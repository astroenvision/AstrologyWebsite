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

public partial class yoga : System.Web.UI.Page
{
    string usermail = "";
    string usermail1 = "";
    string clmail = "";
    string clname = "";
    string asmail = "";
    string asname = "";
    string s = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds1 = new DataSet();
        Ajax.Utility.RegisterTypeForAjax(typeof(yoga));
        if (Session["usermail"] == null)
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(yoga), "wq", "window.parent.location.href='login.aspx';", true);
            return;
        }
        usermail = Request.QueryString["usermail"];
        hdnuser.Value = Request.QueryString["usermail"];
        if (usermail != Session["usermail"].ToString())
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(yoga), "wq", "window.parent.location.href='login.aspx';", true);
            //Response.Redirect("login.aspx");
            return;

        }
        if (!Page.IsPostBack)
        {
            bindlistbox();
            yogalist.Attributes.Add("onclick", "javascript:return listboxitemsclick();");
            Radio2.Attributes.Add("onclick", "javascript:return bindlistbox_data();");
            Radio1.Attributes.Add("onclick", "javascript:return bindlistbox_data1();");
            r1.Attributes.Add("onclick", "javascript:return bindlistbox_data2();");
            //exitbutton.Attributes.Add("onclick", "javascript:return closeformfunction(event);");
            DataSet ds = new DataSet();
            if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                ds = country.ast_rights(Request.QueryString["astmail"].ToString());
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
            s = Request.QueryString["s"].ToString();
            {
                if (Request.QueryString["clname"] == null)
                {
                    clmail = "";
                    clname = "";
                }
                else
                {
                    clname = Request.QueryString["clname"].ToString();
                    clmail = Request.QueryString["clmail"].ToString();
                    asname = Request.QueryString["astname"].ToString();
                    asmail = Request.QueryString["astmail"].ToString();
                    clientid.Text = clmail;
                    clientname.Text = clname;
                    astid.Text = asmail;
                    astname.Text = asname;
                }
                Hs.Value = s;
            }
            ds.Dispose();
        }
    }


    public void bindlistbox()
    {
        string data = "A";
        yogalist.Items.Clear();

        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_listbox_data(data);
        }

        ListItem li = new ListItem();
        li.Text = "---Select Yoga--";
        li.Value = "0";
        li.Selected = true;

        yogalist.Items.Add(li);

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["CODE"].ToString();
            li1.Text = ds.Tables[0].Rows[i]["NAME"].ToString();
            yogalist.Items.Add(li1);
        }
    }
    [Ajax.AjaxMethod]
    public DataSet get_alldata(string data)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_listbox_data(data);
        }
        return ds;
    }
    [Ajax.AjaxMethod]
    public DataSet get_alldata_data(string rashihouse, string listitem)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_listbox_str(rashihouse, listitem);
        }
        return ds;
    }

}
