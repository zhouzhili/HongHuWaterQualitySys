using System;
using System.Drawing;
using System.IO;
using System.Windows;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using Path = System.IO.Path;

namespace RasterMaSys.BLL
{
    /// <summary>
    /// 数据展示类,包括矢量数据栅格数据的展示以及符号设置等
    /// </summary>
    public class DataShowControl
    {
        private readonly IMap _pMap;

        public DataShowControl(IMap map)
        {
            this._pMap = map;
        }
        /// <summary>
        /// 通过给定的图层名称和波段设置显示影像
        /// </summary>
        /// <param name="selectLayerName">图层名</param>
        /// <param name="bandSet">要显示的波段数组</param>
        public void SetImgBand(string selectLayerName, int[] bandSet)
        {

            int layerCount = _pMap.LayerCount;
            ILayer selectLayer = null;
            IMap pMap = _pMap;


            //get Selected layer
            for (int i = 0; i < layerCount; i++)
            {
                if (selectLayerName == pMap.Layer[i].Name)
                {
                    selectLayer = pMap.Layer[i];
                }
            }

            IRasterLayer pRasterLayer = selectLayer as IRasterLayer;

            if (pRasterLayer != null && pRasterLayer.BandCount > 3)
            {
                //初始化RGB渲染
                IRasterRGBRenderer2 rasterRgbRenderer2 = new RasterRGBRendererClass();
                IRasterRenderer rasterRenderer = (IRasterRenderer)rasterRgbRenderer2;
                rasterRenderer.Raster = pRasterLayer.Raster;

                //设置RGB波段
                rasterRgbRenderer2.SetBandIndices(bandSet[0], bandSet[1], bandSet[2]);
                rasterRenderer.Update();

                //刷新地图
                pRasterLayer.Renderer = (IRasterRenderer)rasterRgbRenderer2;
                IActiveView pActiveView = pMap as IActiveView;
                if (pActiveView != null) pActiveView.Refresh();
            }

        }

        /// <summary>
        /// 根据指定的影像路径显示影像
        /// </summary>
        /// <param name="imgPath">影像路径</param>
        public void DisplayImg(string imgPath)
        {
            if (File.Exists(imgPath))
            {
                //获取文件路径和文件名
                string imgDirectory = Path.GetDirectoryName(imgPath);
                string imgFileName = Path.GetFileName(imgPath);
                //
                IWorkspaceFactory pWorkspaceFactory = new RasterWorkspaceFactoryClass();
                IRasterWorkspace pRasterWorkspace = pWorkspaceFactory.OpenFromFile(imgDirectory, 0) as IRasterWorkspace;
                if (pRasterWorkspace != null)
                {
                    IRasterDataset pRasterDataset = pRasterWorkspace.OpenRasterDataset(imgFileName);
                    IRasterPyramid3 prPyramid3 = pRasterDataset as IRasterPyramid3;
                    if (prPyramid3 != null && !prPyramid3.Present)
                    {
                        //进度条怎么写
                        MessageBox.Show("正在建立金字塔！");
                        prPyramid3.BuildPyramid(5, rstResamplingTypes.RSP_BilinearInterpolation);
                        MessageBox.Show("完成建立金字塔！");
                    }
                    IRasterLayer rasterLayer = new RasterLayerClass();
                    rasterLayer.CreateFromDataset(pRasterDataset);
                    rasterLayer.Name = Path.GetFileNameWithoutExtension(imgPath);
                    this._pMap.AddLayer(rasterLayer);
                }
            }
            else
            {
                MessageBox.Show("指定的影像路径" + imgPath + "无效！");
            }
        }

