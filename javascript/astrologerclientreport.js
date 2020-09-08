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

function gridcall() {
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

    searchclientid();
    vargaschart();
    vargasotherchart();
}
function grid() {
    document.getElementById('hdsviewgrid_enduser').innerHTML = "";
    document.getElementById('Divgrid1_enduser').style.display = 'block';
    var temp_del1 = "";
    flg_req = "yes"
    var aa1 = "";
    var aa = "";
    var hs = 0;
    var hs1 = 0;
    //document.getElementById('hdsviewgrid_enduser').style.display = "block";
    //$('hdsviewgrid_enduser').style.display = "block";
    if (document.getElementById("hdsviewgrid_enduser").children.length == "0") {
        klen = "0"
    }
    else {

        klen = document.getElementById("Divgrid1_enduser").childNodes[0].childNodes[0].childNodes.length - 1;
        IntializeNumber = klen + 1;
    }
    if (document.getElementById("hdsviewgrid_enduser").innerHTML.indexOf("width:650px;display:block") <= 0) {
        aa = document.getElementById("hdsviewgrid_enduser").innerHTML.replace("</TBODY>", "")//</TABLE>","")
    }

    buf1 += "<table  id='Divgrid1_enduser' runat='server' align='left' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"

    buf1 += "<tr>"

    buf1 += "<td class='colum-td-head colum-td-head1 Planets'>" + "Planets" + "</td>"
    buf1 += "<td class='colum-td-head colum-td-head1'>" + "Rashi" + "</td>"
    buf1 += "<td class='colum-td-head colum-td-head1'>" + "House" + "</td>"
    buf1 += "<td class='colum-td-head colum-td-head1'>" + "Degree" + "</td>"
    buf1 += "<td class='colum-td-head colum-td-head1'>" + "Minutes" + "</td>"
    buf1 += "<td class='colum-td-head colum-td-head1'>" + "Seconds" + "</td>"
    buf1 += "<td class='colum-td-head colum-td-head1'>" + "Retro" + "</td>"
    buf1 += "<td class='colum-td-head colum-td-head1'>" + "Const" + "</td>"
    buf1 += "</tr>"

    len = 1;

    buf1 += "<tr>"

    buf1 += "<td class='colum-td-new'>"
    buf1 += "<input type='text' disabled class='colum-name_id' align='left'   id='planets_" + klen + "'  >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new ' >"
    buf1 += "<select disabled ' align='left' class='Planets-font rashi-1' AutoPostBack='true' id='rashi_" + klen + "' onChange='javascript:return enablerashi(this.id);' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new '>"
    buf1 += "<input type='text'  disabled 'class='rashi-1'; align='left' value='HOUSE1' id='house_" + klen + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new '>"
    buf1 += "<select disabled align='left' class='rashi-3' id='degree_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new '>"
    buf1 += "<select disabled align='left' class='rashi-3' id='minutes_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new '>"
    buf1 += "<select disabled class='rashi-3'; align='left' id='seconds_" + klen + "' onChange='javascript:return selectconstellation(this.id);'>"
    buf1 += "</td>"


    buf1 += "<td class='retro-1'>"
    buf1 += "<select disabled align='left'class='rashi-3' id='retrograde_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new '>"
    buf1 += "<select disabled align='left'class='rashi-1' id='constelation_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "</tr>"

    buf1 += "</table>"
    var hdsview = "";
    temp_del1 = aa + buf1.toString();
    temp_del1 = temp_del1.replace("<TBODY>", "")
    temp_del1 = temp_del1.replace("</TBODY>", "")

    document.getElementById('hdsviewgrid_enduser').innerHTML = temp_del1;
    return false;

}

function grid1(i) {
    flg_req = "yes"
    var aa1 = "";
    var aa = "";
    var hs = 0;
    var hs1 = 0;
    klen = (i + 1);
    buf1 = document.getElementById("hdsviewgrid_enduser").innerHTML;

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
    buf1 += "<select disabled ' align='left' class='rashi-3' id='degree_" + klen + "'onchange='javascript:return selectdegree(this.id);'>"
    buf1 += "</td>"

    buf1 += "<td  class='colum-td-new '>"
    buf1 += "<select disabled ' align='left' class='rashi-3' id='minutes_" + klen + "'onchange='javascript:return selectminute(this.id);'>"
    buf1 += "</td>"

    buf1 += "<td  class='colum-td-new '>"
    buf1 += "<select disabled ' align='left' class='rashi-3' id='seconds_" + klen + "' onChange='javascript:return selectconstellation(this.id);'>"
    buf1 += "</td>"


    buf1 += "<td class='retro-1'>"
    buf1 += "<select disabled ' align='left' class='rashi-3' id='retrograde_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new '>"
    buf1 += "<select disabled ' align='left' class='rashi-3' id='constelation_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "</tr>"

    if (browser != "Microsoft Internet Explorer") {
        buf1 += "</TBODY></table>"
    }
    else {
        buf1 += "</tbody></table>"
    }
    //alert(buf1);
    //$("hdsviewgrid_enduser").innerHTML = buf1.toString();
    document.getElementById('hdsviewgrid_enduser').innerHTML = buf1.toString();
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
    //     if (res == "planets_10") {
    //      document.getElementById(res).value = "GULIKA";
    //     }
}



