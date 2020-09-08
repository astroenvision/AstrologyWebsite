var astrodegree = "";
var exec_data = "";
var next = 0;
var execute = "";
var exec_data1 = "";
var Modify = 0;
var delete_record = 0;
var totalh="0";
var gridtotal="0";
var find_flag;
var browser = navigator.appName;

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
 document.getElementById('astname').innerHTML=document.getElementById('Hastname').value;
 document.getElementById('astid').innerHTML =document.getElementById('Hastmail').value;
 document.getElementById('clientname').innerHTML =document.getElementById('Hclname').value;
document.getElementById('clientid').innerHTML =document.getElementById('Hclmail').value;
 
 

    grid();


    for (var kk = 0; kk <= 7; kk++) 
    
    {
        binddropdown('planets_' + kk);
//        bindrashi("rashi_" + kk);
    
    }
   
    
}





function allchk()
{
if(document.getElementById('totc_').checked==true)
{
  if(find_flag==1)
      {
document.getElementById('d1c_').checked=true;
document.getElementById('d2c_').checked=true;
document.getElementById('d3c_').checked=true;
document.getElementById('d4c_').checked=true;
document.getElementById('d5c_').checked=true;
document.getElementById('d6c_').checked=true;
document.getElementById('d7c_').checked=true;
document.getElementById('d8c_').checked=true;
document.getElementById('d9c_').checked=true;
document.getElementById('d10c_').checked=true;
document.getElementById('d11c_').checked=true;
document.getElementById('d12c_').checked=true;
document.getElementById('d16c_').checked=true;
document.getElementById('d20c_').checked=true;
document.getElementById('d24c_').checked=true;
document.getElementById('d27c_').checked=true;
document.getElementById('d30c_').checked=true;
document.getElementById('d40c_').checked=true;
document.getElementById('d45c_').checked=true;
document.getElementById('d60c_').checked=true;
document.getElementById('klc_').checked=true;
}

if(find_flag==2)
      {
document.getElementById('d1c_').checked=true;
document.getElementById('d2c_').checked=true;
document.getElementById('d3c_').checked=true;
document.getElementById('d9c_').checked=true;
document.getElementById('d12c_').checked=true;
document.getElementById('d30c_').checked=true;
}
if(find_flag==3)
      {
document.getElementById('d1c_').checked=true;
document.getElementById('d2c_').checked=true;
document.getElementById('d3c_').checked=true;
document.getElementById('d7c_').checked=true;
document.getElementById('d9c_').checked=true;
document.getElementById('d12c_').checked=true;
document.getElementById('d30c_').checked=true;
}
if(find_flag==4)
      {
document.getElementById('d1c_').checked=true;
document.getElementById('d2c_').checked=true;
document.getElementById('d3c_').checked=true;
document.getElementById('d7c_').checked=true;
document.getElementById('d9c_').checked=true;
document.getElementById('d10c_').checked=true;
document.getElementById('d12c_').checked=true;
document.getElementById('d16c_').checked=true;
document.getElementById('d30c_').checked=true;
document.getElementById('d60c_').checked=true;
}
if(find_flag==5)
      {
document.getElementById('d1c_').checked=true;
document.getElementById('d2c_').checked=true;
document.getElementById('d3c_').checked=true;
document.getElementById('d4c_').checked=true;
document.getElementById('d7c_').checked=true;
document.getElementById('d9c_').checked=true;
document.getElementById('d10c_').checked=true;
document.getElementById('d12c_').checked=true;
document.getElementById('d16c_').checked=true;
document.getElementById('d20c_').checked=true;
document.getElementById('d24c_').checked=true;
document.getElementById('d27c_').checked=true;
document.getElementById('d30c_').checked=true;
document.getElementById('d40c_').checked=true;
document.getElementById('d45c_').checked=true;
document.getElementById('d60c_').checked=true;
}
}
else
{ if(find_flag==1)
      {
document.getElementById('d1c_').checked=false;
document.getElementById('d2c_').checked=false;
document.getElementById('d3c_').checked=false;
document.getElementById('d4c_').checked=false;
document.getElementById('d5c_').checked=false;
document.getElementById('d6c_').checked=false;
document.getElementById('d7c_').checked=false;
document.getElementById('d8c_').checked=false;
document.getElementById('d9c_').checked=false;
document.getElementById('d10c_').checked=false;
document.getElementById('d11c_').checked=false;
document.getElementById('d12c_').checked=false;
document.getElementById('d16c_').checked=false;
document.getElementById('d20c_').checked=false;
document.getElementById('d24c_').checked=false;
document.getElementById('d27c_').checked=false;
document.getElementById('d30c_').checked=false;
document.getElementById('d40c_').checked=false;
document.getElementById('d45c_').checked=false;
document.getElementById('d60c_').checked=false;
document.getElementById('klc_').checked=false;
}

if(find_flag==2)
      {
document.getElementById('d1c_').checked=false;
document.getElementById('d2c_').checked=false;
document.getElementById('d3c_').checked=false;
document.getElementById('d9c_').checked=false;
document.getElementById('d12c_').checked=false;
document.getElementById('d30c_').checked=false;
}
if(find_flag==3)
      {
document.getElementById('d1c_').checked=false;
document.getElementById('d2c_').checked=false;
document.getElementById('d3c_').checked=false;
document.getElementById('d7c_').checked=false;
document.getElementById('d9c_').checked=false;
document.getElementById('d12c_').checked=false;
document.getElementById('d30c_').checked=false;
}
if(find_flag==4)
      {
document.getElementById('d1c_').checked=false;
document.getElementById('d2c_').checked=false;
document.getElementById('d3c_').checked=false;
document.getElementById('d7c_').checked=false;
document.getElementById('d9c_').checked=false;
document.getElementById('d10c_').checked=false;
document.getElementById('d12c_').checked=false;
document.getElementById('d30c_').checked=false;
document.getElementById('d60c_').checked=false;
}
if(find_flag==5)
      {
document.getElementById('d1c_').checked=false;
document.getElementById('d2c_').checked=false;
document.getElementById('d3c_').checked=false;
document.getElementById('d4c_').checked=false;
document.getElementById('d7c_').checked=false;
document.getElementById('d9c_').checked=false;
document.getElementById('d10c_').checked=false;
document.getElementById('d12c_').checked=false;
document.getElementById('d16c_').checked=false;
document.getElementById('d20c_').checked=false;
document.getElementById('d24c_').checked=false;
document.getElementById('d27c_').checked=false;
document.getElementById('d30c_').checked=false;
document.getElementById('d40c_').checked=false;
document.getElementById('d45c_').checked=false;
document.getElementById('d60c_').checked=false;
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
//buf1 += "<table  id='Divgrid2' runat='server' align='left' Width='1200px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
//    buf1 += "<tr>"
//    buf1 += "<td class='colum-td-head-chart'>" + "Choose Single Or Multiple Combination's From Following Avastha's" + "</td>"
//    buf1 += "</tr>"
//    buf1 += "</table>"
//    var hdsview = "";
//    
//    temp_del1 = aa + buf1.toString();
//     
//    temp_del1 = temp_del1.replace("<TBODY>", "")
//    temp_del1 = temp_del1.replace("</TBODY>", "")
//    //alert(temp_del1)
//    document.getElementById('hdsviewgrid').innerHTML = temp_del1;
    buf1 += "<table  id='Divgrid1' runat='server' align='left' Width='970px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
    buf1 += "<tr>"
    buf1 += "<td class='colum-td-head-chart'>" + "Planets" + "</td>"
    buf1 += "<td id='own' class='colum-td-head-chart'>" + "Own" + "</td>"
    buf1 += "<td id='fri' class='colum-td-head-chart'>" + "Friendly" + "</td>"
    buf1 += "<td id='exal' class='colum-td-head-chart'>" + "Exaltation " + "</td>"
    buf1 += "<td id='enim' class='colum-td-head-chart'>" + "Enimical" + "</td>"
buf1 += "<td id='deb' class='colum-td-head-chart'>" + "Deblitaition" + "</td>"
buf1 += "<td id='neut' class='colum-td-head-chart'>" + "Neutral" + "</td>"
buf1 += "<td id='mootri' class='colum-td-head-chart'>" + "Moola Trikona" + "</td>"

    buf1 += "<td class='colum-td-head-chart'>" + "D1" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d1c_'>"
    buf1 += "</td>"
    
    buf1 += "<td class='colum-td-head-chart'>" + "D2" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d2c_'>"
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D3" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d3c_'>"
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" +"D4" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d4c_'>"
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D5" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d5c_'>"
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D6" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d6c_'>"
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D7" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d7c_'>"
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D8" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d8c_'>"
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D9" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d9c_'>"
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "D10" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d10c_'>"
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "D11" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d11c_'>"
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "D12" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d12c_'>"
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "D16" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d16c_'>"
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "D20" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d20c_'>"
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "D24" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d24c_'>"
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "D27" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d27c_'>"
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "D30" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d30c_'>"
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>"  +"D40" 
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d40c_'>"
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>"+ "D45" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d45c_'>"
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>"+ "D60" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d60c_'>"
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "KL" 
     buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='klc_'>"
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'> "+ "Total" 
    buf1 += "<input type='checkbox' style='width:40px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='totc_' onclick='javascript:allchk();'>"
    buf1 +="</td>"
    
   


    buf1 += "</tr>"

    len = 1;

for (var i = 0; i <= 7; i++) 
{
    buf1 += "<tr>"


    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text' disabled style='width:60px;'class='dropdown_large_corr'; align='left' id='planets_" + i + "'>"
    buf1 += "</td>"


    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='own_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white';  class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='fri_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:20px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='exal_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:20px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='enim_" + i + "' >"
    buf1 += "</td>"


   buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white';  class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='deb_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:20px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='neut_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:20px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='mootri_" + i + "' >"
    buf1 += "</td>"
    
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   style='width:30px;'class='colum-name_id'; align='left'  id='d1_" + i + "' onclick='javascript:open_div_button(id);'>"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d2_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d3_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d4_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d5_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d6_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d7_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left' id='d8_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d9_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text' onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d10_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left' id='d11_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left' id='d12_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d16_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d20_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left' id='d24_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d27_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d30_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text' onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d40_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d45_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d60_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='kl_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  Enabled='false'disabled style='width:30px;'class='dropdown_large_corr'; align='left'  id='total_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<Button  style='width:50px; ' align='left' Text='Search' class='per_btn1_signi'; value='Search' AutoPostBack='true' id=search_" + i + " onClick='javascript:return search(id);' >Search</Button>"
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
     
    document.getElementById('planets_7').style.display='none'
    document.getElementById('own_7').style.display='none';
     document.getElementById('fri_7').style.display='none';
    document.getElementById('exal_7').style.display='none';
    document.getElementById('enim_7').style.display='none';
         document.getElementById('deb_7').style.display='none';
    document.getElementById('neut_7').style.display='none';
    document.getElementById('mootri_7').style.display='none';
    document.getElementById('d1_7').style.display='none';
    document.getElementById('d2_7').style.display='none';
    document.getElementById('d3_7').style.display='none';
    document.getElementById('d4_7').style.display='none';
    document.getElementById('d5_7').style.display='none';
    document.getElementById('d6_7').style.display='none';
    document.getElementById('d7_7').style.display='none';
    document.getElementById('d8_7').style.display='none';
    document.getElementById('d9_7').style.display='none';
    document.getElementById('d10_7').style.display='none';
    document.getElementById('d11_7').style.display='none';
    document.getElementById('d12_7').style.display='none';
    document.getElementById('d16_7').style.display='none';
    document.getElementById('d20_7').style.display='none';
    document.getElementById('d24_7').style.display='none';
    document.getElementById('d27_7').style.display='none';
    document.getElementById('d30_7').style.display='none';
    document.getElementById('d40_7').style.display='none';
    document.getElementById('d45_7').style.display='none';
    document.getElementById('d60_7').style.display='none';
    document.getElementById('kl_7').style.display='none';
     document.getElementById('search_7').style.display='none';


   
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
//    if (res == "planets_7") {
//                document.getElementById(res).value = "RAHU";

//}
//    if (res == "planets_8") {
//                    document.getElementById(res).value = "KETU";
//}
// if (res == "planets_9") {
//                    document.getElementById(res).value = "GULIKA";
//           }

               
    }




    
    
    
//    function bindrashi(res) {

//        var vishu = "";
//        var res1 = chartindex.bindrashi(vishu);
//        var ds = res1.value;

//        document.getElementById(res).options.length = 0;
//        document.getElementById(res).options[0] = new Option("--Select Rashi--", "0");

//        var i;
//        
//        if (ds.Tables[0].Rows.length > 0) {
//            for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
//                document.getElementById(res).options[document.getElementById(res).options.length] = new Option(ds.Tables[0].Rows[i].RASHI);
//                document.getElementById(res).options.length;
//            }
//        }


//    }


 
 
 
 
 
 
 
 
 function search(id)
     {   
      var sv="";  
     if(find_flag==1)
      {
       if(document.getElementById('totc_').checked==true)
     {
     sv="A";
     }
     if(document.getElementById('d1c_').checked==true)
     {
     sv="D01";
     }
     if(document.getElementById('d2c_').checked==true)
     {
     sv="D02";
     }
     
     if(document.getElementById('d3c_').checked==true)
     {
     sv="D03";
     }
     if(document.getElementById('d4c_').checked==true)
     {
     sv="D04";
     }
     if(document.getElementById('d5c_').checked==true)
     {
     sv="D05";
     }
     if(document.getElementById('d6c_').checked==true)
     {
     sv="D06";
     }
     if(document.getElementById('d7c_').checked==true)
     {
     sv="D07";
     }
     if(document.getElementById('d8c_').checked==true)
     {
     sv="D08";
     }
     if(document.getElementById('d9c_').checked==true)
     {
     sv="D09";
     }
     if(document.getElementById('d10c_').checked==true)
     {
     sv="D10";
     }
     if(document.getElementById('d11c_').checked==true)
     {
     sv="D11";
     }
     if(document.getElementById('d12c_').checked==true)
     {
     sv="D12";
     }
     if(document.getElementById('d16c_').checked==true)
     {
     sv="D16";
     }
     if(document.getElementById('d20c_').checked==true)
     {
     sv="D20";
     }
     if(document.getElementById('d24c_').checked==true)
     {
     sv="D24";
     }
     if(document.getElementById('d27c_').checked==true)
     {
     sv="D27";
     }
     if(document.getElementById('d30c_').checked==true)
     {
     sv="D30";
     }
     if(document.getElementById('d40c_').checked==true)
     {
     sv="D40";
     }
     if(document.getElementById('d45c_').checked==true)
     {
     sv="D45";
     }
     if(document.getElementById('d60c_').checked==true)
     {
     sv="D60";
     }
     if(document.getElementById('klc_').checked==true)
     {
     sv="KL";
     }
     }
     
     var split = id.split('_')
     var split1 = split[1];
      
        var planet = document.getElementById("planets_"+split1).value;
       
        var astrolrger=document.getElementById('Hastmail').value;
         var client=document.getElementById('Hclmail').value;
      
        var rashi ="";
          if(document.getElementById('own_'+split1).checked == true){
          
         rashi= document.getElementById('own').innerHTML+','+rashi;
          }
          
          
         
          if(document.getElementById('fri_'+split1).checked == true){
          
           rashi=document.getElementById('fri').innerHTML+','+rashi;
          }
          
          if(document.getElementById('exal_'+split1).checked == true){
          
         rashi=document.getElementById('exal').innerHTML+','+rashi;
          }
          
          
           if(document.getElementById('enim_'+split1).checked == true){
          
         rashi=document.getElementById('enim').innerHTML+','+rashi;
          }
         
         if(document.getElementById('deb_'+split1).checked == true){
          
          rashi= document.getElementById('deb').innerHTML+','+rashi;
          }
          
         if(document.getElementById('neut_'+split1).checked == true){
          
          rashi= document.getElementById('neut').innerHTML+','+rashi;
          }
          if(document.getElementById('mootri_'+split1).checked == true){
          
          rashi= document.getElementById('mootri').innerHTML+','+rashi;
          } 
                 
              var rashi1=rashi.slice(0,-1);
               if(find_flag==1)
                    {
                if(rashi1=="" || client=="" || sv=="")
                 {
                 alert('Pls select Group name or Rashi or Varga');
                 return false;
                 }}
                 else
                 {
                if(rashi1=="" || client=="" )
                 {
                 alert('Pls select Group name or Rashi or Varga');
                 return false;
                 }  
                 }
       var res = chartindex.search(planet,rashi1,astrolrger,client);
      var ds=res.value;
         var inc=1;
      var dec=0;
      document.getElementById('total_'+split1).value="0";
     if(find_flag==1)
      {
      if(document.getElementById('d1c_').checked==true){
      document.getElementById('d1_'+split1).value=0
}
else
{document.getElementById('d1_'+split1).value=""}
   if(document.getElementById('d2c_').checked==true){
document.getElementById('d2_'+split1).value=0
}
else
{document.getElementById('d2_'+split1).value=""}

   if(document.getElementById('d3c_').checked==true){
document.getElementById('d3_'+split1).value=0
}
else
{document.getElementById('d3_'+split1).value=""}

   if(document.getElementById('d4c_').checked==true){
document.getElementById('d4_'+split1).value=0
}
else
{document.getElementById('d4_'+split1).value=""}

   if(document.getElementById('d5c_').checked==true){
document.getElementById('d5_'+split1).value=0
}
else
{document.getElementById('d5_'+split1).value=""}

   if(document.getElementById('d6c_').checked==true){
document.getElementById('d6_'+split1).value=0
}
else
{document.getElementById('d6_'+split1).value=""}

   if(document.getElementById('d7c_').checked==true){
document.getElementById('d7_'+split1).value=0
}
else
{document.getElementById('d7_'+split1).value=""}

   if(document.getElementById('d8c_').checked==true){
document.getElementById('d8_'+split1).value=0
}
else
{document.getElementById('d8_'+split1).value=""}

   if(document.getElementById('d9c_').checked==true){
document.getElementById('d9_'+split1).value=0
}
else
{document.getElementById('d9_'+split1).value=""}

   if(document.getElementById('d10c_').checked==true){
document.getElementById('d10_'+split1).value=0
}
else
{document.getElementById('d10_'+split1).value=""}

   if(document.getElementById('d11c_').checked==true){
document.getElementById('d11_'+split1).value=0
}
else
{document.getElementById('d11_'+split1).value=""}

   if(document.getElementById('d12c_').checked==true){
document.getElementById('d12_'+split1).value=0
}
else
{document.getElementById('d12_'+split1).value=""}

   if(document.getElementById('d16c_').checked==true){
document.getElementById('d16_'+split1).value=0
}
else
{document.getElementById('d16_'+split1).value=""}

   if(document.getElementById('d20c_').checked==true){
document.getElementById('d20_'+split1).value=0
}
else
{document.getElementById('d20_'+split1).value=""}

   if(document.getElementById('d24c_').checked==true){
document.getElementById('d24_'+split1).value=0
}
else
{document.getElementById('d24_'+split1).value=""}

   if(document.getElementById('d27c_').checked==true){
document.getElementById('d27_'+split1).value=0
}
else
{document.getElementById('d27_'+split1).value=""}

   if(document.getElementById('d30c_').checked==true){
document.getElementById('d30_'+split1).value=0
}
else
{document.getElementById('d30_'+split1).value=""}

   if(document.getElementById('d40c_').checked==true){
document.getElementById('d40_'+split1).value=0
}
else
{document.getElementById('d40_'+split1).value=""}

   if(document.getElementById('d45c_').checked==true){
document.getElementById('d45_'+split1).value=0
}
else
{document.getElementById('d45_'+split1).value=""}

   if(document.getElementById('d60c_').checked==true){
document.getElementById('d60_'+split1).value=0
}
else
{document.getElementById('d60_'+split1).value=""}

   if(document.getElementById('klc_').checked==true){
document.getElementById('kl_'+split1).value=0
}
else
{document.getElementById('kl_'+split1).value=""}
}
     if(find_flag==2)
      {
  
document.getElementById('d1_'+split1).value=""

 document.getElementById('d2_'+split1).value=""

 document.getElementById('d3_'+split1).value=""

 document.getElementById('d9_'+split1).value=""

 document.getElementById('d12_'+split1).value=""
document.getElementById('d30_'+split1).value=""
}

     if(find_flag==3)
      {
document.getElementById('d1_'+split1).value=""
document.getElementById('d2_'+split1).value=""

 document.getElementById('d3_'+split1).value=""

 document.getElementById('d7_'+split1).value=""
document.getElementById('d9_'+split1).value=""
document.getElementById('d12_'+split1).value=""

 document.getElementById('d30_'+split1).value=""
}
 
     if(find_flag==4)
      {
document.getElementById('d1_'+split1).value=""
document.getElementById('d2_'+split1).value=""
document.getElementById('d3_'+split1).value=""
document.getElementById('d7_'+split1).value=""
document.getElementById('d9_'+split1).value=""
document.getElementById('d10_'+split1).value=""
document.getElementById('d12_'+split1).value=""
document.getElementById('d16_'+split1).value=""
document.getElementById('d30_'+split1).value=""
document.getElementById('d60_'+split1).value=""

}
     if(find_flag==5)
      {
document.getElementById('d1_'+split1).value=""
document.getElementById('d2_'+split1).value=""
document.getElementById('d3_'+split1).value=""
document.getElementById('d4_'+split1).value=""
document.getElementById('d7_'+split1).value=""
document.getElementById('d9_'+split1).value=""
document.getElementById('d10_'+split1).value=""
document.getElementById('d12_'+split1).value=""
document.getElementById('d16_'+split1).value=""
document.getElementById('d20_'+split1).value=""
document.getElementById('d24_'+split1).value=""
document.getElementById('d27_'+split1).value=""
document.getElementById('d30_'+split1).value=""
document.getElementById('d40_'+split1).value=""
document.getElementById('d45_'+split1).value=""
document.getElementById('d60_'+split1).value=""


}
      
      if (ds.Tables[0].Rows.length > 0) 
       {
     
       for (i = 0; i < ds.Tables[0].Rows.length; ++i)
       
        {
        if(find_flag==1)
        {
       if(document.getElementById('d1c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01==null)
       {
     
        if(document.getElementById('d1_'+split1)!=null)
         {
          if(document.getElementById('d1_'+split1).value=="")
         {
          document.getElementById('d1_'+split1).value=0;
         }
            document.getElementById('d1_'+split1).value=parseInt(document.getElementById('d1_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d1_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d1_'+split1)!=null)
       { 
       if(document.getElementById('d1_'+split1).value=="")
         {
          document.getElementById('d1_'+split1).value=0;
         }
        document.getElementById('d1_'+split1).value=parseInt(document.getElementById('d1_'+split1).value)+parseInt(inc);
        
        totalh = parseInt(totalh) + parseInt(document.getElementById('d1_'+split1).value);
        
        }
        else{}
       }
}
      if(document.getElementById('d2c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D02==null)
        {
       
        if(document.getElementById('d2_'+split1)!=null)
         { 
         if(document.getElementById('d2_'+split1).value=="")
         {
          document.getElementById('d2_'+split1).value=0;
         }
            document.getElementById('d2_'+split1).value=parseInt(document.getElementById('d2_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d2_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d2_'+split1)!=null)
       { if(document.getElementById('d2_'+split1).value=="")
         {
          document.getElementById('d2_'+split1).value=0;
         }
        document.getElementById('d2_'+split1).value=parseInt(document.getElementById('d2_'+split1).value)+parseInt(inc);
        totalh = parseInt(totalh) + parseInt(document.getElementById('d2_'+split1).value);
        }
        else{}
       }
       
}
 if(document.getElementById('d3c_').checked==true)
       {      
       if(ds.Tables[0].Rows[i].HOROSCOPE_D03==null)
       {
        if(document.getElementById('d3_'+split1)!=null)
         { if(document.getElementById('d3_'+split1).value=="")
         {
          document.getElementById('d3_'+split1).value=0;
         }
            document.getElementById('d3_'+split1).value=parseInt(document.getElementById('d3_'+split1).value)+parseInt(dec);
           totalh = parseInt(totalh) + parseInt(document.getElementById('d3_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d3_'+split1)!=null)
       { if(document.getElementById('d3_'+split1).value=="")
         {
          document.getElementById('d3_'+split1).value=0;
         }
        document.getElementById('d3_'+split1).value=parseInt(document.getElementById('d3_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d3_'+split1).value);
        }
        else{}
       }
       
       }
       if(document.getElementById('d4c_').checked==true)
       {
       
      
     if(ds.Tables[0].Rows[i].HOROSCOPE_D04==null)
       {
        if(document.getElementById('d4_'+split1)!=null)
         { if(document.getElementById('d4_'+split1).value=="")
         {
          document.getElementById('d4_'+split1).value=0;
         }
            document.getElementById('d4_'+split1).value=parseInt(document.getElementById('d4_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d4_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d4_'+split1)!=null)
       { if(document.getElementById('d4_'+split1).value=="")
         {
          document.getElementById('d4_'+split1).value=0;
         }
        document.getElementById('d4_'+split1).value=parseInt(document.getElementById('d4_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d4_'+split1).value);
        }
        else{}
       }
       }
       if(document.getElementById('d5c_').checked==true)
       {
       
       
        if(ds.Tables[0].Rows[i].HOROSCOPE_D05==null)
      {
        if(document.getElementById('d5_'+split1)!=null)
         { if(document.getElementById('d5_'+split1).value=="")
         {
          document.getElementById('d5_'+split1).value=0;
         }
            document.getElementById('d5_'+split1).value=parseInt(document.getElementById('d5_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d5_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d5_'+split1)!=null)
       { if(document.getElementById('d5_'+split1).value=="")
         {
          document.getElementById('d5_'+split1).value=0;
         }
        document.getElementById('d5_'+split1).value=parseInt(document.getElementById('d5_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d5_'+split1).value);
        }
        else{}
       }
       }
       
       if(document.getElementById('d6c_').checked==true)
       {
       
        if(ds.Tables[0].Rows[i].HOROSCOPE_D06==null)
      {
        if(document.getElementById('d6_'+split1)!=null)
         { if(document.getElementById('d6_'+split1).value=="")
         {
          document.getElementById('d6_'+split1).value=0;
         }
            document.getElementById('d6_'+split1).value=parseInt(document.getElementById('d6_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d6_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d6_'+split1)!=null)
       { if(document.getElementById('d6_'+split1).value=="")
         {
          document.getElementById('d6_'+split1).value=0;
         }
        document.getElementById('d6_'+split1).value=parseInt(document.getElementById('d6_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d6_'+split1).value);
        }
        else{}
       }
      }
      
      if(document.getElementById('d7c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D07==null)
        {
        if(document.getElementById('d7_'+split1)!=null)
         { if(document.getElementById('d7_'+split1).value=="")
         {
          document.getElementById('d7_'+split1).value=0;
         }
            document.getElementById('d7_'+split1).value=parseInt(document.getElementById('d7_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d7_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d7_'+split1)!=null)
       { if(document.getElementById('d7_'+split1).value=="")
         {
          document.getElementById('d7_'+split1).value=0;
         }
        document.getElementById('d7_'+split1).value=parseInt(document.getElementById('d7_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d7_'+split1).value);
        }
        else{}
       }
       }
       
       
     if(document.getElementById('d8c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D08==null)
        {
        if(document.getElementById('d8_'+split1)!=null)
         { if(document.getElementById('d8_'+split1).value=="")
         {
          document.getElementById('d8_'+split1).value=0;
         }
            document.getElementById('d8_'+split1).value=parseInt(document.getElementById('d8_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d8_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d8_'+split1)!=null)
       { if(document.getElementById('d8_'+split1).value=="")
         {
          document.getElementById('d8_'+split1).value=0;
         }
        document.getElementById('d8_'+split1).value=parseInt(document.getElementById('d8_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d8_'+split1).value);
        }
        else{}
       }}
     
     
     if(document.getElementById('d9c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D09==null)
        {
        if(document.getElementById('d9_'+split1)!=null)
         { if(document.getElementById('d9_'+split1).value=="")
         {
          document.getElementById('d9_'+split1).value=0;
         }
            document.getElementById('d9_'+split1).value=parseInt(document.getElementById('d9_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d9_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d9_'+split1)!=null)
       { if(document.getElementById('d9_'+split1).value=="")
         {
          document.getElementById('d9_'+split1).value=0;
         }
        document.getElementById('d9_'+split1).value=parseInt(document.getElementById('d9_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d9_'+split1).value);
        }
        else{}
       }
      }
       
     if(document.getElementById('d10c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D10==null)
       {
        if(document.getElementById('d10_'+split1)!=null)
         { if(document.getElementById('d10_'+split1).value=="")
         {
          document.getElementById('d10_'+split1).value=0;
         }
            document.getElementById('d10_'+split1).value=parseInt(document.getElementById('d10_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d10_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d10_'+split1)!=null)
       { if(document.getElementById('d10_'+split1).value=="")
         {
          document.getElementById('d10_'+split1).value=0;
         }
        document.getElementById('d10_'+split1).value=parseInt(document.getElementById('d10_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d10_'+split1).value);
        }
        else{}
       }
       }
       
      if(document.getElementById('d11c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D11==null)
        {
        if(document.getElementById('d11_'+split1)!=null)
         { if(document.getElementById('d11_'+split1).value=="")
         {
          document.getElementById('d11_'+split1).value=0;
         }
            document.getElementById('d11_'+split1).value=parseInt(document.getElementById('d11_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d11_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d11_'+split1)!=null)
       { if(document.getElementById('d11_'+split1).value=="")
         {
          document.getElementById('d11_'+split1).value=0;
         }
        document.getElementById('d11_'+split1).value=parseInt(document.getElementById('d11_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d11_'+split1).value);
        }
        else{}
       }}
       
       
      if(document.getElementById('d12c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D12==null)
        {
        if(document.getElementById('d12_'+split1)!=null)
         { if(document.getElementById('d12_'+split1).value=="")
         {
          document.getElementById('d12_'+split1).value=0;
         }
            document.getElementById('d12_'+split1).value=parseInt(document.getElementById('d12_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d12_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d12_'+split1)!=null)
       { if(document.getElementById('d12_'+split1).value=="")
         {
          document.getElementById('d12_'+split1).value=0;
         }
        document.getElementById('d12_'+split1).value=parseInt(document.getElementById('d12_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d12_'+split1).value);
        }
        else{}
       }}
     
       
      if(document.getElementById('d16c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D16==null)
        {
        if(document.getElementById('d16_'+split1)!=null)
         { if(document.getElementById('d16_'+split1).value=="")
         {
          document.getElementById('d16_'+split1).value=0;
         }
            document.getElementById('d16_'+split1).value=parseInt(document.getElementById('d16_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d16_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d16_'+split1)!=null)
       { if(document.getElementById('d16_'+split1).value=="")
         {
          document.getElementById('d16_'+split1).value=0;
         }
        document.getElementById('d16_'+split1).value=parseInt(document.getElementById('d16_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d16_'+split1).value);
        }
        else{}
       }}
      
       
       if(document.getElementById('d20c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D20==null)
       {
        if(document.getElementById('d20_'+split1)!=null)
         { if(document.getElementById('d20_'+split1).value=="")
         {
          document.getElementById('d20_'+split1).value=0;
         }
            document.getElementById('d20_'+split1).value=parseInt(document.getElementById('d20_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d20_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d20_'+split1)!=null)
       { if(document.getElementById('d20_'+split1).value=="")
         {
          document.getElementById('d20_'+split1).value=0;
         }
        document.getElementById('d20_'+split1).value=parseInt(document.getElementById('d20_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d20_'+split1).value);
        }
        else{}
       }
      }
       
      if(document.getElementById('d24c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D24==null)
        {
        if(document.getElementById('d24_'+split1)!=null)
         { if(document.getElementById('d24_'+split1).value=="")
         {
          document.getElementById('d24_'+split1).value=0;
         }
            document.getElementById('d24_'+split1).value=parseInt(document.getElementById('d24_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d24_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d24_'+split1)!=null)
       { if(document.getElementById('d24_'+split1).value=="")
         {
          document.getElementById('d24_'+split1).value=0;
         }
        document.getElementById('d24_'+split1).value=parseInt(document.getElementById('d24_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d24_'+split1).value);
        }
        else{}
       }
       }
       
       if(document.getElementById('d27c_').checked==true)
       {
      
       if(ds.Tables[0].Rows[i].HOROSCOPE_D27==null)
        {
        if(document.getElementById('d27_'+split1)!=null)
         { if(document.getElementById('d27_'+split1).value=="")
         {
          document.getElementById('d27_'+split1).value=0;
         }
            document.getElementById('d27_'+split1).value=parseInt(document.getElementById('d27_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d27_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d27_'+split1)!=null)
       { if(document.getElementById('d27_'+split1).value=="")
         {
          document.getElementById('d27_'+split1).value=0;
         }
        document.getElementById('d27_'+split1).value=parseInt(document.getElementById('d27_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d27_'+split1).value);
        }
        else{}
       }
       }
       
      if(document.getElementById('d30c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D30==null)
       {
        if(document.getElementById('d30_'+split1)!=null)
         { if(document.getElementById('d30_'+split1).value=="")
         {
          document.getElementById('d30_'+split1).value=0;
         }
            document.getElementById('d30_'+split1).value=parseInt(document.getElementById('d30_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d30_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d30_'+split1)!=null)
       { if(document.getElementById('d30_'+split1).value=="")
         {
          document.getElementById('d30_'+split1).value=0;
         }
        document.getElementById('d30_'+split1).value=parseInt(document.getElementById('d30_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d30_'+split1).value);
        }
        else{}
       }
       }
       
       if(document.getElementById('d40c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D40==null)
        {
        if(document.getElementById('d40_'+split1)!=null)
         { if(document.getElementById('d40_'+split1).value=="")
         {
          document.getElementById('d40_'+split1).value=0;
         }
            document.getElementById('d40_'+split1).value=parseInt(document.getElementById('d40_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d40_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d40_'+split1)!=null)
       { if(document.getElementById('d40_'+split1).value=="")
         {
          document.getElementById('d40_'+split1).value=0;
         }
        document.getElementById('d40_'+split1).value=parseInt(document.getElementById('d40_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d40_'+split1).value);
        }
        else{}
       }
      }
       
      if(document.getElementById('d45c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D45==null)
       {
        if(document.getElementById('d45_'+split1)!=null)
         { if(document.getElementById('d45_'+split1).value=="")
         {
          document.getElementById('d45_'+split1).value=0;
         }
            document.getElementById('d45_'+split1).value=parseInt(document.getElementById('d45_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d45_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d45_'+split1)!=null)
       { if(document.getElementById('d45_'+split1).value=="")
         {
          document.getElementById('d45_'+split1).value=0;
         }
        document.getElementById('d45_'+split1).value=parseInt(document.getElementById('d45_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d45_'+split1).value);
        }
        else{}
       }
       }
      if(document.getElementById('d60c_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_D60==null)
       {
        if(document.getElementById('d60_'+split1)!=null)
         { if(document.getElementById('d60_'+split1).value=="")
         {
          document.getElementById('d60_'+split1).value=0;
         }
            document.getElementById('d60_'+split1).value=parseInt(document.getElementById('d60_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d60_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d60_'+split1)!=null)
       { if(document.getElementById('d60_'+split1).value=="")
         {
          document.getElementById('d60_'+split1).value=0;
         }
        document.getElementById('d60_'+split1).value=parseInt(document.getElementById('d60_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d60_'+split1).value);
        }
        else{}
       }
    }
       
       if(document.getElementById('klc_').checked==true)
       {
       if(ds.Tables[0].Rows[i].HOROSCOPE_DKL==null)
        {
        if(document.getElementById('kl_'+split1)!=null)
         { if(document.getElementById('kl_'+split1).value=="")
         {
          document.getElementById('kl_'+split1).value=0;
         }
            document.getElementById('kl_'+split1).value=parseInt(document.getElementById('kl_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('kl_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('kl_'+split1)!=null)
       { if(document.getElementById('kl_'+split1).value=="")
         {
          document.getElementById('kl_'+split1).value=0;
         }
        document.getElementById('kl_'+split1).value=parseInt(document.getElementById('kl_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('kl_'+split1).value);
        }
        else
        {
        }}
        
       }}
       
       else
       
       {
        
       if(ds.Tables[0].Rows[i].HOROSCOPE_D01==null)
       {
     
        if(document.getElementById('d1_'+split1)!=null)
         {
          if(document.getElementById('d1_'+split1).value=="")
         {
          document.getElementById('d1_'+split1).value=0;
         }
            document.getElementById('d1_'+split1).value=parseInt(document.getElementById('d1_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d1_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d1_'+split1)!=null)
       { 
       if(document.getElementById('d1_'+split1).value=="")
         {
          document.getElementById('d1_'+split1).value=0;
         }
        document.getElementById('d1_'+split1).value=parseInt(document.getElementById('d1_'+split1).value)+parseInt(inc);
        
        totalh = parseInt(totalh) + parseInt(document.getElementById('d1_'+split1).value);
        
        }
        else{}
       }

 
       if(ds.Tables[0].Rows[i].HOROSCOPE_D02==null)
        {
       
        if(document.getElementById('d2_'+split1)!=null)
         { 
         if(document.getElementById('d2_'+split1).value=="")
         {
          document.getElementById('d2_'+split1).value=0;
         }
            document.getElementById('d2_'+split1).value=parseInt(document.getElementById('d2_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d2_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d2_'+split1)!=null)
       { if(document.getElementById('d2_'+split1).value=="")
         {
          document.getElementById('d2_'+split1).value=0;
         }
        document.getElementById('d2_'+split1).value=parseInt(document.getElementById('d2_'+split1).value)+parseInt(inc);
        totalh = parseInt(totalh) + parseInt(document.getElementById('d2_'+split1).value);
        }
        else{}
       }
       
     
       if(ds.Tables[0].Rows[i].HOROSCOPE_D03==null)
       {
        if(document.getElementById('d3_'+split1)!=null)
         { if(document.getElementById('d3_'+split1).value=="")
         {
          document.getElementById('d3_'+split1).value=0;
         }
            document.getElementById('d3_'+split1).value=parseInt(document.getElementById('d3_'+split1).value)+parseInt(dec);
           totalh = parseInt(totalh) + parseInt(document.getElementById('d3_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d3_'+split1)!=null)
       { if(document.getElementById('d3_'+split1).value=="")
         {
          document.getElementById('d3_'+split1).value=0;
         }
        document.getElementById('d3_'+split1).value=parseInt(document.getElementById('d3_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d3_'+split1).value);
        }
        else{}
       }
       
       
       
      
     if(ds.Tables[0].Rows[i].HOROSCOPE_D04==null)
       {
        if(document.getElementById('d4_'+split1)!=null)
         { if(document.getElementById('d4_'+split1).value=="")
         {
          document.getElementById('d4_'+split1).value=0;
         }
            document.getElementById('d4_'+split1).value=parseInt(document.getElementById('d4_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d4_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d4_'+split1)!=null)
       { if(document.getElementById('d4_'+split1).value=="")
         {
          document.getElementById('d4_'+split1).value=0;
         }
        document.getElementById('d4_'+split1).value=parseInt(document.getElementById('d4_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d4_'+split1).value);
        }
        else{}
       }
      
       
       
        if(ds.Tables[0].Rows[i].HOROSCOPE_D05==null)
      {
        if(document.getElementById('d5_'+split1)!=null)
         { if(document.getElementById('d5_'+split1).value=="")
         {
          document.getElementById('d5_'+split1).value=0;
         }
            document.getElementById('d5_'+split1).value=parseInt(document.getElementById('d5_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d5_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d5_'+split1)!=null)
       { if(document.getElementById('d5_'+split1).value=="")
         {
          document.getElementById('d5_'+split1).value=0;
         }
        document.getElementById('d5_'+split1).value=parseInt(document.getElementById('d5_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d5_'+split1).value);
        }
        else{}
       }
     
       
        if(ds.Tables[0].Rows[i].HOROSCOPE_D06==null)
      {
        if(document.getElementById('d6_'+split1)!=null)
         { if(document.getElementById('d6_'+split1).value=="")
         {
          document.getElementById('d6_'+split1).value=0;
         }
            document.getElementById('d6_'+split1).value=parseInt(document.getElementById('d6_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d6_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d6_'+split1)!=null)
       { if(document.getElementById('d6_'+split1).value=="")
         {
          document.getElementById('d6_'+split1).value=0;
         }
        document.getElementById('d6_'+split1).value=parseInt(document.getElementById('d6_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d6_'+split1).value);
        }
        else{}
       }
    
       if(ds.Tables[0].Rows[i].HOROSCOPE_D07==null)
        {
        if(document.getElementById('d7_'+split1)!=null)
         { if(document.getElementById('d7_'+split1).value=="")
         {
          document.getElementById('d7_'+split1).value=0;
         }
            document.getElementById('d7_'+split1).value=parseInt(document.getElementById('d7_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d7_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d7_'+split1)!=null)
       { if(document.getElementById('d7_'+split1).value=="")
         {
          document.getElementById('d7_'+split1).value=0;
         }
        document.getElementById('d7_'+split1).value=parseInt(document.getElementById('d7_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d7_'+split1).value);
        }
        else{}
       }
       
       if(ds.Tables[0].Rows[i].HOROSCOPE_D08==null)
        {
        if(document.getElementById('d8_'+split1)!=null)
         { if(document.getElementById('d8_'+split1).value=="")
         {
          document.getElementById('d8_'+split1).value=0;
         }
            document.getElementById('d8_'+split1).value=parseInt(document.getElementById('d8_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d8_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d8_'+split1)!=null)
       { if(document.getElementById('d8_'+split1).value=="")
         {
          document.getElementById('d8_'+split1).value=0;
         }
        document.getElementById('d8_'+split1).value=parseInt(document.getElementById('d8_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d8_'+split1).value);
        }
        else{}
       }
       
       if(ds.Tables[0].Rows[i].HOROSCOPE_D09==null)
        {
        if(document.getElementById('d9_'+split1)!=null)
         { if(document.getElementById('d9_'+split1).value=="")
         {
          document.getElementById('d9_'+split1).value=0;
         }
            document.getElementById('d9_'+split1).value=parseInt(document.getElementById('d9_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d9_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d9_'+split1)!=null)
       { if(document.getElementById('d9_'+split1).value=="")
         {
          document.getElementById('d9_'+split1).value=0;
         }
        document.getElementById('d9_'+split1).value=parseInt(document.getElementById('d9_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d9_'+split1).value);
        }
        else{}
       }
     
       if(ds.Tables[0].Rows[i].HOROSCOPE_D10==null)
       {
        if(document.getElementById('d10_'+split1)!=null)
         { if(document.getElementById('d10_'+split1).value=="")
         {
          document.getElementById('d10_'+split1).value=0;
         }
            document.getElementById('d10_'+split1).value=parseInt(document.getElementById('d10_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d10_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d10_'+split1)!=null)
       { if(document.getElementById('d10_'+split1).value=="")
         {
          document.getElementById('d10_'+split1).value=0;
         }
        document.getElementById('d10_'+split1).value=parseInt(document.getElementById('d10_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d10_'+split1).value);
        }
        else{}
       }
       
       if(ds.Tables[0].Rows[i].HOROSCOPE_D11==null)
        {
        if(document.getElementById('d11_'+split1)!=null)
         { if(document.getElementById('d11_'+split1).value=="")
         {
          document.getElementById('d11_'+split1).value=0;
         }
            document.getElementById('d11_'+split1).value=parseInt(document.getElementById('d11_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d11_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d11_'+split1)!=null)
       { if(document.getElementById('d11_'+split1).value=="")
         {
          document.getElementById('d11_'+split1).value=0;
         }
        document.getElementById('d11_'+split1).value=parseInt(document.getElementById('d11_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d11_'+split1).value);
        }
        else{}
       }
       if(ds.Tables[0].Rows[i].HOROSCOPE_D12==null)
        {
        if(document.getElementById('d12_'+split1)!=null)
         { if(document.getElementById('d12_'+split1).value=="")
         {
          document.getElementById('d12_'+split1).value=0;
         }
            document.getElementById('d12_'+split1).value=parseInt(document.getElementById('d12_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d12_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d12_'+split1)!=null)
       { if(document.getElementById('d12_'+split1).value=="")
         {
          document.getElementById('d12_'+split1).value=0;
         }
        document.getElementById('d12_'+split1).value=parseInt(document.getElementById('d12_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d12_'+split1).value);
        }
        else{}
       }
       if(ds.Tables[0].Rows[i].HOROSCOPE_D16==null)
        {
        if(document.getElementById('d16_'+split1)!=null)
         { if(document.getElementById('d16_'+split1).value=="")
         {
          document.getElementById('d16_'+split1).value=0;
         }
            document.getElementById('d16_'+split1).value=parseInt(document.getElementById('d16_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d16_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d16_'+split1)!=null)
       { if(document.getElementById('d16_'+split1).value=="")
         {
          document.getElementById('d16_'+split1).value=0;
         }
        document.getElementById('d16_'+split1).value=parseInt(document.getElementById('d16_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d16_'+split1).value);
        }
        else{}
       }
       if(ds.Tables[0].Rows[i].HOROSCOPE_D20==null)
       {
        if(document.getElementById('d20_'+split1)!=null)
         { if(document.getElementById('d20_'+split1).value=="")
         {
          document.getElementById('d20_'+split1).value=0;
         }
            document.getElementById('d20_'+split1).value=parseInt(document.getElementById('d20_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d20_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d20_'+split1)!=null)
       { if(document.getElementById('d20_'+split1).value=="")
         {
          document.getElementById('d20_'+split1).value=0;
         }
        document.getElementById('d20_'+split1).value=parseInt(document.getElementById('d20_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d20_'+split1).value);
        }
        else{}
       }
      
       if(ds.Tables[0].Rows[i].HOROSCOPE_D24==null)
        {
        if(document.getElementById('d24_'+split1)!=null)
         { if(document.getElementById('d24_'+split1).value=="")
         {
          document.getElementById('d24_'+split1).value=0;
         }
            document.getElementById('d24_'+split1).value=parseInt(document.getElementById('d24_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d24_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d24_'+split1)!=null)
       { if(document.getElementById('d24_'+split1).value=="")
         {
          document.getElementById('d24_'+split1).value=0;
         }
        document.getElementById('d24_'+split1).value=parseInt(document.getElementById('d24_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d24_'+split1).value);
        }
        else{}
       }
       
      
       if(ds.Tables[0].Rows[i].HOROSCOPE_D27==null)
        {
        if(document.getElementById('d27_'+split1)!=null)
         { if(document.getElementById('d27_'+split1).value=="")
         {
          document.getElementById('d27_'+split1).value=0;
         }
            document.getElementById('d27_'+split1).value=parseInt(document.getElementById('d27_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d27_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d27_'+split1)!=null)
       { if(document.getElementById('d27_'+split1).value=="")
         {
          document.getElementById('d27_'+split1).value=0;
         }
        document.getElementById('d27_'+split1).value=parseInt(document.getElementById('d27_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d27_'+split1).value);
        }
        else{}
       }
      
       if(ds.Tables[0].Rows[i].HOROSCOPE_D30==null)
       {
        if(document.getElementById('d30_'+split1)!=null)
         { if(document.getElementById('d30_'+split1).value=="")
         {
          document.getElementById('d30_'+split1).value=0;
         }
            document.getElementById('d30_'+split1).value=parseInt(document.getElementById('d30_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d30_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d30_'+split1)!=null)
       { if(document.getElementById('d30_'+split1).value=="")
         {
          document.getElementById('d30_'+split1).value=0;
         }
        document.getElementById('d30_'+split1).value=parseInt(document.getElementById('d30_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d30_'+split1).value);
        }
        else{}
       }
       
       if(ds.Tables[0].Rows[i].HOROSCOPE_D40==null)
        {
        if(document.getElementById('d40_'+split1)!=null)
         { if(document.getElementById('d40_'+split1).value=="")
         {
          document.getElementById('d40_'+split1).value=0;
         }
            document.getElementById('d40_'+split1).value=parseInt(document.getElementById('d40_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d40_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d40_'+split1)!=null)
       { if(document.getElementById('d40_'+split1).value=="")
         {
          document.getElementById('d40_'+split1).value=0;
         }
        document.getElementById('d40_'+split1).value=parseInt(document.getElementById('d40_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d40_'+split1).value);
        }
        else{}
       }
     
       if(ds.Tables[0].Rows[i].HOROSCOPE_D45==null)
       {
        if(document.getElementById('d45_'+split1)!=null)
         { if(document.getElementById('d45_'+split1).value=="")
         {
          document.getElementById('d45_'+split1).value=0;
         }
            document.getElementById('d45_'+split1).value=parseInt(document.getElementById('d45_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d45_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d45_'+split1)!=null)
       { if(document.getElementById('d45_'+split1).value=="")
         {
          document.getElementById('d45_'+split1).value=0;
         }
        document.getElementById('d45_'+split1).value=parseInt(document.getElementById('d45_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d45_'+split1).value);
        }
        else{}
       }
      
       if(ds.Tables[0].Rows[i].HOROSCOPE_D60==null)
       {
        if(document.getElementById('d60_'+split1)!=null)
         { if(document.getElementById('d60_'+split1).value=="")
         {
          document.getElementById('d60_'+split1).value=0;
         }
            document.getElementById('d60_'+split1).value=parseInt(document.getElementById('d60_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('d60_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('d60_'+split1)!=null)
       { if(document.getElementById('d60_'+split1).value=="")
         {
          document.getElementById('d60_'+split1).value=0;
         }
        document.getElementById('d60_'+split1).value=parseInt(document.getElementById('d60_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('d60_'+split1).value);
        }
        else{}
       }
   
       if(ds.Tables[0].Rows[i].HOROSCOPE_DKL==null)
        {
        if(document.getElementById('kl_'+split1)!=null)
         { if(document.getElementById('kl_'+split1).value=="")
         {
          document.getElementById('kl_'+split1).value=0;
         }
            document.getElementById('kl_'+split1).value=parseInt(document.getElementById('kl_'+split1).value)+parseInt(dec);
            totalh = parseInt(totalh) + parseInt(document.getElementById('kl_'+split1).value);
        }
      
       else
       {

       }
       }
       else
       {
       if(document.getElementById('kl_'+split1)!=null)
       { if(document.getElementById('kl_'+split1).value=="")
         {
          document.getElementById('kl_'+split1).value=0;
         }
        document.getElementById('kl_'+split1).value=parseInt(document.getElementById('kl_'+split1).value)+parseInt(inc);
         totalh = parseInt(totalh) + parseInt(document.getElementById('kl_'+split1).value);
        }
        else
        {
        }}
        
       
       }
       
    document.getElementById('total_'+split1).value=totalh;
    totalh="0";
     
   }
 
 }
 
 



 for(var i=0;i<7;i++)
{
 if(document.getElementById('total_'+i).value==null || document.getElementById('total_'+i).value=="")
   {
//      document.getElementById('total_'+i).value='0';
   
   }
   else
   {
   
     gridtotal= parseInt(gridtotal)+ parseInt(document.getElementById('total_'+i).value); ;
   }
   
   
   
   
   
}
document.getElementById('total_'+7).value=gridtotal;
 gridtotal="0";
 return false;
 

 
}





function data1(){

 
  find_flag=2;
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
   

    if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:530px;display:block") <= 0) {
        aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
    }
 buf1 ="";
// buf1 += "<table  id='Divgrid2' runat='server' align='left' Width='1200px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
//    buf1 += "<tr>"
//    buf1 += "<td class='colum-td-head-chart'>" + "Choose Single Or Multiple Combination's From Following Avastha's" + "</td>"
//    buf1 += "</tr>"
//    buf1 += "</table>"
//    var hdsview = "";
//    
//    temp_del1 = aa + buf1.toString();
//     
//    temp_del1 = temp_del1.replace("<TBODY>", "")
//    temp_del1 = temp_del1.replace("</TBODY>", "")
//    //alert(temp_del1)
//    document.getElementById('hdsviewgrid').innerHTML = temp_del1;
    buf1 += "<table  id='Divgrid1' runat='server' align='left' Width='300px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
    buf1 += "<tr>"
    buf1 += "<td class='colum-td-head-chart'>" + "Planets" + "</td>"
    buf1 += "<td id='own' class='colum-td-head-chart'>" + "Own" + "</td>"
    buf1 += "<td id='fri' class='colum-td-head-chart'>" + "Friendly" + "</td>"
    buf1 += "<td id='exal' class='colum-td-head-chart'>" + "Exaltation" + "</td>"
    buf1 += "<td id='enim' class='colum-td-head-chart'>" + "Enimical" + "</td>"
    buf1 += "<td id='deb' class='colum-td-head-chart'>" + "Deblitaition" + "</td>"
buf1 += "<td id='neut' class='colum-td-head-chart'>" + "Neutral" + "</td>"
buf1 += "<td id='mootri' class='colum-td-head-chart'>" + "Moola Trikona" + "</td>"

    buf1 += "<td class='colum-td-head-chart'>" + "D1" 
   
    buf1 +="</td>"
    
    buf1 += "<td class='colum-td-head-chart'>" + "D2" 
   
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D3" 
   
    buf1 +="</td>"

    buf1 += "<td class='colum-td-head-chart'>" + "D9" 
   
    buf1 +="</td>"

    buf1 += "<td class='colum-td-head-chart'>" + "D12" 
   
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D30" 
   
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "Total" 
   
    buf1 +="</td>"
    
    
   


    buf1 += "</tr>"

    len = 1;

for (var i = 0; i <= 7; i++) 
{
    buf1 += "<tr>"


    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text' disabled style='width:60px;'class='dropdown_large_corr'; align='left' id='planets_" + i + "'>"
    buf1 += "</td>"



    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:30px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='own_" + i + "' >"
    buf1 += "</td>"


    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:30px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='fri_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:30px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='exal_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:30px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='enim_" + i + "' >"
    buf1 += "</td>"

 buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white';  class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='deb_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:20px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='neut_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:20px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='mootri_" + i + "' >"
    buf1 += "</td>"
    
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  Enabled='false'disabled style='width:30px;'class='colum-name_id'; align='left'  id='d1_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left'  id='d2_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left'  id='d3_" + i + "' >"
    buf1 += "</td>"


    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left'  id='d9_" + i + "' >"
    buf1 += "</td>"





    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left' id='d12_" + i + "' >"
    buf1 += "</td>"


    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left'  id='d30_" + i + "' >"
    buf1 += "</td>"



    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  Enabled='false'disabled style='width:40px;'class='dropdown_large_corr'; align='left'  id='total_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<Button  style='width:50px; ' align='left' Text='Search' class='per_btn1_signi'; value='Search' AutoPostBack='true' id=search_" + i + " onClick='javascript:return search(id);' >Search</Button>"
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
         document.getElementById('planets_7').style.display='none'
    document.getElementById('own_7').style.display='none';
     document.getElementById('fri_7').style.display='none';
    document.getElementById('exal_7').style.display='none';
    document.getElementById('enim_7').style.display='none';
         document.getElementById('deb_7').style.display='none';
    document.getElementById('neut_7').style.display='none';
    document.getElementById('mootri_7').style.display='none';
    document.getElementById('d1_7').style.display='none';
    document.getElementById('d2_7').style.display='none';
    document.getElementById('d3_7').style.display='none';
    
    document.getElementById('d9_7').style.display='none';
     document.getElementById('d12_7').style.display='none';
   
    document.getElementById('d30_7').style.display='none';
     document.getElementById('search_7').style.display='none';
    
    
    
    
    for (var kk = 0; kk <= 6; kk++)
  {
binddropdown('planets_' + kk);
}

  // return false;
    }
    
   



function gata2(){
  find_flag=3;
 
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
   

    if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:530px;display:block") <= 0) {
        aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
    }
 buf1 ="";
// buf1 += "<table  id='Divgrid2' runat='server' align='left' Width='1200px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
//    buf1 += "<tr>"
//    buf1 += "<td class='colum-td-head-chart'>" + "Choose Single Or Multiple Combination's From Following Avastha's" + "</td>"
//    buf1 += "</tr>"
//    buf1 += "</table>"
//    var hdsview = "";
//    
//    temp_del1 = aa + buf1.toString();
//     
//    temp_del1 = temp_del1.replace("<TBODY>", "")
//    temp_del1 = temp_del1.replace("</TBODY>", "")
//    //alert(temp_del1)
//    document.getElementById('hdsviewgrid').innerHTML = temp_del1;
    buf1 += "<table  id='Divgrid1' runat='server' align='left' Width='300px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
    buf1 += "<tr>"
    buf1 += "<td class='colum-td-head-chart'>" + "Planets" + "</td>"
        buf1 += "<td id='own' class='colum-td-head-chart'>" + "Own" + "</td>"
    buf1 += "<td id='fri' class='colum-td-head-chart'>" + "Friendly" + "</td>"
    buf1 += "<td id='exal' class='colum-td-head-chart'>" + "Exaltation" + "</td>"
    buf1 += "<td id='enim' class='colum-td-head-chart'>" + "Enimical" + "</td>"
    buf1 += "<td id='deb' class='colum-td-head-chart'>" + "Deblitaition" + "</td>"
buf1 += "<td id='neut' class='colum-td-head-chart'>" + "Neutral" + "</td>"
buf1 += "<td id='mootri' class='colum-td-head-chart'>" + "Moola Trikona" + "</td>"
     buf1 += "<td class='colum-td-head-chart'>" + "D1" 
    
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D2" 
    
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D3" 
    
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D7" 
    
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D9" 
    
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D12" 
    
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D30" 
    
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "Total" 
    
    buf1 +="</td>"
    
   
    
   


    buf1 += "</tr>"

    len = 1;

for (var i = 0; i <= 7; i++) 
{
    buf1 += "<tr>"


    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text' disabled style='width:60px;'class='dropdown_large_corr'; align='left' id='planets_" + i + "'>"
    buf1 += "</td>"



    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:30px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='own_" + i + "' >"
    buf1 += "</td>"


    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:30px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='fri_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:30px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='exal_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:30px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='enim_" + i + "' >"
    buf1 += "</td>"


 buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white';  class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='deb_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:20px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='neut_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:20px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='mootri_" + i + "' >"
    buf1 += "</td>"
    
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left'  id='d1_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left'  id='d2_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left'  id='d3_" + i + "' >"
    buf1 += "</td>"


    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left'  id='d7_" + i + "' >"
    buf1 += "</td>"


    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left'  id='d9_" + i + "' >"
    buf1 += "</td>"


    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left' id='d12_" + i + "' >"
    buf1 += "</td>"


    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left'  id='d30_" + i + "' >"
    buf1 += "</td>"


    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  Enabled='false'disabled style='width:40px;'class='dropdown_large_corr'; align='left'  id='total_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<Button  style='width:50px; ' align='left' Text='Search' class='per_btn1_signi'; value='Search' AutoPostBack='true' id=search_" + i + " onClick='javascript:return search(id);' >Search</Button>"
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
   
    document.getElementById('planets_7').style.display='none'
    document.getElementById('own_7').style.display='none';
     document.getElementById('fri_7').style.display='none';
    document.getElementById('exal_7').style.display='none';
    document.getElementById('enim_7').style.display='none';
         document.getElementById('deb_7').style.display='none';
    document.getElementById('neut_7').style.display='none';
    document.getElementById('mootri_7').style.display='none';
    document.getElementById('d1_7').style.display='none';
    document.getElementById('d2_7').style.display='none';
    document.getElementById('d3_7').style.display='none';
    document.getElementById('d7_7').style.display='none';
    
    document.getElementById('d9_7').style.display='none';
     document.getElementById('d12_7').style.display='none';
   
    document.getElementById('d30_7').style.display='none';
     document.getElementById('search_7').style.display='none';

   
      for (var kk = 0; kk <= 6; kk++)
  {
binddropdown('planets_' + kk);
}
   

   
}


function data3(){

find_flag=4;
 
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
   

    if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:530px;display:block") <= 0) {
        aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
    }
 buf1 ="";
// buf1 += "<table  id='Divgrid2' runat='server' align='left' Width='1200px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
//    buf1 += "<tr>"
//    buf1 += "<td class='colum-td-head-chart'>" + "Choose Single Or Multiple Combination's From Following Avastha's" + "</td>"
//    buf1 += "</tr>"
//    buf1 += "</table>"
//    var hdsview = "";
//    
//    temp_del1 = aa + buf1.toString();
//     
//    temp_del1 = temp_del1.replace("<TBODY>", "")
//    temp_del1 = temp_del1.replace("</TBODY>", "")
//    //alert(temp_del1)
//    document.getElementById('hdsviewgrid').innerHTML = temp_del1;
    buf1 += "<table  id='Divgrid1' runat='server' align='left' Width='300px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
    buf1 += "<tr>"
    buf1 += "<td class='colum-td-head-chart'>" + "Planets" + "</td>"
       buf1 += "<td id='own' class='colum-td-head-chart'>" + "Own" + "</td>"
    buf1 += "<td id='fri' class='colum-td-head-chart'>" + "Friendly" + "</td>"
    buf1 += "<td id='exal' class='colum-td-head-chart'>" + "Exaltation" + "</td>"
    buf1 += "<td id='enim' class='colum-td-head-chart'>" + "Enimical" + "</td>"
    buf1 += "<td id='deb' class='colum-td-head-chart'>" + "Deblitaition" + "</td>"
buf1 += "<td id='neut' class='colum-td-head-chart'>" + "Neutral" + "</td>"
buf1 += "<td id='mootri' class='colum-td-head-chart'>" + "Moola Trikona" + "</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "D1" 
    
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D2" 
    
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D3" 
    
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D7" 
    
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D9" 
    
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D10" 
    
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D12" 
    
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D16" 
    
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D30" 
    
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D60" 
    
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "Total" 
    
    buf1 +="</td>"
    
    
   


    buf1 += "</tr>"

    len = 1;

for (var i = 0; i <= 7; i++) 
{
    buf1 += "<tr>"


    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text' disabled style='width:60px;'class='dropdown_large_corr'; align='left' id='planets_" + i + "'>"
    buf1 += "</td>"



    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:30px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='own_" + i + "' >"
    buf1 += "</td>"


    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:30px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='fri_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:30px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='exal_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:30px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='enim_" + i + "' >"
    buf1 += "</td>"


 buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white';  class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='deb_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:20px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='neut_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:20px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='mootri_" + i + "' >"
    buf1 += "</td>"
    
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left'  id='d1_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left'  id='d2_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left'  id='d3_" + i + "' >"
    buf1 += "</td>"


    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left'  id='d7_" + i + "' >"
    buf1 += "</td>"


    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left'  id='d9_" + i + "' >"
    buf1 += "</td>"




    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left'  id='d10_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left' id='d12_" + i + "' >"
    buf1 += "</td>"



    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left' id='d16_" + i + "' >"
    buf1 += "</td>"


    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left'  id='d30_" + i + "' >"
    buf1 += "</td>"


    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:30px;'class='colum-name_id'; align='left'  id='d60_" + i + "' >"
    buf1 += "</td>"



    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  Enabled='false'disabled style='width:40px;'class='dropdown_large_corr'; align='left'  id='total_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<Button  style='width:50px; ' align='left' Text='Search' class='per_btn1_signi'; value='Search' AutoPostBack='true' id=search_" + i + " onClick='javascript:return search(id);' >Search</Button>"
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
    document.getElementById('planets_7').style.display='none'
    document.getElementById('own_7').style.display='none';
     document.getElementById('fri_7').style.display='none';
    document.getElementById('exal_7').style.display='none';
    document.getElementById('enim_7').style.display='none';
         document.getElementById('deb_7').style.display='none';
    document.getElementById('neut_7').style.display='none';
    document.getElementById('mootri_7').style.display='none';
    document.getElementById('d1_7').style.display='none';
    document.getElementById('d2_7').style.display='none';
    document.getElementById('d3_7').style.display='none';
    document.getElementById('d7_7').style.display='none';
     document.getElementById('d10_7').style.display='none';
    
    document.getElementById('d9_7').style.display='none';
     document.getElementById('d12_7').style.display='none';
     document.getElementById('d16_7').style.display='none';
   
    document.getElementById('d30_7').style.display='none';
    document.getElementById('d60_7').style.display='none';
     document.getElementById('search_7').style.display='none';
 
    for (var kk = 0; kk <= 6; kk++)
  {
binddropdown('planets_' + kk);
}

 


}




function data4(){
find_flag=5;

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
   

    if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:530px;display:block") <= 0) {
        aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
    }
    buf1="";
//    buf1 += "<table  id='Divgrid2' runat='server' align='left' Width='1200px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
//    buf1 += "<tr>"
//    buf1 += "<td class='colum-td-head-chart'>" + "Choose Single Or Multiple Combination's From Following Avastha's" + "</td>"
//    buf1 += "</tr>"
//    buf1 += "</table>"
//    var hdsview = "";
//    
//    temp_del1 = aa + buf1.toString();
//     
//    temp_del1 = temp_del1.replace("<TBODY>", "")
//    temp_del1 = temp_del1.replace("</TBODY>", "")
//    //alert(temp_del1)
//    document.getElementById('hdsviewgrid').innerHTML = temp_del1;
    buf1 += "<table  id='Divgrid1' runat='server' align='left' Width='500px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
    buf1 += "<tr>"
    buf1 += "<td class='colum-td-head-chart'>" + "Planets" + "</td>"
        buf1 += "<td id='own' class='colum-td-head-chart'>" + "Own" + "</td>"
    buf1 += "<td id='fri' class='colum-td-head-chart'>" + "Friendly" + "</td>"
    buf1 += "<td id='exal' class='colum-td-head-chart'>" + "Exaltation" + "</td>"
    buf1 += "<td id='enim' class='colum-td-head-chart'>" + "Enimical" + "</td>"
    buf1 += "<td id='deb' class='colum-td-head-chart'>" + "Deblitaition" + "</td>"
buf1 += "<td id='neut' class='colum-td-head-chart'>" + "Neutral" + "</td>"
buf1 += "<td id='mootri' class='colum-td-head-chart'>" + "Moola Trikona" + "</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D1" 
    
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D2" 
    
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D3" 
    
    buf1 +="</td>"
    buf1 += "<td class='colum-td-head-chart'>" + "D4" 
    
    buf1 +="</td>"


    buf1 += "<td class='colum-td-head-chart'>" + "D7" 
    
    buf1 +="</td>"

   buf1 += "<td class='colum-td-head-chart'>" + "D9" 
    
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "D10" 
    
    buf1 +="</td>"

   buf1 += "<td class='colum-td-head-chart'>" + "D12" 
    
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "D16" 
    
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "D20" 
    
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "D24" 
    
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "D27" 
    
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "D30" 
    
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "D40" 
    
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "D45" 
    
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "D60" 
 
    buf1 +="</td>"
   buf1 += "<td class='colum-td-head-chart'>" + "Total" 
 
    buf1 +="</td>"
    
    
   


    buf1 += "</tr>"

    len = 1;

for (var i = 0; i <=7; i++) 
{
    buf1 += "<tr>"


   buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text' disabled style='width:50px;'class='dropdown_large_corr'; align='left' id='planets_" + i + "'>"
    buf1 += "</td>"



   buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:30px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='own_" + i + "' >"
    buf1 += "</td>"
    
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:30px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='fri_" + i + "' >"
    buf1 += "</td>"
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:30px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='exal_" + i + "' >"
    buf1 += "</td>"
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:30px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='enim_" + i + "' >"
    buf1 += "</td>"


 buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:20px;' class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='deb_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:20px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='neut_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='checkbox'  style='width:20px;'class='dropdown_large_corr'; align='center' AutoPostBack='true'  id='mootri_" + i + "' >"
    buf1 += "</td>"
    
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d1_" + i + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d2_" + i + "' >"
    buf1 += "</td>"
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d3_" + i + "' >"
    buf1 += "</td>"
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d4_" + i + "' >"
    buf1 += "</td>"
    
     
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d7_" + i + "' >"
    buf1 += "</td>"
    
     
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d9_" + i + "' >"
    buf1 += "</td>"
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d10_" + i + "' >"
    buf1 += "</td>"
    
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left' id='d12_" + i + "' >"
    buf1 += "</td>"
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d16_" + i + "' >"
    buf1 += "</td>"
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d20_" + i + "' >"
    buf1 += "</td>"
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left' id='d24_" + i + "' >"
    buf1 += "</td>"
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d27_" + i + "' >"
    buf1 += "</td>"
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d30_" + i + "' >"
    buf1 += "</td>"
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d40_" + i + "' >"
    buf1 += "</td>"
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d45_" + i + "' >"
    buf1 += "</td>"
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'   onclick='javascript:open_div_button(id);' style='width:20px;'class='colum-name_id'; align='left'  id='d60_" + i + "' >"
    buf1 += "</td>"
    
    
    
    buf1 += "<td class='colum-td-chart'>"
    buf1 += "<input type='text'  Enabled='false'disabled style='width:30px;'class='dropdown_large_corr'; align='left'  id='total_" + i + "' >"
    buf1 += "</td>"
    
   buf1 += "<td class='colum-td-chart'>"
    buf1 += "<Button  style='width:50px; ' align='left' Text='Search' class='per_btn1_signi'; value='Search' AutoPostBack='true' id=search_" + i + " onClick='javascript:return search(id);' >Search</Button>"
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
     document.getElementById('planets_7').style.display='none'
    document.getElementById('own_7').style.display='none';
     document.getElementById('fri_7').style.display='none';
    document.getElementById('exal_7').style.display='none';
    document.getElementById('enim_7').style.display='none';
         document.getElementById('deb_7').style.display='none';
    document.getElementById('neut_7').style.display='none';
    document.getElementById('mootri_7').style.display='none';
    document.getElementById('d1_7').style.display='none';
    document.getElementById('d2_7').style.display='none';
    document.getElementById('d3_7').style.display='none';
    document.getElementById('d4_7').style.display='none';
  
    
    document.getElementById('d7_7').style.display='none';
   
    document.getElementById('d9_7').style.display='none';
    document.getElementById('d10_7').style.display='none';
    
    document.getElementById('d12_7').style.display='none';
    document.getElementById('d16_7').style.display='none';
    document.getElementById('d20_7').style.display='none';
    document.getElementById('d24_7').style.display='none';
    document.getElementById('d27_7').style.display='none';
    document.getElementById('d30_7').style.display='none';
    document.getElementById('d40_7').style.display='none';
    document.getElementById('d45_7').style.display='none';
    document.getElementById('d60_7').style.display='none';
   
     document.getElementById('search_7').style.display='none';
     
     

   
    for (var kk = 0; kk <= 6; kk++)
  {
binddropdown('planets_' + kk);
}

   
    }
    
    

function open_div_button(id)

{  document.getElementById('clinetnamediv').style.display = 'block';
    var spl1 = id.split("_");
    var spl2 = spl1[1];
    var varga= spl1[0];
    var planet=document.getElementById('planets_'+spl1[1]).value;
    if(varga=='d1')
    {
    varga='D01'
    }
    if(varga=='d2')
    {
    varga='D02'
    }
    if(varga=='d3')
    {
    varga='D03'
    }
    if(varga=='d4')
    {
    varga='D04'
    }
    if(varga=='d5')
    {
    varga='D05'
    }
    if(varga=='d6')
    {
    varga='D06'
    }
    if(varga=='d7')
    {
    varga='D07'
    }
    if(varga=='d8')
    {
    varga='D08'
    }
    if(varga=='d9')
    {
    varga='D09'
    }
    
    var rashi="";
        var rashi2="";
    if(document.getElementById('own_'+spl1[1]).checked==true)
    {
    rashi='Own'+', '+rashi;
    }
    if(document.getElementById('fri_'+spl1[1]).checked==true)
    {
    rashi='Friendly'+', '+rashi;
    }
    if(document.getElementById('mootri_'+spl1[1]).checked==true)
    {
    rashi='Moola Trikona'+', '+rashi;
    }
    if(document.getElementById('exal_'+spl1[1]).checked==true)
    {
    rashi='Exaltation'+', '+rashi;
    }
   if(document.getElementById('enim_'+spl1[1]).checked==true)
    {
    rashi='Enimical'+', '+rashi;
    }
   if(document.getElementById('deb_'+spl1[1]).checked==true)
    {
    rashi='Debilitation'+', '+rashi;
    }
   if(document.getElementById('neut_'+spl1[1]).checked==true)
    {
    rashi='Neutral'+', '+rashi;
    }
    //var rashi2=rashi.slice(0,-1);
     var res = chartindex.clientinfo(varga);
      var ds=res.value;
        document.getElementById('pl').innerHTML=planet;
        document.getElementById('va').innerHTML=varga.toUpperCase();
       
        var cl_na="";
        var cl_ma="";
        for (i = 0; i < ds.Tables[0].Rows.length; ++i)
         {
        cl_na=cl_na+ds.Tables[0].Rows[i]['CLIENT_NAME']+'<br>';
        cl_ma=cl_ma+ds.Tables[0].Rows[i]['CLIENT_MAIL']+'<br>';
        rashi2=rashi2+ds.Tables[0].Rows[i]['RASHI']+'<br>';
        }
        
    document.getElementById('cn').innerHTML=cl_na.slice(0,-1);
document.getElementById('cm').innerHTML=cl_ma.slice(0,-1);
 document.getElementById('ra').innerHTML=rashi2;
    
    
}



function creossdiv() {
    document.getElementById('clinetnamediv').style.display = 'none';
    return false;
}
