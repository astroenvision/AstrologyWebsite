using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASTROLOGY.classesoracle;
using System.Threading;
using System.Configuration;

public partial class admin_ApproveArticle : System.Web.UI.Page
{
    #region Declarartions
    dailyarticle obj = new dailyarticle();
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
                    //BindGrid();
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
                    //BindGrid();
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
        try
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "Close Modal Popup", "StartLoader();", true);
            DataSet ds = new DataSet();
            string CatID = "";
            if (ddlSubCat.SelectedValue == "-1")
            {
                CatID = ddlCategory.SelectedValue;
            }
            else
            {
                CatID = ddlSubCat.SelectedValue;
            }
            ds = obj.Get_Article_Data(CatID, ddlGroup.SelectedValue.ToString().Trim(), "0", "GET_ARTICLES", ddlStatus.SelectedValue.ToString().Trim() , txtHeadline.Text);
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
                for (int i = 0; i < grdData.Rows.Count; i++)
                {
                    Label lblStatus = (Label)(grdData.Rows[i].FindControl("lblStatus"));
                    Label lblStatusVal = (Label)(grdData.Rows[i].FindControl("lblStatusVal"));


                    if (lblStatus.Text == "Approved")
                    {
                        lblStatusVal.CssClass = "badge badge-success badge-pill";
                    }

                    if (lblStatus.Text == "UnApproved")
                    {
                        lblStatusVal.CssClass = "badge badge-primary badge-pill";
                    }
                }
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
    #endregion

    #region Grid Events
    protected void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdData.PageIndex = e.NewPageIndex;
        BindGrid();
    }
    #endregion

    #region CatName OnChange
    protected void ddlCatName_OnChange(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        ds = obj.Get_Categories("BindSubCat", ddlGroup.SelectedValue.ToString().Trim(), ddlCategory.SelectedValue);
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlSubCat.Items.Clear();
            ddlSubCat.DataSource = ds.Tables[0];
            ddlSubCat.DataValueField = "CAT_ID";
            ddlSubCat.DataTextField = "CAT_NAME";
            ddlSubCat.DataBind();
            ddlSubCat.Items.Insert(0, new ListItem("Select Sub Category", "-1")); ;
        }
        ds.Dispose();
    }
    #endregion

    #region BindCategory
    protected void ddlGroup_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlCategory.Items.Clear();
        DataSet ds = new DataSet();
        string GroupID = ddlGroup.SelectedValue.ToString().Trim();
        ds = obj.Get_Categories("", GroupID, "");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlCategory.DataSource = ds.Tables[0];
            ddlCategory.DataValueField = "CAT_ID";
            ddlCategory.DataTextField = "CAT_NAME";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, new ListItem("Select Category", "-1"));
        }
        else
        {
            ddlCategory.Items.Insert(0, new ListItem("Select Category", "-1")); 
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
        ddlCategory.SelectedValue = "-1";
        ddlGroup.SelectedValue = "-1";
        ddlStatus.SelectedValue = "-1";
        BindGrid();

    }
    #endregion

    #region Approve Click
    protected void btnApproved_Click(object sender, EventArgs e)
    {
        ApproveTestimonialsACtion("A");
    }
    #endregion

    #region UnApproved Click
    protected void btnUnapproved_Click(object sender, EventArgs e)
    {
        ApproveTestimonialsACtion("P");
    }
    #endregion

    #region Approver Action
    protected void ApproveTestimonialsACtion(string status)
    {
        try
        {
            bool flagcheck = false;
            for (Int32 Counter = 0; Counter < grdData.Rows.Count; Counter++)
            {
                DataSet ds = new DataSet();
                CheckBox chkval = (CheckBox)(grdData.Rows[Counter].FindControl("chkrow"));
                if (chkval.Checked == true)
                {
                    Label lblAuto_Id = (Label)(grdData.Rows[Counter].FindControl("lblID"));
                    string id = lblAuto_Id.Text;
                    ds = obj.ManageArticlesRequest("MANAGE_REQUEST", id, status);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        string Msg = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
                        ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ApproveArticle), "wq", "alert('" + Msg + "');", true);
                        flagcheck = true;
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ApproveArticle), "wq", "alert('Some Error Occured');", true);

                    }
                    //ddlCategory.SelectedValue = "-1";
                    //ddlGroup.SelectedValue = "-1";
                    //ddlStatus.SelectedValue = "-1";
                    BindGrid();
                }
            }
            if (flagcheck == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ApproveArticle), "wq", "alert('Warning! You have not checked any Checkbox.');", true);
            }


        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion
}