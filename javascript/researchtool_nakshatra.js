var astrodegree = "";
var exec_data = "";
var next = 0;
var execute = "";
var exec_data1 = "";
var Modify = 0;
var delete_record = 0;
var totalh="0";
var gridtotal="0";
var browser = navigator.appName;
var find_flag;
var buf1 = new StringBuffer();
function StringBuffer() {
    this.buffer = [];
}


StringBuffer.prototype.append = function append(string) {
    this.buffer.push(string);
    return this;
};

function StringBuffer() {
    this.buffer = [];
}

StringBuffer.prototype.append = function append(string) {
    this.buffer.push(string);
    return this;
}

StringBuffer.prototype.toString = function toString() {
    return this.buffer.join("");
}
 
function gridcall() {
buf1="";
 //document.getElementById('astname').innerHTML=document.getElementById('Hastname').value;
 document.getElementById('astid').innerHTML =document.getElementById('Hastmail').value;
 //document.getElementById('clientname').innerHTML =document.getElementById('Hclname').value;
//document.getElementById('clientid').innerHTML =document.getElementById('Hclmail').value;
 
 

    grid();


   
     accountuser(); 
   
  
}



function allchk()
{
if(document.getElementById('totc_').checked==true)
{
  if(find_flag==1)
      {
    document.getElementById('ash1c_').checked=true;
    document.getElementById('bha2c_').checked=true;
    document.getElementById('kri3c_').checked=true;
    document.getElementById('roh4c_').checked=true;
    document.getElementById('mri5c_').checked=true;
    document.getElementById('ard6c_').checked=true;
    document.getElementById('pun7c_').checked=true;
    document.getElementById('pus8c_').checked=true;
    document.getElementById('ash9c_').checked=true;
    document.getElementById('mag10c_').checked=true;
    document.getElementById('pph11c_').checked=true;
    document.getElementById('uph12c_').checked=true;
    document.getElementById('has13c_').checked=true;
    document.getElementById('chi14c_').checked=true;
    document.getElementById('swa15c_').checked=true;
    document.getElementById('vis16c_').checked=true;
    document.getElementById('anu17c_').checked=true;
    document.getElementById('jye18c_').checked=true;
    document.getElementById('moo19c_').checked=true;
    document.getElementById('pas20c_').checked=true;
    document.getElementById('uas21c_').checked=true;
    document.getElementById('shr22c_').checked=true;
    document.getElementById('dha23c_').checked=true;
    document.getElementById('sha24c_').checked=true;
    document.getElementById('pbh25c_').checked=true;
    document.getElementById('ubh26c_').checked=true;
    document.getElementById('rev27c_').checked=true;
}


}
else
{ if(find_flag==1)
      {
document.getElementById('ash1c_').checked=false;
    document.getElementById('bha2c_').checked=false;
    document.getElementById('kri3c_').checked=false;
    document.getElementById('roh4c_').checked=false;
    document.getElementById('mri5c_').checked=false;
    document.getElementById('ard6c_').checked=false;
    document.getElementById('pun7c_').checked=false;
    document.getElementById('pus8c_').checked=false;
    document.getElementById('ash9c_').checked=false;
    document.getElementById('mag10c_').checked=false;
    document.getElementById('pph11c_').checked=false;
    document.getElementById('uph12c_').checked=false;
    document.getElementById('has13c_').checked=false;
    document.getElementById('chi14c_').checked=false;
    document.getElementById('swa15c_').checked=false;
    document.getElementById('vis16c_').checked=false;
    document.getElementById('anu17c_').checked=false;
    document.getElementById('jye18c_').checked=false;
    document.getElementById('moo19c_').checked=false;
    document.getElementById('pas20c_').checked=false;
    document.getElementById('uas21c_').checked=false;
    document.getElementById('shr22c_').checked=false;
    document.getElementById('dha23c_').checked=false;
    document.getElementById('sha24c_').checked=false;
    document.getElementById('pbh25c_').checked=false;
    document.getElementById('ubh26c_').checked=false;
    document.getElementById('rev27c_').checked=false;
}

}
}

function grid() {

find_flag=1;
    document.getElementById('hdsviewgrid').innerHTML = "";
        document.getElementById('Divgrid1').style.display = 'block';
    var temp_del1 = "";

    flg_req = "yes"
    var aa1 = "";
    var aa = "";
    var hs = 0;
    var hs1 = 0;
   
    document.getElementById('hdsviewgrid').style.display = "block";
    $('hdsviewgrid').style.display = "block";
   

    if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:970px;display:block") <= 0) {
        aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
    }
    
    buf1 += "<table  id='Divgrid1' runat='server' align='left' Width='970px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
    buf1 += "<tr>"
    
    

    buf1 += "<td class='colum-td-head-chart'>" + "Ashwini" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Ashwini'  id='ash1c_'>"
    buf1 += "</td>"
    
    buf1 += "<td class='colum-td-head-chart'>" + "Bharani" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Bharani' id='bha2c_'>"
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "Krittika" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Krittika' id='kri3c_'>"
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" +"Rohini" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Rohini' id='roh4c_'>"
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "Mrigshira" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Mrigshira' id='mri5c_'>"
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "Ardra" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Ardra' id='ard6c_'>"
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "Punarvasu" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Punarvasu' id='pun7c_'>"
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "Pushya" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Pushya' id='pus8c_'>"
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "Ashlesha" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Ashlesha' id='ash9c_'>"
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "Magha" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Magha' id='mag10c_'>"
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "Poorva Phalguni" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Poorva Phalguni' id='pph11c_'>"
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "Uttara Phalguni" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Uttara Phalguni'  id='uph12c_'>"
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "Hasta" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Hasta' id='has13c_'>"
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "Chitra" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Chitra'  id='chi14c_'>"
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "Swati" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Swati' id='swa15c_'>"
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "Vishakha" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Vishakha' id='vis16c_'>"
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "Anuradha" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Anuradha' id='anu17c_'>"
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>"  +"Jyestha" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Jyestha' id='jye18c_'>"
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>"+ "Moola" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Moola' id='moo19c_'>"
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>"+ "Poorva Ashadah" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Poorva Ashadah' id='pas20c_'>"
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "Uttara Ashadah" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Uttara Ashadah' id='uas21c_'>"
    buf1 +="</td>"
  
    buf1 += "<td class='colum-td-head-chart'>" + "Shravana" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Shravana' id='shr22c_'>"
    buf1 +="</td>"
      buf1 += "<td class='colum-td-head-chart'>" + "Dhanishth" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Dhanishth' id='dha23c_'>"
    buf1 +="</td>"
      buf1 += "<td class='colum-td-head-chart'>" + "Shatbhisha" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Shatbhisha' id='sha24c_'>"
    buf1 +="</td>"
      buf1 += "<td class='colum-td-head-chart'>" + "Poorva Bhadrapada" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Poorva Bhadrapada' id='pbh25c_'>"
    buf1 +="</td>"
      buf1 += "<td class='colum-td-head-chart'>" + "Uttara Bhadrapada" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Uttara Bhadrapada'  id='ubh26c_'>"
    buf1 +="</td>"
      buf1 += "<td class='colum-td-head-chart'>" + "Revati" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Revati' id='rev27c_'>"
    buf1 +="</td>"
    
        buf1 += "<td class='colum-td-head-chart'> "+ "Total" 
    buf1 += "<input type='checkbox' style='width:40px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='totc_' onclick='javascript:allchk();'>"
    buf1 +="</td>"
    
   


    buf1 += "</tr>"

    len = 1;

