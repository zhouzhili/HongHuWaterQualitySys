using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Geodatabase;
using RasterMaSys.BLL;
using RasterMaSys.Util;
using System.IO;

namespace RasterMaSys.UI
{
    public partial class RegressionForm : Form
    {
        public RegressionForm()
        {
            InitializeComponent();
            InitInput.InitWaterDataComboBox(this.cmb_QualityList);
            this._waterFieldsDictionary = new Dictionary<string, string>();
            _waterFieldsDictionary.Add("总磷", "TP");
            _waterFieldsDictionary.Add("总氮", "TN");
            _waterFieldsDictionary.Add("氨氮", "NH4_N");
            _waterFieldsDictionary.Add("化学需氧量", "CODmn");
        }
        //水质字典转换
        private readonly Dictionary<string, string> _waterFieldsDictionary;
        //存储波段组合名称
        private List<string> _bandCombList;

        //选择影像
        private void btn_selectImg_Click(object sender, EventArgs e)
        {
            this.txb_inputImg.Text = InitInput.IninSelectImg("栅格数据集|*.tif");
        }

        //计算回归模型
        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            //输入影像
            IRasterDataset pRasterDataset = GetDataClass.GetRasterDataset(this.txb_inputImg.Text);
            if (pRasterDataset == null)
            {
                MessageBox.Show("输入影像数据不能为空!");
                return;
            }
            //水质期数
            IFeatureClass pFeatureClass = GetDataClass.GetFeatureClassByName(this.cmb_QualityList.SelectedValue.ToString());
            if (pFeatureClass == null)
            {
                MessageBox.Show("选择矢量数据不能为空!");
                return;
            }
            //反演字段
            string selectWaterField = _waterFieldsDictionary[GetSelectRadText(gb_waterFields)];
            List<string> fieldsList = new List<string>() { selectWaterField };
            //获取水质数据和全部影像波段数据
            InversionClass inversionClass = new InversionClass(this.richtxb_info);
            double[][] imgDataArray = inversionClass.GetImgCellValue(pFeatureClass, pRasterDataset);
            Dictionary<string, double[]> waterDataDictionary = inversionClass.GetQualityByFields(pFeatureClass, fieldsList);

