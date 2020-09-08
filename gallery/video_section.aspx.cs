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

public partial class gallery_video_section : System.Web.UI.Page
{
    main obj_main = new main();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //UserIDs
            //For ASTROLOGER == 1
            //For END USER == 2

            //LangIDs
            //For ENGLISH == 1
            //For HINDI == 2
            GetEndUserNatalEnglishVideos("NATAL", 1, 1, 0, "ALBUM");  //End Users
            GetEndUserNatalHindiVideos("NATAL", 1, 2, 0, "ALBUM");   //End Users
            GetEndUserHoraryEnglishVideos("HORARY", 1, 1, 0, "ALBUM");   //End Users
            GetEndUserHoraryHindiVideos("HORARY", 1, 2, 0, "ALBUM");   //End Users
        }   
    }

    void GetEndUserNatalEnglishVideos(string groupid,int userid,int langid,int albumid,string flag)
    {
        ds = obj_main.GetAstrologyVideos(groupid, userid, langid, albumid, flag);
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string AlbumId = ds.Tables[0].Rows[i]["ALBUM_ID"].ToString().Trim();
                string AlbumName = ds.Tables[0].Rows[i]["ALBUM_NAME"].ToString().Trim();
                AlbumName = obj_main.replaceQoute(AlbumName);
                groupid = obj_main.replaceQoute(groupid).ToLower();
                string Alias = AlbumName;
                Alias = obj_main.optimizeURL(Alias);
                UserNatalEngId.InnerHtml += "<h2 class=\"video_h2\"><a href=\"" + ResolveUrl("~/video/" + groupid + "/" + Alias + "/" + AlbumId + ".html") + "\">" + AlbumName + "</a></h2>";
            }
        }
        ds.Dispose();
    }

    void GetEndUserNatalHindiVideos(string groupid, int userid, int langid, int albumid, string flag)
    {
        ds = obj_main.GetAstrologyVideos(groupid, userid, langid, albumid, flag);
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //string albumid = ds.Tables[0].Rows[i]["ALBUM_ID"].ToString().Trim();
                string albumname = ds.Tables[0].Rows[i]["ALBUM_NAME"].ToString().Trim();
                UserNatalHindiId.InnerHtml += "<h2 class=\"video_h2\"><a href=\"#\">" + albumname + "</a></h2>";
            }
        }
        ds.Dispose();
    }

    void GetEndUserHoraryEnglishVideos(string groupid, int userid, int langid, int albumid, string flag)
    {
        ds = obj_main.GetAstrologyVideos(groupid, userid, langid, albumid, flag);
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //string albumid = ds.Tables[0].Rows[i]["ALBUM_ID"].ToString().Trim();
                string albumname = ds.Tables[0].Rows[i]["ALBUM_NAME"].ToString().Trim();
                UserHoraryEngId.InnerHtml += "<h2 class=\"video_h2\"><a href=\"#\">" + albumname + "</a></h2>";
            }
        }
        ds.Dispose();
    }

    void GetEndUserHoraryHindiVideos(string groupid, int userid, int langid, int albumid, string flag)
    {
        ds = obj_main.GetAstrologyVideos(groupid, userid, langid, albumid, flag);
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //string albumid = ds.Tables[0].Rows[i]["ALBUM_ID"].ToString().Trim();
                string albumname = ds.Tables[0].Rows[i]["ALBUM_NAME"].ToString().Trim();
                UserHoraryHindiId.InnerHtml += "<h2 class=\"video_h2\"><a href=\"#\">" + albumname + "</a></h2>";
            }
        }
        ds.Dispose();
    }
}
