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
using System.Data.OracleClient;
public partial class predictive_categery : System.Web.UI.Page
{
    string page = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(predictive_categery));
        if (!IsPostBack)
        {
            categery.Attributes.Add("onkeydown", "javascript:return fillcategery(event);");
            Button2.Attributes.Add("onclick", "javascript:return save();");
            lstcategery.Attributes.Add("onkeydown", "javascript:return closelist(event);");
        }
    
    }

    [Ajax.AjaxMethod]
  public DataSet fill_categery(string extra1)
    {
  DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.categery country = new ASTROLOGY.classesoracle.categery();
            ds = country.bind_categery( extra1);
        }
        //else if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "sql")
        //{
        //    Circulation.Classes.lebel_gen gen = new Circulation.Classes.lebel_gen();
        //    ds = gen.bindagency_code1(compcode, unit, dateformate, extra1, extra2);
        //}
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet bind_desc(string ss, string kk)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.categery country = new ASTROLOGY.classesoracle.categery();
            ds = country.bind_desc(ss, kk);
            //TextBox2.Visible = true;


        }

        return ds;
    }

  
//    protected void Button2_Click(object sender, EventArgs e)
//    {
//        string kk = "";
//        string ss = "";
//        for (int i = 0; i <= lstcategery.Items.Count; i++)
//        {
//            if (lstcategery.Items[i].Selected == true)
//            {
//                ss = ss + lstcategery.Items[i].Text.ToString() + "$";
//            }

//        }
//        if(CheckBox1.Checked==true)
//    {
//      kk="1";
//    }

//        else
//    {
//        kk="0";
//    }

//        if(ss!="")
//        {
//            if(CheckBox1.Checked==false && CheckBox2.Checked==false)
//        {
//            message="Please Select Checkbox";
//            return ;

//        }
//}

//DataSet ds = new DataSet();
//if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
//{
//    ASTROLOGY.classesoracle.categery country = new ASTROLOGY.classesoracle.categery();
//    ds = country.bind_desc(ss, kk);
//    div1.Attributes.Add("style", "visibility:visible;");
//    GridView1.DataSource = ds.Tables[0];
//    GridView1.DataBind();
//    return;
//}

//}

    


//string message=""; 
// protected void AspNetMessageBox(string strMessage)
//    {

//        string strAlert = "";
//        strAlert = "alert('" + strMessage + "')";
//        ScriptManager.RegisterClientScriptBlock(this, typeof(predictive_categery), "ShowAlert", strAlert, true);
//    }
}
