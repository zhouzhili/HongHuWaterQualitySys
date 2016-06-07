using System;
using System.IO;
using System.Windows.Forms;
using ESRI.ArcGIS.Geoprocessor;
using ESRI.ArcGIS.DataManagementTools;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Geoprocessing;

namespace RasterMaSys.BLL
{
    /// <summary>
    /// 调用GP工具类,处理各种GP服务
    /// </summary>
    public class GpToolsClass
    {

        private readonly string _workspace = @"D:\RasterMaSysTemp";
        private readonly Geoprocessor _gp;

        public GpToolsClass()
        {
            //设置环境
            _gp = new Geoprocessor();
            _gp.OverwriteOutput = true;
            _gp.SetEnvironmentValue("Workspace",this._workspace );
        }

        /// <summary>
        /// 根据输入的中红外影像获取洪湖矢量边界
        /// </summary>
        /// <param name="inputPath"></param>
        /// <param name="savePath"></param>
        public void CalculateBoundary(string inputPath, string savePath)
        {

            try
            {
                //使用模型来处理
                _gp.AddToolbox(@"D:\RasterMaSysTemp\hhData\MyToolbox.tbx");
                IVariantArray parametersArray = new VarArrayClass();
                parametersArray.Add(inputPath);
                parametersArray.Add(savePath);
                _gp.Execute("GetHonghuBoundary", parametersArray, null);
            }
            catch (Exception e)
            {
                MessageBox.Show("获取边界出现错误:" + e.ToString());
            }

        }

       /// <summary>
       /// 根据坐标返回影像对应的像元值
       /// </summary>
       /// <param name="point"></param>
       /// <param name="pRasterDataset"></param>
       /// <returns></returns>
        public string  GetCellValueByCoordinate(IPoint point,IRasterDataset pRasterDataset)
        {
           
            GetCellValue getCellValue=new GetCellValue();
            getCellValue.in_raster = pRasterDataset;
            getCellValue.location_point =string.Format("{0} {1}",point.X,point.Y);
            //结果
            Runtool(this._gp, getCellValue);
            string result = getCellValue.out_string;
            return result;
        }

        /// <summary>
        /// 克里金插值
        /// </summary>
        ///  /// <param name="field">插值字段</param>
        /// <param name="outputName">输出影像</param>
        public void CalKriging(string field, string outputName)
        {
            try
            {
                //使用模型来处理
                //先使用克里金插值，然后裁剪
                _gp.AddToolbox(@"D:\RasterMaSysTemp\hhData\MyToolbox.tbx");
                IVariantArray parametersArray = new VarArrayClass();
                parametersArray.Add(field);
                parametersArray.Add(outputName);
                _gp.Execute("GridInterpolation", parametersArray, null);
            }
            catch (Exception exception)
            {
                MessageBox.Show("插值出现错误:" + exception.ToString());
            }
            
        }


        /// <summary>
        /// 运行GP服务，捕捉异常和消息
        /// </summary>
        /// <param name="geoprocessor"></param>
        /// <param name="process"></param>
        private void Runtool(Geoprocessor geoprocessor, IGPProcess process)
        {
            try
            {
                IGeoProcessorResult result = null;
                result=  geoprocessor.Execute(process, null) as IGeoProcessorResult;
                if (result.Status != esriJobStatus.esriJobSucceeded)
                {
                    MessageBox.Show("处理失败!");
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                ReturnMessages(geoprocessor);
                return;
            }
        }
        /// <summary>
        /// 提供消息处理
        /// </summary>
        /// <param name="geoprocessor"></param>
        private void ReturnMessages(Geoprocessor geoprocessor)
        {
            string ms = "";
            if (geoprocessor.MessageCount > 0)
            {
                for (int count = 0; count < geoprocessor.MessageCount - 1; count++)
                {
                    ms += geoprocessor.GetMessage(count)+"\n";
                }
            }
            
            MessageBox.Show(ms);
        }

        private void ShowResultMsg(string resultPath)
        {
            if (File.Exists(resultPath))
            {
                MessageBox.Show("处理成功,\n文件保存在:" + resultPath);
            }
            else
            {
                MessageBox.Show("处理失败!");
            }
        }
    }
}