            //获取需要反演的水质参数
            double[] selectWaterData = waterDataDictionary[selectWaterField];
            //获取选择的波段组合数据
            double[][] selectBandsCombData = GetSelectBandData(imgDataArray);
            //获取选择的反演方法
            string regressionMethod = GetSelectRadText(gb_regressionMethod);

            
            if (regressionMethod == "一元线性")
            {
                AddInfoToRichTextBox("============开始反演============");
                AddInfoToRichTextBox("反演波段为:" + selectWaterField);
                AddInfoToRichTextBox("反演方法为一元线性，回归模型为Y=b+a*X");
                int bandCombCount = selectBandsCombData.Length;
                for (int i = 0; i < bandCombCount; i++)
                {
                    double[] resultDoubles = RegressionClass.SimpleLinearRegression(selectBandsCombData[i],
                        selectWaterData);
                    AddInfoToRichTextBox(string.Format("{0}:自变量为{1}", i + 1, _bandCombList[i]));
                    AddInfoToRichTextBox(string.Format("{0,7}{1,7}{2,7}{3,7}{4,7}{5,7}{6,7}{7,7}", "回归系数b", "回归系数a",
                        "偏差平方和", "平均标准偏差", "回归平方和", "最大偏差", "最小偏差", "偏差平均值"));
                    AddInfoToRichTextBox(string.Format("{0,10}{1,10}{2,11}{3,11}{4,12}{5,13}{6,12}{7,12}",
                        resultDoubles[0].ToString("0.###"), resultDoubles[1].ToString("0.###"),
                        resultDoubles[2].ToString("0.###"), resultDoubles[3].ToString("0.###"),
                        resultDoubles[4].ToString("0.###"), resultDoubles[5].ToString("0.###"),
                        resultDoubles[6].ToString("0.###"), resultDoubles[7].ToString("0.###")));
                }
                AddInfoToRichTextBox("============反演结束============\n");
            }
            else if (regressionMethod == "多元线性")
            {
                AddInfoToRichTextBox("============开始反演============");
               //获取反演结果
                List<double[]> resultList = RegressionClass.MultiLinearRegression(selectBandsCombData, selectWaterData);
                //输出
                AddInfoToRichTextBox("反演波段为:" + selectWaterField);
                AddInfoToRichTextBox("反演方法为多元线性,回归模型为:");
                StringBuilder strBuilder1 = new StringBuilder();
                strBuilder1.Append("Y=");
                int bandComCount = _bandCombList.Count;
                for (int i = 0; i < bandComCount; i++)
                {
                    strBuilder1.AppendFormat("a{0}*{1}+", i, _bandCombList[i]);
                }
                strBuilder1.AppendFormat("a{0}", bandComCount);
                AddInfoToRichTextBox(strBuilder1.ToString());
                //模型参数
                double[] a = resultList[0];
                AddInfoToRichTextBox(string.Format("模型参数a0到a{0}分别为:",bandComCount));
                StringBuilder strbBuilder=new StringBuilder();
                int alength = a.Length;
                for (int i = 0; i < alength; i++)
                {
                    strbBuilder.Append(a[i].ToString("0.###") + "   ");
                }
                AddInfoToRichTextBox(strbBuilder.ToString());
                //模型偏差
                AddInfoToRichTextBox("\n模型偏差:");
                double[] dt = resultList[1];
                AddInfoToRichTextBox(string.Format("{0,7}{1,7}{2,7}{3,7}", "偏差平方和", "平均标准偏差", "相关系数", "回归平方和"));
                AddInfoToRichTextBox(string.Format("{0,10}{1,10}{2,14}{3,12}", dt[0].ToString("0.###"),
                    dt[1].ToString("0.###"), dt[2].ToString("0.###"), dt[3].ToString("0.###")));
                AddInfoToRichTextBox("============反演结束============");
            }
          }

        //清除信息
        private void btn_clearInfo_Click(object sender, EventArgs e)
        {
            this.richtxb_info.Text = "";
        }

        //保存信息
        private void btn_saveInfo_Click(object sender, EventArgs e)
        {
            string saveFileName = InitInput.InitSaveFile("文本文件|*.txt");
            if (saveFileName != null)
            {
                string info = this.richtxb_info.Text.Replace("\n", "\r\n");
                StreamWriter sw = new StreamWriter(saveFileName);
                sw.Write(info);
                sw.Close();
            }
        }

