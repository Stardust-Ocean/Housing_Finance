using Common;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Housing_Finance.ComHelper
{
    public static class StarHelper
    {

        public static CompanyCommunicationLibray.P2SClient client;

        public static string m_strEnd = "_######_";

        public static void Start()
        {
            client = new CompanyCommunicationLibray.P2SClient();
            client.Connect(new CompanyCommunicationLibray.P2SClient.ConnectCallback(ConnectSuccessCallback), new CompanyCommunicationLibray.P2SClient.ConnectCallback(ConnectFailCallback));
        }
        private static void ConnectSuccessCallback()
        {
            Console.WriteLine("Connected!");
        }
        private static void ConnectFailCallback()
        {
            //CMessageBox.Show("Failed!");
        }

        #region  查询接口
        //查询市县下面的区、县    查询区域
        public static string RequestArea(string urbn_Cd, int pg_Num, int pgFC_Byte_Num)//城市代码  页数  页面字节数
        {
            var jsonObj = new
            {
                jsonData = new
                {

                    Urbn_Cd = urbn_Cd,
                    Pg_Num = pg_Num,
                    PgFC_Byte_Num = pgFC_Byte_Num
                }
            };
            // System.Diagnostics.Debug.Assert(jsonObj);
            string ret = client.SendRequest("P5201CL08-pad", JsonConvert.SerializeObject(jsonObj));
            return ret;
        }

        //查询区县的小区房源信息    查询精选房源、楼盘详情等使用方法一样
        public static string RequestHorse(string urbn_Cd, int pg_Num, int pgFC_Byte_Num, string cntyAndDstc_Nm)//城市代码  页数  页面数  区的名称
        {
            var jsonObj = new
            {
                jsonData = new
                {
                    Urbn_Cd = urbn_Cd,
                    Pg_Num = pg_Num,
                    PgFC_Byte_Num = pgFC_Byte_Num,
                    CntyAndDstc_Nm = cntyAndDstc_Nm,

                }
            };
            // System.Diagnostics.Debug.Assert(jsonObj);
            string ret = client.SendRequest("P5201CL03-pad", JsonConvert.SerializeObject(jsonObj));
            return ret;
        }

        //  小区房源  查询精选房源、楼盘详情等使用方法一样
        public static string RequestHourseDetail(string prj_Ecd_Inf)//  项目编号（小区）
        {
            var jsonObj = new
            {
                jsonData = new
                {
                    Prj_ECD_Inf = prj_Ecd_Inf
                }
            };
            // System.Diagnostics.Debug.Assert(jsonObj);
            string ret = client.SendRequest("P5201CL05-pad", JsonConvert.SerializeObject(jsonObj));
            return ret;
        }

        //  小区房源  查询精选房源、楼盘详情等使用方法一样
        public static string RequestHourseNum(string room_No)// 房间号
        {
            var jsonObj = new
            {
                jsonData = new
                {
                    Room_No = room_No,
                }
            };
            // System.Diagnostics.Debug.Assert(jsonObj);
            string ret = client.SendRequest("P5201CL07-pad", JsonConvert.SerializeObject(jsonObj));
            return ret;
        }
        #endregion



        private static object Lock2 = new object();
        /// <summary>
        /// 把文本写入txt
        /// </summary>
        /// <param name="pathStr">日志存放位置</param>
        /// <param name="msg">日志内容</param>
        public static void WriteLogInfo(string msg, string namepth, string pathStr = "")
        {
            lock (Lock2)
            {
                //如果日志文件为空，则默认在Debug目录下新建 YYYY-mm-dd_Log.log文件
                if (pathStr == "")
                {
                    pathStr = Environment.CurrentDirectory + "\\Log\\" +
                        DateTime.Now.Year + '-' +
                        DateTime.Now.Month + '-' +
                        DateTime.Now.Day + '-' + namepth + DateTime.Now.Hour + '-' + DateTime.Now.Minute + '-' + DateTime.Now.Second + ".log";
                }
                string tempPath = System.IO.Path.GetDirectoryName(pathStr);//获得文件的目录
                if (!Directory.Exists(tempPath))//如果没有文件指定的目录就创建
                {
                    Directory.CreateDirectory(tempPath);
                }
                using (StreamWriter sw = new StreamWriter(pathStr, true))
                {
                    sw.Write(msg);
                }

            }
        }
    }
}
