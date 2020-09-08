using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_AddAstrologer : System.Web.UI.Page
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
                    BindCountry();
                    h3headertest.InnerText = "Add Astrologer";
                    btnUpdate.Text = "Save";
                    if (Request.QueryString["q"] != null)
                    {
                        string UserID = Request.QueryString["q"].ToString();
                        h3headertest.InnerText = "Update Astrologer";
                        btnUpdate.Text = "Update";
                        LoadData(UserID);
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
                    BindCountry();
                    h3headertest.InnerText = "Add Astrologer";
                    btnUpdate.Text = "Save";
                    if (Request.QueryString["q"] != null)
                    {
                        string UserID = Request.QueryString["q"].ToString();
                        h3headertest.InnerText = "Update Astrologer";
                        btnUpdate.Text = "Update";
                        LoadData(UserID);
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

    #region BindCountry
    protected void BindCountry()
    {
        DataSet ds = new DataSet();
        ds = common.bindloc();
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlCity.Items.Insert(0, new ListItem("Select City", "-1"));
            ddlState.Items.Insert(0, new ListItem("Select State", "-1"));
            ddlCountry.DataSource = ds.Tables[0];
            ddlCountry.DataTextField = "loc_name";
            ddlCountry.DataValueField = "loc_id";
            ddlCountry.DataBind();
            ddlCountry.Items.Insert(0, new ListItem("Select Country", "-1"));
            ds.Dispose();
        }
    }
    #endregion

    #region LoadData
    protected void LoadData(string ID)
    {
        if (ID == "") return;
        DataSet ds = new DataSet();
        ds = obj.ManageAstrologer("GET_ASTROLOGER_DETAILS_BY_ID", ID);
        if (ds.Tables[0].Rows.Count > 0)
        {
            if (ds.Tables[0].Rows[0]["PHOTO"].ToString() != "")
            {
                string Image = ds.Tables[0].Rows[0]["PHOTO"].ToString();
                imgpreview.Src = "~/img/" + Image + "";
                hdnAstrologerImage.Value = ds.Tables[0].Rows[0]["PHOTO"].ToString();
            }
            txtName.Text = ds.Tables[0].Rows[0]["NAME"].ToString();
            txtEmailID.Text = ds.Tables[0].Rows[0]["EMAIL_ID"].ToString();
            txtLoginID.Text = ds.Tables[0].Rows[0]["LOGINID"].ToString();
            txtPassword.Text = ds.Tables[0].Rows[0]["PASSWORD"].ToString();
            txtPhoneNo.Text = ds.Tables[0].Rows[0]["MOBILE_NO"].ToString();
            txtExperience.Text = ds.Tables[0].Rows[0]["EXPERIENCE"].ToString();
            txtEducation.Text = ds.Tables[0].Rows[0]["EDUCATION"].ToString();
            txtAlternateNo.Text = ds.Tables[0].Rows[0]["ALTERNATE_NO"].ToString();
            txtExpertIn.Text = ds.Tables[0].Rows[0]["EXPERT_IN"].ToString();
            txtAchievements.Text = ds.Tables[0].Rows[0]["ACHIEVEMENTS"].ToString();
            txtSmallDesc.Text = ds.Tables[0].Rows[0]["SMALL_DESC"].ToString();
            txtFullDesc.Text = ds.Tables[0].Rows[0]["FULL_DESC"].ToString();
            ddlGender.Text = ds.Tables[0].Rows[0]["GENDER"].ToString();
            txtAddress.Text = ds.Tables[0].Rows[0]["ADDRESS"].ToString();
            if (ds.Tables[0].Rows[0]["COUNTRY"].ToString() != "")
            {
                ddlCountry.SelectedValue = ds.Tables[0].Rows[0]["COUNTRY"].ToString();
                hdnCountry.Value = ds.Tables[0].Rows[0]["COUNTRY"].ToString();
            }
            if (ds.Tables[0].Rows[0]["STATE"].ToString() != "")
            {
                hdnState.Value = ds.Tables[0].Rows[0]["STATE"].ToString();
                ScriptManager.RegisterStartupScript(this, GetType(), "Close Modal Popup", "ddlCountryChange('Edit');", true);
            }
            if (ds.Tables[0].Rows[0]["CITY"].ToString() != "")
            {
                hdnCity.Value = ds.Tables[0].Rows[0]["CITY"].ToString();
                ScriptManager.RegisterStartupScript(this, GetType(), "Close Modal Popup", "ddlStateChange('Edit');", true);
            }
            txtZipCode.Text = ds.Tables[0].Rows[0]["ZIPCODE"].ToString();
            txtSpeakInLanguage.Text = ds.Tables[0].Rows[0]["SPEAK_IN_LANGUAGE"].ToString();
            
            
            string status = ds.Tables[0].Rows[0]["STATUS"].ToString(); 
            if(status == "A")
            {
                chkStatus.Checked = true;
            }
            else
            {
                chkStatus.Checked = false;
            }
            string CurrentlyAvailable = ds.Tables[0].Rows[0]["CURRENTLY_AVAILABLE"].ToString();
            if (CurrentlyAvailable == "A")
            {
                chkAvailable.Checked = true;
            }
            else
            {
                chkAvailable.Checked = false;
            }
            ddlGroup.SelectedValue = ds.Tables[0].Rows[0]["GROUP_CATEGORY"].ToString();
            txtRating.Text = ds.Tables[0].Rows[0]["RATING"].ToString();
            lblAstrologerID.Text = ds.Tables[0].Rows[0]["ASTROLOGER_ID"].ToString();
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
        string CurrenltyAvailable = "I";
        if (chkAvailable.Checked == true)
        {
            CurrenltyAvailable = "A";
        }
        string Flag = "INSERT_ASTROLOGER";
        if (lblAstrologerID.Text != "")
        {
            Flag = "UPDATE_ASTROLOGER";
        }
        else
        {
            lblAstrologerID.Text = "";
        }
        string FK = FileUserPhoto.FileName;

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
            hdnAstrologerImage.Value = ImageName;
        }

        else
        {
            filePath = hdnAstrologerImage.Value;
        }
        DataSet ds = new DataSet();
        ds = obj.AddUpdateAstrologer(Flag, lblAstrologerID.Text, txtName.Text, txtLoginID.Text, hdnAstrologerImage.Value, txtExperience.Text, txtEducation.Text, txtPhoneNo.Text, 
            txtEmailID.Text, txtAlternateNo.Text, txtExpertIn.Text, txtAchievements.Text, txtSmallDesc.Text, 
            txtFullDesc.Text, CurrenltyAvailable, ddlGender.SelectedValue, txtAddress.Text, hdnCity.Value, 
            hdnState.Value, ddlCountry.SelectedValue, txtZipCode.Text, Status, txtSpeakInLanguage.Text, ddlGroup.SelectedValue, txtRating.Text, AdminUserId, txtPassword.Text);
       if (ds.Tables[0].Rows.Count > 0)
        {
            string STATUS = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if(STATUS == "N")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddAstrologer), "wq", "alert('Some Error Occured');", true);
                return;
            }
            else if(STATUS == "0")
            {
                string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddAstrologer), "wq", "alert(' " + Message + "');", true);
                return;
            }
            else
            {
                string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddAstrologer), "wq", "alert(' " + Message + "');", true);
                if (Flag != "UPDATE_ASTROLOGER")
                {
                    common.ClearAllControls(Page.Controls);
                }
                else
                {
                    LoadData(lblAstrologerID.Text);
                }
              }
            }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddAstrologer), "wq", "alert('Some Error Occured');", true);
            return;
        }
    }
    #endregion
}