using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_AddAlbum : System.Web.UI.Page
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

    #region Page Load
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
                if (!IsPostBack)
                {
                    obj_main.check_year_folder(yyyy_sys, mm_sys);
                    h3headertest.InnerText = "Add Album";
                    btnSubmit.Text = "Save";
                    if (Request.QueryString["q"] != null)
                    {
                        string ID = Request.QueryString["q"].ToString();
                        h3headertest.InnerText = "Update Album";
                        btnSubmit.Text = "Update";
                        LoadData(ID);
                    }
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
                if (!IsPostBack)
                {
                    obj_main.check_year_folder(yyyy_sys, mm_sys);
                    h3headertest.InnerText = "Add Album";
                    btnSubmit.Text = "Save";
                    if (Request.QueryString["q"] != null)
                    {
                        string ID = Request.QueryString["q"].ToString();
                        h3headertest.InnerText = "Update Album";
                        btnSubmit.Text = "Update";
                        LoadData(ID);
                    }
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

    #region Load Data
    protected void LoadData(string ID)
    {
        if (ID == "") return;
        DataSet ds = new DataSet();
        ds = obj.ManageAlbum("GET_ALBUM_BYID", ID);
        if(ds.Tables[0].Rows.Count> 0)
        {
            ddlGroup.SelectedValue = ds.Tables[0].Rows[0]["GROUP_ID"].ToString();
            ddlGroup_SelectChange(null, null);
            ddlCatName.SelectedValue = ds.Tables[0].Rows[0]["CAT_ID"].ToString();
            txtAlbumName.Text = ds.Tables[0].Rows[0]["ALBUM_NAME"].ToString();
            txtTitle.Text = ds.Tables[0].Rows[0]["TITLE"].ToString();
            txtMetaKeywords.Text = ds.Tables[0].Rows[0]["META_KEYWORDS"].ToString();
            txtMetaDescription.Text = ds.Tables[0].Rows[0]["META_DESCRIPTION"].ToString();
            ddlPriority.SelectedValue = ds.Tables[0].Rows[0]["PRIORITY"].ToString();
            string ImageURL = ds.Tables[0].Rows[0]["COVER_IMG"].ToString();
            lblAlbumID.Text = ds.Tables[0].Rows[0]["ALBUM_ID"].ToString();
            txtAlbumURL.Text = ds.Tables[0].Rows[0]["ALBUM_URL"].ToString();
            txtAlbumURL.Enabled = false;
            txtAlbumURL.CssClass = "form-control";

            if (ImageURL != "")
            {
                 hdnCoverImage.Value = ImageURL;
                string Path = Page.ResolveUrl("gall_content/" + ImageURL).Replace("/admin", "");
                imgpreview.Src = Page.ResolveUrl(Path);
                divCoverImage.Visible = true;
            }
            else
            {
                divCoverImage.Visible = false;
            }
        }
    }
    #endregion

    #region Group Select Change
    protected void ddlGroup_SelectChange(object sender , EventArgs e)
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

    #region Submit Click
    protected void btnSubmit_Click(object sender , EventArgs e)
    {
        DataSet ds = new DataSet();
        string Flag = "INSERT_ALBUM";
        if (lblAlbumID.Text != "")
        {
            Flag = "UPDATE_ALBUM";
        }
        string fileType = string.Empty;
        string filePath = string.Empty;
        if (FileUserPhoto.HasFiles)
        {
            string imgName = FileUserPhoto.FileName;
            string extension = System.IO.Path.GetExtension(FileUserPhoto.FileName);
            Random randomNo = new Random();
            string folderPath = Server.MapPath(Page.ResolveUrl("gall_content/" + yyyy_sys + "/" + mm_sys + "/"));
            string ImageName = yyyy_sys + "_" + mm_sys + "_" + txtAlbumName.Text.Trim().Replace(" ", "_") + "_" + randomNo.Next() + extension;
            filePath = yyyy_sys + "/" + mm_sys + "/" + ImageName;
            string path = folderPath.Replace("\\admin", "") + ImageName;
            FileUserPhoto.SaveAs(path);
        }
        else
        {
            //if(Flag == "INSERT_ALBUM")
            //{
            //    ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddAlbum), "wq", "alert('Select Cover Image');", true);
            //    return;
            //}
            //else
            //{
                filePath = hdnCoverImage.Value;
            //}
        }
        ds = obj.AddAlbum(Flag, lblAlbumID.Text, ddlCatName.SelectedValue, txtAlbumName.Text, filePath, txtTitle.Text, txtMetaKeywords.Text, txtMetaDescription.Text, AdminUserId, ddlPriority.SelectedValue, ddlGroup.Text, txtAlbumURL.Text);
         if (ds.Tables[0].Rows.Count > 0)
            {
            string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddAlbum), "wq", "alert(' " + Message + "');", true);
            string STATUS = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if (Flag != "UPDATE_ALBUM")
            {
                common.ClearAllControls(Page.Controls);
                divCoverImage.Visible = false;
            }
            else
            {
                if (Request.QueryString["q"] != null)
                {
                    string ID = Request.QueryString["q"].ToString();
                    LoadData(ID);
                }
               
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddAlbum), "wq", "alert('Some Error Occured');", true);
        }
            
       
    }
    #endregion

    #region TxtAlbumURL Change Events 
    protected void txtAlbumURL_TextChanged(object sender, EventArgs e)
    {
        if (txtAlbumURL.Text.Trim()!="")
        {
            string AlbumURL = common.ReplaceQuotes(txtAlbumURL.Text.Trim());
            txtAlbumURL.Text = common.OptimizeURL(AlbumURL);
        }
    }
    #endregion
}