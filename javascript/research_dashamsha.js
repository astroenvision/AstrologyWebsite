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
var buf2 = new StringBuffer();

var aa = "";
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
 
 document.getElementById('astid').innerHTML =document.getElementById('Hastmail').value;
 

    grid();


    
     accountuser(); 
    return false;
  
}

var temp_del1 = "";

function grid() {

    find_flag=1;
    document.getElementById('hdsviewgrid').innerHTML = "";
    document.getElementById('Divgrid1').style.display = 'block';
    

    flg_req = "yes"
    var aa1 = "";
    
    var hs = 0;
    var hs1 = 0;
   
    document.getElementById('hdsviewgrid').style.display = "block";
    $('hdsviewgrid').style.display = "block";
   

    if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:970px;display:block") <= 0) {
        aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
    }

    buf1 += "<table  id='Divgrid1' runat='server' align='left' Width='100%' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
    buf1 += "<tr>"
    buf1 += "<td class='dropdown_large_corrr'>" + "Client ID" + "</td>"
    buf1 += "<td class='dropdown_large_corrr'>" + "Client Name" + "</td>"
    buf1 += "<td class='dropdown_large_corrr'>" + "SUN" + "</td>"
    buf1 += "<td class='dropdown_large_corrr'>" + "MOON " + "</td>"
    buf1 += "<td class='dropdown_large_corrr'>" + "MARS" + "</td>"
