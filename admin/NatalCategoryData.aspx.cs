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

public partial class admin_NatalCategoryData : System.Web.UI.Page
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
        Ajax.Utility.RegisterTypeForAjax(typeof(admin_NatalCategoryData));

        if (AdminStateManagement == "COOKIE")
        {
            if (Request.Cookies["AdminCookies"] != null)
            {
                AdminUserId = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
                if (!Page.IsPostBack)
                {
                    BindNatalCategories();
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
                    BindNatalCategories();
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

    #region Bind GridView Function
    void bindgridnews()
    {
        try
        {
            TableName = ddltable.SelectedValue.Trim();
            //KeyString = ViewState["keystring"].ToString();
            //KeyString = KeyString.Replace("'", "''").Replace("<br>", "").Trim();
            Logic = "";
            //Logic = Logic.Replace("'", "''").Replace("<br>", "").Trim();
            //DataSet ds = ad_obj.GetNatalFilters(TableName, KeyString, Logic, "EDIT");
            //DataSet ds = ad_obj.GetNatalFilters(TableName, KeyString, Logic, Id, "GET_USING_ID");
            //Comment Below Function by Deepak on 29-07-2020
            //DataSet ds = ad_obj.Get_Natal_Keystring_Filter(KeyString.ToUpper(), Logic.ToUpper(), TableName, "~", "", "");
            DataSet ds = ad_obj.Get_Category_Predictive(ddltable.SelectedValue.Trim(), ddlcategory.SelectedValue, ddlquestion.SelectedItem.Text, ddlfilter.SelectedItem.Text, Logic.ToUpper(), "", "USING_QUESTION", "", "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                int iTotalRecords = ds.Tables[0].Rows.Count;
                int iEndRecord = grdData.PageSize * (grdData.PageIndex + 1);
                int iStartsRecods = iEndRecord - grdData.PageSize;
                if (iEndRecord > iTotalRecords)
                {
                    iEndRecord = iTotalRecords;
                }
                if (iStartsRecods == 0)
                {
                    iStartsRecods = 1;
                }
                if (iEndRecord == 0)
                {
                    iEndRecord = iTotalRecords;
                }
                lbl_result.InnerHtml = "Records <font size=\"3\" color=\"red\">" + iStartsRecods + "</font> TO <font size=\"3\" color=\"red\">" + iEndRecord.ToString() + "</font> Of <font size=\"3\" color=\"red\">" + iTotalRecords.ToString() + "</font> .";

                grdData.DataSource = ds;
                grdData.DataBind();
            }
            else
            {
                lbl_result.InnerHtml = "Search Found  <font size=\"3\" color=\"red\">0</font> result(s).";
                ds = null;
                grdData.DataSource = ds;
                grdData.DataBind();
                grdData.Dispose();
            }
            ds.Dispose();
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    #endregion

    #region BindNatalCategories Function 
    void BindNatalCategories()
    {
        DataSet ds = cs_obj.Get_Natal_cat("");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlcategory.Items.Clear();
            ddlcategory.DataSource = ds;
            ddlcategory.DataTextField = "CATEGORY_NAME";
            ddlcategory.DataValueField = "CATEGORY_ID";
            ddlcategory.DataBind();
            ddlcategory.Items.Insert(0, "--Select Category--");
            ds.Dispose();
        }
    }
    #endregion

    #region DropDownList SelectedIndexChanged Events
    protected void ddlcategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        Cid = ddlcategory.SelectedValue.Trim();
        DataSet ds = cs_obj.Get_Natal_Questions(Cid);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string keystrval = "";
            ddlquestion.Items.Clear();
            ddlquestion.DataSource = ds;
            ddlquestion.DataTextField = "QUESTION";
            ddlquestion.DataValueField = "QUESTION_ID";
            ddlquestion.DataBind();
            ddlquestion.Items.Insert(0, "--Select Question--");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Qid = ds.Tables[0].Rows[i]["QUESTION_ID"].ToString().Trim();
                Ques = ds.Tables[0].Rows[i]["QUESTION"].ToString().Trim();
                DataSet dsq = sub_obj.get_natal_questions_substring(Cid, Qid, Ques, "NATAL");
                if (dsq.Tables[0].Rows.Count > 0)
                {
                    for (int j = 0; j < dsq.Tables[0].Rows.Count; j++)
                    {
                        keystrval += dsq.Tables[0].Rows[j]["CATEGERY"].ToString() + "~";
                    }
                }
                dsq.Dispose();
            }
            ViewState["keystring"] = keystrval;
        }
        ds.Dispose();
    }
    protected void ddlquestion_SelectedIndexChanged(object sender, EventArgs e)
    {
        Cid = ddlcategory.SelectedValue.Trim();
        Qid = ddlquestion.SelectedValue.Trim();
        Ques = ddlquestion.SelectedItem.Text.Trim();
        DataSet ds = sub_obj.get_natal_questions_substring(Cid, Qid, Ques, "NATAL");
        if (ds.Tables[0].Rows.Count > 0)
        {
            string keystr = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                keystr += ds.Tables[0].Rows[i]["CATEGERY"].ToString() + "~";
            }
            ViewState["keystring"] = keystr;
            ddlfilter.Items.Clear();
            ddlfilter.DataSource = ds;
            ddlfilter.DataTextField = "CATEGERY";
            ddlfilter.DataValueField = "SEQ";
            ddlfilter.DataBind();
            ddlfilter.Items.Insert(0, "--Select Filter--");
            ds.Dispose();
        }
    }
    protected void ddlfilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        ViewState["keystring"] = "";
        if (ddlfilter.SelectedValue.ToString() != "0" || ddlfilter.SelectedValue.ToString() != "--Select Filter--")
        {
            ViewState["keystring"] = ddlfilter.SelectedItem.Text.ToString() + "~";
        }
        else
        {

        }
    }
    #endregion

    #region GridView PageIndexChanging
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
    #endregion

    #region GridView RowDataBound
    protected void grdData_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            DataRowView drv = e.Row.DataItem as DataRowView;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //Label lbrowno = (Label)e.Row.FindControl("lblrowno");
                //rn1 = rn1 + 1;
                //lbrowno.Text = Convert.ToString(rn1);
                Label lblautoid = (Label)e.Row.FindControl("lblautoid");
                Label lblkeystring = (Label)e.Row.FindControl("lblkeystring");
                Label lblcat = (Label)e.Row.FindControl("lblcat");
                Label lblquestion = (Label)e.Row.FindControl("lblquestion");
                string keystringval = lblkeystring.Text.ToString();
                keystringval = keystringval.Replace("'", "''").Replace("<br>", "").Trim();
                Label lbllogic = (Label)e.Row.FindControl("lbllogic");
                string lbllogicval = lbllogic.Text.ToString();
                lbllogicval = lbllogicval.Replace("'", "''").Replace("<br>", "").Trim();
                DataSet ds = ad_obj.GetCategoryAndQuestions(keystringval, "GETCATEGORYNAME");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string catname = "", quesname = "";
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        catname += ds.Tables[0].Rows[i]["FINAL_CATEGERY"].ToString().Trim() + ",<br>";
                        quesname += ds.Tables[0].Rows[i]["QUESTION"].ToString().Trim() + ",<br>";
                    }
                    catname = catname.Remove(catname.Length - 5, 1);
                    quesname = quesname.Remove(quesname.Length - 5, 1);
                    lblcat.Text = catname;
                    lblquestion.Text = quesname;
                }
                ds.Dispose();
                //Image imgurl = (Image)e.Row.FindControl("editor_image");
                HyperLink btnmapping = (HyperLink)e.Row.FindControl("btnmapping");
                //btnedit.NavigateUrl = ResolveUrl("~/admin/map_natal_data.aspx?table=" + TableName + "&keystring=" + lblkeystring.Text.Trim() + "&logic=" + lbllogic.Text.Trim() + "&autoid=" + lblautoid.Text.Trim() + "");
                btnmapping.NavigateUrl = ResolveUrl("~/admin/UpdatePredictiveMapping.aspx?table=" + TableName + "&autoid=" + lblautoid.Text.Trim() + "");

                HyperLink btnedit = (HyperLink)e.Row.FindControl("btnedit");
                //btnedit.NavigateUrl = ResolveUrl("~/admin/map_natal_data.aspx?table=" + TableName + "&keystring=" + lblkeystring.Text.Trim() + "&logic=" + lbllogic.Text.Trim() + "&autoid=" + lblautoid.Text.Trim() + "");
                btnedit.NavigateUrl = ResolveUrl("~/admin/UpdatePredictive.aspx?table=" + TableName + "&autoid=" + lblautoid.Text.Trim() + "");

                HyperLink btnaddcat = (HyperLink)e.Row.FindControl("btnaddcat");
                btnaddcat.NavigateUrl = ResolveUrl("~/admin/mapp_natal_category.aspx?table=" + TableName + "&keystring=" + lblkeystring.Text.Trim() + "&logic=" + lbllogic.Text.Trim() + "");


                //Label lbltype = (Label)e.Row.FindControl("lbltype");
                //if (lbltype.Text.Trim() == "P")
                //{
                //    lbltype.Text = "POSITIVE";
                //}
                //if (lbltype.Text.Trim() == "N")
                //{
                //    lbltype.Text = "NEGATIVE";
                //}
                //if (lbltype.Text.Trim() == "R")
                //{
                //    lbltype.Text = "REMEDIAL";
                //}

                Label lblpredictivestatus = (Label)e.Row.FindControl("lblpredictivestatus");
                HiddenField hdnstatus = (HiddenField)e.Row.FindControl("hdnstatus");
                HiddenField hdnchecked = (HiddenField)e.Row.FindControl("hdnchecked");
                if (hdnchecked.Value.Trim() == "T")
                {
                    lblpredictivestatus.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblpredictivestatus.ForeColor = System.Drawing.Color.Red;
                }

            }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    #endregion

    #region Search Button Click Event
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        try
        {
            bindgridnews();
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    #endregion

    #region Reset Button Click Event
    protected void btnReset_click(object sender , EventArgs e)
    {
        common.ClearAllControls(Page.Controls);
        DataSet ds = new DataSet();
        ds = null;
        grdData.DataSource = ds;
        grdData.DataBind();
    }
    #endregion
}