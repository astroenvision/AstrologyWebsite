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

public partial class horary_calculation : System.Web.UI.Page
{
    public DateTime date3;
    string sunsetpre, sunsetval = "", sunriseval = "", sunrisenext = "", dtobval = "", dobval = "", tobval = "", astrogrname = "", dayofweek = "", dateofbirth = "", cityname = "", dateofbirth_nextdate="";
    //string dinmaan = "", ratrimaan = "";
    string sunsettimepre="", sunrisetime = "", sunsettime = "", sunrisetimenext = "",horaname = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["sunsetpre"] != null && Request.QueryString["sunsetpre"] != "")
        {
            sunsetpre = Request.QueryString["sunsetpre"];
            String[] split_sunsetpre = sunsetpre.Split(' ');
            sunsettimepre = split_sunsetpre[1];
        }
        if (Request.QueryString["sunrise"] != null && Request.QueryString["sunrise"] != "")
        {
            sunriseval = Request.QueryString["sunrise"];
            String[] split_sunriseval = sunriseval.Split(' ');
            sunrisetime = split_sunriseval[1];
        }
        if (Request.QueryString["sunset"] != null && Request.QueryString["sunset"] != "")
        {
            sunsetval = Request.QueryString["sunset"];
            String[] split_sunsetval = sunsetval.Split(' ');
            sunsettime = split_sunsetval[1];
        }
        if (Request.QueryString["sunrisenext"] != null && Request.QueryString["sunrisenext"] != "")
        {
            sunrisenext = Request.QueryString["sunrisenext"];
            String[] split_sunrisenext = sunrisenext.Split(' ');
            sunrisetimenext = split_sunrisenext[1];
        }
        if (Request.QueryString["astmail"] != null && Request.QueryString["astmail"] != "")
        {
            astrogrname = Request.QueryString["astmail"];
        }
        if (Request.QueryString["city"] != null && Request.QueryString["city"] != "")
        {
            cityname = Request.QueryString["city"];
        }
        if (Request.QueryString["dob"] != null && Request.QueryString["dob"] != "")
        {
            dobval = Request.QueryString["dob"];
            dateofbirth = Request.QueryString["dob"];
            dobval = DateTime.ParseExact(dobval, "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
            DateTime dtc = Convert.ToDateTime(dobval);
            dayofweek = dtc.DayOfWeek.ToString();
        }
        if (Request.QueryString["tob"] != null && Request.QueryString["tob"] != "")
        {
            tobval = Request.QueryString["tob"];
        }
        dtobval = dobval + " " + tobval;

        if (Request.QueryString["query"] != null && Request.QueryString["query"] != "")
        {
            hdnquery.Value = Request.QueryString["query"];
            if (hdnquery.Value != "")
            {
                clientqueryid.InnerHtml = "Querist's Query: " + hdnquery.Value + "";
            }
        }

        if (Request.QueryString["sunrise"] != null && Request.QueryString["sunrise"] != "")
        {
            sunsettimepre = sunsetpre.Substring(sunsetpre.LastIndexOf(' ') + 1);
            sunsettimepre = sunsettimepre.Substring(0, sunsettimepre.Length - 0); // -3

            sunrisetime = sunriseval.Substring(sunriseval.LastIndexOf(' ') + 1);
            sunrisetime = sunrisetime.Substring(0, sunrisetime.Length - 0);

            sunsettime = sunsetval.Substring(sunsetval.LastIndexOf(' ') + 1);
            sunsettime = sunsettime.Substring(0, sunsettime.Length - 0);

            sunrisetimenext = sunrisenext.Substring(sunrisenext.LastIndexOf(' ') + 1);
            sunrisetimenext = sunrisetimenext.Substring(0, sunrisetimenext.Length - 0);

            DateTime t1 = DateTime.Parse(sunrisetime);
            DateTime t2 = DateTime.Parse(sunsettime);
            DateTime t3 = DateTime.Parse(tobval);
            DateTime t4 = DateTime.Parse(sunrisetimenext);
            DateTime t5 = DateTime.Parse(sunsettimepre);

            if (t3.TimeOfDay <= t1.TimeOfDay && t3.TimeOfDay <= t2.TimeOfDay)
            {
                dobval = Request.QueryString["dob"];
                dobval = DateTime.ParseExact(dobval, "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
                DateTime dtc = Convert.ToDateTime(dobval);
                dayofweek = dtc.DayOfWeek.ToString();
                dayofweek = dtc.AddDays(-1).DayOfWeek.ToString();
                dayofweek = dayofweek.ToUpper();

                DateTime dtn = Convert.ToDateTime(dobval).AddDays(0);
                dateofbirth_nextdate = dtn.ToString("dd/MM/yyyy");

                DateTime dtdb = Convert.ToDateTime(dobval).AddDays(-1);
                dateofbirth = dtdb.ToString("dd/MM/yyyy");

                sunsetval = sunsetpre;

                //GetDinmanHora12(sunsetval, sunriseval, sunrisenext, dtobval, astrogrname, dayofweek, dateofbirth, dateofbirth_nextdate, sunrisetime, sunsettime);
                GetRatrimanHora12(sunsetval, sunriseval, sunrisenext, dtobval, astrogrname, dayofweek, dateofbirth, dateofbirth_nextdate, sunrisetime, sunsettimepre);
                if (astrogrname == "hshoradm@horary.com")
                {
                    //GetDinmanHora36(sunsetval, sunriseval, sunrisenext, dtobval, astrogrname, dayofweek, dateofbirth,dateofbirth_nextdate, sunrisetime, sunsettime);
                    GetRatrimanHora36(sunsetval, sunriseval, sunrisenext, dtobval, astrogrname, dayofweek, dateofbirth, dateofbirth_nextdate, sunrisetime, sunsettimepre);
                }

                dvratrimaan12.Visible = true;
                dvdinmaan12.Visible = false;
                dvratrimaan36.Visible = true;
                dvdinmaan36.Visible = false;
            }
            else if (t3.TimeOfDay >= t1.TimeOfDay && t3.TimeOfDay <= t2.TimeOfDay)
            {
                dobval = Request.QueryString["dob"];
                dobval = DateTime.ParseExact(dobval, "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
                DateTime dtc = Convert.ToDateTime(dobval);
                dayofweek = dtc.DayOfWeek.ToString();
                dayofweek = dayofweek.ToUpper();

                DateTime dtn = Convert.ToDateTime(dobval).AddDays(1);
                dateofbirth_nextdate = dtn.ToString("dd/MM/yyyy");

                GetDinmanHora12(sunsetval, sunriseval, sunrisenext, dtobval, astrogrname, dayofweek, dateofbirth, dateofbirth_nextdate, sunrisetime, sunsettime);
                if (astrogrname == "hshoradm@horary.com")
                {
                    GetDinmanHora36(sunsetval, sunriseval, sunrisenext, dtobval, astrogrname, dayofweek, dateofbirth, dateofbirth_nextdate, sunrisetime, sunsettime);
                }

                dvratrimaan12.Visible = false;
                dvdinmaan12.Visible = true;
                dvratrimaan36.Visible = false;
                dvdinmaan36.Visible = true;
            }
            else
            {
                dobval = Request.QueryString["dob"];
                dobval = DateTime.ParseExact(dobval, "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
                DateTime dtc = Convert.ToDateTime(dobval);
                dayofweek = dtc.DayOfWeek.ToString();
                dayofweek = dayofweek.ToUpper();

                DateTime dtn = Convert.ToDateTime(dobval).AddDays(1);
                dateofbirth_nextdate = dtn.ToString("dd/MM/yyyy");

                sunriseval = sunrisenext;
                GetRatrimanHora12(sunsetval, sunriseval, sunrisenext, dtobval, astrogrname, dayofweek, dateofbirth, dateofbirth_nextdate, sunrisetimenext, sunsettime);
                if (astrogrname == "hshoradm@horary.com")
                {
                    GetRatrimanHora36(sunsetval, sunriseval, sunrisenext, dtobval, astrogrname, dayofweek, dateofbirth, dateofbirth_nextdate, sunrisetimenext, sunsettime);
                }

                dvratrimaan12.Visible = true;
                dvdinmaan12.Visible = false;
                dvratrimaan36.Visible = true;
                dvdinmaan36.Visible = false;
            }
        }
        
    }

    public DataSet GetDinmanHora12(string sunset, string sunrise, string sunrisenextday, string tob, string user, string dayofweek, string dateofbirth, string dateofbirth_nextdate, string sunrisetime, string sunsettime)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.getdinratman(sunset, sunrise, sunrisenextday, tob, user, "", "", dayofweek);
             
            if (ds.Tables[2].Rows.Count > 0)
            {
                //DateTime dtss = Convert.ToDateTime(sunsettime);
                //DateTime dtsr = Convert.ToDateTime(sunrisetime);
                //TimeSpan diff = dtss - dtsr;

                dvdinmaan12.InnerHtml = "<h2 style='height: 15px; padding:0%; margin:1% 0% 1% 0%;font-size: 0.80em; float:left;width:90%;'>HORA RESULT : Location: " + cityname + "</h2>";
                dvdinmaan12.InnerHtml += "<table><tbody><tr>";
                dvdinmaan12.InnerHtml += "<td style='width: 600px; display: block;' align='left'>";
                dvdinmaan12.InnerHtml += "<table id=\"Divgrid1\" runat=\"server\" align=\"left\" width=\"460px\" height=\"0px\" style=\"border: 1px;solid #7daae3;\" cellpadding=\"0\" cellspacing=\"0\">";
                dvdinmaan12.InnerHtml += "<tbody>";
                dvdinmaan12.InnerHtml += "<tr><td style='font-size:1em;' class=\"colum-td-head\" colspan=\"16\">Dinmaan</td></tr>";
                dvdinmaan12.InnerHtml += "<tr><td class='colum-td-subhead'>Date</td><td class='colum-td-subhead'>" + dateofbirth + "</td>";
                dvdinmaan12.InnerHtml += "<td class='colum-td-subhead'>" + dateofbirth + "</td><td class='colum-td-subhead'>" + dateofbirth + "</td><td class='colum-td-subhead'>Hora -1</td><td class='colum-td-subhead'>Hora -2</td><td class='colum-td-subhead'>Hora -3</td>";
                dvdinmaan12.InnerHtml += "<td class='colum-td-subhead'>Hora -4</td><td class='colum-td-subhead'>Hora -5</td><td class='colum-td-subhead'>Hora -6</td><td class='colum-td-subhead'>Hora -7</td><td class='colum-td-subhead'>Hora -8</td>";
                dvdinmaan12.InnerHtml += "<td class='colum-td-subhead'>Hora -9</td><td class='colum-td-subhead'>Hora -10</td><td class='colum-td-subhead'>Hora -11</td><td class='colum-td-subhead'>Hora -12</td>";
                dvdinmaan12.InnerHtml += "</tr>";
                if (ds.Tables[1].Rows.Count > 0)
                {
                    string hora1 = ds.Tables[1].Rows[0]["HORA_1"].ToString();
                    string hora2 = ds.Tables[1].Rows[0]["HORA_2"].ToString();
                    string hora3 = ds.Tables[1].Rows[0]["HORA_3"].ToString();
                    string hora4 = ds.Tables[1].Rows[0]["HORA_4"].ToString();
                    string hora5 = ds.Tables[1].Rows[0]["HORA_5"].ToString();
                    string hora6 = ds.Tables[1].Rows[0]["HORA_6"].ToString();
                    string hora7 = ds.Tables[1].Rows[0]["HORA_7"].ToString();
                    string hora8 = ds.Tables[1].Rows[0]["HORA_8"].ToString();
                    string hora9 = ds.Tables[1].Rows[0]["HORA_9"].ToString();
                    string hora10 = ds.Tables[1].Rows[0]["HORA_10"].ToString();
                    string hora11 = ds.Tables[1].Rows[0]["HORA_11"].ToString();
                    string hora12 = ds.Tables[1].Rows[0]["HORA_12"].ToString();
                    dvdinmaan12.InnerHtml += "<tr><td class='colum-td-subhead'>" + dayofweek + "</td><td class='colum-td-subhead'>Sunrise HH:MM:SS</td><td class='colum-td-subhead'>Sunset HH:MM:SS</td>";
                    dvdinmaan12.InnerHtml += "<td class='colum-td-subhead'>Day Length HH:MM:SS</td><td class='colum-td-subhead'>" + hora1 + "</td><td class='colum-td-subhead'>" + hora2 + "</td><td class='colum-td-subhead'>" + hora3 + "</td><td class='colum-td-subhead'>" + hora4 + "</td>";
                    dvdinmaan12.InnerHtml += "<td class='colum-td-subhead'>" + hora5 + "</td><td class='colum-td-subhead'>" + hora6 + "</td><td class='colum-td-subhead'>" + hora7 + "</td><td class='colum-td-subhead'>" + hora8 + "</td><td class='colum-td-subhead'>" + hora9 + "</td>";
                    dvdinmaan12.InnerHtml += "<td class='colum-td-subhead'>" + hora10 + "</td><td class='colum-td-subhead'>" + hora11 + "</td><td class='colum-td-subhead'>" + hora12 + "</td>";
                    dvdinmaan12.InnerHtml += "</tr>";
                    dvdinmaan12.InnerHtml += "<tr>";
                }

                string[] testarr = getdinmaamratrimaan(sunrise, sunset);
                for (int j = 0; j <= 12; j++)
                {
                   string diff = "";
                   string dinman1 = "", dinman2 = "", finalval = "";
                   if (j == 0)
                   {
                       diff = testarr[j];
                       dvdinmaan12.InnerHtml += "<td class=\"colum-td-subhead\"></td>";
                       dvdinmaan12.InnerHtml += "<td class=\"colum-td-subhead\">";
                       dvdinmaan12.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 75px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + sunrisetime + "'>";
                       dvdinmaan12.InnerHtml += "</td>";
                       dvdinmaan12.InnerHtml += "<td class=\"colum-td-subhead\">";
                       dvdinmaan12.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 75px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + sunsettime + "'>";
                       dvdinmaan12.InnerHtml += "</td>";
                       dvdinmaan12.InnerHtml += "<td class=\"colum-td-subhead\">";
                       dvdinmaan12.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 75px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + diff + "'>";
                       dvdinmaan12.InnerHtml += "</td>";
                   }
                   else if (j == 1)
                   {
                       dinman1 = sunrisetime;
                       dinman2 = testarr[j];
                       dinman2=dinman2.Split(' ').Last();
                       finalval = dinman1 + " - " + dinman2;
                       DateTime dt1 = DateTime.Parse(dinman1);
                       DateTime dt2 = DateTime.Parse(dinman2);
                       DateTime dt3 = DateTime.Parse(tob);
                       if (dt3.TimeOfDay >= dt1.TimeOfDay && dt3.TimeOfDay <= dt2.TimeOfDay)
                       {
                           horaname = ds.Tables[1].Rows[0]["HORA_"+j+""].ToString();
                       }
                       dvdinmaan12.InnerHtml += "<td class=\"colum-td-subhead\">";
                       dvdinmaan12.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 130px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + finalval + "'>";
                       dvdinmaan12.InnerHtml += "</td>";
                   }
                   else if (j == 12)
                   {
                       dinman1 = testarr[j - 1];
                       dinman1 = dinman1.Split(' ').Last();
                       dinman2 = testarr[j];
                       dinman2 = dinman2.Split(' ').Last();
                       finalval = dinman1 + " - " + dinman2;
                       DateTime dt1 = DateTime.Parse(dinman1);
                       DateTime dt2 = DateTime.Parse(dinman2);
                       DateTime dt3 = DateTime.Parse(tob);
                       if (dt3.TimeOfDay >= dt1.TimeOfDay && dt3.TimeOfDay <= dt2.TimeOfDay)
                       {
                           horaname = ds.Tables[1].Rows[0]["HORA_" + j + ""].ToString();
                       }
                       dvdinmaan12.InnerHtml += "<td class=\"colum-td-subhead\">";
                       dvdinmaan12.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 130px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + finalval + "'>";
                       dvdinmaan12.InnerHtml += "</td>";
                   }
                   else
                   {
                       dinman1 = testarr[j-1];
                       dinman1 = dinman1.Split(' ').Last();
                       dinman2 = testarr[j];
                       dinman2 = dinman2.Split(' ').Last();
                       finalval = dinman1 + " - " + dinman2;
                       DateTime dt1 = DateTime.Parse(dinman1);
                       DateTime dt2 = DateTime.Parse(dinman2);
                       DateTime dt3 = DateTime.Parse(tob);
                       if (dt3.TimeOfDay >= dt1.TimeOfDay && dt3.TimeOfDay <= dt2.TimeOfDay)
                       {
                           horaname = ds.Tables[1].Rows[0]["HORA_" + j + ""].ToString();
                       }
                       dvdinmaan12.InnerHtml += "<td class=\"colum-td-subhead\">";
                       dvdinmaan12.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 130px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + finalval + "'>";
                       dvdinmaan12.InnerHtml += "</td>";
                   }
                }

                //for (int i = 0; i < ds.Tables[2].Rows.Count; i++)
                //{
                //    if (i == 0)
                //    {
                //        dvdinmaan12.InnerHtml += "<td class=\"colum-td-subhead\"></td>";
                //        dvdinmaan12.InnerHtml += "<td class=\"colum-td-subhead\">";
                //        dvdinmaan12.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 110px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + sunrisetime + "'>";
                //        dvdinmaan12.InnerHtml += "</td>";
                //        dvdinmaan12.InnerHtml += "<td class=\"colum-td-subhead\">";
                //        dvdinmaan12.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 110px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + sunsettime  + "'>";
                //        dvdinmaan12.InnerHtml += "</td>";
                //        dvdinmaan12.InnerHtml += "<td class=\"colum-td-subhead\">";
                //        dvdinmaan12.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 110px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + diff + "'>";
                //        dvdinmaan12.InnerHtml += "</td>";
                //    }
                //    string horapart = ds.Tables[2].Rows[i]["hora_part"].ToString();
                //    if (horapart == "3")
                //    {
                //        string dinman1 = "", dinman2 = "", finalval="";
                //        string horaname = ds.Tables[2].Rows[i]["hora_name"].ToString();
                //        dinman1 = ds.Tables[2].Rows[i]["dinman"].ToString();
                        
                //           if (i == 2)
                //           {
                //               dinman1 = sunrisetime;
                //               dinman2 = ds.Tables[2].Rows[i]["dinman"].ToString();
                //               finalval = dinman1 + " - " + dinman2;
                //           }
                //           else
                //           {
                //               if (i == 35)
                //               {
                //                   dinman2 = ds.Tables[2].Rows[i]["dinman"].ToString();
                //                   dinman1 = ds.Tables[2].Rows[i-3]["dinman"].ToString();
                //                   finalval = dinman1 + " - " + dinman2;
                //               }
                //               else
                //               {
                //                   dinman1 = ds.Tables[2].Rows[i - 3]["dinman"].ToString();
                //                   dinman2 = ds.Tables[2].Rows[i]["dinman"].ToString();
                //                   finalval = dinman1 + " - " + dinman2;
                //               }
                //           }
                        
                //        dvdinmaan12.InnerHtml += "<td class=\"colum-td-subhead\">";
                //        dvdinmaan12.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 130px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + finalval + "'>";
                //        dvdinmaan12.InnerHtml += "</td>";
                //    }
                //}
                dvdinmaan12.InnerHtml += "</tr>";
                dvdinmaan12.InnerHtml += "</tbody>";
                dvdinmaan12.InnerHtml += "</table></td>";
                dvdinmaan12.InnerHtml += "</tr></tbody></table>";
            }
            dvdinmaan12.InnerHtml += "<h2 style='height: 15px; padding:3px 10px 3px 10px;font-size: 0.80em;color: #F25E0A;'>HORA NAME :- " + horaname + "</h2>";


        }
        return ds;
    }

    public DataSet GetRatrimanHora12(string sunset, string sunrise, string sunrisenextday, string tob, string user, string dayofweek, string dateofbirth,string dateofbirth_nextdate,string sunrisetime,string sunsettime)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.getdinratman(sunset, sunrise, sunrisenextday, tob, user, "", "", dayofweek);

            if (ds.Tables[2].Rows.Count > 0)
            {
                //DateTime dtss = Convert.ToDateTime(sunsettime);
                //DateTime dtsr = Convert.ToDateTime(sunrisetime);
                //TimeSpan diff = dtss - dtsr;

                //DateTime dtn = Convert.ToDateTime(dobval).AddDays(1);
                //string dateofbirth_nextdate = dtn.ToString("dd/MM/yyyy");

                //dvratrimaan12.InnerHtml = "<h2 style='height: 15px; padding:3px 10px 3px 10px;font-size: 0.80em;'>HORA RESULT : Location: New Delhi</h2>";
                dvratrimaan12.InnerHtml = "<table><tbody><tr>";
                dvratrimaan12.InnerHtml += "<td style='width: 600px; display: block;' align='left'>";
                dvratrimaan12.InnerHtml += "<table id=\"Divgrid1\" runat=\"server\" align=\"left\" width=\"460px\" height=\"0px\" style=\"border: 1px;solid #7daae3;\" cellpadding=\"0\" cellspacing=\"0\">";
                dvratrimaan12.InnerHtml += "<tbody>";
                dvratrimaan12.InnerHtml += "<tr><td style='font-size:1em;' class=\"colum-td-head\" colspan=\"16\">Ratrimaan</td></tr>";
                dvratrimaan12.InnerHtml += "<tr><td class='colum-td-subhead'>Date</td><td class='colum-td-subhead'>" + dateofbirth + "</td>";
                dvratrimaan12.InnerHtml += "<td class='colum-td-subhead'>" + dateofbirth_nextdate + "</td><td class='colum-td-subhead'>" + dateofbirth + "</td><td class='colum-td-subhead'>Hora -1</td><td class='colum-td-subhead'>Hora -2</td><td class='colum-td-subhead'>Hora -3</td>";
                dvratrimaan12.InnerHtml += "<td class='colum-td-subhead'>Hora -4</td><td class='colum-td-subhead'>Hora -5</td><td class='colum-td-subhead'>Hora -6</td><td class='colum-td-subhead'>Hora -7</td><td class='colum-td-subhead'>Hora -8</td>";
                dvratrimaan12.InnerHtml += "<td class='colum-td-subhead'>Hora -9</td><td class='colum-td-subhead'>Hora -10</td><td class='colum-td-subhead'>Hora -11</td><td class='colum-td-subhead'>Hora -12</td>";
                dvratrimaan12.InnerHtml += "</tr>";
                if (ds.Tables[2].Rows.Count > 0)
                {
                    string hora1 = ds.Tables[2].Rows[0]["HORA_1"].ToString();
                    string hora2 = ds.Tables[2].Rows[0]["HORA_2"].ToString();
                    string hora3 = ds.Tables[2].Rows[0]["HORA_3"].ToString();
                    string hora4 = ds.Tables[2].Rows[0]["HORA_4"].ToString();
                    string hora5 = ds.Tables[2].Rows[0]["HORA_5"].ToString();
                    string hora6 = ds.Tables[2].Rows[0]["HORA_6"].ToString();
                    string hora7 = ds.Tables[2].Rows[0]["HORA_7"].ToString();
                    string hora8 = ds.Tables[2].Rows[0]["HORA_8"].ToString();
                    string hora9 = ds.Tables[2].Rows[0]["HORA_9"].ToString();
                    string hora10 = ds.Tables[2].Rows[0]["HORA_10"].ToString();
                    string hora11 = ds.Tables[2].Rows[0]["HORA_11"].ToString();
                    string hora12 = ds.Tables[2].Rows[0]["HORA_12"].ToString();
                    dvratrimaan12.InnerHtml += "<tr><td class='colum-td-subhead'>" + dayofweek + "</td><td class='colum-td-subhead'>Sunset HH:MM:SS</td><td class='colum-td-subhead'>Sunrise HH:MM:SS</td>";
                    dvratrimaan12.InnerHtml += "<td class='colum-td-subhead'>Night Length HH:MM:SS</td><td class='colum-td-subhead'>" + hora1 + "</td><td class='colum-td-subhead'>" + hora2 + "</td><td class='colum-td-subhead'>" + hora3 + "</td><td class='colum-td-subhead'>" + hora4 + "</td>";
                    dvratrimaan12.InnerHtml += "<td class='colum-td-subhead'>" + hora5 + "</td><td class='colum-td-subhead'>" + hora6 + "</td><td class='colum-td-subhead'>" + hora7 + "</td><td class='colum-td-subhead'>" + hora8 + "</td><td class='colum-td-subhead'>" + hora9 + "</td>";
                    dvratrimaan12.InnerHtml += "<td class='colum-td-subhead'>" + hora10 + "</td><td class='colum-td-subhead'>" + hora11 + "</td><td class='colum-td-subhead'>" + hora12 + "</td>";
                    dvratrimaan12.InnerHtml += "</tr>";
                    dvratrimaan12.InnerHtml += "<tr>";
                }

                //string[] testarr = getdinmaamratrimaan(sunset, sunrisenextday);
                string[] testarr = getdinmaamratrimaan(sunset, sunrise);
                for (int j = 0; j <= 12; j++)
                {
                    string diff = "";
                    string dinman1 = "", dinman2 = "", finalval = "";
                    if (j == 0)
                    {
                        diff = testarr[j];
                        dvratrimaan12.InnerHtml += "<td class=\"colum-td-subhead\"></td>";
                        dvratrimaan12.InnerHtml += "<td class=\"colum-td-subhead\">";
                        dvratrimaan12.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 75px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + sunsettime  + "'>";
                        dvratrimaan12.InnerHtml += "</td>";
                        dvratrimaan12.InnerHtml += "<td class=\"colum-td-subhead\">";
                        dvratrimaan12.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 75px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + sunrisetime + "'>";
                        dvratrimaan12.InnerHtml += "</td>";
                        dvratrimaan12.InnerHtml += "<td class=\"colum-td-subhead\">";
                        dvratrimaan12.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 75px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + diff + "'>";
                        dvratrimaan12.InnerHtml += "</td>";
                    }
                    else if (j == 1)
                    {
                        dinman1 = sunsettime;
                        dinman2 = testarr[j];
                        dinman2 = dinman2.Split(' ').Last();
                        finalval = dinman1 + " - " + dinman2;
                        DateTime dt1 = DateTime.Parse(dinman1);
                        DateTime dt2 = DateTime.Parse(dinman2);
                        DateTime dt3 = DateTime.Parse(tob);
                        if (dt3.TimeOfDay >= dt1.TimeOfDay && dt3.TimeOfDay <= dt2.TimeOfDay)
                        {
                            horaname = ds.Tables[2].Rows[0]["HORA_" + j + ""].ToString();
                        }
                        dvratrimaan12.InnerHtml += "<td class=\"colum-td-subhead\">";
                        dvratrimaan12.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 130px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + finalval + "'>";
                        dvratrimaan12.InnerHtml += "</td>";
                    }
                    else if (j == 12)
                    {
                        dinman1 = testarr[j - 1];
                        dinman1 = dinman1.Split(' ').Last();
                        dinman2 = testarr[j];
                        dinman2 = dinman2.Split(' ').Last();
                        finalval = dinman1 + " - " + dinman2;
                        DateTime dt1 = DateTime.Parse(dinman1);
                        DateTime dt2 = DateTime.Parse(dinman2);
                        DateTime dt3 = DateTime.Parse(tob);
                        if (dt3.TimeOfDay >= dt1.TimeOfDay && dt3.TimeOfDay <= dt2.TimeOfDay)
                        {
                            horaname = ds.Tables[2].Rows[0]["HORA_" + j + ""].ToString();
                        }
                        dvratrimaan12.InnerHtml += "<td class=\"colum-td-subhead\">";
                        dvratrimaan12.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 130px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + finalval + "'>";
                        dvratrimaan12.InnerHtml += "</td>";
                    }
                    else
                    {
                        dinman1 = testarr[j - 1];
                        dinman1 = dinman1.Split(' ').Last();
                        dinman2 = testarr[j];
                        dinman2 = dinman2.Split(' ').Last();
                        finalval = dinman1 + " - " + dinman2;
                        DateTime dt1 = DateTime.Parse(dinman1);
                        DateTime dt2 = DateTime.Parse(dinman2);
                        DateTime dt3 = DateTime.Parse(tob);
                        if (dt3.TimeOfDay >= dt1.TimeOfDay && dt3.TimeOfDay <= dt2.TimeOfDay)
                        {
                            horaname = ds.Tables[2].Rows[0]["HORA_" + j + ""].ToString();
                        }
                        dvratrimaan12.InnerHtml += "<td class=\"colum-td-subhead\">";
                        dvratrimaan12.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 130px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + finalval + "'>";
                        dvratrimaan12.InnerHtml += "</td>";
                    }
                }

                //for (int i = 0; i < ds.Tables[2].Rows.Count; i++)
                //{
                //    if (i == 0)
                //    {
                //        dvdinmaan12.InnerHtml += "<td class=\"colum-td-subhead\"></td>";
                //        dvdinmaan12.InnerHtml += "<td class=\"colum-td-subhead\">";
                //        dvdinmaan12.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 110px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + sunrisetime + "'>";
                //        dvdinmaan12.InnerHtml += "</td>";
                //        dvdinmaan12.InnerHtml += "<td class=\"colum-td-subhead\">";
                //        dvdinmaan12.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 110px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + sunsettime  + "'>";
                //        dvdinmaan12.InnerHtml += "</td>";
                //        dvdinmaan12.InnerHtml += "<td class=\"colum-td-subhead\">";
                //        dvdinmaan12.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 110px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + diff + "'>";
                //        dvdinmaan12.InnerHtml += "</td>";
                //    }
                //    string horapart = ds.Tables[2].Rows[i]["hora_part"].ToString();
                //    if (horapart == "3")
                //    {
                //        string dinman1 = "", dinman2 = "", finalval="";
                //        string horaname = ds.Tables[2].Rows[i]["hora_name"].ToString();
                //        dinman1 = ds.Tables[2].Rows[i]["dinman"].ToString();

                //           if (i == 2)
                //           {
                //               dinman1 = sunrisetime;
                //               dinman2 = ds.Tables[2].Rows[i]["dinman"].ToString();
                //               finalval = dinman1 + " - " + dinman2;
                //           }
                //           else
                //           {
                //               if (i == 35)
                //               {
                //                   dinman2 = ds.Tables[2].Rows[i]["dinman"].ToString();
                //                   dinman1 = ds.Tables[2].Rows[i-3]["dinman"].ToString();
                //                   finalval = dinman1 + " - " + dinman2;
                //               }
                //               else
                //               {
                //                   dinman1 = ds.Tables[2].Rows[i - 3]["dinman"].ToString();
                //                   dinman2 = ds.Tables[2].Rows[i]["dinman"].ToString();
                //                   finalval = dinman1 + " - " + dinman2;
                //               }
                //           }

                //        dvdinmaan12.InnerHtml += "<td class=\"colum-td-subhead\">";
                //        dvdinmaan12.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 130px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + finalval + "'>";
                //        dvdinmaan12.InnerHtml += "</td>";
                //    }
                //}
                dvratrimaan12.InnerHtml += "</tr>";
                dvratrimaan12.InnerHtml += "</tbody>";
                dvratrimaan12.InnerHtml += "</table></td>";
                dvratrimaan12.InnerHtml += "</tr></tbody></table>";
            }
            dvratrimaan12.InnerHtml += "<h2 style='height: 15px; padding:3px 10px 3px 10px;font-size: 0.80em;color: #F25E0A;'>HORA NAME :- " + horaname + "</h2>";


        }
        return ds;
    }

    public DataSet GetDinmanHora36(string sunset, string sunrise, string sunrisenextday, string tob, string user, string dayofweek, string dateofbirth, string dateofbirth_nextdate, string sunrisetime, string sunsettime)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.getdinratman(sunset, sunrise, sunrisenextday, tob, user, "", "", dayofweek);

            if (ds.Tables[2].Rows.Count > 0)
            {
                //DateTime dtss = Convert.ToDateTime(sunsettime);
                //DateTime dtsr = Convert.ToDateTime(sunrisetime);
                //TimeSpan diff = dtss - dtsr;

                dvdinmaan36.InnerHtml = "<h2 style='height: 15px; padding:3px 10px 3px 10px;font-size: 0.80em;'>HORA RESULT : Location: " + cityname + "</h2>";
                dvdinmaan36.InnerHtml += "<table><tbody><tr>";
                dvdinmaan36.InnerHtml += "<td style='width: 600px; display: block;' align='left'>";
                dvdinmaan36.InnerHtml += "<table id=\"Divgrid1\" runat=\"server\" align=\"left\" width=\"460px\" height=\"0px\" style=\"border: 1px;solid #7daae3;\" cellpadding=\"0\" cellspacing=\"0\">";
                dvdinmaan36.InnerHtml += "<tbody>";
                dvdinmaan36.InnerHtml += "<tr><td style='font-size:1em;' class=\"colum-td-head\" colspan=\"42\">Dinmaan</td></tr>";
                dvdinmaan36.InnerHtml += "<tr><td class='colum-td-subhead'>Date</td><td class='colum-td-subhead'>" + dateofbirth + "</td>";
                dvdinmaan36.InnerHtml += "<td class='colum-td-subhead'>" + dateofbirth + "</td><td class='colum-td-subhead'>" + dateofbirth + "</td><td class='colum-td-subhead'>Hora -1</td><td class='colum-td-subhead'>Hora -1</td><td class='colum-td-subhead'>Hora -1</td><td class='colum-td-subhead'>Hora -2</td><td class='colum-td-subhead'>Hora -2</td><td class='colum-td-subhead'>Hora -2</td><td class='colum-td-subhead'>Hora -3</td><td class='colum-td-subhead'>Hora -3</td><td class='colum-td-subhead'>Hora -3</td>";
                dvdinmaan36.InnerHtml += "<td class='colum-td-subhead'>Hora -4</td><td class='colum-td-subhead'>Hora -4</td><td class='colum-td-subhead'>Hora -4</td><td class='colum-td-subhead'>Hora -5</td><td class='colum-td-subhead'>Hora -5</td><td class='colum-td-subhead'>Hora -5</td><td class='colum-td-subhead'>Hora -6</td><td class='colum-td-subhead'>Hora -6</td><td class='colum-td-subhead'>Hora -6</td><td class='colum-td-subhead'>Hora -7</td><td class='colum-td-subhead'>Hora -7</td><td class='colum-td-subhead'>Hora -7</td><td class='colum-td-subhead'>Hora -8</td><td class='colum-td-subhead'>Hora -8</td><td class='colum-td-subhead'>Hora -8</td>";
                dvdinmaan36.InnerHtml += "<td class='colum-td-subhead'>Hora -9</td><td class='colum-td-subhead'>Hora -9</td><td class='colum-td-subhead'>Hora -9</td><td class='colum-td-subhead'>Hora -10</td><td class='colum-td-subhead'>Hora -10</td><td class='colum-td-subhead'>Hora -10</td><td class='colum-td-subhead'>Hora -11</td><td class='colum-td-subhead'>Hora -11</td><td class='colum-td-subhead'>Hora -11</td><td class='colum-td-subhead'>Hora -12</td><td class='colum-td-subhead'>Hora -12</td><td class='colum-td-subhead'>Hora -12</td>";
                dvdinmaan36.InnerHtml += "</tr>";
                if (ds.Tables[1].Rows.Count > 0)
                {
                    string hora1 = ds.Tables[1].Rows[0]["HORA_1"].ToString();
                    string hora2 = ds.Tables[1].Rows[0]["HORA_2"].ToString();
                    string hora3 = ds.Tables[1].Rows[0]["HORA_3"].ToString();
                    string hora4 = ds.Tables[1].Rows[0]["HORA_4"].ToString();
                    string hora5 = ds.Tables[1].Rows[0]["HORA_5"].ToString();
                    string hora6 = ds.Tables[1].Rows[0]["HORA_6"].ToString();
                    string hora7 = ds.Tables[1].Rows[0]["HORA_7"].ToString();
                    string hora8 = ds.Tables[1].Rows[0]["HORA_8"].ToString();
                    string hora9 = ds.Tables[1].Rows[0]["HORA_9"].ToString();
                    string hora10 = ds.Tables[1].Rows[0]["HORA_10"].ToString();
                    string hora11 = ds.Tables[1].Rows[0]["HORA_11"].ToString();
                    string hora12 = ds.Tables[1].Rows[0]["HORA_12"].ToString();
                    dvdinmaan36.InnerHtml += "<tr><td class='colum-td-subhead'>" + dayofweek + "</td><td class='colum-td-subhead'>Sunrise HH:MM:SS</td><td class='colum-td-subhead'>Sunset HH:MM:SS</td>";
                    dvdinmaan36.InnerHtml += "<td class='colum-td-subhead'>Day Length HH:MM:SS</td><td class='colum-td-subhead'>" + hora1 + " -1</td><td class='colum-td-subhead'>" + hora1 + " -2</td><td class='colum-td-subhead'>" + hora1 + " -3</td><td class='colum-td-subhead'>" + hora2 + " -1</td><td class='colum-td-subhead'>" + hora2 + " -2</td><td class='colum-td-subhead'>" + hora2 + " -3</td><td class='colum-td-subhead'>" + hora3 + " -1</td><td class='colum-td-subhead'>" + hora3 + " -2</td><td class='colum-td-subhead'>" + hora3 + " -3</td><td class='colum-td-subhead'>" + hora4 + " -1</td><td class='colum-td-subhead'>" + hora4 + " -2</td><td class='colum-td-subhead'>" + hora4 + " -3</td>";
                    dvdinmaan36.InnerHtml += "<td class='colum-td-subhead'>" + hora5 + " -1</td><td class='colum-td-subhead'>" + hora5 + " -2</td><td class='colum-td-subhead'>" + hora5 + " -3</td><td class='colum-td-subhead'>" + hora6 + " -1</td><td class='colum-td-subhead'>" + hora6 + " -2</td><td class='colum-td-subhead'>" + hora6 + " -3</td><td class='colum-td-subhead'>" + hora7 + " -1</td><td class='colum-td-subhead'>" + hora7 + " -2</td><td class='colum-td-subhead'>" + hora7 + " -3</td><td class='colum-td-subhead'>" + hora8 + " -1</td><td class='colum-td-subhead'>" + hora8 + " -2</td><td class='colum-td-subhead'>" + hora8 + " -3</td><td class='colum-td-subhead'>" + hora9 + " -1</td><td class='colum-td-subhead'>" + hora9 + " -2</td><td class='colum-td-subhead'>" + hora9 + " -3</td>";
                    dvdinmaan36.InnerHtml += "<td class='colum-td-subhead'>" + hora10 + " -1</td><td class='colum-td-subhead'>" + hora10 + " -2</td><td class='colum-td-subhead'>" + hora10 + " -3</td><td class='colum-td-subhead'>" + hora11 + " -1</td><td class='colum-td-subhead'>" + hora11 + " -2</td><td class='colum-td-subhead'>" + hora11 + " -3</td><td class='colum-td-subhead'>" + hora12 + " -1</td><td class='colum-td-subhead'>" + hora12 + " -2</td><td class='colum-td-subhead'>" + hora12 + " -3</td>";
                    dvdinmaan36.InnerHtml += "</tr>";
                    dvdinmaan36.InnerHtml += "<tr>";
                }

                string[] testarr = getdinmaamratrimaan(sunrise, sunset);
                for (int j = 12; j <= 48; j++)
                {
                    string diff = "";
                    string dinman1 = "", dinman2 = "", finalval = "";
                    if (j == 12)
                    {
                        diff = testarr[0];
                        dvdinmaan36.InnerHtml += "<td class=\"colum-td-subhead\"></td>";
                        dvdinmaan36.InnerHtml += "<td class=\"colum-td-subhead\">";
                        dvdinmaan36.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 75px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + sunrisetime + "'>";
                        dvdinmaan36.InnerHtml += "</td>";
                        dvdinmaan36.InnerHtml += "<td class=\"colum-td-subhead\">";
                        dvdinmaan36.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 75px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + sunsettime + "'>";
                        dvdinmaan36.InnerHtml += "</td>";
                        dvdinmaan36.InnerHtml += "<td class=\"colum-td-subhead\">";
                        dvdinmaan36.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 75px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + diff + "'>";
                        dvdinmaan36.InnerHtml += "</td>";
                    }
                    else if (j == 13)
                    {
                        dinman1 = sunrisetime;
                        dinman2 = testarr[j];
                        dinman2 = dinman2.Split(' ').Last();
                        finalval = dinman1 + " - " + dinman2;
                        dvdinmaan36.InnerHtml += "<td class=\"colum-td-subhead\">";
                        dvdinmaan36.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 130px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + finalval + "'>";
                        dvdinmaan36.InnerHtml += "</td>";
                    }
                    else if (j == 48)
                    {
                        dinman1 = testarr[j - 1];
                        dinman1 = dinman1.Split(' ').Last();
                        dinman2 = testarr[j];
                        dinman2 = dinman2.Split(' ').Last();
                        finalval = dinman1 + " - " + dinman2;
                        dvdinmaan36.InnerHtml += "<td class=\"colum-td-subhead\">";
                        dvdinmaan36.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 130px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + finalval + "'>";
                        dvdinmaan36.InnerHtml += "</td>";
                    }
                    else
                    {
                        dinman1 = testarr[j - 1];
                        dinman1 = dinman1.Split(' ').Last();
                        dinman2 = testarr[j];
                        dinman2 = dinman2.Split(' ').Last();
                        finalval = dinman1 + " - " + dinman2;
                        dvdinmaan36.InnerHtml += "<td class=\"colum-td-subhead\">";
                        dvdinmaan36.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 130px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + finalval + "'>";
                        dvdinmaan36.InnerHtml += "</td>";
                    }
                }


                dvdinmaan36.InnerHtml += "</tr>";
                dvdinmaan36.InnerHtml += "</tbody>";
                dvdinmaan36.InnerHtml += "</table></td>";
                dvdinmaan36.InnerHtml += "</tr></tbody></table>";
            }
            


        }
        return ds;
    }

    public DataSet GetRatrimanHora36(string sunset, string sunrise, string sunrisenextday, string tob, string user, string dayofweek, string dateofbirth, string dateofbirth_nextdate, string sunrisetime, string sunsettime)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.getdinratman(sunset, sunrise, sunrisenextday, tob, user, "", "", dayofweek);

            if (ds.Tables[2].Rows.Count > 0)
            {
                //DateTime dtss = Convert.ToDateTime(sunsettime);
                //DateTime dtsr = Convert.ToDateTime(sunrisetime);
                //TimeSpan diff = dtss - dtsr;

                //DateTime dtn = Convert.ToDateTime(dobval).AddDays(1);
                //string dateofbirth_nextdate = dtn.ToString("dd/MM/yyyy");

                //dvratrimaan36.InnerHtml = "<h2 style='height: 15px; padding:3px 10px 3px 10px;font-size: 0.80em;'>HORA RESULT : Location: New Delhi</h2>";
                dvratrimaan36.InnerHtml += "<table><tbody><tr>";
                dvratrimaan36.InnerHtml += "<td style='width: 600px; display: block;' align='left'>";
                dvratrimaan36.InnerHtml += "<table id=\"Divgrid1\" runat=\"server\" align=\"left\" width=\"460px\" height=\"0px\" style=\"border: 1px;solid #7daae3;\" cellpadding=\"0\" cellspacing=\"0\">";
                dvratrimaan36.InnerHtml += "<tbody>";
                dvratrimaan36.InnerHtml += "<tr><td style='font-size:1em;' class=\"colum-td-head\" colspan=\"42\">Ratrimaan</td></tr>";
                dvratrimaan36.InnerHtml += "<tr><td class='colum-td-subhead'>Date</td><td class='colum-td-subhead'>" + dateofbirth + "</td>";
                dvratrimaan36.InnerHtml += "<td class='colum-td-subhead'>" + dateofbirth_nextdate + "</td><td class='colum-td-subhead'>" + dateofbirth + "</td><td class='colum-td-subhead'>Hora -1</td><td class='colum-td-subhead'>Hora -1</td><td class='colum-td-subhead'>Hora -1</td><td class='colum-td-subhead'>Hora -2</td><td class='colum-td-subhead'>Hora -2</td><td class='colum-td-subhead'>Hora -2</td><td class='colum-td-subhead'>Hora -3</td><td class='colum-td-subhead'>Hora -3</td><td class='colum-td-subhead'>Hora -3</td>";
                dvratrimaan36.InnerHtml += "<td class='colum-td-subhead'>Hora -4</td><td class='colum-td-subhead'>Hora -4</td><td class='colum-td-subhead'>Hora -4</td><td class='colum-td-subhead'>Hora -5</td><td class='colum-td-subhead'>Hora -5</td><td class='colum-td-subhead'>Hora -5</td><td class='colum-td-subhead'>Hora -6</td><td class='colum-td-subhead'>Hora -6</td><td class='colum-td-subhead'>Hora -6</td><td class='colum-td-subhead'>Hora -7</td><td class='colum-td-subhead'>Hora -7</td><td class='colum-td-subhead'>Hora -7</td><td class='colum-td-subhead'>Hora -8</td><td class='colum-td-subhead'>Hora -8</td><td class='colum-td-subhead'>Hora -8</td>";
                dvratrimaan36.InnerHtml += "<td class='colum-td-subhead'>Hora -9</td><td class='colum-td-subhead'>Hora -9</td><td class='colum-td-subhead'>Hora -9</td><td class='colum-td-subhead'>Hora -10</td><td class='colum-td-subhead'>Hora -10</td><td class='colum-td-subhead'>Hora -10</td><td class='colum-td-subhead'>Hora -11</td><td class='colum-td-subhead'>Hora -11</td><td class='colum-td-subhead'>Hora -11</td><td class='colum-td-subhead'>Hora -12</td><td class='colum-td-subhead'>Hora -12</td><td class='colum-td-subhead'>Hora -12</td>";
                dvratrimaan36.InnerHtml += "</tr>";
                if (ds.Tables[2].Rows.Count > 0)
                {
                    string hora1 = ds.Tables[2].Rows[0]["HORA_1"].ToString();
                    string hora2 = ds.Tables[2].Rows[0]["HORA_2"].ToString();
                    string hora3 = ds.Tables[2].Rows[0]["HORA_3"].ToString();
                    string hora4 = ds.Tables[2].Rows[0]["HORA_4"].ToString();
                    string hora5 = ds.Tables[2].Rows[0]["HORA_5"].ToString();
                    string hora6 = ds.Tables[2].Rows[0]["HORA_6"].ToString();
                    string hora7 = ds.Tables[2].Rows[0]["HORA_7"].ToString();
                    string hora8 = ds.Tables[2].Rows[0]["HORA_8"].ToString();
                    string hora9 = ds.Tables[2].Rows[0]["HORA_9"].ToString();
                    string hora10 = ds.Tables[2].Rows[0]["HORA_10"].ToString();
                    string hora11 = ds.Tables[2].Rows[0]["HORA_11"].ToString();
                    string hora12 = ds.Tables[2].Rows[0]["HORA_12"].ToString();
                    dvratrimaan36.InnerHtml += "<tr><td class='colum-td-subhead'>" + dayofweek + "</td><td class='colum-td-subhead'>Sunset HH:MM:SS</td><td class='colum-td-subhead'>Sunrise HH:MM:SS</td>";
                    dvratrimaan36.InnerHtml += "<td class='colum-td-subhead'>Night Length HH:MM:SS</td><td class='colum-td-subhead'>" + hora1 + " -1</td><td class='colum-td-subhead'>" + hora1 + " -2</td><td class='colum-td-subhead'>" + hora1 + " -3</td><td class='colum-td-subhead'>" + hora2 + " -1</td><td class='colum-td-subhead'>" + hora2 + " -2</td><td class='colum-td-subhead'>" + hora2 + " -3</td><td class='colum-td-subhead'>" + hora3 + " -1</td><td class='colum-td-subhead'>" + hora3 + " -2</td><td class='colum-td-subhead'>" + hora3 + " -3</td><td class='colum-td-subhead'>" + hora4 + " -1</td><td class='colum-td-subhead'>" + hora4 + " -2</td><td class='colum-td-subhead'>" + hora4 + " -3</td>";
                    dvratrimaan36.InnerHtml += "<td class='colum-td-subhead'>" + hora5 + " -1</td><td class='colum-td-subhead'>" + hora5 + " -2</td><td class='colum-td-subhead'>" + hora5 + " -3</td><td class='colum-td-subhead'>" + hora6 + " -1</td><td class='colum-td-subhead'>" + hora6 + " -2</td><td class='colum-td-subhead'>" + hora6 + " -3</td><td class='colum-td-subhead'>" + hora7 + " -1</td><td class='colum-td-subhead'>" + hora7 + " -2</td><td class='colum-td-subhead'>" + hora7 + " -3</td><td class='colum-td-subhead'>" + hora8 + " -1</td><td class='colum-td-subhead'>" + hora8 + " -2</td><td class='colum-td-subhead'>" + hora8 + " -3</td><td class='colum-td-subhead'>" + hora9 + " -1</td><td class='colum-td-subhead'>" + hora9 + " -2</td><td class='colum-td-subhead'>" + hora9 + " -3</td>";
                    dvratrimaan36.InnerHtml += "<td class='colum-td-subhead'>" + hora10 + " -1</td><td class='colum-td-subhead'>" + hora10 + " -2</td><td class='colum-td-subhead'>" + hora10 + " -3</td><td class='colum-td-subhead'>" + hora11 + " -1</td><td class='colum-td-subhead'>" + hora11 + " -2</td><td class='colum-td-subhead'>" + hora11 + " -3</td><td class='colum-td-subhead'>" + hora12 + " -1</td><td class='colum-td-subhead'>" + hora12 + " -2</td><td class='colum-td-subhead'>" + hora12 + " -3</td>";
                    dvratrimaan36.InnerHtml += "</tr>";
                    dvratrimaan36.InnerHtml += "<tr>";
                }

                //string[] testarr = getdinmaamratrimaan(sunset, sunrisenextday);
                string[] testarr = getdinmaamratrimaan(sunset, sunrise);
                for (int j = 12; j <= 48; j++)
                {
                    string diff = "";
                    string dinman1 = "", dinman2 = "", finalval = "";
                    if (j == 12)
                    {
                        diff = testarr[0];
                        dvratrimaan36.InnerHtml += "<td class=\"colum-td-subhead\"></td>";
                        dvratrimaan36.InnerHtml += "<td class=\"colum-td-subhead\">";
                        dvratrimaan36.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 75px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + sunsettime + "'>";
                        dvratrimaan36.InnerHtml += "</td>";
                        dvratrimaan36.InnerHtml += "<td class=\"colum-td-subhead\">";
                        dvratrimaan36.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 75px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + sunrisetimenext + "'>";
                        dvratrimaan36.InnerHtml += "</td>";
                        dvratrimaan36.InnerHtml += "<td class=\"colum-td-subhead\">";
                        dvratrimaan36.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 75px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + diff + "'>";
                        dvratrimaan36.InnerHtml += "</td>";
                    }
                    else if (j == 13)
                    {
                        dinman1 = sunsettime;
                        dinman2 = testarr[j];
                        dinman2 = dinman2.Split(' ').Last();
                        finalval = dinman1 + " - " + dinman2;
                        dvratrimaan36.InnerHtml += "<td class=\"colum-td-subhead\">";
                        dvratrimaan36.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 130px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + finalval + "'>";
                        dvratrimaan36.InnerHtml += "</td>";
                    }
                    else if (j == 48)
                    {
                        dinman1 = testarr[j - 1];
                        dinman1 = dinman1.Split(' ').Last();
                        dinman2 = testarr[j];
                        dinman2 = dinman2.Split(' ').Last();
                        finalval = dinman1 + " - " + dinman2;
                        dvratrimaan36.InnerHtml += "<td class=\"colum-td-subhead\">";
                        dvratrimaan36.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 130px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + finalval + "'>";
                        dvratrimaan36.InnerHtml += "</td>";
                    }
                    else
                    {
                        dinman1 = testarr[j - 1];
                        dinman1 = dinman1.Split(' ').Last();
                        dinman2 = testarr[j];
                        dinman2 = dinman2.Split(' ').Last();
                        finalval = dinman1 + " - " + dinman2;
                        dvratrimaan36.InnerHtml += "<td class=\"colum-td-subhead\">";
                        dvratrimaan36.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 130px;\" class=\"dropdown_large_corr\" align=\"left\" value='" + finalval + "'>";
                        dvratrimaan36.InnerHtml += "</td>";
                    }
                }
                dvratrimaan36.InnerHtml += "</tr>";
                dvratrimaan36.InnerHtml += "</tbody>";
                dvratrimaan36.InnerHtml += "</table></td>";
                dvratrimaan36.InnerHtml += "</tr></tbody></table>";
            }

        }
        return ds;
    }


    public string[] getdinmaamratrimaan(string sunrise, string sunset)
    {
        DateTime ss = new DateTime();
        ss = Convert.ToDateTime(sunset);
        DateTime sr = new DateTime();
        sr = Convert.ToDateTime(sunrise);
        TimeSpan ts = ss.Subtract(sr);

        int i;
        int k = Convert.ToInt32(ts.TotalSeconds);

        decimal ii = System.Math.Round(decimal.Divide(Convert.ToDecimal(k), 36), 2);
        decimal ii1 = System.Math.Round(decimal.Divide(Convert.ToDecimal(k), 12), 2);
        int ii2= 0;
        int ii3= 0;

        if (String.Compare(Convert.ToString(ii1), ".")>0)
        {
            string[] aa = null;
            aa = Convert.ToString(ii1).Split('.');
            ii2 = Convert.ToInt32(aa[0]);
            ii3 = k - (ii2 * 12);
        }
        else
        {
            ii2 = Convert.ToInt32(ii1);
            ii3 = 0;
        }
        string[] str = new string[36];
        string[] strd = new string[12];
        string[] strd1 = new string[49];
        int Hours;
        int Minutes;
        int Seconds;
        int ii33a = ii3;
        Seconds = k;
        Hours = Convert.ToInt32(Math.Floor(Convert.ToDouble(Seconds / 3600)));
        Seconds = Seconds % 3600;
        Minutes = Convert.ToInt32(Math.Floor(Convert.ToDouble(Seconds / 60)));
        Seconds = Seconds % 60;

        strd1[0] = ts.Hours.ToString("00") + ":" + ts.Minutes.ToString("00") + ":" + ts.Seconds.ToString("00");

        //DateTime date3;
        int j = 0;

        for (i = 1; i <= 12; i++)
        {
            if (i == 1)
            {
                strd[i - 1] = Convert.ToDateTime(sunrise).AddSeconds(Convert.ToDouble(ii2)).ToString("dd-MM-yyyy HH:mm:ss");
                date3 = Convert.ToDateTime(sunrise).AddSeconds(Convert.ToDouble(ii2));
                double ii1a = ii2 / 3;
                int ii2a = 0;
                int ii3a = 0;
                if (String.Compare(Convert.ToString(ii1a), ".")>0)
                {
                    string[] aa = null;
                    aa = Convert.ToString(ii1a).Split('.');
                    ii2a = Convert.ToInt32(aa[0]);
                    ii3a = ii2 - (ii2a * 3);
                }
                else
                {
                    ii2a = Convert.ToInt32(ii1a);
                    ii3a = 0;
                }
                DateTime date3a;
                date3a = Convert.ToDateTime(sunrise);
                str[j] = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a)).ToString("dd-MM-yyyy HH:mm:ss");
                j = j + 1;
                date3a = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a));
                str[j] = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a)).ToString("dd-MM-yyyy HH:mm:ss");
                j = j + 1;
                date3a = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a));
                str[j] = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a + ii3a)).ToString("dd-MM-yyyy HH:mm:ss");
               
                    str[j] = date3.ToString("dd-MM-yyyy HH:mm:ss");
                j = j + 1;
            }
            else
            {
                if(i % 2 == 0 && ii3 > 0)
                {
                    int iifg = 1;
                    if (i == 12 && ii3 > 0)
                    {
                        iifg = ii3;
                    }
                    else
                    {
                        if (ii33a > 10 && ii3 > 2)
                            iifg = 3;
                    }
                    strd[i - 1] = Convert.ToDateTime(date3).AddSeconds(Convert.ToDouble(ii2 + iifg)).ToString("dd-MM-yyyy HH:mm:ss");
                    ii3 = ii3 - iifg;
                    DateTime date3a;
                    date3a = date3;
                    date3 = Convert.ToDateTime(date3).AddSeconds(Convert.ToDouble(ii2 + iifg));
                    double ii1a = (ii2 + iifg) / 3;
                    int ii2a = 0;
                    int ii3a = 0;

                    if (String.Compare(Convert.ToString(ii1a), ".")>0)
                    {
                        string[] aa = null;
                        aa = Convert.ToString(ii1a).Split('.');
                        ii2a = Convert.ToInt32(aa[0]);
                        ii3a = (ii2 + 1) - (ii2a * 3);
                    }
                    else
                    {
                        ii2a = Convert.ToInt32(ii1a);
                        ii3a = 0;
                    }

                    str[j] = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a)).ToString("dd-MM-yyyy HH:mm:ss");
                    j = j + 1;
                    date3a = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a));
                    str[j] = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a)).ToString("dd-MM-yyyy HH:mm:ss");
                    j = j + 1;
                    date3a = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a));

                    str[j] = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a + ii3a)).ToString("dd-MM-yyyy HH:mm:ss");

                    str[j] = date3.ToString("dd-MM-yyyy HH:mm:ss");
                    j = j + 1;

                }
                else
                {
                    
                    strd[i - 1] = Convert.ToDateTime(date3).AddSeconds(Convert.ToDouble(ii2)).ToString("dd-MM-yyyy HH:mm:ss");
                    DateTime  date3a;
                    date3a = date3;
                    date3 = Convert.ToDateTime(date3).AddSeconds(Convert.ToDouble(ii2));

                    double ii1a = (ii2) / 3;
                    int ii2a  = 0;
                    int ii3a = 0;

                    if (String.Compare(Convert.ToString(ii1a), ".")>0)
                    {
                        string[] aa = null;
                        aa = Convert.ToString(ii1a).Split('.');
                        ii2a = Convert.ToInt32(aa[0]);
                        ii3a = ii2 - (ii2a * 3);
                    }
                    else
                    {
                        ii2a = Convert.ToInt32(ii1a);
                        ii3a = 0;
                    }

                    str[j] = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a)).ToString("dd-MM-yyyy HH:mm:ss");
                    j = j + 1;
                    date3a = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a));
                    str[j] = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a)).ToString("dd-MM-yyyy HH:mm:ss");
                    j = j + 1;
                    date3a = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a));
                    str[j] = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a)).ToString("dd-MM-yyyy HH:mm:ss");
                    str[j] = date3.ToString("dd-MM-yyyy HH:mm:ss");
                    j = j + 1;

                }
            }
        }
        for (i = 1; i <= 12; i++)
        {
            strd1[i] = strd[i - 1];
        }

        for (i = 13; i <= 48; i++) 
        {
            strd1[i] = str[i - 13];
        }
        return strd1;
    }








    //public string[] getdinmaamratrimaan(string sunrise, string sunset)
    //{
    //    DateTime ss = new DateTime();
    //    ss = Convert.ToDateTime(sunset);
    //    DateTime sr = new DateTime();
    //    sr = Convert.ToDateTime(sunrise);
    //    TimeSpan ts = ss.Subtract(sr);

    //    int i;
    //    int k = Convert.ToInt32(ts.TotalSeconds);

    //    decimal ii = System.Math.Round(decimal.Divide(Convert.ToDecimal(k), 36), 2);
    //    decimal ii1 = System.Math.Round(decimal.Divide(Convert.ToDecimal(k), 12), 2);
    //    int ii2 = 0;
    //    int ii3 = 0;

    //    if (String.Compare(Convert.ToString(ii1), ".") > 0)
    //    {
    //        string[] aa = null;
    //        aa = Convert.ToString(ii1).Split('.');
    //        ii2 = Convert.ToInt32(aa[0]);
    //        ii3 = k - (ii2 * 12);
    //    }
    //    else
    //    {
    //        ii2 = Convert.ToInt32(ii1);
    //        ii3 = 0;
    //    }
    //    string[] str = new string[36];
    //    string[] strd = new string[12];
    //    string[] strd1 = new string[49];
    //    int Hours;
    //    int Minutes;
    //    int Seconds;

    //    Seconds = k;
    //    Hours = Convert.ToInt32(Math.Floor(Convert.ToDouble(Seconds / 3600)));
    //    Seconds = Seconds % 3600;
    //    Minutes = Convert.ToInt32(Math.Floor(Convert.ToDouble(Seconds / 60)));
    //    Seconds = Seconds % 60;

    //    strd1[0] = ts.Hours.ToString("00") + ":" + ts.Minutes.ToString("00") + ":" + ts.Seconds.ToString("00");

    //    //DateTime date3;
    //    int j = 0;

    //    for (i = 1; i <= 12; i++)
    //    {
    //        if (i == 1)
    //        {
    //            strd[i - 1] = Convert.ToDateTime(sunrise).AddSeconds(Convert.ToDouble(ii2)).ToString("dd-MM-yyyy HH:mm:ss");
    //            date3 = Convert.ToDateTime(sunrise).AddSeconds(Convert.ToDouble(ii2));
    //            double ii1a = ii2 / 3;
    //            int ii2a = 0;
    //            int ii3a = 0;
    //            if (String.Compare(Convert.ToString(ii1a), ".") > 0)
    //            {
    //                string[] aa = null;
    //                aa = Convert.ToString(ii1a).Split('.');
    //                ii2a = Convert.ToInt32(aa[0]);
    //                ii3a = ii2 - (ii2a * 3);
    //            }
    //            else
    //            {
    //                ii2a = Convert.ToInt32(ii1a);
    //                ii3a = 0;
    //            }
    //            DateTime date3a;
    //            date3a = Convert.ToDateTime(sunrise);
    //            str[j] = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a)).ToString("dd-MM-yyyy HH:mm:ss");
    //            j = j + 1;
    //            date3a = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a));
    //            str[j] = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a)).ToString("dd-MM-yyyy HH:mm:ss");
    //            j = j + 1;
    //            date3a = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a));
    //            str[j] = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a + ii3a)).ToString("dd-MM-yyyy HH:mm:ss");
    //            j = j + 1;
    //        }
    //        else
    //        {
    //            if (i % 2 == 0 && ii3 > 0)
    //            {
    //                strd[i - 1] = Convert.ToDateTime(date3).AddSeconds(Convert.ToDouble(ii2 + 1)).ToString("dd-MM-yyyy HH:mm:ss");
    //                ii3 = ii3 - 1;
    //                DateTime date3a;
    //                date3a = date3;
    //                date3 = Convert.ToDateTime(date3).AddSeconds(Convert.ToDouble(ii2 + 1));
    //                double ii1a = (ii2 + 1) / 3;
    //                int ii2a = 0;
    //                int ii3a = 0;

    //                if (String.Compare(Convert.ToString(ii1a), ".") > 0)
    //                {
    //                    string[] aa = null;
    //                    aa = Convert.ToString(ii1a).Split('.');
    //                    ii2a = Convert.ToInt32(aa[0]);
    //                    ii3a = (ii2 + 1) - (ii2a * 3);
    //                }
    //                else
    //                {
    //                    ii2a = Convert.ToInt32(ii1a);
    //                    ii3a = 0;
    //                }

    //                str[j] = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a)).ToString("dd-MM-yyyy HH:mm:ss");
    //                j = j + 1;
    //                date3a = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a));
    //                str[j] = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a)).ToString("dd-MM-yyyy HH:mm:ss");
    //                j = j + 1;
    //                date3a = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a));

    //                str[j] = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a + ii3a)).ToString("dd-MM-yyyy HH:mm:ss");
    //                j = j + 1;

    //            }
    //            else
    //            {
    //                strd[i - 1] = Convert.ToDateTime(date3).AddSeconds(Convert.ToDouble(ii2)).ToString("dd-MM-yyyy HH:mm:ss");
    //                DateTime date3a;
    //                date3a = date3;
    //                date3 = Convert.ToDateTime(date3).AddSeconds(Convert.ToDouble(ii2));

    //                double ii1a = (ii2) / 3;
    //                int ii2a = 0;
    //                int ii3a = 0;

    //                if (String.Compare(Convert.ToString(ii1a), ".") > 0)
    //                {
    //                    string[] aa = null;
    //                    aa = Convert.ToString(ii1a).Split('.');
    //                    ii2a = Convert.ToInt32(aa[0]);
    //                    ii3a = ii2 - (ii2a * 3);
    //                }
    //                else
    //                {
    //                    ii2a = Convert.ToInt32(ii1a);
    //                    ii3a = 0;
    //                }

    //                str[j] = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a)).ToString("dd-MM-yyyy HH:mm:ss");
    //                j = j + 1;
    //                date3a = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a));
    //                str[j] = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a)).ToString("dd-MM-yyyy HH:mm:ss");
    //                j = j + 1;
    //                date3a = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a));
    //                str[j] = Convert.ToDateTime(date3a).AddSeconds(Convert.ToDouble(ii2a)).ToString("dd-MM-yyyy HH:mm:ss");
    //                j = j + 1;

    //            }
    //        }
    //    }
    //    for (i = 1; i <= 12; i++)
    //    {
    //        strd1[i] = strd[i - 1];
    //    }

    //    for (i = 13; i <= 48; i++)
    //    {
    //        strd1[i] = str[i - 13];
    //    }
    //    return strd1;
    //}

}
