using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Finance.ComHelper
{
    public class RootHouseLin
    {
        public string Ovrlsttn_Trck_No { get; set; }
        public string Status { get; set; }
        public string Desc { get; set; }
        public RootHourse result { get; set; }
    }
    //每个区县的所有小区房源
    public class RootHourse
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
        /// 交易成功
        /// </summary>
        public string BK_DESC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ItemsItem> items { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Tot_Pg_Num { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public COMMON_ _COMMON { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BK_CODE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Pg_Num { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Tot_Num { get; set; }
    }

    public class ItemsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string Lse_Area { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Src_URL_Adr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Modl_Tp_Apl_Ind { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Rent_MoRent_Gld { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LPrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Floor_Num { get; set; }
        /// <summary>
        /// 尚湖名筑
        /// </summary>
        public string Comm_Nm { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Tot_Floor_Num { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Seq_Mod_CgyCd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Room_No { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Msg_Pct_Links { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Lgt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PD_Tp_ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Hs_Area { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Num { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Tpl_Len { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Rsc_TpCd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Room_Num { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Vd_Adr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Prj_ECD_Inf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Prvd_Drc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Ern_Stn_Nm { get; set; }
        /// <summary>
        /// 拎包入住,随时看房
        /// </summary>
        public string Lbl_Cmnt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Ltt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Unit_TpCd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Prmt_Rsrvtn_Ind { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string File_ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string HsStl_Cd { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string HPrc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Num_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Ipnt_Room_Area { get; set; }
        /// <summary>
        /// 建融公租通房源
        /// </summary>
        public string Prj_Nm { get; set; }
        /// <summary>
        /// 路南区
        /// </summary>
        public string CntyAndDstc_Nm { get; set; }
    }

}
