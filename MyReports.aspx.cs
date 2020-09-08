using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyReports : System.Web.UI.Page
{
    common common = new common();
    public string EmailID = "";

    #region PageLoad
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["UserEmailID"] != null)
            {
                EmailID = Session["UserEmailID"].ToString();

                if (EmailID != "")
                {
                    BindReport();
                }
            }
            else
            {
                Response.Redirect(ResolveUrl("~/index.html"));
            }
         }
    }
    #endregion

    #region Bind Report
    protected void BindReport()
    {
        try
        {
            DataSet ds = new DataSet();
            ds = common.GetMyReport("GET_USER_REPORT", "", EmailID, "NATAL");
            if(ds.Tables[0].Rows.Count > 0)
            {
                grdData.DataSource = ds.Tables[0];
                grdData.DataBind();
            } 
            else
            {
                grdData.DataSource = null;
                grdData.DataBind();
            }
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }
    #endregion

    #region Grid Events
    protected void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdData.PageIndex = e.NewPageIndex;
        BindReport();
    }
    protected void grdData_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label lblPaymentFor = (Label)e.Row.FindControl("lblPaymentFor");
            Label lblCartID = (Label)e.Row.FindControl("lblCartID");
            Label lblCLientID = (Label)e.Row.FindControl("lblCLientID");
            Label lblUserMailID = (Label)e.Row.FindControl("lblUserMailID");
            HyperLink lnkShowReport = (HyperLink)e.Row.FindControl("lnkShowReport");

            if (lblPaymentFor.Text == "NATAL_CATEGORY")
            {
                lnkShowReport.NavigateUrl = "~/thankyou_ccavenue.aspx?cartid="+ lblCartID.Text + "&clientid="+ lblCLientID.Text + "&clientemailid="+ lblUserMailID.Text + "&group="+ "NATAL";
            }
            else if (lblPaymentFor.Text == "KUNDALI_MATCHING")
            {
                //Response.Redirect(ResolveUrl("~/compatibilitymatchingreport.aspx?BoyId=" + CartID + "&GirlId=" + CartID + ""));
                lnkShowReport.NavigateUrl = "~/compatibilitymatchingreport.aspx?cartid=" + lblCartID.Text + "";
            }
            else if (lblPaymentFor.Text == "CONSULT_ASTROLOGER")
            {
                lnkShowReport.NavigateUrl = "~/thankyou.html";
            }

            //NavigateUrl = 

        }
    }
  
    #endregion
}