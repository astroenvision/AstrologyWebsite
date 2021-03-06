﻿using System;
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
public partial class admin_UpdatePredictiveUsingUniqueId : System.Web.UI.Page
{
    #region Declarations
    common cs_obj = new common();
    admin ad_obj = new admin();
    subscription sub_obj = new subscription();
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    public string AdminUserId = "", AdminEmailId = "";
    string Cid = "", Qid = "", Ques = "", TableName = "", KeyString = "", Logic = "", ResultVal = "", ResultUpdateVal = "", Id = "";
    bool flagcheck = false, flagnewpredictive = false;
    #endregion

    #region PageLoad
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(admin_UpdatePredictiveUsingUniqueId));

        if (AdminStateManagement == "COOKIE")
        {
            if (Request.Cookies["AdminCookies"] != null)
            {
                AdminUserId = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
                if (!Page.IsPostBack)
                {
                    if (Request["table"] != null && Request["table"].ToString() != "")
                    {
                        ddltable.SelectedValue = Request["table"].ToString().Trim();
                        bindgridnews();
                    }
                }
            }
            else
            {
                Response.Redirect(ResolveUrl("~/admin"));
                return;
            }
        }
        else
        {
            if (Session["AdminUserId"] != null)
            {
                AdminUserId = Session["AdminUserId"].ToString();
                if (!Page.IsPostBack)
                {
                    if (Request["table"] != null && Request["table"].ToString() != "")
                    {
                        ddltable.SelectedValue = Request["table"].ToString().Trim();
                        bindgridnews();
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

    #region Bind Grid
    void bindgridnews()
    {
        try
        {
            if (Request["table"] != null && Request["table"].ToString() != "")
            {
                TableName = Request["table"].ToString().Trim();
                //KeyString = Request["keystring"].ToString().Trim();
                KeyString = "";
                Id = Request["uniqueid"].ToString().Trim();
                KeyString = KeyString.Replace("'", "''").Replace("<br>", "").Trim();
                //Logic = Request["logic"].ToString().Trim();
                Logic = "";
                Logic = Logic.Replace("'", "''").Replace("<br>", "").Trim();
                //DataSet ds = ad_obj.GetNatalFilters(TableName, KeyString, Logic, "EDIT");
                DataSet ds = ad_obj.GetNatalFilters(TableName, KeyString, Logic, Id, "GET_USING_UNIQUE_ID");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    rtepredictivenew.Value = ds.Tables[0].Rows[0]["DESCCLOB"].ToString();
                    ddlpredictivetype.SelectedValue = ds.Tables[0].Rows[0]["PREDICTIVE_TYPE"].ToString();
                    txtkeystringnew.Text = ds.Tables[0].Rows[0]["KEY_STRING"].ToString();
                    txtlogic.Text = ds.Tables[0].Rows[0]["DESCRIPTION"].ToString();
                    txtuniqueid.Text = ds.Tables[0].Rows[0]["UNIQUE_ID"].ToString();
                    lbl_result.InnerHtml = "Search Found <font size=\"3\" color=\"red\">" + ds.Tables[0].Rows.Count.ToString() + "</font> result(s).";
                    grdData.DataSource = ds;
                    grdData.DataBind();
                }
                else
                {
                    ds = null;
                    lbl_result.InnerHtml = "Search Found <font size=\"3\" color=\"red\">0</font> result(s).";
                    grdData.DataSource = ds;
                    grdData.DataBind();
                }
                ds.Dispose();
            }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    #endregion

    #region update Click
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        try
        {
            //Id = Request["uniqueid"].ToString().Trim();
            DataSet dspu = new DataSet();
            TableName = Request["table"].ToString().Trim();
            string PreType = ddlpredictivetype.SelectedValue.ToString();
            if (PreType == "0")
            {
                PreType = "";
            }
            dspu = ad_obj.Insert_Natal_Predictives("HouseNone", "PlanetNone", "RashiNone", txtkeystringnew.Text, txtlogic.Text, "Name", "Chart", "Subbook", "Page", txtuniqueid.Text, rtepredictivenew.Value, "", TableName, "UPDATE_USING_UNIQUE_ID", "HouseNew", "PlanetNew", "RashiNew", "FilterNew", "LogicNew", "NameNew", "ChartNew", "PredictiveNew", "RemedialNew", "UniqueidNew", "Combination", "LagnaRashi", PreType, 0, "", "","","","");
            if (dspu.Tables[0].Rows.Count > 0)
            {
                ResultUpdateVal = dspu.Tables[0].Rows[0]["flag"].ToString();
            }
            dspu.Dispose();
            if (ResultUpdateVal == "Y")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_UpdatePredictiveUsingUniqueId), "wq", "alert('Predictive Updated Successfully!');", true);
            }
            if (ResultUpdateVal != "Y")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_UpdatePredictiveUsingUniqueId), "wq", "alert('Predictive Not Updated Try Again!');", true);
                return;
            }
            bindgridnews();
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    #endregion

    #region Delete Click
    protected void btndelete_Click(object sender, EventArgs e)
    {
        try
        {
            for (Int32 I32Counter = 0; I32Counter < grdData.Rows.Count; I32Counter++)
            {
                Label lblautoid = (Label)(grdData.Rows[I32Counter].FindControl("lblautoid"));
                CheckBox cbRows = (CheckBox)(grdData.Rows[I32Counter].FindControl("cbRows"));
                Label lblkeystring = (Label)(grdData.Rows[I32Counter].FindControl("lblkeystring"));
                Label lbluniqueid = (Label)(grdData.Rows[I32Counter].FindControl("lbluniqueid"));
                //TextBox lblpredictive = (TextBox)(grdviews.Rows[I32Counter].FindControl("lblpredictive"));
                string rtepredictive = ((FCKeditor)grdData.Rows[I32Counter].FindControl("rtepredictive")).Value;
                string rteremedial = ((FCKeditor)grdData.Rows[I32Counter].FindControl("rteremedial")).Value;
                DropDownList ddlpredictive = (DropDownList)(grdData.Rows[I32Counter].FindControl("ddlpredictive"));
                if (cbRows.Checked == true)
                {
                    flagcheck = true;
                    DataSet dspu = new DataSet();
                    TableName = Request["table"].ToString().Trim();
                    string PreType = ddlpredictive.SelectedValue.ToString();
                    if (PreType == "0")
                    {
                        PreType = "";
                    }
                    dspu = ad_obj.Insert_Natal_Predictives("HouseNone", "PlanetNone", "RashiNone", lblkeystring.Text, "Logic", "Name", "Chart", "Subbook", "Page", lbluniqueid.Text, rtepredictive, rteremedial, TableName, "DELETE", "HouseNew", "PlanetNew", "RashiNew", "FilterNew", "LogicNew", "NameNew", "ChartNew", "PredictiveNew", "RemedialNew", "UniqueidNew", "Combination", "LagnaRashi", PreType, int.Parse(lblautoid.Text.ToString()), "", "","","","");
                    if (dspu.Tables[0].Rows.Count > 0)
                    {
                        ResultUpdateVal = dspu.Tables[0].Rows[0]["flag"].ToString();
                    }
                    dspu.Dispose();
                }
            }
            if (flagcheck == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_UpdatePredictiveUsingUniqueId), "wq", "alert('Please check any checkbox!');", true);
                return;
            }
            if (flagcheck == true && ResultUpdateVal == "Y")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_UpdatePredictiveUsingUniqueId), "wq", "alert('Data Delete Successfully!');", true);
                bindgridnews();
                Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri);
                return;
            }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    #endregion

    #region Grid Events
    protected void ddltable_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            grdData.PageIndex = e.NewPageIndex;
            bindgridnews();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    protected void grdData_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            DataRowView drv = e.Row.DataItem as DataRowView;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label lblautoid = (Label)e.Row.FindControl("lblautoid");

                HyperLink btnedit = (HyperLink)e.Row.FindControl("btnedit");
                //btnedit.NavigateUrl = ResolveUrl("~/admin/map_natal_data.aspx?table=" + TableName + "&keystring=" + lblkeystring.Text.Trim() + "&logic=" + lbllogic.Text.Trim() + "&autoid=" + lblautoid.Text.Trim() + "");
                btnedit.NavigateUrl = ResolveUrl("~/admin/UpdatePredicitve.aspx?table=" + TableName + "&autoid=" + lblautoid.Text.Trim() + "");

                //string keystringval = "";
                //Label lblkeystring = (Label)e.Row.FindControl("lblkeystring");
                //keystringval = lblkeystring.Text.ToString();
                //Label lblcat = (Label)e.Row.FindControl("lblcat");
                //Label lblquestion = (Label)e.Row.FindControl("lblquestion");
                //keystringval = keystringval.Replace("'", "''").Replace("<br>", "").Trim();
                //DataSet ds = ad_obj.GetCategoryAndQuestions(keystringval, "GETCATEGORYNAME");
                //if (ds.Tables[0].Rows.Count > 0)
                //{
                //    lblcat.Text = ds.Tables[0].Rows[0]["FINAL_CATEGERY"].ToString().Trim();
                //    lblquestion.Text = ds.Tables[0].Rows[0]["QUESTION"].ToString().Trim();
                //}
                //ds.Dispose();

                ////TextBox txtpredictive = (TextBox)e.Row.FindControl("lblpredictive");
                ////txtpredictive.Attributes["onclick"] = "javascript:return rowno('" + e.Row.RowIndex + "')";

                ////CheckBox cbRowsid = (CheckBox)e.Row.FindControl("cbRows");
                ////cbRowsid.Attributes["onclick"] = "javascript:return rowno(this,'" + e.Row.RowIndex + "')";

                //Label lblpredictivetype = (Label)e.Row.FindControl("lblpredictivetype");
                //DropDownList ddlpredictive = (DropDownList)e.Row.FindControl("ddlpredictive");
                //if (lblpredictivetype.Text != "")
                //{
                //    ddlpredictive.SelectedValue = lblpredictivetype.Text.ToString().Trim();
                //}
            }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    #endregion
}