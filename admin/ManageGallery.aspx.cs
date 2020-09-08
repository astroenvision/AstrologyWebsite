using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_ManageGallery : System.Web.UI.Page
{
    #region Declarations
    admin obj = new admin();
    common common = new common();
    ASTROLOGY.classesoracle.main obj_main = new ASTROLOGY.classesoracle.main();
    public int dd_sys, mm_sys, yyyy_sys;
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    public string AdminUserId = "", AdminEmailId = "";
    #endregion

    #region PageLoad
    protected void Page_Load(object sender, EventArgs e)
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
        if (AdminStateManagement == "COOKIE")
        {
            if (Request.Cookies["AdminCookies"] != null)
            {
                AdminUserId = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
                if (!Page.IsPostBack)
                {
                    
                }
            }
            else
            {
                Response.Redirect(ResolveUrl("~/admin"));
            }
        }
        else
        {
            if (Session["AdminUserId"] != null)
            {
                AdminUserId = Session["AdminUserId"].ToString();
                if (!Page.IsPostBack)
                {
                    
                }
            }
            else
            {
                Response.Redirect(ResolveUrl("~/admin"));
                return;
            }
        }
    }
    #endregion

    #region Bind Grid
    protected void BindGrid()
    {
        DataSet ds = new DataSet();
        ds = obj.ManageAlbum("GET_GALLERY", ddlAlbum.SelectedValue);
        if (ds.Tables[0].Rows.Count > 0)
        {
            grdData.DataSource = ds;
            grdData.DataBind();
        }
        else
        {
            grdData.DataSource = ds;
            grdData.DataBind();
        }
        ds.Dispose();

    }
    #endregion

    #region Grid Events
    protected void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            grdData.PageIndex = e.NewPageIndex;
            BindGrid();
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    protected void grdData_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if ((e.Row.RowState != DataControlRowState.Edit) )
             {
                if(e.Row.RowState != (DataControlRowState.Edit | DataControlRowState.Alternate))
                {
                    Label lblAlbumImage = (Label)e.Row.FindControl("lblAlbumImage");
                    string ImageURl = lblAlbumImage.Text;
                    if (ImageURl != "")
                    {
                        Image imgAlbumURL = (Image)e.Row.FindControl("imgAlbumURL");
                        string[] GetFolder = ImageURl.Split('_');
                        string Path = Page.ResolveUrl("gall_content/" + "/" + ImageURl).Replace("/admin", "");
                        imgAlbumURL.ImageUrl = Page.ResolveUrl(Path);
                    }
                    Label lblCoverImage = (Label)e.Row.FindControl("lblCoverImage");
                    CheckBox chkCoverImage = (CheckBox)e.Row.FindControl("chkCoverImage");
                    if (lblCoverImage.Text == "1")
                    {
                        chkCoverImage.Checked = true;
                    }
                    else
                    {
                        chkCoverImage.Checked = false;
                    }
                }
                
            }
           
        }

    }
 
    protected void grdData_RowEditing(object sender, GridViewEditEventArgs e)
    {  
        grdData.EditIndex = e.NewEditIndex;
      

        BindGrid();
    }
    protected void grdData_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DataSet ds = new DataSet();
        Label lblID = grdData.Rows[e.RowIndex].FindControl("lblID") as Label;
        ds = obj.AddGallery("DELETE_GALLERY", lblID.Text, "", "", "","", "" ,"");
        if (ds.Tables[0].Rows.Count > 0)
        {
            string STATUS = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if (STATUS != "N")
            {
                string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ManageGallery), "wq", "alert(' " + Message + "');", true);
                BindGrid();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ManageGallery), "wq", "alert('Some Error Occured');", true);
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ManageGallery), "wq", "alert('Some Error Occured');", true);
        }
    }
    protected void grdData_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
        grdData.EditIndex = -1;
        BindGrid();
    }
    protected void grdData_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string ImageDescrition = "";
        string resultval = "";
        DataSet ds = new DataSet();
        Label lblID = grdData.Rows[e.RowIndex].FindControl("lblID") as Label;
        DropDownList ddlPriority = grdData.Rows[e.RowIndex].FindControl("ddlPriority") as DropDownList;
        FileUpload FileUpload = grdData.Rows[e.RowIndex].FindControl("FileGallery") as FileUpload;
        Label AlbumName = grdData.Rows[e.RowIndex].FindControl("lblALBUMNAME") as Label;
        Label lblAlbumImage = grdData.Rows[e.RowIndex].FindControl("lblAlbumImage") as Label;
        CheckBox chKimage = grdData.Rows[e.RowIndex].FindControl("chKimage") as CheckBox;
        TextBox txtDescrition = grdData.Rows[e.RowIndex].FindControl("txtDescription") as TextBox;
        Label lblDescriptionValue = grdData.Rows[e.RowIndex].FindControl("lblDescriptionValue") as Label;
        ImageDescrition = txtDescrition.Text;
        if (ImageDescrition == "")
        {
            ImageDescrition = lblDescriptionValue.Text;
        }
        string CoverImage = "0";
        if(chKimage.Checked == true)
        {
            CoverImage = "1";
        }
        string fileType = string.Empty;
        string filePath = string.Empty;
        if (FileUpload.HasFiles)
        {
            string imgName = FileUpload.FileName;
            string extension = System.IO.Path.GetExtension(FileUpload.FileName);
            Random randomNo = new Random();
            string folderPath = Server.MapPath(Page.ResolveUrl("gall_content/" + yyyy_sys + "/" + mm_sys + "/"));
            string ImageName = yyyy_sys + "_" + mm_sys + "_" + AlbumName.Text.Trim().Replace(" ", "_") + "_" + randomNo.Next() + extension;
            filePath = ImageName;
            string path = folderPath.Replace("\\admin", "") + ImageName;
            FileUpload.SaveAs(path);
        }
        else
        {
            if(lblAlbumImage.Text =="")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ManageGallery), "wq", "alert('Please Select Gallery!');", true);
            }
            else
            {
                filePath = lblAlbumImage.Text;
            }
          
        }
        ds = obj.AddGallery("UPDATE_GALLERY", lblID.Text, "", "", filePath, ddlPriority.SelectedValue, CoverImage , ImageDescrition);
            if (ds.Tables[0].Rows.Count > 0)
            {
                string STATUS = ds.Tables[0].Rows[0]["STATUS"].ToString();
                if(STATUS != "N")
                {
                    string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
                    ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ManageGallery), "wq", "alert(' " + Message + "');", true);
                grdData.EditIndex = -1;
                BindGrid();
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ManageGallery), "wq", "alert('Some Error Occured');", true);
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ManageGallery), "wq", "alert('Some Error Occured');", true);
            }

        }
    #endregion

    #region Group Select Change Event
    protected void ddlGroup_SelectChange(object sender, EventArgs e)
    {
        ddlCatName.Items.Clear();
        DataSet ds = new DataSet();
        //if(ddlGroup.SelectedValue == "-1")
        //{
        //    ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddAlbum), "wq", "alert('Firstly Select Group Name!');", true);
        //    return;
        //}
        ds = obj.ManageAlbumCategory("GET_CAT_NAME", ddlGroup.SelectedValue);
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlCatName.DataSource = ds.Tables[0];
            ddlCatName.DataValueField = "CAT_ID";
            ddlCatName.DataTextField = "CATEGORY_NAME";
            ddlCatName.DataBind();
            ddlCatName.Items.Insert(0, new ListItem("Select Category", "-1"));
        }
        ds.Dispose();
    }
    #endregion

    #region Category Select Change Event
    protected void ddlCatName_SelectChange(object sender, EventArgs e)
    {
        ddlAlbum.Items.Clear();
        DataSet ds = new DataSet();
        //if(ddlGroup.SelectedValue == "-1")
        //{
        //    ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddAlbum), "wq", "alert('Firstly Select Group Name!');", true);
        //    return;
        //}
        ds = obj.ManageAlbum("GET_ALBUM_NAME", ddlCatName.SelectedValue);
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlAlbum.DataSource = ds.Tables[0];
            ddlAlbum.DataValueField = "ALBUM_ID";
            ddlAlbum.DataTextField = "ALBUM_NAME";
            ddlAlbum.DataBind();
            ddlAlbum.Items.Insert(0, new ListItem("Select Album", "-1"));
        }
        ds.Dispose();
    }
    #endregion

    #region Search Button Click
    protected void btnsearch_Click(object sender , EventArgs e)
    {
        BindGrid();
    }
    #endregion

    #region Reset Buttom Click
    protected void btnReset_Click(object sender, EventArgs e)
    {
        common.ClearAllControls(Page.Controls);
        BindGrid();
    }
    #endregion
}

