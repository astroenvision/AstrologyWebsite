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

public partial class usercontrol_headernew : System.Web.UI.UserControl
{
    public string WEBSITEDomain = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    string strmenuhtml = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        bindmenubar();
    }

    void bindmenubar()
    {
        strmenuhtml = "<li><a href=\"" + ResolveUrl("" + WEBSITEDomain + "") + "\">Home</a></li>";
        strmenuhtml += "<li><a href=\"" + ResolveUrl("~/article/article.aspx?catid=10&articleid=34") + "\">Services</a></li>";
        strmenuhtml += "<li><a href=\"" + ResolveUrl("~/article/article/details.aspx?catid=20&articleid=40") + "\">Consult an Astrologer</a></li>";
        strmenuhtml += "<li><a href=\"" + ResolveUrl("~/article/article.aspx?catid=7&articleid=32") + "\">About Us</a></li>";
        strmenuhtml += "<li><a href=\"" + ResolveUrl("~/feedback.aspx") + "\">Feedback</a></li>";
        strmenuhtml += "<li><a href=\"" + ResolveUrl("~/article/article.aspx?catid=8&articleid=33") + "\">FAQs</a></li>";
        //strmenuhtml += "<li><a href=\"" + ResolveUrl("~/your_queries.aspx") + "\">Your Queries</a></li>";
        menubarid.InnerHtml = strmenuhtml;
    }
}
