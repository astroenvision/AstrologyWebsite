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

public partial class userregistration : System.Web.UI.Page
{
    public string WEBSITEDomain = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    public string SMTPServer = ConfigurationManager.AppSettings["SMTPServer"].ToString();
    ASTROLOGY.classesoracle.main obj_main = new ASTROLOGY.classesoracle.main();
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    DataSet ds = new DataSet();
    common cs = new common();
    decimal natal_price, horary_price, finalpay;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["usertype"] != null)
                {
                    string usertypeval = Request.QueryString["usertype"];
                    RadioButtonTipoUser.SelectedValue = usertypeval;
                    RadioButtonTipoUser.Enabled = false;
                    if (Request.QueryString["useremailid"] != null)
                    {
                        txtastro_email.Text = Request.QueryString["useremailid"];
                    }
                    if (Request.QueryString["username"] != null)
                    {
                        txtastro_name.Text = Request.QueryString["username"];
                    }
                }
                mainchannelbind();
                bind_subscription();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public void bind_subscription()
    {
        try
        {
            DataSet ds_natal = new DataSet();
            ds_natal = obj_subs.GetCategoryPrice("", "1", "NATAL", "", "GET_ASTROLOGER_SUBSCRIPTION");
            if (ds_natal.Tables[0].Rows.Count > 0)
            {
                DataTable dtn = ds_natal.Tables[0];
                dvnatalsubs.DataSource = dtn;
                dvnatalsubs.DataBind();
                dtn.Dispose();
            }
            ds_natal.Dispose();

            DataSet ds_horary = new DataSet();
            ds_horary = obj_subs.GetCategoryPrice("", "1", "HORARY", "", "GET_ASTROLOGER_SUBSCRIPTION");
            if (ds_horary.Tables[0].Rows.Count > 0)
            {
                DataTable dth = ds_horary.Tables[0];
                dvhorarysubs.DataSource = dth;
                dvhorarysubs.DataBind();
                dth.Dispose();
            }
            ds_horary.Dispose();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    protected void dvnatalsubs_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            string ActualPrice = "", discountval = "";
            decimal discount, discountprice, FinalPriceVal;
            DataRowView drv = e.Row.DataItem as DataRowView;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label lblsubscription = (Label)e.Row.FindControl("lblsubscription");
                string lblsubscriptionval = lblsubscription.Text;
                if (int.Parse(lblsubscriptionval) >= 12)
                {
                    lblsubscriptionval = (int.Parse(lblsubscriptionval) / 12).ToString();
                    lblsubscription.Text = lblsubscriptionval + " Year";
                }
                else
                {
                    lblsubscription.Text = lblsubscriptionval + " Month";
                }
                Label lblactualprice = (Label)e.Row.FindControl("lblactualprice");
                ActualPrice = lblactualprice.Text;
                Label lbldiscount = (Label)e.Row.FindControl("lbldiscount");
                Label lbldiscountper = (Label)e.Row.FindControl("lbldiscountper");
                lbldiscountper.Text = lbldiscountper.Text + "%";
                Label lblfinalprice = (Label)e.Row.FindControl("lblfinalprice");
                
                discountval = lbldiscount.Text;
                discount = decimal.Parse(discountval);
                discountprice = decimal.Parse(ActualPrice) * (discount / 100);
                lbldiscount.Text = String.Format("{0:0.00}", discountprice);
                FinalPriceVal = decimal.Parse(ActualPrice) - discountprice;
                lblfinalprice.Text = String.Format("{0:0.00}", FinalPriceVal);
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    protected void dvhorarysubs_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            string ActualPrice = "", discountval = "";
            decimal discount, discountprice, FinalPriceVal;
            DataRowView drv = e.Row.DataItem as DataRowView;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label lblsubscription = (Label)e.Row.FindControl("lblsubscription");
                string lblsubscriptionval = lblsubscription.Text;
                if (int.Parse(lblsubscriptionval) >= 12)
                {
                    lblsubscriptionval = (int.Parse(lblsubscriptionval) / 12).ToString();
                    lblsubscription.Text = lblsubscriptionval + " Year";
                }
                else
                {
                    lblsubscription.Text = lblsubscriptionval + " Month";
                }
                Label lblactualprice = (Label)e.Row.FindControl("lblactualprice");
                ActualPrice = lblactualprice.Text;
                Label lbldiscount = (Label)e.Row.FindControl("lbldiscount");
                Label lbldiscountper = (Label)e.Row.FindControl("lbldiscountper");
                lbldiscountper.Text = lbldiscountper.Text + "%";
                Label lblfinalprice = (Label)e.Row.FindControl("lblfinalprice");

                discountval = lbldiscount.Text;
                discount = decimal.Parse(discountval);
                discountprice = decimal.Parse(ActualPrice) * (discount / 100);
                lbldiscount.Text = String.Format("{0:0.00}", discountprice);
                FinalPriceVal = decimal.Parse(ActualPrice) - discountprice;
                lblfinalprice.Text = String.Format("{0:0.00}", FinalPriceVal);
            }
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

        astroddlcountry.Items.Clear();
        astroddlcountry.DataSource = ds;
        astroddlcountry.DataTextField = "loc_name";
        astroddlcountry.DataValueField = "loc_id";
        astroddlcountry.DataBind();
        astroddlcountry.Items.Insert(0, "--Select Country--");
        
        ds.Dispose();
    }
    protected void btnastro_registration_Click(object sender, EventArgs e)
    {
        try
        {
            string subs_validity_natal = "", validfrom_natal = "", validto_natal = "";
            string subs_validity_horary = "", validfrom_horary = "", validto_horary = "";
            for (Int32 I32Counter = 0; I32Counter < dvnatalsubs.Rows.Count; I32Counter++)
            {
                RadioButton rdbnatal = (RadioButton)(dvnatalsubs.Rows[I32Counter].FindControl("rdbnatal"));
                if (rdbnatal.Checked == true)
                {
                    Label lblnatalsubscription = (Label)(dvnatalsubs.Rows[I32Counter].FindControl("lblnatalsubscription"));
                    Label lblfinalprice = (Label)(dvnatalsubs.Rows[I32Counter].FindControl("lblfinalprice"));
                    natal_price = decimal.Parse(lblfinalprice.Text.ToString());
                    subs_validity_natal = lblnatalsubscription.Text;
                }
            }

            for (Int32 I32Counter = 0; I32Counter < dvhorarysubs.Rows.Count; I32Counter++)
            {
                RadioButton rdbhorary = (RadioButton)(dvhorarysubs.Rows[I32Counter].FindControl("rdbhorary"));
                if (rdbhorary.Checked == true)
                {
                    Label lblhorarysubscription = (Label)(dvhorarysubs.Rows[I32Counter].FindControl("lblhorarysubscription"));
                    Label lblfinalprice = (Label)(dvhorarysubs.Rows[I32Counter].FindControl("lblfinalprice"));
                    horary_price = decimal.Parse(lblfinalprice.Text.ToString());
                    subs_validity_horary = lblhorarysubscription.Text;
                }
            }
            finalpay = natal_price + horary_price;

            string finalprice = finalpay.ToString();

            string astro_name = txtastro_name.Text.ToString().Trim();
            if (astro_name == "")
            {
                txtastro_name.Focus();
                ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('Please enter name!');", true);
                return;
            }
            string astro_email = txtastro_email.Text.ToString().Trim().ToLower();
            if (astro_email == "")
            {
                txtastro_email.Focus();
                ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('Please enter emailid!');", true);
                return;
            }
            string astro_pwd = txtastro_pwd.Value.ToString().Trim();
            if (astro_pwd == "")
            {
                txtastro_pwd.Focus();
                ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('Please enter password!');", true);
                return;
            }
            string astro_mobileno = txtastro_mobile.Text.ToString().Trim();
            if (astro_mobileno == "")
            {
                txtastro_mobile.Focus();
                ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('Please enter mobile no!');", true);
                return;
            }
            string astro_add = txtastro_address.Text.ToString().Trim();
            if (astro_add == "")
            {
                txtastro_address.Focus();
                ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('Please enter address!');", true);
                return;
            }
            string astro_gender = astroddlgender.SelectedItem.ToString();
            if (astro_gender == "--Select--")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('Please select your gender!');", true);
                return;
            }
            string countrycal = astroddlcountry.SelectedValue.ToString();
            if (countrycal == "--Select Country--")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('Please select your country!');", true);
                return;
            }
            string stateval = astroddlstate.SelectedValue.ToString();
            if (stateval == "" || stateval == "--Select State--")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('Please select your state!');", true);
                return;
            }
            string cityval = astroddlcity.SelectedValue.ToString();
            if (cityval == "" || cityval == "--Select City--")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('Please select your city!');", true);
                return;
            }
            string astro_pincode = txtastro_pincode.Text.ToString().Trim();
            if (astro_pincode == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('Please enter pincode!');", true);
                return;
            }
            string astro_subscriptionfor = rbl_subscription.SelectedValue.Trim();
            if (astro_subscriptionfor == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('Please select any subscription!');", true);
                return;
            }

            DataSet dsu = new DataSet();
            dsu = obj_main.insert_astro_subscription("", astro_name, astro_email, astro_email, astro_mobileno, "", astro_add, astro_add, "", countrycal, astro_pincode, astro_pwd, "", astro_subscriptionfor, "0", astro_gender, stateval, cityval, "1", subs_validity_natal, validfrom_natal, validto_natal, subs_validity_horary, validfrom_horary, validto_horary, "F", natal_price.ToString(), horary_price.ToString(), finalprice, "INSERT_ASTRO_SUBSCRIPTION");
            if (dsu.Tables[0].Rows.Count > 0)
            {
                string resultstatus = dsu.Tables[0].Rows[0]["flag"].ToString();
                //string AstroID = dsu.Tables[0].Rows[0]["USERID"].ToString();
                //AstroID = AstroID + "-ASTROLOGER";
                //if (resultstatus == "SUCCESS")
                //{
                //    Response.Redirect(ResolveUrl("~/auto_ccavenue.aspx?member=" + AstroID.Trim() + "&amount=" + finalprice + "&clientemailid=" + astro_email + "&group=" + astro_subscriptionfor.Trim().ToLower() + ""));
                //}

                if (resultstatus == "EXIST")
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('You have already registered');document.location.href='login.aspx';", true);
                    return;
                }
                else
                {

                    string Current_Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ff").Replace("-", "").Replace(":", "").Replace(" ", "");

                    string SubjectVerify = "Astro Envision - Email Verification Mail";
                    string bodyverify = "<p style='font-size: 15.0pt;'>Dear " + astro_name + " Ji</p><br/>";
                    bodyverify += "<p style='font-size: 15.0pt;'>Thanks for registration of Free Launch Trial version of - Horary (Prashna) Software.</p><br/>";
                    bodyverify += "<p style='font-size: 15.0pt;'>Please wait for 2-3 days for activation, after you confirm your email id.</p><br/>";
                    bodyverify += "<p style='font-size: 15.0pt;'>Your username is " + astro_email + ".</p><br/>";
                    bodyverify += "<p style='font-size: 18.0pt;'>To verify your email ID, Please <a href='" + WEBSITEDomain + "/astrologer_verification.aspx?emailid=" + astro_email + "&verification_code=" + Current_Date + "'>Click here</a></p><br/>";
                    bodyverify += "<p style='font-size: 15.0pt;'>If the link does not get clicked or does not open a Browser Window on Click, Please copy the undermentioned link and paste in your web Browser</p>";
                    bodyverify += "<p style='font-size: 15.0pt;'>" + WEBSITEDomain + "/astrologer_verification.aspx?emailid=" + astro_email + "&verification_code=" + Current_Date + "</p><br/>";
                    bodyverify += "<p style='font-size: 15.0pt;'>You will get the activation mail soon.</p><br/>";
                    bodyverify += "<p style='font-size: 13.0pt;'>Thanks & Regards<br/>";
                    bodyverify += "Your Sincerely</p><br/>";
                    bodyverify += "<p style='font-size: 13.0pt;'>Hari Sharma<br/>";
                    bodyverify += "For Astro Envision<br/>";
                    bodyverify += "support@astroenvision.com<br/>";
                    bodyverify += "+91-9958883955<br/>+91-9555600111</p>";

                    //string Subject = "Astro Envision - Free Trial Horary Software - Registration Verification";
                    //string body = "<p>Dear " + astro_name + ",</p>";
                    //body += "<p>We are happy to receive your registration details for using Horary Module.</p>";
                    //body += "<p>You would receive the activation confirmation mail from Astroenvision within 2 day’s for usage of Software</p>";
                    //body += "<p>Thanks & Regards<br/>";
                    //body += "Your Sincerely</p>";
                    //body += "<p>Hari Sharma<br/>";
                    //body += "For Astro Envision<br/>";
                    //body += "support@astroenvision.com<br/>";
                    //body += "+91-9958883955<br/>+91-9555600111</p>";

                    DataSet dsc = new DataSet();
                    string frommailid = "";
                    dsc = cs.Get_Configuration("Registration", "SUPPORT");
                    if (dsc.Tables[0].Rows.Count > 0)
                    {
                        frommailid = dsc.Tables[0].Rows[0]["EMAILID"].ToString();
                    }
                    dsc.Dispose();

                    string successmsg = "Dear " + astro_name + "";
                    successmsg += "\\n\\You have successfully registered with Astroenvision for Horary Trial Version.";
                    successmsg += "\\n\\Astro Envision has sent a mail to you for confirmation of Your email id.";
                    successmsg += "\\n\\It is very important that you <Click> in the mail to verify your email id for activation.";
                    //string result = cs.SendMailWithLogo(frommailid, astro_email, "", "", Subject, body,"Y");

                    string result2 = cs.SendMailWithLogo(frommailid, astro_email, "", "", SubjectVerify, bodyverify, "Y");
                    if (result2 == "SENT")
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('" + successmsg + "');document.location.href='login.aspx';", true);
                        return;
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('You have not registered. Try Again');document.location.href='login.aspx';", true);
                        return;
                    }
                }
            }
            dsu.Dispose();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        
    }
    protected void btnregister_Click(object sender, EventArgs e)
    {
        int id = 0;
        string name = "", emailval = "", pwd = "", contactno = "", address = "", city = "", state = "", country = "", active = "T", flag = "INSERT", outflag = "", pincode = "",user_gender="";
        name = txtname.Text.ToString().Trim();
        if (name == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('Please Enter Name!');", true);
            return;
        }
        emailval = txtmailid.Text.ToString().Trim().ToLower();
        if (emailval == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('Please Enter Email address!');", true);
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
            ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('Please Enter valid email address!');", true);
            return;
        }
        pwd = txtpwd.Text.ToString().Trim();
        if (pwd == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('Please Enter Password!');", true);
            return;
        }
        contactno = txtcontact.Text.ToString().Trim();
        if (contactno == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('Please Enter Contact No!');", true);
            return;
        }
        address = txtaddress.Text.ToString().Trim();
        user_gender = userddlgender.SelectedItem.Text.ToString();
        if (user_gender == "--Select--")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('Please select your gender!');", true);
            return;
        }

        country = ddlcountry.SelectedValue.ToString().Trim();
        if (ddlcountry.SelectedValue.ToString() == "--Select Country--")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('Please Select Any Country !');", true);
            return;
        }
        state = ddlstate.SelectedValue.ToString().Trim();
        if (ddlstate.SelectedValue.ToString() == "--Select State--")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('Please Select Any State !');", true);
            return;
        }
        city = ddlcity.SelectedValue.ToString().Trim();
        if (ddlcity.SelectedValue.ToString() == "--Select City--")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('Please Select Any City !');", true);
            return;
        }
        pincode = txtpincode.Text.ToString().Trim();
        ds = obj_subs.InsertClientInfo(id, name, emailval, contactno, pwd, address, city, state, country, pincode, active,user_gender.ToUpper(), "SAVECLIENTINFO");
        if (ds.Tables[0].Rows.Count > 0)
        {
            outflag = ds.Tables[0].Rows[0]["flag"].ToString();
            if (outflag == "SUCCESS")
            {
                SendMailToUser(name, "", "", emailval, "", pwd);
                Session["myemailid"] = emailval;
                txtname.Text = "";
                txtmailid.Text = "";
                txtpwd.Text = "";
                txtcontact.Text = "";
                txtaddress.Text="";
                txtpincode.Text = "";
                ddlcountry.Items.Clear();
                ddlcountry.Items.Insert(0, "--Select Country--");
                ddlstate.Items.Clear();
                ddlstate.Items.Insert(0, "--Select State--");
                ddlcity.Items.Clear();
                ddlcity.Items.Insert(0, "--Select City--");

                ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('You have successfully registered.');document.location.href='login.aspx';", true);
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
                ScriptManager.RegisterClientScriptBlock(this, typeof(userregistration), "wq", "alert('You have already registered.');document.location.href='login.aspx';", true);
                return;

            }
        }
    }

    //private bool IsValidEmailId(string InputEmail)
    //{
    //    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
    //    Match match = regex.Match(InputEmail);
    //    if (match.Success)
    //        return true;
    //    else
    //        return false;
    //}

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
    protected void astroddlcountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (astroddlcountry.SelectedValue.ToString() != "--Select Country--")
        {
            bindstates(astroddlcountry.SelectedValue.ToString());
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

        astroddlstate.Items.Clear();
        astroddlstate.DataSource = ds;
        astroddlstate.DataTextField = "loc_name";
        astroddlstate.DataValueField = "loc_id";
        astroddlstate.DataBind();
        astroddlstate.Items.Insert(0, "--Select State--");

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
    protected void astroddlstate_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (astroddlstate.SelectedValue.ToString() != "--Select State--")
        {
            bindcities(astroddlcountry.SelectedValue.ToString(), astroddlstate.SelectedValue.ToString());
        }
        else
        {
            astroddlcity.Items.Clear();
            astroddlcity.Items.Insert(0, "--Select City--");
        }
    }

    public void bindcities(string countrycode, string statecode)
    {
        ds = cs.bindcity(countrycode, statecode, "", "GETALLCITIES");
        ddlcity.Items.Clear();
        ddlcity.DataSource = ds;
        ddlcity.DataTextField = "loc_name";
        ddlcity.DataValueField = "loc_id";
        ddlcity.DataBind();
        ddlcity.Items.Insert(0, "--Select City--");

        astroddlcity.Items.Clear();
        astroddlcity.DataSource = ds;
        astroddlcity.DataTextField = "loc_name";
        astroddlcity.DataValueField = "loc_id";
        astroddlcity.DataBind();
        astroddlcity.Items.Insert(0, "--Select City--");

        ds.Dispose();
    }
    //protected void rbl_natalperiod_SelectedIndexChanged(object sender, EventArgs e)
    //{

    //}
    //protected void rbl_horaryperiod_SelectedIndexChanged(object sender, EventArgs e)
    //{

    //}
    protected void rbl_subscription_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
