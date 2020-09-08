using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using IntegrationKit;

public partial class auto_ccavenue : System.Web.UI.Page
{
    ASTROLOGY.classesoracle.main obj_main = new ASTROLOGY.classesoracle.main();
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    DataSet ds = new DataSet();
    string Memberid = "", totalamount = "", clientemail="",chksum="";
    static string CcavenueThankyouURL = ConfigurationManager.AppSettings["CcavenueThankyouURL"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(auto_ccavenue));

        Memberid = Request.QueryString["member"];
        totalamount = Request.QueryString["amount"].ToString();
        clientemail = Request.QueryString["clientemailid"].ToString();
        if (Memberid.IndexOf("ASTROLOGER") > -1)
        {
            if (Memberid.IndexOf("ASTROLOGER") > -1)
            {
                string[] Memberidsplit = Memberid.Split('-');
                if (Memberidsplit.Length > 0)
                {
                    //Memberid = Memberidsplit[0];

                    Merchant_Id.Value = "M_chauhan_2811"; //This id(also User Id)  available at "Generate Working Key" of "Settings & Options" 
                    Order_Id.Value = Memberid;//your script should substitute the order description here in the quotes provided here        
                    Amount.Value = totalamount;
                    //Redirect_Url.Value = "http://182.74.87.148:8080/astrology/thankyou_ccavenue.aspx";//redirect URL where your customer will be redirected after authorisation from CCAvenue
                    Redirect_Url.Value = CcavenueThankyouURL;//redirect URL where your customer will be redirected after authorisation from CCAvenue
                    WorkingKey.Value = "6fn36dqd3c6yhjxicu5ljvxqltqh5zn8";//put in the 32 bit alphanumeric key in the quotes provided here.Please note that get this key ,login to your CCAvenue merchant account and visit the "Generate Working Key" section at the "Settings & Options" page. 

                    libfuncs myUtility = new libfuncs();
                    chksum = myUtility.getchecksum(Merchant_Id.Value, Order_Id.Value, Amount.Value, Redirect_Url.Value, WorkingKey.Value);
                    Checksum.Value = chksum;

                    DataSet ds = new DataSet();
                    ds = obj_subs.AstGetCommon(clientemail, "", "", "GETASTROLOGERINFO");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        billing_cust_name.Value = ds.Tables[0].Rows[0]["NAME"].ToString();
                        billing_cust_email.Value = ds.Tables[0].Rows[0]["MAINMAIL"].ToString();
                        billing_cust_address.Value = ds.Tables[0].Rows[0]["ADDRESS1"].ToString();
                        billing_cust_tel.Value = ds.Tables[0].Rows[0]["MOBILE_NO"].ToString();
                        billing_cust_city.Value = ds.Tables[0].Rows[0]["CITY"].ToString();
                        billing_zip_code.Value = ds.Tables[0].Rows[0]["ZIPCODE"].ToString();
                        billing_cust_state.Value = ds.Tables[0].Rows[0]["STATE"].ToString();
                        billing_cust_country.Value = ds.Tables[0].Rows[0]["COUNTRY"].ToString();
                    }
                    ds.Dispose();
                }
            }
        }
        else
        {
            DataSet dsp = new DataSet();
            dsp = obj_subs.AddToCartBilling(0, Memberid, "", "", "", "GETFINALPRICE","", "");
            if (dsp.Tables[0].Rows.Count > 0)
            {
                totalamount = dsp.Tables[0].Rows[0]["TOTAL_PRICE"].ToString().Trim();
            }
            dsp.Dispose();

            //DataSet dsu = new DataSet();
            //dsu = obj_subs.UpdateToCartBilling(0, Memberid, clientemail, "", "", "", "", "UPDATEBILLINGEMAILD");
            //if (dsu.Tables[0].Rows.Count > 0)
            //{
            //    string updateflag = dsu.Tables[0].Rows[0]["flag"].ToString().Trim();
            //}
            //dsu.Dispose();

            Merchant_Id.Value = "M_chauhan_2811"; //This id(also User Id)  available at "Generate Working Key" of "Settings & Options" 
            Order_Id.Value = Memberid;//your script should substitute the order description here in the quotes provided here        
            Amount.Value = totalamount;
            //Redirect_Url.Value = "http://182.74.87.148:8080/astrology/thankyou_ccavenue.aspx";//redirect URL where your customer will be redirected after authorisation from CCAvenue
            Redirect_Url.Value = CcavenueThankyouURL;//redirect URL where your customer will be redirected after authorisation from CCAvenue
            WorkingKey.Value = "6fn36dqd3c6yhjxicu5ljvxqltqh5zn8";//put in the 32 bit alphanumeric key in the quotes provided here.Please note that get this key ,login to your CCAvenue merchant account and visit the "Generate Working Key" section at the "Settings & Options" page. 

            libfuncs myUtility = new libfuncs();
            chksum = myUtility.getchecksum(Merchant_Id.Value, Order_Id.Value, Amount.Value, Redirect_Url.Value, WorkingKey.Value);
            Checksum.Value = chksum;

            DataSet ds = new DataSet();
            ds = obj_subs.AstGetCommon(clientemail, "", "", "GETCLIENTINFO");
            if (ds.Tables[0].Rows.Count > 0)
            {
                billing_cust_name.Value = ds.Tables[0].Rows[0]["NAME"].ToString();
                billing_cust_email.Value = ds.Tables[0].Rows[0]["EMAILID"].ToString();
                billing_cust_address.Value = ds.Tables[0].Rows[0]["ADDRESS"].ToString();
                billing_cust_tel.Value = ds.Tables[0].Rows[0]["CONTACT_NO"].ToString();
                billing_cust_city.Value = ds.Tables[0].Rows[0]["CITY"].ToString();
                billing_zip_code.Value = ds.Tables[0].Rows[0]["PINCODE"].ToString();
                billing_cust_state.Value = ds.Tables[0].Rows[0]["STATE"].ToString();
                billing_cust_country.Value = ds.Tables[0].Rows[0]["COUNTRY"].ToString();
            }
            ds.Dispose();
        }
    }
}
