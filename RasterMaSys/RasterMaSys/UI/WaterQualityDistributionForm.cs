using System;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using RasterMaSys.BLL;
using RasterMaSys.Util;

namespace RasterMaSys.UI
{
    public partial class WaterQualityDistributionForm : Form
    {
        public WaterQualityDistributionForm()
        {
            InitializeComponent();
            //初始化地图加载
            InitMapCtr();
            //初始化属性选择列表
            InitInput.InitQualityComboBox(this.cmb_FieldList);
            InitInput.InitWaterDataComboBox(this.cmb_dataList);
        }


        //初始化加载底图
        private void InitMapCtr()
        {
            IWorkspaceFactory pWorkspaceFactory = new ShapefileWorkspaceFactoryClass();
            IWorkspace pWorkspace = pWorkspaceFactory.OpenFromFile(@"D:\RasterMaSysTemp\hhData", 0);
            IFeatureWorkspace pFeatureWorkspace = pWorkspace as IFeatureWorkspace;
            if (pFeatureWorkspace != null)
            {
                IFeatureClass pFeatureClass = pFeatureWorkspace.OpenFeatureClass("洪湖水域.shp");
                IFeatureLayer pFeatureLayer = new FeatureLayerClass();
                pFeatureLayer.Name = "洪湖水域";
                pFeatureLayer.FeatureClass = pFeatureClass;
                //设置为湖泊符号渲染
                IGeoFeatureLayer pGeoFeatureLayer = (IGeoFeatureLayer)pFeatureLayer;
                IFillSymbol pFillSymbol = new SimpleFillSymbolClass();
                pFillSymbol.Color = DataShowControl.GetColor(151, 219, 242);
                ILineSymbol pLineSymbol = new SimpleLineSymbolClass();
                pLineSymbol.Color = DataShowControl.GetColor(64, 101, 235);
                pLineSymbol.Width = 0.4;
                pFillSymbol.Outline = pLineSymbol;
                ISimpleRenderer pSimpleRenderer = new SimpleRendererClass();
                pSimpleRenderer.Symbol = (ISymbol)pFillSymbol;
                pGeoFeatureLayer.Renderer = pSimpleRenderer as IFeatureRenderer;
                //添加图层
                axMapControl1.Map.AddLayer(pGeoFeatureLayer);
                axMapControl1.ActiveView.Extent = axMapControl1.ActiveView.FullExtent;
            }
        }

        //查看按钮
        private void btn_showData_Click(object sender, EventArgs e)
        {
            //先清除底图之外的图层
            int count = this.axMapControl1.Map.LayerCount;
            if (count > 1)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    ILayer layer = this.axMapControl1.get_Layer(i);
                    if (layer.Name != "洪湖水域")
                    {
                        this.axMapControl1.Map.DeleteLayer(layer);
                    }
                }
            }
            //获取选择信息
            string selectShp = this.cmb_dataList.SelectedValue.ToString();
            string selectFiled = this.cmb_FieldList.SelectedValue.ToString();
            //打开数据，获取要素图层
            IWorkspaceFactory pWorkspaceFactory = new ShapefileWorkspaceFactoryClass();
            IWorkspace pWorkspace = pWorkspaceFactory.OpenFromFile(@"D:\RasterMaSysTemp\hhWaterQuality", 0);
            IFeatureWorkspace pFeatureWorkspace = pWorkspace as IFeatureWorkspace;
            if (pFeatureWorkspace != null)
            {
                IFeatureClass pFeatureClass = pFeatureWorkspace.OpenFeatureClass(selectShp);
                IFeatureLayer pFeatureLayer = new FeatureLayerClass();
                pFeatureLayer.FeatureClass = pFeatureClass;
                pFeatureLayer.Name = selectShp;
                if (pFeatureClass != null)
                {
                    //添加水质数据并分级渲染显示
                    DataShowControl dataShow = new DataShowControl(this.axMapControl1.Map);
                    dataShow.SimpleRenderByColor(pFeatureLayer, selectFiled);
                }
            }
        }

    }

}
