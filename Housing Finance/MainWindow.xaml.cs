using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Common.Helper;
using Housing_Finance.ComHelper;
using Newtonsoft.Json;

namespace Housing_Finance
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FullScreenHelper.GoFullscreen(this);
        }


        /// <summary>
        /// 全屏的快捷功能，F11相当于单机按钮；Esc健，如果全屏则退出全屏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetroWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F11)
            {
                FullScreenHelper.GoFullscreen(this);
            }
            else if (e.Key == Key.Escape)//esc键盘退出全屏
            {
                FullScreenHelper.ExitFullscreen(this);
            }
        }
        /// <summary>
        /// 开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Star_Click(object sender, RoutedEventArgs e)
        {
            IndexOne.Visibility = Visibility.Hidden;
            TwoPage.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// 地图-全国
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            cmap.Visibility = Visibility.Hidden;
            WuMap.Visibility = Visibility.Visible;
            b1.Visibility = Visibility.Visible;
        }
       /// <summary>
       /// 返回主页
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void Backbtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            IndexOne.Visibility = Visibility.Visible;
            TwoPage.Visibility = Visibility.Hidden;
            ThreePage.Visibility = Visibility.Hidden;
            #region
            cmap.Visibility = Visibility.Visible;
            WuMap.Visibility = Visibility.Hidden;
            b1.Visibility = Visibility.Hidden;
            #endregion
        }
        /// <summary>
        /// 武汉地图点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WuHna_Click(object sender, RoutedEventArgs e)
        {
            #region
            string hourseRes = "{\r\n  \"needSignFlag\": true,\r\n  \"BK_STATUS\": \"00\",\r\n  \"BK_DESC\": \"交易成功\",\r\n  \"items\": [\r\n    {\r\n      \"Lse_Area\": \"36.03\",\r\n      \"Src_URL_Adr\": \"\",\r\n      \"Modl_Tp_Apl_Ind\": \"0\",\r\n      \"Rent_MoRent_Gld\": \"2500.00\",\r\n      \"LPrc\": \"2500.00\",\r\n      \"Floor_Num\": \"17\",\r\n      \"Comm_Nm\": \"世纪新宸公寓\",\r\n      \"Tot_Floor_Num\": \"\",\r\n      \"Seq_Mod_CgyCd\": \"0\",\r\n      \"Room_No\": \"39e693f1-cc4f-b652-d268-dfdf4914cfd0\",\r\n      \"Msg_Pct_Links\": \"http://ccb-prod-oss.inboyu.com/upload/39e693ed-82e0-b541-9231-d80d5c47694a.jpg\",\r\n      \"Lgt\": \"115.839224\",\r\n      \"PD_Tp_ID\": \"39e693f1-cc4f-b652-d268-dfdf4914cfd0\",\r\n      \"Hs_Area\": \"49.01\",\r\n      \"Num\": \"1\",\r\n      \"Tpl_Len\": \"\",\r\n      \"Rsc_TpCd\": \"01\",\r\n      \"Room_Num\": \"1\",\r\n      \"Vd_Adr\": \"\",\r\n      \"Prj_ECD_Inf\": \"39e693ec-6741-d8f3-543c-f129b3c03e82\",\r\n      \"Prvd_Drc\": \"02\",\r\n      \"Ern_Stn_Nm\": \"\",\r\n      \"Lbl_Cmnt\": \"随时看房,独立卫生间,交通便利\",\r\n      \"Ltt\": \"28.741091\",\r\n      \"Unit_TpCd\": \"m\",\r\n      \"Prmt_Rsrvtn_Ind\": \"1\",\r\n      \"File_ID\": \"\",\r\n      \"HsStl_Cd\": \"1\",\r\n      \"HPrc\": \"2500.00\",\r\n      \"Num_2\": \"1\",\r\n      \"Ipnt_Room_Area\": \"36.03\",\r\n      \"Prj_Nm\": \"世纪新宸公寓\",\r\n      \"CntyAndDstc_Nm\": \"青山湖区\"\r\n    },\r\n    {\r\n      \"Lse_Area\": \"40.00\",\r\n      \"Src_URL_Adr\": \"http://ccb-prod-oss.inboyu.com/upload/39e7e131-1c05-824c-f383-0443c9df5832.jpg\",\r\n      \"Modl_Tp_Apl_Ind\": \"0\",\r\n      \"Rent_MoRent_Gld\": \"2000.00\",\r\n      \"LPrc\": \"2000.00\",\r\n      \"Floor_Num\": \"11\",\r\n      \"Comm_Nm\": \"新力外滩九号\",\r\n      \"Tot_Floor_Num\": \"\",\r\n      \"Seq_Mod_CgyCd\": \"0\",\r\n      \"Room_No\": \"39e88b92-9bee-22b8-4238-225df8122d6c\",\r\n      \"Msg_Pct_Links\": \"http://ccb-prod-oss.inboyu.com/upload/39e88b6e-595b-e870-9770-9df4975d6bdd.jpg\",\r\n      \"Lgt\": \"115.891187\",\r\n      \"PD_Tp_ID\": \"39e88b92-9bee-22b8-4238-225df8122d6c\",\r\n      \"Hs_Area\": \"55.00\",\r\n      \"Num\": \"1\",\r\n      \"Tpl_Len\": \"1.9\",\r\n      \"Rsc_TpCd\": \"01\",\r\n      \"Room_Num\": \"1\",\r\n      \"Vd_Adr\": \"\",\r\n      \"Prj_ECD_Inf\": \"39e877bf-d629-32b3-18b6-213c25216506\",\r\n      \"Prvd_Drc\": \"02\",\r\n      \"Ern_Stn_Nm\": \"珠江路站\",\r\n      \"Lbl_Cmnt\": \"品质公寓,随时看房\",\r\n      \"Ltt\": \"28.714340\",\r\n      \"Unit_TpCd\": \"km\",\r\n      \"Prmt_Rsrvtn_Ind\": \"1\",\r\n      \"File_ID\": \"39e7e135-9315-9c88-a67c-e76eb82be54f\",\r\n      \"HsStl_Cd\": \"1\",\r\n      \"HPrc\": \"3800.00\",\r\n      \"Num_2\": \"1\",\r\n      \"Ipnt_Room_Area\": \"40.00\",\r\n      \"Prj_Nm\": \"新力外滩九号\",\r\n      \"CntyAndDstc_Nm\": \"青山湖区\"\r\n    },\r\n    {\r\n      \"Lse_Area\": \"10.00\",\r\n      \"Src_URL_Adr\": \"\",\r\n      \"Modl_Tp_Apl_Ind\": \"0\",\r\n      \"Rent_MoRent_Gld\": \"200.00\",\r\n      \"LPrc\": \"200.00\",\r\n      \"Floor_Num\": \"1\",\r\n      \"Comm_Nm\": \"光电产业邻里中心\",\r\n      \"Tot_Floor_Num\": \"\",\r\n      \"Seq_Mod_CgyCd\": \"0\",\r\n      \"Room_No\": \"39e89c2a-f8a6-aca5-df9b-d4d06f388afb\",\r\n      \"Msg_Pct_Links\": \"http://ccb-prod-oss.inboyu.com/upload/39e89c24-2d87-f196-d8c7-b0da973ee7d4.jpg\",\r\n      \"Lgt\": \"116.057568\",\r\n      \"PD_Tp_ID\": \"39e89c2a-f8a6-aca5-df9b-d4d06f388afb\",\r\n      \"Hs_Area\": \"20.00\",\r\n      \"Num\": \"0\",\r\n      \"Tpl_Len\": \"12518.8\",\r\n      \"Rsc_TpCd\": \"01\",\r\n      \"Room_Num\": \"1\",\r\n      \"Vd_Adr\": \"\",\r\n      \"Prj_ECD_Inf\": \"39e89c1f-d8a1-003c-70ed-9ba64df7db6e\",\r\n      \"Prvd_Drc\": \"02\",\r\n      \"Ern_Stn_Nm\": \"\",\r\n      \"Lbl_Cmnt\": \"随时看房,环境优美,设施齐全\",\r\n      \"Ltt\": \"28.736136\",\r\n      \"Unit_TpCd\": \"m\",\r\n      \"Prmt_Rsrvtn_Ind\": \"1\",\r\n      \"File_ID\": \"\",\r\n      \"HsStl_Cd\": \"1\",\r\n      \"HPrc\": \"400.00\",\r\n      \"Num_2\": \"0\",\r\n      \"Ipnt_Room_Area\": \"10.00\",\r\n      \"Prj_Nm\": \"光电产业邻里中心\",\r\n      \"CntyAndDstc_Nm\": \"青山湖区\"\r\n    },\r\n    {\r\n      \"Lse_Area\": \"10.00\",\r\n      \"Src_URL_Adr\": \"\",\r\n      \"Modl_Tp_Apl_Ind\": \"0\",\r\n      \"Rent_MoRent_Gld\": \"200.00\",\r\n      \"LPrc\": \"200.00\",\r\n      \"Floor_Num\": \"1\",\r\n      \"Comm_Nm\": \"光电产业邻里中心\",\r\n      \"Tot_Floor_Num\": \"\",\r\n      \"Seq_Mod_CgyCd\": \"0\",\r\n      \"Room_No\": \"39e89c32-27f5-df6b-ee01-f18f26d119fd\",\r\n      \"Msg_Pct_Links\": \"http://ccb-prod-oss.inboyu.com/upload/39e89c2d-2d4a-7c27-1c98-6636d93139fe.jpg\",\r\n      \"Lgt\": \"116.057568\",\r\n      \"PD_Tp_ID\": \"39e89c32-27f5-df6b-ee01-f18f26d119fd\",\r\n      \"Hs_Area\": \"13.00\",\r\n      \"Num\": \"0\",\r\n      \"Tpl_Len\": \"12518.8\",\r\n      \"Rsc_TpCd\": \"01\",\r\n      \"Room_Num\": \"1\",\r\n      \"Vd_Adr\": \"\",\r\n      \"Prj_ECD_Inf\": \"39e89c1f-d8a1-003c-70ed-9ba64df7db6e\",\r\n      \"Prvd_Drc\": \"04\",\r\n      \"Ern_Stn_Nm\": \"\",\r\n      \"Lbl_Cmnt\": \"随时看房,环境优美,设施齐全\",\r\n      \"Ltt\": \"28.736136\",\r\n      \"Unit_TpCd\": \"m\",\r\n      \"Prmt_Rsrvtn_Ind\": \"1\",\r\n      \"File_ID\": \"\",\r\n      \"HsStl_Cd\": \"1\",\r\n      \"HPrc\": \"260.00\",\r\n      \"Num_2\": \"0\",\r\n      \"Ipnt_Room_Area\": \"10.00\",\r\n      \"Prj_Nm\": \"光电产业邻里中心\",\r\n      \"CntyAndDstc_Nm\": \"青山湖区\"\r\n    },\r\n    {\r\n      \"Lse_Area\": \"10.00\",\r\n      \"Src_URL_Adr\": \"\",\r\n      \"Modl_Tp_Apl_Ind\": \"0\",\r\n      \"Rent_MoRent_Gld\": \"5000.00\",\r\n      \"LPrc\": \"5000.00\",\r\n      \"Floor_Num\": \"1\",\r\n      \"Comm_Nm\": \"九九颐家康养中心\",\r\n      \"Tot_Floor_Num\": \"\",\r\n      \"Seq_Mod_CgyCd\": \"0\",\r\n      \"Room_No\": \"39e8e40e-64d0-b47b-d757-4e83908d05fb\",\r\n      \"Msg_Pct_Links\": \"http://ccb-prod-oss.inboyu.com/upload/39e8e40d-2e77-712e-5ae2-5f182cbe7c43.jpg\",\r\n      \"Lgt\": \"115.954603\",\r\n      \"PD_Tp_ID\": \"39e8e40e-64d0-b47b-d757-4e83908d05fb\",\r\n      \"Hs_Area\": \"100.00\",\r\n      \"Num\": \"0\",\r\n      \"Tpl_Len\": \"\",\r\n      \"Rsc_TpCd\": \"01\",\r\n      \"Room_Num\": \"1\",\r\n      \"Vd_Adr\": \"\",\r\n      \"Prj_ECD_Inf\": \"39e8df5f-8ccb-b675-1333-4c2d6666b7c5\",\r\n      \"Prvd_Drc\": \"\",\r\n      \"Ern_Stn_Nm\": \"\",\r\n      \"Lbl_Cmnt\": \"交通便利,环境优美,温馨宜人\",\r\n      \"Ltt\": \"28.667861\",\r\n      \"Unit_TpCd\": \"m\",\r\n      \"Prmt_Rsrvtn_Ind\": \"1\",\r\n      \"File_ID\": \"\",\r\n      \"HsStl_Cd\": \"1\",\r\n      \"HPrc\": \"5000.00\",\r\n      \"Num_2\": \"0\",\r\n      \"Ipnt_Room_Area\": \"10.00\",\r\n      \"Prj_Nm\": \"九九颐家康养中心\",\r\n      \"CntyAndDstc_Nm\": \"青山湖区\"\r\n    },\r\n    {\r\n      \"Lse_Area\": \"5.00\",\r\n      \"Src_URL_Adr\": \"\",\r\n      \"Modl_Tp_Apl_Ind\": \"0\",\r\n      \"Rent_MoRent_Gld\": \"8000.00\",\r\n      \"LPrc\": \"8000.00\",\r\n      \"Floor_Num\": \"2\",\r\n      \"Comm_Nm\": \"九九颐家康养中心\",\r\n      \"Tot_Floor_Num\": \"\",\r\n      \"Seq_Mod_CgyCd\": \"0\",\r\n      \"Room_No\": \"39e8e411-3a56-19a8-c173-b31196e94aff\",\r\n      \"Msg_Pct_Links\": \"http://ccb-prod-oss.inboyu.com/upload/39e8e411-1c9c-cb4d-542e-3259cf24af4e.jpg\",\r\n      \"Lgt\": \"115.954603\",\r\n      \"PD_Tp_ID\": \"39e8e411-3a56-19a8-c173-b31196e94aff\",\r\n      \"Hs_Area\": \"100.00\",\r\n      \"Num\": \"0\",\r\n      \"Tpl_Len\": \"\",\r\n      \"Rsc_TpCd\": \"01\",\r\n      \"Room_Num\": \"1\",\r\n      \"Vd_Adr\": \"\",\r\n      \"Prj_ECD_Inf\": \"39e8df5f-8ccb-b675-1333-4c2d6666b7c5\",\r\n      \"Prvd_Drc\": \"\",\r\n      \"Ern_Stn_Nm\": \"\",\r\n      \"Lbl_Cmnt\": \"交通便利,环境优美,温馨宜人\",\r\n      \"Ltt\": \"28.667861\",\r\n      \"Unit_TpCd\": \"m\",\r\n      \"Prmt_Rsrvtn_Ind\": \"1\",\r\n      \"File_ID\": \"\",\r\n      \"HsStl_Cd\": \"1\",\r\n      \"HPrc\": \"8000.00\",\r\n      \"Num_2\": \"0\",\r\n      \"Ipnt_Room_Area\": \"5.00\",\r\n      \"Prj_Nm\": \"九九颐家康养中心\",\r\n      \"CntyAndDstc_Nm\": \"青山湖区\"\r\n    },\r\n    {\r\n      \"Lse_Area\": \"44.00\",\r\n      \"Src_URL_Adr\": \"\",\r\n      \"Modl_Tp_Apl_Ind\": \"0\",\r\n      \"Rent_MoRent_Gld\": \"800.00\",\r\n      \"LPrc\": \"800.00\",\r\n      \"Floor_Num\": \"1\",\r\n      \"Comm_Nm\": \"昱博科技园\",\r\n      \"Tot_Floor_Num\": \"\",\r\n      \"Seq_Mod_CgyCd\": \"0\",\r\n      \"Room_No\": \"39ecacda-a8e3-7cb6-aac7-446c4615b2ed\",\r\n      \"Msg_Pct_Links\": \"http://ccb-prod-oss.inboyu.com/upload/39ecacd5-4927-ee7d-6712-076af50ebe54.jpg\",\r\n      \"Lgt\": \"115.909040\",\r\n      \"PD_Tp_ID\": \"39ecacda-a8e3-7cb6-aac7-446c4615b2ed\",\r\n      \"Hs_Area\": \"44.00\",\r\n      \"Num\": \"1\",\r\n      \"Tpl_Len\": \"12503.4\",\r\n      \"Rsc_TpCd\": \"01\",\r\n      \"Room_Num\": \"1\",\r\n      \"Vd_Adr\": \"\",\r\n      \"Prj_ECD_Inf\": \"39ecacd0-dced-d5f7-229f-eceecdd2287c\",\r\n      \"Prvd_Drc\": \"09\",\r\n      \"Ern_Stn_Nm\": \"\",\r\n      \"Lbl_Cmnt\": \"随时看房,独立卫生间,独立阳台\",\r\n      \"Ltt\": \"28.786690\",\r\n      \"Unit_TpCd\": \"m\",\r\n      \"Prmt_Rsrvtn_Ind\": \"1\",\r\n      \"File_ID\": \"\",\r\n      \"HsStl_Cd\": \"1\",\r\n      \"HPrc\": \"800.00\",\r\n      \"Num_2\": \"1\",\r\n      \"Ipnt_Room_Area\": \"44.00\",\r\n      \"Prj_Nm\": \"昱博科技园\",\r\n      \"CntyAndDstc_Nm\": \"青山湖区\"\r\n    },\r\n    {\r\n      \"Lse_Area\": \"31.26\",\r\n      \"Src_URL_Adr\": \"\",\r\n      \"Modl_Tp_Apl_Ind\": \"0\",\r\n      \"Rent_MoRent_Gld\": \"1200.00\",\r\n      \"LPrc\": \"1200.00\",\r\n      \"Floor_Num\": \"6\",\r\n      \"Comm_Nm\": \"长泰公寓\",\r\n      \"Tot_Floor_Num\": \"28\",\r\n      \"Seq_Mod_CgyCd\": \"0\",\r\n      \"Room_No\": \"39ee8b54-9423-008a-b64f-f37ed030cbc6\",\r\n      \"Msg_Pct_Links\": \"http://ccb-prod-oss.inboyu.com/upload/39ee8b4d-c788-a62e-0d6d-67ae4a5c304f.jpg\",\r\n      \"Lgt\": \"115.954278\",\r\n      \"PD_Tp_ID\": \"39ee8b54-9423-008a-b64f-f37ed030cbc6\",\r\n      \"Hs_Area\": \"42.10\",\r\n      \"Num\": \"0\",\r\n      \"Tpl_Len\": \"769.7\",\r\n      \"Rsc_TpCd\": \"01\",\r\n      \"Room_Num\": \"1\",\r\n      \"Vd_Adr\": \"\",\r\n      \"Prj_ECD_Inf\": \"39ee864e-01af-bd3f-c2f1-2f4b28137a9f\",\r\n      \"Prvd_Drc\": \"\",\r\n      \"Ern_Stn_Nm\": \"青山湖大道\",\r\n      \"Lbl_Cmnt\": \"独卫,拎包入住,随时看房\",\r\n      \"Ltt\": \"28.687178\",\r\n      \"Unit_TpCd\": \"m\",\r\n      \"Prmt_Rsrvtn_Ind\": \"1\",\r\n      \"File_ID\": \"\",\r\n      \"HsStl_Cd\": \"1\",\r\n      \"HPrc\": \"1300.00\",\r\n      \"Num_2\": \"1\",\r\n      \"Ipnt_Room_Area\": \"31.26\",\r\n      \"Prj_Nm\": \"长泰公寓\",\r\n      \"CntyAndDstc_Nm\": \"青山湖区\"\r\n    },\r\n    {\r\n      \"Lse_Area\": \"51.26\",\r\n      \"Src_URL_Adr\": \"\",\r\n      \"Modl_Tp_Apl_Ind\": \"0\",\r\n      \"Rent_MoRent_Gld\": \"1500.00\",\r\n      \"LPrc\": \"1500.00\",\r\n      \"Floor_Num\": \"4\",\r\n      \"Comm_Nm\": \"长泰公寓\",\r\n      \"Tot_Floor_Num\": \"28\",\r\n      \"Seq_Mod_CgyCd\": \"0\",\r\n      \"Room_No\": \"39ee8b5b-c024-83b2-1edf-564ec80185b8\",\r\n      \"Msg_Pct_Links\": \"http://ccb-prod-oss.inboyu.com/upload/39ee8b58-6b58-ff33-dd9b-c400c7c947f5.jpg\",\r\n      \"Lgt\": \"115.954278\",\r\n      \"PD_Tp_ID\": \"39ee8b5b-c024-83b2-1edf-564ec80185b8\",\r\n      \"Hs_Area\": \"51.26\",\r\n      \"Num\": \"1\",\r\n      \"Tpl_Len\": \"769.7\",\r\n      \"Rsc_TpCd\": \"01\",\r\n      \"Room_Num\": \"1\",\r\n      \"Vd_Adr\": \"\",\r\n      \"Prj_ECD_Inf\": \"39ee864e-01af-bd3f-c2f1-2f4b28137a9f\",\r\n      \"Prvd_Drc\": \"\",\r\n      \"Ern_Stn_Nm\": \"青山湖大道\",\r\n      \"Lbl_Cmnt\": \"独卫,拎包入住,随时看房\",\r\n      \"Ltt\": \"28.687178\",\r\n      \"Unit_TpCd\": \"m\",\r\n      \"Prmt_Rsrvtn_Ind\": \"1\",\r\n      \"File_ID\": \"\",\r\n      \"HsStl_Cd\": \"1\",\r\n      \"HPrc\": \"1500.00\",\r\n      \"Num_2\": \"1\",\r\n      \"Ipnt_Room_Area\": \"51.26\",\r\n      \"Prj_Nm\": \"长泰公寓\",\r\n      \"CntyAndDstc_Nm\": \"青山湖区\"\r\n    },\r\n    {\r\n      \"Lse_Area\": \"119.80\",\r\n      \"Src_URL_Adr\": \"\",\r\n      \"Modl_Tp_Apl_Ind\": \"0\",\r\n      \"Rent_MoRent_Gld\": \"3200.00\",\r\n      \"LPrc\": \"3200.00\",\r\n      \"Floor_Num\": \"4\",\r\n      \"Comm_Nm\": \"长泰公寓\",\r\n      \"Tot_Floor_Num\": \"28\",\r\n      \"Seq_Mod_CgyCd\": \"0\",\r\n      \"Room_No\": \"39ee8b63-edc3-a69b-fd74-b642f3d52179\",\r\n      \"Msg_Pct_Links\": \"http://ccb-prod-oss.inboyu.com/upload/39ee8b5e-fc75-9c71-04d3-9433e5a9ae27.jpg\",\r\n      \"Lgt\": \"115.954278\",\r\n      \"PD_Tp_ID\": \"39ee8b63-edc3-a69b-fd74-b642f3d52179\",\r\n      \"Hs_Area\": \"119.80\",\r\n      \"Num\": \"2\",\r\n      \"Tpl_Len\": \"769.7\",\r\n      \"Rsc_TpCd\": \"01\",\r\n      \"Room_Num\": \"2\",\r\n      \"Vd_Adr\": \"\",\r\n      \"Prj_ECD_Inf\": \"39ee864e-01af-bd3f-c2f1-2f4b28137a9f\",\r\n      \"Prvd_Drc\": \"\",\r\n      \"Ern_Stn_Nm\": \"青山湖大道\",\r\n      \"Lbl_Cmnt\": \"独卫,拎包入住,随时看房\",\r\n      \"Ltt\": \"28.687178\",\r\n      \"Unit_TpCd\": \"m\",\r\n      \"Prmt_Rsrvtn_Ind\": \"1\",\r\n      \"File_ID\": \"\",\r\n      \"HsStl_Cd\": \"1\",\r\n      \"HPrc\": \"3200.00\",\r\n      \"Num_2\": \"2\",\r\n      \"Ipnt_Room_Area\": \"119.80\",\r\n      \"Prj_Nm\": \"长泰公寓\",\r\n      \"CntyAndDstc_Nm\": \"青山湖区\"\r\n    }\r\n  ],\r\n  \"Tot_Pg_Num\": \"8\",\r\n  \"_COMMON\": {\r\n    \"SYS_EVT_TRACE_ID\": \"1020018111565682264705009\",\r\n    \"P2S_EVT_TRACE_ID\": \"1020018111565682264705009\"\r\n  },\r\n  \"BK_CODE\": \"000000000000\",\r\n  \"Pg_Num\": \"1\",\r\n  \"Tot_Num\": \"79\"\r\n}";

            string houseA = hourseRes.Replace(StarHelper.m_strEnd, "").Replace("\\r\\n", "").Replace("\\", "").Replace("\"{", "{").Replace("}\"", "}");

            RootHourse rootHourse = JsonConvert.DeserializeObject<RootHourse>(hourseRes);

            List<ItemsItem> itemList = rootHourse.items;

            itemsControl.ItemsSource = itemList;
            #endregion
            ThreePage.Visibility = Visibility.Visible;
            TwoPage.Visibility = Visibility.Hidden;
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            
        }
        /// <summary>
        /// 市区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WuHan_Clity(object sender, RoutedEventArgs e)
        {

        }
    }
}
