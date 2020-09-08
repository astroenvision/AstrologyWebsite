using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ASTROLOGY.classesoracle;
using System.Configuration;

public partial class admin_UpdateCategoryPrice : System.Web.UI.Page
{
    #region Declaration
    public string ID = "0";
    public string PayType = "0";
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
                    if (Request.QueryString["q"] != "")
                    {
                        ID = Request.QueryString["q"].ToString();
                        PayType = Request.QueryString["PayType"].ToString();
                    }
                    LoadData(ID);
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
                    if (Request.QueryString["q"] != "")
                    {
                        ID = Request.QueryString["q"].ToString();
                        PayType = Request.QueryString["PayType"].ToString();
                    }
                    LoadData(ID);
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

    #region LoadData 

    protected void LoadData(string PriceID)
    {
        if (PriceID == "0") return;
        DataSet ds = new DataSet();
        ds = obj.ManageCategoryPrice("GETCATPRICEBYID", "", PriceID, "");
        if (ds.Tables[0].Rows.Count > 0)
        {
            lblCatID.Text = ds.Tables[0].Rows[0]["CAT_ID"].ToString();
            txtCatName.Text = ds.Tables[0].Rows[0]["CAT_NAME"].ToString();
            txtCatName.Enabled = false;
            txtActualPrice.Text = ds.Tables[0].Rows[0]["PRICE_INR"].ToString();
            txtActualPrice.Enabled = false;
            txtDicountRate.Text = ds.Tables[0].Rows[0]["DISCOUNT_INR"].ToString();
            txtDiscountPrice.Text = ds.Tables[0].Rows[0]["DISCOUNTPRICE_INR"].ToString();
            txtDiscountPrice.Enabled = false;
            txtFinalPrice.Text = ds.Tables[0].Rows[0]["FINALPRICE_INR"].ToString();
            txtUsdRate.Text = ds.Tables[0].Rows[0]["USD_INR_RATE"].ToString();
            txtUsdRate.Enabled = false;
            txtIncreaseUsdPriceInPer.Text = ds.Tables[0].Rows[0]["INCREASE_USD"].ToString();
            txtIncreaseUsdPrice.Text = ds.Tables[0].Rows[0]["INCREASEPRICE_USD"].ToString();
            txtIncreaseUsdPrice.Enabled = false;
            TxtActualPriceinUsd.Text = ds.Tables[0].Rows[0]["PRICE_USD"].ToString();
            TxtActualPriceinUsd.Enabled = false;
            txtUSD_DiscountPrice.Text = ds.Tables[0].Rows[0]["DISCOUNTPRICE_USD"].ToString();
            txtUSD_DiscountPrice.Enabled = false;
            txtUsdDiscount.Text = ds.Tables[0].Rows[0]["DISCOUNT_USD"].ToString();
            txtUSD_FinalPrice.Text = ds.Tables[0].Rows[0]["FINALPRICE_USD"].ToString();
            txtUSD_FinalPrice.Enabled = false;
        }
    }
    #endregion

    #region Update Click
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        ds = obj.UpdateCategoryPrice("UPDATE", lblCatID.Text, "INR", hdnActualAmountINR.Value, lblCatID.Text, txtDicountRate.Text.Trim(), hdntxtDiscountPriceINR.Value,
                                    txtFinalPrice.Text.Trim(), txtUsdRate.Text.Trim(), txtIncreaseUsdPriceInPer.Text.Trim(), hdnActualAmountUSD.Value, hdnDiscountPriceUSD.Value, txtUsdDiscount.Text.Trim(), 
                                    hdnFinalPriceUSD.Value, txtIncreaseUsdPrice.Text.ToString(), AdminUserId);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
             ScriptManager.RegisterClientScriptBlock(this, typeof(admin_UpdateCategoryPrice), "wq", "alert(' " + Message + "');", true);
            if (Request.QueryString["q"] != "")
            {
                ID = Request.QueryString["q"].ToString();
                LoadData(ID);
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_UpdateCategoryPrice), "wq", "alert('Some Error Occured!!');", true);
        }
    }
    #endregion
}