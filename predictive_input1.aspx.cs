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

public partial class predictive_input1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(predictive_input1));

        DataSet ds1 = new DataSet();
        ds1.ReadXml(Server.MapPath("ast.xml/extentions.xml"));
        tblfields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        fields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        hiddendateformat.Value = "dd/mm/yyyy";

        if (!Page.IsPostBack)
        {
            bindplanet();
            debrashibind();
            bindhouse();
            bindchart();
            fixedrashi();
            binddebexl();
            ownrashi();
            bindbenmal();
            f1ahouse.Attributes.Add("onchange", "javascript:return f1bindplanetaspplanet();");
            f2house.Attributes.Add("onchange", "javascript:return f2binddispositor();");
            f3lohhouse.Attributes.Add("onchange", "javascript:return f3planetasploh();");
            f4rashi.Attributes.Add("onchange", "javascript:return f4lohinfixed();");
            f5rashi.Attributes.Add("onchange", "javascript:return f5dopinrashi();");
            f6rashi.Attributes.Add("onchange", "javascript:return f6planetinownrashi();");
            f7benmal.Attributes.Add("onchange", "javascript:return f7planetinbenmal();");
            f8ahouse.Attributes.Add("onchange", "javascript:return lordhouseasphouse();");
            f9house.Attributes.Add("onchange", "javascript:return inhouse123();");
            f10benmal.Attributes.Add("onchange", "javascript:return benmalinhouse();");
            f11benmal.Attributes.Add("onchange", "javascript:return planetbenmalbet();");
            f12deb.Attributes.Add("onchange", "javascript:return planetindeb();");
            f13deb.Attributes.Add("onchange", "javascript:return houseindeb();");
            






            f6house.Attributes.Add("onkeydown", "javascript:return fillf6house(event);");
            f7house.Attributes.Add("onkeydown", "javascript:return fillf7house(event);");

            f1lstmultiplehouse.Attributes.Add("onkeydown", "javascript:return closehouse(event);");



            f1_save.Attributes.Add("onclick", "javascript:return f1_save123();");
            f2save.Attributes.Add("onclick", "javascript:return f2_save();");
            f3save.Attributes.Add("onclick", "javascript:return f3_save();");
            f4save.Attributes.Add("onclick", "javascript:return f4_save();");
            f5save.Attributes.Add("onclick", "javascript:return f5_save();");
            f6save.Attributes.Add("onclick", "javascript:return planetinhouse();");
            f7save.Attributes.Add("onclick", "javascript:return planetinbenmal();");
            f8save.Attributes.Add("onclick", "javascript:return f8_save();");
            f9save.Attributes.Add("onclick", "javascript:return f9_save();");
            f10save.Attributes.Add("onclick", "javascript:return f10_save();");
            f11save.Attributes.Add("onclick", "javascript:return f11_save();");
            f12save.Attributes.Add("onclick", "javascript:return f12_save();");
            f13save.Attributes.Add("onclick", "javascript:return f13_save();");
           


        }

    }



    public void binddebexl()
    {
        f5rashi.Items.Clear();
        
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_debexal("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select Rashi--";
        li.Value = "0";
        li.Selected = true;
        f5rashi.Items.Add(li);
        
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            f5rashi.Items.Add(li1);
          
        }
    }


    public void bindbenmal()
    {
        f7benmal.Items.Clear();
        f9benmal.Items.Clear();
        f10benmal.Items.Clear();
        f11benmal.Items.Clear();
        
        
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Benific_malific bmcountry = new ASTROLOGY.classesoracle.Benific_malific();

            ds = bmcountry.ast_benificmalific("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select Aspect--";
        li.Value = "0";
        li.Selected = true;
        f7benmal.Items.Add(li);
        f9benmal.Items.Add(li);
        f10benmal.Items.Add(li);
        f11benmal.Items.Add(li);
       
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            f7benmal.Items.Add(li1);
            f9benmal.Items.Add(li1);
            f10benmal.Items.Add(li1);
            f11benmal.Items.Add(li1);

           
        }




    }



    public void bindplanet()
    {
        f1planet.Items.Clear();
        f1aplanet.Items.Clear();
        f1aceptplanet.Items.Clear();
        f3planet.Items.Clear();
        f5dop.Items.Clear();
        f6planet.Items.Clear();
        f7planet.Items.Clear();
        f11planet.Items.Clear();
        f12planet.Items.Clear();
       
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
        f1planet.Items.Add(li);
        f1aplanet.Items.Add(li);
        f1aceptplanet.Items.Add(li);
        f3planet.Items.Add(li);
        f5dop.Items.Add(li);
        f6planet.Items.Add(li);
        f7planet.Items.Add(li);
        f11planet.Items.Add(li);
        f12planet.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            f1planet.Items.Add(li1);
            f1aplanet.Items.Add(li1);
            f1aceptplanet.Items.Add(li1);
            f3planet.Items.Add(li1);
            f5dop.Items.Add(li1);
            f6planet.Items.Add(li1);
            f7planet.Items.Add(li1);
            f11planet.Items.Add(li1);
            f12planet.Items.Add(li1);
        }
    }


    public void fixedrashi()
    {

        f4rashi.Items.Clear();
       
        
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input1 country = new ASTROLOGY.classesoracle.predictive_input1();

            ds = country.ast_fixed("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select Rashi--";
        li.Value = "0";
        li.Selected = true;

        f4rashi.Items.Add(li);
        
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();

            f4rashi.Items.Add(li1);
           
        }
    }

    public void bindhouse()
    {
        f1house.Items.Clear();
        f1ahouse.Items.Clear();
        f2dhouse.Items.Clear();
        f2house.Items.Clear();
        f3house.Items.Clear();
        f3lohhouse.Items.Clear();
        f4loh.Items.Clear();
        f8loh.Items.Clear();
        f8house.Items.Clear();
        f8ahouse.Items.Clear();
        f9house.Items.Clear();
        f9loh.Items.Clear();
        f10loh.Items.Clear();
        f13loh.Items.Clear();
      

        //f19house.Items.Clear();

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
        f1house.Items.Add(li);
        f1ahouse.Items.Add(li);
        f2dhouse.Items.Add(li);
        f2house.Items.Add(li);
        f3house.Items.Add(li);
        f3lohhouse.Items.Add(li);
        f4loh.Items.Add(li);
        f8loh.Items.Add(li);
        f8house.Items.Add(li);
        f8ahouse.Items.Add(li);
        f9house.Items.Add(li);
        f9loh.Items.Add(li);
        f10loh.Items.Add(li);
        f13loh.Items.Add(li);
    

    

    

    



        // f19house.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            f1house.Items.Add(li1);
            f1ahouse.Items.Add(li1);
            f2house.Items.Add(li1);
            f2dhouse.Items.Add(li1);
            f3house.Items.Add(li1);
            f3lohhouse.Items.Add(li1);
            f4loh.Items.Add(li1);
            f8loh.Items.Add(li1);
            f8house.Items.Add(li1);
            f8ahouse.Items.Add(li1);
            f9house.Items.Add(li1);
            f9loh.Items.Add(li1);
            f10loh.Items.Add(li1);
            f13loh.Items.Add(li1);
         


            //  f19house.Items.Add(li1);
        }
    }


    public void bindchart()
    {

        f1chart.Items.Clear();
        f2chart.Items.Clear();
        f3chart.Items.Clear();
        f4chart.Items.Clear();
        f4chart.Items.Clear();
        f5chart.Items.Clear();
        f6chart.Items.Clear();
        f7chart.Items.Clear();
        f8chart.Items.Clear();
        f9chart.Items.Clear();
        f10chart.Items.Clear();
        f11chart.Items.Clear();
        f12chart.Items.Clear();
        f13chart.Items.Clear();
       


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
        f1chart.Items.Add(li);
        f2chart.Items.Add(li);
        f3chart.Items.Add(li);
        f4chart.Items.Add(li);
        f5chart.Items.Add(li);
        f6chart.Items.Add(li);
        f7chart.Items.Add(li);
        f8chart.Items.Add(li);
        f9chart.Items.Add(li);
        f10chart.Items.Add(li);
        f11chart.Items.Add(li);
        f12chart.Items.Add(li);
        f13chart.Items.Add(li);
       



        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["CHART_NO"].ToString();
            f1chart.Items.Add(li1);
            f2chart.Items.Add(li1);
            f3chart.Items.Add(li1);
            f4chart.Items.Add(li1);
            f5chart.Items.Add(li1);
            f6chart.Items.Add(li1);
            f7chart.Items.Add(li1);
            f8chart.Items.Add(li1);
            f9chart.Items.Add(li1);
            f10chart.Items.Add(li1);
            f11chart.Items.Add(li1);
            f12chart.Items.Add(li1);
            f13chart.Items.Add(li1);
         





        }
    }


    public void ownrashi()
    {
        f6rashi.Items.Clear();

        DataSet ds = new DataSet();

        
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input1 country = new ASTROLOGY.classesoracle.predictive_input1();

            ds = country.ast_own("");
        }


        ListItem li = new ListItem();
        li.Text = "--Select Rashi--";
        li.Value = "0";
        li.Selected = true;

        f6rashi.Items.Add(li);

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();

            f6rashi.Items.Add(li1);

        }

    }



    public void debrashibind()
    {
        f12deb.Items.Clear();
        f13deb.Items.Clear();

        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input1 country = new ASTROLOGY.classesoracle.predictive_input1();

            ds = country.ast_deb("");
        }


        ListItem li = new ListItem();
        li.Text = "--Select Rashi--";
        li.Value = "0";
        li.Selected = true;

        f12deb.Items.Add(li);
        f13deb.Items.Add(li);

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["CODE"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();

            f12deb.Items.Add(li1);
            f13deb.Items.Add(li1);

        }

    }






    [Ajax.AjaxMethod]
    public DataSet multipleplanetinanyhouse(string name, string book, string page, string filter, string detail, string description, string nop, string chart, string unique, string fid,string today)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.save_multipleplanetinanyhouse(name, book, page, filter, detail, description, nop, chart, unique, fid,today);
        }

        return ds;
    }




    [Ajax.AjaxMethod]
    public DataSet planetaspectplanet(string planet, string house, string aspplanet, string ahouse)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.predictive_input1 ashouse = new ASTROLOGY.classesoracle.predictive_input1();
            ds = ashouse.planetaspectplanet(planet, house, aspplanet, ahouse);
        }
        return ds;


    }







    



