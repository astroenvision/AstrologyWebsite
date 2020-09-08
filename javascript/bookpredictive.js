var book_predictive = "";
var browser = navigator.appName;
var buf2 = new StringBuffer2();
var bold="0";
var flag="0";
var flag1="0";
var flag2="0";




function StringBuffer2() {
    this.buffer = [];
}

StringBuffer2.prototype.append = function append(string) {
    this.buffer.push(string);
    return this;
}

function StringBuffer2() {
    this.buffer = [];
}

StringBuffer2.prototype.append = function append(string) {
    this.buffer.push(string);
    return this;
}

StringBuffer2.prototype.toString = function toString() {
    return this.buffer.join("");
}

function bookpredictive() {
    var bookname = document.getElementById('b1').value;
    fil=document.getElementById('f1').value;
    book_predictive.searchp(bookname,fil, execute_callback);
    return false;


}


function searchid() {
    var unique = document.getElementById('unique').value;
    book_predictive.searchbyid(unique, execute_callback);
    return false;


}



function execute_callback(val) {
 
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
    exec_data = val.value;
    var i = 0
 document.getElementById('lc').innerHTML = 'Count = ' + exec_data.Tables[0].Rows.length;
 if (exec_data.Tables[0].Rows.length > 0) {

     document.getElementById('hdsviewgridh').innerHTML = "";
     document.getElementById('Divgrid1h').style.display = 'block';
     document.getElementById('Divgrid1h').style.BackColor = "Ivory";
     var temp_del1 = "";
     flg_req = "yes"
     var aa1 = "";
     var aa = "";
     var hs = 0;
     var hs1 = 0;

     document.getElementById('hdsviewgridh').style.display = "block";

     if (document.getElementById("hdsviewgridh").children.length == "0") {
         klen = "0"
     }
     else {
         klen = document.getElementById("Divgrid1h").childNodes[0].childNodes[0].childNodes.length - 1;
         IntializeNumber = klen + 1;
     }

     if (document.getElementById("hdsviewgridh").innerHTML.indexOf("width:900px;display:block") <= 0) {
         aa = document.getElementById("hdsviewgridh").innerHTML.replace("</TBODY>", "")//</TABLE>","")
     }
     bufh = "";
     bufh += "<table  id='Divgrid1h' runat='server' align='left' Width='99%' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
     bufh += "<tr>"
     bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:150px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LOGIC" + "</td>"
     bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:100px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "FILTER" + "</td>"
     if (document.getElementById('f1').value == '0') {
         bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:200px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "PREDICTIVE NATAL" + "</td>"
     }
     else {
         bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:200px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "PREDICTIVE HORARY" + "</td>"
     }
     bufh += "<td  bgcolor=#7DAAE3 style='height:0px;width:0px;font-size:0px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "EXPLANATION" + "</td>"
     bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:50px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "UNIQUE ID" + "</td>"
     bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:50px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "FORM NO" + "</td>"
     bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:50px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "VERIFIED" + "</td>"

     bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:40px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "PAGE" + "</td>"
     //        bufh += "<td   style='border:0px solid #7DAAE3;' align='left'>"
     //        bufh += "<input type='checkbox' style='width:15px;' class='dropdown_large_corr'; align='left'   id='chkbox_" + 'h' + "' onClick='javascript:return chkall(this.id);' >"
     //        bufh += "</td>"
     bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "UPD" + "</td>"

     bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "CHK" + "</td>"
     bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "CLUB" + "</td>"
     bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "DEL" + "</td>"
     bufh += "</tr>"

     bufh += "</table>"
     var hdsview = "";
     temp_del1 = aa + bufh.toString();
     temp_del1 = temp_del1.replace("<TBODY>", "")
     temp_del1 = temp_del1.replace("</TBODY>", "")
     //alert(temp_del1)
     document.getElementById('hdsviewgridh').innerHTML = temp_del1;




     document.getElementById('hdsviewgrid').innerHTML = "";
     document.getElementById('Divgrid1').style.display = 'block';
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

     if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:900px;display:block") <= 0) {
         aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
     }
     buf2 = "";
     buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='99%' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
     //        buf2 += "<tr>"
     //        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:150px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LOGIC" + "</td>"
     //        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:100px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "FILTER" + "</td>"
     //        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:200px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "PREDICTIVE" + "</td>"
     //        buf2 += "<td  bgcolor=#7DAAE3 style='height:0px;width:0px;font-size:0px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "EXPLANATION" + "</td>"
     //        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:50px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "UNIQUE ID" + "</td>"
     //        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:50px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "FORM NO" + "</td>"
     //        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:50px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "VERIFIED" + "</td>"
     //        
     //        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:40px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "PAGE" + "</td>"
     //        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
     //        buf2 += "<input type='checkbox' style='width:15px;' class='dropdown_large_corr'; align='left'   id='chkbox_" + 'h' + "' onClick='javascript:return chkall(this.id);' >"
     //        buf2 += "</td>"
     //        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "UPD" + "</td>"

     //        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "CHK" + "</td>"
     //        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "CLUB" + "</td>"
     //        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "DEL" + "</td>"       
     //        buf2 += "</tr>"

     len = 1;


     if (exec_data.Tables[0].Rows.length > 0) {
         for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {

             buf2 += "<tr style='height:220px;'>"
             buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
             buf2 += "<textarea type='text' style='width:170px; height:200px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr';  id='description_" + i + "'>" + exec_data.Tables[0].Rows[i]['DESCRIPTION'] + "</textarea>"
             buf2 += "</td>"
             if (document.getElementById('f1').value == '0') {
                 if (exec_data.Tables[0].Rows[i]['KEY_STRING'] == null) {
                     buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                     buf2 += "<div type='text'contentEditable='true' style='overflow:auto; width:150px; height:200px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='key_" + i + "'></div>"
                     buf2 += "</td>"
                 }
                 else {
                     buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                     buf2 += "<div type='text'contentEditable='true' style='overflow:auto; width:150px; height:200px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='key_" + i + "'>" + exec_data.Tables[0].Rows[i]['KEY_STRING'] + "</div>"
                     buf2 += "</td>"
                 }

             }

             else {
                 if (exec_data.Tables[0].Rows[i]['KEY_STRING'] == null) {
                     buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                     buf2 += "<div type='text'contentEditable='true' disabled style='overflow:auto; width:100px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='key_" + i + "'></div>"
                     buf2 += "</td>"
                 }
                 else {
                     buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                     buf2 += "<div type='text'contentEditable='true' disabled style='overflow:auto; width:100px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='key_" + i + "'>" + exec_data.Tables[0].Rows[i]['KEY_STRING'] + "</div>"
                     buf2 += "</td>"
                 }

             }

             buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
             buf2 += "<div  type='text'contentEditable='true' style='overflow:auto; width:500px;  height:200px; font-family:sans-serif; font-size:16px;' align='left' class='dropdown_large_corr'; id='detaild_" + i + "'>" + exec_data.Tables[0].Rows[i]['DESCCLOB'] + "</div>"
             buf2 += "</td>"


             if (exec_data.Tables[0].Rows[i]['EXPLANATION'] == null) {
                 buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                 buf2 += "<textarea type='text' style='width:0px; height:110px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='explain_" + i + "'> </textarea>"
                 buf2 += "</td>"
             }
             else {
                 buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                 buf2 += "<textarea type='text' style='width:0px; height:110px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='explain_" + i + "'>" + exec_data.Tables[0].Rows[i]['EXPLANATION'] + "</textarea>"
                 buf2 += "</td>"
             }


             buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
             buf2 += "<textarea type='text'  style='width:60px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='unique_" + i + "'>" + exec_data.Tables[0].Rows[i]['UNIQUE_ID'] + "</textarea>"
             buf2 += "</td>"

             buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
             buf2 += "<textarea type='text' disabled style='width:60px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='fid_" + i + "'>" + exec_data.Tables[0].Rows[i]['FORM_ID'] + "</textarea>"
             buf2 += "</td>"



             buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
             buf2 += "<textarea type='text' disabled style='width:60px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='chk_" + i + "'>" + exec_data.Tables[0].Rows[i]['CHECKED'] + "</textarea>"
             buf2 += "</td>"




             buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
             buf2 += "<textarea type='text' style='width:40px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='page_" + i + "'>" + exec_data.Tables[0].Rows[i]['PAGE_NO'] + "</textarea>"
             buf2 += "</td>"

             buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
             buf2 += "<input type='checkbox' style='width:15px;' class='dropdown_large_corr'; align='left'   id='chkbox_" + i + "'  >"
             buf2 += "</td>"

             buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
             buf2 += "<Button  style='width:30px;' align='left' class='dropdown_large_corr'; Text='Update' value='Update' AutoPostBack='true' id=update_" + i + " onClick='javascript:return update1234(id);' >UPD</Button>"
             buf2 += "</td>"


             buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
             buf2 += "<Button  style='width:30px;' align='left' class='dropdown_large_corr'; Text='Update' value='Update' AutoPostBack='true' id=chkb_" + i + " onClick='javascript:return chk1234(id);' >CHK</Button>"
             buf2 += "</td>"

             buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
             buf2 += "<Button  style='width:30px;' align='left' class='dropdown_large_corr'; Text='Update' value='Update' AutoPostBack='true' id=upd_" + i + " onClick='javascript:return club1234(id);' >CLUB</Button>"
             buf2 += "</td>"

             buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
             buf2 += "<Button  style='width:30px;' align='left' class='dropdown_large_corr'; Text='Update' value='Update' AutoPostBack='true' id=del_" + i + " onClick='javascript:return delete1234(id);' >MOVE</Button>"
             buf2 += "</td>"

             //                 buf2 += "<td    ;'  align='left' >"
             //                 buf2 += "<td><a href=''  ><img src='Image/STAR1.jpg' id=star1_" + i + " onClick='javascript:return star1(id);'/>"+"</td>"

             //                buf2 += "</td>"
             //                
             //                
             //                 buf2 += "<td    ;'  align='left' >"
             //                buf2 += "<td><a href=''  ><img src='Image/STAR2.jpg' id=star2_" + i + " onClick='javascript:return changerating(id);'/>"+"</td>"
             //                buf2 += "</td>"
             //                
             //                
             //                 buf2 += "<td    ;'  align='left' >"
             //                 buf2 += "<td><a href=''  ><img src='Image/STAR3.jpg' class=''id=star3_" + i + " onClick='javascript:return changeratingstar(id);'/>"+"</td>"
             //                buf2 += "</td>"


             //                 buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
             //                buf2 += "<Button  style='width:30px;' align='left' class='dropdown_large_corr'; Text='Update' value='Update' AutoPostBack='true' id=astknowledge_" + i + " onClick='javascript:return astroknowledge(id);' >AK</Button>"
             //                buf2 += "</td>"



             buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
             buf2 += "<Button  style='width:30px;' align='left' class='dropdown_large_corr'; Text='b' value='Bold' AutoPostBack='true' id=b_" + i + " onClick='javascript:return GetSelection(id);'>B</Button>"
             buf2 += "</td>"

             //                 buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
             //                buf2 += "<Button  style='width:30px;' align='left' class='dropdown_large_corr'; Text='i' value='Italic' AutoPostBack='true' id=i_" + i + " onClick='javascript:return GetSelection(id);'>I</Button>"
             //                buf2 += "</td>"

             buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
             buf2 += "<Button  style='width:30px;' align='left' class='dropdown_large_corr'; Text='u' value='Underline' AutoPostBack='true' id=u_" + i + " onClick='javascript:return GetSelection(id);'>U</Button>"
             buf2 += "</td>"



             buf2 += "</tr>"
         }

     }
     buf2 += "</table>"
     var hdsview = "";
     temp_del1 = aa + buf2.toString();
     temp_del1 = temp_del1.replace("<TBODY>", "")
     temp_del1 = temp_del1.replace("</TBODY>", "")
     //alert(temp_del1)
     document.getElementById('hdsviewgrid').innerHTML = temp_del1;



 }
 else {
     alert('No data');
     document.getElementById('hdsviewgrid').innerHTML = "";

     return false;
 }
   

}

