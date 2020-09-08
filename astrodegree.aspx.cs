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

public partial class astrodegree : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(astrodegree));
        DataSet ds1 = new DataSet();
        ds1.ReadXml(Server.MapPath("ast.xml/astrodegree.xml"));
        tblfields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        fields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        hiddendateformat.Value = "dd/mm/yyyy";
      
        //Hidden5.Value = Request.QueryString["ss"].ToString();
        //Hidden4.Value = Request.QueryString["kk"].ToString();        
        if (!Page.IsPostBack)
        {
            bindchart();
            bindbirth();
            bindplanet();
            //bindhouse();
            //bindplanet();
            //bindrashi();
            //bindconstellation();
            //bindretrograde();
            //binddegree();
            //bindminutes();
            //bindseconds();
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
            sreach1.Attributes.Add("onclick", "javascript:return search123();");
            button2.Attributes.Add("onclick", "javascript:return vargas();");
           
            
        }
    }
    public void bindchart()
    {
       

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

      


        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["CHART_NO"].ToString();
           

        }




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

    //public void bindconstellation()
    //{
    //    constelation1.Items.Clear();
    //    DataSet ds = new DataSet();


    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

    //        ds = country.ast_constellation("");

    //    }

    //    //hdncompcode.Value
    //    ListItem li = new ListItem();
    //    li.Text = "--Select Constellation--";
    //    li.Value = "0";
    //    li.Selected = true;
    //    constelation1.Items.Add(li);
    //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
    //    {
    //        ListItem li1 = new ListItem();
    //        li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
    //        li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
    //        constelation1.Items.Add(li1);

    //    }
    //}


    //public void bindplanet()
    //{
    //    planet1.Items.Clear();
    //    DataSet ds = new DataSet();


    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

    //        ds = country.ast_planet("");

    //    }

    //    //hdncompcode.Value
    //    ListItem li = new ListItem();
    //    li.Text = "--Select Planet--";
    //    li.Value = "0";
    //    li.Selected = true;
    //    planet1.Items.Add(li);
    //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
    //    {
    //        ListItem li1 = new ListItem();
    //        li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
    //        li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
    //        planet1.Items.Add(li1);

    //    }



    //}
    [Ajax.AjaxMethod]
    public DataSet bindplanet( string vishu)
    {
        
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_planet_ascendent(vishu);
        }
        return ds;
  
    }

    [Ajax.AjaxMethod]
    public DataSet bindrashi(string vishu)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_rashi(vishu);
        }
        return ds;


    }


    [Ajax.AjaxMethod]
    public DataSet searchdesc(string s, string ss, string kk, string rashi,string key,string planets,string chart)
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
    public DataSet bindhouse(string vishu)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_house(vishu);
        }
        return ds;


    }

    //[Ajax.AjaxMethod]
    //public DataSet bindbirth(string vishu)
    //{

    //    DataSet ds = new DataSet();
    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {

    //        //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
    //        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
    //        ds = country.ast_birth(vishu);
    //    }
    //    return ds;


    //}


    //public void bindchart()
    //{


    //    DataSet ds = new DataSet();


    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

    //        ds = country.ast_chart("");

    //    }


    //    ListItem li = new ListItem();
    //    li.Text = "--Select Chart--";
    //    li.Value = "0";
    //    li.Selected = true;




    //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
    //    {
    //        ListItem li1 = new ListItem();
    //        li1.Text = ds.Tables[0].Rows[i]["CHART_NO"].ToString();


    //    }




    //}


    [Ajax.AjaxMethod]
    public DataSet binddegree(string vishu)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_degree(vishu);
        }
        return ds;


    }

    [Ajax.AjaxMethod]
    public DataSet bindminutes(string vishu)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_degree(vishu);
        }
        return ds;


    }
    [Ajax.AjaxMethod]
    public DataSet bindseconds(string vishu)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_degree(vishu);
        }
        return ds;


    }
    [Ajax.AjaxMethod]
    public DataSet bindretrograde(string vishu)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_retrograde(vishu);
        }
        return ds;


    }
    [Ajax.AjaxMethod]
    public DataSet bindconstelation(string vishu)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_constellation(vishu);
        }
        return ds;


    }

    [Ajax.AjaxMethod]
    public DataSet housevalue(string house, string rashi, string selectedrashi)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.housevalue(house, rashi, selectedrashi);
        }
        return ds;


    }

     [Ajax.AjaxMethod]
    public DataSet getconstellation(string rashi, string degreevalue)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.getconstellation(rashi, degreevalue);
        }
        return ds;


    }
    
    [Ajax.AjaxMethod]
    public DataSet rashivalue(string house, string rashi, string selectedhouse)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.rashivalue(house, rashi, selectedhouse);
        }
        return ds;


    }

    //public void bindrashi()
    //{
    //    rashi1.Items.Clear();

    //    DataSet ds = new DataSet();


    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

    //        ds = country.ast_rashi("");

    //    }

    //    //hdncompcode.Value
    //    ListItem li = new ListItem();
    //    li.Text = "--Select Rashi--";
    //    li.Value = "0";
    //    li.Selected = true;
    //    rashi1.Items.Add(li);

    //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
    //    {
    //        ListItem li1 = new ListItem();
    //        li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
    //        li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
    //        rashi1.Items.Add(li1);


    //    }




    //}
    //public void bindhouse()
    //{
    //   house1.Items.Clear();
    //    DataSet ds = new DataSet();


    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
    //        ds = country.ast_house("");
    //    }

    //    ListItem li = new ListItem();
    //    li.Text = "--Select House--";
    //    li.Value = "0";
    //    li.Selected = true;
    //    house1.Items.Add(li);
    //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
    //    {
    //        ListItem li1 = new ListItem();
    //        li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
    //        li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
    //        house1.Items.Add(li1);
    //    }
    //}

    //public void bindretrograde()
    //{
    //    retrograde1.Items.Clear();
    //    DataSet ds = new DataSet();


    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
    //        ds = country.ast_retrograde("");
    //    }

    //    ListItem li = new ListItem();
    //    li.Text = "--Select Retrograde--";
    //    li.Value = "0";
    //    li.Selected = true;
    //    retrograde1.Items.Add(li);
    //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
    //    {
    //        ListItem li1 = new ListItem();
    //        li1.Text = ds.Tables[0].Rows[i]["CATE"].ToString();
    //      //  li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
    //        retrograde1.Items.Add(li1);
    //    }
    //}

    //public void binddegree()
    //{
    //    degree1.Items.Clear();
    //    DataSet ds = new DataSet();


    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
    //        ds = country.ast_degree("");
    //    }

    //    ListItem li = new ListItem();
    //    li.Text = "--Select Degree--";
    //    li.Value = "0";
    //    li.Selected = true;
    //    degree1.Items.Add(li);

        
    //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
    //    {
    //        ListItem li3 = new ListItem();
    //        li3.Text = ds.Tables[0].Rows[i]["DEGREE"].ToString();
    //        //  li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
    //        degree1.Items.Add(li3);

          
    //    }
    //}


    //public void bindminutes()
    //{
    //    minutes1.Items.Clear();
    //    DataSet ds = new DataSet();


    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
    //        ds = country.ast_degree("");
    //    }

    //    ListItem li = new ListItem();
    //    li.Text = "--Select Minutes--";
    //    li.Value = "0";
    //    li.Selected = true;
    //    minutes1.Items.Add(li);


    //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
    //    {
    //        ListItem li3 = new ListItem();
    //        li3.Text = ds.Tables[0].Rows[i]["MINUTES"].ToString();
    //        //  li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
    //        minutes1.Items.Add(li3);


    //    }
    //}

    //public void bindseconds()
    //{
    //    seconds1.Items.Clear();
    //    DataSet ds = new DataSet();


    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
    //        ds = country.ast_degree("");
    //    }

    //    ListItem li = new ListItem();
    //    li.Text = "--Select Seconds--";
    //    li.Value = "0";
    //    li.Selected = true;
    //    seconds1.Items.Add(li);


    //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
    //    {
    //        ListItem li3 = new ListItem();
    //        li3.Text = ds.Tables[0].Rows[i]["SECONDS"].ToString();
    //       // li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
    //        seconds1.Items.Add(li3);


    //    }
    //}



    [Ajax.AjaxMethod]
    public DataSet update_grid(string description,string description1, string descclob,string key,string key1,string explain)
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

    public void bindbirth()
    {
        bitrh.Items.Clear();

        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_birth("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select Birth--";
        li.Value = "0";
        li.Selected = true;
        bitrh.Items.Add(li);

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            bitrh.Items.Add(li1);


        }
    }



    public void bindplanet()
    {
        planet1.Items.Clear();

        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_planet("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select Planet--";
        li.Value = "0";
        li.Selected = true;
        planet1.Items.Add(li);

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            planet1.Items.Add(li1);


        }
    }

   


}
