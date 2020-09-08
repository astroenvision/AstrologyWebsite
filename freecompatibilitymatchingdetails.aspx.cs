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
using System.Net;
using ASTROLOGY.classesoracle;

public partial class freecompatibilitymatchingdetails : System.Web.UI.Page
{
    compatibilitymatching cm = new compatibilitymatching();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["userid"] != null)
            {
                string UId = Request.QueryString["userid"].Trim();
                BindGrid(UId);
                btnproceed.Attributes.Add("onclick", "javascript:return Get_CompatibilityMatching();");
            }
        }
    }
    protected void btnproceed_Click(object sender, EventArgs e)
    {

    }
    void BindGrid(string Id)
    {
        DataSet ds = new DataSet();
        ds = cm.GetMatchingUserDetails(Id, "GET_MATCHING_USER_DETAILS");
        if (ds.Tables[0].Rows.Count > 0)
        {
            Gv1.DataSource = ds.Tables[0];
            Gv1.DataBind();
            Gv2.DataSource = ds.Tables[1];
            Gv2.DataBind();
            if (ds.Tables[0].Rows[0]["GENDER"].ToString().Trim() == "M")
            {
                hdnboyid.Value = ds.Tables[0].Rows[0]["ID"].ToString().Trim();
                Gv1Head.InnerText = "Boy's Birth Detail";
            }
            else
            {
                hdngirlid.Value = ds.Tables[0].Rows[0]["ID"].ToString().Trim();
                Gv1Head.InnerText = "Girl's Birth Detail";
            }
            if (ds.Tables[1].Rows[0]["GENDER"].ToString().Trim() == "M")
            {
                hdnboyid.Value = ds.Tables[1].Rows[0]["ID"].ToString().Trim();
                Gv2Head.InnerText = "Boy's Birth Detail";
            }
            else
            {
                hdngirlid.Value = ds.Tables[1].Rows[0]["ID"].ToString().Trim();
                Gv2Head.InnerText = "Girl's Birth Detail";
            }
        }
        else
        {
            Gv1.DataSource = null;
            Gv1.DataBind();
            Gv2.DataSource = null;
            Gv2.DataBind();
        }
        ds.Dispose();
    }
    protected void Gv1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "DeleteRecord")
        {
            // get the categoryID of the clicked row
            int categoryID = Convert.ToInt32(e.CommandArgument);
            // Delete the record 
            //DeleteRecordByID(categoryID);
            // Implement this on your own :) 
        }
    }
    protected void Gv1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            DataRowView drv = e.Row.DataItem as DataRowView;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton l = (LinkButton)e.Row.FindControl("LinkButton1");
                l.Attributes.Add("onclick", "javascript:return " +
                "confirm('Are you sure you want to delete this record')");
            }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    protected void Gv2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "DeleteRecord")
        {
            // get the categoryID of the clicked row
            int categoryID = Convert.ToInt32(e.CommandArgument);
            // Delete the record 
            //DeleteRecordByID(categoryID);
            // Implement this on your own :) 
        }
    }
    protected void Gv2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            DataRowView drv = e.Row.DataItem as DataRowView;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton l = (LinkButton)e.Row.FindControl("LinkButton1");
                l.Attributes.Add("onclick", "javascript:return " +
                "confirm('Are you sure you want to delete this record')");
            }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
}