buf1 += "<td class='dropdown_large_corrr'>" + "MERCURY" + "</td>"
buf1 += "<td class='dropdown_large_corrr'>" + "JUPITER" + "</td>"
buf1 += "<td class='dropdown_large_corrr'>" + "VENUS" + "</td>"
buf1 += "<td class='dropdown_large_corrr'>" + "SATURN" + "</td>"
buf1 += "<td class='dropdown_large_corrr'>" + "RAHU" + "</td>"
buf1 += "<td class='dropdown_large_corrr'>" + "KETU" + "</td>"
buf1 += "<td class='dropdown_large_corrr'>" + "TOTAL" + "</td>"


    buf1 += "</tr>"

    
    
   

    
  
  buf1 += "</table>"
    var hdsview = "";
    
    temp_del1 = aa + buf1.toString();
     
    temp_del1 = temp_del1.replace("<TBODY>", "")
    temp_del1 = temp_del1.replace("</TBODY>", "")
    //alert(temp_del1)
    document.getElementById('hdsviewgrid').innerHTML = temp_del1;
     
     
    }
    
   

 
 
 
 
 
 
 
 function search1()
     {
     buf2="";
      var temp_del11 = "";
        var astrolrger=document.getElementById('Hastmail').value;
        var res = research_dashamsha.search(astrolrger, document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text);
        var ds=res.value;
        document.getElementById('hdnre').value=res.value;
       if (ds.Tables[0].Rows.length > 0) 
       {
        len = 1;
 buf2 += "<table id='Divgrid1' runat='server' align='left' Width='100%' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
for (var i = 0; i < ds.Tables[0].Rows.length; i++) 
{
    buf2 += "<tr>"

    buf2 += "<td class='dropdown_large_corrr1'>"
    buf2 += "<input type='text' Enabled='false' disabled class='dropdown_large_corrr1'; value='" + ds.Tables[0].Rows[i]['CLIENT_MAIL'] + "'  id='clmail_" + i + "'  >"
    buf2 += "</td>"


    buf2 += "<td class='dropdown_large_corrr1'>"
    buf2 += "<input type='text' Enabled='false' disabled class='dropdown_large_corrr1'; value='" + ds.Tables[0].Rows[i]['CLIENT_NAME'] + "'  id='clmail_" + i + "'  >"
    buf2 += "</td>"

     buf2 += "<td class='dropdown_large_corrr1'>"
    buf2 += "<input type='text' Enabled='false' disabled class='dropdown_large_corrr1'; value='" + ds.Tables[0].Rows[i]['SUN'] + "'  id='sun_" + i + "'  >"
    buf2 += "</td>"

    buf2 += "<td class='dropdown_large_corrr1'>"
    buf2 += "<input type='text' Enabled='false' disabled class='dropdown_large_corrr1'; value='" + ds.Tables[0].Rows[i]['MOON']+ "'  id='moon_" + i + "'  >"
    buf2 += "</td>"
    
     buf2 += "<td class='dropdown_large_corrr1'>"
    buf2 += "<input type='text' Enabled='false' disabled class='dropdown_large_corrr1'; value='" + ds.Tables[0].Rows[i]['MARS'] + "'  id='mars_" + i + "'  >"
    buf2 += "</td>"


    buf2 += "<td class='dropdown_large_corrr1'>"
    buf2 += "<input type='text' Enabled='false' disabled class='dropdown_large_corrr1'; value='" + ds.Tables[0].Rows[i]['MERCURY'] + "'  id='mer_" + i + "'  >"
    buf2 += "</td>"
    
     buf2 += "<td class='dropdown_large_corrr1'>"
    buf2 += "<input type='text' Enabled='false' disabled class='dropdown_large_corrr1'; value='" + ds.Tables[0].Rows[i]['JUPITER'] + "'  id='jup_" + i + "'  >"
    buf2 += "</td>"
    
     buf2 += "<td class='dropdown_large_corrr1'>"
    buf2 += "<input type='text' Enabled='false' disabled class='dropdown_large_corrr1'; value='" + ds.Tables[0].Rows[i]['VENUS'] + "'  id='ven_" + i + "'  >"
    buf2 += "</td>"
    
     buf2 += "<td class='dropdown_large_corrr1'>"
    buf2 += "<input type='text' Enabled='false'  disabled class='dropdown_large_corrr1'; value='" + ds.Tables[0].Rows[i]['SATURN'] + "'  id='sat_" + i + "'  >"
    buf2 += "</td>"
    
     buf2 += "<td class='dropdown_large_corrr1'>"
    buf2 += "<input type='text' Enabled='false' disabled class='dropdown_large_corrr1'; value='" + ds.Tables[0].Rows[i]['RAHU'] + "'  id='rahu_" + i + "'  >"
    buf2 += "</td>"
    
     buf2 += "<td class='dropdown_large_corrr1'>"
    buf2 += "<input type='text' Enabled='false' disabled  class='dropdown_large_corrr1'; value='" + ds.Tables[0].Rows[i]['KETU'] + "'  id='ketu_" + i + "'  >"
    buf2 += "</td>"
    
   buf2 += "<td class='dropdown_large_corrr1'>"
    buf2 += "<input type='text' Enabled='false' disabled  class='dropdown_large_corrr1'; id='tot_" + i + "'  >"
    buf2 += "</td>"
   
    buf2 += "</tr>"
    
    
   } 

    
  
  buf2 += "</table>"
  var hdsview = "";
    
  temp_del11 = aa + buf2.toString();
  temp_del11 = temp_del11.replace("<TBODY>", "")
  temp_del11 = temp_del11.replace("</TBODY>", "")
  document.getElementById('hdsviewgrid').innerHTML = temp_del1+temp_del11;
  document.getElementById('hdsviewgrid').style.display = "block";
    
     }
     else
     {
     alert('There is No Chart of This Client');
     document.getElementById('hdsviewgrid').style.display = "none";
     }
 return false;
 }
 
 




//    
//function open_div_button(id)