function chkall(id) {
    if (document.getElementById('chkbox_h').checked == true) {
        for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {
            if (document.getElementById('chkbox_' + i).checked == false) {
                document.getElementById('chkbox_' + i).checked = true;

            }

        }
    }
    else {
        for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {
            if (document.getElementById('chkbox_' + i).checked == true) {
                document.getElementById('chkbox_' + i).checked = false;

            }
        }
    }


}



function update1234(id)
{

    var update = id.split('_');
        var update1 = update[1];
        var book = document.getElementById('b1').value;
        var description = exec_data.Tables[0].Rows[update1].DESCRIPTION

        var key = exec_data.Tables[0].Rows[update1].KEY_STRING
        if (key == null) {
            key = "";
        }
        var description1 = document.getElementById("description_" + update1).value;
        if (description1 == "") {

            description1 = description;

        }
        var key1 = document.getElementById("key_" + update1).innerHTML;
        if (key1 == null) {
            key1 = "";
        }
        var explain = document.getElementById("explain_" + update1).value;
        var descclob = document.getElementById("detaild_" + update1).innerHTML;
        fil=document.getElementById('f1').value;
         var uniqueid=document.getElementById("unique_" + update1).innerHTML; 
        var res = book_predictive.update_gridall(description, description1, descclob, key, key1, explain, fil, book,uniqueid);
        alert("Data updated Successfully");
        return false;
    }



    var flag = '0';
    var vrf = "";
    function chk1234(id) {

        var ch = id.split('_')
        var ch1 = ch[1];
        var desc = document.getElementById("description_" + ch1).innerHTML
        var key = document.getElementById("key_" + ch1).innerHTML
        if (flag == '0') {
            document.getElementById("chk_" + ch1).innerHTML = 'Chk'
            document.getElementById("chkb_" + ch1).innerHTML = 'UnChk'
            vrf = 'Chk';
            flag = '1'
        }
        else {
            document.getElementById("chk_" + ch1).innerHTML = 'Not Chk'
            document.getElementById("chkb_" + ch1).innerHTML = 'CHK...'
            vrf = 'Not Chk';
            flag = '0'
        }

        var book = document.getElementById('b1').innerHTML;
       var res = book_predictive.chk_book_predictive(book, desc, key, vrf);
        alert("Data Verified Successfully")


        return false;
    }




    function delete1234(id) {
        var delete1 = id.split('_')
        var delete11 = delete1[1];
        var book = document.getElementById('b1').value;
        var description = exec_data.Tables[0].Rows[delete11].DESCRIPTION
        var key = exec_data.Tables[0].Rows[delete11].KEY_STRING
        if (key == null) {
            key = "";
        }
        var book = document.getElementById('b1').value;
        var descclob = exec_data.Tables[0].Rows[delete11].DESCCLOB;
        
        var explain = document.getElementById("explain_" + delete11).value;

        var res = book_predictive.delete_book_predictive(description, key, book, descclob, explain);

        document.getElementById("description_" + delete11).value = "";
        document.getElementById("key_" + delete11).value = "";
        document.getElementById("detaild_" + delete11).value = "";
        document.getElementById("explain_" + delete11).value = "";
        alert("Data DELETED OR MOVE Successfully")


        return false;
    }




    function club1234(id) {
        var club = id.split('_')
        var club1 = club[1];
        var book = document.getElementById('b1').value;
        var description = document.getElementById("description_" + club1).value;
        var key = document.getElementById("key_" + club1).value;
        var descclob = document.getElementById("detaild_" + club1).innerHTML;
        var explain = document.getElementById("explain_" + club1).value;
        for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {
            if (document.getElementById('chkbox_' + i).checked == true) {
                if (document.getElementById("chk_" + i).innerHTML == 'Not Chk') {
                    alert('Data are not verified plz verified first')
                    return false;
                }
            }
        }

        for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {
            if (document.getElementById('chkbox_' + i).checked == true) {
                if (i == club[1])
                { }
                else {
                    description = description + ' ~ ' + exec_data.Tables[0].Rows[i]['DESCRIPTION'];
                    key = key + ' ~ ' + exec_data.Tables[0].Rows[i]['KEY_STRING'];
                    explain = explain + ' ~ ' + exec_data.Tables[0].Rows[i]['EXPLANATION'];
                    descclob = descclob + ' ~ ' + exec_data.Tables[0].Rows[i]['DESCCLOB'];
                   

                    document.getElementById("description_" + i).value = "";
                    document.getElementById("key_" + i).value = "";
                    document.getElementById("detaild_" + i).value = "";
                    document.getElementById("explain_" + i).value = "";
                    var descr = exec_data.Tables[0].Rows[i]['DESCRIPTION']
                    var kkey = exec_data.Tables[0].Rows[i]['KEY_STRING']
                    var res = book_predictive.club_book_predictive(descr, kkey, book);
                }
            }
        }
        document.getElementById("description_" + club1).value = description;
        document.getElementById("key_" + club1).innerHTML = key;
        document.getElementById("detaild_" + club1).innerHTML = descclob;
        document.getElementById("explain_" + club1).value = explain;
        alert("Data club Successfully")
        for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {
            document.getElementById('chkbox_' + i).checked = false;
        }

        return false;
    }
    
    
    function star1(id)
    {
    
     var club = id.split('_')
        var club1 = club[1];
         var priority="1";
        var book  =document.getElementById('b1').value;
    var key =document.getElementById('key_'+club1).value;
    var despription=document.getElementById('description_'+club1).value;
    book_predictive.starratingpriority(priority, key, book, despription);
    alert('Priority Set By 1')
    return false;
         
         }
         
    
       
    
    function changerating(id)
     {
     var club = id.split('_')
        var club1 = club[1];
        var priority="2";
        var book  =document.getElementById('b1').value;
    var key =document.getElementById('key_'+club1).value;
    var despription=document.getElementById('description_'+club1).value;
    book_predictive.starratingpriority(priority, key, book, despription);
    alert('Priority Set By 2')
    return false;
         
         
         }
      
   
  
     
     
     
      function changeratingstar(id)
      {
     var club = id.split('_')
        var club1 = club[1];
        var priority="3";
        var book  =document.getElementById('b1').value;
    var key =document.getElementById('key_'+club1).value;
    var despription=document.getElementById('description_'+club1).value;
    book_predictive.starratingpriority(priority, key, book, despription);
    alert('Priority Set By 3')
    return false;
         
    
     } 
