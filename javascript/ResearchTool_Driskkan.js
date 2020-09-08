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



    //grid();



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







function chapl() {
    if (document.getElementById('chap').checked == true) {
        document.getElementById('csu').checked = true
        document.getElementById('cmo').checked = true
        document.getElementById('cma').checked = true
        document.getElementById('cme').checked = true
        document.getElementById('cju').checked = true
        document.getElementById('cve').checked = true
        document.getElementById('csa').checked = true
        document.getElementById('cra').checked = true
        document.getElementById('cke').checked = true
    }
    else {
        document.getElementById('csu').checked = false
        document.getElementById('cmo').checked = false
        document.getElementById('cma').checked = false
        document.getElementById('cme').checked = false
        document.getElementById('cju').checked = false
        document.getElementById('cve').checked = false
        document.getElementById('csa').checked = false
        document.getElementById('cra').checked = false
        document.getElementById('cke').checked = false
    }
}

function chadr() {
    if (document.getElementById('chad').checked == true) {

        document.getElementById('ay').checked = true
        document.getElementById('sa').checked = true
        document.getElementById('ni').checked = true
        document.getElementById('pa').checked = true
        document.getElementById('ch').checked = true
        document.getElementById('vars').checked = true
        document.getElementById('paa').checked = true
        document.getElementById('ag').checked = true
        document.getElementById('ja').checked = true
        document.getElementById('ma').checked = true
        document.getElementById('pu').checked = true
        document.getElementById('kr').checked = true
        document.getElementById('sau').checked = true
        document.getElementById('fe').checked = true
        document.getElementById('kri').checked = true
        document.getElementById('ar').checked = true
        document.getElementById('vi').checked = true

    }

    else {
        document.getElementById('ay').checked = false
        document.getElementById('sa').checked = false
        document.getElementById('ni').checked = false
        document.getElementById('pa').checked = false
        document.getElementById('ch').checked = false
        document.getElementById('vars').checked = false
        document.getElementById('paa').checked = false
        document.getElementById('ag').checked = false
        document.getElementById('ja').checked = false
        document.getElementById('ma').checked = false
        document.getElementById('pu').checked = false
        document.getElementById('kr').checked = false
        document.getElementById('sau').checked = false
        document.getElementById('fe').checked = false
        document.getElementById('kri').checked = false
        document.getElementById('ar').checked = false
        document.getElementById('vi').checked = false

    }
}


function chahr() {
    if (document.getElementById('chah').checked == true) {

        document.getElementById('ch1').checked = true
        document.getElementById('ch2').checked = true
        document.getElementById('ch3').checked = true
        document.getElementById('ch4').checked = true
        document.getElementById('ch5').checked = true
        document.getElementById('ch6').checked = true
        document.getElementById('ch7').checked = true
        document.getElementById('ch8').checked = true
        document.getElementById('ch9').checked = true
        document.getElementById('ch10').checked = true
        document.getElementById('ch11').checked = true
        document.getElementById('ch12').checked = true
        
    }

    else {

        document.getElementById('ch1').checked = false
        document.getElementById('ch2').checked = false
        document.getElementById('ch3').checked = false
        document.getElementById('ch4').checked = false
        document.getElementById('ch5').checked = false
        document.getElementById('ch6').checked = false
        document.getElementById('ch7').checked = false
        document.getElementById('ch8').checked = false
        document.getElementById('ch9').checked = false
        document.getElementById('ch10').checked = false
        document.getElementById('ch11').checked = false
        document.getElementById('ch12').checked = false
        
    }
}

