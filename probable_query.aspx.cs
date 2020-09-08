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

public partial class probable_query : System.Web.UI.Page
{
    public DateTime date3;
    string sunsetval = "", sunriseval = "", sunrisenext = "", dtobval = "", dobval = "", tobval = "", astrogrname = "", dayofweek = "", dateofbirth = "";
    string sunrisetime = "", sunsettime = "", sunrisetimenext = "";
    public string[] testarr;
    protected void Page_Load(object sender, EventArgs e)
    {
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
            GetProbableQuery(sunsetval, sunriseval, sunrisenext, dtobval, astrogrname, dayofweek, dateofbirth);
        }
    }

    public DataSet GetProbableQuery(string sunset, string sunrise, string sunrisenextday, string tob, string user, string dayofweek, string dateofbirth)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.myaccount country = new ASTROLOGY.classesoracle.myaccount();
            ds = country.getdinratman(sunset, sunrise, sunrisenextday, tob, user, "", "", dayofweek.ToUpper());
            DataSet dss = new DataSet();
            string hora_name = "", hora_part = "";
            string[] hora_arr = new string[36];
            string horavalue = "";
            

            TimeSpan ts_tobval = TimeSpan.Parse(tobval);
            TimeSpan ts_sunrisetime = TimeSpan.Parse(sunrisetime);
            TimeSpan ts_sunsettime = TimeSpan.Parse(sunsettime);
            if (ts_sunrisetime <= ts_tobval && ts_sunsettime >= ts_tobval)
            {
                if (ds.Tables[1].Rows.Count > 0)
                {
                    string hora1 = ds.Tables[1].Rows[0]["HORA_1"].ToString();
                    hora_arr[0] = hora1 + "-1";
                    hora_arr[1] = hora1 + "-2";
                    hora_arr[2] = hora1 + "-3";
                    string hora2 = ds.Tables[1].Rows[0]["HORA_2"].ToString();
                    hora_arr[3] = hora2 + "-1";
                    hora_arr[4] = hora2 + "-2";
                    hora_arr[5] = hora2 + "-3";
                    string hora3 = ds.Tables[1].Rows[0]["HORA_3"].ToString();
                    hora_arr[6] = hora3 + "-1";
                    hora_arr[7] = hora3 + "-2";
                    hora_arr[8] = hora3 + "-3";
                    string hora4 = ds.Tables[1].Rows[0]["HORA_4"].ToString();
                    hora_arr[9] = hora4 + "-1";
                    hora_arr[10] = hora4 + "-2";
                    hora_arr[11] = hora4 + "-3";
                    string hora5 = ds.Tables[1].Rows[0]["HORA_5"].ToString();
                    hora_arr[12] = hora5 + "-1";
                    hora_arr[13] = hora5 + "-2";
                    hora_arr[14] = hora5 + "-3";
                    string hora6 = ds.Tables[1].Rows[0]["HORA_6"].ToString();
                    hora_arr[15] = hora6 + "-1";
                    hora_arr[16] = hora6 + "-2";
                    hora_arr[17] = hora6 + "-3";
                    string hora7 = ds.Tables[1].Rows[0]["HORA_7"].ToString();
                    hora_arr[18] = hora7 + "-1";
                    hora_arr[19] = hora7 + "-2";
                    hora_arr[20] = hora7 + "-3";
                    string hora8 = ds.Tables[1].Rows[0]["HORA_8"].ToString();
                    hora_arr[21] = hora8 + "-1";
                    hora_arr[22] = hora8 + "-2";
                    hora_arr[23] = hora8 + "-3";
                    string hora9 = ds.Tables[1].Rows[0]["HORA_9"].ToString();
                    hora_arr[24] = hora9 + "-1";
                    hora_arr[25] = hora9 + "-2";
                    hora_arr[26] = hora9 + "-3";
                    string hora10 = ds.Tables[1].Rows[0]["HORA_10"].ToString();
                    hora_arr[27] = hora10 + "-1";
                    hora_arr[28] = hora10 + "-2";
                    hora_arr[29] = hora10 + "-3";
                    string hora11 = ds.Tables[1].Rows[0]["HORA_11"].ToString();
                    hora_arr[30] = hora11 + "-1";
                    hora_arr[31] = hora11 + "-2";
                    hora_arr[32] = hora11 + "-3";
                    string hora12 = ds.Tables[1].Rows[0]["HORA_12"].ToString();
                    hora_arr[33] = hora12 + "-1";
                    hora_arr[34] = hora12 + "-2";
                    hora_arr[35] = hora12 + "-3";
                    testarr = getdinmaamratrimaan(sunrise, sunset);
                }
            }
            else
            {
                if (ds.Tables[2].Rows.Count > 0)
                {
                    string hora1 = ds.Tables[2].Rows[0]["HORA_1"].ToString();
                    hora_arr[0] = hora1 + "-1";
                    hora_arr[1] = hora1 + "-2";
                    hora_arr[2] = hora1 + "-3";
                    string hora2 = ds.Tables[2].Rows[0]["HORA_2"].ToString();
                    hora_arr[3] = hora2 + "-1";
                    hora_arr[4] = hora2 + "-2";
                    hora_arr[5] = hora2 + "-3";
                    string hora3 = ds.Tables[2].Rows[0]["HORA_3"].ToString();
                    hora_arr[6] = hora3 + "-1";
                    hora_arr[7] = hora3 + "-2";
                    hora_arr[8] = hora3 + "-3";
                    string hora4 = ds.Tables[2].Rows[0]["HORA_4"].ToString();
                    hora_arr[9] = hora4 + "-1";
                    hora_arr[10] = hora4 + "-2";
                    hora_arr[11] = hora4 + "-3";
                    string hora5 = ds.Tables[2].Rows[0]["HORA_5"].ToString();
                    hora_arr[12] = hora5 + "-1";
                    hora_arr[13] = hora5 + "-2";
                    hora_arr[14] = hora5 + "-3";
                    string hora6 = ds.Tables[2].Rows[0]["HORA_6"].ToString();
                    hora_arr[15] = hora6 + "-1";
                    hora_arr[16] = hora6 + "-2";
                    hora_arr[17] = hora6 + "-3";
                    string hora7 = ds.Tables[2].Rows[0]["HORA_7"].ToString();
                    hora_arr[18] = hora7 + "-1";
                    hora_arr[19] = hora7 + "-2";
                    hora_arr[20] = hora7 + "-3";
                    string hora8 = ds.Tables[2].Rows[0]["HORA_8"].ToString();
                    hora_arr[21] = hora8 + "-1";
                    hora_arr[22] = hora8 + "-2";
                    hora_arr[23] = hora8 + "-3";
                    string hora9 = ds.Tables[2].Rows[0]["HORA_9"].ToString();
                    hora_arr[24] = hora9 + "-1";
                    hora_arr[25] = hora9 + "-2";
                    hora_arr[26] = hora9 + "-3";
                    string hora10 = ds.Tables[2].Rows[0]["HORA_10"].ToString();
                    hora_arr[27] = hora10 + "-1";
                    hora_arr[28] = hora10 + "-2";
                    hora_arr[29] = hora10 + "-3";
                    string hora11 = ds.Tables[2].Rows[0]["HORA_11"].ToString();
                    hora_arr[30] = hora11 + "-1";
                    hora_arr[31] = hora11 + "-2";
                    hora_arr[32] = hora11 + "-3";
                    string hora12 = ds.Tables[2].Rows[0]["HORA_12"].ToString();
                    hora_arr[33] = hora12 + "-1";
                    hora_arr[34] = hora12 + "-2";
                    hora_arr[35] = hora12 + "-3";
                    testarr = getdinmaamratrimaan(sunset, sunrisenextday);
                }
            }

            

            
            int i = 0;
            for (int j = 12; j <= 48; j++)
            {
                string diff = "";
                string dinman1 = "", dinman2 = "", finalval = "";
                if (j == 12)
                {
                    diff = testarr[0];
                    horavalue = hora_arr[i];
                }
                else if (j == 13)
                {
                    dinman1 = sunrisetime;
                    dinman2 = testarr[j];
                    dinman2 = dinman2.Split(' ').Last();
                    finalval = dinman1 + " - " + dinman2;

                    TimeSpan ts_dinman1 = TimeSpan.Parse(dinman1);
                    TimeSpan ts_dinman2 = TimeSpan.Parse(dinman2);
                    if (ts_dinman1 <= ts_tobval && ts_dinman2 >= ts_tobval)
                    {
                        finalval = dinman1 + " - " + dinman2;
                        horavalue = hora_arr[i];
                        hora_name = horavalue.Split('-').First();
                        hora_part = horavalue.Split('-').Last();
                    }
                    i++;
                }
                else if (j == 48)
                {
                    dinman1 = testarr[j - 1];
                    dinman1 = dinman1.Split(' ').Last();
                    dinman2 = testarr[j];
                    dinman2 = dinman2.Split(' ').Last();
                    finalval = dinman1 + " - " + dinman2;

                    TimeSpan ts_dinman1 = TimeSpan.Parse(dinman1);
                    TimeSpan ts_dinman2 = TimeSpan.Parse(dinman2);
                    if (ts_dinman1 <= ts_tobval && ts_dinman2 >= ts_tobval)
                    {
                        finalval = dinman1 + " - " + dinman2;
                        horavalue = hora_arr[i];
                        hora_name = horavalue.Split('-').First();
                        hora_part = horavalue.Split('-').Last();
                    }
                }
                else
                {
                    dinman1 = testarr[j - 1];
                    dinman1 = dinman1.Split(' ').Last();
                    dinman2 = testarr[j];
                    dinman2 = dinman2.Split(' ').Last();
                    finalval = dinman1 + " - " + dinman2;

                    TimeSpan ts_dinman1 = TimeSpan.Parse(dinman1);
                    TimeSpan ts_dinman2 = TimeSpan.Parse(dinman2);
                    if (ts_dinman1 <= ts_tobval && ts_dinman2 >= ts_tobval)
                    {
                        finalval = dinman1 + " - " + dinman2;
                        horavalue = hora_arr[i];
                        hora_name = horavalue.Split('-').First();
                        hora_part = horavalue.Split('-').Last();
                    }
                    i++;
                }
            }

            dss = country.getdinratman(sunset, sunrise, sunrisenextday, tob, user, hora_name, hora_part,"");
            if (dss.Tables[0].Rows.Count > 0)
            {
                dvquery.InnerHtml = "<h2 style='font-size: 0.80em; width:100%; border-bottom:2px solid #c5c5c5;float:left;box-sizing: border-box;height: 100%;margin-bottom: 10px;padding-bottom: 10px;'>Probable Query</h2>";
                dvquery.InnerHtml += "<table id=\"Divgrid1\" runat=\"server\" align=\"left\" width=\"100%\" height=\"0px\" style=\"border: 1px;solid #7daae3;\" cellpadding=\"0\" cellspacing=\"0\">";
                dvquery.InnerHtml += "<tbody>";
                for (int j = 0; j < dss.Tables[0].Rows.Count; j++)
                {
                    string DESCCLOB = dss.Tables[0].Rows[j]["DESCCLOB"].ToString();
                    dvquery.InnerHtml += "<tr>";
                    dvquery.InnerHtml += "<td class=\"colum-td-subhead\" style='border-right:none !important; border-bottom:none !important;padding:5px 10px;'>";
                    dvquery.InnerHtml += "<input type=\"text\" enabled=\"false\" disabled='' style=\"width: 100%;\" class=\"dropdown_large_corr\" align=\"left\" value='>> " + DESCCLOB + "'>";
                    dvquery.InnerHtml += "</td>";
                    dvquery.InnerHtml += "</tr>";
                }
                dvquery.InnerHtml += "</tbody>";
                dvquery.InnerHtml += "</table>";
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
        int ii2 = 0;
        int ii3 = 0;

        if (String.Compare(Convert.ToString(ii1), ".") > 0)
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
                if (String.Compare(Convert.ToString(ii1a), ".") > 0)
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
                if (i % 2 == 0 && ii3 > 0)
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

                    if (String.Compare(Convert.ToString(ii1a), ".") > 0)
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
                    DateTime date3a;
                    date3a = date3;
                    date3 = Convert.ToDateTime(date3).AddSeconds(Convert.ToDouble(ii2));

                    double ii1a = (ii2) / 3;
                    int ii2a = 0;
                    int ii3a = 0;

                    if (String.Compare(Convert.ToString(ii1a), ".") > 0)
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



}
