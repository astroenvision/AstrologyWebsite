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

public partial class horary_illustration : System.Web.UI.Page
{
    common cs = new common();
    string clmail = "";
    string clname = "";
    string asmail = "";
    string asname = "";
    string usermail = "";
    string username1 = "";
    string cat_id = "";
    string study = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(horary_illustration));

       
            
        if (!Page.IsPostBack)
        {

           
            fill_topc();
            bind_chart();
            clgroup.Attributes.Add("Onchange", "javascript:return cldetail(this.id);");
            adgrp.Attributes.Add("Onchange", "javascript:return cldetail(this.id);");
            cat.Attributes.Add("onchange", "javascript:return newgroup();");
            chart.Attributes.Add("Onchange", "javascript:return vargaschartd01();");
            sebyb.Attributes.Add("Onclick", "javascript:return sebyb_data();");
            se.Attributes.Add("Onclick", "javascript:return save_data();");
            up.Attributes.Add("Onclick", "javascript:return update_data();");
            de.Attributes.Add("Onclick", "javascript:return delete_data();");
            sebyd.Attributes.Add("Onchange", "javascript:return sebyd_data();");
            DataSet ds = new DataSet();


            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

                ds = country.ast_rights(Request.QueryString["usermail"]);

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

            if (Session["usermail"] == null || Session["usermail"] == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(horary_illustration), "wq", "window.parent.location.href='login.aspx';", true);
                return;
            }

               

            usermail = Request.QueryString["usermail"];
            hdnuser.Value = Request.QueryString["usermail"];
            hdngroupunder.Value = Request.QueryString["gropunder"];
            if (usermail != Session["usermail"].ToString())
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(horary_illustration), "wq", "window.parent.location.href='login.aspx';", true);
                //   Response.Redirect("login.aspx");
                return;

            }
            else
            {
                var astrologer = Session["usermail"].ToString();
                Hidden9.Value = astrologer;
                
            }

        
        }
       
    }

    public void bind_chart()
    {
        chart.Items.Clear();

        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_chart("");

        }


        ListItem li = new ListItem();
        li.Text = "--Select Chart--";
        li.Value = "0";
        li.Selected = true;

        chart.Items.Add(li);


        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["CHART_NO"].ToString();
            chart.Items.Add(li1);

        }




    }

   
    [Ajax.AjaxMethod]
    public DataSet bindcat(string astrologer, string grp_cat, string grp_cat_u,string clmail)
    {
        DataSet ds = new DataSet();
        ds = cs.bind_category(astrologer, grp_cat, grp_cat_u, clmail);
       
        return ds;
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
    public DataSet searchuser(string astrologer,string grp_cat)
    {
        DataSet ds = new DataSet();

        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.bind_user(astrologer, grp_cat);
        }

        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet fetchd1(string clmail, string astmail,string grop,string gropu)
    {
        DataSet ds = new DataSet();

        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.fetchd1(clmail, astmail, grop, gropu);
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
    public DataSet scs(string astrologer, string cat, string client,string grop,string gropu)
    {
        DataSet ds = new DataSet();

        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.search_cs(astrologer, cat, client,grop,gropu);
        }

        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet vargasvalue(string vargas)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {


            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.vargas(vargas);
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
    public DataSet searchclient(string astrologer, string grop,string groupu)
    {
        DataSet ds = new DataSet();

        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.bind_client(astrologer, grop,groupu);
        }

        return ds;
    }
    [Ajax.AjaxMethod]
    public DataSet searchclient_by(string astrologer, string grop, string searchoption, string txtvalue,string gropu)
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
    public DataSet datadel(string astrologer_id, string client_id, string flag, string group,string gropu)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();

            ds = country.data_delete(astrologer_id, client_id, flag, group, gropu);
        }
        return ds;
    }
    [Ajax.AjaxMethod]
    public DataSet save_data(string cat_id, string clname, string clmail, string p_mail, string study,string group,string gropu)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();

            ds = country.insert_astro_client_cstudy(cat_id, clname, clmail, p_mail, study,group,gropu);
        }
        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet update_data(string cat_id, string clname, string clmail, string p_mail, string study, string group, string gropu)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();

            ds = country.update_astro_client_cstudy(cat_id, clname, clmail, p_mail, study, group, gropu);
        }
        return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet delete_data(string cat_id, string clname, string clmail, string p_mail, string group, string gropu)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();

            ds = country.delete_astro_client_cstudy(cat_id, clname, clmail, p_mail, group, gropu);
        }
        return ds;
    }
    public void clear_data()
    {
        catn.Attributes.Add("style", "visibility:hidden;");
        cat.SelectedIndex = 0;
        explanation_text.Value = "";
    }
    

}