function bindrashi(res) {

    var vishu = "";
    var res1 = astrologerclientreport.bindrashi(vishu);
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
        var res1 = astrologerclientreport.bindhouse(vishu);
        var ds = res1.value;
        //var drop_id=
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
    var res1 = astrologerclientreport.binddegree(vishu);
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
    var res1 = astrologerclientreport.bindminutes(vishu);
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
    var res1 = astrologerclientreport.bindseconds(vishu);
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
    var res1 = astrologerclientreport.bindretrograde(vishu);
    var ds = res1.value;

    //    document.getElementById(res).options.length = 0;
    //    document.getElementById(res).options[0] = new Option("", "0");

    var i;
    //    if(ds!=null)
    //    {
    if (ds.Tables[0].Rows.length > 0) {
        for (i = 0; i < ds.Tables[0].Rows.length; ++i) {

            if (ds.Tables[0].Rows[i].CATE == null) {
                ds.Tables[0].Rows[i].CATE = "";
            }
            if (ds.Tables[0].Rows[i].CODE == null) {
                ds.Tables[0].Rows[i].CODE = "";
            }
            document.getElementById(res).options[document.getElementById(res).options.length] = new Option(ds.Tables[0].Rows[i].CATE, ds.Tables[0].Rows[i].CODE);
            document.getElementById(res).options.length;
        }
    }


}

function bindconstelation(res) {

    var vishu = "";
    var res1 = astrologerclientreport.bindconstelation(vishu);
    var ds = res1.value;

    document.getElementById(res).options.length = 0;
    document.getElementById(res).options[0] = new Option("--Select Constelation--", "0");

    var i;
    //if(ds!=null)
    //{
    if (ds.Tables[0].Rows.length > 0) {
        for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
            document.getElementById(res).options[document.getElementById(res).options.length] = new Option(ds.Tables[0].Rows[i].NAME, ds.Tables[0].Rows[i].CODE);
            document.getElementById(res).options.length;
        }
    }
}



