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

public partial class admin_ManagePackage : System.Web.UI.Page
{
    #region Declarartions
    common Common = new common();
    subscription obj = new subscription();
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

    #region Grid Events
    protected void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdData.PageIndex = e.NewPageIndex;
        BindGrid();
    }
    #endregion

    #region BindGrid
    protected void BindGrid()
    {
        try
        {
            DataSet ds = new DataSet();
            ds = obj.ManagePackage("GETALLCATPRICE", "", "", "", "");
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

    #region Update Click
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        ds = obj.ManagePackage("UPDATEPACKAGEPRICE", ddlCatFrom.SelectedValue, ddlCatTO.SelectedValue, txtUsdDiscount.Text.Trim(), txtInrDiscount.Text.Trim());
        if (ds.Tables[0].Rows.Count > 0)
        {
            string Message = ds.Tables[0].Rows[0]["Message"].ToString();
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ManagePackage), "wq", "alert('" + Message + "');", true);
            common.ClearAllControls(Page.Controls);
            BindGrid();
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ManagePackage), "wq", "alert('Some Error Occured');", true);
        }
    }

    #endregion

    #region Reset Click
    protected void btnReset_Click(object sender, EventArgs e)
    {
        try
        {
            common.ClearAllControls(Page.Controls);
            BindGrid();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion
}