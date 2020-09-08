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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.Text;
using System.Net;


public partial class thankyouccavenue : System.Web.UI.Page
{
    public string WEBSITEDomain = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    public string Ccavenue_chkAuthDesc = ConfigurationManager.AppSettings["Ccavenue_chkAuthDesc"].ToString();
    public string Ccavenue_PaymentStatus = ConfigurationManager.AppSettings["Ccavenue_PaymentStatus"].ToString();
    ASTROLOGY.classesoracle.main obj_main = new ASTROLOGY.classesoracle.main();
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    ASTROLOGY.classesoracle.myaccount objmc = new ASTROLOGY.classesoracle.myaccount();
    DataSet ds = new DataSet();
    string paymentstatus = "F", GroupId="";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string chkAuthDesc = Convert.ToString(Request.Form["AuthDesc"]);
            string mem_id = Convert.ToString(Request.Form["Order_Id"]);
            string price = Convert.ToString(Request.Form["Amount"]);
            if (chkAuthDesc == Ccavenue_chkAuthDesc) // Y //N
            {
                if (mem_id.IndexOf("ASTROLOGER") > -1)
                {
                    string[] mem_idsplit = mem_id.Split('-');
                    if (mem_idsplit.Length > 0)
                    {
                        string MemID = mem_idsplit[0];
                        DataSet dsp = new DataSet();
                        dsp = obj_subs.UpdatePaymentStatus("", MemID, "", "UPDATE_ASTROLOGER_SUBS");
                        if (dsp.Tables[0].Rows.Count > 0)
                        {
                            paymentstatus = dsp.Tables[0].Rows[0]["PAYMENT_STATUS"].ToString();
                            if (paymentstatus == Ccavenue_PaymentStatus) // T //F
                            {
                                Response.Redirect(WEBSITEDomain);
                            }
                        }
                        dsp.Dispose();
                    }
                }
                else
                {
                    paymentstatus = Update_PaymentStatus(mem_id);
                    if (paymentstatus == Ccavenue_PaymentStatus) // T //F
                    {
                        DataSet ds = new DataSet();
                        ds = obj_subs.AstGetCommon(Session["UserEmailID"].ToString(), "", "", "GETCLIENTINFO");
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            paymentstatus = Update_PaymentStatus(mem_id);
                            string UAccess = ds.Tables[0].Rows[0]["USER_ACCESS"].ToString();
                            string UID = ds.Tables[0].Rows[0]["ID"].ToString();
                            string UEmailID = ds.Tables[0].Rows[0]["EMAILID"].ToString();
                            if (UAccess == "FREE" && paymentstatus == Ccavenue_PaymentStatus)
                            {
                                //Response.Redirect(ResolveUrl("~/addtocart.aspx?groupid=" + ViewState["GroupId"].ToString().Trim() + "&cartid=" + mem_id + ""));
                                Response.Redirect(ResolveUrl("~/thankyou_ccavenue.aspx?cartid=" + mem_id.Trim() + "&clientid=" + UID + "&clientemailid=" + UEmailID + "&group="+ ViewState["GroupId"].ToString().Trim() + ""));
                            }
                            else
                            {
                                resultid.InnerHtml = "Your transaction is failed !";
                            }
                        }
                        ds.Dispose();

                        //Response.Redirect(ResolveUrl("~/addtocart.aspx?groupid=" + ViewState["GroupId"].ToString().Trim() + "&cartid=" + mem_id + ""));
                    }
                }
            }
            if (chkAuthDesc == "N" || chkAuthDesc == null)
            {
                if (Session["UserEmailID"] != null)
                {
                    DataSet ds = new DataSet();
                    ds = obj_subs.AstGetCommon(Session["UserEmailID"].ToString(), "", "", "GETCLIENTINFO");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        paymentstatus = Update_PaymentStatus(mem_id);
                        string UAccess = ds.Tables[0].Rows[0]["USER_ACCESS"].ToString();
                        string UID = ds.Tables[0].Rows[0]["ID"].ToString();
                        string UEmailID = ds.Tables[0].Rows[0]["EMAILID"].ToString();
                        if (UAccess == "FREE" && paymentstatus == Ccavenue_PaymentStatus)
                        {
                            //Response.Redirect(ResolveUrl("~/addtocart.aspx?groupid=" + ViewState["GroupId"].ToString().Trim() + "&cartid=" + mem_id + ""));
                            Response.Redirect(ResolveUrl("~/thankyou_ccavenue.aspx?cartid =" + mem_id.Trim() + "&clientid=" + UID + "&clientemailid=" + UEmailID + "&group=" + ViewState["GroupId"].ToString().Trim() + ""));
                        }
                        else
                        {
                            resultid.InnerHtml = "Your transaction is failed !";
                        }
                    }
                    ds.Dispose();
                }
                else
                {
                    resultid.InnerHtml = "Your transaction is failed !";
                }
                
            }
        }
    }

    public string Update_PaymentStatus(string cartidval)
    {
        try
        {
            string paymentactive = "F";
            ds = obj_subs.UpdatePaymentStatus(cartidval, "", "", "UPDATEBILLINGSTATUS");
            if (ds.Tables[0].Rows.Count > 0)
            {
                paymentactive = ds.Tables[0].Rows[0]["PAYMENT_STATUS"].ToString();
                GroupId = ds.Tables[0].Rows[0]["GROUP_ID"].ToString();
                ViewState["GroupId"] = GroupId;
            }
            else
            {
                paymentactive = "F";
            }
            ds.Dispose();
            return paymentactive;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
