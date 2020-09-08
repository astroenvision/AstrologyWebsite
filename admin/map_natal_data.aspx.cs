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

public partial class admin_map_natal_data : System.Web.UI.Page
{
    common cs_obj = new common();
    admin ad_obj = new admin();
    subscription sub_obj = new subscription();
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    public string AdminUserId = "", AdminEmailId = "";
    string Cid = "", Qid = "", Ques = "", TableName = "", KeyString = "", Logic = "", ResultVal = "", ResultUpdateVal = "", Id="";
    bool flagcheck = false, flagnewpredictive = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(admin_map_natal_data));

        if (AdminStateManagement == "COOKIE")
        {
            if (Request.Cookies["AdminCookies"] != null)
            {
                AdminUserId = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
                if (!Page.IsPostBack)
                {
                    ddlbooks.Attributes.Add("onchange", "javascript:return bind_subbooks();");
                    if (Request["table"] != null && Request["table"].ToString() != "")
                    {
                        BindNatalCategories();
                        ddltable.SelectedValue = Request["table"].ToString().Trim();
                        bindgridnews();
                        bind_books();
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
                if (!Page.IsPostBack)
                {
                    ddlbooks.Attributes.Add("onchange", "javascript:return bind_subbooks();");
                    if (Request["table"] != null && Request["table"].ToString() != "")
                    {
                        BindNatalCategories();
                        ddltable.SelectedValue = Request["table"].ToString().Trim();
                        bindgridnews();
                        bind_books();
                    }
                }
            }
            else
            {
                Response.Redirect(ResolveUrl("~/admin"));
                return;
            }
        }

        //if (Session["adminuseremail"] != null && Session["adminuseremail"] != null)
        //{
        //    if (!Page.IsPostBack)
        //    {
        //        ddlbooks.Attributes.Add("onchange", "javascript:return bind_subbooks();");
        //        if (Request["table"] != null && Request["table"].ToString() != "")
        //        {
        //            BindNatalCategories();
        //            ddltable.SelectedValue = Request["table"].ToString().Trim();
        //            bindgridnews();
        //            bind_books();
        //        }
        //    }
        //}
        //else
        //{
        //    //ScriptManager.RegisterClientScriptBlock(this, typeof(myaccount), "wq", "window.parent.location.href='loginadmin.aspx';", true);
        //    Response.Redirect(ResolveUrl("~/loginadmin.aspx"));
        //    return;
        //}        
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

    void bind_books()
    {
        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
        DataSet ds = country.bookbind("0");
        ddlbooks.Items.Clear();
        ddlbooks.DataSource = ds;
        ddlbooks.DataTextField = "CODE";
        ddlbooks.DataValueField = "CODE";
        ddlbooks.DataBind();
        ddlbooks.Items.Insert(0, "--Select--");
        ds.Dispose();
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
        if (ddlfilter.SelectedValue.ToString() != "0" || ddlfilter.SelectedValue.ToString() != "--Select Filter--")
        {
            //txtkeystringnew.Text = ddlfilter.SelectedItem.Text.ToString();
        }
        else
        {
            txtkeystringnew.Text = "";
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
                string keystringval = "";
                Label lblkeystring = (Label)e.Row.FindControl("lblkeystring");
                keystringval = lblkeystring.Text.ToString();
                Label lblcat = (Label)e.Row.FindControl("lblcat");
                Label lblquestion = (Label)e.Row.FindControl("lblquestion");
                keystringval = keystringval.Replace("'", "''").Replace("<br>", "").Trim();
                DataSet ds = ad_obj.GetCategoryAndQuestions(keystringval, "GETCATEGORYNAME");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    lblcat.Text = ds.Tables[0].Rows[0]["FINAL_CATEGERY"].ToString().Trim();
                    lblquestion.Text = ds.Tables[0].Rows[0]["QUESTION"].ToString().Trim();
                }
                ds.Dispose();

                //TextBox txtpredictive = (TextBox)e.Row.FindControl("lblpredictive");
                //txtpredictive.Attributes["onclick"] = "javascript:return rowno('" + e.Row.RowIndex + "')";

                CheckBox cbRowsid = (CheckBox)e.Row.FindControl("cbRows");
                cbRowsid.Attributes["onclick"] = "javascript:return rowno(this,'" + e.Row.RowIndex + "')";

                Label lblpredictivetype = (Label)e.Row.FindControl("lblpredictivetype");
                DropDownList ddlpredictive = (DropDownList)e.Row.FindControl("ddlpredictive");
                if (lblpredictivetype.Text!="")
                {
                    ddlpredictive.SelectedValue = lblpredictivetype.Text.ToString().Trim();
                }
            }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    protected void btninsert_Click(object sender, EventArgs e)
    {
        try
        {
            for (Int32 I32Counter = 0; I32Counter < grdviews.Rows.Count; I32Counter++)
            {
                Label lbllogic = (Label)(grdviews.Rows[I32Counter].FindControl("lbllogic"));
                Label lblkeystring = (Label)(grdviews.Rows[I32Counter].FindControl("lblkeystring"));
                //int catid = Convert.ToInt32(lblcat_id.Text.Trim().ToString());
                Label lblhouse = (Label)(grdviews.Rows[I32Counter].FindControl("lblhouse"));
                Label lblplanet = (Label)(grdviews.Rows[I32Counter].FindControl("lblplanet"));
                Label lblrashi = (Label)(grdviews.Rows[I32Counter].FindControl("lblrashi"));
                //TextBox lblpredictive = (TextBox)(grdviews.Rows[I32Counter].FindControl("lblpredictive"));
                string rtepredictive = ((FCKeditor)grdviews.Rows[I32Counter].FindControl("rtepredictive")).Value;
                string rteremedial = ((FCKeditor)grdviews.Rows[I32Counter].FindControl("rteremedial")).Value;

                Label lblcombination = (Label)(grdviews.Rows[I32Counter].FindControl("lblcombination"));
                Label lbllagnarashi = (Label)(grdviews.Rows[I32Counter].FindControl("lbllagnarashi"));
                Label lbluniqueid = (Label)(grdviews.Rows[I32Counter].FindControl("lbluniqueid"));
                Label lblbook = (Label)(grdviews.Rows[I32Counter].FindControl("lblbook"));

                Label lblpredictivetype = (Label)(grdviews.Rows[I32Counter].FindControl("lblpredictivetype"));
                //DropDownList ddlpredictive = (DropDownList)(grdviews.Rows[I32Counter].FindControl("ddlpredictive"));

                CheckBox cbRows = (CheckBox)(grdviews.Rows[I32Counter].FindControl("cbRows"));

                if (cbRows.Checked == true)
                {
                    flagcheck = true;
                    flagnewpredictive = false;
                    string housevalnew = "", planetvalnew = "", rashivalnew = "", filtervalnew = "", descvalnew = "",
                         predictivenew = "", remedialnew, combination = "", uniqueidvalnew = "", selquestionval = "", predictivetypeval = "", namevalnew = "", chartvalnew = "";
                    housevalnew = lblhouse.Text;
                    planetvalnew = lblplanet.Text;
                    rashivalnew = lblrashi.Text;
                    descvalnew = lbllogic.Text.Trim();   // logic
                    combination = lblcombination.Text.Trim();

                    filtervalnew = txtkeystringnew.Text.Trim();    //Filter/keystring

                    if (ddlquestion.SelectedValue != "0" && ddlquestion.SelectedValue != "" && ddlquestion.SelectedValue != "--Select Question--")
                    {
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(admin_map_natal_data), "wq", "alert('Please select any question!');", true);
                        return;
                    }

                    if (txtuniqueid.Text != "")
                    {
                        uniqueidvalnew = txtuniqueid.Text.Trim();
                    }
                    else
                    {
                        uniqueidvalnew = lblbook.Text.Trim();
                    }

                    //predictivenew = txtpredictivenew.Text.Trim();   // predictive
                    predictivenew = rtepredictivenew.Value.Trim();   // predictive
                    if (predictivenew == "")
                    {
                        //predictivenew = lblpredictive.Text.Trim();
                        predictivenew = rtepredictive;
                    }

                    //remedialnew = txtremedialnew.Text.Trim();   // remedial
                    remedialnew = rteremedialnew.Value.Trim();   // remedial
                    if (remedialnew == "")
                    {
                        remedialnew = rteremedial;
                    }

                    TableName = Request["table"].ToString().Trim();

                    if (ddlfilter.SelectedValue != "0" && ddlfilter.SelectedValue != "" && ddlfilter.SelectedValue != "--Select Filter--")
                    {
                        filtervalnew = ddlfilter.SelectedItem.Text.Trim();
                    }
                    else if (txtkeystringnew.Text != "")
                    {
                        filtervalnew = txtkeystringnew.Text.ToString();
                        flagnewpredictive = true;
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(admin_map_natal_data), "wq", "alert('Please select any keystring/filter!');", true);
                        return;
                    }

                    string subbookval = ddlsubbooks.SelectedValue.Trim().ToString();
                    if (subbookval != "" || subbookval != "0")
                    {
                        subbookval = lblbook.Text.Trim().ToString();
                    }
                    predictivetypeval = ddlpredictivetype.SelectedValue.ToString().Trim();
                    if (predictivetypeval == "0")
                    {
                        predictivetypeval = lblpredictivetype.Text.Trim().ToString();
                    }
                    if (predictivetypeval == "")
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(admin_map_natal_data), "wq", "alert('Please select predictive type!');", true);
                        return;
                    }

                    DataSet dsinp = new DataSet();
                    DataSet dsinpc = new DataSet();
                    if (predictivenew != "")
                    {
                        dsinp = ad_obj.Insert_Natal_Predictives(lblhouse.Text, lblplanet.Text, lblrashi.Text, lblkeystring.Text, lbllogic.Text, "", "", subbookval, "", lbluniqueid.Text, "", "", TableName, "INSERT", housevalnew, planetvalnew, rashivalnew, filtervalnew, descvalnew, namevalnew, chartvalnew, predictivenew, remedialnew, uniqueidvalnew, combination, lbllagnarashi.Text, predictivetypeval, int.Parse("0"),"","","","","");
                        if (dsinp.Tables[0].Rows.Count > 0)
                        {
                            ResultVal = dsinp.Tables[0].Rows[0]["flag"].ToString();
                        }
                    }
                    //if (ResultVal == "Y" && flagnewpredictive == true)
                    //{
                    //    if (ddlquestion.SelectedValue != "0" && ddlquestion.SelectedValue != "" && ddlquestion.SelectedValue != "--Select Question--")
                    //    {
                    //        selquestionval = ddlquestion.SelectedItem.Text.Trim();
                    //    }
                    //    dsinpc = ad_obj.Insert_Natal_Predictives_Cat(ddlcategory.SelectedItem.Text.Trim(), selquestionval, filtervalnew, predictivenew, TableName, "INSERT");
                    //}
                    dsinp.Dispose();
                    dsinpc.Dispose();
                }
            }

            if (flagcheck == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_map_natal_data), "wq", "alert('Please check any checkbox!');", true);
                return;
            }
            if (flagcheck == true)
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_map_natal_data), "wq", "alert('Data Save Successfully!');", true);
                return;
            }
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
            for (Int32 I32Counter = 0; I32Counter < grdviews.Rows.Count; I32Counter++)
            {
                Label lblautoid = (Label)(grdviews.Rows[I32Counter].FindControl("lblautoid"));
                CheckBox cbRows = (CheckBox)(grdviews.Rows[I32Counter].FindControl("cbRows"));
                Label lblkeystring = (Label)(grdviews.Rows[I32Counter].FindControl("lblkeystring"));
                Label lbluniqueid = (Label)(grdviews.Rows[I32Counter].FindControl("lbluniqueid"));
                //TextBox lblpredictive = (TextBox)(grdviews.Rows[I32Counter].FindControl("lblpredictive"));
                string rtepredictive = ((FCKeditor)grdviews.Rows[I32Counter].FindControl("rtepredictive")).Value;
                string rteremedial = ((FCKeditor)grdviews.Rows[I32Counter].FindControl("rteremedial")).Value;
                DropDownList ddlpredictive = (DropDownList)(grdviews.Rows[I32Counter].FindControl("ddlpredictive"));
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
                    dspu = ad_obj.Insert_Natal_Predictives("HouseNone", "PlanetNone", "RashiNone", lblkeystring.Text, "Logic", "Name", "Chart", "Subbook", "Page", lbluniqueid.Text, rtepredictive, rteremedial, TableName, "UPDATE", "HouseNew", "PlanetNew", "RashiNew", "FilterNew", "LogicNew", "NameNew", "ChartNew", "PredictiveNew", "RemedialNew", "UniqueidNew", "Combination", "LagnaRashi", PreType, int.Parse(lblautoid.Text.ToString()), "", "","","","");
                    if (dspu.Tables[0].Rows.Count > 0)
                    {
                        ResultUpdateVal = dspu.Tables[0].Rows[0]["flag"].ToString();
                    }
                    dspu.Dispose();
                }
            }
            if (flagcheck == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_map_natal_data), "wq", "alert('Please check any checkbox!');", true);
                return;
            }
            if (flagcheck == true && ResultUpdateVal == "Y")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_map_natal_data), "wq", "alert('Data Update Successfully!');", true);
                return;
            }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    protected void btndelete_Click(object sender, EventArgs e)
    {
        try
        {
            for (Int32 I32Counter = 0; I32Counter < grdviews.Rows.Count; I32Counter++)
            {
                Label lblautoid = (Label)(grdviews.Rows[I32Counter].FindControl("lblautoid"));
                CheckBox cbRows = (CheckBox)(grdviews.Rows[I32Counter].FindControl("cbRows"));
                Label lblkeystring = (Label)(grdviews.Rows[I32Counter].FindControl("lblkeystring"));
                Label lbluniqueid = (Label)(grdviews.Rows[I32Counter].FindControl("lbluniqueid"));
                //TextBox lblpredictive = (TextBox)(grdviews.Rows[I32Counter].FindControl("lblpredictive"));
                string rtepredictive = ((FCKeditor)grdviews.Rows[I32Counter].FindControl("rtepredictive")).Value;
                string rteremedial = ((FCKeditor)grdviews.Rows[I32Counter].FindControl("rteremedial")).Value;
                DropDownList ddlpredictive = (DropDownList)(grdviews.Rows[I32Counter].FindControl("ddlpredictive"));
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
                    dspu = ad_obj.Insert_Natal_Predictives("HouseNone", "PlanetNone", "RashiNone", lblkeystring.Text, "Logic", "Name", "Chart", "Subbook", "Page", lbluniqueid.Text, rtepredictive, rteremedial, TableName, "DELETE", "HouseNew", "PlanetNew", "RashiNew", "FilterNew", "LogicNew", "NameNew", "ChartNew", "PredictiveNew", "RemedialNew", "UniqueidNew", "Combination", "LagnaRashi", PreType, int.Parse(lblautoid.Text.ToString()),"","","","","");
                    if (dspu.Tables[0].Rows.Count > 0)
                    {
                        ResultUpdateVal = dspu.Tables[0].Rows[0]["flag"].ToString();
                    }
                    dspu.Dispose();
                }
            }
            if (flagcheck == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_map_natal_data), "wq", "alert('Please check any checkbox!');", true);
                return;
            }
            if (flagcheck == true && ResultUpdateVal == "Y")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_map_natal_data), "wq", "alert('Data Delete Successfully!');", true);
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
   
    void bindgridnews()
    {
        try
        {
            if (Request["table"] != null && Request["table"].ToString() != "")
            {
                TableName = Request["table"].ToString().Trim();
                //KeyString = Request["keystring"].ToString().Trim();
                KeyString="";
                Id = Request["autoid"].ToString().Trim();
                KeyString = KeyString.Replace("'", "''").Replace("<br>", "").Trim();
                //Logic = Request["logic"].ToString().Trim();
                Logic = "";
                Logic = Logic.Replace("'", "''").Replace("<br>", "").Trim();
                //DataSet ds = ad_obj.GetNatalFilters(TableName, KeyString, Logic, "EDIT");
                DataSet ds = ad_obj.GetNatalFilters(TableName, KeyString, Logic, Id, "GET_USING_ID");
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
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }


    [Ajax.AjaxMethod]
    public DataSet bindbook(string fil)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.bookbind(fil);
            ds.Dispose();
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet getbookname(string book, string fil)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.bindbooknames(book, fil);
            ds.Dispose();
        }
        return ds;
    }

    protected void ddlbooks_SelectedIndexChanged(object sender, EventArgs e)
    {
        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
        string bookselval = ddlbooks.SelectedValue.ToString().Trim();
        if (bookselval != "")
        {
            DataSet ds = country.bindbooknames(bookselval, "0");
            ddlsubbooks.Items.Clear();
            ddlsubbooks.DataSource = ds;
            ddlsubbooks.DataTextField = "NAME";
            ddlsubbooks.DataValueField = "NAME";
            ddlsubbooks.DataBind();
            ddlsubbooks.Items.Insert(0, "--Select--");
            ds.Dispose();
        }
    }
}
