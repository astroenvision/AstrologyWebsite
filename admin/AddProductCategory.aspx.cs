using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_AddProductCategory : System.Web.UI.Page
{
    #region Declarations
    admin obj = new admin();
    common common = new common();
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    public string AdminUserId = "", AdminEmailId = "";
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (AdminStateManagement == "COOKIE")
        {
            if (Request.Cookies["AdminCookies"] != null)
            {
                AdminUserId = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
                if (!IsPostBack)
                {
                    h3headertest.InnerText = "Add Product Category";
                    btnUpdate.Text = "Save";

                    if (Request.QueryString["q"] != null)
                    {
                        string ID = Request.QueryString["q"].ToString();
                        h3headertest.InnerText = "Update Product Category";
                        btnUpdate.Text = "Update";
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
                    h3headertest.InnerText = "Add Product Category";
                    btnUpdate.Text = "Save";

                    if (Request.QueryString["q"] != null)
                    {
                        string ID = Request.QueryString["q"].ToString();
                        h3headertest.InnerText = "Update Product Category";
                        btnUpdate.Text = "Update";
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
        ds = obj.ManageProductCategory("GetCategoryByID", ID ,"","","","","","","","","");
        if (ds.Tables[0].Rows.Count > 0)
        {
            txtCategoryName.Text = ds.Tables[0].Rows[0]["PRODUCT_CATEGORY_NAME"].ToString();

            txtFullDesc.Text = ds.Tables[0].Rows[0]["PRODUCT_FULL_DESC"].ToString();

            txtShortDesc.Text = ds.Tables[0].Rows[0]["PRODUCT_SHORT_DESC"].ToString();

            txtMetakeywords.Text = ds.Tables[0].Rows[0]["META_KEYWORDS"].ToString();

            txtMetaDesc.Text = ds.Tables[0].Rows[0]["META_DESCRIPTION"].ToString();

            ddlPriority.SelectedValue = ds.Tables[0].Rows[0]["PRIORITY"].ToString(); 

            txtTitle.Text = ds.Tables[0].Rows[0]["TITLE"].ToString();

            string Status = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if (Status == "A")
            {
                chkStatus.Checked = true;
            }
            else
            {
                chkStatus.Checked = false;
            }

            lblID.Text = ds.Tables[0].Rows[0]["PRODUCT_CATEGORY_ID"].ToString();
        }

    }
    #endregion

    #region Update Click
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        string Status = "I";
        if (chkStatus.Checked == true)
        {
            Status = "A";
        }
        string Flag = "INSERT_CATEGORY";
        if (lblID.Text != "")
        {
            Flag = "UPDATE_CATEGORY";
        }
        else
        {
            lblID.Text = "";
        }
   
        DataSet ds = new DataSet();
        ds = obj.ManageProductCategory(Flag,lblID.Text , txtCategoryName.Text , txtShortDesc.Text , txtFullDesc.Text , Status , ddlPriority.SelectedValue , txtTitle.Text , txtMetakeywords.Text , txtMetaDesc.Text , AdminUserId);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddProductCategory), "wq", "alert(' " + Message + "');", true);
            string STATUS = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if (Flag != "UPDATE_CATEGORY")
            {
                common.ClearAllControls(Page.Controls);
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddProductCategory), "wq", "alert('Some Error Occured');", true);
        }
    }
    #endregion
}