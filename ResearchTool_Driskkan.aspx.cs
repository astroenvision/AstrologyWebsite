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

public partial class ResearchTool_Driskkan : System.Web.UI.Page
{
    string usermail = "";
    string usermail1 = "";
    string clmail = "";
    string clname = "";
    string asmail = "";
    string asname = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds1 = new DataSet();
        Ajax.Utility.RegisterTypeForAjax(typeof(ResearchTool_Driskkan));
        if (Session["usermail"] == null || Session["usermail"] == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(ResearchTool_Driskkan), "wq", "window.parent.location.href='login.aspx';", true);
            return;
        }
        usermail = Request.QueryString["usermail"];
        hdnuser.Value = Request.QueryString["usermail"];

        if (usermail != Session["usermail"].ToString())
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(ResearchTool_Driskkan), "wq", "window.parent.location.href='login.aspx';", true);
            //Response.Redirect("login.aspx");
            return;

        }
        if (!Page.IsPostBack)
        {
            clgroup.Attributes.Add("onchange", "javascript:return grcli();");
           
            cross.Attributes.Add("onclick", "javascript:return creossdiv();");
            cal.Attributes.Add("onclick", "javascript:return search1();");
            chad.Attributes.Add("onclick", "javascript:return chadr();");
            chah.Attributes.Add("onclick", "javascript:return chahr();");
            chap.Attributes.Add("onclick", "javascript:return chapl();");
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
    public DataSet search(string planet1, string astrolrger, string clgroup, string client, string sv, string svn,string house)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.researchtool country = new ASTROLOGY.classesoracle.researchtool();
            ds = country.ast_research_driskkan(planet1, astrolrger, clgroup, client, sv, svn,house);
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
    public DataSet clientinfo(string varga, string astrologer)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.researchtool country = new ASTROLOGY.classesoracle.researchtool();
            ds = country.ast_clientinfo(varga, astrologer);
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
