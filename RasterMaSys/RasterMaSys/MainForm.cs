using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using RasterMaSys.BLL;
using RasterMaSys.UI;

namespace RasterMaSys
{
    //主窗口
    public partial class MainForm : Form
    {
        private ILayer _pTocLayer;

        public MainForm()
        {
            InitializeComponent();
        }

        //影像检索按钮点击事件
        private void searchBox_Click(object sender, EventArgs e)
        {
            IMap pMap = this.axMapControl1.Map;
            var rasterMaForm = new RasterMaForm(pMap);
            rasterMaForm.Show();
        }

        //添加影像
        private void addImgBox_Click(object sender, EventArgs e)
        {
            AddInfoForm addInfoForm = new AddInfoForm(null, null);
            addInfoForm.Show();
        }

        //影像列表
        private void listImg_Click(object sender, EventArgs e)
        {
            IMap pMap = this.axMapControl1.Map;
            ImgListForm imgListForm=new ImgListForm(pMap);
            imgListForm.Show();
        }

        //TOCControl的右键事件
        private void axTOCControl1_OnMouseDown(object sender, ITOCControlEvents_OnMouseDownEvent e)
        {
            //如果图层数大于0
            if (axMapControl1.LayerCount > 0)
            {
                //如果右键单击，显示右键菜单
                if (e.button == 2)
                {
                    var pItem = esriTOCControlItem.esriTOCControlItemNone;
                    IBasicMap pMap = null;
                    object unk = null, data = null;
                    //内容表控件中的这个方法是根据鼠标的点击位置返回内容表中的项
                    axTOCControl1.HitTest(e.x, e.y, ref pItem, ref pMap, ref _pTocLayer, ref unk, ref data);
                    //下面是判断鼠标选中的项是什么类型的项目（通过esriTOCControlItem的枚举值我们可以知道
                    if (pItem == esriTOCControlItem.esriTOCControlItemLayer)
                    {
                        contextMenuStrip1.Show(axTOCControl1, e.x, e.y);
                    }
                }
            }
        }

        //sender是删除菜单
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_pTocLayer != null)
            {
                axMapControl1.Map.DeleteLayer(_pTocLayer);
            }
        }
     
        //  刷新按钮，刷新波段选择
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //首先获取图层列表
            //获取用户选择的展示要求，灰度还是RGB
            //获取波段设置
            //刷新显示
            var selectLayerName = cmb_layerList.SelectedItem.ToString();

            //store band setting
            var bandSet = new int[3];
            bandSet[0] = cmb_bandR.SelectedIndex;
            bandSet[1] = cmb_bandG.SelectedIndex;
            bandSet[2] = cmb_bandB.SelectedIndex;

            //process Method
            var imgShow = new DataShowControl(axMapControl1.Map);
            imgShow.SetImgBand(selectLayerName, bandSet);
        }

        //点击选择图层时，更新图层列表
        private void cmb_layerList_Click(object sender, EventArgs e)
        {
            var pMap = axMapControl1.Map;
            var layerCount = axMapControl1.LayerCount;
            cmb_layerList.Items.Clear();
            if (layerCount > 0)
            {
                for (var i = 0; i < layerCount; i++)
                {
                    var pLayer = pMap.Layer[i];
                    var layerName = pLayer.Name;
                    if (!cmb_layerList.Items.Contains(layerName))
                    {
                        cmb_layerList.Items.Add(layerName);
                    }
                }
            }
        }

        // 辐射定标按钮处理函数
        // 输入的路径以及保存路径不能包含中文字符,否则会报错
        private void radCalibrationBox_Click(object sender, EventArgs e)
        {
            var radCalibrationForm = new RadCalibrationForm(axMapControl1);
            radCalibrationForm.Show();
        }

        //大气校正
        private void atmosphCorrectionBox_Click(object sender, EventArgs e)
        {
            var quickAtmo = new QuickAtmoCorrectionForm(axMapControl1);
            quickAtmo.Show();
        }

        //湖区提取
        private void lakeExtractionBox_Click(object sender, EventArgs e)
        {
            CalhonghuBoundaryForm calhonghuBoundary = new CalhonghuBoundaryForm(this.axMapControl1);
            calhonghuBoundary.Show();
        }

        //水体面积变化
        private void picBox_areaChange_Click(object sender, EventArgs e)
        {
            GetChartDataClass chartData = new GetChartDataClass();
            Dictionary<DateTime, double> dataDictionary = chartData.GetAreaData();

            if (dataDictionary.Count > 0)
            {
                AreaChartForm areaChartForm = new AreaChartForm();
                areaChartForm.BandingData(dataDictionary);
                areaChartForm.Show();
            }
            else
            {
                MessageBox.Show("未选择有效数据!");
            }
        }

        //查看水质分布
        private void picBox_waterQuality_Click(object sender, EventArgs e)
        {
            WaterQualityDistributionForm waterQualityForm = new WaterQualityDistributionForm();
            waterQualityForm.Show();
        }

        //计算相关性
        private void picBox_CalculateRelativity_Click(object sender, EventArgs e)
        {
            CalculateRelativityForm calculateRelativityForm = new CalculateRelativityForm();
            calculateRelativityForm.Show();
        }

        //回归分析
        private void picBox_Regression_Click(object sender, EventArgs e)
        {
            RegressionForm regressionForm=new RegressionForm();
            regressionForm.Show();
        }

        //插值分析
        private void picBox_interpolation_Click(object sender, EventArgs e)
        {
            InterpolationForm interpolationForm=new InterpolationForm();
            interpolationForm.Show();
        }
    }
}