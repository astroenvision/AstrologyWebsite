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

public partial class astro_client_details : System.Web.UI.Page
{
    myaccount objmc = new myaccount();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["clientemailid"] != null)
        {
            string EmailID = Request.QueryString["clientemailid"].ToString().Trim();
            ds = objmc.Get_Clientdetails(EmailID,"");
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    txtname.Text = ds.Tables[0].Rows[i]["CLIENT_NAME"].ToString();
                    txtsex.Text = ds.Tables[0].Rows[i]["GENDER"].ToString();
                    if (txtsex.Text == "M")
                    {
                        txtsex.Text = "Male";
                    }
                    else
                    {
                        txtsex.Text = "Female";
                    }
                    string group = ds.Tables[0].Rows[i]["CAT_ID_U"].ToString();
                    if (group == "Natal")
                    {
                        dobid.InnerText = "Date of Birth:";
                        tobid.InnerText = "Time of Birth:";
                        pobid.InnerText = "Place of Birth:";
                        daybirthid.InnerText = "Day of Birth:";
                    }
                    else
                    {
                        dobid.InnerText = "Date of Query:";
                        tobid.InnerText = "Time of Query:";
                        pobid.InnerText = "Place of Query:";
                        daybirthid.InnerText = "Day of Query:";
                    }
                    string dobtime = ds.Tables[0].Rows[i]["DOB"].ToString();
                    dobtime = DateTime.ParseExact(dobtime, "dd/MM/yyyy", null).ToString("dd-MMM-yyyy");
                    txtdob_doq.Text = dobtime.ToUpper();
                    txttob_toq.Text = ds.Tables[0].Rows[i]["TOB"].ToString();
                    txtpob_poq.Text = ds.Tables[0].Rows[i]["CITY"].ToString();
                    txtdayob.Text = ds.Tables[0].Rows[i]["DAYOB"].ToString();
                    txtcountry.Text = ds.Tables[0].Rows[i]["COUNTRY"].ToString();
                    txtstate.Text = ds.Tables[0].Rows[i]["STATE"].ToString();
                    txtemailid.Text = ds.Tables[0].Rows[i]["CLIENT_MAIL"].ToString();
                    txtlatitude.Text = ds.Tables[0].Rows[i]["LATITUDE"].ToString();
                    txtlongitude.Text = ds.Tables[0].Rows[i]["LONGITUDE"].ToString();
                    txttimezone.Text = ds.Tables[0].Rows[i]["TIMEZONE"].ToString();
                    txtconstellation.Text = ds.Tables[0].Rows[i]["CONSTELLATION"].ToString();
                    txtrashi.Text = ds.Tables[0].Rows[i]["RASHI"].ToString();
                    string balancedashaval = ds.Tables[0].Rows[i]["BALANCE_DASHA_TOB"].ToString();
                    balancedashaval=balancedashaval.Replace("Balance Of Dasha :", "");
                    txtbalancedasha.Text = balancedashaval.Trim();
                    string sunrise = ds.Tables[0].Rows[i]["SUN_RISE"].ToString();
                    DateTime srt = Convert.ToDateTime(sunrise);
                    sunrise = srt.ToString("dd/MM/yyyy hh:mm:ss tt");
                    sunrise = DateTime.ParseExact(sunrise, "dd/MM/yyyy hh:mm:ss tt", null).ToString("dd-MMM-yyyy , hh:mm:ss tt");
                    txtsunrise.Text = sunrise.ToUpper();

                    string sunret = ds.Tables[0].Rows[i]["SUN_SET"].ToString();
                    DateTime sst = Convert.ToDateTime(sunret);
                    sunret = sst.ToString("dd/MM/yyyy hh:mm:ss tt");
                    sunret = DateTime.ParseExact(sunret, "dd/MM/yyyy hh:mm:ss tt", null).ToString("dd-MMM-yyyy , hh:mm:ss tt");
                    txtsunset.Text = sunret.ToUpper();

                    string sunrisenext = ds.Tables[0].Rows[i]["SUN_RISE_NEXTDAY"].ToString();
                    DateTime srnt = Convert.ToDateTime(sunrisenext);
                    sunrisenext = srnt.ToString("dd/MM/yyyy hh:mm:ss tt");
                    sunrisenext = DateTime.ParseExact(sunrisenext, "dd/MM/yyyy hh:mm:ss tt", null).ToString("dd-MMM-yyyy , hh:mm:ss tt");
                    txtsunrisenext.Text = sunrisenext.ToUpper();

                    txtdinmaan.Text = ds.Tables[0].Rows[i]["DAY_DURATION"].ToString();
                    txtratrimaan.Text = ds.Tables[0].Rows[i]["NIGHT_DURATION"].ToString();
                    txtcontactno.Text = ds.Tables[0].Rows[i]["MOBILE_NO"].ToString();
                    if (txtcontactno.Text == "0")
                    {
                        txtcontactno.Text = "";
                    }
                    txtastrologername.Text = ds.Tables[0].Rows[i]["ASTROLOGER_NAME"].ToString();
                    txtastrologermobile.Text = ds.Tables[0].Rows[i]["ASTROLOGER_MOBILE"].ToString();
                    txtastrologeremail.Text = ds.Tables[0].Rows[i]["ASTROLOGER_ID"].ToString();
                }
            }
            ds.Dispose();
        }
    }
}
