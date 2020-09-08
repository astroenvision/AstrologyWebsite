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

public partial class chartindex : System.Web.UI.Page
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
        Ajax.Utility.RegisterTypeForAjax(typeof(chartindex));
        if (Session["usermail"] == null || Session["usermail"] == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(chartindex), "wq", "window.parent.location.href='login.aspx';", true);
            return;
        }
        usermail = Request.QueryString["usermail"];
        hdnuser.Value = Request.QueryString["usermail"];

        if (usermail != Session["usermail"].ToString())
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(chartindex), "wq", "window.parent.location.href='login.aspx';", true);
            //Response.Redirect("login.aspx");
            return;

        }
        if (!Page.IsPostBack)
        {
            Radio1.Attributes.Add("onclick", "javascript:return gridcall();");
            RadioButton1.Attributes.Add("onclick", "javascript:return data1();");
            RadioButton2.Attributes.Add("onclick", "javascript:return gata2();");
            RadioButton3.Attributes.Add("onclick", "javascript:return data3();");
            RadioButton4.Attributes.Add("onclick", "javascript:return data4();");
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

                a7.Attributes.Add("style", "display:none;");
                a8.Attributes.Add("style", "display:none;");
                a7l.Attributes.Add("style", "display:none;");
                a8l.Attributes.Add("style", "display:none;");

                
            }
            if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Horary")
            {
                a2.Attributes.Add("style", "display:none;");
                a3.Attributes.Add("style", "display:none;");
                a4.Attributes.Add("style", "display:none;");
                a5.Attributes.Add("style", "display:none;");
                a6.Attributes.Add("style", "display:none;");
                a2l.Attributes.Add("style", "display:none;");
                a3l.Attributes.Add("style", "display:none;");
                a4l.Attributes.Add("style", "display:none;");
                a5l.Attributes.Add("style", "display:none;");
                a6l.Attributes.Add("style", "display:none;");



                
            }
            
            if (Session["usermail"] != "ASTROLOGY" && Session["usermail"] != "astrology")
            {
                if (Request.QueryString["clname"] == null)
                {                   
                        clmail ="";                                      
                        clname ="";
                    
                }
                else
                {
                    clname = Request.QueryString["clname"].ToString();
                    clmail = Request.QueryString["clmail"].ToString();
                    asname = Request.QueryString["astname"].ToString();
                    asmail = Request.QueryString["astmail"].ToString();

                    Hclmail.Value = clmail;
                    Hclname.Value = clname;
                    Hastmail.Value = asmail;
                    Hastname.Value = asname;
                }

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
    public DataSet search(string planet, string rashi,string astrolrger,string client)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
            ds = country.ast_rashisearch(planet, rashi, astrolrger, client);
        }
        return ds;


    }



    [Ajax.AjaxMethod]
    public DataSet clientinfo(string varga)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
            ds = country.ast_clientinfo(varga);
        }
        return ds;

    }

   

   


}
