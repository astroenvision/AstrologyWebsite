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
using System.IO;
using System.Diagnostics;

public partial class astro_client : System.Web.UI.Page
{
    string astroname = "";
    long mno;
    string usermail = "";
    string asmail = "";
    string asname = "";
    common cs = new common();
    string astrologer = "";
    string clname = "";
    string astmail = "";
    string astname = "";
    string clmail = "";
    string name = "", profession = "", sex = "", astro_dtls = "null", cat_id = "", email = "", cat_grp = "";
    int age;
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(astro_client));

        //Start Deepak Add following line on 19/06/2020
        Session["usermail"] = "nataladmin@astroenvision.com";
        DropDownList2.SelectedValue = "NATAL";
        //if (cat.Items.Count > 0)
        //{
        //    cat.SelectedValue = "Astro Envision Natal";
        //}
        //End Deepak Add following line on 19/06/2020

        if (Session["usermail"] == null || Session["usermail"].ToString() == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(astro_client), "wq", "window.parent.location.href='login.aspx';", true);
            return;
        }
        usermail = Request.QueryString["usermail"];
        hdnuser.Value = Request.QueryString["usermail"];
        hdnflag.Value = Request.QueryString["flag"];
        if (Session["name"] != null)
        {
            username.Value = Session["name"].ToString();
        }

        if (usermail != Session["usermail"].ToString())
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(astro_client), "wq", "window.parent.location.href='login.aspx';", true);
            //Response.Redirect("login.aspx");
            return;
        }
        if (Session["usermail"].ToString() != "" && Session["usermail"] != null)
        {
            if (!IsPostBack)
            {
                astrologer = Session["usermail"].ToString();
                astmail = Session["usermail"].ToString();

                astname = Request.QueryString["astname"].ToString();
                hdnastname.Value = astname;
                mainchannelbind();

                if (hdnflag.Value == "1")
                {
                    hdnclmail.Value = Request.QueryString["clmail"];
                    hdnclname.Value = Request.QueryString["clname"];
                    hdnastname.Value = Request.QueryString["astname"];
                    hdnastmail.Value = Request.QueryString["astmail"];
                    hdnage.Value = Request.QueryString["age"];
                    hdnhob.Value = Request.QueryString["hob"];
                    hdnmiob.Value = Request.QueryString["miob"];

                    hdncon.Value = Request.QueryString["con"];
                    hdnstateu.Value = Request.QueryString["state"];
                    hdndist.Value = Request.QueryString["dist"];
                    hdncity.Value = Request.QueryString["city"];
                    hdngender.Value = Request.QueryString["gender"];
                    hdnmob.Value = Request.QueryString["mob"];
                    hdnprof.Value = Request.QueryString["prof"];
                    hdngroup.Value = Request.QueryString["group"];
                    hdngroupu.Value = Request.QueryString["groupcat"];

                    txtmail.Text = Request.QueryString["clmail"];
                    cl_name.Text = Request.QueryString["clname"];
                    cat.Items.Insert(0, Request.QueryString["group"]);
                    hob.Items.Insert(0, hdnhob.Value);
                    mob.Items.Insert(0, hdnmiob.Value);
                    DropDownList2.Items.Insert(0, Request.QueryString["groupcat"]);
                    mn.Text = Request.QueryString["mob"];
                    dob.Text = Request.QueryString["age"];
                    ddlcunt.Items.Insert(0, Request.QueryString["con"]);
                    ddlstat.Text = Request.QueryString["state"];
                    district.Text = Request.QueryString["dist"];
                    city.Text = Request.QueryString["city"];

                    cl_pro.Text = Request.QueryString["prof"];
                    cl_age.Text = Request.QueryString["age"];
                    if (Request.QueryString["gender"] == "M")
                    {
                        male.Checked = true;
                    }
                    else
                    {
                        female.Checked = true;
                    }
                    if (hdndist.Value != "")
                    {
                        district.Attributes.Add("style", "visibility:visible;");
                        dis.Attributes.Add("style", "visibility:visible;");
                    }

                    txtmail.Enabled = false;
                    submit.Enabled = false;
                    cat.Enabled = false;
                    DropDownList2.Enabled = false;
                    dob.Enabled = false;
                    hob.Enabled = false;
                    mob.Enabled = false;
                    ddlcunt.Enabled = false;
                    ddlstat.Enabled = false;
                    district.Enabled = false;
                    city.Enabled = false;
                    lng.Enabled = false;
                    lat.Enabled = false;
                    tz.Enabled = false;
                    //cal.Enabled = false;

                    logout.Attributes.Add("style", "visibility:visible;");
                    submit.Attributes.Add("style", "visibility:hidden;");
                    moc.Attributes.Add("style", "visibility:hidden;");
                }
                else
                {
                    logout.Attributes.Add("style", "visibility:hidden;");
                    submit.Attributes.Add("style", "visibility:visible;");
                    moc.Attributes.Add("style", "visibility:visible;");
                }
            }

            city.Attributes.Add("onkeyup", "javascript:return openroot(event);");
            city_list.Attributes.Add("onclick", "javascript:return insert_data(id);");
            ddlstat.Attributes.Add("onkeyup", "javascript:return state(event);");
            district.Attributes.Add("onkeyup", "javascript:return districtt(event);");
            state_list.Attributes.Add("onclick", "javascript:return insert_data(id);");
            district_list.Attributes.Add("onclick", "javascript:return insert_data(id);");
            cross.Attributes.Add("onclick", "javascript:return creossdiv();");
            cl_age.Attributes.Add("onkeypress", "javascript:return numeric(event)");
            mn.Attributes.Add("onkeypress", "javascript:return numeric(event)");
            submit.Attributes.Add("onclick", "javascript:return cl_dtls();");
            pqh.Attributes.Add("onclick", "javascript:return probquery();");
            moc.Attributes.Add("onclick", "javascript:return cl_dtls();");
            cat.Attributes.Add("onchange", "javascript:return newgroup();");
            logout.Attributes.Add("onclick", "javascript:return update_cl_dtls();");
            DropDownList2.Attributes.Add("Onchange", "javascript:return group_bind();");
            female.Attributes.Add("Onchange", "javascript:return fr();");
            male.Attributes.Add("Onchange", "javascript:return mr();");
            DataSet ds = new DataSet();

            if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                
                ds = country.ast_rights(Request.QueryString["usermail"].ToString());

            }
            if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Both")
            {
                hdncat.Value = ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString();
                return;

            }
            if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Natal")
            {
                DropDownList2.Enabled = false;
                ////horarydiv.Attributes.Add("style", "display:none;");
                hdncat.Value = ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString();

                // a8.Attributes.Add("style", "display:none;");
                //a7l.Attributes.Add("style", "display:none;");
                //a8l.Attributes.Add("style", "display:none;");
                //horarycombina.Attributes.Add("style", "visibility:hidden;");
                return;
            }
            if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Horary")
            {
                DropDownList2.Enabled = false;
                hdncat.Value = ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString();
                // a2.Attributes.Add("style", "display:none;");
                ////nataldiv.Attributes.Add("style", "display:none;");

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
        else
            ScriptManager.RegisterClientScriptBlock(this, typeof(astro_client), "wq", "alert('Your Session has Expired.');window.parent.location.href='login.aspx';", true);
    }


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
        // String getfilename = "";
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

            //myprocess = new Process();
            //myprocess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //myprocess.StartInfo.FileName = "\"" + fname + "\"";
            //myprocess.StartInfo.UseShellExecute = false;
            //myprocess.StartInfo.RedirectStandardError = false;
            //myprocess.StartInfo.RedirectStandardOutput = true;
            //myprocess.StartInfo.CreateNoWindow = false;
            //myprocess.Start();
            //myprocess.WaitForExit(120000);
            //myprocess.WaitForExit();

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
        // String getfilename = "";
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

            //myprocess = new Process();
            //myprocess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //myprocess.StartInfo.FileName = "\"" + fname + "\"";
            //myprocess.StartInfo.UseShellExecute = false;
            //myprocess.StartInfo.RedirectStandardError = false;
            //myprocess.StartInfo.RedirectStandardOutput = true;
            //myprocess.StartInfo.CreateNoWindow = false;
            //myprocess.Start();
            //myprocess.WaitForExit(120000);
            //myprocess.WaitForExit();

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
        // String getfilename = "";
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

            //myprocess = new Process();
            //myprocess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //myprocess.StartInfo.FileName = "\"" + fname + "\"";
            //myprocess.StartInfo.UseShellExecute = false;
            //myprocess.StartInfo.RedirectStandardError = false;
            //myprocess.StartInfo.RedirectStandardOutput = true;
            //myprocess.StartInfo.CreateNoWindow = false;
            //myprocess.Start();
            //myprocess.WaitForExit(120000);
            //myprocess.WaitForExit();

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

    public void mainchannelbind()
    {
        if (!Page.IsPostBack)
        {
            ds = cs.bindloc();
            ddlcunt.Items.Clear();
            ddlcunt.DataSource = ds;
            ddlcunt.DataTextField = "loc_name";
            ddlcunt.DataValueField = "loc_id";
            ddlcunt.DataBind();
            ddlcunt.Items.Insert(0, "--Select Country--");
        }
    }

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





    public void clear_data()
    {
        cl_name.Text = "";
        cl_pro.Text = "";
        cl_age.Text = "";
        mn.Text = "";
        // cl_gender.SelectedIndex = 0;

        DropDownList2.SelectedIndex = 0;
    }

    protected void logout_Click(object sender, EventArgs e)
    {
        Session["usermail"] = null;
        Session.Abandon();
        //Session["pass"] = null;
        ScriptManager.RegisterClientScriptBlock(this, typeof(astro_client), "wq", "alert('You have logged out!');window.parent.location.href='login.aspx';", true);
    }


    protected void horoscope_Click(object sender, EventArgs e)
    {

        Response.Redirect("homenewpage.aspx");

    }

}
