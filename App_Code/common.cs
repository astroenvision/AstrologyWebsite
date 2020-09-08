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
using System.Data.SqlClient;
using System.Data.OracleClient;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Net.Mail;
using System.Text.RegularExpressions;

/// <summary>
/// Summary description for common
/// </summary>
public class common
{
    public string WEBSITEDomain = ConfigurationManager.AppSettings["WEBSITEDomain"].ToString();
    public string SMTPServer = ConfigurationManager.AppSettings["SMTPServer"].ToString();
	public common()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    #region  ReplaceQuotes
    public string ReplaceQuotes(string input)
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
    #endregion

    #region OptimizeURL
    public string OptimizeURL(string input)
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
    #endregion

    #region bindloc
    public DataSet bindloc()
    {
        DataSet ds = new DataSet();
        OracleConnection cn = getConnection();
        try
        {
            OracleCommand com = new OracleCommand("sp_sendQuery", cn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("varFlag",OracleType.VarChar).Value = "location";

            com.Parameters.Add("p_accounts", OracleType.Cursor);
            com.Parameters["p_accounts"].Direction = ParameterDirection.Output;

            int rows = com.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(com);
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex) { throw ex; }
        finally
        {
            ds.Dispose();
            cn.Close();
        }
    }
    #endregion

    #region bindstate
    public DataSet bindstate(string filter,string country)
    {
        DataSet ds = new DataSet();
        OracleConnection cn = getConnection();
        try
        {
            OracleCommand com = new OracleCommand("sp_sendQuerys", cn);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("vfilter", OracleType.VarChar).Value = filter;
            com.Parameters.Add("vcountry", OracleType.VarChar).Value = country;

            com.Parameters.Add("p_accounts", OracleType.Cursor);
            com.Parameters["p_accounts"].Direction = ParameterDirection.Output;

            int rows = com.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(com);
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex) { throw ex; }
        finally
        {
            ds.Dispose();
            cn.Close();
        }
    }
    #endregion

    #region binddistrict
    public DataSet binddistrict(string country,string state,string district)
    {
        DataSet ds = new DataSet();
        OracleConnection cn = getConnection();
        try
        {
            OracleCommand com = new OracleCommand("sp_sendQueryd", cn);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("vcountry", OracleType.VarChar).Value = country;
            com.Parameters.Add("vstate", OracleType.VarChar).Value = state;
            com.Parameters.Add("vdistrict", OracleType.VarChar).Value = district;

            com.Parameters.Add("p_accounts", OracleType.Cursor);
            com.Parameters["p_accounts"].Direction = ParameterDirection.Output;

            int rows = com.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(com);
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex) { throw ex; }
        finally
        {
            ds.Dispose();
            cn.Close();
        }
    }
    #endregion

    #region isdate2
    public DataSet isdate2(int ist3, string tob, string dateob)
    {
        DataSet ds = new DataSet();
        OracleConnection cn = getConnection();
        try
        {
            OracleCommand com = new OracleCommand("AST_ISDATE", cn);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("vist", OracleType.Number).Value = ist3;
            com.Parameters.Add("vitob", OracleType.VarChar).Value = tob;
            string[] arr = dateob.Split('/');
                    string dd = arr[0];
                    string mm = arr[1];
                    string yy = arr[2];
                    dateob = mm + "/" + dd + "/" + yy ;

                    com.Parameters.Add("vdateob", OracleType.VarChar).Value = Convert.ToDateTime(dateob).ToString("dd-MMMM-yyyy"); 


            //OracleParameter prm5 = new OracleParameter("fromdate", OracleType.VarChar);
            //prm5.Direction = ParameterDirection.Input;
            //if (startdate == "" || startdate == null)
            //{
            //    prm5.Value = System.DBNull.Value;
            //}
            //else
            //{
            //    if (dateformate == "dd/mm/yyyy")
            //    {
            //        string[] arr = startdate.Split('/');
            //        string dd = arr[0];
            //        string mm = arr[1];
            //        string yy = arr[2];
            //        startdate = mm + "/" + dd + "/" + yy;


            //    }
            //    prm5.Value = Convert.ToDateTime(startdate).ToString("dd-MMMM-yyyy");
            //}
            //// prm3.Value = startdate;
            //objOraclecommand.Parameters.Add(prm5);

            com.Parameters.Add("p_accounts", OracleType.Cursor);
            com.Parameters["p_accounts"].Direction = ParameterDirection.Output;

            int rows = com.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(com);
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex) { throw ex; }
        finally
        {
            ds.Dispose();
            cn.Close();
        }
    }
    #endregion

    #region actsrss

    public DataSet actsrss(string sr, string tz, string ss,string dob)
    {
        DataSet ds = new DataSet();
        OracleConnection cn = getConnection();
        try
        {
            OracleCommand com = new OracleCommand("AST_SSRR", cn);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("vsr", OracleType.VarChar).Value = sr;
            com.Parameters.Add("vtz", OracleType.VarChar).Value = tz;
            com.Parameters.Add("vss", OracleType.VarChar).Value = ss;
            com.Parameters.Add("vdob", OracleType.VarChar).Value = dob;
            com.Parameters.Add("p_accounts", OracleType.Cursor);
            com.Parameters["p_accounts"].Direction = ParameterDirection.Output;
            com.Parameters.Add("p_accounts1", OracleType.Cursor);
            com.Parameters["p_accounts1"].Direction = ParameterDirection.Output;

            int rows = com.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(com);
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex) { throw ex; }
        finally
        {
            ds.Dispose();
            cn.Close();
        }
    }
    #endregion

    #region bindcity
    public DataSet bindcity(string country, string state,string district,string city)
    {
        DataSet ds = new DataSet();
        OracleConnection cn = getConnection();
        try
        {
            OracleCommand com = new OracleCommand("sp_sendQueryc", cn);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("vcountry", OracleType.VarChar).Value = country;
            com.Parameters.Add("vstate", OracleType.VarChar).Value = state;

            com.Parameters.Add("vdistrict", OracleType.VarChar).Value = district;
            com.Parameters.Add("vcity", OracleType.VarChar).Value = city;

            com.Parameters.Add("p_accounts", OracleType.Cursor);
            com.Parameters["p_accounts"].Direction = ParameterDirection.Output;

            int rows = com.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(com);
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex) { throw ex; }
        finally
        {
            ds.Dispose();
            cn.Close();
        }
    }
    #endregion

    #region getConnection
    public OracleConnection getConnection()
    {
        OracleConnection cn = new OracleConnection(ConfigurationManager.AppSettings["orclConnectionString"]);
        if (cn.State == ConnectionState.Open)
        {

        }
        else if (cn.State == ConnectionState.Closed)
        {
            cn.Open();
        }
        return cn;
    }
    #endregion

    #region insert_astro_dtls

    public void insert_astro_dtls(string name, string mmail, string amail, string mobno, string landno, string add1, string add2, string lndmrk, string zip, string country, string pass, string captcha, string subscription,string flag,string gender,string state,string city,string user_type)
    {        
        OracleConnection cn = getConnection();
        try
        {
            OracleCommand com = new OracleCommand("ins_astro_dtls", cn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("name", OracleType.VarChar).Value = name;
            com.Parameters.Add("mmail", OracleType.VarChar).Value = mmail;
            com.Parameters.Add("amail", OracleType.VarChar).Value = amail;
            com.Parameters.Add("mobno", OracleType.VarChar).Value = mobno;
            com.Parameters.Add("landno", OracleType.VarChar).Value = landno;
            com.Parameters.Add("add1", OracleType.VarChar).Value = add1;
            com.Parameters.Add("add2", OracleType.VarChar).Value = add2;
            com.Parameters.Add("lndmrk", OracleType.VarChar).Value = lndmrk;
            com.Parameters.Add("zip", OracleType.Number).Value = zip;
            com.Parameters.Add("country", OracleType.VarChar).Value = country;
            com.Parameters.Add("pass", OracleType.VarChar).Value = pass;
            com.Parameters.Add("captcha", OracleType.VarChar).Value = captcha;
            com.Parameters.Add("subscription", OracleType.VarChar).Value = subscription;
            com.Parameters.Add("flag", OracleType.VarChar).Value = flag;
            com.Parameters.Add("gender", OracleType.VarChar).Value = gender;
            com.Parameters.Add("state", OracleType.VarChar).Value = state;
            com.Parameters.Add("city", OracleType.VarChar).Value = city;
            com.Parameters.Add("usertype", OracleType.VarChar).Value = user_type;
            int rows = com.ExecuteNonQuery();            
        }
        catch (Exception ex) { throw ex; }
        finally
        {            
            cn.Close();
        }
    }
    #endregion

    #region getcatdata
    public DataSet getcatdata()
    {
        DataSet ds = new DataSet();
        OracleConnection cn = getConnection();
        try
        {
            OracleCommand com = new OracleCommand("GET_ASTRO_CAT_DATA", cn);
            com.CommandType = CommandType.StoredProcedure;
          
            com.Parameters.Add("p_accounts", OracleType.Cursor);
            com.Parameters["p_accounts"].Direction = ParameterDirection.Output;

            int rows = com.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(com);
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex) { throw ex; }
        finally
        {
            ds.Dispose();
            cn.Close();
        }
    }
    #endregion

    #region search_astro
    public DataSet search_astro(string mail, string pass)
    {
        DataSet ds = new DataSet();
        OracleConnection cn = getConnection();
        try
        {
            OracleCommand com = new OracleCommand("search_astro", cn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("pmail", OracleType.VarChar).Value = mail;
            com.Parameters.Add("ppass", OracleType.VarChar).Value = pass;

            com.Parameters.Add("p_accounts", OracleType.Cursor);
            com.Parameters["p_accounts"].Direction = ParameterDirection.Output;

            int rows = com.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(com);
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex) { throw ex; }
        finally
        {
            ds.Dispose();
            cn.Close();
        }
    }
    #endregion

    #region CheckLogin

    public DataSet CheckLogin(string mail, string pass,string usertype,string groupid)
    {
        DataSet ds = new DataSet();
        OracleConnection cn = getConnection();
        try
        {
            OracleCommand com = new OracleCommand("ASP_CHECK_LOGIN", cn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("EMAILID", OracleType.VarChar).Value = mail;
            com.Parameters.Add("PASSWORDVAL", OracleType.VarChar).Value = pass;
            com.Parameters.Add("USERTYPE", OracleType.VarChar).Value = usertype;
            com.Parameters.Add("GROUPID", OracleType.VarChar).Value = groupid;

            com.Parameters.Add("p_out_astro", OracleType.Cursor);
            com.Parameters["p_out_astro"].Direction = ParameterDirection.Output;
            com.Parameters.Add("p_out_end", OracleType.Cursor);
            com.Parameters["p_out_end"].Direction = ParameterDirection.Output;

            int rows = com.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(com);
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex) { throw ex; }
        finally
        {
            ds.Dispose();
            cn.Close();
        }
    }
    #endregion

    #region astro_client_dtls

    public DataSet astro_client_dtls(string usermail)
    {
        DataSet ds = new DataSet();
        OracleConnection cn = getConnection();
        try
        {
            OracleCommand com = new OracleCommand("ast_search_astro_client_detail", cn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("pmail", OracleType.VarChar).Value = usermail;
            

            com.Parameters.Add("p_accounts", OracleType.Cursor);
            com.Parameters["p_accounts"].Direction = ParameterDirection.Output;


            int rows = com.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(com);
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex) { throw ex; }
        finally
        {
            ds.Dispose();
            cn.Close();
        }
    }
    #endregion

    #region check_dup_email

    public DataSet check_dup_email(string mmail)
    {
        DataSet ds = new DataSet();
        OracleConnection cn = getConnection();
        try
        {
            OracleCommand com = new OracleCommand("check_dup_email", cn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("mmail", OracleType.VarChar).Value = mmail;


            com.Parameters.Add("p_accounts", OracleType.Cursor);
            com.Parameters["p_accounts"].Direction = ParameterDirection.Output;


            int rows = com.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(com);
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex) { throw ex; }
        finally
        {
            ds.Dispose();
            cn.Close();
        }
    }
    #endregion

    #region check_cl_dupid
    public DataSet check_cl_dupid(string email, string cat_id,string astrologer)
    {
        DataSet ds = new DataSet();
        OracleConnection cn = getConnection();
        try
        {
            OracleCommand com = new OracleCommand("check_cl_dupid", cn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("email", OracleType.VarChar).Value = email;


            com.Parameters.Add("cat_id1", OracleType.VarChar).Value = cat_id;

            com.Parameters.Add("astrologerm", OracleType.VarChar).Value = astrologer;


            com.Parameters.Add("p_accounts", OracleType.Cursor);
            com.Parameters["p_accounts"].Direction = ParameterDirection.Output;


            int rows = com.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(com);
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex) { throw ex; }
        finally
        {
            ds.Dispose();
            cn.Close();
        }
    }
    #endregion

    #region bind_user1
    public DataSet bind_user1(string astrologer)
    {
        DataSet ds = new DataSet();
        OracleConnection cn = getConnection();
        try
        {
            OracleCommand com = new OracleCommand("AST_groupname_bind", cn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("pastrologer", OracleType.VarChar).Value = astrologer;

            com.Parameters.Add("p_accounts1", OracleType.Cursor);
            com.Parameters["p_accounts1"].Direction = ParameterDirection.Output;


            int rows = com.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(com);
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex) { throw ex; }
        finally
        {
            ds.Dispose();
            cn.Close();
        }
    }
    #endregion

    #region bind_category
    public DataSet bind_category(string astrologer,string grp_cat,string grp_cat_u,string clmail)
    {
        DataSet ds = new DataSet();
        OracleConnection cn = getConnection();
        try
        {
            OracleCommand com = new OracleCommand("AST_CATEGORY_BIND", cn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("pastrologer", OracleType.VarChar).Value = astrologer;

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("p_grp_cat", OracleType.VarChar).Value = grp_cat;

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("p_grp_cat_u", OracleType.VarChar).Value = grp_cat_u;

             com.CommandType = CommandType.StoredProcedure;
             com.Parameters.Add("p_clmail", OracleType.VarChar).Value = clmail; 

            com.Parameters.Add("p_accounts1", OracleType.Cursor);
            com.Parameters["p_accounts1"].Direction = ParameterDirection.Output;

            int rows = com.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(com);
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex) { throw ex; }
        finally
        {
            ds.Dispose();
            cn.Close();
        }
    }
    #endregion

    #region Get_Hora_cat
    public DataSet Get_Hora_cat()
    {
        OracleConnection cn = getConnection();
        DataSet ds = new DataSet();
        try
        {
            string str = "select distinct CODE,PRIORITY,CODE_ID,CATEGORY_DESC from horary_combination_filter order by PRIORITY ASC";
            OracleDataAdapter odt = new OracleDataAdapter(str, cn);
            odt.Fill(ds);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cn.Close();
        }
        return ds;
    }
    #endregion

    #region Get_Natal_cat
    public DataSet Get_Natal_cat(string CurrencyType)
    {
        string str = "";
        OracleConnection cn = getConnection();
        DataSet ds = new DataSet();
        try
        {
            //string str = "SELECT DISTINCT A.FINAL_CATEGERY,A.CATEGORY_IMAGE,A.PRIORITY,A.FINAL_CATID,A.CATEGORY_DESC,";
            //str += "B.PRICE_INR AS ACTUAL_PRICE,B.DISCOUNT_INR AS DISCOUNT,B.FINALPRICE_INR AS PAYABLE_PRICE";
            //str += " FROM PREDICTIVE_CATEGERY A,price_mst B WHERE A.FINAL_CATID>0 AND A.FINAL_CATID=B.CAT_ID ORDER BY A.PRIORITY ASC";

            if(CurrencyType=="USD")
            {
                str = "SELECT ROWNUM as ROW_NO, a.* FROM (SELECT A.CATEGORY_NAME,A.PRE_CATEGORY_URL,A.CATEGORY_URL,(A.PRE_CATEGORY_URL || '/' || A.CATEGORY_URL) AS URL,A.CATEGORY_IMAGE,A.PRIORITY,A.CATEGORY_ID,A.CATEGORY_DESC,";
                str += " A.IS_PAID,A.IS_ADDTOCART,A.CATEGORY_SYNOPSIS,B.PRICE_USD AS ACTUAL_PRICE,B.DISCOUNT_USD AS DISCOUNT,B.FINALPRICE_USD AS PAYABLE_PRICE , A.CATEGORY_COLOR , A.IS_BLINK";
                str += " FROM CATEGORY_MST A, PRICE_MST B WHERE A.CATEGORY_ID > 0 AND A.CATEGORY_ID = B.CAT_ID AND A.STATUS='A' ORDER BY CASE WHEN A.PRIORITY =0 THEN 100 ELSE A.PRIORITY END) a";
            }
            else {
                str = "SELECT ROWNUM as ROW_NO, a.* FROM (SELECT A.CATEGORY_NAME,A.PRE_CATEGORY_URL,A.CATEGORY_URL,(A.PRE_CATEGORY_URL || '/' || A.CATEGORY_URL) AS URL,A.CATEGORY_IMAGE,A.PRIORITY,A.CATEGORY_ID,A.CATEGORY_DESC,";
                str += " A.IS_PAID,A.IS_ADDTOCART,A.CATEGORY_SYNOPSIS,B.PRICE_INR AS ACTUAL_PRICE,B.DISCOUNT_INR AS DISCOUNT,B.FINALPRICE_INR AS PAYABLE_PRICE , A.CATEGORY_COLOR, A.IS_BLINK";
                str += " FROM CATEGORY_MST A, PRICE_MST B WHERE A.CATEGORY_ID > 0 AND A.CATEGORY_ID = B.CAT_ID AND A.STATUS='A' ORDER BY CASE WHEN A.PRIORITY =0 THEN 100 ELSE A.PRIORITY END) a";
            }
            OracleDataAdapter odt = new OracleDataAdapter(str, cn);
            odt.Fill(ds);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cn.Close();
        }
        return ds;
    }
    #endregion

    #region Get_Harary_Questions
    public DataSet Get_Harary_Questions(string code)
    {
        OracleConnection cn = getConnection();
        DataSet ds = new DataSet();
        try
        {
            string str = "select sub_code,seq as Question_id,code as Category_name from horary_combination_filter where code_id='" + code + "'";
            OracleDataAdapter od = new OracleDataAdapter(str, cn);
            od.Fill(ds);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cn.Close();
        }
        return ds;
    }
    #endregion

    #region Get_Natal_Questions
    public DataSet Get_Natal_Questions(string code)
    {
        OracleConnection cn = getConnection();
        DataSet ds = new DataSet();
        try
        {
            //string str = "select DISTINCT QUESTION,FINAL_CATEGERY as Category_name,SEQ as QUESTION_ID from predictive_categery WHERE FINAL_CATID='" + code + "'";
            string str = "select QUESTION,FINAL_CATEGERY as Category_name,MAX(SEQ) as QUESTION_ID,PRIORITY_QUES,TITLE,META_KEYWORDS,META_DESCRIPTION from predictive_categery WHERE FINAL_CATID='" + code + "' GROUP BY QUESTION,FINAL_CATEGERY,PRIORITY_QUES,TITLE,META_KEYWORDS,META_DESCRIPTION ORDER BY PRIORITY_QUES asc";
            OracleDataAdapter od = new OracleDataAdapter(str, cn);
            od.Fill(ds);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cn.Close();
        }
        return ds;
    }
    #endregion

    #region Get_Configuration
    public DataSet Get_Configuration(string con_type, string purpose)
    {
        DataSet ds = new DataSet();
        OracleConnection cn = getConnection();
        try
        {
            OracleCommand com = new OracleCommand("AST_GET_CONFIGURATION", cn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("configuration_type", OracleType.VarChar).Value = con_type;

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("purpose", OracleType.VarChar).Value = purpose;

            com.Parameters.Add("p_out", OracleType.Cursor);
            com.Parameters["p_out"].Direction = ParameterDirection.Output;

            int rows = com.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(com);
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex) { throw ex; }
        finally
        {
            ds.Dispose();
            cn.Close();
        }
    }
    #endregion

    #region Encrypt
    public static string Encrypt(string clearText)
    {
        string EncryptionKey = "NIEV2SPBNI992$2";
        byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(clearBytes, 0, clearBytes.Length);
                    cs.Close();
                }
                clearText = Convert.ToBase64String(ms.ToArray());
            }
        }
        return clearText;
    }
    #endregion

    #region Decrypt
    public static string Decrypt(string cipherText)
    {
        string EncryptionKey = "NIEV2SPBNI992$2";
        byte[] cipherBytes = Convert.FromBase64String(cipherText);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(cipherBytes, 0, cipherBytes.Length);
                    cs.Close();
                }
                cipherText = Encoding.Unicode.GetString(ms.ToArray());
            }
        }
        return cipherText;
    }
    #endregion

    #region SendMail
    public string SendMail(string FromEmailId,string ToEmailId,string CCEmailId,string BCCEmailId,string SubjectMatter,string BodyMatter)
    {
        try
        {
            MailMessage objMailMessage = new MailMessage();
            MailAddress mail = new MailAddress(FromEmailId);
            Attachment oAttachment = new Attachment("");

            objMailMessage.From = mail;
            objMailMessage.To.Add(ToEmailId);
            if (CCEmailId != "")
            {
                objMailMessage.CC.Add(CCEmailId);
            }
            if (BCCEmailId != "")
            {
                objMailMessage.Bcc.Add(BCCEmailId);
            }
            objMailMessage.IsBodyHtml = true;
            objMailMessage.Subject = SubjectMatter;
            objMailMessage.Body = BodyMatter;
            SmtpClient smtp = new SmtpClient(SMTPServer);
            //smtp.DeliveryMethod = SmtpDeliveryMethod.PickupDirectoryFromIis;
            smtp.Send(objMailMessage);
            return "SENT";
        }
        catch (Exception ex)
        {
            return "FAILED";
        }
    }
    #endregion

    #region SendMailWithLogo
    public string SendMailWithLogo(string FromEmailId, string ToEmailId, string CCEmailId, string BCCEmailId, string SubjectMatter, string BodyMatter, string SignatureLogo)
    {
        try
        {
            MailMessage objMailMessage = new MailMessage();
            MailAddress mail = new MailAddress(FromEmailId);
            objMailMessage.From = mail;
            objMailMessage.To.Add(ToEmailId);
            if (CCEmailId != "")
            {
                objMailMessage.CC.Add(CCEmailId);
            }
            if (BCCEmailId != "")
            {
                objMailMessage.Bcc.Add(BCCEmailId);
            }
            objMailMessage.IsBodyHtml = true;
            if (SignatureLogo=="Y")
            {
                //add our attachment
                Attachment imgAtt = new Attachment(HttpContext.Current.Server.MapPath("~/Image/SignatureLogo.png"));
                //give it a content id that corresponds to the src we added in the body img tag
                imgAtt.ContentId = "SignatureLogo.png";
                //add the attachment to the email
                objMailMessage.Attachments.Add(imgAtt);
                BodyMatter = BodyMatter + "<br/><a href=\"" + (HttpContext.Current.Handler as Page).ResolveUrl("" + WEBSITEDomain + "") + "\" target='_blank'><img src=\"cid:SignatureLogo.png\"></a>";
            }
            objMailMessage.Subject = SubjectMatter;
            objMailMessage.Body = BodyMatter;
            SmtpClient smtp = new SmtpClient(SMTPServer);
            //smtp.DeliveryMethod = SmtpDeliveryMethod.PickupDirectoryFromIis;
            smtp.Send(objMailMessage);
            return "SENT";
        }
        catch (Exception ex)
        {
            return "FAILED";
        }
    }
    #endregion

    #region IsValidEmailId
    public bool IsValidEmailId(string InputEmail)
    {
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Match match = regex.Match(InputEmail);
        if (match.Success)
            return true;
        else
            return false;
    }
    #endregion

    #region GetIpAddress
    public static string GetIpAddress()
    {
        string strIpAddress;
        strIpAddress = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        if (strIpAddress == null)
        {
            strIpAddress = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
        }
        return strIpAddress;
    }
    #endregion

    #region GetUserIPAddress
    public static string GetUserIPAddress()
    {
        // Gets the current context
        System.Web.HttpContext context = System.Web.HttpContext.Current;

        // Checks the HTTP_X_FORWARDED_FOR Header (which can be multiple IPs)
        string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

        //If that is not empty
        if (!string.IsNullOrEmpty(ipAddress))
        {
            // Grab the first address
            string[] addresses = ipAddress.Split(',');
            if (addresses.Length != 0)
            {
                return addresses[0];
            }
        }

        // Otherwise use the REMOTE_ADDR Header
        return context.Request.ServerVariables["REMOTE_ADDR"];
    }
    #endregion

    #region GetUserPublicIPAddress
    public static string GetUserPublicIPAddress()
    {
        var context = System.Web.HttpContext.Current;
        string ip = String.Empty;
        if (context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
            ip = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
        else if (!String.IsNullOrEmpty(context.Request.UserHostAddress))
            ip = context.Request.UserHostAddress;

        if (ip == "::1")
            ip = "127.0.0.1";

        return ip;
    }
    #endregion

    #region GenerateRandomNo
    public static string GenerateRandomNo(int length)
    {
        Random random = new Random();
        string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        StringBuilder result = new StringBuilder(length);
        for (int i = 0; i < length; i++)
        {
            result.Append(characters[random.Next(characters.Length)]);
        }
        return result.ToString();
    }
    #endregion

    #region ClearAllControls
    public static void ClearAllControls(ControlCollection ctrls)
    {
        foreach (Control ctrl in ctrls)
        {
            if (ctrl is TextBox)
                ((TextBox)ctrl).Text = string.Empty;
            else if (ctrl is DropDownList)
                ((DropDownList)ctrl).ClearSelection();
            else if (ctrl is CheckBoxList)
                ((CheckBoxList)ctrl).ClearSelection();
            else if (ctrl is RadioButtonList)
                ((RadioButtonList)ctrl).ClearSelection();
            else if (ctrl is ListBox)
                ((ListBox)ctrl).ClearSelection();
            else if (ctrl is HiddenField)
                ((HiddenField)ctrl).Value = string.Empty;
            else if (ctrl is RadioButton)
                ((RadioButton)ctrl).Checked = false;
            //else if (ctrl is CheckBox)
            //    ((CheckBox)ctrl).Checked = false;
            ClearAllControls(ctrl.Controls);
        }
    }
    #endregion

    #region Get Category Details
    public DataSet GetCategoryDetails(string Flag, string CategoryURL)
    {
        DataSet ds = new DataSet();
        OracleConnection cn = getConnection();
        try
        {
            OracleCommand com = new OracleCommand("GET_CATEGORY_DETAILS", cn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("FLAG", OracleType.VarChar).Value = Flag;

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("CATURL", OracleType.VarChar).Value = CategoryURL;

            com.Parameters.Add("outflag", OracleType.Cursor);
            com.Parameters["outflag"].Direction = ParameterDirection.Output;

            int rows = com.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(com);
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex) { throw ex; }
        finally
        {
            ds.Dispose();
            cn.Close();
        }
    }
    #endregion

    #region Get Report Details
    public DataSet GetMyReport(string Flag, string UserID , string UserEmailID , string GroupName)
    {
        DataSet ds = new DataSet();
        OracleConnection cn = getConnection();
        try
        {
            OracleCommand com = new OracleCommand("AST_GET_REPORTS", cn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("FLAG", OracleType.VarChar).Value = Flag;

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("USER_ID", OracleType.VarChar).Value = UserID;

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("USER_EMAILID", OracleType.VarChar).Value = UserEmailID;

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("GROUPNAME", OracleType.VarChar).Value = GroupName;
            
            com.Parameters.Add("p_out1", OracleType.Cursor);
            com.Parameters["p_out1"].Direction = ParameterDirection.Output;

            int rows = com.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(com);
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex) { throw ex; }
        finally
        {
            ds.Dispose();
            cn.Close();
        }
    }
    #endregion

    #region Remove Duplicate Records
    public static  DataTable RemoveRecord(DataTable dts, string ColumName)
    {
        DataTable dt = dts;
        dt = dt.DefaultView.ToTable(true, ColumName);
        return dt;
    }
    #endregion
    
    #region Get Report Details
    public DataSet GetDashboardDetails(string Flag)
    {
        DataSet ds = new DataSet();
        OracleConnection cn = getConnection();
        try
        {
            OracleCommand com = new OracleCommand("AST_DASHBOARD_SUMMARY", cn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("FLAG", OracleType.VarChar).Value = Flag;

            com.Parameters.Add("OUTFLAG", OracleType.Cursor);
            com.Parameters["OUTFLAG"].Direction = ParameterDirection.Output;

            int rows = com.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(com);
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex) { throw ex; }
        finally
        {
            ds.Dispose();
            cn.Close();
        }
    }
    #endregion

    #region  Get Bhakoot Type
    public DataSet GetBhakootType()
    {
        string str = "";
        OracleConnection cn = getConnection();
        DataSet ds = new DataSet();
        try
        {
            str = "select distinct BHAKOOT_TYPE from ASHTAKOOT_BHAKOOT";
            OracleDataAdapter odt = new OracleDataAdapter(str, cn);
            odt.Fill(ds);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cn.Close();
        }
        return ds;
    }
    #endregion

    #region  Get Constellation
    public DataSet GetConstellation()
    {
        string str = "";
        OracleConnection cn = getConnection();
        DataSet ds = new DataSet();
        try
        {
            str = "select NAME from CONSTELLATION";
            OracleDataAdapter odt = new OracleDataAdapter(str, cn);
            odt.Fill(ds);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cn.Close();
        }
        return ds;
    }
    #endregion


    #region Bind Natal Categories
    public DataSet Bind_Natal_Category()
    {
        string str = "";
        OracleConnection cn = getConnection();
        DataSet ds = new DataSet();
        try
        {
            str = "SELECT CATEGORY_ID,CATEGORY_NAME,CONCAT(CONCAT(CATEGORY_ID,' - '),CATEGORY_NAME) AS CATEGORY_NAME_ID ";
            str += " FROM CATEGORY_MST WHERE STATUS='A' ORDER BY CASE WHEN PRIORITY =0 THEN 100 ELSE PRIORITY END";
            OracleDataAdapter odt = new OracleDataAdapter(str, cn);
            odt.Fill(ds);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            cn.Close();
        }
        return ds;
    }
    #endregion
}
