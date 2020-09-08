using ASTROLOGY.classesoracle;
using System;
using System.Configuration;
using System.Data;
using System.Web.UI;

public partial class admin_Eka_Nakashtra_Dosha_Update : System.Web.UI.Page
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
        ds = obj.GetAshtakootPredictive("Eka_Nakashtra_Dosha", Id,"","");
        if (ds.Tables[0].Rows.Count > 0)
        {
            txtGirlConstellation.Text = ds.Tables[0].Rows[0]["GIRL_CONSTELLATION"].ToString();
            txtBoyConstellation.Text = ds.Tables[0].Rows[0]["BOY_CONSTELLATION"].ToString();
            txtGirlCharan.Text = ds.Tables[0].Rows[0]["GIRL_CHARAN"].ToString();
            txtBoyCharan.Text = ds.Tables[0].Rows[0]["BOY_CHARAN"].ToString();
            txtGirlBoyCharan.Text = ds.Tables[0].Rows[0]["GIRL_BOY_CHARAN"].ToString();
            txtMatch.Text = ds.Tables[0].Rows[0]["MATCH"].ToString();
            fckPredictive.Value = ds.Tables[0].Rows[0]["PREDICTIVE"].ToString();
            lblID.Text = ds.Tables[0].Rows[0]["ID"].ToString();
            fckExpertOpinion.Value = ds.Tables[0].Rows[0]["EXPERT_OPINION"].ToString();
            fckRemedial.Value = ds.Tables[0].Rows[0]["REMEDIAL"].ToString();
            ddlchecked.SelectedValue = ds.Tables[0].Rows[0]["CHECKED"].ToString();
            ddlStatus.SelectedValue = ds.Tables[0].Rows[0]["STATUS"].ToString();
            ddlPriority.SelectedValue = ds.Tables[0].Rows[0]["PRIORITY"].ToString();
            rteDefinition.Value = ds.Tables[0].Rows[0]["DEFINITION"].ToString();
        }
    }
    #endregion

    #region Update Click
    protected void btnUpdate_click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        if (fckPredictive.Value == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_Eka_Nakashtra_Dosha_Update), "wq", "alert('Enter Predictive!');", true);
            return;
        }
        ds = obj.UpdateEkaNakashtraDosha("Update_Eka_Nakashtra_Dosha", lblID.Text, rteDefinition.Value, fckPredictive.Value, fckRemedial.Value, fckExpertOpinion.Value,
            ddlPriority.SelectedValue, ddlStatus.SelectedValue, ddlchecked.SelectedValue , AdminUserId);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string STATUS = ds.Tables[0].Rows[0]["STATUS"].ToString();
            if (STATUS == "1")
            {
                string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_Eka_Nakashtra_Dosha_Update), "wq", "alert(' " + Message + "');", true);
                LoadData(lblID.Text);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_Eka_Nakashtra_Dosha_Update), "wq", "alert('Some Error Occured');", true);
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_Eka_Nakashtra_Dosha_Update), "wq", "alert('Some Error Occured');", true);
        }
    }
    #endregion
}