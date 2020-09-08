using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ASTROLOGY.classesoracle;
using System.Configuration;

public partial class admin_EditArticleRequest : System.Web.UI.Page
{

    #region Declaration
    public string ID = "0";
    dailyarticle obj = new dailyarticle();
    public string AdminStateManagement = ConfigurationManager.AppSettings["AdminStateManagement"].ToString();
    public string AdminCookieTimeoutType = ConfigurationManager.AppSettings["AdminCookieTimeoutType"].ToString();
    public string AdminCookieTimeout = ConfigurationManager.AppSettings["AdminCookieTimeout"].ToString();
    public string AdminUserId = "", AdminEmailId = "";
    #endregion

    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (AdminStateManagement == "COOKIE")
        {
            if (Request.Cookies["AdminCookies"] != null)
            {
                AdminUserId = Request.Cookies["AdminCookies"]["AdminUserId"].ToString();
                if (Request.QueryString["q"] != "")
                {
                    ID = Request.QueryString["q"].ToString();
                }
                if (!IsPostBack)
                {
                    LoadData(ID);
                }
            }
            else
            {
                Response.Redirect(ResolveUrl("~/admin"));
            }
        }
        else
        {
            if (Session["AdminUserId"] != null)
            {
                AdminUserId = Session["AdminUserId"].ToString();
                if (Request.QueryString["q"] != "")
                {
                    ID = Request.QueryString["q"].ToString();
                }
                if (!IsPostBack)
                {
                    LoadData(ID);
                }
            }
            else
            {
                Response.Redirect(ResolveUrl("~/admin"));
                return;
            }
        }
    }
    #endregion

    #region LoadData
    protected void LoadData(string NewID)
    {
        if (NewID == "0") return;
        DataSet ds = new DataSet();

        ds = obj.Get_ArticleData_ByID("GET_ARTICLES_ID", NewID);
        if (ds.Tables[0].Rows.Count > 0)
        {
            lblCatID.Text = ds.Tables[0].Rows[0]["CATID"].ToString();
            lblStatus.Text = ds.Tables[0].Rows[0]["APPROVE"].ToString();
            if (ds.Tables[0].Rows[0]["AUTHOR"].ToString() != "")
            {
                txtName.Text = ds.Tables[0].Rows[0]["AUTHOR"].ToString();
            }

            if (ds.Tables[0].Rows[0]["CAT_NAME"].ToString() != "")
            {
                txtCatName.Text = ds.Tables[0].Rows[0]["CAT_NAME"].ToString();
            }


            if (ds.Tables[0].Rows[0]["GROUP_ID"].ToString() != "")
            {
                txtGroupName.Text = ds.Tables[0].Rows[0]["GROUP_ID"].ToString();
            }


            if (ds.Tables[0].Rows[0]["PRIORITY"].ToString() != "")
            {
                ddlPriority.SelectedValue = ds.Tables[0].Rows[0]["PRIORITY"].ToString();
            }


            if (ds.Tables[0].Rows[0]["HEADLINE"].ToString() != "")
            {
                txtHeadLine.Text = ds.Tables[0].Rows[0]["HEADLINE"].ToString();
            }

            if (ds.Tables[0].Rows[0]["SYNOPSIS"].ToString() != "")
            {
                fckSynopsis.Value = ds.Tables[0].Rows[0]["SYNOPSIS"].ToString();
            }

            if (ds.Tables[0].Rows[0]["FULLSTORY"].ToString() != "")
            {
                rtedetails.Value = ds.Tables[0].Rows[0]["FULLSTORY"].ToString();
            }

            if (ds.Tables[0].Rows[0]["AUTHOR_IMG"].ToString() != "")
            {
                string Image = ds.Tables[0].Rows[0]["AUTHOR_IMG"].ToString();
                imgauthor.ImageUrl = "~/Image/" + Image + "";
                divUserImg.Visible = true;
            }
            else
            {
                divUserImg.Visible = false;
            }
        }
        else
        {

        }
    }
    #endregion

    #region Update Click
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        ds = obj.Update_Article(txtGroupName.Text.Trim(), lblCatID.Text, txtHeadLine.Text.Trim(), fckSynopsis.Value, rtedetails.Value,
            txtName.Text.Trim(), imgauthor.ImageUrl, lblStatus.Text, ddlPriority.SelectedValue, "", ID,"","","","");
        if (ds.Tables[0].Rows.Count > 0)
        {
            if (ds.Tables[0].Rows[0]["FLAG"].ToString() == "Y")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_EditArticleRequest), "wq", "alert('Records Updated Sucessfully!!');", true);
                //Response.AddHeader("REFRESH", "2;URL=/astrology/admin/ApproveArticles.aspx");
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(admin_EditArticleRequest), "wq", "alert('Some Error Occured!!');", true);
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(admin_EditArticleRequest), "wq", "alert('Some Error Occured!!');", true);
        }
    }
    #endregion

}