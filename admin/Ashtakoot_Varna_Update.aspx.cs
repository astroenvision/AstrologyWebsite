using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class admin_Ashtakoot_Varna_Update : System.Web.UI.Page
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
        ds = obj.GetAshtakootPredictive("Varna_Predictive", Id,"","");
        if (ds.Tables[0].Rows.Count > 0)
        {
            txtVarnaPoints.Text = ds.Tables[0].Rows[0]["VARNA_POINT"].ToString();
            txtIsMatch.Text = ds.Tables[0].Rows[0]["ISMATCH"].ToString();
            txtIsMatchException.Text = ds.Tables[0].Rows[0]["ISMATCH_EXCEPTION"].ToString();
            fckPredictive.Value = ds.Tables[0].Rows[0]["PREDICTIVE"].ToString();
            fckDefinition.Value = ds.Tables[0].Rows[0]["DEFINITION"].ToString();
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
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_Ashtakoot_Varna_Update), "wq", "alert('Enter Predictive!');", true);
            return;
        }
        ds = obj.UpdateVarnaPredictive("Update_Varna_Predictive", lblID.Text,fckPredictive.Value, fckDefinition.Value, fckRemedial.Value, fckExpertOpinion.Value,
            ddlPriority.SelectedValue, ddlStatus.SelectedValue, ddlchecked.SelectedValue , AdminUserId);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string STATUS = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if (STATUS == "1")
            {
                string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_Ashtakoot_Varna_Update), "wq", "alert(' " + Message + "');", true);
                LoadData(lblID.Text);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_Ashtakoot_Varna_Update), "wq", "alert('Some Error Occured');", true);
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_Ashtakoot_Varna_Update), "wq", "alert('Some Error Occured');", true);
        }
    }
    #endregion
}