using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Index : System.Web.UI.Page
{
    #region Declarations
    common common = new common();
    admin obj = new admin();
    string IsAdmin = "" , AdminUserId = "";
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            hhead.InnerHtml = "Current Month (" + DateTime.Now.ToString("MMMM") + "," + DateTime.Now.Year.ToString() + ")";
            hAstroHead.InnerHtml = "Current Month (" + DateTime.Now.ToString("MMMM") + "," + DateTime.Now.Year.ToString() + ")";

            if (AdminStateManagement == "COOKIE")
            {
                if (Request.Cookies["AdminCookies"] != null)
                {
                    IsAdmin = Request.Cookies["AdminCookies"]["IsAdmin"].ToString();
                    AdminUserId = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
                }
                else
                {
                    Response.Redirect(ResolveUrl("~/admin"));
                }
            }
            else
            {
                if (Session["IsAdmin"] != null)
                {
                    IsAdmin = Session["IsAdmin"].ToString();
                }
                else
                {
                    Response.Redirect(ResolveUrl("~/admin"));
                }
            }
            if (IsAdmin == "0" || IsAdmin == "")
            {
                divAdminBlock.Visible = false;
                divAdminData.Visible = false;
                divAstrologerData.Visible = true;
            }
            else
            {
                divAstrologerData.Visible = false;
                divAdminData.Visible = true;
                divAdminBlock.Visible = true;
                
            }
            BindDashBoardDetails();
        }
    }
    #endregion

    #region Bind DashBoard Details
    protected void BindDashBoardDetails()
    {
        DataSet ds = new DataSet();
        ds = common.GetDashboardDetails("GET_DASHBOARD_DETAILS");

        /*******************************For Admin**************************************/

        divFreeUser.InnerText = ds.Tables[0].Rows[0]["FREE_USER_MONTH"].ToString();
        divFreeMatchingUser.InnerText = ds.Tables[0].Rows[0]["FREE_MATCHING_USER_MONTH"].ToString();
        divPaidMatchingReport.InnerText = ds.Tables[0].Rows[0]["PAID_MATCHING_USER_MONTH"].ToString();
        divTotalPaidUser.InnerText = ds.Tables[0].Rows[0]["PAID_USER"].ToString();
        divTestimonials.InnerText = ds.Tables[0].Rows[0]["TESTIMONIAL_COUNT"].ToString();
        divTotalFeedBack.InnerText = ds.Tables[0].Rows[0]["FEEDBACK_COUNT"].ToString();
        divPaymentInINR.InnerText = ds.Tables[0].Rows[0]["TOTALINR_AMOUNT"].ToString();
        divTotalReguser.InnerText = ds.Tables[0].Rows[0]["REGISTERED_USER_MONTH"].ToString();
        divOverRallPayment.InnerText = ds.Tables[0].Rows[0]["OVERRALL_PAYMENT"].ToString();
        divOverallUser.InnerText = ds.Tables[0].Rows[0]["OVERRALL_PAID_USER"].ToString();
        divImportantPlanet.InnerText = ds.Tables[0].Rows[0]["OVERRALL_IMPORTANT_PLANET"].ToString();
        divTotalUser.InnerText = ds.Tables[0].Rows[0]["REGISTERED_USER"].ToString();
        divTotalFreeUser.InnerText = ds.Tables[0].Rows[0]["FREE_USER"].ToString();
        divTotalFreeMatching.InnerText = ds.Tables[0].Rows[0]["FREE_MATCHING_USER"].ToString();
        divTotalPaidMatching.InnerText = ds.Tables[0].Rows[0]["PAID_MATCHING_USER"].ToString();
        divOverRallFeedbackList.InnerText = ds.Tables[0].Rows[0]["OVERRALL_FEEDBACK_COUNT"].ToString();
        divTotalTestimonials.InnerText = ds.Tables[0].Rows[0]["OVERRALL_TESTIMONIAL_COUNT"].ToString();
        divCurrentImportantPlanet.InnerText = ds.Tables[0].Rows[0]["IMPORTANT_PLANET"].ToString();

        /*******************************For Astrologer**************************************/

        DataSet dsAstro = new DataSet();
        string AstrologerID = "";
        if (Request.Cookies["AdminCookies"]["IsAdmin"].ToString() != null)
        {
            if (Request.Cookies["AdminCookies"]["IsAdmin"].ToString() != "1")
            {
                AstrologerID = AdminUserId;
            }
        }
        dsAstro = obj.GetClientList("GET_CLIENT_LIST", "", "", "", AstrologerID);
        if (dsAstro.Tables[0].Rows.Count > 0)
        {
            divTotalClient.InnerText = dsAstro.Tables[0].Rows[0]["ASTROLOGER_CLIENT"].ToString();
            divOverrallClient.InnerText = dsAstro.Tables[0].Rows[0]["OVERRALL_ASTROLOGER_CLIENT"].ToString();
            divAstrologerClient.InnerText = dsAstro.Tables[0].Rows[0]["ASTROLOGER_CLIENT"].ToString();
            divAstroOverrallClient.InnerText = dsAstro.Tables[0].Rows[0]["OVERRALL_ASTROLOGER_CLIENT"].ToString();
        }
 }
    #endregion
}