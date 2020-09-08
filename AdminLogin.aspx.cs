using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminLogin : System.Web.UI.Page
{
    #region Declarations
    admin obj = new admin();
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
    }
    #endregion

    #region Signin Button Click
    protected void btnsignin_Click(object sender, EventArgs e)
    {
        string username = txtuserid.Text.ToString().Trim();
        string userpwd = txtpwd.Text.ToString().Trim();
        DataSet ds = new DataSet();
        ds = obj.CheckLoginDetails("CHECK_USER_PASSWORD", username, userpwd);
        if (ds.Tables[0].Rows.Count > 0)
        {
            if (ds.Tables[0].Rows[0]["FLAG"].ToString() == "YES")
            {
                if (AdminStateManagement == "COOKIE")
                {
                    HttpCookie AdminCookies = new HttpCookie("AdminCookies");
                    AdminCookies["AdminUserId"] = ds.Tables[1].Rows[0]["USER_ID"].ToString();
                    AdminCookies["AdminEmailId"] = ds.Tables[1].Rows[0]["EMAIL_ID"].ToString();
                    AdminCookies["AdminName"] = ds.Tables[1].Rows[0]["NAME"].ToString();
                    AdminCookies["IsAdmin"] = ds.Tables[1].Rows[0]["ISSUPERADMIN"].ToString();
                    if (AdminCookieTimeoutType == "MINUTES")
                    {
                        AdminCookies["CookiesExpirationTime"] = DateTime.Now.AddMinutes(Convert.ToInt32(AdminCookieTimeout)).ToString();
                        AdminCookies.Expires = DateTime.Now.AddMinutes(Convert.ToInt32(AdminCookieTimeout));
                    }
                    else if (AdminCookieTimeoutType == "HOURS")
                    {
                        AdminCookies["CookiesExpirationTime"] = DateTime.Now.AddHours(Convert.ToInt32(AdminCookieTimeout)).ToString();
                        AdminCookies.Expires = DateTime.Now.AddHours(Convert.ToInt32(AdminCookieTimeout));
                    }
                    else if (AdminCookieTimeoutType == "DAYS")
                    {
                        AdminCookies["CookiesExpirationTime"] = DateTime.Now.AddDays(Convert.ToInt32(AdminCookieTimeout)).ToString();
                        AdminCookies.Expires = DateTime.Now.AddDays(Convert.ToInt32(AdminCookieTimeout));
                    }
                    else
                    {
                        AdminCookies["CookiesExpirationTime"] = DateTime.Now.AddSeconds(Convert.ToInt32(AdminCookieTimeout)).ToString();
                        AdminCookies.Expires = DateTime.Now.AddSeconds(Convert.ToInt32(AdminCookieTimeout));
                    }
                    Response.Cookies.Add(AdminCookies);
                }
                else
                {
                    //Comment following lines On 22-07-2020
                    //Session["UserEmailId"] = ds.Tables[1].Rows[0]["NAME"].ToString();
                    //Session["IsAdmin"] = ds.Tables[1].Rows[0]["ISSUPERADMIN"].ToString();
                    //Session["UserID"] = ds.Tables[1].Rows[0]["USER_ID"].ToString();
                    Session["AdminUserId"] = ds.Tables[1].Rows[0]["USER_ID"].ToString();
                    Session["AdminEmailId"] = ds.Tables[1].Rows[0]["EMAIL_ID"].ToString();
                    Session["AdminName"] = ds.Tables[1].Rows[0]["NAME"].ToString();
                    Session["IsAdmin"] = ds.Tables[1].Rows[0]["ISSUPERADMIN"].ToString();
                }
                Response.Redirect("~/admin/Index.aspx");
            }
            else
            {
                if (ds.Tables[1].Rows[0]["FLAG"].ToString() == "INVALID PASSOWRD")
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(AdminLogin), "js", "alert('Invalid UserName or Password! Try Again !');", true);
                    return;
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(AdminLogin), "js", "alert('Not Register User!');", true);
                    return;
                }
            }
        }
    }
    #endregion
}