        /// <summary>
        /// 根据给定的路径，显示矢量文件
        /// </summary>
        /// <param name="shpPath">矢量文件的路径</param>
        public void DisplayShp(string shpPath)
        {
            if (File.Exists(shpPath))
            {
                //获取文件路径文件和文件名
                string fileDirectory = Path.GetDirectoryName(shpPath);
                string fileName = Path.GetFileNameWithoutExtension(shpPath);
                //获取工作空间
                IWorkspaceFactory pWsFactory = new ShapefileWorkspaceFactoryClass();
                IWorkspace pWorkspace = pWsFactory.OpenFromFile(fileDirectory, 0);
                IFeatureWorkspace pFeatureWorkspace = pWorkspace as IFeatureWorkspace;
                if (pFeatureWorkspace != null)
                {
                    //获取要素
                    IFeatureClass pFeatureClass = pFeatureWorkspace.OpenFeatureClass(fileName);
                    //创建要素图层
                    IFeatureLayer pFeatureLayer = new FeatureLayerClass();
                    pFeatureLayer.FeatureClass = pFeatureClass;
                    pFeatureLayer.Name = fileName;
                    //添加
                    this._pMap.AddLayer(pFeatureLayer);
                }
            }
            else
            {
                MessageBox.Show("指定的shapefile路径" + shpPath + "无效！");
            }
        }

        /// <summary>
        /// 分级符号渲染矢量数据
        /// </summary>
        /// <param name="pFeatureLayer"></param>
        /// <param name="mField"></param>
        public void SimpleRenderByColor(IFeatureLayer pFeatureLayer, string mField)
        {
            //分5类
            int breakCount = 5;

            try
            {
                var pGeoFeatureLayer = (IGeoFeatureLayer)pFeatureLayer;
                //计算最大最小值
                var pTable = (ITable)pGeoFeatureLayer;
                if (pTable.FindField(mField) == -1)
                {
                    MessageBox.Show("此类型水质数据不存在");
                    return;
                }

                IQueryFilter pQueryFilter = new QueryFilterClass();
                pQueryFilter.AddField("");
                var pCursor = pTable.Search(pQueryFilter, true);
                //获取统计结果
                IDataStatistics pDataStatistics = new DataStatisticsClass();
                pDataStatistics.Cursor = pCursor;
                //设置要统计字段的名称
                pDataStatistics.Field = mField;
                //获取统计的结果
                //背景色
                IFillSymbol pFillSymbol = new SimpleFillSymbolClass();
                pFillSymbol.Color = GetColor(0, 0, 0);
                //点符号样式
                ISimpleMarkerSymbol pSimpleMarkerSymbol = new SimpleMarkerSymbolClass();
                pSimpleMarkerSymbol.Outline = true;
                pSimpleMarkerSymbol.OutlineColor = GetColor(0, 0, 0);

                //分级符号
                //获取统计数据及频率
                ITableHistogram pTableHistogram = new BasicTableHistogramClass();
                pTableHistogram.Field = mField;
                pTableHistogram.Table = pTable;
                object dataValue, dataFrequency;
                IBasicHistogram pHistogram = (IBasicHistogram)pTableHistogram;
                pHistogram.GetHistogram(out dataValue, out dataFrequency);
                IClassifyGEN pClassifyGen = new NaturalBreaksClass();
                //产生种类
                pClassifyGen.Classify(dataValue, dataFrequency, ref breakCount);
                object ob = pClassifyGen.ClassBreaks;
                double[] classes = (double[])ob;
                int classesCount = classes.Length;
                //定义分类渲染
                IClassBreaksRenderer pClassBreaksRenderer = new ClassBreaksRendererClass();
                pClassBreaksRenderer.Field = mField;
                pClassBreaksRenderer.BreakCount = classesCount;
                pClassBreaksRenderer.SortClassesAscending = true;
                pClassBreaksRenderer.MinimumBreak = classes[0];
                //设置要素颜色
                IColor pColor = GetColor(0, 217, 0);
                for (int i = 0; i < classesCount; i++)
                {
                    ISimpleFillSymbol pFillSymbol1 = new SimpleFillSymbolClass();
                    pSimpleMarkerSymbol.Color = pColor;
                    pFillSymbol1.Style = esriSimpleFillStyle.esriSFSSolid;

                    pSimpleMarkerSymbol.Size = 2 * (i + 1);
                    pClassBreaksRenderer.BackgroundSymbol = pFillSymbol1;
                    pClassBreaksRenderer.set_Symbol(i, (ISymbol)pSimpleMarkerSymbol);
                    pClassBreaksRenderer.set_Break(i, classes[i]);
                }
                pGeoFeatureLayer.Renderer = (IFeatureRenderer)pClassBreaksRenderer;

                this._pMap.AddLayer(pGeoFeatureLayer);
                IActiveView pActiveView = _pMap as IActiveView;
                if (pActiveView != null)
                {
                    pActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeography, null, null);
                    pActiveView.Extent = pActiveView.FullExtent;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("渲染出错!\n" + e.ToString());
            }

        }

