﻿var searchpage = "";
var res="";
function searchresult1() {

document.getElementById('Divgrid2').style.display="none";
document.getElementById('vargaschart').style.display="none";
document.getElementById('labchart').style.display="none";
document.getElementById('vargasdiv').style.display="none";

    var chart=document.getElementById('hiddenchart').value;
    var planets = "";
    var key = "";
    var kk = "";
    var ss = "";
   document.getElementById('hdsviewgrid').innerHTML = "";
        document.getElementById('Divgrid1').style.display = "";
      //var ds1 = "";
 
    if(document.getElementById('categery').value!=""||document.getElementById('categery').value!=null)
    { 
        
       
    for (var i = 0; i < document.getElementById('lstcategery').options.length; ++i)
     {
        if (document.getElementById('lstcategery').options[i].selected == true) 
        {
            ss = ss + document.getElementById('lstcategery').options[i].innerHTML + "$";
            document.getElementById('CheckBox2').checked = true;
        }
     }
     
     if(ss=="")
     {ss=document.getElementById('categery').value+"$";
        document.getElementById('CheckBox2').checked = true;}
     
}
    if (ss == "") {
        if (document.getElementById('CheckBoxKetu').checked == false && document.getElementById('CheckBoxRahu').checked == false && document.getElementById('CheckBoxSaturn').checked == false && document.getElementById('CheckBoxVenus').checked == false && document.getElementById('CheckBoxJupitor').checked == false && document.getElementById('CheckBoxMercury').checked == false && document.getElementById('CheckBoxMars').checked == false && document.getElementById('CheckBoxMoon').checked == false && document.getElementById('CheckBoxSun').checked == false && document.getElementById('k1').value == "" ) {
            document.getElementById('CheckBox2').checked = false;
            document.getElementById('CheckBox1').checked = false;

        } 
    }

   


    if (document.getElementById('CheckBox1').checked == true) {
        kk = 1;
        document.getElementById('CheckBox2').checked == false
    }
    else if (document.getElementById('CheckBox2').checked == true) {
        kk = 0;
        document.getElementById('CheckBox1').checked == false
    }
    else {

        kk = "";
    }



    if (ss != "") {
        ss = ss.slice(0, -1);
        if (document.getElementById('CheckBox1').checked == false && document.getElementById('CheckBox2').checked == false) {
            alert("Please Select Checkbox");
            return false;

        }
    }

    var s = "";
    

         s = document.getElementById('Hidden6').value;

    
    var rashi = document.getElementById('Hidden1').value;
    key = document.getElementById('k1').value;



    if (document.getElementById('CheckBoxSun').checked == true) {
        planets = planets + document.getElementById('LabelSun').innerHTML + "$";
    }

    if (document.getElementById('CheckBoxMoon').checked == true) {
        planets = planets + document.getElementById('LabelMoon').innerHTML + "$";
    }

    if (document.getElementById('CheckBoxMars').checked == true) {
        planets = planets + document.getElementById('LabelMars').innerHTML + "$";
    }

    if (document.getElementById('CheckBoxMercury').checked == true) {
        planets = planets + document.getElementById('LabelMercury').innerHTML + "$";
    }

    if (document.getElementById('CheckBoxJupitor').checked == true) {
        planets = planets + document.getElementById('LabelJupitor').innerHTML + "$";
    }

    if (document.getElementById('CheckBoxVenus').checked == true) {
        planets = planets + document.getElementById('LabelVenus').innerHTML + "$";
    }

    if (document.getElementById('CheckBoxSaturn').checked == true) {
        planets = planets + document.getElementById('LabelSaturn').innerHTML + "$";
    }

    if (document.getElementById('CheckBoxRahu').checked == true) {
        planets = planets + document.getElementById('LabelRahu').innerHTML + "$";
    }

    if (document.getElementById('CheckBoxKetu').checked == true) {
        planets = planets + document.getElementById('LabelKetu').innerHTML + "$";
    }

    if (planets != "") {
        planets = planets.slice(0, -1);

    }
  

    
    document.getElementById('Hidden2').value = ss;
    document.getElementById('Hidden3').value = kk;
    document.getElementById('Hidden4').value = key;
    document.getElementById('Hidden5').value=planets;
    document.getElementById('Hidden7').value=chart;
      document.getElementById('img1').style.display='block';
       var astrologer1= document.getElementById('Hidden9').value ;
      
      if(astrologer1=='astrology' ||astrologer1=='ASTROLOGY' || astrologer1=='' || astrologer1=='hshoradm@horary.com')
      
 {

     res = searchpage.searchdesc1(s, ss, kk, rashi, key, planets, chart, astrologer1,callback_fillgrid1);

 }
 else{
     res = searchpage.searchdescf(s, ss, kk, rashi, key, planets, chart, astrologer1,callback_fillgrid);
     }
 

    return false;
}




function fillcategery(event) {


    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "categery") {
            document.getElementById('lstcategery').value = "";
            document.getElementById("divcategery").style.display = "block";
            document.getElementById('divcategery').style.top = 200 + "px";
            document.getElementById('divcategery').style.left = 400 + "px";
            var extra1 = document.getElementById('categery').value;
            document.getElementById('categery').focus();
           
            searchpage.fill_categery(extra1, callback_fillcategery)

        }
        

    }

    if (keycode == 27) {

        document.getElementById('divcategery').style.display = "none";
        document.getElementById('categery').focus()
        return false;

    }

    else if (keycode == 8 || keycode == 46) {
        
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
    document.getElementById('CheckBox2').checked = true;
    document.getElementById('CheckBox1').checked = false;
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
        document.getElementById('CheckBox2').checked = false;
        document.getElementById('CheckBox1').checked = false;
        return false;
    }

}

var flag1 = "0";
function keywordpressed(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;

    if (flag1 == "1") {
        if (document.getElementById('k1').value == "") {

            document.getElementById('CheckBox2').checked = false;
            document.getElementById('CheckBox1').checked = false;
            flag1 = "0";
        }
        else {
            document.getElementById('CheckBox2').checked = true;
            document.getElementById('CheckBox1').checked = false;
            flag1 = "0";
        }
    }
    else {
        if (event.keyCode == 8 || event.keyCode == 46) {
            return;
        }
        else {
            document.getElementById('CheckBox2').checked = true;
            document.getElementById('CheckBox1').checked = false;
            flag1 = "1";
        }
    }
}