        //取消，关闭窗口
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// 获取选择的所有波段组合数据
        /// </summary>
        /// <param name="allImgBands"></param>
        /// <returns>返回波段组合数据数组</returns>
        private double[][] GetSelectBandData(double[][] allImgBands)
        {
            List<double[]> imgList = new List<double[]>();
            _bandCombList = new List<string>();
            if (ck_b1.Checked)
            {
                imgList.Add(allImgBands[0]);
                _bandCombList.Add("b1");
            }
            if (ck_b2.Checked)
            {
                imgList.Add(allImgBands[1]);
                _bandCombList.Add("b2");
            }
            if (ck_b3.Checked)
            {
                imgList.Add(allImgBands[2]);
                _bandCombList.Add("b3");
            }
            if (ck_b4.Checked)
            {
                imgList.Add(allImgBands[3]);
                _bandCombList.Add("b4");
            }
            if (ck_b5.Checked)
            {
                imgList.Add(allImgBands[4]);
                _bandCombList.Add("b5");
            }
            if (ck_b6.Checked)
            {
                imgList.Add(allImgBands[5]);
                _bandCombList.Add("b6");
            }
            //landsat7只有6个波段参与，landsat8有7个波段
            int bandsCount = allImgBands.Length;
            if (bandsCount >= 7 && ck_b7.Checked)
            {
                imgList.Add(allImgBands[6]);
                _bandCombList.Add("b7");
            }


            int dataCount = allImgBands[0].Length;
            //b1/b2
            if (ck1.Checked)
            {
                double[] temp = new double[dataCount];
                for (int i = 0; i < dataCount; i++)
                {
                    //double类型不能直接和0比较，绝对值小于0.001则认为=0
                    if (Math.Abs(allImgBands[1][i]) > 0.001)
                    {
                        temp[i] = allImgBands[0][i] / allImgBands[1][i];
                    }
                    else
                    {
                        temp[i] = 0;
                    }
                }
                imgList.Add(temp);
                _bandCombList.Add("b1/b2");
            }
            //b1/b4
            if (ck2.Checked)
            {
                double[] temp = new double[dataCount];
                for (int i = 0; i < dataCount; i++)
                {
                    if (Math.Abs(allImgBands[3][i]) > 0.001)
                    {
                        temp[i] = allImgBands[0][i] / allImgBands[3][i];
                    }
                    else
                    {
                        temp[i] = 0;
                    }
                }
                imgList.Add(temp);
                _bandCombList.Add("b1/b4");
            }
            //b2/b4
            if (ck3.Checked)
            {
                double[] temp = new double[dataCount];
                for (int i = 0; i < dataCount; i++)
                {
                    if (Math.Abs(allImgBands[3][i]) > 0.001)
                    {
                        temp[i] = allImgBands[1][i] / allImgBands[3][i];
                    }
                    else
                    {
                        temp[i] = 0;
                    }
                }
                imgList.Add(temp);
                _bandCombList.Add("b2/b4");
            }
            //(b4-b2)/(b4+b2)
            if (ck4.Checked)
            {
                double[] temp = new double[dataCount];
                for (int i = 0; i < dataCount; i++)
                {
                    //b4-b2
                    double a = allImgBands[3][i] - allImgBands[1][i];
                    //b4+b2
                    double b = allImgBands[3][i] + allImgBands[1][i];
                    if (Math.Abs(b) > 0.001)
                    {
                        temp[i] = a / b;
                    }
                    else
                    {
                        temp[i] = 0;
                    }
                }
                imgList.Add(temp);
                _bandCombList.Add("(b4-b2)/(b4+b2)");
            }
            // b4/(b1+b2)
            if (ck5.Checked)
            {
                double[] temp = new double[dataCount];
                for (int i = 0; i < dataCount; i++)
                {
                    //b4
                    double a = allImgBands[3][i];
                    //b1+b2
                    double b = allImgBands[0][i] + allImgBands[1][i];
                    if (Math.Abs(b) > 0.001)
                    {
                        temp[i] = a / b;
                    }
                    else
                    {
                        temp[i] = 0;
                    }
                }
                imgList.Add(temp);
                _bandCombList.Add("b4/(b1+b2)");
            }
            // b4/(b1+b3)
            if (ck6.Checked)
            {
                double[] temp = new double[dataCount];
                for (int i = 0; i < dataCount; i++)
                {
                    //b4
                    double a = allImgBands[3][i];
                    //b1+b3
                    double b = allImgBands[0][i] + allImgBands[2][i];
                    if (Math.Abs(b) > 0.001)
                    {
                        temp[i] = a / b;
                    }
                    else
                    {
                        temp[i] = 0;
                    }
                }
                imgList.Add(temp);
                _bandCombList.Add("b4/(b1+b3)");
            }

            int listCount = imgList.Count;
            double[][] resultSelectData = new double[listCount][];
            if (listCount > 0)
            {
                for (int i = 0; i < listCount; i++)
                {
                    resultSelectData[i] = imgList[i];
                }
            }
            return resultSelectData;
        }

        /// <summary>
        /// 返回选择的radioButton的Text
        /// </summary>
        /// <param name="groupBox">groupBox</param>
        /// <returns>字符串</returns>
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

        //向信息窗输出信息
        private void AddInfoToRichTextBox(string msg)
        {
            this.richtxb_info.Text += msg + "\n";
        } 
    }
}
