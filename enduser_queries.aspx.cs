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

public partial class enduser_queries : System.Web.UI.Page
{
    public string WEBSITEDomain = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    public string SMTPServer = ConfigurationManager.AppSettings["SMTPServer"].ToString();
    ASTROLOGY.classesoracle.main obj_main = new ASTROLOGY.classesoracle.main();
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    ASTROLOGY.classesoracle.myaccount objmc = new ASTROLOGY.classesoracle.myaccount();
    common obj_comm = new common();
    string cartidval = "", emailid = "", clientid = "", groupval = "", clientname = "", Gender = "";
    bool MAILSENTTOUSER = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["cartid"] != null && Request.QueryString["cartid"] != null)
            {
                cartidval = Request.QueryString["cartid"].ToString().Trim();
                emailid = Request.QueryString["clientemailid"].ToString().Trim();
                clientid = Request.QueryString["clientid"].ToString().Trim();
                groupval = Request.QueryString["group"].ToString().Trim();
                ViewState["emailid"] = emailid;
                ViewState["cartidval"] = cartidval;
                ViewState["clientid"] = clientid;
                ViewState["groupval"] = groupval;
                ViewState["MAILSENTTOUSERVAL"] = "F";
                Show_QuestionAnswers(cartidval, clientid, emailid, groupval);
            }
        }
    }

    void Show_QuestionAnswers(string cartidval, string clientid, string emailid, string groupval)
    {
        DataSet dsd = new DataSet();
        dsd = objmc.Get_Clientdetails(emailid, clientid);
        if (dsd.Tables[0].Rows.Count > 0)
        {
            clientname = dsd.Tables[0].Rows[0]["CLIENT_NAME"].ToString();
            Gender = dsd.Tables[0].Rows[0]["GENDER"].ToString();
        }
        dsd.Dispose();
        DataSet dsa = new DataSet();
        dsa = obj_subs.UpdatePaymentStatus(cartidval, emailid, groupval, "GETQUESTIONS_WITHOUTANSWERS");
        if (dsa.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < dsa.Tables[0].Rows.Count; i++)
            {
                string CATNAME = dsa.Tables[0].Rows[i]["CATNAME"].ToString();
                string CATNAME_PRE = "";
                if (i > 0)
                {
                    CATNAME_PRE = dsa.Tables[0].Rows[i - 1]["CATNAME"].ToString();
                }
                if (CATNAME != CATNAME_PRE)
                {
                    if (i == 0)
                    {
                        outputdetailsid.InnerHtml += "<h1>- " + CATNAME + "</h1>";
                    }
                    else
                    {
                        outputdetailsid.InnerHtml += "<h1>- " + CATNAME + "</h1>";
                    }
                }

                string QUESTION = dsa.Tables[0].Rows[i]["QUESTION"].ToString();
                string QUESTIONID = dsa.Tables[0].Rows[i]["QUESTIONID"].ToString();
                string GROUP_ID = dsa.Tables[0].Rows[i]["GROUP_ID"].ToString();
                string ANSWER = dsa.Tables[0].Rows[i]["ANSWER"].ToString();
                string ANSWER_MANUAL = dsa.Tables[0].Rows[i]["ANSWER_MANUAL"].ToString();
                string MailSentToUser = dsa.Tables[0].Rows[i]["MAIL_SENT_TOUSER"].ToString();
                if (MailSentToUser == "T" && ANSWER_MANUAL!="")
                {
                    MAILSENTTOUSER = true;
                    ViewState["MAILSENTTOUSERVAL"] = "T";
                    rtesentnaswer.Value = ANSWER_MANUAL;
                }
                outputdetailsid.InnerHtml += "<h2>" + QUESTION + "</h2>";

                string[] ANSWERSplitAll = ANSWER.Split('$');
                string[] ANSWERSplit = ANSWERSplitAll.Distinct().ToArray();
                if (ANSWERSplit.Length > 0)
                {
                    for (int j = 0; j < ANSWERSplit.Length; j++)
                    {
                        string a = "", anext = "";
                        a = ANSWERSplit[j];
                        a = a.Replace("\n", "");
                        a = Regex.Replace(a, "<.*?>", String.Empty);
                        if (j == ANSWERSplit.Length - 1)
                        {
                            a = ANSWERSplit[j];
                            a = a.Replace("\n", "");
                        }
                        else
                        {
                            anext = ANSWERSplit[j + 1];
                            anext = anext.Replace("\n", "");
                            anext = Regex.Replace(anext, "<.*?>", String.Empty);
                        }
                        if (a != anext)
                        {
                            outputdetailsid.InnerHtml += "<h3>" + a + "</h3>";
                        }
                    }
                }
            }

            string bodymatter = "";
            if (Gender == "M")
            {
                bodymatter = "<b>Dear Mr. " + clientname + ",</b>";
            }
            else
            {
                bodymatter = "<b>Dear Ms. " + clientname + ",</b>";
            }
            bodymatter += "<br /><br />";
            bodymatter += "Thanks a lot for your patience, below are the answers for your unattended questions.";
            bodymatter += outputdetailsid.InnerHtml;
            bodymatter += "<br /><br />Please feel free to seek any personalised questions, beyond the scope of Online services provided…Click <a target='_blank' href=\"" + ResolveUrl("" + WEBSITEDomain + "/addtoconsult.aspx") + "\">“<b>Consult an Astrologer</b>”</a>";
            bodymatter += "<br /><br />You may please recommend us if you are satisfied with our Astro Services.";
            bodymatter += "<br /><br />Thanks  & Regards";
            bodymatter += "<br /><br />Consultant Astrologer";
            bodymatter += "<br />Hari Sharma";
            bodymatter += "<br />(Team Astroenvision)";
            rtedetails.Value = bodymatter;
        }
        dsa.Dispose();
    }

    protected void sendtouser_Click(object sender, EventArgs e)
    {
        try
        {
            if (ViewState["MAILSENTTOUSERVAL"].ToString() == "F")
            {
                string Frommailid = "support@astroenvision.com";
                string body = rtedetails.Value;
                string result = obj_comm.SendMail(Frommailid, ViewState["emailid"].ToString(), "deepaknirwal11@gmail.com", "", "Astroenvision:  Predictive answers  for your unattended questions", body);
                if (result == "SENT") //FAILED  //SENT
                {
                    DataSet dsua = new DataSet();
                    dsua = obj_subs.UpdateCommon("", "", ViewState["emailid"].ToString(), "", ViewState["groupval"].ToString(), ViewState["cartidval"].ToString(), rtedetails.Value, "", "", "", "", "UPDATE_ANSWERTYPE");
                    if (dsua.Tables[0].Rows.Count > 0)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(enduser_queries), "wq", "alert('E-mail has been sent successfully!');", true);
                        return;
                    }
                    dsua.Dispose();
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(enduser_queries), "wq", "alert('E-mail has not been sent! Try again');", true);
                    return;
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(enduser_queries), "wq", "alert('You have sent answer manually to user');", true);
                return;
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

}