//{  document.getElementById('clinetnamediv').style.display = 'block';
//    var spl1 = id.split("_");
//    var spl2 = spl1[1];
//    var varga= spl1[0];
//    var planet=document.getElementById('planets_'+spl1[1]).value;
//       
//    var rashi="";
//    var rashi2="";
//    if(document.getElementById('own_'+spl1[1]).checked==true)
//    {
//    rashi='Own'+', '+rashi;
//    }
//    if(document.getElementById('fri_'+spl1[1]).checked==true)
//    {
//    rashi='Friendly'+', '+rashi;
//    }
//    if(document.getElementById('mootri_'+spl1[1]).checked==true)
//    {
//    rashi='Moola Trikona'+', '+rashi;
//    }
//    if(document.getElementById('exal_'+spl1[1]).checked==true)
//    {
//    rashi='Exaltation'+', '+rashi;
//    }
//   if(document.getElementById('enim_'+spl1[1]).checked==true)
//    {
//    rashi='Enimical'+', '+rashi;
//    }
//   if(document.getElementById('deb_'+spl1[1]).checked==true)
//    {
//    rashi='Debilitation'+', '+rashi;
//    }
//   if(document.getElementById('neut_'+spl1[1]).checked==true)
//    {
//    rashi='Neutral'+', '+rashi;
//    }
//    //var rashi2=rashi.slice(0,-1);
//     var res = ResearchTool.clientinfo(varga);
//      var ds=res.value;
//        document.getElementById('pl').innerHTML=planet;
//        document.getElementById('va').innerHTML=varga.toUpperCase();
//       
//        var cl_na="";
//        var cl_ma="";
//        for (i = 0; i < ds.Tables[0].Rows.length; ++i)
//         {
//        cl_na=cl_na+ds.Tables[0].Rows[i]['CLIENT_NAME']+'<br>';
//        cl_ma=cl_ma+ds.Tables[0].Rows[i]['CLIENT_MAIL']+'<br>';
//        rashi2=rashi2+ds.Tables[0].Rows[i]['RASHI']+'<br>';
//        }
//        
//    document.getElementById('cn').innerHTML=cl_na.slice(0,-1);
//document.getElementById('cm').innerHTML=cl_ma.slice(0,-1);
// document.getElementById('ra').innerHTML=rashi2;
//    
//    
//}



function creossdiv() {
    document.getElementById('clinetnamediv').style.display = 'none';
    return false;
}


function accountuser()
{

 var astrologer= document.getElementById('hdnuser').value;
 if(astrologer=='astrology' ||astrologer=='ASTROLOGY' || astrologer==""){
// alert('you are admin');
 getopen("login.aspx");

 return false;
 }
 else{
     var grp_cat='Natal';
     res = research_dashamsha.searchuser(astrologer, grp_cat);
 
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


function caldash()
{
var dashamsha="";
if(document.getElementById('Ind').checked==true)
{
dashamsha=document.getElementById('Ind').value + ',' + dashamsha;
}
if(document.getElementById('Agn').checked==true)
{
    dashamsha = document.getElementById('Agn').value + ',' + dashamsha;
}
if(document.getElementById('Yam').checked==true)
{
    dashamsha = document.getElementById('Yam').value + ',' + dashamsha;
}
if(document.getElementById('Rak').checked==true)
{
    dashamsha = document.getElementById('Rak').value + ',' + dashamsha;
}
if(document.getElementById('Var').checked==true)
{
    dashamsha = document.getElementById('Var').value + ',' + dashamsha;
}
if(document.getElementById('Vay').checked==true)
{
    dashamsha = document.getElementById('Vay').value + ',' + dashamsha;
}
if(document.getElementById('Kub').checked==true)
{
    dashamsha = document.getElementById('Kub').value + ',' + dashamsha;
}
if(document.getElementById('Ish').checked==true)
{
    dashamsha = document.getElementById('Ish').value + ',' + dashamsha;
}
if(document.getElementById('Bra').checked==true)
{
    dashamsha = document.getElementById('Bra').value + ',' + dashamsha;
}
if(document.getElementById('Ana').checked==true)
{
    dashamsha = document.getElementById('Ana').value + ',' + dashamsha;
}
var astrologer = document.getElementById('Hastmail').value;
var dasha = dashamsha.slice(0, -1);
var res = research_dashamsha.searchdasha(trim(dasha), astrologer);
var ds=res.value;

for (var i = 0; i < ds.Tables[0].Rows.length; i++) 
{
document.getElementById('tot_'+i).value=ds.Tables[0].Rows[i]['TOTAL'];
}

return false;
}

function trim(stringToTrim) {
return stringToTrim.replace(/^\s+|\s+$/g, "");
}