using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_ManageAstrologerPrice : System.Web.UI.Page
{
    #region Declarartions
    common Common = new common();
    admin obj = new admin();
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
                    BindAstrologer();
                    if (Request.QueryString["q"] != null)
                    {
                        string AstrologerID = Request.QueryString["q"].ToString();
                        ddlAstrologer.SelectedValue = AstrologerID;
                    }
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
                    BindAstrologer();
                    if (Request.QueryString["q"] != null)
                    {
                        string AstrologerID = Request.QueryString["q"].ToString();
                        ddlAstrologer.SelectedValue = AstrologerID;
                    }
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

    #region BindAstrologer
    protected void BindAstrologer()
    {
        ddlAstrologer.Items.Clear();
        DataSet ds = new DataSet();
        ds = obj.ManageMapingDetails("GET_ASTROLOGER_LIST", "1", "", "","","","","","");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlAstrologer.DataSource = ds.Tables[0];
            ddlAstrologer.DataValueField = "USER_ID";
            ddlAstrologer.DataTextField = "NAME";
            ddlAstrologer.DataBind();
            ddlAstrologer.Items.Insert(0, new ListItem("Select Astrologer", "-1"));
       }
        ds.Dispose();
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
            ds = obj.ManageAstrologerPrice("GET_PRICE_DETAILS_FOR_GRID", "", ddlAstrologer.SelectedValue, txtNoOfMinutes.Text,
               txtPrice.Text, txtInrDiscount.Text, txtFinalPrice.Text, txtPriceUSD.Text, txtDiscountUSD.Text, txtFinalPriceUSD.Text, "", "",ddlPaymentFor.SelectedValue,"");
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

    #region Row Command
    protected void grdData_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            string ID = e.CommandArgument.ToString();
            if (e.CommandName.Equals("EditPrice"))
            {
                DataSet ds = new DataSet();
                ds = obj.ManageAstrologerPrice("GET_PRICE_DETAILS_BY_ID", ID, ddlAstrologer.SelectedValue, txtNoOfMinutes.Text,
                txtPrice.Text, txtInrDiscount.Text, txtFinalPrice.Text, txtPriceUSD.Text, txtDiscountUSD.Text, txtFinalPriceUSD.Text, "", "","","");
                if(ds.Tables[0].Rows.Count > 0)
                {
                    lblID.Text = ds.Tables[0].Rows[0]["ID"].ToString();
                    ddlAstrologer.SelectedValue = ds.Tables[0].Rows[0]["ASTROLOGER_ID"].ToString();
                    txtPrice.Text = ds.Tables[0].Rows[0]["PRICE_INR"].ToString();
                    txtInrDiscount.Text = ds.Tables[0].Rows[0]["DISCOUNT_INR"].ToString();
                    txtFinalPrice.Text = ds.Tables[0].Rows[0]["FINAL_PRICE_INR"].ToString();
                    hdnPrice.Value = ds.Tables[0].Rows[0]["PRICE_INR"].ToString();
                    txtDiscountUSD.Text = ds.Tables[0].Rows[0]["DISCOUNT_USD"].ToString();
                    txtPriceUSD.Text = ds.Tables[0].Rows[0]["PRICE_USD"].ToString();
                    txtFinalPriceUSD.Text = ds.Tables[0].Rows[0]["FINAL_PRICE_USD"].ToString();
                    ddlPaymentFor.SelectedValue = ds.Tables[0].Rows[0]["PAYMENT_FOR"].ToString();
                    txtNoOfQuestions.Text = ds.Tables[0].Rows[0]["NO_OF_QUESTIONS"].ToString();
                    txtNoOfMinutes.Text = ds.Tables[0].Rows[0]["NO_OF_MINUTES"].ToString();
                    string Status = ds.Tables[0].Rows[0]["STATUS"].ToString();
                    if(Status =="1")
                    {
                        chkStatus.Checked = true;
                    }
                    else
                    {
                        chkStatus.Checked = false;
                    }
                    btnUpdate.Text = "Update";
                }
            }
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

        string Flag = "INSERT_PRICE";
        if(lblID.Text !="")
        {
            Flag = "UPDATE_PRICE";
        }
        DataSet ds = new DataSet();
        string ModifyBy = "";
        string Status = "0";
        if(chkStatus.Checked == true)
        {
            Status = "1";
        }
        if (Session["UserID"] != null)
        {
            ModifyBy = Session["UserID"].ToString();
        }
        string NoOfQuestions = "";
        if(ddlPaymentFor.SelectedValue == "CONSULT_AN_ASTROLOGER")
        {
            NoOfQuestions = txtNoOfQuestions.Text;
        }
        else
        {
            NoOfQuestions = "2";
        }
        ds = obj.ManageAstrologerPrice(Flag, lblID.Text, ddlAstrologer.SelectedValue, txtNoOfMinutes.Text,
               hdnPrice.Value, txtInrDiscount.Text, txtFinalPrice.Text, txtPriceUSD.Text, txtDiscountUSD.Text, txtFinalPriceUSD.Text, Status, ModifyBy , ddlPaymentFor.SelectedValue , NoOfQuestions);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string Message = ds.Tables[0].Rows[0]["Message"].ToString();
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ManageAstrologerPrice), "wq", "alert('" + Message + "');", true);
            common.ClearAllControls(Page.Controls);
            lblID.Text = "";
            if (Request.QueryString["q"] != null)
            {
                string AstrologerID = Request.QueryString["q"].ToString();
                ddlAstrologer.SelectedValue = AstrologerID;
            }
            BindGrid();
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ManageAstrologerPrice), "wq", "alert('Some Error Occured');", true);
        }
    }

    #endregion

    #region Reset Click
    protected void btnReset_Click(object sender, EventArgs e)
    {
        try
        {
            common.ClearAllControls(Page.Controls);
            lblID.Text = "";
            if (Request.QueryString["q"] != null)
            {
                string AstrologerID = Request.QueryString["q"].ToString();
                ddlAstrologer.SelectedValue = AstrologerID;
            }
            BindGrid();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion

    #region On Select Change
    protected void ddlPaymentFor_SelectChange(object sender , EventArgs e)
    {
        BindGrid();
    }
    #endregion

}