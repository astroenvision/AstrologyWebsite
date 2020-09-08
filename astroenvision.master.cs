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
using System.Data.SqlClient;
using ASTROLOGY.classesoracle;
using System.Collections.Generic;
using System.Text;
using System.Web.Services;
using System.IO;
using System.Globalization;
using System.Threading;

public partial class astroenvision : System.Web.UI.MasterPage
{
    #region Declarartion
    blog obj_blog = new blog();
    common Com_Obj = new common();
    private static int IntCookieTimeOut { get { return int.Parse(ConfigurationManager.AppSettings["CookieTimeout"]); } }
    public string StateManagement = ConfigurationManager.AppSettings["StateManagement"].ToString();
    #endregion

    #region PageLoad
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ////string ipaddress1 = common.GetIpAddress();
            ////string ipaddress2 = common.GetUserIPAddress();
            ////string ipaddress3 = common.GetUserPublicIPAddress();
            ////string das = common.GenerateRandomNo(5);
            //BindUpdates();
        }
        if (StateManagement == "COOKIE")
        {
            if (ClsStateMangement.HasUserCartID(Context) != null)
            {
                string MySessionID = ClsStateMangement.GetMyCartID(Context).ToString();
                ViewState["MySessionID"] = MySessionID;
            }
            else
            {
                string intrandom = Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day) + Convert.ToString(DateTime.Now.Hour) + Convert.ToString(DateTime.Now.Minute) + Convert.ToString(DateTime.Now.Second) + Convert.ToString(DateTime.Now.Millisecond);
                ClsStateMangement.SetUserCartID(Context, intrandom, StateManagement);
            }
        }
        else
        {
            if (Session["MySessionID"] == null || Session["MySessionID"].ToString() == "")
            {
                string intrandom = Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day) + Convert.ToString(DateTime.Now.Hour) + Convert.ToString(DateTime.Now.Minute) + Convert.ToString(DateTime.Now.Second) + Convert.ToString(DateTime.Now.Millisecond);
                Session["MySessionID"] = intrandom;
            }
        }

        string PageURL = "";
        string GetCount = "";
        if (Session["CurrentCartValue"] != null)
        {
            if (Session["CurrentCartValue"].ToString() == "Product")
            {
                PageURL = "~/CheckOut.aspx";
                if (Session["MyCartProductCount"] != null)
                {
                    GetCount = Convert.ToString(Session["MyCartProductCount"]);
                }
            }
            else
            {
                PageURL = "~/CheckOutCart.html";
                if (Session["MyCartCount"] != null)
                {
                    GetCount = Convert.ToString(Session["MyCartCount"]);
                }
            }
        }
        else
        {
            PageURL = "~/CheckOutCart.html";
        }

        string Img = "~/img/cart_white.svg";

        if (GetCount != "")
        {
            cartsrvc.InnerHtml = "<a href=\"" + ResolveUrl(PageURL) + "\" class=\"cartrgt\"><img src =\"" + ResolveUrl(Img) + "\" alt=\"Cart Image\" /><span class=\"prdcont\" runat=\"server\" id=\"ctl00_cartid\">" + GetCount + "</span></a>";
        }
        else
        {
            cartsrvc.InnerHtml = "<a href=\"" + ResolveUrl(PageURL) + "\" class=\"cartrgt\"><img src =\"" + ResolveUrl(Img) + "\" alt=\"Cart Image\" /><span class=\"prdcont\" runat=\"server\" id=\"ctl00_cartid\">0</span></a>";
        }

        //if (Session["MyCartCount"] != null)
        //{
        //    string GetCount = Convert.ToString(Session["MyCartCount"]);
        //    if (GetCount != "")
        //    {
        //        if (Convert.ToInt32(GetCount) > 0)
        //        {
        //            cartid.InnerText = GetCount;
        //        }
        //    }
        //}
    }
    #endregion

    #region BindUpdates
    protected void BindUpdates()
    {
        try
        {
            StringBuilder str = new StringBuilder();
            DataSet ds = new DataSet();
            ds = obj_blog.GetBlogList("", "GET_ALL_BLOGS","","A");
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i <= 1; i++)
                {
                    string BlogSummary = ds.Tables[0].Rows[i]["SUMMARY"].ToString().Trim();
                    string BlogTitle = ds.Tables[0].Rows[i]["TITLE"].ToString().Trim();
                    string BlogId = ds.Tables[0].Rows[i]["BLOG_ID"].ToString().Trim();
                    string BlogUrl = Com_Obj.ReplaceQuotes(BlogTitle);
                    BlogUrl = Com_Obj.OptimizeURL(BlogUrl);
                    BlogUrl = "~/blog/" + BlogUrl + "/" + BlogId + ".html";
                    str.Append("<div class=\"col-sm-5 form-group\">");
                    str.Append("<div class=\"nwsupdt\">");
                    str.Append("<div class=\"nzupttl\"> " + ds.Tables[0].Rows[i]["TITLE"].ToString() + "</div>");
                    str.Append("<div class=\"nwzupdt-desc\"> " + BlogSummary.Substring(0, 150).Replace("<p>", "").Replace("</p>", "") + "</div>");
                    str.Append("<a class=\"rdmre\" href=\"" + ResolveUrl(BlogUrl) + "\">Read More...</a>");
                    str.Append("</div>");
                    str.Append("</div>");

                }
                divUpdates.InnerHtml = str.ToString();
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion

    #region LogOut
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        ClsStateMangement.ReleaseUserLogin(Context);
        Response.Redirect("~/index.html");
    }
    #endregion

    //protected void BindNatalCatgeory()
    //{
    //    DataSet ds = new DataSet();
    //    ds = Com_Obj.Get_Natal_cat("INR");
    //    string strHtmlNatalCat = "";
    //    if (ds.Tables[0].Rows.Count > 0)
    //    {
    //        for (int i = 1; i < ds.Tables[0].Rows.Count; i++)
    //        {
    //            strHtmlNatalCat += "<li><a href=\"" + ResolveUrl("~/natal-astrology/" + ds.Tables[0].Rows[i]["CATEGORY_URL"].ToString().TrimEnd('-').TrimStart('-') + ".html") + "\">" + ds.Tables[0].Rows[i]["CATEGORY_NAME"].ToString() + "</a></li>";

    //        }
    //        BindNatalCat.InnerHtml = strHtmlNatalCat.ToString();
    //    }
    //}

    protected void btnIndianCurrency_click(object sender , EventArgs e)
    {
        Session["CountryCode"] = "IN";
        string Domainurl = Request.Url.Scheme + System.Uri.SchemeDelimiter + Request.Url.Host;
        string url = Domainurl + HttpContext.Current.Request.RawUrl;
        string Query = HttpContext.Current.Request.Url.Query;
        if(Query!="")
        {
            url = url.Replace(Query, "").Trim();
        }
        Response.Redirect(url);
    }
    protected void btnUSDCurrency_click(object sender , EventArgs e)
    {
        Session["CountryCode"] = "USD";
        string Domainurl = Request.Url.Scheme + System.Uri.SchemeDelimiter + Request.Url.Host;
        string url = Domainurl + HttpContext.Current.Request.RawUrl;
        string Query = HttpContext.Current.Request.Url.Query;
        if (Query != "")
        {
            url = url.Replace(Query, "").Trim();
        }
        Response.Redirect(url);
    }
}
