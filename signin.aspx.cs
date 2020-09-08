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


public partial class signin : System.Web.UI.Page
{
    #region Declarations
    common cs_obj = new common();
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    public string WEBSITEDomain = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    public string StateManagement = ConfigurationManager.AppSettings["StateManagement"].ToString();
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.UrlReferrer != null)
            {
                hdnPriviousURl.Value = Request.UrlReferrer.ToString();
            }
        }
    }
    #endregion

    #region Sign IN
    protected void btnsignin_Click(object sender, EventArgs e)
    {
        DataSet dscl = new DataSet();
        dscl = obj_subs.CheckLoginEndUser(txtuserid.Text, txtpwd.Text, "", "", "CHECKENDUSERLOGIN");
        if (dscl.Tables[0].Rows.Count > 0)
        {
            string flag = dscl.Tables[0].Rows[0]["flag"].ToString().Trim();
            if (flag == "YES")
            {
                string UserID = dscl.Tables[1].Rows[0]["ID"].ToString().Trim();
                Session["UserID"] = dscl.Tables[1].Rows[0]["ID"].ToString().Trim();
                string UserEmailID = dscl.Tables[1].Rows[0]["EMAILID"].ToString().Trim();
                string UserName = dscl.Tables[1].Rows[0]["NAME"].ToString().Trim();
                if (StateManagement== "COOKIE")
                {
                    ClsStateMangement.SetUserLogin(Context, UserID, UserEmailID, UserName, StateManagement);
                }
                else
                {
                    ClsStateMangement.SetUserLogin(Context, UserID, UserEmailID, UserName, StateManagement);
                }
                if (Session["CurrentPage"] != null)
                {
                    if (Session["CurrentPage"].ToString() == "ConsultToAstrologer")
                    {
                        Session["CurrentPage"] = null;
                        string SeriveType = Session["ServiceType"].ToString();
                        Response.Redirect("~/addtoconsult.aspx?servicetype=" + SeriveType + "");
                    }
                    else if (Session["CurrentPage"].ToString() == "FREE_ASK_ONE_QUESTION")
                    {
                        Session["CurrentPage"] = null;
                        Response.Redirect("~/ask-one-question-free.html");
                    }
                    else if (Session["CurrentPage"].ToString() == "FREE_ASK_ONE_QUESTION_ANS")
                    {
                        Session["CurrentPage"] = null;
                        Response.Redirect("~/ask-question-ans-free.html");
                    }
                    //else if (Session["CurrentPage"].ToString() == "TalkToAstrologer")
                    //{
                    //    DataSet ds = new DataSet();
                    //    string ID = Session["CurrentID"].ToString();
                    //    ds = obj_subs.ManagePayment("UpdateUserID", ID, "", UserID, UserEmailID, "", "", "", "", "", "", "", "", "",
                    //      "", "", "", "", "", "", "", "");
                    //    if (ds.Tables[0].Rows.Count > 0)
                    //    {
                    //        Response.Redirect("~/enterdetails.aspx?groupid=" + Request.QueryString["groupid"] + "&cartid=" + Session["MySessionID"].ToString() + "&Flag=TALK_TO_ASTROLOGER");
                    //    }
                    //}
                    else if (Session["CurrentPage"].ToString() == "FOR_PRODUCT")
                    {
                        Session["CurrentPage"] = null;
                        DataSet ds = new DataSet();
                        ds = obj_subs.AddBillingDetails("UpdateRegID", "", Session["MySessionID"].ToString(), "", "", "", "", "", "", "", "", UserID, UserEmailID, "" , Session["AddressID"].ToString());
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            Response.Redirect(ResolveUrl("~/auto_razorpay.aspx?member=" + Session["MySessionID"].ToString() + "&amount=" + Session["TotalValue"].ToString() + "&clientemailid=" + UserEmailID + "&group=NATAL&PaymentFor=FOR_PRODUCT"));
                        }
                    }
                    else if (Session["CurrentPage"].ToString() == "AstrologerComments")
                    {
                        Session["CurrentPage"] = null;
                        Response.Redirect(hdnPriviousURl.Value);
                    }
                }
                else if (Request.QueryString["groupid"] != null)
                {
                    Response.Redirect("~/enterdetails.aspx?groupid=" + Request.QueryString["groupid"] + "&cartid=" + Session["MySessionID"].ToString() + "");
                }
                else if (Request.QueryString["flag"] != null)
                {
                    if(Request.QueryString["flag"].ToString().Trim() == "compatibilitymatching")
                    {
                        Response.Redirect("compatibilitymatching.html");
                    }
                    if (Request.QueryString["flag"].ToString().Trim() == "free-horoscope")
                    {
                        Response.Redirect("free-horoscope.html");
                    }
                    if (Request.QueryString["flag"].ToString().Trim() == "free-kundli-matching")
                    {
                        Response.Redirect("free-kundli-matching.html");
                    }
                    if (Request.QueryString["flag"].ToString().Trim() == "the-most-important-planet-for-you")
                    {
                        Response.Redirect("single-most-important-planet-for-you.html");
                    }
                    if (Request.QueryString["flag"].ToString().Trim() == "two-most-important-planet-for-you")
                    {
                        Response.Redirect("two-most-important-planet-for-you.html");
                    }
                    if (Request.QueryString["flag"].ToString().Trim() == "three-most-important-planet-for-you")
                    {
                        Response.Redirect("three-most-important-planet-for-you.html");
                    }
                    if (Request.QueryString["flag"].ToString().Trim() == "TalkToAstrologer" || Request.QueryString["flag"].ToString().Trim() == "CONSULT_AN_ASTROLOGER" || Request.QueryString["flag"].ToString().Trim() == "PERSONAL_MEETING")
                    {
                        DataSet ds = new DataSet();
                        ds = obj_subs.ManagePayment("UpdateUserID", "", Session["MySessionID"].ToString(), UserID, UserEmailID, "", "", "", "", "", "", "", "", "",
                          "", "", "", "", "", "", "", "");
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            if(Request.QueryString["flag"].ToString().Trim() == "CONSULT_AN_ASTROLOGER")
                            {
                                Response.Redirect("~/enterdetails.aspx?groupid=NATAL&cartid=" + Session["MySessionID"].ToString() + "&Flag=CONSULT_AN_ASTROLOGER");
                            }
                            else if(Request.QueryString["flag"].ToString().Trim() == "TalkToAstrologer")
                            {
                                Response.Redirect("~/enterdetails.aspx?groupid=NATAL&cartid=" + Session["MySessionID"].ToString() + "&Flag=TalkToAstrologer");
                            }
                            else 
                            {
                                Response.Redirect("~/enterdetails.aspx?groupid=NATAL&cartid=" + Session["MySessionID"].ToString() + "&Flag=PERSONAL_MEETING");
                            }
                        }
                        ds.Dispose();
                    }
                }
                else
                {
                    Response.Redirect("index.html");
                }
             }
            if (flag == "NO")
            {
                string flag2 = dscl.Tables[1].Rows[0]["flag"].ToString().Trim();
                if (flag2 == "NOT REGISTERED")
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(signin), "wq", "alert('Your email address is not registered!');", true);
                    return;
                }
                if (flag2 == "INVALID PASSOWRD")
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(signin), "wq", "alert('Your password is invalid please try again!');", true);
                    return;
                }
            }
        }
        dscl.Dispose();
    }
   #endregion
}