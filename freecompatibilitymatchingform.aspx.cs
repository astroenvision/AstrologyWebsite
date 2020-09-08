using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class freecompatibilitymatchingform : System.Web.UI.Page
{

    #region Declarations
    string Flag = "";
    subscription obj = new subscription();
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserEmailID"] == null)
        {
            Response.Redirect(ResolveUrl("signin.html?flag=free-kundli-matching"));
        }
        if (!IsPostBack)
        {
            BindPrice();

            string Domainurl = Request.Url.Scheme + System.Uri.SchemeDelimiter + Request.Url.Host;
            string url = Domainurl + HttpContext.Current.Request.RawUrl;
            HtmlLink tag = new HtmlLink();
            tag.Attributes.Add("rel", "canonical");
            tag.Href = url;
            //Header.Controls.Add(tag);  // This Line is used without Master Page
            Master.FindControl("head").Controls.Add(tag); // This Line is used with Master Page
        }

    }
    #endregion

    #region Bind Price
    protected void BindPrice()
    {
        DataSet ds = new DataSet();
        ds = obj.AstGetCommon("28", "", "", "GET_KUNDLI_MATCHING");
        if(ds.Tables[0].Rows.Count >0)
        {
            thPrice.InnerHtml = "<label style ='color: white; font-weight: normal'>Total Price </label><label style ='color: white;'>₹"+ ds.Tables[0].Rows[0]["PAYABLE_PRICE"].ToString() + " (" + ds.Tables[0].Rows[0]["DISCOUNT"].ToString() +"%)<br/><span style = 'text-decoration: line-through;' >₹"+ ds.Tables[0].Rows[0]["ACTUAL_PRICE"].ToString() +"</span></label>";
        }
    }
    #endregion

    //protected void btnnext_Click(object sender, EventArgs e)
    //{
    //    if (maleid.Checked == true)
    //    {
    //        Flag = "M";
    //    }
    //    else if (femaleid.Checked == true)
    //    {
    //        Flag = "F";
    //    }
    //    Response.Redirect(ResolveUrl("~/freecompatibilitymatching.aspx?flag=" + Flag.Trim() + ""));
    //}

    #region Boy to Girl Click
    protected void lnkboytogirl_Click(object sender, EventArgs e)
    {
        Response.Redirect(ResolveUrl("~/freecompatibilitymatching.aspx?flag=M"));
    }
    #endregion

    #region Girl to Boy Click
    protected void lnkgirltoboy_Click(object sender, EventArgs e)
    {
        Response.Redirect(ResolveUrl("~/freecompatibilitymatching.aspx?flag=F"));
    }
    #endregion
}