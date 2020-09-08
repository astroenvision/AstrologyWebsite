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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((Session["adminuseremail"] != null) && (Session["adminuseremail"].ToString() != ""))
        {
            Response.Expires = -1;
            Response.Buffer = true;
            Response.ExpiresAbsolute = DateTime.Now.AddDays(-1d);
            Response.Expires = -1500;
            //Response.CacheControl = "no-cache";
            //Session["compcode"] = "HT001";
            //Session["username"] = "ankur";
            Ajax.Utility.RegisterTypeForAjax(typeof(_Default));

            //if (Request.QueryString["compname"] != "" && Request.QueryString["compname"]!=null)
            //{
            //    Session["centername"] = Request.QueryString["unitname"].ToString();
            //    Session["comp_name"] = Request.QueryString["compname"].ToString();
            //    Session["Username"] = Request.QueryString["compcode"].ToString();
            //    Session["userid"] = Request.QueryString["userid"].ToString();
            //    Session["compcode"] = Request.QueryString["compcode"].ToString();
            //    Session["dateformat"] = Request.QueryString["dateformat"].ToString();
            //    Session["center"] = Request.QueryString["unit"].ToString();
            //}
            //if (Session["compcode"] != null)
            //{

            //}
            //else
            //{
            //    //Response.Redirect("http://localhost/Circulation/login.aspx");
            //    //Response.Redirect("logout.aspx");
            //    //Response.Write("<script>window.parent.location=\"login.aspx\";</script>");
            //    //li.Text = "<script>window.parent.location=\"login.aspx\";</script>";
            //    Response.Redirect("login.aspx");
            //    return;
            //}
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(_Default), "wq", "window.parent.location.href='loginadmin.aspx'", true);
        }

    }
    protected void Leftbar1_Load(object sender, EventArgs e)
    {

    }
    //[Ajax.AjaxMethod]
    //public DataSet chkpermissionagency(string userid)
    //{
        
    //       Circulation.Classes.pop per = new Circulation.Classes.pop();
    //        DataSet ds = new DataSet();
    //        ds = per.checkPrevuser(userid);
    //        return ds;

    //}
    //[Ajax.AjaxMethod]
    //public DataSet givepermision(string userid, string compcode, string formname)
    //{
    //    DataSet ds = new DataSet();
    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "sql")
    //    {
    //        //Circulation.Classes.Master per = newCirculation.Classes.Master();
    //        //ds = per.givepermission(userid, compcode, formname);
    //        //return ds;
    //        /* cha*/
    //    }
    //    else if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        // deletepermition_new.deletepermition_new_p
    //       Circulation.classesoracle.reportconfirm per = new Circulation.classesoracle.reportconfirm();
    //        ds = per.givepermission(userid, compcode, formname);
    //        return ds;
    //        /* cha*/
    //    }
    //    else
    //    {
    //       Circulation.classmysql.Master per = new Circulation.classmysql.Master();
    //        ds = per.givepermission(userid, compcode, formname);
            
    //    }
    //    return ds;
    }

   
