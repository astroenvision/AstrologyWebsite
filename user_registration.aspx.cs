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

public partial class user_registration : System.Web.UI.Page
{
    public string WEBSITEDomain = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    public string SMTPServer = ConfigurationManager.AppSettings["SMTPServer"].ToString();
    ASTROLOGY.classesoracle.main obj_main = new ASTROLOGY.classesoracle.main();
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    DataSet ds = new DataSet();
    common cs = new common();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            mainchannelbind();
            Session["UserEmailID"] = null;
            if (Request.QueryString["cartid"] != null && Request.QueryString["cartid"] != null)
            {
                ViewState["cartid"] = Request.QueryString["cartid"].ToString().Trim();
                hdncartid.Value = ViewState["cartid"].ToString().Trim();
                if (Request.QueryString["groupid"] != null)
                {
                    ViewState["GroupId"] = Request.QueryString["groupid"].ToString().Trim();
                    hdngroupid.Value = ViewState["GroupId"].ToString();
                }
                if (Session["UserEmailID"] != null)
                {
                    string totalprice = "";
                    DataSet dsp = new DataSet();
                    dsp = obj_subs.AddToCartBilling(0, hdncartid.Value.ToString().Trim(), "","", "", "GETFINALPRICE","", "");
                    if (dsp.Tables[0].Rows.Count > 0)
                    {
                        totalprice = dsp.Tables[0].Rows[0]["TOTAL_PRICE"].ToString().Trim();
                    }
                    dsp.Dispose();

                    string CountryCode = GetCountryCode();
                    if (CountryCode == "IN" && totalprice != "")
                    {
                        Response.Redirect(ResolveUrl("~/auto_ccavenue.aspx?member=" + hdncartid.Value.ToString().Trim() + "&amount=" + totalprice + "&clientemailid=" + Session["endusermail"].ToString() + "&group=" + hdngroupid.Value.ToString().Trim().ToLower() + ""));
                    }
                }
            }
        }
    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        try
        {
            DataSet dscl = new DataSet();
            string mail = txtloginemail.Text.ToString().Trim();
            //if (mail == "")
            //{
            //    ScriptManager.RegisterClientScriptBlock(this, typeof(user_registration), "wq", "alert('Please Enter Email address!');", true);
            //    return;
            //}
            //if (IsValidEmailId(mail))
            //{
            //    mail = txtloginemail.Text.ToString().Trim();
            //}
            //else
            //{
            //    txtloginemail.Text = "";
            //    txtloginemail.Focus();
            //    ScriptManager.RegisterClientScriptBlock(this, typeof(user_registration), "wq", "alert('Please Enter valid email address!');", true);
            //    return;
            //}
            string pass = txtloginpwd.Text.ToString().Trim();
            //string pass = txtloginpwd.Value.ToString();
            //if (pass == "")
            //{
            //    ScriptManager.RegisterClientScriptBlock(this, typeof(user_registration), "wq", "alert('Please Enter Password!');", true);
            //    return;
            //}
            dscl = obj_subs.CheckLoginEndUser(mail, pass, "", "","CHECKENDUSERLOGIN");
            if (dscl.Tables[0].Rows.Count > 0)
            {
                string flag = dscl.Tables[0].Rows[0]["flag"].ToString().Trim();
                if (flag=="YES")
                {
                    string emailval = dscl.Tables[1].Rows[0]["EMAILID"].ToString().Trim();
                    //Session["usermail"] = emailval;
                    Session["UserEmailID"] = emailval;

                    //DataSet dscname = new DataSet();
                    //dscname = obj_subs.AstGetCommon(emailval, "", "", "GETCLIENTNAME");
                    //if (dscname.Tables[0].Rows.Count > 0)
                    //{
                    //    Session["name"] = dscname.Tables[0].Rows[0]["NAME"].ToString().Trim();
                    //}
                    //dscname.Dispose();

                    string totalprice = "";
                    DataSet dsp = new DataSet();
                    dsp = obj_subs.AddToCartBilling(0, hdncartid.Value.ToString().Trim(),"", "", "", "GETFINALPRICE","", "");
                    if (dsp.Tables[0].Rows.Count > 0)
                    {
                        totalprice = dsp.Tables[0].Rows[0]["TOTAL_PRICE"].ToString().Trim();
                    }
                    dsp.Dispose();

                    string CountryCode = GetCountryCode();
                    if (CountryCode == "IN" && totalprice != "")
                    {
                        Response.Redirect(ResolveUrl("~/auto_ccavenue.aspx?member=" + hdncartid.Value.ToString().Trim() + "&amount=" + totalprice + "&clientemailid=" + emailval + "&group=" + hdngroupid.Value.ToString().Trim().ToLower() + ""));
                    }
                }
                if (flag == "NO")
                {
                    string flag2 = dscl.Tables[1].Rows[0]["flag"].ToString().Trim();
                    if (flag2 == "NOT REGISTERED")
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(user_registration), "wq", "alert('Your email address is not registered!');", true);
                        return;
                    }
                    if (flag2 == "INVALID PASSOWRD")
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(user_registration), "wq", "alert('Your password is invalid please try again!');", true);
                        return;
                    }
                }
            }
            dscl.Dispose();
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }
    protected void btnforgotpwd_Click(object sender, EventArgs e)
    {
        try
        {
            DataSet dsfp = new DataSet();
            string email_val = txtforgotemail.Text.ToString().Trim();
            if (email_val == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(user_registration), "wq", "alert('Please Enter Email address!');", true);
                return;
            }
            if (IsValidEmailId(email_val))
            {
                email_val = txtforgotemail.Text.ToString().Trim();
            }
            else
            {
                txtforgotemail.Text = "";
                txtforgotemail.Focus();
                ScriptManager.RegisterClientScriptBlock(this, typeof(user_registration), "wq", "alert('Please Enter valid email address!');", true);
                return;
            }
            dsfp = obj_subs.CheckLoginEndUser(email_val, "", "", "", "FORGOTPASSWORD");
            if (dsfp.Tables[0].Rows.Count > 0)
            {
                string flag = dsfp.Tables[0].Rows[0]["flag"].ToString().Trim();
                if (flag == "YES")
                {
                    string name = dsfp.Tables[1].Rows[0]["NAME"].ToString().Trim();
                    string pwd = dsfp.Tables[1].Rows[0]["PASSWORD"].ToString().Trim();

                    DataSet dsc = new DataSet();
                    string frommailid = "";
                    dsc = cs.Get_Configuration("Registration", "SUPPORT");
                    if (dsc.Tables[0].Rows.Count > 0)
                    {
                        frommailid = dsc.Tables[0].Rows[0]["EMAILID"].ToString();
                    }
                    dsc.Dispose();

                    string body = "Hello " + name + ",";
                    body += "<br /><br />Your password is : " + pwd + "";
                    //body += "<br /><a target='_blank' href=\"" + ResolveUrl("" + WEBSITEDomain + "/login.aspx") + "\">Click here to login !</a>";
                    body += "<br /><br />Thanks";
                    MailMessage objMailMessage = new MailMessage();
                    MailAddress mail = new MailAddress(frommailid);
                    objMailMessage.From = mail;
                    objMailMessage.To.Add(email_val);
                    objMailMessage.Bcc.Add("deepaknirwal11@gmail.com");
                    objMailMessage.IsBodyHtml = true;
                    objMailMessage.Subject = "Your Forget Password:"; // Verification Email
                    objMailMessage.Body = body;
                    SmtpClient smtp = new SmtpClient(SMTPServer);
                    smtp.DeliveryMethod = SmtpDeliveryMethod.PickupDirectoryFromIis;
                    smtp.Send(objMailMessage);
                    ScriptManager.RegisterClientScriptBlock(this, typeof(user_registration), "wq", "alert('Your Password has been sent to your email address.!');", true);

                }
                if (flag == "NO")
                {
                    string flag2 = dsfp.Tables[1].Rows[0]["flag"].ToString().Trim();
                    if (flag2 == "NOT REGISTERED")
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(user_registration), "wq", "alert('Your email address is not registered!');", true);
                        return;
                    }
                }
            }
            dsfp.Dispose();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
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
    protected void btnregister_Click(object sender, EventArgs e)
    {
        int id = 0;
        string name = "", emailval = "", pwd = "", contactno = "", address = "", city = "", state = "", country = "", active = "T", flag = "INSERT", outflag = "", pincode = "", user_gender="";
        name = txtname.Text.ToString().Trim();
        //if (name == "")
        //{
        //    ScriptManager.RegisterClientScriptBlock(this, typeof(user_registration), "wq", "alert('Please Enter Name!');", true);
        //    return;
        //}
        emailval = txtmailid.Text.ToString().Trim();
        //if (emailval == "")
        //{
        //    ScriptManager.RegisterClientScriptBlock(this, typeof(user_registration), "wq", "alert('Please Enter Email address!');", true);
        //    return;
        //}
        //if (IsValidEmailId(emailval))
        //{
        //    emailval = txtmailid.Text.ToString().Trim();
        //}
        //else
        //{
        //    txtmailid.Text = "";
        //    txtmailid.Focus();
        //    ScriptManager.RegisterClientScriptBlock(this, typeof(user_registration), "wq", "alert('Please Enter valid email address!');", true);
        //    return;
        //}
        pwd = txtpwd.Text.ToString().Trim();
        //if (pwd == "")
        //{
        //    ScriptManager.RegisterClientScriptBlock(this, typeof(user_registration), "wq", "alert('Please Enter Password!');", true);
        //    return;
        //}
        contactno = txtcontact.Text.ToString().Trim();
        //if (contactno == "")
        //{
        //    ScriptManager.RegisterClientScriptBlock(this, typeof(user_registration), "wq", "alert('Please Enter Contact No!');", true);
        //    return;
        //}
        user_gender = userddlgender.SelectedItem.Text.ToString().Trim();
        address = txtaddress.Text.ToString().Trim();
        country = ddlcountry.SelectedValue.ToString().Trim();
        //if (ddlcountry.SelectedValue.ToString() == "--Select Country--")
        //{
        //    ScriptManager.RegisterClientScriptBlock(this, typeof(user_registration), "wq", "alert('Please Select Any Country !');", true);
        //    return;
        //}
        state = ddlstate.SelectedValue.ToString().Trim();
        //if (ddlstate.SelectedValue.ToString() == "--Select State--")
        //{
        //    ScriptManager.RegisterClientScriptBlock(this, typeof(user_registration), "wq", "alert('Please Select Any State !');", true);
        //    return;
        //}
        city = ddlcity.SelectedValue.ToString().Trim();
        //if (ddlcity.SelectedValue.ToString() == "--Select City--")
        //{
        //    ScriptManager.RegisterClientScriptBlock(this, typeof(user_registration), "wq", "alert('Please Select Any City !');", true);
        //    return;
        //}
        pincode = txtpincode.Text.ToString().Trim();
        ds = obj_subs.InsertClientInfo(id, name, emailval, contactno, pwd, address, city, state, country,pincode, active,user_gender.ToUpper(), "SAVECLIENTINFO");
        if (ds.Tables[0].Rows.Count > 0)
        {
            outflag = ds.Tables[0].Rows[0]["flag"].ToString();
            if (outflag == "SUCCESS")
            {
                //Session["myemailid"] = emailval;
                //txtname.Text = "";
                Session["UserEmailID"] = emailval;
                //Session["usermail"] = emailval;
                //txtmailid.Text = "";
                //txtpwd.Text = "";
                //txtcontact.Text = "";
                //txtaddress.Text = "";
                //txtpincode.Text = "";
                //ddlcountry.Items.Clear();
                //ddlcountry.Items.Insert(0, "--Select Country--");
                //ddlstate.Items.Clear();
                //ddlstate.Items.Insert(0, "--Select State--");
                //ddlcity.Items.Clear();
                //ddlcity.Items.Insert(0, "--Select City--");

                string totalprice = "";
                DataSet dsp = new DataSet();
                dsp = obj_subs.AddToCartBilling(0, hdncartid.Value.ToString().Trim(),"", "", "", "GETFINALPRICE","", "");
                if (dsp.Tables[0].Rows.Count > 0)
                {
                    totalprice = dsp.Tables[0].Rows[0]["TOTAL_PRICE"].ToString().Trim();
                }
                dsp.Dispose();

                string CountryCode = GetCountryCode();
                if (CountryCode == "IN" && totalprice!="")
                {
                    SendMailToUser(name, hdncartid.Value.ToString(), "", emailval, hdngroupid.Value.ToString(), pwd);

                    Response.Redirect(ResolveUrl("~/auto_ccavenue.aspx?member=" + hdncartid.Value.ToString().Trim() + "&amount=" + totalprice + "&clientemailid=" + emailval + "&group=" + hdngroupid.Value.ToString().Trim().ToLower() + ""));
                }

                ScriptManager.RegisterClientScriptBlock(this, typeof(user_registration), "wq", "alert('You have successfully registered !');", true);
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

                ScriptManager.RegisterClientScriptBlock(this, typeof(user_registration), "wq", "alert('You have already registered !');", true);
                return;

            }
        }
    }
    private bool IsValidEmailId(string InputEmail)
    {
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Match match = regex.Match(InputEmail);
        if (match.Success)
            return true;
        else
            return false;
    }

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
            body = "Dear Mr. " + Client_Name + ",";
            body += "<br /><br />Thank you for registering yourself for using astroenvision.com";
            body += "<br /><br />For your convenience, please find";
            body += "<br /><br /><b>Your Login id:</b> " + Client_EmailId + "";
            body += "<br /><br /><b>Your Password is:</b> " + GenderVal + "";
            body += "<br /><br />We assure you that details provided on this site shall be kept highly secured.";
            body += "<br /><br />Please ensure that you use you Login id and Password for any further usage of this site.";
            body += "<br /><br />The repeat visits will also entitle you for additional discounts also.";
            body += "<br /><br />Thanks & Regards";
            body += "<br /><br />(Team Astroenvision)";
            body += "<br /><br /><a href='http://www.astroenvision.com' target='_blank'>www.astroenvision.com</a>";
            body += "<br /><br />Mobile Number: 9555600111, 9555700111";
            result = cs.SendMail(Frommailid, Client_EmailId, "deepaknirwal11@gmail.com", "", "Registration Email Confirmation", body);
            if (result == "SENT")  //FAILED  // SENT
            {
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

    public void bindcities(string countrycode,string statecode)
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
            dscd = obj_subs.AstGetCommon(IPNumber.ToString(), "", "", "GETCOUNTRYCODE");
            if (dscd.Tables[0].Rows.Count > 0)
            {
                CountryCode = dscd.Tables[0].Rows[0]["COUNTRY_CODE"].ToString();
            }
        }
        return CountryCode;
    }
}
