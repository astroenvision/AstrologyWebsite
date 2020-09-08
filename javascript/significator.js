var querytype="";
var val = "";
var significator="";


var Houseposition="";
var exec_data = "";
var exec_extention = "";
var showext_value = "";
var next=0;
var execute="";
var Modify = 0;
var browser = navigator.appName;
var buf2 = new StringBuffer2();
function StringBuffer2() {
    this.buffer = [];
}

StringBuffer2.prototype.append = function append(string) {
    this.buffer.push(string);
    return this;
};

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
function StringBuffer3() {
    this.buffer = [];
}

StringBuffer3.prototype.append = function append(string) {
    this.buffer.push(string);
    return this;
};













function filter(event) 
{



    id = document.getElementById(document.activeElement.id).value;
    if (browser != "Microsoft Internet Explorer") {
        event.which;
    }
    else {

        event.keyCode;
    }
   

//var keycode = event.keyCode ? event.keyCode : event.which;
    if (event.keyCode == 37 || event.keyCode == 39) 
{
    return; 
  }
  if (event.keyCode == 46) 
    {


        if (document.getElementById("texthouse").value == '0') {
          var h=  document.getElementById("texthouse").value = ""
          house = h;
        }
        else {
            house = document.getElementById("texthouse").value
        }

        if (document.getElementById("planet").value == '0') {
            var p = document.getElementById("planet").value = ""
            planet = p;
        }
        else {
            planet = document.getElementById("planet").value
        }


        if (document.getElementById("rashi").value == '0') {
           var r= document.getElementById("rashi").value = ""
           rashi = r;
        }
        else {
            rashi = document.getElementById("rashi").value
        }
        ext = document.getElementById('Hidden6').value
       
       
        comp_code = "";
        book = "";
        page0 = "";
        textname = "";
        dedsec = "";
        var extra1 = id;
        document.getElementById('Hiddenid').value = extra1;
        significator.filtergrid1(comp_code, house, rashi, planet, textname, book, page0,ext, extra1, exec_gridcall)
        document.getElementById('filter_').focus();
        //doTimer();
        document.activeElement.id = "filter_";
        //alert(document.activeElement.id);
        document.getElementById('filter_').focus();
        document.getElementById('filter_').tabIndex = 0;
        document.getElementById('filter_').focus();
        return false;
    
    
    }
    if (document.getElementById("texthouse").value == '0') 
    {
      var h=  document.getElementById("texthouse").value = ""
      house = h;
     }
    else
     {
        house = document.getElementById("texthouse").value
    }

    if (document.getElementById("planet").value == '0') {
        var p = document.getElementById("planet").value = ""
        planet = p;
    }
    else {
        planet = document.getElementById("planet").value
    }


    if (document.getElementById("rashi").value == '0') {
      var r=  document.getElementById("rashi").value = ""
      rashi = r;
    }
    else {
        rashi = document.getElementById("rashi").value
    }
    
    
    
    
     ext = document.getElementById('Hidden6').value
    
    
    comp_code = "";
    book = "";
    page0 ="";
    textname = "";
    dedsec = "";
  var extra1 = id;
  document.getElementById('Hiddenid').value = extra1;
  significator.filtergrid1(comp_code, house, rashi, planet, textname, book, page0, ext, extra1, exec_gridcall)
  
  document.getElementById('filter_').focus();
  //doTimer();
  document.activeElement.id = "filter_";
  //alert(document.activeElement.id);
  document.getElementById('filter_').focus();
  document.getElementById('filter_').tabIndex = 0;
  document.getElementById('filter_').focus();


  return false;
}
function exec_gridcall(val) 
{
   
    var exec_grid = val.value;
    var id1 = document.getElementById('Hiddenid').value;
    var dsgrid = exec_grid
    document.getElementById('hdsviewgrid').innerHTML = "";
    document.getElementById('Divgrid1').style.display = "none";
    if (exec_grid.Tables[0].Rows.length >= 0) {
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
        buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='400px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   class='colum-td-head'>" + "KEY_STRINGS" + "</td>"
        
       
        buf2 += "</tr>"
        buf2 += "<tr>"
        buf2 += "<td  class='colum-td-head'>"
        buf2 += "<input type='text' id='filter_' runat='server' style='width:400px;' value='" + id1 + "' onkeyup='javascript:return filter(event);'   >"
        buf2 += "</td>"
        buf2 += "</tr>"
        // document.getElementById( 'filter_').focus();
        len = 1;

        if (dsgrid.Tables[0].Rows.length == 0) {

        }

        if (dsgrid.Tables[0].Rows.length > 0) {

            for (i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {


                buf2 += "<tr>"


                buf2 += "<td   class='colum-td-new1'>"
                  buf2 += "<font width='900px'>" +(dsgrid.Tables[0].Rows[i]['KEY_STRINGS']) + "</font>"
                buf2 += "<input type='hidden' style='width:250px;' class='dropdown_large_corr'; align='left' value='" + dsgrid.Tables[0].Rows[i]['KEY_STRINGS'] + "'  id='key_" + i + "'  >"
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
        
        //alert(document.activeElement.id);
     //   doTimer();
        document.getElementById('filter_').focus();
        document.getElementById('filter_').tabIndex = 0;
        document.getElementById('filter_').focus();
        var text = document.getElementById('filter_');
        if (text != null && text.value.length > 0) {
            if (text.createTextRange) {
                var FieldRange = text.createTextRange();
                FieldRange.moveStart('character', text.value.length);
                FieldRange.collapse();
                FieldRange.select();
               
            }
        }

        
        return false;

    }
}




function update12(id) {
    var update = id.split('_')
    var update1 = update[1];
    var key = dsexec.Tables[0].Rows[update1].KEY_STRINGS
    var key1 = document.getElementById("key_" + update1).value;
    if (document.getElementById('texthouse').value != 0) {
        var housev = document.getElementById('texthouse').value
    }
    if (document.getElementById('planet').value != 0) {
        var housev = document.getElementById('planet').value
    }

    if (document.getElementById('rashi').value != 0) {
        var housev = document.getElementById('rashi').value
    }
    
    var res = significator.update_grid(key, key1,housev);


    alert("Data updated Successfully")


    return false;
}


function delete1(id) {
    var delet = id.split('_')
    var delet1 = delet[1];
    var key = dsexec.Tables[0].Rows[delet1].KEY_STRINGS
    //house = document.getElementById("texthouse").value

    if (document.getElementById('texthouse').value != 0) {
        var housev = document.getElementById('texthouse').value
    }
    if (document.getElementById('planet').value != 0) {
        var housev = document.getElementById('planet').value
    }

    if (document.getElementById('rashi').value != 0) {
        var housev = document.getElementById('rashi').value
    }
    
    
    
    var res = encyclopaedia.delete_grid_row(key,housev);


    alert("Data deleted Successfully")


    return false;
}






function update1(id) {
    var update = id.split('_')
    var update11 = update[1];
    var key = ds.Tables[0].Rows[update11].KEY_STRINGS
    var key1 = document.getElementById("key_" + update11).value;
    if (document.getElementById('ho_' + update11).value != null && document.getElementById('ho_' + update11).value != "" && document.getElementById('ho_' + update11).value != '0') {
        var housev = document.getElementById("ho_" + update11).value
    }
    if (document.getElementById('ra_' + update11).value != null && document.getElementById('ra_' + update11).value != "" && document.getElementById('ra_' + update11).value != '0') {
        var housev = document.getElementById('ra_' + update11).value 
    }

    if (document.getElementById('pl_' + update11).value != null && document.getElementById('pl_' + update11).value != "" && document.getElementById('pl_' + update11).value != '0') {
        var housev = document.getElementById('pl_' + update11).value
    }
    var res = significator.update_grid(key,key1,housev);


    alert("Data updated Successfully")


    return false;
}

function delete12(id) {
    var delete11 = id.split('_')
    var delete12 = delete11[1];
   
    var key = document.getElementById("key_" + delete12).value;
    if (document.getElementById('ho_' + delete12).value != null && document.getElementById('ho_' + delete12).value != "" && document.getElementById('ho_' + delete12).value != '0') {
        var housev = document.getElementById("ho_" + delete12).value
    }
    if (document.getElementById('ra_' + delete12).value != null && document.getElementById('ra_' + delete12).value != "" && document.getElementById('ra_' + delete12).value != '0') {
        var housev = document.getElementById('ra_' + delete12).value
    }

    if (document.getElementById('pl_' + delete12).value != null && document.getElementById('pl_' + delete12).value != "" && document.getElementById('pl_' + delete12).value != '0') {
        var housev = document.getElementById('pl_' + delete12).value
    }
    var res = significator.delete_grid_row(key, housev);


    alert("Data deleted Successfully")


    return false;
}


function chk12(id) {
    var chk = id.split('_')
    var chk1 = chk[1];
    var key = document.getElementById("key_" + chk1).value
    if (document.getElementById('ho_' + chk1).value != null && document.getElementById('ho_' + chk1).value != "" && document.getElementById('ho_' + chk1).value != '0') {
        var housev = document.getElementById("ho_" + chk1).value
    }
    if (document.getElementById('ra_' + chk1).value != null && document.getElementById('ra_' + chk1).value != "" && document.getElementById('ra_' + chk1).value != '0') {
        var housev = document.getElementById('ra_' + chk1).value
    }

    if (document.getElementById('pl_' + chk1).value != null && document.getElementById('pl_' + chk1).value != "" && document.getElementById('pl_' + chk1).value != '0') {
        var housev = document.getElementById('pl_' + chk1).value
    }
    document.getElementById("vrf_" + chk1).value = 'Chk'

    var res = significator.chk_encyclo(key, housev);
    alert("Data Verified Successfully")
    return false;


}


function showextentions() {

 document.getElementById('hdsviewgrid').innerHTML = "";
    document.getElementById('Divgrid1').style.display = "none";
    document.getElementById('hdsviewgrid2').innerHTML = "";
    document.getElementById('Divgrid2').style.display = "none";
    if (document.getElementById('texthouse').value != 0) 
    {
        var exten = document.getElementById('texthouse').value
    }
    if (document.getElementById('planet').value != 0) 
    {
        var exten = document.getElementById('planet').value
            }

    if (document.getElementById('rashi').value != 0) 
    {
        var exten = document.getElementById('rashi').value
    }
    document.getElementById('Hidden7').value = exten;
    significator.showext(exten, call_ext);
    return false;
}

function call_ext(val) {

   
    exec_extention = val.value;
    if (exec_extention.Tables[0].Rows.length > 0) {
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

        if (document.getElementById("hdsviewgrid2").innerHTML.indexOf("width:280px;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid2").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf3 = "";
        buf3 += "<table  id='Divgrid2' runat='server' align='left' Width='280px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf3 += "<tr>"
        buf3 += "<td class='colum-td-head Planets'>" + "EXTENTIONS" + "</td>"
        buf3 += "<td class='colum-td-head Planets'>" + "Show" + "</td>"
      
        buf3 += "</tr>"
      
        len = 1;


        if (exec_extention.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_extention.Tables[0].Rows.length; ++i) 
            {

                buf3 += "<tr>"
                buf3 += "<td    class='colum-td-new1'>"
                buf3 += "<font width='900px'>"+exec_extention.Tables[0].Rows[i]['EXTENTIONS'] + "</font>"
                buf3 += "<input type='hidden' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + exec_extention.Tables[0].Rows[i]['EXTENTIONS'] + "'  id='ext_" + i + "'  >"
                buf3 += "</td>"
                buf3 += "<td     class='colum-td-new1' >"
                buf3 += "<Button  style='width:80px;' align='left' class='per_btn1_signi'  value='show' AutoPostBack='true' id='showext_" + i + "' onClick='javascript:return showext12(this.id);' >Show...</Button>"
                buf3 += "</td>"

               
                buf3 += "</tr>"
            }
        }
        buf3 += "</table>"

        var hdsview = "";
        temp_del1 = aa + buf3.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('hdsviewgrid2').innerHTML = temp_del1;
       
        return false;

    }


}
function showext12(id) {
 document.getElementById('hdsviewgrid').innerHTML = "";
    document.getElementById('Divgrid1').style.display = "none";
//    document.getElementById('hdsviewgrid2').innerHTML = "";
//    document.getElementById('Divgrid2').style.display = "none";
   
    var extense = id.split('_')
    var extense1 = extense[1];

    var extenvalue = exec_extention.Tables[0].Rows[extense1].EXTENTIONS
    if (document.getElementById('texthouse').value != 0) {
        var exten = document.getElementById('texthouse').value
    }
    if (document.getElementById('planet').value != 0) {
        var exten = document.getElementById('planet').value
    }

    if (document.getElementById('rashi').value != 0) {
        var exten = document.getElementById('rashi').value
    }
   
    document.getElementById('Hidden6').value = extenvalue
    
     document.getElementById('Hidden7').value = exten
   var res = significator.showextvalue_natal(exten,extenvalue,exec_showextvalue);


   


    return false;

}
function exec_showextvalue(val)
 {
     dsexec = val.value;
     if (dsexec.Tables[0].Rows.length > 0) {
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

         if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:460px;display:block") <= 0) {
             aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
         }
         buf2 = "";
         buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='280px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
         buf2 += "<tr>"
         buf2 += "<td class='colum-td-head'>" + "KEY_STRINGS" + "</td>"
         
       
         buf2 += "</tr>"
         buf2 += "<tr>"
         buf2 += "<td   colum-td-head'>"
         buf2 += "<input type='text' id='filter_' runat='server' style='width:280px;' onkeyup='javascript:return filter(event);'  >"
         buf2 += "</td>"
         buf2 += "</tr>"

         len = 1;


         if (dsexec.Tables[0].Rows.length > 0) {
             for (i = 0; i < dsexec.Tables[0].Rows.length; ++i) {

                 buf2 += "<tr>"
                  buf2 += "<td   class='colum-td-new1'>"
                buf2 += "<font width='900px'>"+dsexec.Tables[0].Rows[i]['KEY_STRINGS'] + "</font>"
                buf2 += "<input type='hidden' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsexec.Tables[0].Rows[i]['KEY_STRINGS'] + "'  id='key_" + i + "'  >"
//                 buf2 += "<td   style='border: solid 1px black;' align='left'>"
//                   buf2 += "<font width='900px'>" +(dsexec.Tables[0].Rows[i]['KEY_STRINGS']) + "</font>"
//                 buf2 += "<input type='hidden' style='width:280px;' align='left' class='dropdown_large_corr'; value='" + dsexec.Tables[0].Rows[i]['KEY_STRINGS'] + "'  id='key_" + i + "'  >"
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
         document.getElementById('filter_').focus();
         return false;

     }
 }


 function check1(id) {
     var chk = id.split('_')
     var chk1 = chk[1];
     var key = document.getElementById("key_" + chk1).value
     if (document.getElementById('texthouse').value != 0) {
         var housev = document.getElementById('texthouse').value
     }
     if (document.getElementById('planet').value != 0) {
         var housev = document.getElementById('planet').value
     }

     if (document.getElementById('rashi').value != 0) {
         var housev = document.getElementById('rashi').value
     }
     document.getElementById("vrf_" + chk1).value = 'Chk'
     
     var res = encyclopaedia.chk_encyclo(key,housev);
     alert("Data Verified Successfully")


     return false;


 }





function fillcategery(event) 
{
    document.getElementById('hdsviewgrid2').innerHTML = "";
    document.getElementById('Divgrid2').style.display = "none";
   // document.getElementById('hous').style.display = "block";
    //document.getElementById('karka').style.display = "block";
    //document.getElementById('rash').style.display = "block";
    //document.getElementById('plant').style.display = "block";
    //document.getElementById('inserts').style.display = "block";
    //document.getElementById('Label7').style.display = "block";  
   var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "gs") {

        var extra1 = document.getElementById('gs').value;
            
           significator.fill_categery(extra1,callback_categery);
            return false;            
        }
       
    }
    
}

function callback_categery(val) {
    ds = val.value;
    var id1 = document.getElementById('Hiddenid').value;
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {

        document.getElementById('hdsviewgrid').innerHTML = "";
        document.getElementById('Divgrid1').style.display = "none";
        if (ds.Tables[0].Rows.length >= 0) {
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

            if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:560px;display:block") <= 0) {
                aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
            }
            buf2 = "";
            buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='500px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
            buf2 += "<tr>"
            buf2 += "<td  class='colum-td-head'>" + "KEY_STRINGS" + "</td>"
            buf2 += "<td  class='colum-td-head'>" + "HOUSE" + "</td>"
            buf2 += "<td  class='colum-td-head'>" + "RASHI" + "</td>"
            buf2 += "<td  class='colum-td-head'>" + "PLANET" + "</td>"
            
            
            
            buf2 += "</tr>"
           
            // document.getElementById( 'filter_').focus();
            len = 1;

            if (ds.Tables[0].Rows.length == 0) {
                return false;
            }

            if (ds.Tables[0].Rows.length > 0) {

                for (i = 0; i < ds.Tables[0].Rows.length; ++i) {


                    buf2 += "<tr>"


                    buf2 += "<td   class='colum-td-new1'>"
                     buf2 += "<font width='900px'>" +(ds.Tables[0].Rows[i]['KEY_STRINGS']) + "</font>"
                    buf2 += "<input type='hidden' style='width:374px;' class='dropdown_large_corr'; align='left' value='" + ds.Tables[0].Rows[i]['KEY_STRINGS'] + "'  id='key_" + i + "'  >"
                    buf2 += "</td>"


                    if (ds.Tables[0].Rows[i]['HOUSE'] == null || ds.Tables[0].Rows[i]['HOUSE'] == "0") {
                   var hou= ds.Tables[0].Rows[i]['HOUSE'] = "0"

                        buf2 += "<td  class='colum-td-new1'>"
                        buf2 += "<font width='900px'>" +(hou) + "</font>"
                        buf2 += "<input type='hidden' style='width:60px;' class='dropdown_large_corr'; align='left'   id='ho_" + i + "'  >"
                        buf2 += "</td>"


                    }
                    else {

                        buf2 += "<td  class='colum-td-new1'>"
                        buf2 += "<font width='900px'>" +(ds.Tables[0].Rows[i]['HOUSE']) + "</font>"
                        buf2 += "<input type='hidden' style='width:60px;' class='dropdown_large_corr'; align='left' value='" + ds.Tables[0].Rows[i]['HOUSE'] + "'  id='ho_" + i + "'  >"
                        buf2 += "</td>"
                    }

                    if (ds.Tables[0].Rows[i]['RASHI'] == null || ds.Tables[0].Rows[i]['RASHI'] == "0") {
                   var ras=  ds.Tables[0].Rows[i]['RASHI'] = "0"
                   buf2 += "<td  class='colum-td-new1'>"
                        buf2 += "<font width='900px'>" +(ras) + "</font>"
                        buf2 += "<input type='hidden' style='width:60px;' class='dropdown_large_corr'; align='left'  id='ra_" + i + "'  >"
                        buf2 += "</td>"
                    }
                    else {


                        buf2 += "<td  class='colum-td-new1'>"
                        buf2 += "<font width='900px'>" +(ds.Tables[0].Rows[i]['RASHI']) + "</font>"
                        buf2 += "<input type='hidden' style='width:60px;' class='dropdown_large_corr'; align='left' value='" + ds.Tables[0].Rows[i]['RASHI'] + "'  id='ra_" + i + "'  >"
                        buf2 += "</td>"
                    }


                    if (ds.Tables[0].Rows[i]['PLANET'] == null || ds.Tables[0].Rows[i]['PLANET'] == "0") {
                   var pla= ds.Tables[0].Rows[i]['PLANET'] = "0"
                        buf2 += "<td   class='colum-td-new1'>"
                         buf2 += "<font width='900px'>" +(pla) + "</font>"
                        buf2 += "<input type='hidden' style='width:60px;' class='dropdown_large_corr'; align='left'  id='pl_" + i + "'  >"
                        buf2 += "</td>"
                    }
                    else {
                        buf2 += "<td   class='colum-td-new1'>"
                         buf2 += "<font width='900px'>" +(ds.Tables[0].Rows[i]['PLANET']) + "</font>"
                        buf2 += "<input type='hidden' style='width:60px;' class='dropdown_large_corr'; align='left' value='" + ds.Tables[0].Rows[i]['PLANET'] + "'  id='pl_" + i + "'  >"
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
            //alert(temp_del1)
            document.getElementById('hdsviewgrid').innerHTML = temp_del1;



            return false;

        }
    }
    return false;
}




function showmultiplesignificators() 
{
document.getElementById('texthouse').value="";
document.getElementById('planet').selectedIndex='0';
document.getElementById('rashi').selectedIndex='0';
    document.getElementById('hdsviewgrid2').innerHTML = "";
    document.getElementById('Divgrid2').style.display = "none";
    var multisign = document.getElementById("Textname").value;
    significator.multisignificators(multisign, callback_categery);
    return false;
 
 
}


function clh() {
    if (document.getElementById('texthouse').value != '--Select House--') {
        document.getElementById('planet').value = '0';
        document.getElementById('rashi').value = '0';

    }
    return false;
}

function clp() {
    if (document.getElementById('planet').value != '--Select Planet--') {
        document.getElementById('texthouse').value = '0';
        document.getElementById('rashi').value = '0';

    }
    return false;
}
function clr() {
    if (document.getElementById('rashi').value != '--Select Rashi--') {
        document.getElementById('texthouse').value = '0';
        document.getElementById('planet').value = '0';

    }
    return false;
}