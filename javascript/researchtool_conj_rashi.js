var astrodegree = "";
var exec_data = "";
var next = 0;
var execute = "";
var exec_data1 = "";
var Modify = 0;
var delete_record = 0;
var totalh = "0";
var gridtotal = "0";
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
    buf1 = "";
    //document.getElementById('astname').innerHTML=document.getElementById('Hastname').value;
    document.getElementById('astid').innerHTML = document.getElementById('Hastmail').value;
    //document.getElementById('clientname').innerHTML =document.getElementById('Hclname').value;
    //document.getElementById('clientid').innerHTML =document.getElementById('Hclmail').value;



    grid();



    accountuser();


}



function allchk() {
    if (document.getElementById('totc_').checked == true) {
        if (find_flag == 1) {
            document.getElementById('d1c_').checked = true;
            document.getElementById('d2c_').checked = true;
            document.getElementById('d3c_').checked = true;
            document.getElementById('d4c_').checked = true;
            document.getElementById('d5c_').checked = true;
            document.getElementById('d6c_').checked = true;
            document.getElementById('d7c_').checked = true;
            document.getElementById('d8c_').checked = true;
            document.getElementById('d9c_').checked = true;
            document.getElementById('d10c_').checked = true;
            document.getElementById('d11c_').checked = true;
            document.getElementById('d12c_').checked = true;
            document.getElementById('d16c_').checked = true;
            document.getElementById('d20c_').checked = true;
            document.getElementById('d24c_').checked = true;
            document.getElementById('d27c_').checked = true;
            document.getElementById('d30c_').checked = true;
            document.getElementById('d40c_').checked = true;
            document.getElementById('d45c_').checked = true;
            document.getElementById('d60c_').checked = true;
            document.getElementById('klc_').checked = true;
        }

        if (find_flag == 2) {
            document.getElementById('d1c_').checked = true;
            document.getElementById('d2c_').checked = true;
            document.getElementById('d3c_').checked = true;
            document.getElementById('d9c_').checked = true;
            document.getElementById('d12c_').checked = true;
            document.getElementById('d30c_').checked = true;
        }
        if (find_flag == 3) {
            document.getElementById('d1c_').checked = true;
            document.getElementById('d2c_').checked = true;
            document.getElementById('d3c_').checked = true;
            document.getElementById('d7c_').checked = true;
            document.getElementById('d9c_').checked = true;
            document.getElementById('d12c_').checked = true;
            document.getElementById('d30c_').checked = true;
        }
        if (find_flag == 4) {
            document.getElementById('d1c_').checked = true;
            document.getElementById('d2c_').checked = true;
            document.getElementById('d3c_').checked = true;
            document.getElementById('d7c_').checked = true;
            document.getElementById('d9c_').checked = true;
            document.getElementById('d10c_').checked = true;
            document.getElementById('d12c_').checked = true;
            document.getElementById('d16c_').checked = true;
            document.getElementById('d30c_').checked = true;
            document.getElementById('d60c_').checked = true;
        }
        if (find_flag == 5) {
            document.getElementById('d1c_').checked = true;
            document.getElementById('d2c_').checked = true;
            document.getElementById('d3c_').checked = true;
            document.getElementById('d4c_').checked = true;
            document.getElementById('d7c_').checked = true;
            document.getElementById('d9c_').checked = true;
            document.getElementById('d10c_').checked = true;
            document.getElementById('d12c_').checked = true;
            document.getElementById('d16c_').checked = true;
            document.getElementById('d20c_').checked = true;
            document.getElementById('d24c_').checked = true;
            document.getElementById('d27c_').checked = true;
            document.getElementById('d30c_').checked = true;
            document.getElementById('d40c_').checked = true;
            document.getElementById('d45c_').checked = true;
            document.getElementById('d60c_').checked = true;
        }
    }
    else {
        if (find_flag == 1) {
            document.getElementById('d1c_').checked = false;
            document.getElementById('d2c_').checked = false;
            document.getElementById('d3c_').checked = false;
            document.getElementById('d4c_').checked = false;
            document.getElementById('d5c_').checked = false;
            document.getElementById('d6c_').checked = false;
            document.getElementById('d7c_').checked = false;
            document.getElementById('d8c_').checked = false;
            document.getElementById('d9c_').checked = false;
            document.getElementById('d10c_').checked = false;
            document.getElementById('d11c_').checked = false;
            document.getElementById('d12c_').checked = false;
            document.getElementById('d16c_').checked = false;
            document.getElementById('d20c_').checked = false;
            document.getElementById('d24c_').checked = false;
            document.getElementById('d27c_').checked = false;
            document.getElementById('d30c_').checked = false;
            document.getElementById('d40c_').checked = false;
            document.getElementById('d45c_').checked = false;
            document.getElementById('d60c_').checked = false;
            document.getElementById('klc_').checked = false;
        }

        if (find_flag == 2) {
            document.getElementById('d1c_').checked = false;
            document.getElementById('d2c_').checked = false;
            document.getElementById('d3c_').checked = false;
            document.getElementById('d9c_').checked = false;
            document.getElementById('d12c_').checked = false;
            document.getElementById('d30c_').checked = false;
        }
        if (find_flag == 3) {
            document.getElementById('d1c_').checked = false;
            document.getElementById('d2c_').checked = false;
            document.getElementById('d3c_').checked = false;
            document.getElementById('d7c_').checked = false;
            document.getElementById('d9c_').checked = false;
            document.getElementById('d12c_').checked = false;
            document.getElementById('d30c_').checked = false;
        }
        if (find_flag == 4) {
            document.getElementById('d1c_').checked = false;
            document.getElementById('d2c_').checked = false;
            document.getElementById('d3c_').checked = false;
            document.getElementById('d7c_').checked = false;
            document.getElementById('d9c_').checked = false;
            document.getElementById('d10c_').checked = false;
            document.getElementById('d12c_').checked = false;
            document.getElementById('d30c_').checked = false;
            document.getElementById('d60c_').checked = false;
        }
        if (find_flag == 5) {
            document.getElementById('d1c_').checked = false;
            document.getElementById('d2c_').checked = false;
            document.getElementById('d3c_').checked = false;
            document.getElementById('d4c_').checked = false;
            document.getElementById('d7c_').checked = false;
            document.getElementById('d9c_').checked = false;
            document.getElementById('d10c_').checked = false;
            document.getElementById('d12c_').checked = false;
            document.getElementById('d16c_').checked = false;
            document.getElementById('d20c_').checked = false;
            document.getElementById('d24c_').checked = false;
            document.getElementById('d27c_').checked = false;
            document.getElementById('d30c_').checked = false;
            document.getElementById('d40c_').checked = false;
            document.getElementById('d45c_').checked = false;
            document.getElementById('d60c_').checked = false;
        }
    }
}

