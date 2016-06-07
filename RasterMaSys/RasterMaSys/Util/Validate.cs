using System.Text.RegularExpressions;

namespace RasterMaSys.Util
{
   public  class MyValidateUtil
    {
       /// <summary>
       /// 验证字符串是否是正整数，如果是返回true，否则返回false
       /// </summary>
       /// <param name="str"></param>
       /// <returns>bool</returns>
       public static bool IsShort(string str)
       {
           Regex reg = new Regex(@"^[1-9]\d*$");
           return reg.IsMatch(str) ? true : false;
       }
       /// <summary>
       /// 验证字符串是否是正浮点数，如果是返回true，否则返回false
       /// </summary>
       /// <param name="str"></param>
       /// <returns></returns>
       public static bool IsDouble(string str)
       {
           Regex reg = new Regex(@"^[1-9]\d*\.\d*|0\.\d*[1-9]\d*$");
           return reg.IsMatch(str) ? true : false;
       }
    }
}
