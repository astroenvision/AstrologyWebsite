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

public partial class article_finalquestions : System.Web.UI.Page
{
    ASTROLOGY.classesoracle.main obj_main = new ASTROLOGY.classesoracle.main();
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    DataSet ds = new DataSet();
    DataSet ds1 = new DataSet();
    DataSet ds2 = new DataSet();
    DataSet dso = new DataSet();
    string PreviousPageURLFinal = "";
    string ActualPrice = "", FinalPrice = "", discountval="",Offerdtls = "";
    decimal discount, discountprice, FinalPriceVal;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.UrlReferrer != null)
            {
                PreviousPageURLFinal = Request.UrlReferrer.ToString();
            }
            if (Request.QueryString["cartid"] != null && Request.QueryString["cartid"] != "")
            {
                if (Request.QueryString["groupid"] != null)
                {
                    ViewState["GroupId"] = Request.QueryString["groupid"].ToString().Trim();
                    hdngroupid.Value = ViewState["GroupId"].ToString();
                    groupheaderid.InnerText = ViewState["GroupId"].ToString();
                }
                ViewState["cartid"] = Request.QueryString["cartid"].ToString().Trim();
                hdncartid.Value = ViewState["cartid"].ToString().Trim();
            }
            BindCartGrid();
        }
    }

    void BindCartGrid()
    {
        ds = obj_subs.GetAddToCart(ViewState["cartid"].ToString().Trim(), "", "", "", "GETALLQUESTIONS");
        if (ds.Tables[0].Rows.Count > 0)
        {
            //Session["myquery"] = HttpContext.Current.Request.Url.Query + "$" + ds.Tables[0].Rows.Count.ToString();
            Session["myquery"] = HttpContext.Current.Request.RawUrl + "$" + ds.Tables[0].Rows.Count.ToString();
            ViewState["GroupId"] = ds.Tables[0].Rows[0]["GROUP_ID"].ToString();

            ViewState["CountryCode"] = GetCountryCode();
            hdncountrycode.Value = ViewState["CountryCode"].ToString().Trim();

            if (ViewState["GroupId"].ToString().Trim().ToUpper() == "HORARY")
            {
                ds2 = obj_subs.GetCategoryPrice(ViewState["cartid"].ToString().Trim(), "2", ViewState["GroupId"].ToString().ToUpper(), "", "GETFINALPRICE");
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    if (ViewState["CountryCode"].ToString() == "IN")
                    {
                        FinalPrice = ds2.Tables[0].Rows[0]["FINALPRICE_INR"].ToString();
                        totalamt.InnerText = "Total Amount: Rs. " + FinalPrice + " (INR)";
                        TotalAmounts.Value = FinalPrice.ToString().Trim();
                    }
                    else
                    {
                        FinalPrice = ds2.Tables[0].Rows[0]["FINALPRICE_USD"].ToString();
                        totalamt.InnerText = "Total Amount: $ " + FinalPrice + " (USD)";
                        TotalAmounts.Value = FinalPrice.ToString().Trim();
                    }
                }
                ds2.Dispose();
                //offermaindiv.Visible = false;
            }
            if (ViewState["GroupId"].ToString().Trim().ToUpper() == "NATAL")
            {
                ds2 = obj_subs.GetCategoryPrice(ViewState["cartid"].ToString().Trim(), "2", ViewState["GroupId"].ToString().ToUpper(), "0", "GETFINALPRICE");
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    if (ViewState["CountryCode"].ToString() == "IN")
                    {
                        ActualPrice = ds2.Tables[0].Rows[0]["FINALPRICE"].ToString();
                        discountval = ds2.Tables[1].Rows[0]["DISCOUNT_INR"].ToString();
                        if (discountval != "" && discountval != "0")
                        {
                            discount = decimal.Parse(discountval);
                            discountprice = decimal.Parse(ActualPrice) * (discount / 100);
                            FinalPriceVal = decimal.Parse(ActualPrice) - discountprice;
                            FinalPrice = FinalPriceVal.ToString();
                            actualtotalamt.InnerHtml = "Amount: ₹ " + ActualPrice + "";
                            discountper.InnerHtml = "You Save: ₹ " + discountprice + " (" + discountval + "%)";
                        }
                        else
                        {
                            FinalPrice = ActualPrice;
                        }
                        totalamt.InnerText = "Total Fee Payable: ₹ " + FinalPrice + "";
                        TotalAmounts.Value = FinalPrice.ToString().Trim();
                    }
                    else
                    {
                        FinalPrice = ds2.Tables[0].Rows[0]["FINALPRICE_USD"].ToString();
                        totalamt.InnerText = "Total Amount: $ " + FinalPrice + " (USD)";
                        TotalAmounts.Value = FinalPrice.ToString().Trim();
                    }
                }
                ds2.Dispose();

                //dso = obj_subs.GetCategoryPrice(ViewState["cartid"].ToString().Trim(), "2", ViewState["GroupId"].ToString().ToUpper(), "", "CHECKFREEOFFER");
                //if (dso.Tables[0].Rows.Count > 0)
                //{
                //    offermaindiv.Visible = true;
                //    offermaindiv.Visible = true;
                //    Offerdtls = dso.Tables[0].Rows[0]["SERVICE_THIRD"].ToString();
                //    offerid.InnerText = Offerdtls;
                //}
                //else
                //{
                //    offermaindiv.Visible = false;
                //}
                //dso.Dispose();

            }

            //GvNatalQuestions.Visible = false;
            //NatalPanel.Visible = false;
            GvHoraryQuestions.Visible = true;
            HoraryPanel.Visible = true;
            btnproceedforpayment.Visible = true;
            GvHoraryQuestions.DataSource = ds;
            GvHoraryQuestions.DataBind();
            if (ViewState["GroupId"].ToString().Trim().ToUpper() == "HORARY")
            {
                btnaddmorecat.Visible = false;
            }
            if (ViewState["GroupId"].ToString().Trim().ToUpper() == "NATAL")
            {
                btnaddmorecat.Visible = true;
            }
        }
        else
        {
            Session["myquery"] = null;
            fullarticle_id.InnerHtml = "<h1 style='padding:3% 0% 0% 1%' class='fullarticle_catname_h1'>No Result !</h2>";
            //GvNatalQuestions.Visible = false;
            //NatalPanel.Visible = false;
            GvHoraryQuestions.Visible = false;
            HoraryPanel.Visible = false;
            totalamt.Visible = false;
            //btnnext.Visible = false;
            btnaddmorecat.Visible = false;
            btnproceedforpayment.Visible = false;
            Response.Redirect(ResolveUrl("~/login.aspx"));
        }
        ds.Dispose();
    }

    protected void GvHoraryQuestions_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            DataRowView drv = e.Row.DataItem as DataRowView;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label LblCatid = (Label)(e.Row.FindControl("lblcatid"));
                HyperLink btnEdit = (HyperLink)(e.Row.FindControl("btnedit"));
                btnEdit.NavigateUrl = ResolveUrl("~/article/questions.aspx?groupid=" + ViewState["GroupId"].ToString().Trim().ToLower() + "&catid=" + LblCatid.Text.ToString() + "&cartid=" + ViewState["cartid"].ToString().Trim() + ""); ;
               
                ds = obj_subs.AstGetCommon(LblCatid.Text.ToString().Trim(), "2", ViewState["GroupId"].ToString().Trim(), "CATEGORYNAME");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    LblCatid.Text = ds.Tables[0].Rows[0]["CATNAME"].ToString();
                }
                ds.Dispose();
            }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    protected void GvHoraryQuestions_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            Label lblcategoryid = (Label)GvHoraryQuestions.Rows[e.RowIndex].FindControl("lblcategoryid");
            string cid = lblcategoryid.Text.ToString().Trim();
            ds = obj_subs.AstDeleteCommon(cid, ViewState["cartid"].ToString().Trim(), "2", ViewState["GroupId"].ToString().Trim(), "DELETECART");
            if (ds.Tables[0].Rows.Count > 0)
            {
                string flag_chk = ds.Tables[0].Rows[0]["outresult"].ToString();
                if (flag_chk == "Y")
                {
                    //Session["myquery"] = null;
                    //Response.Redirect(ResolveUrl("~/login.aspx"));
                    Response.Redirect(ResolveUrl("" + HttpContext.Current.Request.RawUrl + ""));
                }
            }
            ds.Dispose();
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }

    protected void btnaddmorecat_Click(object sender, EventArgs e)
    {
        Response.Redirect(ResolveUrl("~/login.aspx?groupid=" + ViewState["GroupId"].ToString().Trim().ToLower() + ""));
    }
    protected void btnproceedforpayment_Click(object sender, EventArgs e)
    {
        if (chkboxreadtermsid.Checked == true)
        {
            DataSet dsb = new DataSet();
            dsb = obj_subs.AddToCartBilling(0, ViewState["cartid"].ToString(), TotalAmounts.Value.ToString(), hdngroupid.Value.Trim().ToUpper(), "F", "SAVEBILLING","", "");
            if (dsb.Tables[0].Rows.Count > 0)
            {
                string flagstatus = dsb.Tables[0].Rows[0]["flag"].ToString().Trim();
                if (flagstatus == "SUCCESS" || flagstatus == "EXIST")
                {
                    //Response.Redirect(ResolveUrl("~/user_registration.aspx?groupid=" + hdngroupid.Value.ToString().Trim().ToLower() + "&cartid=" + hdncartid.Value.ToString() + ""));
                    Response.Redirect(ResolveUrl("~/registration/" + hdngroupid.Value.ToString().Trim().ToLower() + "/" + hdncartid.Value.ToString() + ".html"));
                }
            }
            dsb.Dispose();
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(article_finalquestions), "wq", "alert('Please ensure the following accurate details are available with you before you proceed for payment.');", true);
            return;
        }
    }

    public string GetCountryCode()
    {
        string VisitorsIPAddr = string.Empty;
        if (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
        {
            VisitorsIPAddr = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
        }
        else if (HttpContext.Current.Request.UserHostAddress.Length != 0)
        {
            VisitorsIPAddr = HttpContext.Current.Request.UserHostAddress;
        }

        long w, x, y, z, IPNumber;
        //String hostName = System.Net.Dns.GetHostName();
        //IPHostEntry localIpAddresses = Dns.GetHostEntry(hostName);
        //string publicIP = localIpAddresses.AddressList[0].ToString();
        string publicIP = VisitorsIPAddr;
        string CountryCode = "IN";
        String[] splitIP = publicIP.Split('.');
        if (splitIP.Length > 3)
        {
            w = Convert.ToInt32(splitIP[0]);
            x = Convert.ToInt32(splitIP[1]);
            y = Convert.ToInt32(splitIP[2]);
            z = Convert.ToInt32(splitIP[3]);
            IPNumber = (16777216 * w) + (65536 * x) + (256 * y) + (z);
            DataSet dscd = new DataSet();
            dscd = obj_subs.AstGetCommon(IPNumber.ToString(), "", "", "GETCOUNTRYCODE");
            if (dscd.Tables[0].Rows.Count > 0)
            {
                CountryCode = dscd.Tables[0].Rows[0]["COUNTRY_CODE"].ToString();
            }
        }
        return CountryCode;
    }


}
