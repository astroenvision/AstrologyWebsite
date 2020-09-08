using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_PaidMatchingUser : System.Web.UI.Page
{
    #region Declarations
    admin obj = new admin();
    subscription sub_obj = new subscription();
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    public string AdminUserId = "", AdminEmailId = "" ,Month = "";
    #endregion

    #region PageLoad
    protected void Page_Load(object sender, EventArgs e)
    {
        DateTime dt = DateTime.Now;
        Month = Convert.ToString(dt.Month);
        if (Request.QueryString["q"] != null)
        {
            Month = "";
        }

        if (AdminStateManagement == "COOKIE")
        {
            if (Request.Cookies["AdminCookies"] != null)
            {
                AdminUserId = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
                if (!IsPostBack)
                {
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

    #region Bind Grid
    protected void BindGrid()
    {
        DataSet ds = new DataSet();
        string SearchBy = txtUserName.Text;
        if (ddlPyamentStatus.SelectedValue != "-1")
        {
            SearchBy = ddlPyamentStatus.SelectedValue;
        }
        ds = obj.GetDashboardDetailsNew("GET_MATCHING_USER", SearchBy, txtFromDate.Text, txtToDate.Text,
                                           ddlSearchBy.SelectedValue, ddlSortColumn.SelectedValue, ddlSortBy.SelectedValue, "5", Month);
       if (ds.Tables[0].Rows.Count > 0)
        {

            int iTotalRecords = ds.Tables[0].Rows.Count;
            int iEndRecord = grdData.PageSize * (grdData.PageIndex + 1);
            int iStartsRecods = iEndRecord - grdData.PageSize;
            if (iEndRecord > iTotalRecords)
            {
                iEndRecord = iTotalRecords;
            }
            if (iStartsRecods == 0)
            {
                iStartsRecods = 1;
            }
            if (iEndRecord == 0)
            {
                iEndRecord = iTotalRecords;
            }
            lbl_result.InnerHtml = "Records <font size=\"3\" color=\"red\">" + iStartsRecods + "</font> TO <font size=\"3\" color=\"red\">" + iEndRecord.ToString() + "</font> Of <font size=\"3\" color=\"red\">" + iTotalRecords.ToString() + "</font> .";

            grdData.DataSource = ds;
            grdData.DataBind();
        }
        else
        {
            lbl_result.InnerHtml = "Records <font size=\"3\" color=\"red\">" + 0 + "</font> TO <font size=\"3\" color=\"red\">" + 0 + "</font> Of <font size=\"3\" color=\"red\">" + 0 + "</font> .";
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

    #region BUtton Events
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindGrid();
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        common.ClearAllControls(Page.Controls);
        BindGrid();
    }
    #endregion

    #region Select Change Events
    protected void ddlSearchBy_SelectChange(object sender, EventArgs e)
    {
        if (ddlSearchBy.SelectedValue == "Date")
        {
            FromDate.Visible = true;
            ToDate.Visible = true;
            Name.Visible = false;
        }
        else if (ddlSearchBy.SelectedValue == "PaymentStatus")
        {
            FromDate.Visible = false;
            ToDate.Visible = false;
            Name.Visible = false;
            divPyamentStatus.Visible = true;
        }
        else if (ddlSearchBy.SelectedValue == "Name" || ddlSearchBy.SelectedValue == "MobileNo" || ddlSearchBy.SelectedValue == "Email")
        {
            FromDate.Visible = false;
            ToDate.Visible = false;
            Name.Visible = true;
        }
        else
        {
            FromDate.Visible = false;
            ToDate.Visible = false;
            Name.Visible = false;
        }
    }

    #endregion

    #region Row Command
    protected void grdData_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Delete")
        {
            int rowno = Convert.ToInt32(e.CommandArgument.ToString());
            DataSet ds = new DataSet();
            ds = sub_obj.AstDeleteCommon(rowno.ToString(), "", "", "", "DELETE_PAID_MATCHING_CHART_DETAILS");
            if (ds.Tables[0].Rows.Count > 0)
            {
                string outresult = ds.Tables[0].Rows[0]["OUTRESULT"].ToString();
                if (outresult == "Y")
                {
                    Response.Redirect("~/admin/PaidMatchingUser.aspx");
                    //BindGrid();
                    //ScriptManager.RegisterClientScriptBlock(this, typeof(admin_FreeUserList), "wq", "alert('Record deleted successfully!');", true);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(admin_PaidMatchingUser), "wq", "alert('Some error occured!');", true);
                    return;
                }

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_PaidMatchingUser), "wq", "alert('Some error occured!');", true);
                return;
            }
        }
    }
    #endregion
}