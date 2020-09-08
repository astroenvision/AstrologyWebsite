using System;
using System.Data;
using System.Web.UI.WebControls;
using ASTROLOGY.classesoracle;
using System.Configuration;

public partial class admin_ManageCategoryPrice : System.Web.UI.Page
{
    #region Declarartions
    common Common = new common();
    subscription obj = new subscription();
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    public string AdminUserId = "", AdminEmailId = "";
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (AdminStateManagement == "COOKIE")
        {
            if (Request.Cookies["AdminCookies"] != null)
            {
                AdminUserId = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
                if (!IsPostBack)
                {
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
    #region Grid Events
    protected void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdData.PageIndex = e.NewPageIndex;
        BindGrid();
    }
    #endregion
    protected void BindGrid()
    {
        try
        {
            DataSet ds = new DataSet();
            ds = obj.ManageCategoryPrice("GETALLCATPRICE", ddlCat.SelectedValue, "", "");
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
                grdData.DataSource = ds.Tables[0];
                grdData.DataBind();
            }
            else
            {
                lbl_result.InnerHtml = "Search Found  <font size=\"3\" color=\"red\">0</font> result(s).";
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

    protected void BindCategory()
    {
        ddlCat.Items.Clear();
        DataSet ds = new DataSet();
        ds = Common.Get_Natal_cat("");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlCat.DataSource = ds.Tables[0];
            ddlCat.DataValueField = "CATEGORY_ID";
            ddlCat.DataTextField = "CATEGORY_NAME";
            ddlCat.DataBind();
            ddlCat.Items.Insert(0, new ListItem("Select Category", "-1")); ;
        }
        ds.Dispose();
    }

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