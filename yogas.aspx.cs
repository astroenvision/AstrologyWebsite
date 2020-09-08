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

public partial class yogas : System.Web.UI.Page
{
    string v = "";
    string lagnarashi = "";
    string lagnadegree = "";
    string degree = "";
    string house = "";
    string drop1 = "";
    string degreesecond="";
    string moonrashi = "";
    string sunhouse = "";
    string moonhouse = "";
    string usermail = "";
    string asendrashi = "";
    string suninhouse = "";
    string mooninhouse = "";
    string marsinhouse = "";
    string mrecinhouse = "";
    string jupinhouse = "";
    string venusinhouse = "";
    string saturninhouse = "";
    string retro = "";
    string rashie = "";
   
    protected void Page_Load(object sender, EventArgs e)
    {

        Ajax.Utility.RegisterTypeForAjax(typeof(yogas));
        if (Session["usermail"] == null || Session["usermail"] == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(yogas), "wq", "window.parent.location.href='login.aspx';", true);
            return;
        }
        usermail = Request.QueryString["usermail"];
        hdnuser.Value = Request.QueryString["usermail"];
        if (usermail != Session["usermail"].ToString())
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(yogas), "wq", "window.parent.location.href='login.aspx';", true);
            //Response.Redirect("login.aspx");
            return;

        }
        if (!Page.IsPostBack)
        {
            allyogosid.HRef = HttpContext.Current.Request.Url.AbsoluteUri;
            horarykaryasidhi.Attributes.Add("Onclick", "javascript:return karyasiddhi();");
            naktabutton.Attributes.Add("Onclick", "javascript:return naktayogaitc();");
            yamyabut.Attributes.Add("Onclick", "javascript:return naktayogaitc();");
            cross.Attributes.Add("onclick", "javascript:return creossdiv();");
            vargaschart.Attributes.Add("onchange", "javascript:return showvargas();");
            fhy.Attributes.Add("onclick", "javascript:return calfhy();");
            //button_grid.Attributes.Add("onclick", "javascript:return cross_signi();");
            
            bindvargaschart();
            bindhouse();
            drop1 = Request.QueryString["drop1"].ToString();
            astname.Text = Request.QueryString["astname"].ToString();
            astid.Text = Request.QueryString["astmail"].ToString();
            clientname.Text = Request.QueryString["clname"].ToString();
            clientid.Text = Request.QueryString["clmail"].ToString();
            astrologername.Value = Request.QueryString["astname"].ToString();
            astrologerid.Value = Request.QueryString["astmail"].ToString();
            hdnclientname.Value = Request.QueryString["clname"].ToString();
            hdnclientid.Value = Request.QueryString["clmail"].ToString();

            hdnidateob.Value = Request.QueryString["idateob"];
            hdnimonthob.Value = Request.QueryString["imonthob"];
            hdniyearob.Value = Request.QueryString["iyearob"];
            hdnihourob.Value = Request.QueryString["ihourob"];
            hdniminuteob.Value = Request.QueryString["iminuteob"];


            hdnidateobf.Value = Request.QueryString["idateob"];
            hdnimonthobf.Value = Request.QueryString["imonthob"];
            hdniyearobf.Value = Request.QueryString["iyearob"];
            hdnihourobf.Value = Request.QueryString["ihourob"];
            hdniminuteobf.Value = Request.QueryString["iminuteob"];

            hdnlongit.Value = Request.QueryString["longitude"];
            hdnlatit.Value = Request.QueryString["latitude"];

            hdndob.Value = Request.QueryString["dob"];
            hdntob.Value = Request.QueryString["tob"];
            hdntzo.Value = Request.QueryString["tz"];
            hdntzval.Value = Request.QueryString["tzval"];
            hdnquery.Value = Request.QueryString["query"];
            if (hdnquery.Value != "")
            {
                clientqueryid.InnerHtml = "Querist's Query: " + hdnquery.Value + "";
            }

            DataSet ds = new DataSet();

            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
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
            if (drop1 =="Karya Siddhi Yoga")
            {
                asendrashi = Request.QueryString["asendrashi"].ToString();
                suninhouse = Request.QueryString["suninhouse"].ToString();
                mooninhouse = Request.QueryString["mooninhouse"].ToString();
                marsinhouse = Request.QueryString["marsinhouse"].ToString();
                mrecinhouse = Request.QueryString["mrecinhouse"].ToString();
                jupinhouse = Request.QueryString["jupinhouse"].ToString();
                venusinhouse = Request.QueryString["venusinhouse"].ToString();
                saturninhouse = Request.QueryString["saturninhouse"].ToString();
                v = Request.QueryString["v"].ToString();
                Hiddenva.Value = v;
                Hasendrashi.Value = asendrashi;
                Hsuninhouse.Value = suninhouse;
                Hmooninhouse.Value = mooninhouse;
                Hmarsinhouse.Value = marsinhouse;
                Hmrecinhouse.Value = mrecinhouse;
                Hjupinhouse.Value = jupinhouse;
                Hvenusinhouse.Value = venusinhouse;
                Hsaturninhouse.Value = saturninhouse;
                Hdrop1.Value = drop1;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Test","karyafun();", true);
            }
            else if ((drop1 == "Nakta Yoga") || drop1 == "Yamya Yoga")
            {
                naktabutton.Attributes.Add("style", "display:block");
                yamyabut.Attributes.Add("style", "display:none");
                foritchaaldiv.Attributes.Add("style", "display:none");
                if (drop1 == "Yamya Yoga")
                {
                    naktabutton.Attributes.Add("style", "display:none");
                    yamyabut.Attributes.Add("style", "display:block");
                    foritchaaldiv.Attributes.Add("style", "display:none");
                }
                
                lagnarashi = Request.QueryString["lagnarashi"].ToString();
                lagnadegree = Request.QueryString["lagnadegree"].ToString();
                degree = Request.QueryString["degree"].ToString();
                house = Request.QueryString["house"].ToString();

                degreesecond = Request.QueryString["degreesecond"].ToString();
                moonrashi = Request.QueryString["moonrashi"].ToString();
                sunhouse = Request.QueryString["sunhouse"].ToString();
                moonhouse = Request.QueryString["moonhouse"].ToString();

                Hlagnarashi.Value = lagnarashi;
                Hlagnadegree.Value = lagnadegree;
                Hdegree.Value = degree;
                Hhouse.Value = house;
                Hdrop1.Value = drop1;
                Hdegreesecond.Value = degreesecond;
                Hmoonrashi.Value = moonrashi;
                Hsunhouse.Value = sunhouse;
                Hmoonhouse.Value = moonhouse;
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Test","naktafun();", true);
               
            }
            else if ((drop1 == "Manau Yoga") || (drop1 == "Kamboola Yoga"))
            {
               
                lagnarashi = Request.QueryString["lagnarashi"].ToString();
                lagnadegree = Request.QueryString["lagnadegree"].ToString();
                degree = Request.QueryString["degree"].ToString();
                house = Request.QueryString["house"].ToString();

                degreesecond = Request.QueryString["degreesecond"].ToString();
                moonrashi = Request.QueryString["moonrashi"].ToString();
                sunhouse = Request.QueryString["sunhouse"].ToString();
                moonhouse = Request.QueryString["moonhouse"].ToString();

                Hlagnarashi.Value = lagnarashi;
                Hlagnadegree.Value = lagnadegree;
                Hdegree.Value = degree;
                Hhouse.Value = house;
                Hdrop1.Value = drop1;
                Hdegreesecond.Value = degreesecond;
                Hmoonrashi.Value = moonrashi;
                Hsunhouse.Value = sunhouse;
                Hmoonhouse.Value = moonhouse;
               Page.ClientScript.RegisterStartupScript(this.GetType(), "Test","yogasgrid();", true);
             }

             else
            {
                foritchaaldiv.Attributes.Add("style", "display:block");
                lagnarashi = Request.QueryString["lagnarashi"].ToString();
                lagnadegree = Request.QueryString["lagnadegree"].ToString();
                degree = Request.QueryString["degree"].ToString();
                house = Request.QueryString["house"].ToString();
                v = Request.QueryString["v"].ToString();
                Hiddenva.Value = v;
                degreesecond = Request.QueryString["degreesecond"].ToString();
                moonrashi = Request.QueryString["moonrashi"].ToString();
                sunhouse = Request.QueryString["sunhouse"].ToString();
                moonhouse = Request.QueryString["moonhouse"].ToString();
                retro = Request.QueryString["retro"].ToString();
                rashie = Request.QueryString["rashie"].ToString();

                Hlagnarashi.Value = lagnarashi;
                Hlagnadegree.Value = lagnadegree;
                Hdegree.Value = degree;
                Hhouse.Value = house;
                Hdrop1.Value = drop1;
                Hdegreesecond.Value = degreesecond;
                Hmoonrashi.Value = moonrashi;
                Hsunhouse.Value = sunhouse;
                Hmoonhouse.Value = moonhouse;
                Hretro.Value = retro;
                Hrashie.Value = rashie;
             
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Test","yogasgrid();", true);
             }
        }
    }

    public void bindvargaschart()
    {

        vargaschart.Items.Clear();



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
        vargaschart.Items.Add(li);



        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["CHART_NO"].ToString();
            vargaschart.Items.Add(li1);



        }
    }

    public void bindhouse()
    {
        hd.Items.Clear();
        naktadrop.Items.Clear();
        
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
        hd.Items.Add(li);
        naktadrop.Items.Add(li);
       

        // f19house.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            hd.Items.Add(li1);
            naktadrop.Items.Add(li1);
        }
    }


    [Ajax.AjaxMethod]
    public DataSet showyogas(string lagnarashi, string degree, string house, string degreesecond, string menuitemsvalus, string retro, string rashie)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
            ds = country.showyogas(lagnarashi, degree, house, degreesecond, menuitemsvalus, retro, rashie);
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet showyogas_menuitem(string lagnarashi, string degree, string house, string degreesecond, string menuitemsvalus, string retro, string rashie)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
            ds = country.showyogas_menu(lagnarashi, degree, house, degreesecond, menuitemsvalus, retro, rashie);
        }
        return ds;
       

    }


    [Ajax.AjaxMethod]
    public DataSet showyogas_manau(string lagnarashi, string degree, string house, string degreesecond)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
            ds = country.showyogas_manau_process(lagnarashi, degree, house, degreesecond);
        }
        return ds;

    }




  [Ajax.AjaxMethod]
    public DataSet showyogas1(string lagnarashi, string degree, string house, string menuitemsvalus, string retro)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
            ds = country.showyogas1(lagnarashi, degree, house, menuitemsvalus, retro);
        }
        return ds;

    }

 [Ajax.AjaxMethod]
  public DataSet showyogas_kamboola(string lagnarashi,string degree,string house,string degreesecond,string moonrashi,string moonhouse,string sunhouse)
  {
      DataSet ds = new DataSet();
      if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
      {
          ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
          ds = country.kamboola_proce(lagnarashi,degree,house,degreesecond,moonrashi,moonhouse,sunhouse);
      }
      return ds;

  }


 [Ajax.AjaxMethod]
 public DataSet karya_sidhi(string asendrashi,  string houselord,string housewithtill, string lagnarashi)
 {
     DataSet ds = new DataSet();
     if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
     {
         ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
         ds = country.karya_sidhi_yoga(asendrashi, houselord,housewithtill, lagnarashi);
     }
     return ds;

 }



 [Ajax.AjaxMethod]
 public DataSet datra_nakta(string lagnarashi, string degree, string house, string lordhouse, string newdegree)
 {
     DataSet ds = new DataSet();
     if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
     {
         ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
         ds = country.showyogas_nakta_proce(lagnarashi, degree, house, lordhouse, newdegree);
     }
     return ds;

 }

 [Ajax.AjaxMethod]
 public DataSet datra_yamya(string lagnarashi, string degree, string house, string lordhouse, string newdegree)
 {
     DataSet ds = new DataSet();
     if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
     {
         ASTROLOGY.classesoracle.chartindex country = new ASTROLOGY.classesoracle.chartindex();
         ds = country.showyogas_yamya_proce(lagnarashi, degree, house, lordhouse, newdegree);
     }
     return ds;

 }


 protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
 {

     string menusel = Menu1.SelectedItem.Value;
     menuitsmcvalue.Value = menusel;
     Page.ClientScript.RegisterStartupScript(this.GetType(), "Test", "yogasgrid();", true);
    
        
     }

 [Ajax.AjaxMethod]
 public DataSet bindgirdfor(string datafortable)
 {
     DataSet ds = new DataSet();

     if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
     {
         ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

         ds = country.checkdataforgrid(datafortable);

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

 }