function search1() {
    var sv = "";
    var svn = 0;
    var house = "";
    var house1 = "";
    var planet = "";
    var planet1 = "";
  

        if (document.getElementById('ay').checked == true) {
            sv = 'Ayaduha Dreshkon' + ',' + sv;
            svn = svn + 1;
        }
        if (document.getElementById('sa').checked == true) {
            sv = 'Sarpa Dreshkon' + ',' + sv;
            svn = svn + 1;
        }

        if (document.getElementById('ni').checked == true) {
            sv = 'Nigada Dreshkon' + ',' + sv;
            svn = svn + 1;
        }
        if (document.getElementById('pa').checked == true) {
            sv = 'Pakshee Dreshkon' + ',' + sv;
            svn = svn + 1;
        }
        if (document.getElementById('ch').checked == true) {
            sv = 'Chatushpaad Dreshkon' + ',' + sv;
            svn = svn + 1;
        }
        if (document.getElementById('vars').checked == true) {
            sv = 'Varaaha Dreshkon' + ',' + sv;
            svn = svn + 1;
        }
        if (document.getElementById('paa').checked == true) {
            sv = 'Paasa Dreshkon' + ',' + sv;
            svn = svn + 1;
        }
        if (document.getElementById('ag').checked == true) {
            sv = 'Agni Dreshkon' + ',' + sv;
            svn = svn + 1;
        }
        if (document.getElementById('ja').checked == true) {
            sv = 'ala Dreshkon' + ',' + sv;
            svn = svn + 1;
        }
        if (document.getElementById('ma').checked == true) {
            sv = 'Manushya Dreshkon' + ',' + sv;
            svn = svn + 1;
        }
        if (document.getElementById('pu').checked == true) {
            sv = 'Purusha Dreshkon' + ',' + sv;
            svn = svn + 1;
        }
        if (document.getElementById('kr').checked == true) {
            sv = 'Kroora Dreshkon' + ',' + sv;
            svn = svn + 1;
        }
        if (document.getElementById('sau').checked == true) {
            sv = 'Saumya Dreshkon' + ',' + sv;
            svn = svn + 1;
        }
        if (document.getElementById('fe').checked == true) {
            sv = 'Female Dreshkon' + ',' + sv;
            svn = svn + 1;
        }
        if (document.getElementById('kri').checked == true) {
            sv = 'Krishi Dreshkon' + ',' + sv;
            svn = svn + 1;
        }
        if (document.getElementById('ar').checked == true) {
            sv = 'Aranya Dreshkon' + ',' + sv;
            svn = svn + 1;
        }
        if (document.getElementById('vi').checked == true) {
            sv = 'Visha Dreshkon' + ',' + sv;
            svn = svn + 1;
        }
        sv = sv.slice(0, -1);

    
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

    if (house == "") {
        house = 'HOUSE1' + ',' + 'HOUSE2' + ',' + 'HOUSE3' + ',' + 'HOUSE4' + ',' + 'HOUSE5' + ',' + 'HOUSE6' + ',' + 'HOUSE7' + ',' + 'HOUSE8' + ',' + 'HOUSE9' + ',' + 'HOUSE10' + ',' + 'HOUSE11' + ',' + 'HOUSE12' + ',';
    }
    var house1 = house.slice(0, -1);
    
    var astrolrger = document.getElementById('Hastmail').value;
    var planet = "";

    if (document.getElementById('csu').checked == true) {
        planet = planet + 'SUN' + ',';
    }

    if (document.getElementById('cmo').checked == true) {

        planet = planet + 'MOON' + ','
    }

    if (document.getElementById('cma').checked == true) {

        planet = planet + 'MARS' + ',';
    }


    if (document.getElementById('cme').checked == true) {

        planet = planet + 'MERCURY' + ',';
    }

    if (document.getElementById('cju').checked == true) {

        planet = planet + 'JUPITER' + ',';
    }

    if (document.getElementById('cve').checked == true) {

        planet = planet + 'VENUS' + ',';
    }
    if (document.getElementById('csa').checked == true) {

        planet = planet + 'SATURN' + ',';
    }
    if (document.getElementById('cra').checked == true) {

        planet = planet + 'RAHU' + ',';
    }
    if (document.getElementById('cke').checked == true) {

        planet = planet + 'KETU' + ',';
    }

    var planet1 = planet.slice(0, -1);

    if (find_flag == 1) {
        if (planet1 == "" || document.getElementById('clgroup').value == "0" || sv == "") {
            alert('Pls select Group name or Planet or Varga');
            return false;
        }

    }
    else {
        if (planet1 == "" || document.getElementById('clgroup').value == "0") {
            alert('Pls select Group name or Planet or Varga');
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
    var s = sv.replace(/,/g, ' and ');
    var query = 'Query:- ' + p + ' are in ' + s + ' Driskkana in ' + house1 + ' in ' + document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text + ' Group '
    document.getElementById('qry').innerHTML = query;
   
    var res = ResearchTool_Driskkan.search(planet1, astrolrger, document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text, client, sv, svn, house1);
    var ds = res.value;
    var inc = 1;
    var dec = 0;
    



    document.getElementById('clinetnamediv').style.display = 'block';
    var varga = '';
    var rashi2 = ''
    // var res = researchtool_conjunction.clientinfoall();
    // var ds = res.value;
    var fl = "";
    var pl1 = '';
    var pl2 = '';
    var varga1 = "";
    var cl_na = "";
    var cl_ma = "";
    var dr = "";
    var dr1 = "";
    for (i = 0; i < ds.Tables[0].Rows.length; i++) 
    {
      
          
                if (ds.Tables[0].Rows[i]['HOROSCOPE_D01'] != null) 
                {
                   
                    dr = dr+ds.Tables[0].Rows[i]['HOROSCOPE_D01'] + '<br>';
                    cl_na = cl_na + ds.Tables[0].Rows[i]['CLIENT_NAME'] + '<br>'
                    cl_ma = cl_ma + ds.Tables[0].Rows[i]['CLIENT_MAIL'] + '<br>'
                    pl2 = pl2 + ds.Tables[0].Rows[i]['PLANET'] + '<br>'
                    varga = varga + ds.Tables[0].Rows[i]['RASHI'] + '<br>'
                }
           
           

        
       
    }

    document.getElementById('cn').innerHTML = cl_na;
    document.getElementById('cm').innerHTML = cl_ma;
    document.getElementById('pl').innerHTML = pl2
    document.getElementById('va').innerHTML = varga;
    document.getElementById('dri').innerHTML = dr;
    ////////////////////

    ///////
    var pn = '';
    var rn = '';
    var tn = '';
    var per = '';
    var noc = '';

    for (i = 0; i < ds.Tables[1].Rows.length; ++i) {
        pn = pn + ds.Tables[1].Rows[i]['PLANET'] + '<br>';
        tn = tn + ds.Tables[1].Rows[i]['TOTAL'] + '<br>';
        per = per + ds.Tables[1].Rows[i]['PERCENTAGE'] + '<br>'
        noc = noc + ds.Tables[1].Rows[i]['NO_OF_CHART'] + '<br>'
    }
    document.getElementById('pn').innerHTML = pn;
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
    var planet = "";

    if (document.getElementById('csu').checked == true) {
        planet = planet + 'SUN' + ',';
    }

    if (document.getElementById('cmo').checked == true) {

        planet = planet + 'MOON' + ','
    }

    if (document.getElementById('cma').checked == true) {

        planet = planet + 'MARS' + ',';
    }


    if (document.getElementById('cme').checked == true) {

        planet = planet + 'MERCURY' + ',';
    }

    if (document.getElementById('cju').checked == true) {

        planet = planet + 'JUPITER' + ',';
    }

    if (document.getElementById('cve').checked == true) {

        planet = planet + 'VENUS' + ',';
    }
    if (document.getElementById('csa').checked == true) {

        planet = planet + 'SATURN' + ',';
    }
    if (document.getElementById('cra').checked == true) {

        planet = planet + 'RAHU' + ',';
    }
    if (document.getElementById('cke').checked == true) {

        planet = planet + 'KETU' + ',';
    }

    var planet1 = planet.slice(0, -1);

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
    var astrologer = document.getElementById('Hastmail').value;

    var res = ResearchTool_Driskkan.clientinfo(varga, astrologer);
    var ds = res.value;
    document.getElementById('pl').innerHTML = planet1;
    document.getElementById('va').innerHTML = varga.toUpperCase();

    var cl_na = "";
    var cl_ma = "";
    for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
        cl_na = cl_na + ds.Tables[0].Rows[i]['CLIENT_NAME'] + '<br>';
        cl_ma = cl_ma + ds.Tables[0].Rows[i]['CLIENT_MAIL'] + '<br>';

    }

    document.getElementById('cn').innerHTML = cl_na.slice(0, -1);
    document.getElementById('cm').innerHTML = cl_ma.slice(0, -1);



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
        res = ResearchTool_Driskkan.searchuser(astrologer, grp_cat);

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
        res = ResearchTool_Driskkan.searchclient(astrologer, document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text, 'Natal');
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
