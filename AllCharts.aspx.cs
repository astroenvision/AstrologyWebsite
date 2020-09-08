using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AllCharts : System.Web.UI.Page
{
    #region Declarations

    ASTROLOGY.classesoracle.main obj_main = new ASTROLOGY.classesoracle.main();
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    ASTROLOGY.classesoracle.myaccount objmc = new ASTROLOGY.classesoracle.myaccount();
    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
    public string UserName = "";
    public string p21 = "", p22 = "", p23 = "", p24 = "", p25 = "", p26 = "", p27 = "", p28 = "", p29 = "", p210 = "", p211 = "", p212 = "", HeaderValue = "";
    public string j21 = "", j22 = "", j23 = "", j24 = "", j25 = "", j26 = "", j27 = "", j28 = "", j29 = "", j210 = "", j211 = "", j212 = "";
    public string h21 = "", h22 = "", h23 = "", h24 = "", h25 = "", h26 = "", h27 = "", h28 = "", h29 = "", h210 = "", h211 = "", r11 = "", h212 = "";
    public string r21 = "", r22 = "", r23 = "", r24 = "", r25 = "", r26 = "", r27 = "", r28 = "", r29 = "", r210 = "", r211 = "", r212 = "";
    DataSet dsd = new DataSet();
    common obj_comm = new common();
    DataSet ds = new DataSet();
    bool flaglagna = false;
    bool flagRemedial = false;
    public string GetDetails = "";
    List<string> lstHouse = new List<string>();
    List<string> lstRashi = new List<string>();
    List<string> lstPlanets = new List<string>();
    List<string> lstDegree = new List<string>();
    List<string> lstRetro = new List<string>();
    List<string> lstMintues = new List<string>();
    StringBuilder TBL = new StringBuilder();
    bool flagnoanswer = false, MAILSENTTOSUPPORT = false;
    public static int yearantar, yearpratyantar, yearsookshma;
    public string HoraryEndUserAstrologerIDVal = ConfigurationManager.AppSettings["HoraryEndUserAstrologerID"].ToString();
    public string HoraryEndUserAstrologerNameVal = ConfigurationManager.AppSettings["HoraryEndUserAstrologerName"].ToString();
    public string NatalEndUserAstrologerIDVal = ConfigurationManager.AppSettings["NatalEndUserAstrologerID"].ToString();
    public string NatalEndUserAstrologerNameVal = ConfigurationManager.AppSettings["NatalEndUserAstrologerName"].ToString();
    public string WEBSITEDomainVal = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
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
    public int dd_sys, mm_sys, yyyy_sys;
    public int Houes1Value = 0, Houes2Value = 0, Houes3Value = 0, Houes4Value = 0, Houes5Value = 0, Houes6Value = 0, Houes7Value = 0, Houes8Value = 0, Houes9Value = 0, Houes10Value = 0, Houes11Value = 0, Houes12Value = 0;
    public string j10 = "", h10 = "", j1 = "", h1 = "", RashiID0 = "", RashiID1 = "", j2 = "", h2 = "", RashiID2 = "", RashiID3 = "", RashiID4 = "", RashiID5 = "",
            RashiID6 = "", RashiID7 = "", RashiID8 = "", RashiID9 = "", RashiID10 = "", RashiID11 = "", RashiID12 = "", j3 = "", j4 = "", j5 = "", j6 = "", j7 = "", j8 = "", j9 = "", j11 = "", j12 = "", h3 = "", h4 = "", h5 = "", h6 = "", h7 = "", h8 = "", h9 = "", h11 = "", h12 = "";
    public string Sucolor = "#FF0000", MaColor = "#C74F4F", VeColor = "#FA0095", MeColor = "#087830", Jucolor = "#F25E0A", KeColor = "#708090", MoColor = "#3CA9EE", SaColor = "#00008B", GkColor = "#C71585", RaColor = "#000000", AscColor = "#FF8C00";
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            BindCharts("BindChart");
        }
    }

    #region Bind Charts
    protected void BindCharts(string Flag)
    {
        string clientname = "";//"Akshay@gmail.com";
        string ClientId = "";//"1";
        string emailid = "";//"Akshay@gmail.com";
        string clientid = "";//"1";
        if (Request.QueryString["userid"] != null && Request.QueryString["userid"] != null)
        {
            clientname = Request.QueryString["useremailid"].ToString().Trim();
            ClientId = Request.QueryString["userid"].ToString().Trim();
            emailid = Request.QueryString["useremailid"].ToString().Trim();
            clientid = Request.QueryString["userid"].ToString().Trim();
        }
            
        dsd = objmc.Get_Clientdetails(emailid, clientid);

        string dob = dsd.Tables[0].Rows[0]["DOB"].ToString();
        dob = DateTime.ParseExact(dob, "dd/MM/yyyy", null).ToString("dd-MMM-yyyy");
        string dobtime = dsd.Tables[0].Rows[0]["TOB"].ToString();
        string Gender = dsd.Tables[0].Rows[0]["GENDER"].ToString();
        if (Gender == "M")
        {
            Gender = "Male";
        }
        else
        {
            Gender = "Female";
        }
        string dobtimeval = dsd.Tables[0].Rows[0]["DOB"].ToString();
        string lagnarashival = dsd.Tables[0].Rows[0]["LAGNARASHI"].ToString();
        dobtimeval = DateTime.ParseExact(dobtimeval, "dd/MM/yyyy", null).ToString("dd-MMM-yyyy");
        dobtimeval = dobtimeval.ToUpper();
        string tobval = dsd.Tables[0].Rows[0]["TOB"].ToString();
        string balancedashaval = dsd.Tables[0].Rows[0]["BALANCE_DASHA_TOB"].ToString();
        balancedashaval = balancedashaval.Replace("Balance Of Dasha :", "");
        balancedashaval = balancedashaval.Trim();
        string sunrise = dsd.Tables[0].Rows[0]["SUN_RISE"].ToString();
        DateTime srt = Convert.ToDateTime(sunrise);
        sunrise = srt.ToString("dd/MM/yyyy hh:mm:ss tt");
        sunrise = DateTime.ParseExact(sunrise, "dd/MM/yyyy hh:mm:ss tt", null).ToString("dd-MMM-yyyy , hh:mm:ss tt");
        sunrise = sunrise.ToUpper();

        string sunret = dsd.Tables[0].Rows[0]["SUN_SET"].ToString();
        DateTime sst = Convert.ToDateTime(sunret);
        sunret = sst.ToString("dd/MM/yyyy hh:mm:ss tt");
        sunret = DateTime.ParseExact(sunret, "dd/MM/yyyy hh:mm:ss tt", null).ToString("dd-MMM-yyyy , hh:mm:ss tt");
        sunret = sunret.ToUpper();

        string sunrisenext = dsd.Tables[0].Rows[0]["SUN_RISE_NEXTDAY"].ToString();
        DateTime srnt = Convert.ToDateTime(sunrisenext);
        sunrisenext = srnt.ToString("dd/MM/yyyy hh:mm:ss tt");
        sunrisenext = DateTime.ParseExact(sunrisenext, "dd/MM/yyyy hh:mm:ss tt", null).ToString("dd-MMM-yyyy , hh:mm:ss tt");
        sunrisenext = sunrisenext.ToUpper();
        UserName = dsd.Tables[0].Rows[0]["CLIENT_NAME"].ToString();

        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"margin-bottom:12px;margin-left: 390px;\">");
            TBL.Append("<img src=\"" + WEBSITEDomainVal + "/Image/large_logo.svg\" alt=\"Astro Envision\" title=\"Astro Envision\" />");
            TBL.Append("</div>");
        }
        

        #region Bind Birth Chart

        string astroname = NatalEndUserAstrologerNameVal;
        string astid1 = NatalEndUserAstrologerIDVal;
        string group = "Astro Envision Natal";
        string groupu = "Natal";

        DataSet dsClient = new DataSet();

        dsClient = country.searchclientid(clientname, astroname, astid1, group, groupu, ClientId);

        string GetDetails = dsClient.Tables[1].Rows[0]["HOROSCOPE_D01"].ToString();
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
            string RetrovVal = "-";
            if (GetRetro == "B")
            {
                RetrovVal = "-";
                lstRetro.Add("B");
            }
            else
            {
                RetrovVal = GetRetro;
                lstRetro.Add(GetRetro);
            }
            }
        
        TBL.Append("<div style =\"page-break-before:always\">&nbsp;</div>");

        TBL.Append("<table style = \"width:99%;border-collapse: collapse;font-family:Roboto,sans-serif;font-size:15px;-webkit-print-color-adjust: exact; margin:0 auto;\">");
        TBL.Append("<tr>");

        #region Start Loop
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
            #region Rashi Conditions
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
            #endregion
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
                    j10 = "<span style='color:" + SaColor + "'>SA</span>" + "<span style= \"text-align:left; color:black; font-size:12px;font-weight: bold;padding-left: " + Padding + "\">" + Retro + "</span>" + " " + "<span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[i] + '.' + lstMintues[i] + "</span><br/>";
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

        TBL.Append("<td style = \"vertical-align:top;\">");

        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style='width: 50%;margin: 0;float:left;'>");
        }
        else
        {
            TBL.Append("<div class='chartboxleft'>");
        }

        #region Bind D01 Chart
        TBL.Append("<div style = 'color:Black;font-size:14px;font-weight:bold;font-family:sans-serif;'>D01(Birth Chart)</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style = \"background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:480px;height: 450px;\">");
        }
        else
        {
            TBL.Append("<div style = \"background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:540px;height: 450px;\">");
        }
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

        TBL.Append("<span id = \"DetailsHouese1\" style = \"text-align:left; color:#403E3E; font-weight: bold;font-size:" + fontsize1 + ";\"><span style='color:" + AscColor + ";font-size:" + fontsize1 + "';'>As</span><span style =\"text-align:left; color:black; font-size:12px;font-weight: bold;\"> " + Ret + "</span><span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">" + lstDegree[0] + "</span><span style=\"text-align:left; color:black; font-size:11px;font-weight: bold;\">." + lstMintues[0] + "</span><br/> " + h1 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:37%;  left:49%;width:30%;\">");
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
        TBL.Append("<div style=\"position:absolute; top:13%;left:24%;width:10%;\">");
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
        TBL.Append("<div style=\"position:absolute; top:19%; left:19%;width:10%;\">");
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
        TBL.Append("<div style=\"position:absolute; top:43%; left:44%;width:10%;\">");
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
        TBL.Append("<div style=\"position:absolute; top:67%; left:17%;width:10%;\">");
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
        if (Houes9Value >= 4)
        {
            Top9 = "62%;";
        }
        if (Houes9Value > 4)
        {
            LineHeight9 = "line-height:15px;";
            fontsize9 = "12px;";
        }
        TBL.Append("<div style=\"position:absolute; top:" + Top9 + " left:85%;width:15%;" + LineHeight9 + "\">");
        TBL.Append("<span>");
        TBL.Append("<span id =\"1h9l1\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize9 + ";font-weight: bold;\">" + h9 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:68%; left:79%;width:11%;\">");
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
        TBL.Append("<div style=\"position:absolute; top:43%; left:55%;width:10%;\">");
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
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:20%; left:77%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:17%; left:77%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id =\"1h11r\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID11 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");

        /******* House 12******/
        string Top12 = "3%;";
        string RashiTop12 = "13%;";
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
        TBL.Append("<div style=\"position:absolute; top:" + RashiTop12 + " left:74%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id =\"1h12r\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID12 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");

        #endregion

        TBL.Append("</div>");

        #region Split Birth Data
        string vargas = GetDetails;
        string vargasfinal = "", birth = "0";
        string[] vgs1 = vargas.Split('~');
        List<string> lstPlannets = new List<string>();
        List<string> lstrashi = new List<string>();
        List<string> lsthouse = new List<string>();

        List<string> retrograde = new List<string>();
        List<string> constelation = new List<string>();
        List<string> degree = new List<string>();

        List<string> minutes = new List<string>();
        List<string> seconds = new List<string>();

        for (int i = 0; i < vgs1.Length - 1; i++)
        {
            string vgs1_str = vgs1[i];
            string[] vgs2 = vgs1_str.Split('/');
            lstPlannets.Add(vgs2[0]);
            lstrashi.Add(vgs2[1]);
            lsthouse.Add(vgs2[2]);
            retrograde.Add(vgs2[4]);
            constelation.Add(vgs2[5]);
            var vgs3 = vgs2[3].Split('.');
            degree.Add(vgs3[0]);
            minutes.Add(vgs3[1]);
            seconds.Add(vgs3[2]);
            string retro = "";
            if (retrograde[i] == "")
            {
                retro = "B";
            }
            else
            {
                retro = retrograde[i];
            }
            string DegreeVal = degree[i] + "." + minutes[i] + "." + seconds[i];
            vargasfinal = vargasfinal + lstPlannets[i] + "~" + lstrashi[i] + "~" + lsthouse[i] + "~" + birth + "~" + retro + "~" + DegreeVal + "~" + constelation[i] + "$";
        }
        vargasfinal = vargasfinal.Substring(0, vargasfinal.Length - 1);
        ds = country.vargas(vargasfinal);

        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; ++i)
            {
                lstPlanetRashiId.Add(ds.Tables[0].Rows[i]["PLANET"].ToString());
                D1lstHouse1.Add(ds.Tables[0].Rows[i]["D1_HOUSE"].ToString());
                D1Rashi.Add(ds.Tables[0].Rows[i]["D1_RASHI"].ToString());
                D1BirthTime.Add(ds.Tables[0].Rows[i]["BIRTH_TIME"].ToString());
                D1Retro.Add(ds.Tables[0].Rows[i]["RETRO"].ToString());
                D1Degree.Add(ds.Tables[0].Rows[i]["DEGREE"].ToString());
                D2lstHouse1.Add(ds.Tables[0].Rows[i]["D2_HOUSE"].ToString());
                D2Rashi.Add(ds.Tables[0].Rows[i]["D2_RASHI"].ToString());
                D4lstHouse1.Add(ds.Tables[0].Rows[i]["D4_HOUSE"].ToString());
                D4Rashi.Add(ds.Tables[0].Rows[i]["D4_RASHI"].ToString());
                D9lstHouse1.Add(ds.Tables[0].Rows[i]["D9_HOUSE"].ToString());
                D9Rashi.Add(ds.Tables[0].Rows[i]["D9_RASHI"].ToString());
                D10lstHouse1.Add(ds.Tables[0].Rows[i]["D10_HOUSE"].ToString());
                D10Rashi.Add(ds.Tables[0].Rows[i]["D10_RASHI"].ToString());
                D24lstHouse1.Add(ds.Tables[0].Rows[i]["D24_HOUSE"].ToString());
                D24Rashi.Add(ds.Tables[0].Rows[i]["D24_RASHI"].ToString());
                D60lstHouse1.Add(ds.Tables[0].Rows[i]["D60_HOUSE"].ToString());
                D60Rashi.Add(ds.Tables[0].Rows[i]["D60_RASHI"].ToString());
                D03lstHouse1.Add(ds.Tables[0].Rows[i]["D3_HOUSE"].ToString());
                D03Rashi.Add(ds.Tables[0].Rows[i]["D3_RASHI"].ToString());
                D07lstHouse1.Add(ds.Tables[0].Rows[i]["D7_HOUSE"].ToString());
                D07Rashi.Add(ds.Tables[0].Rows[i]["D7_RASHI"].ToString());
                D12lstHouse1.Add(ds.Tables[0].Rows[i]["D12_HOUSE"].ToString());
                D12Rashi.Add(ds.Tables[0].Rows[i]["D12_RASHI"].ToString());
                D16lstHouse1.Add(ds.Tables[0].Rows[i]["D16_HOUSE"].ToString());
                D16Rashi.Add(ds.Tables[0].Rows[i]["D16_RASHI"].ToString());
                D30lstHouse1.Add(ds.Tables[0].Rows[i]["D30_HOUSE"].ToString());
                D30Rashi.Add(ds.Tables[0].Rows[i]["D30_RASHI"].ToString());
                D45lstHouse1.Add(ds.Tables[0].Rows[i]["D45_HOUSE"].ToString());
                D45Rashi.Add(ds.Tables[0].Rows[i]["D45_RASHI"].ToString());
                D20lstHouse1.Add(ds.Tables[0].Rows[i]["D20_HOUSE"].ToString());
                D20Rashi.Add(ds.Tables[0].Rows[i]["D20_RASHI"].ToString());
                D27lstHouse1.Add(ds.Tables[0].Rows[i]["D27_HOUSE"].ToString());
                D27Rashi.Add(ds.Tables[0].Rows[i]["D27_RASHI"].ToString());
                D40lstHouse1.Add(ds.Tables[0].Rows[i]["D40_HOUSE"].ToString());
                D40Rashi.Add(ds.Tables[0].Rows[i]["D40_RASHI"].ToString());
                D05lstHouse1.Add(ds.Tables[0].Rows[i]["D5_HOUSE"].ToString());
                D05Rashi.Add(ds.Tables[0].Rows[i]["D5_RASHI"].ToString());
                D06lstHouse1.Add(ds.Tables[0].Rows[i]["D6_HOUSE"].ToString());
                D06Rashi.Add(ds.Tables[0].Rows[i]["D6_RASHI"].ToString());
                D08lstHouse1.Add(ds.Tables[0].Rows[i]["D8_HOUSE"].ToString());
                D08Rashi.Add(ds.Tables[0].Rows[i]["D8_RASHI"].ToString());
                D11lstHouse1.Add(ds.Tables[0].Rows[i]["D11_HOUSE"].ToString());
                D11Rashi.Add(ds.Tables[0].Rows[i]["D11_RASHI"].ToString());
                DKLlstHouse1.Add(ds.Tables[0].Rows[i]["KARAKAMSHA_HOUSE"].ToString());
                DKLRashi.Add(ds.Tables[0].Rows[i]["KARAKAMSHA_RASHI"].ToString());
                DMoonlstHouse1.Add(ds.Tables[0].Rows[i]["MOON_HOUSE"].ToString());
                DMoonRashi.Add(ds.Tables[0].Rows[i]["MOON_RASHI"].ToString());
                DVenuslstHouse1.Add(ds.Tables[0].Rows[i]["VENUS_HOUSE"].ToString());
                DVenusRashi.Add(ds.Tables[0].Rows[i]["VENUS_RASHI"].ToString());
            }
        }
        #endregion

        ShowChart("D09");

        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style='width: 45%;margin: 0;float: left;padding: 0 0 0 20px;'>");
        }
        else
        {
            TBL.Append("<div class='chartboxright'>");
        }

        TBL.Append("<div style='width: auto;margin: 0;float: left;'>");

        #region Bind Chart D09
        TBL.Append("<div style = \"color:Black;font-size:14px;font-weight:bold;\"> " + HeaderValue + "</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:450px;height:210px; \">");
        }
        else
        {
            TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:500px;height:210px; \">");
        }
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id =\"Fhou1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:33%;  left:44%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:27%;  left:46%;width:10%;\">");
        }
        //TBL.Append("<div style=\"position:absolute; top:27%;  left:46%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"FRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"FHouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:6%;  left: 21%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:4%;  left: 21%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id =\"FRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id =\"FHouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:15%; left:13%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:11%; left:13%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id =\"FRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:40%; left:13%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id =\"FHouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:39%; left:40%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:34%; left:40%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id =\"FRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id =\"FHouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:63%; left:14%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:58%; left:16%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id = \"FRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id =\"FHouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:69%; left:21%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id =\"FRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id =\"FHouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:44%; left:45%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:39%; left:45%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id =\"FRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id =\"FHouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span></span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:72%; left:70%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:63%; left:70%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id =\"FRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"FHouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:64%; left:75%;width:11%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:58%; left:76%;width:11%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id = \"FRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"FHouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:40%; left:50%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:34%; left:50%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id = \"FRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"FHouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:15%; left:76%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:10%; left:74%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id = \"FRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id =\"FHouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:5%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id =\"FRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        #endregion

        TBL.Append("</div>");
        TBL.Append("<div style='width: auto;margin: 5px 0 0 0;float: left;'>");

        ShowChart("D10");

        #region Bind Chart D10
        TBL.Append("<div style=\"color:Black;font-size:14px;font-weight:bold;\">" + HeaderValue + "</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:450px;height:210px; \">");
        }
        else
        {
            TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:500px;height:210px; \">");
        }
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id =\"Shouse1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:33%;  left:44%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:27%;  left:46%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id = \"SRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"FHouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:6%;  left: 21%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:4%;  left: 21%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id =\"FRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"Shouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:15%; left:13%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:11%; left:13%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id = \"SRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:42%; left:15%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"Shouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:39%; left:40%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:34%; left:40%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id = \"SRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"Shouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:63%; left:14%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:58%; left:16%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id = \"SRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"Shouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:69%; left:21%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id = \"SRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"Shouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:44%; left:45%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:39%; left:45%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id = \"SRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"Shouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:72%; left:70%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:63%; left:70%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id = \"SRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"Shouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:64%; left:75%;width:11%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:58%; left:76%;width:11%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id = \"SRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"Shouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:40%; left:50%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:34%; left:50%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id = \"SRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"Shouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "FOR_PDF")
        {
            TBL.Append("<div style=\"position:absolute; top:15%; left:76%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top:10%; left:74%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id = \"SRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"Shouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:5%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"SRashi12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        #endregion

        TBL.Append("</div>");


        TBL.Append("</div>");

        TBL.Append("</td>");
        TBL.Append("</tr>");
        TBL.Append("</table>");

        #endregion

        #region Bind Other Chart Comment
        
        ShowChart("D24");

        /******* Third Chart *********/
        #region Bind D24 Chart
        TBL.Append("<div style=\"float:left;width: 550px;margin-left: 15px;\">");
        //TBL.Append("<td style = \"width:500px; padding-left:10px;\" >");
        TBL.Append("<div style=\"color:Black;font-size:14px;font-weight:bold;margin-top:.65cm;\">" + HeaderValue + "</div>");
        TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:525px;height:190px; \">");
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:23%;  left:46%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 0%;  left: 21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:16%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:15%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:40%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:54%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:37%; left:45%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:56%; left:75%;width:11%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:52%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:76%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:0%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        //TBL.Append("</td>");
        TBL.Append("</div>");
        #endregion


        ShowChart("D02");
        /******* Third Chart *********/
        #region Bind D02 Chart
        //TBL.Append("<td style = \"width:500px; padding-left:10px;\" >");
        TBL.Append("<div style=\"float:left;width:500px;\">");
        TBL.Append("<div style=\"color:Black;font-size:14px;font-weight:bold;margin-top:.65cm;\">" + HeaderValue + "</div>");
        TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:525px;height:190px; \">");
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:23%;  left:46%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 0%;  left: 21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:16%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:15%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:40%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:54%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:37%; left:45%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:56%; left:75%;width:11%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:52%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:76%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:0%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        //TBL.Append("</td>");
        TBL.Append("</div>");
        #endregion

        /************** Forth Chart*********************/
        ShowChart("D60");

        #region Bind D60 Chart
        //TBL.Append("<td style = \"width:500px; padding-left:10px;\" >");
        TBL.Append("<div style=\"float:left;width: 550px;margin-left: 15px;\">");
        TBL.Append("<div style=\"color:Black;font-size:14px;font-weight:bold;margin-top:.65cm;\">" + HeaderValue + "</div>");
        TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:525px;height:190px; \">");
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:23%;  left:46%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 0%;  left: 21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:16%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:15%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:40%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:54%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:37%; left:45%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:56%; left:75%;width:11%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:52%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:76%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:0%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        //TBL.Append("</td>");
        TBL.Append("</div>");
        #endregion

        ShowChart("D03");

        #region Bind D03 Chart
        //TBL.Append("<td style = \"width:500px; padding-left:10px;\" >");
        TBL.Append("<div style=\"float:left;width:500px;\">");
        TBL.Append("<div style=\"color:Black;font-size:14px;font-weight:bold;margin-top:.65cm;\">" + HeaderValue + "</div>");
        TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:525px;height:190px; \">");
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:23%;  left:46%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 0%;  left: 21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:16%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:15%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:40%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:54%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:37%; left:45%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:56%; left:75%;width:11%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:52%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:76%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:0%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        //TBL.Append("</td>");
        TBL.Append("</div>");
        #endregion


        ShowChart("D04");

        #region Bind D04 Chart
        //TBL.Append("<td style = \"width:500px; padding-left:10px;\" >");
        TBL.Append("<div style=\"float:left;width: 550px;margin-left: 15px;\">");
        TBL.Append("<div style=\"color:Black;font-size:14px;font-weight:bold;margin-top:.65cm;\">" + HeaderValue + "</div>");
        TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:525px;height:190px; \">");
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:23%;  left:46%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 0%;  left: 21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:16%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:15%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:40%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:54%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:37%; left:45%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:56%; left:75%;width:11%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:52%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:76%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:0%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        //TBL.Append("</td>");
        TBL.Append("</div>");
        #endregion

        ShowChart("D07");

        #region Bind D07 Chart
        //TBL.Append("<td style = \"width:500px; padding-left:10px;\" >");
        TBL.Append("<div style=\"float:left;width:500px;\">");
        TBL.Append("<div style=\"color:Black;font-size:14px;font-weight:bold;margin-top:.65cm;\">" + HeaderValue + "</div>");
        TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:525px;height:190px; \">");
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:23%;  left:46%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 0%;  left: 21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:16%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:15%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:40%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:54%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:37%; left:45%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:56%; left:75%;width:11%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:52%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:76%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:0%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        //TBL.Append("</td>");
        TBL.Append("</div>");
        #endregion

        ShowChart("D12");

        #region Bind D12 Chart
        //TBL.Append("<td style = \"width:500px; padding-left:10px;\" >");
        TBL.Append("<div style=\"float:left;width: 550px;margin-left: 15px;\">");
        TBL.Append("<div style=\"color:Black;font-size:14px;font-weight:bold;margin-top:.65cm;\">" + HeaderValue + "</div>");
        TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:525px;height:190px; \">");
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:23%;  left:46%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 0%;  left: 21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:16%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:15%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:40%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:54%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:37%; left:45%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:56%; left:75%;width:11%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:52%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:76%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:0%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        //TBL.Append("</td>");
        TBL.Append("</div>");
        #endregion

        ShowChart("D16");

        #region Bind D16 Chart
        //TBL.Append("<td style = \"width:500px; padding-left:10px;\" >");
        TBL.Append("<div style=\"float:left;width:500px;\">");
        TBL.Append("<div style=\"color:Black;font-size:14px;font-weight:bold;margin-top:.65cm;\">" + HeaderValue + "</div>");
        TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:525px;height:190px; \">");
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:23%;  left:46%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 0%;  left: 21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:16%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:15%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:40%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:54%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:37%; left:45%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:56%; left:75%;width:11%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:52%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:76%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:0%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        //TBL.Append("</td>");
        TBL.Append("</div>");
        #endregion

        ShowChart("D30");

        #region Bind D30 Chart
        //TBL.Append("<td style = \"width:500px; padding-left:10px;\" >");
        TBL.Append("<div style=\"float:left;width: 550px;margin-left: 15px;\">");
        TBL.Append("<div style=\"color:Black;font-size:14px;font-weight:bold;margin-top:.65cm;\">" + HeaderValue + "</div>");
        TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:525px;height:190px; \">");
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:23%;  left:46%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 0%;  left: 21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:16%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:15%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:40%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:54%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:37%; left:45%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:56%; left:75%;width:11%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:52%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:76%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:0%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        //TBL.Append("</td>");
        TBL.Append("</div>");
        #endregion

        ShowChart("D45");

        #region Bind D45 Chart

        //TBL.Append("<td style = \"width:500px; padding-left:10px;\" >");
        TBL.Append("<div style=\"float:left;width:500px;\">");
        TBL.Append("<div style=\"color:Black;font-size:14px;font-weight:bold;margin-top:.65cm;\">" + HeaderValue + "</div>");
        TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:525px;height:190px; \">");
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:23%;  left:46%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 0%;  left: 21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:16%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:15%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:40%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:54%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:37%; left:45%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:56%; left:75%;width:11%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:52%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:76%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:0%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        //TBL.Append("</td>");
        TBL.Append("</div>");
        #endregion

        ShowChart("D20");

        #region Bind D20 Chart

        //TBL.Append("<td style = \"width:500px; padding-left:10px;\" >");
        TBL.Append("<div style=\"float:left;width: 550px;margin-left: 15px;\">");
        TBL.Append("<div style=\"color:Black;font-size:14px;font-weight:bold;margin-top:.65cm;\">" + HeaderValue + "</div>");
        TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:525px;height:190px; \">");
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:23%;  left:46%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 0%;  left: 21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:16%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:15%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:40%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:54%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:37%; left:45%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:56%; left:75%;width:11%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:52%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:76%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:0%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        //TBL.Append("</td>");
        TBL.Append("</div>");
        #endregion

        ShowChart("D27");

        #region Bind D27 Chart

        //TBL.Append("<td style = \"width:500px; padding-left:10px;\" >");
        TBL.Append("<div style=\"float:left;width:500px;\">");
        TBL.Append("<div style=\"color:Black;font-size:14px;font-weight:bold;margin-top:.65cm;\">" + HeaderValue + "</div>");
        TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:525px;height:190px; \">");
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:23%;  left:46%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 0%;  left: 21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:16%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:15%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:40%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:54%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:37%; left:45%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:56%; left:75%;width:11%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:52%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:76%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:0%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        //TBL.Append("</td>");
        TBL.Append("</div>");
        #endregion

        ShowChart("D40");

        #region Bind D40 Chart

        //TBL.Append("<td style = \"width:500px; padding-left:10px;\" >");
        TBL.Append("<div style=\"float:left;width: 550px;margin-left: 15px;\">");
        TBL.Append("<div style=\"color:Black;font-size:14px;font-weight:bold;margin-top:.65cm;\">" + HeaderValue + "</div>");
        TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:525px;height:190px; \">");
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:23%;  left:46%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 0%;  left: 21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:16%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:15%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:40%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:54%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:37%; left:45%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:56%; left:75%;width:11%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:52%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:76%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:0%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        //TBL.Append("</td>");
        TBL.Append("</div>");
        #endregion


        ShowChart("D05");

        #region Bind D05 Chart

        //TBL.Append("<td style = \"width:500px; padding-left:10px;\" >");
        TBL.Append("<div style=\"float:left;width:500px;\">");
        TBL.Append("<div style=\"color:Black;font-size:14px;font-weight:bold;margin-top:.65cm;\">" + HeaderValue + "</div>");
        TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:525px;height:190px; \">");
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:23%;  left:46%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 0%;  left: 21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:16%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:15%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:40%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:54%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:37%; left:45%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:56%; left:75%;width:11%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:52%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:76%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:0%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        //TBL.Append("</td>");
        TBL.Append("</div>");
        #endregion

        ShowChart("D06");

        #region Bind D06 Chart

        //TBL.Append("<td style = \"width:500px; padding-left:10px;\" >");
        TBL.Append("<div style=\"float:left;width: 550px;margin-left: 15px;\">");
        TBL.Append("<div style=\"color:Black;font-size:14px;font-weight:bold;margin-top:.65cm;\">" + HeaderValue + "</div>");
        TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:525px;height:190px; \">");
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:23%;  left:46%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 0%;  left: 21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:16%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:15%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:40%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:54%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:37%; left:45%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:56%; left:75%;width:11%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:52%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:76%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:0%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        //TBL.Append("</td>");
        TBL.Append("</div>");
        #endregion

        ShowChart("D08");

        #region Bind D08 Chart

        //TBL.Append("<td style = \"width:500px; padding-left:10px;\" >");
        TBL.Append("<div style=\"float:left;width:500px;\">");
        TBL.Append("<div style=\"color:Black;font-size:14px;font-weight:bold;margin-top:.65cm;\">" + HeaderValue + "</div>");
        TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:525px;height:190px; \">");
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:23%;  left:46%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 0%;  left: 21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:16%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:15%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:40%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:54%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:37%; left:45%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:56%; left:75%;width:11%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:52%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:76%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:0%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        //TBL.Append("</td>");
        TBL.Append("</div>");
        #endregion

        ShowChart("D11");

        #region Bind D11 Chart

        //TBL.Append("<td style = \"width:500px; padding-left:10px;\" >");
        TBL.Append("<div style=\"float:left;width: 550px;margin-left: 15px;\">");
        TBL.Append("<div style=\"color:Black;font-size:14px;font-weight:bold;margin-top:.65cm;\">" + HeaderValue + "</div>");
        TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:525px;height:190px; \">");
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:23%;  left:46%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 0%;  left: 21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:16%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:15%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:40%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:54%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:37%; left:45%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:56%; left:75%;width:11%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:52%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:76%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:0%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        //TBL.Append("</td>");
        TBL.Append("</div>");
        #endregion

        ShowChart("KL");

        #region Bind DKL Chart

        //TBL.Append("<td style = \"width:500px; padding-left:10px;\" >");
        TBL.Append("<div style=\"float:left;width:500px;\">");
        TBL.Append("<div style=\"color:Black;font-size:14px;font-weight:bold;margin-top:.65cm;\">" + HeaderValue + "</div>");
        TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:525px;height:190px; \">");
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:23%;  left:46%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 0%;  left: 21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:16%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:15%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:40%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:54%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:37%; left:45%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:56%; left:75%;width:11%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:52%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:76%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:0%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        //TBL.Append("</td>");
        TBL.Append("</div>");
        #endregion

        ShowChart("MOON");

        #region Bind DMOON Chart

        //TBL.Append("<td style = \"width:500px; padding-left:10px;\" >");
        TBL.Append("<div style=\"float:left;width: 550px;margin-left: 15px;\">");
        TBL.Append("<div style=\"color:Black;font-size:14px;font-weight:bold;margin-top:.65cm;\">" + HeaderValue + "</div>");
        TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:525px;height:190px; \">");
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:23%;  left:46%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 0%;  left: 21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:16%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:15%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:40%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:54%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:37%; left:45%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:56%; left:75%;width:11%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:52%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:76%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:0%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        //TBL.Append("</td>");
        TBL.Append("</div>");
        #endregion

        ShowChart("VENUS");

        #region Bind DVENUS Chart

        //TBL.Append("<td style = \"width:500px; padding-left:10px;\" >");
        TBL.Append("<div style=\"float:left;width:500px;\">");
        TBL.Append("<div style=\"color:Black;font-size:14px;font-weight:bold;margin-top:.65cm;\">" + HeaderValue + "</div>");
        TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:525px;height:190px; \">");
        TBL.Append("<div style=\"position:absolute; top:20%;  left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse1\" style=\"text-align:left; color:#403E3E; font-size:18px;font-weight: bold;\">" + p21 + " As</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:23%;  left:46%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi1\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 3%;  left: 14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p22 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top: 0%;  left: 21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi2\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:16%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p23 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi3\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:15%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p24 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:40%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi4\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:2%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p25 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:54%; left:15%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi5\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:14%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p26 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:63%; left:21%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi6\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:70%; left:40%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p27 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:37%; left:45%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi7\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:87%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p28 + "</span></span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi8\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:67%; left:85%;width:15%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p29 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:56%; left:75%;width:11%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi9\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:45%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p210 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:31%; left:52%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi10\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p211 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:7%; left:76%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi11\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:3%; left:65%;width:30%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"THouse12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\">" + p212 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:0%; left:70%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id = \"TRashi12\" style=\"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        //TBL.Append("</td>");
        TBL.Append("</div><div style='clear:both;'></div>");
        #endregion


        //TBL.Append("</tr>");
        //TBL.Append("</table>");

        #endregion

        if (Flag != "FOR_PDF")
        {
            divShowChart.InnerHtml = TBL.ToString();
        }
    }
    protected void ShowChart(string ChartNo)
    {
        p21 = ""; p22 = ""; p23 = ""; p24 = ""; p25 = ""; p26 = ""; p27 = ""; p28 = ""; p29 = ""; p210 = ""; p211 = ""; p212 = ""; HeaderValue = "";
        j21 = ""; j22 = ""; j23 = ""; j24 = ""; j25 = ""; j26 = ""; j27 = ""; j28 = ""; j29 = ""; j210 = ""; j211 = ""; j212 = "";
        h21 = ""; h22 = ""; h23 = ""; h24 = ""; h25 = ""; h26 = ""; h27 = ""; h28 = ""; h29 = ""; h210 = ""; h211 = ""; r11 = ""; h212 = "";
        r21 = ""; r22 = ""; r23 = ""; r24 = ""; r25 = ""; r26 = ""; r27 = ""; r28 = ""; r29 = ""; r210 = ""; r211 = ""; r212 = "";
        Houes1Value = 0; Houes2Value = 0; Houes3Value = 0; Houes4Value = 0; Houes5Value = 0; Houes6Value = 0; Houes7Value = 0; Houes8Value = 0; Houes9Value = 0; Houes10Value = 0; Houes11Value = 0; Houes12Value = 0;
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
            HeaderValue = ChartNo + " (General Indicative & Shubhatwa & else)";
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
        if (ChartNo == "KL")
        {
            HeaderValue = ChartNo + " (Karakamsha Lagna)";
        }
        if (ChartNo == "MOON")
        {
            HeaderValue = ChartNo ;
        }
        if (ChartNo == "VENUS")
        {
            HeaderValue = ChartNo ;
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
                Houes1Value++;
                string fontsize1 = "18px;";
                if (Houes1Value > 4)
                {
                    fontsize1 = "14px;";
                }
                if (lstPlanetRashiId[i] == "MERCURY")
                {

                    j21 = "<span style='font-size:" + fontsize1 + "color:" + MeColor + "'>Me</span>";
                }

                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j21 = "<span style='font-size:" + fontsize1 + "color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j21 = "<span style='font-size:" + fontsize1 + "color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j21 = "<span style='font-size:" + fontsize1 + "color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j21 = "<span style='font-size:" + fontsize1 + "color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j21 = "<span style='font-size:" + fontsize1 + "color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j21 = "<span style='font-size:" + fontsize1 + "color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j21 = "<span style='font-size:" + fontsize1 + "color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j21 = "<span style='font-size:" + fontsize1 + "color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j21 = "<span style='font-size:" + fontsize1 + "color:" + GkColor + "'>Gk</span>";
                }
                h21 = h21 + j21 + " ";
                if (Houes1Value > 4)
                {
                    h21 = h21.Replace("18px", "14px");
                }
            }
            #endregion
            #region HOUSE2 Condition
            if (h == "HOUSE2")
            {
                Houes2Value++;
                string fontsize2 = "18px;";
                if (Houes2Value > 4)
                {
                    fontsize2 = "14px;";
                }
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j22 = "<span style='font-size:" + fontsize2 + "color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j22 = "<span style='font-size:" + fontsize2 + "color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j22 = "<span style='font-size:" + fontsize2 + "color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j22 = "<span style='font-size:" + fontsize2 + "color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j22 = "<span style='font-size:" + fontsize2 + "color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j22 = "<span style='font-size:" + fontsize2 + "color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j22 = "<span style='font-size:" + fontsize2 + "color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j22 = "<span style='font-size:" + fontsize2 + "color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j22 = "<span style='font-size:" + fontsize2 + "color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j22 = "<span style='font-size:" + fontsize2 + "color:" + GkColor + "'>Gk</span>";
                }
                h22 = h22 + j22 + " ";
                if (Houes2Value > 4)
                {
                    h22 = h22.Replace("18px", "14px");
                }
            }
            #endregion
            #region HOUSE3 Condition
            if (h == "HOUSE3")
            {
                Houes3Value++;
                string fontsize3 = "18px;";
                if (Houes3Value > 4)
                {
                    fontsize3 = "14px;";
                }

                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j23 = "<span style='font-size:" + fontsize3 + "color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j23 = "<span style='font-size:" + fontsize3 + "color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j23 = "<span style='font-size:" + fontsize3 + "color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j23 = "<span style='font-size:" + fontsize3 + "color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j23 = "<span style='font-size:" + fontsize3 + "color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j23 = "<span style='font-size:" + fontsize3 + "color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j23 = "<span style='font-size:" + fontsize3 + "color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j23 = "<span style='font-size:18px;color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j23 = "<span style='font-size:" + fontsize3 + "color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j23 = "<span style='font-size:" + fontsize3 + "color:" + GkColor + "'>Gk</span>";
                }
                h23 = h23 + j23 + " ";
                if (Houes3Value > 4)
                {
                    h23 = h23.Replace("18px", "14px");
                }
            }
            #endregion
            #region HOUSE4 Condition
            if (h == "HOUSE4")
            {
                Houes4Value++;
                string fontsize4 = "18px;";
                if (Houes4Value > 4)
                {
                    fontsize4 = "14px;";
                }
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j24 = "<span style='font-size:" + fontsize4 + "color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j24 = "<span style='font-size:" + fontsize4 + "color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j24 = "<span style='font-size:" + fontsize4 + "color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j24 = "<span style='font-size:" + fontsize4 + "color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j24 = "<span style='font-size:" + fontsize4 + "color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j24 = "<span style='font-size:" + fontsize4 + "color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j24 = "<span style='font-size:" + fontsize4 + "color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j24 = "<span style='font-size:" + fontsize4 + "color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j24 = "<span style='font-size:" + fontsize4 + "color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j24 = "<span style='font-size:" + fontsize4 + "color:" + GkColor + "'>Gk</span>";
                }
                h24 = h24 + j24 + " ";
                if (Houes4Value > 4)
                {
                    h24 = h24.Replace("18px", "14px");
                }
            }
            #endregion
            #region HOUSE5 Condition
            if (h == "HOUSE5")
            {
                Houes5Value++;
                string fontsize5 = "18px;";
                if (Houes5Value > 4)
                {
                    fontsize5 = "14px;";
                }
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j25 = "<span style='font-size:" + fontsize5 + "color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j25 = "<span style='font-size:" + fontsize5 + "color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j25 = "<span style='font-size:" + fontsize5 + "color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j25 = "<span style='font-size:" + fontsize5 + "color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j25 = "<span style='font-size:" + fontsize5 + "color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j25 = "<span style='font-size:" + fontsize5 + "color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j25 = "<span style='font-size:" + fontsize5 + "color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j25 = "<span style='font-size:" + fontsize5 + "color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j25 = "<span style='font-size:" + fontsize5 + "color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j25 = "<span style='font-size:" + fontsize5 + "color:" + GkColor + "'>Gk</span>";
                }
                h25 = h25 + j25 + " ";
                if (Houes5Value > 4)
                {
                    h25 = h25.Replace("18px", "14px");
                }
            }
            #endregion
            #region HOUSE6 Condition
            if (h == "HOUSE6")
            {
                Houes6Value++;
                string fontsize6 = "18px;";
                if (Houes6Value > 4)
                {
                    fontsize6 = "14px;";
                }
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j26 = "<span style='font-size:" + fontsize6 + "color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j26 = "<span style='font-size:" + fontsize6 + "color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j26 = "<span style='font-size:" + fontsize6 + "color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j26 = "<span style='font-size:" + fontsize6 + "color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j26 = "<span style='font-size:" + fontsize6 + "color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j26 = "<span style='font-size:" + fontsize6 + "color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j26 = "<span style='font-size:" + fontsize6 + "color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j26 = "<span style='font-size:" + fontsize6 + "color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j26 = "<span style='font-size:" + fontsize6 + "color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j26 = "<span style='font-size:" + fontsize6 + "color:" + GkColor + "'>Gk</span>";
                }
                h26 = h26 + j26 + " ";
                if (Houes6Value > 4)
                {
                    h26 = h26.Replace("18px", "14px");
                }
            }
            #endregion
            #region HOUSE7 Condition
            if (h == "HOUSE7")
            {
                Houes7Value++;
                string fontsize7 = "18px;";
                if (Houes7Value > 4)
                {
                    fontsize7 = "14px;";
                }
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j27 = "<span style='font-size:" + fontsize7 + "color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j27 = "<span style='font-size:" + fontsize7 + "color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j27 = "<span style='font-size:" + fontsize7 + "color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j27 = "<span style='font-size:" + fontsize7 + "color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j27 = "<span style='font-size:" + fontsize7 + "color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j27 = "<span style='font-size:" + fontsize7 + "color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j27 = "<span style='font-size:" + fontsize7 + "color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j27 = "<span style='font-size:" + fontsize7 + "color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j27 = "<span style='font-size:" + fontsize7 + "color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j27 = "<span style='font-size:" + fontsize7 + "color:" + GkColor + "'>Gk</span>";
                }
                h27 = h27 + j27 + " ";
                if (Houes7Value > 4)
                {
                    h27 = h27.Replace("18px", "14px");
                }
            }
            #endregion
            #region HOUSE8 Condition
            if (h == "HOUSE8")
            {
                Houes8Value++;
                string fontsize8 = "18px;";
                if (Houes8Value > 4)
                {
                    fontsize8 = "14px;";
                }
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j28 = "<span style='font-size:" + fontsize8 + "color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j28 = "<span style='font-size:" + fontsize8 + "color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j28 = "<span style='font-size:" + fontsize8 + "color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j28 = "<span style='font-size:" + fontsize8 + "color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j28 = "<span style='font-size:" + fontsize8 + "color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j28 = "<span style='font-size:" + fontsize8 + "color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j28 = "<span style='font-size:" + fontsize8 + "color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j28 = "<span style='font-size:" + fontsize8 + "color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j28 = "<span style='font-size:" + fontsize8 + "color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j28 = "<span style='font-size:" + fontsize8 + "color:" + GkColor + "'>Gk</span>";
                }
                h28 = h28 + j28 + " ";
                if (Houes8Value > 4)
                {
                    h28 = h28.Replace("18px", "14px");
                }
            }
            #endregion
            #region HOUSE9 Condition
            if (h == "HOUSE9")
            {
                Houes9Value++;
                string fontsize9 = "18px;";
                if (Houes9Value > 4)
                {
                    fontsize9 = "14px;";
                }
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j29 = "<span style='font-size:" + fontsize9 + "color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j29 = "<span style='font-size:" + fontsize9 + "color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j29 = "<span style='font-size:" + fontsize9 + "color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j29 = "<span style='font-size:" + fontsize9 + "color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j29 = "<span style='font-size:" + fontsize9 + "color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j29 = "<span style='font-size:" + fontsize9 + "color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j29 = "<span style='font-size:" + fontsize9 + "color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j29 = "<span style='font-size:" + fontsize9 + "color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j29 = "<span style='font-size:" + fontsize9 + "color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j29 = "<span style='font-size:" + fontsize9 + "color:" + GkColor + "'>Gk</span>";
                }
                h29 = h29 + j29 + " ";
                if (Houes9Value > 4)
                {
                    h29 = h29.Replace("18px", "14px");
                }
            }
            #endregion
            #region HOUSE10 Condition
            if (h == "HOUSE10")
            {
                Houes10Value++;
                string fontsize10 = "18px;";
                if (Houes10Value > 4)
                {
                    fontsize10 = "14px;";
                }
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j210 = "<span style='font-size:" + fontsize10 + "color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j210 = "<span style='font-size:" + fontsize10 + "color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j210 = "<span style='font-size:" + fontsize10 + "color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j210 = "<span style='font-size:" + fontsize10 + "color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j210 = "<span style='font-size:" + fontsize10 + "color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j210 = "<span style='font-size:" + fontsize10 + "color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j210 = "<span style='font-size:" + fontsize10 + "color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j210 = "<span style='font-size:" + fontsize10 + "color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j210 = "<span style='font-size:" + fontsize10 + "color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j210 = "<span style='font-size:" + fontsize10 + "color:" + GkColor + "'>Gk</span>";
                }
                h210 = h210 + j210 + " ";
                if (Houes10Value > 4)
                {
                    h210 = h210.Replace("18px", "14px");
                }
            }
            #endregion
            #region HOUSE11 Condition
            if (h == "HOUSE11")
            {
                Houes11Value++;
                string fontsize11 = "18px;";
                if (Houes11Value > 4)
                {
                    fontsize11 = "14px;";
                }
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j211 = "<span style='font-size:" + fontsize11 + "color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j211 = "<span style='font-size:" + fontsize11 + "color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j211 = "<span style='font-size:" + fontsize11 + "color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j211 = "<span style='font-size:" + fontsize11 + "color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j211 = "<span style='font-size:" + fontsize11 + "color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j211 = "<span style='font-size:" + fontsize11 + "color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j211 = "<span style='font-size:" + fontsize11 + "color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j211 = "<span style='font-size:" + fontsize11 + "color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j211 = "<span style='font-size:" + fontsize11 + "color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j211 = "<span style='font-size:" + fontsize11 + "color:" + GkColor + "'>Gk</span>";
                }
                h211 = h211 + j211 + " ";
                if (Houes11Value > 4)
                {
                    h211 = h211.Replace("18px", "14px");
                }
            }
            #endregion
            #region HOUSE12 Condition
            if (h == "HOUSE12")
            {
                Houes12Value++;
                string fontsize12 = "18px;";
                if (Houes12Value > 4)
                {
                    fontsize12 = "14px;";
                }
                if (lstPlanetRashiId[i] == "MERCURY")
                {
                    j212 = "<span style='font-size:" + fontsize12 + "color:" + MeColor + "'>Me</span>";
                }
                if (lstPlanetRashiId[i] == "JUPITER")
                {
                    j212 = "<span style='font-size:" + fontsize12 + "color:" + Jucolor + "'>Ju</span>";
                }

                if (lstPlanetRashiId[i] == "VENUS")
                {
                    j212 = "<span style='font-size:" + fontsize12 + "color:" + VeColor + "'>Ve</span>";
                }

                if (lstPlanetRashiId[i] == "SATURN")
                {
                    j212 = "<span style='font-size:" + fontsize12 + "color:" + SaColor + "'>Sa</span>";
                }

                if (lstPlanetRashiId[i] == "SUN")
                {
                    j212 = "<span style='font-size:" + fontsize12 + "color:" + Sucolor + "'>Su</span>";
                }

                if (lstPlanetRashiId[i] == "MOON")
                {
                    j212 = "<span style='font-size:" + fontsize12 + "color:" + MoColor + "'>Mo</span>";
                }

                if (lstPlanetRashiId[i] == "MARS")
                {
                    j212 = "<span style='font-size:" + fontsize12 + "color:" + MaColor + "'>Ma</span>";
                }

                if (lstPlanetRashiId[i] == "RAHU")
                {
                    j212 = "<span style='font-size:" + fontsize12 + "color:" + RaColor + "'>Ra</span>";
                }
                if (lstPlanetRashiId[i] == "KETU")
                {
                    j212 = "<span style='font-size:" + fontsize12 + "color:" + KeColor + "'>Ke</span>";
                }

                if (lstPlanetRashiId[i] == "GULIKA")
                {
                    j212 = "<span style='font-size:" + fontsize12 + "color:" + GkColor + "'>Gk</span>";
                }
                h212 = h212 + j212 + " ";
                if (Houes12Value > 4)
                {
                    h212 = h212.Replace("18px", "14px");
                }
            }
            #endregion
        }
        #region Rashi Conditions
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
        #endregion
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
    }

    #endregion
}