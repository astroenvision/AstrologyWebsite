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
using System.Data.SqlClient;
using ASTROLOGY.classesoracle;
using System.Net;
using System.IO;
public partial class deepak : System.Web.UI.Page
{
    common cs_obj = new common();
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    protected void Page_Load(object sender, EventArgs e)
    {

        //string VisitorsIPAddr = string.Empty;
        //if (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
        //{
        //    VisitorsIPAddr = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
        //}
        //else if (HttpContext.Current.Request.UserHostAddress.Length != 0)
        //{
        //    VisitorsIPAddr = HttpContext.Current.Request.UserHostAddress;
        //}
        //H6.InnerHtml = "Your IP is: " + VisitorsIPAddr;

        //long w, x, y, z, IPNumber;
        //String hostName = System.Net.Dns.GetHostName();
        //H0.InnerHtml = "Host Name-" + hostName;
        //IPHostEntry localIpAddresses = Dns.GetHostEntry(hostName);
        //H1.InnerHtml = "Local IP Addresses-" + localIpAddresses;
        //string publicIP = localIpAddresses.AddressList[0].ToString();
        //H2.InnerHtml = "public IP-" + publicIP ;
        //string CountryCode = "IN";
        //publicIP = VisitorsIPAddr;
        //String[] splitIP = publicIP.Split('.');
        //if (splitIP.Length > 3)
        //{
        //    w = Convert.ToInt32(splitIP[0]);
        //    x = Convert.ToInt32(splitIP[1]);
        //    y = Convert.ToInt32(splitIP[2]);
        //    z = Convert.ToInt32(splitIP[3]);
        //    IPNumber = (16777216 * w) + (65536 * x) + (256 * y) + (z);
        //    H4.InnerHtml = "IPNumber-" + IPNumber;
        //    DataSet dscd = new DataSet();
        //    dscd = obj_subs.AstGetCommon(IPNumber.ToString(), "", "", "GETCOUNTRYCODE");
        //    if (dscd.Tables[0].Rows.Count > 0)
        //    {
        //        CountryCode = dscd.Tables[0].Rows[0]["COUNTRY_CODE"].ToString();
        //    }
        //    H5.InnerHtml = "CountryCode-" + CountryCode;
        //}
    }
}