function searchclientid() {

    var clientname = document.getElementById('txtmail').value;
    var astroname = document.getElementById('Hastname').value;
    //astroname="HARI SHARMA";
    var astid1 = document.getElementById('Hastmail').value;
    //astid1="hshoradm@horary.com";
    var exec = astrologerclientreport.searchclientid(clientname, astroname, astid1, document.getElementById('hdngroup').value, document.getElementById('hdngroup_u').value, document.getElementById('hdnuserid').value);
    var ds = exec.value;
    if (ds.Tables[1].Rows.length > 0) {
        var ds1 = ds.Tables[1].Rows[0].HOROSCOPE_D01;
        Hiddencons.value = ds1;
        ds1 = ds1.slice(0, -1);
        var id1 = ds1.split('~')
        for (i = 0; i < id1.length; i++) {
            var id2 = id1[i].split('/')
            document.getElementById('rashi_' + i).value = id2[1];
            document.getElementById('house_' + i).value = id2[2];

            var id3 = id2[3].split('.')

            document.getElementById('degree_' + i).value = id3[0];
            document.getElementById('minutes_' + i).value = id3[1];
            document.getElementById('seconds_' + i).value = id3[2];
            document.getElementById('retrograde_' + i).value = id2[4];
            document.getElementById('constelation_' + i).value = id2[5];
        }
    }
    else {
        for (i = 0; i < 11; i++) {

            document.getElementById('rashi_' + i).selectedIndex = "0";
            document.getElementById('house_' + i).selectedIndex = "0";
            document.getElementById('degree_' + i).selectedIndex = "0";
            document.getElementById('minutes_' + i).selectedIndex = "0";
            document.getElementById('seconds_' + i).selectedIndex = "0";
        }

    }

    //vargasotherchart();

    return false;
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


    if ((parseFloat(document.getElementById('Hnewdiffm').value) > parseFloat('28.00.00') && parseFloat(document.getElementById('Hnewdiffm1').value) > parseFloat('28.00.00')) || (parseFloat(document.getElementById('Hnewdiffm').value) < parseFloat('00.00.00') || parseFloat(document.getElementById('Hnewdiffm1').value) < parseFloat('00.00.00')) || (parseFloat(document.getElementById('Hnewdiffv').value) > parseFloat('48.00.00') && parseFloat(document.getElementById('Hnewdiffv1').value) > parseFloat('48.00.00')) || (parseFloat(document.getElementById('Hnewdiffv').value) < parseFloat('00.00.00') || parseFloat(document.getElementById('Hnewdiffv1').value) < parseFloat('00.00.00'))) {
        alert('chart is not valid');
        return false;
    }

    else {
        document.getElementById('rashiid_enduser').style.display = "block";
        for (var i = 1; i < 11; i++) {
            document.getElementById('Hidden4').value = i;

            var h = document.getElementById('house_' + i).value
            var r = document.getElementById('rashi_' + 0).value



            if (document.getElementById('retrograde_' + i).value == '0') {
                document.getElementById('retrograde_' + i).innerHTML = "";

            }


            if (h == 'HOUSE1') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j1 = 'Me' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j1 = 'Ju' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j1 = 'Ve' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j1 = 'Sa' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j1 = 'Su' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j1 = 'Mo' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span sclass="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j1 = 'Ma' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j1 = 'Ra' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j1 = 'Ke' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j1 = 'Gk' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                h1 = h1 + j1 + " ";


            }
            if (h == 'HOUSE2') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j2 = 'Me' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j2 = 'Ju' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j2 = 'Ve' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j2 = 'Sa' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j2 = 'Su' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j2 = 'Mo' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j2 = 'Ma' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j2 = 'Ra' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j2 = 'Ke' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j2 = 'Gk' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }


                h2 = h2 + j2 + " ";


            }

            if (h == 'HOUSE3') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j3 = 'Me' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j3 = 'Ju' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j3 = 'Ve' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j3 = 'Sa' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j3 = 'Su' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j3 = 'Mo' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j3 = 'Ma' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j3 = 'Ra' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j3 = 'Ke' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j3 = 'Gk' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h3 = h3 + j3 + " ";


            }


            if (h == 'HOUSE4') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j4 = 'Me' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j4 = 'Ju' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j4 = 'Ve' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j4 = 'Sa' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j4 = 'Su' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j4 = 'Mo' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j4 = 'Ma' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j4 = 'Ra' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j4 = 'Ke' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j4 = 'Gk' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h4 = h4 + j4 + " ";


            }

            if (h == 'HOUSE5') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j5 = 'Me' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j5 = 'Ju' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j5 = 'Ve' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j5 = 'Sa' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j5 = 'Su' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j5 = 'Mo' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j5 = 'Ma' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j5 = 'Ra' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j5 = 'Ke' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j5 = 'Gk' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h5 = h5 + j5 + " ";

            }

            if (h == 'HOUSE6') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j6 = 'Me' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j6 = 'Ju' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j6 = 'Ve' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j6 = 'Sa' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j6 = 'Su' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j6 = 'Mo' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j6 = 'Ma' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j6 = 'Ra' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';

                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j6 = 'Ke' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j6 = 'Gk' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h6 = h6 + j6 + " ";


            }

            if (h == 'HOUSE7') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j7 = 'Me' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j7 = 'Ju' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j7 = 'Ve' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j7 = 'Sa' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j7 = 'Su' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j7 = 'Mo' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j7 = 'Ma' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j7 = 'Ra' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j7 = 'Ke' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j7 = 'Gk' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                h7 = h7 + j7 + " ";


            }

            if (h == 'HOUSE8') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j8 = 'Me' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j8 = 'Ju' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j8 = 'Ve' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j8 = 'Sa' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j8 = 'Su' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j8 = 'Mo' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j8 = 'Ma' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j8 = 'Ra' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j8 = 'Ke' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j8 = 'Gk' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                h8 = h8 + j8 + " ";


            }

            if (h == 'HOUSE9') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j9 = 'Me' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j9 = 'Ju' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j9 = 'Ve' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j9 = 'Sa' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j9 = 'Su' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j9 = 'Mo' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j9 = 'Ma' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j9 = 'Ra' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j9 = 'Ke' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }


                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j9 = 'Gk' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h9 = h9 + j9 + " ";


            }

            if (h == 'HOUSE10') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j10 = 'Me' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j10 = 'Ju' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j10 = 'Ve' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j10 = 'Sa' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j10 = 'Su' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j10 = 'Mo' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j10 = 'Ma' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j10 = 'Ra' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j10 = 'Ke' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j10 = 'Gk' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                h10 = h10 + j10 + " ";


            }

            if (h == 'HOUSE11') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j11 = 'Me' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j11 = 'Ju' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j11 = 'Ve' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j11 = 'Sa' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j11 = 'Su' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j11 = 'Mo' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j11 = 'Ma' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j11 = 'Ra' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j11 = 'Ke' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }


                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j11 = 'Gk' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h11 = h11 + j11 + " ";

            }
            if (h == 'HOUSE12') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j12 = 'Me' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j12 = 'Ju' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j12 = 'Ve' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j12 = 'Sa' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j12 = 'Su' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j12 = 'Mo' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j12 = 'Ma' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j12 = 'Ra' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j12 = 'Ke' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j12 = 'Gk' + '<span class="spanretro">' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span class="spandegree">' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
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
        document.getElementById('h1l1').innerHTML = p1 + " " + 'Asc' + " " + '<span class="spandegree">' + document.getElementById('degree_' + 0).value + '.' + document.getElementById('minutes_' + 0).value + '</span>';
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
        document.getElementById('h12r').innerHTML = '<br>' + '<span class="spanhouse">' + r12 + '</span>' + '</br>';
        document.getElementById('h1r').innerHTML = '<br>' + '<span class="spanhouse">' + r1 + '</span>' + '</br>';
        document.getElementById('h2r').innerHTML = '<br>' + '<span class="spanhouse">' + r2 + '</span>' + '</br>';
        document.getElementById('h3r').innerHTML = '<br>' + '<span class="spanhouse">' + r3 + '</span>' + '</br>';
        document.getElementById('h4r').innerHTML = '<br>' + '<span class="spanhouse">' + r4 + '</span>' + '</br>';
        document.getElementById('h5r').innerHTML = '<br>' + '<span class="spanhouse">' + r5 + '</span>' + '</br>';
        document.getElementById('h6r').innerHTML = '<br>' + '<span class="spanhouse">' + r6 + '</span>' + '</br>';
        document.getElementById('h7r').innerHTML = '<br>' + '<span class="spanhouse">' + r7 + '</span>' + '</br>';
        document.getElementById('h8r').innerHTML = '<br>' + '<span class="spanhouse">' + r8 + '</span>' + '</br>';
        document.getElementById('h9r').innerHTML = '<br>' + '<span class="spanhouse">' + r9 + '</span>' + '</br>';
        document.getElementById('h10r').innerHTML = '<br>' + '<span class="spanhouse">' + r10 + '</span>' + '</br>';
        document.getElementById('h11r').innerHTML = '<br>' + '<span class="spanhouse">' + r11 + '</span>' + '</br>';

        return false;
    }
}


