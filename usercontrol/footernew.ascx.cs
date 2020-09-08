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

public partial class usercontrol_footernew : System.Web.UI.UserControl
{
    myaccount obj_mc = new myaccount();
    DataSet ds = new DataSet();
    string InnerStr = "", InnerStr2;
    protected void Page_Load(object sender, EventArgs e)
    {
        getcomments();
        gettestimonials();
    }

    public void getcomments()
    {
        ds = obj_mc.GetArticles("3", "BOTH", "0","");
        if (ds.Tables[0].Rows.Count != 0)
        {
            InnerStr += "  <ul class=\"rslides\" id=\"slider3\">";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string NewsId = ds.Tables[0].Rows[i]["NEWS_ID"].ToString();
                string CatId = ds.Tables[0].Rows[i]["CATID"].ToString();
                string Headline = ds.Tables[0].Rows[i]["HEADLINE"].ToString();
                Headline = Regex.Replace(Headline, @"<[^>]+>|&nbsp;", "").Trim();
                Headline = Regex.Replace(Headline, @"\s{2,}", " ");
                string synopsis = ds.Tables[0].Rows[i]["SYNOPSIS"].ToString();
                //synopsis = Regex.Replace(synopsis, @"<[^>]+>|&nbsp;", "").Trim();
                //synopsis = Regex.Replace(synopsis, @"\s{2,}", " ");
                string authorimg = ds.Tables[0].Rows[i]["AUTHOR_IMG"].ToString();
                string author = ds.Tables[0].Rows[i]["AUTHOR"].ToString();
                InnerStr += "<li>";
                if (authorimg != "")
                {
                    InnerStr += "<div class=\"expert_photo\">";
                    //InnerStr += "<a href=\"" + ResolveUrl("~/news/" + newsid + "-" + headline_url + ".html") + "\">" + newshead + "";
                    InnerStr += "<a href=\"" + ResolveUrl("~/article/article.aspx?catid=" + CatId + "&articleid=" + NewsId + "") + "\">";
                    InnerStr += "<img src=\"" + ResolveUrl("~/Image/" + authorimg + "") + "\" alt=\"" + author + "\" title='" + author + "' />";
                    InnerStr += "</a>";
                    InnerStr += "</div>";
                }
                InnerStr += "<div class=\"expert_details\">";
                InnerStr += "<h1 class=\"expert_details_h1\"><a href=\"" + ResolveUrl("~/article/article.aspx?catid=" + CatId + "&articleid=" + NewsId + "") + "\">" + Headline + "</a></h1>";
                InnerStr += "<h3 class=\"expert_details_h3\">" + synopsis + "";
                InnerStr += "<a style=\"color: #6D6D6D;font-size: 1.1em;\" href=\"" + ResolveUrl("~/article/article.aspx?catid=" + CatId + "&articleid=" + NewsId + "") + "\">read more..</a>";
                InnerStr += "</h3>";
                InnerStr += "</div>";
                InnerStr += "</li>";
            }
            InnerStr += "</ul>";
            expertid.InnerHtml = InnerStr;
        }
        ds.Dispose();
    }

    public void gettestimonials()
    {
        ds = obj_mc.GetArticles("4", "BOTH", "0","");
        if (ds.Tables[0].Rows.Count != 0)
        {
            InnerStr2 += "<ul class=\"rslides\" id=\"slider4\">";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string NewsId = ds.Tables[0].Rows[i]["NEWS_ID"].ToString();
                string CatId = ds.Tables[0].Rows[i]["CATID"].ToString();
                string Headline = ds.Tables[0].Rows[i]["HEADLINE"].ToString();
                Headline = Regex.Replace(Headline, @"<[^>]+>|&nbsp;", "").Trim();
                Headline = Regex.Replace(Headline, @"\s{2,}", " ");
                string synopsis = ds.Tables[0].Rows[i]["SYNOPSIS"].ToString();
                //synopsis = Regex.Replace(synopsis, @"<[^>]+>|&nbsp;", "").Trim();
                //synopsis = Regex.Replace(synopsis, @"\s{2,}", " ");
                string authorimg = ds.Tables[0].Rows[i]["AUTHOR_IMG"].ToString();
                string author = ds.Tables[0].Rows[i]["AUTHOR"].ToString();
                InnerStr2 += "<li>";
                if (authorimg != "")
                {
                    InnerStr2 += "<div class=\"testimoni_photo\">";
                    //InnerStr += "<a href=\"" + ResolveUrl("~/news/" + newsid + "-" + headline_url + ".html") + "\">" + newshead + "";
                    InnerStr2 += "<a href=\"" + ResolveUrl("~/article/article.aspx?catid=" + CatId + "&articleid=" + NewsId + "") + "\">";
                    InnerStr2 += "<img src=\"" + ResolveUrl("~/Image/" + authorimg + "") + "\" alt=\"" + author + "\" title='" + author + "' />";
                    InnerStr2 += "</a>";
                    InnerStr2 += "</div>";
                }

                InnerStr2 += "<div class=\"testimoni_details\">";
                InnerStr2 += "<h1 class=\"testimoni_details_h1\"><a href=\"" + ResolveUrl("~/article/article.aspx?catid=" + CatId + "&articleid=" + NewsId + "") + "\">" + Headline + "</a></h1>";
                InnerStr2 += "<h3 class=\"testimoni_details_h3\">" + synopsis + "";
                InnerStr2 += "<a style=\"color: #6D6D6D;font-size: 1.1em;\" href=\"" + ResolveUrl("~/article/article.aspx?catid=" + CatId + "&articleid=" + NewsId + "") + "\">read more..</a>";
                InnerStr2 += "</h3>";
                InnerStr2 += "</div>";
                InnerStr2 += "</li>";
            }
            InnerStr2 += "</ul>";
            testimonialid.InnerHtml = InnerStr2;
        }
        ds.Dispose();
    }


}
