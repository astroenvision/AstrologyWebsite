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
using System.Data.SqlClient;
using ASTROLOGY.classesoracle;
using System.Net;

public partial class article_questions : System.Web.UI.Page
{
    ASTROLOGY.classesoracle.main obj_main = new ASTROLOGY.classesoracle.main();
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    common cs_obj = new common();
    string MId = "", CatId = "";
    string article_dtls = "", usertype = "2", CategoryName = "";
    DataSet dsmaxid = new DataSet();
    DataSet ds = new DataSet();
    DataSet ds1 = new DataSet();
    DataSet ds2 = new DataSet();
    DataSet dsg = new DataSet();
    string ActualPrice = "", FinalPrice = "", discountval = "";
    decimal discount, discountprice, FinalPriceVal;
    string PreviousPageURLFinal = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (Request.UrlReferrer != null)
            {
                string PreviousPageURL = Request.UrlReferrer.ToString();
                string CurrentPageURL = Request.Url.ToString();
                if (CurrentPageURL.IndexOf("horary") > -1)
                {
                    if (PreviousPageURL.IndexOf("horary") == -1)
                    {
                        PreviousPageURLFinal = PreviousPageURL + "?groupid=horary";
                    }
                    else
                    {
                        PreviousPageURLFinal = PreviousPageURL;
                    }
                }
                if (CurrentPageURL.IndexOf("natal") > -1)
                {
                    if (PreviousPageURL.IndexOf("natal") == -1)
                    {
                        PreviousPageURLFinal = PreviousPageURL + "?groupid=natal";
                    }
                    else
                    {
                        PreviousPageURLFinal = PreviousPageURL;
                    }
                }
            }
            if (Session["MySessionID"] != null || Session["MySessionID"].ToString() != "")
            {
                ViewState["cartid"] = Session["MySessionID"];
            }
            if (Request.QueryString["groupid"] != null && Request.QueryString["catid"] != null)
            {
                ViewState["CountryCode"] = GetCountryCode();
                MId = Request.QueryString["groupid"].ToString().Trim();
                CatId = Request.QueryString["catid"].ToString();
                ViewState["cartid"] = Request.QueryString["cartid"].ToString().Trim();
                ViewState["CatId"] = CatId.ToString().Trim();
                ViewState["GroupId"] = MId.ToString().Trim();
                if (MId == "horary")
                {
                    DataSet ds = cs_obj.Get_Harary_Questions(CatId);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ViewState["totalques"] = ds.Tables[0].Rows.Count.ToString();
                        CategoryName = ds.Tables[0].Rows[0]["Category_name"].ToString();
                        ViewState["CatName"] = CategoryName;
                        GvNatalQuestions.Visible = false;
                        NatalPanel.Visible = false;
                        GvHoraryQuestions.Visible = true;
                        HoraryPanel.Visible = true;
                        GvHoraryQuestions.DataSource = ds;
                        GvHoraryQuestions.DataBind();
                        tabs.InnerHtml = " <li><a href=\"#\">Horary</a></li>";
                        article_dtls = "<div class='fullarticle_catname'><a href=\"" + ResolveUrl(PreviousPageURLFinal) + "\"><img src=\"" + ResolveUrl("~/Image/previous.png") + "\" alt='Back' title='Back' /></a>&nbsp;&nbsp;Astro Report on - " + CategoryName + "<div class='selectallcss' style='display:none;'><a id='selectid' style='color:#4d4d4d;' onclick=\"SetHoraryAutoSelected('Select');\" href=\"javascript:void(0);\">Select All</a> | <a id='deselectid' style='color:#F4600A;' onclick=\"SetHoraryAutoSelected('DeSelect');\" href=\"javascript:void(0);\">Deselect All</a></div></div>";
                    }
                    ds.Dispose();
                    fullarticle_id.InnerHtml = article_dtls;

                    ds2 = obj_subs.AstGetCommon("1", "2", ViewState["GroupId"].ToString().ToUpper(), "GETCATEGORYPRICE");
                    if (ds2.Tables[0].Rows.Count > 0)
                    {
                        if (ViewState["CountryCode"].ToString() == "IN")
                        {
                            FinalPrice = ds2.Tables[0].Rows[0]["FINALPRICE_INR"].ToString();
                            totalamt.InnerText = "Total Amount: Rs. " + FinalPrice + " (INR)";
                        }
                        else
                        {
                            FinalPrice = ds2.Tables[0].Rows[0]["FINALPRICE_USD"].ToString();
                            totalamt.InnerText = "Total Amount: $ " + FinalPrice + " (USD)";
                        }
                    }
                    ds2.Dispose();
                }
                if (MId == "natal")
                {
                    DataSet ds = cs_obj.Get_Natal_Questions(CatId);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ViewState["totalques"] = ds.Tables[0].Rows.Count.ToString();
                        CategoryName = ds.Tables[0].Rows[0]["Category_name"].ToString();
                        string TITLE_VAL = ds.Tables[0].Rows[0]["TITLE"].ToString();
                        string META_KEYWORDS_VAL = ds.Tables[0].Rows[0]["META_KEYWORDS"].ToString();
                        string META_DESCRIPTION_VAL = ds.Tables[0].Rows[0]["META_DESCRIPTION"].ToString();
                        meta_keywords_desc(TITLE_VAL, META_KEYWORDS_VAL, META_DESCRIPTION_VAL, CategoryName);
                        //Page.Title = CategoryName + " | Natal | Astro Envision";
                        ViewState["CatName"] = CategoryName;
                        GvNatalQuestions.Visible = true;
                        NatalPanel.Visible = true;
                        GvHoraryQuestions.Visible = false;
                        HoraryPanel.Visible = false;
                        GvNatalQuestions.DataSource = ds;
                        GvNatalQuestions.DataBind();
                        string natalmsg = "<br /><h2 class='fullarticle_catname_msg'>We have covered the following set of a query in Your Astro Report apart from other promises, related to your current report.</h2>";
                        tabs.InnerHtml = "<li><a href=\"#\">Natal</a></li>";
                        article_dtls = "<div class='fullarticle_catname'><a href=\"" + ResolveUrl(PreviousPageURLFinal) + "\"><img src=\"" + ResolveUrl("~/Image/previous.png") + "\" alt='Back' title='Back' /></a>&nbsp;&nbsp;Astro Report on - " + CategoryName + " " + natalmsg + "<div class='selectallcss' style='display:none;'><a id='selectid' style='color:#4d4d4d;' onclick=\"SetNatalAutoSelected('Select');\" href=\"javascript:void(0);\">Select All</a> | <a id='deselectid' style='color:#F4600A;' onclick=\"SetNatalAutoSelected('DeSelect');\" href=\"javascript:void(0);\">Deselect All</a></div></div>";
                    }
                    ds.Dispose();
                    fullarticle_id.InnerHtml = article_dtls;

