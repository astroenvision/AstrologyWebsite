using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ASTROLOGY.classesoracle;
using System.Configuration;
using System.Web.UI.HtmlControls;
using System.Text.RegularExpressions;

public partial class section_CategoryDetails : System.Web.UI.Page
{
    #region Declarartions
    common Com_Obj = new common();
    dailyarticle obj = new dailyarticle();
    subscription obj_subs = new subscription();
    public string WEBSITEDomain = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    string StrHtml = "";
    string StrHtmlData = "";
    public string CategoryName = "", CategorySynopsis="", CategoryImagePath="", GetCategoryUrl="";
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.UrlReferrer != null)
            {
                hdnPreviousURL.InnerText = Request.UrlReferrer.ToString();
            }
            BindDetail();
        }
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

    #region Bind Details
    protected void BindDetail()
    {
        try
        {
            string GetCurrencyType = "";
            if (Session["CountryCode"] != null)
            {
                GetCurrencyType = Session["CountryCode"].ToString();
            }
            string flag = "GETCATDETAILS_IN";
            if(GetCurrencyType == "USD")
            {
                flag = "GETCATDETAILS_USD";
            }
            string CatgoruURl = Request.QueryString["Category"].ToString();
            DataSet ds = Com_Obj.GetCategoryDetails(flag , CatgoruURl);
            if (ds.Tables[0].Rows.Count > 0)
            {

                string titleval = ds.Tables[0].Rows[0]["TITLE"].ToString();
                string keywordsval = ds.Tables[0].Rows[0]["META_KEYWORDS"].ToString();
                string descval = ds.Tables[0].Rows[0]["META_DESCRIPTION"].ToString();
                //Add Page Title
                if (titleval != "")
                {
                    Page.Title = titleval + " | Astro Envision";
                }
                if (keywordsval != "")
                {
                    //Add Keywords Meta Tag
                    HtmlMeta keywords = new HtmlMeta();
                    keywords.HttpEquiv = "keywords";
                    keywords.Name = "keywords";
                    keywords.Content = keywordsval;
                    //Page.Header.Controls.Add(keywords); // This Line is used without Master Page
                    Master.FindControl("head").Controls.Add(keywords); // This Line is used with Master Page
                }
                if (descval != "")
                {
                    //Add Description Meta Tag
                    HtmlMeta description = new HtmlMeta();
                    description.HttpEquiv = "description";
                    description.Name = "description";
                    description.Content = descval;
                    //Page.Header.Controls.Add(description); // This Line is used without Master Page
                    Master.FindControl("head").Controls.Add(description); // This Line is used with Master Page
                }
                string Domainurl = Request.Url.Scheme + System.Uri.SchemeDelimiter + Request.Url.Host;
                string url = Domainurl + HttpContext.Current.Request.RawUrl;
                GetCategoryUrl = url;
                HtmlLink tag = new HtmlLink();
                tag.Attributes.Add("rel", "canonical");
                tag.Href = url;
                //Header.Controls.Add(tag);  // This Line is used without Master Page
                Master.FindControl("head").Controls.Add(tag); // This Line is used with Master Page

                CategoryName = ds.Tables[0].Rows[0]["CATEGORY_NAME"].ToString();
                string CatImage = ds.Tables[0].Rows[0]["CATEGORY_IMAGE"].ToString();
                CategoryImagePath = WEBSITEDomain + "/img/" + CatImage + "";
                CategorySynopsis = ds.Tables[0].Rows[0]["CATEGORY_SYNOPSIS"].ToString();
                string Cat_Actual_Price = ds.Tables[0].Rows[0]["ACTUAL_PRICE"].ToString();
                string Cat_Discount = ds.Tables[0].Rows[0]["DISCOUNT"].ToString();
                string Cat_Payable_Price = ds.Tables[0].Rows[0]["PAYABLE_PRICE"].ToString();
                string SaveAmount = (Convert.ToDouble(ds.Tables[0].Rows[0]["ACTUAL_PRICE"]) - Convert.ToDouble(ds.Tables[0].Rows[0]["PAYABLE_PRICE"])).ToString();
                string h_code = ds.Tables[0].Rows[0]["CATEGORY_ID"].ToString();
                string h_desc = ds.Tables[0].Rows[0]["CATEGORY_DESC"].ToString();
                string h_desc1 = ds.Tables[0].Rows[0]["CATEGORY_DESC1"].ToString();
                string h_desc2 = ds.Tables[0].Rows[0]["CATEGORY_DESC2"].ToString();
                string IsPaid = ds.Tables[0].Rows[0]["IS_PAID"].ToString();
                string IsAddToCart = ds.Tables[0].Rows[0]["IS_ADDTOCART"].ToString();
                h_desc += h_desc1 + h_desc2;
                h_desc = h_desc.Replace("'", "&#39;").Replace("<div>", "<p>").Replace("</div>", "</p>");
                
                //Add Data for Social Media Share Start
                HtmlMeta hm_title = new HtmlMeta();
                hm_title.Attributes.Add("property", "og:title");
                hm_title.Content = CategoryName;
                Master.FindControl("head").Controls.Add(hm_title);

                CategorySynopsis = Regex.Replace(CategorySynopsis, "<.*?>", String.Empty);
                HtmlMeta hm_desc = new HtmlMeta();
                hm_desc.Attributes.Add("property", "og:description");
                hm_desc.Content = CategorySynopsis;
                Master.FindControl("head").Controls.Add(hm_desc);

                HtmlMeta hm_image = new HtmlMeta();
                hm_image.Attributes.Add("property", "og:image");
                hm_image.Content = CategoryImagePath;
                Master.FindControl("head").Controls.Add(hm_image);

                HtmlMeta hm_url = new HtmlMeta();
                hm_url.Attributes.Add("property", "og:url");
                hm_url.Content = GetCategoryUrl;
                Master.FindControl("head").Controls.Add(hm_url);

                HtmlMeta hm_site_name = new HtmlMeta();
                hm_site_name.Attributes.Add("property", "og:site_name");
                hm_site_name.Content = WEBSITEDomain;
                Master.FindControl("head").Controls.Add(hm_site_name);

                HtmlMeta hm_title1 = new HtmlMeta();
                hm_title1.Attributes.Add("property", "twitter:title");
                hm_title1.Content = CategoryName;
                Master.FindControl("head").Controls.Add(hm_title1);

                HtmlMeta hm_desc1 = new HtmlMeta();
                hm_desc1.Attributes.Add("property", "twitter:description");
                hm_desc1.Content = CategorySynopsis;
                Master.FindControl("head").Controls.Add(hm_desc1);

                HtmlMeta hm_image1 = new HtmlMeta();
                hm_image1.Attributes.Add("property", "twitter:image");
                hm_image1.Content = CategoryImagePath;
                Master.FindControl("head").Controls.Add(hm_image1);

                HtmlMeta hm_site_name1 = new HtmlMeta();
                hm_site_name1.Attributes.Add("property", "twitter:domain");
                hm_site_name1.Content = WEBSITEDomain;
                Master.FindControl("head").Controls.Add(hm_site_name1);

                HtmlMeta hm_site1 = new HtmlMeta();
                hm_site1.Attributes.Add("property", "twitter:site");
                hm_site1.Content = "@astroenvision";
                Master.FindControl("head").Controls.Add(hm_site1);

                HtmlMeta hm_card = new HtmlMeta();
                hm_card.Attributes.Add("property", "twitter:card");
                hm_card.Content = CategorySynopsis;
                Master.FindControl("head").Controls.Add(hm_card);

                //Add Data for Social Media Share End

                StrHtml = "<div class=\"fullarticle\" runat=\"server\">";
                StrHtml += "<h1 class=\"fullarticle_catname\">"+ CategoryName + "<div style='float: right;cursor: pointer;' onClick=\"location.href='" + hdnPreviousURL.InnerText + "';\"><a href=\"" + ResolveUrl(hdnPreviousURL.InnerText) + "\"><img src=\"" + ResolveUrl("~/Image/previous.png") + "\" alt='Back' title='Back' /></a>&nbsp;Back&nbsp;&nbsp;</div></h1>";
                StrHtml += "</div>";

                StrHtml += "<h2 class='fullarticle_catname_h1' style='padding:0% 0% 0.5% 0%; width: 100%'>";
                StrHtml += "<a href=\"" + ResolveUrl("~") + "\">Astro Envision</a> > <a href=\"" + ResolveUrl("~/natal-astrology.html") + "\">Natal Astrology</a> > " + CategoryName + "";
                StrHtml += "</h2>";

                StrHtml += "<div style=\"clear: both;\"></div>";
                StrHtml += "<div class=\"row\">";
                StrHtml += "<div class=\"col-sm-4\"><img src=\"" + ResolveUrl("~/img/" + CatImage + "") + "\" alt=" + CategoryName + " title=" + CategoryName + "/></div>";
                StrHtml += "<div class=\"col-sm-4\">";
                StrHtml += "<div class =\"prce\">";
                          
                if (GetCurrencyType != "USD")
                {
                    StrHtml += "<label style =\"font-size:1.5em;font-weight: 400;\">Actual Amount :- &nbsp;</label><label style =\"font-size:1.5em;font-weight: 400;vertical-align: initial;\" class=\"price-old\">₹" + Cat_Actual_Price + "</label><br />";
                    if (Cat_Discount != "" && Cat_Discount != "0" && Cat_Discount != "NULL")
                    {
                        StrHtml += "<label style =\"font-size:1.5em;font-weight: 400;vertical-align: middle;\">Payable Amount :- &nbsp;</label><label style =\"font-size:1.8em;font-weight: 600;vertical-align: middle;\" class=\"price-new\">₹" + Cat_Payable_Price + "</label><br />";
                        StrHtml += "<label style =\"font-size:1.5em;font-weight: 400;\">You Save :- &nbsp;</label><label style =\"font-size:1.5em;font-weight: 400;vertical-align: initial;color:#f25e0a;\" >₹" + SaveAmount + " (" + Cat_Discount + "%)</label><br />";
                    }
                }
                else
                {
                    StrHtml += "<label style =\"font-size:1.5em;font-weight: 400;\">Actual Amount :- &nbsp;</label><label style =\"font-size:1.5em;font-weight: 400;vertical-align: initial;\" class=\"price-old\">$" + Cat_Actual_Price + "</label><br />";
                    if (Cat_Discount != "" && Cat_Discount != "0" && Cat_Discount != "NULL")
                    {
                        StrHtml += "<label style =\"font-size:1.5em;font-weight: 400;vertical-align: middle;\">Payable Amount :- &nbsp;</label><label style =\"font-size:1.8em;font-weight: 600;vertical-align: middle;\" class=\"price-new\">$" + Cat_Payable_Price + "</label><br />";
                        StrHtml += "<label style =\"font-size:1.5em;font-weight: 400;\">You Save :- &nbsp;</label><label style =\"font-size:1.5em;font-weight: 400;vertical-align: initial;color: #f25e0a;\">$" + SaveAmount + " (" + Cat_Discount + "%)</label><br />";
                    }
                }
                StrHtml += "</div>";
               
                //Code For Social Media Start
                StrHtml += "<div>"; 
                //StrHtml += "<span class=\"sfacebook\"><a href=\"https://www.facebook.com/sharer/sharer.php?u=" + GetCategoryUrl + "\" onclick=\"window.open(this.href, '', 'width=626,height=436');  return false;\" rel=\"nofollow\" target=\"_blank\" title=\"Share this on Facebook\"><i class=\"fa fa-facebook\"></i></a></span>";
                StrHtml += "<ul class='socialmediaul'>";
                StrHtml += "<li><a href=\"https://www.facebook.com/sharer/sharer.php?u=" + GetCategoryUrl + "\" onclick=\"window.open(this.href, '', 'width=626,height=436');  return false;\" rel=\"noopener noreferrer nofollow\" target=\"_blank\" title=\"Share this on Facebook\"><i class=\"fa fa-facebook\"></i></a></li>";
                StrHtml += "<li><a href=\"https://www.linkedin.com/shareArticle?mini=true&summary=" + CategorySynopsis + "&title=" + CategoryName + "&url=" + GetCategoryUrl + "\" onclick=\"window.open(this.href, '', 'width=626,height=436');  return false;\" rel=\"noopener noreferrer nofollow\" target=\"_blank\" title=\"Share this on Linkedin\"><i class=\"fa fa-linkedin\"></i></a></li>";
                StrHtml += "<li><a href=\"https://twitter.com/share?text=" + CategoryName + "&url=" + GetCategoryUrl + "&amp;via=astroenvision\" onclick=\"window.open(this.href, '', 'width=626,height=436');  return false;\" rel=\"noopener noreferrer nofollow\" target=\"_blank\" title=\"Share this on Twitter\"><i class=\"fa fa-twitter\"></i></a></li>";
                //StrHtml += "<li><a href=\"https://plus.google.com/share?url=" + GetCategoryUrl + "\" onclick=\"window.open(this.href, '', 'width=626,height=436');  return false;\" rel=\"nofollow\" target=\"_blank\" title=\"Share this on Google Plus\"><i class=\"fa fa-google-plus\"></i></a></li>";
                //StrHtml += "<li><a href=\"https://www.instagram.com/?url=" + GetCategoryUrl + "\" onclick=\"window.open(this.href, '', 'width=626,height=436');  return false;\" rel=\"nofollow\" target=\"_blank\" title=\"Share this on Instagram\"><i class=\"fa fa-instagram\"></i></a></li>";
                StrHtml += "<li><a href=\"https://web.whatsapp.com/send?text=" + GetCategoryUrl + "\" target='_blank' title=\"Share this on Whatsapp\" rel=\"noopener noreferrer nofollow\"><i class=\"fa fa-whatsapp\"></i></a></li>";
                StrHtml += "<li><a href=\"mailto:?subject=" + CategoryName + "&amp;body=" + CategorySynopsis + "&nbsp;" + GetCategoryUrl + "\" rel=\"noopener noreferrer nofollow\" title=\"Share this on Email\"><i class=\"fa fa-envelope\"></i></a></li>";
                StrHtml += "</ul>";
                StrHtml += "</div>";
                //Code For Social Media End

                StrHtml += "</div>";

                StrHtml += "<div class=\"col-sm-4\">";


                if (IsPaid == "Y")
                {
                    if (h_code == "28")
                    {
                        StrHtml += "<div class=\"text-sm-left\">";
                        StrHtml += "<div><b>Your " + CategoryName + " Astro Report:-</b>&nbsp;&nbsp;<a href=\"javascript:BuyReport('" + CategoryName + "'," + h_code + ",'NATAL' , '');\" class=\"vwall-btn\"><i class=\"fa fa-shopping-cart mr-1\"></i>Buy Report</a></div>";
                        StrHtml += "</div>";
                    }
                    else
                    {
                        if (IsAddToCart == "Y")
                        {
                            StrHtml += "<div class=\"text-sm-left\">";
                            StrHtml += "<div><b>Your " + CategoryName + " Astro Report:-</b>&nbsp;&nbsp;<a href=\"javascript:AddToCart('" + CategoryName + "'," + h_code + ",'NATAL' , '');\" class=\"vwall-btn\"><i class=\"fa fa-shopping-cart mr-1\"></i>Add to Cart</a></div>";
                            StrHtml += "</div>";
                        }
                        else
                        {
                            StrHtml += "<div class=\"text-sm-left\">";
                            StrHtml += "<div><b>Your " + CategoryName + " Astro Report:-</b>&nbsp;&nbsp;<a href=\"" + ResolveUrl("~/" + ds.Tables[0].Rows[0]["URL"].ToString() + ".html") + "\" class=\"vwall-btn\"><i class=\"fa fa-shopping-cart mr-1\"></i>Add to Cart</a></div>";
                            StrHtml += "</div>";
                        }
                    }
                }
                else
                {
                    StrHtml += "<div class=\"text-sm-left\">";
                    StrHtml += "<div><b>Your " + CategoryName + " Astro Report:-</b>&nbsp;&nbsp;<a href=\"" + ResolveUrl("~/" + ds.Tables[0].Rows[0]["URL"].ToString() + ".html") + "\" class=\"vwall-btn\"><i class=\"fa fa-file mr-1\"></i>Get Report</a></div>";
                    StrHtml += "</div>";
                }

                //if (h_code == "28")
                //{
                //    StrHtml += "<div class=\"text-sm-left\">";
                //    StrHtml += "<div><b>Your " + CategoryName + " Astro Report:-</b>&nbsp;&nbsp;<a href=\"javascript:BuyReport('" + CategoryName + "'," + h_code + ",'NATAL' , '');\" class=\"vwall-btn\"><i class=\"fa fa-shopping-cart mr-1\"></i>Buy Report</a></div>";
                //    StrHtml += "</div>";
                //}
                //else
                //{
                //    StrHtml += "<div class=\"text-sm-left\">";
                //    StrHtml += "<div><b>Your " + CategoryName + " Astro Report:-</b>&nbsp;&nbsp;<a href=\"javascript:AddToCart('" + CategoryName + "'," + h_code + ",'NATAL' , '');\" class=\"vwall-btn\"><i class=\"fa fa-shopping-cart mr-1\"></i>Add to Cart</a></div>";
                //    StrHtml += "</div>";
                //}
                StrHtml += "</div>";

                StrHtml += "</div>";

                StrHtml += "<div style=\"margin-top: 17px;\">" + h_desc + "</div>";

                if (IsPaid == "Y")
                {
                    if (h_code == "28")
                    {
                        StrHtml += "<div class=\"text-sm-right\">";
                        StrHtml += "<div><b>Your " + CategoryName + " Astro Report:-</b>&nbsp;&nbsp;<a href=\"javascript:BuyReport('" + CategoryName + "'," + h_code + ",'NATAL' , '');\" class=\"vwall-btn\"><i class=\"fa fa-shopping-cart mr-1\"></i>Buy Report</a></div>";
                        StrHtml += "</div>";
                    }
                    else
                    {
                        if (IsAddToCart == "Y")
                        {
                            StrHtml += "<div class=\"text-sm-right\">";
                            StrHtml += "<div><b>Your " + CategoryName + " Astro Report:-</b>&nbsp;&nbsp;<a href=\"javascript:AddToCart('" + CategoryName + "'," + h_code + ",'NATAL' , '');\" class=\"vwall-btn\"><i class=\"fa fa-shopping-cart mr-1\"></i>Add to Cart</a></div>";
                            StrHtml += "</div>";
                        }
                        else
                        {
                            StrHtml += "<div class=\"text-sm-right\">";
                            StrHtml += "<div><b>Your " + CategoryName + " Astro Report:-</b>&nbsp;&nbsp;<a href=\"" + ResolveUrl("~/" + ds.Tables[0].Rows[0]["URL"].ToString() + ".html") + "\"  class=\"vwall-btn\"><i class=\"fa fa-shopping-cart mr-1\"></i>Add to Cart</a></div>";
                            StrHtml += "</div>";
                         
                        }
                    }
                }
                else
                {
                    StrHtml += "<div class=\"text-sm-right\">";
                    StrHtml += "<div><b>Your " + CategoryName + " Astro Report:-</b>&nbsp;&nbsp;<a href=\"" + ResolveUrl("~/" + ds.Tables[0].Rows[0]["URL"].ToString() + ".html") + "\"  class=\"vwall-btn\"><i class=\"fa fa-file mr-1\"></i>Get Report</a></div>";
                    StrHtml += "</div>";
               }

                
                StrHtml += "<div style='clear:both;'></div>";


                /************************************************* Bind Related Category*****************************************************************************/

                DataSet dsRelatedCat = obj.GetCategoryDetails("GETRELATEDCATEGORY", h_code , "NatalCategory");
                StrHtmlData = "<div class=\"fullarticle\" runat=\"server\">";
                StrHtmlData += "<div class=\"fullarticle_catname\">&nbsp;Related Astro Report</div>";
                StrHtmlData += "</div>";
                string CatColor = "#f25e0a";
                string CatID = "";
                for (int i = 0; i < dsRelatedCat.Tables[0].Rows.Count; i++)
                {
                    CatID = dsRelatedCat.Tables[0].Rows[i]["CATEGORY_ID"].ToString();
                    string ID = dsRelatedCat.Tables[0].Rows[i]["CATEGORY_ID"].ToString();
                    string CatName = dsRelatedCat.Tables[0].Rows[i]["CATEGORY_NAME"].ToString();
                    string CatImageUrl = dsRelatedCat.Tables[0].Rows[i]["CATEGORY_IMAGE"].ToString();
                    h_desc = dsRelatedCat.Tables[0].Rows[i]["CATEGORY_DESC"].ToString();
                    h_desc = h_desc.Replace("'", "&#39;").Replace("<div>", "<p>").Replace("</div>", "</p>"); ;
                    Cat_Actual_Price = dsRelatedCat.Tables[0].Rows[i]["ACTUAL_PRICE"].ToString();
                    Cat_Discount = dsRelatedCat.Tables[0].Rows[i]["DISCOUNT"].ToString();
                    Cat_Payable_Price = dsRelatedCat.Tables[0].Rows[i]["PAYABLE_PRICE"].ToString();
                    CatColor = dsRelatedCat.Tables[0].Rows[i]["CATEGORY_COLOR"].ToString();
                    string RelIsPaid = dsRelatedCat.Tables[0].Rows[0]["IS_PAID"].ToString();
                    string RelIsAddToCart = dsRelatedCat.Tables[0].Rows[0]["IS_ADDTOCART"].ToString();
                    if (CatColor == "")
                    {
                        CatColor = "#f25e0a";
                    }
                    string CatSynopsis= dsRelatedCat.Tables[0].Rows[i]["CATEGORY_SYNOPSIS"].ToString();

                    string h_name_url = Com_Obj.ReplaceQuotes(CatName);
                    h_name_url = Com_Obj.OptimizeURL(h_name_url);
                    //string finalurl = "category/" + h_name_url + "/natal/" + h_code + "-" + Session["MySessionID"].ToString() + ".html";
                    int priority = Convert.ToInt32(dsRelatedCat.Tables[0].Rows[i]["PRIORITY"].ToString());
                     StrHtmlData += "<div class=\"col-xl-3 col-lg-4 col-sm-6 wow fadeInUp\">";
                    StrHtmlData += "<div class=\"service-col\">";
                    StrHtmlData += "<div class=\"img\"><img src=\"" + ResolveUrl("~/img/" + CatImageUrl + "") + "\" alt=\"" + CatName + "\" title=\"" + CatName + "\" class=\"img-fluid\" /></div>";
                    StrHtmlData += "<div class=\"bdy\">";
                    StrHtmlData += "<h1 class=\"title\"><a style=\"color: " + CatColor + "\" href=\"" + ResolveUrl("~/natal-astrology/" + dsRelatedCat.Tables[0].Rows[i]["CATEGORY_URL"].ToString() + ".html") + "\">" + CatName + "</a></h1>";
                    StrHtmlData += "<div class=\"prc-sec d-flex justify-content-between align-items-center\">";
                    StrHtmlData += "<div class=\"prce\">";
                    if (GetCurrencyType != "USD")
                    {
                        StrHtmlData += "<span style=\"color: " + CatColor + "\" class=\"price-new\">₹" + Cat_Payable_Price + "</span>";
                        if (Cat_Discount != "" && Cat_Discount != "0" && Cat_Discount != "NULL")
                        {
                            StrHtmlData += "<span class=\"price-old\">₹" + Cat_Actual_Price + "</span>";
                        }
                    }
                    else
                    {
                        StrHtmlData += "<span style=\"color: " + CatColor + "\" class=\"price-new\">$" + Cat_Payable_Price + "</span>";
                        if (Cat_Discount != "" && Cat_Discount != "0" && Cat_Discount != "NULL")
                        {
                            StrHtmlData += "<span class=\"price-old\">$" + Cat_Actual_Price + "</span>";
                        }
                    }
                    StrHtmlData += "</div>";
                    if (Cat_Discount != "" && Cat_Discount != "0" && Cat_Discount != "NULL")
                    {
                        StrHtmlData += "<span class=\"disc-bdge\">" + Cat_Discount + "%</span>";
                    }
                    StrHtmlData += "</div>";

                    StrHtmlData += "<p>" + CatSynopsis.ToString() + "</p>";
                    //strHtmlNatalCat += "<div class=\"rdmr\"><a class='effect-shine' href=\"javascript:;\" data-toggle=\"modal\" data-target=\"#readMore" + h_code + "\">Read More...</a></div>";
                    StrHtmlData += "<div class=\"rdmr\"><a style=\"color: " + CatColor + "\" class='effect-shine' href=\"" + ResolveUrl("~/natal-astrology/" + dsRelatedCat.Tables[0].Rows[i]["CATEGORY_URL"].ToString() + ".html") + "\">Read More...</a></div>";

                    if (RelIsPaid == "Y")
                    {
                        if (CatID == "28")
                        {
                            StrHtmlData += "&nbsp;<a href=\"javascript:BuyReport('" + CatName + "'," + CatID + ",'NATAL' , '');\" class=\"kwm-btn\"><i class=\"fa fa-shopping-cart mr-1\"></i>Buy Report</a>";
                        }
                        else
                        {
                            if (RelIsAddToCart == "Y")
                            {
                                StrHtmlData += "&nbsp;<a href=\"javascript:AddToCart('" + CatName + "'," + CatID + ",'NATAL' , '');\" class=\"kwm-btn\"><i class=\"fa fa-shopping-cart mr-1\"></i>Add to Cart</a>";
                            }
                            else
                            {
                                StrHtmlData += "&nbsp;<a href=\"" + ResolveUrl("~/" + dsRelatedCat.Tables[0].Rows[0]["URL"].ToString() + ".html") + "\"  class=\"kwm-btn\"><i class=\"fa fa-shopping-cart mr-1\"></i>Add to Cart</a>";
                             }
                        }
                    }
                    else
                    {
                        StrHtmlData += "&nbsp;<a href=\"" + ResolveUrl("~/" + dsRelatedCat.Tables[0].Rows[0]["URL"].ToString() + ".html") + "\"  class=\"kwm-btn\"><i class=\"fa fa-file mr-1\"></i>Get Report</a>";
                    }


                    //if (CatID == "28")
                    //{
                    //    //strHtmlNatalCat += "&nbsp;<a href=\"" + ResolveUrl("~/compatibilitymatching.html") + "\" class=\"kwm-btn\">Buy Report</a>";
                    //    StrHtmlData += "&nbsp;<a href=\"javascript:BuyReport('" + CatName + "'," + CatID + ",'NATAL' , '');\" class=\"kwm-btn\"><i class=\"fa fa-shopping-cart mr-1\"></i>Buy Report</a>";
                    //}
                    //else
                    //{
                    //    StrHtmlData += "&nbsp;<a href=\"javascript:AddToCart('" + CatName + "'," + CatID + ",'NATAL' , '');\" class=\"kwm-btn\"><i class=\"fa fa-shopping-cart mr-1\"></i>Add to Cart</a>";
                    //}
                    StrHtmlData += "</div>";
                    StrHtmlData += "</div>";
                    StrHtmlData += "</div>";
                }
                if(dsRelatedCat.Tables[0].Rows.Count > 0)
                {
                    natalcategorydiv.InnerHtml = StrHtmlData.ToString();
                }
                divCategory.InnerHtml = StrHtml;
            }
            ds.Dispose();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    #endregion

    //#region Bind Details
    //protected void BindDetails()
    // {
    //    try
    //    {
    //        string CatgoruURl = Request.QueryString["Category"].ToString();
    //        DataSet ds = Com_Obj.GetCategoryDetails("GETCATDETAILS", CatgoruURl);
    //        if (ds.Tables[0].Rows.Count > 0)
    //        {
    //            string titleval = ds.Tables[0].Rows[0]["TITLE"].ToString();
    //            string keywordsval = ds.Tables[0].Rows[0]["META_KEYWORDS"].ToString();
    //            string descval = ds.Tables[0].Rows[0]["META_DESCRIPTION"].ToString();
    //           //Add Page Title
    //            if (titleval != "")
    //            {
    //               Page.Title = titleval + " | Astro Envision";
    //            }
    //            if (keywordsval != "")
    //            {
    //                //Add Keywords Meta Tag
    //                HtmlMeta keywords = new HtmlMeta();
    //                keywords.HttpEquiv = "keywords";
    //                keywords.Name = "keywords";
    //                keywords.Content = keywordsval;
    //                //Page.Header.Controls.Add(keywords); // This Line is used without Master Page
    //                Master.FindControl("head").Controls.Add(keywords); // This Line is used with Master Page
    //            }
    //            if (descval != "")
    //            {
    //                //Add Description Meta Tag
    //                HtmlMeta description = new HtmlMeta();
    //                description.HttpEquiv = "description";
    //                description.Name = "description";
    //                description.Content = descval;
    //                //Page.Header.Controls.Add(description); // This Line is used without Master Page
    //                Master.FindControl("head").Controls.Add(description); // This Line is used with Master Page
    //            }
    //            string Domainurl = Request.Url.Scheme + System.Uri.SchemeDelimiter + Request.Url.Host;
    //            string url = Domainurl + HttpContext.Current.Request.RawUrl;
    //            HtmlLink tag = new HtmlLink();
    //            tag.Attributes.Add("rel", "canonical");
    //            tag.Href = url;
    //            //Header.Controls.Add(tag);  // This Line is used without Master Page
    //            Master.FindControl("head").Controls.Add(tag); // This Line is used with Master Page

    //            string CatImage = ds.Tables[0].Rows[0]["CATEGORY_IMAGE"].ToString();
    //            string Cat_Actual_Price = ds.Tables[0].Rows[0]["ACTUAL_PRICE"].ToString();
    //            string Cat_Discount = ds.Tables[0].Rows[0]["DISCOUNT"].ToString();
    //            string Cat_Payable_Price = ds.Tables[0].Rows[0]["PAYABLE_PRICE"].ToString();

    //            StrHtml = " <div class=\"fullarticle_catname\">" + ds.Tables[0].Rows[0]["CATEGORY_NAME"].ToString() + "</div>";
    //            string h_code = ds.Tables[0].Rows[0]["CATEGORY_ID"].ToString();
    //            string h_desc = ds.Tables[0].Rows[0]["CATEGORY_DESC"].ToString();
    //            h_desc = h_desc.Replace("'", "&#39;").Replace("<div>", "<p>").Replace("</div>", "</p>");
    //            string GetCountryCodde = GetCountryCode();
    //            h_desc = h_desc.Replace("http://localhost/astrology", WEBSITEDomain);
    //            StrHtml += "<h1 class='fullarticle_catname_h1' style='padding:0% 0% 0.5% 0%;width: 100%'>";
    //            StrHtml += "<a href=\""+ ResolveUrl("~/index.html")  + "\">Astroenvision</a> > <a href=\"" + ResolveUrl("~/natal-astrology.html") + "\">Natal Astrology</a> > " + ds.Tables[0].Rows[0]["CATEGORY_NAME"].ToString() + "";
    //            StrHtml += "</a>";
    //            StrHtml += "</h1>";
    //            StrHtml += "<div><img src=\"" + ResolveUrl("~/img/" + CatImage + "") + "\" alt="+ ds.Tables[0].Rows[0]["CATEGORY_NAME"].ToString() + " title=" + ds.Tables[0].Rows[0]["CATEGORY_NAME"].ToString() + "></img></div>";
    //            //StrHtml += "<div class=\"img\"><img src=\"~/img/" + CatImage + "\" alt=\"" + ds.Tables[0].Rows[0]["CATEGORY_NAME"].ToString() + "\" title=\"" + ds.Tables[0].Rows[0]["CATEGORY_NAME"].ToString() + "\" class=\"img-fluid\"></div>";
    //            StrHtml += "<div style='clear: both;'></div>";
    //            StrHtml += "<div style='float:left; margin:0% 0% 0% 0%'>";
    //            StrHtml += "<div class=\"prce\">";
    //            if (GetCountryCodde == "IN")
    //            {
    //                StrHtml += "<span class=\"price-new\">₹" + Cat_Payable_Price + "</span>";
    //                if (Cat_Discount != "" && Cat_Discount != "0" && Cat_Discount != "NULL")
    //                {
    //                    StrHtml += "<span class=\"price-old\">₹" + Cat_Actual_Price + "</span>";
    //                }
    //            }
    //            else
    //            {
    //                StrHtml += "<span class=\"price-new\">$" + Cat_Payable_Price + "</span>";
    //                if (Cat_Discount != "" && Cat_Discount != "0" && Cat_Discount != "NULL")
    //                {
    //                    StrHtml += "<span class=\"price-old\">$" + Cat_Actual_Price + "</span>";
    //                }
    //            }
    //            StrHtml += "</div>";

    //            if (Cat_Discount != "" && Cat_Discount != "0" && Cat_Discount != "NULL")
    //            {
    //                StrHtml += "<span class=\"disc-bdge\">" + Cat_Discount + "%</span>";
    //            }
    //            StrHtml += "<div style='clear:both;'></div>";
    //            StrHtml += "<div>" + h_desc + "</div>";
    //            StrHtml += "</div>";
    //            //StrHtml += "<div><b>Your " + ds.Tables[0].Rows[0]["CATEGORY_NAME"].ToString() + " Astro Report</b></div>";
    //            if (h_code == "28")
    //            {
    //                //strHtmlNatalCat += "&nbsp;<a href=\"" + ResolveUrl("~/compatibilitymatching.html") + "\" class=\"kwm-btn\">Buy Report</a>";
    //                StrHtml += "<div><b>Your " + ds.Tables[0].Rows[0]["CATEGORY_NAME"].ToString() + " Astro Report:-</b>&nbsp;&nbsp;<a href=\"javascript:BuyReport(" + h_code + ",'NATAL' , '');\" class=\"kwm-btn\"><i class=\"fa fa-shopping-cart mr-1\"></i>Buy Report</a></div>";
    //            }
    //            else
    //            {
    //                  StrHtml += "<div class=\"text-sm-right\">";
    //                  StrHtml += "<div><b>Your " + ds.Tables[0].Rows[0]["CATEGORY_NAME"].ToString() + " Astro Report:-</b>&nbsp;&nbsp;<a href=\"javascript:AddToCart(" + h_code + ",'NATAL' , '');\" class=\"vwall-btn\"><i class=\"fa fa-shopping-cart mr-1\"></i>Add to Cart</a></div>";
    //                  StrHtml += "<div>";
    //            }
    //            StrHtml += "<div style='clear:both;'></div>";
    //            divCategory.InnerHtml = StrHtml;
    //        }
    //        ds.Dispose();
    //    }
    //    catch (Exception ex)
    //    {
    //        throw ex;
    //    }
    //}

    //#endregion
}