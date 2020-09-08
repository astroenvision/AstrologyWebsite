var homenewpage = "";
var exec_data = "";
var next = 0;
var execute = "";
var exec_data1 = "";
var Modify = 0;
var delete_record = 0;
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

function gethorarycalculation()
{
   var sunsetpre = document.getElementById('hdsunsetpre').value;
   var sunrise = document.getElementById('hdsunrise').value;
   var sunset = document.getElementById('hdsunset').value;
   var sunrisenext = document.getElementById('hdsunrisenext').value;
   var astrologer = document.getElementById('hdnastmail').value;
   var tob = document.getElementById('hdntob').value;
   var dob = document.getElementById('hdndob').value;
   var city = document.getElementById('hdncity').value;
   var clientquery = document.getElementById('hdnquery').value;
   window.open("horary_calculation.aspx?astmail=" + astrologer + "&dob=" + dob + "&tob=" + tob + "&city=" + city + "&sunsetpre=" + sunsetpre + "&sunrise=" + sunrise  + "&sunset=" + sunset  + "&sunrisenext=" + sunrisenext +   "&usermail=" + document.getElementById('hdnuser').value+"&query="+clientquery + "", null);
   return false;
}

function getprobablequery()
{
   var sunsetpre = document.getElementById('hdsunsetpre').value;
   var sunrise = document.getElementById('hdsunrise').value;
   var sunset = document.getElementById('hdsunset').value;
   var sunrisenext = document.getElementById('hdsunrisenext').value;
   var astrologer = document.getElementById('hdnastmail').value;
   var tob = document.getElementById('hdntob').value;
   var dob = document.getElementById('hdndob').value;
   var city = document.getElementById('hdncity').value;
   var clientquery = document.getElementById('hdnquery').value;
   window.open("probable_query.aspx?astmail=" + astrologer + "&dob=" + dob + "&tob=" + tob + "&city=" + city + "&sunsetpre=" + sunsetpre + "&sunrise=" + sunrise + "&sunset=" + sunset + "&sunrisenext=" + sunrisenext + "&usermail=" + document.getElementById('hdnuser').value + "&query="+clientquery + "", null);
   return false;
}

function gridcall()
{
    document.getElementById('clientname').innerHTML = document.getElementById('Hclname').value;
    document.getElementById('clientid').innerHTML = document.getElementById('Hclmail').value;
    document.getElementById('astname').innerHTML = document.getElementById('Hastname').value;
    document.getElementById('astid').innerHTML = document.getElementById('Hastmail').value;
    grid();
    for (var i = 0; i <= 9; i++) {
        grid1(i);
    }


    for (var kk = 0; kk < 11; kk++) {
        binddropdown("planets_" + kk);
        bindrashi("rashi_" + kk);
        bindhouse("house_" + kk);
        binddegree("degree_" + kk);
        bindminutes("minutes_" + kk);
        bindseconds("seconds_" + kk);
        bindretrograde("retrograde_" + kk);
        bindconstelation("constelation_" + kk);

    }
    document.getElementById('seconds_9').disabled = true;
    document.getElementById('minutes_9').disabled = true;
    document.getElementById('degree_9').disabled = true;
    document.getElementById('rashi_9').disabled = true;
    document.getElementById('rashi_10').disabled = true;
    document.getElementById('house_10').disabled = true;

    document.getElementById('planets_10').value = "GULIKA";
    document.getElementById('planets_10').disabled = true;
     

    //document.getElementById('degree_10').style.display = 'none';
    //document.getElementById('minutes_10').style.display = 'none';
    //document.getElementById('seconds_10').style.display = 'none';
    //document.getElementById('retrograde_10').style.display = 'none';
    //document.getElementById('constelation_10').style.display = 'none';
    
    if (document.getElementById('hdnmoc').value == 1)
    {
        makebc();
    }
    else if (document.getElementById('hdnmoc').value == 0) {
        makeoc();
    }
    else
    {
        searchclientid();
    }

    vargaschart();
}



function grid() {
//    document.getElementById('Divgrid1').style.top = 160 + "px";
//    document.getElementById('Divgrid1').style.left =-250 + "px";
    document.getElementById('hdsviewgrid').innerHTML = "";
        document.getElementById('Divgrid1').style.display = 'block';
    var temp_del1 = "";

    flg_req = "yes"
    var aa1 = "";
    var aa = "";
    var hs = 0;
    var hs1 = 0;
    //alert('kkk')
    //alert(document.getElementById("datagrid1").childNodes[0])
    document.getElementById('hdsviewgrid').style.display = "block";
    //$('hdsviewgrid').style.display = "block";
    //alert(document.getElementById("hdsviewgrid").children.length)
    if (document.getElementById("hdsviewgrid").children.length == "0") {
        klen = "0"
        //alert(klen)
    }
    else {

        klen = document.getElementById("Divgrid1").childNodes[0].childNodes[0].childNodes.length - 1;
        //alert(klen)
        //           klen=document.getElementById("hdsviewgrid").childNodes[0].childNodes[0].childNodes.length-1;
        IntializeNumber = klen + 1;
    }

    if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:530px;display:block") <= 0) {
        aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
    }

    buf1 += "<table  id='Divgrid1' runat='server' align='left' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
    buf1 += "<tr>"
    buf1 += "<td class='colum-td-head Planets'>" + "Planets" + "</td>"
    buf1 += "<td class='colum-td-head'>" + "Rashi" + "</td>"
    buf1 += "<td class='colum-td-head'>" + "House" + "</td>"
    buf1 += "<td class='colum-td-head'>" + "o`" + "</td>"
    buf1 += "<td class='colum-td-head'>" + "'" + "</td>"
    buf1 += "<td class='colum-td-head'>" + "''" + "</td>"
    buf1 += "<td class='colum-td-head'>" + "Retro" + "</td>"
    buf1 += "<td class='colum-td-head'>" + "Const" + "</td>"
     // buf1 += "<td  bgcolor=#7DAAE3 style='height:20px;width:70px;font-size:10px;text-align:center;border:1px solid #ffffff;'>" + "Birth_date" + "</td>"


    buf1 += "</tr>"

    len = 1;


    buf1 += "<tr>"


    buf1 += "<td class='colum-td-new'>"
    buf1 += "<input type='text' disabled class='colum-name_id' align='left'   id='planets_" + klen + "'  >"
    buf1 += "</td>"



    buf1 += "<td class='colum-td-new ' >"
    buf1 += "<select   ' align='left' class='Planets-font rashi-1' AutoPostBack='true' id='rashi_" + klen + "' onChange='javascript:return enablerashi(this.id);' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new '>"
    buf1 += "<input type='text'  disabled 'class='rashi-1'; align='left' value='HOUSE1' id='house_" + klen + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new '>"
    buf1 += "<select align='left' class='rashi-3' id='degree_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new '>"
    buf1 += "<select align='left' class='rashi-3' id='minutes_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new '>"
    buf1 += "<select class='rashi-3'; align='left' id='seconds_" + klen + "' onChange='javascript:return selectconstellation(this.id);'>"
    buf1 += "</td>"


    buf1 += "<td class='retro-1'>"
    buf1 += "<select  align='left'class='rashi-3' id='retrograde_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new '>"
    buf1 += "<select disabled align='left'class='rashi-1' id='constelation_" + klen + "'>"
    buf1 += "</td>"
    
//     buf1 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
//    buf1 += "<select style='width:70px;'class='dropdown_large_corr'; align='left' id='birth_" + klen + "' onChange='javascript:return selectbirthon(this.id);'>"
//    buf1 += "</td>"


    //    buf1 += "<td class='gridview' style='border:0px solid #7DAAE3;display:none;'>"
    //    buf1 += "<input type='text'   class='fortaxtbox' width=100px' id='drprefid_" + klen + "'>"
    //    buf1 += "</td>"

    //        buf1 +="<td  class='gridview' style='border:0px solid #7DAAE3;'>")
    //        buf1 +="<select  style='display:none;' class=fordropdown width=100px' id='txtclimit_" + klen + "' onfocus='javascript:return binddropdown(id);'>"
    //        buf1 +="</td>")
    buf1 += "</tr>"






    buf1 += "</table>"
    var hdsview = "";
    temp_del1 = aa + buf1.toString();
    temp_del1 = temp_del1.replace("<TBODY>", "")
    temp_del1 = temp_del1.replace("</TBODY>", "")
    //alert(temp_del1)
    document.getElementById('hdsviewgrid').innerHTML = temp_del1;
    //for(var i=0;
    //binddropdown('planets_0');
    //alert(document.getElementById('hdsviewgrid').innerHTML)
    //document.getElementById('Td1').innerHTML=temp_del1; 
    //lert(document.getElementById('hdsviewgrid').innerHTML)
    //document.getElementById('txtdesc__0').focus();


    //    valfill(res);

    //document.getElementById('hdsviewgrid').style.display="block";

    //    flg_req = "no"



    
    //disabeled();
    //setButtonImages();


    return false;




}


function grid1(i) {

     flg_req = "yes"
    var aa1 = "";
    var aa = "";
    var hs = 0;
    var hs1 = 0;


    klen = (i+1);

    // buf1 +="<table  class='gridview' id='datagrid1' runat='server' align='center' Width='500px' height='0px' style='border:0;margin-left:250px; solid #7DAAE3; cellpadding='0' cellspacing='0'>")//<tr>")
    // for (klen = a; klen < len1; klen++) {


    buf1 = document.getElementById("hdsviewgrid").innerHTML;

    if (browser != "Microsoft Internet Explorer") {
        buf1 = buf1.replace("</tbody></table>", "");
    }
    else {
        buf1 = buf1.replace("</tbody></table>", "");
    }


    buf1 += "<tr>"

    buf1 += "<td class='colum-td-new'>"
    buf1 += "<input type='text'disabled '; class='Planets-font' align='left' id='planets_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new'>"
    buf1 += "<select disabled  ' align='left' class='Planets-font rashi-1'  id='rashi_" + klen + "' onChange='javascript:return selectrashi(this.id);' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new'>"
    buf1 += "<select disabled '; id='house_" + klen + "' runat='server'  align='left' class='rashi-2'  onChange='javascript:return selecthouse(this.id);' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new '>"
    buf1 += "<select disabled ' align='left'class='rashi-3' id='degree_" + klen + "'onchange='javascript:return selectdegree(this.id);'>"
    buf1 += "</td>"

    buf1 += "<td  class='colum-td-new '>"
    buf1 += "<select disabled  ' align='left' class='rashi-3' id='minutes_" + klen + "'onchange='javascript:return selectminute(this.id);'>"
    buf1 += "</td>"

    buf1 += "<td  class='colum-td-new '>"
    buf1 += "<select disabled ' align='left' class='rashi-3' id='seconds_" + klen + "' onChange='javascript:return selectconstellation(this.id);'>"
    buf1 += "</td>"


    buf1 += "<td class='retro-1'>"
    buf1 += "<select ' align='left'class='rashi-3' id='retrograde_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new '>"
    buf1 += "<select disabled ' align='left'class='rashi-1' id='constelation_" + klen + "'>"
    buf1 += "</td>"
    
//    buf1 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
//    buf1 += "<select disabled style='width:70px;'class='dropdown_large_corr'; align='left' id='birth_" + klen + "' >"
//    buf1 += "</td>"
//    //        buf1 +="<td  class='gridview' style='border:0px solid #7DAAE3;'>")
    //        buf1 +="<select  style='display:none;' class=fordropdown width=100px' id='txtclimit_" + klen + "' onfocus='javascript:return binddropdown(id);'>"
    //        buf1 +="</td>")
    buf1 += "</tr>"




    if (browser != "Microsoft Internet Explorer") {
        buf1 += "</TBODY></table>"
    }
    else {
        buf1 += "</tbody></table>"
    }
     $("hdsviewgrid").innerHTML = buf1.toString();



    //    //for(var i=0;
    //    //binddropdown('planets_0');


    return false;




}


function binddropdown(res) {

    if (res == "planets_0") {
        document.getElementById(res).value = "ASCENDENT";
    }
    if (res == "planets_1") {
        document.getElementById(res).value = "SUN";
    }

    if (res == "planets_2") {
        document.getElementById(res).value = "MOON";
    }

    if (res == "planets_3") {
        document.getElementById(res).value = "MARS";
    }

    if (res == "planets_4") {
        document.getElementById(res).value = "MERCURY";
    }

    if (res == "planets_5") {
        document.getElementById(res).value = "JUPITER";
    }

    if (res == "planets_6") {
        document.getElementById(res).value = "VENUS";
    }
    if (res == "planets_7") {
        document.getElementById(res).value = "SATURN";
    }
    if (res == "planets_8") {
        document.getElementById(res).value = "RAHU";

    }
    if (res == "planets_9") {
        document.getElementById(res).value = "KETU";
    }
// if (res == "planets_10") {
//        document.getElementById(res).value = "GULIKA";
//    }

}


function bindrashi(res) {

    var vishu = "";
    var res1 = homenewpage.bindrashi(vishu);
    var ds = res1.value;
    
    document.getElementById(res).options.length = 0;
    document.getElementById(res).options[0] = new Option("--Select Rashi--", "0");
    
    var i;
    //    if(ds!=null)
    //    {
    if (ds.Tables[0].Rows.length > 0) {
        for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
            
            document.getElementById(res).options[document.getElementById(res).options.length] = new Option(ds.Tables[0].Rows[i].NAME, ds.Tables[0].Rows[i].CODE);
            document.getElementById(res).options.length;
        }
    }

}


function bindhouse(res) {
    if (res == "house_0") {

    }
    else {
        var vishu = "";
        var res1 = homenewpage.bindhouse(vishu);
        var ds = res1.value;
        
        //var drop_id=
        document.getElementById(res).options.length =0;
    
    document.getElementById(res).options[0] = new Option("--Select House--", "0");
        
        var i;
        //    if(ds!=null)
        //    {
        if (ds.Tables[0].Rows.length > 0) {
            for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
                document.getElementById(res).options[document.getElementById(res).options.length] = new Option(ds.Tables[0].Rows[i].NAME, ds.Tables[0].Rows[i].CODE);
                document.getElementById(res).options.length;
            }
        }
    }

}

function binddegree(res) {

    var vishu = "";
    var res1 = homenewpage.binddegree(vishu);
    var ds = res1.value;

    document.getElementById(res).options.length = 0;
    document.getElementById(res).options[0] = new Option("", "");

    var i;
    //    if(ds!=null)
    //    {
    if (ds.Tables[0].Rows.length > 0) {
        for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
            document.getElementById(res).options[document.getElementById(res).options.length] = new Option(ds.Tables[0].Rows[i].DEGREE, ds.Tables[0].Rows[i].CODE);
            document.getElementById(res).options.length;
        }
    }


}

function bindminutes(res) {

    var vishu = "";
    var res1 = homenewpage.bindminutes(vishu);
    var ds = res1.value;

    document.getElementById(res).options.length = 0;
    document.getElementById(res).options[0] = new Option("", "");

    var i;
    //    if(ds!=null)
    //    {
    if (ds.Tables[0].Rows.length > 0) {
        for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
            document.getElementById(res).options[document.getElementById(res).options.length] = new Option(ds.Tables[0].Rows[i].MINUTES, ds.Tables[0].Rows[i].CODE);
            document.getElementById(res).options.length;
        }
    }


}

