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

public partial class vargas_chart : System.Web.UI.Page
{
    string c = "";
    string usermail = "";
    string v = "";
    string j = "";
    string k = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        string abcd = Request.RawUrl;
        Ajax.Utility.RegisterTypeForAjax(typeof(vargas_chart));
        if (Session["usermail"] == null || Session["usermail"].ToString() == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(vargas_chart), "wq", "window.parent.location.href='login.aspx';", true);
            return;
        }
        usermail = Request.QueryString["usermail"];
        hdnuser.Value = Request.QueryString["usermail"];

        if (usermail != Session["usermail"].ToString())
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(vargas_chart), "wq", "window.parent.location.href='login.aspx';", true);
            //Response.Redirect("login.aspx");
            return;
        }
        c = Request.QueryString["c"].ToString();
        v = Request.QueryString["v"].ToString();
        j = Request.QueryString["j"].ToString();
        k = Request.QueryString["k"].ToString();
        astname.Text = Request.QueryString["astname"].ToString();
        astid.Text = Request.QueryString["astid"].ToString();
        clientname.Text = Request.QueryString["clientname"].ToString();
        clientid.Text = Request.QueryString["clientid"].ToString();
        Hastname.Value = Request.QueryString["astname"].ToString();
        Hastid.Value = Request.QueryString["astid"].ToString();
        Hclname.Value = Request.QueryString["clientname"].ToString();
        Hclid.Value = Request.QueryString["clientid"].ToString();

        hdndob.Value = Request.QueryString["dob"];
        hdntob.Value = Request.QueryString["tob"];
        hdncountry.Value = Request.QueryString["country"];
        hdnstate.Value = Request.QueryString["state"];
        hdndist.Value = Request.QueryString["district"];
        hdncity.Value = Request.QueryString["city"];
        hdngroup_u.Value = Request.QueryString["group_under"];
        string maingroup = hdngroup_u.Value;
        maingroup = char.ToUpper(maingroup[0]) + maingroup.Substring(1);
        hdngroup_u.Value = maingroup;
        hdngroup.Value = Request.QueryString["group"];
        hdnprof.Value = Request.QueryString["prof"];
        hdnsex.Value = Request.QueryString["sex"];
        hdnmobile.Value = Request.QueryString["mobile"];

        hdnidateob.Value = Request.QueryString["idateob"];
        hdnimonthob.Value = Request.QueryString["imonthob"];
        hdniyearob.Value = Request.QueryString["iyearob"];
        hdnihourob.Value = Request.QueryString["ihourob"];
        hdniminuteob.Value = Request.QueryString["iminuteob"];

        hdnlongit.Value = Request.QueryString["longitude"];
        hdnlatit.Value = Request.QueryString["latitude"];
        hdntzo.Value = Request.QueryString["timezone"];
        hdntzval.Value = Request.QueryString["tzval"];
        hdnquery.Value = Request.QueryString["query"];
        if (hdnquery.Value != "")
        {
            clientqueryid.InnerHtml = "Querist's Query: " + hdnquery.Value + "";
        }

        hdsunsetpre.Value = Request.QueryString["sunsetpre"];
        hdsunrise.Value = Request.QueryString["sunrise"];
        hdsunset.Value = Request.QueryString["sunset"];
        hdnsunrisenext.Value = Request.QueryString["sunrisenext"];
        string dateofbirth = hdndob.Value;
        dateofbirth = DateTime.ParseExact(dateofbirth, "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
        DateTime dtc = Convert.ToDateTime(dateofbirth);
        hddayofbirth.Value = dtc.DayOfWeek.ToString();

        if (hdsunrise.Value != "")
        {
            DateTime sr = new DateTime();
            sr = Convert.ToDateTime(hdsunrise.Value);
            DateTime ss = new DateTime();
            ss = Convert.ToDateTime(hdsunset.Value);
            DateTime srn = new DateTime();
            srn = Convert.ToDateTime(hdnsunrisenext.Value);

            TimeSpan ts_daylength = ss.Subtract(sr);
            hdndayduration.Value = Convert.ToString(ts_daylength).Trim();
            TimeSpan ts_nightlength = srn.Subtract(ss);
            hdnnightduration.Value = Convert.ToString(ts_nightlength).Trim();
        }

        if (c!="")
        {
            String[] splitC = c.Split('$');
            if (splitC.Length>0)
            {
                for (int i = 0; i < splitC.Length; i++)
                {
                    if (splitC[i].IndexOf("MOON") > -1)
                    {
                        string rc = splitC[i];
                        String[] splitrc = rc.Split('~');
                        if (splitrc.Length>0)
                        {
                            hdrashi.Value = splitrc[1];
                            hdconstellation.Value = splitrc[6];
                        }
                    }
                }
            }
        }

        string balancedashastr = Request.QueryString["balancedasha"];
        String[] split_bds = balancedashastr.Split('$');
        if (split_bds.Length > 0)
        {
            DataSet ds_dasha = new DataSet();
            if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
                ds_dasha = country.caldashap(Convert.ToInt32(split_bds[0]), Convert.ToInt32(split_bds[1]), Convert.ToInt32(split_bds[2]), split_bds[3], Convert.ToInt32(split_bds[4]), Convert.ToInt32(split_bds[5]), Convert.ToInt32(split_bds[6]), Convert.ToInt32(split_bds[7]), Convert.ToInt32(split_bds[8]), Convert.ToInt32(split_bds[9]), split_bds[10], split_bds[11]);
                if (ds_dasha.Tables[0].Rows.Count > 0)
                {
                    hdnbalancedasha.Value = ds_dasha.Tables[0].Rows[0]["BALANCEDASHA"].ToString();
                    hdnbalancedasha.Value = (hdnbalancedasha.Value).Replace("Balance Of Dasha :", "");
                    hdnbalancedasha.Value = hdnbalancedasha.Value.Trim();
                }
            }
        }

        Hidden4.Value = v;
        Hiddencons.Value = c;
        Hidden1.Value = j;
        Hidden2.Value = k;

        if (!Page.IsPostBack)
        {
            bindchart();
            bindyogas();
            cat_grp.Attributes.Add("Onchange", "javascript:return group_bind();");
            ImageButton1.Attributes.Add("onclick", "javascript:return showchart();");
            D01.Attributes.Add("onclick", "javascript:return searchdataopt();");
            chart.Attributes.Add("Onchange", "javascript:return vargaschart();");
            ImageButton2.Attributes.Add("onclick", "javascript:return savegrid();");
            ImageButton4.Attributes.Add("onclick", "javascript:return chartindexdata();");
            yogasbutton.Attributes.Add("onclick", "javascript:return calculateyogas();");
            yoga.Attributes.Add("onclick", "javascript:return yoga();");
            cliidname.Attributes.Add("onclick", "javascript:return hidediv();");
            cross.Attributes.Add("onclick", "javascript:return creossdiv();");
            horarycombina.Attributes.Add("onclick", "javascript:return openhorcomb();");
            astrocalc.Attributes.Add("onclick", "javascript:return openastrocalcu();");
            DataSet ds = new DataSet();

            if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

                ds = country.ast_rights(Request.QueryString["astid"].ToString());

            }
            if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Both")
            {
                hdncat.Value = ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString();
                return;
            }
            if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString().ToUpper().Trim() == "Natal")
            {
                cat_grp.Enabled = false;
                horarydiv.Attributes.Add("style", "display:none;");
                hdncat.Value = ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString();
                //a8.Attributes.Add("style", "display:none;");
                //a7l.Attributes.Add("style", "display:none;");
                //a8l.Attributes.Add("style", "display:none;");
                //horarycombina.Attributes.Add("style", "visibility:hidden;");
               return;
            }
             if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString().ToUpper().Trim() == "Horary")
             {
                 cat_grp.Enabled = false;
                // a2.Attributes.Add("style", "display:none;");
                 nataldiv.Attributes.Add("style", "display:none;");
                 hdncat.Value = ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString();
                 //a2l.Attributes.Add("style", "display:none;");
                 //a3l.Attributes.Add("style", "display:none;");
                 //a4l.Attributes.Add("style", "display:none;");
                 //a5l.Attributes.Add("style", "display:none;");
                 //a6l.Attributes.Add("style", "display:none;");
                 
                // d2.Attributes.Add("style", "visibility:hidden;");
                //yoga.Attributes.Add("style", "visibility:hidden;");
                //astrocalc.Attributes.Add("style", "visibility:hidden;");
            
                return;
            }
        } 
    }

    public void bindchart()
    {
        chart.Items.Clear();
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_chart("");
        }
        ds.Dispose();

        ListItem li = new ListItem();
        li.Text = "--Select Chart--";
        li.Value = "0";
        li.Selected = true;

        chart.Items.Add(li);
        
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            string ChartName = ds.Tables[0].Rows[i]["CHART_NAME"].ToString();
            if (ChartName != "")
            {
                ChartName = ds.Tables[0].Rows[i]["CHART_NO"].ToString() + " " + ds.Tables[0].Rows[i]["CHART_NAME"].ToString() + " (" + ds.Tables[0].Rows[i]["CHART_DESC"].ToString() + ")";
            }
            else
            {
                ChartName = ds.Tables[0].Rows[i]["CHART_NO"].ToString();
            }
            ListItem li1 = new ListItem();
            li1.Value = ds.Tables[0].Rows[i]["CHART_NO"].ToString();
            li1.Text = ChartName;
            chart.Items.Add(li1);
        }

    }

    public void bindyogas()
    {
        dropyogas.Items.Clear();
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_yogas("");
            ListItem li = new ListItem();
            li.Text = "---Select yogas---";
            li.Value = "0";
            li.Selected = true;

            dropyogas.Items.Add(li);


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ListItem li1 = new ListItem();
                li1.Text = ds.Tables[0].Rows[i]["NAME"].ToString();
                dropyogas.Items.Add(li1);
            }
        }

    }

   

   

    [Ajax.AjaxMethod]
    public DataSet vargasvalue(string vargas)
    {

        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.vargas(vargas);
        }
        return ds;

    }


   [Ajax.AjaxMethod]
    public DataSet savecharts(string d01, string d02, string d03, string d04, string d05, string d06, string d07, string d08, string d09, string d10, string d11, string d12, string d16, string d20, string d24, string d27, string d30, string d40, string d45, string d60, string kl, string astid, string astname, string client, string clientid, string dasha, string dob, string tob, string countr, string state, string district, string city, string group, string group_u, string prof, string sex, string mobile, string sunsetpre, string sunrise, string sunset, string sunrisenext, string dayofborth, string rashi, string constellation, string longitude, string latitude, string timezone, string dayduration, string nightduration, string balancedasha, string ClientEmailId, string pwd, string lagnarashi, string chartdetails, string matchwith, string lagnachart, string moonchart, string venuschart, string UserType, string RegUserId, string RegUserEmailId, string Cartid, string clientquery)
    {

        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.savecharts(d01, d02, d03, d04, d05, d06, d07, d08, d09, d10, d11, d12, d16, d20, d24, d27, d30, d40, d45, d60, kl, astid, astname, client, clientid, dasha, dob, tob, countr, state, district, city, group, group_u, prof, sex, mobile, sunsetpre, sunrise, sunset, sunrisenext, dayofborth, rashi, constellation, longitude, latitude, timezone, dayduration, nightduration, balancedasha, ClientEmailId, pwd, lagnarashi, chartdetails, matchwith, lagnachart, moonchart, venuschart, UserType, RegUserId, RegUserEmailId, Cartid, clientquery);
        }
        return ds;

    }


   [Ajax.AjaxMethod]
   public DataSet chechduplicacy(string astid, string astname, string client, string clientid,string group,string groupu)
   {

       DataSet ds = new DataSet();
       if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
       {
           ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
           ds = country.chechduplicacy(astid, astname, client, clientid, group, groupu);
       }
       return ds;

   }
   [Ajax.AjaxMethod]
   public DataSet viewclientinfo(string astid, string clinid)
   {
       DataSet ds = new DataSet();
       if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
       {
           //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
           ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
           ds = country.ast_viewclientinfo(astid, clinid);
       }
       return ds;


   }

   [Ajax.AjaxMethod]
   public DataSet searchuser(string astrologer, string cat_grp)
   {
       DataSet ds = new DataSet();

       if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
       {
           ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
           ds = country.bind_user(astrologer, cat_grp);
       }

       return ds;
   }


   //[Ajax.AjaxMethod]
   //public DataSet viewyagas(string lagnarashi, string lagnadegree, string degree, string house)
   //{
   //    DataSet ds = new DataSet();
   //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
   //    {

   //        Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
   //        ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
   //        ds = country.showyogas(lagnarashi, lagnadegree, degree, house);
   //    }
   //    return ds;

   //}


   protected void btncancel_Click(object sender, EventArgs e)
   {
       string jScript = "<script>window.close();</script>";
       ClientScript.RegisterClientScriptBlock(this.GetType(), "keyClientBlock", jScript);
   }
}

