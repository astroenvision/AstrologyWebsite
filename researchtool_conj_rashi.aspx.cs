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

public partial class researchtool_conj_rashi : System.Web.UI.Page
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
        Ajax.Utility.RegisterTypeForAjax(typeof(researchtool_conj_rashi));
        if (Session["usermail"] == null || Session["usermail"] == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(researchtool_conj_rashi), "wq", "window.parent.location.href='login.aspx';", true);
            return;
        }
        usermail = Request.QueryString["usermail"];
        filt = Request.QueryString["filt"];
       Hdnra.Value=filt;
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
            ScriptManager.RegisterClientScriptBlock(this, typeof(researchtool_conj_rashi), "wq", "window.parent.location.href='login.aspx';", true);
            //Response.Redirect("login.aspx");
            return;

        }
        if (!Page.IsPostBack)
        {
            ds1.ReadXml(Server.MapPath("XML/ResearchTool.xml"));
            rh.InnerHtml = ds1.Tables[0].Rows[0].ItemArray[2].ToString();
            crh.InnerHtml = ds1.Tables[0].Rows[0].ItemArray[3].ToString();
            clgroup.Attributes.Add("onchange", "javascript:return grcli();");
            Radio1.Attributes.Add("onclick", "javascript:return gridcall();");
            RadioButton1.Attributes.Add("onclick", "javascript:return data1();");
            RadioButton2.Attributes.Add("onclick", "javascript:return gata2();");
            RadioButton3.Attributes.Add("onclick", "javascript:return data3();");
            RadioButton4.Attributes.Add("onclick", "javascript:return data4();");
            cross.Attributes.Add("onclick", "javascript:return creossdiv();");
            cal.Attributes.Add("onclick", "javascript:return search1();");
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
    public DataSet search(string planet1, string rashi1, string house1, string astrolrger, string clgroup,string flag,string client,string sv,string svn,string conj)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.researchtool country = new ASTROLOGY.classesoracle.researchtool();
            if (conj == "Without Conjunction")
            {
                ds = country.ast_rashisearch_withoutconj_rashi(planet1, rashi1, house1, astrolrger, clgroup, flag, client, sv, svn);
            }
            else
            {
                ds = country.ast_rashisearch_conj_rashi(planet1, rashi1, house1, astrolrger, clgroup, flag, client, sv, svn); 
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
