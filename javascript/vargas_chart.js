
function openastrocalcu()
{  var astname = document.getElementById('astname').innerHTML;
     var astmail = document.getElementById('astid').innerHTML;
     var clname = document.getElementById('clientname').innerHTML;
     var clmail = document.getElementById('clientid').innerHTML;
     var s="";
     //var c="";sa
     var moon="";
     var venus="";
      for (var i = 0; i < 11; i++)
     {
        var degree=document.getElementById('degree_' + i).value
        var degree1=degree.split('.');
        var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
       // c = c + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "~" + '0' + "~" + 'B' + "~" + degree + "~" +document.getElementById('cons_' + i).value+ "$";
      var moon=moon + document.getElementById('planets_' + i).value + "~" + document.getElementById('moonrashi_' + i).value + "~" + document.getElementById('moonhouse_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
      var venus=venus + document.getElementById('planets_' + i).value + "~" + document.getElementById('venusrashi_' + i).value + "~" + document.getElementById('venushouse_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
      }
      //var v= document.getElementById('Hidden4').value;
      //c=c.slice(0,-1);
      var c= document.getElementById('Hiddencons').value;
      window.open('astro_calculation.aspx?clmail=' + clmail + "&clname=" + clname+ "&s="+s+ "&c="+c+ "&moon="+moon+ "&venus="+venus + "&astname=" + astname + "&astmail=" + astmail + "&usermail=" + document.getElementById('hdnuser').value);
     return false;
 }

function gethorarycalculation()
{
   var sunsetpre = document.getElementById('hdsunsetpre').value;
   var sunrise = document.getElementById('hdsunrise').value;
   var sunset = document.getElementById('hdsunset').value;
   var sunrisenext = document.getElementById('hdnsunrisenext').value;
   var astrologer = document.getElementById('Hastid').value;
   var tob = document.getElementById('hdntob').value;
   var dob = document.getElementById('hdndob').value;
   var city = document.getElementById('hdncity').value;
   var clientquery = document.getElementById('hdnquery').value;
   window.open("horary_calculation.aspx?astmail=" + astrologer + "&dob=" + dob + "&tob=" + tob + "&city=" + city + "&sunsetpre=" + sunsetpre + "&sunrise=" + sunrise  + "&sunset=" + sunset  + "&sunrisenext=" + sunrisenext +   "&usermail=" + document.getElementById('hdnuser').value+"&query="+clientquery + "", null);
   return false;
}

function getprobablequery() {
    var sunrise = document.getElementById('hdsunrise').value;
    var sunset = document.getElementById('hdsunset').value;
    var sunrisenext = document.getElementById('hdnsunrisenext').value;
    var astrologer = document.getElementById('Hastid').value;
    var tob = document.getElementById('hdntob').value;
    var dob = document.getElementById('hdndob').value;
    var city = document.getElementById('hdncity').value;
    window.open("probable_query.aspx?astmail=" + astrologer + "&dob=" + dob + "&tob=" + tob + "&city=" + city + "&sunrise=" + sunrise + "&sunset=" + sunset + "&sunrisenext=" + sunrisenext + "&usermail=" + document.getElementById('hdnuser').value + "", null);
    return false;
}
function showchart()
{
    var degreesecond = "";
    var degree = "";
    var house = "";
    var astname = document.getElementById('astname').innerHTML;
    var astmail = document.getElementById('astid').innerHTML;
    var clname = document.getElementById('clientname').innerHTML;
    var clmail = document.getElementById('clientid').innerHTML;
    var lagnarashi = document.getElementById('rashi_0').value;
    var lagnadegree = document.getElementById('degree_0').value;
    var drop1 = document.getElementById('dropyogas').value;
    var moonrashi = document.getElementById('rashi_2').value;
    var sunhouse = document.getElementById('house_1').value;
    var moonhouse = document.getElementById('house_2').value;

    for (i = 1; i < 10; i++) {
        var spldeg = document.getElementById('degree_' + i).value;
        var teospl = spldeg.split('.');
        var dataf = teospl[0];

        var minsplit = spldeg.split('.');
        var minsecsplit = teospl[1];
        degree = degree + dataf + '.' + minsecsplit + "~";

        degreesecond = degreesecond + dataf + '.' + minsecsplit + '~';

        house = house + document.getElementById('house_' + i).value + "~";
    }

    var asendrashi = document.getElementById('rashi_0').value;
    var suninhouse = document.getElementById('house_1').value;
    var mooninhouse = document.getElementById('house_2').value;
    var marsinhouse = document.getElementById('house_3').value;
    var mrecinhouse = document.getElementById('house_4').value;
    var jupinhouse = document.getElementById('house_5').value;
    var venusinhouse = document.getElementById('house_6').value;
    var saturninhouse = document.getElementById('house_7').value;
    var s = "";
    var astname = document.getElementById('astname').innerHTML;
    var astmail = document.getElementById('astid').innerHTML;
    var clname = document.getElementById('clientname').innerHTML;
    var clmail = document.getElementById('clientid').innerHTML;
    var rashie = ""
    var retro = "";
    for (i = 1; i < 10; i++) {

        rashie = rashie + document.getElementById('rashi_' + i).value + "~"
    }
    for (i = 1; i < 9; i++) {
        if (document.getElementById('retrograde_' + i).value == '' || document.getElementById('retrograde_' + i).value == null)
        { retro = retro + 'B' + "~" }
        else {
            retro = retro + document.getElementById('retrograde_' + i).value + "~";
        }
    }
    retro = retro + 'B' + "~";


    for (i = 1; i <= 10; i++) {
        s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "$";

    }
    s = s.slice(0, -1);
    var v = document.getElementById('Hiddencons').value;
    var clientquery = document.getElementById('hdnquery').value;
    // window.open('horarycombination.aspx?clmail=' + clmail + "&clname=" + clname + "&astname=" + astname + "&astmail=" + astmail + "&s=" + s +"&lagnarashi=" + lagnarashi + "&lagnadegree=" + lagnadegree + "&degree=" + degree + "&house=" + house + "&drop1=" + drop1 + "&degreesecond=" + degreesecond + "&moonrashi=" + moonrashi + "&sunhouse=" + sunhouse + "&moonhouse=" + moonhouse);
    window.open('showchart.aspx?clmail=' + clmail + "&clname=" + clname + "&astname=" + astname + "&astmail=" + astmail + "&lagnarashi=" + lagnarashi + "&lagnadegree=" + lagnadegree + "&degree=" + degree + "&house=" + house + "&drop1=" + drop1 + "&degreesecond=" + degreesecond + "&moonrashi=" + moonrashi + "&sunhouse=" + sunhouse + "&moonhouse=" + moonhouse + "&s=" + s + "&rashie=" + rashie + "&retro=" + retro + "&usermail=" + document.getElementById('hdnuser').value + "&v=" + v +"&query=" + clientquery);
    return false;
}
function accountuser() {
    if (document.getElementById('hdncat').value == 'Horary') {
        document.getElementById('cat_grp').value = 'Horary'

    }

    if (document.getElementById('hdncat').value == 'Natal') {
        document.getElementById('cat_grp').value = 'Natal'

    }
    group_bind();
}
function vargas()
{
document.getElementById('chart').value='D09';
var vargas=document.getElementById('Hiddencons').value;
document.getElementById('planet').value=document.getElementById('Hidden1').value;
document.getElementById('dasha').value=document.getElementById('Hidden2').value;
document.getElementById('planet').disabled=true;
document.getElementById('dasha').disabled=true;
vargas_chart.vargasvalue(vargas,callback_vargas);
return false;
}


function callback_vargas(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
    exec_data = val.value;
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

        if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:520;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='450px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td  class='colum-td-head'>" + "PLANET" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D1_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D1_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head' style='display:none;'>" + "BIRTH_TIME" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "DEGREE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "R" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "CONST." + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "CHA." + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "CONST.LORD" + "</td>"
                
        buf2 += "<td  class='colum-td-head'>" + "D2_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D2_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D3_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D3_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D4_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D4_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D5_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D5_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D6_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D6_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D7_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D7_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D8_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D8_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D9_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D9_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D10_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D10_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D11_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D11_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D12_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D12_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D16_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D16_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D20_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D20_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D24_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D24_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D27_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D27_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D30_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D30_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D40_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D40_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D45_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D45_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D60_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D60_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "SHASHTYAMSHA_NAME" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D60_NATURE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "KARAKAMSHA_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "KARAKAMSHA_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "MOON_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "MOON_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "VENUS_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "VENUS_RASHI" + "</td>"
        buf2 += "</tr>"


        len = 1;


        if (exec_data.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"
//                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'> "
//                buf2 += "<label  style='width:90px; font-family:helvetica;' class='dropdown_large_corr'; align='left' Text='" + exec_data.Tables[0].Rows[i]['PLANET'] + "'  id=planets_" + i + " >"
//                buf2 += "</td>"


                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px' class='Planets-font'>" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</font>"
               buf2 +="<input type='hidden' class='Planets-font' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['PLANET'])+">"
              buf2 += "</td>"
                
                

                 buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D1_HOUSE']) + "</font>"
               buf2 += "<input type='hidden' class='Planets-font' id=house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D1_HOUSE']) + ">"
              buf2 += "</td>"


                buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D1_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D1_RASHI'])+">"
              buf2 += "</td>"
              
               buf2 += "<td class='colum-td-new1' style='display:none;'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['BIRTH_TIME']) + "</font>"
               buf2 +="<input type='hidden' id=birth_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['BIRTH_TIME'])+">"
               buf2 += "</td>"
               
                 buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
               buf2 +="<input type='hidden' id=degree_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE'])+">"
              buf2 += "</td>"

               buf2 += "<td class='colum-td-new1'>"
               if (exec_data.Tables[0].Rows[i]['RETRO'] == null || exec_data.Tables[0].Rows[i]['RETRO'] =="B") {
                   buf2 += "<font width='90px'></font>"
                   buf2 += "<input type='hidden' id=retrograde_" + i + " >"
                   buf2 += "</td>"
                 
               }
               else {
                   buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['RETRO']) + "</font>"
                   buf2 += "<input type='hidden' id=retrograde_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['RETRO']) + ">"
                   buf2 += "</td>"
                 }
               
                
                 buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['CONSTELATION']) + "</font>"
               buf2 +="<input type='hidden' id=cons_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['CONSTELATION'])+">"
               buf2 += "</td>"
               
               buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['CHARAN']) + "</font>"
               buf2 +="<input type='hidden' id=charan_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['CHARAN'])+">"
               buf2 += "</td>"
               
               buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['CONSTELATION_LORD']) + "</font>"
               buf2 +="<input type='hidden' id=conslord_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['CONSTELATION_LORD'])+">"
               buf2 += "</td>"
              
               buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D2_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d2house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D2_HOUSE'])+">"
               buf2 += "</td>"
              
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D2_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d2rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D2_RASHI'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D3_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d3house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D3_HOUSE'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D3_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d3rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D3_RASHI'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D4_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d4house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D4_HOUSE'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D4_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d4rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D4_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D5_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d5house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D5_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D5_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d5rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D5_RASHI'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D6_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d6house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D6_HOUSE'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D6_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d6rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D6_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D7_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d7house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D7_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D7_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d7rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D7_RASHI'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D8_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d8house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D8_HOUSE'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D8_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d8rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D8_RASHI'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D9_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d9house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D9_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D9_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d9rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D9_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D10_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d10house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D10_HOUSE'])+">"
              buf2 += "</td>"
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D10_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d10rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D10_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D11_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d11house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D11_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D11_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d11rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D11_RASHI'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D12_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d12house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D12_HOUSE'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D12_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d12rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D12_RASHI'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D16_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d16house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D16_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D16_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d16rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D16_RASHI'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D20_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d20house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D20_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D20_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d20rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D20_RASHI'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D24_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d24house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D24_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D24_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d24rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D24_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D27_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d27house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D27_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D27_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d27rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D27_RASHI'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D30_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d30house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D30_HOUSE'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D30_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d30rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D30_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D40_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d40house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D40_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D40_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d40rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D40_RASHI'])+">"
              buf2 += "</td>"
                 
                 
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D45_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d45house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D45_HOUSE'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D45_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d45rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D45_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D60_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d60house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D60_HOUSE'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D60_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d60rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D60_RASHI'])+">"
              buf2 += "</td>"
                
               
                     buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['SHASHTYAMSHA_NAME']) + "</font>"
               buf2 +="<input type='hidden' id=d60shash_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['SHASHTYAMSHA_NAME'])+">"
              buf2 += "</td>"
               
                
                     buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D60_NATURE']) + "</font>"
               buf2 +="<input type='hidden' id=d60nature_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D60_NATURE'])+">"
              buf2 += "</td>"
               
                
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['KARAKAMSHA_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=karkahouse_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['KARAKAMSHA_HOUSE'])+">"
              buf2 += "</td>"
              
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['KARAKAMSHA_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=karkarashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['KARAKAMSHA_RASHI'])+">"
              buf2 += "</td>"
              
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['MOON_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=moonhouse_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['MOON_HOUSE'])+">"
              buf2 += "</td>"
              
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['MOON_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=moonrashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['MOON_RASHI'])+">"
              buf2 += "</td>"
              
              buf2 += "<td class='colum-td-new1'>"
              buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['VENUS_HOUSE']) + "</font>"
              buf2 +="<input type='hidden' id=venushouse_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['VENUS_HOUSE'])+">"
              buf2 += "</td>"
              
              buf2 += "<td class='colum-td-new1'>"
              buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['VENUS_RASHI']) + "</font>"
              buf2 +="<input type='hidden' id=venusrashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['VENUS_RASHI'])+">"
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

    }
vargaschart();
vargaschartd01();

}


