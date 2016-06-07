using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using Path = System.IO.Path;


namespace RasterMaSys.BLL
{
    /// <summary>
    /// 洪湖水域面积处理类,返回矢量文件面积数据整理成图表所需的数据格式
    /// </summary>
   public class GetChartDataClass
    {
       public Dictionary<DateTime, double> GetAreaData()
       {
           ArrayList areaArrayList=new ArrayList();
          Dictionary<DateTime,double> areaDictionary=new Dictionary<DateTime, double>();

           string[] fileNames = this.GetDataPath();
           if (fileNames != null)
           {
               foreach (var shpfile in fileNames)
               {
                   string fileName = Path.GetFileNameWithoutExtension(shpfile).Substring(2);
                   //获取日期
                   DateTime dt = DateTime.ParseExact(fileName, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
                   //获取面积并转换为公顷，保留3位小数
                   double area = this.GetShpArea(shpfile) / 10000;
                   double area2 = double.Parse(area.ToString("0.###"));
                   areaDictionary.Add(dt, area2);
               }
           }
           return areaDictionary;
       }

       private string[] GetDataPath()
       {
           string[] fileNames = null;
           OpenFileDialog fileDialog=new OpenFileDialog();
           fileDialog.Filter = "shapefile文件|*.shp|所有文件|*.*";
           fileDialog.FilterIndex = 1;
           fileDialog.Multiselect = true;
           if (fileDialog.ShowDialog() ==DialogResult.OK)
           {
               fileNames = fileDialog.FileNames;
           }
           return fileNames;
       }

       //获取要素面积，单位为平方米
       private double GetShpArea(string filePath)
       {
           string folder = Path.GetDirectoryName(filePath);
           string fileName = Path.GetFileName(filePath);
           double dArea = 0;

           IWorkspaceFactory pwsf=new ShapefileWorkspaceFactoryClass();
           IFeatureWorkspace pFeatureWorkspace=pwsf.OpenFromFile(folder,0) as IFeatureWorkspace;
           if (pFeatureWorkspace != null)
           {
               IFeatureClass pFeatureClass = pFeatureWorkspace.OpenFeatureClass(fileName);
               IFeatureCursor pFeatureCursor = pFeatureClass.Search(null, false);
               IFeature pFeature = pFeatureCursor.NextFeature();
               while (pFeature!=null)
               {
                   if (pFeature.Shape.GeometryType==esriGeometryType.esriGeometryPolygon)
                   {
                       IArea pArea=pFeature.Shape as IArea;
                       dArea = dArea + pArea.Area;
                   }
                   pFeature = pFeatureCursor.NextFeature();
               }
               Marshal.ReleaseComObject(pFeatureCursor);
           }
           Marshal.ReleaseComObject(pwsf);
           return dArea;
       }
    }
}
