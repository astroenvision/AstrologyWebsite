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

public partial class all_predictive : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(all_predictive));

        hiddendateformat.Value = "dd/mm/yyyy";
        if (!Page.IsPostBack)
        {
            sf.Attributes.Add("onclick", "javascript:return click_on_subfilter();");
            ra.Attributes.Add("onclick", "javascript:return click_on_replace();");
            categery.Attributes.Add("onkeydown", "javascript:return fillcategery(event);");
            lstcategery.Attributes.Add("onkeydown", "javascript:return closelist(event);");
            lstcategery.Attributes.Add("onclick", "javascript:return sub_categery();");
            lstsubcategery.Attributes.Add("onkeydown", "javascript:return closesublist(event);");
            datesearch.Attributes.Add("onclick", "javascript:return datesearchfn();");
            
            

            s1.Attributes.Add("onclick", "javascript:return searchpredictive();");
            s2.Attributes.Add("onclick", "javascript:return searchid();");
            sh.Attributes.Add("onclick", "javascript:return showfilter();");
            de.Attributes.Add("onclick", "javascript:return deletefilter();");
           
        }
    }



    [Ajax.AjaxMethod]
    public DataSet searchp(string tblname)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {


            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.allpredictive(tblname);
        }
        return ds;

    }

    [Ajax.AjaxMethod]
    public DataSet update_gridall(string description, string description1, string descclob, string key, string key1,string tbl,string explain)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.update_gridall(description, description1, descclob, key, key1,tbl,explain);
        }
        return ds;


    }

    [Ajax.AjaxMethod]
    public DataSet delete_gridall(string description, string key, string tbl, string descclob,string explain)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.delete_gridall(description, key, tbl,descclob,explain);
        }
        return ds;


    }


    [Ajax.AjaxMethod]
    public DataSet delete_moved_grid(string description, string key, string tbl, string descclob, string explain)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.delete_moved_grid(description, key, tbl, descclob, explain);
        }
        return ds;


    }


    [Ajax.AjaxMethod]
    public DataSet update_table(string tbl,string desc,string key,string vrf)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {


            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.update_tabl(tbl,desc,key,vrf);
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
    public DataSet sub_filter(string extra1)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.categery country = new ASTROLOGY.classesoracle.categery();
            ds = country.bind_subcategery(extra1);
        }
        //else if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "sql")
        //{
        //    Circulation.Classes.lebel_gen gen = new Circulation.Classes.lebel_gen();
        //    ds = gen.bindagency_code1(compcode, unit, dateformate, extra1, extra2);
        //}
        return ds;
    }
    

    [Ajax.AjaxMethod]
    public DataSet showcatval(string lst)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {


            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.showcat(lst);
        }
        return ds;

    }

    [Ajax.AjaxMethod]
    public DataSet update_grid(string description, string description1, string descclob, string key, string key1,string explain,string fil)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
           // ds = country.update_grid(description, description1, descclob, key, key1,explain,fil);
        }
        return ds;


    }

    [Ajax.AjaxMethod]
    public DataSet deletecatval(string filter)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.deletecat(filter);
        }
        return ds;


    }


    [Ajax.AjaxMethod]
    public DataSet club_gridall(string descr, string kkey, string tbl)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.club_gridall(descr, kkey, tbl);
        }
        return ds;


    }

     [Ajax.AjaxMethod]
    public DataSet findreplace(string find, string replace,string tbl)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.findandreplace(find, replace,tbl);
        }
        return ds;


    }

    [Ajax.AjaxMethod]
     public DataSet subfilter(string filter, string subfilter)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.categery country = new ASTROLOGY.classesoracle.categery();
            ds = country.findandreplace(filter, subfilter);
        }
        return ds;


    }

    [Ajax.AjaxMethod]
    public DataSet searchbyid(string unique)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {


            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.searchbyid(unique);
        }
        return ds;

    }


    [Ajax.AjaxMethod]
    public DataSet searchbydate(string date1, string date2)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.searchbydate(date1, date2);
        }
        return ds;


    }

    
}
