using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_Finance.ComHelper
{
    //根据网点代码  查询到的 网点详情实体类
    public class BankAddressRoot
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
        /// 数据库操作成功
        /// </summary>
        public string BK_DESC { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BK_CODE { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Database_resultItem> database_result { get; set; }
    }

    public class Database_resultItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string INST_UDO_DT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CCBINS_ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string INSTUDOAFBLGCCBINS_ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CCBINS_ESTB_DT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BLNG_BO_INSID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string INST_LDGR_HIER_CD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FIX_TELNO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PROV_CD { get; set; }
        /// <summary>
        /// 建行唐山分行营业部
        /// </summary>
        public string CCBINS_CHN_SHRTNM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string INST_MDF_DT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CCBINS_ENG_SHRTNM { get; set; }
        /// <summary>
        /// 中国建设银行股份有限公司唐山分行营业部
        /// </summary>
        public string CCBINS_CHN_FULLNM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string INST_STCD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SWIFT_NO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BLNG_HQ_INSID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CITY_CD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CCBINS_TPCD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ADIV_CD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string MOVE_TELNO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CCBINS_ADMNHIER_CD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BLNG_SUBBR_INSID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BLNG_LVL2_BR_INSID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CCBINS_ENG_FULLNM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DRCSELL_BR_IND { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PBC_FNC_INST_ECD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ORG_INST_RGON_ID_CD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OPRT_TRM_STDT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FAX_TELNO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string INST_STRT_OPRG_TM { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BLNG_LV1_BR_INSID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string EMAIL_ADR_CNTNT { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ZIPECD { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OPRT_TRM_EDDT { get; set; }
        /// <summary>
        /// 新华东道106号
        /// </summary>
        public string DTL_ADR { get; set; }
    }

   
}
