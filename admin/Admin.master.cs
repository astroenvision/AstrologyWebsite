using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Admin : System.Web.UI.MasterPage
{
    #region Declarations
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            //Page.ClientScript.RegisterStartupScript(Type.GetType("System.String"), "addScript", "startTimer(1,2)", true);
            if (AdminStateManagement == "COOKIE")
            {
                if (Request.Cookies["AdminCookies"] != null)
                {
                    DateTime end = Convert.ToDateTime(Request.Cookies["AdminCookies"]["CookiesExpirationTime"]);
                    DateTime now = DateTime.Now;
                    HdnCookieStart.Value = now.ToString();
                    HdnCookieEnd.Value = end.ToString();
                    //lefttime.InnerText = (end - now).TotalMinutes.ToString(); 

                    HdnCookieTimeoutType.Value = AdminCookieTimeoutType;
                    HdnCookieTimeout.Value = AdminCookieTimeout;
                    SpnUserName.InnerText = Request.Cookies["AdminCookies"]["AdminName"].ToString();
                    SpnUserNameText.InnerText = Request.Cookies["AdminCookies"]["AdminName"].ToString();
                    if (Request.Cookies["AdminCookies"]["IsAdmin"].ToString() != null)
                    {
                        string IsAdmin = Request.Cookies["AdminCookies"]["IsAdmin"].ToString();
                        if (IsAdmin != "1")
                        {
                            divAstrologerDtls.Visible = true;
                            divAdminSection.Visible = false;
                        }
                        else
                        {
                            divAdminSection.Visible = true;
                            divAstrologerDtls.Visible = false;
                        }
                    }
                }
                else
                {
                    Response.Redirect(ResolveUrl("~/admin"));
                }
            }
            else
            {
                if (Session["UserEmailId"] != null)
                {
                    SpnUserName.InnerText = Session["UserEmailId"].ToString();
                    SpnUserNameText.InnerText = Session["UserEmailId"].ToString();
                }
                else
                {
                    Response.Redirect(ResolveUrl("~/admin"));
                }
               
            }
        }
    }
    #endregion
}
