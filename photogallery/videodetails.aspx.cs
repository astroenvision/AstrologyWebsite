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

public partial class photogallery_videodetails : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    myaccount obj_mc = new myaccount();
    string CatId = "", ArticleID = "";
    string article_dtls = "", Cat_name = "";
    string strHtml = "";
    string PreviousPageURLFinal = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
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

        //if (Request.QueryString["catid"] != null && Request.QueryString["articleid"].ToString() != null)
        //{
            //CatId = Request.QueryString["catid"].ToString().Trim();
            //ArticleID = Request.QueryString["articleid"].ToString().Trim();

            //ds = obj_mc.GetArticles(CatId, "BOTH", ArticleID);
            //if (ds.Tables[1].Rows.Count != 0)
            //{
                //string Headline = ds.Tables[1].Rows[0]["HEADLINE"].ToString();
                //article_dtls = ds.Tables[1].Rows[0]["FULLSTORY"].ToString();
                //Cat_name = ds.Tables[2].Rows[0]["CAT_NAME"].ToString();
                string Cat_name = "Astro Envision Inauguration October 11th,2016";
                string Headline = "";
                strHtml += "<div class='fullarticle_catname'><a href=\"" + ResolveUrl(PreviousPageURLFinal) + "\"><img src=\"" + ResolveUrl("~/Image/previous.png") + "\" alt='Back' title='Back' /></a>" + Cat_name + "<div style='float: right;cursor: pointer;' onClick=\"location.href='" + PreviousPageURLFinal + "';\">Back&nbsp;&nbsp;</div></div>";
                strHtml += "<h1 class='fullarticle_catname_h1' style='padding:0% 0% 0.5% 0%;'>" + Headline + "</h1>";
                strHtml += "<div style='clear:both;'></div>";
                strHtml += article_dtls;
            //}
            fullarticle_id.InnerHtml = strHtml;
            //ds.Dispose();
       // }


    }
}
