using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Net;
using ASTROLOGY.classesoracle;
using System.Text;
using System.Collections.Generic;
using NReco.PdfGenerator;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;

public partial class compatibilitymatchingreport : System.Web.UI.Page
{
    StringBuilder strData = new StringBuilder();
    public int  Count = 1;
    public  string Gender = "";
    StringBuilder strCart = new StringBuilder();
    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
    compatibilitymatching cm = new compatibilitymatching();
    subscription obj_subs = new subscription();
    Houseposition objhp = new Houseposition();
    public string WEBSITEDomainVal = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString(); DataTable dt = new DataTable();
    DataTable dtmd = new DataTable();
    DataTable dtds = new DataTable();
    DataTable dtdsboy = new DataTable();
    ASTROLOGY.classesoracle.myaccount objmc = new ASTROLOGY.classesoracle.myaccount();
    DataTable dtdsgirl = new DataTable();
    string BoyLagnaPoints, BoyMoonPoints, BoyVenusPoints, BoyTotalPoints, GirlLagnaPoints, GirlMoonPoints, GirlVenusPoints, GirlTotalPoints;
    string BoyDoshaSamyaTotalPoints, GirlDoshaSamyaTotalPoints;
    DataSet objds = new DataSet();
    public string BoyId = "", GirlId = "";
    public string p21 = "", p22 = "", p23 = "", p24 = "", p25 = "", p26 = "", p27 = "", p28 = "", p29 = "", p210 = "", p211 = "", p212 = "", HeaderValue = "";
    public string j21 = "", j22 = "", j23 = "", j24 = "", j25 = "", j26 = "", j27 = "", j28 = "", j29 = "", j210 = "", j211 = "", j212 = "";
    public string h21 = "", h22 = "", h23 = "", h24 = "", h25 = "", h26 = "", h27 = "", h28 = "", h29 = "", h210 = "", h211 = "", r11 = "", h212 = "";
    public string r21 = "", r22 = "", r23 = "", r24 = "", r25 = "", r26 = "", r27 = "", r28 = "", r29 = "", r210 = "", r211 = "", r212 = "";
    public List<string> lstPlanetRashiId = new List<string>();
    public List<string> D1lstHouse1 = new List<string>();
    public List<string> D1Rashi = new List<string>();
    public List<string> D1BirthTime = new List<string>();
    public List<string> D1Retro = new List<string>();
    public List<string> D1Degree = new List<string>();
    public List<string> D9lstHouse1 = new List<string>();
    public List<string> D9Rashi = new List<string>();
    public List<string> D03lstHouse1 = new List<string>();
    public List<string> D03Rashi = new List<string>();
    public List<string> D10lstHouse1 = new List<string>();
    public List<string> D10Rashi = new List<string>();
    public List<string> D4lstHouse1 = new List<string>();
    public List<string> D4Rashi = new List<string>();
    public List<string> D24lstHouse1 = new List<string>();
    public List<string> D24Rashi = new List<string>();
    public List<string> D60lstHouse1 = new List<string>();
    public List<string> D60Rashi = new List<string>();
    public List<string> D2lstHouse1 = new List<string>();
    public List<string> D2Rashi = new List<string>();
    public List<string> D07lstHouse1 = new List<string>();
    public List<string> D07Rashi = new List<string>();
    public List<string> D12lstHouse1 = new List<string>();
    public List<string> D12Rashi = new List<string>();
    public List<string> D16lstHouse1 = new List<string>();
    public List<string> D16Rashi = new List<string>();
    public List<string> D30lstHouse1 = new List<string>();
    public List<string> D30Rashi = new List<string>();
    public List<string> D45lstHouse1 = new List<string>();
    public List<string> D45Rashi = new List<string>();
    public List<string> D20lstHouse1 = new List<string>();
    public List<string> D20Rashi = new List<string>();
    public List<string> D27lstHouse1 = new List<string>();
    public List<string> D27Rashi = new List<string>();
    public List<string> D40lstHouse1 = new List<string>();
    public List<string> D40Rashi = new List<string>();
    public List<string> D05lstHouse1 = new List<string>();
    public List<string> D05Rashi = new List<string>();
    public List<string> D06lstHouse1 = new List<string>();
    public List<string> D06Rashi = new List<string>();
    public List<string> D08lstHouse1 = new List<string>();
    public List<string> D08Rashi = new List<string>();
    public List<string> D11lstHouse1 = new List<string>();
    public List<string> D11Rashi = new List<string>();
    public List<string> DKLlstHouse1 = new List<string>();
    public List<string> DKLRashi = new List<string>();
    public List<string> DMoonlstHouse1 = new List<string>();
    public List<string> DMoonRashi = new List<string>();
    public List<string> DVenuslstHouse1 = new List<string>();
    public List<string> DVenusRashi = new List<string>();
    decimal sumFooterValue = 0, sumMDBFooterValue = 0, sumMDGFooterValue = 0, sumDSBFooterValue = 0, sumDSGFooterValue = 0;
    public string FlagForPDF="", Sucolor = "#FF0000", MaColor = "#C74F4F", VeColor = "#FA0095", MeColor = "#087830", Jucolor = "#F25E0A", KeColor = "#708090", MoColor = "#3CA9EE", SaColor = "#00008B", GkColor = "#C71585", RaColor = "#000000", AscColor = "#FF8C00";
    public int Houes1Value = 0, Houes2Value = 0, Houes3Value = 0, Houes4Value = 0, Houes5Value = 0, Houes6Value = 0, Houes7Value = 0, Houes8Value = 0, Houes9Value = 0, Houes10Value = 0, Houes11Value = 0, Houes12Value = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Deepak Add the following 2 lines for refresh the CartId
            string intrandom = Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day) + Convert.ToString(DateTime.Now.Hour) + Convert.ToString(DateTime.Now.Minute) + Convert.ToString(DateTime.Now.Second) + Convert.ToString(DateTime.Now.Millisecond);
            Session["MySessionID"] = intrandom;

            //if (Session["UserEmailID"] != null)
            //{
            astrologo.InnerHtml = "<a href=\"" + ResolveUrl("~/index.html") + "\" title=\"Astro Envision\">";
            astrologo.InnerHtml += "<img src=\"" + WEBSITEDomainVal + "/Image/large_logo.svg\" alt=\"Astro Envision\" title=\"Astro Envision\" />";
            astrologo.InnerHtml += "</a>";
            astrofreereport.InnerHtml = "<div style='padding:0em 0em 0em 0em;margin: 0em 0em 0.4em 0em;height: 40px;vertical-align: top;width: 100%;text-align: center;font-size: 1.4em;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;'><img style='width: 35px;' src=\"" + WEBSITEDomainVal + "/Image/om_small.png\" alt=\"Astro Envision\" title=\"Astro Envision\" />&nbsp;Kundli Compatibility Matching Report&nbsp;<img style='width: 35px;' src=\"" + WEBSITEDomainVal + "/Image/om_small.png\" alt=\"Astro Envision\" title=\"Astro Envision\" /></div>";
            GetMatchingReport();
            BindBasicDeatis("");
            BindCharts();
            //}
            //else
            //{
            //    Response.Redirect(ResolveUrl("~/index.html"));
            //}
        }
    }
    #region Bind Matching Reports
    void GetMatchingReport()
    {
        try
        {
            if (Request.QueryString["cartid"] != null)
            {
                DataSet dsbyd = new DataSet();
                dsbyd = obj_subs.AstGetCommon(Request.QueryString["cartid"].ToString().Trim(), "", "", "GET_KUNDLI_MATCHING_BOY_GIRL_IDS");
                if (dsbyd.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dsbyd.Tables[0].Rows.Count; i++)
                    {
                        if (dsbyd.Tables[0].Rows[i]["GENDER"].ToString().Trim() == "M")
                        {
                            BoyId = dsbyd.Tables[0].Rows[i]["ID"].ToString().Trim();
                        }
                        if (dsbyd.Tables[0].Rows[i]["GENDER"].ToString().Trim() == "F")
                        {
                            GirlId = dsbyd.Tables[0].Rows[i]["ID"].ToString().Trim();
                        }
                    }
                }
                dsbyd.Dispose();
            }

            //if (Request.QueryString["BoyId"] != null && Request.QueryString["GirlId"] != null)
            //{
            //if (Request.QueryString["BoyId"] != null)
            //{
            //    BoyId = Request.QueryString["BoyId"].Trim();
            //}
            //if (Request.QueryString["GirlId"] != null)
            //{
            //    GirlId = Request.QueryString["GirlId"].Trim();
            //}
            ViewState["FinalReport"] = "";
            ViewState["NadiReport"] = "";
            ViewState["NadiReportDiv2"] = "";
            ViewState["BhakootReport"] = "";
            ViewState["GanaReport"] = "";
            ViewState["GrahamaitriReport"] = "";
            ViewState["YoniReport"] = "";
            ViewState["TaraReport"] = "";
            ViewState["VasyaReport"] = "";
            ViewState["VarnaReport"] = "";
            ViewState["NakashtraReportDiv"] = "";
            ViewState["EkaNakashtraReportDiv"] = "";
            ViewState["Nakashtra27thReportDiv"] = "";
            ViewState["VadhaVainasikaReportDiv"] = "";
            ViewState["ManglikDoshaDiv1"] = "";
            ViewState["ManglikDoshaDiv2"] = "";
            ViewState["DoshaSamyaDiv1"] = "";
            ViewState["DoshaSamyaDiv2"] = "";
            ViewState["KaalSarpaYogaDiv"] = "";

            //BoyId = "5"; GirlId = "6";
            DataSet ds = new DataSet();
            ds = cm.GetAshthakootNadiMatch(BoyId, GirlId, "GET_MATCHING_REPORT");
            if (ds.Tables[0].Rows.Count > 0)
            {
                string BoyName = ds.Tables[0].Rows[0]["BOY_NAME"].ToString().Trim();
                string BoyNadi = ds.Tables[0].Rows[0]["BOY_NADI"].ToString().Trim();
                string GirlName = ds.Tables[1].Rows[0]["GIRL_NAME"].ToString().Trim();
                string GirlNadi = ds.Tables[1].Rows[0]["GIRL_NADI"].ToString().Trim();

                ViewState["BoyName"] = BoyName;
                ViewState["GirlName"] = GirlName;
                string MatchedGunasVal = "0", IsExceptionMatchVal = "N", DoshaStatusVal = "Unmatched";
                if (ds.Tables[2].Rows.Count > 0)
                {
                    string DefinitionVal = ds.Tables[2].Rows[0]["DEFINITION"].ToString().Trim();
                    string PredictiveVal = ds.Tables[2].Rows[0]["PREDICTIVE"].ToString().Trim();
                    string RemedialVal = ds.Tables[2].Rows[0]["REMEDIAL"].ToString().Trim();
                    string ExpertOpinionVal = ds.Tables[2].Rows[0]["EXPERT_OPINION"].ToString().Trim();
                    string htmlstr = "";
                    NadiReportDiv1.InnerHtml = DefinitionVal;
                    ViewState["NadiReport"] = DefinitionVal;
                    if (PredictiveVal != "")
                    {
                        htmlstr = PredictiveVal.Replace("BBBBNADI", BoyNadi).Replace("GGGGNADI", GirlNadi).Replace("BBBB", BoyName).Replace("GGGG", GirlName);
                    }
                    if (ExpertOpinionVal != "")
                    {
                        htmlstr += "" + ExpertOpinionVal.Replace("BOYNAME", BoyName).Replace("GIRLNAME", GirlName).Replace("BBBBNADI", BoyNadi).Replace("GGGGNADI", GirlNadi);
                    }
                    if (RemedialVal != "")
                    {
                        htmlstr += "" + RemedialVal;
                    }
                    NadiReportDiv2.InnerHtml = htmlstr;
                    ViewState["NadiReportDiv2"] = htmlstr;

                    MatchedGunasVal = ds.Tables[2].Rows[0]["MATCHEDPOINT"].ToString().Trim();
                    IsExceptionMatchVal = ds.Tables[2].Rows[0]["ISMATCHEXCEPTION"].ToString().Trim();
                    DoshaStatusVal = ds.Tables[2].Rows[0]["DOSHASTATUS"].ToString().Trim();
                }
                dt.Columns.AddRange(new DataColumn[8] { new DataColumn("SNo"), new DataColumn("KootName"), new DataColumn("GirlKootName"), new DataColumn("BoyKootName"), new DataColumn("MaximumGunas"), new DataColumn("MatchedGunas"), new DataColumn("DoshaStatus"), new DataColumn("IsExceptionMatch") });
                dt.Rows.Add(1, "Nadi", FirstCharToUpper(GirlNadi), FirstCharToUpper(BoyNadi), "8", MatchedGunasVal, DoshaStatusVal, IsExceptionMatchVal);
            }
            ds.Dispose();

            DataSet dsb = new DataSet();
            dsb = cm.GetAshthakootBhakootMatch(BoyId, GirlId, "", "", "GET_MATCHING_REPORT");
            if (dsb.Tables[0].Rows.Count > 0)
            {
                string DefinitionVal = "", PredictiveVal = "", MatchedGunasVal = "0", IsExceptionMatchVal = "N", DoshaStatusVal = "Unmatched";
                string BoyName = dsb.Tables[0].Rows[0]["BOY_NAME"].ToString().Trim();
                string BoyRashi = dsb.Tables[0].Rows[0]["BOY_RASHI"].ToString().Trim();
                string GirlName = dsb.Tables[1].Rows[0]["GIRL_NAME"].ToString().Trim();
                string GirlRashi = dsb.Tables[1].Rows[0]["GIRL_RASHI"].ToString().Trim();
                if (dsb.Tables[2].Rows.Count > 0)
                {
                    DefinitionVal = dsb.Tables[2].Rows[0]["DEFINITION"].ToString().Trim();
                    PredictiveVal = dsb.Tables[2].Rows[0]["PREDICTIVE"].ToString().Trim();
                    BhakootReportdiv.InnerHtml = DefinitionVal;
                    BhakootReportdiv.InnerHtml += "" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBRASHI", BoyRashi).Replace("GGGGRASHI", GirlRashi);
                    ViewState["BhakootReport"] = DefinitionVal;
                    ViewState["BhakootReportLastRow"] = "" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBRASHI", BoyRashi).Replace("GGGGRASHI", GirlRashi);
                    MatchedGunasVal = dsb.Tables[2].Rows[0]["MATCHEDPOINT"].ToString().Trim();
                    IsExceptionMatchVal = dsb.Tables[2].Rows[0]["ISMATCHEXCEPTION"].ToString().Trim();
                    DoshaStatusVal = dsb.Tables[2].Rows[0]["DOSHASTATUS"].ToString().Trim();
                }
                dt.Rows.Add(2, "Bhakoot", FirstCharToUpper(GirlRashi), FirstCharToUpper(BoyRashi), "7", MatchedGunasVal, DoshaStatusVal, IsExceptionMatchVal);
            }
            dsb.Dispose();


            DataSet dsg = new DataSet();
            dsg = cm.GetAshthakootGanaMatch(BoyId, GirlId, "", "", "GET_MATCHING_REPORT");
            if (dsg.Tables[2].Rows.Count > 0)
            {
                string BoyName = dsg.Tables[0].Rows[0]["BOY_NAME"].ToString().Trim();
                string BoyGana = dsg.Tables[0].Rows[0]["BOY_GANA"].ToString().Trim();
                string GirlName = dsg.Tables[1].Rows[0]["GIRL_NAME"].ToString().Trim();
                string GirlGana = dsg.Tables[1].Rows[0]["GIRL_GANA"].ToString().Trim();
                string PredictiveVal = dsg.Tables[2].Rows[0]["PREDICTIVE"].ToString().Trim();
                string DefinitionVal = dsg.Tables[2].Rows[0]["DEFINITION"].ToString().Trim();
                GanaReportDiv.InnerHtml = DefinitionVal;
                GanaReportDiv.InnerHtml += "" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBGANA", BoyGana).Replace("GGGGGANA", GirlGana);
                ViewState["GanaReport"] = DefinitionVal + "" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBGANA", BoyGana).Replace("GGGGGANA", GirlGana);
                string MatchedGunasVal = dsg.Tables[2].Rows[0]["MATCHEDPOINT"].ToString().Trim();
                string IsExceptionMatchVal = dsg.Tables[2].Rows[0]["ISMATCHEXCEPTION"].ToString().Trim();
                string DoshaStatusVal = dsg.Tables[2].Rows[0]["DOSHASTATUS"].ToString().Trim();
                dt.Rows.Add(3, "Gana", FirstCharToUpper(GirlGana), FirstCharToUpper(BoyGana), "6", MatchedGunasVal, DoshaStatusVal, IsExceptionMatchVal);
            }
            dsg.Dispose();

            DataSet dsgm = new DataSet();
            dsgm = cm.GetAshthakootGrahamaitriMatch(BoyId, GirlId, "", "", "GET_MATCHING_REPORT");
            if (dsgm.Tables[2].Rows.Count > 0)
            {
                string BoyName = dsgm.Tables[0].Rows[0]["BOY_NAME"].ToString().Trim();
                string BoyRashiLord = dsgm.Tables[0].Rows[0]["BOY_LORD"].ToString().Trim();
                string GirlName = dsgm.Tables[1].Rows[0]["GIRL_NAME"].ToString().Trim();
                string GirlRashiLord = dsgm.Tables[1].Rows[0]["GIRL_LORD"].ToString().Trim();
                string PredictiveVal = dsgm.Tables[2].Rows[0]["PREDICTIVE"].ToString().Trim();
                string DefinitionVal = dsgm.Tables[2].Rows[0]["DEFINITION"].ToString().Trim();
                GrahamaitriReportDiv.InnerHtml = DefinitionVal;
                GrahamaitriReportDiv.InnerHtml += "" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBPPPP", BoyRashiLord).Replace("GGGGPPPP", GirlRashiLord);
                ViewState["GrahamaitriReport"] = DefinitionVal + "" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBPPPP", BoyRashiLord).Replace("GGGGPPPP", GirlRashiLord);
                string MatchedGunasVal = dsgm.Tables[2].Rows[0]["MATCHEDPOINT"].ToString().Trim();
                string IsExceptionMatchVal = dsgm.Tables[2].Rows[0]["ISMATCHEXCEPTION"].ToString().Trim();
                string DoshaStatusVal = dsgm.Tables[2].Rows[0]["DOSHASTATUS"].ToString().Trim();
                dt.Rows.Add(4, "Grahamaitri", FirstCharToUpper(GirlRashiLord), FirstCharToUpper(BoyRashiLord), "5", MatchedGunasVal, DoshaStatusVal, IsExceptionMatchVal);
            }
            dsgm.Dispose();

            DataSet dsyn = new DataSet();
            dsyn = cm.GetAshthakootYoniMatch(BoyId, GirlId, "GET_MATCHING_REPORT");
            if (dsyn.Tables[2].Rows.Count > 0)
            {
                string BoyName = dsyn.Tables[0].Rows[0]["BOY_NAME"].ToString().Trim();
                string BoyYoni = dsyn.Tables[0].Rows[0]["BOY_YONI"].ToString().Trim();
                string GirlName = dsyn.Tables[1].Rows[0]["GIRL_NAME"].ToString().Trim();
                string GirlYoni = dsyn.Tables[1].Rows[0]["GIRL_YONI"].ToString().Trim();
                string PredictiveVal = dsyn.Tables[2].Rows[0]["PREDICTIVE"].ToString().Trim();
                string DefinitionVal = dsyn.Tables[2].Rows[0]["DEFINITION"].ToString().Trim();
                YoniReportDiv.InnerHtml = DefinitionVal;
                YoniReportDiv.InnerHtml += "" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBYYYY", BoyYoni).Replace("GGGGYYYY", GirlYoni);
                ViewState["YoniReport"] = DefinitionVal + "" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBYYYY", BoyYoni).Replace("GGGGYYYY", GirlYoni);
                string MatchedGunasVal = dsyn.Tables[2].Rows[0]["MATCHEDPOINT"].ToString().Trim();
                string IsExceptionMatchVal = dsyn.Tables[2].Rows[0]["ISMATCHEXCEPTION"].ToString().Trim();
                string DoshaStatusVal = dsyn.Tables[2].Rows[0]["DOSHASTATUS"].ToString().Trim();
                dt.Rows.Add(5, "Yoni", FirstCharToUpper(GirlYoni), FirstCharToUpper(BoyYoni), "4", MatchedGunasVal, DoshaStatusVal, IsExceptionMatchVal);
            }
            dsyn.Dispose();


            DataSet dstara = new DataSet();
            dstara = cm.GetAshthakootTaraMatch(BoyId, GirlId, "GET_MATCHING_REPORT");
            if (dstara.Tables[4].Rows.Count > 0)
            {
                string BoyName = dstara.Tables[0].Rows[0]["BOY_NAME"].ToString().Trim();
                string BoyTara = dstara.Tables[2].Rows[0]["BOY_TARA"].ToString().Trim();
                string GirlName = dstara.Tables[1].Rows[0]["GIRL_NAME"].ToString().Trim();
                string GirlTara = dstara.Tables[3].Rows[0]["GIRL_TARA"].ToString().Trim();
                string PredictiveVal = dstara.Tables[4].Rows[0]["PREDICTIVE"].ToString().Trim();
                string DefinitionVal = dstara.Tables[4].Rows[0]["DEFINITION"].ToString().Trim();
                TaraReportDiv.InnerHtml = DefinitionVal;
                TaraReportDiv.InnerHtml += "" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBTTTT", BoyTara).Replace("GGGGTTTT", GirlTara);
                ViewState["TaraReport"] = DefinitionVal + "" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBTTTT", BoyTara).Replace("GGGGTTTT", GirlTara);
                string MatchedGunasVal = dstara.Tables[4].Rows[0]["MATCHEDPOINT"].ToString().Trim();
                string IsExceptionMatchVal = dstara.Tables[4].Rows[0]["ISMATCHEXCEPTION"].ToString().Trim();
                string DoshaStatusVal = dstara.Tables[4].Rows[0]["DOSHASTATUS"].ToString().Trim();
                dt.Rows.Add(6, "Tara", FirstCharToUpper(GirlTara), FirstCharToUpper(BoyTara), "3", MatchedGunasVal, DoshaStatusVal, IsExceptionMatchVal);
            }
            dstara.Dispose();

            DataSet dsvs = new DataSet();
            dsvs = cm.GetAshthakootVasyaMatch(BoyId, GirlId, "GET_MATCHING_REPORT");
            if (dsvs.Tables[2].Rows.Count > 0)
            {
                string BoyName = dsvs.Tables[0].Rows[0]["BOY_NAME"].ToString().Trim();
                string BoyYasya = dsvs.Tables[2].Rows[0]["BOY_VASYA"].ToString().Trim();
                string GirlName = dsvs.Tables[1].Rows[0]["GIRL_NAME"].ToString().Trim();
                string GirlYasya = dsvs.Tables[3].Rows[0]["GIRL_VASYA"].ToString().Trim();
                string PredictiveVal = dsvs.Tables[4].Rows[0]["PREDICTIVE"].ToString().Trim();
                string DefinitionVal = dsvs.Tables[4].Rows[0]["DEFINITION"].ToString().Trim();
                VasyaReportDiv.InnerHtml = DefinitionVal;
                VasyaReportDiv.InnerHtml += "" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBVVVV", BoyYasya).Replace("GGGGVVVV", GirlYasya);
                ViewState["VasyaReport"] = DefinitionVal + "" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBVVVV", BoyYasya).Replace("GGGGVVVV", GirlYasya);
                string MatchedGunasVal = dsvs.Tables[4].Rows[0]["MATCHEDPOINT"].ToString().Trim();
                string IsExceptionMatchVal = dsvs.Tables[4].Rows[0]["ISMATCHEXCEPTION"].ToString().Trim();
                string DoshaStatusVal = dsvs.Tables[4].Rows[0]["DOSHASTATUS"].ToString().Trim();
                dt.Rows.Add(7, "Vasya", FirstCharToUpper(GirlYasya), FirstCharToUpper(BoyYasya), "2", MatchedGunasVal, DoshaStatusVal, IsExceptionMatchVal);
            }
            dsvs.Dispose();

            DataSet dsvrna = new DataSet();
            dsvrna = cm.GetAshthakootVarnaMatch(BoyId, GirlId, "", "", "GET_MATCHING_REPORT");
            if (dsvrna.Tables[2].Rows.Count > 0)
            {
                string BoyName = dsvrna.Tables[0].Rows[0]["BOY_NAME"].ToString().Trim();
                string BoyRashiVarna = dsvrna.Tables[0].Rows[0]["BOY_VARNA"].ToString().Trim();
                string GirlName = dsvrna.Tables[1].Rows[0]["GIRL_NAME"].ToString().Trim();
                string GirlRashiVarna = dsvrna.Tables[1].Rows[0]["GIRL_VARNA"].ToString().Trim();
                string PredictiveVal = dsvrna.Tables[2].Rows[0]["PREDICTIVE"].ToString().Trim();
                string DefinitionVal = dsvrna.Tables[2].Rows[0]["DEFINITION"].ToString().Trim();
                VarnaReportDiv.InnerHtml = DefinitionVal;
                VarnaReportDiv.InnerHtml += "" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBVVVV", BoyRashiVarna).Replace("GGGGVVVV", GirlRashiVarna);
                ViewState["VarnaReport"] = DefinitionVal + "" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBVVVV", BoyRashiVarna).Replace("GGGGVVVV", GirlRashiVarna);
                string MatchedGunasVal = dsvrna.Tables[2].Rows[0]["MATCHEDPOINT"].ToString().Trim();
                string IsExceptionMatchVal = dsvrna.Tables[2].Rows[0]["ISMATCHEXCEPTION"].ToString().Trim();
                string DoshaStatusVal = dsvrna.Tables[2].Rows[0]["DOSHASTATUS"].ToString().Trim();
                dt.Rows.Add(8, "Varna", FirstCharToUpper(GirlRashiVarna), FirstCharToUpper(BoyRashiVarna), "1", MatchedGunasVal, DoshaStatusVal, IsExceptionMatchVal);
            }
            dsvrna.Dispose();

            DataSet dsnakashtra = new DataSet();
            dsnakashtra = cm.GetNakashtraDosha(BoyId, GirlId, "", "", "GET_MATCHING_REPORT");
            if (dsnakashtra.Tables[2].Rows.Count > 0)
            {
                string BoyName = dsnakashtra.Tables[0].Rows[0]["BOY_NAME"].ToString().Trim();
                string BoyCons = dsnakashtra.Tables[0].Rows[0]["BOY_CONSTELLATION"].ToString().Trim();
                string GirlName = dsnakashtra.Tables[1].Rows[0]["GIRL_NAME"].ToString().Trim();
                string GirlCons = dsnakashtra.Tables[1].Rows[0]["GIRL_CONSTELLATION"].ToString().Trim();
                string PredictiveVal = dsnakashtra.Tables[2].Rows[0]["PREDICTIVE"].ToString().Trim();
                string DefinitionVal = dsnakashtra.Tables[2].Rows[0]["DEFINITION"].ToString().Trim();
                NakashtraReportDiv.InnerHtml = DefinitionVal;
                NakashtraReportDiv.InnerHtml += "<p><strong>Nakashtra Dosha Report:-</strong></p>" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBNAKASHTRA", BoyCons).Replace("GGGGNAKASHTRA", GirlCons);
                ViewState["NakashtraReportDiv"] = DefinitionVal + "<p><strong>Nakashtra Dosha Report:-</strong></p>" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBNAKASHTRA", BoyCons).Replace("GGGGNAKASHTRA", GirlCons);
            }
            dsnakashtra.Dispose();


            DataSet dsekanakashtra = new DataSet();
            dsekanakashtra = cm.GetEkaNakashtraDosha(BoyId, GirlId, "", "", "GET_MATCHING_REPORT");
            if (dsekanakashtra.Tables[2].Rows.Count > 0)
            {
                string BoyName = dsekanakashtra.Tables[0].Rows[0]["BOY_NAME"].ToString().Trim();
                string BoyCons = dsekanakashtra.Tables[0].Rows[0]["BOY_CONSTELLATION"].ToString().Trim();
                string GirlName = dsekanakashtra.Tables[1].Rows[0]["GIRL_NAME"].ToString().Trim();
                string GirlCons = dsekanakashtra.Tables[1].Rows[0]["GIRL_CONSTELLATION"].ToString().Trim();
                string PredictiveVal = dsekanakashtra.Tables[2].Rows[0]["PREDICTIVE"].ToString().Trim();
                string DefinitionVal = dsekanakashtra.Tables[2].Rows[0]["DEFINITION"].ToString().Trim();
                EkaNakashtraReportDiv.InnerHtml = DefinitionVal;
                EkaNakashtraReportDiv.InnerHtml += "<p><strong>Eka Nakashtra Dosha Report:-</strong></p>" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBCCCC", BoyCons).Replace("GGGGCCCC", GirlCons);
                ViewState["EkaNakashtraReportDiv"] = DefinitionVal + "<p><strong>Eka Nakashtra Dosha Report:-</strong></p>" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBCCCC", BoyCons).Replace("GGGGCCCC", GirlCons);
            }
            dsekanakashtra.Dispose();


            DataSet ds27thnakashtra = new DataSet();
            ds27thnakashtra = cm.GetNakashtra27thDosha(BoyId, GirlId, "", "", "GET_MATCHING_REPORT");
            if (ds27thnakashtra.Tables[2].Rows.Count > 0)
            {
                string BoyName = ds27thnakashtra.Tables[0].Rows[0]["BOY_NAME"].ToString().Trim();
                string BoyCons = ds27thnakashtra.Tables[0].Rows[0]["BOY_CONSTELLATION"].ToString().Trim();
                string GirlName = ds27thnakashtra.Tables[1].Rows[0]["GIRL_NAME"].ToString().Trim();
                string GirlCons = ds27thnakashtra.Tables[1].Rows[0]["GIRL_CONSTELLATION"].ToString().Trim();
                string PredictiveVal = ds27thnakashtra.Tables[2].Rows[0]["PREDICTIVE"].ToString().Trim();
                string DefinitionVal = ds27thnakashtra.Tables[2].Rows[0]["DEFINITION"].ToString().Trim();
                Nakashtra27thReportDiv.InnerHtml = DefinitionVal;
                Nakashtra27thReportDiv.InnerHtml += "<p><strong>27th Nakashtra Dosha Report:-</strong></p>" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBNAKASHTRA", BoyCons).Replace("GGGGNAKASHTRA", GirlCons);
                ViewState["Nakashtra27thReportDiv"] = DefinitionVal + "<p><strong>27th Nakashtra Dosha Report:-</strong></p>" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBNAKASHTRA", BoyCons).Replace("GGGGNAKASHTRA", GirlCons);
            }
            ds27thnakashtra.Dispose();


            DataSet dsVadhaVainasika = new DataSet();
            dsVadhaVainasika = cm.GetVadhaVainasikaDosha(BoyId, GirlId, "", "", "GET_MATCHING_REPORT");
            if (dsVadhaVainasika.Tables[2].Rows.Count > 0)
            {
                string BoyName = dsVadhaVainasika.Tables[0].Rows[0]["BOY_NAME"].ToString().Trim();
                string BoyCons = dsVadhaVainasika.Tables[0].Rows[0]["BOY_CONSTELLATION"].ToString().Trim();
                string GirlName = dsVadhaVainasika.Tables[1].Rows[0]["GIRL_NAME"].ToString().Trim();
                string GirlCons = dsVadhaVainasika.Tables[1].Rows[0]["GIRL_CONSTELLATION"].ToString().Trim();
                string DefinitionVal = dsVadhaVainasika.Tables[2].Rows[0]["DEFINITION"].ToString().Trim();
                string PredictiveVal = dsVadhaVainasika.Tables[2].Rows[0]["PREDICTIVE"].ToString().Trim();
                string ExpertOpinionVal = dsVadhaVainasika.Tables[2].Rows[0]["EXPERT_OPINION"].ToString().Trim();
                PredictiveVal += ExpertOpinionVal;
                VadhaVainasikaReportDiv.InnerHtml = DefinitionVal;
                VadhaVainasikaReportDiv.InnerHtml += "<p><strong>Vadha Vainasika Dosha Report:-</strong></p>" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBNAKASHTRA", BoyCons).Replace("GGGGNAKASHTRA", GirlCons);
                ViewState["VadhaVainasikaReportDiv"] = DefinitionVal + "<p><strong>Vadha Vainasika Dosha Report:-</strong></p>" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBNAKASHTRA", BoyCons).Replace("GGGGNAKASHTRA", GirlCons);
            }
            dsVadhaVainasika.Dispose();

            if (dt.Rows.Count > 0)
            {
                ViewState["dtForPdf"] = dt;
                grdashakootmatching.DataSource = dt;
                grdashakootmatching.DataBind();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string KootNameVal = dt.Rows[i]["KootName"].ToString().ToUpper();
                    string MatchedGunasVal = dt.Rows[i]["MatchedGunas"].ToString();
                    string TotalMatchedGunasVal = ViewState["TotalMatchedGunas"].ToString();
                    if (i == 0)
                    {
                        if (KootNameVal == "NADI" && Convert.ToDouble(TotalMatchedGunasVal) >= 15 && Convert.ToDouble(MatchedGunasVal) == 8)
                        {
                            finalreportid.InnerHtml = "<p>There is a positive gains by Two major Koots and attaining " + TotalMatchedGunasVal + " Gunas between Ms. " + ViewState["GirlName"].ToString() + "(Girl) and Mr. " + ViewState["BoyName"].ToString() + "(Boy), the alliance may be considered for matching but still you are advised to go through the other dosha results before taking final decision.</p>";
                        }
                    }
                }
            }
            dt.Dispose();

            string BoyLagnaChart = ds.Tables[0].Rows[0]["LAGNA_CHART"].ToString().Trim();
            string GirlLagnaChart = ds.Tables[1].Rows[0]["LAGNA_CHART"].ToString().Trim();
            string BoyMoonChart = ds.Tables[0].Rows[0]["MOON_CHART"].ToString().Trim();
            string GirlMoonChart = ds.Tables[1].Rows[0]["MOON_CHART"].ToString().Trim();
            string BoyVenusChart = ds.Tables[0].Rows[0]["VENUS_CHART"].ToString().Trim();
            string GirlVenusChart = ds.Tables[1].Rows[0]["VENUS_CHART"].ToString().Trim();



            Get_ManglikDosha_Dosha_Samya(BoyId, GirlId);

            //GetManglikDosha(GirlLagnaChart, GirlMoonChart, GirlVenusChart, BoyLagnaChart, BoyMoonChart, BoyVenusChart);

            //Start Code for Kaal Sarpa Dosha

            DataSet dsksy = new DataSet();
            dsksy = cm.GetKaalSarpaYogaReport(BoyId, GirlId, "GET_MATCHING_REPORT");
            if (dsksy.Tables[3].Rows.Count > 0)
            {
                string BoyName = dsksy.Tables[0].Rows[0]["BOY_NAME"].ToString().Trim();
                string BoyRashi = dsksy.Tables[0].Rows[0]["BOY_RASHI"].ToString().Trim();
                string GirlName = dsksy.Tables[1].Rows[0]["GIRL_NAME"].ToString().Trim();
                string GirlRashi = dsksy.Tables[1].Rows[0]["GIRL_RASHI"].ToString().Trim();
                string DefinitionVal = dsksy.Tables[2].Rows[0]["DEFINITION"].ToString().Trim();
                string BoyPredictiveVal = dsksy.Tables[3].Rows[0]["PREDICTIVE"].ToString().Trim();
                string GirlPredictiveVal = dsksy.Tables[4].Rows[0]["PREDICTIVE"].ToString().Trim();
                KaalSarpaYogaDiv.InnerHtml = DefinitionVal;
                KaalSarpaYogaDiv.InnerHtml += BoyPredictiveVal;
                KaalSarpaYogaDiv.InnerHtml += GirlPredictiveVal;

                ViewState["KaalSarpaYogaDiv"] = KaalSarpaYogaDiv.InnerHtml;
            }
            dsksy.Dispose();

            //End Code for Kaal Sarpa Yoga

            //}
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion

    void Get_ManglikDosha_Dosha_Samya(string BoyId, string GirlId)
    {
        DataSet dsmld = new DataSet();
        dsmld = cm.GetManglikDoshaMatching(BoyId, GirlId, "GET_MANGLIK_DOSHA");
        if (dsmld.Tables[0].Rows.Count > 0)
        {
            string BoyChartName = "", BoyLagnaHouse = "", BoyMoonHouse = "", BoyVenusHouse = "", BoyManglikResult = "";
            string BoyPoint = "", BoyPointPer = "", Boyhouse = "", BoyLagnaPoint = "", BoyMoonPoint = "", BoyVenusPoint = "";
            string BoyLagnaPoint_Per = "", BoyMoonPoint_Per = "", BoyVenusPoint_Per = "", BoyFinalPoint_Per = "";

            string GirlChartName = "", GirlLagnaHouse = "", GirlMoonHouse = "", GirlVenusHouse = "", GirlManglikResult = "";
            string GirlPoint = "", GirlPointPer = "", Girlhouse = "", GirlLagnaPoint = "", GirlMoonPoint = "", GirlVenusPoint = "";
            string GirlLagnaPoint_Per = "", GirlMoonPoint_Per = "", GirlVenusPoint_Per = "", GirlFinalPoint_Per = "";
            for (int p = 0; p < dsmld.Tables[0].Rows.Count; p++)
            {
                BoyPoint = "";
                BoyChartName = dsmld.Tables[0].Rows[p]["CHART_NO"].ToString().Trim();
                BoyPoint = dsmld.Tables[0].Rows[p]["POINT"].ToString().Trim();
                BoyPointPer = dsmld.Tables[0].Rows[p]["POINT_PERCENTAGE"].ToString().Trim();
                BoyFinalPoint_Per = dsmld.Tables[0].Rows[p]["MARS_POINT_PERCENTAGE_AVG"].ToString().Trim();
                Boyhouse = dsmld.Tables[0].Rows[p]["HOUSE"].ToString().Trim();

                GirlPoint = "";
                GirlChartName = dsmld.Tables[2].Rows[p]["CHART_NO"].ToString().Trim();
                GirlPoint = dsmld.Tables[2].Rows[p]["POINT"].ToString().Trim();
                GirlPointPer = dsmld.Tables[2].Rows[p]["POINT_PERCENTAGE"].ToString().Trim();
                GirlFinalPoint_Per = dsmld.Tables[2].Rows[p]["MARS_POINT_PERCENTAGE_AVG"].ToString().Trim();
                Girlhouse = dsmld.Tables[2].Rows[p]["HOUSE"].ToString().Trim();
                if (BoyChartName == "LAGNA")
                {
                    BoyLagnaPoint = BoyPoint;
                    BoyLagnaHouse = Boyhouse;
                    BoyLagnaPoint_Per = BoyPointPer;
                }
                if (BoyChartName == "MOON")
                {
                    BoyMoonPoint = BoyPoint;
                    BoyMoonHouse = Boyhouse;
                    BoyMoonPoint_Per = BoyPointPer;
                }
                if (BoyChartName == "VENUS")
                {
                    BoyVenusPoint = BoyPoint;
                    BoyVenusHouse = Boyhouse;
                    BoyVenusPoint_Per = BoyPointPer;
                }
                if (GirlChartName == "LAGNA")
                {
                    GirlLagnaPoint = GirlPoint;
                    GirlLagnaHouse = Girlhouse;
                    GirlLagnaPoint_Per = GirlPointPer;
                }
                if (GirlChartName == "MOON")
                {
                    GirlMoonPoint = GirlPoint;
                    GirlMoonHouse = Girlhouse;
                    GirlMoonPoint_Per = GirlPointPer;
                }
                if (GirlChartName == "VENUS")
                {
                    GirlVenusPoint = GirlPoint;
                    GirlVenusHouse = Girlhouse;
                    GirlVenusPoint_Per = GirlPointPer;
                }
            }

            #region Boy Manglik Dosh Result
            string boy_lagna_result = "", boy_moon_result = "", boy_venus_result = "", boy_final_result = "";
            DataSet mdrds_boy = obj_subs.Get_Manglik_Dosha_Result("MARS", "LAGNA", "MOON", "VENUS", BoyLagnaPoint, BoyMoonPoint, BoyVenusPoint, "ManglikDosha", "", "");
            if (mdrds_boy.Tables[0].Rows.Count > 0)
            {
                string lagna_chart = mdrds_boy.Tables[0].Rows[0]["CHART_NO"].ToString();
                string lagna_cat = mdrds_boy.Tables[0].Rows[0]["CATEGORY"].ToString();
                boy_lagna_result = mdrds_boy.Tables[0].Rows[0]["DESCCLOB"].ToString();
                string predictivetype = mdrds_boy.Tables[0].Rows[0]["PREDICTIVE_TYPE"].ToString();
                boy_lagna_result = boy_lagna_result.Replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                boy_lagna_result = boy_lagna_result.Replace("XX.XX", BoyLagnaPoint_Per.ToString());
                BoyLagnaHouse = BoyLagnaHouse.Replace("HOUSE", "");
                boy_lagna_result = boy_lagna_result.Replace("HH", BoyLagnaHouse);

                if (mdrds_boy.Tables[1].Rows.Count > 0)
                {
                    string moon_chart = mdrds_boy.Tables[1].Rows[0]["CHART_NO"].ToString();
                    string moon_cat = mdrds_boy.Tables[1].Rows[0]["CATEGORY"].ToString();
                    boy_moon_result = mdrds_boy.Tables[1].Rows[0]["DESCCLOB"].ToString();
                    predictivetype = mdrds_boy.Tables[1].Rows[0]["PREDICTIVE_TYPE"].ToString();
                    boy_moon_result = boy_moon_result.Replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                    boy_moon_result = boy_moon_result.Replace("XX.XX", BoyMoonPoint_Per.ToString());
                    BoyMoonHouse = BoyMoonHouse.Replace("HOUSE", "");
                    boy_moon_result = boy_moon_result.Replace("HH", BoyMoonHouse);
                }

                if (mdrds_boy.Tables[2].Rows.Count > 0)
                {
                    string venus_chart = mdrds_boy.Tables[2].Rows[0]["CHART_NO"].ToString();
                    string venus_cat = mdrds_boy.Tables[2].Rows[0]["CATEGORY"].ToString();
                    boy_venus_result = mdrds_boy.Tables[2].Rows[0]["DESCCLOB"].ToString();
                    predictivetype = mdrds_boy.Tables[2].Rows[0]["PREDICTIVE_TYPE"].ToString();
                    boy_venus_result = boy_venus_result.Replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                    boy_venus_result = boy_venus_result.Replace("XX.XX", BoyVenusPoint_Per.ToString());
                    BoyVenusHouse = BoyVenusHouse.Replace("HOUSE", "");
                    boy_venus_result = boy_venus_result.Replace("HH", BoyVenusHouse);
                }
                if (mdrds_boy.Tables[3].Rows.Count > 0)
                {
                    string final_chart = mdrds_boy.Tables[3].Rows[0]["CHART_NO"].ToString();
                    string final_cat = mdrds_boy.Tables[3].Rows[0]["CATEGORY"].ToString();
                    boy_final_result = mdrds_boy.Tables[3].Rows[0]["DESCCLOB"].ToString();
                    predictivetype = mdrds_boy.Tables[3].Rows[0]["PREDICTIVE_TYPE"].ToString();
                    //BoyFinalPoint_Per = ((Convert.ToDouble(BoyLagnaPoint_Per) + Convert.ToDouble(BoyMoonPoint_Per) + Convert.ToDouble(BoyVenusPoint_Per)) / 3).ToString();
                    //BoyFinalPoint_Per = Math.Round(Convert.ToDouble(BoyFinalPoint_Per), 2).ToString();
                    boy_final_result = boy_final_result.Replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                    boy_final_result = boy_final_result.Replace("XX.XX", BoyFinalPoint_Per.ToString());
                }
                if (mdrds_boy.Tables[4].Rows.Count > 0)
                {
                    BoyManglikResult = mdrds_boy.Tables[4].Rows[0]["DESCCLOB"].ToString();
                    predictivetype = mdrds_boy.Tables[4].Rows[0]["PREDICTIVE_TYPE"].ToString();
                }
                if (mdrds_boy.Tables[5].Rows.Count > 0)
                {
                    BoyManglikResult = mdrds_boy.Tables[5].Rows[0]["DESCCLOB"].ToString();
                    predictivetype = mdrds_boy.Tables[5].Rows[0]["PREDICTIVE_TYPE"].ToString();
                }
                BoyManglikResult = boy_lagna_result + "" + boy_moon_result + "" + boy_venus_result + "" + boy_final_result;
            }
            mdrds_boy.Dispose();
            #endregion

            #region Girl Manglik Dosh Result
            string girl_lagna_result = "", girl_moon_result = "", girl_venus_result = "", girl_final_result = "";
            DataSet mdrds_girl = obj_subs.Get_Manglik_Dosha_Result("MARS", "LAGNA", "MOON", "VENUS", GirlLagnaPoint, GirlMoonPoint, GirlVenusPoint, "ManglikDosha", "", "");
            if (mdrds_girl.Tables[0].Rows.Count > 0)
            {
                string lagna_chart = mdrds_girl.Tables[0].Rows[0]["CHART_NO"].ToString();
                string lagna_cat = mdrds_girl.Tables[0].Rows[0]["CATEGORY"].ToString();
                girl_lagna_result = mdrds_girl.Tables[0].Rows[0]["DESCCLOB"].ToString();
                string predictivetype = mdrds_girl.Tables[0].Rows[0]["PREDICTIVE_TYPE"].ToString();
                girl_lagna_result = girl_lagna_result.Replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                girl_lagna_result = girl_lagna_result.Replace("XX.XX", GirlLagnaPoint_Per.ToString());
                GirlLagnaHouse = GirlLagnaHouse.Replace("HOUSE", "");
                girl_lagna_result = girl_lagna_result.Replace("HH", GirlLagnaHouse);

                if (mdrds_girl.Tables[1].Rows.Count > 0)
                {
                    string moon_chart = mdrds_girl.Tables[1].Rows[0]["CHART_NO"].ToString();
                    string moon_cat = mdrds_girl.Tables[1].Rows[0]["CATEGORY"].ToString();
                    girl_moon_result = mdrds_girl.Tables[1].Rows[0]["DESCCLOB"].ToString();
                    predictivetype = mdrds_girl.Tables[1].Rows[0]["PREDICTIVE_TYPE"].ToString();
                    girl_moon_result = girl_moon_result.Replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                    girl_moon_result = girl_moon_result.Replace("XX.XX", GirlMoonPoint_Per.ToString());
                    GirlMoonHouse = GirlMoonHouse.Replace("HOUSE", "");
                    girl_moon_result = girl_moon_result.Replace("HH", GirlMoonHouse);
                }

                if (mdrds_girl.Tables[2].Rows.Count > 0)
                {
                    string venus_chart = mdrds_girl.Tables[2].Rows[0]["CHART_NO"].ToString();
                    string venus_cat = mdrds_girl.Tables[2].Rows[0]["CATEGORY"].ToString();
                    girl_venus_result = mdrds_girl.Tables[2].Rows[0]["DESCCLOB"].ToString();
                    predictivetype = mdrds_girl.Tables[2].Rows[0]["PREDICTIVE_TYPE"].ToString();
                    girl_venus_result = girl_venus_result.Replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                    girl_venus_result = girl_venus_result.Replace("XX.XX", GirlVenusPoint_Per.ToString());
                    GirlVenusHouse = GirlVenusHouse.Replace("HOUSE", "");
                    girl_venus_result = girl_venus_result.Replace("HH", GirlVenusHouse);
                }
                if (mdrds_girl.Tables[3].Rows.Count > 0)
                {
                    string final_chart = mdrds_girl.Tables[3].Rows[0]["CHART_NO"].ToString();
                    string final_cat = mdrds_girl.Tables[3].Rows[0]["CATEGORY"].ToString();
                    girl_final_result = mdrds_girl.Tables[3].Rows[0]["DESCCLOB"].ToString();
                    predictivetype = mdrds_girl.Tables[3].Rows[0]["PREDICTIVE_TYPE"].ToString();
                    //GirlFinalPoint_Per = ((Convert.ToDouble(GirlLagnaPoint_Per) + Convert.ToDouble(GirlMoonPoint_Per) + Convert.ToDouble(GirlVenusPoint_Per)) / 3).ToString();
                    //GirlFinalPoint_Per = Math.Round(Convert.ToDouble(GirlFinalPoint_Per), 2).ToString();
                    girl_final_result = girl_final_result.Replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                    girl_final_result = girl_final_result.Replace("XX.XX", GirlFinalPoint_Per.ToString());
                }
                if (mdrds_girl.Tables[4].Rows.Count > 0)
                {
                    GirlManglikResult = mdrds_girl.Tables[4].Rows[0]["DESCCLOB"].ToString();
                    predictivetype = mdrds_girl.Tables[4].Rows[0]["PREDICTIVE_TYPE"].ToString();
                }
                if (mdrds_girl.Tables[5].Rows.Count > 0)
                {
                    GirlManglikResult = mdrds_girl.Tables[5].Rows[0]["DESCCLOB"].ToString();
                    predictivetype = mdrds_girl.Tables[5].Rows[0]["PREDICTIVE_TYPE"].ToString();
                }
                GirlManglikResult = girl_lagna_result + "" + girl_moon_result + "" + girl_venus_result + "" + girl_final_result;
            }
            mdrds_girl.Dispose();
            #endregion

            #region Merge Boy and Girl Manglik Dosh Result
            dtmd.Columns.AddRange(new DataColumn[4] { new DataColumn("ManglikDoshaofBoy"), new DataColumn("ManglikPercentageForBoy"), new DataColumn("ManglikDoshaofGirl"), new DataColumn("ManglikPercentageforGirl") });
            dtmd.Rows.Add("Manglik Dosha from Lagna Chart", BoyLagnaPoint_Per, "Manglik Dosha from Lagna Chart", GirlLagnaPoint_Per);
            dtmd.Rows.Add("Manglik Dosha from Moon Chart", BoyMoonPoint_Per, "Manglik Dosha from Moon Chart", GirlMoonPoint_Per);
            dtmd.Rows.Add("Manglik Dosha from Venus Chart", BoyVenusPoint_Per, "Manglik Dosha from Venus Chart", GirlVenusPoint_Per);

            if (dtmd.Rows.Count > 0)
            {
                ViewState["dtManglisk"] = dtmd;
                grdmanglikdosha.DataSource = dtmd;
                grdmanglikdosha.DataBind();
            }
            dtmd.Dispose();

            string dsmdpstr1 = "", dsmdpstr2 = "";
            DataSet dsmdp = obj_subs.Get_Manglik_Dosha_Predictive("MANGLIK_DOSHA", BoyFinalPoint_Per, GirlFinalPoint_Per);
            if (dsmdp.Tables[0].Rows.Count > 0)
            {
                for (int p = 0; p < dsmdp.Tables[0].Rows.Count; p++)
                {
                    if (dsmdp.Tables[0].Rows[p]["PRIORITY"].ToString() == "1")
                    {
                        dsmdpstr1 += "" + dsmdp.Tables[0].Rows[p]["QUESTION"].ToString() + "</b>" + dsmdp.Tables[0].Rows[p]["PREDICTIVE"].ToString();
                    }
                    else
                    {
                        dsmdpstr2 += "" + dsmdp.Tables[0].Rows[p]["QUESTION"].ToString() + "</b>" + dsmdp.Tables[0].Rows[p]["PREDICTIVE"].ToString() + "";
                    }
                }
            }
            dsmdp.Dispose();

            ManglikDoshaDiv1.InnerHtml = dsmdpstr1.Replace("BBBBPPPP", "<b>" + BoyFinalPoint_Per + " %</b>").Replace("GGGGPPPP", "<b>" + GirlFinalPoint_Per + "  %</b>");
            ViewState["ManglikDoshaDiv1"] = dsmdpstr1.Replace("BBBBPPPP", "<b>" + BoyFinalPoint_Per + " %</b>").Replace("GGGGPPPP", "<b>" + GirlFinalPoint_Per + "  %</b>");
            ManglikDoshaDiv2.InnerHtml = dsmdpstr2.Replace("BBBBPPPP", "<b>" + BoyFinalPoint_Per + " %</b>").Replace("GGGGPPPP", "<b>" + GirlFinalPoint_Per + "  %</b>");
            ViewState["ManglikDoshaDiv2"] = dsmdpstr2.Replace("BBBBPPPP", "<b>" + BoyFinalPoint_Per + " %</b>").Replace("GGGGPPPP", "<b>" + GirlFinalPoint_Per + "  %</b>");

            #endregion
        }

        #region Dosha Samya for Boy and Girl Start Here
        if (dsmld.Tables[1].Rows.Count > 0)
        {
            string BoySunPoint_Per = "", BoyMarsPoint_Per = "", BoySaturnPoint_Per = "", BoyRahuPoint_Per = "";
            string GirlSunPoint_Per = "", GirlMarsPoint_Per = "", GirlSaturnPoint_Per = "", GirlRahuPoint_Per = "";
            for (int d = 0; d < dsmld.Tables[1].Rows.Count; d++)
            {
                BoySunPoint_Per = dsmld.Tables[1].Rows[d]["SUN_POINT_PERCENTAGE_AVG"].ToString().Trim();
                BoyMarsPoint_Per = dsmld.Tables[1].Rows[d]["MARS_POINT_PERCENTAGE_AVG"].ToString().Trim();
                BoySaturnPoint_Per = dsmld.Tables[1].Rows[d]["SATURN_POINT_PERCENTAGE_AVG"].ToString().Trim();
                BoyRahuPoint_Per = dsmld.Tables[1].Rows[d]["RAHU_POINT_PERCENTAGE_AVG"].ToString().Trim();

                GirlSunPoint_Per = dsmld.Tables[3].Rows[d]["SUN_POINT_PERCENTAGE_AVG"].ToString().Trim();
                GirlMarsPoint_Per = dsmld.Tables[3].Rows[d]["MARS_POINT_PERCENTAGE_AVG"].ToString().Trim();
                GirlSaturnPoint_Per = dsmld.Tables[3].Rows[d]["SATURN_POINT_PERCENTAGE_AVG"].ToString().Trim();
                GirlRahuPoint_Per = dsmld.Tables[3].Rows[d]["RAHU_POINT_PERCENTAGE_AVG"].ToString().Trim();
            }

            dtds.Columns.AddRange(new DataColumn[4] { new DataColumn("DoshaSamyaofBoy"), new DataColumn("DoshaPercentageForBoy"), new DataColumn("DoshaSamyaofGirl"), new DataColumn("DoshaPercentageforGirl") });
            dtds.Rows.Add("Dosha Samya of Sun from Lagna , Moon and Venus Charts", BoySunPoint_Per, "Dosha Samya of Sun from Lagna , Moon and Venus Charts", GirlSunPoint_Per);
            dtds.Rows.Add("Dosha Samya of Mars from Lagna , Moon and Venus Charts", BoyMarsPoint_Per, "Dosha Samya of Mars from Lagna , Moon and Venus Charts", GirlMarsPoint_Per);
            dtds.Rows.Add("Dosha Samya of Saturn from Lagna , Moon and Venus Charts", BoySaturnPoint_Per, "Dosha Samya of Saturn from Lagna , Moon and Venus Charts", GirlSaturnPoint_Per);
            dtds.Rows.Add("Dosha Samya of Rahu from Lagna , Moon and Venus Charts", BoyRahuPoint_Per, "Dosha Samya of Rahu from Lagna , Moon and Venus Charts", GirlRahuPoint_Per);
            if (dtds.Rows.Count > 0)
            {
                ViewState["grddoshasamya"] = dtds;
                grddoshasamya.DataSource = dtds;
                grddoshasamya.DataBind();
            }
            dtds.Dispose();

            string dsdspstr1 = "", dsdspstr2 = "";
            DataSet dsdsp = obj_subs.Get_Dosha_Samya_Predictive("DOSHA_SAMYA", BoyDoshaSamyaTotalPoints, GirlDoshaSamyaTotalPoints);
            if (dsdsp.Tables[0].Rows.Count > 0)
            {
                for (int p = 0; p < dsdsp.Tables[0].Rows.Count; p++)
                {
                    if (dsdsp.Tables[0].Rows[p]["PRIORITY"].ToString() == "1")
                    {
                        dsdspstr1 += "<b>" + dsdsp.Tables[0].Rows[p]["QUESTION"].ToString() + "</b>" + dsdsp.Tables[0].Rows[p]["PREDICTIVE"].ToString();
                    }
                    else
                    {
                        dsdspstr2 += "<b>" + dsdsp.Tables[0].Rows[p]["QUESTION"].ToString() + "</b>" + dsdsp.Tables[0].Rows[p]["PREDICTIVE"].ToString() + "";
                    }
                }
            }
            dsdsp.Dispose();

            DoshaSamyaDiv1.InnerHtml = dsdspstr1.Replace("BBBBPPPP", "<b>" + BoyDoshaSamyaTotalPoints + " %</b>").Replace("GGGGPPPP", "<b>" + GirlDoshaSamyaTotalPoints + "  %</b>");
            ViewState["DoshaSamyaDiv1"] = dsdspstr1.Replace("BBBBPPPP", "<b>" + BoyDoshaSamyaTotalPoints + " %</b>").Replace("GGGGPPPP", "<b>" + GirlDoshaSamyaTotalPoints + "  %</b>");
            DoshaSamyaDiv2.InnerHtml = dsdspstr2.Replace("BBBBPPPP", "<b>" + BoyDoshaSamyaTotalPoints + " %</b>").Replace("GGGGPPPP", "<b>" + GirlDoshaSamyaTotalPoints + "  %</b>");
            ViewState["DoshaSamyaDiv2"] = dsdspstr2.Replace("BBBBPPPP", "<b>" + BoyDoshaSamyaTotalPoints + " %</b>").Replace("GGGGPPPP", "<b>" + GirlDoshaSamyaTotalPoints + "  %</b>");
        }
        #endregion


        dsmld.Dispose();
    }

    #region Get Manglik Dosha Reports
    void GetManglikDosha(string GirlLagnaChart, string GirlMoonChart, string GirlVenusChart, string BoyLagnaChart, string BoyMoonChart, string BoyVenusChart)
    {
        try
        {
            string Boylagna_house = "";
            string Boymoon_house = "";
            string Boyvenus_house = "";
            string Boymanglik_result = "";

            #region Get Boy Manglik Dosha
            if (BoyLagnaChart != "")
            {
                string[] BoyLagnaChartSplt = BoyLagnaChart.Split('$');
                if (BoyLagnaChartSplt.Length > 0)
                {
                    for (int b = 0; b < BoyLagnaChartSplt.Length; b++)
                    {
                        if (BoyLagnaChartSplt[b] != "")
                        {
                            string[] BoyLagnaChartArr = BoyLagnaChartSplt[b].Split('~');
                            if (BoyLagnaChartArr.Length > 0)
                            {
                                if (BoyLagnaChartArr[0].ToString().Trim().ToUpper() == "MARS")
                                {
                                    Boylagna_house = BoyLagnaChartArr[2];
                                }
                            }
                        }
                    }
                }
            }
            if (BoyMoonChart != "")
            {
                string[] BoyMoonChartSplt = BoyMoonChart.Split('$');
                if (BoyMoonChartSplt.Length > 0)
                {
                    for (int b = 0; b < BoyMoonChartSplt.Length; b++)
                    {
                        if (BoyMoonChartSplt[b] != "")
                        {
                            string[] BoyMoonChartArr = BoyMoonChartSplt[b].Split('~');
                            if (BoyMoonChartArr.Length > 0)
                            {
                                if (BoyMoonChartArr[0].ToString().Trim().ToUpper() == "MARS")
                                {
                                    Boymoon_house = BoyMoonChartArr[2];
                                }
                            }
                        }
                    }
                }
            }
            if (BoyVenusChart != "")
            {
                string[] BoyVenusChartSplt = BoyVenusChart.Split('$');
                if (BoyVenusChartSplt.Length > 0)
                {
                    for (int b = 0; b < BoyVenusChartSplt.Length; b++)
                    {
                        if (BoyVenusChartSplt[b] != "")
                        {
                            string[] BoyVenusChartArr = BoyVenusChartSplt[b].Split('~');
                            if (BoyVenusChartArr.Length > 0)
                            {
                                if (BoyVenusChartArr[0].ToString().Trim().ToUpper() == "MARS")
                                {
                                    Boyvenus_house = BoyVenusChartArr[2];
                                }
                            }
                        }
                    }
                }
            }

            DataSet Boyrespaapds = objhp.pun("Paap Samya", BoyLagnaChart, BoyMoonChart, BoyVenusChart, "nataladmin@astroenvision.com");

            if (Boyrespaapds.Tables[0].Rows.Count > 0)
            {
                for (int p = 0; p < Boyrespaapds.Tables[0].Rows.Count; p++)
                {
                    if (Boyrespaapds.Tables[0].Rows[p]["DESCCLOB"].ToString() == "MARS")
                    {
                        string lagnapoint = Boyrespaapds.Tables[0].Rows[p]["KEY_STRING"].ToString(); // Lagna
                        string moonpoint = Boyrespaapds.Tables[0].Rows[p]["PLANET"].ToString();      // Moon
                        string venuspoint = Boyrespaapds.Tables[0].Rows[p]["CHART_NO"].ToString();   // Venus
                        double total = Convert.ToDouble(lagnapoint) + Convert.ToDouble(moonpoint) + Convert.ToDouble(venuspoint);
                        DataSet mdrds = obj_subs.Get_Manglik_Dosha_Result("MARS", "LAGNA", "MOON", "VENUS", lagnapoint, moonpoint, venuspoint, "ManglikDosha", "", "");
                        string lagna_result = "", moon_result = "", venus_result = "", final_result = "";
                        if (mdrds.Tables[0].Rows.Count > 0)
                        {
                            string lagna_chart = mdrds.Tables[0].Rows[0]["CHART_NO"].ToString();
                            string lagna_cat = mdrds.Tables[0].Rows[0]["CATEGORY"].ToString();
                            lagna_result = mdrds.Tables[0].Rows[0]["DESCCLOB"].ToString();
                            string predictivetype = mdrds.Tables[0].Rows[0]["PREDICTIVE_TYPE"].ToString();
                            double lagnapointval = Convert.ToDouble(lagnapoint) * (1.19);
                            lagnapointval = Math.Round(lagnapointval, 2);
                            BoyLagnaPoints = lagnapointval.ToString();
                            lagna_result = lagna_result.Replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                            lagna_result = lagna_result.Replace("XX.XX", lagnapointval.ToString());
                            lagna_result = lagna_result.Replace("HH", "<font color='#F4600A'><b>HHth</b></font>");
                            Boylagna_house = Boylagna_house.Replace("HOUSE", "");
                            lagna_result = lagna_result.Replace("HH", Boylagna_house);


                            if (mdrds.Tables[1].Rows.Count > 0)
                            {
                                string moon_chart = mdrds.Tables[1].Rows[0]["CHART_NO"].ToString();
                                string moon_cat = mdrds.Tables[1].Rows[0]["CATEGORY"].ToString();
                                moon_result = mdrds.Tables[1].Rows[0]["DESCCLOB"].ToString();
                                predictivetype = mdrds.Tables[1].Rows[0]["PREDICTIVE_TYPE"].ToString();
                                double moonpointval = Convert.ToDouble(moonpoint) * (1.19);
                                moonpointval = Math.Round(moonpointval, 2);
                                BoyMoonPoints = moonpointval.ToString();
                                moon_result = moon_result.Replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                                moon_result = moon_result.Replace("XX.XX", moonpointval.ToString());
                                moon_result = moon_result.Replace("HH", "<font color='#F4600A'><b>HHth</b></font>");
                                Boymoon_house = Boymoon_house.Replace("HOUSE", "");
                                moon_result = moon_result.Replace("HH", Boymoon_house);
                            }

                            if (mdrds.Tables[2].Rows.Count > 0)
                            {
                                string venus_chart = mdrds.Tables[2].Rows[0]["CHART_NO"].ToString();
                                string venus_cat = mdrds.Tables[2].Rows[0]["CATEGORY"].ToString();
                                venus_result = mdrds.Tables[2].Rows[0]["DESCCLOB"].ToString();
                                predictivetype = mdrds.Tables[2].Rows[0]["PREDICTIVE_TYPE"].ToString();
                                double venuspointval = Convert.ToDouble(venuspoint) * (1.19);
                                venuspointval = Math.Round(venuspointval, 2);
                                BoyVenusPoints = venuspointval.ToString();
                                venus_result = venus_result.Replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                                venus_result = venus_result.Replace("XX.XX", venuspointval.ToString());
                                venus_result = venus_result.Replace("HH", "<font color='#F4600A'><b>HHth</b></font>");
                                Boyvenus_house = Boyvenus_house.Replace("HOUSE", "");
                                venus_result = venus_result.Replace("HH", Boyvenus_house);
                            }
                            if (mdrds.Tables[3].Rows.Count > 0)
                            {
                                string final_chart = mdrds.Tables[3].Rows[0]["CHART_NO"].ToString();
                                string final_cat = mdrds.Tables[3].Rows[0]["CATEGORY"].ToString();
                                final_result = mdrds.Tables[3].Rows[0]["DESCCLOB"].ToString();
                                predictivetype = mdrds.Tables[3].Rows[0]["PREDICTIVE_TYPE"].ToString();
                                total = Convert.ToDouble(total) * (1.19);
                                total = Math.Round(total, 2);
                                BoyTotalPoints = total.ToString();
                                final_result = final_result.Replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                                final_result = final_result.Replace("XX.XX", total.ToString());
                            }
                            if (mdrds.Tables[4].Rows.Count > 0)
                            {
                                Boymanglik_result = mdrds.Tables[4].Rows[0]["DESCCLOB"].ToString();
                                predictivetype = mdrds.Tables[4].Rows[0]["PREDICTIVE_TYPE"].ToString();
                            }
                            if (mdrds.Tables[5].Rows.Count > 0)
                            {
                                Boymanglik_result = mdrds.Tables[5].Rows[0]["DESCCLOB"].ToString();
                                predictivetype = mdrds.Tables[5].Rows[0]["PREDICTIVE_TYPE"].ToString();
                            }
                            Boymanglik_result = lagna_result + "" + moon_result + "" + venus_result + "" + final_result;
                        }
                    }
                }
            }
            Boyrespaapds.Dispose();

            #endregion

            #region Get Boy Dosha Samya
            //dtds.Columns.AddRange(new DataColumn[4] { new DataColumn("DoshaSamyaofBoy"), new DataColumn("DoshaPercentageForBoy"), new DataColumn("DoshaSamyaofGirl"), new DataColumn("DoshaPercentageforGirl") });
            dtds.Columns.AddRange(new DataColumn[2] { new DataColumn("DoshaSamyaofBoy"), new DataColumn("DoshaPercentageForBoy") });
            string dsresult = "", palnetname = "", totalpercentage = "";
            //string totalpercentageboy_mars = "", totalpercentageboy_saturn = "", totalpercentageboy_rahu = "", totalpercentageboy_sun = "";
            DataSet ydsr = obj_subs.Get_Dosha_Samya_Result("ALL", "ALL", "ALL", "ALL", "", "", "", "DoshaSamya", "Y", "");
            if (ydsr.Tables[0].Rows.Count > 0)
            {
                for (int a = 0; a < ydsr.Tables[0].Rows.Count; a++)
                {
                    dsresult = ydsr.Tables[0].Rows[a]["DESCCLOB"].ToString();
                    palnetname = Boyrespaapds.Tables[2].Rows[a]["PLANET"].ToString(); //ydsr.Tables[0].Rows[a]["PLANET"].ToString(); 
                    totalpercentage = Boyrespaapds.Tables[2].Rows[a]["TOTALPERCENTAGE"].ToString();
                    if (palnetname == "MARS")
                    {
                        dtds.Rows.Add("Dosha Samya of Mars from Lagna , Moon and Venus Charts", totalpercentage);
                    }
                    if (palnetname == "SATURN")
                    {
                        dtds.Rows.Add("Dosha Samya of Saturn from Lagna , Moon and Venus Charts", totalpercentage);
                    }
                    if (palnetname == "RAHU")
                    {
                        dtds.Rows.Add("Dosha Samya of Rahu from Lagna , Moon and Venus Charts", totalpercentage);
                    }
                    if (palnetname == "SUN")
                    {
                        dtds.Rows.Add("Dosha Samya of Sun from Lagna , Moon and Venus Charts", totalpercentage);
                    }

                    //dsresult = dsresult.Replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                    //dsresult = dsresult.Replace("XXX", "<font color='#F4600A'><b>XXX</b></font>");
                    //dsresult = dsresult.Replace("HHH", "<font color='#F4600A'><b>HHH</b></font>");
                    //dsresult = dsresult.Replace("XX.XX", totalpercentage);
                    //dsresult = dsresult.Replace("XXX", palnetname);
                    //dsresult = dsresult.Replace("HHH", palnetname);
                    //doshasamya_result = doshasamya_result + dsresult + "<br /><br />";
                }
            }
            ydsr.Dispose();
            //DoshaSamyaDiv1.InnerHtml = doshasamya_result;

            //DataSet ddsr = obj_subs.Get_Dosha_Samya_Result("ALL", "ALL", "ALL", "ALL", "", "", "", "DoshaSamya", "D", "");
            //DataSet fdsr = obj_subs.Get_Dosha_Samya_Result("ALL", "ALL", "ALL", "ALL", "", "", "", "DoshaSamya", "F", "");
            //DataSet rdsr = obj_subs.Get_Dosha_Samya_Result("ALL", "ALL", "ALL", "ALL", "", "", "", "DoshaSamya", "R", "");

            //End Code for Boy DoshaSamya
            #endregion

            #region Get Girl Manglik Dosha
            string Girllagna_house = "";
            string Girlmoon_house = "";
            string Girlvenus_house = "";
            string Girlmanglik_result = "";
            if (GirlLagnaChart != "")
            {
                string[] GirlLagnaChartSplt = GirlLagnaChart.Split('$');
                if (GirlLagnaChartSplt.Length > 0)
                {
                    for (int b = 0; b < GirlLagnaChartSplt.Length; b++)
                    {
                        if (GirlLagnaChartSplt[b] != "")
                        {
                            string[] GirlLagnaChartArr = GirlLagnaChartSplt[b].Split('~');
                            if (GirlLagnaChartArr.Length > 0)
                            {
                                if (GirlLagnaChartArr[0].ToString().Trim().ToUpper() == "MARS")
                                {
                                    Girllagna_house = GirlLagnaChartArr[2];
                                }
                            }
                        }
                    }
                }
            }
            if (GirlMoonChart != "")
            {
                string[] GirlMoonChartSplt = GirlMoonChart.Split('$');
                if (GirlMoonChartSplt.Length > 0)
                {
                    for (int b = 0; b < GirlMoonChartSplt.Length; b++)
                    {
                        if (GirlMoonChartSplt[b] != "")
                        {
                            string[] GirlMoonChartArr = GirlMoonChartSplt[b].Split('~');
                            if (GirlMoonChartArr.Length > 0)
                            {
                                if (GirlMoonChartArr[0].ToString().Trim().ToUpper() == "MARS")
                                {
                                    Girlmoon_house = GirlMoonChartArr[2];
                                }
                            }
                        }
                    }
                }
            }
            if (GirlVenusChart != "")
            {
                string[] GirlVenusChartSplt = GirlVenusChart.Split('$');
                if (GirlVenusChartSplt.Length > 0)
                {
                    for (int b = 0; b < GirlVenusChartSplt.Length; b++)
                    {
                        if (GirlVenusChartSplt[b] != "")
                        {
                            string[] GirlVenusChartArr = GirlVenusChartSplt[b].Split('~');
                            if (GirlVenusChartArr.Length > 0)
                            {
                                if (GirlVenusChartArr[0].ToString().Trim().ToUpper() == "MARS")
                                {
                                    Girlvenus_house = GirlVenusChartArr[2];
                                }
                            }
                        }
                    }
                }
            }

            DataSet Girlrespaapds = objhp.pun("Paap Samya", GirlLagnaChart, GirlMoonChart, GirlVenusChart, "nataladmin@astroenvision.com");

            if (Girlrespaapds.Tables[0].Rows.Count > 0)
            {
                for (int p = 0; p < Girlrespaapds.Tables[0].Rows.Count; p++)
                {
                    if (Girlrespaapds.Tables[0].Rows[p]["DESCCLOB"].ToString() == "MARS")
                    {
                        string lagnapoint = Girlrespaapds.Tables[0].Rows[p]["KEY_STRING"].ToString(); // Lagna
                        string moonpoint = Girlrespaapds.Tables[0].Rows[p]["PLANET"].ToString();      // Moon
                        string venuspoint = Girlrespaapds.Tables[0].Rows[p]["CHART_NO"].ToString();   // Venus
                        double total = Convert.ToDouble(lagnapoint) + Convert.ToDouble(moonpoint) + Convert.ToDouble(venuspoint);
                        DataSet mdrds = obj_subs.Get_Manglik_Dosha_Result("MARS", "LAGNA", "MOON", "VENUS", lagnapoint, moonpoint, venuspoint, "ManglikDosha", "", "");
                        string lagna_result = "", moon_result = "", venus_result = "", final_result = "";
                        if (mdrds.Tables[0].Rows.Count > 0)
                        {
                            string lagna_chart = mdrds.Tables[0].Rows[0]["CHART_NO"].ToString();
                            string lagna_cat = mdrds.Tables[0].Rows[0]["CATEGORY"].ToString();
                            lagna_result = mdrds.Tables[0].Rows[0]["DESCCLOB"].ToString();
                            string predictivetype = mdrds.Tables[0].Rows[0]["PREDICTIVE_TYPE"].ToString();
                            double lagnapointval = Convert.ToDouble(lagnapoint) * (1.19);
                            lagnapointval = Math.Round(lagnapointval, 2);
                            GirlLagnaPoints = lagnapointval.ToString();
                            lagna_result = lagna_result.Replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                            lagna_result = lagna_result.Replace("XX.XX", lagnapointval.ToString());
                            lagna_result = lagna_result.Replace("HH", "<font color='#F4600A'><b>HHth</b></font>");
                            Boylagna_house = Boylagna_house.Replace("HOUSE", "");
                            lagna_result = lagna_result.Replace("HH", Boylagna_house);

                            if (mdrds.Tables[1].Rows.Count > 0)
                            {
                                string moon_chart = mdrds.Tables[1].Rows[0]["CHART_NO"].ToString();
                                string moon_cat = mdrds.Tables[1].Rows[0]["CATEGORY"].ToString();
                                moon_result = mdrds.Tables[1].Rows[0]["DESCCLOB"].ToString();
                                predictivetype = mdrds.Tables[1].Rows[0]["PREDICTIVE_TYPE"].ToString();
                                double moonpointval = Convert.ToDouble(moonpoint) * (1.19);
                                moonpointval = Math.Round(moonpointval, 2);
                                GirlMoonPoints = moonpointval.ToString();
                                moon_result = moon_result.Replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                                moon_result = moon_result.Replace("XX.XX", moonpointval.ToString());
                                moon_result = moon_result.Replace("HH", "<font color='#F4600A'><b>HHth</b></font>");
                                Boymoon_house = Boymoon_house.Replace("HOUSE", "");
                                moon_result = moon_result.Replace("HH", Boymoon_house);
                            }

                            if (mdrds.Tables[2].Rows.Count > 0)
                            {
                                string venus_chart = mdrds.Tables[2].Rows[0]["CHART_NO"].ToString();
                                string venus_cat = mdrds.Tables[2].Rows[0]["CATEGORY"].ToString();
                                venus_result = mdrds.Tables[2].Rows[0]["DESCCLOB"].ToString();
                                predictivetype = mdrds.Tables[2].Rows[0]["PREDICTIVE_TYPE"].ToString();
                                double venuspointval = Convert.ToDouble(venuspoint) * (1.19);
                                venuspointval = Math.Round(venuspointval, 2);
                                GirlVenusPoints = venuspointval.ToString();
                                venus_result = venus_result.Replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                                venus_result = venus_result.Replace("XX.XX", venuspointval.ToString());
                                venus_result = venus_result.Replace("HH", "<font color='#F4600A'><b>HHth</b></font>");
                                Boyvenus_house = Boyvenus_house.Replace("HOUSE", "");
                                venus_result = venus_result.Replace("HH", Boyvenus_house);
                            }
                            if (mdrds.Tables[3].Rows.Count > 0)
                            {
                                string final_chart = mdrds.Tables[3].Rows[0]["CHART_NO"].ToString();
                                string final_cat = mdrds.Tables[3].Rows[0]["CATEGORY"].ToString();
                                final_result = mdrds.Tables[3].Rows[0]["DESCCLOB"].ToString();
                                predictivetype = mdrds.Tables[3].Rows[0]["PREDICTIVE_TYPE"].ToString();
                                total = Convert.ToDouble(total) * (1.19);
                                total = Math.Round(total, 2);
                                GirlTotalPoints = total.ToString();
                                final_result = final_result.Replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                                final_result = final_result.Replace("XX.XX", total.ToString());
                            }
                            if (mdrds.Tables[4].Rows.Count > 0)
                            {
                                Girlmanglik_result = mdrds.Tables[4].Rows[0]["DESCCLOB"].ToString();
                                predictivetype = mdrds.Tables[4].Rows[0]["PREDICTIVE_TYPE"].ToString();
                            }
                            if (mdrds.Tables[5].Rows.Count > 0)
                            {
                                Girlmanglik_result = mdrds.Tables[5].Rows[0]["DESCCLOB"].ToString();
                                predictivetype = mdrds.Tables[5].Rows[0]["PREDICTIVE_TYPE"].ToString();
                            }
                            Girlmanglik_result = lagna_result + "<br /><br />" + moon_result + "<br /><br />" + venus_result + "<br /><br />" + final_result;
                        }
                    }
                }
            }
            Girlrespaapds.Dispose();

            #endregion

            dtmd.Columns.AddRange(new DataColumn[4] { new DataColumn("ManglikDoshaofBoy"), new DataColumn("ManglikPercentageForBoy"), new DataColumn("ManglikDoshaofGirl"), new DataColumn("ManglikPercentageforGirl") });
            dtmd.Rows.Add("Manglik Dosha from Lagna Chart", BoyLagnaPoints, "Manglik Dosha from Lagna Chart", GirlLagnaPoints);
            dtmd.Rows.Add("Manglik Dosha from Moon Chart", BoyMoonPoints, "Manglik Dosha from Moon Chart", GirlMoonPoints);
            dtmd.Rows.Add("Manglik Dosha from Venus Chart", BoyVenusPoints, "Manglik Dosha from Venus Chart", GirlVenusPoints);
            //dtmd.Rows.Add("Overall Manglik Dosha", BoyTotalPoints, "Overall Manglik Dosha", GirlTotalPoints);

            if (dtmd.Rows.Count > 0)
            {
                ViewState["dtManglisk"] = dtmd;
                grdmanglikdosha.DataSource = dtmd;
                grdmanglikdosha.DataBind();
            }
            dtmd.Dispose();

            string dsmdpstr1 = "", dsmdpstr2 = "";
            DataSet dsmdp = obj_subs.Get_Manglik_Dosha_Predictive("MANGLIK_DOSHA", BoyTotalPoints, GirlTotalPoints);
            if (dsmdp.Tables[0].Rows.Count > 0)
            {
                for (int p = 0; p < dsmdp.Tables[0].Rows.Count; p++)
                {
                    if (dsmdp.Tables[0].Rows[p]["PRIORITY"].ToString() == "1")
                    {
                        dsmdpstr1 += "" + dsmdp.Tables[0].Rows[p]["QUESTION"].ToString() + "</b>" + dsmdp.Tables[0].Rows[p]["PREDICTIVE"].ToString();
                    }
                    else
                    {
                        dsmdpstr2 += "" + dsmdp.Tables[0].Rows[p]["QUESTION"].ToString() + "</b>" + dsmdp.Tables[0].Rows[p]["PREDICTIVE"].ToString() + "";
                    }
                }
            }
            dsmdp.Dispose();

            ManglikDoshaDiv1.InnerHtml = dsmdpstr1.Replace("BBBBPPPP", "<b>" + BoyTotalPoints + " %</b>").Replace("GGGGPPPP", "<b>" + GirlTotalPoints + "  %</b>");
            ViewState["ManglikDoshaDiv1"] = dsmdpstr1.Replace("BBBBPPPP", "<b>" + BoyTotalPoints + " %</b>").Replace("GGGGPPPP", "<b>" + GirlTotalPoints + "  %</b>");
            ManglikDoshaDiv2.InnerHtml = dsmdpstr2.Replace("BBBBPPPP", "<b>" + BoyTotalPoints + " %</b>").Replace("GGGGPPPP", "<b>" + GirlTotalPoints + "  %</b>");
            ViewState["ManglikDoshaDiv2"] = dsmdpstr2.Replace("BBBBPPPP", "<b>" + BoyTotalPoints + " %</b>").Replace("GGGGPPPP", "<b>" + GirlTotalPoints + "  %</b>");

            //ManglikDoshaDiv.InnerHtml = "Boy Manglik Dosha :- <br />" + Boymanglik_result + "<br /><br />" + "Girl Manglik Dosha :- <br />" + Girlmanglik_result;

            #region Get Girl Dosha Samya
            dtds.Columns.AddRange(new DataColumn[2] { new DataColumn("DoshaSamyaofGirl"), new DataColumn("DoshaPercentageforGirl") });
            string dsresult_girl = "", palnetname_girl = "", totalpercentage_girl = "";
            DataSet ydsr2 = obj_subs.Get_Dosha_Samya_Result("ALL", "ALL", "ALL", "ALL", "", "", "", "DoshaSamya", "Y", "");
            if (ydsr2.Tables[0].Rows.Count > 0)
            {
                for (int a = 0; a < ydsr2.Tables[0].Rows.Count; a++)
                {
                    dsresult_girl = ydsr2.Tables[0].Rows[a]["DESCCLOB"].ToString();
                    palnetname_girl = Girlrespaapds.Tables[2].Rows[a]["PLANET"].ToString(); //ydsr.Tables[0].Rows[a]["PLANET"].ToString(); 
                    totalpercentage_girl = Girlrespaapds.Tables[2].Rows[a]["TOTALPERCENTAGE"].ToString();
                    if (palnetname_girl == "MARS")
                    {
                        //dtdsgirl.Rows.Add("Dosha Samya of Mars from Lagna , Moon and Venus Charts", totalpercentage_girl);
                        dtds.Rows[a]["DoshaSamyaofGirl"] = "Dosha Samya of Mars from Lagna , Moon and Venus Charts";
                        dtds.Rows[a]["DoshaPercentageforGirl"] = totalpercentage_girl;
                    }
                    if (palnetname_girl == "SATURN")
                    {
                        //dtdsgirl.Rows.Add("Dosha Samya of Saturn from Lagna , Moon and Venus Charts", totalpercentage_girl);
                        dtds.Rows[a]["DoshaSamyaofGirl"] = "Dosha Samya of Saturn from Lagna , Moon and Venus Charts";
                        dtds.Rows[a]["DoshaPercentageforGirl"] = totalpercentage_girl;
                    }
                    if (palnetname_girl == "RAHU")
                    {
                        //dtdsgirl.Rows.Add("Dosha Samya of Rahu from Lagna , Moon and Venus Charts", totalpercentage_girl);
                        dtds.Rows[a]["DoshaSamyaofGirl"] = "Dosha Samya of Rahu from Lagna , Moon and Venus Charts";
                        dtds.Rows[a]["DoshaPercentageforGirl"] = totalpercentage_girl;
                    }
                    if (palnetname_girl == "SUN")
                    {
                        //dtdsgirl.Rows.Add("Dosha Samya of Sun from Lagna , Moon and Venus Charts", totalpercentage_girl);
                        dtds.Rows[a]["DoshaSamyaofGirl"] = "Dosha Samya of Sun from Lagna , Moon and Venus Charts";
                        dtds.Rows[a]["DoshaPercentageforGirl"] = totalpercentage_girl;
                    }
                    //dsresult_girl = dsresult_girl.Replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                    //dsresult_girl = dsresult_girl.Replace("XXX", "<font color='#F4600A'><b>XXX</b></font>");
                    //dsresult_girl = dsresult_girl.Replace("HHH", "<font color='#F4600A'><b>HHH</b></font>");
                    //dsresult_girl = dsresult_girl.Replace("XX.XX", totalpercentage_girl);
                    //dsresult_girl = dsresult_girl.Replace("XXX", palnetname_girl);
                    //dsresult_girl = dsresult_girl.Replace("HHH", palnetname_girl);
                    //doshasamya_result_girl = doshasamya_result_girl + dsresult_girl + "<br /><br />";
                }
            }
            ydsr2.Dispose();
            #endregion

            if (dtds.Rows.Count > 0)
            {
                ViewState["grddoshasamya"] = dtds;
                grddoshasamya.DataSource = dtds;
                grddoshasamya.DataBind();
            }
            dtds.Dispose();


            string dsdspstr1 = "", dsdspstr2 = "";
            DataSet dsdsp = obj_subs.Get_Dosha_Samya_Predictive("DOSHA_SAMYA", BoyDoshaSamyaTotalPoints, GirlDoshaSamyaTotalPoints);
            if (dsdsp.Tables[0].Rows.Count > 0)
            {
                for (int p = 0; p < dsdsp.Tables[0].Rows.Count; p++)
                {
                    if (dsdsp.Tables[0].Rows[p]["PRIORITY"].ToString() == "1")
                    {
                        dsdspstr1 += "<b>" + dsdsp.Tables[0].Rows[p]["QUESTION"].ToString() + "</b>" + dsdsp.Tables[0].Rows[p]["PREDICTIVE"].ToString();
                    }
                    else
                    {
                        dsdspstr2 += "<b>" + dsdsp.Tables[0].Rows[p]["QUESTION"].ToString() + "</b>" + dsdsp.Tables[0].Rows[p]["PREDICTIVE"].ToString() + "";
                    }
                }
            }
            dsdsp.Dispose();

            DoshaSamyaDiv1.InnerHtml = dsdspstr1.Replace("BBBBPPPP", "<b>" + BoyDoshaSamyaTotalPoints + " %</b>").Replace("GGGGPPPP", "<b>" + GirlDoshaSamyaTotalPoints + "  %</b>");
            ViewState["DoshaSamyaDiv1"] = dsdspstr1.Replace("BBBBPPPP", "<b>" + BoyDoshaSamyaTotalPoints + " %</b>").Replace("GGGGPPPP", "<b>" + GirlDoshaSamyaTotalPoints + "  %</b>");
            DoshaSamyaDiv2.InnerHtml = dsdspstr2.Replace("BBBBPPPP", "<b>" + BoyDoshaSamyaTotalPoints + " %</b>").Replace("GGGGPPPP", "<b>" + GirlDoshaSamyaTotalPoints + "  %</b>");
            ViewState["DoshaSamyaDiv2"] = dsdspstr2.Replace("BBBBPPPP", "<b>" + BoyDoshaSamyaTotalPoints + " %</b>").Replace("GGGGPPPP", "<b>" + GirlDoshaSamyaTotalPoints + "  %</b>");
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion

    #region Get Bind Charts
    protected void BindCharts()
    {
        
        DataSet ds = new DataSet();
        hdnBoysID.Value = BoyId;
        hdnGirlID.Value = GirlId;
        ds = cm.GetAshthakootNadiMatch(BoyId, GirlId, "GET_MATCHING_REPORT");
        BindBasicDeatis("ForPdf");
        for (int jx = 0; jx <= 1; jx++)
        {
            Count = 1;
            strCart.Length = 0;
            Houes1Value = 0; Houes2Value = 0; Houes3Value = 0; Houes4Value = 0; Houes5Value = 0; Houes6Value = 0; Houes7Value = 0; Houes8Value = 0; Houes9Value = 0; Houes10Value = 0; Houes11Value = 0; Houes12Value = 0;
            StringBuilder TBL = new StringBuilder();
            string GetDetails = ds.Tables[jx].Rows[0]["HOROSCOPE_D01"].ToString();
            string j10 = "", h10 = "", j1 = "", h1 = "", RashiID0 = "", RashiID1 = "", j2 = "", h2 = "", RashiID2 = "", RashiID3 = "", RashiID4 = "", RashiID5 = "", Name = "",
            RashiID6 = "", RashiID7 = "", RashiID8 = "", RashiID9 = "", RashiID10 = "", RashiID11 = "", RashiID12 = "", j3 = "", j4 = "", j5 = "", j6 = "", j7 = "", j8 = "", j9 = "", j11 = "", j12 = "", h3 = "", h4 = "", h5 = "", h6 = "", h7 = "", h8 = "", h9 = "", h11 = "", h12 = "";
            if (jx == 0)
            {
                Gender = "Boy Chart";
                Name = ds.Tables[jx].Rows[0]["BOY_NAME"].ToString();
            }
            else
            {
                Gender = "Girl Chart";
                Name = ds.Tables[jx].Rows[0]["GIRL_NAME"].ToString();
            }

            List<string> lstPlanets = new List<string>();
            List<string> lstRashi = new List<string>();
            List<string> lstHouse = new List<string>();
            List<string> lstDegree = new List<string>();
            List<string> lstMintues = new List<string>();
            List<string> lstSecond = new List<string>();
            List<string> lstRetro = new List<string>();
            List<string> lstconstelation = new List<string>();

            #region Bind Birth Chart
            string ChartImagePath = System.Configuration.ConfigurationManager.AppSettings["ChartImagePath"];

            TBL.Append("<table style = \"width:100%;border-collapse: collapse;font-family: 'Roboto', sans-serif;font-size:13px;margin-bottom:.65cm;-webkit-print-color-adjust: exact;\">");
            TBL.Append("<tr>");
            TBL.Append("<td colspan = \"2\" style = \"text-align:left;padding:.30cm 0;\">");
            TBL.Append("<div style = \"font-size: 20px;font-weight:bold;color:#f25e0a;text-align: center;\" >" + Name + "'s Chart" + "</div>");
            TBL.Append("</td>");
            TBL.Append("</tr>");
            TBL.Append("<tr>");
            string vargasfinal = "", birth = "0" , retro="";
            string[] ar = GetDetails.Split('~');
            for (int j = 0; j < ar.Length - 1; j++)
            {
                string Value = ar[j];
                string[] SplitValue = Value.Split('/');

                lstPlanets.Add(SplitValue[0]);
                lstRashi.Add(SplitValue[1]);
                lstHouse.Add(SplitValue[2]);
                string val = SplitValue[3];
                string[] TimeVal = val.Split('.');
                lstDegree.Add(TimeVal[0]);
                lstMintues.Add(TimeVal[1]);
                lstSecond.Add(TimeVal[2]);
                lstconstelation.Add(SplitValue[5]);
                string GetRetro = SplitValue[4];
                if (GetRetro == "R")
                {
                    lstRetro.Add("R");
                    retro = "R";

                }
                else
                {
                    lstRetro.Add("B");
                    retro = "B";

                }
                string DegreeVal = lstDegree[j] + "." + lstMintues[j] + "." + lstSecond[j];

                vargasfinal = vargasfinal + lstPlanets[j] + "~" + lstRashi[j] + "~" + lstHouse[j] + "~" + birth + "~" + retro + "~" + DegreeVal + "~" + lstconstelation[j] + "$";
            }
            vargasfinal = vargasfinal.Substring(0, vargasfinal.Length - 1);
            DataSet DsDm = new DataSet();
            DsDm = country.vargas(vargasfinal);


            if (DsDm.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DsDm.Tables[0].Rows.Count; ++i)
                {
                    lstPlanetRashiId.Add(DsDm.Tables[0].Rows[i]["PLANET"].ToString());
                    D1lstHouse1.Add(DsDm.Tables[0].Rows[i]["D1_HOUSE"].ToString());
                    D1Rashi.Add(DsDm.Tables[0].Rows[i]["D1_RASHI"].ToString());
                    D1BirthTime.Add(DsDm.Tables[0].Rows[i]["BIRTH_TIME"].ToString());
                    D1Retro.Add(DsDm.Tables[0].Rows[i]["RETRO"].ToString());
                    D1Degree.Add(DsDm.Tables[0].Rows[i]["DEGREE"].ToString());
                    D2lstHouse1.Add(DsDm.Tables[0].Rows[i]["D2_HOUSE"].ToString());
                    D2Rashi.Add(DsDm.Tables[0].Rows[i]["D2_RASHI"].ToString());
                    D4lstHouse1.Add(DsDm.Tables[0].Rows[i]["D4_HOUSE"].ToString());
                    D4Rashi.Add(DsDm.Tables[0].Rows[i]["D4_RASHI"].ToString());
                    D9lstHouse1.Add(DsDm.Tables[0].Rows[i]["D9_HOUSE"].ToString());
                    D9Rashi.Add(DsDm.Tables[0].Rows[i]["D9_RASHI"].ToString());
                    D10lstHouse1.Add(DsDm.Tables[0].Rows[i]["D10_HOUSE"].ToString());
                    D10Rashi.Add(DsDm.Tables[0].Rows[i]["D10_RASHI"].ToString());
                    D24lstHouse1.Add(DsDm.Tables[0].Rows[i]["D24_HOUSE"].ToString());
                    D24Rashi.Add(DsDm.Tables[0].Rows[i]["D24_RASHI"].ToString());
                    D60lstHouse1.Add(DsDm.Tables[0].Rows[i]["D60_HOUSE"].ToString());
                    D60Rashi.Add(DsDm.Tables[0].Rows[i]["D60_RASHI"].ToString());
                    D03lstHouse1.Add(DsDm.Tables[0].Rows[i]["D3_HOUSE"].ToString());
                    D03Rashi.Add(DsDm.Tables[0].Rows[i]["D3_RASHI"].ToString());
                    D07lstHouse1.Add(DsDm.Tables[0].Rows[i]["D7_HOUSE"].ToString());
                    D07Rashi.Add(DsDm.Tables[0].Rows[i]["D7_RASHI"].ToString());
                    D12lstHouse1.Add(DsDm.Tables[0].Rows[i]["D12_HOUSE"].ToString());
                    D12Rashi.Add(DsDm.Tables[0].Rows[i]["D12_RASHI"].ToString());
                    D16lstHouse1.Add(DsDm.Tables[0].Rows[i]["D16_HOUSE"].ToString());
                    D16Rashi.Add(DsDm.Tables[0].Rows[i]["D16_RASHI"].ToString());
                    D30lstHouse1.Add(DsDm.Tables[0].Rows[i]["D30_HOUSE"].ToString());
                    D30Rashi.Add(DsDm.Tables[0].Rows[i]["D30_RASHI"].ToString());
                    D45lstHouse1.Add(DsDm.Tables[0].Rows[i]["D45_HOUSE"].ToString());
                    D45Rashi.Add(DsDm.Tables[0].Rows[i]["D45_RASHI"].ToString());
                    D20lstHouse1.Add(DsDm.Tables[0].Rows[i]["D20_HOUSE"].ToString());
                    D20Rashi.Add(DsDm.Tables[0].Rows[i]["D20_RASHI"].ToString());
                    D27lstHouse1.Add(DsDm.Tables[0].Rows[i]["D27_HOUSE"].ToString());
                    D27Rashi.Add(DsDm.Tables[0].Rows[i]["D27_RASHI"].ToString());
                    D40lstHouse1.Add(DsDm.Tables[0].Rows[i]["D40_HOUSE"].ToString());
                    D40Rashi.Add(DsDm.Tables[0].Rows[i]["D40_RASHI"].ToString());
                    D05lstHouse1.Add(DsDm.Tables[0].Rows[i]["D5_HOUSE"].ToString());
                    D05Rashi.Add(DsDm.Tables[0].Rows[i]["D5_RASHI"].ToString());
                    D06lstHouse1.Add(DsDm.Tables[0].Rows[i]["D6_HOUSE"].ToString());
                    D06Rashi.Add(DsDm.Tables[0].Rows[i]["D6_RASHI"].ToString());
                    D08lstHouse1.Add(DsDm.Tables[0].Rows[i]["D8_HOUSE"].ToString());
                    D08Rashi.Add(DsDm.Tables[0].Rows[i]["D8_RASHI"].ToString());
                    D11lstHouse1.Add(DsDm.Tables[0].Rows[i]["D11_HOUSE"].ToString());
                    D11Rashi.Add(DsDm.Tables[0].Rows[i]["D11_RASHI"].ToString());
                    DKLlstHouse1.Add(DsDm.Tables[0].Rows[i]["KARAKAMSHA_HOUSE"].ToString());
                    DKLRashi.Add(DsDm.Tables[0].Rows[i]["KARAKAMSHA_RASHI"].ToString());
                    DMoonlstHouse1.Add(DsDm.Tables[0].Rows[i]["MOON_HOUSE"].ToString());
                    DMoonRashi.Add(DsDm.Tables[0].Rows[i]["MOON_RASHI"].ToString());
                    DVenuslstHouse1.Add(DsDm.Tables[0].Rows[i]["VENUS_HOUSE"].ToString());
                    DVenusRashi.Add(DsDm.Tables[0].Rows[i]["VENUS_RASHI"].ToString());
                }
            }
            DsDm.Dispose();


            ShowChart("D02");
            ShowChart("D05");
            ShowChart("D06");
            ShowChart("D09");
            ShowChart("D10");
            ShowChart("D12");
            #region For Loop For Birth Chart
            for (int i = 0; i <= 10; i++)
            {
                string h = lstHouse[i];
                RashiID0 = lstRashi[0];

                string Retro = lstRetro[i];
                if (Retro == "B")
                {
                    Retro = "";
                }
                string Padding = "0px;";
                if (Retro != "")
                {
                    Padding = "2px;";
                }
                if (RashiID0 == "Aries")
                {
                    RashiID1 = "1";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = (Convert.ToInt32(RashiID8) + 1).ToString();
                    RashiID10 = (Convert.ToInt32(RashiID9) + 1).ToString();
                    RashiID11 = (Convert.ToInt32(RashiID10) + 1).ToString();
                    RashiID12 = (Convert.ToInt32(RashiID11) + 1).ToString();

                }
                if (RashiID0 == "Taurus")
                {
                    RashiID1 = "2";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = (Convert.ToInt32(RashiID8) + 1).ToString();
                    RashiID10 = (Convert.ToInt32(RashiID9) + 1).ToString();
                    RashiID11 = (Convert.ToInt32(RashiID10) + 1).ToString();
                    RashiID12 = "1";
                }

                if (RashiID0 == "Gemini")
                {
                    RashiID1 = "3";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = (Convert.ToInt32(RashiID8) + 1).ToString();
                    RashiID10 = (Convert.ToInt32(RashiID9) + 1).ToString();
                    RashiID11 = "1";
                    RashiID12 = "2";
                }

                if (RashiID0 == "Cancer")
                {
                    RashiID1 = "4";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = (Convert.ToInt32(RashiID8) + 1).ToString();
                    RashiID10 = "1";
                    RashiID11 = "2";
                    RashiID12 = "3";
                }
                if (RashiID0 == "Leo")
                {
                    RashiID1 = "5";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = "1";
                    RashiID10 = "2";
                    RashiID11 = "3";
                    RashiID12 = "4";
                }
                if (RashiID0 == "Virgo")
                {
                    RashiID1 = "6";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = "1";
                    RashiID9 = "2";
                    RashiID10 = "3";
                    RashiID11 = "4";
                    RashiID12 = "5";
                }

                if (RashiID0 == "Libra")
                {
                    RashiID1 = "7";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) - 11).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = (Convert.ToInt32(RashiID8) + 1).ToString();
                    RashiID10 = (Convert.ToInt32(RashiID9) + 1).ToString();
                    RashiID11 = (Convert.ToInt32(RashiID10) + 1).ToString();
                    RashiID12 = (Convert.ToInt32(RashiID11) + 1).ToString();
                }

                if (RashiID0 == "Scorpio")
                {
                    RashiID1 = "8";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) - 11).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = (Convert.ToInt32(RashiID8) + 1).ToString();
                    RashiID10 = (Convert.ToInt32(RashiID9) + 1).ToString();
                    RashiID11 = (Convert.ToInt32(RashiID10) + 1).ToString();
                    RashiID12 = (Convert.ToInt32(RashiID11) + 1).ToString();
                }

                if (RashiID0 == "Sagittarius")
                {
                    RashiID1 = "9";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) - 11).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = (Convert.ToInt32(RashiID8) + 1).ToString();
                    RashiID10 = (Convert.ToInt32(RashiID9) + 1).ToString();
                    RashiID11 = (Convert.ToInt32(RashiID10) + 1).ToString();
                    RashiID12 = (Convert.ToInt32(RashiID11) + 1).ToString();
                }

                if (RashiID0 == "Capricorn")
                {
                    RashiID1 = "10";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) - 11).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = (Convert.ToInt32(RashiID8) + 1).ToString();
                    RashiID10 = (Convert.ToInt32(RashiID9) + 1).ToString();
                    RashiID11 = (Convert.ToInt32(RashiID10) + 1).ToString();
                    RashiID12 = (Convert.ToInt32(RashiID11) + 1).ToString();
                }

                if (RashiID0 == "Aquarius")
                {
                    RashiID1 = "11";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) - 11).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = (Convert.ToInt32(RashiID8) + 1).ToString();
                    RashiID10 = (Convert.ToInt32(RashiID9) + 1).ToString();
                    RashiID11 = (Convert.ToInt32(RashiID10) + 1).ToString();
                    RashiID12 = (Convert.ToInt32(RashiID11) + 1).ToString();
                }
                if (RashiID0 == "Pisces")
                {
                    RashiID1 = "12";
                    RashiID2 = (Convert.ToInt32(RashiID1) - 11).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = (Convert.ToInt32(RashiID8) + 1).ToString();
                    RashiID10 = (Convert.ToInt32(RashiID9) + 1).ToString();
                    RashiID11 = (Convert.ToInt32(RashiID10) + 1).ToString();
                    RashiID12 = (Convert.ToInt32(RashiID11) + 1).ToString();
                }
                if (h == "HOUSE1")
                {
                    Houes1Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j1 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "JUPITER")
                    {
                        j1 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "VENUS")
                    {
                        j1 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SATURN")
                    {
                        j1 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SUN")
                    {
                        j1 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MOON")
                    {
                        j1 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MARS")
                    {
                        j1 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "RAHU")
                    {
                        j1 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j1 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "GULIKA")
                    {
                        j1 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    h1 = h1 + j1 + " ";
                }

                if (h == "HOUSE2")
                {

                    Houes2Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j2 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "JUPITER")
                    {
                        j2 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "VENUS")
                    {
                        j2 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SATURN")
                    {
                        j2 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SUN")
                    {
                        j2 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MOON")
                    {
                        j2 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MARS")
                    {
                        j2 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "RAHU")
                    {
                        j2 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j2 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "GULIKA")
                    {
                        j2 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    h2 = h2 + j2 + " ";
                }

                if (h == "HOUSE3")
                {
                    Houes3Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j3 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "JUPITER")
                    {
                        j3 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "VENUS")
                    {
                        j3 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SATURN")
                    {
                        j3 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left:" + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SUN")
                    {
                        j3 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MOON")
                    {
                        j3 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MARS")
                    {
                        j3 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left:" + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "RAHU")
                    {
                        j3 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j3 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "GULIKA")
                    {
                        j3 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    h3 = h3 + j3 + " ";
                }

                if (h == "HOUSE4")
                {
                    Houes4Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j4 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "JUPITER")
                    {
                        j4 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "VENUS")
                    {
                        j4 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SATURN")
                    {
                        j4 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SUN")
                    {
                        j4 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MOON")
                    {
                        j4 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MARS")
                    {
                        j4 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "RAHU")
                    {
                        j4 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j4 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "GULIKA")
                    {
                        j4 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    h4 = h4 + j4 + " ";
                }


                if (h == "HOUSE5")
                {
                    Houes5Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j5 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "JUPITER")
                    {
                        j5 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "VENUS")
                    {
                        j5 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SATURN")
                    {
                        j5 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SUN")
                    {
                        j5 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MOON")
                    {
                        j5 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MARS")
                    {
                        j5 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "RAHU")
                    {
                        j5 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j5 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "GULIKA")
                    {
                        j5 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    h5 = h5 + j5 + " ";
                }

                if (h == "HOUSE6")
                {
                    Houes6Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j6 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:#F4600A; font-size:12px;font-weight: bold;\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:#F4600A; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }
                    if (lstPlanets[i] == "JUPITER")
                    {
                        j6 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:#F4600A; font-size:12px;font-weight: bold;\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:#F4600A; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }

                    if (lstPlanets[i] == "VENUS")
                    {
                        j6 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:#F4600A; font-size:12px;font-weight: bold;\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:#F4600A; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }

                    if (lstPlanets[i] == "SATURN")
                    {
                        j6 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:#F4600A; font-size:12px;font-weight: bold;\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:#F4600A; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }

                    if (lstPlanets[i] == "SUN")
                    {
                        j6 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:#F4600A; font-size:12px;font-weight: bold;\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:#F4600A; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }

                    if (lstPlanets[i] == "MOON")
                    {
                        j6 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:#F4600A; font-size:12px;font-weight: bold;\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:#F4600A; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }

                    if (lstPlanets[i] == "MARS")
                    {
                        j6 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:#F4600A; font-size:12px;font-weight: bold;\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:#F4600A; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }

                    if (lstPlanets[i] == "RAHU")
                    {
                        j6 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:#F4600A; font-size:12px;font-weight: bold;\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:#F4600A; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j6 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:#F4600A; font-size:12px;font-weight: bold;\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:#F4600A; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }

                    if (lstPlanets[i] == "GULIKA")
                    {
                        j6 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:#F4600A; font-size:12px;font-weight: bold;\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:#F4600A; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }
                    h6 = h6 + j6 + " ";
                }

                if (h == "HOUSE7")
                {
                    Houes7Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j7 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "JUPITER")
                    {
                        j7 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "VENUS")
                    {
                        j7 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SATURN")
                    {
                        j7 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SUN")
                    {
                        j7 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MOON")
                    {
                        j7 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MARS")
                    {
                        j7 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "RAHU")
                    {
                        j7 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j7 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "GULIKA")
                    {
                        j7 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }
                    h7 = h7 + j7 + " ";
                }
                if (h == "HOUSE8")
                {
                    Houes8Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j8 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "JUPITER")
                    {
                        j8 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "VENUS")
                    {
                        j8 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SATURN")
                    {
                        j8 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SUN")
                    {
                        j8 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MOON")
                    {
                        j8 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MARS")
                    {
                        j8 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "RAHU")
                    {
                        j8 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j8 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "GULIKA")
                    {
                        j8 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    h8 = h8 + j8 + " ";
                }

                if (h == "HOUSE9")
                {
                    Houes9Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j9 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "JUPITER")
                    {
                        j9 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "VENUS")
                    {
                        j9 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SATURN")
                    {
                        j9 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SUN")
                    {
                        j9 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MOON")
                    {
                        j9 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MARS")
                    {
                        j9 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "RAHU")
                    {
                        j9 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j9 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "GULIKA")
                    {
                        j9 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    h9 = h9 + j9 + " ";
                }


                if (h == "HOUSE10")
                {
                    Houes10Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j10 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "JUPITER")
                    {
                        j10 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "VENUS")
                    {
                        j10 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "SATURN")
                    {
                        j10 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "SUN")
                    {
                        j10 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "MOON")
                    {
                        j10 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "MARS")
                    {
                        j10 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "RAHU")
                    {
                        j10 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j10 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "GULIKA")
                    {
                        j10 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    h10 = h10 + j10 + " ";
                }
                if (h == "HOUSE11")
                {
                    Houes11Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j11 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "JUPITER")
                    {
                        j11 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "VENUS")
                    {
                        j11 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "SATURN")
                    {
                        j11 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "SUN")
                    {
                        j11 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "MOON")
                    {
                        j11 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "MARS")
                    {
                        j11 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "RAHU")
                    {
                        j11 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j11 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "GULIKA")
                    {
                        j11 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    h11 = h11 + j11 + " ";
                }
                if (h == "HOUSE12")
                {
                    Houes12Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j12 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "JUPITER")
                    {
                        j12 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "VENUS")
                    {
                        j12 = "<span style='color:" + VeColor + "'>Ve</span>" + " <span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "SATURN")
                    {
                        j12 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "SUN")
                    {
                        j12 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "MOON")
                    {
                        j12 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "MARS")
                    {
                        j12 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "RAHU")
                    {
                        j12 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j12 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "GULIKA")
                    {
                        j12 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    h12 = h12 + j12 + " ";
                }
            }
            #endregion

            TBL.Append("<td colspan = \"2\" style = \"padding:0px 0px 0px 20px;vertical-align:top;width:500px;\">");
            TBL.Append("<div style = \"background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:500px;height: 450px;\">");
            string Top1 = "20%;";
            string fontsize1 = "18px;";
            if (Houes1Value > 3)
            {
                Top1 = "11%;";
            }
            if (Houes1Value >= 5)
            {
                fontsize1 = "14px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top1 + " left:44%;width:30%;\">");
            TBL.Append("<span>");
            string Ret = "";
            if (lstRetro[0] == "R")
            {
                Ret = "R";
            }
            /******* House 1 *******/
            TBL.Append("<span id = \"DetailsHouese1\" style = \"text-align:left; color:#403E3E; font-weight: bold;font-size:" + fontsize1 + ";'\"><span style='color:" + AscColor + ";font-size:" + fontsize1 + "'>As</span><span style =\"text-align:left; color:black; font-size:12px;font-weight: bold;\"> " + Ret + "</span><span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[0] + "</span><span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">." + lstMintues[0] + "</span><br/> " + h1 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:41%;left:49.5%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"DetailsHouese1Rashi\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID1 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");

            /******* House 2 *******/
            string Top2 = "3%;";
            string Left = "14%;";
            string fontsize2 = "18px;";
            string LineHeight2 = "";
            if (Houes2Value >= 3)
            {
                fontsize2 = "14px;";
                Top2 = "2%;";
                Left = "20%;";
            }
            if (Houes2Value >= 5)
            {
                Top2 = "1%;";
                fontsize2 = "12px;";
                LineHeight2 = "line-height:15px;";
            }
            TBL.Append("<div style=\"position:absolute; top: " + Top2 + " left: " + Left + "width:30%;" + LineHeight2 + "\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"DetailsHouese2\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize2 + "font-weight: bold;\">" + h2 + " </span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top: 16%;  left: 25%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"DetailsHouese2Rashi\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID2 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");


            /******* House 3 *******/
            string Top3 = "20%;";
            string fontsize3 = "18px;";
            if (Houes3Value > 3)
            {
                Top3 = "11%;";
            }
            if (Houes3Value >= 5)
            {
                fontsize3 = "14px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top3 + " left:2%;width:15%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"DetailsHouese3\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize3 + " font-weight: bold;\">" + h3 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute;top: 19.2%; left:22.5%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"DetailsHouese3Rashi\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID3 + "</span><br></span></span>");
            TBL.Append("</div>");

            /******* House 4 *******/
            string Top4 = "42%;";
            string left = "15%;";
            string fontsize4 = "18px;";
            if (Houes4Value > 3)
            {
                Top4 = "37%;";
                left = " 18%;";
            }
            if (Houes4Value > 5)
            {
                fontsize4 = "12px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top4 + " left:" + left + "width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"DetailsHouese4\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize4 + "font-weight: bold;\">" + h4 + " </span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:43.3%; left:47%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"DetailsHouese4Rashi\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID4 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");


            /******* House 5*******/
            string Top5 = "70%;";
            string fontsize5 = "18px;";
            if (Houes5Value > 3)
            {
                Top5 = "59%;";
            }
            if (Houes5Value >= 5)
            {
                fontsize5 = "14px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top5 + " left:2%;width:20%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"DetailsHouese5\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize5 + "font-weight: bold;\">" + h5 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute;top: 67.8%; left:22.7%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"DetailsHouese5Rashi\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID5 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");


            /******* House 6*******/
            string Top6 = "87%;";
            string Left6 = "11%;";
            string fontsize6 = "18px;";
            string LineHeight6 = "";
            if (Houes6Value >= 3)
            {
                Top6 = "81%;";
                //Left6 = "20%;";
            }
            if (Houes6Value >= 4)
            {
                 Top6 = "89%;";
                fontsize6 = "12px;";
                LineHeight6 = "line-height:15px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top6 + " left:" + Left6 + "width:30%;" + LineHeight6 + "\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"DetailsHouese6\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize6 + ";font-weight: bold;\"> " + h6 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top: 70.5%; left:25%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"DetailsHouese6Rashi\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID6 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");

            /******* House 7*******/
            string Top7 = "70%;";
            string fontsize7 = "18px;";
            if (Houes7Value > 3)
            {
                Top7 = "60%;";
            }
            if (Houes7Value > 5)
            {
                fontsize7 = "14px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top7 + "left:45%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"1hasd7l1\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize7 + "font-weight: bold;\">" + h7 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute;top: 46%; left:49%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"1hsad7r\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID7 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");


            /******* House 8*******/
            string Top8 = "82%;";
         
            string Left8 = "70%;";
            string LineHeight8 = "";
            string fontsize8 = "18px;";
            if (Houes8Value > 3)
            {
                Top8 = "78%;";
                Left8 = "70%;";
                LineHeight8 = "line-height:15px;";
               
            }
            if (Houes8Value >= 3)
            {
                fontsize8 = "12px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top8 + " left:" + Left8 + "width:30%;" + LineHeight8 + "\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"ads\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize8 + "font-weight: bold;\">" + h8 + "</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:70%; left:74%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"1asdh8r\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID8 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            /******* House 9*******/
            string Top9 = "67%;";
            string fontsize9 = "18px;";
            string LineHeight9 = "";
            if (Houes9Value >= 4)
            {
                Top9 = "64%;";
                 fontsize9 = "13px;";

            }
            if (Houes9Value >= 5)
            {
                LineHeight9 = "line-height:15px;";
                fontsize9 = "12px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top9 + " left:85%;width:15%;" + LineHeight9 + "\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"1h9l1\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize9 + ";font-weight: bold;\">" + h9 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:68%;left: 76%;width:11%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"1adh9r\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID9 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");

            /******* House 10******/
            string Top10 = "45%;";
            string fontsize10 = "18px;";

            if (Houes10Value >= 5)
            {
                Top10 = "36%;";
            }
            if (Houes10Value > 5)
            {
                fontsize10 = "12px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top10 + "; left:67%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"1h10l1\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize10 + "font-weight: bold;\">" + h10 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute;top:43.3%;left: 52%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"h10ForRashi\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight:bold;\">" + RashiID10 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");

            /******* House 11******/
            string Top11 = "20%;";
            string fontsize11 = "16px;";
            string LineHeight11 = "";
            if (Houes11Value > 3)
            {
                Top11 = "15%;";
            }
            if (Houes11Value >= 5)
            {
                LineHeight11 = "line-height:15px;";
                fontsize11 = "12px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top11 + " left:84%;width:22%;" + LineHeight11 + "\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"h10FDegPln\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize11 + "font-weight: bold;\">" + h11 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute;top: 19%; left: 76%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"1h11r\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID11 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            /******* House 12******/
            string Top12 = "3%;";
     
            string fontsize12 = "16px;";
            string LineHeight12 = "";
            if (Houes12Value > 3)
            {
                Top12 = "0%;";
              }
            if (Houes12Value >= 5)
            {
                fontsize12 = "14px;";
                LineHeight12 = "line-height:15px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top12 + "; left:69%;width:30%;" + LineHeight12 + "\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"1h12l1\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize12 + "font-weight: bold;\">" + h12 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top: 17%;left:74%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"1h12r\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID12 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("</div>");

            TBL.Append("</td>");
            TBL.Append("</tr>");
            TBL.Append("</table>");

          
 
          
            #endregion
            if (Gender == "Boy Chart")
            {
                divBoysChart.InnerHtml = TBL.ToString();
                BoySmallCHart.InnerHtml = strCart.ToString();
            }
            else
            {
                divGirlsChart.InnerHtml = TBL.ToString();
                GirlSmallCHart.InnerHtml = strCart.ToString();
            }
        }
    }
    #endregion

    #region Show All Charts
    protected void ShowChart(string ChartNo)
    {
        p21 = ""; p22 = ""; p23 = ""; p24 = ""; p25 = ""; p26 = ""; p27 = ""; p28 = ""; p29 = ""; p210 = ""; p211 = ""; p212 = ""; HeaderValue = "";
        j21 = ""; j22 = ""; j23 = ""; j24 = ""; j25 = ""; j26 = ""; j27 = ""; j28 = ""; j29 = ""; j210 = ""; j211 = ""; j212 = "";
        h21 = ""; h22 = ""; h23 = ""; h24 = ""; h25 = ""; h26 = ""; h27 = ""; h28 = ""; h29 = ""; h210 = ""; h211 = ""; r11 = ""; h212 = "";
        r21 = ""; r22 = ""; r23 = ""; r24 = ""; r25 = ""; r26 = ""; r27 = ""; r28 = ""; r29 = ""; r210 = ""; r211 = ""; r212 = "";

        //chartname = chartno;
        //    document.getElementById('chart').value = chartname;

        if (ChartNo == "D09")
        {
            HeaderValue = ChartNo + " (Pros & Cons of Married Life, Strength of Planets)";
        }
        if (ChartNo == "D10")
        {
            HeaderValue = ChartNo + " (Power & Position)";
        }
        if (ChartNo == "D24")
        {
            HeaderValue = ChartNo + " (Scholarly & Academic status)";
        }
        if (ChartNo == "D60")
        {
            HeaderValue = ChartNo + " (General Indications & Shubhatwa)";
        }
        if (ChartNo == "D02")
        {
            HeaderValue = ChartNo + " (Wealth etc)";
        }
        if (ChartNo == "D03")
        {
            HeaderValue = ChartNo + " (Happiness through Siblings)";
        }
        if (ChartNo == "D04")
        {
            HeaderValue = ChartNo + " (Fortune of Native)";
        }
        if (ChartNo == "D07")
        {
            HeaderValue = ChartNo + " (Happiness through Children)";
        }
        if (ChartNo == "D12")
        {
            HeaderValue = ChartNo + " (Happines through Parents)";
        }
        if (ChartNo == "D16")
        {
            HeaderValue = ChartNo + " (Comforts of Vehicle & Shubhatwa)";
        }
        if (ChartNo == "D30")
        {
            HeaderValue = ChartNo + " (Arishtha & Dangers)";
        }
        if (ChartNo == "D45")
        {
            HeaderValue = ChartNo + " (General Indications of life)";
        }
        if (ChartNo == "D20")
        {
            HeaderValue = ChartNo + " (Worship & Spiritual attainment)";
        }
        if (ChartNo == "D27")
        {
            HeaderValue = ChartNo + " (Strength & Weakness)";
        }
        if (ChartNo == "D40")
        {
            HeaderValue = ChartNo + " (Auspicious & Inauspicious effect)";
        }
        if (ChartNo == "D05")
        {
            HeaderValue = ChartNo + " (Fame & Power)";
        }
        if (ChartNo == "D06")
        {
            HeaderValue = ChartNo + " (Health)";
        }
        if (ChartNo == "D08")
        {
            HeaderValue = ChartNo + " (Unexpected Troubles)";
        }
        if (ChartNo == "D11")
        {
            HeaderValue = ChartNo + " (Death and Destruction)";
        }
        if (ChartNo == "MOON")
        {
            HeaderValue = ChartNo;
        }
        if (ChartNo == "VENUS")
        {
            HeaderValue = ChartNo;
        }
        string h = "", r = "";
        for (var i = 1; i <= 10; i++)
        {
            if (ChartNo == "D09")
            {
                h = D9lstHouse1[i];
                r = D9Rashi[0];
            }

            if (ChartNo == "D10")
            {
                h = D10lstHouse1[i];
                r = D10Rashi[0];
            }
            if (ChartNo == "D24")
            {
                h = D24lstHouse1[i];
                r = D24Rashi[0];
            }

            if (ChartNo == "D60")
            {
                h = D60lstHouse1[i];
                r = D60Rashi[0];
            }

            if (ChartNo == "D02")
            {
                h = D2lstHouse1[i];
                r = D2Rashi[0];
            }

            if (ChartNo == "D03")
            {
                h = D03lstHouse1[i];
                r = D03Rashi[0];
            }

            if (ChartNo == "D04")
            {
                h = D4lstHouse1[i];
                r = D4Rashi[0];
            }
            if (ChartNo == "D07")
            {
                h = D07lstHouse1[i];
                r = D07Rashi[0];
            }
            if (ChartNo == "D12")
            {
                h = D12lstHouse1[i];
                r = D12Rashi[0];
            }
            if (ChartNo == "D16")
            {
                h = D16lstHouse1[i];
                r = D16Rashi[0];
            }
            if (ChartNo == "D30")
            {
                h = D30lstHouse1[i];
                r = D30Rashi[0];
            }
            if (ChartNo == "D45")
            {
                h = D45lstHouse1[i];
                r = D45Rashi[0];
            }
            if (ChartNo == "D20")
            {
                h = D20lstHouse1[i];
                r = D20Rashi[0];
            }
            if (ChartNo == "D27")
            {
                h = D27lstHouse1[i];
                r = D27Rashi[0];
            }
            if (ChartNo == "D40")
            {
                h = D40lstHouse1[i];
                r = D40Rashi[0];
            }
            if (ChartNo == "D05")
            {
                h = D05lstHouse1[i];
                r = D05Rashi[0];
            }
            if (ChartNo == "D06")
            {
                h = D06lstHouse1[i];
                r = D06Rashi[0];
            }
            if (ChartNo == "D08")
            {
                h = D08lstHouse1[i];
                r = D08Rashi[0];
            }
            if (ChartNo == "D11")
            {
                h = D11lstHouse1[i];
                r = D11Rashi[0];
            }
            if (ChartNo == "KL")
            {
                h = DKLlstHouse1[i];
                r = DKLRashi[0];
            }
            if (ChartNo == "MOON")
            {
                h = DMoonlstHouse1[i];
                r = DMoonRashi[0];
            }
            if (ChartNo == "VENUS")
            {
                h = DVenuslstHouse1[i];
                r = DVenusRashi[0];
            }
            #region HOUSE1 Condition
            if (h == "HOUSE1")
            {
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j21 = "<span style='font-size:14px;color:" + MeColor + "'>Me</span>";
                }

                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j21 = "<span style='font-size:14px;color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j21 = "<span style='font-size:14px;color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j21 = "<span style='font-size:14px;color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j21 = "<span style='font-size:14px;color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j21 = "<span style='font-size:14px;color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j21 = "<span style='font-size:14px;color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j21 = "<span style='font-size:14px;color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j21 = "<span style='font-size:14px;color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j21 = "<span style='font-size:14px;color:" + GkColor + "'>Gk</span>";
                }
                h21 = h21 + j21 + " ";
            }
            #endregion
            #region HOUSE2 Condition
            if (h == "HOUSE2")
            {
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j22 = "<span style='font-size:14px;color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j22 = "<span style='font-size:14px;color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j22 = "<span style='font-size:14px;color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j22 = "<span style='font-size:14px;color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j22 = "<span style='font-size:14px;color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j22 = "<span style='font-size:14px;color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j22 = "<span style='font-size:14px;color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j22 = "<span style='font-size:14px;color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j22 = "<span style='font-size:14px;color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j22 = "<span style='font-size:14px;color:" + GkColor + "'>Gk</span>";
                }
                h22 = h22 + j22 + " ";
            }
            #endregion
            #region HOUSE3 Condition
            if (h == "HOUSE3")
            {
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j23 = "<span style='font-size:14px;color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j23 = "<span style='font-size:14px;color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j23 = "<span style='font-size:14px;color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j23 = "<span style='font-size:14px;color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j23 = "<span style='font-size:14px;color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j23 = "<span style='font-size:14px;color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j23 = "<span style='font-size:14px;color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j23 = "<span style='font-size:14px;color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j23 = "<span style='font-size:14px;color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j23 = "<span style='font-size:14px;color:" + GkColor + "'>Gk</span>";
                }
                h23 = h23 + j23 + " ";
            }
            #endregion
            #region HOUSE4 Condition
            if (h == "HOUSE4")
            {
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j24 = "<span style='font-size:14px;color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j24 = "<span style='font-size:14px;color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j24 = "<span style='font-size:14px;color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j24 = "<span style='font-size:14px;color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j24 = "<span style='font-size:14px;color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j24 = "<span style='font-size:14px;color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j24 = "<span style='font-size:14px;color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j24 = "<span style='font-size:14px;color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j24 = "<span style='font-size:14px;color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j24 = "<span style='font-size:14px;color:" + GkColor + "'>Gk</span>";
                }
                h24 = h24 + j24 + " ";
            }
            #endregion
            #region HOUSE5 Condition
            if (h == "HOUSE5")
            {
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j25 = "<span style='font-size:14px;color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j25 = "<span style='font-size:14px;color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j25 = "<span style='font-size:14px;color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j25 = "<span style='font-size:14px;color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j25 = "<span style='font-size:14px;color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j25 = "<span style='font-size:14px;color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j25 = "<span style='font-size:14px;color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j25 = "<span style='font-size:14px;color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j25 = "<span style='font-size:14px;color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j25 = "<span style='font-size:14px;color:" + GkColor + "'>Gk</span>";
                }
                h25 = h25 + j25 + " ";
            }
            #endregion
            #region HOUSE6 Condition
            if (h == "HOUSE6")
            {
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j26 = "<span style='font-size:14px;color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j26 = "<span style='font-size:14px;color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j26 = "<span style='font-size:14px;color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j26 = "<span style='font-size:14px;color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j26 = "<span style='font-size:14px;color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j26 = "<span style='font-size:14px;color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j26 = "<span style='font-size:14px;color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j26 = "<span style='font-size:14px;color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j26 = "<span style='font-size:14px;color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j26 = "<span style='font-size:14px;color:" + GkColor + "'>Gk</span>";
                }
                h26 = h26 + j26 + " ";
            }
            #endregion
            #region HOUSE7 Condition
            if (h == "HOUSE7")
            {
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j27 = "<span style='font-size:14px;color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j27 = "<span style='font-size:14px;color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j27 = "<span style='font-size:14px;color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j27 = "<span style='font-size:14px;color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j27 = "<span style='font-size:14px;color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j27 = "<span style='font-size:14px;color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j27 = "<span style='font-size:14px;color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j27 = "<span style='font-size:14px;color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j27 = "<span style='font-size:14px;color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j27 = "<span style='font-size:14px;color:" + GkColor + "'>Gk</span>";
                }
                h27 = h27 + j27 + " ";
            }
            #endregion
            #region HOUSE8 Condition
            if (h == "HOUSE8")
            {
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j28 = "<span style='font-size:14px;color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j28 = "<span style='font-size:14px;color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j28 = "<span style='font-size:14px;color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j28 = "<span style='font-size:14px;color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j28 = "<span style='font-size:14px;color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j28 = "<span style='font-size:14px;color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j28 = "<span style='font-size:14px;color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j28 = "<span style='font-size:14px;color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j28 = "<span style='font-size:14px;color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j28 = "<span style='font-size:14px;color:" + GkColor + "'>Gk</span>";
                }
                h28 = h28 + j28 + " ";
            }
            #endregion
            #region HOUSE9 Condition
            if (h == "HOUSE9")
            {
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j29 = "<span style='font-size:14px;color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j29 = "<span style='font-size:14px;color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j29 = "<span style='font-size:14px;color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j29 = "<span style='font-size:14px;color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j29 = "<span style='font-size:14px;color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j29 = "<span style='font-size:14px;color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j29 = "<span style='font-size:14px;color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j29 = "<span style='font-size:14px;color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j29 = "<span style='font-size:14px;color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j29 = "<span style='font-size:14px;color:" + GkColor + "'>Gk</span>";
                }
                h29 = h29 + j29 + " ";
            }
            #endregion
            #region HOUSE10 Condition
            if (h == "HOUSE10")
            {
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j210 = "<span style='font-size:14px;color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j210 = "<span style='font-size:14px;color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j210 = "<span style='font-size:14px;color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j210 = "<span style='font-size:14px;color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j210 = "<span style='font-size:14px;color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j210 = "<span style='font-size:14px;color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j210 = "<span style='font-size:14px;color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j210 = "<span style='font-size:14px;color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j210 = "<span style='font-size:14px;color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j210 = "<span style='font-size:14px;color:" + GkColor + "'>Gk</span>";
                }
                h210 = h210 + j210 + " ";
            }
            #endregion
            #region HOUSE11 Condition
            if (h == "HOUSE11")
            {
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j211 = "<span style='font-size:14px;color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j211 = "<span style='font-size:14px;color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j211 = "<span style='font-size:14px;color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j211 = "<span style='font-size:14px;color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j211 = "<span style='font-size:14px;color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j211 = "<span style='font-size:14px;color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j211 = "<span style='font-size:14px;color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j211 = "<span style='font-size:14px;color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j211 = "<span style='font-size:14px;color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j211 = "<span style='font-size:14px;color:" + GkColor + "'>Gk</span>";
                }
                h211 = h211 + j211 + " ";
            }
            #endregion
            #region HOUSE12 Condition
            if (h == "HOUSE12")
            {
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j212 = "<span style='font-size:14px;color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j212 = "<span style='font-size:14px;color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j212 = "<span style='font-size:14px;color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j212 = "<span style='font-size:14px;color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j212 = "<span style='font-size:14px;color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j212 = "<span style='font-size:14px;color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j212 = "<span style='font-size:14px;color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j212 = "<span style='font-size:14px;color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j212 = "<span style='font-size:14px;color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j212 = "<span style='font-size:14px;color:" + GkColor + "'>Gk</span>";
                }
                h212 = h212 + j212 + " ";
            }
            #endregion
        }
        if (r == "Aries")
        {
            r21 = "1";
            r22 = ((Convert.ToInt32(r21) + 1)).ToString();
            r23 = ((Convert.ToInt32(r22) + 1)).ToString();
            r24 = ((Convert.ToInt32(r23) + 1)).ToString();
            r25 = ((Convert.ToInt32(r24) + 1)).ToString();
            r26 = ((Convert.ToInt32(r25) + 1)).ToString();
            r27 = ((Convert.ToInt32(r26) + 1)).ToString();
            r28 = ((Convert.ToInt32(r27) + 1)).ToString();
            r29 = ((Convert.ToInt32(r28) + 1)).ToString();
            r210 = ((Convert.ToInt32(r29) + 1)).ToString();
            r211 = ((Convert.ToInt32(r210) + 1)).ToString();
            r212 = ((Convert.ToInt32(r211) + 1)).ToString();

        }
        if (r == "Taurus")
        {
            r21 = "2";
            r22 = ((Convert.ToInt32(r21) + 1)).ToString();
            r23 = ((Convert.ToInt32(r22) + 1)).ToString();
            r24 = ((Convert.ToInt32(r23) + 1)).ToString();
            r25 = ((Convert.ToInt32(r24) + 1)).ToString();
            r26 = ((Convert.ToInt32(r25) + 1)).ToString();
            r27 = ((Convert.ToInt32(r26) + 1)).ToString();
            r28 = ((Convert.ToInt32(r27) + 1)).ToString();
            r29 = ((Convert.ToInt32(r28) + 1)).ToString();
            r210 = ((Convert.ToInt32(r29) + 1)).ToString();
            r211 = ((Convert.ToInt32(r210) + 1)).ToString();
            r212 = "1";
        }

        if (r == "Gemini")
        {
            r21 = "3";
            r22 = ((Convert.ToInt32(r21) + 1)).ToString();
            r23 = ((Convert.ToInt32(r22) + 1)).ToString();
            r24 = ((Convert.ToInt32(r23) + 1)).ToString();
            r25 = ((Convert.ToInt32(r24) + 1)).ToString();
            r26 = ((Convert.ToInt32(r25) + 1)).ToString();
            r27 = ((Convert.ToInt32(r26) + 1)).ToString();
            r28 = ((Convert.ToInt32(r27) + 1)).ToString();
            r29 = ((Convert.ToInt32(r28) + 1)).ToString();
            r210 = ((Convert.ToInt32(r29) + 1)).ToString();
            r211 = "1";
            r212 = "2";
        }

        if (r == "Cancer")
        {
            r21 = "4";
            r22 = ((Convert.ToInt32(r21) + 1)).ToString();
            r23 = ((Convert.ToInt32(r22) + 1)).ToString();
            r24 = ((Convert.ToInt32(r23) + 1)).ToString();
            r25 = ((Convert.ToInt32(r24) + 1)).ToString();
            r26 = ((Convert.ToInt32(r25) + 1)).ToString();
            r27 = ((Convert.ToInt32(r26) + 1)).ToString();
            r28 = ((Convert.ToInt32(r27) + 1)).ToString();
            r29 = ((Convert.ToInt32(r28) + 1)).ToString();
            r210 = "1";
            r211 = "2";
            r212 = "3";
        }


        if (r == "Leo")
        {
            r21 = "5";
            r22 = ((Convert.ToInt32(r21) + 1)).ToString();
            r23 = ((Convert.ToInt32(r22) + 1)).ToString();
            r24 = ((Convert.ToInt32(r23) + 1)).ToString();
            r25 = ((Convert.ToInt32(r24) + 1)).ToString();
            r26 = ((Convert.ToInt32(r25) + 1)).ToString();
            r27 = ((Convert.ToInt32(r26) + 1)).ToString();
            r28 = ((Convert.ToInt32(r27) + 1)).ToString();
            r29 = "1";
            r210 = "2";
            r211 = "3";
            r212 = "4";
        }
        if (r == "Virgo")
        {
            r21 = "6";
            r22 = ((Convert.ToInt32(r21) + 1)).ToString();
            r23 = ((Convert.ToInt32(r22) + 1)).ToString();
            r24 = ((Convert.ToInt32(r23) + 1)).ToString();
            r25 = ((Convert.ToInt32(r24) + 1)).ToString();
            r26 = ((Convert.ToInt32(r25) + 1)).ToString();
            r27 = ((Convert.ToInt32(r26) + 1)).ToString();
            r28 = "1";
            r29 = "2";
            r210 = "3";
            r211 = "4";
            r212 = "5";
        }

        if (r == "Libra")
        {
            r21 = "7";
            r22 = ((Convert.ToInt32(r21) + 1)).ToString();
            r23 = ((Convert.ToInt32(r22) + 1)).ToString();
            r24 = ((Convert.ToInt32(r23) + 1)).ToString();
            r25 = ((Convert.ToInt32(r24) + 1)).ToString();
            r26 = ((Convert.ToInt32(r25) + 1)).ToString();
            r27 = ((Convert.ToInt32(r26) - 11)).ToString();
            r28 = ((Convert.ToInt32(r27) + 1)).ToString();
            r29 = ((Convert.ToInt32(r28) + 1)).ToString();
            r210 = ((Convert.ToInt32(r29) + 1)).ToString();
            r211 = ((Convert.ToInt32(r210) + 1)).ToString();
            r212 = ((Convert.ToInt32(r211) + 1)).ToString();
        }
        if (r == "Scorpio")
        {
            r21 = "8";
            r22 = ((Convert.ToInt32(r21) + 1)).ToString();
            r23 = ((Convert.ToInt32(r22) + 1)).ToString();
            r24 = ((Convert.ToInt32(r23) + 1)).ToString();
            r25 = ((Convert.ToInt32(r24) + 1)).ToString();
            r26 = ((Convert.ToInt32(r25) - 11)).ToString();
            r27 = ((Convert.ToInt32(r26) + 1)).ToString();
            r28 = ((Convert.ToInt32(r27) + 1)).ToString();
            r29 = ((Convert.ToInt32(r28) + 1)).ToString();
            r210 = ((Convert.ToInt32(r29) + 1)).ToString();
            r211 = ((Convert.ToInt32(r210) + 1)).ToString();
            r212 = ((Convert.ToInt32(r211) + 1)).ToString();
        }

        if (r == "Sagittarius")
        {
            r21 = "9";
            r22 = ((Convert.ToInt32(r21) + 1)).ToString();
            r23 = ((Convert.ToInt32(r22) + 1)).ToString();
            r24 = ((Convert.ToInt32(r23) + 1)).ToString();
            r25 = ((Convert.ToInt32(r24) - 11)).ToString();
            r26 = ((Convert.ToInt32(r25) + 1)).ToString();
            r27 = ((Convert.ToInt32(r26) + 1)).ToString();
            r28 = ((Convert.ToInt32(r27) + 1)).ToString();
            r29 = ((Convert.ToInt32(r28) + 1)).ToString();
            r210 = ((Convert.ToInt32(r29) + 1)).ToString();
            r211 = ((Convert.ToInt32(r210) + 1)).ToString();
            r212 = ((Convert.ToInt32(r211) + 1)).ToString();
        }

        if (r == "Capricorn")
        {
            r21 = "10";
            r22 = ((Convert.ToInt32(r21) + 1)).ToString();
            r23 = ((Convert.ToInt32(r22) + 1)).ToString();
            r24 = ((Convert.ToInt32(r23) - 11)).ToString();
            r25 = ((Convert.ToInt32(r24) + 1)).ToString();
            r26 = ((Convert.ToInt32(r25) + 1)).ToString();
            r27 = ((Convert.ToInt32(r26) + 1)).ToString();
            r28 = ((Convert.ToInt32(r27) + 1)).ToString();
            r29 = ((Convert.ToInt32(r28) + 1)).ToString();
            r210 = ((Convert.ToInt32(r29) + 1)).ToString();
            r211 = ((Convert.ToInt32(r210) + 1)).ToString();
            r212 = ((Convert.ToInt32(r211) + 1)).ToString();
        }
        if (r == "Aquarius")
        {
            r21 = "11";
            r22 = ((Convert.ToInt32(r21) + 1)).ToString();
            r23 = ((Convert.ToInt32(r22) - 11)).ToString();
            r24 = ((Convert.ToInt32(r23) + 1)).ToString();
            r25 = ((Convert.ToInt32(r24) + 1)).ToString();
            r26 = ((Convert.ToInt32(r25) + 1)).ToString();
            r27 = ((Convert.ToInt32(r26) + 1)).ToString();
            r28 = ((Convert.ToInt32(r27) + 1)).ToString();
            r29 = ((Convert.ToInt32(r28) + 1)).ToString();
            r210 = ((Convert.ToInt32(r29) + 1)).ToString();
            r211 = ((Convert.ToInt32(r210) + 1)).ToString();
            r212 = ((Convert.ToInt32(r211) + 1)).ToString();

        }
        if (r == "Pisces")
        {
            r21 = "12";
            r22 = ((Convert.ToInt32(r21) - 11)).ToString();
            r23 = ((Convert.ToInt32(r22) + 1)).ToString();
            r24 = ((Convert.ToInt32(r23) + 1)).ToString();
            r25 = ((Convert.ToInt32(r24) + 1)).ToString();
            r26 = ((Convert.ToInt32(r25) + 1)).ToString();
            r27 = ((Convert.ToInt32(r26) + 1)).ToString();
            r28 = ((Convert.ToInt32(r27) + 1)).ToString();
            r29 = ((Convert.ToInt32(r28) + 1)).ToString();
            r210 = ((Convert.ToInt32(r29) + 1)).ToString();
            r211 = ((Convert.ToInt32(r210) + 1)).ToString();
            r212 = ((Convert.ToInt32(r211) + 1)).ToString();
        }

        p21 = h21;
        p22 = h22;
        p23 = h23;
        p24 = h24;
        p25 = h25;
        p26 = h26;
        p27 = h27;
        p28 = h28;
        p29 = h29;
        p210 = h210;
        p211 = h211;
        p212 = h212;

       

        string fontsize1 = "14px";
        if (FlagForPDF == "ForPage")
        {

            strCart.Append("<td style = \"width:500px; padding-left:10px;\">");
            strCart.Append("<div style = \"color:Black;font-size:14px;font-weight:bold;\"> " + HeaderValue + "</div >");
            strCart.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:340px;height:250px; \">");
            strCart.Append("<div style=\"position:absolute; top:11%;  left:36%;width:30%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"Fhou1\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p21 + "<span style='color:" + AscColor + ";font-size:" + fontsize1 + "';'>As</span></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:32%;  left:45%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id = \"FRashi1\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top: 3%;  left: 11%;width:30%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id = \"FHouse2\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p22 + "</span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:9%;  left: 21%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FRashi2\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:20%; left:2%;width:20%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FHouse3\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p23 + "</span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:12%; left:16%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FRashi3\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:45%; left:10%;width:30%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FHouse4\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p24 + "</span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:37%; left:40%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FRashi4\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:65%; left:0%;width:20%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FHouse5\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p25 + "</span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:61%; left:16%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id = \"FRashi5\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:87%; left:11%;width:30%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FHouse6\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p26 + "</span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:66%; left:21%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FRashi6\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:70%; left:36%;width:30%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FHouse7\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p27 + "</span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:42%; left:45%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FRashi7\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:81%; left:60%;width:30%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FHouse8\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p28 + "</span></span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FRashi8\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:64%; left:84%;width:15%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id = \"FHouse9\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p29 + "</span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:60%; left:75%;width:11%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id = \"FRashi9\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:43%; left:55%;width:30%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id = \"FHouse10\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p210 + "</span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:36%; left:50%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id = \"FRashi10\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id = \"FHouse11\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p211 + "</span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:12%; left:73%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id = \"FRashi11\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:3%; left:60%;width:30%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FHouse12\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p212 + "</span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:7%; left:70%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FRashi12\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("</div>");
            strCart.Append("</td>");
        }
        else
        {
            strCart.Append("<td style = \"width:500px; padding-left:10px;\">");
            strCart.Append("<div style = \"color:Black;font-size:15px;font-weight:bold;\"> " + HeaderValue + "</div >");
            strCart.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:300px;height:250px;margin-bottom: 60px; \">");
            strCart.Append("<div style=\"position:absolute; top:15%;  left:36%;width:30%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"Fhou1\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p21 + "<span style='color:" + AscColor + ";font-size:" + fontsize1 + "';'>As</span></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:38%;  left:45%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id = \"FRashi1\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top: 3%;  left: 11%;width:30%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id = \"FHouse2\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p22 + "</span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:12%;  left: 20%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FRashi2\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:20%; left:2%;width:20%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FHouse3\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p23 + "</span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:18%; left:16%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FRashi3\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:45%; left:10%;width:30%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FHouse4\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p24 + "</span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:42%; left:40%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FRashi4\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:65%; left:0%;width:20%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FHouse5\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p25 + "</span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:68%; left:16%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id = \"FRashi5\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:87%; left:11%;width:30%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FHouse6\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p26 + "</span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:72%; left:21%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FRashi6\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:70%; left:36%;width:30%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FHouse7\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p27 + "</span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:47%; left:45%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FRashi7\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:81%; left:60%;width:30%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FHouse8\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p28 + "</span></span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:70%; left:70%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FRashi8\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:67%; left:81%;width:15%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id = \"FHouse9\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p29 + "</span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:67%; left:72%;width:11%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id = \"FRashi9\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:43%; left:55%;width:30%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id = \"FHouse10\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p210 + "</span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:42%; left:50%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id = \"FRashi10\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id = \"FHouse11\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p211 + "</span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:18%; left:73%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id = \"FRashi11\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:3%; left:60%;width:30%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FHouse12\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p212 + "</span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("<div style=\"position:absolute; top:14%; left:70%;width:10%;\">");
            strCart.Append("<span>");
            strCart.Append("<span id =\"FRashi12\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
            strCart.Append("</span>");
            strCart.Append("</div>");
            strCart.Append("</div>");
            strCart.Append("</td>");
        }
        if (FlagForPDF == "ForPage")
        {
            if (Count == 3 || Count == 6 || Count == 9 || Count == 12 || Count == 15 || Count == 18)
            {
                strCart.Append("</tr>");
                if (Count == 12)
                {
                    strCart.Append("<tr><td><div style =\"page-break-before:always\">&nbsp;</div></td></tr>");
                }
                strCart.Append("<tr>");
            }
        }
        else
        {
          if (Count == 3 || Count == 6 || Count == 9 || Count == 12 || Count == 15 || Count == 18)
            {
               strCart.Append("</tr>");
               if (Count == 6)
                {
                     strCart.Append("<tr><td><div style =\"page-break-before:always\">&nbsp;</div></td></tr>");
                     strCart.Append("<tr>");
                     strCart.Append("<td colspan=8>");
                     strCart.Append("<div style =\"page-break-before:always\">&nbsp;</div>");
                     strCart.Append("<div style='float: left;padding:0em 0em 0.4em 0em;margin: 0em 0em 0em 0em;width: 100%;text-align: left;font-size: 1.3em;color: #007bff;font-weight: bold;border-bottom: 3px solid #007bff;'>" + Gender + "</div>");
                     strCart.Append("</td>");
                     strCart.Append("</tr>");
               }
            strCart.Append("<tr>");
          }
        }
        Count++;
    }
    #endregion

    #region Get Basic Details
    protected void BindBasicDeatis(string Flag)
    {
        FlagForPDF = "ForPage";
        StringBuilder strHtml = new StringBuilder();
        string BoysName = "", BoysGender = "", BoyDateOfBirth = "", BoyDateOFTime = "", BoyConstellation = "", BoyBirthPlace = "", BoyRashi = "", BoyLagnaRashi = "", GirlConstellation = "", GirlsName = "", GirlGender = "", GirlDateOfBirth = "",
            GirlDateOFtime = "", GirlsBirthPlace = "", GirlDayName = "", DayName = "", GirlRashi = "", GirlLagnaRashi = "", GirlLatitude = "", BoyLatitude = "", GirlLongitude = "", BoyLongitude = "", GirlTimeZone = "", BoyTimeZone = "", BoyBalanceDasha = "", GirlBalanceDasha = "", BoySunriseTime = "", GirlSunriseTime = "", BoySunsetTime = "", GirlSunsetTime = "";
        for (int i = 1; i <= 2; i++)
        {
            if (Flag == "ForPdf")
            {
                GirlId = hdnGirlID.Value;
                BoyId = hdnBoysID.Value;
            }
            string ClientID = GirlId;
            if (i == 1)
            {
                ClientID = BoyId;
            }
            DataSet dsd = new DataSet();
            dsd = objmc.Get_Clientdetails("", ClientID);
            if (dsd.Tables[0].Rows.Count > 0)
            {
                if (i == 1)
                {
                    BoysName = dsd.Tables[0].Rows[0]["CLIENT_NAME"].ToString();
                    BoysGender = dsd.Tables[0].Rows[0]["GENDER"].ToString();
                    string dob = dsd.Tables[0].Rows[0]["DOB"].ToString();

                    BoyDateOfBirth = DateTime.ParseExact(dob, "dd/MM/yyyy", null).ToString("dd-MMM-yyyy");
                    DayName = dsd.Tables[0].Rows[0]["DAYOB"].ToString();
                    BoyDateOFTime = dsd.Tables[0].Rows[0]["TOB"].ToString();
                    BoyBirthPlace = dsd.Tables[0].Rows[0]["CITY"].ToString() + ", " + dsd.Tables[0].Rows[0]["STATE"].ToString() + ", " + dsd.Tables[0].Rows[0]["COUNTRY"].ToString();
                    BoyConstellation = dsd.Tables[0].Rows[0]["CONSTELLATION"].ToString();
                    BoyRashi = dsd.Tables[0].Rows[0]["RASHI"].ToString();
                    BoyLagnaRashi = dsd.Tables[0].Rows[0]["LAGNARASHI"].ToString();
                    BoyLatitude = dsd.Tables[0].Rows[0]["LATITUDE"].ToString();
                    BoyLongitude = dsd.Tables[0].Rows[0]["LONGITUDE"].ToString();
                    BoyTimeZone = dsd.Tables[0].Rows[0]["TIMEZONE"].ToString();
                    string balancedashaval = dsd.Tables[0].Rows[0]["BALANCE_DASHA_TOB"].ToString();
                    balancedashaval = balancedashaval.Replace("Balance Of Dasha :", "");
                    BoyBalanceDasha = balancedashaval.Trim();

                    string sunrise = dsd.Tables[0].Rows[0]["SUN_RISE"].ToString();
                    DateTime srt = Convert.ToDateTime(sunrise);
                    sunrise = srt.ToString("dd/MM/yyyy hh:mm:ss tt");
                    sunrise = DateTime.ParseExact(sunrise, "dd/MM/yyyy hh:mm:ss tt", null).ToString("dd-MMM-yyyy , hh:mm:ss tt");
                    BoySunriseTime = sunrise.ToUpper();

                    string sunret = dsd.Tables[0].Rows[0]["SUN_SET"].ToString();
                    DateTime sst = Convert.ToDateTime(sunret);
                    sunret = sst.ToString("dd/MM/yyyy hh:mm:ss tt");
                    sunret = DateTime.ParseExact(sunret, "dd/MM/yyyy hh:mm:ss tt", null).ToString("dd-MMM-yyyy , hh:mm:ss tt");
                    BoySunsetTime = sunret.ToUpper();
                }
                else
                {
                    GirlsName = dsd.Tables[0].Rows[0]["CLIENT_NAME"].ToString();
                    GirlGender = dsd.Tables[0].Rows[0]["GENDER"].ToString();
                    string dob = dsd.Tables[0].Rows[0]["DOB"].ToString();
                    GirlDateOfBirth = DateTime.ParseExact(dob, "dd/MM/yyyy", null).ToString("dd-MMM-yyyy");
                    GirlDayName = dsd.Tables[0].Rows[0]["DAYOB"].ToString();
                    GirlDateOFtime = dsd.Tables[0].Rows[0]["TOB"].ToString();
                    GirlsBirthPlace = dsd.Tables[0].Rows[0]["CITY"].ToString() + ", " + dsd.Tables[0].Rows[0]["STATE"].ToString() + ", " + dsd.Tables[0].Rows[0]["COUNTRY"].ToString();
                    GirlConstellation = dsd.Tables[0].Rows[0]["CONSTELLATION"].ToString();
                    GirlRashi = dsd.Tables[0].Rows[0]["RASHI"].ToString();
                    GirlLagnaRashi = dsd.Tables[0].Rows[0]["LAGNARASHI"].ToString();
                    GirlLatitude = dsd.Tables[0].Rows[0]["LATITUDE"].ToString();
                    GirlLongitude = dsd.Tables[0].Rows[0]["LONGITUDE"].ToString();
                    GirlTimeZone = dsd.Tables[0].Rows[0]["TIMEZONE"].ToString();

                    string balancedashaval = dsd.Tables[0].Rows[0]["BALANCE_DASHA_TOB"].ToString();
                    balancedashaval = balancedashaval.Replace("Balance Of Dasha :", "");
                    GirlBalanceDasha = balancedashaval.Trim();

                    string sunrise = dsd.Tables[0].Rows[0]["SUN_RISE"].ToString();
                    DateTime srt = Convert.ToDateTime(sunrise);
                    sunrise = srt.ToString("dd/MM/yyyy hh:mm:ss tt");
                    sunrise = DateTime.ParseExact(sunrise, "dd/MM/yyyy hh:mm:ss tt", null).ToString("dd-MMM-yyyy , hh:mm:ss tt");
                    GirlSunriseTime = sunrise.ToUpper();

                    string sunret = dsd.Tables[0].Rows[0]["SUN_SET"].ToString();
                    DateTime sst = Convert.ToDateTime(sunret);
                    sunret = sst.ToString("dd/MM/yyyy hh:mm:ss tt");
                    sunret = DateTime.ParseExact(sunret, "dd/MM/yyyy hh:mm:ss tt", null).ToString("dd-MMM-yyyy , hh:mm:ss tt");
                    GirlSunsetTime = sunret.ToUpper();
                }
            }
        }


        strHtml.Append("<table style = \"width:100%;border-collapse: collapse;font-family: 'Roboto', sans-serif;font-size:15px;border:1px solid #d5d5d5;background:#fff;margin-bottom:.25cm;line-height: 15px;\">");
        strHtml.Append("<tr>");
        strHtml.Append("<th colspan=4 style = \"text-align:center;padding:.30cm;border-bottom:1px solid #d5d5d5;background-color: #fce9ce;\"><i class=\"fa fa-birthday-cake\" aria-hidden=\"true\"></i>&nbsp;Birth Details</th>");
        strHtml.Append("</tr>");

        strHtml.Append("<tr>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Boy Name:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + BoysName + "</td>");
        //strHtml.Append("<th style = \"background: #a09999;width:2px;\"></th>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Girl Name:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + GirlsName + "</td>");
        strHtml.Append("</tr>");


        strHtml.Append("<tr>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Gender:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + "Male" + "</td>");
        //strHtml.Append("<th style = \"background: #a09999;width:2px;\"></th>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Gender:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + "Female" + "</td>");
        strHtml.Append("</tr>");

        strHtml.Append("<tr>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Date of Birth:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + BoyDateOfBirth + " (" + DayName + ")" + "</td>");
        //strHtml.Append("<th style = \"background: #a09999;width:2px;\"></th>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Date of Birth:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + GirlDateOfBirth + " (" + GirlDayName + ")" + "</td>");
        strHtml.Append("</tr>");

        strHtml.Append("<tr>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Time of Birth:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + BoyDateOFTime + " (24 hrs)</td>");
        //strHtml.Append("<th style = \"background: #a09999;width:2px;\"></th>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Time of Birth:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + GirlDateOFtime + " (24 hrs)</td>");
        strHtml.Append("</tr>");

        strHtml.Append("<tr>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Birth Place:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + BoyBirthPlace + "</td>");
        //strHtml.Append("<th style = \"background: #a09999;width:2px;\"></th>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Birth Place:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + GirlsBirthPlace + "</td>");
        strHtml.Append("</tr>");

        strHtml.Append("<tr>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Latitude:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + BoyLatitude + "</td>");
        //strHtml.Append("<th style = \"background: #a09999;width:2px;\"></th>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Latitude:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + GirlLatitude + "</td>");
        strHtml.Append("</tr>");

        strHtml.Append("<tr>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Longitude:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + BoyLongitude + "</td>");
        //strHtml.Append("<th style = \"background: #a09999;width:2px;\"></th>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Longitude:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + GirlLongitude + "</td>");
        strHtml.Append("</tr>");


        strHtml.Append("<tr>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Time Zone:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + BoyTimeZone + "</td>");
        //strHtml.Append("<th style = \"background: #a09999;width:2px;\"></th>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Time Zone:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + GirlTimeZone + "</td>");
        strHtml.Append("</tr>");

        strHtml.Append("<tr>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Rashi:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + BoyRashi + "</td>");
        //strHtml.Append("<th style = \"background: #a09999;width:2px;\"></th>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Rashi:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + GirlRashi + "</td>");
        strHtml.Append("</tr>");

        strHtml.Append("<tr>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Lagna Rashi:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + BoyLagnaRashi + "</td>");
        //strHtml.Append("<th style = \"background: #a09999;width:2px;\"></th>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Lagna Rashi:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + GirlLagnaRashi + "</td>");
        strHtml.Append("</tr>");

        strHtml.Append("<tr>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Constellation:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + BoyConstellation + "</td>");
        //strHtml.Append("<th style = \"background: #a09999;width:2px;\"></th>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Constellation:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + GirlConstellation + "</td>");
        strHtml.Append("</tr>");

        strHtml.Append("<tr>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Balance Dasha:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + BoyBalanceDasha + "</td>");
        //strHtml.Append("<th style = \"background: #a09999;width:2px;\"></th>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Balance Dasha:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + GirlBalanceDasha + "</td>");
        strHtml.Append("</tr>");

        strHtml.Append("<tr>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Sunrise Time:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + BoySunriseTime + "</td>");
        //strHtml.Append("<th style = \"background: #a09999;width:2px;\"></th>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Sunrise Time:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + GirlSunriseTime + "</td>");
        strHtml.Append("</tr>");

        strHtml.Append("<tr>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Sunset Time:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + BoySunsetTime + "</td>");
        //strHtml.Append("<th style = \"background: #a09999;width:2px;\"></th>");
        strHtml.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Sunset Time:</th>");
        strHtml.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + GirlSunsetTime + "</td>");
        strHtml.Append("</tr>");

        strHtml.Append("</table>");

        if (Flag == "ForPdf")
        {
            strData.Append(strHtml.ToString());
        }
        bindDetails.InnerHtml = strHtml.ToString();
    }
    #endregion

    #region Generate PDF Code
    protected void lnkGeneratePDF_Click(object sender, EventArgs e)
    {
        FlagForPDF = "Yes";
        DataSet ds = new DataSet();
        ds = cm.GetAshthakootNadiMatch(hdnBoysID.Value, hdnGirlID.Value, "GET_MATCHING_REPORT");

        StringBuilder TBL = new StringBuilder();
        TBL.Append("<div style=\"width:100%; margin:0 auto; text-align:center;margin: 0em 0em 1em 0em;\">");
        TBL.Append("<img src=\"" + WEBSITEDomainVal + "/Image/large_logo.svg\" alt=\"Astro Envision\" title=\"Astro Envision\" />");
        TBL.Append("</div>");
        TBL.Append("<div style='padding:0em 0em 0em 0em;margin: 0em 0em 0.4em 0em;height: 40px;vertical-align: top;width: 100%;text-align: center;font-size: 1.4em;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;'><img style='width: 35px;' src=\"" + WEBSITEDomainVal + "/Image/om_small.png\" alt=\"Astro Envision\" title=\"Astro Envision\" />&nbsp;Kundli Compatibility Matching Report&nbsp;<img style='width: 35px;' src=\"" + WEBSITEDomainVal + "/Image/om_small.png\" alt=\"Astro Envision\" title=\"Astro Envision\" /></div>");
        BindBasicDeatis("ForPdf");
        TBL.Append(strData.ToString());
        TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0.88em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Birth Chart</div>");
        for (int jx = 0; jx <= 1; jx++)
        {
           
               Houes1Value = 0; Houes2Value = 0; Houes3Value = 0; Houes4Value = 0; Houes5Value = 0; Houes6Value = 0; Houes7Value = 0; Houes8Value = 0; Houes9Value = 0; Houes10Value = 0; Houes11Value = 0; Houes12Value = 0;
            string GetDetails = ds.Tables[jx].Rows[0]["HOROSCOPE_D01"].ToString();
            string j10 = "", h10 = "", j1 = "", h1 = "", RashiID0 = "", RashiID1 = "", j2 = "", h2 = "", RashiID2 = "", RashiID3 = "", RashiID4 = "", RashiID5 = "", Name = "",
            RashiID6 = "", RashiID7 = "", RashiID8 = "", RashiID9 = "", RashiID10 = "", RashiID11 = "", RashiID12 = "", j3 = "", j4 = "", j5 = "", j6 = "", j7 = "", j8 = "", j9 = "", j11 = "", j12 = "", h3 = "", h4 = "", h5 = "", h6 = "", h7 = "", h8 = "", h9 = "", h11 = "", h12 = "";
            if (jx == 0)
            {
                Gender = "Boy Chart";
                Name = ds.Tables[jx].Rows[0]["BOY_NAME"].ToString();
            }
            else
            {
                Gender = "Girl Chart";
                Name = ds.Tables[jx].Rows[0]["GIRL_NAME"].ToString();
            }

            List<string> lstPlanets = new List<string>();
            List<string> lstRashi = new List<string>();
            List<string> lstHouse = new List<string>();
            List<string> lstDegree = new List<string>();
            List<string> lstMintues = new List<string>();
            List<string> lstRetro = new List<string>();
            List<string> lstSecond = new List<string>();
            List<string> lstconstelation = new List<string>();



            #region Bind Birth Chart
            //string ChartImagePath = System.Configuration.ConfigurationManager.AppSettings["ChartImagePath"];
            TBL.Append("<div style=\"float: left; width:50%;\">");
            TBL.Append("<table style = \"width:100%;border-collapse: collapse;font-family: 'Roboto', sans-serif;font-size:13px;margin-bottom:.65cm;-webkit-print-color-adjust: exact;\">");
            TBL.Append("<tr>");
            TBL.Append("<td colspan = \"2\" style = \"padding:0px 0px 0px 20px;vertical-align:top;width:500px;\">");
            TBL.Append("<div style = \"font-size: 20px;font-weight:bold;color:#f25e0a;text-align: center;\" >" + Name + "'s Chart" + "</div>");
            TBL.Append("</td>");
            TBL.Append("</tr>");
            TBL.Append("<tr>");
            string vargasfinal = "", birth = "0" , retro="";
            string[] ar = GetDetails.Split('~');
            for (int j = 0; j < ar.Length - 1; j++)
            {
                string Value = ar[j];
                string[] SplitValue = Value.Split('/');

                lstPlanets.Add(SplitValue[0]);
                lstRashi.Add(SplitValue[1]);
                lstHouse.Add(SplitValue[2]);
                string val = SplitValue[3];
                string[] TimeVal = val.Split('.');
                lstDegree.Add(TimeVal[0]);
                lstMintues.Add(TimeVal[1]);
                lstSecond.Add(TimeVal[2]);
                lstconstelation.Add(SplitValue[5]);

                string GetRetro = SplitValue[4];
                if (GetRetro == "R")
                {
                    retro = "R";
                      lstRetro.Add("R");
                }
                else
                {
                    retro = "B";
                    lstRetro.Add("B");
                }
                string DegreeVal = lstDegree[j] + "." + lstMintues[j] + "." + lstSecond[j];

                vargasfinal = vargasfinal + lstPlanets[j] + "~" + lstRashi[j] + "~" + lstHouse[j] + "~" + birth + "~" + retro + "~" + DegreeVal + "~" + lstconstelation[j] + "$";
            }
            vargasfinal = vargasfinal.Substring(0, vargasfinal.Length - 1);
            DataSet DsDm = new DataSet();
            DsDm = country.vargas(vargasfinal);


            if (DsDm.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DsDm.Tables[0].Rows.Count; ++i)
                {
                    lstPlanetRashiId.Add(DsDm.Tables[0].Rows[i]["PLANET"].ToString());
                    D1lstHouse1.Add(DsDm.Tables[0].Rows[i]["D1_HOUSE"].ToString());
                    D1Rashi.Add(DsDm.Tables[0].Rows[i]["D1_RASHI"].ToString());
                    D1BirthTime.Add(DsDm.Tables[0].Rows[i]["BIRTH_TIME"].ToString());
                    D1Retro.Add(DsDm.Tables[0].Rows[i]["RETRO"].ToString());
                    D1Degree.Add(DsDm.Tables[0].Rows[i]["DEGREE"].ToString());
                    D2lstHouse1.Add(DsDm.Tables[0].Rows[i]["D2_HOUSE"].ToString());
                    D2Rashi.Add(DsDm.Tables[0].Rows[i]["D2_RASHI"].ToString());
                    D4lstHouse1.Add(DsDm.Tables[0].Rows[i]["D4_HOUSE"].ToString());
                    D4Rashi.Add(DsDm.Tables[0].Rows[i]["D4_RASHI"].ToString());
                    D9lstHouse1.Add(DsDm.Tables[0].Rows[i]["D9_HOUSE"].ToString());
                    D9Rashi.Add(DsDm.Tables[0].Rows[i]["D9_RASHI"].ToString());
                    D10lstHouse1.Add(DsDm.Tables[0].Rows[i]["D10_HOUSE"].ToString());
                    D10Rashi.Add(DsDm.Tables[0].Rows[i]["D10_RASHI"].ToString());
                    D24lstHouse1.Add(DsDm.Tables[0].Rows[i]["D24_HOUSE"].ToString());
                    D24Rashi.Add(DsDm.Tables[0].Rows[i]["D24_RASHI"].ToString());
                    D60lstHouse1.Add(DsDm.Tables[0].Rows[i]["D60_HOUSE"].ToString());
                    D60Rashi.Add(DsDm.Tables[0].Rows[i]["D60_RASHI"].ToString());
                    D03lstHouse1.Add(DsDm.Tables[0].Rows[i]["D3_HOUSE"].ToString());
                    D03Rashi.Add(DsDm.Tables[0].Rows[i]["D3_RASHI"].ToString());
                    D07lstHouse1.Add(DsDm.Tables[0].Rows[i]["D7_HOUSE"].ToString());
                    D07Rashi.Add(DsDm.Tables[0].Rows[i]["D7_RASHI"].ToString());
                    D12lstHouse1.Add(DsDm.Tables[0].Rows[i]["D12_HOUSE"].ToString());
                    D12Rashi.Add(DsDm.Tables[0].Rows[i]["D12_RASHI"].ToString());
                    D16lstHouse1.Add(DsDm.Tables[0].Rows[i]["D16_HOUSE"].ToString());
                    D16Rashi.Add(DsDm.Tables[0].Rows[i]["D16_RASHI"].ToString());
                    D30lstHouse1.Add(DsDm.Tables[0].Rows[i]["D30_HOUSE"].ToString());
                    D30Rashi.Add(DsDm.Tables[0].Rows[i]["D30_RASHI"].ToString());
                    D45lstHouse1.Add(DsDm.Tables[0].Rows[i]["D45_HOUSE"].ToString());
                    D45Rashi.Add(DsDm.Tables[0].Rows[i]["D45_RASHI"].ToString());
                    D20lstHouse1.Add(DsDm.Tables[0].Rows[i]["D20_HOUSE"].ToString());
                    D20Rashi.Add(DsDm.Tables[0].Rows[i]["D20_RASHI"].ToString());
                    D27lstHouse1.Add(DsDm.Tables[0].Rows[i]["D27_HOUSE"].ToString());
                    D27Rashi.Add(DsDm.Tables[0].Rows[i]["D27_RASHI"].ToString());
                    D40lstHouse1.Add(DsDm.Tables[0].Rows[i]["D40_HOUSE"].ToString());
                    D40Rashi.Add(DsDm.Tables[0].Rows[i]["D40_RASHI"].ToString());
                    D05lstHouse1.Add(DsDm.Tables[0].Rows[i]["D5_HOUSE"].ToString());
                    D05Rashi.Add(DsDm.Tables[0].Rows[i]["D5_RASHI"].ToString());
                    D06lstHouse1.Add(DsDm.Tables[0].Rows[i]["D6_HOUSE"].ToString());
                    D06Rashi.Add(DsDm.Tables[0].Rows[i]["D6_RASHI"].ToString());
                    D08lstHouse1.Add(DsDm.Tables[0].Rows[i]["D8_HOUSE"].ToString());
                    D08Rashi.Add(DsDm.Tables[0].Rows[i]["D8_RASHI"].ToString());
                    D11lstHouse1.Add(DsDm.Tables[0].Rows[i]["D11_HOUSE"].ToString());
                    D11Rashi.Add(DsDm.Tables[0].Rows[i]["D11_RASHI"].ToString());
                    DKLlstHouse1.Add(DsDm.Tables[0].Rows[i]["KARAKAMSHA_HOUSE"].ToString());
                    DKLRashi.Add(DsDm.Tables[0].Rows[i]["KARAKAMSHA_RASHI"].ToString());
                    DMoonlstHouse1.Add(DsDm.Tables[0].Rows[i]["MOON_HOUSE"].ToString());
                    DMoonRashi.Add(DsDm.Tables[0].Rows[i]["MOON_RASHI"].ToString());
                    DVenuslstHouse1.Add(DsDm.Tables[0].Rows[i]["VENUS_HOUSE"].ToString());
                    DVenusRashi.Add(DsDm.Tables[0].Rows[i]["VENUS_RASHI"].ToString());
                }
            }
            DsDm.Dispose();
            #region For Loop For Birth Chart
            for (int i = 0; i <= 10; i++)
            {
                string h = lstHouse[i];
                RashiID0 = lstRashi[0];

                string Retro = lstRetro[i];
                if (Retro == "B")
                {
                    Retro = "";
                }
                string Padding = "0px;";
                if (Retro != "")
                {
                    Padding = "2px;";
                }
                if (RashiID0 == "Aries")
                {
                    RashiID1 = "1";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = (Convert.ToInt32(RashiID8) + 1).ToString();
                    RashiID10 = (Convert.ToInt32(RashiID9) + 1).ToString();
                    RashiID11 = (Convert.ToInt32(RashiID10) + 1).ToString();
                    RashiID12 = (Convert.ToInt32(RashiID11) + 1).ToString();

                }
                if (RashiID0 == "Taurus")
                {
                    RashiID1 = "2";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = (Convert.ToInt32(RashiID8) + 1).ToString();
                    RashiID10 = (Convert.ToInt32(RashiID9) + 1).ToString();
                    RashiID11 = (Convert.ToInt32(RashiID10) + 1).ToString();
                    RashiID12 = "1";
                }

                if (RashiID0 == "Gemini")
                {
                    RashiID1 = "3";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = (Convert.ToInt32(RashiID8) + 1).ToString();
                    RashiID10 = (Convert.ToInt32(RashiID9) + 1).ToString();
                    RashiID11 = "1";
                    RashiID12 = "2";
                }

                if (RashiID0 == "Cancer")
                {
                    RashiID1 = "4";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = (Convert.ToInt32(RashiID8) + 1).ToString();
                    RashiID10 = "1";
                    RashiID11 = "2";
                    RashiID12 = "3";
                }
                if (RashiID0 == "Leo")
                {
                    RashiID1 = "5";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = "1";
                    RashiID10 = "2";
                    RashiID11 = "3";
                    RashiID12 = "4";
                }
                if (RashiID0 == "Virgo")
                {
                    RashiID1 = "6";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = "1";
                    RashiID9 = "2";
                    RashiID10 = "3";
                    RashiID11 = "4";
                    RashiID12 = "5";
                }

                if (RashiID0 == "Libra")
                {
                    RashiID1 = "7";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) - 11).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = (Convert.ToInt32(RashiID8) + 1).ToString();
                    RashiID10 = (Convert.ToInt32(RashiID9) + 1).ToString();
                    RashiID11 = (Convert.ToInt32(RashiID10) + 1).ToString();
                    RashiID12 = (Convert.ToInt32(RashiID11) + 1).ToString();
                }

                if (RashiID0 == "Scorpio")
                {
                    RashiID1 = "8";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) - 11).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = (Convert.ToInt32(RashiID8) + 1).ToString();
                    RashiID10 = (Convert.ToInt32(RashiID9) + 1).ToString();
                    RashiID11 = (Convert.ToInt32(RashiID10) + 1).ToString();
                    RashiID12 = (Convert.ToInt32(RashiID11) + 1).ToString();
                }

                if (RashiID0 == "Sagittarius")
                {
                    RashiID1 = "9";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) - 11).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = (Convert.ToInt32(RashiID8) + 1).ToString();
                    RashiID10 = (Convert.ToInt32(RashiID9) + 1).ToString();
                    RashiID11 = (Convert.ToInt32(RashiID10) + 1).ToString();
                    RashiID12 = (Convert.ToInt32(RashiID11) + 1).ToString();
                }

                if (RashiID0 == "Capricorn")
                {
                    RashiID1 = "10";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) - 11).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = (Convert.ToInt32(RashiID8) + 1).ToString();
                    RashiID10 = (Convert.ToInt32(RashiID9) + 1).ToString();
                    RashiID11 = (Convert.ToInt32(RashiID10) + 1).ToString();
                    RashiID12 = (Convert.ToInt32(RashiID11) + 1).ToString();
                }

                if (RashiID0 == "Aquarius")
                {
                    RashiID1 = "11";
                    RashiID2 = (Convert.ToInt32(RashiID1) + 1).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) - 11).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = (Convert.ToInt32(RashiID8) + 1).ToString();
                    RashiID10 = (Convert.ToInt32(RashiID9) + 1).ToString();
                    RashiID11 = (Convert.ToInt32(RashiID10) + 1).ToString();
                    RashiID12 = (Convert.ToInt32(RashiID11) + 1).ToString();
                }
                if (RashiID0 == "Pisces")
                {
                    RashiID1 = "12";
                    RashiID2 = (Convert.ToInt32(RashiID1) - 11).ToString();
                    RashiID3 = (Convert.ToInt32(RashiID2) + 1).ToString();
                    RashiID4 = (Convert.ToInt32(RashiID3) + 1).ToString();
                    RashiID5 = (Convert.ToInt32(RashiID4) + 1).ToString();
                    RashiID6 = (Convert.ToInt32(RashiID5) + 1).ToString();
                    RashiID7 = (Convert.ToInt32(RashiID6) + 1).ToString();
                    RashiID8 = (Convert.ToInt32(RashiID7) + 1).ToString();
                    RashiID9 = (Convert.ToInt32(RashiID8) + 1).ToString();
                    RashiID10 = (Convert.ToInt32(RashiID9) + 1).ToString();
                    RashiID11 = (Convert.ToInt32(RashiID10) + 1).ToString();
                    RashiID12 = (Convert.ToInt32(RashiID11) + 1).ToString();
                }
                if (h == "HOUSE1")
                {
                    Houes1Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j1 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "JUPITER")
                    {
                        j1 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "VENUS")
                    {
                        j1 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SATURN")
                    {
                        j1 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SUN")
                    {
                        j1 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MOON")
                    {
                        j1 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MARS")
                    {
                        j1 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "RAHU")
                    {
                        j1 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j1 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "GULIKA")
                    {
                        j1 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    h1 = h1 + j1 + " ";
                }

                if (h == "HOUSE2")
                {

                    Houes2Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j2 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "JUPITER")
                    {
                        j2 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "VENUS")
                    {
                        j2 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SATURN")
                    {
                        j2 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SUN")
                    {
                        j2 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MOON")
                    {
                        j2 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MARS")
                    {
                        j2 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "RAHU")
                    {
                        j2 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j2 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "GULIKA")
                    {
                        j2 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    h2 = h2 + j2 + " ";
                }

                if (h == "HOUSE3")
                {
                    Houes3Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j3 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "JUPITER")
                    {
                        j3 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "VENUS")
                    {
                        j3 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SATURN")
                    {
                        j3 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left:" + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SUN")
                    {
                        j3 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MOON")
                    {
                        j3 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MARS")
                    {
                        j3 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left:" + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "RAHU")
                    {
                        j3 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j3 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "GULIKA")
                    {
                        j3 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    h3 = h3 + j3 + " ";
                }

                if (h == "HOUSE4")
                {
                    Houes4Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j4 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "JUPITER")
                    {
                        j4 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "VENUS")
                    {
                        j4 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SATURN")
                    {
                        j4 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SUN")
                    {
                        j4 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MOON")
                    {
                        j4 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MARS")
                    {
                        j4 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "RAHU")
                    {
                        j4 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j4 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "GULIKA")
                    {
                        j4 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    h4 = h4 + j4 + " ";
                }


                if (h == "HOUSE5")
                {
                    Houes5Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j5 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "JUPITER")
                    {
                        j5 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "VENUS")
                    {
                        j5 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SATURN")
                    {
                        j5 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SUN")
                    {
                        j5 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MOON")
                    {
                        j5 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MARS")
                    {
                        j5 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "RAHU")
                    {
                        j5 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j5 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "GULIKA")
                    {
                        j5 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    h5 = h5 + j5 + " ";
                }

                if (h == "HOUSE6")
                {
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j6 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:#F4600A; font-size:12px;font-weight: bold;\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:#F4600A; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }
                    if (lstPlanets[i] == "JUPITER")
                    {
                        j6 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:#F4600A; font-size:12px;font-weight: bold;\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:#F4600A; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }

                    if (lstPlanets[i] == "VENUS")
                    {
                        j6 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:#F4600A; font-size:12px;font-weight: bold;\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:#F4600A; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }

                    if (lstPlanets[i] == "SATURN")
                    {
                        j6 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:#F4600A; font-size:12px;font-weight: bold;\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:#F4600A; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }

                    if (lstPlanets[i] == "SUN")
                    {
                        j6 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:#F4600A; font-size:12px;font-weight: bold;\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:#F4600A; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }

                    if (lstPlanets[i] == "MOON")
                    {
                        j6 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:#F4600A; font-size:12px;font-weight: bold;\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:#F4600A; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }

                    if (lstPlanets[i] == "MARS")
                    {
                        j6 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:#F4600A; font-size:12px;font-weight: bold;\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:#F4600A; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }

                    if (lstPlanets[i] == "RAHU")
                    {
                        j6 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:#F4600A; font-size:12px;font-weight: bold;\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:#F4600A; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j6 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:#F4600A; font-size:12px;font-weight: bold;\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:#F4600A; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }

                    if (lstPlanets[i] == "GULIKA")
                    {
                        j6 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:#F4600A; font-size:12px;font-weight: bold;\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:#F4600A; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }
                    h6 = h6 + j6 + " ";
                }

                if (h == "HOUSE7")
                {
                    Houes7Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j7 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "JUPITER")
                    {
                        j7 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "VENUS")
                    {
                        j7 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SATURN")
                    {
                        j7 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SUN")
                    {
                        j7 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MOON")
                    {
                        j7 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MARS")
                    {
                        j7 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "RAHU")
                    {
                        j7 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j7 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "GULIKA")
                    {
                        j7 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }
                    h7 = h7 + j7 + " ";
                }
                if (h == "HOUSE8")
                {
                    Houes8Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j8 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "JUPITER")
                    {
                        j8 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "VENUS")
                    {
                        j8 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SATURN")
                    {
                        j8 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SUN")
                    {
                        j8 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MOON")
                    {
                        j8 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MARS")
                    {
                        j8 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "RAHU")
                    {
                        j8 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j8 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "GULIKA")
                    {
                        j8 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    h8 = h8 + j8 + " ";
                }

                if (h == "HOUSE9")
                {
                    Houes9Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j9 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "JUPITER")
                    {
                        j9 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "VENUS")
                    {
                        j9 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SATURN")
                    {
                        j9 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SUN")
                    {
                        j9 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MOON")
                    {
                        j9 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MARS")
                    {
                        j9 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "RAHU")
                    {
                        j9 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j9 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "GULIKA")
                    {
                        j9 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    h9 = h9 + j9 + " ";
                }


                if (h == "HOUSE10")
                {
                    Houes10Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j10 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "JUPITER")
                    {
                        j10 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "VENUS")
                    {
                        j10 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "SATURN")
                    {
                        j10 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "SUN")
                    {
                        j10 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "MOON")
                    {
                        j10 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "MARS")
                    {
                        j10 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "RAHU")
                    {
                        j10 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j10 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "GULIKA")
                    {
                        j10 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    h10 = h10 + j10 + " ";
                }
                if (h == "HOUSE11")
                {
                    Houes11Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j11 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "JUPITER")
                    {
                        j11 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "VENUS")
                    {
                        j11 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "SATURN")
                    {
                        j11 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "SUN")
                    {
                        j11 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "MOON")
                    {
                        j11 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "MARS")
                    {
                        j11 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "RAHU")
                    {
                        j11 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j11 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "GULIKA")
                    {
                        j11 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    h11 = h11 + j11 + " ";
                }
                if (h == "HOUSE12")
                {
                    Houes12Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j12 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "JUPITER")
                    {
                        j12 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "VENUS")
                    {
                        j12 = "<span style='color:" + VeColor + "'>Ve</span>" + " <span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "SATURN")
                    {
                        j12 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "SUN")
                    {
                        j12 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "MOON")
                    {
                        j12 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "MARS")
                    {
                        j12 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "RAHU")
                    {
                        j12 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j12 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "GULIKA")
                    {
                        j12 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    h12 = h12 + j12 + " ";
                }
            }
            #endregion

            TBL.Append("<td colspan = \"2\" style = \"padding:.0cm;vertical-align:top;width:450px;\">");
            TBL.Append("<div style = \"background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:400px;height: 400px;\">");
            string Top1 = "20%;";
            string fontsize1 = "18px;";
            if (Houes1Value > 3)
            {
                Top1 = "11%;";
            }
            if (Houes1Value >= 5)
            {
                fontsize1 = "14px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top1 + " left:44%;width:30%;\">");
            TBL.Append("<span>");
            string Ret = "";
            if (lstRetro[0] == "R")
            {
                Ret = "R";
            }
            /******* House 1 *******/
            TBL.Append("<span id = \"DetailsHouese1\" style = \"text-align:left; color:#403E3E; font-weight: bold;\"><span style='color:" + AscColor + ";font-size:" + fontsize1 + "'>As</span><span style =\"text-align:left; color:black; font-size:12px;font-weight: bold;\"> " + Ret + "</span><span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[0] + "</span><span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">." + lstMintues[0] + "</span><br/> " + h1 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:40%;  left:49.5%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"DetailsHouese1Rashi\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID1 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");

            /******* House 2 *******/
            string Top2 = "3%;";
            string Left = "14%;";
            string fontsize2 = "18px;";
            string LineHeight2 = "";
            if (Houes2Value > 3)
            {
                Top2 = "0%;";
                Left = "20%;";
            }
            if (Houes2Value >= 5)
            {
                fontsize2 = "12px;";
                LineHeight2 = "line-height:15px;";
            }
            TBL.Append("<div style=\"position:absolute; top: " + Top2 + " left: " + Left + "width:30%;" + LineHeight2 + "\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"DetailsHouese2\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize2 + "font-weight: bold;\">" + h2 + " </span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top: 16%;  left: 24%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"DetailsHouese2Rashi\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID2 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");


            /******* House 3 *******/
            string Top3 = "20%;";
            string fontsize3 = "18px;";
            if (Houes3Value > 3)
            {
                Top3 = "11%;";
            }
            if (Houes3Value >= 5)
            {
                fontsize3 = "14px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top3 + " left:2%;width:15%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"DetailsHouese3\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize3 + " font-weight: bold;\">" + h3 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:21%; left:21%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"DetailsHouese3Rashi\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID3 + "</span><br></span></span>");
            TBL.Append("</div>");

            /******* House 4 *******/
            string Top4 = "42%;";
            string left = "15%;";
            string fontsize4 = "18px;";
            if (Houes4Value > 3)
            {
                Top4 = "37%;";
                left = " 18%;";
            }
            if (Houes4Value > 5)
            {
                fontsize4 = "12px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top4 + " left:" + left + "width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"DetailsHouese4\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize4 + "font-weight: bold;\">" + h4 + " </span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:45%; left:45%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"DetailsHouese4Rashi\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID4 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");


            /******* House 5*******/
            string Top5 = "70%;";
            string fontsize5 = "18px;";
            if (Houes5Value > 3)
            {
                Top5 = "59%;";
            }
            if (Houes5Value >= 5)
            {
                fontsize5 = "14px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top5 + " left:2%;width:20%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"DetailsHouese5\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize5 + "font-weight: bold;\">" + h5 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:70%; left:20.5%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"DetailsHouese5Rashi\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID5 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");


            /******* House 6*******/
            string Top6 = "87%;";
            string Left6 = "14%;";
            string fontsize6 = "18px;";
            string LineHeight6 = "";
            if (Houes6Value >= 3)
            {
                Top6 = "81%;";
                Left6 = "20%;";
            }
            if (Houes6Value >= 4)
            {
                fontsize6 = "12px;";
                LineHeight6 = "line-height:15px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top6 + " left:" + Left6 + "width:30%;" + LineHeight6 + "\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"DetailsHouese6\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize6 + ";font-weight: bold;\"> " + h6 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:73%; left:25%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"DetailsHouese6Rashi\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID6 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");

            /******* House 7*******/
            string Top7 = "70%;";
            string fontsize7 = "18px;";
            if (Houes7Value > 3)
            {
                Top7 = "60%;";
            }
            if (Houes7Value > 5)
            {
                fontsize7 = "14px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top7 + "left:45%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"1hasd7l1\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize7 + "font-weight: bold;\">" + h7 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:49%; left:49%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"1hsad7r\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID7 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");


            /******* House 8*******/
            string Top8 = "82%;";
            string RashiTop8 = "73%;";
            string Left8 = "70%;";
            string LineHeight8 = "";
            string fontsize8 = "18px;";
            if (Houes8Value > 3)
            {
                Top8 = "78%;";
                Left8 = "70%;";
                LineHeight8 = "line-height:15px;";
                RashiTop8 = "68%;";
            }
            if (Houes8Value >= 3)
            {
                fontsize8 = "12px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top8 + " left:" + Left8 + "width:30%;" + LineHeight8 + "\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"ads\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize8 + "font-weight: bold;\">" + h8 + "</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:" + RashiTop8 + " left:74%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"1asdh8r\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID8 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            /******* House 9*******/
            string Top9 = "67%;";
            string fontsize9 = "18px;";
            string LineHeight9 = "";
            if (Houes9Value > 5)
            {
                Top9 = "62%;";

            }
            if (Houes9Value > 5)
            {
                LineHeight9 = "line-height:15px;";
                fontsize9 = "12px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top9 + " left:85%;width:15%;" + LineHeight9 + "\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"1h9l1\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize9 + ";font-weight: bold;\">" + h9 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:70%; left:79%;width:11%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"1adh9r\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID9 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");

            /******* House 10******/
            string Top10 = "45%;";
            string fontsize10 = "18px;";

            if (Houes10Value >= 5)
            {
                Top10 = "36%;";
            }
            if (Houes10Value > 5)
            {
                fontsize10 = "12px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top10 + "; left:67%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"1h10l1\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize10 + "font-weight: bold;\">" + h10 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:45%; left:54%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"h10ForRashi\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight:bold;\">" + RashiID10 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");

            /******* House 11******/
            string Top11 = "20%;";
            string fontsize11 = "16px;";
            string LineHeight11 = "";
            if (Houes11Value > 3)
            {
                Top11 = "15%;";
            }
            if (Houes11Value >= 5)
            {
                LineHeight11 = "line-height:15px;";
                fontsize11 = "12px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top11 + " left:84%;width:22%;" + LineHeight11 + "\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"h10FDegPln\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize11 + "font-weight: bold;\">" + h11 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:21%; left:77%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"1h11r\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID11 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            /******* House 12******/
            string Top12 = "3%;";
            string RashiTop12 = "16%;";
            string fontsize12 = "16px;";
            string LineHeight12 = "";
            if (Houes12Value > 3)
            {
                Top12 = "0%;";
                RashiTop12 = "15%;";
            }
            if (Houes12Value >= 5)
            {
                fontsize12 = "14px;";
                LineHeight12 = "line-height:15px;";
            }
            TBL.Append("<div style=\"position:absolute; top:" + Top12 + "; left:69%;width:30%;" + LineHeight12 + "\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"1h12l1\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize12 + "font-weight: bold;\">" + h12 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:" + RashiTop12 + " left:73%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"1h12r\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID12 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("</div>");

            TBL.Append("</td>");
            TBL.Append("</tr>");
            TBL.Append("</table>");

            TBL.Append("</div>");

            FlagForPDF = "ForPDF";
            ShowChart("D02");
            ShowChart("D05");
            ShowChart("D06");
            ShowChart("D09");
            ShowChart("D10");
            ShowChart("D12");
            #region Bind Other Chart

            if(jx==1)
            {

                    TBL.Append("<div style =\"page-break-before:always\"> &nbsp;</div>");
                    TBL.Append("<span>");
                    TBL.Append("<table style = \"width:100%;border-collapse: collapse;font-family: 'Roboto', sans-serif;font-size:15px;margin-bottom:.25cm;-webkit-print-color-adjust: exact;\" >");
                    TBL.Append("<div style='float: left;padding:0em 0em 0.4em 0em;margin: 0em 0em 0em 0em;width: 100%;text-align: left;font-size: 1.3em;color: #007bff;font-weight: bold;border-bottom: 3px solid #007bff;'> Other Chart</div>");
                    TBL.Append("<div style='float: left;padding:0em 0em 0.4em 0em;margin: 0em 0em 0em 0em;width: 100%;text-align: left;font-size: 1.3em;color: #007bff;font-weight: bold;border-bottom: 3px solid #007bff;'>" + Gender  +"</div>");
                    TBL.Append("<tr>");
                    TBL.Append("<td colspan = \"2\" style = \"text-align:left;padding:.30cm 0; \">");
                    TBL.Append("</td>");
                    TBL.Append("</tr>");
                    TBL.Append("<tr>");
                    TBL.Append(strCart.ToString());
                    TBL.Append("</tr>");
                    TBL.Append("</tr>");
                    TBL.Append("</table>");
            }
            #endregion
        }
        TBL.Append("<div style =\"page-break-before:always\"> &nbsp;</div>");
        TBL.Append("<div style=\"float:left; width: 100%;\">");
        TBL.Append("<table style = \"width:100%;border-collapse: collapse;font-family: 'Roboto', sans-serif;font-size:15px;margin-bottom:.45cm;-webkit-print-color-adjust: exact;\">");
        TBL.Append("<tr>");
        TBL.Append("<td colspan = \"2\" style = \"text-align:left;padding:.30cm 0;\">");
        TBL.Append("<div style='font-size: 1.4em;float: left;padding:0em 0em 0.4em 0em;margin: 0em 0em 0em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;'>Ashtakoot Guna Matching Status</div>");
        TBL.Append("</td>");
        TBL.Append("</tr>");
        TBL.Append("<tr>");
        TBL.Append("<td colspan = \"2\" style = \"vertical-align:top; \">");
        TBL.Append("<table style = \"width:100%;border-collapse: collapse;border:1px solid #d5d5d5;line-height: 30px;\">");
        TBL.Append("<tr>");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\"> S.No </td>");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Koot Name </td>");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Girl Koot </td>");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Boy Koot </td> ");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Maximum Gunas </td> ");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Matched Gunas </td> ");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Dosha Status </td> ");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;border-right:1px solid #d5d5d5;color:#fff;-webkit-print-color-adjust: exact;\" > Exception Match </th> ");
        TBL.Append("</tr>");
        DataTable dtCurrentTable = (DataTable)ViewState["dtForPdf"];
        int count = dtCurrentTable.Rows.Count;
        for (int j = 0; j < count; j++)
        {
            TBL.Append("<tr>");
            TBL.Append("<td style = \"padding:.1cm .2cm;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + dtCurrentTable.Rows[j]["SNo"].ToString() + " </td>");
            TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + dtCurrentTable.Rows[j]["KootName"].ToString() + " </td>");
            TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + dtCurrentTable.Rows[j]["GirlKootName"].ToString() + " </td>");
            TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + dtCurrentTable.Rows[j]["BoyKootName"].ToString() + "</td>");
            TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + dtCurrentTable.Rows[j]["MaximumGunas"].ToString() + " </td>");
            TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + dtCurrentTable.Rows[j]["MatchedGunas"].ToString() + " </td>");
            TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" >" + dtCurrentTable.Rows[j]["DoshaStatus"].ToString() + "</td>");
            TBL.Append("<td style = \"padding:.1cm .2cm;border-top:1px solid #d5d5d5;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + dtCurrentTable.Rows[j]["IsExceptionMatch"].ToString() + " </th>");
            TBL.Append("</tr>");
        }
        TBL.Append("<tr style='color: White;background-color: #F4600A;font-weight: bold;'>");
        TBL.Append("<td style = \"padding:.1cm .2cm;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\"></td>");
        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" ></td>");
        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" ></td>");
        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" >Total</td>");
        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" >" + "36" + "</td>");
        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + ViewState["TotalMatchedGunas"].ToString() + " </td>");
        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" ></td>");
        TBL.Append("<td style = \"padding:.1cm .2cm;border-top:1px solid #d5d5d5;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" ></th>");
        TBL.Append("</tr>");
        TBL.Append("</td>");
        TBL.Append("</table>");
        TBL.Append("</div>");
        if (ViewState["FinalReport"].ToString() != "")
        {
            string FinalRestult = ViewState["FinalReport"].ToString();
            TBL.Append("<div>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0.88em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Matching Results</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + FinalRestult + " </div>");
            TBL.Append("</div>");
        }
        if (ViewState["NadiReport"].ToString() != "")
        {
            string NadiReport = ViewState["NadiReport"].ToString();
            TBL.Append("<div style='margin:10px 0px 0px 0px;'>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Nadi Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + NadiReport + " </div>");
            TBL.Append("</div>");
        }
        if (ViewState["NadiReportDiv2"].ToString() != "")
        {
            string NadiReportDiv2 = ViewState["NadiReportDiv2"].ToString();
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + NadiReportDiv2 + " </div>");
        }
        if (ViewState["BhakootReport"].ToString() != "")
        {
            string BhakootReport = ViewState["BhakootReport"].ToString();
            string BhakootReportLastRow = ViewState["BhakootReportLastRow"].ToString();
            TBL.Append("<div style='margin:25px 0px 0px 0px;'>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Bhakoot Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + BhakootReport + " </div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + BhakootReportLastRow + " </div>");
            TBL.Append("</div>");
        }
        if (ViewState["GanaReport"].ToString() != "")
        {
            string GanaReport = ViewState["GanaReport"].ToString();
            TBL.Append("<div style='margin:25px 0px 0px 0px;'>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Gana Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + GanaReport + " </div>");
            TBL.Append("</div>");
        }
        if (ViewState["GrahamaitriReport"].ToString() != "")
        {
            string GrahamaitriReport = ViewState["GrahamaitriReport"].ToString();
            TBL.Append("<div style='margin:25px 0px 0px 0px;'>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Grahamaitri Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + GrahamaitriReport + " </div>");
            TBL.Append("</div>");
        }
        if (ViewState["YoniReport"].ToString() != "")
        {
            string YoniReport = ViewState["YoniReport"].ToString();
            TBL.Append("<div style='margin:25px 0px 0px 0px;'>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Yoni Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + YoniReport + " </div>");
            TBL.Append("</div>");
        }
        if (ViewState["TaraReport"].ToString() != "")
        {
            string TaraReport = ViewState["TaraReport"].ToString();
            TBL.Append("<div style='margin:25px 0px 0px 0px;'>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Tara Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + TaraReport + " </div>");
            TBL.Append("</div>");
        }
        if (ViewState["VasyaReport"].ToString() != "")
        {
            string VasyaReport = ViewState["VasyaReport"].ToString();
            TBL.Append("<div style='margin:25px 0px 0px 0px;'>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Vasya Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + VasyaReport + " </div>");
            TBL.Append("</div>");
        }
        if (ViewState["VarnaReport"].ToString() != "")
        {
            string VarnaReport = ViewState["VarnaReport"].ToString();
            TBL.Append("<div style='margin:25px 0px 0px 0px;'>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Varna Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + VarnaReport + " </div>");
            TBL.Append("</div>");
        }

        if (ViewState["NakashtraReportDiv"].ToString() != "")
        {
            string NakashtraReportDiv = ViewState["NakashtraReportDiv"].ToString();
            TBL.Append("<div style='margin:25px 0px 0px 0px;'>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Nakashtra Dosha Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + NakashtraReportDiv + " </div>");
            TBL.Append("</div>");
        }

        if (ViewState["EkaNakashtraReportDiv"].ToString() != "")
        {
            string EkaNakashtraReportDiv = ViewState["EkaNakashtraReportDiv"].ToString();
            TBL.Append("<div style='margin:25px 0px 0px 0px;'>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Eka Nakashtra Dosha Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + EkaNakashtraReportDiv + " </div>");
            TBL.Append("</div>");
        }

        if (ViewState["Nakashtra27thReportDiv"].ToString() != "")
        {
            string Nakashtra27thReportDiv = ViewState["Nakashtra27thReportDiv"].ToString();
            TBL.Append("<div style='margin:25px 0px 0px 0px;'>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>27th Nakashtra Dosha Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + Nakashtra27thReportDiv + " </div>");
            TBL.Append("</div>");
        }
        if (ViewState["VadhaVainasikaReportDiv"].ToString() != "")
        {
            string VadhaVainasikaReportDiv = ViewState["VadhaVainasikaReportDiv"].ToString();
            TBL.Append("<div style='margin:25px 0px 0px 0px;'>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Vadha Vainasika Dosha Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + VadhaVainasikaReportDiv + " </div>");
            TBL.Append("</div>");
        }
        if (ViewState["ManglikDoshaDiv1"].ToString() != "")
        {
            string ManglikDoshaDiv1 = ViewState["ManglikDoshaDiv1"].ToString();
            TBL.Append("<div style='margin:25px 0px 0px 0px;'>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Manglik Dosha Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + ManglikDoshaDiv1 + " </div>");
            TBL.Append("</div>");
        }
        TBL.Append("<div style=\"float:left; width: 100%;\">");
        TBL.Append("<table style = \"width:100%;border-collapse: collapse;font-family: 'Roboto', sans-serif;font-size:15px;margin-bottom:.45cm;-webkit-print-color-adjust: exact;\">");
        //TBL.Append("<tr>");
        //TBL.Append("<td colspan = \"2\" style = \"text-align:left;padding:.30cm 0;\">");
        //TBL.Append("<div style='font-size: 1.4em;float: left;padding:0em 0em 0.4em 0em;margin: 0em 0em 0em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;'>Ashtakoot Guna Matching Status</div>");
        //TBL.Append("</td>");
        //TBL.Append("</tr>");
        TBL.Append("<tr>");
        TBL.Append("<td colspan = \"2\" style = \"vertical-align:top; \">");
        TBL.Append("<table style = \"width:100%;border-collapse: collapse;border:1px solid #d5d5d5;line-height: 30px;\">");
        TBL.Append("<tr>");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\">Manglik Dosha of Boy</td>");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > % </td>");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Manglik Dosha of Girl </td>");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" >%</td> ");
        TBL.Append("</tr>");
        DataTable dtManglisk = (DataTable)ViewState["dtManglisk"];
        int count1 = dtManglisk.Rows.Count;
        for (int k = 0; k < count1; k++)
        {
            TBL.Append("<tr>");
            TBL.Append("<td style = \"padding:.1cm .2cm;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + dtManglisk.Rows[k]["ManglikDoshaofBoy"].ToString() + " </td>");
            TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + dtManglisk.Rows[k]["ManglikPercentageForBoy"].ToString() + " </td>");
            TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + dtManglisk.Rows[k]["ManglikDoshaofGirl"].ToString() + " </td>");
            TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + dtManglisk.Rows[k]["ManglikPercentageforGirl"].ToString() + "</td>");
            TBL.Append("</tr>");
        }
        TBL.Append("</td>");
        TBL.Append("</table>");
        TBL.Append("</div>");
        if (ViewState["ManglikDoshaDiv2"].ToString() != "")
        {
            string ManglikDoshaDiv2 = ViewState["ManglikDoshaDiv2"].ToString();
            TBL.Append("<div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + ManglikDoshaDiv2 + " </div>");
            TBL.Append("</div>");
        }

        if (ViewState["DoshaSamyaDiv1"].ToString() != "")
        {
            string DoshaSamyaDiv1 = ViewState["DoshaSamyaDiv1"].ToString();
            TBL.Append("<div>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Dosha Samya Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + DoshaSamyaDiv1 + " </div>");
            TBL.Append("</div>");
        }
        TBL.Append("<div style=\"float:left; width: 100%;\">");
        TBL.Append("<table style = \"width:100%;border-collapse: collapse;font-family: 'Roboto', sans-serif;font-size:15px;margin-bottom:.45cm;-webkit-print-color-adjust: exact;\">");
        TBL.Append("<tr>");
        TBL.Append("<td colspan = \"2\" style = \"vertical-align:top; \">");
        TBL.Append("<table style = \"width:100%;border-collapse: collapse;border:1px solid #d5d5d5;line-height: 30px;\">");
        TBL.Append("<tr>");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\">Dosha Samya of Boy</td>");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > % </td>");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Dosha Samya of Girl</td>");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" >%</td> ");
        TBL.Append("</tr>");
        DataTable dtdoshasamya = (DataTable)ViewState["grddoshasamya"];
        int count2 = dtdoshasamya.Rows.Count;
        for (int k = 0; k < count2; k++)
        {
            TBL.Append("<tr>");
            TBL.Append("<td style = \"padding:.1cm .2cm;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + dtdoshasamya.Rows[k]["DoshaSamyaofBoy"].ToString() + " </td>");
            TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + dtdoshasamya.Rows[k]["DoshaPercentageForBoy"].ToString() + " </td>");
            TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + dtdoshasamya.Rows[k]["DoshaSamyaofGirl"].ToString() + " </td>");
            TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + dtdoshasamya.Rows[k]["DoshaPercentageforGirl"].ToString() + "</td>");
            TBL.Append("</tr>");
        }
        TBL.Append("</td>");
        TBL.Append("</table>");
        TBL.Append("</div>");

        if (ViewState["DoshaSamyaDiv2"].ToString() != "")
        {
            string DoshaSamyaDiv2 = ViewState["DoshaSamyaDiv2"].ToString();
            TBL.Append("<div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + DoshaSamyaDiv2 + " </div>");
            TBL.Append("</div>");
        }
        if (ViewState["KaalSarpaYogaDiv"].ToString() != "")
        {
            string KaalSarpaYogaDiv = ViewState["KaalSarpaYogaDiv"].ToString();
            TBL.Append("<div>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Kaal Sarpa Yoga Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + KaalSarpaYogaDiv + " </div>");
            TBL.Append("</div>");
        }

        TBL.Append("<div style=\"clear:both;\"></div>");
        TBL.Append("<div style =\"float: left;width: 100%;margin: 1% 0% 1% 0%;padding: 0.5em 0em 0em 0em;text-align: center;border-top-color: #F4600A;border-top-style: dashed;border-top-width: medium;font-family:Roboto,sans-serif;\">");
        TBL.Append("<img style='width: 50px;' src=\"" + WEBSITEDomainVal + "/Image/om_small.png\" alt=\"Astro Envision\" title=\"Astro Envision\" />");
        TBL.Append("<h1 style='float: left;padding: 1% 0% 0.5% 0%;margin: 0%;width: 100%;font-size: 1.5em;color: #F4600A;font-weight: bold;'>Thanks for using Astro Envision services</h1>");
        TBL.Append("<h2 style='float: left;padding: 0% 0% 0% 0%;margin: 0%;width: 100%;font-size: 1.2em;line-height: 1.8em;color: #5D5D5D;font-weight: bold;'>Provided By : Astro Envision</h2>");
        TBL.Append("<h2 style='float: left;padding: 0% 0% 0% 0%;margin: 0%;width: 100%;font-size: 1.2em;line-height: 1.8em;color: #5D5D5D;font-weight: bold;'>Contact : +91 9958883955, +91-9953248136</h2>");
        TBL.Append("<h2 style='float: left;padding: 0% 0% 0% 0%;margin: 0%;width: 100%;font-size: 1.2em;line-height: 1.8em;color: #5D5D5D;font-weight: bold;'>Email Id : support@astroenvision.com</h2>");
        TBL.Append("</div>");

        divShowData.InnerHtml = TBL.ToString();
        string reportHtml = TBL.ToString();
        var margins = new PageMargins
        {
            Top = 2,
            Bottom = 2,
            Left = 2,
            Right = 2
        };
        HtmlToPdfConverter _htmlToPdf = new HtmlToPdfConverter
        {
            Orientation = PageOrientation.Portrait,
            Margins = margins,
        };
        _htmlToPdf.Margins.Bottom = 20;
        _htmlToPdf.Margins.Left = 10;
        _htmlToPdf.Margins.Right = 10;
        _htmlToPdf.Margins.Top = 10;
        string system_date = System.DateTime.Now.ToString();
        String[] split_date = system_date.Split('/');
        string mm = split_date[0];
        string dd = split_date[1];
        string yyyy = split_date[2];
        string final_date = dd + "/" + mm + "/" + yyyy.Substring(0, 4);
        int dd_sys = Convert.ToInt32(dd);
        int mm_sys = Convert.ToInt32(mm);
        int yyyy_sys = Convert.ToInt32(yyyy.Substring(0, 4));
        string folderPath = Server.MapPath("gall_content/" + yyyy_sys + "/" + mm_sys + "/");
        iTextSharp.text.Font blackFont = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
        var FileName = BoyId.Replace(" ", String.Empty) + "_Report_" + DateTime.Now.ToString("ddMMyyyyHHss") + ".pdf";
        //PdfImage headerImage = "http:\"localhost\astrology\\img\\logo-astro.svg";
        var pdfBytes = _htmlToPdf.GeneratePdf(reportHtml);
        using (MemoryStream stream = new MemoryStream())
        {
            PdfReader reader = new PdfReader(pdfBytes);
            using (PdfStamper stamper = new PdfStamper(reader, stream))
            {
                int pages = reader.NumberOfPages;
                for (int i = 1; i <= pages; i++)
                {
                    ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_RIGHT, new Phrase(i.ToString(), blackFont), 568f, 15f, 0);
                }
            }
            pdfBytes = stream.ToArray();
        }
        var FolderWithFile = folderPath + FileName;
        System.IO.File.WriteAllBytes(FolderWithFile, pdfBytes);
        string DownLoadFileName = "gall_content/" + yyyy_sys + "/" + mm_sys + "/" + FileName;
        DownLoadFileName = DownLoadFileName.Replace("~", "");
        Response.ContentType = "application/pdf";
        Response.ContentEncoding = System.Text.Encoding.UTF8;
        // Response.AddHeader("Content-Disposition", "attachment; filename=" + FileName + "");
        Response.BinaryWrite(pdfBytes);
        //System.IO.File.WriteAllBytes(Server.MapPath("gall_content/" + yyyy_sys + "/" + mm_sys + "/") + FileName, pdfBytes);
        Response.Flush();
        Response.End();

    }
    #endregion
    #endregion
    #region Others Functions
    protected void btnproceed_Click(object sender, EventArgs e)
    {

    }
    protected void grdashakootmatching_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            string sponsorBonus = ((Label)e.Row.FindControl("lblMatchedGunas")).Text;
            decimal totalvalue = Convert.ToDecimal(sponsorBonus);
            sumFooterValue += totalvalue;
        }
        if (e.Row.RowType == DataControlRowType.Footer)
        {
            Label lbl = (Label)e.Row.FindControl("lblTotalMatchedGunas");
            lbl.Text = sumFooterValue.ToString();
            ViewState["TotalMatchedGunas"] = lbl.Text.ToString();
        }
    }
    public static string FirstCharToUpper(string input)
    {
        if (String.IsNullOrEmpty(input))
            throw new ArgumentException("");
        return input.First().ToString().ToUpper() + input.Substring(1).ToLower();
    }
    protected void grdmanglikdosha_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            string ManglikPercentageForBoy = ((Label)e.Row.FindControl("lblManglikPercentageForBoy")).Text;
            decimal totalvalue1 = Convert.ToDecimal(ManglikPercentageForBoy);
            sumMDBFooterValue += totalvalue1;
            string OverallGirlManglikDosha = ((Label)e.Row.FindControl("lblManglikPercentageForGirl")).Text;
            decimal totalvalue2 = Convert.ToDecimal(OverallGirlManglikDosha);
            sumMDGFooterValue += totalvalue2;
        }
        if (e.Row.RowType == DataControlRowType.Footer)
        {
            Label lblBoyTotal = (Label)e.Row.FindControl("lblBoyTotal");
            decimal ManglikPercentageForBoy = Convert.ToDecimal(sumMDBFooterValue) / 3;
            lblBoyTotal.Text = Math.Round(ManglikPercentageForBoy, 2).ToString();
            Label lblGirlTotal = (Label)e.Row.FindControl("lblGirlTotal");
            decimal ManglikPercentageForGirl = Convert.ToDecimal(sumMDGFooterValue) / 3;
            lblGirlTotal.Text = Math.Round(ManglikPercentageForGirl, 2).ToString();
        }
    }
    protected void grddoshasamya_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            string DoshaPercentageForBoy = ((Label)e.Row.FindControl("lblDoshaPercentageForBoy")).Text;
            decimal totalvalue1 = Convert.ToDecimal(DoshaPercentageForBoy);
            sumDSBFooterValue += totalvalue1;
            string OverallGirlDosha = ((Label)e.Row.FindControl("lblDoshaPercentageforGirl")).Text;
            decimal totalvalue2 = Convert.ToDecimal(OverallGirlDosha);
            sumDSGFooterValue += totalvalue2;
        }
        if (e.Row.RowType == DataControlRowType.Footer)
        {
            Label lblBoyTotal = (Label)e.Row.FindControl("lblBoyTotal");
            //lblBoyTotal.Text = (Convert.ToDouble(sumDSBFooterValue.ToString()) / 4).ToString("00.00");
            lblBoyTotal.Text = Math.Round(Convert.ToDouble(sumDSBFooterValue.ToString()) / 4, 2).ToString();
            Label lblGirlTotal = (Label)e.Row.FindControl("lblGirlTotal");
            //lblGirlTotal.Text = (Convert.ToDouble(sumDSGFooterValue.ToString()) / 4).ToString("00.00");
            lblGirlTotal.Text = Math.Round(Convert.ToDouble(sumDSGFooterValue.ToString()) / 4, 2).ToString();
            BoyDoshaSamyaTotalPoints = lblBoyTotal.Text;
            GirlDoshaSamyaTotalPoints = lblGirlTotal.Text;
        }
    }
    #endregion
}