function searchdataopt() {

if(document.getElementById('chart').value=="0")
{
alert('Please select the chart')
return false;
}
else
{
   var chart=document.getElementById('chart').value;
   var s = "";
    for (var i = 0; i < 11; i++)
     {

        var degree=document.getElementById('degree_' + i).value
        var degree1=degree.split('.');
        if(chart=='D01')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        
        }
        if(chart=='D02')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d2rashi_' + i).value + "~" + document.getElementById('d2house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D03')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d3rashi_' + i).value + "~" + document.getElementById('d3house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D04')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d4rashi_' + i).value + "~" + document.getElementById('d4house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D05')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d5rashi_' + i).value + "~" + document.getElementById('d5house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D06')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d6rashi_' + i).value + "~" + document.getElementById('d6house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D07')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d7rashi_' + i).value + "~" + document.getElementById('d7house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D08')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d8rashi_' + i).value + "~" + document.getElementById('d8house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D09')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d9rashi_' + i).value + "~" + document.getElementById('d9house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D10')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d10rashi_' + i).value + "~" + document.getElementById('d10house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D11')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d11rashi_' + i).value + "~" + document.getElementById('d11house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D12')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d12rashi_' + i).value + "~" + document.getElementById('d12house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D16')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d16rashi_' + i).value + "~" + document.getElementById('d16house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D20')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d20rashi_' + i).value + "~" + document.getElementById('d20house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D24')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d24rashi_' + i).value + "~" + document.getElementById('d24house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D27')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d27rashi_' + i).value + "~" + document.getElementById('d27house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D30')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d30rashi_' + i).value + "~" + document.getElementById('d30house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D40')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d40rashi_' + i).value + "~" + document.getElementById('d40house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D45')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d45rashi_' + i).value + "~" + document.getElementById('d45house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D60')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d60rashi_' + i).value + "~" + document.getElementById('d60house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
    
          if(chart=='KL')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('karkarashi_' + i).value + "~" + document.getElementById('karkahouse_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
    }
    var rashi = document.getElementById('rashi_' + 0).value;
   
    var searchpage = s + "/" + rashi+ "/" + chart;
    var v= document.getElementById('Hidden4').value;
    var j=   document.getElementById('Hidden1').value;
    var k=   document.getElementById('Hidden2').value;
    var astmail=document.getElementById('astid').innerHTML;
    var astname=document.getElementById('astname').innerHTML;
 
  var client=document.getElementById('clientname').innerHTML;
  
  
  var clmail = document.getElementById('clientid').innerHTML;
  var v = document.getElementById('Hiddencons').value;
    window.open('searchpage.aspx?searchpage=' + searchpage+"&v="+ v + "&j="+ j + "&k="+ k +"&clmail="+ clmail + "&astmail=" + astmail + "&astname=" + astname + "&client=" + client+ "&usermail=" + document.getElementById('hdnuser').value);
    chart="0";
    return false;

    

}}

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

