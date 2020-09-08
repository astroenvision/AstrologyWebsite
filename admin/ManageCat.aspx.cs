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

public partial class admin_ManageCat : System.Web.UI.Page
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
                    Thread.Sleep(10000);
                    BindCategory();
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
                    Thread.Sleep(10000);
                    BindCategory();
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

    #region BindGrid
    protected void BindGrid()
    {
        try
        {
            DataSet ds = new DataSet();
            ds = obj.ManageCategory("GETCATDETAILS", ddlCategory.SelectedValue, "", "", "", "", "", "" , "" , "" , "","","","","","","","","");
            if (ds.Tables[0].Rows.Count > 0)
            {
                grdData.DataSource = ds.Tables[0];
                grdData.DataBind();
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

    #region BindCategory
    protected void BindCategory()
    {
        ddlCategory.Items.Clear();
        DataSet ds = new DataSet();
        ds = Common.Get_Natal_cat("");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlCategory.DataSource = ds.Tables[0];
            ddlCategory.DataValueField = "FINAL_CATID";
            ddlCategory.DataTextField = "FINAL_CATEGERY";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, new ListItem("Select Category", "-1")); ;
        }
        ds.Dispose();
    }
    #endregion

    #region Search Click
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindGrid();
    }
    #endregion

    #region Reset 
    protected void btnReset_Click(object sender, EventArgs e)
    {
        common.ClearAllControls(Page.Controls);
        BindGrid();
    }
    #endregion
}