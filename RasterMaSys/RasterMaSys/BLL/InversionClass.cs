using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;

namespace RasterMaSys.BLL
{
    /// <summary>
    /// 处理水质反演相关过程类
    /// </summary>
    public class InversionClass
    {
        private readonly RichTextBox _richTextBox;

        public InversionClass(RichTextBox txb)
        {
            this._richTextBox = txb;
        }

        /// <summary>
        /// 获取水质点对应的影像值,返回一个多维数据，每一维存一个波段中所有数据
        /// </summary>
        /// <param name="pFeatureClass">水质要素类</param>
        /// <param name="pRasterDataset">栅格影像数据</param>
        /// <returns>返回数组的数组，每个波段数据为一个数组</returns>
        public double[][] GetImgCellValue(IFeatureClass pFeatureClass, IRasterDataset pRasterDataset)
        {
            this.ShowRunInfo("=======正在获取水质点对应的影像值=======");
            //获取影像波段总数
            IRasterBandCollection pBandCollection = pRasterDataset as IRasterBandCollection;
            int bandCount = pBandCollection.Count;
            this.ShowRunInfo("影像一共"+bandCount.ToString()+"个波段");
            //获取对应坐标像元值
            IFeatureCursor pFeatureCursor = pFeatureClass.Search(new QueryFilterClass(), true);
            //获取要素总数
            int featureCount = pFeatureClass.FeatureCount(new QueryFilterClass());
            this.ShowRunInfo("一共有" + featureCount.ToString() + "个水质采样点");
            //以多维数组存储数据,每个波段的数据为一个数组
            double[][] imgList = new double[bandCount][];
            for (int i = 0; i < bandCount; i++)
            {
                imgList[i] = new double[featureCount];
                IRasterBand pRasterBand = pBandCollection.Item(i);
                string msg = string.Format("波段索引{0}对应波段{1}", i, pRasterBand.Bandname);
                this.ShowRunInfo(msg);
            }

            int count = 0;
            IFeature pFeature = pFeatureCursor.NextFeature();
            while (pFeature != null)
            {
                IGeometry pGeometry = pFeature.Shape;
                IPoint point = pGeometry as IPoint;
                //存储每个点下的所有波段的像元值       
                if (point != null)
                {
                    //使用GP工具获取指定点的像元值,结果为字符串
                    GpToolsClass gpToolsClass = new GpToolsClass();
                    string resultStr = gpToolsClass.GetCellValueByCoordinate(point, pRasterDataset);
                    //分割字符串，转换为数组
                    if (resultStr != null)
                    {
                        string[] s = resultStr.Split(new char[] { '\n' });
                        int sCount = s.Length;
                        //分波段存储
                        for (int i = 0; i < sCount; i++)
                        {
                            imgList[i][count] = double.Parse(s[i]);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < bandCount; i++)
                        {
                            imgList[i][count] = 0;
                        }
                    }
                }
                pFeature = pFeatureCursor.NextFeature();
                count += 1;
            }

            this.ShowRunInfo("=======水质点对应的影像值获取完毕!=======\n");
            return imgList;
        }

        /// <summary>
        /// 获取相关水质字段数据
        /// </summary>
        /// <param name="pFeatureClass">水质要素类</param>
        /// <param name="fieldsList">水质字段列表集合</param>
        /// <returns>以字典的形式返回水质数据，key为水质数据名</returns>
        public Dictionary<string, double[]> GetQualityByFields(IFeatureClass pFeatureClass, List<string> fieldsList)
        {
            this.ShowRunInfo("=======正在获取水质点数据=======");
            //存储每个水质字段的值
            Dictionary<string, double[]> fieldDictionary = new Dictionary<string, double[]>();
            //获取需要的数值参数个数和点位个数
            int fieldCount = fieldsList.Count;
            int featureCount = pFeatureClass.FeatureCount(new QueryFilterClass());

            for (int i = 0; i < fieldCount; i++)
            {
                //查询
                IFeatureCursor pFeatureCursor = pFeatureClass.Search(new QueryFilterClass(), true);
                IFeature pFeature = pFeatureCursor.NextFeature();
                //字段名
                string fieldName = fieldsList[i];
                this.ShowRunInfo(string.Format("正在获取{0}水质数据",fieldName));
                //存储水质数据
                double[] waterArray = new double[featureCount];
                //获取字段索引
                int fieldIndex = pFeatureClass.FindField(fieldName);
                int count = 0;
                while (pFeature != null)
                {
                    string value = pFeature.Value[fieldIndex].ToString();
                    waterArray[count] = double.Parse(value);
                    pFeature = pFeatureCursor.NextFeature();
                    count += 1;
                }
                fieldDictionary.Add(fieldName, waterArray);
            }
            this.ShowRunInfo("=======水质点数据获取完毕!=======\n");
            return fieldDictionary;
        }

