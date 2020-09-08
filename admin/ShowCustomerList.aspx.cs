using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_ShowCustomerList : System.Web.UI.Page
{
    #region Declarations
    admin obj = new admin();
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    public string AdminUserId = "", AdminEmailId = "";
    #endregion

    #region PageLoad
    protected void Page_Load(object sender, EventArgs e)
    {
        if (AdminStateManagement == "COOKIE")
        {
            if (Request.Cookies["AdminCookies"] != null)
            {
                AdminUserId = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
                if (!IsPostBack)
                {
                    BindAstrologer();
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
                    BindAstrologer();
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

    #region BindAstrologer
    protected void BindAstrologer()
    {
        ddlAstrologer.Items.Clear();
        DataSet ds = new DataSet();
        ds = obj.ManageMapingDetails("GET_ASTROLOGER_LIST", "1" , "", "","","","","","");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlAstrologer.DataSource = ds.Tables[0];
            ddlAstrologer.DataValueField = "USER_ID";
            ddlAstrologer.DataTextField = "NAME";
            ddlAstrologer.DataBind();
            ddlAstrologer.Items.Insert(0, new ListItem("Select Astrologer", "-1"));
            if(Session["IsAdmin"]!=null)
            {
                string IsAdmin = Session["IsAdmin"].ToString();
                if(IsAdmin =="0" || IsAdmin == "")
                {
                    ddlAstrologer.SelectedValue = Session["UserID"].ToString();
                    ddlAstrologer.Enabled = false;
                }
                else
                {
                    ddlAstrologer.Enabled = true;
                }
            } 
        }
        ds.Dispose();
    }
    #endregion

    #region Bind Grid
    protected void BindGrid()
    {
        DataSet ds = new DataSet();
        ds = obj.ManageMapingDetails("GET_CUSTOMER_MAPPING", ddlAstrologer.SelectedValue, ddlConsultType.SelectedValue, "","","","","","");
        if (ds.Tables[0].Rows.Count > 0)
        {
            grdData.DataSource = ds;
            grdData.DataBind();
        }
        else
        {
            grdData.DataSource = ds;
            grdData.DataBind();
        }
        ds.Dispose();

    }
    #endregion

    #region Grid Events
    protected void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            grdData.PageIndex = e.NewPageIndex;
            BindGrid();
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    #endregion

    #region Search Button Click
    protected void btnSearch_Click(object sender , EventArgs e)
    {
        BindGrid();
    }
    #endregion

    #region Reset Click
    protected void btnReset_Click(object sender , EventArgs e)
    {
        common.ClearAllControls(Page.Controls);
        BindGrid();
    }
    #endregion
}