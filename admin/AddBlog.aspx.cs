using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_AddBlog : System.Web.UI.Page
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
                    h3header.InnerText = "Add Blog";
                    btnSubmit.Text = "Save";

                    if (Request.QueryString["q"] != null)
                    {
                        string ID = Request.QueryString["q"].ToString();
                        h3header.InnerText = "Update Blog";
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
                    h3header.InnerText = "Add Blog";
                    btnSubmit.Text = "Save";

                    if (Request.QueryString["q"] != null)
                    {
                        string ID = Request.QueryString["q"].ToString();
                        h3header.InnerText = "Update Blog";
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

    #region Submit Click
    protected void btnSubmit_Click(object sender , EventArgs e)
    {
        string Status = "I";
       
        if(fckDesc.Value == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddBlog), "wq", "alert('Please Enter Description!');", true);
            return;
        }
        if (chkStatus.Checked == true)
        {
            Status = "A";
        }
        string flag = "INSERT_BLOG";
        if (lblBlogID.Text != "")
        {
            flag = "UPDATE_BLOG";
        }
      
        string fileType = string.Empty;
        string filePath = string.Empty;
        if (FileUserPhoto.HasFiles)
        {
            string imgName = FileUserPhoto.FileName;
            string extension = System.IO.Path.GetExtension(FileUserPhoto.FileName);
            Random randomNo = new Random();
            string folderPath = Server.MapPath(Page.ResolveUrl("gall_content/" + yyyy_sys + "/" + mm_sys + "/"));
            string ImageName = "BLOG_" + imgName.Trim().Replace(" ", "_") + "_" + randomNo.Next() + extension;
            filePath = yyyy_sys + "/" + mm_sys + "/" + ImageName;
            string path = folderPath.Replace("\\admin", "") + ImageName;
            FileUserPhoto.SaveAs(path);
        }
        else
        {
          filePath = hdnImage.Value;
         }
        DataSet ds = new DataSet();
        ds = obj.AddBlogs(flag , lblBlogID.Text , txtTitle.Text , txtSubTitle.Text , fckDesc.Value , txtMetaKeywords.Text , txtMetaDescription.Text , filePath, Status , AdminUserId, ddlPriority.SelectedValue, txtSummary.Text , txtWrittenBy.Text , ddlGroup.SelectedValue, txtBlogURL.Text , txtHeading.Text );
        if (ds.Tables[0].Rows.Count > 0)
        {
            string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddBlog), "wq", "alert(' " + Message + "');", true);
            string STATUS = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if (flag != "UPDATE_BLOG")
            {
                common.ClearAllControls(Page.Controls);
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
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddBlog), "wq", "alert('Some Error Occured');", true);
        }
    }
    #endregion

    #region Load Data
    protected void LoadData(string ID)
    {
        if (ID == "") return;
        DataSet ds = new DataSet();
        ds = obj.ManageBlog("GET_BLOG_DETAILS", ID,"", "");
        if(ds.Tables[0].Rows.Count > 0)
        {
            lblBlogID.Text = ds.Tables[0].Rows[0]["BLOG_ID"].ToString();
            ddlGroup.SelectedValue = ds.Tables[0].Rows[0]["CATEGORY"].ToString();
            txtTitle.Text = ds.Tables[0].Rows[0]["TITLE"].ToString();
            txtSubTitle.Text = ds.Tables[0].Rows[0]["SUB_TITLE"].ToString();
            txtSummary.Text = ds.Tables[0].Rows[0]["SUMMARY"].ToString();
            txtMetaKeywords.Text = ds.Tables[0].Rows[0]["META_KEYWORDS"].ToString();
            txtMetaDescription.Text = ds.Tables[0].Rows[0]["META_DESCRIPTION"].ToString();
            ddlPriority.SelectedValue = ds.Tables[0].Rows[0]["PRIORITY"].ToString();
            txtWrittenBy.Text = ds.Tables[0].Rows[0]["WRITTEN_BY"].ToString();
            txtBlogURL.Text = ds.Tables[0].Rows[0]["BLOG_URL"].ToString();
            txtBlogURL.Enabled = false;
            txtBlogURL.CssClass = "form-control";
            fckDesc.Value = ds.Tables[0].Rows[0]["DESCRIPTION"].ToString();
            string Active = ds.Tables[0].Rows[0]["ACTIVE"].ToString();
            txtHeading.Text = ds.Tables[0].Rows[0]["HEADLINE"].ToString();
            if (Active == "A")
            {
                chkStatus.Checked = true;
            }
            else
            {
                chkStatus.Checked = false;
            }
            string ImageURL = ds.Tables[0].Rows[0]["IMAGE"].ToString();
            if(ImageURL != "")
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
        }
    }
    #endregion

    #region  txt Blog URL Change Events 
    protected void txtBlogURL_TextChanged(object sender, EventArgs e)
    {
        if (txtBlogURL.Text.Trim() != "")
        {
            string BlogURL = common.ReplaceQuotes(txtBlogURL.Text.Trim());
            txtBlogURL.Text = common.OptimizeURL(BlogURL);
        }
    }
    #endregion
}