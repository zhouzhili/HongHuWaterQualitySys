using System.Collections.Generic;
using System.Windows.Forms;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;

namespace RasterMaSys.Util
{
   public class InitInput
    {
       /// <summary>
       /// 初始化下拉列表，可以选择已有图层或者通过打开文件按钮自己选择图层
       /// </summary>
        /// <param name="pMapControl">MapControl控件</param>
       /// <param name="pComboBox">将要进行初始化的ComboBox</param>
       public static void InitRsCombox(AxMapControl pMapControl, ComboBox pComboBox)
       {
           //获取图层名，添加到Combox列表中
           
           IMap pMap = pMapControl.Map;
           int mapCount = pMap.LayerCount;
           if (mapCount < 0)
               return;
           List<MyItem> list = new List<MyItem>();
           for (int i = 0; i < mapCount; i++)
           {
               IRasterLayer pRasterLayer = pMap.Layer[i] as IRasterLayer;
               if (pRasterLayer != null)
               {
                   string layerName = pRasterLayer.Name;
                   string layerPath = pRasterLayer.FilePath;
                   list.Add(new MyItem(layerName, layerPath));
               }
           }
           pComboBox.DataSource = list;
           pComboBox.DisplayMember = "LayerName";
           pComboBox.ValueMember = "LayerPath";
           pComboBox.SelectedItem = null;
       }

       /// <summary>
       /// 初始化水质字段选择列表的显示值与真实值
       /// </summary>
       /// <param name="pComboBox">需要初始化的ComboBox</param>
       public static void InitQualityComboBox(ComboBox pComboBox)
       {
           //初始化列表
           //列表显示水质中文名
           //列表实际值为属性表中对应的字段名
           List<FieldData> fieldList = new List<FieldData>();
           fieldList.Add(new FieldData("总磷", "TP"));
           fieldList.Add(new FieldData("总氮", "TN"));
           fieldList.Add(new FieldData("氨氮", "NH4_N"));
           fieldList.Add(new FieldData("PH值", "PH"));
           fieldList.Add(new FieldData("温度", "Temperatur"));
           fieldList.Add(new FieldData("深度", "Depth"));
           fieldList.Add(new FieldData("电导率", "Conductivi"));
           fieldList.Add(new FieldData("溶解态", "Dissolved"));
           fieldList.Add(new FieldData("高锰酸钾", "CODmn"));
           fieldList.Add(new FieldData("透明度", "Transpranc"));
           fieldList.Add(new FieldData("叶绿素", "Chlorophyl"));
           //绑定数据源，并设置显示值与真实值
           pComboBox.DataSource = fieldList;
           pComboBox.DisplayMember = "Display";
           pComboBox.ValueMember = "value";
       }

       /// <summary>
       /// 初始化水质数据列表
       /// </summary>
       /// <param name="pComboBox"></param>
       public static void InitWaterDataComboBox(ComboBox pComboBox)
       {
          List<FieldData> waterDatas=new List<FieldData>();
          waterDatas.Add(new FieldData("2012年8月1日","hh_20120801.shp"));
          waterDatas.Add(new FieldData("2012年12月1日", "hh_20121201.shp"));
          waterDatas.Add(new FieldData("2013年4月1日", "hh_20130401.shp"));
          waterDatas.Add(new FieldData("2016年4月1日", "hh_20160401.shp"));
           pComboBox.DataSource = waterDatas;
           pComboBox.DisplayMember = "Display";
           pComboBox.ValueMember = "value";
       }

       /// <summary>
       /// 文件选择函数，返回选择的文件路径
       /// </summary>
       /// <param name="filter">格式筛选器</param>
       /// <returns></returns>
       public static string IninSelectImg(string filter)
       {
           string fileName = null;
           OpenFileDialog openFileDialog=new OpenFileDialog();
           openFileDialog.Filter = filter;
           openFileDialog.FilterIndex = 1;
           if (openFileDialog.ShowDialog() == DialogResult.OK)
           {
               fileName = openFileDialog.FileName;
           }
           return fileName;
       }

       /// <summary>
       /// 文件保存函数，根据给定的格式，返回保存文件的绝对路径
       /// </summary>
       /// <param name="filter">格式筛选字符串</param>
       /// <returns>保存的绝对路径</returns>
       public static string InitSaveFile(string filter)
       {
           string saveFileName = null;
           SaveFileDialog dialog=new SaveFileDialog();
           dialog.Filter = filter;
           dialog.FilterIndex = 1;
           if (dialog.ShowDialog() == DialogResult.OK)
           {
               saveFileName = dialog.FileName;
           }
           return saveFileName;
       }

    }

    //显示与真是值类
   public class FieldData
   {
       public string Display { get; set; }
       public string Value { get; set; }

       public FieldData(string display, string value)
       {
           this.Display = display;
           this.Value = value;
       }
   }

    //ComboBox的Item对象
   class MyItem
   {
       public MyItem(string name, string path)
       {
           LayerName = name;
           LayerPath = path;
       }
       public string LayerName { get; private set; }
       public string LayerPath { get; private set; }

       public override string ToString()
       {
           return LayerPath.ToString();
       }
   }
}
