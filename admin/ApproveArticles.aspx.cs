using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.IO;
using ASTROLOGY.classesoracle;
using System.Threading;

public partial class admin_ApproveArticles : System.Web.UI.Page
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
            ds = obj.Get_Article_Data(ddlCategory.SelectedValue.ToString().Trim(), ddlGroup.SelectedValue.ToString().Trim(), "0", "GET_ARTICLES", ddlStatus.SelectedValue.ToString().Trim(),"");
            if (ds.Tables[0].Rows.Count > 0)
            {
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
    protected void ddlGroup_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlCategory.Items.Clear();
        DataSet ds = new DataSet();
        string GroupID = ddlGroup.SelectedValue.ToString().Trim();
        ds = obj.Get_Categories("",GroupID, "");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlCategory.DataSource = ds.Tables[0];
            ddlCategory.DataValueField = "CAT_ID";
            ddlCategory.DataTextField = "CAT_NAME";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, new ListItem("Select Category", "-1")); ;
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
                        ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ApproveArticles), "wq", "alert('" + Msg + "');", true);
                        flagcheck = true;
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ApproveArticles), "wq", "alert('Some Error Occured');", true);

                    }
                    //ddlCategory.SelectedValue = "-1";
                    //ddlGroup.SelectedValue = "-1";
                    //ddlStatus.SelectedValue = "-1";
                    BindGrid();
                }
            }
            if (flagcheck == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ApproveArticles), "wq", "alert('Warning! You have not checked any Checkbox.');", true);
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion
}