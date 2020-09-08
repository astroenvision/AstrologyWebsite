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

public partial class multiplesignificators : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(multiplesignificators));
        DataSet ds1 = new DataSet();
        ds1.ReadXml(Server.MapPath("ast.xml/extentions.xml"));
        tblfields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        fields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        hiddendateformat.Value = "dd/mm/yyyy";

        if (!Page.IsPostBack)
        {

            txthouse.Attributes.Add("onkeydown", "javascript:return fillhouse(event);");
            txtplanet.Attributes.Add("onkeydown", "javascript:return fillplanet(event);");
            txtrashi.Attributes.Add("onkeydown", "javascript:return fillrashi(event);");
            lsthouse.Attributes.Add("onkeydown", "javascript:return closehouse(event);");
            lstplanet.Attributes.Add("onkeydown", "javascript:return closeplanet(event);");
            lstrashi.Attributes.Add("onkeydown", "javascript:return closerashi(event);");
           
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
       
    }

    [Ajax.AjaxMethod]
    public DataSet fill_house(string extra1)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.multiplesigni country = new ASTROLOGY.classesoracle.multiplesigni();
            ds = country.bind_house(extra1);
        }
      
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet fill_planet(string extra1)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.multiplesigni country = new ASTROLOGY.classesoracle.multiplesigni();
            ds = country.bind_planet(extra1);
        }

        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet fill_rashi(string extra1)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.multiplesigni country = new ASTROLOGY.classesoracle.multiplesigni();
            ds = country.bind_rashi(extra1);
        }

        return ds;
    }

    [Ajax.AjaxMethod]
    public string save(string casesignificators,string signifies)
    {
        try
        {
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {


                ASTROLOGY.classesoracle.multiplesigni country = new ASTROLOGY.classesoracle.multiplesigni();
                ds = country.save_multiplesigni(casesignificators, signifies);
            }
            return "true";
        }
        catch (Exception ex)
        {
            return Convert.ToString(ex.Message);

        }

    }
     [Ajax.AjaxMethod]
    public DataSet executemultisigni(string txtmultisigni)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.multiplesigni country = new ASTROLOGY.classesoracle.multiplesigni();
            ds = country.execute_multisigni(txtmultisigni);
        }

        return ds;
    }

     [Ajax.AjaxMethod]
     public DataSet update_multisignificators(string multisignificators, string multisignificators1, string signifiesby)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.multiplesigni country = new ASTROLOGY.classesoracle.multiplesigni();
            ds = country.update_multisignificator(multisignificators, multisignificators1, signifiesby);
        }
        return ds;


    }

     [Ajax.AjaxMethod]
     public DataSet delete_multisignificators(string multisignificators,string signifiesby)
    {

        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
            ASTROLOGY.classesoracle.multiplesigni country = new ASTROLOGY.classesoracle.multiplesigni();
            ds = country.delete_multisignificator(multisignificators, signifiesby);
        }
        return ds;


    }

     [Ajax.AjaxMethod]
     public DataSet chk_multisignificators(string multisignificators, string signifiesby)
     {

         DataSet ds = new DataSet();
         if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
         {

             //Circulation.classesoracle.agency_mast admast = new Circulation.classesoracle.agency_mast();
             ASTROLOGY.classesoracle.multiplesigni country = new ASTROLOGY.classesoracle.multiplesigni();
             ds = country.chk_multisignificator(multisignificators, signifiesby);
         }
         return ds;


     }
}
