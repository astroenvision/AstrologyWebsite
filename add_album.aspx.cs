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
using AjaxControlToolkit;
using System.IO;
using System.Diagnostics;
using ASTROLOGY.classesoracle;
using System.Web.Services;


public partial class add_album : System.Web.UI.Page
{
    main obj_main = new main();
    DataSet ds = new DataSet();
    string[] videoExt = new string[] { "flv", "avi", "wmv", "3gp", "mp4", "txt", "mpeg", "mpg","MP4","AVI","FLV","MPEG","MPG" };
    string[] imgExt = new string[] { "jpg", "gif", "png", "bmp", "jpeg", "JPG", "JPEG" };
    string[] audioExt = new string[] { "mp3", "wave" };
    string strFilename1 = "", strFilename2 = "", today_date = "", strMessage1="";
    public int dd_sys, mm_sys, yyyy_sys;

    string headline = "", desc = "", caption = "", status = "A", groupid = "", user_type="";
    int album_id = 0, priority = 0, langid = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string system_date = System.DateTime.Now.ToString();
            String[] split_date = system_date.Split('/');
            string mm = split_date[0];
            string dd = split_date[1];
            string yyyy = split_date[2];
            string final_date = dd + "/" + mm + "/" + yyyy.Substring(0, 4);

            dd_sys = Convert.ToInt32(dd);
            mm_sys = Convert.ToInt32(mm);
            yyyy_sys = Convert.ToInt32(yyyy.Substring(0, 4));

            if (!Page.IsPostBack)
            {
                for (int i = 0; i <= 20; i++)
                {
                    ddlpriority.Items.Add(i.ToString());
                }
                hdncrtdby.Value = "astrology";
                obj_main.check_year_folder(yyyy_sys, mm_sys);
                BindAbums();
            }

