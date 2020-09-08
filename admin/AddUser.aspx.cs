using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_AddUser : System.Web.UI.Page
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
                    BindCountry();
                    h3headertest.InnerText = "Add User";
                    btnUpdate.Text = "Save";
                    if (Request.QueryString["q"] != null)
                    {
                        string UserID = "";
                        if (Request.QueryString["q"] == "Admin")
                        {
                            UserID = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
                        }
                        else
                        {
                            UserID = Request.QueryString["q"].ToString();
                        }

                        h3headertest.InnerText = "Update User";
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
                    h3headertest.InnerText = "Add User";
                    btnUpdate.Text = "Save";
                    if (Request.QueryString["q"] != null)
                    {
                        string UserID = "";
                        if (Request.QueryString["q"] == "Admin")
                        {
                            UserID = Session["AdminUserId"].ToString();
                        }
                        else
                        {
                           UserID = Request.QueryString["q"].ToString();
                        }
                       
                        h3headertest.InnerText = "Update User";
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
    #endregion

    #region Load Data 
    protected void LoadData(string ID)
    {
        if (ID == "") return;
        DataSet ds = new DataSet();
        ds = obj.ManageUser("GET_USER_DETAILS_BY", ID);
        if(ds.Tables[0].Rows.Count > 0)
        {
            txtName.Text = ds.Tables[0].Rows[0]["NAME"].ToString();

            txtEmailID.Text = ds.Tables[0].Rows[0]["EMAIL_ID"].ToString();

            txtLoginID.Text = ds.Tables[0].Rows[0]["LOGIN_ID"].ToString();

            txtPhoneNo.Text = ds.Tables[0].Rows[0]["CONTACT_NO"].ToString();

            txtPassword.Text = ds.Tables[0].Rows[0]["PASSWORD"].ToString();

           
            if (ds.Tables[0].Rows[0]["COUNTRY"].ToString() != "")
            {
                ddlCountry.SelectedValue = ds.Tables[0].Rows[0]["COUNTRY"].ToString();
                hdnCountry.Value = ds.Tables[0].Rows[0]["COUNTRY"].ToString();
            }
            if (ds.Tables[0].Rows[0]["STATE"].ToString() != "")
            {
                ddlState.SelectedValue = ds.Tables[0].Rows[0]["STATE"].ToString();
                hdnState.Value = ds.Tables[0].Rows[0]["STATE"].ToString();
                ScriptManager.RegisterStartupScript(this, GetType(), "Close Modal Popup", "ddlCountryChange('Edit');", true);
            }
            if (ds.Tables[0].Rows[0]["CITY"].ToString() != "")
            {
                ddlCity.SelectedValue = ds.Tables[0].Rows[0]["CITY"].ToString();
                hdnCity.Value = ds.Tables[0].Rows[0]["CITY"].ToString();
                ScriptManager.RegisterStartupScript(this, GetType(), "Close Modal Popup", "ddlStateChange('Edit');", true);
            }
            txtAddress.Text = ds.Tables[0].Rows[0]["ADDRESS"].ToString();
            ddlGroup.SelectedValue = ds.Tables[0].Rows[0]["GROUP_ID"].ToString();
            string Status = ds.Tables[0].Rows[0]["STATUSVAl"].ToString();
            if(Status == "A")
            {
                chkStatus.Checked = true;
            }
            else
            {
                chkStatus.Checked = false;
            }
            string IsSuperAdmin = ds.Tables[0].Rows[0]["ISSUPERADMIN"].ToString();
            if (IsSuperAdmin == "1")
            {
                chkIsSuperAdmin.Checked = true;
            }
            else
            {
                chkIsSuperAdmin.Checked = false;
            }

   
            lblUserID.Text = ds.Tables[0].Rows[0]["USER_ID"].ToString();
        }

    }
    #endregion

    #region Update Click
    protected void btnUpdate_Click(object sender , EventArgs e)
    {
        string Status = "I";
        if(chkStatus.Checked == true)
        {
            Status = "A";
        }
        string SuperAdmin = "0";
        if (chkIsSuperAdmin.Checked == true)
        {
            SuperAdmin = "1";
        }
        
        string Flag = "INSERT_USER";
        if (lblUserID.Text != "")
        {
            Flag = "UPDATE_USER";
        }
        else
        {
            lblUserID.Text = "";
        }
        DataSet ds = new DataSet();
        ds = obj.AddUpdateUser(Flag, lblUserID.Text, txtName.Text, txtEmailID.Text, txtPhoneNo.Text, "", Status, txtAddress.Text, hdnCity.Value, hdnState.Value, 
             ddlCountry.SelectedValue, ddlGroup.SelectedValue, AdminUserId ,txtLoginID.Text ,txtPassword.Text , SuperAdmin);
        if(ds.Tables[0].Rows.Count > 0)
        {
            string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddUser), "wq", "alert(' " + Message + "');", true);
            string STATUS = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if (Flag != "UPDATE_USER")
            {
                common.ClearAllControls(Page.Controls);
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddUser), "wq", "alert('Some Error Occured');", true);
        }
    }
    #endregion

    #region BindCountry
    protected void BindCountry()
    {
        DataSet ds = new DataSet();
        ds = common.bindloc();
        if (ds.Tables[0].Rows.Count > 0)
        {    ddlCity.Items.Insert(0, new ListItem("Select City", "-1"));
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
 }