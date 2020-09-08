using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASTROLOGY.classesoracle;
using System.Configuration;

public partial class admin_ManagePredictiveUsingUniqueId : System.Web.UI.Page
{
    common cs_obj = new common();
    admin ad_obj = new admin();
    subscription sub_obj = new subscription();
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    public string AdminUserId = "", AdminEmailId = "";
    string Cid = "", Qid = "", Ques = "", TableName = "", KeystringVal = "", LogicVal = "", txtsrchval = "", PredictiveTypeVal = "";
    protected void Page_Load(object sender, EventArgs e)
    {
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
                //ScriptManager.RegisterClientScriptBlock(this, typeof(admin_ManagePredictiveUsingUniqueId), "wq", "window.parent.location.href='/admin';", true);
                Response.Redirect(ResolveUrl("~/admin"));
                return;
            }
        }
    }
    #region Grid Events
    protected void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdData.PageIndex = e.NewPageIndex;
        bindgridnews();
    }
    protected void gdvpredictive_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gdvpredictive.PageIndex = e.NewPageIndex;
        BindPredictiveCount();
    }
    #endregion

    void BindPredictiveCount()
    {
        try
        {
            DataSet ds = ad_obj.Get_Natal_Search_Predictives("", "", ddltable.SelectedValue.Trim(), "", "", "","", "", "", "", "","GET_PREDICTIVE_USING_UNIQUE_ID");
            if (ds.Tables[0].Rows.Count > 0)
            {
                int iTotalRecords = ds.Tables[0].Rows.Count;
                int iEndRecord = gdvpredictive.PageSize * (gdvpredictive.PageIndex + 1);
                int iStartsRecods = iEndRecord - gdvpredictive.PageSize;
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
                lbl_result_gdvpredictive.InnerHtml = "Records <font size=\"3\" color=\"red\">" + iStartsRecods + "</font> TO <font size=\"3\" color=\"red\">" + iEndRecord.ToString() + "</font> Of <font size=\"3\" color=\"red\">" + iTotalRecords.ToString() + "</font> .";

                gdvpredictive.DataSource = ds;
                gdvpredictive.DataBind();
            }
            else
            {
                lbl_result_gdvpredictive.InnerHtml = "Search Found  <font size=\"3\" color=\"red\">0</font> result(s).";
                ds = null;
                gdvpredictive.DataSource = ds;
                gdvpredictive.DataBind();
            }
            ds.Dispose();
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }

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
    protected void ddlcategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        Cid = ddlcategory.SelectedValue.Trim();
        DataSet ds = cs_obj.Get_Natal_Questions(Cid);
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlquestion.Items.Clear();
            ddlquestion.DataSource = ds;
            ddlquestion.DataTextField = "QUESTION";
            ddlquestion.DataValueField = "QUESTION_ID";
            ddlquestion.DataBind();
            ddlquestion.Items.Insert(0, "--Select Question--");
            ds.Dispose();
        }
    }
    protected void ddlquestion_SelectedIndexChanged(object sender, EventArgs e)
    {
        Cid = ddlcategory.SelectedValue.Trim();
        Qid = ddlquestion.SelectedValue.Trim();
        Ques = ddlquestion.SelectedItem.Text.Trim();
        DataSet ds = sub_obj.get_natal_questions_substring(Cid, Qid, Ques, "NATAL");
        if (ds.Tables[0].Rows.Count > 0)
        {
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

    }
    protected void ddlkeystring_SelectedIndexChanged(object sender, EventArgs e)
    {
        TableName = ddltable.SelectedValue.Trim();
        DataSet dsl = ad_obj.GetNatal_Filter_Logic(TableName, "", "LOGIC");
        if (dsl.Tables[0].Rows.Count > 0)
        {
            ddllogic.Items.Clear();
            ddllogic.DataSource = dsl;
            ddllogic.DataTextField = "DESCRIPTION";
            ddllogic.DataValueField = "DESCRIPTION";
            ddllogic.DataBind();
            ddllogic.Items.Insert(0, "--Select Logic--");
        }
        dsl.Dispose();
    }
    protected void ddllogic_SelectedIndexChanged(object sender, EventArgs e)
    {
        TableName = ddltable.SelectedValue.Trim();
        DataSet ds = ad_obj.GetNatal_Filter_Logic(TableName, "", "KEYSTRING");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlkeystring.Items.Clear();
            ddlkeystring.DataSource = ds;
            ddlkeystring.DataTextField = "KEY_STRING";
            ddlkeystring.DataValueField = "KEY_STRING";
            ddlkeystring.DataBind();
            ddlkeystring.Items.Insert(0, "--Select Keystring--");
        }
        ds.Dispose();
    }
    protected void ddltable_SelectedIndexChanged(object sender, EventArgs e)
    {
        TableName = ddltable.SelectedValue.Trim();
        DataSet ds = ad_obj.GetNatal_Filter_Logic(TableName, "", "KEYSTRING");
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlkeystring.Items.Clear();
            ddlkeystring.DataSource = ds;
            ddlkeystring.DataTextField = "KEY_STRING";
            ddlkeystring.DataValueField = "KEY_STRING";
            ddlkeystring.DataBind();
            ddlkeystring.Items.Insert(0, "--Select Keystring--");
        }
        ds.Dispose();

        DataSet dsl = ad_obj.GetNatal_Filter_Logic(TableName, "", "LOGIC");
        if (dsl.Tables[0].Rows.Count > 0)
        {
            ddllogic.Items.Clear();
            ddllogic.DataSource = dsl;
            ddllogic.DataTextField = "DESCRIPTION";
            ddllogic.DataValueField = "DESCRIPTION";
            ddllogic.DataBind();
            ddllogic.Items.Insert(0, "--Select Logic--");
        }
        dsl.Dispose();

        BindPredictiveCount();
    }
    protected void grdviews_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            grdData.PageIndex = e.NewPageIndex;
            bindgridnews();
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    protected void grdviews_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            DataRowView drv = e.Row.DataItem as DataRowView;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                TableName = ddltable.SelectedValue.Trim();
                //Label lbrowno = (Label)e.Row.FindControl("lblrowno");
                //rn1 = rn1 + 1;
                //lbrowno.Text = Convert.ToString(rn1);
                Label lblautoid = (Label)e.Row.FindControl("lblautoid");
                Label lblkeystring = (Label)e.Row.FindControl("lblkeystring");
                Label lblcat = (Label)e.Row.FindControl("lblcat");
                Label lblquestion = (Label)e.Row.FindControl("lblquestion");
                Label lbluniqueid = (Label)e.Row.FindControl("lbluniqueid"); 
                string keystringval = lblkeystring.Text.ToString();
                keystringval = keystringval.Replace("'", "''").Replace("<br>", "").Trim();
                Label lbllogic = (Label)e.Row.FindControl("lbllogic");
                string lbllogicval = lbllogic.Text.ToString();
                lbllogicval = lbllogicval.Replace("'", "''").Replace("<br>", "").Trim();
                //DataSet ds = ad_obj.GetCategoryAndQuestions(keystringval, "GETCATEGORYNAME");
                //if (ds.Tables[0].Rows.Count > 0)
                //{
                //    string catname = "", quesname = "";
                //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                //    {
                //        catname += ds.Tables[0].Rows[i]["FINAL_CATEGERY"].ToString().Trim() + ",<br>";
                //        quesname += ds.Tables[0].Rows[i]["QUESTION"].ToString().Trim() + ",<br>";
                //    }
                //    catname = catname.Remove(catname.Length - 5, 1);
                //    quesname = quesname.Remove(quesname.Length - 5, 1);
                //    lblcat.Text = catname;
                //    lblquestion.Text = quesname;
                //}
                //ds.Dispose();
                //Image imgurl = (Image)e.Row.FindControl("editor_image");
                HyperLink btnedit = (HyperLink)e.Row.FindControl("btnedit");
                //btnedit.NavigateUrl = ResolveUrl("~/admin/map_natal_data.aspx?table=" + TableName + "&keystring=" + lblkeystring.Text.Trim() + "&logic=" + lbllogic.Text.Trim() + "&autoid=" + lblautoid.Text.Trim() + "");
                btnedit.NavigateUrl = ResolveUrl("~/admin/UpdatePredictiveUsingUniqueId.aspx?table=" + TableName + "&uniqueid=" + lbluniqueid.Text.Trim() + "");

                //HyperLink btnaddcat = (HyperLink)e.Row.FindControl("btnaddcat");
                //btnaddcat.NavigateUrl = ResolveUrl("~/admin/natal_update_predictive.aspx?table=" + TableName + "&keystring=" + lblkeystring.Text.Trim() + "&logic=" + lbllogic.Text.Trim() + "");

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

    protected void gdvpredictive_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            DataRowView drv = e.Row.DataItem as DataRowView;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                TableName = ddltable.SelectedValue.Trim();
                //Label lbrowno = (Label)e.Row.FindControl("lblrowno");
                //rn1 = rn1 + 1;
                //lbrowno.Text = Convert.ToString(rn1);
                //Label lblautoid = (Label)e.Row.FindControl("lblautoid");
                //Label lblkeystring = (Label)e.Row.FindControl("lblkeystring");
                //Label lblcat = (Label)e.Row.FindControl("lblcat");
                //Label lblquestion = (Label)e.Row.FindControl("lblquestion");
                Label lbluniqueid = (Label)e.Row.FindControl("lbluniqueid");
                //string keystringval = lblkeystring.Text.ToString();
                //keystringval = keystringval.Replace("'", "''").Replace("<br>", "").Trim();
                //Label lbllogic = (Label)e.Row.FindControl("lbllogic");
                //string lbllogicval = lbllogic.Text.ToString();
                //lbllogicval = lbllogicval.Replace("'", "''").Replace("<br>", "").Trim();
                //DataSet ds = ad_obj.GetCategoryAndQuestions(keystringval, "GETCATEGORYNAME");
                //if (ds.Tables[0].Rows.Count > 0)
                //{
                //    string catname = "", quesname = "";
                //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                //    {
                //        catname += ds.Tables[0].Rows[i]["FINAL_CATEGERY"].ToString().Trim() + ",<br>";
                //        quesname += ds.Tables[0].Rows[i]["QUESTION"].ToString().Trim() + ",<br>";
                //    }
                //    catname = catname.Remove(catname.Length - 5, 1);
                //    quesname = quesname.Remove(quesname.Length - 5, 1);
                //    lblcat.Text = catname;
                //    lblquestion.Text = quesname;
                //}
                //ds.Dispose();
                //Image imgurl = (Image)e.Row.FindControl("editor_image");
                HyperLink btnedit = (HyperLink)e.Row.FindControl("btnedit");
                //btnedit.NavigateUrl = ResolveUrl("~/admin/map_natal_data.aspx?table=" + TableName + "&keystring=" + lblkeystring.Text.Trim() + "&logic=" + lbllogic.Text.Trim() + "&autoid=" + lblautoid.Text.Trim() + "");
                btnedit.NavigateUrl = ResolveUrl("~/admin/UpdatePredictiveUsingUniqueId.aspx?table=" + TableName + "&uniqueid=" + lbluniqueid.Text.Trim() + "");

                //HyperLink btnaddcat = (HyperLink)e.Row.FindControl("btnaddcat");
                //btnaddcat.NavigateUrl = ResolveUrl("~/admin/natal_update_predictive.aspx?table=" + TableName + "&keystring=" + lblkeystring.Text.Trim() + "&logic=" + lbllogic.Text.Trim() + "");

               
            }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(2000);
        bindgridnews();
        BindPredictiveCount();
    }
    void bindgridnews()
    {
        try
        {
            PredictiveTypeVal = ddlpredictivetype.SelectedValue.Trim();
            TableName = ddltable.SelectedValue.Trim();
            KeystringVal = ddlkeystring.SelectedValue.Trim();
            LogicVal = ddllogic.SelectedValue.Trim();
            if (LogicVal.IndexOf("Select") > -1)
            {
                LogicVal = "";
            }
            if (KeystringVal.IndexOf("Select") > -1)
            {
                KeystringVal = "";
            }
            if (LogicVal == "")
            {
                LogicVal = txtsrch.Text.ToString().Trim();
               //LogicVal = LogicVal.Replace(" ", "~").Trim();
            }
            KeystringVal = KeystringVal.Replace("'", "''");
            LogicVal = LogicVal.Replace("'", "''");
            //DataSet ds = ad_obj.GetNatalFilters(TableName, KeystringVal, LogicVal,"", "GET");
            DataSet ds = ad_obj.Get_Natal_Search_Predictives("", "~", TableName, KeystringVal.ToUpper(), LogicVal.ToUpper(), PredictiveTypeVal,"", "","", "", "", "GET");
            if (ds.Tables[0].Rows.Count > 0)
            {
                lbl_result.InnerHtml = "Search Found  <font size=\"3\" color=\"red\">" + ds.Tables[0].Rows.Count.ToString() + "</font> result(s).";
                grdData.DataSource = ds;
                grdData.DataBind();
            }
            else
            {
                lbl_result.InnerHtml = "Search Found  <font size=\"3\" color=\"red\">0</font> result(s).";
                ds = null;
                grdData.DataSource = ds;
                grdData.DataBind();
            }
            ds.Dispose();
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        common.ClearAllControls(Page.Controls);
        DataSet ds = new DataSet();
        ds = null;
        grdData.DataSource = ds;
        grdData.DataBind();
    }
}