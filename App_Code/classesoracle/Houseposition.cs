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
using ADODB;



namespace ASTROLOGY.classesoracle
{

    public class Houseposition : orclconnection
    {
        public Houseposition()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public DataSet ast_planet(string extra)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_binD.ast_planet_bind", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pextra", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = extra;
                orclcmd.Parameters.Add(prm1);

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


        public DataSet Pla_filter(string extra)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_hora_tree_view", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_under_node_id", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = extra;
                orclcmd.Parameters.Add(prm1);

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


        public DataSet ast_rashi(string extra)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_binD.ast_rashi_bind", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pextra", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = extra;
                orclcmd.Parameters.Add(prm1);

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




        public DataSet ast_house(string extra)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_binD.ast_house_bind", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pextra", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = extra;
                orclcmd.Parameters.Add(prm1);

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
        //...................for save..............................
        //..........................................
        public DataSet save(string tbl, string col, string val, string mit, string dateformat, string extra1, string extra2, string extra3, string extra4, string extra5, string extra6, string extra7, string extra8, string extra9, string extra10, string extra11, string extra12, string extra13)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("insertposition", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("casecode", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                if (tbl == "")
                {
                    prm1.Value = System.DBNull.Value;
                }
                else
                {

                    prm1.Value = tbl;
                }
                orclcmd.Parameters.Add(prm1);



                OracleParameter prm2 = new OracleParameter("casename", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;

                if (col == "")
                {
                    prm2.Value = System.DBNull.Value;
                }
                else
                {
                    prm2.Value = col;
                }
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("casehouse", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                if (val == "")
                {
                    prm3.Value = System.DBNull.Value;
                }
                else
                {
                    prm3.Value = val;
                }
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("planet1", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                if (mit == "")
                {
                    prm4.Value = System.DBNull.Value;

                }
                else
                {
                    prm4.Value = mit;
                }
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("caserashi", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                if (dateformat == "")
                {
                    prm5.Value = System.DBNull.Value;

                }
                else
                {


                    prm5.Value = dateformat;
                }
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("casedegree", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                if (extra1 == "")
                {
                    prm6.Value = System.DBNull.Value;
                }
                else
                {
                    prm6.Value = extra1;
                }
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("casedescription", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                if (extra2 == "")
                {
                    prm7.Value = System.DBNull.Value;
                }
                else
                {
                    prm7.Value = extra2;
                }
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("caseplanet", OracleType.Clob, 32000);
                prm8.Direction = ParameterDirection.Input;
                if (extra3 == "")
                {
                    prm8.Value = System.DBNull.Value;
                }
                else
                {
                    prm8.Value = extra3;
                }
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("caseascendent", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                if (extra4 == "")
                {
                    prm9.Value = System.DBNull.Value;
                }
                else
                {
                    prm9.Value = extra4;
                }
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("caseconstellation", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                if (extra5 == "")
                {
                    prm10.Value = System.DBNull.Value;
                }
                else
                {
                    prm10.Value = extra5;
                }

                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("casedegreefrom", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                if (extra6 == "")
                { prm11.Value = System.DBNull.Value; }
                else
                {
                    prm11.Value = extra6;
                }


                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("casedegreeto", OracleType.VarChar, 2000);
                prm12.Direction = ParameterDirection.Input;
                if (extra7 == "")
                {
                    prm12.Value = System.DBNull.Value;

                }
                else
                {
                    prm12.Value = extra7;
                } orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("casechart", OracleType.VarChar, 2000);
                prm13.Direction = ParameterDirection.Input;
                if (extra8 == "")
                { prm13.Value = System.DBNull.Value; }
                else { prm13.Value = extra8; }

                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("caseaspecting", OracleType.VarChar, 2000);
                prm14.Direction = ParameterDirection.Input;
                if (extra9 == "")
                {
                    prm14.Value = System.DBNull.Value;
                }
                else { prm14.Value = extra9; }

                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("casebook", OracleType.VarChar, 2000);
                prm15.Direction = ParameterDirection.Input;
                if (extra10 == "")
                {
                    prm15.Value = System.DBNull.Value;
                }
                else
                {
                    prm15.Value = extra10;
                }
                orclcmd.Parameters.Add(prm15);


                OracleParameter prm16 = new OracleParameter("casepage0", OracleType.VarChar, 2000);
                prm16.Direction = ParameterDirection.Input;
                if (extra11 == "")
                { prm16.Value = System.DBNull.Value; }
                else { prm16.Value = extra11; }

                orclcmd.Parameters.Add(prm16);

                OracleParameter prm17 = new OracleParameter("caseloh", OracleType.VarChar, 2000);
                prm17.Direction = ParameterDirection.Input;
                if (extra12 == "")
                { prm17.Value = System.DBNull.Value; }
                else { prm17.Value = extra12; }

                orclcmd.Parameters.Add(prm17);

                OracleParameter prm18 = new OracleParameter("keystring", OracleType.VarChar, 2000);
                prm18.Direction = ParameterDirection.Input;
                if (extra13 == "")
                { prm18.Value = System.DBNull.Value; }
                else { prm18.Value = extra13; }

                orclcmd.Parameters.Add(prm18);


                da.SelectCommand = orclcmd;
                da.Fill(ds);
                //orclcmd.ExecuteNonQuery();

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

        //}}
        //************************ this is for execute**********************
        //***********************************************************

        public DataSet execute(string tbl, string col, string val, string mit, string dateformat, string extra1, string extra2)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("Cir_Dynamic_DML.variable_execute_stmt", ref con);
                //orclcmd = GetCommand("Cir_Dynamic_DML.variable_insert_stmt", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("ptable_name", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = tbl;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pcond_colname", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = col;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("pcond_colval", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = val;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("pdelimiter", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = "$~$";
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("pdateformat", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = dateformat;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = extra1;
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = extra2;
                orclcmd.Parameters.Add(prm7);

                orclcmd.Parameters.Add("p_accounts", OracleType.Cursor);
                orclcmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;




                da.SelectCommand = orclcmd;
                da.Fill(ds);
                //orclcmd.ExecuteNonQuery();

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





        //******************this is for delete***************************

        public DataSet delete(string tbl, string col, string val, string dateformat, string extra1, string extra2)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try                                 //variable_delete_stmt
            {
                con.Open();

                //  orclcmd = GetCommand("Cir_Dynamic_DML.executequery(querytype", ref con);
                orclcmd = GetCommand("Cir_Dynamic_DML.variable_delete_stmt", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("ptable_name", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = tbl;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pcond_colname", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = col;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("pcond_colval", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = val;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("pdelimiter", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = "$~$";
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("pdateformat", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = dateformat;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = extra1;
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = extra2;
                orclcmd.Parameters.Add(prm7);




                da.SelectCommand = orclcmd;
                da.Fill(ds);
                //orclcmd.ExecuteNonQuery();

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

        //**********************this  is for duplicusy check*********************




        public DataSet duplicacy_chk(string tbl, string col, string val, string mit, string dateformat, string extra1, string extra2)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try                                 //variable_delete_stmt
            {
                con.Open();

                orclcmd = GetCommand("Cir_Dynamic_DML.variable_delete_stmt", ref con);
                //orclcmd = GetCommand("Cir_Dynamic_DML.variable_insert_stmt", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("ptable_name", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = tbl;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pcond_colname", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = col;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("pcond_colval", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = val;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("pdelimiter", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = "$~$";
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("pdateformat", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = dateformat;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = extra1;
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = extra2;
                orclcmd.Parameters.Add(prm7);

                orclcmd.Parameters.Add("p_accounts", OracleType.Cursor);
                orclcmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;




                da.SelectCommand = orclcmd;
                da.Fill(ds);
                //orclcmd.ExecuteNonQuery();

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

        //************************* this is for Modify_data***********************

        public DataSet Modify_data(string tbl, string col, string val, string mit, string dateformat, string extra1, string extra2)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("Cir_Dynamic_DML.variable_update_stmt", ref con);
                //orclcmd = GetCommand("Cir_Dynamic_DML.variable_insert_stmt", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("ptable_name", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = tbl;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pcolname", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = col;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("pcolvalue", OracleType.VarChar, 10000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = val;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("pdelimiter", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = "$~$";
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("pdateformat", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = dateformat;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = extra1;
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = extra2;
                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("pcond_colname", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = mit;
                orclcmd.Parameters.Add(prm8);




                //  orclcmd.Parameters.Add("p_accounts", OracleType.Cursor);
                //  orclcmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;




                da.SelectCommand = orclcmd;
                da.Fill(ds);
                //orclcmd.ExecuteNonQuery();

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
        public DataSet genastcode(string tbl, string col, string val, string mit, string ascendent, string constellation, string degrrefrom, string degreeto, string chart, string aspecting, string loh1)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("gen_ast_code", ref con);
                //orclcmd = GetCommand("Cir_Dynamic_DML.variable_insert_stmt", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = tbl;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_rashi", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = col;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = val;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_asc_degree", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = mit;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_ascendent", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = ascendent;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_constellation", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = constellation;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_degree_from", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = degrrefrom;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_degree_to", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = degreeto;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_chart_no", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = chart;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("p_asp_planet", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = aspecting;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("p_lord_house", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = loh1;
                orclcmd.Parameters.Add(prm11);



                orclcmd.Parameters.Add("p_accounts", OracleType.Cursor);
                orclcmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;




                da.SelectCommand = orclcmd;
                da.Fill(ds);
                //orclcmd.ExecuteNonQuery();

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
        //public DataSet bindgrid(string house, string rashi, string planet, string degree)
        //{
        //    OracleConnection con = GetConnection();
        //    OracleDataAdapter da = new OracleDataAdapter();
        //    DataSet ds = new DataSet();
        //    OracleCommand orclcmd;
        //    try
        //    {
        //        con.Open();

        //        orclcmd = GetCommand("get_ast_code", ref con);
        //        //orclcmd = GetCommand("Cir_Dynamic_DML.variable_insert_stmt", ref con);
        //        orclcmd.CommandType = CommandType.StoredProcedure;

        //        OracleParameter prm1 = new OracleParameter("p_house", OracleType.VarChar, 2000);
        //        prm1.Direction = ParameterDirection.Input;
        //        if (house == "" || house == "0")
        //        {
        //            prm1.Value = System.DBNull.Value;
        //        }
        //        else
        //        {
        //            prm1.Value = house;
        //        }
        //        orclcmd.Parameters.Add(prm1);

        //        OracleParameter prm2 = new OracleParameter("p_rashi", OracleType.VarChar, 2000);
        //        prm2.Direction = ParameterDirection.Input;
        //        if (rashi == "" || rashi == "0")
        //        {
        //            prm2.Value = System.DBNull.Value;
        //        }
        //        else
        //        {

        //            prm2.Value = rashi;
        //        }
        //        orclcmd.Parameters.Add(prm2);


        //        OracleParameter prm3 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
        //        prm3.Direction = ParameterDirection.Input;
        //        if (planet == "" || planet == "0")
        //        {
        //            prm3.Value = System.DBNull.Value;
        //        }
        //        else
        //        {

        //            prm3.Value = planet;

        //        }
        //        orclcmd.Parameters.Add(prm3);

        //        OracleParameter prm4 = new OracleParameter("p_planet_degree", OracleType.VarChar, 2000);
        //        prm4.Direction = ParameterDirection.Input;
        //        if (degree == "" || degree == "0")
        //        {
        //            prm4.Value = System.DBNull.Value;
        //        }
        //        else
        //        {

        //            prm4.Value = degree;

        //        }

        //        orclcmd.Parameters.Add(prm4);

        //        //OracleParameter prm5 = new OracleParameter("p_code", OracleType.VarChar, 2000);
        //        //prm5.Direction = ParameterDirection.Input;
        //        //prm5.Value = comblist;
        //        //orclcmd.Parameters.Add(prm5);

        //        orclcmd.Parameters.Add("p_accounts", OracleType.Cursor);
        //        orclcmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;




        //        da.SelectCommand = orclcmd;
        //        da.Fill(ds);
        //        return ds;



        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    finally
        //    {
        //        con.Close();
        //    }
        //}


        public DataSet save_data(string code, string name1, string detail_decription, string description, string auto_gen_code, string book, string page0, string keystring)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("save_data", ref con);
                //orclcmd = GetCommand("Cir_Dynamic_DML.variable_insert_stmt", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("code", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = code;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("name1", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = name1;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("combin_code", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = detail_decription;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("description", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = description;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("autogencode", OracleType.Clob, 32000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = code;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("book", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = book;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("page0", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = page0;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("keystring", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = keystring;
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



        public DataSet list(string comblist)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("search_comb_code", ref con);
                //orclcmd = GetCommand("Cir_Dynamic_DML.variable_insert_stmt", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_code", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = comblist;
                orclcmd.Parameters.Add(prm1);

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

        public DataSet detaildescription(string code)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("get_detail_desc", ref con);
                //orclcmd = GetCommand("Cir_Dynamic_DML.variable_insert_stmt", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_code", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = code;
                orclcmd.Parameters.Add(prm1);

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

        public DataSet ast_constellation(string extra)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_CONSTELLATION_bind", ref con);
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

        public DataSet ast_ascendent(string extra)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_ASCENDENT_bind", ref con);
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

        public DataSet save_encyclopaedia(string CODE, string KEY_STRINGS, string DESCCLOB, string BOOK, string PAGE_NO, string HOUSE, string PLANET, string RASHI, string EXTENTIONS)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("save_encyclopaedia", ref con);
                //orclcmd = GetCommand("Cir_Dynamic_DML.variable_insert_stmt", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("code", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                if (CODE == "")
                {
                    prm1.Value = System.DBNull.Value;
                }
                else
                {
                    prm1.Value = CODE;
                }


                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("keystring", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                if (KEY_STRINGS == "")
                {
                    prm2.Value = System.DBNull.Value;
                }
                else
                {
                    prm2.Value = KEY_STRINGS;
                }

                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("detail", OracleType.Clob, 32000);
                prm3.Direction = ParameterDirection.Input;
                if (DESCCLOB == "")
                {
                    prm3.Value = System.DBNull.Value;
                }
                else
                {
                    prm3.Value = DESCCLOB;
                }

                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("book", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                if (BOOK == "")
                {
                    prm4.Value = System.DBNull.Value;
                }
                else
                {
                    prm4.Value = BOOK;
                }
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("page0", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                if (PAGE_NO == "")
                {
                    prm5.Value = System.DBNull.Value;
                }
                else
                {
                    prm5.Value = PAGE_NO;
                }

                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("house", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = HOUSE;
                orclcmd.Parameters.Add(prm6);



                OracleParameter prm7 = new OracleParameter("planet", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = PLANET;
                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("rashi", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = RASHI;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("ext", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = EXTENTIONS;
                orclcmd.Parameters.Add(prm9);


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

        public DataSet save_horary(string CODE, string KEY_STRINGS, string DESCCLOB, string BOOK, string PAGE_NO, string HOUSE, string PLANET, string RASHI, string EXTENTIONS)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("save_horary", ref con);
                //orclcmd = GetCommand("Cir_Dynamic_DML.variable_insert_stmt", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("code", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                if (CODE == "")
                {
                    prm1.Value = System.DBNull.Value;
                }
                else
                {
                    prm1.Value = CODE;
                }


                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("keystring", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                if (KEY_STRINGS == "")
                {
                    prm2.Value = System.DBNull.Value;
                }
                else
                {
                    prm2.Value = KEY_STRINGS;
                }

                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("detail", OracleType.Clob, 32000);
                prm3.Direction = ParameterDirection.Input;
                if (DESCCLOB == "")
                {
                    prm3.Value = System.DBNull.Value;
                }
                else
                {
                    prm3.Value = DESCCLOB;
                }

                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("book", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                if (BOOK == "")
                {
                    prm4.Value = System.DBNull.Value;
                }
                else
                {
                    prm4.Value = BOOK;
                }
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("page0", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                if (PAGE_NO == "")
                {
                    prm5.Value = System.DBNull.Value;
                }
                else
                {
                    prm5.Value = PAGE_NO;
                }

                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("house", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = HOUSE;
                orclcmd.Parameters.Add(prm6);



                OracleParameter prm7 = new OracleParameter("planet", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = PLANET;
                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("rashi", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = RASHI;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("ext", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = EXTENTIONS;
                orclcmd.Parameters.Add(prm9);


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

        public DataSet execute1(string tbl, string col, string val, string mit, string dateformat, string extra1, string extra2)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("Cir_Dynamic_DML.variable_execute_stmt", ref con);
                //orclcmd = GetCommand("Cir_Dynamic_DML.variable_insert_stmt", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("ptable_name", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = tbl;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pcond_colname", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = col;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("pcond_colval", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = val;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("pdelimiter", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = "$~$";
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("pdateformat", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = dateformat;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = extra1;
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = extra2;
                orclcmd.Parameters.Add(prm7);

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

        public DataSet delete1(string tbl, string col, string val, string dateformat, string extra1, string extra2)
        {

            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();


                orclcmd = GetCommand("Cir_Dynamic_DML.variable_delete_stmt", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("ptable_name", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = tbl;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pcond_colname", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = col;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("pcond_colval", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = val;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("pdelimiter", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = "$~$";
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("pdateformat", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = dateformat;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = extra1;
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = extra2;
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


        public DataSet Modify_data1(string tbl, string col, string val, string mit, string dateformat, string extra1, string extra2)
        {

            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("Cir_Dynamic_DML.variable_update_stmt", ref con);
                //orclcmd = GetCommand("Cir_Dynamic_DML.variable_insert_stmt", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("ptable_name", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = tbl;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pcolname", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = col;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("pcolvalue", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = val;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("pdelimiter", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = "$~$";
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("pdateformat", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = dateformat;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pextra1", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = extra1;
                orclcmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("pextra2", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = extra2;
                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("pcond_colname", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = mit;
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

        public DataSet ast_chart(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_chart_bind", ref con);
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

        public DataSet ast_rights(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_RIGHTS", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_astid", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = p;
                orclcmd.Parameters.Add(prm1);


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

        public DataSet AST_lord_bind(string p)
        {


            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_lord_bind", ref con);
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

        public DataSet getlord(string rashi)
        {

            OracleConnection con;
            OracleCommand cmd = new OracleCommand();
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            string ank = "";
            try
            {
                ank = "Select get_lord_of('" + rashi + "') AS NAME from dual";
                cmd.CommandText = ank;
                cmd.Connection = con;
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                CloseConnection(ref con);
            }

            return ds;
        }



        public DataSet getlordofhouse(string loh1, string house, string rashi)
        {


            OracleConnection con;
            OracleCommand cmd = new OracleCommand();
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            string ank = "";
            try
            {
                ank = "Select get_lord_from('" + loh1 + "','" + house + "','" + rashi + "') AS NAME from dual";
                cmd.CommandText = ank;
                cmd.Connection = con;
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                CloseConnection(ref con);
            }

            return ds;
        }

        public DataSet ast_quardent(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_binD.ast_rashi_bind", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pextra", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = p;
                orclcmd.Parameters.Add(prm1);

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

        public DataSet ast_trine(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_trines_bind", ref con);
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

        public DataSet save_aspect(string astrocat1, string aspects, string lord, string rashi, string hous, string desc, string detail, string loh, string categery, string lagna, string book1, string keystring1, string aspectrashi,string f11page,string chart,string unique,string fid,string today)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("save_aspect", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("house", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;

                prm1.Value = aspects;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("lord", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = lord;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("rashi", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = aspectrashi;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("hou", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = hous;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("description", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = desc;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("desclob", OracleType.Clob, 32000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = detail;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("loh", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = loh;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("categery", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = categery;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("lagna", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = lagna;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("withlord", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("inlord", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = "";
                orclcmd.Parameters.Add(prm11);


                OracleParameter prm12 = new OracleParameter("planet", OracleType.VarChar, 2000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = lord;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("astrocat", OracleType.VarChar, 2000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = astrocat1;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("book", OracleType.VarChar, 2000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = book1;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("keystring", OracleType.VarChar, 2000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = keystring1;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("aspecthouse", OracleType.VarChar, 2000);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = hous;
                orclcmd.Parameters.Add(prm16);

                OracleParameter prm17 = new OracleParameter("aspectrashi", OracleType.VarChar, 2000);
                prm17.Direction = ParameterDirection.Input;
                prm17.Value = rashi;
                orclcmd.Parameters.Add(prm17);


                OracleParameter prm18 = new OracleParameter("p_Page", OracleType.VarChar, 2000);
                prm18.Direction = ParameterDirection.Input;
                if (f11page == "")
                {
                    prm18.Value = System.DBNull.Value;
                }
                else
                { prm18.Value = f11page; }

                orclcmd.Parameters.Add(prm18);

                OracleParameter prm19 = new OracleParameter("p_chart", OracleType.VarChar, 2000);
                prm19.Direction = ParameterDirection.Input;
                prm19.Value = chart;
                orclcmd.Parameters.Add(prm19);

                OracleParameter prm20 = new OracleParameter("p_unique", OracleType.VarChar, 2000);
                prm20.Direction = ParameterDirection.Input;
                prm20.Value = unique;
                orclcmd.Parameters.Add(prm20);

                OracleParameter prm21 = new OracleParameter("p_fid", OracleType.VarChar, 2000);
                prm21.Direction = ParameterDirection.Input;
                prm21.Value = fid;
                orclcmd.Parameters.Add(prm21);


                OracleParameter prm22 = new OracleParameter("p_date", OracleType.VarChar, 2000);
                prm22.Direction = ParameterDirection.Input;
                prm22.Value = today;
                orclcmd.Parameters.Add(prm22);


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

        //public DataSet getlordofhouse1(string loh1)
        //{
        //    OracleConnection con;
        //    OracleCommand cmd = new OracleCommand();
        //    con = GetConnection();
        //    DataSet ds = new DataSet();
        //    OracleDataAdapter da = new OracleDataAdapter();
        //    string ank = "";
        //    try
        //    {
        //        ank = "Select get_lord_from('" + loh1 + "') AS NAME from dual";
        //        cmd.CommandText = ank;
        //        cmd.Connection = con;
        //        da.SelectCommand = cmd;
        //        da.Fill(ds);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw (ex);
        //    }
        //    finally
        //    {
        //        CloseConnection(ref con);
        //    }

        //    return ds;
        //}

        public DataSet bindaspecthouse(string p)
        {

            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_aspecthouse_bind", ref con);
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

        public DataSet detaildescriptionaspect(string desc)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("get_detail_descaspect", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_code", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = desc;
                orclcmd.Parameters.Add(prm1);

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

        public DataSet ast_lord(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_LORD_bind", ref con);
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
        public DataSet aspect1(string s1, string s2)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_ASPECTS_HOUSE_BIND", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = s1;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = s2;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = "";
                orclcmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("pextra3", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = "";
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("pextra4", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = "";
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pextra5", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = "";
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("pextra6", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "";
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pextra7", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "";
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pextra8", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = "";
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("pextra9", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("pextra10", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = "";
                orclcmd.Parameters.Add(prm11);



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

        public DataSet aspect(string aspecthouse, string lordofhouse)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_ASPECTS_HOUSE_BIND", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = aspecthouse;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = lordofhouse;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = "";
                orclcmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("pextra3", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = "";
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("pextra4", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = "";
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pextra5", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = "";
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("pextra6", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "";
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pextra7", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "";
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pextra8", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = "";
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("pextra9", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("pextra10", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = "";
                orclcmd.Parameters.Add(prm11);



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


        public DataSet bindwithhouse(string withthouse, string lordofhouse)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_WITH_HOUSE_BIND", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = withthouse;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_house_code2", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = lordofhouse;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("pdateformat", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = "";
                orclcmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = "";
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = "";
                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("pextra3", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = "";
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("pextra4", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "";
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pextra5", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "";
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pextra6", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = "";
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("pextra7", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("pextra8", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = "";
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("pextra9", OracleType.VarChar, 2000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = "";
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("pextra10", OracleType.VarChar, 2000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = "";
                orclcmd.Parameters.Add(prm13);



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

        public DataSet save_with(string astrocat1, string lagna, string with, string lordof, string house1, string withhouse, string loh, string desc, string detail, string categery, string book1, string keystring1, string rashi, string rashiwith)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("save_aspect", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("house", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;

                prm1.Value = withhouse;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("lord", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = lordof;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("rashi", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = rashiwith;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("hou", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = house1;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("description", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = desc;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("desclob", OracleType.Clob, 32000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = detail;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("loh", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = loh;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("categery", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = categery;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("lagna", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = lagna;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("withlord", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = with;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("inlord", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = "";
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("planet", OracleType.VarChar, 2000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = lordof;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("astrocat", OracleType.VarChar, 2000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = astrocat1;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("book", OracleType.VarChar, 2000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = book1;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("keystring", OracleType.VarChar, 2000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = keystring1;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("aspecthouse", OracleType.VarChar, 2000);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = house1;
                orclcmd.Parameters.Add(prm16);

                OracleParameter prm17 = new OracleParameter("aspectrashi", OracleType.VarChar, 2000);
                prm17.Direction = ParameterDirection.Input;
                prm17.Value = rashi;
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

        public DataSet ast_categery(string p)
        {

            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_categery_bind", ref con);
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

        public DataSet with1(string s3, string s4)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_WITH_HOUSE_BIND", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = s4;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_house_code2", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = s3;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("pdateformat", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = "";
                orclcmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = "";
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = "";
                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("pextra3", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = "";
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("pextra4", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "";
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pextra5", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "";
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pextra6", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = "";
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("pextra7", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("pextra8", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = "";
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("pextra9", OracleType.VarChar, 2000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = "";
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("pextra10", OracleType.VarChar, 2000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = "";
                orclcmd.Parameters.Add(prm13);



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



        public DataSet bindwithhouse(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_withhouse_bind", ref con);
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

        public DataSet bindinhouse(string lordofhouse, string inhouse)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_IN_HOUSE_BIND", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = lordofhouse;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_house_code2", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = inhouse;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("pdateformat", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = "";
                orclcmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = "";
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = "";
                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("pextra3", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = "";
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("pextra4", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "";
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pextra5", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "";
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pextra6", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = "";
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("pextra7", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("pextra8", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = "";
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("pextra9", OracleType.VarChar, 2000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = "";
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("pextra10", OracleType.VarChar, 2000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = "";
                orclcmd.Parameters.Add(prm13);



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

        public DataSet save_in(string astrocat1, string lagna, string lordof, string house2, string inhouse, string loh, string desc, string detail, string categery, string book1, string keystring1, string rashi, string inrashi,string f9page,string chart,string unique,string fid,string today)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("save_aspect", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("house", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;

                prm1.Value = inhouse;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("lord", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = lordof;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("rashi", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = inrashi;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("hou", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = house2;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("description", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = desc;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("desclob", OracleType.Clob, 32000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = detail;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("loh", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = loh;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("categery", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = categery;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("lagna", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = lagna;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("withlord", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("inlord", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = lordof;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("planet", OracleType.VarChar, 2000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = lordof;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("astrocat", OracleType.VarChar, 2000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = astrocat1;
                orclcmd.Parameters.Add(prm13);


                OracleParameter prm14 = new OracleParameter("book", OracleType.VarChar, 2000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = book1;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("keystring", OracleType.VarChar, 2000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = keystring1;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("aspecthouse", OracleType.VarChar, 2000);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = house2;
                orclcmd.Parameters.Add(prm16);

                OracleParameter prm17 = new OracleParameter("aspectrashi", OracleType.VarChar, 2000);
                prm17.Direction = ParameterDirection.Input;
                prm17.Value = rashi;
                orclcmd.Parameters.Add(prm17);





                OracleParameter prm18 = new OracleParameter("p_Page", OracleType.VarChar, 2000);
                prm18.Direction = ParameterDirection.Input;
                if (f9page == "")
                {
                    prm18.Value = System.DBNull.Value;
                }
                else
                { prm18.Value = f9page; }

                orclcmd.Parameters.Add(prm18);


                OracleParameter prm19 = new OracleParameter("p_chart", OracleType.VarChar, 2000);
                prm19.Direction = ParameterDirection.Input;
                prm19.Value = chart;
                orclcmd.Parameters.Add(prm19);


                OracleParameter prm20 = new OracleParameter("p_unique", OracleType.VarChar, 2000);
                prm20.Direction = ParameterDirection.Input;
                prm20.Value = unique;
                orclcmd.Parameters.Add(prm20);


                OracleParameter prm21 = new OracleParameter("p_fid", OracleType.VarChar, 2000);
                prm21.Direction = ParameterDirection.Input;
                prm21.Value = fid;
                orclcmd.Parameters.Add(prm21);


                OracleParameter prm22 = new OracleParameter("p_date", OracleType.VarChar, 2000);
                prm22.Direction = ParameterDirection.Input;
                prm22.Value = today;
                orclcmd.Parameters.Add(prm22);

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

        public DataSet in1(string s5, string s6)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_IN_HOUSE_BIND", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = s5;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_house_code2", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = s6;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("pdateformat", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = "";
                orclcmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = "";
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = "";
                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("pextra3", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = "";
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("pextra4", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "";
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pextra5", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "";
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pextra6", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = "";
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("pextra7", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("pextra8", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = "";
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("pextra9", OracleType.VarChar, 2000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = "";
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("pextra10", OracleType.VarChar, 2000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = "";
                orclcmd.Parameters.Add(prm13);



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

        public DataSet inwithhouse(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_inhouse_bind", ref con);
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

        public DataSet ast_astrocat(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_astrocat_bind", ref con);
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

        public DataSet bindplanethouse(string lordhouse, string planet1)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("PLANET_ASPECT_BIND", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = lordhouse;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = planet1;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("pdateformat", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = "";
                orclcmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = "";
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = "";
                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("pextra3", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = "";
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("pextra4", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "";
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pextra5", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "";
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pextra6", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = "";
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("pextra7", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("pextra8", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = "";
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("pextra9", OracleType.VarChar, 2000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = "";
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("pextra10", OracleType.VarChar, 2000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = "";
                orclcmd.Parameters.Add(prm13);



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

        public DataSet save_planet(string astrocat1, string lagna, string planet1, string categery, string housep, string desc, string detail, string lordp, string house1, string aspecthouse, string book1, string keystring1, string rashi, string aspectrashi,string f12page,string chart,string unique,string fid,string today)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("save_aspect", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("house", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;

                prm1.Value = housep;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("lord", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = lordp;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("rashi", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = aspectrashi;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("hou", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = aspecthouse;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("description", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = desc;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("desclob", OracleType.Clob, 32000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = detail;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("loh", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = house1;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("categery", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = categery;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("lagna", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = lagna;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("withlord", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("inlord", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = "";
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("planet", OracleType.VarChar, 2000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = planet1;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("astrocat", OracleType.VarChar, 2000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = astrocat1;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("book", OracleType.VarChar, 2000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = book1;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("keystring", OracleType.VarChar, 2000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = keystring1;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("aspecthouse", OracleType.VarChar, 2000);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = house1;
                orclcmd.Parameters.Add(prm16);

                OracleParameter prm17 = new OracleParameter("aspectrashi", OracleType.VarChar, 2000);
                prm17.Direction = ParameterDirection.Input;
                prm17.Value = rashi;
                orclcmd.Parameters.Add(prm17);

                OracleParameter prm18 = new OracleParameter("p_Page", OracleType.VarChar, 2000);
                prm18.Direction = ParameterDirection.Input;
                if (f12page == "")
                {
                    prm18.Value = System.DBNull.Value;
                }
                else
                { prm18.Value = f12page; }

                orclcmd.Parameters.Add(prm18);


                OracleParameter prm19 = new OracleParameter("p_chart", OracleType.VarChar, 2000);
                prm19.Direction = ParameterDirection.Input;
                prm19.Value = chart;
                orclcmd.Parameters.Add(prm19);


                OracleParameter prm20 = new OracleParameter("p_unique", OracleType.VarChar, 2000);
                prm20.Direction = ParameterDirection.Input;
                prm20.Value = unique;
                orclcmd.Parameters.Add(prm20);


                OracleParameter prm21 = new OracleParameter("p_fid", OracleType.VarChar, 2000);
                prm21.Direction = ParameterDirection.Input;
                prm21.Value = fid;
                orclcmd.Parameters.Add(prm21);


                OracleParameter prm22 = new OracleParameter("p_date", OracleType.VarChar, 2000);
                prm22.Direction = ParameterDirection.Input;
                prm22.Value = today;
                orclcmd.Parameters.Add(prm22);



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

        public DataSet bindplanethouse1(string s2, string s1)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("PLANET_ASPECT_BIND", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = s2;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = s1;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("pdateformat", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = "";
                orclcmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = "";
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = "";
                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("pextra3", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = "";
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("pextra4", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "";
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pextra5", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "";
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pextra6", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = "";
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("pextra7", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("pextra8", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = "";
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("pextra9", OracleType.VarChar, 2000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = "";
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("pextra10", OracleType.VarChar, 2000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = "";
                orclcmd.Parameters.Add(prm13);



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

        public DataSet bindaspectplanet(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_planetaspect_bind", ref con);
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

        public DataSet saveplanetfromplanet(string f15planet, string f15house, string f15aplanet, string f15book, string f15page, string keystring, string detail, string desc, string combination, string lagna,string chart,string unique,string fid,string today)
        {

            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_save_planetfromplanet", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planet", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = f15planet;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_house", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = f15house;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_aplanet", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = f15aplanet;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = f15book;
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("p_desc", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = desc;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_detail", OracleType.Clob, 64000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = detail;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_comb", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = combination;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = f15page;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_filter", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = keystring;
                orclcmd.Parameters.Add(prm9);


                OracleParameter prm10 = new OracleParameter("p_lagna", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = lagna;
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


                OracleParameter prm14 = new OracleParameter("p_date", OracleType.VarChar, 4000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = today;
                orclcmd.Parameters.Add(prm14);





                da.SelectCommand = orclcmd;
                da.Fill(ds);
                //orclcmd.ExecuteNonQuery();

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


        public DataSet inhouse1(string s1, string s2)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_IN_HOUSE_BIND", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = s1;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_house_code2", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = s2;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("pdateformat", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = "";
                orclcmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = "";
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = "";
                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("pextra3", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = "";
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("pextra4", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "";
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pextra5", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "";
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pextra6", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = "";
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("pextra7", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("pextra8", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = "";
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("pextra9", OracleType.VarChar, 2000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = "";
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("pextra10", OracleType.VarChar, 2000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = "";
                orclcmd.Parameters.Add(prm13);


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

        public DataSet bindin1(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_in1_bind", ref con);
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

        public DataSet savepriority(string code, string priority, string descclob, string ref_, string updated, string casedescription)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("save_priority", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("code", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = code;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("priority", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = priority;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("desclob", OracleType.Clob, 32000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = descclob;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("ref_", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ref_;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("updat", OracleType.Clob, 32000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = updated;

                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("descr", OracleType.Clob, 32000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = casedescription;

                orclcmd.Parameters.Add(prm6);



                da.SelectCommand = orclcmd;
                da.Fill(ds);
                //orclcmd.ExecuteNonQuery();

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

        public DataSet refcode(string extra1, string extra2)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {

                con.Open();
                cmd = GetCommand("PRIORITY_HOUSE_p", ref con);
                cmd.CommandType = CommandType.StoredProcedure;



                OracleParameter prm1 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = extra1;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = extra2;
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

        public DataSet ast_retrograde(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_RETROGRADE_bind", ref con);
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

        public DataSet ast_degree(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_DEGREE_bind", ref con);
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

        public DataSet ast_planet_ascendent(string vishu)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_PLANET_ASCENDENT_bind", ref con);
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

        public DataSet housevalue(string house, string rashi, string selectedrashi)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_house_value", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = house;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("prashi1", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = rashi;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("prashi2", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = selectedrashi;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = "";
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = "";
                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("pextra3", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = "";
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("pextra4", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "";
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pextra5", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "";
                orclcmd.Parameters.Add(prm8);


                orclcmd.Parameters.Add("p_accounts", OracleType.Cursor);
                orclcmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_accounts1", OracleType.Cursor);
                orclcmd.Parameters["p_accounts1"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_accounts2", OracleType.Cursor);
                orclcmd.Parameters["p_accounts2"].Direction = ParameterDirection.Output;

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

        public DataSet rashivalue(string house, string rashi, string selectedhouse)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_rashi_value", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = house;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_house_code2", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = selectedhouse;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("prashi1", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = rashi;
                orclcmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = "";
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = "";
                orclcmd.Parameters.Add(prm5);


                OracleParameter prm6 = new OracleParameter("pextra3", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = "";
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("pextra4", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "";
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pextra5", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "";
                orclcmd.Parameters.Add(prm8);

                orclcmd.Parameters.Add("p_accounts", OracleType.Cursor);
                orclcmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_accounts1", OracleType.Cursor);
                orclcmd.Parameters["p_accounts1"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_accounts2", OracleType.Cursor);
                orclcmd.Parameters["p_accounts2"].Direction = ParameterDirection.Output;

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

        public DataSet searchdesc(string s, string ss, string kk, string rashi, string key, string planets, string chart,string astrologer1)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_dbg_comb_search", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_code", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = s;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("ptxt", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                if (ss == "")
                {
                    prm2.Value = '2';

                }
                else
                {
                    prm2.Value = ss;
                }
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("pflag", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                if (kk == "")
                {
                    prm3.Value = '3';
                }
                else
                {
                    prm3.Value = kk;
                }
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("prashilagna", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = rashi;
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("keyword", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                if (key == "")
                {
                    prm5.Value = '2';

                }
                else
                {
                    prm5.Value = key;
                }
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("allplanets", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                if (planets == "")
                {
                    prm6.Value = '1';

                }
                else
                {
                    prm6.Value = planets;
                }
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_chart", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = chart;
                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("p_astro", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = astrologer1;
                orclcmd.Parameters.Add(prm8);

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



        public DataSet searchdescf(string s, string ss, string kk, string rashi, string key, string planets, string chart,string astrologer1)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_dbg_comb_search_f", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_code", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = s;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("ptxt", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                if (ss == "")
                {
                    prm2.Value = '2';

                }
                else
                {
                    prm2.Value = ss;
                }
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("pflag", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                if (kk == "")
                {
                    prm3.Value = '3';
                }
                else
                {
                    prm3.Value = kk;
                }
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("prashilagna", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = rashi;
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("keyword", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                if (key == "")
                {
                    prm5.Value = '2';

                }
                else
                {
                    prm5.Value = key;
                }
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("allplanets", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                if (planets == "")
                {
                    prm6.Value = '1';

                }
                else
                {
                    prm6.Value = planets;
                }
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_chart", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = chart;
                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("p_astro", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = astrologer1;
                orclcmd.Parameters.Add(prm8);

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



        public DataSet fillgrid(string comp_code, string house, string rashi, string planet, string textname, string book, string page0, string EXTENTIONS, string extra1)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_filter_grid", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("phouse", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = house;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("prashi", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = rashi;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("pplanet", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = planet;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("pcode", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = comp_code;
                cmd.Parameters.Add(prm4);



                OracleParameter prm5 = new OracleParameter("pbook", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = book;
                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("ppage", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = page0;
                cmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("pkey", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = textname;
                cmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pext", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = EXTENTIONS;
                cmd.Parameters.Add(prm8);


                OracleParameter prm9 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = extra1;
                cmd.Parameters.Add(prm9);


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

        public DataSet fillgridh(string comp_code, string house, string rashi, string planet, string textname, string book, string page0, string EXTENTIONS, string extra1)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_filterh_grid", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("phouse", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = house;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("prashi", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = rashi;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("pplanet", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = planet;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("pcode", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = comp_code;
                cmd.Parameters.Add(prm4);



                OracleParameter prm5 = new OracleParameter("pbook", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = book;
                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("ppage", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = page0;
                cmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("pkey", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = textname;
                cmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pext", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = EXTENTIONS;
                cmd.Parameters.Add(prm8);


                OracleParameter prm9 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = extra1;
                cmd.Parameters.Add(prm9);


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

        public DataSet update_grid(string description, string description1, string descclob, string key, string key1, string explain, string fil, string book, string uniqueid)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_UPDATE_GRID", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("descr", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = description;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("descr1", OracleType.Clob, 32000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = description1;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("ddescr", OracleType.Clob, 32000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = descclob;
                cmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("kkey", OracleType.Clob, 32000);
                prm4.Direction = ParameterDirection.Input;
                if (key == "")
                {
                    prm4.Value = '2';

                }
                else
                {
                    prm4.Value = key;
                }

                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("kkey1", OracleType.Clob, 32000);
                prm5.Direction = ParameterDirection.Input;
                if (key1 == "")
                {
                    prm5.Value = System.DBNull.Value;

                }
                else
                {
                    prm5.Value = key1;
                }

                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pexplain", OracleType.Clob, 32000);
                prm6.Direction = ParameterDirection.Input;
                if (explain == "")
                {
                    prm6.Value = System.DBNull.Value;

                }
                else
                {
                    prm6.Value = explain;
                }

                cmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("pfil", OracleType.Clob, 32000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = fil;
                cmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pbook", OracleType.Clob, 32000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = book;
                cmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("puniqueid", OracleType.VarChar, 500);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = uniqueid;
                cmd.Parameters.Add(prm9);

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

        public DataSet save_extentions(string EXTENTIONS)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("save_extentions", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("extentions", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                if (EXTENTIONS == "")
                {
                    prm1.Value = System.DBNull.Value;
                }
                else
                {
                    prm1.Value = EXTENTIONS;
                }


                orclcmd.Parameters.Add(prm1);




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

        public DataSet Modifydata1(string casetxtextentions, string hiddenmodtxtextentions)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_modify_ext", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("newext", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = casetxtextentions;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("oldext", OracleType.Clob, 32000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = hiddenmodtxtextentions;
                cmd.Parameters.Add(prm2);

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

        public DataSet ast_ext(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_ext_bind", ref con);
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

        public DataSet donecharts(string planet1, string house1, string ldeg, string pdeg)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("PLANET_ASPECT_BIND_D9", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = house1;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = planet1;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_pdegree", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = pdeg;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_ldegree", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ldeg;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("pdateformat", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = "";
                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = "";
                cmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "";
                cmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pextra3", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "";
                cmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pextra4", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = "";
                cmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("pextra5", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                cmd.Parameters.Add(prm10);



                OracleParameter prm11 = new OracleParameter("pextra6", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = "";
                cmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("pextra7", OracleType.VarChar, 2000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = "";
                cmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("pextra8", OracleType.VarChar, 2000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = "";
                cmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("pextra9", OracleType.VarChar, 2000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = "";
                cmd.Parameters.Add(prm14);


                OracleParameter prm15 = new OracleParameter("pextra10", OracleType.VarChar, 2000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = "";
                cmd.Parameters.Add(prm15);



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

        public DataSet dninecharts(string planet1, string house1, string ldeg, string pdeg)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("PLANET_ASPECT_BIND_D9", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = house1;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = planet1;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_pdegree", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = pdeg;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_ldegree", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ldeg;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("pdateformat", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = "";
                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = "";
                cmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "";
                cmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pextra3", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "";
                cmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pextra4", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = "";
                cmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("pextra5", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                cmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("pextra6", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = "";
                cmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("pextra7", OracleType.VarChar, 2000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = "";
                cmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("pextra8", OracleType.VarChar, 2000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = "";
                cmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("pextra9", OracleType.VarChar, 2000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = "";
                cmd.Parameters.Add(prm14);


                OracleParameter prm15 = new OracleParameter("pextra10", OracleType.VarChar, 2000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = "";
                cmd.Parameters.Add(prm15);




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

        public DataSet update_gridencyclo(string key, string key1, string housev)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_update_grid_encyclo", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pkeys", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = key;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pkeys1", OracleType.Clob, 32000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = key1;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("phouse", OracleType.Clob, 32000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = housev;
                cmd.Parameters.Add(prm3);


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
        public DataSet update_gridencycloh(string key, string key1, string housev)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_update_grid_encycloh", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pkeys", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = key;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pkeys1", OracleType.Clob, 32000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = key1;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("phouse", OracleType.Clob, 32000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = housev;
                cmd.Parameters.Add(prm3);


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
        public DataSet delete_gridencyclo(string key, string housev)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_delete_grid_encyclo", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pkeys", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = key;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("phouse", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = housev;
                cmd.Parameters.Add(prm2);


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
        public DataSet delete_gridencycloh(string key, string housev)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_delete_grid_encycloh", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pkeys", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = key;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("phouse", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = housev;
                cmd.Parameters.Add(prm2);


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
        public DataSet dthreecharts(string planet1, string house1, string ldeg, string pdeg)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("PLANET_ASPECT_BIND_D3", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = house1;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = planet1;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_pdegree", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = pdeg;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_ldegree", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ldeg;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("pdateformat", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = "";
                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = "";
                cmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "";
                cmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pextra3", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "";
                cmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pextra4", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = "";
                cmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("pextra5", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                cmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("pextra6", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = "";
                cmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("pextra7", OracleType.VarChar, 2000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = "";
                cmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("pextra8", OracleType.VarChar, 2000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = "";
                cmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("pextra9", OracleType.VarChar, 2000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = "";
                cmd.Parameters.Add(prm14);


                OracleParameter prm15 = new OracleParameter("pextra10", OracleType.VarChar, 2000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = "";
                cmd.Parameters.Add(prm15);




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

        public DataSet dfourcharts(string planet1, string house1, string ldeg, string pdeg)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("PLANET_ASPECT_BIND_D4", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = house1;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = planet1;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_pdegree", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = pdeg;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_ldegree", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ldeg;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("pdateformat", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = "";
                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = "";
                cmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "";
                cmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pextra3", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "";
                cmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pextra4", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = "";
                cmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("pextra5", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                cmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("pextra6", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = "";
                cmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("pextra7", OracleType.VarChar, 2000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = "";
                cmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("pextra8", OracleType.VarChar, 2000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = "";
                cmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("pextra9", OracleType.VarChar, 2000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = "";
                cmd.Parameters.Add(prm14);


                OracleParameter prm15 = new OracleParameter("pextra10", OracleType.VarChar, 2000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = "";
                cmd.Parameters.Add(prm15);




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

        public DataSet dsevencharts(string planet1, string house1, string ldeg, string pdeg)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("PLANET_ASPECT_BIND_D7", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = house1;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = planet1;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_pdegree", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = pdeg;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_ldegree", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ldeg;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("pdateformat", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = "";
                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = "";
                cmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "";
                cmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pextra3", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "";
                cmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pextra4", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = "";
                cmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("pextra5", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                cmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("pextra6", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = "";
                cmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("pextra7", OracleType.VarChar, 2000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = "";
                cmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("pextra8", OracleType.VarChar, 2000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = "";
                cmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("pextra9", OracleType.VarChar, 2000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = "";
                cmd.Parameters.Add(prm14);


                OracleParameter prm15 = new OracleParameter("pextra10", OracleType.VarChar, 2000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = "";
                cmd.Parameters.Add(prm15);




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

        public DataSet dtenharts(string planet1, string house1, string ldeg, string pdeg)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("PLANET_ASPECT_BIND_D10", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = house1;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = planet1;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_pdegree", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = pdeg;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_ldegree", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ldeg;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("pdateformat", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = "";
                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = "";
                cmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "";
                cmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pextra3", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "";
                cmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pextra4", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = "";
                cmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("pextra5", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                cmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("pextra6", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = "";
                cmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("pextra7", OracleType.VarChar, 2000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = "";
                cmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("pextra8", OracleType.VarChar, 2000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = "";
                cmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("pextra9", OracleType.VarChar, 2000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = "";
                cmd.Parameters.Add(prm14);


                OracleParameter prm15 = new OracleParameter("pextra10", OracleType.VarChar, 2000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = "";
                cmd.Parameters.Add(prm15);




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

        public DataSet dtwelvecharts(string planet1, string house1, string ldeg, string pdeg)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("PLANET_ASPECT_BIND_D12", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = house1;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = planet1;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_pdegree", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = pdeg;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_ldegree", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ldeg;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("pdateformat", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = "";
                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = "";
                cmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "";
                cmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pextra3", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "";
                cmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pextra4", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = "";
                cmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("pextra5", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                cmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("pextra6", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = "";
                cmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("pextra7", OracleType.VarChar, 2000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = "";
                cmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("pextra8", OracleType.VarChar, 2000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = "";
                cmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("pextra9", OracleType.VarChar, 2000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = "";
                cmd.Parameters.Add(prm14);


                OracleParameter prm15 = new OracleParameter("pextra10", OracleType.VarChar, 2000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = "";
                cmd.Parameters.Add(prm15);




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

        public DataSet dsixteencharts(string planet1, string house1, string ldeg, string pdeg)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("PLANET_ASPECT_BIND_D16", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = house1;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_planet", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = planet1;
                cmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_pdegree", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = pdeg;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_ldegree", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ldeg;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("pdateformat", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = "";
                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pextra1", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = "";
                cmd.Parameters.Add(prm6);


                OracleParameter prm7 = new OracleParameter("pextra2", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = "";
                cmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pextra3", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = "";
                cmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pextra4", OracleType.VarChar, 2000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = "";
                cmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("pextra5", OracleType.VarChar, 2000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = "";
                cmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("pextra6", OracleType.VarChar, 2000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = "";
                cmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("pextra7", OracleType.VarChar, 2000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = "";
                cmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("pextra8", OracleType.VarChar, 2000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = "";
                cmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("pextra9", OracleType.VarChar, 2000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = "";
                cmd.Parameters.Add(prm14);


                OracleParameter prm15 = new OracleParameter("pextra10", OracleType.VarChar, 2000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = "";
                cmd.Parameters.Add(prm15);




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

        public DataSet vargas(string v)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_chart_combination", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_str", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = v;
                orclcmd.Parameters.Add(prm1);

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
        public DataSet pun(string main, string s, string m, string v, string astro)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_pushkar_navamsha", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_main", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = main;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_str", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = s;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_strm", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = m;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_strv", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = v;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_astro", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = astro;
                orclcmd.Parameters.Add(prm5);

                orclcmd.Parameters.Add("p_accounts", OracleType.Cursor);
                orclcmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_accounts1", OracleType.Cursor);
                orclcmd.Parameters["p_accounts1"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_accounts2", OracleType.Cursor);
                orclcmd.Parameters["p_accounts2"].Direction = ParameterDirection.Output;

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


        public DataSet allpredictive(string tblname)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_all_predictive", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("tbl", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = tblname;
                orclcmd.Parameters.Add(prm1);

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

        public DataSet update_gridall(string description, string description1, string descclob, string key, string key1, string tbl,string explain)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_update_gridall", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("descr", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = description;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("descr1", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = description1;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("ddescr", OracleType.Clob, 32000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = descclob;
                cmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("kkey", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                if (key == "")
                {
                    prm4.Value = '2';

                }
                else
                {
                    prm4.Value = key;
                }

                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("kkey1", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                if (key1 == "")
                {
                    prm5.Value = System.DBNull.Value;

                }
                else
                {
                    prm5.Value = key1;
                }

                cmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("tbln", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = tbl;
                cmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("pexplain", OracleType.Clob, 32000);
                prm7.Direction = ParameterDirection.Input;

                if (explain == "")
                {
                    prm7.Value = System.DBNull.Value;

                }
                else
                {
                    prm7.Value = explain;
                }

               
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

        public DataSet update_tabl(string tbl, string desc, string key,string vrf)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_update_table", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("tbln", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = tbl;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("descc", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = desc;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("kkey", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = key;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("pvrf", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = vrf;
                orclcmd.Parameters.Add(prm4);


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

        public DataSet showcat(string lst)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_cat_predictive", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("Plist", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = lst;
                orclcmd.Parameters.Add(prm1);



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

        public DataSet deletecat(string filter)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_cat_delete", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("Pcat", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = filter;
                orclcmd.Parameters.Add(prm1);



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

        public DataSet bookpredictive(string bookname,string fil)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_book_predictive", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;
                OracleParameter prm1 = new OracleParameter("bookname1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = bookname;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pfil", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = fil;
                orclcmd.Parameters.Add(prm2);

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

        public DataSet bookpredictivepage(string bookname, string pageno)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_book_pred_page", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("bookname1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = bookname;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("ppage", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = pageno;
                orclcmd.Parameters.Add(prm2);


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

        public DataSet showextn(string exten)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_extention", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("extent", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = exten;
                orclcmd.Parameters.Add(prm1);



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

        public DataSet showextnvalue(string exten, string extenvalue)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_extention_data", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pextent", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = exten;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pextentvalue", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = extenvalue;
                orclcmd.Parameters.Add(prm2);


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
        public DataSet showextnvalueh(string exten)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_extentionh_data", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pextent", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = exten;
                orclcmd.Parameters.Add(prm1);

                


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

        public DataSet chk_encyclogrid(string key, string housev)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_chk_encyclo", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pkey", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = key;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("phouse", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = housev;
                orclcmd.Parameters.Add(prm2);


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
        public DataSet chk_encyclogridh(string key, string housev)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_chk_encycloh", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pkey", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = key;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("phouse", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = housev;
                orclcmd.Parameters.Add(prm2);


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


        public DataSet showmultisigni(string multisign)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_multi_significators", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pmultisign", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = multisign;
                orclcmd.Parameters.Add(prm1);

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

        public DataSet delete_gridall(string description, string key, string tbl, string descclob,string explain)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_delete_gridall", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("descr", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = description;
                cmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("kkey", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                if (key == "")
                {
                    prm2.Value = System.DBNull.Value;

                }
                else
                {
                    prm2.Value = key;
                }
                
                cmd.Parameters.Add(prm2);



                OracleParameter prm3 = new OracleParameter("ddescr", OracleType.Clob, 32000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = descclob;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("tbln", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = tbl;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("pexplain", OracleType.Clob, 64000);
                prm5.Direction = ParameterDirection.Input;
                if (explain == "")
                {
                    prm5.Value = System.DBNull.Value;

                }
                else
                {
                    prm5.Value = explain;
                }

                
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

        public DataSet club_gridall(string descr, string kkey, string tbl)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_club_gridall", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("descr", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = descr;
                cmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("kkey", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = kkey;
                cmd.Parameters.Add(prm2);



                OracleParameter prm3 = new OracleParameter("tbln", OracleType.Clob, 32000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = tbl;
                cmd.Parameters.Add(prm3);

               
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

        public DataSet planetfromplanet(string planets, string fromplanet, string inhouse)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_planetfromplanet_BIND", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_planets", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = planets;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_fromplanet", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = fromplanet;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_house_code1", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = inhouse;
                orclcmd.Parameters.Add(prm3);


                


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

        public DataSet chk_book_predictive(string book, string desc, string key, string vrf)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_chk_book", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_book", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = book;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_descc", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = desc;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_key", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = key;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_vrf", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = vrf;
                orclcmd.Parameters.Add(prm4);


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

        public DataSet delete_book_predictive(string description, string key, string book, string descclob, string explain)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_delete_book", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_descr", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = description;
                cmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_kkey", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                if (key == "")
                {
                    prm2.Value = System.DBNull.Value;

                }
                else
                {
                    prm2.Value = key;
                }

                cmd.Parameters.Add(prm2);



                OracleParameter prm3 = new OracleParameter("p_ddescr", OracleType.Clob, 32000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = descclob;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_book", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = book;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_explain", OracleType.Clob, 64000);
                prm5.Direction = ParameterDirection.Input;
                if (explain == "")
                {
                    prm5.Value = System.DBNull.Value;

                }
                else
                {
                    prm5.Value = explain;
                }


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

        public DataSet club_book_predictive(string descr, string kkey, string book)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_club_book", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_descr", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = descr;
                cmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_kkey", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = kkey;
                cmd.Parameters.Add(prm2);



                OracleParameter prm3 = new OracleParameter("p_book", OracleType.Clob, 32000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = book;
                cmd.Parameters.Add(prm3);


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

        public DataSet findandreplace(string find, string replace,string tbl)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_find_and_replace", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pfind", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = find;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("preplace", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = replace;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("ptbl", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = tbl;
                orclcmd.Parameters.Add(prm3);



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

        public DataSet delete_moved_grid(string description, string key, string tbl, string descclob, string explain)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("ast_delete_moved_grid", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("descr", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = description;
                cmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("kkey", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                if (key == "")
                {
                    prm2.Value = System.DBNull.Value;

                }
                else
                {
                    prm2.Value = key;
                }

                cmd.Parameters.Add(prm2);



                OracleParameter prm3 = new OracleParameter("ddescr", OracleType.Clob, 32000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = descclob;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("tbln", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = tbl;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("pexplain", OracleType.Clob, 64000);
                prm5.Direction = ParameterDirection.Input;
                if (explain == "")
                {
                    prm5.Value = System.DBNull.Value;

                }
                else
                {
                    prm5.Value = explain;
                }


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

        public DataSet getconstellation(string rashi, string degreevalue)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_constellation_value", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_rashi_code", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = rashi;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_degreevalue", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = degreevalue;
                orclcmd.Parameters.Add(prm2);

                


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

        public DataSet ast_debexal(string extra)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_DEB_EXAL_bind", ref con);
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

        public DataSet houseindebexal(string loh, string rashi)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_debilitation_exaltation", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_house_code", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = loh;
                orclcmd.Parameters.Add(prm1);

               

                OracleParameter prm2 = new OracleParameter("p_cat", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = rashi;
                orclcmd.Parameters.Add(prm2);





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

        public DataSet ast_charan(string extra)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_binD.ast_charan_bind", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pextra", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = extra;
                orclcmd.Parameters.Add(prm1);

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

        public DataSet ast_quadraped(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_QUADRAPED_bind", ref con);
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

        public DataSet ast_watery(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_WATERY_bind", ref con);
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

        public DataSet searchbyid(string unique)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_book_predictive_id", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_unique", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = unique;
                orclcmd.Parameters.Add(prm1);



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

        public DataSet ast_birth(string vishu)
        {

            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_BIRTHTIME_bind", ref con);

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

        public DataSet ast_makebirthchart(string dob, string tob, double tzon, double ascca, double gulca)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_PLANET_DEGREE_RASHI", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pdob", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Convert.ToDateTime(dob).ToString("dd-MMMM-yyyy"); 
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("ptob", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = tob;

                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("ptz", OracleType.Number);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = tzon;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("pascca", OracleType.Number);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = ascca;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("pgulca", OracleType.Number);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = gulca;
                orclcmd.Parameters.Add(prm5); 
                
                orclcmd.Parameters.Add("p_accounts", OracleType.Cursor);
                orclcmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_accounts1", OracleType.Cursor);
                orclcmd.Parameters["p_accounts1"].Direction = ParameterDirection.Output;

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


        public DataSet ast_maketransition(string dob, string tob,string flag)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_PLANET_DEGREE_TRANSITION", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pdob", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Convert.ToDateTime(dob).ToString("dd-MMMM-yyyy");
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("ptob", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = tob;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("pflag", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = flag;
                orclcmd.Parameters.Add(prm3);

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


        public DataSet ast_maketransitionsp(string dob, string tob, string flag,string sphr)
        {

            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_PLANET_DEGREE_TRANSITIONSP", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pdob", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = Convert.ToDateTime(dob).ToString("dd-MMMM-yyyy");
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("ptob", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = tob;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("pflag", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = flag;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("psphr", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = sphr;
                orclcmd.Parameters.Add(prm4);

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
        public DataSet ast_rashibind(string p)
        {

            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_VARGAS_CLASS_BIND", ref con);

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

        public DataSet searchclientid(string clientname, string astroname, string astid1, string group, string groupu,string clientid)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_client_id", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_cname", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = clientname;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_astname", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = astroname;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_astid", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = astid1;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_group", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = group;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_groupu", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = groupu;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_clientid", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = clientid;
                orclcmd.Parameters.Add(prm6);

                orclcmd.Parameters.Add("p_accounts", OracleType.Cursor);
                orclcmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_accounts1", OracleType.Cursor);
                orclcmd.Parameters["p_accounts1"].Direction = ParameterDirection.Output;

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




        public DataSet starratingprioritydata(string priority, string key, string book, string despription)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_update_priority", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("descr", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = despription;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("kkey", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = key;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("bookname", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = book;
                orclcmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("priority", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = priority;
                orclcmd.Parameters.Add(prm4);

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

        public DataSet movedatainformintable(string description, string key, string book, string descclob, string explain, string form, string unique, string check, string page)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_astroknow", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_book", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = book;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_kkey", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = key;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_descr", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = description;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_ddescr", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = descclob;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_explain", OracleType.Clob, 60000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = explain;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_form", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = form;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_chk", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = check;

                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_unique", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = unique;

                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("p_page", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = page;

                orclcmd.Parameters.Add(prm9);

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

        public DataSet chechduplicacy(string astid, string astname, string client, string clientid, string group, string groupu)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_chk_duplicacy", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm22 = new OracleParameter("pdid", OracleType.VarChar, 4000);
                prm22.Direction = ParameterDirection.Input;
                prm22.Value = astid;
                orclcmd.Parameters.Add(prm22);

                OracleParameter prm23 = new OracleParameter("pdname", OracleType.VarChar, 4000);
                prm23.Direction = ParameterDirection.Input;
                prm23.Value = astname;
                orclcmd.Parameters.Add(prm23);

                OracleParameter prm24 = new OracleParameter("pdclient", OracleType.VarChar, 4000);
                prm24.Direction = ParameterDirection.Input;
                prm24.Value = client;
                orclcmd.Parameters.Add(prm24);

                OracleParameter prm25 = new OracleParameter("pdclientid", OracleType.VarChar, 4000);
                prm25.Direction = ParameterDirection.Input;
                prm25.Value = clientid;
                orclcmd.Parameters.Add(prm25);

                OracleParameter prm26 = new OracleParameter("pgroup", OracleType.VarChar, 4000);
                prm26.Direction = ParameterDirection.Input;
                prm26.Value = group;
                orclcmd.Parameters.Add(prm26);

                OracleParameter prm27 = new OracleParameter("pgroupu", OracleType.VarChar, 4000);
                prm27.Direction = ParameterDirection.Input;
                prm27.Value = groupu;
                orclcmd.Parameters.Add(prm27);

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

        public DataSet bookfindandreplace(string find, string replace, string book)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_bookfind_and_replace", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pfind", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = find;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("preplace", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = replace;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("pbook", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = book;
                orclcmd.Parameters.Add(prm3);

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



        public DataSet bookbind(string f1)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_bookname_bind", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pbook", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = f1;
                orclcmd.Parameters.Add(prm1);

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




        public DataSet bindbooknames(string book,string fill)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("AST_bookcategery_bind", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pbook", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = book;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("pfill", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = fill;
                orclcmd.Parameters.Add(prm2);


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

        public DataSet searchdesc1(string s, string ss, string kk, string rashi, string key, string planets, string chart,string astrologer1)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_degree_comb_search", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_code", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = s;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("ptxt", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                if (ss == "")
                {
                    prm2.Value = '2';
                }
                else
                {
                    prm2.Value = ss;
                }
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("pflag", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                if (kk == "")
                {
                    prm3.Value = '3';
                }
                else
                {
                    prm3.Value = kk;
                }
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("prashilagna", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = rashi;
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("keyword", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                if (key == "")
                {
                    prm5.Value = '2';

                }
                else
                {
                    prm5.Value = key;
                }
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("allplanets", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                if (planets == "")
                {
                    prm6.Value = '1';

                }
                else
                {
                    prm6.Value = planets;
                }
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_chart", OracleType.VarChar, 2000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = chart;
                orclcmd.Parameters.Add(prm7);


                OracleParameter prm8 = new OracleParameter("p_astro", OracleType.VarChar, 2000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = astrologer1;
                orclcmd.Parameters.Add(prm8);

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


        public DataSet ast_yogas(string p)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("horary_ptanet_itchaal_drop", ref con);
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





        public DataSet searchbydate(string date1, string date2)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("ast_search_by_date", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("f_date", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = date1;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("t_date", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = date2;
                orclcmd.Parameters.Add(prm2);

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

        public DataSet ast_listbox_data(string data)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand(" AST_YOGAFILTER_BIND", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_yoga", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = data;
                orclcmd.Parameters.Add(prm1);

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



        public DataSet ast_listbox_str(string rashihouse,string listitem)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_YOGAPREDICTIVE_SEARCH", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_combination", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = rashihouse;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_listitem", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = listitem;
                orclcmd.Parameters.Add(prm2);

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



        public DataSet ast_major_remedials(string extra)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_MAJOR_REMEDIALS", ref con);
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
        public DataSet ast_main_filter(string extra)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_hcf_bind", ref con);
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

        public DataSet horarycombination_bind(string maindrop)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_hcsf_bind", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_main", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = maindrop;
                orclcmd.Parameters.Add(prm1);
               
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

        public DataSet sub_remedies(string maindrop)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_SUBREMEDIES_BIND", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_main", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = maindrop;
                orclcmd.Parameters.Add(prm1);

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

        
            
        public DataSet sub_lagna(string maindrop)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_SUBLAGNA_BIND", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_main", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = maindrop;
                orclcmd.Parameters.Add(prm1);

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

        public DataSet sub_sub_remedies(string menup,string menuc)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_SUBSUBREMEDIES_BIND", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_main", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = menup;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("c_main", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = menuc;
                orclcmd.Parameters.Add(prm2);

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
        
        public DataSet ast_horary_comb(string combination, string lagnarashi, string mainfilerdrop, string subfilterdrop,string astrologer,string clmail)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_horarypredictive_search", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_combination", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = combination;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_lagna", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = lagnarashi;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_filter", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = mainfilerdrop;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_subfilter", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                if (subfilterdrop == "")
                {
                    prm4.Value = System.DBNull.Value;
                }
                else
                {
                    prm4.Value = subfilterdrop;
                }
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_astrologer", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = astrologer;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_clmail", OracleType.VarChar, 2000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = clmail;
                orclcmd.Parameters.Add(prm6);

                orclcmd.Parameters.Add("p_accounts", OracleType.Cursor);
                orclcmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_accounts1", OracleType.Cursor);
                orclcmd.Parameters["p_accounts1"].Direction = ParameterDirection.Output;

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

        public DataSet ast_remedial_comb(string combination, string lagnarashi, string mainfilerdrop, string subfilterdrop, string astrologer)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_REMEDIAL_SEARCH", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_combination", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = combination;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_lagna", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = lagnarashi;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_filter", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = mainfilerdrop;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_subfilter", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                if (subfilterdrop == "")
                {
                    prm4.Value = System.DBNull.Value;
                }
                else
                {
                    prm4.Value = subfilterdrop;
                }
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_astrologer", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = astrologer;
                orclcmd.Parameters.Add(prm5);

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

        public DataSet ast_horary_combm(string combination, string lagnarashi, string mainfilerdrop,  string astrologer,string clmail)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_horarypredictive_searchm", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_combination", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = combination;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_lagna", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = lagnarashi;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_filter", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = mainfilerdrop;
                orclcmd.Parameters.Add(prm3);


                OracleParameter prm4 = new OracleParameter("p_astrologer", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = astrologer;
                orclcmd.Parameters.Add(prm4);


                OracleParameter prm5 = new OracleParameter("p_clmail", OracleType.VarChar, 2000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = clmail;
                orclcmd.Parameters.Add(prm5);

                orclcmd.Parameters.Add("p_accounts", OracleType.Cursor);
                orclcmd.Parameters["p_accounts"].Direction = ParameterDirection.Output;

                orclcmd.Parameters.Add("p_accounts1", OracleType.Cursor);
                orclcmd.Parameters["p_accounts1"].Direction = ParameterDirection.Output;

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


        public DataSet checkdataforgrid(string datafortable)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("horary_significatro_search", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_signifi", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = datafortable;
                orclcmd.Parameters.Add(prm1);

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



        public DataSet fill1_data_filter(string filter1)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_hora_treeid_view", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_selectednode", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = filter1;
                orclcmd.Parameters.Add(prm1);

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



        public DataSet open_grid(string filter1,string filter2)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("horary_astro_explanataion", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_filter1", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = filter1;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_filter2", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = filter2;
                orclcmd.Parameters.Add(prm2);


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

     

        public DataSet save_data_tree(string node_name, string group, string explanation, string under_node_id, string id, string exp2, string exp3, string drop_down)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_astrokno_save_tree", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_nodename", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = node_name;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_nodegroup", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = group;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_explanation", OracleType.Clob);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = explanation;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_explanation2", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = exp2;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_explanation3", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = exp3;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("p_under_nodeid", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = under_node_id;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("p_id", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = id;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("p_know_source", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = drop_down;
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


        public DataSet save_synonyam(string drop_down, string node_name, string synonyam)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_ASTROKNO_SAVE_SYNONYAM", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_know_source", OracleType.VarChar, 64000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = drop_down;
                orclcmd.Parameters.Add(prm1);
                
                OracleParameter prm2 = new OracleParameter("p_nodename", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = node_name;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_synonyam", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = synonyam;
                orclcmd.Parameters.Add(prm3);


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


        public DataSet check_node_data(string node_name, string drop, string under_node_id, string drop_down)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_check_node", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_nodename", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = node_name;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_drop", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = drop;
                orclcmd.Parameters.Add(prm2);


                OracleParameter prm3 = new OracleParameter("p_under_node_id", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = under_node_id;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_know_source", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = drop_down;
                orclcmd.Parameters.Add(prm4);

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




        public DataSet fetch_tree(string under_node_id)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_astro_tree_view", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_under_node_id", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = under_node_id;
                orclcmd.Parameters.Add(prm1);            

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

        public DataSet fetch_treeexplation(string under_node_id)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_astro_treeexp", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_under_node_id", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = under_node_id;
                orclcmd.Parameters.Add(prm1);

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

        public DataSet bindlatlng(string country, string state, string district, string city)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_latlng", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("vc", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = country;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("vs", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = state;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("vd", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = district;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("vci", OracleType.VarChar, 2000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = city;
                orclcmd.Parameters.Add(prm4);

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
        public DataSet bindtz( string tzid, string dob1)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GMT_DST", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("tzid", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = tzid;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("dob", OracleType.VarChar, 2000);
                string[] arr = dob1.Split('/');
                string dd = arr[0];
                string mm = arr[1];
                string yy = arr[2];
                dob1 = mm + "/" + dd + "/" + yy;
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = Convert.ToDateTime(dob1).ToString("dd-MMMM-yyyy"); 
                orclcmd.Parameters.Add(prm2);

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
        public DataSet fetch_treeexplation_hora(string under_node_id)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_hora_treeexp", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_under_node_id", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = under_node_id;
                orclcmd.Parameters.Add(prm1);

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



        public DataSet fetch_treeid(string selectednode)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_astro_treeid_view", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_selectednode", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = selectednode;
                orclcmd.Parameters.Add(prm1);

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



        public DataSet view_node(string filter, string under_node_id, string drop_down)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_tree_root_bind", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_root", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = filter;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_undernode_id", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = under_node_id;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_know_source", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = drop_down;
                orclcmd.Parameters.Add(prm3);

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
       



        public DataSet view_exp(string sp, string f, string drop_down)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_tree_exp_bind", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_sp", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = sp;
                orclcmd.Parameters.Add(prm1);


                OracleParameter prm2 = new OracleParameter("p_f", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = f;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_know_source", OracleType.VarChar, 2000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = drop_down;
                orclcmd.Parameters.Add(prm3);


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

        public DataSet view_syno(string f, string drop_down)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_ASTROKNO_SYNO_TREE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_nodeid", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = f;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_know_source", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = drop_down;
                orclcmd.Parameters.Add(prm2);

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
        public DataSet view_par(string f, string drop_down)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_ASTROKNO_PARENT_TREE", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_nodeid", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = f;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_know_source", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = drop_down;
                orclcmd.Parameters.Add(prm2);

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
      

        public DataSet update_data_tree(string nodeid, string explanation, string exp2, string exp3, string drop_down, string upnode)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_astrokno_update_tree", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_nodeid", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = nodeid;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_explanation2", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = exp2;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("p_explanation3", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = exp3;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("p_know_source", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = drop_down;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("p_upnode", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = upnode;
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


        public DataSet ast_menubar()
        {

            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_MENUBAR", ref con);
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


        public DataSet fetch_node(string v4)
        {

            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_astro_tree_node", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_node_id", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = v4;
                orclcmd.Parameters.Add(prm1);

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

        public DataSet delete_data_tree(string nodeid, string drop_down)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("ast_astrokno_delete_tree", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("p_nodeid", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = nodeid;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("p_know_source", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = drop_down;
                orclcmd.Parameters.Add(prm2);

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


        public Recordset update_data_tree1(string nodeid, string explanation, string drop_down, string upnode)
        {
            ADODB.Connection con = new ADODB.Connection();
            ADODB.Recordset rs = new ADODB.Recordset();
            try
            {
                con.Open("orcl_astro", "astrology", "astrology", 0);
                string EXPLANATIONed = explanation;
                string nid = nodeid;
                string sqld;
                if (drop_down=="Astro knowledge")
                {
                sqld = "select EXPLANATION from ASTRO_KNOWLEDGE_TRANSACTION where SYNO_ID='" + nid + "'  ";
                }
                else
                {
                sqld = "select EXPLANATION from HORARY_KNOWLEDGE_EXPLANATION where SYNO_ID='" + nid + "'  ";
                }
                rs.Open(sqld, con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic,1);
                //rs.record
                // rs.Fields[0].Value = EXPLANATION;
                rs.MoveFirst();
                while (!rs.EOF)
                {
                 rs.Update("EXPLANATION", EXPLANATIONed);
                 rs.MoveNext();
                }
                 
                return rs;
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



        public DataSet savecharts(string d01, string d02, string d03, string d04, string d05, string d06, string d07, string d08, string d09, string d10, string d11, string d12, string d16, string d20, string d24, string d27, string d30, string d40, string d45, string d60, string kl, string astid, string astname, string client, string clientid, string dasha, string dob, string tob, string countr, string state, string district, string city, string group, string group_u, string prof, string sex, string mobile, string sunsetpre, string sunrise, string sunset, string sunrisenext, string dayofborth, string rashi, string constellation, string longitude, string latitude, string timezone, string dayduration, string nightduration, string balancedasha, string ClientEmailId, string pwd, string lagnarashi, string chartdetails, string matchwith, string lagnachart, string moonchart, string venuschart, string UserType, string RegUserId, string RegUserEmailId, string Cartid,string clientquery)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();

                orclcmd = GetCommand("SAVE_DATA_CHART", ref con);

                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pd01", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = d01;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pd02", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = d02;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("pd03", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = d03;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("pd04", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = d04;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("pd05", OracleType.Clob, 60000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = d05;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pd06", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = d06;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("pd07", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = d07;

                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pd08", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = d08;

                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pd09", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = d09;

                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("pd10", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = d10;

                orclcmd.Parameters.Add(prm10);


                OracleParameter prm11 = new OracleParameter("pd11", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = d11;

                orclcmd.Parameters.Add(prm11);


                OracleParameter prm12 = new OracleParameter("pd12", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = d12;

                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("pd16", OracleType.VarChar, 4000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = d16;

                orclcmd.Parameters.Add(prm13);
                OracleParameter prm14 = new OracleParameter("pd20", OracleType.VarChar, 4000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = d20;

                orclcmd.Parameters.Add(prm14);


                OracleParameter prm15 = new OracleParameter("pd24", OracleType.VarChar, 4000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = d24;

                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("pd27", OracleType.VarChar, 4000);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = d27;

                orclcmd.Parameters.Add(prm16);

                OracleParameter prm17 = new OracleParameter("pd30", OracleType.VarChar, 4000);
                prm17.Direction = ParameterDirection.Input;
                prm17.Value = d30;

                orclcmd.Parameters.Add(prm17);

                OracleParameter prm18 = new OracleParameter("pd40", OracleType.VarChar, 4000);
                prm18.Direction = ParameterDirection.Input;
                prm18.Value = d40;

                orclcmd.Parameters.Add(prm18);

                OracleParameter prm19 = new OracleParameter("pd45", OracleType.VarChar, 4000);
                prm19.Direction = ParameterDirection.Input;
                prm19.Value = d45;

                orclcmd.Parameters.Add(prm19);

                OracleParameter prm20 = new OracleParameter("pd60", OracleType.VarChar, 4000);
                prm20.Direction = ParameterDirection.Input;
                prm20.Value = d60;

                orclcmd.Parameters.Add(prm20);

                OracleParameter prm21 = new OracleParameter("pkl", OracleType.VarChar, 4000);
                prm21.Direction = ParameterDirection.Input;
                prm21.Value = kl;

                orclcmd.Parameters.Add(prm21);

                OracleParameter prm22 = new OracleParameter("pdid", OracleType.VarChar, 4000);
                prm22.Direction = ParameterDirection.Input;
                prm22.Value = astid;

                orclcmd.Parameters.Add(prm22);

                OracleParameter prm23 = new OracleParameter("pdname", OracleType.VarChar, 4000);
                prm23.Direction = ParameterDirection.Input;
                prm23.Value = astname;

                orclcmd.Parameters.Add(prm23);

                OracleParameter prm24 = new OracleParameter("pdclient", OracleType.VarChar, 4000);
                prm24.Direction = ParameterDirection.Input;
                prm24.Value = client;

                orclcmd.Parameters.Add(prm24);

                OracleParameter prm25 = new OracleParameter("pdclientid", OracleType.VarChar, 4000);
                prm25.Direction = ParameterDirection.Input;
                prm25.Value = clientid;

                orclcmd.Parameters.Add(prm25);

                OracleParameter prm26 = new OracleParameter("pdasha", OracleType.VarChar, 4000);
                prm26.Direction = ParameterDirection.Input;
                prm26.Value = dasha;

                orclcmd.Parameters.Add(prm26);


                OracleParameter prm27 = new OracleParameter("pdob", OracleType.VarChar, 4000);
                prm27.Direction = ParameterDirection.Input;
                prm27.Value = dob;

                orclcmd.Parameters.Add(prm27);

                OracleParameter prm28 = new OracleParameter("ptob", OracleType.VarChar, 4000);
                prm28.Direction = ParameterDirection.Input;
                prm28.Value = tob;

                orclcmd.Parameters.Add(prm28);


                OracleParameter prm29 = new OracleParameter("pcon", OracleType.VarChar, 4000);
                prm29.Direction = ParameterDirection.Input;
                prm29.Value = countr;

                orclcmd.Parameters.Add(prm29);


                OracleParameter prm30 = new OracleParameter("pstate", OracleType.VarChar, 4000);
                prm30.Direction = ParameterDirection.Input;
                prm30.Value = state;

                orclcmd.Parameters.Add(prm30);


                OracleParameter prm31 = new OracleParameter("pdist", OracleType.VarChar, 4000);
                prm31.Direction = ParameterDirection.Input;
                prm31.Value = district;

                orclcmd.Parameters.Add(prm31);


                OracleParameter prm32 = new OracleParameter("pcity", OracleType.VarChar, 4000);
                prm32.Direction = ParameterDirection.Input;
                prm32.Value = city;

                orclcmd.Parameters.Add(prm32);


                OracleParameter prm33 = new OracleParameter("pgroup", OracleType.VarChar, 4000);
                prm33.Direction = ParameterDirection.Input;
                prm33.Value = group;
                orclcmd.Parameters.Add(prm33);


                OracleParameter prm34 = new OracleParameter("pgroupu", OracleType.VarChar, 4000);
                prm34.Direction = ParameterDirection.Input;
                prm34.Value = group_u.ToUpper(); ;
                orclcmd.Parameters.Add(prm34);

                OracleParameter prm35 = new OracleParameter("pprof", OracleType.VarChar, 4000);
                prm35.Direction = ParameterDirection.Input;
                prm35.Value = prof;

                orclcmd.Parameters.Add(prm35);

                OracleParameter prm36 = new OracleParameter("psex", OracleType.VarChar, 4000);
                prm36.Direction = ParameterDirection.Input;
                prm36.Value = sex;

                orclcmd.Parameters.Add(prm36);

                OracleParameter prm37 = new OracleParameter("pmobile", OracleType.Number);
                prm37.Direction = ParameterDirection.Input;
                prm37.Value = mobile;
                orclcmd.Parameters.Add(prm37);

                OracleParameter prm38 = new OracleParameter("sunsetpre", OracleType.VarChar, 100);
                prm38.Direction = ParameterDirection.Input;
                prm38.Value = sunsetpre;
                orclcmd.Parameters.Add(prm38);

                OracleParameter prm39 = new OracleParameter("sunrise", OracleType.VarChar, 100);
                prm39.Direction = ParameterDirection.Input;
                prm39.Value = sunrise;
                orclcmd.Parameters.Add(prm39);

                OracleParameter prm40 = new OracleParameter("sunset", OracleType.VarChar, 100);
                prm40.Direction = ParameterDirection.Input;
                prm40.Value = sunset;
                orclcmd.Parameters.Add(prm40);

                OracleParameter prm41 = new OracleParameter("sunrisenext", OracleType.VarChar, 100);
                prm41.Direction = ParameterDirection.Input;
                prm41.Value = sunrisenext;
                orclcmd.Parameters.Add(prm41);

                OracleParameter prm42 = new OracleParameter("dayofborth", OracleType.VarChar, 100);
                prm42.Direction = ParameterDirection.Input;
                prm42.Value = dayofborth;
                orclcmd.Parameters.Add(prm42);

                OracleParameter prm43 = new OracleParameter("rashiname", OracleType.VarChar, 100);
                prm43.Direction = ParameterDirection.Input;
                prm43.Value = rashi;
                orclcmd.Parameters.Add(prm43);

                OracleParameter prm44 = new OracleParameter("constellationname", OracleType.VarChar, 100);
                prm44.Direction = ParameterDirection.Input;
                prm44.Value = constellation;
                orclcmd.Parameters.Add(prm44);

                OracleParameter prm45 = new OracleParameter("longitudeval", OracleType.VarChar, 100);
                prm45.Direction = ParameterDirection.Input;
                prm45.Value = longitude;
                orclcmd.Parameters.Add(prm45);

                OracleParameter prm46 = new OracleParameter("latitudeval", OracleType.VarChar, 100);
                prm46.Direction = ParameterDirection.Input;
                prm46.Value = latitude;
                orclcmd.Parameters.Add(prm46);

                OracleParameter prm47 = new OracleParameter("timezoneval", OracleType.VarChar, 100);
                prm47.Direction = ParameterDirection.Input;
                prm47.Value = timezone;
                orclcmd.Parameters.Add(prm47);

                OracleParameter prm48 = new OracleParameter("daydurationval", OracleType.VarChar, 100);
                prm48.Direction = ParameterDirection.Input;
                prm48.Value = dayduration;
                orclcmd.Parameters.Add(prm48);

                OracleParameter prm49 = new OracleParameter("nightdurationval", OracleType.VarChar, 100);
                prm49.Direction = ParameterDirection.Input;
                prm49.Value = nightduration;
                orclcmd.Parameters.Add(prm49);

                OracleParameter prm50 = new OracleParameter("balancedashaval", OracleType.VarChar, 200);
                prm50.Direction = ParameterDirection.Input;
                prm50.Value = balancedasha;
                orclcmd.Parameters.Add(prm50);

                OracleParameter prm51 = new OracleParameter("ClientEmailId", OracleType.VarChar, 200);
                prm51.Direction = ParameterDirection.Input;
                prm51.Value = ClientEmailId;
                orclcmd.Parameters.Add(prm51);

                OracleParameter prm52 = new OracleParameter("pwd", OracleType.VarChar, 200);
                prm52.Direction = ParameterDirection.Input;
                prm52.Value = pwd;
                orclcmd.Parameters.Add(prm52);

                OracleParameter prm53 = new OracleParameter("lagnarashi", OracleType.VarChar, 100);
                prm53.Direction = ParameterDirection.Input;
                prm53.Value = lagnarashi;
                orclcmd.Parameters.Add(prm53);

                OracleParameter prm54 = new OracleParameter("chartdetails", OracleType.VarChar, 4000);
                prm54.Direction = ParameterDirection.Input;
                prm54.Value = chartdetails;
                orclcmd.Parameters.Add(prm54);

                OracleParameter prm55 = new OracleParameter("matchwith", OracleType.VarChar, 50);
                prm55.Direction = ParameterDirection.Input;
                prm55.Value = matchwith;
                orclcmd.Parameters.Add(prm55);

                OracleParameter prm56 = new OracleParameter("lagnachart", OracleType.VarChar, 4000);
                prm56.Direction = ParameterDirection.Input;
                prm56.Value = lagnachart;
                orclcmd.Parameters.Add(prm56);

                OracleParameter prm57 = new OracleParameter("moonchart", OracleType.VarChar, 4000);
                prm57.Direction = ParameterDirection.Input;
                prm57.Value = moonchart;
                orclcmd.Parameters.Add(prm57);

                OracleParameter prm58 = new OracleParameter("venuschart", OracleType.VarChar, 4000);
                prm58.Direction = ParameterDirection.Input;
                prm58.Value = venuschart;
                orclcmd.Parameters.Add(prm58);

                OracleParameter prm59 = new OracleParameter("usertype", OracleType.VarChar, 10);
                prm59.Direction = ParameterDirection.Input;
                prm59.Value = UserType;
                orclcmd.Parameters.Add(prm59);

                OracleParameter prm60 = new OracleParameter("reguserid", OracleType.VarChar, 100);
                prm60.Direction = ParameterDirection.Input;
                prm60.Value = RegUserId;
                orclcmd.Parameters.Add(prm60);

                OracleParameter prm61 = new OracleParameter("reguseremailid", OracleType.VarChar, 100);
                prm61.Direction = ParameterDirection.Input;
                prm61.Value = RegUserEmailId;
                orclcmd.Parameters.Add(prm61);

                OracleParameter prm62 = new OracleParameter("cartid", OracleType.VarChar, 100);
                prm62.Direction = ParameterDirection.Input;
                prm62.Value = Cartid;
                orclcmd.Parameters.Add(prm62);

                OracleParameter prm63 = new OracleParameter("queryval", OracleType.VarChar, 4000);
                prm63.Direction = ParameterDirection.Input;
                prm63.Value = clientquery;
                orclcmd.Parameters.Add(prm63);
                
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

        public DataSet savecharts_enduser(string d01, string d02, string d03, string d04, string d05, string d06, string d07, string d08, string d09, string d10, string d11, string d12, string d16, string d20, string d24, string d27, string d30, string d40, string d45, string d60, string kl, string astid, string astname, string client, string clientid, string dasha, string dob, string tob, string countr, string state, string district, string city, string group, string group_u, string prof, string sex, string mobile, string sunsetpre, string sunrise, string sunset, string sunrisenext, string dayofborth, string rashi, string constellation, string longitude, string latitude, string timezone, string dayduration, string nightduration, string balancedasha, string ClientEmailId, string pwd, string lagnarashi, string chartdetails, string matchwith, string lagnachart, string moonchart, string venuschart, string UserType, string RegUserId, string RegUserEmailId, string Cartid, string AstrologerId)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("SAVE_DATA_CHART_ENDUSER", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pd01", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = d01;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pd02", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = d02;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("pd03", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = d03;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("pd04", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = d04;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("pd05", OracleType.Clob, 60000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = d05;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pd06", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = d06;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("pd07", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = d07;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pd08", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = d08;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pd09", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = d09;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("pd10", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = d10;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("pd11", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = d11;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("pd12", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = d12;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("pd16", OracleType.VarChar, 4000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = d16;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("pd20", OracleType.VarChar, 4000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = d20;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("pd24", OracleType.VarChar, 4000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = d24;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("pd27", OracleType.VarChar, 4000);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = d27;
                orclcmd.Parameters.Add(prm16);

                OracleParameter prm17 = new OracleParameter("pd30", OracleType.VarChar, 4000);
                prm17.Direction = ParameterDirection.Input;
                prm17.Value = d30;
                orclcmd.Parameters.Add(prm17);

                OracleParameter prm18 = new OracleParameter("pd40", OracleType.VarChar, 4000);
                prm18.Direction = ParameterDirection.Input;
                prm18.Value = d40;
                orclcmd.Parameters.Add(prm18);

                OracleParameter prm19 = new OracleParameter("pd45", OracleType.VarChar, 4000);
                prm19.Direction = ParameterDirection.Input;
                prm19.Value = d45;
                orclcmd.Parameters.Add(prm19);

                OracleParameter prm20 = new OracleParameter("pd60", OracleType.VarChar, 4000);
                prm20.Direction = ParameterDirection.Input;
                prm20.Value = d60;
                orclcmd.Parameters.Add(prm20);

                OracleParameter prm21 = new OracleParameter("pkl", OracleType.VarChar, 4000);
                prm21.Direction = ParameterDirection.Input;
                prm21.Value = kl;
                orclcmd.Parameters.Add(prm21);

                OracleParameter prm22 = new OracleParameter("pdid", OracleType.VarChar, 4000);
                prm22.Direction = ParameterDirection.Input;
                prm22.Value = astid;
                orclcmd.Parameters.Add(prm22);

                OracleParameter prm23 = new OracleParameter("pdname", OracleType.VarChar, 4000);
                prm23.Direction = ParameterDirection.Input;
                prm23.Value = astname;
                orclcmd.Parameters.Add(prm23);

                OracleParameter prm24 = new OracleParameter("pdclient", OracleType.VarChar, 4000);
                prm24.Direction = ParameterDirection.Input;
                prm24.Value = client;
                orclcmd.Parameters.Add(prm24);

                OracleParameter prm25 = new OracleParameter("pdclientid", OracleType.VarChar, 4000);
                prm25.Direction = ParameterDirection.Input;
                prm25.Value = clientid;
                orclcmd.Parameters.Add(prm25);

                OracleParameter prm26 = new OracleParameter("pdasha", OracleType.VarChar, 4000);
                prm26.Direction = ParameterDirection.Input;
                prm26.Value = dasha;
                orclcmd.Parameters.Add(prm26);

                OracleParameter prm27 = new OracleParameter("pdob", OracleType.VarChar, 4000);
                prm27.Direction = ParameterDirection.Input;
                prm27.Value = dob;
                orclcmd.Parameters.Add(prm27);

                OracleParameter prm28 = new OracleParameter("ptob", OracleType.VarChar, 4000);
                prm28.Direction = ParameterDirection.Input;
                prm28.Value = tob;
                orclcmd.Parameters.Add(prm28);

                OracleParameter prm29 = new OracleParameter("pcon", OracleType.VarChar, 4000);
                prm29.Direction = ParameterDirection.Input;
                prm29.Value = countr;
                orclcmd.Parameters.Add(prm29);

                OracleParameter prm30 = new OracleParameter("pstate", OracleType.VarChar, 4000);
                prm30.Direction = ParameterDirection.Input;
                prm30.Value = state;
                orclcmd.Parameters.Add(prm30);

                OracleParameter prm31 = new OracleParameter("pdist", OracleType.VarChar, 4000);
                prm31.Direction = ParameterDirection.Input;
                prm31.Value = district;
                orclcmd.Parameters.Add(prm31);

                OracleParameter prm32 = new OracleParameter("pcity", OracleType.VarChar, 4000);
                prm32.Direction = ParameterDirection.Input;
                prm32.Value = city;
                orclcmd.Parameters.Add(prm32);

                OracleParameter prm33 = new OracleParameter("pgroup", OracleType.VarChar, 4000);
                prm33.Direction = ParameterDirection.Input;
                prm33.Value = group;
                orclcmd.Parameters.Add(prm33);

                OracleParameter prm34 = new OracleParameter("pgroupu", OracleType.VarChar, 4000);
                prm34.Direction = ParameterDirection.Input;
                prm34.Value = group_u.ToUpper(); ;
                orclcmd.Parameters.Add(prm34);

                OracleParameter prm35 = new OracleParameter("pprof", OracleType.VarChar, 4000);
                prm35.Direction = ParameterDirection.Input;
                prm35.Value = prof;
                orclcmd.Parameters.Add(prm35);

                OracleParameter prm36 = new OracleParameter("psex", OracleType.VarChar, 4000);
                prm36.Direction = ParameterDirection.Input;
                prm36.Value = sex;
                orclcmd.Parameters.Add(prm36);

                OracleParameter prm37 = new OracleParameter("pmobile", OracleType.VarChar, 100);
                prm37.Direction = ParameterDirection.Input;
                prm37.Value = mobile;
                orclcmd.Parameters.Add(prm37);

                OracleParameter prm38 = new OracleParameter("sunsetpre", OracleType.VarChar, 100);
                prm38.Direction = ParameterDirection.Input;
                prm38.Value = sunsetpre;
                orclcmd.Parameters.Add(prm38);

                OracleParameter prm39 = new OracleParameter("sunrise", OracleType.VarChar, 100);
                prm39.Direction = ParameterDirection.Input;
                prm39.Value = sunrise;
                orclcmd.Parameters.Add(prm39);

                OracleParameter prm40 = new OracleParameter("sunset", OracleType.VarChar, 100);
                prm40.Direction = ParameterDirection.Input;
                prm40.Value = sunset;
                orclcmd.Parameters.Add(prm40);

                OracleParameter prm41 = new OracleParameter("sunrisenext", OracleType.VarChar, 100);
                prm41.Direction = ParameterDirection.Input;
                prm41.Value = sunrisenext;
                orclcmd.Parameters.Add(prm41);

                OracleParameter prm42 = new OracleParameter("dayofborth", OracleType.VarChar, 100);
                prm42.Direction = ParameterDirection.Input;
                prm42.Value = dayofborth;
                orclcmd.Parameters.Add(prm42);

                OracleParameter prm43 = new OracleParameter("rashiname", OracleType.VarChar, 100);
                prm43.Direction = ParameterDirection.Input;
                prm43.Value = rashi;
                orclcmd.Parameters.Add(prm43);

                OracleParameter prm44 = new OracleParameter("constellationname", OracleType.VarChar, 100);
                prm44.Direction = ParameterDirection.Input;
                prm44.Value = constellation;
                orclcmd.Parameters.Add(prm44);

                OracleParameter prm45 = new OracleParameter("longitudeval", OracleType.VarChar, 100);
                prm45.Direction = ParameterDirection.Input;
                prm45.Value = longitude;
                orclcmd.Parameters.Add(prm45);

                OracleParameter prm46 = new OracleParameter("latitudeval", OracleType.VarChar, 100);
                prm46.Direction = ParameterDirection.Input;
                prm46.Value = latitude;
                orclcmd.Parameters.Add(prm46);

                OracleParameter prm47 = new OracleParameter("timezoneval", OracleType.VarChar, 100);
                prm47.Direction = ParameterDirection.Input;
                prm47.Value = timezone;
                orclcmd.Parameters.Add(prm47);

                OracleParameter prm48 = new OracleParameter("daydurationval", OracleType.VarChar, 100);
                prm48.Direction = ParameterDirection.Input;
                prm48.Value = dayduration;
                orclcmd.Parameters.Add(prm48);

                OracleParameter prm49 = new OracleParameter("nightdurationval", OracleType.VarChar, 100);
                prm49.Direction = ParameterDirection.Input;
                prm49.Value = nightduration;
                orclcmd.Parameters.Add(prm49);

                OracleParameter prm50 = new OracleParameter("balancedashaval", OracleType.VarChar, 200);
                prm50.Direction = ParameterDirection.Input;
                prm50.Value = balancedasha;
                orclcmd.Parameters.Add(prm50);

                OracleParameter prm51 = new OracleParameter("ClientEmailId", OracleType.VarChar, 200);
                prm51.Direction = ParameterDirection.Input;
                prm51.Value = ClientEmailId;
                orclcmd.Parameters.Add(prm51);

                OracleParameter prm52 = new OracleParameter("pwd", OracleType.VarChar, 200);
                prm52.Direction = ParameterDirection.Input;
                prm52.Value = pwd;
                orclcmd.Parameters.Add(prm52);

                OracleParameter prm53 = new OracleParameter("lagnarashi", OracleType.VarChar, 100);
                prm53.Direction = ParameterDirection.Input;
                prm53.Value = lagnarashi;
                orclcmd.Parameters.Add(prm53);

                OracleParameter prm54 = new OracleParameter("chartdetails", OracleType.VarChar, 4000);
                prm54.Direction = ParameterDirection.Input;
                prm54.Value = chartdetails;
                orclcmd.Parameters.Add(prm54);

                OracleParameter prm55 = new OracleParameter("matchwith", OracleType.VarChar, 50);
                prm55.Direction = ParameterDirection.Input;
                prm55.Value = matchwith;
                orclcmd.Parameters.Add(prm55);

                OracleParameter prm56 = new OracleParameter("lagnachart", OracleType.VarChar, 4000);
                prm56.Direction = ParameterDirection.Input;
                prm56.Value = lagnachart;
                orclcmd.Parameters.Add(prm56);

                OracleParameter prm57 = new OracleParameter("moonchart", OracleType.VarChar, 4000);
                prm57.Direction = ParameterDirection.Input;
                prm57.Value = moonchart;
                orclcmd.Parameters.Add(prm57);

                OracleParameter prm58 = new OracleParameter("venuschart", OracleType.VarChar, 4000);
                prm58.Direction = ParameterDirection.Input;
                prm58.Value = venuschart;
                orclcmd.Parameters.Add(prm58);

                OracleParameter prm59 = new OracleParameter("usertype", OracleType.VarChar, 10);
                prm59.Direction = ParameterDirection.Input;
                prm59.Value = UserType;
                orclcmd.Parameters.Add(prm59);

                OracleParameter prm60 = new OracleParameter("reguserid", OracleType.VarChar, 100);
                prm60.Direction = ParameterDirection.Input;
                prm60.Value = RegUserId;
                orclcmd.Parameters.Add(prm60);

                OracleParameter prm61 = new OracleParameter("reguseremailid", OracleType.VarChar, 100);
                prm61.Direction = ParameterDirection.Input;
                prm61.Value = RegUserEmailId;
                orclcmd.Parameters.Add(prm61);

                OracleParameter prm62 = new OracleParameter("cartid", OracleType.VarChar, 100);
                prm62.Direction = ParameterDirection.Input;
                prm62.Value = Cartid;
                orclcmd.Parameters.Add(prm62);

                OracleParameter prm63 = new OracleParameter("astrologerid", OracleType.VarChar, 20);
                prm63.Direction = ParameterDirection.Input;
                prm63.Value = AstrologerId;
                orclcmd.Parameters.Add(prm63);
                
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



        public DataSet PublishUnpublishSignificators(string key, string key1, string housev,string status,string groupid)
        {
            OracleConnection con;
            OracleCommand cmd;
            con = GetConnection();
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            try
            {
                con.Open();
                cmd = GetCommand("AST_PUBLISH_SIGNIFICATORS", ref con);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pkeys", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = key;
                cmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pkeys1", OracleType.Clob, 32000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = key1;
                cmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("phouse", OracleType.Clob, 32000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = housev;
                cmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("status_val", OracleType.VarChar, 1);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = status;
                cmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("grouptype", OracleType.VarChar, 10);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = groupid;
                cmd.Parameters.Add(prm5);

                cmd.Parameters.Add("outflag", OracleType.Cursor);
                cmd.Parameters["outflag"].Direction = ParameterDirection.Output;

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


        public DataSet showextnvalue_natal(string exten, string extenvalue)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("NATAL_SIGNIFICATOR_SEARCH", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;
                OracleParameter prm1 = new OracleParameter("pextent", OracleType.VarChar, 2000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = exten;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pextentvalue", OracleType.VarChar, 2000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = extenvalue;
                orclcmd.Parameters.Add(prm2);

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



        public DataSet savecharts_consultuser(string d01, string d02, string d03, string d04, string d05, string d06, string d07, string d08, string d09, string d10, string d11, string d12, string d16, string d20, string d24, string d27, string d30, string d40, string d45, string d60, string kl, string astid, string astname, string client, string clientid, string dasha, string dob, string tob, string countr, string state, string district, string city, string group, string group_u, string prof, string sex, string mobile, string sunsetpre, string sunrise, string sunset, string sunrisenext, string dayofborth, string rashi, string constellation, string longitude, string latitude, string timezone, string dayduration, string nightduration, string balancedasha, string ClientEmailId, string pwd, string lagnarashi, string chartdetails, string matchwith, string lagnachart, string moonchart, string venuschart, string UserType, string RegUserId, string RegUserEmailId, string Cartid)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("SAVE_DATA_CHART_CONSULTUSER", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pd01", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = d01;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pd02", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = d02;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("pd03", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = d03;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("pd04", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = d04;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("pd05", OracleType.Clob, 60000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = d05;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pd06", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = d06;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("pd07", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = d07;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pd08", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = d08;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pd09", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = d09;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("pd10", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = d10;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("pd11", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = d11;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("pd12", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = d12;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("pd16", OracleType.VarChar, 4000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = d16;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("pd20", OracleType.VarChar, 4000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = d20;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("pd24", OracleType.VarChar, 4000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = d24;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("pd27", OracleType.VarChar, 4000);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = d27;
                orclcmd.Parameters.Add(prm16);

                OracleParameter prm17 = new OracleParameter("pd30", OracleType.VarChar, 4000);
                prm17.Direction = ParameterDirection.Input;
                prm17.Value = d30;
                orclcmd.Parameters.Add(prm17);

                OracleParameter prm18 = new OracleParameter("pd40", OracleType.VarChar, 4000);
                prm18.Direction = ParameterDirection.Input;
                prm18.Value = d40;
                orclcmd.Parameters.Add(prm18);

                OracleParameter prm19 = new OracleParameter("pd45", OracleType.VarChar, 4000);
                prm19.Direction = ParameterDirection.Input;
                prm19.Value = d45;
                orclcmd.Parameters.Add(prm19);

                OracleParameter prm20 = new OracleParameter("pd60", OracleType.VarChar, 4000);
                prm20.Direction = ParameterDirection.Input;
                prm20.Value = d60;
                orclcmd.Parameters.Add(prm20);

                OracleParameter prm21 = new OracleParameter("pkl", OracleType.VarChar, 4000);
                prm21.Direction = ParameterDirection.Input;
                prm21.Value = kl;
                orclcmd.Parameters.Add(prm21);

                OracleParameter prm22 = new OracleParameter("pdid", OracleType.VarChar, 4000);
                prm22.Direction = ParameterDirection.Input;
                prm22.Value = astid;
                orclcmd.Parameters.Add(prm22);

                OracleParameter prm23 = new OracleParameter("pdname", OracleType.VarChar, 4000);
                prm23.Direction = ParameterDirection.Input;
                prm23.Value = astname;
                orclcmd.Parameters.Add(prm23);

                OracleParameter prm24 = new OracleParameter("pdclient", OracleType.VarChar, 4000);
                prm24.Direction = ParameterDirection.Input;
                prm24.Value = client;
                orclcmd.Parameters.Add(prm24);

                OracleParameter prm25 = new OracleParameter("pdclientid", OracleType.VarChar, 4000);
                prm25.Direction = ParameterDirection.Input;
                prm25.Value = clientid;
                orclcmd.Parameters.Add(prm25);

                OracleParameter prm26 = new OracleParameter("pdasha", OracleType.VarChar, 4000);
                prm26.Direction = ParameterDirection.Input;
                prm26.Value = dasha;
                orclcmd.Parameters.Add(prm26);


                OracleParameter prm27 = new OracleParameter("pdob", OracleType.VarChar, 4000);
                prm27.Direction = ParameterDirection.Input;
                prm27.Value = dob;
                orclcmd.Parameters.Add(prm27);

                OracleParameter prm28 = new OracleParameter("ptob", OracleType.VarChar, 4000);
                prm28.Direction = ParameterDirection.Input;
                prm28.Value = tob;
                orclcmd.Parameters.Add(prm28);

                OracleParameter prm29 = new OracleParameter("pcon", OracleType.VarChar, 4000);
                prm29.Direction = ParameterDirection.Input;
                prm29.Value = countr;
                orclcmd.Parameters.Add(prm29);

                OracleParameter prm30 = new OracleParameter("pstate", OracleType.VarChar, 4000);
                prm30.Direction = ParameterDirection.Input;
                prm30.Value = state;
                orclcmd.Parameters.Add(prm30);

                OracleParameter prm31 = new OracleParameter("pdist", OracleType.VarChar, 4000);
                prm31.Direction = ParameterDirection.Input;
                prm31.Value = district;
                orclcmd.Parameters.Add(prm31);

                OracleParameter prm32 = new OracleParameter("pcity", OracleType.VarChar, 4000);
                prm32.Direction = ParameterDirection.Input;
                prm32.Value = city;
                orclcmd.Parameters.Add(prm32);

                OracleParameter prm33 = new OracleParameter("pgroup", OracleType.VarChar, 4000);
                prm33.Direction = ParameterDirection.Input;
                prm33.Value = group;
                orclcmd.Parameters.Add(prm33);

                OracleParameter prm34 = new OracleParameter("pgroupu", OracleType.VarChar, 4000);
                prm34.Direction = ParameterDirection.Input;
                prm34.Value = group_u;
                orclcmd.Parameters.Add(prm34);

                OracleParameter prm35 = new OracleParameter("pprof", OracleType.VarChar, 4000);
                prm35.Direction = ParameterDirection.Input;
                prm35.Value = prof;
                orclcmd.Parameters.Add(prm35);

                OracleParameter prm36 = new OracleParameter("psex", OracleType.VarChar, 4000);
                prm36.Direction = ParameterDirection.Input;
                prm36.Value = sex;
                orclcmd.Parameters.Add(prm36);

                OracleParameter prm37 = new OracleParameter("pmobile", OracleType.Number);
                prm37.Direction = ParameterDirection.Input;
                prm37.Value = mobile;
                orclcmd.Parameters.Add(prm37);

                OracleParameter prm38 = new OracleParameter("sunsetpre", OracleType.VarChar, 100);
                prm38.Direction = ParameterDirection.Input;
                prm38.Value = sunsetpre;
                orclcmd.Parameters.Add(prm38);

                OracleParameter prm39 = new OracleParameter("sunrise", OracleType.VarChar, 100);
                prm39.Direction = ParameterDirection.Input;
                prm39.Value = sunrise;
                orclcmd.Parameters.Add(prm39);

                OracleParameter prm40 = new OracleParameter("sunset", OracleType.VarChar, 100);
                prm40.Direction = ParameterDirection.Input;
                prm40.Value = sunset;
                orclcmd.Parameters.Add(prm40);

                OracleParameter prm41 = new OracleParameter("sunrisenext", OracleType.VarChar, 100);
                prm41.Direction = ParameterDirection.Input;
                prm41.Value = sunrisenext;
                orclcmd.Parameters.Add(prm41);

                OracleParameter prm42 = new OracleParameter("dayofborth", OracleType.VarChar, 100);
                prm42.Direction = ParameterDirection.Input;
                prm42.Value = dayofborth;
                orclcmd.Parameters.Add(prm42);

                OracleParameter prm43 = new OracleParameter("rashiname", OracleType.VarChar, 100);
                prm43.Direction = ParameterDirection.Input;
                prm43.Value = rashi;
                orclcmd.Parameters.Add(prm43);

                OracleParameter prm44 = new OracleParameter("constellationname", OracleType.VarChar, 100);
                prm44.Direction = ParameterDirection.Input;
                prm44.Value = constellation;
                orclcmd.Parameters.Add(prm44);

                OracleParameter prm45 = new OracleParameter("longitudeval", OracleType.VarChar, 100);
                prm45.Direction = ParameterDirection.Input;
                prm45.Value = longitude;
                orclcmd.Parameters.Add(prm45);

                OracleParameter prm46 = new OracleParameter("latitudeval", OracleType.VarChar, 100);
                prm46.Direction = ParameterDirection.Input;
                prm46.Value = latitude;
                orclcmd.Parameters.Add(prm46);

                OracleParameter prm47 = new OracleParameter("timezoneval", OracleType.VarChar, 100);
                prm47.Direction = ParameterDirection.Input;
                prm47.Value = timezone;
                orclcmd.Parameters.Add(prm47);

                OracleParameter prm48 = new OracleParameter("daydurationval", OracleType.VarChar, 100);
                prm48.Direction = ParameterDirection.Input;
                prm48.Value = dayduration;
                orclcmd.Parameters.Add(prm48);

                OracleParameter prm49 = new OracleParameter("nightdurationval", OracleType.VarChar, 100);
                prm49.Direction = ParameterDirection.Input;
                prm49.Value = nightduration;
                orclcmd.Parameters.Add(prm49);

                OracleParameter prm50 = new OracleParameter("balancedashaval", OracleType.VarChar, 200);
                prm50.Direction = ParameterDirection.Input;
                prm50.Value = balancedasha;
                orclcmd.Parameters.Add(prm50);

                OracleParameter prm51 = new OracleParameter("ClientEmailId", OracleType.VarChar, 200);
                prm51.Direction = ParameterDirection.Input;
                prm51.Value = ClientEmailId;
                orclcmd.Parameters.Add(prm51);

                OracleParameter prm52 = new OracleParameter("pwd", OracleType.VarChar, 200);
                prm52.Direction = ParameterDirection.Input;
                prm52.Value = pwd;
                orclcmd.Parameters.Add(prm52);

                OracleParameter prm53 = new OracleParameter("lagnarashi", OracleType.VarChar, 100);
                prm53.Direction = ParameterDirection.Input;
                prm53.Value = lagnarashi;
                orclcmd.Parameters.Add(prm53);

                OracleParameter prm54 = new OracleParameter("chartdetails", OracleType.VarChar, 4000);
                prm54.Direction = ParameterDirection.Input;
                prm54.Value = chartdetails;
                orclcmd.Parameters.Add(prm54);

                OracleParameter prm55 = new OracleParameter("matchwith", OracleType.VarChar, 50);
                prm55.Direction = ParameterDirection.Input;
                prm55.Value = matchwith;
                orclcmd.Parameters.Add(prm55);

                OracleParameter prm56 = new OracleParameter("lagnachart", OracleType.VarChar, 4000);
                prm56.Direction = ParameterDirection.Input;
                prm56.Value = lagnachart;
                orclcmd.Parameters.Add(prm56);

                OracleParameter prm57 = new OracleParameter("moonchart", OracleType.VarChar, 4000);
                prm57.Direction = ParameterDirection.Input;
                prm57.Value = moonchart;
                orclcmd.Parameters.Add(prm57);

                OracleParameter prm58 = new OracleParameter("venuschart", OracleType.VarChar, 4000);
                prm58.Direction = ParameterDirection.Input;
                prm58.Value = venuschart;
                orclcmd.Parameters.Add(prm58);

                OracleParameter prm59 = new OracleParameter("usertype", OracleType.VarChar, 10);
                prm59.Direction = ParameterDirection.Input;
                prm59.Value = UserType;
                orclcmd.Parameters.Add(prm59);

                OracleParameter prm60 = new OracleParameter("reguserid", OracleType.VarChar, 100);
                prm60.Direction = ParameterDirection.Input;
                prm60.Value = RegUserId;
                orclcmd.Parameters.Add(prm60);

                OracleParameter prm61 = new OracleParameter("reguseremailid", OracleType.VarChar, 100);
                prm61.Direction = ParameterDirection.Input;
                prm61.Value = RegUserEmailId;
                orclcmd.Parameters.Add(prm61);

                OracleParameter prm62 = new OracleParameter("cartid", OracleType.VarChar, 100);
                prm62.Direction = ParameterDirection.Input;
                prm62.Value = Cartid;
                orclcmd.Parameters.Add(prm62);
                
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


        public DataSet savecharts_enduserTemp(string d01, string d02, string d03, string d04, string d05, string d06, string d07, string d08, string d09, string d10, string d11, string d12, string d16, string d20, string d24, string d27, string d30, string d40, string d45, string d60, string kl, string astid, string astname, string client, string clientid, string dasha, string dob, string tob, string countr, string state, string district, string city, string group, string group_u, string prof, string sex, string mobile, string sunsetpre, string sunrise, string sunset, string sunrisenext, string dayofborth, string rashi, string constellation, string longitude, string latitude, string timezone, string dayduration, string nightduration, string balancedasha, string ClientEmailId, string pwd, string lagnarashi, string chartdetails, string matchwith, string lagnachart, string moonchart, string venuschart, string UserType, string RegUserId, string RegUserEmailId, string Cartid, string AstrologerId)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("SAVE_DATA_CHART_TEMP", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("pd01", OracleType.VarChar, 4000);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = d01;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("pd02", OracleType.VarChar, 4000);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = d02;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3 = new OracleParameter("pd03", OracleType.VarChar, 4000);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = d03;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("pd04", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = d04;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("pd05", OracleType.Clob, 60000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = d05;
                orclcmd.Parameters.Add(prm5);

                OracleParameter prm6 = new OracleParameter("pd06", OracleType.VarChar, 4000);
                prm6.Direction = ParameterDirection.Input;
                prm6.Value = d06;
                orclcmd.Parameters.Add(prm6);

                OracleParameter prm7 = new OracleParameter("pd07", OracleType.VarChar, 4000);
                prm7.Direction = ParameterDirection.Input;
                prm7.Value = d07;
                orclcmd.Parameters.Add(prm7);

                OracleParameter prm8 = new OracleParameter("pd08", OracleType.VarChar, 4000);
                prm8.Direction = ParameterDirection.Input;
                prm8.Value = d08;
                orclcmd.Parameters.Add(prm8);

                OracleParameter prm9 = new OracleParameter("pd09", OracleType.VarChar, 4000);
                prm9.Direction = ParameterDirection.Input;
                prm9.Value = d09;
                orclcmd.Parameters.Add(prm9);

                OracleParameter prm10 = new OracleParameter("pd10", OracleType.VarChar, 4000);
                prm10.Direction = ParameterDirection.Input;
                prm10.Value = d10;
                orclcmd.Parameters.Add(prm10);

                OracleParameter prm11 = new OracleParameter("pd11", OracleType.VarChar, 4000);
                prm11.Direction = ParameterDirection.Input;
                prm11.Value = d11;
                orclcmd.Parameters.Add(prm11);

                OracleParameter prm12 = new OracleParameter("pd12", OracleType.VarChar, 4000);
                prm12.Direction = ParameterDirection.Input;
                prm12.Value = d12;
                orclcmd.Parameters.Add(prm12);

                OracleParameter prm13 = new OracleParameter("pd16", OracleType.VarChar, 4000);
                prm13.Direction = ParameterDirection.Input;
                prm13.Value = d16;
                orclcmd.Parameters.Add(prm13);

                OracleParameter prm14 = new OracleParameter("pd20", OracleType.VarChar, 4000);
                prm14.Direction = ParameterDirection.Input;
                prm14.Value = d20;
                orclcmd.Parameters.Add(prm14);

                OracleParameter prm15 = new OracleParameter("pd24", OracleType.VarChar, 4000);
                prm15.Direction = ParameterDirection.Input;
                prm15.Value = d24;
                orclcmd.Parameters.Add(prm15);

                OracleParameter prm16 = new OracleParameter("pd27", OracleType.VarChar, 4000);
                prm16.Direction = ParameterDirection.Input;
                prm16.Value = d27;
                orclcmd.Parameters.Add(prm16);

                OracleParameter prm17 = new OracleParameter("pd30", OracleType.VarChar, 4000);
                prm17.Direction = ParameterDirection.Input;
                prm17.Value = d30;
                orclcmd.Parameters.Add(prm17);

                OracleParameter prm18 = new OracleParameter("pd40", OracleType.VarChar, 4000);
                prm18.Direction = ParameterDirection.Input;
                prm18.Value = d40;
                orclcmd.Parameters.Add(prm18);

                OracleParameter prm19 = new OracleParameter("pd45", OracleType.VarChar, 4000);
                prm19.Direction = ParameterDirection.Input;
                prm19.Value = d45;
                orclcmd.Parameters.Add(prm19);

                OracleParameter prm20 = new OracleParameter("pd60", OracleType.VarChar, 4000);
                prm20.Direction = ParameterDirection.Input;
                prm20.Value = d60;
                orclcmd.Parameters.Add(prm20);

                OracleParameter prm21 = new OracleParameter("pkl", OracleType.VarChar, 4000);
                prm21.Direction = ParameterDirection.Input;
                prm21.Value = kl;
                orclcmd.Parameters.Add(prm21);

                OracleParameter prm22 = new OracleParameter("pdid", OracleType.VarChar, 4000);
                prm22.Direction = ParameterDirection.Input;
                prm22.Value = astid;
                orclcmd.Parameters.Add(prm22);

                OracleParameter prm23 = new OracleParameter("pdname", OracleType.VarChar, 4000);
                prm23.Direction = ParameterDirection.Input;
                prm23.Value = astname;
                orclcmd.Parameters.Add(prm23);

                OracleParameter prm24 = new OracleParameter("pdclient", OracleType.VarChar, 4000);
                prm24.Direction = ParameterDirection.Input;
                prm24.Value = client;
                orclcmd.Parameters.Add(prm24);

                OracleParameter prm25 = new OracleParameter("pdclientid", OracleType.VarChar, 4000);
                prm25.Direction = ParameterDirection.Input;
                prm25.Value = clientid;
                orclcmd.Parameters.Add(prm25);

                OracleParameter prm26 = new OracleParameter("pdasha", OracleType.VarChar, 4000);
                prm26.Direction = ParameterDirection.Input;
                prm26.Value = dasha;
                orclcmd.Parameters.Add(prm26);

                OracleParameter prm27 = new OracleParameter("pdob", OracleType.VarChar, 4000);
                prm27.Direction = ParameterDirection.Input;
                prm27.Value = dob;
                orclcmd.Parameters.Add(prm27);

                OracleParameter prm28 = new OracleParameter("ptob", OracleType.VarChar, 4000);
                prm28.Direction = ParameterDirection.Input;
                prm28.Value = tob;
                orclcmd.Parameters.Add(prm28);

                OracleParameter prm29 = new OracleParameter("pcon", OracleType.VarChar, 4000);
                prm29.Direction = ParameterDirection.Input;
                prm29.Value = countr;
                orclcmd.Parameters.Add(prm29);

                OracleParameter prm30 = new OracleParameter("pstate", OracleType.VarChar, 4000);
                prm30.Direction = ParameterDirection.Input;
                prm30.Value = state;
                orclcmd.Parameters.Add(prm30);

                OracleParameter prm31 = new OracleParameter("pdist", OracleType.VarChar, 4000);
                prm31.Direction = ParameterDirection.Input;
                prm31.Value = district;
                orclcmd.Parameters.Add(prm31);

                OracleParameter prm32 = new OracleParameter("pcity", OracleType.VarChar, 4000);
                prm32.Direction = ParameterDirection.Input;
                prm32.Value = city;
                orclcmd.Parameters.Add(prm32);

                OracleParameter prm33 = new OracleParameter("pgroup", OracleType.VarChar, 4000);
                prm33.Direction = ParameterDirection.Input;
                prm33.Value = group;
                orclcmd.Parameters.Add(prm33);

                OracleParameter prm34 = new OracleParameter("pgroupu", OracleType.VarChar, 4000);
                prm34.Direction = ParameterDirection.Input;
                prm34.Value = group_u.ToUpper(); ;
                orclcmd.Parameters.Add(prm34);

                OracleParameter prm35 = new OracleParameter("pprof", OracleType.VarChar, 4000);
                prm35.Direction = ParameterDirection.Input;
                prm35.Value = prof;
                orclcmd.Parameters.Add(prm35);

                OracleParameter prm36 = new OracleParameter("psex", OracleType.VarChar, 4000);
                prm36.Direction = ParameterDirection.Input;
                prm36.Value = sex;
                orclcmd.Parameters.Add(prm36);

                OracleParameter prm37 = new OracleParameter("pmobile", OracleType.VarChar, 100);
                prm37.Direction = ParameterDirection.Input;
                prm37.Value = mobile;
                orclcmd.Parameters.Add(prm37);

                OracleParameter prm38 = new OracleParameter("sunsetpre", OracleType.VarChar, 100);
                prm38.Direction = ParameterDirection.Input;
                prm38.Value = sunsetpre;
                orclcmd.Parameters.Add(prm38);

                OracleParameter prm39 = new OracleParameter("sunrise", OracleType.VarChar, 100);
                prm39.Direction = ParameterDirection.Input;
                prm39.Value = sunrise;
                orclcmd.Parameters.Add(prm39);

                OracleParameter prm40 = new OracleParameter("sunset", OracleType.VarChar, 100);
                prm40.Direction = ParameterDirection.Input;
                prm40.Value = sunset;
                orclcmd.Parameters.Add(prm40);

                OracleParameter prm41 = new OracleParameter("sunrisenext", OracleType.VarChar, 100);
                prm41.Direction = ParameterDirection.Input;
                prm41.Value = sunrisenext;
                orclcmd.Parameters.Add(prm41);

                OracleParameter prm42 = new OracleParameter("dayofborth", OracleType.VarChar, 100);
                prm42.Direction = ParameterDirection.Input;
                prm42.Value = dayofborth;
                orclcmd.Parameters.Add(prm42);

                OracleParameter prm43 = new OracleParameter("rashiname", OracleType.VarChar, 100);
                prm43.Direction = ParameterDirection.Input;
                prm43.Value = rashi;
                orclcmd.Parameters.Add(prm43);

                OracleParameter prm44 = new OracleParameter("constellationname", OracleType.VarChar, 100);
                prm44.Direction = ParameterDirection.Input;
                prm44.Value = constellation;
                orclcmd.Parameters.Add(prm44);

                OracleParameter prm45 = new OracleParameter("longitudeval", OracleType.VarChar, 100);
                prm45.Direction = ParameterDirection.Input;
                prm45.Value = longitude;
                orclcmd.Parameters.Add(prm45);

                OracleParameter prm46 = new OracleParameter("latitudeval", OracleType.VarChar, 100);
                prm46.Direction = ParameterDirection.Input;
                prm46.Value = latitude;
                orclcmd.Parameters.Add(prm46);

                OracleParameter prm47 = new OracleParameter("timezoneval", OracleType.VarChar, 100);
                prm47.Direction = ParameterDirection.Input;
                prm47.Value = timezone;
                orclcmd.Parameters.Add(prm47);

                OracleParameter prm48 = new OracleParameter("daydurationval", OracleType.VarChar, 100);
                prm48.Direction = ParameterDirection.Input;
                prm48.Value = dayduration;
                orclcmd.Parameters.Add(prm48);

                OracleParameter prm49 = new OracleParameter("nightdurationval", OracleType.VarChar, 100);
                prm49.Direction = ParameterDirection.Input;
                prm49.Value = nightduration;
                orclcmd.Parameters.Add(prm49);

                OracleParameter prm50 = new OracleParameter("balancedashaval", OracleType.VarChar, 200);
                prm50.Direction = ParameterDirection.Input;
                prm50.Value = balancedasha;
                orclcmd.Parameters.Add(prm50);

                OracleParameter prm51 = new OracleParameter("ClientEmailId", OracleType.VarChar, 200);
                prm51.Direction = ParameterDirection.Input;
                prm51.Value = ClientEmailId;
                orclcmd.Parameters.Add(prm51);

                OracleParameter prm52 = new OracleParameter("pwd", OracleType.VarChar, 200);
                prm52.Direction = ParameterDirection.Input;
                prm52.Value = pwd;
                orclcmd.Parameters.Add(prm52);

                OracleParameter prm53 = new OracleParameter("lagnarashi", OracleType.VarChar, 100);
                prm53.Direction = ParameterDirection.Input;
                prm53.Value = lagnarashi;
                orclcmd.Parameters.Add(prm53);

                OracleParameter prm54 = new OracleParameter("chartdetails", OracleType.VarChar, 4000);
                prm54.Direction = ParameterDirection.Input;
                prm54.Value = chartdetails;
                orclcmd.Parameters.Add(prm54);

                OracleParameter prm55 = new OracleParameter("matchwith", OracleType.VarChar, 50);
                prm55.Direction = ParameterDirection.Input;
                prm55.Value = matchwith;
                orclcmd.Parameters.Add(prm55);

                OracleParameter prm56 = new OracleParameter("lagnachart", OracleType.VarChar, 4000);
                prm56.Direction = ParameterDirection.Input;
                prm56.Value = lagnachart;
                orclcmd.Parameters.Add(prm56);

                OracleParameter prm57 = new OracleParameter("moonchart", OracleType.VarChar, 4000);
                prm57.Direction = ParameterDirection.Input;
                prm57.Value = moonchart;
                orclcmd.Parameters.Add(prm57);

                OracleParameter prm58 = new OracleParameter("venuschart", OracleType.VarChar, 4000);
                prm58.Direction = ParameterDirection.Input;
                prm58.Value = venuschart;
                orclcmd.Parameters.Add(prm58);

                OracleParameter prm59 = new OracleParameter("usertype", OracleType.VarChar, 10);
                prm59.Direction = ParameterDirection.Input;
                prm59.Value = UserType;
                orclcmd.Parameters.Add(prm59);

                OracleParameter prm60 = new OracleParameter("reguserid", OracleType.VarChar, 100);
                prm60.Direction = ParameterDirection.Input;
                prm60.Value = RegUserId;
                orclcmd.Parameters.Add(prm60);

                OracleParameter prm61 = new OracleParameter("reguseremailid", OracleType.VarChar, 100);
                prm61.Direction = ParameterDirection.Input;
                prm61.Value = RegUserEmailId;
                orclcmd.Parameters.Add(prm61);

                OracleParameter prm62 = new OracleParameter("cartid", OracleType.VarChar, 100);
                prm62.Direction = ParameterDirection.Input;
                prm62.Value = Cartid;
                orclcmd.Parameters.Add(prm62);

                OracleParameter prm63 = new OracleParameter("astrologerid", OracleType.VarChar, 20);
                prm63.Direction = ParameterDirection.Input;
                prm63.Value = AstrologerId;
                orclcmd.Parameters.Add(prm63);

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



    }

}
   
