using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Manglik_Dosha_Update : System.Web.UI.Page
{
    #region Declarations
    admin obj = new admin();
    subscription sub = new subscription();
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    public string AdminUserId = "", AdminEmailId = "";
    string ID = "";
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (AdminStateManagement == "COOKIE")
        {
            if (Request.Cookies["AdminCookies"] != null)
            {
                AdminUserId = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
                if (Request.QueryString["q"] != "")
                {
                    ID = Request.QueryString["q"].ToString();
                }
                if (!IsPostBack)
                {
                    LoadData(ID);
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
                if (Request.QueryString["q"] != "")
                {
                    ID = Request.QueryString["q"].ToString();
                }
                if (!IsPostBack)
                {
                    LoadData(ID);
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
    protected void LoadData(string Id)
    {
        if (Id == "") return;
        DataSet ds = new DataSet();
        ds = obj.GetAshtakootPredictive("Manglik_Predictive", Id, "", "");
        if (ds.Tables[0].Rows.Count > 0)
        {
            txtManglikDoshaBoy.Text = ds.Tables[0].Rows[0]["MANGLIK_DOSHA_BOY"].ToString();
            txtManglikDoshaGirl.Text = ds.Tables[0].Rows[0]["MANGLIK_DOSHA_GIRL"].ToString();
            txtPredictiveFor.Text = ds.Tables[0].Rows[0]["PREDICTIVE_FOR"].ToString();
            txtManglikDoshaFor.Text = ds.Tables[0].Rows[0]["MANGLIK_DOSHA_FOR"].ToString();
            txtPredictiveType.Text = ds.Tables[0].Rows[0]["PREDICTIVE_TYPE"].ToString();
            txtIsMatch.Text = ds.Tables[0].Rows[0]["ISMATCH"].ToString();
            txtChartNo.Text = ds.Tables[0].Rows[0]["CHART_NO"].ToString();
            rteQuestion.Value = ds.Tables[0].Rows[0]["QUESTION"].ToString();
            fckPredictive.Value = ds.Tables[0].Rows[0]["PREDICTIVE"].ToString();
            lblID.Text = ds.Tables[0].Rows[0]["ID"].ToString();
            fckExpertOpinion.Value = ds.Tables[0].Rows[0]["EXPERT_OPINION"].ToString();
            fckRemedial.Value = ds.Tables[0].Rows[0]["REMEDIAL"].ToString();
            ddlchecked.SelectedValue = ds.Tables[0].Rows[0]["CHECKED"].ToString();
            ddlStatus.SelectedValue = ds.Tables[0].Rows[0]["STATUS"].ToString();
            ddlPriority.SelectedValue = ds.Tables[0].Rows[0]["PRIORITY"].ToString();
        }
    }
    #endregion

    #region Update Click
    protected void btnUpdate_click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        if (fckPredictive.Value == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_Manglik_Dosha_Update), "wq", "alert('Enter Predictive!');", true);
            return;
        }
         ds = obj.UpdateManglikDoshaPredictive("UPDATE_MANGLIK_DOSHA", lblID.Text , rteQuestion.Value , fckPredictive.Value , fckRemedial.Value ,
         fckExpertOpinion.Value , ddlPriority.SelectedValue ,ddlStatus.SelectedValue , ddlchecked.SelectedValue, AdminUserId);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string STATUS = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if (STATUS == "1")
            {
                string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_Manglik_Dosha_Update), "wq", "alert(' " + Message + "');", true);
                LoadData(lblID.Text);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_Manglik_Dosha_Update), "wq", "alert('Some Error Occured');", true);
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_Manglik_Dosha_Update), "wq", "alert('Some Error Occured');", true);
        }
    }
    #endregion
}