function chk1() {
    document.getElementById('CheckBox2').checked = false;
}

function chk2() {
    document.getElementById('CheckBox1').checked = false;
}

function chk()
{ document.getElementById('CheckBox2').checked = true; }



function gridcall(){


 
 
 
document.getElementById('vargaschart').style.display="none";
document.getElementById('labchart').style.display="none";
 var s= document.getElementById('hiddens').value ;   
 var ss=document.getElementById('hiddenss').value ; 
 var kk=document.getElementById('hiddenkk').value ; 
 var rashi=document.getElementById('hiddenrashi').value ; 
 var key=document.getElementById('hiddenkey').value ;
 var planets=document.getElementById('hiddenplanets').value ;
 
 var chart=document.getElementById('hiddenchart').value ;
  
 
 var astrologer1= document.getElementById('Hidden9').value ;
 
 if(astrologer1=='astrology' ||astrologer1=='ASTROLOGY' || astrologer1=='' || astrologer1=='hshoradm@horary.com')
 {

     res = searchpage.searchdesc1(s, ss, kk, rashi, key, planets, chart, astrologer1,callback_fillgrid1);

 }
 else{

     res = searchpage.searchdesc(s, ss, kk, rashi, key, planets, chart, astrologer1,callback_fillgrid);
 
}
return false;

}



function callback_fillgrid1(res){
document.getElementById('img1').style.display='none';


  record_show = 10
  record_show1 = 1
  var gg4 = 0;
 exec_data = res.value;
    var i = 0
           if (exec_data.Tables[0].Rows.length > 0) {
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
        buf2 += "<table  id='hdsviewgrid' runat='server' Width='750px' height='40px' style='border:0px;margin-left:00px; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   class='colum-td-head'>" + "DESCRIPTION" + "</td>"
        buf2 += "<td   class='colum-td-head'>" + "KEY_STRING" + "</td>"

        buf2 += "<td   class='colum-td-head'>" + "DETAIL_DESCRIPTION" + "</td>"
        
        buf2 += "<td   class='colum-td-head'>" + "BOOK" + "</td>"
       
        buf2 += "</tr>"

        len = 1;

        if (exec_data.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {


                buf2 += "<tr>"
         
                 buf2 += "<td class='colum-td-new1 >"
               buf2 += "<font width='900px'>" +(exec_data.Tables[0].Rows[i]['DESCRIPTION']) + "</font>"
               buf2 +="<input type='hidden' id=description_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DESCRIPTION'])+">"
              buf2 += "</td>"
                    
                      if (exec_data.Tables[0].Rows[i]['KEY_STRING'] == null){     
                 buf2 += "<td class='colum-td-new1 >"
               buf2 += "<font width='900px'>" +(exec_data.Tables[0].Rows[i]['KEY_STRING']) + "</font>"
               buf2 +="<input type='hidden' id=key_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['KEY_STRING'])+">"
              buf2 += "</td>"
              }
                           
              else {
                buf2 += "<td class='colum-td-new1 >"
               buf2 += "<font width='900px'>" +(exec_data.Tables[0].Rows[i]['KEY_STRING']) + "</font>"
               buf2 +="<input type='hidden' id=key_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['KEY_STRING'])+">"
              buf2 += "</td>"
               }
                   buf2 += "<td class='colum-td-new1 >"
               buf2 += "<font width='900px'>" +(exec_data.Tables[0].Rows[i]['DESCCLOB']) + "</font>"
               buf2 +="<input type='hidden' id=detaild_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DESCCLOB'])+">"
              buf2 += "</td>"
               
               buf2 += "<td class='colum-td-new1 >"
               buf2 += "<font width='900px'>" +(exec_data.Tables[0].Rows[i]['BOOK']) + "</font>"
               buf2 +="<input type='hidden' id=book_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['BOOK'])+">"
              buf2 += "</td>"
           
                buf2 += "</tr>"
            }
        }
        buf2 += "</table>"

        buf2 += "</TBODY></TABLE>"
    
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        document.getElementById('hdsviewgrid').innerHTML = temp_del1;
        return false;

    }
    }
    
   

function callback_fillgrid(res){

document.getElementById('img1').style.display='none';

 record_show = 10
  record_show1 = 1
  var gg4 =0;
 exec_data = res.value;
    var i = 0

    if (exec_data.Tables[0].Rows.length > 0) {
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
        buf2 += "<table  id='Divgrid1' align:'left' runat='server' Width='900px' height='0px' style='border:1px solid;border-color:#7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td  class='colum-td-head'>" + "PREDICTIVE" + "</td>"
        
        buf2 += "</tr>"


        len = 1;


        if (exec_data.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {

                maxlength = 200;
                if (exec_data.Tables[0].Rows[i]['DESCCLOB'].length > maxlength) {

                    buf2 += "<tr>"
                    buf2 += "<td class='colum-td-new1 >"
                    buf2 += "<font width='900px'>" + (exec_data.Tables[0].Rows[i]['DESCCLOB'].substring(0, 200)) + "</font>"
                    buf2 += "<input type='hidden' id=pre_" + i + " runat='server' value =" + (exec_data.Tables[0].Rows[i]['DESCCLOB']) + " >"
                    var iid = "pre_" + i + "";
                    buf2 += "<a id=pre_" + i + " runat='server' onclick='javascript:showdataingrid(id);' style='cursor:pointer; color:red;' >.......READ MORE.....</a>"
                    buf2 += "</td>"
                    buf2 += "</td>"
                    buf2 += "</tr>"

                }


                else {




                    buf2 += "<tr>"
                    buf2 += "<td class='colum-td-new1 >"
                    buf2 += "<font width='900px'>" + (exec_data.Tables[0].Rows[i]['DESCCLOB']) + "</font>"
                    buf2 += "<input type='hidden' id=pre_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DESCCLOB']) + ">"
                    buf2 += "</td>"
                    buf2 += "</td>"
                    buf2 += "</tr>"
                }
            }
        }
        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('hdsviewgrid').innerHTML = temp_del1;
        return false;



 }
 return false;

}

