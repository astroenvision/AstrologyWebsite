
var all_predictive = "";
var exec_data = "";
var browser = navigator.appName;
var buf2 = new StringBuffer2();
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


function fillcategery(event) {


    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "categery") {



            document.getElementById('lstcategery').value = "";
            //var compcode = $('hdncompcode').value;
            //var unit=$('hdnunitcode').value;          
            document.getElementById("divcategery").style.display = "block";
            document.getElementById('divcategery').style.top = 100 + "px";
            document.getElementById('divcategery').style.left = 830 + "px";
            var extra1 = document.getElementById('categery').value;
            document.getElementById('categery').focus();
            all_predictive.fill_categery(extra1, callback_fillcategery)

        }

    }

    if (keycode == 27) {

        document.getElementById('divcategery').style.display = "none";
        document.getElementById('categery').focus()
        return false;

    }

    else if (keycode == 8 || keycode == 46) {
        document.getElementById('categery').value = "";
        return true;
    }

    else if (event.ctrlKey == true && keycode == 88) {
        document.getElementById('categery').value = "";
        // $('txtreason').focus();
        return true;
    }
    else if (keycode == 9) {
        return keycode;
    }
    else if (keycode == 13) {
        return false;
    }
    else {
        document.getElementById('categery').focus();
        return keycode;
    }

}
function callback_fillcategery(res) {
    ds = res.value;
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        var pkgitem = document.getElementById("lstcategery");
        pkgitem.options.length = 0;
        pkgitem.options[0] = new Option("--Select categery--", "0");
        pkgitem.options.length = 1;
        for (var i = 0; i < ds.Tables[0].Rows.length; ++i) {
            //pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].REASON_CODE+"-"+ds.Tables[0].Rows[i].REASON_NAME,ds.Tables[0].Rows[i].REASON_CODE);
            pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].CATEGERY, ds.Tables[0].Rows[i].CATEGERY);
            pkgitem.options.length;
        }
    }
    document.getElementById('lstcategery').focus();
   
    //document.getElementById("lstcategery").value="0";
    return false;
}
function oncliccategery(event) {

    var browser = navigator.appName;
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 13 || event.type == "click") {
        if (document.activeElement.id == "lstcategery") {
            if (document.getElementById('lstcategery').value == "0") {
                document.getElementById('categery').value = "";
                document.getElementById('divcategery').style.display = "none";
                document.getElementById('categery').focus();
                document.getElementById('CheckBox2').checked = true;
                document.getElementById('CheckBox1').checked = false;
                return false;
            }

            // document.getElementById("divcategery").style.display="none";
            var page = document.getElementById('lstcategery').value;
            agencycodeglo = page;
            for (var k = 0; k <= document.getElementById("lstcategery").length - 1; k++) {
                if (document.getElementById('lstcategery').options[k].value == page) {
                    if (browser != "Microsoft Internet Explorer") {
                        var abc = document.getElementById('lstcategery').options[k].textContent;
                    }
                    else {
                        var abc = document.getElementById('lstcategery').options[k].innerText;

                    }
                    var splitcategery = abc;
                    var str = splitcategery.split("~");
                    var agcd = str[0];
                    var dpcd = str[1];
                    document.getElementById('categery').value = agcd;
                    document.getElementById('categery').focus();
                    return false;
                }
            }
        }
    }
    else if (keycode == 27) {

        document.getElementById('divcategery').style.display = "none";
        document.getElementById('categery').focus();
        return false;
    }
}

function closelist(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 27) {
        for (var i = 0; i < document.getElementById('lstcategery').options.length; ++i) {
            document.getElementById('lstcategery').options[i].selected = false;

        }
        document.getElementById('divcategery').style.display = "none";
        document.getElementById('categery').value = "";
        document.getElementById('categery').focus();
       
        return false;
    }

}






function searchpredictive() {





    var tblname = document.getElementById('f1').value;
    if (tblname != 'MOVED_ENTRY') {
        all_predictive.searchp(tblname, execute_callback);
    }
    else {
        var tblname = 'NEW_LOGICAL_ENTRY';
       all_predictive.searchp(tblname, execute_callback);
    }
    
    return false;
}

function searchid() 
{
    var unique = document.getElementById('unique').value;
    all_predictive.searchbyid(unique, execute_callback);
    return false;


}

