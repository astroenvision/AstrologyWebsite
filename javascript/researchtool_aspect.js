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


    for (var kk = 0; kk <= 7; kk++) {
        binddropdown('planets_' + kk);
        //        bindrashi("rashi_" + kk);

    }
    accountuser();


}



function allchk() {
    if (document.getElementById('totc_').checked == true) {
        if (find_flag == 1) {
            document.getElementById('suc_').checked = true;
            document.getElementById('moc_').checked = true;
            document.getElementById('mac_').checked = true;
            document.getElementById('mec_').checked = true;
            document.getElementById('juc_').checked = true;
            document.getElementById('vec_').checked = true;
            document.getElementById('sac_').checked = true;
            document.getElementById('rac_').checked = true;
            document.getElementById('kec_').checked = true;
                    }


    }
    else {
        if (find_flag == 1)
         {
            document.getElementById('suc_').checked = false;
            document.getElementById('moc_').checked = false;
            document.getElementById('mac_').checked = false;
            document.getElementById('mec_').checked = false;
            document.getElementById('juc_').checked = false;
            document.getElementById('vec_').checked = false;
            document.getElementById('sac_').checked = false;
            document.getElementById('rac_').checked = false;
            document.getElementById('kec_').checked = false;
           
        }

    }
}
function allchk() 
{
 for(var i=0;i<=6;i++)
    {
    document.getElementById('pc_' + i).checked = true;
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
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "Planets" + "</td>"

    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + ""
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' onclick='javascript:allchk();'   id='ac_'>"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "SUN"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Ashwini'  id='suc_'>"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "MOON"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Bharani' id='moc_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "MARS"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Krittika' id='mac_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "MERCURY"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Rohini' id='mec_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "JUPITER"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Mrigshira' id='juc_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "VENUS"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Ardra' id='vec_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "SATURN"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Punarvasu' id='sac_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "RAHU"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Pushya' id='rac_'>"
    buf1 += "</td>"
    buf1 += "<td class='colum-td-head-chart' style='width:0%;'>" + "KETU"
    buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true' value='Ashlesha' id='kec_'>"
    buf1 += "</td>"

    buf1 += "</tr>"

    len = 1;

    for (var i = 0; i <= 6; i++) {
        buf1 += "<tr>"


        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text' disabled style='width:60px;'class='dropdown_large_corr';  align='left' id='planets_" + i + "'>"
        buf1 += "</td>"


        buf1 += "<td class='colum-td-head-chartpc' style='width:0%;'>"
        buf1 += "<input type='checkbox'  style='width:20px;' BackColor='white'; class='dropdown_large_corr' ; align='center' AutoPostBack='true'  id='pc_" + i + "' >"
        buf1 += "</td>"



        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'   style='width:30px;'class='colum-name_id'; align='left' onclick='javascript:open_div_button(id);' id='suc_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'   style='width:20px;'class='colum-name_id'; align='left' onclick='javascript:open_div_button(id);' id='moc_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'   style='width:20px;'class='colum-name_id'; align='left' onclick='javascript:open_div_button(id);' id='mac_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  style='width:20px;'class='colum-name_id'; align='left' onclick='javascript:open_div_button(id);' id='mec_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'   style='width:20px;'class='colum-name_id'; align='left' onclick='javascript:open_div_button(id);' id='juc_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'   style='width:20px;'class='colum-name_id'; align='left' onclick='javascript:open_div_button(id);' id='vec_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'  style='width:20px;'class='colum-name_id'; align='left' onclick='javascript:open_div_button(id);' id='sac_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'   style='width:20px;'class='colum-name_id'; align='left' onclick='javascript:open_div_button(id);' id='rac_" + i + "' >"
        buf1 += "</td>"

        buf1 += "<td class='colum-td-chart' style='width:0%;'>"
        buf1 += "<input type='text'   style='width:20px;'class='colum-name_id'; align='left' onclick='javascript:open_div_button(id);' id='kec_" + i + "' >"
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

//    document.getElementById('planets_7').style.display = 'none'

//    document.getElementById('suc_7').style.display = 'none';
//    document.getElementById('moc_7').style.display = 'none';
//    document.getElementById('mac_7').style.display = 'none';
//    document.getElementById('mec_7').style.display = 'none';
//    document.getElementById('juc_7').style.display = 'none';
//    document.getElementById('vec_7').style.display = 'none';
//    document.getElementById('sac_7').style.display = 'none';
//    document.getElementById('rac_7').style.display = 'none';
//    document.getElementById('kec_7').style.display = 'none';
  //document.getElementById('pc_7').style.display = 'none';
    


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







function search1() {

    var astrolrger = document.getElementById('Hastmail').value;
    var planets = "";

    if (document.getElementById('suc_').checked == true) {
        planets = 'SUN' + ',' + planets;
    }

    if (document.getElementById('moc_').checked == true) {
        planets = 'MOON' + ',' + planets;
    }

    if (document.getElementById('mac_').checked == true) {
        planets = 'MARS' + ',' + planets;
    }

    if (document.getElementById('mec_').checked == true) {
        planets = 'MERCURY' + ',' + planets;
    }

    if (document.getElementById('juc_').checked == true) {
        planets = 'JUPITER' + ',' + planets;
    }

    if (document.getElementById('vec_').checked == true) {
        planets = 'VENUS' + ',' + planets;
    }

    if (document.getElementById('sac_').checked == true) {
        planets = 'SATURN' + ',' + planets;
    }

    if (document.getElementById('rac_').checked == true) {
        planets = 'RAHU' + ',' + planets;
    }

    if (document.getElementById('kec_').checked == true) {
        planets = 'KETU' + ',' + planets;
    }




    var planets1 = planets.slice(0, -1);
    var varga = document.getElementById('varga').value;
    var varga1 = 'HOROSCOPE_' + document.getElementById('varga').value;    
    if (find_flag == 1) {
        if (planets1 == "" || document.getElementById('clgroup').value == "0" || varga=="") {
            alert('Pls select Group name or planets');
            return false;
        }
    }

    var res = researchtool_aspect.search(varga1, astrolrger, document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text);
    var ds = res.value;

    if (ds.Tables[0].Rows.length > 0) 
    {

        for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
            if (document.getElementById('pc_'+i).checked == true) {
                if (document.getElementById('suc_').checked == true) {
                    document.getElementById('suc_' + i).value = ds.Tables[0].Rows[i]['SUN'].split('~')[0];
                }
            }
            if (document.getElementById('pc_' + i).checked == true) {
                if (document.getElementById('moc_').checked == true) {
                    document.getElementById('moc_' + i).value = ds.Tables[0].Rows[i]['MOON'].split('~')[0];
                }
            }
            if (document.getElementById('pc_' + i).checked == true) {
                if (document.getElementById('mac_').checked == true) {
                    document.getElementById('mac_' + i).value = ds.Tables[0].Rows[i]['MARS'].split('~')[0];
                }
            }
            if (document.getElementById('pc_' + i).checked == true) {
                if (document.getElementById('mec_').checked == true) {
                    document.getElementById('mec_' + i).value = ds.Tables[0].Rows[i]['MERCURY'].split('~')[0];
                }
            }
            if (document.getElementById('pc_' + i).checked == true) {
                if (document.getElementById('juc_').checked == true) {
                    document.getElementById('juc_' + i).value = ds.Tables[0].Rows[i]['JUPITER'].split('~')[0];
                }
            }
            if (document.getElementById('pc_' + i).checked == true) {
                if (document.getElementById('vec_').checked == true) {
                    document.getElementById('vec_' + i).value = ds.Tables[0].Rows[i]['VENUS'].split('~')[0];
                }
            }
            if (document.getElementById('pc_' + i).checked == true) {
                if (document.getElementById('sac_').checked == true) {
                    document.getElementById('sac_' + i).value = ds.Tables[0].Rows[i]['SATURN'].split('~')[0];
                }
            }
            if (document.getElementById('pc_' + i).checked == true) {
                if (document.getElementById('rac_').checked == true) {
                    document.getElementById('rac_' + i).value = ds.Tables[0].Rows[i]['RAHU'].split('~')[0];
                }
            }
            if (document.getElementById('pc_' + i).checked == true) {
                if (document.getElementById('kec_').checked == true) {
                    document.getElementById('kec_' + i).value = ds.Tables[0].Rows[i]['KETU'].split('~')[0];
                } 
            }

        }
    }
    return false;
}




function open_div_button(id) {
    document.getElementById('clinetnamediv').style.display = 'block';
    var spl1 = id.split('_');
    var spl2 = spl1[1];
    var planet = spl1[0];
    var seq = parseInt(spl2) + parseInt(1);
    if (planet == 'suc')
    { planet = 'SUN' }
    if (planet == 'moc')
    { planet = 'MOON' }
    if (planet == 'mac')
    { planet = 'MARS' }
    if (planet == 'mec')
    { planet = 'MERCURY' }
    if (planet == 'juc')
    { planet = 'JUPITER' }
    if (planet == 'vec')
    { planet = 'VENUS' }
    if (planet == 'sac')
    { planet = 'SATURN' }
    if (planet == 'rac')
    { planet = 'RAHU' }
    if (planet == 'kec')
    { planet = 'KETU' }
    var astrologer = document.getElementById('Hastmail').value;
    var res = researchtool_aspect.clientinfo(planet, seq,astrologer);
    var ds = res.value;
    var p = "";
    if (seq == 1) {
        p = 'SUN';
    }
    if (seq == 2) {
        p = 'MOON';
    }
    if (seq == 3) {
        p = 'MARS';
    }
    if (seq == 4) {
        p = 'MERCURY';
    }
    if (seq == 5) {
        p = 'JUPITER';
    }
    if (seq == 6) {
        p = 'VENUS';
    }
    if (seq == 7) {
        p = 'SATURN';
    }
    var query = p + ' Aspects ' + planet + ' in ' + document.getElementById('varga').value + ' in ' + document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text + ' Group';
     document.getElementById('qry').innerHTML = query;

     var alld = ds.Tables[0].Rows[0]['DETAIL'].split(',');
     var clnameas = "";
     var clname = "";
     var aspects = "";
     for (i = 1; i < alld.length; ++i) {
          clnameas = alld[i].split('$');
          clname = clname+clnameas[0]  +'<br>';
          aspects =aspects+clnameas[1]+'<br>';
     }




     document.getElementById('cn').innerHTML = clname;
     document.getElementById('ca').innerHTML = aspects
   


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
        res = researchtool_aspect.searchuser(astrologer, grp_cat);

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