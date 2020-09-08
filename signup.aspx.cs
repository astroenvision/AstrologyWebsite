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
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.IO;

public partial class signup : System.Web.UI.Page
{
    #region Declaration
    public string WEBSITEDomain = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    public string SMTPServer = ConfigurationManager.AppSettings["SMTPServer"].ToString();
    ASTROLOGY.classesoracle.main obj_main = new ASTROLOGY.classesoracle.main();
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    DataSet ds = new DataSet();
    common cs = new common();
    decimal natal_price, horary_price, finalpay;
    private static string EncryptionKey = "!#853g`de";
    private static byte[] key = { };
    private static byte[] IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
   #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!Page.IsPostBack)
            {
                this.Page.SetFocus(txtname);
               
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion

    //protected override void OnPreRender(EventArgs e)
    //{
    //    txtpwd.Attributes.Add("value", txtpwd.Text);
    //    base.OnPreRender(e);
    //}

    #region Channel Bind
    public void mainchannelbind()
    {
        ds = cs.bindloc();
        ddlcountry.Items.Clear();
        ddlcountry.DataSource = ds;
        ddlcountry.DataTextField = "loc_name";
        ddlcountry.DataValueField = "loc_id";
        ddlcountry.DataBind();
        ddlcountry.Items.Insert(0, "--Select Country--");
        ds.Dispose();
    }
    #endregion

    #region County & State Change
    protected void ddlcountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlcountry.SelectedValue.ToString() != "--Select Country--")
        {
            bindstates(ddlcountry.SelectedValue.ToString());
        }
        else
        {
            ddlstate.Items.Clear();
            ddlstate.Items.Insert(0, "--Select State--");
        }
    }
    protected void ddlstate_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlstate.SelectedValue.ToString() != "--Select State--")
        {
            bindcities(ddlcountry.SelectedValue.ToString(), ddlstate.SelectedValue.ToString());
        }
        else
        {
            ddlcity.Items.Clear();
            ddlcity.Items.Insert(0, "--Select City--");
        }
    }
    #endregion

    #region Bind State
    public void bindstates(string countrycode)
    {
        ds = cs.bindstate("GETALLSTATES", countrycode);
        ddlstate.Items.Clear();
        ddlstate.DataSource = ds;
        ddlstate.DataTextField = "loc_name";
        ddlstate.DataValueField = "loc_id";
        ddlstate.DataBind();
        ddlstate.Items.Insert(0, "--Select State--");
        ds.Dispose();
    }
    #endregion

    #region Bind Cities
    public void bindcities(string countrycode, string statecode)
    {
        ds = cs.bindcity(countrycode, statecode, "", "GETALLCITIES");
        ddlcity.Items.Clear();
        ddlcity.DataSource = ds;
        ddlcity.DataTextField = "loc_name";
        ddlcity.DataValueField = "loc_id";
        ddlcity.DataBind();
        ddlcity.Items.Insert(0, "--Select City--");
        ds.Dispose();
    }
    #endregion

    #region Encrypt
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
    #endregion

    #region Register Click
    protected void btnregister_Click(object sender, EventArgs e)
    {
       
        int id = 0;
        string name = "", emailval = "", pwd = "", contactno = "", address = "", city = "", state = "", country = "", active = "F", flag = "INSERT", outflag = "", pincode = "", user_gender = "";
        name = txtname.Text.ToString().Trim();
        if (name == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(signup), "wq", "alert('Please Enter Name!');", true);
            return;
        }
        emailval = txtmailid.Text.ToString().Trim().ToLower();
        if (emailval == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(signup), "wq", "alert('Please Enter Email address!');", true);
            return;
        }
        if (cs.IsValidEmailId(emailval))
        {
            emailval = txtmailid.Text.ToString().Trim().ToLower();
        }
        else
        {
            txtmailid.Text = "";
            txtmailid.Focus();
            ScriptManager.RegisterClientScriptBlock(this, typeof(signup), "wq", "alert('Please Enter valid email address!');", true);
            return;
        }
        pwd = txtpwd.Text.ToString().Trim();
        if (pwd == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(signup), "wq", "alert('Please Enter Password!');", true);
            return;
        }
        contactno = txtcontact.Text.ToString().Trim();
        if (contactno == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(signup), "wq", "alert('Please Enter Contact No!');", true);
            return;
        }
        address = txtaddress.Text.ToString().Trim();
        user_gender = userddlgender.SelectedItem.Text.ToString();
        if (user_gender == "--Select--")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(signup), "wq", "alert('Please select your gender!');", true);
            return;
        }

        country = ddlcountry.SelectedValue.ToString().Trim();
        if (ddlcountry.SelectedValue.ToString() == "--Select Country--")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(signup), "wq", "alert('Please Select Any Country !');", true);
            return;
        }
        state = ddlstate.SelectedValue.ToString().Trim();
        if (ddlstate.SelectedValue.ToString() == "--Select State--")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(signup), "wq", "alert('Please Select Any State !');", true);
            return;
        }
        city = ddlcity.SelectedValue.ToString().Trim();
        if (ddlcity.SelectedValue.ToString() == "--Select City--")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(signup), "wq", "alert('Please Select Any City !');", true);
            return;
        }
        pincode = txtpincode.Text.ToString().Trim();
        ds = obj_subs.InsertClientInfo(id, name, emailval, contactno, pwd, address, city, state, country, pincode, active, user_gender.ToUpper(), "SAVECLIENTINFO");
        if (ds.Tables[0].Rows.Count > 0)
        {
            outflag = ds.Tables[0].Rows[0]["flag"].ToString();
            if (outflag == "SUCCESS")
            {
                SendMailToUser(name, "", "", emailval, "", pwd);
                //Session["myemailid"] = emailval;
                //Session["UserID"] = ds.Tables[0].Rows[0]["user_id"].ToString();
                //Session["UserEmailID"] = ds.Tables[0].Rows[0]["user_emailid"].ToString(); ;
                //Session["UserName"] = name;
                txtname.Text = "";
                txtmailid.Text = "";
                txtpwd.Text = "";
                txtcontact.Text = "";
                txtaddress.Text = "";
                txtpincode.Text = "";
                ddlcountry.Items.Clear();
                ddlcountry.Items.Insert(0, "--Select Country--");
                ddlstate.Items.Clear();
                ddlstate.Items.Insert(0, "--Select State--");
                ddlcity.Items.Clear();
                ddlcity.Items.Insert(0, "--Select City--");

                ScriptManager.RegisterClientScriptBlock(this, typeof(signup), "wq", "alert('You have successfully registered.');document.location.href='signin.html';", true);
                return;
            }
            else if (outflag == "EXIST")
            {
                txtname.Text = "";
                txtmailid.Text = "";
                txtpwd.Text = "";
                txtcontact.Text = "";
                txtaddress.Text = "";
                txtpincode.Text = "";
                ddlcountry.Items.Clear();
                ddlcountry.Items.Insert(0, "--Select Country--");
                ddlstate.Items.Clear();
                ddlstate.Items.Insert(0, "--Select State--");
                ddlcity.Items.Clear();
                ddlcity.Items.Insert(0, "--Select City--");
                ScriptManager.RegisterClientScriptBlock(this, typeof(signup), "wq", "alert('You have already registered.');document.location.href='signin.html';", true);
                return;

            }
        }
    }
    #endregion

    #region Send Mail
    void SendMailToUser(string Client_Name, string Cartid_Val, string Client_Id, string Client_EmailId, string Client_Groupval, string GenderVal)
    {
        try
        {
            string result = "";
            //string dateval = DateTime.Now.ToString("dd-MMM-yyyy");
            //string timeval = DateTime.Now.ToString("hh:mm:ss tt");
            //string dayval = DateTime.Now.DayOfWeek.ToString();
            //string datetimeday = dateval + " , " + timeval + " , " + dayval;
            string Frommailid = "support@astroenvision.com";
            string body = "";
            //if (GenderVal == "Male")
            //{
            //    body = "Dear Mr. " + Client_Name + ",";
            //}
            //else
            //{
            //    body = "Dear Ms. " + Client_Name + ",";
            //}
            //body = "Dear Mr. " + Client_Name + ",";
            //body += "<br /><br />Thank you for registering yourself for using astroenvision.com";
            //body += "<br /><br />For your convenience, please find";
            //body += "<br /><br /><b>Your Login id:</b> " + Client_EmailId + "";
            //body += "<br /><br /><b>Your Password is:</b> " + GenderVal + "";
            //body += "<br /><br />We assure you that details provided on this site shall be kept highly secured.";
            //body += "<br /><br />Please ensure that you use you Login id and Password for any further usage of this site.";
            //body += "<br /><br />The repeat visits will also entitle you for additional discounts also.";
            //body += "<br /><br />Thanks & Regards";
            //body += "<br /><br />(Team Astroenvision)";
            //body += "<br /><br /><a href='https://www.astroenvision.com' target='_blank'>www.astroenvision.com</a>";
            //body += "<br /><br />Mobile Number: 9555600111, 9555700111";
            //result = cs.SendMail(Frommailid, Client_EmailId, "deepaknirwal11@gmail.com", "", "Registration Email Confirmation", body);
            string verify_email = Encrypt(Client_EmailId);
            string host = HttpContext.Current.Request.Url.Host;
            body = "Hello " + Client_Name + ",";
            body += "<br /><br />Please click the following link to activate your account";
            body += "<br /><a href='"+ ResolveUrl("" + WEBSITEDomain + "/VerifyUser.aspx?UserID=" + Server.UrlEncode(verify_email) + "") +"' target='_blank'>Click here to activate your account.</a>";
            body += "<br /><br />Thanks";
            //result = cs.SendMail(Frommailid, Client_EmailId, "deepaknirwal11@gmail.com", "", "Registration Email Confirmation", body);
            result = cs.SendMailWithLogo(Frommailid, Client_EmailId, "deepaknirwal11@gmail.com", "", "Email Account Verification", body, "Y");
            if (result == "SENT")  //FAILED  // SENT
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(signup), "wq", "alert('Confirmation Email has been sent to your email address.!');", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(signup), "wq", "alert('Confirmation Email has been failed. Try Again !');", true);
            }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
        finally
        {
        }
    }
    #endregion

   
}