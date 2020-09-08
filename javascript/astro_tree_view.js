var tree = "";
var astro_tree_view = "";
function tree_call(under_node_id) {
    
   var res= astro_tree_view.calltree(under_node_id,callback_tree);
    return false;
   
}
var grid_ds = "";

function callback_tree(res) {
    grid_ds = res.value;

    for (i = 0; i < grid_ds.Tables[0].Rows.length; ++i)
     {
    tree+=tree;
    tree += "<div style=\"OVERFLOW: auto; WIDTH: 170; HEIGHT: 480px\"><table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"180\" id = 'table1' >";
    tree += "<tr>";
    tree += "<td valign=\"top\">";
//    tree += "<a id='nodename_' style='cursor:hand;cursor:pointer' <a href=\"open_node(this.id)\" class=\"folder\"><img src=\"Image/plus.gif\"\">" + grid_ds.Tables[0].Rows[i]["NODE_NAME"] + "</a>";
    tree += "<a id=nodename_" + i + " runat='server' onclick='javascript:tree_call("+grid_ds.Tables[0].Rows[i]["NODE_ID"]+");' style='cursor:pointer; color:red;'  class=\"folder\"><img src=\"Image/plus.gif\"\">" + grid_ds.Tables[0].Rows[i]["NODE_NAME"] + "</a>"

    tree += "</td >";
    tree += "</tr>";          
    tree += "</table>";
    tree += "</div>";
}
document.getElementById('data_tree').innerHTML = tree;
return false;
}



function Clicked(event) {
   
    
    var obj = event.srcElement || event.target || event.NODE_ID;
    var seltreeNode = obj;

  
    
    if (seltreeNode.innerHTML == '') {

    }
    else
    {
       
        document.getElementById('Label4').innerHTML = seltreeNode.innerHTML;
        document.getElementById('Label4').style.color = "Blue";
        var id = TreeView1_Data.selectedNodeID.value;  //Get the Selectednode id of tv with asp.net id of TreeView2
        if (id.length > 0) {
            var selectedNode = document.getElementById(id);  //Get the Selectnode object  -> selectedNode.innerText will give you the text of the node
            if ((typeof (selectedNode) != "undefined") && (selectedNode != null)) {
                //Determine the depth of the select node
                var nodeDepth = selectedNode.href.split('\\\\')  // the separator is the default single \. Tv adds the extra on and of course we have to add 2 for the string literals.
                //node depth wil always be one more than the real node depth, so root is one.
                if (nodeDepth.length >= 2) {
                    var nodeid = nodeDepth[nodeDepth.length - 1];
                    nodeid = nodeid.replace("%20", " ");
                    nodeid = nodeid.replace("%20", " ");

                    nodeid = nodeid.replace("%20", " ");
                    nodeid = nodeid.replace("%20", " ");

                    nodeid = nodeid.replace("%20", " ");
                    nodeid = nodeid.replace("%20", " ");

                    nodeid = nodeid.replace("%20", " ");
                    nodeid = nodeid.replace("%20", " ");
                  
                    nodeid = nodeid.slice(0, -2);
                }
            }
        }
         
        
        var res = astro_tree_view.show_exp1(nodeid);
        
        var ds = res.value;
        if (ds.Tables[0].Rows.length > 0) {

            if (ds.Tables[0].Rows[0]["EXPLANATION"] != "" && ds.Tables[0].Rows[0]["EXPLANATION"] != null) {
                document.getElementById('data_shoe_div').style.visibility = 'visible';
                document.getElementById('data_shoe_div').style.border = '1px solid black';
                document.getElementById('Label3').innerHTML = "EXPLANATION 1";
                document.getElementById('data_shoe_div').innerHTML = ds.Tables[0].Rows[0]["EXPLANATION"];
               
                
            }
            else
            {
                document.getElementById('data_shoe_div').style.visibility = 'hidden';
                document.getElementById('Label3').innerHTML = '';
                
                
            }

            if (ds.Tables[0].Rows[0]["EXPLANATION2"] != "" && ds.Tables[0].Rows[0]["EXPLANATION2"] != null) {

                document.getElementById('data_shoe_div1').style.visibility = 'visible';
                document.getElementById('data_shoe_div1').style.border = '1px solid black';
                document.getElementById('Label1').innerHTML = "EXPLANATION 2";
                document.getElementById('data_shoe_div1').innerHTML = ds.Tables[0].Rows[0]["EXPLANATION2"];
                

            }
            else
            {
                document.getElementById('data_shoe_div1').style.visibility = 'hidden';
                document.getElementById('Label1').innerHTML = '';
                
                

            }

            if (ds.Tables[0].Rows[0]["EXPLANATION3"] != "" && ds.Tables[0].Rows[0]["EXPLANATION3"] != null) {

                document.getElementById('data_shoe_div2').style.visibility = 'visible';
                document.getElementById('data_shoe_div2').style.border = '1px solid black';
                document.getElementById('Label2').innerHTML = "EXPLANATION 3";
                document.getElementById('data_shoe_div2').InnerHtml = ds.Tables[0].Rows[0]["EXPLANATION3"];
                

             
            }
            else {

                document.getElementById('data_shoe_div2').style.visibility = 'hidden';
                document.getElementById('Label2').innerHTML = '';
                
                

             
            }

        }

        return false;
    }
}



 