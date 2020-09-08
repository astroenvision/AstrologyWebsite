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

public partial class readmore : System.Web.UI.Page

{
    string head = "";
    string keyword = "";
    string snopsis = "";
    string story = "";
    string state_inner = "";
    string v = "";
    string j = "";
    string k = "";
   

    common cs = new common();
    string mail = "astrology";
    string strHtml = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        //Get Story
        if (Request.QueryString["time"] != "")
        {
            string nId = Request.QueryString["time"].ToString();
            DataSet ds = new DataSet();
            //ds = cs.test(nId);
            
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.login useragency = new ASTROLOGY.classesoracle.login();
                ds = useragency.newsdata(nId);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                string headline = ds.Tables[0].Rows[0]["HEADLINES"].ToString();
                string keyword = ds.Tables[0].Rows[0]["KEYWORD"].ToString();
                string synopsis = ds.Tables[0].Rows[0]["SYNOPSIS"].ToString();
                string fillstory = ds.Tables[0].Rows[0]["FILLSTORY"].ToString();
                string image = ds.Tables[0].Rows[0]["IMAGE"].ToString();
                strHtml += "<div style=\"width:100%\"><img style=\"float:left;padding:5px;\" src=\"articles/" + image + "\" width=\"282\" height=\"191\" alt=\"img\" />";
                strHtml += "" + headline + "";
                strHtml += "" + fillstory + "";
                strHtml += "</div>";
            }
            replace_div.InnerHtml = strHtml;
        }

        Ajax.Utility.RegisterTypeForAjax(typeof(readmore));
        //v = Request.QueryString["time"].ToString();
        //j = Request.QueryString["fillstory"].ToString();
        //k = Request.QueryString["image"].ToString();

        //link1.Value = v;
        //himg.Value = k;
        //hstr.Value = j;
        



        Session["usermail"] = mail;
        DataSet objDataSet = new DataSet();

      
        
     
        Ajax.Utility.RegisterTypeForAjax(typeof(readmore));

      
        if (!Page.IsPostBack)
        {


           
            r1.Attributes.Add("onchange", "javascript:return radio1butt();");
            r2.Attributes.Add("onchange", "javascript:return radio2butt();");
          
        }
        

    }



   

    protected void LinkButton1_Click(object sender, EventArgs e)
    {

        DataSet ds1 = new DataSet();
        string mail = txtusername1.Text.ToString();
        string pass = txtpwd1.Text.ToString();
        ds1 = cs.search_astro(mail, pass);
        if (ds1.Tables[0].Rows.Count != 0)
        {
            Session["name"] = ds1.Tables[0].Rows[0]["NAME"].ToString();
            Session["usermail"] = mail;
            string usermail = mail;
            Response.Redirect("myaccount.aspx?usermail=" + usermail);

        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(readmore), "wq", "alert('Invalid ID / Password !');", true);
        }
        ds1.Dispose();

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("astro_dtls.aspx");


    }


    //[Ajax.AjaxMethod]
    //public DataSet datashow(string grididata)
    //{
    //    DataSet ds = new DataSet();
    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ASTROLOGY.classesoracle.login useragency = new ASTROLOGY.classesoracle.login();
    //        ds = useragency.newsdata(grididata);
    //    }
        
    //    return ds;
    //}

}
