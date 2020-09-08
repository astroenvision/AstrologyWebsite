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

public partial class FeedBack : System.Web.UI.Page
{

    #region Declarartions
    common cs = new common();
    subscription sub = new subscription();
    public string SMTPServer = ConfigurationManager.AppSettings["SMTPServer"].ToString();
    static string PrevPage = String.Empty;
    #endregion

    #region PageLoad
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //PrevPage = Request.UrlReferrer.ToString();
            Page.Title = "Feedback" + " | Astro Envision";
            string Domainurl = Request.Url.Scheme + System.Uri.SchemeDelimiter + Request.Url.Host;
            string url = Domainurl + HttpContext.Current.Request.RawUrl;
            HtmlLink tag = new HtmlLink();
            tag.Attributes.Add("rel", "canonical");
            tag.Href = url;
            //Header.Controls.Add(tag);  // This Line is used without Master Page
            Master.FindControl("head").Controls.Add(tag); // This Line is used with Master Page
        }
    }
    #endregion

    #region Submit Click
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        try
        {
            string name = txtName.Text.ToString();
            string email = txtEmail.Text.ToString();
            string phoneno = txtContcatNo.Text.ToString();
           string message = txtMessage.Text.ToString();

            DataSet ds = sub.SaveFeedBack("SAVE_FEEDBACK", name, email, phoneno, message, "NATAL");
            if(ds.Tables[0].Rows.Count > 0)
            {
                if(ds.Tables[0].Rows[0]["STATUS"].ToString() == "1")
                {
                    common.ClearAllControls(Page.Controls);
                    ScriptManager.RegisterStartupScript(this, typeof(FeedBack), "str", "<script language='javascript'>alert('Your Valuable Feedback Received Successfully!');</script>", false);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(FeedBack), "str", "<script language='javascript'>alert('Your Valuable Feedback Not Received Successfully!');</script>", false);
                }
            }

            //DataSet dsc = new DataSet();
            //string Tomailid = "";
            //dsc = cs.Get_Configuration("Feedback", "FEEDBACK");
            //if (dsc.Tables[0].Rows.Count > 0)
            //{
            //    Tomailid = dsc.Tables[0].Rows[0]["EMAILID"].ToString();
            //}
            //dsc.Dispose();

            //string bodyinfo = informaition(name, email, company, phoneno, feed_type, message, country);

            //string result = "";
            //string dateval = DateTime.Now.ToString("dd-MMM-yyyy");
            //string timeval = DateTime.Now.ToString("hh:mm:ss tt");
            //string dayval = DateTime.Now.DayOfWeek.ToString();
            //string datetimeday = dateval + " , " + timeval + " , " + dayval;
            //result = cs.SendMail(email, Tomailid, "deepaknirwal11@gmail.com", "", "Astro Envision Feedback:- " + name + " - " + datetimeday, bodyinfo);
            //if (result == "SENT") //FAILED  // SENT
            //{
            //    txtName.Text = "";
            //    txtEmail.Text = "";
            //    txtContcatNo.Text = "";
            //    txtMessage.Text = "";
            //    ScriptManager.RegisterStartupScript(this, typeof(FeedBack), "str", "<script language='javascript'>alert('Your Valuable Feedback Received Successfully!');</script>", false);
            //}
            //else
            //{
            //    ScriptManager.RegisterStartupScript(this, typeof(FeedBack), "str", "<script language='javascript'>alert('Your Valuable Feedback Not Received Successfully!');</script>", false);
            //}

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion

    #region Information
    public string informaition(string name, string email, string company, string phoneno, string feed_type, string message, string country)
    {
        string info = "";
        info += "<table width=\"700\" style=\"font-family:Verdana;font-size:13px\" border=\"0\" align=\"center\" cellpadding=\"4\" cellspacing=\"0\">";
        //info += "<tr><td colspan=\"2\"><strong>Customer Details</strong></td></tr>";
        info += "<tr><td width=\"128\"><strong>Name  :</strong></td><td width=\"550\">" + name + " </td></tr>";
        info += "<tr><td width=\"128\"><strong>Email :</strong></td><td width=\"550\">" + email + " </td></tr>";
        //info += "<tr><td width=\"128\"><strong>Company     :</strong></td><td width=\"550\">" + company + " </td></tr>";
        info += "<tr><td width=\"128\"><strong>Phone     :</strong></td><td width=\"550\">" + phoneno + " </td></tr>";
        //info += "<tr><td width=\"128\"><strong>Country    :</strong></td><td width=\"550\">" + country + " </td></tr>";
        //info += "<tr><td width=\"128\"><strong>Feedback Type    :</strong></td><td width=\"550\">" + feed_type + " </td></tr>";
        info += "<tr><td width=\"128\"><strong>Message  :</strong></td><td width=\"550\">" + message + " </td></tr>";
        info += "</table>";
        return info;
    }

    #endregion

}