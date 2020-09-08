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

public partial class searchpage : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    string chart = "";
    string searchpage1 = "";
    string[] detail; 
    string rashi = "";
    string ss = "";
    string kk = "";
    string key = "";
    string planets = "";
    string s = "";
    string global = "";
    string v = "";
    string j = "";
    string k = "";
    string usermail = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(searchpage));
        if (Session["usermail"] == null || Session["usermail"] == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(searchpage), "wq", "window.parent.location.href='login.aspx';", true);
            return;
        }
        usermail = Request.QueryString["usermail"];
        hdnuser.Value = Request.QueryString["usermail"];
        if (usermail != Session["usermail"].ToString())
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(searchpage), "wq", "window.parent.location.href='login.aspx';", true); 
            //Response.Redirect("login.aspx");
            return;

        }
        if (Session["usermail"] == "" || Session["usermail"] == null)
        {
            if (!Page.IsPostBack)
            {
                Response.Redirect("login.aspx");

            }

        }
        else
        {
            var astrologer = Session["usermail"].ToString();
            Hidden9.Value = astrologer;

        }

        searchpage1 = Request.QueryString["searchpage"].ToString();
        v = Request.QueryString["v"].ToString();
        j = Request.QueryString["j"].ToString();
        k = Request.QueryString["k"].ToString();
        astid.Text = Request.QueryString["astmail"].ToString();
        clientid.Text = Request.QueryString["clmail"].ToString();
        clientname.Text = Request.QueryString["client"].ToString();
        astname.Text = Request.QueryString["astname"].ToString();
        detail = searchpage1.ToString().Split('/');
        s = detail[0];
        rashi = detail[1];
        chart = detail[2];
        hiddenchart.Value = chart;
        Hidden6.Value = s;
        Hidden1.Value = rashi;
        hiddens.Value = s;
        hiddenss.Value = ss;
        hiddenkk.Value = kk;
        hiddenrashi.Value = rashi;
        hiddenkey.Value = key;
        hiddenplanets.Value = planets;
        Hiddenv.Value = v;
        Hiddenj.Value = j;
        Hiddenk.Value = k;
        
        if (!Page.IsPostBack)
        {
            bindvargaschart();
            CheckBoxSun.Attributes.Add("onclick", "javascript:return chk();");
            CheckBoxMoon.Attributes.Add("onclick", "javascript:return chk();");
            CheckBoxMars.Attributes.Add("onclick", "javascript:return chk();");
            CheckBoxMercury.Attributes.Add("onclick", "javascript:return chk();");
            CheckBoxVenus.Attributes.Add("onclick", "javascript:return chk();");
            CheckBoxJupitor.Attributes.Add("onclick", "javascript:return chk();");
            CheckBoxSaturn.Attributes.Add("onclick", "javascript:return chk();");
            CheckBoxRahu.Attributes.Add("onclick", "javascript:return chk();");
            CheckBoxKetu.Attributes.Add("onclick", "javascript:return chk();");
            CheckBox1.Attributes.Add("onclick", "javascript:return chk1();");
            CheckBox2.Attributes.Add("onclick", "javascript:return chk2();");
            k1.Attributes.Add("onkeydown", "javascript:return keywordpressed(event);");
            categery.Attributes.Add("onkeydown", "javascript:return fillcategery(event);");
            lstcategery.Attributes.Add("onkeydown", "javascript:return closelist(event);");
            D01.Attributes.Add("onclick", "javascript:return searchresult1();");
            short1.Attributes.Add("onclick", "javascript:return shortres();");
            long1.Attributes.Add("onclick", "javascript:return longres();");
            ImageButton1.Attributes.Add("onclick", "javascript:return vargaschart11();");
            vargaschart.Attributes.Add("onchange", "javascript:return showvargas();");
            cross.Attributes.Add("onclick", "javascript:return creossdiv();");
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
        
        
        //if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        //{
        //               //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
        //    ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
        // ds = country.searchdesc(s, ss, kk, rashi, key, planets, chart);
        //    Hiddends.Value = ds;
           
         
        //    //DataGrid1.DataSource = ds.Tables[0];
        //    //DataGrid1.DataBind();
        //    //div2.Attributes.Add("style", "visibility:hidden;");

        //    return;
        //}

        
    }

    

    [Ajax.AjaxMethod]
    public DataSet fill_categery(string extra1)
    {
        
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.categery country = new ASTROLOGY.classesoracle.categery();
            ds = country.bind_categery(extra1);
        }
        //else if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "sql")
        //{
        //    Circulation.Classes.lebel_gen gen = new Circulation.Classes.lebel_gen();
        //    ds = gen.bindagency_code1(compcode, unit, dateformate, extra1, extra2);
        //}
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
    public DataSet searchdesc(string s, string ss, string kk, string rashi, string key, string planets,string chart,string astrologer1)
   
    {
        
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

           
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.searchdesc(s, ss, kk, rashi, key, planets,chart,astrologer1);
      
        }
        return ds;
}



    [Ajax.AjaxMethod]
    public DataSet searchdescf(string s, string ss, string kk, string rashi, string key, string planets, string chart,string astrologer1)
    {

        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {


            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.searchdescf(s, ss, kk, rashi, key, planets, chart,astrologer1);

        }
        return ds;
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


    //protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    //{
        
    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        var ss = Hidden2.Value;
    //        var kk = Hidden3.Value;
    //        var key=Hidden4.Value;
    //        var planets=Hidden5.Value;
    //        var chart = Hidden7.Value;
    //        //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
    //        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
    //        ds = country.searchdesc(s, ss, kk, rashi, key, planets, chart);
            
    //        //DataGrid1.DataSource = ds.Tables[0];
    //        //DataGrid1.DataBind();
    //        //div2.Attributes.Add("style","visibility:hidden;");
    //        return ;


    [Ajax.AjaxMethod]
    public DataSet searchdesc1(string s, string ss, string kk, string rashi, string key, string planets, string chart,string astrologer1)
    {
      

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.searchdesc1(s, ss, kk, rashi, key, planets, chart, astrologer1);
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
   
}
