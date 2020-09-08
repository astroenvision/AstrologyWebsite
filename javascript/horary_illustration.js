var buf2 = "";
var dsgrid = "";
var flag = '0';
var group1 = "";
var flag1 = true;
var horary_illustration = "";

var popUpWin = 0;
function getopen(pagename) {

    if (popUpWin) {
        if (!popUpWin.closed) popUpWin.close();
    }

    popUpWin = window.open('' + pagename + '', 'form', 'resizable=yes, status=no, toolbar=no, scrollbars=yes, location=no, menubar=no,addressbar=no')

}

function accountuser() {
    
    var astrologer = document.getElementById('Hidden9').value;
    document.getElementById('astid').innerHTML = astrologer;
    if (astrologer == 'astrology' || astrologer == 'ASTROLOGY' || astrologer == "") {
        // alert('you are admin');
        getopen("login.aspx");
        return false;
    }
    else {
        var grp_cat = 'Horary';
        res = horary_illustration.searchuser(astrologer, grp_cat);
       // callback_fillgrid(res);
        // callback_fillgrid2(res);

        callback_drp1(res);
        cldetail();
        bindadmingrp();
        return false
    }
    return false;
}

function newgroup() {
    var currentdate = new Date();
    var datetime = "Query Date : " + currentdate.getDate() + "/" + currentdate.getMonth()+1
    + "/" + currentdate.getFullYear() + " @ "
    + currentdate.getHours() + ":"
    + currentdate.getMinutes() + ":" + currentdate.getSeconds();

    

    document.getElementById('catn').value = "";
    FCKeditorAPI.GetInstance('explanation_text').SetHTML(datetime);
    if (document.getElementById('hdnid').value == 'adgrp') {
        var grop = document.getElementById('adgrp').options[document.getElementById('adgrp').selectedIndex].text
    
    }

    else {
        var grop = document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text
    

    }
    gropu = document.getElementById('hdngroupunder').value;

    var astrologer = document.getElementById('Hidden9').value;

    if (document.getElementById('cat').selectedIndex == '1') {
        if ((astrologer == 'hshoradm@horary.com' && document.getElementById('hdnid').value == 'adgrp') || (astrologer != 'hshoradm@horary.com' && document.getElementById('hdnid').value != 'adgrp')) {
            document.getElementById('catn').style.display = 'block'
            document.getElementById('se').style.display = 'block'
            document.getElementById('up').style.display = 'none'
            document.getElementById('de').style.display = 'none'
            // FCKeditorAPI.GetInstance('explanation_text').SetHTML("");
            return false;
        }
    }
    else {
        document.getElementById('catn').style.display = 'none'
      
        if (document.getElementById('hdnid').value == 'adgrp') {
            var astrologer = 'hshoradm@horary.com'
        }

        else {
            var astrologer = document.getElementById('Hidden9').value;

        }
        res = horary_illustration.scs(astrologer, document.getElementById('cat').value, document.getElementById('DropDownList2').innerHTML, grop, gropu);
        dsgrid = res.value;
        var astrologer = document.getElementById('Hidden9').value;
        if (dsgrid.Tables[0].Rows.length > 0 && dsgrid.Tables[0].Rows[0]['CASE_STUDY'] != null) {
            if (astrologer != 'hshoradm@horary.com') {

                if (document.getElementById('hdnid').value != 'adgrp') {
                    document.getElementById('up').style.display = 'block'
                    document.getElementById('de').style.display = 'block'
                    document.getElementById('se').style.display = 'none'
                    FCKeditorAPI.GetInstance('explanation_text').SetHTML(dsgrid.Tables[0].Rows[0].CASE_STUDY);
                }
                else {
                    document.getElementById('up').style.display = 'none'
                    document.getElementById('de').style.display = 'none'
                    document.getElementById('se').style.display = 'none'
                    FCKeditorAPI.GetInstance('explanation_text').SetHTML(dsgrid.Tables[0].Rows[0].CASE_STUDY);

                }
            }
            else {
                if (document.getElementById('hdnid').value == 'adgrp') {
                    document.getElementById('up').style.display = 'block'
                    document.getElementById('de').style.display = 'block'
                    document.getElementById('se').style.display = 'none'
                    FCKeditorAPI.GetInstance('explanation_text').SetHTML(dsgrid.Tables[0].Rows[0].CASE_STUDY);
                }
                else {
                    document.getElementById('up').style.display = 'none'
                    document.getElementById('de').style.display = 'none'
                    document.getElementById('se').style.display = 'none'
                    FCKeditorAPI.GetInstance('explanation_text').SetHTML(dsgrid.Tables[0].Rows[0].CASE_STUDY);

                }

            }


        }

        else {
            if (astrologer != 'hshoradm@horary.com') {

                if (document.getElementById('hdnid').value != 'adgrp') {
                    document.getElementById('de').style.display = 'none'
                    document.getElementById('up').style.display = 'none'
                    document.getElementById('se').style.display = 'block'
                }
                else {
                    document.getElementById('up').style.display = 'none'
                    document.getElementById('de').style.display = 'none'
                    document.getElementById('se').style.display = 'none'
                }
            }

            else {
                if (document.getElementById('hdnid').value == 'adgrp') {
                    document.getElementById('de').style.display = 'none'
                    document.getElementById('up').style.display = 'none'
                    document.getElementById('se').style.display = 'block'
                }
                else {
                    document.getElementById('up').style.display = 'none'
                    document.getElementById('de').style.display = 'none'
                    document.getElementById('se').style.display = 'none'
                }
            }
            //FCKeditorAPI.GetInstance('explanation_text').SetHTML("");
        }
        return false;
    }

}
function vargas(id) {
    //FCKeditorAPI.GetInstance('explanation_text').SetHTML("");
    var cmail = id.split('_')
    var cmail1 = cmail[1];
    var clmail = document.getElementById("climale1_" + cmail1).value;
    document.getElementById('td1').style.display = "block";
    document.getElementById('td2').style.display = "block";
    document.getElementById('td3').style.display = "block";

    document.getElementById('DropDownList1').style.display = "block";
    document.getElementById('DropDownList2').style.display = "block";
    document.getElementById('cat').style.display = "block";
    document.getElementById('cat').selectedIndex= 0;
    document.getElementById('DropDownList1').innerHTML = document.getElementById("cname1_" + cmail1).value;
    document.getElementById('DropDownList2').innerHTML = document.getElementById("climale1_" + cmail1).value;
    var astmail = document.getElementById('Hidden9').value
    var grop = document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text
    var gropu = document.getElementById('hdngroupunder').value;
    //document.getElementById('chart').value = 'D09';
    if (document.getElementById('hdnid').value == 'adgrp')
    {
        astmail = 'hshoradm@horary.com'
        var grop = document.getElementById('adgrp').options[document.getElementById('adgrp').selectedIndex].text
    }
    bindcat(clmail);
    var resd1 = horary_illustration.fetchd1(clmail, astmail, grop, gropu);
    if (resd1.value == null)
    {
        alert('Please Save Chart First');
        return false;
    }
    else
    {
        ds = resd1.value;
        var d1 = ds.Tables[0].Rows[0]['HOROSCOPE_D01'];
        d1 = d1.slice(0, -1);
        var va1 = d1.split('~');
        var vargas = "";
        for (var i = 0; i < va1.length; i++)
        {

            var va2 = va1[i].split('/');
            for(var j=0;j<va2.length;j++)
            {
                if (j == 3) {
                    vargas = vargas + '0~' + va2[j+1] + '~' ;
                }
                else if (j == 4) {
                    vargas = vargas  + va2[j-1] + '~';
                }
                else if (j == 5) {
                    vargas = vargas + va2[j] + '$';
                }
                else {
                    vargas = vargas + va2[j] + '~';
                }
            }
    }
        
    }

    vargas = vargas.slice(0,-1);
    //var vargas = document.getElementById('Hiddencons').value;

    
    horary_illustration.vargasvalue(vargas, callback_vargas);
   
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
        //document.getElementById('Divgrid1').style.display = 'block';
        document.getElementById('Divgrid1').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

       // document.getElementById('hdsviewgrid').style.display = "block";

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
        buf2 += "<td  class='colum-td-head'>" + "BIRTH_TIME" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "R" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "DEGREE" + "</td>"

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
        buf2 += "<td  class='colum-td-head'>" + "CONSTELATION" + "</td>"
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
                if (exec_data.Tables[0].Rows[i]['RETRO'] == 'R') {

                    buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['RETRO']) + "</font>"
                    buf2 += "<input type='hidden' id=retrograde_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['RETRO']) + ">"
                    buf2 += "</td>"
                }
                else {
                    buf2 += "<font width='90px'></font>"
                    buf2 += "<input type='hidden' id=retrograde_" + i + " >"
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
        //alert(temp_del1)
        document.getElementById('hdsviewgrid').innerHTML = temp_del1;



    }
   // vargaschart();
    vargaschartd01();

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
    var deg = "";
    var deg1 = "";
        document.getElementById('rashiidd01').style.display = "block";
    document.getElementById('lb').style.display = "block";
    document.getElementById('ch').style.display = "block";

    var chartname = document.getElementById('chart').value
    if (chartname == "" || chartname==0)
    {
        document.getElementById('chart').value='D01'
        chartname = 'D01'
    }
    document.getElementById('Label1d01').innerHTML = chartname + ' Chart';
    document.getElementById('Label1d01').style.display = "block";
    for (var i = 1; i < 11; i++) {
        document.getElementById('Hidden5d01').value = i;

        if (document.getElementById('chart').value == 'D01') {
            var h = document.getElementById('house_' + i).value
            var r = document.getElementById('rashi_' + 0).value

        }

        if (document.getElementById('chart').value == 'D02') {
            var h = document.getElementById('d2house_' + i).value
            var r = document.getElementById('d2rashi_' + 0).value
        }

        if (document.getElementById('chart').value == 'D03') {
            var h = document.getElementById('d3house_' + i).value
            var r = document.getElementById('d3rashi_' + 0).value
        }

        if (document.getElementById('chart').value == 'D04') {
            var h = document.getElementById('d4house_' + i).value
            var r = document.getElementById('d4rashi_' + 0).value
        }

        if (document.getElementById('chart').value == 'D05') {
            var h = document.getElementById('d5house_' + i).value
            var r = document.getElementById('d5rashi_' + 0).value
        }

        if (document.getElementById('chart').value == 'D06') {
            var h = document.getElementById('d6house_' + i).value
            var r = document.getElementById('d6rashi_' + 0).value
        }

        if (document.getElementById('chart').value == 'D07') {
            var h = document.getElementById('d7house_' + i).value
            var r = document.getElementById('d7rashi_' + 0).value
        }

        if (document.getElementById('chart').value == 'D08') {
            var h = document.getElementById('d8house_' + i).value
            var r = document.getElementById('d8rashi_' + 0).value
        }

        if (document.getElementById('chart').value == 'D09') {
            var h = document.getElementById('d9house_' + i).value
            var r = document.getElementById('d9rashi_' + 0).value
        }

        if (document.getElementById('chart').value == 'D10') {
            var h = document.getElementById('d10house_' + i).value
            var r = document.getElementById('d10rashi_' + 0).value
        }
        if (document.getElementById('chart').value == 'D11') {
            var h = document.getElementById('d11house_' + i).value
            var r = document.getElementById('d11rashi_' + 0).value
        }

        if (document.getElementById('chart').value == 'D12') {
            var h = document.getElementById('d12house_' + i).value
            var r = document.getElementById('d12rashi_' + 0).value
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



        if (document.getElementById('retrograde_' + i).value == "0" || document.getElementById('retrograde_' + i).value == "B") {
            document.getElementById('retrograde_' + i).innerHTML= "";
        }



        if (h == 'HOUSE1') {

            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j1 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j1 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j1 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j1 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j1 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j1 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j1 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j1 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j1 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j1 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }
            h1 = h1 + j1 + " ";


        }
        if (h == 'HOUSE2') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j2 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j2 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j2 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j2 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j2 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j2 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j2 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j2 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j2 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j2 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }



            h2 = h2 + j2 + " ";


        }

        if (h == 'HOUSE3') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j3 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j3 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j3 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j3 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j3 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j3 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j3 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j3 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j3 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j3 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }
            h3 = h3 + j3 + " ";


        }


        if (h == 'HOUSE4') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j4 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j4 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j4 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j4 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j4 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j4 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j4 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j4 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j4 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j4 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }
            h4 = h4 + j4 + " ";


        }

        if (h == 'HOUSE5') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j5 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j5 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j5 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j5 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j5 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j5 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j5 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j5 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j5 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j5 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }
            h5 = h5 + j5 + " ";

        }

        if (h == 'HOUSE6') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j6 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j6 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j6 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j6 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j6 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j6 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j6 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j6 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';

            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j6 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j6 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }
            h6 = h6 + j6 + " ";


        }

        if (h == 'HOUSE7') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j7 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j7 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j7 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j7 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j7 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j7 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j7 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j7 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j7 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j7 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            h7 = h7 + j7 + " ";


        }

        if (h == 'HOUSE8') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j8 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j8 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j8 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j8 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j8 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j8 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j8 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j8 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j8 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j8 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            h8 = h8 + j8 + " ";


        }

        if (h == 'HOUSE9') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j9 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j9 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j9 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j9 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j9 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j9 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j9 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j9 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j9 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j9 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            h9 = h9 + j9 + " ";


        }

        if (h == 'HOUSE10') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j10 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j10 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j10 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j10 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j10 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j10 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j10 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j10 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j10 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j10 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            h10 = h10 + j10 + " ";


        }

        if (h == 'HOUSE11') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j11 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j11 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j11 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j11 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j11 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j11 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j11 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j11 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j11 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j11 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }


            h11 = h11 + j11 + " ";

        }
        if (h == 'HOUSE12') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j12 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j12 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j12 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j12 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j12 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j12 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j12 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j12 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j12 = 'Ke' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j12 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
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
    document.getElementById('h1l1d01').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + 0).value + '</span>';
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
function callback_drp1(res) {
    //FCKeditorAPI.GetInstance('explanation_text').SetHTML("");
    var ds = res.value;
    document.getElementById('hdnasn').value = ds.Tables[0].Rows[0].NAME;
    document.getElementById('hdnas').value = ds.Tables[0].Rows[0].MAINMAIL;
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
function sebyd_data() {
    document.getElementById('sebyt').style.display = 'inline-block';
}
function cldetail(id) {
    document.getElementById('hdnid').value = id;
    document.getElementById('whitediv2').style.display = 'block';
  
    document.getElementById('sebyd').selectedIndex = 0
    document.getElementById('sebyt').style.display = 'none';
    var gropu = document.getElementById('hdngroupunder').value;
    var astrologer = document.getElementById('Hidden9').value;
    if ( id=='adgrp')
    {
        var grop = document.getElementById('adgrp').options[document.getElementById('adgrp').selectedIndex].text
        var astrologer = 'hshoradm@horary.com';
        document.getElementById('clgroup').selectedIndex = 0;
        document.getElementById('catn').style.display = 'none'
        document.getElementById('se').style.display = 'none'
        document.getElementById('up').style.display = 'none'
        document.getElementById('de').style.display = 'none'
    }
    else
    {
        var grop = document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text
        var astrologer = document.getElementById('Hidden9').value;
        document.getElementById('adgrp').selectedIndex = 0;
        document.getElementById('catn').style.display = 'none'
        document.getElementById('se').style.display = 'none'
        document.getElementById('up').style.display = 'none'
        document.getElementById('de').style.display = 'none'
    }

    res = horary_illustration.searchclient(astrologer, grop,gropu);
    callback_fillgrid2(res);
    //bindcat();
    return false;
}
function bindcat(clmail)
{
    if (document.getElementById('hdnid').value == 'adgrp') {
        var grop = document.getElementById('adgrp').options[document.getElementById('adgrp').selectedIndex].text
        var astrologer = 'hshoradm@horary.com';
    }

    else
    {
        var grop = document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text
        var astrologer = document.getElementById('Hidden9').value;

    }
    gropu = document.getElementById('hdngroupunder').value;
    res = horary_illustration.bindcat(astrologer, grop, gropu, clmail);
    var ds = res.value;
  
    var edtn = $("cat");
    edtn.options.length = 1;
    edtn.options[0] = new Option("Select Query", "0");
    edtn.options[1] = new Option("New Query", "1");
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        for (var i = 0; i < ds.Tables[0].Rows.length; i++) {
            edtn.options[edtn.options.length] = new Option(ds.Tables[0].Rows[i].CAT_ID, ds.Tables[0].Rows[i].CAT_ID)
            edtn.options.length;
        }
    }
   

}

