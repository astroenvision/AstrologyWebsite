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

public partial class categery : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Ajax.Utility.RegisterTypeForAjax(typeof(categery));

            LinkButton1.Attributes.Add("onclick", "javascript:return link1();");
            LinkButton2.Attributes.Add("onclick", "javascript:return link2();");
        
        }
       
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {


    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {


    }
}
