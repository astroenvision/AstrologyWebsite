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

public partial class admin_natal_category_data : System.Web.UI.Page
{
    #region Declarations
    common cs_obj = new common();
    admin ad_obj = new admin();
    subscription sub_obj = new subscription();
    string Cid = "", Qid = "", Ques = "", TableName = "", KeyString = "", Logic = "", ResultVal = "", ResultUpdateVal = "", Id = "";
    bool flagcheck = false, flagnewpredictive = false;
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    public string AdminUserId = "", AdminEmailId = "";
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(admin_natal_category_data));

        if (AdminStateManagement == "COOKIE")
        {
            if (Request.Cookies["AdminCookies"] != null)
            {
                AdminUserId = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
                if (!Page.IsPostBack)
                {
                    //if (Request["table"] != null && Request["table"].ToString() != "")
                    //{
                    BindNatalCategories();
                    //ddltable.SelectedValue = Request["table"].ToString().Trim();
                    //bindgridnews();
                    //}
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
                    //if (Request["table"] != null && Request["table"].ToString() != "")
                    //{
                    BindNatalCategories();
                    //ddltable.SelectedValue = Request["table"].ToString().Trim();
                    //bindgridnews();
                    //}
                }
            }
            else
            {
                Response.Redirect(ResolveUrl("~/admin"));
                return;
            }
        }
    }

    void BindNatalCategories()
    {
        DataSet ds = cs_obj.Get_Natal_cat("");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlcategory.Items.Clear();
            ddlcategory.DataSource = ds;
            ddlcategory.DataTextField = "FINAL_CATEGERY";
            ddlcategory.DataValueField = "FINAL_CATID";
            ddlcategory.DataBind();
            ddlcategory.Items.Insert(0, "--Select Category--");
            ds.Dispose();
        }
    }

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
                    for (int j = 0; j < dsq.Tables[0].Rows.Count;j++)
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
            string keystr="";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                keystr +=  ds.Tables[0].Rows[i]["CATEGERY"].ToString() + "~";
            }
            ViewState["keystring"]=keystr;
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
    protected void ddltable_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void grdviews_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            grdviews.PageIndex = e.NewPageIndex;
            bindgridnews();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    protected void grdviews_RowDataBound(object sender, GridViewRowEventArgs e)
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
                HyperLink btnedit = (HyperLink)e.Row.FindControl("btnedit");
                //btnedit.NavigateUrl = ResolveUrl("~/admin/map_natal_data.aspx?table=" + TableName + "&keystring=" + lblkeystring.Text.Trim() + "&logic=" + lbllogic.Text.Trim() + "&autoid=" + lblautoid.Text.Trim() + "");
                btnedit.NavigateUrl = ResolveUrl("~/admin/map_natal_data.aspx?table=" + TableName + "&autoid=" + lblautoid.Text.Trim() + "");

                HyperLink btnaddcat = (HyperLink)e.Row.FindControl("btnaddcat");
                btnaddcat.NavigateUrl = ResolveUrl("~/admin/mapp_natal_category.aspx?table=" + TableName + "&keystring=" + lblkeystring.Text.Trim() + "&logic=" + lbllogic.Text.Trim() + "");


                Label lbltype = (Label)e.Row.FindControl("lbltype");
                if (lbltype.Text.Trim() == "P")
                {
                    lbltype.Text = "POSITIVE";
                }
                if (lbltype.Text.Trim() == "N")
                {
                    lbltype.Text = "NEGATIVE";
                }
                if (lbltype.Text.Trim() == "R")
                {
                    lbltype.Text = "REMEDIAL";
                }
            }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }


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
    void bindgridnews()
    {
        try
        {
                TableName = ddltable.SelectedValue.Trim();
                KeyString = ViewState["keystring"].ToString();
                KeyString = KeyString.Replace("'", "''").Replace("<br>", "").Trim();
                Logic = "";
                Logic = Logic.Replace("'", "''").Replace("<br>", "").Trim();
                //DataSet ds = ad_obj.GetNatalFilters(TableName, KeyString, Logic, "EDIT");
                //DataSet ds = ad_obj.GetNatalFilters(TableName, KeyString, Logic, Id, "GET_USING_ID");
                DataSet ds = ad_obj.Get_Natal_Keystring_Filter(KeyString.ToUpper(), Logic.ToUpper(), TableName, "~", "", "");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    lbl_result.InnerHtml = "Search Found <font size=\"3\" color=\"red\">" + ds.Tables[0].Rows.Count.ToString() + "</font> result(s).";
                    grdviews.DataSource = ds;
                    grdviews.DataBind();
                }
                else
                {
                    ds = null;
                    lbl_result.InnerHtml = "Search Found <font size=\"3\" color=\"red\">0</font> result(s).";
                    grdviews.DataSource = ds;
                    grdviews.DataBind();
                    grdviews.Dispose();
                }
                ds.Dispose();
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }


    

   
}