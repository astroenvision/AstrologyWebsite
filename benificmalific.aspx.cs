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

public partial class benificmalific : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(benificmalific));
        DataSet ds1 = new DataSet();
        ds1.ReadXml(Server.MapPath("ast.xml/extentions.xml"));
        tblfields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        fields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        hiddendateformat.Value = "dd/mm/yyyy";
             
        if (!Page.IsPostBack)
        {

            bindplanet();
            bindbenmal();
            bindhouse();
            benmal.Attributes.Add("onchange", "javascript:return benmalaspects();");
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
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            planet.Items.Add(li1);

        }




    }



    public void bindbenmal()
    {
        benmal.Items.Clear();
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
        benmal.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            benmal.Items.Add(li1);

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
        li.Text = "--Select House--";
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
    public DataSet aspectbenmal(string planet,string house,string benmal)
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
      public string save(string f14planet, string f14house, string f14aplanet, string f14book, string f14page, string keystring, string detail, string desc, string combination, string lagna)
      {
          try
          {
              DataSet ds = new DataSet();
              if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
              {
                  ASTROLOGY.classesoracle.Benific_malific country = new ASTROLOGY.classesoracle.Benific_malific();
                  ds = country.save_benific_malific(f14planet, f14house, f14aplanet, f14book, f14page, keystring, detail, desc, combination, lagna,"","","","");
              }
              return "true";
          }
          catch (Exception ex)
          {
              return Convert.ToString(ex.Message);

          }
      }
}
