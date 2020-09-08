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
using System.Data.OracleClient;
using System.IO;


public partial class combinationentry : System.Web.UI.Page
{
    string comblist ;
    int j = 0;
    int count;
    //string vaue = "D1";
    protected void Page_Load(object sender, EventArgs e)
    {

        //Hidden2.Value = Request.QueryString["ss"].ToString();
        //Hidden1.Value = Request.QueryString["kk"].ToString();   
        if (!Page.IsPostBack)
        {
            bindaspectingplanet();
            bindhouse();
            bindrashi();
            bindplanet();
            bindascendent();
            bindconstellation();
            bindchart();
           // lordofhouse();
            Ajax.Utility.RegisterTypeForAjax(typeof(combinationentry));
        

            div2.Attributes.Add("style", "visibility:hidden;");
            //div1.Attributes.Add("style", "visibility:hidden;");
            Button8.Attributes.Add("onclick", "javascript:return ShowPreview();");
            Buton2.Attributes.Add("onclick", "javascript:return click_on_cancel();");
            Buton3.Attributes.Add("onclick", "javascript:return click_on_new();");
         
            //chart.Enabled = false;
            //chart.Text = vaue;
        }
    }



    public void bindaspectingplanet()
    {
        aspecting.Items.Clear();
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_planet("");

        }