//       
//function rating(id){
// var club = id.split('_')
//        var club1 = club[1];
//  document.getElementById('hiddenc1').value=flag;
//  document.getElementById('hiddenc3').value=flag2;
//  document.getElementById('hiddenc2').value=flag1;  
//var star1=document.getElementById('hiddenc1').value;
//var star2=document.getElementById('hiddenc2').value;
//var star3=document.getElementById('hiddenc3').value;
// var priority = parseInt(star1) + parseInt(star2)+ parseInt(star3);
// var book  =document.getElementById('b1').value;
// var key =document.getElementById('key_'+club1).value;
// var despription=document.getElementById('description_'+club1).value;
//  book_predictive.starratingpriority(priority, key, book, despription);
//  alert('Priority Update Successfully')
//return false;

//}



function astroknowledge(id) {
        var delete1 = id.split('_')
        var delete11 = delete1[1];
        var book = document.getElementById('b1').value;
        var description = exec_data.Tables[0].Rows[delete11].DESCRIPTION
        var key = exec_data.Tables[0].Rows[delete11].KEY_STRING
        if (key == null) {
            key = "";
        }
        var form=exec_data.Tables[0].Rows[delete11].FORM_ID
         if (form == null) {
            form = "";
        }
        var page=exec_data.Tables[0].Rows[delete11].PAGE_NO
         if (page == null) {
            page = "";
        }
        var unique=exec_data.Tables[0].Rows[delete11].UNIQUE_ID
         if (unique == null) {
            unique = "";
        }
        var check=exec_data.Tables[0].Rows[delete11].CHECKED
       
        var descclob = exec_data.Tables[0].Rows[delete11].DESCCLOB;
        
        var explain = document.getElementById("explain_" + delete11).value;
        if (explain == null) {
            explain = "";
        }

        var res = book_predictive.movedatainform(description, key, book, descclob, explain,form,unique,check,page);
         alert("Data DELETED OR MOVE Successfully")
        
        // document.getElementById("description_" + delete11).value = "";
       // document.getElementById("key_" + delete11).value = "";
       // document.getElementById("detaild_" + delete11).value = "";
       // document.getElementById("explain_" + delete11).value = "";
       // return false;
       
        }
        
        
        
      

 

