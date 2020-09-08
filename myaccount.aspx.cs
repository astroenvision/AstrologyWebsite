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

public partial class myaccount : System.Web.UI.Page
{
    string usermail = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(myaccount));
        if (!Page.IsPostBack)
        {
            fill_topc();
            update1.Attributes.Add("Onclick", "javascript:return updatedata();");
            update2.Attributes.Add("Onclick", "javascript:return updateclientdata();");
            newclient.Attributes.Add("Onclick", "javascript:return newcl();");
            clgroup.Attributes.Add("Onchange", "javascript:return cldetail();");
            chartfilling.Attributes.Add("Onclick", "javascript:return craeatnewchart();");
            delete_0.Attributes.Add("Onclick", "javascript:return delete_data(id);");
            sebyb.Attributes.Add("Onclick", "javascript:return sebyb_data();");
            sebyd.Attributes.Add("Onchange", "javascript:return sebyd_data();");
            grp_cat.Attributes.Add("Onchange", "javascript:return group_bind();");
            DataSet ds = new DataSet();

            if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

                ds = country.ast_rights(Request.QueryString["usermail"]);
                hdncat.Value = ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString();
            }
            if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Both")
            {

            }
            if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Natal")
            {
                grp_cat.Enabled = false;
                /////horarydiv.Attributes.Add("style", "display:none;");
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Test", "accountuser();", true);

                // a8.Attributes.Add("style", "display:none;");
                //a7l.Attributes.Add("style", "display:none;");
                //a8l.Attributes.Add("style", "display:none;");
                //horarycombina.Attributes.Add("style", "visibility:hidden;");

            }
            if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Horary")
            {
                grp_cat.Enabled = false;

                /////nataldiv.Attributes.Add("style", "display:none;");
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Test", "accountuser();", true);

                // a2.Attributes.Add("style", "display:none;");
                //a2l.Attributes.Add("style", "display:none;");
                //a3l.Attributes.Add("style", "display:none;");
                //a4l.Attributes.Add("style", "display:none;");
                //a5l.Attributes.Add("style", "display:none;");
                //a6l.Attributes.Add("style", "display:none;");

                // d2.Attributes.Add("style", "visibility:hidden;");
                //yoga.Attributes.Add("style", "visibility:hidden;");
                //astrocalc.Attributes.Add("style", "visibility:hidden;");


            }
        }
        if (Session["usermail"] == null)
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(myaccount), "wq", "window.parent.location.href='login.aspx';", true);
            return;
        }



        usermail = Request.QueryString["usermail"];
        cngpwd.InnerHtml = "<a style='text-decoration: none;color:#4d4d4d;font-size: 0.80em; font-weight:bold;' href=\"" + ResolveUrl("astro_registration_reactivation.aspx?UserID=" + usermail + "&Flag=CP") + "\">Change Password</a>";
        cngpwd.InnerHtml += " | <a style='text-decoration: none;color:#4d4d4d;font-size: 0.80em; font-weight:bold;' onclick=\"javascript:getopen1(&quot;login.aspx&quot;)\">Log Out</a>";
        hdnuser.Value = Request.QueryString["usermail"];
        if (usermail != Session["usermail"].ToString())
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(myaccount), "wq", "window.parent.location.href='login.aspx';", true);
            //   Response.Redirect("login.aspx");
            return;

        }
        else
        {
            var astrologer = Session["usermail"].ToString();
            Hidden9.Value = astrologer;

        }

    }

    public void fill_topc()
    {
        DataSet div = new DataSet();
        div.ReadXml(Server.MapPath("XML/myaccount.xml"));
        sebyd.Items.Clear();
        int i;
        ListItem li1;
        li1 = new ListItem();
        li1.Text = "Select Option";
        li1.Value = "0";
        li1.Selected = true;
        sebyd.Items.Add(li1);
        for (i = 0; i < div.Tables[0].Columns.Count; i++)
        {
            ListItem li;
            li = new ListItem();
            li.Text = div.Tables[0].Rows[0].ItemArray[i].ToString();
            i = i + 1;
            li.Value = div.Tables[0].Rows[0].ItemArray[i].ToString();
            sebyd.Items.Add(li);
        }
    }

    [Ajax.AjaxMethod]
    public DataSet searchuser(string astrologer, string cat_grp)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.bind_user(astrologer, cat_grp.ToUpper());
        }
        return ds;
    }



    [Ajax.AjaxMethod]
    public DataSet update(string name, string altmail, string mobno, string landno, string add1, string dd2, string country1, string zip, string pwd, string landmark, string mainmail)
    {
        DataSet ds = new DataSet();

        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.update_user(name, altmail, mobno, landno, add1, dd2, country1, zip, pwd, landmark, mainmail);
        }

        return ds;
    }



    [Ajax.AjaxMethod]
    public DataSet updateclient(string astrodetail, string clidetail, string profession, string age, string gender, string pmail, string climail, string group)
    {
        DataSet ds = new DataSet();

        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.update_client(astrodetail, clidetail, profession, age, gender, pmail, climail, group);
        }

        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet searchclient(string astrologer, string grop, string gropu)
    {
        DataSet ds = new DataSet();

        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.bind_client(astrologer, grop, gropu);
        }

        return ds;
    }
    [Ajax.AjaxMethod]
    public DataSet searchclient_by(string astrologer, string grop, string searchoption, string txtvalue, string gropu)
    {
        DataSet ds = new DataSet();

        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.bind_client_by(astrologer, grop, searchoption, txtvalue, gropu);
        }

        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet abc(string astrologer, string grop, string viewcolname, string orderby, string gropu)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();

            ds = country.bind_all_routes_ds(astrologer, grop, viewcolname, orderby, gropu);
        }
        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet datadel(string astrologer_id, string client_id, string flag, string group, string groupu)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();

            ds = country.data_delete(astrologer_id, client_id, flag, group, groupu);
        }
        return ds;
    }

}
