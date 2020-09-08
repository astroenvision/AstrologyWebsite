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
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Media;

public partial class significator: System.Web.UI.Page
{
    string usermail = "";
    string message = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(significator));
        DataSet ds1 = new DataSet();
        ds1.ReadXml(Server.MapPath("ast.xml/encyclopaedia.xml"));
        tblfields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        fields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        hiddendateformat.Value = "dd/mm/yyyy";

        if (Session["usermail"] == null || Session["usermail"] == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(significator), "wq", "window.parent.location.href='login.aspx';", true);
            return;
        }
        usermail = Request.QueryString["usermail"];
        hdnuser.Value = Request.QueryString["usermail"];
        if (usermail != Session["usermail"].ToString())
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(significator), "wq", "window.parent.location.href='login.aspx';", true);
            // Response.Redirect("login.aspx");
            return;

        }
        if (!Page.IsPostBack)
        {
           
            bindhouse();
            bindplanet();
            bindrashi();

            texthouse.Attributes.Add("onchange", "javascript:return clh()");
            planet.Attributes.Add("onchange", "javascript:return clp()");
            rashi.Attributes.Add("onchange", "javascript:return clr()");
            exte.Attributes.Add("onclick", "javascript:return showextentions();");
            ms.Attributes.Add("onclick", "javascript:return showmultiplesignificators();");
            gs.Attributes.Add("onkeydown", "javascript:return fillcategery(event);");
            DataSet ds = new DataSet();


            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

                ds = country.ast_rights(Request.QueryString["usermail"].ToString());

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


    [Ajax.AjaxMethod]
    public DataSet fill_categery(string extra1)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.categery country = new ASTROLOGY.classesoracle.categery();
            ds = country.bind_categerygs(extra1);
        }
        //else if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "sql")
        //{
        //    Circulation.Classes.lebel_gen gen = new Circulation.Classes.lebel_gen();
        //    ds = gen.bindagency_code1(compcode, unit, dateformate, extra1, extra2);
        //}
        return ds;
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


   

    public void bindrashi()
    {
        rashi.Items.Clear();
       

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
        rashi.Items.Add(li);
      
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            rashi.Items.Add(li1);
            
        }




    }
    public void bindhouse()
    {
        texthouse.Items.Clear();
     
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_house("");
        }

        ListItem li = new ListItem();
        li.Text = "--Select House--";
        li.Value = "0";
        li.Selected = true;
        texthouse.Items.Add(li);
       
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            texthouse.Items.Add(li1);
          
        }
    }

    protected void AspNetMessageBox(string strMessage)
    {
        string strAlert = "";
        strAlert = "alert('" + strMessage + "')";
        ScriptManager.RegisterClientScriptBlock(this, typeof(significator), "ShowAlert", strAlert, true);
    }


    [Ajax.AjaxMethod]
    public string save1(string CODE, string KEY_STRING, string DESCCLOB, string BOOK, string PAGE_NO, string HOUSE, string PLANET, string RASHI, string EXTENTIONS)
    {
        try
        {
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {


                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                ds = country.save_encyclopaedia(CODE, KEY_STRING, DESCCLOB, BOOK, PAGE_NO, HOUSE, PLANET, RASHI, EXTENTIONS);
            }
            return "true";
        }
        catch (Exception ex)
        {
            return Convert.ToString(ex.Message);

        }

    }








    [Ajax.AjaxMethod]
    public DataSet execute1(string tbl, string col, string val, string mit, string dateformat, string extra1, string extra2)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {


            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.execute1(tbl, col, val, mit, dateformat, extra1, extra2);
        }
        return ds;

    }
    [Ajax.AjaxMethod]
    public string agency_delete1(string tbl, string col, string val, string formt, string extra1, string extra2)
    {
        try
        {
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {


                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                ds = country.delete1(tbl, col, val, formt, extra1, extra2);
            }
            return "true";
        }
        catch (Exception ex)
        {
            return Convert.ToString(ex.Message);

        }

    }
    [Ajax.AjaxMethod]
    public string Modify_data1(string tbl, string col, string val, string mit, string dateformat, string extra1, string extra2)
    {
        try
        {
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {


                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                ds = country.Modify_data1(tbl, col, val, mit, dateformat, extra1, extra2);

            }
            return "true";

        }
        catch (Exception ex)
        {
            return Convert.ToString(ex.Message);

        }
    }

  









    [Ajax.AjaxMethod]
    public DataSet filtergrid1(string comp_code, string house, string rashi, string planet, string textname, string book, string page0, string EXTENTIONS, string extra1)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {


            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.fillgrid(comp_code, house, rashi, planet, textname, book, page0, EXTENTIONS, extra1);
        }
        return ds;

    }


    [Ajax.AjaxMethod]
    public DataSet update_grid(string key, string key1, string housev)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.update_gridencyclo(key, key1, housev);
        }
        return ds;


    }



    [Ajax.AjaxMethod]
    public DataSet delete_grid_row(string key, string housev)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.delete_gridencyclo(key, housev);
        }
        return ds;


    }

    [Ajax.AjaxMethod]
    public DataSet showext(string exten)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.showextn(exten);
        }
        return ds;


    }
    [Ajax.AjaxMethod]
    public DataSet showextvalue(string exten, string extenvalue)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.showextnvalue(exten, extenvalue);
        }
        return ds;


    }

    [Ajax.AjaxMethod]
    public DataSet showextvalue_natal(string exten, string extenvalue)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.showextnvalue_natal(exten, extenvalue);
        }
        return ds;


    }

    [Ajax.AjaxMethod]
    public DataSet chk_encyclo(string key, string housev)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.chk_encyclogrid(key, housev);
        }
        return ds;


    }

    [Ajax.AjaxMethod]
    public DataSet multisignificators(string multisign)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.showmultisigni(multisign);
        }
        return ds;


    }

   
}