function click_on_replace() {
   
  var buf = new StringBuffer2();
  var aa="";
  $('replace_div').style.display = "block";
  var hdsview="";
  var klen="";
 

    if (document.getElementById("replace_div").innerHTML.indexOf("width:900px;display:block") <= 0)
     {
         aa = document.getElementById("replace_div").innerHTML.replace("</TBODY></TABLE>", "")
     }

     

     buf.append("<table Width='270px' cellpadding='0' cellspacing='0' border='2px solid #0000FF'>")
     buf.append("<tr><td  bgcolor=#7d95ff style='width:100px;font-size:9px;font-weight:bold;text-align:center;border:1px solid #0000FF;font-family:Verdana;height:18px;'>Find All</td>")
     buf.append("<td  bgcolor=#7d95ff style='width:100px;font-size:9px;font-weight:bold;text-align:center;border:1px solid #0000FF;font-family:Verdana;height:18px;'>Replace With</td>")
     buf.append("<td style='width:10px;height:15px;border:1px solid #0000FF;' colspan='1'><input type='image' src='image/closelabel(1).gif' id='btnredump' onclick='javascript:return closeissuedespatch();'></td>");
     buf.append("</tr>")


buf += "<tr><td><input type=text id=txtfind   style='width:100px; height:20px' class=btext ></td>";
buf += "<td><input type=text id=txtreplace  style='width:100px; height:20px' class=btext ></td>";
buf += "<td><Button id=btnok  style='width:70px; height:20px' class=btext onClick='javascript:return on_click_ok(id);'>Ok</Button></td>";
buf += "</tr>";
buf += "</table>";

$("replace_div").innerHTML = buf.toString();
 $('replace_div').style.display = "block";
$("replace_div").style.width = screen.availWidth;
$("replace_div").style.height = screen.availHeight;
document.getElementById('b1').disabled = true;
return false;
}


