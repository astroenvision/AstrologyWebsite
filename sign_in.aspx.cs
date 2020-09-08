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

public partial class sign_in : System.Web.UI.Page
{
    common cs_obj = new common();
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    public string WEBSITEDomain = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnsignin_Click(object sender, EventArgs e)
    {
        try
        {
            DataSet ds1 = new DataSet();
            string mail = txtusername1.Text.ToString();
            string pass = txtpwd1.Text.ToString();
            //ds1 = cs_obj.search_astro(mail, pass);
            ds1 = cs_obj.CheckLogin(mail, pass, "", "");
            if (ds1.Tables[0].Rows.Count != 0)
            {
                string UserType = ds1.Tables[0].Rows[0]["USER_TYPE"].ToString().Trim();
                string UserActive = ds1.Tables[0].Rows[0]["ACTIVE"].ToString().Trim();
                string pwd = ds1.Tables[0].Rows[0]["PASSWORD"].ToString().Trim();
                string usermail = ds1.Tables[0].Rows[0]["MAINMAIL"].ToString().Trim();
                string username = ds1.Tables[0].Rows[0]["NAME"].ToString().Trim();
                if (UserType == "1" && UserActive == "T")
                {
                    if (pwd == pass)
                    {
                        Session["usermail"] = mail;
                        usermail = mail;
                        Response.Redirect("myaccount.aspx?usermail=" + usermail);
                        //loginid.InnerText = "Welcome: " + username + "";
                        //logoutid.InnerHtml = "<a onclick=\"javascript:loginoutenduser();\">Log Out</a>";
                        //middleloginid.Style.Add("display", "none");
                        //Session["endusermail"] = mail;
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(sign_in), "wq", "alert('Your Password is Incorrect !');", true);
                    }
                }
                else if (UserActive == "F")
                {
                    Response.Redirect("astro_registration_reactivation.aspx?UserID=" + usermail + "&Flag=D");
                }
            }
            else if (ds1.Tables[0].Rows.Count == 0)
            {
                DataSet dscl = new DataSet();
                dscl = obj_subs.CheckLoginEndUser(mail, pass, "", "", "CHECKENDUSERLOGIN");
                if (dscl.Tables[0].Rows.Count > 0)
                {
                    string flag = dscl.Tables[0].Rows[0]["flag"].ToString().Trim();
                    if (flag == "YES")
                    {
                        string emailval = dscl.Tables[1].Rows[0]["EMAILID"].ToString().Trim();
                        //loginid.InnerText = "" + username + "";
                        ////logoutid.InnerHtml = "<a onclick=\"javascript:loginoutenduser();\">Log Out</a>";
                        //logoutid.InnerHtml = "";
                        //middleloginid.Style.Add("display", "none");
                        Session["usermail"] = emailval;
                        Session["endusermail"] = emailval;
                        Response.Redirect("login.aspx");
                    }
                    if (flag == "NO")
                    {
                        string flag2 = dscl.Tables[1].Rows[0]["flag"].ToString().Trim();
                        if (flag2 == "NOT REGISTERED")
                        {
                            ScriptManager.RegisterClientScriptBlock(this, typeof(sign_in), "wq", "alert('Your email address is not registered!');", true);
                            return;
                        }
                        if (flag2 == "INVALID PASSOWRD")
                        {
                            ScriptManager.RegisterClientScriptBlock(this, typeof(sign_in), "wq", "alert('Your password is invalid please try again!');", true);
                            return;
                        }
                    }
                }
                dscl.Dispose();
            }
            else if (ds1.Tables[1].Rows.Count == 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(sign_in), "wq", "alert('Your Password is Incorrect !');", true);
            }
            else
            {
                Response.Redirect("astro_registration_reactivation.aspx?UserID=" + mail + "&Flag=NR");
            }
            ds1.Dispose();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
