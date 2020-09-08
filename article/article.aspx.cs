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

public partial class article_article : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    DataSet dsmeta = new DataSet();
    myaccount obj_mc = new myaccount();
    common obj_cm = new common();
    string CatId = "", ArticleID = "", ArticleUrl="";
    string article_dtls = "", Cat_name = "";
    string strHtml = "";
    string PreviousPageURLFinal = "";
    bool QryStringFlag = false;
    public string WEBSITEDomain = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if(Request.UrlReferrer != null)
            {
                lnkPreviousPage.Visible = true;
                hdnPriviousURl.Value = Request.UrlReferrer.ToString();
            }
            else
            {
                lnkPreviousPage.Visible = false;
            }

            if (Request.QueryString["catid"] != null && Request.QueryString["articleid"] != null)
            {
                CatId = Request.QueryString["catid"].ToString().Trim();
                ArticleID = Request.QueryString["articleid"].ToString().Trim();
                QryStringFlag = true;
            }
            if(Request.QueryString["articleurl"] != null)
            {
                ArticleUrl = Request.QueryString["articleurl"].ToString().Trim();
                QryStringFlag = true;
            }

            if (QryStringFlag==true)
            {
                string page = Request.Url.Segments[Request.Url.Segments.Length - 1];

                dsmeta = obj_mc.GetArticles(CatId, "BOTH", ArticleID, ArticleUrl);
                if (dsmeta.Tables[1].Rows.Count > 0)
                {
                    string headlineval = dsmeta.Tables[1].Rows[0]["HEADLINE"].ToString();
                    headlineval = headlineval.Replace(":", "");
                    string titleval = dsmeta.Tables[2].Rows[0]["TITLE"].ToString();
                    string keywordsval = dsmeta.Tables[2].Rows[0]["META_KEYWORDS"].ToString();
                    string descval = dsmeta.Tables[2].Rows[0]["META_DESCRIPTION"].ToString();
                    //Add Page Title
                 
                    if (keywordsval != "")
                    {
                        //Add Keywords Meta Tag
                        HtmlMeta keywords = new HtmlMeta();
                        keywords.HttpEquiv = "keywords";
                        keywords.Name = "keywords";
                        keywords.Content = keywordsval;
                        Master.FindControl("head").Controls.Add(keywords);
                    }
                   
                    string Domainurl = Request.Url.Scheme + System.Uri.SchemeDelimiter + Request.Url.Host;
                    string url = Domainurl + HttpContext.Current.Request.RawUrl;
                    HtmlLink tag = new HtmlLink();
                    tag.Attributes.Add("rel", "canonical");
                    tag.Href = url;
                    //Header.Controls.Add(tag);  // This Line is used without Master Page


                    Master.FindControl("head").Controls.Add(tag); // This Line is used with Master Page

                    var form = (HtmlForm)this.Master.FindControl("form1");
                    form.Action = url;
                }
                dsmeta.Dispose();
            }
            else
            {
                Response.Redirect(WEBSITEDomain);
            }

        }
        if (QryStringFlag == true)
        {
            ds = obj_mc.GetArticles(CatId, "BOTH", ArticleID, ArticleUrl);
            if (ds.Tables[1].Rows.Count != 0)
            {
                string Headline = ds.Tables[1].Rows[0]["HEADLINE"].ToString();
                string CreatedDate = ds.Tables[1].Rows[0]["CREATEDDATE"].ToString();
                article_dtls = ds.Tables[1].Rows[0]["FULLSTORY"].ToString();
                Cat_name = ds.Tables[2].Rows[0]["CAT_NAME"].ToString();
                string authorimg = ds.Tables[1].Rows[0]["AUTHOR_IMG"].ToString();
                string catname = ds.Tables[2].Rows[0]["CAT_NAME"].ToString();
                string caturl = obj_cm.ReplaceQuotes(catname);
                caturl = obj_cm.OptimizeURL(caturl);
              
                Headline = Regex.Replace(Headline, @"<[^>]+>|&nbsp;", "").Trim();
                Headline = Regex.Replace(Headline, @"\s{2,}", " ");
                string headline_url = obj_cm.ReplaceQuotes(Headline);
                headline_url = obj_cm.OptimizeURL(headline_url);

                string AUTHOR = ds.Tables[1].Rows[0]["AUTHOR"].ToString();
                string HeadlineTitle = ds.Tables[1].Rows[0]["TITLE"].ToString();

                string Headlinekeyworval = ds.Tables[1].Rows[0]["META_KEYWORDS"].ToString();
                string Headlinedescval = ds.Tables[1].Rows[0]["META_DESCRIPTION"].ToString();

                if (HeadlineTitle=="")
                {
                    HeadlineTitle = Cat_name;
                }
                if (AUTHOR != "")
                {
                    Page.Title = Cat_name + " by " + AUTHOR + " | Astro Envision";
                    //Add Description Meta Tag
                    HtmlMeta description = new HtmlMeta();
                    description.HttpEquiv = "description";
                    description.Name = "description";
                    //description.Content = "Astro Envsion - "+ Cat_name + " by  " + AUTHOR + ", Please read our customer's views about our astrology services.";
                    description.Content = Headlinedescval;
                    Master.FindControl("head").Controls.Add(description);

                    HtmlMeta keywords = new HtmlMeta();
                    keywords.HttpEquiv = "keywords";
                    keywords.Name = "keywords";
                    keywords.Content = Headlinekeyworval;
                    Master.FindControl("head").Controls.Add(keywords);
                }
                else
                {
                    Page.Title = HeadlineTitle + " | Astro Envision";
                    HtmlMeta description = new HtmlMeta();
                    description.HttpEquiv = "description";
                    description.Name = "description";
                    //description.Content = "Astro Envsion - Testimonial ,Please read our customer's views about our astrology services.";
                    description.Content = Headlinedescval;
                    Master.FindControl("head").Controls.Add(description);

                    HtmlMeta keywords = new HtmlMeta();
                    keywords.HttpEquiv = "keywords";
                    keywords.Name = "keywords";
                    keywords.Content = Headlinekeyworval;
                    Master.FindControl("head").Controls.Add(keywords);
                }
                //strHtml += "<div class='fullarticle_catname'><a href=\"" + ResolveUrl(PreviousPageURLFinal) + "\"><img src=\"" + ResolveUrl("~/Image/previous.png") + "\" alt='Back' title='Back' /></a>" + Cat_name + "<div style='float: right;cursor: pointer;' onClick=\"location.href='" + PreviousPageURLFinal + "';\">Back&nbsp;&nbsp;</div></div>";
                //strHtml += "<h1 class='fullarticle_catname'>" + Cat_name + "</h1>";
                //if (Headline != "")
                //{
                //    strHtml += "<h2 class='fullarticle_catname_h1' style='padding:0% 0% 0.5% 0%;'>" + Headline + "</h2>";
                //}
                //strHtml += "<div style='clear:both;'></div>";
                //strHtml += article_dtls;
                strHtml = "<h1 class=\"fullarticle_catname\">"+ Cat_name + "</h1><div style=\"clear: both;\"></div>";
                
                strHtml += "<div class='mt-2 pb-1' style='border-bottom: 1px dashed #d0d0d0;'>";
               
                if (authorimg != "")
                {
                    strHtml += "<p>";
                    strHtml += "<img class='mr-2' style=\"max-width:135px;border-radius: 20px;float: left;\" src=\"" + ResolveUrl("~/Image/" + authorimg + "") + "\" alt=\"" + Cat_name + "\" title='" + Cat_name + "' />";
                    strHtml += "</p>";

                }
                //strHtml += "<h1> "+ Cat_name + "</h1>";
                if (Headline != "")
                {
                    strHtml += "<span style='font-weight:600;'>"+ Headline  + "</span>";
                }
                strHtml += "<br/><span style='font-weight:600;'>" + CreatedDate + "</span>";

                strHtml += "<div class='fullarticle'>";
                strHtml += "<p>" + article_dtls + "</p>";
                strHtml += "</div>";
                strHtml += "</div>";
            }
            //strHtml += "<div style='clear:both;'></div>";
            fullarticle_id.InnerHtml = strHtml;
            ds.Dispose();
        }
    }

    protected void lnkPreviousPage_Click(object sender , EventArgs e)
    {
        if (hdnPriviousURl.Value != "")
        {
            Response.Redirect(hdnPriviousURl.Value);
        }
    }
}