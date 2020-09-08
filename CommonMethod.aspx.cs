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
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using ASTROLOGY.classesoracle;
using System.Collections.Generic;
using System.Text;
using System.Web.Services;
using System.IO;
using Newtonsoft.Json;
public partial class CommonMethod : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    #region LogOut
    [WebMethod]
    public static string Logout()
    {
        string result = "1";
        HttpContext.Current.Session["UserID"] = null;
        HttpContext.Current.Session["UserEmailID"] = null;
        HttpContext.Current.Session["MyCartCount"] = null;
        HttpContext.Current.Session["UserName"] = null;
        return result;
    }
    #endregion

    #region AddToCart
    [WebMethod]
    public static string AddToCart(string CatName, string CatId, string GroupId, string Flag)
    {
        ASTROLOGY.classesoracle.main obj_main = new ASTROLOGY.classesoracle.main();
        ASTROLOGY.classesoracle.subscription obj_subs = new ASTROLOGY.classesoracle.subscription();
        string result = "0";
        string MyCatId = HttpContext.Current.Session["MySessionID"].ToString();

        if (Flag == "GetTotalCount")
        {
            DataSet dsc = obj_subs.GetAddToCart(MyCatId, "", "", "", "GETALLQUESTIONS");
            if (dsc.Tables[0].Rows.Count > 0)
            {
                result = dsc.Tables[0].Rows.Count.ToString();
                HttpContext.Current.Session["MyCartCount"] = result;
            }
            dsc.Dispose();
        }
        else
        {
            common cs_obj = new common();
            string flag_output2 = "", usertype = "2";
            //bool flagactive = false;
            //if (HttpContext.Current.Session["UserEmailID"] == null || HttpContext.Current.Session["UserEmailID"].ToString() == "")
            //{
            //    return result;
            //}
            //else
            //{

            DataSet dsnc = cs_obj.Get_Natal_Questions(CatId);
            if (dsnc.Tables[0].Rows.Count > 0)
            {
                DataSet dsmaxid = new DataSet();
                dsmaxid = obj_main.GetMaxId("AUTOID", "ADDTOCART");
                int gallmaxid = 0;
                if (dsmaxid.Tables[0].Rows.Count > 0)
                {
                    gallmaxid = Convert.ToInt32(dsmaxid.Tables[0].Rows[0]["MAXID"].ToString().Trim());
                }
                dsmaxid.Dispose();

                string ActualPrice = "", FinalPrice = "", discountval = "";
                decimal discount, discountprice, FinalPriceVal;
                DataSet ds2 = obj_subs.AstGetCommon(CatId, "2", GroupId.ToUpper(), "GETCATEGORYPRICE");
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    string GetCurrencyType = "";
                    if (HttpContext.Current.Session["CountryCode"] != null)
                    {
                        GetCurrencyType = HttpContext.Current.Session["CountryCode"].ToString();
                    }
                    if (GetCurrencyType == "")
                    {
                        ActualPrice = ds2.Tables[0].Rows[0]["PRICE_INR"].ToString();
                        discountval = ds2.Tables[0].Rows[0]["DISCOUNT_INR"].ToString();
                        if (discountval != "" && discountval != "0" && discountval != "NULL")
                        {
                            discount = decimal.Parse(discountval);
                            discountprice = decimal.Parse(ActualPrice) * (discount / 100);
                            FinalPriceVal = decimal.Parse(ActualPrice) - discountprice;
                            FinalPrice = FinalPriceVal.ToString();
                            //actualtotalamt.InnerText = "Amount: ₹ " + ActualPrice + "";
                            //discountper.InnerText = "You Save: ₹ " + discountprice + " (" + discountval + "%)";
                        }
                        else
                        {
                            FinalPrice = ActualPrice;
                        }
                        //totalamt.InnerText = "Fee Payable: ₹ " + FinalPrice + "";
                        //ViewState["FinalPrice"] = FinalPrice;
                    }
                    else
                    {
                        ActualPrice = ds2.Tables[0].Rows[0]["PRICE_INR"].ToString();
                        discountval = ds2.Tables[0].Rows[0]["DISCOUNT_INR"].ToString();
                        if (discountval != "" && discountval != "0" && discountval != "NULL")
                        {
                            discount = decimal.Parse(discountval);
                            discountprice = decimal.Parse(ActualPrice) * (discount / 100);
                            FinalPriceVal = decimal.Parse(ActualPrice) - discountprice;
                            FinalPrice = FinalPriceVal.ToString();
                            //actualtotalamt.InnerText = "Amount: $ " + ActualPrice + "";
                            //discountper.InnerText = "You Save: $ " + discountprice + " (" + discountval + "%)";
                        }
                        else
                        {
                            FinalPrice = ActualPrice;
                        }
                        //totalamt.InnerText = "Fee Payable: $ " + FinalPrice + " (USD)";
                        //ViewState["FinalPrice"] = FinalPrice;
                    }
                }
                ds2.Dispose();

                string categoryid = CatId;
                string totalques = dsnc.Tables[0].Rows.Count.ToString();
                for (int i = 0; i < dsnc.Tables[0].Rows.Count; i++)
                {
                    string categotyname = dsnc.Tables[0].Rows[i]["Category_name"].ToString();
                    string questionid = dsnc.Tables[0].Rows[i]["QUESTION_ID"].ToString();
                    string questionval = dsnc.Tables[0].Rows[i]["QUESTION"].ToString();

                    DataSet ds = obj_subs.AddToCart(gallmaxid, MyCatId, "", categoryid, categotyname, questionid, questionval, totalques, "", FinalPrice, usertype, GroupId.ToUpper(), "INSERT");
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        //flag_output1 = ds.Tables[0].Rows[0]["flag"].ToString().Trim();
                        //flagactive = true;
                        flag_output2 = ds.Tables[1].Rows[0]["flag2"].ToString().Trim();
                        if (flag_output2 == "SUCCESS")
                        {
                            //flagactive = true;
                        }
                        //else if (flag_output2 == "FAILD")
                        //{
                        //    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('You can choose only One Category at one Point of time. You have already chosen " + precatname.ToString().ToUpper() + " Category. Do You want to Change the Query Category ');", true);
                        //    return;
                        //}
                        else if (flag_output2 == "EXIST")
                        {
                            //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "confirm('You have already chosen these Questions .');", true);
                            //return;
                        }
                    }
                    ds.Dispose();
                }

                DataSet dsc = obj_subs.GetAddToCart(MyCatId, "", "", "", "GETALLQUESTIONS");
                if (dsc.Tables[0].Rows.Count > 0)
                {
                    result = dsc.Tables[0].Rows.Count.ToString();
                    HttpContext.Current.Session["MyCartCount"] = result;
                }
                dsc.Dispose();
            }
            dsnc.Dispose();

        }

        //}
        return result;
    }
    #endregion

    #region DeleteCategoryID

    [WebMethod]
    public static string DeleteCategoryID(string CartId, string CatId)
    {
        DataSet ds = new DataSet();
        string Result;
        ASTROLOGY.classesoracle.subscription obj = new ASTROLOGY.classesoracle.subscription();
        ds = obj.GetMyCartDetails(CartId, "", "", CatId, "", "DELETECATEGORY");
        if (ds.Tables[0].Rows.Count > 0)
        {
            string GetCount = Convert.ToString(HttpContext.Current.Session["MyCartCount"]);
            HttpContext.Current.Session["MyCartCount"] = Convert.ToString(Convert.ToInt32(GetCount) - Convert.ToInt32(1));
            Result = "1";
        }
        else
        {
            Result = "0";
        }
        return Result;
    }
    #endregion

    #region State Data

    [WebMethod]
    public static string GetStateData(string CountryCode)
    {
        common com = new common();
        DataSet ds = new DataSet();
        string JSONString = string.Empty;
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ds = com.bindstate("GETALLSTATES", CountryCode);
            JSONString = JsonConvert.SerializeObject(ds.Tables[0]);
        }
        return JSONString;
    }
    #endregion

    #region City Data
    [WebMethod]
    public static string GetCityData(string CountryCode, string StateCode)
    {
        common com = new common();
        DataSet ds = new DataSet();
        string JSONString = string.Empty;
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ds = com.bindcity(CountryCode, StateCode, "", "");
            JSONString = JsonConvert.SerializeObject(ds.Tables[0]);
        }
        return JSONString;
    }
    #endregion

    #region Manage Payment

    [WebMethod]
    public static string ManagePayment(string Flag, string CartId, string RegUserID, string RegEmailId, string PayableAmount, string Discount, string DiscountAmount,
                                     string ActualAmount, string AmountType, string AstrologerID, string Name, string LangType, string ConsultationType,
                                     string Question1, string Question2, string NoOfMin, string Question3, string Question4, string Question5, string PayFor, string ClientID , string ClientEmailID)
    {
        DataSet ds = new DataSet();
        string Result;
        ASTROLOGY.classesoracle.subscription obj = new ASTROLOGY.classesoracle.subscription();
        ds = obj.ManagePayment(Flag, "", CartId, RegUserID, RegEmailId, ClientID, ClientEmailID, "NATAL", "", "", PayableAmount, Discount, DiscountAmount, ActualAmount,
                      AmountType, "", "P", "", PayFor, "", "", "RAZORPAY");
        if (ds.Tables[0].Rows.Count > 0)
        {
            string ID = Convert.ToString(ds.Tables[0].Rows[0]["RESULT"]);
            DataSet dsClientDetails = new DataSet();
            dsClientDetails = obj.SaveAstroClient("INSERT", ID, AstrologerID, CartId, RegUserID, RegEmailId, "", LangType, ConsultationType, Question1, Question2, NoOfMin, Question3, Question4, Question5, PayFor);
            HttpContext.Current.Session["AstrologerID"] = AstrologerID;
            //HttpContext.Current.Session["AstrologerName"] = Name;
            //HttpContext.Current.Session["CurrentPage"] = "TalkToAstrologer";
            Result = "1";
        }
        else
        {
            Result = "0";
        }
        return Result;
    }
    #endregion

    #region Add To Cart Product

    [WebMethod]
    public static string AddToCartProduct(string Flag, string ProductOrderId, string Cartid, string ProductId, string ProductQuantity, string ProductDimension,
                                      string ProductWeight, string ActualPriceINR, string DiscountINR, string PayableAmountINR, string RegUserID, string RegEmailID)
    {
        DataSet ds = new DataSet();
        string Result;
        ASTROLOGY.classesoracle.subscription obj = new ASTROLOGY.classesoracle.subscription();
        ds = obj.ProductAddToCart(Flag, "", Cartid, ProductId, ProductQuantity, ProductDimension, ProductWeight, ActualPriceINR, DiscountINR, PayableAmountINR, "", "", "", "P", "F", "F", RegUserID, RegEmailID);
        if (ds.Tables[0].Rows.Count > 0)
        {
            Result = ds.Tables[0].Rows[0]["TOTALCOUNT"].ToString();
            HttpContext.Current.Session["MyCartProductCount"] = ds.Tables[0].Rows[0]["TOTALCOUNT"].ToString();
        }
        else
        {
            Result = "0";
        }
        return Result;
    }
    #endregion

    #region DeleteProduct

    [WebMethod]
    public static string DeleteProduct(string ProductId)
    {
        DataSet ds = new DataSet();
        string Result;
        string CartID = HttpContext.Current.Session["MySessionID"].ToString();
        ASTROLOGY.classesoracle.subscription obj = new ASTROLOGY.classesoracle.subscription();
        ds = obj.ProductAddToCart("DELETE_PRODUCT", ProductId, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
        if (ds.Tables[0].Rows.Count > 0)
        {
            string GetCount = Convert.ToString(HttpContext.Current.Session["MyCartProductCount"]);
            HttpContext.Current.Session["MyCartProductCount"] = Convert.ToString(Convert.ToInt32(GetCount) - Convert.ToInt32(1));
            Result = "1";
        }
        else
        {
            Result = "0";
        }
        return Result;
    }
    #endregion

    #region Admin Logout
    [WebMethod]
    public static string AdminLogout(string StateManagementType, string CookieTimeoutType, string CookieTimeout)
    {
        string result = "1";
        if (StateManagementType.Trim() == "COOKIE")
        {
            // Clear Cookies Method 1
            if (HttpContext.Current != null)
            {
                int cookieCount = HttpContext.Current.Request.Cookies.Count;
                for (var i = 0; i < cookieCount; i++)
                {
                    var cookie = HttpContext.Current.Request.Cookies[i];
                    if (cookie != null)
                    {
                        if (CookieTimeoutType == "MINUTES")
                        {
                            var expiredCookie = new HttpCookie(cookie.Name)
                            {
                                Expires = DateTime.Now.AddMinutes(-Convert.ToInt32(CookieTimeout)),
                                Domain = cookie.Domain
                            };
                            HttpContext.Current.Response.Cookies.Add(expiredCookie);
                        }
                        else if (CookieTimeoutType == "HOURS")
                        {
                            var expiredCookie = new HttpCookie(cookie.Name)
                            {
                                Expires = DateTime.Now.AddHours(-Convert.ToInt32(CookieTimeout)),
                                Domain = cookie.Domain
                            };
                            HttpContext.Current.Response.Cookies.Add(expiredCookie);
                        }
                        else if (CookieTimeoutType == "DAYS")
                        {
                            var expiredCookie = new HttpCookie(cookie.Name)
                            {
                                Expires = DateTime.Now.AddDays(-Convert.ToInt32(CookieTimeout)),
                                Domain = cookie.Domain
                            };
                            HttpContext.Current.Response.Cookies.Add(expiredCookie);
                        }
                        else
                        {
                            var expiredCookie = new HttpCookie(cookie.Name)
                            {
                                Expires = DateTime.Now.AddSeconds(-Convert.ToInt32(CookieTimeout)),
                                Domain = cookie.Domain
                            };
                            HttpContext.Current.Response.Cookies.Add(expiredCookie);
                        }
                    }
                }
                HttpContext.Current.Request.Cookies.Clear();
            }

            // Clear Cookies Method 2
            if (HttpContext.Current.Request.Cookies["AdminCookies"] != null)
            {
                HttpCookie aCookie = HttpContext.Current.Request.Cookies["AdminCookies"];
                if (CookieTimeoutType == "MINUTES")
                {
                    aCookie.Expires = DateTime.Now.AddMinutes(-Convert.ToInt32(CookieTimeout));
                }
                else if (CookieTimeoutType == "HOURS")
                {
                    aCookie.Expires = DateTime.Now.AddHours(-Convert.ToInt32(CookieTimeout));
                }
                else if (CookieTimeoutType == "DAYS")
                {
                    aCookie.Expires = DateTime.Now.AddDays(-Convert.ToInt32(CookieTimeout));
                }
                else
                {
                    aCookie.Expires = DateTime.Now.AddSeconds(-Convert.ToInt32(CookieTimeout));
                }
                aCookie.Value = "";
                HttpContext.Current.Response.Cookies.Add(aCookie);
            }
        }
        else
        {
            //HttpContext.Current.Session["adminuseremail"] = null;
            //Comment following lines On 22-07-2020
            //HttpContext.Current.Session["UserEmailId"] = null;
            //HttpContext.Current.Session["IsAdmin"] = null;
            //HttpContext.Current.Session["UserID"] = null;
            HttpContext.Current.Session["AdminUserId"] = null;
            HttpContext.Current.Session["AdminEmailId"] = null;
            HttpContext.Current.Session["AdminName"] = null;
            HttpContext.Current.Session["IsAdmin"] = null;
        }
        return result;
    }
    #endregion

    #region Get Address By ID
    [WebMethod]
    public static string GetAddressByID(string ShippingId)
    {

        DataSet ds = new DataSet();
        string JSONString = string.Empty;
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.subscription obj = new ASTROLOGY.classesoracle.subscription();
            ds = obj.SaveShippingAddresss("GETADDRESSBY_ID", ShippingId, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            JSONString = JsonConvert.SerializeObject(ds.Tables[0]);
        }
        return JSONString;
    }
    #endregion

    #region Save Comment
    [WebMethod]
    public static string SaveComment(string Flag ,string QuestionID , string CommentDtls , string RegUserID , string RegEmailID , string Status , string NoOfLike)
    {
        DataSet ds = new DataSet();
        string JSONString = string.Empty;
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.subscription obj = new ASTROLOGY.classesoracle.subscription();
            ds = obj.SaveClientQuestionComment(Flag, "0", QuestionID , CommentDtls , RegUserID ,RegUserID, RegEmailID , Status, NoOfLike );
            JSONString = JsonConvert.SerializeObject(ds.Tables[0]);
        }
        return JSONString;
    }
    #endregion


}