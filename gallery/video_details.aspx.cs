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
using ASTROLOGY.classesoracle;
using System.IO;
using System.Net;

public partial class gallery_video_details : System.Web.UI.Page
{
    main obj_main = new main();
    DataSet ds = new DataSet();
    string gallid = "", groupid = "",albumid="0";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Request.QueryString["gallid"] != null && Request.QueryString["gallid"] != "")
            {
                dvPhoto.Visible = true;
                gallid = Request.QueryString["gallid"].ToString();
                groupid = Request.QueryString["groupid"].ToString().ToUpper();
                GetVideo(groupid, 1, 1, Convert.ToInt32(gallid), "GALLERY");  //End Users
            }
            else if (Request.QueryString["groupid"] != null && Request.QueryString["groupid"] != "")
            {
                groupid = Request.QueryString["groupid"].ToString().ToUpper();
                albumid = Request.QueryString["albumid"].ToString();
                GetEndUserVideos(groupid, 1, 1, Convert.ToInt32(albumid), "ALLGALLERY");  //End Users
                dvPhoto.Visible = false;
            }
        }
    }

    void GetEndUserVideos(string groupid, int userid, int langid, int albumid, string flag)
    {
        ds = obj_main.GetAstrologyVideos(groupid, userid, langid, albumid, flag);
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string GallId = ds.Tables[0].Rows[i]["GALL_ID"].ToString().Trim();
                string HEADLINE = ds.Tables[0].Rows[i]["HEADLINE"].ToString().Trim();
                string Group = groupid + " Videos";
                HEADLINE = obj_main.replaceQoute(HEADLINE);
                string Alias = HEADLINE;
                Alias = obj_main.optimizeURL(Alias);
                if(i==0)
                {
                    video_h1Id.InnerHtml = "<h1 class=\"video_h1\"><img src=\"" + ResolveUrl("~/Image/previous.png") + "\" onclick=\"window.history.back();\" alt='Back' title='Back' />" + Group.ToLower() + "</h1>";
                }
                EndUserVideoId.InnerHtml += "<h2 class=\"video_h2\"><a href=\"" + ResolveUrl("~/videogallery/" + groupid.ToLower() + "/" + Alias + "/" + GallId + ".html") + "\">" + HEADLINE + "</a></h2>";
            }
        }
        ds.Dispose();
    }

    void GetVideo(string groupid, int userid, int langid, int albumid, string flag)
    {
        string strGallery = "";
        ds = obj_main.GetAstrologyVideos(groupid, userid, langid, albumid, flag);
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string GallId = ds.Tables[0].Rows[i]["GALL_ID"].ToString().Trim();
                string headline = ds.Tables[0].Rows[i]["HEADLINE"].ToString().Trim();
                headline = obj_main.replaceQoute(headline);
                string caption = ds.Tables[0].Rows[i]["CAPTION"].ToString().Trim();
                caption = obj_main.replaceQoute(caption);
                string filename = ds.Tables[0].Rows[i]["VIDEO_URL"].ToString().Trim();
                string thumbimg = ds.Tables[0].Rows[i]["THUMB_IMG"].ToString().Trim();
                string largeimg = ds.Tables[0].Rows[i]["LARGE_IMG"].ToString().Trim();

                string Group = groupid + " Videos";
                video_h1Id.InnerHtml = "<h1 class=\"video_h1\"><img src=\"" + ResolveUrl("~/Image/previous.png") + "\" onclick=\"window.history.back();\" alt='Back' title='Back' />" + Group.ToLower() + "</h1>";

                if (filename.IndexOf(".txt") > -1)
                {
                    filename = obj_main.getpath(filename);
                    //filename = ReadTxtFile("http://localhost/astrology/" + filename + "");
                    filename = File.ReadAllText(Server.MapPath("~/" + filename));
                    if (filename.IndexOf("<iframe") > -1 || filename.IndexOf("<embed") > -1 || filename.IndexOf("<object") > -1)
                    {
                        strGallery = "" + filename + "";
                    }
                    else if (filename.IndexOf("watch?v") > -1)
                    {
                        var rgx = new System.Text.RegularExpressions.Regex(@"(?:https?:\/\/)?(?:www\.)?(?:(?:(?:youtube.com\/watch\?[^?]*v=|youtu.be\/)([\w\-]+))(?:[^\s?]+)?)");
                        var result = rgx.Replace(filename, "<iframe width=\"640\" height=\"360\" src=\"//www.youtube.com/embed/$1\" frameborder=\"0\" allowfullscreen=\"\"></iframe>");
                        strGallery = result;
                    }
                }
                else
                {
                    strGallery += "<video width=\"600\" height=\"400\" controls>";
                    strGallery += "<source src=\"http://localhost/astrology/gall_content/2015/9/2015_9$video101_Tuesday_2015_171511177gallery.MP4\" type=\"video/mp4\">";
                    strGallery += "Your browser does not support the video tag.";
                    strGallery += "</video>";
                }
            }
            dvPhoto.InnerHtml = strGallery;
        }
        ds.Dispose();
    }

    private string ReadTxtFile(string url)
    {
        WebRequest request = WebRequest.Create(url);
        WebResponse response = request.GetResponse();
        Stream stream = response.GetResponseStream();
        StreamReader reader = new StreamReader(stream);
        string result = reader.ReadToEnd();
        stream.Dispose();
        reader.Dispose();
        return result;
    }
}
