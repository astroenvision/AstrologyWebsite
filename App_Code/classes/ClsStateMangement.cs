using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

public class ClsStateMangement
{

    #region Session Cookie Settings
    private static int IntCookieTimeOut { get { return int.Parse(ConfigurationManager.AppSettings["CookieTimeout"]); } }

    private const string StrUserName = "UserName";
    private const string StrUserId = "UserID";
    private const string StrUserEmailId = "UserEmailID";
    private const string MySessionID = "MYSESSIDVAL";
    #endregion
    public static void SetUserLogin(HttpContext Context, string UserID, string UserEmailID, string UserName, string StateManagement)
    {
        if(StateManagement== "COOKIE")
        {
            SetCookies(StrUserId, UserID, IntCookieTimeOut, Context);
            SetCookies(StrUserEmailId, UserEmailID, IntCookieTimeOut, Context);
            SetCookies(StrUserName, UserName, IntCookieTimeOut, Context);
        }
        if(StateManagement == "SESSION")
        {
            //Session["UserID"] = UserID;
            //Session["UserEmailID"] = UserEmailID;
            //Session["UserName"] = UserName;
            SetSession(StrUserId, UserID, Context);
            SetSession(StrUserEmailId, UserEmailID, Context);
            SetSession(StrUserName, UserName, Context);
        }
     }
    public static void SetUserCartID(HttpContext Context ,string value,string StateManagement)
    {
        if (StateManagement == "COOKIE")
        {
            SetCookies(MySessionID, value, IntCookieTimeOut, Context);
        }
        if (StateManagement == "SESSION")
        {
            SetSession(MySessionID, value, Context);
        }
    }
    public static string GetUserName(HttpContext context)
    {
        return GetCookies(StrUserName, context);
    }
    public static string GetUserId(HttpContext context)
    {
        return GetCookies(StrUserId, context);
    }

    public static string GetMyCartID(HttpContext context)
    {
        return GetCookies(MySessionID, context);
    }
    public static string GetEmailID(HttpContext context)
    {
        return GetCookies(StrUserEmailId, context);
    }
    public static string GetCookies(string CookieName, HttpContext Context)
    {
        if (Context.Request.Cookies[CookieName] == null)
            return GetSession(CookieName, Context);
        else
            return Context.Request.Cookies[CookieName].Value.ToString();
    }
    public static bool HasUserLogin(HttpContext context)
    {
        return GetHasUserLogin(context) != -1;
    }
    public static int GetHasUserLogin(HttpContext context)
    {
        try { return int.Parse(GetCookies(StrUserId, context)); }
        catch { return -1; }
    }

    public static string HasUserCartID(HttpContext context)
    {
        return GetHasUserCartID(context);
    }

    public static string GetHasUserCartID(HttpContext context)
    {
        try { return GetCookies(MySessionID, context); }
        catch { return ""; }
    }



    public static void SetCookies(string CookieName, string Value, int ExpireDays, HttpContext Context)
    {
        HttpCookie cookie = new HttpCookie(CookieName);
        cookie.Value = Value;
        cookie.Expires = DateTime.Now.AddDays(ExpireDays);
        Context.Response.Cookies.Add(cookie);
    }
    public static void ReleaseUserLogin(HttpContext context)
    {
        //DeleteCookies(StrUserId, context);
        //DeleteCookies(StrUserEmailId, context);
        //DeleteCookies(StrUserName, context);
        //DeleteCookies(MySessionID, context);
        context.Session["MySessionID"] = null;
        context.Session["UserID"] = null;
        context.Session["UserEmailID"] = null;
        context.Session["UserName"] = null;
        context.Session["MyCartCount"] = null;
    }
    public static void DeleteCookies(string CookieName, HttpContext Context)
    {
        HttpCookie cookie = Context.Request.Cookies["MYSESSIDVAL"];
        if (cookie != null)
        {
            cookie.Expires = DateTime.Now.AddDays(-1);
            Context.Response.Cookies.Add(cookie);
            ClearCookies(Context);
            DeleteSession(CookieName, Context);
        }
    }

    #region Get And Set Sessions
    public static void SetSession(string SessionName, string Value, HttpContext Context)
    {
        Context.Session.Add(SessionName, Value);
    }

    public static string GetSession(string SessionName, HttpContext Context)
    {
        if (Context.Session[SessionName] == null)
            return "";
        else
            return Context.Session[SessionName].ToString();
    }

    public static void DeleteSession(string SessionName, HttpContext Context)
    {
        if (Context.Session[SessionName] != null)
            Context.Session[SessionName] = null;
    }

    public static void ClearCookies(HttpContext Context)
    {
        Context.Response.Cookies.Clear();
        ClearSession(Context);
    }
    public static void ClearSession(HttpContext Context)
    {
        Context.Session.Clear();
        Context.Session.Abandon();
    }
    #endregion
}