for (var i = 0; i < 1; i++) 
{
    buf1 += "<tr>"


   


   
    
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   style='width:30px;'class='colum-name_id'; align='left'  id='ash1c_" + i + "' onclick='javascript:open_div_button(id);'>"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='bha2c_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='kri3c_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='roh4c_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='mri5c_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='ard6c_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='pun7c_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left' id='pus8c_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='ash9c_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text' onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='mag10c_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left' id='pph11c_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left' id='uph12c_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='has13c_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='chi14c_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left' id='swa15c_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='vis16c_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='anu17c_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text' onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='jye18c_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='moo19c_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='pas20c_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='uas21c_" + i + "' >"
    buf1 += "</td>"


    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='shr22c_" + i + "' >"
    buf1 += "</td>"
    
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='dha23c_" + i + "' >"
    buf1 += "</td>"
    
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='sha24c_" + i + "' >"
    buf1 += "</td>"
    
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='pbh25c_" + i + "' >"
    buf1 += "</td>"
    
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='ubh26c_" + i + "' >"
    buf1 += "</td>"
    
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='rev27c_" + i + "' >"
    buf1 += "</td>"
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  Enabled='false'disabled style='width:30px;'class='dropdown_large_corr'; align='left'  id='total_" + i + "' >"
    buf1 += "</td>"

    
    
   
   
    buf1 += "</tr>"
    
     
    
    
    
    
    
    
   } 

    
  
  buf1 += "</table>"
    var hdsview = "";
    
    temp_del1 = aa + buf1.toString();
     
    temp_del1 = temp_del1.replace("<TBODY>", "")
    temp_del1 = temp_del1.replace("</TBODY>", "")
    //alert(temp_del1)
    document.getElementById('hdsviewgrid').innerHTML = temp_del1;
     
   
    
   


   
    }
    
   

