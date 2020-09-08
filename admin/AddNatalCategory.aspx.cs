using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_AddNatalCategory : System.Web.UI.Page
{
    #region Declaration
    public string PayType = "0";
    dailyarticle obj = new dailyarticle();
    common obj_com = new common();
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    public string AdminUserId = "", AdminEmailId = "";
    string BlogURL = "";
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (AdminStateManagement == "COOKIE")
        {
            if (Request.Cookies["AdminCookies"] != null)
            {
                AdminUserId = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
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
    protected void LoadData(string Id)
    {
        if (Id == "0") return;
        DataSet ds = new DataSet();
        ds = obj.ManageCategory("GETCATDETAILSBYID", Id, "", "", "", "", "", "", "", "", "", "", "", "","","","","","");
        if (ds.Tables[0].Rows.Count > 0)
        {
            lblID.Text = ds.Tables[0].Rows[0]["CATEGORY_ID"].ToString();
            txtCatName.Text = ds.Tables[0].Rows[0]["CATEGORY_NAME"].ToString();
            ddlPriority.SelectedValue = ds.Tables[0].Rows[0]["PRIORITY"].ToString();
            txtMetaKeyWords.Text = ds.Tables[0].Rows[0]["META_KEYWORDS"].ToString();
            txtMetaDesc.Text = ds.Tables[0].Rows[0]["META_DESCRIPTION"].ToString();
            rtedetails.Value = ds.Tables[0].Rows[0]["CATEGORY_DESC"].ToString();
            rtesynopsis.Value = ds.Tables[0].Rows[0]["CATEGORY_SYNOPSIS"].ToString();
            txtTitle.Text = ds.Tables[0].Rows[0]["TITLE"].ToString();
            if (ds.Tables[0].Rows[0]["CATEGORY_IMAGE"].ToString() != "")
            {
                string Image = ds.Tables[0].Rows[0]["CATEGORY_IMAGE"].ToString();
                imgpreview.Src = "~/img/" + Image + "";
                hdnCatImage.Value = ds.Tables[0].Rows[0]["CATEGORY_IMAGE"].ToString();
            }
            if (ds.Tables[0].Rows[0]["CATEGORY_COLOR"].ToString() != "")
            {
                txtColor.Value = ds.Tables[0].Rows[0]["CATEGORY_COLOR"].ToString();
            }
            string Status = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if (Status == "A")
            {
                chkStatus.Checked = true;
            }
            else
            {
                chkStatus.Checked = false;
            }
            string IsBlink = ds.Tables[0].Rows[0]["IS_BLINK"].ToString();
            if (IsBlink == "Y")
            {
                chkIsBlink.Checked = true;
            }
            else
            {
                chkIsBlink.Checked = false;
            }
            string IsPaid = ds.Tables[0].Rows[0]["IS_PAID"].ToString();
            if (IsPaid == "Y")
            {
                chkIsPaid.Checked = true;
            }
            else
            {
                chkIsPaid.Checked = false;
            }
            string AddTOCart = ds.Tables[0].Rows[0]["IS_ADDTOCART"].ToString();
            if (AddTOCart == "Y")
            {
                chkISAddToCart.Checked = true;
            }
            else
            {
                chkISAddToCart.Checked = false;
            }
            txtPostURL.Text = ds.Tables[0].Rows[0]["POST_CATEGORY_URL"].ToString();
            txtPreUrl.Text = ds.Tables[0].Rows[0]["PRE_CATEGORY_URL"].ToString();
            txtCategoryURL.Text = ds.Tables[0].Rows[0]["CATEGORY_URL"].ToString();

        }
    }
    #endregion

    #region  txt Blog URL Change Events 
    protected void txtCategoryURL_TextChanged(object sender, EventArgs e)
    {
        if (txtCategoryURL.Text.Trim() != "")
        {
            BlogURL = obj_com.ReplaceQuotes(txtCategoryURL.Text.Trim());
            txtCategoryURL.Text = obj_com.OptimizeURL(BlogURL);
        }
    }
    #endregion

    #region Update Click
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        string FK = FileUserPhoto.FileName;
        string Color = txtColor.Value;
        string fileType = string.Empty;
        string filePath = string.Empty;
        if (FileUserPhoto.HasFile)
        {
            string imgName = FileUserPhoto.FileName;
            string folderPath = Server.MapPath("~/img");
            string ImageName = FileUserPhoto.FileName.Replace(" ", "-");
            filePath = ImageName;
            string path = folderPath + "/" + ImageName;
            FileUserPhoto.SaveAs(path);
            hdnCatImage.Value = ImageName;
        }

        else
        {
            filePath = hdnCatImage.Value;
        }

        string Status = "P";
        if (chkStatus.Checked == true)
        {
            Status = "A";
        }

        string IsBlink = "N";
        if (chkIsBlink.Checked == true)
        {
            IsBlink = "Y";
        }
        string IsPaid = "N";
        if (chkIsPaid.Checked == true)
        {
            IsPaid = "Y";
        }
        string AddToCart = "N";
        if (chkISAddToCart.Checked == true)
        {
            AddToCart = "Y";
        }
        DataSet ds = new DataSet();
        ds = obj.ManageCategory("INSERT", lblID.Text, txtCatName.Text, txtMetaKeyWords.Text, txtMetaDesc.Text, rtedetails.Value, rtesynopsis.Value, ddlPriority.SelectedValue, txtTitle.Text.ToString(), hdnCatImage.Value, Status, Color, IsBlink, IsPaid , txtCategoryURL.Text,txtPreUrl.Text , txtPostURL.Text , AdminUserId, AddToCart);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddNatalCategory), "wq", "alert(' " + Message + "');", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddNatalCategory), "wq", "alert('Some Error Occured!!');", true);
        }

    }
    #endregion
}