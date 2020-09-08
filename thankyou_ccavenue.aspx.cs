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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using NReco.PdfGenerator;

public partial class thankyou_ccavenue : System.Web.UI.Page
{
    #region Declarations
    public string WEBSITEDomain = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    public string SMTPServer = ConfigurationManager.AppSettings["SMTPServer"].ToString();
    ASTROLOGY.classesoracle.main obj_main = new ASTROLOGY.classesoracle.main();
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    ASTROLOGY.classesoracle.myaccount objmc = new ASTROLOGY.classesoracle.myaccount();
    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
    ASTROLOGY.classesoracle.compatibilitymatching objcm = new ASTROLOGY.classesoracle.compatibilitymatching();
    common obj_comm = new common();
    DataSet ds = new DataSet();
    bool flaglagna = false;
    bool flagRemedial = false;
    public string UserName = "";
    bool flagnoanswer = false, MAILSENTTOSUPPORT = false;
    public static int yearantar, yearpratyantar, yearsookshma;
    public string HoraryEndUserAstrologerIDVal = ConfigurationManager.AppSettings["HoraryEndUserAstrologerID"].ToString();
    public string HoraryEndUserAstrologerNameVal = ConfigurationManager.AppSettings["HoraryEndUserAstrologerName"].ToString();
    public string NatalEndUserAstrologerIDVal = ConfigurationManager.AppSettings["NatalEndUserAstrologerID"].ToString();
    public string NatalEndUserAstrologerNameVal = ConfigurationManager.AppSettings["NatalEndUserAstrologerName"].ToString();
    public string WEBSITEDomainVal = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    int yyyy, mm;
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
    List<string> lstHouse = new List<string>();
    List<string> lstRashi = new List<string>();
    List<string> lstPlanets = new List<string>();
    List<string> lstDegree = new List<string>();
    List<string> lstRetro = new List<string>();
    List<string> lstMintues = new List<string>();
    StringBuilder TBL = new StringBuilder();

