using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Finance.ComHelper
{
    //根据城市代码 查询到区县名的实体类 
    public class AreaLin
    {
        public string Ovrlsttn_Trck_No { get; set; }
        public string Status { get; set; }
        public string Desc { get; set; }
        public AreaRoot result { get; set; }
    }
    public class AreaRoot
    {
        /// <summary>
        /// 
        /// </summary>
        public string needSignFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BK_STATUS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<AreaItem> area { get; set; }
        /// <summary>
        /// 交易成功
        /// </summary>
        public string BK_DESC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public COMMON_ _COMMON { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BK_CODE { get; set; }
    }
    public class AreaItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string CntyAndDstc_ID { get; set; }
        /// <summary>
        /// 路南区
        /// </summary>
        public string CntyAndDstc_Nm { get; set; }
    }
    
}
