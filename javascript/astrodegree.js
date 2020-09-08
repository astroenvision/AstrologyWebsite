var astrodegree = "";
var exec_data = "";
var next = 0;
var execute = "";
var exec_data1 = "";
var Modify = 0;
var delete_record = 0;
var ds1="";
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


function gridcall() {
    grid();
    for (var i = 0; i <= 9; i++) {
        grid1();
    } 
document.getElementById('seconds_9').disabled=true;
document.getElementById('minutes_9').disabled=true;
document.getElementById('degree_9').disabled=true;
document.getElementById('house_1').disabled=true;
document.getElementById('house_2').disabled=true;
document.getElementById('house_3').disabled=true;
document.getElementById('house_4').disabled=true;
document.getElementById('house_5').disabled=true;
document.getElementById('house_6').disabled=true;
document.getElementById('house_7').disabled=true;
document.getElementById('house_8').disabled=true;
document.getElementById('house_9').disabled=true;
document.getElementById('rashi_9').disabled=true;

document.getElementById('retrograde_10').style.display='none';
document.getElementById('degree_10').style.display='none';
document.getElementById('minutes_10').style.display='none';
document.getElementById('seconds_10').style.display='none';
document.getElementById('constelation_10').style.display='none';




    for (var kk = 0; kk < 11; kk++) 
    {
        binddropdown("planets_" + kk);
        bindrashi("rashi_" + kk);
        bindhouse("house_" + kk);
        
       // bindbirth("birth_"+kk);
     
        binddropdown("planets_" + kk);
        bindrashi("rashi_" + kk);
        bindhouse("house_" + kk);
        
        binddegree("degree_" + kk);
        bindminutes("minutes_" + kk);
        bindseconds("seconds_" + kk);
        bindretrograde("retrograde_" + kk);
        bindconstelation("constelation_" + kk);
    }
}



function grid()
 {
    document.getElementById('Divgrid1').style.top = 150 + "px";
  document.getElementById('Divgrid1').style.left = -180 + "px";
    document.getElementById('Divgrid1').style.BackColor = "Ivory";
    var temp_del1 = "";

    flg_req = "yes"
    var aa1 = "";
    var aa = "";
    var hs = 0;
    var hs1 = 0;
    //alert('kkk')
    //alert(document.getElementById("datagrid1").childNodes[0])
    document.getElementById('hdsviewgrid').style.display = "block";
    $('hdsviewgrid').style.display = "block";
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

    if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:510px;display:block") <= 0) {
        aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
    }

    buf1 += "<table  class='gridview' id='Divgrid1' runat='server' align='center' Width='800px' height='0px' style='border:1px;margin-left:200px; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
    buf1 += "<tr>"
    buf1 += "<td  bgcolor=#7DAAE3 style='height:20px;width:100px;font-size:15px;text-align:center;border:1px solid #ffffff;'>" + "Planets" + "</td>"
    buf1 += "<td  bgcolor=#7DAAE3 style='height:20px;width:100px;font-size:15px;text-align:center;border:1px solid #ffffff;'>" + "Rashi" + "</td>"
    buf1 += "<td  bgcolor=#7DAAE3 style='height:20px;width:100px;font-size:15px;text-align:center;border:1px solid #ffffff;'>" + "House" + "</td>"
    buf1 += "<td  bgcolor=#7DAAE3 style='height:20px;width:100px;font-size:15px;text-align:center;border:1px solid #ffffff;'>" + "Degree" + "</td>"
    buf1 += "<td  bgcolor=#7DAAE3 style='height:20px;width:100px;font-size:15px;text-align:center;border:1px solid #ffffff;'>" + "Minutes" + "</td>"
    buf1 += "<td  bgcolor=#7DAAE3 style='height:20px;width:100px;font-size:15px;text-align:center;border:1px solid #ffffff;'>" + "Seconds" + "</td>"
    buf1 += "<td  bgcolor=#7DAAE3 style='height:20px;width:100px;font-size:15px;text-align:center;border:1px solid #ffffff;'>" + "Retrograde" + "</td>"
    buf1 += "<td  bgcolor=#7DAAE3 style='height:20px;width:100px;font-size:15px;text-align:center;border:1px solid #ffffff;'>" + "Constelation" + "</td>"
    


    buf1 += "</tr>"

    len = 1;


    buf1 += "<tr>"


    buf1 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
    buf1 += "<input type='text'style='width:100px;'class='dropdown_large_corr'; align='left'   id='planets_" + klen + "'  >"
    buf1 += "</td>"
    
    
    
    buf1 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
    buf1 += "<select style='width:100px;'class='dropdown_large_corr'; align='left' AutoPostBack='true' id='rashi_" + klen + "' onChange='javascript:return enablerashi(this.id);'>"
    buf1 += "</td>"

    buf1 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
    buf1 += "<input type='text' Enabled='false' style='width:100px;'class='dropdown_large_corr'; align='left' value='HOUSE1' id='house_" + klen + "' >"
    buf1 += "</td>"

    buf1 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
    buf1 += "<select  style='width:100px;'class='dropdown_large_corr'; align='left' id='degree_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
    buf1 += "<select  style='width:100px;'class='dropdown_large_corr'; align='left' id='minutes_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
    buf1 += "<select  style='width:100px;'class='dropdown_large_corr'; align='left' id='seconds_" + klen + "' onChange='javascript:return selectconstellation(this.id);' >"
    buf1 += "</td>"


    buf1 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
    buf1 += "<select  style='width:100px;'class='dropdown_large_corr'; align='left' id='retrograde_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
    buf1 += "<select  disabled style='width:100px;'class='dropdown_large_corr'; align='left' id='constelation_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "</tr>"






    buf1 += "</table>"
    var hdsview = "";
    temp_del1 = aa + buf1.toString();
    temp_del1 = temp_del1.replace("<TBODY>", "")
    temp_del1 = temp_del1.replace("</TBODY>", "")
    //alert(temp_del1)
    document.getElementById('hdsviewgrid').innerHTML = temp_del1;


   
    return false;




}


