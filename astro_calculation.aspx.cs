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

public partial class astro_calculation : System.Web.UI.Page
{
    string usermail = "";
    string v = "";
    string s = "";
    string moon = "";
    string venus = "";
    string j = "";
    string k = "";
    string c = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds1 = new DataSet();
        Ajax.Utility.RegisterTypeForAjax(typeof(astro_calculation));
        if (Session["usermail"] == null || Session["usermail"] == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(astro_calculation), "wq", "window.parent.location.href='login.aspx';", true);
            return;
        }
        usermail = Request.QueryString["usermail"];
        hdnuser.Value = Request.QueryString["usermail"];
        if (usermail != Session["usermail"].ToString())
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(astro_calculation), "wq", "window.parent.location.href='login.aspx';", true);
            //Response.Redirect("login.aspx");
            return;

        }
       // v = Request.QueryString["v"].ToString();
        c = Request.QueryString["c"].ToString();
        s = Request.QueryString["s"].ToString();
        moon = Request.QueryString["moon"].ToString();
        venus = Request.QueryString["venus"].ToString();
        astname.Text = Request.QueryString["astname"].ToString();
        astid.Text = Request.QueryString["astmail"].ToString();
        clientname.Text = Request.QueryString["clname"].ToString();
        clientid.Text = Request.QueryString["clmail"].ToString();

       // Hidden4.Value = v;
        Hiddencons.Value = c;
        Hs.Value = s;
        Hm.Value = moon;
        Hv.Value = venus;
        if (!Page.IsPostBack)
        {
            ds1.ReadXml(Server.MapPath("XML/AstroCalculation.xml"));
            hdn22nd.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
            hdn64th.Value= ds1.Tables[0].Rows[0].ItemArray[1].ToString();

            bindchart();
            som.Attributes.Add("OnClick", "javascript:return yogasgridm();");
            chart.Attributes.Add("Onchange", "javascript:return showvargas();");
            DataSet ds = new DataSet();


            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

                ds = country.ast_rights(Request.QueryString["astmail"].ToString());

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
    public void bindchart()
    {
        chart.Items.Clear();

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

        chart.Items.Add(li);


        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["CHART_NO"].ToString();
            chart.Items.Add(li1);

        }




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
    public DataSet pn(string main, string s, string m, string v, string astro)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {


            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.pun(main,s,m,v,astro);
        }
        return ds;

    }

}
