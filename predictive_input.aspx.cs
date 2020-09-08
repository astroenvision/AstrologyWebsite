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

public partial class predictive_input : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(predictive_input));
        DataSet ds1 = new DataSet();
        ds1.ReadXml(Server.MapPath("ast.xml/extentions.xml"));
        tblfields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        fields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        hiddendateformat.Value = "dd/mm/yyyy";

        if (!Page.IsPostBack)
        {
            bindchart();
            bindcharan();
            binddebexl();
            bindbenmal();
            bindrashinew();
            bindconstellation();
            bindrashi();
            bindplanet();
            bindhouse();
            bindquadrapedrashi();
            bindwateryrashi();

            btnexecute.Attributes.Add("onclick", "javascript:return findentry();");
            btnupdate.Attributes.Add("onclick", "javascript:return updatefindentry();");
            btnsave.Attributes.Add("onclick", "javascript:return planetinhouse();");
            txtmultipleplanet.Attributes.Add("onkeydown", "javascript:return fillplanet(event);");
            f7planet.Attributes.Add("onkeydown", "javascript:return fillf7planet(event);");
            f8planet.Attributes.Add("onkeydown", "javascript:return fillf8planet(event);");
            f7rashi.Attributes.Add("onkeydown", "javascript:return fillf7rashi(event);");
            f8rashi.Attributes.Add("onkeydown", "javascript:return fillf8rashi(event);");
           
            lstmultiplerashi.Attributes.Add("onkeydown", "javascript:return closerashi(event);");
            lstmultipleplanet.Attributes.Add("onkeydown", "javascript:return closeplanet(event);");
            mdrphouse.Attributes.Add("onkeydown", "javascript:return fillmhouse(event);");
            
            f8house.Attributes.Add("onkeydown", "javascript:return fillf8house(event);");
            drphouse.Attributes.Add("onkeydown", "javascript:return fillhouse(event);");
            lstmultiplehouse.Attributes.Add("onkeydown", "javascript:return closehouse(event);");
            mbtnsave.Attributes.Add("onclick", "javascript:return multipleplanetinhouse();");
            mbtnexecute.Attributes.Add("onclick", "javascript:return findmultipleentry();");
            mbtnupdate.Attributes.Add("onclick", "javascript:return updatemultiplefindentry();");
           
            f2save.Attributes.Add("onclick", "javascript:return planetinrashi();");
            f3save.Attributes.Add("onclick", "javascript:return houseinrashi();");
            f4save.Attributes.Add("onclick", "javascript:return planetinrashiinhouse();");
            f5save.Attributes.Add("onclick", "javascript:return planetinconstelation();");
            f7save.Attributes.Add("onclick", "javascript:return f7planetinrashi();");
            f8save.Attributes.Add("onclick", "javascript:return f8planetinhouseinrashi();");
            f9save.Attributes.Add("onclick", "javascript:return f9savelhinh();");
            f10save.Attributes.Add("onclick", "javascript:return f10_save();");
            f11save.Attributes.Add("onclick", "javascript:return f11_save();");
            f12save.Attributes.Add("onclick", "javascript:return f12_save();");
            f13save.Attributes.Add("onclick", "javascript:return f13_save();");
            f16save.Attributes.Add("onclick", "javascript:return f16_save();");
            f14save.Attributes.Add("onclick", "javascript:return f14_save();");
            f15save.Attributes.Add("onclick", "javascript:return f15_save();");
            f17save.Attributes.Add("onclick", "javascript:return f17_save();");
            f18save.Attributes.Add("onclick", "javascript:return f18_save();");
            f19save.Attributes.Add("onclick", "javascript:return f19_save();");
            f20save.Attributes.Add("onclick", "javascript:return f20_save();");
            f21save.Attributes.Add("onclick", "javascript:return f21_save();");
            f22save.Attributes.Add("onclick", "javascript:return f22_save();");
            f23save.Attributes.Add("onclick", "javascript:return f23_save();");
            f24save.Attributes.Add("onclick", "javascript:return f24_save();");
            f25save.Attributes.Add("onclick", "javascript:return f25_save();");
            f26save.Attributes.Add("onclick", "javascript:return f26_save();");
            f27save.Attributes.Add("onclick", "javascript:return f27_save();");
            f28save.Attributes.Add("onclick", "javascript:return f28_save();");
            f29save.Attributes.Add("onclick", "javascript:return f29_save();");
            f30save.Attributes.Add("onclick", "javascript:return f30_save();");
            f31save.Attributes.Add("onclick", "javascript:return f31_save();");
            f32save.Attributes.Add("onclick", "javascript:return f32_save();");


            f2execute.Attributes.Add("onclick", "javascript:return findplanetinrashi();");
            f3execute.Attributes.Add("onclick", "javascript:return findhouseinrashi();");
            f4execute.Attributes.Add("onclick", "javascript:return findplanetinrashiinhouse();");
            f5execute.Attributes.Add("onclick", "javascript:return findplanetinconstelation();");
            f7execute.Attributes.Add("onclick", "javascript:return f7findplanetinrashi();");
            f8execute.Attributes.Add("onclick", "javascript:return f8findplanetinrashiinhouse();");
            f9execute.Attributes.Add("onclick", "javascript:return f9_execute();");
            f10execute.Attributes.Add("onclick", "javascript:return f10_execute();");
            f11execute.Attributes.Add("onclick", "javascript:return f11_execute();");
            f12execute.Attributes.Add("onclick", "javascript:return f12_execute();");
            f13execute.Attributes.Add("onclick", "javascript:return f13_execute();");
            f16execute.Attributes.Add("onclick", "javascript:return f16_execute();");
            f14execute.Attributes.Add("onclick", "javascript:return f14_execute();");
            f15execute.Attributes.Add("onclick", "javascript:return f15_execute();");
            f17execute.Attributes.Add("onclick", "javascript:return f17_execute();");
            f18execute.Attributes.Add("onclick", "javascript:return f18_execute();");
            f19execute.Attributes.Add("onclick", "javascript:return f19_execute();");
            f20execute.Attributes.Add("onclick", "javascript:return f20_execute();");
            



            f2update.Attributes.Add("onclick", "javascript:return updateplanetinrashi();");
            f3update.Attributes.Add("onclick", "javascript:return updatehouseinrashi();");
            f4update.Attributes.Add("onclick", "javascript:return updateplanetinrashiinhouse();");
            f5update.Attributes.Add("onclick", "javascript:return updateplanetinconstelation();");
            f7update.Attributes.Add("onclick", "javascript:return f7updateplanetinrashi();");
            f8update.Attributes.Add("onclick", "javascript:return f8updateplanetinrashiinhouse();");
            f9update.Attributes.Add("onclick", "javascript:return f9_update();");
            f10update.Attributes.Add("onclick", "javascript:return f10_update();");
            f11update.Attributes.Add("onclick", "javascript:return f11_update();");
            f12update.Attributes.Add("onclick", "javascript:return f12_update();");
            f13update.Attributes.Add("onclick", "javascript:return f13_update();");
            f16update.Attributes.Add("onclick", "javascript:return f16_update();");
            f14update.Attributes.Add("onclick", "javascript:return f14_update();");
            f15update.Attributes.Add("onclick", "javascript:return f15_update();");
            f17update.Attributes.Add("onclick", "javascript:return f17_update();");
            f18update.Attributes.Add("onclick", "javascript:return f18_update();");
            f19update.Attributes.Add("onclick", "javascript:return f19_update();");
            f20update.Attributes.Add("onclick", "javascript:return f20_update();");


            //f17ahouse.Attributes.Add("onkeydown", "javascript:return fillhouseinedm(event);");
            f19house.Attributes.Add("onkeydown", "javascript:return houseincharan(event);");
            f9house.Attributes.Add("onchange", "javascript:return lordhouseintohouse();");
            f22ahouse.Attributes.Add("onchange", "javascript:return lordhouseinhousewithplanet();");
            f10alhouse.Attributes.Add("onchange", "javascript:return lordhousewithhouse();");
            f11house.Attributes.Add("onchange", "javascript:return lordhouseaspectinghouse();");
            f12house.Attributes.Add("onchange", "javascript:return planetaspectinghouse();");
            f13aplanet.Attributes.Add("onchange", "javascript:return planetaspectplanet();");
            f16aplanet.Attributes.Add("onchange", "javascript:return planetaspectbyplanet();");
            f14aplanet.Attributes.Add("onchange", "javascript:return planetaspectbenific();");
            f15house.Attributes.Add("onchange", "javascript:return planetfromplanet();");
            f17rashi.Attributes.Add("onchange", "javascript:return houseindebexal();");
            f18cons.Attributes.Add("onchange", "javascript:return bindhouseincons();");
            f19cons.Attributes.Add("onchange", "javascript:return bindhouseincharanofcons();");
           
            f20aplanet.Attributes.Add("onkeydown", "javascript:return f20fillplanet(event);");
            f20arashi.Attributes.Add("onkeydown", "javascript:return f20fillrashi(event);");
            f20rashi.Attributes.Add("onchange", "javascript:return f20bindquadraped();");
            f21wrashi.Attributes.Add("onchange", "javascript:return f21bindwatery();");
            f23planet.Attributes.Add("onchange", "javascript:return f23bindplanet();");
            f24house2.Attributes.Add("onchange", "javascript:return f24bindlohinhouse();");
            f25house.Attributes.Add("onchange", "javascript:return f25bindlohinhouse();");
            f25malifics.Attributes.Add("onkeydown", "javascript:return f25fillmalifics(event);");
            f26malifics.Attributes.Add("onchange", "javascript:return f26bindlohaspectbybenmal();");
            f22planet.Attributes.Add("onkeydown", "javascript:return f22fillplanet(event);");
            f27loh2.Attributes.Add("onchange", "javascript:return f27bindlohaspectbydispositor();");
            f28sign.Attributes.Add("onchange", "javascript:return f28bindlohwithbenmalinwatery();");
            f29planet.Attributes.Add("onchange", "javascript:return lordofhousefromplanet(event);");
            f30loh.Attributes.Add("onchange", "javascript:return planethouselord(event);");
            f31aloh.Attributes.Add("onchange", "javascript:return lohinhouseloh(event);");
            f32rashi.Attributes.Add("onchange", "javascript:return lordrashiclass();");
        }

    }


    public void bindplanet()
    {
        drpplanet.Items.Clear();
        f2planet.Items.Clear();
        f4planet.Items.Clear();
        f5planet.Items.Clear();
        f12planet.Items.Clear();
        f13planet.Items.Clear();
        f13aplanet.Items.Clear();
        f14planet.Items.Clear();
        f15planet.Items.Clear();
        f15aplanet.Items.Clear();
        f16planet.Items.Clear();
        f16aplanet.Items.Clear();
        f18planet.Items.Clear();
        f19planet.Items.Clear();
        f20planet.Items.Clear();
        f21planet.Items.Clear();
       
        f23planet.Items.Clear();
        f24planet.Items.Clear();
        f25planet.Items.Clear();
        f29planet.Items.Clear();
        f30planet.Items.Clear();

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
        drpplanet.Items.Add(li);
        f2planet.Items.Add(li);
        f4planet.Items.Add(li);
        f5planet.Items.Add(li);
        f12planet.Items.Add(li);
        f13planet.Items.Add(li);
        f13aplanet.Items.Add(li);
        f14planet.Items.Add(li);
        f15planet.Items.Add(li);
        f15aplanet.Items.Add(li);
        f16planet.Items.Add(li);
        f16aplanet.Items.Add(li);
        f18planet.Items.Add(li);
        f19planet.Items.Add(li);
        f20planet.Items.Add(li);
        f21planet.Items.Add(li);
        
        f23planet.Items.Add(li);
        f24planet.Items.Add(li);
        f25planet.Items.Add(li);
        f29planet.Items.Add(li);
        f30planet.Items.Add(li);

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            drpplanet.Items.Add(li1);
            f2planet.Items.Add(li1);
            f4planet.Items.Add(li1);
            f5planet.Items.Add(li1);
            f12planet.Items.Add(li1);
            f13planet.Items.Add(li1);
            f13aplanet.Items.Add(li1);
            f14planet.Items.Add(li1);
            f15planet.Items.Add(li1);
            f15aplanet.Items.Add(li1);
            f16planet.Items.Add(li1);
            f16aplanet.Items.Add(li1);
            f18planet.Items.Add(li1);
            f19planet.Items.Add(li1);
            f20planet.Items.Add(li1);
            f21planet.Items.Add(li1);
            
            f23planet.Items.Add(li1);
            f24planet.Items.Add(li1);
            f25planet.Items.Add(li1);
            f29planet.Items.Add(li1);
            f30planet.Items.Add(li1);
        }
    }


    public void bindrashi()
    {
        
        f2rashi.Items.Clear();
        f3rashi.Items.Clear();
        f4rashi.Items.Clear();
        
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_rashi("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select Rashi--";
        li.Value = "0";
        li.Selected = true;
        f2rashi.Items.Add(li);
        f3rashi.Items.Add(li);
        f4rashi.Items.Add(li);
        
       
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            f2rashi.Items.Add(li1);
            f3rashi.Items.Add(li1);
            f4rashi.Items.Add(li1);
           
            
        }
    }


    public void bindrashinew()
    {

        f32rashi.Items.Clear();
       

        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_rashibind("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select Rashi--";
        li.Value = "0";
        li.Selected = true;
        f32rashi.Items.Add(li);
        


        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            f32rashi.Items.Add(li1);
           


        }
    }

    public void bindwateryrashi()
    {

        
        f21wrashi.Items.Clear();
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_watery("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select Rashi--";
        li.Value = "0";
        li.Selected = true;

        f21wrashi.Items.Add(li);
       
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();

            f21wrashi.Items.Add(li1);
          
        }
    }

    public void bindquadrapedrashi()
    {

        
        f20rashi.Items.Clear();
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_quadraped("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select Rashi--";
        li.Value = "0";
        li.Selected = true;
       
        f20rashi.Items.Add(li);

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
           
            f20rashi.Items.Add(li1);

        }
    }

    public void bindcharan()
    {

        f19charan.Items.Clear();
       
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_charan("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select Charan--";
        li.Value = "0";
        li.Selected = true;
        f19charan.Items.Add(li);
       

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            f19charan.Items.Add(li1);
           

        }
    }



    public void bindconstellation()
    {
        f5constelation.Items.Clear();
        f18cons.Items.Clear();
        f19cons.Items.Clear();
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_constellation("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select Constellation--";
        li.Value = "0";
        li.Selected = true;
        f5constelation.Items.Add(li);
        f18cons.Items.Add(li);
        f19cons.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            f5constelation.Items.Add(li1);
            f18cons.Items.Add(li1);
            f19cons.Items.Add(li1);

        }
    }



    



    public void binddebexl()
    {
        f17rashi.Items.Clear();
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
        f17rashi.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            f17rashi.Items.Add(li1);

        }
    }
    

    public void bindhouse()
    {
        f3house.Items.Clear();
        f4house.Items.Clear();
        f9house.Items.Clear();
        f9lhouse.Items.Clear();
        f10lhouse.Items.Clear();
        f10house.Items.Clear();
        f10alhouse.Items.Clear();
        f11lhouse.Items.Clear();
        f11house.Items.Clear();
        f12house.Items.Clear();
        f13house.Items.Clear();
        f14house.Items.Clear();
        f15house.Items.Clear();
        f17house.Items.Clear();
        
        f18house.Items.Clear();
        f21house.Items.Clear();
        f21ahouse.Items.Clear();
        f22house.Items.Clear();
        f22ahouse.Items.Clear();
        f23house.Items.Clear();
        f24house.Items.Clear();
        f24loh1.Items.Clear();
        f24loh2.Items.Clear();
        f24house1.Items.Clear();
        f24house2.Items.Clear();
        f25house.Items.Clear();
        f25loh.Items.Clear();
        f26house.Items.Clear();
        f27loh1.Items.Clear();
        f27loh2.Items.Clear();
        f28loh.Items.Clear();
        f29loh.Items.Clear();
        f29house.Items.Clear();
        f30house.Items.Clear();
        f30loh.Items.Clear();
        f31loh.Items.Clear();
        f31house.Items.Clear();
        f31aloh.Items.Clear();
        f32loh.Items.Clear();
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
        f3house.Items.Add(li);
        f4house.Items.Add(li);
        f9house.Items.Add(li);
        f9lhouse.Items.Add(li);
        f10lhouse.Items.Add(li);
        f10house.Items.Add(li);
        f10alhouse.Items.Add(li);
        f11lhouse.Items.Add(li);
        f11house.Items.Add(li);
        f12house.Items.Add(li);
        f13house.Items.Add(li);
        f14house.Items.Add(li);
        f15house.Items.Add(li);
        f17house.Items.Add(li);
       
        f18house.Items.Add(li);
        f21house.Items.Add(li);
        f21ahouse.Items.Add(li);
        f22house.Items.Add(li);
        f22ahouse.Items.Add(li);
        f23house.Items.Add(li);

        f24house.Items.Add(li);
        f24loh1.Items.Add(li);
        f24loh2.Items.Add(li);
        f24house1.Items.Add(li);
        f24house2.Items.Add(li);
        f25house.Items.Add(li);
        f25loh.Items.Add(li);
        f26house.Items.Add(li);
        f27loh1.Items.Add(li);
        f27loh2.Items.Add(li);
        f28loh.Items.Add(li);
        f29loh.Items.Add(li);
        f29house.Items.Add(li);
        f30house.Items.Add(li);
        f30loh.Items.Add(li);
        f31loh.Items.Add(li);
        f31house.Items.Add(li);
        f31aloh.Items.Add(li);
        f32loh.Items.Add(li);
        
       // f19house.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            f3house.Items.Add(li1);
            f4house.Items.Add(li1);
            f9house.Items.Add(li1);
            f9lhouse.Items.Add(li1);
            f10lhouse.Items.Add(li1);
            f10house.Items.Add(li1);
            f10alhouse.Items.Add(li1);
            f11lhouse.Items.Add(li1);
            f11house.Items.Add(li1);
            f12house.Items.Add(li1);
            f13house.Items.Add(li1);
            f14house.Items.Add(li1);
            f15house.Items.Add(li1);
            f17house.Items.Add(li1);
           
            f18house.Items.Add(li1);
            f21house.Items.Add(li1);
            f21ahouse.Items.Add(li1);
            f22house.Items.Add(li1);
            f22ahouse.Items.Add(li1);
            f23house.Items.Add(li1);
            f24house.Items.Add(li1);
            f24loh1.Items.Add(li1);
            f24loh2.Items.Add(li1);
            f24house1.Items.Add(li1);
            f24house2.Items.Add(li1);
            f25house.Items.Add(li1);
            f25loh.Items.Add(li1);
            f26house.Items.Add(li1);
            f27loh1.Items.Add(li1);
            f27loh2.Items.Add(li1);
            f28loh.Items.Add(li1);
            f29loh.Items.Add(li1);
            f29house.Items.Add(li1);
            f30house.Items.Add(li1);
            f30loh.Items.Add(li1);
            f31loh.Items.Add(li1);
            f31house.Items.Add(li1);
            f31aloh.Items.Add(li1);
            f32loh.Items.Add(li1);
            
            //  f19house.Items.Add(li1);
        }
    }

    public void bindbenmal()
    {
        f14aplanet.Items.Clear();
        f26malifics.Items.Clear();
        f28benmal.Items.Clear();
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
        f14aplanet.Items.Add(li);
        f26malifics.Items.Add(li);
        f28benmal.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            f14aplanet.Items.Add(li1);
            f26malifics.Items.Add(li1);
            f28benmal.Items.Add(li1);

        }
    }



    

    public void bindchart()
    {
        f1chart.Items.Clear();
        f2chart.Items.Clear();
        f3chart.Items.Clear();
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
        f14chart.Items.Clear();
        f15chart.Items.Clear();
        f16chart.Items.Clear();
        f17chart.Items.Clear();
        f18chart.Items.Clear();
        f19chart.Items.Clear();
        f20chart.Items.Clear();
        f21chart.Items.Clear();
        f22chart.Items.Clear();
        f23chart.Items.Clear();
        f24chart.Items.Clear();
        f25chart.Items.Clear();
        f26chart.Items.Clear();
        f27chart.Items.Clear();
        f28chart.Items.Clear();
        f29chart.Items.Clear();
        f30chart.Items.Clear();
        f31chart.Items.Clear();
        f32chart.Items.Clear();
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
        f14chart.Items.Add(li);
        f15chart.Items.Add(li);
        f16chart.Items.Add(li);
        f17chart.Items.Add(li);
        f18chart.Items.Add(li);
        f19chart.Items.Add(li);
        f20chart.Items.Add(li);
        f21chart.Items.Add(li);
        f22chart.Items.Add(li);
        f23chart.Items.Add(li);
        f24chart.Items.Add(li);
        f25chart.Items.Add(li);
        f26chart.Items.Add(li);
        f27chart.Items.Add(li);
        f28chart.Items.Add(li);
        f29chart.Items.Add(li);
        f30chart.Items.Add(li);
        f31chart.Items.Add(li);
        f32chart.Items.Add(li);
        
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
            f14chart.Items.Add(li1);
            f15chart.Items.Add(li1);
            f16chart.Items.Add(li1);
            f17chart.Items.Add(li1);
            f18chart.Items.Add(li1);
            f19chart.Items.Add(li1);
            f20chart.Items.Add(li1);
            f21chart.Items.Add(li1);
            f22chart.Items.Add(li1);
            f23chart.Items.Add(li1);
            f24chart.Items.Add(li1);
            f25chart.Items.Add(li1);
            f26chart.Items.Add(li1);
            f27chart.Items.Add(li1);
            f28chart.Items.Add(li1);
            f29chart.Items.Add(li1);
            f30chart.Items.Add(li1);
            f31chart.Items.Add(li1);
            f32chart.Items.Add(li1);

        }




    }
    
    [Ajax.AjaxMethod]
    public DataSet fill_rashi(string extra1)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.multiplesigni country = new ASTROLOGY.classesoracle.multiplesigni();
            ds = country.bind_rashi(extra1);
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
    public DataSet fill_malifics(string extra1)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Benific_malific country = new ASTROLOGY.classesoracle.Benific_malific();
            ds = country.ast_malific(extra1);
        }

        return ds;
    }
    [Ajax.AjaxMethod]
    public DataSet fill_planet(string extra1)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.multiplesigni country = new ASTROLOGY.classesoracle.multiplesigni();
            ds = country.bind_planet(extra1);
        }

        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet multipleplanetinanyhouse(string name,string book,string page,string filter,string detail,string description,string nop,string chart,string unique,string fid,string today)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.save_multipleplanetinanyhouse(name, book, page, filter, detail, description,nop,chart,unique,fid,today);
        }

        return ds;
    }
    
    [Ajax.AjaxMethod]
    public DataSet saveplanetonhouse(string house, string planet, string name, string description, string book, string page, string filter,string detail,string chart,string unique,string fid,string today)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.save_planetinhouse(house, planet, name, description, book, page, filter, detail, chart, unique, fid, today);
        }

        return ds;
    }
    
    [Ajax.AjaxMethod]
    public DataSet save_f2predictiveinput(string f2planet, string f2rashi, string f2book, string f2page, string f2filter, string f2detail, string f2description, string f2name,string chart,string unique,string fid,string today)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.save_f2predictiveinput(f2planet, f2rashi, f2book, f2page, f2filter, f2detail, f2description, f2name,chart,unique,fid,today);
        }

        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet save_f3predictiveinput(string f3house, string f3rashi, string f3book, string f3page, string f3filter, string f3detail, string f3description, string f3name,string chart,string unique,string fid,string today)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.save_f3predictiveinput(f3house, f3rashi, f3book, f3page, f3filter, f3detail, f3description, f3name,chart,unique,fid,today);
        }

        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet save_f4predictiveinput(string f4planet,string f4house, string f4rashi, string f4book, string f4page, string f4filter, string f4detail, string f4description, string f4name,string chart,string unique,string fid,string today)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.save_f4predictiveinput(f4planet, f4house, f4rashi, f4book, f4page, f4filter, f4detail, f4description, f4name, chart, unique, fid, today);
        }

        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet save_f5predictiveinput(string f5planet, string f5constelation, string f5book, string f5page, string f5filter, string f5detail, string f5description, string f5name,string chart,string unique,string fid,string today)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.save_f5predictiveinput(f5planet, f5constelation, f5book, f5page, f5filter, f5detail, f5description, f5name,chart,unique,fid,today);
        }

        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet find_entry(string planet,string house)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.find_entry(planet, house);
        }

        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet fetch_f2predictiveinput(string planet, string rashi)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.fetch_f2predictiveinput(planet, rashi);
        }

        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet fetch_f3predictiveinput(string house, string rashi)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.fetch_f3predictiveinput(house, rashi);
        }

        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet fetch_f4predictiveinput(string house, string rashi,string planet)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.fetch_f4predictiveinput(house, rashi,planet);
        }

        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet fetch_f5predictiveinput(string planet, string constelation)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.fetch_f5predictiveinput(planet, constelation);
        }

        return ds;
    }
    
     [Ajax.AjaxMethod]
    public DataSet update_findentry(string planet, string house, string filter, string filternew, string detail, string book, string page)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.update_findentry(planet, house, filter, filternew, detail, book, page);
        }

        return ds;
    }
    
        [Ajax.AjaxMethod]
     public DataSet update_planetinrashi(string f2planet, string f2rashi, string f2filter, string f2filternew, string detail, string book, string page)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.update_planetinrashi(f2planet, f2rashi, f2filter, f2filternew, detail, book, page);
        }

        return ds;
    }


    
        [Ajax.AjaxMethod]
        public DataSet update_houseinrashi(string f3house, string f3rashi, string f3filter, string f3filternew, string detail, string book, string page)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.update_houseinrashi(f3house, f3rashi, f3filter, f3filternew, detail, book, page);
        }

        return ds;
    }


        [Ajax.AjaxMethod]
        public DataSet update_planetinrashiinhouse(string f4house, string f4rashi, string f4planet, string f4filter, string f4filternew, string detail, string book,string page)
        {
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
                ds = country.update_planetinrashiinhouse(f4house, f4rashi, f4planet, f4filter, f4filternew, detail, book, page);
            }

            return ds;
        }
    
     [Ajax.AjaxMethod]
     public DataSet find_multiple_entry(string name)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.find_multiple_entry(name);
        }

        return ds;
    }
     [Ajax.AjaxMethod]
     public DataSet update_multiplefindentry(string name, string filter, string filternew, string detail, string book, string page)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.update_multiplefindentry(name, filter, filternew, detail, book, page);
        }

        return ds;
    }


      [Ajax.AjaxMethod]
     public DataSet update_planetinconstelation(string f5planet, string f5constelation,string f5filter, string f5filternew, string detail, string book, string page)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.update_planetinconstelation(f5planet, f5constelation, f5filter, f5filternew, detail, book, page);
        }

        return ds;
    }


      [Ajax.AjaxMethod]
      public DataSet lordhouseinto_house(string lordofhouse, string inhouse)
      {
          DataSet ds = new DataSet();
          if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
          {
              ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
              ds = country.bindinhouse(lordofhouse, inhouse);
          }

          return ds;
      }




    [Ajax.AjaxMethod]
      public DataSet save_f9(string astrocat1, string lagna, string lordof, string house2, string inhouse, string loh, string desc, string detail, string categery, string book1, string keystring1, string rashi, string inrashi, string f9page,string chart,string unique,string fid,string today)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.save_in(astrocat1, lagna, lordof, house2, inhouse, loh, desc, detail, categery, book1, keystring1, rashi, inrashi, f9page,chart,unique,fid,today);
        }

        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet f9_executevalue(string loh,string categery, string inhouse)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.fetch_f9(loh, categery, inhouse);
        }

        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet f9_updatevalue(string loh, string categery, string inhouse, string filter, string filternew, string detail, string book, string page)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.update_f9_updatevalue(loh, categery, inhouse, filter, filternew, detail, book, page);
        }

        return ds;
    }
    
    
    [Ajax.AjaxMethod]
    public DataSet f10combination(string withthouse, string lordofhouse)
      {
          DataSet ds = new DataSet();
          if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
          {
              ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
              ds = country.bindwithhouse(withthouse, lordofhouse);
          }

          return ds;
      }

   [Ajax.AjaxMethod]
    public DataSet save_f10(string name, string book, string page, string filter, string detail, string description, string nop,string comb,string chart,string unique,string fid,string today)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.save_f10with(name, book, page, filter, detail, description,nop,comb,chart,unique,fid,today);
        }

        return ds;
    }


   [Ajax.AjaxMethod]
   public DataSet execute_f10(string comb)
   {
       DataSet ds = new DataSet();
       if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
       {
           ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
           ds = country.f10_execute_withlord(comb);
       }

       return ds;
   }

   [Ajax.AjaxMethod]
   public DataSet update_f10(string comb, string filter, string filternew, string detail, string book, string page)
   {
       DataSet ds = new DataSet();
       if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
       {
           ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
           ds = country.f10_update_withlord(comb, filter, filternew, detail, book, page);
       }

       return ds;
   }


    [Ajax.AjaxMethod]
   public DataSet f11lohah(string aspecthouse, string lordofhouse)
      {
          DataSet ds = new DataSet();
          if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
          {
              ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
              ds = country.aspect(aspecthouse, lordofhouse);
          }

          return ds;
      }



    [Ajax.AjaxMethod]
    public DataSet save_f11(string astrocat1, string aspects, string lord, string rashi, string hous, string desc, string detail, string loh, string categery, string lagna, string book1, string keystring1, string aspectrashi,string f11page,string chart,string unique,string fid,string today)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.save_aspect(astrocat1, aspects, lord, rashi, hous, desc, detail, loh, categery, lagna, book1, keystring1, aspectrashi, f11page, chart, unique, fid, today);
        }

        return ds;
    }

   [Ajax.AjaxMethod]
    public DataSet f12pah(string lordhouse, string planet1)
      {
          DataSet ds = new DataSet();
          if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
          {
              ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
              ds = country.bindplanethouse(lordhouse, planet1);
          }

          return ds;
      }

   [Ajax.AjaxMethod]
   public DataSet save_f12(string astrocat1,string lagna,string planet1,string categery,string housep,string desc,string detail,string lordp,string house1,string aspecthouse,string book1,string keystring1,string rashi,string aspectrashi,string f12page,string chart,string unique,string fid,string today)
   {
       DataSet ds = new DataSet();
       if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
       {
           ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
           ds = country.save_planet(astrocat1, lagna, planet1, categery, housep, desc, detail, lordp, house1, aspecthouse, book1, keystring1, rashi, aspectrashi, f12page,chart,unique,fid,today);
       }

       return ds;
   }


   [Ajax.AjaxMethod]
   public DataSet f12_executevalue(string planet, string categery, string aspecthouse)
   {
       DataSet ds = new DataSet();
       if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
       {
           ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
           ds = country.fetch_f12(planet, categery, aspecthouse);
       }

       return ds;
   }

     [Ajax.AjaxMethod]
   public DataSet f12_updatevalue(string planet, string categery, string aspectshouse, string filter, string filternew, string detail, string book, string page)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.update_f12_updatevalue(planet, categery, aspectshouse, filter, filternew, detail, book, page);
        }

        return ds;
    }
     [Ajax.AjaxMethod]
     public DataSet planetaspectplanet(string planet, string planet1, string house)
     {

         DataSet ds = new DataSet();
         if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
         {

             //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
             ASTROLOGY.classesoracle.planet_aspect_planet ashouse = new ASTROLOGY.classesoracle.planet_aspect_planet();
             ds = ashouse.aspecthouse(planet, planet1, house);
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
     public DataSet f13_executevalue(string f13planet, string f13house, string f13aplanet)
   {
       DataSet ds = new DataSet();
       if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
       {
           ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
           ds = country.fetch_f13(f13planet, f13house, f13aplanet);
       }

       return ds;
   }
     [Ajax.AjaxMethod]
   public DataSet f13_updatevalue(string planet, string house, string aplanet, string filter, string filternew, string detail, string book, string page)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.update_f13_updatevalue(planet, house, aplanet, filter, filternew, detail, book, page);
        }

        return ds;
    }

    [Ajax.AjaxMethod]
     public DataSet planetaspectbenific(string planet, string house, string benmal)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Benific_malific bmcountry = new ASTROLOGY.classesoracle.Benific_malific();
            ds = bmcountry.aspectbenimali(planet, house, benmal);
        }
        return ds;

    }
    [Ajax.AjaxMethod]
    public DataSet save_f14(string f14planet, string f14house, string f14aplanet, string f14book, string f14page, string keystring, string detail, string desc, string combination, string lagna,string chart,string unique,string fid,string today)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Benific_malific country = new ASTROLOGY.classesoracle.Benific_malific();
            ds = country.save_benific_malific(f14planet, f14house, f14aplanet, f14book, f14page, keystring, detail, desc, combination, lagna,chart,unique,fid,today);
        }

        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet f14_executevalue(string f14planet, string f14house, string f14aplanet)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.fetch_f14(f14planet, f14house, f14aplanet);
        }

        return ds;
    }
    [Ajax.AjaxMethod]
    public DataSet f14_updatevalue(string planet, string house, string aplanet, string filter, string filternew, string detail, string book, string page)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.update_f14_updatevalue(planet, house, aplanet, filter, filternew, detail, book, page);
        }

        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet planetfromplanet(string planets, string fromplanet, string inhouse)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition bmcountry = new ASTROLOGY.classesoracle.Houseposition();
            ds = bmcountry.planetfromplanet(planets, fromplanet, inhouse);
        }
        return ds;

    }

    [Ajax.AjaxMethod]
    public DataSet save_f15(string f15planet, string f15house, string f15aplanet, string f15book, string f15page, string keystring, string detail, string desc, string combination, string lagna,string chart,string unique,string fid,string today)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.saveplanetfromplanet(f15planet, f15house, f15aplanet, f15book, f15page, keystring, detail, desc, combination, lagna,chart,unique,fid,today);
        }

        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet f15_executevalue(string f15planet, string f15house, string f15aplanet)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.fetch_f15(f15planet, f15house, f15aplanet);
        }

        return ds;
     
    }

    [Ajax.AjaxMethod]
    public DataSet f15_updatevalue(string planet, string house, string aplanet, string filter, string filternew, string detail, string book, string page)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.update_f15_updatevalue(planet, house, aplanet, filter, filternew, detail, book, page);
        }

        return ds;
    }
    [Ajax.AjaxMethod]
    public DataSet planetaspectbyplanet(string planet, string planet1)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.planet_aspect_planet ashouse = new ASTROLOGY.classesoracle.planet_aspect_planet();
            ds = ashouse.aspectbyhouse(planet, planet1);
        }
        return ds;


    }

    [Ajax.AjaxMethod]
    public DataSet f16_executevalue(string f16planet, string f16aplanet)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.fetchf_f16(f16planet, f16aplanet);
        }

        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet f16_updatevalue(string planet, string aplanet, string filter, string filternew, string detail, string book, string page)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.update_f16_updatevalue(planet,  aplanet, filter, filternew, detail, book, page);
        }

        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet houseindebexal(string loh,  string rashi)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition ashouse = new ASTROLOGY.classesoracle.Houseposition();
            ds = ashouse.houseindebexal(loh,  rashi);
        }
        return ds;


    }

    [Ajax.AjaxMethod]
    public DataSet save_f17(string loh, string house, string categery, string lagnarashi, string rashi, string planet, string lfrom, string lto, string book, string page,string filter, string detail, string desc,string chart,string unique,string fid,string today)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.houseinedm(loh, house, categery, lagnarashi, rashi, planet, lfrom, lto, book, page, filter, detail, desc, chart, unique, fid, today);
        }

        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet f17_executevalue(string loh, string house, string categery)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.fetch_f17(loh, house, categery);
        }

        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet f17_updatevalue(string loh, string house, string categery, string filter, string filternew, string detail, string book, string page)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.update_f17_updatevalue(loh, house, categery, filter, filternew, detail, book, page);
        }

        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet houseincons(string f18planet, string f18house, string f18cons)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.predictive_input ashouse = new ASTROLOGY.classesoracle.predictive_input();
            ds = ashouse.houseincons(f18planet, f18house, f18cons);
        }
        return ds;


    }


    [Ajax.AjaxMethod]
    public DataSet save_f18(string planet, string house, string cons, string book, string page, string filter, string rashi, string charan, string lfrom, string lto, string detail,string desc,string chart,string unique,string fid,string today)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.savehouseincons(planet, house, cons, book, page, filter, rashi, charan, lfrom, lto,detail,desc,chart,unique,fid,today);
        }

        return ds;
    }
    [Ajax.AjaxMethod]
    public DataSet f18_executevalue(string planet, string house, string cons)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.fetch_f18(planet, house, cons);
        }

        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet f18_updatevalue(string planet, string house,string cons, string filter, string filternew, string detail, string book, string page)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.update_f18_updatevalue(planet, house,cons, filter, filternew, detail, book, page);
        }

        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet houseincharanincons(string f19planet, string f19house, string f19cons, string f19charan)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.predictive_input ashouse = new ASTROLOGY.classesoracle.predictive_input();
            ds = ashouse.houseincharanincons(f19planet, f19house, f19cons, f19charan);
        }
        return ds;

        
    }

    [Ajax.AjaxMethod]
    public DataSet planetinquadraped(string qplanet)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.predictive_input ashouse = new ASTROLOGY.classesoracle.predictive_input();
            ds = ashouse.planetinquadraped(qplanet);
        }
        return ds;

        
    }
    
    [Ajax.AjaxMethod]
    public DataSet save_f20(string qplanet, string qrashi, string desc1, string detail, string book, string page, string combination, string filter,string nop,string chart,string unique,string fid,string today)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.savequadraped(qplanet, qrashi, desc1, detail, book, page, combination, filter,nop,chart,unique,fid,today);
        }

        return ds;
    }
    [Ajax.AjaxMethod]
    public DataSet f20_executevalue(string qplanet)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.fetch_f20(qplanet);
        }

        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet f20_updatevalue(string qplanet,  string filter, string filternew, string detail, string book, string page)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.update_f20_updatevalue(qplanet, filter, filternew, detail, book, page);
        }

        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet planetinwrashi(string house)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.predictive_input ashouse = new ASTROLOGY.classesoracle.predictive_input();
            ds = ashouse.planetinwatery(house);
        }
        return ds;


    }
    [Ajax.AjaxMethod]
    public DataSet save_f21(string house, string wrashi, string planet, string ahouse, string book, string page, string filter, string detail, string desc,string name,string chart,string unique,string fid,string today)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.predictive_input country = new ASTROLOGY.classesoracle.predictive_input();
            ds = country.savewatery(house, wrashi, planet, ahouse, book, page, filter, detail, desc,name,chart,unique,fid,today);
        }
        
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet lohaspectedbyplanet(string planet, string loh)
     {

         DataSet ds = new DataSet();
         if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
         {

             //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
             ASTROLOGY.classesoracle.planet_aspect_planet ashouse = new ASTROLOGY.classesoracle.planet_aspect_planet();
             ds = ashouse.lohaspectedbyplanet(planet, loh);
         }
         return ds;


     }

    [Ajax.AjaxMethod]
    public DataSet f24lohhouse(string loh1, string house1, string planet, string house, string loh2, string house2)
     {

         DataSet ds = new DataSet();
         if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
         {

             //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
             ASTROLOGY.classesoracle.predictive_input ashouse = new ASTROLOGY.classesoracle.predictive_input();
             ds = ashouse.f24lohhouse(loh1, house1, planet, house, loh2, house2);
         }
         return ds;


     }
     [Ajax.AjaxMethod]
    public DataSet save_lordwithplanetwithmalifics(string lagnarashi, string lordofhouse, string lord, string house, string rashi, string combination, string book, string page, string filter, string detail, string description,string nop,string chart,string unique,string fid,string today)
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
     public DataSet f26bindlohaspectbybenmal(string lordofhouse, string benmal)
     {

         DataSet ds = new DataSet();
         if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
         {

             //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
             ASTROLOGY.classesoracle.predictive_input ashouse = new ASTROLOGY.classesoracle.predictive_input();
             ds = ashouse.f26lohaspbenmal(lordofhouse, benmal);
         }
         return ds;


     }
     [Ajax.AjaxMethod]
    public DataSet f27bindlohaspectbydispositor(string loh1, string loh2)
     {

         DataSet ds = new DataSet();
         if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
         {

             //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
             ASTROLOGY.classesoracle.predictive_input ashouse = new ASTROLOGY.classesoracle.predictive_input();
             ds = ashouse.f27lohaspdis(loh1, loh2);
         }
         return ds;


     }

     [Ajax.AjaxMethod]
     public DataSet f28bindlohwithbenmalinwatery(string loh, string benmal, string sign)
     {

         DataSet ds = new DataSet();
         if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
         {

             //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
             ASTROLOGY.classesoracle.predictive_input ashouse = new ASTROLOGY.classesoracle.predictive_input();
             ds = ashouse.f28lohwithbenmal(loh, benmal, sign);
         }
         return ds;


     }


     [Ajax.AjaxMethod]
     public DataSet lordofhousefromplanet(string loh, string house,string planet)
     {

         DataSet ds = new DataSet();
         if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
         {

             //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
             ASTROLOGY.classesoracle.predictive_input ashouse = new ASTROLOGY.classesoracle.predictive_input();
             ds = ashouse.lordofhousefromplanet(loh,house,planet);
         }
         return ds;


     }



     [Ajax.AjaxMethod]
     public DataSet planethouselord(string planet, string house,string loh)
     {

         DataSet ds = new DataSet();
         if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
         {

             //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
             ASTROLOGY.classesoracle.predictive_input ashouse = new ASTROLOGY.classesoracle.predictive_input();
             ds = ashouse.planethouselord(planet,house,loh);
         }
         return ds;


     }




     [Ajax.AjaxMethod]
     public DataSet lohinhouseloh(string loh, string house, string aloh)
     {

         DataSet ds = new DataSet();
         if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
         {

             //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
             ASTROLOGY.classesoracle.Benific_malific bmcountry = new ASTROLOGY.classesoracle.Benific_malific();
             ds = bmcountry.lohinhouseloh(loh, house, aloh);
         }
         return ds;

     }


     [Ajax.AjaxMethod]
     public DataSet lordrashiclass(string loh, string rashi)
     {

         DataSet ds = new DataSet();
         if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
         {

             //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
             ASTROLOGY.classesoracle.Benific_malific bmcountry = new ASTROLOGY.classesoracle.Benific_malific();
             ds = bmcountry.lordrashiclass(loh, rashi);
         }
         return ds;

     }
    


    
    
}


