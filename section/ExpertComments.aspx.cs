using System;
using System.Collections;
using System.Configuration;
using System.Data;
using ASTROLOGY.classesoracle;
using System.Web.UI.HtmlControls;
using System.Web;
using System.Text.RegularExpressions;

public partial class section_ExpertComments : System.Web.UI.Page
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

            Page.Title = "Expert's Comment" + " | Astro Envision";
            string Domainurl = Request.Url.Scheme + System.Uri.SchemeDelimiter + Request.Url.Host;
            string url = Domainurl + HttpContext.Current.Request.RawUrl;
            HtmlLink tag = new HtmlLink();
            tag.Attributes.Add("rel", "canonical");
            tag.Href = url;
            //Header.Controls.Add(tag);  // This Line is used without Master Page
            Master.FindControl("head").Controls.Add(tag); // This Line is used with Master Page
            GetExpertCommentList();
        }
    }
    #endregion

    #region Expert Comment List
    void GetExpertCommentList()
    {
        try
        {
            ds = obj_mc.GetArticles("3", "BOTH", "0","");
            if (ds.Tables[0].Rows.Count > 0)
            {
                StrHtml = "<h1 class=\"fullarticle_catname\">Expert's Comment</h1><div style='clear:both;'></div>";
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
                 
                    string authorimg = ds.Tables[0].Rows[i]["AUTHOR_IMG"].ToString();
                    string author = ds.Tables[0].Rows[i]["AUTHOR"].ToString();
                    string catname = ds.Tables[2].Rows[0]["CAT_NAME"].ToString();
                    string caturl = obj_cm.ReplaceQuotes(catname);
                    caturl = obj_cm.OptimizeURL(caturl);
                    StrHtml += "<div class=\"col-sm-12 mt-2 pb-1\" style='border-bottom: 1px dashed #d0d0d0;'>";
                    if (authorimg != "")
                    {
                        StrHtml += "<p><a rel=\"nofollow\" title='" + author + "' style = 'color:#F4600A;' href =\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url.TrimStart('-').TrimEnd('-') + ".html") + "\">";
                        StrHtml += "<img class='mr-2' style=\"max-width:90px;border-radius: 20px;float: left;\" src=\"" + ResolveUrl("~/Image/" + authorimg + "") + "\" alt=\"" + author + "\" title='" + author + "' class=\"expert-img\" />";
                        StrHtml += "</a></p>";
                    }
                    else
                    {
                        StrHtml += "<p><a rel=\"nofollow\" title='" + author + "' style = 'color:#F4600A;' href =\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url.TrimStart('-').TrimEnd('-') + ".html") + "\">";
                        StrHtml += "<img class='mr-2' style=\"max-width:90px;border-radius: 20px;float: left;\" src=\"" + ResolveUrl("~/img/Default.jpg") + "\"  alt=\"" + author + "\" title='" + author + "' class=\"expert-img\" />";
                        StrHtml += "</a></p>";
                    }
                    StrHtml += "<h2><a style = 'color:#F4600A;' href =\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url.TrimStart('-').TrimEnd('-') + ".html") + "\">" + author + "</a></h2>";
                    StrHtml += "<h3><a style = 'color:#F4600A;' href =\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url.TrimStart('-').TrimEnd('-') + ".html") + "\">" + Headline + "</a></h3>";
                    StrHtml += "<div class='fullarticle_summary'>" + synopsis + "<p><a rel=\"nofollow\" title='" + author + "'style='color:#F4600A;font-weight: 600;' href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url.TrimStart('-').TrimEnd('-') + ".html") + "\">&nbsp;Read More...</a></p></div>";
                    StrHtml += "</div>";
                }

                StrHtml += "<div style='clear:both;'></div>";
                divExpertComments.InnerHtml = StrHtml;
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