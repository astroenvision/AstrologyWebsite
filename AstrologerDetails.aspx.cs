using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AstrologerDetails : System.Web.UI.Page
{
    #region Declarations
    admin obj = new admin();
    subscription Sub_Obj = new subscription();
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["q"] != null)
            {
                string astrologerID = Request.QueryString["q"].ToString();
                BindAstrologer(astrologerID);
            }
            if (Session["UserID"] != null)
            {
                LoadComments();
            }
            BindReviews();
            BindRaiting();

        }
    }
    #endregion

    #region Bind Astrologer
    protected void BindAstrologer(string ID)
    {
        DataSet ds = new DataSet();
        ds = obj.ManageAstrologer("GET_ASTROLOGER_BY_NAME", ID);
        if (ds.Tables[0].Rows.Count > 0)
        {
            hdnAstrologerID.Value = ds.Tables[0].Rows[0]["ASTROLOGER_ID"].ToString();
           string Image = ds.Tables[0].Rows[0]["PHOTO"].ToString();

            if (Image != "")
            {
                Image = "img/" + Image + "";
            }
            else
            {
                Image = "img/Default.jpg";
            }
            imgAstrologer.Src = Image;
            divName.InnerText = ds.Tables[0].Rows[0]["NAME"].ToString();
            divExpertIn.InnerText = ds.Tables[0].Rows[0]["EXPERT_IN"].ToString();
            divExperience.InnerText = ds.Tables[0].Rows[0]["EXPERIENCE"].ToString() + " Years of Experience";
            fullDesc.InnerText = ds.Tables[0].Rows[0]["FULL_DESC"].ToString();
            divAchievement.InnerText = ds.Tables[0].Rows[0]["ACHIEVEMENTS"].ToString();
        }
    }
    #endregion

    #region Save Comments
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        if (Session["UserID"] == null)
        {
            Session["CurrentPage"] = "AstrologerComments";
            Response.Redirect("~/signin.html");
        }
        else
        {
            if(hdnRating.Value == "")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(AstrologerDetails), "wq", "alert('Select atleast one rating!!');", true);
                return;
            }
            string ID = "0";
            if (hdnID.Value !="")
            {
                ID = hdnID.Value;
            }
            string Flag = "INSERT_COMMENTS";
                    if (hdnID.Value != "")
                    {
                        Flag = "UPDATE_COMMENTS";
                    }
            ds = Sub_Obj.SaveAstrolgerComments(Flag, ID, hdnAstrologerID.Value, Session["UserID"].ToString(), txtComments.Text, hdnRating.Value, "A", "0");
            if (ds.Tables[0].Rows.Count > 0)
            {
                string Message = ds.Tables[0].Rows[0]["MESSAGE"].ToString();
                string status = ds.Tables[0].Rows[0]["STATUS"].ToString();
                if (status != "N")
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(AstrologerDetails), "wq", "alert('" + Message + "');", true);
                  
                    LoadComments();
                    BindReviews();
                    BindRaiting();
                   return;
                   }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(AstrologerDetails), "wq", "alert('Some Error in DataBase!');", true);
                    return;
                }

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(AstrologerDetails), "wq", "alert('Some Error in DataBase!');", true);
                return;
            }
        }

    }
    #endregion
   
    #region Load User Comment
    protected void LoadComments()
    {
        DataSet ds = new DataSet();
        ds = Sub_Obj.SaveAstrolgerComments("GET_COMMENTS", "0", "0", Session["UserID"].ToString(), "", "", "0", "0");
        if (ds.Tables[0].Rows.Count > 0)
        {
            txtComments.Text = ds.Tables[0].Rows[0]["COMMENTS"].ToString();
            hdnRating.Value = ds.Tables[0].Rows[0]["RATING"].ToString();
            hdnID.Value = ds.Tables[0].Rows[0]["COMMENT_ID"].ToString();
            btnEdit.Visible = true;
            btnsave.Visible = false;
            if (hdnRating.Value=="1")
            {
                rating_1.Checked = true;
            }
            else if (hdnRating.Value == "2")
            {
                rating_1.Checked = true;
                rating_2.Checked = true;
            }
            else if (hdnRating.Value == "3")
            {
                rating_1.Checked = true;
                rating_2.Checked = true;
                rating_3.Checked = true;
            }
            else if (hdnRating.Value == "4")
            {
                rating_1.Checked = true;
                rating_2.Checked = true;
                rating_3.Checked = true;
                rating_4.Checked = true;
            }
            else if (hdnRating.Value == "5")
            {
                rating_1.Checked = true;
                rating_2.Checked = true;
                rating_3.Checked = true;
                rating_4.Checked = true;
                rating_5.Checked = true;
            }
        }
        else
        {
            btnEdit.Visible = false;
            btnsave.Visible = true;
        }
    }
    #endregion

    #region Bind All Reviwes
    protected void BindReviews()
    {

        DataSet ds = new DataSet();
        string HtmLappend = "";
       
        ds = Sub_Obj.SaveAstrolgerComments("GET_ALL_COMMENTS", "0", "0","0", "", "", "0", "0");
        if (ds.Tables[0].Rows.Count > 0)
        {
            for(int i= 0; i < ds.Tables[0].Rows.Count; i++)
            {

                HtmLappend += "<li>";
                HtmLappend += "<div class='rvwnme'>"+ ds.Tables[0].Rows[i]["NAME"].ToString() + "</div>";
                HtmLappend += "<div class='rvwdte'>" + ds.Tables[0].Rows[i]["CREATED_ON"].ToString() + "</div>";
                HtmLappend += "<div class='rvwstr'>";
                int Rating = Convert.ToInt16(ds.Tables[0].Rows[i]["RATING"].ToString());
                if(Rating> 0)
                {
                    for (int j = 1; j <= Rating; j++)
                    {
                        HtmLappend += "<i class='fa fa-star'></i>";
                    }
                }
                HtmLappend += "</div>";
                HtmLappend += "<div class='rvwcmnt'>" + ds.Tables[0].Rows[i]["COMMENTS"].ToString() + "</div>";
                HtmLappend += "<div style='display:none' class='commentrply'>";
                HtmLappend += "<span></span>";
                HtmLappend += "<div class='rating_light'>" + ds.Tables[0].Rows[i]["NAME"].ToString() + ", <i>" + ds.Tables[0].Rows[i]["CREATED_ON"].ToString() + "</i></div>";
                HtmLappend += "<i>Thank you so much</i>";
                HtmLappend += "</div>";
                HtmLappend += "</li>";

            }
           
        }
        ulReviews.InnerHtml = HtmLappend.ToString();
    }
    #endregion

    #region Bind Raiting Chart
    protected void BindRaiting()
    {
        DataSet ds = new DataSet();
        string HtmlBind = "";
        ds = Sub_Obj.SaveAstrolgerComments("GET_OVERAll_RATING", "0", "0", "0", "", "", "0", "0");
        if (ds.Tables[0].Rows.Count > 0)
        {
            int TotalUser = Convert.ToInt32(ds.Tables[0].Rows[0]["ALLUSER"].ToString());
            spnTotalComments.InnerHtml = TotalUser.ToString() + "<i class='fa fa-comment'></i>";
            spnTotalRating.InnerHtml = "0" + "<i class='fa fa-star'></i>";
            if (TotalUser != 0)
            {
                int TotalRating = Convert.ToInt32(ds.Tables[0].Rows[0]["SUMOFRATING"].ToString());
                double OverAllRating = Convert.ToDouble(Convert.ToDouble(TotalRating) / Convert.ToDouble(TotalUser));
                string[] var = OverAllRating.ToString().Split('.');
                int DesVal = var.Length;
                string Rat = OverAllRating.ToString();
                string AfterDecimal = "0";
                if (DesVal > 1)
                {
                    Rat = var[0];
                  AfterDecimal = var[1];
                }
               
                spnTotalRating.InnerHtml = Math.Round(OverAllRating, 1) + "<i class='fa fa-star'></i>";
                int FiveRating = Convert.ToInt32(ds.Tables[0].Rows[0]["FIVERATING"].ToString());
                double BarFiveRating = Convert.ToDouble((Convert.ToDouble(FiveRating) / Convert.ToDouble(TotalUser)) * 100);
                int FourRating = Convert.ToInt32(ds.Tables[0].Rows[0]["FOURRATING"].ToString());
                double BarFourRating = Convert.ToDouble((Convert.ToDouble(FourRating) / Convert.ToDouble(TotalUser)) * 100);
                int ThreeRating = Convert.ToInt32(ds.Tables[0].Rows[0]["THREERATING"].ToString());
                double BarThreeRating = Convert.ToDouble((Convert.ToDouble(ThreeRating) / Convert.ToDouble(TotalUser)) * 100);
                int TwoRating = Convert.ToInt32(ds.Tables[0].Rows[0]["TWORATING"].ToString());
                double BarTwoRating = Convert.ToDouble((Convert.ToDouble(TwoRating) / Convert.ToDouble(TotalUser)) * 100);
                int OneRating = Convert.ToInt32(ds.Tables[0].Rows[0]["ONERATING"].ToString());
                double BarOneRating = Convert.ToDouble((Convert.ToDouble(OneRating) / Convert.ToDouble(TotalUser)) * 100);

                HtmlBind += "<div class='card-body'>";
                HtmlBind += "<span class='heading'>Average Rating</span>";
                int PendingRating = 5 - Convert.ToInt32(Rat);
                for (int i=1; i<= Convert.ToInt32(Rat);i++)
                {
                HtmlBind += "<span style='font-size: 23px;' class='fa fa-star checked'></span>";
                }
                if (Convert.ToDouble(AfterDecimal) > 0)
                {
                       PendingRating = PendingRating - 1;
                       HtmlBind += "<span style='font-size: 23px;' class='fa fa-star-half-o checked'></span>";
                }
                for (int i = 1; i <= Convert.ToInt32(PendingRating); i++)
                {
                 HtmlBind += "<span style='font-size: 23px;' class='fa fa-star'></span>";
                }
                //HtmlBind +=  "<p> "+ OverAllRating + " average based on "+ TotalRating + " reviews.</p>";
                HtmlBind += "<hr style='border:3px solid #f1f1f1'> ";
                HtmlBind +=   "<div class='row'>";
                HtmlBind +=   "<div class='side'>";
                HtmlBind +=   "<div>5 star</div>";
                HtmlBind +=   "</div>";
                HtmlBind +=   "<div class='middle'>";
                HtmlBind +=   "<div class='bar-container'>";
                HtmlBind += "<div style='width:"+ Convert.ToInt32(BarFiveRating) + "%;height: 18px; background-color: #4CAF50;'></div>";
                HtmlBind +=  "</div>";
                HtmlBind +=  "</div>";
                HtmlBind +=  "<div class='side right'>";
                HtmlBind +=  "<div>"+ FiveRating + "</div>";
                HtmlBind +=  "</div>";
                HtmlBind +=  "<div class='side'>";
                HtmlBind +=  "<div>4 star</div>";
                HtmlBind +=  "</div>";
                HtmlBind +=  "<div class='middle'>";
                HtmlBind +=  "<div class='bar-container'>";
                HtmlBind += "<div style='width:" + Convert.ToInt32(BarFourRating) + "%;height: 18px; background-color:#2196F3;'></div>";
                HtmlBind +=  "</div>";
                HtmlBind +=  "</div>";
                HtmlBind +=  "<div class='side right'>";
                HtmlBind +=  "<div>"+ FourRating + "</div>";
                HtmlBind +=  "</div>";
                HtmlBind +=  "<div class='side'>";
                HtmlBind +=  "<div>3 star</div>";
                HtmlBind +=  "</div>";
                HtmlBind +=  "<div class='middle'>";
                HtmlBind +=  "<div class='bar-container'>";
                HtmlBind += "<div style='width:" + Convert.ToInt32(BarThreeRating) + "%;height: 18px; background-color: #00bcd4;'></div>";
                HtmlBind +=  "</div>";
                HtmlBind +=  "</div>";
                HtmlBind +=  "<div class='side right'>";
                HtmlBind +=  "<div>"+ ThreeRating + "</div>";
                HtmlBind +=  "</div>";
                HtmlBind +=  "<div class='side'>";
                HtmlBind +=  "<div>2 star</div>";
                HtmlBind +=  "</div>";
                HtmlBind +=  "<div class='middle'>";
                HtmlBind +=  "<div class='bar-container'>";
                HtmlBind += "<div style='width:" + Convert.ToInt32(BarTwoRating) + "%;height: 18px; background-color: #ff9800;'></div>";
                HtmlBind +=  "</div>";
                HtmlBind +=  "</div>";
                HtmlBind +=  "<div class='side right'>";
                HtmlBind += "<div>" + TwoRating + "</div>";
                HtmlBind +=  "</div>";
                HtmlBind +=  "<div class='side'>";
                HtmlBind +=  "<div>1 star</div>";
                HtmlBind +=  "</div>";
                HtmlBind +=  "<div class='middle'>";
                HtmlBind +=  "<div class='bar-container'>";
                HtmlBind += "<div style='width:" + Convert.ToInt32(BarOneRating) + "%;height: 18px; background-color: #f44336;'></div>";
                HtmlBind +=  "</div>";
                HtmlBind +=  "</div>";
                HtmlBind +=  "<div class='side right'>";
                HtmlBind += "<div>" + OneRating + "</div>";
                HtmlBind +=  "</div>";
                HtmlBind +=  "</div>";
                HtmlBind += "</div>";
        }
        }
        UserRating.InnerHtml = HtmlBind.ToString();
   }

    #endregion

}