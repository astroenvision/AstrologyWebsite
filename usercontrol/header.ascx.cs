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

public partial class usercontrol_header : System.Web.UI.UserControl
{
    public string WEBSITEDomain = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    ASTROLOGY.classesoracle.main obj_main = new ASTROLOGY.classesoracle.main();
    string strmenuhtml = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["myquery"] != null)
        {
            string[] myqueryparts = Session["myquery"].ToString().Trim().Split('$');
            if (myqueryparts.Length > 0)
            {
                //myqueryid.InnerHtml = "<a href=\"" + ResolveUrl("~/addtocart.aspx" + myqueryparts[0] + "") + "\"> My Query (" + myqueryparts[1] + ")</a>";
                //myqueryid.InnerHtml = "<a href=\"" + ResolveUrl("~/article/finalquestions.aspx" + myqueryparts[0] + "") + "\"> My Query (" + myqueryparts[1] + ")</a>";
                myqueryid.InnerHtml = "<a href=\"" + ResolveUrl("~/" + myqueryparts[0].Replace("astrology/", "") + "") + "\"> My Query (" + myqueryparts[1] + ")</a>";
                myqueryid.Visible = true;
            }
        }
        else
        {
            //myqueryid.InnerHtml = "My Query (0)";
            myqueryid.Visible = true;
        }

        if (Session["usermail"] != null)
        {
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
                signinsignup_id.InnerHtml = "<li><a href=\"" + ResolveUrl("~/myaccount.aspx?usermail=" + Session["usermail"].ToString() + "") + "\">My Account</a></li>";
            }
            else
            {
                if (Session["endusermail"] != null)
                {
                    dsu = obj_main.AstGetCommon(Session["endusermail"].ToString(), "UrseType", "GroupId", "GETCLIENTINFO");
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
                }
            }

            dsu.Dispose();
            //signinsignup_id.InnerHtml += "<li><a href=\"" + ResolveUrl("~/logout.aspx") + "\" style=\"cursor: pointer\">Logout</a></li>";
        }
        else
        {
            signinsignup_id.InnerHtml = "<li><a href=\"" + ResolveUrl("~/signin.html") + "\">Login</a></li>";
            signinsignup_id.InnerHtml += "<li><a href=\"" + ResolveUrl("~/registration.html") + "\">Create My Account</a></li>";
        }

        bindmenubar();
    }
    void bindmenubar()
    {
        logoid.InnerHtml = "<a href=\"" + ResolveUrl("" + WEBSITEDomain + "") + "\"><img src=\"" + ResolveUrl("~/Image/large_logo.svg") + "\" alt=\"Astro Envision\" title=\"Astro Envision\" /></a>";
        //    strmenuhtml = "<li><a href=\"" + ResolveUrl("" + WEBSITEDomain + "") + "\">Home</a></li>";
        //    strmenuhtml += "<li><a href=\"" + ResolveUrl("~/services.html") + "\">Services</a></li>";
        //    strmenuhtml += "<li><a href=\"" + ResolveUrl("~/consult-an-astrologer.html") + "\">Consult an Astrologer</a></li>";
        //    strmenuhtml += "<li><a href=\"" + ResolveUrl("~/aboutus.html") + "\">About Us</a></li>";
        //    strmenuhtml += "<li><a href=\"" + ResolveUrl("~/feedback.html") + "\">Feedback</a></li>";
        //    strmenuhtml += "<li><a href=\"" + ResolveUrl("~/faqs.html") + "\">FAQs</a></li>";
        //    //strmenuhtml += "<li><a href=\"" + ResolveUrl("~/your_queries.aspx") + "\">Your Queries</a></li>";
        //    menubarid.InnerHtml = strmenuhtml;
    }
}