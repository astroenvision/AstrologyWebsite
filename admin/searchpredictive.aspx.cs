using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_searchpredictive : System.Web.UI.Page
{
    #region Declarations
    Houseposition house_obj = new Houseposition();
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
                {BindGrid();
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
        ds = obj.GetPredictive("GET_DETAILS_BY_SCRH", "", txtpredictive.Text , ddlchecked.SelectedValue , ddlstatus.SelectedValue);
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
            grdData.DataSource = ds;
            grdData.DataBind();
        }
        ds.Dispose();

    }
    #endregion

    #region Search Button Click
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindGrid();
    }
    #endregion

    #region Reset Click
    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtpredictive.Text = "";
        BindGrid();
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

    #region Row Command
    protected void grdData_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Delete")
        {
            string rowno = e.CommandArgument.ToString();
            DataSet ds = new DataSet();
            ds = obj.SavePredictive("DELETED", rowno, "","", "", "", "", "","", "", "", "", "", "", "", "","","");
            if (ds.Tables[0].Rows.Count > 0)
            {
                string outresult = ds.Tables[0].Rows[0]["STATUS"].ToString();
                if (outresult == "1")
                {
                    Response.Redirect("~/admin/searchpredictive.aspx");
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(admin_searchpredictive), "wq", "alert('Some error occured!');", true);
                    return;
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_searchpredictive), "wq", "alert('Some error occured!');", true);
                return;
            }
        }
    }
    #endregion

    #region Row Data Bound
    protected void grdData_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            DataRowView drv = e.Row.DataItem as DataRowView;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //HyperLink btnedit = (HyperLink)e.Row.FindControl("btnedit");
                //btnedit.NavigateUrl = ResolveUrl("~/admin/UpdatePredictive.aspx?table=" + TableName + "&autoid=" + lblautoid.Text.Trim() + "");
                //HyperLink btnaddcat = (HyperLink)e.Row.FindControl("btnaddcat");
                //btnaddcat.NavigateUrl = ResolveUrl("~/admin/natal_update_predictive.aspx?table=" + TableName + "&keystring=" + lblkeystring.Text.Trim() + "&logic=" + lbllogic.Text.Trim() + "");

                Label lblpredictivestatus = (Label)e.Row.FindControl("lblpredictivestatus");
                HiddenField hdnstatus = (HiddenField)e.Row.FindControl("hdnstatus");
                HiddenField hdnchecked = (HiddenField)e.Row.FindControl("hdnchecked");
                if (hdnchecked.Value.Trim() == "T")
                {
                    lblpredictivestatus.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblpredictivestatus.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    #endregion
}