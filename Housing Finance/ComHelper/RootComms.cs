using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Finance.ComHelper
{
    public class RootCommLins
    {
        public string Ovrlsttn_Trck_No { get; set; }
        public string Status { get; set; }
        public string Desc { get; set; }
        public RootComm result { get; set; }
    }
    //每个小区的房源
    public class RootComms
    {
        /// <summary>
        /// 
        /// </summary>
        public string Smy_Inf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Pic_Nm { get; set; }
        /// <summary>
        /// 交易成功
        /// </summary>
        public string BK_DESC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Mrch_Tmnl_Brnd_Modl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Opn_Dt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BK_CODE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Ctc_Tel { get; set; }
        /// <summary>
        /// 深圳市福田区neo企业大厦a座
        /// </summary>
        public string Comm_Adr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Comm_Nm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BK_STATUS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Room_Type_listItems Room_Type_list { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> Elmt_Tnf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Wk_Dys_Sel_Smy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> Msg_Pct_Links { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Lgt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Cst_WbtRgon_Cd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string needSignFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Rsrvtn_Crt_Dt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Ern_Stn_ECD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Rsrvtn_TmDt { get; set; }
        /// <summary>
        /// [{"class":"icon-diantifuwu","title":"电梯"},{"class":"icon-ditie","title":"地铁"},{"class":"icon-bianlidianchaoshi","title":"便利店"},{"class":"icon-xiyi","title":"洗衣服务"},{"class":"icon-atm","title":"ATM"},{"class":"icon-tingchechang","title":"停车场"},{"class":"icon-yumaoqiu","title":"羽毛球场"},{"class":"icon-huilvjianshenfang","title":"健身房"},{"class":"icon-huiyishi","title":"会议室"},{"class":"icon-spa","title":"SPA"},{"class":"icon-canting","title":"餐厅"},{"class":"icon-75405","title":"活动场地"},{"class":"icon-lanqiu","title":"篮球场"},{"class":"icon-zuqiu","title":"足球场"},{"class":"icon-pingpangqiushi","title":"乒乓球室"},{"class":"icon-shiwaiyouyongchi","title":"室外泳池"},{"class":"icon-wangqiuchang","title":"网球场"},{"class":"icon-jiankongshipin","title":"安全监控"},{"class":"icon-kuaididaishou","title":"快递代收"},{"class":"icon-jiatingbaoji","title":"家居保洁"},{"class":"icon-chufang","title":"公共厨房"}]
        /// </summary>
        public List<HsPty_AftEqmt_StnDsc> HsPty_AftEqmt_StnDsc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Ern_Stn_Nm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Usr_UDF_Rte_ID { get; set; }
        /// <summary>
        /// 森系小清新,出行方便
        /// </summary>
        public string Lbl_Cmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Ltt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Prmt_Rsrvtn_Ind { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string HsStl_Cd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public COMMON_ _COMMON { get; set; }
        /// <summary>
        /// 深圳市
        /// </summary>
        public string Prj_Wbt_Urbn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LOB_Nm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<MsgRp_Expd_Inf_Set> MsgRp_Expd_Inf_Set { get; set; }
        /// <summary>
        /// 0挪威森林
        /// </summary>
        public string Prj_Nm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Str_Nm { get; set; }
        /// <summary>
        /// 福田区
        /// </summary>
        public string CntyAndDstc_Nm { get; set; }
    }

    //每一层上的所有房间
    public class Room_Type_listItems
    {
        public int tempIndex { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Lse_Area { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Pic_Nm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Hs_Area { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Modl_Tp_Apl_Ind { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LPrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Prj_ECD_Inf { get; set; }
        /// <summary>
        /// 1室1厅1卫1厨1阳台
        /// </summary>
        public string Mrtg_Hs_Stc_Dsc { get; set; }
        /// <summary>
        /// 一室一厅
        /// </summary>
        public string Ttl_Ttl_Nm { get; set; }
        /// <summary>
        /// 森系小清新,出行方便
        /// </summary>
        public string Lbl_Cmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string HPrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Room_No { get; set; }
        /// <summary>
        /// 1室1厅
        /// </summary>
        public string New_Hs_Nm { get; set; }
        /// <summary>
        /// 0挪威森林
        /// </summary>
        public string Prj_Nm { get; set; }
    }

    public class MsgRp_Expd_Inf_Sets
    {
        public string iconClass { get; set; }
        public string content { get; set; }

    }
    public class HsPty_AftEqmt_StnDscs
    {
        [JsonProperty("class")]
        public string _class { get; set; }
        [JsonProperty("title")]
        public string _title { get; set; }
    }

}