function grid() {

    find_flag = 1;
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

    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D1"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d1c_'>"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D2"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d2c_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D3"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d3c_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D4"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d4c_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D5"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d5c_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D6"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d6c_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D7"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d7c_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D8"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d8c_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D9"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d9c_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D10"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d10c_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D11"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d11c_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D12"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d12c_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D16"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d16c_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D20"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d20c_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D24"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d24c_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D27"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d27c_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D30"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d30c_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D40"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d40c_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D45"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d45c_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D60"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='d60c_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "KL"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='klc_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'> " + "Total"
    buf1 += "<input type='checkbox' style='width:40px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='totc_' onclick='javascript:allchk();'>"
    buf1 += "</td>"




    buf1 += "</tr>"
    for (var i = 0; i < 1; i++) {
        buf1 += "<tr>"




        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'   class='colum-name_id'; align='left'  id='d1_" + i + "' onclick='javascript:open_div_button(id);'>"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d2_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d3_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d4_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d5_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);' class='colum-name_id'; align='left'  id='d6_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d7_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left' id='d8_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d9_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text' onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d10_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left' id='d11_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left' id='d12_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d16_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d20_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left' id='d24_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d27_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d30_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text' onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d40_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d45_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d60_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='kl_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  Enabled='false' disabled class='dropdown_large_corr';  align='left' id='total_" + i + "' >"
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










function search1() {
    var sv = "";
    var svn = 0;
    if (find_flag == 1) {

        if (document.getElementById('d1c_').checked == true) {
            sv = "HOROSCOPE_D01 is not null," + sv;
            svn = svn + 1;
        }
        if (document.getElementById('d2c_').checked == true) {
            sv = "HOROSCOPE_D02 is not null," + sv;
            svn = svn + 1;
        }

        if (document.getElementById('d3c_').checked == true) {
            sv = "HOROSCOPE_D03 is not null," + sv;
            svn = svn + 1;
        }
        if (document.getElementById('d4c_').checked == true) {
            sv = "HOROSCOPE_D04 is not null," + sv;
            svn = svn + 1;
        }
        if (document.getElementById('d5c_').checked == true) {
            sv = "HOROSCOPE_D05 is not null," + sv;
            svn = svn + 1;
        }
        if (document.getElementById('d6c_').checked == true) {
            sv = "HOROSCOPE_D06 is not null," + sv;
            svn = svn + 1;
        }
        if (document.getElementById('d7c_').checked == true) {
            sv = "HOROSCOPE_D07 is not null," + sv;
            svn = svn + 1;
        }
        if (document.getElementById('d8c_').checked == true) {
            sv = "HOROSCOPE_D08 is not null," + sv;
            svn = svn + 1;
        }
        if (document.getElementById('d9c_').checked == true) {
            sv = "HOROSCOPE_D09 is not null," + sv;
            svn = svn + 1;
        }
        if (document.getElementById('d10c_').checked == true) {
            sv = "HOROSCOPE_D10 is not null," + sv;
            svn = svn + 1;
        }
        if (document.getElementById('d11c_').checked == true) {
            sv = "HOROSCOPE_D11 is not null," + sv;
            svn = svn + 1;
        }
        if (document.getElementById('d12c_').checked == true) {
            sv = "HOROSCOPE_D12 is not null," + sv;
            svn = svn + 1;
        }
        if (document.getElementById('d16c_').checked == true) {
            sv = "HOROSCOPE_D16 is not null," + sv;
            svn = svn + 1;
        }
        if (document.getElementById('d20c_').checked == true) {
            sv = "HOROSCOPE_D20 is not null," + sv;
            svn = svn + 1;
        }
        if (document.getElementById('d24c_').checked == true) {
            sv = "HOROSCOPE_D24 is not null," + sv;
            svn = svn + 1;
        }
        if (document.getElementById('d27c_').checked == true) {
            sv = "HOROSCOPE_D27 is not null," + sv;
            svn = svn + 1;
        }
        if (document.getElementById('d30c_').checked == true) {
            sv = "HOROSCOPE_D30 is not null," + sv;
            svn = svn + 1;
        }
        if (document.getElementById('d40c_').checked == true) {
            sv = "HOROSCOPE_D40 is not null," + sv;
            svn = svn + 1;
        }
        if (document.getElementById('d45c_').checked == true) {
            sv = "HOROSCOPE_D45 is not null," + sv;
            svn = svn + 1;
        }
        if (document.getElementById('d60c_').checked == true) {
            sv = "HOROSCOPE_D60 is not null," + sv;
            svn = svn + 1;
        }
        if (document.getElementById('klc_').checked == true) {
            sv = "HOROSCOPE_DKL is not null," + sv;
            svn = svn + 1;
        }

    }
    if (find_flag == 2) {


        sv = "HOROSCOPE_D01 is not null,HOROSCOPE_D02 is not null,HOROSCOPE_D03 is not null,HOROSCOPE_D09 is not null,HOROSCOPE_D12 is not null,HOROSCOPE_D30 is not null," + sv;
        svn = 6;



    }
    if (find_flag == 3) {


        sv = "HOROSCOPE_D01 is not null,HOROSCOPE_D02 is not null,HOROSCOPE_D03 is not null,HOROSCOPE_D07 is not null,HOROSCOPE_D09 is not null,HOROSCOPE_D12 is not null,HOROSCOPE_D30 is not null," + sv;
        svn = 7;


    }

    if (find_flag == 4) {


        sv = "HOROSCOPE_D01 is not null,HOROSCOPE_D02 is not null,HOROSCOPE_D03 is not null,HOROSCOPE_D07 is not null,HOROSCOPE_D09 is not null,HOROSCOPE_D10 is not null,HOROSCOPE_D12 is not null,HOROSCOPE_D16 is not null,HOROSCOPE_D30 is not null,HOROSCOPE_D60 is not null," + sv;
        svn = 10;


    }

    if (find_flag == 5) {

        sv = "HOROSCOPE_D01 is not null,HOROSCOPE_D02 is not null,HOROSCOPE_D03 is not null,HOROSCOPE_D04 is not null,HOROSCOPE_D07 is not null,HOROSCOPE_D09 is not null,HOROSCOPE_D10 is not null,HOROSCOPE_D12 is not null,HOROSCOPE_D16 is not null,HOROSCOPE_D20 is not null,HOROSCOPE_D24 is not null,HOROSCOPE_D27 is not null,HOROSCOPE_D30 is not null,HOROSCOPE_D40 is not null,HOROSCOPE_D45 is not null,HOROSCOPE_D60 is not null," + sv;
        svn = 16;
    }
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

    var rashi = "";

    if (document.getElementById('car').checked == true) {
        rashi = rashi + 'Aries' + ',';
    }

    if (document.getElementById('cta').checked == true) {

        rashi = rashi + 'Taurus' + ','
    }

    if (document.getElementById('cge').checked == true) {

        rashi = rashi + 'Gemini' + ',';
    }


    if (document.getElementById('cca').checked == true) {

        rashi = rashi + 'Cancer' + ',';
    }

    if (document.getElementById('cle').checked == true) {

        rashi = rashi + 'Leo' + ',';
    }

    if (document.getElementById('cvi').checked == true) {

        rashi = rashi + 'Virgo' + ',';
    }
    if (document.getElementById('cli').checked == true) {

        rashi = rashi + 'Libra' + ',';
    }
     if (document.getElementById('csc').checked == true) {

         rashi = rashi + 'Scorpio' + ',';
    }
    if (document.getElementById('csg').checked == true) {

        rashi = rashi + 'Sagittarius' + ',';
    }
    if (document.getElementById('ccp').checked == true) {

        rashi = rashi + 'Capricorn' + ',';
    }
    if (document.getElementById('caq').checked == true) {

        rashi = rashi + 'Aquarius' + ',';
    }
    if (document.getElementById('cpi').checked == true) {

        rashi = rashi + 'Pisces' + ',';
    }
    var rashi1 = rashi.slice(0, -1);

    var house = "";

    if (document.getElementById('ch1').checked == true) {
        house = house + 'HOUSE1' + ',';
    }

    if (document.getElementById('ch2').checked == true) {

        house = house + 'HOUSE2' + ','
    }

    if (document.getElementById('ch3').checked == true) {

        house = house + 'HOUSE3' + ',';
    }


    if (document.getElementById('ch4').checked == true) {

        house = house + 'HOUSE4' + ',';
    }

    if (document.getElementById('ch5').checked == true) {

        house = house + 'HOUSE5' + ',';
    }

    if (document.getElementById('ch6').checked == true) {

        house = house + 'HOUSE6' + ',';
    }
    if (document.getElementById('ch7').checked == true) {

        house = house + 'HOUSE7' + ',';
    }
    if (document.getElementById('ch8').checked == true) {

        house = house + 'HOUSE8' + ',';
    }
    if (document.getElementById('ch9').checked == true) {

        house = house + 'HOUSE9' + ',';
    }
    if (document.getElementById('ch10').checked == true) {

        house = house + 'HOUSE10' + ',';
    }
    if (document.getElementById('ch11').checked == true) {

        house = house + 'HOUSE11' + ',';
    }
    if (document.getElementById('ch12').checked == true) {

        house = house + 'HOUSE12' + ',';
    }
    var house1 = house.slice(0, -1);

    if (find_flag == 1) {
        if ((rashi1 == "" && house1 == "") || document.getElementById('clgroup').value == "0" || sv == "") {
            alert('Pls select Group name or Rashi or Varga');
            return false;
        }

    }
    else {
        if ((rashi1 == "" && house1 == "") || document.getElementById('clgroup').value == "0") {
            alert('Pls select Group name or Rashi or Varga');
            return false;
        }
    }
    if (document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text == 'General') {
        var client = document.getElementById('grcl').value;
    }
    else {
        var client = "";
    }
    var ch;
    if (document.getElementById('RadioButton1').checked == true) {
        ch = document.getElementById('RadioButton1').value;
    }
    if (document.getElementById('RadioButton2').checked == true) {
        ch = document.getElementById('RadioButton2').value;
    }
    if (document.getElementById('RadioButton3').checked == true) {
        ch = document.getElementById('RadioButton3').value;
    }
    if (document.getElementById('RadioButton4').checked == true) {
        ch = document.getElementById('RadioButton4').value;
    }
    if (document.getElementById('Radio1').checked == true) {
        ch = document.getElementById('Radio1').value;
    }

    var p = planet1.replace(/,/g, ' and ');
    var r = rashi1.replace(/,/g, ' or ');
    var query = p + ' are in ' + r + ' Rashi in ' + ch + ' in ' + document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text + ' Group '
    document.getElementById('qry').innerHTML = query;
    sv = sv.slice(0, -1);
    var conj = document.getElementById('Hdnra').value;
    var res = researchtool_conj_rashi.search(planet1, rashi1, house1, astrolrger, document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text, flag, client, sv, svn, conj);
    var ds = res.value;
    var inc = 1;
    var dec = 0;
    document.getElementById('total_' + 0).value = "0";

    if (find_flag == 1) {
        if (document.getElementById('d1c_').checked == true) {
            document.getElementById('d1_' + 0).value = 0
        }
        else {
            document.getElementById('d1_' + 0).value = ""
        }

        if (document.getElementById('d2c_').checked == true) {
            document.getElementById('d2_' + 0).value = 0
        }
        else {
            document.getElementById('d2_' + 0).value = ""
        }

        if (document.getElementById('d3c_').checked == true) {
            document.getElementById('d3_' + 0).value = 0
        }
        else {
            document.getElementById('d3_' + 0).value = ""
        }

        if (document.getElementById('d4c_').checked == true) {
            document.getElementById('d4_' + 0).value = 0
        }
        else {
            document.getElementById('d4_' + 0).value = ""
        }

        if (document.getElementById('d5c_').checked == true) {
            document.getElementById('d5_' + 0).value = 0
        }
        else {
            document.getElementById('d5_' + 0).value = ""
        }

        if (document.getElementById('d6c_').checked == true) {
            document.getElementById('d6_' + 0).value = 0
        }
        else {
            document.getElementById('d6_' + 0).value = ""
        }

        if (document.getElementById('d7c_').checked == true) {
            document.getElementById('d7_' + 0).value = 0
        }
        else {
            document.getElementById('d7_' + 0).value = ""
        }

        if (document.getElementById('d8c_').checked == true) {
            document.getElementById('d8_' + 0).value = 0
        }
        else {
            document.getElementById('d8_' + 0).value = ""
        }

        if (document.getElementById('d9c_').checked == true) {
            document.getElementById('d9_' + 0).value = 0
        }
        else {
            document.getElementById('d9_' + 0).value = ""
        }

        if (document.getElementById('d10c_').checked == true) {
            document.getElementById('d10_' + 0).value = 0
        }

        else {
            document.getElementById('d10_' + 0).value = ""
        }

        if (document.getElementById('d11c_').checked == true) {
            document.getElementById('d11_' + 0).value = 0
        }
        else {
            document.getElementById('d11_' + 0).value = ""
        }

        if (document.getElementById('d12c_').checked == true) {
            document.getElementById('d12_' + 0).value = 0
        }
        else {
            document.getElementById('d12_' + 0).value = ""
        }

        if (document.getElementById('d16c_').checked == true) {
            document.getElementById('d16_' + 0).value = 0
        }
        else {
            document.getElementById('d16_' + 0).value = ""
        }

        if (document.getElementById('d20c_').checked == true) {
            document.getElementById('d20_' + 0).value = 0
        }
        else {
            document.getElementById('d20_' + 0).value = ""
        }

        if (document.getElementById('d24c_').checked == true) {
            document.getElementById('d24_' + 0).value = 0
        }
        else {
            document.getElementById('d24_' + 0).value = ""
        }

        if (document.getElementById('d27c_').checked == true) {
            document.getElementById('d27_' + 0).value = 0
        }
        else {
            document.getElementById('d27_' + 0).value = ""
        }

        if (document.getElementById('d30c_').checked == true) {
            document.getElementById('d30_' + 0).value = 0
        }
        else {
            document.getElementById('d30_' + 0).value = ""
        }

        if (document.getElementById('d40c_').checked == true) {
            document.getElementById('d40_' + 0).value = 0
        }
        else {
            document.getElementById('d40_' + 0).value = ""
        }

        if (document.getElementById('d45c_').checked == true) {
            document.getElementById('d45_' + 0).value = 0
        }
        else {
            document.getElementById('d45_' + 0).value = ""
        }

        if (document.getElementById('d60c_').checked == true) {
            document.getElementById('d60_' + 0).value = 0
        }
        else {
            document.getElementById('d60_' + 0).value = ""
        }

        if (document.getElementById('klc_').checked == true) {
            document.getElementById('kl_' + 0).value = 0
        }
        else {
            document.getElementById('kl_' + 0).value = ""
        }

    }

    if (find_flag == 2) {

        document.getElementById('d1_' + 0).value = ""

        document.getElementById('d2_' + 0).value = ""

        document.getElementById('d3_' + 0).value = ""

        document.getElementById('d9_' + 0).value = ""

        document.getElementById('d12_' + 0).value = ""
        document.getElementById('d30_' + 0).value = ""
    }

    if (find_flag == 3) {
        document.getElementById('d1_' + 0).value = ""
        document.getElementById('d2_' + 0).value = ""

        document.getElementById('d3_' + 0).value = ""

        document.getElementById('d7_' + 0).value = ""
        document.getElementById('d9_' + 0).value = ""
        document.getElementById('d12_' + 0).value = ""

        document.getElementById('d30_' + 0).value = ""
    }

    if (find_flag == 4) {
        document.getElementById('d1_' + 0).value = ""
        document.getElementById('d2_' + 0).value = ""
        document.getElementById('d3_' + 0).value = ""
        document.getElementById('d7_' + 0).value = ""
        document.getElementById('d9_' + 0).value = ""
        document.getElementById('d10_' + 0).value = ""
        document.getElementById('d12_' + 0).value = ""
        document.getElementById('d16_' + 0).value = ""
        document.getElementById('d30_' + 0).value = ""
        document.getElementById('d60_' + 0).value = ""

    }
    if (find_flag == 5) {
        document.getElementById('d1_' + 0).value = ""
        document.getElementById('d2_' + 0).value = ""
        document.getElementById('d3_' + 0).value = ""
        document.getElementById('d4_' + 0).value = ""
        document.getElementById('d7_' + 0).value = ""
        document.getElementById('d9_' + 0).value = ""
        document.getElementById('d10_' + 0).value = ""
        document.getElementById('d12_' + 0).value = ""
        document.getElementById('d16_' + 0).value = ""
        document.getElementById('d20_' + 0).value = ""
        document.getElementById('d24_' + 0).value = ""
        document.getElementById('d27_' + 0).value = ""
        document.getElementById('d30_' + 0).value = ""
        document.getElementById('d40_' + 0).value = ""
        document.getElementById('d45_' + 0).value = ""
        document.getElementById('d60_' + 0).value = ""


    }
    if (ds.Tables[0].Rows.length > 0) {

        for (i = 0; i < ds.Tables[0].Rows.length; ++i) {

            if (find_flag == 1) {

                if (document.getElementById('d1c_').checked == true) {

                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 == null) {

                        if (document.getElementById('d1_' + 0) != null) {
                            if (document.getElementById('d1_' + 0).value == "") {
                                document.getElementById('d1_' + 0).value = 0;
                            }
                            document.getElementById('d1_' + 0).value = parseInt(document.getElementById('d1_' + 0).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d1_' + 0).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('d1_' + 0) != null) {
                            if (document.getElementById('d1_' + 0).value == "") {
                                document.getElementById('d1_' + 0).value = 0;
                            }
                            document.getElementById('d1_' + 0).value = parseInt(document.getElementById('d1_' + 0).value) + parseInt(inc);

                            totalh = parseInt(totalh) + parseInt(document.getElementById('d1_' + 0).value);

                        }
                        else { }
                    }
                }
                if (document.getElementById('d2c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D02 == null) {

                        if (document.getElementById('d2_' + 0) != null) {
                            if (document.getElementById('d2_' + 0).value == "") {
                                document.getElementById('d2_' + 0).value = 0;
                            }
                            document.getElementById('d2_' + 0).value = parseInt(document.getElementById('d2_' + 0).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d2_' + 0).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('d2_' + 0) != null) {
                            if (document.getElementById('d2_' + 0).value == "") {
                                document.getElementById('d2_' + 0).value = 0;
                            }
                            document.getElementById('d2_' + 0).value = parseInt(document.getElementById('d2_' + 0).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d2_' + 0).value);
                        }
                        else { }
                    }

                }
                if (document.getElementById('d3c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D03 == null) {
                        if (document.getElementById('d3_' + 0) != null) {
                            if (document.getElementById('d3_' + 0).value == "") {
                                document.getElementById('d3_' + 0).value = 0;
                            }
                            document.getElementById('d3_' + 0).value = parseInt(document.getElementById('d3_' + 0).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d3_' + 0).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('d3_' + 0) != null) {
                            if (document.getElementById('d3_' + 0).value == "") {
                                document.getElementById('d3_' + 0).value = 0;
                            }
                            document.getElementById('d3_' + 0).value = parseInt(document.getElementById('d3_' + 0).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d3_' + 0).value);
                        }
                        else { }
                    }

                }
                if (document.getElementById('d4c_').checked == true) {


                    if (ds.Tables[0].Rows[i].HOROSCOPE_D04 == null) {
                        if (document.getElementById('d4_' + 0) != null) {
                            if (document.getElementById('d4_' + 0).value == "") {
                                document.getElementById('d4_' + 0).value = 0;
                            }
                            document.getElementById('d4_' + 0).value = parseInt(document.getElementById('d4_' + 0).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d4_' + 0).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('d4_' + 0) != null) {
                            if (document.getElementById('d4_' + 0).value == "") {
                                document.getElementById('d4_' + 0).value = 0;
                            }
                            document.getElementById('d4_' + 0).value = parseInt(document.getElementById('d4_' + 0).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d4_' + 0).value);
                        }
                        else { }
                    }
                }
                if (document.getElementById('d5c_').checked == true) {


                    if (ds.Tables[0].Rows[i].HOROSCOPE_D05 == null) {
                        if (document.getElementById('d5_' + 0) != null) {
                            if (document.getElementById('d5_' + 0).value == "") {
                                document.getElementById('d5_' + 0).value = 0;
                            }
                            document.getElementById('d5_' + 0).value = parseInt(document.getElementById('d5_' + 0).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d5_' + 0).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('d5_' + 0) != null) {
                            if (document.getElementById('d5_' + 0).value == "") {
                                document.getElementById('d5_' + 0).value = 0;
                            }
                            document.getElementById('d5_' + 0).value = parseInt(document.getElementById('d5_' + 0).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d5_' + 0).value);
                        }
                        else { }
                    }
                }

                if (document.getElementById('d6c_').checked == true) {

                    if (ds.Tables[0].Rows[i].HOROSCOPE_D06 == null) {
                        if (document.getElementById('d6_' + 0) != null) {
                            if (document.getElementById('d6_' + 0).value == "") {
                                document.getElementById('d6_' + 0).value = 0;
                            }
                            document.getElementById('d6_' + 0).value = parseInt(document.getElementById('d6_' + 0).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d6_' + 0).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('d6_' + 0) != null) {
                            if (document.getElementById('d6_' + 0).value == "") {
                                document.getElementById('d6_' + 0).value = 0;
                            }
                            document.getElementById('d6_' + 0).value = parseInt(document.getElementById('d6_' + 0).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d6_' + 0).value);
                        }
                        else { }
                    }
                }

                if (document.getElementById('d7c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D07 == null) {
                        if (document.getElementById('d7_' + 0) != null) {
                            if (document.getElementById('d7_' + 0).value == "") {
                                document.getElementById('d7_' + 0).value = 0;
                            }
                            document.getElementById('d7_' + 0).value = parseInt(document.getElementById('d7_' + 0).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d7_' + 0).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('d7_' + 0) != null) {
                            if (document.getElementById('d7_' + 0).value == "") {
                                document.getElementById('d7_' + 0).value = 0;
                            }
                            document.getElementById('d7_' + 0).value = parseInt(document.getElementById('d7_' + 0).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d7_' + 0).value);
                        }
                        else { }
                    }
                }


                if (document.getElementById('d8c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D08 == null) {
                        if (document.getElementById('d8_' + 0) != null) {
                            if (document.getElementById('d8_' + 0).value == "") {
                                document.getElementById('d8_' + 0).value = 0;
                            }
                            document.getElementById('d8_' + 0).value = parseInt(document.getElementById('d8_' + 0).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d8_' + 0).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('d8_' + 0) != null) {
                            if (document.getElementById('d8_' + 0).value == "") {
                                document.getElementById('d8_' + 0).value = 0;
                            }
                            document.getElementById('d8_' + 0).value = parseInt(document.getElementById('d8_' + 0).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d8_' + 0).value);
                        }
                        else { }
                    } 
                }


                if (document.getElementById('d9c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D09 == null) {
                        if (document.getElementById('d9_' + 0) != null) {
                            if (document.getElementById('d9_' + 0).value == "") {
                                document.getElementById('d9_' + 0).value = 0;
                            }
                            document.getElementById('d9_' + 0).value = parseInt(document.getElementById('d9_' + 0).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d9_' + 0).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('d9_' + 0) != null) {
                            if (document.getElementById('d9_' + 0).value == "") {
                                document.getElementById('d9_' + 0).value = 0;
                            }
                            document.getElementById('d9_' + 0).value = parseInt(document.getElementById('d9_' + 0).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d9_' + 0).value);
                        }
                        else { }
                    }
                }

                if (document.getElementById('d10c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D10 == null) {
                        if (document.getElementById('d10_' + 0) != null) {
                            if (document.getElementById('d10_' + 0).value == "") {
                                document.getElementById('d10_' + 0).value = 0;
                            }
                            document.getElementById('d10_' + 0).value = parseInt(document.getElementById('d10_' + 0).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d10_' + 0).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('d10_' + 0) != null) {
                            if (document.getElementById('d10_' + 0).value == "") {
                                document.getElementById('d10_' + 0).value = 0;
                            }
                            document.getElementById('d10_' + 0).value = parseInt(document.getElementById('d10_' + 0).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d10_' + 0).value);
                        }
                        else { }
                    }
                }

                if (document.getElementById('d11c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D11 == null) {
                        if (document.getElementById('d11_' + 0) != null) {
                            if (document.getElementById('d11_' + 0).value == "") {
                                document.getElementById('d11_' + 0).value = 0;
                            }
                            document.getElementById('d11_' + 0).value = parseInt(document.getElementById('d11_' + 0).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d11_' + 0).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('d11_' + 0) != null) {
                            if (document.getElementById('d11_' + 0).value == "") {
                                document.getElementById('d11_' + 0).value = 0;
                            }
                            document.getElementById('d11_' + 0).value = parseInt(document.getElementById('d11_' + 0).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d11_' + 0).value);
                        }
                        else { }
                    } 
                }


                if (document.getElementById('d12c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D12 == null) {
                        if (document.getElementById('d12_' + 0) != null) {
                            if (document.getElementById('d12_' + 0).value == "") {
                                document.getElementById('d12_' + 0).value = 0;
                            }
                            document.getElementById('d12_' + 0).value = parseInt(document.getElementById('d12_' + 0).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d12_' + 0).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('d12_' + 0) != null) {
                            if (document.getElementById('d12_' + 0).value == "") {
                                document.getElementById('d12_' + 0).value = 0;
                            }
                            document.getElementById('d12_' + 0).value = parseInt(document.getElementById('d12_' + 0).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d12_' + 0).value);
                        }
                        else { }
                    } 
                }


                if (document.getElementById('d16c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D16 == null) {
                        if (document.getElementById('d16_' + 0) != null) {
                            if (document.getElementById('d16_' + 0).value == "") {
                                document.getElementById('d16_' + 0).value = 0;
                            }
                            document.getElementById('d16_' + 0).value = parseInt(document.getElementById('d16_' + 0).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d16_' + 0).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('d16_' + 0) != null) {
                            if (document.getElementById('d16_' + 0).value == "") {
                                document.getElementById('d16_' + 0).value = 0;
                            }
                            document.getElementById('d16_' + 0).value = parseInt(document.getElementById('d16_' + 0).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d16_' + 0).value);
                        }
                        else { }
                    } 
                }


                if (document.getElementById('d20c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D20 == null) {
                        if (document.getElementById('d20_' + 0) != null) {
                            if (document.getElementById('d20_' + 0).value == "") {
                                document.getElementById('d20_' + 0).value = 0;
                            }
                            document.getElementById('d20_' + 0).value = parseInt(document.getElementById('d20_' + 0).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d20_' + 0).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('d20_' + 0) != null) {
                            if (document.getElementById('d20_' + 0).value == "") {
                                document.getElementById('d20_' + 0).value = 0;
                            }
                            document.getElementById('d20_' + 0).value = parseInt(document.getElementById('d20_' + 0).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d20_' + 0).value);
                        }
                        else { }
                    }
                }

                if (document.getElementById('d24c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D24 == null) {
                        if (document.getElementById('d24_' + 0) != null) {
                            if (document.getElementById('d24_' + 0).value == "") {
                                document.getElementById('d24_' + 0).value = 0;
                            }
                            document.getElementById('d24_' + 0).value = parseInt(document.getElementById('d24_' + 0).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d24_' + 0).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('d24_' + 0) != null) {
                            if (document.getElementById('d24_' + 0).value == "") {
                                document.getElementById('d24_' + 0).value = 0;
                            }
                            document.getElementById('d24_' + 0).value = parseInt(document.getElementById('d24_' + 0).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d24_' + 0).value);
                        }
                        else { }
                    }
                }

                if (document.getElementById('d27c_').checked == true) {

                    if (ds.Tables[0].Rows[i].HOROSCOPE_D27 == null) {
                        if (document.getElementById('d27_' + 0) != null) {
                            if (document.getElementById('d27_' + 0).value == "") {
                                document.getElementById('d27_' + 0).value = 0;
                            }
                            document.getElementById('d27_' + 0).value = parseInt(document.getElementById('d27_' + 0).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d27_' + 0).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('d27_' + 0) != null) {
                            if (document.getElementById('d27_' + 0).value == "") {
                                document.getElementById('d27_' + 0).value = 0;
                            }
                            document.getElementById('d27_' + 0).value = parseInt(document.getElementById('d27_' + 0).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d27_' + 0).value);
                        }
                        else { }
                    }
                }

                if (document.getElementById('d30c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D30 == null) {
                        if (document.getElementById('d30_' + 0) != null) {
                            if (document.getElementById('d30_' + 0).value == "") {
                                document.getElementById('d30_' + 0).value = 0;
                            }
                            document.getElementById('d30_' + 0).value = parseInt(document.getElementById('d30_' + 0).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d30_' + 0).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('d30_' + 0) != null) {
                            if (document.getElementById('d30_' + 0).value == "") {
                                document.getElementById('d30_' + 0).value = 0;
                            }
                            document.getElementById('d30_' + 0).value = parseInt(document.getElementById('d30_' + 0).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d30_' + 0).value);
                        }
                        else { }
                    }
                }

                if (document.getElementById('d40c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D40 == null) {
                        if (document.getElementById('d40_' + 0) != null) {
                            if (document.getElementById('d40_' + 0).value == "") {
                                document.getElementById('d40_' + 0).value = 0;
                            }
                            document.getElementById('d40_' + 0).value = parseInt(document.getElementById('d40_' + 0).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d40_' + 0).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('d40_' + 0) != null) {
                            if (document.getElementById('d40_' + 0).value == "") {
                                document.getElementById('d40_' + 0).value = 0;
                            }
                            document.getElementById('d40_' + 0).value = parseInt(document.getElementById('d40_' + 0).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d40_' + 0).value);
                        }
                        else { }
                    }
                }

                if (document.getElementById('d45c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D45 == null) {
                        if (document.getElementById('d45_' + 0) != null) {
                            if (document.getElementById('d45_' + 0).value == "") {
                                document.getElementById('d45_' + 0).value = 0;
                            }
                            document.getElementById('d45_' + 0).value = parseInt(document.getElementById('d45_' + 0).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d45_' + 0).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('d45_' + 0) != null) {
                            if (document.getElementById('d45_' + 0).value == "") {
                                document.getElementById('d45_' + 0).value = 0;
                            }
                            document.getElementById('d45_' + 0).value = parseInt(document.getElementById('d45_' + 0).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d45_' + 0).value);
                        }
                        else { }
                    }
                }
                if (document.getElementById('d60c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D60 == null) {
                        if (document.getElementById('d60_' + 0) != null) {
                            if (document.getElementById('d60_' + 0).value == "") {
                                document.getElementById('d60_' + 0).value = 0;
                            }
                            document.getElementById('d60_' + 0).value = parseInt(document.getElementById('d60_' + 0).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d60_' + 0).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('d60_' + 0) != null) {
                            if (document.getElementById('d60_' + 0).value == "") {
                                document.getElementById('d60_' + 0).value = 0;
                            }
                            document.getElementById('d60_' + 0).value = parseInt(document.getElementById('d60_' + 0).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('d60_' + 0).value);
                        }
                        else { }
                    }
                }

                if (document.getElementById('klc_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_DKL == null) {
                        if (document.getElementById('kl_' + 0) != null) {
                            if (document.getElementById('kl_' + 0).value == "") {
                                document.getElementById('kl_' + 0).value = 0;
                            }
                            document.getElementById('kl_' + 0).value = parseInt(document.getElementById('kl_' + 0).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('kl_' + 0).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('kl_' + 0) != null) {
                            if (document.getElementById('kl_' + 0).value == "") {
                                document.getElementById('kl_' + 0).value = 0;
                            }
                            document.getElementById('kl_' + 0).value = parseInt(document.getElementById('kl_' + 0).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('kl_' + 0).value);
                        }
                        else {
                        } 
                    }

                } 
            }

            else {

                if (ds.Tables[0].Rows[i].HOROSCOPE_D01 == null) {

                    if (document.getElementById('d1_' + 0) != null) {
                        if (document.getElementById('d1_' + 0).value == "") {
                            document.getElementById('d1_' + 0).value = 0;
                        }
                        document.getElementById('d1_' + 0).value = parseInt(document.getElementById('d1_' + 0).value) + parseInt(dec);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d1_' + 0).value);
                    }

                    else {

                    }
                }
                else {
                    if (document.getElementById('d1_' + 0) != null) {
                        if (document.getElementById('d1_' + 0).value == "") {
                            document.getElementById('d1_' + 0).value = 0;
                        }
                        document.getElementById('d1_' + 0).value = parseInt(document.getElementById('d1_' + 0).value) + parseInt(inc);

                        totalh = parseInt(totalh) + parseInt(document.getElementById('d1_' + 0).value);

                    }
                    else { }
                }


                if (ds.Tables[0].Rows[i].HOROSCOPE_D02 == null) {

                    if (document.getElementById('d2_' + 0) != null) {
                        if (document.getElementById('d2_' + 0).value == "") {
                            document.getElementById('d2_' + 0).value = 0;
                        }
                        document.getElementById('d2_' + 0).value = parseInt(document.getElementById('d2_' + 0).value) + parseInt(dec);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d2_' + 0).value);
                    }

                    else {

                    }
                }
                else {
                    if (document.getElementById('d2_' + 0) != null) {
                        if (document.getElementById('d2_' + 0).value == "") {
                            document.getElementById('d2_' + 0).value = 0;
                        }
                        document.getElementById('d2_' + 0).value = parseInt(document.getElementById('d2_' + 0).value) + parseInt(inc);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d2_' + 0).value);
                    }
                    else { }
                }


                if (ds.Tables[0].Rows[i].HOROSCOPE_D03 == null) {
                    if (document.getElementById('d3_' + 0) != null) {
                        if (document.getElementById('d3_' + 0).value == "") {
                            document.getElementById('d3_' + 0).value = 0;
                        }
                        document.getElementById('d3_' + 0).value = parseInt(document.getElementById('d3_' + 0).value) + parseInt(dec);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d3_' + 0).value);
                    }

                    else {

                    }
                }
                else {
                    if (document.getElementById('d3_' + 0) != null) {
                        if (document.getElementById('d3_' + 0).value == "") {
                            document.getElementById('d3_' + 0).value = 0;
                        }
                        document.getElementById('d3_' + 0).value = parseInt(document.getElementById('d3_' + 0).value) + parseInt(inc);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d3_' + 0).value);
                    }
                    else { }
                }




                if (ds.Tables[0].Rows[i].HOROSCOPE_D04 == null) {
                    if (document.getElementById('d4_' + 0) != null) {
                        if (document.getElementById('d4_' + 0).value == "") {
                            document.getElementById('d4_' + 0).value = 0;
                        }
                        document.getElementById('d4_' + 0).value = parseInt(document.getElementById('d4_' + 0).value) + parseInt(dec);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d4_' + 0).value);
                    }

                    else {

                    }
                }
                else {
                    if (document.getElementById('d4_' + 0) != null) {
                        if (document.getElementById('d4_' + 0).value == "") {
                            document.getElementById('d4_' + 0).value = 0;
                        }
                        document.getElementById('d4_' + 0).value = parseInt(document.getElementById('d4_' + 0).value) + parseInt(inc);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d4_' + 0).value);
                    }
                    else { }
                }



                if (ds.Tables[0].Rows[i].HOROSCOPE_D05 == null) {
                    if (document.getElementById('d5_' + 0) != null) {
                        if (document.getElementById('d5_' + 0).value == "") {
                            document.getElementById('d5_' + 0).value = 0;
                        }
                        document.getElementById('d5_' + 0).value = parseInt(document.getElementById('d5_' + 0).value) + parseInt(dec);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d5_' + 0).value);
                    }

                    else {

                    }
                }
                else {
                    if (document.getElementById('d5_' + 0) != null) {
                        if (document.getElementById('d5_' + 0).value == "") {
                            document.getElementById('d5_' + 0).value = 0;
                        }
                        document.getElementById('d5_' + 0).value = parseInt(document.getElementById('d5_' + 0).value) + parseInt(inc);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d5_' + 0).value);
                    }
                    else { }
                }


                if (ds.Tables[0].Rows[i].HOROSCOPE_D06 == null) {
                    if (document.getElementById('d6_' + 0) != null) {
                        if (document.getElementById('d6_' + 0).value == "") {
                            document.getElementById('d6_' + 0).value = 0;
                        }
                        document.getElementById('d6_' + 0).value = parseInt(document.getElementById('d6_' + 0).value) + parseInt(dec);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d6_' + 0).value);
                    }

                    else {

                    }
                }
                else {
                    if (document.getElementById('d6_' + 0) != null) {
                        if (document.getElementById('d6_' + 0).value == "") {
                            document.getElementById('d6_' + 0).value = 0;
                        }
                        document.getElementById('d6_' + 0).value = parseInt(document.getElementById('d6_' + 0).value) + parseInt(inc);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d6_' + 0).value);
                    }
                    else { }
                }

                if (ds.Tables[0].Rows[i].HOROSCOPE_D07 == null) {
                    if (document.getElementById('d7_' + 0) != null) {
                        if (document.getElementById('d7_' + 0).value == "") {
                            document.getElementById('d7_' + 0).value = 0;
                        }
                        document.getElementById('d7_' + 0).value = parseInt(document.getElementById('d7_' + 0).value) + parseInt(dec);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d7_' + 0).value);
                    }

                    else {

                    }
                }
                else {
                    if (document.getElementById('d7_' + 0) != null) {
                        if (document.getElementById('d7_' + 0).value == "") {
                            document.getElementById('d7_' + 0).value = 0;
                        }
                        document.getElementById('d7_' + 0).value = parseInt(document.getElementById('d7_' + 0).value) + parseInt(inc);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d7_' + 0).value);
                    }
                    else { }
                }

                if (ds.Tables[0].Rows[i].HOROSCOPE_D08 == null) {
                    if (document.getElementById('d8_' + 0) != null) {
                        if (document.getElementById('d8_' + 0).value == "") {
                            document.getElementById('d8_' + 0).value = 0;
                        }
                        document.getElementById('d8_' + 0).value = parseInt(document.getElementById('d8_' + 0).value) + parseInt(dec);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d8_' + 0).value);
                    }

                    else {

                    }
                }
                else {
                    if (document.getElementById('d8_' + 0) != null) {
                        if (document.getElementById('d8_' + 0).value == "") {
                            document.getElementById('d8_' + 0).value = 0;
                        }
                        document.getElementById('d8_' + 0).value = parseInt(document.getElementById('d8_' + 0).value) + parseInt(inc);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d8_' + 0).value);
                    }
                    else { }
                }

                if (ds.Tables[0].Rows[i].HOROSCOPE_D09 == null) {
                    if (document.getElementById('d9_' + 0) != null) {
                        if (document.getElementById('d9_' + 0).value == "") {
                            document.getElementById('d9_' + 0).value = 0;
                        }
                        document.getElementById('d9_' + 0).value = parseInt(document.getElementById('d9_' + 0).value) + parseInt(dec);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d9_' + 0).value);
                    }

                    else {

                    }
                }
                else {
                    if (document.getElementById('d9_' + 0) != null) {
                        if (document.getElementById('d9_' + 0).value == "") {
                            document.getElementById('d9_' + 0).value = 0;
                        }
                        document.getElementById('d9_' + 0).value = parseInt(document.getElementById('d9_' + 0).value) + parseInt(inc);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d9_' + 0).value);
                    }
                    else { }
                }

                if (ds.Tables[0].Rows[i].HOROSCOPE_D10 == null) {
                    if (document.getElementById('d10_' + 0) != null) {
                        if (document.getElementById('d10_' + 0).value == "") {
                            document.getElementById('d10_' + 0).value = 0;
                        }
                        document.getElementById('d10_' + 0).value = parseInt(document.getElementById('d10_' + 0).value) + parseInt(dec);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d10_' + 0).value);
                    }

                    else {

                    }
                }
                else {
                    if (document.getElementById('d10_' + 0) != null) {
                        if (document.getElementById('d10_' + 0).value == "") {
                            document.getElementById('d10_' + 0).value = 0;
                        }
                        document.getElementById('d10_' + 0).value = parseInt(document.getElementById('d10_' + 0).value) + parseInt(inc);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d10_' + 0).value);
                    }
                    else { }
                }

                if (ds.Tables[0].Rows[i].HOROSCOPE_D11 == null) {
                    if (document.getElementById('d11_' + 0) != null) {
                        if (document.getElementById('d11_' + 0).value == "") {
                            document.getElementById('d11_' + 0).value = 0;
                        }
                        document.getElementById('d11_' + 0).value = parseInt(document.getElementById('d11_' + 0).value) + parseInt(dec);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d11_' + 0).value);
                    }

                    else {

                    }
                }
                else {
                    if (document.getElementById('d11_' + 0) != null) {
                        if (document.getElementById('d11_' + 0).value == "") {
                            document.getElementById('d11_' + 0).value = 0;
                        }
                        document.getElementById('d11_' + 0).value = parseInt(document.getElementById('d11_' + 0).value) + parseInt(inc);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d11_' + 0).value);
                    }
                    else { }
                }
                if (ds.Tables[0].Rows[i].HOROSCOPE_D12 == null) {
                    if (document.getElementById('d12_' + 0) != null) {
                        if (document.getElementById('d12_' + 0).value == "") {
                            document.getElementById('d12_' + 0).value = 0;
                        }
                        document.getElementById('d12_' + 0).value = parseInt(document.getElementById('d12_' + 0).value) + parseInt(dec);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d12_' + 0).value);
                    }

                    else {

                    }
                }
                else {
                    if (document.getElementById('d12_' + 0) != null) {
                        if (document.getElementById('d12_' + 0).value == "") {
                            document.getElementById('d12_' + 0).value = 0;
                        }
                        document.getElementById('d12_' + 0).value = parseInt(document.getElementById('d12_' + 0).value) + parseInt(inc);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d12_' + 0).value);
                    }
                    else { }
                }
                if (ds.Tables[0].Rows[i].HOROSCOPE_D16 == null) {
                    if (document.getElementById('d16_' + 0) != null) {
                        if (document.getElementById('d16_' + 0).value == "") {
                            document.getElementById('d16_' + 0).value = 0;
                        }
                        document.getElementById('d16_' + 0).value = parseInt(document.getElementById('d16_' + 0).value) + parseInt(dec);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d16_' + 0).value);
                    }

                    else {

                    }
                }
                else {
                    if (document.getElementById('d16_' + 0) != null) {
                        if (document.getElementById('d16_' + 0).value == "") {
                            document.getElementById('d16_' + 0).value = 0;
                        }
                        document.getElementById('d16_' + 0).value = parseInt(document.getElementById('d16_' + 0).value) + parseInt(inc);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d16_' + 0).value);
                    }
                    else { }
                }
                if (ds.Tables[0].Rows[i].HOROSCOPE_D20 == null) {
                    if (document.getElementById('d20_' + 0) != null) {
                        if (document.getElementById('d20_' + 0).value == "") {
                            document.getElementById('d20_' + 0).value = 0;
                        }
                        document.getElementById('d20_' + 0).value = parseInt(document.getElementById('d20_' + 0).value) + parseInt(dec);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d20_' + 0).value);
                    }

                    else {

                    }
                }
                else {
                    if (document.getElementById('d20_' + 0) != null) {
                        if (document.getElementById('d20_' + 0).value == "") {
                            document.getElementById('d20_' + 0).value = 0;
                        }
                        document.getElementById('d20_' + 0).value = parseInt(document.getElementById('d20_' + 0).value) + parseInt(inc);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d20_' + 0).value);
                    }
                    else { }
                }

                if (ds.Tables[0].Rows[i].HOROSCOPE_D24 == null) {
                    if (document.getElementById('d24_' + 0) != null) {
                        if (document.getElementById('d24_' + 0).value == "") {
                            document.getElementById('d24_' + 0).value = 0;
                        }
                        document.getElementById('d24_' + 0).value = parseInt(document.getElementById('d24_' + 0).value) + parseInt(dec);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d24_' + 0).value);
                    }

                    else {

                    }
                }
                else {
                    if (document.getElementById('d24_' + 0) != null) {
                        if (document.getElementById('d24_' + 0).value == "") {
                            document.getElementById('d24_' + 0).value = 0;
                        }
                        document.getElementById('d24_' + 0).value = parseInt(document.getElementById('d24_' + 0).value) + parseInt(inc);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d24_' + 0).value);
                    }
                    else { }
                }


                if (ds.Tables[0].Rows[i].HOROSCOPE_D27 == null) {
                    if (document.getElementById('d27_' + 0) != null) {
                        if (document.getElementById('d27_' + 0).value == "") {
                            document.getElementById('d27_' + 0).value = 0;
                        }
                        document.getElementById('d27_' + 0).value = parseInt(document.getElementById('d27_' + 0).value) + parseInt(dec);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d27_' + 0).value);
                    }

                    else {

                    }
                }
                else {
                    if (document.getElementById('d27_' + 0) != null) {
                        if (document.getElementById('d27_' + 0).value == "") {
                            document.getElementById('d27_' + 0).value = 0;
                        }
                        document.getElementById('d27_' + 0).value = parseInt(document.getElementById('d27_' + 0).value) + parseInt(inc);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d27_' + 0).value);
                    }
                    else { }
                }

                if (ds.Tables[0].Rows[i].HOROSCOPE_D30 == null) {
                    if (document.getElementById('d30_' + 0) != null) {
                        if (document.getElementById('d30_' + 0).value == "") {
                            document.getElementById('d30_' + 0).value = 0;
                        }
                        document.getElementById('d30_' + 0).value = parseInt(document.getElementById('d30_' + 0).value) + parseInt(dec);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d30_' + 0).value);
                    }

                    else {

                    }
                }
                else {
                    if (document.getElementById('d30_' + 0) != null) {
                        if (document.getElementById('d30_' + 0).value == "") {
                            document.getElementById('d30_' + 0).value = 0;
                        }
                        document.getElementById('d30_' + 0).value = parseInt(document.getElementById('d30_' + 0).value) + parseInt(inc);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d30_' + 0).value);
                    }
                    else { }
                }

                if (ds.Tables[0].Rows[i].HOROSCOPE_D40 == null) {
                    if (document.getElementById('d40_' + 0) != null) {
                        if (document.getElementById('d40_' + 0).value == "") {
                            document.getElementById('d40_' + 0).value = 0;
                        }
                        document.getElementById('d40_' + 0).value = parseInt(document.getElementById('d40_' + 0).value) + parseInt(dec);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d40_' + 0).value);
                    }

                    else {

                    }
                }
                else {
                    if (document.getElementById('d40_' + 0) != null) {
                        if (document.getElementById('d40_' + 0).value == "") {
                            document.getElementById('d40_' + 0).value = 0;
                        }
                        document.getElementById('d40_' + 0).value = parseInt(document.getElementById('d40_' + 0).value) + parseInt(inc);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d40_' + 0).value);
                    }
                    else { }
                }

                if (ds.Tables[0].Rows[i].HOROSCOPE_D45 == null) {
                    if (document.getElementById('d45_' + 0) != null) {
                        if (document.getElementById('d45_' + 0).value == "") {
                            document.getElementById('d45_' + 0).value = 0;
                        }
                        document.getElementById('d45_' + 0).value = parseInt(document.getElementById('d45_' + 0).value) + parseInt(dec);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d45_' + 0).value);
                    }

                    else {

                    }
                }
                else {
                    if (document.getElementById('d45_' + 0) != null) {
                        if (document.getElementById('d45_' + 0).value == "") {
                            document.getElementById('d45_' + 0).value = 0;
                        }
                        document.getElementById('d45_' + 0).value = parseInt(document.getElementById('d45_' + 0).value) + parseInt(inc);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d45_' + 0).value);
                    }
                    else { }
                }

                if (ds.Tables[0].Rows[i].HOROSCOPE_D60 == null) {
                    if (document.getElementById('d60_' + 0) != null) {
                        if (document.getElementById('d60_' + 0).value == "") {
                            document.getElementById('d60_' + 0).value = 0;
                        }
                        document.getElementById('d60_' + 0).value = parseInt(document.getElementById('d60_' + 0).value) + parseInt(dec);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d60_' + 0).value);
                    }

                    else {

                    }
                }
                else {
                    if (document.getElementById('d60_' + 0) != null) {
                        if (document.getElementById('d60_' + 0).value == "") {
                            document.getElementById('d60_' + 0).value = 0;
                        }
                        document.getElementById('d60_' + 0).value = parseInt(document.getElementById('d60_' + 0).value) + parseInt(inc);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('d60_' + 0).value);
                    }
                    else { }
                }

                if (ds.Tables[0].Rows[i].HOROSCOPE_DKL == null) {
                    if (document.getElementById('kl_' + 0) != null) {
                        if (document.getElementById('kl_' + 0).value == "") {
                            document.getElementById('kl_' + 0).value = 0;
                        }
                        document.getElementById('kl_' + 0).value = parseInt(document.getElementById('kl_' + 0).value) + parseInt(dec);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('kl_' + 0).value);
                    }

                    else {

                    }
                }
                else {
                    if (document.getElementById('kl_' + 0) != null) {
                        if (document.getElementById('kl_' + 0).value == "") {
                            document.getElementById('kl_' + 0).value = 0;
                        }
                        document.getElementById('kl_' + 0).value = parseInt(document.getElementById('kl_' + 0).value) + parseInt(inc);
                        totalh = parseInt(totalh) + parseInt(document.getElementById('kl_' + 0).value);
                    }
                    else {
                    } 
                }


            }

            document.getElementById('total_' + 0).value = totalh;
            totalh = "0";

        }

    }







    //////////////////
    document.getElementById('clinetnamediv').style.display = 'block';
    var varga = '';
    var rashi2 = ''
//    var res = researchtool_conj_rashi.clientinfoall();
//    var ds = res.value;

    var pl1 = '';
    var pl2 = '';
    var varga1 = "";
    var cl_na = "";
    var cl_ma = "";
    for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
        if (find_flag == 1) {
            if (document.getElementById('d1c_').checked == true) {
                if (ds.Tables[0].Rows[i]['HOROSCOPE_D01'] != null) {
                    varga = 'D01 ' + ',' + varga;

                }
            }
            if (document.getElementById('d2c_').checked == true) {
                if (ds.Tables[0].Rows[i]['HOROSCOPE_D02'] != null) {
                    varga = 'D02 ' + ',' + varga;

                }
            }
            if (document.getElementById('d3c_').checked == true) {
                if (ds.Tables[0].Rows[i]['HOROSCOPE_D03'] != null) {
                    varga = 'D03 ' + ',' + varga;

                }
            }
            if (document.getElementById('d4c_').checked == true) {
                if (ds.Tables[0].Rows[i]['HOROSCOPE_D04'] != null) {
                    varga = 'D04 ' + ',' + varga;

                }
            }
            if (document.getElementById('d5c_').checked == true) {
                if (ds.Tables[0].Rows[i]['HOROSCOPE_D05'] != null) {
                    varga = 'D05 ' + ',' + varga;

                }
            }
            if (document.getElementById('d6c_').checked == true) {
                if (ds.Tables[0].Rows[i]['HOROSCOPE_D06'] != null) {
                    varga = 'D06 ' + ',' + varga;

                }
            }
            if (document.getElementById('d7c_').checked == true) {
                if (ds.Tables[0].Rows[i]['HOROSCOPE_D07'] != null) {
                    varga = 'D07 ' + ',' + varga;

                }
            }
            if (document.getElementById('d8c_').checked == true) {
                if (ds.Tables[0].Rows[i]['HOROSCOPE_D08'] != null) {
                    varga = 'D08 ' + ',' + varga;

                }
            }
            if (document.getElementById('d9c_').checked == true) {
                if (ds.Tables[0].Rows[i]['HOROSCOPE_D09'] != null) {
                    varga = 'D09 ' + ',' + varga;

                }
            }
            if (document.getElementById('d10c_').checked == true) {
                if (ds.Tables[0].Rows[i]['HOROSCOPE_D10'] != null) {
                    varga = 'D10 ' + ',' + varga; ;

                }
            }
            if (document.getElementById('d11c_').checked == true) {
                if (ds.Tables[0].Rows[i]['HOROSCOPE_D11'] != null) {
                    varga = 'D11 ' + ',' + varga; ;

                }
            }
            if (document.getElementById('d12c_').checked == true) {
                if (ds.Tables[0].Rows[i]['HOROSCOPE_D12'] != null) {
                    varga = 'D12 ' + ',' + varga; ;

                }
            }
            if (document.getElementById('d16c_').checked == true) {
                if (ds.Tables[0].Rows[i]['HOROSCOPE_D16'] != null) {
                    varga = 'D16 ' + ',' + varga; ;

                }
            }
            if (document.getElementById('d20c_').checked == true) {
                if (ds.Tables[0].Rows[i]['HOROSCOPE_D20'] != null) {
                    varga = 'D20 ' + ',' + varga; ;

                }
            }

            if (document.getElementById('d24c_').checked == true) {
                if (ds.Tables[0].Rows[i]['HOROSCOPE_D24'] != null) {
                    varga = 'D24 ' + ',' + varga;

                }
            }
            if (document.getElementById('d27c_').checked == true) {
                if (ds.Tables[0].Rows[i]['HOROSCOPE_D27'] != null) {
                    varga = 'D27 ' + ',' + varga;

                }
            }
            if (document.getElementById('d30c_').checked == true) {
                if (ds.Tables[0].Rows[i]['HOROSCOPE_D30'] != null) {
                    varga = 'D30 ' + ',' + varga;

                }
            }
            if (document.getElementById('d40c_').checked == true) {
                if (ds.Tables[0].Rows[i]['HOROSCOPE_D40'] != null) {
                    varga = 'D40 ' + ',' + varga;

                }
            }
            if (document.getElementById('d45c_').checked == true) {
                if (ds.Tables[0].Rows[i]['HOROSCOPE_D45'] != null) {
                    varga = 'D45 ' + ',' + varga;

                }
            }
            if (document.getElementById('d60c_').checked == true) {
                if (ds.Tables[0].Rows[i]['HOROSCOPE_D60'] != null) {
                    varga = 'D60 ' + ',' + varga;

                }
            }
            if (document.getElementById('klc_').checked == true) {
                if (ds.Tables[0].Rows[i]['HOROSCOPE_DKL'] != null) {
                    varga = 'DKL ' + ',' + varga;

                }
            }
        }

        if (find_flag == 2) {
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D01'] != null) {
                varga = 'D01 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D02'] != null) {
                varga = 'D02 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D03'] != null) {
                varga = 'D03 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D09'] != null) {
                varga = 'D09 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D12'] != null) {
                varga = 'D12 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D30'] != null) {
                varga = 'D30 ' + ',' + varga;
            }


        }

        if (find_flag == 3) {
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D01'] != null) {
                varga = 'D01 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D02'] != null) {
                varga = 'D02 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D03'] != null) {
                varga = 'D03 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D09'] != null) {
                varga = 'D09 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D12'] != null) {
                varga = 'D12 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D30'] != null) {
                varga = 'D30 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D07'] != null) {
                varga = 'D07 ' + ',' + varga;
            }


        }

        if (find_flag == 4) {
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D01'] != null) {
                varga = 'D01 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D02'] != null) {
                varga = 'D02 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D03'] != null) {
                varga = 'D03 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D09'] != null) {
                varga = 'D09 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D12'] != null) {
                varga = 'D12 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D30'] != null) {
                varga = 'D30 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D07'] != null) {
                varga = 'D07 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D10'] != null) {
                varga = 'D10 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D16'] != null) {
                varga = 'D16 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D60'] != null) {
                varga = 'D60 ' + ',' + varga;
            }





        }

        if (find_flag == 5) {
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D01'] != null) {
                varga = 'D01 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D02'] != null) {
                varga = 'D02 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D03'] != null) {
                varga = 'D03 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D04'] != null) {
                varga = 'D04 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D09'] != null) {
                varga = 'D09 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D12'] != null) {
                varga = 'D12 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D30'] != null) {
                varga = 'D30 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D20'] != null) {
                varga = 'D20 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D24'] != null) {
                varga = 'D24 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D27'] != null) {
                varga = 'D27 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D07'] != null) {
                varga = 'D07 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D10'] != null) {
                varga = 'D10 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D16'] != null) {
                varga = 'D16 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D60'] != null) {
                varga = 'D60 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D40'] != null) {
                varga = 'D40 ' + ',' + varga;
            }
            if (ds.Tables[0].Rows[i]['HOROSCOPE_D45'] != null) {
                varga = 'D45 ' + ',' + varga;
            }



        }

        if (varga != "") {
            cl_na = cl_na + ds.Tables[0].Rows[i]['CLIENT_NAME'] + '<br>';
            cl_ma = cl_ma + ds.Tables[0].Rows[i]['CLIENT_MAIL'] + '<br>';
            rashi2 = rashi2 + ds.Tables[0].Rows[i]['RASHI'] + '<br>';
            pl2 = pl2 + ds.Tables[0].Rows[i]['PLANET'] + '<br>'
            varga1 = varga1 + varga.slice(0, -1) + '<br>';
            varga = "";


        }
    }

    document.getElementById('cn').innerHTML = cl_na.slice(0, -1);
    document.getElementById('cm').innerHTML = cl_ma.slice(0, -1);

    document.getElementById('ra').innerHTML = rashi2
    document.getElementById('pla').innerHTML = pl2
    document.getElementById('va').innerHTML = varga1;
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




