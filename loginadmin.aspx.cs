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
using System.Data.SqlClient;
using ASTROLOGY.classesoracle;

public partial class loginadmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnsignin_Click(object sender, EventArgs e)
    {
        string username = txtusername1.Text.ToString().Trim();
        string userpwd = txtpwd1.Text.ToString().Trim();
        if (username != "" && userpwd != "")
        {
            if ((username == "ASTROLOGY" || username == "astrology") && (userpwd == "ASTROLOGY" || userpwd == "astrology"))
            {
                Session["adminuseremail"] = username;
                Response.Redirect("Default.aspx");
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(loginadmin), "js", "alert('Invalid UserName or Password! Try Again !');", true);
                return;
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(loginadmin), "js", "alert('Please Enter Username / Password.');", true);
            return;
        }
    }
}
