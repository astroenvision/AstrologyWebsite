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
using AjaxControlToolkit;
using System.IO;
using System.Diagnostics;
using ASTROLOGY.classesoracle;
using System.Web.Services;
using System.Text.RegularExpressions;
using FredCK.FCKeditorV2;

public partial class admin_ImportExportData : System.Web.UI.Page
{
    #region Declarations
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    public string AdminUserId = "", AdminEmailId = "";
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (AdminStateManagement == "COOKIE")
        {
            if (Request.Cookies["AdminCookies"] != null)
            {
                AdminUserId = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
                if (!Page.IsPostBack)
                {
                    
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
                if (!Page.IsPostBack)
                {
                    
                }
            }
            else
            {
                Response.Redirect(ResolveUrl("~/admin"));
                return;
            }
        }
    }

    protected void btninsert_Click(object sender, EventArgs e)
    {
        try
        {
            DataSet dsinp = new DataSet();
            //dsinp = ad_obj.Insert_Natal_Predictives(lblhouse.Text, lblplanet.Text, lblrashi.Text, lblkeystring.Text, lbllogic.Text, "", "", subbookval, "", lbluniqueid.Text, "", "", TableName, "INSERT", housevalnew, planetvalnew, rashivalnew, filtervalnew, descvalnew, namevalnew, chartvalnew, predictivenew, remedialnew, uniqueidvalnew, combination, lbllagnarashi.Text, predictivetypeval, int.Parse("0"));
            //if (dsinp.Tables[0].Rows.Count > 0)
            //{
            //    ResultVal = dsinp.Tables[0].Rows[0]["flag"].ToString();
            //}
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        try
        {
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
}