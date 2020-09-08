using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.IO;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Diagnostics;
using kundli4c;
using ASTROLOGY.classesoracle;

public partial class transition : System.Web.UI.Page
{
    string c = "";
    string usermail = "";
    string v = "";
    string j = "";
    string k = "";
    short dateofbirth;
    short monthofbirth ;
    short yearofbirth;
    short hourofbirth;
    short minuteofbirth;
    short secondofbirth;
    double longitude;
    double tdiff1 ;
    double latitude;
    kundli4c.clskundli obj = new clskundli();
    common cs = new common();
    ASTROLOGY.classesoracle.myaccount objmc = new ASTROLOGY.classesoracle.myaccount();
    string gulikatob = "";
    protected void Page_Load(object sender, EventArgs e)
    {
       
        Ajax.Utility.RegisterTypeForAjax(typeof(transition));
        if (Session["usermail"] == null || Session["usermail"].ToString() == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(transition), "wq", "window.parent.location.href='login.aspx';", true);
            return;
        }
        usermail = Request.QueryString["usermail"];
        hdnuser.Value = Request.QueryString["usermail"];

        if (usermail != Session["usermail"].ToString())
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(transition), "wq", "window.parent.location.href='login.aspx';", true);
            //Response.Redirect("login.aspx");
            return;
        }
        if (Session["name"] != null)
        {
            username.Value = Session["name"].ToString();
        }
        c = Request.QueryString["c"].ToString();
        v = Request.QueryString["v"].ToString();
        j = Request.QueryString["j"].ToString();
        k = Request.QueryString["k"].ToString();
        astname.Text = Request.QueryString["astname"].ToString();
        astid.Text = Request.QueryString["astid"].ToString();
        clientname.Text = Request.QueryString["clientname"].ToString();
        clientid.Text = Request.QueryString["clientid"].ToString();
        Hastname.Value = Request.QueryString["astname"].ToString();
        Hastid.Value = Request.QueryString["astid"].ToString();
        Hclname.Value = Request.QueryString["clientname"].ToString();
        Hclid.Value = Request.QueryString["clientid"].ToString();

        hdndob.Value = Request.QueryString["dob"];
        hdntob.Value = Request.QueryString["tob"];
        hdncountry.Value = Request.QueryString["country"];
        hdnstate.Value = Request.QueryString["state"];
        hdndist.Value = Request.QueryString["district"];
        hdncity.Value = Request.QueryString["city"];
        hdngroup_u.Value = Request.QueryString["group_under"];
        hdngroup.Value = Request.QueryString["group"];
        hdnprof.Value = Request.QueryString["prof"];
        hdnsex.Value = Request.QueryString["sex"];
        hdnmobile.Value = Request.QueryString["mobile"];

        hdnidateob.Value = Request.QueryString["idateob"];
        hdnimonthob.Value = Request.QueryString["imonthob"];
        hdniyearob.Value = Request.QueryString["iyearob"];
        hdnihourob.Value = Request.QueryString["ihourob"];
        hdniminuteob.Value = Request.QueryString["iminuteob"];
        ttt.Text=hdnidateob.Value+'-'+hdnimonthob.Value+'-'+hdniyearob.Value+' '+hdnihourob.Value+':'+hdniminuteob.Value +":00";
        hdnlongit.Value = Request.QueryString["longitude"];
        hdnlatit.Value = Request.QueryString["latitude"];
        hdntzo.Value = Request.QueryString["tz"];
        hdntzval.Value = Request.QueryString["tzval"];
         dateofbirth = short.Parse(hdnidateob.Value);
         monthofbirth = short.Parse(hdnimonthob.Value);
         yearofbirth = short.Parse(hdniyearob.Value);

         hourofbirth = short.Parse(hdnihourob.Value);
         minuteofbirth = short.Parse(hdniminuteob.Value);
         secondofbirth = short.Parse("0");

         tdiff1 = double.Parse("-5.5");
         longitude = double.Parse((hdnlongit.Value).ToString());
         latitude = double.Parse((hdnlatit.Value).ToString());
       
        double asccal = obj.asccalcul(dateofbirth, monthofbirth, yearofbirth, hourofbirth, minuteofbirth, secondofbirth, tdiff1, longitude, latitude);
        hdnasc.Value = asccal.ToString();
        
        Hidden4.Value = v;
        Hiddencons.Value = c;
        Hidden1.Value = j;
        Hidden2.Value = k;
        hdnprevret1.Value = "";
        hdnprevret2.Value = "";
        hdnprevret3.Value = "";
        hdnprevret4.Value = "";
        hdnprevret5.Value = "";
        hdnprevret6.Value = "";
        hdnprevret7.Value = "";
        hdnprevret8.Value = "";
        hdnprevret9.Value = "";
        hdnprevret10.Value = "";
        if (!Page.IsPostBack)
        {
            yearp10.Attributes.Add("OnClick", "javascript:return add10year();");
            yearm10.Attributes.Add("OnClick", "javascript:return minus10year();");


            yearp1.Attributes.Add("OnClick", "javascript:return add1year();");
            yearm1.Attributes.Add("OnClick", "javascript:return minus1year();");

            monthp1.Attributes.Add("OnClick", "javascript:return add1month();");
            monthm1.Attributes.Add("OnClick", "javascript:return minus1month();");

            weekp1.Attributes.Add("OnClick", "javascript:return add1week();");
            weekm1.Attributes.Add("OnClick", "javascript:return minus1week();");
            sod.Attributes.Add("OnClick", "javascript:return soda();");

            dayp1.Attributes.Add("OnClick", "javascript:return add1day();");
            daym1.Attributes.Add("OnClick", "javascript:return minus1day();");

            hrp10.Attributes.Add("OnClick", "javascript:return add10hour();");
            hrm10.Attributes.Add("OnClick", "javascript:return minus10hour();");

            hrp1.Attributes.Add("OnClick", "javascript:return add1hour();");
            hrm1.Attributes.Add("OnClick", "javascript:return minus1hour();");


            mip10.Attributes.Add("OnClick", "javascript:return add10min();");
            mim10.Attributes.Add("OnClick", "javascript:return minus10min();");

            mip1.Attributes.Add("OnClick", "javascript:return add1min();");
            mim1.Attributes.Add("OnClick", "javascript:return minus1min();");
           

            DataSet ds = new DataSet();


            if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

                ds = country.ast_rights(Request.QueryString["astid"].ToString());

            }
            if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Both")
            {

                return;
            }
            if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Natal")
            {

                horarydiv.Attributes.Add("style", "display:none;");
                // a8.Attributes.Add("style", "display:none;");
                //a7l.Attributes.Add("style", "display:none;");
                //a8l.Attributes.Add("style", "display:none;");
                //horarycombina.Attributes.Add("style", "visibility:hidden;");
                return;
            }
            if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Horary")
            {
                // a2.Attributes.Add("style", "display:none;");
                nataldiv.Attributes.Add("style", "display:none;");
                //a2l.Attributes.Add("style", "display:none;");
                //a3l.Attributes.Add("style", "display:none;");
                //a4l.Attributes.Add("style", "display:none;");
                //a5l.Attributes.Add("style", "display:none;");
                //a6l.Attributes.Add("style", "display:none;");

                // d2.Attributes.Add("style", "visibility:hidden;");
                //yoga.Attributes.Add("style", "visibility:hidden;");
                //astrocalc.Attributes.Add("style", "visibility:hidden;");

                return;
            }
        }

    }


    

        [Ajax.AjaxMethod]
    public DataSet maketransition(string dob, string tob,string flag)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_maketransition(dob, tob, flag);
        }
        return ds;


    }


        

        [Ajax.AjaxMethod]
        public string asccalcul(short da1ob, short mo1ob, short yr1ob, short ihob, short imob, short secondofbirth, double tdiff1, double longitude, double latitude)
        {
            double asccal = obj.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, secondofbirth, tdiff1, longitude, latitude);
            //hdnasc.Value = asccal.ToString();
            return asccal.ToString(); 


        } 

    [Ajax.AjaxMethod]
    public DataSet makebirthchart(string dob, string tob, double tzon, double ascca, double gulca)
    {
       
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_makebirthchart(dob, tob, tzon, ascca,gulca);
        }
        return ds;
       
        
    } 

    [Ajax.AjaxMethod]
    public DataSet vargasvalue(string vargas)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {


            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.vargas(vargas);
        }
        return ds;

    }
    [Ajax.AjaxMethod]
    public DataSet vargasvalue1(string vargas)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {


            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.vargas(vargas);
        }
        return ds;

    }


    //[Ajax.AjaxMethod]
    //public DataSet savecharts(string d01, string d02, string d03, string d04, string d05, string d06, string d07, string d08, string d09, string d10, string d11, string d12, string d16, string d20, string d24, string d27, string d30, string d40, string d45, string d60, string kl, string astid, string astname, string client, string clientid, string dasha, string dob, string tob, string countr, string state, string district, string city, string group, string group_u, string prof, string sex, string mobile)
    //{

    //    DataSet ds = new DataSet();
    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
    //        ds = country.savecharts(d01, d02, d03, d04, d05, d06, d07, d08, d09, d10, d11, d12, d16, d20, d24, d27, d30, d40, d45, d60, kl, astid, astname, client, clientid, dasha, dob, tob, countr, state, district, city, group, group_u, prof, sex, mobile);
    //    }
    //    return ds;

    //}
    [Ajax.AjaxMethod]
    public DataSet chechduplicacy(string astid, string astname, string client, string clientid, string group, string groupu)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {


            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.chechduplicacy(astid, astname, client, clientid, group, groupu);
        }
        return ds;

    }
    [Ajax.AjaxMethod]
    public DataSet viewclientinfo(string astid, string clinid)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
            ds = country.ast_viewclientinfo(astid, clinid);
        }
        return ds;


    }

    [Ajax.AjaxMethod]
    public DataSet searchuser(string astrologer, string cat_grp)
    {
        DataSet ds = new DataSet();

        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.bind_user(astrologer, cat_grp);
        }

        return ds;
    }


    //[Ajax.AjaxMethod]
    //public DataSet viewyagas(string lagnarashi, string lagnadegree, string degree, string house)
    //{
    //    DataSet ds = new DataSet();
    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {

    //        Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
    //        ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
    //        ds = country.showyogas(lagnarashi, lagnadegree, degree, house);
    //    }
    //    return ds;

    //}



    //Deepak Nirwal Added New Methods

    [Ajax.AjaxMethod]
    public String getsunsetsunrise(String lati, string lngi, string astroname, string dob)
    {
        String datastore = "";
        // String getfilename = "";
        try
        {
            StreamReader sr;
            //Process myprocess;          
            astroname = astroname.Trim().Replace(" ", "");
            string binaddress = ConfigurationSettings.AppSettings["keyloc"].ToString();
            string pythoncodepath = ConfigurationSettings.AppSettings["sunrisesunset"].ToString();
            string sname = ConfigurationSettings.AppSettings["pythonexe"].ToString();

            String fname = binaddress + astroname + ".bat";
            string textfile = binaddress + astroname + ".txt";

            if (!File.Exists(fname))
                File.CreateText(fname).Close();

            if (!File.Exists(textfile))
                File.CreateText(textfile).Close();

            //bat file params

            string lat = lati;
            string lon = lngi;
            string curDate = Convert.ToDateTime(dob).ToString("yyyy/MM/dd");

            String batContent = "\"" + sname + "\" ";
            batContent += "\"" + pythoncodepath + "\" ";
            batContent += "\"" + lat + "\" ";
            batContent += "\"" + lon + "\" ";
            batContent += "\"" + curDate + "\" > ";
            batContent += "\"" + textfile + "\"";

            //end bat fileparams

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

    [Ajax.AjaxMethod]
    public DataSet getsunsetsunrisea(String sr, string tz, string ss, string dob)
    {
        dob = Convert.ToDateTime(dob).ToString("yyyy/MM/dd");
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ds = cs.actsrss(sr, tz, ss, dob);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public String getsunsetsunrise1(String lati, string lngi, string astroname, string dob)
    {

        String datastore = "";
        // String getfilename = "";
        try
        {
            StreamReader sr;
            //Process myprocess;
            astroname = astroname.Trim().Replace(" ", "");
            string binaddress = ConfigurationSettings.AppSettings["keyloc"].ToString();
            string pythoncodepath = ConfigurationSettings.AppSettings["sunrisesunset"].ToString();
            string sname = ConfigurationSettings.AppSettings["pythonexe"].ToString();

            String fname = binaddress + astroname + ".bat";
            string textfile = binaddress + astroname + ".txt";

            if (!File.Exists(fname))
                File.CreateText(fname).Close();

            if (!File.Exists(textfile))
                File.CreateText(textfile).Close();

            //bat file params

            string lat = lati;
            string lon = lngi;
            string curDate = Convert.ToDateTime(dob).AddDays(1).ToString("yyyy/MM/dd");

            String batContent = "\"" + sname + "\" ";
            batContent += "\"" + pythoncodepath + "\" ";
            batContent += "\"" + lat + "\" ";
            batContent += "\"" + lon + "\" ";
            batContent += "\"" + curDate + "\" > ";
            batContent += "\"" + textfile + "\"";

            //end bat fileparams
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

    [Ajax.AjaxMethod]
    public DataSet getsunsetsunriseanext(String sr, string tz, string ss, string dob)
    {
        dob = Convert.ToDateTime(dob).AddDays(1).ToString("yyyy/MM/dd");
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ds = cs.actsrss(sr, tz, ss, dob);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public String getsunsetsunrise2(String lati, string lngi, string astroname, string dob)
    {

        String datastore = "";
        // String getfilename = "";
        try
        {
            StreamReader sr;
            //Process myprocess;
            astroname = astroname.Trim().Replace(" ", "");
            string binaddress = ConfigurationSettings.AppSettings["keyloc"].ToString();
            string pythoncodepath = ConfigurationSettings.AppSettings["sunrisesunset"].ToString();
            string sname = ConfigurationSettings.AppSettings["pythonexe"].ToString();

            String fname = binaddress + astroname + ".bat";
            string textfile = binaddress + astroname + ".txt";

            if (!File.Exists(fname))
                File.CreateText(fname).Close();

            if (!File.Exists(textfile))
                File.CreateText(textfile).Close();

            //bat file params

            string lat = lati;
            string lon = lngi;
            string curDate = Convert.ToDateTime(dob).AddDays(-1).ToString("yyyy/MM/dd");

            String batContent = "\"" + sname + "\" ";
            batContent += "\"" + pythoncodepath + "\" ";
            batContent += "\"" + lat + "\" ";
            batContent += "\"" + lon + "\" ";
            batContent += "\"" + curDate + "\" > ";
            batContent += "\"" + textfile + "\"";

            //end bat fileparams
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

    [Ajax.AjaxMethod]
    public DataSet getsunsetsunriseapre(String sr, string tz, string ss, string dob)
    {
        dob = Convert.ToDateTime(dob).AddDays(-1).ToString("yyyy/MM/dd");
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ds = cs.actsrss(sr, tz, ss, dob);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public string GulikaCalculate(string dob_val,string tob_val,string sunsetpre_val,string sunrise_val,string sunset_val,string sunrisenext_val,string tz_val ,string latit_val,string longit_val)
    {
        DataSet dsg = new DataSet();
        string dobval = dob_val, dayofweek = "", GulikaType = "", dinmanval = "", ratrimanval = "", gulikatimeval = "", AscendantVal = "" ;
        string tobval = tob_val;  //hourofbirth + ":" + minuteofbirth;

        string sunsetpreval = sunsetpre_val;
        string sunsetpretime = sunsetpreval.Substring(sunsetpreval.LastIndexOf(' ') + 1);
        sunsetpretime = sunsetpretime.Substring(0, sunsetpretime.Length - 0); // -3

        string sunriseval = sunrise_val;
        string sunrisetime = sunriseval.Substring(sunriseval.LastIndexOf(' ') + 1);
        sunrisetime = sunrisetime.Substring(0, sunrisetime.Length - 0);

        string sunsetval = sunset_val;
        string sunsettime = sunsetval.Substring(sunsetval.LastIndexOf(' ') + 1);
        sunsettime = sunsettime.Substring(0, sunsettime.Length - 0);

        string sunrisenextval = sunrisenext_val;
        string sunrisetimenext = sunrisenextval.Substring(sunrisenextval.LastIndexOf(' ') + 1);
        sunrisetimenext = sunrisetimenext.Substring(0, sunrisetimenext.Length - 0);

        DateTime t1 = DateTime.Parse(sunrisetime);
        DateTime t2 = DateTime.Parse(sunsettime);
        DateTime t3 = DateTime.Parse(tobval);
        DateTime t4 = DateTime.Parse(sunrisetimenext);
        DateTime t5 = DateTime.Parse(sunsetpretime);

        if (t3.TimeOfDay <= t1.TimeOfDay)
        {
            dobval = dob_val; 
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
                    gulikatimeval = ll.ToString();
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
                    gulikatimeval = ll.ToString();
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
                    gulikatimeval = ll.ToString();
                }
            }
        }

        //Ascendant Calculation Start Here

        if (t3.TimeOfDay <= t1.TimeOfDay && t3.TimeOfDay <= t2.TimeOfDay)
        {
            DateTime sspt = DateTime.Parse(sunsetpreval);
            int gt = int.Parse(gulikatimeval);

            TimeSpan time = new TimeSpan(0, 0, gt, 0);
            DateTime combined = sspt.Add(time);

            gulikatob = combined.ToString("MM/dd/yyyy HH:mm:ss");
            string timezoneval = tz_val;

            DateTime gulikatobgulika = DateTime.Parse(gulikatob);
            DateTime time1;
            tz_val = Math.Round(Double.Parse(tz_val), 2).ToString("0.00");
            if (tz_val.IndexOf(".") > -1)
            {
                time1 = DateTime.Parse(tz_val.Replace(".", ":").Replace("-", ""));
            }
            else
            {
                if (timezoneval.IndexOf("-") > -1)
                {
                    tz_val = tz_val.Replace("-", "") + ":00";
                    time1 = DateTime.Parse(tz_val);
                }
                else
                {
                    tz_val = tz_val + ":00";
                    time1 = DateTime.Parse(tz_val);
                }
            }
            DateTime timetz = DateTime.Parse("5:30");
            TimeSpan combined1 = new TimeSpan();
            if (timezoneval.IndexOf("-") > -1)
            {
                tz_val = tz_val.Replace(".", ":").Replace("-", "");
                TimeSpan spantimezone = TimeSpan.Parse(tz_val);
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
            int gt = int.Parse(gulikatimeval);

            TimeSpan time = new TimeSpan(0, 0, gt, 0);
            DateTime combined = srt.Add(time);

            gulikatob = combined.ToString("MM/dd/yyyy HH:mm:ss");

            string timezoneval = tz_val;
            DateTime gulikatobgulika = DateTime.Parse(gulikatob);
            DateTime time1;
            tz_val = Math.Round(Double.Parse(tz_val), 2).ToString("0.00");
            if (tz_val.IndexOf(".") > -1)
            {
                time1 = DateTime.Parse(tz_val.Replace(".", ":").Replace("-", ""));
            }
            else
            {
                if (timezoneval.IndexOf("-") > -1)
                {
                    tz_val = tz_val.Replace("-", "") + ":00";
                    time1 = DateTime.Parse(tz_val);
                }
                else
                {
                    tz_val = tz_val + ":00";
                    time1 = DateTime.Parse(tz_val);
                }
            }

            DateTime timetz = DateTime.Parse("5:30");
            TimeSpan combined1 = new TimeSpan();
            if (timezoneval.IndexOf("-") > -1)
            {
                tz_val = tz_val.Replace(".", ":").Replace("-", "");
                TimeSpan spantimezone = TimeSpan.Parse(tz_val);
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
            int gt = int.Parse(gulikatimeval);

            TimeSpan time = new TimeSpan(0, 0, gt, 0);
            DateTime combined = sst.Add(time);

            gulikatob = combined.ToString("MM/dd/yyyy HH:mm:ss");

            string timezoneval = tz_val;
            DateTime gulikatobgulika = DateTime.Parse(gulikatob);
            DateTime time1;
            tz_val = Math.Round(Double.Parse(tz_val), 2).ToString("0.00");
            if (tz_val.IndexOf(".") > -1)
            {
                time1 = DateTime.Parse(tz_val.Replace(".", ":").Replace("-", ""));
            }
            else
            {
                if (timezoneval.IndexOf("-") > -1)
                {
                    tz_val = tz_val.Replace("-", "") + ":00";
                    time1 = DateTime.Parse(tz_val);
                }
                else
                {
                    tz_val = tz_val + ":00";
                    time1 = DateTime.Parse(tz_val);
                }
            }
            DateTime timetz = DateTime.Parse("5:30");
            TimeSpan combined1 = new TimeSpan();
            if (timezoneval.IndexOf("-") > -1)
            {
                tz_val = tz_val.Replace(".", ":").Replace("-", "");
                TimeSpan spantimezone = TimeSpan.Parse(tz_val);
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

        double tdiff1 = double.Parse("-5.5");

        double gulikacalculation = obj.asccalcul(gulikaday, gulikamonth, gulikayear, gulikah, gulikam, gulikas, tdiff1, Convert.ToDouble(longit_val),Convert.ToDouble(latit_val));
        //gulikaval.Value = gulikacalculation.ToString();
        AscendantVal = gulikacalculation.ToString();
        dsg.Dispose();

        //Ascendant Calculation End Here


        string finalval = gulikatimeval + "/" + dayofweek + "/" + AscendantVal;

        return finalval;
    }


}

