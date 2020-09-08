using ASTROLOGY.classesoracle;
using System;
using System.Data;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;

public partial class photogallery_showgallery : System.Web.UI.Page
{
    #region Declarations
    admin obj = new admin();
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
            if (Request.QueryString["q"] != null)
            {
                string ID = Request.QueryString["q"].ToString();
                BindGallery(ID);
            }
        }
    }
    #endregion

    #region Bind Gallery 
    protected void BindGallery(string ALbumID)
    {
        if (ALbumID == "") return;
        string ALbumIDVal = "";
        DataSet ds = new DataSet();
        StringBuilder strhtml = new StringBuilder();
        ds = obj.ManageAlbum("GET_GALLERY_BY_ALBUM_URL", ALbumID);
        if (ds.Tables[0].Rows.Count > 0)
        {
            ALbumIDVal = ds.Tables[0].Rows[0]["ALBUM_ID"].ToString();
            string AlbumName = ds.Tables[0].Rows[0]["HEADLINE"].ToString();
            divHeader.InnerHtml = "<h1 style='color: #F4600A;font-size: 1.4em;font-weight: bold;margin: 10px 0px 0px 0px;padding: 0px 0px 4px 0px;'>" + AlbumName + "<div style='float: right;cursor: pointer;' onClick=\"location.href='" + hdnPreviousURL.InnerText + "';\"><a href=\"" + ResolveUrl(hdnPreviousURL.InnerText) + "\"><img src=\"" + ResolveUrl("~/Image/previous.png") + "\" alt='Back' title='Back' /></a>&nbsp;Back&nbsp;&nbsp;</div></h1>";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string ImageURL = ds.Tables[0].Rows[i]["LARGE_IMG"].ToString();
                
                string Path = Page.ResolveUrl("gall_content/" + "/" + ImageURL).Replace("/photogallery", "");
                strhtml.Append("<figure class=\"col-xs-12 col-sm-6 col-md-4 gallery_margin2\" itemprop=\"associatedMedia\">");
                strhtml.Append("<a href =\"" + Path + "\" itemprop=\"contentUrl\" data-size=\"500x428\">");
                strhtml.Append("<img src =\"" + Path + "\" itemprop=\"thumbnail\" alt=\""+ ds.Tables[0].Rows[i]["DESCRIPTION"].ToString() + "\" Title=\"" + ds.Tables[0].Rows[i]["DESCRIPTION"].ToString() + "\" style=\"height: 250px;width: 340px;\"  class=\"img-responsive\" />");
                strhtml.Append("</a>");
                strhtml.Append("<figcaption itemprop =\"caption description\">");
                //strhtml.Append("<div class=\"capCamDiv\"><a href = \"#\" ><span class=\"fa fa-camera capCam\" aria-hidden=\"true\"></span></a></div>");
                strhtml.Append("<div class=\"capTxt\">" + ds.Tables[0].Rows[i]["DESCRIPTION"].ToString() + "</div>");
                strhtml.Append("</figcaption>");
                strhtml.Append(" </figure>");
             }
            divShowGallery.InnerHtml = strhtml.ToString();
        }
        DataSet dsAlbum = new DataSet();
        dsAlbum = obj.ManageAlbum("GET_ALBUM_BYID", ALbumIDVal);
        if (dsAlbum.Tables[0].Rows.Count > 0)
        {
            string KeyWords = dsAlbum.Tables[0].Rows[0]["META_KEYWORDS"].ToString();
            string DESCRIPTION = dsAlbum.Tables[0].Rows[0]["META_DESCRIPTION"].ToString();
            string TITLE = dsAlbum.Tables[0].Rows[0]["TITLE"].ToString();
            if (KeyWords != "")
            {
                //Add Keywords Meta Tag
                HtmlMeta keywords = new HtmlMeta();
                keywords.HttpEquiv = "keywords";
                keywords.Name = "keywords";
                keywords.Content = KeyWords;
                Page.Controls.Add(keywords);
                //Master.FindControl("head").Controls.Add(keywords);
            }

            if (TITLE != "")
            {
                Page.Title = TITLE + " | Astro Envision";
                //Add Description Meta Tag
                HtmlMeta description = new HtmlMeta();
                description.HttpEquiv = "description";
                description.Name = "description";
                description.Content = DESCRIPTION;
                Page.Controls.Add(description);
            }
            else
            {
                Page.Title = "Online Astrology and Consultancy, Prashna(Horary) Astrology";
                HtmlMeta description = new HtmlMeta();
                description.HttpEquiv = "description";
                description.Name = "description";
                description.Content = "Online Vedic Astrology Software generates multiple reports backed by Hundreds of Thousands of planetary combinations present in your birth Chart.";
                Page.Controls.Add(description);
            }

            string Domainurl = Request.Url.Scheme + System.Uri.SchemeDelimiter + Request.Url.Host;
            string url = Domainurl + HttpContext.Current.Request.RawUrl;
            HtmlLink tag = new HtmlLink();
            tag.Attributes.Add("rel", "canonical");
            tag.Href = url;
            //Header.Controls.Add(tag);  // This Line is used without Master Page
            Page.Controls.Add(tag); // This Line is used with Master Page

        }
    }
    #endregion
}