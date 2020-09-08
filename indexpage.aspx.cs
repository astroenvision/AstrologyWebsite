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
public partial class indexpage : System.Web.UI.Page
{
    #region Declarartions
    public string WEBSITEDomain = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    public string StateManagement = ConfigurationManager.AppSettings["StateManagement"].ToString();
    ASTROLOGY.classesoracle.myaccount obj_mc = new ASTROLOGY.classesoracle.myaccount();
    common obj_cm = new common();
    subscription obj_subs = new subscription();
    DataSet ds = new DataSet();
    string InnerStr = "", InnerStr2, strbottommenuhtml = "";
    string mail = "astrology", Catclass = "";
    string strHtml = "";
    public string GetCurrencyType = "";
    #endregion

    #region PageLoad
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CountryCode"] != null)
        {
            GetCurrencyType = Session["CountryCode"].ToString();
        }
        if (StateManagement == "COOKIE")
        {
            if (ClsStateMangement.HasUserCartID(Context) != null && ClsStateMangement.HasUserCartID(Context)!="")
            {
                string MySessionID = ClsStateMangement.GetMyCartID(Context).ToString();
                ViewState["MySessionID"] = MySessionID;
            }
            else
            {
                string intrandom = Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day) + Convert.ToString(DateTime.Now.Hour) + Convert.ToString(DateTime.Now.Minute) + Convert.ToString(DateTime.Now.Second) + Convert.ToString(DateTime.Now.Millisecond);
                ClsStateMangement.SetUserCartID(Context, intrandom, StateManagement);
                string MySessionID = ClsStateMangement.GetMyCartID(Context).ToString();
                ViewState["MySessionID"] = MySessionID;
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
        if (!IsPostBack)
        {
            //bindbottommenubar();
            getcomments();
            gettestimonials();
            BindNatalCategories();

            //Session["CountryCode"] = GetCountryCode();
            string url = Request.Url.Scheme + System.Uri.SchemeDelimiter + Request.Url.Host;
            HtmlLink tag = new HtmlLink();
            tag.Attributes.Add("rel", "canonical");
            tag.Href = url;
            //Header.Controls.Add(tag);  // This Line is used without Master Page
            Master.FindControl("head").Controls.Add(tag); // This Line is used with Master Page
        }
    }
    #endregion

