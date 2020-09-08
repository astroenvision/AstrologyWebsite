using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class product : System.Web.UI.Page
{
    #region Declarations
    admin obj = new admin();
    subscription sub = new subscription();
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindProduct();
        }

    }
    #endregion

    #region Bind Product
    protected void  BindProduct()
    {
        Session["CurrentCartValue"] = "Product";
        StringBuilder strhtml = new StringBuilder();
        DataSet ds = new DataSet();
        ds = sub.GetProduct("GET_PRODUCT", "","","");
        if (ds.Tables[0].Rows.Count > 0)
        {
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
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string ImageURL = ds.Tables[0].Rows[i]["SMALL_IMAGE"].ToString();
                string Path = Page.ResolveUrl("gall_content/" + ImageURL).Replace("/admin", "");
                strhtml.Append("<div class='col-sm-4 form-group'>");
                strhtml.Append("<div class='yntrprodbx'>");
                strhtml.Append("<div class='yntrhdr'><a title=\"" + ds.Tables[0].Rows[i]["PRODUCT_NAME"].ToString() + "\" href =\"" + ResolveUrl("~/product/" + ds.Tables[0].Rows[i]["PRODUCT_URL"].ToString() + ".html") + "\">"+ ds.Tables[0].Rows[i]["PRODUCT_NAME"].ToString() +"</a></div>");
                strhtml.Append("<div class='d-flex proddtlz'>");
                strhtml.Append("<div class='propic'>");
                strhtml.Append("<a title=\"" + ds.Tables[0].Rows[i]["PRODUCT_NAME"].ToString() + "\" href =\"" + ResolveUrl("~/product/" + ds.Tables[0].Rows[i]["PRODUCT_URL"].ToString() + ".html") + "\"><img class='dscphto' src='" + Path + "'/></a>");
                strhtml.Append("</div>");
                strhtml.Append("<div class='prodscz'>");
                strhtml.Append("<div class='prdsrtdsc'>" + ds.Tables[0].Rows[i]["SHORT_DESC"].ToString() + "</div>");
                strhtml.Append("<div class='rdmr'><a title=\"" + ds.Tables[0].Rows[i]["PRODUCT_NAME"].ToString() + "\" href =\"" + ResolveUrl("~/product/" + ds.Tables[0].Rows[i]["PRODUCT_URL"].ToString() + ".html") + "\">Read More...</a></div>");
			    strhtml.Append("</div>");
                strhtml.Append("</div>");
                strhtml.Append("<div class='yusrprc d-flex justify-content-between align-items-center'>");
                strhtml.Append("<div class='strrtuzr'><i class='fa fa-star'></i> 100+ Users</div>");
                strhtml.Append("<div class='yntprcz'>₹" + ds.Tables[0].Rows[i]["TOTAL_AMOUNT_INR"].ToString() + "</div>");
                strhtml.Append("</div>");
                strhtml.Append("<div Onclick=\"ProductAddToCart('INSERT_INTO_CART' ,'', '"+ CartID + "', '"+ ds.Tables[0].Rows[i]["PRODUCT_ID"].ToString() + "', '1' , '" + ds.Tables[0].Rows[i]["PRODUCT_DIMENSION"].ToString() + "' , '"+ ds.Tables[0].Rows[i]["PRODUCT_WEIGHT"].ToString() + "' , '" + ds.Tables[0].Rows[i]["PRODUCT_PRICE_INR"].ToString() + "' , '" + ds.Tables[0].Rows[i]["DISCOUNT_INR"].ToString() + "', '" + ds.Tables[0].Rows[i]["TOTAL_AMOUNT_INR"].ToString() + "', '"+ UserID+"' , '"+ UserEmailID +"' );\" class='cartsecz'>");
                strhtml.Append("<div class='adtocrtdft'><i class='fa fa-shopping-cart'></i> Add to Cart</div>");
                strhtml.Append("</div>");
                strhtml.Append("</div>");
                strhtml.Append("</div>");
         }
       }
        divProduct.InnerHtml = strhtml.ToString();
   }
    #endregion
}