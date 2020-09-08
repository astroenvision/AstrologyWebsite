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

public partial class auto_paypal : System.Web.UI.Page
{
    static string WEBSITEDomain = ConfigurationSettings.AppSettings["WEBSITEDomain"].ToString();
    public string Location = "";
    public string CurrencyCode = "";
    public string Amount = "";
    public string business = "";
    public string websiteUrl = "";
    public string memberid = "";
    public string uid = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(auto_paypal));

        uid = Request.QueryString["uid"].ToString();

        string price = Request.QueryString["amount"].ToString();
        string catid = Request.QueryString["catid"].ToString();
        string name = Request.QueryString["username"].ToString();
        string emailid = Request.QueryString["emailid"].ToString();
        string city = Request.QueryString["city"].ToString();
        string state = Request.QueryString["state"].ToString();
        string country = Request.QueryString["country"].ToString();
        string Address = Request.QueryString["address"].ToString();
        string phone = Request.QueryString["phone"].ToString();
        string Zipcode = Request.QueryString["zipcode"].ToString();

        memberid = Request.QueryString["member"].ToString();
        Amount = price;
        //CurrencyCode = "USD";
        CurrencyCode = Request.QueryString["currency_type"].ToString();
        Location = "Other";
        business = "sanjaya@ezinemart.com";
        websiteUrl = WEBSITEDomain;
    }
}
