using System;
using System.Data;
using ASTROLOGY.classesoracle;
using System.Web;
using System.Web.UI.HtmlControls;

public partial class blog_details : System.Web.UI.Page
{
    #region Declarations
    common Com_Obj = new common();
    blog obj_blog = new blog();
    DataTable dt = new DataTable();
    DataSet ds = new DataSet();
    string StrHtml = "";
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["blogid"] != null)
            {
                GetBlogDetails(Request.QueryString["blogid"].ToString());
            }
        }
    }
    #endregion

    #region Blog Details
    void GetBlogDetails(string BlogId)
    {
        try
        {
            ds = obj_blog.GetBlogList(BlogId, "GET_BLOG_DETAILS_BY_URL","","");
            if (ds.Tables[0].Rows.Count > 0)
            {
                StrHtml = "<h1 class=\"fullarticle_catname\">Blog</h1><div style=\"clear: both;\"></div>";
                for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                {
                    Page.Title = ds.Tables[0].Rows[j]["TITLE"].ToString().Trim() + " | Astro Envision";
                    string Domainurl = Request.Url.Scheme + System.Uri.SchemeDelimiter + Request.Url.Host;
                    string url = Domainurl + HttpContext.Current.Request.RawUrl;
                    HtmlLink tag = new HtmlLink();
                    tag.Attributes.Add("rel", "canonical");
                    tag.Href = url;
                    //Header.Controls.Add(tag);  // This Line is used without Master Page
                    Master.FindControl("head").Controls.Add(tag); // This Line is used with Master Page

                    var form = (HtmlForm)this.Master.FindControl("form1");
                    form.Action = url;

                    string Blog_Id = ds.Tables[0].Rows[j]["BLOG_ID"].ToString().Trim();
                    string BlogTitle = ds.Tables[0].Rows[j]["HEADLINE"].ToString().Trim();
                    string BlogWrittenBy = ds.Tables[0].Rows[j]["WRITTEN_BY"].ToString().Trim();
                    string BlogDate = ds.Tables[0].Rows[j]["CREATED_ON"].ToString().Trim();
                    string BlogDesc = ds.Tables[0].Rows[j]["DESCRIPTION"].ToString().Trim();
                    string BlogImg = ds.Tables[0].Rows[j]["IMAGE"].ToString();
                    string BlogUrl = Com_Obj.ReplaceQuotes(BlogTitle);
                    BlogUrl = Com_Obj.OptimizeURL(BlogUrl);
                    BlogUrl = "~/blog/" + BlogUrl + ".html";
                    StrHtml += "<div class='mt-2 pb-1' style='border-bottom: 1px dashed #d0d0d0;'>";
                    if (BlogImg != "")
                    {
                        StrHtml += "<p>";
                        StrHtml += "<img class='mr-2' style=\"max-width:135px;border-radius: 20px;float: left;\" src=\"" + ResolveUrl("~/gall_content/" + BlogImg + "") + "\" alt=\"" + BlogTitle + "\" title='" + BlogTitle + "' />";
                        StrHtml += "</p>";
                    }
                    StrHtml += "<h2> "+ BlogTitle + "</h2>";
                     StrHtml += "<span style='font-weight:600;'>By " + BlogWrittenBy + " Date On: " + BlogDate + "</span>";
                    StrHtml += "<div class='fullarticle'>";
                    StrHtml += "<p>" + BlogDesc + "</p>";
                    StrHtml += "</div>";
                    StrHtml += "</div>";
                    //BlogUrl = "~/blog/" + BlogUrl + "/" + BlogId + ".html";
                    //if (BlogImg != "")
                    //{
                    //    StrHtml += "<p><a style = 'color:#F4600A;' href =\"" + ResolveUrl(BlogUrl) + "\">";
                    //    StrHtml += "<img class='mr-2' style=\"max-width:110px;border-radius: 20px;float: left;\" src=\"" + ResolveUrl("~/gall_content/" + BlogImg + "") + "\" alt=\"" + BlogTitle + "\" title='" + BlogTitle + "' />";
                    //    StrHtml += "</a></p>";
                    //}
                    //StrHtml += "<div style='margin: 0 0 1rem 0;'>";
                    //StrHtml += "<h2 class='fullarticle_catname_h1'><strong>";
                    //StrHtml += "<a href=\"" + ResolveUrl(BlogUrl) + "\">";
                    //StrHtml += "" + BlogTitle + "";
                    //StrHtml += "</a>";
                    //StrHtml += "</strong></h2>";
                    //StrHtml += "<div style='clear:both;'></div>";
                    //StrHtml += "<div style='float:left; margin:0% 0% 0% 0%'><p><strong>By " + BlogWrittenBy + " Date On: " + BlogDate + "</strong></p></div>";
                    //StrHtml += "<div style='clear:both;'></div>";
                    //StrHtml += "<div>" + BlogDesc + "</div>";
                    //StrHtml += "</div>";
                }

                StrHtml += "<div style='clear:both;'></div>";
                blogdetailsid.InnerHtml = StrHtml;
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