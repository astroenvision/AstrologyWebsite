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
using System.Diagnostics;
using kundli4c;
using ASTROLOGY.classesoracle;

public partial class futureyogas : System.Web.UI.Page
{
    string v = "";
    string lagnarashi = "";
    string lagnadegree = "";
    string degree = "";
    string house = "";
    string drop1 = "";
    string degreesecond = "";
    string moonrashi = "";
    string sunhouse = "";
    string moonhouse = "";
    string usermail = "";
    string asendrashi = "";
    string suninhouse = "";
    string mooninhouse = "";
    string marsinhouse = "";
    string mrecinhouse = "";
    string jupinhouse = "";
    string venusinhouse = "";
    string saturninhouse = "";
    string retro = "";
    string rashie = "";

    kundli4c.clskundli obj = new clskundli();
    common cs = new common();
    myaccount objmc = new myaccount();
    string gulikatob = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        Ajax.Utility.RegisterTypeForAjax(typeof(futureyogas));
        if (Session["usermail"] == null || Session["usermail"] == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(futureyogas), "wq", "window.parent.location.href='login.aspx';", true);
            return;
        }
        if (Session["name"] != null)
        {
            username.Value = Session["name"].ToString();
        }
        usermail = Request.QueryString["usermail"];
        hdnuser.Value = Request.QueryString["usermail"];
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
        if (usermail != Session["usermail"].ToString())
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(futureyogas), "wq", "window.parent.location.href='login.aspx';", true);
            //Response.Redirect("login.aspx");
            return;

        }
        if (!Page.IsPostBack)
        {
            horarykaryasidhi.Attributes.Add("Onclick", "javascript:return karyasiddhi();");
            naktabutton.Attributes.Add("Onclick", "javascript:return naktayogaitc();");
            yamyabut.Attributes.Add("Onclick", "javascript:return naktayogaitc();");
            cross.Attributes.Add("onclick", "javascript:return creossdiv();");
            vargaschart.Attributes.Add("onchange", "javascript:return showvargas();");
            //button_grid.Attributes.Add("onclick", "javascript:return cross_signi();");

            bindvargaschart();
            bindhouse();
            drop1 = Request.QueryString["drop1"].ToString();
            astname.Text = Request.QueryString["astname"].ToString();
            astid.Text = Request.QueryString["astmail"].ToString();
            clientname.Text = Request.QueryString["clname"].ToString();
            clientid.Text = Request.QueryString["clmail"].ToString();
            astrologername.Value = Request.QueryString["astname"].ToString();
            astrologerid.Value = Request.QueryString["astmail"].ToString();
            hdnidateob.Value = Request.QueryString["idateob"];
            hdnimonthob.Value = Request.QueryString["imonthob"];
            hdniyearob.Value = Request.QueryString["iyearob"];
            hdnihourob.Value = Request.QueryString["ihourob"];
            hdniminuteob.Value = Request.QueryString["iminuteob"];


            hdnidateobf.Value = Request.QueryString["idateob"];
            hdnimonthobf.Value = Request.QueryString["imonthob"];
            hdniyearobf.Value = Request.QueryString["iyearob"];
            hdnihourobf.Value = Request.QueryString["ihourob"];
            hdniminuteobf.Value = Request.QueryString["iminuteob"];

            hdnlongit.Value = Request.QueryString["longitude"];
            hdnlatit.Value = Request.QueryString["latitude"];

            hdndob.Value = Request.QueryString["dob"];
            hdntob.Value = Request.QueryString["tob"];
            hdntzo.Value = Request.QueryString["tz"];
            hdntzval.Value = Request.QueryString["tzval"];
            hdnquery.Value = Request.QueryString["query"];
            if (hdnquery.Value != "")
            {
                clientqueryid.InnerHtml = "Querist's Query: " + hdnquery.Value + "";
            }



            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

                ds = country.ast_rights(Request.QueryString["astmail"].ToString());

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


            }
            if (drop1 == "Karya Siddhi Yoga")
            {
                asendrashi = Request.QueryString["asendrashi"].ToString();
                suninhouse = Request.QueryString["suninhouse"].ToString();
                mooninhouse = Request.QueryString["mooninhouse"].ToString();
                marsinhouse = Request.QueryString["marsinhouse"].ToString();
                mrecinhouse = Request.QueryString["mrecinhouse"].ToString();
                jupinhouse = Request.QueryString["jupinhouse"].ToString();
                venusinhouse = Request.QueryString["venusinhouse"].ToString();
                saturninhouse = Request.QueryString["saturninhouse"].ToString();
                v = Request.QueryString["v"].ToString();
                Hiddenva.Value = v;
                Hasendrashi.Value = asendrashi;
                Hsuninhouse.Value = suninhouse;
                Hmooninhouse.Value = mooninhouse;
                Hmarsinhouse.Value = marsinhouse;
                Hmrecinhouse.Value = mrecinhouse;
                Hjupinhouse.Value = jupinhouse;
                Hvenusinhouse.Value = venusinhouse;
                Hsaturninhouse.Value = saturninhouse;
                Hdrop1.Value = drop1;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Test", "karyafun();", true);
            }
            else if ((drop1 == "Nakta Yoga") || drop1 == "Yamya Yoga")
            {
                naktabutton.Attributes.Add("style", "display:block");
                yamyabut.Attributes.Add("style", "display:none");
                foritchaaldiv.Attributes.Add("style", "display:none");
                if (drop1 == "Yamya Yoga")
                {
                    naktabutton.Attributes.Add("style", "display:none");
                    yamyabut.Attributes.Add("style", "display:block");
                    foritchaaldiv.Attributes.Add("style", "display:none");
                }

                lagnarashi = Request.QueryString["lagnarashi"].ToString();
                lagnadegree = Request.QueryString["lagnadegree"].ToString();
                degree = Request.QueryString["degree"].ToString();
                house = Request.QueryString["house"].ToString();

                degreesecond = Request.QueryString["degreesecond"].ToString();
                moonrashi = Request.QueryString["moonrashi"].ToString();
                sunhouse = Request.QueryString["sunhouse"].ToString();
                moonhouse = Request.QueryString["moonhouse"].ToString();

                Hlagnarashi.Value = lagnarashi;
                Hlagnadegree.Value = lagnadegree;
                Hdegree.Value = degree;
                Hhouse.Value = house;
                Hdrop1.Value = drop1;
                Hdegreesecond.Value = degreesecond;
                Hmoonrashi.Value = moonrashi;
                Hsunhouse.Value = sunhouse;
                Hmoonhouse.Value = moonhouse;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Test", "naktafun();", true);

            }
            else if ((drop1 == "Manau Yoga") || (drop1 == "Kamboola Yoga"))
            {

                lagnarashi = Request.QueryString["lagnarashi"].ToString();
                lagnadegree = Request.QueryString["lagnadegree"].ToString();
                degree = Request.QueryString["degree"].ToString();
                house = Request.QueryString["house"].ToString();

                degreesecond = Request.QueryString["degreesecond"].ToString();
                moonrashi = Request.QueryString["moonrashi"].ToString();
                sunhouse = Request.QueryString["sunhouse"].ToString();
                moonhouse = Request.QueryString["moonhouse"].ToString();

                Hlagnarashi.Value = lagnarashi;
                Hlagnadegree.Value = lagnadegree;
                Hdegree.Value = degree;
                Hhouse.Value = house;
                Hdrop1.Value = drop1;
                Hdegreesecond.Value = degreesecond;
                Hmoonrashi.Value = moonrashi;
                Hsunhouse.Value = sunhouse;
                Hmoonhouse.Value = moonhouse;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Test", "yogasgrid();", true);
            }

            else
            {
                foritchaaldiv.Attributes.Add("style", "display:block");
                lagnarashi = Request.QueryString["lagnarashi"].ToString();
                lagnadegree = Request.QueryString["lagnadegree"].ToString();
                degree = Request.QueryString["degree"].ToString();
                house = Request.QueryString["house"].ToString();
                v = Request.QueryString["v"].ToString();
                Hiddenva.Value = v;
                degreesecond = Request.QueryString["degreesecond"].ToString();
                moonrashi = Request.QueryString["moonrashi"].ToString();
                sunhouse = Request.QueryString["sunhouse"].ToString();
                moonhouse = Request.QueryString["moonhouse"].ToString();
                retro = Request.QueryString["retro"].ToString();
                rashie = Request.QueryString["rashie"].ToString();

                Hlagnarashi.Value = lagnarashi;
                Hlagnadegree.Value = lagnadegree;
                Hdegree.Value = degree;
                Hhouse.Value = house;
                Hdrop1.Value = drop1;
                Hdegreesecond.Value = degreesecond;
                Hmoonrashi.Value = moonrashi;
                Hsunhouse.Value = sunhouse;
                Hmoonhouse.Value = moonhouse;
                Hretro.Value = retro;
                Hrashie.Value = rashie;

                Page.ClientScript.RegisterStartupScript(this.GetType(), "Test", "yogasgrid();", true);
            }
        }
    }

    public void bindvargaschart()
    {

        vargaschart.Items.Clear();



        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_chart("");

        }


        ListItem li = new ListItem();
        li.Text = "--Select Chart--";
        li.Value = "0";
        li.Selected = true;
        vargaschart.Items.Add(li);



        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["CHART_NO"].ToString();
            vargaschart.Items.Add(li1);



        }
    }

    public void bindhouse()
    {
        hd.Items.Clear();
        naktadrop.Items.Clear();

        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_house("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select House--";
        li.Value = "0";
        li.Selected = true;
        hd.Items.Add(li);
        naktadrop.Items.Add(li);


        // f19house.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            hd.Items.Add(li1);
            naktadrop.Items.Add(li1);

        }
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
    public DataSet maketransitionsp(string dob, string tob, string flag, string sphr)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_maketransitionsp(dob, tob, flag, sphr);
        }
        return ds;
    }



    [Ajax.AjaxMethod]
    public string asccalcul(short da1ob, short mo1ob, short yr1ob, short ihob, short imob, short secondofbirth, double tdiff1, double longitude, double latitude)
    {
        kundli4c.clskundli obj = new clskundli();
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
            ds = country.ast_makebirthchart(dob, tob, tzon, ascca, gulca);
        }
        return ds;


    } 
    [Ajax.AjaxMethod]
    public DataSet showyogas(string lagnarashi, string degree, string house, string degreesecond, string menuitemsvalus, string retro, string rashie)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
            ds = country.showyogas(lagnarashi, degree, house, degreesecond, menuitemsvalus, retro, rashie);
        }
        return ds;

    }

    [Ajax.AjaxMethod]
    public DataSet showyogas_menuitem(string lagnarashi, string degree, string house, string degreesecond, string menuitemsvalus, string retro, string rashie)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
            ds = country.showyogas_menu(lagnarashi, degree, house, degreesecond, menuitemsvalus, retro, rashie);
        }
        return ds;


    }


    [Ajax.AjaxMethod]
    public DataSet showyogas_manau(string lagnarashi, string degree, string house, string degreesecond)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
            ds = country.showyogas_manau_process(lagnarashi, degree, house, degreesecond);
        }
        return ds;

    }




    [Ajax.AjaxMethod]
    public DataSet showyogas1(string lagnarashi, string degree, string house, string menuitemsvalus, string retro)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
            ds = country.showyogas1(lagnarashi, degree, house, menuitemsvalus, retro);
        }
        return ds;

    }

    [Ajax.AjaxMethod]
    public DataSet showyogas_kamboola(string lagnarashi, string degree, string house, string degreesecond, string moonrashi, string moonhouse, string sunhouse)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
            ds = country.kamboola_proce(lagnarashi, degree, house, degreesecond, moonrashi, moonhouse, sunhouse);
        }
        return ds;

    }


    [Ajax.AjaxMethod]
    public DataSet karya_sidhi(string asendrashi, string houselord, string housewithtill, string lagnarashi)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
            ds = country.karya_sidhi_yoga(asendrashi, houselord, housewithtill, lagnarashi);
        }
        return ds;

    }



    [Ajax.AjaxMethod]
    public DataSet datra_nakta(string lagnarashi, string degree, string house, string lordhouse, string newdegree)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
            ds = country.showyogas_nakta_proce(lagnarashi, degree, house, lordhouse, newdegree);
        }
        return ds;

    }

    [Ajax.AjaxMethod]
    public DataSet datra_yamya(string lagnarashi, string degree, string house, string lordhouse, string newdegree)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
            ds = country.showyogas_yamya_proce(lagnarashi, degree, house, lordhouse, newdegree);
        }
        return ds;

    }


    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {

        string menusel = Menu1.SelectedItem.Value;
        menuitsmcvalue.Value = menusel;
        Page.ClientScript.RegisterStartupScript(this.GetType(), "Test", "yogasgrid();", true);


    }

    [Ajax.AjaxMethod]
    public DataSet bindgirdfor(string datafortable)
    {
        DataSet ds = new DataSet();

        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.checkdataforgrid(datafortable);

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
    public string GulikaCalculate(string dob_val, string tob_val, string sunsetpre_val, string sunrise_val, string sunset_val, string sunrisenext_val, string tz_val, string latit_val, string longit_val)
    {
        DataSet dsg = new DataSet();
        string dobval = dob_val, dayofweek = "", GulikaType = "", dinmanval = "", ratrimanval = "", gulikatimeval = "", AscendantVal = "";
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

        double gulikacalculation = obj.asccalcul(gulikaday, gulikamonth, gulikayear, gulikah, gulikam, gulikas, tdiff1, Convert.ToDouble(longit_val), Convert.ToDouble(latit_val));
        //gulikaval.Value = gulikacalculation.ToString();
        AscendantVal = gulikacalculation.ToString();
        dsg.Dispose();

        //Ascendant Calculation End Here


        string finalval = gulikatimeval + "/" + dayofweek + "/" + AscendantVal;

        return finalval;
    }




}

