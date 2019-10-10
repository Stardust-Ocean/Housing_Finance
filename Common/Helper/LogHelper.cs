using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper
{
    public class LogHelper
    {
        public static string DicpathStr = AppDomain.CurrentDomain.BaseDirectory + "\\Log\\";


        private static object Lock = new object();
        /// <summary>
        /// 将异常打印到LOG文件
        /// </summary>
        /// <param name="ex">异常</param>
        /// <param name="LogAddress">日志文件地址</param>
        public static void WriteLog(Exception ex, string LogAddress = "")
        {
            lock (Lock)
            {
                if (LogAddress == "")
                {
                    LogAddress = Environment.CurrentDirectory + "\\Log\\" +
                        DateTime.Now.Year + '-' +
                        DateTime.Now.Month + '-' +
                        DateTime.Now.Day + "Error_Log.log";
                }
                string tempPath = System.IO.Path.GetDirectoryName(LogAddress);//获得文件的目录
                if (!System.IO.Directory.Exists(LogAddress))
                {
                    System.IO.Directory.CreateDirectory(tempPath);//不存在就创建目录 
                }
                //如果日志文件为空，则默认在Debug目录下新建 YYYY-mm-dd_Log.log文件

                //把异常信息输出到文件
                StreamWriter fs = new StreamWriter(LogAddress, true);
                fs.WriteLine("当前时间：" + DateTime.Now.ToString());
                fs.WriteLine("异常信息：" + ex.Message);
                fs.WriteLine("异常对象：" + ex.Source);
                fs.WriteLine("调用堆栈：\n" + ex.StackTrace.Trim());
                fs.WriteLine("触发方法：" + ex.TargetSite);
                fs.WriteLine();
                fs.Close();
            }
        }

        //以时间分目录，免得很大日志都写在同一个目录

        /// <summary>
        /// 写日志方法
        /// </summary>
        /// <param name="pathStr">日志存放位置</param>
        /// <param name="msg">日志内容</param>
        public static void WriteLogInfo(string msg, string pathStr = "")
        {

            //如果日志文件为空，则默认在Debug目录下新建 YYYY-mm-dd_Log.log文件
            if (pathStr == "")
            {
                pathStr = Environment.CurrentDirectory + "\\Log\\" +
                    DateTime.Now.Year + '-' +
                    DateTime.Now.Month + '-' +
                    DateTime.Now.Day + ".log";
            }
            string tempPath = Path.GetDirectoryName(pathStr);//获得文件的目录
            if (!Directory.Exists(tempPath))//如果没有文件指定的目录就创建
            {
                Directory.CreateDirectory(tempPath);
            }
            using (StreamWriter sw = new StreamWriter(pathStr, true))
            {
                sw.Write(msg+"/r/n");
            }
        }
    }
}
