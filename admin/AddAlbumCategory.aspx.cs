using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_AddAlbumCategory : System.Web.UI.Page
{
    #region Declarations
    admin obj = new admin();
    common common = new common();
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    public string AdminUserId = "", AdminEmailId = "";
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (AdminStateManagement == "COOKIE")
        {
            if (Request.Cookies["AdminCookies"] != null)
            {
                AdminUserId = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
                if (!IsPostBack)
                {
                    h3headertest.InnerText = "Add Album Category";
                    btnSubmit.Text = "Save";
                    if (Request.QueryString["q"] != null)
                    {
                        string ID = Request.QueryString["q"].ToString();
                        h3headertest.InnerText = "Update Album Category";
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
                    h3headertest.InnerText = "Add Album Category";
                    btnSubmit.Text = "Save";
                    if (Request.QueryString["q"] != null)
                    {
                        string ID = Request.QueryString["q"].ToString();
                        h3headertest.InnerText = "Update Album Category";
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

    #region Load Data
    protected void LoadData(string ID)
    {
        if (ID == "") return;
        DataSet ds = new DataSet();
        ds = obj.ManageAlbumCategory("GET_CAT_DETAILS", ID);
        if(ds.Tables[0].Rows.Count > 0)
        {
            ddlGroup.SelectedValue = ds.Tables[0].Rows[0]["GROUP_ID"].ToString();
            txtCategoryName.Text = ds.Tables[0].Rows[0]["CATEGORY_NAME"].ToString();
            txtCategoryDesc.Text = ds.Tables[0].Rows[0]["CATEGORY_DESC"].ToString();
            txtTitle.Text = ds.Tables[0].Rows[0]["TITLE"].ToString();
            txtMetaDescription.Text = ds.Tables[0].Rows[0]["META_DESCRIPTION"].ToString();
            txtMetaKeywords.Text = ds.Tables[0].Rows[0]["META_KEYWORDS"].ToString();
            ddlPriority.SelectedValue = ds.Tables[0].Rows[0]["PRIORITY"].ToString();
            string Status = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if(Status == "A")
            {
                chkStatus.Checked = true;
            }
            else
            {
                chkStatus.Checked = false;
            }
            lblCatID.Text = ds.Tables[0].Rows[0]["CAT_ID"].ToString();
        }
    } 
    #endregion
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string Status = "I";
        if(chkStatus.Checked == true)
        {
            Status = "A";
        }
        string flag = "INSERT_ALBUM_CATEGORY";
        if(lblCatID.Text != "")
        {
            flag = "UPDATE_ALBUM_CATEGORY";
        }
        DataSet ds = new DataSet();
        ds = obj.AddAlbumCategory(flag, lblCatID.Text, txtCategoryName.Text, txtCategoryDesc.Text, txtTitle.Text, txtMetaKeywords.Text, txtMetaDescription.Text,AdminEmailId, Status, ddlPriority.SelectedValue, ddlGroup.SelectedValue);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddAlbumCategory), "wq", "alert(' " + Message + "');", true);
            string STATUS = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if (flag != "UPDATE_ALBUM_CATEGORY")
            {
                common.ClearAllControls(Page.Controls);
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddAlbumCategory), "wq", "alert('Some Error Occured');", true);
        }
    }
}