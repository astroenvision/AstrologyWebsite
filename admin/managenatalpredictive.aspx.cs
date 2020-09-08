using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_managenatalpredictive : System.Web.UI.Page
{
    #region Declarations
    admin obj = new admin();
    common common = new common();
    dailyarticle obj_daily = new dailyarticle();
    Houseposition house_obj = new Houseposition();
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    public string AdminUserId = "", AdminEmailId = "" , CatID="";
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
                    BindLogic();
                    h3headertest.InnerText = "Add Predictive";
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

                        h3headertest.InnerText = "Update Predictive";
                        btnUpdate.Text = "Update";
                        LoadData(UserID);
                    }
                    BindGrid();
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
                    BindLogic();
                    h3headertest.InnerText = "Add Predictive";
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

                        h3headertest.InnerText = "Update Predictive";
                        btnUpdate.Text = "Update";
                        LoadData(UserID);
                       
                    }
                    BindGrid();
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

    protected void BindLogic()
    {
        DataSet ds = new DataSet();
        ds = obj.GetCombination("GET_DETAILS_BY_SCRH", "", "", "", "", "", "");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlLogic.Items.Clear();
            ddlLogic.DataSource = ds.Tables[0];
            ddlLogic.DataTextField = "LOGIC_DESC";
            ddlLogic.DataValueField = "LOGIC_ID";
            ddlLogic.DataBind();
            ddlLogic.Items.Insert(0, new ListItem("Select Logic", "-1"));
            ds.Dispose();
        }
    }

    #region Bind Grid
    protected void BindGrid()
    {
        DataSet ds = new DataSet();
        ds = obj_daily.ManageCategory("GET_PAID_CATEGORIES", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
        if (ds.Tables[0].Rows.Count > 0)
        {
            grdData.DataSource = ds;
            grdData.DataBind();
            for (int i = 0; i < grdData.Rows.Count; i++)
            {
                Label lblCATEGORYID = (Label)(grdData.Rows[i].FindControl("lblCATEGORYID"));
                CheckBox chkrow = (CheckBox)(grdData.Rows[i].FindControl("chkrow"));
                if (lblCATEGORYID.Text == CatID)
                {
                    chkrow.Checked = true;
                }
                else
                {
                    chkrow.Checked = false;
                }
             }
        }
        else
        {
            grdData.DataSource = ds;
            grdData.DataBind();
        }
        ds.Dispose();
    }
    #endregion

    #region Load Data 
    protected void LoadData(string ID)
    {
        if (ID == "") return;
        DataSet ds = new DataSet();
        ds = obj.GetPredictive("GET_DETAILS", ID, "", "", "");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlpredictivetype.SelectedValue = ds.Tables[0].Rows[0]["PREDICTIVE_TYPE"].ToString();
            ddlchecked.SelectedValue = ds.Tables[0].Rows[0]["CHECKED"].ToString().ToUpper();
            ddlPriority.SelectedValue = ds.Tables[0].Rows[0]["PRIORITY"].ToString();
            ddlstatus.SelectedValue = ds.Tables[0].Rows[0]["STATUS"].ToString();
            ddlLogic.SelectedValue = ds.Tables[0].Rows[0]["LOGIC_ID"].ToString();
            rtepredictivenew.Value = ds.Tables[0].Rows[0]["PREDICTIVE"].ToString();
            rteremedialnew.Value = ds.Tables[0].Rows[0]["REMEDIAL"].ToString();
            lblID.Text = ds.Tables[0].Rows[0]["PREDICTIVE_ID"].ToString();
            CatID = ds.Tables[0].Rows[0]["CATEGORY_ID"].ToString();
        }
    }
    #endregion

    #region Update Click
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        string Flag = "INSERT";
        bool flagcheck = false;
        for (Int32 Counter = 0; Counter < grdData.Rows.Count; Counter++)
        {
            CheckBox chkval = (CheckBox)(grdData.Rows[Counter].FindControl("chkrow"));
            if (chkval.Checked == true)
            {
                Label lblCATEGORYID = (Label)(grdData.Rows[Counter].FindControl("lblCATEGORYID"));
                DataSet ds = new DataSet();
                ds = obj.SavePredictive(Flag, lblID.Text,  ddlLogic.SelectedItem.Text, "", "", rtepredictivenew.Value, rteremedialnew.Value, ddlpredictivetype.SelectedValue,
                    "", "","", lblCATEGORYID.Text, AdminUserId, ddlchecked.SelectedValue, ddlstatus.SelectedValue, ddlPriority.SelectedValue, ddlLogic.SelectedValue, txtUniqueID.Text);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    flagcheck = true;
                    string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
                    ScriptManager.RegisterClientScriptBlock(this, typeof(admin_managenatalpredictive), "wq", "alert(' " + Message + "');", true);
                 }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(admin_managenatalpredictive), "wq", "alert('Some Error Occured');", true);
                }
            }
        }
        if (flagcheck == false)
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_managenatalpredictive), "wq", "alert('Warning! You have not checked any Checkbox.');", true);
        }
        if (Flag != "UPDATE")
        {
            common.ClearAllControls(Page.Controls);
        }
    }
    #endregion
}