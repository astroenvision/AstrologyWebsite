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
using System.Text.RegularExpressions;
using kundli4c;


public partial class Birth_Detail : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    common cs = new common();
    string name = "", mmail = "", amail = "", mobno = "", landno = "", lndmrk = "", add1 = "", add2 = "", zip = "", country = "", pass = "", subscription = "";
    double degreeasc;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        hdncit.Value = "~";
        Ajax.Utility.RegisterTypeForAjax(typeof(Birth_Detail));
        if (!IsPostBack)
        {
            mainchannelbind();
        }
    }

    public void mainchannelbind()
    {
        if (!Page.IsPostBack)
        {
            ds = cs.bindloc();
            ddlcunt.Items.Clear();
            ddlcunt.DataSource = ds;
            ddlcunt.DataTextField = "loc_name";
            ddlcunt.DataValueField = "loc_id";
            ddlcunt.DataBind();
            ddlcunt.Items.Insert(0, "--Select Country--");
        }


        city.Attributes.Add("onkeyup", "javascript:return insert_lat(event);");
        city_list.Attributes.Add("onclick", "javascript:return insert_data(id);");

        ddlstat.Attributes.Add("onkeyup", "javascript:return state(event);");
        state_list.Attributes.Add("onclick", "javascript:return insert_data(id);");
        submit.Attributes.Add("onclick", "javascript:return insert_lat(id);");
    }

    //[Ajax.AjaxMethod]
    //public DataSet state(string country)
    //{
    //    DataSet ds = new DataSet();
    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ds = cs.bindstate(country);
    //    }
      
    //    return ds;
    //}

    //[Ajax.AjaxMethod]
    //public DataSet citys(string country, string state)
    //{
    //    DataSet ds = new DataSet();
    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ds = cs.bindcity(country,state);
    //    }

    //    return ds;
    //}



    //[Ajax.AjaxMethod]
    //public DataSet latlng(string c)
    //{
    //    DataSet ds = new DataSet();
    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
    //        ds = country.bindlatlng(c);
    //    }

    //    return ds;
    //}

    [Ajax.AjaxMethod]
    public DataSet updatelatlng(string latf,string  lngf,string  conco,string stateco,string city)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.updatelatlng(latf, lngf, conco, stateco, city);
        }

        return ds;
    }

    
}
