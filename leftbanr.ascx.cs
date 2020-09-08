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

public partial class leftbanr : System.Web.UI.UserControl
{
    public string tree = "";
    string userhome = "";
    string admin = "";
    int j = 0;
    string[] values_subhead;
    int subhead_length;

    protected void Page_Load(object sender, System.EventArgs e)
    {
        //Ajax.Utility.RegisterTypeForAjax(typeof(EnterPage));
        //Ajax.Utility.RegisterTypeForAjax(typeof(ClientMaster));	
        //Ajax.Utility.RegisterTypeForAjax(typeof(ClientMaster));

        // Put user code to initialize the page here
        //hiddenusername.Value = Session["username"].ToString();
        //userhome = Session["userhome"].ToString();
        //admin = Session["Admin"].ToString();


        //        dynamictreeview();

        dynamictreeview_new();


    }
    public void dynamictreeview_new()
    {

       tree += "<div style=\"OVERFLOW: auto; WIDTH: 170; HEIGHT: 480px\"><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"180\" id = 'table1' >";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' onClick=\"toggle(this)\" class=\"folder\"><img src=\"Image/plus.gif\">ASTROLOGY</a>";
        tree += "<div style=\"display:none;\">";

        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/plus.gif\">Masters</a>";
        tree += "<div  style=\"display:none;\">";


        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('combinationentry','combinationentry');\" >Combination Entry </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";


        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Houseposition','Houseposition');\" >House Position  </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";



        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('encyclopaedia','encyclopaedia');\" >Natal Significators </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('horarysigni','horarysigni');\" >Horary Significator </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('multiplesignificators','multiplesignificators');\" >Multiple Significators </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";


        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('planetfromplanet','planetfromplanet');\" >Planet From Planet </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('planetaspectplanet','planetaspectplanet');\" >Planet Aspect Planet </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";



        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('planet_Aspect','planet_Aspect');\" >Aspects Planet </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('benificmalific','benificmalific');\" >Benific Malific Aspect </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('predictive_categery','predictive_categery');\" >Predictive Categery </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";



        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('extentions','extentions');\" >Astro Extension </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";


        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('predictive_input','predictive_input');\" >Predictive Input </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";





        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('predictive_input1','predictive_input1');\" >Predictive Input1 </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";


        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('dailyairticle','dailyairticle');\" >dailyairticle </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";


        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('astro_dtls','astro_dtls');\" >Astrologer Registration </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";


        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('astro_client','astro_client');\" >Client Registration </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        //tree += "<table border=\"0\" width=\"100%\">";
        //tree += "<tr>";
        //tree += "<td valign=\"top\">";
        //tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('astro_tree','astro_tree');\" >Astro Knowlwgde Tree </a>";
        //tree += "</td>";
        //tree += "</tr>";
        //tree += "</table>";


        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('astro_tree_view_excl','astro_tree_view_excl');\" >Astro Knowlwgde Tree Through Excl</a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('add_article','add_article');\" >Add Articles</a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('mod_article','mod_article');\" >Modify Articles</a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        tree += "</div>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";
      

        



        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/plus.gif\">Transactions</a>";
        tree += "<div  style=\"display:none;\">";

              

        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('astrodegree','astrodegree');\" >Astrodegree </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

       



        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('astrocharts','astrocharts');\" >Astro Charts </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";




        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('homenewpage','homenewpage');\" >Horoscope Result </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('book_predictive','book_predictive');\" >Book Wise Predictive </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('all_predictive','all_predictive');\" >All Predictive </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";


        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('chartindex','chartindex');\" >Chart Index </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";


        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ResearchTool','ResearchTool');\" >Research Tool </a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";





        //tree += "</td>";
        //tree += "</tr>";
        //tree += "</table>";

        //tree += "</td>";
        //tree += "</tr>";
        //tree += "</table>";
        //tree += "</div>";
        tree += "</div>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";
        // Promo Master End Here





        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer;' onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/plus.gif\">Natal</a>";
        tree += "<div  style=\"display:none;\">";

        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        //tree += "<a style='cursor:hand;cursor:pointer;' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return giveopenpermission('admin/modify_natal_data','admin/modify_natal_data');\" >Update Predictive</a>";
        tree += "<a style='cursor:hand;cursor:pointer;' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" href='admin/natal_search_predictive.aspx' target='_blank' >Update Predictive</a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        //tree += "<a style='cursor:hand;cursor:pointer;' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return giveopenpermission('admin/modify_natal_data','admin/modify_natal_data');\" >Update Predictive</a>";
        tree += "<a style='cursor:hand;cursor:pointer;' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" href='admin/modify_natal_data.aspx' target='_blank' >Search Predictive</a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer;' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" href='admin/natal_category_data.aspx' target='_blank' >Category Wise Predictive</a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        tree += "</div>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";





        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer;' onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/plus.gif\">Astrologer Details</a>";
        tree += "<div  style=\"display:none;\">";

        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        //tree += "<a style='cursor:hand;cursor:pointer;' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return giveopenpermission('admin/modify_natal_data','admin/modify_natal_data');\" >Update Predictive</a>";
        tree += "<a style='cursor:hand;cursor:pointer;' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" href='astrologer_details.aspx' target='_blank' >Astrologer Details</a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        tree += "</div>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        /***************************** Manage Category ******************************************/
        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer;' onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/plus.gif\">Manage Category</a>";
        tree += "<div  style=\"display:none;\">";

        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        //tree += "<a style='cursor:hand;cursor:pointer;' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return giveopenpermission('admin/modify_natal_data','admin/modify_natal_data');\" >Update Predictive</a>";
        tree += "<a style='cursor:hand;cursor:pointer;' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" href='admin/ManageCategory.aspx' target='_blank' >Update Category</a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        tree += "</div>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";


        /***************************** Manage Price******************************************/
        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer;' onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/plus.gif\">Manage Price</a>";
        tree += "<div  style=\"display:none;\">";

        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer;' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" href='admin/ManageCategoryPrice.aspx' target='_blank' >Update Category Price</a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer;' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" href='admin/ManagePackage.aspx' target='_blank' >Update Package Price</a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        tree += "</div>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";


        /***************************** Approve Aricles ******************************************/
        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer;' onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/plus.gif\">Manage Article</a>";
        tree += "<div  style=\"display:none;\">";

        tree += "<table border=\"0\" width=\"100%\">";
        tree += "<tr>";
        tree += "<td valign=\"top\">";
        tree += "<a style='cursor:hand;cursor:pointer;' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"Image/minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" href='admin/ApproveArticles.aspx' target='_blank' >Approve Articles</a>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        tree += "</div>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        /*****************************End Approve Aricles******************************************/












        tree += "</div>";
        tree += "</td>";
        tree += "</tr>";
        tree += "</table>";

        tree += "</div>";
       
    
    }
             
}
            
        
    
