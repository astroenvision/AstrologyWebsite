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
using System.Net.Mail;
using System.Security.Cryptography;
using System.IO;
using ASTROLOGY.classesoracle;

public partial class mod_article : System.Web.UI.Page
{
    dailyarticle objda = new dailyarticle();
    DataSet ds = new DataSet();
    string groupid = "", catid = "", headline = "", synopsis = "", fulldetails = "", author = "", authorimg = "", status = "A", priority = "0", crtdby = "";
    static int rn = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((Session["adminuseremail"] != null) && (Session["adminuseremail"] != ""))
        {
            crtdby = Session["adminuseremail"].ToString();
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(mod_article), "wq", "window.parent.location.href='loginadmin.aspx'", true);
        }
    }

    protected void btnsearch_Click(object sender, EventArgs e)
    {
        try
        {
            rn = 0;
            bindgridnews();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    void bindgridnews()
    {
        try
        {
            catid = ddlcat.SelectedValue.ToString().Trim();
            groupid = ddlgroup.SelectedValue.ToString().Trim();
            ds = objda.Get_Article_Data(catid, groupid, "0","","","");
            if (ds.Tables[0].Rows.Count > 0)
            {
                grdviews.Visible = true;
                grdviews.DataSource = ds;
                grdviews.DataBind();
            }
            ds.Dispose();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    protected void ddlgroup_SelectedIndexChanged(object sender, EventArgs e)
    {
        groupid = ddlgroup.SelectedValue.ToString().Trim();
        catid = ddlcat.SelectedValue.ToString().Trim();
        ds = objda.Get_Categories("",groupid, catid);
        if (ds.Tables[0].Rows.Count > 0)
        {
            ddlcat.DataSource = ds;
            ddlcat.DataValueField = "CAT_ID";
            ddlcat.DataTextField = "CAT_NAME";
            ddlcat.DataBind();
            ddlcat.Items.Insert(0, "--Select Category--");
        }
        ds.Dispose();
    }
    protected void grdviews_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdviews.PageIndex = e.NewPageIndex;
        rn = 0;
        bindgridnews();
    }
    protected void grdviews_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        DataRowView drv = e.Row.DataItem as DataRowView;
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Label lbrowno = (Label)e.Row.FindControl("lblrowno");
            rn = rn + 1;
            lbrowno.Text = Convert.ToString(rn);
            HyperLink btnmodify = (HyperLink)(e.Row.FindControl("btnedit"));
            Label lblnewsid = (Label)e.Row.FindControl("lblnewsid");
            Label lblcatid = (Label)e.Row.FindControl("lblcatid");
            btnmodify.NavigateUrl = ResolveUrl("~/add_article.aspx?NewsId=" + lblnewsid.Text.Trim() + "");

            catid = ddlcat.SelectedValue.ToString().Trim();
            ds = objda.Get_Categories("",groupid, catid);
            if (ds.Tables[1].Rows.Count > 0)
            {
                lblcatid.Text = ds.Tables[1].Rows[0]["CAT_NAME"].ToString();
            }
            ds.Dispose();

            e.Row.Attributes.Add("onmouseover", "MouseEvents(this, event)");
            e.Row.Attributes.Add("onmouseout", "MouseEvents(this, event)");
        }
    }

    protected void btndelete_Click(object sender, EventArgs e)
    {
        try
        {
            bool flag = false;
            string flag_chk = "N";
            foreach (GridViewRow grow in grdviews.Rows)
            {
                CheckBox chkdel = (CheckBox)grow.FindControl("CheckBox1");
                if (chkdel.Checked)
                {
                    Label lblnewsid = (Label)grow.FindControl("lblnewsid");
                    Label lblauthorimg = (Label)grow.FindControl("lblauthorimg");
                    ds = objda.Delete_Article_Data(lblnewsid.Text.ToString().Trim());
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        flag_chk = ds.Tables[0].Rows[0]["flag"].ToString();
                        if (File.Exists(Server.MapPath("Image/" + lblauthorimg.Text.ToString().Trim())))
                        {
                            File.Delete(Server.MapPath("Image/" + lblauthorimg.Text.ToString().Trim()));
                        }
                    }
                    ds.Dispose();
                    flag = true;
                }
            }
            if (flag == true && flag_chk == "Y")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(mod_article), "wq", "alert('Record Deleted successfully !');", true);
            }
            else if (flag == true && flag_chk == "N")
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(mod_article), "wq", "alert('Record Not Deleted !');", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(mod_article), "wq", "alert('Select at least one checkbox !');", true);
            }
            rn = 0;
            bindgridnews();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
