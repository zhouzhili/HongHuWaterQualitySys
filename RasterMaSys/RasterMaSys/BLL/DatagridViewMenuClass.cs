using ESRI.ArcGIS.Carto;
using RasterMaSys.Model;
using System;
using System.IO;
using System.Windows.Forms;

namespace RasterMaSys.BLL
{
    //DatagridView右键菜单
   public  class DatagridViewMenuClass
    {
       /// <summary>
       /// 添加至显示
       /// </summary>
       /// <param name="dataGridView"></param>
       /// <returns></returns>
       public static IRasterLayer AddImgToShow(DataGridView dataGridView)
       {
           IRasterLayer pRasterLayer = new RasterLayerClass();
           try
           {
               int rowIndex = dataGridView.CurrentCell.RowIndex;
               rasterTable ts = dataGridView.Rows[rowIndex].DataBoundItem as rasterTable;
               if (ts != null)
               {
                   string imgPath = ts.path.Trim();
                   pRasterLayer = new RasterLayerClass();
                   pRasterLayer.CreateFromFilePath(imgPath);
               }
               return pRasterLayer;
           }
           catch (Exception exception)
           {
               MessageBox.Show("显示失败，请检查路径或格式是否正确!\n格式为tif或arcgis支持的格式");
               return null;
           }  
       }

       /// <summary>
       /// 根据路径打开文件夹
       /// </summary>
       /// <param name="dataGridView"></param>
       public static void OpenSelectDir(DataGridView dataGridView)
       {
           try
           {
               int rowIndex = dataGridView.CurrentCell.RowIndex;
               rasterTable ts = dataGridView.Rows[rowIndex].DataBoundItem as rasterTable;
               if (ts != null)
               {
                   string path = ts.path.Trim();
                   string dir = Path.GetDirectoryName(path);
                   if (Directory.Exists(dir))
                   {
                       System.Diagnostics.Process.Start("Explorer.exe", dir);
                   }
                   else
                   {
                       MessageBox.Show("文件夹不存在!");
                   }
               }
           }
           catch (Exception exception)
           {

               MessageBox.Show("打开失败，请检查路径是否正确!");
           }
       }
    }
}