            ScriptManager.GetCurrent(this.Page).RegisterPostBackControl(Repeater1);
            if (!IsPostBack && !IsCallback && !ajaxFileUploadAttachments.IsInFileUploadPostBack) // Need to prevent normal stuff on ajaxFileUpload PostBack
            {
                ds = obj_main.GetMaxId("GALL_ID", "GALLERY_MST");
                int gallmaxid = 0;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    gallmaxid = Convert.ToInt32(ds.Tables[0].Rows[0]["MAXID"].ToString().Trim());
                    hdnmaxgallid.Value = gallmaxid.ToString();
                }
                ds.Dispose();
            }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        try
        {
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    void BindAbums()
    {
        try
        {
            DataSet dsc = new DataSet();
            dsc = obj_main.GetGallery(0, "ALBUMGET");
            if (dsc.Tables[0].Rows.Count > 0)
            {
                ddlalbums.DataSource = dsc;
                ddlalbums.DataValueField = "ALBUM_ID";
                ddlalbums.DataTextField = "ALBUM_NAME";
                ddlalbums.DataBind();
                ddlalbums.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            else
            {
                ddlalbums.Items.Clear(); ddlalbums.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            dsc.Dispose();
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
    }
    protected void ajaxFileUploadAttachments_UploadComplete(object sender, AjaxFileUploadEventArgs e)
    {
        string videopath = "", videoscriptpath = "", photopath = "";

        today_date = DateTime.Now.ToString("dd dddd yyyy HH:mm:ss:fff");
        today_date = today_date.Replace(":", "");

        ds = obj_main.GetMaxId("GALL_ID", "GALLERY_MST");
        int gallmaxid=0;
        if (ds.Tables[0].Rows.Count > 0)
        {
            gallmaxid = Convert.ToInt32(ds.Tables[0].Rows[0]["MAXID"].ToString().Trim());
        }
        ds.Dispose();

        string extn = e.FileName;
        string upFileName = e.FileName;
        String[] splitname = extn.Split('.');
        extn = splitname[1].ToString();
        if (imgExt.Contains(extn))
        {
            strFilename1 = yyyy_sys + "_" + mm_sys + "$thumbimg" + "1" + today_date + "gallery" + "." + extn;
            strFilename1 = strFilename1.Replace(" ", "_");

            strFilename2 = yyyy_sys + "_" + mm_sys + "$largeimg" + "1" + today_date + "gallery" + "." + extn;
            strFilename2 = strFilename2.Replace(" ", "_");

            photopath = Server.MapPath("gall_content/" + yyyy_sys + "/" + mm_sys + "/") + strFilename2;
            ajaxFileUploadAttachments.SaveAs(photopath);

            string large = Server.MapPath("gall_content/" + yyyy_sys + "/" + mm_sys + "/" + strFilename2);
            string thumb = Server.MapPath("gall_content/" + yyyy_sys + "/" + mm_sys + "/" + strFilename1);
            System.IO.File.Copy(large, thumb);
        }
        else if (videoExt.Contains(extn) && e.FileSize < 70000000)
        {
            if (extn == "txt")
            {
                string thumbimg = "", largeimg = "", videofile = "";
                strMessage1 = yyyy_sys + "_" + mm_sys + "$Object" + "1" + today_date + "gallery" + "." + extn + "";
                strMessage1 = strMessage1.Replace(" ", "_");
                videofile = strMessage1;

                videopath = Server.MapPath("gall_content/" + yyyy_sys + "/" + mm_sys + "/") + strMessage1;
                ajaxFileUploadAttachments.SaveAs(videopath);

                videoscriptpath = File.ReadAllText(videopath);
                if (videoscriptpath.Contains("embed"))
                {
                    videoscriptpath = videoscriptpath.Replace("/v/", "$");
                    videoscriptpath = videoscriptpath.Replace("/embed/", "$");
                    String[] splitobject = videoscriptpath.Split('$');
                    videoscriptpath = splitobject[1].ToString();
                    splitobject = videoscriptpath.Split('?');
                    videoscriptpath = splitobject[0].ToString();
                    largeimg = "http://img.youtube.com/vi/" + videoscriptpath + "/0.jpg";
                    thumbimg = "http://img.youtube.com/vi/" + videoscriptpath + "/1.jpg";
                }
                else
                {
                    String[] GetNewfine = videoscriptpath.Split('?');
                    string Getinoval = GetNewfine[1].ToString();
                    largeimg = "http://img.youtube.com/vi/" + Getinoval.Replace("v=", "") + "/0.jpg";
                    thumbimg = "http://img.youtube.com/vi/" + Getinoval.Replace("v=", "") + "/1.jpg";
                }

                obj_main.Save_AlbumGallery(gallmaxid, headline, desc, caption, videofile, largeimg, thumbimg, album_id, status, priority, groupid, user_type, langid);

            }
            else
            {
                string thumbimg = "", largeimg = "", videofile = "";
                thumbimg = yyyy_sys + "_" + mm_sys + "$thumbimg" + "1" + today_date + "gallery" + ".jpg";
                thumbimg = thumbimg.Replace(" ", "_");

                largeimg = yyyy_sys + "_" + mm_sys + "$largeimg" + "1" + today_date + "gallery" + ".jpg";
                largeimg = largeimg.Replace(" ", "_");

                videofile = yyyy_sys + "_" + mm_sys + "$video" + "1" + today_date + "gallery" + "." + extn;
                videofile = videofile.Replace(" ", "_");

                videopath = Server.MapPath("gall_content/" + yyyy_sys + "/" + mm_sys + "/") + videofile;
                ajaxFileUploadAttachments.SaveAs(videopath);

                MakeThumbImgFromVideo(Server.MapPath("gall_content/" + yyyy_sys + "/" + mm_sys + "/") + videofile, Server.MapPath("gall_content/" + yyyy_sys + "/" + mm_sys + "/") + thumbimg);

                MakeLargeImgFromVideo(Server.MapPath("gall_content/" + yyyy_sys + "/" + mm_sys + "/") + videofile, Server.MapPath("gall_content/" + yyyy_sys + "/" + mm_sys + "/") + largeimg);

                obj_main.Save_AlbumGallery(gallmaxid, headline, desc, caption, videofile, largeimg, thumbimg, album_id, status, priority, groupid, user_type, langid);

            }
        }
        else if (audioExt.Contains(extn))
        {

        }
    }
    protected void updatePanelAttachments_Load(object sender, EventArgs e)
    {
        int initialid = 0;
        if (hdnmaxgallid.Value != "")
        {
            initialid = Convert.ToInt32(hdnmaxgallid.Value);
        }
        if (initialid != 0)
        {
            System.Threading.Thread.Sleep(1000);
            ds = obj_main.GetGallery(initialid, "GALLERY");
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
        }
        ds.Dispose();
    }
    protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.AlternatingItem ||
                                e.Item.ItemType == ListItemType.Item)
        {
            System.Threading.Thread.Sleep(1000);
            Image image1 = (Image)e.Item.FindControl("img1");
            HiddenField lblimg = (HiddenField)e.Item.FindControl("lblthumbimg");
            string imgpath = lblimg.Value;
            if (imgpath != "")
            {
                if (imgpath.Contains("gallery"))
                {
                    imgpath = obj_main.getpath(imgpath);
                    image1.ImageUrl = ResolveUrl("~/"+imgpath+"");
                }
                else
                {
                    image1.ImageUrl = imgpath;
                }
            }
        }
    }
    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "Delete")
            {
                DataSet dsdel = new DataSet(); string image = "", content = "", obj = "";
                dsdel = obj_main.GetGallery(Convert.ToInt32(e.CommandArgument), "GALLERYGET");
                if (dsdel.Tables[0].Rows.Count > 0)
                {
                    image = dsdel.Tables[0].Rows[0]["THUMB_IMG"].ToString();
                    content = dsdel.Tables[0].Rows[0]["LARGE_IMG"].ToString();
                    obj = dsdel.Tables[0].Rows[0]["VIDEO_URL"].ToString();
                    if (image != "")
                    {
                        if (image.Contains("gallery"))
                        {
                            image = ResolveUrl("~/" + obj_main.getpath(image));
                            File.Delete(Server.MapPath(image));
                        }
                    }
                    if (content != "")
                    {
                        content = ResolveUrl("~/" + obj_main.getpath(content));
                        File.Delete(Server.MapPath(content));
                    }
                    if (obj != "")
                    {
                        content = ResolveUrl("~/" + obj_main.getpath(content));
                        obj = ResolveUrl("~/" + obj_main.getpath(obj));
                        File.Delete(Server.MapPath(obj));
                    }
                }
                dsdel.Dispose();
                obj_main.DeleteAlbumGallery(Convert.ToInt32(e.CommandArgument), "DELETEGALLERY");
                int initialid = Convert.ToInt32(hdnmaxgallid.Value);
                if (initialid != 0)
                {
                    ds = obj_main.GetGallery(initialid, "GALLERY");
                    Repeater1.DataSource = ds;
                    Repeater1.DataBind();
                }
            }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }

    public static void MakeThumbImgFromVideo(string VideoFilePath, string ThumbImagePath)
    {
        try
        {
            string ThumbImgSize = "150x100";
            string ffmpeg = System.Web.HttpContext.Current.Server.MapPath("~/gallery/ffmpeg.exe");
            Process pss = new Process();
            pss.StartInfo.FileName = ffmpeg;
            if (VideoFilePath.IndexOf("flv") > -1 || VideoFilePath.IndexOf("FLV") > -1)
            {
                pss.StartInfo.Arguments = "   -i " + VideoFilePath + " -y -f image2 -ss 00:00:05 -s  " + ThumbImgSize.Trim() + "   " + ThumbImagePath;
            }
            if (VideoFilePath.IndexOf("mp4") > -1 || VideoFilePath.IndexOf("MP4") > -1)
            {
                pss.StartInfo.Arguments = "  -ss 00:00:05 -i  " + VideoFilePath + " -s " + ThumbImgSize.Trim() + " -vframes 1 " + ThumbImagePath;
            }
            pss.Start();
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }

    public static void MakeLargeImgFromVideo(string VideoFilePath, string LargeImagePath)
    {
        try
        {
            string LargeImgSize = "600x400";
            string ffmpeg = System.Web.HttpContext.Current.Server.MapPath("~/gallery/ffmpeg.exe");
            Process psslarge = new Process();
            psslarge.StartInfo.FileName = ffmpeg;
            if (VideoFilePath.IndexOf("flv") > -1 || VideoFilePath.IndexOf("FLV") > -1)
            {
                psslarge.StartInfo.Arguments = "   -i " + VideoFilePath + " -y -f image2 -ss 00:00:05 -s  " + LargeImgSize.Trim() + "   " + LargeImagePath;
            }
            if (VideoFilePath.IndexOf("mp4") > -1 || VideoFilePath.IndexOf("MP4") > -1)
            {
                psslarge.StartInfo.Arguments = "  -ss 00:00:05 -i  " + VideoFilePath + " -s " + LargeImgSize.Trim() + " -vframes 1 " + LargeImagePath;
            }
            psslarge.Start();
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }

    [WebMethod]
    public static string Save_Album(int catid, string albumname, string keywords, string desc, string crtdby, string status, int priority,string groupid, string user_type, int langid)
    {
        main obj = new main();
        DataSet dsm = new DataSet();
        dsm = obj.GetMaxId("ALBUM_ID", "ALBUM_MST");
        int albummaxid = 0;
        if (dsm.Tables[0].Rows.Count > 0)
        {
            albummaxid = Convert.ToInt32(dsm.Tables[0].Rows[0]["MAXID"].ToString().Trim());
        }
        dsm.Dispose();
        string Coverimg = "", thumbimg = "";
        obj.Save_Album(albummaxid, catid, albumname, Coverimg, thumbimg, keywords, desc, crtdby, status, priority, "F", "F", groupid, user_type, langid);
        return albummaxid.ToString();
    }

    [WebMethod]
    public static string Update_AlbumGallery(int albumid,int gallid,string caption, string thumbimg, string largeimg,string flag)
    {
        main obj = new main();
        DataSet dsm = new DataSet();
        obj.UpdateAlbumGallery(albumid, gallid, caption, thumbimg, largeimg, flag);
        return "";
    }
}