function vargasotherchart() {
    var vargasfinal = "", degree = "", retro = "", birth = "0";
    var vargas = document.getElementById('Hiddencons').value;
    vargas = vargas.slice(0, -1);
    var vgs1 = vargas.split('~');
    for (i = 0; i < vgs1.length; i++) {
        var vgs1_str = vgs1[i];
        var vgs2 = vgs1_str.split('/');
        document.getElementById('planets_' + i).value = vgs2[0];
        document.getElementById('rashi_' + i).value = vgs2[1];
        document.getElementById('house_' + i).value = vgs2[2];
        document.getElementById('retrograde_' + i).value = vgs2[4];
        document.getElementById('constelation_' + i).value = vgs2[5];
        var vgs3 = vgs2[3].split('.');
        document.getElementById('degree_' + i).value = vgs3[0];
        document.getElementById('minutes_' + i).value = vgs3[1];
        document.getElementById('seconds_' + i).value = vgs3[2];
        if (document.getElementById('retrograde_' + i).value == "")
        { retro = 'B' }

        else {
            retro = document.getElementById('retrograde_' + i).value;
        }

        degree = document.getElementById('degree_' + i).value + "." + document.getElementById('minutes_' + i).value + "." + document.getElementById('seconds_' + i).value;

        vargasfinal = vargasfinal + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "~" + birth + "~" + retro + "~" + degree + "~" + document.getElementById('constelation_' + i).value + "$";

    }

    //for (var i = 0; i <= 11; i++) 
    //    {
    //   vargas = vargas.replace("~", "$");
    //    }
    //for (var i = 0; i <= 55; i++) 
    //    {
    //    vargas = vargas.replace("/", "~");
    //    }

    vargasfinal = vargasfinal.slice(0, -1);

    astrologerclientreport.vargasvalue(vargasfinal, callback_vargas);

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
        //        buf2 += "<tr>"
        //        buf2 += "<td  class='colum-td-head'>" + "PLANET" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D1_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D1_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "BIRTH_TIME" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "R" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "DEGREE" + "</td>"
        //                
        //        buf2 += "<td  class='colum-td-head'>" + "D2_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D2_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D3_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D3_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D4_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D4_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D5_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D5_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D6_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D6_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D7_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D7_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D8_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D8_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D9_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D9_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D10_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D10_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D11_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D11_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D12_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D12_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D16_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D16_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D20_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D20_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D24_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D24_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D27_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D27_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D30_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D30_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D40_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D40_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D45_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D45_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D60_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D60_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "SHASHTYAMSHA_NAME" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "D60_NATURE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "KARAKAMSHA_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "KARAKAMSHA_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "MOON_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "MOON_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "VENUS_HOUSE" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "VENUS_RASHI" + "</td>"
        //        buf2 += "<td  class='colum-td-head'>" + "CONSTELATION" + "</td>"
        //        buf2 += "</tr>"


        len = 1;


        if (exec_data.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"
                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px' class='Planets-font'>" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</font>"
                buf2 += "<input type='hidden' class='Planets-font' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['PLANET']) + ">"
                buf2 += "</td>"



                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D1_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' class='Planets-font' id=house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D1_HOUSE']) + ">"
                buf2 += "</td>"


                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D1_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D1_RASHI']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['BIRTH_TIME']) + "</font>"
                buf2 += "<input type='hidden' id=birth_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['BIRTH_TIME']) + ">"
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


                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                buf2 += "<input type='hidden' id=degree_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D2_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' id=d2house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D2_HOUSE']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D2_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=d2rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D2_RASHI']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D3_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' id=d3house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D3_HOUSE']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D3_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=d3rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D3_RASHI']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D4_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' id=d4house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D4_HOUSE']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D4_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=d4rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D4_RASHI']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D5_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' id=d5house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D5_HOUSE']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D5_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=d5rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D5_RASHI']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D6_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' id=d6house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D6_HOUSE']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D6_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=d6rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D6_RASHI']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D7_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' id=d7house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D7_HOUSE']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D7_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=d7rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D7_RASHI']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D8_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' id=d8house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D8_HOUSE']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D8_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=d8rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D8_RASHI']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D9_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' id=d9house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D9_HOUSE']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D9_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=d9rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D9_RASHI']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D10_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' id=d10house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D10_HOUSE']) + ">"
                buf2 += "</td>"
                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D10_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=d10rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D10_RASHI']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D11_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' id=d11house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D11_HOUSE']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D11_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=d11rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D11_RASHI']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D12_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' id=d12house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D12_HOUSE']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D12_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=d12rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D12_RASHI']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D16_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' id=d16house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D16_HOUSE']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D16_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=d16rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D16_RASHI']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D20_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' id=d20house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D20_HOUSE']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D20_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=d20rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D20_RASHI']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D24_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' id=d24house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D24_HOUSE']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D24_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=d24rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D24_RASHI']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D27_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' id=d27house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D27_HOUSE']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D27_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=d27rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D27_RASHI']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D30_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' id=d30house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D30_HOUSE']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D30_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=d30rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D30_RASHI']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D40_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' id=d40house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D40_HOUSE']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D40_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=d40rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D40_RASHI']) + ">"
                buf2 += "</td>"


                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D45_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' id=d45house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D45_HOUSE']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D45_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=d45rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D45_RASHI']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D60_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' id=d60house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D60_HOUSE']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D60_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=d60rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D60_RASHI']) + ">"
                buf2 += "</td>"


                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['SHASHTYAMSHA_NAME']) + "</font>"
                buf2 += "<input type='hidden' id=d60shash_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['SHASHTYAMSHA_NAME']) + ">"
                buf2 += "</td>"


                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['D60_NATURE']) + "</font>"
                buf2 += "<input type='hidden' id=d60nature_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D60_NATURE']) + ">"
                buf2 += "</td>"



                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['KARAKAMSHA_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' id=karkahouse_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['KARAKAMSHA_HOUSE']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['KARAKAMSHA_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=karkarashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['KARAKAMSHA_RASHI']) + ">"
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
        document.getElementById('hdsviewgrid').innerHTML = temp_del1;



    }
    showotherchart("D09");
    showotherchart("D10");
    showotherchart("D24");
    showotherchart("D60");
    //vargaschartd01();

}