function bindseconds(res) {

    var vishu = "";
    var res1 = homenewpage.bindseconds(vishu);
    var ds = res1.value;

    document.getElementById(res).options.length = 0;
    document.getElementById(res).options[0] = new Option("", "");

    var i;
    //    if(ds!=null)
    //    {
    if (ds.Tables[0].Rows.length > 0) {
        for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
            document.getElementById(res).options[document.getElementById(res).options.length] = new Option(ds.Tables[0].Rows[i].SECONDS, ds.Tables[0].Rows[i].CODE);
            document.getElementById(res).options.length;
        }
    }


}

function bindretrograde(res) {

    var vishu = "";
    var res1 = homenewpage.bindretrograde(vishu);
    var ds = res1.value;

//    document.getElementById(res).options.length = 0;
//    document.getElementById(res).options[0] = new Option("", "0");

    var i;
    //    if(ds!=null)
    //    {
    if (ds.Tables[0].Rows.length > 0) {
        for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
             if(ds.Tables[0].Rows[i].CATE==null)
             {
                ds.Tables[0].Rows[i].CATE="";
             }
             if(ds.Tables[0].Rows[i].CODE==null)
             {
                ds.Tables[0].Rows[i].CODE="";
             }
            document.getElementById(res).options[document.getElementById(res).options.length] = new Option(ds.Tables[0].Rows[i].CATE, ds.Tables[0].Rows[i].CODE);
            document.getElementById(res).options.length;
        }
    }


}

function bindconstelation(res) {

    var vishu = "";
    var res1 = homenewpage.bindconstelation(vishu);
    var ds = res1.value;

    document.getElementById(res).options.length = 0;
    document.getElementById(res).options[0] = new Option("--Select Constelation--", "0");

    var i;
    //    if(ds!=null)
    //    {
    if (ds.Tables[0].Rows.length > 0) {
        for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
            document.getElementById(res).options[document.getElementById(res).options.length] = new Option(ds.Tables[0].Rows[i].NAME, ds.Tables[0].Rows[i].CODE);
            document.getElementById(res).options.length;
        }
    }


}


function selectrashi(id) {
    var id1 = id.split('_')
    var id2 = id1[1]
    document.getElementById("degree_" + id2).disabled = false;
    document.getElementById("minutes_" + id2).disabled = false;
    document.getElementById("seconds_" + id2).disabled = false;
    var house = document.getElementById("house_" + 0).value
    var rashi = document.getElementById("rashi_" + 0).value
    var selectedrashi = document.getElementById(id).value
    var re = homenewpage.housevalue(house, rashi, selectedrashi);
    var ds = re.value;
    document.getElementById("house_" + id2).value = ds.Tables[0].Rows[0].CODE;
    if (id2 == '8') {
        document.getElementById("house_9").value = ds.Tables[1].Rows[0].CODE;
        document.getElementById("rashi_9").value = ds.Tables[2].Rows[0].CODE;
    }
}

function selecthouse(id) {
    var id1 = id.split('_')
    var id2 = id1[1]
    var house = document.getElementById("house_" + 0).value
    var rashi = document.getElementById("rashi_" + 0).value
    var selectedhouse = document.getElementById(id).value
    var re = homenewpage.rashivalue(house, rashi, selectedhouse);
    var ds = re.value;

    document.getElementById("rashi_" + id2).value = ds.Tables[0].Rows[0].CODE;
    if (id2 == '8') {
        document.getElementById("house_9").value = ds.Tables[1].Rows[0].CODE;
        document.getElementById("rashi_9").value = ds.Tables[2].Rows[0].CODE;
          
  var a = document.getElementById('house_'+8).value;
  document.getElementById('house_'+9).value=a;
 
    }
}
function selectconstellation(id) {
    var second = id.split('_')
    var seconds1 = second[1]

    var house = document.getElementById("house_" + seconds1).value
    var rashi = document.getElementById("rashi_" + seconds1).value
    var degree = document.getElementById("degree_" + seconds1).value
    var minutes = document.getElementById("minutes_" + seconds1).value
    var seconds = document.getElementById("seconds_" + seconds1).value
    var degreevalue = degree + '.' + minutes + '.' + seconds;

    var cons = homenewpage.getconstellation(rashi, degreevalue);
    var ds = cons.value;
    document.getElementById("constelation_" + seconds1).value = ds.Tables[0].Rows[0].CONSTELLATION;
     var a = document.getElementById('seconds_'+8).value;
  document.getElementById('seconds_'+9).value=a;
   var a = document.getElementById('constelation_'+8).value;
  document.getElementById('constelation_'+9).value=a;
  
  checkforsec(id);
}