var ChartID = document.getElementById("chart");
var ChartVal = ChartID.options[ChartID.selectedIndex].value; 
var Charttxt = ChartID.options[ChartID.selectedIndex].text; 
chartname=Charttxt;
//var chartname=document.getElementById('chart').value;
document.getElementById('Label1').innerHTML = chartname +' Chart';
    document.getElementById('rashiid').style.display = "block";
   for (var i = 1; i <= 10; i++) 
    {
        document.getElementById('Hidden5').value = i;
            if(document.getElementById('chart').value=='D01')
            {
                var h = document.getElementById('house_' + i).value
                var r=document.getElementById('rashi_' + 0).value
                
            }
            
            if(document.getElementById('chart').value=='D02')
            {
                var h = document.getElementById('d2house_' + i).value
                var r=document.getElementById('d2rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D03')
            {
                var h = document.getElementById('d3house_' + i).value
                var r=document.getElementById('d3rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D04')
            {
                var h = document.getElementById('d4house_' + i).value
                var r=document.getElementById('d4rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D05')
            {
                var h = document.getElementById('d5house_' + i).value
                var r=document.getElementById('d5rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D06')
            {
                var h = document.getElementById('d6house_' + i).value
                var r=document.getElementById('d6rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D07')
            {
                var h = document.getElementById('d7house_' + i).value
                var r=document.getElementById('d7rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D08')
            {
                var h = document.getElementById('d8house_' + i).value
                var r=document.getElementById('d8rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D09')
            {
                var h = document.getElementById('d9house_' + i).value
                var r=document.getElementById('d9rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D10')
            {
                var h = document.getElementById('d10house_' + i).value
                var r=document.getElementById('d10rashi_' + 0).value
            }
            if(document.getElementById('chart').value=='D11')
            {
                var h = document.getElementById('d11house_' + i).value
                var r=document.getElementById('d11rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D12')
            {
                var h = document.getElementById('d12house_' + i).value
                var r=document.getElementById('d12rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D16')
            {
                var h = document.getElementById('d16house_' + i).value
                var r=document.getElementById('d16rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D20')
            {
                var h = document.getElementById('d20house_' + i).value
                var r=document.getElementById('d20rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D24')
            {
                var h = document.getElementById('d24house_' + i).value
                var r=document.getElementById('d24rashi_' + 0).value
            }
            
             if(document.getElementById('chart').value=='D27')
            {
                var h = document.getElementById('d27house_' + i).value
                var r=document.getElementById('d27rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D30')
            {
                var h = document.getElementById('d30house_' + i).value
                var r=document.getElementById('d30rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D40')
            {
                var h = document.getElementById('d40house_' + i).value
                var r=document.getElementById('d40rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D45')
            {
                var h = document.getElementById('d45house_' + i).value
                var r=document.getElementById('d45rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D60')
            {
                var h = document.getElementById('d60house_' + i).value
                var r=document.getElementById('d60rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='KL')
            {
                var h = document.getElementById('karkahouse_' + i).value
                var r=document.getElementById('karkarashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='MOON')
            {
                var h = document.getElementById('moonhouse_' + i).value
                var r=document.getElementById('moonrashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='VENUS')
            {
                var h = document.getElementById('venushouse_' + i).value
                var r=document.getElementById('venusrashi_' + 0).value
            }
            
       
         
         if (h == 'HOUSE1') {
           
                   
           if (document.getElementById('planets_' + i).value == 'MERCURY') 
             {
             j1 = 'Me';
             }

            if (document.getElementById('planets_' + i).value == 'JUPITER')
              {
              j1 = 'Ju';
              }

    if (document.getElementById('planets_' + i).value == 'VENUS') 
    {
        j1 = 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN')
     {
        j1 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN') 
    {
        j1 = 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON')
     {
        j1 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS')
     {
        j1 = 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU') 
    {
        j1 = 'Ra';
    }
    if (document.getElementById('planets_' + i).value == 'KETU') 
    {
        j1= 'Ke';
    }

    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j1 = 'Gk';
    }
      h1 =h1+j1 + " ";
    
            
        }
        if (h == 'HOUSE2') 
        {
            
            if (document.getElementById('planets_' + i).value == 'MERCURY') 
            {
        j2 = 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER') 
    {
        j2 = 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS') 
    {
        j2 = 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN')
     {
        j2 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN') 
    {
        j2 = 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON')
     {
        j2 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS') 
    {
        j2 = 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU')
     {
        j2 = 'Ra';
}
    if (document.getElementById('planets_' + i).value == 'KETU')
     {
        j2 = 'Ke';
    }

    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j2 = 'Gk';
    }

   

    h2 = h2+j2 + " ";
   
            
        }

         if (h == 'HOUSE3') 
        {
           
           if (document.getElementById('planets_' + i).value == 'MERCURY')
            {
        j3 = 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER')
     {
        j3 = 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS')
     {
       j3 = 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN') 
    {
        j3 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN')
     {
        j3= 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON')
     {
        j3 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS')
     {
        j3 = 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU') 
    {
        j3 = 'Ra';
}
    if (document.getElementById('planets_' + i).value == 'KETU')
     {
        j3 = 'Ke';
    }
    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j3 = 'Gk';
    }
  
    h3 =h3+ j3 + " ";
   
           
        }


        if (h == 'HOUSE4') {
           
           if (document.getElementById('planets_' + i).value == 'MERCURY')
            {
        j4 = 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER')
     {
        j4 = 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS') 
    {
        j4 = 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN') 
    {
        j4 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN') 
    {
        j4 = 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON') 
    {
        j4 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS')
     {
        j4 = 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU') 
    {
        j4 = 'Ra';
}
    if (document.getElementById('planets_' + i).value == 'KETU')
     {
        j4 = 'Ke';
    }
    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j4 = 'Gk';
    }

    h4 =h4+ j4 + " ";
    
           
        }

        if (h == 'HOUSE5') {
            
            if (document.getElementById('planets_' + i).value == 'MERCURY')
             {
        j5 = 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER')
     {
        j5 = 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS') 
    {
        j5 = 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN')
     {
        j5 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN') 
    {
        j5 = 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON')
     {
        j5 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS')
     {
        j5 = 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU')
     {
       j5 = 'Ra';
}
    if (document.getElementById('planets_' + i).value == 'KETU')
     {
        j5 = 'Ke';
    }
    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j5 = 'Gk';
    }

    h5 =h5+ j5 + " ";
    
        }

        if (h == 'HOUSE6') {
            
            if (document.getElementById('planets_' + i).value == 'MERCURY') 
            {
        j6= 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER')
     {
        j6= 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS') 
    {
        j6 = 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN')
     {
        j6 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN')
     {
        j6 = 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON')
     {
        j6 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS')
     {
       j6 = 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU')
     {
        j6 = 'Ra';

}
    if (document.getElementById('planets_' + i).value == 'KETU')
     {
        j6= 'Ke';
    }
    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j6 = 'Gk';
    }


    h6 =h6+ j6 + " ";
   
            
        }

        if (h == 'HOUSE7') {
           
            if (document.getElementById('planets_' + i).value == 'MERCURY')
             {
        j7 = 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER')
     {
        j7 = 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS')
     {
        j7 = 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN') 
    {
        j7 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN')
     {
      j7 = 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON')
     {
        j7 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS')
     {
        j7 = 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU')
     {
        j7= 'Ra';
}
    if (document.getElementById('planets_' + i).value == 'KETU')
     {
        j7 = 'Ke';
    }
  
    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j7 = 'Gk';
    }

    h7 =h7+ j7 + " ";
    
            
        }

        if (h == 'HOUSE8') {
           
            if (document.getElementById('planets_' + i).value == 'MERCURY')
             {
       j8= 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER')
     {
        j8 = 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS')
     {
       j8 = 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN') 
    {
        j8 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN') 
    {
        j8= 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON')
     {
        j8 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS') 
    {
        j8= 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU')
     {
        j8= 'Ra';
}
    if (document.getElementById('planets_' + i).value == 'KETU') 
    {
       j8 = 'Ke';
    }

    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j8 = 'Gk';
    }


    h8 =h8+ j8 + " ";
    
           
        }

        if (h == 'HOUSE9') {
            
            if (document.getElementById('planets_' + i).value == 'MERCURY') 
            {
       j9 = 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER') 
    {
        j9 = 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS')
     {
        j9= 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN') 
    {
        j9 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN')
     {
       j9 = 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON') 
    {
        j9 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS') 
    {
        j9= 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU') 
    {
       j9= 'Ra';
}
    if (document.getElementById('planets_' + i).value == 'KETU') 
    {
        j9 = 'Ke';
    }
    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j9 = 'Gk';
    }
    

    h9 =h9+ j9 + " ";
   
            
        }

        if (h == 'HOUSE10') {
            
            if (document.getElementById('planets_' + i).value == 'MERCURY')
             {
        j10 = 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER')
     {
        j10 = 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS') 
    {
        j10 = 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN') 
    {
        j10= 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN')
     {
        j10 = 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON')
     {
        j10 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS')
     {
        j10 = 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU')
     {
        j10 = 'Ra';
}
    if (document.getElementById('planets_' + i).value == 'KETU') 
    {
        j10 = 'Ke';
    }
    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j10 = 'Gk';
    }


   

    h10 =h10+ j10 + " ";
   
           
        }

        if (h == 'HOUSE11') {
            
            if (document.getElementById('planets_' + i).value == 'MERCURY')
             {
        j11 = 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER') 
    {
        j11 = 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS')
     {
        j11= 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN') 
    {
        j11 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN') 
    {
        j11 = 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON') 
    {
        j11 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS')
     {
        j11 = 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU') 
    {
        j11= 'Ra';
}
    if (document.getElementById('planets_' + i).value == 'KETU')
     {
        j11 = 'Ke';
    }

    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j11 = 'Gk';
    }


    h11 =h11+ j11 + " ";
    
}
            if (h == 'HOUSE12') {
                
               if (document.getElementById('planets_' + i).value == 'MERCURY')
                {
       j12 = 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER')
     {
        j12= 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS')
     {
        j12 = 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN')
     {
       j12 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN')
     {
        j12= 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON')
     {
        j12 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS')
     {
        j12 = 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU') {
        j12 = 'Ra';
    }
    if (document.getElementById('planets_' + i).value == 'KETU')
     {
        j12 = 'Ke';
    }
    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j12 = 'Gk';
    }
   
    h12 =h12+ j12 + " ";
  
     
          
        }

    }
    if (r == 'Aries') 
    {
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
    p2 = h2 ;
    p3 = h3;
    p4 = h4; 
    p5 = h5;
    p6 = h6; 
    p7 = h7 ;
    p8 = h8 ; 
    p9 = h9 ;
    p10 = h10 ;
    p11 = h11 ;
    p12 = h12;
document.getElementById('h1l1').innerHTML = p1+" "+'Asc';
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
    
    return false;
}


function vargaschartd01() {
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
var deg="";
var deg1="";
var chartname='D01 Birth Chart (General well being and Physique)'
document.getElementById('Label1d01').innerHTML = chartname+' Chart';
    document.getElementById('rashiidd01').style.display = "block";
   for (var i = 1; i <= 10; i++) 
    {
        document.getElementById('Hidden5d01').value = i;
           
                var h = document.getElementById('house_' + i).value
                var r=document.getElementById('rashi_' + 0).value


                if (document.getElementById('retrograde_' + i).value == "B") {
                    document.getElementById('retrograde_' + i).value = "";
                }


                if (h == 'HOUSE1') {
                     deg = document.getElementById('degree_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j1 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j1 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j1 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j1 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j1 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j1 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j1 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j1 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j1 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j1 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    h1 = h1 + j1 + " ";


                }
                if (h == 'HOUSE2') {
                     deg = document.getElementById('degree_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j2 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j2 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j2 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j2 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j2 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j2 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j2 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j2 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j2 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j2 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }



                    h2 = h2 + j2 + " ";


                }

                if (h == 'HOUSE3') {
                     deg = document.getElementById('degree_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j3 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j3 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j3 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j3 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j3 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j3 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j3 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j3 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j3 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j3 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    h3 = h3 + j3 + " ";


                }


                if (h == 'HOUSE4') {
                     deg = document.getElementById('degree_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j4 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j4 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j4 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j4 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j4 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j4 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j4 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j4 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j4 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j4 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    h4 = h4 + j4 + " ";


                }

                if (h == 'HOUSE5') {
                     deg = document.getElementById('degree_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j5 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j5 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j5 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j5 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j5 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j5 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j5 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j5 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j5 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j5 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    h5 = h5 + j5 + " ";

                }

                if (h == 'HOUSE6') {
                     deg = document.getElementById('degree_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j6 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j6 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j6 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j6 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j6 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j6 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j6 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j6 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';

                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j6 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j6 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    h6 = h6 + j6 + " ";


                }

                if (h == 'HOUSE7') {
                     deg = document.getElementById('degree_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j7 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j7 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j7 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j7 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j7 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j7 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j7 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j7 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j7 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j7 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    h7 = h7 + j7 + " ";


                }

                if (h == 'HOUSE8') {
                     deg = document.getElementById('degree_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j8 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j8 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j8 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j8 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j8 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j8 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j8 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j8 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j8 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j8 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    h8 = h8 + j8 + " ";


                }

                if (h == 'HOUSE9') {
                     deg = document.getElementById('degree_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j9 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j9 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j9 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j9 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j9 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j9 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j9 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j9 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j9 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j9 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }


                    h9 = h9 + j9 + " ";


                }

                if (h == 'HOUSE10') {
                     deg = document.getElementById('degree_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j10 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j10 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j10 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j10 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j10 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j10 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j10 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j10 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j10 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j10 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }


                    h10 = h10 + j10 + " ";


                }

                if (h == 'HOUSE11') {
                     deg = document.getElementById('degree_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j11 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j11 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j11 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j11 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j11 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j11 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j11 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j11 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j11 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j11 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }


                    h11 = h11 + j11 + " ";

                }
                if (h == 'HOUSE12') {
                    deg = document.getElementById('degree_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j12 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j12 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j12 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j12 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j12 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j12 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j12 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j12 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j12 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j12 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + deg1 + '</span>';
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
document.getElementById('h1l1d01').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' +0).value  + '</span>';
document.getElementById('h2l1d01').innerHTML = p2;
document.getElementById('h3l1d01').innerHTML = p3;
document.getElementById('h4l1d01').innerHTML = p4;
document.getElementById('h5l1d01').innerHTML = p5;
document.getElementById('h6l1d01').innerHTML = p6;
document.getElementById('h7l1d01').innerHTML = p7;
document.getElementById('h8l1d01').innerHTML = p8;
document.getElementById('h9l1d01').innerHTML = p9;
document.getElementById('h10l1d01').innerHTML = p10;
document.getElementById('h11l1d01').innerHTML = p11;
document.getElementById('h12l1d01').innerHTML = p12;
document.getElementById('h12rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r12 + '</span>' + '</br>';
document.getElementById('h1rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r1 + '</span>' + '</br>';
document.getElementById('h2rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r2 + '</span>' + '</br>';
document.getElementById('h3rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r3 + '</span>' + '</br>';
document.getElementById('h4rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r4 + '</span>' + '</br>';
document.getElementById('h5rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r5 + '</span>' + '</br>';
document.getElementById('h6rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r6 + '</span>' + '</br>';
document.getElementById('h7rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r7 + '</span>' + '</br>';
document.getElementById('h8rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r8 + '</span>' + '</br>';
document.getElementById('h9rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r9 + '</span>' + '</br>';
document.getElementById('h10rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r10 + '</span>' + '</br>';
document.getElementById('h11rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r11 + '</span>' + '</br>';
    
    return false;
}
function savegrid()
{
d01=""
d02=""
d03=""
d04=""
d05=""
d06=""
d07=""
d08=""
d09=""
d10=""
d11=""
d12=""
d16=""
d20=""
d24=""
d27=""
d30=""
d40=""
d45=""
d60=""
kl=""
retro=""

for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) 
{
  var planet=document.getElementById('planets_'+i).value;  
  var house=document.getElementById('house_'+i).value;
  var rashi=document.getElementById('rashi_'+i).value;
  var degree=document.getElementById('degree_'+i).value;
  var birth=document.getElementById('birth_'+i).value;
  var cons=document.getElementById('cons_'+i).value;
  var d2house=document.getElementById('d2house_'+i).value;
  var d2rashi=document.getElementById('d2rashi_'+i).value;
  var d3house=document.getElementById('d3house_'+i).value;
  var d3rashi=document.getElementById('d3rashi_'+i).value;
  var d4house=document.getElementById('d4house_'+i).value;
  var d4rashi=document.getElementById('d4rashi_'+i).value;
  var d5house=document.getElementById('d5house_'+i).value;
  var d5rashi=document.getElementById('d5rashi_'+i).value;
  var d6house=document.getElementById('d6house_'+i).value;
  var d6rashi=document.getElementById('d6rashi_'+i).value;
  var d7house=document.getElementById('d7house_'+i).value;
  var d7rashi=document.getElementById('d7rashi_'+i).value;
  var d8house=document.getElementById('d8house_'+i).value;
  var d8rashi=document.getElementById('d8rashi_'+i).value;
  var d9house=document.getElementById('d9house_'+i).value;
  var d9rashi=document.getElementById('d9rashi_'+i).value;
  var d10house=document.getElementById('d10house_'+i).value;
  var d10rashi=document.getElementById('d10rashi_'+i).value;
  var d11house=document.getElementById('d11house_'+i).value;
  var d11rashi=document.getElementById('d11rashi_'+i).value;
  var d12house=document.getElementById('d12house_'+i).value;
  var d12rashi=document.getElementById('d12rashi_'+i).value;
  var d16house=document.getElementById('d16house_'+i).value;
  var d16rashi=document.getElementById('d16rashi_'+i).value;
  var d20house=document.getElementById('d20house_'+i).value;
  var d20rashi=document.getElementById('d20rashi_'+i).value;
  var d24house=document.getElementById('d24house_'+i).value;
  var d24rashi=document.getElementById('d24rashi_'+i).value;
  var d27house=document.getElementById('d27house_'+i).value;
  var d27rashi=document.getElementById('d27rashi_'+i).value;
  var d30house=document.getElementById('d30house_'+i).value;
  var d30rashi=document.getElementById('d30rashi_'+i).value;
  var d40house=document.getElementById('d40house_'+i).value;
  var d40rashi=document.getElementById('d40rashi_'+i).value;
  var d45house=document.getElementById('d45house_'+i).value;
  var d45rashi=document.getElementById('d45rashi_'+i).value;
  var d60house=document.getElementById('d60house_'+i).value;
  var d60rashi=document.getElementById('d60rashi_'+i).value;
  var klhouse=document.getElementById('karkahouse_'+i).value;
  var klrashi=document.getElementById('karkarashi_'+i).value;

  if (document.getElementById('retrograde_' + i).value == "")
  { var rvalue = 'B' }
  else
  { var rvalue = document.getElementById('retrograde_' + i).value }

  var d01 = d01 + document.getElementById('planets_' + i).value + "/" + document.getElementById('rashi_' + i).value + "/" + document.getElementById('house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"

  var d02 = d02 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d2rashi_' + i).value + "/" + document.getElementById('d2house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d03 = d03 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d3rashi_' + i).value + "/" + document.getElementById('d3house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d04 = d04 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d4rashi_' + i).value + "/" + document.getElementById('d4house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d05 = d05 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d5rashi_' + i).value + "/" + document.getElementById('d5house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d06 = d06 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d6rashi_' + i).value + "/" + document.getElementById('d6house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d07 = d07 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d7rashi_' + i).value + "/" + document.getElementById('d7house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d08 = d08 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d8rashi_' + i).value + "/" + document.getElementById('d8house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d09 = d09 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d9rashi_' + i).value + "/" + document.getElementById('d9house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d10 = d10 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d10rashi_' + i).value + "/" + document.getElementById('d10house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d11 = d11 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d11rashi_' + i).value + "/" + document.getElementById('d11house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d12 = d12 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d12rashi_' + i).value + "/" + document.getElementById('d12house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d16 = d16 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d16rashi_' + i).value + "/" + document.getElementById('d16house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d20 = d20 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d20rashi_' + i).value + "/" + document.getElementById('d20house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d24 = d24 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d24rashi_' + i).value + "/" + document.getElementById('d24house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d27 = d27 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d27rashi_' + i).value + "/" + document.getElementById('d27house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d30 = d30 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d30rashi_' + i).value + "/" + document.getElementById('d30house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d40 = d40 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d40rashi_' + i).value + "/" + document.getElementById('d40house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d45 = d45 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d45rashi_' + i).value + "/" + document.getElementById('d45house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d60 = d60 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d60rashi_' + i).value + "/" + document.getElementById('d60house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var kl = kl + document.getElementById('planets_' + i).value + "/" + document.getElementById('karkarashi_' + i).value + "/" + document.getElementById('karkahouse_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
   
  
}

var sunsetpre = document.getElementById('hdsunsetpre').value;
var sunrise = document.getElementById('hdsunrise').value;
var sunset = document.getElementById('hdsunset').value;
var sunrisenext = document.getElementById('hdnsunrisenext').value;
var dayofbirth_val = document.getElementById('hddayofbirth').value;
var rashi_val = document.getElementById("hdrashi").value;
var constellation_val = document.getElementById("hdconstellation").value;
var longitude_val= document.getElementById('hdnlongit').value;
var latitude_val= document.getElementById('hdnlatit').value;
var timezone_val= document.getElementById('hdntzo').value;
var dayduration_val= document.getElementById('hdndayduration').value;
var nightduration_val= document.getElementById('hdnnightduration').value;
var balancedasha_val=document.getElementById('hdnbalancedasha').value;
 var clientquery = document.getElementById('hdnquery').value;

var group = document.getElementById('hdngroup').value;
var dasha = document.getElementById('dasha').value;
var astname=document.getElementById('astname').innerHTML;
  var astid=document.getElementById('astid').innerHTML;
  var client = document.getElementById('clientname').innerHTML;
  var clientid = document.getElementById('clientid').innerHTML;

  var pwdval = "123";
  if (client == "" || clientid == "") {
      alert('Enter Client Name');
      document.getElementById('clinetnamediv').style.display = 'block';
      var astrologer = astid
      res = vargas_chart.searchuser(astrologer, document.getElementById('cat_grp').options[document.getElementById('cat_grp').selectedIndex].text);
      callback_drp1(res)
      return false;
  }

  var res = vargas_chart.chechduplicacy(astid, astname, client, clientid, document.getElementById("hdngroup").value, document.getElementById("hdngroup_u").value);
   var ds=res.value;
   if(ds.Tables[0].Rows.length > 0)
   {
       alert('client chart already saved in this group')
       document.getElementById('clinetnamediv').style.display = 'block';
       var astrologer = astid
       res = vargas_chart.searchuser(astrologer, document.getElementById('hdngroup_u').value);
       callback_drp1(res)
       return false;
   }
   else
   {
       var chartdetails = "";
       var lagnarashi_final = "";
       if (document.getElementById("hdngroup_u").value.toUpperCase() == "HORARY") {
           var ss = "";
           for (i = 1; i <= 10; i++) {
               var dd = document.getElementById('degreefinal_' + i).value
               dd = dd.split('.')
               dd = dd[0] + '.' + dd[1];
               ss = ss + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "~" + dd + "$";
           }
           ss = ss.slice(0, -1);
           chartdetails = ss;
           lagnarashi_final = document.getElementById('rashi_0').value;
       }
       else {
           lagnarashi_final = document.getElementById('rashi_0').value;
       }
       var matchwithval = "";
       var UserType = "4"; // For Astrologer's Clients

       //Code start for lagna/moon//venus chart
       var lagnastr = "", lagna_house = "";
       var moonstr = "", moon_house = "";
       var venusstr = "", venus_house = "";
       for (var i = 0; i < 11; i++) {
           var degree = document.getElementById('degree_' + i).value
           var degree1 = degree.split('.');
           var lagnastr = lagnastr + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
           if (document.getElementById('planets_' + i).value.toUpperCase() == "MARS") {
               lagna_house = document.getElementById('house_' + i).value;
           }
           var moonstr = moonstr + document.getElementById('planets_' + i).value + "~" + document.getElementById('moonrashi_' + i).value + "~" + document.getElementById('moonhouse_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
           if (document.getElementById('planets_' + i).value.toUpperCase() == "MARS") {
               moon_house = document.getElementById('moonhouse_' + i).value;
           }
           var venusstr = venusstr + document.getElementById('planets_' + i).value + "~" + document.getElementById('venusrashi_' + i).value + "~" + document.getElementById('venushouse_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
           if (document.getElementById('planets_' + i).value.toUpperCase() == "MARS") {
               venus_house = document.getElementById('venushouse_' + i).value;
           }
       }
       //Code end for lagna/moon//venus chart

       vargas_chart.savecharts(d01, d02, d03, d04, d05, d06, d07, d08, d09, d10, d11, d12, d16, d20, d24, d27, d30, d40, d45, d60, kl, astid, astname, client, clientid, dasha, document.getElementById("hdndob").value, document.getElementById("hdntob").value, document.getElementById("hdncountry").value, document.getElementById("hdnstate").value, document.getElementById("hdndist").value, document.getElementById("hdncity").value, document.getElementById("hdngroup").value, document.getElementById("hdngroup_u").value, document.getElementById("hdnprof").value, document.getElementById("hdnsex").value, document.getElementById("hdnmobile").value,sunsetpre,sunrise,sunset,sunrisenext,dayofbirth_val,rashi_val,constellation_val,longitude_val,latitude_val,timezone_val,dayduration_val,nightduration_val,balancedasha_val,"", pwdval, lagnarashi_final, chartdetails, matchwithval, lagnastr, moonstr, venusstr, UserType, "", "", "",clientquery)
       alert('Data saved successfully !')
       window.open('astro_client_details.aspx?clientemailid=' + clientid + '');
       return false;
   }
   
  return false;
  
}




function group_bind() {

    var astrologer = document.getElementById('astid').innerHTML;
    if (astrologer == 'astrology' || astrologer == 'ASTROLOGY' || astrologer == "") {
        // alert('you are admin');
        getopen("login.aspx");
        return false;
    }
    else {
        res = vargas_chart.searchuser(astrologer, document.getElementById('cat_grp').options[document.getElementById('cat_grp').selectedIndex].text);

        callback_drp1(res);
   
     
    }
    
}


function chartindexdata()
{
    var degreesecond = "";
    var degree = "";
    var house = "";
  var astname=document.getElementById('astname').innerHTML;
  var astmail=document.getElementById('astid').innerHTML;
  var clname=document.getElementById('clientname').innerHTML;
  var clmail=document.getElementById('clientid').innerHTML;
  var lagnarashi = document.getElementById('rashi_0').value;
  var lagnadegree = document.getElementById('degree_0').value;
  var moonrashi = document.getElementById('rashi_2').value;
  var sunhouse = document.getElementById('house_1').value;
  var moonhouse = document.getElementById('house_2').value;

  var drop1 = document.getElementById('dropyogas').value;


  for (i = 1; i < 10; i++) {
      var spldeg = document.getElementById('degree_' + i).value;
      var teospl = spldeg.split('.');
      var dataf = teospl[0];

      var minsplit = spldeg.split('.');
      var minsecsplit = teospl[1];
      degree = degree + dataf + '.' + minsecsplit + "~";

      degreesecond = degreesecond + dataf + '.' + minsecsplit + '~';

      house = house + document.getElementById('house_' + i).value + "~";
  }

  var asendrashi = document.getElementById('rashi_0').value;
  var suninhouse = document.getElementById('house_1').value;
  var mooninhouse = document.getElementById('house_2').value;
  var marsinhouse = document.getElementById('house_3').value;
  var mrecinhouse = document.getElementById('house_4').value;
  var jupinhouse = document.getElementById('house_5').value;
  var venusinhouse = document.getElementById('house_6').value;
  var saturninhouse = document.getElementById('house_7').value;
  var s = "";
  var astname = document.getElementById('astname').innerHTML;
  var astmail = document.getElementById('astid').innerHTML;
  var clname = document.getElementById('clientname').innerHTML;
  var clmail = document.getElementById('clientid').innerHTML;
  var rashie = ""
  var retro = "";
  for (i = 1; i < 10; i++) {
                 
      rashie = rashie + document.getElementById('rashi_' + i).value + "~"
  }
  for (i = 1; i < 9; i++) {
      if (document.getElementById('retrograde_' + i).value == '' || document.getElementById('retrograde_' + i).value == null)
      { retro = retro + 'B' + "~" }
      else {
          retro = retro + document.getElementById('retrograde_' + i).value + "~";
      }
  }
  retro = retro + 'B' + "~";


  for (i = 1; i <= 10; i++) {
      s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "$";

  }
  s = s.slice(0, -1);
  var v= document.getElementById('Hiddencons').value;
    
  window.open('remedials.aspx?clmail=' + clmail + "&clname=" + clname + "&astname=" + astname + "&astmail=" + astmail + "&lagnarashi=" + lagnarashi + "&lagnadegree=" + lagnadegree + "&degree=" + degree + "&house=" + house + "&drop1=" + drop1 + "&degreesecond=" + degreesecond + "&moonrashi=" + moonrashi + "&sunhouse=" + sunhouse + "&moonhouse=" + moonhouse + "&s=" + s + "&rashie=" + rashie + "&retro=" + retro+ "&usermail=" + document.getElementById('hdnuser').value+ "&v=" + v);
  return false;
}
   





function calculateyogas(id) {
    var degreesecond = "";
var degree="";
var house="";
var astname=document.getElementById('astname').innerHTML;
  var astmail=document.getElementById('astid').innerHTML;
  var clname=document.getElementById('clientname').innerHTML;
  var clmail=document.getElementById('clientid').innerHTML;
 var lagnarashi=document.getElementById('rashi_0').value; 
 var lagnadegree=document.getElementById('degree_0').value;
 var drop1 = id.innerHTML;
 var moonrashi = document.getElementById('rashi_2').value;
 var sunhouse = document.getElementById('house_1').value;
 var moonhouse = document.getElementById('house_2').value;
 
 var rashie=""
 var retro = "";
 for (i = 1; i <10; i++)
 { var spldeg=document.getElementById('degree_'+i).value;
 var teospl=spldeg.split('.');
 var dataf=teospl[0];
 
 var minsplit=spldeg.split('.');
 var minsecsplit=teospl[1];
 degree = degree + dataf + '.' + minsecsplit + "~";


degreesecond = degreesecond +dataf + '.' + minsecsplit + '~';

 house=house+document.getElementById('house_'+i).value+"~";
 rashie=rashie+document.getElementById('rashi_'+i).value+"~"
}
for (i = 1; i <= 9; i++) {
    if (document.getElementById('retrograde_' + i).value == '' || document.getElementById('retrograde_' + i).value == null)
    { retro = retro + 'B' + "~" }
    else {
        retro = retro + document.getElementById('retrograde_' + i).value + "~";
    }
}

 //retro = 'B' + "~" + 'B' + "~" + 'B' + "~" + 'B' + "~" + 'B' + "~" + 'B' + "~" + 'B' + "~" + 'B' + "~" + 'B' + "~";

var v = document.getElementById('Hiddencons').value;

var asendrashi = document.getElementById('rashi_0').value;
var suninhouse=document.getElementById('house_1').value;
var mooninhouse=document.getElementById('house_2').value;
var marsinhouse=document.getElementById('house_3').value;
var mrecinhouse=document.getElementById('house_4').value;
var jupinhouse=document.getElementById('house_5').value;
var venusinhouse=document.getElementById('house_6').value;
var saturninhouse = document.getElementById('house_7').value;
var imonthob = document.getElementById('hdnimonthob').value
var idateob = document.getElementById('hdnidateob').value
var iyearob = document.getElementById('hdniyearob').value

var ihourob = document.getElementById('hdnihourob').value
var iminuteob = document.getElementById('hdniminuteob').value
if (drop1 == 'Calculate Karyasiddhi Yoga')
{
    drop1 = 'Karya Siddhi Yoga'
}
else if (drop1 == 'Calculate Future Horary Yoga') {
    drop1 = 'Future Horary Yoga'
}
else

{
    drop1 = 'Horary Yogas'
}

var dob = document.getElementById('hdndob').value;
var tob = document.getElementById('hdntob').value;
var tz = document.getElementById('hdntzo').value;
var tzval = document.getElementById('hdntzval').value;
var clientquery = document.getElementById('hdnquery').value;

if (drop1 == 'Karya Siddhi Yoga')
  {
     window.open('yogas.aspx?clmail=' + clmail + "&clname=" + clname + "&astname=" + astname + "&astmail=" + astmail + "&asendrashi=" + asendrashi + "&suninhouse=" + suninhouse + "&mooninhouse=" + mooninhouse + "&marsinhouse=" + marsinhouse + "&mrecinhouse=" + mrecinhouse + "&jupinhouse=" + jupinhouse + "&venusinhouse=" + venusinhouse + "&saturninhouse=" + saturninhouse + "&drop1=" + drop1+ "&usermail=" + document.getElementById('hdnuser').value + "&v=" + v + "&longitude=" + document.getElementById('hdnlongit').value + "&latitude=" + document.getElementById('hdnlatit').value + "&dob=" + dob + "&tob=" + tob + "&tz=" + tz + "&tzval=" + tzval + "&query="+clientquery + "");
}
else if (drop1 == 'Future Horary Yoga') {
    window.open('futureyogas.aspx?clmail=' + clmail + "&clname=" + clname + "&astname=" + astname + "&astmail=" + astmail + "&lagnarashi=" + lagnarashi + "&lagnadegree=" + lagnadegree + "&degree=" + degree + "&house=" + house + "&drop1=" + drop1 + "&degreesecond=" + degreesecond + "&moonrashi=" + moonrashi + "&sunhouse=" + sunhouse + "&moonhouse=" + moonhouse + "&retro=" + retro + "&rashie=" + rashie + "&usermail=" + document.getElementById('hdnuser').value + "&v=" + v + "&idateob=" + idateob + "&imonthob=" + imonthob + "&iyearob=" + iyearob + "&ihourob=" + ihourob + "&iminuteob=" + iminuteob + "&longitude=" + document.getElementById('hdnlongit').value + "&latitude=" + document.getElementById('hdnlatit').value + "&query="+clientquery + "");
}
 else 
 {
    window.open('yogas.aspx?clmail=' + clmail + "&clname=" + clname + "&astname=" + astname + "&astmail=" + astmail + "&lagnarashi=" + lagnarashi + "&lagnadegree=" + lagnadegree + "&degree=" + degree + "&house=" + house + "&drop1=" + drop1 + "&degreesecond=" + degreesecond + "&moonrashi=" + moonrashi + "&sunhouse=" + sunhouse + "&moonhouse=" + moonhouse + "&retro=" + retro + "&rashie=" + rashie + "&usermail=" + document.getElementById('hdnuser').value + "&v=" + v + "&idateob=" + idateob + "&imonthob=" + imonthob + "&iyearob=" + iyearob + "&ihourob=" + ihourob + "&iminuteob=" + iminuteob + "&longitude=" + document.getElementById('hdnlongit').value + "&latitude=" + document.getElementById('hdnlatit').value + "&dob=" + dob + "&tob=" + tob + "&tz=" + tz + "&tzval=" + tzval + "&query="+clientquery + "");
 }
 return false;


}



function hidediv() 
{
    d01 = ""
    d02 = ""
    d03 = ""
    d04 = ""
    d05 = ""
    d06 = ""
    d07 = ""
    d08 = ""
    d09 = ""
    d10 = ""
    d11 = ""
    d12 = ""
    d16 = ""
    d20 = ""
    d24 = ""
    d27 = ""
    d30 = ""
    d40 = ""
    d45 = ""
    d60 = ""
    kl = ""
    retro = ""

    for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {
        var planet = document.getElementById('planets_' + i).value;
        var house = document.getElementById('house_' + i).value;
        var rashi = document.getElementById('rashi_' + i).value;
        var degree = document.getElementById('degree_' + i).value;
        var birth = document.getElementById('birth_' + i).value;
        var cons = document.getElementById('cons_' + i).value;
        var d2house = document.getElementById('d2house_' + i).value;
        var d2rashi = document.getElementById('d2rashi_' + i).value;
        var d3house = document.getElementById('d3house_' + i).value;
        var d3rashi = document.getElementById('d3rashi_' + i).value;
        var d4house = document.getElementById('d4house_' + i).value;
        var d4rashi = document.getElementById('d4rashi_' + i).value;
        var d5house = document.getElementById('d5house_' + i).value;
        var d5rashi = document.getElementById('d5rashi_' + i).value;
        var d6house = document.getElementById('d6house_' + i).value;
        var d6rashi = document.getElementById('d6rashi_' + i).value;
        var d7house = document.getElementById('d7house_' + i).value;
        var d7rashi = document.getElementById('d7rashi_' + i).value;
        var d8house = document.getElementById('d8house_' + i).value;
        var d8rashi = document.getElementById('d8rashi_' + i).value;
        var d9house = document.getElementById('d9house_' + i).value;
        var d9rashi = document.getElementById('d9rashi_' + i).value;
        var d10house = document.getElementById('d10house_' + i).value;
        var d10rashi = document.getElementById('d10rashi_' + i).value;
        var d11house = document.getElementById('d11house_' + i).value;
        var d11rashi = document.getElementById('d11rashi_' + i).value;
        var d12house = document.getElementById('d12house_' + i).value;
        var d12rashi = document.getElementById('d12rashi_' + i).value;
        var d16house = document.getElementById('d16house_' + i).value;
        var d16rashi = document.getElementById('d16rashi_' + i).value;
        var d20house = document.getElementById('d20house_' + i).value;
        var d20rashi = document.getElementById('d20rashi_' + i).value;
        var d24house = document.getElementById('d24house_' + i).value;
        var d24rashi = document.getElementById('d24rashi_' + i).value;
        var d27house = document.getElementById('d27house_' + i).value;
        var d27rashi = document.getElementById('d27rashi_' + i).value;
        var d30house = document.getElementById('d30house_' + i).value;
        var d30rashi = document.getElementById('d30rashi_' + i).value;
        var d40house = document.getElementById('d40house_' + i).value;
        var d40rashi = document.getElementById('d40rashi_' + i).value;
        var d45house = document.getElementById('d45house_' + i).value;
        var d45rashi = document.getElementById('d45rashi_' + i).value;
        var d60house = document.getElementById('d60house_' + i).value;
        var d60rashi = document.getElementById('d60rashi_' + i).value;
        var klhouse = document.getElementById('karkahouse_' + i).value;
        var klrashi = document.getElementById('karkarashi_' + i).value;

        
        if (document.getElementById('retrograde_' + i).value == "")
        { var rvalue = 'B'}
        else
        { var rvalue = document.getElementById('retrograde_' + i).value }
        var d01 = d01 + document.getElementById('planets_' + i).value + "/" + document.getElementById('rashi_' + i).value + "/" + document.getElementById('house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"


        var d02 = d02 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d2rashi_' + i).value + "/" + document.getElementById('d2house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d03 = d03 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d3rashi_' + i).value + "/" + document.getElementById('d3house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d04 = d04 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d4rashi_' + i).value + "/" + document.getElementById('d4house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d05 = d05 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d5rashi_' + i).value + "/" + document.getElementById('d5house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d06 = d06 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d6rashi_' + i).value + "/" + document.getElementById('d6house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d07 = d07 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d7rashi_' + i).value + "/" + document.getElementById('d7house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d08 = d08 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d8rashi_' + i).value + "/" + document.getElementById('d8house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d09 = d09 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d9rashi_' + i).value + "/" + document.getElementById('d9house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d10 = d10 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d10rashi_' + i).value + "/" + document.getElementById('d10house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d11 = d11 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d11rashi_' + i).value + "/" + document.getElementById('d11house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d12 = d12 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d12rashi_' + i).value + "/" + document.getElementById('d12house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d16 = d16 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d16rashi_' + i).value + "/" + document.getElementById('d16house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d20 = d20 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d20rashi_' + i).value + "/" + document.getElementById('d20house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d24 = d24 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d24rashi_' + i).value + "/" + document.getElementById('d24house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d27 = d27 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d27rashi_' + i).value + "/" + document.getElementById('d27house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d30 = d30 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d30rashi_' + i).value + "/" + document.getElementById('d30house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d40 = d40 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d40rashi_' + i).value + "/" + document.getElementById('d40house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d45 = d45 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d45rashi_' + i).value + "/" + document.getElementById('d45house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d60 = d60 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d60rashi_' + i).value + "/" + document.getElementById('d60house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var kl = kl + document.getElementById('planets_' + i).value + "/" + document.getElementById('karkarashi_' + i).value + "/" + document.getElementById('karkahouse_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"


    }

    var astname = document.getElementById('astname').innerHTML;
    var astid = document.getElementById('astid').innerHTML;
    
     //var client = document.getElementById('clientname').innerHTML;
     //var clientid = document.getElementById('clientid').innerHTML;
  
    var clientid = document.getElementById('clientidtextbox').value;
        if(clientid=="")
         {
             alert('Please Enter Emailid');
        return false;
        }
            var  client = document.getElementById('clientnametextbox').value;
            if(client=="") {
                alert('Please Enter Name');
        
        return false;
        }

            var dasha = document.getElementById('dasha').value;
            var group = document.getElementById('groupdrop').value;
            if (group == 0)
            {
                group= document.getElementById('groupdrop').options[document.getElementById('groupdrop').selectedIndex].text;
            }
            var groupcat = document.getElementById('cat_grp').options[document.getElementById('cat_grp').selectedIndex].text
            
            var res = vargas_chart.chechduplicacy(astid, astname, client, clientid, group, groupcat);

       // var res = vargas_chart.chechduplicacy(astid, astname, client, clientid, group);
    var ds = res.value;
    if (ds.Tables[0].Rows.length > 0) {
        alert('client Horoscope already saved');
        document.getElementById('clinetnamediv').style.display = 'none';
        document.getElementById('clientnametextbox').value="";
        document.getElementById('clientidtextbox').value="";
    }
    else {
      
        if (document.getElementById('cat_grp').selectedIndex == '0') {
            alert('Please select group category');
            return false;
        }
        
        
        var sunsetpre = document.getElementById('hdsunsetpre').value;
        var sunrise = document.getElementById('hdsunrise').value;
        var sunset = document.getElementById('hdsunset').value;
        var sunrisenext = document.getElementById('hdnsunrisenext').value;
        var dayofbirth_val = document.getElementById('hddayofbirth').value;
        var rashi_val = document.getElementById("hdrashi").value;
        var constellation_val = document.getElementById("hdconstellation").value;
        var longitude_val= document.getElementById('hdnlongit').value;
        var latitude_val= document.getElementById('hdnlatit').value;
        var timezone_val= document.getElementById('hdntzo').value;
        var dayduration_val= document.getElementById('hdndayduration').value;
        var nightduration_val= document.getElementById('hdnnightduration').value;
        var balancedasha_val=document.getElementById('hdnbalancedasha').value;
        var clientquery = document.getElementById('hdnquery').value;
 
        vargas_chart.savecharts(d01, d02, d03, d04, d05, d06, d07, d08, d09, d10, d11, d12, d16, d20, d24, d27, d30, d40, d45, d60, kl, astid, astname, client, clientid, dasha,  document.getElementById("hdndob").value, document.getElementById("hdntob").value, document.getElementById("hdncountry").value, document.getElementById("hdnstate").value, document.getElementById("hdndist").value, document.getElementById("hdncity").value, group,groupcat, document.getElementById("hdnprof").value, document.getElementById("hdnsex").value, document.getElementById("hdnmobile").value,sunsetpre,sunrise,sunset,sunrisenext,dayofbirth_val,rashi_val,constellation_val,longitude_val,latitude_val,timezone_val,dayduration_val,nightduration_val,balancedasha_val,clientquery);
        alert('Data saved successfully !')
        document.getElementById('clinetnamediv').style.display = 'none';
        document.getElementById('clientnametextbox').value = "";
        document.getElementById('clientidtextbox').value = "";
    }
    return false;

}


function creossdiv() {
    document.getElementById('clinetnamediv').style.display = 'none';
    return false;
}


function yoga() {
    var s = "";
    var astname = document.getElementById('astname').innerHTML;
    var astmail = document.getElementById('astid').innerHTML;
    var clname = document.getElementById('clientname').innerHTML;
    var clmail = document.getElementById('clientid').innerHTML;

    for (i = 0; i <= 10; i++) {
        s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "$";
      
    }
    s = s.slice(0, -1);
   
    window.open('yoga.aspx?clmail=' + clmail + "&clname=" + clname + "&astname=" + astname + "&astmail=" + astmail + "&s=" + s+ "&usermail=" + document.getElementById('hdnuser').value);
   
    return false;


}
function openhorcomb() {
    var degreesecond = "";
    var degree = "";
    var house = "";
    var astname = document.getElementById('astname').innerHTML;
    var astmail = document.getElementById('astid').innerHTML;
    var clname = document.getElementById('clientname').innerHTML;
    var clmail = document.getElementById('clientid').innerHTML;
    var lagnarashi = document.getElementById('rashi_0').value;
    var lagnadegree = document.getElementById('degree_0').value;
    var drop1 = document.getElementById('dropyogas').value;
    var moonrashi = document.getElementById('rashi_2').value;
    var sunhouse = document.getElementById('house_1').value;
    var moonhouse = document.getElementById('house_2').value;

   

    for (i = 1; i < 10; i++) {
        var spldeg = document.getElementById('degree_' + i).value;
        var teospl = spldeg.split('.');
        var dataf = teospl[0];

        var minsplit = spldeg.split('.');
        var minsecsplit = teospl[1];
        degree = degree + dataf + '.' + minsecsplit + "~";

        degreesecond = degreesecond + dataf + '.' + minsecsplit + '~';

        house = house + document.getElementById('house_' + i).value + "~";
    }

    var asendrashi = document.getElementById('rashi_0').value;
    var suninhouse = document.getElementById('house_1').value;
    var mooninhouse = document.getElementById('house_2').value;
    var marsinhouse = document.getElementById('house_3').value;
    var mrecinhouse = document.getElementById('house_4').value;
    var jupinhouse = document.getElementById('house_5').value;
    var venusinhouse = document.getElementById('house_6').value;
    var saturninhouse = document.getElementById('house_7').value;
     var s = "";
     var astname = document.getElementById('astname').innerHTML;
     var astmail = document.getElementById('astid').innerHTML;
     var clname = document.getElementById('clientname').innerHTML;
     var clmail = document.getElementById('clientid').innerHTML;
     var rashie = ""
     var retro = "";
     for (i = 1; i < 10; i++) {
                 
         rashie = rashie + document.getElementById('rashi_' + i).value + "~"
     }
     for (i = 1; i < 9; i++) {
         if (document.getElementById('retrograde_' + i).value == '' || document.getElementById('retrograde_' + i).value == null)
         { retro = retro + 'B' + "~" }
         else {
             retro = retro + document.getElementById('retrograde_' + i).value + "~";
         }
     }
     retro = retro + 'B' + "~";


     for (i = 1; i <= 10; i++) {

         var d = document.getElementById('degree_' + i).value
         d = d.split('.')
         d=d[0] + '.' + d[1];
         s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "~" + d + "$";

     }
     s = s.slice(0, -1);
    var v= document.getElementById('Hiddencons').value;
    // window.open('horarycombination.aspx?clmail=' + clmail + "&clname=" + clname + "&astname=" + astname + "&astmail=" + astmail + "&s=" + s +"&lagnarashi=" + lagnarashi + "&lagnadegree=" + lagnadegree + "&degree=" + degree + "&house=" + house + "&drop1=" + drop1 + "&degreesecond=" + degreesecond + "&moonrashi=" + moonrashi + "&sunhouse=" + sunhouse + "&moonhouse=" + moonhouse);
     window.open('horarycombination.aspx?clmail=' + clmail + "&clname=" + clname + "&astname=" + astname + "&astmail=" + astmail + "&lagnarashi=" + lagnarashi + "&lagnadegree=" + lagnadegree + "&degree=" + degree + "&house=" + house + "&drop1=" + drop1 + "&degreesecond=" + degreesecond + "&moonrashi=" + moonrashi + "&sunhouse=" + sunhouse + "&moonhouse=" + moonhouse + "&s=" + s + "&rashie=" + rashie + "&retro=" + retro+ "&usermail=" + document.getElementById('hdnuser').value+ "&v=" + v);
     return false;
 }
 
 

 function callback_drp1(res) {
     var ds = res.value;
     var edtn = $("groupdrop");
     edtn.options.length = 1;
     edtn.options[0] = new Option("General", "0");
     if (ds != null && typeof (ds) == "object" && ds.Tables[1].Rows.length > 0) {
         for (var i = 0; i < ds.Tables[1].Rows.length; i++) {
             edtn.options[edtn.options.length] = new Option(ds.Tables[1].Rows[i].CAT_ID, ds.Tables[1].Rows[i].CAT_ID)
             edtn.options.length;
         }
     }
     
 }
