using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_AddPooja : System.Web.UI.Page
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
                    h3headertest.InnerText = "Add Pooja";
                    btnUpdate.Text = "Save";
                    BindCategory();
                    if (Request.QueryString["q"] != null)
                    {
                        string ID = Request.QueryString["q"].ToString();
                        h3headertest.InnerText = "Update Pooja";
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
                    obj_main.check_year_folder(yyyy_sys, mm_sys);
                    h3headertest.InnerText = "Add Pooja";
                    btnUpdate.Text = "Save";
                    BindCategory();
                    if (Request.QueryString["q"] != null)
                    {
                        string ID = Request.QueryString["q"].ToString();
                        h3headertest.InnerText = "Update Pooja";
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

    #region Bind Category
    protected void BindCategory()
    {
        DataSet ds = new DataSet();
        ds = obj.ManagePoojaCategory("GetCategory", "", "", "", "", "", "", "", "", "", "");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlCategory.DataSource = ds.Tables[0];
            ddlCategory.DataValueField = "POOJA_CATEGORY_ID";
            ddlCategory.DataTextField = "POOJA_CATEGORY_NAME";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, new ListItem("Select Category", "-1"));
        }
    }
    #endregion

    #region Load Data 
    protected void LoadData(string ID)
    {
        if (ID == "") return;
        DataSet ds = new DataSet();
        ds = obj.ManagePooja("GetPoojaByID", ID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
        if (ds.Tables[0].Rows.Count > 0)
        {

            txtPoojaCode.Text = ds.Tables[0].Rows[0]["POOJA_CODE"].ToString();
            ddlCategory.SelectedValue = ds.Tables[0].Rows[0]["POOJA_CATEGORY_ID"].ToString();
            txtPoojaType.Text = ds.Tables[0].Rows[0]["POOJA_TYPE"].ToString();
            txtProductName.Text = ds.Tables[0].Rows[0]["POOJA_NAME"].ToString();
            txtProductURL.Text = ds.Tables[0].Rows[0]["POOJA_URL"].ToString();
            txtProductPurpose.Text = ds.Tables[0].Rows[0]["POOJA_PURPOSE"].ToString();
            txtColor.Value = ds.Tables[0].Rows[0]["POOJA_COLOR"].ToString();
            txtPoojaRating.Text = ds.Tables[0].Rows[0]["POOJA_RATING"].ToString();
            txtTitle.Text = ds.Tables[0].Rows[0]["POOJA_TITLE"].ToString();
            ddlPriority.SelectedValue = ds.Tables[0].Rows[0]["PRIORITY"].ToString();
            txtMetakeywords.Text = ds.Tables[0].Rows[0]["META_KEYWORDS"].ToString();
            txtMetaDesc.Text = ds.Tables[0].Rows[0]["META_DESCRIPTION"].ToString();
            hdnSmallImage.Value = ds.Tables[0].Rows[0]["SMALL_IMAGE"].ToString();
            hdnLargeImage.Value = ds.Tables[0].Rows[0]["LARGE_IMAGE"].ToString();
            fckShortDesc.Value = ds.Tables[0].Rows[0]["SHORT_DESC"].ToString();
            fckFullDesc.Value = ds.Tables[0].Rows[0]["FULL_DESC"].ToString();
           
            string Status = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if (Status == "A")
            {
                chkStatus.Checked = true;
            }
            else
            {
                chkStatus.Checked = false;
            }
            lblID.Text = ds.Tables[0].Rows[0]["POOJA_ID"].ToString();
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
       
        string Flag = "INSERT_POOJA";
        if (lblID.Text != "")
        {
            Flag = "UPDATE_POOJA";
        }
        else
        {
            lblID.Text = "";
        }
       
        string LargefileType = string.Empty;
        string LargefilePath = string.Empty;
        if (fileLargeImage.HasFiles)
        {
            string imgName = fileLargeImage.FileName;
            string extension = System.IO.Path.GetExtension(fileLargeImage.FileName);
            Random randomNo = new Random();
            string folderPath = Server.MapPath(Page.ResolveUrl("gall_content/" + yyyy_sys + "/" + mm_sys + "/"));
            string ImageName = yyyy_sys + "_" + mm_sys + "_" + txtProductName.Text.Trim().Replace(" ", "_") + "_" + randomNo.Next() + extension;
            LargefilePath = yyyy_sys + "/" + mm_sys + "/" + ImageName;
            string path = folderPath.Replace("\\admin", "") + ImageName;
            fileLargeImage.SaveAs(path);
        }
        else
        {
            LargefilePath = hdnLargeImage.Value;

        }
        string SmallfileType = string.Empty;
        string SmallfilePath = string.Empty;
        if (FileSmallImage.HasFiles)
        {
            string imgName = FileSmallImage.FileName;
            string extension = System.IO.Path.GetExtension(FileSmallImage.FileName);
            Random randomNo = new Random();
            string folderPath = Server.MapPath(Page.ResolveUrl("gall_content/" + yyyy_sys + "/" + mm_sys + "/"));
            string ImageName = yyyy_sys + "_" + mm_sys + "_" + txtProductName.Text.Trim().Replace(" ", "_") + "_" + randomNo.Next() + extension;
            SmallfilePath = yyyy_sys + "/" + mm_sys + "/" + ImageName;
            string path = folderPath.Replace("\\admin", "") + ImageName;
            FileSmallImage.SaveAs(path);
        }
        else
        {
            SmallfilePath = hdnSmallImage.Value;

        }
        DataSet ds = new DataSet();
        ds = obj.ManagePooja(Flag, lblID.Text, txtPoojaCode.Text, ddlCategory.SelectedValue, txtPoojaType.Text, txtProductName.Text, txtProductURL.Text,
                                   txtProductPurpose.Text, "", "", txtColor.Value, SmallfilePath, LargefilePath, fckShortDesc.Value, fckFullDesc.Value,
                                   txtPoojaRating.Text, "", "", Status, ddlPriority.SelectedValue, txtTitle.Text, txtMetakeywords.Text, txtMetaDesc.Text, AdminUserId);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddPooja), "wq", "alert(' " + Message + "');", true);
            string STATUS = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if (Flag != "UPDATE_POOJA")
            {
                common.ClearAllControls(Page.Controls);
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddPooja), "wq", "alert('Some Error Occured');", true);
        }
    }
    #endregion

    #region  txt Blog URL Change Events 
    protected void txtProductURL_TextChanged(object sender, EventArgs e)
    {
        if (txtProductURL.Text.Trim() != "")
        {
            string URL = common.ReplaceQuotes(txtProductURL.Text.Trim());
            txtProductURL.Text = common.OptimizeURL(URL);
        }
    }
    #endregion
}