function vargaschart() {
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

   
    if( (parseFloat(document.getElementById('Hnewdiffm').value) > parseFloat('28.00.00') && parseFloat(document.getElementById('Hnewdiffm1').value) > parseFloat('28.00.00'))||(parseFloat(document.getElementById('Hnewdiffm').value) < parseFloat('00.00.00') || parseFloat(document.getElementById('Hnewdiffm1').value) < parseFloat('00.00.00'))||(parseFloat(document.getElementById('Hnewdiffv').value) >parseFloat( '48.00.00') && parseFloat(document.getElementById('Hnewdiffv1').value) >parseFloat( '48.00.00'))||(parseFloat(document.getElementById('Hnewdiffv').value) <parseFloat( '00.00.00') || parseFloat(document.getElementById('Hnewdiffv1').value) <parseFloat( '00.00.00'))){
        alert('chart is not valid');
        return false;
    }

    else {
        document.getElementById('rashiid').style.display = "block";
        for (var i = 1; i < 11; i++) {
            document.getElementById('Hidden4').value = i;

            var h = document.getElementById('house_' + i).value
            var r = document.getElementById('rashi_' + 0).value
            
        

            if (document.getElementById('retrograde_' + i).value == '0')
            {
                document.getElementById('retrograde_' + i).innerHTML = "";
                
            }


            if (h == 'HOUSE1') {


                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j1 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j1 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j1 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j1 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j1 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j1 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j1 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j1 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j1 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j1 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                h1 = h1 + j1 + " ";


            }
            if (h == 'HOUSE2') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j2 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j2 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j2 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j2 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j2 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j2 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j2 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j2 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j2 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j2 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }


                h2 = h2 + j2 + " ";


            }

            if (h == 'HOUSE3') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j3 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j3 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j3 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j3 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j3 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j3 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j3 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j3 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j3 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j3 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h3 = h3 + j3 + " ";


            }


            if (h == 'HOUSE4') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j4 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j4 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j4 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j4 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j4 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j4 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j4 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j4 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j4 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j4 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h4 = h4 + j4 + " ";


            }

            if (h == 'HOUSE5') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j5 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j5 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j5 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j5 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j5 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j5 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j5 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j5 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j5 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j5 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h5 = h5 + j5 + " ";

            }

            if (h == 'HOUSE6') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j6 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j6 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j6 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j6 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
          }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j6 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j6 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j6 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j6 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';

                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j6 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j6 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h6 = h6 + j6 + " ";


            }

            if (h == 'HOUSE7') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j7 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j7 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j7 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j7 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j7 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j7 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j7 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j7 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j7 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j7 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                h7 = h7 + j7 + " ";


            }

            if (h == 'HOUSE8') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j8 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j8 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j8 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j8 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j8 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j8 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j8 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j8 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j8 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j8 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                h8 = h8 + j8 + " ";


            }

            if (h == 'HOUSE9') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j9 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j9 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j9 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j9 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j9 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j9 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j9 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j9 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j9 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }


                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j9 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h9 = h9 + j9 + " ";


            }

            if (h == 'HOUSE10') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j10 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j10 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j10 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j10 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j10 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j10 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j10 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j10 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j10 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>' + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j10 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                h10 = h10 + j10 + " ";


            }

            if (h == 'HOUSE11') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j11 = 'Me'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j11 = 'Ju'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " + '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j11 = 'Ve'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j11 = 'Sa'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j11 = 'Su'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j11 = 'Mo'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j11 = 'Ma'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j11 = 'Ra'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j11 = 'Ke'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }


                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j11 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h11 = h11 + j11 + " ";

            }
            if (h == 'HOUSE12') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j12 = 'Me'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j12 = 'Ju'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j12 = 'Ve'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j12 = 'Sa'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j12 = 'Su'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j12 = 'Mo'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j12 = 'Ma'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j12 = 'Ra'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j12 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>' + " " + '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j12 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
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
        document.getElementById('h1l1').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#F25E0A>'+document.getElementById('degree_' + 0).value+'.'+document.getElementById('minutes_' + 0).value+'</span>';
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
        document.getElementById('h12r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r12+'</span>'+'</br>';
        document.getElementById('h1r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r1+'</span>'+'</br>';
        document.getElementById('h2r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r2+'</span>'+'</br>';
        document.getElementById('h3r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r3+'</span>'+'</br>';
        document.getElementById('h4r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r4+'</span>'+'</br>';
        document.getElementById('h5r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r5+'</span>'+'</br>';
        document.getElementById('h6r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r6+'</span>'+'</br>';
        document.getElementById('h7r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r7+'</span>'+'</br>';
        document.getElementById('h8r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r8+'</span>'+'</br>';
        document.getElementById('h9r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r9+'</span>'+'</br>';
        document.getElementById('h10r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r10+'</span>'+'</br>';
        document.getElementById('h11r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r11+'</span>'+'</br>';


        ///////mobile/////////////////
        //document.getElementById('h1l1m').innerHTML = p1+" "+'Asc';
        //document.getElementById('h2l1m').innerHTML = p2;
        //document.getElementById('h3l1m').innerHTML = p3;
        //document.getElementById('h4l1m').innerHTML = p4;
        //document.getElementById('h5l1m').innerHTML = p5;
        //document.getElementById('h6l1m').innerHTML = p6;
        //document.getElementById('h7l1m').innerHTML = p7;
        //document.getElementById('h8l1m').innerHTML = p8;
        //document.getElementById('h9l1m').innerHTML = p9;
        //document.getElementById('h10l1m').innerHTML = p10;
        //document.getElementById('h11l1m').innerHTML = p11;
        //document.getElementById('h12l1m').innerHTML = p12;
        //document.getElementById('h12rm').innerHTML = r12;
        //document.getElementById('h1rm').innerHTML = r1;
        //document.getElementById('h2rm').innerHTML = r2;
        //document.getElementById('h3rm').innerHTML = r3;
        //document.getElementById('h4rm').innerHTML = r4;
        //document.getElementById('h5rm').innerHTML = r5;
        //document.getElementById('h6rm').innerHTML = r6;
        //document.getElementById('h7rm').innerHTML = r7;
        //document.getElementById('h8rm').innerHTML = r8;
        //document.getElementById('h9rm').innerHTML = r9;
        //document.getElementById('h10rm').innerHTML = r10;
        //document.getElementById('h11rm').innerHTML = r11;



        return false;
    }
}
 function search(id) {

   var chart=id;
   var s = "";
    for (var i = 0; i < 11; i++) {
document.getElementById('degree_10').value = '00';
document.getElementById('minutes_10').value = '00';
document.getElementById('seconds_10').value = '00';
        var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "~" + document.getElementById('degree_' + i).value + "~" + document.getElementById('minutes_' + i).value + "~" + document.getElementById('seconds_' + i).value + "~" + document.getElementById('retrograde_' + i).value + "~" + document.getElementById('constelation_' + i).value + "~" + "0" + "$";

    }
    var rashi = document.getElementById('rashi_' + 0).value;
   
    var searchpage = s + "/" + rashi+ "/" + chart;
    window.open('searchpage.aspx?searchpage=' + searchpage);


}

var v = "";
var c="";
var degree = "";
function calvargas() {

    if ( (document.getElementById('hdnmoc').value == 0) && (parseFloat(document.getElementById('Hnewdiffm').value) > parseFloat('28.00.00') && parseFloat(document.getElementById('Hnewdiffm1').value) > parseFloat('28.00.00')) || (parseFloat(document.getElementById('Hnewdiffm').value) < parseFloat('00.00.00') && parseFloat(document.getElementById('Hnewdiffm1').value) < parseFloat('00.00.00')) || (parseFloat(document.getElementById('Hnewdiffv').value) > parseFloat('48.00.00') && parseFloat(document.getElementById('Hnewdiffv1').value) > parseFloat('48.00.00')) || (parseFloat(document.getElementById('Hnewdiffv').value) < parseFloat('00.00.00') && parseFloat(document.getElementById('Hnewdiffv1').value) < parseFloat('00.00.00'))) {
    
            alert('chart is not valid');
            return false;
    }

    else {

        var astname = document.getElementById('Hastname').value;
        var astid = document.getElementById('Hastmail').value;
        var clientid = document.getElementById('Hclmail').value;

        var clientname = document.getElementById('Hclname').value;
        var j = document.getElementById('planet').value;

        var k = document.getElementById('Texttodate').value;
       
        var retro = "";
        for (var i = 0; i < 11; i++) {

            if (document.getElementById('retrograde_' + i).value == "")
            { retro = 'B' }

            else {
                retro = document.getElementById('retrograde_' + i).value;
            }

            if (document.getElementById('degree_' + i).value == '00') {
                //document.getElementById('degree_' + i).value = '01'
            }
            if (document.getElementById('minutes_' + i).value == '00') {
                document.getElementById('minutes_' + i).value = '01'
            }
            if (document.getElementById('seconds_' + i).value == '00') {
                document.getElementById('seconds_' + i).value = '01'
            }

            degree = document.getElementById('degree_' + i).value + "." + document.getElementById('minutes_' + i).value + "." + document.getElementById('seconds_' + i).value;
            v = v + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "~" + document.getElementById('birth').value + "~" + retro + "~" + degree + "$";
            c = c + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "~" + document.getElementById('birth').value + "~" + retro + "~" + degree + "~" + document.getElementById('constelation_' + i).value + "$";
        }
        v = v.slice(0, -1);
        c = c.slice(0, -1);
        // var resv = astrodegree.calvargas(v);
        // var dsv = resv.value;
        var imonthob = document.getElementById('hdnimoob').value
        var idateob = document.getElementById('hdnidob').value
        var iyearob = document.getElementById('hdniyob').value

        var ihourob = document.getElementById('hdnihob').value
        var iminuteob = document.getElementById('hdnimob').value
        
        var sunsetpre = document.getElementById('hdsunsetpre').value;
        var sunrise = document.getElementById('hdsunrise').value;
        var sunset = document.getElementById('hdsunset').value;
        var sunrisenext = document.getElementById('hdsunrisenext').value;
        var tzo = document.getElementById('hdntzo').value;
        
        
        var dob = document.getElementById('hdndob').value
        var dob1 = dob.split('/')
        var date1=dob1[0];
        var month1=dob1[1];
        var year1=dob1[2];

        var tob = document.getElementById('hdntob').value
        var tob1 = tob.split(':');
        var hob=tob1[0];
        var miob=tob1[1];
        var stob="0";
        var dn="Maha Dasha";
        var clientquery = document.getElementById('hdnquery').value;
        var astmail = document.getElementById('Hastmail').value;
        var bosparameters = document.getElementById('degree_' + 2).value + "$" + document.getElementById('minutes_' + 2).value + "$" + document.getElementById('seconds_' + 2).value + "$" + document.getElementById('rashi_' + 2).value + "$" + date1 + "$" + month1 + "$" + year1 + "$" + hob + "$" + miob + "$" + stob + "$" + astmail + "$" +  dn;
        window.open('vargas_chart.aspx?v=' + v + "&j=" + j + "&k=" + k + "&astname=" + astname + "&astid=" + astid + "&clientname=" + clientname + "&clientid=" + clientid + "&usermail=" + document.getElementById('hdnuser').value + "&c=" + c + "&dob=" + document.getElementById("hdndob").value + "&tob=" + document.getElementById("hdntob").value + "&country=" + document.getElementById("hdncountry").value + "&state=" + document.getElementById("hdnstate").value + "&district=" + document.getElementById("hdndist").value + "&city=" + document.getElementById("hdncity").value + "&group=" + document.getElementById("hdngroup").value + "&group_under=" + document.getElementById("hdngroup_u").value + "&prof=" + document.getElementById("hdnprof").value + "&sex=" + document.getElementById("hdnsex").value + "&mobile=" + document.getElementById("hdnmobile").value + "&idateob=" + idateob + "&imonthob=" + imonthob + "&iyearob=" + iyearob + "&ihourob=" + ihourob + "&iminuteob=" + iminuteob + "&longitude=" + document.getElementById('hdnlongit').value + "&latitude=" + document.getElementById('hdnlatit').value + "&timezone=" + tzo + "&tzval=" + document.getElementById('hdntzval').value + "&sunsetpre=" + sunsetpre  + "&sunrise=" + sunrise + "&sunset=" + sunset + "&sunrisenext=" + sunrisenext + "&balancedasha=" + bosparameters +"&query="+clientquery + "");
        
        
    }


}


function transit() {


    if ((document.getElementById('hdnmoc').value == 0) && (parseFloat(document.getElementById('Hnewdiffm').value) > parseFloat('28.00.00') && parseFloat(document.getElementById('Hnewdiffm1').value) > parseFloat('28.00.00')) || (parseFloat(document.getElementById('Hnewdiffm').value) < parseFloat('00.00.00') && parseFloat(document.getElementById('Hnewdiffm1').value) < parseFloat('00.00.00')) || (parseFloat(document.getElementById('Hnewdiffv').value) > parseFloat('48.00.00') && parseFloat(document.getElementById('Hnewdiffv1').value) > parseFloat('48.00.00')) || (parseFloat(document.getElementById('Hnewdiffv').value) < parseFloat('00.00.00') && parseFloat(document.getElementById('Hnewdiffv1').value) < parseFloat('00.00.00'))) {

        alert('chart is not valid');
        return false;

    }

    else {

        if (document.getElementById('hdnmoc').value != "2") {
            var astname = document.getElementById('Hastname').value;
            var astid = document.getElementById('Hastmail').value;
            var clientid = document.getElementById('Hclmail').value;

            var clientname = document.getElementById('Hclname').value;
            var j = document.getElementById('planet').value;

            var k = document.getElementById('Texttodate').value;
          
            var retro = "";
            for (var i = 0; i < 11; i++) {

                if (document.getElementById('retrograde_' + i).selectedIndex == '0')
                { retro = 'B' }

                else {
                    retro = document.getElementById('retrograde_' + i).value;
                }
                if (document.getElementById('degree_' + i).value == '00') {
                    document.getElementById('degree_' + i).value = '01'
                }
                if (document.getElementById('minutes_' + i).value == '00') {
                    document.getElementById('minutes_' + i).value = '01'
                }
                if (document.getElementById('seconds_' + i).value == '00') {
                    document.getElementById('seconds_' + i).value = '01'
                }

                degree = document.getElementById('degree_' + i).value + "." + document.getElementById('minutes_' + i).value + "." + document.getElementById('seconds_' + i).value;
                v = v + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "~" + document.getElementById('birth').value + "~" + retro + "~" + degree + "$";
                c = c + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "~" + document.getElementById('birth').value + "~" + retro + "~" + degree + "~" + document.getElementById('constelation_' + i).value + "$";
            }
            v = v.slice(0, -1);
            c = c.slice(0, -1);

            var imonthob = document.getElementById('hdnimoob').value
            var idateob = document.getElementById('hdnidob').value
            var iyearob = document.getElementById('hdniyob').value

            var ihourob = document.getElementById('hdnihob').value
            var iminuteob = document.getElementById('hdnimob').value

            window.open('transition.aspx?v=' + v + "&j=" + j + "&k=" + k + "&astname=" + astname + "&astid=" + astid + "&clientname=" + clientname + "&clientid=" + clientid + "&usermail=" + document.getElementById('hdnuser').value + "&c=" + c + "&dob=" + document.getElementById("hdndob").value + "&tob=" + document.getElementById("hdntob").value + "&country=" + document.getElementById("hdncountry").value + "&state=" + document.getElementById("hdnstate").value + "&district=" + document.getElementById("hdndist").value + "&city=" + document.getElementById("hdncity").value + "&group=" + document.getElementById("hdngroup").value + "&group_under=" + document.getElementById("hdngroup_u").value + "&prof=" + document.getElementById("hdnprof").value + "&sex=" + document.getElementById("hdnsex").value + "&idateob=" + idateob + "&imonthob=" + imonthob + "&iyearob=" + iyearob + "&ihourob=" + ihourob + "&iminuteob=" + iminuteob + "&longitude=" + document.getElementById('hdnlongit').value + "&latitude=" + document.getElementById('hdnlatit').value + "&mobile=" + document.getElementById("hdnmobile").value + "&tz=" + document.getElementById('hdntzo').value + "&tzval=" + document.getElementById('hdntzval').value);
        }

        else {

            alert('Pls Fill The Chart Detail');
            return false
        }
    }




}

function selectminute(id)
{
   
var a = document.getElementById('minutes_'+8).value;
document.getElementById('minutes_' + 9).value = a;
checkforsec(id); 
   
  }
  
  function selectdegree(id)
   {
  
  
  a = document.getElementById('degree_'+8).value;
  document.getElementById('degree_' + 9).value = a;
  checkforsec(id);
 
  
 }
 
  
  
  
  var str="";
var h1="";

var str1="";
var h2="";

var str2="";
var h3="";



var diff="";

var a="";
     
var housesun="";
var housemercury="";
var housevenus="";
var minutsun="";
var minutmerc="";
var minutvenus="";
var secsun="";
var secmerc="";
var secvenus=""; 
 var hmin="";
var minmunsplit="";
   var newsun="";
 var sundegreenew="";
 var addminutin="";
 var addsecin="";
var finaldegree="";
 var minsecsplit="";
  var venusdegreenew="";
   var merdegreenew="";
  var degsun="";
var degmerc="";
var degvenus="";
var newdiff="";
var venusmin="";
var marsmin="";
 var equql1="";
 var equql2="";
   var equql3="";
  

 function checkforsec(id)
 {

 


 housesun=document.getElementById('house_1').value;
 housemercury=document.getElementById('house_4').value;
 housevenus=document.getElementById('house_6').value;

 str=housesun;
 h1=str.slice(5);

 str1=housemercury;
 h2=str1.slice(5);

 str2=housevenus;
 h3=str2.slice(5);

 degsun=document.getElementById('degree_1').value;
 degmerc=document.getElementById('degree_4').value;
 degvenus=document.getElementById('degree_6').value;
 minutsun=document.getElementById('minutes_1').value;
 minutmerc=document.getElementById('minutes_4').value;
 minutvenus=document.getElementById('minutes_6').value;
 secsun=document.getElementById('seconds_1').value;
 secmerc=document.getElementById('seconds_4').value;
secvenus=document.getElementById('seconds_6').value;



if (id == 'seconds_4' || id == 'degree_4' || id == 'minutes_4')
{
    housesun = document.getElementById('house_1').value;
    housemercury = document.getElementById('house_4').value;
    housevenus = document.getElementById('house_6').value;

    str = housesun;
    h1 = str.slice(5);

    str1 = housemercury;
    h2 = str1.slice(5);

    str2 = housevenus;
    h3 = str2.slice(5);
    degsun=document.getElementById('degree_1').value;
 degmerc=document.getElementById('degree_4').value;
 degvenus=document.getElementById('degree_6').value;
 minutsun=document.getElementById('minutes_1').value;
 minutmerc=document.getElementById('minutes_4').value;
 minutvenus=document.getElementById('minutes_6').value;
 secsun=document.getElementById('seconds_1').value;
 secmerc=document.getElementById('seconds_4').value;
secvenus=document.getElementById('seconds_6').value;

  if(parseInt(h1)<parseInt(h2))
   {
   hmin=((h2-h1)-1)*30;   
    minsecsplit=parseInt(60)-parseInt(secsun);    
    minmunsplit=parseInt(59)-parseInt(minutsun);   
    newsun=parseInt(29) -parseInt(degsun);      
    
         
     sundegreenew=(parseInt(newsun)+parseInt(hmin));
    
      addsecin=(parseInt(minsecsplit)+parseInt(secmerc));
       if(addsecin>59)       
      {  
       addsecin=parseInt(addsecin)-parseInt(59);
      if(addsecin>1 || addsecin<60)
         {
      addsecin=parseInt(1);
        }
      

      
      minmunsplit=(parseInt(minmunsplit)+parseInt(addsecin));
      addsecin=59;
       }
        
       addminutin=(parseInt(minmunsplit)+parseInt(minutmerc));
       
       if(addminutin>59)
       {       
     addminutin=parseInt(addminutin)-parseInt(59);
      
      if(addminutin>1 || addminutin<60)
         {
      addminutin=parseInt(1);
        }
      

     
       sundegreenew=parseInt(sundegreenew)+parseInt(addminutin);
       addminutin=59;
      }

      finaldegree=(parseInt(sundegreenew)+parseInt(degmerc));
    
      newdiff=finaldegree+'.'+addminutin+'.'+addsecin;
      document.getElementById('Hnewdiffm').value = newdiff;

     
   
   // alert(newdiff);
     minutsun="";
 minutmerc="";
 minutvenus="";
 secsun="";
 secmerc="";
 secvenus=""; 
 hmin="";
 minmunsplit="";
   newsun="";
 sundegreenew="";
 addminutin="";
  addsecin="";
 finaldegree="";
 minsecsplit="";
  venusdegreenew="";
  merdegreenew="";
 degsun="";
 degmerc="";
 degvenus="";
 
 venusmin="";
 marsmin="";
  equql1="";
     equql2="";
     equql3="";
     h1 = "";
     h2 = "";
     h3 = "";
     
     
      housesun = document.getElementById('house_1').value;
    housemercury = document.getElementById('house_4').value;
    housevenus = document.getElementById('house_6').value;

    str = housesun;
    h1 = str.slice(5);

    str1 = housemercury;
    h2 = str1.slice(5);

    str2 = housevenus;
    h3 = str2.slice(5);
    degsun=document.getElementById('degree_1').value;
 degmerc=document.getElementById('degree_4').value;
 degvenus=document.getElementById('degree_6').value;
 minutsun=document.getElementById('minutes_1').value;
 minutmerc=document.getElementById('minutes_4').value;
 minutvenus=document.getElementById('minutes_6').value;
 secsun=document.getElementById('seconds_1').value;
 secmerc=document.getElementById('seconds_4').value;
secvenus=document.getElementById('seconds_6').value;

   hmin=((parseInt(h1-h2)+12)-1)*30;   
     minsecsplit=parseInt(60)-parseInt(secmerc);    
    minmunsplit=parseInt(59)-parseInt(minutmerc);   
    newsun=parseInt(29) -parseInt(degmerc);      
    
         
    merdegreenew=(parseInt(newsun)+parseInt(hmin));  
  
      addsecin=(parseInt(minsecsplit)+parseInt(secsun));
       if(addsecin>59)       
      {  
       addsecin=parseInt(addsecin)-parseInt(59);
      if(addsecin>1 || addsecin<60)
         {
      addsecin=parseInt(1);
        }   

      minmunsplit=(parseInt(minmunsplit)+parseInt(addsecin));
      addsecin=59;
       }
       
       addminutin=(parseInt(minmunsplit)+parseInt(minutsun));
       
       if(addminutin>59)
       {       
     addminutin=parseInt(addminutin)-parseInt(59);
      
      if(addminutin>1 || addminutin<60)
         {
      addminutin=parseInt(1);
        }  
  
     
       merdegreenew=parseInt(merdegreenew)+parseInt(addminutin);
       addminutin=59;
      }

      finaldegree=(parseInt(merdegreenew)+parseInt(degsun));
     
      newdiff1=finaldegree+'.'+addminutin+'.'+addsecin;
      document.getElementById('Hnewdiffm1').value = newdiff1;

      if (parseFloat(newdiff) > parseFloat('28.00.00') && parseFloat(newdiff1) > parseFloat('28.00.00') )
    {
    alert('Sun and Merucry can not have more than 28 degree difference.')
    }
    
    
   
         minutsun="";
 minutmerc="";
 minutvenus="";
 secsun="";
 secmerc="";
 secvenus=""; 
 hmin="";
 minmunsplit="";
   newsun="";
 sundegreenew="";
 addminutin="";
  addsecin="";
 finaldegree="";
 minsecsplit="";
  venusdegreenew="";
  merdegreenew="";
 degsun="";
 degmerc="";
 degvenus="";
 
 venusmin="";
 marsmin="";
  equql1="";
     equql2="";
     equql3="";
     h1 = "";
     h2 = "";
     h3 = "";
    }      
   
  
  
  
 
 
if(parseInt(h1)>parseInt(h2)) {


    housesun = document.getElementById('house_1').value;
    housemercury = document.getElementById('house_4').value;
    housevenus = document.getElementById('house_6').value;

    str = housesun;
    h1 = str.slice(5);

    str1 = housemercury;
    h2 = str1.slice(5);

    str2 = housevenus;
    h3 = str2.slice(5);
    degsun=document.getElementById('degree_1').value;
 degmerc=document.getElementById('degree_4').value;
 degvenus=document.getElementById('degree_6').value;
 minutsun=document.getElementById('minutes_1').value;
 minutmerc=document.getElementById('minutes_4').value;
 minutvenus=document.getElementById('minutes_6').value;
 secsun=document.getElementById('seconds_1').value;
 secmerc=document.getElementById('seconds_4').value;
secvenus=document.getElementById('seconds_6').value;

   hmin=((h1-h2)-1)*30;   
     minsecsplit=parseInt(60)-parseInt(secmerc);    
    minmunsplit=parseInt(59)-parseInt(minutmerc);   
    newsun=parseInt(29) -parseInt(degmerc);      
    
         
    merdegreenew=(parseInt(newsun)+parseInt(hmin));  
  
      addsecin=(parseInt(minsecsplit)+parseInt(secsun));
       if(addsecin>59)       
      {  
       addsecin=parseInt(addsecin)-parseInt(59);
      if(addsecin>1 || addsecin<60)
         {
      addsecin=parseInt(1);
        }   

      minmunsplit=(parseInt(minmunsplit)+parseInt(addsecin));
      addsecin=59;
       }
       
       addminutin=(parseInt(minmunsplit)+parseInt(minutsun));
       
       if(addminutin>59)
       {       
     addminutin=parseInt(addminutin)-parseInt(59);
      
      if(addminutin>1 || addminutin<60)
         {
      addminutin=parseInt(1);
        }  
  
     
       merdegreenew=parseInt(merdegreenew)+parseInt(addminutin);
       addminutin=59;
      }

      finaldegree=(parseInt(merdegreenew)+parseInt(degsun));
     
      newdiff=finaldegree+'.'+addminutin+'.'+addsecin;
      document.getElementById('Hnewdiffm').value = newdiff;

     
    
    
   
         minutsun="";
 minutmerc="";
 minutvenus="";
 secsun="";
 secmerc="";
 secvenus=""; 
 hmin="";
 minmunsplit="";
   newsun="";
 sundegreenew="";
 addminutin="";
  addsecin="";
 finaldegree="";
 minsecsplit="";
  venusdegreenew="";
  merdegreenew="";
 degsun="";
 degmerc="";
 degvenus="";

 venusmin="";
 marsmin="";
  equql1="";
     equql2="";
     equql3="";
     h1 = "";
     h2 = "";
     h3 = "";
      housesun = document.getElementById('house_1').value;
    housemercury = document.getElementById('house_4').value;
    housevenus = document.getElementById('house_6').value;

    str = housesun;
    h1 = str.slice(5);

    str1 = housemercury;
    h2 = str1.slice(5);

    str2 = housevenus;
    h3 = str2.slice(5);
    degsun=document.getElementById('degree_1').value;
 degmerc=document.getElementById('degree_4').value;
 degvenus=document.getElementById('degree_6').value;
 minutsun=document.getElementById('minutes_1').value;
 minutmerc=document.getElementById('minutes_4').value;
 minutvenus=document.getElementById('minutes_6').value;
 secsun=document.getElementById('seconds_1').value;
 secmerc=document.getElementById('seconds_4').value;
secvenus=document.getElementById('seconds_6').value;

     
     
     hmin=((parseInt(h2-h1)+12)-1)*30;   
    minsecsplit=parseInt(60)-parseInt(secsun);    
    minmunsplit=parseInt(59)-parseInt(minutsun);   
    newsun=parseInt(29) -parseInt(degsun);      
    
         
     sundegreenew=(parseInt(newsun)+parseInt(hmin));
    
      addsecin=(parseInt(minsecsplit)+parseInt(secmerc));
       if(addsecin>59)       
      {  
       addsecin=parseInt(addsecin)-parseInt(59);
      if(addsecin>1 || addsecin<60)
         {
      addsecin=parseInt(1);
        }
      

      
      minmunsplit=(parseInt(minmunsplit)+parseInt(addsecin));
      addsecin=59;
       }
        
       addminutin=(parseInt(minmunsplit)+parseInt(minutmerc));
       
       if(addminutin>59)
       {       
     addminutin=parseInt(addminutin)-parseInt(59);
      
      if(addminutin>1 || addminutin<60)
         {
      addminutin=parseInt(1);
        }
      

     
       sundegreenew=parseInt(sundegreenew)+parseInt(addminutin);
       addminutin=59;
      }

      finaldegree=(parseInt(sundegreenew)+parseInt(degmerc));
    
      newdiff1=finaldegree+'.'+addminutin+'.'+addsecin;
      document.getElementById('Hnewdiffm1').value = newdiff1;

      if (parseFloat(newdiff) > parseFloat('28.00.00') && parseFloat(newdiff1) > parseFloat('28.00.00'))
    {
    alert('Sun and Merucry can not have more than 28 degree difference.')
    }
    
    }      
   
   
   
   
   
   if(parseInt(h2)==parseInt(h1))
   {
       housesun = document.getElementById('house_1').value;
       housemercury = document.getElementById('house_4').value;
       housevenus = document.getElementById('house_6').value;

       str = housesun;
       h1 = str.slice(5);

       str1 = housemercury;
       h2 = str1.slice(5);

       str2 = housevenus;
       h3 = str2.slice(5);
    degsun=document.getElementById('degree_1').value;
 degmerc=document.getElementById('degree_4').value;
 degvenus=document.getElementById('degree_6').value;
 minutsun=document.getElementById('minutes_1').value;
 minutmerc=document.getElementById('minutes_4').value;
 minutvenus=document.getElementById('minutes_6').value;
 secsun=document.getElementById('seconds_1').value;
 secmerc=document.getElementById('seconds_4').value;
secvenus=document.getElementById('seconds_6').value;

  if(degsun>degmerc)
   {
     equql1= parseInt(degsun)-parseInt(degmerc);
     equql2=parseInt(minutsun)-parseInt(minutmerc);
     equql3=parseInt(secsun)-parseInt(secmerc);
   }
   
  if(degsun<degmerc) 
   {
     equql1= parseInt(degmerc)-parseInt(degsun);
     equql2=parseInt(minutmerc)-parseInt(minutsun);
     equql3=parseInt(secmerc)-parseInt(secsun);
   }
   
   newdiff=equql1+'.'+equql2+'.'+equql3;
   document.getElementById('Hnewdiffm').value = newdiff;
    document.getElementById('Hnewdiffm1').value = newdiff;
   if (parseFloat(newdiff) > parseFloat('28.00.00'))
    {
    alert('Sun and Merucry can not have more than 28 degree difference.');
    }
   
    
    
       minutsun="";
 minutmerc="";
 minutvenus="";
 secsun="";
 secmerc="";
 secvenus=""; 
 hmin="";
 minmunsplit="";
   newsun="";
 sundegreenew="";
 addminutin="";
  addsecin="";
 finaldegree="";
 minsecsplit="";
  venusdegreenew="";
  merdegreenew="";
 degsun="";
 degmerc="";
 degvenus="";
 
 venusmin="";
 marsmin="";
  equql1="";
     equql2="";
     equql3="";
     h1 = "";
     h2 = "";
     h3 = "";
   
   }
  }








 if (id == 'seconds_6' || id == 'degree_6' || id == 'minutes_6')
  {
      housesun = document.getElementById('house_1').value;
      housemercury = document.getElementById('house_4').value;
      housevenus = document.getElementById('house_6').value;

      str = housesun;
      h1 = str.slice(5);

      str1 = housemercury;
      h2 = str1.slice(5);

      str2 = housevenus;
      h3 = str2.slice(5);
      
      
      housesun = document.getElementById('house_1').value;
      housemercury = document.getElementById('house_4').value;
      housevenus = document.getElementById('house_6').value;

      str = housesun;
      h1 = str.slice(5);

      str1 = housemercury;
      h2 = str1.slice(5);

      str2 = housevenus;
      h3 = str2.slice(5);
       degsun=document.getElementById('degree_1').value;
 degmerc=document.getElementById('degree_4').value;
 degvenus=document.getElementById('degree_6').value;
 minutsun=document.getElementById('minutes_1').value;
 minutmerc=document.getElementById('minutes_4').value;
 minutvenus=document.getElementById('minutes_6').value;
 secsun=document.getElementById('seconds_1').value;
 secmerc=document.getElementById('seconds_4').value;
secvenus=document.getElementById('seconds_6').value;

 if(parseInt(h1)>parseInt(h3))
   {
   
    hmin=((h1-h3)-1)*30;   
    minsecsplit=parseInt(60)-parseInt(secvenus);    
    minmunsplit=parseInt(59)-parseInt(minutvenus);   
    newsun=parseInt(29) -parseInt(degvenus);


    venusdegreenew = (parseInt(newsun) + parseInt(hmin));
    //alert(venusdegreenew);
    
      addsecin=(parseInt(minsecsplit)+parseInt(secsun));
       if(addsecin>59)       
      {  
       addsecin=parseInt(addsecin)-parseInt(59);
      if(addsecin>1 || addsecin<60)
         {
      addsecin=parseInt(1);
        }           
      minmunsplit=(parseInt(minmunsplit)+parseInt(addsecin));
      addsecin=59;
       }
        
       addminutin=(parseInt(minmunsplit)+parseInt(minutsun));       
       if(addminutin>59)
       {       
     addminutin=parseInt(addminutin)-parseInt(59);      
      if(addminutin>1 || addminutin<60)
         {
      addminutin=parseInt(1);
        }          
       venusdegreenew=parseInt(venusdegreenew)+parseInt(addminutin);
       addminutin=59;
      }
      
       finaldegree=(parseInt(venusdegreenew)+parseInt(degsun));
     
      newdiff=finaldegree+'.'+addminutin+'.'+addsecin;
      document.getElementById('Hnewdiffv').value = newdiff;
      

  //  alert(newdiff);
    
 minutsun="";
 minutmerc="";
 minutvenus="";
 secsun="";
 secmerc="";
 secvenus=""; 
 hmin="";
 minmunsplit="";
   newsun="";
 sundegreenew="";
 addminutin="";
  addsecin="";
 finaldegree="";
 minsecsplit="";
  venusdegreenew="";
  merdegreenew="";
 degsun="";
 degmerc="";
 degvenus="";
 
 venusmin="";
 marsmin="";
  equql1="";
     equql2="";
     equql3 = "";
     h1 = "";
     h2 = "";
     h3 = "";
     
      housesun = document.getElementById('house_1').value;
    housemercury = document.getElementById('house_4').value;
    housevenus = document.getElementById('house_6').value;

    str = housesun;
    h1 = str.slice(5);

    str1 = housemercury;
    h2 = str1.slice(5);

    str2 = housevenus;
    h3 = str2.slice(5);
    
     degsun=document.getElementById('degree_1').value;
 degmerc=document.getElementById('degree_4').value;
 degvenus=document.getElementById('degree_6').value;
 minutsun=document.getElementById('minutes_1').value;
 minutmerc=document.getElementById('minutes_4').value;
 minutvenus=document.getElementById('minutes_6').value;
 secsun=document.getElementById('seconds_1').value;
 secmerc=document.getElementById('seconds_4').value;
secvenus=document.getElementById('seconds_6').value;

   hmin=((parseInt(h3-h1)+12)-1)*30;
   
    minsecsplit=parseInt(60)-parseInt(secsun);    
    minmunsplit=parseInt(59)-parseInt(minutsun);   
    newsun=parseInt(29) -parseInt(degsun);      
    
         
   venusdegreenew=(parseInt(newsun)+parseInt(hmin));
    
      addsecin=(parseInt(minsecsplit)+parseInt(secvenus));
       if(addsecin>59)       
      {  
       addsecin=parseInt(addsecin)-parseInt(59);
      if(addsecin>1 || addsecin<60)
         {
      addsecin=parseInt(1);
        }
           
      minmunsplit=(parseInt(minmunsplit)+parseInt(addsecin));
      addsecin=59;
       }
        
       addminutin=(parseInt(minmunsplit)+parseInt(minutvenus));
       
       if(addminutin>59)
       {       
     addminutin=parseInt(addminutin)-parseInt(59);
      
      if(addminutin>1 || addminutin<60)
         {
      addminutin=parseInt(1);
        }          
       venusdegreenew=parseInt(venusdegreenew)+parseInt(addminutin);
       addminutin=59;
      }
      finaldegree=(parseInt(venusdegreenew)+parseInt(degvenus));    
      newdiff1=finaldegree+'.'+addminutin+'.'+addsecin;
      document.getElementById('Hnewdiffv1').value = newdiff1;
      if (parseFloat(newdiff) > parseFloat('48.00.00') && parseFloat(newdiff1) > parseFloat('48.00.00'))
    {
    alert('Sun and Venus can not have more than 48 degree difference.');
    }
    //alert(newdiff);
     
          minutsun="";
 minutmerc="";
 minutvenus="";
 secsun="";
 secmerc="";
 secvenus=""; 
 hmin="";
 minmunsplit="";
   newsun="";
 sundegreenew="";
 addminutin="";
  addsecin="";
 finaldegree="";
 minsecsplit="";
  venusdegreenew="";
  merdegreenew="";
 degsun="";
 degmerc="";
 degvenus="";

 venusmin="";
 marsmin="";
  equql1="";
     equql2="";
     equql3 = "";
     h1 = "";
     h2 = "";
     h3 = "";
    }      
  
  
    
    
   
if(parseInt(h1)<parseInt(h3)) {


    housesun = document.getElementById('house_1').value;
    housemercury = document.getElementById('house_4').value;
    housevenus = document.getElementById('house_6').value;

    str = housesun;
    h1 = str.slice(5);

    str1 = housemercury;
    h2 = str1.slice(5);

    str2 = housevenus;
    h3 = str2.slice(5);
     degsun=document.getElementById('degree_1').value;
 degmerc=document.getElementById('degree_4').value;
 degvenus=document.getElementById('degree_6').value;
 minutsun=document.getElementById('minutes_1').value;
 minutmerc=document.getElementById('minutes_4').value;
 minutvenus=document.getElementById('minutes_6').value;
 secsun=document.getElementById('seconds_1').value;
 secmerc=document.getElementById('seconds_4').value;
secvenus=document.getElementById('seconds_6').value;

    
   hmin=((h3-h1)-1)*30;
   
    minsecsplit=parseInt(60)-parseInt(secsun);    
    minmunsplit=parseInt(59)-parseInt(minutsun);   
    newsun=parseInt(29) -parseInt(degsun);      
    
         
   venusdegreenew=(parseInt(newsun)+parseInt(hmin));
    
      addsecin=(parseInt(minsecsplit)+parseInt(secvenus));
       if(addsecin>59)       
      {  
       addsecin=parseInt(addsecin)-parseInt(59);
      if(addsecin>1 || addsecin<60)
         {
      addsecin=parseInt(1);
        }
           
      minmunsplit=(parseInt(minmunsplit)+parseInt(addsecin));
      addsecin=59;
       }
        
       addminutin=(parseInt(minmunsplit)+parseInt(minutvenus));
       
       if(addminutin>59)
       {       
     addminutin=parseInt(addminutin)-parseInt(59);
      
      if(addminutin>1 || addminutin<60)
         {
      addminutin=parseInt(1);
        }          
       venusdegreenew=parseInt(venusdegreenew)+parseInt(addminutin);
       addminutin=59;
      }
      finaldegree=(parseInt(venusdegreenew)+parseInt(degvenus));    
      newdiff=finaldegree+'.'+addminutin+'.'+addsecin;
      document.getElementById('Hnewdiffv').value = newdiff;
     
    //alert(newdiff);
     
          minutsun="";
 minutmerc="";
 minutvenus="";
 secsun="";
 secmerc="";
 secvenus=""; 
 hmin="";
 minmunsplit="";
   newsun="";
 sundegreenew="";
 addminutin="";
  addsecin="";
 finaldegree="";
 minsecsplit="";
  venusdegreenew="";
  merdegreenew="";
 degsun="";
 degmerc="";
 degvenus="";
 
 venusmin="";
 marsmin="";
  equql1="";
     equql2="";
     equql3 = "";
     h1 = "";
     h2 = "";
     h3 = "";
     housesun = document.getElementById('house_1').value;
    housemercury = document.getElementById('house_4').value;
    housevenus = document.getElementById('house_6').value;

    str = housesun;
    h1 = str.slice(5);

    str1 = housemercury;
    h2 = str1.slice(5);

    str2 = housevenus;
    h3 = str2.slice(5);
     degsun=document.getElementById('degree_1').value;
 degmerc=document.getElementById('degree_4').value;
 degvenus=document.getElementById('degree_6').value;
 minutsun=document.getElementById('minutes_1').value;
 minutmerc=document.getElementById('minutes_4').value;
 minutvenus=document.getElementById('minutes_6').value;
 secsun=document.getElementById('seconds_1').value;
 secmerc=document.getElementById('seconds_4').value;
secvenus=document.getElementById('seconds_6').value;

      hmin=((parseInt(h1-h3)+12)-1)*30;   
    minsecsplit=parseInt(60)-parseInt(secvenus);    
    minmunsplit=parseInt(59)-parseInt(minutvenus);   
    newsun=parseInt(29) -parseInt(degvenus);


    venusdegreenew = (parseInt(newsun) + parseInt(hmin));
    //alert(venusdegreenew);
    
      addsecin=(parseInt(minsecsplit)+parseInt(secsun));
       if(addsecin>59)       
      {  
       addsecin=parseInt(addsecin)-parseInt(59);
      if(addsecin>1 || addsecin<60)
         {
      addsecin=parseInt(1);
        }           
      minmunsplit=(parseInt(minmunsplit)+parseInt(addsecin));
      addsecin=59;
       }
        
       addminutin=(parseInt(minmunsplit)+parseInt(minutsun));   
           
       if(addminutin>59)
       {       
     addminutin=parseInt(addminutin)-parseInt(59);      
      if(addminutin>1 || addminutin<60)
         {
      addminutin=parseInt(1);
        }          
       venusdegreenew=parseInt(venusdegreenew)+parseInt(addminutin);
       addminutin=59;
      }
      
       finaldegree=(parseInt(venusdegreenew)+parseInt(degsun));
     
      newdiff1=finaldegree+'.'+addminutin+'.'+addsecin;
      document.getElementById('Hnewdiffv1').value = newdiff1;
      if (parseFloat(newdiff) > parseFloat('48.00.00') && parseFloat(newdiff1) > parseFloat('48.00.00'))
    {
    alert('Sun and Venus can not have more than 48 degree difference.');
    }

  //  alert(newdiff);
    
 minutsun="";
 minutmerc="";
 minutvenus="";
 secsun="";
 secmerc="";
 secvenus=""; 
 hmin="";
 minmunsplit="";
   newsun="";
 sundegreenew="";
 addminutin="";
  addsecin="";
 finaldegree="";
 minsecsplit="";
  venusdegreenew="";
  merdegreenew="";
 degsun="";
 degmerc="";
 degvenus="";

 venusmin="";
 marsmin="";
  equql1="";
     equql2="";
     equql3 = "";
     h1 = "";
     h2 = "";
     h3 = "";
     
     
  }
    
    
    
  if(parseInt(h3)==parseInt(h1)) {


      housesun = document.getElementById('house_1').value;
      housemercury = document.getElementById('house_4').value;
      housevenus = document.getElementById('house_6').value;

      str = housesun;
      h1 = str.slice(5);

      str1 = housemercury;
      h2 = str1.slice(5);

      str2 = housevenus;
      h3 = str2.slice(5);
         degsun=document.getElementById('degree_1').value;
 degmerc=document.getElementById('degree_4').value;
 degvenus=document.getElementById('degree_6').value;
 minutsun=document.getElementById('minutes_1').value;
 minutmerc=document.getElementById('minutes_4').value;
 minutvenus=document.getElementById('minutes_6').value;
 secsun=document.getElementById('seconds_1').value;
 secmerc=document.getElementById('seconds_4').value;
secvenus=document.getElementById('seconds_6').value;

      
  if(degsun>degvenus)
   {
     equql1= parseInt(degsun)-parseInt(degvenus);
     equql2=parseInt(minutsun)-parseInt(minutvenus);
     equql3=parseInt(secsun)-parseInt(secvenus);
   }
   
  if(degsun<degvenus) 
   {
     equql1= parseInt(degvenus)-parseInt(degsun);
     equql2=parseInt(minutvenus)-parseInt(minutsun);
     equql3=parseInt(secvenus)-parseInt(secsun);
   }
   
   newdiff=equql1+'.'+equql2+'.'+equql3;
   document.getElementById('Hnewdiffv').value = newdiff;
   document.getElementById('Hnewdiffv1').value = newdiff;
   if (parseFloat(newdiff) > parseFloat('48.00.00'))
    {
    alert('Sun and Venus can not have more than 48 degree difference.')
    }
    //alert(newdiff);
  minutsun="";
 minutmerc="";
 minutvenus="";
 secsun="";
 secmerc="";
 secvenus=""; 
 hmin="";
 minmunsplit="";
   newsun="";
 sundegreenew="";
 addminutin="";
  addsecin="";
 finaldegree="";
 minsecsplit="";
  venusdegreenew="";
  merdegreenew="";
 degsun="";
 degmerc="";
 degvenus="";

 venusmin="";
 marsmin="";
  equql1="";
     equql2="";
     equql3 = "";
     h1 = "";
     h2 = "";
     h3 = "";
   }
   
}
if (id == 'seconds_1' || id == 'degree_1' || id == 'minutes_1') {
    if (document.getElementById('house_4').selectedIndex == 0 || document.getElementById('house_6').selectedIndex == 0)
    { }
    else {
        if (parseInt(h1) <parseInt(h2)) {

            housesun = document.getElementById('house_1').value;
            housemercury = document.getElementById('house_4').value;
            housevenus = document.getElementById('house_6').value;

            str = housesun;
            h1 = str.slice(5);

            str1 = housemercury;
            h2 = str1.slice(5);

            str2 = housevenus;
            h3 = str2.slice(5);

   degsun=document.getElementById('degree_1').value;
 degmerc=document.getElementById('degree_4').value;
 degvenus=document.getElementById('degree_6').value;
 minutsun=document.getElementById('minutes_1').value;
 minutmerc=document.getElementById('minutes_4').value;
 minutvenus=document.getElementById('minutes_6').value;
 secsun=document.getElementById('seconds_1').value;
 secmerc=document.getElementById('seconds_4').value;
secvenus=document.getElementById('seconds_6').value;

            hmin = ((h2 - h1) - 1) * 30;
            minsecsplit = parseInt(60) - parseInt(secsun);
            minmunsplit = parseInt(59) - parseInt(minutsun);
            newsun = parseInt(29) - parseInt(degsun);


            sundegreenew = (parseInt(newsun) + parseInt(hmin));

            addsecin = (parseInt(minsecsplit) + parseInt(secmerc));
            if (addsecin > 59) {
                addsecin = parseInt(addsecin) - parseInt(59);
                if (addsecin > 1 || addsecin < 60) {
                    addsecin = parseInt(1);
                }



                minmunsplit = (parseInt(minmunsplit) + parseInt(addsecin));
                addsecin = 59;
            }

            addminutin = (parseInt(minmunsplit) + parseInt(minutmerc));

            if (addminutin > 59)
            {
                addminutin = parseInt(addminutin) - parseInt(59);

                if (addminutin > 1 || addminutin < 60) {
                    addminutin = parseInt(1);
                }



                sundegreenew = parseInt(sundegreenew) + parseInt(addminutin);
                addminutin = 59;
            }

            finaldegree = (parseInt(sundegreenew) + parseInt(degmerc));

            newdiff = finaldegree + '.' + addminutin + '.' + addsecin;
            document.getElementById('Hnewdiffm').value = newdiff;

           


            minutsun = "";
            minutmerc = "";
            minutvenus = "";
            secsun = "";
            secmerc = "";
            secvenus = "";
            hmin = "";
            minmunsplit = "";
            newsun = "";
            sundegreenew = "";
            addminutin = "";
            addsecin = "";
            finaldegree = "";
            minsecsplit = "";
            venusdegreenew = "";
            merdegreenew = "";
            degsun = "";
            degmerc = "";
            degvenus = "";
           
            venusmin = "";
            marsmin = "";
            equql1 = "";
            equql2 = "";
            equql3 = "";
            h1 = "";
            h2 = "";
            h3 = "";
            
            housesun = document.getElementById('house_1').value;
            housemercury = document.getElementById('house_4').value;
            housevenus = document.getElementById('house_6').value;

            str = housesun;
            h1 = str.slice(5);

            str1 = housemercury;
            h2 = str1.slice(5);

            str2 = housevenus;
            h3 = str2.slice(5);
   degsun=document.getElementById('degree_1').value;
 degmerc=document.getElementById('degree_4').value;
 degvenus=document.getElementById('degree_6').value;
 minutsun=document.getElementById('minutes_1').value;
 minutmerc=document.getElementById('minutes_4').value;
 minutvenus=document.getElementById('minutes_6').value;
 secsun=document.getElementById('seconds_1').value;
 secmerc=document.getElementById('seconds_4').value;
secvenus=document.getElementById('seconds_6').value;


            hmin = ((parseInt(h1 - h2)+12) - 1) * 30;
            minsecsplit = parseInt(60) - parseInt(secmerc);
            minmunsplit = parseInt(59) - parseInt(minutmerc);
            newsun = parseInt(29) - parseInt(degmerc);


            merdegreenew = (parseInt(newsun) + parseInt(hmin));

            addsecin = (parseInt(minsecsplit) + parseInt(secsun));
            if (addsecin > 59) {
                addsecin = parseInt(addsecin) - parseInt(59);
                if (addsecin > 1 || addsecin < 60) {
                    addsecin = parseInt(1);
                }

                minmunsplit = (parseInt(minmunsplit) + parseInt(addsecin));
                addsecin = 59;
            }

            addminutin = (parseInt(minmunsplit) + parseInt(minutsun));

            if (addminutin > 59)
            {
                addminutin = parseInt(addminutin) - parseInt(59);

                if (addminutin > 1 || addminutin < 60) {
                    addminutin = parseInt(1);
                }


                merdegreenew = parseInt(merdegreenew) + parseInt(addminutin);
                addminutin = 59;
            }

            finaldegree = (parseInt(merdegreenew) + parseInt(degsun));

            newdiff1 = finaldegree + '.' + addminutin + '.' + addsecin;
            document.getElementById('Hnewdiffm1').value = newdiff1;

            if (parseFloat(newdiff) > parseFloat('28.00.00') && parseFloat(newdiff1) > parseFloat('28.00.00') ) {
                alert('Sun and Merucry can not have more than 28 degree difference.')
            }



            minutsun = "";
            minutmerc = "";
            minutvenus = "";
            secsun = "";
            secmerc = "";
            secvenus = "";
            hmin = "";
            minmunsplit = "";
            newsun = "";
            sundegreenew = "";
            addminutin = "";
            addsecin = "";
            finaldegree = "";
            minsecsplit = "";
            venusdegreenew = "";
            merdegreenew = "";
            degsun = "";
            degmerc = "";
            degvenus = "";
           
            venusmin = "";
            marsmin = "";
            equql1 = "";
            equql2 = "";
            equql3 = "";
            h1 = "";
            h2 = "";
            h3 = "";

        }






        if (parseInt(h1) >parseInt(h2)) {

            housesun = document.getElementById('house_1').value;
            housemercury = document.getElementById('house_4').value;
            housevenus = document.getElementById('house_6').value;

            str = housesun;
            h1 = str.slice(5);

            str1 = housemercury;
            h2 = str1.slice(5);

            str2 = housevenus;
            h3 = str2.slice(5);

   degsun=document.getElementById('degree_1').value;
 degmerc=document.getElementById('degree_4').value;
 degvenus=document.getElementById('degree_6').value;
 minutsun=document.getElementById('minutes_1').value;
 minutmerc=document.getElementById('minutes_4').value;
 minutvenus=document.getElementById('minutes_6').value;
 secsun=document.getElementById('seconds_1').value;
 secmerc=document.getElementById('seconds_4').value;
secvenus=document.getElementById('seconds_6').value;

            hmin = ((h1 - h2) - 1) * 30;
            minsecsplit = parseInt(60) - parseInt(secmerc);
            minmunsplit = parseInt(59) - parseInt(minutmerc);
            newsun = parseInt(29) - parseInt(degmerc);


            merdegreenew = (parseInt(newsun) + parseInt(hmin));

            addsecin = (parseInt(minsecsplit) + parseInt(secsun));
            if (addsecin > 59) {
                addsecin = parseInt(addsecin) - parseInt(59);
                if (addsecin > 1 || addsecin < 60) {
                    addsecin = parseInt(1);
                }

                minmunsplit = (parseInt(minmunsplit) + parseInt(addsecin));
                addsecin = 59;
            }

            addminutin = (parseInt(minmunsplit) + parseInt(minutsun));

            if (addminutin > 59)
            {
                addminutin = parseInt(addminutin) - parseInt(59);

                if (addminutin > 1 || addminutin < 60) {
                    addminutin = parseInt(1);
                }


                merdegreenew = parseInt(merdegreenew) + parseInt(addminutin);
                addminutin = 59;
            }

            finaldegree = (parseInt(merdegreenew) + parseInt(degsun));

            newdiff = finaldegree + '.' + addminutin + '.' + addsecin;
            document.getElementById('Hnewdiffm').value = newdiff;

          


            minutsun = "";
            minutmerc = "";
            minutvenus = "";
            secsun = "";
            secmerc = "";
            secvenus = "";
            hmin = "";
            minmunsplit = "";
            newsun = "";
            sundegreenew = "";
            addminutin = "";
            addsecin = "";
            finaldegree = "";
            minsecsplit = "";
            venusdegreenew = "";
            merdegreenew = "";
            degsun = "";
            degmerc = "";
            degvenus = "";
           
            venusmin = "";
            marsmin = "";
            equql1 = "";
            equql2 = "";
            equql3 = "";
            h1 = "";
            h2 = "";
            h3 = "";

 housesun = document.getElementById('house_1').value;
            housemercury = document.getElementById('house_4').value;
            housevenus = document.getElementById('house_6').value;

            str = housesun;
            h1 = str.slice(5);

            str1 = housemercury;
            h2 = str1.slice(5);

            str2 = housevenus;
            h3 = str2.slice(5);

   degsun=document.getElementById('degree_1').value;
 degmerc=document.getElementById('degree_4').value;
 degvenus=document.getElementById('degree_6').value;
 minutsun=document.getElementById('minutes_1').value;
 minutmerc=document.getElementById('minutes_4').value;
 minutvenus=document.getElementById('minutes_6').value;
 secsun=document.getElementById('seconds_1').value;
 secmerc=document.getElementById('seconds_4').value;
secvenus=document.getElementById('seconds_6').value;

            hmin = ((parseInt(h2 - h1)+12) - 1) * 30;
            minsecsplit = parseInt(60) - parseInt(secsun);
            minmunsplit = parseInt(59) - parseInt(minutsun);
            newsun = parseInt(29) - parseInt(degsun);


            sundegreenew = (parseInt(newsun) + parseInt(hmin));

            addsecin = (parseInt(minsecsplit) + parseInt(secmerc));
            if (addsecin > 59) {
                addsecin = parseInt(addsecin) - parseInt(59);
                if (addsecin > 1 || addsecin < 60) {
                    addsecin = parseInt(1);
                }



                minmunsplit = (parseInt(minmunsplit) + parseInt(addsecin));
                addsecin = 59;
            }

            addminutin = (parseInt(minmunsplit) + parseInt(minutmerc));

            if (addminutin > 59)
            {
                addminutin = parseInt(addminutin) - parseInt(59);

                if (addminutin > 1 || addminutin < 60) {
                    addminutin = parseInt(1);
                }



                sundegreenew = parseInt(sundegreenew) + parseInt(addminutin);
                addminutin = 59;
            }

            finaldegree = (parseInt(sundegreenew) + parseInt(degmerc));

            newdiff1 = finaldegree + '.' + addminutin + '.' + addsecin;
            document.getElementById('Hnewdiffm1').value = newdiff1;

            if (parseFloat(newdiff) > parseFloat('28.00.00') && parseFloat(newdiff1) > parseFloat('28.00.00')) {
                alert('Sun and Merucry can not have more than 28 degree difference.')
            }


            minutsun = "";
            minutmerc = "";
            minutvenus = "";
            secsun = "";
            secmerc = "";
            secvenus = "";
            hmin = "";
            minmunsplit = "";
            newsun = "";
            sundegreenew = "";
            addminutin = "";
            addsecin = "";
            finaldegree = "";
            minsecsplit = "";
            venusdegreenew = "";
            merdegreenew = "";
            degsun = "";
            degmerc = "";
            degvenus = "";
           
            venusmin = "";
            marsmin = "";
            equql1 = "";
            equql2 = "";
            equql3 = "";
            h1 = "";
            h2 = "";
            h3 = "";
        }





        if (parseInt(h2) == parseInt(h1)) {
            housesun = document.getElementById('house_1').value;
            housemercury = document.getElementById('house_4').value;
            housevenus = document.getElementById('house_6').value;

            str = housesun;
            h1 = str.slice(5);

            str1 = housemercury;
            h2 = str1.slice(5);

            str2 = housevenus;
            h3 = str2.slice(5);


   degsun=document.getElementById('degree_1').value;
 degmerc=document.getElementById('degree_4').value;
 degvenus=document.getElementById('degree_6').value;
 minutsun=document.getElementById('minutes_1').value;
 minutmerc=document.getElementById('minutes_4').value;
 minutvenus=document.getElementById('minutes_6').value;
 secsun=document.getElementById('seconds_1').value;
 secmerc=document.getElementById('seconds_4').value;
secvenus=document.getElementById('seconds_6').value;

            if (degsun > degmerc) {
                equql1 = parseInt(degsun) - parseInt(degmerc);
                //     equql2=parseInt(minutsun)-parseInt(minutmerc);
                //     equql3=parseInt(secsun)-parseInt(secmerc);
            }

            if (degsun < degmerc) {
                equql1 = parseInt(degmerc) - parseInt(degsun);
                //     equql2=parseInt(minutmerc)-parseInt(minutsun);
                //     equql3=parseInt(secmerc)-parseInt(secsun);
            }

            newdiff = equql1;
            document.getElementById('Hnewdiffm').value = newdiff;
             document.getElementById('Hnewdiffm1').value = newdiff;
            if (parseFloat(newdiff) > parseFloat('28.00.00')) {
                alert('Sun and Merucry can not have more than 28 degree difference.');
            }


            minutsun = "";
            minutmerc = "";
            minutvenus = "";
            secsun = "";
            secmerc = "";
            secvenus = "";
            hmin = "";
            minmunsplit = "";
            newsun = "";
            sundegreenew = "";
            addminutin = "";
            addsecin = "";
            finaldegree = "";
            minsecsplit = "";
            venusdegreenew = "";
            merdegreenew = "";
            degsun = "";
            degmerc = "";
            degvenus = "";
           
            venusmin = "";
            marsmin = "";
            equql1 = "";
            equql2 = "";
            equql3 = "";
            h1 = "";
            h2 = "";
            h3 = "";


        }
  housesun = document.getElementById('house_1').value;
            housemercury = document.getElementById('house_4').value;
            housevenus = document.getElementById('house_6').value;

            str = housesun;
            h1 = str.slice(5);

            str1 = housemercury;
            h2 = str1.slice(5);

            str2 = housevenus;
            h3 = str2.slice(5);
        degsun = document.getElementById('degree_1').value;
        degmerc = document.getElementById('degree_4').value;
        degvenus = document.getElementById('degree_6').value;
        minutsun = document.getElementById('minutes_1').value;
        minutmerc = document.getElementById('minutes_4').value;
        minutvenus = document.getElementById('minutes_6').value;
        secsun = document.getElementById('seconds_1').value;
        secmerc = document.getElementById('seconds_4').value;
        secvenus = document.getElementById('seconds_6').value;

        if (parseInt(h1) >parseInt(h3)) {


            housesun = document.getElementById('house_1').value;
            housemercury = document.getElementById('house_4').value;
            housevenus = document.getElementById('house_6').value;

            str = housesun;
            h1 = str.slice(5);

            str1 = housemercury;
            h2 = str1.slice(5);

            str2 = housevenus;
            h3 = str2.slice(5);
   degsun=document.getElementById('degree_1').value;
 degmerc=document.getElementById('degree_4').value;
 degvenus=document.getElementById('degree_6').value;
 minutsun=document.getElementById('minutes_1').value;
 minutmerc=document.getElementById('minutes_4').value;
 minutvenus=document.getElementById('minutes_6').value;
 secsun=document.getElementById('seconds_1').value;
 secmerc=document.getElementById('seconds_4').value;
secvenus=document.getElementById('seconds_6').value;


            hmin = ((h1 - h3) - 1) * 30;
            minsecsplit = parseInt(60) - parseInt(secvenus);
            minmunsplit = parseInt(59) - parseInt(minutvenus);
            newsun = parseInt(29) - parseInt(degvenus);


            venusdegreenew = (parseInt(newsun) + parseInt(hmin));

            addsecin = (parseInt(minsecsplit) + parseInt(secsun));
            if (addsecin > 59) {
                addsecin = parseInt(addsecin) - parseInt(59);
                if (addsecin > 1 || addsecin < 60) {
                    addsecin = parseInt(1);
                }
                minmunsplit = (parseInt(minmunsplit) + parseInt(addsecin));
                addsecin = 59;
            }

            addminutin = (parseInt(minmunsplit) + parseInt(minutsun));
            if (addminutin > 59)
            {
                addminutin = parseInt(addminutin) - parseInt(59);
                if (addminutin > 1 || addminutin < 60) {
                    addminutin = parseInt(1);
                }
                venusdegreenew = parseInt(venusdegreenew) + parseInt(addminutin);
                addminutin = 59;
            }

            finaldegree = (parseInt(venusdegreenew) + parseInt(degsun));

            newdiff = finaldegree + '.' + addminutin + '.' + addsecin;
            document.getElementById('Hnewdiffv').value = newdiff;
           



            minutsun = "";
            minutmerc = "";
            minutvenus = "";
            secsun = "";
            secmerc = "";
            secvenus = "";
            hmin = "";
            minmunsplit = "";
            newsun = "";
            sundegreenew = "";
            addminutin = "";
            addsecin = "";
            finaldegree = "";
            minsecsplit = "";
            venusdegreenew = "";
            merdegreenew = "";
            degsun = "";
            degmerc = "";
            degvenus = "";
            
            venusmin = "";
            marsmin = "";
            equql1 = "";
            equql2 = "";
            equql3 = "";
            h1 = "";
            h2 = "";
            h3 = "";
            
             housesun = document.getElementById('house_1').value;
            housemercury = document.getElementById('house_4').value;
            housevenus = document.getElementById('house_6').value;

            str = housesun;
            h1 = str.slice(5);

            str1 = housemercury;
            h2 = str1.slice(5);

            str2 = housevenus;
            h3 = str2.slice(5);

   degsun=document.getElementById('degree_1').value;
 degmerc=document.getElementById('degree_4').value;
 degvenus=document.getElementById('degree_6').value;
 minutsun=document.getElementById('minutes_1').value;
 minutmerc=document.getElementById('minutes_4').value;
 minutvenus=document.getElementById('minutes_6').value;
 secsun=document.getElementById('seconds_1').value;
 secmerc=document.getElementById('seconds_4').value;
secvenus=document.getElementById('seconds_6').value;

            hmin = ((parseInt(h3 - h1)+12) - 1) * 30;

            minsecsplit = parseInt(60) - parseInt(secsun);
            minmunsplit = parseInt(59) - parseInt(minutsun);
            newsun = parseInt(29) - parseInt(degsun);



            venusdegreenew = (parseInt(newsun) + parseInt(hmin));




            addsecin = (parseInt(minsecsplit) + parseInt(secvenus));
            if (addsecin > 59) {
                addsecin = parseInt(addsecin) - parseInt(59);
                if (addsecin > 1 || addsecin < 60) {
                    addsecin = parseInt(1);
                }


                minmunsplit = (parseInt(minmunsplit) + parseInt(addsecin));
                addsecin = 59;
            }

            addminutin = (parseInt(minmunsplit) + parseInt(minutvenus));

            if (addminutin > 59)
            {
                addminutin = parseInt(addminutin) - parseInt(59);

                if (addminutin > 1 || addminutin < 60) {
                    addminutin = parseInt(1);
                }
                venusdegreenew = parseInt(venusdegreenew) + parseInt(addminutin);
                addminutin = 59;
            }
            finaldegree = (parseInt(venusdegreenew) + parseInt(degvenus));
            newdiff1 = finaldegree + '.' + addminutin + '.' + addsecin;
            document.getElementById('Hnewdiffv1').value = newdiff1;
            if (parseFloat(newdiff) > parseFloat('48.00.00') && parseFloat(newdiff1) > parseFloat('48.00.00')) {
                alert('Sun and Venus can not have more than 48 degree difference.');
            }


            minutsun = "";
            minutmerc = "";
            minutvenus = "";
            secsun = "";
            secmerc = "";
            secvenus = "";
            hmin = "";
            minmunsplit = "";
            newsun = "";
            sundegreenew = "";
            addminutin = "";
            addsecin = "";
            finaldegree = "";
            minsecsplit = "";
            venusdegreenew = "";
            merdegreenew = "";
            degsun = "";
            degmerc = "";
            degvenus = "";
           
            venusmin = "";
            marsmin = "";
            equql1 = "";
            equql2 = "";
            equql3 = "";
            h1 = "";
            h2 = "";
            h3 = "";
        }





        if (parseInt(h1)<(h3)) {

            housesun = document.getElementById('house_1').value;
            housemercury = document.getElementById('house_4').value;
            housevenus = document.getElementById('house_6').value;

            str = housesun;
            h1 = str.slice(5);

            str1 = housemercury;
            h2 = str1.slice(5);

            str2 = housevenus;
            h3 = str2.slice(5);

   degsun=document.getElementById('degree_1').value;
 degmerc=document.getElementById('degree_4').value;
 degvenus=document.getElementById('degree_6').value;
 minutsun=document.getElementById('minutes_1').value;
 minutmerc=document.getElementById('minutes_4').value;
 minutvenus=document.getElementById('minutes_6').value;
 secsun=document.getElementById('seconds_1').value;
 secmerc=document.getElementById('seconds_4').value;
secvenus=document.getElementById('seconds_6').value;

            hmin = ((h3 - h1) - 1) * 30;

            minsecsplit = parseInt(60) - parseInt(secsun);
            minmunsplit = parseInt(59) - parseInt(minutsun);
            newsun = parseInt(29) - parseInt(degsun);



            venusdegreenew = (parseInt(newsun) + parseInt(hmin));




            addsecin = (parseInt(minsecsplit) + parseInt(secvenus));
            if (addsecin > 59) {
                addsecin = parseInt(addsecin) - parseInt(59);
                if (addsecin > 1 || addsecin < 60) {
                    addsecin = parseInt(1);
                }


                minmunsplit = (parseInt(minmunsplit) + parseInt(addsecin));
                addsecin = 59;
            }

            addminutin = (parseInt(minmunsplit) + parseInt(minutvenus));

            if (addminutin > 59)
            {
                addminutin = parseInt(addminutin) - parseInt(59);

                if (addminutin > 1 || addminutin < 60) {
                    addminutin = parseInt(1);
                }
                venusdegreenew = parseInt(venusdegreenew) + parseInt(addminutin);
                addminutin = 59;
            }
            finaldegree = (parseInt(venusdegreenew) + parseInt(degvenus));
            newdiff = finaldegree + '.' + addminutin + '.' + addsecin;
            document.getElementById('Hnewdiffv').value = newdiff;
           

            minutsun = "";
            minutmerc = "";
            minutvenus = "";
            secsun = "";
            secmerc = "";
            secvenus = "";
            hmin = "";
            minmunsplit = "";
            newsun = "";
            sundegreenew = "";
            addminutin = "";
            addsecin = "";
            finaldegree = "";
            minsecsplit = "";
            venusdegreenew = "";
            merdegreenew = "";
            degsun = "";
            degmerc = "";
            degvenus = "";
           
            venusmin = "";
            marsmin = "";
            equql1 = "";
            equql2 = "";
            equql3 = "";
            h1 = "";
            h2 = "";
            h3 = "";
            
               housesun = document.getElementById('house_1').value;
            housemercury = document.getElementById('house_4').value;
            housevenus = document.getElementById('house_6').value;

            str = housesun;
            h1 = str.slice(5);

            str1 = housemercury;
            h2 = str1.slice(5);

            str2 = housevenus;
            h3 = str2.slice(5);
   degsun=document.getElementById('degree_1').value;
 degmerc=document.getElementById('degree_4').value;
 degvenus=document.getElementById('degree_6').value;
 minutsun=document.getElementById('minutes_1').value;
 minutmerc=document.getElementById('minutes_4').value;
 minutvenus=document.getElementById('minutes_6').value;
 secsun=document.getElementById('seconds_1').value;
 secmerc=document.getElementById('seconds_4').value;
secvenus=document.getElementById('seconds_6').value;


            hmin = ((parseInt(h1 - h3)+12) - 1) * 30;
            minsecsplit = parseInt(60) - parseInt(secvenus);
            minmunsplit = parseInt(59) - parseInt(minutvenus);
            newsun = parseInt(29) - parseInt(degvenus);


            venusdegreenew = (parseInt(newsun) + parseInt(hmin));

            addsecin = (parseInt(minsecsplit) + parseInt(secsun));
            if (addsecin > 59) {
                addsecin = parseInt(addsecin) - parseInt(59);
                if (addsecin > 1 || addsecin < 60) {
                    addsecin = parseInt(1);
                }
                minmunsplit = (parseInt(minmunsplit) + parseInt(addsecin));
                addsecin = 59;
            }

            addminutin = (parseInt(minmunsplit) + parseInt(minutsun));
            if (addminutin > 59)
            {
                addminutin = parseInt(addminutin) - parseInt(59);
                if (addminutin > 1 || addminutin < 60) {
                    addminutin = parseInt(1);
                }
                venusdegreenew = parseInt(venusdegreenew) + parseInt(addminutin);
                addminutin = 59;
            }

            finaldegree = (parseInt(venusdegreenew) + parseInt(degsun));

            newdiff1 = finaldegree + '.' + addminutin + '.' + addsecin;
            document.getElementById('Hnewdiffv1').value = newdiff1;
            if (parseFloat(newdiff) > parseFloat('48.00.00') && parseFloat(newdiff1) > parseFloat('48.00.00')) {
                alert('Sun and Venus can not have more than 48 degree difference.');
            }



            minutsun = "";
            minutmerc = "";
            minutvenus = "";
            secsun = "";
            secmerc = "";
            secvenus = "";
            hmin = "";
            minmunsplit = "";
            newsun = "";
            sundegreenew = "";
            addminutin = "";
            addsecin = "";
            finaldegree = "";
            minsecsplit = "";
            venusdegreenew = "";
            merdegreenew = "";
            degsun = "";
            degmerc = "";
            degvenus = "";
            
            venusmin = "";
            marsmin = "";
            equql1 = "";
            equql2 = "";
            equql3 = "";
            h1 = "";
            h2 = "";
            h3 = "";
        }



        if (parseInt(h3)==parseInt(h1)) {

            housesun = document.getElementById('house_1').value;
            housemercury = document.getElementById('house_4').value;
            housevenus = document.getElementById('house_6').value;

            str = housesun;
            h1 = str.slice(5);

            str1 = housemercury;
            h2 = str1.slice(5);

            str2 = housevenus;
            h3 = str2.slice(5);

   degsun=document.getElementById('degree_1').value;
 degmerc=document.getElementById('degree_4').value;
 degvenus=document.getElementById('degree_6').value;
 minutsun=document.getElementById('minutes_1').value;
 minutmerc=document.getElementById('minutes_4').value;
 minutvenus=document.getElementById('minutes_6').value;
 secsun=document.getElementById('seconds_1').value;
 secmerc=document.getElementById('seconds_4').value;
secvenus=document.getElementById('seconds_6').value;

            if (degsun > degvenus) {
                equql3 = parseInt(secsun) - parseInt(secvenus);
                equql2 = parseInt(minutsun) - parseInt(minutvenus);
                equql1 = parseInt(degsun) - parseInt(degvenus);


            }

            if (degsun < degvenus) {
                equql1 = parseInt(degvenus) - parseInt(degsun);
                equql2 = parseInt(minutvenus) - parseInt(minutsun);
                equql3 = parseInt(secvenus) - parseInt(secsun);
            }

            newdiff = equql1 + '.' + equql2 + '.' + equql3;
            document.getElementById('Hnewdiffv').value = newdiff;
            document.getElementById('Hnewdiffv1').value = newdiff;
            if (parseFloat(newdiff) > parseFloat('48.00.00')) {
                alert('Sun and Venus can not have more than 48 degree difference.')
            }

            minutsun = "";
            minutmerc = "";
            minutvenus = "";
            secsun = "";
            secmerc = "";
            secvenus = "";
            hmin = "";
            minmunsplit = "";
            newsun = "";
            sundegreenew = "";
            addminutin = "";
            addsecin = "";
            finaldegree = "";
            minsecsplit = "";
            venusdegreenew = "";
            merdegreenew = "";
            degsun = "";
            degmerc = "";
            degvenus = "";
            
            venusmin = "";
            marsmin = "";
            equql1 = "";
            equql2 = "";
            equql3 = "";
            h1 = "";
            h2 = "";
            h3 = "";

        }



    }
}
return false;
  }
  
  

 function enablerashi(id)
 {
   if(document.getElementById('rashi_0').selectedIndex==0)
   {
    for (var i =1; i <=9; i++)
    {
     document.getElementById('rashi_'+i).disabled=true;
    }
   }
    else 
    {
      for (var i =1; i <=10; i++)
      {
      document.getElementById('rashi_'+i).disabled=false;
      }
      document.getElementById('rashi_9').disabled = true;
    }
 }
  
  
  function searchclientid()
  {
  
  var clientname =document.getElementById('Hclmail').value;
  var astroname=document.getElementById('Hastname').value;
  var astid1=document.getElementById('Hastmail').value;
  var exec = homenewpage.searchclientid(clientname, astroname, astid1, document.getElementById('hdngroup').value, document.getElementById('hdngroup_u').value,'');
  var ds=exec.value;
  
  if(ds.Tables[1].Rows.length > 0)
  {
  var ds1=ds.Tables[1].Rows[0].HOROSCOPE_D01;
  ds1=ds1.slice(0,-1);
   var id1 = ds1.split('~')
   for(i=0; i<id1.length; i++){
    var id2 =id1[i].split('/')
    document.getElementById('rashi_'+ i).value=id2[1];
    document.getElementById('house_'+ i ).value=id2[2];
    
    var id3 =id2[3].split('.')
    document.getElementById('degree_'+ i ).value=id3[0];
   document.getElementById('minutes_'+ i ).value=id3[1];
   document.getElementById('seconds_' + i).value = id3[2];
   document.getElementById('retrograde_' + i).value = id2[4];
    document.getElementById('constelation_'+ i ).value=id2[5];
    }
    }
    else{
    for(i=0; i<11;i++){
     
      document.getElementById('rashi_'+ i ).selectedIndex="0";
      document.getElementById('house_'+ i ).selectedIndex="0";
      document.getElementById('degree_'+ i ).selectedIndex="0";
      document.getElementById('minutes_'+ i ).selectedIndex="0";
      document.getElementById('seconds_'+ i ).selectedIndex="0";
    }
    
    }
  return false;
  }
  

  function makeoc() {

      var clientname = document.getElementById('Hclmail').value;
      var astroname = document.getElementById('Hastname').value;
      var astid1 = document.getElementById('Hastmail').value;
     
          for (i = 0; i < 11; i++) {

              document.getElementById('rashi_' + i).selectedIndex = "0";
              document.getElementById('house_' + i).selectedIndex = "0";
              document.getElementById('degree_' + i).selectedIndex = "0";
              document.getElementById('minutes_' + i).selectedIndex = "0";
              document.getElementById('seconds_' + i).selectedIndex = "0";
          }

     
      return false;
  }

  function makebc() {
      var dob = document.getElementById('hdnimoob').value + '/' + document.getElementById('hdnidob').value + '/' + document.getElementById('hdniyob').value
      var tob = document.getElementById('hdnihob').value + '.' + document.getElementById('hdnimob').value
      var tzon = "5.30";
      
      var exec = homenewpage.makebirthchart(dob, tob, tzon, parseFloat(document.getElementById('hdnasc').value),parseFloat(document.getElementById('gulikaval').value));

      var ds = exec.value;

      if (ds.Tables[0].Rows.length > 0)
      {
           for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
               
              document.getElementById('rashi_' + i).value = ds.Tables[0].Rows[i].RASHI;
              document.getElementById('house_' + i).value = ds.Tables[0].Rows[i].HOUSE;
              document.getElementById('degree_' + i).value = ds.Tables[0].Rows[i].DEGREE;
              document.getElementById('minutes_' + i).value = ds.Tables[0].Rows[i].MINUTE;
              document.getElementById('seconds_' + i).value = ds.Tables[0].Rows[i].SECOND;
              document.getElementById('constelation_' + i).value = ds.Tables[0].Rows[i].CONSTELATION;

              if (ds.Tables[0].Rows[i].RASHI == 'Aries') {
                  var num = 1;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Taurus') {
                  var num = 2;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Gemini') {
                  var num = 3;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Cancer') {
                  var num = 4;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Leo') {
                  var num = 5;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Virgo') {
                  var num = 6;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Libra') {
                  var num = 7;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Scorpio') {
                  var num = 8;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Sagittarius') {
                  var num = 9;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Capricorn') {
                  var num = 10;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Aquarius') {
                  var num = 11;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Pisces') {
                  var num = 12;
              }
              document.getElementById('hdnr'+i).value = num;
              document.getElementById('hdnretro' + i).value = zeroPad(parseInt(ds.Tables[0].Rows[i].DEGREE), 2) + '.' + zeroPad(parseInt(ds.Tables[0].Rows[i].MINUTE), 2) + '.' + zeroPad(parseInt(ds.Tables[0].Rows[i].SECOND), 2);
              
          }
      
      

      }

      document.getElementById('rashi_' + 10).value = ds.Tables[0].Rows[10].RASHI;
      document.getElementById('house_' + 10).value = ds.Tables[0].Rows[10].HOUSE;
      document.getElementById('degree_' + 10).value = ds.Tables[0].Rows[10].DEGREE;
      document.getElementById('minutes_' + 10).value = ds.Tables[0].Rows[10].MINUTE;
      document.getElementById('seconds_' + 10).value = ds.Tables[0].Rows[10].SECOND;
      document.getElementById('constelation_' + 10).value = ds.Tables[0].Rows[10].CONSTELATION;


      if (ds.Tables[1].Rows.length > 0) {

          for (i = 0; i < ds.Tables[1].Rows.length; ++i)
          {
              if (ds.Tables[1].Rows[i].PLANET == 'MARS' && ds.Tables[1].Rows[i].MOVEMENT1 == 'R')
              { document.getElementById('retrograde_' + 3).value = 'R' }
              if (ds.Tables[1].Rows[i].PLANET == 'MERCURY' && ds.Tables[1].Rows[i].MOVEMENT1 == 'R')
              { document.getElementById('retrograde_' + 4).value = 'R' }
              if (ds.Tables[1].Rows[i].PLANET == 'JUPITER' && ds.Tables[1].Rows[i].MOVEMENT1 == 'R')
              { document.getElementById('retrograde_' + 5).value = 'R' }
              if (ds.Tables[1].Rows[i].PLANET == 'VENUS' && ds.Tables[1].Rows[i].MOVEMENT1 == 'R')
              { document.getElementById('retrograde_' + 6).value = 'R' }
              if (ds.Tables[1].Rows[i].PLANET == 'SATURN' && ds.Tables[1].Rows[i].MOVEMENT1 == 'R')
              { document.getElementById('retrograde_' + 7).value = 'R' }
          }
      }
      //daob = ds.Tables[1].Rows[0].IDOB.split(' ');
      //idaob = daob[0];
      //itaob = daob[1];

      //idaob1 = idaob.split('-');
      //da1ob = idaob1[0];
      //mo1ob = idaob1[1];
      //yr1ob = idaob1[2];

      //itaob1 = itaob.split(':');
      //ihob = itaob1[0];
      //imob = itaob1[1];

      //var dob = mo1ob + '/' + da1ob + '/' + yr1ob;
      //var tob = ihob + '.' + imob

      //var exec = homenewpage.makebirthchart(dob, tob, tzon, parseFloat(document.getElementById('hdnasc').value));
      //var ds1 = exec.value;

      //if (ds1.Tables[0].Rows.length > 0)
      // {


      //    for (i = 3; i < ds1.Tables[0].Rows.length; ++i) 
      //    {
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Aries') {
      //            var num = 1;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Taurus') {
      //            var num = 2;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Gemini') {
      //            var num = 3;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Cancer') {
      //            var num = 4;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Leo') {
      //            var num = 5;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Virgo') {
      //            var num = 6;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Libra') {
      //            var num = 7;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Scorpio') {
      //            var num = 8;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Sagittarius') {
      //            var num = 9;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Capricorn') {
      //            var num = 10;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Aquarius') {
      //            var num = 11;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Pisces') {
      //            var num = 12;
      //        }

      //        fretro = zeroPad(parseInt(ds1.Tables[0].Rows[i].DEGREE), 2) + '.' + zeroPad(parseInt(ds1.Tables[0].Rows[i].MINUTE), 2) + '.' + zeroPad(parseInt(ds1.Tables[0].Rows[i].SECOND), 2);

      //        if (document.getElementById('hdnretro' + i).value > fretro && parseInt(document.getElementById('hdnr' + i).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + i).value) != parseInt(1) && (parseInt(document.getElementById('hdnr' + i).value) >= parseInt(num) || parseInt(document.getElementById('hdnr' + i).value) == parseInt(num))) {
      //            document.getElementById('retrograde_' + i).value = 'R'
      //        }
      //        else { }


      //        if (parseInt(document.getElementById('hdnr' + i).value)==parseInt(12))
      //        {
                  
      //            if (document.getElementById('hdnretro' + i).value > fretro && parseInt(num) != parseInt('1') && (parseInt(document.getElementById('hdnr' + i).value) >= parseInt(num) || parseInt(document.getElementById('hdnr' + i).value) == parseInt(num)))
      //        {
      //            document.getElementById('retrograde_' + i).value = 'R'
      //        }
      //        else { }
      //        }

      //        if (parseInt(document.getElementById('hdnr' + i).value) == parseInt(1))
      //         {

      //            if (document.getElementById('hdnretro' + i).value > fretro && (parseInt(num) == parseInt('1') || parseInt(num) == parseInt('12')  ) ) {
      //                document.getElementById('retrograde_' + i).value = 'R'
      //            }
      //            else { }
      //        }



      //    }
      //}

   
      var moonsunr = document.getElementById('hdnr' + 2).value - document.getElementById('hdnr' + 1).value
      var marsunr = document.getElementById('hdnr' + 3).value - document.getElementById('hdnr' + 1).value
      var mersunr = document.getElementById('hdnr' + 4).value - document.getElementById('hdnr' + 1).value
      var jupsunr = document.getElementById('hdnr' + 5).value - document.getElementById('hdnr' + 1).value
      var vensunr = document.getElementById('hdnr' + 6).value - document.getElementById('hdnr' + 1).value
      var satsunr = document.getElementById('hdnr' + 7).value - document.getElementById('hdnr' + 1).value
      var rahusunr = document.getElementById('hdnr' + 8).value - document.getElementById('hdnr' + 1).value
      var ketusunr = document.getElementById('hdnr' + 9).value - document.getElementById('hdnr' + 1).value

      if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) && parseInt(document.getElementById('hdnr' + 2).value) == parseInt(1)) {
          var moonsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 2).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) && parseInt(document.getElementById('hdnr' + 2).value) == parseInt(12)) {
          var moonsun = parseFloat('30.00' - document.getElementById('hdnretro' + 2).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) > parseInt(document.getElementById('hdnr' + 2).value)) {
          var moonsun = parseFloat('30.00' - document.getElementById('hdnretro' + 2).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) < parseInt(document.getElementById('hdnr' + 2).value)) 
          {
              var moonsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 2).value.slice(0, -3))
          }
      else
      {
          var moonsun = parseFloat(document.getElementById('hdnretro' + 2).value.slice(0, -3)) - parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
          
          }


      if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) && parseInt(document.getElementById('hdnr' + 3).value)==parseInt(1)) {
          var marsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 3).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) && parseInt(document.getElementById('hdnr' + 3).value) == parseInt(12)) {
          var marsun = parseFloat('30.00' - document.getElementById('hdnretro' + 3).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) > parseInt(document.getElementById('hdnr' + 3).value)) {
          var marsun = parseFloat('30.00' - document.getElementById('hdnretro' + 3).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) < parseInt(document.getElementById('hdnr' + 3).value)) {
          var marsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 3).value.slice(0, -3))
      }
      else
      {
          var marsun = parseFloat(document.getElementById('hdnretro' + 3).value.slice(0, -3)) - parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))

      }



      if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) && parseInt(document.getElementById('hdnr' + 4).value) == parseInt(1)) {
          var mersun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 4).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) && parseInt(document.getElementById('hdnr' + 4).value) == parseInt(12)) {
          var mersun = parseFloat('30.00' - document.getElementById('hdnretro' + 4).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) > parseInt(document.getElementById('hdnr' + 4).value)) {
          var mersun = parseFloat('30.00' - document.getElementById('hdnretro' + 4).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) < parseInt(document.getElementById('hdnr' + 4).value)) {
          var mersun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 4).value.slice(0, -3))

      }
      else {
          var mersun = parseFloat(document.getElementById('hdnretro' + 4).value.slice(0, -3)) - parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }


      if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) && parseInt(document.getElementById('hdnr' + 5).value) == parseInt(1)) {
          var jupsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 5).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) && parseInt(document.getElementById('hdnr' + 5).value) == parseInt(12)) {
          var jupsun = parseFloat('30.00' - document.getElementById('hdnretro' + 5).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) > parseInt(document.getElementById('hdnr' + 5).value)) {
          var jupsun = parseFloat('30.00' - document.getElementById('hdnretro' + 5).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) < parseInt(document.getElementById('hdnr' + 5).value)) {
          var jupsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 5).value.slice(0, -3))
      }
      else {
          var jupsun = parseFloat( document.getElementById('hdnretro' + 5).value.slice(0, -3)) - parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }


      if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) && parseInt(document.getElementById('hdnr' + 6).value) == parseInt(1)) {
          var vensun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 6).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) && parseInt(document.getElementById('hdnr' + 6).value) == parseInt(12)) {
          var vensun = parseFloat('30.00' - document.getElementById('hdnretro' + 6).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) > parseInt(document.getElementById('hdnr' + 6).value)) {
          var vensun = parseFloat('30.00' - document.getElementById('hdnretro' + 6).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) < parseInt(document.getElementById('hdnr' + 6).value)) {
          var vensun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 6).value.slice(0, -3))
      }
      else {
          var vensun = parseFloat( document.getElementById('hdnretro' + 6).value.slice(0, -3)) - parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))

      }


      if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) && parseInt(document.getElementById('hdnr' + 7).value) == parseInt(1)) {
          var satsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 7).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) && parseInt(document.getElementById('hdnr' + 7).value) == parseInt(12)) {
          var satsun = parseFloat('30.00' - document.getElementById('hdnretro' + 7).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) > parseInt(document.getElementById('hdnr' + 7).value)) {
          var satsun = parseFloat('30.00' - document.getElementById('hdnretro' + 7).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) < parseInt(document.getElementById('hdnr' + 7).value)) {
          var satsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 7).value.slice(0, -3))
      }
      else {
          var satsun = parseFloat(document.getElementById('hdnretro' + 7).value.slice(0, -3)) - parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))

      }


      if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) && parseInt(document.getElementById('hdnr' + 8).value) == parseInt(1)) {
          var rahsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 8).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) && parseInt(document.getElementById('hdnr' + 8).value) == parseInt(12)) {
          var rahsun = parseFloat('30.00' - document.getElementById('hdnretro' + 8).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) > parseInt(document.getElementById('hdnr' + 8).value)) {
          var rahsun = parseFloat('30.00' - document.getElementById('hdnretro' + 8).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) < parseInt(document.getElementById('hdnr' + 8).value)) {
          var rahsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 8).value.slice(0, -3))

      }
      else {
          var rahsun = parseFloat( document.getElementById('hdnretro' + 8).value.slice(0, -3)) - parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }


      if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) && parseInt(document.getElementById('hdnr' + 9).value) == parseInt(1)) {
          var ketsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 9).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) && parseInt(document.getElementById('hdnr' + 9).value) == parseInt(12)) {
          var ketsun = parseFloat('30.00' - document.getElementById('hdnretro' + 9).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) > parseInt(document.getElementById('hdnr' + 9).value)) {
          var ketsun = parseFloat('30.00' - document.getElementById('hdnretro' + 9).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) < parseInt(document.getElementById('hdnr' + 9).value)) {
          var ketsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 9).value.slice(0, -3))
      }
      else {
          var ketsun = parseFloat( document.getElementById('hdnretro' + 9).value.slice(0, -3)) - parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }



      if (moonsun < "12" && moonsun > "-12" && parseInt(document.getElementById('hdnr' + 2).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 2).value) != parseInt(1) && moonsunr <= '1' && moonsunr>='-1') {
          if (document.getElementById('retrograde_' + 2).value == 'R') {
              document.getElementById('retrograde_' + 2).value = 'RC'
          }
          else {
              document.getElementById('retrograde_' + 2).value = 'C'
          }
      }

      if (moonsun < "3.20" && moonsun > "-3.20" && parseInt(document.getElementById('hdnr' + 2).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 2).value) != parseInt(1) && moonsunr <= '1' && moonsunr >= '-1') {
          if (document.getElementById('retrograde_' + 2).value == 'R') {
              document.getElementById('retrograde_' + 2).value = 'RDC'
          }
          else {
              document.getElementById('retrograde_' + 2).value = 'DC'
          }


      }


      if (parseInt(document.getElementById('hdnr' + 2).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) ||  parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1)  )     ) {

          if (moonsun < "12" && moonsun > "-12" && (parseInt(document.getElementById('hdnr' + 2).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 2).value == 'R') {
                  document.getElementById('retrograde_' + 2).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 2).value = 'C'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 2).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (moonsun < "3.20" && moonsun > "-3.20" && (parseInt(document.getElementById('hdnr' + 2).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 2).value == 'R') {
                  document.getElementById('retrograde_' + 2).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 2).value = 'DC'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 2).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2)) ) {

          if (moonsun < "12" && moonsun > "-12" && ((parseInt(document.getElementById('hdnr' + 2).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 2).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 2).value == 'R') {
                  document.getElementById('retrograde_' + 2).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 2).value = 'C'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 2).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (moonsun < "3.20" && moonsun > "-3.20" && ((parseInt(document.getElementById('hdnr' + 2).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 2).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 2).value == 'R') {
                  document.getElementById('retrograde_' + 2).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 2).value = 'DC'
              }
          }

      }











      if (satsun < "16" && satsun > "-16" && parseInt(document.getElementById('hdnr' + 7).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 7).value) != parseInt(1) && satsunr <= '1' && satsunr >= '-1') {
          if (document.getElementById('retrograde_' + 7).value == 'R') {
              document.getElementById('retrograde_' + 7).value = 'RC'
          }
          else {
              document.getElementById('retrograde_' + 7).value = 'C'
          }
      }

      if (satsun < "3.20" && satsun > "-3.20" && parseInt(document.getElementById('hdnr' + 7).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 7).value) != parseInt(1) && satsunr <= '1' && satsunr >= '-1') {
          if (document.getElementById('retrograde_' + 7).value == 'R') {
              document.getElementById('retrograde_' + 7).value = 'RDC'
          }
          else {
              document.getElementById('retrograde_' + 7).value = 'DC'
          }


      }


      if (parseInt(document.getElementById('hdnr' + 7).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (satsun < "16" && satsun > "-16" && (parseInt(document.getElementById('hdnr' + 7).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 7).value == 'R') {
                  document.getElementById('retrograde_' + 7).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 7).value = 'C'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 7).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (satsun < "3.20" && satsun > "-3.20" && (parseInt(document.getElementById('hdnr' + 7).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 7).value == 'R') {
                  document.getElementById('retrograde_' + 7).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 7).value = 'DC'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 7).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (satsun < "16" && satsun > "-16" && ((parseInt(document.getElementById('hdnr' + 7).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 7).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 7).value == 'R') {
                  document.getElementById('retrograde_' + 7).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 7).value = 'C'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 7).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (satsun < "3.20" && satsun > "-3.20" && ((parseInt(document.getElementById('hdnr' + 7).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 7).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 7).value == 'R') {
                  document.getElementById('retrograde_' + 7).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 7).value = 'DC'
              }
          }

      }











      if (vensun < "10" && vensun > "-10" && parseInt(document.getElementById('hdnr' + 6).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 6).value) != parseInt(1) && vensunr <= '1' && vensunr >= '-1') {
          if (document.getElementById('retrograde_' + 6).value == 'R') {
              document.getElementById('retrograde_' + 6).value = 'RC'
          }
          else {
              document.getElementById('retrograde_' + 6).value = 'C'
          }
      }

      if (vensun < "3.20" && vensun > "-3.20" && parseInt(document.getElementById('hdnr' + 6).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 6).value) != parseInt(1) && vensunr <= '1' && vensunr >= '-1') {
          if (document.getElementById('retrograde_' + 6).value == 'R') {
              document.getElementById('retrograde_' + 6).value = 'RDC'
          }
          else {
              document.getElementById('retrograde_' + 6).value = 'DC'
          }


      }


      if (parseInt(document.getElementById('hdnr' + 6).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (vensun < "10" && vensun > "-10" && (parseInt(document.getElementById('hdnr' + 6).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 6).value == 'R') {
                  document.getElementById('retrograde_' + 6).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 6).value = 'C'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 6).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (vensun < "3.20" && vensun > "-3.20" && (parseInt(document.getElementById('hdnr' + 6).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 6).value == 'R') {
                  document.getElementById('retrograde_' + 6).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 6).value = 'DC'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 6).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (vensun < "10" && vensun > "-10" && ((parseInt(document.getElementById('hdnr' + 6).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 6).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 6).value == 'R') {
                  document.getElementById('retrograde_' + 6).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 6).value = 'C'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 6).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (vensun < "3.20" && vensun > "-3.20" && ((parseInt(document.getElementById('hdnr' + 6).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 6).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 6).value == 'R') {
                  document.getElementById('retrograde_' + 6).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 6).value = 'DC'
              }
          }

      }















      if (jupsun < "11" && jupsun > "-11" && parseInt(document.getElementById('hdnr' + 5).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 5).value) != parseInt(1) && jupsunr <= '1' && jupsunr >= '-1') {
          if (document.getElementById('retrograde_' + 5).value == 'R') {
              document.getElementById('retrograde_' + 5).value = 'RC'
          }
          else {
              document.getElementById('retrograde_' + 5).value = 'C'
          }
      }

      if (jupsun < "3.20" && jupsun > "-3.20" && parseInt(document.getElementById('hdnr' + 5).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 5).value) != parseInt(1) && jupsunr <= '1' && jupsunr >= '-1') {
          if (document.getElementById('retrograde_' + 5).value == 'R') {
              document.getElementById('retrograde_' + 5).value = 'RDC'
          }
          else {
              document.getElementById('retrograde_' + 5).value = 'DC'
          }


      }


      if (parseInt(document.getElementById('hdnr' + 5).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (jupsun < "11" && jupsun > "-11" && (parseInt(document.getElementById('hdnr' + 5).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 5).value == 'R') {
                  document.getElementById('retrograde_' + 5).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 5).value = 'C'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 5).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (jupsun < "3.20" && jupsun > "-3.20" && (parseInt(document.getElementById('hdnr' + 5).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 5).value == 'R') {
                  document.getElementById('retrograde_' + 5).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 5).value = 'DC'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 5).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (jupsun < "11" && jupsun > "-11" && ((parseInt(document.getElementById('hdnr' + 5).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 5).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 5).value == 'R') {
                  document.getElementById('retrograde_' + 5).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 5).value = 'C'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 5).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (jupsun < "3.20" && jupsun > "-3.20" && ((parseInt(document.getElementById('hdnr' + 5).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 5).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 5).value == 'R') {
                  document.getElementById('retrograde_' + 5).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 5).value = 'DC'
              }
          }

      }
















      if (mersun < "14" && mersun > "-14" && parseInt(document.getElementById('hdnr' + 4).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 4).value) != parseInt(1) && mersunr <= '1' && mersunr >= '-1') {
          if (document.getElementById('retrograde_' + 4).value == 'R') {
              document.getElementById('retrograde_' + 4).value = 'RC'
          }
          else {
              document.getElementById('retrograde_' + 4).value = 'C'
          }
      }

      if (mersun < "3.20" && mersun > "-3.20" && parseInt(document.getElementById('hdnr' + 4).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 4).value) != parseInt(1) && mersunr <= '1' && mersunr >= '-1') {
          if (document.getElementById('retrograde_' + 4).value == 'R') {
              document.getElementById('retrograde_' + 4).value = 'RDC'
          }
          else {
              document.getElementById('retrograde_' + 4).value = 'DC'
          }


      }


      if (parseInt(document.getElementById('hdnr' + 4).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (mersun < "14" && mersun > "-14" && (parseInt(document.getElementById('hdnr' + 4).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 4).value == 'R') {
                  document.getElementById('retrograde_' + 4).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 4).value = 'C'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 4).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (mersun < "3.20" && mersun > "-3.20" && (parseInt(document.getElementById('hdnr' + 4).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 4).value == 'R') {
                  document.getElementById('retrograde_' + 4).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 4).value = 'DC'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 4).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (mersun < "14" && mersun > "-14" && ((parseInt(document.getElementById('hdnr' + 4).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 4).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 4).value == 'R') {
                  document.getElementById('retrograde_' + 4).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 4).value = 'C'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 4).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (mersun < "3.20" && mersun > "-3.20" && ((parseInt(document.getElementById('hdnr' + 4).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 4).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 4).value == 'R') {
                  document.getElementById('retrograde_' + 4).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 4).value = 'DC'
              }
          }

      }






      if (marsun < "17" && marsun > "-17" && parseInt(document.getElementById('hdnr' + 3).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 3).value) != parseInt(1) && marsunr <= '1' && marsunr >= '-1')
      {
          if (document.getElementById('retrograde_' + 3).value == 'R')
          {
              document.getElementById('retrograde_' + 3).value = 'RC'
          }
          else
          {
              document.getElementById('retrograde_' + 3).value = 'C'
          }
      }
      
      if (marsun < "3.20" && marsun > "-3.20" && parseInt(document.getElementById('hdnr' + 3).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 3).value) != parseInt(1) && marsunr <= '1' && marsunr >= '-1') {
          if (document.getElementById('retrograde_' + 3).value == 'R') {
              document.getElementById('retrograde_' + 3).value = 'RDC'
          }
          else {
              document.getElementById('retrograde_' + 3).value = 'DC'
          }

          
      }


      if (parseInt(document.getElementById('hdnr' + 3).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (marsun < "17" && marsun > "-17" && (parseInt(document.getElementById('hdnr' + 3).value)) != parseInt('1'))
          {
              if (document.getElementById('retrograde_' + 3).value == 'R') {
                  document.getElementById('retrograde_' + 3).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 3).value = 'C'
              }
          }

           
      }

      if (parseInt(document.getElementById('hdnr' + 3).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (marsun < "3.20" && marsun > "-3.20" && (parseInt(document.getElementById('hdnr' + 3).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 3).value == 'R') {
                  document.getElementById('retrograde_' + 3).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 3).value = 'DC'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 3).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (marsun < "17" && marsun > "-17" && ((parseInt(document.getElementById('hdnr' + 3).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 3).value)) == parseInt('12')))
          {
              if (document.getElementById('retrograde_' + 3).value == 'R') {
                  document.getElementById('retrograde_' + 3).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 3).value = 'C'
              }
          }
          
      }

      if (parseInt(document.getElementById('hdnr' + 3).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (marsun < "3.20" && marsun > "-3.20" && ((parseInt(document.getElementById('hdnr' + 3).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 3).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 3).value == 'R') {
                  document.getElementById('retrograde_' + 3).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 3).value = 'DC'
              }
          }

      }



      return false;
  }

  function zeroPad(num, numZeros) {
      var n = Math.abs(num);
      var zeros = Math.max(0, numZeros - Math.floor(n).toString().length);
      var zeroString = Math.pow(10, zeros).toString().substr(1);
      if (num < 0) {
          zeroString = '-' + zeroString;
      }

      return zeroString + n;
  }
