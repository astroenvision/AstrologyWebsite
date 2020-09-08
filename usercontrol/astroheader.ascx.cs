using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class usercontrol_astroheader : System.Web.UI.UserControl
{
    string strmenu = "";
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["endusermail"] != null)
        //{
        //    strmenu += "<li><a href=\"#\"><i class=\"fa fa-shopping-cart cartfs\"></i></a></li>";
        //    strmenu += "<li class=\"menu-has-children\"><a href=\"#\">" + Session["name"] + "</a></li>";
        //    strmenu += "<li><a href=\"javascript:Logout();\">Logout</a></li>";
        //    //strmenu += "<li><a href=\"#\">Change Password</a></li>";
        //    //strmenu += "<li class=\"d-768-none\"><a href=\"signup.aspx\">Subscribe</a></li>";
        //    strmenu += "<li class=\"hdslinks\">";
        //    strmenu += "<a href=\"https://api.whatsapp.com/send?phone=91+9958883955\" target=\"_blank\"><img class=\"sicon\" src=\"img/whatsapp.png\"></a>";
        //    strmenu += "<a href='https://www.facebook.com/Astro-Envision-1702561730064187' target=\"_blank\"><img class=\"sicon\" src=\"img/facebook.png\"></a>";
        //    strmenu += "<a href='https://twitter.com/AstroEnvision' target=\"_blank\"><img class=\"sicon\" src=\"img/twitter.png\"></a>";
        //    strmenu += "</li>";
        //}
        //else
        //{
        //    strmenu += "<li><a href=\"#\"><i class=\"fa fa-shopping-cart cartfs\"></i></a></li>";
        //    strmenu += "<li class=\"d-768-none\"><a href=\"signin.aspx\">Login</a></li>";
        //    strmenu += "<li class=\"d-768-none\"><a href=\"signup.aspx\">Subscribe</a></li>";
        //    strmenu += "<li class=\"hdslinks\">";
        //    strmenu += "<a href=\"https://api.whatsapp.com/send?phone=91+9958883955\" target=\"_blank\"><img class=\"sicon\" src=\"img/whatsapp.png\"></a>";
        //    strmenu += "<a href='https://www.facebook.com/Astro-Envision-1702561730064187' target=\"_blank\"><img class=\"sicon\" src=\"img/facebook.png\"></a>";
        //    strmenu += "<a href='https://twitter.com/AstroEnvision' target=\"_blank\"><img class=\"sicon\" src=\"img/twitter.png\"></a>";
        //    strmenu += "";
        //    strmenu += "";
        //    strmenu += "";
        //    strmenu += "</li>";
        //}
        //menurightid.InnerHtml = strmenu;
    }
    #region LogOut
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        ClsStateMangement.ReleaseUserLogin(Context);
        Response.Redirect("~/index.html");
    }
    #endregion

}