    public int dd_sys, mm_sys, yyyy_sys, Count = 1;
    public int Houes1Value = 0, Houes2Value = 0, Houes3Value = 0, Houes4Value = 0, Houes5Value = 0, Houes6Value = 0, Houes7Value = 0, Houes8Value = 0, Houes9Value = 0, Houes10Value = 0, Houes11Value = 0, Houes12Value = 0;
    public string j10 = "", h10 = "", j1 = "", h1 = "", RashiID0 = "", RashiID1 = "", j2 = "", h2 = "", RashiID2 = "", RashiID3 = "", RashiID4 = "", RashiID5 = "",
            RashiID6 = "", RashiID7 = "", RashiID8 = "", RashiID9 = "", RashiID10 = "", RashiID11 = "", RashiID12 = "", j3 = "", j4 = "", j5 = "", j6 = "", j7 = "", j8 = "", j9 = "", j11 = "", j12 = "", h3 = "", h4 = "", h5 = "", h6 = "", h7 = "", h8 = "", h9 = "", h11 = "", h12 = "";
    public string Sucolor = "#FF0000", MaColor = "#C74F4F", VeColor = "#FA0095", MeColor = "#087830", Jucolor = "#F25E0A", KeColor = "#708090", MoColor = "#3CA9EE", SaColor = "#00008B", GkColor = "#C71585", RaColor = "#000000", AscColor = "#FF8C00";
    public string clientid = "", emailid = "", fontsize1 = "", flagForPdf = "";
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(thankyou_ccavenue));
        //string system_date = System.DateTime.Now.ToString();
        //String[] split_date = system_date.Split('/');
        //string mm = split_date[0];
        //string dd = split_date[1];
        //string yyyy = split_date[2];
        //string final_date = dd + "/" + mm + "/" + yyyy.Substring(0, 4);
        //dd_sys = Convert.ToInt32(dd);
        //mm_sys = Convert.ToInt32(mm);
        //yyyy_sys = Convert.ToInt32(yyyy.Substring(0, 4));
        if (!IsPostBack)
        {
            //Deepak Add the following 2 lines for refresh the CartId
            string intrandom = Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day) + Convert.ToString(DateTime.Now.Hour) + Convert.ToString(DateTime.Now.Minute) + Convert.ToString(DateTime.Now.Second) + Convert.ToString(DateTime.Now.Millisecond);
            Session["MySessionID"] = intrandom;

            if (Request.QueryString["cartid"] != null && Request.QueryString["cartid"] != null)
            {
                obj_main.check_year_folder(yyyy_sys, mm_sys);
                string cartidval = Request.QueryString["cartid"].ToString().Trim();
                hdnCartId.Value = cartidval;

                DataSet dscid = new DataSet();
                dscid = obj_subs.AstGetCommon(cartidval, "", "", "GET_CLIENT_ID_FROM_CARTID");
                if (dscid.Tables[0].Rows.Count > 0)
                {
                    clientid = dscid.Tables[0].Rows[0]["CLIENT_ID"].ToString();
                }
                dscid.Dispose();

                //string emailid = Request.QueryString["clientemailid"].ToString().Trim();
                //string clientid = Request.QueryString["clientid"].ToString().Trim();
                hdnuserid.Value = clientid;
                txtmail.Value = emailid;

                string groupval = Request.QueryString["group"].ToString().Trim();
                if (groupval == "NATAL")
                {
                    hdngroup.Value = "Astro Envision Natal";
                    hdngroup_u.Value = "Natal";
                    Hastmail.Value = NatalEndUserAstrologerIDVal;
                    Hastname.Value = NatalEndUserAstrologerNameVal;
                }
                else
                {
                    hdngroup.Value = "Astro Envision Horary";
                    hdngroup_u.Value = "Horary";
                    Hastmail.Value = HoraryEndUserAstrologerIDVal;
                    Hastname.Value = HoraryEndUserAstrologerNameVal;
                }
                //GetUserOutputDetais(cartidval, emailid, groupval, clientid);
                Session["MySessionID"] = null;
                Session["MyCartCount"] = null;
                //Session["myquery"] = null;
                //Session["UserEmailID"] = null;
                //Session["UserName"] = null;

                BindCharts("ForPage");
            }
        }

        //string chkAuthDesc = Convert.ToString(Request.Form["AuthDesc"]);
        //string mem_id = Convert.ToString(Request.Form["Order_Id"]);
        //string price = Convert.ToString(Request.Form["Amount"]);
        //if (chkAuthDesc == "Y")
        //{
        //    if (!IsPostBack)
        //    {
        //        if (Request.QueryString["cartid"] != null && Request.QueryString["cartid"] != null)
        //        {
        //            string cartidval = Request.QueryString["cartid"].ToString().Trim();
        //            string emailid = Request.QueryString["clientemailid"].ToString().Trim();
        //            string groupval = Request.QueryString["group"].ToString().Trim();
        //            Update_PaymentStatus(cartidval, emailid, groupval);
        //        }
        //    }
        //}
        //if (chkAuthDesc == "N" || chkAuthDesc == null)
        //{
        //    resultid.InnerHtml = "<table class=\"questionsdiv_gv\" cellspacing=\"0\" border=\"0\" style=\"width: 100%; border-collapse: collapse;\">";
        //    resultid.InnerHtml += "<tr style=\"width: 99%; padding:2% 0% 2% 0%;\">";
        //    resultid.InnerHtml += "<td colspan=\"4\" align=\"center\" valign=\"middle\" style=\"color: #5D5D5D; width: 100%;\"><b>Your transaction is failed.</b></td>";
        //    resultid.InnerHtml += "</tr>";
        //    resultid.InnerHtml += "</table>";
        //}
    }
    #endregion

    #region Export Click
    protected void btnExport_Click(object sender, EventArgs e)
    {
        //string str = ViewState["str"].ToString();
        //Response.ContentType = "application/pdf";
        //Response.AddHeader("content-disposition", "attachment;filename=TestPage.pdf");
        //Response.Cache.SetCacheability(HttpCacheability.NoCache);
        //StringWriter sw = new StringWriter();
        //HtmlTextWriter hw = new HtmlTextWriter(sw);
        //this.Page.RenderControl(hw);
        ////StringReader sr = new StringReader(hw.ToString());
        //StringReader sr = new StringReader(str.ToString());
        //Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
        //HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
        //PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
        //pdfDoc.Open();
        //htmlparser.Parse(sr);
        //pdfDoc.Close();
        //Response.Write(pdfDoc);
        //Response.End();
    }
    #endregion

    #region Print Click
    protected void btnprint_Click(object sender, EventArgs e)
    {
        Session["ctrl"] = Panel1;
        Control ctrl = (Control)Session["ctrl"];
        PrintWebControl(ctrl);
    }
    #endregion

    #region Print Web Control
    public static void PrintWebControl(Control ControlToPrint)
    {
        StringWriter stringWrite = new StringWriter();
        System.Web.UI.HtmlTextWriter htmlWrite = new System.Web.UI.HtmlTextWriter(stringWrite);
        if (ControlToPrint is WebControl)
        {
            Unit w = new Unit(100, UnitType.Percentage);
            ((WebControl)ControlToPrint).Width = w;
        }
        Page pg = new Page();
        pg.EnableEventValidation = false;
        HtmlForm frm = new HtmlForm();
        pg.Controls.Add(frm);
        frm.Attributes.Add("runat", "server");
        frm.Controls.Add(ControlToPrint);
        pg.DesignerInitialize();
        pg.RenderControl(htmlWrite);
        string strHTML = stringWrite.ToString();
        HttpContext.Current.Response.Clear();
        HttpContext.Current.Response.Write(strHTML);
        HttpContext.Current.Response.Write("<script>window.print();</script>");
        HttpContext.Current.Response.End();
    }
    #endregion

    #region Get User Output Details Not Used
    void GetUserOutputDetais(string cartidval, string emailid, string groupval, string clientid)
    {
        DataSet dsd = new DataSet();
        dsd = objmc.Get_Clientdetails(emailid, clientid);
        if (dsd.Tables[0].Rows.Count > 0)
        {
            string cname = dsd.Tables[0].Rows[0]["CLIENT_NAME"].ToString();
            string dob = dsd.Tables[0].Rows[0]["DOB"].ToString();
            dob = DateTime.ParseExact(dob, "dd/MM/yyyy", null).ToString("dd-MMM-yyyy");
            string DayName = dsd.Tables[0].Rows[0]["DAYOB"].ToString();
            string dobtime = dsd.Tables[0].Rows[0]["TOB"].ToString();
            string countryname = dsd.Tables[0].Rows[0]["COUNTRY"].ToString();
            string statename = dsd.Tables[0].Rows[0]["STATE"].ToString();
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
            dobtimeval = DateTime.ParseExact(dobtimeval, "dd/MM/yyyy", null).ToString("dd-MMM-yyyy");
            dobtimeval = dobtimeval.ToUpper();
            string tobval = dsd.Tables[0].Rows[0]["TOB"].ToString();
            string cityobval = dsd.Tables[0].Rows[0]["CITY"].ToString();
            string dayobval = dsd.Tables[0].Rows[0]["DAYOB"].ToString();
            string countryobval = dsd.Tables[0].Rows[0]["COUNTRY"].ToString();
            string stateobval = dsd.Tables[0].Rows[0]["STATE"].ToString();
            string mailid = dsd.Tables[0].Rows[0]["CLIENT_MAIL"].ToString();
            string[] mailidsplit = mailid.Split('-');
            if (mailidsplit.Length > 0)
            {
                mailid = mailidsplit[0];
            }
            string contactno = dsd.Tables[0].Rows[0]["MOBILE_NO"].ToString();
            string lati = dsd.Tables[0].Rows[0]["LATITUDE"].ToString();
            string longi = dsd.Tables[0].Rows[0]["LONGITUDE"].ToString();
            string timezoneval = dsd.Tables[0].Rows[0]["TIMEZONE"].ToString();
            string consval = dsd.Tables[0].Rows[0]["CONSTELLATION"].ToString();
            string rashival = dsd.Tables[0].Rows[0]["RASHI"].ToString();
            string lagnarashival = dsd.Tables[0].Rows[0]["LAGNARASHI"].ToString();
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
            string dinmaan = dsd.Tables[0].Rows[0]["DAY_DURATION"].ToString();
            string ratrimaan = dsd.Tables[0].Rows[0]["NIGHT_DURATION"].ToString();

            DataSet dsq = new DataSet();
            string specific_cat = "";
            dsq = obj_subs.AstGetCommon(cartidval, "", "", "HORARYSELECTEDCAT");
            if (dsq.Tables[0].Rows.Count > 0)
            {
                ViewState["TotalCategory"] = dsq.Tables[0].Rows.Count;
                for (int i = 0; i < dsq.Tables[0].Rows.Count; i++)
                {
                    specific_cat += dsq.Tables[0].Rows[i]["CATNAME"].ToString() + ", ";
                }
                specific_cat = specific_cat.Substring(0, specific_cat.Length - 2);
            }

            resultid.InnerHtml += "<div class='reportfirst'>";
            resultid.InnerHtml += "<h2>" + cname + "</h2>";
            resultid.InnerHtml += "<h3>" + dob + "&nbsp;|&nbsp;" + dobtime + "&nbsp;hrs.&nbsp;|&nbsp;" + statename + "&nbsp;(" + countryname + ")</h4>";
            resultid.InnerHtml += "<span class='reportcat'>Your Report On <h1>" + specific_cat + "</h1></span>";
            resultid.InnerHtml += "</div>";
            resultid.InnerHtml += "<div class='rptprsnl_details'>";
            resultid.InnerHtml += "<span class='rpthead'><h1>Personal Details</h1></span>";
            resultid.InnerHtml += "<table cellspacing='5' cellpadding='5' class='rptprsnl_detailslefttable'>";
            resultid.InnerHtml += "<tr><td class='rptprsnl_detailslefttabletd1'>Client Name</td><td class='rptprsnl_detailslefttabletd2'>&nbsp;:&nbsp;&nbsp;" + cname + "</td></tr>";
            resultid.InnerHtml += "<tr><td class='rptprsnl_detailslefttabletd1'>Gender</td><td class='rptprsnl_detailslefttabletd2'>&nbsp;:&nbsp;&nbsp;" + Gender + "</td></tr>";
            resultid.InnerHtml += "<tr><td class='rptprsnl_detailslefttabletd1'>Date of Birth</td><td class='rptprsnl_detailslefttabletd2'>&nbsp;:&nbsp;&nbsp;" + dobtimeval + " (" + DayName + ")" + "</td></tr>";
            resultid.InnerHtml += "<tr><td class='rptprsnl_detailslefttabletd1'>Time of Birth</td><td class='rptprsnl_detailslefttabletd2'>&nbsp;:&nbsp;&nbsp;" + tobval + "</td></tr>";
            resultid.InnerHtml += "<tr><td class='rptprsnl_detailslefttabletd1'>Place of Birth</td><td class='rptprsnl_detailslefttabletd2'>&nbsp;:&nbsp;&nbsp;" + cityobval + "</td></tr>";
            resultid.InnerHtml += "<tr><td class='rptprsnl_detailslefttabletd1'>Day of Birth</td><td class='rptprsnl_detailslefttabletd2'>&nbsp;:&nbsp;&nbsp;" + dayobval + "</td></tr>";
            resultid.InnerHtml += "<tr><td class='rptprsnl_detailslefttabletd1'>State</td><td class='rptprsnl_detailslefttabletd2'>&nbsp;:&nbsp;&nbsp;" + stateobval + "</td></tr>";
            resultid.InnerHtml += "<tr><td class='rptprsnl_detailslefttabletd1'>Country</td><td class='rptprsnl_detailslefttabletd2'>&nbsp;:&nbsp;&nbsp;" + countryobval + "</td></tr>";
            resultid.InnerHtml += "<tr><td class='rptprsnl_detailslefttabletd1'>Email Id</td><td class='rptprsnl_detailslefttabletd2'>&nbsp;:&nbsp;&nbsp;" + mailid + "</td></tr>";
            resultid.InnerHtml += "<tr><td class='rptprsnl_detailslefttabletd1'>Contact No</td><td class='rptprsnl_detailslefttabletd2'>&nbsp;:&nbsp;&nbsp;" + contactno + "</td></tr>";
            resultid.InnerHtml += "</table>";
            resultid.InnerHtml += "<table cellspacing='5' cellpadding='5' class='rptprsnl_detailsrighttable'>";
            resultid.InnerHtml += "<tr><td class='rptprsnl_detailsrighttabletd1'>Latitude</td><td class='rptprsnl_detailsrighttabletd2'>&nbsp;:&nbsp;&nbsp;" + lati + "</td></tr>";
            resultid.InnerHtml += "<tr><td class='rptprsnl_detailsrighttabletd1'>Longitude</td><td class='rptprsnl_detailsrighttabletd2'>&nbsp;:&nbsp;&nbsp;" + longi + "</td></tr>";
            resultid.InnerHtml += "<tr><td class='rptprsnl_detailsrighttabletd1'>Time Zone</td><td class='rptprsnl_detailsrighttabletd2'>&nbsp;:&nbsp;&nbsp;" + timezoneval + "</td></tr>";
            resultid.InnerHtml += "<tr><td class='rptprsnl_detailsrighttabletd1'>Constellation</td><td class='rptprsnl_detailsrighttabletd2'>&nbsp;:&nbsp;&nbsp;" + consval + "</td></tr>";
            resultid.InnerHtml += "<tr><td class='rptprsnl_detailsrighttabletd1'>Rashi</td><td class='rptprsnl_detailsrighttabletd2'>&nbsp;:&nbsp;&nbsp;" + rashival + "</td></tr>";
            resultid.InnerHtml += "<tr><td class='rptprsnl_detailsrighttabletd1'>Balance Dasha</td><td class='rptprsnl_detailsrighttabletd2'>&nbsp;:&nbsp;" + balancedashaval + "</td></tr>";
            resultid.InnerHtml += "<tr><td class='rptprsnl_detailsrighttabletd1'>Sunrise Time</td><td class='rptprsnl_detailsrighttabletd2'>&nbsp;:&nbsp;" + sunrise + "</td></tr>";
            resultid.InnerHtml += "<tr><td class='rptprsnl_detailsrighttabletd1'>Sunset Time</td><td class='rptprsnl_detailsrighttabletd2'>&nbsp;:&nbsp;" + sunret + "</td></tr>";
            resultid.InnerHtml += "<tr><td class='rptprsnl_detailsrighttabletd1'>Next Day Sunrise Time</td><td class='rptprsnl_detailsrighttabletd2'>&nbsp;:&nbsp;" + sunrisenext + "</td></tr>";
            resultid.InnerHtml += "<tr><td class='rptprsnl_detailsrighttabletd1'>Day Duration / Dinmaan</td><td class='rptprsnl_detailsrighttabletd2'>&nbsp;:&nbsp;" + dinmaan + "</td></tr>";
            resultid.InnerHtml += "<tr><td class='rptprsnl_detailsrighttabletd1'>Night Duration / Ratrimaan</td><td class='rptprsnl_detailsrighttabletd2'>&nbsp;:&nbsp;" + ratrimaan + "</td></tr>";
            resultid.InnerHtml += "</table>";
            resultid.InnerHtml += "</div>";

            int hdnmoondegree_val = 0, hdnmoonminute_val = 0, hdnmoonsecond_val = 0, dobval = 0, mobval = 0, yobval = 0, htobval = 0, mtobval = 0, stobval = 0;
            string chartd01 = dsd.Tables[0].Rows[0]["HOROSCOPE_D01"].ToString();
            if (chartd01 != "")
            {
                string[] chartd01split = chartd01.Split('~');
                for (int i = 0; i < chartd01split.Length; i++)
                {
                    if (chartd01split[i].IndexOf("MOON") > -1)
                    {
                        string[] moonstr = chartd01split[i].Split('/');
                        string moondegreeval = moonstr[3];
                        string[] moondegreeval_split = moondegreeval.Split('.');
                        if (moondegreeval_split.Length > 0)
                        {
                            hdnmoondegree_val = Convert.ToInt32(moondegreeval_split[0]);
                            hdnmoonminute_val = Convert.ToInt32(moondegreeval_split[1]);
                            hdnmoonsecond_val = Convert.ToInt32(moondegreeval_split[2]);
                        }
                    }
                }
            }

            string clientdob = dsd.Tables[0].Rows[0]["DOB"].ToString();
            string[] clientdobsplit = clientdob.Split('/');
            if (clientdobsplit.Length > 0)
            {
                dobval = Convert.ToInt32(clientdobsplit[0]);
                mobval = Convert.ToInt32(clientdobsplit[1]);
                yobval = Convert.ToInt32(clientdobsplit[2]);
            }
            string clienttob = dsd.Tables[0].Rows[0]["TOB"].ToString();
            string[] clienttobsplit = clienttob.Split(':');
            if (clienttobsplit.Length > 0)
            {
                htobval = Convert.ToInt32(clienttobsplit[0]);
                mtobval = Convert.ToInt32(clienttobsplit[1]);
            }
            showdasha(hdnmoondegree_val, hdnmoonminute_val, hdnmoonsecond_val, rashival, dobval, mobval, yobval, htobval, mtobval, stobval);

            //Show_QuestionAnswers(cartidval, emailid, groupval, lagnarashival);
            //Show_QuestionAnswers_Paragraph(cartidval, emailid, groupval, lagnarashival);
            Show_QuestionAnswers_Pointwise_New(cartidval, emailid, groupval, lagnarashival);

            if (flagnoanswer == true && MAILSENTTOSUPPORT == false)
            {
                SendQuestionToAstroSupport(cname, cartidval, clientid, emailid, groupval);
                SendMailToUser(cname, cartidval, clientid, emailid, groupval, Gender);
            }

            if (flaglagna == false)
            {
                Show_Lagna(lagnarashival, "GETLAGNADETAILS");
            }
            else
            {
                lagnadetailsid.Visible = false;
            }
            if (flagRemedial == false)
            {
                Show_Remedial(lagnarashival, "GETREMEDIALDETAILS");
            }
            else
            {
                remedialdetailsid.Visible = false;
            }
        }

        //ViewState["str"] = resultid.InnerHtml;

    }
    #endregion

    #region Show Lagna Not Used
    void Show_Lagna(string lagnarashival, string flag)
    {
        // Lagna Details Start Here //
        DataSet dsld = new DataSet();
        string NoofCat = "1";
        if (Convert.ToInt32(ViewState["TotalCategory"].ToString()) > 0)
        {
            NoofCat = ViewState["TotalCategory"].ToString();
        }
        dsld = showlagnadetails(lagnarashival, NoofCat, flag);
        if (dsld.Tables[0].Rows.Count > 0)
        {
            lagnadetailsid.InnerHtml = "<span class=\"rpthead\"><h1>Your Astro Snapshot</h1></span><div class=\"lagnadetails\">";
            for (int i = 0; i < dsld.Tables[0].Rows.Count; i++)
            {
                int icount = i + 1;
                string lagnastr = dsld.Tables[0].Rows[i]["descclob"].ToString();
                //lagnadetailsid.InnerHtml += "<h2>" + icount + " " + lagnastr + "</h2>";
                lagnadetailsid.InnerHtml += "<h2>" + lagnastr + "</h2>";
            }
        }
        if (dsld.Tables[1].Rows.Count > 0)
        {
            int Total = dsld.Tables[1].Rows.Count;
            ArrayList lstNumbers = RandomNumbers(Total);
            for (int i = 0; i < lstNumbers.Count; i++)
            {
                int icount = i + 1;
                int no = Convert.ToInt32(lstNumbers[i]);
                string lagnastr = dsld.Tables[1].Rows[no]["descclob"].ToString();
                //lagnadetailsid.InnerHtml += "<h2>" + icount + " " + lagnastr + "</h2>";
                lagnadetailsid.InnerHtml += "<h2>" + lagnastr + "</h2>";
            }
        }
        if (dsld.Tables[2].Rows.Count > 0)
        {
            for (int i = 0; i < dsld.Tables[2].Rows.Count; i++)
            {
                int icount = i + 1;
                string lagnastr = dsld.Tables[2].Rows[i]["descclob"].ToString();
                //lagnadetailsid.InnerHtml += "<h2>" + icount + " " + lagnastr + "</h2>";
                lagnadetailsid.InnerHtml += "<h2>" + lagnastr + "</h2>";
            }
            lagnadetailsid.InnerHtml += "</div>";
        }
        dsld.Dispose();
        // Lagna Details End Here //
    }
    #endregion

    #region Show Remedial
    void Show_Remedial(string lagnarashival, string flag)
    {
        // Remedial Details Start Here //
        DataSet dsrd = new DataSet();
        dsrd = showremedialdetails(lagnarashival, "1", flag);
        if (dsrd.Tables[0].Rows.Count > 0)
        {
            remedialdetailsid.InnerHtml = "<span class=\"rpthead\"><h1>Remedial As Per Your Birth Chart</h1></span><div class=\"lagnadetails\">";
            for (int i = 0; i < dsrd.Tables[0].Rows.Count; i++)
            {
                string remedialstr = dsrd.Tables[0].Rows[i]["descclob"].ToString();
                remedialdetailsid.InnerHtml += "<h2><span>Remedial - " + (i + 1) + " : </span>" + remedialstr + "</h2>";
            }
            remedialdetailsid.InnerHtml += "</div>";
        }
        dsrd.Dispose();
        // Remedial Details Start Here //
    }
    #endregion

    #region Remove Dulicate Rows
    public DataTable RemoveDuplicateRows(DataTable dTable, string colName)
    {
        Hashtable hTable = new Hashtable();
        ArrayList duplicateList = new ArrayList();
        foreach (DataRow dtRow in dTable.Rows)
        {
            if (hTable.Contains(dtRow[colName]))
                duplicateList.Add(dtRow);
            else
                hTable.Add(dtRow[colName], string.Empty);
        }
        foreach (DataRow dtRow in duplicateList)
            dTable.Rows.Remove(dtRow);
        return dTable;
    }
    #endregion

    #region Not Used Show Question Answers Pointwise
    void Show_QuestionAnswers_Pointwise_New(string cartidval, string emailid, string groupval, string lagnarashival)
    {
        DataSet dsa = new DataSet();
        DataSet dssa = new DataSet();
        dsa = obj_subs.UpdatePaymentStatus(cartidval, emailid, groupval, "GETOUTPUT_CAT");
        if (dsa.Tables[0].Rows.Count > 0)
        {
            //DataTable dt = dsa.Tables[0];
            //RemoveDuplicateRows(dt, "ANSWER"); 
            outputdetailsid_point.InnerHtml = "<div class='outputdetails_point'>";
            for (int i = 0; i < dsa.Tables[0].Rows.Count; i++)
            {
                string PositiveHtml = "", NegativeHtml = "", RemedialHtml = "";
                string CATID = dsa.Tables[0].Rows[i]["CATID"].ToString();
                string CATNAME = dsa.Tables[0].Rows[i]["CATNAME"].ToString();
                outputdetailsid_point.InnerHtml += "<p class='outputdetails_pcat'>Your Report on - " + CATNAME + "</p><div style='clear: both;'></div>";
                dssa = obj_subs.UpdatePaymentStatus(cartidval, CATID, groupval, "GETOUTPUT_CAT_ANS");
                if (dssa.Tables[0].Rows.Count > 0)
                {
                    for (int j = 0; j < dssa.Tables[0].Rows.Count; j++)
                    {
                        //string CATNAME = dssa.Tables[0].Rows[j]["CATNAME"].ToString();
                        //if (j == 0)
                        //{
                        //    outputdetailsid_point.InnerHtml += "<p class='outputdetails_pcat'>Your Report on - " + CATNAME + "</p>";
                        //}

                        //string QUESTION = dsa.Tables[0].Rows[i]["QUESTION"].ToString();
                        string QUESTIONID = dssa.Tables[0].Rows[j]["QUESTIONID"].ToString();
                        //string GROUP_ID = dsa.Tables[0].Rows[i]["GROUP_ID"].ToString();
                        string ANSWER = dssa.Tables[0].Rows[j]["ANSWER"].ToString();
                        string MailSentToSupport = dssa.Tables[0].Rows[j]["MAIL_SENT_TOSUPPORT"].ToString();
                        if (MailSentToSupport == "T")
                        {
                            MAILSENTTOSUPPORT = true;
                        }
                        //outputdetailsid_para.InnerHtml += "<h2>" + QUESTION + "</h2>";
                        if (ANSWER == "" && groupval == "HORARY")
                        {
                            flagnoanswer = true;
                            ANSWER = "As You have not been able to find the answer for Your chosen category, we will provide the answer of your category by mail within 2-3 working days at no extra cost.Sorry for the inconvenience.";
                        }
                        if (ANSWER == "" && groupval == "NATAL")
                        {
                            if (QUESTIONID == "1297") //Remedials for You?
                            {
                                flagRemedial = true;
                                // Remedial Details Start Here //
                                DataSet dsrd = new DataSet();
                                dsrd = showremedialdetails(lagnarashival, "1", "GETREMEDIALDETAILS");
                                if (dsrd.Tables[0].Rows.Count > 0)
                                {
                                    for (int r = 0; r < dsrd.Tables[0].Rows.Count; r++)
                                    {
                                        string remedialstr = dsrd.Tables[0].Rows[r]["descclob"].ToString();
                                        outputdetailsid_point.InnerHtml += "<h3><span>Remedial - " + (r + 1) + " : </span>" + remedialstr + "</h3>";
                                    }
                                }
                                dsrd.Dispose();
                                // Remedial Details Start Here //
                            }
                            else if (QUESTIONID == "2059") //Know your attributes - 1
                            {
                                flaglagna = true;
                                // Lagna Details Start Here //
                                DataSet dsld = new DataSet();
                                string NoofCat = "1";
                                if (Convert.ToInt32(ViewState["TotalCategory"].ToString()) > 0)
                                {
                                    NoofCat = ViewState["TotalCategory"].ToString();
                                }
                                dsld = showlagnadetails(lagnarashival, NoofCat, "GETALLLAGNADETAILS");
                                if (dsld.Tables[0].Rows.Count > 0)
                                {
                                    for (int s = 0; s < dsld.Tables[0].Rows.Count; s++)
                                    {
                                        int scount = s + 1;
                                        string lagnastr = dsld.Tables[0].Rows[s]["descclob"].ToString();
                                        outputdetailsid_point.InnerHtml += "<h3>" + scount + " " + lagnastr + "</h3>";
                                    }
                                }
                                if (dsld.Tables[1].Rows.Count > 0)
                                {
                                    int Total = dsld.Tables[1].Rows.Count;
                                    ArrayList lstNumbers = RandomNumbers(Total);
                                    for (int ss = 0; ss < lstNumbers.Count; ss++)
                                    {
                                        int sscount = ss + 1;
                                        int no = Convert.ToInt32(lstNumbers[ss]);
                                        string lagnastr = dsld.Tables[1].Rows[no]["descclob"].ToString();
                                        outputdetailsid_point.InnerHtml += "<h3>" + sscount + " " + lagnastr + "</h3>";
                                    }
                                }
                                if (dsld.Tables[2].Rows.Count > 0)
                                {
                                    for (int sss = 0; sss < dsld.Tables[2].Rows.Count; sss++)
                                    {
                                        int ssscount = sss + 1;
                                        string lagnastr = dsld.Tables[2].Rows[sss]["descclob"].ToString();
                                        outputdetailsid_point.InnerHtml += "<h3>" + ssscount + " " + lagnastr + "</h3>";
                                    }
                                }
                                dsld.Dispose();
                                // Lagna Details End Here //
                            }
                            else
                            {
                                flagnoanswer = true;
                                ANSWER = "As You have not been able to find the answer for your chosen category, we will provide the answer of your category by mail within 2-3 working days at no extra cost.Sorry for the inconvenience.";
                            }
                        }

                        string[] ANSWERSplitAll = ANSWER.Split('$');
                        string[] ANSWERSplit = ANSWERSplitAll.Distinct().ToArray();
                        if (ANSWERSplit.Length > 0)
                        {
                            for (int m = 0; m < ANSWERSplit.Length; m++)
                            {
                                string a = "", anext = "";
                                a = ANSWERSplit[m];
                                //deepak comment following 2 lines on 18 December 2019
                                //a = a.Replace("\n", "");
                                //a = Regex.Replace(a, "<.*?>", String.Empty);
                                if (m == ANSWERSplit.Length - 1)
                                {
                                    a = ANSWERSplit[m];
                                    a = a.Replace("\n", "");
                                }
                                else
                                {
                                    anext = ANSWERSplit[m + 1];
                                    //deepak comment following 2 lines on 18 December 2019
                                    //anext = anext.Replace("\n", "");
                                    //anext = Regex.Replace(anext, "<.*?>", String.Empty);
                                }
                                if (a != anext)
                                {
                                    if (a.IndexOf("#P") > -1)
                                    {
                                        PositiveHtml += "<h3>" + a.Replace("#P", "") + "</h3>";
                                    }
                                    if (a.IndexOf("#N") > -1)
                                    {
                                        NegativeHtml += "<h3>" + a.Replace("#N", "") + "</h3>";
                                    }
                                    if (a.IndexOf("#R") > -1)
                                    {
                                        RemedialHtml += "<h3>" + a.Replace("#R", "") + "</h3>";
                                    }
                                    else
                                    {
                                        PositiveHtml += "<h3>" + a.Replace("#P", "") + "</h3>";
                                    }
                                    //outputdetailsid_point.InnerHtml += "<h3>" + a + "</h3>";
                                }
                            }
                        }



                    }

                    if (PositiveHtml != "")
                    {
                        outputdetailsid_point.InnerHtml += "<p class='outputdetails_pcat_type'>Your Positives</p><div style='clear: both;'></div>" + PositiveHtml;
                    }
                    if (NegativeHtml != "")
                    {
                        outputdetailsid_point.InnerHtml += "<p class='outputdetails_pcat_type'>Your Improvement Points</p><div style='clear: both;'></div>" + NegativeHtml;
                    }
                    if (RemedialHtml != "")
                    {
                        outputdetailsid_point.InnerHtml += "<p class='outputdetails_pcat_type'>Your Remedial</p><div style='clear: both;'></div>" + RemedialHtml;
                    }
                }
                //string CATNAME = dsa.Tables[0].Rows[i]["CATNAME"].ToString();
                //string CATNAME_PRE = "";
                //if (i > 0)
                //{
                //    CATNAME_PRE = dsa.Tables[0].Rows[i - 1]["CATNAME"].ToString();
                //}
                //if (CATNAME != CATNAME_PRE)
                //{
                //    if (i == 0)
                //    {
                //        outputdetailsid_point.InnerHtml += "<p class='outputdetails_pcat'>Your Report on - " + CATNAME + "</p>";
                //    }
                //    else
                //    {
                //        outputdetailsid_point.InnerHtml += "<p class='outputdetails_pcat'>Your Report on - " + CATNAME + "</p>";
                //    }
                //}

                ////string QUESTION = dsa.Tables[0].Rows[i]["QUESTION"].ToString();
                //string QUESTIONID = dsa.Tables[0].Rows[i]["QUESTIONID"].ToString();
                ////string GROUP_ID = dsa.Tables[0].Rows[i]["GROUP_ID"].ToString();
                //string ANSWER = dsa.Tables[0].Rows[i]["ANSWER"].ToString();
                //string MailSentToSupport = dsa.Tables[0].Rows[i]["MAIL_SENT_TOSUPPORT"].ToString();
                //if (MailSentToSupport == "T")
                //{
                //    MAILSENTTOSUPPORT = true;
                //}
                ////outputdetailsid_para.InnerHtml += "<h2>" + QUESTION + "</h2>";
                //if (ANSWER == "" && groupval == "HORARY")
                //{
                //    flagnoanswer = true;
                //    ANSWER = "As You have not been able to find the answer for Your chosen category, we will provide the answer of your category by mail within 2-3 working days at no extra cost.Sorry for the inconvenience.";
                //}
                //if (ANSWER == "" && groupval == "NATAL")
                //{
                //    if (QUESTIONID == "1297") //Remedials for You?
                //    {
                //        flagRemedial = true;
                //        // Remedial Details Start Here //
                //        DataSet dsrd = new DataSet();
                //        dsrd = showremedialdetails(lagnarashival, "1", "GETREMEDIALDETAILS");
                //        if (dsrd.Tables[0].Rows.Count > 0)
                //        {
                //            for (int r = 0; r < dsrd.Tables[0].Rows.Count; r++)
                //            {
                //                string remedialstr = dsrd.Tables[0].Rows[r]["descclob"].ToString();
                //                outputdetailsid_point.InnerHtml += "<h3><span>Remedial - " + (r + 1) + " : </span>" + remedialstr + "</h3>";
                //            }
                //        }
                //        dsrd.Dispose();
                //        // Remedial Details Start Here //
                //    }
                //    else if (QUESTIONID == "2059") //Know Your Zodiac / Lagna?
                //    {
                //        flaglagna = true;
                //        // Lagna Details Start Here //
                //        DataSet dsld = new DataSet();
                //        string NoofCat = "1";
                //        if (Convert.ToInt32(ViewState["TotalCategory"].ToString()) > 0)
                //        {
                //            NoofCat = ViewState["TotalCategory"].ToString();
                //        }
                //        dsld = showlagnadetails(lagnarashival, NoofCat, "GETALLLAGNADETAILS");
                //        if (dsld.Tables[0].Rows.Count > 0)
                //        {
                //            for (int s = 0; s < dsld.Tables[0].Rows.Count; s++)
                //            {
                //                int scount = s + 1;
                //                string lagnastr = dsld.Tables[0].Rows[s]["descclob"].ToString();
                //                outputdetailsid_point.InnerHtml += "<h3>" + scount + " " + lagnastr + "</h3>";
                //            }
                //        }
                //        if (dsld.Tables[1].Rows.Count > 0)
                //        {
                //            int Total = dsld.Tables[1].Rows.Count;
                //            ArrayList lstNumbers = RandomNumbers(Total);
                //            for (int ss = 0; ss < lstNumbers.Count; ss++)
                //            {
                //                int sscount = ss + 1;
                //                int no = Convert.ToInt32(lstNumbers[ss]);
                //                string lagnastr = dsld.Tables[1].Rows[no]["descclob"].ToString();
                //                outputdetailsid_point.InnerHtml += "<h3>" + sscount + " " + lagnastr + "</h3>";
                //            }
                //        }
                //        if (dsld.Tables[2].Rows.Count > 0)
                //        {
                //            for (int sss = 0; sss < dsld.Tables[2].Rows.Count; sss++)
                //            {
                //                int ssscount = sss + 1;
                //                string lagnastr = dsld.Tables[2].Rows[sss]["descclob"].ToString();
                //                outputdetailsid_point.InnerHtml += "<h3>" + ssscount + " " + lagnastr + "</h3>";
                //            }
                //        }
                //        dsld.Dispose();
                //        // Lagna Details End Here //
                //    }
                //    else
                //    {
                //        flagnoanswer = true;
                //        ANSWER = "As You have not been able to find the answer for your chosen category, we will provide the answer of your category by mail within 2-3 working days at no extra cost.Sorry for the inconvenience.";
                //    }
                //}

                //string[] ANSWERSplitAll = ANSWER.Split('$');
                //string[] ANSWERSplit = ANSWERSplitAll.Distinct().ToArray();
                //if (ANSWERSplit.Length > 0)
                //{
                //    for (int j = 0; j < ANSWERSplit.Length; j++)
                //    {
                //        string a = "", anext = "";
                //        a = ANSWERSplit[j];
                //        a = a.Replace("\n", "");
                //        a = Regex.Replace(a, "<.*?>", String.Empty);
                //        if (j == ANSWERSplit.Length - 1)
                //        {
                //            a = ANSWERSplit[j];
                //            a = a.Replace("\n", "");
                //        }
                //        else
                //        {
                //            anext = ANSWERSplit[j + 1];
                //            anext = anext.Replace("\n", "");
                //            anext = Regex.Replace(anext, "<.*?>", String.Empty);
                //        }
                //        if (a != anext)
                //        {
                //            if (a.IndexOf("#P") > -1)
                //            {
                //                PositiveHtml += "<h3>" + a + "</h3>";
                //            }
                //            if (a.IndexOf("#N") > -1)
                //            {
                //                NegativeHtml += "<h3>" + a + "</h3>";
                //            }
                //            if (a.IndexOf("#R") > -1)
                //            {
                //                RemedialHtml += "<h3>" + a + "</h3>";
                //            }
                //            //outputdetailsid_point.InnerHtml += "<h3>" + a + "</h3>";
                //        }
                //    }
                //}
            }

            outputdetailsid_point.InnerHtml += "</div>";
        }
        dsa.Dispose();

    }
    #endregion

    #region Show Question Answers Paragraph
    void Show_QuestionAnswers_Paragraph(string cartidval, string emailid, string groupval, string lagnarashival)
    {
        DataSet dsa = new DataSet();
        dsa = obj_subs.UpdatePaymentStatus(cartidval, emailid, groupval, "GETOUTPUT");
        if (dsa.Tables[0].Rows.Count > 0)
        {
            outputdetailsid_para.InnerHtml = "<div class='outputdetails_p'>";
            for (int i = 0; i < dsa.Tables[0].Rows.Count; i++)
            {
                string CATNAME = dsa.Tables[0].Rows[i]["CATNAME"].ToString();
                string CATNAME_PRE = "";
                if (i > 0)
                {
                    CATNAME_PRE = dsa.Tables[0].Rows[i - 1]["CATNAME"].ToString();
                }
                if (CATNAME != CATNAME_PRE)
                {
                    if (i == 0)
                    {
                        outputdetailsid_para.InnerHtml += "<p class='outputdetails_pcat'>Your Report on - " + CATNAME + "</p>";
                    }
                    else
                    {
                        outputdetailsid_para.InnerHtml += "<p class='outputdetails_pcat'>Your Report on - " + CATNAME + "</p>";
                    }
                }

                //string QUESTION = dsa.Tables[0].Rows[i]["QUESTION"].ToString();
                string QUESTIONID = dsa.Tables[0].Rows[i]["QUESTIONID"].ToString();
                //string GROUP_ID = dsa.Tables[0].Rows[i]["GROUP_ID"].ToString();
                string ANSWER = dsa.Tables[0].Rows[i]["ANSWER"].ToString();
                string MailSentToSupport = dsa.Tables[0].Rows[i]["MAIL_SENT_TOSUPPORT"].ToString();
                if (MailSentToSupport == "T")
                {
                    MAILSENTTOSUPPORT = true;
                }
                //outputdetailsid_para.InnerHtml += "<h2>" + QUESTION + "</h2>";
                if (ANSWER == "" && groupval == "HORARY")
                {
                    flagnoanswer = true;
                    ANSWER = "As You have not been able to find the answer for Your chosen category, we will provide the answer of your category by mail within 2-3 working days at no extra cost.Sorry for the inconvenience.";
                }
                if (ANSWER == "" && groupval == "NATAL")
                {
                    if (QUESTIONID == "1297") //Remedials for You?
                    {
                        flagRemedial = true;
                        // Remedial Details Start Here //
                        DataSet dsrd = new DataSet();
                        dsrd = showremedialdetails(lagnarashival, "1", "GETREMEDIALDETAILS");
                        if (dsrd.Tables[0].Rows.Count > 0)
                        {
                            for (int r = 0; r < dsrd.Tables[0].Rows.Count; r++)
                            {
                                string remedialstr = dsrd.Tables[0].Rows[r]["descclob"].ToString();
                                outputdetailsid_para.InnerHtml += "<h3><span>Remedial - " + (r + 1) + " : </span>" + remedialstr + "</h3>";
                            }
                        }
                        dsrd.Dispose();
                        // Remedial Details Start Here //
                    }
                    else if (QUESTIONID == "2059") //Know Your Zodiac / Lagna?
                    {
                        flaglagna = true;
                        // Lagna Details Start Here //
                        DataSet dsld = new DataSet();
                        string NoofCat = "1";
                        if (Convert.ToInt32(ViewState["TotalCategory"].ToString()) > 0)
                        {
                            NoofCat = ViewState["TotalCategory"].ToString();
                        }
                        dsld = showlagnadetails(lagnarashival, NoofCat, "GETALLLAGNADETAILS");
                        if (dsld.Tables[0].Rows.Count > 0)
                        {
                            for (int s = 0; s < dsld.Tables[0].Rows.Count; s++)
                            {
                                int scount = s + 1;
                                string lagnastr = dsld.Tables[0].Rows[s]["descclob"].ToString();
                                //outputdetailsid.InnerHtml += "<h3>" + scount + " " + lagnastr + "</h3>";
                                outputdetailsid_para.InnerHtml += lagnastr;
                            }
                        }
                        if (dsld.Tables[1].Rows.Count > 0)
                        {
                            int Total = dsld.Tables[1].Rows.Count;
                            ArrayList lstNumbers = RandomNumbers(Total);
                            for (int ss = 0; ss < lstNumbers.Count; ss++)
                            {
                                int sscount = ss + 1;
                                int no = Convert.ToInt32(lstNumbers[ss]);
                                string lagnastr = dsld.Tables[1].Rows[no]["descclob"].ToString();
                                //outputdetailsid.InnerHtml += "<h3>" + sscount + " " + lagnastr + "</h3>";
                                outputdetailsid_para.InnerHtml += lagnastr;
                            }
                        }
                        if (dsld.Tables[2].Rows.Count > 0)
                        {
                            for (int sss = 0; sss < dsld.Tables[2].Rows.Count; sss++)
                            {
                                int ssscount = sss + 1;
                                string lagnastr = dsld.Tables[2].Rows[sss]["descclob"].ToString();
                                //outputdetailsid.InnerHtml += "<h3>" + ssscount + " " + lagnastr + "</h3>";
                                outputdetailsid_para.InnerHtml += lagnastr;
                            }
                        }
                        dsld.Dispose();
                        // Lagna Details End Here //
                    }
                    else
                    {
                        flagnoanswer = true;
                        ANSWER = "As You have not been able to find the answer for your chosen category, we will provide the answer of your category by mail within 2-3 working days at no extra cost.Sorry for the inconvenience.";
                    }
                }

                string[] ANSWERSplitAll = ANSWER.Split('$');
                string[] ANSWERSplit = ANSWERSplitAll.Distinct().ToArray();
                if (ANSWERSplit.Length > 0)
                {
                    for (int j = 0; j < ANSWERSplit.Length; j++)
                    {
                        string a = "", anext = "";
                        a = ANSWERSplit[j];
                        a = a.Replace("\n", "");
                        a = Regex.Replace(a, "<.*?>", String.Empty);
                        if (j == ANSWERSplit.Length - 1)
                        {
                            a = ANSWERSplit[j];
                            a = a.Replace("\n", "");
                        }
                        else
                        {
                            anext = ANSWERSplit[j + 1];
                            anext = anext.Replace("\n", "");
                            anext = Regex.Replace(anext, "<.*?>", String.Empty);
                        }
                        if (a != anext)
                        {
                            outputdetailsid_para.InnerHtml += a;
                        }
                    }
                }
            }
            outputdetailsid_para.InnerHtml += "</div>";
            //string finalstr = outputdetailsid.InnerHtml;
            //ViewState["str"] = finalstr;
        }
        dsa.Dispose();

    }
    #endregion

    #region Show Question Answers Pointwise
    void Show_QuestionAnswers_Pointwise(string cartidval, string emailid, string groupval, string lagnarashival)
    {
        DataSet dsa = new DataSet();
        dsa = obj_subs.UpdatePaymentStatus(cartidval, emailid, groupval, "GETOUTPUT");
        if (dsa.Tables[0].Rows.Count > 0)
        {
            outputdetailsid_point.InnerHtml = "<div class='outputdetails_point'>";
            for (int i = 0; i < dsa.Tables[0].Rows.Count; i++)
            {
                string CATNAME = dsa.Tables[0].Rows[i]["CATNAME"].ToString();
                string CATNAME_PRE = "";
                if (i > 0)
                {
                    CATNAME_PRE = dsa.Tables[0].Rows[i - 1]["CATNAME"].ToString();
                }
                if (CATNAME != CATNAME_PRE)
                {
                    if (i == 0)
                    {
                        outputdetailsid_point.InnerHtml += "<p class='outputdetails_pcat'>Your Report on - " + CATNAME + "</p>";
                    }
                    else
                    {
                        outputdetailsid_point.InnerHtml += "<p class='outputdetails_pcat'>Your Report on - " + CATNAME + "</p>";
                    }
                }

                //string QUESTION = dsa.Tables[0].Rows[i]["QUESTION"].ToString();
                string QUESTIONID = dsa.Tables[0].Rows[i]["QUESTIONID"].ToString();
                //string GROUP_ID = dsa.Tables[0].Rows[i]["GROUP_ID"].ToString();
                string ANSWER = dsa.Tables[0].Rows[i]["ANSWER"].ToString();
                string MailSentToSupport = dsa.Tables[0].Rows[i]["MAIL_SENT_TOSUPPORT"].ToString();
                if (MailSentToSupport == "T")
                {
                    MAILSENTTOSUPPORT = true;
                }
                //outputdetailsid_para.InnerHtml += "<h2>" + QUESTION + "</h2>";
                if (ANSWER == "" && groupval == "HORARY")
                {
                    flagnoanswer = true;
                    ANSWER = "As You have not been able to find the answer for Your chosen category, we will provide the answer of your category by mail within 2-3 working days at no extra cost.Sorry for the inconvenience.";
                }
                if (ANSWER == "" && groupval == "NATAL")
                {
                    if (QUESTIONID == "1297") //Remedials for You?
                    {
                        flagRemedial = true;
                        // Remedial Details Start Here //
                        DataSet dsrd = new DataSet();
                        dsrd = showremedialdetails(lagnarashival, "1", "GETREMEDIALDETAILS");
                        if (dsrd.Tables[0].Rows.Count > 0)
                        {
                            for (int r = 0; r < dsrd.Tables[0].Rows.Count; r++)
                            {
                                string remedialstr = dsrd.Tables[0].Rows[r]["descclob"].ToString();
                                outputdetailsid_point.InnerHtml += "<h3><span>Remedial - " + (r + 1) + " : </span>" + remedialstr + "</h3>";
                            }
                        }
                        dsrd.Dispose();
                        // Remedial Details Start Here //
                    }
                    else if (QUESTIONID == "2059") //Know Your Zodiac / Lagna?
                    {
                        flaglagna = true;
                        // Lagna Details Start Here //
                        DataSet dsld = new DataSet();
                        string NoofCat = "1";
                        if (Convert.ToInt32(ViewState["TotalCategory"].ToString()) > 0)
                        {
                            NoofCat = ViewState["TotalCategory"].ToString();
                        }
                        dsld = showlagnadetails(lagnarashival, NoofCat, "GETALLLAGNADETAILS");
                        if (dsld.Tables[0].Rows.Count > 0)
                        {
                            for (int s = 0; s < dsld.Tables[0].Rows.Count; s++)
                            {
                                int scount = s + 1;
                                string lagnastr = dsld.Tables[0].Rows[s]["descclob"].ToString();
                                outputdetailsid_point.InnerHtml += "<h3>" + scount + " " + lagnastr + "</h3>";
                            }
                        }
                        if (dsld.Tables[1].Rows.Count > 0)
                        {
                            int Total = dsld.Tables[1].Rows.Count;
                            ArrayList lstNumbers = RandomNumbers(Total);
                            for (int ss = 0; ss < lstNumbers.Count; ss++)
                            {
                                int sscount = ss + 1;
                                int no = Convert.ToInt32(lstNumbers[ss]);
                                string lagnastr = dsld.Tables[1].Rows[no]["descclob"].ToString();
                                outputdetailsid_point.InnerHtml += "<h3>" + sscount + " " + lagnastr + "</h3>";
                            }
                        }
                        if (dsld.Tables[2].Rows.Count > 0)
                        {
                            for (int sss = 0; sss < dsld.Tables[2].Rows.Count; sss++)
                            {
                                int ssscount = sss + 1;
                                string lagnastr = dsld.Tables[2].Rows[sss]["descclob"].ToString();
                                outputdetailsid_point.InnerHtml += "<h3>" + ssscount + " " + lagnastr + "</h3>";
                            }
                        }
                        dsld.Dispose();
                        // Lagna Details End Here //
                    }
                    else
                    {
                        flagnoanswer = true;
                        ANSWER = "As You have not been able to find the answer for your chosen category, we will provide the answer of your category by mail within 2-3 working days at no extra cost.Sorry for the inconvenience.";
                    }
                }

                string[] ANSWERSplitAll = ANSWER.Split('$');
                string[] ANSWERSplit = ANSWERSplitAll.Distinct().ToArray();
                if (ANSWERSplit.Length > 0)
                {
                    for (int j = 0; j < ANSWERSplit.Length; j++)
                    {
                        string a = "", anext = "";
                        a = ANSWERSplit[j];
                        a = a.Replace("\n", "");
                        a = Regex.Replace(a, "<.*?>", String.Empty);
                        if (j == ANSWERSplit.Length - 1)
                        {
                            a = ANSWERSplit[j];
                            a = a.Replace("\n", "");
                        }
                        else
                        {
                            anext = ANSWERSplit[j + 1];
                            anext = anext.Replace("\n", "");
                            anext = Regex.Replace(anext, "<.*?>", String.Empty);
                        }
                        if (a != anext)
                        {
                            outputdetailsid_point.InnerHtml += "<h3>" + a + "</h3>";
                        }
                    }
                }
            }
            outputdetailsid_point.InnerHtml += "</div>";
        }
        dsa.Dispose();

    }
    #endregion

    #region Show Question Answers 
    void Show_QuestionAnswers(string cartidval, string emailid, string groupval, string lagnarashival)
    {
        DataSet dsa = new DataSet();
        dsa = obj_subs.UpdatePaymentStatus(cartidval, emailid, groupval, "GETOUTPUT");
        if (dsa.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < dsa.Tables[0].Rows.Count; i++)
            {
                string CATNAME = dsa.Tables[0].Rows[i]["CATNAME"].ToString();
                string CATNAME_PRE = "";
                if (i > 0)
                {
                    CATNAME_PRE = dsa.Tables[0].Rows[i - 1]["CATNAME"].ToString();
                }
                if (CATNAME != CATNAME_PRE)
                {
                    if (i == 0)
                    {
                        outputdetailsid.InnerHtml += "<h1>- " + CATNAME + "</h1>";
                    }
                    else
                    {
                        outputdetailsid.InnerHtml += "<h1>- " + CATNAME + "</h1>";
                    }
                }

                string QUESTION = dsa.Tables[0].Rows[i]["QUESTION"].ToString();
                string QUESTIONID = dsa.Tables[0].Rows[i]["QUESTIONID"].ToString();
                string GROUP_ID = dsa.Tables[0].Rows[i]["GROUP_ID"].ToString();
                string ANSWER = dsa.Tables[0].Rows[i]["ANSWER"].ToString();
                string MailSentToSupport = dsa.Tables[0].Rows[i]["MAIL_SENT_TOSUPPORT"].ToString();
                if (MailSentToSupport == "T")
                {
                    MAILSENTTOSUPPORT = true;
                }
                outputdetailsid.InnerHtml += "<h2>" + QUESTION + "</h2>";
                if (ANSWER == "" && groupval == "HORARY")
                {
                    flagnoanswer = true;
                    ANSWER = "As You have not been able to find the answer for Your chosen query, we will provide the answer of your query by mail within 2-3 working days at no extra cost.Sorry for the inconvenience.";
                }
                if (ANSWER == "" && groupval == "NATAL")
                {
                    if (QUESTIONID == "1297") //Remedials for You?
                    {
                        flagRemedial = true;
                        // Remedial Details Start Here //
                        DataSet dsrd = new DataSet();
                        dsrd = showremedialdetails(lagnarashival, "1", "GETREMEDIALDETAILS");
                        if (dsrd.Tables[0].Rows.Count > 0)
                        {
                            for (int r = 0; r < dsrd.Tables[0].Rows.Count; r++)
                            {
                                string remedialstr = dsrd.Tables[0].Rows[r]["descclob"].ToString();
                                outputdetailsid.InnerHtml += "<h3><span>Remedial - " + (r + 1) + " : </span>" + remedialstr + "</h3>";
                            }
                        }
                        dsrd.Dispose();
                        // Remedial Details Start Here //
                    }
                    else if (QUESTIONID == "2059") //Know Your Zodiac / Lagna?
                    {
                        flaglagna = true;
                        // Lagna Details Start Here //
                        DataSet dsld = new DataSet();
                        string NoofCat = "1";
                        if (Convert.ToInt32(ViewState["TotalCategory"].ToString()) > 0)
                        {
                            NoofCat = ViewState["TotalCategory"].ToString();
                        }
                        dsld = showlagnadetails(lagnarashival, NoofCat, "GETALLLAGNADETAILS");
                        if (dsld.Tables[0].Rows.Count > 0)
                        {
                            for (int s = 0; s < dsld.Tables[0].Rows.Count; s++)
                            {
                                int scount = s + 1;
                                string lagnastr = dsld.Tables[0].Rows[s]["descclob"].ToString();
                                //outputdetailsid.InnerHtml += "<h3>" + scount + " " + lagnastr + "</h3>";
                                outputdetailsid.InnerHtml += "<h3>" + lagnastr + "</h3>";
                            }
                        }
                        if (dsld.Tables[1].Rows.Count > 0)
                        {
                            int Total = dsld.Tables[1].Rows.Count;
                            ArrayList lstNumbers = RandomNumbers(Total);
                            for (int ss = 0; ss < lstNumbers.Count; ss++)
                            {
                                int sscount = ss + 1;
                                int no = Convert.ToInt32(lstNumbers[ss]);
                                string lagnastr = dsld.Tables[1].Rows[no]["descclob"].ToString();
                                //outputdetailsid.InnerHtml += "<h3>" + sscount + " " + lagnastr + "</h3>";
                                outputdetailsid.InnerHtml += "<h3>" + lagnastr + "</h3>";
                            }
                        }
                        if (dsld.Tables[2].Rows.Count > 0)
                        {
                            for (int sss = 0; sss < dsld.Tables[2].Rows.Count; sss++)
                            {
                                int ssscount = sss + 1;
                                string lagnastr = dsld.Tables[2].Rows[sss]["descclob"].ToString();
                                //outputdetailsid.InnerHtml += "<h3>" + ssscount + " " + lagnastr + "</h3>";
                                outputdetailsid.InnerHtml += "<h3>" + lagnastr + "</h3>";
                            }
                        }
                        dsld.Dispose();
                        // Lagna Details End Here //
                    }
                    else
                    {
                        flagnoanswer = true;
                        ANSWER = "As You have not been able to find the answer for your chosen question, we will provide the answer of your question by mail within 2-3 working days at no extra cost.Sorry for the inconvenience.";
                    }
                }

                string[] ANSWERSplitAll = ANSWER.Split('$');
                string[] ANSWERSplit = ANSWERSplitAll.Distinct().ToArray();
                if (ANSWERSplit.Length > 0)
                {
                    for (int j = 0; j < ANSWERSplit.Length; j++)
                    {
                        string a = "", anext = "";
                        a = ANSWERSplit[j];
                        a = a.Replace("\n", "");
                        a = Regex.Replace(a, "<.*?>", String.Empty);
                        if (j == ANSWERSplit.Length - 1)
                        {
                            a = ANSWERSplit[j];
                            a = a.Replace("\n", "");
                        }
                        else
                        {
                            anext = ANSWERSplit[j + 1];
                            anext = anext.Replace("\n", "");
                            anext = Regex.Replace(anext, "<.*?>", String.Empty);
                        }
                        if (a != anext)
                        {
                            outputdetailsid.InnerHtml += "<h3>" + a + "</h3>";
                        }
                    }
                }
            }
            //string finalstr = outputdetailsid.InnerHtml;
            //ViewState["str"] = finalstr;
        }
        dsa.Dispose();
    }
    #endregion

    #region Send Question To Astro Support
    void SendQuestionToAstroSupport(string Client_Name, string Cartid_Val, string Client_Id, string Client_EmailId, string Client_Groupval)
    {
        try
        {
            string result = "";
            string dateval = DateTime.Now.ToString("dd-MMM-yyyy");
            string timeval = DateTime.Now.ToString("hh:mm:ss tt");
            string dayval = DateTime.Now.DayOfWeek.ToString();
            string datetimeday = dateval + " , " + timeval + " , " + dayval;
            string Tomailid = "support@astroenvision.com";
            string body = "User Name:- " + Client_Name + ",";
            body += "<br /><br /><a target='_blank' href=\"" + ResolveUrl("" + WEBSITEDomain + "/thankyou_ccavenue.aspx?cartid=" + Cartid_Val + "&clientid=" + Client_Id + "&clientemailid=" + Client_EmailId + "&group=" + Client_Groupval.ToUpper() + "") + "\">click here to show the user's chart</a>";
            body += "<br /><br /><a target='_blank' href=\"" + ResolveUrl("" + WEBSITEDomain + "/enduser_queries.aspx?cartid=" + Cartid_Val + "&clientid=" + Client_Id + "&clientemailid=" + Client_EmailId + "&group=" + Client_Groupval.ToUpper() + "") + "\">click here to send show the user's questions</a>";
            body += "<br /><br />Thanks & Regards";
            body += "<br /><br />(Team Astroenvision)";
            body += "<br /><br /><a href='http://www.astroenvision.com' target='_blank'>www.astroenvision.com</a>";
            body += "<br /><br />Mobile Number: 9555600111, 9555700111";
            result = obj_comm.SendMail(Client_EmailId, Tomailid, "deepaknirwal11@gmail.com", "", "AstroEnvision:- " + Client_Name + " - " + datetimeday, body);
            if (result == "SENT") //FAILED  // SENT
            {
                DataSet dsua = new DataSet();
                dsua = obj_subs.UpdateCommon("", "", Client_EmailId, "", Client_Groupval, Cartid_Val, "", "", "", "", "", "UPDATE_SENTTOSUPPORT");
                if (dsua.Tables[0].Rows.Count > 0)
                {
                }
                dsua.Dispose();
            }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
        finally
        {
        }
    }
    #endregion

    #region Send Mail TO User
    void SendMailToUser(string Client_Name, string Cartid_Val, string Client_Id, string Client_EmailId, string Client_Groupval, string GenderVal)
    {
        try
        {
            string result = "";
            string dateval = DateTime.Now.ToString("dd-MMM-yyyy");
            string timeval = DateTime.Now.ToString("hh:mm:ss tt");
            string dayval = DateTime.Now.DayOfWeek.ToString();
            string datetimeday = dateval + " , " + timeval + " , " + dayval;
            string Frommailid = "support@astroenvision.com";
            string body = "";
            if (GenderVal == "Male")
            {
                body = "Dear Mr. " + Client_Name + ",";
            }
            else
            {
                body = "Dear Ms. " + Client_Name + ",";
            }
            body += "<br /><br />Thank you so much for trusting us and visiting Astroenvison…..";
            body += "<br /><br />We shall workout the predictive answers for your unnattend questions.";
            body += "<br /><br />After deep manual analysis of your Birth Chart, which may take 2-3 working days or even earlier, we shall post the reply on your e-mail.";
            body += "<br /><br />Kindly note that there is no extra cost to this service. We are thankful for keeping patience till then.";
            body += "<br /><br />You may also please ask for  any personalised questions, beyond the scope of Online services provided. Please go to Home Page to Login and click on Consult an Astrologer.";
            //body += "<br /><br />Please feel free to seek any personalised questions, beyond the scope of Online services provided…Click <a target='_blank' href=\"" + ResolveUrl("" + WEBSITEDomain + "/addtoconsult.aspx") + "\">“<b>Consult an Astrologer</b>”</a>";
            body += "<br /><br />Sorry for the inconvenience…";
            body += "<br /><br />Thanks  & Regards";
            body += "<br /><br />(Team Astroenvision)";
            body += "<br /><br /><a href='https://www.astroenvision.com' target='_blank'>www.astroenvision.com</a>";
            body += "<br /><br />Mobile Number: 9555600111, 9555700111";
            result = obj_comm.SendMail(Frommailid, Client_EmailId, "support@astroenvision.com", "", "Astroenvision: Confirmation for seamless support...", body);
            if (result == "SENT")  //FAILED  // SENT
            {
            }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
        finally
        {
        }
    }
    #endregion

    #region Random Numbers
    public ArrayList RandomNumbers(int max)
    {
        // Create an ArrayList object that will hold the numbers
        ArrayList lstNumbers = new ArrayList();
        // The Random class will be used to generate numbers
        Random rndNumber = new Random();

        // Generate a random number between 1 and the Max
        int number = rndNumber.Next(1, max);
        // Add this first random number to the list
        lstNumbers.Add(number);
        // Set a count of numbers to 0 to start
        int count = 0;

        do // Repeatedly...
        {
            // ... generate a random number between 1 and the Max
            number = rndNumber.Next(0, max);

            // If the newly generated number in not yet in the list...
            if (!lstNumbers.Contains(number))
            {
                // ... add it
                lstNumbers.Add(number);
            }

            // Increase the count
            count++;
        } while (count <= 10 * max); // Do that again

        // Once the list is built, return it
        return lstNumbers;
    }
    #endregion

    #region  Show Lagna Details
    public DataSet showlagnadetails(string lagnarashi, string NoofCat, string Flag)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.subscription subobj = new ASTROLOGY.classesoracle.subscription();
            ds = subobj.AstGetEndUserLagna(lagnarashi, "", "", Flag, NoofCat);
        }
        return ds;
    }
    #endregion

    #region Show Remedial Details
    public DataSet showremedialdetails(string lagnarashi, string NoofCat, string Flag)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.subscription subobj = new ASTROLOGY.classesoracle.subscription();
            ds = subobj.AstGetEndUserLagna(lagnarashi, "", "", Flag, NoofCat);
        }
        return ds;
    }
    #endregion

    #region Show Dasha
    public void showdasha(int mdegree, int mminute, int msecond, string mrashi, int dob, int mob, int yob, int htob, int mtob, int stob)
    {
        DataSet ds = new DataSet();
        // Pratyantar Dasha  //Maha Dasha

        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            //ds = country.caldashap(mdegree, mminute, msecond, mrashi, dob, mob, yob, htob, mtob, stob, "hshoradm@horary.com", "Pratyantar Dasha");
            ds = country.caldashap_all(mdegree, mminute, msecond, mrashi, dob, mob, yob, htob, mtob, stob, "hshoradm@horary.com", "Pratyantar Dasha");
        }
        //dasha.InnerHtml = ds.Tables[0].Rows[0]["BALANCEDASHA"].ToString();
        if (ds.Tables[0].Rows.Count > 0)
        {
            string balancedasha = ds.Tables[0].Rows[0]["BALANCEDASHA"].ToString();
            balancedasha = balancedasha.Replace("Balance Of Dasha :", "").Trim();
            balancedasha_id.InnerHtml = "Balance Of Dasha Period - <font color=\"#6D6D6D\">" + balancedasha + "</font>";
            string[] balancedashasplit = balancedasha.Split(' ');
            {
                if (balancedashasplit.Length > 0)
                {
                    yyyy = int.Parse(balancedashasplit[2]);
                    mm = int.Parse(balancedashasplit[4]);
                }
            }
        }

        if (ds.Tables[4].Rows.Count > 0)
        {
            mahadasha_id.InnerHtml = "<table class=\"tftable\" border=\"1\">";
            mahadasha_id.InnerHtml += "<tr><th>Mahadasha</th><th>Years</th><th>Beginning</th><th>Ending</th></tr>";
            for (int i = 0; i < ds.Tables[4].Rows.Count; i++)
            {
                string planet1 = ds.Tables[4].Rows[i]["PLANET"].ToString();
                string yearval = ds.Tables[4].Rows[i]["YEARS"].ToString();
                yearval = yearval.Replace("Year", "");
                string starttime = ds.Tables[4].Rows[i]["Start Time"].ToString();
                string[] starttimesplit = starttime.Split(' ');
                if (starttimesplit.Length > 0)
                {
                    starttime = starttimesplit[0];
                }
                string endtime = ds.Tables[4].Rows[i]["End Time"].ToString();
                string[] endtimesplit = endtime.Split(' ');
                if (endtimesplit.Length > 0)
                {
                    endtime = endtimesplit[0];
                }
                mahadasha_id.InnerHtml += "<tr>";
                mahadasha_id.InnerHtml += "<td>" + planet1 + "</td>";
                mahadasha_id.InnerHtml += "<td>" + yearval + "</td>";
                mahadasha_id.InnerHtml += "<td>" + starttime + "</td>";
                mahadasha_id.InnerHtml += "<td>" + endtime + "</td>";
                mahadasha_id.InnerHtml += "</tr>";
            }
            mahadasha_id.InnerHtml += "</table>";
        }


        if (ds.Tables[3].Rows.Count > 0)
        {
            int flagi;
            int ds4i = 0;
            yearantar = yob + 50;
            //antardasha_id.InnerHtml = "<table class=\"tftable2\" border=\"1\">";
            //antardasha_id.InnerHtml += "<tr><th>Mahadasha</th><th>Antardasha</th><th style='width:10px;'>Yr.</th><th style='width:10px;'>Mo.</th><th style='width:10px;'>Da.</th><th>Beginning</th><th>Ending</th></tr>";
            for (int i = 0; i < ds.Tables[3].Rows.Count; i++)
            {
                string planet1 = ds.Tables[3].Rows[i]["PLANET"].ToString();
                //planet1 = planet1.Replace("MARS", "Mar").Replace("RAHU", "Rah").Replace("JUPITER", "Jup").Replace("SATURN", "Sat").Replace("MERCURY", "Mer").Replace("KETU", "Ket").Replace("VENUS", "Ven").Replace("SUN", "Sun").Replace("MOON", "Mo");
                string planet2 = ds.Tables[3].Rows[i]["PLANET1"].ToString();
                //planet2 = planet2.Replace("MARS", "Mar").Replace("RAHU", "Rah").Replace("JUPITER", "Jup").Replace("SATURN", "Sat").Replace("MERCURY", "Mer").Replace("KETU", "Ket").Replace("VENUS", "Ven").Replace("SUN", "Sun").Replace("MOON", "Mo");
                string yearval = ds.Tables[3].Rows[i]["YEARS"].ToString();
                yearval = yearval.Replace("Year", "");
                string monthval = ds.Tables[3].Rows[i]["MONTHS"].ToString();
                monthval = monthval.Replace("Month", "");
                string dayval = ds.Tables[3].Rows[i]["DAYS"].ToString();
                dayval = dayval.Replace("Day", "");
                string starttime = ds.Tables[3].Rows[i]["Start Time"].ToString();
                string[] starttimesplit = starttime.Split(' ');
                if (starttimesplit.Length > 0)
                {
                    starttime = starttimesplit[0];
                }
                string endtime = ds.Tables[3].Rows[i]["End Time"].ToString();
                string[] endtimesplit = endtime.Split(' ');
                if (endtimesplit.Length > 0)
                {
                    endtime = endtimesplit[0];
                }
                string[] endyearsplit = endtime.Split('-');
                //if (yearantar < Convert.ToInt32(endyearsplit[2]))
                //{
                //    goto Outer;
                //}

                flagi = i % 9;
                if (i == 0)
                {
                    string mahadashaperiod = ds.Tables[4].Rows[ds4i]["YEARS"].ToString();
                    mahadashaperiod = mahadashaperiod.Replace("Year", "");

                    string dashafromto = "From 0y to " + yyyy.ToString() + "y " + mm.ToString() + "m";

                    antardasha_id.InnerHtml = "<table class=\"tftable2\" border=\"1\">";
                    antardasha_id.InnerHtml += "<tr><th class=\"tftable2th\" colspan='6'>" + planet1 + " (" + mahadashaperiod + " Year) - " + dashafromto + "</th></tr>";
                    //antardasha_id.InnerHtml += "<tr><th>Mahadasha</th><th>Antardasha</th><th style='width:10px;'>Yr.</th><th style='width:10px;'>Mo.</th><th style='width:10px;'>Da.</th><th>Beginning</th><th>Ending</th></tr>";
                    antardasha_id.InnerHtml += "<tr><th>Antar</th><th style='width:10px;'>Yr.</th><th style='width:10px;'>Mo.</th><th style='width:10px;'>Da.</th><th>Beginning</th><th>Ending</th></tr>";
                    antardasha_id.InnerHtml += "<tr>";
                    //antardasha_id.InnerHtml += "<td>" + planet1 + "</td>";
                    antardasha_id.InnerHtml += "<td>" + planet2 + "</td>";
                    antardasha_id.InnerHtml += "<td>" + yearval + "</td>";
                    antardasha_id.InnerHtml += "<td>" + monthval + "</td>";
                    antardasha_id.InnerHtml += "<td>" + dayval + "</td>";
                    antardasha_id.InnerHtml += "<td>" + starttime + "</td>";
                    antardasha_id.InnerHtml += "<td>" + endtime + "</td>";
                    antardasha_id.InnerHtml += "</tr>";
                }
                else if (flagi == 0)
                {
                    ds4i++;
                    string mahadashaperiod = ds.Tables[4].Rows[ds4i]["YEARS"].ToString();
                    mahadashaperiod = mahadashaperiod.Replace("Year", "");

                    antardasha_id.InnerHtml += "</table>";
                    if (i != ds.Tables[3].Rows.Count)
                    {

                        string dashafromto = "From " + yyyy + "y" + mm.ToString() + "m to " + (yyyy + int.Parse(mahadashaperiod)) + "y" + mm.ToString() + "m";
                        yyyy = yyyy + int.Parse(mahadashaperiod);

                        antardasha_id.InnerHtml += "<table class=\"tftable2\" border=\"1\">";
                        antardasha_id.InnerHtml += "<tr><th class=\"tftable2th\" colspan='6'>" + planet1 + " (" + mahadashaperiod + " Year) - " + dashafromto + "</th></tr>";
                        //antardasha_id.InnerHtml += "<tr><th>Mahadasha</th><th>Antardasha</th><th style='width:10px;'>Yr.</th><th style='width:10px;'>Mo.</th><th style='width:10px;'>Da.</th><th>Beginning</th><th>Ending</th></tr>";
                        antardasha_id.InnerHtml += "<tr><th>Antar</th><th style='width:10px;'>Yr.</th><th style='width:10px;'>Mo.</th><th style='width:10px;'>Da.</th><th>Beginning</th><th>Ending</th></tr>";
                        antardasha_id.InnerHtml += "<tr>";
                        //antardasha_id.InnerHtml += "<td>" + planet1 + "</td>";
                        antardasha_id.InnerHtml += "<td>" + planet2 + "</td>";
                        antardasha_id.InnerHtml += "<td>" + yearval + "</td>";
                        antardasha_id.InnerHtml += "<td>" + monthval + "</td>";
                        antardasha_id.InnerHtml += "<td>" + dayval + "</td>";
                        antardasha_id.InnerHtml += "<td>" + starttime + "</td>";
                        antardasha_id.InnerHtml += "<td>" + endtime + "</td>";
                        antardasha_id.InnerHtml += "</tr>";
                    }
                }
                else if (flagi > 0)
                {
                    if (i == ds.Tables[3].Rows.Count - 1)
                    {
                        antardasha_id.InnerHtml += "<tr>";
                        //antardasha_id.InnerHtml += "<td>" + planet1 + "</td>";
                        antardasha_id.InnerHtml += "<td>" + planet2 + "</td>";
                        antardasha_id.InnerHtml += "<td>" + yearval + "</td>";
                        antardasha_id.InnerHtml += "<td>" + monthval + "</td>";
                        antardasha_id.InnerHtml += "<td>" + dayval + "</td>";
                        antardasha_id.InnerHtml += "<td>" + starttime + "</td>";
                        antardasha_id.InnerHtml += "<td>" + endtime + "</td>";
                        antardasha_id.InnerHtml += "</tr>";
                        antardasha_id.InnerHtml += "</table>";
                    }
                    else
                    {
                        antardasha_id.InnerHtml += "<tr>";
                        //antardasha_id.InnerHtml += "<td>" + planet1 + "</td>";
                        antardasha_id.InnerHtml += "<td>" + planet2 + "</td>";
                        antardasha_id.InnerHtml += "<td>" + yearval + "</td>";
                        antardasha_id.InnerHtml += "<td>" + monthval + "</td>";
                        antardasha_id.InnerHtml += "<td>" + dayval + "</td>";
                        antardasha_id.InnerHtml += "<td>" + starttime + "</td>";
                        antardasha_id.InnerHtml += "<td>" + endtime + "</td>";
                        antardasha_id.InnerHtml += "</tr>";
                    }
                }

            }
            //Outer:
            //antardasha_id.InnerHtml += "</table>";
            //antardasha_id.InnerHtml += "<div style='clear: both;'></div>";
        }
        if (ds.Tables[2].Rows.Count > 0)
        {
            int flagii;
            yearpratyantar = yob + 50;
            //pratyantardasha_id.InnerHtml = "<table class=\"tftable3\" border=\"1\">";
            //pratyantardasha_id.InnerHtml += "<tr><th>Mahadasha</th><th>Antardasha</th><th>Pratyantardasha</th><th style='width:10px;'>Mo.</th><th style='width:10px;'>Da.</th><th>Beginning</th><th>Ending</th></tr>";
            for (int i = 0; i < ds.Tables[2].Rows.Count; i++)
            {
                string planet1 = ds.Tables[2].Rows[i]["PLANET"].ToString();
                //planet1 = planet1.Replace("MARS", "Mar").Replace("RAHU", "Rah").Replace("JUPITER", "Jup").Replace("SATURN", "Sat").Replace("MERCURY", "Mer").Replace("KETU", "Ket").Replace("VENUS", "Ven").Replace("SUN", "Sun").Replace("MOON", "Mo");
                string planet2 = ds.Tables[2].Rows[i]["PLANET1"].ToString();
                //planet2 = planet2.Replace("MARS", "Mar").Replace("RAHU", "Rah").Replace("JUPITER", "Jup").Replace("SATURN", "Sat").Replace("MERCURY", "Mer").Replace("KETU", "Ket").Replace("VENUS", "Ven").Replace("SUN", "Sun").Replace("MOON", "Mo");
                string planet3 = ds.Tables[2].Rows[i]["PLANET2"].ToString();
                // planet3 = planet3.Replace("MARS", "Mar").Replace("RAHU", "Rah").Replace("JUPITER", "Jup").Replace("SATURN", "Sat").Replace("MERCURY", "Mer").Replace("KETU", "Ket").Replace("VENUS", "Ven").Replace("SUN", "Sun").Replace("MOON", "Mo");
                //string yearval = ds.Tables[2].Rows[i]["YEARS"].ToString();
                //yearval = yearval.Replace("Year", "");
                string monthval = ds.Tables[2].Rows[i]["MONTHS"].ToString();
                monthval = monthval.Replace("Month", "");
                string dayval = ds.Tables[2].Rows[i]["DAYS"].ToString();
                dayval = dayval.Replace("Day", "");
                string starttime = ds.Tables[2].Rows[i]["Start Time"].ToString();
                string[] starttimesplit = starttime.Split(' ');
                if (starttimesplit.Length > 0)
                {
                    starttime = starttimesplit[0];
                }
                string endtime = ds.Tables[2].Rows[i]["End Time"].ToString();
                string[] endtimesplit = endtime.Split(' ');
                if (endtimesplit.Length > 0)
                {
                    endtime = endtimesplit[0];
                }
                string[] endyearsplit = endtime.Split('-');
                //if (yearpratyantar < Convert.ToInt32(endyearsplit[2]))
                //{
                //    goto Outer;
                //}

                flagii = i % 9;
                if (i == 0)
                {
                    pratyantardasha_id.InnerHtml = "<table class=\"tftable3\" border=\"1\">";
                    pratyantardasha_id.InnerHtml += "<tr><th class=\"tftable3th\" colspan='5'>" + planet1 + " - " + planet2 + "</th></tr>";
                    //pratyantardasha_id.InnerHtml += "<tr><th>Mahadasha</th><th>Antardasha</th><th>Pratyantardasha</th><th style='width:10px;'>Mo.</th><th style='width:10px;'>Da.</th><th>Beginning</th><th>Ending</th></tr>";
                    pratyantardasha_id.InnerHtml += "<tr><th>Pratyantar</th><th style='width:10px;'>Mo.</th><th style='width:10px;'>Da.</th><th>Beginning</th><th>Ending</th></tr>";
                    pratyantardasha_id.InnerHtml += "<tr>";
                    //pratyantardasha_id.InnerHtml += "<td>" + planet1 + "</td>";
                    //pratyantardasha_id.InnerHtml += "<td>" + planet2 + "</td>";
                    pratyantardasha_id.InnerHtml += "<td>" + planet3 + "</td>";
                    //pratyantardasha_id.InnerHtml += "<td>" + yearval + "</td>";
                    pratyantardasha_id.InnerHtml += "<td>" + monthval + "</td>";
                    pratyantardasha_id.InnerHtml += "<td>" + dayval + "</td>";
                    pratyantardasha_id.InnerHtml += "<td>" + starttime + "</td>";
                    pratyantardasha_id.InnerHtml += "<td>" + endtime + "</td>";
                    pratyantardasha_id.InnerHtml += "</tr>";
                }
                else if (flagii == 0)
                {
                    pratyantardasha_id.InnerHtml += "</table>";
                    if (i != ds.Tables[2].Rows.Count)
                    {
                        pratyantardasha_id.InnerHtml += "<table class=\"tftable3\" border=\"1\">";
                        pratyantardasha_id.InnerHtml += "<tr><th class=\"tftable3th\" colspan='5'>" + planet1 + " - " + planet2 + "</th></tr>";
                        //pratyantardasha_id.InnerHtml += "<tr><th>Mahadasha</th><th>Antardasha</th><th>Pratyantardasha</th><th style='width:10px;'>Mo.</th><th style='width:10px;'>Da.</th><th>Beginning</th><th>Ending</th></tr>";
                        pratyantardasha_id.InnerHtml += "<tr><th>Pratyantar</th><th style='width:10px;'>Mo.</th><th style='width:10px;'>Da.</th><th>Beginning</th><th>Ending</th></tr>";
                        pratyantardasha_id.InnerHtml += "<tr>";
                        //pratyantardasha_id.InnerHtml += "<td>" + planet1 + "</td>";
                        //pratyantardasha_id.InnerHtml += "<td>" + planet2 + "</td>";
                        pratyantardasha_id.InnerHtml += "<td>" + planet3 + "</td>";
                        //pratyantardasha_id.InnerHtml += "<td>" + yearval + "</td>";
                        pratyantardasha_id.InnerHtml += "<td>" + monthval + "</td>";
                        pratyantardasha_id.InnerHtml += "<td>" + dayval + "</td>";
                        pratyantardasha_id.InnerHtml += "<td>" + starttime + "</td>";
                        pratyantardasha_id.InnerHtml += "<td>" + endtime + "</td>";
                        pratyantardasha_id.InnerHtml += "</tr>";
                    }

                }
                else if (flagii > 0)
                {
                    if (i == ds.Tables[2].Rows.Count - 1)
                    {
                        pratyantardasha_id.InnerHtml += "<tr>";
                        //pratyantardasha_id.InnerHtml += "<td>" + planet1 + "</td>";
                        //pratyantardasha_id.InnerHtml += "<td>" + planet2 + "</td>";
                        pratyantardasha_id.InnerHtml += "<td>" + planet3 + "</td>";
                        //pratyantardasha_id.InnerHtml += "<td>" + yearval + "</td>";
                        pratyantardasha_id.InnerHtml += "<td>" + monthval + "</td>";
                        pratyantardasha_id.InnerHtml += "<td>" + dayval + "</td>";
                        pratyantardasha_id.InnerHtml += "<td>" + starttime + "</td>";
                        pratyantardasha_id.InnerHtml += "<td>" + endtime + "</td>";
                        pratyantardasha_id.InnerHtml += "</tr>";
                        pratyantardasha_id.InnerHtml += "</table>";
                    }
                    else
                    {
                        pratyantardasha_id.InnerHtml += "<tr>";
                        //pratyantardasha_id.InnerHtml += "<td>" + planet1 + "</td>";
                        //pratyantardasha_id.InnerHtml += "<td>" + planet2 + "</td>";
                        pratyantardasha_id.InnerHtml += "<td>" + planet3 + "</td>";
                        //pratyantardasha_id.InnerHtml += "<td>" + yearval + "</td>";
                        pratyantardasha_id.InnerHtml += "<td>" + monthval + "</td>";
                        pratyantardasha_id.InnerHtml += "<td>" + dayval + "</td>";
                        pratyantardasha_id.InnerHtml += "<td>" + starttime + "</td>";
                        pratyantardasha_id.InnerHtml += "<td>" + endtime + "</td>";
                        pratyantardasha_id.InnerHtml += "</tr>";
                    }
                }

            }
            //Outer:
            //    pratyantardasha_id.InnerHtml += "</table>";
        }
        //if (ds.Tables[1].Rows.Count > 0)
        //{
        //    yearsookshma = yob + 15;
        //    sookshmadasha_id.InnerHtml = "<table class=\"tftable2\" border=\"1\">";
        //    sookshmadasha_id.InnerHtml += "<tr><th>Maha Dasha</th><th>Antar Dasha</th><th>Pratyantar Dasha</th><th>Sookshma Dasha</th><th>Months</th><th>Days</th><th>Beginning</th><th>Ending</th></tr>";
        //    for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
        //    {
        //        string planet1 = ds.Tables[1].Rows[i]["PLANET"].ToString();
        //        string planet2 = ds.Tables[1].Rows[i]["PLANET1"].ToString();
        //        string planet3 = ds.Tables[1].Rows[i]["PLANET2"].ToString();
        //        string planet4 = ds.Tables[1].Rows[i]["PLANET3"].ToString();
        //        //string yearval = ds.Tables[1].Rows[i]["YEARS"].ToString();
        //        //yearval = yearval.Replace("Year", "");
        //        string monthval = ds.Tables[1].Rows[i]["MONTHS"].ToString();
        //        monthval = monthval.Replace("Month", "");
        //        string dayval = ds.Tables[1].Rows[i]["DAYS"].ToString();
        //        dayval = dayval.Replace("Day", "");
        //        string starttime = ds.Tables[1].Rows[i]["Start Time"].ToString();
        //        string[] starttimesplit = starttime.Split(' ');
        //        if (starttimesplit.Length > 0)
        //        {
        //            starttime = starttimesplit[0];
        //        }
        //        string endtime = ds.Tables[1].Rows[i]["End Time"].ToString();
        //        string[] endtimesplit = endtime.Split(' ');
        //        if (endtimesplit.Length > 0)
        //        {
        //            endtime = endtimesplit[0];
        //        }
        //        string[] endyearsplit = endtime.Split('-');
        //        if (yearpratyantar < Convert.ToInt32(endyearsplit[2]))
        //        {
        //            goto Outer;
        //        }
        //        sookshmadasha_id.InnerHtml += "<tr>";
        //        sookshmadasha_id.InnerHtml += "<td>" + planet1 + "</td>";
        //        sookshmadasha_id.InnerHtml += "<td>" + planet2 + "</td>";
        //        sookshmadasha_id.InnerHtml += "<td>" + planet3 + "</td>";
        //        sookshmadasha_id.InnerHtml += "<td>" + planet4 + "</td>";
        //        //sookshmadasha_id.InnerHtml += "<td>" + yearval + "</td>";
        //        sookshmadasha_id.InnerHtml += "<td>" + monthval + "</td>";
        //        sookshmadasha_id.InnerHtml += "<td>" + dayval + "</td>";
        //        sookshmadasha_id.InnerHtml += "<td>" + starttime + "</td>";
        //        sookshmadasha_id.InnerHtml += "<td>" + endtime + "</td>";
        //        sookshmadasha_id.InnerHtml += "</tr>";
        //    }
        //Outer:
        //    sookshmadasha_id.InnerHtml += "</table>";
        //}
        ds.Dispose();
        return;
    }
    #endregion

    #region Grid Events
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.RowIndex == 0)
                e.Row.Style.Add("height", "50px");
        }
    }
    #endregion

    #region Ajax Method
    [Ajax.AjaxMethod]
    public DataSet bindrashi(string vishu)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_rashi(vishu);
        }
        return ds;
    }
    [Ajax.AjaxMethod]
    public DataSet bindhouse(string vishu)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_house(vishu);
        }
        return ds;
    }
    [Ajax.AjaxMethod]
    public DataSet binddegree(string vishu)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_degree(vishu);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet bindseconds(string vishu)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_degree(vishu);
        }
        return ds;
    }
    [Ajax.AjaxMethod]
    public DataSet bindminutes(string vishu)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_degree(vishu);
        }
        return ds;
    }
    [Ajax.AjaxMethod]
    public DataSet bindretrograde(string vishu)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_retrograde(vishu);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet bindconstelation(string vishu)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_constellation(vishu);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet searchclientid(string clientname, string astroname, string astid1, string group, string groupu, string clientid)
    {

        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.searchclientid(clientname, astroname, astid1, group, groupu, clientid);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    #endregion

    #region Vargas Value
    public DataSet vargasvalue(string vargas)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.vargas(vargas);
        }
        return ds;
    }
    #endregion

    #region  Generate PDF Click
    protected void lnkGeneratePDF_Click(object sender, EventArgs e)
    {
        BindCharts("");
        divShowChart.InnerHtml = TBL.ToString();

        TBL.Append("<div style =\"float: left;width: 100%;margin: 1% 0% 1% 0%;padding: 0.5em 0em 0em 0em;text-align: center;border-top-color: #F4600A;border-top-style: dashed;border-top-width: medium;font-family:Roboto,sans-serif;\">");
        TBL.Append("<img style='width: 50px;' src=\"" + WEBSITEDomainVal + "/Image/om_small.png\" alt=\"Astro Envision\" title=\"Astro Envision\" />");
        TBL.Append("<h1 style='float: left;padding: 1% 0% 0.5% 0%;margin: 0%;width: 100%;font-size: 1.5em;color: #F4600A;font-weight: bold;'>Thanks for using Astro Envision services</h1>");
        TBL.Append("<h2 style='float: left;padding: 0% 0% 0% 0%;margin: 0%;width: 100%;font-size: 1.1em;line-height: 1.5em;color: #5D5D5D;font-weight: bold;'>Provided By : Astro Envision</h2>");
        TBL.Append("<h2 style='float: left;padding: 0% 0% 0% 0%;margin: 0%;width: 100%;font-size: 1.1em;line-height: 1.5em;color: #5D5D5D;font-weight: bold;'>Contact : +91 9958883955</h2>");
        TBL.Append("<h2 style='float: left;padding: 0% 0% 0% 0%;margin: 0%;width: 100%;font-size: 1.1em;line-height: 1.5em;color: #5D5D5D;font-weight: bold;'>Email Id : support@astroenvision.com</h2>");
        TBL.Append("</div>");
        string reportHtml = TBL.ToString();
        var margins = new PageMargins
        {
            Top = 5,
            Bottom = 5,
            Left = 5,
            Right = 5
        };
        HtmlToPdfConverter _htmlToPdf = new HtmlToPdfConverter
        {
            Orientation = PageOrientation.Portrait,
            Margins = margins,
            //PageHeaderHtml = "<div style='border-bottom: 1px solid #e5e5e5;width: 500px;text-align: left;'></div>",
        };

        _htmlToPdf.Margins.Bottom = 20;
        _htmlToPdf.Margins.Left = 10;
        _htmlToPdf.Margins.Right = 10;
        _htmlToPdf.Margins.Top = 10;
        string folderPath = Server.MapPath("gall_content/" + yyyy_sys + "/" + mm_sys + "/");
        iTextSharp.text.Font blackFont = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
        var FileName = UserName.Replace(" ", String.Empty) + "_Report_" + DateTime.Now.ToString("ddMMyyyyHHss") + ".pdf";
        //PdfImage headerImage = "http:\"\localhost\astrology\\img\\logo-astro.svg";
        var pdfBytes = _htmlToPdf.GeneratePdf(reportHtml);
        PdfReader reader = new PdfReader(pdfBytes);
        using (MemoryStream stream = new MemoryStream())
        {

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
        //Response.AddHeader("Content-Disposition", "attaschment; filename=" + FileName + "");
        Response.BinaryWrite(pdfBytes);
        //System.IO.File.WriteAllBytes(Server.MapPath("gall_content/" + yyyy_sys + "/" + mm_sys + "/") + FileName, pdfBytes);
        Response.Flush();
        Response.End();
    }
    #endregion

    #region Bind Client Details, Charts And Predictives
    protected void BindCharts(string Flag)
    {
        flagForPdf = Flag;
        string LogoPath = System.Configuration.ConfigurationManager.AppSettings["LogoPath"];
        DataSet dsd = objmc.Get_Clientdetails(txtmail.Value, hdnuserid.Value);
        string dob = dsd.Tables[0].Rows[0]["DOB"].ToString();
        dob = DateTime.ParseExact(dob, "dd/MM/yyyy", null).ToString("dd-MMM-yyyy");
        string DayName = dsd.Tables[0].Rows[0]["DAYOB"].ToString();
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
        ViewState["TotalCategory"] = dsd.Tables[0].Rows.Count;
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

        #region For Birth Details

        TBL.Append("<div style=\"width:100%;padding-right:15px;padding-left:15px;margin-right:auto;margin-left:auto;\">");
        if (Flag == "ForPage")
        {

        }
        else
        {
            TBL.Append("<div style='text-align:center;'>");
            TBL.Append("<img src=\"" + WEBSITEDomainVal + "/Image/large_logo.svg\" alt=\"Astro Envision\" title=\"Astro Envision\" />");
            TBL.Append("</div>");
        }
        if (Flag == "ForPage") // HTML
        {
            TBL.Append("<div style='padding:0em 0em 0em 0em;margin: 0em 0em 0.4em 0em;height: 40px;vertical-align: top;width: 100%;text-align: center;font-size: 1.4em;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;'><img style='width: 35px;' src=\"" + WEBSITEDomainVal + "/Image/om_small.png\" alt=\"Astro Envision\" title=\"Astro Envision\" />&nbsp;Your Astrology Report&nbsp;<img style='width: 35px;' src=\"" + WEBSITEDomainVal + "/Image/om_small.png\" alt=\"Astro Envision\" title=\"Astro Envision\" /></div>");
        }
        else  // PDF
        {
            TBL.Append("<div style='text-align:center; margin-top:270px; margin-bottom:230px;'><img src=\"" + WEBSITEDomainVal + "/IMAGES/om.jpg\" /><br/><br/><h1 style = 'font-size: 2rem;font-family: sans-serif;color: #f25e0a;padding: 0px;margin: 0px;'>" + dsd.Tables[0].Rows[0]["CLIENT_NAME"].ToString() + "'s Astrology Report</h1><br/><br/><img src =\"" + WEBSITEDomainVal + "/IMAGES/ganesha.jpg\" /><br/><br/><br/><img src =\"" + WEBSITEDomainVal + "/IMAGES/om.jpg\" /></div>");
            TBL.Append("<div style='text-align:center;'>");
            TBL.Append("<img src=\"" + WEBSITEDomainVal + "/Image/large_logo.svg\" alt=\"Astro Envision\" title=\"Astro Envision\" />");
            TBL.Append("</div>");
            TBL.Append("<div style =\"page-break-before:always\"> &nbsp;</div>");
            TBL.Append("<div style='padding:0em 0em 0em 0em;margin: 0em 0em 0.4em 0em;height: 40px;vertical-align: top;width: 100%;text-align: center;font-size: 1.4em;color: #f25e0a;font-weight: bold;border-bottom: 2px solid #f25e0a;'><img style='width: 35px;' src=\"" + WEBSITEDomainVal + "/Image/om_small.png\" alt=\"Astro Envision\" title=\"Astro Envision\" />&nbsp;Your Astrology Report&nbsp;<img style='width: 35px;' src=\"" + WEBSITEDomainVal + "/Image/om_small.png\" alt=\"Astro Envision\" title=\"Astro Envision\" /></div>");
        }

        TBL.Append("<table style = \"width:100%;border-collapse: collapse;font-family: 'Roboto', sans-serif;font-size:15px;border:1px solid #d5d5d5;background:#fff;margin-bottom:.25cm;line-height: 15px;\">");
        TBL.Append("<tr>");
        TBL.Append("<th colspan=4 style = \"text-align:center;padding:.30cm;border-bottom:1px solid #d5d5d5;background-color: #fce9ce;\"><i class=\"fa fa-birthday-cake\" aria-hidden=\"true\"></i>&nbsp;Birth Details</th>");
        TBL.Append("</tr>");
        TBL.Append("<tr>");
        TBL.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Name:</th>");
        TBL.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + dsd.Tables[0].Rows[0]["CLIENT_NAME"].ToString() + "</td>");
        //TBL.Append("<th style = \"background: #a09999;width:2px;\"></th>");
        TBL.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Gender:</th>");
        TBL.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + Gender + "</td>");
        TBL.Append("</tr>");

        TBL.Append("<tr>");
        TBL.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Date of Birth:</th>");
        TBL.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + dob + " (" + DayName + ")" + "</td>");
        //TBL.Append("<th style = \"background: #a09999;width:2px;\"></th>");
        TBL.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Time of Birth:</th>");
        TBL.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + tobval + " (24 hrs)</td>");
        TBL.Append("</tr>");

        TBL.Append("<tr>");
        TBL.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Birth Place:</th>");
        TBL.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + dsd.Tables[0].Rows[0]["CITY"].ToString() + ", " + dsd.Tables[0].Rows[0]["STATE"].ToString() + ", " + dsd.Tables[0].Rows[0]["COUNTRY"].ToString() + "</td>");
        //TBL.Append("<th style = \"background: #a09999;width:2px;\"></th>");
        TBL.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Email:</th>");
        TBL.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + dsd.Tables[0].Rows[0]["CLIENT_MAIL"].ToString() + "</td>");
        TBL.Append("</tr>");

        TBL.Append("</table>");
        #endregion

        #region For Vedic Astrology Details

        TBL.Append("<table style = \"width:100%;border-collapse: collapse;font-family: 'Roboto', sans-serif;font-size:15px;border:1px solid #d5d5d5;background:#fff;line-height: 15px;\">");
        TBL.Append("<tr>");
        TBL.Append("<th colspan=4 style = \"text-align:center;padding:.30cm;border-bottom:1px solid #d5d5d5;background-color: #fce9ce;\"><i class=\"fa fa-user\" aria-hidden=\"true\"></i>&nbsp;Vedic Astrology Details</th>");
        TBL.Append("</tr>");
        TBL.Append("<tr>");
        TBL.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Latitude:</th>");
        TBL.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + dsd.Tables[0].Rows[0]["LATITUDE"].ToString() + "" + "</td>");
        //TBL.Append("<th style = \"background: #a09999;width:2px;\"></th>");
        TBL.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Longitude:</th>");
        TBL.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + dsd.Tables[0].Rows[0]["LONGITUDE"].ToString() + "</td>");
        TBL.Append("</tr>");

        TBL.Append("<tr>");
        TBL.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Time Zone:</th>");
        TBL.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + dsd.Tables[0].Rows[0]["TIMEZONE"].ToString() + "</td>");
        //TBL.Append("<th style = \"background: #a09999;width:2px;\"></th>");
        TBL.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Constellation:</th>");
        TBL.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + dsd.Tables[0].Rows[0]["CONSTELLATION"].ToString() + "</td>");
        TBL.Append("</tr>");

        TBL.Append("<tr>");
        TBL.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Rashi:</th>");
        TBL.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + dsd.Tables[0].Rows[0]["RASHI"].ToString() + "</td>");
        //TBL.Append("<th style = \"background: #a09999;width:2px;\"></th>");
        TBL.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Lagna Rashi:</th>");
        TBL.Append("<td style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + dsd.Tables[0].Rows[0]["LAGNARASHI"].ToString() + "</td>");
        TBL.Append("</tr>");

        TBL.Append("<tr>");
        TBL.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Balance Dasha:</th>");
        TBL.Append("<td colspan=3 style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + balancedashaval + "</td>");
        TBL.Append("</tr>");

        TBL.Append("<tr>");
        TBL.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Sunrise Time:</th>");
        TBL.Append("<td colspan=3 style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + sunrise + "</td>");
        TBL.Append("</tr>");


        TBL.Append("<tr>");
        TBL.Append("<th style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">Sunset Time:</th>");
        TBL.Append("<td colspan=3 style = \"text-align:center;padding:.30cm;border:1px solid #d5d5d5;\">" + sunret + "</td>");
        TBL.Append("</tr>");

        TBL.Append("</table>");

        #endregion

        #region For Personal Info
        //TBL.Append("<table style = \"width:100%;border-collapse: collapse;font-family: 'Roboto', sans-serif;font-size:13px;border:1px solid #d5d5d5;background:#fff;margin-bottom:.65cm;\">");

        //TBL.Append("<tr>");

        //TBL.Append("<td style = \"text-align:left;padding:.30cm;border-bottom:1px solid #d5d5d5;\" >");
        //TBL.Append("<div style = \"font-size: 20px;font-weight:bold;color:#f25e0a;\" >" + dsd.Tables[0].Rows[0]["CLIENT_NAME"].ToString() + "</div>");

        //TBL.Append("<div style = \"font-size: 14px;color:#000;\" > " + dob + " at " + dobtime + " (" + dsd.Tables[0].Rows[0]["STATE"].ToString() + ", " + dsd.Tables[0].Rows[0]["COUNTRY"].ToString() + ")" + "</div >");
        //TBL.Append("</td>");

        //TBL.Append("<td style = \"text-align:right;padding:.30cm;border-bottom:1px solid #d5d5d5;\">");
        //TBL.Append("<div style = \"font-size: 20px;font-weight:bold;color:#000;\">Your Report</div>");
        ////TBL.Append("<div style = \"font -size: 14px;color:#000;\" >Career & Profession</div>");
        //TBL.Append("</td>");

        //TBL.Append("</tr>");
        //TBL.Append("<tr>");
        //TBL.Append("<td style = \"padding:.30cm;border-right:1px solid #d5d5d5;vertical-align:top;\" >");
        //TBL.Append("<table style =\"border-collapse:collapse;\">");

        //TBL.Append("<tr>");

        //TBL.Append("<td style='font-weight: bold;'>Client Name</td>");
        //TBL.Append("<td>: " + dsd.Tables[0].Rows[0]["CLIENT_NAME"].ToString() + "</td>");

        //TBL.Append("</tr>");

        //TBL.Append("<tr>");
        //TBL.Append("<td style='font-weight: bold;'> Gender  </td>");
        //TBL.Append("<td>: " + Gender + "</td>");

        //TBL.Append("</tr>");

        //TBL.Append("<tr>");
        //TBL.Append("<td style='font-weight: bold;'> Date of Birth</td>");
        //TBL.Append("<td>: " + dob + "</td>");
        //TBL.Append("</tr>");

        //TBL.Append("<tr>");
        //TBL.Append("<td style='font-weight: bold;'>Time of Birth</td>");
        //TBL.Append("<td>: " + tobval + " </td>");
        //TBL.Append("</tr>");

        //TBL.Append("<tr>");
        //TBL.Append("<td style='font-weight: bold;'>Place of Birth</td>");
        //TBL.Append("<td>: " + dsd.Tables[0].Rows[0]["CITY"].ToString() + "</td >");
        //TBL.Append("</tr>");

        //TBL.Append("<tr>");
        //TBL.Append("<td style='font-weight: bold;'>Day of Birth</td>");
        //TBL.Append("<td>: " + dsd.Tables[0].Rows[0]["DAYOB"].ToString() + "</td>");
        //TBL.Append("</tr>");

        //TBL.Append("<tr>");
        //TBL.Append("<td style='font-weight: bold;'>State</td>");
        //TBL.Append("<td>: " + dsd.Tables[0].Rows[0]["STATE"].ToString() + "</td>");
        //TBL.Append("</tr>");

        //TBL.Append("<tr>");
        //TBL.Append("<td style='font-weight: bold;'>Country</td>");
        //TBL.Append("<td>: " + dsd.Tables[0].Rows[0]["COUNTRY"].ToString() + " </td>");
        //TBL.Append("</tr>");

        //TBL.Append("<tr>");
        //TBL.Append("<td style='font-weight: bold;'> Email </td>");
        //TBL.Append("<td>: " + dsd.Tables[0].Rows[0]["CLIENT_MAIL"].ToString() + " </td>");
        //TBL.Append("</tr>");

        //TBL.Append("<tr>");
        //TBL.Append("<td style='font-weight: bold;'> Contact No. </td>");
        //TBL.Append("<td>: " + dsd.Tables[0].Rows[0]["MOBILE_NO"].ToString() + " </td>");
        //TBL.Append("</tr>");

        //TBL.Append("</table>");

        //TBL.Append("</td>");

        //TBL.Append("<td style = \"padding:.30cm;vertical-align:top;\">");

        //TBL.Append("<table style = \"border-collapse: collapse;\">");

        //TBL.Append("<tr>");
        //TBL.Append("<td style='font-weight: bold;'>Latitude</td>");
        //TBL.Append("<td>: " + dsd.Tables[0].Rows[0]["LATITUDE"].ToString() + " </td>");
        //TBL.Append("</tr>");

        //TBL.Append("<tr>");
        //TBL.Append("<td style='font-weight: bold;'>Longitude</td>");
        //TBL.Append("<td>: " + dsd.Tables[0].Rows[0]["LONGITUDE"].ToString() + "</td>");
        //TBL.Append("</tr>");

        //TBL.Append("<tr>");
        //TBL.Append("<td style='font-weight: bold;'>Time Zone</td>");
        //TBL.Append("<td>: " + dsd.Tables[0].Rows[0]["TIMEZONE"].ToString() + " </td>");
        //TBL.Append("</tr>");

        //TBL.Append("<tr>");
        //TBL.Append("<td style='font-weight: bold;'>Constellation</td>");
        //TBL.Append("<td>: " + dsd.Tables[0].Rows[0]["CONSTELLATION"].ToString() + "</td>");
        //TBL.Append("</tr>");

        //TBL.Append("<tr>");
        //TBL.Append("<td style='font-weight: bold;'>Rashi</td>");
        //TBL.Append("<td>: " + dsd.Tables[0].Rows[0]["RASHI"].ToString() + "</td>");
        //TBL.Append("</tr>");

        //TBL.Append("<tr>");
        //TBL.Append("<td style='font-weight: bold;'> Balance Dasha  </td>");
        //TBL.Append("<td>: " + balancedashaval + " </td>");
        //TBL.Append("</tr>");

        //TBL.Append("<tr>");
        //TBL.Append("<td style='font-weight: bold;'>Sunrise Time</td>");
        //TBL.Append("<td>: " + sunrise + "</td>");
        //TBL.Append("</tr>");

        //TBL.Append("<tr>");
        //TBL.Append("<td style='font-weight: bold;'>Sunset Time</td>");
        //TBL.Append("<td>: " + sunret + "</td >");
        //TBL.Append("</tr>");

        //TBL.Append("<tr>");
        //TBL.Append("<td style='font-weight: bold;'>Next Day Sunrise Time </td>");
        //TBL.Append("<td>: " + sunrisenext + " </td>");
        //TBL.Append("</tr>");

        //TBL.Append("<tr>");
        //TBL.Append("<td style='font-weight: bold;'> Day Duration / Dinmaan </td>");
        //TBL.Append("<td>: " + dsd.Tables[0].Rows[0]["DAY_DURATION"].ToString() + " </td>");
        //TBL.Append("</tr>");

        //TBL.Append("<tr>");
        //TBL.Append("<td style='font-weight: bold;'> Night Duration / Ratrimaan </td>");
        //TBL.Append("<td>: " + dsd.Tables[0].Rows[0]["NIGHT_DURATION"].ToString() + " </td>");
        //TBL.Append("</tr>");

        //TBL.Append("</table>");
        //TBL.Append("</td>");
        //TBL.Append("</tr>");
        //TBL.Append("</table>");
        #endregion

        #region Bind Birth Chart
        string ChartImagePath = System.Configuration.ConfigurationManager.AppSettings["ChartImagePath"];
        string astroname = Hastname.Value;
        string clientname = txtmail.Value;
        string astid1 = Hastmail.Value;
        string group = hdngroup.Value;
        string groupu = hdngroup_u.Value;
        string ClientId = hdnuserid.Value;

        DataSet dsClient = new DataSet();

        dsClient = country.searchclientid(clientname, astroname, astid1, group, groupu, ClientId);

        TBL.Append("<table style = \"width:100%;border-collapse: collapse;font-family: 'Roboto', sans-serif;font-size:15px;margin-bottom:.25cm;-webkit-print-color-adjust: exact;\">");
        TBL.Append("<tr>");
        TBL.Append("<td colspan = \"2\" style = \"text-align:left;padding:.30cm 0;\">");
        if (Flag == "ForPage") // HTML
        {
            TBL.Append("<div style='font-size: 1.2em;float: left;padding:0em 0em 0.4em 0em;margin: 2em 0em 0em 0em;width: 100%;text-align: left;color: #007bff;font-weight: bold;border-bottom: 3px solid #007bff;'>Birth Chart</div>");
        }
        else  // PDF
        {
            TBL.Append("<div style='font-size: 1.4em;float: left;padding:0em 0em 0.4em 0em;margin: 1em 0em 0em 0em;width: 100%;text-align: left;color: #007bff;font-weight: bold;border-bottom: 3px solid #007bff;'>Birth Chart</div>");
        }

        TBL.Append("</td>");
        TBL.Append("</tr>");
        TBL.Append("<tr>");
        TBL.Append("<td colspan = \"2\" style = \"vertical-align:top; \">");
        TBL.Append("<table style = \"width:100%;border-collapse: collapse;border:1px solid #d5d5d5;line-height: 25px;\">");
        TBL.Append("<tr>");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\"> Planets </td>");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Rashi </td>");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > House </td>");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Degree </td> ");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Minutes </td> ");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Seconds </td> ");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Retro </td> ");
        TBL.Append("<td style = \"padding:.1cm .3cm;background:#555;border-right:1px solid #d5d5d5;color:#fff;-webkit-print-color-adjust: exact;\" > Const </th> ");
        TBL.Append("</tr>");

        string GetDetails = dsClient.Tables[1].Rows[0]["HOROSCOPE_D01"].ToString();
        string[] ar = GetDetails.Split('~');
        for (int j = 0; j < ar.Length - 1; j++)
        {
            string Value = ar[j];
            string[] SplitValue = Value.Split('/');
            TBL.Append("<tr>");
            TBL.Append("<td style = \"padding:.1cm .2cm;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + SplitValue[0] + " </td>");
            lstPlanets.Add(SplitValue[0]);
            TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + SplitValue[1] + " </td>");
            lstRashi.Add(SplitValue[1]);
            TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + SplitValue[2] + " </td>");
            lstHouse.Add(SplitValue[2]);
            string val = SplitValue[3];
            string[] TimeVal = val.Split('.');
            TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + TimeVal[0] + "</td>");
            lstDegree.Add(TimeVal[0]);
            TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + TimeVal[1] + " </td>");
            lstMintues.Add(TimeVal[1]);
            TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + TimeVal[2] + " </td>");

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
            TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" >" + RetrovVal + "</td>");
            TBL.Append("<td style = \"padding:.1cm .2cm;border-top:1px solid #d5d5d5;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + SplitValue[5] + " </th>");
            TBL.Append("</tr>");
        }
        TBL.Append("</table>");
        TBL.Append("</td>");

        TBL.Append("</tr>");   //deepak
        TBL.Append("</table>"); //deepak

        TBL.Append("<div style='width: 50%;margin: 0 auto;'>");
        TBL.Append("<div style = 'color:Black;font-size:14px;font-weight:bold;font-family:sans-serif;'> D01(Birth Chart)</div>");

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

        #region Start Chart Code

        TBL.Append("<div style = \"background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:500px;height: 450px;\">");
        string Top1 = "20%;";
        fontsize1 = "18px;";
        if (Houes1Value > 3)
        {
            Top1 = "11%;";
        }
        if (Houes1Value >= 5)
        {
            fontsize1 = "14px;";
            Top1 = "5%;";
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
       
        if (Flag == "")
        {
            TBL.Append("<div style=\"position:absolute; top: 39%;left: 49.5%;;width:30%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top: 39%;left: 49.5%;;width:30%;\">");
        }
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
            Top2 = "0%;";
            Left = "20%;";
             fontsize2 = "14px;";
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
       
        if (Flag == "")
        {
            TBL.Append("<div style=\"position:absolute;    top: 15%; left: 25%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute;    top: 15%; left: 25%;width:10%;\">");
        }
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
        if (Flag == "")
        {
            TBL.Append("<div style=\"position:absolute;top: 20%;  left: 22%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute;top: 17.1%;  left: 22%;width:10%;\">");
        }
      
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
        if (Flag == "")
        {
            TBL.Append("<div style=\"position:absolute;top: 44%;left: 47%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute;top: 42.1%;left: 47%;width:10%;\">");
        }
     
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
        if (Flag == "")
        {
            TBL.Append("<div style=\"position:absolute; top: 69%;left: 22%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top: 66%;left: 22%;width:10%;\">");
        }
    
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
        if (Flag == "")
        {
            TBL.Append("<div style=\"position:absolute; top: 72%; left:25%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top: 68%; left:25%;width:10%;\">");
        }
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
        if (Flag == "")
        {
            TBL.Append("<div style=\"position:absolute;top: 48%; left:49%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute;top: 45%; left:49%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id = \"1hsad7r\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID7 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");

        /******* House 8*******/
        string Top8 = "81%;";
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
        if (Flag == "")
        {
            TBL.Append("<div style=\"position:absolute;top: 72%;left: 73.5%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute;top: 69%;left: 73.5%;width:10%;\">");
        }
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
            Top9 = "63%;";

        }
        if (Houes9Value >= 4)
        {
            LineHeight9 = "line-height:15px;";
            fontsize9 = "16px;";
        }
        TBL.Append("<div style=\"position:absolute; top:" + Top9 + " left:85%;width:15%;" + LineHeight9 + "\">");
        TBL.Append("<span>");
        TBL.Append("<span id =\"1h9l1\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize9 + ";font-weight: bold;\">" + h9 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        if (Flag == "")
        {
            TBL.Append("<div style=\"position:absolute;top: 69%;left: 76%;width:11%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute;top: 66%;left: 76%;width:11%;\">");
        }
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
        if (Flag == "")
        {
            TBL.Append("<div style=\"position:absolute; top: 44%;left: 52%;width:10%;\">");
        }
        else
        {
            TBL.Append("<div style=\"position:absolute; top: 41.5%;left: 52%;width:10%;\">");
        }
        TBL.Append("<span>");
        TBL.Append("<span id =\"h10ForRashi\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight:bold;\">" + RashiID10 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");

        /******* House 11******/
        string Top11 = "20%;";
        string fontsize11 = "18px;";
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
        if (Flag == "")
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
        string fontsize12 = "18px;";
        string LineHeight12 = "";
        if (Houes12Value > 3)
        {
            Top12 = "1%;";
        }
        if (Houes12Value >= 4)
        {
            fontsize12 = "14px;";
            LineHeight12 = "line-height:15px;";
        }
        TBL.Append("<div style=\"position:absolute; top:" + Top12 + "; left:69%;width:30%;" + LineHeight12 + "\">");
        TBL.Append("<span>");
        TBL.Append("<span id =\"1h12l1\" style = \"text-align:left; color:#403E3E; font-size:" + fontsize12 + "font-weight: bold;\">" + h12 + "</span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("<div style=\"position:absolute; top:14%; left:74%;width:10%;\">");
        TBL.Append("<span>");
        TBL.Append("<span id =\"1h12r\" style = \"text-align:left; color:#403E3E; font-size:12px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + RashiID12 + "</span><br></span>");
        TBL.Append("</span>");
        TBL.Append("</div>");
        TBL.Append("</div>");
        #endregion

        TBL.Append("</div>");

        #endregion

        #region Split Chart Details
        string vargas = GetDetails;
        string vargasfinal = "", birth = "0";
        //vargas = vargas.slice(0, -1);
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
        ds.Dispose();

        TBL.Append("<div style =\"page-break-before:always\"> &nbsp;</div>");
        #endregion

        #region Bind Other Chart
        TBL.Append("<span>");

        TBL.Append("<table style = \"width:100%;border-collapse: collapse;font-family: 'Roboto', sans-serif;font-size:15px;margin-bottom:.25cm;-webkit-print-color-adjust: exact;\" >");
        TBL.Append("<div style='float: left;padding:0em 0em 0.4em 0em;margin: 0em 0em 0em 0em;width: 100%;text-align: left;font-size: 1.3em;color: #007bff;font-weight: bold;border-bottom: 3px solid #007bff;'> Other Chart</div>");
        TBL.Append("<tr>");

        TBL.Append("<td colspan = \"2\" style = \"text-align:left;padding:.30cm 0; \">");

        TBL.Append("</td>");
        TBL.Append("</tr>");
        TBL.Append("<tr>");

        ShowChart("D02");
        ShowChart("D03");
        ShowChart("D04");
        ShowChart("D05");
        ShowChart("D06");
        ShowChart("D07");
        ShowChart("D08");
        ShowChart("D09");
        ShowChart("D10");
        ShowChart("D11");
        ShowChart("D12");
        ShowChart("D16");
        ShowChart("D20");
        ShowChart("D24");
        ShowChart("D27");
        ShowChart("D30");
        ShowChart("D40");
        ShowChart("D45");
        ShowChart("D60");
        ShowChart("MOON");
        ShowChart("VENUS");

        TBL.Append("</tr>");
        TBL.Append("</tr>");
        TBL.Append("</table>");

        #endregion

        #region Bind All Small Graph

        DataSet dsForSmallGrpah = new DataSet();
        // Pratyantar Dasha  //Maha Dasha
        int hdnmoondegree_val = 0, hdnmoonminute_val = 0, hdnmoonsecond_val = 0, dobval = 0, mobval = 0, yobval = 0, htobval = 0, mtobval = 0;
        string chartd01 = dsd.Tables[0].Rows[0]["HOROSCOPE_D01"].ToString();
        if (chartd01 != "")
        {
            string[] chartd01split = chartd01.Split('~');
            for (int i = 0; i < chartd01split.Length; i++)
            {
                if (chartd01split[i].IndexOf("MOON") > -1)
                {
                    string[] moonstr = chartd01split[i].Split('/');
                    string moondegreeval = moonstr[3];
                    string[] moondegreeval_split = moondegreeval.Split('.');
                    if (moondegreeval_split.Length > 0)
                    {
                        hdnmoondegree_val = Convert.ToInt32(moondegreeval_split[0]);
                        hdnmoonminute_val = Convert.ToInt32(moondegreeval_split[1]);
                        hdnmoonsecond_val = Convert.ToInt32(moondegreeval_split[2]);
                    }
                }
            }
        }
        string clientdob = dsd.Tables[0].Rows[0]["DOB"].ToString();
        string[] clientdobsplit = clientdob.Split('/');
        if (clientdobsplit.Length > 0)
        {
            dobval = Convert.ToInt32(clientdobsplit[0]);
            mobval = Convert.ToInt32(clientdobsplit[1]);
            yobval = Convert.ToInt32(clientdobsplit[2]);
        }
        string clienttob = dsd.Tables[0].Rows[0]["TOB"].ToString();
        string[] clienttobsplit = clienttob.Split(':');
        if (clienttobsplit.Length > 0)
        {
            htobval = Convert.ToInt32(clienttobsplit[0]);
            mtobval = Convert.ToInt32(clienttobsplit[1]);
        }
        dsForSmallGrpah = objmc.caldashap_all(hdnmoondegree_val, hdnmoonminute_val, hdnmoonsecond_val, dsd.Tables[0].Rows[0]["RASHI"].ToString(), dobval, mobval, yobval, htobval, mtobval, 0, "hshoradm@horary.com", "Pratyantar Dasha");
        if (dsForSmallGrpah.Tables[0].Rows.Count > 0)
        {
            string balancedasha = dsForSmallGrpah.Tables[0].Rows[0]["BALANCEDASHA"].ToString();
            balancedasha = balancedasha.Replace("Balance Of Dasha :", "").Trim();
            string[] balancedashasplit = balancedasha.Split(' ');
            {
                if (balancedashasplit.Length > 0)
                {
                    yyyy = int.Parse(balancedashasplit[2]);
                    mm = int.Parse(balancedashasplit[4]);
                }
            }
            TBL.Append("<tr><td><div style =\"page-break-before:always\"> &nbsp;</div></td></tr>");
            if (dsForSmallGrpah.Tables[4].Rows.Count > 0)
            {
                TBL.Append("<table style = \"width:100%;border-collapse: collapse;font-family: 'Roboto', sans-serif;margin-bottom:.25cm;-webkit-print-color-adjust: exact;\" >");
                TBL.Append("<tr>");
                TBL.Append("<td style=\"text-align:left;padding:.30cm 0;\">");
                TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #007bff;font-weight: bold;border-bottom: 3px solid #007bff;font-size: 1.4em;'>Balance of Dasha Period</div>");
                TBL.Append("<div style = \"font-size: 16px;color:#000;font-weight:bold;\" >" + balancedasha + "</div>");
                TBL.Append("</td>");
                TBL.Append("</tr>");
                TBL.Append("<tr>");
                TBL.Append("<td style = \"text-align:left;padding:.30cm 0; \">");
                TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #007bff;font-weight: bold;border-bottom: 3px solid #007bff;font-size: 1.4em;'>Vimshottri Mahadasha</div>");
                TBL.Append("<div style =\"width:375px;margin:0 auto;\">");
                TBL.Append("<table style = \"width:100%;border-collapse:collapse;border: 1px solid #d5d5d5;\">");
                TBL.Append("<tr>");
                TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;-webkit-print-color-adjust:exact\">Mahadasha</td>");
                TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" >Years</td>");
                TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\"> Beginning</td>");
                TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Ending </ td >");
                TBL.Append("</tr>");

                for (int i = 0; i < dsForSmallGrpah.Tables[4].Rows.Count; i++)
                {
                    string planet1 = dsForSmallGrpah.Tables[4].Rows[i]["PLANET"].ToString();
                    string yearval = dsForSmallGrpah.Tables[4].Rows[i]["YEARS"].ToString();
                    yearval = yearval.Replace("Year", "");
                    string starttime = dsForSmallGrpah.Tables[4].Rows[i]["Start Time"].ToString();
                    string[] starttimesplit = starttime.Split(' ');
                    if (starttimesplit.Length > 0)
                    {
                        starttime = starttimesplit[0];
                    }
                    string endtime = dsForSmallGrpah.Tables[4].Rows[i]["End Time"].ToString();
                    string[] endtimesplit = endtime.Split(' ');
                    if (endtimesplit.Length > 0)
                    {
                        endtime = endtimesplit[0];
                    }

                    TBL.Append("<tr>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + planet1 + " </ td >");
                    TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\"> " + yearval + "</td>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" >" + starttime + "</td>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > " + endtime + "</td>");
                    TBL.Append("</tr>");
                }
                TBL.Append("</table>");
                TBL.Append("</div>");
                TBL.Append("</td>");
                TBL.Append("</tr>");
                TBL.Append("</table>");
            }
        }
        /****************************  Vimshottari Mahadasha and Antardashas   *****************************************/

        TBL.Append("<table style = \"width:100%;border-collapse: collapse;font-family: 'Roboto', sans-serif;margin-bottom:.15cm;-webkit-print-color-adjust: exact;\">");
        TBL.Append("<tr>");
        TBL.Append("<td style =\"text-align:left;padding:.30cm 0;\">");
        TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color:#007bff;font-weight: bold;border-bottom: 3px solid #007bff;font-size: 1.4em;'>Vimshottri Mahadasha and Antardashas</div>");
        TBL.Append("<table style = \"width:100%;border-collapse: collapse;\" >");
        TBL.Append("<tr>");

        if (dsForSmallGrpah.Tables[3].Rows.Count > 0)
        {
            int flagi;
            int ds4i = 0;
            yearantar = yobval + 50;

            for (int i = 0; i < dsForSmallGrpah.Tables[3].Rows.Count; i++)
            {
                string planet1 = dsForSmallGrpah.Tables[3].Rows[i]["PLANET"].ToString();
                string planet2 = dsForSmallGrpah.Tables[3].Rows[i]["PLANET1"].ToString();
                string yearval = dsForSmallGrpah.Tables[3].Rows[i]["YEARS"].ToString();
                yearval = yearval.Replace("Year", "");
                string monthval = dsForSmallGrpah.Tables[3].Rows[i]["MONTHS"].ToString();
                monthval = monthval.Replace("Month", "");
                string dayval = dsForSmallGrpah.Tables[3].Rows[i]["DAYS"].ToString();
                dayval = dayval.Replace("Day", "");
                string starttime = dsForSmallGrpah.Tables[3].Rows[i]["Start Time"].ToString();
                string[] starttimesplit = starttime.Split(' ');
                if (starttimesplit.Length > 0)
                {
                    starttime = starttimesplit[0];
                }
                string endtime = dsForSmallGrpah.Tables[3].Rows[i]["End Time"].ToString();
                string[] endtimesplit = endtime.Split(' ');
                if (endtimesplit.Length > 0)
                {
                    endtime = endtimesplit[0];
                }
                string[] endyearsplit = endtime.Split('-');
                flagi = i % 9;

                if (i == 0)
                {
                    string mahadashaperiod = dsForSmallGrpah.Tables[4].Rows[ds4i]["YEARS"].ToString();
                    mahadashaperiod = mahadashaperiod.Replace("Year", "");
                    string dashafromto = "From 0y to " + yyyy.ToString() + "y " + mm.ToString() + "m";
                    TBL.Append("<td style = \"padding:0px 3px 0px 0px;\">");
                    TBL.Append("<table style = \"width:100%;border-collapse: collapse;border: 1px solid #d5d5d5;font-size:13px;\">");
                    TBL.Append("<tr>");
                    TBL.Append("<td colspan =\"6\" style = \"padding:.1cm .2cm;background:#555;color:#fff;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-weight: bold;\" > " + planet1 + " (" + mahadashaperiod + " Year) - " + dashafromto + " </ td >");
                    TBL.Append("</tr>");
                    TBL.Append("<tr>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-weight: bold;\" > Antar </td>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-weight: bold;\" > Yr.</td>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-weight: bold;\" > Mo.</td>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-weight: bold;\" > Day.</td>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-weight: bold;\" > Beginning </td>");
                    TBL.Append("<td style = \"padding:.1cm .5cm;background:#f25e0a;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-weight: bold;\" > Ending </td>");
                    TBL.Append("</tr>");

                    TBL.Append("<tr>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" > " + planet2 + " </td>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" >" + yearval + " </td>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" > " + monthval + " </td>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" > " + dayval + " </td>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" > " + starttime + "</td>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" >" + endtime + "</td>");
                    TBL.Append("</tr>");
                }
                else if (flagi == 0)
                {
                    TBL.Append("</table>");
                    TBL.Append("</td>");

                    ds4i++;

                    if (ds4i % 3 == 0)
                    {
                        TBL.Append("</table>");
                        TBL.Append("</td>");
                        TBL.Append("</tr>");
                        TBL.Append("</table>");
                        TBL.Append("</td>");
                        TBL.Append("</tr>");
                        TBL.Append("</table>");
                        TBL.Append("<table style = \"width:100%;border-collapse: collapse;font-family: 'Roboto', sans-serif;font-size:13px;margin-bottom:.25cm;-webkit-print-color-adjust: exact;\">");
                        TBL.Append("<tr>");
                        TBL.Append("<td style =\"text-align:left;padding:.0cm 0;\">");
                        TBL.Append("<table style = \"width:100%;border-collapse: collapse;font-size:13px;\" >");
                        TBL.Append("<tr>");

                    }
                    if (Flag != "ForPage")
                    {
                        //if (ds4i == 6)
                        //{
                        //    TBL.Append("<tr><td><div style =\"page-break-before:always\"> &nbsp;</div></td></tr>");
                        //}
                    }

                    string mahadashaperiod = dsForSmallGrpah.Tables[4].Rows[ds4i]["YEARS"].ToString();
                    mahadashaperiod = mahadashaperiod.Replace("Year", "");

                    if (i != dsForSmallGrpah.Tables[3].Rows.Count)
                    {

                        string dashafromto = "From " + yyyy + "y" + mm.ToString() + "m to " + (yyyy + int.Parse(mahadashaperiod)) + "y" + mm.ToString() + "m";
                        yyyy = yyyy + int.Parse(mahadashaperiod);

                        TBL.Append("<td style = \"padding:0px 3px 0px 0px;\">");
                        TBL.Append("<table style = \"width:100%;border-collapse: collapse;border: 1px solid #d5d5d5;font-size:13px;\">");
                        TBL.Append("<tr>");
                        TBL.Append("<td colspan =\"6\" style = \"padding:.1cm .2cm;background:#555;color:#fff;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-weight: bold;\" > " + planet1 + " (" + mahadashaperiod + " Year) - " + dashafromto + " </ td >");
                        TBL.Append("</tr>");
                        TBL.Append("<tr>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-weight: bold;\" > Antar </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-weight: bold;\" > Yr.</td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-weight: bold;\" > Mo.</td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-weight: bold;\" > Day.</td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-weight: bold;\" > Beginning </td>");
                        TBL.Append("<td style = \"padding:.1cm .5cm;background:#f25e0a;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-weight: bold;\" > Ending </td>");
                        TBL.Append("</tr>");

                        TBL.Append("<tr>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" > " + planet2 + " </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" >" + yearval + " </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" > " + monthval + " </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" > " + dayval + " </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" > " + starttime + "</td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" >" + endtime + "</td>");
                        TBL.Append("</tr>");
                    }
                }
                else if (flagi > 0)
                {
                    if (i == dsForSmallGrpah.Tables[3].Rows.Count - 1)
                    {
                        TBL.Append("<tr>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" > " + planet2 + " </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" >" + yearval + " </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" > " + monthval + " </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" > " + dayval + " </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" > " + starttime + "</td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" >" + endtime + "</td>");
                        TBL.Append("</tr>");

                        TBL.Append("</table>");
                        TBL.Append("</td>");
                    }
                    else
                    {
                        TBL.Append("<tr>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" > " + planet2 + " </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" >" + yearval + " </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" > " + monthval + " </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" > " + dayval + " </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" > " + starttime + "</td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 12px\" >" + endtime + "</td>");
                        TBL.Append("</tr>");
                    }
                }
            }
            TBL.Append("</tr>");
            TBL.Append("</table>");
            TBL.Append("</td>");
            TBL.Append("</tr>");
            TBL.Append("</table>");
        }

        #endregion

        #region Bind Mahadasha, Antardashas, Pratyantardashas
        TBL.Append("<tr><td><div style =\"page-break-before:always\"> &nbsp;</div></td></tr>");
        TBL.Append("<table style = \"width:100%;border-collapse: collapse;font-family: 'Roboto', sans-serif;font-size:13px;margin-bottom:.25cm;-webkit-print-color-adjust: exact;\">");
        TBL.Append("<tr>");
        TBL.Append("<td style =\"text-align:left;padding:.0cm 0;\">");
        TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;color: #007bff;font-weight: bold;border-bottom: 3px solid #007bff;font-size: 1.4em;'>Vimshottari Antardasha and Pratyantardashas</div>");
        TBL.Append("<table style = \"width:100%;border-collapse: collapse;\" >");
        TBL.Append("<tr>");
        if (dsForSmallGrpah.Tables[2].Rows.Count > 0)
        {
            int flagii;
            yearpratyantar = yobval + 50;
            int ds5i = 0;
            for (int i = 0; i < dsForSmallGrpah.Tables[2].Rows.Count; i++)
            {
                string planet1 = dsForSmallGrpah.Tables[2].Rows[i]["PLANET"].ToString();
                string planet2 = dsForSmallGrpah.Tables[2].Rows[i]["PLANET1"].ToString();
                string planet3 = dsForSmallGrpah.Tables[2].Rows[i]["PLANET2"].ToString();
                string monthval = dsForSmallGrpah.Tables[2].Rows[i]["MONTHS"].ToString();
                monthval = monthval.Replace("Month", "");
                string dayval = dsForSmallGrpah.Tables[2].Rows[i]["DAYS"].ToString();
                dayval = dayval.Replace("Day", "");

                string starttime = dsForSmallGrpah.Tables[2].Rows[i]["Start Time"].ToString();
                string[] starttimesplit = starttime.Split(' ');
                if (starttimesplit.Length > 0)
                {
                    starttime = starttimesplit[0];
                }
                string endtime = dsForSmallGrpah.Tables[2].Rows[i]["End Time"].ToString();
                string[] endtimesplit = endtime.Split(' ');
                if (endtimesplit.Length > 0)
                {
                    endtime = endtimesplit[0];
                }
                string[] endyearsplit = endtime.Split('-');

                flagii = i % 9;
                if (i == 0)
                {
                    TBL.Append("<td style = \"padding:0px 4px 0px 0px;\">");
                    TBL.Append("<table style = \"width:100%;border-collapse: collapse;border: 1px solid #d5d5d5; \">");
                    TBL.Append("<tr>");
                    TBL.Append("<td colspan =\"6\" style = \"padding:.1cm .2cm;background:#555;color:#fff;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-weight: bold;\" >" + planet1 + " - " + planet2 + " </ td >");
                    TBL.Append("</tr>");
                    TBL.Append("<tr>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Pratyantar </td>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Mo.</td>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Day.</td>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Beginning </td>");
                    TBL.Append("<td style = \"padding:.1cm .5cm;background:#f25e0a;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Ending </td>");
                    TBL.Append("</tr>");

                    TBL.Append("<tr>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 13px\" > " + planet3 + " </td>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 13px\" >" + monthval + " </td>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 13px\" > " + dayval + " </td>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 13px\" > " + starttime + "</td>");
                    TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 13px\" >" + endtime + "</td>");
                    TBL.Append("</tr>");
                }
                else if (flagii == 0)
                {
                    TBL.Append("</table>");
                    TBL.Append("</td>");

                    ds5i++;

                    if (ds5i % 3 == 0)
                    {
                        TBL.Append("</table>");
                        TBL.Append("</td>");
                        TBL.Append("</tr>");
                        TBL.Append("</table>");
                        TBL.Append("</td>");
                        TBL.Append("</tr>");
                        TBL.Append("</table>");
                        TBL.Append("<table style = \"width:100%;border-collapse: collapse;font-family: 'Roboto', sans-serif;font-size:13px;margin-bottom:.25cm;-webkit-print-color-adjust: exact;\">");
                        TBL.Append("<tr>");
                        TBL.Append("<td style =\"text-align:left;padding:.0cm 0;\">");
                        TBL.Append("<table style = \"width:100%;border-collapse: collapse;\" >");
                        TBL.Append("<tr>");

                    }
                    if (Flag != "ForPage")
                    {
                        if (ds5i == 15 || ds5i == 30 || ds5i == 45 || ds5i == 60 || ds5i == 75)
                        {
                            TBL.Append("<tr><td><div style =\"page-break-before:always\"> &nbsp;</div></td></tr>");
                        }
                    }

                    if (i != dsForSmallGrpah.Tables[2].Rows.Count)
                    {

                        TBL.Append("<td style = \"padding:0px 4px 0px 0px;\">");
                        TBL.Append("<table style = \"width:100%;border-collapse: collapse;border: 1px solid #d5d5d5;\">");
                        TBL.Append("<tr>");
                        TBL.Append("<td colspan =\"6\" style = \"padding:.1cm .2cm;background:#555;color:#fff;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-weight: bold;\" >" + planet1 + " - " + planet2 + " </ td >");
                        TBL.Append("</tr>");
                        TBL.Append("<tr>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Pratyantar </td>");

                        TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Mo.</td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Day.</td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;background:#f25e0a;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Beginning </td>");
                        TBL.Append("<td style = \"padding:.1cm .5cm;background:#f25e0a;color:#fff;border-right:1px solid #d5d5d5;-webkit-print-color-adjust: exact;\" > Ending </td>");
                        TBL.Append("</tr>");

                        TBL.Append("<tr>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 13px\" > " + planet2 + " </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 13px\" > " + monthval + " </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 13px\" > " + dayval + " </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 13px\" > " + starttime + "</td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 13px\" >" + endtime + "</td>");
                        TBL.Append("</tr>");
                    }
                }
                else if (flagii > 0)
                {
                    if (i == dsForSmallGrpah.Tables[2].Rows.Count - 1)
                    {
                        TBL.Append("<tr>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 13px\" > " + planet2 + " </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 13px\" > " + monthval + " </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 13px\" > " + dayval + " </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 13px\" > " + starttime + "</td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 13px\" >" + endtime + "</td>");
                        TBL.Append("</tr>");
                        TBL.Append("</table>");
                        TBL.Append("</td>");
                    }
                    else
                    {
                        TBL.Append("<tr>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-left:1px solid #d5d5d5;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 13px\" > " + planet2 + " </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 13px\" > " + monthval + " </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 13px\" > " + dayval + " </td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 13px\" > " + starttime + "</td>");
                        TBL.Append("<td style = \"padding:.1cm .2cm;border-right:1px solid #d5d5d5;border-top:1px solid #d5d5d5;-webkit-print-color-adjust: exact;font-size: 13px\" >" + endtime + "</td>");
                        TBL.Append("</tr>");
                    }
                }
            }
            TBL.Append("</tr>");
            TBL.Append("</table>");
            TBL.Append("</td>");
            TBL.Append("</tr>");
            TBL.Append("</table>");
        }
        #endregion 

        #region Bind Astro Snapshot

        ds = country.ast_rashi("");
        DataSet dslp = new DataSet();
        string NoofCat = "1";
        if (Convert.ToInt32(ViewState["TotalCategory"].ToString()) > 0)
        {
            NoofCat = ViewState["TotalCategory"].ToString();
        }
        //dslp = showlagnadetails(lagnarashival, NoofCat, "GETLAGNADETAILS");
        dslp= obj_subs.GetLagnaPredictive(lagnarashival, "GET_LAGNA_PREDICTIVE_FOR_PAID_USER");

        TBL.Append("<div>");
        if (Flag == "ForPage")
        {
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin:2em 0em 0.5em 0em;width: 100%;text-align: left;color: #007bff;font-weight: bold;border-bottom: 3px solid #007bff;font-size: 1.1em;'>Your Astro Snapshot</div>");
            TBL.Append("<ul style='font-size:1.1em;line-height: 2rem;padding: 0px 0px 0px 1.2rem;list-style-image: url(\"" + WEBSITEDomainVal + "/Image/double_arrow_12x12.svg\");'>");
        }
        else
        {
            TBL.Append("<div style='padding:0em 0em 0.4em 0em;margin: 1em 0em 0.5em 0em;width: 100%;text-align: left;color: #007bff;font-weight: bold;border-bottom: 3px solid #007bff;font-size: 1.3em;'>Your Astro Snapshot</div>");
            TBL.Append("<ul style='font-size:1.4em;line-height: 2rem;padding: 0px 0px 0px 1.5rem;list-style-image: url(\"" + WEBSITEDomainVal + "/Image/double_arrow_14x14.svg\");'>");
        }


        if (dslp.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < dslp.Tables[0].Rows.Count; i++)
            {
                //TBL.Append("<div style = \"margin-top:10px;display:list-item;list-style-type: disc;list-style-position: inside;\">" + dslp.Tables[0].Rows[i]["descclob"].ToString().Trim() + "</div>");
                //TBL.Append("<li>" + dslp.Tables[0].Rows[i]["descclob"].ToString().Trim() + "</li>");
                TBL.Append("<li>" + dslp.Tables[0].Rows[i]["PREDICTIVE"].ToString().Trim() + "</li>");
            }
        }
        //if (dslp.Tables[1].Rows.Count > 0)
        //{
        //    int Total = dslp.Tables[1].Rows.Count;
        //    ArrayList lstNumbers = RandomNumbers(Total);
        //    for (int i = 0; i < lstNumbers.Count; i++)
        //    {
        //        int icount = i + 1;
        //        int no = Convert.ToInt32(lstNumbers[i]);
        //        string lagnastr = dslp.Tables[1].Rows[no]["descclob"].ToString();
        //        //TBL.Append("<div style = \"margin-top:10px;display:list-item;list-style-type: disc;list-style-position: inside;\">" + lagnastr + "</div>");
        //        TBL.Append("<li>" + lagnastr + "</li>");
        //    }
        //}
        //if (dslp.Tables[2].Rows.Count > 0)
        //{
        //    for (int i = 0; i < dslp.Tables[2].Rows.Count; i++)
        //    {
        //        int icount = i + 1;
        //        string lagnastr = dslp.Tables[2].Rows[i]["descclob"].ToString();
        //        //lagnadetailsid.InnerHtml += "<h2>" + icount + " " + lagnastr + "</h2>";
        //        //TBL.Append("<div style = \"margin-top:10px;display:list-item;list-style-type: disc;list-style-position: inside;\">" + lagnastr + "</div>");
        //        TBL.Append("<li>" + lagnastr + "</li>");
        //    }
        //}
        TBL.Append("</ul>");
        TBL.Append("</div>");
        #endregion

        #region Categories Predictives

        DataSet dsa = new DataSet();
        DataSet dssa = new DataSet();
        TBL.Append("<div style = \"margin-top:20px;\">");
        if (Flag == "ForPage")
        {
            TBL.Append("<div style='float: left;padding:0em 0em 0.4em 0em;margin: 2em 0em 0.5em 0em;width: 100%;text-align: left;font-size: 1.1em;color: #007bff;font-weight: bold;border-bottom: 3px solid #007bff;'>Your Astro Reports</div>");
        }
        else
        {
            TBL.Append("<div style='float: left;padding:0em 0em 0.4em 0em;margin: 1em 0em 0.5em 0em;width: 100%;text-align: left;font-size: 1.4em;color: #007bff;font-weight: bold;border-bottom: 3px solid #007bff;'>Your Astro Reports</div>");
        }

        dsa = obj_subs.UpdatePaymentStatus(hdnCartId.Value, txtmail.Value, "NATAL", "GETOUTPUT_CAT");
        if (dsa.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < dsa.Tables[0].Rows.Count; i++)
            {
                //string PositiveHtml = "", NegativeHtml = "", RemedialHtml = "";
                string CATID = dsa.Tables[0].Rows[i]["CATID"].ToString();
                string CATNAME = dsa.Tables[0].Rows[i]["CATNAME"].ToString();
                if (Flag == "ForPage")
                {
                    //TBL.Append("<div style=\"color: #F4600A\"><h1 style=\"margin:4px 0 -6px 0;padding:0;font-size:20px;\"><b>Your Report on - " + CATNAME + "</b></h1></div>");
                    TBL.Append("<div style='float: left;padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: auto;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 3px solid #f25e0a;font-size: 1.1em;'>Your Report on - " + CATNAME + "</div><div style='clear: both;'></div>");
                    TBL.Append("<ul style='font-size:1.1em;line-height: 2rem;padding: 0px 0px 0px 1.2rem;list-style-image: url(\"" + WEBSITEDomainVal + "/Image/double_arrow_12x12.svg\");'>");
                }
                else
                {
                    //TBL.Append("<div style=\"color: #F4600A\"><h1>Your Report on - " + CATNAME + "</h1></div>");
                    TBL.Append("<div style='float: left;padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: auto;text-align: left;color: #f25e0a;font-weight: bold;border-bottom: 3px solid #f25e0a;font-size: 1.3em;'>Your Report on - " + CATNAME + "</div><div style='clear: both;'></div>");
                    TBL.Append("<ul style='font-size:1.1em;line-height: 2rem;padding: 0px 0px 0px 1.2rem;list-style-image: url(\"" + WEBSITEDomainVal + "/Image/double_arrow_12x12.svg\");'>");
                }
                dssa = obj_subs.UpdatePaymentStatus(hdnCartId.Value, CATID, "NATAL", "GETOUTPUT_CAT_ANS");
                if (dssa.Tables[0].Rows.Count > 0)
                {
                    //DataTable dps = common.RemoveRecord(dssa.Tables[0], "ANSWER");
                    for (int j = 0; j < dssa.Tables[0].Rows.Count; j++)
                    {
                        string QUESTIONID = dssa.Tables[0].Rows[j]["QUESTIONID"].ToString();

                        string ANSWER = dssa.Tables[0].Rows[j]["ANSWER"].ToString();
                        string MailSentToSupport = dssa.Tables[0].Rows[j]["MAIL_SENT_TOSUPPORT"].ToString();
                        if (MailSentToSupport == "T")
                        {
                            MAILSENTTOSUPPORT = true;
                        }
                        //outputdetailsid_para.InnerHtml += "<h2>" + QUESTION + "</h2>";
                        if (ANSWER == "" && hdngroup_u.Value == "HORARY")
                        {
                            flagnoanswer = true;
                            ANSWER = "As You have not been able to find the answer for Your chosen category, we will provide the answer of your category by mail within 2-3 working days at no extra cost.Sorry for the inconvenience.";
                        }
                        if (ANSWER == "" && hdngroup_u.Value == "NATAL")
                        {
                            if (QUESTIONID == "1297") //Remedials for You?
                            {
                                flagRemedial = true;
                                // Remedial Details Start Here //
                                DataSet dsrd = new DataSet();
                                dsrd = showremedialdetails(lagnarashival, "1", "GETREMEDIALDETAILS");
                                if (dsrd.Tables[0].Rows.Count > 0)
                                {
                                    DataTable dsc = common.RemoveRecord(dsrd.Tables[0], "descclob");
                                    for (int r = 0; r < dsc.Rows.Count; r++)
                                    {
                                        string remedialstr = dsc.Rows[r]["descclob"].ToString();
                                        TBL.Append("<div style=\"color: #F4600A;display:list-item;list-style-type: disc;list-style-position: inside;\"><h3><span>Remedial - " + (r + 1) + " : </span>" + remedialstr + "</h3></div>");
                                    }
                                }
                                dsrd.Dispose();
                                // Remedial Details Start Here //
                            }
                            else if (QUESTIONID == "2059") //Know Your Zodiac / Lagna?
                            {
                                flaglagna = true;
                                // Lagna Details Start Here //
                                DataSet dsld = new DataSet();
                                string Noo1fCat = "1";
                                if (Convert.ToInt32(ViewState["TotalCategory"].ToString()) > 0)
                                {
                                    NoofCat = ViewState["TotalCategory"].ToString();
                                }
                                dsld = showlagnadetails(lagnarashival, Noo1fCat, "GETALLLAGNADETAILS");
                                if (dsld.Tables[0].Rows.Count > 0)
                                {
                                    for (int s = 0; s < dsld.Tables[0].Rows.Count; s++)
                                    {
                                        int scount = s + 1;
                                        string lagnastr = dsld.Tables[0].Rows[s]["descclob"].ToString();
                                        TBL.Append("<div style = \"margin-top:10px;display:list-item;list-style-type: disc;list-style-position: inside;\" > " + scount + " " + lagnastr + " </div>");
                                    }
                                }
                                if (dsld.Tables[1].Rows.Count > 0)
                                {
                                    int Total = dsld.Tables[1].Rows.Count;
                                    ArrayList lstNumbers = RandomNumbers(Total);
                                    for (int ss = 0; ss < lstNumbers.Count; ss++)
                                    {
                                        int sscount = ss + 1;
                                        int no = Convert.ToInt32(lstNumbers[ss]);
                                        string lagnastr = dsld.Tables[1].Rows[no]["descclob"].ToString();
                                        TBL.Append("<div style = \"margin-top:10px;display:list-item;list-style-type: disc;list-style-position: inside;\" > " + sscount + " " + lagnastr + " </div>");
                                    }
                                }
                                if (dsld.Tables[2].Rows.Count > 0)
                                {
                                    for (int sss = 0; sss < dsld.Tables[2].Rows.Count; sss++)
                                    {
                                        int ssscount = sss + 1;
                                        string lagnastr = dsld.Tables[2].Rows[sss]["descclob"].ToString();
                                        TBL.Append("<div style = \"margin-top:10px;display:list-item;list-style-type: disc;list-style-position: inside;\" > " + ssscount + " " + lagnastr + " </div>");
                                    }
                                }
                                dsld.Dispose();
                            }
                            else
                            {
                                flagnoanswer = true;
                                ANSWER = "As You have not been able to find the answer for your chosen category, we will provide the answer of your category by mail within 2-3 working days at no extra cost.Sorry for the inconvenience.";
                            }
                        }
                        string[] ANSWERSplitAll = ANSWER.Split('$');
                        string[] ANSWERSplit = ANSWERSplitAll.Distinct().ToArray();
                        if (ANSWERSplit.Length > 0)
                        {
                            for (int m = 0; m < ANSWERSplit.Length; m++)
                            {
                                string a = "", anext = "";
                                a = ANSWERSplit[m];
                                if (a != "")
                                {
                                    if (m == ANSWERSplit.Length - 1)
                                    {
                                        a = ANSWERSplit[m];
                                        a = a.Replace("\n", "");
                                    }
                                    else
                                    {
                                        anext = ANSWERSplit[m + 1];
                                    }
                                    //a = Regex.Replace(a, "<.*?>", string.Empty);
                                    if (CATID != "10" && CATID != "24")
                                    {
                                        var pattern = @"(?!</?b>)<.*?>";
                                        a = Regex.Replace(a, pattern, String.Empty, RegexOptions.Multiline);
                                    }
                                    if (Flag == "ForPage")
                                    {
                                        TBL.Append("<li font-size: 1.2em>" + a.Replace("#P", "").Trim() + "</li>");
                                    }
                                    else
                                    {
                                        TBL.Append("<li font-size: 1.4em>" + a.Replace("#P", "").Trim() + "</li>");
                                    }
                                    //   if (a != anext)
                                    //   {
                                    //       if (a.IndexOf("#P") > -1)
                                    //       {
                                    //           TBL.Append("<div style = \"margin-top:10px;display:list-item;list-style-type: disc;list-style-position: inside;\" > " + a.Replace("#P", "") + " </div>");
                                    //       }
                                    //       if (a.IndexOf("#N") > -1)
                                    //       {

                                    //           TBL.Append("<div style = \"margin-top:10px;display:list-item;list-style-type: disc;list-style-position: inside;\" > " + a.Replace("#N", "") + " </div>");
                                    //       }
                                    //       if (a.IndexOf("#R") > -1)
                                    //       {

                                    //           TBL.Append("<div style = \"margin-top:10px;display:list-item;list-style-type: disc;list-style-position: inside;\" > " + a.Replace("#R", "") + " </div>");
                                    //       }
                                    //       else
                                    //       {
                                    //           TBL.Append("<div style = \"margin-top:10px;display:list-item;list-style-type: disc;list-style-position: inside;\" > " + a.Replace("#P", "") + " </div>");
                                    //       }
                                    //   //outputdetailsid_point.InnerHtml += "<h3>" + a + "</h3>";
                                    //}
                                }
                                else
                                {
                                    if (QUESTIONID == "2064") // Kaal Sarpa Dosha Report
                                    {
                                        DataSet dsksdosha = new DataSet();
                                        dsksdosha = obj_subs.GetKaalSarpaDosha(hdnuserid.Value, "GET_MATCHING_REPORT");
                                        if (dsksdosha.Tables[0].Rows.Count > 0)
                                        {
                                            string DoshaDefinition = dsksdosha.Tables[0].Rows[0]["DEFINITION"].ToString().Trim();
                                            string DoshaPredictive = dsksdosha.Tables[1].Rows[0]["PREDICTIVE"].ToString().Trim();
                                            string DoshaRemedial = dsksdosha.Tables[1].Rows[0]["REMEDIAL"].ToString().Trim();
                                            //var pattern = @"(?!</?b>)<.*?>";
                                            //DoshaPredictive = Regex.Replace(DoshaPredictive, pattern, String.Empty, RegexOptions.Multiline);
                                            if (Flag == "ForPage")
                                            {
                                                TBL.Append("<li style = \"font-size: 1em\">" + DoshaDefinition + DoshaPredictive + DoshaRemedial + "</li>");
                                            }
                                            else
                                            {
                                                TBL.Append("<li style = \"font-size: 1.2em\">" + DoshaDefinition + DoshaPredictive + DoshaRemedial + "</li>");
                                            }
                                        }
                                    }
                                    else if (QUESTIONID == "2065") // Dashamsha Report
                                    {
                                        DataSet dsdashamsha = new DataSet();
                                        dsdashamsha = obj_subs.GetDashamsha(hdnuserid.Value, "", "GET_DASHAMSHA");
                                        if (dsdashamsha.Tables[0].Rows.Count > 0)
                                        {
                                            string DoshaPredictive = "";
                                            for (int d = 0; d < dsdashamsha.Tables[0].Rows.Count; d++)
                                            {
                                                if (dsdashamsha.Tables[0].Rows[d]["PLANET_NAME"].ToString().Trim() == "ASCENDENT")
                                                {
                                                    DoshaPredictive += "<p></p><p><b>Your Report :-</b></p></b></p>";
                                                }
                                                DoshaPredictive += dsdashamsha.Tables[0].Rows[d]["PREDICTIVE"].ToString().Trim();
                                                if (dsdashamsha.Tables[0].Rows[d]["PLANET_NAME"].ToString().Trim() == "KETU")
                                                {
                                                    DoshaPredictive += "<p></p><p style='font-size: 1.3rem;color: #5d8ee8;'><strong style='border-bottom: 2px solid #5d8ee8;'>Dashamsha's examples for reading :-</strong></p>";
                                                }
                                            }
                                            if (Flag == "ForPage")
                                            {
                                                TBL.Append("<li style = \"font-size: 1em\">" + DoshaPredictive + "</li>");
                                            }
                                            else
                                            {
                                                TBL.Append("<li style = \"font-size: 1.2em\">" + DoshaPredictive + "</li>");
                                            }
                                        }
                                        dsdashamsha.Dispose();
                                    }
                                    else if (QUESTIONID == "2066") // Vaisheshikamsha Report
                                    {
                                        DataSet dsvai = new DataSet();
                                        dsvai = obj_subs.GetVaisheshikamsha(hdnuserid.Value, "", "DASHAVARGA");
                                        if (dsvai.Tables[0].Rows.Count > 0)
                                        {
                                            string VaisheshikPredictive = "";
                                            for (int d = 0; d < dsvai.Tables[0].Rows.Count; d++)
                                            {
                                                if (dsvai.Tables[0].Rows[d]["PLANET_NAME"].ToString().Trim() == "ASCENDENT")
                                                {
                                                    VaisheshikPredictive += "<p></p><p><b>Your Report :-</b></p></b></p>";
                                                }
                                                VaisheshikPredictive += dsvai.Tables[0].Rows[d]["PREDICTIVE"].ToString().Trim();
                                                if (dsvai.Tables[0].Rows[d]["PLANET_NAME"].ToString().Trim() == "KETU")
                                                {
                                                    VaisheshikPredictive += "<p></p><p style='font-size: 1.3rem;color: #5d8ee8;'><strong style='border-bottom: 2px solid #5d8ee8;'>Vaisheshikamsha's examples for reading :-</strong></p>";
                                                }
                                            }
                                            if (Flag == "ForPage")
                                            {
                                                TBL.Append("<li style = \"font-size: 1em\">" + VaisheshikPredictive + "</li>");
                                            }
                                            else
                                            {
                                                TBL.Append("<li style = \"font-size: 1.2em\">" + VaisheshikPredictive + "</li>");
                                            }
                                        }
                                        dsvai.Dispose();
                                    }
                                    else
                                    {
                                        TBL.Append("<li>As You have not been able to find the answer for your chosen category, we will provide the answer of your category by mail within 2-3 working days at no extra cost.Sorry for the inconvenience.</li>");
                                    }
                                }
                            }
                        }
                    }
                }

                TBL.Append("</ul>");
            }

            TBL.Append("</div>");
        }

        //DataSet dsrd1 = new DataSet();
        //dsrd1 = showremedialdetails(lagnarashival, "1", "GETREMEDIALDETAILS");
        //if (dsrd1.Tables[0].Rows.Count > 0)
        //{
        //    TBL.Append("<div style = \"margin-top:20px;\">");
        //    if (Flag == "ForPage")
        //    {
        //        TBL.Append("<div style='float: left;padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;font-size: 1.1em;color: #007bff;font-weight: bold;border-bottom: 3px solid #007bff;'>Remedial As Per Your Birth Chart</div>");
        //        TBL.Append("<ul style='font-size:1.1em;line-height: 2rem;padding: 0px 0px 0px 1.2rem;list-style-image: url(\"" + WEBSITEDomainVal + "/Image/double_arrow_12x12.svg\");'>");
        //    }
        //    else
        //    {
        //        TBL.Append("<div style='float: left;padding:0em 0em 0.4em 0em;margin: 0em 0em 0.5em 0em;width: 100%;text-align: left;font-size: 1.4em;color: #007bff;font-weight: bold;border-bottom: 3px solid #007bff;'>Remedial As Per Your Birth Chart</div>");
        //        TBL.Append("<ul style='font-size:1.1em;line-height: 2rem;padding: 0px 0px 0px 1.2rem;list-style-image: url(\"" + WEBSITEDomainVal + "/Image/double_arrow_12x12.svg\");'>");
        //    }
        //    for (int i = 0; i < dsrd1.Tables[0].Rows.Count; i++)
        //    {
        //        string remedialstr = dsrd1.Tables[0].Rows[i]["descclob"].ToString();
        //        //remedialstr = Regex.Replace(remedialstr, "<.*?>", string.Empty);
        //        if (Flag == "ForPage")
        //        {
        //            TBL.Append("<li style = \"font-size: 1em\">" + remedialstr + "</li>");
        //        }
        //        else
        //        {
        //            TBL.Append("<li style = \"font-size: 1.2em\">" + remedialstr + "</li>");
        //        }
        //    }

        //    //if (Flag == "ForPage")
        //    //{
        //    //    for (int i = 0; i < dsrd1.Tables[0].Rows.Count; i++)
        //    //    {
        //    //        string remedialstr = dsrd1.Tables[0].Rows[i]["descclob"].ToString();
        //    //        remedialstr = Regex.Replace(remedialstr, "<.*?>", string.Empty);
        //    //        TBL.Append("<div style = \"margin-top:10px;font-size: 1.2em\" ><span style=\"color: #F4600A;font-size: 1.2em; font-weight: bold;display:list-item;list-style-type: disc;list-style-position: inside;\"> Remedial " + (i + 1) + " : </span>" + remedialstr + " </div>");
        //    //    }
        //    //}
        //    //else
        //    //{
        //    //    for (int i = 0; i < dsrd1.Tables[0].Rows.Count; i++)
        //    //    {
        //    //        string remedialstr = dsrd1.Tables[0].Rows[i]["descclob"].ToString();
        //    //        remedialstr = Regex.Replace(remedialstr, "<.*?>", string.Empty);
        //    //        TBL.Append("<div style = \"margin-top:10px;\" ><span style=\"color: #F4600A;font-size: 1.2em; font-weight: bold;display:list-item;list-style-type: disc;list-style-position: inside;\"> Remedial " + (i + 1) + " : </span>" + remedialstr + " </div>");
        //    //    }
        //    //}

        //    TBL.Append("</ul>");
        //    TBL.Append("</div>");
        //}
        //dsrd1.Dispose();

        dsa.Dispose();
        #endregion

        TBL.Append("</div>");
        if (Flag == "ForPage")
        {
            TBL.Append("<p style='background: #bcbfe2;border-radius: 10px;padding: 10px;margin: 20px;color:#3c3a3a;'><strong><span style='color:red;'>Note:-</span> Your Astro Reports are based on the placement and combinations of planets in your birth chart and this may generate the repetition of same predictions, reinforcing the predicted results.</strong></p>");
            divShowChart.InnerHtml = TBL.ToString();
        }
    }

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


        fontsize1 = "14px";
        if (flagForPdf == "ForPage")
        {
            TBL.Append("<td style = \"width:500px; padding-left:10px;\">");
            TBL.Append("<div style = \"color:Black;font-size:14px;font-weight:bold;\"> " + HeaderValue + "</div >");
            TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:340px;height:250px; \">");
            TBL.Append("<div style=\"position:absolute; top:19%;  left:36%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"Fhou1\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p21 + "<span style='color:" + AscColor + ";font-size:" + fontsize1 + "';'>As</span></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:32%;  left:45%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"FRashi1\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top: 3%;  left: 9%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"FHouse2\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p22 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:9%;  left: 21%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FRashi2\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:21%; left:2%;width:20%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FHouse3\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p23 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:12%; left:17%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FRashi3\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:45%; left:10%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FHouse4\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p24 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:37%; left:40%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FRashi4\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:65%; left:0%;width:20%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FHouse5\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p25 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:61%; left:16%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"FRashi5\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:87%; left:11%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FHouse6\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p26 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:66%; left:21%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FRashi6\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:70%; left:36%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FHouse7\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p27 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:42%; left:45%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FRashi7\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:89%; left:60%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FHouse8\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p28 + "</span></span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:65%; left:70%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FRashi8\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:64%; left:84%;width:15%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"FHouse9\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p29 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:60%; left:75%;width:11%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"FRashi9\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:43%; left:55%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"FHouse10\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p210 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:36%; left:50%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"FRashi10\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"FHouse11\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p211 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:12%; left:73%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"FRashi11\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:3%; left:60%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FHouse12\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p212 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:7%; left:70%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FRashi12\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("</div>");
            TBL.Append("</td>");
        }
        else
        {
            TBL.Append("<td style = \"width:500px; padding-left:10px;\">");
            TBL.Append("<div style = \"color:Black;font-size:15px;font-weight:bold;\"> " + HeaderValue + "</div >");
            TBL.Append("<div style = \"text-align: center;background:url('" + WEBSITEDomainVal + "/Image/bgastrology.jpg') no-repeat;background-position: center;background-size: 100% 100%;-webkit-print-color-adjust: exact;position: relative;z-index: 1;display: block;width:300px;height:250px;margin-bottom: 60px; \">");
            TBL.Append("<div style=\"position:absolute; top:11%;  left:36%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"Fhou1\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p21 + "<span style='color:" + AscColor + ";font-size:" + fontsize1 + "';'>As</span></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:38%;  left:45%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"FRashi1\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r21 + "</span><br></span></span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top: 3%;  left: 11%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"FHouse2\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p22 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:12%;  left: 20%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FRashi2\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r22 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:20%; left:2%;width:20%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FHouse3\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p23 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:18%; left:16%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FRashi3\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r23 + "</span><br></span></span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:45%; left:10%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FHouse4\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p24 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:42%; left:40%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FRashi4\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r24 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:65%; left:0%;width:20%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FHouse5\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p25 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:68%; left:16%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"FRashi5\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r25 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:87%; left:11%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FHouse6\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p26 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:72%; left:21%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FRashi6\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r26 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:70%; left:36%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FHouse7\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p27 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:47%; left:45%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FRashi7\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r27 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:81%; left:60%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FHouse8\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p28 + "</span></span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:70%; left:70%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FRashi8\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r28 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:67%; left:81%;width:15%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"FHouse9\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p29 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:67%; left:72%;width:11%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"FRashi9\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r29 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:43%; left:55%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"FHouse10\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p210 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:42%; left:50%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"FRashi10\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r210 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:20%; left:80%;width:20%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"FHouse11\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p211 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:18%; left:73%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id = \"FRashi11\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r211 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:3%; left:60%;width:30%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FHouse12\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\">" + p212 + "</span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("<div style=\"position:absolute; top:14%; left:70%;width:10%;\">");
            TBL.Append("<span>");
            TBL.Append("<span id =\"FRashi12\" style=\"text-align:left; color:#403E3E; font-size:10px;font-weight: bold;\"><br><span style=\"text-align:left; color:#6461CA; font-size:11px;font-weight: bold;\">" + r212 + "</span><br></span>");
            TBL.Append("</span>");
            TBL.Append("</div>");
            TBL.Append("</div>");
            TBL.Append("</td>");
        }
        if (Count == 3 || Count == 6 || Count == 9 || Count == 12 || Count == 15 || Count == 18)
        {
            TBL.Append("</tr>");
            if (Count == 12)
            {
                TBL.Append("<tr><td><div style =\"page-break-before:always\">&nbsp;</div></td></tr>");
            }
            TBL.Append("<tr>");
        }
        Count++;
    }
    #endregion

    #endregion
}