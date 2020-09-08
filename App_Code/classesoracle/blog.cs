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
    /// Summary description for blog
    /// </summary>
    public class blog : orclconnection
    {
        public blog()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public DataSet GetBlogList(string groupid, string flag ,string Title , string Active)
        {
            OracleConnection con = GetConnection();
            OracleDataAdapter da = new OracleDataAdapter();
            DataSet ds = new DataSet();
            OracleCommand orclcmd;
            try
            {
                con.Open();
                orclcmd = GetCommand("AST_GET_BLOGS", ref con);
                orclcmd.CommandType = CommandType.StoredProcedure;

                OracleParameter prm1 = new OracleParameter("BLOGID", OracleType.VarChar, 200);
                prm1.Direction = ParameterDirection.Input;
                prm1.Value = groupid;
                orclcmd.Parameters.Add(prm1);

                OracleParameter prm2 = new OracleParameter("GROUPID", OracleType.VarChar, 10);
                prm2.Direction = ParameterDirection.Input;
                prm2.Value = groupid;
                orclcmd.Parameters.Add(prm2);

                OracleParameter prm3= new OracleParameter("FLAG", OracleType.VarChar, 100);
                prm3.Direction = ParameterDirection.Input;
                prm3.Value = flag;
                orclcmd.Parameters.Add(prm3);

                OracleParameter prm4 = new OracleParameter("P_TITLE", OracleType.VarChar, 4000);
                prm4.Direction = ParameterDirection.Input;
                prm4.Value = Title;
                orclcmd.Parameters.Add(prm4);

                OracleParameter prm5 = new OracleParameter("P_ACTIVE", OracleType.VarChar, 4000);
                prm5.Direction = ParameterDirection.Input;
                prm5.Value = Active;
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
    }
}