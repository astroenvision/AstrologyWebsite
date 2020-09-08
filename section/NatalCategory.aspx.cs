using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class section_NatalCategory : System.Web.UI.Page
{
    #region Declarartions
    public string WEBSITEDomain = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    public string StateManagement = ConfigurationManager.AppSettings["StateManagement"].ToString();
    ASTROLOGY.classesoracle.myaccount obj_mc = new ASTROLOGY.classesoracle.myaccount();
    common obj_cm = new common();
    subscription obj_subs = new subscription();
    DataSet ds = new DataSet();
    string InnerStr = "", InnerStr2, strbottommenuhtml = "";
    string mail = "astrology", Catclass="";
    string strHtmlNatalCat = "", strHtml="";
    string CatId = "", ArticleID = "";
    public string GetCurrencyType="";
    DataSet dsmeta = new DataSet();
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
            if (ClsStateMangement.HasUserCartID(Context) != null)
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
            BindNatalCategories();
            //Session["CountryCode"] = GetCountryCode();
        }
    }
    #endregion

    #region Bind Natal Categories
    public void BindNatalCategories()
    {
        if (Request.QueryString["catid"] != null && Request.QueryString["articleid"].ToString() != null)
        {
            CatId = Request.QueryString["catid"].ToString().Trim();
            ArticleID = Request.QueryString["articleid"].ToString().Trim();
            string page = Request.Url.Segments[Request.Url.Segments.Length - 1];

            dsmeta = obj_mc.GetArticles(CatId, "BOTH", ArticleID,"");
            if (dsmeta.Tables[1].Rows.Count != 0)
            {
                string headlineval = dsmeta.Tables[1].Rows[0]["HEADLINE"].ToString();
                headlineval = headlineval.Replace(":", "");
                string titleval = dsmeta.Tables[1].Rows[0]["TITLE"].ToString();
                string keywordsval = dsmeta.Tables[1].Rows[0]["META_KEYWORDS"].ToString();
                string descval = dsmeta.Tables[1].Rows[0]["META_DESCRIPTION"].ToString();
                string article_dtls = dsmeta.Tables[1].Rows[0]["FULLSTORY"].ToString();
                string Cat_name = dsmeta.Tables[2].Rows[0]["CAT_NAME"].ToString();

                //strHtml += "<h1 class='fullarticle_catname'>" + Cat_name + "</h1>";
                strHtml += "<h1 class='fullarticle_catname'>Astro Reports</h1>";
                if (headlineval != "")
                {
                    strHtml += "<h2 class='fullarticle_catname_h1' style='padding:0% 0% 0.5% 0%; width: 100%'>";
                    strHtml += "<a title='Astro Envision' href=\"" + ResolveUrl("~") + "\">Astro Envision</a> > <a title='Astro Reports' href=\"" + ResolveUrl("~/astro-reports.html") + "\">Astro Reports</a>";
                    strHtml += "</h2>";
                }
                strHtml += "<div style='clear:both;'></div>";
                strHtml += article_dtls;
                fullarticle_id.InnerHtml = strHtml;

                //Add Page Title
                if (titleval != "")
                {
                    if (titleval != "")
                    {
                        Page.Title = titleval + " | Astro Envision";
                    }
                    else
                    {
                        Page.Title = headlineval + " | " + titleval + " | Astro Envision";
                    }
                }
                if (keywordsval != "")
                {
                    //Add Keywords Meta Tag
                    HtmlMeta keywords = new HtmlMeta();
                    keywords.HttpEquiv = "keywords";
                    keywords.Name = "keywords";
                    keywords.Content = keywordsval;
                    Master.FindControl("head").Controls.Add(keywords);
                }
                if (descval != "")
                {
                    //Add Description Meta Tag
                    HtmlMeta description = new HtmlMeta();
                    description.HttpEquiv = "description";
                    description.Name = "description";
                    description.Content = descval;
                    Master.FindControl("head").Controls.Add(description);
                }
                string Domainurl = Request.Url.Scheme + System.Uri.SchemeDelimiter + Request.Url.Host;
                string url = Domainurl + HttpContext.Current.Request.RawUrl;
                HtmlLink tag = new HtmlLink();
                tag.Attributes.Add("rel", "canonical");
                tag.Href = url;
                //Header.Controls.Add(tag);  // This Line is used without Master Page
                Master.FindControl("head").Controls.Add(tag); // This Line is used with Master Page
            }
            dsmeta.Dispose();
        }

        //DataSet ds = obj_cm.Get_Natal_cat(GetCurrencyType);
        //if (ds.Tables[0].Rows.Count > 0)
        //{
        //    string CatColor = "#f25e0a";
        //    strHtmlNatalCat += "<h1 class='fullarticle_catname'>&nbsp;Astro Reports</h1>";
        //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //    {
        //        string h_desc = "", short_desc = "", CatImg = "", Cat_Actual_Price = "", Cat_Discount, Cat_Payable_Price = "";
        //        string h_code = ds.Tables[0].Rows[i]["CATEGORY_ID"].ToString();
        //        string h_name = ds.Tables[0].Rows[i]["CATEGORY_NAME"].ToString();

        //        CatImg = ds.Tables[0].Rows[i]["CATEGORY_IMAGE"].ToString();
        //        h_desc = ds.Tables[0].Rows[i]["CATEGORY_DESC"].ToString();
        //        h_desc = h_desc.Replace("'", "&#39;").Replace("<div>", "<p>").Replace("</div>", "</p>"); ;
        //        Cat_Actual_Price = ds.Tables[0].Rows[i]["ACTUAL_PRICE"].ToString();
        //        Cat_Discount = ds.Tables[0].Rows[i]["DISCOUNT"].ToString();
        //        Cat_Payable_Price = ds.Tables[0].Rows[i]["PAYABLE_PRICE"].ToString();
        //        CatColor = ds.Tables[0].Rows[i]["CATEGORY_COLOR"].ToString();
        //        if (CatColor == "")
        //        {
        //            CatColor = "#f25e0a";
        //        }
        //        string IsBlink = ds.Tables[0].Rows[i]["IS_BLINK"].ToString();
        //        if (IsBlink == "Y")
        //        {
        //            Catclass = "title blink";
        //        }
        //        else
        //        {
        //            Catclass = "title";
        //        }

        //        string h_name_url = obj_cm.ReplaceQuotes(h_name);
        //        h_name_url = obj_cm.OptimizeURL(h_name_url);
        //        string finalurl = "category/" + h_name_url + "/natal/" + h_code + "-" + Session["MySessionID"].ToString() + ".html";
        //        //strHtml += "<a class='readmorecss' href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url + "/" + CatId + "-" + NewsId + ".html") + "\">read more..</a>";
        //        int priority = Convert.ToInt32(ds.Tables[0].Rows[i]["PRIORITY"].ToString());

        //        strHtmlNatalCat += "<div class=\"col-xl-3 col-lg-4 col-sm-6 wow fadeInUp\">";
        //        strHtmlNatalCat += "<div class=\"service-col\">";
        //        if (CatImg != "")
        //        {
        //            strHtmlNatalCat += "<div class=\"img\">";
        //            strHtmlNatalCat += "<a href=\"" + ResolveUrl("~/natal-astrology/" + ds.Tables[0].Rows[i]["CATEGORY_URL"].ToString() + ".html") + "\">";
        //            strHtmlNatalCat += "<img src=\"" + ResolveUrl("~/img/" + CatImg + "") + "\" alt=\"" + h_name + "\" title=\"" + h_name + "\" class=\"img-fluid\">";
        //            strHtmlNatalCat += "</a>";
        //            strHtmlNatalCat += "</div>";
        //        }
        //        strHtmlNatalCat += "<div class=\"bdy\">";
        //        //strHtmlNatalCat += "<h2 class=\"title\"><a href=\"javascript:;\" data-toggle=\"modal\" data-target=\"#readMore" + h_code + "\">" + h_name + "</a></h2>";

        //        strHtmlNatalCat += "<h1 class=\"" + Catclass + "\"><a style=\"color: " + CatColor + "\" href=\"" + ResolveUrl("~/natal-astrology/" + ds.Tables[0].Rows[i]["CATEGORY_URL"].ToString() + ".html") + "\">" + h_name + "</a></h1>";

        //        strHtmlNatalCat += "<div class=\"prc-sec d-flex justify-content-between align-items-center\">";
        //        strHtmlNatalCat += "<div class=\"prce\">";
        //        if (GetCurrencyType != "USD")
        //        {
        //            strHtmlNatalCat += "<span style=\"color: " + CatColor + "\" class=\"price-new\">₹" + Cat_Payable_Price + "</span>";
        //            if (Cat_Discount != "" && Cat_Discount != "0" && Cat_Discount != "NULL")
        //            {
        //                strHtmlNatalCat += "<span class=\"price-old\">₹" + Cat_Actual_Price + "</span>";
        //            }
        //        }
        //        else
        //        {
        //            strHtmlNatalCat += "<span style=\"color: " + CatColor + "\" class=\"price-new\">$" + Cat_Payable_Price + "</span>";
        //            if (Cat_Discount != "" && Cat_Discount != "0" && Cat_Discount != "NULL")
        //            {
        //                strHtmlNatalCat += "<span class=\"price-old\">$" + Cat_Actual_Price + "</span>";
        //            }
        //        }
        //        strHtmlNatalCat += "</div>";
        //        if (Cat_Discount != "" && Cat_Discount != "0" && Cat_Discount != "NULL")
        //        {
        //            strHtmlNatalCat += "<span class=\"disc-bdge\">" + Cat_Discount + "%</span>";
        //        }
        //        strHtmlNatalCat += "</div>";

        //        short_desc = ds.Tables[0].Rows[i]["CATEGORY_SYNOPSIS"].ToString();

        //        strHtmlNatalCat += "<p>" + short_desc.ToString() + "</p>";
        //        //strHtmlNatalCat += "<div class=\"rdmr\"><a class='effect-shine' href=\"javascript:;\" data-toggle=\"modal\" data-target=\"#readMore" + h_code + "\">Read More...</a></div>";
        //        strHtmlNatalCat += "<div class=\"rdmr\"><a style=\"color: " + CatColor + "\" class='effect-shine' href=\"" + ResolveUrl("~/natal-astrology/" + ds.Tables[0].Rows[i]["CATEGORY_URL"].ToString() + ".html") + "\">Read More...</a></div>";

        //        if (h_code == "28")
        //        {
        //            //strHtmlNatalCat += "&nbsp;<a href=\"" + ResolveUrl("~/compatibilitymatching.html") + "\" class=\"kwm-btn\">Buy Report</a>";
        //            strHtmlNatalCat += "&nbsp;<a href=\"javascript:BuyReport('" + h_name + "'," + h_code + ",'NATAL' , '');\" class=\"kwm-btn\"><i class=\"fa fa-shopping-cart mr-1\"></i>Buy Report</a>";
        //        }
        //        else
        //        {
        //            strHtmlNatalCat += "&nbsp;<a href=\"javascript:AddToCart('" + h_name + "'," + h_code + ",'NATAL' , '');\" class=\"kwm-btn\"><i class=\"fa fa-shopping-cart mr-1\"></i>Add to Cart</a>";
        //        }
        //        strHtmlNatalCat += "</div>";
        //        strHtmlNatalCat += "</div>";
        //        //Code Start For Know More 
        //        //strHtmlNatalCat += "<div class=\"modal fade\" id=\"readMore" + h_code + "\">";
        //        //strHtmlNatalCat += "<div class=\"modal-dialog modal-lg modal-dialog-centered\">";
        //        //strHtmlNatalCat += "<div class=\"modal-content\">";
        //        //strHtmlNatalCat += "<div class=\"modal-header\">";
        //        //strHtmlNatalCat += "<h4 class=\"modal-title\">" + h_name + "</h4>";
        //        //strHtmlNatalCat += "<button type=\"button\" class=\"close\" data-dismiss=\"modal\"><i class=\"ion-ios-close-outline text-bold\"></i></button>";
        //        //strHtmlNatalCat += "</div>";
        //        //strHtmlNatalCat += "<div class=\"modal-body\">" + h_desc + "</div>";
        //        //strHtmlNatalCat += "</div>";
        //        //strHtmlNatalCat += "</div>";
        //        //strHtmlNatalCat += "</div>";
        //        //Code End For Know More 
        //        strHtmlNatalCat += "</div>";
        //    }
        //    natalcategorydiv.InnerHtml = strHtmlNatalCat;
        //}
         DataSet ds = obj_cm.Get_Natal_cat(GetCurrencyType);
        StringBuilder strHtml1 = new StringBuilder();
        if (ds.Tables[0].Rows.Count > 0)
            {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string h_desc = "", CatImg = "", Cat_Actual_Price = "", Cat_Discount, Cat_Payable_Price = "";
                string h_code = ds.Tables[0].Rows[i]["CATEGORY_ID"].ToString();
                string IsPaid = ds.Tables[0].Rows[i]["IS_PAID"].ToString();
                string h_name = ds.Tables[0].Rows[i]["CATEGORY_NAME"].ToString();
                string IsAddToCart = ds.Tables[0].Rows[i]["IS_ADDTOCART"].ToString();
                Cat_Actual_Price = ds.Tables[0].Rows[i]["ACTUAL_PRICE"].ToString();
                      Cat_Discount = ds.Tables[0].Rows[i]["DISCOUNT"].ToString();
                    Cat_Payable_Price = ds.Tables[0].Rows[i]["PAYABLE_PRICE"].ToString();
                double YouSave = Convert.ToDouble(Cat_Actual_Price) - Convert.ToDouble(Cat_Payable_Price);

                CatImg = ds.Tables[0].Rows[i]["CATEGORY_IMAGE"].ToString();
                h_desc = ds.Tables[0].Rows[i]["CATEGORY_DESC"].ToString();
                strHtml1.Append("<tr>");
                //strHtml1.Append("<td class=\"text-right\"><img src=\"" + ResolveUrl("~/img/" + CatImg + "") + "\" alt=\"" + h_name + "\" title=\"" + h_name + "\" class=\"img-fluid\"></td>");
                strHtml1.Append("<td class=\"text-left\"><a href=\"" + ResolveUrl("~/" + ds.Tables[0].Rows[i]["URL"].ToString() + ".html") + "\">" + h_name + "</a></td>");
                strHtml1.Append("<td class=\"text-left\">₹" + Cat_Actual_Price  + "</td>");
                strHtml1.Append("<td class=\"text-left\">" + Cat_Discount + "%</td>");
                strHtml1.Append("<td class=\"text-left\">₹" + YouSave + "</td>");
                strHtml1.Append("<td class=\"text-left\">₹" + Cat_Payable_Price + "</td>");
                if (IsPaid == "Y")
                {
                    if (h_code == "28")
                    {
                        strHtml1.Append("<td class=\"text-left mt-0 pt-0 pb-0\"><a href =\"javascript:BuyReport('" + h_name + "'," + h_code + ",'NATAL' , '');\" class=\"kwm-btn mt-1\"><i class=\"fa fa-shopping-cart mr-1\"></i>Buy Report</a></td>");
                    }
                    else
                    {
                        if (IsAddToCart == "Y")
                        {
                            strHtml1.Append("<td class=\"text-left mt-0 pt-0 pb-0\"><a href =\"javascript:AddToCart('" + h_name + "'," + h_code + ",'NATAL' , '');\" class=\"kwm-btn mt-1\"><i class=\"fa fa-shopping-cart mr-1\"></i>Add to Cart</a></td>");
                        }
                        else
                        {
                            strHtml1.Append("<td class=\"text-left mt-0 pt-0 pb-0\"><a href=\"" + ResolveUrl("~/" + ds.Tables[0].Rows[i]["URL"].ToString() + ".html") + "\" class=\"kwm-btn mt-1\"><i class=\"fa fa-shopping-cart mr-1\"></i>Add to Cart</a></td>");
                        }
                      }
                }
                else
                {
                    strHtml1.Append("<td class=\"text-left mt-0 pt-0 pb-0\"><a href=\"" + ResolveUrl("~/" + ds.Tables[0].Rows[i]["URL"].ToString() + ".html") + "\" class=\"kwm-btn mt-1\"><i class=\"fa fa-file mr-1\"></i>Get Report</a></td>");
                }
                //    if (h_code == "28")
                //{
                //    strHtml1.Append("<td class=\"text-left mt-0 pt-0 pb-0\"><a href =\"javascript:BuyReport('" + h_name + "'," + h_code + ",'NATAL' , '');\" class=\"kwm-btn mt-1\"><i class=\"fa fa-shopping-cart mr-1\"></i>Buy Report</a></td>");
                //}
                //else
                //{
                //    strHtml1.Append("<td class=\"text-left mt-0 pt-0 pb-0\"><a href =\"javascript:AddToCart('" + h_name + "'," + h_code + ",'NATAL' , '');\" class=\"kwm-btn mt-1\"><i class=\"fa fa-shopping-cart mr-1\"></i>Add to Cart</a></td>");
                //}
                strHtml1.Append("</tr>");
            }
        }
        divData.InnerHtml = strHtml1.ToString();


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