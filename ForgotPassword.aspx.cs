using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ForgotPassword : System.Web.UI.Page
{
    public string WEBSITEDomain = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    public string SMTPServer = ConfigurationManager.AppSettings["SMTPServer"].ToString();
    private static string EncryptionKey = "!#853g`de";
    private static byte[] key = { };
    private static byte[] IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
    myaccount objmc = new myaccount();
    common cs_obj = new common();
    subscription obj_subs = new subscription();
    DataSet ds = new DataSet();
    string EmailID = "", Flag = "";
    decimal natal_price, horary_price, finalpay;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public string Encrypt(string Input)
    {
        try
        {
            key = System.Text.Encoding.UTF8.GetBytes(EncryptionKey.Substring(0, 8));
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            Byte[] inputByteArray = System.Text.Encoding.UTF8.GetBytes(Input);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(key, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Convert.ToBase64String(ms.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        try
        {
            DataSet dsc = new DataSet();
            string frommailid = "";
            dsc = cs_obj.Get_Configuration("Registration", "SUPPORT");
            if (dsc.Tables[0].Rows.Count > 0)
            {
                frommailid = dsc.Tables[0].Rows[0]["EMAILID"].ToString();
            }
            dsc.Dispose();

            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            string Email_ID = txtmailid.Text.ToString().Trim();
            ds1 = cs_obj.search_astro(Email_ID, "");
            if (ds1.Tables[0].Rows.Count != 0)
            {
                string pwd = ds1.Tables[0].Rows[0]["PASSWORD"].ToString().Trim();
                string usermail = ds1.Tables[0].Rows[0]["MAINMAIL"].ToString().Trim();
                string UserName = ds1.Tables[0].Rows[0]["NAME"].ToString().Trim();

                string body = "<p>Hello " + UserName + ",</p>";
                body += "<p>Your password is : " + pwd + "";
                body += "<br /><a target='_blank' href=\"" + ResolveUrl("" + WEBSITEDomain + "/signin.html") + "\">Click here to login !</a></p>";
                body += "<p>Thanks & Regards<br/>";
                body += "Your Sincerely<br/>";
                body += "For Astro Envision<br/>";
                body += "support@astroenvision.com<br/>";
                body += "+91-9958883955<br/>+91-9555600111</p>";

                //string result = cs_obj.SendMail(frommailid, usermail, "", "deepaknirwal11@gmail.com", "Your Forget Password", body);
                string result = cs_obj.SendMailWithLogo(frommailid, usermail, "", "", "Your Forget Password", body, "Y");
                if (result == "SENT")
                {
                    txtmailid.Text = "";
                    ScriptManager.RegisterClientScriptBlock(this, typeof(ForgotPassword), "wq", "alert('Your Password has been sent to your email address.!');", true);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(ForgotPassword), "wq", "alert('Some error occurred!');", true);
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(ForgotPassword), "wq", "alert('You are not registered with AstroEnvision!');", true);
            }
            if (ds1.Tables[0].Rows.Count == 0)
            {
                ds2 = obj_subs.AstGetCommon(Email_ID, "", "", "GETCLIENTINFO");
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    string pwd = ds2.Tables[0].Rows[0]["PASSWORD"].ToString().Trim();
                    string usermail = ds2.Tables[0].Rows[0]["EMAILID"].ToString().Trim();
                    string UserName = ds2.Tables[0].Rows[0]["NAME"].ToString().Trim();
                    string verify_email = Encrypt(usermail);
                    string body = "Hello " + UserName + ",</p>";
                    body += "<p>Please click the following link to update your account</p>";
                    body += "<br /><a href='" + ResolveUrl("" + WEBSITEDomain + "/SetPassword.aspx?UserID=" + Server.UrlEncode(verify_email) + "") + "' target='_blank'>Click here to Update Your Password.</a>";
                    body += "<p>Thanks & Regards<br/>";
                    body += "Your Sincerely<br/>";
                    body += "For Astro Envision<br/>";
                    body += "support@astroenvision.com<br/>";
                    body += "+91-9958883955<br/>+91-9555600111</p>";

                    //string result = cs_obj.SendMail(frommailid, usermail, "", "deepaknirwal11@gmail.com", "Your Forget Password", body);
                    string result = cs_obj.SendMailWithLogo(frommailid, usermail, "", "", "Your Forget Password", body, "Y");
                    if (result == "SENT")
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(ForgotPassword), "wq", "alert('Your Password has been sent to your email address.!');", true);
                    }
                    else
                    {

                    }
                }
                ds2.Dispose();
            }
            
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}