using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.OracleClient;
using System.IO;
using System.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;

/// <summary>
/// Summary description for main
/// </summary>

namespace ASTROLOGY.classesoracle
{
    public class main : orclconnection
    {
        public main()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static bool SaveLogEntry(string ErrorMessage)
        {
            try
            {
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.Append("\r\n");
                sbMessage.Append("\r\n");
                sbMessage.Append("Date --" + System.DateTime.Now);
                sbMessage.Append("\r\n");
                sbMessage.Append("ErrorMessage --" + ErrorMessage);
                sbMessage.Append("\r\n");
                sbMessage.Append("\r\n");
                sbMessage.Append("****************************************************************************************");

                bool flag = WriteToLog(sbMessage);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private static bool WriteToLog(StringBuilder sbMessage)
        {
            try
            {
                FileStream fs;
                string strLogFileName = "Error_Log_" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
                string strLogFilePath = AppDomain.CurrentDomain.BaseDirectory + "Logs\\";
                if (!Directory.Exists(strLogFilePath))
                    Directory.CreateDirectory(strLogFilePath);

                if (File.Exists(strLogFilePath + strLogFileName) == true) { fs = File.Open(strLogFilePath + strLogFileName, FileMode.Append, FileAccess.Write); }
                else { fs = File.Create(strLogFilePath + strLogFileName); }
                {
                    using (StreamWriter sw = new StreamWriter(fs)) { sw.Write(sbMessage.ToString() + Environment.NewLine); }
                    fs.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void check_year_folder(int yyyy_sys, int mm_sys)
        {
            string folder = "gall_content/" + yyyy_sys + "";
            DirectoryInfo myDirectoryInfo = new DirectoryInfo(HttpContext.Current.Server.MapPath(folder));
            if (myDirectoryInfo.Exists)
            {
                string folder1 = "gall_content/" + yyyy_sys + "/" + mm_sys + "";
                DirectoryInfo myDirectoryInfo1 = new DirectoryInfo(HttpContext.Current.Server.MapPath(folder1));
                if (myDirectoryInfo1.Exists)
                {

                }
                else
                {
                    myDirectoryInfo1.Create();
                }
            }
            else
            {
                myDirectoryInfo.Create();
                string folder2 = "gall_content/" + yyyy_sys + "/" + mm_sys + "";
                DirectoryInfo myDirectoryInfo2 = new DirectoryInfo(HttpContext.Current.Server.MapPath(folder2));
                myDirectoryInfo2.Create();
            }
        }

        public string getpath(string path)
        {
            try
            {
                string getimg = path;
                string getimage = "";
                if (getimg.Contains("$"))
                {
                    string[] splitfname = getimg.Split('$');
                    int indexjpg = splitfname.GetLowerBound(0);
                    string findjpg = splitfname[indexjpg];

                    string[] splyear = findjpg.Split('_');
                    int getyear = splyear.GetLowerBound(0);
                    string findyer = splyear[getyear];

                    string[] splmnth = findjpg.Split('_');
                    int getmnth = splmnth.GetUpperBound(0);
                    string findmonth = splmnth[getmnth];

                    getimage = "gall_content/" + findyer + "/" + findmonth + "/" + getimg;
                }
                else
                {
                    getimage = getimg;
                }
                return getimage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string replaceQoute(string input)
        {
            string strInput = input;
            string pattern = "'+";
            if (Regex.IsMatch(strInput, pattern))
            {
                foreach (Match m in Regex.Matches(strInput, pattern))
                {
                    strInput = strInput.Replace(m.Value, "'");
                }
            }
            return strInput;
        }
        public string optimizeURL(string input)
        {
            string strInput = input.ToLower();
            strInput = Regex.Replace(strInput, @"[^\w\@-]", "-");
            string pattern = "-+";
            if (Regex.IsMatch(strInput, pattern))
            {
                foreach (Match m in Regex.Matches(strInput, pattern))
                {
                    strInput = strInput.Replace(m.Value, "-");
                }
            }
            strInput = Regex.Replace(strInput, "-$", "");
            strInput = strInput.Replace("'", "");
            strInput = strInput.Replace("update", "updat");
            return strInput;
        }



        public DataSet GetMaxId(string columnname, string tablename)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_GET_MAXID", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("COLUMNNAME", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = columnname;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("TABLENAME", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = tablename;
                orclcmd.Parameters.Add(prm2);

                orclcmd.Parameters.Add("p_out", OracleType.Cursor);
                orclcmd.Parameters["p_out"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }

        

        public DataSet Save_AlbumGallery(int gallid, string headline, string desc, string caption, string videourl,string largeimg, string thumbimg, int album_id, string status, int priority, string groupid,string user_type,int langid)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_SAVE_ALBUMGALLERY", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("GALLID", OracleType.Number);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = gallid;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("HEADLINE", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = headline;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("DESCRIPTION", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = desc;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("CAPTION", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = caption;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("VIDEOURL", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = videourl;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("LARGEIMG", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = largeimg;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("THUMBIMG", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = thumbimg;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("ALBUMID", OracleType.Number);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = album_id;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("STATUS", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = status;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("PRIORITY", OracleType.Number);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = priority;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("GROUPID", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = groupid;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("USERTYPE", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = user_type;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("LANGID", OracleType.Number);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = langid;
                orclcmd.Parameters.Add(prm13);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }

        public DataSet Save_Album(int albumid, int catid, string albumname, string coverimg, string thumbimg, string keywords, string desc, string crtd_by, string status, int priority, string lead, string latest, string groupid, string user_type, int langid)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_SAVE_ALBUM", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("ALBUMID", OracleType.Number);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = albumid;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("CATID", OracleType.Number);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = catid;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("ALBUMNAME", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = albumname;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("COVERIMG", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = coverimg;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("THUMBIMG", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = thumbimg;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("KEYWORDS", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = keywords;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("DESCRIPTION", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = desc;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("CRTDBY", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = crtd_by;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("STATUS", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = status;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("PRIORITY", OracleType.Number);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = priority;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("LEAD", OracleType.Char, 1);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = lead;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("LATEST", OracleType.Char, 1);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = latest;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("GROUPID", OracleType.VarChar, 4000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = groupid;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("USERTYPE", OracleType.VarChar, 4000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = user_type;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("LANGID", OracleType.Number);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = langid;
                orclcmd.Parameters.Add(prm15);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }

        public DataSet GetGallery(int gallid, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_ALBUMGALLERY", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("ALBUM_GALLID", OracleType.Number);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = gallid;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("FLAG", OracleType.VarChar, 50);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = flag;
                orclcmd.Parameters.Add(prm2);

                orclcmd.Parameters.Add("p_out", OracleType.Cursor);
                orclcmd.Parameters["p_out"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }

        public DataSet DeleteAlbumGallery(int id, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_DELETE_ALBUMGALLERY", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("GALL_ALBUM_ID", OracleType.Number);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = id;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("FLAG", OracleType.VarChar, 50);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = flag;
                orclcmd.Parameters.Add(prm2);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }


        public DataSet UpdateAlbumGallery(int albumid,int gallid,string caption,string thumbimg,string largeimg, string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_UPDATE_ALBUMGALLERY", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("ALBUMID", OracleType.Number);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = albumid;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("GALLID", OracleType.Number);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = gallid;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("IMGCAPTION", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = caption;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("THUMBIMG", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = thumbimg;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("LARGEIMG", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = largeimg;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("FLAG", OracleType.VarChar, 50);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = flag;
                orclcmd.Parameters.Add(prm6);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }




        public DataSet GetAstrologyVideos(string groupid, int userid,int langid,int albumid,string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_ASTROVIDEOS", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("GROUPID", OracleType.VarChar, 10);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = groupid;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("USER_ID", OracleType.Number);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = userid;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("LANGID", OracleType.Number);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = langid;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("ALBUMID", OracleType.Number);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = albumid;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("FLAG", OracleType.VarChar, 10);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = flag;
                orclcmd.Parameters.Add(prm5);

                orclcmd.Parameters.Add("p_out", OracleType.Cursor);
                orclcmd.Parameters["p_out"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }

        public DataSet insert_astro_subscription(string UId, string UName, string Uemail, string Ualtemail, string Umobileno, string Ulandlineno,
        string Uadd1, string Uadd2, string Ulandmark, string Ucountrycal, string Upincode, string Upwd, string Ucaptcha, string subscriptionfor,
        string Uactive, string Ugender, string Ustateval, string Ucityval, string Utype, string Usubs_validity_natal, string validfrom_natal,
        string validto_natal, string Usubs_validity_horary, string validfrom_horary, string validto_horary, string paymentstatus,
        string natalprice,string horaryprice,string finalpay, string flagval)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("INSERT_ASTRO_DTLS", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("USER_ID", OracleType.VarChar,10);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = UId;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("USER_NAME", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = UName;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("USER_EMAIL", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Uemail;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("USER_ALTEMAIL", OracleType.VarChar, 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Ualtemail;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("USER_MOBNO", OracleType.VarChar, 20);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Umobileno;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("USER_LANDLINENO", OracleType.VarChar, 50);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = Ulandlineno;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("USER_ADDFIRST", OracleType.VarChar, 300);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = Uadd1;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("USER_ADDSECOND", OracleType.VarChar, 300);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = Uadd2;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("USER_LANDMARK", OracleType.VarChar, 300);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = Ulandmark;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("USER_COUNTRY", OracleType.VarChar, 20);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = Ucountrycal;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("USER_PINCODE", OracleType.VarChar, 10);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = Upincode;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("USER_PWD", OracleType.VarChar, 30);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = Upwd;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("USER_CAPTCHA", OracleType.VarChar, 20);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = Ucaptcha;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("SUBSCRIPTION_FOR", OracleType.VarChar, 20);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = subscriptionfor;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("USER_ACTIVE", OracleType.VarChar, 1);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = Uactive;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("USER_GENDER", OracleType.VarChar, 10);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = Ugender;
                orclcmd.Parameters.Add(prm16);

                OracleParameter prm17 = new OracleParameter("USER_STATE", OracleType.VarChar, 50);
                prm17.Direction = ParameterDirection.Input;
                prm17.Value = Ustateval;
                orclcmd.Parameters.Add(prm17);

                OracleParameter prm18 = new OracleParameter("USER_CITY", OracleType.VarChar, 50);
                prm18.Direction = ParameterDirection.Input;
                prm18.Value = Ucityval;
                orclcmd.Parameters.Add(prm18);

                OracleParameter prm19 = new OracleParameter("USERTYPE", OracleType.VarChar, 1);
                prm19.Direction = ParameterDirection.Input;
                prm19.Value = Utype;
                orclcmd.Parameters.Add(prm19);

                OracleParameter prm20 = new OracleParameter("SUBSVALIDITY_NATAL", OracleType.VarChar, 10);
                prm20.Direction = ParameterDirection.Input;
                prm20.Value = Usubs_validity_natal;
                orclcmd.Parameters.Add(prm20);

                OracleParameter prm21 = new OracleParameter("VALIDFROM_NATAL", OracleType.VarChar, 20);
                prm21.Direction = ParameterDirection.Input;
                prm21.Value = validfrom_natal;
                orclcmd.Parameters.Add(prm21);

                OracleParameter prm22 = new OracleParameter("VALIDTO_NATAL", OracleType.VarChar, 20);
                prm22.Direction = ParameterDirection.Input;
                prm22.Value = validto_natal;
                orclcmd.Parameters.Add(prm22);

                OracleParameter prm23 = new OracleParameter("SUBSVALIDITY_HORARY", OracleType.VarChar, 10);
                prm23.Direction = ParameterDirection.Input;
                prm23.Value = Usubs_validity_horary;
                orclcmd.Parameters.Add(prm23);

                OracleParameter prm24 = new OracleParameter("VALIDFROM_HORARY", OracleType.VarChar, 20);
                prm24.Direction = ParameterDirection.Input;
                prm24.Value = validfrom_horary;
                orclcmd.Parameters.Add(prm24);

                OracleParameter prm25 = new OracleParameter("VALIDTO_HORARY", OracleType.VarChar, 20);
                prm25.Direction = ParameterDirection.Input;
                prm25.Value = validto_horary;
                orclcmd.Parameters.Add(prm25);

                OracleParameter prm26 = new OracleParameter("PAYMENTSTATUS", OracleType.VarChar, 1);
                prm26.Direction = ParameterDirection.Input;
                prm26.Value = paymentstatus;
                orclcmd.Parameters.Add(prm26);

                OracleParameter prm27 = new OracleParameter("PRICE_NATAL", OracleType.VarChar, 10);
                prm27.Direction = ParameterDirection.Input;
                prm27.Value = natalprice;
                orclcmd.Parameters.Add(prm27);

                OracleParameter prm28 = new OracleParameter("PRICE_HORARY", OracleType.VarChar, 10);
                prm28.Direction = ParameterDirection.Input;
                prm28.Value = horaryprice;
                orclcmd.Parameters.Add(prm28);

                OracleParameter prm29 = new OracleParameter("FINALPRICE", OracleType.VarChar, 10);
                prm29.Direction = ParameterDirection.Input;
                prm29.Value = finalpay;
                orclcmd.Parameters.Add(prm29);

                OracleParameter prm30 = new OracleParameter("FLAGTYPE", OracleType.VarChar, 100);
                prm30.Direction = ParameterDirection.Input;
                prm30.Value = flagval;
                orclcmd.Parameters.Add(prm30);

                orclcmd.Parameters.Add("outflag", OracleType.Cursor);
                orclcmd.Parameters["outflag"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }


        public DataSet AstGetCommon(string Id, string UrseType, string GroupId, string Flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_GET_COMMON", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("IDVAL", OracleType.VarChar, 100);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Id;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("USERTYPE", OracleType.VarChar, 100);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = UrseType;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("GROUPID", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = GroupId;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Flag;
                orclcmd.Parameters.Add(prm4);

                orclcmd.Parameters.Add("p_out", OracleType.Cursor);
                orclcmd.Parameters["p_out"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }


        public DataSet GetVargas(string UserId ,string Chart,string Flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ASP_GET_VARGAS", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("USERID", OracleType.VarChar, 50);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = UserId;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("CHARTNO", OracleType.VarChar, 50);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = Chart;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("FLAG", OracleType.VarChar, 200);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = Flag;
                orclcmd.Parameters.Add(prm3);

                orclcmd.Parameters.Add("p_out1", OracleType.Cursor);
                orclcmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

                da.SelectCommand = orclcmd;
                da.Fill(ds);
                return ds;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                con.Close();
            }
        }


    }
}
