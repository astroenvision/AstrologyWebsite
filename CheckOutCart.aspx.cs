using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;


public partial class CheckOutCart : System.Web.UI.Page
{

    #region Declartions 
    ASTROLOGY.classesoracle.subscription obj = new ASTROLOGY.classesoracle.subscription();
    public string orderId;
    #endregion

    #region PageLoad
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["MySessionID"] != null)
        {
            string CartID = Session["MySessionID"].ToString();
            ViewState["MyCartId"] = Session["MySessionID"].ToString().Trim();
            string EmailID = "";
             BindCartDetails(CartID, EmailID);
         }
     }
    #endregion
    
    #region Bind Cart Details
    protected void BindCartDetails(string CartID , string UserMail)
    {
        StringBuilder strHtml = new StringBuilder();
        DataSet ds = new DataSet();
        DataSet dsCatPrice = new DataSet();
        double SumOfPrice = 0;
        string discountval = "";
        string GetCountryCodde = "";
        if (Session["CountryCode"] != null)
        {
            GetCountryCodde = Session["CountryCode"].ToString();
        }
        string flag = "GETALLQUESTIONS";
        if (GetCountryCodde == "USD")
        {
            flag = "GET_USD_RATE";
        }
        ds = obj.GetMyCartDetails(CartID, "", "", "", UserMail, flag);
        if(ds.Tables[0].Rows.Count> 0)
        {
            categories_list.Visible = true;
            categories_price.Visible = true;
            //spnTotalItem.InnerText = ds.Tables[0].Rows.Count.ToString();

            pTotalItem.InnerHtml = "You have added total categories: <span>" + ds.Tables[0].Rows.Count.ToString() + "</span>";
            divColoumNameForCat.InnerHtml = "<tr><th class='text-left'>Categories</th><th class='text-right'>Actual Amount</th><th class='text-right'>Discount</th><th class='text-right'>You Save</th><th class='text-right'>Payable Amount</th><th class='text-left'>Remove</th></tr>";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (SumOfPrice == 0)
                {
                    SumOfPrice = Convert.ToDouble(ds.Tables[0].Rows[i]["PRICE"]);
                }
                else
                {
                    SumOfPrice = SumOfPrice + Convert.ToDouble(ds.Tables[0].Rows[i]["PRICE"]);
                }

                discountval = ds.Tables[0].Rows[i]["DISCOUNT_PRICE"].ToString();
                discountval = discountval.Replace("NULL", "0");
                strHtml.Append("<tr>");
                strHtml.Append("<td class=\"text-left\">" + ds.Tables[0].Rows[i]["CATNAME"].ToString() + "</td>");
                if(GetCountryCodde != "USD")
                {
                    if (Convert.ToInt32(discountval) > 0)
                    {
                        strHtml.Append("<td class=\"text-right\"><del>₹" + Math.Round(Convert.ToDouble(ds.Tables[0].Rows[i]["ACTUAL_PRICE"].ToString()), 2) + "</del></td>");
                    }
                    else
                    {
                        strHtml.Append("<td class=\"text-right\">₹" + ds.Tables[0].Rows[i]["ACTUAL_PRICE"].ToString() + "</td>");
                    }
                }
                else
                {
                    if (Convert.ToInt32(discountval) > 0)
                    {
                        strHtml.Append("<td class=\"text-right\"><del>$" + Math.Round(Convert.ToDouble(ds.Tables[0].Rows[i]["ACTUAL_PRICE"].ToString()), 2) + "</del></td>");
                    }
                    else
                    {
                        strHtml.Append("<td class=\"text-right\">$" + ds.Tables[0].Rows[i]["ACTUAL_PRICE"].ToString() + "</td>");
                    }
                }
              
                strHtml.Append("<td class=\"text-right\">" + discountval +  "%</td>");
                double YouSave = Convert.ToDouble(ds.Tables[0].Rows[i]["ACTUAL_PRICE"]) - Convert.ToDouble(ds.Tables[0].Rows[i]["PRICE"]);
                if (GetCountryCodde != "USD")
                {
                    strHtml.Append("<td class=\"text-right\">₹" + Math.Round(YouSave, 2) + "</td>");
                    strHtml.Append("<td class=\"text-right\">₹" + Math.Round(Convert.ToDouble(ds.Tables[0].Rows[i]["PRICE"].ToString()), 2) + "</td>");
                    strHtml.Append("<td class=\"text-left\">");
                    strHtml.Append("<div class=\"input-group btn-block\" style=\"max-width: 200px;\">");
                    strHtml.Append("<span class=\"input-group-btn\" onclick=\"DeleteCategory(" + CartID + "," + ds.Tables[0].Rows[i]["CATID"].ToString() + ");\">");
                    //strHtml.Append("<button type =\"button\" class=\"btn btn-danger\"><i class=\"fa fa-times-circle\"></i></button>");
                    strHtml.Append("<img src=\"" + ResolveUrl("~/Image/deletebtn.png") + "\" alt=\"Delete\" title=\"Delete\" style='cursor: pointer;'>");
                    strHtml.Append("</span></div></td>");
                    strHtml.Append("</tr>");
                    divTotalAmount.InnerText = "₹" + Math.Round(Convert.ToDouble(SumOfPrice), 2).ToString("#,##0.00");
                    dsCatPrice = obj.GetMyCartDetails(CartID, "2", "NATAL", "0", UserMail, "GETFINALPRICEBYEMAIL");
                    if (dsCatPrice.Tables[0].Rows.Count > 0)
                    {
                        double DisCount = Convert.ToDouble(dsCatPrice.Tables[0].Rows[0]["DISCOUNT_INR"]);
                        if (DisCount > 0)
                        {
                            divTotalAmount.InnerHtml = "<del>₹" + Math.Round(Convert.ToDouble(SumOfPrice), 2).ToString("#,##0.00") + "</del>";
                            double DiscountAmount = (SumOfPrice * DisCount) / 100;
                            double PayableAmount = SumOfPrice - DiscountAmount;
                            divDiscountPrice.InnerText = DisCount.ToString();
                            divYouSave.InnerText = "₹" + Convert.ToString(Math.Round(Convert.ToDouble(SumOfPrice - PayableAmount), 2));
                            divTotalPayableAmount.InnerText = "₹" + Convert.ToString(Math.Round(PayableAmount, 2));
                            TotalAmounts.Value = Convert.ToString(Math.Round(PayableAmount, 2));
                            hdnAmountid.Value = Convert.ToString(100 * Convert.ToDouble(TotalAmounts.Value));
                        }
                        else
                        {
                            divDiscountPrice.InnerText = "0";
                            divYouSave.InnerText = "0";
                            divTotalPayableAmount.InnerText = "₹" + Math.Round(Convert.ToDouble(SumOfPrice), 2).ToString("#,##0.00");
                            TotalAmounts.Value = Math.Round(Convert.ToDouble(SumOfPrice), 2).ToString("#,##0.00");
                            hdnAmountid.Value = Convert.ToString(100 * Convert.ToDouble((Math.Round((Double)SumOfPrice, 2)).ToString()));
                        }
                    }
                    else
                    {
                        divDiscountPrice.InnerText = "0";
                        divTotalPayableAmount.InnerText = "₹" + Math.Round(Convert.ToDouble(SumOfPrice), 2).ToString("#,##0.00");
                        hdnAmountid.Value = Convert.ToString(100 * Convert.ToDouble((Math.Round((Double)SumOfPrice, 2)).ToString()));
                    }
                }
                else
                {
                    strHtml.Append("<td class=\"text-right\">$" + Math.Round(YouSave, 2) + "</td>");
                    strHtml.Append("<td class=\"text-right\">$" + Math.Round(Convert.ToDouble(ds.Tables[0].Rows[i]["PRICE"].ToString()), 2) + "</td>");
                    strHtml.Append("<td class=\"text-left\">");
                    strHtml.Append("<div class=\"input-group btn-block\" style=\"max-width: 200px;\">");
                    strHtml.Append("<span class=\"input-group-btn\" onclick=\"DeleteCategory(" + CartID + "," + ds.Tables[0].Rows[i]["CATID"].ToString() + ");\">");
                    //strHtml.Append("<button type =\"button\" class=\"btn btn-danger\"><i class=\"fa fa-times-circle\"></i></button>");
                    strHtml.Append("<img src=\"" + ResolveUrl("~/Image/deletebtn.png") + "\" alt=\"Delete\" title=\"Delete\" style='cursor: pointer;'>");
                    strHtml.Append("</span></div></td>");
                    strHtml.Append("</tr>");
                    divTotalAmount.InnerText = "₹" + Math.Round(Convert.ToDouble(SumOfPrice), 2).ToString("#,##0.00");
                    dsCatPrice = obj.GetMyCartDetails(CartID, "2", "NATAL", "0", UserMail, "GETFINALPRICEBYEMAIL");
                    if (dsCatPrice.Tables[0].Rows.Count > 0)
                    {
                        double DisCount = Convert.ToDouble(dsCatPrice.Tables[0].Rows[0]["DISCOUNT_INR"]);
                        if (DisCount > 0)
                        {
                            divTotalAmount.InnerHtml = "<del>$" + Math.Round(Convert.ToDouble(SumOfPrice.ToString()), 2) + "</del>";
                            double DiscountAmount = (SumOfPrice * DisCount) / 100;
                            double PayableAmount = SumOfPrice - DiscountAmount;
                            divDiscountPrice.InnerText = DisCount.ToString();
                            divYouSave.InnerText = "$" + Convert.ToString(Math.Round(Convert.ToDouble(SumOfPrice - PayableAmount), 2));
                            divTotalPayableAmount.InnerText = "$" + Convert.ToString(Math.Round(PayableAmount, 2));
                            TotalAmounts.Value = Convert.ToString(Math.Round(PayableAmount, 2));
                            hdnAmountid.Value = Convert.ToString(100 * Convert.ToDouble((Math.Round((Double)SumOfPrice, 2)).ToString()));
                        }
                        else
                        {
                            divDiscountPrice.InnerText = "0";
                            divYouSave.InnerText = "0";
                            divTotalPayableAmount.InnerText = Math.Round(Convert.ToDouble(SumOfPrice), 2).ToString("#,##0.00");
                            TotalAmounts.Value = Math.Round(Convert.ToDouble(SumOfPrice), 2).ToString("#,##0.00");
                            hdnAmountid.Value = Convert.ToString(100 * Convert.ToDouble((Math.Round((Double)SumOfPrice, 2)).ToString())); 
                        }
                    }
                    else
                    {
                        divDiscountPrice.InnerText = "0";
                        divTotalPayableAmount.InnerText = Math.Round(Convert.ToDouble(SumOfPrice), 2).ToString("#,##0.00");
                        hdnAmountid.Value = Convert.ToString(100 * Convert.ToDouble((Math.Round((Double)SumOfPrice, 2)).ToString()));
                    }
                }
            }
            divData.InnerHtml = "";
            divData.InnerHtml = strHtml.ToString();
        }
        else
        {
            categories_list.Visible = false;
            categories_price.Visible = false;
            divTotalAmount.InnerText = "0";
            //spnTotalItem.InnerText = "0";
            pTotalItem.InnerHtml = "You have added total categories: <span>0</span>";
        }
    }
    #endregion

    #region Next Button Click
    protected void lnkNext_Click(object sender , EventArgs e)
    {
        if (Request.QueryString["Flag"] == null)
        {
            string GetCountryCodde = "";
            string PaymentFor = "NATAL_CATEGORY";
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
            dsb = obj.AddToCartBilling(0, ViewState["MyCartId"].ToString(), TotalAmounts.Value.ToString(), "NATAL", "F", "SAVEBILLING", PayType, PaymentFor);
            if (dsb.Tables[0].Rows.Count > 0)
            {
                string flagstatus = dsb.Tables[0].Rows[0]["flag"].ToString().Trim();
                if (flagstatus == "SUCCESS" || flagstatus == "EXIST")
                {
                    if (Session["UserEmailID"] != null)
                    {
                        Response.Redirect(ResolveUrl("~/enterdetails.aspx?groupid=NATAL&cartid=" + Session["MySessionID"].ToString() + ""));
                    }
                    else
                    {
                        Response.Redirect(ResolveUrl("signin.html?groupid=NATAL"));
                    }
                }
            }
            dsb.Dispose();
        }
        else
        {

        }
    }
    #endregion

    #region Add More Button 
    protected void lnkAddMore_Click(object sender , EventArgs e)
    {
        Response.Redirect("~/index.html");
    }
    #endregion

    #region Get Country Code
    public string GetCountryCode()
    {
        string VisitorsIPAddr = string.Empty;
        if (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
        {
            VisitorsIPAddr = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
        }
        else if (HttpContext.Current.Request.UserHostAddress.Length != 0)
        {
            VisitorsIPAddr = HttpContext.Current.Request.UserHostAddress;
        }

        long w, x, y, z, IPNumber;
        //String hostName = System.Net.Dns.GetHostName();
        //IPHostEntry localIpAddresses = Dns.GetHostEntry(hostName);
        //string publicIP = localIpAddresses.AddressList[0].ToString();
        string publicIP = VisitorsIPAddr;
        string CountryCode = "IN";
        String[] splitIP = publicIP.Split('.');
        if (splitIP.Length > 3)
        {
            w = Convert.ToInt32(splitIP[0]);
            x = Convert.ToInt32(splitIP[1]);
            y = Convert.ToInt32(splitIP[2]);
            z = Convert.ToInt32(splitIP[3]);
            IPNumber = (16777216 * w) + (65536 * x) + (256 * y) + (z);
            DataSet dscd = new DataSet();
            dscd = obj.AstGetCommon(IPNumber.ToString(), "", "", "GETCOUNTRYCODE");
            if (dscd.Tables[0].Rows.Count > 0)
            {
                CountryCode = dscd.Tables[0].Rows[0]["COUNTRY_CODE"].ToString();
                Session["CountryCode"] = CountryCode;
            }
        }
        return CountryCode;
    }
    #endregion
}