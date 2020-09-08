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

public partial class usercontrol_header_astro : System.Web.UI.UserControl
{
    public string WEBSITEDomain = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    ASTROLOGY.classesoracle.main obj_main = new ASTROLOGY.classesoracle.main();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["endusermail"] != null)
        {
            bindmenubar();
        }
        else if (Session["usermail"] != null)
        {
            bindmenubar();
            DataSet dsu = new DataSet();
            dsu = obj_main.AstGetCommon(Session["usermail"].ToString(), "UrseType", "GroupId", "GETASTROLOGERINFO");
            if (dsu.Tables[0].Rows.Count > 0)
            {
                string UserNameVal = dsu.Tables[0].Rows[0]["NAME"].ToString().Trim();
                string genderval = dsu.Tables[0].Rows[0]["GENDER"].ToString().Trim().ToUpper();
                if (genderval == "MALE")
                {
                    welcomeBoxId.InnerHtml = "Welcome Mr. " + UserNameVal + "..";
                }
                else
                {
                    welcomeBoxId.InnerHtml = "Welcome Mrs. " + UserNameVal + "..";
                }
            }
            dsu.Dispose();
        }
        else
        {
            Response.Redirect(WEBSITEDomain);
        }

    }
    protected void lblogout_Click(object sender, EventArgs e)
    {
        Session["endusermail"] = null;
        Session["usermail"] = null;
        Session["myquery"] = null;
        Session.Clear();
        Session.Abandon();
        Response.Redirect("~/login.aspx");
    }

    void bindmenubar()
    {
        logoid.InnerHtml = "<a href=\"" + ResolveUrl("" + WEBSITEDomain + "") + "\"><img src=\"" + ResolveUrl("~/Image/large_logo.png") + "\" alt=\"Astro Envision\" title=\"Astro Envision\" /></a>";
    }
}
