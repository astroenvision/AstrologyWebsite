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






function grid() {
    var astrolrger = document.getElementById('Hastmail').value;
    if (document.getElementById('pw').checked == true) {
        var awastha = document.getElementById('pw').value
    }
    if (document.getElementById('va').checked == true) {
        var awastha = document.getElementById('va').value
    }
    if (document.getElementById('sa').checked == true) {
        var awastha = document.getElementById('sa').value
    }
    if (document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text == 'General') {
        var client = document.getElementById('grcl').value;
    }
    else {
        var client = "";
    }
    var res = researchtool_awastha.search(awastha, astrolrger, document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text, client);
    var ds = res.value;
   
    document.getElementById('hdsviewgrid').innerHTML = "";
    document.getElementById('Divgrid1').style.display = 'block';
    var temp_del1 = "";
    buf1 = ""; 
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
    len = 1; 
    
    buf1 += "<table  id='Divgrid1' runat='server' align='left' Width='970px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
    if (ds.Tables[0].Rows.length > 0) {
        buf1 += "<tr>"
        buf1 += "<td class='colum-td-head'>" + "Client Name : " + ds.Tables[0].Rows[0].CLIENT_NAME + "</td>"
        buf1 += "</tr>"

        var fv = ds.Tables[0].Rows[0].CLIENT_MAIL;
        for (i = 0; i < ds.Tables[0].Rows.length; ++i) {

            if (fv != ds.Tables[0].Rows[i].CLIENT_MAIL) {
                fv = ds.Tables[0].Rows[i].CLIENT_MAIL;
                buf1 += "<tr>"
                buf1 += "<td class='colum-td-head'>" + "Client Name : " + ds.Tables[0].Rows[i].CLIENT_NAME + "</td>"
                buf1 += "</tr>"
            }

            buf1 += "<tr>"
            buf1 += "<td class='colum-td'>"

            mystring = ds.Tables[0].Rows[i].HOROSCOPE_D01



            buf1 += "<font width='90px'>" + ((i + 1 + '.    '))
            buf1 += "<font width='90px'>" + (mystring) + "</font>"
            buf1 += "<input type='hidden' id=pl_" + i + "  value =" + (mystring) + ">"
            buf1 += "</td>"

            buf1 += "</tr>"


        }
    }
    else {
        alert('There is no result');
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



}







function search(id) {

    var split = id.split('_')
    var split1 = split[1];
    var planet = document.getElementById("planets_" + split1).value;
    var astrolrger = document.getElementById('Hastmail').value;
    var nakshatra = "";

    if (document.getElementById('ash1c_').checked == true) {
        nakshatra = 'Ashwini' + ',' + nakshatra;
    }

    if (document.getElementById('bha2c_').checked == true) {
        nakshatra = 'Bharani' + ',' + nakshatra;
    }

    if (document.getElementById('kri3c_').checked == true) {
        nakshatra = 'Krittika' + ',' + nakshatra;
    }

    if (document.getElementById('roh4c_').checked == true) {
        nakshatra = 'Rohini' + ',' + nakshatra;
    }

    if (document.getElementById('mri5c_').checked == true) {
        nakshatra = 'Mrigshira' + ',' + nakshatra;
    }

    if (document.getElementById('ard6c_').checked == true) {
        nakshatra = 'Ardra' + ',' + nakshatra;
    }

    if (document.getElementById('pun7c_').checked == true) {
        nakshatra = 'Punarvasu' + ',' + nakshatra;
    }

    if (document.getElementById('pus8c_').checked == true) {
        nakshatra = 'Pushya' + ',' + nakshatra;
    }

    if (document.getElementById('ash9c_').checked == true) {
        nakshatra = 'Ashlesha' + ',' + nakshatra;
    }

    if (document.getElementById('mag10c_').checked == true) {
        nakshatra = 'Magha' + ',' + nakshatra;
    }

    if (document.getElementById('pph11c_').checked == true) {
        nakshatra = 'Poorva Phalguni' + ',' + nakshatra;
    }

    if (document.getElementById('uph12c_').checked == true) {
        nakshatra = 'Uttara Phalguni' + ',' + nakshatra;
    }

    if (document.getElementById('has13c_').checked == true) {
        nakshatra = 'Hasta' + ',' + nakshatra;
    }

    if (document.getElementById('chi14c_').checked == true) {
        nakshatra = 'Chitra' + ',' + nakshatra;
    }

    if (document.getElementById('swa15c_').checked == true) {
        nakshatra = 'Swati' + ',' + nakshatra;
    }

    if (document.getElementById('vis16c_').checked == true) {
        nakshatra = 'Vishakha' + ',' + nakshatra;
    }

    if (document.getElementById('anu17c_').checked == true) {
        nakshatra = 'Anuradha' + ',' + nakshatra;
    }

    if (document.getElementById('jye18c_').checked == true) {
        nakshatra = 'Jyestha' + ',' + nakshatra;
    }

    if (document.getElementById('moo19c_').checked == true) {
        nakshatra = 'Moola' + ',' + nakshatra;
    }

    if (document.getElementById('pas20c_').checked == true) {
        nakshatra = 'Poorva Ashadah' + ',' + nakshatra;
    }

    if (document.getElementById('uas21c_').checked == true) {
        nakshatra = 'Uttara Ashadah' + ',' + nakshatra;
    }

    if (document.getElementById('shr22c_').checked == true) {
        nakshatra = 'Shravana' + ',' + nakshatra;
    }

    if (document.getElementById('dha23c_').checked == true) {
        nakshatra = 'Dhanishth' + ',' + nakshatra;
    }

    if (document.getElementById('sha24c_').checked == true) {
        nakshatra = 'Shatbhisha' + ',' + nakshatra;
    }

    if (document.getElementById('pbh25c_').checked == true) {
        nakshatra = 'Poorva Bhadrapada' + ',' + nakshatra;
    }

    if (document.getElementById('ubh26c_').checked == true) {
        nakshatra = 'Uttara Bhadrapada' + ',' + nakshatra;
    }

    if (document.getElementById('rev27c_').checked == true) {
        nakshatra = 'Revati' + ',' + nakshatra;
    }


    var nakshatra1 = nakshatra.slice(0, -1);

    if (find_flag == 1) {
        if (nakshatra1 == "" || document.getElementById('clgroup').value == "0") {
            alert('Pls select Group name or nakshatra');
            return false;
        }
    }
    if (document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text == 'General') {
        var client = document.getElementById('grcl').value;
    }
    else {
        var client = "";
    }
    var res = researchtool_nakshatra.search(planet, nakshatra1, astrolrger, document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text, client);
    var ds = res.value;
    var inc = 1;
    var dec = 0;
    document.getElementById('total_' + split1).value = "0";

    if (find_flag == 1) {
        if (document.getElementById('ash1c_').checked == true) {
            document.getElementById('ash1c_' + split1).value = 0
        }
        else {
            document.getElementById('ash1c_' + split1).value = ""
        }

        if (document.getElementById('bha2c_').checked == true) {
            document.getElementById('bha2c_' + split1).value = 0
        }
        else {
            document.getElementById('bha2c_' + split1).value = ""
        }

        if (document.getElementById('kri3c_').checked == true) {
            document.getElementById('kri3c_' + split1).value = 0
        }
        else {
            document.getElementById('kri3c_' + split1).value = ""
        }

        if (document.getElementById('roh4c_').checked == true) {
            document.getElementById('roh4c_' + split1).value = 0
        }
        else {
            document.getElementById('roh4c_' + split1).value = ""
        }

        if (document.getElementById('mri5c_').checked == true) {
            document.getElementById('mri5c_' + split1).value = 0
        }
        else {
            document.getElementById('mri5c_' + split1).value = ""
        }

        if (document.getElementById('ard6c_').checked == true) {
            document.getElementById('ard6c_' + split1).value = 0
        }
        else {
            document.getElementById('ard6c_' + split1).value = ""
        }

        if (document.getElementById('pun7c_').checked == true) {
            document.getElementById('pun7c_' + split1).value = 0
        }
        else {
            document.getElementById('pun7c_' + split1).value = ""
        }

        if (document.getElementById('pus8c_').checked == true) {
            document.getElementById('pus8c_' + split1).value = 0
        }
        else {
            document.getElementById('pus8c_' + split1).value = ""
        }

        if (document.getElementById('ash9c_').checked == true) {
            document.getElementById('ash9c_' + split1).value = 0
        }
        else {
            document.getElementById('ash9c_' + split1).value = ""
        }

        if (document.getElementById('mag10c_').checked == true) {
            document.getElementById('mag10c_' + split1).value = 0
        }
        else
        { document.getElementById('mag10c_' + split1).value = "" }

        if (document.getElementById('pph11c_').checked == true) {
            document.getElementById('pph11c_' + split1).value = 0
        }
        else
        { document.getElementById('pph11c_' + split1).value = "" }

        if (document.getElementById('uph12c_').checked == true) {
            document.getElementById('uph12c_' + split1).value = 0
        }
        else
        { document.getElementById('uph12c_' + split1).value = "" }

        if (document.getElementById('has13c_').checked == true) {
            document.getElementById('has13c_' + split1).value = 0
        }
        else
        { document.getElementById('has13c_' + split1).value = "" }

        if (document.getElementById('chi14c_').checked == true) {
            document.getElementById('chi14c_' + split1).value = 0
        }
        else
        { document.getElementById('chi14c_' + split1).value = "" }

        if (document.getElementById('swa15c_').checked == true) {
            document.getElementById('swa15c_' + split1).value = 0
        }
        else
        { document.getElementById('swa15c_' + split1).value = "" }

        if (document.getElementById('vis16c_').checked == true) {
            document.getElementById('vis16c_' + split1).value = 0
        }
        else
        { document.getElementById('vis16c_' + split1).value = "" }

        if (document.getElementById('anu17c_').checked == true) {
            document.getElementById('anu17c_' + split1).value = 0
        }
        else
        { document.getElementById('anu17c_' + split1).value = "" }

        if (document.getElementById('jye18c_').checked == true) {
            document.getElementById('jye18c_' + split1).value = 0
        }
        else
        { document.getElementById('jye18c_' + split1).value = "" }

        if (document.getElementById('moo19c_').checked == true) {
            document.getElementById('moo19c_' + split1).value = 0
        }
        else
        { document.getElementById('moo19c_' + split1).value = "" }

        if (document.getElementById('pas20c_').checked == true) {
            document.getElementById('pas20c_' + split1).value = 0
        }
        else
        { document.getElementById('pas20c_' + split1).value = "" }

        if (document.getElementById('uas21c_').checked == true) {
            document.getElementById('uas21c_' + split1).value = 0
        }
        else
        { document.getElementById('uas21c_' + split1).value = "" }


        if (document.getElementById('shr22c_').checked == true) {
            document.getElementById('shr22c_' + split1).value = 0
        }
        else
        { document.getElementById('shr22c_' + split1).value = "" }


        if (document.getElementById('dha23c_').checked == true) {
            document.getElementById('dha23c_' + split1).value = 0
        }
        else {
            document.getElementById('dha23c_' + split1).value = ""
        }


        if (document.getElementById('sha24c_').checked == true) {
            document.getElementById('sha24c_' + split1).value = 0
        }
        else
        { document.getElementById('sha24c_' + split1).value = "" }


        if (document.getElementById('pbh25c_').checked == true) {
            document.getElementById('pbh25c_' + split1).value = 0
        }
        else
        { document.getElementById('pbh25c_' + split1).value = "" }


        if (document.getElementById('ubh26c_').checked == true) {
            document.getElementById('ubh26c_' + split1).value = 0
        }
        else
        { document.getElementById('ubh26c_' + split1).value = "" }


        if (document.getElementById('rev27c_').checked == true) {
            document.getElementById('rev27c_' + split1).value = 0
        }
        else
        { document.getElementById('rev27c_' + split1).value = "" }
    }

    if (ds.Tables[0].Rows.length > 0) {

        for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
            if (find_flag == 1) {
                if (document.getElementById('ash1c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('ash1c_').value) {

                        if (document.getElementById('ash1c_' + split1) != null) {
                            if (document.getElementById('ash1c_' + split1).value == "") {
                                document.getElementById('ash1c_' + split1).value = 0;
                            }
                            document.getElementById('ash1c_' + split1).value = parseInt(document.getElementById('ash1c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('ash1c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('ash1c_' + split1) != null) {
                            if (document.getElementById('ash1c_' + split1).value == "") {
                                document.getElementById('ash1c_' + split1).value = 0;
                            }
                            document.getElementById('ash1c_' + split1).value = parseInt(document.getElementById('ash1c_' + split1).value) + parseInt(inc);

                            totalh = parseInt(totalh) + parseInt(document.getElementById('ash1c_' + split1).value);

                        }
                        else { }
                    }
                }
                if (document.getElementById('bha2c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('bha2c_').value) {

                        if (document.getElementById('bha2c_' + split1) != null) {
                            if (document.getElementById('bha2c_' + split1).value == "") {
                                document.getElementById('bha2c_' + split1).value = 0;
                            }
                            document.getElementById('bha2c_' + split1).value = parseInt(document.getElementById('bha2c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('bha2c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('bha2c_' + split1) != null) {
                            if (document.getElementById('bha2c_' + split1).value == "") {
                                document.getElementById('bha2c_' + split1).value = 0;
                            }
                            document.getElementById('bha2c_' + split1).value = parseInt(document.getElementById('bha2c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('bha2c_' + split1).value);
                        }
                        else { }
                    }

                }
                if (document.getElementById('kri3c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('kri3c_').value) {
                        if (document.getElementById('kri3c_' + split1) != null) {
                            if (document.getElementById('kri3c_' + split1).value == "") {
                                document.getElementById('kri3c_' + split1).value = 0;
                            }
                            document.getElementById('kri3c_' + split1).value = parseInt(document.getElementById('kri3c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('kri3c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('kri3c_' + split1) != null) {
                            if (document.getElementById('kri3c_' + split1).value == "") {
                                document.getElementById('kri3c_' + split1).value = 0;
                            }
                            document.getElementById('kri3c_' + split1).value = parseInt(document.getElementById('kri3c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('kri3c_' + split1).value);
                        }
                        else { }
                    }

                }
                if (document.getElementById('roh4c_').checked == true) {


                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('roh4c_').value) {
                        if (document.getElementById('roh4c_' + split1) != null) {
                            if (document.getElementById('roh4c_' + split1).value == "") {
                                document.getElementById('roh4c_' + split1).value = 0;
                            }
                            document.getElementById('roh4c_' + split1).value = parseInt(document.getElementById('roh4c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('roh4c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('roh4c_' + split1) != null) {
                            if (document.getElementById('roh4c_' + split1).value == "") {
                                document.getElementById('roh4c_' + split1).value = 0;
                            }
                            document.getElementById('roh4c_' + split1).value = parseInt(document.getElementById('roh4c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('roh4c_' + split1).value);
                        }
                        else { }
                    }
                }
                if (document.getElementById('mri5c_').checked == true) {


                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('mri5c_').value) {
                        if (document.getElementById('mri5c_' + split1) != null) {
                            if (document.getElementById('mri5c_' + split1).value == "") {
                                document.getElementById('mri5c_' + split1).value = 0;
                            }
                            document.getElementById('mri5c_' + split1).value = parseInt(document.getElementById('mri5c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('mri5c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('mri5c_' + split1) != null) {
                            if (document.getElementById('mri5c_' + split1).value == "") {
                                document.getElementById('mri5c_' + split1).value = 0;
                            }
                            document.getElementById('mri5c_' + split1).value = parseInt(document.getElementById('mri5c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('mri5c_' + split1).value);
                        }
                        else { }
                    }
                }

                if (document.getElementById('ard6c_').checked == true) {

                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('ard6c_').value) {
                        if (document.getElementById('ard6c_' + split1) != null) {
                            if (document.getElementById('ard6c_' + split1).value == "") {
                                document.getElementById('ard6c_' + split1).value = 0;
                            }
                            document.getElementById('ard6c_' + split1).value = parseInt(document.getElementById('ard6c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('ard6c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('ard6c_' + split1) != null) {
                            if (document.getElementById('ard6c_' + split1).value == "") {
                                document.getElementById('ard6c_' + split1).value = 0;
                            }
                            document.getElementById('ard6c_' + split1).value = parseInt(document.getElementById('ard6c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('ard6c_' + split1).value);
                        }
                        else { }
                    }
                }

                if (document.getElementById('pun7c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('pun7c_').value) {
                        if (document.getElementById('pun7c_' + split1) != null) {
                            if (document.getElementById('pun7c_' + split1).value == "") {
                                document.getElementById('pun7c_' + split1).value = 0;
                            }
                            document.getElementById('pun7c_' + split1).value = parseInt(document.getElementById('pun7c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('pun7c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('pun7c_' + split1) != null) {
                            if (document.getElementById('pun7c_' + split1).value == "") {
                                document.getElementById('pun7c_' + split1).value = 0;
                            }
                            document.getElementById('pun7c_' + split1).value = parseInt(document.getElementById('pun7c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('pun7c_' + split1).value);
                        }
                        else { }
                    }
                }


                if (document.getElementById('pus8c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('pus8c_').value) {
                        if (document.getElementById('pus8c_' + split1) != null) {
                            if (document.getElementById('pus8c_' + split1).value == "") {
                                document.getElementById('pus8c_' + split1).value = 0;
                            }
                            document.getElementById('pus8c_' + split1).value = parseInt(document.getElementById('pus8c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('pus8c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('pus8c_' + split1) != null) {
                            if (document.getElementById('pus8c_' + split1).value == "") {
                                document.getElementById('pus8c_' + split1).value = 0;
                            }
                            document.getElementById('pus8c_' + split1).value = parseInt(document.getElementById('pus8c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('pus8c_' + split1).value);
                        }
                        else { }
                    } 
                }


                if (document.getElementById('ash9c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('ash9c_').value) {
                        if (document.getElementById('ash9c_' + split1) != null) {
                            if (document.getElementById('ash9c_' + split1).value == "") {
                                document.getElementById('ash9c_' + split1).value = 0;
                            }
                            document.getElementById('ash9c_' + split1).value = parseInt(document.getElementById('ash9c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('ash9c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('ash9c_' + split1) != null) {
                            if (document.getElementById('ash9c_' + split1).value == "") {
                                document.getElementById('ash9c_' + split1).value = 0;
                            }
                            document.getElementById('ash9c_' + split1).value = parseInt(document.getElementById('ash9c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('ash9c_' + split1).value);
                        }
                        else { }
                    }
                }

                if (document.getElementById('mag10c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('mag10c_').value) {
                        if (document.getElementById('mag10c_' + split1) != null) {
                            if (document.getElementById('mag10c_' + split1).value == "") {
                                document.getElementById('mag10c_' + split1).value = 0;
                            }
                            document.getElementById('mag10c_' + split1).value = parseInt(document.getElementById('mag10c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('mag10c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('mag10c_' + split1) != null) {
                            if (document.getElementById('mag10c_' + split1).value == "") {
                                document.getElementById('mag10c_' + split1).value = 0;
                            }
                            document.getElementById('mag10c_' + split1).value = parseInt(document.getElementById('mag10c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('mag10c_' + split1).value);
                        }
                        else { }
                    }
                }

                if (document.getElementById('pph11c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('pph11c_').value) {
                        if (document.getElementById('pph11c_' + split1) != null) {
                            if (document.getElementById('pph11c_' + split1).value == "") {
                                document.getElementById('pph11c_' + split1).value = 0;
                            }
                            document.getElementById('pph11c_' + split1).value = parseInt(document.getElementById('pph11c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('pph11c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('pph11c_' + split1) != null) {
                            if (document.getElementById('pph11c_' + split1).value == "") {
                                document.getElementById('pph11c_' + split1).value = 0;
                            }
                            document.getElementById('pph11c_' + split1).value = parseInt(document.getElementById('pph11c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('pph11c_' + split1).value);
                        }
                        else { }
                    } 
                }


                if (document.getElementById('uph12c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('uph12c_').value) {
                        if (document.getElementById('uph12c_' + split1) != null) {
                            if (document.getElementById('uph12c_' + split1).value == "") {
                                document.getElementById('uph12c_' + split1).value = 0;
                            }
                            document.getElementById('uph12c_' + split1).value = parseInt(document.getElementById('uph12c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('uph12c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('uph12c_' + split1) != null) {
                            if (document.getElementById('uph12c_' + split1).value == "") {
                                document.getElementById('uph12c_' + split1).value = 0;
                            }
                            document.getElementById('uph12c_' + split1).value = parseInt(document.getElementById('uph12c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('uph12c_' + split1).value);
                        }
                        else { }
                    } 
                }


                if (document.getElementById('has13c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('has13c_').value) {
                        if (document.getElementById('has13c_' + split1) != null) {
                            if (document.getElementById('has13c_' + split1).value == "") {
                                document.getElementById('has13c_' + split1).value = 0;
                            }
                            document.getElementById('has13c_' + split1).value = parseInt(document.getElementById('has13c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('has13c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('has13c_' + split1) != null) {
                            if (document.getElementById('has13c_' + split1).value == "") {
                                document.getElementById('has13c_' + split1).value = 0;
                            }
                            document.getElementById('has13c_' + split1).value = parseInt(document.getElementById('has13c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('has13c_' + split1).value);
                        }
                        else { }
                    } 
                }


                if (document.getElementById('chi14c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('chi14c_').value) {
                        if (document.getElementById('chi14c_' + split1) != null) {
                            if (document.getElementById('chi14c_' + split1).value == "") {
                                document.getElementById('chi14c_' + split1).value = 0;
                            }
                            document.getElementById('chi14c_' + split1).value = parseInt(document.getElementById('chi14c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('chi14c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('chi14c_' + split1) != null) {
                            if (document.getElementById('chi14c_' + split1).value == "") {
                                document.getElementById('chi14c_' + split1).value = 0;
                            }
                            document.getElementById('chi14c_' + split1).value = parseInt(document.getElementById('chi14c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('chi14c_' + split1).value);
                        }
                        else { }
                    }
                }

                if (document.getElementById('swa15c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('swa15c_').value) {
                        if (document.getElementById('swa15c_' + split1) != null) {
                            if (document.getElementById('swa15c_' + split1).value == "") {
                                document.getElementById('swa15c_' + split1).value = 0;
                            }
                            document.getElementById('swa15c_' + split1).value = parseInt(document.getElementById('swa15c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('swa15c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('swa15c_' + split1) != null) {
                            if (document.getElementById('swa15c_' + split1).value == "") {
                                document.getElementById('swa15c_' + split1).value = 0;
                            }
                            document.getElementById('swa15c_' + split1).value = parseInt(document.getElementById('swa15c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('swa15c_' + split1).value);
                        }
                        else { }
                    }
                }

                if (document.getElementById('vis16c_').checked == true) {

                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('vis16c_').value) {
                        if (document.getElementById('vis16c_' + split1) != null) {
                            if (document.getElementById('vis16c_' + split1).value == "") {
                                document.getElementById('vis16c_' + split1).value = 0;
                            }
                            document.getElementById('vis16c_' + split1).value = parseInt(document.getElementById('vis16c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('vis16c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('vis16c_' + split1) != null) {
                            if (document.getElementById('vis16c_' + split1).value == "") {
                                document.getElementById('vis16c_' + split1).value = 0;
                            }
                            document.getElementById('vis16c_' + split1).value = parseInt(document.getElementById('vis16c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('vis16c_' + split1).value);
                        }
                        else { }
                    }
                }

                if (document.getElementById('anu17c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('anu17c_').value) {
                        if (document.getElementById('anu17c_' + split1) != null) {
                            if (document.getElementById('anu17c_' + split1).value == "") {
                                document.getElementById('anu17c_' + split1).value = 0;
                            }
                            document.getElementById('anu17c_' + split1).value = parseInt(document.getElementById('anu17c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('anu17c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('anu17c_' + split1) != null) {
                            if (document.getElementById('anu17c_' + split1).value == "") {
                                document.getElementById('anu17c_' + split1).value = 0;
                            }
                            document.getElementById('anu17c_' + split1).value = parseInt(document.getElementById('anu17c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('anu17c_' + split1).value);
                        }
                        else { }
                    }
                }

                if (document.getElementById('jye18c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('jye18c_').value) {
                        if (document.getElementById('jye18c_' + split1) != null) {
                            if (document.getElementById('jye18c_' + split1).value == "") {
                                document.getElementById('jye18c_' + split1).value = 0;
                            }
                            document.getElementById('jye18c_' + split1).value = parseInt(document.getElementById('jye18c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('jye18c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('jye18c_' + split1) != null) {
                            if (document.getElementById('jye18c_' + split1).value == "") {
                                document.getElementById('jye18c_' + split1).value = 0;
                            }
                            document.getElementById('jye18c_' + split1).value = parseInt(document.getElementById('jye18c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('jye18c_' + split1).value);
                        }
                        else { }
                    }
                }

                if (document.getElementById('moo19c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('moo19c_').value) {
                        if (document.getElementById('moo19c_' + split1) != null) {
                            if (document.getElementById('moo19c_' + split1).value == "") {
                                document.getElementById('moo19c_' + split1).value = 0;
                            }
                            document.getElementById('moo19c_' + split1).value = parseInt(document.getElementById('moo19c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('moo19c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('moo19c_' + split1) != null) {
                            if (document.getElementById('moo19c_' + split1).value == "") {
                                document.getElementById('moo19c_' + split1).value = 0;
                            }
                            document.getElementById('moo19c_' + split1).value = parseInt(document.getElementById('moo19c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('moo19c_' + split1).value);
                        }
                        else { }
                    }
                }
                if (document.getElementById('pas20c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('pas20c_').value) {
                        if (document.getElementById('pas20c_' + split1) != null) {
                            if (document.getElementById('pas20c_' + split1).value == "") {
                                document.getElementById('pas20c_' + split1).value = 0;
                            }
                            document.getElementById('pas20c_' + split1).value = parseInt(document.getElementById('pas20c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('pas20c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('pas20c_' + split1) != null) {
                            if (document.getElementById('pas20c_' + split1).value == "") {
                                document.getElementById('pas20c_' + split1).value = 0;
                            }
                            document.getElementById('pas20c_' + split1).value = parseInt(document.getElementById('pas20c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('pas20c_' + split1).value);
                        }
                        else { }
                    }
                }

                if (document.getElementById('uas21c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('uas21c_').value) {
                        if (document.getElementById('uas21c_' + split1) != null) {
                            if (document.getElementById('uas21c_' + split1).value == "") {
                                document.getElementById('uas21c_' + split1).value = 0;
                            }
                            document.getElementById('uas21c_' + split1).value = parseInt(document.getElementById('uas21c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('uas21c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('uas21c_' + split1) != null) {
                            if (document.getElementById('uas21c_' + split1).value == "") {
                                document.getElementById('uas21c_' + split1).value = 0;
                            }
                            document.getElementById('uas21c_' + split1).value = parseInt(document.getElementById('uas21c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('uas21c_' + split1).value);
                        }
                        else {
                        }
                    }

                }
                if (document.getElementById('shr22c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('shr22c_').value) {
                        if (document.getElementById('shr22c_' + split1) != null) {
                            if (document.getElementById('shr22c_' + split1).value == "") {
                                document.getElementById('shr22c_' + split1).value = 0;
                            }
                            document.getElementById('shr22c_' + split1).value = parseInt(document.getElementById('shr22c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('shr22c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('shr22c_' + split1) != null) {
                            if (document.getElementById('shr22c_' + split1).value == "") {
                                document.getElementById('shr22c_' + split1).value = 0;
                            }
                            document.getElementById('shr22c_' + split1).value = parseInt(document.getElementById('shr22c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('shr22c_' + split1).value);
                        }
                        else { }
                    }
                }
                if (document.getElementById('dha23c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('dha23c_').value) {
                        if (document.getElementById('dha23c_' + split1) != null) {
                            if (document.getElementById('dha23c_' + split1).value == "") {
                                document.getElementById('dha23c_' + split1).value = 0;
                            }
                            document.getElementById('dha23c_' + split1).value = parseInt(document.getElementById('dha23c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('dha23c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('dha23c_' + split1) != null) {
                            if (document.getElementById('dha23c_' + split1).value == "") {
                                document.getElementById('dha23c_' + split1).value = 0;
                            }
                            document.getElementById('dha23c_' + split1).value = parseInt(document.getElementById('dha23c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('dha23c_' + split1).value);
                        }
                        else { }
                    }
                }
                if (document.getElementById('sha24c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('sha24c_').value) {
                        if (document.getElementById('sha24c_' + split1) != null) {
                            if (document.getElementById('sha24c_' + split1).value == "") {
                                document.getElementById('sha24c_' + split1).value = 0;
                            }
                            document.getElementById('sha24c_' + split1).value = parseInt(document.getElementById('sha24c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('sha24c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('sha24c_' + split1) != null) {
                            if (document.getElementById('sha24c_' + split1).value == "") {
                                document.getElementById('sha24c_' + split1).value = 0;
                            }
                            document.getElementById('sha24c_' + split1).value = parseInt(document.getElementById('sha24c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('sha24c_' + split1).value);
                        }
                        else { }
                    }
                }
                if (document.getElementById('pbh25c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('pbh25c_').value) {
                        if (document.getElementById('pbh25c_' + split1) != null) {
                            if (document.getElementById('pbh25c_' + split1).value == "") {
                                document.getElementById('pbh25c_' + split1).value = 0;
                            }
                            document.getElementById('pbh25c_' + split1).value = parseInt(document.getElementById('pbh25c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('pbh25c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('pbh25c_' + split1) != null) {
                            if (document.getElementById('pbh25c_' + split1).value == "") {
                                document.getElementById('pbh25c_' + split1).value = 0;
                            }
                            document.getElementById('pbh25c_' + split1).value = parseInt(document.getElementById('pbh25c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('pbh25c_' + split1).value);
                        }
                        else { }
                    }
                }
                if (document.getElementById('ubh26c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('ubh26c_').value) {
                        if (document.getElementById('ubh26c_' + split1) != null) {
                            if (document.getElementById('ubh26c_' + split1).value == "") {
                                document.getElementById('ubh26c_' + split1).value = 0;
                            }
                            document.getElementById('ubh26c_' + split1).value = parseInt(document.getElementById('ubh26c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('ubh26c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('ubh26c_' + split1) != null) {
                            if (document.getElementById('ubh26c_' + split1).value == "") {
                                document.getElementById('ubh26c_' + split1).value = 0;
                            }
                            document.getElementById('ubh26c_' + split1).value = parseInt(document.getElementById('ubh26c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('ubh26c_' + split1).value);
                        }
                        else { }
                    }
                }
                if (document.getElementById('rev27c_').checked == true) {
                    if (ds.Tables[0].Rows[i].HOROSCOPE_D01 != document.getElementById('rev27c_').value) {
                        if (document.getElementById('rev27c_' + split1) != null) {
                            if (document.getElementById('rev27c_' + split1).value == "") {
                                document.getElementById('rev27c_' + split1).value = 0;
                            }
                            document.getElementById('rev27c_' + split1).value = parseInt(document.getElementById('rev27c_' + split1).value) + parseInt(dec);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('rev27c_' + split1).value);
                        }

                        else {

                        }
                    }
                    else {
                        if (document.getElementById('rev27c_' + split1) != null) {
                            if (document.getElementById('rev27c_' + split1).value == "") {
                                document.getElementById('rev27c_' + split1).value = 0;
                            }
                            document.getElementById('rev27c_' + split1).value = parseInt(document.getElementById('rev27c_' + split1).value) + parseInt(inc);
                            totalh = parseInt(totalh) + parseInt(document.getElementById('rev27c_' + split1).value);
                        }
                        else { }
                    }
                }
            }



            document.getElementById('total_' + split1).value = totalh;
            totalh = "0";

        }

    }





    for (var i = 0; i < 7; i++) {
        if (document.getElementById('total_' + i).value == null || document.getElementById('total_' + i).value == "") {
            //      document.getElementById('total_'+i).value='0';

        }
        else {

            gridtotal = parseInt(gridtotal) + parseInt(document.getElementById('total_' + i).value); ;
        }





    }
    document.getElementById('total_' + 7).value = gridtotal;
    gridtotal = "0";
    return false;



}




function open_div_button(id) {
    document.getElementById('clinetnamediv').style.display = 'block';
    var spl1 = id.split("_");
    var spl2 = spl1[1];
    var nakshatra = document.getElementById(spl1[0] + '_').value;
    var planet = document.getElementById('planets_' + spl1[1]).value;

    var res = researchtool_nakshatra.clientinfo(nakshatra);
    var ds = res.value;
    document.getElementById('pl').innerHTML = planet;
    document.getElementById('na').innerHTML = nakshatra.toUpperCase();

    var cl_na = "";
    var cl_ma = "";
    for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
        cl_na = cl_na + ds.Tables[0].Rows[i]['CLIENT_NAME'] + '<br>';
        cl_ma = cl_ma + ds.Tables[0].Rows[i]['CLIENT_MAIL'] + '<br>';

    }

    document.getElementById('cn').innerHTML = cl_na.slice(0, -1);
    document.getElementById('cm').innerHTML = cl_ma.slice(0, -1);
    document.getElementById('na').innerHTML = nakshatra;


}



function creossdiv() {
    document.getElementById('clinetnamediv').style.display = 'none';
    return false;
}

function accountuser() {
    document.getElementById('astid').innerHTML = document.getElementById('Hastmail').value;
    var astrologer = document.getElementById('hdnuser').value;
    if (astrologer == 'astrology' || astrologer == 'ASTROLOGY' || astrologer == "") {
        // alert('you are admin');
        getopen("login.aspx");

        return false;
    }
    else {
        var grp_cat = 'Natal';
        res = researchtool_awastha.searchuser(astrologer, grp_cat);

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
        res = researchtool_awastha.searchclient(astrologer, document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text, 'Natal');
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