function closeissuedespatch()
{
    $("replace_div").style.display = 'none';
  document.getElementById('b1').disabled = false;
  return false;

}


function on_click_ok() {
 var find=   document.getElementById('txtfind').value;
 var replace = document.getElementById('txtreplace').value;
 if(document.getElementById('txtreplace').value=="")
 {
 replace=" ";
 
 }
 var book = document.getElementById('b1').value;
 
 book_predictive.findreplace(find, replace,book);
 alert('replaced succcessfully');
 return false;
   
}



function category(){
  var  fil = document.getElementById('f1').value;
var book=document.getElementById('bokcate').value;
var res = book_predictive.getbookname(book, fil);

callback_drp1(res);

return false;

}



 function callback_drp1(res) {
    var ds=res.value;
    var edtn = $("b1");
    edtn.options.length = 1;
    edtn.options[0] = new Option("Select Book", "0");
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        for (var i = 0; i < ds.Tables[0].Rows.length; i++) {
            edtn.options[edtn.options.length] = new Option(ds.Tables[0].Rows[i].NAME, ds.Tables[0].Rows[i].NAME)
            edtn.options.length;
        }
    }
    return false;
}



// function formatText (tag) {
//        var selectedText = document.selection.createRange().text;
//        
//        if (selectedText != "") {
//            var newText = "<" + tag + ">" + selectedText + "</" + tag + ">";
//            document.selection.createRange().text = newText;
//        }
//    } 
// 
// 
// 
// 
//  var data = key.split('_')
//  var data1 = data[1];