function data1() {

    find_flag = 2;

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
    buf1 = "";
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
    buf1 += "<table  id='Divgrid1' runat='server' align='left' Width='970px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"


    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D1"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D2"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D3"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D9"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D12"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D30"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "Total"
    buf1 += "</td>"


    buf1 += "</tr>"


    for (var i = 0; i < 1; i++) {
        buf1 += "<tr>"




        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'   class='colum-name_id'; align='left'  id='d1_" + i + "' onclick='javascript:open_div_button(id);'>"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d2_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d3_" + i + "' >"
        buf1 += "</td>"


        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d9_" + i + "' >"
        buf1 += "</td>"



        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left' id='d12_" + i + "' >"
        buf1 += "</td>"


        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d30_" + i + "' >"
        buf1 += "</td>"


        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  Enabled='false' disabled class='dropdown_large_corr';  align='left' id='total_" + i + "' >"
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





    // return false;
}





function gata2() {

    find_flag = 3;
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
    buf1 = "";
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
    buf1 += "<table  id='Divgrid1' runat='server' align='left' Width='970px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
    buf1 += "<tr>"


    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D1"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D2"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D3"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D7"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D9"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D12"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D30"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "Total"

    buf1 += "</td>"




    buf1 += "</tr>"



    for (var i = 0; i < 1; i++) {
        buf1 += "<tr>"




        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'   class='colum-name_id'; align='left'  id='d1_" + i + "' onclick='javascript:open_div_button(id);'>"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d2_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d3_" + i + "' >"
        buf1 += "</td>"


        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d7_" + i + "' >"
        buf1 += "</td>"



        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d9_" + i + "' >"
        buf1 += "</td>"



        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left' id='d12_" + i + "' >"
        buf1 += "</td>"


        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d30_" + i + "' >"
        buf1 += "</td>"


        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  Enabled='false' disabled class='dropdown_large_corr';  align='left' id='total_" + i + "' >"
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


function data3() {

    find_flag = 4;

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
    buf1 = "";
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
    buf1 += "<table  id='Divgrid1' runat='server' align='left' Width='970px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
    buf1 += "<tr>"


    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D1"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D2"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D3"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D7"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D9"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D10"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D12"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D16"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D30"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D60"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "Total"

    buf1 += "</td>"




    buf1 += "</tr>"

    for (var i = 0; i < 1; i++) {
        buf1 += "<tr>"




        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'   class='colum-name_id'; align='left'  id='d1_" + i + "' onclick='javascript:open_div_button(id);'>"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d2_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d3_" + i + "' >"
        buf1 += "</td>"



        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d7_" + i + "' >"
        buf1 += "</td>"



        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d9_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text' onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d10_" + i + "' >"
        buf1 += "</td>"


        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left' id='d12_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d16_" + i + "' >"
        buf1 += "</td>"



        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d30_" + i + "' >"
        buf1 += "</td>"



        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d60_" + i + "' >"
        buf1 += "</td>"



        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  Enabled='false' disabled class='dropdown_large_corr';  align='left' id='total_" + i + "' >"
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




function data4() {

    find_flag = 5;
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
    buf1 = "";
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
    buf1 += "<table  id='Divgrid1' runat='server' align='left' Width='970px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
    buf1 += "<tr>"


    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D1"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D2"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D3"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D4"

    buf1 += "</td>"


    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D7"

    buf1 += "</td>"

    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D9"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D10"

    buf1 += "</td>"

    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D12"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D16"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D20"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D24"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D27"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D30"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D40"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D45"

    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "D60"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "Total"

    buf1 += "</td>"




    buf1 += "</tr>"


    for (var i = 0; i < 1; i++) {
        buf1 += "<tr>"




        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'   class='colum-name_id'; align='left'  id='d1_" + i + "' onclick='javascript:open_div_button(id);'>"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d2_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d3_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d4_" + i + "' >"
        buf1 += "</td>"


        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d7_" + i + "' >"
        buf1 += "</td>"



        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d9_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text' onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d10_" + i + "' >"
        buf1 += "</td>"



        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left' id='d12_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d16_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d20_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left' id='d24_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d27_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d30_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text' onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d40_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d45_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  onclick='javascript:open_div_button(id);'  class='colum-name_id'; align='left'  id='d60_" + i + "' >"
        buf1 += "</td>"



        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  Enabled='false' disabled class='dropdown_large_corr';  align='left' id='total_" + i + "' >"
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


function open_div_button(id) {
    document.getElementById('clinetnamediv').style.display = 'block';
   
    var spl1 = id.split("_");
    var spl2 = spl1[1];
    var varga = spl1[0];

    if (varga == 'd1') {
        varga = 'D01'
    }
    if (varga == 'd2') {
        varga = 'D02'
    }
    if (varga == 'd3') {
        varga = 'D03'
    }
    if (varga == 'd4') {
        varga = 'D04'
    }
    if (varga == 'd5') {
        varga = 'D05'
    }
    if (varga == 'd6') {
        varga = 'D06'
    }
    if (varga == 'd7') {
        varga = 'D07'
    }
    if (varga == 'd8') {
        varga = 'D08'
    }
    if (varga == 'd9') {
        varga = 'D09'
    }

    var rashi = "";
    var rashi2 = "";
    var cl_na = "";
    var cl_ma = "";
    var planet = "";
    var astrologer = document.getElementById('Hastmail').value;
    var res = researchtool_conj_rashi.clientinfo(varga,astrologer);
    var ds = res.value;
    for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
        cl_na = cl_na + ds.Tables[0].Rows[i]['CLIENT_NAME'] + '<br>';
        cl_ma = cl_ma + ds.Tables[0].Rows[i]['CLIENT_MAIL'] + '<br>';
        rashi2 = rashi2 + ds.Tables[0].Rows[i]['RASHI'] + '<br>';
        varga = varga.toUpperCase() + '<br>'; ;
        planet = planet + ds.Tables[0].Rows[i]['PLANET'] + '<br>';
    }

    document.getElementById('cn').innerHTML = cl_na.slice(0, -1);
    document.getElementById('cm').innerHTML = cl_ma.slice(0, -1);
    document.getElementById('va').innerHTML = varga
    document.getElementById('pla').innerHTML = planet
    document.getElementById('ra').innerHTML = rashi2
   

}



function creossdiv() {
    document.getElementById('clinetnamediv').style.display = 'none';
    return false;
}

function accountuser() {

    var astrologer = document.getElementById('hdnuser').value;
    if (astrologer == 'astrology' || astrologer == 'ASTROLOGY' || astrologer == "") {
        // alert('you are admin');
        getopen("login.aspx");

        return false;
    }
    else {
        var grp_cat = 'Natal';
        res = researchtool_conj_rashi.searchuser(astrologer, grp_cat);

        callback_drp1(res);

        return false
    }
    return false;
}
function callback_drp1(res) {
    var ds = res.value;
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
        res = researchtool_conj_rashi.searchclient(astrologer, document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text, 'Natal');
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
