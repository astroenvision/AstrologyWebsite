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

public partial class researchtool_nakshatra : System.Web.UI.Page
{
    string filt = "";
    string usermail = "";
    string usermail1 = "";
    string clmail = "";
    string clname = "";
    string asmail = "";
    string asname = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds1 = new DataSet();
        Ajax.Utility.RegisterTypeForAjax(typeof(researchtool_nakshatra));
        if (Session["usermail"] == null || Session["usermail"] == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(researchtool_nakshatra), "wq", "window.parent.location.href='login.aspx';", true);
            return;
        }
        usermail = Request.QueryString["usermail"];
        filt = Request.QueryString["filt"];
        Hdnna.Value = filt;
        hdnuser.Value = Request.QueryString["usermail"];
        if (filt == "Without Conjunction")
        {
            e2.Attributes.Add("style", "display:none;");

        }
        else
        {
            e1.Attributes.Add("style", "display:none;");

        }
        if (usermail != Session["usermail"].ToString())
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(researchtool_nakshatra), "wq", "window.parent.location.href='login.aspx';", true);
            //Response.Redirect("login.aspx");
            return;

        }
        if (!Page.IsPostBack)
        {
            ds1.ReadXml(Server.MapPath("XML/ResearchTool.xml"));
            sn.InnerHtml = ds1.Tables[0].Rows[0].ItemArray[6].ToString();
            mn.InnerHtml = ds1.Tables[0].Rows[0].ItemArray[7].ToString();
            clgroup.Attributes.Add("onchange", "javascript:return grcli();");
            cal.Attributes.Add("onclick", "javascript:return search1();");
            cross.Attributes.Add("onclick", "javascript:return creossdiv();");
            //usermail1 = Session["usermail"].ToString();
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

            if (Session["usermail"] != "ASTROLOGY" && Session["usermail"] != "astrology")
            {

                // clname = Request.QueryString["clname"].ToString();
                // clmail = Request.QueryString["clmail"].ToString();
                // asname = Request.QueryString["astname"].ToString();
                asmail = Request.QueryString["usermail"];

                // Hclmail.Value = clmail;
                // Hclname.Value = clname;
                Hastmail.Value = asmail;
                //Hastname.Value = asname;


            }

        }
    }


    [Ajax.AjaxMethod]
    public DataSet bindrashi(string vishu)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
            ds = country.ast_rashi(vishu);
        }
        return ds;


    }



    [Ajax.AjaxMethod]
    public DataSet search(string planet, string nakshatra, string astrolrger, string clgroup,string flag,string client,string conj)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.researchtool country = new ASTROLOGY.classesoracle.researchtool();
            if (conj == "Without Conjunction")
            {
                ds = country.ast_rashisearch_withoutconjnakshatra(planet, nakshatra, astrolrger, clgroup, flag, client);
            }
            else
            {
                ds = country.ast_rashisearch_withconjnakshatra(planet, nakshatra, astrolrger, clgroup, flag, client);
            }
        }
        return ds;


    }




    [Ajax.AjaxMethod]
    public DataSet clientinfoall()
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.researchtool country = new ASTROLOGY.classesoracle.researchtool();
            ds = country.clientinfoall();
        }
        return ds;

    }

    [Ajax.AjaxMethod]
    public DataSet clientinfo(string varga,string astrologer)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.researchtool country = new ASTROLOGY.classesoracle.researchtool();
            ds = country.ast_clientinfo(varga,astrologer);
        }
        return ds;

    }
    [Ajax.AjaxMethod]
    public DataSet searchuser(string astrologer, string grp_cat)
    {
        DataSet ds = new DataSet();

        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.bind_user(astrologer, grp_cat);
        }

        return ds;
    }
    [Ajax.AjaxMethod]
    public DataSet searchclient(string astrologer, string clgroup, string clgroupu)
    {
        DataSet ds = new DataSet();

        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.researchtool country = new ASTROLOGY.classesoracle.researchtool();
            ds = country.bind_grclient(astrologer, clgroup, clgroupu);
        }

        return ds;
    }
}
