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
using AjaxControlToolkit;
using System.IO;
using System.Diagnostics;
using ASTROLOGY.classesoracle;
using System.Web.Services;
using System.Text.RegularExpressions;

public partial class login : System.Web.UI.Page
{
    //string head = "";
    //string keyword = "";
    //string snopsis = "";
    //string story = "";
    //string state_inner = "";
    common cs_obj = new common();
    ASTROLOGY.classesoracle.myaccount obj_mc = new ASTROLOGY.classesoracle.myaccount();
    ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
    public string WEBSITEDomain = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    string mail = "astrology";
    string strHtml = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["MySessionID"] == null || Session["MySessionID"].ToString() == "")
        {
            string intrandom = Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day) + Convert.ToString(DateTime.Now.Hour) + Convert.ToString(DateTime.Now.Minute) + Convert.ToString(DateTime.Now.Second) + Convert.ToString(DateTime.Now.Millisecond);
            Session["MySessionID"] = intrandom;
        }
        if (Session["endusermail"] != null && Session["name"]!=null)
        {
            //loginid.InnerText = "" + Session["name"].ToString() + "";
            ////logoutid.InnerHtml = "<a onclick=\"javascript:loginoutenduser();\">Log Out</a>";
            //logoutid.InnerHtml = "";
            //middleloginid.Style.Add("display", "none");

            loginid.InnerHtml = "Login";
            //logoutid.InnerHtml = "<a href=\"" + ResolveUrl("astro_registration.aspx?user=1") + "\">Register Now ?</a>";
            //logoutid.InnerHtml = "<a href=\"" + ResolveUrl("userregistration.aspx") + "\">Register Now ?</a>";
            logoutid.InnerHtml = "<a href=\"" + ResolveUrl("registration.html") + "\">Create My Account (New Users)</a>";
            middleloginid.Style.Add("display", "block");
        }
        else
        {
            loginid.InnerHtml = "Login";
            //logoutid.InnerHtml = "<a href=\"" + ResolveUrl("astro_registration.aspx?user=1") + "\">Register Now ?</a>";
            //logoutid.InnerHtml = "<a href=\"" + ResolveUrl("userregistration.aspx") + "\">Register Now ?</a>";
            logoutid.InnerHtml = "<a href=\"" + ResolveUrl("registration.html") + "\">Create My Account (New Users)</a>";
            middleloginid.Style.Add("display", "block");
        }

        Ajax.Utility.RegisterTypeForAjax(typeof(login));
        //BindHoraCategories();
        //BindNatalCategories();

        //BindHoraryHighlightes();  //Horary Highlights
        //BindNatalHighlightes();   //Natal Highlights
        //BindHoraryAstrology();    //Know about Horary Astrology
        //BindNatalAstrology();     //Know about Natal Astrology

        //Session["usermail"] = mail;
        DataSet objDataSet = new DataSet();
        objDataSet.ReadXml(Server.MapPath("ast.xml/login.xml"));
    }
    protected void btnsignin_Click(object sender, EventArgs e)
    {
        DataSet ds1 = new DataSet();
        string mail = txtusername1.Text.ToString().ToLower();
        string pass = txtpwd1.Text.ToString();
        //ds1 = cs_obj.search_astro(mail, pass);
        ds1 = cs_obj.CheckLogin(mail, pass, "", "");
        if (ds1.Tables[0].Rows.Count > 0)
        {
            string UserType = ds1.Tables[0].Rows[0]["USER_TYPE"].ToString().Trim();
            string UserActive = ds1.Tables[0].Rows[0]["ACTIVE"].ToString().Trim();
            string pwd = ds1.Tables[0].Rows[0]["PASSWORD"].ToString().Trim();
            string usermail = ds1.Tables[0].Rows[0]["MAINMAIL"].ToString().Trim();
            if (UserType == "1" && UserActive == "T")
            {
                if (pwd == pass)
                {
                    Session["usermail"] = mail;
                    usermail = mail;
                    Response.Redirect("myaccount.aspx?usermail=" + usermail);
                    //loginid.InnerText = "Welcome: " + username + "";
                    //logoutid.InnerHtml = "<a onclick=\"javascript:loginoutenduser();\">Log Out</a>";
                    //middleloginid.Style.Add("display", "none");
                    //Session["endusermail"] = mail;
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(login), "wq", "alert('Your Password is Incorrect !');", true);
                }
            }
            else if (UserActive == "F")
            {
                Response.Redirect("astro_registration_reactivation.aspx?UserID=" + usermail + "&Flag=D");
            }
        }
        else if (ds1.Tables[0].Rows.Count == 0)
        {
            DataSet dscl = new DataSet();
            dscl = obj_subs.CheckLoginEndUser(mail, pass, "", "", "CHECKENDUSERLOGIN");
            if (dscl.Tables[0].Rows.Count > 0)
            {
                string flag = dscl.Tables[0].Rows[0]["flag"].ToString().Trim();
                if (flag == "YES")
                {
                    string emailval = dscl.Tables[1].Rows[0]["EMAILID"].ToString().Trim();
                    //loginid.InnerText = "" + username + "";
                    ////logoutid.InnerHtml = "<a onclick=\"javascript:loginoutenduser();\">Log Out</a>";
                    //logoutid.InnerHtml = "";
                    //middleloginid.Style.Add("display", "none");
                    Session["endusermail"] = emailval;
                    Session["usermail"] = emailval;
                    Response.Redirect("login.aspx");
                }
                if (flag == "NO")
                {
                    string flag2 = dscl.Tables[1].Rows[0]["flag"].ToString().Trim();
                    if (flag2 == "NOT REGISTERED")
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(login), "wq", "alert('Your email address is not registered!');", true);
                        return;
                    }
                    if (flag2 == "INVALID PASSOWRD")
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(login), "wq", "alert('Your password is invalid please try again!');", true);
                        return;
                    }
                }
            }
            dscl.Dispose();
        }
        //else if (ds1.Tables[1].Rows.Count != 0)
        //{
        //    string usermail = ds1.Tables[1].Rows[0]["CLIENT_EMAILID"].ToString().Trim();
        //    string username = ds1.Tables[1].Rows[0]["CLIENT_NAME"].ToString().Trim();
        //    loginid.InnerText = "Welcome: " + username + "";
        //    logoutid.InnerHtml = "<a onclick=\"javascript:loginoutenduser();\">Log Out</a>";
        //    middleloginid.Style.Add("display", "none");
        //    Session["endusermail"] = usermail;
        //    Session["name"] = username;
        //}
        else if (ds1.Tables[1].Rows.Count == 0)
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(login), "wq", "alert('Your Password is Incorrect !');", true);
        }
        else
        {
            Response.Redirect("astro_registration_reactivation.aspx?UserID=" + mail + "&Flag=NR");
        }
        ds1.Dispose();
    }
    public void BindHoraryAstrology()
    {
        DataSet dsh = new DataSet();
        dsh = obj_mc.GetArticles("5", "HORARY", "0","");
        if (dsh.Tables[0].Rows.Count != 0)
        {
            string Cat_name = dsh.Tables[2].Rows[0]["CAT_NAME"].ToString();
            string caturl = cs_obj.ReplaceQuotes(Cat_name);
            caturl = cs_obj.OptimizeURL(caturl);
            horary_astroid.InnerHtml = "<li><a>" + Cat_name + "</a>";
            horary_astroid.InnerHtml += "<ul>";
            for (int i = 0; i < dsh.Tables[0].Rows.Count; i++)
            {
                string NewsId = dsh.Tables[0].Rows[i]["NEWS_ID"].ToString();
                string CatId = dsh.Tables[0].Rows[i]["CATID"].ToString();
                string Headline = dsh.Tables[0].Rows[i]["HEADLINE"].ToString();
                Headline = Regex.Replace(Headline, @"<[^>]+>|&nbsp;", "").Trim();
                Headline = Regex.Replace(Headline, @"\s{2,}", " ");
                string headline_url = cs_obj.ReplaceQuotes(Headline);
                headline_url = cs_obj.OptimizeURL(headline_url);
                horary_astroid.InnerHtml += "<li>";
                //horary_astroid.InnerHtml += "<a href=\"" + ResolveUrl("~/article/article.aspx?groupid=horary&catid=" + CatId + "&articleid=" + NewsId + "") + "\">" + Headline + "</a>";
                horary_astroid.InnerHtml += "<a href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url + "/" + CatId + "-" + NewsId + ".html") + "\">" + Headline + "</a>";
                horary_astroid.InnerHtml += "</li>";
            }
            horary_astroid.InnerHtml += "</ul>";
            horary_astroid.InnerHtml += "</li>";
        }
        dsh.Dispose();
    }
    public void BindNatalAstrology()
    {
        DataSet dsn = new DataSet();
        dsn = obj_mc.GetArticles("6", "NATAL", "0", "");
        if (dsn.Tables[0].Rows.Count != 0)
        {
            string Cat_name = dsn.Tables[2].Rows[0]["CAT_NAME"].ToString();
            string caturl = cs_obj.ReplaceQuotes(Cat_name);
            caturl = cs_obj.OptimizeURL(caturl);
            natal_astroid.InnerHtml = "<li><a>" + Cat_name + "</a>";
            natal_astroid.InnerHtml += "<ul>";
            for (int i = 0; i < dsn.Tables[0].Rows.Count; i++)
            {
                string NewsId = dsn.Tables[0].Rows[i]["NEWS_ID"].ToString();
                string CatId = dsn.Tables[0].Rows[i]["CATID"].ToString();
                string Headline = dsn.Tables[0].Rows[i]["HEADLINE"].ToString();
                Headline = Regex.Replace(Headline, @"<[^>]+>|&nbsp;", "").Trim();
                Headline = Regex.Replace(Headline, @"\s{2,}", " ");
                string headline_url = cs_obj.ReplaceQuotes(Headline);
                headline_url = cs_obj.OptimizeURL(headline_url);
                natal_astroid.InnerHtml += "<li>";
                //natal_astroid.InnerHtml += "<a href=\"" + ResolveUrl("~/article/article.aspx?groupid=natal&catid=" + CatId + "&articleid=" + NewsId + "") + "\">" + Headline + "</a>";
                natal_astroid.InnerHtml += "<a href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url + "/" + CatId + "-" + NewsId + ".html") + "\">" + Headline + "</a>";
                natal_astroid.InnerHtml += "</li>";
            }
            natal_astroid.InnerHtml += "</ul>";
            natal_astroid.InnerHtml += "</li>";
        }
        dsn.Dispose();
    }
    public void BindHoraryHighlightes()
    {
        DataSet dsn = new DataSet();
        dsn = obj_mc.GetArticles("1", "HORARY", "0", "");
        if (dsn.Tables[0].Rows.Count != 0)
        {
            strHtml = "<ul class=\"rslides\" id=\"slider1\">";
            for (int i = 0; i < dsn.Tables[0].Rows.Count; i++)
            {
                string NewsId = dsn.Tables[0].Rows[i]["NEWS_ID"].ToString();
                string CatId = dsn.Tables[0].Rows[i]["CATID"].ToString();
                string Headline = dsn.Tables[0].Rows[i]["HEADLINE"].ToString();
                Headline = Regex.Replace(Headline, @"<[^>]+>|&nbsp;", "").Trim();
                Headline = Regex.Replace(Headline, @"\s{2,}", " ");
                string headline_url = cs_obj.ReplaceQuotes(Headline);
                headline_url = cs_obj.OptimizeURL(headline_url);
                string synopsis = dsn.Tables[0].Rows[i]["SYNOPSIS"].ToString();
                synopsis = Regex.Replace(synopsis, @"<[^>]+>|&nbsp;", "").Trim();
                synopsis = Regex.Replace(synopsis, @"\s{2,}", " ");
                string authorimg = dsn.Tables[0].Rows[i]["AUTHOR_IMG"].ToString();
                string author = dsn.Tables[0].Rows[i]["AUTHOR"].ToString();
                string catname = dsn.Tables[2].Rows[0]["CAT_NAME"].ToString();
                string caturl = cs_obj.ReplaceQuotes(catname);
                caturl = cs_obj.OptimizeURL(caturl);
                int j = i + 1;
                strHtml += "<li>";
                strHtml += "<p>";
                if (Headline != "")
                {
                    strHtml += "<b style='color: #F25E0A;'>" + Headline + "</b><br />";
                }
                strHtml += "" + synopsis + "";
                strHtml += "<br />";
                //strHtml += "<a class='readmorecss' href=\"" + ResolveUrl("~/article/article.aspx?groupid=horary&catid=" + CatId + "&articleid=" + NewsId + "") + "\">read more..</a>";
                strHtml += "<a class='readmorecss' href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url + "/" + CatId + "-" + NewsId + ".html") + "\">read more..</a>";
                strHtml += "</p>";
                strHtml += "</li>";
            }
            strHtml += "</ul>";
            horaryhighlightid.InnerHtml = strHtml;
        }
        dsn.Dispose();
    }
    public void BindNatalHighlightes()
    {
        strHtml = "";
        DataSet dsn = new DataSet();
        dsn = obj_mc.GetArticles("2", "NATAL", "0", "");
        if (dsn.Tables[0].Rows.Count != 0)
        {
            strHtml = " <ul class=\"rslides\" id=\"slider2\">";
            for (int i = 0; i < dsn.Tables[0].Rows.Count; i++)
            {
                string NewsId = dsn.Tables[0].Rows[i]["NEWS_ID"].ToString();
                string CatId = dsn.Tables[0].Rows[i]["CATID"].ToString();
                string Headline = dsn.Tables[0].Rows[i]["HEADLINE"].ToString();
                Headline = Regex.Replace(Headline, @"<[^>]+>|&nbsp;", "").Trim();
                Headline = Regex.Replace(Headline, @"\s{2,}", " ");
                string headline_url = cs_obj.ReplaceQuotes(Headline);
                headline_url = cs_obj.OptimizeURL(headline_url);
                string synopsis = dsn.Tables[0].Rows[i]["SYNOPSIS"].ToString();
                synopsis = Regex.Replace(synopsis, @"<[^>]+>|&nbsp;", "").Trim();
                synopsis = Regex.Replace(synopsis, @"\s{2,}", " ");
                string authorimg = dsn.Tables[0].Rows[i]["AUTHOR_IMG"].ToString();
                string author = dsn.Tables[0].Rows[i]["AUTHOR"].ToString();
                string catname = dsn.Tables[2].Rows[0]["CAT_NAME"].ToString();
                string caturl = cs_obj.ReplaceQuotes(catname);
                caturl = cs_obj.OptimizeURL(caturl);
                int j = i + 1;
                strHtml += "<li>";
                strHtml += "<p>";
                if (Headline != "")
                {
                    strHtml += "<b style='color: #F25E0A;'>" + Headline + "</b><br />";
                }
                strHtml += "" + synopsis + "";
                strHtml += "<br />";
                //strHtml += "<a class='readmorecss' href=\"" + ResolveUrl("~/article/article.aspx??groupid=natal&catid=" + CatId + "&articleid=" + NewsId + "") + "\">read more..</a>";
                strHtml += "<a class='readmorecss' href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url + "/" + CatId + "-" + NewsId + ".html") + "\">read more..</a>";
                strHtml += "</p>";
                strHtml += "</li>";
            }
            strHtml += "</ul>";
            natalhighlightid.InnerHtml = strHtml;
        }
        dsn.Dispose();
    }

    public void BindHoraCategories()
    {
        DataSet ds = cs_obj.Get_Hora_cat();
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string h_desc = "";
                string h_code = ds.Tables[0].Rows[i]["CODE_ID"].ToString();
                string h_name = ds.Tables[0].Rows[i]["CODE"].ToString();
                h_desc = ds.Tables[0].Rows[i]["CATEGORY_DESC"].ToString();
                h_desc = h_desc.Replace("'", "&#39;");
                //h_desc = h_desc.Replace("http//", "").Replace("https//", "");
                h_desc = h_desc.Replace("localhost/astrology", WEBSITEDomain);
                h_desc = h_desc.Replace("http//", "");
                h_desc = h_desc.Replace("http://beta.astroenvision.com", "www.astroenvision.com");
                h_desc = ""; //Add deepak 16/06/2020 for reomve error

                int priority = Convert.ToInt32(ds.Tables[0].Rows[i]["PRIORITY"].ToString());
                string cssflag = "1";
                
                if (priority == 1)
                {
                    cssflag = "1";
                    horaleftid.InnerHtml += "<h1 class=\"cathead_left_white\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=horary&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                }
                else if (priority == 2)
                {
                    cssflag = "3";
                    horaleftid.InnerHtml += "<h1 class=\"cathead_left_gray\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=horary&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                }
                else if (priority == 3)
                {
                    cssflag = "1";
                    horaleftid.InnerHtml += "<h1 class=\"cathead_left_white\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=horary&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                }
                else if (priority == 4)
                {
                    cssflag = "3";
                    horaleftid.InnerHtml += "<h1 class=\"cathead_left_gray\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=horary&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                }
                else if (priority == 5)
                {
                    cssflag = "2";
                    horaleftid.InnerHtml += "<h1 class=\"cathead_left_gray\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=horary&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                }

                else if (priority == 6)
                {
                    cssflag = "1";
                    horaleftid.InnerHtml += "<h1 class=\"cathead_left_white\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=horary&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                    //horamiddleid.InnerHtml = "<h1 class=\"cathead_middle\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' onmouseover='tooltip.pop(this, \"" + h_desc + "\")' style='letter-spacing: 5px;' class=\"cathead_middle_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=horary&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                }
                if (priority == 7)
                {
                    cssflag = "2";
                    horaleftid.InnerHtml += "<h1 class=\"cathead_left_gray\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=horary&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                    //horarightid.InnerHtml = "<h1 class=\"cathead_right\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' style='font-size: 0.55em;' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=horary&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                }
                else if (priority == 8)
                {
                    cssflag = "1";
                    horaleftid.InnerHtml += "<h1 class=\"cathead_left_white\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=horary&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                    //horarightid.InnerHtml += "<h1 class=\"cathead_right\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=horary&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                }
                else if (priority == 9)
                {
                    cssflag = "3";
                    horaleftid.InnerHtml += "<h1 class=\"cathead_left_white\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=horary&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                    //horarightid.InnerHtml += "<h1 class=\"cathead_right\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' style='font-size: 0.60em;' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=horary&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                }
                else if (priority == 10)
                {
                    cssflag = "1";
                    horaleftid.InnerHtml += "<h1 class=\"cathead_left_gray\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=horary&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                    //horarightid.InnerHtml += "<h1 class=\"cathead_right\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' style='font-size: 0.75em;' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=horary&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                }
                else if (priority == 11)
                {
                    cssflag = "3";
                    horaleftid.InnerHtml += "<h1 class=\"cathead_left_white\" style='width:48%;'><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=horary&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                    //horarightid.InnerHtml += "<h1 class=\"cathead_right\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' style='font-size: 0.70em;' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=horary&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                }
                //Deepak Added below line for horary message
                horaleftid.InnerHtml = "";
                horaleftid.InnerHtml = "<h3 id='blinker' style='text-align: center;color:#F4600A;'>Yet to be Live</h3>";
            }
        }
    }

    public void BindNatalCategories()
    {
        string strHtmlNatalFirst = "", strHtmlNatalSecond = "", strHtmlNatalThird = "" ;
        DataSet ds = cs_obj.Get_Natal_cat("");
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string h_desc = "";
                string h_code = ds.Tables[0].Rows[i]["FINAL_CATID"].ToString();
                string h_name = ds.Tables[0].Rows[i]["FINAL_CATEGERY"].ToString();
                h_desc = ds.Tables[0].Rows[i]["CATEGORY_DESC"].ToString();
                h_desc = h_desc.Replace("'", "&#39;");
                //h_desc = h_desc.Replace("http//", "").Replace("https//", "");
                h_desc = h_desc.Replace("http://localhost/astrology", WEBSITEDomain);
                //h_desc = h_desc.Replace("http//", "");
                //h_desc = h_desc.Replace("http://beta.astroenvision.com", "www.astroenvision.com");

                string h_name_url = cs_obj.ReplaceQuotes(h_name);
                h_name_url = cs_obj.OptimizeURL(h_name_url);
                string finalurl = "category/" + h_name_url + "/natal/" + h_code + "-" + Session["MySessionID"].ToString() + ".html";
                //strHtml += "<a class='readmorecss' href=\"" + ResolveUrl("~/astrology/" + caturl + "/" + headline_url + "/" + CatId + "-" + NewsId + ".html") + "\">read more..</a>";
                int priority = Convert.ToInt32(ds.Tables[0].Rows[i]["PRIORITY"].ToString());
                string cssflag = "1";
                if (priority<=12)
                {
                    if (priority == 1)
                    {
                        strHtmlNatalFirst += "<div class=\"leftcat\" id=\"natalleftid\" runat=\"server\">";
                        cssflag = "3";
                        strHtmlNatalFirst += "<h1 class=\"cathead_left_white\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 2)
                    {
                        cssflag = "2";
                        //strHtmlNatalFirst += "<h1 class=\"cathead_left_gray\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\"\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                        strHtmlNatalFirst += "<h1 class=\"cathead_left_gray\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\"\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 3)
                    {
                        cssflag = "1";
                        strHtmlNatalFirst += "<h1 class=\"cathead_left_white\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 4)
                    {
                        cssflag = "2";
                        strHtmlNatalFirst += "<h1 class=\"cathead_left_gray\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 5)
                    {
                        cssflag = "2";
                        strHtmlNatalFirst += "<h1 class=\"cathead_left_gray\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 6)
                    {
                        cssflag = "3";
                        strHtmlNatalFirst += "<h1 class=\"cathead_left_white\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 7)
                    {
                        cssflag = "2";
                        strHtmlNatalFirst += "<h1 class=\"cathead_left_gray\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 8)
                    {
                        cssflag = "1";
                        strHtmlNatalFirst += "<h1 class=\"cathead_left_white\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 9)
                    {
                        cssflag = "1";
                        strHtmlNatalFirst += "<h1 class=\"cathead_left_white\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 10)
                    {
                        cssflag = "2";
                        strHtmlNatalFirst += "<h1 class=\"cathead_left_gray\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 11)
                    {
                        cssflag = "3";
                        strHtmlNatalFirst += "<h1 class=\"cathead_left_white\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 12)
                    {
                        cssflag = "2";
                        strHtmlNatalFirst += "<h1 class=\"cathead_left_gray\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                        strHtmlNatalFirst += "</div>";
                    }
                }
                else if (priority >= 13 && priority <= 24)
                {
                    if (priority == 13)
                    {
                        strHtmlNatalSecond += "<div class=\"leftcat\" id=\"natalrightid\" runat=\"server\">";
                        cssflag = "3";
                        strHtmlNatalSecond += "<h1 class=\"cathead_left_white\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 14)
                    {
                        cssflag = "2";
                        strHtmlNatalSecond += "<h1 class=\"cathead_left_gray\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 15)
                    {
                        cssflag = "1";
                        strHtmlNatalSecond += "<h1 class=\"cathead_left_white\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 16)
                    {
                        cssflag = "3";
                        strHtmlNatalSecond += "<h1 class=\"cathead_left_gray\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 17)
                    {
                        cssflag = "1";
                        strHtmlNatalSecond += "<h1 class=\"cathead_left_gray\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 18)
                    {
                        cssflag = "3";
                        strHtmlNatalSecond += "<h1 class=\"cathead_left_white\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 19)
                    {
                        cssflag = "2";
                        strHtmlNatalSecond += "<h1 class=\"cathead_left_gray\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 20)
                    {
                        cssflag = "1";
                        strHtmlNatalSecond += "<h1 class=\"cathead_left_white\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 21)
                    {
                        cssflag = "3";
                        strHtmlNatalSecond += "<h1 class=\"cathead_left_white\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 22)
                    {
                        cssflag = "1";
                        strHtmlNatalSecond += "<h1 class=\"cathead_left_gray\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 23)
                    {
                        cssflag = "3";
                        strHtmlNatalSecond += "<h1 class=\"cathead_left_white\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                    }
                    if (priority == 24)
                    {
                        cssflag = "2";
                        strHtmlNatalSecond += "<h1 class=\"cathead_left_gray\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/" + finalurl + "") + "\">" + h_name + "</a></h1>";
                        strHtmlNatalSecond += "</div>";
                    }
                }
                //else if (priority == 6)
                //{
                //    cssflag = "2";
                //    strHtmlNatalFirst += "<h1 class=\"cathead_left_white\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //    //strHtmlNatalFirst += "<div class=\"middlecat\" style=\"width: 190px;\" id=\"natalmiddleid\" runat=\"server\">";
                //    //strHtmlNatalFirst += "<h1 style='margin:27% 0% 0% -31%' class=\"cathead_middle\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' style='font-size: 0.80em;' class=\"cathead_middle_1\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //    //strHtmlNatalFirst += "</div>";
                //}
                //else if (priority >= 7 && priority < 12)
                //{
                //    if (priority == 7)
                //    {
                //        strHtmlNatalFirst += "<div class=\"rightcat\" style=\"margin:0% 0% 0% -24%\" id=\"natalrightid\" runat=\"server\">";
                //        cssflag = "2";
                //        strHtmlNatalFirst += "<h1 class=\"cathead_right\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";

                //        strHtmlNatalSecond = "<div class=\"leftcat\" id=\"natalleftid\" runat=\"server\">";
                //        cssflag = "2";
                //        strHtmlNatalSecond += "<h1 class=\"cathead_left\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //    }
                //    if (priority == 8)
                //    {
                //        cssflag = "1";
                //        strHtmlNatalFirst += "<h1 class=\"cathead_right\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";

                //        cssflag = "1";
                //        strHtmlNatalSecond += "<h1 class=\"cathead_left\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //    }
                //    if (priority == 9)
                //    {
                //        cssflag = "2";
                //        strHtmlNatalFirst += "<h1 class=\"cathead_right\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";

                //        cssflag = "2";
                //        strHtmlNatalSecond += "<h1 class=\"cathead_left\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //    }
                //    if (priority == 10)
                //    {
                //        cssflag = "1";
                //        strHtmlNatalFirst += "<h1 class=\"cathead_right\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";

                //        cssflag = "1";
                //        strHtmlNatalSecond += "<h1 class=\"cathead_left\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //    }
                //    if (priority == 11)
                //    {
                //        cssflag = "3";
                //        strHtmlNatalFirst += "<h1 class=\"cathead_right\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //        strHtmlNatalFirst += "</div>";

                //        cssflag = "3";
                //        strHtmlNatalSecond += "<h1 class=\"cathead_left\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //        strHtmlNatalSecond += "</div>";
                //    }
                //}
                //else if (priority == 12)
                //{
                //    cssflag = "1";
                //    strHtmlNatalSecond += "<div class=\"middlecat\" style=\"width: 205px;\" id=\"natalmiddleid\" runat=\"server\">";
                //    //strHtmlNatalSecond += "<h1 style='margin:25% 0% 0% -28%;letter-spacing:1px;' class=\"cathead_middle\"><a style='font-size: 0.70em;color:#F4600A;' class=\"cathead_middle_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //    strHtmlNatalSecond += "<h1 style='margin:25% 0% 0% -28%;letter-spacing:1px;' class=\"cathead_middle\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' style='font-size: 0.70em;color:#F4600A;' class=\"cathead_middle_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //    //strHtmlNatalSecond += "<h1 id=\"tooltip\" style='margin:25% 0% 0% -28%;letter-spacing:1px;' class=\"cathead_middle\"><a style='font-size: 0.70em;color:#F4600A;' class=\"cathead_middle_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "<span class=\"tooltiptext\"><b>Why is this Software important to know about the Manglik Dosha results ?</b>This Software gives correct result of  non- existnce or existence of Manglik Dosha in Percentage using a complex and established ancient methodology.<b>Critical to match Manglik Dosha ?</b>The placement of Mars in certain positions in a Birth Chart creates Manglik Dosha and if one out of the Boy & Girl does not have the Manglik dosha and go ahead with marriage; then it is very likely that this relation would lead to disharmony, disbalance and to an extent of death of one of them depending on the serverity of the presence of Manglik Dosh in the Chart.<b>Significance:</b>Manglik dosha or Kuja Dosha compatibility between the Prospective Bride and Groom s Birth Chart is  considered  to be very Important by vast majority of people across the world.</span></a></h1>";
                //    strHtmlNatalSecond += "</div>";
                //}
                //else if (priority >= 13 && priority <= 18)
                //{
                //    if (priority == 13)
                //    {
                //        strHtmlNatalSecond += "<div class=\"rightcat\" style=\"margin:0% 0% 0% -26%\" id=\"natalrightid\" runat=\"server\">";
                //        cssflag = "3";
                //        //h_desc = "<p><strong>Why is this Software important to know about the Dosha-Samya results ?</strong> This Software gives correct result of &nbsp;non- existnce or existence of Dosha Samya in Percentage using a complex and established ancient methodology. How to get best use of this compatibility methodoly has been explained well for user&#39;s.</p><p><strong>Critical to match Dosha Samya?</strong> The placement of Major Malefic planets namely Mars, Saturn, Rahu and Sun in certain positions in &nbsp;Birth Chart, Moon chart and Venus Chart creates Dosha Samya. There is a very high probability that some percentage of dosha will exists in every Individual&#39;s Chart. As mentioned the Dosha Samya is sum of overall malefic influence being created by malefic planets. Avoiding the matching of Dosha Samya is very likely to lead disharmony, short lived love &amp; compassion, financial crisis, health issues and so on between the couple.</p><p><strong>Significance:</strong> Compatibilitty according to Doshya Samya methodology between the prospective Bride and Groom&#39;s birth Charts is considered &nbsp;to be very important by vast majority of people in south India and some other part of country wants to be compliant to Dosha Samya for grand positive results in married life.</p>";
                //        //strHtmlNatalSecond += "<h1 class=\"cathead_right\"><a style='font-size: 0.60em;' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //        strHtmlNatalSecond += "<h1 class=\"cathead_right\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' style='font-size: 0.60em;' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //        //strHtmlNatalSecond += "<h1 id=\"tooltip\" class=\"cathead_right\"><a style='font-size: 0.60em;' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "<span class=\"tooltiptext\"><b>Why is this Software important to know about the Manglik Dosha results ?</b>This Software gives correct result of  non- existnce or existence of Manglik Dosha in Percentage using a complex and established ancient methodology.<b>Critical to match Manglik Dosha ?</b>The placement of Mars in certain positions in a Birth Chart creates Manglik Dosha and if one out of the Boy & Girl does not have the Manglik dosha and go ahead with marriage; then it is very likely that this relation would lead to disharmony, disbalance and to an extent of death of one of them depending on the serverity of the presence of Manglik Dosh in the Chart.<b>Significance:</b>Manglik dosha or Kuja Dosha compatibility between the Prospective Bride and Groom s Birth Chart is  considered  to be very Important by vast majority of people across the world.</span></a></h1>";

                //        strHtmlNatalThird = "<div class=\"leftcat\" id=\"natalleftid\" runat=\"server\">";
                //        cssflag = "3";
                //        strHtmlNatalThird += "<h1 class=\"cathead_left\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' style='font-size: 0.60em;' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //    }
                //    if (priority == 14)
                //    {
                //        cssflag = "2";
                //        strHtmlNatalSecond += "<h1 class=\"cathead_right\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' style='font-size: 0.60em;' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";

                //        cssflag = "2";
                //        strHtmlNatalThird += "<h1 class=\"cathead_left\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' style='font-size: 0.60em;' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //    }
                //    if (priority == 15)
                //    {
                //        cssflag = "1";
                //        strHtmlNatalSecond += "<h1 class=\"cathead_right\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' style='font-size: 0.60em;' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";

                //        cssflag = "1";
                //        strHtmlNatalThird += "<h1 class=\"cathead_left\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' style='font-size: 0.60em;' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //    }
                //    if (priority == 16)
                //    {
                //        cssflag = "3";
                //        strHtmlNatalSecond += "<h1 class=\"cathead_right\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";

                //        cssflag = "3";
                //        strHtmlNatalThird += "<h1 class=\"cathead_left\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //    }
                //    if (priority == 17)
                //    {
                //        cssflag = "1";
                //        strHtmlNatalSecond += "<h1 class=\"cathead_right\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' style='font-size: 0.60em;' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";

                //        cssflag = "1";
                //        strHtmlNatalThird += "<h1 class=\"cathead_left\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' style='font-size: 0.60em;' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //    }
                //    if (priority == 18)
                //    {
                //        cssflag = "2";
                //        strHtmlNatalSecond += "<h1 class=\"cathead_right\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' style='font-size: 0.60em;' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //        strHtmlNatalSecond += "</div>";

                //        cssflag = "2";
                //        strHtmlNatalThird += "<h1 class=\"cathead_left\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' style='font-size: 0.60em;' class=\"cathead_left_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //        strHtmlNatalThird += "</div>";
                //    }
                //}
                //else if (priority == 19)
                //{
                //    cssflag = "1";
                //    strHtmlNatalThird += "<div class=\"middlecat\" style=\"width: 205px;\" id=\"natalmiddleid\" runat=\"server\">";
                //    strHtmlNatalThird += "<h1 style='margin:24% 0% 0% -27%' class=\"cathead_middle\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' style='font-size: 0.70em;letter-spacing: 4px;' class=\"cathead_middle_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //    strHtmlNatalThird += "</div>";
                //}
                //else if (priority >= 20 && priority <= 24)
                //{
                //    if (priority == 20)
                //    {
                //        strHtmlNatalThird += "<div class=\"rightcat\" style=\"margin:0% 0% 0% -26%\" id=\"natalrightid\" runat=\"server\">";
                //        cssflag = "1";
                //        strHtmlNatalThird += "<h1 class=\"cathead_right\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' style='font-size: 0.55em;' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //    }
                //    if (priority == 21)
                //    {
                //        cssflag = "2";
                //        strHtmlNatalThird += "<h1 class=\"cathead_right\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //    }
                //    if (priority == 22)
                //    {
                //        cssflag = "1";
                //        strHtmlNatalThird += "<h1 class=\"cathead_right\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' style='font-size: 0.60em;' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //    }
                //    if (priority == 23)
                //    {
                //        cssflag = "3";
                //        strHtmlNatalThird += "<h1 class=\"cathead_right\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //    }
                //    if (priority == 24)
                //    {
                //        cssflag = "2";
                //        strHtmlNatalThird += "<h1 class=\"cathead_right\"><a onmouseover='tooltip.pop(this, \"" + h_desc + "\")' style='font-size: 0.75em;' class=\"cathead_right_" + cssflag + "\" href=\"" + ResolveUrl("~/article/questions.aspx?groupid=natal&catid=" + h_code + "&cartid=" + Session["MySessionID"].ToString() + "") + "\">" + h_name + "</a></h1>";
                //        strHtmlNatalThird += "</div>";
                //    }
                //}
                
                
            }
            natalcatfirst.InnerHtml = strHtmlNatalFirst;
            natalcatsecond.InnerHtml = strHtmlNatalSecond;
           // natalcatthird.InnerHtml = strHtmlNatalThird;
        }
    }


    public void BindHoraCategory_Questions(string code)
    {
        string codeval = code;
    }


    [Ajax.AjaxMethod]
    public DataSet Show_Harary_Questions(string code)
    {
        DataSet ds = new DataSet();

        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            common cs_obj = new common();
            ds = cs_obj.Get_Harary_Questions(code);
        }
        return ds;
    }

    [WebMethod(EnableSession = true)]
    public static string LogOut()
    {
        try
        {
            HttpContext.Current.Session["endusermail"]= null;
            return "null";
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
