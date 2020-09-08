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

public partial class Leftbar : System.Web.UI.UserControl
{
    public string tree = "";

    public void Page_Load(object sender, EventArgs e)
    {


        DataSet ds = new DataSet();
        ds.ReadXml(Server.MapPath("ast.xml/release_no.xml"));
        lbrelease.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();

        //Ajax.Utility.RegisterTypeForAjax(typeof(EnterPage));
        //Ajax.Utility.RegisterTypeForAjax(typeof(ClientMaster));

        // Put user code to initialize the page here
        dynamictreeview();
    }




    public void dynamictreeview()
    {
   
    
    
    
    
    
    }

}
