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

public partial class astro_tree : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(astro_tree));
        submit.Attributes.Add("Onclick", "javascript:return datasave();");
        drop_parent.Attributes.Add("onchange", "javascript:return datasubmit();");
    }

    [Ajax.AjaxMethod]
    public DataSet save_data(string node_name, string group, string explanation, string under_node_id, string id, string exp2, string exp3)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.save_data_tree(node_name, group, explanation, under_node_id, id, exp2, exp3,"");
        }
        return ds;
    }

    [Ajax.AjaxMethod]
    public DataSet check_node(string node_name, string drop, string under_node_id)
    {
        DataSet ds = new DataSet();
        if (ConfigurationManager.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.check_node_data(node_name, drop, under_node_id,"");
        }
        return ds;
    }
}
