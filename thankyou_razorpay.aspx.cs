using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;
using ASTROLOGY.classesoracle;
using System.Data;
using System.Configuration;

public partial class thankyou_razorpay : System.Web.UI.Page
{
    subscription obj = new subscription();
    common obj_Com= new common();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Form["razorpay_order_id"] != null)
        {
            divMessgae.Visible = false;
            string razorpay_payment_id = Request.Form["razorpay_payment_id"];
            string razorpay_order_id = Request.Form["razorpay_order_id"].ToString();
            string secret = ConfigurationManager.AppSettings["RazorpaySecretKey"].ToString();
            string generated_signature = getActualSignature(razorpay_order_id + "|" + razorpay_payment_id, secret);
            string razorpay_signature = Request.Form["razorpay_signature"].ToString();// ComputeSha256Hash(generated_signature);
            string CartID = "";
            string TypeOfPayment = "";
            if (Request.QueryString["q"] != null)
            {
                CartID = Request.QueryString["q"].ToString();
            }
            if (Request.QueryString["PaymentFor"] != null)
            {
                TypeOfPayment = Request.QueryString["PaymentFor"].ToString();
            }
            if (generated_signature == razorpay_signature)
            {
                Response.Write("payment is successful");
                DataSet ds = new DataSet();
                if (CartID != "")
                {
                    string Flag = "UPDATE_BILLING_STATUS";
                    if (TypeOfPayment == "CONSULT_ASTROLOGER")
                    {
                        Flag = "UPDATE_BILLING_STATUS_FOR_CONSULT";
                    }
                    if (TypeOfPayment == "KUNDALI_MATCHING")
                    {
                        Flag = "UPDATE_BILLING_STATUS_FOR_KUNDALI_MATCHING";
                    }
                    if (TypeOfPayment == "TALK_TO_ASTROLOGER")
                    {
                        Flag = "TALK_TO_ASTROLOGER";
                    }
                    if (TypeOfPayment == "FOR_PRODUCT")
                    {
                        Flag = "FOR_PRODUCT";
                    }
                    if (TypeOfPayment == "PERSONAL_MEETING")
                    {
                        Flag = "PERSONAL_MEETING";
                    }
                    if (TypeOfPayment == "CONSULT_AN_ASTROLOGER")
                    {
                        Flag = "CONSULT_AN_ASTROLOGER";
                    }
                    if (TypeOfPayment == "THE_MOST_IMPORTANT_PLANET")
                    {
                        Flag = "THE_MOST_IMPORTANT_PLANET";
                    }
                    if (TypeOfPayment == "TWO_IMPORTANT_PLANET")
                    {
                        Flag = "TWO_IMPORTANT_PLANET";
                    }
                    if (TypeOfPayment == "THREE_IMPORTANT_PLANET")
                    {
                        Flag = "THREE_IMPORTANT_PLANET";
                    }
                    ds = obj.UpdateRazorPayStatus(CartID, "", "Natal", razorpay_payment_id, razorpay_order_id, Flag);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        string Type = ds.Tables[0].Rows[0]["RAZORPAY_PAYMENT_FOR"].ToString().Trim();
                        if (Type == "NATAL_CATEGORY")
                        {
                            Response.Redirect(ResolveUrl("~/thankyou_ccavenue.aspx?cartid=" + CartID + "&group=NATAL"));
                        }
                        else if (Type == "KUNDALI_MATCHING")
                        {
                            //Response.Redirect(ResolveUrl("~/compatibilitymatchingreport.aspx?BoyId=" + CartID + "&GirlId=" + CartID + ""));
                            Response.Redirect(ResolveUrl("~/compatibilitymatchingreport.aspx?cartid=" + CartID + ""));
                        }
                        else if (Type == "CONSULT_ASTROLOGER")
                        {
                            Response.Redirect(ResolveUrl("~/thankyou.html"));
                        }
                        else if (Type == "TALK_TO_ASTROLOGER")
                        {
                            DataSet dsc = new DataSet();
                            string frommailid = "";
                            dsc = obj_Com.Get_Configuration("Registration", "SUPPORT");
                            if (dsc.Tables[0].Rows.Count > 0)
                            {
                                frommailid = dsc.Tables[0].Rows[0]["EMAILID"].ToString();
                            }
                            dsc.Dispose();
                            string Subject = "Astroenvision - Talk to Astrologer";
                            string QUESTION1 = ds.Tables[0].Rows[0]["QUESTION1"].ToString().Trim();
                            string QUESTION2 = ds.Tables[0].Rows[0]["QUESTION2"].ToString().Trim();
                            string UserName = ds.Tables[0].Rows[0]["NAME"].ToString().Trim();
                            string CONTACT = ds.Tables[0].Rows[0]["CONTACT_NO"].ToString().Trim();
                             string body = "<p>Client Name:-  " + UserName + ",</p>";
                            String Questions = "";
                            if(QUESTION1 != "" && QUESTION1 != "")
                            {
                                Questions = QUESTION1 + "<br/>" + QUESTION2;
                            }
                            else if (QUESTION1 != "" && QUESTION2 == "")
                            {
                                Questions = QUESTION1;
                            }
                            else if (QUESTION1 == "" && QUESTION2 != "")
                            {
                                Questions = QUESTION2;
                            }
                            body += "<p>Mobile No :- " + CONTACT + "";
                            body += "<p>Query:- : " + Questions + "";
                            body += "<p>Thanks & Regards<br/>";
                            body += "Your Sincerely<br/>";
                            body += "For Astro Envision<br/>";
                            body += "support@astroenvision.com<br/>";
                            body += "+91-9958883955<br/>+91-9555600111</p>";
                            //string result = cs_obj.SendMail(frommailid, usermail, "", "deepaknirwal11@gmail.com", "Your Forget Password", body);
                            string result = obj_Com.SendMailWithLogo(frommailid, "astrologer@harisharma.com", "", "", Subject, body, "Y");
                            Response.Redirect(ResolveUrl("~/thankyou.html"));
                        }
                        else if (Type == "THE_MOST_IMPORTANT_PLANET")
                        {
                            string ClientID = ds.Tables[0].Rows[0]["CLIENT_ID"].ToString().Trim();
                            string ClientEmailID = ds.Tables[0].Rows[0]["CLIENT_EMAILID"].ToString().Trim();
                            Response.Redirect(ResolveUrl("~/most_important_planet_report.aspx?userid="+ ClientID + "&useremailid="+ ClientEmailID + "&flag=single"));
                        }
                        else if (Type == "TWO_IMPORTANT_PLANET")
                        {
                            string ClientID = ds.Tables[0].Rows[0]["CLIENT_ID"].ToString().Trim();
                            string ClientEmailID = ds.Tables[0].Rows[0]["CLIENT_EMAILID"].ToString().Trim();
                            Response.Redirect(ResolveUrl("~/most_important_planet_report.aspx?userid=" + ClientID + "&useremailid=" + ClientEmailID + "&flag=two"));
                        }
                        else if (Type == "THREE_IMPORTANT_PLANET")
                        {
                            string ClientID = ds.Tables[0].Rows[0]["CLIENT_ID"].ToString().Trim();
                            string ClientEmailID = ds.Tables[0].Rows[0]["CLIENT_EMAILID"].ToString().Trim();
                            Response.Redirect(ResolveUrl("~/most_important_planet_report.aspx?userid=" + ClientID + "&useremailid=" + ClientEmailID + "&flag=three"));
                        }
                        else if (Type == "FOR_PRODUCT")
                        {
                            Response.Redirect(ResolveUrl("~/thankyou.html"));
                        }
                        else if (Type == "CONSULT_AN_ASTROLOGER")
                        {
                            Response.Redirect(ResolveUrl("~/thankyou.html"));
                        }
                        else if (Type == "PERSONAL_MEETING")
                        {
                            Response.Redirect(ResolveUrl("~/thankyou.html"));
                        }
                    }
                    ds.Dispose();
                    //Response.Redirect(ResolveUrl("~/thankyou_ccavenue.aspx?cartid=" + CartID + "&clientid=" + Session["UserID"].ToString() + "&clientemailid=" + Session["UserEmailID"].ToString() + "&group=NATAL"));
                }
            }
        }
        else
        {
            divMessgae.Visible = true;
        }
    }

    private static byte[] StringEncode(string text)
    {
        var encoding = new ASCIIEncoding();
        return encoding.GetBytes(text);
    }
    private static string HashEncode(byte[] hash)
    {
        return BitConverter.ToString(hash).Replace("-", "").ToLower();
    }
    private static string getActualSignature(string payload, string secret)
    {
        byte[] secretBytes = StringEncode(secret);

        HMACSHA256 hashHmac = new HMACSHA256(secretBytes);

        var bytes = StringEncode(payload);

        return HashEncode(hashHmac.ComputeHash(bytes));
    }

    private static string hmac_sha256(string message, string key)
    {
        byte[] key1 = Encoding.UTF8.GetBytes(key);
        byte[] message1 = Encoding.UTF8.GetBytes(message);
        var hash = new HMACSHA256(key1);
        return Convert.ToBase64String(hash.ComputeHash(message1));
    }
}