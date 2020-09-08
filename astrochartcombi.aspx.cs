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

public partial class astrochartcombi : System.Web.UI.Page
{
    string v = "";
    string j = "";
    string k = "";
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(astrochartcombi));
        v = Request.QueryString["v"].ToString();
        j = Request.QueryString["j"].ToString();
        k = Request.QueryString["k"].ToString();
        Hidden4.Value = v;
        Hidden1.Value = j;
        Hidden2.Value = k;


        if (!Page.IsPostBack)
        {
            bindchart();

            search.Attributes.Add("onclick", "javascript:return search123();");
            categery.Attributes.Add("onkeydown", "javascript:return categery123(event);");
            lstcategery.Attributes.Add("onkeydown", "javascript:return closelist(event);");
            
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
            calvergas.Attributes.Add("onclick", "javascript:return vargaschart();");

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
    public DataSet searchdesc(string s, string ss, string kk, string rashi, string key, string planets, string chart)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.searchdesc1(s, ss, kk, rashi, key, planets, chart,"");
        }
        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet fill_categery(string extra1)
    {
        DataSet ds = new DataSet();
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
    public DataSet update_grid(string description, string description1, string descclob, string key, string key1, string explain)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.update_grid(description, description1, descclob, key, key1, explain,"","","");
        }
        return ds;


    }


   




}