                    ds2 = obj_subs.AstGetCommon(CatId, "2", ViewState["GroupId"].ToString().ToUpper(), "GETCATEGORYPRICE");
                    if (ds2.Tables[0].Rows.Count > 0)
                    {
                        if (ViewState["CountryCode"].ToString() == "IN")
                        {
                            ActualPrice = ds2.Tables[0].Rows[0]["PRICE_INR"].ToString();
                            discountval = ds2.Tables[0].Rows[0]["DISCOUNT_INR"].ToString();
                            if (discountval != "" && discountval != "0")
                            {
                                discount = decimal.Parse(discountval);
                                discountprice = decimal.Parse(ActualPrice) * (discount / 100);
                                FinalPriceVal = decimal.Parse(ActualPrice) - discountprice;
                                FinalPrice = FinalPriceVal.ToString();
                                actualtotalamt.InnerText = "Amount: ₹ " + ActualPrice + "";
                                discountper.InnerText = "You Save: ₹ " + discountprice + " (" + discountval + "%)";
                            }
                            else
                            {
                                FinalPrice = ActualPrice;
                            }
                            totalamt.InnerText = "Fee Payable: ₹ " + FinalPrice + "";
                            ViewState["FinalPrice"] = FinalPrice;
                        }
                        else
                        {
                            ActualPrice = ds2.Tables[0].Rows[0]["PRICE_INR"].ToString();
                            discountval = ds2.Tables[0].Rows[0]["DISCOUNT_INR"].ToString();
                            if (discountval != "" && discountval != "0")
                            {
                                discount = decimal.Parse(discountval);
                                discountprice = decimal.Parse(ActualPrice) * (discount / 100);
                                FinalPriceVal = decimal.Parse(ActualPrice) - discountprice;
                                FinalPrice = FinalPriceVal.ToString();
                                actualtotalamt.InnerText = "Amount: $ " + ActualPrice + "";
                                discountper.InnerText = "You Save: $ " + discountprice + " (" + discountval + "%)";
                            }
                            else
                            {
                                FinalPrice = ActualPrice;
                            }
                            totalamt.InnerText = "Fee Payable: $ " + FinalPrice + " (USD)";
                            ViewState["FinalPrice"] = FinalPrice;
                        }
                    }
                    ds2.Dispose();


                }
            }
        }
    }

    void meta_keywords_desc(string titleval, string keywordsval, string descval, string catname)
    {
        if (titleval != "")
        {
            Page.Title = titleval + " | Astro Envision";
        }
        else
        {
            Page.Title = catname + " | Natal | Astro Envision";
        }
        if (keywordsval != "")
        {
            //Add Keywords Meta Tag
            HtmlMeta keywords = new HtmlMeta();
            keywords.HttpEquiv = "keywords";
            keywords.Name = "keywords";
            keywords.Content = keywordsval;
            Page.Header.Controls.Add(keywords);
        }
        if (descval != "")
        {
            //Add Description Meta Tag
            HtmlMeta description = new HtmlMeta();
            description.HttpEquiv = "description";
            description.Name = "description";
            description.Content = descval;
            Page.Header.Controls.Add(description);
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
                Session["CountryCode"] = CountryCode;
            }
        }
        return CountryCode;

    }

    protected void GvHoraryQuestions_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            DataRowView drv = e.Row.DataItem as DataRowView;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                CheckBox LblCatid = (CheckBox)(e.Row.FindControl("chkRowhorary"));
                Label lblhoraryquestionid = (Label)(e.Row.FindControl("lblhoraryquestionid"));
                ds = obj_subs.GetAddToCart(ViewState["cartid"].ToString().Trim(), "", "", ViewState["CatId"].ToString().Trim(), "GETCATQUESTIONS");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        string Ques_id = ds.Tables[0].Rows[i]["QUESTIONID"].ToString();
                        if (lblhoraryquestionid.Text.ToString().Trim() == Ques_id)
                        {
                            LblCatid.Checked = true;
                        }
                    }

                }
            }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
    protected void GvNatalQuestions_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            DataRowView drv = e.Row.DataItem as DataRowView;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                CheckBox LblCatid = (CheckBox)(e.Row.FindControl("chkRownatal"));
                Label lblnatalquestionid = (Label)(e.Row.FindControl("lblnatalquestionid"));
                ds = obj_subs.GetAddToCart(ViewState["cartid"].ToString().Trim(), "", "", ViewState["CatId"].ToString().Trim(), "GETCATQUESTIONS");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        string Ques_id = ds.Tables[0].Rows[i]["QUESTIONID"].ToString();
                        if (lblnatalquestionid.Text.ToString().Trim() == Ques_id)
                        {
                            LblCatid.Checked = true;
                        }
                    }

                }
            }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }

    protected void selectallH_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow item in GvHoraryQuestions.Rows)
        {
            if ((item.Cells[0].FindControl("chkRowhorary") as CheckBox).Checked == false)
            {
                CheckBox bf = (item.Cells[0].FindControl("chkRowhorary") as CheckBox);
                bf.Checked = true;
            }
        }
    }
    protected void UnselectallH_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow item in GvHoraryQuestions.Rows)
        {
            if ((item.Cells[0].FindControl("chkRowhorary") as CheckBox).Checked == true)
            {
                CheckBox bf = (item.Cells[0].FindControl("chkRowhorary") as CheckBox);
                bf.Checked = false;
            }
        }
    }

    protected void selectallN_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow item in GvNatalQuestions.Rows)
        {
            if ((item.Cells[0].FindControl("chkRownatal") as CheckBox).Checked == false)
            {
                CheckBox bf = (item.Cells[0].FindControl("chkRownatal") as CheckBox);
                bf.Checked = true;
            }
        }
    }
    protected void UnselectallN_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow item in GvNatalQuestions.Rows)
        {
            if ((item.Cells[1].FindControl("chkRownatal") as CheckBox).Checked == true)
            {
                CheckBox bf = (item.Cells[1].FindControl("chkRownatal") as CheckBox);
                bf.Checked = false;
            }
        }
    }

    protected void btnnext_Click(object sender, EventArgs e)
    {
        try
        {
            bool flagactive = false;
            //string flag_output1 = "";
            string flag_output2 = "", precatname = "";
            for (Int32 I32Counter = 0; I32Counter < GvHoraryQuestions.Rows.Count; I32Counter++)
            {
                Label lblhoraryquestionid = (Label)(GvHoraryQuestions.Rows[I32Counter].FindControl("lblhoraryquestionid"));
                Label lblhoraryquestion = (Label)(GvHoraryQuestions.Rows[I32Counter].FindControl("lblhoraryquestion"));
                CheckBox chkRowhorary = (CheckBox)(GvHoraryQuestions.Rows[I32Counter].FindControl("chkRowhorary"));
                //if (chkRowhorary.Checked == true)
                //{
                string categoryid = ViewState["CatId"].ToString().Trim();
                string categotyname = ViewState["CatName"].ToString().Trim();
                string questionid = lblhoraryquestionid.Text.ToString().Trim();
                string questionval = lblhoraryquestion.Text.ToString().Trim();
                questionval = questionval.Replace("'", "''");
                string totalques = ViewState["totalques"].ToString().Trim();
                string groupid = ViewState["GroupId"].ToString().Trim();

                ds1 = obj_subs.AstGetCommon("", "2", groupid.ToUpper(), "HORARY_ENDUSER_PRICE");
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    string finalamt = ds1.Tables[0].Rows[0]["FINALPRICE_INR"].ToString();
                    ViewState["TotalAmount"] = finalamt;
                }
                ds1.Dispose();

                ds2 = obj_subs.AstGetCommon(ViewState["cartid"].ToString(), "2", groupid.ToUpper(), "HORARYSELECTEDCAT");
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    precatname = ds2.Tables[0].Rows[0]["CATNAME"].ToString();
                }
                ds2.Dispose();

                dsg = obj_subs.AstGetCommon(ViewState["cartid"].ToString(), "2", "", "CHECKGROUP");
                string Existgroup = "";
                if (dsg.Tables[0].Rows.Count > 0)
                {
                    Existgroup = dsg.Tables[0].Rows[0]["GROUP_ID"].ToString();
                    if (Existgroup == groupid.ToUpper())
                    {
                        if (chkRowhorary.Checked == true)
                        {
                            dsmaxid = obj_main.GetMaxId("AUTOID", "ADDTOCART");
                            int gallmaxid = 0;
                            if (dsmaxid.Tables[0].Rows.Count > 0)
                            {
                                gallmaxid = Convert.ToInt32(dsmaxid.Tables[0].Rows[0]["MAXID"].ToString().Trim());
                            }
                            dsmaxid.Dispose();

                            ds = obj_subs.AddToCart(gallmaxid, ViewState["cartid"].ToString(), "", categoryid, categotyname, questionid, questionval, totalques, "", ViewState["TotalAmount"].ToString().Trim(), usertype, groupid.ToUpper(), "INSERT");
                            if (ds.Tables[1].Rows.Count > 0)
                            {
                                //flag_output1 = ds.Tables[0].Rows[0]["flag"].ToString().Trim();
                                flagactive = true;
                                flag_output2 = ds.Tables[1].Rows[0]["flag2"].ToString().Trim();
                                if (flag_output2 == "SUCCESS")
                                {
                                    flagactive = true;
                                }
                                else if (flag_output2 == "FAILD")
                                {
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('You can choose only One Category at one Point of time. You have already chosen " + precatname.ToString().ToUpper() + " Category. Do You want to Change the Query Category ');", true);
                                    return;
                                }
                                else if (flag_output2 == "EXIST")
                                {
                                    //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "confirm('You have already chosen these Questions .');", true);
                                    //return;
                                }
                            }
                            ds.Dispose();
                        }
                        if (chkRowhorary.Checked == false)
                        {
                            int gallmaxid = 0;
                            ds = obj_subs.AddToCart(gallmaxid, ViewState["cartid"].ToString(), "", categoryid, categotyname, questionid, questionval, totalques, "", ViewState["TotalAmount"].ToString().Trim(), usertype, groupid.ToUpper(), "EDIT");
                            if (ds.Tables[1].Rows.Count > 0)
                            {
                                flagactive = true;
                                flag_output2 = ds.Tables[1].Rows[0]["flag2"].ToString().Trim();
                                if (flag_output2 == "DELETE")
                                {
                                    dsg = obj_subs.AstGetCommon(ViewState["cartid"].ToString(), "2", "", "CHECKGROUP");
                                    if (dsg.Tables[0].Rows.Count > 0)
                                    {
                                        flagactive = true;
                                    }
                                    else
                                    {
                                        flagactive = false;
                                        Session["myquery"] = null;
                                        Response.Redirect(ResolveUrl("" + HttpContext.Current.Request.RawUrl + ""));
                                    }
                                    dsg.Dispose();
                                }
                                else if (flag_output2 == "NOTEXIST")
                                {

                                }
                            }
                            ds.Dispose();
                        }
                    }
                    else if (Existgroup != groupid.ToUpper())
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('You can choose only One Group at one Point of time. You have already chosen " + Existgroup.ToString().ToUpper() + " Group.');", true);
                        return;
                    }
                }
                else
                {
                    if (chkRowhorary.Checked == true)
                    {
                        dsmaxid = obj_main.GetMaxId("AUTOID", "ADDTOCART");
                        int gallmaxid = 0;
                        if (dsmaxid.Tables[0].Rows.Count > 0)
                        {
                            gallmaxid = Convert.ToInt32(dsmaxid.Tables[0].Rows[0]["MAXID"].ToString().Trim());
                        }
                        dsmaxid.Dispose();

                        ds = obj_subs.AddToCart(gallmaxid, ViewState["cartid"].ToString(), "", categoryid, categotyname, questionid, questionval, totalques, "", ViewState["TotalAmount"].ToString().Trim(), usertype, groupid.ToUpper(), "INSERT");
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            //flag_output1 = ds.Tables[0].Rows[0]["flag"].ToString().Trim();
                            flagactive = true;
                            flag_output2 = ds.Tables[1].Rows[0]["flag2"].ToString().Trim();
                            if (flag_output2 == "SUCCESS")
                            {
                                flagactive = true;
                            }
                            else if (flag_output2 == "FAILD")
                            {
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('You can choose only One Category at one Point of time. You have already chosen " + precatname.ToString().ToUpper() + " Category. Do You want to Change the Query Category ');", true);
                                return;
                            }
                            else if (flag_output2 == "EXIST")
                            {
                                //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "confirm('You have already chosen these Questions .');", true);
                                //return;
                            }
                        }
                        ds.Dispose();
                    }
                }
                dsg.Dispose();
                //}
            }

            for (Int32 I32Counter = 0; I32Counter < GvNatalQuestions.Rows.Count; I32Counter++)
            {
                Label lblnatalquestionid = (Label)(GvNatalQuestions.Rows[I32Counter].FindControl("lblnatalquestionid"));
                Label lblnatalquestion = (Label)(GvNatalQuestions.Rows[I32Counter].FindControl("lblnatalquestion"));
                CheckBox chkRownatal = (CheckBox)(GvNatalQuestions.Rows[I32Counter].FindControl("chkRownatal"));
                //if (chkRownatal.Checked == true)
                //{
                string categoryid = ViewState["CatId"].ToString().Trim();
                string categotyname = ViewState["CatName"].ToString().Trim();
                string questionid = lblnatalquestionid.Text.ToString().Trim();
                string questionval = lblnatalquestion.Text.ToString().Trim();
                questionval = questionval.Replace("'", "''");
                string totalques = ViewState["totalques"].ToString().Trim();
                string groupid = ViewState["GroupId"].ToString().Trim();

                dsg = obj_subs.AstGetCommon(ViewState["cartid"].ToString(), "2", "", "CHECKGROUP");
                string Existgroup = "";
                if (dsg.Tables[0].Rows.Count > 0)
                {
                    Existgroup = dsg.Tables[0].Rows[0]["GROUP_ID"].ToString();
                    if (Existgroup == groupid.ToUpper())
                    {
                        if (chkRownatal.Checked == true)
                        {
                            dsmaxid = obj_main.GetMaxId("AUTOID", "ADDTOCART");
                            int gallmaxid = 0;
                            if (dsmaxid.Tables[0].Rows.Count > 0)
                            {
                                gallmaxid = Convert.ToInt32(dsmaxid.Tables[0].Rows[0]["MAXID"].ToString().Trim());
                            }
                            dsmaxid.Dispose();

                            ds = obj_subs.AddToCart(gallmaxid, Session["MySessionID"].ToString(), "", categoryid, categotyname, questionid, questionval, totalques, "", ViewState["FinalPrice"].ToString(), usertype, groupid.ToUpper(), "INSERT");
                            if (ds.Tables[1].Rows.Count > 0)
                            {
                                flagactive = true;
                                flag_output2 = ds.Tables[1].Rows[0]["flag2"].ToString().Trim();
                                if (flag_output2 == "SUCCESS")
                                {
                                    flagactive = true;
                                }
                                else if (flag_output2 == "EXIST")
                                {
                                    //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "confirm('You have already chosen these Questions.');", true);
                                    //return;
                                }
                            }
                            ds.Dispose();
                        }
                        if (chkRownatal.Checked == false)
                        {
                            int gallmaxid = 0;
                            ds = obj_subs.AddToCart(gallmaxid, Session["MySessionID"].ToString(), "", categoryid, categotyname, questionid, questionval, totalques, "", ViewState["FinalPrice"].ToString(), usertype, groupid.ToUpper(), "EDIT");
                            if (ds.Tables[1].Rows.Count > 0)
                            {
                                flagactive = true;
                                flag_output2 = ds.Tables[1].Rows[0]["flag2"].ToString().Trim();
                                if (flag_output2 == "DELETE")
                                {
                                    dsg = obj_subs.AstGetCommon(ViewState["cartid"].ToString(), "2", "", "CHECKGROUP");
                                    if (dsg.Tables[0].Rows.Count > 0)
                                    {
                                        flagactive = true;
                                    }
                                    else
                                    {
                                        flagactive = false;
                                        Session["myquery"] = null;
                                        Response.Redirect(ResolveUrl("" + HttpContext.Current.Request.RawUrl + ""));
                                    }
                                    dsg.Dispose();
                                }
                                else if (flag_output2 == "NOTEXIST")
                                {

                                }
                            }
                            ds.Dispose();
                        }
                    }
                    else if (Existgroup != groupid.ToUpper())
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('You can choose only One Group at one Point of time. You have already chosen " + Existgroup.ToString().ToUpper() + " Group.');", true);
                        return;
                    }
                }
                else
                {
                    if (chkRownatal.Checked == true)
                    {
                        dsmaxid = obj_main.GetMaxId("AUTOID", "ADDTOCART");
                        int gallmaxid = 0;
                        if (dsmaxid.Tables[0].Rows.Count > 0)
                        {
                            gallmaxid = Convert.ToInt32(dsmaxid.Tables[0].Rows[0]["MAXID"].ToString().Trim());
                        }
                        dsmaxid.Dispose();

                        ds = obj_subs.AddToCart(gallmaxid, Session["MySessionID"].ToString(), "", categoryid, categotyname, questionid, questionval, totalques, "", ViewState["FinalPrice"].ToString(), usertype, groupid.ToUpper(), "INSERT");
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            flagactive = true;
                            flag_output2 = ds.Tables[1].Rows[0]["flag2"].ToString().Trim();
                            if (flag_output2 == "SUCCESS")
                            {
                                flagactive = true;
                            }
                            else if (flag_output2 == "EXIST")
                            {
                                //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "confirm('You have already chosen these Questions .');", true);
                                //return;
                            }
                        }
                        ds.Dispose();
                    }
                }
                dsg.Dispose();
                //}
            }

            if (flagactive == true)
            {
                //Response.Redirect(ResolveUrl("~/addtocart.aspx?groupid=" + ViewState["GroupId"].ToString().Trim() + "&cartid=" + Session["mysession"].ToString() + ""));
                Response.Redirect(ResolveUrl("~/article/finalquestions.aspx?groupid=" + ViewState["GroupId"].ToString().Trim() + "&cartid=" + Session["MySessionID"].ToString() + ""));
                //Response.Redirect(ResolveUrl("~/payment/" + ViewState["GroupId"].ToString().Trim() + "/" + Session["mysession"].ToString() + ".html"));
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(article_questions), "wq", "alert('Please check any question !');", true);
                return;
            }
        }
        catch (Exception ex)
        {
            ASTROLOGY.classesoracle.main.SaveLogEntry(ex.Message + " | Error Source:- " + ex.Source + " | TargetSite:- " + ex.TargetSite.ToString());
        }
    }
}
