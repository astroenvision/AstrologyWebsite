using ASTROLOGY.classesoracle;
using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_ManageClientCmnt : System.Web.UI.Page
{
    #region Declarations
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
        string QuesID = "";
        if(Request.QueryString["q"] !=null)
        {
            QuesID = Request.QueryString["q"].ToString();
        }
        DataSet ds = new DataSet();
        ds = sub.SaveClientQuestionComment("GET_DETAILS", "0", QuesID , "","","","","","");
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

    #region Grid Events
    protected void grdData_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
        grdData.EditIndex = -1;
        BindGrid();
    }

    protected void grdData_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DataSet ds = new DataSet();
        Label lblID = grdData.Rows[e.RowIndex].FindControl("lblID") as Label;
        ds = sub.SaveClientQuestionComment("DELETE", lblID.Text, "", "", "", "", "", "","");
        if (ds.Tables[0].Rows.Count > 0)
        {
            string STATUS = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if (STATUS != "N")
            {
                string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ManageClientCmnt), "wq", "alert(' " + Message + "');", true);
                BindGrid();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ManageClientCmnt), "wq", "alert('Some Error Occured');", true);
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ManageClientCmnt), "wq", "alert('Some Error Occured');", true);
        }
    }

    protected void grdData_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grdData.EditIndex = e.NewEditIndex;


        BindGrid();
    }

    protected void grdData_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        DataSet ds = new DataSet();
        Label lblID = grdData.Rows[e.RowIndex].FindControl("lblID") as Label;
        Label lblReplyID = grdData.Rows[e.RowIndex].FindControl("lblReplyID") as Label;
        Label lblQuestionID = grdData.Rows[e.RowIndex].FindControl("lblQuestionID") as Label;
        TextBox txtReply = grdData.Rows[e.RowIndex].FindControl("txtReply") as TextBox;
        string Flag = "INSERT";
        string ReplyID = "0";
        if (lblReplyID.Text !="")
        {
            ReplyID = lblReplyID.Text;
            Flag = "UPDATE";
        }
         ds = sub.SaveClientCommentReply(Flag, ReplyID, lblID.Text, lblQuestionID.Text , txtReply.Text , AdminUserId ,"1");
        if (ds.Tables[0].Rows.Count > 0)
        {
            string STATUS = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if (STATUS != "0")
            {
                string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ManageClientCmnt), "wq", "alert(' " + Message + "');", true);
                grdData.EditIndex = -1;
                BindGrid();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ManageClientCmnt), "wq", "alert('Some Error Occured');", true);
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ManageClientCmnt), "wq", "alert('Some Error Occured');", true);
        }

    }

    #endregion
}