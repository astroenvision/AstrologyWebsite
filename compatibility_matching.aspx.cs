using System;
using System.Collections;
using System.Collections.Generic;
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


public partial class compatibility_matching : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindGridviewFirst();

            // Generate a list of 5 integers - this will be the data source for the GridView
            List<int> rows = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                rows.Add(i);
            }

            //Bind the Gridview to the list of integers so we get 5 rows in the UI
            gridsecond.DataSource = rows;
            gridsecond.DataBind();
        }
    }

    protected void BindGridviewFirst()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("rowidfirst", typeof(int));
        dt.Columns.Add("txtNamefirst", typeof(string));
        dt.Columns.Add("txtdobfirst", typeof(string));
        dt.Columns.Add("txttobfirst", typeof(string));
        dt.Columns.Add("txtcountryfirst", typeof(string));
        dt.Columns.Add("txtstatefirst", typeof(string));
        dt.Columns.Add("txtcityfirst", typeof(string));
        DataRow dr = dt.NewRow();
        dr["rowidfirst"] = 1;
        dr["txtNamefirst"] = string.Empty;
        dr["txtdobfirst"] = string.Empty;
        dr["txttobfirst"] = string.Empty;
        dr["txtcountryfirst"] = string.Empty;
        dr["txtstatefirst"] = string.Empty;
        dr["txtcityfirst"] = string.Empty;
        dt.Rows.Add(dr);
        ViewState["Curtbl"] = dt;
        gridfirst.DataSource = dt;
        gridfirst.DataBind();
    }
}