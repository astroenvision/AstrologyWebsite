using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_AstrologerClientDetails : System.Web.UI.Page
{
    #region Declarations
    public string Type = "";
    common cs = new common();
    admin obj = new admin();
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    public string AdminUserId = "", AdminEmailId = "";
    ASTROLOGY.classesoracle.main obj_main = new ASTROLOGY.classesoracle.main();
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    #endregion

    #region Page load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (AdminStateManagement == "COOKIE")
        {
            if (Request.Cookies["AdminCookies"] != null)
            {
                AdminUserId = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
                if (!IsPostBack)
                {
                    if (Request.QueryString["q"] != null)
                    {
                        mainchannelbind();
                        string ID = Request.QueryString["q"].ToString();
                        if (Request.QueryString["Type"] != null)
                        {
                            Type = Request.QueryString["Type"].ToString();
                            LoadData(ID);
                        }
                    }
                }
            }
            else
            {
                Response.Redirect(ResolveUrl("~/admin"));
            }
        }
        else
        {
            if (Session["AdminUserId"] != null)
            {
                AdminUserId = Session["AdminUserId"].ToString();
                if (!IsPostBack)
                {
                    if (Request.QueryString["q"] != null)
                    {
                        mainchannelbind();
                        string ID = Request.QueryString["q"].ToString();
                        if (Request.QueryString["Type"] != null)
                        {
                            Type = Request.QueryString["Type"].ToString();
                            LoadData(ID);
                        }
                    }
                }
            }
            else
            {
                Response.Redirect(ResolveUrl("~/admin"));
                return;
            }
        }
    }
    #endregion

    #region Load Data
    protected void LoadData(string ID)
    {
        if (ID == null) return;
        DataSet ds = new DataSet();
        ds = obj.ManageMapingDetails("GET_MAPPING_DETAILS", ID, "", "","","","","","");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ViewReport.NavigateUrl = "~/ClientReport.aspx?cartid=" + ds.Tables[0].Rows[0]["CART_ID"].ToString() + "&group=NATAL";
            txtname.Text = ds.Tables[0].Rows[0]["CLIENT_NAME"].ToString();
            txtcontact.Text = ds.Tables[0].Rows[0]["CONTACT_NO"].ToString();
            userddlgender.SelectedValue = ds.Tables[0].Rows[0]["GENDER"].ToString();
            lblID.Text = ds.Tables[0].Rows[0]["AUTO_ID"].ToString();
            string Dob = ds.Tables[0].Rows[0]["DOB"].ToString();
            string[] a = Dob.Split('/');
            ddlDate.SelectedValue = a[0].ToString();
            ddlMonth.SelectedValue = a[1].ToString();
            ddlYear.SelectedValue = a[2].ToString();
            string TOB = ds.Tables[0].Rows[0]["TOB"].ToString();
            string[] b = TOB.Split(':');
            hob.SelectedValue = b[0].ToString();
            mob.SelectedValue = b[1].ToString();
            ddlCountry.Text = ds.Tables[0].Rows[0]["COUNTRY"].ToString();
            ddlState.Text = ds.Tables[0].Rows[0]["STATE"].ToString();
            ddlCity.Text = ds.Tables[0].Rows[0]["CITY"].ToString();
            txtNoOfMin.Text = ds.Tables[0].Rows[0]["NO_OF_MINUTES"].ToString();
            ddlConsultationType.SelectedValue = ds.Tables[0].Rows[0]["CONSULTATION_TYPE"].ToString();
            ddlConsultancyLanguage.SelectedValue = ds.Tables[0].Rows[0]["LANGUAGE_TYPE"].ToString();
            txtQuestion1.Text = ds.Tables[0].Rows[0]["QUESTION1"].ToString();
            txtQuestion2.Text = ds.Tables[0].Rows[0]["QUESTION2"].ToString();
            txtQuestion3.Text = ds.Tables[0].Rows[0]["QUESTION3"].ToString();
            txtQuestion4.Text = ds.Tables[0].Rows[0]["QUESTION4"].ToString();
            txtQuestion5.Text = ds.Tables[0].Rows[0]["QUESTION5"].ToString();
            txtAnswer1.Text = ds.Tables[0].Rows[0]["ANSWER1"].ToString();
            txtAnswer2.Text = ds.Tables[0].Rows[0]["ANSWER2"].ToString();
            txtAnswer3.Text = ds.Tables[0].Rows[0]["ANSWER3"].ToString();
            txtAnswer4.Text = ds.Tables[0].Rows[0]["ANSWER4"].ToString();
            txtAnswer5.Text = ds.Tables[0].Rows[0]["ANSWER5"].ToString();

        }
    }
    #endregion

    #region Bind Drop Down
    protected void mainchannelbind()
    {
        DataSet ds = new DataSet();
        ds = cs.bindloc();
        DataSet dsc = obj_subs.GetDateMonthYearHourMinute("");
        if (dsc.Tables[0].Rows.Count > 0)
        {
            ddlDate.Items.Clear();
            ddlDate.DataSource = dsc.Tables[0];
            ddlDate.DataTextField = "DATE_NAME";
            ddlDate.DataValueField = "DATE_NAME";
            ddlDate.DataBind();
            ddlDate.Items.Insert(0, new ListItem("Date", "-1"));

        

            ddlMonth.Items.Clear();
            ddlMonth.DataSource = dsc.Tables[1];
            ddlMonth.DataTextField = "MONTH_NAME";
            ddlMonth.DataValueField = "MONTH_NUMBER";
            ddlMonth.DataBind();
            ddlMonth.Items.Insert(0, new ListItem("Month", "-1"));


            ddlYear.Items.Clear();
            ddlYear.DataSource = dsc.Tables[2];
            ddlYear.DataTextField = "YEAR_NAME";
            ddlYear.DataValueField = "YEAR_NAME";
            ddlYear.DataBind();
            ddlYear.Items.Insert(0, new ListItem("Year", "-1"));

          
            hob.Items.Clear();
            hob.DataSource = dsc.Tables[3];
            hob.DataTextField = "HOUR_NAME";
            hob.DataValueField = "HOUR_NAME";
            hob.DataBind();
            hob.Items.Insert(0, new ListItem("Hours", "-1"));

            mob.Items.Clear();
            mob.DataSource = dsc.Tables[4];
            mob.DataTextField = "MINUTE_NAME";
            mob.DataValueField = "MINUTE_NAME";
            mob.DataBind();
            mob.Items.Insert(0, new ListItem("Minutes", "-1"));
        }
        dsc.Dispose();
    }
    #endregion

    #region Submit Click
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        ds = obj.ManageMapingDetails("UPDATE_FINAL_STATUS", lblID.Text, ddlStatus.SelectedValue, "" , txtAnswer1.Text , txtAnswer2.Text , txtAnswer3.Text , txtAnswer4.Text , txtAnswer5.Text);
        if (ds.Tables[0].Rows.Count > 0)
         {
              string Status = ds.Tables[0].Rows[0]["Status"].ToString();
              string Message = ds.Tables[0].Rows[0]["Message"].ToString();
              if (Status == "1")
              {
                  ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AstrologerClientDetails), "wq", "alert('" + Message + "');", true);
              }
              else
              {
                  ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AstrologerClientDetails), "wq", "alert('Some Error Occured');", true);
              }
           }
          else
            {
                 ScriptManager.RegisterClientScriptBlock(this, typeof(admin_AstrologerClientDetails), "wq", "alert('Some Error Occured');", true);
            }
     }
    #endregion
}