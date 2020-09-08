function datasubmit() {
   
        var node_name = document.getElementById('node_name').value;

        var group = document.getElementById('group_text').value;
        var explanation = document.getElementById('explanation_text').value;
        var drop = document.getElementById('drop_parent').value;
        if (drop == 'Child') {
            under_node_id = 'B'; 
            astro_tree.check_node(node_name, drop, under_node_id,callback_f1grid);

        }
        if (drop == 'Parent') {
            document.getElementById('Divgrid1').style.display = "none";
        }
        return false;
}

var grid_ds = "";
    
function callback_f1grid(res) {
       // var ds = ds.value;

        grid_ds = res.value;
        if (grid_ds.Tables[0].Rows.length == 0) {
            alert('There is no node')
            return false;
        }
        if (grid_ds.Tables[0].Rows.length > 0) {

            document.getElementById('hdsviewgrid').innerHTML = "";
            document.getElementById('Divgrid1').style.display = "none";
            if (grid_ds.Tables[0].Rows.length >= 0) {
                document.getElementById('hdsviewgrid').innerHTML = "";
                document.getElementById('Divgrid1').style.display = 'block';
                $('Divgrid1').display = 'block;'


                document.getElementById('Divgrid1').style.BackColor = "Ivory";
                var temp_del1 = "";

                flg_req = "yes"
                var aa1 = "";
                var aa = "";
                var hs = 0;
                var hs1 = 0;

                document.getElementById('hdsviewgrid').style.display = "block";

                if (document.getElementById("hdsviewgrid").children.length == "0") {
                    klen = "0"
                }
                else {
                    klen = document.getElementById("Divgrid1").childNodes[0].childNodes[0].childNodes.length - 1;
                    IntializeNumber = klen + 1;
                }

                if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:460px;display:block") <= 0) {
                    aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
                }
                buf2 = "";
                buf2 += "<table  id='Divgrid1' runat='server' align='left' ' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
                buf2 += "<tr>"
                buf2 += "<td class='colum-td-head_new'>" + "Check" + "</td>"
                buf2 += "<td class='colum-td-head_new'>" + "GROUP_NAME" + "</td>"
                buf2 += "<td class='colum-td-head_new'>" + "NODE_NAME" + "</td>"
                buf2 += "<td class='colum-td-head_new'>" + "UNDER_NODE_ID" + "</td>"               
                buf2 += "<td class='colum-td-head_new'  >" + "NODE_ID" + "</td>"
//                buf2 += "<td class='colum-td-head_new'>" + "EXPLANATION" + "</td>"


                buf2 += "</tr>"
                len = 1;


                if (grid_ds.Tables[0].Rows.length > 0) {

                    for (i = 0; i < grid_ds.Tables[0].Rows.length; ++i) {


                        buf2 += "<tr >"
                        buf2 += "<td class='retro-1'>"
                        buf2 += "<input type='radio' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "' onClick='javascript:return chkallinto(this.id);'   >"
                        buf2 += "</td>"

                        buf2 += "<td class='colum-td'>"
                        buf2 += "<font width='90px' >" + (grid_ds.Tables[0].Rows[i]['GROUP_NAME']) + "</font>"
                        buf2 += "<input type='hidden' id=group_" + i + "  value =" + (grid_ds.Tables[0].Rows[i]['GROUP_NAME']) + "> "
                        buf2 += "</td>"
                     



                        buf2 += "<td  class='colum-td'>"
                        buf2 += "<font width='90px' >" + (grid_ds.Tables[0].Rows[i]['NODE_NAME']) + "</font>"
                        buf2 += "<input type='hidden' id=nodename_" + i + "  value =" + (grid_ds.Tables[0].Rows[i]['NODE_NAME']) + "> "
                        buf2 += "</td>"


                        buf2 += "<td class='colum-td'>"
                        buf2 += "<font width='90px' >" + (grid_ds.Tables[0].Rows[i]['UNDER_NODE_ID']) + "</font>"
                        buf2 += "<input type='hidden' id=undernodeid_" + i + "  value =" + (grid_ds.Tables[0].Rows[i]['UNDER_NODE_ID']) + "> "
                        buf2 += "</td>"

                     buf2 += "<td class='colum-td'>"
                        buf2 += "<font width='90px' >" + (grid_ds.Tables[0].Rows[i]['NODE_ID']) + "</font>"
                        buf2 += "<input type='hidden' id=nodeid_" + i + "  value =" + (grid_ds.Tables[0].Rows[i]['NODE_ID']) + "> "
                        buf2 += "</td>"
                       

//                        buf2 += "<td class='colum-td'>"
//                        buf2 += "<font width='90px' >" + (grid_ds.Tables[0].Rows[i]['EXPLANATION']) + "</font>"
//                        buf2 += "<input type='hidden' id=exp_" + i + "  value =" + (grid_ds.Tables[0].Rows[i]['EXPLANATION']) + "> "
//                        buf2 += "</td>"





                        buf2 += "</tr>"

                    }
                }

                buf2 += "</table>"
                var hdsview = "";
                temp_del1 = aa + buf2.toString();
                temp_del1 = temp_del1.replace("<TBODY>", "")
                temp_del1 = temp_del1.replace("</TBODY>", "")
                document.getElementById('hdsviewgrid').innerHTML = temp_del1;






            }
           

        }

      
    }

    function datasave() {
        var exp2 = document.getElementById('explanation_text2').value;
        var exp3 = document.getElementById('explanation_text3').value;
        var drop = document.getElementById('drop_parent').value;
        if (drop == 'Parent') 
        {

            var node_name = document.getElementById('node_name').value;
            if (node_name == '')
             {
                alert('Please Enter Node Name');
                return false;
            }
            var explanation = document.getElementById('explanation_text').value;
            var group = document.getElementById('node_name').value;
            var under_node_id = 0;

            var res = astro_tree.check_node(node_name, drop,under_node_id);
            var ds = res.value;
            if (ds.Tables[0].Rows.length > 0)
             {
                alert('Data Already Exist')
                return false;
            }
            if (ds.Tables[0].Rows.length == 0)
             {var id = 'B';
                var under_node_id = 0;
                astro_tree.save_data(node_name, group, explanation, under_node_id, id, exp2, exp3);
                alert('Data Saved')
                return false;
            }

        }

        if (drop == 'Child') 
        {

          
            var node_name = document.getElementById('node_name').value;

            if (node_name == '') 
            {
                alert('Please Enter Node Name');
                return false;
            }
            
            var explanation = document.getElementById('explanation_text').value;
            for (i = 0; i < grid_ds.Tables[0].Rows.length; ++i)
             {
                 if (document.getElementById('chkboxinto_' + i).checked == true)
                
                 {
                    under_node_id = grid_ds.Tables[0].Rows[i]['NODE_ID'];
                    var res = astro_tree.check_node(node_name,drop, under_node_id );
                    var ds = res.value;
                    if (ds.Tables[0].Rows.length > 0)
                     {
                        alert('Data Already Exist')
                        return false;
                    }
                    if (ds.Tables[0].Rows.length == 0) {
                        var id = grid_ds.Tables[0].Rows[i]['NODE_ID'];
                        group = grid_ds.Tables[0].Rows[i]['GROUP_NAME'] +' '+ '~' +' '+ document.getElementById('node_name').value;
                        astro_tree.save_data(node_name, group, explanation, under_node_id, id, exp2, exp3);
                         alert('Data Save')
                         datasubmit();
                         return false; 
                    }

                }


            }



        }
        
    }




    function chkallinto(id) {

        var nyc = id.split('_');
        var sapl = nyc[1];

        

        for (i = 0; i < grid_ds.Tables[0].Rows.length; ++i) {
            (document.getElementById('chkboxinto_' + i).checked = false)       
                
                
                                

                             }
                             document.getElementById('chkboxinto_' + sapl).checked = true;
               
   }

