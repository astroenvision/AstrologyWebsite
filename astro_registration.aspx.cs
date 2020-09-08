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
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Security.Cryptography;
using System.IO;
using ASTROLOGY.classesoracle;

public partial class astro_registration : System.Web.UI.Page
{
    public string WEBSITEDomain = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    public string SMTPServer = ConfigurationManager.AppSettings["SMTPServer"].ToString();
    myaccount objmc = new myaccount();
    DataSet ds = new DataSet();
    common cs = new common();
    private static string EncryptionKey = "!#853g`de";
    private static byte[] key = { };
    private static byte[] IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindCountries();
            if (Request.QueryString["user"] != null)
            {
                ViewState["user"] = Request.QueryString["user"].ToString().Trim();
            }
        }
    }
    public void BindCountries()
    {
        if (!Page.IsPostBack)
        {
            ds = cs.bindloc();
            ddlcountry.Items.Clear();
            ddlcountry.DataSource = ds;
            ddlcountry.DataTextField = "loc_name";
            ddlcountry.DataValueField = "loc_id";
            ddlcountry.DataBind();
            ddlcountry.Items.Insert(0, "--Select--");
            ds.Dispose();
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string name = txtname.Text.ToString().Trim();
        string email = txtemailid.Text.ToString().Trim();
        string pwd = txtpwd.Text.ToString().Trim();
        string altemail = txtaltemailid.Text.ToString().Trim();
        string mobileno = txtmobileno.Text.ToString().Trim();
        string landlineno = txtlandlineno.Text.ToString().Trim();
        string addressone = txtaddressone.Text.ToString().Trim();
        string addresstwo = txtaddresstwo.Text.ToString().Trim();
        string landmark = txtlandmark.Text.ToString().Trim();
        string country = ddlcountry.SelectedValue.ToString();
        string zipcode = txtzipcode.Text.ToString().Trim();
        string subscriptiontype = ddlsb.SelectedItem.Text.ToString().Trim();
        string gender = ddlgender.SelectedItem.ToString();
        //ds = ASTROLOGY.classesoracle.myaccount.CheckDuplicate_registration(email);
        ds = objmc.CheckDuplicate_registration(email);
        if (ds.Tables[0].Rows.Count == 0)
        {
            cs.insert_astro_dtls(name, email, altemail, mobileno, landlineno, addressone, addresstwo, landmark, zipcode, country, pwd, "", subscriptiontype, "0", gender,"","" ,ViewState["user"].ToString().Trim());
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(astro_registration), "wq", "alert('This Email Id already exists ! Try Again !');", true);
            return;
        }
        ds.Dispose();

        DataSet dsc = new DataSet();
        string frommailid = "";
        dsc = cs.Get_Configuration("Registration", "SUPPORT");
        if (dsc.Tables[0].Rows.Count > 0)
        {
            frommailid = dsc.Tables[0].Rows[0]["EMAILID"].ToString();
        }
        dsc.Dispose();

        string verify_email = Encrypt(email);
        string host = HttpContext.Current.Request.Url.Host;
        string body = "Hello " + name + ",";
        body += "<br /><br />Please click the following link to activate your account";
        body += "<br /><a target='_blank' href=\"" + ResolveUrl("" + WEBSITEDomain + "/astro_registration_activation.aspx?UserID=" + verify_email + "") + "\">Click here to activate your account.</a>";
        body += "<br /><br />Thanks";
        MailMessage objMailMessage = new MailMessage();
        MailAddress mail = new MailAddress(frommailid);
        objMailMessage.From = mail;
        objMailMessage.To.Add(email);
        objMailMessage.Bcc.Add("deepaknirwal11@gmail.com");
        objMailMessage.IsBodyHtml = true;
        objMailMessage.Subject = "Account Activation"; // Verification Email
        objMailMessage.Body = body;
        SmtpClient smtp = new SmtpClient(SMTPServer);
        smtp.DeliveryMethod = SmtpDeliveryMethod.PickupDirectoryFromIis;
        smtp.Send(objMailMessage);
        ScriptManager.RegisterClientScriptBlock(this, typeof(astro_registration), "wq", "alert('Registration successful. Activation email has been sent.!');window.parent.location.href='login.aspx';", true);
        clear_data();
    }

    public void clear_data()
    {
        txtname.Text = "";
        txtaltemailid.Text = "";
        txtpwd.Text = "";
        txtaltemailid.Text = "";
        txtzipcode.Text = "";
        txtmobileno.Text = "";
        txtlandlineno.Text = "";
        txtaddressone.Text = "";
        txtaddresstwo.Text = "";
        txtlandmark.Text = "";
        ddlcountry.SelectedIndex = 0;
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

    public string Decrypt(string Input)
    {
        Byte[] inputByteArray = new Byte[Input.Length];
        try
        {
            key = System.Text.Encoding.UTF8.GetBytes(EncryptionKey.Substring(0, 8));
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            inputByteArray = Convert.FromBase64String(Input);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(key, IV), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;
            return encoding.GetString(ms.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }
}

