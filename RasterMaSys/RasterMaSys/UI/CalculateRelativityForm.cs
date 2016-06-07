using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ESRI.ArcGIS.Geodatabase;
using RasterMaSys.BLL;
using RasterMaSys.Util;

namespace RasterMaSys.UI
{
    public partial class CalculateRelativityForm : Form
    {
        public CalculateRelativityForm()
        {
            InitializeComponent();
            //初始化水质数据列表
            InitInput.InitWaterDataComboBox(this.cmb_QualityList);
        }

        //选择影像
        private void btn_selectImg_Click(object sender, EventArgs e)
        {
            this.txb_inputImg.Text = InitInput.IninSelectImg("landsat影像|*.tif|所有文件|*.*");
        }

        //计算相关性
        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            string imgPath = this.txb_inputImg.Text;
            string shapefileName = this.cmb_QualityList.SelectedValue.ToString();

            List<string> waterFieldList = new List<string>();
            if (this.checkBox_COD.Checked)
            {
                waterFieldList.Add("CODmn");
            }
            if (checkBox_NH4N.Checked)
            {
                waterFieldList.Add("NH4_N");
            }
            if (checkBox_TN.Checked)
            {
                waterFieldList.Add("TN");
            }
            if (checkBox_TP.Checked)
            {
                waterFieldList.Add("TP");
            }
            //获取栅格数据集
            IRasterDataset pRasterDataset = GetDataClass.GetRasterDataset(imgPath);
            //获取矢量要素
            IFeatureClass pFeatureClass = GetDataClass.GetFeatureClassByName(shapefileName);
            //计算相关系数
            InversionClass pInversionClass = new InversionClass(this.richtxb_result);
            pInversionClass.CalculateRelativityInit(pFeatureClass, pRasterDataset, waterFieldList);
        }

        //取消按钮
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //清除输出信息窗口所有信息
        private void btn_clearInfo_Click(object sender, EventArgs e)
        {
            this.richtxb_result.Text = "";
        }

        //保存输出信息窗口信息
        private void btn_saveInfo_Click(object sender, EventArgs e)
        {
            string saveFileName = InitInput.InitSaveFile("文本文件|*.txt");
            if (saveFileName!=null)
            {
                string info = this.richtxb_result.Text.Replace("\n", "\r\n");
                StreamWriter sw=new StreamWriter(saveFileName);
                sw.Write(info);
                sw.Close();
            }
        }
    }
}