        /// <summary>
        /// 依据色带渲染栅格
        /// </summary>
        /// <param name="pRasterLayer"></param>
        public void SetStretchColorRampRender(IRasterLayer pRasterLayer)
        {
            try
            {
                IRasterStretchColorRampRenderer pRampRenderer = new RasterStretchColorRampRendererClass();
                IRasterRenderer pRasterRenderer = pRampRenderer as IRasterRenderer;
                pRasterRenderer.Raster = pRasterLayer.Raster;
                pRasterRenderer.Update();
                //创建起始颜色
                IColor fromColor = GetColor(40, 146, 179);
                IColor toColor = GetColor(255, 255, 100);
                //创建起止色带
                IAlgorithmicColorRamp pAlgorithmicColorRamp = new AlgorithmicColorRampClass();
                pAlgorithmicColorRamp.Algorithm = esriColorRampAlgorithm.esriCIELabAlgorithm;
                pAlgorithmicColorRamp.Size = 255;
                pAlgorithmicColorRamp.FromColor = fromColor;
                pAlgorithmicColorRamp.ToColor = toColor;
                bool btrue = true;
                pAlgorithmicColorRamp.CreateRamp(out btrue);
                //选择拉伸颜色符号的波段
                pRampRenderer.BandIndex = 0;
                pRampRenderer.ColorRamp = pAlgorithmicColorRamp as IColorRamp;
                pRasterRenderer.Update();
                pRasterLayer.Renderer = pRasterRenderer;

                this._pMap.AddLayer(pRasterLayer);
                IActiveView pActiveView = _pMap as IActiveView;
                if (pActiveView != null)
                {
                    pActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeography, null, null);
                    pActiveView.Extent = pActiveView.FullExtent;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }


        public static void SaveCurrentToImage(AxPageLayoutControl axPageLayoutControl, string savePath)
        {
            tagRECT rect = new tagRECT();
            rect.left = rect.top = 0;
            rect.right = 1000;
            rect.bottom = 600;
            try
            {
                IActiveView pActiveView = axPageLayoutControl.ActiveView;
                Image image = new Bitmap(1000, 600);
                Graphics graphics = Graphics.FromImage(image);
                //
                graphics.FillRectangle(Brushes.White, 0, 0, 1000, 600);
                int dpi = (int) (1000/500);
                //保存范围
                IGraphicsContainer pGraphicsContainer = axPageLayoutControl.GraphicsContainer;
                IMapFrame pMapFrame = pGraphicsContainer.FindFrame(pActiveView.FocusMap) as IMapFrame;


                IEnvelope pMapExt = pActiveView.Extent;
                
                IEnvelope pEnvelope = new EnvelopeClass();
                pEnvelope.PutCoords(pMapExt.XMin - 2, pMapExt.YMin - 2, pMapExt.XMax + 1, pMapExt.YMax + 1);
                pActiveView.Output(graphics.GetHdc().ToInt32(), dpi, ref rect, pEnvelope, null);
                graphics.ReleaseHdc();
                //保存影像
                image.Save(savePath);
            }
            catch (Exception e)
            {
                MessageBox.Show("保存失败:" + e.ToString());
            }
        }

        /// <summary>
        /// 颜色获取器
        /// </summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        /// <returns>返回IColor</returns>
        public static IColor GetColor(int red, int green, int blue)
        {
            IRgbColor rgbColor = new RgbColorClass();
            rgbColor.Red = red;
            rgbColor.Green = green;
            rgbColor.Blue = blue;
            IColor color = (IColor)rgbColor;
            return color;
        }
    }
}
