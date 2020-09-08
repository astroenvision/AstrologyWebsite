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

public partial class index : System.Web.UI.Page
{
    public string WEBSITEDomain = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    ASTROLOGY.classesoracle.myaccount obj_mc = new ASTROLOGY.classesoracle.myaccount();
    common obj_cm = new common();
    subscription obj_subs = new subscription();
    DataSet ds = new DataSet();
    string InnerStr = "", InnerStr2, strbottommenuhtml = "";
    string mail = "astrology";
    string strHtml = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["mysession"] == null || Session["mysession"].ToString() == "")
        {
            string intrandom = Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day) + Convert.ToString(DateTime.Now.Hour) + Convert.ToString(DateTime.Now.Minute) + Convert.ToString(DateTime.Now.Second) + Convert.ToString(DateTime.Now.Millisecond);
            Session["mysession"] = intrandom;
        }
        if (!IsPostBack)
        {
            //bindbottommenubar();
            getcomments();
            gettestimonials();
            BindNatalCategories();
            Session["CountryCode"]=GetCountryCode();
        }
    }
    public void BindNatalCategories()
    {
        string strHtmlNatalCat="";
        DataSet ds = obj_cm.Get_Natal_cat("");
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string h_desc = "", short_desc = "", CatImg = ""; ;
                string h_code = ds.Tables[0].Rows[i]["CATEGORY_ID"].ToString();
                string h_name = ds.Tables[0].Rows[i]["CATEGORY_NAME"].ToString();
                CatImg = ds.Tables[0].Rows[i]["CATEGORY_IMAGE"].ToString();
                h_desc = ds.Tables[0].Rows[i]["CATEGORY_DESC"].ToString();
                h_desc = h_desc.Replace("'", "&#39;").Replace("<div>", "<p>").Replace("</div>", "</p>"); ;
                //h_desc = h_desc.Replace("http//", "").Replace("https//", "");
                h_desc = h_desc.Replace("http://localhost/astrology", WEBSITEDomain);

                string h_name_url = obj_cm.ReplaceQuotes(h_name);
                h_name_url = obj_cm.OptimizeURL(h_name_url);
                string finalurl = "category/" + h_name_url + "/natal/" + h_code + "-" + Session["mysession"].ToString() + ".html";
                //strHtml += "<a class='readmorecss' href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url + "/" + CatId + "-" + NewsId + ".html") + "\">read more..</a>";
                int priority = Convert.ToInt32(ds.Tables[0].Rows[i]["PRIORITY"].ToString());
                strHtmlNatalCat += "<div class=\"col-xl-3 col-lg-4 col-sm-6 wow fadeInUp\">";
                strHtmlNatalCat += "<div class=\"service-col\">";
                strHtmlNatalCat += "<div class=\"img\"><img src=\"img/"+ CatImg + "\" alt=\"\" class=\"img-fluid\" style='height:105px;'></div>";
                strHtmlNatalCat += "<div class=\"bdy\">";
                strHtmlNatalCat += "<h2 class=\"title\"><a href=\"#\">"+ h_name + "</a></h2>";

                short_desc = h_desc;
                short_desc = short_desc.Replace("<p>", "").Replace("</p>", "");
                IEnumerable<string> words = short_desc.Split().Take(15);
                StringBuilder firstwords = new StringBuilder();
                foreach (string s in words)
                {
                    firstwords.Append(s + " ");
                }
                firstwords.Append("...");

                strHtmlNatalCat += "<p>"+ firstwords.ToString() + "</p>";
                strHtmlNatalCat += "<a href=\"javascript:;\" class=\"kwm-btn\" data-toggle=\"modal\" data-target=\"#readMore" + h_code + "\">Know More</a>";
                strHtmlNatalCat += "&nbsp;<a href=\"javascript:AddToCart("+ h_code + ",'NATAL');\" class=\"kwm-btn\"><i class=\"fa fa-shopping-cart mr-1\"></i>Add to Cart</a>";
                strHtmlNatalCat += "</div>";
                strHtmlNatalCat += "</div>";

                //Code Start For Know More 
                strHtmlNatalCat += "<div class=\"modal fade\" id=\"readMore" + h_code + "\">";
                strHtmlNatalCat += "<div class=\"modal-dialog modal-lg modal-dialog-centered\">";
                strHtmlNatalCat += "<div class=\"modal-content\">";
                strHtmlNatalCat += "<div class=\"modal-header\">";
                strHtmlNatalCat += "<h4 class=\"modal-title\">" + h_name + "</h4>";
                strHtmlNatalCat += "<button type=\"button\" class=\"close\" data-dismiss=\"modal\"><i class=\"ion-ios-close-outline text-bold\"></i></button>";
                strHtmlNatalCat += "</div>";
                strHtmlNatalCat += "<div class=\"modal-body\">"+ h_desc + "</div>";
                strHtmlNatalCat += "</div>";
                strHtmlNatalCat += "</div>";
                strHtmlNatalCat += "</div>";
                //Code End For Know More 
                strHtmlNatalCat += "</div>";
            }
            natalcategorydiv.InnerHtml = strHtmlNatalCat;
       }
       ds.Dispose();
    }
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
                    InnerStr += "<a href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url + "/" + CatId + "-" + NewsId + ".html") + "\">";
                    InnerStr += "<img src=\"" + ResolveUrl("~/Image/" + authorimg + "") + "\" alt=\"" + author + "\" title='" + author + "' class=\"expert-img\" />";
                    InnerStr += "</a>";
                }
                InnerStr += "<p><img src=\"img/quote-sign-left.png\" class=\"quote-sign-left\" alt=\"\">";
                InnerStr +=  synopsis.Replace("<p>", "").Replace("</p>", "");
                InnerStr += "<a href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url + "/" + CatId + "-" + NewsId + ".html") + "\">&nbsp;read more..</a>";
                InnerStr += "<img src=\"img/quote-sign-right.png\" class=\"quote-sign-right\" alt=\"\"></p>";
                InnerStr += "<h3>" + author + "</h3>";
                InnerStr += "<div class=\"cmddesg\">" + Headline + "</div>";

                InnerStr += "</div>";
            }
            expertid.InnerHtml = InnerStr;
        }
        ds.Dispose();
    }
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
                InnerStr2 += "<div class=\"testimonial-item\">";
                if (authorimg != "")
                {
                    InnerStr2 += "<a href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url + "/" + CatId + "-" + NewsId + ".html") + "\">";
                    InnerStr2 += "<img class=\"testimonial-img\" src=\"" + ResolveUrl("~/Image/" + authorimg + "") + "\" alt=\"" + author + "\" title='" + author + "' />";
                    InnerStr2 += "</a>";
                }

                InnerStr2 += "<p>";
                InnerStr2 += "<img src=\"img/quote-sign-left.png\" class=\"quote-sign-left\" alt='' />";
                InnerStr2 += synopsis.Replace("<p>", "").Replace("</p>", "");
                InnerStr2 += "<a href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url + "/" + CatId + "-" + NewsId + ".html") + "\">&nbsp;read more..</a>";
                InnerStr2 += "<img src=\"img/quote-sign-right.png\" class=\"quote-sign-right\" alt='' />";
                InnerStr2 += "</p>";
                InnerStr2 += "<h3>"+ author + "</h3>";
                InnerStr2 += "</div>";
            }
            testimonialid.InnerHtml = InnerStr2;
        }
        ds.Dispose();
    }

    [WebMethod]
    public static string AddToCart(string CatId,string GroupId)
    {
        ASTROLOGY.classesoracle.main obj_main = new ASTROLOGY.classesoracle.main();
        ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
        common cs_obj = new common();
        string result = "0", flag_output2="", usertype = "2";
        bool flagactive = false;
        if (HttpContext.Current.Session["usermail"] == null || HttpContext.Current.Session["usermail"].ToString() == "")
        {
            return result;
        }
        else
        {
            string MyCatId = HttpContext.Current.Session["mysession"].ToString();
            DataSet dsnc = cs_obj.Get_Natal_Questions(CatId);
            if (dsnc.Tables[0].Rows.Count > 0)
            {
                DataSet dsmaxid = new DataSet();
                dsmaxid = obj_main.GetMaxId("AUTOID", "ADDTOCART");
                int gallmaxid = 0;
                if (dsmaxid.Tables[0].Rows.Count > 0)
                {
                    gallmaxid = Convert.ToInt32(dsmaxid.Tables[0].Rows[0]["MAXID"].ToString().Trim());
                }
                dsmaxid.Dispose();

                string ActualPrice = "", FinalPrice = "", discountval = "";
                decimal discount, discountprice, FinalPriceVal;
                DataSet ds2 = obj_subs.AstGetCommon(CatId, "2", GroupId.ToUpper(), "GETCATEGORYPRICE");
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    if (HttpContext.Current.Session["CountryCode"].ToString() == "IN")
                    {
                        ActualPrice = ds2.Tables[0].Rows[0]["PRICE_INR"].ToString();
                        discountval = ds2.Tables[0].Rows[0]["DISCOUNT_INR"].ToString();
                        if (discountval != "" && discountval != "0")
                        {
                            discount = decimal.Parse(discountval);
                            discountprice = decimal.Parse(ActualPrice) * (discount / 100);
                            FinalPriceVal = decimal.Parse(ActualPrice) - discountprice;
                            FinalPrice = FinalPriceVal.ToString();
                            //actualtotalamt.InnerText = "Amount: ₹ " + ActualPrice + "";
                            //discountper.InnerText = "You Save: ₹ " + discountprice + " (" + discountval + "%)";
                        }
                        else
                        {
                            FinalPrice = ActualPrice;
                        }
                        //totalamt.InnerText = "Fee Payable: ₹ " + FinalPrice + "";
                        //ViewState["FinalPrice"] = FinalPrice;
                    }
                    else
                    {
                        ActualPrice = ds2.Tables[0].Rows[0]["PRICE_INR"].ToString();
                        discountval = ds2.Tables[0].Rows[0]["DISCOUNT_INR"].ToString();
                        if (discountval != "" && discountval != "0")
                        {
                            discount = decimal.Parse(discountval);
                            discountprice = decimal.Parse(ActualPrice) * (discount / 100);
                            FinalPriceVal = decimal.Parse(ActualPrice) - discountprice;
                            FinalPrice = FinalPriceVal.ToString();
                            //actualtotalamt.InnerText = "Amount: $ " + ActualPrice + "";
                            //discountper.InnerText = "You Save: $ " + discountprice + " (" + discountval + "%)";
                        }
                        else
                        {
                            FinalPrice = ActualPrice;
                        }
                        //totalamt.InnerText = "Fee Payable: $ " + FinalPrice + " (USD)";
                        //ViewState["FinalPrice"] = FinalPrice;
                    }
                }
                ds2.Dispose();

                string categoryid = CatId;
                string totalques = dsnc.Tables[0].Rows.Count.ToString();
                for (int i = 0; i < dsnc.Tables[0].Rows.Count; i++)
                {
                    string categotyname = dsnc.Tables[0].Rows[i]["Category_name"].ToString();
                    string questionid = dsnc.Tables[0].Rows[i]["QUESTION_ID"].ToString();
                    string questionval = dsnc.Tables[0].Rows[i]["QUESTION"].ToString();
                    
                    DataSet ds = obj_subs.AddToCart(gallmaxid, MyCatId, "", categoryid, categotyname, questionid, questionval, totalques, "", FinalPrice, usertype, GroupId.ToUpper(), "INSERT");
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        //flag_output1 = ds.Tables[0].Rows[0]["flag"].ToString().Trim();
                        flagactive = true;
                        flag_output2 = ds.Tables[1].Rows[0]["flag2"].ToString().Trim();
                        if (flag_output2 == "SUCCESS")
                        {
                            flagactive = true;
                        }
                        //else if (flag_output2 == "FAILD")
                        //{
                        //    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('You can choose only One Category at one Point of time. You have already chosen " + precatname.ToString().ToUpper() + " Category. Do You want to Change the Query Category ');", true);
                        //    return;
                        //}
                        else if (flag_output2 == "EXIST")
                        {
                            //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "confirm('You have already chosen these Questions .');", true);
                            //return;
                        }
                    }
                    ds.Dispose();
                }

                DataSet dsc = obj_subs.GetAddToCart(MyCatId, "", "", "", "GETALLQUESTIONS");
                if (dsc.Tables[0].Rows.Count > 0)
                {
                    result = dsc.Tables[0].Rows.Count.ToString();
                }
                dsc.Dispose();
            }
            dsnc.Dispose();
        }
        return result;
    }

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

    [WebMethod]
    public static string Logout()
    {
        string result = "1"; 
        HttpContext.Current.Session["usermail"] = null;
        HttpContext.Current.Session["endusermail"] = null;
        HttpContext.Current.Session["name"] = null;
        return result;
    }

}