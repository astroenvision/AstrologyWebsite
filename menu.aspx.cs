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

public partial class menu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //string id = TreeView1.SelectedNode.Value;
        if (!Page.IsPostBack)
        {
         
            //TreeView1.Attributes.Add("onclick", "javascript:return getnode(this.value)");
        }

        

        
    }

    //protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    //{
    //    //Response.Write(e.Item.Value);
    //    string i = e.Item.Value;
    //    string j = i + ".aspx";

    //   Response.Redirect(j);
    // //  string popupScript = "<script language="'javascript'">"+ "window.open('j')"+" </script>";
    // //   Page.ClientScript.RegisterStartupScript(GetType(), "PopupScript", popupScript);

    //}
    protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
    {
        string i = TreeView1.SelectedNode.Value;
        if (i == "ASTROLOGY")
        {
            
                TreeView1.ExpandAll();
           
           
               // TreeView1.CollapseAll();
            return;
        }
        string j = i + ".aspx";
        Response.Redirect(j);
    }
}