        /// <summary>
        /// 计算给定数据的平均值
        /// </summary>
        /// <param name="dataArray">double类型的数组</param>
        /// <returns>数组的平均值</returns>
        private double CalculateAverage(double[] dataArray)
        {
            double average = 0;
            int length = dataArray.Length;
            if (length > 0)
            {
                double sum = dataArray.Sum();
                average = sum / length;
            }
            return average;
        }

        /// <summary>
        /// 计算每一个参数与波段间的相关性,影像为Y，水质参数为X
        /// </summary>
        /// <param name="imgArray">影像数据集，double类型数组</param>
        /// <param name="waterArray">水质数据集，double类型数组</param>
        /// <returns>相关系数</returns>
        public double CalculateRelativity(double[] imgArray, double[] waterArray)
        {
            double waterAve = CalculateAverage(imgArray);
            double imgAve = CalculateAverage(waterArray);
            int length = imgArray.Length;

            double correlation = 0;
            double value1 = 0;
            double value2 = 0;
            double value3 = 0;
            for (int i = 0; i < length; i++)
            {
                //sum（(x-x平均数)*(y-y平均数) ）
                double temp1 = (imgArray[i] - waterAve) * (waterArray[i] - imgAve);
                value1 += temp1;
                //(x-x平均数)的平方的和
                value2 += Math.Pow((imgArray[i] - waterAve), 2);
                // (y-y平均数) 的平方的和
                value3 += Math.Pow((waterArray[i] - imgAve), 2);
            }
            correlation = value1 / Math.Sqrt(value2) / Math.Sqrt(value3);
            //返回R方
            return correlation;
        }

        /// <summary>
        /// 输出信息到richtextbox
        /// </summary>
        /// <param name="msg">字符串信息</param>
        private void ShowRunInfo(string msg)
        {
            this._richTextBox.Text += msg + "\n";
        }

        /// <summary>
        /// 计算相关性主入口,计算每个波段与每个水质参见间的相关性，结果输出相关性到信息窗口
        /// </summary>
        /// <param name="pFeatureClass">要素类</param>
        /// <param name="pRasterDataset">栅格数据</param>
        /// <param name="fieldsList">字段列表</param>
        public void CalculateRelativityInit(IFeatureClass pFeatureClass, IRasterDataset pRasterDataset,
            List<string> fieldsList)
        {
            double[][] imgArryDoubles = this.GetImgCellValue(pFeatureClass, pRasterDataset);
            Dictionary<string, double[]> waterDictionary = this.GetQualityByFields(pFeatureClass, fieldsList);

            int bandCount = imgArryDoubles.Length;
            this.ShowRunInfo(string.Format("{0,-8}{1,-10}{2,-10}", "波段索引", "水质参数", "相关系数"));
            for (int i = 0; i < bandCount; i++)
            {
                //获取一个波段的所有数据
                double[] bandCollection = imgArryDoubles[i];
                foreach (string key in waterDictionary.Keys)
                {
                    //获取一个水质参数
                    double[] waterQuality = waterDictionary[key];
                    double correlation = this.CalculateRelativity(bandCollection, waterQuality);
                    string msg = string.Format("{0,-12}{1,-14}{2,-10}", i, key, correlation);
                    this.ShowRunInfo(msg);
                }
            }
        }
    }
}