//   var elem = document.book_predictive.detaild_[data1]; 
//   /start of selection area/ 
//   var start = elem.selectionStart;
//   var end = elem.selectionEnd;
//   var len = elem.value.length;
//   var sel_txt = elem.value.substring(start,end);

//   if (sel_txt != ""){
//     var begin_tag = "<"+key+">"; 
//     var close_tag =  "</"+key+">";
//     var replace = begin_tag + sel_txt + close_tag;
//     elem.value = elem.value.substring(0,start) + replace + elem.value.substring(end,len);
  ////}
//}


 function GetSelection (id) {
  var data = id.split('_')
  var newdata=data[0];
  var data1 = data[1];
            var selection = "";

            var textarea = document.getElementById('detaild_'+data1);
            var keydata = document.getElementById('key_'+data1);
           
           
         if(bold=="0"){
          if (browser != "Microsoft Internet Explorer") 
          {  if (document.getSelection)
            {       
            var userSelection = document.getSelection();
           
            selection=userSelection.toString();
              var selection1 = '<' + newdata + '>' +selection+'</' + newdata + '>' ;
              document.getElementById('detaild_'+data1).innerHTML = textarea.innerHTML.replace(selection, selection1);
              document.getElementById('key_'+data1).innerHTML = keydata.innerHTML.replace(selection, selection1);
              bold="1";
              
           return false;
            }

          }  
        else if (document.selection)
        {
            var userSelection = document.selection.createRange();
            selection=userSelection.text;
           
              var selection1 = '<' + newdata + '>' +selection+'</' + newdata + '>' ;
              document.getElementById('detaild_'+data1).innerHTML = textarea.innerText.replace(selection, selection1);
              document.getElementById('key_'+data1).innerHTML = keydata.innerText.replace(selection, selection1);
              bold="1";
             return false;
        }
       }
       else{
        if (browser != "Microsoft Internet Explorer") 
          {  if (document.getSelection)
            { 
            var userSelection = document.getSelection();
          
            selection=userSelection.toString();
              
             
              if(newdata=='b')
              {
              var selection1 = '<font style="font-weight:normal;">' +selection+'</font>' ;
              }
               if(newdata=='i')
              {
              var selection1 = '<font style="font-style:normal;">' +selection+'</font>' ;
              }
             if(newdata=='u')
            
              var selection1 = '</u>' +selection+'<u>' ;
              }
              document.getElementById('detaild_'+data1).innerHTML = textarea.innerHTML.replace(selection, selection1);
              document.getElementById('key_'+data1).innerHTML = keydata.innerHTML.replace(selection, selection1);
              bold="0";
              
           return false;
            }
            

         
        else if (document.selection)
        {
            var userSelection = document.selection.createRange();
            selection=userSelection.text;
              var selection1 = selection ;
             
              
              document.getElementById('detaild_'+data1).innerHTML = textarea.innerText.replace(selection, selection1);
              document.getElementById('key_'+data1).innerHTML = keydata.innerText.replace(selection, selection1);
             bold="0";
             return false;
        }
        return false;
       }
       }


       function datesearchfn() {
     
  var date1 = document.getElementById('Texttodate').value;
   var date2 = document.getElementById('todate').value;
     

      book_predictive.searchbydate(date1,date2, execute_callback);
      return false;
   }      
        
       

     var fil="";   