function shortres(){
var astrologer= document.getElementById('Hidden9').value; 
document.getElementById('Divgrid2').style.display="none";
document.getElementById('vargaschart').style.display="none";
document.getElementById('labchart').style.display="none";
document.getElementById('vargasdiv').style.display="none";
if(astrologer=='astrology' ||astrologer=='ASTROLOGY'){
record_show = 10
  record_show1 = 1
  var gg4 = 0;
// exec_data = res.value;
    var i = 0

    if (exec_data.Tables[0].Rows.length > 0) {
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
        buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='900px' height='0px' style='border:1px solid;border-color:#7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   class='colum-td-head'>" + "DESCRIPTION" + "</td>"
        buf2 += "<td   class='colum-td-head'>" + "KEY_STRING" + "</td>"
        buf2 += "</tr>"


        len = 1;


        if (exec_data.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"
            
                  buf2 += "<td class='colum-td-new1 >"
               buf2 += "<font width='900px'>" +(exec_data.Tables[0].Rows[i]['DESCRIPTION']) + "</font>"
               buf2 +="<input type='hidden' id=description_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DESCRIPTION'])+">"
               buf2 += "</td>"
                
                
                 buf2 += "<td class='colum-td-new1 >"
               buf2 += "<font width='900px'>" +(exec_data.Tables[0].Rows[i]['KEY_STRING']) + "</font>"
               buf2 +="<input type='hidden' id=key_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['KEY_STRING'])+">"
              buf2 += "</td>"
              
              
                 
             
                

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
        document.getElementById('Divgrid1').style.display="block";
        

return false;

 }

}


else{

record_show = 10
  record_show1 = 1
  var gg4 = 0;
// exec_data = res.value;
    var i = 0

    if (exec_data.Tables[0].Rows.length > 0) {
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
        buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='900px' height='0px' style='border:1px solid;border-color:#7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td class='colum-td-head'>" + "KEY_STRING" + "</td>"
       
        buf2 += "</tr>"


        len = 1;


        if (exec_data.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"
            
                
                
                 buf2 += "<td class='colum-td-new1 >"
               buf2 += "<font width='900px'>" +(exec_data.Tables[0].Rows[i]['KEY_STRING']) + "</font>"
               buf2 +="<input type='hidden' id=key_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['KEY_STRING'])+">"
              buf2 += "</td>"
                
                

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
        document.getElementById('Divgrid1').style.display="block";
        

}

return false;
}
}



function longres(){
var astrologer= document.getElementById('Hidden9').value; 
document.getElementById('Divgrid2').style.display="none";
document.getElementById('vargaschart').style.display="none";
document.getElementById('labchart').style.display="none";
document.getElementById('vargasdiv').style.display="none";
if(astrologer=='astrology' ||astrologer=='ASTROLOGY'){
  record_show = 10
  record_show1 = 1
  var gg4 = 0;
// exec_data = res.value;
    var i = 0
       if (exec_data.Tables[0].Rows.length > 0) {
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
        buf2 += "<table  id='hdsviewgrid' runat='server' align='center' Width='750px' height='40px' style='border:1px;margin-left:100px; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td class='colum-td-head>" + "DESCRIPTION" + "</td>"
        buf2 += "<td class='colum-td-head>" + "KEY_STRING" + "</td>"

        buf2 += "<td class='colum-td-head>" + "DETAIL_DESCRIPTION" + "</td>"
        
        buf2 += "<td class='colum-td-head>" + "BOOK" + "</td>"
       
        buf2 += "</tr>"

        len = 1;

        if (exec_data.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {


                buf2 += "<tr>"
         
                 buf2 += "<td class='colum-td-new1 >"
               buf2 += "<font width='900px'>" +(exec_data.Tables[0].Rows[i]['DESCRIPTION']) + "</font>"
               buf2 +="<input type='hidden' id=description_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DESCRIPTION'])+">"
              buf2 += "</td>"
                    
                      if (exec_data.Tables[0].Rows[i]['KEY_STRING'] == null){     
                 buf2 += "<td class='colum-td-new1 >"
               buf2 += "<font width='900px'>" +(exec_data.Tables[0].Rows[i]['KEY_STRING']) + "</font>"
               buf2 +="<input type='hidden' id=key_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['KEY_STRING'])+">"
              buf2 += "</td>"
              }
                           
              else {
                buf2 += "<td class='colum-td-new1 >"
               buf2 += "<font width='900px'>" +(exec_data.Tables[0].Rows[i]['KEY_STRING']) + "</font>"
               buf2 +="<input type='hidden' id=key_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['KEY_STRING'])+">"
              buf2 += "</td>"
               }
                   buf2 += "<td class='colum-td-new1 >"
               buf2 += "<font width='900px'>" +(exec_data.Tables[0].Rows[i]['DESCCLOB']) + "</font>"
               buf2 +="<input type='hidden' id=detaild_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DESCCLOB'])+">"
              buf2 += "</td>"
               
               buf2 += "<td class='colum-td-new1 >"
               buf2 += "<font width='900px'>" +(exec_data.Tables[0].Rows[i]['BOOK']) + "</font>"
               buf2 +="<input type='hidden' id=book_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['BOOK'])+">"
              buf2 += "</td>"
           
                buf2 += "</tr>"
            }
        }
        buf2 += "</table>"

        buf2 += "</TBODY></TABLE>"
    
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        document.getElementById('hdsviewgrid').innerHTML = temp_del1;
        return false;

    }
}
else{

 record_show = 10
  record_show1 = 1
  var gg4 = 0;
 //exec_data = res.value;
    var i = 0

    if (exec_data.Tables[0].Rows.length > 0) {
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

        if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:900;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='900px' height='0px' style='border:1px solid;border-color:#7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   class='colum-td-head'>" + "PREDICTIVE" + "</td>"
        buf2 += "</tr>"


        len = 1;

       
        if (exec_data.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {
                maxlength = 200;
                if (exec_data.Tables[0].Rows[i]['DESCCLOB'].length > maxlength)
                 {

                    buf2 += "<tr>"
                    buf2 += "<td class='colum-td-new1 >"
                    buf2 += "<font width='900px'>" + (exec_data.Tables[0].Rows[i]['DESCCLOB'].substring(0, 200)) + "</font>"
                    buf2 += "<input type='hidden' id=pre_" + i + " runat='server' value =" + (exec_data.Tables[0].Rows[i]['DESCCLOB']) + " >"
                    var iid = "pre_" + i + "";
                    buf2 += "<a id=pre_" + i + " runat='server' onclick='javascript:showdataingrid(id);' style='cursor:pointer; color:red;' >.......READ MORE.....</a>"
                    buf2 += "</td>"
                    buf2 += "</td>"
                    buf2 += "</tr>"

                }


                else {




                    buf2 += "<tr>"
                    buf2 += "<td class='colum-td-new1 >"
                    buf2 += "<font width='900px'>" + (exec_data.Tables[0].Rows[i]['DESCCLOB']) + "</font>"
                    buf2 += "<input type='hidden' id=pre_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DESCCLOB']) + ">"
                    buf2 += "</td>"
                    buf2 += "</td>"
                    buf2 += "</tr>"
                } 
            }
        }
        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('hdsviewgrid').innerHTML = temp_del1;
        document.getElementById('Divgrid1').style.display="block";
       return false;
 }
 
return false;
}

}






function vargaschart11() {
document.getElementById('vargasdiv').style.display="block";
document.getElementById('Divgrid1').style.display="none";
document.getElementById('Divgrid2').style.display="none";

var vargas=document.getElementById('Hiddenv').value;
searchpage.vargasvalue(vargas,callback_vargas);
return false;
}


function callback_vargas(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
     var vds= val.value;
    var i = 0

    if (vds.Tables[0].Rows.length > 0) {
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

        if (document.getElementById("hdsviewgrid2").innerHTML.indexOf("width:600;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid2").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='Divgrid2' runat='server' align='left' Width='600' height='0px' style='border:1px solid;border-color:#7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   class='colum-td-head'>" + "PLANET" + "</td>"
        buf2 += "<td   class='colum-td-head'>" + "D1_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head'>" + "D1_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "BIRTH_TIME" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "R" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "DEGREE" + "</td>"
                
        buf2 += "<td   class='colum-td-head>" + "D2_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D2_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D3_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D3_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D4_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D4_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D5_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D5_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D6_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D6_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D7_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D7_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D8_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D8_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D9_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D9_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D10_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head'>" + "D10_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D11_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D11_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D12_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D12_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D16_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D16_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D20_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D20_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D24_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D24_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D27_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D27_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D30_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D30_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D40_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D40_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D45_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D45_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D60_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D60_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head>" + "SHASHTYAMSHA_NAME" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D60_NATURE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "KARAKAMSHA_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "KARAKAMSHA_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "MOON_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "MOON_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "VENUS_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "VENUS_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "CONSTELATION" + "</td>"
        buf2 += "</tr>"


        len = 1;


        if (vds.Tables[0].Rows.length > 0) {
            for (i = 0; i < vds.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"
//                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'> "
//                buf2 += "<label  style='width:90px; font-family:helvetica;' class='dropdown_large_corr'; align='left' Text='" + exec_data.Tables[0].Rows[i]['PLANET'] + "'  id=planets_" + i + " >"
//                buf2 += "</td>"
                
                
                 buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['PLANET']) + "</font>"
               buf2 +="<input type='hidden' id=planets_" + i + "  value =" + (vds.Tables[0].Rows[i]['PLANET'])+">"
              buf2 += "</td>"
                
                

                 buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D1_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D1_HOUSE'])+">"
              buf2 += "</td>"


                buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D1_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D1_RASHI'])+">"
              buf2 += "</td>"
              
               buf2 += "<td   style='width:150px;'class='dropdown_large_corr2'; align='left' >"
               buf2 += "<font width='150px'>" +(vds.Tables[0].Rows[i]['BIRTH_TIME']) + "</font>"
               buf2 +="<input type='hidden' id=birth_" + i + "  value =" + (vds.Tables[0].Rows[i]['BIRTH_TIME'])+">"
              buf2 += "</td>"
                
              buf2 += "<td class='colum-td-new1'>"
              if (exec_data.Tables[0].Rows[i]['RETRO'] == null) {
                  buf2 += "<font width='90px'></font>"
                  buf2 += "<input type='hidden' id=retrograde_" + i + " >"
                  buf2 += "</td>"

              }
              else {
                  buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['RETRO']) + "</font>"
                  buf2 += "<input type='hidden' id=retrograde_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['RETRO']) + ">"
                  buf2 += "</td>"
              }
                 buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['DEGREE']) + "</font>"
               buf2 +="<input type='hidden' id=degree_" + i + "  value =" + (vds.Tables[0].Rows[i]['DEGREE'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D2_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d2house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D2_HOUSE'])+">"
              buf2 += "</td>"
              
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D2_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d2rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D2_RASHI'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D3_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d3house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D3_HOUSE'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D3_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d3rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D3_RASHI'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D4_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d4house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D4_HOUSE'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D4_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d4rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D4_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D5_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d5house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D5_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D5_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d5rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D5_RASHI'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D6_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d6house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D6_HOUSE'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D6_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d6rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D6_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D7_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d7house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D7_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D7_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d7rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D7_RASHI'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D8_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d8house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D8_HOUSE'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D8_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d8rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D8_RASHI'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D9_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d9house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D9_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D9_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d9rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D9_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D10_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d10house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D10_HOUSE'])+">"
              buf2 += "</td>"
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D10_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d10rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D10_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D11_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d11house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D11_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D11_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d11rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D11_RASHI'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D12_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d12house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D12_HOUSE'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D12_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d12rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D12_RASHI'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D16_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d16house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D16_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D16_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d16rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D16_RASHI'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D20_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d20house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D20_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D20_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d20rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D20_RASHI'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D24_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d24house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D24_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D24_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d24rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D24_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D27_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d27house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D27_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D27_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d27rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D27_RASHI'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D30_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d30house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D30_HOUSE'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D30_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d30rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D30_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D40_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d40house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D40_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D40_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d40rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D40_RASHI'])+">"
              buf2 += "</td>"
                 
                 
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D45_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d45house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D45_HOUSE'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D45_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d45rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D45_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D60_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d60house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D60_HOUSE'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D60_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d60rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D60_RASHI'])+">"
              buf2 += "</td>"
                
               
                     buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['SHASHTYAMSHA_NAME']) + "</font>"
               buf2 +="<input type='hidden' id=d60shash_" + i + "  value =" + (vds.Tables[0].Rows[i]['SHASHTYAMSHA_NAME'])+">"
              buf2 += "</td>"
               
                
                     buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D60_NATURE']) + "</font>"
               buf2 +="<input type='hidden' id=d60nature_" + i + "  value =" + (vds.Tables[0].Rows[i]['D60_NATURE'])+">"
              buf2 += "</td>"
               
                
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['KARAKAMSHA_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=karkahouse_" + i + "  value =" + (vds.Tables[0].Rows[i]['KARAKAMSHA_HOUSE'])+">"
              buf2 += "</td>"
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['KARAKAMSHA_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=karkarashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['KARAKAMSHA_RASHI'])+">"
               buf2 += "</td>"


               buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['MOON_HOUSE']) + "</font>"
               buf2 += "<input type='hidden' id=moonhouse_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['MOON_HOUSE']) + ">"
               buf2 += "</td>"

               buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['MOON_RASHI']) + "</font>"
               buf2 += "<input type='hidden' id=moonrashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['MOON_RASHI']) + ">"
               buf2 += "</td>"

               buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['VENUS_HOUSE']) + "</font>"
               buf2 += "<input type='hidden' id=venushouse_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['VENUS_HOUSE']) + ">"
               buf2 += "</td>"

               buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['VENUS_RASHI']) + "</font>"
               buf2 += "<input type='hidden' id=venusrashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['VENUS_RASHI']) + ">"
               buf2 += "</td>"

               buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['CONSTELATION']) + "</font>"
               buf2 += "<input type='hidden' id=cons_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['CONSTELATION']) + ">"
               buf2 += "</td>"

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
        document.getElementById('vargaschart').style.display="block";
