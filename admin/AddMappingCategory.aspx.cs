using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Threading;
using System.Data;
using ASTROLOGY.classesoracle;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class admin_AddMappingCategory : System.Web.UI.Page
{
    #region Declarartions
    dailyarticle obj = new dailyarticle();
    common Common = new common();
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
                    Thread.Sleep(5000);
                    BindCategory();
                    hdnFlag.Value = "NatalCategory";
                    if (!string.IsNullOrEmpty(Request.QueryString["q"]))
                    {
                        string id = Request.QueryString["q"].ToString();
                        ddlCategory.SelectedValue = id;

                    }
                    if (!string.IsNullOrEmpty(Request.QueryString["Flag"]))
                    {
                        if(Request.QueryString["Flag"].ToString()== "CompatibilityMatching")
                        {
                            hdnFlag.Value = Request.QueryString["Flag"].ToString();
                            ddlCategory.SelectedValue = "28";
                        }
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
                    Thread.Sleep(5000);
                    BindCategory();
                    hdnFlag.Value = "NatalCategory";
                    if (!string.IsNullOrEmpty(Request.QueryString["q"]))
                    {
                        string id = Request.QueryString["q"].ToString();
                        ddlCategory.SelectedValue = id;

                    }
                    if (!string.IsNullOrEmpty(Request.QueryString["Flag"]))
                    {
                        hdnFlag.Value = Request.QueryString["Flag"].ToString();
                        ddlCategory.SelectedValue = "28";
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

    #region BindCategory
    protected void BindCategory()
    {
        ddlCategory.Items.Clear();
        DataSet ds = new DataSet();
        ds = Common.Get_Natal_cat("");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlCategory.DataSource = ds.Tables[0];
            ddlCategory.DataValueField = "CATEGORY_ID";
            ddlCategory.DataTextField = "CATEGORY_NAME";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, new ListItem("Select Category", "-1"));
        }
        ds.Dispose();
    }
    #endregion

    #region Save Details

    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            bool flagcheck = false;
            DataSet dsDelete = obj.GetCategoryDetails("DeleteDetails", ddlCategory.SelectedValue, hdnFlag.Value);
            for (Int32 Counter = 0; Counter < grdData.Rows.Count; Counter++)
            {
                DataSet ds = new DataSet();
                CheckBox chkval = (CheckBox)(grdData.Rows[Counter].FindControl("chkrow"));
                if (chkval.Checked == true)
                {
                    Label lblRelatedCatID = (Label)(grdData.Rows[Counter].FindControl("lblCatID"));
                    DropDownList ddlPriority = (DropDownList)(grdData.Rows[Counter].FindControl("ddlPriority"));
                    ds = obj.SaveCategoryMapping("SAVEDETAILS", "", ddlCategory.SelectedValue, lblRelatedCatID.Text, "1", ddlPriority.SelectedValue, "NATAL" , hdnFlag.Value);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                         flagcheck = true;
                    }
                    else
                    {
                        flagcheck = false;
                        ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddMappingCategory), "wq", "alert('Some Error Occured');", true);
                    }
                 }
            }
            if (flagcheck == true)
            {
               
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddMappingCategory), "wq", "alert('Record Save Successfully');", true);
                BindGrid();
            }
            if (flagcheck == false)
            {

                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AddMappingCategory), "wq", "alert('Warning!..You have not checked any Checkbox.');", true);
               
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion

    #region Load Data
    protected void LoadData(string id)
    {
        if (id == "") return;
        DataSet ds = new DataSet();
        ds = obj.GetCategoryDetails("GETMAPDETAILSBYID" , id, hdnFlag.Value);
        if(ds.Tables[0].Rows.Count > 0)
        {
            //btnSave.Text = "Update";
            //lblId.Text = ds.Tables[0].Rows[0]["AUTO_ID"].ToString();
            //ddlCatID.SelectedValue = ds.Tables[0].Rows[0]["CATEGORY_ID"].ToString();
            //ddlCatReatedID.SelectedValue = ds.Tables[0].Rows[0]["CATEGORY_MAPPED_ID"].ToString();
            //ddlPriority.SelectedValue = ds.Tables[0].Rows[0]["PRIORITY"].ToString();
            //ddlStatus.SelectedValue = ds.Tables[0].Rows[0]["STATUS"].ToString();
        }
    }

    #endregion

    #region Search
    protected void btnSearch_Click(object sender , EventArgs e)
    {
        BindGrid();
    }
    #endregion

    #region BindGrid
    protected void BindGrid()
    {
        try
        {
            DataSet ds = new DataSet();
            ds = obj.GetCategoryDetails("GETCATDETAILSBYID", ddlCategory.SelectedValue , hdnFlag.Value);
            if (ds.Tables[0].Rows.Count > 0)
            {
                grdData.DataSource = ds.Tables[0];
                grdData.DataBind();
                for (int i = 0; i < grdData.Rows.Count; i++)
                {
                    Label lblStatus = (Label)(grdData.Rows[i].FindControl("lblStatus"));
                    Label lblPriority = (Label)(grdData.Rows[i].FindControl("lblPriority"));
                    CheckBox chk = (CheckBox)(grdData.Rows[i].FindControl("chkrow"));
                    DropDownList ddl = (DropDownList)(grdData.Rows[i].FindControl("ddlPriority"));
                    if (lblStatus.Text == "1")
                    {
                        chk.Checked = true;
                        ddl.SelectedValue = lblPriority.Text;
                    }
                }
            }
            else
            {
                grdData.DataSource = null;
                grdData.DataBind();
            }
            ds.Dispose();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion

    #region Grid Events
    protected void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdData.PageIndex = e.NewPageIndex;
        BindGrid();
    }
    #endregion

    #region Reset
    protected void BtnReset_Click(object sender , EventArgs e)
    {
        common.ClearAllControls(Page.Controls);
        grdData.DataSource = null;
    }
    #endregion
}