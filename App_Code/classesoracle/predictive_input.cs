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
/// <summary>
/// Summary description for predictive_input
/// </summary>
namespace ASTROLOGY.classesoracle
{
    public class predictive_input : orclconnection
    {
        public predictive_input()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public DataSet save_multipleplanetinanyhouse(string name, string book, string page, string filter, string detail,string description,string nop,string chart,string unique,string fid,string today)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_save_multiplanetinanyhouse", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_name", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = name;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = book;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = page;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = filter;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = detail;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_description", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = description;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_nop", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = nop;
                
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_chart", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = chart;

                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_unique", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = unique;

                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_fid", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = fid;

                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("p_fid", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = fid;

                orclcmd.Parameters.Add(prm11);



                OracleParameter prm12 = new OracleParameter("p_date", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = today;

                orclcmd.Parameters.Add(prm12);

               


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

        public DataSet save_planetinhouse(string house, string planet, string name, string description, string book, string page, string filter, string detail, string chart, string unique, string fid, string today)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_save_planetinhouse", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = house;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = planet;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_name", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = name;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_description", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = description;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = book;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = page;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = filter;

                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = detail;

                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_chart", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = chart;

                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_unique", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = unique;

                orclcmd.Parameters.Add(prm10);


                OracleParameter prm11 = new OracleParameter("p_fid", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = fid;

                orclcmd.Parameters.Add(prm11);


                OracleParameter prm12 = new OracleParameter("p_date", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = today;

                orclcmd.Parameters.Add(prm12);




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

        public DataSet find_entry(string planet, string house)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_fetch_planet_position", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = house;
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

        public DataSet update_findentry(string planet, string house, string filter, string filternew, string detail, string book, string page)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_update_find_entry", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = house;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                if (filter == "")
                {
                    prm3.Value = System.DBNull.Value;
                }
                else
                {
                    prm3.Value = filter;
                }
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_filter_new", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                if (filternew == "")
                {
                    prm4.Value = System.DBNull.Value;
                }
                else
                {
                    prm4.Value = filternew;
                }
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = detail;
                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = book;
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = page;
                orclcmd.Parameters.Add(prm7);

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

        public DataSet find_multiple_entry(string name)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_fetch_multiple_entry", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_name", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = name;
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

        public DataSet update_multiplefindentry(string name, string filter, string filternew, string detail, string book, string page)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_update_multipleentry", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_name", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = name;
                orclcmd.Parameters.Add(prm1);


                
                OracleParameter prm2 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                if (filter == "")
                {
                    prm2.Value = System.DBNull.Value;
                }
                else
                {
                    prm2.Value = filter;
                }
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_filter_new", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                if (filternew == "")
                {
                    prm3.Value = System.DBNull.Value;
                }
                else
                {
                    prm3.Value = filternew;
                }
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = detail;
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = book;
                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6= new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = page;
                orclcmd.Parameters.Add(prm6);

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

        public DataSet save_f2predictiveinput(string f2planet, string f2rashi, string f2book, string f2page, string f2filter, string f2detail, string f2description, string f2name,string chart,string unique,string fid,string today)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_save_planetinrashi", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = f2planet;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_rashi", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = f2rashi;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = f2book;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = f2page;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = f2filter;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = f2detail;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_description", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = f2description;

                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("p_name", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = f2name;

                orclcmd.Parameters.Add(prm8);


                OracleParameter prm9 = new OracleParameter("p_chart", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = chart;

                orclcmd.Parameters.Add(prm9);


                OracleParameter prm10 = new OracleParameter("p_unique", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = unique;

                orclcmd.Parameters.Add(prm10);


                OracleParameter prm11 = new OracleParameter("p_fid", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = fid;

                orclcmd.Parameters.Add(prm11);


                OracleParameter prm12 = new OracleParameter("p_date", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = today;

                orclcmd.Parameters.Add(prm12);



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

        public DataSet fetch_f2predictiveinput(string planet, string rashi)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_fetch_planetinrashi", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_rashi", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = rashi;
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

        public DataSet update_planetinrashi(string f2planet, string f2rashi, string f2filter, string f2filternew, string detail, string book, string page)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_update_planetinrashi", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = f2planet;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_rashi", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = f2rashi;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                if (f2filter == "")
                {
                    prm3.Value = System.DBNull.Value;
                }
                else
                {
                    prm3.Value = f2filter;
                }
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_filter_new", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                if (f2filternew == "")
                {
                    prm4.Value = System.DBNull.Value;
                }
                else
                {
                    prm4.Value = f2filternew;
                }
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = detail;
                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = book;
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = page;
                orclcmd.Parameters.Add(prm7);

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

        public DataSet save_f3predictiveinput(string f3house, string f3rashi, string f3book, string f3page, string f3filter, string f3detail, string f3description, string f3name,string chart,string unique,string fid,string today)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_save_houseinrashi", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = f3house;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_rashi", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = f3rashi;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = f3book;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = f3page;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = f3filter;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = f3detail;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_description", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = f3description;

                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("p_name", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = f3name;

                orclcmd.Parameters.Add(prm8);


                OracleParameter prm9 = new OracleParameter("p_chart", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = chart;

                orclcmd.Parameters.Add(prm9);


                OracleParameter prm10 = new OracleParameter("p_unique", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = unique;

                orclcmd.Parameters.Add(prm10);


                OracleParameter prm11 = new OracleParameter("p_fid", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = fid;

                orclcmd.Parameters.Add(prm11);


                OracleParameter prm12 = new OracleParameter("p_date", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = fid;

                orclcmd.Parameters.Add(prm12);



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

        public DataSet fetch_f3predictiveinput(string house, string rashi)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_fetch_houseinrashi", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_house", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = house;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_rashi", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = rashi;
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

        public DataSet update_houseinrashi(string f3house, string f3rashi, string f3filter, string f3filternew, string detail, string book, string page)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_update_houseinrashi", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = f3house;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_rashi", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = f3rashi;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                if (f3filter == "")
                {
                    prm3.Value = System.DBNull.Value;
                }
                else
                {
                    prm3.Value = f3filter;
                }
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_filter_new", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                if (f3filternew == "")
                {
                    prm4.Value = System.DBNull.Value;
                }
                else
                {
                    prm4.Value = f3filternew;
                }
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = detail;
                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = book;
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = page;
                orclcmd.Parameters.Add(prm7);

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

        public DataSet save_f4predictiveinput(string f4planet, string f4house, string f4rashi, string f4book, string f4page, string f4filter, string f4detail, string f4description, string f4name,string chart,string unique,string fid,string today)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_save_planetinrashiinhouse", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = f4house;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_rashi", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = f4rashi;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = f4book;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = f4page;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = f4filter;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = f4detail;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_description", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = f4description;

                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("p_name", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = f4name;

                orclcmd.Parameters.Add(prm8);


                OracleParameter prm9 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = f4planet;

                orclcmd.Parameters.Add(prm9);


                OracleParameter prm10 = new OracleParameter("p_chart", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = chart;

                orclcmd.Parameters.Add(prm10);


                OracleParameter prm11 = new OracleParameter("p_unique", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = unique;

                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("p_fid", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = fid;

                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("p_date", OracleType.VarChar, 4000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = today;

                orclcmd.Parameters.Add(prm13);


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

        public DataSet fetch_f4predictiveinput(string house, string rashi, string planet)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_fetch_planetinrashiinhouse", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_house", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = house;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_rashi", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = rashi;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = planet;
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

        public DataSet update_planetinrashiinhouse(string f4house, string f4rashi, string f4planet, string f4filter, string f4filternew, string detail, string book, string page)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_update_planetrashihouse", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = f4house;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_rashi", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = f4rashi;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                if (f4filter == "")
                {
                    prm3.Value = System.DBNull.Value;
                }
                else
                {
                    prm3.Value = f4filter;
                }
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_filter_new", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                if (f4filternew == "")
                {
                    prm4.Value = System.DBNull.Value;
                }
                else
                {
                    prm4.Value = f4filternew;
                }
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = detail;
                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = book;
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = page;
                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = f4planet;
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

        public DataSet save_f5predictiveinput(string f5planet, string f5constelation, string f5book, string f5page, string f5filter, string f5detail, string f5description, string f5name,string chart,string unique,string fid,string today)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_save_planetinconstelation", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = f5planet;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_constelation", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = f5constelation;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = f5book;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = f5page;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = f5filter;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = f5detail;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_description", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = f5description;

                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("p_name", OracleType.Clob, 60000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = f5name;

                orclcmd.Parameters.Add(prm8);


                OracleParameter prm9 = new OracleParameter("p_chart", OracleType.Clob, 60000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = chart;

                orclcmd.Parameters.Add(prm9);


                OracleParameter prm10 = new OracleParameter("p_unique", OracleType.Clob, 60000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = unique;

                orclcmd.Parameters.Add(prm10);


                OracleParameter prm11 = new OracleParameter("p_fid", OracleType.Clob, 60000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = fid;

                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("p_date", OracleType.Clob, 60000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = today;

                orclcmd.Parameters.Add(prm12);
                
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

        public DataSet fetch_f5predictiveinput(string planet, string constelation)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_fetch_planetinconstelation", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_constelation", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = constelation;
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

        public DataSet update_planetinconstelation(string f5planet, string f5constelation, string f5filter, string f5filternew, string detail, string book, string page)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_update_planetconstelation", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = f5planet;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_constelation", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = f5constelation;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                if (f5filter == "")
                {
                    prm3.Value = System.DBNull.Value;
                }
                else
                {
                    prm3.Value = f5filter;
                }
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_filter_new", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                if (f5filternew == "")
                {
                    prm4.Value = System.DBNull.Value;
                }
                else
                {
                    prm4.Value = f5filternew;
                }
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = detail;
                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = book;
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = page;
                orclcmd.Parameters.Add(prm7);


              

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

        public DataSet fetch_f9(string loh, string categery, string inhouse)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_fetch_lohinhouse", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_loh", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = loh;
                cmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_categery", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = categery;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_inhouse", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = inhouse;
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

        public DataSet update_f9_updatevalue(string loh, string categery, string inhouse, string filter, string filternew, string detail, string book, string page)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_update_lohinhouse", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_loh", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = loh;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_categery", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = categery;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_inhouse", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = inhouse;
                orclcmd.Parameters.Add(prm3);



                OracleParameter prm4 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                if (filter == "")
                {
                    prm4.Value = System.DBNull.Value;
                }
                else
                {
                    prm4.Value = filter;
                }
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_filter_new", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                if (filternew == "")
                {
                    prm5.Value = System.DBNull.Value;
                }
                else
                {
                    prm5.Value = filternew;
                }
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = detail;
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = book;
                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = page;
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

        public DataSet save_f10with(string name, string book, string page, string filter, string detail, string description, string nop, string comb,string chart,string unique,string fid,string today)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_save_lordwithlord", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_name", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = name;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = book;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = page;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = filter;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = detail;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_description", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = description;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_nop", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = nop;

                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("p_comb", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = comb;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_chart", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = chart;

                orclcmd.Parameters.Add(prm9);


                OracleParameter prm10 = new OracleParameter("p_unique", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = unique;
                orclcmd.Parameters.Add(prm10);


                OracleParameter prm11 = new OracleParameter("p_fid", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = fid;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("p_date", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = today;
                orclcmd.Parameters.Add(prm12);

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

        public DataSet f10_execute_withlord(string comb)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_fetch_withlord", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_comb", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = comb;
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

        public DataSet f10_update_withlord(string comb, string filter, string filternew, string detail, string book, string page)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_update_withlord", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_comb", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = comb;
                orclcmd.Parameters.Add(prm1);



                OracleParameter prm2 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                if (filter == "")
                {
                    prm2.Value = System.DBNull.Value;
                }
                else
                {
                    prm2.Value = filter;
                }
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_filter_new", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                if (filternew == "")
                {
                    prm3.Value = System.DBNull.Value;
                }
                else
                {
                    prm3.Value = filternew;
                }
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = detail;
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = book;
                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = page;
                orclcmd.Parameters.Add(prm6);

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

        public DataSet fetch_f12(string planet, string categery, string aspecthouse)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_fetch_planetaspecthouse", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                cmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_categery", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = categery;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_aspecthouse", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = aspecthouse;
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

        public DataSet update_f12_updatevalue(string planet, string categery, string aspectshouse, string filter, string filternew, string detail, string book, string page)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_update_planetaspecthouse", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_categery", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = categery;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_aspectshouse", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = aspectshouse;
                orclcmd.Parameters.Add(prm3);



                OracleParameter prm4 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                if (filter == "")
                {
                    prm4.Value = System.DBNull.Value;
                }
                else
                {
                    prm4.Value = filter;
                }
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_filter_new", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                if (filternew == "")
                {
                    prm5.Value = System.DBNull.Value;
                }
                else
                {
                    prm5.Value = filternew;
                }
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = detail;
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = book;
                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = page;
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

        public DataSet fetch_f13(string f13planet, string f13house, string f13aplanet)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_fetch_planetaspectbyplanet", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = f13planet;
                cmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = f13house;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_aplanet", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = f13aplanet;
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

        public DataSet update_f13_updatevalue(string planet, string house, string aplanet, string filter, string filternew, string detail, string book, string page)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_update_planetaspectplanet", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = house;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_aplanet", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = aplanet;
                orclcmd.Parameters.Add(prm3);



                OracleParameter prm4 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                if (filter == "")
                {
                    prm4.Value = System.DBNull.Value;
                }
                else
                {
                    prm4.Value = filter;
                }
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_filter_new", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                if (filternew == "")
                {
                    prm5.Value = System.DBNull.Value;
                }
                else
                {
                    prm5.Value = filternew;
                }
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = detail;
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = book;
                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = page;
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

        public DataSet fetch_f14(string f14planet, string f14house, string f14aplanet)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_fetch_planetaspbenimalific", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = f14planet;
                cmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = f14house;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_aplanet", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = f14aplanet;
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

        public DataSet update_f14_updatevalue(string planet, string house, string aplanet, string filter, string filternew, string detail, string book, string page)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_update_planetaspbenmalfic", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = house;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_aplanet", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = aplanet;
                orclcmd.Parameters.Add(prm3);



                OracleParameter prm4 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                if (filter == "")
                {
                    prm4.Value = System.DBNull.Value;
                }
                else
                {
                    prm4.Value = filter;
                }
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_filter_new", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                if (filternew == "")
                {
                    prm5.Value = System.DBNull.Value;
                }
                else
                {
                    prm5.Value = filternew;
                }
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = detail;
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = book;
                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = page;
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

        public DataSet fetch_f15(string f15planet, string f15house, string f15aplanet)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_fetch_planetfromplanet", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = f15planet;
                cmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = f15house;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_aplanet", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = f15aplanet;
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

        public DataSet update_f15_updatevalue(string planet, string house, string aplanet, string filter, string filternew, string detail, string book, string page)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_update_planetfromplanet", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = house;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_aplanet", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = aplanet;
                orclcmd.Parameters.Add(prm3);



                OracleParameter prm4 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                if (filter == "")
                {
                    prm4.Value = System.DBNull.Value;
                }
                else
                {
                    prm4.Value = filter;
                }
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_filter_new", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                if (filternew == "")
                {
                    prm5.Value = System.DBNull.Value;
                }
                else
                {
                    prm5.Value = filternew;
                }
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = detail;
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = book;
                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = page;
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

      
       

        public DataSet fetchf_f16(string f16planet, string f16aplanet)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_fetch_planetaspbyplanet", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = f16planet;
                cmd.Parameters.Add(prm1);



                OracleParameter prm2 = new OracleParameter("p_aplanet", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = f16aplanet;
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

        public DataSet update_f16_updatevalue(string planet, string aplanet, string filter, string filternew, string detail, string book, string page)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_update_planetaspplanet", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                orclcmd.Parameters.Add(prm1);


              
                OracleParameter prm2 = new OracleParameter("p_aplanet", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = aplanet;
                orclcmd.Parameters.Add(prm2);



                OracleParameter prm3 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                if (filter == "")
                {
                    prm3.Value = System.DBNull.Value;
                }
                else
                {
                    prm3.Value = filter;
                }
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_filter_new", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                if (filternew == "")
                {
                    prm4.Value = System.DBNull.Value;
                }
                else
                {
                    prm4.Value = filternew;
                }
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = detail;
                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = book;
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = page;
                orclcmd.Parameters.Add(prm7);

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

        public DataSet ast_nakshatras(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_NAKSHATRAS_bind", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;



                orclcmd.Parameters.Add("p_accounts", OracleType.Cursor);
                orclcmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

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

        public DataSet houseincons(string f18planet, string f18house, string f18cons)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_fetch_constellation_rashi", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = f18planet;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = f18house;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_cons", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = f18cons;
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

        public DataSet savehouseincons(string planet, string house, string cons, string book, string page, string filter, string rashi, string charan, string lfrom, string lto, string detail, string desc,string chart,string unique,string fid,string today)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_save_houseincons", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = house;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_cons", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = cons;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = book;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = page;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = filter;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_rashi", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = rashi;

                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("p_charan", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = charan;

                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_lfrom", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = lfrom;

                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_lto", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = lto;

                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = detail;

                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("p_desc", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = desc;

                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("p_chart", OracleType.VarChar, 4000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = chart;

                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("p_unique", OracleType.VarChar, 4000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = unique;

                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("p_fid", OracleType.VarChar, 4000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = fid;

                orclcmd.Parameters.Add(prm15);


                OracleParameter prm16 = new OracleParameter("p_date", OracleType.VarChar, 4000);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = today;

                orclcmd.Parameters.Add(prm16);



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

        public DataSet fetch_f18(string planet, string house, string cons)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_fetch_houseinconstellation", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                cmd.Parameters.Add(prm1);



                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = house;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_cons", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = cons;
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

        public DataSet update_f18_updatevalue(string planet, string house, string cons, string filter, string filternew, string detail, string book, string page)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_update_houseconstellation", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                orclcmd.Parameters.Add(prm1);



                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = house;
                orclcmd.Parameters.Add(prm2);



                OracleParameter prm3 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                if (filter == "")
                {
                    prm3.Value = System.DBNull.Value;
                }
                else
                {
                    prm3.Value = filter;
                }
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_filter_new", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                if (filternew == "")
                {
                    prm4.Value = System.DBNull.Value;
                }
                else
                {
                    prm4.Value = filternew;
                }
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = detail;
                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = book;
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = page;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_cons", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = cons;
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

        public DataSet houseincharanincons(string f19planet, string f19house, string f19cons, string f19charan)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_constellation_charan", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = f19planet;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = f19house;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_cons", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = f19cons;
                cmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("p_charan", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = f19charan;
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

        public DataSet houseinedm(string loh, string house, string categery, string lagnarashi, string rashi, string planet, string lfrom, string lto, string book, string page, string filter, string detail, string desc,string chart,string unique,string fid,string today)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_save_edm", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_loh", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = loh;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = house;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_categery", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = categery;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_lagnarashi", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = lagnarashi;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_rashi", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = rashi;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = planet;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_lfrom", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = lfrom;

                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("p_lto", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = lto;

                orclcmd.Parameters.Add(prm8);

               

                OracleParameter prm9 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = book;

                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = page;

                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = filter;

                orclcmd.Parameters.Add(prm11);


                OracleParameter prm12 = new OracleParameter("p_detail", OracleType.Clob, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = detail;

                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("p_desc", OracleType.VarChar, 4000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = desc;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("p_chart", OracleType.VarChar, 4000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = chart;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("p_unique", OracleType.VarChar, 4000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = unique;

                orclcmd.Parameters.Add(prm15);


                OracleParameter prm16 = new OracleParameter("p_fid", OracleType.VarChar, 4000);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = fid;

                orclcmd.Parameters.Add(prm16);


                OracleParameter prm17= new OracleParameter("p_date", OracleType.VarChar, 4000);
                prm17.Direction = ParameterDirection.Input;
                prm17.Value = today;

                orclcmd.Parameters.Add(prm17);


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

        public DataSet fetch_f17(string loh, string house, string categery)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_fetch_houseinedm", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_loh", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = loh;
                cmd.Parameters.Add(prm1);



                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = house;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_categery", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = categery;
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

        public DataSet update_f17_updatevalue(string loh, string house, string categery, string filter, string filternew, string detail, string book, string page)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_update_houseinedm", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_loh", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = loh;
                orclcmd.Parameters.Add(prm1);



                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = house;
                orclcmd.Parameters.Add(prm2);



                OracleParameter prm3 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                if (filter == "")
                {
                    prm3.Value = System.DBNull.Value;
                }
                else
                {
                    prm3.Value = filter;
                }
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_filter_new", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                if (filternew == "")
                {
                    prm4.Value = System.DBNull.Value;
                }
                else
                {
                    prm4.Value = filternew;
                }
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = detail;
                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = book;
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = page;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_categery", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = categery;
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

        public DataSet planetinquadraped(string qplanet)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_PLANET_QUADRAPED", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_qplanet_code", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = qplanet;
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

        public DataSet savequadraped(string qplanet, string qrashi, string desc1, string detail, string book, string page, string combination, string filter,string nop,string chart,string unique,string fid,string today)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_save_planetinquadraped", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_qplanet", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = qplanet;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_qrashi", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = qrashi;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_desc1", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = desc1;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_detail", OracleType.Clob, 64000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = detail;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = book;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = page;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_combination", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = combination;

                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = filter;

                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_nop", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = nop;

                orclcmd.Parameters.Add(prm9);


                OracleParameter prm10 = new OracleParameter("p_chart", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = chart;

                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("p_unique", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = unique;

                orclcmd.Parameters.Add(prm11);


                OracleParameter prm12 = new OracleParameter("p_fid", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = fid;

                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("p_date", OracleType.VarChar, 4000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = today;

                orclcmd.Parameters.Add(prm13);

                

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

        public DataSet fetch_f20(string qplanet)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_fetch_planetinquadraped", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_qplanet", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = qplanet;
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

        public DataSet update_f20_updatevalue(string qplanet, string filter, string filternew, string detail, string book, string page)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_update_planetinquadraped", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_qplanet", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = qplanet;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm3 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                if (filter == "")
                {
                    prm3.Value = System.DBNull.Value;
                }
                else
                {
                    prm3.Value = filter;
                }
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_filter_new", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                if (filternew == "")
                {
                    prm4.Value = System.DBNull.Value;
                }
                else
                {
                    prm4.Value = filternew;
                }
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_detail", OracleType.Clob, 60000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = detail;
                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = book;
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = page;
                orclcmd.Parameters.Add(prm7);

             

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

        public DataSet planetinwatery(string house)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_PLANET_WATERY", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_house_code", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = house;
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

        public DataSet savewatery(string house, string wrashi, string planet, string ahouse, string book, string page, string filter, string detail, string desc,string name,string chart,string unique,string fid,string today)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_save_planetinwatery", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = house;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_wrashi", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = wrashi;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = planet;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_ahouse", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ahouse;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = book;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = page;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = filter;

                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("p_detail", OracleType.Clob, 64000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = detail;

                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_desc", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = desc;

                orclcmd.Parameters.Add(prm9);


                OracleParameter prm10 = new OracleParameter("p_name", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = name;

                orclcmd.Parameters.Add(prm10);


                OracleParameter prm11 = new OracleParameter("p_chart", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = chart;

                orclcmd.Parameters.Add(prm11);


                OracleParameter prm12 = new OracleParameter("p_unique", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = unique;

                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("p_fid", OracleType.VarChar, 4000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = fid;

                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("p_fid", OracleType.VarChar, 4000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value =today;

                orclcmd.Parameters.Add(prm14);



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

        public DataSet f24lohhouse(string loh1, string house1, string planet, string house, string loh2, string house2)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_loh_planet_loh_inhouse", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_loh1", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = loh1;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_house1", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = house1;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = planet;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = house;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_loh2", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = loh2;
                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_house2", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = house2;
                cmd.Parameters.Add(prm6);




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

        public DataSet lordwithplanetwithmalifics(string lagnarashi, string lordofhouse, string lord, string house, string rashi, string combination, string book, string page, string filter, string detail, string description, string nop,string chart,string unique,string fid,string today)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_save_lordplanetmalifics", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_lagnarashi", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = lagnarashi;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_lordofhouse", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = lordofhouse;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_lord", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = lord;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = house;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_rashi", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = rashi;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_combination", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = combination;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = book;

                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = page;

                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = filter;

                orclcmd.Parameters.Add(prm9);


                OracleParameter prm10 = new OracleParameter("p_detail", OracleType.Clob, 64000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = detail;

                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("p_description", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = description;

                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("p_nop", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = nop;

                orclcmd.Parameters.Add(prm12);


                OracleParameter prm13 = new OracleParameter("p_chart", OracleType.VarChar, 4000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = chart;

                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("p_unique", OracleType.VarChar, 4000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = unique;

                orclcmd.Parameters.Add(prm14);


                OracleParameter prm15 = new OracleParameter("p_fid", OracleType.VarChar, 4000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = fid;

                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("p_date", OracleType.VarChar, 4000);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value =today;

                orclcmd.Parameters.Add(prm16);




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

        public DataSet f26lohaspbenmal(string lordofhouse, string benmal)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_lord_aspectby_BENMAL", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_house_code", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = lordofhouse;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_benmal", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = benmal;
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

        public DataSet f27lohaspdis(string loh1, string loh2)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_lord_asp_dispositorplanet", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_loh1", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = loh1;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_loh2", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = loh2;
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

        public DataSet f28lohwithbenmal(string loh, string benmal, string sign)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_lord_ben_watery", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_house_code1", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = loh;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_benmal", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = benmal;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_sign", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = sign;
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

        public DataSet lordofhousefromplanet(string loh, string house, string planet)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_lordfromplanet", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_loh", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = loh;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_house_code1", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = house;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_fromplanet", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = planet;
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


        public DataSet planethouselord(string planet, string house, string loh)
        {


            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_planetfromloh", ref con);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter prm1 = new OracleParameter("p_planets", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planet;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_house_code1", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = house;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_fromloh", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = loh;
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



        
      
    }
}
    






