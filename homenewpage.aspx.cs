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
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Drawing.Drawing2D;
using kundli4c;
using ASTROLOGY.classesoracle;

public partial class homenewpage : System.Web.UI.Page
{ 
    string clmail="";
    string clname = "";
    string asmail = "";
    string asname = "";
    string degreeasc = "";
    string usermail="";
    myaccount objmc = new myaccount();
    protected void Page_Load(object sender, EventArgs e)
    {
        string gulikatob="";
        common cs = new common();
        Ajax.Utility.RegisterTypeForAjax(typeof(homenewpage));
        hdngroup.Value = Request.QueryString["group"];

        hdngroup_u.Value = Request.QueryString["group_u"];
        hdnmobile.Value = Request.QueryString["mobile"];

        hdndob.Value = Request.QueryString["dob"];
        hdnidob.Value = Request.QueryString["da1ofb"];
        hdnimoob.Value = Request.QueryString["mo1ofb"];
        hdniyob.Value = Request.QueryString["yr1ofb"];

        hdntob.Value = Request.QueryString["tob"];
        hdnihob.Value = Request.QueryString["hourofb"];
        hdnimob.Value = Request.QueryString["minuteofb"];

        hdncountry.Value = Request.QueryString["country"];
        hdnstate.Value = Request.QueryString["state"];
        hdndist.Value = Request.QueryString["dist"];
        hdncity.Value = Request.QueryString["city"];
        hdnlatit.Value = Request.QueryString["latit"];
        hdnlongit.Value = Request.QueryString["longit"];
        hdntzo.Value = Request.QueryString["tzo"];
        hdntzval.Value = Request.QueryString["tzoval"];

        hdnprof.Value = Request.QueryString["prof"];
        hdnsex.Value = Request.QueryString["sex"];
        hdnmoc.Value = Request.QueryString["cd"];

        hdsunsetpre.Value = Request.QueryString["sunsetpre"];
        hdsunrise.Value = Request.QueryString["sunrise"];
        hdsunset.Value = Request.QueryString["sunset"];
        hdsunrisenext.Value = Request.QueryString["sunrisenext"];
        hdnastmail.Value = Request.QueryString["astmail"];
        hdnquery.Value = Request.QueryString["query"];
        if (hdnquery.Value!="")
        {
            clientqueryid.InnerHtml = "Querist's Query: " + hdnquery.Value + "";
        }

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

        if (Session["usermail"] == null || Session["usermail"].ToString() == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(homenewpage), "wq", "window.parent.location.href='login.aspx';", true);
            return;
        }
        usermail = Request.QueryString["usermail"];
        hdnuser.Value = Request.QueryString["usermail"];
       
