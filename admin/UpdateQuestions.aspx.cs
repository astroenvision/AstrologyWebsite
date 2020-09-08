using ASTROLOGY.classesoracle;
using System;
using System.Configuration;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class admin_UpdateQuestions : System.Web.UI.Page
{
    #region Declaration
    public string ID = "0";
    public string PayType = "0";
    dailyarticle obj = new dailyarticle();
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

    #region BindGrid
    protected void BindGrid()
    {
        try
        {
            if (Request.QueryString["q"] != "")
            {
                ID = Request.QueryString["q"].ToString();
                DataSet ds = new DataSet();
                ds = obj.ManageCategory("GETQUESIONS", ID, "", "", "", "", "", "" , "" , "","","","","","","","","","");
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

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    protected void grdData_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
    {
        //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
        grdData.EditIndex = -1;
        BindGrid();
    }
    protected void grdData_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
    {
        //NewEditIndex property used to determine the index of the row being edited.  
        grdData.EditIndex = e.NewEditIndex;
        BindGrid();
    }
    protected void grdData_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
    {
        ////Finding the controls from Gridview for the row which is going to update  
        Label lblCat = grdData.Rows[e.RowIndex].FindControl("lbl_Category") as Label;
        TextBox txtQus = grdData.Rows[e.RowIndex].FindControl("txtQuestions") as TextBox;
        Label lblOldQus = grdData.Rows[e.RowIndex].FindControl("lblOldQus") as Label;


        DataSet ds = obj.UpdateQuestions("UPDATEQUESIONS", lblOldQus.Text, txtQus.Text, lblCat.Text);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_UpdateQuestions), "wq", "alert(' " + Message + "');", true);
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_UpdateQuestions), "wq", "alert('Some Error Occured!!');", true);
        }

        BindGrid();
    }
    #endregion

    #region Grid Events
    protected void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdData.PageIndex = e.NewPageIndex;
        BindGrid();
    }
    #endregion
}