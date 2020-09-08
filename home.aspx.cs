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

public partial class home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {


            Ajax.Utility.RegisterTypeForAjax(typeof(home));




            Button1.Attributes.Add("onclick", "javascript:return combinationentry();");
            Button2.Attributes.Add("onclick", "javascript:return houseposition();");
            Button3.Attributes.Add("onclick", "javascript:return encyclopaedia();");
            Button4.Attributes.Add("onclick", "javascript:return planetaspect();");
            Button5.Attributes.Add("onclick", "javascript:return planetfromplanet();");
            Button6.Attributes.Add("onclick", "javascript:return astrodegree();");
            Button7.Attributes.Add("onclick", "javascript:return predictivecategery();");
            Button8.Attributes.Add("onclick", "javascript:return astroextentions();");
        }
    }
    
}
