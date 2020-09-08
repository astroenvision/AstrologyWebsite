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

public partial class astrocharts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Ajax.Utility.RegisterTypeForAjax(typeof(astrocharts));
        DataSet ds1 = new DataSet();
        ds1.ReadXml(Server.MapPath("ast.xml/aspectplanet.xml"));
        tblfields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        fields.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        hiddendateformat.Value = "dd/mm/yyyy";
        hiddenvalue.Value = ds1.Tables[0].Rows[0].ItemArray[0].ToString();
        //Hidden38.Value = Request.QueryString["ss"].ToString();
        //Hidden37.Value = Request.QueryString["kk"].ToString();
        if (!Page.IsPostBack)
        {
            bindplanet();
            bindlohhouse();
            
          
            btnNew.Attributes.Add("onclick", "javascript:return EnableOnNew();");
            btnCancel.Attributes.Add("onclick", "javascript:return ClearAll();");
            btnModify.Attributes.Add("onclick", "javascript:return modifydata()");
            btnExit.Attributes.Add("onclick", "javascript:return Exit();");
            btnQuery.Attributes.Add("onclick", "javascript:return enablequery()");
            btnDelete.Attributes.Add("onclick", "javascript:return delete_data();");
            

            btnExecute.Attributes.Add("onclick", "javascript:return executequery(querytype)");

            btnfirst.Attributes.Add("onclick", "javascript:return fnd_first_record()");
            btnnext.Attributes.Add("onclick", "javascript:return fnd_next_record()");
            btnprevious.Attributes.Add("onclick", "javascript:return fnd_pre_record()");
            btnlast.Attributes.Add("onclick", "javascript:return fnd_last_record()");




        }


    
    }

    public void bindplanet()
    {
        planet.Items.Clear();
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_planet("");
        }
        ListItem li = new ListItem();
        li.Text = "--Select Planet--";
        li.Value = "0";
        li.Selected = true;
        planet.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            planet.Items.Add(li1);
        }
    }

    public void bindlohhouse()
    {
        
        house.Items.Clear();
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.ast_house("");
        }

        ListItem li = new ListItem();
        li.Text = "--Select House--";
        li.Value = "0";
        li.Selected = true;
        
        house.Items.Add(li);

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            
            house.Items.Add(li1);
        }
    }


    protected void DataGrid1_ItemDataBound(object sender, DataGridItemEventArgs e)
    {





    }


    protected void d9_Click(object sender, EventArgs e)
    {
       
            string planet1 = planet.SelectedValue;
            string house1 = house.SelectedValue;
            string ldeg = ldegree.Text.ToString();
            string pdeg = pdegree.Text.ToString();


            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {

                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                //ds = country.d9chart(planet, house, ldeg, pdeg);
                ds = country.dninecharts(planet1, house1, ldeg, pdeg);
            }
            if (ds.Tables[1].Rows.Count == 0)
            {
                DataGrid1.DataSource = ds.Tables[1];
                DataGrid1.DataBind();
                return;
            }
            else
            {
                DataGrid7.Visible = false;
                DataGrid10.Visible = false;
                DataGrid12.Visible = false;
                DataGrid16.Visible = false;
                DataGrid1.Visible = true;
                DataGrid2.Visible = false;
                DataGrid4.Visible = false;
                DataGrid3.Visible = false;
                DataGrid1.DataSource = ds.Tables[1];
                DataGrid1.DataBind();
                Label9.Text = "Navamsha Chart";
                return;

            }
        }

    protected void d3_Click(object sender, EventArgs e)
    {

        string planet1 = planet.SelectedValue;
        string house1 = house.SelectedValue;
        string ldeg = ldegree.Text.ToString();
        string pdeg = pdegree.Text.ToString();


        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            //ds = country.d9chart(planet, house, ldeg, pdeg);
            ds = country.dthreecharts(planet1, house1, ldeg, pdeg);
        }
        if (ds.Tables[1].Rows.Count == 0)
        {
            DataGrid3.DataSource = ds.Tables[1];
            DataGrid3.DataBind();
            return;
        }
        else
        {
            DataGrid7.Visible = false;
            DataGrid10.Visible = false;
            DataGrid12.Visible = false;
            DataGrid16.Visible = false;
            DataGrid3.Visible = true;
            DataGrid1.Visible = false;
            DataGrid4.Visible = false;
            DataGrid2.Visible = false;
            DataGrid3.DataSource = ds.Tables[1];
            DataGrid3.DataBind();
            Label9.Text = "Drekkana Chart";
            return;


        }
    }


    protected void d4_Click(object sender, EventArgs e)
    {

        string planet1 = planet.SelectedValue;
        string house1 = house.SelectedValue;
        string ldeg = ldegree.Text.ToString();
        string pdeg = pdegree.Text.ToString();


        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            //ds = country.d9chart(planet, house, ldeg, pdeg);
            ds = country.dfourcharts(planet1, house1, ldeg, pdeg);
        }
        if (ds.Tables[1].Rows.Count == 0)
        {
            DataGrid4.DataSource = ds.Tables[1];
            DataGrid4.DataBind();
            return;
        }
        else
        {
            DataGrid3.Visible = false;
            DataGrid10.Visible = false;
            DataGrid12.Visible = false;
            DataGrid16.Visible = false;
            DataGrid1.Visible = false;
            DataGrid2.Visible = false;
            DataGrid4.Visible = true;
            DataGrid4.DataSource = ds.Tables[1];
            DataGrid4.DataBind();
            DataGrid7.Visible = false;
            Label9.Text = "Chaturthamsha Chart";
            return;

        }
    }
  
    
    protected void d1_Click(object sender, EventArgs e)
    {
        
            string planet1 = planet.SelectedValue;
            string house1 = house.SelectedValue;
            string ldeg = ldegree.Text.ToString();
            string pdeg = pdegree.Text.ToString();


            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {

                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                //ds = country.d9chart(planet, house, ldeg, pdeg);
                ds = country.donecharts(planet1, house1, ldeg, pdeg);
            }
            if (ds.Tables[1].Rows.Count == 0)
            {
                DataGrid2.DataSource = ds.Tables[0];
                DataGrid2.DataBind();
                return;
            }
            else
            {
                //divgrid1.Attributes.Add("style", "visibility:Visible;");
                DataGrid2.Visible = true;
                DataGrid1.Visible = false;
                DataGrid10.Visible = false;
                DataGrid12.Visible = false;
                DataGrid16.Visible = false;
                DataGrid7.Visible = false;
                DataGrid4.Visible = false;
                DataGrid3.Visible = false;
                DataGrid2.DataSource = ds.Tables[0];
                DataGrid2.DataBind();
                Label9.Text = "Rashi Chart";
                return;
            }
        }



    protected void d7_Click(object sender, EventArgs e)
    {

        string planet1 = planet.SelectedValue;
        string house1 = house.SelectedValue;
        string ldeg = ldegree.Text.ToString();
        string pdeg = pdegree.Text.ToString();


        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            //ds = country.d9chart(planet, house, ldeg, pdeg);
            ds = country.dsevencharts(planet1, house1, ldeg, pdeg);
        }
        if (ds.Tables[1].Rows.Count == 0)
        {
            DataGrid7.DataSource = ds.Tables[1];
            DataGrid7.DataBind();
            return;
        }
        else
        {
            //divgrid1.Attributes.Add("style", "visibility:Visible;");
            DataGrid2.Visible = false;
            DataGrid10.Visible = false;
            DataGrid12.Visible = false;
            DataGrid16.Visible = false;
            DataGrid7.Visible = true;
            DataGrid1.Visible = false;
            DataGrid4.Visible = false;
            DataGrid3.Visible = false;
            DataGrid7.DataSource = ds.Tables[1];
            DataGrid7.DataBind();
            Label9.Text = "Saptamsha Chart";
            return;
        }
    }


    protected void d10_Click(object sender, EventArgs e)
    {

        string planet1 = planet.SelectedValue;
        string house1 = house.SelectedValue;
        string ldeg = ldegree.Text.ToString();
        string pdeg = pdegree.Text.ToString();


        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            //ds = country.d9chart(planet, house, ldeg, pdeg);
            ds = country.dtenharts(planet1, house1, ldeg, pdeg);
        }
        if (ds.Tables[1].Rows.Count == 0)
        {
            DataGrid10.DataSource = ds.Tables[1];
            DataGrid10.DataBind();
            return;
        }
        else
        {
            //divgrid1.Attributes.Add("style", "visibility:Visible;");
            DataGrid2.Visible = false;
            DataGrid7.Visible = false;
            DataGrid10.Visible = true;
            DataGrid1.Visible = false;
            DataGrid12.Visible = false;
            DataGrid16.Visible = false;
            DataGrid4.Visible = false;
            DataGrid3.Visible = false;
            DataGrid10.DataSource = ds.Tables[1];
            DataGrid10.DataBind();
            Label9.Text = "Dashamamsha Chart";
            return;
        }
    }

    protected void d12_Click(object sender, EventArgs e)
    {

        string planet1 = planet.SelectedValue;
        string house1 = house.SelectedValue;
        string ldeg = ldegree.Text.ToString();
        string pdeg = pdegree.Text.ToString();


        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            //ds = country.d9chart(planet, house, ldeg, pdeg);
            ds = country.dtwelvecharts(planet1, house1, ldeg, pdeg);
        }
        if (ds.Tables[1].Rows.Count == 0)
        {
            DataGrid12.DataSource = ds.Tables[1];
            DataGrid12.DataBind();
            return;
        }
        else
        {
            //divgrid1.Attributes.Add("style", "visibility:Visible;");
            DataGrid2.Visible = false;
            DataGrid7.Visible = false;
            DataGrid12.Visible = true;
            DataGrid1.Visible = false;
            DataGrid10.Visible = false;
            DataGrid16.Visible = false;
            DataGrid4.Visible = false;
            DataGrid3.Visible = false;
            DataGrid12.DataSource = ds.Tables[1];
            DataGrid12.DataBind();
            Label9.Text = "Dwadashamsha Chart";
            return;
        }
    }



    protected void d16_Click(object sender, EventArgs e)
    {

        string planet1 = planet.SelectedValue;
        string house1 = house.SelectedValue;
        string ldeg = ldegree.Text.ToString();
        string pdeg = pdegree.Text.ToString();


        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            //ds = country.d9chart(planet, house, ldeg, pdeg);
            ds = country.dsixteencharts(planet1, house1, ldeg, pdeg);
        }
        if (ds.Tables[1].Rows.Count == 0)
        {
            DataGrid16.DataSource = ds.Tables[1];
            DataGrid16.DataBind();
            return;
        }
        else
        {
            //divgrid1.Attributes.Add("style", "visibility:Visible;");
            DataGrid2.Visible = false;
            DataGrid10.Visible = false;
            DataGrid7.Visible = false;
            DataGrid12.Visible = false;
            DataGrid16.Visible = true;
            DataGrid1.Visible = false;
            DataGrid4.Visible = false;
            DataGrid3.Visible = false;
            DataGrid16.DataSource = ds.Tables[1];
            DataGrid16.DataBind();
            Label9.Text = "Shodashamsha Chart";
            return;
        }
    }

}
