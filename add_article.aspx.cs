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

public partial class add_article : System.Web.UI.Page
{
    dailyarticle objda = new dailyarticle();
    DataSet ds = new DataSet();
    string groupid = "", catid="",headline="",synopsis="",fulldetails="",author="",authorimg="",status="A",priority="0",crtdby="";
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((Session["adminuseremail"] != null) && (Session["adminuseremail"].ToString() != ""))
        {
            crtdby = Session["adminuseremail"].ToString();
            if (!Page.IsPostBack)
            {
                for (int i = 0; i <= 20; i++)
                {
                    ddlpriority.Items.Add(i.ToString());
                }
                if (Request["NewsId"] != null && Request["NewsId"].ToString() != "")
                {
                    try
                    {
                        updateid.Visible = true;
                        submitid.Visible = false;
                        ViewState["NewsId"] = Request["NewsId"];
                        ds = objda.Get_Article_Data("0", "0", ViewState["NewsId"].ToString().Trim(),"","","");
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            ddlgroup.SelectedValue = ds.Tables[1].Rows[0]["GROUP_ID"].ToString();
                            DataSet dsc = new DataSet();
                            dsc = objda.Get_Categories("",ddlgroup.SelectedValue.ToString().Trim(), "");
                            if (dsc.Tables[0].Rows.Count > 0)
                            {
                                ddlcat.DataSource = dsc;
                                ddlcat.DataValueField = "CAT_ID";
                                ddlcat.DataTextField = "CAT_NAME";
                                ddlcat.DataBind();
                                ddlcat.SelectedValue = ds.Tables[1].Rows[0]["CATID"].ToString();
                            }
                            dsc.Dispose();

                            txtheadline.Text = ds.Tables[1].Rows[0]["HEADLINE"].ToString();
                            txtsynopsis.Text = ds.Tables[1].Rows[0]["SYNOPSIS"].ToString();
                            rtedetails.Value = ds.Tables[1].Rows[0]["FULLSTORY"].ToString();
                            txtauthor.Text = ds.Tables[1].Rows[0]["AUTHOR"].ToString();
                            ddlstatus.SelectedValue = ds.Tables[1].Rows[0]["APPROVE"].ToString();
                            ddlpriority.SelectedValue = ds.Tables[1].Rows[0]["PRIORITY"].ToString();
                            ViewState["authorimg"] = ds.Tables[1].Rows[0]["AUTHOR_IMG"].ToString();
                            if (ViewState["authorimg"].ToString() == "")
                            {
                                imgauthor.ImageUrl = "Image/no_thumb.jpg";
                            }
                            else
                            {
                                //imgauthor_filename.Value = "Image/" + ViewState["authorimg"].ToString().Trim() + "";
                                imgauthor.ImageUrl = "Image/" + ViewState["authorimg"].ToString().Trim() + "";
                            }
                        }
                        ds.Dispose();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    updateid.Visible = false;
                    submitid.Visible = true;
                }
            }
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(add_article), "wq", "window.parent.location.href='loginadmin.aspx'", true);
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        try
        {
            groupid = ddlgroup.SelectedValue.ToString().Trim();
            catid = ddlcat.SelectedValue.ToString().Trim();
            headline = txtheadline.Text.ToString().Trim();
            synopsis = txtsynopsis.Text.ToString().Trim();
            fulldetails = rtedetails.Value.ToString().Trim();
            author = txtauthor.Text.ToString().Trim();
            status = ddlstatus.SelectedValue.ToString().Trim();
            priority = ddlpriority.SelectedValue.ToString().Trim();
            if (imgauthorfilename.PostedFile.ContentLength != 0)
            {
                authorimg = imgauthorfilename.PostedFile.FileName.ToString();
                authorimg = objda.uploadsw(authorimg, "Image", imgauthorfilename);
            }
            ds = objda.Save_Article(groupid, catid, headline, synopsis, fulldetails, author, authorimg, status, priority, crtdby,"","","","","");
            if (ds.Tables[0].Rows.Count > 0)
            {
                string flag = ds.Tables[0].Rows[0]["flag"].ToString().Trim();
                if (flag == "Y")
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(add_article), "wq", "alert('Record saved successfully !');", true);
                    txtheadline.Text = "";
                    txtsynopsis.Text = "";
                    rtedetails.Value = "";
                    txtauthor.Text = "";
                    return;
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(add_article), "wq", "alert('Record saved failed !');", true);
                    return;
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(add_article), "wq", "alert('Data Saved failed !');", true);
                return;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        try
        {
            groupid = ddlgroup.SelectedValue.ToString().Trim();
            catid = ddlcat.SelectedValue.ToString().Trim();
            headline = txtheadline.Text.ToString().Trim();
            synopsis = txtsynopsis.Text.ToString().Trim();
            fulldetails = rtedetails.Value.ToString().Trim();
            author = txtauthor.Text.ToString().Trim();
            status = ddlstatus.SelectedValue.ToString().Trim();
            priority = ddlpriority.SelectedValue.ToString().Trim();
            if (imgauthorfilename.PostedFile.ContentLength != 0)
            {
                authorimg = imgauthorfilename.PostedFile.FileName.ToString();
                authorimg = objda.uploadsw(authorimg, "Image", imgauthorfilename);
                authorimg = ViewState["authorimg"].ToString();
            }
            else
            {
                authorimg = ViewState["authorimg"].ToString();
            }
            ds = objda.Update_Article(groupid, catid, headline, synopsis, fulldetails, author, authorimg, status, priority, crtdby, ViewState["NewsId"].ToString().Trim(),"","","","");
            if (ds.Tables[0].Rows.Count > 0)
            {
                string flag = ds.Tables[0].Rows[0]["flag"].ToString().Trim();
                if (flag == "Y")
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(add_article), "wq", "alert('Record updated successfully !');", true);
                    return;
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(add_article), "wq", "alert('Record updated failed !');", true);
                    return;
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(add_article), "wq", "alert('Data updated failed !');", true);
                return;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    protected void ddlgroup_SelectedIndexChanged(object sender, EventArgs e)
    {
        groupid = ddlgroup.SelectedValue.ToString().Trim();
        ds = objda.Get_Categories("",groupid,"");
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
}
