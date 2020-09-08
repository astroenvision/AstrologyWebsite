using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class compatibilitymatchingform : System.Web.UI.Page
{
    #region Declartions 
    ASTROLOGY.classesoracle.subscription obj = new ASTROLOGY.classesoracle.subscription();
    dailyarticle obj_Da = new dailyarticle();
    string Flag = "";
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserEmailID"] == null)
        {
            //Response.Redirect(ResolveUrl("~/natal-astrology/kundli-matching.html"));
            Response.Redirect(ResolveUrl("signin.html?flag=compatibilitymatching"));
        }
        if (Session["MySessionID"] != null)
        {
            string CartID = Session["MySessionID"].ToString();
            ViewState["MyCartId"] = Session["MySessionID"].ToString().Trim();
        }
        if(!IsPostBack)
        {
            BindPrice();
            BindOtherCategory();
        }
    }
    #endregion

    #region Boy to Girl
    protected void lnkboytogirl_Click(object sender, EventArgs e)
    {
        Flag = "M";
        UpdateMatchingData(Flag);
    }
    #endregion

    #region Girl to Boy
    protected void lnkgirltoboy_Click(object sender, EventArgs e)
    {
        Flag = "F";
        UpdateMatchingData(Flag);
    }
    #endregion

    #region Update Matching Data
     void UpdateMatchingData(string FlagVal)
    {
        double SumOfPrice = 0;
        string discountval = "";
        DataSet ds = new DataSet();
        DataSet dsCatPrice = new DataSet();
        //string GetCountry = GetCountryCode();
        ds = obj.GetMyCartDetails(ViewState["MyCartId"].ToString(), "", "", "", Session["UserEmailID"].ToString(), "GETALLQUESTIONS_FOR_COMPATIBILITY_MATCHING");
        if (ds.Tables[0].Rows.Count > 0)
        {
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

                TotalAmounts.Value = Math.Round(Convert.ToDouble(ds.Tables[0].Rows[i]["PRICE"].ToString()), 2).ToString();
            }
        }
        ds.Dispose();

        string GetCountryCode = "";
        if (Session["CountryCode"] != null)
        {
            GetCountryCode = Session["CountryCode"].ToString();
        }
        string PayType = "USD";
        if (GetCountryCode != "USD")
        {
            PayType = "INR";
        }

        DataSet dsb = new DataSet();
        dsb = obj.AddToCartBilling(0, ViewState["MyCartId"].ToString(), TotalAmounts.Value.ToString(), "NATAL", "F", "SAVEBILLING_FOR_COMPATIBILITY_MATCHING", PayType, "KUNDALI_MATCHING");
        if (dsb.Tables[0].Rows.Count > 0)
        {
            string flagstatus = dsb.Tables[0].Rows[0]["flag"].ToString().Trim();
            if (flagstatus == "SUCCESS" || flagstatus == "EXIST")
            {
                DataSet dsu = new DataSet();
                dsu = obj.UpdateToCartBilling(0, ViewState["MyCartId"].ToString(), "", "", "", Session["UserID"].ToString(), Session["UserEmailID"].ToString(), "UPDATEBILLINGEMAILD");
                if (dsu.Tables[0].Rows.Count > 0)
                {
                    string updateflag = dsu.Tables[0].Rows[0]["flag"].ToString().Trim();
                }
                dsu.Dispose();

                Response.Redirect(ResolveUrl("~/compatibilitymatching.aspx?flag=" + FlagVal.Trim() + ""));
            }
        }
        dsb.Dispose();
    }
    #endregion

    #region Next Click
    protected void btnnext_Click(object sender, EventArgs e)
    {
        //double SumOfPrice = 0;
        //string discountval = "";
        //DataSet ds = new DataSet();
        //DataSet dsCatPrice = new DataSet();
        ////string GetCountry = GetCountryCode();
        //ds = obj.GetMyCartDetails(ViewState["MyCartId"].ToString(), "", "", "", Session["UserEmailID"].ToString(), "GETALLQUESTIONS_FOR_COMPATIBILITY_MATCHING");
        //if (ds.Tables[0].Rows.Count > 0)
        //{
        //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //    {
        //        if (SumOfPrice == 0)
        //        {
        //            SumOfPrice = Convert.ToDouble(ds.Tables[0].Rows[i]["PRICE"]);
        //        }
        //        else
        //        {
        //            SumOfPrice = SumOfPrice + Convert.ToDouble(ds.Tables[0].Rows[i]["PRICE"]);
        //        }

        //        discountval = ds.Tables[0].Rows[i]["DISCOUNT_PRICE"].ToString();
        //        discountval = discountval.Replace("NULL", "0");
                
        //        TotalAmounts.Value= Math.Round(Convert.ToDouble(ds.Tables[0].Rows[i]["PRICE"].ToString()), 2).ToString();
        //    }
        //}
        //ds.Dispose();

        //string GetCountryCode = "";
        //if (Session["CountryCode"] != null)
        //{
        //    GetCountryCode = Session["CountryCode"].ToString();
        //}
        //string PayType = "USD";
        //if (GetCountryCode != "USD")
        //{
        //    PayType = "INR";
        //}
        
        //DataSet dsb = new DataSet();
        //dsb = obj.AddToCartBilling(0, ViewState["MyCartId"].ToString(), TotalAmounts.Value.ToString(), "NATAL", "F", "SAVEBILLING_FOR_COMPATIBILITY_MATCHING", PayType, "KUNDALI_MATCHING");
        //if (dsb.Tables[0].Rows.Count > 0)
        //{
        //    string flagstatus = dsb.Tables[0].Rows[0]["flag"].ToString().Trim();
        //    if (flagstatus == "SUCCESS" || flagstatus == "EXIST")
        //    {
        //        if (maleid.Checked == true)
        //        {
        //            Flag = "M";
        //        }
        //        else if (femaleid.Checked == true)
        //        {
        //            Flag = "F";
        //        }

        //        DataSet dsu = new DataSet();
        //        dsu = obj.UpdateToCartBilling(0, ViewState["MyCartId"].ToString(), "", "", "", Session["UserID"].ToString(), Session["UserEmailID"].ToString(), "UPDATEBILLINGEMAILD");
        //        if (dsu.Tables[0].Rows.Count > 0)
        //        {
        //            string updateflag = dsu.Tables[0].Rows[0]["flag"].ToString().Trim();
        //        }
        //        dsu.Dispose();

        //        Response.Redirect(ResolveUrl("~/compatibilitymatching.aspx?flag=" + Flag.Trim() + ""));
        //    }
        //}
        //dsb.Dispose();
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

    #region Bind Other Category
    protected void BindOtherCategory()
    {
        StringBuilder strHtml = new StringBuilder();
        DataSet ds = new DataSet();
        double SumOfPrice = 0;
        string discountval = "";
        string GetCountryCodde = "";
        if (Session["CountryCode"] != null)
        {
            GetCountryCodde = Session["CountryCode"].ToString();
        }
        ds = obj_Da.GetCategoryDetails("GETRELATEDCATEGORY", "28", "CompatibilityMatching");
        if (ds.Tables[0].Rows.Count > 0)
        {
            strHtml.Append("<input type = 'hidden' value = " + ds.Tables[0].Rows.Count.ToString() + " id = 'hdnCount'>");
            categories_list.Visible = true;
            categories_price.Visible = true;
            //spnTotalItem.InnerText = ds.Tables[0].Rows.Count.ToString();

          divColoumNameForCat.InnerHtml = "<tr><th class='text-left'>Categories</th><th class='text-right'>Actual Amount</th><th class='text-right'>Discount</th><th class='text-right'>You Save</th><th class='text-right'>Payable Amount</th><th class='text-left'>Buy</th></tr>";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (SumOfPrice == 0)
                {
                    SumOfPrice = Convert.ToDouble(ds.Tables[0].Rows[i]["ACTUAL_PRICE"]);
                }
                else
                {
                    SumOfPrice = SumOfPrice + Convert.ToDouble(ds.Tables[0].Rows[i]["ACTUAL_PRICE"]);
                }

                discountval = ds.Tables[0].Rows[i]["DISCOUNT"].ToString();
                discountval = discountval.Replace("NULL", "0");
                strHtml.Append("<tr>");
                strHtml.Append("<td class=\"text-left\">" + ds.Tables[0].Rows[i]["CATEGORY_NAME"].ToString() + "</td>");
                if (GetCountryCodde != "USD")
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

                strHtml.Append("<td class=\"text-right\">" + discountval + "%</td>");
                double YouSave = Convert.ToDouble(ds.Tables[0].Rows[i]["ACTUAL_PRICE"]) - Convert.ToDouble(ds.Tables[0].Rows[i]["PAYABLE_PRICE"]);
                if (GetCountryCodde != "USD")
                {
                    strHtml.Append("<td class=\"text-right\">₹" + Math.Round(YouSave, 2) + "</td>");
                    strHtml.Append("<td class=\"text-right\">₹" + Math.Round(Convert.ToDouble(ds.Tables[0].Rows[i]["PAYABLE_PRICE"].ToString()), 2) + "</td>");
                    strHtml.Append("<td class=\"text-left\">");
                    strHtml.Append("<div class=\"input-group btn-block\" style=\"max-width: 200px;\">");
                    strHtml.Append("<span class=\"input-group-btn\" onclick=\"AddPrice();\">");
                    strHtml.Append("<input type = 'hidden' value = " + Math.Round(Convert.ToDouble(ds.Tables[0].Rows[i]["PAYABLE_PRICE"].ToString()), 2) + " id = 'hdnPaybleAmonut_" + i + "'>");
                    strHtml.Append("<input type = 'hidden' value = " + ds.Tables[0].Rows[i]["CATEGORY_ID"].ToString() + " id = 'hdnCatID_" + i + "'>");
                    strHtml.Append("<input type = 'hidden' value =\"" + ds.Tables[0].Rows[i]["CATEGORY_NAME"].ToString() + "\"  id = 'hdnCatNAME_" + i + "'>");
                    strHtml.Append("<input type = 'hidden' value = " + Math.Round(Convert.ToDouble(ds.Tables[0].Rows[i]["ACTUAL_PRICE"].ToString()), 2) + " id = 'hdnActualAmonut_" + i + "'>");
                    strHtml.Append("<input type ='checkbox' id = \"AddCat_"+ i +"\">");
                    strHtml.Append("</span></div></td>");
                    strHtml.Append("</tr>");
                    //divTotalAmount.InnerText = "₹" + Math.Round(Convert.ToDouble(SumOfPrice), 2).ToString("#,##0.00");
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
         }
    }
    #endregion

    #region Bind Price
    protected void BindPrice()
    {
        DataSet ds = new DataSet();
        ds = obj.AstGetCommon("28", "", "", "GET_KUNDLI_MATCHING");
        if (ds.Tables[0].Rows.Count > 0)
        {
            divKundliMactingprice.InnerHtml = "₹" + ds.Tables[0].Rows[0]["PAYABLE_PRICE"].ToString();
            divActualPayableAmount.InnerHtml = "₹" + ds.Tables[0].Rows[0]["PAYABLE_PRICE"].ToString();
            hdnKundliMacting.Value = ds.Tables[0].Rows[0]["PAYABLE_PRICE"].ToString();
            thPrice.InnerHtml = "<label style ='color: white; font-weight: normal'>Total Price </label><label style ='color: white;'>₹" + ds.Tables[0].Rows[0]["PAYABLE_PRICE"].ToString() + " (" + ds.Tables[0].Rows[0]["DISCOUNT"].ToString() + "%)<br/><span style = 'text-decoration: line-through;' >₹" + ds.Tables[0].Rows[0]["ACTUAL_PRICE"].ToString() + "</span></label>";
        }
    }
    #endregion

}