function filter()
{
fil=document.getElementById('f1').value;
var res=book_predictive.bindbook(fil);
callback_drp0(res);
return false;
}


 function callback_drp0(res) {
    var ds=res.value;
    if(fil=='0')
    {
    var edtn = $("bokcate");
    edtn.options.length = 1;
    edtn.options[0] = new Option("Select Book", "0");
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        for (var i = 0; i < ds.Tables[0].Rows.length; i++) {
            edtn.options[edtn.options.length] = new Option(ds.Tables[0].Rows[i].CODE, ds.Tables[0].Rows[i].CODE)
            edtn.options.length;
        }
    }}
    else
    {
    var edtn = $("bokcate");
    
    edtn.options.length = 1;
    
    edtn.options[0] = new Option("Select Book", "0");
    
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        for (var i = 0; i < ds.Tables[0].Rows.length; i++) {
            edtn.options[edtn.options.length] = new Option(ds.Tables[0].Rows[i].CODE, ds.Tables[0].Rows[i].CODE)
            edtn.options.length;
        
        }
    }}
   
    return false;
}

function sbp1() 
{

    var bookname = document.getElementById('bokcate').value
    var pageno = document.getElementById('page111').value
    book_predictive.searchpa(bookname, pageno,execute_callback);
    return false;
}
