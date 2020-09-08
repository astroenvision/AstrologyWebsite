using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TalkToAstrologers_old : System.Web.UI.Page
{

    #region Declarations
    admin obj = new admin();
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            BindAstrologers();
        }

    }
    #endregion

    #region Bind Astrologer
    protected void BindAstrologers()
    {
        StringBuilder strhtml = new StringBuilder();
        DataSet ds = new DataSet();
        ds = obj.ManageMapingDetails("GET_ASTROLOGER", "", "", "","","","","","");
        string UserID = "0";
        string CartID = "0";
        string UserEmailID = "0";
        if (Session["UserID"] != null)
        {
            UserID = Session["UserID"].ToString();
        }
        if (Session["MySessionID"] != null)
        {
            CartID = Session["MySessionID"].ToString();
        }
        if (Session["UserEmailID"] != null)
        {
            UserEmailID = Session["UserEmailID"].ToString();
        }
        
      if (ds.Tables[0].Rows.Count > 0)
        {
            for(int i =0; i<ds.Tables[0].Rows.Count; i++)
            {
                string Image = ds.Tables[0].Rows[i]["PHOTO"].ToString();

                if (Image != "")
                {
                    Image = "img/" + Image + "";
                }
                else
                {
                    Image = "img/Default.jpg";
                }
                DataSet dsAs = new DataSet();
                string Rating = ds.Tables[0].Rows[i]["RATING"].ToString();
                if(Rating == "")
                {
                    Rating = "4";
                }
                dsAs = obj.ManageAstrologerPrice("GET_PRICE_DETAILS", "", ds.Tables[0].Rows[i]["USER_ID"].ToString(), "","", "", "", "", "", "", "", "","","");
                strhtml.Append("<li class='d-flex'>");
                strhtml.Append("<div class='tpic'>");
                strhtml.Append("<img src='"+ Image + "'/>");
                strhtml.Append("</div>");
                strhtml.Append("<div class='tdtl'>");
                strhtml.Append("<div class='tttle'>"+ ds.Tables[0].Rows[i]["NAME"].ToString() +"</div>");
                strhtml.Append("<div class='tttle-sb'>" + ds.Tables[0].Rows[i]["EXPERT_IN"].ToString() + "</div>");
                strhtml.Append("<div class='ttbatag'>");
                strhtml.Append("<span class='spinle'><img class='strrtng' src='img/Rating.png'/> " + Rating + " Rating</span>");
                strhtml.Append("<span class='spinle'>876 Comments</span>");
                strhtml.Append("<span class='spinle'>2345 Views</span>");
                strhtml.Append("</div>");
                strhtml.Append("<div class='tstdtl'>" + ds.Tables[0].Rows[i]["SMALL_DESC"].ToString() + "</div>");

                strhtml.Append("<div class='cfss d-flex'>");
                if(dsAs.Tables[0].Rows.Count > 0 )
                {
                    for(int j =0; j< dsAs.Tables[0].Rows.Count; j++)
                    {
                        strhtml.Append("<div class='cfssblk d-flex'>");
                        strhtml.Append("<input type ='radio' runat='server' id='AstroPrice_" + j + "'  name='AstroPrice_" + i + "' class='rdoast' onclick='SetPayment(this.id)'>");
                        strhtml.Append("<input type = 'hidden' value = " + dsAs.Tables[0].Rows[j]["DISCOUNT_INR"].ToString() + " id = 'hdnDiscountAmonut_" + j + "'>");
                        strhtml.Append("<input type = 'hidden' value = " + dsAs.Tables[0].Rows[j]["PRICE_INR"].ToString()  + " id = 'hdnActualAmonut_" + j + "'>");
                        strhtml.Append("<input type = 'hidden' value = " + dsAs.Tables[0].Rows[j]["FINAL_PRICE_INR"].ToString() + " id = 'hdnPayableAmount_" + j + "'>");
                        strhtml.Append("<div><span>for "+dsAs.Tables[0].Rows[j]["NO_OF_MINUTES"].ToString() + " minutes : ₹  " + dsAs.Tables[0].Rows[j]["FINAL_PRICE_INR"].ToString() + " </span>tax included</div>");
                        strhtml.Append("</div>");
                    }
                }
                strhtml.Append("</div>");
                strhtml.Append("<div class='btnsec'>");
                strhtml.Append("<div class='btn btn-info btn-sm'>CALL NOW</div>");
                strhtml.Append("<div style='margin-left: 7px;' class='btn btn-primary btn-sm' Onclick=\"btnBook_Click('INSERT_PAYMENT_IN_TEMP','" + CartID + "' , '" + UserID + "' , '" + UserEmailID + "' , 'INR');\">BOOK NOW</div>");
                strhtml.Append("</div>");
                strhtml.Append("</div>");
                strhtml.Append("</li>");
            }
        }
        ulAstrologer.InnerHtml = strhtml.ToString();
    }
    #endregion
}