document.getElementById('labchart').style.display="block";
document.getElementById('Divgrid2').style.display="none";



    }



}

function showvargas()
{
    if (document.getElementById('vargaschart').value == 'D01') {


        document.getElementById('vargasdiv').style.display = "block";


        var p1 = "";
        var p2 = "";
        var p3 = "";
        var p4 = "";
        var p5 = "";
        var p6 = "";
        var p7 = "";
        var p8 = "";
        var p9 = "";
        var p10 = "";
        var p11 = "";
        var p12 = "";
        var j1 = "";
        var j2 = "";
        var j3 = "";
        var j4 = "";
        var j5 = "";
        var j6 = "";
        var j7 = "";
        var j8 = "";
        var j9 = "";
        var j10 = "";
        var j11 = "";
        var j12 = "";
        var h1 = "";
        var r1 = "";
        var h2 = "";
        var r2 = "";
        var h3 = "";
        var r3 = "";
        var h4 = "";
        var r4 = "";
        var h5 = "";
        var r5 = "";
        var h6 = "";
        var r6 = "";
        var h7 = "";
        var r7 = "";
        var h8 = "";
        var r8 = "";
        var h9 = "";
        var r9 = "";
        var h10 = "";
        var r10 = "";
        var h11 = "";
        var r11 = "";
        var h12 = "";
        var r12 = "";
        var deg = "";
        var deg1 = "";
        var chartname = 'D01'
       
        document.getElementById('rashiid').style.display = "block";
        for (var i = 1; i < 11; i++) {
            document.getElementById('Hidden8').value = i;

            var h = document.getElementById('house_' + i).value
            var r = document.getElementById('rashi_' + 0).value


            if (document.getElementById('retrograde_' + i).value == "0" || document.getElementById('retrograde_' + i).value == "B") {
                document.getElementById('retrograde_' + i).innerHTML = "";
            }


            if (h == 'HOUSE1') {

                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j1 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j1 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j1 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j1 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j1 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j1 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j1 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j1 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j1 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j1 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                h1 = h1 + j1 + " ";


            }
            if (h == 'HOUSE2') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j2 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j2 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j2 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j2 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j2 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j2 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j2 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j2 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j2 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j2 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }



                h2 = h2 + j2 + " ";


            }

            if (h == 'HOUSE3') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j3 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j3 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j3 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j3 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j3 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j3 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j3 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j3 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j3 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j3 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                h3 = h3 + j3 + " ";


            }


            if (h == 'HOUSE4') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j4 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j4 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j4 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j4 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j4 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j4 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j4 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j4 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j4 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j4 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                h4 = h4 + j4 + " ";


            }

            if (h == 'HOUSE5') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j5 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j5 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j5 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j5 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j5 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j5 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j5 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j5 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j5 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j5 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                h5 = h5 + j5 + " ";

            }

            if (h == 'HOUSE6') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j6 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j6 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j6 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j6 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j6 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j6 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j6 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j6 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';

                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j6 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j6 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                h6 = h6 + j6 + " ";


            }

            if (h == 'HOUSE7') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j7 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j7 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j7 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j7 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j7 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j7 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j7 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j7 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j7 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j7 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                h7 = h7 + j7 + " ";


            }

            if (h == 'HOUSE8') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j8 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j8 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j8 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j8 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j8 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j8 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j8 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j8 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j8 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j8 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                h8 = h8 + j8 + " ";


            }

            if (h == 'HOUSE9') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j9 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j9 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j9 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j9 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j9 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j9 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j9 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j9 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j9 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j9 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }


                h9 = h9 + j9 + " ";


            }

            if (h == 'HOUSE10') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j10 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j10 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j10 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j10 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j10 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j10 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j10 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j10 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j10 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j10 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                h10 = h10 + j10 + " ";


            }

            if (h == 'HOUSE11') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j11 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j11 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j11 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j11 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j11 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j11 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j11 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j11 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j11 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j11 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                h11 = h11 + j11 + " ";

            }
            if (h == 'HOUSE12') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j12 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j12 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j12 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j12 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j12 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j12 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j12 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j12 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j12 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j12 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                h12 = h12 + j12 + " ";



            }

        }

        if (r == 'Aries') {
            r1 = '1'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = parseInt(r11) + parseInt(1);

        }
        if (r == 'Taurus') {
            r1 = '2'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = '1';

        }

        if (r == 'Gemini') {
            r1 = '3'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = '1';
            r12 = '2';

        }

        if (r == 'Cancer') {
            r1 = '4'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = '1';
            r11 = '2';
            r12 = '3';

        }


        if (r == 'Leo') {
            r1 = '5'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = '1';
            r10 = '2';
            r11 = '3';
            r12 = '4';

        }
        if (r == 'Virgo') {
            r1 = '6'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = '1'
            r9 = '2'
            r10 = '3'
            r11 = '4'
            r12 = '5'

        }

        if (r == 'Libra') {
            r1 = '7'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) - parseInt(11);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = parseInt(r11) + parseInt(1);

        }
        if (r == 'Scorpio') {
            r1 = '8'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) - parseInt(11);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = parseInt(r11) + parseInt(1);

        }

        if (r == 'Sagittarius') {
            r1 = '9'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) - parseInt(11);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = parseInt(r11) + parseInt(1);

        }

        if (r == 'Capricorn') {
            r1 = '10'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) - parseInt(11);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = parseInt(r11) + parseInt(1);

        }
        if (r == 'Aquarius') {
            r1 = '11'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) - parseInt(11);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = parseInt(r11) + parseInt(1);

        }
        if (r == 'Pisces') {
            r1 = '12'
            r2 = r1 - '11';
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = parseInt(r11) + parseInt(1);

        }

        p1 = h1;
        p2 = h2;
        p3 = h3;
        p4 = h4;
        p5 = h5;
        p6 = h6;
        p7 = h7;
        p8 = h8;
        p9 = h9;
        p10 = h10;
        p11 = h11;
        p12 = h12;
        document.getElementById('h1l1').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + 0).value + '</span>';
        document.getElementById('h2l1').innerHTML = p2;
        document.getElementById('h3l1').innerHTML = p3;
        document.getElementById('h4l1').innerHTML = p4;
        document.getElementById('h5l1').innerHTML = p5;
        document.getElementById('h6l1').innerHTML = p6;
        document.getElementById('h7l1').innerHTML = p7;
        document.getElementById('h8l1').innerHTML = p8;
        document.getElementById('h9l1').innerHTML = p9;
        document.getElementById('h10l1').innerHTML = p10;
        document.getElementById('h11l1').innerHTML = p11;
        document.getElementById('h12l1').innerHTML = p12;
        document.getElementById('h12r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r12 + '</span>' + '</br>';
        document.getElementById('h1r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r1 + '</span>' + '</br>';
        document.getElementById('h2r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r2 + '</span>' + '</br>';
        document.getElementById('h3r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r3 + '</span>' + '</br>';
        document.getElementById('h4r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r4 + '</span>' + '</br>';
        document.getElementById('h5r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r5 + '</span>' + '</br>';
        document.getElementById('h6r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r6 + '</span>' + '</br>';
        document.getElementById('h7r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r7 + '</span>' + '</br>';
        document.getElementById('h8r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r8 + '</span>' + '</br>';
        document.getElementById('h9r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r9 + '</span>' + '</br>';
        document.getElementById('h10r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r10 + '</span>' + '</br>';
        document.getElementById('h11r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r11 + '</span>' + '</br>';

    }

    else
    {
        document.getElementById('vargasdiv').style.display = "block";


        var p1 = "";
        var p2 = "";
        var p3 = "";
        var p4 = "";
        var p5 = "";
        var p6 = "";
        var p7 = "";
        var p8 = "";
        var p9 = "";
        var p10 = "";
        var p11 = "";
        var p12 = "";
        var j1 = "";
        var j2 = "";
        var j3 = "";
        var j4 = "";
        var j5 = "";
        var j6 = "";
        var j7 = "";
        var j8 = "";
        var j9 = "";
        var j10 = "";
        var j11 = "";
        var j12 = "";
        var h1 = "";
        var r1 = "";
        var h2 = "";
        var r2 = "";
        var h3 = "";
        var r3 = "";
        var h4 = "";
        var r4 = "";
        var h5 = "";
        var r5 = "";
        var h6 = "";
        var r6 = "";
        var h7 = "";
        var r7 = "";
        var h8 = "";
        var r8 = "";
        var h9 = "";
        var r9 = "";
        var h10 = "";
        var r10 = "";
        var h11 = "";
        var r11 = "";
        var h12 = "";
        var r12 = "";

        var chartname = document.getElementById('vargaschart').value;

        document.getElementById('rashiid').style.display = "block";
        for (var i = 1; i < 11; i++) {
            document.getElementById('Hidden8').value = i;
            if (document.getElementById('vargaschart').value == 'D01') {
                var h = document.getElementById('house_' + i).value
                var r = document.getElementById('rashi_' + 0).value

            }

            if (document.getElementById('vargaschart').value == 'D02') {
                var h = document.getElementById('d2house_' + i).value
                var r = document.getElementById('d2rashi_' + 0).value
            }

            if (document.getElementById('vargaschart').value == 'D03') {
                var h = document.getElementById('d3house_' + i).value
                var r = document.getElementById('d3rashi_' + 0).value
            }

            if (document.getElementById('vargaschart').value == 'D04') {
                var h = document.getElementById('d4house_' + i).value
                var r = document.getElementById('d4rashi_' + 0).value
            }

            if (document.getElementById('vargaschart').value == 'D05') {
                var h = document.getElementById('d5house_' + i).value
                var r = document.getElementById('d5rashi_' + 0).value
            }

            if (document.getElementById('vargaschart').value == 'D06') {
                var h = document.getElementById('d6house_' + i).value
                var r = document.getElementById('d6rashi_' + 0).value
            }

            if (document.getElementById('vargaschart').value == 'D07') {
                var h = document.getElementById('d7house_' + i).value
                var r = document.getElementById('d7rashi_' + 0).value
            }

            if (document.getElementById('vargaschart').value == 'D08') {
                var h = document.getElementById('d8house_' + i).value
                var r = document.getElementById('d8rashi_' + 0).value
            }

            if (document.getElementById('vargaschart').value == 'D09') {
                var h = document.getElementById('d9house_' + i).value
                var r = document.getElementById('d9rashi_' + 0).value
            }

            if (document.getElementById('vargaschart').value == 'D10') {
                var h = document.getElementById('d10house_' + i).value
                var r = document.getElementById('d10rashi_' + 0).value
            }
            if (document.getElementById('vargaschart').value == 'D11') {
                var h = document.getElementById('d11house_' + i).value
                var r = document.getElementById('d11rashi_' + 0).value
            }

            if (document.getElementById('vargaschart').value == 'D12') {
                var h = document.getElementById('d12house_' + i).value
                var r = document.getElementById('d12rashi_' + 0).value
            }

            if (document.getElementById('vargaschart').value == 'D16') {
                var h = document.getElementById('d16house_' + i).value
                var r = document.getElementById('d16rashi_' + 0).value
            }

            if (document.getElementById('vargaschart').value == 'D20') {
                var h = document.getElementById('d20house_' + i).value
                var r = document.getElementById('d20rashi_' + 0).value
            }

            if (document.getElementById('vargaschart').value == 'D24') {
                var h = document.getElementById('d24house_' + i).value
                var r = document.getElementById('d24rashi_' + 0).value
            }

            if (document.getElementById('vargaschart').value == 'D27') {
                var h = document.getElementById('d27house_' + i).value
                var r = document.getElementById('d27rashi_' + 0).value
            }

            if (document.getElementById('vargaschart').value == 'D30') {
                var h = document.getElementById('d30house_' + i).value
                var r = document.getElementById('d30rashi_' + 0).value
            }

            if (document.getElementById('vargaschart').value == 'D40') {
                var h = document.getElementById('d40house_' + i).value
                var r = document.getElementById('d40rashi_' + 0).value
            }

            if (document.getElementById('vargaschart').value == 'D45') {
                var h = document.getElementById('d45house_' + i).value
                var r = document.getElementById('d45rashi_' + 0).value
            }

            if (document.getElementById('vargaschart').value == 'D60') {
                var h = document.getElementById('d60house_' + i).value
                var r = document.getElementById('d60rashi_' + 0).value
            }

            if (document.getElementById('vargaschart').value == 'KL') {
                var h = document.getElementById('karkahouse_' + i).value
                var r = document.getElementById('karkarashi_' + 0).value
            }



            if (h == 'HOUSE1') {


                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j1 = 'Me';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j1 = 'Ju';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j1 = 'Ve';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j1 = 'Sa';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j1 = 'Su';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j1 = 'Mo';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j1 = 'Ma';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j1 = 'Ra';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j1 = 'Ke';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j1 = 'Gk';
                }

                h1 = h1 + j1 + " ";


            }
            if (h == 'HOUSE2') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j2 = 'Me';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j2 = 'Ju';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j2 = 'Ve';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j2 = 'Sa';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j2 = 'Su';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j2 = 'Mo';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j2 = 'Ma';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j2 = 'Ra';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j2 = 'Ke';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j2 = 'Gk';
                }



                h2 = h2 + j2 + " ";


            }

            if (h == 'HOUSE3') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j3 = 'Me';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j3 = 'Ju';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j3 = 'Ve';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j3 = 'Sa';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j3 = 'Su';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j3 = 'Mo';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j3 = 'Ma';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j3 = 'Ra';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j3 = 'Ke';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j3 = 'Gk';
                }
                h3 = h3 + j3 + " ";


            }


            if (h == 'HOUSE4') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j4 = 'Me';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j4 = 'Ju';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j4 = 'Ve';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j4 = 'Sa';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j4 = 'Su';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j4 = 'Mo';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j4 = 'Ma';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j4 = 'Ra';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j4 = 'Ke';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j4 = 'Gk';
                }
                h4 = h4 + j4 + " ";


            }

            if (h == 'HOUSE5') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j5 = 'Me';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j5 = 'Ju';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j5 = 'Ve';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j5 = 'Sa';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j5 = 'Su';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j5 = 'Mo';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j5 = 'Ma';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j5 = 'Ra';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j5 = 'Ke';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j5 = 'Gk';
                }
                h5 = h5 + j5 + " ";

            }

            if (h == 'HOUSE6') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j6 = 'Me';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j6 = 'Ju';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j6 = 'Ve';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j6 = 'Sa';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j6 = 'Su';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j6 = 'Mo';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j6 = 'Ma';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j6 = 'Ra';

                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j6 = 'Ke';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j6 = 'Gk';
                }

                h6 = h6 + j6 + " ";


            }

            if (h == 'HOUSE7') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j7 = 'Me';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j7 = 'Ju';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j7 = 'Ve';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j7 = 'Sa';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j7 = 'Su';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j7 = 'Mo';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j7 = 'Ma';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j7 = 'Ra';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j7 = 'Ke';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j7 = 'Gk';
                }

                h7 = h7 + j7 + " ";


            }

            if (h == 'HOUSE8') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j8 = 'Me';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j8 = 'Ju';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j8 = 'Ve';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j8 = 'Sa';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j8 = 'Su';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j8 = 'Mo';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j8 = 'Ma';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j8 = 'Ra';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j8 = 'Ke';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j8 = 'Gk';
                }

                h8 = h8 + j8 + " ";


            }

            if (h == 'HOUSE9') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j9 = 'Me';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j9 = 'Ju';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j9 = 'Ve';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j9 = 'Sa';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j9 = 'Su';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j9 = 'Mo';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j9 = 'Ma';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j9 = 'Ra';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j9 = 'Ke';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j9 = 'Gk';
                }


                h9 = h9 + j9 + " ";


            }

            if (h == 'HOUSE10') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j10 = 'Me';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j10 = 'Ju';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j10 = 'Ve';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j10 = 'Sa';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j10 = 'Su';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j10 = 'Mo';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j10 = 'Ma';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j10 = 'Ra';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j10 = 'Ke';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j10 = 'Gk';
                }

                h10 = h10 + j10 + " ";


            }

            if (h == 'HOUSE11') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j11 = 'Me';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j11 = 'Ju';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j11 = 'Ve';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j11 = 'Sa';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j11 = 'Su';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j11 = 'Mo';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j11 = 'Ma';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j11 = 'Ra';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j11 = 'Ke';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j11 = 'Gk';
                }


                h11 = h11 + j11 + " ";

            }
            if (h == 'HOUSE12') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j12 = 'Me';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j12 = 'Ju';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j12 = 'Ve';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j12 = 'Sa';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j12 = 'Su';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j12 = 'Mo';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j12 = 'Ma';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j12 = 'Ra';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j12 = 'Ke';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j12 = 'Gk';
                }

                h12 = h12 + j12 + " ";



            }

        }
        if (r == 'Aries') {
            r1 = '1'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = parseInt(r11) + parseInt(1);

        }
        if (r == 'Taurus') {
            r1 = '2'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = '1';

        }

        if (r == 'Gemini') {
            r1 = '3'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = '1';
            r12 = '2';

        }

        if (r == 'Cancer') {
            r1 = '4'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = '1';
            r11 = '2';
            r12 = '3';

        }


        if (r == 'Leo') {
            r1 = '5'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = '1';
            r10 = '2';
            r11 = '3';
            r12 = '4';

        }
        if (r == 'Virgo') {
            r1 = '6'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = '1'
            r9 = '2'
            r10 = '3'
            r11 = '4'
            r12 = '5'

        }

        if (r == 'Libra') {
            r1 = '7'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) - parseInt(11);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = parseInt(r11) + parseInt(1);

        }
        if (r == 'Scorpio') {
            r1 = '8'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) - parseInt(11);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = parseInt(r11) + parseInt(1);

        }

        if (r == 'Sagittarius') {
            r1 = '9'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) - parseInt(11);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = parseInt(r11) + parseInt(1);

        }

        if (r == 'Capricorn') {
            r1 = '10'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) - parseInt(11);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = parseInt(r11) + parseInt(1);

        }
        if (r == 'Aquarius') {
            r1 = '11'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) - parseInt(11);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = parseInt(r11) + parseInt(1);

        }
        if (r == 'Pisces') {
            r1 = '12'
            r2 = r1 - '11';
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = parseInt(r11) + parseInt(1);

        }

        p1 = h1;
        p2 = h2;
        p3 = h3;
        p4 = h4;
        p5 = h5;
        p6 = h6;
        p7 = h7;
        p8 = h8;
        p9 = h9;
        p10 = h10;
        p11 = h11;
        p12 = h12;
        document.getElementById('h1l1').innerHTML = p1 + " " + 'Asc';
        document.getElementById('h2l1').innerHTML = p2;
        document.getElementById('h3l1').innerHTML = p3;
        document.getElementById('h4l1').innerHTML = p4;
        document.getElementById('h5l1').innerHTML = p5;
        document.getElementById('h6l1').innerHTML = p6;
        document.getElementById('h7l1').innerHTML = p7;
        document.getElementById('h8l1').innerHTML = p8;
        document.getElementById('h9l1').innerHTML = p9;
        document.getElementById('h10l1').innerHTML = p10;
        document.getElementById('h11l1').innerHTML = p11;
        document.getElementById('h12l1').innerHTML = p12;
        document.getElementById('h12r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r12 + '</span>' + '</br>';
        document.getElementById('h1r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r1 + '</span>' + '</br>';
        document.getElementById('h2r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r2 + '</span>' + '</br>';
        document.getElementById('h3r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r3 + '</span>' + '</br>';
        document.getElementById('h4r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r4 + '</span>' + '</br>';
        document.getElementById('h5r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r5 + '</span>' + '</br>';
        document.getElementById('h6r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r6 + '</span>' + '</br>';
        document.getElementById('h7r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r7 + '</span>' + '</br>';
        document.getElementById('h8r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r8 + '</span>' + '</br>';
        document.getElementById('h9r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r9 + '</span>' + '</br>';
        document.getElementById('h10r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r10 + '</span>' + '</br>';
        document.getElementById('h11r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r11 + '</span>' + '</br>';

    }
    return false;
}





function chartindexdata(){
var astname=document.getElementById('astname').innerHTML;
  var astmail=document.getElementById('astid').innerHTML;
  var clname=document.getElementById('clientname').innerHTML;
  var clmail=document.getElementById('clientid').innerHTML;
   var res = searchpage.viewclientinfo(astmail,clmail);
      var ds=res.value;

if(ds.Tables[0].Rows.length==0)
{
alert('client not exisxt')
 return false;
}
else
{

    window.open('chartindex.aspx?clmail='+ clmail + "&clname=" + clname+ "&astname=" + astname+ "&astmail=" + astmail);

}
}







function showdataingrid(iid) {
   
    var spl1 = iid.split("_");
    var spl2 = spl1[1];
   
  
      alert(exec_data.Tables[0].Rows[spl2]['DESCCLOB'])
   // document.getElementById('iid').value = exec_data.Tables[0].Rows[spl2]['DESCCLOB'];
      document.getElementById('clinetnamediv').style.display = 'block';
      alert(exec_data.Tables[0].Rows[spl2]['DESCCLOB'])
      document.getElementById('readmorediv').innerHTML = exec_data.Tables[0].Rows[spl2]['DESCCLOB'];

}



function creossdiv() {
    document.getElementById('clinetnamediv').style.display = 'none';
    return false;
}