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

public partial class ConsultAnAstrologer : System.Web.UI.Page
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
                if (ds.Tables[0].Rows[0]["SUMOFRATING"].ToString() != "")
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

                dsAs = obj.ManageAstrologerPrice("GET_PRICE_DETAILS", "", ds.Tables[0].Rows[i]["USER_ID"].ToString(), "", "", "", "", "", "", "", "", "", "CONSULT_AN_ASTROLOGER", "");
                strhtml.Append("<li>");
                strhtml.Append("<div class='row'>");
                strhtml.Append("<div class='col-xl-3 col-4'>");
                strhtml.Append("<div class='astprofpix'><a title=" + Name + " href=\"" + ResolveUrl("~/astrologer/" + ds.Tables[0].Rows[i]["NAME"].ToString().Replace(" ", "-").ToLower() + ".html") + "\">");
                strhtml.Append("<img class='astpicz' src='" + Image + "' alt=\"" + ds.Tables[0].Rows[i]["NAME"].ToString() + "\" title='" + ds.Tables[0].Rows[i]["NAME"].ToString() + "' />");
                strhtml.Append("</a></div>");

                strhtml.Append("<div class='astdtlz'>");
                strhtml.Append("<div class='astdtlzin'><b style='color:#f25e0a;'>Qualification:</b> " + QualificationVal + "</div>");
                strhtml.Append("<div class='astdtlzin'><b style='color:#f25e0a;'>Expertise in:</b> " + ExpertInVal + " </div>");
                //strhtml.Append("<div class='astdtlzin'><b>Rating:</b> " + Rating + " </div>");
                //strhtml.Append("<div class='astdtlzin'><b>Comments:</b> 876 </div>");
                //strhtml.Append("<div class='astdtlzin'><b>Views:</b> 2345 </div>");
                strhtml.Append("<div class='astdtlzin'><b style='color:#f25e0a;'>Experience in Astrology:</b> " + ds.Tables[0].Rows[i]["EXPERIENCE"].ToString() + " Years </div>");
                strhtml.Append("</div>");
                strhtml.Append("</div>");

                strhtml.Append("<div class='col-xl-7 col-8'>");
                strhtml.Append("<div class='tttle'><a title=\"" + Name + "\" href =\"" + ResolveUrl("~/astrologer/" + ds.Tables[0].Rows[i]["NAME"].ToString().Replace(" ", "-").ToLower() + ".html") + "\">" + ds.Tables[0].Rows[i]["NAME"].ToString() + "</a></div>");
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
                strhtml.Append("<span class='spinle'>" + TotalUser + " Comments</span>");
                strhtml.Append("<span class='spinle' style='display:none'>2345 Views</span>");
                strhtml.Append("</div>");
                strhtml.Append("<div class='tstdtl'><p style='display: inherit;'><strong>Consult an Astrologer - Astrology Reports</strong></p><p style='display: inherit;'>(Via e - mail / Whatsaap within 48 working hours)</p><p style='display: inherit;'>(Inclusive of all Taxes)</p><p>You get a highly customized service for you to seek an answer for any specific questions.Our Astrologer refers to your birth chart precisely and writes the predictive for your query along with the Do's and Don'ts, remedial to attain your goal.</p></div>");
                string Amount = "", DiscountPer = "", DiscountAmount = "", ActualAmount = "";
                strhtml.Append("<div class='cfss d-flex'>");
                if (dsAs.Tables[0].Rows.Count > 0)
                {

                    for (int j = 0; j < dsAs.Tables[0].Rows.Count; j++)
                    {
                        strhtml.Append("<input type = 'hidden' value = " + dsAs.Tables[0].Rows.Count.ToString() + " id = 'SecondCount_" + i + "'>");
                        Amount = dsAs.Tables[0].Rows[0]["FINAL_PRICE_INR"].ToString();
                        DiscountPer = dsAs.Tables[0].Rows[0]["DISCOUNT_INR"].ToString();
                        ActualAmount = dsAs.Tables[0].Rows[0]["PRICE_INR"].ToString();
                        DiscountAmount = Convert.ToString(Convert.ToDouble(dsAs.Tables[0].Rows[0]["PRICE_INR"]) - Convert.ToDouble(dsAs.Tables[0].Rows[0]["FINAL_PRICE_INR"]));
                        double YouSave = Convert.ToDouble(dsAs.Tables[0].Rows[j]["PRICE_INR"]) - Convert.ToDouble(dsAs.Tables[0].Rows[j]["FINAL_PRICE_INR"]);
                        strhtml.Append("<div class='cfssblk d-flex'>");
                        strhtml.Append("<input type ='radio' runat='server' id='AstroPrice_" + i + "_" + j + "' name='AstroPrice_" + i + "' class='rdoast' onclick='SetPayment(this.id)'>");
                        strhtml.Append("<input type = 'hidden' value = " + dsAs.Tables[0].Rows[j]["DISCOUNT_INR"].ToString() + " id = 'hdnDiscountAmonut_" + i + "_" + j + "'>");
                        strhtml.Append("<input type = 'hidden' value = " + dsAs.Tables[0].Rows[j]["PRICE_INR"].ToString() + " id = 'hdnActualAmonut_" + i + "_" + j + "'>");
                        strhtml.Append("<input type = 'hidden' value = " + dsAs.Tables[0].Rows[j]["FINAL_PRICE_INR"].ToString() + " id = 'hdnPayableAmount_" + i + "_" + j + "'>");
                        strhtml.Append("<input type = 'hidden' value = " + dsAs.Tables[0].Rows[j]["NO_OF_MINUTES"].ToString() + " id = 'hdnMin_" + i + "_" + j + "'>");
                        strhtml.Append("<input type = 'hidden' value = " + dsAs.Tables[0].Rows[j]["NO_OF_QUESTIONS"].ToString() + " id = 'hdnQus_" + i + "_" + j + "'>");
                        strhtml.Append("<div>");
                        strhtml.Append("<span> " + dsAs.Tables[0].Rows[j]["NO_OF_QUESTIONS"].ToString() + " question : ₹  " + dsAs.Tables[0].Rows[j]["FINAL_PRICE_INR"].ToString() + " </span>");
                        strhtml.Append("<div class='prce'>");
                        strhtml.Append("<span class='price-old'>₹ " + dsAs.Tables[0].Rows[j]["PRICE_INR"].ToString() + "</span>");
                        strhtml.Append("<span class='price-new'>Save ₹ " + YouSave.ToString("0.00") + "</span>");
                        strhtml.Append("</div>");
                        strhtml.Append("</div>");
                        strhtml.Append("</div>");
                    }
                }
                strhtml.Append("</div>");
           
              
              
                strhtml.Append("</div>");
                strhtml.Append("<div class='col-xl-2'>");
                strhtml.Append("<div class='plndtls text-center'>");
                strhtml.Append("<div class='slcpp' id='divPayableAmount_" + i + "' ><span style='color: #f25e0a;font-weight: bold;font-size: 0.45em;'>You Pay</span>₹" + Amount + "<span>(Includes GST)</span></div>");
                strhtml.Append("<div class='przast'>");
                strhtml.Append("<div class='price-old' id='divOldAmount_" + i + "' >₹ " + ActualAmount + "</div>");
                strhtml.Append("<div class='price-new' id='divSaveAmount_" + i + "'>Save:- ₹ " + DiscountAmount + "</div>");
                strhtml.Append("<div class='price-new' id='divDiscountAmount_" + i + "'>Discount:- " + DiscountPer + "%</div>");
                strhtml.Append("</div>");
                strhtml.Append("<div style='margin-left: 7px;cursor: pointer;' class='vwall-btn' Onclick=\"btnBook_Click('INSERT_PAYMENT_IN_TEMP','" + CartID + "' , '" + UserID + "' , '" + UserEmailID + "' , 'INR' , '" + ds.Tables[0].Rows[i]["ASTROLOGER_ID"].ToString() + "' , '" + ds.Tables[0].Rows[i]["NAME"].ToString() + "' , '" + i + "');\">BOOK NOW</div>");
                strhtml.Append("</div>");
                strhtml.Append("</div>");
                strhtml.Append("</div>");
                strhtml.Append("<div class='row'>");
                strhtml.Append("<div class='col-xl-6' id='divqus_1'>");
                strhtml.Append("<div><b>Enter Question 1</b><span style='color:red;font-size:.75rem;'> (250 Characters)</span></div>");
                strhtml.Append("<textarea id='txtQuestion_1' maxlength='250' CssClass='form-control' onkeyup='countChar(1)' onblur='countChar(1)' placeholder='Enter Question 1' rows='3' cols='60'></textarea>");
                strhtml.Append("<label id='lblCharater1'>Total Character Count:- <label id='lblMessage_1'>0</label></label>");
                strhtml.Append("</div>");

                strhtml.Append("<div class='col-xl-6'  id='divqus_2' style='Display:none'>");
                strhtml.Append("<div><b>Enter Question 2</b><span style='color:red;font-size:.75rem;'> (250 Characters)</span></div>");
                strhtml.Append("<textarea id='txtQuestion_2'  maxlength='250' CssClass='form-control' onkeyup='countChar(2)' onblur='countChar(2)' placeholder='Enter Question 2' rows='3' cols='60'></textarea>");
                strhtml.Append("<label id='lblCharater2'>Total Character Count:- <label id='lblMessage_2'>0</label></label>");
                strhtml.Append("</div>");

                strhtml.Append("<div class='col-xl-6'  id='divqus_3' style='Display:none'>");
                strhtml.Append("<div><b>Enter Question 3</b><span style='color:red;font-size:.75rem;'> (250 Characters)</span></div>");
                strhtml.Append("<textarea id='txtQuestion_3'  maxlength='250' CssClass='form-control' onkeyup='countChar(3)' onblur='countChar(3)' placeholder='Enter Question 3' rows='3' cols='60'></textarea>");
                strhtml.Append("<label id='lblCharater3'>Total Character Count:- <label id='lblMessage_3'>0</label></label>");
                strhtml.Append("</div>");

                strhtml.Append("<div class='col-xl-6'  id='divqus_4' style='Display:none'>");
                strhtml.Append("<div><b>Enter Question 4</b><span style='color:red;font-size:.75rem;'> (250 Characters)</span></div>");
                strhtml.Append("<textarea id='txtQuestion_4'  maxlength='250' CssClass='form-control' onkeyup='countChar(4)' onblur='countChar(4)' placeholder='Enter Question 4' rows='3' cols='60'></textarea>");
                strhtml.Append("<label id='lblCharater4'>Total Character Count:- <label id='lblMessage_4'>0</label></label>");
                strhtml.Append("</div>");

                strhtml.Append("<div class='col-xl-6'  id='divqus_5' style='Display:none'>");
                strhtml.Append("<div><b>Enter Question 5</b><span style='color:red;font-size:.75rem;'> (250 Characters)</span></div>");
                strhtml.Append("<textarea id='txtQuestion_5'  maxlength='250' CssClass='form-control' onkeyup='countChar(5)' onblur='countChar(5)' placeholder='Enter Question 5' rows='3' cols='60'></textarea>");
                strhtml.Append("<label id='lblCharater5'>Total Character Count:- <label id='lblMessage_5'>0</label></label>");
                strhtml.Append("</div>");

                strhtml.Append("</div>");

                string htmlstrmat = "";
                htmlstrmat = "<p style='display: inherit;margin-bottom: 10px;color: rgb(0, 0, 255);'><strong>Likely questions for you - Career &amp; Job Related</strong></p>";
                htmlstrmat += "<p style='display: inherit;' id=p_1 ><input type='checkbox' id=chk_1 onclick='GetCheckbocData(1);'> 1.I want to switch to another job? Whether it will be beneficial and favourable in a new job?</p>";
                htmlstrmat += "<p style='display: inherit'; id=p_2 ><input type='checkbox' id=chk_2 onclick='GetCheckbocData(2);'> 2.My best time to move to another job in the near future - One - year Horizon ?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_3 ><input type='checkbox' id=chk_3 onclick='GetCheckbocData(3);'> 3.My boss does not listen to me, how to manage him?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_4 ><input type='checkbox' id=chk_4 onclick='GetCheckbocData(4);'> 4.My boss gives me new work without considering what is already is on my plate. How to deal with this ?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_5 ><input type='checkbox' id=chk_5 onclick='GetCheckbocData(5);'> 5.My boss micromanages me, how shall I get out of his clutches?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_6 ><input type='checkbox' id=chk_6 onclick='GetCheckbocData(6);'> 6.My boss is negative towards me and does not give feedback on my performance?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_7 ><input type='checkbox' id=chk_7 onclick='GetCheckbocData(7);'> 7.I am expecting a promotion, what are my chances to get a promotion ?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_8 ><input type='checkbox' id=chk_8 onclick='GetCheckbocData(8);'> 8.I don't get the pay as per my work. What should I do?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_9 ><input type='checkbox' id=chk_9 onclick='GetCheckbocData(9);'> 9.I am baffled with the favoritisms at my workplace, how do I tackle this situation?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_10><input type='checkbox' id=chk_10 onclick='GetCheckbocData(10);'> 10.I have an incompetent manager, and he troubles me a lot, what shall be the best course of action for me?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_11><input type='checkbox' id=chk_11 onclick='GetCheckbocData(11);'> 11.I am not finding any opportunity for advancement despite vacancy exists, how do I convince my boss to promote me?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_12><input type='checkbox' id=chk_12 onclick='GetCheckbocData(12);'> 12.What are the possibilities to get a Government Job?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_13><input type='checkbox' id=chk_13 onclick='GetCheckbocData(13);'> 13.Can I go abroad to work, if Yes, when, and which directions should I try?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_14><input type='checkbox' id=chk_14 onclick='GetCheckbocData(14);'> 14.I want to leave the job and get into my own business.Will I be successful?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_15><input type='checkbox' id=chk_15 onclick='GetCheckbocData(15);'> 15.Want to achieve a Top position in my workplace, what are the chances, and what should I do to attain so astrologically ?</p>";
                htmlstrmat += "<p style='display: inherit;height: 10px;'></p>";

                htmlstrmat += "<p style='display: inherit;margin-bottom: 10px;color: rgb(0, 0, 255);'><strong>Likely questions for you - Money, Wealth & Luxuries</strong></p>";
                htmlstrmat += "<p style='display: inherit;' id=p_16><input type='checkbox' id=chk_16 onclick='GetCheckbocData(16);'> 1.What are the best investment models for me to grow like Reality, Investment, Fixed deposit, and Yellow metal and so on?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_17><input type='checkbox' id=chk_17 onclick='GetCheckbocData(17);'> 2.What shall be my financial status in the near future ?</p>";
                htmlstrmat += "<p style='display: inherit;'  id=p_18><input type='checkbox' id=chk_18 onclick='GetCheckbocData(18);'> 3.Whether My chart confirms gains from Stocks trading?</p>";
                htmlstrmat += "<p style='display: inherit;'  id=p_19><input type='checkbox' id=chk_19 onclick='GetCheckbocData(19);'> 4.I have substantial debts, when will I get rid of this?</p> ";
                htmlstrmat += "<p style='display: inherit;'  id=p_20><input type='checkbox' id=chk_20 onclick='GetCheckbocData(20);'> 5.Prosperity loan payment is a big monkey on my head, what should I do?</p>";
                htmlstrmat += "<p style='display: inherit;'  id=p_21><input type='checkbox' id=chk_21 onclick='GetCheckbocData(21);'> 6.What level of richness can I achieve in my life?</p>";
                htmlstrmat += "<p style='display: inherit;height: 10px;'></p>";

                htmlstrmat += "<p style='display: inherit;margin-bottom: 10px;color: rgb(0, 0, 255);'><strong>Likely questions for you - Love and Relationship Related</strong></p>";
                htmlstrmat += "<p style='display: inherit;' id=p_22><input type='checkbox' id=chk_22 onclick='GetCheckbocData(22);'> 1.When shall I get marry, and what is the best time to get married?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_23><input type='checkbox' id=chk_23 onclick='GetCheckbocData(23);'> 2.How will be my spouse in nature?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_24><input type='checkbox' id=chk_24 onclick='GetCheckbocData(24);'> 3.How much marital bliss, I will have ?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_25><input type='checkbox' id=chk_25 onclick='GetCheckbocData(25);'> 4.Can I have a love which shall get into a Soulmate ?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_26><input type='checkbox' id=chk_26 onclick='GetCheckbocData(26);'> 5.Currently, we have troubles in our life, whether we will be able to continue?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_27><input type='checkbox' id=chk_27 onclick='GetCheckbocData(27);'> 6.Whether I will have inter-caste marriage?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_28><input type='checkbox' id=chk_28 onclick='GetCheckbocData(28);'> 7.Whether I will have arranged marriage?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_29><input type='checkbox' id=chk_29 onclick='GetCheckbocData(29);'> 8.What are Astro and divine remedies for a healthy and long relationship with my soul mate ?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_30><input type='checkbox' id=chk_30 onclick='GetCheckbocData(30);'> 9.What are the possibilities that I will have successful marital bliss ?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_31><input type='checkbox' id=chk_31 onclick='GetCheckbocData(31);'> 10.Whether my life Partner will respect my parents and me?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_32><input type='checkbox' id=chk_32 onclick='GetCheckbocData(32);'> 11.What are the chances that my soul mate may develop extra affairs ?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_33><input type='checkbox' id=chk_33 onclick='GetCheckbocData(33);'> 12.What will be the anger Quotient of my would be?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_34><input type='checkbox' id=chk_34 onclick='GetCheckbocData(34);'> 13.Whether I would be in the habit of digging unpleasant things time and again?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_35><input type='checkbox' id=chk_35 onclick='GetCheckbocData(35);'> 14.Whether I would be soul mate be compatible in love with me?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_36><input type='checkbox' id=chk_36 onclick='GetCheckbocData(36);'> 15 Whether I would be a good listener and forward - looking?</p>";
                htmlstrmat += "<p style='display: inherit;height: 10px;'></p>";

                htmlstrmat += "<p style='display: inherit;margin-bottom: 10px;color: rgb(0, 0, 255);'><strong>Likely questions for you - Wellness &amp; Health Related</strong></p>";
                htmlstrmat += "<p style='display: inherit;' id=p_37><input type='checkbox' id=chk_37 onclick='GetCheckbocData(37);'> 1.What is the significant chronic disease I can face?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_38><input type='checkbox' id=chk_38 onclick='GetCheckbocData(38);'> 2.What are the chances to have a Heart Disease?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_39><input type='checkbox' id=chk_39 onclick='GetCheckbocData(39);'> 3.Can I suffer from Cancer?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_40><input type='checkbox' id=chk_40 onclick='GetCheckbocData(40);'> 4.What are the chances that I can catch Alzheimer's?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_41><input type='checkbox' id=chk_41 onclick='GetCheckbocData(41);'> 5.I get depressed very fast, how should I control it?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_42><input type='checkbox' id=chk_42 onclick='GetCheckbocData(42);'> 6, how long my Gastric trouble will continue and what should I do to control it apart from taking medicines?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_43><input type='checkbox' id=chk_43 onclick='GetCheckbocData(43);'> 7.Are chances of mine getting the hereditary disease?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_44><input type='checkbox' id=chk_44 onclick='GetCheckbocData(44);'> 8.How long my current problem with continue. Kindly resolve?</p>";
                htmlstrmat += "<p style='display: inherit;height: 10px;'></p>";

                htmlstrmat += "<p style='display: inherit;margin-bottom: 10px;color: rgb(0, 0, 255);'><strong>Likely questions for you - Personality Related</strong></p>";
                htmlstrmat += "<p style='display: inherit;' id=p_45><input type='checkbox' id=chk_45  onclick='GetCheckbocData(45);'>  1.I have communication problems. When will it improve and what should I do?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_46><input type='checkbox' id=chk_46  onclick='GetCheckbocData(46);'>  2.Do I need a Mentor?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_47><input type='checkbox' id=chk_47  onclick='GetCheckbocData(47);'>  3.I, lose my control at times, how can I control this ?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_48><input type='checkbox' id=chk_48  onclick='GetCheckbocData(48);'>  4.I have the desire to improve, but I feel low.What can I do on this count ?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_49><input type='checkbox' id=chk_49  onclick='GetCheckbocData(49);'>  5.I lose compassion for my family members and get a lousy name.What are the remedies for this ?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_50><input type='checkbox' id=chk_50  onclick='GetCheckbocData(50);'>  6.I lose my mindfulness at times, and people go away from me.How to manage this astrologically ?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_51><input type='checkbox' id=chk_51  onclick='GetCheckbocData(51);'>  7.Sometimes, my approach is very adamant, though I want to improve, but unable to do so.How do I handle this to ensure my honour?</p>";
                htmlstrmat += "<p style='display: inherit;' id=p_52><input type='checkbox' id=chk_52  onclick='GetCheckbocData(52);'>  8.I keep thinking much beyond a limit and gets depressed, which of my planets is creating such a problem?</p>";
  
                strhtml.Append("<div class='tstdtl'>"+ htmlstrmat + "</div>");
                strhtml.Append("</li>");
           }
        }
        ulAstrologer.InnerHtml = strhtml.ToString();
        ScriptManager.RegisterStartupScript(this, GetType(), "Close Modal Popup", "CheckedRadioButton();", true);

    }
    #endregion
}