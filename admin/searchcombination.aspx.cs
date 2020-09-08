using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_searchcombination : System.Web.UI.Page
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
                    BindDropDown();
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
                    BindDropDown();
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
        ds = obj.GetCombination("GET_DETAILS_BY_SCRH", "",ddlChartNo.SelectedValue , ddlRashi.SelectedValue , ddlHouse.SelectedValue , ddlPlanet.SelectedValue , txtLogicDesc.Text);
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

    #region Bind DropDown
    protected void BindDropDown()
    {
        DataSet ds = new DataSet();
        ds = house_obj.ast_chart("");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlChartNo.Items.Clear();
            ddlChartNo.DataSource = ds.Tables[0];
            ddlChartNo.DataTextField = "CHART_NO";
            ddlChartNo.DataValueField = "CHART_NO";
            ddlChartNo.DataBind();
            ddlChartNo.Items.Insert(0, new ListItem("Select Chart", ""));
            ds.Dispose();
        }

        ds = house_obj.ast_house("");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlHouse.Items.Clear();
            ddlHouse.DataSource = ds.Tables[0];
            ddlHouse.DataTextField = "Name";
            ddlHouse.DataValueField = "Code";
            ddlHouse.DataBind();
            ddlHouse.Items.Insert(0, new ListItem("Select House", ""));
            ds.Dispose();
        }

        ds = house_obj.ast_planet("");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlPlanet.Items.Clear();
            ddlPlanet.DataSource = ds.Tables[0];
            ddlPlanet.DataTextField = "Name";
            ddlPlanet.DataValueField = "Code";
            ddlPlanet.DataBind();
            ddlPlanet.Items.Insert(0, new ListItem("Select Planet", ""));
             ds.Dispose();
        }

        ds = house_obj.ast_rashi("");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlRashi.Items.Clear();
            ddlRashi.DataSource = ds.Tables[0];
            ddlRashi.DataTextField = "Name";
            ddlRashi.DataValueField = "Code";
            ddlRashi.DataBind();
            ddlRashi.Items.Insert(0, new ListItem("Select Rashi", ""));
             ds.Dispose();
        }

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
        ddlPlanet.SelectedValue = "";
        ddlHouse.SelectedValue = "";
        ddlRashi.SelectedValue = "";
        ddlChartNo.SelectedValue = "";
        txtLogicDesc.Text = "";
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
            ds = obj.SaveCombinatiom("DELETED", rowno, "", "", "", "","","","","","","","","","","","","","","","","","","","","","","");
            if (ds.Tables[0].Rows.Count > 0)
            {
                string outresult = ds.Tables[0].Rows[0]["STATUS"].ToString();
                if (outresult == "1")
                {
                    Response.Redirect("~/admin/searchcombination.aspx");
                    //BindGrid();
                    //ScriptManager.RegisterClientScriptBlock(this, typeof(admin_FreeUserList), "wq", "alert('Record deleted successfully!');", true);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(admin_searchcombination), "wq", "alert('Some error occured!');", true);
                    return;
                }

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_searchcombination), "wq", "alert('Some error occured!');", true);
                return;
            }
        }
    }
    #endregion

}