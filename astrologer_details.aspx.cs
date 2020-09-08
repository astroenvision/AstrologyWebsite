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

public partial class astrologer_details : System.Web.UI.Page
{
    public string WEBSITEDomain = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    public string SMTPServer = ConfigurationManager.AppSettings["SMTPServer"].ToString();
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    common cs = new common();
    DataSet ds = new DataSet();
    string srchtxt = "",result="";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            bind_userdetails();
            BindGridview();
        }
    }
    protected void BindGridview()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("rowid", typeof(int));
        dt.Columns.Add("name", typeof(string));
        dt.Columns.Add("emailid", typeof(string));
        DataRow dr = dt.NewRow();
        dr["rowid"] = 1;
        dr["name"] = string.Empty;
        dr["emailid"] = string.Empty;
        dt.Rows.Add(dr);
        ViewState["Curtbl"] = dt;
        gvDetails.DataSource = dt;
        gvDetails.DataBind();
    }

    private void AddNewRow()
    {
        int rowIndex = 0;

        if (ViewState["Curtbl"] != null)
        {
            DataTable dt = (DataTable)ViewState["Curtbl"];
            DataRow drCurrentRow = null;
            if (dt.Rows.Count > 0)
            {
                for (int i = 1; i <= dt.Rows.Count; i++)
                {
                    TextBox txtname = (TextBox)gvDetails.Rows[rowIndex].Cells[1].FindControl("txtName");
                    TextBox txtemailid = (TextBox)gvDetails.Rows[rowIndex].Cells[2].FindControl("txtemailid");
                    drCurrentRow = dt.NewRow();
                    drCurrentRow["rowid"] = i + 1;
                    dt.Rows[i - 1]["name"] = txtname.Text;
                    dt.Rows[i - 1]["emailid"] = txtemailid.Text;
                    rowIndex++;
                }
                dt.Rows.Add(drCurrentRow);
                ViewState["Curtbl"] = dt;
                gvDetails.DataSource = dt;
                gvDetails.DataBind();
            }
        }
        else
        {
            Response.Write("ViewState Value is Null");
        }
        SetOldData();
    }
    private void SetOldData()
    {
        int rowIndex = 0;
        if (ViewState["Curtbl"] != null)
        {
            DataTable dt = (DataTable)ViewState["Curtbl"];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TextBox txtname = (TextBox)gvDetails.Rows[rowIndex].Cells[1].FindControl("txtName");
                    TextBox txtemailid = (TextBox)gvDetails.Rows[rowIndex].Cells[2].FindControl("txtemailid");
                    txtname.Text = dt.Rows[i]["name"].ToString();
                    txtemailid.Text = dt.Rows[i]["emailid"].ToString();
                    rowIndex++;
                }
            }
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        AddNewRow();
    }
    protected void gvDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (ViewState["Curtbl"] != null)
        {
            DataTable dt = (DataTable)ViewState["Curtbl"];
            DataRow drCurrentRow = null;
            int rowIndex = Convert.ToInt32(e.RowIndex);
            if (dt.Rows.Count > 1)
            {
                dt.Rows.Remove(dt.Rows[rowIndex]);
                drCurrentRow = dt.NewRow();
                ViewState["Curtbl"] = dt;
                gvDetails.DataSource = dt;
                gvDetails.DataBind();

                for (int i = 0; i < gvDetails.Rows.Count - 1; i++)
                {
                    gvDetails.Rows[i].Cells[0].Text = Convert.ToString(i + 1);
                }
                SetOldData();
            }
        }
    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        bind_userdetails();
    }
    protected void btnreset_Click(object sender, EventArgs e)
    {
        txtkeyword.Text = "";
        BindGridview();
    }
    protected void btnsendmail_Click(object sender, EventArgs e)
    {
        try
        {
            int rowIndex = 0;
            if (ViewState["Curtbl"] != null)
            {
                DataTable dt = (DataTable)ViewState["Curtbl"];
                if (dt.Rows.Count > 0)
                {
                    string body = "", Name = "Sir / Madam", EmailID = "", frommailid="";
                    //string Subject = "Horary Software – Registration – Free Trial Usage";
                    string Subject = "Introducing First Ever Horary (Prashna) Astrology Software";
                    DataSet dsc = new DataSet();
                    dsc = cs.Get_Configuration("Registration", "SUPPORT");
                    if (dsc.Tables[0].Rows.Count > 0)
                    {
                        frommailid = dsc.Tables[0].Rows[0]["EMAILID"].ToString();
                    }
                    dsc.Dispose();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        TextBox txtname = (TextBox)gvDetails.Rows[rowIndex].Cells[1].FindControl("txtName");
                        TextBox txtemailid = (TextBox)gvDetails.Rows[rowIndex].Cells[2].FindControl("txtemailid");
                        if (txtname.Text!="")
                        {
                            Name = txtname.Text.Trim();
                        }
                        EmailID = txtemailid.Text.Trim();
                        rowIndex++;

                        //body = "";
                        //body = "<p>Dear " + Name + ",</p>";
                        //body += "<p>We, at Astroenvision, are happy to launch Horary (Tajik – Prashna) Software, for the first time in India. You may read the expert's comments & Salient features.</p>";
                        //body += "<p>You are one-off exclusive Astrologer, being offered access to use this Free-Trial Horary Software. The link is given below for your activation.</p>";
                        //body += "<p>May we, request you to kindly register yourself by clicking on the below link for activation of Free-Trial Horary Software.</p>";
                        //body += "<p><a target='_blank' href=\"" + ResolveUrl("" + WEBSITEDomain + "/astrologer/registration.html") + "\">Click here to register</a></p>";
                        //body += "<p>Thanks & Regards<br/>";
                        //body += "Your Sincerely</p>";
                        //body += "<p>Hari Sharma<br/>";
                        //body += "For Astro Envision<br/>";
                        //body += "support@astroenvision.com<br/>";
                        //body += "+91-9958883955<br/>+91-9555600111</p>";
                        //result = cs.SendMailWithLogo(frommailid, EmailID, "", "", Subject, body, "Y");

                        MailMessage objMailMessage = new MailMessage();
                        MailAddress mail = new MailAddress(frommailid);
                        objMailMessage.From = mail;
                        objMailMessage.To.Add(EmailID);
                        //objMailMessage.Bcc.Add("chdeepaknirwal10@gmail.com");
                        objMailMessage.IsBodyHtml = true;

                        body = "";
                        body += "<p style='font-size: 15.0pt;'>Dear " + Name + " Ji,</p>";
                        body += "<p style='font-size: 15.0pt;'><center style='font-size: 15.0pt;'><font color='red'>FREE TRIAL OFFER - HORARY SOFTWARE (Tajik Software)</font></center></p>";
                        body += "<p style='font-size: 15.0pt;'>We, at Astro Envision, are happy to inform you the Launch of Horary (Tajik – Prashna) Software, for the first time in India.</p>";
                        body += "<p style='font-size: 15.0pt;'>The complex calculations of Horary Yogas such as Ithsaal, Eshraaf, Kambool, etc. are significant features of this Unique Horary Software. The Predictive horary module covers 12 Horary Category such as Employment & Profession, Disease, Litigation and so on apart from Horary Knowledge and other salient features</p>";
                        body += "<p style='font-size: 15.0pt;'>Kindly register yourself by clicking on the below link for activation of the Free Trial Offer.</p>";
                        //body += "<p style='font-size: 15.0pt;'>Links:<br/>";
                        body += "<p style='font-size: 15.0pt;'><a style='color:#5f5fe2;border-bottom: 1px solid;text-decoration: none;' target='_blank' href=\"" + ResolveUrl("" + WEBSITEDomain + "/userregistration.aspx?usertype=ASTROLOGER&useremailid=" + EmailID + "&username=" + Name + "") + "\">Click here for Free Trial offer Registration</a></p>";
                        //body += "Expert’s Comments: <a target='_blank' href=\"" + ResolveUrl("" + WEBSITEDomain + "/astrology/expert-s-comment/shri-j-n-sharma/3-10.html") + "\">Click here</a></p><br/>";
                        body += "<p style='font-size: 15.0pt;'><font color='red'>Note: Please ensure that you fill in a valid email at the time of Registration for Free Trial Offer.</font></p>";

                        //add our attachment
                        Attachment imgAtt1 = new Attachment(HttpContext.Current.Server.MapPath("~/Image/mailer_astro.jpg"));
                        //give it a content id that corresponds to the src we added in the body img tag
                        imgAtt1.ContentId = "mailer_astro.jpg";
                        //add the attachment to the email
                        objMailMessage.Attachments.Add(imgAtt1);
                        body += "<p style='font-size: 15.0pt;'><a href=\"" + (HttpContext.Current.Handler as Page).ResolveUrl("" + WEBSITEDomain + "/userregistration.aspx?usertype=ASTROLOGER&useremailid=" + EmailID + "&username=" + Name + "") + "\" target='_blank'><img src=\"cid:mailer_astro.jpg\"></a></p>";

                        body += "<p style='font-size: 13.0pt;'>For Astro Envision<br/>";
                        body += "Astrologer (Hari Sharma)<br/>";
                        body += "support@astroenvision.com<br/>";
                        body += "www.astroenvision.com<br/>";
                        body += "+91-11-995883955</p>";
                       
                        //add our attachment
                        Attachment imgAtt = new Attachment(HttpContext.Current.Server.MapPath("~/Image/SignatureLogo.png"));
                        //give it a content id that corresponds to the src we added in the body img tag
                        imgAtt.ContentId = "SignatureLogo.png";
                        //add the attachment to the email
                        objMailMessage.Attachments.Add(imgAtt);
                        body += "<br/><a href=\"" + (HttpContext.Current.Handler as Page).ResolveUrl("" + WEBSITEDomain + "") + "\" target='_blank'><img src=\"cid:SignatureLogo.png\"></a>";

                        objMailMessage.Subject = Subject;
                        objMailMessage.Body = body;
                        SmtpClient smtp = new SmtpClient(SMTPServer);
                        //smtp.DeliveryMethod = SmtpDeliveryMethod.PickupDirectoryFromIis;
                        smtp.Send(objMailMessage);
                        result = "SENT";
                        
                    }

                    if (result == "SENT")
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(astrologer_details), "wq", "alert('Mail has been sent successfully.');", true);
                        return;
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(astrologer_details), "wq", "alert('Mail has not been sent successfully. Try Again');", true);
                        return;
                    }
                }
            }


        //    string Subject = "Horary Software – Registration – Free Usage";
        //    string body = "", Name = "Sir / Madam", EmailID="";
        //    DataSet dsc = new DataSet();
        //    string frommailid = "";
        //    dsc = cs.Get_Configuration("Registration", "SUPPORT");
        //    if (dsc.Tables[0].Rows.Count > 0)
        //    {
        //        frommailid = dsc.Tables[0].Rows[0]["EMAILID"].ToString();
        //    }
        //    dsc.Dispose();

        //    srchtxt = txtkeyword.Text.Trim();
        //    if (srchtxt.IndexOf(",") > -1)
        //    {
        //        string[] splsrchtxt = srchtxt.Split(',');
        //        for (int index = 0; index < splsrchtxt.Length; index++)
        //        {
        //            body = "";
        //            EmailID = splsrchtxt[index];
        //            if (EmailID.IndexOf("~") > -1)
        //            {
        //                string[] SplitEmailID = EmailID.Split('~');
        //                Name = SplitEmailID[0];
        //                EmailID = SplitEmailID[1];
        //            }
        //            body = "<p>Dear " + Name + ",</p>";
        //            body += "<p>We, at Astroenvision are happy to launch Free-Trial Horary (Tajik – Prashna) Software. This is a unique Free-Trial Horary (Tajik - Prashna) Software being introduced the first time in India. You may read the expert's comments & Salient features. The link is given below.</p>";
        //            body += "<p>You are one off exclusive Astrologer’s, offered free access to use this Free-Trial Horary Software.</p>";
        //            body += "<p>May we, request you to kindly register yourself by clicking on the below link for activation of Free-Trial Horary Software.</p>";
        //            body += "<p>Click here <a target='_blank' href=\"" + ResolveUrl("" + WEBSITEDomain + "/registration.html") + "\">Registration Link</a></p>";
        //            body += "<p>Thanks & Regards<br/>";
        //            body += "Your Sincerely</p>";
        //            body += "<p>Hari Sharma<br/>";
        //            body += "Astrologer<br/>";
        //            body += "Astro Envision</p>";
        //            //body += "<br/><a href=\"" + ResolveUrl("" + WEBSITEDomain + "") + "\" target='_blank'><img src=\"cid:SignatureLogo.png\"></a>";

        //            result = cs.SendMailWithLogo(frommailid, EmailID, "", "", Subject, body,"Y");
        //        }

        //        if (result == "SENT")
        //        {
        //            ScriptManager.RegisterClientScriptBlock(this, typeof(astrologer_details), "wq", "alert('Mail has been sent successfully.');", true);
        //            return;
        //        }
        //        else
        //        {
        //            ScriptManager.RegisterClientScriptBlock(this, typeof(astrologer_details), "wq", "alert('Mail has not been sent successfully. Try Again');", true);
        //            return;
        //        }
        //    }
        //    else
        //    {
        //        EmailID = srchtxt;
        //        if (EmailID.IndexOf("~") > -1)
        //        {
        //            string[] SplitEmailID = EmailID.Split('~');
        //            Name = SplitEmailID[0];
        //            EmailID = SplitEmailID[1];
        //        }
        //        body = "<p>Dear " + Name + ",</p>";
        //        body += "<p>We, at Astroenvision are happy to launch Free-Trial Horary (Tajik – Prashna) Software. This is a unique Free-Trial Horary (Tajik - Prashna) Software being introduced the first time in India. You may read the expert's comments & Salient features. The link is given below.</p>";
        //        body += "<p>You are one off exclusive Astrologer’s, offered free access to use this Free-Trial Horary Software.</p>";
        //        body += "<p>May we, request you to kindly register yourself by clicking on the below link for activation of Free-Trial Horary Software.</p>";
        //        body += "<p>Click here <a target='_blank' href=\"" + ResolveUrl("" + WEBSITEDomain + "/registration.html") + "\">Registration Link</a></p>";
        //        body += "<p>Thanks & Regards<br/>";
        //        body += "Your Sincerely</p>";
        //        body += "<p>Hari Sharma<br/>";
        //        body += "Astrologer<br/>";
        //        body += "Astro Envision</p>";
        //        //body += "<br/><a href=\"" + ResolveUrl("" + WEBSITEDomain + "") + "\" target='_blank'><img src=\"cid:SignatureLogo.png\"></a>";

        //        result = cs.SendMailWithLogo(frommailid, EmailID, "", "", Subject, body, "Y");
        //        if (result == "SENT")
        //        {
        //            ScriptManager.RegisterClientScriptBlock(this, typeof(astrologer_details), "wq", "alert('Mail has been sent successfully.');", true);
        //            return;
        //        }
        //        else
        //        {
        //            ScriptManager.RegisterClientScriptBlock(this, typeof(astrologer_details), "wq", "alert('Mail has not been sent successfully. Try Again');", true);
        //            return;
        //        }
        //    }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
            ScriptManager.RegisterClientScriptBlock(this, typeof(astrologer_details), "wq", "alert('Failure sending mail. Try Again');", true);
            return;
        }
    }
    void bind_userdetails()
    {
        try
        {
            System.Threading.Thread.Sleep(5000);
            string srckkeyword = txtkeyword.Text.Trim();
            ds = obj_subs.AstGetCommon(srckkeyword, "", "", "GETASTROLOGERDETAILS");
            if (ds.Tables[0].Rows.Count > 0)
            {
                lbl_result.InnerHtml = "Search Found  <font size=\"3\" color=\"red\">" + ds.Tables[0].Rows.Count.ToString() + "</font> result(s).";
                grdviews.DataSource = ds;
                grdviews.DataBind();
            }
            else
            {
                lbl_result.InnerHtml = "Search Found  <font size=\"3\" color=\"red\">0</font> result(s).";
                ds = null;
                grdviews.DataSource = ds;
                grdviews.DataBind();
            }
            ds.Dispose();
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    protected void grdviews_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //NewEditIndex property used to determine the index of the row being edited. 
        grdviews.EditIndex = e.NewEditIndex;
        bind_userdetails();
    }
    protected void grdviews_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        DataSet dsd = new DataSet();
        Label lblemailidval = grdviews.Rows[e.RowIndex].FindControl("lblemailid") as Label;
        string deleteflag = "";
        dsd = obj_subs.AstDeleteCommon(lblemailidval.Text.Trim(), "", "", "", "DELETE_ASTROLOGER");
        if (dsd.Tables[0].Rows.Count > 0)
        {
            deleteflag = dsd.Tables[0].Rows[0]["outresult"].ToString();
        }
        dsd.Dispose();
        bind_userdetails();
    }
    protected void grdviews_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
        grdviews.EditIndex = -1;
        bind_userdetails();
    }
    protected void grdviews_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string resultval="";
        string Id = grdviews.DataKeys[e.RowIndex].Values["ID"].ToString();
        DropDownList drpvalidity = grdviews.Rows[e.RowIndex].FindControl("ddlvalidity") as DropDownList;
        DropDownList drpstatus = grdviews.Rows[e.RowIndex].FindControl("ddlstatus") as DropDownList;
        DropDownList ddlmailstatus = grdviews.Rows[e.RowIndex].FindControl("ddlmailstatus") as DropDownList;
        string Validity_Val = drpvalidity.SelectedValue;
        string Status_Val = drpstatus.SelectedValue;
        string MailStatus_Val = ddlmailstatus.SelectedValue;
        if (MailStatus_Val == "0")
        {
            MailStatus_Val = "F";
        }
        string Status_Flag = "";
        if (Validity_Val=="0")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(astrologer_details), "wq", "alert('Please select any validity!');", true);
            return;
        }
        if (Status_Val == "0")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(astrologer_details), "wq", "alert('Please select any status!');", true);
            return;
        }
        if (Validity_Val != "0" && Status_Val != "0")
        {
            if (Status_Val == "T")
            {
                Status_Flag = "1";
            }
            if (Status_Val == "F")
            {
                Status_Flag = "0";
            }
            ds = obj_subs.UpdateCommon("ID", Id, "UserEmailId", "UserType", "GroupId", "CartID", Status_Flag, Status_Val, Validity_Val, MailStatus_Val, "Value5", "UPDATE_ASTROLOGER_VALIDITY");
            if (ds.Tables[0].Rows.Count > 0)
            {
                resultval = ds.Tables[0].Rows[0]["outresult"].ToString();
                if (resultval == "Y" && Status_Val == "T")
                {
                    string body = "", fromemailid = "";
                    Label lblname = grdviews.Rows[e.RowIndex].FindControl("lblname") as Label;
                    Label lblemailid = grdviews.Rows[e.RowIndex].FindControl("lblemailid") as Label;
                    string Subject = "Free Trial – Horary Software Registration – Successful";  //Activated
                    DataSet dsc = new DataSet();
                    dsc = cs.Get_Configuration("Registration", "SUPPORT");
                    if (dsc.Tables[0].Rows.Count > 0)
                    {
                        fromemailid = dsc.Tables[0].Rows[0]["EMAILID"].ToString();
                    }
                    dsc.Dispose();

                    body = "<p>Dear " + lblname.Text + ",</p>";
                    body += "<p>We are happy to inform you that your Login Id and Password registered with Astroenvision has been activated for access to Horary Module.</p>";
                    body += "<p>We shall be thankful for sending us the feedback so that we can serve you well.</p>";
                    body += "<p>Enjoy..using Astro Horary (Tajik – Prashna) Module</p>";
                    body += "<p>Thanks & Regards<br/>";
                    body += "Your Sincerely</p>";
                    body += "<p>Hari Sharma<br/>";
                    body += "For Astro Envision<br/>";
                    body += "support@astroenvision.com<br/>";
                    body += "+91-9958883955<br/>+91-9555600111</p>";

                    result = cs.SendMailWithLogo(fromemailid, lblemailid.Text.Trim(), "", "chdeepaknirwal10@gmail.com", Subject, body, "Y");

                }
            }
            ds.Dispose();
        }

        //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
        grdviews.EditIndex = -1;
        //Call ShowData method for displaying updated data  
        bind_userdetails();

        if (result == "SENT")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(astrologer_details), "wq", "alert('Mail has been sent successfully.');", true);
            return;
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(astrologer_details), "wq", "alert('Failure sending mail. Try Again');", true);
            return;
        }

        //if (result=="Y")
        //{
        //    ScriptManager.RegisterClientScriptBlock(this, typeof(astrologer_details), "wq", "alert('User details updated successfully!');", true);
        //    return;
        //}
    }  
    protected void grdviews_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            grdviews.PageIndex = e.NewPageIndex;
            bind_userdetails();
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    protected void grdviews_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            DataRowView drv = e.Row.DataItem as DataRowView;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                  Label lblstatus = (Label)e.Row.FindControl("lblstatus");
                  Label lblmailstatus = (Label)e.Row.FindControl("lblmailstatus");
                  if (lblstatus.Text == "T")
                  {
                      lblstatus.Text = "Active";
                  }
                  else
                  {
                      lblstatus.Text = "Inactive";
                  }
                  if (lblmailstatus.Text == "T")
                  {
                      lblmailstatus.Text = "Active";
                  }
                  else
                  {
                      lblmailstatus.Text = "Inactive";
                  }
            }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
}
