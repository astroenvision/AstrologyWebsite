using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_AddArticle : System.Web.UI.Page
{
    #region Declarations
    admin obj = new admin();
    common common = new common();
    dailyarticle objda = new dailyarticle();
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
                    h3header.InnerText = "Add Article";
                    btnSubmit.Text = "Save";

                    if (Request.QueryString["q"] != null)
                    {
                        string ID = Request.QueryString["q"].ToString();
                        h3header.InnerText = "Update Article";
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
                    h3header.InnerText = "Add Article";
                    btnSubmit.Text = "Save";

                    if (Request.QueryString["q"] != null)
                    {
                        string ID = Request.QueryString["q"].ToString();
                        h3header.InnerText = "Update Article";
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

    #region  txt Blog URL Change Events 
    protected void txtArticleURL_TextChanged(object sender, EventArgs e)
    {
        if (txtArticleURL.Text.Trim() != "")
        {
            string ArticleURL = common.ReplaceQuotes(txtArticleURL.Text.Trim());
            txtArticleURL.Text = common.OptimizeURL(ArticleURL);
        }
    }
    #endregion

    #region Group Change Events
    protected void ddlgroup_SelectedIndexChanged(object sender, EventArgs e)
    {
       DataSet ds = new DataSet();
       ds = objda.Get_Categories("",ddlGroup.SelectedValue.ToString().Trim(), "");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlCatName.DataSource = ds;
            ddlCatName.DataValueField = "CAT_ID";
            ddlCatName.DataTextField = "CAT_NAME";
            ddlCatName.DataBind();
            ddlCatName.Items.Insert(0, new ListItem("Select Category", "-1")); ;
        }
        ds.Dispose();
    }
    #endregion

    #region ddlCatName OnChange
       protected void ddlCatName_OnChange(object sender , EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = objda.Get_Categories("BindSubCat", ddlGroup.SelectedValue.ToString().Trim(), ddlCatName.SelectedValue);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlSubCat.Items.Clear();
                ddlSubCat.DataSource = ds.Tables[0];
                ddlSubCat.DataValueField ="CAT_ID";
                ddlSubCat.DataTextField = "CAT_NAME";
                ddlSubCat.DataBind();
                ddlSubCat.Items.Insert(0, new ListItem("Select Sub Category", "-1")); ;
            }
            ds.Dispose();
       }
    #endregion

    #region LoadData
    protected void LoadData(string NewID)
    {
        if (NewID == "0") return;
        DataSet ds = new DataSet();

        ds = objda.Get_ArticleData_ByID("GET_ARTICLES_ID", NewID);
        if (ds.Tables[0].Rows.Count > 0)
        {
            lblStatus.Text = ds.Tables[0].Rows[0]["APPROVE"].ToString();
            lblArticleID.Text = ds.Tables[0].Rows[0]["CATID"].ToString();
            if (ds.Tables[0].Rows[0]["AUTHOR"].ToString() != "")
            {
                txtAuthor.Text = ds.Tables[0].Rows[0]["AUTHOR"].ToString();
            }
            if (ds.Tables[0].Rows[0]["GROUP_ID"].ToString() != "")
            {
                ddlGroup.SelectedValue = ds.Tables[0].Rows[0]["GROUP_ID"].ToString();
            }
            ddlgroup_SelectedIndexChanged(null, null);
            
            if (ds.Tables[0].Rows[0]["PID"].ToString() != "0")
            { 
                if (ds.Tables[0].Rows[0]["PID"].ToString() != "")
                {
                    ddlCatName.SelectedValue = ds.Tables[0].Rows[0]["PID"].ToString();
                }
                ddlCatName_OnChange(null, null);
                ddlSubCat.SelectedValue = ds.Tables[0].Rows[0]["CATID"].ToString();
            }
            else
            {
                ddlCatName.SelectedValue = ds.Tables[0].Rows[0]["CATID"].ToString();
            }
            if (ds.Tables[0].Rows[0]["PRIORITY"].ToString() != "")
            {
                ddlPriority.SelectedValue = ds.Tables[0].Rows[0]["PRIORITY"].ToString();
            }
            if (ds.Tables[0].Rows[0]["HEADLINE"].ToString() != "")
            {
                txtHeadline.Text = ds.Tables[0].Rows[0]["HEADLINE"].ToString();
            }

            if (ds.Tables[0].Rows[0]["SYNOPSIS"].ToString() != "")
            {
                FckSynopsis.Value = ds.Tables[0].Rows[0]["SYNOPSIS"].ToString();
            }

            if (ds.Tables[0].Rows[0]["FULLSTORY"].ToString() != "")
            {
                fckFullDetails.Value = ds.Tables[0].Rows[0]["FULLSTORY"].ToString();
            }

            string ImageURL = ds.Tables[0].Rows[0]["AUTHOR_IMG"].ToString();
            if (ImageURL != "")
            {
                divImage.Visible = true;
                string Path = Page.ResolveUrl("gall_content/" + ImageURL).Replace("/admin", "");
                imgpreview.Src = Page.ResolveUrl(Path);
                hdnImage.Value = ImageURL;
            }
            else
            {
                divImage.Visible = false;
            }
            string ImageURLStory = ds.Tables[0].Rows[0]["THUMB_IMG"].ToString();
            if (ImageURLStory != "")
            {
                divStoryImage.Visible = true;
                string Path = Page.ResolveUrl("gall_content/" + ImageURLStory).Replace("/admin", "");
                imgStoryImage.Src = Page.ResolveUrl(Path);
                hdnImageStory.Value = ImageURL;
            }
            else
            {
                divStoryImage.Visible = false;
            }
            txtMetaDescription.Text = ds.Tables[0].Rows[0]["META_DESCRIPTION"].ToString();
            txtMetaKeywords.Text = ds.Tables[0].Rows[0]["META_KEYWORDS"].ToString();
            txtArticleURL.Text = ds.Tables[0].Rows[0]["URL"].ToString();
            txtTitle.Text = ds.Tables[0].Rows[0]["TITLE"].ToString();
            txtArticleURL.Enabled = false;
        }
        else
        {

        }
    }
    #endregion

    #region Submit
    protected void btnSubmit_Click(object sender , EventArgs e)
    {
        string Status = "I";
        
        if (fckFullDetails.Value == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddArticle), "wq", "alert('Please Enter Description!');", true);
            return;
        }
        if (chkStatus.Checked == true)
        {
            Status = "A";
        }        
        
        string fileType = string.Empty;
        string filePath = string.Empty;
        if (FileUserPhoto.HasFiles)
        {
            string imgName = FileUserPhoto.FileName;
            string extension = System.IO.Path.GetExtension(FileUserPhoto.FileName);
            Random randomNo = new Random();
            string folderPath = Server.MapPath(Page.ResolveUrl("gall_content/" + yyyy_sys + "/" + mm_sys + "/"));
            string ImageName = "Author_" + imgName.Trim().Replace(" ", "_") + "_" + randomNo.Next() + extension;
            filePath = yyyy_sys + "/" + mm_sys + "/" + ImageName;
            string path = folderPath.Replace("\\admin", "") + ImageName;
            FileUserPhoto.SaveAs(path);
             hdnImage.Value = filePath;
        }
        else
        {
            filePath = hdnImage.Value;
        }
        string fileTypeForStory = string.Empty;
        string filePathForStory = string.Empty;
        if (FileStoryImage.HasFiles)
        {
            string imgName = FileStoryImage.FileName;
            string extension = System.IO.Path.GetExtension(FileStoryImage.FileName);
            Random randomNo = new Random();
            string folderPath = Server.MapPath(Page.ResolveUrl("gall_content/" + yyyy_sys + "/" + mm_sys + "/"));
            string ImageName = "Author_Story_" + imgName.Trim().Replace(" ", "_") + "_" + randomNo.Next() + extension;
            filePathForStory = yyyy_sys + "/" + mm_sys + "/" + ImageName;
            string path = folderPath.Replace("\\admin", "") + ImageName;
            FileStoryImage.SaveAs(path);
            hdnImageStory.Value = filePathForStory;
        }
        else
        {
            filePathForStory = hdnImageStory.Value;
        }
        DataSet ds = new DataSet();
        if (lblArticleID.Text == "")
        {
            string CatID = "";
            if(ddlSubCat.SelectedValue == "-1")
            {
                CatID = ddlCatName.SelectedValue;
            }
            else
            {
                CatID = ddlSubCat.SelectedValue;
            }
            ds = objda.Save_Article(ddlGroup.SelectedValue, CatID, txtHeadline.Text.Trim(), FckSynopsis.Value, fckFullDetails.Value, txtAuthor.Text, hdnImage.Value, Status,
                                                   ddlPriority.SelectedValue, AdminUserId, txtMetaDescription.Text.Trim(), txtMetaKeywords.Text.Trim(), txtTitle.Text.Trim(), txtArticleURL.Text.Trim(), hdnImageStory.Value);
        }
        else
        {
            if (Request.QueryString["q"] != null)
            {
                string CatID = "";
                if (ddlSubCat.SelectedValue == "-1" )
                {
                    CatID = ddlCatName.SelectedValue;
                }
                else
                {
                    CatID = ddlSubCat.SelectedValue;
                }
                ID = Request.QueryString["q"].ToString();
                ds = objda.Update_Article(ddlGroup.SelectedValue, CatID, txtHeadline.Text.Trim(), FckSynopsis.Value, fckFullDetails.Value,
                       txtAuthor.Text.Trim(), hdnImage.Value, lblStatus.Text, ddlPriority.SelectedValue, AdminUserId, ID , txtMetaDescription.Text.Trim(), txtMetaKeywords.Text.Trim(), txtTitle.Text.Trim(), hdnImageStory.Value);
            }

       }
       
      
        if (ds.Tables[0].Rows.Count > 0)
        {
            string STATUS = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if(STATUS != "N")
            {
                string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddArticle), "wq", "alert(' " + Message + "');", true);
                if (lblArticleID.Text == "")
                {

                    common.ClearAllControls(Page.Controls);
                }
                else
                {
                    if (Request.QueryString["q"] != null)
                    {
                        ID = Request.QueryString["q"].ToString();
                        LoadData(ID);
                    }
                }

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddArticle), "wq", "alert('Some Error Occured');", true);
            }
       }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddArticle), "wq", "alert('Some Error Occured');", true);
        }
    }

    #endregion
}