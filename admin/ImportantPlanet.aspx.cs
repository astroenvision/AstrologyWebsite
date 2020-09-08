using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_ImportantPlanet : System.Web.UI.Page
{
    #region Declarations
    admin obj = new admin();
    subscription sub_obj = new subscription();
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    public string AdminUserId = "", AdminEmailId = "", Month = "";
    #endregion

    #region PageLoad
    protected void Page_Load(object sender, EventArgs e)
    {
        if (AdminStateManagement == "COOKIE")
        {
            if (Request.Cookies["AdminCookies"] != null)
            {
                AdminUserId = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
                if (!Page.IsPostBack)
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
                if (!Page.IsPostBack)
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
        DateTime dt = DateTime.Now;
        Month = Convert.ToString(dt.Month);
        if (Request.QueryString["q"] != null)
        {
            Month = "";
        }
        DataSet ds = new DataSet();
        string flag = ddlPlanet.SelectedValue;
        heading.InnerHtml = ddlPlanet.SelectedItem.Text;
        ds = obj.GetDashboardDetailsNew("GETDETAILS", txtUserName.Text, txtFromDate.Text, txtToDate.Text, ddlSearchBy.SelectedValue, ddlSortColumn.SelectedValue, ddlSortBy.SelectedValue , ddlPlanet.SelectedValue, Month);
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

    #region Select Change Events
    protected void ddlSearchBy_SelectChange(object sender, EventArgs e)
    {
        if (ddlSearchBy.SelectedValue == "Date")
        {
            FromDate.Visible = true;
            ToDate.Visible = true;
            Name.Visible = false;
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

    protected void grdData_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        DataRowView drv = e.Row.DataItem as DataRowView;
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            var lnk = (HyperLink)e.Row.FindControl("lnkaReport");
            Label ID = (Label)e.Row.FindControl("lblID");
            Label lblEMailID = (Label)e.Row.FindControl("lblEMailID");

            string FlagVal = ddlPlanet.SelectedValue;
            if (FlagVal == "9")
            {
                FlagVal = "single";
            }
            else if (FlagVal == "10")
            {
                FlagVal = "two";
            }
            else
            {
                FlagVal = "three";
            }

                lnk.NavigateUrl = "~/most_important_planet_report.aspx?userid=" + ID.Text + "&useremailid=" + lblEMailID.Text + "&flag=" + FlagVal;
              }
       }

    #region Row Command
    protected void grdData_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Delete")
        {
            int rowno = Convert.ToInt32(e.CommandArgument.ToString());
            DataSet ds = new DataSet();
            ds = sub_obj.AstDeleteCommon(rowno.ToString(), "", "", "", "DELETE_PLANET_DTLS");
            if (ds.Tables[0].Rows.Count > 0)
            {
                string outresult = ds.Tables[0].Rows[0]["OUTRESULT"].ToString();
                if (outresult == "Y")
                {
                    Response.Redirect("~/admin/ImportantPlanet.aspx");
                    //BindGrid();
                    //ScriptManager.RegisterClientScriptBlock(this, typeof(admin_FreeUserList), "wq", "alert('Record deleted successfully!');", true);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ImportantPlanet), "wq", "alert('Some error occured!');", true);
                    return;
                }

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ImportantPlanet), "wq", "alert('Some error occured!');", true);
                return;
            }
        }
    }
    #endregion

}