function execute_callback(val)
 {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
    exec_data = val.value;
    var i = 0

    
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
        var tblname = document.getElementById('f1').value;
        if (tblname != 'MOVED_ENTRY') {
            buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='580px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
            buf2 += "<tr>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LOGIC" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "FILTER" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:230px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "PREDICTIVE" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:0px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:60px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "UNIQUE ID" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:60px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "FORM NO" + "</td>"
            
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:50px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "VERIFIED" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:50px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "BOOK" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:40px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "PAGE" + "</td>"
            buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
            buf2 += "<input type='checkbox' style='width:15px;' class='dropdown_large_corr'; align='left'   id='chkbox_" + 'h' + "' onClick='javascript:return chkall(this.id);' >"
            buf2 += "</td>"

            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "UPD" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "VRF" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "CLUB" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "DEL" + "</td>"
            buf2 += "</tr>"

        }


        else {
            buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='580px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
            buf2 += "<tr>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LOGIC" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:50px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "FILTER" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:230px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "PREDICTIVE" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:0px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:60px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "UNIQUE ID" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:60px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "FORM NO" + "</td>"
            
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "UPD" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "DEL" + "</td>"
           
            buf2 += "</tr>"
        }
        len = 1;

        var flag = "0";
        var count = "0";
        if (exec_data.Tables[0].Rows.length > 0) 
        {
            for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) 
            {



                buf2 += "<tr>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:80px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='description_" + i + "'>" + exec_data.Tables[0].Rows[i]['DESCRIPTION'] + "</textarea>"
                buf2 += "</td>"


                if (exec_data.Tables[0].Rows[i]['KEY_STRING'] == null) {
                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<div type='text'contentEditable='true' style='width:100px;  height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='key_" + i + "'></div>"
                    buf2 += "</td>"
                }
                else {
                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<div type='text'contentEditable='true' style='width:100px;overflow:auto;  height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr';   id='key_" + i + "'>" + exec_data.Tables[0].Rows[i]['KEY_STRING'] + "</div>"
                    buf2 += "</td>"
                }
                var tbl = document.getElementById('f1').value;

                if (tbl == 'HOUSE_POSITIPON_COMB') 
                {
                    buf2 += "<td   style='border:0px; solid #7DAAE3; '  align='left'>"
                    buf2 += "<div type='text'contentEditable='true' style='width:230px;overflow:auto; height:100px; font-family:helvetica; font-size:14px;'   align='left' class='dropdown_large_corr'; id='detaild_" + i + "'>" + exec_data.Tables[0].Rows[i]['DESC_CLOB'] + "</div>"
                    buf2 += "</td>"
                }
                 
                 else if(tbl=='MOVED_ENTRY')
                 
                {
                    buf2 += "<td   style='border:0px; solid #7DAAE3;'   align='left'>"
                    buf2 += "<div type='text'contentEditable='true' style='width:230px;overflow:auto; height:100px; font-family:helvetica; font-size:14px;'  align='left' class='dropdown_large_corr';   id='detaild_" + i + "'>" + exec_data.Tables[0].Rows[i]['DESCCLOB'] + "</div>"
                    buf2 += "</td>"
                
                }
                else
                {
                    buf2 += "<td   style='border:0px; solid #7DAAE3;'   align='left'>"
                    buf2 += "<div type='text'contentEditable='true' style='width:230px;overflow:auto; height:100px; font-family:helvetica; font-size:14px;'  align='left' class='dropdown_large_corr';   id='detaild_" + i + "'>" + exec_data.Tables[0].Rows[i]['DESCCLOB'] + "</div>"
                    buf2 += "</td>"
                
                }



                if (exec_data.Tables[0].Rows[i]['EXPLANATION'] == null) {
                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<textarea type='text' style='width:0px;  height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='explain_" + i + "'></textarea>"
                    buf2 += "</td>"
                }
                else {
                    buf2 += "<td   style='border:0px; solid #7DAAE3;'   align='left'>"
                    buf2 += "<textarea type='text' style='width:0px; height:100px; font-family:helvetica; font-size:14px;font-size:14px;'  align='left' class='dropdown_large_corr';   id='explain_" + i + "'>" + exec_data.Tables[0].Rows[i]['EXPLANATION'] + "</textarea>"
                    buf2 += "</td>"
                }
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:50px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id=' unique_" + i + "'>" + exec_data.Tables[0].Rows[i]['UNIQUE_ID'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:70px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='fid_" + i + "'>" + exec_data.Tables[0].Rows[i]['FORM_ID'] + "</textarea>"
                buf2 += "</td>"

                if (tblname != 'MOVED_ENTRY') {
                buf2 += "<td   style='border:0px solid #7DAAE3; ' align='left'>"
                buf2 += "<textarea type='text' disabled style='width:50px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='chk_" + i + "'>" + exec_data.Tables[0].Rows[i]['CHECKED'] + "</textarea>"
                buf2 += "</td>"


                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text'  style='width:70px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='book_" + i + "'>" + exec_data.Tables[0].Rows[i]['BOOK'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:40px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='page_" + i + "'>" + exec_data.Tables[0].Rows[i]['PAGE_NO'] + "</textarea>"
                buf2 += "</td>"


                
                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<input type='checkbox' style='width:15px;' class='dropdown_large_corr'; align='left'   id='chkbox_" + i + "'  >"
                    buf2 += "</td>"
                }



                buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:30px;' align='left' class='dropdown_large_corr'; Text='Update' value='Update' AutoPostBack='true' id=update_" + i + " onClick='javascript:return update123(id);' >UPD</Button>"
                buf2 += "</td>"

                if (tblname != 'MOVED_ENTRY') {
                    buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                    buf2 += "<Button  style='width:30px;' align='left' class='dropdown_large_corr'; Text='Chk' value='Chk' AutoPostBack='true' id=chkb1_" + i + " onClick='javascript:return chk123(id);' >CHK</Button>"
                    buf2 += "</td>"


                    buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                    buf2 += "<Button  style='width:30px;' align='left' class='dropdown_large_corr'; Text='Club' value='Club' AutoPostBack='true' id=club_" + i + " onClick='javascript:return club123(id);' >CLUB</Button>"
                    buf2 += "</td>"

                }
                    buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                    buf2 += "<Button  style='width:30px;' align='left' class='dropdown_large_corr'; Text='Update' value='Delete' AutoPostBack='true' id=delete_" + i + " onClick='javascript:return deleteall123(id);' >DEL</Button>"
                    buf2 += "</td>"
                    
                    
                                     
                buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:30px;' align='left' class='dropdown_large_corr'; Text='b' value='Bold' AutoPostBack='true' id=b_" + i + " onClick='javascript:return GetSelection(id);'>B</Button>"
                buf2 += "</td>"
                
                 buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:30px;' align='left' class='dropdown_large_corr'; Text='i' value='Italic' AutoPostBack='true' id=i_" + i + " onClick='javascript:return GetSelection(id);'>I</Button>"
                buf2 += "</td>"
                
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



function update123(id) {
    var update = id.split('_')
    var update1 = update[1];
    var tbl = document.getElementById('f1').value;
    if (tbl == 'MOVED_ENTRY')
    {tbl = 'NEW_LOGICAL_ENTRY';}
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
    if (key1 == null ) {
        key1 = "";
    }
    var descclob = document.getElementById("detaild_" + update1).innerHTML;
    var explain = document.getElementById("explain_" + update1).value;
    var res = all_predictive.update_gridall(description, description1, descclob, key, key1, tbl, explain);


    alert("Data updated Successfully")


    return false;
}
var flag = '0';
var vrf = "";
function chk123(id) {

    var ch = id.split('_')
    var ch1 = ch[1];
  var desc=  document.getElementById("description_" + ch1).innerHTML;
  var key=  document.getElementById("key_" + ch1).innerHTML;
  if (flag == '0') {
      document.getElementById("chk_" + ch1).innerHTML = 'Chk'
      document.getElementById("chkb1_" + ch1).innerHTML = 'UnChk'
      vrf = 'Chk';
      flag = '1'
  }
  else
   {
       document.getElementById("chk_" + ch1).innerHTML = 'Not Chk'
      document.getElementById("chkb1_" + ch1).innerHTML = 'CHK...'
      vrf = 'Not Chk';   
      flag = '0'
   }
  
    var tbl = document.getElementById('f1').value;
    var res = all_predictive.update_table(tbl,desc,key,vrf);
    alert("Data Verified Successfully")


    return false;
}

function deleteall123(id) {
    var delete1 = id.split('_')
    var delete11 = delete1[1];
    var tbl = document.getElementById('f1').value;
    var description = exec_data.Tables[0].Rows[delete11].DESCRIPTION
    var key = exec_data.Tables[0].Rows[delete11].KEY_STRING
    if (key == null) {
        key = "";
    }
     var tbl= document.getElementById('f1').value;
     if (tbl == 'HOUSE_POSITIPON_COMB') 
     {
         var descclob = exec_data.Tables[0].Rows[delete11].DESC_CLOB;
     }
     else
      {
         var descclob = exec_data.Tables[0].Rows[delete11].DESCCLOB;
      }
      var explain = document.getElementById("explain_" + delete11).value;
      if (tbl != 'MOVED_ENTRY') {
          var res = all_predictive.delete_gridall(description, key, tbl, descclob, explain);
          alert("Data DELETED OR MOVE Successfully")
      }
      else {
          tbl = 'NEW_LOGICAL_ENTRY';
          var res = all_predictive.delete_moved_grid(description, key, tbl, descclob, explain);
          alert("Data Permanently Deleted")
      }
    document.getElementById("description_" + delete11).value = "";
    document.getElementById("key_" + delete11).value = "";
    document.getElementById("detaild_" + delete11).value = "";
    document.getElementById("explain_" + delete11).value = "";
    


    return false;
}

function club123(id) {
    var club = id.split('_')
    var club1 = club[1];
    var tbl = document.getElementById('f1').value;
    var description = document.getElementById("description_" + club1).value;
    var key = document.getElementById("key_" + club1).value;
    var descclob = document.getElementById("detaild_" + club1).value;
    var explain = document.getElementById("explain_" + club1).value;
    for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {
        if (document.getElementById('chkbox_' + i).checked == true) {
            if (document.getElementById("chk_" + i).innerHTML == 'Not Chk') {
                alert('Data are not verified plz verified first');
                return false;
            } 
        } 
    }
    
    
    
    
    
    for (i = 0; i < exec_data.Tables[0].Rows.length; ++i)
     {
         if (document.getElementById('chkbox_' + i).checked == true) {
         
         
             if ( i == club[1])
             { }
             else {
                 description = description + ' ~ ' + exec_data.Tables[0].Rows[i]['DESCRIPTION'];
                 key = key + ' ~ ' + exec_data.Tables[0].Rows[i]['KEY_STRING'];
                 explain = explain + ' ~ ' + exec_data.Tables[0].Rows[i]['EXPLANATION'];
                 if (tbl == 'HOUSE_POSITIPON_COMB') {
                     descclob = descclob + ' ~ ' + exec_data.Tables[0].Rows[i]['DESC_CLOB'];
                 }
                 else {
                     descclob = descclob + ' ~ ' + exec_data.Tables[0].Rows[i]['DESCCLOB'];
                  }
                
                document.getElementById("description_" + i).value = "";
                document.getElementById("key_" + i).value = "";
                document.getElementById("detaild_" + i).value = "";
                document.getElementById("explain_" + i).value = "";
              var descr=  exec_data.Tables[0].Rows[i]['DESCRIPTION']
              var kkey=  exec_data.Tables[0].Rows[i]['KEY_STRING']
              var res = all_predictive.club_gridall(descr, kkey, tbl);
             } 
         }
     }
     document.getElementById("description_" + club1).value = description;
     document.getElementById("key_" + club1).value = key;
     document.getElementById("detaild_" + club1).value = descclob;
     document.getElementById("explain_" + club1).value = explain;
    alert("Data club Successfully")
    for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) 
    {
    document.getElementById('chkbox_' + i).checked = false;
    }

    return false;
}
function showfilter() 
{
if(document.getElementById("divsubcategery").style.display == "block")
{
var lst = document.getElementById('lstsubcategery').value;
}
else{
    var lst = document.getElementById('lstcategery').value;
    }all_predictive.showcatval(lst, execute_callback1);
    return false;


}

function execute_callback1(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('hdsviewgrid2').innerHTML = "";
        document.getElementById('Divgrid2').style.display = 'block';
        document.getElementById('Divgrid2').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('hdsviewgrid2').style.display = "block";

        if (document.getElementById("hdsviewgrid2").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("Divgrid2").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("hdsviewgrid2").innerHTML.indexOf("width:900px;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid2").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='Divgrid2' runat='server' align='left' Width='900px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:150px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LOGIC" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:120px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "FILTER" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:380px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "PREDICTIVE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:200px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "EXPLANATION" + "</td>"

        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "BOOK" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "UPD" + "</td>"

        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
                
                buf2 += "<tr>"
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:150px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr';  id='ddescription_" + i + "'>" + exec_data1.Tables[0].Rows[i]['DESCRIPTION'] + "</textarea>" 
                buf2 += "</td>"

                if (exec_data1.Tables[0].Rows[i]['KEY_STRING'] == null) {
                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<div type='text' style=' overflow:auto; width:120px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='kkey_" + i + "'>" + exec_data1.Tables[0].Rows[i]['KEY_STRING'] + "</div>" 
                    buf2 += "</td>"
                }
                else {
                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<div type='text' style=' overflow:auto; width:120px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='kkey_" + i + "'>" + exec_data1.Tables[0].Rows[i]['KEY_STRING'] + "</div>" 
                    buf2 += "</td>"
                }



                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<div type='text' style='overflow:auto; width:380px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='ddetaild_" + i + "'>" + exec_data1.Tables[0].Rows[i]['DESCCLOB'] + "</div>" 
                buf2 += "</td>"


                if (exec_data1.Tables[0].Rows[i]['EXPLANATION'] == null) {
                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<textarea type='text' style='width:200px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='explain_" + i + "'>" + "</textarea>" 
                    buf2 += "</td>"
                }
                else {
                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<textarea type='text' style='width:200px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='explain_" + i + "'>" + exec_data1.Tables[0].Rows[i]['EXPLANATION'] + "</textarea>" 
                    buf2 += "</td>"
                }


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:30px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='book_" + i + "'>" + exec_data1.Tables[0].Rows[i]['BOOK'] + "</textarea>" 
                buf2 += "</td>"

                buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:30px;' align='left' class='dropdown_large_corr'; Text='Update' value='Update' AutoPostBack='true' id=update_" + i + " onClick='javascript:return update123456(id);' >UPD</Button>"
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
        document.getElementById('hdsviewgrid2').innerHTML = temp_del1;



    }


    else {
        buf2 = "";
        alert('there are no filter exist');
    }


}

function update123456(id) {
    var update = id.split('_')
    var update1 = update[1];
    var tbl = document.getElementById('f1').value;
    var description = exec_data1.Tables[0].Rows[update1].DESCRIPTION

    var key = exec_data1.Tables[0].Rows[update1].KEY_STRING
    if (key == null) {
        key = "";
    }
    var description1 = document.getElementById("ddescription_" + update1).value;
    if (description1 == "") {

        description1 = description;

    }
    var key1 = document.getElementById("kkey_" + update1).value;
    if (key1 == null) {
        key1 = "";
    }

    var explain = document.getElementById("explain_" + update1).value;
    
    var descclob = document.getElementById("ddetaild_" + update1).value;
    var res = all_predictive.update_grid(description, description1, descclob, key, key1, explain);


    alert("Data updated Successfully")


    return false;
}

function deletefilter() {
    var filter = document.getElementById('lstcategery').value;
    all_predictive.deletecatval(filter);
    alert('categery delete successfully')
    return false;
}





String.prototype.wordWrap = function(m, b, c) { var i, j, s, r = this.split("\n"); if (m > 0) for (i in r) { for (s = r[i], r[i] = ""; s.length > m; j = c ? m : (j = s.substr(0, m).match(/\S*$/)).input.length - j[0].length || m, r[i] += s.substr(0, j) + ((s = s.substr(j)).length ? b : "")); r[i] += s; } return r.join("\n"); };










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
document.getElementById('f1').disabled = true;
return false;
}


