using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_ManageProductPrice : System.Web.UI.Page
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
                    BindProduct();
                    if (Request.QueryString["q"] != null)
                    {
                        string ProductID = Request.QueryString["q"].ToString();
                        ddlProduct.SelectedValue = ProductID;
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
                    BindProduct();
                    if (Request.QueryString["q"] != null)
                    {
                        string ProductID = Request.QueryString["q"].ToString();
                        ddlProduct.SelectedValue = ProductID;
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
    protected void BindProduct()
    {
        ddlProduct.Items.Clear();
        DataSet ds = new DataSet();
        ds = obj.ManageProduct("GetProduct", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlProduct.DataSource = ds.Tables[0];
            ddlProduct.DataValueField = "PRODUCT_ID";
            ddlProduct.DataTextField = "PRODUCT_NAME";
            ddlProduct.DataBind();
            ddlProduct.Items.Insert(0, new ListItem("Select Product Name", "-1"));
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
            ds = obj.ManageProductPrice("GET_PRICE_DETAILS", "", ddlProduct.SelectedValue, "","","","","","","","","","","");
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
                ds = obj.ManageProductPrice("GET_PRICE_DETAILS_BY_ID", ID, "", "","","","","","","","","","","");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    lblID.Text = ds.Tables[0].Rows[0]["PRODUCT_PRICE_ID"].ToString();
                    ddlProduct.SelectedValue = ds.Tables[0].Rows[0]["PRODUCT_ID"].ToString();
                    txtProductDimension.Text = ds.Tables[0].Rows[0]["PRODUCT_DIMENSION"].ToString();
                    txtProductWeight.Text = ds.Tables[0].Rows[0]["PRODUCT_WEIGHT"].ToString();
                    txtPrice.Text = ds.Tables[0].Rows[0]["PRODUCT_PRICE_INR"].ToString();
                    txtInrDiscount.Text = ds.Tables[0].Rows[0]["DISCOUNT_INR"].ToString();
                    txtFinalPrice.Text = ds.Tables[0].Rows[0]["TOTAL_AMOUNT_INR"].ToString();
                    hdnPrice.Value = ds.Tables[0].Rows[0]["PRODUCT_PRICE_INR"].ToString();
                    txtDiscountUSD.Text = ds.Tables[0].Rows[0]["DISCOUNT_USD"].ToString();
                    txtPriceUSD.Text = ds.Tables[0].Rows[0]["PRODUCT_PRICE_USD"].ToString();
                    txtFinalPriceUSD.Text = ds.Tables[0].Rows[0]["TOTAL_AMOUNT_USD"].ToString();
                    string Status = ds.Tables[0].Rows[0]["STATUS"].ToString();
                    if (Status == "1")
                    {
                        chkStatus.Checked = true;
                    }
                    else
                    {
                        chkStatus.Checked = false;
                    }
                    btnUpdate.Text = "Update";
                    //PRIORITY
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
        if (lblID.Text != "")
        {
            Flag = "UPDATE_PRICE";
        }
        DataSet ds = new DataSet();
        string ModifyBy = "";
        string Status = "0";
        if (chkStatus.Checked == true)
        {
            Status = "1";
        }
        if (Session["UserID"] != null)
        {
            ModifyBy = Session["UserID"].ToString();
        }
        ds = obj.ManageProductPrice(Flag, lblID.Text, ddlProduct.SelectedValue, txtProductDimension.Text , txtProductWeight.Text,
               hdnPrice.Value, txtInrDiscount.Text, txtFinalPrice.Text, txtPriceUSD.Text, txtDiscountUSD.Text, txtFinalPriceUSD.Text , "", Status, ModifyBy);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string Message = ds.Tables[0].Rows[0]["Message"].ToString();
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ManageProductPrice), "wq", "alert('" + Message + "');", true);
            common.ClearAllControls(Page.Controls);
            lblID.Text = "";
            if (Request.QueryString["q"] != null)
            {
                string ProductID = Request.QueryString["q"].ToString();
                ddlProduct.SelectedValue = ProductID;
            }
            BindGrid();
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ManageProductPrice), "wq", "alert('Some Error Occured');", true);
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
                string ProductID = Request.QueryString["q"].ToString();
                ddlProduct.SelectedValue = ProductID;
            }
            BindGrid();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion
}