        if (usermail != Session["usermail"].ToString())
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(homenewpage), "wq", "window.parent.location.href='login.aspx';", true);
            //Response.Redirect("login.aspx");
            return;
        }
       
            
        if (!Page.IsPostBack)
        {
            bindbirth();
            bindplanet();
            //D01.Attributes.Add("onclick", "javascript:return search(id);");
            ImageButton1.Attributes.Add("onclick", "javascript:return vargaschart();");
            calvargas.Attributes.Add("onclick", "javascript:return calvargas();");
            //clientid.Attributes.Add("onchange", "javascript:return searchclientid();");
            ImageButton2.Attributes.Add("Onclick", "javascript:return newc1l();");
            ImageButton5.Attributes.Add("onclick", "javascript:return chartindexdata();");
            dp.Attributes.Add("onclick", "javascript:return dashapattern();");
            transit.Attributes.Add("onclick", "javascript:return transit();");

            //b1.Attributes.Add("onclick", "javascript:return abc1();");
           
           //if (Session["usermail"] != "ASTROLOGY" && Session["usermail"] != "astrology")
           //{
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

                ds = country.ast_rights(Request.QueryString["usermail"].ToString());
            }
            if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Both")
            {

               
            }
            if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Natal")
            {
                horarydiv.Attributes.Add("style", "display:none;");
                // a8.Attributes.Add("style", "display:none;");
                //a7l.Attributes.Add("style", "display:none;");
                //a8l.Attributes.Add("style", "display:none;");
                //horarycombina.Attributes.Add("style", "visibility:hidden;");
            }
            if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Horary")
            {
                //a2.Attributes.Add("style", "display:none;");
                nataldiv.Attributes.Add("style", "display:none;");
                //a2l.Attributes.Add("style", "display:none;");
                //a3l.Attributes.Add("style", "display:none;");
                //a4l.Attributes.Add("style", "display:none;");
                //a5l.Attributes.Add("style", "display:none;");
                //a6l.Attributes.Add("style", "display:none;");

                //d2.Attributes.Add("style", "visibility:hidden;");
                //yoga.Attributes.Add("style", "visibility:hidden;");
                //astrocalc.Attributes.Add("style", "visibility:hidden;");
            }
            ds.Dispose();

            if (Request.QueryString["clmail"] == null || Request.QueryString["clmail"] == "")
            {
                clmail = "";
            }

            if ( Request.QueryString["clname"]== null|| Request.QueryString["clname"] == "")
            {
                clname = "";
            }

            if (Request.QueryString["astname"] == null || Request.QueryString["astname"] == "")
            {
                asname = "";
            }

            if (Request.QueryString["astmail"] == null || Request.QueryString["astmail"] == "")
            {
                asmail = "";
            }
         
            clmail = Request.QueryString["clmail"];                 
            clname = Request.QueryString["clname"];
            asname = Request.QueryString["astname"];
            asmail = Request.QueryString["astmail"];

            Hclmail.Value = clmail;
            Hclname.Value = clname;
            Hastmail.Value = asmail;
            Hastname.Value = asname;

            kundli4c.clskundli obj = new clskundli();

            if (hdnmoc.Value != "2")
            {
                short dateofbirth = short.Parse(hdnidob.Value);
                short monthofbirth = short.Parse(hdnimoob.Value);
                short yearofbirth = short.Parse(hdniyob.Value);

                short hourofbirth = short.Parse(hdnihob.Value);
                short minuteofbirth = short.Parse(hdnimob.Value);
                short secondofbirth = short.Parse("0");

                double tdiff1 = double.Parse("-5.5");
                double longitude = double.Parse((hdnlongit.Value).ToString());
                double latitude = double.Parse((hdnlatit.Value).ToString());

                double asccal = obj.asccalcul(dateofbirth, monthofbirth, yearofbirth, hourofbirth, minuteofbirth, secondofbirth, tdiff1, longitude, latitude);
                hdnasc.Value = asccal.ToString();

                
                string dobval = hdndob.Value, dayofweek = "", GulikaType = "", dinmanval = "", ratrimanval = "";
                string tobval = hdntob.Value;  //hourofbirth + ":" + minuteofbirth;

                string sunsetpreval = hdsunsetpre.Value;
                string sunsetpretime = sunsetpreval.Substring(sunsetpreval.LastIndexOf(' ') + 1);
                sunsetpretime = sunsetpretime.Substring(0, sunsetpretime.Length - 0); // -3

                string sunriseval = hdsunrise.Value;
                string sunrisetime = sunriseval.Substring(sunriseval.LastIndexOf(' ') + 1);
                sunrisetime = sunrisetime.Substring(0, sunrisetime.Length - 0);

                string sunsetval = hdsunset.Value;
                string sunsettime = sunsetval.Substring(sunsetval.LastIndexOf(' ') + 1);
                sunsettime = sunsettime.Substring(0, sunsettime.Length - 0);

                string sunrisenextval = hdsunrisenext.Value;
                string sunrisetimenext = sunrisenextval.Substring(sunrisenextval.LastIndexOf(' ') + 1);
                sunrisetimenext = sunrisetimenext.Substring(0, sunrisetimenext.Length - 0);

                DateTime t1 = DateTime.Parse(sunrisetime);
                DateTime t2 = DateTime.Parse(sunsettime);
                DateTime t3 = DateTime.Parse(tobval);
                DateTime t4 = DateTime.Parse(sunrisetimenext);
                DateTime t5 = DateTime.Parse(sunsetpretime);

                if (t3.TimeOfDay <= t1.TimeOfDay)
                {
                    dobval = hdndob.Value; //hdnidob.Value + "/" + hdnimoob.Value + "" + hdniyob.Value;
                    dobval = DateTime.ParseExact(dobval, "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
                    DateTime dtc = Convert.ToDateTime(dobval);
                    dayofweek = dtc.DayOfWeek.ToString();
                    dayofweek = dtc.AddDays(-1).DayOfWeek.ToString();
                    dayofweek = dayofweek.ToUpper();
                }
                else
                {
                    dobval = hdndob.Value;
                    dobval = DateTime.ParseExact(dobval, "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
                    DateTime dtc = Convert.ToDateTime(dobval);
                    dayofweek = dtc.DayOfWeek.ToString();
                    dayofweek = dayofweek.ToUpper();
                }

                if (t1.TimeOfDay <= t2.TimeOfDay)
                {
                    DataSet dsg = new DataSet();
                    dsg = GetGulikaInfo(dayofweek);
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
                            hdgulikatime.Value = ll.ToString();
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
                            hdgulikatime.Value = ll.ToString();
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
                            hdgulikatime.Value = ll.ToString();
                        }
                    }

                    gulikaid.InnerText = "" + GulikaType + " Gulika time :---- " + hdgulikatime.Value + " Minute";
                    dayofweekid.InnerText = "Day :---- " + dayofweek + "";
                    dinmanid.InnerText = "Dinman :---- " + dinmanval + "";
                    ratmanid.InnerText = "Ratriman :---- " + ratrimanval + "";
                    sunsetpreid.InnerText = "Sunset Previous time :-- " + hdsunsetpre.Value + "";
                    sunriseid.InnerText = "Sunrise time :---- " + hdsunrise.Value + "";
                    sunsetid.InnerText = "Sunset time :---- " + hdsunset.Value + "";
                    sunrisenestid.InnerText = "Sunrise Next time :-- " + hdsunrisenext.Value + "";

                    if (t3.TimeOfDay <= t1.TimeOfDay && t3.TimeOfDay <= t2.TimeOfDay)
                    {
                        DateTime sspt = DateTime.Parse(sunsetpreval);
                        int gt = int.Parse(hdgulikatime.Value);

                        TimeSpan time = new TimeSpan(0, 0, gt, 0);
                        DateTime combined = sspt.Add(time);

                        gulikatob = combined.ToString("MM/dd/yyyy HH:mm:ss");
                        string timezoneval = hdntzo.Value;


                        DateTime gulikatobgulika = DateTime.Parse(gulikatob);
                        DateTime time1;
                        hdntzo.Value = Math.Round(Double.Parse(hdntzo.Value), 2).ToString("0.00");
                        if (hdntzo.Value.IndexOf(".") > -1)
                        {
                            time1 = DateTime.Parse(hdntzo.Value.Replace(".", ":").Replace("-", ""));
                        }
                        else
                        {
                            if (timezoneval.IndexOf("-") > -1)
                            {
                                hdntzo.Value = hdntzo.Value.Replace("-", "") + ":00";
                                time1 = DateTime.Parse(hdntzo.Value);
                            }
                            else
                            {
                                hdntzo.Value = hdntzo.Value + ":00";
                                time1 = DateTime.Parse(hdntzo.Value);
                            }
                        }
                        DateTime timetz = DateTime.Parse("5:30");
                        TimeSpan combined1 = new TimeSpan();
                        if (timezoneval.IndexOf("-") > -1)
                        {
                            hdntzo.Value = hdntzo.Value.Replace(".", ":").Replace("-", "");
                            TimeSpan spantimezone = TimeSpan.Parse(hdntzo.Value);
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
                        int gt = int.Parse(hdgulikatime.Value);

                        TimeSpan time = new TimeSpan(0, 0, gt, 0);
                        DateTime combined = srt.Add(time);

                        gulikatob = combined.ToString("MM/dd/yyyy HH:mm:ss");

                        string timezoneval = hdntzo.Value;
                        DateTime gulikatobgulika = DateTime.Parse(gulikatob);
                        DateTime time1;
                        hdntzo.Value = Math.Round(Double.Parse(hdntzo.Value), 2).ToString("0.00");
                        if (hdntzo.Value.IndexOf(".") > -1)
                        {
                            time1 = DateTime.Parse(hdntzo.Value.Replace(".", ":").Replace("-", ""));
                        }
                        else
                        {
                            if (timezoneval.IndexOf("-") > -1)
                            {
                                hdntzo.Value = hdntzo.Value.Replace("-", "") + ":00";
                                time1 = DateTime.Parse(hdntzo.Value);
                            }
                            else
                            {
                                hdntzo.Value = hdntzo.Value + ":00";
                                time1 = DateTime.Parse(hdntzo.Value);
                            }
                        }

                        DateTime timetz = DateTime.Parse("5:30");
                        TimeSpan combined1 = new TimeSpan();
                        if (timezoneval.IndexOf("-") > -1)
                        {
                            hdntzo.Value = hdntzo.Value.Replace(".", ":").Replace("-", "");
                            TimeSpan spantimezone = TimeSpan.Parse(hdntzo.Value);
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
                        int gt = int.Parse(hdgulikatime.Value);

                        TimeSpan time = new TimeSpan(0, 0, gt, 0);
                        DateTime combined = sst.Add(time);

                        gulikatob = combined.ToString("MM/dd/yyyy HH:mm:ss");

                        string timezoneval = hdntzo.Value;
                        DateTime gulikatobgulika = DateTime.Parse(gulikatob);
                        DateTime time1;
                        hdntzo.Value = Math.Round(Double.Parse(hdntzo.Value), 2).ToString("0.00");
                        if (hdntzo.Value.IndexOf(".") > -1)
                        {
                            time1 = DateTime.Parse(hdntzo.Value.Replace(".", ":").Replace("-", ""));
                        }
                        else
                        {
                            if (timezoneval.IndexOf("-") > -1)
                            {
                                hdntzo.Value = hdntzo.Value.Replace("-", "") + ":00";
                                time1 = DateTime.Parse(hdntzo.Value);
                            }
                            else
                            {
                                hdntzo.Value = hdntzo.Value + ":00";
                                time1 = DateTime.Parse(hdntzo.Value);
                            }
                        }
                        DateTime timetz = DateTime.Parse("5:30");
                        TimeSpan combined1 = new TimeSpan();
                        if (timezoneval.IndexOf("-") > -1)
                        {
                            hdntzo.Value = hdntzo.Value.Replace(".", ":").Replace("-", "");
                            TimeSpan spantimezone = TimeSpan.Parse(hdntzo.Value);
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
                    gulikaval.Value = gulikacalculation.ToString();

                    ds.Dispose();
                }
            }

        }
    }


    public DataSet GetGulikaInfo(string dayname)
    {
        DataSet ds = new DataSet();
        ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
        ds = country.GetGulikaInfo(dayname);
        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet maketransition(string dob, string tob, string flag)
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
    public DataSet bindrashi(string vishu)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_rashi(vishu);
        }
        return ds;
    }
   [Ajax.AjaxMethod]
    public DataSet makebirthchart(string dob, string tob, double tzon, double ascca, double gulca)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_makebirthchart(dob, tob, tzon, ascca, gulca);
        }
        return ds;
    } 

    [Ajax.AjaxMethod]
    public DataSet bindbirth(string vishu)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_birth(vishu);
        }
        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet bindhouse(string vishu)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
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
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
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
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
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
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
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
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
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
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_constellation(vishu);
        }
        return ds;
    }



    

    public void bindplanet()
    {
        planet.Items.Clear();
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_planet("");
        }

        //hdncompcode.Value
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

    [Ajax.AjaxMethod]
    public DataSet housevalue(string house, string rashi, string selectedrashi)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.housevalue(house, rashi, selectedrashi);
        }
        return ds;
    }
    [Ajax.AjaxMethod]
    public DataSet rashivalue(string house, string rashi, string selectedhouse)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.rashivalue(house, rashi, selectedhouse);
        }
        return ds;
    }
    [Ajax.AjaxMethod]
    public DataSet getconstellation(string rashi, string degreevalue)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.getconstellation(rashi, degreevalue);
        }
        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet searchclientid(string clientname, string astroname, string astid1, string group, string groupu,string clientid)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.searchclientid(clientname, astroname, astid1, group, groupu, clientid);
        }
        return ds;
    }



    public void bindbirth()
    {
        birth.Items.Clear();
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_birth("");
        }

        //hdncompcode.Value
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

    protected void b1_Click(object sender, EventArgs e)
    {
        //System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        //System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(bitmap as System.Drawing.Image);
        //graphics.CopyFromScreen(25, 25, 25, 25, bitmap.Size);
        //bitmap.Save(@"c:\myscreenshot.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        Bitmap bitmap = new Bitmap
       (Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

        Graphics graphics = Graphics.FromImage(bitmap as System.Drawing.Image);
        graphics.CopyFromScreen(750, 220, 1020, 430, bitmap.Size);
        bitmap.Save(@"c:\myscreenshot.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
    }

}