function closeissuedespatch()
{$("subfilter").style.display = 'none';
    $("replace_div").style.display = 'none';
  document.getElementById('f1').disabled = false;
  return false;

}


function on_click_ok() {
 var find=   document.getElementById('txtfind').value;
 var replace = document.getElementById('txtreplace').value;
 var tbl = document.getElementById('f1').value;
 if (tbl == 'MOVED_ENTRY')
 {var tbl = 'NEW_LOGICAL_ENTRY'; }
 all_predictive.findreplace(find, replace,tbl);
 alert('replaced succcessfully');
 return false;
   
}

function click_on_subfilter() {
   
  var buf = new StringBuffer2();
  var aa="";
  $('subfilter').style.display = "block";
  var hdsview="";
  var klen="";
 

    if (document.getElementById("subfilter").innerHTML.indexOf("width:900px;display:block") <= 0)
     {
         aa = document.getElementById("subfilter").innerHTML.replace("</TBODY></TABLE>", "")
     }

     

     buf.append("<table Width='270px' cellpadding='0' cellspacing='0' border='2px solid #0000FF'>")
     buf.append("<tr><td  bgcolor=#7d95ff style='width:100px;font-size:9px;font-weight:bold;text-align:center;border:1px solid #0000FF;font-family:Verdana;height:18px;'>Filter</td>")
     buf.append("<td  bgcolor=#7d95ff style='width:100px;font-size:9px;font-weight:bold;text-align:center;border:1px solid #0000FF;font-family:Verdana;height:18px;'>Sub Filter</td>")
     buf.append("<td style='width:10px;height:15px;border:1px solid #0000FF;' colspan='1'><input type='image' src='image/closelabel(1).gif' id='btnredump' onclick='javascript:return closeissuedespatch();'></td>");
     buf.append("</tr>")


buf += "<tr><td><input type=text id=txtfilter   style='width:100px; align:right; height:20px' class=btext;  value='"+document.getElementById('lstcategery').value+"'></td>";
buf += "<td><input type=text id=txtsubfilter  style='width:100px; height:20px' class=btext ></td>";
buf += "<td><Button id=btnadd  style='width:70px; height:20px' class=btext onClick='javascript:return add_filter(id);'>ADD</Button></td>";
buf += "</tr>";
buf += "</table>";

$("subfilter").innerHTML = buf.toString();
 $('subfilter').style.display = "block";
$("subfilter").style.width = screen.availWidth;
$("subfilter").style.height = screen.availHeight;
document.getElementById('f1').disabled = true;
return false;
}


