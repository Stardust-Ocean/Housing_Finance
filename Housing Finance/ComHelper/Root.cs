using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Finance.ComHelper
{
    //网点请求返回的跟类
    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public string Ovrlsttn_Trck_No { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string result { get; set; }
    }
}
