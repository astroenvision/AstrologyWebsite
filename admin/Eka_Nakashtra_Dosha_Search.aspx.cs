using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class admin_Eka_Nakashtra_Dosha_Search : System.Web.UI.Page
{
    #region Declarations
    admin obj = new admin();
    common common = new common();
    subscription sub = new subscription();
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
                    BindConstellation();
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
                    BindConstellation();
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

    #region Bind Constellation 
    protected void BindConstellation()
    {
        DataSet ds = new DataSet();
        ddlGirlConstellation.Items.Clear();
        ddlBoyConstellation.Items.Clear();
        ds = common.GetConstellation();
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlGirlConstellation.DataSource = ds.Tables[0];
            ddlGirlConstellation.DataValueField = "NAME";
            ddlGirlConstellation.DataTextField = "NAME";
            ddlGirlConstellation.DataBind();
            ddlGirlConstellation.Items.Insert(0, new ListItem("Select Girl Constellation", "-1"));
            ddlBoyConstellation.DataSource = ds.Tables[0];
            ddlBoyConstellation.DataValueField = "NAME";
            ddlBoyConstellation.DataTextField = "NAME";
            ddlBoyConstellation.DataBind();
            ddlBoyConstellation.Items.Insert(0, new ListItem("Select Boy Constellation", "-1"));
        }
    }
    #endregion

    #region Bind Grid
    protected void BindGrid()
    {
        DataSet ds = new DataSet();
        ds = obj.GetAshtakootPredictive("Eka_Nakashtra_Dosha_By_Search", "", ddlGirlConstellation.SelectedValue, ddlBoyConstellation.SelectedValue);
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

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindGrid();
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        common.ClearAllControls(Page.Controls);
        BindGrid();
    }
}