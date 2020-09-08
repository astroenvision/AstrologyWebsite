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
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;


public partial class freecompatibilitymatchingreport : System.Web.UI.Page
{
    StringBuilder TBL = new StringBuilder();
    compatibilitymatching cm = new compatibilitymatching();
    ASTROLOGY.classesoracle.myaccount objmc = new ASTROLOGY.classesoracle.myaccount();
    subscription obj_subs = new subscription();
    Houseposition objhp = new Houseposition();
    public string WEBSITEDomainVal = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    DataTable dt = new DataTable();
    public int Houes1Value = 0, Houes2Value = 0, Houes3Value = 0, Houes4Value = 0, Houes5Value = 0, Houes6Value = 0, Houes7Value = 0, Houes8Value = 0, Houes9Value = 0, Houes10Value = 0, Houes11Value = 0, Houes12Value = 0;
    DataTable dtmd = new DataTable();
    DataTable dtds = new DataTable();
    DataTable dtdsboy = new DataTable();
    DataTable dtdsgirl = new DataTable();
    string BoyLagnaPoints, BoyMoonPoints, BoyVenusPoints, BoyTotalPoints, GirlLagnaPoints, GirlMoonPoints, GirlVenusPoints, GirlTotalPoints;
    string BoyDoshaSamyaTotalPoints, GirlDoshaSamyaTotalPoints;
    DataSet objds = new DataSet();
    string BoyId = "", GirlId = "";
    decimal sumFooterValue = 0, sumMDBFooterValue = 0, sumMDGFooterValue = 0;
    public string Sucolor = "#FF0000", MaColor = "#C74F4F", VeColor = "#FA0095", MeColor = "#087830", Jucolor = "#F25E0A", KeColor = "#708090", MoColor = "#3CA9EE", SaColor = "#00008B", GkColor = "#C71585", RaColor = "#000000", AscColor = "#FF8C00";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Deepak Add the following 2 lines for refresh the CartId
            string intrandom = Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day) + Convert.ToString(DateTime.Now.Hour) + Convert.ToString(DateTime.Now.Minute) + Convert.ToString(DateTime.Now.Second) + Convert.ToString(DateTime.Now.Millisecond);
            Session["MySessionID"] = intrandom;

            GetMatchingReport();
            astrologo.InnerHtml = "<a href=\"" + ResolveUrl("~/index.html") + "\" title=\"Astro Envision\">";
            astrologo.InnerHtml += "<img src=\"" + WEBSITEDomainVal + "/Image/large_logo.svg\" alt=\"Astro Envision\" title=\"Astro Envision\" />";
            astrologo.InnerHtml += "</a>";
            astrofreereport.InnerHtml = "<div style='padding:0em 0em 0em 0em;margin: 0em 0em 0.4em 0em;height: 40px;vertical-align: top;width: 100%;text-align: center;font-size: 1.4em;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;'><img style='width: 35px;' src=\"" + WEBSITEDomainVal + "/Image/om_small.png\" alt=\"Astro Envision\" title=\"Astro Envision\" />&nbsp;Kundli Compatibility Matching Report&nbsp;<img style='width: 35px;' src=\"" + WEBSITEDomainVal + "/Image/om_small.png\" alt=\"Astro Envision\" title=\"Astro Envision\" /></div>";
            BindBasicDeatis("");
            BindCharts();
        }
    }
    #region Bind Matching Reports
    void GetMatchingReport()
    {
        try
        {
            if (Request.QueryString["BoyId"] != null && Request.QueryString["GirlId"] != null)
            {
                if (Request.QueryString["BoyId"] != null)
                {
                    BoyId = Request.QueryString["BoyId"].Trim();
                }
                if (Request.QueryString["GirlId"] != null)
                {
                    GirlId = Request.QueryString["GirlId"].Trim();
                }
                DataSet ds = new DataSet();
                ds = cm.GetAshthakootNadiMatch(BoyId, GirlId, "GET_MATCHING_REPORT");
                ViewState["FinalReport"]= "";
                ViewState["NadiReport"] = "";
                ViewState["NadiReportDiv2"] = "";
                ViewState["BhakootReport"] = "";
                ViewState["GanaReport"] = "";
                ViewState["GrahamaitriReport"] = "";
                ViewState["YoniReport"] = "";
                ViewState["TaraReport"] = "";
                ViewState["VasyaReport"]= "";
                ViewState["VarnaReport"] = "";
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
                    string DefinitionVal = "", PredictiveVal = "", MatchedGunasVal="0", IsExceptionMatchVal="N", DoshaStatusVal="Unmatched";
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
                    string DefinitionVal =  dsg.Tables[2].Rows[0]["DEFINITION"].ToString().Trim();
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
                if (dsyn.Tables[0].Rows.Count > 0)
                {
                    string BoyName = dsyn.Tables[0].Rows[0]["BOY_NAME"].ToString().Trim();
                    string BoyYoni = dsyn.Tables[0].Rows[0]["BOY_YONI"].ToString().Trim();
                    string GirlName = dsyn.Tables[1].Rows[0]["GIRL_NAME"].ToString().Trim();
                    string GirlYoni = dsyn.Tables[1].Rows[0]["GIRL_YONI"].ToString().Trim();
                    string PredictiveVal = dsyn.Tables[2].Rows[0]["PREDICTIVE"].ToString().Trim();
                    string DefinitionVal = dsyn.Tables[2].Rows[0]["DEFINITION"].ToString().Trim();
                    YoniReportDiv.InnerHtml = DefinitionVal;
                    YoniReportDiv.InnerHtml += "" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBYYYY", BoyYoni).Replace("GGGGYYYY", GirlYoni);
                    ViewState["YoniReport"] = DefinitionVal+"" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBYYYY", BoyYoni).Replace("GGGGYYYY", GirlYoni);
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
                    ViewState["VasyaReport"] = DefinitionVal+"" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBVVVV", BoyYasya).Replace("GGGGVVVV", GirlYasya);
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
                    ViewState["VarnaReport"] = DefinitionVal+"" + PredictiveVal.Replace("BBBBNAME", BoyName).Replace("GGGGNAME", GirlName).Replace("BBBBVVVV", BoyRashiVarna).Replace("GGGGVVVV", GirlRashiVarna);
                    string MatchedGunasVal = dsvrna.Tables[2].Rows[0]["MATCHEDPOINT"].ToString().Trim();
                    string IsExceptionMatchVal = dsvrna.Tables[2].Rows[0]["ISMATCHEXCEPTION"].ToString().Trim();
                    string DoshaStatusVal = dsvrna.Tables[2].Rows[0]["DOSHASTATUS"].ToString().Trim();
                    dt.Rows.Add(8, "Varna", FirstCharToUpper(GirlRashiVarna), FirstCharToUpper(BoyRashiVarna), "1", MatchedGunasVal, DoshaStatusVal, IsExceptionMatchVal);
                }
                dsvrna.Dispose();

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
                                ViewState["FinalReport"] = "<p>There is a positive gains by Two major Koots and attaining " + TotalMatchedGunasVal + " Gunas between Ms. " + ViewState["GirlName"].ToString() + "(Girl) and Mr. " + ViewState["BoyName"].ToString() + "(Boy), the alliance may be considered for matching but still you are advised to go through the other dosha results before taking final decision.</p>";
                                finalreportid.InnerHtml = "<p>There is a positive gains by Two major Koots and attaining " + TotalMatchedGunasVal + " Gunas between Ms. " + ViewState["GirlName"].ToString() + "(Girl) and Mr. " + ViewState["BoyName"].ToString() + "(Boy), the alliance may be considered for matching but still you are advised to go through the other dosha results before taking final decision.</p>"; ;
                            }
                        }
                    }
                }
                dt.Dispose();
            }
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
        string Gender = "";

        if (Request.QueryString["BoyId"] != null)
        {
            BoyId = Request.QueryString["BoyId"].Trim();
        }
        if (Request.QueryString["GirlId"] != null)
        {
            GirlId = Request.QueryString["GirlId"].Trim();
        }
        DataSet ds = new DataSet();
        ds = cm.GetAshthakootNadiMatch(BoyId, GirlId, "GET_MATCHING_REPORT");
        for (int jx = 0; jx <= 1; jx++)
        {
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
            List<string> lstRetro = new List<string>();

            #region Bind Birth Chart
            string ChartImagePath = System.Configuration.ConfigurationManager.AppSettings["ChartImagePath"];

            TBL.Append("<table style = \"width:100%;border-collapse: collapse;font-family: 'Roboto', sans-serif;font-size:13px;margin-bottom:.65cm;-webkit-print-color-adjust: exact;\">");
            TBL.Append("<tr>");
            TBL.Append("<td colspan = \"2\" style = \"text-align:left;padding:.30cm 0;\">");
            TBL.Append("<div style = \"font-size: 20px;font-weight:bold;color:#f25e0a;text-align: center;\" >" + Name + "'s Chart" + "</div>");
            TBL.Append("</td>");
            TBL.Append("</tr>");
            TBL.Append("<tr>");
            //TBL.Append("<td style = \"vertical-align:top; \">");

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

                string GetRetro = SplitValue[4];
                if (GetRetro == "R")
                {
                    lstRetro.Add("R");
                }
                else
                {
                    lstRetro.Add("B");
                }
            }
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
                #region HOUSE1 Condition
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
                #endregion
                #region HOUSE2 Condition
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
                #endregion
                #region HOUSE3 Condition
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
                #endregion
                #region HOUSE4 Condition
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
                #endregion
                #region HOUSE5 Condition
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
                #endregion
                #region HOUSE6 Condition
                if (h == "HOUSE6")
                {
                    Houes6Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j6 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "JUPITER")
                    {
                        j6 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "VENUS")
                    {
                        j6 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SATURN")
                    {
                        j6 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SUN")
                    {
                        j6 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MOON")
                    {
                        j6 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MARS")
                    {
                        j6 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "RAHU")
                    {
                        j6 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j6 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "GULIKA")
                    {
                        j6 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }
                    h6 = h6 + j6 + " ";
                }
                #endregion
                #region HOUSE7 Condition
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
                #endregion
                #region HOUSE8 Condition
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
                #endregion
                #region HOUSE9 Condition
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
                #endregion
                #region HOUSE10 Condition
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
                #endregion
                #region HOUSE11 Condition
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
                #endregion
                #region HOUSE12 Condition
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
                #endregion
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
            }
            else
            {
                divGirlsChart.InnerHtml = TBL.ToString();
            }
        }
    }
    #endregion

    #region Get Basic Details
    protected void BindBasicDeatis(string Flag)
    {
        StringBuilder strHtml = new StringBuilder();
        string BoysName = "", BoysGender = "", BoyDateOfBirth = "", BoyDateOFTime = "", BoyConstellation = "", BoyBirthPlace = "", BoyRashi = "", BoyLagnaRashi = "", GirlConstellation = "", GirlsName = "", GirlGender = "", GirlDateOfBirth = "",
            GirlDateOFtime = "", GirlsBirthPlace = "", GirlRashi = "", GirlDayName = "", DayName = "", GirlLagnaRashi = "", GirlLatitude = "", BoyLatitude="", GirlLongitude="", BoyLongitude="", GirlTimeZone="",BoyTimeZone="" , BoyBalanceDasha="", GirlBalanceDasha="", BoySunriseTime="", GirlSunriseTime="", BoySunsetTime="", GirlSunsetTime="";
        for (int i = 1; i <= 2; i++)
        {
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
                    DayName = dsd.Tables[0].Rows[0]["DAYOB"].ToString();
                    BoyDateOfBirth = DateTime.ParseExact(dob, "dd/MM/yyyy", null).ToString("dd-MMM-yyyy");
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
                    GirlDayName = dsd.Tables[0].Rows[0]["DAYOB"].ToString();
                    GirlDateOfBirth = DateTime.ParseExact(dob, "dd/MM/yyyy", null).ToString("dd-MMM-yyyy");
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

        if(Flag== "ForPdf")
        {
            TBL.Append(strHtml.ToString());
        }
        bindDetails.InnerHtml = strHtml.ToString();
    }
    #endregion

    #region Generate PDF Code
    protected void lnkGeneratePDF_Click(object sender, EventArgs e)
    {
        //string Gender = "", Flag="";
      
        if (Request.QueryString["BoyId"] != null)
        {
            BoyId = Request.QueryString["BoyId"].Trim();
        }
        if (Request.QueryString["GirlId"] != null)
        {
            GirlId = Request.QueryString["GirlId"].Trim();
        }
        DataSet ds = new DataSet();
        ds = cm.GetAshthakootNadiMatch(BoyId, GirlId, "GET_MATCHING_REPORT");
        TBL.Append("<div style=\"width:100%; margin:0 auto; text-align:center;margin: 0em 0em 1em 0em;\">");
        TBL.Append("<a href=\"" + ResolveUrl("~/index.html") + "\" title=\"Astro Envision\">");
        TBL.Append("<img src=\"" + WEBSITEDomainVal + "/Image/large_logo.svg\" alt=\"Astro Envision\" title=\"Astro Envision\" />");
        TBL.Append("</a>");
        TBL.Append("</div>");
        TBL.Append("<div style='padding:0em 0em 0em 0em;margin: 0em 0em 0.4em 0em;height: 40px;vertical-align: top;width: 100%;text-align: center;font-size: 1.4em;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;'><img style='width: 35px;' src=\"" + WEBSITEDomainVal + "/Image/om_small.png\" alt=\"Astro Envision\" title=\"Astro Envision\" />&nbsp;Kundli Compatibility Matching Report&nbsp;<img style='width: 35px;' src=\"" + WEBSITEDomainVal + "/Image/om_small.png\" alt=\"Astro Envision\" title=\"Astro Envision\" /></div>");
        BindBasicDeatis("ForPdf");
        TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0.88em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Birth Chart</div>");
        for (int jx = 0; jx <= 1; jx++)
        {
            Houes1Value = 0; Houes2Value = 0; Houes3Value = 0; Houes4Value = 0; Houes5Value = 0; Houes6Value = 0; Houes7Value = 0; Houes8Value = 0; Houes9Value = 0; Houes10Value = 0; Houes11Value = 0; Houes12Value = 0;
            string GetDetails = ds.Tables[jx].Rows[0]["HOROSCOPE_D01"].ToString();
            string j10 = "", h10 = "", j1 = "", h1 = "", RashiID0 = "", RashiID1 = "", j2 = "", h2 = "", RashiID2 = "", RashiID3 = "", RashiID4 = "", RashiID5 = "", Name = "",
            RashiID6 = "", RashiID7 = "", RashiID8 = "", RashiID9 = "", RashiID10 = "", RashiID11 = "", RashiID12 = "", j3 = "", j4 = "", j5 = "", j6 = "", j7 = "", j8 = "", j9 = "", j11 = "", j12 = "", h3 = "", h4 = "", h5 = "", h6 = "", h7 = "", h8 = "", h9 = "", h11 = "", h12 = "";
            if (jx == 0)
            {
                //Gender = "Boy Chart";
                Name = ds.Tables[jx].Rows[0]["BOY_NAME"].ToString();
            }
            else
            {
                //Gender = "Girl Chart";
                Name = ds.Tables[jx].Rows[0]["GIRL_NAME"].ToString();
            }

            List<string> lstPlanets = new List<string>();
            List<string> lstRashi = new List<string>();
            List<string> lstHouse = new List<string>();
            List<string> lstDegree = new List<string>();
            List<string> lstMintues = new List<string>();
            List<string> lstRetro = new List<string>();
          
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

                string GetRetro = SplitValue[4];
                if (GetRetro == "R")
                {

                    lstRetro.Add("R");
                }
                else
                {
                    lstRetro.Add("B");
                }
            }

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
                #region HOUSE1 Condition
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
                #endregion
                #region HOUSE2 Condition
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
                #endregion
                #region HOUSE3 Condition
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
                #endregion
                #region HOUSE4 Condition
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
                #endregion
                #region HOUSE5 Condition
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
                #endregion
                #region HOUSE6 Condition
                if (h == "HOUSE6")
                {
                    Houes6Value++;
                    if (lstPlanets[i] == "MERCURY")
                    {
                        j6 = "<span style='color:" + MeColor + "'>Me</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "JUPITER")
                    {
                        j6 = "<span style='color:" + Jucolor + "'>Ju</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "VENUS")
                    {
                        j6 = "<span style='color:" + VeColor + "'>Ve</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SATURN")
                    {
                        j6 = "<span style='color:" + SaColor + "'>Sa</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "SUN")
                    {
                        j6 = "<span style='color:" + Sucolor + "'>Su</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MOON")
                    {
                        j6 = "<span style='color:" + MoColor + "'>Mo</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "MARS")
                    {
                        j6 = "<span style='color:" + MaColor + "'>Ma</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "RAHU")
                    {
                        j6 = "<span style='color:" + RaColor + "'>Ra</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }
                    if (lstPlanets[i] == "KETU")
                    {
                        j6 = "<span style='color:" + KeColor + "'>Ke</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
                    }

                    if (lstPlanets[i] == "GULIKA")
                    {
                        j6 = "<span style='color:" + GkColor + "'>Gk</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span>";
                    }
                    h6 = h6 + j6 + " ";
                }
                #endregion
                #region HOUSE7 Condition
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
                #endregion
                #region HOUSE8 Condition
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
                #endregion
                #region HOUSE9 Condition
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
                #endregion
                #region HOUSE10 Condition
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
                #endregion
                #region HOUSE11 Condition
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
                #endregion
                #region HOUSE12 Condition
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
                #endregion
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
            TBL.Append("<div style=\"position:absolute; top:41%;  left:49%;width:30%;\">");
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
                Top2 = "0%;";
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
            TBL.Append("<div style=\"position:absolute; top:20%; left:19%;width:10%;\">");
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
            TBL.Append("<div style=\"position:absolute; top:46%; left:44%;width:10%;\">");
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
            TBL.Append("<div style=\"position:absolute; top:69%; left:18.5%;width:10%;\">");
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
                RashiTop8 = "70%;";
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
            if (Houes9Value >= 5)
            {
                Top9 = "64%;";

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
            TBL.Append("<div style=\"position:absolute; top:69%; left:77%;width:11%;\">");
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
            TBL.Append("<div style=\"position:absolute; top:45%; left:53%;width:10%;\">");
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
            TBL.Append("<div style=\"position:absolute; top:20%; left:77%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"1h11r\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID11 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");

            /******* House 12******/
            string Top12 = "5%;";
            string RashiTop12 = "17%;";
            string fontsize12 = "16px;";
            string LineHeight12 = "";
            if (Houes12Value > 3)
            {
                Top12 = "3%;";
                RashiTop12 = "17%;";
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
            TBL.Append("<div style=\"position:absolute; top:" + RashiTop12 + " left:74%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"1h12r\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID12 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("</div>");
            TBL.Append("</td>");
            TBL.Append("</tr>");
            TBL.Append("</table>");
            TBL.Append("</div>");
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
            TBL.Append("<div>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Nadi Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + NadiReport + " </div>");
            TBL.Append("</div>");
        }
        if(ViewState["NadiReportDiv2"].ToString() != "")
        {
            string NadiReportDiv2 = ViewState["NadiReportDiv2"].ToString();
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + NadiReportDiv2 + " </div>");
        }
        if (ViewState["BhakootReport"].ToString() != "")
        {
            string BhakootReport = ViewState["BhakootReport"].ToString();
            string BhakootReportLastRow = ViewState["BhakootReportLastRow"].ToString();
            TBL.Append("<div>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Bhakoot Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + BhakootReport + " </div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + BhakootReportLastRow + " </div>");
            TBL.Append("</div>");
        }
        if (ViewState["GanaReport"].ToString() != "")
        {
            string GanaReport = ViewState["GanaReport"].ToString();
            TBL.Append("<div>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Gana Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + GanaReport + " </div>");
            TBL.Append("</div>");
        }
        if (ViewState["GrahamaitriReport"].ToString() != "")
        {
            string GrahamaitriReport = ViewState["GrahamaitriReport"].ToString();
            TBL.Append("<div>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Grahamaitri Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + GrahamaitriReport + " </div>");
            TBL.Append("</div>");
        }
        if (ViewState["YoniReport"].ToString() != "")
        {
            string YoniReport = ViewState["YoniReport"].ToString();
            TBL.Append("<div>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Yoni Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + YoniReport + " </div>");
            TBL.Append("</div>");
        }
        if (ViewState["TaraReport"].ToString() != "")
        {
            string TaraReport = ViewState["TaraReport"].ToString();
            TBL.Append("<div>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Tara Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + TaraReport + " </div>");
            TBL.Append("</div>");
        }
        if (ViewState["VasyaReport"].ToString() != "")
        {
            string VasyaReport = ViewState["VasyaReport"].ToString();
            TBL.Append("<div>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Vasya Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + VasyaReport + " </div>");
            TBL.Append("</div>");
        }
        if (ViewState["VarnaReport"].ToString() != "")
        {
            string VarnaReport = ViewState["VarnaReport"].ToString();
            TBL.Append("<div>");
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;font-size: 1.3em;'>Varna Report</div>");
            TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\" > " + VarnaReport + " </div>");
            TBL.Append("</div>");
        }
        TBL.Append("<div style=\"clear:both;\"></div><div>");
        TBL.Append("<h1 style=\"color: #f25e0a;font-size: 1.3em; font-weight: 600; margin: 0 0 8px 0;\"><i class=\"fa fa-angle-double-right\" style=\"font-size:26px;color:#f25e0a;\"></i>&nbsp;Important</h1>");
        TBL.Append("</div>");
        TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\"><p>The following Kundali Matching &#8208; (Compatibility) reports are very crucial to consider before taking final decision to go ahead for marriage.</p></div>");
        TBL.Append("<h5 style=\"line-height:4px;font-size:1em; \">1. Manglik Dosha Report</h5>");
        TBL.Append("<h5 style=\"line-height:4px;font-size:1em; \">2. Dosha Samay Report</h5>");
        TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\">Covers combined dosha arising from Mars, Saturn, Rahu and Sun &#8208; Very Important Consideration much beyond Manglik Dosha</div>");
        TBL.Append("<h5 style=\"line-height:4px;font-size:1em; \">3. Nakashtra Dosha Report</h5>");
        TBL.Append("<h5 style=\"line-height:4px;font-size:1em; \">4. Eka Nakashtra Dosha Report</h5>");
        TBL.Append("<h5 style=\"line-height:4px;font-size:1em; \">5. Vaadh Vainashik Dosha Report</h5>");
        TBL.Append("<h5 style=\"line-height:4px;font-size:1em; \">6. 27th Constellation Dosha Report</h5>");
        TBL.Append("<h5 style=\"line-height:4px;font-size:1em; \">7. Kaal- Sarpa Yoga</h5>");
        TBL.Append("<div style = \"display:list-item;list-style-type: disc;list-style-position: inside;margin-top:10px;\">Further, you may buy various Astro reports to know deep about the prospective alliance.</div><br/>");
        TBL.Append("<div><a style=\"font-weight:bold;color: #f25e0a;text-decoration: none;\" href=\"" + WEBSITEDomainVal + "/natal-astrology/kundli-matching.html" + "\" title=\"Buy Report\" target=\"_blank\">Click Here For Buy Report</a></div><br/>");
        TBL.Append("<div style =\"float: left;width: 100%;margin: 1% 0% 1% 0%;padding: 0.5em 0em 0em 0em;text-align: center;border-top-color: #F4600A;border-top-style: dashed;border-top-width: medium;font-family:Roboto,sans-serif;\">");
        TBL.Append("<img style='width: 50px;' src=\"" + WEBSITEDomainVal + "/Image/om_small.png\" alt=\"Astro Envision\" title=\"Astro Envision\" />");
        TBL.Append("<h1 style='float: left;padding: 1% 0% 0.5% 0%;margin: 0%;width: 100%;font-size: 1.5em;color: #F4600A;font-weight: bold;'>Thanks for using Astro Envision services</h1>");
        TBL.Append("<h2 style='float: left;padding: 0% 0% 0% 0%;margin: 0%;width: 100%;font-size: 1.2em;line-height: 1.8em;color: #5D5D5D;font-weight: bold;'>Provided By : Astro Envision</h2>");
        TBL.Append("<h2 style='float: left;padding: 0% 0% 0% 0%;margin: 0%;width: 100%;font-size: 1.2em;line-height: 1.8em;color: #5D5D5D;font-weight: bold;'>Contact : +91 9958883955, +91-9953248136</h2>");
        TBL.Append("<h2 style='float: left;padding: 0% 0% 0% 0%;margin: 0%;width: 100%;font-size: 1.2em;line-height: 1.8em;color: #5D5D5D;font-weight: bold;'>Email Id : support@astroenvision.com</h2>");
        TBL.Append("</div>");
        //divShowData.InnerHtml = TBL.ToString();
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

        //var FormHtml = @"<html><body><h2>Editable PDF  Form</h2><form>Deepak Nirwal</form></body></html>";
        //IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
        //// add a header to every page easily
        //Renderer.PrintOptions.FirstPageNumber = 1; // use 2 if a coverpage  will be appended
        //Renderer.PrintOptions.Header.DrawDividerLine = true;
        //Renderer.PrintOptions.Header.CenterText = "{url}";
        //Renderer.PrintOptions.Header.FontFamily = "Helvetica,Arial";
        //Renderer.PrintOptions.Header.FontSize = 12;
        //// add a footer too
        //Renderer.PrintOptions.Footer.DrawDividerLine = true;
        //Renderer.PrintOptions.Footer.FontFamily = "Arial";
        //Renderer.PrintOptions.Footer.FontSize = 10;
        //Renderer.PrintOptions.Footer.LeftText = "{date} {time}";
        //Renderer.PrintOptions.Footer.RightText = "{page} of {total-pages}";
        //// Render an HTML document or snippet as a string
        //Renderer.RenderHtmlAsPdf(FormHtml).SaveAs("D:\\ShareFolder\\html-string.pdf");
        //// Advanced: 
        //// Set a "base url" or file path so that images, javascript and CSS can be loaded  
        //var PDF = Renderer.RenderHtmlAsPdf("<img src='icons/iron.png'>", @"D:\ShareFolder\");
        //PDF.SaveAs("D:\\ShareFolder\\html-string.pdf");
   }
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
    #endregion
}