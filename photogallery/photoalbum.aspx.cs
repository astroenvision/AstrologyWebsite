using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class photogallery_photoalbum : System.Web.UI.Page
{
    #region Declarations
    admin obj = new admin();
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindAlbums();
        }
    }
    #endregion

    #region Bind Albums 
    protected void BindAlbums()
    {
        DataSet ds = new DataSet();
        StringBuilder strhtml = new StringBuilder();
        ds = obj.ManageAlbum("GET_ALBUM", "");
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string AlbumURL = ds.Tables[0].Rows[i]["ALBUM_URL"].ToString();
                string ImageURL = ds.Tables[0].Rows[i]["COVER_IMG"].ToString();
                string AlbumName = ds.Tables[0].Rows[i]["ALBUM_NAME"].ToString();
                string Path = Page.ResolveUrl("gall_content/" + "/" + ImageURL).Replace("/photogallery", "");
                strhtml.Append("<figure class=\"col-xs-12 col-sm-6 col-md-4 gallery_margin2\" itemprop=\"associatedMedia\">");
                strhtml.Append("<a style='cursor:pointer;' onclick=\"RedirectToAlbum('" + AlbumURL.ToString() + "');\" itemprop=\"contentUrl\" data-size=\"500x428\" title=\"" + AlbumName + "\">");
                strhtml.Append("<img src =\""+ Path  + "\" itemprop=\"thumbnail\" alt=\"" + AlbumName + "\" title=\"" + AlbumName + "\" style=\"height: 250px;width: 350px;border-radius:5px;\"  class=\"img-responsive\" />");
                strhtml.Append("</a>");
                strhtml.Append("<figcaption itemprop =\"caption description\">");
                strhtml.Append("<div class=\"capCamDiv\"><a style='cursor:pointer;' onclick=\"RedirectToAlbum('" + AlbumURL.ToString() + "');\" title=\"" + AlbumName + "\"><span class=\"fa fa-camera capCam\" aria-hidden=\"true\"></span></a></div>");
                strhtml.Append("<div onclick=\"RedirectToAlbum('"+ AlbumURL.ToString() + "');\" class=\"capTxt\">" + AlbumName + "</div>");
                strhtml.Append("</figcaption>");
                strhtml.Append(" </figure>");
         
            }
            divShowAlbum.InnerHtml = strhtml.ToString();
        }
    }
    #endregion
}