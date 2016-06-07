using RasterMaSys.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using RasterMaSys.BLL;

namespace RasterMaSys.UI
{
    public partial class InterpolationForm : Form
    {
        public InterpolationForm()
        {
            InitializeComponent();

            this._waterFieldsDictionary = new Dictionary<string, string>();
            _waterFieldsDictionary.Add("总磷", "TP");
            _waterFieldsDictionary.Add("总氮", "TN");
            _waterFieldsDictionary.Add("氨氮", "NH4_N");
            _waterFieldsDictionary.Add("化学需氧量", "CODmn");
         InitPageLayoutSize();
           
        }

        private readonly Dictionary<string, string> _waterFieldsDictionary;
        private string _labelFun;
        //选择栅格影像
        private void btn_selectImg_Click(object sender, EventArgs e)
        {
            this.txb_inputImg.Text = InitInput.IninSelectImg("栅格数据集|*.tif");
        }
        //保存插值结果影像
        private void btn_save_Click(object sender, EventArgs e)
        {
            this.txb_output.Text = InitInput.InitSaveFile("栅格数据集|*.tif");
        }
        //插值
        private void btn_interpolation_Click(object sender, EventArgs e)
        {
          
            this.label_fun.Text = "";
            //获取加密点矢量
            IWorkspaceFactory pWorkspaceFactory = new ShapefileWorkspaceFactoryClass();
            IWorkspace pWorkspace = pWorkspaceFactory.OpenFromFile(@"D:\RasterMaSysTemp\hhData", 0);
            IFeatureWorkspace pFeatureWorkspace = pWorkspace as IFeatureWorkspace;
            IFeatureClass pFeatureClass = pFeatureWorkspace.OpenFeatureClass("加密点.shp");
            //获取栅格波段
            IRasterDataset pRasterDataset = GetDataClass.GetRasterDataset(this.txb_inputImg.Text);
            InversionClass inversionClass = new InversionClass(new RichTextBox());
            double[][] imgAllBands = inversionClass.GetImgCellValue(pFeatureClass, pRasterDataset);

            //所有波段组合的值
            Dictionary<string, double[]> imgBandscomb = calculateBandscomb(imgAllBands);

            string selectMethod = this.GetSelectRadText(gb_regressionMethod);
            string selectFieldRad = this.GetSelectRadText(gb_waterFields);
            string selectWaterField = _waterFieldsDictionary[selectFieldRad];

             _labelFun = string.Format("回归拟合方程为:{0}=", selectWaterField);
            //获取结果值
            if (selectMethod == "二次模型" || selectMethod == "指数模型")
            {
                MessageBox.Show("请选择其他拟合算法");
                return;
            }
            List<double> resultList = this.GetResultValue(imgBandscomb, selectMethod,imgAllBands[0].Length);
            //显示拟合函数
            this.label_fun.Text += _labelFun;
            
            //更新加密点属性
            if (resultList.Count == 0)
            {
                MessageBox.Show("获取数据失败");
                return;
            }
            this.UpdatePointValue(pFeatureClass,selectWaterField,resultList);
            
            //插值
            if (this.txb_output.Text.Trim() != "")
            {
                GpToolsClass gpTools = new GpToolsClass();
                gpTools.CalKriging(selectWaterField, this.txb_output.Text);
            }
            //如果生成插值图成功，则添加显示
            if (File.Exists(this.txb_output.Text))
            {
                if (File.Exists(@"D:\RasterMaSysTemp\hhData\水质插值专题图.mxd"))
                {
                    MapDocument mapDoc = new MapDocumentClass();
                    mapDoc.Open(@"D:\RasterMaSysTemp\hhData\水质插值专题图.mxd", "");
                    axPageLayoutControl1.PageLayout = mapDoc.PageLayout;

                    IMap pMap = mapDoc.get_Map(0);
                    IRasterLayer pRasterLayer = pMap.Layer[0] as IRasterLayer;
                    pRasterLayer.CreateFromFilePath(this.txb_output.Text);
                    axPageLayoutControl1.PageLayout.ZoomToWhole();
                    IPage page = axPageLayoutControl1.Page;
                    axPageLayoutControl1.Refresh();
                }
                else
                {
                    IMap pMap = this.axPageLayoutControl1.ActiveView.FocusMap;
                    IRasterLayer pRasterLayer=new RasterLayerClass();
                    pRasterLayer.CreateFromFilePath(this.txb_output.Text);
                    pMap.AddLayer(pRasterLayer);
                }
             
            }
            else
            {
                MessageBox.Show("处理失败!");
            }

        }

