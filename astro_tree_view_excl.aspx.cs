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


public partial class astro_tree_view_excl : System.Web.UI.Page
{
    string node_id1 = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        
       
        if (!Page.IsPostBack)
        {

           
            Ajax.Utility.RegisterTypeForAjax(typeof(astro_tree_view_excl));
            rootu.Attributes.Add("onkeyup", "javascript:return openrootu(event);");
            filter1u.Attributes.Add("onkeyup", "javascript:return openrootu(event);");
            filter2u.Attributes.Add("onkeyup", "javascript:return openrootu(event);");
            filter3u.Attributes.Add("onkeyup", "javascript:return openrootu(event);");
            filter4u.Attributes.Add("onkeyup", "javascript:return openrootu(event);");
            filter5u.Attributes.Add("onkeyup", "javascript:return openrootu(event);");
            filter6u.Attributes.Add("onkeyup", "javascript:return openrootu(event);");
            root_listu.Attributes.Add("onclick", "javascript:return insert_datau(id);");
            filter1_listu.Attributes.Add("onclick", "javascript:return insert_datau(id);");
            filter2_listu.Attributes.Add("onclick", "javascript:return insert_datau(id);");
            filter3_listu.Attributes.Add("onclick", "javascript:return insert_datau(id);");
            filter4_listu.Attributes.Add("onclick", "javascript:return insert_datau(id);");
            filter5_listu.Attributes.Add("onclick", "javascript:return insert_datau(id);");
            filter6_listu.Attributes.Add("onclick", "javascript:return insert_datau(id);");
            update.Attributes.Add("onclick", "javascript:return update_data(id);");
            delete.Attributes.Add("onclick", "javascript:return delete_data(id);");

            root_listu.Attributes.Add("onkeyup", "javascript:return textboxfocusu(event);");
            filter1_listu.Attributes.Add("onkeyup", "javascript:return textboxfocusu(event);");
            filter2_listu.Attributes.Add("onkeyup", "javascript:return textboxfocusu(event);");
            filter3_listu.Attributes.Add("onkeyup", "javascript:return textboxfocusu(event);");
            filter4_listu.Attributes.Add("onkeyup", "javascript:return textboxfocusu(event);");
            filter5_listu.Attributes.Add("onkeyup", "javascript:return textboxfocusu(event);");
            filter6_listu.Attributes.Add("onkeyup", "javascript:return textboxfocusu(event);");
            drop_select.Attributes.Add("onchange", "javascript:return cu();");
            
            
            
            
            root.Attributes.Add("onkeyup", "javascript:return openroot(event);");
            filter1.Attributes.Add("onkeyup", "javascript:return openroot(event);");
            filter2.Attributes.Add("onkeyup", "javascript:return openroot(event);");
            filter3.Attributes.Add("onkeyup", "javascript:return openroot(event);");
            filter4.Attributes.Add("onkeyup", "javascript:return openroot(event);");
            filter5.Attributes.Add("onkeyup", "javascript:return openroot(event);");
            filter6.Attributes.Add("onkeyup", "javascript:return openroot(event);");
            root_list.Attributes.Add("onclick", "javascript:return insert_data(id);");
            filter1_list.Attributes.Add("onclick", "javascript:return insert_data(id);");
            filter2_list.Attributes.Add("onclick", "javascript:return insert_data(id);");
            filter3_list.Attributes.Add("onclick", "javascript:return insert_data(id);");
            filter4_list.Attributes.Add("onclick", "javascript:return insert_data(id);");
            filter5_list.Attributes.Add("onclick", "javascript:return insert_data(id);");
            filter6_list.Attributes.Add("onclick", "javascript:return insert_data(id);");
            save.Attributes.Add("onclick", "javascript:return save_data(id);");
            sas.Attributes.Add("onclick", "javascript:return save_synonyam();");
            clear.Attributes.Add("onclick", "javascript:return clear_data(id);");
            clear1.Attributes.Add("onclick", "javascript:return clear_datau(id);");
            root_list.Attributes.Add("onkeyup", "javascript:return textboxfocus(event);");
            filter1_list.Attributes.Add("onkeyup", "javascript:return textboxfocus(event);");
            filter2_list.Attributes.Add("onkeyup", "javascript:return textboxfocus(event);");
            filter3_list.Attributes.Add("onkeyup", "javascript:return textboxfocus(event);");
            filter4_list.Attributes.Add("onkeyup", "javascript:return textboxfocus(event);");
            filter5_list.Attributes.Add("onkeyup", "javascript:return textboxfocus(event);");
            filter6_list.Attributes.Add("onkeyup", "javascript:return textboxfocus(event);");
            anr.Attributes.Add("onclick", "javascript:return anr();");
            ctr1.Attributes.Add("onclick", "javascript:return ctr1();");
            ctr2.Attributes.Add("onclick", "javascript:return ctr2();");
            ctr3.Attributes.Add("onclick", "javascript:return ctr3();");
            ctr4.Attributes.Add("onclick", "javascript:return ctr4();");
            ctr5.Attributes.Add("onclick", "javascript:return ctr5();");
            ctr6.Attributes.Add("onclick", "javascript:return ctr6();");



        }
    }

    [Ajax.AjaxMethod]
    public DataSet show_node_exp(string sp, string f, string drop_down)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.view_exp(sp, f, drop_down);
        }
        return ds;
    }
        
    [Ajax.AjaxMethod]
    public DataSet show_syno_name(string f, string drop_down)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.view_syno( f, drop_down);
        }
        return ds;
    }
         [Ajax.AjaxMethod]
    public DataSet show_par_name(string f, string drop_down)
    {
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.view_par( f, drop_down);
        }
        return ds;
    }
    
    [Ajax.AjaxMethod]
    public DataSet show_node_data(string filter, string under_node_id, string drop_down)
    {
            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                ds = country.view_node(filter, under_node_id, drop_down);
            }
            return ds;
    }


    [Ajax.AjaxMethod]
    public DataSet check_node(string node_name, string drop, string under_node_id, string drop_down)
    {
        DataSet ds = new DataSet();

        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.check_node_data(node_name, drop, under_node_id, drop_down);

        }
        return ds;


    }
     
    [Ajax.AjaxMethod]
    public DataSet save_data(string node_name, string group, string explanation, string under_node_id, string id, string exp2, string exp3, string drop_down)
    {
        
        DataSet ds = new DataSet();
        
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.save_data_tree(node_name, group, explanation, under_node_id, id, exp2, exp3, drop_down);

        }
        return ds;


    }
    
       [Ajax.AjaxMethod]
    public DataSet update_data(string nodeid, string explanation, string exp2, string exp3, string drop_down, string upnode)
    {
        DataSet ds = new DataSet();

        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.update_data_tree(nodeid, explanation, exp2, exp3, drop_down, upnode);

        }
        return ds;


    }
       [Ajax.AjaxMethod]
       public ADODB.Recordset update_data1(string nodeid, string explanation,string drop_down, string upnode)
       {
          ADODB.Recordset rs = new ADODB.Recordset();

           if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
           {
               ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

               rs = country.update_data_tree1(nodeid, explanation,  drop_down, upnode);

           }
           return rs;


       }
       [Ajax.AjaxMethod]
       public DataSet delete_data(string nodeid, string drop_down)
       {
           DataSet ds = new DataSet();

           if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
           {
               ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

               ds = country.delete_data_tree(nodeid, drop_down);

           }
           return ds;


       }
     [Ajax.AjaxMethod]
       public DataSet save_syn(string drop_down, string node_name, string synonyam)
    {
        
        DataSet ds = new DataSet();
        
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.save_synonyam(drop_down, node_name, synonyam);

        }
        return ds;


    }
   
    //public void bindchart()
    
    //{
       
    //    //ADODB.Recordset rs=new ADODB.Recordset();
    //    //ADODB.Connection cn = new ADODB.Connection("DSN=orcl_astro;UID=astrology;PWD=astrology;");
    //    //ADODB.Command cmd = new ADODB.Command("select EXPLANATION from ASTRO_KNOWLEDGE_transaction where node_id='3681' ", cn);
    //    //rs = new ADODB.Recordset(); 
    //    //cn.Open();
       
        
       
        
    //    //rs.Open(sqld,cn,3,3);
    //    //rs(0).Value = story;
    //    //rs.Update();
    //    //rs = Nothing;
    //    //cn.Close();
    //    //cn = Nothing;

       

    //}
   
}
   
   

