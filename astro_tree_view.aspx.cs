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
using System.Collections.Generic;
using System.Drawing;



public partial class astro_tree_view : System.Web.UI.Page
{
    string usermail = "";
   
    string under_node_id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["usermail"] == null || Session["usermail"] == "")
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(astro_tree_view), "wq", "window.parent.location.href='login.aspx';", true);
            return;
        } 
        usermail = Request.QueryString["usermail"];
        hdnuser.Value = Request.QueryString["usermail"];
        if (usermail != Session["usermail"].ToString())
        {
            ScriptManager.RegisterClientScriptBlock(this, typeof(astro_tree_view), "wq", "window.parent.location.href='login.aspx';", true);
            //Response.Redirect("login.aspx");
            return;

        }
        tb1.Focus();

        data_shoe_div2.Attributes.Add("style", "visibility:hidden;");
        data_shoe_div.Attributes.Add("style", "visibility:hidden;");
        data_shoe_div1.Attributes.Add("style", "visibility:hidden;");

       
       
        if (!Page.IsPostBack)
        {
          
            
            Ajax.Utility.RegisterTypeForAjax(typeof(astro_tree_view));

            TreeView1.Attributes.Add("onclick", "javascript:return Clicked(event);");
            calltree(null);
            DataSet ds = new DataSet();
          

            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();

                ds = country.ast_rights(Request.QueryString["usermail"].ToString());

            }
            if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Both")
            {
                return;

            }
            if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Natal")
            {

                horarydiv.Attributes.Add("style", "display:none;");
                // a8.Attributes.Add("style", "display:none;");
                //a7l.Attributes.Add("style", "display:none;");
                //a8l.Attributes.Add("style", "display:none;");
                //horarycombina.Attributes.Add("style", "visibility:hidden;");
                return;
            }
            if (ds.Tables[0].Rows[0]["SUBSCRIPTION"].ToString() == "Horary")
            {
                // a2.Attributes.Add("style", "display:none;");
                nataldiv.Attributes.Add("style", "display:none;");
                //a2l.Attributes.Add("style", "display:none;");
                //a3l.Attributes.Add("style", "display:none;");
                //a4l.Attributes.Add("style", "display:none;");
                //a5l.Attributes.Add("style", "display:none;");
                //a6l.Attributes.Add("style", "display:none;");

                // d2.Attributes.Add("style", "visibility:hidden;");
                //yoga.Attributes.Add("style", "visibility:hidden;");
                //astrocalc.Attributes.Add("style", "visibility:hidden;");
                return;

            }
            //tb1.Attributes.Add("onkeyup", "javascript:return __doPostBack();");
        }
    
    }
   
    TreeNode FindNameInTreeView(TreeNode node, String name)
    {
       
        if (node == null)
            return null;

       
        if (node.Value == name)
            return node;

      
        for (int i = 0; i < node.ChildNodes.Count; i++)
        {
           
            TreeNode foundNode = FindNameInTreeView(node.ChildNodes[i], name);
           
            if (foundNode != null)
                return foundNode;
        }
   
        return null;
    }


    public void calltree(string under_node_id)
    {
        TreeView1.Nodes.Clear();
        DataSet dsj = new DataSet();
        string page_name = "";

            if (ConfigurationSettings.AppSettings["ConnectionType"].ToString() == "orcl")
            {
                ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
                dsj = country.fetch_tree("");

            }
        
     

        TreeNode root = new TreeNode();
        string formName;
        string formId;
        string childId;
        string parentId;

        for (int h = 0; h < dsj.Tables[0].Rows.Count; h++)
        {
            formName = dsj.Tables[0].Rows[h]["NODE_NAME"].ToString();
            parentId = dsj.Tables[0].Rows[h]["UNDER_NODE_ID"].ToString();
            childId = dsj.Tables[0].Rows[h]["NODE_ID"].ToString();
            formId = dsj.Tables[0].Rows[h]["NODE_ID"].ToString();

            TreeNode node = new TreeNode();
            node.Text = formName;
            node.Value = childId;
            
      
            node.Text = node.Text; 
       

            TreeNode parentNode = null;
           
           parentNode = FindNameInTreeView(root, parentId);

            if (parentNode != null)
            {
               
                parentNode.ChildNodes.Add(node);
            }
            else
            {
               
              root.ChildNodes.Add(node);
            
            }
            
            node.SelectAction = TreeNodeSelectAction.Select;
        }

        root.Text = "Astro Knowledge";
        root.Target = "doc";
        root.Text =  root.Text;
       TreeView1.Nodes.Add(root);
        TreeView1.CollapseAll();
        TreeView1.RootNodeStyle.Font.Bold = true;
        TreeView1.RootNodeStyle.Font.Size = 11;
        
        TreeView1.ParentNodeStyle.Font.Size = 10;
        TreeView1.RootNodeStyle.ForeColor = Color.Black;
      
       // iframe1.InnerHtml = TreeView1.DataSource.ToString();
    }


    private void expandTree(TreeNode node)
    {
        if (node.Depth == 0)
        {
            node.Expand();
        }
        else
        {

            node.CollapseAll();
        }
    }
    protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
    {
        ////data_tree.Attributes.Add("style", "top:0;");

        //if (TreeView1.SelectedNode.Expanded == true)
        //{
        //    TreeView1.SelectedNode.Collapse();
        //}
        //else
        //{
        //    TreeView1.SelectedNode.Expand();
        //}
        ////expandTree(TreeView1.SelectedNode);
        //TreeView1.SelectedNodeStyle.ForeColor = Color.Crimson;
        //TreeView1.SelectedNodeStyle.BorderWidth = 1;
        //TreeView1.SelectedNodeStyle.BorderColor = Color.AliceBlue;
        //TreeView1.SelectedNodeStyle.Font.Bold = true;

        //// TreeView1.SelectedNode.Expand();
        //string t = TreeView1.SelectedNode.Value;
        //Label4.Text = TreeView1.SelectedNode.Text;
        //Label4.ForeColor = Color.Blue;



        //DataSet ds = new DataSet();
        //ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
        //ds = country.fetch_treeexplation(t);


        //if (ds.Tables[0].Rows.Count > 0)
        //{

        //    if (ds.Tables[0].Rows[0]["EXPLANATION"].ToString() != "")
        //    {
        //        Label3.Text = "EXPLANATION 1";
        //        data_shoe_div.InnerHtml = ds.Tables[0].Rows[0]["EXPLANATION"].ToString();
        //        data_shoe_div.Visible = true;
        //    }
        //    else
        //    {
        //        Label3.Text = "";
        //        data_shoe_div.InnerHtml = ds.Tables[0].Rows[0]["EXPLANATION"].ToString();
        //        data_shoe_div.Visible = false;
        //    }
        //    if (ds.Tables[0].Rows[0]["EXPLANATION2"].ToString() != "")
        //    {
        //        Label1.Text = "EXPLANATION 2";
        //        data_shoe_div1.InnerHtml = ds.Tables[0].Rows[0]["EXPLANATION2"].ToString();
        //        data_shoe_div1.Visible = true;
        //    }
        //    else
        //    {
        //        Label1.Text = "";
        //        data_shoe_div1.InnerHtml = ds.Tables[0].Rows[0]["EXPLANATION2"].ToString();
        //        data_shoe_div1.Visible = false;
        //    }
        //    if (ds.Tables[0].Rows[0]["EXPLANATION3"].ToString() != "")
        //    {
        //        Label2.Text = "EXPLANATION 3";
        //        data_shoe_div2.InnerHtml = ds.Tables[0].Rows[0]["EXPLANATION3"].ToString();
        //        data_shoe_div2.Visible = true;
        //    }
        //    else
        //    {
        //        Label2.Text = "";
        //        data_shoe_div2.InnerHtml = ds.Tables[0].Rows[0]["EXPLANATION3"].ToString();
        //        data_shoe_div2.Visible = false;
        //    }

        //}


        //return;
    }


   


   protected void tb1_TextChanged(object sender, EventArgs e)
   {
     
       Label2.Text = "";
      
       Label1.Text = "";
      
       Label3.Text = "";
       data_shoe_div2.Attributes.Add("style", "visibility:hidden;");
       data_shoe_div.Attributes.Add("style", "visibility:hidden;");
       data_shoe_div1.Attributes.Add("style", "visibility:hidden;");

       
       
       calltree(null);
       if (tb1.Text == "")
       {
           calltree(null);
           return;
       }
       TreeNode oMainNode = TreeView1.Nodes[0];
       TreeView1.Nodes.Clear();
        PrintNodesRecursive(oMainNode);
        return;
            
     
   }
  
       string page_name = "";

       TreeNode root = new TreeNode();
       string formName;
       string formId;
       string childId;
       string parentId;
       string flag = "0";
       string main = "";
       string v1 = "";
       public void PrintNodesRecursive(TreeNode oMainNode)
       {

           foreach (TreeNode osubnode in oMainNode.ChildNodes)
           {

               string pid = oMainNode.ValuePath.ToString();
               string[] tokens = pid.Split('/');
               int count = int.Parse(tokens.Length.ToString());

               if (pid == "" || pid == "Astro Knowledge")
               {
                   v1 = osubnode.Text.ToUpper();
                   under_node_id = "0";
                   flag = "0";
               }
               else
               {
                   under_node_id = oMainNode.Value.ToString();
               }


               string cid = osubnode.ValuePath.ToString();
               string[] ctokens = cid.Split('/');
               int ccount = int.Parse(ctokens.Length.ToString());

               string v3 = ctokens[1].ToString();
               string v4 = "";
               string c = "";
               if (oMainNode.Text == "Astro Knowledge")
               {
                   if (flag == "0")
                   {
                       v4 = v3;
                       main = v3;
                       flag = "1";
                   }
               }
               else
               {
                   v4 = tokens[1].ToString();
               }


               string v2 = tb1.Text.ToUpper();
               string p = "";
               if (v1.StartsWith(v2))
               {
                   p = "YES";
               }

               if (v3 == main)
               {
                   c = "YES";

               }
               if (p == "YES" && c == "YES")
               {




                   formName = osubnode.Text.ToString();
                   parentId = under_node_id;
                   childId = osubnode.Value.ToString();
                   formId = osubnode.Value.ToString();

                   TreeNode node = new TreeNode();
                   node.Text = formName;
                   node.Value = childId;






                   node.Text = node.Text;


                   TreeNode parentNode = null;
                   foreach (TreeNode childTN in TreeView1.Nodes)
                   {
                       parentNode = FindNameInTreeView(childTN, parentId);
                       if (parentNode != null) break;
                   }
                   //parentNode = FindNameInTreeView(root, parentId);

                   if (parentNode != null)
                   {

                       parentNode.ChildNodes.Add(node);
                   }
                   else
                   {
                       TreeView1.Nodes.Add(node);
                       // root.ChildNodes.Add(node);



                   }

                   node.SelectAction = TreeNodeSelectAction.Select;

                   PrintNodesRecursive(osubnode);

               }

           }






           root.Text = "Astro Knowledge";
           root.Target = "doc";
           root.Text = root.Text;

           //TreeView1.Nodes.Add(root);
           // TreeView1.ExpandAll();
           //TreeView1.RootNodeStyle.CssClass = "hideRoot";
           TreeView1.ParentNodeStyle.Font.Size = 10;
           TreeView1.RootNodeStyle.ForeColor = Color.Black;

           /////vishu//////////

       }

    
    [Ajax.AjaxMethod]
   public DataSet show_exp1(string t)
    {
        DataSet ds = new DataSet();
        ASTROLOGY.classesoracle.Houseposition country = new ASTROLOGY.classesoracle.Houseposition();
        ds = country.fetch_treeexplation(t);

        return ds;
    }
  
}