        //保存图片
        private void btn_saveImg_Click(object sender, EventArgs e)
        {
            IMap pMap = this.axPageLayoutControl1.ActiveView.FocusMap;
            int count = pMap.LayerCount;
            if (count > 0)
            {
                string savePath = InitInput.InitSaveFile("bmp图像|*.bmp");
                DataShowControl.SaveCurrentToImage(this.axPageLayoutControl1, savePath);
                MessageBox.Show("图像保存成功!");
            }
        }

        private void InitPageLayoutSize()
        {
            IMap pMap = axPageLayoutControl1.ActiveView.FocusMap;
            IGraphicsContainer pGraphicsContainer = axPageLayoutControl1.GraphicsContainer;
            IMapFrame pMapFrame = pGraphicsContainer.FindFrame(pMap) as IMapFrame;

            IElement pElement = pMapFrame as IElement;
            IEnvelope pEnvelope = new EnvelopeClass();
            pEnvelope.PutCoords(0.75, 0.75, 28.063, 19.248);
            pElement.Geometry = pEnvelope as IGeometry;

            IPage page = axPageLayoutControl1.Page;
            page.PutCustomSize(29, 20);
            axPageLayoutControl1.ActiveView.Refresh();
        }


        //获取根据选择的公式计算每个点的反演值
        private List<double> GetResultValue(Dictionary<string, double[]> imgBandscomb, string selectMethod,int count)
        {
            Dictionary<string, double[]> selectParam = new Dictionary<string, double[]>();
            double[] ra = new double[count];
            //n7为常量值
            double n7 = (double)num7.Value;
            //结果列表
            var result = (from a in ra select a + n7).ToList();

            //获取选择的数据
            if (selectMethod == "一元线性" || selectMethod == "多元线性")
            {
                string str3 = cmb3.Text;
                if (num3.Value != (decimal)0.000 && str3 != "")
                {
                    if (!selectParam.ContainsKey(str3))
                    {
                        double[] bd = imgBandscomb[str3];
                        double n = (double)num3.Value;
                        //系数乘以波段组合的每个值存到字典里
                        var l = (from d in bd select n * d).ToArray();
                        selectParam.Add(str3, l);
                        _labelFun += string.Format("({0})*({1})+", num3.Value, str3);
                    }
                }
                string str4 = cmb4.Text;
                if (num4.Value != (decimal)0.000 && str4 != "")
                {
                    if (!selectParam.ContainsKey(str4))
                    {
                        double[] bd = imgBandscomb[str4];
                        double n = (double)num4.Value;
                        var l = (from d in bd select n * d).ToArray();
                        selectParam.Add(str4, l);
                        _labelFun += string.Format("({0})*({1})+", num4.Value, str4);
                    }
                }
                string str5 = cmb5.Text;
                if (num5.Value != (decimal)0.000 && str5 != "")
                {
                    if (!selectParam.ContainsKey(str5))
                    {
                        double[] bd = imgBandscomb[str5];
                        double n = (double)num5.Value;
                        var l = (from d in bd select n * d).ToArray();
                        selectParam.Add(str5, l);
                        _labelFun += string.Format("({0})*({1})+", num5.Value, str5);
                    }
                }
                string str6 = cmb6.Text;
                if (num6.Value != (decimal)0.000 && str6 != "")
                {
                    if (!selectParam.ContainsKey(str6))
                    {
                        double[] bd = imgBandscomb[str6];
                        double n = (double)num6.Value;
                        var l = (from d in bd select n * d).ToArray();
                        selectParam.Add(str6, l);
                        _labelFun += string.Format("({0})*({1})+", num6.Value, str6);
                    }
                }

                //常量
                _labelFun += string.Format("({0})", num7.Value.ToString("0.###"));

                int resultCount = result.Count;
                var keys = selectParam.Keys;
                //将字典中的值累加
                for (int i = 0; i < resultCount; i++)
                {
                    foreach (var key in keys)
                    {
                        result[i] += selectParam[key][i];
                    }
                }
            }
            return result;
        } 

