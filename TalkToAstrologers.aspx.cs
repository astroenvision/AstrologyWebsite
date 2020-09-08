using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class TalkToAstrologers : System.Web.UI.Page
{
    #region Declarations
    admin obj = new admin();
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindAstrologers();

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
            strhtml.Append("<input type = 'hidden' value = " + ds.Tables[0].Rows.Count.ToString() + " id = 'hdnCount'>");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string Name = ds.Tables[0].Rows[i]["NAME"].ToString();
                string Image = ds.Tables[0].Rows[i]["PHOTO"].ToString();
                string QualificationVal = ds.Tables[0].Rows[i]["EDUCATION"].ToString();
                string ExpertInVal = ds.Tables[0].Rows[i]["EXPERT_IN"].ToString();

                if (Image != "")
                {
                    Image = "img/" + Image + "";
                }
                else
                {
                    Image = "img/Default.jpg";
                }
                //Image = "img/Default.jpg";
                DataSet dsAs = new DataSet();
                int TotalUser = 0;
                int TotalRating = 0;
                if (ds.Tables[0].Rows[0]["SUMOFRATING"].ToString() !="")
                {
                    TotalUser = Convert.ToInt32(ds.Tables[0].Rows[0]["ALLUSER"].ToString());
                    TotalRating = Convert.ToInt32(ds.Tables[0].Rows[0]["SUMOFRATING"].ToString());
                }
                double Rating = 0;
                if (TotalUser > 0)
                {
                     Rating = Convert.ToDouble(Convert.ToDouble(TotalRating) / Convert.ToDouble(TotalUser));
                }
                string[] var = Rating.ToString().Split('.');
                int DesVal = var.Length;
                string Rat = Rating.ToString();
                string AfterDecimal = "0";
                if (DesVal > 1)
                {
                    Rat = var[0];
                    AfterDecimal = var[1];
                }

                dsAs = obj.ManageAstrologerPrice("GET_PRICE_DETAILS", "", ds.Tables[0].Rows[i]["USER_ID"].ToString(), "", "", "", "", "", "", "", "", "", "TALK_TO_ASTROLOGER","");
                strhtml.Append("<li>");
                strhtml.Append("<div class='row'>");
                strhtml.Append("<div class='col-xl-3 col-4'>");
                strhtml.Append("<div class='astprofpix'><a title=\"" + Name + "\" href=\"" + ResolveUrl("~/astrologer/" + ds.Tables[0].Rows[i]["NAME"].ToString().Replace(" ", "-").ToLower() + ".html") + "\">");
                strhtml.Append("<img class='astpicz' src='" + Image + "' alt=\"" + ds.Tables[0].Rows[i]["NAME"].ToString() + "\" title='" + ds.Tables[0].Rows[i]["NAME"].ToString() + "' />");
                strhtml.Append("</a></div>");

                strhtml.Append("<div class='astdtlz'>");
                strhtml.Append("<div class='astdtlzin'><b style='color:#f25e0a;'>Qualification:</b> " + QualificationVal + "</div>");
                strhtml.Append("<div class='astdtlzin'><b style='color:#f25e0a;'>Expertise in:</b> " + ExpertInVal + " </div>");
                //strhtml.Append("<div class='astdtlzin'><b>Rating:</b> " + Rating + " </div>");
                //strhtml.Append("<div class='astdtlzin'><b>Comments:</b> 876 </div>");
                //strhtml.Append("<div class='astdtlzin'><b>Views:</b> 2345 </div>");
                strhtml.Append("<div class='astdtlzin'><b style='color:#f25e0a;'>Experience in Astrology:</b> " + ds.Tables[0].Rows[i]["EXPERIENCE"].ToString()  + " Years </div>");
                strhtml.Append("</div>");
                strhtml.Append("</div>");

                strhtml.Append("<div class='col-xl-7 col-8'>");
                strhtml.Append("<div class='tttle'><a title=\""+ Name +"\" href =\"" + ResolveUrl("~/astrologer/" + ds.Tables[0].Rows[i]["NAME"].ToString().Replace(" ", "-").ToLower() + ".html") + "\">" + ds.Tables[0].Rows[i]["NAME"].ToString() + "</a></div>");
                //strhtml.Append("<div class='tttle-sb'>" + ds.Tables[0].Rows[i]["EXPERT_IN"].ToString() + "</div>");
                strhtml.Append("<div class='ttbatag'>");
                strhtml.Append("<span class='spinle'>");
                int PendingRating = 5 - Convert.ToInt32(Rat);
                for (int j = 1; j <= Convert.ToInt32(Rat); j++)
                {
                    strhtml.Append("<span style='font-size: 20px;'  class='fa fa-star checked'></span>");
                }
                if (Convert.ToDouble(AfterDecimal) > 0)
                {
                    PendingRating = PendingRating - 1;
                    strhtml.Append("<span  style='font-size: 20px;'  class='fa fa-star-half-o checked'></span>");
                }
                for (int k = 1; k <= Convert.ToInt32(PendingRating); k++)
                {
                    strhtml.Append("<span  style='font-size: 20px;'  class='fa fa-star'></span>");
                 }
                strhtml.Append("" + Math.Round(Rating, 1) + " Rating </span>");
                strhtml.Append("<span class='spinle'>"+ TotalUser + " Comments</span>");
                strhtml.Append("<span class='spinle' style='display:none'>2345 Views</span>");
                strhtml.Append("</div>");
                strhtml.Append("<div class='tstdtl'>" + ds.Tables[0].Rows[i]["SMALL_DESC"].ToString() + "<a title=\"" + Name + "\" style='font-size: 1em;font-weight: 600;' href=\"" + ResolveUrl("~/astrologer/" + Name.Replace(" ", "-").ToLower() + ".html") + "\"> Read More..</a></div>");
                string Amount = "", DiscountPer = "", DiscountAmount="", ActualAmount="" ;
                strhtml.Append("<div class='cfss d-flex'>");
                if (dsAs.Tables[0].Rows.Count > 0)
                {
                   
                    for (int j = 0; j < dsAs.Tables[0].Rows.Count; j++)
                    {
                        strhtml.Append("<input type = 'hidden' value = " + dsAs.Tables[0].Rows.Count.ToString() + " id = 'SecondCount_" + i + "'>");
                        Amount = dsAs.Tables[0].Rows[0]["FINAL_PRICE_INR"].ToString();
                        DiscountPer = dsAs.Tables[0].Rows[0]["DISCOUNT_INR"].ToString();
                        ActualAmount = dsAs.Tables[0].Rows[0]["PRICE_INR"].ToString();
                        DiscountAmount =Convert.ToString(Convert.ToDouble(dsAs.Tables[0].Rows[0]["PRICE_INR"]) - Convert.ToDouble(dsAs.Tables[0].Rows[0]["FINAL_PRICE_INR"]));
                        double YouSave = Convert.ToDouble(dsAs.Tables[0].Rows[j]["PRICE_INR"]) - Convert.ToDouble(dsAs.Tables[0].Rows[j]["FINAL_PRICE_INR"]);
                        strhtml.Append("<div class='cfssblk d-flex'>");
                        strhtml.Append("<input type ='radio' runat='server' id='AstroPrice_" + i +"_"  + j + "' name='AstroPrice_" + i + "' class='rdoast' onclick='SetPayment(this.id)'>");
                        strhtml.Append("<input type = 'hidden' value = " + dsAs.Tables[0].Rows[j]["DISCOUNT_INR"].ToString() + " id = 'hdnDiscountAmonut_" + i + "_" + j + "'>");
                        strhtml.Append("<input type = 'hidden' value = " + dsAs.Tables[0].Rows[j]["PRICE_INR"].ToString() + " id = 'hdnActualAmonut_" + i + "_" + j + "'>");
                        strhtml.Append("<input type = 'hidden' value = " + dsAs.Tables[0].Rows[j]["FINAL_PRICE_INR"].ToString() + " id = 'hdnPayableAmount_" + i + "_" + j + "'>");
                        strhtml.Append("<input type = 'hidden' value = " + dsAs.Tables[0].Rows[j]["NO_OF_MINUTES"].ToString() + " id = 'hdnMin_" + i + "_" + j + "'>");
                        strhtml.Append("<div>");
                        strhtml.Append("<span> " + dsAs.Tables[0].Rows[j]["NO_OF_MINUTES"].ToString() + " minutes : ₹  " + dsAs.Tables[0].Rows[j]["FINAL_PRICE_INR"].ToString() + " </span>");
                        strhtml.Append("<div class='prce'>");
                        strhtml.Append("<span class='price-old'>₹ "+dsAs.Tables[0].Rows[j]["PRICE_INR"].ToString()+"</span>");
                        strhtml.Append("<span class='price-new'>Save ₹ "+ YouSave.ToString("0.00") + "</span>");
                        strhtml.Append("</div>");
                        strhtml.Append("</div>");
                        strhtml.Append("</div>");
                    }
                }
                strhtml.Append("</div>");
                strhtml.Append("<div style='color:red;font-weight: bold;margin-top:0px; margin-bottom: 14px;font-size: 1.25em;'>Consultancy-upto two questions</div>");
                strhtml.Append("<div class='cfss d-flex'>");
                strhtml.Append("<div><b>Consultancy Language :-&nbsp&nbsp</b></div>");

                strhtml.Append("<div class='cfssblk d-flex' style='margin-right: 5rem;'>");
                strhtml.Append("<input type = 'radio' onclick=\"SetLanguageType('English');\"  name='Language' class='rdoast' id='rbEnglish_" + i + "' checked>");
                strhtml.Append("English");
                strhtml.Append("</div>");

                strhtml.Append("<div class='cfssblk d-flex' style='margin-right: 5rem;'>");
                strhtml.Append("<input type ='radio' onclick=\"SetLanguageType('Hindi');\"  name='Language'  class='rdoast'  id='rbHindi_" + i + "' >");
                strhtml.Append("Hindi");
                strhtml.Append("</div>");

                strhtml.Append("<div class='cfssblk d-flex' style='margin-right: 1rem;'>");
                strhtml.Append("<input type = 'radio' onclick=\"SetLanguageType('Both');\"  name='Language' class='rdoast' id='rbBoth_" + i + "'>");
                strhtml.Append("Both");
                strhtml.Append("</div>");

                strhtml.Append("</div>");

                strhtml.Append("<div class='cfss d-flex'>");
                strhtml.Append("<div><b>Consultation Type :-&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</b></div>");

                strhtml.Append("<div class='cfssblk d-flex' style='margin-right: 3.8rem;'>");
                strhtml.Append("<input type ='radio' onclick=\"SetConsultationType('Telephonic');\" name='Type'  class='rdoast'  id='rbType_" + i + "' checked>");
                strhtml.Append("Telephonic");
                strhtml.Append("</div>");

                strhtml.Append("<div class='cfssblk d-flex' style='margin-right: 1rem;'>");
                strhtml.Append("<input type = 'radio' onclick=\"SetConsultationType('Video');\"  name='Type' class='rdoast' id='rbType_" + i + "'>");
                strhtml.Append("Video Meeting");
                strhtml.Append("</div>");
                
                strhtml.Append("</div>");
                strhtml.Append("</div>");
                strhtml.Append("<div class='col-xl-2'>");
                strhtml.Append("<div class='plndtls text-center'>");
                strhtml.Append("<div class='slcpp' id='divPayableAmount_" + i + "' ><span style='color: #f25e0a;font-weight: bold;font-size: 0.45em;'>You Pay</span>₹" + Amount + "<span>(Includes GST)</span></div>");
                strhtml.Append("<div class='przast'>");
                strhtml.Append("<div class='price-old' id='divOldAmount_" + i + "' >₹ "+ ActualAmount + "</div>");
                strhtml.Append("<div class='price-new' id='divSaveAmount_" + i + "'>Save:- ₹ "+ DiscountAmount +"</div>");
                strhtml.Append("<div class='price-new' id='divDiscountAmount_" + i + "'>Discount:- " + DiscountPer + "%</div>");
                strhtml.Append("</div>");
                strhtml.Append("<div style='margin-left: 7px;cursor: pointer;' class='vwall-btn' Onclick=\"btnBook_Click('INSERT_PAYMENT_IN_TEMP','" + CartID + "' , '" + UserID + "' , '" + UserEmailID + "' , 'INR' , '" + ds.Tables[0].Rows[i]["ASTROLOGER_ID"].ToString() + "' , '" + ds.Tables[0].Rows[i]["NAME"].ToString() + "' , '"+ i +"');\">BOOK NOW</div>");
                strhtml.Append("</div>");
                strhtml.Append("</div>");
                strhtml.Append("</div>");
                strhtml.Append("<div class='row'>");
                strhtml.Append("<div class='col-xl-6'>");
                strhtml.Append("<div><b>Enter Question 1</b><span style='color:red;font-size:.75rem;'> (250 Characters)</span></div>");
                strhtml.Append("<textarea id='txtQuestion1' maxlength='250' CssClass='form-control' onkeyup='countChar(1)' onblur='countChar(1)' placeholder='Enter Question 1' rows='3' cols='60'></textarea>");
                strhtml.Append("<label id='lblCharater1'>Total Character Count:- <label id='lblMessage'>0</label></label>");
                strhtml.Append("</div>");
                strhtml.Append("<div class='col-xl-6'>");
                strhtml.Append("<div><b>Enter Question 2</b><span style='color:red;font-size:.75rem;'> (250 Characters)</span></div>");
                strhtml.Append("<textarea id='txtQuestion2'  maxlength='250' CssClass='form-control' onkeyup='countChar(2)' onblur='countChar(2)' placeholder='Enter Question 2' rows='3' cols='60'></textarea>");
                strhtml.Append("<label id='lblCharater2'>Total Character Count:- <label id='lblMessage1'>0</label></label>");
                strhtml.Append("</div>");
                strhtml.Append("</div>");
                         strhtml.Append("<div style='color:red;font-weight: bold;'>Note:- After payment is made contact us +91-9555600111 to fix the appointment.</div>");
                strhtml.Append("</li>");


            }
        }
        ulAstrologer.InnerHtml = strhtml.ToString();
        ScriptManager.RegisterStartupScript(this, GetType(), "Close Modal Popup", "CheckedRadioButton();", true);
   
}
    #endregion
}