function sebyb_data() {

   
    //if (document.getElementById('clgroup').selectedIndex == 0) {
    //    alert('Please Select Group Name');
    //    return;
    //}
    if (astrologer == 'hshoradm@horary.com' && id == 'adgrp') {
        var grop = document.getElementById('adgrp').options[document.getElementById('adgrp').selectedIndex].text
        var astrologer = 'hshoradm@horary.com';
    }
    else {
        var grop = document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text
        var astrologer = document.getElementById('Hidden9').value;

    }
    gropu = document.getElementById('hdngroupunder').value;
  
    var txtvalue = document.getElementById('sebyt').value;
    var searchoption = document.getElementById('sebyd').value;

    res = horary_illustration.searchclient_by(astrologer, grop, searchoption, txtvalue,gropu);
    callback_fillgrid2(res);
    return false;
}

function callback_fillgrid(res) {



    var exec_data = res.value;

    dsgrid = exec_data;
    document.getElementById('hdsviewgrid').innerHTML = "";
    document.getElementById('Divgrid1').style.display = "none";
    if (exec_data.Tables[0].Rows.length >= 0) {
        document.getElementById('hdsviewgrid').innerHTML = "";
       // document.getElementById('Divgrid1').style.display = 'block';
      //  $('Divgrid1').display = 'block;'


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

        if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:460px;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='460px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td class='colum-td-head'>" + "NAME" + "</td>"
        buf2 += "<td class='colum-td-head'>" + "MAINMAIL" + "</td>"
        buf2 += "<td class='colum-td-head'>" + "ALTMAIL" + "</td>"
        buf2 += "<td class='colum-td-head'>" + "MOBILE_NO" + "</td>"
        buf2 += "<td class='colum-td-head'>" + "LANDLINE_NO" + "</td>"
        buf2 += "<td class='colum-td-head'>" + "ADDRESS1" + "</td>"
        buf2 += "<td class='colum-td-head'>" + "ADDRESS2" + "</td>"
        buf2 += "<td class='colum-td-head'>" + "LANDMARK" + "</td>"
        buf2 += "<td class='colum-td-head'>" + "COUNTRY" + "</td>"
        buf2 += "<td class='colum-td-head'>" + "ZIPCODE" + "</td>"
        buf2 += "<td class='colum-td-head'>" + "PASSWORD" + "</td>"

        buf2 += "</tr>"
        len = 1;


        if (dsgrid.Tables[0].Rows.length > 0) {

            for (i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {


                buf2 += "<tr>"

                document.getElementById('hdnasn').value = dsgrid.Tables[0].Rows[i]['NAME']
                buf2 += "<td class='colum-td'>"
                buf2 += "<input type='text' style='width:200px;' class='dropdown_large_corr'; align='left' value='" + dsgrid.Tables[0].Rows[i]['NAME'] + "'  id='name_" + i + "'  >"
                buf2 += "</td>"


                document.getElementById('hdnas').value = dsgrid.Tables[0].Rows[i]['MAINMAIL'];

                buf2 += "<td class='colum-td'>"
                buf2 += "<input type='text'Enabled='false'disabled style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['MAINMAIL'] + "'  id='pmail1_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td class='colum-td'>"
                buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['ALTMAIL'] + "'  id='altmail_" + i + "'  >"
                buf2 += "</td>"



                buf2 += "<td class='colum-td'>"
                buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['MOBILE_NO'] + "'  id='mobno_" + i + "'  >"
                buf2 += "</td>"



                buf2 += "<td class='colum-td'>"
                buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['LANDLINE_NO'] + "'  id='landno_" + i + "'  >"
                buf2 += "</td>"



                buf2 += "<td class='colum-td'>"
                buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['ADDRESS1'] + "'  id='add1_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td class='colum-td'>"
                buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['ADDRESS2'] + "'  id='add2_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td class='colum-td'>"
                buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['LANDMARK'] + "'  id='landmark_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td class='colum-td'>"
                buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['COUNTRY'] + "'  id='country_" + i + "'  >"
                buf2 += "</td>"

              
                    buf2 += "<td  class='colum-td'>"
                    buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['ZIPCODE'] + "'  id='zip_" + i + "'  >"
                    buf2 += "</td>"
               

                    buf2 += "<td class='colum-td'>"
                    buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['PASSWORD'] + "'  id='pwd_" + i + "'  >"
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
}








function callback_fillgrid2(res) {


    var exec_data = res.value;

    dsgrid = exec_data;
    document.getElementById('hdsviewgrid2').innerHTML = "";
    document.getElementById('Divgrid2').style.display = "none";
    if (exec_data.Tables[0].Rows.length >= 0) {
        document.getElementById('hdsviewgrid2').innerHTML = "";
        document.getElementById('Divgrid2').style.display = 'block';
        document.getElementById('Divgrid2').style.height = 'auto';
        $('Divgrid2').display = 'block;'


        document.getElementById('Divgrid2').style.BackColor = "Ivory";
        var temp_del1 = "";

        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('hdsviewgrid2').style.display = "block";

        if (document.getElementById("hdsviewgrid2").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("Divgrid2").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("hdsviewgrid2").innerHTML.indexOf("width:460px;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid2").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        //        buf2 += "<table>"
        //        buf2 += "<tr>"
        if (dsgrid.Tables[0].Rows.length > 0) {

            for (i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
                var group = dsgrid.Tables[0].Rows[i]['CAT_ID'];
                //            if(group!=group1){
                //            flag='0';
                //            buf2 += "</tr>"
                //            
                //             }else{flag='1'}
                //            
                //        
                //        
                if (flag == '0') {


                    buf2 += "<table>"
                    buf2 += "<tr>"
                    buf2 += "<td  class='colum-td-head'>" + "Group Name:" + group + "</td>"
                    buf2 += "</tr>"
                    flag = '1';
                    buf2 += "<tr>"
                    buf2 += "<table >"
                    buf2 += "<tr>"
                    //buf2 += "<td style='display:none;' class='colum-td-head'>" + "ASTRO_DTLS" + "</td>"
                    //buf2 += "<td style='display:none;' class='colum-td-head astro-mail'>" + "ASTRO_MAIL" + "</td>"
                    buf2 += "<td id='cliname' class='colum-td-head colum-name' onclick=\"click_trcode(this.id);\">" + "CLIENT_NAME" + "</td>"
                    buf2 += "<td  class='colum-td-head astro-mail'>" + "CLIENT_MAIL" + "</td>"
                //    buf2 += "<td id='prof' class='colum-td-head colum-name' onclick=\"click_trcode(this.id);\">" + "PROFESSION" + "</td>"
                    buf2 += "<td id='prof' class='colum-td-head colum-name'>" + "MOBILE_NO" + "</td>"
                    buf2 += "<td  class='colum-td-head colum-age'>" + "DOB" + "</td>"
                    buf2 += "<td  class='colum-td-head colum-age'>" + "TOB" + "</td>"
                    buf2 += "<td  class='colum-td-head colum-age'>" + "COUNTRY" + "</td>"
                    buf2 += "<td  class='colum-td-head colum-age'>" + "STATE" + "</td>"
                    buf2 += "<td  class='colum-td-head colum-age' style='display:none;'>" + "DISTRICT" + "</td>"
                    buf2 += "<td  class='colum-td-head colum-age'>" + "CITY" + "</td>"
                    buf2 += "<td  class='colum-td-head colum-age'>" + "GENDER" + "</td>"
                    buf2 += "<td  class='colum-td-head colum-age'>" + "NOTES" + "</td>"
  




                    buf2 += "</tr>"


                    len = 1;
                }

                buf2 += "<tr>"


                //buf2 += "<td class='colum-td'>"
                //buf2 += "<input type='text' style='display:none;' class='dropdown_large_corr' Enabled='false' disabled  value='" + dsgrid.Tables[0].Rows[i]['ASTRO_DTLS'] + "'  id='astdel1_" + i + "'  >"
                //buf2 += "</td>"



                //buf2 += "<td  class='colum-td'>"
                //buf2 += "<input type='text' style='display:none;' class='dropdown_large_corr' style='width:200px; 'Enabled='false' disabled value='" + dsgrid.Tables[0].Rows[i]['P_MAIL'] + "'  id='pmail1_" + i + "'  >"
                //buf2 += "</td>"




                buf2 += "<td   class='colum-td'>"
                buf2 += "<input type='text' class='dropdown_large_corr'  Enabled='false'disabled  value='" + dsgrid.Tables[0].Rows[i]['CLIENT_NAME'] + "'  id='cname1_" + i + "'  >"
                buf2 += "</td>"



                buf2 += "<td   class='colum-td'>"
                buf2 += "<input type='text'  style='width:200px';  class='colum-name_id' value='" + dsgrid.Tables[0].Rows[i]['CLIENT_MAIL'] + "'  id='climale1_" + i + "' onClick='javascript:return onclientmail(id);' >"
                buf2 += "</td>"


                //if (dsgrid.Tables[0].Rows[i]['PROFESSION'] == 0 || dsgrid.Tables[0].Rows[i]['PROFESSION'] == null) {
                //    buf2 += "<td   class='colum-td'>"
                //    buf2 += "<input type='text' class='dropdown_large_corr'  Enabled='false'disabled class='colum-name'  id='prof1_" + i + "'  >"
                //    buf2 += "</td>"
                //}
                //else {

                //    buf2 += "<td   class='colum-td'>"
                //    buf2 += "<input type='text' class='dropdown_large_corr'  Enabled='false'disabled  class='colum-name' value='" + dsgrid.Tables[0].Rows[i]['PROFESSION'] + "'  id='prof1_" + i + "'  >"
                //    buf2 += "</td>"
                //}
                if (dsgrid.Tables[0].Rows[i]['MOBILE_NO'] == 0 || dsgrid.Tables[0].Rows[i]['MOBILE_NO'] == null) {
                    buf2 += "<td   class='colum-td'>"
                    buf2 += "<input type='text' class='dropdown_large_corr'  Enabled='false'disabled  class='colum-age'  id='mobile_" + i + "'  >"
                    buf2 += "</td>"
                }
                else {
                    buf2 += "<td   class='colum-td'>"
                    buf2 += "<input type='text' class='dropdown_large_corr'  Enabled='false'disabled class='colum-age'  value='" + dsgrid.Tables[0].Rows[i]['MOBILE_NO'] + "'  id='mobile_" + i + "'  >"
                    buf2 += "</td>"
                }


                buf2 += "<td   class='colum-td'>"
                buf2 += "<input type='text'  class='colum-age' class='dropdown_large_corr'  value='" + dsgrid.Tables[0].Rows[i]['DOB'] + "'  id='age1_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   class='colum-td'>"
                buf2 += "<input type='text'  class='colum-age' class='dropdown_large_corr'  value='" + dsgrid.Tables[0].Rows[i]['TOB'] + "'  id='tob_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   class='colum-td'>"
                buf2 += "<input type='text'  class='colum-age' class='dropdown_large_corr'  value='" + dsgrid.Tables[0].Rows[i]['COUNTRY'] + "'  id='con_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   class='colum-td'>"
                buf2 += "<input type='text'  class='colum-age' class='dropdown_large_corr'  value='" + dsgrid.Tables[0].Rows[i]['STATE'] + "'  id='state_" + i + "'  >"
                buf2 += "</td>"

                if (dsgrid.Tables[0].Rows[i]['DISTRICT'] == 0 || dsgrid.Tables[0].Rows[i]['DISTRICT'] == null) {
                    buf2 += "<td   class='colum-td' style='display:none;'>"
                    buf2 += "<input type='text' class='dropdown_large_corr' style='display:none;' Enabled='false'disabled  class='colum-age'  id='dist_" + i + "'  >"
                    buf2 += "</td>"
                }
                else {
                    buf2 += "<td   class='colum-td'  style='display:none;'>"
                    buf2 += "<input type='text'  class='colum-age' class='dropdown_large_corr'  style='display:none;' value='" + dsgrid.Tables[0].Rows[i]['DISTRICT'] + "'  id='dist_" + i + "'  >"
                    buf2 += "</td>"
                }
                buf2 += "<td   class='colum-td'>"
                buf2 += "<input type='text'  class='colum-age' class='dropdown_large_corr'  value='" + dsgrid.Tables[0].Rows[i]['CITY'] + "'  id='city_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   class='colum-td'>"
                buf2 += "<input type='text'   class='colum-age' class='dropdown_large_corr'  value='" + dsgrid.Tables[0].Rows[i]['GENDER'] + "'  id='gender1_" + i + "'  >"
                buf2 += "</td>"

                if (document.getElementById('hdnid').value == 'clgroup') {
                    buf2 += "<td   class='colum-td'>"
                    buf2 += "<input type='button' class='per_btn1_2 '  onClick='javascript:return vargas(id);' value='Add Notes'  id='open_" + i + "'  >"
                    buf2 += "</td>"
                }

                else {

                    buf2 += "<td   class='colum-td'>"
                    buf2 += "<input type='button' class='per_btn1_2 '  onClick='javascript:return vargas(id);' value='Show Case Study'  id='open_" + i + "'  >"
                    buf2 += "</td>"
                }


                buf2 += "</tr>"
                //                group1=group;


            }


        }

        else {

            alert('There is no Data regarding your query');
            return false;
        }

        flag = '0';
        buf2 += "</table>"
        buf2 += "</tr>"
        //buf2 += "</tr>"
        buf2 += "</table>"
        //buf2 += "</tr>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        document.getElementById('hdsviewgrid2').innerHTML = temp_del1;




    }
}




function updatedata() {


    var name = document.getElementById('name_0').value;
    var mainmail = document.getElementById('pmail1_0').value;
    var altmail = document.getElementById('altmail_0').value;
    var mobno = document.getElementById('mobno_0').value;
    var landno = document.getElementById('landno_0').value;
    var add1 = document.getElementById('add1_0').value;
    var dd2 = document.getElementById('add2_0').value;
    var landmark = document.getElementById('landmark_0').value;
    var country1 = document.getElementById('country_0').value;
    var zip = document.getElementById('zip_0').value;
    var pwd = document.getElementById('pwd_0').value;
    horary_illustration.update(name, altmail, mobno, landno, add1, dd2, country1, zip, pwd, landmark, mainmail);
    alert('update successfully');
    accountuser();



}

function update_data(id) {
    var cmail = id.split('_')
    var cmail1 = cmail[1];
    var group = document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text

    var astrodetail = document.getElementById('hdnasn').value
    var clidetail = document.getElementById('cname1_' + cmail1).value;
    var profession = document.getElementById('prof1_' + cmail1).value;
    var age = document.getElementById('age1_' + cmail1).value;
    var gender = document.getElementById('gender1_' + cmail1).value;
    var pmail = document.getElementById('hdnas').value
    var climail = document.getElementById('climale1_' + cmail1).value;
    var mobile = document.getElementById('mobile_' + cmail1).value;
    var flagu = 1;
    window.open('astro_client.aspx?clmail=' + climail + "&clname=" + clidetail + "&astname=" + astrodetail + "&astmail=" + pmail + "&usermail=" + document.getElementById("hdnuser").value + "&group=" + group + "&prof=" + profession + "&age=" + age + "&gender=" + gender + "&mob=" + mobile + "&flag=" + flagu);

    //myaccount.updateclient(astrodetail,clidetail,profession,age,gender,pmail,climail,group);

    //alert('update successfully');
    //accountuser();


}

function onclientmail(id) {
    var cmail = id.split('_')
    var cmail1 = cmail[1];
    var group = document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text
    var clname = document.getElementById("cname1_" + cmail1).value;
    var clmail = document.getElementById("climale1_" + cmail1).value;
    var astname = document.getElementById('hdnasn').value
    var astmail = document.getElementById('hdnas').value
    gropu = 'Horary';
    window.open('homenewpage.aspx?clmail=' + clmail + "&clname=" + clname + "&astname=" + astname + "&astmail=" + astmail + "&usermail=" + document.getElementById("hdnuser").value + "&group=" + group + "&group_u=" + gropu + "&mobile=" + document.getElementById("mobile_" + cmail1).value + "&dob=" + document.getElementById("age1_" + cmail1).value + "&tob=" + document.getElementById("tob_" + cmail1).value + "&country=" + document.getElementById("con_" + cmail1).value + "&state=" + document.getElementById("state_" + cmail1).value + "&dist=" + document.getElementById("dist_" + cmail1).value + "&city=" + document.getElementById("city_" + cmail1).value + "&prof=" + document.getElementById("prof1_" + cmail1).value + "&sex=" + document.getElementById("gender1_" + cmail1).value + "&cd=" + 2);

    return false;
}


function newcl() {
    var astrologer = document.getElementById('Hidden9').value;
    var astname = document.getElementById('name_0').value;
    var flag = 0;
    window.open('astro_client.aspx?astrologer=' + astrologer + "&astname=" + astname + "&usermail=" + document.getElementById('hdnuser').value + "&flag=" + flag);
    return false;
}




function click_trcode(hd) {
    var astrologer = document.getElementById('Hidden9').value;
    var grop = document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text
    gropu = document.getElementById('hdngroupunder').value;
    valueType = hd;

    if (valueType == "cliname") {
        viewcolname = "CLIENT_NAME";
    }

    else if (valueType == "prof") {
        viewcolname = "PROFESSION";
    }



    var orderby = "";
    if (flag1 == true) {

        orderby = "ASC";
        flag1 = false
    }
    else {

        orderby = "DESC";
        flag1 = true

    }

    horary_illustration.abc(astrologer, grop, viewcolname, orderby,gropu, callback_fillgrid2);

    return false;

}

function craeatnewchart() {
    var astmail = document.getElementById('Hidden9').value;
    var astname = document.getElementById('name_0').value;
    var clmail = "";
    var clname = "";
    // alert(astmail); 
    var group = document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text
    window.open('homenewpage.aspx?astmail=' + astmail + "&astname=" + astname + "&clmail=" + clmail + "&clname=" + clname + "&usermail=" + document.getElementById('hdnuser').value + "&group=" + group);

    return false;

}


function delete_data(id) {
    var gropu = document.getElementById('hdngroupunder').value;
    var group = document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text
    var spl = id.split('_')
    var spl1 = spl[1];
    if (id == 'delete_0') {
        var flag = 'A'
        var client_id = "";
    }
    else {

        var flag = 'C';
        var client_id = document.getElementById('climale1_' + spl1).value;
        var r = confirm("Are You Sure You Want To Delete This? ");
        if (r == true) {
            var astrologer_id = document.getElementById('hdnas').value;

            horary_illustration.datadel(astrologer_id, client_id, flag, group,gropu)
            alert('Delete Sucessfully')
            if (flag == 'A') {
                window.open('login.aspx');

            }
            if (flag == 'C') {
                cldetail();

            }
        }
        else {
            return false;
        }


    }




}
function trim(stringToTrim) {
return stringToTrim.replace(/^\s+|\s+$/g, "");
}

function save_data() {
    var clname = document.getElementById('DropDownList1').innerHTML
    var clmail = (document.getElementById('DropDownList2').innerHTML);
    var study = FCKeditorAPI.GetInstance("explanation_text").GetHTML();
    var gropu = document.getElementById('hdngroupunder').value;
    if (document.getElementById('cat').selectedIndex == 0) {
        alert('Select Category Name !');
        return false;
    }
    else if (document.getElementById('cat').selectedIndex == 1) {
        cat_id = trim(document.getElementById('catn').value)
    }
    else {
        cat_id = document.getElementById('cat').value;
    }
    if (document.getElementById('hdnid').value == 'adgrp') {
        var grop = document.getElementById('adgrp').options[document.getElementById('adgrp').selectedIndex].text

    }

    else {
        var grop = document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text


    }
    horary_illustration.save_data(cat_id, clname, clmail, document.getElementById('Hidden9').value, study, grop, gropu)
    alert('Data Saved')
    document.getElementById('cat').selectedIndex = 0;
    document.getElementById('catn').style.display = 'none'

    FCKeditorAPI.GetInstance('explanation_text').SetHTML("");
   
    return false;



}


function update_data() {
    var clname = document.getElementById('DropDownList1').innerHTML
    var clmail = (document.getElementById('DropDownList2').innerHTML);
    var study = FCKeditorAPI.GetInstance("explanation_text").GetHTML();

    if (document.getElementById('cat').selectedIndex == 0) {
        alert('Select Category Name !');
        return false;
    }
    else if (document.getElementById('cat').selectedIndex == 1) {
        cat_id = trim(document.getElementById('catn').value)
    }
    else {
        cat_id = document.getElementById('cat').value;
    }

    if (document.getElementById('hdnid').value == 'adgrp') {
        var grop = document.getElementById('adgrp').options[document.getElementById('adgrp').selectedIndex].text

    }

    else {
        var grop = document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text


    }
    gropu = document.getElementById('hdngroupunder').value;
    
    horary_illustration.update_data(cat_id, clname, clmail, document.getElementById('Hidden9').value, study,grop,gropu)
    alert('Data Updated')
    document.getElementById('cat').selectedIndex = 0;
    document.getElementById('catn').style.display = 'none'

    FCKeditorAPI.GetInstance('explanation_text').SetHTML("");

    return false;



}


function delete_data() {
    var clname = document.getElementById('DropDownList1').innerHTML
    var clmail = (document.getElementById('DropDownList2').innerHTML);
    var study = FCKeditorAPI.GetInstance("explanation_text").GetHTML();

    if (document.getElementById('cat').selectedIndex == 0) {
        alert('Select Category Name !');
        return false;
    }
    else if (document.getElementById('cat').selectedIndex == 1) {
        cat_id = trim(document.getElementById('catn').value)
    }
    else {
        cat_id = document.getElementById('cat').value;
    }
    if (document.getElementById('hdnid').value == 'adgrp') {
        var grop = document.getElementById('adgrp').options[document.getElementById('adgrp').selectedIndex].text

    }

    else {
        var grop = document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text


    }
    gropu = document.getElementById('hdngroupunder').value;
    horary_illustration.delete_data(cat_id, clname, clmail, document.getElementById('Hidden9').value, grop, gropu)
    alert('Data Deleted')
    document.getElementById('cat').selectedIndex = 0;
    document.getElementById('catn').style.display = 'none'

    FCKeditorAPI.GetInstance('explanation_text').SetHTML("");

    return false;



}


function bindadmingrp()
{
    var astrologer = document.getElementById('Hidden9').value;
    var adminid = 'hshoradm@horary.com';
    var grp_cat = document.getElementById('hdngroupunder').value;
    res = horary_illustration.searchuser(adminid, grp_cat);
    callback_drpadmin(res);

    if (astrologer == 'hshoradm@horary.com')
    {
        
        document.getElementById('Label1').style.display = 'none';
        document.getElementById('clgroup').style.display = 'none';
        
    }
    
    return false;
}



function callback_drpadmin(res) {
    //FCKeditorAPI.GetInstance('explanation_text').SetHTML("");
    var ds = res.value;
   
    var edtn = $("adgrp");
    edtn.options.length = 1;
    
    edtn.options[0] = new Option("Select Group", "0");
    edtn.options[1] = new Option("General", "1");
    if (ds != null && typeof (ds) == "object" && ds.Tables[1].Rows.length > 0) {
        for (var i = 0; i < ds.Tables[1].Rows.length; i++) {
            edtn.options[edtn.options.length] = new Option(ds.Tables[1].Rows[i].CAT_ID, ds.Tables[1].Rows[i].CAT_ID)
            edtn.options.length;
        }
    }
   
}