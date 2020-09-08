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
namespace ASTROLOGY.classesoracle
{

/// <summary>
/// Summary description for myaccount
/// </summary>
public class myaccount : orclconnection
{
	public myaccount()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataSet bind_user(string astrologer,string cat_grp)
    {
        OracleConnection con;
        OracleCommand cmd;
        con = GetConnection();
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            con.Open();
            cmd = GetCommand("AST_myaccount_bind", ref con);
            cmd.CommandType = CommandType.StoredProcedure;


            OracleParameter prm1 = new OracleParameter("pastrologer", OracleType.VarChar, 2000);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = astrologer;
            cmd.Parameters.Add(prm1);

            OracleParameter prm2 = new OracleParameter("p_cat_grp", OracleType.VarChar, 2000);
            prm2.Direction = ParameterDirection.Input;
            prm2.Value = cat_grp;
            cmd.Parameters.Add(prm2);


            cmd.Parameters.Add("p_accounts", OracleType.Cursor);
            cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;


            cmd.Parameters.Add("p_accounts1", OracleType.Cursor);
            cmd.Parameters["p_accounts1"].Direction = ParameterDirection.Output;


            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            CloseConnection(ref con);
        }
 
    
    }
    public DataSet update_client(string astro_dtls, string name, string profession, string age, string sex, string p, string email, string cat_id, string mno,string groupu)
    {

        OracleConnection con;
        OracleCommand cmd;
        con = GetConnection();
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            con.Open();
            cmd = GetCommand("ast_update_clientdtls", ref con);
            cmd.CommandType = CommandType.StoredProcedure;


            OracleParameter prm1 = new OracleParameter("pcname", OracleType.VarChar, 2000);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = name;
            cmd.Parameters.Add(prm1);


            OracleParameter prm2 = new OracleParameter("pprof", OracleType.VarChar, 2000);
            prm2.Direction = ParameterDirection.Input;
            prm2.Value = profession;
            cmd.Parameters.Add(prm2);

          
            OracleParameter prm4 = new OracleParameter("pgender", OracleType.VarChar, 2000);
            prm4.Direction = ParameterDirection.Input;
            prm4.Value = sex;
            cmd.Parameters.Add(prm4);


            OracleParameter prm5 = new OracleParameter("pmail", OracleType.VarChar, 2000);
            prm5.Direction = ParameterDirection.Input;
            prm5.Value = p;
            cmd.Parameters.Add(prm5);


            OracleParameter prm6 = new OracleParameter("paname", OracleType.VarChar, 2000);
            prm6.Direction = ParameterDirection.Input;
            prm6.Value = astro_dtls;
            cmd.Parameters.Add(prm6);


            OracleParameter prm7 = new OracleParameter("pcmail", OracleType.VarChar, 2000);
            prm7.Direction = ParameterDirection.Input;
            prm7.Value = email;
            cmd.Parameters.Add(prm7);


            OracleParameter prm8 = new OracleParameter("pgroup", OracleType.VarChar, 2000);
            prm8.Direction = ParameterDirection.Input;
            prm8.Value = cat_id;
            cmd.Parameters.Add(prm8);


            OracleParameter prm9 = new OracleParameter("pmobile", OracleType.Number);
            prm9.Direction = ParameterDirection.Input;
            prm9.Value = mno;
            cmd.Parameters.Add(prm9);

            OracleParameter prm10 = new OracleParameter("pgroupu", OracleType.VarChar, 2000);
            prm10.Direction = ParameterDirection.Input;
            prm10.Value = groupu;
            cmd.Parameters.Add(prm10);


            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            CloseConnection(ref con);
        }

           
    }
    public DataSet getdinratman(string sunset, string sunrise, string sunrisenextday, string tob, string user, string hora_name, string hora_part, string dayofweek)
    {
        OracleConnection con;
        OracleCommand cmd;
        con = GetConnection();
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            con.Open();
            cmd = GetCommand("AST_GETDINRATMAN", ref con);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter prm1 = new OracleParameter("vsunset", OracleType.VarChar, 2000);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = Convert.ToDateTime(sunset).ToString("yyyy-MM-dd HH:mm:ss"); ;
            cmd.Parameters.Add(prm1);


            OracleParameter prm2 = new OracleParameter("vsunrise", OracleType.VarChar, 2000);
            prm2.Direction = ParameterDirection.Input;
            prm2.Value = Convert.ToDateTime(sunrise).ToString("yyyy-MM-dd HH:mm:ss"); ;
            cmd.Parameters.Add(prm2);


            OracleParameter prm4 = new OracleParameter("vsunrisenextday", OracleType.VarChar, 2000);
            prm4.Direction = ParameterDirection.Input;
            prm4.Value = Convert.ToDateTime(sunrisenextday).ToString("yyyy-MM-dd HH:mm:ss");
            cmd.Parameters.Add(prm4);

            OracleParameter prm5 = new OracleParameter("vtob", OracleType.VarChar, 2000);
            prm5.Direction = ParameterDirection.Input;
            prm5.Value = Convert.ToDateTime(tob).ToString("yyyy-MM-dd HH:mm:ss");
            cmd.Parameters.Add(prm5);

            OracleParameter prm6 = new OracleParameter("vuser", OracleType.VarChar, 2000);
            prm6.Direction = ParameterDirection.Input;
            prm6.Value = user;
            cmd.Parameters.Add(prm6);

            OracleParameter prm7 = new OracleParameter("vhoraname", OracleType.VarChar, 2000);
            prm7.Direction = ParameterDirection.Input;
            prm7.Value = hora_name;
            cmd.Parameters.Add(prm7);

            OracleParameter prm8 = new OracleParameter("vhorapart", OracleType.VarChar, 2000);
            prm8.Direction = ParameterDirection.Input;
            prm8.Value = hora_part;
            cmd.Parameters.Add(prm8);

            OracleParameter prm9 = new OracleParameter("dayofbirth", OracleType.VarChar, 2000);
            prm9.Direction = ParameterDirection.Input;
            prm9.Value = dayofweek;
            cmd.Parameters.Add(prm9);

            cmd.Parameters.Add("p_accounts", OracleType.Cursor);
            cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;
            //cmd.Parameters.Add("p_accounts1", OracleType.Cursor);
            //cmd.Parameters["p_accounts1"].Direction = ParameterDirection.Output;
            //cmd.Parameters.Add("p_accounts2", OracleType.Cursor);
            //cmd.Parameters["p_accounts2"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("p_accounts3", OracleType.Cursor);
            cmd.Parameters["p_accounts3"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("p_accounts4", OracleType.Cursor);
            cmd.Parameters["p_accounts4"].Direction = ParameterDirection.Output;
           

            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            CloseConnection(ref con);
        }


    }
    public DataSet insert_astro_client_dtls(string astro_dtls, string name, string email, string profession, string age, string sex, string cat_id, string p_mail, string p_captcha, string mno, string cat_grp)
    {
        OracleConnection con;
        OracleCommand cmd;
        con = GetConnection();
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            con.Open();
            cmd = GetCommand("ins_astro_cl_dtls", ref con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            OracleParameter prm1 = new OracleParameter("astro_dtls", OracleType.VarChar, 2000);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = astro_dtls;
            cmd.Parameters.Add(prm1);

            OracleParameter prm2 = new OracleParameter("name", OracleType.VarChar, 2000);
            prm2.Direction = ParameterDirection.Input;
            prm2.Value = name;
            cmd.Parameters.Add(prm2);

            OracleParameter prm3 = new OracleParameter("email", OracleType.VarChar, 2000);
            prm3.Direction = ParameterDirection.Input;
            prm3.Value = email;
            cmd.Parameters.Add(prm3);

            OracleParameter prm4 = new OracleParameter("profession", OracleType.VarChar, 2000);
            prm4.Direction = ParameterDirection.Input;
            prm4.Value = profession;
            cmd.Parameters.Add(prm4);

            OracleParameter prm5 = new OracleParameter("age", OracleType.VarChar, 2000);
            prm5.Direction = ParameterDirection.Input;
            prm5.Value = age;
            cmd.Parameters.Add(prm5);

            OracleParameter prm6 = new OracleParameter("sex", OracleType.VarChar, 2000);
            prm6.Direction = ParameterDirection.Input;
            prm6.Value = sex;
            cmd.Parameters.Add(prm6);

            OracleParameter prm7 = new OracleParameter("cat_id", OracleType.VarChar, 2000);
            prm7.Direction = ParameterDirection.Input;
            prm7.Value = cat_id;
            cmd.Parameters.Add(prm7);

            OracleParameter prm8 = new OracleParameter("p_mail", OracleType.VarChar, 2000);
            prm8.Direction = ParameterDirection.Input;
            prm8.Value = p_mail;
            cmd.Parameters.Add(prm8);

            OracleParameter prm9 = new OracleParameter("p_captcha", OracleType.VarChar, 2000);
            prm9.Direction = ParameterDirection.Input;
            prm9.Value = p_captcha;
            cmd.Parameters.Add(prm9);

            OracleParameter prm10 = new OracleParameter("p_mno", OracleType.VarChar, 2000);
            prm10.Direction = ParameterDirection.Input;
            prm10.Value = p_captcha;
            cmd.Parameters.Add(prm10);

            OracleParameter prm11 = new OracleParameter("p_cat_grp", OracleType.VarChar, 2000);
            prm11.Direction = ParameterDirection.Input;
            prm11.Value = cat_grp;
            cmd.Parameters.Add(prm11);

            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            CloseConnection(ref con);
        }
    }

    public DataSet insert_astro_client_cstudy(string cat_id, string cl_name, string cl_mail, string p_mail, string study, string group, string groupu)
    {
        OracleConnection con;
        OracleCommand cmd;
        con = GetConnection();
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            con.Open();
            cmd = GetCommand("INS_ASTRO_CL_study", ref con);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter prm1 = new OracleParameter("cat_id", OracleType.VarChar, 2000);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = cat_id;
            cmd.Parameters.Add(prm1);

            OracleParameter prm2 = new OracleParameter("cl_name", OracleType.VarChar, 2000);
            prm2.Direction = ParameterDirection.Input;
            prm2.Value = cl_name;
            cmd.Parameters.Add(prm2);

            OracleParameter prm3 = new OracleParameter("cl_mail", OracleType.VarChar, 2000);
            prm3.Direction = ParameterDirection.Input;
            prm3.Value = cl_mail;
            cmd.Parameters.Add(prm3);

            OracleParameter prm4 = new OracleParameter("p_mail", OracleType.VarChar, 2000);
            prm4.Direction = ParameterDirection.Input;
            prm4.Value = p_mail;
            cmd.Parameters.Add(prm4);

            OracleParameter prm5 = new OracleParameter("study", OracleType.VarChar, 2000);
            prm5.Direction = ParameterDirection.Input;
            prm5.Value = study;
            cmd.Parameters.Add(prm5);

            OracleParameter prm6 = new OracleParameter("p_group", OracleType.VarChar, 2000);
            prm6.Direction = ParameterDirection.Input;
            prm6.Value = group;
            cmd.Parameters.Add(prm6);

            OracleParameter prm7 = new OracleParameter("p_groupu", OracleType.VarChar, 2000);
            prm7.Direction = ParameterDirection.Input;
            prm7.Value = groupu;
            cmd.Parameters.Add(prm7);
            
            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            CloseConnection(ref con);
        }
    }

    public DataSet update_astro_client_cstudy(string cat_id, string cl_name, string cl_mail, string p_mail, string study, string group, string gropu)
    {
        OracleConnection con;
        OracleCommand cmd;
        con = GetConnection();
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            con.Open();
            cmd = GetCommand("UPD_ASTRO_CL_study", ref con);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter prm1 = new OracleParameter("p_cat_id", OracleType.VarChar, 2000);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = cat_id;
            cmd.Parameters.Add(prm1);

            OracleParameter prm2 = new OracleParameter("cl_name", OracleType.VarChar, 2000);
            prm2.Direction = ParameterDirection.Input;
            prm2.Value = cl_name;
            cmd.Parameters.Add(prm2);

            OracleParameter prm3 = new OracleParameter("cl_mail", OracleType.VarChar, 2000);
            prm3.Direction = ParameterDirection.Input;
            prm3.Value = cl_mail;
            cmd.Parameters.Add(prm3);

            OracleParameter prm4 = new OracleParameter("p_mail", OracleType.VarChar, 2000);
            prm4.Direction = ParameterDirection.Input;
            prm4.Value = p_mail;
            cmd.Parameters.Add(prm4);

            OracleParameter prm5 = new OracleParameter("study", OracleType.VarChar, 2000);
            prm5.Direction = ParameterDirection.Input;
            prm5.Value = study;
            cmd.Parameters.Add(prm5);

            OracleParameter prm6 = new OracleParameter("pgroup", OracleType.VarChar, 2000);
            prm6.Direction = ParameterDirection.Input;
            prm6.Value = group;
            cmd.Parameters.Add(prm6);

            OracleParameter prm7 = new OracleParameter("pgropu", OracleType.VarChar, 2000);
            prm7.Direction = ParameterDirection.Input;
            prm7.Value = gropu;
            cmd.Parameters.Add(prm7);

            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            CloseConnection(ref con);
        }
    }

    public DataSet delete_astro_client_cstudy(string cat_id, string cl_name, string cl_mail, string p_mail, string group, string gropu)
    {
        OracleConnection con;
        OracleCommand cmd;
        con = GetConnection();
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            con.Open();
            cmd = GetCommand("DEL_ASTRO_CL_study", ref con);
            cmd.CommandType = CommandType.StoredProcedure;


            OracleParameter prm1 = new OracleParameter("p_cat_id", OracleType.VarChar, 2000);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = cat_id;
            cmd.Parameters.Add(prm1);


            OracleParameter prm2 = new OracleParameter("cl_name", OracleType.VarChar, 2000);
            prm2.Direction = ParameterDirection.Input;
            prm2.Value = cl_name;
            cmd.Parameters.Add(prm2);

            OracleParameter prm3 = new OracleParameter("cl_mail", OracleType.VarChar, 2000);
            prm3.Direction = ParameterDirection.Input;
            prm3.Value = cl_mail;
            cmd.Parameters.Add(prm3);

            OracleParameter prm4 = new OracleParameter("p_mail", OracleType.VarChar, 2000);
            prm4.Direction = ParameterDirection.Input;
            prm4.Value = p_mail;
            cmd.Parameters.Add(prm4);


            OracleParameter prm5 = new OracleParameter("pgroup", OracleType.VarChar, 2000);
            prm5.Direction = ParameterDirection.Input;
            prm5.Value = group;
            cmd.Parameters.Add(prm5);

            OracleParameter prm6 = new OracleParameter("pgropu", OracleType.VarChar, 2000);
            prm6.Direction = ParameterDirection.Input;
            prm6.Value = gropu;
            cmd.Parameters.Add(prm6);

            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            CloseConnection(ref con);
        }
    }
    public DataSet search_cs(string astrologer, string cat, string client,string grop,string gropu)
    {
        OracleConnection con;
        OracleCommand cmd;
        con = GetConnection();
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            con.Open();
            cmd = GetCommand("AST_SEARCH_CS", ref con);
            cmd.CommandType = CommandType.StoredProcedure;


            OracleParameter prm1 = new OracleParameter("pastro", OracleType.VarChar, 2000);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = astrologer;
            cmd.Parameters.Add(prm1);

            OracleParameter prm2 = new OracleParameter("pcat", OracleType.VarChar, 2000);
            prm2.Direction = ParameterDirection.Input;
            prm2.Value = cat;
            cmd.Parameters.Add(prm2);

            OracleParameter prm3 = new OracleParameter("pclient", OracleType.VarChar, 2000);
            prm3.Direction = ParameterDirection.Input;
            prm3.Value = client;
            cmd.Parameters.Add(prm3);


            OracleParameter prm4 = new OracleParameter("pgrop", OracleType.VarChar, 2000);
            prm4.Direction = ParameterDirection.Input;
            prm4.Value = grop;
            cmd.Parameters.Add(prm4);

            OracleParameter prm5 = new OracleParameter("pgropu", OracleType.VarChar, 2000);
            prm5.Direction = ParameterDirection.Input;
            prm5.Value = gropu;
            cmd.Parameters.Add(prm5);

            cmd.Parameters.Add("p_accounts", OracleType.Cursor);
            cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            CloseConnection(ref con);
        }
    }
    public DataSet fetchd1(string clmail, string astmail,string grop,string gropu)
    {
        OracleConnection con;
        OracleCommand cmd;
        con = GetConnection();
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            con.Open();
            cmd = GetCommand("AST_FETCH_D1", ref con);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter prm1 = new OracleParameter("pclmail", OracleType.VarChar, 2000);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = clmail;
            cmd.Parameters.Add(prm1);

            OracleParameter prm2 = new OracleParameter("pastmail", OracleType.VarChar, 2000);
            prm2.Direction = ParameterDirection.Input;
            prm2.Value = astmail;
            cmd.Parameters.Add(prm2);

            OracleParameter prm3 = new OracleParameter("pgrop", OracleType.VarChar, 2000);
            prm3.Direction = ParameterDirection.Input;
            prm3.Value = grop;
            cmd.Parameters.Add(prm3);

            OracleParameter prm4 = new OracleParameter("pgropu", OracleType.VarChar, 2000);
            prm4.Direction = ParameterDirection.Input;
            prm4.Value = gropu;
            cmd.Parameters.Add(prm4);

            cmd.Parameters.Add("p_accounts", OracleType.Cursor);
            cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            CloseConnection(ref con);
        }
    }
    public DataSet update_user(string name, string altmail, string mobno, string landno, string add1, string dd2, string country1, string zip, string pwd, string landmark, string mainmail)
    {
        OracleConnection con = GetConnection();
        OracleDataAdapter da = new OracleDataAdapter();
        DataSet ds = new DataSet();
        OracleCommand orclcmd;
        try
        {
            con.Open();
            orclcmd = GetCommand("ast_update_astrodtls", ref con);
            orclcmd.CommandType = CommandType.StoredProcedure;

            OracleParameter prm1 = new OracleParameter("pname", OracleType.VarChar, 4000);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = name;
            orclcmd.Parameters.Add(prm1);

            OracleParameter prm2 = new OracleParameter("pamail", OracleType.VarChar, 4000);
            prm2.Direction = ParameterDirection.Input;
            prm2.Value = altmail;
            orclcmd.Parameters.Add(prm2);

            OracleParameter prm3 = new OracleParameter("pmob", OracleType.VarChar, 4000);
            prm3.Direction = ParameterDirection.Input;
            prm3.Value = mobno;
            orclcmd.Parameters.Add(prm3);

            OracleParameter prm4 = new OracleParameter("pland", OracleType.VarChar, 4000);
            prm4.Direction = ParameterDirection.Input;
            prm4.Value = landno;
            orclcmd.Parameters.Add(prm4);

            OracleParameter prm5 = new OracleParameter("pad1", OracleType.VarChar, 4000);
            prm5.Direction = ParameterDirection.Input;
            prm5.Value = add1;
            orclcmd.Parameters.Add(prm5);

            OracleParameter prm6 = new OracleParameter("pad2", OracleType.VarChar, 4000);
            prm6.Direction = ParameterDirection.Input;
            prm6.Value = dd2;
            orclcmd.Parameters.Add(prm6);

            OracleParameter prm7 = new OracleParameter("pcountry", OracleType.Int16);
            prm7.Direction = ParameterDirection.Input;
            prm7.Value = country1;

            orclcmd.Parameters.Add(prm7);
            OracleParameter prm8 = new OracleParameter("pzip", OracleType.Number);
            prm8.Direction = ParameterDirection.Input;
            prm8.Value = zip;
            orclcmd.Parameters.Add(prm8);

            OracleParameter prm9 = new OracleParameter("ppass", OracleType.VarChar, 4000);
            prm9.Direction = ParameterDirection.Input;
            prm9.Value = pwd;
            orclcmd.Parameters.Add(prm9);

            OracleParameter prm10 = new OracleParameter("pmark", OracleType.VarChar, 4000);
            prm10.Direction = ParameterDirection.Input;
            prm10.Value = landmark;
            orclcmd.Parameters.Add(prm10);

            OracleParameter prm11 = new OracleParameter("pmail", OracleType.VarChar, 4000);
            prm11.Direction = ParameterDirection.Input;
            prm11.Value = mainmail;
            orclcmd.Parameters.Add(prm11);

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


    public DataSet updatelatlng(string latf, string lngf, string conco, string stateco, string city)
    {
        OracleConnection con = GetConnection();
        OracleDataAdapter da = new OracleDataAdapter();
        DataSet ds = new DataSet();
        OracleCommand orclcmd;
        try
        {
            con.Open();

            orclcmd = GetCommand("ast_latlng_update", ref con);

            orclcmd.CommandType = CommandType.StoredProcedure;


            OracleParameter prm1 = new OracleParameter("vlat", OracleType.VarChar, 4000);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = latf;
            orclcmd.Parameters.Add(prm1);


            OracleParameter prm2 = new OracleParameter("vlng", OracleType.VarChar, 4000);
            prm2.Direction = ParameterDirection.Input;
            prm2.Value = lngf;
            orclcmd.Parameters.Add(prm2);


            OracleParameter prm3 = new OracleParameter("vcc", OracleType.VarChar, 4000);
            prm3.Direction = ParameterDirection.Input;
            prm3.Value = conco;
            orclcmd.Parameters.Add(prm3);



            OracleParameter prm4 = new OracleParameter("vsc", OracleType.VarChar, 4000);
            prm4.Direction = ParameterDirection.Input;
            prm4.Value = stateco;
            orclcmd.Parameters.Add(prm4);



            OracleParameter prm5 = new OracleParameter("vcn", OracleType.VarChar, 4000);
            prm5.Direction = ParameterDirection.Input;
            prm5.Value = city;
            orclcmd.Parameters.Add(prm5);



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


   

    public DataSet update_client(string astrodetail, string clidetail, string profession, string age, string gender, string pmail, string climail,string group)
    {
        OracleConnection con = GetConnection();
        OracleDataAdapter da = new OracleDataAdapter();
        DataSet ds = new DataSet();
        OracleCommand orclcmd;
        try
        {
            con.Open();

            orclcmd = GetCommand("ast_update_clientdtls", ref con);

            orclcmd.CommandType = CommandType.StoredProcedure;

            OracleParameter prm1 = new OracleParameter("pcname", OracleType.VarChar, 4000);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = clidetail;
            orclcmd.Parameters.Add(prm1);


            OracleParameter prm2 = new OracleParameter("pprof", OracleType.VarChar, 4000);
            prm2.Direction = ParameterDirection.Input;
            prm2.Value = profession;
            orclcmd.Parameters.Add(prm2);

            OracleParameter prm3 = new OracleParameter("p_age", OracleType.Number);
            prm3.Direction = ParameterDirection.Input;
            prm3.Value = age;
            orclcmd.Parameters.Add(prm3);


            OracleParameter prm4 = new OracleParameter("pgender", OracleType.VarChar, 4000);
            prm4.Direction = ParameterDirection.Input;
            prm4.Value = gender;
            orclcmd.Parameters.Add(prm4);

            OracleParameter prm5 = new OracleParameter("pmail", OracleType.VarChar, 4000);
            prm5.Direction = ParameterDirection.Input;
            prm5.Value = pmail;
            orclcmd.Parameters.Add(prm5);

            OracleParameter prm6 = new OracleParameter("paname", OracleType.VarChar, 4000);
            prm6.Direction = ParameterDirection.Input;
            prm6.Value = astrodetail;
            orclcmd.Parameters.Add(prm6);

            OracleParameter prm7 = new OracleParameter("pcmail", OracleType.VarChar, 4000);
            prm7.Direction = ParameterDirection.Input;
            prm7.Value = climail;
            orclcmd.Parameters.Add(prm7);

            OracleParameter prm8 = new OracleParameter("pgroup", OracleType.VarChar, 4000);
            prm8.Direction = ParameterDirection.Input;
            prm8.Value = group;
            orclcmd.Parameters.Add(prm8);

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

    public DataSet bind_client(string astrologer, string grop, string gropu)
    {
        OracleConnection con;
        OracleCommand cmd;
        con = GetConnection();
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            con.Open();
            cmd = GetCommand("AST_myclient_bind", ref con);
            cmd.CommandType = CommandType.StoredProcedure;


            OracleParameter prm1 = new OracleParameter("pastrologer", OracleType.VarChar, 2000);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = astrologer;
            cmd.Parameters.Add(prm1);

            OracleParameter prm2 = new OracleParameter("pgrop", OracleType.VarChar, 2000);
            prm2.Direction = ParameterDirection.Input;
            prm2.Value = grop;
            cmd.Parameters.Add(prm2);

            OracleParameter prm3 = new OracleParameter("pgropu", OracleType.VarChar, 2000);
            prm3.Direction = ParameterDirection.Input;
            prm3.Value = gropu;
            cmd.Parameters.Add(prm3);



            cmd.Parameters.Add("p_accounts", OracleType.Cursor);
            cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;


           


            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            CloseConnection(ref con);
        }
    }


    public DataSet bind_client_by(string astrologer, string grop, string searchoption, string txtvalue,string gropu)
    {
        OracleConnection con;
        OracleCommand cmd;
        con = GetConnection();
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            con.Open();
            cmd = GetCommand("AST_myclient_by_bind", ref con);
            cmd.CommandType = CommandType.StoredProcedure;


            OracleParameter prm1 = new OracleParameter("pastrologer", OracleType.VarChar, 2000);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = astrologer;
            cmd.Parameters.Add(prm1);

            OracleParameter prm2 = new OracleParameter("pgrop", OracleType.VarChar, 2000);
            prm2.Direction = ParameterDirection.Input;
            prm2.Value = grop;
            cmd.Parameters.Add(prm2);


            OracleParameter prm3 = new OracleParameter("psearchoption", OracleType.VarChar, 2000);
            prm3.Direction = ParameterDirection.Input;
            prm3.Value = searchoption;
            cmd.Parameters.Add(prm3);

            OracleParameter prm4 = new OracleParameter("ptxtvalue", OracleType.VarChar, 2000);
            prm4.Direction = ParameterDirection.Input;
            prm4.Value = txtvalue;
            cmd.Parameters.Add(prm4);

            OracleParameter prm5 = new OracleParameter("pgropu", OracleType.VarChar, 2000);
            prm5.Direction = ParameterDirection.Input;
            prm5.Value = gropu;
            cmd.Parameters.Add(prm5);



            cmd.Parameters.Add("p_accounts", OracleType.Cursor);
            cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;





            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            CloseConnection(ref con);
        }
    }






    public DataSet bind_all_routes_ds(string astrologer, string grop, string viewcolname, string orderby,string gropu)
    {
        OracleConnection con;
        OracleCommand cmd;
        con = GetConnection();
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            con.Open();
            cmd = GetCommand("variable_order_get", ref con);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter prm1 = new OracleParameter("pastrologer", OracleType.VarChar, 2000);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = astrologer;
            cmd.Parameters.Add(prm1);

            OracleParameter prm2 = new OracleParameter("pgrop", OracleType.VarChar, 2000);
            prm2.Direction = ParameterDirection.Input;
            prm2.Value = grop;
            cmd.Parameters.Add(prm2);

            OracleParameter prm3 = new OracleParameter("pcol", OracleType.VarChar, 2000);
            prm3.Direction = ParameterDirection.Input;
            prm3.Value = viewcolname;
            cmd.Parameters.Add(prm3);

            OracleParameter prm4 = new OracleParameter("porder", OracleType.VarChar, 2000);
            prm4.Direction = ParameterDirection.Input;
            prm4.Value = orderby;
            cmd.Parameters.Add(prm4);

            OracleParameter prm5 = new OracleParameter("pgropu", OracleType.VarChar, 2000);
            prm5.Direction = ParameterDirection.Input;
            prm5.Value = gropu;
            cmd.Parameters.Add(prm5);


            cmd.Parameters.Add("p_accounts1", OracleType.Cursor);
            cmd.Parameters["p_accounts1"].Direction = ParameterDirection.Output;


        

            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            CloseConnection(ref con);
        }

    }


    public DataSet data_delete(string astrologer_id, string client_id, string flag, string group, string groupu)
    {
        OracleConnection con;
        OracleCommand cmd;
        con = GetConnection();
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            con.Open();
            cmd = GetCommand("AST_DEL_ASTRO_CLNT_DTLS", ref con);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter prm1 = new OracleParameter("p_astrologer", OracleType.VarChar, 2000);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = astrologer_id;
            cmd.Parameters.Add(prm1);

            OracleParameter prm2 = new OracleParameter("p_client", OracleType.VarChar, 2000);
            prm2.Direction = ParameterDirection.Input;
            prm2.Value = client_id;
            cmd.Parameters.Add(prm2);

            OracleParameter prm3 = new OracleParameter("p_flag", OracleType.VarChar, 2000);
            prm3.Direction = ParameterDirection.Input;
            prm3.Value = flag;
            cmd.Parameters.Add(prm3);

            OracleParameter prm4 = new OracleParameter("pgroup", OracleType.VarChar, 2000);
            prm4.Direction = ParameterDirection.Input;
            prm4.Value = group;
            cmd.Parameters.Add(prm4);

            OracleParameter prm5 = new OracleParameter("pgroupu", OracleType.VarChar, 2000);
            prm5.Direction = ParameterDirection.Input;
            prm5.Value = groupu;
            cmd.Parameters.Add(prm5);

            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            CloseConnection(ref con);
        }

    }


    public DataSet caldashap(int mdegree, int mminute, int msecond, string mrashi, int dob, int mob, int yob, int htob, int mtob, int stob, string astrologer,string dn)
    {
        OracleConnection con;
        OracleCommand cmd;
        con = GetConnection();
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            con.Open();
            cmd = GetCommand("AST_DASHA_PATTERN", ref con);
            cmd.CommandType = CommandType.StoredProcedure;


            OracleParameter prm1 = new OracleParameter("m_degree", OracleType.Number);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = mdegree;
            cmd.Parameters.Add(prm1);

            OracleParameter prm2 = new OracleParameter("m_minute", OracleType.Number);
            prm2.Direction = ParameterDirection.Input;
            prm2.Value = mminute;
            cmd.Parameters.Add(prm2);

            OracleParameter prm3 = new OracleParameter("m_second", OracleType.Number);
            prm3.Direction = ParameterDirection.Input;
            prm3.Value = msecond;
            cmd.Parameters.Add(prm3);

            OracleParameter prm4 = new OracleParameter("m_rashi", OracleType.VarChar, 2000);
            prm4.Direction = ParameterDirection.Input;
            prm4.Value = mrashi;
            cmd.Parameters.Add(prm4);

            OracleParameter prm5 = new OracleParameter("dob", OracleType.Number);
            prm5.Direction = ParameterDirection.Input;
            prm5.Value = dob;
            cmd.Parameters.Add(prm5);

            OracleParameter prm6 = new OracleParameter("mob", OracleType.Number);
            prm6.Direction = ParameterDirection.Input;
            prm6.Value = mob;
            cmd.Parameters.Add(prm6);

            OracleParameter prm7 = new OracleParameter("yob", OracleType.Number);
            prm7.Direction = ParameterDirection.Input;
            prm7.Value = yob;
            cmd.Parameters.Add(prm7);

            OracleParameter prm8 = new OracleParameter("htob", OracleType.Number);
            prm8.Direction = ParameterDirection.Input;
            prm8.Value = htob;
            cmd.Parameters.Add(prm8);

            OracleParameter prm9 = new OracleParameter("mtob", OracleType.Number);
            prm9.Direction = ParameterDirection.Input;
            prm9.Value = mtob;
            cmd.Parameters.Add(prm9);

            OracleParameter prm10 = new OracleParameter("stob", OracleType.Number);
            prm10.Direction = ParameterDirection.Input;
            prm10.Value = stob;
            cmd.Parameters.Add(prm10);


            OracleParameter prm11 = new OracleParameter("p_astro", OracleType.VarChar, 2000);
            prm11.Direction = ParameterDirection.Input;
            prm11.Value = astrologer;
            cmd.Parameters.Add(prm11);

            OracleParameter prm12 = new OracleParameter("p_dn", OracleType.VarChar, 2000);
            prm12.Direction = ParameterDirection.Input;
            prm12.Value = dn;
            cmd.Parameters.Add(prm12);


            cmd.Parameters.Add("p_accounts", OracleType.Cursor);
            cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add("p_accounts1", OracleType.Cursor);
            cmd.Parameters["p_accounts1"].Direction = ParameterDirection.Output;

            //cmd.Parameters.Add("p_accounts2", OracleType.Cursor);
            //cmd.Parameters["p_accounts2"].Direction = ParameterDirection.Output;

            //cmd.Parameters.Add("p_accounts3", OracleType.Cursor);
            //cmd.Parameters["p_accounts3"].Direction = ParameterDirection.Output;

            //cmd.Parameters.Add("p_accounts4", OracleType.Cursor);
            //cmd.Parameters["p_accounts4"].Direction = ParameterDirection.Output;


            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            CloseConnection(ref con);
        }
    }


    public DataSet caldashap_all(int mdegree, int mminute, int msecond, string mrashi, int dob, int mob, int yob, int htob, int mtob, int stob, string astrologer, string dn)
    {
        OracleConnection con;
        OracleCommand cmd;
        con = GetConnection();
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            con.Open();
            cmd = GetCommand("AST_DASHA_PATTERN_ALL", ref con);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter prm1 = new OracleParameter("m_degree", OracleType.Number);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = mdegree;
            cmd.Parameters.Add(prm1);

            OracleParameter prm2 = new OracleParameter("m_minute", OracleType.Number);
            prm2.Direction = ParameterDirection.Input;
            prm2.Value = mminute;
            cmd.Parameters.Add(prm2);

            OracleParameter prm3 = new OracleParameter("m_second", OracleType.Number);
            prm3.Direction = ParameterDirection.Input;
            prm3.Value = msecond;
            cmd.Parameters.Add(prm3);

            OracleParameter prm4 = new OracleParameter("m_rashi", OracleType.VarChar, 2000);
            prm4.Direction = ParameterDirection.Input;
            prm4.Value = mrashi;
            cmd.Parameters.Add(prm4);

            OracleParameter prm5 = new OracleParameter("dob", OracleType.Number);
            prm5.Direction = ParameterDirection.Input;
            prm5.Value = dob;
            cmd.Parameters.Add(prm5);

            OracleParameter prm6 = new OracleParameter("mob", OracleType.Number);
            prm6.Direction = ParameterDirection.Input;
            prm6.Value = mob;
            cmd.Parameters.Add(prm6);

            OracleParameter prm7 = new OracleParameter("yob", OracleType.Number);
            prm7.Direction = ParameterDirection.Input;
            prm7.Value = yob;
            cmd.Parameters.Add(prm7);

            OracleParameter prm8 = new OracleParameter("htob", OracleType.Number);
            prm8.Direction = ParameterDirection.Input;
            prm8.Value = htob;
            cmd.Parameters.Add(prm8);

            OracleParameter prm9 = new OracleParameter("mtob", OracleType.Number);
            prm9.Direction = ParameterDirection.Input;
            prm9.Value = mtob;
            cmd.Parameters.Add(prm9);

            OracleParameter prm10 = new OracleParameter("stob", OracleType.Number);
            prm10.Direction = ParameterDirection.Input;
            prm10.Value = stob;
            cmd.Parameters.Add(prm10);


            OracleParameter prm11 = new OracleParameter("p_astro", OracleType.VarChar, 2000);
            prm11.Direction = ParameterDirection.Input;
            prm11.Value = astrologer;
            cmd.Parameters.Add(prm11);

            OracleParameter prm12 = new OracleParameter("p_dn", OracleType.VarChar, 2000);
            prm12.Direction = ParameterDirection.Input;
            prm12.Value = dn;
            cmd.Parameters.Add(prm12);


            cmd.Parameters.Add("p_accounts", OracleType.Cursor);
            cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add("p_accounts1", OracleType.Cursor);
            cmd.Parameters["p_accounts1"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add("p_accounts2", OracleType.Cursor);
            cmd.Parameters["p_accounts2"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add("p_accounts3", OracleType.Cursor);
            cmd.Parameters["p_accounts3"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add("p_accounts4", OracleType.Cursor);
            cmd.Parameters["p_accounts4"].Direction = ParameterDirection.Output;


            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;

        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            CloseConnection(ref con);
        }
    }


    public DataSet Activate_registration(string Emailid)
    {
        OracleConnection con;
        OracleCommand cmd;
        con = GetConnection();
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            con.Open();
            cmd = GetCommand("AST_ACTIVE_ASTRO_DETAILS", ref con);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter prm1 = new OracleParameter("EmailId", OracleType.VarChar, 100);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = Emailid;
            cmd.Parameters.Add(prm1);

            cmd.Parameters.Add("p_accounts", OracleType.Cursor);
            cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            CloseConnection(ref con);
        }
    }

    public DataSet CheckDuplicate_registration(string Emailid)
    {
        OracleConnection con;
        OracleCommand cmd;
        con = GetConnection();
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            con.Open();
            cmd = GetCommand("AST_CHKDUPLICATE_ASTRO_DETAILS", ref con);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter prm1 = new OracleParameter("EmailId", OracleType.VarChar, 100);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = Emailid;
            cmd.Parameters.Add(prm1);

            cmd.Parameters.Add("p_accounts", OracleType.Cursor);
            cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            CloseConnection(ref con);
        }
    }


    public DataSet Update_ClientPwd(string Email, string oldpwd,string newpwd)
    {
        OracleConnection con;
        OracleCommand cmd;
        con = GetConnection();
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            con.Open();
            cmd = GetCommand("AST_UPDATEPWD_ASTRO_DETAILS", ref con);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter prm1 = new OracleParameter("Email", OracleType.VarChar, 2000);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = Email;
            cmd.Parameters.Add(prm1);

            OracleParameter prm2 = new OracleParameter("OldPwd", OracleType.VarChar, 2000);
            prm2.Direction = ParameterDirection.Input;
            prm2.Value = oldpwd;
            cmd.Parameters.Add(prm2);

            OracleParameter prm3 = new OracleParameter("NewPwd", OracleType.VarChar, 2000);
            prm3.Direction = ParameterDirection.Input;
            prm3.Value = newpwd;
            cmd.Parameters.Add(prm3);

            cmd.Parameters.Add("p_out", OracleType.Cursor);
            cmd.Parameters["p_out"].Direction = ParameterDirection.Output;

            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            CloseConnection(ref con);
        }
    }

    public DataSet GetGulikaInfo(string dayname)
    {
        OracleConnection con;
        OracleCommand cmd;
        con = GetConnection();
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            con.Open();
            cmd = GetCommand("AST_GETGULIKAINFO", ref con);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter prm1 = new OracleParameter("dayname", OracleType.VarChar, 2000);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = dayname;
            cmd.Parameters.Add(prm1);

            cmd.Parameters.Add("p_out1", OracleType.Cursor);
            cmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add("p_out2", OracleType.Cursor);
            cmd.Parameters["p_out2"].Direction = ParameterDirection.Output;

            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            CloseConnection(ref con);
        }
    }

    public DataSet GetArticles(string catid, string groupid, string newsid , string ArticleURL)
    {
        OracleConnection con;
        OracleCommand cmd;
        con = GetConnection();
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            con.Open();
            cmd = GetCommand("AST_GETARTICLES", ref con);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter prm1 = new OracleParameter("CID", OracleType.VarChar, 10);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = catid;
            cmd.Parameters.Add(prm1);

            OracleParameter prm2 = new OracleParameter("GROUPID", OracleType.VarChar, 10);
            prm2.Direction = ParameterDirection.Input;
            prm2.Value = groupid;
            cmd.Parameters.Add(prm2);

            OracleParameter prm3 = new OracleParameter("NEWSID", OracleType.VarChar, 10);
            prm3.Direction = ParameterDirection.Input;
            prm3.Value = newsid;
            cmd.Parameters.Add(prm3);

            OracleParameter prm4 = new OracleParameter("ARTICLEURL", OracleType.VarChar, 500);
            prm4.Direction = ParameterDirection.Input;
            prm4.Value = ArticleURL;
            cmd.Parameters.Add(prm4);

            cmd.Parameters.Add("p_out1", OracleType.Cursor);
            cmd.Parameters["p_out1"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add("p_out2", OracleType.Cursor);
            cmd.Parameters["p_out2"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add("p_out3", OracleType.Cursor);
            cmd.Parameters["p_out3"].Direction = ParameterDirection.Output;

            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            CloseConnection(ref con);
        }
    }

    public DataSet Get_Clientdetails(string Emailid, string clientid)
    {
        OracleConnection con;
        OracleCommand cmd;
        con = GetConnection();
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter();
        try
        {
            con.Open();
            cmd = GetCommand("AST_ASTRO_CLIENT_DETAILS", ref con);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter prm1 = new OracleParameter("EmailId", OracleType.VarChar, 100);
            prm1.Direction = ParameterDirection.Input;
            prm1.Value = Emailid;
            cmd.Parameters.Add(prm1);

            OracleParameter prm2 = new OracleParameter("UserId", OracleType.VarChar, 100);
            prm2.Direction = ParameterDirection.Input;
            prm2.Value = clientid;
            cmd.Parameters.Add(prm2);

            cmd.Parameters.Add("p_accounts", OracleType.Cursor);
            cmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            CloseConnection(ref con);
        }
    }

    
   }
}