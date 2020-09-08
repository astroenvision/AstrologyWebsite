using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Checkout : System.Web.UI.Page
{
    #region Declarations
     common common = new common();
     subscription obj = new subscription();
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindCountry();
            BindProductCartDetails();
        }
  }
    #endregion

    #region BindCountry
    protected void BindCountry()
    {
        DataSet ds = new DataSet();
        ds = common.bindloc();
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlCountry.Items.Clear();
            ddlCountry.DataSource = ds.Tables[0];
            ddlCountry.DataTextField = "loc_name";
            ddlCountry.DataValueField = "loc_id";
            ddlCountry.DataBind();
            ddlCountry.Items.Insert(0, new ListItem("Select Country", "-1"));
            ds.Dispose();
        }
    }
    #endregion
    
    #region Continue Click
    protected void btnContinue_Click(object sender , EventArgs e)
    {
        string RegUserID = "";
        string RegEmailID = "";
        string CartID = "";
        if (Session["UserID"] != null)
        {
            RegUserID = Session["UserID"].ToString();
            RegEmailID = Session["UserEmailID"].ToString();
        }
        if (Session["MySessionID"] != null)
        {
            CartID = Session["MySessionID"].ToString();
        }
        string Flag = "INSERT";
        if (hdnFlag.Value =="Edit")
        {
            Flag = "UPDATE";
        }   
        DataSet ds = new DataSet();
        ds = obj.SaveShippingAddresss(Flag, hdnAddressID.Value, CartID, txtname.Text, txtMobileNo.Text, txtAlternateNo.Text,
                                        rdAddressType.SelectedValue.ToString(), txtAddress.Text, hdnCity.Value, hdnState.Value, hdnCountry.Value,
                                        txtpincode.Text, txtLandmark.Text, "", "A", RegUserID, RegUserID, RegEmailID);
            if(ds.Tables[0].Rows.Count > 0)
            {
                string AddRessID = ds.Tables[0].Rows[0]["RESULT"].ToString();
                RedirectToPage(AddRessID);
            }
 }
    #endregion

    #region Bind All Address
    protected void BindAllAddress()
    {
        StringBuilder str = new StringBuilder();
        DataSet ds = new DataSet();
        ds = obj.SaveShippingAddresss("GET_ADDRESS", "", "", txtname.Text, txtMobileNo.Text, txtAlternateNo.Text,
                                        rdAddressType.SelectedValue.ToString(), txtAddress.Text, ddlCity.SelectedValue, ddlState.SelectedValue, ddlCountry.SelectedValue,
                                        txtpincode.Text, txtLandmark.Text, "", "A", "", "", "");
        if (ds.Tables[0].Rows.Count > 0)
        {
            for(int i =0; i< ds.Tables[0].Rows.Count; i++)
            {
                string FullAddress = "";
                string Landmark = ds.Tables[0].Rows[i]["LANDMARK"].ToString();
                string ADDRESS = ds.Tables[0].Rows[i]["ADDRESS"].ToString();
                if(Landmark !="")
                {
                    FullAddress = Landmark + " , " + ADDRESS;
                }
                else
                {
                    FullAddress =  ADDRESS;
                }
                str.Append("<label class='rad'><b>"+ ds.Tables[0].Rows[i]["USER_NAME"].ToString() + "</b>&nbsp&nbsp<span style='color:#5f5c5c;background-color: #dee2e6;'> " + ds.Tables[0].Rows[i]["ADDRESS_TYPE"].ToString() + " </span>&nbsp&nbsp<b>" + ds.Tables[0].Rows[i]["MOBILE_NO"].ToString() + "</b> <br /> " + FullAddress + ", " + ds.Tables[0].Rows[i]["CITY"].ToString() + " ," + ds.Tables[0].Rows[i]["STATE_NAME"].ToString() + ", " + ds.Tables[0].Rows[i]["COUNTRY_NAME"].ToString() +  " - <b>" + ds.Tables[0].Rows[i]["PIN_CODE"].ToString() + "</b>");
                str.Append("<input name='Address' id='Address_" + ds.Tables[0].Rows[i]["SHIPPING_ID"].ToString() + "' onclick=\"CheckMethod('" + ds.Tables[0].Rows[i]["SHIPPING_ID"].ToString() + "')\" type='radio'/>");
                str.Append("<div style='float: right;color: blue;' onclick=\"OnEditClick('" + ds.Tables[0].Rows[i]["SHIPPING_ID"].ToString() + "')\"> (Edit)</div>");
 

                 str.Append("<span class='checkmark'></span>");
                str.Append("</label>");
            }
            bindAddress.InnerHtml = str.ToString();
            divAllAddress.Style["display"] = "block";
            DivAddNewAddress.Style["display"] = "none";
            lnkNext.Visible = false;
            lnkContinue.Style["display"] = "none";
            lnkContinueWithAddress.Style["display"] = "block";

        }
        else
        {
            lnkNext.Visible = false;
            lnkContinue.Style["display"] = "block";
            lnkContinueWithAddress.Style["display"] = "none";
            divAllAddress.Style["display"] = "none";
            DivAddNewAddress.Style["display"] = "block";
        }
    }
    #endregion

    #region BindProductCartDetails
    protected void BindProductCartDetails()
    {
        string CartID = Session["MySessionID"].ToString();
        DataSet ds = new DataSet();
        StringBuilder strHtml = new StringBuilder();
        double SumOfPrice = 0;
        double PayableAmountTotal = 0;
        string discountval = "";
        divColoumNameForCat.InnerHtml = "<tr><th class='text-left'>Product Name</th><th class='text-right'>Actual Amount</th><th class='text-right'>Discount</th><th class='text-right'>You Save</th><th class='text-right'>Payable Amount</th><th class='text-left'>Remove</th></tr>";
        ds = obj.ProductAddToCart("GET_CART_DETAILS_BY_ID", "", CartID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
        if (ds.Tables[0].Rows.Count > 0)
        {
            pTotalItem.InnerHtml = "You have added total products: <span>" + ds.Tables[0].Rows.Count.ToString() + "</span>";
           
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (SumOfPrice == 0)
                {
                    SumOfPrice = Convert.ToDouble(ds.Tables[0].Rows[i]["ACTUAL_PRICE_INR"]);
                    PayableAmountTotal = Convert.ToDouble(ds.Tables[0].Rows[i]["PAYABLE_AMOUNT_INR"]);
                }
                else
                {
                    SumOfPrice = SumOfPrice + Convert.ToDouble(ds.Tables[0].Rows[i]["ACTUAL_PRICE_INR"]);
                    PayableAmountTotal = PayableAmountTotal + Convert.ToDouble(ds.Tables[0].Rows[i]["PAYABLE_AMOUNT_INR"]);
                }

                discountval = ds.Tables[0].Rows[i]["DISCOUNT_INR"].ToString();
                discountval = discountval.Replace("NULL", "0");
                strHtml.Append("<tr>");
                strHtml.Append("<td class=\"text-left\">" + ds.Tables[0].Rows[i]["PRODUCT_CATEGORY_NAME"].ToString() + "</td>");
                if (Convert.ToInt32(discountval) > 0)
                {
                    strHtml.Append("<td class=\"text-right\"><del>₹" + Math.Round(Convert.ToDouble(ds.Tables[0].Rows[i]["ACTUAL_PRICE_INR"].ToString()), 2) + "</del></td>");
                }
                else
                {
                    strHtml.Append("<td class=\"text-right\">₹" + ds.Tables[0].Rows[i][""].ToString() + "</td>");
                }

                strHtml.Append("<td class=\"text-right\">" + discountval + "%</td>");
                double YouSave = Convert.ToDouble(ds.Tables[0].Rows[i]["ACTUAL_PRICE_INR"]) - Convert.ToDouble(ds.Tables[0].Rows[i]["PAYABLE_AMOUNT_INR"]);
                strHtml.Append("<td class=\"text-right\">₹" + Math.Round(YouSave, 2) + "</td>");
                strHtml.Append("<td class=\"text-right\">₹" + Math.Round(Convert.ToDouble(ds.Tables[0].Rows[i]["PAYABLE_AMOUNT_INR"].ToString()), 2) + "</td>");
                strHtml.Append("<td class=\"text-left\">");
                strHtml.Append("<div class=\"input-group btn-block\" style=\"max-width: 200px;\">");
                strHtml.Append("<div class=\"input-group-btn\" onclick=\"DeleteProduct('" + ds.Tables[0].Rows[i]["PRODUCT_ORDER_ID"].ToString() + "')\">");
                //strHtml.Append("<button type =\"button\" class=\"btn btn-danger\"><i class=\"fa fa-times-circle\"></i></button>");
                strHtml.Append("<img src=\"" + ResolveUrl("~/Image/deletebtn.png") + "\" alt=\"Delete\" style='cursor: pointer;'>");
                strHtml.Append("</div></div></td>");
                strHtml.Append("</tr>");
                divTotalAmount.InnerText = "₹" + Math.Round(Convert.ToDouble(SumOfPrice), 2).ToString("#,##0.00");
                divDiscountPrice.InnerText = "0";
                divYouSave.InnerText = "₹" + Convert.ToString(Math.Round(Convert.ToDouble(SumOfPrice - PayableAmountTotal), 2));
                Double save = Math.Round(Convert.ToDouble(SumOfPrice - PayableAmountTotal), 2);
                TotalAmounts.Value = Math.Round(Convert.ToDouble(SumOfPrice), 2).ToString("#,##0.00");
                divTotalPayableAmount.InnerHtml = "₹" + Convert.ToString(Math.Round(Convert.ToDouble(SumOfPrice - save), 2));
                //TotalAmounts.Value = Math.Round(Convert.ToDouble(SumOfPrice), 2).ToString("#,##0.00");
                //divTotalPayableAmount.InnerHtml = "₹" + Math.Round(Convert.ToDouble(ds.Tables[0].Rows[i]["PAYABLE_AMOUNT_INR"].ToString()), 2);
            }
            divData.InnerHtml = "";
            divData.InnerHtml = strHtml.ToString();
        }
        else
        {
            pTotalItem.InnerHtml = "You have added total product: <span>0</span>";
        }

    }
    #endregion

    #region Next Button Click
    protected void lnkNext_Click(object sender, EventArgs e)
    { 
          string CartID = Session["MySessionID"].ToString();
            string GetCountryCodde = "";
            string PaymentFor = "FOR_PRODUCT";
            string RegUserID = "";
            string RegEmailID = "";
             if (Session["UserID"] != null)
            {
            RegUserID = Session["UserID"].ToString();
            RegEmailID = Session["UserEmailID"].ToString();
            }
            if (Session["CountryCode"] != null)
            {
                GetCountryCodde = Session["CountryCode"].ToString();
            }
            string PayType = "USD";
            if (GetCountryCodde != "USD")
            {
                PayType = "INR";
            }
            DataSet dsb = new DataSet();
            dsb = obj.AddBillingDetails("INSERT_INTO_BILLING", "", CartID, TotalAmounts.Value.ToString(),"", PayType, "", "P" , "RAZORPAY","","", RegUserID , RegEmailID, PaymentFor , "");
            if (dsb.Tables[0].Rows.Count > 0)
            {
                    Productlist.Visible = false;
                    if (Session["UserID"] != null)
                    {
                       BindAllAddress();
                    }
                    divAllAddress.Style["display"] = "none";
                    DivAddNewAddress.Style["display"] = "block";
                    lnkNext.Visible = false;
                    lnkContinue.Style["display"] = "block";
                    lnkContinueWithAddress.Style["display"] = "none";
         }
            dsb.Dispose();
    }
    #endregion

    #region Add New Add
    protected void btnAddNewAddress_Click(object sender , EventArgs e)
    {
        divAllAddress.Style["display"] = "none";
        DivAddNewAddress.Style["display"] = "block";
        lnkNext.Visible = false;
        lnkContinue.Style["display"] = "block";
        lnkContinueWithAddress.Style["display"] = "none";
    }
    #endregion

    #region Show Old Address
    protected void btnShowOldAddress_Click(object sender , EventArgs e)
    {
        divAllAddress.Style["display"] = "block";
        DivAddNewAddress.Style["display"] = "none";
        lnkNext.Visible = false;
        lnkContinue.Style["display"] = "none";
        lnkContinueWithAddress.Style["display"] = "block";
        BindAllAddress();
    }
    #endregion

    #region Redirect Function
    protected void RedirectToPage(string AddressID)
    {
        if (Session["UserEmailID"] != null)
        {
            DataSet dsUpdateAdd = new DataSet();
            dsUpdateAdd = obj.AddBillingDetails("UpdateAddressID", "", Session["MySessionID"].ToString(), "", "", "", "", "", "", "", "", "", "", "", AddressID);
            if (dsUpdateAdd.Tables[0].Rows.Count > 0)
            {
                Response.Redirect(ResolveUrl("~/auto_razorpay.aspx?member=" + Session["MySessionID"].ToString() + "&amount=" + TotalAmounts.Value + "&clientemailid=" + Session["UserEmailID"].ToString() + "&group=NATAL&PaymentFor=FOR_PRODUCT"));
            }
        }
        else
        {
            Session["CurrentPage"] = "FOR_PRODUCT";
            Session["AddressID"] = AddressID;
            Session["TotalValue"] = TotalAmounts.Value;
            Response.Redirect(ResolveUrl("signin.html?groupid=NATAL"));
        }
    }
    #endregion

    #region Continue With Old Address
    protected void btnContinueWithOld_Click(object sender , EventArgs e)
    {
        if (hdnAddressID.Value == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(Checkout), "wq", "alert('Please select delivery address!');", true);
            return;
        }
        else
        {
            RedirectToPage(hdnAddressID.Value);
        }
    }
    #endregion
}