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

public partial class astroextentions : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(astroextentions));
        DataSet ds1 = new DataSet();
        ds1.ReadXml(Server.MapPath("ast.xml/extentions.xml"));
        tblfields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        fields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        hiddendateformat.Value = "dd/mm/yyyy";
             
        if (!Page.IsPostBack)
        {
            

         
            btnNew.Attributes.Add("onclick", "javascript:return EnableOnNew();");
            btnSave.Attributes.Add("onclick", "javascript:return Save_Records();");
            btnExecute.Attributes.Add("onclick", "javascript:return executequery(querytype)");
            btnQuery.Attributes.Add("onclick", "javascript:return enablequery()");
            btnCancel.Attributes.Add("onclick", "javascript:return click_on_cancel();");
            btnExit.Attributes.Add("onclick", "javascript:return Exit();");
            btnDelete.Attributes.Add("onclick", "javascript:return delete_data();");
            btnfirst.Attributes.Add("onclick", "javascript:return fnd_first_record()");
            btnnext.Attributes.Add("onclick", "javascript:return fnd_next_record()");
            btnprevious.Attributes.Add("onclick", "javascript:return fnd_pre_record()");
            btnlast.Attributes.Add("onclick", "javascript:return fnd_last_record()");
            btnModify.Attributes.Add("onclick", "javascript:return modifydata()");
        }
        txtextentions.Enabled = false;
        
    }



    [Ajax.AjaxMethod]
    public string save(string EXTENTIONS)
    {
        try
        {
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {


                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                ds = country.save_extentions(EXTENTIONS);
            }
            return "true";
        }
        catch (Exception ex)
        {
            return Convert.ToString(ex.Message);

        }

    }


    [Ajax.AjaxMethod]
    public DataSet Modifydata1(string casetxtextentions, string hiddenmodtxtextentions)
    {
        
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {


                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                ds = country.Modifydata1(casetxtextentions, hiddenmodtxtextentions);

            }
            return ds;

        
    }

    [Ajax.AjaxMethod]
    public DataSet execute11(string tbl, string col, string val, string mit, string dateformat, string extra1, string extra2)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {


            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.execute1(tbl, col, val, mit, dateformat, extra1, extra2);
        }
        return ds;

    }

    [Ajax.AjaxMethod]
    public string agency_delete1(string tbl, string col, string val, string formt, string extra1, string extra2)
    {
        try
        {
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {


                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                ds = country.delete1(tbl, col, val, formt, extra1, extra2);
            }
            return "true";
        }
        catch (Exception ex)
        {
            return Convert.ToString(ex.Message);

        }

    }
}
