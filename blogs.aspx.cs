using System;
using System.Collections;
using System.Configuration;
using System.Data;
using ASTROLOGY.classesoracle;
using System.Web.UI.HtmlControls;
using System.Web;
using System.Threading;

public partial class blogs : System.Web.UI.Page
{

    #region Declarartions
    common Com_Obj = new common();
    blog obj_blog = new blog();
    DataTable dt = new DataTable();
    DataSet ds = new DataSet();
    string StrHtml = "";
    public int NoOfRow = 4 ;
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
            Thread.Sleep(3000);
            GetBlogList("4");
            Page.Title = "Blog" + " | Astro Envision";
            string Domainurl = Request.Url.Scheme + System.Uri.SchemeDelimiter + Request.Url.Host;
            string url = Domainurl + HttpContext.Current.Request.RawUrl;
            HtmlLink tag = new HtmlLink();
            tag.Attributes.Add("rel", "canonical");
            tag.Href = url;
            //Header.Controls.Add(tag);  // This Line is used without Master Page
            Master.FindControl("head").Controls.Add(tag); // This Line is used with Master Page
        //}
    }

    #endregion

    #region Blog List
    void GetBlogList(string NoOfRow)
    {
        try
        {
            ds = obj_blog.GetBlogList(NoOfRow, "GET_ALL_BLOGS_BY_PAGING", "", "A");
            if (ds.Tables[0].Rows.Count > 0)
            {
                string TotalCount = ds.Tables[0].Rows[0]["TOTALBLOGS"].ToString();
                if(Convert.ToInt32(NoOfRow) >= Convert.ToInt32(TotalCount))
                {
                    btnSubmit.Visible = false;
                }
                else
                    {
                    btnSubmit.Visible = true;
                }
                StrHtml = "<h1 class=\"fullarticle_catname\">Blog</h1><div style=\"clear: both;\"></div>";
                for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                {
                    string BlogId = ds.Tables[0].Rows[j]["BLOG_ID"].ToString().Trim();
                    string BlogTitle = ds.Tables[0].Rows[j]["HEADLINE"].ToString().Trim();
                    string BlogWrittenBy = ds.Tables[0].Rows[j]["WRITTEN_BY"].ToString().Trim();
                    string BlogDate = ds.Tables[0].Rows[j]["CREATED_DATE"].ToString().Trim();
                    string BlogSummary = ds.Tables[0].Rows[j]["SUMMARY"].ToString().Trim();
                    string BlogUrl = ds.Tables[0].Rows[j]["BLOG_URL"].ToString().Trim();
                    string BlogImg = ds.Tables[0].Rows[j]["IMAGE"].ToString();

                    BlogUrl = "~/blog/" + BlogUrl + ".html";
                    StrHtml += "<div class='mt-2 pb-1' style='border-bottom: 1px dashed #d0d0d0;'>";
                    //StrHtml += "<div style='clear:both;'></div>";
                    
                    //StrHtml += "<div style='clear:both;'></div>";
                    
                    if (BlogImg != "")
                    {
                        StrHtml += "<p><a title=\"" + BlogTitle + "\" style = 'color:#F4600A;' href =\"" + ResolveUrl(BlogUrl) + "\">";
                        StrHtml += "<img class='mr-2' style=\"max-width:90px;border-radius: 20px;float: left;\" src=\"" + ResolveUrl("~/gall_content/" + BlogImg + "") + "\" alt=\"" + BlogTitle + "\" title='" + BlogTitle + "' />";
                        StrHtml += "</a></p>";
                    }
                    else
                    {
                        StrHtml += "<p><a title=\"" + BlogTitle + "\" style='color:#F4600A;' href =\"" + ResolveUrl(BlogUrl) + "\">";
                        StrHtml += "<img class='mr-2' style=\"max-width:90px;border-radius: 20px;float: left;\" src=\"" + ResolveUrl("~/img/Default.jpg") + "\"  alt=\"" + BlogTitle + "\" title='" + BlogTitle + "' />";
                        StrHtml += "</a></p>";
                    }
                    StrHtml += "<h2>";
                    StrHtml += "<a title=\"" + BlogTitle + "\" href=\"" + ResolveUrl(BlogUrl) + "\">" + BlogTitle + "</a>";
                    StrHtml += "</h2>";
                    StrHtml += "<span style='font-weight:600;'>By " + BlogWrittenBy + " Date On: " + BlogDate + "</span>";
                    StrHtml += "<div class='fullarticle_summary'>";
                    StrHtml += "<p>" + BlogSummary + "<a rel=\"nofollow\" style='color:#F4600A;font-weight: 600;' title=\"Read More...\" href=\"" + ResolveUrl(BlogUrl) + "\">&nbsp;Read More...</a></p>";
                    StrHtml += "</div>";
                    StrHtml += "</div>";
                }
                StrHtml += "<div style='clear:both;'></div>";
                blogdivid.InnerHtml = StrHtml;
            }
            ds.Dispose();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion

    #region Load More Click
    protected void btnSubmit_Click(object sender , EventArgs e)
    {
        string Count = hdnCount.Value;
        if(Count == "")
        {
            Count = "4";
        }
        NoOfRow = NoOfRow + Convert.ToInt32(Count);
        hdnCount.Value = Convert.ToString(NoOfRow);
        GetBlogList(hdnCount.Value);
    }
    #endregion
}