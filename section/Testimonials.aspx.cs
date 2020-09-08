using System;
using System.Collections;
using System.Configuration;
using System.Data;
using ASTROLOGY.classesoracle;
using System.Web.UI.HtmlControls;
using System.Web;
using System.Text.RegularExpressions;

public partial class section_Testimonials : System.Web.UI.Page
{
    #region Declarartions
    ASTROLOGY.classesoracle.myaccount obj_mc = new ASTROLOGY.classesoracle.myaccount();
    common obj_cm = new common();
    DataTable dt = new DataTable();
    DataSet ds = new DataSet();
    string StrHtml = "";
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            Page.Title = "Testimonials" + " | Astro Envision";
            string Domainurl = Request.Url.Scheme + System.Uri.SchemeDelimiter + Request.Url.Host;
            string url = Domainurl + HttpContext.Current.Request.RawUrl;
            HtmlLink tag = new HtmlLink();
            tag.Attributes.Add("rel", "canonical");
            tag.Href = url;
            //Header.Controls.Add(tag);  // This Line is used without Master Page
            Master.FindControl("head").Controls.Add(tag); // This Line is used with Master Page
            GetTestimonialList();
        }
    }
    #endregion

    #region Testimonials List
    void GetTestimonialList()
    {
        try
       {
            ds = obj_mc.GetArticles("4", "BOTH", "0","");
            if (ds.Tables[0].Rows.Count > 0)
            {
                StrHtml += "<ul class=\"tstlist\">";
                for (int i = 0; i < ds.Tables[0].Rows.Count;i++)
                {
                    string NewsId = ds.Tables[0].Rows[i]["NEWS_ID"].ToString();
                    string CatId = ds.Tables[0].Rows[i]["CATID"].ToString();
                
                    string Headline = ds.Tables[0].Rows[i]["HEADLINE"].ToString();
                    Headline = Regex.Replace(Headline, @"<[^>]+>|&nbsp;", "").Trim();
                    Headline = Regex.Replace(Headline, @"\s{2,}", " ");
                    string headline_url = obj_cm.ReplaceQuotes(Headline);
                    headline_url = obj_cm.OptimizeURL(headline_url);
                    string synopsis = ds.Tables[0].Rows[i]["SYNOPSIS"].ToString();
                    string authorimg = ds.Tables[0].Rows[i]["AUTHOR_IMG"].ToString();
                    string author = ds.Tables[0].Rows[i]["AUTHOR"].ToString();
                    string CreatedDate = ds.Tables[0].Rows[i]["CREATEDDATE"].ToString();
                    string catname = ds.Tables[2].Rows[0]["CAT_NAME"].ToString();
                    string URL = ds.Tables[0].Rows[i]["URL"].ToString();
                    string caturl = obj_cm.ReplaceQuotes(catname);
                    caturl = obj_cm.OptimizeURL(caturl);

                    StrHtml += "<li class=\"d-flex\">";
                    StrHtml += "<div class=\"tdtl\">";
                    if (authorimg != "")
                    {
                        StrHtml += "<p><a rel=\"nofollow\" title='" + author + "' href=\"" + ResolveUrl("~/astrology/" + URL + ".html") + "\">";
                        StrHtml += "<img class='mr-2' src=\"" + ResolveUrl("~/Image/" + authorimg + "") + "\" alt=\"" + author + "\" title='" + author + "' />";
                        StrHtml += "</a></p>";
                    }
                    if (authorimg == "")
                    {
                        StrHtml += "<p><a rel=\"nofollow\" title='" + author + "' href=\"" + ResolveUrl("~/astrology/" + URL + ".html") + "\">";
                        StrHtml += "<img class='mr-2' title='No Image' alt='No Image' src=\"" + ResolveUrl("~/img/Default.jpg") + "\" />";
                        StrHtml += "</a></p>";
                    }
                    StrHtml += "<h2 class=\"tstnme\"><a title='" + author + "' href=\"" + ResolveUrl("~/astrology/" + URL + ".html") + "\">" + Headline + "</a></h2>";
                    StrHtml += "<span style='font-weight:600;'>" + CreatedDate + "</span>";
                    StrHtml += "<div class=\"tstdtl\">" + synopsis + "";
                    StrHtml += "<p><a rel=\"nofollow\" class=\"tstlnk\" title='" + author + "' href=\"" + ResolveUrl("~/astrology/" + URL +  ".html") + "\">&nbsp;Read More...</a></p>";
                    StrHtml += "</div>";
                    StrHtml += "</div>";
                    StrHtml += "</li>";
                }
                StrHtml += "</ul>";
                divTestimonial.InnerHtml = StrHtml;
            }
            ds.Dispose();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion
}