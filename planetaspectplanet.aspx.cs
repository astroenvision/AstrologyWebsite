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

public partial class planetaspectplanet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(planetaspectplanet));
        DataSet ds1 = new DataSet();
        ds1.ReadXml(Server.MapPath("ast.xml/extentions.xml"));
        tblfields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        fields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        hiddendateformat.Value = "dd/mm/yyyy";
             
        if (!Page.IsPostBack)
        {
            bindhouse();
            bindplanet();
           
            planet1.Attributes.Add("onchange", "javascript:return planetaspect();");
            btnNew.Attributes.Add("onclick", "javascript:return EnableOnNew();");
            btnSave.Attributes.Add("onclick", "javascript:return Save_Records();");
            btnExecute.Attributes.Add("onclick", "javascript:return executequery(querytype)");
            btnQuery.Attributes.Add("onclick", "javascript:return enablequery()");
            btnCancel.Attributes.Add("onclick", "javascript:return click_on_cancel();");
            btnExit.Attributes.Add("onclick", "javascript:return Exit();");
            btnDelete.Attributes.Add("onclick", "javascript:return delete_data();");
            btnfirst.Attributes.Add("onclick", "javascript:return fnd_first_record()");
            btnnext.Attributes.Add("onclick", "javascript:return fnd_next_record()");
            btnprevious.Attributes.Add("onclick", "javascript:return fnd_pre_record()");
            btnlast.Attributes.Add("onclick", "javascript:return fnd_last_record()");
            btnModify.Attributes.Add("onclick", "javascript:return modifydata()");
        }
       
    
    }

    public void bindplanet()
    {
        planet.Items.Clear();
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
        planet.Items.Add(li);
        planet1.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            planet.Items.Add(li1);
            planet1.Items.Add(li1);

        }




    }

    public void bindhouse()
    {
        house.Items.Clear();
        
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_house("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select house--";
        li.Value = "0";
        li.Selected = true;
        house.Items.Add(li);
        
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            house.Items.Add(li1);
            

        }




    }


    [Ajax.AjaxMethod]
    public DataSet aspecthouse(string planet, string planet1,string house)
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
    public string save(string f13planet, string f13house, string f13aplanet, string f13book, string f13page, string keystring, string detail, string desc, string combination, string lagna)
    {
        try
        {
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.planet_aspect_planet country = new ASTROLOGY.classesoracle.planet_aspect_planet();
                ds = country.save_planet_aspect_planet(f13planet, f13house, f13aplanet, f13book, f13page, keystring, detail, desc, combination, lagna,"","","","");
            }
            return "true";
        }
        catch (Exception ex)
        {
            return Convert.ToString(ex.Message);

        }
    }
}
