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

public partial class book_predictive : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(book_predictive));

        hiddendateformat.Value = "dd/mm/yyyy";
        if (!Page.IsPostBack)
        {
           // bindbook();
           
            ra.Attributes.Add("onclick", "javascript:return click_on_replace();");
            s1.Attributes.Add("onclick", "javascript:return bookpredictive();");
            s2.Attributes.Add("onclick", "javascript:return searchid();");
            bokcate.Attributes.Add("onchange", "javascript:return category();");
            f1.Attributes.Add("onchange", "javascript:return filter();");
            datesearch.Attributes.Add("onclick", "javascript:return datesearchfn();");
            sbp.Attributes.Add("onclick", "javascript:return sbp1();");
           
           

        }
    }


    [Ajax.AjaxMethod]
    public DataSet bindbook(string fil)
    {
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.bookbind(fil);

        }
        return ds;
    }
    

   


    [Ajax.AjaxMethod]
    public DataSet getbookname(string book, string fil)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.bindbooknames(book, fil);
        }
        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet searchp(string bookname,string fil)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.bookpredictive(bookname,fil);
        }
        return ds;

    }
    [Ajax.AjaxMethod]
    public DataSet searchpa(string bookname, string pageno)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.bookpredictivepage(bookname, pageno);
        }
        return ds;
    }
    

    [Ajax.AjaxMethod]
    public DataSet update_gridall(string description, string description1, string descclob, string key, string key1, string explain, string fil, string book, string uniqueid)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.update_grid(description, description1, descclob, key, key1, explain, fil, book, uniqueid);
        }
        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet chk_book_predictive(string book, string desc, string key, string vrf)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.chk_book_predictive(book, desc, key, vrf);
        }
        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet delete_book_predictive(string description, string key, string book, string descclob, string explain)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.delete_book_predictive(description, key, book, descclob, explain);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet club_book_predictive(string descr, string kkey, string book)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.club_book_predictive(descr, kkey, book);
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
    public DataSet starratingpriority(string priority,string key,string book,string despription)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.starratingprioritydata(priority, key, book, despription);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet movedatainform(string description,string key,string book,string descclob,string explain,string form,string unique,string check,string page)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.movedatainformintable(description, key, book, descclob, explain, form, unique, check, page);
        }
        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet findreplace(string find, string replace, string book)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.bookfindandreplace(find, replace, book);
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
