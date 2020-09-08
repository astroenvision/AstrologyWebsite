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
using System.Web.Services;

public partial class horarycombination : System.Web.UI.Page
{
    string usermail = "";
    string usermail1 = "";
    string clmail = "";
    string clname = "";
    string asmail = "";
    string asname = "";
    string s = "";
    string lagnarashi = "";
    string lagnadegree = "";
    string degree = "";
    string house = "";
    string drop1 = "";
    string degreesecond = "";
    string moonrashi = "";
    string sunhouse = "";
    string moonhouse = "";
    string v = "";
    string asendrashi = "";
    string suninhouse = "";
    string mooninhouse = "";
    string marsinhouse = "";
    string mrecinhouse = "";
    string jupinhouse = "";
    string venusinhouse = "";
    string saturninhouse = "";
    string rashie ="";
    string retro = "";
    string astrologer = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(horarycombination));
        if (!Page.IsPostBack)
        {
            if (Session["usermail"] == null || Session["usermail"] == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(horarycombination), "wq", "window.parent.location.href='login.aspx';", true);
                return;
            } 
            usermail = Request.QueryString["usermail"];
            hdnuser.Value = Request.QueryString["usermail"];
            if (usermail != Session["usermail"].ToString())
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(horarycombination), "wq", "window.parent.location.href='login.aspx';", true);
                //Response.Redirect("login.aspx");
                return;

            }

            mainfilter.Attributes.Add("OnChange", "javascript:return bindddrop();");
            //subfilter.Attributes.Add("OnClick", "javascript:return clear();");
            som.Attributes.Add("OnClick", "javascript:return yogasgridm();");
            sos.Attributes.Add("OnClick", "javascript:return yogasgrid();");
            vargaschart.Attributes.Add("onchange", "javascript:return showvargas();");
            
           
            bidddropr1();
            bindvargaschart();
            astrologer = Session["usermail"].ToString();
            Hidden9.Value = astrologer;
            s = Request.QueryString["s"].ToString();
            {
                if (Request.QueryString["clname"] == null)
                {
                    clmail = "";
                    clname = "";

                }
                else
                {
                    clname = Request.QueryString["clname"].ToString();
                    clmail = Request.QueryString["clmail"].ToString();
                    asname = Request.QueryString["astname"].ToString();
                    asmail = Request.QueryString["astmail"].ToString();
                    clientid.Text = clmail;
                    clientname.Text = clname;
                    astid.Text = asmail;
                    astname.Text = asname;

                }
               
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
                hdnclmail.Value = clmail;
                rashie = Request.QueryString["rashie"].ToString();
                retro = Request.QueryString["retro"].ToString();
                Hretro.Value=retro;
                Hrashie.Value=rashie;
                Hlagnarashi.Value = lagnarashi;
                Hlagnadegree.Value = lagnadegree;
                Hdegree.Value = degree;
                Hhouse.Value = house;
                Hdrop1.Value = drop1;
                Hdegreesecond.Value = degreesecond;
                Hmoonrashi.Value = moonrashi;
                Hsunhouse.Value = sunhouse;
                Hmoonhouse.Value = moonhouse;
                Hs.Value = s;
            }

            DataSet ds = new DataSet();


            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

                ds = country.ast_rights(Request.QueryString["usermail"].ToString());

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
    public void bidddropr1()
    {
        mainfilter.Items.Clear();
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_main_filter("");
        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select Category--";
        li.Value = "0";
        li.Selected = true;
        mainfilter.Items.Add(li);
       
        // f19house.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            mainfilter.Items.Add(li1);
        }
    }

    [Ajax.AjaxMethod]
    //[WebMethod(EnableSession = true)]
    public DataSet getquestionsdata(string maindrop)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.horarycombination_bind(maindrop);
        }
        return ds;

    }

    [Ajax.AjaxMethod]
    public DataSet showyogas(string lagnarashi, string degree, string house, string degreesecond, string menuitemsvalus, string rashie, string retro)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
            ds = country.showyogas(lagnarashi, degree, house, degreesecond, menuitemsvalus, rashie, retro);
        }
        return ds;

    }

    [Ajax.AjaxMethod]
    public DataSet get_alldata_data(string combination, string lagnarashi, string mainfilerdrop, string subfilterdrop, string astrologer,string clmail)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_horary_comb(combination, lagnarashi, mainfilerdrop, subfilterdrop, astrologer,clmail);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet get_alldata_datam(string combination, string lagnarashi, string mainfilerdrop,  string astrologer,string clmail)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_horary_combm(combination, lagnarashi, mainfilerdrop, astrologer,clmail);
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
}