using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Leftbanr_n : System.Web.UI.UserControl
{
    public string tree = "";
    string userhome = "";
    string admin = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        //ds.ReadXml(Server.MapPath("XML/releaseno.xml"));
        //lbrelease.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        ////Ajax.Utility.RegisterTypeForAjax(typeof(EnterPage));
        ////Ajax.Utility.RegisterTypeForAjax(typeof(ClientMaster));	
        ////Ajax.Utility.RegisterTypeForAjax(typeof(ClientMaster));

        //// Put user code to initialize the page here
        //if (Session["compcode"] != null && Session["username"].ToString() != null)
        //{

        //}
        //else
        //{
        //    Response.Redirect("login.aspx");
        //    return;
        //}
        //hiddenusername.Value = Session["username"].ToString();
        //userhome = Session["userhome"].ToString();
        //admin = Session["Admin"].ToString();


        //dynamictreeview();


    }

    public void dynamictreeview()
    {
        if (Session["ROLEID"].ToString() != "CA0")
        {
            DataSet dstreexml = new DataSet();
            dstreexml.ReadXml(Server.MapPath("XML/tree.xml"));

            if (ConfigurationSettings.AppSettings["center"].ToString() == "depo" || ConfigurationSettings.AppSettings["showmasters"].ToString() == "no")
            {

                tree += "<div style=\"OVERFLOW: auto; WIDTH: 230; HEIGHT: 480px\"><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"230\" id = 'table1' >";
                tree += "<tr>";
                tree += "<td valign=\"top\">";
                tree += "<a style='cursor:hand;cursor:pointer' onClick=\"toggle(this)\" class=\"folder\"><img src=\"plus.gif\">Ad Manager</a>";


                tree += "<div style=\"display:none;\">";
                ////  tree += "<a onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Booking Scheduling</a>";
                // // tree += "<div style=\"display:none;\">";
                //  tree += "<a onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Master</a>";

                //  tree += "<div  style=\"display:none;\">";
                //  tree += "<a onClick=\"toggle1(this,'group1')\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Agency/Client Master</a>";
                //  tree += "<div id=\"group1\" style=\"display:none;\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Agent_master','Agency Master');\" >Agency </a>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AgencyCategoryMaster','Agency Category Master');\" >Agency Category</a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AgencySubCategoryMaster','Agency Sub Category Master');\" >Agency Sub Category </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AgencyTypeMaster','Agency Type Master');\" >Agency Type </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";


                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ClientCategoryMaster','Client Category Master');\" >Client Category</a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";


                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('PublisherMaster','Publisher Master');\" >Publisher</a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ProductCategory','Product Category');\" >Product Category </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('PaymentMode','Payment Mode');\" >Payment Mode</a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('status_master','Status Master');\" >Status Master</a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ProductSubCategory','Product Sub Category');\" >Product Sub Category </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('product_subsub_category','Product Sub Sub Category');\" >Product SubSubCat. </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('BrandMaster','BrandMaster');\" >Brand</a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('VarientMaster','VarientMaster');\" >Varient</a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";


                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ClientMaster','Client Master');\" >Client </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ProductMaster','Product Master');\" >Product </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('region_master','Region Master');\" >Region </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";





                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AdvTypeMaster2','Adv Type Master');\" >Ad Type </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";


                //  //tree += "<table border=\"0\" width=\"100%\">";
                //  //tree += "<tr>";
                //  //tree += "<td valign=\"top\">";
                //  //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Revenue_master','Revenue Master');\" >Revenue </a>";
                //  //tree += "</td>";
                //  //tree += "</tr>";
                //  //tree += "</table>";


                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('RetainerMaster','Retainer Master');\" >Retainer </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";


                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('BranchMaster','Branch Master');\" >Branch </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('DocumentMaster','Document Master');\" >Document </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('RepMast','Representative Master');\" >Representative</a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";


                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AgencyRoleMaster','Agency Role Master');\" >Agency Role Master </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('All_module_master','Module Master');\" >Module Master</a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";


                //  tree += "</div>";
                //  /////////////////////

                //  /////////////////////////////////



                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  //tree +="<a onClick=\"toggle1(this,'group2')\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Enviornment Masters</a>";
                //  tree += "<a onClick=\"toggle1(this,'group2')\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Enviornment Master</a>";

                //  tree += "<div id=\"group2\" style=\"display:none;\">";
                //  //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Adsize_master','Ad Size Master');\" >AdSize </a>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('BoxMaster','Box Master');\" >Box </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";


                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('IndustryMaster','Industry Master');\" >Industry</a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  //tree += "<table border=\"0\" width=\"100%\">";
                //  //tree += "<tr>";
                //  //tree += "<td valign=\"top\">";
                //  //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('MaterialMaster','Material Master');\" >Material </a>";
                //  //tree += "</td>";
                //  //tree += "</tr>";
                //  //tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('BillStatus','Bill Status');\" >Bill Status</a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";



                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ColorMaster','Color Master');\" >Color </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('BgColor','BgColor Master');\" >Bg Color </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('CurrencyMaster','Currency Master');\" >Currency </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('LanguageMaster','Language Master');\" >Language </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ZoneMaster','Zone Master');\" >Zone </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('CityMaster','City Master');\" >City </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('CountryMaster','Country Master');\" >Country </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('StateMaster','State Master');\" >State </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('DistrictMaster','District Master');\" >District </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";


                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('UOM','UOM Master');\" >UOM </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";


                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Bullet_master','Bullet Master');\" >Bullet </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Vatmaster','Vat Master');\" >Vat </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AdBookingIssue1','AdbookingIssue Master');\" >Adbooking Issue </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('addummydaypages','Ad dummy Master');\" >Ad dummy</a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('adDummyDayPS','Ad dummy Day Ps');\" >Ad dummy PS</a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";
                //  //tree +="</div>";


                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a onClick=\"toggle1(this,'group3')\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Publication Masters</a>";


                //  tree += "<div id=\"group3\" style=\"display:none;\">";
                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AdvPagePositionMaster','Page Position Master');\" >Ad Page Prem. </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";






                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('PubCatMast','Publication Center Master');\" >Publication Center </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('PublicationType','Publication Type');\" >Publication Type </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('PublicationMaster','Publication Master');\" >Publication </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('EditorMaster','Editor Master');\" >Editon </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('SupplimentMaster','Suppliment Master');\" >Supplement </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('SupplementType','Suppliment Type Master');\" >Supplement Type</a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('PageType','Page Type');\" >Page Type </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('preodicitymaster','Periodicity');\" >Periodicity</a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Pageparametermaster','Page Parameter Master');\" >Page Parameter </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AdvPositionTypMst','Adv Postion Master');\" >Ad Position Type </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Adcategorymaster','Ad Cat. Master');\" >Ad Category </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('adsubcat1','Ad Sub Cat Master');\" >Ad Sub Category </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Adsubcat3','Ad Sub Cat3');\" >Ad Sub Category3</a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AdCat4','Ad Sub Cat4');\" >Ad Sub Category4</a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AdSubCat5','Ad Sub Cat5');\" >Ad Sub Category5</a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AdvExecMaster','Adv Exec. Master');\" >Ad Executive </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";






                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('NoIssueMaster','No Issue Master');\" >NoIssue </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('NoIssueDayMaster','No Issue Day Master');\" >NoIssueDay </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";


                //  tree += "</div>";




                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<a onClick=\"toggle1(this,'group4')\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Rate Masters</a>";
                //  tree += "<div id=\"group4\" style=\"display:none;\">";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('CombinationMaster','Combination Master');\" >Combination </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  //tree += "<table border=\"0\" width=\"100%\">";
                //  //tree += "<tr>";
                //  //tree += "<td valign=\"top\">";
                //  //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('DiscountMaster','Discount Master');\" >Discount </a>";
                //  //tree += "</td>";
                //  //tree += "</tr>";
                //  //tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ColorRateGroupMast','ColorRateGroupMast');\" >Color Rate Group </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Scheme_Master','Scheme_Master');\" >Scheme</a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";


                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Ratemaster','Rate Master');\" >Rate </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  //tree += "<table border=\"0\" width=\"100%\">";
                //  //tree += "<tr>";
                //  //tree += "<td valign=\"top\">";
                //  //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Booking_master','Booking Master');\" >Booking</a>";
                //  //tree += "</td>";
                //  //tree += "</tr>";
                //  //tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('DealTypeMaster','Deal Type Master');\" >Deal Type </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ContractMaster','Contract Master');\" >Contract Master </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";


                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Premium_typ_master','Premium Type Master');\" >Premium Type </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";







                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('premium_master','Premium Master');\" >Premium </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  //tree += "<table border=\"0\" width=\"100%\">";
                //  //tree += "<tr>";
                //  //tree += "<td valign=\"top\">";
                //  //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('SchemeTypeMaster','Scheme Type Master');\" >Scheme Type </a>";
                //  //tree += "</td>";
                //  //tree += "</tr>";
                //  //tree += "</table>";

                //  //tree += "<table border=\"0\" width=\"100%\">";
                //  //tree += "<tr>";
                //  //tree += "<td valign=\"top\">";
                //  //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('SchemeMaster','Scheme Master');\" >Scheme</a>";
                //  //tree += "</td>";
                //  //tree += "</tr>";
                //  //tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ProductMaster','Product Master');\" >Product </a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";

                //  tree += "<table border=\"0\" width=\"100%\">";
                //  tree += "<tr>";
                //  tree += "<td valign=\"top\">";
                //  tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('RateGroupMaster','Rate Group Master');\" >Rate Group</a>";
                //  tree += "</td>";
                //  tree += "</tr>";
                //  tree += "</table>";


                //  //tree += "<table border=\"0\" width=\"100%\">";
                //  //tree += "<tr>";
                //  //tree += "<td valign=\"top\">";
                //  //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return calldepo('DepotIncmaster');\" >Depo Inc.</a>";
                //  //tree += "</td>";
                //  //tree += "</tr>";
                //  //tree += "</table>";






                //  tree += "</div>";



                //  tree += "</div>";







                // // tree += "</div>";

                tree += "<table border=\"0\" width=\"100%\">";
                tree += "<tr>";
                tree += "<td valign=\"top\">";


                tree += "<a style='cursor:hand;cursor:pointer' onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Transaction</a>";

                tree += "<div style=\"display:none;\">";
                //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Booking_master','Booking Master');\" >Display Booking</a>";

                //tree += "<table border=\"0\" width=\"100%\">";
                //tree += "<tr>";
                //tree += "<td valign=\"top\">";
                ////        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Classified_Booking','Classified Booking');\" >Classified Booking</a>";
                //tree += "</td>";
                //tree += "</tr>";
                //tree += "</table>";

                if (dstreexml.Tables[0].Rows[0].ItemArray[78].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return giveopenpermission('QBC','QBC');\" >&nbsp;QBC</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                    if (dstreexml.Tables[0].Rows[0].ItemArray[104].ToString() == "enable")
                    {
                        // for payment gateway link
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('https://ht.4cplus.com/adbooking/login.asp');\" >&nbsp;Payment Gateway </a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[105].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\"><img src=\"minus.gif\" style=\"padding-left:21px;\"></a></td><td><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return giveopenpermission('unconfirmpaidad','unconfirmpaidad');\" >Confirm Ads paid through Payment Gatway</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[106].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\"><img src=\"minus.gif\" style=\"padding-left:21px;\"></a></td><td><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return giveopenpermission('unconfirmad','unconfirmad');\" >Confirm Ads to be paid in Cash at HTML</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                // if (dstreexml.Tables[0].Rows[0].ItemArray[137].ToString() == "enable")
                //{
                //    tree += "<table border=\"0\" width=\"100%\">";
                //    tree += "<tr>";
                //    tree += "<td valign=\"top\">";
                //    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                //    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\"><img src=\"minus.gif\" style=\"padding-left:6px;\"></a></td><td><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return giveopenpermission('followup','followup');\" >follow Up</a>";
                //    tree += "</td>";
                //    tree += "</tr>";
                //    tree += "</table>";
                //}
                // if (dstreexml.Tables[0].Rows[0].ItemArray[138].ToString() == "enable")
                // {
                //     tree += "<table border=\"0\" width=\"100%\">";
                //     tree += "<tr>";
                //     tree += "<td valign=\"top\">";
                //     //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                //     tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\"><img src=\"minus.gif\" style=\"padding-left:6px;\"></a></td><td><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return giveopenpermission('misupdation','misupdation');\" >Mis Updation</a>";
                //     tree += "</td>";
                //     tree += "</tr>";
                //     tree += "</table>";
                // }


                //tree += "<table border=\"0\" width=\"100%\">";
                //tree += "<tr>";
                //tree += "<td valign=\"top\">";
                ////        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Booking_Audit1','Booking_Audit1');\" >Booking Audit</a>";
                //tree += "</td>";
                //tree += "</tr>";
                //tree += "</table>";


                tree += "</div>";



                tree += "</td>";
                tree += "</tr>";
                tree += "</table>";


                tree += "<table border=\"0\" width=\"100%\">";
                tree += "<tr>";
                tree += "<td valign=\"top\">";
                //tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" \" >Reports</a>";
                tree += "<a style='cursor:hand;cursor:pointer' onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Reports</a>";

                if (ConfigurationSettings.AppSettings["show_report_ht"].ToString() == "yes")
                {
                    tree += "<div style=\"display:none;\">";
                    if (dstreexml.Tables[0].Rows[0].ItemArray[80].ToString() == "enable")
                    {
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return openreports('report','Day');\" >All Ads of the Day</a>";
                    }

                    if (dstreexml.Tables[0].Rows[0].ItemArray[81].ToString() == "enable")
                    {
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return openreports('report2','Agency');\" >All Ads of the Agency</a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }

                    if (dstreexml.Tables[0].Rows[0].ItemArray[82].ToString() == "enable")
                    {
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return openreports('agencyclient','Client');\" >All Ads of the Client</a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";

                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return openreports('ad_status_search','Status');\" >Ad Status Report</a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }

                    if (dstreexml.Tables[0].Rows[0].ItemArray[83].ToString() == "enable")
                    {
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return openreports('reportConfirm','Confirmed');\" >Confirmed/Unconfirmed</a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }

                    if (dstreexml.Tables[0].Rows[0].ItemArray[84].ToString() == "enable")
                    {
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return openreports('qbcTransfer_User','Confirmed');\" >Transfered Booking User Wise</a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }

                    if (dstreexml.Tables[0].Rows[0].ItemArray[85].ToString() == "enable")
                    {
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return openreports('qbctransfer_report','Transfer');\" >Transfered Booking of the Day</a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }

                    tree += "</div>";
                }
                else
                {
                    tree += "<div style=\"display:none;\">";
                    if (dstreexml.Tables[0].Rows[0].ItemArray[83].ToString() == "enable")
                    {
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return openreports('reportConfirm','Confirmed');\" >Confirmed/Unconfirmed</a>";
                    }

                    if (dstreexml.Tables[0].Rows[0].ItemArray[84].ToString() == "enable")
                    {
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return openreports('qbcTransfer_User','Confirmed');\" >Transfered Booking User Wise</a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }

                    if (dstreexml.Tables[0].Rows[0].ItemArray[85].ToString() == "enable")
                    {
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return openreports('qbctransfer_report','Transfer');\" >Transfered Booking of the Day</a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }

                    tree += "</div>";
                }



                tree += "</td>";
                tree += "</tr>";
                tree += "</table>";

                //tree += "<table border=\"0\" width=\"100%\">";
                //tree += "<tr>";
                //tree += "<td valign=\"top\">";
                //tree += "<a  style='cursor:hand;cursor:pointer' onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Dial Up</a>";
                //tree += "</td>";
                //tree += "</tr>";
                //tree += "</table>";



                //tree += "<table border=\"0\" width=\"100%\">";
                //tree += "<tr>";
                //tree += "<td valign=\"top\">";
                //tree += "<a style='cursor:hand;cursor:pointer' onClick=\"homekeeping()\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">HouseKeeping</a>";
                //tree += "</td>";
                //tree += "</tr>";
                //tree += "</table>";

                if (dstreexml.Tables[0].Rows[0].ItemArray[88].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //tree += "<a style='cursor:hand;cursor:pointer' onClick=\"javascript:return openreports('Search','Search');\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">AdSearch</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' onClick=\"javascript:return giveopenpermission('Search','Search');\"  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">AdSearch</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                //tree += "<table border=\"0\" width=\"100%\">";
                //tree += "<tr>";
                //tree += "<td valign=\"top\">";
                //tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Billing</a>";
                //tree += "</td>";
                //tree += "</tr>";
                //tree += "</table>";

                //tree += "<table border=\"0\" width=\"100%\">";
                //tree += "<tr>";
                //tree += "<td valign=\"top\">";


                //tree += "<a onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Services</a>";

                //tree += "<div style=\"display:none;\">";
                //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"     class=\"nodescription\" onClick=\"javascript:masterprevilege();\">Master Privilege</a>";

                //tree += "<table border=\"0\" width=\"100%\">";
                //tree += "<tr>";
                //tree += "<td valign=\"top\">";
                //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('FormSubbmition','Form Name');\" >Form Name </a>";
                //tree += "</td>";
                //tree += "</tr>";
                //tree += "</table>";


                //tree += "<table border=\"0\" width=\"100%\">";
                //tree += "<tr>";
                //tree += "<td valign=\"top\">";
                ////tree +="<br>";
                //tree += "<a onClick=\"folder\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"     class=\"nodescription\" href=\"javascript:date();\">Preferences</a>";



                //tree += "</td>";
                //tree += "</tr>";
                //tree += "</table>";
                tree += "<table border=\"0\" width=\"100%\">";
                tree += "<tr>";
                tree += "<td valign=\"top\">";


                tree += "<a onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Services</a>";

                //tree += "<div style=\"display:none;\">";
                //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"     class=\"nodescription\" onClick=\"javascript:masterprevilege();\">Master Privilege</a>";
                tree += "<div style=\"display:none;\">";

                if (dstreexml.Tables[0].Rows[0].ItemArray[93].ToString() == "enable")
                {
                    tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"     class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Aduser','Receipt Change');\">Receipt No. Setting</a>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[84].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:openChange_Pwd();\">Change Password </a>";
                    tree += "</td> ";
                    tree += "</tr>";
                    tree += "</table>";

                    // ratecard
                    if (dstreexml.Tables[0].Rows[0].ItemArray[109].ToString() == "enable")
                    {
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('Images/RATECARD.jpg');\" >Rate Card </a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }
                    //SCHEME
                    if (dstreexml.Tables[0].Rows[0].ItemArray[110].ToString() == "enable")
                    {
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('Images/scheme.jpg');\" >Schemes Available</a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }
                    // user manual
                    if (dstreexml.Tables[0].Rows[0].ItemArray[108].ToString() == "enable")
                    {
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('manual.pdf');\" >User Manual </a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }
                    // FOR KEYBOARD
                    if (dstreexml.Tables[0].Rows[0].ItemArray[111].ToString() == "enable")
                    {
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        tree += "<a onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Virtual Keyboard</a>";

                        tree += "<div  style=\"display:none;\">";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:openKeyboard('remington');\" >Remington </a>";


                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:openKeyboard('phonetic');\" >Phonetic </a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";

                        tree += "</div>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }

                }


                //tree += "<table border=\"0\" width=\"100%\">";
                //tree += "<tr>";
                //tree += "<td valign=\"top\">";
                ////tree +="<br>";
                //tree += "<a onClick=\"folder\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"     class=\"nodescription\" href=\"javascript:date();\">Preferences</a>";



                tree += "</td>";
                tree += "</tr>";
                tree += "</table>";
                tree += "</div>";



                tree += "</td>";
                tree += "</tr>";
                tree += "</table>";


                //tree += "<table border=\"0\" width=\"100%\">";
                //tree += "<tr>";
                //tree += "<td valign=\"top\">";


                //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" OnClick=\"javascript: home('Enter Page');\">Home Page</a>";

                //tree += "</td>";
                //tree += "</tr>";
                //tree += "</table>";

                //			tree +="<table border=\"0\" width=\"100%\">";
                //			tree +="<tr>";
                //			tree +="<td valign=\"top\">";
                //			//tree +="<br>";
                //			tree +="<a  class=\"folder\">&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"     class=\"nodescription\" href=\"javascript: logout();\">Log Out</a>";
                //
                //
                //
                //
                //			tree +="</td>";
                //			tree +="</tr>";
                //			tree +="</table>";



                tree += "</div>";
                tree += "</td>";
                tree += "</tr>";
                tree += "</table></div>";


            }
            else if (ConfigurationSettings.AppSettings["LeftBanerForCD"].ToString() == "CD")
            {
                tree += "<div style=\"OVERFLOW: auto; WIDTH: 230; HEIGHT: 480px\"><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"230\" id = 'table1' >";
                tree += "<tr>";
                tree += "<td valign=\"top\">";
                tree += "<a style='cursor:hand;cursor:pointer' onClick=\"toggle(this)\" class=\"folder\"><img src=\"plus.gif\">Ad Manager</a>";


                tree += "<div  style=\"display:none;\">";
                tree += "<a onClick=\"toggle(this,'group1')\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Master</a>";
                tree += "<div id=\"group1\" style=\"display:none;\">";
                //*********************************************************************************************************************************//
                if (dstreexml.Tables[0].Rows[0].ItemArray[35].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('CountryMaster','Country Master');\" >Country Master </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[36].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('StateMaster','State Master');\" >State Master </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[37].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('DistrictMaster','District Master');\" >District Master </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[34].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('CityMaster','District Master');\" >City Master </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[33].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ZoneMaster','Zone Master');\" >Zone Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[15].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('region_master','Region Master');\" >Region Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[6].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ProductCategory','Product Category');\" >Product Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[11].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('BrandMaster','BrandMaster');\" >Brand Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[12].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('VarientMaster','VarientMaster');\" >Variant Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[55].ToString() == "enable")
                {
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AdCategoryMaster','Ad Cat. Master');\" >Ad Category Master </a>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[56].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('adsubcat1','Ad Sub Cat Master');\" >Ad Sub Category Master </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[57].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Adsubcat3','Ad Sub Cat3');\" >Ad Sub Sub Category Master </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[60].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AdvExecMaster','Adv Exec. Master');\" >Executive Master </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[47].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('PublicationMaster','Publication Master');\" >Publication Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[48].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('EditorMaster','Editor Master');\" >Edition Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[44].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AdvPagePositionMaster','Page Position Master');\" >Ad Page Premium Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[66].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Scheme_Master_CD','Scheme_Master');\" >Scheme Master </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[67].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('RateMaster_CD','Rate Master');\" >Rate Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";

                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ImportExportRate','Import/Export Rate');\" >Import/Export Rate</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[25].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('BoxMaster','Box Master');\" >Box Charges Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }


                //*********************************************************************************************************************************//
                tree += "</div>";

                tree += "<table border=\"0\" width=\"100%\">";
                tree += "<tr>";
                tree += "<td valign=\"top\">";


                tree += "<a style='cursor:hand;cursor:pointer' onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Transaction</a>";

                tree += "<div style=\"display:none;\">";
                if (dstreexml.Tables[0].Rows[0].ItemArray[76].ToString() == "enable")
                {
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Booking_master','Booking Master');\" >Display Booking</a>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[77].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Classified_Booking','Classified Booking');\" >Classified Booking</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[78].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return giveopenpermission('QBC','QBC');\" >QBC</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                tree += "</div>";
                tree += "</td>";
                tree += "</tr>";
                tree += "</table>";

                tree += "<table border=\"0\" width=\"100%\">";
                tree += "<tr>";
                tree += "<td valign=\"top\">";

                if (dstreexml.Tables[0].Rows[0].ItemArray[100].ToString() == "enable")
                {
                    tree += "<a style='cursor:hand;cursor:pointer' onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('reports/reportmenu.aspx');\" >Reports</a>";
                }

                tree += "</td>";
                tree += "</tr>";
                tree += "</table>";


                tree += "</div>";

                // }

                tree += "</td>";
                tree += "</tr>";
                tree += "</table></div>";
            }

            else
            {
                tree += "<div style=\"OVERFLOW: auto; WIDTH: 230; HEIGHT: 480px\"><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"230\" id = 'table1' >";
                tree += "<tr>";
                tree += "<td valign=\"top\">";
                tree += "<a style='cursor:hand;cursor:pointer' onClick=\"toggle(this)\" class=\"folder\"><img src=\"plus.gif\">Ad Manager</a>";


                tree += "<div style=\"display:none;\">";

                tree += "<a style='cursor:hand;cursor:pointer' onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Master</a>";

                tree += "<div  style=\"display:none;\">";
                tree += "<a onClick=\"toggle(this,'group1')\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Agency/Client Master</a>";
                tree += "<div id=\"group1\" style=\"display:none;\">";

                if (dstreexml.Tables[0].Rows[0].ItemArray[0].ToString() == "enable")
                {
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AgencyTypeMaster','Agency Type Master');\" >Agency Type </a>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[3].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Agent_master','Agency Master');\" >Agency </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[140].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Ro_Qbc','Ro_Qbc');\" >RO Book Issue Entry(Qbc)</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[13].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ClientMaster','Client Master');\" >Client </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[1].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AgencyCategoryMaster','Agency Category Master');\" >Agency Category</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[2].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AgencySubCategoryMaster','Agency Sub Category Master');\" >Agency Sub Category </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }



                if (dstreexml.Tables[0].Rows[0].ItemArray[4].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ClientCategoryMaster','Client Category Master');\" >Client Category</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[5].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('PublisherMaster','Publisher Master');\" >Publisher</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[6].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ProductCategory','Product Category');\" >Product </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }





                if (dstreexml.Tables[0].Rows[0].ItemArray[9].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ProductSubCategory','Product Sub Category');\" >Product Sub Category </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[10].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('product_subsub_category','Product Sub Sub Category');\" >Product SubSubCat. </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[11].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('BrandMaster','BrandMaster');\" >Brand</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[12].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('VarientMaster','VarientMaster');\" >Varient</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }



                if (dstreexml.Tables[0].Rows[0].ItemArray[14].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ProductMaster','Product Master');\" >Client Product </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }



                //tree += "<table border=\"0\" width=\"100%\">";
                //tree += "<tr>";
                //tree += "<td valign=\"top\">";
                //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Revenue_master','Revenue Master');\" >Revenue </a>";
                //tree += "</td>";
                //tree += "</tr>";
                //tree += "</table>";




                if (dstreexml.Tables[0].Rows[0].ItemArray[20].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('DocumentMaster','Document Master');\" >Document </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[21].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('RepMast','Representative Master');\" >Representative</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[129].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('AgencyBookingType.aspx');\" >AgencyBookingType</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }




                tree += "</div>";
                /////////////////////

                /////////////////////////////////

                //EXECUTIVE/RETAINER MASTER

                tree += "<table border=\"0\" width=\"100%\">";
                tree += "<tr>";
                tree += "<td valign=\"top\">";
                if (dstreexml.Tables[0].Rows[0].ItemArray[112].ToString() == "enable")
                {
                    //tree +="<a onClick=\"toggle1(this,'group2')\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Enviornment Masters</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' onClick=\"toggle(this,'group5')\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Exec./Retainer Master</a>";

                    tree += "<div id=\"group5\" style=\"display:none;\">";

                    if (dstreexml.Tables[0].Rows[0].ItemArray[22].ToString() == "enable")
                    {
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AgencyRoleMaster','Designation Master');\" >Designation</a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }


                    if (dstreexml.Tables[0].Rows[0].ItemArray[23].ToString() == "enable")
                    {
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('All_module_master','Reporting Master');\" >Reporting To</a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }

                    if (dstreexml.Tables[0].Rows[0].ItemArray[60].ToString() == "enable")
                    {
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AdvExecMaster','Adv Exec. Master');\" >Executive Master</a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }

                    if (dstreexml.Tables[0].Rows[0].ItemArray[18].ToString() == "enable")
                    {
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('RetainerMaster','Retainer Master');\" >Retainer Master</a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }

                    tree += "</div>";
                }
                // END

                tree += "<table border=\"0\" width=\"100%\">";
                tree += "<tr>";
                tree += "<td valign=\"top\">";
                //tree +="<a onClick=\"toggle1(this,'group2')\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Enviornment Masters</a>";
                tree += "<a style='cursor:hand;cursor:pointer' onClick=\"toggle(this,'group2')\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Enviornment Master</a>";

                tree += "<div id=\"group2\" style=\"display:none;\">";
                //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Adsize_master','Ad Size Master');\" >AdSize </a>";

                if (dstreexml.Tables[0].Rows[0].ItemArray[19].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Company_Master','Company Master');\" >Company Name</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[45].ToString() == "enable")
                {

                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('PubCatMast','Publication Center Master');\" >Publication Center </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[19].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('BranchMaster','Branch Master');\" >Branch Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }


                if (dstreexml.Tables[0].Rows[0].ItemArray[35].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('CountryMaster','Country Master');\" >Country Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[36].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    /*change ankur*/
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('StateMaster','State Master');\" >State Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[33].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ZoneMaster','Zone Master');\" >Zone Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[37].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('DistrictMaster','District Master');\" >District Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";

                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('taluka_mast','Taluka Master');\" >Taluka Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }


                if (dstreexml.Tables[0].Rows[0].ItemArray[15].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('region_master','Region Master');\" >Region Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[34].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    /*change ankur*/
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('CityMaster','City Master');\" >City Master</a>";

                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[7].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('PaymentMode','Payment Mode');\" >Payment Mode</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[8].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('status_master','Status Master');\" >Status Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[16].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AdvTypeMaster2','Adv Type Master');\" >Ad Type </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }


                if (dstreexml.Tables[0].Rows[0].ItemArray[31].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('CurrencyMaster','Currency Master');\" >Currency </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[32].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a  style='cursor:hand;cursor:pointer'class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('LanguageMaster','Language Master');\" >Language </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }


                if (dstreexml.Tables[0].Rows[0].ItemArray[28].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('BillStatus','Bill Status');\" >Bill Status</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[114].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Cir_roleMaster','Role Master');\" >Role Master </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[40].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Vatmaster','Vat Master');\" >Tax Rate </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }


                if (dstreexml.Tables[0].Rows[0].ItemArray[55].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AdCategoryMaster','Ad Cat. Master');\" >Ad Category </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[56].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('adsubcat1','Ad Sub Cat Master');\" >Ad Sub Category </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[57].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Adsubcat3','Ad Sub Cat3');\" >Ad Sub Category3</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[58].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AdCat4','Ad Sub Cat4');\" >Ad Sub Category4</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[59].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AdSubCat5','Ad Sub Cat5');\" >Ad Sub Category5</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }


                if (dstreexml.Tables[0].Rows[0].ItemArray[139].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('cat_seq_no','Cat seq no');\" >Category   Seq No.</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }


                if (dstreexml.Tables[0].Rows[0].ItemArray[26].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('IndustryMaster','Industry Master');\" >Industry</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                //tree += "<table border=\"0\" width=\"100%\">";
                //tree += "<tr>";
                //tree += "<td valign=\"top\">";
                //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('MaterialMaster','Material Master');\" >Material </a>";
                //tree += "</td>";
                //tree += "</tr>";
                //tree += "</table>";









                /*changes ankur*/
                if (dstreexml.Tables[0].Rows[0].ItemArray[96].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a  style='cursor:hand;cursor:pointer'class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('variable','variable Master');\" >Variable </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }


                /*change ankur*/








                /*change ankur*/








                if (dstreexml.Tables[0].Rows[0].ItemArray[41].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AdBookingIssue1','AdbookingIssue Master');\" >Adbooking Issue </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[42].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('addummydaypages','Ad dummy Master');\" >Ad dummy</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[43].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('adDummyDayPS','Ad dummy Day Ps');\" >Ad dummy PS</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[122].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Pub_Cent_Box_Add','Pub_Cent_Box_Add');\" >Pub_Cent_Box_Add</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[123].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('PubCatRef','PubCatRef');\" >PubCatRef</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[145].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('CaptionMaster','CaptionMaster');\" >CaptionMaster</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                tree += "</td>";
                tree += "</tr>";
                tree += "</table>";
                //tree +="</div>";


                tree += "<table border=\"0\" width=\"100%\">";
                tree += "<tr>";
                tree += "<td valign=\"top\">";
                tree += "<a style='cursor:hand;cursor:pointer' onClick=\"toggle(this,'group3')\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Publication Masters</a>";


                tree += "<div id=\"group3\" style=\"display:none;\">";



                if (dstreexml.Tables[0].Rows[0].ItemArray[46].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('PublicationType','Publication Type');\" >Publication Type </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[47].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('PublicationMaster','Publication Master');\" >Publication </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[48].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('EditorMaster','Editor Master');\" >Editon </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[50].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('SupplementType','Suppliment Type Master');\" >Supplement Type</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[49].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('SupplimentMaster','Suppliment Master');\" >Supplement </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                //combination

                if (dstreexml.Tables[0].Rows[0].ItemArray[63].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('CombinationMaster','Combination Master');\" >Combination </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";

                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('EditionStatus','EditionStatus');\" >Change Package Status </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[51].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('PageType','Page Type');\" >Page Type </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[52].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('preodicitymaster','Periodicity');\" >Periodicity</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[61].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('NoIssueMaster','No Issue Master');\" >NoIssue </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[62].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('NoIssueDayMaster','No Issue Day Master');\" >NoIssueDay </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[38].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('UOM','UOM Master');\" >Unit Of Measurement</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[124].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Adsize_master','Ad Size Master');\" >Ad Size </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
















                if (dstreexml.Tables[0].Rows[0].ItemArray[53].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Pageparametermaster','Page Parameter Master');\" >Page Parameter </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }





                /*new change ankur for mapping*/
                if (dstreexml.Tables[0].Rows[0].ItemArray[97].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('cat_mapping','cat_mapping');\" >Cat Mapping</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[97].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('pckgleader','pckgleader');\" >Package Leader</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }








                tree += "</div>";




                tree += "</td>";
                tree += "</tr>";
                tree += "</table>";

                tree += "<a style='cursor:hand;cursor:pointer' onClick=\"toggle(this,'group4')\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Rate Masters</a>";
                tree += "<div id=\"group4\" style=\"display:none;\">";



                //tree += "<table border=\"0\" width=\"100%\">";
                //tree += "<tr>";
                //tree += "<td valign=\"top\">";
                //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('DiscountMaster','Discount Master');\" >Discount </a>";
                //tree += "</td>";
                //tree += "</tr>";
                //tree += "</table>";






                //tree += "<table border=\"0\" width=\"100%\">";
                //tree += "<tr>";
                //tree += "<td valign=\"top\">";
                //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Booking_master','Booking Master');\" >Booking</a>";
                //tree += "</td>";
                //tree += "</tr>";
                //tree += "</table>";












                //tree += "<table border=\"0\" width=\"100%\">";
                //tree += "<tr>";
                //tree += "<td valign=\"top\">";
                //tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('premium_master','Premium Master');\" >Premium </a>";
                //tree += "</td>";
                //tree += "</tr>";
                //tree += "</table>";

                //tree += "<table border=\"0\" width=\"100%\">";
                //tree += "<tr>";
                //tree += "<td valign=\"top\">";
                //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('SchemeTypeMaster','Scheme Type Master');\" >Scheme Type </a>";
                //tree += "</td>";
                //tree += "</tr>";
                //tree += "</table>";

                //tree += "<table border=\"0\" width=\"100%\">";
                //tree += "<tr>";
                //tree += "<td valign=\"top\">";
                //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('SchemeMaster','Scheme Master');\" >Scheme</a>";
                //tree += "</td>";
                //tree += "</tr>";
                //tree += "</table>";
                if (dstreexml.Tables[0].Rows[0].ItemArray[67].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Ratemaster','Rate Master');\" >Rate Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";

                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ImportExportRate','Import/Export Rate');\" >Import/Export Rate</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }


                if (dstreexml.Tables[0].Rows[0].ItemArray[116].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('RateMaster_CD','Rate Master');\" >Rate Master New</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";

                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ImportExportRate','Import/Export Rate');\" >Import/Export Rate</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                //-----new form added by rinki 
                if (dstreexml.Tables[0].Rows[0].ItemArray[118].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('EditionWise_RatioEntry','Edition Wise Ratio Master');\" >Edition Wise Ratio Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[74].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('RateGroupMaster','Rate Group Master');\" >Rate Group Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[65].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ColorRateGroupMast','ColorRateGroupMast');\" >Color Rate Group </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[71].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Premium_typ_master','Premium Type Master');\" >Premium Type </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }


                if (dstreexml.Tables[0].Rows[0].ItemArray[69].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('DealTypeMaster','Deal Type Master');\" >Contract Type </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[70].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ContractMaster','Contract Master');\" >Contract Master </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[29].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ColorMaster','Color Master');\" >Color Master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }


                if (dstreexml.Tables[0].Rows[0].ItemArray[95].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('colortype','Color Type Master');\" >Color Type</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[30].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('BgColor','BgColor Master');\" >Bg Color </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[39].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Bullet_master','Bullet Master');\" >Bullet </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[44].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AdvPagePositionMaster','Page Position Master');\" >Ad Page Prem. </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[66].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Scheme_Master','Scheme_Master');\" >Scheme</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[117].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Scheme_Master_CD','Scheme_Master');\" >Scheme New</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[25].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('BoxMaster','Box Master');\" >Box </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                //*********** ad barter
                if (dstreexml.Tables[0].Rows[0].ItemArray[119].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Ad_BarteMaster','Ad Barter');\" >Ad Barter </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                //******************
                if (dstreexml.Tables[0].Rows[0].ItemArray[54].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AdvPositionTypMst','Adv Postion Master');\" >Ad Position Type </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[14].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('ProductMaster','Product Master');\" >Client Product </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[15].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Ad_Translation_charge','Ad_Translation_charge');\" >Translation Charge</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[130].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Disc_master','Disc_master');\" >Disc. master</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }




                //tree += "<table border=\"0\" width=\"100%\">";
                //tree += "<tr>";
                //tree += "<td valign=\"top\">";
                //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return calldepo('DepotIncmaster');\" >Depo Inc.</a>";
                //tree += "</td>";
                //tree += "</tr>";
                //tree += "</table>";






                tree += "</div>";



                tree += "</td>";
                tree += "</tr>";
                tree += "</table>";





                tree += "</div>";

                tree += "<table border=\"0\" width=\"100%\">";
                tree += "<tr>";
                tree += "<td valign=\"top\">";


                tree += "<a style='cursor:hand;cursor:pointer' onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Transaction</a>";

                tree += "<div style=\"display:none;\">";
                if (dstreexml.Tables[0].Rows[0].ItemArray[76].ToString() == "enable")
                {
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Booking_master','Booking Master');\" >Display Booking</a>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[77].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Classified_Booking','Classified Booking');\" >Classified Booking</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[134].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('tv_booking_transaction','TV Booking');\" >TV Booking</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[78].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return giveopenpermission('QBC','QBC');\" >QBC</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";

                    // for payment gateway link
                    if (dstreexml.Tables[0].Rows[0].ItemArray[104].ToString() == "enable")
                    {
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('https://ht.4cplus.com/adbooking/login.asp');\" >Payment Gateway </a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[105].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\"><img src=\"minus.gif\" style=\"padding-left:21px;\"></a></td><td><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return giveopenpermission('unconfirmpaidad','unconfirmpaidad');\" >Confirm Ads paid through Payment Gatway</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[106].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\"><img src=\"minus.gif\" style=\"padding-left:21px;\"></a></td><td><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return giveopenpermission('unconfirmad','unconfirmad');\" >Confirm Ads to be paid in Cash at HTML</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[107].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return openadsearch();\" >RO Details</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }


                //if (dstreexml.Tables[0].Rows[0].ItemArray[103].ToString() == "enable")
                //{
                //    tree += "<table border=\"0\" width=\"100%\">";
                //    tree += "<tr>";
                //    tree += "<td valign=\"top\">";
                //    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                //    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('PublishAudit','PublishAudit');\" >Publish Audit</a>";
                //    tree += "</td>";
                //    tree += "</tr>";
                //    tree += "</table>";
                //}

                if (dstreexml.Tables[0].Rows[0].ItemArray[79].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Booking_Audit1','Booking_Audit1');\" >Booking Audit</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[102].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:openBookingStatus();\">Publish Audit</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[98].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    if (Session["RATE_AUDIT_PREF"].ToString() == "1")
                    {
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('bookaudit','bookaudit');\" >Rate Audit</a>";
                    }
                    else
                    {
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('rate_audit_orderwise','rate_audit_orderwise');\" >Rate Audit</a>";
                    }
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[121].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('rofileform','rofileform');\" >R.O.File Form</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[120].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    //tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('bookaudit','bookaudit');\" >Rate Audit</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('ROapproval.aspx');\">ROapproval</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[125].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    //tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('bookaudit','bookaudit');\" >Rate Audit</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('ProofReading.aspx');\">ProofReading</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[127].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('Receipt_Form.aspx');\">Print Receipt</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[128].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('AuthorizationRelease','AuthorizationRelease');\">AuthorizationRelease</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[136].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('dealaudit','dealaudit');\">Deal Audit</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[137].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('followup.aspx');\">Follow Up</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[138].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('misupdation.aspx');\">Mis Updation</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                //if (dstreexml.Tables[0].Rows[0].ItemArray[140].ToString() == "enable")
                //{
                //    tree += "<table border=\"0\" width=\"100%\">";
                //    tree += "<tr>";
                //    tree += "<td valign=\"top\">";
                //    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Ro_Qbc','Ro_Qbc');\" >RO Book Issue Entry(Qbc)</a>";
                //    tree += "</td>";
                //    tree += "</tr>";
                //    tree += "</table>";
                //}
                if (dstreexml.Tables[0].Rows[0].ItemArray[142].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    // tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('Agency_merging.aspx');\">Agency Merging</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Agency_merging','Agency_merging');\" >Agency Merging</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[143].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    // tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('Agency_merging.aspx');\">Agency Merging</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('pendingfordummy','pendingfordummy');\" >Pending For Dummy</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";

                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[144].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    // tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('Agency_merging.aspx');\">Agency Merging</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('CD_Upload','CD_Upload');\" >CD Upload</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";

                }

                if (dstreexml.Tables[0].Rows[0].ItemArray[147].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    // tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('Agency_merging.aspx');\">Agency Merging</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('dealprovision','dealprovision');\" >Deal Provision</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";

                }
                tree += "</div>";







                tree += "</td>";
                tree += "</tr>";
                tree += "</table>";


                // enebale pam
                if (dstreexml.Tables[0].Rows[0].ItemArray[99].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' onClick=\"window.open('http://ankur4c/demopam/login.aspx');\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">PAM</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                //-------------------------------------------PAm
                if (dstreexml.Tables[0].Rows[0].ItemArray[99].ToString() == "enable")
                {
                    tree += "<table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"200\" id = 'tablepam' >";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";


                    tree += "<a style='cursor:hand;cursor:pointer' onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">PAM</a>";
                    tree += "<div style=\"display:none;\">";
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' onClick=\"toggle(this,'group5')\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Transaction</a>";

                    tree += "<div id=\"group5\" style=\"display:none;\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('frma_entry_new','Entry Form');\">Entry </a>";

                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('FRMA_SEARCHDATA','Search Data');\">Advance Search </a>";
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
                    tree += "<a style='cursor:hand;cursor:pointer' onClick=\"toggle(this,'group6')\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Reports</a>";

                    tree += "<div id=\"group6\" style=\"display:none;\">";

                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\"onClick=\"javascript:return giveopenpermission('missreportdemo','missreportdemo');\">Missed ADS Report</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";


                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\"onClick=\"javascript:return giveopenpermission('VolumeMktshare','VolumeMktshare ');\">Volume Market Share</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";


                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\"onClick=\"javascript:return giveopenpermission('pa_clientagency','pa_clientagency ');\">Client/Agency Report</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";


                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\"onClick=\"javascript:return giveopenpermission('pa_mtdreport','pa_mtdreport ');\">Mtd Report</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";

                    //tree += "<table border=\"0\" width=\"100%\">";
                    //tree += "<tr>";
                    //tree += "<td valign=\"top\">";
                    //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\"onClick=\"javascript:return giveopenpermission('Mtdreport','Mtdreport ');\">Mtd Report</a>";
                    //tree += "</td>";
                    //tree += "</tr>";
                    //tree += "</table>";

                    tree += "<table border=\"0\"width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\"onClick=\"javascript:return giveopenpermission('issuereport','issuereport ');\">Issue Wise Cat Rev</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";



                    tree += "<table border=\"0\"width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\"onClick=\"javascript:return giveopenpermission('pa_executive','pa_executive ');\">Exec Clnt Vol Rev Report</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";




                    //tree += "<table border=\"0\"width=\"100%\">";
                    //tree += "<tr>";
                    //tree += "<td valign=\"top\">";
                    //tree += "<a class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\"onClick=\"javascript:return giveopenpermission('pa_volrevenue','pa_volrevenue ');\">Volume Revenue Report</a>";
                    //tree += "</td>";
                    //tree += "</tr>";
                    //tree += "</table>";

                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\"onClick=\"javascript:return giveopenpermission('Topclientnew','Topclientnew ');\">Top Client</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";




                    //tree += "<table border=\"0\" width=\"100%\">";
                    //tree += "<tr>";
                    //tree += "<td valign=\"top\">";
                    //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\"onClick=\"javascript:return giveopenpermission('TopClientVolumeRevenueReport','TopClientVolumeRevenueReport ');\">TopClientVolumeRevenue</a>";
                    //tree += "</td>";
                    //tree += "</tr>";
                    //tree += "</table>";

                    //tree += "<table border=\"0\" width=\"100%\">";
                    //tree += "<tr>";
                    //tree += "<td valign=\"top\">";
                    //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\"onClick=\"javascript:return giveopenpermission('Volumerevenue_new','Volumerevenue_new ');\">TopClientVolumeRevenue</a>";
                    //tree += "</td>";
                    //tree += "</tr>";
                    //tree += "</table>";


                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\"onClick=\"javascript:return giveopenpermission('supplementreport','supplementreport ');\">Supp Mkt Share report</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                    // tree += "</div>";

                    //tree += "<table border=\"0\" width=\"100%\">";
                    //tree += "<tr>";
                    //tree += "<td valign=\"top\">";
                    //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\"onClick=\"javascript:return giveopenpermission('pam_targetrep','pam_targetrep ');\">Target V/S Achivement</a>";
                    //tree += "</td>";
                    //tree += "</tr>";
                    //tree += "</table>";

                    //tree += "<table border=\"0\" width=\"100%\">";
                    //tree += "<tr>";
                    //tree += "<td valign=\"top\">";
                    //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\"onClick=\"javascript:return giveopenpermission('demo','demop');\">Demo</a>";
                    //tree += "</td>";
                    //tree += "</tr>";
                    //tree += "</table>";
                    // tree += "</div>";












                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                    tree += "</div>";

                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                //----------------------------------------------END


                tree += "<table border=\"0\" width=\"100%\">";
                tree += "<tr>";
                tree += "<td valign=\"top\">";
                //tree += "<a style='cursor:hand;cursor:pointer' onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('reportmenu.aspx');\" >Reports</a>";

                if (ConfigurationSettings.AppSettings["show_report_ht"].ToString() == "yes")
                {
                    tree += "<a style='cursor:hand;cursor:pointer' onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Reports</a>";
                    tree += "<div style=\"display:none;\">";
                    if (dstreexml.Tables[0].Rows[0].ItemArray[80].ToString() == "enable")
                    {
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return openreports('report','Day');\" >All Ads of the Day</a>";
                    }

                    if (dstreexml.Tables[0].Rows[0].ItemArray[81].ToString() == "enable")
                    {
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return openreports('report2','Agency');\" >All Ads of the Agency</a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }

                    if (dstreexml.Tables[0].Rows[0].ItemArray[82].ToString() == "enable")
                    {
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return openreports('agencyclient','Client');\" >All Ads of the Client</a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";

                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return openreports('ad_status_search','Status');\" >Ad Status Report</a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }

                    if (dstreexml.Tables[0].Rows[0].ItemArray[83].ToString() == "enable")
                    {
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return openreports('reportConfirm','Confirmed');\" >Confirmed/Unconfirmed</a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }

                    if (dstreexml.Tables[0].Rows[0].ItemArray[84].ToString() == "enable")
                    {
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return openreports('qbcTransfer_User','Confirmed');\" >Transfered Booking User Wise</a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }

                    if (dstreexml.Tables[0].Rows[0].ItemArray[85].ToString() == "enable")
                    {
                        tree += "<table border=\"0\" width=\"100%\">";
                        tree += "<tr>";
                        tree += "<td valign=\"top\">";
                        //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                        tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a style=\"text-decoration:none;cursor:hand;cursor:pointer\" class=\"nodescription\" onClick=\"javascript:return openreports('qbctransfer_report','Transfer');\" >Transfered Booking of the Day</a>";
                        tree += "</td>";
                        tree += "</tr>";
                        tree += "</table>";
                    }

                    tree += "</div>";
                }
                else
                {
                    if (dstreexml.Tables[0].Rows[0].ItemArray[100].ToString() == "enable")
                    {
                        tree += "<a style='cursor:hand;cursor:pointer' onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('reports/reportmenu.aspx');\" >Reports</a>";
                    }
                }
                tree += "</td>";
                tree += "</tr>";
                tree += "</table>";
                if (dstreexml.Tables[0].Rows[0].ItemArray[88].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' onClick=\"javascript:return giveopenpermission('Search','Search');\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">AdSearch</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[89].ToString() == "enable")
                {
                    tree += "<table border=\"0\" id=\"billingmenu\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";


                    //tree += "<a style='cursor:hand;cursor:pointer' style='cursor:hand;cursor:pointer' onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Billing</a>";
                    //tree += "<a style='cursor:hand;cursor:pointer'  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"     class=\"nodescription\" onClick=\"javascript:openBilling();\">Billing</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' style='cursor:hand;cursor:pointer' onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Billing</a>";


                    tree += "<div style=\"display:none;\">";
                    tree += "<a style='cursor:hand;cursor:pointer'  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"     class=\"nodescription\" onClick=\"javascript:openBilling();\">Billing</a>";
                    /*  tree += "<table border=\"0\" width=\"100%\">";
                      tree += "<tr>";
                      tree += "<td valign=\"top\">";
                      tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('billNoRevised.aspx');\">Revised Bill </a>";
                      tree += "</td>";
                      tree += "</tr>";
                      tree += "</table>";*/
                    tree += "<div>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";


                }

                tree += "<table border=\"0\" id=\"services1\" width=\"100%\">";
                tree += "<tr>";
                tree += "<td valign=\"top\">";


                tree += "<a style='cursor:hand;cursor:pointer' style='cursor:hand;cursor:pointer' onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Services</a>";

                tree += "<div style=\"display:none;\">";
                tree += "<a style='cursor:hand;cursor:pointer'  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"     class=\"nodescription\" onClick=\"javascript:createuser();\">Create User</a>";

                tree += "<table border=\"0\" width=\"100%\">";
                tree += "<tr>";
                tree += "<td valign=\"top\">";
                tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('reportlognew.aspx');\">Log </a>";
                tree += "</td>";
                tree += "</tr>";
                tree += "</table>";



                tree += "<table border=\"0\" width=\"100%\">";
                tree += "<tr>";
                tree += "<td valign=\"top\">";
                tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:openChange_Pwd();\">Change Password </a>";
                tree += "</td>";
                tree += "</tr>";
                tree += "</table>";
                if (Session["Admin"].ToString() == "yes")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:masterprevilege();\">Master Privilege </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[126].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    //        tree += "<a onClick=\"\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\">Classified Booking</a>";
                    //tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('bookaudit','bookaudit');\" >Rate Audit</a>";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('Userpermission.aspx');\">Userpermission</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[115].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('Role_detail','Role_detail');\">Role Permission</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                tree += "<table border=\"0\" width=\"100%\">";
                tree += "<tr>";
                tree += "<td valign=\"top\">";
                tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('FormSubbmition','Form Name');\" >Form Name </a>";
                tree += "</td>";
                tree += "</tr>";
                if (dstreexml.Tables[0].Rows[0].ItemArray[132].ToString() == "enable")
                {
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('DefaultPageConfigurationMaster','Default Page Configuration Master');\" >Default PageConfig Master </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[131].ToString() == "enable")
                {
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('PaginationDays','Pagination Days');\" >Pagination Days Master </a>";
                    tree += "</td>";
                    tree += "</tr>";

                    tree += "</table>";
                }
                if (dstreexml.Tables[0].Rows[0].ItemArray[113].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('xtg_generate','xtg_generate');\">Generate XTG File </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                tree += "<table border=\"0\" width=\"100%\">";
                tree += "<tr>";
                tree += "<td valign=\"top\">";
                tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\"  onClick=\"javascript:return giveopenpermission('genReference','genReference');\">Generate Ref. File </a>";
                tree += "</td>";
                tree += "</tr>";
                tree += "</table>";

                tree += "<table border=\"0\" width=\"100%\">";
                tree += "<tr>";
                tree += "<td valign=\"top\">";
                //tree +="<br>";
                tree += "<a style='cursor:hand;cursor:pointer' onClick=\"folder\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"  onClick=\"javascript:return giveopenpermission('updateprefer','updateprefer');\"   class=\"nodescription\" href=\"javascript:date();\">Preferences</a>";

                //tree += "<div style=\"display:none;\">";
                //tree += "<a style='cursor:hand;cursor:pointer'  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"     class=\"nodescription\" onClick=\"window.open('DefaultPageConfigurationMaster.aspx');\">Default Page Configuration Master</a>";

                tree += "</td>";
                tree += "</tr>";
                tree += "</table>";

                if (dstreexml.Tables[0].Rows[0].ItemArray[104].ToString() == "enable")
                {
                    // for payment gateway link
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('https://ht.4cplus.com/adbooking/login.asp');\" >Payment Gateway </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                // urerpermissionreport
                if (dstreexml.Tables[0].Rows[0].ItemArray[146].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('userformwiserights','userformwiserights');\">UserFormwiseRights </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                // ratecard
                if (dstreexml.Tables[0].Rows[0].ItemArray[109].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('Images/RATECARD.jpg');\" >Rate Card </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                //SCHEME
                if (dstreexml.Tables[0].Rows[0].ItemArray[110].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('Images/scheme.jpg');\" >Schemes Available</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                // user manual
                if (dstreexml.Tables[0].Rows[0].ItemArray[108].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"window.open('manual.pdf');\" >User Manual </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                // FOR KEYBOARD
                if (dstreexml.Tables[0].Rows[0].ItemArray[111].ToString() == "enable")
                {
                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">Virtual Keyboard</a>";

                    tree += "<div  style=\"display:none;\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:openKeyboard('remington');\" >Remington </a>";


                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:openKeyboard('phonetic');\" >Phonetic </a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";

                    tree += "</div>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                tree += "</div>";

                // }

                tree += "</td>";
                tree += "</tr>";
                tree += "</table>";
                if (dstreexml.Tables[0].Rows[0].ItemArray[135].ToString() == "enable")
                {
                    tree += "<table border=\"0\" id=\"license1\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";


                    tree += "<a style='cursor:hand;cursor:pointer' style='cursor:hand;cursor:pointer' onClick=\"toggle(this)\" class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"plus.gif\">License</a>";

                    tree += "<div style=\"display:none;\">";
                    tree += "<a style='cursor:hand;cursor:pointer'  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"     class=\"nodescription\" onClick=\"javascript:return giveopenpermission('licenseinfo','License Info');\">License Info</a>";

                    tree += "<table border=\"0\" width=\"100%\">";
                    tree += "<tr>";
                    tree += "<td valign=\"top\">";
                    tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" onClick=\"javascript:return giveopenpermission('upgradelicense','Upgrade License');\">Upgrade License</a>";
                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                    tree += "</div>";

                    // }

                    tree += "</td>";
                    tree += "</tr>";
                    tree += "</table>";
                }
                //tree += "<table border=\"0\" width=\"100%\">";
                //tree += "<tr>";
                //tree += "<td valign=\"top\">";


                //tree += "<a  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"    class=\"nodescription\" OnClick=\"javascript: home('Enter Page');\">Home Page</a>";

                //tree += "</td>";
                //tree += "</tr>";
                //tree += "</table>";

                //			tree +="<table border=\"0\" width=\"100%\">";
                //			tree +="<tr>";
                //			tree +="<td valign=\"top\">";
                //			//tree +="<br>";
                //			tree +="<a  class=\"folder\">&nbsp;&nbsp;<img src=\"minus.gif\"></a><a     style=\"text-decoration:none;cursor:hand;cursor:pointer\"     class=\"nodescription\" href=\"javascript: logout();\">Log Out</a>";
                //
                //
                //
                //
                //			tree +="</td>";
                //			tree +="</tr>";
                //			tree +="</table>";



                tree += "</div>";
                tree += "</td>";
                tree += "</tr>";
                tree += "</table></div>";









            }
        }
        else
        {
            tree += "<div style=\"OVERFLOW: auto; WIDTH: 230; HEIGHT: 480px\"><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"230\" id = 'table1' >";
            tree += "<tr>";
            tree += "<td valign=\"top\">";
            tree += "<a style='cursor:hand;cursor:pointer' onClick=\"toggle(this)\" class=\"folder\"><img src=\"plus.gif\">Ad Manager</a>";
            tree += "<div  style=\"display:none;\">";

            tree += "<table border=\"0\" width=\"100%\">";
            tree += "<tr>";
            tree += "<td valign=\"top\">";

            tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\" onClick=\"javascript:return giveopenpermission('cash_recipt','Cash Recipt');\">&nbsp;&nbsp;&nbsp;&nbsp;Cash Receipt</a>";
            tree += "</td>";
            tree += "</tr>";
            tree += "</table>";

            tree += "<table border=\"0\" width=\"100%\">";
            tree += "<tr>";
            tree += "<td valign=\"top\">";

            tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\" onClick=\"javascript:return giveopenpermission('external_cash_recipt','Receipt From External Source');\">&nbsp;&nbsp;&nbsp;&nbsp;Receipt From External Source</a>";
            tree += "</td>";
            tree += "</tr>";
            tree += "</table>";

            tree += "<table border=\"0\" width=\"100%\">";
            tree += "<tr>";
            tree += "<td valign=\"top\">";

            tree += "<a style='cursor:hand;cursor:pointer' class=\"folder\" onClick=\"javascript:return openAdReceipt();\">&nbsp;&nbsp;&nbsp;&nbsp;Ad Receipt</a>";
            tree += "</td>";
            tree += "</tr>";
            tree += "</table>";

            tree += "<table border=\"0\" width=\"100%\">";
            tree += "<tr>";
            tree += "<td valign=\"top\">";

            tree += "<a style='cursor:hand;cursor:pointer'  class=\"folder\">&nbsp;&nbsp;&nbsp;&nbsp;Circulation Receipt</a>";
            tree += "</td>";
            tree += "</tr>";
            tree += "</table>";
            tree += "</div>";
            tree += "</td>";
            tree += "</tr>";
            tree += "</table></div>";

        }
    }
}

