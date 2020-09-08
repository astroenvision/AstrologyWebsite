using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;

public partial class ChangePassword : System.Web.UI.Page
{
    #region Declaration
    ASTROLOGY.classesoracle.main obj_main = new ASTROLOGY.classesoracle.main();
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    #endregion

    #region PageLoad
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    #endregion

    #region Change Password
    protected void btnChangePwd_Click(object sender, EventArgs e)
    {
        if (Session["UserEmailID"] != null)
        {
            DataSet ds = new DataSet();
            if (txtNewpwd.Text == txtConfrimPwd.Text)
            {
                ds = obj_subs.ChangeUserPassword("CHANGE_USER_PASSWORD", Session["UserEmailID"].ToString(), txtOldPwd.Text.Trim(), txtNewpwd.Text.Trim());
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0]["Status"].ToString() == "1")
                    {
                        HttpContext.Current.Session["UserID"] = null;
                        HttpContext.Current.Session["UserEmailID"] = null;
                        HttpContext.Current.Session["UserName"] = null;
                      
                        string msg = "Your password change successfully !";
                        var page = HttpContext.Current.CurrentHandler as Page;
                        ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + msg + "');window.location ='" + "index.html" + "';", true);
                        return;
                    }
                    else
                    {
                        txtOldPwd.Text = "";
                        txtNewpwd.Text = "";
                        txtConfrimPwd.Text = "";
                        txtOldPwd.Focus();
                        ScriptManager.RegisterClientScriptBlock(this, typeof(ChangePassword), "wq", "alert('Old Password Does Not Match!');", true);
                        return;
                    }
                }
                else
                {
                    txtOldPwd.Text = "";
                    txtNewpwd.Text = "";
                    txtConfrimPwd.Text = "";
                    txtOldPwd.Focus();
                    ScriptManager.RegisterClientScriptBlock(this, typeof(ChangePassword), "wq", "alert('Warning! Some Error Occurred!');", true);
                    return;
                }
            }
            else
            {
                txtOldPwd.Text = "";
                txtNewpwd.Text = "";
                txtConfrimPwd.Text = "";
                txtOldPwd.Focus();
                ScriptManager.RegisterClientScriptBlock(this, typeof(ChangePassword), "wq", "alert('Password and confirm password does not match!');", true);
                return;
            }
        }
    }
    #endregion
}