        //hdncompcode.Value
        ListItem li = new ListItem();
        li.Text = "--Select Aspecting Planet--";
        li.Value = "0";
        li.Selected = true;
        aspecting.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            aspecting.Items.Add(li1);

        }

    }
    //public void lordofhouse()
    //{

    //    loh.Items.Clear();
    //    DataSet ds = new DataSet();


    //    if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
    //    {
    //        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

    //        ds = country.AST_lord_bind("");

    //    }


    //    ListItem li = new ListItem();
    //    li.Text = "--Select Lord Of House--";
    //    li.Value = "0";
    //    li.Selected = true;

    //    loh.Items.Add(li);
    //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
    //    {
    //        ListItem li1 = new ListItem();
    //        li1.Text = ds.Tables[0].Rows[i]["CODE"].ToString();


    //        loh.Items.Add(li1);
    //    }




    //}
    public void bindhouse()
    {
        DropDownList1.Items.Clear();
        DropDownList4.Items.Clear();
        loh.Items.Clear();
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
        DropDownList1.Items.Add(li);
        DropDownList4.Items.Add(li);
        loh.Items.Add(li);

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            DropDownList1.Items.Add(li1);
            DropDownList4.Items.Add(li1);
            loh.Items.Add(li1);
        }
    }
    public void bindrashi()
    {

        DropDownList2.Items.Clear();
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_rashi("");

        }


        ListItem li = new ListItem();
        li.Text = "--Select Rashi--";
        li.Value = "0";
        li.Selected = true;

        DropDownList2.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();

            DropDownList2.Items.Add(li1);
        }




    }
    public void bindchart()
    {

        chart.Items.Clear();
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_chart("");

        }


        ListItem li = new ListItem();
        li.Text = "--Select Chart--";
        li.Value = "0";
        li.Selected = true;

        chart.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["CHART_NO"].ToString();


            chart.Items.Add(li1);
        }




    }
    public void bindconstellation()
    {
        constellationbox.Items.Clear();
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_constellation("");

        }


        ListItem li = new ListItem();
        li.Text = "--Select Constellation--";
        li.Value = "0";
        li.Selected = true;
        constellationbox.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            constellationbox.Items.Add(li1);

        }
    }



    public void bindascendent()
    {
        ascendentbox.Items.Clear();
        DataSet ds = new DataSet();


        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {
            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

            ds = country.ast_ascendent("");

        }

        
        ListItem li = new ListItem();
        li.Text = "--Select Ascendent--";
        li.Value = "0";
        li.Selected = true;
        ascendentbox.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();
            ascendentbox.Items.Add(li1);

        }
    }


    public void bindplanet()
    {
        DropDownList3.Items.Clear();

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

        DropDownList3.Items.Add(li);
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            ListItem li1 = new ListItem();
            li1.Text = ds.Tables[0].Rows[i]["Name"].ToString();
            li1.Value = ds.Tables[0].Rows[i]["Code"].ToString();

            DropDownList3.Items.Add(li1);
        }

    }

    protected void AspNetMessageBox(string strMessage)
    {

        string strAlert = "";
        strAlert = "alert('" + strMessage + "')";
        ScriptManager.RegisterClientScriptBlock(this, typeof(combinationentry), "ShowAlert", strAlert, true);
    }



    protected void Buton1_Click(object sender, EventArgs e)
    {
        if (ListBox1.Items.Count == 0)
        {
            message = "plz fill the list";
            AspNetMessageBox(message);

        }
        else
        {
            string str = "$";

           
            for (int l = 0; l < ListBox1.Items.Count; l++)
            {

                string str1 = ListBox1.Items[l].Text.ToString();

                if (comblist == null)
                {
                    comblist = str1;
                }
                else
                { 
                    comblist = comblist+str+str1;
                }
            }





            DataSet ds = new DataSet();
            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {
               
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                ds = country.list(comblist.ToString());
            }
          
         //  div1.Attributes.Add("style", "visibility:visible;");
            div2.Attributes.Add("style", "visibility:visible;");
            TextBox2.Text = string.Empty;
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
          
            return;

            
        }
    }
    protected void DataGrid1_ItemDataBound(object sender, DataGridItemEventArgs e)
    {
    }
    string message;
    
    
    protected void Button4_Click(object sender, EventArgs e)
    {



        foreach (GridViewRow r in GridView1.Rows)
        {
              
            
            
            
            
            
            CheckBox ch = r.Cells[0].FindControl("check1") as CheckBox;
            if (ch.Checked == true)
            {
                count = 1;
              






            }

            else
            {


            }


            continue;


        }

        if (count == 0)
        {
            message = "atleast one checkbox are selected";
            AspNetMessageBox(message);
            Textcode.Text = string.Empty;
            Textname.Text = string.Empty;
            TextBox3.Text = string.Empty;
            detaildesc.Text = string.Empty;
            page0.Text = string.Empty;
            keystring.Text = string.Empty;
            book.Text = string.Empty;
            Textdesc.Text = string.Empty;
            return;

        }






        

        

        string splitcode = Textcode.Text;
        string[] split_code = splitcode.Split('~');
    
        for (int i = 0; i < split_code.Length - 1; i++)
        {



            for (int j = i; j < split_code.Length - 1; j++)
            {
                if (split_code[i] == split_code[j + 1])
                {
                    message = "duplicate code are not insert.....  plz select another checkbox";
                    AspNetMessageBox(message);
                    TextBox3.Text = string.Empty;
                    Textdesc.Text = string.Empty;
                    detaildesc.Text = string.Empty;
                    page0.Text = string.Empty;
                    keystring.Text = string.Empty;
                    book.Text = string.Empty;
                    return;


                }
                else
                {

                }
            }


        }
       








              DataSet ds = new DataSet();
              if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
              {
                 
                  foreach (GridViewRow r in GridView1.Rows)
                  {

                      if (Textcode.Text == r.Cells[3].Text)
                      {

                          message = "duplicate code are not insert....  plz select another checkbox";
                          AspNetMessageBox(message);
                          
                          Textdesc.Text = string.Empty;
                          detaildesc.Text = string.Empty;
                          TextBox3.Text = string.Empty;
                          page0.Text = string.Empty;
                          keystring.Text = string.Empty;
                          book.Text = string.Empty;
                          return;
                      }
                      else
                      {

                      }
                  }
                  ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                  ds = country.save_data(Textcode.Text, Textname.Text, Textdesc.Text, detaildesc.Text, TextBox3.Text,book.Text,page0.Text,keystring.Text);


                  TextBox1.Text = string.Empty;
                 

                  message = "Data save successfully";
                  AspNetMessageBox(message);
                  Textcode.Text = string.Empty;
                  Textname.Text = string.Empty;
                  Textdesc.Text = string.Empty;
                 detaildesc.Text = string.Empty;
                 page0.Text = string.Empty;
                 keystring.Text = string.Empty;
                 book.Text = string.Empty;
                 TextBox3.Text = string.Empty;
                 page0.Text = string.Empty;
                 book.Text = string.Empty;
                 
              }

        

    }
    string s;
    string s1;
    string s2;

  
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        foreach (GridViewRow r in GridView1.Rows)
        {
            CheckBox ch = r.Cells[0].FindControl("check1") as CheckBox;
        
            if (ch.Checked == true)
             {
              count = 1;
                Textname.Text = string.Empty;
                Textcode.Text = string.Empty;
               
               s = s+"";
               s1 = s1 + "";
               s2 = s2 + "";
               if (s == "")
               {
                  

                       Textname.Text = r.Cells[2].Text.ToString();



                       Textcode.Text = r.Cells[3].Text;


                     
                    
                  
               }
               else
               {
                   
                       Textname.Text = s1 + "~" + r.Cells[2].Text.ToString();



                       Textcode.Text = s + "~" + r.Cells[3].Text;



                      


                       
                    
                   
               }

               s= Textcode.Text;
               s1 = Textname.Text.ToString();
              
           }
           else 
           {
              

              

           }
            
 
          continue;
            


        }
        if (count == 0)
        {
           
            Textcode.Text = string.Empty;
            Textname.Text = string.Empty;
            Textdesc.Text = string.Empty;
            detaildesc.Text = string.Empty;
            TextBox3.Text = string.Empty;
            page0.Text = string.Empty;
            keystring.Text = string.Empty;
            book.Text = string.Empty;
            return;
          

        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        int flag = 0;
        for (int h = 0; h < ListBox1.Items.Count; h++)
        {
            if (TextBox1.Text == "")
            {

                TextBox1.Text = "0";

            }

            if (degreefrom.Text == "")
            {
                degreefrom.Text = "0";
            }
            if (degreeto.Text == "")
            {
                degreeto.Text = "0";
            }
            if (ListBox1.Items[h].Text == DropDownList3.SelectedValue + "~" + DropDownList2.SelectedValue + "~" + DropDownList1.SelectedValue + "~" + ascendentbox.SelectedValue + "~" + TextBox1.Text + "~" + constellationbox.SelectedValue + "~" + degreefrom.Text + "~" + degreeto.Text + "~" + chart.Text + "~" + aspecting.SelectedValue + "~" + loh.SelectedValue)
            {
                message = "duplicate value are not insert";
                AspNetMessageBox(message);
                
                flag = -1;
                TextBox1.Text = string.Empty;
                constellationbox.SelectedIndex = 0;
                ascendentbox.SelectedIndex = 0;
                degreefrom.Text = string.Empty;
                degreeto.Text = string.Empty;
                chart.SelectedIndex = 0;
                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
                DropDownList3.SelectedIndex = 0;
                DropDownList4.SelectedIndex = 0;
                aspecting.SelectedIndex = 0;
                loh.SelectedIndex = 0;
                page0.Text = string.Empty;
                keystring.Text = string.Empty;
                book.Text = string.Empty;

                break;
            }
          
        }
        if (flag == 0)
        {
            if (DropDownList1.SelectedIndex != 0)
            {
                if (TextBox1.Text == "")
                {

                    TextBox1.Text = "0";

                }
               
                if (degreefrom.Text == "")
                {
                    degreefrom.Text = "0";
                }
                if (degreeto.Text == "")
                {
                    degreeto.Text = "0";
                }

                ListBox1.Items.Add(DropDownList3.SelectedValue + "~" + DropDownList2.SelectedValue + "~" + DropDownList1.SelectedValue + "~" + ascendentbox.SelectedValue + "~" + TextBox1.Text + "~" + constellationbox.SelectedValue + "~" + degreefrom.Text + "~" + degreeto.Text + "~" + chart.Text + "~" + aspecting.SelectedValue + "~" + loh.SelectedValue );
                TextBox1.Text = string.Empty;
                constellationbox.SelectedIndex = 0;
                ascendentbox.SelectedIndex = 0;
                degreefrom.Text = string.Empty;
                degreeto.Text = string.Empty;
                chart.SelectedIndex = 0;
                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
                DropDownList3.SelectedIndex = 0;
                DropDownList4.SelectedIndex = 0;
                loh.SelectedIndex = 0;
                page0.Text = string.Empty;
                book.Text = string.Empty;
                keystring.Text = string.Empty;

            }
                else if(DropDownList2.SelectedIndex!=0)
            {
                if (TextBox1.Text == "")
                {

                    TextBox1.Text = "0";
                }
              
                if (degreefrom.Text == "")
                {
                    degreefrom.Text = "0";
                }

                if (degreeto.Text == "")
                { 
                    degreeto.Text = "0"; 
                }


                ListBox1.Items.Add(DropDownList3.SelectedValue + "~" + DropDownList2.SelectedValue + "~" + DropDownList1.SelectedValue + "~" + ascendentbox.SelectedValue + "~" + TextBox1.Text + "~" + constellationbox.SelectedValue + "~" + degreefrom.Text + "~" + degreeto.Text + "~" + chart.Text + "~" + aspecting.SelectedValue + "~" + loh.SelectedValue);
                TextBox1.Text = string.Empty;
                ascendentbox.SelectedIndex = 0;
                constellationbox.SelectedIndex = 0;
                degreefrom.Text = string.Empty;
                degreeto.Text = string.Empty;
                chart.SelectedIndex = 0;
                DropDownList1.SelectedIndex = 0;
                loh.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
                DropDownList3.SelectedIndex = 0;
                DropDownList4.SelectedIndex = 0;
                aspecting.SelectedIndex = 0;
                page0.Text = string.Empty;
                book.Text = string.Empty;
                keystring.Text = string.Empty;
            }
            else if(DropDownList3.SelectedIndex!=0)
            {
                if (TextBox1.Text == "")
                {

                    TextBox1.Text = "0";

                }
                
                if (degreefrom.Text == "")
                {
                    degreefrom.Text = "0";
                }
                if (degreeto.Text == "")
                {
                    degreeto.Text = "0";
                }


                ListBox1.Items.Add(DropDownList3.SelectedValue + "~" + DropDownList2.SelectedValue + "~" + DropDownList1.SelectedValue + "~" + ascendentbox.SelectedValue + "~" + TextBox1.Text + "~" + constellationbox.SelectedValue + "~" + degreefrom.Text + "~" + degreeto.Text + "~" + chart.Text + "~" + aspecting.SelectedValue + "~" + loh.SelectedValue );
                TextBox1.Text = string.Empty;
                ascendentbox.SelectedIndex = 0;
                loh.SelectedIndex = 0;
                constellationbox.SelectedIndex = 0;
                degreefrom.Text = string.Empty;
                degreeto.Text = string.Empty;
                chart.SelectedIndex = 0;
                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
                DropDownList3.SelectedIndex = 0;
                DropDownList4.SelectedIndex = 0;
                aspecting.SelectedIndex = 0;
                page0.Text = string.Empty;
                book.Text = string.Empty;
                keystring.Text = string.Empty;
            }
            else if (loh.SelectedIndex!=0)
            {
                if (TextBox1.Text == "")
                {

                    TextBox1.Text = "0";

                }

                if (degreefrom.Text == "")
                {
                    degreefrom.Text = "0";
                }
                if (degreeto.Text == "")
                {
                    degreeto.Text = "0";
                }


                ListBox1.Items.Add(DropDownList3.SelectedValue + "~" + DropDownList2.SelectedValue + "~" + DropDownList1.SelectedValue + "~" + ascendentbox.SelectedValue + "~" + TextBox1.Text + "~" + constellationbox.SelectedValue + "~" + degreefrom.Text + "~" + degreeto.Text + "~" + chart.Text + "~" + aspecting.SelectedValue + "~" + loh.SelectedValue);
                TextBox1.Text = string.Empty;
                ascendentbox.SelectedIndex = 0;
                loh.SelectedIndex = 0;
                constellationbox.SelectedIndex = 0;
                degreefrom.Text = string.Empty;
                degreeto.Text = string.Empty;
                chart.SelectedIndex = 0;
                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
                DropDownList3.SelectedIndex = 0;
                DropDownList4.SelectedIndex = 0;
                aspecting.SelectedIndex = 0;
                page0.Text = string.Empty;
                book.Text = string.Empty;
                keystring.Text = string.Empty;
            }
            else if (TextBox1.Text!="")
            {
                if (TextBox1.Text == "")
                {

                    TextBox1.Text = "0";

                }
                
                if (degreefrom.Text == "")
                {
                    degreefrom.Text = "0";
                }
                if (degreeto.Text == "")
                {
                    degreeto.Text = "0";
                }


                ListBox1.Items.Add(DropDownList3.SelectedValue + "~" + DropDownList2.SelectedValue + "~" + DropDownList1.SelectedValue + "~" + ascendentbox.SelectedValue + "~" + TextBox1.Text + "~" + constellationbox.SelectedValue + "~" + degreefrom.Text + "~" + degreeto.Text + "~" + chart.Text + "~" + aspecting.SelectedValue + "~" + loh.SelectedValue );
                TextBox1.Text = string.Empty;
                ascendentbox.SelectedIndex = 0;
                constellationbox.SelectedIndex = 0;
                loh.SelectedIndex = 0;
                degreefrom.Text = string.Empty;
                degreeto.Text = string.Empty;
                chart.SelectedIndex = 0;
                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
                DropDownList3.SelectedIndex = 0;
                DropDownList4.SelectedIndex = 0;
                aspecting.SelectedIndex = 0;
                page0.Text = string.Empty;
                book.Text = string.Empty;
                keystring.Text = string.Empty;
            }
            else if (ascendentbox.SelectedIndex!=0)
            {
                if (TextBox1.Text == "")
                {

                    TextBox1.Text = "0";

                }
                
                if (degreefrom.Text == "")
                {
                    degreefrom.Text = "0";
                }
                if (degreeto.Text == "")
                {
                    degreeto.Text = "0";
                }


                ListBox1.Items.Add(DropDownList3.SelectedValue + "~" + DropDownList2.SelectedValue + "~" + DropDownList1.SelectedValue + "~" + ascendentbox.SelectedValue + "~" + TextBox1.Text + "~" + constellationbox.SelectedValue + "~" + degreefrom.Text + "~" + degreeto.Text + "~" + chart.Text + "~" + aspecting.SelectedValue + "~" + loh.SelectedValue);
                TextBox1.Text = string.Empty;
                ascendentbox.SelectedIndex = 0;
                loh.SelectedIndex = 0;
                constellationbox.SelectedIndex=0;
                degreefrom.Text = string.Empty;
                degreeto.Text = string.Empty;
                chart.SelectedIndex = 0;
                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
                DropDownList3.SelectedIndex = 0;
                DropDownList4.SelectedIndex = 0;
                aspecting.SelectedIndex = 0;
                page0.Text = string.Empty;
                book.Text = string.Empty;
                keystring.Text = string.Empty;
            }
            else if (constellationbox.SelectedIndex!=0)
            {
                if (TextBox1.Text == "")
                {

                    TextBox1.Text = "0";

                }
                
                if (degreefrom.Text == "")
                {
                    degreefrom.Text = "0";
                }
                if (degreeto.Text == "")
                {
                    degreeto.Text = "0";
                }


                ListBox1.Items.Add(DropDownList3.SelectedValue + "~" + DropDownList2.SelectedValue + "~" + DropDownList1.SelectedValue + "~" + ascendentbox.SelectedValue + "~" + TextBox1.Text + "~" + constellationbox.SelectedValue + "~" + degreefrom.Text + "~" + degreeto.Text + "~" + chart.Text + "~" + aspecting.SelectedValue + "~" + loh.SelectedValue);
                TextBox1.Text = string.Empty;
                ascendentbox.SelectedIndex = 0;
                loh.SelectedIndex = 0;
                constellationbox.SelectedIndex = 0;
                degreefrom.Text = string.Empty;
                degreeto.Text = string.Empty;
                chart.SelectedIndex = 0;
                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
                DropDownList3.SelectedIndex = 0;
                DropDownList4.SelectedIndex = 0;
                aspecting.SelectedIndex = 0;
                page0.Text = string.Empty;
                book.Text = string.Empty;
                keystring.Text = string.Empty;
            }
            else if (degreefrom.Text != "")
            {
                if (TextBox1.Text == "")
                {

                    TextBox1.Text = "0";

                }
                
                if (degreefrom.Text == "")
                {
                    degreefrom.Text = "0";
                }
                if (degreeto.Text == "")
                {
                    degreeto.Text = "0";
                }


                ListBox1.Items.Add(DropDownList3.SelectedValue + "~" + DropDownList2.SelectedValue + "~" + DropDownList1.SelectedValue + "~" + ascendentbox.SelectedValue + "~" + TextBox1.Text + "~" + constellationbox.SelectedValue + "~" + degreefrom.Text + "~" + degreeto.Text + "~" + chart.Text + "~" + aspecting.SelectedValue + "~" + loh.SelectedValue);
                TextBox1.Text = string.Empty;
                ascendentbox.SelectedIndex = 0;
                constellationbox.SelectedIndex = 0;
                loh.SelectedIndex = 0;
                degreefrom.Text = string.Empty;
                degreeto.Text = string.Empty;
                chart.SelectedIndex = 0;
                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
                DropDownList4.SelectedIndex = 0;
                DropDownList3.SelectedIndex = 0;
                aspecting.SelectedIndex = 0;
            }
            else if (degreeto.Text != "")
            {
                if (TextBox1.Text == "")
                {

                    TextBox1.Text = "0";

                }
                
                if (degreefrom.Text == "")
                {
                    degreefrom.Text = "0";
                }
                if (degreeto.Text == "")
                {
                    degreeto.Text = "0";
                }



                ListBox1.Items.Add(DropDownList3.SelectedValue + "~" + DropDownList2.SelectedValue + "~" + DropDownList1.SelectedValue + "~" + ascendentbox.SelectedValue + "~" + TextBox1.Text + "~" + constellationbox.SelectedValue + "~" + degreefrom.Text + "~" + degreeto.Text + "~" + chart.Text + "~" + aspecting.SelectedValue + "~" + loh.SelectedValue);
                TextBox1.Text = string.Empty;
                ascendentbox.SelectedIndex =0;
                constellationbox.SelectedIndex = 0;
                degreefrom.Text = string.Empty;
                degreeto.Text = string.Empty;
                loh.SelectedIndex = 0;
                chart.SelectedIndex = 0;
                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
                DropDownList3.SelectedIndex = 0;
                DropDownList4.SelectedIndex = 0;
                aspecting.SelectedIndex = 0;
                page0.Text = string.Empty;
                keystring.Text = string.Empty;
                book.Text = string.Empty;
            }
            else if (chart.Text != "")
            {
                if (TextBox1.Text == "")
                {

                    TextBox1.Text = "0";

                }
                
                if (degreefrom.Text == "")
                {
                    degreefrom.Text = "0";
                }
                if (degreeto.Text == "")
                {
                    degreeto.Text = "0";
                }


                ListBox1.Items.Add(DropDownList3.SelectedValue + "~" + DropDownList2.SelectedValue + "~" + DropDownList1.SelectedValue + "~" + ascendentbox.SelectedValue + "~" + TextBox1.Text + "~" + constellationbox.SelectedValue + "~" + degreefrom.Text + "~" + degreeto.Text + "~" + chart.Text + "~" + aspecting.SelectedValue + "~" + loh.SelectedValue);
                TextBox1.Text = string.Empty;
                ascendentbox.SelectedIndex = 0;
                constellationbox.SelectedIndex = 0;
                loh.SelectedIndex = 0;
                degreefrom.Text = string.Empty;
                degreeto.Text = string.Empty;
                chart.SelectedIndex = 0;
                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
                DropDownList3.SelectedIndex = 0;
                DropDownList4.SelectedIndex = 0;
                aspecting.SelectedIndex = 0;
                page0.Text = string.Empty;
                book.Text = string.Empty;
                keystring.Text = string.Empty;
            }
            else if (aspecting.SelectedIndex != 0)
            {
                if (TextBox1.Text == "")
                {

                    TextBox1.Text = "0";

                }

                if (degreefrom.Text == "")
                {
                    degreefrom.Text = "0";
                }
                if (degreeto.Text == "")
                {
                    degreeto.Text = "0";
                }


                ListBox1.Items.Add(DropDownList3.SelectedValue + "~" + DropDownList2.SelectedValue + "~" + DropDownList1.SelectedValue + "~" + ascendentbox.SelectedValue + "~" + TextBox1.Text + "~" + constellationbox.SelectedValue + "~" + degreefrom.Text + "~" + degreeto.Text + "~" + chart.Text + "~" + aspecting.SelectedValue + "~" + loh.SelectedValue);
                TextBox1.Text = string.Empty;
                ascendentbox.SelectedIndex = 0;
                constellationbox.SelectedIndex = 0;
                degreefrom.Text = string.Empty;
                loh.SelectedIndex = 0;
                degreeto.Text = string.Empty;
                chart.SelectedIndex = 0;
                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
                DropDownList3.SelectedIndex = 0;
                DropDownList4.SelectedIndex = 0;
                aspecting.SelectedIndex = 0;
                page0.Text = string.Empty;
                book.Text = string.Empty;
                keystring.Text = string.Empty;
            }
            else
            {

            }
        }
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        //div1.Attributes.Add("style", "visibility:hidden;");
       //div2.Attributes.Add("style", "visibility:hidden;");
        ListBox1.Items.Clear();

        TextBox1.Text = string.Empty;
        ascendentbox.SelectedIndex = 0;
        constellationbox.SelectedIndex = 0;
        degreefrom.Text = string.Empty;
        degreeto.Text = string.Empty;
        chart.SelectedIndex = 0;
        DropDownList1.SelectedIndex = 0;
        DropDownList2.SelectedIndex = 0;
        DropDownList3.SelectedIndex = 0;
        loh.SelectedIndex = 0;
        aspecting.SelectedIndex = 0;
        page0.Text = string.Empty;
        book.Text = string.Empty;
        keystring.Text = string.Empty;
        return;
    }
    
 
               



    protected void aa_a(object sender, EventArgs e)
    {
        
        Button btn = (Button)sender;

        
        GridViewRow gv = (GridViewRow)btn.NamingContainer;

        
        int rowindex = gv.RowIndex;
        string code = GridView1.Rows[rowindex].Cells[3].Text;
        DataSet ds = new DataSet();
        if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
        {

            ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
            ds = country.detaildescription(code.ToString());
         
            TextBox2.Text = GridView1.Rows[rowindex].Cells[3].Text + "   " + GridView1.Rows[rowindex].Cells[2].Text.ToString() + System.Environment.NewLine + System.Environment.NewLine + ds.Tables[0].Rows[0]["DESCCLOB"].ToString();
            return;
        }
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        string serverpath = "";

        string strFileName = File1.PostedFile.FileName;

        if (strFileName == "")
        {
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), Guid.NewGuid().ToString(), "alert('You have not Browse the File.');", true);
            return;
        }

        if (File1.PostedFile.ContentType == "image/pjpeg" || File1.PostedFile.ContentType == "image/gif" || File1.PostedFile.ContentType == "image/tiff" || File1.PostedFile.ContentType == "image/eps" || File1.PostedFile.ContentType == "image/pdf" || File1.PostedFile.ContentType == "image/tif" || File1.PostedFile.ContentType == "image/jpg")
        {

            for (int i = 0; i < ListBox2.Items.Count; i++)
            {
                if (strFileName.Split('\\')[strFileName.Split('\\').Length - 1] == ListBox2.Items[i].Value)
                {
                    ScriptManager.RegisterStartupScript(this.Page, this.GetType(), Guid.NewGuid().ToString(), "alert('You have already attached this File.');", true);
                    return;
                }

            }




            serverpath = Server.MapPath("Attachment/");
            string fname = System.IO.Path.GetFileName(strFileName);
            File1.PostedFile.SaveAs(Path.Combine(serverpath, fname));
            hiddenfilename.Value = hiddenfilename.Value + fname + ":";

            string filelst = hiddenfilename.Value;
            string[] arr = filelst.Split(':');
            ListBox2.DataSource = arr;
            ListBox2.DataBind();


            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), Guid.NewGuid().ToString(), "alert('File Attached Successfully.');", true);
            return;
        }

        else
        {
            message = "Upload status: Only JPEG,gif,tif,eps files are accepted!";
            AspNetMessageBox(message);
            return;
        }

    }

   
    
}
