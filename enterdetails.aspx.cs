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
using System.Data.SqlClient;
using ASTROLOGY.classesoracle;
using System.Diagnostics;
using System.IO;
using kundli4c;
using System.Net;

public partial class enterdetails : System.Web.UI.Page
{
    ASTROLOGY.classesoracle.main obj_main = new ASTROLOGY.classesoracle.main();
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    common cs = new common();
    DataSet ds = new DataSet();
    DataSet ds1 = new DataSet();
    DataSet ds2 = new DataSet();
    DataSet dso = new DataSet();
    DataSet dsp = new DataSet();
    string EditPageUrl = "";

    string astroname = "";
    long mno;
    string usermail = "";
    string asmail = "";
    string asname = "";

    string astrologer = "";
    string clname = "";
    string astmail = "";
    string astrologername = "";
    string clmail = "";
    string name = "", profession = "", sex = "", astro_dtls = "null", cat_id = "", email = ""; //cat_grp = "";
    int age;
    string paymentstatus = "";
    public string HoraryEndUserAstrologerIDVal = ConfigurationManager.AppSettings["HoraryEndUserAstrologerID"].ToString();
    public string HoraryEndUserAstrologerNameVal = ConfigurationManager.AppSettings["HoraryEndUserAstrologerName"].ToString();
    public string NatalEndUserAstrologerIDVal = ConfigurationManager.AppSettings["NatalEndUserAstrologerID"].ToString();
    public string NatalEndUserAstrologerNameVal = ConfigurationManager.AppSettings["NatalEndUserAstrologerName"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(enterdetails));
        if (Session["UserEmailID"] != null)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["cartid"] != null && Request.QueryString["cartid"] != null)
                {
                    if (Request.QueryString["groupid"] != null)
                    {
                        ViewState["GroupId"] = Request.QueryString["groupid"].ToString().Trim();
                        //groupheaderid.InnerText = ViewState["GroupId"].ToString().ToUpper();

                        //DropDownList2.SelectedValue = ViewState["GroupId"].ToString().ToLower();
                        ////body.Attributes.Add("OnLoad", "javascript:return group_bind();");
                        if (ViewState["GroupId"].ToString().ToUpper() == "HORARY")
                        {
                            //cat.SelectedValue = "AEH";
                            usermail = HoraryEndUserAstrologerIDVal;
                            hdnuser.Value = HoraryEndUserAstrologerIDVal;
                            username.Value = HoraryEndUserAstrologerNameVal;
                            astrologer = HoraryEndUserAstrologerIDVal;
                            astmail = HoraryEndUserAstrologerIDVal;
                            astrologername = HoraryEndUserAstrologerNameVal;
                        }
                        if (ViewState["GroupId"].ToString().ToUpper() == "NATAL")
                        {
                            //cat.SelectedValue = "AEN";
                            usermail = NatalEndUserAstrologerIDVal;
                            hdnuser.Value = NatalEndUserAstrologerIDVal;
                            username.Value = NatalEndUserAstrologerNameVal;
                            astrologer = NatalEndUserAstrologerIDVal;
                            astmail = NatalEndUserAstrologerIDVal;
                            astrologername = NatalEndUserAstrologerNameVal;
                        }
                    }

                    if (Request.QueryString["Flag"] != null)
                    {
                        if(Request.QueryString["Flag"] == "PERSONAL_MEETING")
                        {
                            hdnUserType.Value = "12";
                            hdnPaymentFor.Value = "PERSONAL_MEETING";
                        }
                        else if (Request.QueryString["Flag"] == "CONSULT_AN_ASTROLOGER")
                        {
                            hdnUserType.Value = "13";
                            hdnPaymentFor.Value = "CONSULT_AN_ASTROLOGER";
                        }
                        else
                        {
                            hdnUserType.Value = "8";
                            hdnPaymentFor.Value = "TALK_TO_ASTROLOGER";
                        }
                           
                        if(Session["AstrologerID"] != null)
                        {
                            hdnAstrologerIdVal.Value = Session["AstrologerID"].ToString();
                            //hdnAstrologerName.Value = Session["AstrologerName"].ToString();
                            hdnAstrologerID.Value = "nataladmin@astroenvision.com";
                            hdnAstrologerName.Value = "Astroenvision Natal Admin";
                        }
                    }
                    else
                    {
                        hdnAstrologerID.Value = "nataladmin@astroenvision.com";  
                        hdnAstrologerName.Value = "Astroenvision Natal Admin";
                        hdnUserType.Value = "2";
                        hdnPaymentFor.Value = "NATAL_CATEGORY";
                        DataSet dsu = new DataSet();
                        dsu = obj_subs.UpdateToCartBilling(0, Request.QueryString["cartid"].ToString(), "", "", "", Session["UserID"].ToString(), Session["UserEmailID"].ToString(), "UPDATEBILLINGEMAILD");
                        if (dsu.Tables[0].Rows.Count > 0)
                        {
                            string updateflag = dsu.Tables[0].Rows[0]["flag"].ToString().Trim();
                        }
                        dsu.Dispose();
                    }

                    hdnRegUserEmailId.Value = Session["UserEmailID"].ToString();
                    hdnRegUserId.Value = Session["UserID"].ToString();
                    ViewState["cartid"] = Request.QueryString["cartid"].ToString().Trim();
                    hdncartid.Value = ViewState["cartid"].ToString().Trim();

                    //dsp = obj_subs.UpdatePaymentStatus(hdncartid.Value.ToString(), "", "", "GETEMAILPASSWORD");
                    //if (dsp.Tables[0].Rows.Count > 0)
                    //{
                    //    paymentstatus = dsp.Tables[0].Rows[0]["PAYMENT_STATUS"].ToString();
                    //    txtmail.Text = dsp.Tables[0].Rows[0]["EMAILID"].ToString();
                    //    string userpwd = dsp.Tables[0].Rows[0]["PASSWORD"].ToString();
                    //    txtpwd.Attributes.Add("value", userpwd);
                    //    //txtpwd.Text = common.Encrypt(userpwd);
                    //}
                    //dsp.Dispose();

                    //if (Request.UrlReferrer != null)
                    //{
                    //    EditPageUrl = Request.UrlReferrer.ToString();
                    //}
                }

                //Add Client Details
                bindbirth();
                bindplanet();
                bindchart();
                bindyogas();
                //usermail = "hshoradm@horary.com";
                //hdnuser.Value = "hshoradm@horary.com";
                //username.Value = "HARI SHARMA";
                //astrologer = "hshoradm@horary.com";
                //astmail = "hshoradm@horary.com";
                //astrologername = "HARISHARMA";
                hdnflag.Value = "0";
                //Session["usermail"] = usermail; //Comment By Deepak on 26 Nov 2019
                mainchannelbind();
                hdncat.Value = "natal";
                hdngroup.Value = "Astro Envision Natal";
                hdngroup_u.Value = "natal";

                ViewState["CountryCode"] = GetCountryCode();
                hdncountrycode.Value = ViewState["CountryCode"].ToString().Trim();

                //if (hdnflag.Value == "0")
                //{
                //    logout.Attributes.Add("style", "visibility:hidden;");
                //    submit.Attributes.Add("style", "visibility:visible;");
                //    //moc.Attributes.Add("style", "visibility:visible;");
                //}

                ddlCity.Attributes.Add("onchange", "javascript:return insert_data(id);");

                //pqh.Attributes.Add("onclick", "javascript:return probquery();");
                //logout.Attributes.Add("onclick", "javascript:return update_cl_dtls();");
                //DropDownList2.Attributes.Add("Onchange", "javascript:return group_bind();");
                //female.Attributes.Add("Onchange", "javascript:return fr();");
                //male.Attributes.Add("Onchange", "javascript:return mr();");
                btnsave.Attributes.Add("onclick", "javascript:return cl_dtls();");
            }
        }
        else
        {
            Response.Redirect(ResolveUrl("~/index.html"));
        }
    }

    #region Bind Drop Down
    protected void mainchannelbind()
    {
        DataSet ds = new DataSet();
        ds = cs.bindloc();
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlCountry.Items.Clear();
            ddlState.Items.Clear();
            ddlCity.Items.Clear();
            ddlCity.Items.Insert(0, new ListItem("Select City", "-1"));
            ddlState.Items.Insert(0, new ListItem("Select State", "-1"));
            ddlCountry.DataSource = ds.Tables[0];
            ddlCountry.DataTextField = "loc_name";
            ddlCountry.DataValueField = "loc_id";
            ddlCountry.DataBind();
            ddlCountry.Items.Insert(0, new ListItem("Select Country", "-1"));
            ds.Dispose();
        }

        DataSet dsc = obj_subs.GetDateMonthYearHourMinute("");
        if (dsc.Tables[0].Rows.Count > 0)
        {
            ddlDate.Items.Clear();
            ddlDate.DataSource = dsc.Tables[0];
            ddlDate.DataTextField = "DATE_NAME";
            ddlDate.DataValueField = "DATE_NAME";
            ddlDate.DataBind();
            ddlDate.Items.Insert(0, new ListItem("Date", "-1"));

            ddlMonth.Items.Clear();
            ddlMonth.DataSource = dsc.Tables[1];
            ddlMonth.DataTextField = "MONTH_NAME";
            ddlMonth.DataValueField = "MONTH_NUMBER";
            ddlMonth.DataBind();
            ddlMonth.Items.Insert(0, new ListItem("Month", "-1"));

            ddlYear.Items.Clear();
            ddlYear.DataSource = dsc.Tables[2];
            ddlYear.DataTextField = "YEAR_NAME";
            ddlYear.DataValueField = "YEAR_NAME";
            ddlYear.DataBind();
            ddlYear.Items.Insert(0, new ListItem("Year", "-1"));

            hob.Items.Clear();
            hob.DataSource = dsc.Tables[3];
            hob.DataTextField = "HOUR_NAME";
            hob.DataValueField = "HOUR_NAME";
            hob.DataBind();
            hob.Items.Insert(0, new ListItem("Hours", "-1"));

            mob.Items.Clear();
            mob.DataSource = dsc.Tables[4];
            mob.DataTextField = "MINUTE_NAME";
            mob.DataValueField = "MINUTE_NAME";
            mob.DataBind();
            mob.Items.Insert(0, new ListItem("Minutes", "-1"));
        }
        dsc.Dispose();
    }
    #endregion

    #region Country Change Event
    protected void ddlCountry_SelectChnage(object sender, EventArgs e)
    {
        ddlCity.Items.Clear();
        ddlCity.Items.Insert(0, new ListItem("Select City", "-1"));
        DataSet ds = new DataSet();
        ds = cs.bindstate("GETALLSTATES", ddlCountry.SelectedValue);
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlState.Items.Clear();
            ddlState.DataSource = ds.Tables[0];
            ddlState.DataTextField = "loc_name";
            ddlState.DataValueField = "loc_id";
            ddlState.DataBind();
            ddlState.Items.Insert(0, new ListItem("Select State", "-1"));
            ds.Dispose();
        }
    }

    #endregion

    #region State Change Event
    protected void ddlState_SelectChange(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        ds = cs.bindcity(ddlCountry.SelectedItem.Value, ddlState.SelectedItem.Value, "", "");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlCity.Items.Clear();
            ddlCity.DataSource = ds.Tables[0];
            ddlCity.DataTextField = "loc_name";
            ddlCity.DataValueField = "loc_id";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, new ListItem("Select City", "-1"));
            ds.Dispose();
        }
    }

    #endregion

    #region Get the final price

    [Ajax.AjaxMethod]
    public DataSet GetFinalPrice(string Cartid, string PaymentFor, string UserID)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
            if (PaymentFor == "TALK_TO_ASTROLOGER" || PaymentFor == "PERSONAL_MEETING" || PaymentFor == "CONSULT_AN_ASTROLOGER")
            {
                ds = obj_subs.GetPayment("GET_FINAl_PRICE", "", "", UserID, "");
            }
            else
            {
                ds = obj_subs.AddToCartBilling(0, Cartid.Trim(), "", "", "", "GETFINALPRICE", "", "");
            }
        }
        return ds;
    }
    #endregion

    //Start Function For Client DEtails

    [Ajax.AjaxMethod]
    public DataSet getdinrat(string sunset, string sunrise, string sunrisenextday, string tob, string user)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.getdinratman(sunset, sunrise, sunrisenextday, tob, user, "", "", "");
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet getsunsetsunrisea(String sr, string tz, string ss, string dob)
    {
        dob = Convert.ToDateTime(dob).ToString("yyyy/MM/dd");
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ds = cs.actsrss(sr, tz, ss, dob);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet getsunsetsunriseanext(String sr, string tz, string ss, string dob)
    {
        dob = Convert.ToDateTime(dob).AddDays(1).ToString("yyyy/MM/dd");
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ds = cs.actsrss(sr, tz, ss, dob);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet getsunsetsunriseapre(String sr, string tz, string ss, string dob)
    {
        dob = Convert.ToDateTime(dob).AddDays(-1).ToString("yyyy/MM/dd");
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ds = cs.actsrss(sr, tz, ss, dob);
        }
        return ds;
    }

    // Function for get the time of Current Sunrise and Sunset//

    [Ajax.AjaxMethod]
    public String getsunsetsunrise(String lati, string lngi, string astroname, string dob)
    {
        String datastore = "";
        try
        {
            StreamReader sr;
            astroname = astroname.Trim().Replace(" ", "");
            string binaddress = ConfigurationManager.AppSettings["keyloc"].ToString();
            string pythoncodepath = ConfigurationManager.AppSettings["sunrisesunset"].ToString();
            string sname = ConfigurationManager.AppSettings["pythonexe"].ToString();

            String fname = binaddress + astroname + ".bat";
            string textfile = binaddress + astroname + ".txt";

            if (!File.Exists(fname))
                File.CreateText(fname).Close();

            if (!File.Exists(textfile))
                File.CreateText(textfile).Close();

            string lat = lati;
            string lon = lngi;
            string curDate = Convert.ToDateTime(dob).ToString("yyyy/MM/dd");

            String batContent = "\"" + sname + "\" ";
            batContent += "\"" + pythoncodepath + "\" ";
            batContent += "\"" + lat + "\" ";
            batContent += "\"" + lon + "\" ";
            batContent += "\"" + curDate + "\" > ";
            batContent += "\"" + textfile + "\"";

            System.IO.File.WriteAllText(fname, batContent);

            //Start Code for Execute Batch File
            String command = @"" + fname + "";
            ProcessStartInfo p = new ProcessStartInfo("cmd.exe", "/c " + command);
            p.CreateNoWindow = true;
            Process myProcess = Process.Start(p);
            myProcess.WaitForExit();
            int exitCode1 = -1;
            string error1 = "";
            if (myProcess.HasExited)
            {
                exitCode1 = myProcess.ExitCode;
                if (exitCode1 == 0)
                {
                }
                else
                {
                    error1 = myProcess.StandardError.ReadToEnd();
                }
            }
            myProcess.Close();
            //End Code for Execute Batch File

            datastore = File.ReadAllText(textfile, System.Text.Encoding.GetEncoding("utf-8"));

            string[] lines = System.IO.File.ReadAllLines(textfile);
        }
        catch (Exception ex)
        {
            datastore = datastore + ex.Message;
        }
        return datastore;
    }

    // Function for get the time of Next Day Sunrise and Sunset//

    [Ajax.AjaxMethod]
    public String getsunsetsunrise1(String lati, string lngi, string astroname, string dob)
    {
        String datastore = "";
        try
        {
            StreamReader sr;
            astroname = astroname.Trim().Replace(" ", "");
            string binaddress = ConfigurationManager.AppSettings["keyloc"].ToString();
            string pythoncodepath = ConfigurationManager.AppSettings["sunrisesunset"].ToString();
            string sname = ConfigurationManager.AppSettings["pythonexe"].ToString();

            String fname = binaddress + astroname + ".bat";
            string textfile = binaddress + astroname + ".txt";

            if (!File.Exists(fname))
                File.CreateText(fname).Close();

            if (!File.Exists(textfile))
                File.CreateText(textfile).Close();

            string lat = lati;
            string lon = lngi;
            string curDate = Convert.ToDateTime(dob).AddDays(1).ToString("yyyy/MM/dd");

            String batContent = "\"" + sname + "\" ";
            batContent += "\"" + pythoncodepath + "\" ";
            batContent += "\"" + lat + "\" ";
            batContent += "\"" + lon + "\" ";
            batContent += "\"" + curDate + "\" > ";
            batContent += "\"" + textfile + "\"";

            System.IO.File.WriteAllText(fname, batContent);

            //Start Code for Execute Batch File
            String command = @"" + fname + "";
            ProcessStartInfo p = new ProcessStartInfo("cmd.exe", "/c " + command);
            p.CreateNoWindow = true;
            Process myProcess = Process.Start(p);
            myProcess.WaitForExit();
            int exitCode1 = -1;
            string error1 = "";
            if (myProcess.HasExited)
            {
                exitCode1 = myProcess.ExitCode;
                if (exitCode1 == 0)
                {
                }
                else
                {
                    error1 = myProcess.StandardError.ReadToEnd();
                }
            }
            myProcess.Close();
            //End Code for Execute Batch File

            datastore = File.ReadAllText(textfile, System.Text.Encoding.GetEncoding("utf-8"));
        }
        catch (Exception ex)
        {
            datastore = datastore + ex.Message;
        }
        return datastore;
    }

    // Function for get the time of Previous Day Sunrise and Sunset//

    [Ajax.AjaxMethod]
    public String getsunsetsunrise2(String lati, string lngi, string astroname, string dob)
    {
        String datastore = "";
        try
        {
            StreamReader sr;
            //Process myprocess;
            astroname = astroname.Trim().Replace(" ", "");
            string binaddress = ConfigurationManager.AppSettings["keyloc"].ToString();
            string pythoncodepath = ConfigurationManager.AppSettings["sunrisesunset"].ToString();
            string sname = ConfigurationManager.AppSettings["pythonexe"].ToString();

            String fname = binaddress + astroname + ".bat";
            string textfile = binaddress + astroname + ".txt";

            if (!File.Exists(fname))
                File.CreateText(fname).Close();

            if (!File.Exists(textfile))
                File.CreateText(textfile).Close();

            string lat = lati;
            string lon = lngi;
            string curDate = Convert.ToDateTime(dob).AddDays(-1).ToString("yyyy/MM/dd");

            String batContent = "\"" + sname + "\" ";
            batContent += "\"" + pythoncodepath + "\" ";
            batContent += "\"" + lat + "\" ";
            batContent += "\"" + lon + "\" ";
            batContent += "\"" + curDate + "\" > ";
            batContent += "\"" + textfile + "\"";

            System.IO.File.WriteAllText(fname, batContent);

            //Start Code for Execute Batch File
            String command = @"" + fname + "";
            ProcessStartInfo p = new ProcessStartInfo("cmd.exe", "/c " + command);
            p.CreateNoWindow = true;
            Process myProcess = Process.Start(p);
            myProcess.WaitForExit();
            int exitCode1 = -1;
            string error1 = "";
            if (myProcess.HasExited)
            {
                exitCode1 = myProcess.ExitCode;
                if (exitCode1 == 0)
                {
                }
                else
                {
                    error1 = myProcess.StandardError.ReadToEnd();
                }
            }
            myProcess.Close();
            //End Code for Execute Batch File

            datastore = File.ReadAllText(textfile, System.Text.Encoding.GetEncoding("utf-8"));
        }
        catch (Exception ex)
        {
            datastore = datastore + ex.Message;
        }
        return datastore;
    }

    //public void mainchannelbind()
    //{
    //    if (!Page.IsPostBack)
    //    {
    //        ds = cs.bindloc();
    //        ddlcunt.Items.Clear();
    //        ddlcunt.DataSource = ds;
    //        ddlcunt.DataTextField = "loc_name";
    //        ddlcunt.DataValueField = "loc_id";
    //        ddlcunt.DataBind();
    //        ddlcunt.Items.Insert(0, "--Select Country--");
    //        ds.Dispose();
    //    }
    //}

    [Ajax.AjaxMethod]
    public DataSet istfind(int ist3, string tob, string dateob)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ds = cs.isdate2(ist3, tob, dateob);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet state(string filter, string country)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ds = cs.bindstate(filter, country);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet districtt(string country, string state, string filter)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ds = cs.binddistrict(country, state, filter);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet citys(string country, string state, string district, string city)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ds = cs.bindcity(country, state, district, city);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet latlng(string country1, string state, string district, string city)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.bindlatlng(country1, state, district, city);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet timezone(string tzid, string dob1)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.bindtz(tzid, dob1);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet insert_astro_client_dtls1(string astro_dtls, string name, string email, string profession, string age, string sex, string cat_id, string astrologer, string p_captcha, string mno, string cat_grp)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.insert_astro_client_dtls(astro_dtls, name, email, profession, age, sex, cat_id, astrologer, "", mno, cat_grp);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet update_client(string astro_dtls, string name, string profession, string age, string sex, string astrologer, string email, string cat_id, string mno, string groupu)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.update_client(astro_dtls, name, profession, age, sex, astrologer, email, cat_id, mno, groupu);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet searchuser(string astrologer, string cat_grp)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.bind_user(astrologer, cat_grp);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet dup(string email, string cat_id, string astrologer)
    {
        DataSet ds = new DataSet();
        ds = cs.check_cl_dupid(email, cat_id, astrologer);
        return ds;
    }


    //End Function For Client Deatils

    [Ajax.AjaxMethod]
    public string Cal_Ascendant_Gulika(string hdnmocval, string dob_val, string dateob, string monthob, string yearob, string timeob, string hourob, string hdnimob, string longitudeval, string latitudeval, string sunsetpre, string sunrise, string sunset, string sunrisenext, string tzval)
    {
        string finalval = "";
        string gulikatob = "";
        kundli4c.clskundli obj = new clskundli();
        DataSet ds = new DataSet();
        if (hdnmocval != "2")
        {
            short dateofbirth = short.Parse(dateob);
            short monthofbirth = short.Parse(monthob);
            short yearofbirth = short.Parse(yearob);

            short hourofbirth = short.Parse(hourob);
            short minuteofbirth = short.Parse(hdnimob);
            short secondofbirth = short.Parse("0");

            double tdiff1 = double.Parse("-5.5");
            double longitude = double.Parse((longitudeval).ToString());
            double latitude = double.Parse((latitudeval).ToString());

            double asccal = obj.asccalcul(dateofbirth, monthofbirth, yearofbirth, hourofbirth, minuteofbirth, secondofbirth, tdiff1, longitude, latitude);

            DataSet dsg = new DataSet();
            string dobval = dob_val, dayofweek = "", GulikaTime = "", GulikaType = "", dinmanval = "", ratrimanval = "";
            string tobval = timeob;  //hourofbirth + ":" + minuteofbirth;

            string sunsetpreval = sunsetpre;
            string sunsetpretime = sunsetpreval.Substring(sunsetpreval.LastIndexOf(' ') + 1);
            sunsetpretime = sunsetpretime.Substring(0, sunsetpretime.Length - 0); // -3

            string sunriseval = sunrise;
            string sunrisetime = sunriseval.Substring(sunriseval.LastIndexOf(' ') + 1);
            sunrisetime = sunrisetime.Substring(0, sunrisetime.Length - 0);

            string sunsetval = sunset;
            string sunsettime = sunsetval.Substring(sunsetval.LastIndexOf(' ') + 1);
            sunsettime = sunsettime.Substring(0, sunsettime.Length - 0);

            string sunrisenextval = sunrisenext;
            string sunrisetimenext = sunrisenextval.Substring(sunrisenextval.LastIndexOf(' ') + 1);
            sunrisetimenext = sunrisetimenext.Substring(0, sunrisetimenext.Length - 0);

            DateTime t1 = DateTime.Parse(sunrisetime);
            DateTime t2 = DateTime.Parse(sunsettime);
            DateTime t3 = DateTime.Parse(tobval);
            DateTime t4 = DateTime.Parse(sunrisetimenext);
            DateTime t5 = DateTime.Parse(sunsetpretime);

            if (t3.TimeOfDay <= t1.TimeOfDay)
            {
                dobval = dob_val; //hdnidob.Value + "/" + hdnimoob.Value + "" + hdniyob.Value;
                dobval = DateTime.ParseExact(dobval, "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
                DateTime dtc = Convert.ToDateTime(dobval);
                dayofweek = dtc.DayOfWeek.ToString();
                dayofweek = dtc.AddDays(-1).DayOfWeek.ToString();
                dayofweek = dayofweek.ToUpper();
            }
            else
            {
                dobval = dob_val;
                dobval = DateTime.ParseExact(dobval, "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
                DateTime dtc = Convert.ToDateTime(dobval);
                dayofweek = dtc.DayOfWeek.ToString();
                dayofweek = dayofweek.ToUpper();
            }

            ASTROLOGY.classesoracle.myaccount objmc = new ASTROLOGY.classesoracle.myaccount();

            if (t1.TimeOfDay <= t2.TimeOfDay)
            {
                dsg = objmc.GetGulikaInfo(dayofweek);
                if (t3.TimeOfDay <= t1.TimeOfDay && t3.TimeOfDay <= t2.TimeOfDay)
                {
                    DateTime ss = new DateTime();
                    ss = Convert.ToDateTime(sunriseval);
                    DateTime sr = new DateTime();
                    sr = Convert.ToDateTime(sunsetpreval);
                    TimeSpan ts = ss.Subtract(sr);
                    int i = Convert.ToInt32(ts.TotalSeconds);
                    Double j = Convert.ToDouble(i) / Convert.ToDouble(60);
                    Double k = Math.Round(j, MidpointRounding.AwayFromZero);
                    int l = Convert.ToInt32(k);
                    ratrimanval = l.ToString();

                    if (dsg.Tables[1].Rows.Count > 0)
                    {
                        string totalminutes = dsg.Tables[1].Rows[0]["TOTAL_MINUTES"].ToString();
                        string ratman = dsg.Tables[1].Rows[0]["RATMAN"].ToString();
                        string nightbirth = dsg.Tables[1].Rows[0]["NIGHT_BIRTH"].ToString();
                        GulikaType = "NIGHT";
                        Double ii = Convert.ToDouble(totalminutes) / Convert.ToDouble(ratman);
                        Double jj = ii * l;
                        Double kk = Math.Round(jj, MidpointRounding.AwayFromZero);
                        int ll = Convert.ToInt32(kk);
                        //hdgulikatime.Value = ll.ToString();
                        GulikaTime = ll.ToString();
                    }
                }
                else if (t3.TimeOfDay >= t1.TimeOfDay && t3.TimeOfDay <= t2.TimeOfDay)
                {
                    DateTime ss = new DateTime();
                    ss = Convert.ToDateTime(sunsetval);
                    DateTime sr = new DateTime();
                    sr = Convert.ToDateTime(sunriseval);
                    TimeSpan ts = ss.Subtract(sr);
                    int i = Convert.ToInt32(ts.TotalSeconds);
                    Double j = Convert.ToDouble(i) / Convert.ToDouble(60);
                    Double k = Math.Round(j, MidpointRounding.AwayFromZero);
                    int l = Convert.ToInt32(k);
                    dinmanval = l.ToString();

                    if (dsg.Tables[0].Rows.Count > 0)
                    {
                        string totalminutes = dsg.Tables[0].Rows[0]["TOTAL_MINUTES"].ToString();
                        string dinman = dsg.Tables[0].Rows[0]["DINMAN"].ToString();
                        string daybirth = dsg.Tables[0].Rows[0]["DAY_BIRTH"].ToString();
                        GulikaType = "DAY";
                        Double ii = Convert.ToDouble(totalminutes) / Convert.ToDouble(dinman);
                        Double jj = ii * l;
                        Double kk = Math.Round(jj, MidpointRounding.AwayFromZero);
                        int ll = Convert.ToInt32(kk);
                        //hdgulikatime.Value = ll.ToString();
                        GulikaTime = ll.ToString();
                    }
                }
                else
                {
                    DateTime ss = new DateTime();
                    ss = Convert.ToDateTime(sunrisenextval);
                    DateTime sr = new DateTime();
                    sr = Convert.ToDateTime(sunsetval);
                    TimeSpan ts = ss.Subtract(sr);
                    int i = Convert.ToInt32(ts.TotalSeconds);
                    Double j = Convert.ToDouble(i) / Convert.ToDouble(60);
                    Double k = Math.Round(j, MidpointRounding.AwayFromZero);
                    int l = Convert.ToInt32(k);
                    ratrimanval = l.ToString();

                    if (dsg.Tables[1].Rows.Count > 0)
                    {
                        string totalminutes = dsg.Tables[1].Rows[0]["TOTAL_MINUTES"].ToString();
                        string ratman = dsg.Tables[1].Rows[0]["RATMAN"].ToString();
                        string nightbirth = dsg.Tables[1].Rows[0]["NIGHT_BIRTH"].ToString();
                        GulikaType = "NIGHT";
                        Double ii = Convert.ToDouble(totalminutes) / Convert.ToDouble(ratman);
                        Double jj = ii * l;
                        Double kk = Math.Round(jj, MidpointRounding.AwayFromZero);
                        int ll = Convert.ToInt32(kk);
                        //hdgulikatime.Value = ll.ToString();
                        GulikaTime = ll.ToString();
                    }
                }

                if (t3.TimeOfDay <= t1.TimeOfDay && t3.TimeOfDay <= t2.TimeOfDay)
                {
                    DateTime sspt = DateTime.Parse(sunsetpreval);
                    int gt = int.Parse(GulikaTime);

                    TimeSpan time = new TimeSpan(0, 0, gt, 0);
                    DateTime combined = sspt.Add(time);

                    gulikatob = combined.ToString("MM/dd/yyyy HH:mm:ss");
                    string timezoneval = tzval;


                    DateTime gulikatobgulika = DateTime.Parse(gulikatob);
                    DateTime time1;
                    tzval = Math.Round(Double.Parse(tzval), 2).ToString("0.00");
                    if (tzval.IndexOf(".") > -1)
                    {
                        time1 = DateTime.Parse(tzval.Replace(".", ":").Replace("-", ""));
                    }
                    else
                    {
                        if (timezoneval.IndexOf("-") > -1)
                        {
                            tzval = tzval.Replace("-", "") + ":00";
                            time1 = DateTime.Parse(tzval);
                        }
                        else
                        {
                            tzval = tzval + ":00";
                            time1 = DateTime.Parse(tzval);
                        }
                    }
                    DateTime timetz = DateTime.Parse("5:30");
                    TimeSpan combined1 = new TimeSpan();
                    if (timezoneval.IndexOf("-") > -1)
                    {
                        tzval = tzval.Replace(".", ":").Replace("-", "");
                        TimeSpan spantimezone = TimeSpan.Parse(tzval);
                        DateTime timetzzz = timetz.Add(spantimezone);
                        combined1 = TimeSpan.Parse(timetzzz.ToString("HH:mm:ss"));
                    }
                    else
                    {
                        combined1 = timetz.Subtract(time1);
                    }
                    DateTime combined2 = gulikatobgulika.Add(combined1);
                    gulikatob = combined2.ToString("MM/dd/yyyy HH:mm:ss");
                }
                else if (t3.TimeOfDay >= t1.TimeOfDay && t3.TimeOfDay <= t2.TimeOfDay)
                {

                    DateTime srt = DateTime.Parse(sunriseval);
                    int gt = int.Parse(GulikaTime);

                    TimeSpan time = new TimeSpan(0, 0, gt, 0);
                    DateTime combined = srt.Add(time);

                    gulikatob = combined.ToString("MM/dd/yyyy HH:mm:ss");

                    string timezoneval = tzval;
                    DateTime gulikatobgulika = DateTime.Parse(gulikatob);
                    DateTime time1;
                    tzval = Math.Round(Double.Parse(tzval), 2).ToString("0.00");
                    if (tzval.IndexOf(".") > -1)
                    {
                        time1 = DateTime.Parse(tzval.Replace(".", ":").Replace("-", ""));
                    }
                    else
                    {
                        if (timezoneval.IndexOf("-") > -1)
                        {
                            tzval = tzval.Replace("-", "") + ":00";
                            time1 = DateTime.Parse(tzval);
                        }
                        else
                        {
                            tzval = tzval + ":00";
                            time1 = DateTime.Parse(tzval);
                        }
                    }

                    DateTime timetz = DateTime.Parse("5:30");
                    TimeSpan combined1 = new TimeSpan();
                    if (timezoneval.IndexOf("-") > -1)
                    {
                        tzval = tzval.Replace(".", ":").Replace("-", "");
                        TimeSpan spantimezone = TimeSpan.Parse(tzval);
                        DateTime timetzzz = timetz.Add(spantimezone);
                        combined1 = TimeSpan.Parse(timetzzz.ToString("HH:mm:ss"));
                    }
                    else
                    {
                        combined1 = timetz.Subtract(time1);
                    }
                    DateTime combined2 = gulikatobgulika.Add(combined1);
                    gulikatob = combined2.ToString("MM/dd/yyyy HH:mm:ss");
                }

                else
                {
                    DateTime sst = DateTime.Parse(sunsetval);
                    int gt = int.Parse(GulikaTime);

                    TimeSpan time = new TimeSpan(0, 0, gt, 0);
                    DateTime combined = sst.Add(time);

                    gulikatob = combined.ToString("MM/dd/yyyy HH:mm:ss");


                    string timezoneval = tzval;
                    DateTime gulikatobgulika = DateTime.Parse(gulikatob);
                    DateTime time1;
                    tzval = Math.Round(Double.Parse(tzval), 2).ToString("0.00");
                    if (tzval.IndexOf(".") > -1)
                    {
                        time1 = DateTime.Parse(tzval.Replace(".", ":").Replace("-", ""));
                    }
                    else
                    {
                        if (timezoneval.IndexOf("-") > -1)
                        {
                            tzval = tzval.Replace("-", "") + ":00";
                            time1 = DateTime.Parse(tzval);
                        }
                        else
                        {
                            tzval = tzval + ":00";
                            time1 = DateTime.Parse(tzval);
                        }
                    }
                    DateTime timetz = DateTime.Parse("5:30");
                    TimeSpan combined1 = new TimeSpan();
                    if (timezoneval.IndexOf("-") > -1)
                    {
                        tzval = tzval.Replace(".", ":").Replace("-", "");
                        TimeSpan spantimezone = TimeSpan.Parse(tzval);
                        DateTime timetzzz = timetz.Add(spantimezone);
                        combined1 = TimeSpan.Parse(timetzzz.ToString("HH:mm:ss"));
                    }
                    else
                    {
                        combined1 = timetz.Subtract(time1);
                    }
                    DateTime combined2 = gulikatobgulika.Add(combined1);
                    gulikatob = combined2.ToString("MM/dd/yyyy HH:mm:ss");
                }

                string[] gulikadt = gulikatob.Split(' ');
                string gulikadate = gulikadt[0];
                string gulikatime = gulikadt[1];

                string[] gulikadaya = gulikadate.Split('/');
                string[] gulikatimea = gulikatime.Split(':');


                short gulikaday = short.Parse(gulikadaya[1]);
                short gulikamonth = short.Parse(gulikadaya[0]);
                short gulikayear = short.Parse(gulikadaya[2]);

                short gulikah = short.Parse(gulikatimea[0]);
                short gulikam = short.Parse(gulikatimea[1]);
                short gulikas = short.Parse(gulikatimea[2]);


                double gulikacalculation = obj.asccalcul(gulikaday, gulikamonth, gulikayear, gulikah, gulikam, gulikas, tdiff1, longitude, latitude);
                //gulikaval.Value = gulikacalculation.ToString();
                string gulikaval = gulikacalculation.ToString();

                finalval = asccal + "~" + gulikaval;
            }
        }
        return finalval;
    }

    [Ajax.AjaxMethod]
    public DataSet makebirthchart(string dob, string tob, double tzon, double ascca, double gulca)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_makebirthchart(dob, tob, tzon, ascca, gulca);
        }
        return ds;
    }

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

    public void bindplanet()
    {
        planet.Items.Clear();
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_planet("");
        }
        ListItem li = new ListItem();
        li.Text = "--Select Planet--";
        li.Value = "0";
        li.Selected = true;
        planet.Items.Add(li);

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            planet.Items.Add(li1);
        }
    }

    public void bindbirth()
    {
        birth.Items.Clear();
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_birth("");
        }

        ListItem li = new ListItem();
        li.Text = "--Select Birth--";
        li.Value = "0";
        li.Selected = true;
        birth.Items.Add(li);

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            birth.Items.Add(li1);
        }
    }

    public void bindchart()
    {
        chart_final.Items.Clear();

        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_chart("");
        }

        ListItem li = new ListItem();
        li.Text = "--Select Chart--";
        li.Value = "0";
        li.Selected = true;

        chart_final.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["CHART_NO"].ToString();
            chart_final.Items.Add(li1);
        }
    }

    public void bindyogas()
    {
        dropyogas_final.Items.Clear();
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_yogas("");
            ListItem li = new ListItem();
            li.Text = "---Select yogas---";
            li.Value = "0";
            li.Selected = true;

            dropyogas_final.Items.Add(li);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ListItem li1 = new ListItem();
                li1.Text = ds.Tables[0].Rows[i]["NAME"].ToString();
                dropyogas_final.Items.Add(li1);
            }
        }
    }

    [Ajax.AjaxMethod]
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

    [Ajax.AjaxMethod]
    public DataSet chechduplicacy(string astid, string astname, string client, string clientid, string group, string groupu)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.chechduplicacy(astid, astname, client, clientid, group, groupu);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet savecharts_enduser(string d01, string d02, string d03, string d04, string d05, string d06, string d07, string d08, string d09, string d10, string d11, string d12, string d16, string d20, string d24, string d27, string d30, string d40, string d45, string d60, string kl, string astid, string astname, string client, string clientid, string dasha, string dob, string tob, string countr, string state, string district, string city, string group, string group_u, string prof, string sex, string mobile, string sunsetpre, string sunrise, string sunset, string sunrisenext, string dayofborth, string rashi, string constellation, string longitude, string latitude, string timezone, string dayduration, string nightduration, string balancedasha, string ClientEmailId, string pwd, string lagnarashi, string chartdetails, string matchwith, string lagnachart, string moonchart, string venuschart, string UserType, string RegUserId, string RegUserEmailId, string Cartid,string AstrologerId)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.savecharts_enduser(d01, d02, d03, d04, d05, d06, d07, d08, d09, d10, d11, d12, d16, d20, d24, d27, d30, d40, d45, d60, kl, astid, astname, client, clientid, dasha, dob, tob, countr, state, district, city, group, group_u, prof, sex, mobile, sunsetpre, sunrise, sunset, sunrisenext, dayofborth, rashi, constellation, longitude, latitude, timezone, dayduration, nightduration, balancedasha, ClientEmailId, pwd, lagnarashi, chartdetails, matchwith, lagnachart, moonchart, venuschart, UserType, RegUserId, RegUserEmailId, Cartid, AstrologerId);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet GetRashi_Constellation(string CValue)
    {
        DataSet ds = new DataSet();
        string c = CValue.ToString().Trim();
        if (c != "")
        {
            String[] splitC = c.Split('$');
            if (splitC.Length > 0)
            {
                for (int i = 0; i < splitC.Length; i++)
                {
                    if (splitC[i].IndexOf("MOON~") > -1)
                    {
                        string rc = splitC[i];
                        String[] splitrc = rc.Split('~');
                        if (splitrc.Length > 0)
                        {
                            DataTable dt = new DataTable();
                            dt.TableName = "Table1";
                            dt.Columns.Add("Rashi");
                            dt.Columns.Add("Constellation");
                            dt.Rows.Add(splitrc[1], splitrc[6]);
                            ds.Tables.Add(dt);
                            //hdrashi.Value = splitrc[1];
                            //hdconstellation.Value = splitrc[6];
                        }
                    }
                }
            }
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet GetBalance_Dasha(string BDValue)
    {
        DataSet ds = new DataSet();
        string balancedashastr = BDValue;
        String[] split_bds = balancedashastr.Split('$');
        if (split_bds.Length > 0)
        {
            DataSet ds_dasha = new DataSet();
            if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
                ds_dasha = country.caldashap(Convert.ToInt32(split_bds[0]), Convert.ToInt32(split_bds[1]), Convert.ToInt32(split_bds[2]), split_bds[3], Convert.ToInt32(split_bds[4]), Convert.ToInt32(split_bds[5]), Convert.ToInt32(split_bds[6]), Convert.ToInt32(split_bds[7]), Convert.ToInt32(split_bds[8]), Convert.ToInt32(split_bds[9]), split_bds[10], split_bds[11]);
                if (ds_dasha.Tables[0].Rows.Count > 0)
                {
                    string tempdb = ds_dasha.Tables[0].Rows[0]["BALANCEDASHA"].ToString();
                    tempdb = tempdb.Replace("Balance Of Dasha :", "");
                    tempdb = tempdb.Trim();
                    DataTable dt = new DataTable();
                    dt.TableName = "Table1";
                    dt.Columns.Add("BalanceDasha");
                    dt.Rows.Add(tempdb);
                    ds.Tables.Add(dt);
                }
            }
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet GetDayOfBirth(string DOB)
    {
        DataSet ds = new DataSet();
        if (DOB != "")
        {
            string dateofbirth = DOB;
            dateofbirth = DateTime.ParseExact(dateofbirth, "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
            DateTime dtc = Convert.ToDateTime(dateofbirth);
            DataTable dt = new DataTable();
            dt.TableName = "Table1";
            dt.Columns.Add("DayOB");
            dt.Rows.Add(dtc.DayOfWeek.ToString());
            ds.Tables.Add(dt);
            //hddayofbirth.Value = dtc.DayOfWeek.ToString();
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet GetDayNightDuration(string SunRise, string SunSet, string SunRiseNext)
    {
        DataSet ds = new DataSet();
        if (SunRise != "")
        {
            DateTime sr = new DateTime();
            sr = Convert.ToDateTime(SunRise.Trim());
            DateTime ss = new DateTime();
            ss = Convert.ToDateTime(SunSet.Trim());
            DateTime srn = new DateTime();
            srn = Convert.ToDateTime(SunRiseNext.Trim());

            TimeSpan ts_daylength = ss.Subtract(sr);
            //hdndayduration.Value = Convert.ToString(ts_daylength).Trim();
            string daylength = Convert.ToString(ts_daylength).Trim();
            TimeSpan ts_nightlength = srn.Subtract(ss);
            //hdnnightduration.Value = Convert.ToString(ts_nightlength).Trim();
            string nightlength = Convert.ToString(ts_nightlength).Trim();
            DataTable dt = new DataTable();
            dt.TableName = "Table1";
            dt.Columns.Add("DayDuration");
            dt.Columns.Add("NightDuration");
            dt.Rows.Add(daylength, nightlength);
            ds.Tables.Add(dt);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet get_horaryquestion_ans(string combination, string lagnarashi, string mainfilerdrop, string subfilterdrop, string astrologer, string clmail)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_horary_comb(combination, lagnarashi, mainfilerdrop, subfilterdrop, astrologer, clmail);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet get_allhorarynatal_question(string cartid, string usertype, string groupid, string catid, string flag)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = obj_subs.GetAddToCart(cartid, usertype, groupid, catid, flag);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public string update_horaryquestion_ans(int Autoid, int Questionid, string Answer, string flag)
    {
        DataSet dsm = new DataSet();
        obj_subs.update_horaryquestion_ans(Autoid, Questionid, Answer, flag);
        return "";
    }


    [Ajax.AjaxMethod]
    public DataSet get_natal_questions_substring(string catid, string questionid, string questionval, string flag)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = obj_subs.get_natal_questions_substring(catid, questionid, questionval, flag);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet get_natalquestion_ans(string s, string ss, string kk, string rashi, string key, string planets, string chart, string astrologer1)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = obj_subs.get_natalquestion_ans(s, ss, kk, rashi, key, planets, chart, astrologer1);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet get_natalquestion_ans_temp(string s, string ss, string kk, string rashi, string key, string planets, string chart, string astrologer1, string sessionid, string actionflag)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = obj_subs.get_natalquestion_ans_temp(s, ss, kk, rashi, key, planets, chart, astrologer1, sessionid, actionflag);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public string update_natalquestion_ans(int Autoid, int Questionid, string Answer, string flag)
    {
        DataSet dsm = new DataSet();
        obj_subs.update_natalquestion_ans(Autoid, Questionid, Answer, flag);
        return "";
    }

    [Ajax.AjaxMethod]
    public DataSet pn(string main, string s, string m, string v, string astro)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.pun(main, s, m, v, astro);
        }
        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet Get_Manglik_Dosha_Result(string planet, string lagnachart, string moonchart, string venuschart, string lagnapoints, string moonpoints, string venuspoints, string doshaflag, string flag, string noofplanet)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = obj_subs.Get_Manglik_Dosha_Result(planet, lagnachart, moonchart, venuschart, lagnapoints, moonpoints, venuspoints, doshaflag, flag, noofplanet);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet Get_Dosha_Samya_Result(string planet, string lagnachart, string moonchart, string venuschart, string lagnapoints, string moonpoints, string venuspoints, string doshaflag, string flag, string noofplanet)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = obj_subs.Get_Dosha_Samya_Result(planet, lagnachart, moonchart, venuschart, lagnapoints, moonpoints, venuspoints, doshaflag, flag, noofplanet);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet get_natal_yoga(string rashihouse, string listitem)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_listbox_str(rashihouse, listitem);
        }
        return ds;
    }

    //[Ajax.AjaxMethod]
    //public DataSet Get_Kaal_Sarpa_Dosha(string BoyId,string GirlId, string Flag)
    //{
    //    DataSet ds = new DataSet();
    //    if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ASTROLOGY.classesoracle.compatibilitymatching objcom = new ASTROLOGY.classesoracle.compatibilitymatching();
    //        ds = objcom.GetKaalSarpaYogaReport(BoyId, GirlId, "GET_MATCHING_REPORT");
    //    }
    //    return ds;
    //}


    [Ajax.AjaxMethod]
    public DataSet UpdateToCartBilling_UserId(int clientid, string cartid, string PaymentFor, string UserID)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.subscription obj_sub = new ASTROLOGY.classesoracle.subscription();
            string Flag = "UPDATEBILLINGUSERID";
            if (PaymentFor == "TALK_TO_ASTROLOGER" || PaymentFor == "PERSONAL_MEETING" || PaymentFor == "CONSULT_AN_ASTROLOGER")
            {
                Flag = "UpdateClientID";
            }
            ds = obj_sub.UpdateToCartBilling(clientid, cartid, "", "", "", "", "", Flag);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet GetManglikDosha(string UserId, string flag)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.compatibilitymatching Objcom = new ASTROLOGY.classesoracle.compatibilitymatching();
            ds = Objcom.GetManglikDosha(UserId, flag);
        }
        return ds;
    }

    public string GetCountryCode()
    {
        long w, x, y, z, IPNumber;
        String hostName = System.Net.Dns.GetHostName();
        IPHostEntry localIpAddresses = Dns.GetHostEntry(hostName);
        string publicIP = localIpAddresses.AddressList[0].ToString();
        string CountryCode = "IN";
        String[] splitIP = publicIP.Split('.');
        if (splitIP.Length > 3)
        {
            w = Convert.ToInt32(splitIP[0]);
            x = Convert.ToInt32(splitIP[1]);
            y = Convert.ToInt32(splitIP[2]);
            z = Convert.ToInt32(splitIP[3]);
            IPNumber = (16777216 * w) + (65536 * x) + (256 * y) + (z);
            DataSet dscd = new DataSet();
            dscd = obj_subs.AstGetCommon(IPNumber.ToString(), "", "", "GETCOUNTRYCODE");
            if (dscd.Tables[0].Rows.Count > 0)
            {
                CountryCode = dscd.Tables[0].Rows[0]["COUNTRY_CODE"].ToString();
            }
        }
        return CountryCode;
    }
}