        //更新加密点属性
        private void UpdatePointValue(IFeatureClass pFeatureClass,string field, List<double> resultList )
        {
            ITable pTable = pFeatureClass as ITable;
            if (pTable != null)
            {
                int fieldIndex = pTable.FindField(field);
                ICursor pCursor = pTable.Update(null, false);
                IRow pRow = pCursor.NextRow();
                int rowCount = pTable.RowCount(null);

                for (int i = 0; i < rowCount; i++)
                {
                    pRow.set_Value(fieldIndex, resultList[i]);
                    pCursor.UpdateRow(pRow);
                    pRow = pCursor.NextRow();
                }
            }
        }

        //获取数据字典
        private Dictionary<string, double[]> calculateBandscomb(double[][] imgAllBands)
        {
            Dictionary<string, double[]> imgBandscomb = new Dictionary<string, double[]>();
            int b1Count = imgAllBands[0].Length;
            imgBandscomb.Add("b1", imgAllBands[0]);
            imgBandscomb.Add("b2", imgAllBands[1]);
            imgBandscomb.Add("b3", imgAllBands[2]);
            imgBandscomb.Add("b4", imgAllBands[3]);
            imgBandscomb.Add("b5", imgAllBands[4]);
            imgBandscomb.Add("b6", imgAllBands[5]);
            if (imgAllBands.Length > 6)
            {
                imgBandscomb.Add("b7", imgAllBands[6]);
            }

            double[] temp1 = new double[b1Count];
            double[] temp2 = new double[b1Count];
            double[] temp3 = new double[b1Count];
            double[] temp4 = new double[b1Count];
            double[] temp5 = new double[b1Count];
            double[] temp6 = new double[b1Count];

            for (int i = 0; i < b1Count; i++)
            {
                //b1/b2
                if (Math.Abs(imgAllBands[1][i]) > 0.001)
                {
                    temp1[i] = imgAllBands[0][i] / imgAllBands[1][i];
                }
                else
                {
                    temp1[i] = 0;
                }
                //b1/b4
                if (Math.Abs(imgAllBands[3][i]) > 0.001)
                {
                    temp2[i] = imgAllBands[0][i] / imgAllBands[3][i];
                    //b2/b4
                    temp3[i] = imgAllBands[1][i] / imgAllBands[3][i];
                }
                else
                {
                    temp2[i] = 0;
                    temp3[i] = 0;
                }
                //b4/(b1+b2)
                double a = imgAllBands[0][i] + imgAllBands[1][i];
                if (Math.Abs(a) > 0.001)
                {
                    temp4[i] = imgAllBands[3][i] / a;
                }
                else
                {
                    temp4[i] = 0;
                }

                //b4/(b1+b3)
                double b = imgAllBands[0][i] + imgAllBands[2][i];
                if (Math.Abs(b) > 0.001)
                {
                    temp5[i] = imgAllBands[3][i] / b;
                }
                else
                {
                    temp5[i] = 0;
                }
                //(b4-b2)/(b4+b2)
                double c = imgAllBands[3][i] + imgAllBands[1][i];
                double d = imgAllBands[3][i] - imgAllBands[1][i];
                if (Math.Abs(c) > 0.001)
                {
                    temp6[i] = d / c;
                }
                else
                {
                    temp6[i] = 0;
                }
            }

            imgBandscomb.Add("b1/b2", temp1);
            imgBandscomb.Add("b1/b4", temp2);
            imgBandscomb.Add("b2/b4", temp3);
            imgBandscomb.Add("b4/(b1+b2)", temp4);
            imgBandscomb.Add("b4/(b1+b3)", temp5);
            imgBandscomb.Add("(b4-b2)/(b4+b2)", temp6);

            return imgBandscomb;
        }

        //获取选择的按钮的字符串
        private string GetSelectRadText(GroupBox groupBox)
        {
            string str = "";
            foreach (var rad in groupBox.Controls)
            {
                RadioButton radioButton = rad as RadioButton;
                if (radioButton != null && radioButton.Checked)
                {
                    str = radioButton.Text.ToString();
                }
            }
            return str;
        }
    }
}
