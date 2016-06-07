using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesRaster;
using System.IO;
using ESRI.ArcGIS.DataSourcesFile;

namespace RasterMaSys.Util
{
   public class GetDataClass
    {
       /// <summary>
       /// 通过给定的路径返回栅格数据集
       /// </summary>
       /// <param name="rasterPath"></param>
       /// <returns></returns>
       public static IRasterDataset GetRasterDataset(string rasterPath)
       {
           IRasterDataset pRasterDataset = null;
           if (File.Exists(rasterPath))
           {
               IWorkspaceFactory pWorkspaceFactory = new RasterWorkspaceFactoryClass();
               IWorkspace pWorkspace = pWorkspaceFactory.OpenFromFile(Path.GetDirectoryName(rasterPath), 0);
               IRasterWorkspace pRasterWorkspace = pWorkspace as IRasterWorkspace;
               if (pRasterWorkspace != null)
               {
                   pRasterDataset = pRasterWorkspace.OpenRasterDataset(Path.GetFileName(rasterPath));
               }
           }
           return pRasterDataset;
       }

       /// <summary>
       /// 通过给定的要素名，返回要素类。要素默认工作空间为 D:\RasterMaSysTemp\hhWaterQuality
       /// </summary>
       /// <param name="featureName"></param>
       /// <returns></returns>
       public static IFeatureClass GetFeatureClassByName(string featureName)
       {
           IFeatureClass pFeatureClass = null;
           if (File.Exists(@"D:\RasterMaSysTemp\hhWaterQuality" + "\\" + featureName))
           {
               IWorkspaceFactory pWorkspaceFactory2 = new ShapefileWorkspaceFactoryClass();
               IWorkspace pWorkspace2 = pWorkspaceFactory2.OpenFromFile(@"D:\RasterMaSysTemp\hhWaterQuality", 0);
               IFeatureWorkspace pFeatureWorkspace = pWorkspace2 as IFeatureWorkspace;
               if (pFeatureWorkspace != null)
               {
                   pFeatureClass = pFeatureWorkspace.OpenFeatureClass(featureName);
               }
           }
           return pFeatureClass;
       }

       /// <summary>
       /// 通过给定的要素绝对路径，返回要素类
       /// </summary>
       /// <param name="featurePath"></param>
       /// <returns></returns>
       public static IFeatureClass GetFeatureClassByPath(string featurePath)
       {
           IFeatureClass pFeatureClass = null;
           if (File.Exists(featurePath))
           {
               string dir = Path.GetDirectoryName(featurePath);
               string name = Path.GetFileName(featurePath);
               IWorkspaceFactory pWorkspaceFactory=new ShapefileWorkspaceFactoryClass();
               IWorkspace pWorkspace = pWorkspaceFactory.OpenFromFile(dir,0);
               IFeatureWorkspace pFeatureWorkspace=pWorkspace as IFeatureWorkspace;
               if (pFeatureWorkspace != null) pFeatureClass = pFeatureWorkspace.OpenFeatureClass(name);
           }
           return pFeatureClass;
       }

    }
}