    #region Bind Natal Categories
    public void BindNatalCategories()
    {
        string strHtmlNatalCat = "";
        string CatColor = "#f25e0a";
        DataSet ds = obj_cm.Get_Natal_cat(GetCurrencyType);
        if (ds.Tables[0].Rows.Count > 0)
        {
            Session["CurrentCartValue"] = "Category";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string h_desc = "", short_desc = "", CatImg = "", Cat_Actual_Price = "", Cat_Discount, Cat_Payable_Price = "";
                string h_code = ds.Tables[0].Rows[i]["CATEGORY_ID"].ToString();
                string h_name = ds.Tables[0].Rows[i]["CATEGORY_NAME"].ToString();
                string IsPaid = ds.Tables[0].Rows[i]["IS_PAID"].ToString();
                string IsAddToCart = ds.Tables[0].Rows[i]["IS_ADDTOCART"].ToString();
                //string GetCountryCodde = GetCountryCode();

                CatImg = ds.Tables[0].Rows[i]["CATEGORY_IMAGE"].ToString();
                h_desc = ds.Tables[0].Rows[i]["CATEGORY_DESC"].ToString();
                h_desc = h_desc.Replace("'", "&#39;").Replace("<div>", "<p>").Replace("</div>", "</p>"); ;

                Cat_Actual_Price = ds.Tables[0].Rows[i]["ACTUAL_PRICE"].ToString();
                Cat_Discount = ds.Tables[0].Rows[i]["DISCOUNT"].ToString();
                Cat_Payable_Price = ds.Tables[0].Rows[i]["PAYABLE_PRICE"].ToString();
                CatColor = ds.Tables[0].Rows[i]["CATEGORY_COLOR"].ToString();
                if (CatColor == "")
                {
                    CatColor = "#f25e0a";
                }
                string IsBlink = ds.Tables[0].Rows[i]["IS_BLINK"].ToString();
                if (IsBlink == "Y")
                {
                    Catclass = "title blink";
                }
                else
                {
                    Catclass = "title";
                }

                string h_name_url = obj_cm.ReplaceQuotes(h_name);
                h_name_url = obj_cm.OptimizeURL(h_name_url);
                //string finalurl = "category/" + h_name_url + "/natal/" + h_code + "-" + Session["MySessionID"].ToString() + ".html";
                //strHtml += "<a class='readmorecss' href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url + "/" + CatId + "-" + NewsId + ".html") + "\">read more..</a>";
                int priority = Convert.ToInt32(ds.Tables[0].Rows[i]["PRIORITY"].ToString());
                strHtmlNatalCat += "<div class=\"col-xl-3 col-lg-4 col-sm-6 wow fadeInUp\">";
                strHtmlNatalCat += "<div class=\"service-col\">";
                if (CatImg != "")
                {
                    strHtmlNatalCat += "<div class=\"img\">";
                    //Comment on 17-08-2020//strHtmlNatalCat += "<a href=\"" + ResolveUrl("~/natal-astrology/" + ds.Tables[0].Rows[i]["CATEGORY_URL"].ToString() + ".html") + "\">";
                    strHtmlNatalCat += "<a href=\"" + ResolveUrl("~/" + ds.Tables[0].Rows[i]["URL"].ToString() + ".html") + "\">";
                    strHtmlNatalCat += "<img src=\"img/" + CatImg + "\" alt=\"" + h_name + "\" title=\"" + h_name + "\" class=\"img-fluid\">";
                    strHtmlNatalCat += "</a>";
                    strHtmlNatalCat += "</div>";
                }
                strHtmlNatalCat += "<div class=\"bdy\">";
                //strHtmlNatalCat += "<h2 class=\"title\"><a href=\"javascript:;\" data-toggle=\"modal\" data-target=\"#readMore" + h_code + "\">" + h_name + "</a></h2>";

                //Comment on 17-08-2020//strHtmlNatalCat += "<h1 class=\"" + Catclass + "\"><a style=\"color: " + CatColor + "\" href=\"" + ResolveUrl("~/natal-astrology/" + ds.Tables[0].Rows[i]["CATEGORY_URL"].ToString() + ".html") + "\">" + h_name + "</a></h1>";
                strHtmlNatalCat += "<h1 class=\"" + Catclass + "\"><a style=\"color: " + CatColor + "\" href=\"" + ResolveUrl("~/" + ds.Tables[0].Rows[i]["URL"].ToString() + ".html") + "\">" + h_name + "</a></h1>";

                strHtmlNatalCat += "<div class=\"prc-sec d-flex justify-content-between align-items-center\">";
                strHtmlNatalCat += "<div class=\"prce\">";
                if (GetCurrencyType != "USD")
                {
                    strHtmlNatalCat += "<span style=\"color: " + CatColor + "\" class=\"price-new\">₹" + Cat_Payable_Price + "</span>";
                    if (Cat_Discount != "" && Cat_Discount != "0" && Cat_Discount != "NULL")
                    {
                        strHtmlNatalCat += "<span class=\"price-old\">₹" + Cat_Actual_Price + "</span>";
                    }
                }
                else
                {
                    strHtmlNatalCat += "<span style=\"color: " + CatColor + "\" class=\"price-new\">$" + Cat_Payable_Price + "</span>";
                    if (Cat_Discount != "" && Cat_Discount != "0" && Cat_Discount != "NULL")
                    {
                        strHtmlNatalCat += "<span class=\"price-old\">$" + Cat_Actual_Price + "</span>";
                    }
                }
                strHtmlNatalCat += "</div>";
                if (Cat_Discount != "" && Cat_Discount != "0" && Cat_Discount != "NULL")
                {
                    strHtmlNatalCat += "<span class=\"disc-bdge\">" + Cat_Discount + "%</span>";
                }
                strHtmlNatalCat += "</div>";

                short_desc = ds.Tables[0].Rows[i]["CATEGORY_SYNOPSIS"].ToString();
                //firstwords.Append("...");

                strHtmlNatalCat += "<p>" + short_desc.ToString() + "</p>";
                //strHtmlNatalCat += "<div class=\"rdmr\"><a class='effect-shine' href=\"javascript:;\" data-toggle=\"modal\" data-target=\"#readMore" + h_code + "\">Read More...</a></div>";
                //Comment on 17-08-2020//strHtmlNatalCat += "<div class=\"rdmr\"><a style=\"color: " + CatColor + "\" class='effect-shine' href=\"" + ResolveUrl("~/natal-astrology/" + ds.Tables[0].Rows[i]["CATEGORY_URL"].ToString() + ".html") + "\">Read More...</a></div>";
                if (IsPaid == "Y")
                {
                    strHtmlNatalCat += "<div class=\"rdmr\"><a style=\"color: " + CatColor + "\" class='effect-shine' href=\"" + ResolveUrl("~/" + ds.Tables[0].Rows[i]["URL"].ToString() + ".html") + "\">Read More...</a></div>";
                }
                
                if (IsPaid == "Y")
                {
                    if (h_code == "28")
                    {
                        //strHtmlNatalCat += "&nbsp;<a href=\"" + ResolveUrl("~/compatibilitymatching.html") + "\" class=\"kwm-btn\">Buy Report</a>";
                        strHtmlNatalCat += "&nbsp;<a href=\"javascript:BuyReport('" + h_name + "'," + h_code + ",'NATAL' , '');\" class=\"kwm-btn\"><i class=\"fa fa-shopping-cart mr-1\"></i>Buy Report</a>";
                    }
                    else
                    {
                        if (IsAddToCart == "Y")
                        {
                            strHtmlNatalCat += "&nbsp;<a href=\"javascript:AddToCart('" + h_name + "'," + h_code + ",'NATAL' , '');\" class=\"kwm-btn\"><i class=\"fa fa-shopping-cart mr-1\"></i>Add to Cart</a>";
                        }
                        else
                        {
                            strHtmlNatalCat += "&nbsp;<a href=\"" + ResolveUrl("~/" + ds.Tables[0].Rows[i]["URL"].ToString() + ".html") + "\" class=\"kwm-btn\"><i class=\"fa fa-shopping-cart mr-1\"></i>Add to Cart</a>";
                        }
                    }
                }
                else
                {
                    strHtmlNatalCat += "&nbsp;<a href=\"" + ResolveUrl("~/" + ds.Tables[0].Rows[i]["URL"].ToString() + ".html") + "\" class=\"kwm-btn\"><i class=\"fa fa-file mr-1\"></i>Get Report</a>";
                }
                
                strHtmlNatalCat += "</div>";
                strHtmlNatalCat += "</div>";
                //Code Start For Know More 
                //strHtmlNatalCat += "<div class=\"modal fade\" id=\"readMore" + h_code + "\">";
                //strHtmlNatalCat += "<div class=\"modal-dialog modal-lg modal-dialog-centered\">";
                //strHtmlNatalCat += "<div class=\"modal-content\">";
                //strHtmlNatalCat += "<div class=\"modal-header\">";
                //strHtmlNatalCat += "<h4 class=\"modal-title\">" + h_name + "</h4>";
                //strHtmlNatalCat += "<button type=\"button\" class=\"close\" data-dismiss=\"modal\"><i class=\"ion-ios-close-outline text-bold\"></i></button>";
                //strHtmlNatalCat += "</div>";
                //strHtmlNatalCat += "<div class=\"modal-body\">" + h_desc + "</div>";
                //strHtmlNatalCat += "</div>";
                //strHtmlNatalCat += "</div>";
                //strHtmlNatalCat += "</div>";
                //Code End For Know More 
                strHtmlNatalCat += "</div>";
            }
            natalcategorydiv.InnerHtml = strHtmlNatalCat;
        }
        ds.Dispose();
    }
    #endregion

    #region Get Comments
    public void getcomments()
    {
        ds = obj_mc.GetArticles("3", "BOTH", "0", "");
        if (ds.Tables[0].Rows.Count != 0)
        {
            InnerStr = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string NewsId = ds.Tables[0].Rows[i]["NEWS_ID"].ToString();
                string CatId = ds.Tables[0].Rows[i]["CATID"].ToString();
                string Headline = ds.Tables[0].Rows[i]["HEADLINE"].ToString();
                Headline = Regex.Replace(Headline, @"<[^>]+>|&nbsp;", "").Trim();
                Headline = Regex.Replace(Headline, @"\s{2,}", " ");
                string headline_url = obj_cm.ReplaceQuotes(Headline);
                headline_url = obj_cm.OptimizeURL(headline_url);
                string synopsis = ds.Tables[0].Rows[i]["SYNOPSIS"].ToString();
                //synopsis = Regex.Replace(synopsis, @"<[^>]+>|&nbsp;", "").Trim();
                //synopsis = Regex.Replace(synopsis, @"\s{2,}", " ");
                string authorimg = ds.Tables[0].Rows[i]["AUTHOR_IMG"].ToString();
                string author = ds.Tables[0].Rows[i]["AUTHOR"].ToString();
                string catname = ds.Tables[2].Rows[0]["CAT_NAME"].ToString();
                string caturl = obj_cm.ReplaceQuotes(catname);
                caturl = obj_cm.OptimizeURL(caturl);
                InnerStr += "<div class=\"expert-item\">";
                if (authorimg != "")
                {
                    //InnerStr += "<a href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url.TrimStart('-').TrimEnd('-') + "/" + CatId + "-" + NewsId + ".html") + "\">";
                    InnerStr += "<a rel=\"nofollow\" title='" + author + "' href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url.TrimStart('-').TrimEnd('-') + ".html") + "\">";
                    InnerStr += "<img src=\"" + ResolveUrl("~/Image/" + authorimg + "") + "\" alt=\"" + author + "\" title='" + author + "' class=\"expert-img\" />";
                    InnerStr += "</a>";
                }
                InnerStr += "<p><img src=\"img/quote-sign-left.png\" class=\"quote-sign-left\" alt=\"left quote\" title=\"left quote\">";
                InnerStr += synopsis.Replace("<p>", "").Replace("</p>", "");
                //InnerStr += "<a href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url.TrimStart('-').TrimEnd('-') + "/" + CatId + "-" + NewsId + ".html") + "\">&nbsp;Read More..</a>";
                InnerStr += "<a rel=\"nofollow\" title='" + author + "' href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url.TrimStart('-').TrimEnd('-') + ".html") + "\">&nbsp;Read More..</a>";
                InnerStr += "<img src=\"img/quote-sign-right.png\" class=\"quote-sign-right\" alt=\"right quote\" title=\"right quote\" ></p>";
                InnerStr += "<h3>" + author + "</h3>";
                InnerStr += "<div class=\"cmddesg\">" + Headline + "</div>";
                InnerStr += "</div>";
            }
            expertid.InnerHtml = InnerStr;
        }
        ds.Dispose();
    }

    #endregion

    #region Get Testimonials
    public void gettestimonials()
    {
        ds = obj_mc.GetArticles("4", "BOTH", "0", "");
        if (ds.Tables[0].Rows.Count != 0)
        {
            InnerStr2 = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string NewsId = ds.Tables[0].Rows[i]["NEWS_ID"].ToString();
                string CatId = ds.Tables[0].Rows[i]["CATID"].ToString();
                string Headline = ds.Tables[0].Rows[i]["HEADLINE"].ToString();
                Headline = Regex.Replace(Headline, @"<[^>]+>|&nbsp;", "").Trim();
                Headline = Regex.Replace(Headline, @"\s{2,}", " ");
                string headline_url = ds.Tables[0].Rows[i]["URL"].ToString();
                headline_url = obj_cm.ReplaceQuotes(headline_url);
                headline_url = obj_cm.OptimizeURL(headline_url);
                string synopsis = ds.Tables[0].Rows[i]["SYNOPSIS"].ToString();
                //synopsis = Regex.Replace(synopsis, @"<[^>]+>|&nbsp;", "").Trim();
                //synopsis = Regex.Replace(synopsis, @"\s{2,}", " ");
                string authorimg = ds.Tables[0].Rows[i]["AUTHOR_IMG"].ToString();
                string author = ds.Tables[0].Rows[i]["AUTHOR"].ToString();
                string catname = ds.Tables[2].Rows[0]["CAT_NAME"].ToString();
                string caturl = obj_cm.ReplaceQuotes(catname);
                caturl = obj_cm.OptimizeURL(caturl);
                InnerStr2 += "<div class=\"testimonial-item\">";
                if (authorimg != "")
                {
                    //InnerStr2 += "<a href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url + "/" + CatId + "-" + NewsId + ".html") + "\">";
                    InnerStr2 += "<a rel=\"nofollow\" title='" + author + "' href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url.TrimStart('-').TrimEnd('-') + ".html") + "\">";
                    InnerStr2 += "<img class=\"testimonial-img\" src=\"" + ResolveUrl("~/Image/" + authorimg + "") + "\" alt=\"" + author + "\" title='" + author + "' />";
                    InnerStr2 += "</a>";
                }
                else
                {
                    //InnerStr2 += "<a href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url + "/" + CatId + "-" + NewsId + ".html") + "\">";
                    InnerStr2 += "<a title='" + author + "' href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url.TrimStart('-').TrimEnd('-') + ".html") + "\">";
                    InnerStr2 += "<img class=\"testimonial-img\" src=\"" + ResolveUrl("~/img/Default.jpg") + "\" alt=\"" + author + "\" title='" + author + "' />";
                    InnerStr2 += "</a>";
                }
                InnerStr2 += "<p>";
                InnerStr2 += "<img src=\"img/quote-sign-left.png\" class=\"quote-sign-left\" alt=\"left quote\" title=\"left quote\" />";
                InnerStr2 += synopsis.Replace("<p>", "").Replace("</p>", "");
                //InnerStr2 += "<a href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url + "/" + CatId + "-" + NewsId + ".html") + "\">&nbsp;Read More..</a>";
                InnerStr2 += "<a rel=\"nofollow\" title='" + author + "' href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url.TrimStart('-').TrimEnd('-') + ".html") + "\">&nbsp;Read More..</a>";
                InnerStr2 += "<img src=\"img/quote-sign-right.png\" class=\"quote-sign-right\" alt=\"right quote\" title=\"right quote\" />";
                InnerStr2 += "</p>";
                InnerStr2 += "<h3>" + author + "</h3>";
                InnerStr2 += "</div>";
            }
            testimonialid.InnerHtml = InnerStr2;
        }
        ds.Dispose();
    }
    #endregion

    #region Get Country Code
    public string GetCountryCode()
    {
        string VisitorsIPAddr = string.Empty;
        if (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
        {
            VisitorsIPAddr = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
        }
        else if (HttpContext.Current.Request.UserHostAddress.Length != 0)
        {
            VisitorsIPAddr = HttpContext.Current.Request.UserHostAddress;
        }

        long w, x, y, z, IPNumber;
        //String hostName = System.Net.Dns.GetHostName();
        //IPHostEntry localIpAddresses = Dns.GetHostEntry(hostName);
        //string publicIP = localIpAddresses.AddressList[0].ToString();
        string publicIP = VisitorsIPAddr;
        string CountryCode = "IN";
        String[] splitIP = publicIP.Split('.');
        if (splitIP.Length > 3)
        {
            w = Convert.ToInt32(splitIP[0]);
            x = Convert.ToInt32(splitIP[1]);
            y = Convert.ToInt32(splitIP[2]);
            z = Convert.ToInt32(splitIP[3]);
            IPNumber = (16777216 * w) + (65536 * x) + (256 * y) + (z);
            DataSet dscd = new DataSet();
            dscd = obj_subs.AstGetCommon(IPNumber.ToString(), "", "", "GETCOUNTRYCODE");
            if (dscd.Tables[0].Rows.Count > 0)
            {
                CountryCode = dscd.Tables[0].Rows[0]["COUNTRY_CODE"].ToString();
                Session["CountryCode"] = CountryCode;
            }
        }
        return CountryCode;
    }
    #endregion
}