function grid1() {

    flg_req = "yes"
    var aa1 = "";
    var aa = "";
    var hs = 0;
    var hs1 = 0;


    klen = document.getElementById("hdsviewgrid").childNodes[0].childNodes[0].childNodes.length - 1;

    buf1 = document.getElementById("hdsviewgrid").innerHTML;

    if (browser != "Microsoft Internet Explorer") {
        buf1 = buf1.replace("</tbody></table>", "");
    }
    else {
        buf1 = buf1.replace("</TBODY></TABLE>", "");
    }


    buf1 += "<tr>"

    buf1 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
    buf1 += "<input type='text' style='width:100px;'class='dropdown_large_corr'; align='left' id='planets_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
    buf1 += "<select disabled style='width:100px;'class='dropdown_large_corr'; align='left' AutoPostBack='true' id='rashi_" + klen + "' onChange='javascript:return selectrashi(this.id);' >"
    buf1 += "</td>"

    buf1 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
    buf1 += "<select style='width:100px;'class='dropdown_large_corr'; align='left' AutoPostBack='true' id='house_" + klen + "'  onChange='javascript:return selecthouse(this.id);' >"
    buf1 += "</td>"

    buf1 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
    buf1 += "<select  style='width:100px;'class='dropdown_large_corr'; align='left' id='degree_" + klen + "'onChange='javascript:return selectrahu(this.id);'>"
    buf1 += "</td>"

    buf1 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
    buf1 += "<select  style='width:100px;'class='dropdown_large_corr'; align='left' id='minutes_" + klen + "'onChange='javascript:return selectminute(this.id);'>"
    buf1 += "</td>"

    buf1 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
    buf1 += "<select  style='width:100px;'class='dropdown_large_corr'; align='left' id='seconds_" + klen + "' onChange='javascript:return selectconstellation(this.id);'>"
    buf1 += "</td>"
    
    buf1 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
    buf1 += "<select  style='width:100px;'class='dropdown_large_corr'; align='left' id='retrograde_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
    buf1 += "<select disabled style='width:100px;'class='dropdown_large_corr'; align='left' id='constelation_" + klen + "' >"
    buf1 += "</td>"
    
    

    buf1 += "</tr>"




    if (browser != "Microsoft Internet Explorer") {
        buf1 += "</TBODY></table>"
    }
    else {
        buf1 += "</TBODY></TABLE>"
    }
    $("hdsviewgrid").innerHTML = buf1.toString();

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
                
    if (res == "planets_10") {
    document.getElementById(res).value = "GULIKA";

}

               
    }


    function bindrashi(res) {

        var vishu = "";
        var res1 = astrodegree.bindrashi(vishu);
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
            var res1 = astrodegree.bindhouse(vishu);
            var ds = res1.value;

            document.getElementById(res).options.length = 0;
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
        var res1 = astrodegree.binddegree(vishu);
        var ds = res1.value;

        document.getElementById(res).options.length = 0;
        document.getElementById(res).options[0] = new Option("--Select Degree--", "0");

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
        var res1 = astrodegree.bindminutes(vishu);
        var ds = res1.value;

        document.getElementById(res).options.length = 0;
        document.getElementById(res).options[0] = new Option("--Select Minutes--", "0");

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
        var res1 = astrodegree.bindseconds(vishu);
        var ds = res1.value;

        document.getElementById(res).options.length = 0;
        document.getElementById(res).options[0] = new Option("--Select Seconds--", "0");

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
        var res1 = astrodegree.bindretrograde(vishu);
        var ds = res1.value;

        document.getElementById(res).options.length = 0;
        document.getElementById(res).options[0] = new Option("--Select Retrograde--", "0");

        var i;
        //    if(ds!=null)
        //    {
        if (ds.Tables[0].Rows.length > 0) {
            for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
                document.getElementById(res).options[document.getElementById(res).options.length] = new Option(ds.Tables[0].Rows[i].CATE, ds.Tables[0].Rows[i].CODE);
                document.getElementById(res).options.length;
            }
        }


    }

    function bindconstelation(res) {

        var vishu = "";
        var res1 = astrodegree.bindconstelation(vishu);
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
        var house = document.getElementById("house_" + 0).value
        var rashi = document.getElementById("rashi_" + 0).value
        var selectedrashi = document.getElementById(id).value
        var re = astrodegree.housevalue(house, rashi, selectedrashi);
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
        var re = astrodegree.rashivalue(house, rashi, selectedhouse);
        var ds = re.value;

        document.getElementById("rashi_" + id2).value = ds.Tables[0].Rows[0].CODE;
        if (id2 == '8') {
            document.getElementById("house_9").value = ds.Tables[1].Rows[0].CODE;
            document.getElementById("rashi_9").value = ds.Tables[2].Rows[0].CODE;
        }
    }



    function selectconstellation(id) {
        var second = id.split('_')
        var seconds1 = second[1]

        var house = document.getElementById("house_" + seconds1).value
        var rashi = document.getElementById("rashi_" + seconds1).value
        var a = document.getElementById('seconds_'+8).value;
         document.getElementById('seconds_'+9).value=a;
 
        var degree = document.getElementById("degree_" + seconds1).value
        var minutes = document.getElementById("minutes_" + seconds1).value
        var seconds = document.getElementById("seconds_" + seconds1).value
        var degreevalue = degree + '.' + minutes + '.' + seconds;

        var cons = astrodegree.getconstellation(rashi, degreevalue);
        var ds=cons.value;
        document.getElementById("constelation_" + seconds1).value = ds.Tables[0].Rows[0].CONSTELLATION;
         var a = document.getElementById('constelation_'+8).value;
         document.getElementById('constelation_'+9).value=a;
 
    }
    
    
    
    
    
    
    
    
    
    
    
    
    var ds2 = "";
   
    function search123() {
    var chart="D01";
      
        document.getElementById('hdsviewgrid2').innerHTML = "";
        document.getElementById('Divgrid2').style.display = "none";
        var planets = "";
        var key = "";
    var kk = "";
    
    var ss = "";
    //var ds1 = "";
    for ( var i = 0; i < document.getElementById('lstcategery').options.length; ++i) {
        if (document.getElementById('lstcategery').options[i].selected == true) {
            ss = ss + document.getElementById('lstcategery').options[i].innerHTML + "$";
            document.getElementById('CheckBox2').checked = true;
        }

    }

    if (document.getElementById('CheckBox1').checked == true) 
    {
        kk = 1;
       
        document.getElementById('CheckBox2').checked == false
    }
   else if (document.getElementById('CheckBox2').checked == true) 
    {
        kk = 0;
        
        document.getElementById('CheckBox1').checked == false
    }
   else {
    
    kk="";
   
}



if (ss != "") {
    ss= ss.slice(0, -1);
        if (document.getElementById('CheckBox1').checked == false && document.getElementById('CheckBox2').checked == false) {
            alert("Please Select Checkbox");
            return false;

        } 
    }
    
        var s = "";
        for (var i = 0; i < 11; i++) {
            document.getElementById('degree_10').value="00";
document.getElementById('minutes_10').value="00";
document.getElementById('seconds_10').value="00";
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "~" + document.getElementById('degree_' + i).value + "~" + document.getElementById('minutes_' + i).value + "~" + document.getElementById('seconds_' + i).value + "~" + document.getElementById('retrograde_' + i).value + "~" + document.getElementById('constelation_' + i).value +"~"+"0"+"$";
         
        }
        var rashi = document.getElementById('rashi_' + 0).value;
        key = document.getElementById('k1').value;
        
         
        
        if(document.getElementById('CheckBoxSun').checked == true)
        {
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
         

         var res1 = astrodegree.searchdesc(s, ss, kk,  rashi, key, planets,chart);
       
         ds1 = res1.value;

       
        
        document.getElementById('Divgrid2').style.top =700 + "px";
        document.getElementById('Divgrid2').style.left = -90 + "px";
        document.getElementById('Divgrid2').style.BackColor = "Ivory";
        var temp_del1 = "";

        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;
        var flag = "0";
        document.getElementById('hdsviewgrid2').style.display = "block";
        document.getElementById('Divgrid2').style.display = "block";
       
        
        if (document.getElementById("hdsviewgrid2").children.length == "0") {
            klen = "0"
        }
        else 
        {
            klen = document.getElementById("Divgrid2").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }


        if (document.getElementById("Divgrid2").innerHTML.indexOf("width:900px;display:block") <= 0) {
            aa = document.getElementById("Divgrid2").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
         buf2 = document.getElementById("hdsviewgrid2").innerHTML;
         if (browser != "Microsoft Internet Explorer") {
        buf2 = buf2.replace("</tbody></table>", "");
    }
    else {
        buf2 = buf2.replace("</TBODY></TABLE>", "");
    }
        
        buf2 = "";
        buf2 += "<table  id='hdsviewgrid2' runat='server' align='center' Width='750px' height='40px' style='border:1px;margin-left:100px; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:200px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "DESCRIPTION" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:100px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "KEY_STRING" + "</td>"

        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:250px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "DETAIL_DESCRIPTION" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "EXPLANATION" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:100px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "BOOK" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:50px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "DETAIL" + "</td>"
        
      
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:50px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "UPDATE" + "</td>"
        
        buf2 += "</tr>"

        len = 1;

        if (ds1.Tables[0].Rows.length > 0) {
            for (i = 0; i < ds1.Tables[0].Rows.length; ++i) {




              

                buf2 += "<tr>"

               
                    
                        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                        buf2 += "<textarea type='text' style='width:150px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr';  id='description_" + i + "'>" + ds1.Tables[0].Rows[i]['DESCRIPTION'] + "</textarea>" 
                        buf2 += "</td>"
                    
                 if (ds1.Tables[0].Rows[i]['KEY_STRING'] == null) {
                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<textarea type='text' style='width:200px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='key_" + i + "'>" + "</textarea>" 
                    buf2 += "</td>"
                }
                else {
                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<textarea type='text' style='width:200px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='key_" + i + "'>" + ds1.Tables[0].Rows[i]['KEY_STRING'] + "</textarea>" 
                    buf2 += "</td>"
                }


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:250px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr';  id=detaild_" + i + "  >" + ds1.Tables[0].Rows[i]['DESCCLOB']+ "</textarea>" 
                buf2 += "</td>"
                
                
                
                if (ds1.Tables[0].Rows[i]['EXPLANATION'] == null) {
                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<textarea type='text' style='width:60px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='explain_" + i + "'>" + "</textarea>" 
                    buf2 += "</td>"
                }
                else {
                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<textarea type='text' style='width:60px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='explain_" + i + "'>" + ds1.Tables[0].Rows[i]['EXPLANATION'] + "</textarea>" 
                    buf2 += "</td>"
                    
                }
                
                 buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:100px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr';  id=book_" + i + "  >" + ds1.Tables[0].Rows[i]['BOOK']+ "</textarea>" 
                buf2 += "</td>"
                

               
                
                
                buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:50px; ' align='left' class='dropdown_large_corr'; Text='Detail' value='Detail' AutoPostBack='true' id=detail_" + i + " onClick='javascript:return descclob1(id);' >More...</Button>"
                buf2 += "</td>"



              
          
          
                buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:50px; ' align='left' Text='Update' class='dropdown_large_corr'; value='Update' AutoPostBack='true' id=update_" + i + " onClick='javascript:return update1234(id);' >Update...</Button>"
                buf2 += "</td>"


               

                buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<input type='text' style='display:none; font-family:helvetica;' align='left' class='dropdown_large_corr'; id=text_" + i + " >"
                buf2 += "</td>"


                
              
                buf2 += "</tr>"
            }
        }
        buf2 += "</table>"
        
    if (browser != "Microsoft Internet Explorer") {
        buf2 += "</TBODY></table>"
    }
    else {
        buf2 += "</TBODY></TABLE>"
    }
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
      //  alert(temp_del1);
      
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('hdsviewgrid2').innerHTML = temp_del1;
        return false;




    }
   
    

    





    function descclob1(id) {




        document.getElementById('hidden123').value = id;
  

        var detail = id.split('_')
        var detail1 = detail[1];
        document.getElementById("Div3").style.display = "block";


           
            $('Div3').style.top = findPos($(id), "top");
            $('Div3').style.left = findPos($(id), "left")

        document.getElementById("list").value = document.getElementById("detaild_" + detail1).value;
        return false;
    }



    function fillcategery(event) {
      
        
        var keycode = event.keyCode ? event.keyCode : event.which;
        if (keycode == 113) 
        {
            if (document.activeElement.id == "categery") {



                document.getElementById('lstcategery').value = "";
                //var compcode = $('hdncompcode').value;
                //var unit=$('hdnunitcode').value;          
                document.getElementById("divcategery").style.display = "block";
                document.getElementById('divcategery').style.top = 440 + "px";
                document.getElementById('divcategery').style.left = 150 + "px";
                var extra1 = document.getElementById('categery').value;
                document.getElementById('categery').focus();
                astrodegree.fill_categery(extra1, callback_fillcategery)

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
        for ( var i = 0; i < document.getElementById('lstcategery').options.length; ++i) 
        {
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


    function update1234(id)
     {
        
    
       
        var update = id.split('_')
        var update1 = update[1];
        var description = ds1.Tables[0].Rows[update1].DESCRIPTION
       
        var key = ds1.Tables[0].Rows[update1].KEY_STRING
       if (key == null) {
            key = "";
       }
        var description1 = document.getElementById("description_" + update1).value;
        if (description1 == "") {

            description1 = description;
        
        }
        var key1 = document.getElementById("key_" + update1).value;
        if (key1 == null) {
            key1 = "";
        }

        var explain = document.getElementById("explain_" + update1).value;
        if (explain == null) {
            explain = "";
        }
        
        
        var descclob = document.getElementById("detaild_" + update1).value;
        var res = astrodegree.update_grid(description, description1, descclob, key, key1, explain);
   

            alert("Data updated Successfully")
          
    
        return false;
    }


   
 function enablerashi(id)
 {
  if(document.getElementById('rashi_0').selectedIndex==0)
  {
  for (var i =1; i <=10; i++)
  {
  document.getElementById('rashi_'+i).disabled=true;
}}
else 
{
for (var i =1; i <=8; i++)
  {
  document.getElementById('rashi_'+i).disabled=false;
}

for (var i =10; i <=10; i++)
  {
  document.getElementById('rashi_'+i).disabled=false;
}
}}




    function findPos(obj, val) {

       
    var curleft = curtop = 0;

    if (obj.offsetParent) {
        curleft = obj.offsetLeft

        curtop = obj.offsetTop

        while (obj = obj.offsetParent) {
            if (document.getElementById('hidden123').value.indexOf("detail_") < 0) {
                curleft += obj.offsetLeft + 105;

                curtop += obj.offsetTop
            }
            else {
                curleft += obj.offsetLeft+20;
                curtop += obj.offsetTop
            }
        }

    }
    curtop = curtop += 5;
    if (val == "top")
        return curtop +"px";
    else
        return curleft + "px";
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
    else 
    {
        if (event.keyCode == 8 || event.keyCode == 46) 
        {
            return;
        }
        else
         {
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
    
    
    
      

               
               
               
function selectrahu(id){

  
  var a = document.getElementById('degree_'+8).value;
  document.getElementById('degree_'+9).value=a;
 
         
 
  }
  
                 
function selectminute(id){

  
  var a = document.getElementById('minutes_'+8).value;
  document.getElementById('minutes_'+9).value=a;
 
         
 
  }
 
     

  
  function selectvaluelast(id){

  
  var a = document.getElementById('constelation_'+8).value;
  document.getElementById('constelation_'+9).value=a;
 
         
 
  }
 
              
 var v = "";
    var degree = "";
    function vargas() {
    var j=document.getElementById('planet1').value;
    var k=document.getElementById('Texttodate').value;
    
        for (var i = 0; i < 11; i++) {
        document.getElementById('retrograde_10').value="00";
document.getElementById('degree_10').value="00";
document.getElementById('minutes_10').value="00";
document.getElementById('seconds_10').value="00";
document.getElementById('constelation_10').value="00";
            degree = document.getElementById('degree_' + i).value + "." + document.getElementById('minutes_' + i).value + "." + document.getElementById('seconds_' + i).value;
            v = v + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "~" + document.getElementById('bitrh').value +"~" + degree + "$";
            
        } v = v.slice(0, -1);

       // var resv = astrodegree.calvargas(v);
       // var dsv = resv.value;
               window.open('astrochartcombi.aspx?v='+ v + "&j=" + j + "&k=" + k );

    }