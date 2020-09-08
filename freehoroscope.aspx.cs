using System;
using System.Configuration;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASTROLOGY.classesoracle;
using System.Diagnostics;
using System.IO;
using kundli4c;
using System.Web;
using System.Web.UI.HtmlControls;

public partial class freehoroscope : System.Web.UI.Page
{
    common cs = new common();
    subscription objsub = new subscription();
    DataSet ds = new DataSet();
    public string NatalEndUserAstrologerIDVal = ConfigurationManager.AppSettings["NatalEndUserAstrologerID"].ToString();
    public string NatalEndUserAstrologerNameVal = ConfigurationManager.AppSettings["NatalEndUserAstrologerName"].ToString();
    string astrologer = "", astmail = "", astrologername = "", usermail = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Ajax.Utility.RegisterTypeForAjax(typeof(freehoroscope));

            if (Session["UserEmailID"] == null)
            {
                //Session["CurrentPage"] = "free-horoscope";
                Response.Redirect(ResolveUrl("signin.html?flag=free-horoscope"));
            }
            //if (Session["MySessionID"] != null)
            //{
            //    string CartID = Session["MySessionID"].ToString();
            //    ViewState["MyCartId"] = Session["MySessionID"].ToString().Trim();
            //}
            if (!IsPostBack)
            {
                form1.Attributes.Add("onload", "javascript:return Bind_DateMonthYear();");
                usermail = NatalEndUserAstrologerIDVal;
                hdnuser.Value = NatalEndUserAstrologerIDVal;
                username.Value = NatalEndUserAstrologerNameVal;
                astrologer = NatalEndUserAstrologerIDVal;
                astmail = NatalEndUserAstrologerIDVal;
                astrologername = NatalEndUserAstrologerNameVal;

                //bindbirth();
                //bindplanet();
                //bindchart();
                //bindyogas();
                hdnflag.Value = "0";
                hdncat.Value = "natal";
                hdngroup.Value = "Astro Envision Natal";
                hdngroup_u.Value = "natal";
                mainchannelbind();
                //if (Request.QueryString["flag"] != null)
                //{
                //    if (Request.QueryString["matchwith"] != null)
                //    {
                //        hfmatchwithid.Value = Request.QueryString["matchwith"].Trim();
                //        rblgender.SelectedValue = Request.QueryString["flag"].ToString().Trim();
                //        rblgender.Enabled = false;
                //        if (Request.QueryString["flag"].Trim() == "M")
                //        {
                //            headingh1.InnerText = "Enter the Birth Details of the Boy";
                //        }
                //        if (Request.QueryString["flag"].Trim() == "F")
                //        {
                //            headingh1.InnerText = "Enter the Birth Details of the Girl";
                //        }
                //    }
                //    else
                //    {
                //        rblgender.SelectedValue = Request.QueryString["flag"].ToString().Trim();
                //        rblgender.Enabled = false;
                //        if (Request.QueryString["flag"].Trim() == "M")
                //        {
                //            headingh1.InnerText = "Enter Your Birth Details as - Boy";
                //        }
                //        if (Request.QueryString["flag"].Trim() == "F")
                //        {
                //            headingh1.InnerText = "Enter Your Birth Details as - Girl";
                //        }
                //    }
                //}
                //else
                //{
                //    rblgender.Enabled = true;
                //    headingh1.InnerText = "Enter Your Birth Details";
                //}
                ddlCity.Attributes.Add("onchange", "javascript:return insert_data(id);");
                //mn.Attributes.Add("onkeypress", "javascript:return numeric(event)");
                btnsave.Attributes.Add("onclick", "javascript:return cl_dtls();");

                string Domainurl = Request.Url.Scheme + System.Uri.SchemeDelimiter + Request.Url.Host;
                string url = Domainurl + HttpContext.Current.Request.RawUrl;
                HtmlLink tag = new HtmlLink();
                tag.Attributes.Add("rel", "canonical");
                tag.Href = url;
                Header.Controls.Add(tag);  // This Line is used without Master Page
                //Master.FindControl("head").Controls.Add(tag); // This Line is used with Master Page
            }
        }
        catch (Exception ex)
        {
            throw ex;
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

        DataSet dsc = objsub.GetDateMonthYearHourMinute("");
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
    public DataSet savecharts_enduser(string d01, string d02, string d03, string d04, string d05, string d06, string d07, string d08, string d09, string d10, string d11, string d12, string d16, string d20, string d24, string d27, string d30, string d40, string d45, string d60, string kl, string astid, string astname, string client, string clientid, string dasha, string dob, string tob, string countr, string state, string district, string city, string group, string group_u, string prof, string sex, string mobile, string sunsetpre, string sunrise, string sunset, string sunrisenext, string dayofborth, string rashi, string constellation, string longitude, string latitude, string timezone, string dayduration, string nightduration, string balancedasha, string ClientEmailId, string pwd, string lagnarashi, string chartdetails, string matchwith, string lagnachart, string moonchart, string venuschart, string UserType, string RegUserId, string RegUserEmailId,string Cartid, string AstrologerId)
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

    //[Ajax.AjaxMethod]
    //public DataSet pn(string main, string s, string m, string v, string astro)
    //{
    //    DataSet ds = new DataSet();
    //    if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
    //        ds = country.pun(main, s, m, v, astro);
    //    }
    //    return ds;
    //}


    //[Ajax.AjaxMethod]
    //public DataSet Get_Manglik_Dosha_Result(string planet, string lagnachart, string moonchart, string venuschart, string lagnapoints, string moonpoints, string venuspoints, string doshaflag, string flag, string noofplanet)
    //{
    //    DataSet ds = new DataSet();
    //    if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
    //        ds = obj_subs.Get_Manglik_Dosha_Result(planet, lagnachart, moonchart, venuschart, lagnapoints, moonpoints, venuspoints, doshaflag, flag, noofplanet);
    //    }
    //    return ds;
    //}

    //[Ajax.AjaxMethod]
    //public DataSet Get_Dosha_Samya_Result(string planet, string lagnachart, string moonchart, string venuschart, string lagnapoints, string moonpoints, string venuspoints, string doshaflag, string flag, string noofplanet)
    //{
    //    DataSet ds = new DataSet();
    //    if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
    //        ds = obj_subs.Get_Dosha_Samya_Result(planet, lagnachart, moonchart, venuschart, lagnapoints, moonpoints, venuspoints, doshaflag, flag, noofplanet);
    //    }
    //    return ds;
    //}


    //[Ajax.AjaxMethod]
    //public DataSet GetDateMonthYearHourMinute(string Flag)
    //{
    //    DataSet ds = new DataSet();
    //    if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ASTROLOGY.classesoracle.subscription objsub = new ASTROLOGY.classesoracle.subscription();
    //        ds = objsub.GetDateMonthYearHourMinute(Flag);
    //    }
    //    return ds;
    //}

}