function add_filter() {
 var filter=   document.getElementById('txtfilter').value;
 var subfilter = document.getElementById('txtsubfilter').value;
 all_predictive.subfilter(filter, subfilter);
 alert('Add Filter Succcessfully');
 return false;
   
}

function sub_categery()
{ 
var lst=document.getElementById('lstcategery').value;
    
          
            all_predictive.sub_filter(lst,callback_fillsubcategery);
        return false;

           

    
}

function callback_fillsubcategery(res) 
{
    ds = res.value;
    if(ds.Tables[0].Rows[0].SUB_CATEGERY==null)
    {document.getElementById("lstsubcategery").value="";
    document.getElementById("divsubcategery").style.display = "none";
    return false;}
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0)
     {
        document.getElementById("divsubcategery").style.display = "block";
        document.getElementById('divsubcategery').style.top = 170 + "px";
        document.getElementById('divsubcategery').style.left = 830 + "px";
        var pkgitem = document.getElementById("lstsubcategery");
        pkgitem.options.length = 0;
        pkgitem.options[0] = new Option("--Select subcategery--", "0");
        pkgitem.options.length = 1;
        for (var i = 0; i < ds.Tables[0].Rows.length; ++i)
         {
            //pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].REASON_CODE+"-"+ds.Tables[0].Rows[i].REASON_NAME,ds.Tables[0].Rows[i].REASON_CODE);
            pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].SUB_CATEGERY, ds.Tables[0].Rows[i].SUB_CATEGERY);
            pkgitem.options.length;
        }
        document.getElementById('lstsubcategery').focus();
    }
    
   
    //document.getElementById("lstcategery").value="0";
    return false;
}


function closesublist(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 27) {
        for (var i = 0; i < document.getElementById('lstsubcategery').options.length; ++i) {
            document.getElementById('lstsubcategery').options[i].selected = false;

        }
        document.getElementById('divsubcategery').style.display = "none";
        
       
        return false;
    }

}





 function GetSelection (id) {
  var data = id.split('_')
  var newdata=data[0];
  var data1 = data[1];
            var selection = "";

            var textarea = document.getElementById('detaild_'+data1);
            var keydata = document.getElementById('key_'+data1);
          if (browser != "Microsoft Internet Explorer") 
          {  if (document.getSelection)
            {       
            var userSelection = document.getSelection();
           
            selection=userSelection.toString();
              var selection1 = '<' + newdata + '>' +selection+'</' + newdata + '>' ;
              document.getElementById('detaild_'+data1).innerHTML = textarea.innerHTML.replace(selection, selection1);
              document.getElementById('key_'+data1).innerHTML = keydata.innerHTML.replace(selection, selection1);
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
             return false;
        }
        return false;

        }

        function datesearchfn() {

            var date1 = document.getElementById('Texttodate').value;
            var date2 = document.getElementById('todate').value;


            all_predictive.searchbydate(date1, date2, execute_callback);
            return false;
        }      