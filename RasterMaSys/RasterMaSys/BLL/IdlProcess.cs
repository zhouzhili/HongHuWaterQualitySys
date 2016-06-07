using System;
using System.Windows.Forms;

namespace RasterMaSys.BLL
{
    /// <summary>
    /// IDL程序处理类
    /// </summary>
    public class IdlProcess
    {
        /// <summary>
        /// 根据输入的landsat7头文件MTL.txt和保存的位置，完成辐射定标，返回结果文件的路径
        /// </summary>
        /// <param name="inputStr">landsat头文件MTL.txt的路径</param>
        /// <param name="outputStr">定标后的保存文件夹</param>
        /// <returns>完成定标后的可见光和红外保存的路径，返回为字符串数组</returns>
        public static string[] IdlRadCalibration(string inputStr,string outputStr)
        {
            string[] resultStr=new string[2];
            try
            {
                //初始化COM_IDL_connectLib对象
                COM_IDL_connectLib.COM_IDL_connect oComIdl = new COM_IDL_connectLib.COM_IDL_connectClass();
                oComIdl.CreateObject(0, 0, 0);
                //定义IDL下的变量
                oComIdl.SetIDLVariable("inputFile", inputStr);
                oComIdl.SetIDLVariable("outputFolder", outputStr);
                //编译IDL源码
                oComIdl.ExecuteString(".compile '" + Application.StartupPath +
                                      "\\IDLProcess\\ENVIPROVESS_TMCAL_DOIT.pro'");
                oComIdl.ExecuteString("ENVIPROVESS_TMCAL_DOIT,inputFile,outputFolder,mb_output=mb_output,thre_output=thre_output");
                //获取IDL下的变量值
                object objMulOutputName = oComIdl.GetIDLVariable("mb_output");
                object objThreOutputName = oComIdl.GetIDLVariable("thre_output");
                //设置返回值
                resultStr[0] = objThreOutputName.ToString();
                resultStr[1] = objMulOutputName.ToString();
                oComIdl = null;
            }
            catch (Exception e)
            {
                MessageBox.Show("辐射定标处理过程出现错误" + e.ToString());
            }
            return resultStr;
        }

       /// <summary>
       /// 大气校正IDL处理函数，输入影像以及保存路径
       /// </summary>
        /// <param name="inputfile">输入影像</param>
        /// <param name="outputfile">保存路径</param>
        public static void  IdlAtmoCorrection(string inputfile, string outputfile)
        {
            //程序报错，但是结果正确，未找到错误源
            try
            {
                //初始化COM_IDL_connectLib对象
                COM_IDL_connectLib.COM_IDL_connect oComIdl = new COM_IDL_connectLib.COM_IDL_connectClass();
                oComIdl.CreateObject(0, 0, 0);
                //定义IDL下的变量
                oComIdl.SetIDLVariable("inputfile", inputfile);
                oComIdl.SetIDLVariable("outputfile", outputfile);
                //编译IDL源码
                oComIdl.ExecuteString(".compile '" + Application.StartupPath +
                                      "\\IDLProcess\\cal_quc.pro'");
                oComIdl.ExecuteString("CAL_QUC,inputfile,outputfile");
                oComIdl = null;
            }
            catch (Exception e)
            {
                MessageBox.Show("大气校正处理过程出现错误:\n" + e.ToString());
            }
        } 
    }
}
