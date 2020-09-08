using ASTROLOGY.classesoracle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Free_Ask_Question_Ans : System.Web.UI.Page
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
            //HtmlMeta meta = new HtmlMeta();
            //meta.Name = "robots";
            //meta.Content = "noindex,follow";
            ////Header.Controls.Add(tag);  // This Line is used without Master Page
            //Master.FindControl("head").Controls.Add(meta); // This Line is used with Master Page

            if (Session["UserID"] != null)
            {
                BindAns();
            }
            else
            {
                Session["CurrentPage"] = "FREE_ASK_ONE_QUESTION_ANS";
                Response.Redirect(ResolveUrl("~/signin.html"));
            }
        }
    }
    #endregion

    #region Bind Ans
    protected void BindAns()
    {
        if (Session["UserID"] != null)
        {
            DataSet ds = new DataSet();
            string HtmLappend = "";
            ds = Sub_Obj.SaveClientQuestion("GET_DETAILS_BY_USERID", "0", "", "", "", "", "", "", "", "", "", Session["UserID"].ToString(), "", "", "", "", "");
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i]["ANSWER"].ToString() != "")
                    {
                        HtmLappend += "<li>";
                        HtmLappend += "<div class='rvwnme'>" + ds.Tables[0].Rows[i]["QUESTION"].ToString() + "</div>";
                        HtmLappend += "<div class='rvwdte'>" + ds.Tables[0].Rows[i]["CRTD_DATE"].ToString() + "</div>";
                        HtmLappend += "<div class='rvwcmnt'>" + ds.Tables[0].Rows[i]["ANSWER"].ToString() + "</div>";
                        HtmLappend += "<div class='row'>";
                        HtmLappend += "<div class='col-xl-12'  style='Display:none' id ='divComnt_" + i + "'>";

                        HtmLappend += "<textarea id='txtComnt_" + ds.Tables[0].Rows[i]["QUESTION_ID"].ToString() + "' maxlength='250' CssClass='form-control' placeholder='Write your comment' rows='3' cols='60'></textarea>";

                        HtmLappend += "<div style=\"clear:both;\"></div><div style='margin-left: 7px; cursor: pointer;' onclick=\"SaveLike('SaveComnt','" + ds.Tables[0].Rows[i]["QUESTION_ID"].ToString() + "' , '" + Session["UserID"].ToString() + "','" + Session["UserEmailID"].ToString() + "'); \"><i class=\"fa fa-floppy-o\" aria-hidden=\"true\"></i> Save</div>";

                        HtmLappend += "</div>";
                        HtmLappend += "</div>";

                        HtmLappend += "<div>";
                        HtmLappend += "<div style='margin-left: 7px; cursor: pointer;display: inline-block;' onclick=\"SaveLike('SaveLike','" + ds.Tables[0].Rows[i]["QUESTION_ID"].ToString() + "' , '" + Session["UserID"].ToString() + "','" + Session["UserEmailID"].ToString() + "'); \"><i class=\"fa fa-thumbs-up\" aria-hidden=\"true\"></i> Like</div>";
                        HtmLappend += "<div style='margin-left: 20px; cursor: pointer;display: inline-block;' onclick = \"ShowCommntbox('" + i + "')\"><i class=\"fa fa-comment\" aria-hidden=\"true\"></i> Comment</div>";
                        HtmLappend += "</div>";

                        DataSet dsComnt = Sub_Obj.SaveClientQuestionComment("GET_DETAILS", "0", ds.Tables[0].Rows[i]["QUESTION_ID"].ToString(), "", "", "", "", "", "");
                        if (dsComnt.Tables[0].Rows.Count > 0)
                        {
                            HtmLappend += "<div class='rvwnme' style='margin-top: 10px;margin-bottom: 6px;'>Comments</div>";
                            for (int j = 0; j < dsComnt.Tables[0].Rows.Count; j++)
                            {
                                HtmLappend += "<span style='color: #000;margin-left: 15px;'><b>" + dsComnt.Tables[0].Rows[j]["NAME"].ToString() + "</b></span><br/>";
                                HtmLappend += "<div class='rvwcmnt' style='margin-left: 15px;'>" + dsComnt.Tables[0].Rows[j]["COMMENT_DTLS"].ToString() + "<div class='rvwcmnt'>" + dsComnt.Tables[0].Rows[j]["CRTD_DATE"].ToString() + "</div></div>";
                                if (dsComnt.Tables[0].Rows[j]["COMMENTREPLY"].ToString() != "Write your reply")
                                {

                                    HtmLappend += "<div class='rvwcmnt' style='margin-left: 30px;'><span style='color: #000;'><b>Reply By Hari Sharma</b></span><br/> " + dsComnt.Tables[0].Rows[j]["COMMENTREPLY"].ToString() + "</div>";
                                }
                            }
                        }
                        HtmLappend += "</li>";

                        ulUserAns.InnerHtml = HtmLappend.ToString();
                    }
                }
            }
            //else
            //{
            //    Session["CurrentPage"] = "FREE_ASK_ONE_QUESTION_ANS";
            //    Response.Redirect(ResolveUrl("~/signin.html"));
            //}
        }
    }

    #endregion
}