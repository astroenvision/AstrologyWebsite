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
using System.Net.Mail;
using System.Security.Cryptography;
using System.IO;
using ASTROLOGY.classesoracle;

public partial class astro_registration_reactivation : System.Web.UI.Page
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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["Flag"] != null)
        {
            Flag = Request.QueryString["Flag"].ToString().Trim();
            if (Request.QueryString["UserID"] != null)
            {
                EmailID = Request.QueryString["UserID"].ToString().Trim();
                if (Flag == "D")  //Not Verify EmailID
                {
                    activate_h1_id.Visible = true;
                    FSForgetPwdID.Visible = false;
                    FSChangePwdID.Visible = false;
                    activate_h1_id.InnerHtml = "Your Email ID is not verified yet !.";
                    activate_h1_id.InnerHtml += "</br>";
                    activate_h1_id.InnerHtml += "Please click the link sent on your Email ID.";
                    activate_h1_id.InnerHtml += "</br>";
                    Button btnverify = new Button();
                    btnverify.ID = "btnverify";
                    btnverify.Text = "click here to re-send the link.";
                    btnverify.CssClass = "btncss";
                    btnverify.Click += btnverify_Click;
                    activate_h1_id.Controls.Add(btnverify);
                }
                if (Flag == "NR")    // Not Registered
                {
                    activate_h1_id.Visible = true;
                    FSForgetPwdID.Visible = false;
                    FSChangePwdID.Visible = false;
                    activate_h1_id.InnerHtml = " You are not registered with us !.";
                    activate_h1_id.InnerHtml += "</br>";
                    activate_h1_id.InnerHtml += "<a href=\"" + ResolveUrl("registration.html") + "\">Please click to Register now.</a>";
                }
                if (Flag == "CP")    // Change Password
                {
                    FSForgetPwdID.Visible = false;
                    FSChangePwdID.Visible = true;
                    activate_h1_id.Visible = false;
                }
            }
            else
            {
                if (Flag == "FP")  // Forgot Password
                {
                    FSForgetPwdID.Visible = true;
                    FSChangePwdID.Visible = false;
                    activate_h1_id.Visible = false;
                }
            }
        }
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
            throw ex;
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
            string Email_ID = txtemailid.Text.ToString().Trim();
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
                    ScriptManager.RegisterClientScriptBlock(this, typeof(astro_registration_reactivation), "wq", "alert('Your Password has been sent to your email address.!');", true);
                }
                else
                {
                    
                }
            }
            if (ds1.Tables[0].Rows.Count==0)
            {
                ds2 = obj_subs.AstGetCommon(Email_ID, "", "", "GETCLIENTINFO");
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    string pwd = ds2.Tables[0].Rows[0]["PASSWORD"].ToString().Trim();
                    string usermail = ds2.Tables[0].Rows[0]["EMAILID"].ToString().Trim();
                    string UserName = ds2.Tables[0].Rows[0]["NAME"].ToString().Trim();

                    string body = "Hello " + UserName + ",</p>";
                    body += "<p>Your password is : " + pwd + "</p>";
                    body += "<p><a target='_blank' href=\"" + ResolveUrl("" + WEBSITEDomain + "/login.aspx") + "\">Click here to login !</a></p>";
                    body += "<p>Thanks & Regards<br/>";
                    body += "Your Sincerely<br/>";
                    body += "For Astro Envision<br/>";
                    body += "support@astroenvision.com<br/>";
                    body += "+91-9958883955<br/>+91-9555600111</p>";

                    //string result = cs_obj.SendMail(frommailid, usermail, "", "deepaknirwal11@gmail.com", "Your Forget Password", body);
                    string result = cs_obj.SendMailWithLogo(frommailid, usermail, "", "", "Your Forget Password", body, "Y");
                    if (result == "SENT")
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(astro_registration_reactivation), "wq", "alert('Your Password has been sent to your email address.!');", true);
                    }
                    else
                    {

                    }
                }
                ds2.Dispose();
            }
            if (ds1.Tables[0].Rows.Count == 0 && ds2.Tables[0].Rows.Count==0)
            {
                Response.Redirect("astro_registration_reactivation.aspx?UserID=" + Email_ID + "&Flag=NR");
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    protected void btnupdatepwd_Click(object sender, EventArgs e)
    {
        string oldpwd = txtoldpwd.Text.ToString().Trim();
        string newpwd = txtnewpwd.Text.ToString().Trim();
        if (oldpwd != newpwd)
        {
            ds = objmc.Update_ClientPwd(EmailID, oldpwd, newpwd);
            if (ds.Tables[0].Rows.Count > 0)
            {
                string outflag = ds.Tables[0].Rows[0]["active_flag"].ToString();
                if (outflag == "1")
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(astro_registration_reactivation), "wq", "alert('Your Password has been changed successfully !');window.parent.location.href='login.aspx';;", true);
                    txtoldpwd.Text = "";
                    txtnewpwd.Text = "";
                    txtcfmnewpwd.Text = "";
                    return;
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(astro_registration_reactivation), "wq", "alert('Your old Password is incorrect try again !');", true);
                    return;
                }
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(astro_registration_reactivation), "wq", "alert('Old Password and New Password must not be equal !');", true);
            return;
        }
    }
    protected void btnverify_Click(object sender, EventArgs e)
    {
        DataSet dsc = new DataSet();
        string frommailid = "";
        dsc = cs_obj.Get_Configuration("Registration", "SUPPORT");
        if (dsc.Tables[0].Rows.Count > 0)
        {
            frommailid = dsc.Tables[0].Rows[0]["EMAILID"].ToString();
        }
        dsc.Dispose();

        string verify_email = Encrypt(EmailID);
        string host = HttpContext.Current.Request.Url.Host;
        string body = "Hello ";
        body += "<br /><br />Please click the following link to activate your account";
        body += "<br /><a target='_blank' href=\"" + ResolveUrl("" + WEBSITEDomain + "/astro_registration_activation.aspx?UserID=" + verify_email + "") + "\">Click here to activate your account.</a>";
        body += "<br /><br />Thanks";
        //MailMessage objMailMessage = new MailMessage();
        //MailAddress mail = new MailAddress(frommailid);
        //objMailMessage.From = mail;
        //objMailMessage.To.Add(EmailID);
        //objMailMessage.Bcc.Add("deepaknirwal11@gmail.com");
        //objMailMessage.IsBodyHtml = true;
        //objMailMessage.Subject = "Account Activation"; // Verification Email
        //objMailMessage.Body = body;
        //SmtpClient smtp = new SmtpClient(SMTPServer);
        //smtp.DeliveryMethod = SmtpDeliveryMethod.PickupDirectoryFromIis;
        //smtp.Send(objMailMessage);
        string result = cs_obj.SendMail(frommailid, EmailID, "", "deepaknirwal11@gmail.com", "Account Activation", body);
        if (result == "SENT")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(astro_registration_reactivation), "wq", "alert('Activation email has been sent on your Email Id !');window.parent.location.href='login.aspx';", true);
        }
        else
        {

        }
    }
}
