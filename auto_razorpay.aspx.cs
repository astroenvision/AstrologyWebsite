using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Razorpay.Api;
using System.Net;
using System.Data;
using System.Configuration;

public partial class auto_razorpay : System.Web.UI.Page
{
    public string orderId;
    string Memberid = "", totalamount = "", clientemail = "", chksum = "" , Name="" , ContactNo="" , PaymentFor = "";
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["MySessionID"] != null)
        {
            string CartID = Session["MySessionID"].ToString();
            ViewState["MyCartId"] = Session["MySessionID"].ToString().Trim();
            hdnCartId.Value = CartID;
            Memberid = Request.QueryString["member"];
            if(Request.QueryString["PaymentFor"] != null)
            {
                PaymentFor = Request.QueryString["PaymentFor"].ToString();
                hdnPaymentFor.Value = PaymentFor;
            }
            clientemail = Request.QueryString["clientemailid"].ToString();
            string Key = ConfigurationManager.AppSettings["RazorpayKeyId"].ToString();
            string SecretKey = ConfigurationManager.AppSettings["RazorpaySecretKey"].ToString();
            hdnKey.Value = Key;
            if (Memberid.IndexOf("ASTROLOGER") > -1)
            {
                if (Memberid.IndexOf("ASTROLOGER") > -1)
                {
                    //string[] Memberidsplit = Memberid.Split('-');
                    //if (Memberidsplit.Length > 0)
                    //{
                    //    Amount.Value = totalamount;
                    //    DataSet ds = new DataSet();
                    //    ds = obj_subs.AstGetCommon(clientemail, "", "", "GETASTROLOGERINFO");
                    //    if (ds.Tables[0].Rows.Count > 0)
                    //    {
                    //        billing_cust_name.Value = ds.Tables[0].Rows[0]["NAME"].ToString();
                    //        billing_cust_email.Value = ds.Tables[0].Rows[0]["MAINMAIL"].ToString();
                    //        billing_cust_address.Value = ds.Tables[0].Rows[0]["ADDRESS1"].ToString();
                    //        billing_cust_tel.Value = ds.Tables[0].Rows[0]["MOBILE_NO"].ToString();
                    //        billing_cust_city.Value = ds.Tables[0].Rows[0]["CITY"].ToString();
                    //        billing_zip_code.Value = ds.Tables[0].Rows[0]["ZIPCODE"].ToString();
                    //        billing_cust_state.Value = ds.Tables[0].Rows[0]["STATE"].ToString();
                    //        billing_cust_country.Value = ds.Tables[0].Rows[0]["COUNTRY"].ToString();
                    //    }
                    //    ds.Dispose();
                    // }
                }
            }
            else
            {
                DataSet dsp = new DataSet();
                string Flag = "GETFINALPRICE";
                if (PaymentFor == "CONSULT_ASTROLOGER")
                {
                    Flag = "GET_FINALPRICE_FOR_CONSULT";
                }
                else if (PaymentFor == "TALK_TO_ASTROLOGER" || PaymentFor == "CONSULT_AN_ASTROLOGER" || PaymentFor == "PERSONAL_MEETING" || PaymentFor == "THE_MOST_IMPORTANT_PLANET" || PaymentFor == "TWO_IMPORTANT_PLANET" || PaymentFor == "THREE_IMPORTANT_PLANET")
                {
                    dsp = obj_subs.GetPayment("GET_FINAl_PRICE_BY_EMAILID", "", CartID, "", clientemail);
                    if (dsp.Tables[0].Rows.Count > 0)
                    {
                        totalamount = dsp.Tables[0].Rows[0]["TOTAL_PRICE"].ToString().Trim();
                        totalamount = (Convert.ToDouble(totalamount) * 100).ToString();
                    }
                    dsp.Dispose();
                }
                else if (PaymentFor == "FOR_PRODUCT")
                {
                    dsp = obj_subs.AddBillingDetails("GET_FINAL_PRICE", "", CartID, "", "", "", "", "", "", "", "", "", clientemail, "","");
                    if (dsp.Tables[0].Rows.Count > 0)
                    {
                        totalamount = dsp.Tables[0].Rows[0]["TOTAL_AMOUNT"].ToString().Trim();
                        totalamount = (Convert.ToDouble(totalamount) * 100).ToString();
                    }
                    dsp.Dispose();
                }
                else
                {
                    dsp = obj_subs.AddToCartBilling(0, Memberid, "", "", "", Flag, "", "");
                    if (dsp.Tables[0].Rows.Count > 0)
                    {
                        totalamount = dsp.Tables[0].Rows[0]["TOTAL_PRICE"].ToString().Trim();
                        totalamount = (Convert.ToDouble(totalamount) * 100).ToString();
                    }
                    dsp.Dispose();
                }
                DataSet ds = new DataSet();
                ds = obj_subs.AstGetCommon(clientemail, "", "", "GETCLIENTINFO");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Name = ds.Tables[0].Rows[0]["NAME"].ToString();
                    hdnName.Value = Name;
                    string EmailID = ds.Tables[0].Rows[0]["EMAILID"].ToString();
                    hdnEmail.Value = EmailID;
                    string Address = ds.Tables[0].Rows[0]["ADDRESS"].ToString();
                    hdnAddress.Value = Address;
                    ContactNo = ds.Tables[0].Rows[0]["CONTACT_NO"].ToString();
                    hdnPhone.Value = ContactNo;
                    string City = ds.Tables[0].Rows[0]["CITY"].ToString();
                    string PinCode = ds.Tables[0].Rows[0]["PINCODE"].ToString();
                    string State = ds.Tables[0].Rows[0]["STATE"].ToString();
                    string Country = ds.Tables[0].Rows[0]["COUNTRY"].ToString();
                  }
                ds.Dispose();
            }
            string GetCountryCodde = "", PayType = "INR" ;
            if (Session["CountryCode"] != null)
            {
                GetCountryCodde = Session["CountryCode"].ToString();
            }
            if(GetCountryCodde == "USD")
            {
                PayType = "USD";
            }
            System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            Dictionary<string, object> input = new Dictionary<string, object>();
            input.Add("amount", totalamount); // this amount should be same as transaction amount
            input.Add("currency", PayType);
            input.Add("payment_capture", 1);
            input.Add("receipt", "12121");
            string key = Key;
            string secret = SecretKey;
            RazorpayClient client = new RazorpayClient(key, secret);
            Razorpay.Api.Order order = client.Order.Create(input);
            orderId = order["id"].ToString();
            ClientScript.RegisterStartupScript(GetType(), "Javascript", "javascript:Payment(); ", true);
        }
    }
}