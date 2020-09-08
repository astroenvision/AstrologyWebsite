using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_UpdateClientQues : System.Web.UI.Page
{
    #region Declarations
    subscription sub = new subscription();
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
                    h3headertest.InnerText = "Update Answer";
                    btnUpdate.Text = "Update";
                    if (Request.QueryString["q"] != null)
                    {
                        string ID = "";
                        if (Request.QueryString["q"] == "Admin")
                        {
                            ID = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
                        }
                        else
                        {
                            ID = Request.QueryString["q"].ToString();
                        }

                        h3headertest.InnerText = "Update Answer";
                        btnUpdate.Text = "Update";
                        BindCategory();
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
                    h3headertest.InnerText = "Update Answer";
                    btnUpdate.Text = "Update";
                    if (Request.QueryString["q"] != null)
                    {
                        string ID = "";
                        if (Request.QueryString["q"] == "Admin")
                        {
                            ID = Session["AdminUserId"].ToString();
                        }
                        else
                        {
                            ID = Request.QueryString["q"].ToString();
                        }

                        h3headertest.InnerText = "Update Answer";
                        btnUpdate.Text = "Update";
                        BindCategory();
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

    #region BindCategory
    protected void BindCategory()
    {
        ddlCategory.Items.Clear();
        DataSet ds = new DataSet();
        ds = common.Get_Natal_cat("");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlCategory.DataSource = ds.Tables[0];
            ddlCategory.DataValueField = "CATEGORY_ID";
            ddlCategory.DataTextField = "CATEGORY_NAME";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, new ListItem("Select Category", "-1")); ;
        }
        ds.Dispose();
    }
    #endregion


    #region Load Data 
    protected void LoadData(string ID)
    {
        if (ID == "") return;
        DataSet ds = new DataSet();
        ds = sub.SaveClientQuestion("GET_DETAILS", ID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
        if (ds.Tables[0].Rows.Count > 0)
        {
            txtName.Text = ds.Tables[0].Rows[0]["NAME"].ToString();
            string Dob = ds.Tables[0].Rows[0]["DOB"].ToString();
            txtBirthDateTime.Text = ds.Tables[0].Rows[0]["DATETIMEOFBIRTH"].ToString(); 
            txtBirthPlace.Text = ds.Tables[0].Rows[0]["BIRTHPLACE"].ToString();
            txtQuestion.Text = ds.Tables[0].Rows[0]["QUESTION"].ToString();
            fckAns.Value = ds.Tables[0].Rows[0]["ANSWER"].ToString();
            string Status = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if (Status == "1")
            {
                chkStatus.Checked = true;
            }
            else
            {
                chkStatus.Checked = false;
            }
            ddlPass.SelectedValue = ds.Tables[0].Rows[0]["ISVALID"].ToString();
            lblQuestionID.Text = ds.Tables[0].Rows[0]["QUESTION_ID"].ToString();
        }

    }
    #endregion

    #region Update Click
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        string Status = "0";
        if (chkStatus.Checked == true)
        {
            Status = "1";
        }
        
         DataSet ds = new DataSet();
        ds = sub.SaveClientQuestion("UPDATE" , lblQuestionID.Text , "", fckAns.Value, "","","","","","", AdminUserId, "","", Status, ddlPass.SelectedValue, "","");
        if (ds.Tables[0].Rows.Count > 0)
        {
            string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_UpdateClientQues), "wq", "alert(' " + Message + "');", true);
            string STATUS = ds.Tables[0].Rows[0]["STATUS"].ToString();
         }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_UpdateClientQues), "wq", "alert('Some Error Occured');", true);
        }
    }
    #endregion

  
}