function binddropdown(res) {

    
    if (res == 'planets_0') {
        document.getElementById(res).value = "SUN";
    }

    if (res == 'planets_1') {
        document.getElementById(res).value = "MOON";
    }

    if (res == "planets_2") {
        document.getElementById(res).value = "MARS";
    }

    if (res == "planets_3") {
        document.getElementById(res).value = "MERCURY";
    }

    if (res == "planets_4") {
        document.getElementById(res).value = "JUPITER";
    }

    if (res == "planets_5") {
        document.getElementById(res).value = "VENUS";
}
    if (res == "planets_6") {
            document.getElementById(res).value = "SATURN";
}


               
    }




    
 
 
 function search1()
     {
   
     

     var astrolrger = document.getElementById('Hastmail').value;

     var planet = "";
     var flag = 0;
     if (document.getElementById('csu').checked == true) {
         planet = planet + 'SUN' + ',';
         flag = flag + 1;
     }

     if (document.getElementById('cmo').checked == true) {

         planet = planet + 'MOON' + ','
         flag = flag + 1;
     }

     if (document.getElementById('cma').checked == true) {

         planet = planet + 'MARS' + ',';
         flag = flag + 1;
     }


     if (document.getElementById('cme').checked == true) {

         planet = planet + 'MERCURY' + ',';
         flag = flag + 1;
     }

     if (document.getElementById('cju').checked == true) {

         planet = planet + 'JUPITER' + ',';
         flag = flag + 1;
     }

     if (document.getElementById('cve').checked == true) {

         planet = planet + 'VENUS' + ',';
         flag = flag + 1;
     }
     if (document.getElementById('csa').checked == true) {

         planet = planet + 'SATURN' + ',';
         flag = flag + 1;
     }
     if (document.getElementById('cra').checked == true) {

         planet = planet + 'RAHU' + ',';
         flag = flag + 1;
     }
     if (document.getElementById('cke').checked == true) {

         planet = planet + 'KETU' + ',';
         flag = flag + 1;
     }

     var planet1 = planet.slice(0, -1);
     var nakshatra ="";
     
         
          if(document.getElementById('ash1c_').checked == true)
          {
             nakshatra= 'Ashwini'+','+nakshatra;
          }
         
          if(document.getElementById('bha2c_').checked == true)
          {
           nakshatra='Bharani'+','+nakshatra;
          }
          
          if(document.getElementById('kri3c_').checked == true)
          {
          nakshatra='Krittika'+','+nakshatra;
          }
          
          if(document.getElementById('roh4c_').checked == true)
          {
             nakshatra='Rohini'+','+nakshatra;
          }
         
         if(document.getElementById('mri5c_').checked == true)
         {
          nakshatra= 'Mrigshira'+','+nakshatra;
         }
          
         if(document.getElementById('ard6c_').checked == true)
         {
          nakshatra= 'Ardra'+','+nakshatra;
         }
         
         if(document.getElementById('pun7c_').checked == true)
         {
          nakshatra= 'Punarvasu'+','+nakshatra;
         } 
         
         if(document.getElementById('pus8c_').checked == true)
         {
         nakshatra= 'Pushya'+','+nakshatra;
         } 
         
         if(document.getElementById('ash9c_').checked == true)
         {
         nakshatra= 'Ashlesha'+','+nakshatra;
         } 
         
         if(document.getElementById('mag10c_').checked == true)
         {
          nakshatra= 'Magha'+','+nakshatra;
         } 
         
         if(document.getElementById('pph11c_').checked == true)
         {
         nakshatra= 'Poorva Phalguni'+','+nakshatra;
         } 
         
         if(document.getElementById('uph12c_').checked == true)
         {
          nakshatra= 'Uttara Phalguni'+','+nakshatra;
         } 
         
         if(document.getElementById('has13c_').checked == true)
         {
          nakshatra= 'Hasta'+','+nakshatra;
         } 
         
         if(document.getElementById('chi14c_').checked == true)
         {
          nakshatra= 'Chitra'+','+nakshatra;
         } 
         
         if(document.getElementById('swa15c_').checked == true)
         {
          nakshatra= 'Swati'+','+nakshatra;
         } 
         
         if(document.getElementById('vis16c_').checked == true)
         {
          nakshatra= 'Vishakha'+','+nakshatra;
         } 
         
         if(document.getElementById('anu17c_').checked == true)
         {
          nakshatra= 'Anuradha'+','+nakshatra;
         } 
         
         if(document.getElementById('jye18c_').checked == true)
         {
          nakshatra= 'Jyestha'+','+nakshatra;
         } 
         
         if(document.getElementById('moo19c_').checked == true)
         {
          nakshatra= 'Moola'+','+nakshatra;
         } 
         
         if(document.getElementById('pas20c_').checked == true)
         {
          nakshatra= 'Poorva Ashadah'+','+nakshatra;
         } 
         
         if(document.getElementById('uas21c_').checked == true)
         {
          nakshatra= 'Uttara Ashadah'+','+nakshatra;
         } 
         
         if(document.getElementById('shr22c_').checked == true)
         {
          nakshatra= 'Shravana'+','+nakshatra;
         } 
         
         if(document.getElementById('dha23c_').checked == true)
         {
          nakshatra= 'Dhanishth'+','+nakshatra;
         } 
         
         if(document.getElementById('sha24c_').checked == true)
         {
          nakshatra= 'Shatbhisha'+','+nakshatra;
         } 
         
         if(document.getElementById('pbh25c_').checked == true)
         {
          nakshatra= 'Poorva Bhadrapada'+','+nakshatra;
         } 
         
         if(document.getElementById('ubh26c_').checked == true)
         {
          nakshatra= 'Uttara Bhadrapada'+','+nakshatra;
         } 
         
         if(document.getElementById('rev27c_').checked == true)
         {
          nakshatra= 'Revati'+','+nakshatra;
         } 
         
         
         var nakshatra1=nakshatra.slice(0,-1);
     
         if(find_flag==1)
            {
               if(nakshatra1=="" || document.getElementById('clgroup').value=="0" )
                 {
                     alert('Pls select Group name or nakshatra');
                     return false;
                 }
            }
         if (document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text == 'General') {
                var client = document.getElementById('grcl').value;
            }
            else {
                var client = "";
            }

            var p = planet1.replace(/,/g, ' and ');
            var r = nakshatra1.replace(/,/g, ' or ');
            var query = p + ' are in ' + r + ' Constellation in ' + document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text + ' Group '
            document.getElementById('qry').innerHTML = query;
            var conj = document.getElementById('Hdnna').value;
            var res = researchtool_nakshatra.search(planet1, nakshatra1, astrolrger, document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text, flag, client, conj);
      var ds=res.value;
      var inc=1;
      var dec=0;
      document.getElementById('total_'+0).value="0";
    
  if(find_flag==1)
   {
      if(document.getElementById('ash1c_').checked==true)
      {
      document.getElementById('ash1c_'+0).value=0
      }
      else
        {
        document.getElementById('ash1c_'+0).value=""
        }
        
   if(document.getElementById('bha2c_').checked==true)
   {
    document.getElementById('bha2c_'+0).value=0
    }
    else
    {
    document.getElementById('bha2c_'+0).value=""
    }

   if(document.getElementById('kri3c_').checked==true)
   {
    document.getElementById('kri3c_'+0).value=0
    }
    else
    {
    document.getElementById('kri3c_'+0).value=""
    }

   if(document.getElementById('roh4c_').checked==true)
   {
    document.getElementById('roh4c_'+0).value=0
    }
    else
    {
    document.getElementById('roh4c_'+0).value=""
    }

   if(document.getElementById('mri5c_').checked==true)
   {
    document.getElementById('mri5c_'+0).value=0
    }
    else
    {
    document.getElementById('mri5c_'+0).value=""
    }

   if(document.getElementById('ard6c_').checked==true)
   {
    document.getElementById('ard6c_'+0).value=0
    }
    else
    {
    document.getElementById('ard6c_'+0).value=""
    }

   if(document.getElementById('pun7c_').checked==true)
   {
    document.getElementById('pun7c_'+0).value=0
    }
    else
    {
    document.getElementById('pun7c_'+0).value=""
    }

    if(document.getElementById('pus8c_').checked==true)
    {
    document.getElementById('pus8c_'+0).value=0
    }
    else
    {
    document.getElementById('pus8c_'+0).value=""
    }

   if(document.getElementById('ash9c_').checked==true)
   {
    document.getElementById('ash9c_'+0).value=0
    }
    else
    {
    document.getElementById('ash9c_'+0).value=""
    }

   if(document.getElementById('mag10c_').checked==true){
document.getElementById('mag10c_'+0).value=0
}
else
{document.getElementById('mag10c_'+0).value=""}

   if(document.getElementById('pph11c_').checked==true){
document.getElementById('pph11c_'+0).value=0
}
else
{document.getElementById('pph11c_'+0).value=""}

   if(document.getElementById('uph12c_').checked==true){
document.getElementById('uph12c_'+0).value=0
}
else
{document.getElementById('uph12c_'+0).value=""}

   if(document.getElementById('has13c_').checked==true){
document.getElementById('has13c_'+0).value=0
}
else
{document.getElementById('has13c_'+0).value=""}

   if(document.getElementById('chi14c_').checked==true){
document.getElementById('chi14c_'+0).value=0
}
else
{document.getElementById('chi14c_'+0).value=""}

   if(document.getElementById('swa15c_').checked==true){
document.getElementById('swa15c_'+0).value=0
}
else
{document.getElementById('swa15c_'+0).value=""}

   if(document.getElementById('vis16c_').checked==true){
document.getElementById('vis16c_'+0).value=0
}
else
{document.getElementById('vis16c_'+0).value=""}

   if(document.getElementById('anu17c_').checked==true){
document.getElementById('anu17c_'+0).value=0
}
else
{document.getElementById('anu17c_'+0).value=""}

   if(document.getElementById('jye18c_').checked==true){
document.getElementById('jye18c_'+0).value=0
}
else
{document.getElementById('jye18c_'+0).value=""}

   if(document.getElementById('moo19c_').checked==true){
document.getElementById('moo19c_'+0).value=0
}
else
{document.getElementById('moo19c_'+0).value=""}

   if(document.getElementById('pas20c_').checked==true){
document.getElementById('pas20c_'+0).value=0
}
else
{document.getElementById('pas20c_'+0).value=""}

   if(document.getElementById('uas21c_').checked==true){
document.getElementById('uas21c_'+0).value=0
}
else
{document.getElementById('uas21c_'+0).value=""}


if(document.getElementById('shr22c_').checked==true){
document.getElementById('shr22c_'+0).value=0
}
else
{document.getElementById('shr22c_'+0).value=""}


if(document.getElementById('dha23c_').checked==true){
document.getElementById('dha23c_'+0).value=0
}
else
{
document.getElementById('dha23c_'+0).value=""
}
     

if(document.getElementById('sha24c_').checked==true){
document.getElementById('sha24c_'+0).value=0
}
else
{document.getElementById('sha24c_'+0).value=""}
  

if(document.getElementById('pbh25c_').checked==true){
document.getElementById('pbh25c_'+0).value=0
}
else
{document.getElementById('pbh25c_'+0).value=""}
  

if(document.getElementById('ubh26c_').checked==true){
document.getElementById('ubh26c_'+0).value=0
}
else
{document.getElementById('ubh26c_'+0).value=""}
  

if(document.getElementById('rev27c_').checked==true){
document.getElementById('rev27c_'+0).value=0
}
else
{document.getElementById('rev27c_'+0).value=""}
}  

       if (ds.Tables[0].Rows.length > 0) 
       {
     
       for (i = 0; i < ds.Tables[0].Rows.length; ++i)
       
        {
        if(find_flag==1)
        {
       if(document.getElementById('ash1c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('ash1c_').value)
       {
     
        if(document.getElementById('ash1c_'+0)!=null)
         {
          if(document.getElementById('ash1c_'+0).value=="")
         {
          document.getElementById('ash1c_'+0).value=0;
         }
            document.getElementById('ash1c_'+0).value=parseInt(document.getElementById('ash1c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('ash1c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('ash1c_'+0)!=null)
       { 
       if(document.getElementById('ash1c_'+0).value=="")
         {
          document.getElementById('ash1c_'+0).value=0;
         }
        document.getElementById('ash1c_'+0).value=parseInt(document.getElementById('ash1c_'+0).value)+parseInt(inc);
        
        totalh = parseInt(totalh) + parseInt(document.getElementById('ash1c_'+0).value);
        
        }
        else{}
       }
}
      if(document.getElementById('bha2c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('bha2c_').value)
        {
       
        if(document.getElementById('bha2c_'+0)!=null)
         { 
         if(document.getElementById('bha2c_'+0).value=="")
         {
          document.getElementById('bha2c_'+0).value=0;
         }
            document.getElementById('bha2c_'+0).value=parseInt(document.getElementById('bha2c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('bha2c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('bha2c_'+0)!=null)
       { if(document.getElementById('bha2c_'+0).value=="")
         {
          document.getElementById('bha2c_'+0).value=0;
         }
        document.getElementById('bha2c_'+0).value=parseInt(document.getElementById('bha2c_'+0).value)+parseInt(inc);
        totalh = parseInt(totalh) + parseInt(document.getElementById('bha2c_'+0).value);
        }
        else{}
       }
       
}
 if(document.getElementById('kri3c_').checked==true)
       {      
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('kri3c_').value)
       {
        if(document.getElementById('kri3c_'+0)!=null)
         { if(document.getElementById('kri3c_'+0).value=="")
         {
          document.getElementById('kri3c_'+0).value=0;
         }
            document.getElementById('kri3c_'+0).value=parseInt(document.getElementById('kri3c_'+0).value)+parseInt(dec);
           totalh = parseInt(totalh) + parseInt(document.getElementById('kri3c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('kri3c_'+0)!=null)
       { if(document.getElementById('kri3c_'+0).value=="")
         {
          document.getElementById('kri3c_'+0).value=0;
         }
        document.getElementById('kri3c_'+0).value=parseInt(document.getElementById('kri3c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('kri3c_'+0).value);
        }
        else{}
       }
       
       }
       if(document.getElementById('roh4c_').checked==true)
       {
       
      
     if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('roh4c_').value)
       {
        if(document.getElementById('roh4c_'+0)!=null)
         { if(document.getElementById('roh4c_'+0).value=="")
         {
          document.getElementById('roh4c_'+0).value=0;
         }
            document.getElementById('roh4c_'+0).value=parseInt(document.getElementById('roh4c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('roh4c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('roh4c_'+0)!=null)
       { if(document.getElementById('roh4c_'+0).value=="")
         {
          document.getElementById('roh4c_'+0).value=0;
         }
        document.getElementById('roh4c_'+0).value=parseInt(document.getElementById('roh4c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('roh4c_'+0).value);
        }
        else{}
       }
       }
       if(document.getElementById('mri5c_').checked==true)
       {
       
       
        if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('mri5c_').value)
      {
        if(document.getElementById('mri5c_'+0)!=null)
         { if(document.getElementById('mri5c_'+0).value=="")
         {
          document.getElementById('mri5c_'+0).value=0;
         }
            document.getElementById('mri5c_'+0).value=parseInt(document.getElementById('mri5c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('mri5c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('mri5c_'+0)!=null)
       { if(document.getElementById('mri5c_'+0).value=="")
         {
          document.getElementById('mri5c_'+0).value=0;
         }
        document.getElementById('mri5c_'+0).value=parseInt(document.getElementById('mri5c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('mri5c_'+0).value);
        }
        else{}
       }
       }
       
       if(document.getElementById('ard6c_').checked==true)
       {
       
        if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('ard6c_').value)
      {
        if(document.getElementById('ard6c_'+0)!=null)
         { if(document.getElementById('ard6c_'+0).value=="")
         {
          document.getElementById('ard6c_'+0).value=0;
         }
            document.getElementById('ard6c_'+0).value=parseInt(document.getElementById('ard6c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('ard6c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('ard6c_'+0)!=null)
       { if(document.getElementById('ard6c_'+0).value=="")
         {
          document.getElementById('ard6c_'+0).value=0;
         }
        document.getElementById('ard6c_'+0).value=parseInt(document.getElementById('ard6c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('ard6c_'+0).value);
        }
        else{}
       }
      }
      
      if(document.getElementById('pun7c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('pun7c_').value)
        {
        if(document.getElementById('pun7c_'+0)!=null)
         { if(document.getElementById('pun7c_'+0).value=="")
         {
          document.getElementById('pun7c_'+0).value=0;
         }
            document.getElementById('pun7c_'+0).value=parseInt(document.getElementById('pun7c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('pun7c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('pun7c_'+0)!=null)
       { if(document.getElementById('pun7c_'+0).value=="")
         {
          document.getElementById('pun7c_'+0).value=0;
         }
        document.getElementById('pun7c_'+0).value=parseInt(document.getElementById('pun7c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('pun7c_'+0).value);
        }
        else{}
       }
       }
       
       
     if(document.getElementById('pus8c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('pus8c_').value)
        {
        if(document.getElementById('pus8c_'+0)!=null)
         { if(document.getElementById('pus8c_'+0).value=="")
         {
          document.getElementById('pus8c_'+0).value=0;
         }
            document.getElementById('pus8c_'+0).value=parseInt(document.getElementById('pus8c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('pus8c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('pus8c_'+0)!=null)
       { if(document.getElementById('pus8c_'+0).value=="")
         {
          document.getElementById('pus8c_'+0).value=0;
         }
        document.getElementById('pus8c_'+0).value=parseInt(document.getElementById('pus8c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('pus8c_'+0).value);
        }
        else{}
       }}
     
     
     if(document.getElementById('ash9c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('ash9c_').value)
        {
        if(document.getElementById('ash9c_'+0)!=null)
         { if(document.getElementById('ash9c_'+0).value=="")
         {
          document.getElementById('ash9c_'+0).value=0;
         }
            document.getElementById('ash9c_'+0).value=parseInt(document.getElementById('ash9c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('ash9c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('ash9c_'+0)!=null)
       { if(document.getElementById('ash9c_'+0).value=="")
         {
          document.getElementById('ash9c_'+0).value=0;
         }
        document.getElementById('ash9c_'+0).value=parseInt(document.getElementById('ash9c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('ash9c_'+0).value);
        }
        else{}
       }
      }
       
     if(document.getElementById('mag10c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('mag10c_').value)
       {
        if(document.getElementById('mag10c_'+0)!=null)
         { if(document.getElementById('mag10c_'+0).value=="")
         {
          document.getElementById('mag10c_'+0).value=0;
         }
            document.getElementById('mag10c_'+0).value=parseInt(document.getElementById('mag10c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('mag10c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('mag10c_'+0)!=null)
       { if(document.getElementById('mag10c_'+0).value=="")
         {
          document.getElementById('mag10c_'+0).value=0;
         }
        document.getElementById('mag10c_'+0).value=parseInt(document.getElementById('mag10c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('mag10c_'+0).value);
        }
        else{}
       }
       }
       
      if(document.getElementById('pph11c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('pph11c_').value)
        {
        if(document.getElementById('pph11c_'+0)!=null)
         { if(document.getElementById('pph11c_'+0).value=="")
         {
          document.getElementById('pph11c_'+0).value=0;
         }
            document.getElementById('pph11c_'+0).value=parseInt(document.getElementById('pph11c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('pph11c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('pph11c_'+0)!=null)
       { if(document.getElementById('pph11c_'+0).value=="")
         {
          document.getElementById('pph11c_'+0).value=0;
         }
        document.getElementById('pph11c_'+0).value=parseInt(document.getElementById('pph11c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('pph11c_'+0).value);
        }
        else{}
       }}
       
       
      if(document.getElementById('uph12c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('uph12c_').value)
        {
        if(document.getElementById('uph12c_'+0)!=null)
         { if(document.getElementById('uph12c_'+0).value=="")
         {
          document.getElementById('uph12c_'+0).value=0;
         }
            document.getElementById('uph12c_'+0).value=parseInt(document.getElementById('uph12c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('uph12c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('uph12c_'+0)!=null)
       { if(document.getElementById('uph12c_'+0).value=="")
         {
          document.getElementById('uph12c_'+0).value=0;
         }
        document.getElementById('uph12c_'+0).value=parseInt(document.getElementById('uph12c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('uph12c_'+0).value);
        }
        else{}
       }}
     
       
      if(document.getElementById('has13c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('has13c_').value)
        {
        if(document.getElementById('has13c_'+0)!=null)
         { if(document.getElementById('has13c_'+0).value=="")
         {
          document.getElementById('has13c_'+0).value=0;
         }
            document.getElementById('has13c_'+0).value=parseInt(document.getElementById('has13c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('has13c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('has13c_'+0)!=null)
       { if(document.getElementById('has13c_'+0).value=="")
         {
          document.getElementById('has13c_'+0).value=0;
         }
        document.getElementById('has13c_'+0).value=parseInt(document.getElementById('has13c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('has13c_'+0).value);
        }
        else{}
       }}
      
       
       if(document.getElementById('chi14c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('chi14c_').value)
       {
        if(document.getElementById('chi14c_'+0)!=null)
         { if(document.getElementById('chi14c_'+0).value=="")
         {
          document.getElementById('chi14c_'+0).value=0;
         }
            document.getElementById('chi14c_'+0).value=parseInt(document.getElementById('chi14c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('chi14c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('chi14c_'+0)!=null)
       { if(document.getElementById('chi14c_'+0).value=="")
         {
          document.getElementById('chi14c_'+0).value=0;
         }
        document.getElementById('chi14c_'+0).value=parseInt(document.getElementById('chi14c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('chi14c_'+0).value);
        }
        else{}
       }
      }
       
      if(document.getElementById('swa15c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('swa15c_').value)
        {
        if(document.getElementById('swa15c_'+0)!=null)
         { if(document.getElementById('swa15c_'+0).value=="")
         {
          document.getElementById('swa15c_'+0).value=0;
         }
            document.getElementById('swa15c_'+0).value=parseInt(document.getElementById('swa15c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('swa15c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('swa15c_'+0)!=null)
       { if(document.getElementById('swa15c_'+0).value=="")
         {
          document.getElementById('swa15c_'+0).value=0;
         }
        document.getElementById('swa15c_'+0).value=parseInt(document.getElementById('swa15c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('swa15c_'+0).value);
        }
        else{}
       }
       }
       
       if(document.getElementById('vis16c_').checked==true)
       {
      
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('vis16c_').value)
        {
        if(document.getElementById('vis16c_'+0)!=null)
         { if(document.getElementById('vis16c_'+0).value=="")
         {
          document.getElementById('vis16c_'+0).value=0;
         }
            document.getElementById('vis16c_'+0).value=parseInt(document.getElementById('vis16c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('vis16c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('vis16c_'+0)!=null)
       { if(document.getElementById('vis16c_'+0).value=="")
         {
          document.getElementById('vis16c_'+0).value=0;
         }
        document.getElementById('vis16c_'+0).value=parseInt(document.getElementById('vis16c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('vis16c_'+0).value);
        }
        else{}
       }
       }
       
      if(document.getElementById('anu17c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('anu17c_').value)
       {
        if(document.getElementById('anu17c_'+0)!=null)
         { if(document.getElementById('anu17c_'+0).value=="")
         {
          document.getElementById('anu17c_'+0).value=0;
         }
            document.getElementById('anu17c_'+0).value=parseInt(document.getElementById('anu17c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('anu17c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('anu17c_'+0)!=null)
       { if(document.getElementById('anu17c_'+0).value=="")
         {
          document.getElementById('anu17c_'+0).value=0;
         }
        document.getElementById('anu17c_'+0).value=parseInt(document.getElementById('anu17c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('anu17c_'+0).value);
        }
        else{}
       }
       }
       
       if(document.getElementById('jye18c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('jye18c_').value)
        {
        if(document.getElementById('jye18c_'+0)!=null)
         { if(document.getElementById('jye18c_'+0).value=="")
         {
          document.getElementById('jye18c_'+0).value=0;
         }
            document.getElementById('jye18c_'+0).value=parseInt(document.getElementById('jye18c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('jye18c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('jye18c_'+0)!=null)
       { if(document.getElementById('jye18c_'+0).value=="")
         {
          document.getElementById('jye18c_'+0).value=0;
         }
        document.getElementById('jye18c_'+0).value=parseInt(document.getElementById('jye18c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('jye18c_'+0).value);
        }
        else{}
       }
      }
       
      if(document.getElementById('moo19c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('moo19c_').value)
       {
        if(document.getElementById('moo19c_'+0)!=null)
         { if(document.getElementById('moo19c_'+0).value=="")
         {
          document.getElementById('moo19c_'+0).value=0;
         }
            document.getElementById('moo19c_'+0).value=parseInt(document.getElementById('moo19c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('moo19c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('moo19c_'+0)!=null)
       { if(document.getElementById('moo19c_'+0).value=="")
         {
          document.getElementById('moo19c_'+0).value=0;
         }
        document.getElementById('moo19c_'+0).value=parseInt(document.getElementById('moo19c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('moo19c_'+0).value);
        }
        else{}
       }
       }
      if(document.getElementById('pas20c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('pas20c_').value)
       {
        if(document.getElementById('pas20c_'+0)!=null)
         { if(document.getElementById('pas20c_'+0).value=="")
         {
          document.getElementById('pas20c_'+0).value=0;
         }
            document.getElementById('pas20c_'+0).value=parseInt(document.getElementById('pas20c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('pas20c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('pas20c_'+0)!=null)
       { if(document.getElementById('pas20c_'+0).value=="")
         {
          document.getElementById('pas20c_'+0).value=0;
         }
        document.getElementById('pas20c_'+0).value=parseInt(document.getElementById('pas20c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('pas20c_'+0).value);
        }
        else{}
       }
    }
       
       if(document.getElementById('uas21c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('uas21c_').value)
        {
        if(document.getElementById('uas21c_'+0)!=null)
         { if(document.getElementById('uas21c_'+0).value=="")
         {
          document.getElementById('uas21c_'+0).value=0;
         }
            document.getElementById('uas21c_'+0).value=parseInt(document.getElementById('uas21c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('uas21c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('uas21c_'+0)!=null)
       { if(document.getElementById('uas21c_'+0).value=="")
         {
          document.getElementById('uas21c_'+0).value=0;
         }
        document.getElementById('uas21c_'+0).value=parseInt(document.getElementById('uas21c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('uas21c_'+0).value);
        }
        else
        {
        }
        }
        
       }
       if(document.getElementById('shr22c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('shr22c_').value)
       {
        if(document.getElementById('shr22c_'+0)!=null)
         { if(document.getElementById('shr22c_'+0).value=="")
         {
          document.getElementById('shr22c_'+0).value=0;
         }
            document.getElementById('shr22c_'+0).value=parseInt(document.getElementById('shr22c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('shr22c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('shr22c_'+0)!=null)
       { if(document.getElementById('shr22c_'+0).value=="")
         {
          document.getElementById('shr22c_'+0).value=0;
         }
        document.getElementById('shr22c_'+0).value=parseInt(document.getElementById('shr22c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('shr22c_'+0).value);
        }
        else{}
       }
    }
    if(document.getElementById('dha23c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('dha23c_').value)
       {
        if(document.getElementById('dha23c_'+0)!=null)
         { if(document.getElementById('dha23c_'+0).value=="")
         {
          document.getElementById('dha23c_'+0).value=0;
         }
            document.getElementById('dha23c_'+0).value=parseInt(document.getElementById('dha23c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('dha23c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('dha23c_'+0)!=null)
       { if(document.getElementById('dha23c_'+0).value=="")
         {
          document.getElementById('dha23c_'+0).value=0;
         }
        document.getElementById('dha23c_'+0).value=parseInt(document.getElementById('dha23c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('dha23c_'+0).value);
        }
        else{}
       }
    }
    if(document.getElementById('sha24c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('sha24c_').value)
       {
        if(document.getElementById('sha24c_'+0)!=null)
         { if(document.getElementById('sha24c_'+0).value=="")
         {
          document.getElementById('sha24c_'+0).value=0;
         }
            document.getElementById('sha24c_'+0).value=parseInt(document.getElementById('sha24c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('sha24c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('sha24c_'+0)!=null)
       { if(document.getElementById('sha24c_'+0).value=="")
         {
          document.getElementById('sha24c_'+0).value=0;
         }
        document.getElementById('sha24c_'+0).value=parseInt(document.getElementById('sha24c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('sha24c_'+0).value);
        }
        else{}
       }
    }
    if(document.getElementById('pbh25c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('pbh25c_').value)
       {
        if(document.getElementById('pbh25c_'+0)!=null)
         { if(document.getElementById('pbh25c_'+0).value=="")
         {
          document.getElementById('pbh25c_'+0).value=0;
         }
            document.getElementById('pbh25c_'+0).value=parseInt(document.getElementById('pbh25c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('pbh25c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('pbh25c_'+0)!=null)
       { if(document.getElementById('pbh25c_'+0).value=="")
         {
          document.getElementById('pbh25c_'+0).value=0;
         }
        document.getElementById('pbh25c_'+0).value=parseInt(document.getElementById('pbh25c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('pbh25c_'+0).value);
        }
        else{}
       }
    }
    if(document.getElementById('ubh26c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('ubh26c_').value)
       {
        if(document.getElementById('ubh26c_'+0)!=null)
         { if(document.getElementById('ubh26c_'+0).value=="")
         {
          document.getElementById('ubh26c_'+0).value=0;
         }
            document.getElementById('ubh26c_'+0).value=parseInt(document.getElementById('ubh26c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('ubh26c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('ubh26c_'+0)!=null)
       { if(document.getElementById('ubh26c_'+0).value=="")
         {
          document.getElementById('ubh26c_'+0).value=0;
         }
        document.getElementById('ubh26c_'+0).value=parseInt(document.getElementById('ubh26c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('ubh26c_'+0).value);
        }
        else{}
       }
    }
    if(document.getElementById('rev27c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01!=document.getElementById('rev27c_').value)
       {
        if(document.getElementById('rev27c_'+0)!=null)
         { if(document.getElementById('rev27c_'+0).value=="")
         {
          document.getElementById('rev27c_'+0).value=0;
         }
            document.getElementById('rev27c_'+0).value=parseInt(document.getElementById('rev27c_'+0).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('rev27c_'+0).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('rev27c_'+0)!=null)
       { if(document.getElementById('rev27c_'+0).value=="")
         {
          document.getElementById('rev27c_'+0).value=0;
         }
        document.getElementById('rev27c_'+0).value=parseInt(document.getElementById('rev27c_'+0).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('rev27c_'+0).value);
        }
        else{}
       }
    }
       }
       
      
       
    document.getElementById('total_'+0).value=totalh;
    totalh="0";
     
   }
 
 }



 //////////////////
 document.getElementById('clinetnamediv').style.display = 'block';
 var varga = '';
 var rashi2 = ''
// var res = researchtool_nakshatra.clientinfoall();
// var ds = res.value;

 var pl1 = '';
 var pl2 = '';
 var varga1 = "";
 var cl_na = "";
 var cl_ma = "";
 for (i = 0; i < ds.Tables[0].Rows.length; ++i)
  {
      if (ds.Tables[0].Rows[i]['HOROSCOPE_D01'] != null) {
          cl_na = cl_na + ds.Tables[0].Rows[i]['CLIENT_NAME'] + '<br>';
          cl_ma = cl_ma + ds.Tables[0].Rows[i]['CLIENT_MAIL'] + '<br>';
          rashi2 = rashi2 + ds.Tables[0].Rows[i]['RASHI'] + '<br>';
          pl2 = pl2 + ds.Tables[0].Rows[i]['PLANET'] + '<br>'
      } 
 }

 document.getElementById('cn').innerHTML = cl_na.slice(0, -1);
 document.getElementById('cm').innerHTML = cl_ma.slice(0, -1);

 document.getElementById('ra').innerHTML = rashi2
 document.getElementById('pl').innerHTML = pl2
 
 ////////////////////

 ///////
 var pn = '';
 var rn = '';
 var tn = '';
 var per = '';
 var noc = '';

 for (i = 0; i < ds.Tables[1].Rows.length; ++i) {
     pn = pn + ds.Tables[1].Rows[i]['PLANET'] + '<br>';
     rn = rn + ds.Tables[1].Rows[i]['RASHI'] + '<br>';
     tn = tn + ds.Tables[1].Rows[i]['TOTAL'] + '<br>';
     per = per + ds.Tables[1].Rows[i]['PERCENTAGE'] + '<br>'
     noc = noc + ds.Tables[1].Rows[i]['NO_OF_CHART'] + '<br>'
 }
 document.getElementById('pn').innerHTML = pn;
 document.getElementById('rn').innerHTML = rn;

 document.getElementById('tn').innerHTML = tn
 document.getElementById('per').innerHTML = per
 document.getElementById('noc').innerHTML = noc;
 /////
 return false;
 
 

 
}


    
    
function open_div_button(id) { 

 document.getElementById('clinetnamediv').style.display = 'block';
    var spl1 = id.split("_");
    var spl2 = spl1[1];
    var nakshatra=document.getElementById(spl1[0]+'_').value;
    var planet = "";


    var astrologer = document.getElementById('Hastmail').value;
     var res = researchtool_nakshatra.clientinfo(nakshatra,astrologer);
      var ds=res.value;
       
        //document.getElementById('na').innerHTML=nakshatra.toUpperCase();
       
        var cl_na="";
        var cl_ma="";
        for (i = 0; i < ds.Tables[0].Rows.length; ++i)
         {
        pn = cl_na + ds.Tables[0].Rows[i]['PLANET'] + '<br>';
        cl_na=cl_na+ds.Tables[0].Rows[i]['CLIENT_NAME']+'<br>';
        cl_ma=cl_ma+ds.Tables[0].Rows[i]['CLIENT_MAIL']+'<br>';
        
        }
       
 document.getElementById('cn').innerHTML=cl_na.slice(0,-1);
 document.getElementById('cm').innerHTML=cl_ma.slice(0,-1);
 document.getElementById('ra').innerHTML=nakshatra;
 document.getElementById('pl').innerHTML = pn;   
    
}



function creossdiv() {
    document.getElementById('clinetnamediv').style.display = 'none';
    return false;
}

function accountuser(){

 var astrologer= document.getElementById('hdnuser').value;
 if(astrologer=='astrology' ||astrologer=='ASTROLOGY' || astrologer==""){
// alert('you are admin');
 getopen("login.aspx");

 return false;
 }
 else {
     var grp_cat = 'Natal';
     res = researchtool_nakshatra.searchuser(astrologer, grp_cat);
 
 callback_drp1(res);

   return false
 }
     return false;
}
  function callback_drp1(res) {
    var ds=res.value;
    var edtn = $("clgroup");
    edtn.options.length = 1;
    edtn.options[0] = new Option("Select Group", "0");
    edtn.options[1] = new Option("General", "1");
    if (ds != null && typeof (ds) == "object" && ds.Tables[1].Rows.length > 0) {
        for (var i = 0; i < ds.Tables[1].Rows.length; i++) {
            edtn.options[edtn.options.length] = new Option(ds.Tables[1].Rows[i].CAT_ID, ds.Tables[1].Rows[i].CAT_ID)
            edtn.options.length;
        }
    }
    return false;
}

function grcli() {
    var astrologer = document.getElementById('hdnuser').value;
    if (document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text == 'General') {
        document.getElementById('grcl').className = 'drpo_homenewclb';
        res = researchtool_nakshatra.searchclient(astrologer, document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text, 'Natal');
        callback_drp2(res);
    }
    else {
        document.getElementById('grcl').className = 'drpo_homenewcl';
        return false;
    }
}

function callback_drp2(res) {
    var ds = res.value;
    var edtn1 = $("grcl");
    edtn1.options.length = 1;
    edtn1.options[0] = new Option("Select Client", "0");
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        for (var i = 0; i < ds.Tables[0].Rows.length; i++) {
            edtn1.options[edtn1.options.length] = new Option(ds.Tables[0].Rows[i].CLIENT_MAIL, ds.Tables[0].Rows[i].CLIENT_MAIL)
            edtn1.options.length;
        }

    }
    return false;
}
