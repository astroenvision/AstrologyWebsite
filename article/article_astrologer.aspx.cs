﻿using System;
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

public partial class article_article_astrologer : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    DataSet dsmeta = new DataSet();
    myaccount obj_mc = new myaccount();
    string CatId = "", ArticleID = "";
    string article_dtls = "", Cat_name = "";
    string strHtml = "";
    string PreviousPageURLFinal = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["usermail"] != null || Session["usermail"] != "")
        {
            if (!IsPostBack)
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
                        string titleval = dsmeta.Tables[2].Rows[0]["TITLE"].ToString();
                        string keywordsval = dsmeta.Tables[2].Rows[0]["META_KEYWORDS"].ToString();
                        string descval = dsmeta.Tables[2].Rows[0]["META_DESCRIPTION"].ToString();
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
                            Page.Header.Controls.Add(keywords);
                        }
                        if (descval != "")
                        {
                            //Add Description Meta Tag
                            HtmlMeta description = new HtmlMeta();
                            description.HttpEquiv = "description";
                            description.Name = "description";
                            description.Content = descval;
                            Page.Header.Controls.Add(description);
                        }
                    }
                    dsmeta.Dispose();
                }


                if (Request.UrlReferrer != null)
                {
                    string PreviousPageURL = Request.UrlReferrer.ToString();
                    string CurrentPageURL = Request.Url.ToString();
                    PreviousPageURLFinal = PreviousPageURL;
                    if (CurrentPageURL.IndexOf("horary") > -1)
                    {
                        if (PreviousPageURL.IndexOf("horary") == -1)
                        {
                            PreviousPageURLFinal = PreviousPageURL + "?groupid=horary";
                        }
                        else
                        {
                            PreviousPageURLFinal = PreviousPageURL;
                        }
                    }
                    if (CurrentPageURL.IndexOf("natal") > -1)
                    {
                        if (PreviousPageURL.IndexOf("natal") == -1)
                        {
                            PreviousPageURLFinal = PreviousPageURL + "?groupid=natal";
                        }
                        else
                        {
                            PreviousPageURLFinal = PreviousPageURL;
                        }
                    }
                }
            }
            if (Request.QueryString["catid"] != null && Request.QueryString["articleid"].ToString() != null)
            {
                CatId = Request.QueryString["catid"].ToString().Trim();
                ArticleID = Request.QueryString["articleid"].ToString().Trim();

                ds = obj_mc.GetArticles(CatId, "BOTH", ArticleID,"");
                if (ds.Tables[1].Rows.Count != 0)
                {
                    string Headline = ds.Tables[1].Rows[0]["HEADLINE"].ToString();
                    article_dtls = ds.Tables[1].Rows[0]["FULLSTORY"].ToString();
                    Cat_name = ds.Tables[2].Rows[0]["CAT_NAME"].ToString();
                    strHtml += "<div class='fullarticle_catname'><a href=\"" + ResolveUrl(PreviousPageURLFinal) + "\"><img src=\"" + ResolveUrl("~/Image/previous.png") + "\" alt='Back' title='Back' /></a>" + Cat_name + "<div style='float: right;cursor: pointer;' onClick=\"location.href='" + PreviousPageURLFinal + "';\">Back&nbsp;&nbsp;</div></div>";
                    if (Headline != "")
                    {
                        strHtml += "<h1 class='fullarticle_catname_h1' style='padding:0% 0% 0.5% 0%;'>" + Headline + "</h1>";
                    }
                    strHtml += "<div style='clear:both;'></div>";
                    strHtml += article_dtls;
                }
                fullarticle_id.InnerHtml = strHtml;
                ds.Dispose();
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(article_article_astrologer), "wq", "window.parent.location.href='login.aspx';", true);
            return;
        }
    }
}
