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

public partial class horarysignificator : System.Web.UI.Page
{
    string usermail = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(horarysignificator));
        if (Session["usermail"] == null || Session["usermail"] == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(horarysignificator), "wq", "window.parent.location.href='login.aspx';", true);
            return;
        } 
        usermail = Request.QueryString["usermail"];
        hdnuser.Value = Request.QueryString["usermail"];
        if (usermail != Session["usermail"].ToString())
        {

            ScriptManager.RegisterClientScriptBlock(this, typeof(horarysignificator), "wq", "window.parent.location.href='login.aspx';", true);
            return;


        }
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_rights(Request.QueryString["usermail"].ToString());

        }
        if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Both")
        {
           

        }
        if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Natal")
        {

            horarydiv.Attributes.Add("style", "display:none;");
            // a8.Attributes.Add("style", "display:none;");
            //a7l.Attributes.Add("style", "display:none;");
            //a8l.Attributes.Add("style", "display:none;");
            //horarycombina.Attributes.Add("style", "visibility:hidden;");
            
        }
        if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Horary")
        {
            // a2.Attributes.Add("style", "display:none;");
            nataldiv.Attributes.Add("style", "display:none;");
            //a2l.Attributes.Add("style", "display:none;");
            //a3l.Attributes.Add("style", "display:none;");
            //a4l.Attributes.Add("style", "display:none;");
            //a5l.Attributes.Add("style", "display:none;");
            //a6l.Attributes.Add("style", "display:none;");

            // d2.Attributes.Add("style", "visibility:hidden;");
            //yoga.Attributes.Add("style", "visibility:hidden;");
            //astrocalc.Attributes.Add("style", "visibility:hidden;");
            

        }
        bindplanet();
        bindrashi();
        bindhouse();

        yamyabut.Attributes.Add("onclick", "javascript:return showgrid();");
        horpalnet.Attributes.Add("onchange", "javascript:return clearall();");
        horrashi.Attributes.Add("onchange", "javascript:return clearall2();");
        horhouse.Attributes.Add("onchange", "javascript:return clearall3();");
        searchsignificator.Attributes.Add("onblur", "javascript:return clearall4();");
    }


    public void bindplanet()
    {
        horpalnet.Items.Clear();


        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_planet("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select Planet--";
        li.Value = "0";
        li.Selected = true;
        horpalnet.Items.Add(li);

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            horpalnet.Items.Add(li1);

        }
    }



    public void bindhouse()
    {
        horhouse.Items.Clear();

        //f19house.Items.Clear();

        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_house("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select House--";
        li.Value = "0";
        li.Selected = true;
        horhouse.Items.Add(li);

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            horhouse.Items.Add(li1);

     }

    }



    public void bindrashi()
    {   horrashi.Items.Clear();     

        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_rashi("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select Rashi--";
        li.Value = "0";
        li.Selected = true;
        horrashi.Items.Add(li);
       


        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            horrashi.Items.Add(li1);
         


        }
    }

    [Ajax.AjaxMethod]
    public DataSet bindgirdfor(string datafortable)
    {
    DataSet ds=new DataSet();

    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    {
        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

        ds = country.checkdataforgrid(datafortable);
        
    }
    return ds;


}
    protected void yamyabut_Click(object sender, EventArgs e)
    {
        string datafortable = hs.Value;
        if (datafortable == "")
        {
            return;
        }
        else
        {
            DataSet ds = new DataSet();

            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

                ds = country.checkdataforgrid(datafortable);

            }
            GridView1.PageIndex = 0;
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        string datafortable = hs.Value;
        DataSet ds = new DataSet();

        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.checkdataforgrid(datafortable);

        }
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
        return;
    }
   
}