[Ajax.AjaxMethod]
    public DataSet f2binddispositor(string dhouse, string house)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
    
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.predictive_input1 ashouse = new ASTROLOGY.classesoracle.predictive_input1();
            ds = ashouse.f2binddispositor(dhouse, house);
        }
        return ds;


    }


    [Ajax.AjaxMethod]
    public DataSet save_lordwithplanetwithmalifics(string lagnarashi, string lordofhouse, string lord, string house, string rashi, string combination, string book, string page, string filter, string detail, string description, string nop, string chart,string unique,string fid,string today)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.lordwithplanetwithmalifics(lagnarashi, lordofhouse, lord, house, rashi, combination, book, page, filter, detail, description, nop, chart,unique,fid,today);
        }

        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet f3planetasploh(string planet, string house, string lohouse)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.predictive_input1 ashouse = new ASTROLOGY.classesoracle.predictive_input1();
            ds = ashouse.f3planetasploh(planet, house, lohouse);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet save_f13(string f13planet, string f13house, string f13aplanet, string f13book, string f13page, string keystring, string detail, string desc, string combination, string lagna,string chart,string unique,string fid,string today)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.planet_aspect_planet country = new ASTROLOGY.classesoracle.planet_aspect_planet();
            ds = country.save_planet_aspect_planet(f13planet, f13house, f13aplanet, f13book, f13page, keystring, detail, desc, combination, lagna,chart,unique,fid,today);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet f4lohinfixed(string loh, string rashi)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.predictive_input1 ashouse = new ASTROLOGY.classesoracle.predictive_input1();
            ds = ashouse.f4lohinfixed(loh, rashi);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet save_f4predictiveinput(string f4planet, string f4house, string f4rashi, string f4book, string f4page, string f4filter, string f4detail, string f4description, string f4name,string chart,string unique,string fid,string today)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.save_f4predictiveinput(f4planet, f4house, f4rashi, f4book, f4page, f4filter, f4detail, f4description, f4name,chart,unique,fid,today);
        }
        return ds;
    }



    [Ajax.AjaxMethod]
    public DataSet f5dopinrashi(string dop, string rashi)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.predictive_input1 ashouse = new ASTROLOGY.classesoracle.predictive_input1();
            ds = ashouse.f5dopinrashi(dop, rashi);
        }
       return ds;

    }



    [Ajax.AjaxMethod]
    public DataSet fill_house(string extra1)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.multiplesigni country = new ASTROLOGY.classesoracle.multiplesigni();
            ds = country.bind_house(extra1);
        }

        return ds;
    }





    [Ajax.AjaxMethod]
    public DataSet f6planetinownrashi(string planet, string rashi)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.predictive_input1 ashouse = new ASTROLOGY.classesoracle.predictive_input1();
            ds = ashouse.f6planetinownrashi(planet, rashi);
        }
        return ds;

    }




    [Ajax.AjaxMethod]
    public DataSet f7planetinbenmal(string benmal)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.predictive_input1 ashouse = new ASTROLOGY.classesoracle.predictive_input1();
            ds = ashouse.f7planetinbenmal(benmal);
        }
        return ds;


    }



    [Ajax.AjaxMethod]
    public DataSet lordhouseasphouse(string loh, string house,string ahouse)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.predictive_input1 ashouse = new ASTROLOGY.classesoracle.predictive_input1();
            ds = ashouse.lordhouseasphouse(loh, house, ahouse);
        }
        return ds;

    }




    [Ajax.AjaxMethod]
    public DataSet inhouse123(string loh, string benmal, string house)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.predictive_input1 ashouse = new ASTROLOGY.classesoracle.predictive_input1();
            ds = ashouse.inhouse123(loh, benmal, house);
        }
        return ds;

    }


    [Ajax.AjaxMethod]
    public DataSet benmalinhousebet(string loh, string benmal)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.predictive_input1 ashouse = new ASTROLOGY.classesoracle.predictive_input1();
            ds = ashouse.benmalinhousebet(loh, benmal);
        }
        return ds;

    }


    [Ajax.AjaxMethod]
    public DataSet planetbenmalbet(string planet, string benmal)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.predictive_input1 ashouse = new ASTROLOGY.classesoracle.predictive_input1();
            ds = ashouse.planetbenmalbet(planet, benmal);
        }
        return ds;

    }



    [Ajax.AjaxMethod]
    public DataSet planetindebrash(string planet)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.predictive_input1 ashouse = new ASTROLOGY.classesoracle.predictive_input1();
            ds = ashouse.planetdeb(planet);
        }
        return ds;

    }

    [Ajax.AjaxMethod]
    public DataSet houseindebo(string house)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.predictive_input1 ashouse = new ASTROLOGY.classesoracle.predictive_input1();
            ds = ashouse.lordindeb(house);
        }
        return ds;

    }   

   


   



}