function newc1l()
{
var astname=document.getElementById('astname').innerHTML;
window.open('astro_client.aspx?astname='+astname+ "&usermail=" + document.getElementById('hdnuser').value);
return false;}





function chartindexdata(){
//var astname=document.getElementById('Hastname').innerHTML;
//  var astmail=document.getElementById('Hastmail').innerHTML;
//  var clname=document.getElementById('Hclmail').innerHTML;
//  var clmail=document.getElementById('Hclmail').innerHTML;
var astname=document.getElementById('Hastname').value;
var astmail=document.getElementById('Hastmail').value;
var clmail=document.getElementById('Hclmail').value;

var clname=document.getElementById('Hclname').value;
   var res = homenewpage.viewclientinfo(astmail,clmail);
      var ds=res.value;

if(ds.Tables[0].Rows.length==0)
{alert('Client Not Exist');
    //window.open('chartindex.aspx?clmail=' + clmail + "&clname=" + clname + "&astname=" + astname + "&astmail=" + astmail);
 return false;
}
else
{

    window.open('chartindex.aspx?clmail=' + clmail + "&clname=" + clname + "&astname=" + astname + "&astmail=" + astmail+ "&usermail=" + document.getElementById('hdnuser').value);
    return false;

}
}

function dashapattern()
{
    var dob = document.getElementById('hdndob').value
    var dob1 = dob.split('/')
    var date1=dob1[0];
    var month1=dob1[1];
    var year1=dob1[2];

    var tob = document.getElementById('hdntob').value
    var tob1 = tob.split(':');
    var hob=tob1[0];
    var miob=tob1[1];
    var astmail = document.getElementById('Hastmail').value;
    window.open('dasha_pattern.aspx?mdegree=' + document.getElementById('degree_' + 2).value + "&mminute=" + document.getElementById('minutes_' + 2).value + "&msecond=" + document.getElementById('seconds_' + 2).value + "&mrashi=" + document.getElementById('rashi_' + 2).value + "&dob=" + date1 + "&mob=" + month1 + "&yob=" + year1 + "&htob=" + hob + "&mtob=" + miob + "&usermail=" + astmail);
    return false;
}
//function abc1()
//{ 
//System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
//System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(bitmap as System.Drawing.Image);
//graphics.CopyFromScreen(25, 25, 25, 25, bitmap.Size);
//bitmap.Save(@"d:\myscreenshot.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
//}