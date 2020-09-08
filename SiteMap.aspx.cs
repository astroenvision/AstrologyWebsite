using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class SiteMap : System.Web.UI.Page
{
    #region Declaration
    common obj_cm = new common();
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Page.Title = "SiteMap" + " | Astro Envision";
            string Domainurl = Request.Url.Scheme + System.Uri.SchemeDelimiter + Request.Url.Host;
            string url = Domainurl + HttpContext.Current.Request.RawUrl;
            HtmlLink tag = new HtmlLink();
            tag.Attributes.Add("rel", "canonical");
            tag.Href = url;
            //Header.Controls.Add(tag);  // This Line is used without Master Page
            Master.FindControl("head").Controls.Add(tag); // This Line is used with Master Page
            BindData();
        }
    }
    #endregion

    #region BindData 
    protected void BindData()
    {
        string strHtmlNatalCat = "";
        string strFreeServices = "";
        string strOtherServices = "";
        DataSet ds = new DataSet();
        ds = obj_cm.Get_Natal_cat("INR");

        /********************************************Paid Services**************************************/
        strHtmlNatalCat = "<h2 class=\"SiteMapTitle\"><i class=\"fa fa-angle-double-right\" style=\"font-size:26px;color:#f25e0a;\"></i>&nbsp;Astrology Reports</h2>";
        if (ds.Tables[0].Rows.Count> 0)
        {
            for(int i =1; i < ds.Tables[0].Rows.Count; i++ )
            {
               if(ds.Tables[0].Rows[i]["IS_PAID"].ToString() =="Y")
                    {
                    strHtmlNatalCat += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"href=\"" + ResolveUrl("~/" + ds.Tables[0].Rows[i]["URL"].ToString().TrimEnd('-').TrimStart('-') + ".html") + "\">" + ds.Tables[0].Rows[i]["CATEGORY_NAME"].ToString() + "</a></div>";
                }
                //strHtmlNatalCat += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"href=\"" + ResolveUrl("~/natal-astrology/" + ds.Tables[0].Rows[i]["CATEGORY_URL"].ToString().TrimEnd('-').TrimStart('-') + ".html") + "\">" + ds.Tables[0].Rows[i]["CATEGORY_NAME"].ToString() + "</a></div>";
               
            }
        }
        strHtmlNatalCat += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"href=\"" + ResolveUrl("~/talk-to-astrologers.html") + "\">Talk To Astrologer</a></div>";
        //strHtmlNatalCat += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"href=\"" + ResolveUrl("~/consult-an-astrologer.html") + "\">Consult An Astrologer</a></div>";
        strHtmlNatalCat += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"href=\"" + ResolveUrl("~/personal-meeting.html") + "\">Personal Meetings</a></div>";
        /********************************************Free Services**************************************/
        strFreeServices += "<h2 class=\"SiteMapTitle\"><i class=\"fa fa-angle-double-right\" style=\"font-size:26px;color:#f25e0a;\"></i>&nbsp;Free Astrology Reports</h2>";
        strFreeServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\" title=\"Free Astro Report\" href =\"" + ResolveUrl("~/free-horoscope.html") + "\">Free Astro Report</a></div>";
        strFreeServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Free Kundli Matching Report\" href=\"" + ResolveUrl("~/free-kundli-matching.html") + "\">Free Kundli Matching Report</a></div>";
       
        /********************************************Other Services**************************************/
        strOtherServices += "<h2 class=\"SiteMapTitle\"><i class=\"fa fa-angle-double-right\" style=\"font-size:26px;color:#f25e0a;\"></i>&nbsp;Other Important Links</h2>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Blogs\"  href=\"" + ResolveUrl("~/astrology/blog.html") + "\">Blogs</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Experts Comments\" href= \"" + ResolveUrl("~/astrology/expert-s-comment.html") + "\">Experts Comments</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Testimonials\"  href= \"" + ResolveUrl("~/astrology/testimonials.html") + "\">Testimonials</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Privacy Policy\" href=\"" + ResolveUrl("~/privacy-policy.html") + "\">Privacy Policy</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Terms of Use\" href=\"" + ResolveUrl("~/terms-of-use.html") + "\">Terms of Use</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"About Us\" href=\"" + ResolveUrl("~/aboutus.html") + "\">About Us</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Contact Us\" href=\"" + ResolveUrl("~/contactus.html") + "\">Contact Us</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Feedback\" href=\"" + ResolveUrl("~/feedback.html") + "\">Feedback</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"FAQs\" href=\"" + ResolveUrl("~/faqs.html") + "\">FAQs</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Astro Reports\" href=\"" + ResolveUrl("~/astro-reports.html") + "\">Astro Reports</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Natal Astrology\" href=\"" + ResolveUrl("~/natal-astrology.html") + "\">Natal Astrology</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"24X7 - Astrological Support\" href=\"" + ResolveUrl("~/24-7-astrological-support.html") + "\">24X7 - Astrological Support</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Weekly Predictions\" href=\"" + ResolveUrl("~/weekly-predictions.html") + "\">Weekly Predictions</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Monthly Predictions\" href=\"" + ResolveUrl("~/monthly-predictions.html") + "\">Monthly Predictions</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Yearly Predictions\" href=\"" + ResolveUrl("~/yearly-predictions.html") + "\">Yearly Predictions</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Birth Chart Analysis\" href=\"" + ResolveUrl("~/birth-chart-analysis.html") + "\">Birth Chart Analysis</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Corporate Astrology\" href=\"" + ResolveUrl("~/corporate-astrology.html") + "\">Corporate Astrology</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Business Astrology\" href=\"" + ResolveUrl("~/business-astrology.html") + "\">Business Astrology</a></div>";

        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"A Natal Glimpse\" href=\"" + ResolveUrl("~/astrology/highlights/a-natal-glimpse.html") + "\">A Natal Glimpse</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Natal Features\" href=\"" + ResolveUrl("~/astrology/highlights/natal-features.html") + "\">Natal Features</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"A Horary Glimpse\" href=\"" + ResolveUrl("~/astrology/highlights/a-horary-glimpse.html") + "\">A Horary Glimpse</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Horary Features\" href=\"" + ResolveUrl("~/astrology/highlights/horary-features.html") + "\">Horary Features</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Write Your Testimonials\" href=\"" + ResolveUrl("~/managetestimonials.html") + "\">Write Your Testimonials</a></div>";

        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Consult an Astrologer\" href=\"" + ResolveUrl("~/consult-an-astrologer.html") + "\">Consult an Astrologer</a></div>";

        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Register\" href=\"" + ResolveUrl("~/signup.html") + "\">Registers</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Login\" href=\"" + ResolveUrl("~/signin.html") + "\">Login</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Sitemap\" href=\"" + ResolveUrl("~/sitemap.html") + "\">Sitemap</a></div>";
        strOtherServices += "<div class=\"SubCat\"><i class='fa fa-angle-double-right'></i>&nbsp;<a style=\"color:black;\"title=\"Forgot Password\" href=\"" + ResolveUrl("~/forgot_password.html") + "\">Forgot Password</a></div>";

        divCategoryID.InnerHtml = strHtmlNatalCat.ToString();
        divFreeServices.InnerHtml = strFreeServices.ToString();
        divOtherServices.InnerHtml = strOtherServices.ToString();
    }
    #endregion
}