function showotherchart(chartno) {
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
    var chartname = chartno;
    document.getElementById('chart').value = chartname;

    if (document.getElementById('chart').value == 'D09') {
        document.getElementById('fLabel1').innerHTML = chartname + ' (Pros & Cons of Married Life, Strength of Planets)';
        document.getElementById('frashiid').style.display = "block";
    }
    if (document.getElementById('chart').value == 'D10') {
        document.getElementById('sLabel1').innerHTML = chartname + ' (Power & Position)';
        document.getElementById('srashiid').style.display = "block";
    }
    if (document.getElementById('chart').value == 'D24') {
        document.getElementById('tLabel1').innerHTML = chartname + ' (Scholarly & Academic status)';
        document.getElementById('trashiid').style.display = "block";
    }
    if (document.getElementById('chart').value == 'D60') {
        document.getElementById('frLabel1').innerHTML = chartname + ' (General Indicative & Shubhatwa & else)';
        document.getElementById('frrashiid').style.display = "block";
    }

    for (var i = 1; i <= 10; i++) {
        //document.getElementById('Hidden5').value = i;
        if (document.getElementById('chart').value == 'D01') {
            var h = document.getElementById('house_' + i).value;
            var r = document.getElementById('rashi_' + 0).value;
        }

        if (document.getElementById('chart').value == 'D02') {
            var h = document.getElementById('d2house_' + i).value;
            var r = document.getElementById('d2rashi_' + 0).value;
        }

        if (document.getElementById('chart').value == 'D03') {
            var h = document.getElementById('d3house_' + i).value;
            var r = document.getElementById('d3rashi_' + 0).value;
        }

        if (document.getElementById('chart').value == 'D04') {
            var h = document.getElementById('d4house_' + i).value;
            var r = document.getElementById('d4rashi_' + 0).value;
        }

        if (document.getElementById('chart').value == 'D05') {
            var h = document.getElementById('d5house_' + i).value;
            var r = document.getElementById('d5rashi_' + 0).value;
        }

        if (document.getElementById('chart').value == 'D06') {
            var h = document.getElementById('d6house_' + i).value;
            var r = document.getElementById('d6rashi_' + 0).value;
        }

        if (document.getElementById('chart').value == 'D07') {
            var h = document.getElementById('d7house_' + i).value;
            var r = document.getElementById('d7rashi_' + 0).value;
        }

        if (document.getElementById('chart').value == 'D08') {
            var h = document.getElementById('d8house_' + i).value;
            var r = document.getElementById('d8rashi_' + 0).value;
        }

        if (document.getElementById('chart').value == 'D09') {
            var h = document.getElementById('d9house_' + i).value;
            var r = document.getElementById('d9rashi_' + 0).value;
        }

        if (document.getElementById('chart').value == 'D10') {
            var h = document.getElementById('d10house_' + i).value;
            var r = document.getElementById('d10rashi_' + 0).value;
        }
        if (document.getElementById('chart').value == 'D11') {
            var h = document.getElementById('d11house_' + i).value;
            var r = document.getElementById('d11rashi_' + 0).value;
        }

        if (document.getElementById('chart').value == 'D12') {
            var h = document.getElementById('d12house_' + i).value;
            var r = document.getElementById('d12rashi_' + 0).value;
        }

        if (document.getElementById('chart').value == 'D16') {
            var h = document.getElementById('d16house_' + i).value
            var r = document.getElementById('d16rashi_' + 0).value
        }

        if (document.getElementById('chart').value == 'D20') {
            var h = document.getElementById('d20house_' + i).value
            var r = document.getElementById('d20rashi_' + 0).value
        }

        if (document.getElementById('chart').value == 'D24') {
            var h = document.getElementById('d24house_' + i).value
            var r = document.getElementById('d24rashi_' + 0).value
        }

        if (document.getElementById('chart').value == 'D27') {
            var h = document.getElementById('d27house_' + i).value
            var r = document.getElementById('d27rashi_' + 0).value
        }

        if (document.getElementById('chart').value == 'D30') {
            var h = document.getElementById('d30house_' + i).value
            var r = document.getElementById('d30rashi_' + 0).value
        }

        if (document.getElementById('chart').value == 'D40') {
            var h = document.getElementById('d40house_' + i).value
            var r = document.getElementById('d40rashi_' + 0).value
        }

        if (document.getElementById('chart').value == 'D45') {
            var h = document.getElementById('d45house_' + i).value
            var r = document.getElementById('d45rashi_' + 0).value
        }

        if (document.getElementById('chart').value == 'D60') {
            var h = document.getElementById('d60house_' + i).value
            var r = document.getElementById('d60rashi_' + 0).value
        }

        if (document.getElementById('chart').value == 'KL') {
            var h = document.getElementById('karkahouse_' + i).value
            var r = document.getElementById('karkarashi_' + 0).value
        }

        if (document.getElementById('chart').value == 'MOON') {
            var h = document.getElementById('moonhouse_' + i).value
            var r = document.getElementById('moonrashi_' + 0).value
        }

        if (document.getElementById('chart').value == 'VENUS') {
            var h = document.getElementById('venushouse_' + i).value
            var r = document.getElementById('venusrashi_' + 0).value
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

    if (document.getElementById('chart').value == 'D09') {
        document.getElementById('fh1l1').innerHTML = p1 + " " + 'Asc';
        document.getElementById('fh2l1').innerHTML = p2;
        document.getElementById('fh3l1').innerHTML = p3;
        document.getElementById('fh4l1').innerHTML = p4;
        document.getElementById('fh5l1').innerHTML = p5;
        document.getElementById('fh6l1').innerHTML = p6;
        document.getElementById('fh7l1').innerHTML = p7;
        document.getElementById('fh8l1').innerHTML = p8;
        document.getElementById('fh9l1').innerHTML = p9;
        document.getElementById('fh10l1').innerHTML = p10;
        document.getElementById('fh11l1').innerHTML = p11;
        document.getElementById('fh12l1').innerHTML = p12;
        document.getElementById('fh12r').innerHTML = '<br>' + '<span class="spanhouse">' + r12 + '</span>' + '</br>';
        document.getElementById('fh1r').innerHTML = '<br>' + '<span class="spanhouse">' + r1 + '</span>' + '</br>';
        document.getElementById('fh2r').innerHTML = '<br>' + '<span class="spanhouse">' + r2 + '</span>' + '</br>';
        document.getElementById('fh3r').innerHTML = '<br>' + '<span class="spanhouse">' + r3 + '</span>' + '</br>';
        document.getElementById('fh4r').innerHTML = '<br>' + '<span class="spanhouse">' + r4 + '</span>' + '</br>';
        document.getElementById('fh5r').innerHTML = '<br>' + '<span class="spanhouse">' + r5 + '</span>' + '</br>';
        document.getElementById('fh6r').innerHTML = '<br>' + '<span class="spanhouse">' + r6 + '</span>' + '</br>';
        document.getElementById('fh7r').innerHTML = '<br>' + '<span class="spanhouse">' + r7 + '</span>' + '</br>';
        document.getElementById('fh8r').innerHTML = '<br>' + '<span class="spanhouse">' + r8 + '</span>' + '</br>';
        document.getElementById('fh9r').innerHTML = '<br>' + '<span class="spanhouse">' + r9 + '</span>' + '</br>';
        document.getElementById('fh10r').innerHTML = '<br>' + '<span class="spanhouse">' + r10 + '</span>' + '</br>';
        document.getElementById('fh11r').innerHTML = '<br>' + '<span class="spanhouse">' + r11 + '</span>' + '</br>';
    }
    if (document.getElementById('chart').value == 'D10') {
        document.getElementById('sh1l1').innerHTML = p1 + " " + 'Asc';
        document.getElementById('sh2l1').innerHTML = p2;
        document.getElementById('sh3l1').innerHTML = p3;
        document.getElementById('sh4l1').innerHTML = p4;
        document.getElementById('sh5l1').innerHTML = p5;
        document.getElementById('sh6l1').innerHTML = p6;
        document.getElementById('sh7l1').innerHTML = p7;
        document.getElementById('sh8l1').innerHTML = p8;
        document.getElementById('sh9l1').innerHTML = p9;
        document.getElementById('sh10l1').innerHTML = p10;
        document.getElementById('sh11l1').innerHTML = p11;
        document.getElementById('sh12l1').innerHTML = p12;
        document.getElementById('sh12r').innerHTML = '<br>' + '<span class="spanhouse">' + r12 + '</span>' + '</br>';
        document.getElementById('sh1r').innerHTML = '<br>' + '<span class="spanhouse">' + r1 + '</span>' + '</br>';
        document.getElementById('sh2r').innerHTML = '<br>' + '<span class="spanhouse">' + r2 + '</span>' + '</br>';
        document.getElementById('sh3r').innerHTML = '<br>' + '<span class="spanhouse">' + r3 + '</span>' + '</br>';
        document.getElementById('sh4r').innerHTML = '<br>' + '<span class="spanhouse">' + r4 + '</span>' + '</br>';
        document.getElementById('sh5r').innerHTML = '<br>' + '<span class="spanhouse">' + r5 + '</span>' + '</br>';
        document.getElementById('sh6r').innerHTML = '<br>' + '<span class="spanhouse">' + r6 + '</span>' + '</br>';
        document.getElementById('sh7r').innerHTML = '<br>' + '<span class="spanhouse">' + r7 + '</span>' + '</br>';
        document.getElementById('sh8r').innerHTML = '<br>' + '<span class="spanhouse">' + r8 + '</span>' + '</br>';
        document.getElementById('sh9r').innerHTML = '<br>' + '<span class="spanhouse">' + r9 + '</span>' + '</br>';
        document.getElementById('sh10r').innerHTML = '<br>' + '<span class="spanhouse">' + r10 + '</span>' + '</br>';
        document.getElementById('sh11r').innerHTML = '<br>' + '<span class="spanhouse">' + r11 + '</span>' + '</br>';
    }

    if (document.getElementById('chart').value == 'D24') {
        document.getElementById('th1l1').innerHTML = p1 + " " + 'Asc';
        document.getElementById('th2l1').innerHTML = p2;
        document.getElementById('th3l1').innerHTML = p3;
        document.getElementById('th4l1').innerHTML = p4;
        document.getElementById('th5l1').innerHTML = p5;
        document.getElementById('th6l1').innerHTML = p6;
        document.getElementById('th7l1').innerHTML = p7;
        document.getElementById('th8l1').innerHTML = p8;
        document.getElementById('th9l1').innerHTML = p9;
        document.getElementById('th10l1').innerHTML = p10;
        document.getElementById('th11l1').innerHTML = p11;
        document.getElementById('th12l1').innerHTML = p12;
        document.getElementById('th12r').innerHTML = '<br>' + '<span class="spanhouse">' + r12 + '</span>' + '</br>';
        document.getElementById('th1r').innerHTML = '<br>' + '<span class="spanhouse">' + r1 + '</span>' + '</br>';
        document.getElementById('th2r').innerHTML = '<br>' + '<span class="spanhouse">' + r2 + '</span>' + '</br>';
        document.getElementById('th3r').innerHTML = '<br>' + '<span class="spanhouse">' + r3 + '</span>' + '</br>';
        document.getElementById('th4r').innerHTML = '<br>' + '<span class="spanhouse">' + r4 + '</span>' + '</br>';
        document.getElementById('th5r').innerHTML = '<br>' + '<span class="spanhouse">' + r5 + '</span>' + '</br>';
        document.getElementById('th6r').innerHTML = '<br>' + '<span class="spanhouse">' + r6 + '</span>' + '</br>';
        document.getElementById('th7r').innerHTML = '<br>' + '<span class="spanhouse">' + r7 + '</span>' + '</br>';
        document.getElementById('th8r').innerHTML = '<br>' + '<span class="spanhouse">' + r8 + '</span>' + '</br>';
        document.getElementById('th9r').innerHTML = '<br>' + '<span class="spanhouse">' + r9 + '</span>' + '</br>';
        document.getElementById('th10r').innerHTML = '<br>' + '<span class="spanhouse">' + r10 + '</span>' + '</br>';
        document.getElementById('th11r').innerHTML = '<br>' + '<span class="spanhouse">' + r11 + '</span>' + '</br>';
    }

    if (document.getElementById('chart').value == 'D60') {
        document.getElementById('frh1l1').innerHTML = p1 + " " + 'Asc';
        document.getElementById('frh2l1').innerHTML = p2;
        document.getElementById('frh3l1').innerHTML = p3;
        document.getElementById('frh4l1').innerHTML = p4;
        document.getElementById('frh5l1').innerHTML = p5;
        document.getElementById('frh6l1').innerHTML = p6;
        document.getElementById('frh7l1').innerHTML = p7;
        document.getElementById('frh8l1').innerHTML = p8;
        document.getElementById('frh9l1').innerHTML = p9;
        document.getElementById('frh10l1').innerHTML = p10;
        document.getElementById('frh11l1').innerHTML = p11;
        document.getElementById('frh12l1').innerHTML = p12;
        document.getElementById('frh12r').innerHTML = '<br>' + '<span class="spanhouse">' + r12 + '</span>' + '</br>';
        document.getElementById('frh1r').innerHTML = '<br>' + '<span class="spanhouse">' + r1 + '</span>' + '</br>';
        document.getElementById('frh2r').innerHTML = '<br>' + '<span class="spanhouse">' + r2 + '</span>' + '</br>';
        document.getElementById('frh3r').innerHTML = '<br>' + '<span class="spanhouse">' + r3 + '</span>' + '</br>';
        document.getElementById('frh4r').innerHTML = '<br>' + '<span class="spanhouse">' + r4 + '</span>' + '</br>';
        document.getElementById('frh5r').innerHTML = '<br>' + '<span class="spanhouse">' + r5 + '</span>' + '</br>';
        document.getElementById('frh6r').innerHTML = '<br>' + '<span class="spanhouse">' + r6 + '</span>' + '</br>';
        document.getElementById('frh7r').innerHTML = '<br>' + '<span class="spanhouse">' + r7 + '</span>' + '</br>';
        document.getElementById('frh8r').innerHTML = '<br>' + '<span class="spanhouse">' + r8 + '</span>' + '</br>';
        document.getElementById('frh9r').innerHTML = '<br>' + '<span class="spanhouse">' + r9 + '</span>' + '</br>';
        document.getElementById('frh10r').innerHTML = '<br>' + '<span class="spanhouse">' + r10 + '</span>' + '</br>';
        document.getElementById('frh11r').innerHTML = '<br>' + '<span class="spanhouse">' + r11 + '</span>' + '</br>';
    }


    return false;
}
