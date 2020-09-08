var buf = "";
var buf2 = "";
var buf3 = "";
var flag = 0;
var exp1 = "";
var exp2 = "";
var exp3 = "";
function bind_filter2() {
    var filter1 = document.getElementById('filter1').value;
    var res = hoarary_knowledge.fill_filer(filter1);
    
    var ds = res.value;
    var edtn = $("filter2");
    edtn.options.length = 1;
    edtn.options[0] = new Option("----Select Filter---", "0");
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        for (var i = 0; i < ds.Tables[0].Rows.length; i++) {
            edtn.options[edtn.options.length] = new Option(ds.Tables[0].Rows[i].FILTER2, ds.Tables[0].Rows[i].FILTER2)
            edtn.options.length;
}
}
}

function opengrid() {

    var filter1 = document.getElementById('filter1').value;
    var filter2 = document.getElementById('filter2').value;
    var res = hoarary_knowledge.fill_grid(filter1, filter2, callback_grid);
    return false;
}
function callback_grid(res) {
    var exec_data = res.value;

    dsgrid = exec_data;
    document.getElementById('hdsviewgrid').innerHTML = "";
    document.getElementById('Divgrid1').style.display = "none";
    if (exec_data.Tables[0].Rows.length >= 0) {
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
        buf2 += "<td class='colum-td-head_new'  >" + "EXPLANATION1" + "</td>"
        buf2 += "<td class='colum-td-head_new'>" + "EXPLANATION2" + "</td>"
        buf2 += "<td class='colum-td-head_new'>" + "EXPLANATION3" + "</td>"
        

        buf2 += "</tr>"
        len = 1;


        if (dsgrid.Tables[0].Rows.length > 0) {

            for (i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {


                buf2 += "<tr>"


                buf2 += "<td class=''>"
                buf2 += "<font width='90px' >" + (exec_data.Tables[0].Rows[i]['EXPLANATION1']) + "</font>"
                buf2 += "<input type='hidden' id=exp2_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['EXPLANATION1']) + "> "
                buf2 += "</td>"



                buf2 += "<td  class=''>"
                buf2 += "<font width='90px' >"  +(exec_data.Tables[0].Rows[i]['EXPLANATION2']) + "</font>"
                buf2 += "<input type='hidden' id=exp2_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['EXPLANATION2']) + "> "
                buf2 += "</td>"

                if (dsgrid.Tables[0].Rows[i]['EXPLANATION3'] == null) {

                    buf2 += "<td class=''>"
                    buf2 += "<font width='90px' >" +  "</font>"
                    buf2 += "<input type='hidden' id=exp3_" + i + "  value =''> "
                    buf2 += "</td>"
                }

                else {
                    buf2 += "<td class=''>"
                    buf2 += "<font width='90px' >" + (exec_data.Tables[0].Rows[i]['EXPLANATION3']) + "</font>"
                    buf2 += "<input type='hidden' id=exp3_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['EXPLANATION3']) + "> "
                    buf2 += "</td>"
                }




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


function Clicked(event) {


    var obj = event.srcElement || event.target || event.NODE_ID;
    var seltreeNode = obj;
    var nl = document.getElementById('hdnnl').value;
    var nla=nl.split('~');

    if (seltreeNode.innerHTML == '') {
        
    }
    else {
      
        var id = TreeView1_Data.selectedNodeID.value;  //Get the Selectednode id of tv with asp.net id of TreeView2
        if (id.length > 0) {
            
            var selectedNode = document.getElementById(id);  //Get the Selectnode object  -> selectedNode.innerText will give you the text of the node
            if ((typeof (selectedNode) != "undefined") && (selectedNode != null)) {
                
              
                var nodeDepth = selectedNode.href.split('\\\\')
                 if (nodeDepth.length <= 1)
                 {
                     var nodeDepth = selectedNode.href.split('s')
                 }
                // the separator is the default single \. Tv adds the extra on and of course we have to add 2 for the string literals.
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


        var res = hoarary_knowledge.show_exp1(nodeid);

        var ds = res.value;
        if (ds.Tables[0].Rows.length > 0) {
          
            document.getElementById('Label4').innerHTML = ds.Tables[0].Rows[0]["GROUP_NAME"];
            document.getElementById('Label4').style.color = "Blue";

            

            if (ds.Tables[0].Rows[0]["EXPLANATION"] != "" && ds.Tables[0].Rows[0]["EXPLANATION"] != null) {
                buf = "";
                flag = 0;
                var ex1 = ds.Tables[0].Rows[0]["EXPLANATION"].split(' ');

                for (var i = 0; i < ex1.length - 1; i++) {
                    for (var j = 0; j < nla.length - 1; j++) {

                        exp1 = ex1[i] + " ";
                       exp1 = exp1.replace("<p>&nbsp;</p><p>&nbsp;", "");
                       exp1 = exp1.replace("/>", "");
                        if (exp1.startsWith(nla[j]) == true) {
                           
                            buf += "<a runat='server' id=e_" + i + "  value =" + exp1 + " onclick='tb1_TextChanged(id);' style='cursor:pointer;color:blue;'>" + exp1 + "</a>"
                            flag = 1;

                        }




                    }
                    if (flag == 0) {
                        
                        
                        buf += "<a runat='server'>" + exp1 + "</a>"
                    }
                    else {
                        flag = 0;
                    }

                }


                document.getElementById('data_shoe_div').style.visibility = 'visible';
                document.getElementById('data_shoe_div').style.border = '1px solid #777';
                document.getElementById('data_shoe_div').style.boxSizing = 'border-box';
                document.getElementById('data_shoe_div').style.padding = '6px 10px';
                document.getElementById('data_shoe_div').style.borderRadius = '4px';
                document.getElementById('Label3').innerHTML = "EXPLANATION 1";
                document.getElementById('data_shoe_div').innerHTML = buf //ds.Tables[0].Rows[0]["EXPLANATION"];


            }
            else {
                document.getElementById('data_shoe_div').style.visibility = 'hidden';
                document.getElementById('Label3').innerHTML = '';


            }

            if (ds.Tables[0].Rows[0]["EXPLANATION2"] != "" && ds.Tables[0].Rows[0]["EXPLANATION2"] != null) {
                buf2 = "";
                flag = 0;
                var ex2 = ds.Tables[0].Rows[0]["EXPLANATION2"].split(' ');

                for (var i = 0; i < ex2.length - 1; i++) {
                    for (var j = 0; j < nla.length - 1; j++) {

                        exp2 = ex2[i] + " ";
                        exp2 = exp2.replace("<p>&nbsp;</p><p>&nbsp;", "");
                        exp2 = exp2.replace("/>", "");


                        if (exp2.startsWith(nla[j]) == true) {
                          
                            buf2 += "<a runat='server' id=e2_" + i + "  value =" + exp2 + " onclick='tb1_TextChanged(id);' style='cursor:pointer;color:blue;'>" + exp2 + "</a>"
                            flag = 1;

                        }




                    }
                    if (flag == 0) {
                       
                        buf2 += "<a runat='server'>" + exp2 + "</a>"
                    }
                    else {
                        flag = 0;
                    }

                }
                document.getElementById('data_shoe_div1').style.visibility = 'visible';
                document.getElementById('data_shoe_div1').style.border = '1px solid black';
                document.getElementById('Label1').innerHTML = "EXPLANATION 2";
                document.getElementById('data_shoe_div1').innerHTML =buf2 // ds.Tables[0].Rows[0]["EXPLANATION2"];


            }
            else {
                document.getElementById('data_shoe_div1').style.visibility = 'hidden';
                document.getElementById('Label1').innerHTML = '';



            }

            if (ds.Tables[0].Rows[0]["EXPLANATION3"] != "" && ds.Tables[0].Rows[0]["EXPLANATION3"] != null) {
                buf3= "";
                flag = 0;
                var ex3 = ds.Tables[0].Rows[0]["EXPLANATION3"].split(' ');

                for (var i = 0; i < ex3.length - 1; i++) {
                    for (var j = 0; j < nla.length - 1; j++) {

                        exp3 = ex3[i] + " ";
                        exp3 = exp3.replace("<p>&nbsp;</p><p>&nbsp;", "");
                        exp3 = exp3.replace("/>", "");


                        if (exp3.startsWith(nla[j]) == true) {
                           
                            buf3 += "<a runat='server' id=e3_" + i + "  value =" + exp3 + " onclick='tb1_TextChanged(id);' style='cursor:pointer;color:blue;'>" + exp3 + "</a>"
                            flag = 1;

                        }




                    }
                    if (flag == 0) {
                        
                        buf3 += "<a runat='server'>" + exp3 + "</a>"
                    }
                    else {
                        flag = 0;
                    }

                }
                document.getElementById('data_shoe_div2').style.visibility = 'visible';
                document.getElementById('data_shoe_div2').style.border = '1px solid black';
                document.getElementById('Label2').innerHTML = "EXPLANATION 3";
                document.getElementById('data_shoe_div2').InnerHtml =buf3 // ds.Tables[0].Rows[0]["EXPLANATION3"];



            }
            else {

                document.getElementById('data_shoe_div2').style.visibility = 'hidden';
                document.getElementById('Label2').innerHTML = '';




            }

        }

        return false;
    }
}

function tb1_TextChanged(id)
{
   
    var v = document.getElementById(id).innerHTML.slice(0, -1);
    document.getElementById('tb1').value = v;
    document.getElementById('tb1').focus();
    
}