var querytype = "";
var val = "";
var planetaspectplanet = "";
var exec_data = "";
var exec_extention = "";
var showext_value = "";
var next = 0;
var execute = "";
var Modify = 0;
var browser = navigator.appName;
var buf2 = new StringBuffer2();
function StringBuffer2() {
    this.buffer = [];
}

StringBuffer2.prototype.append = function append(string) {
    this.buffer.push(string);
    return this;
};


function planetaspect() {
    var planet = document.getElementById('planet').value
    var planet1 = document.getElementById('planet1').value
    var house = document.getElementById('house').value
    planetaspectplanet.aspecthouse(planet, planet1,house, callback_grid);
    return false;

}

var dsgrid = "";
function callback_grid(val) {
    var exec_grid = val.value;

    dsgrid = exec_grid
    document.getElementById('hdsviewgrid').innerHTML = "";
    document.getElementById('Divgrid1').style.display = "none";
    if (exec_grid.Tables[0].Rows.length >= 0) {
        document.getElementById('hdsviewgrid').innerHTML = "";
        document.getElementById('Divgrid1').style.display = 'block';
        $('Divgrid1').display = 'block;'


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

        if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:350px;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='350px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"

        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:15px;' class='dropdown_large_corr'; align='left'   id='chk_" + 'h' + "' onClick='javascript:return chkall(this.id);' >"
        buf2 += "</td>"

      
            



            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:60px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:60px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASP_RASHI" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:60px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASP_HOUSE" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:60px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:60px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"

        buf2 += "</tr>"

        // document.getElementById( 'filter_').focus();
        len = 1;

        if (dsgrid.Tables[0].Rows.length == 0) {

        }

        if (dsgrid.Tables[0].Rows.length > 0) {

            for (i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {


                buf2 += "<tr>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:15px;' class='dropdown_large_corr'; align='left'   id='chk_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:60px;' class='dropdown_large_corr'; align='left' value='" + dsgrid.Tables[0].Rows[i]['LAGNA_RASHI'] + "'  id='lr_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:60px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['ASPECTED_PLANET_RASHI'] + "'  id='apr_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:60px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['ASPECTED_PLANET_HOUSE'] + "'  id='aph_" + i + "'  >"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:60px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['RASHI'] + "'  id='rashi_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:60px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['HOUSE'] + "'  id='house_" + i + "'  >"
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
        return false;
    }

}




function chkall(id) {
    if (document.getElementById('chk_h').checked == true) {
        for (i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
            if (document.getElementById('chk_' + i).checked == false) {
                document.getElementById('chk_' + i).checked = true;

            }

        }
    }
    else {
        for (i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
            if (document.getElementById('chk_' + i).checked == true) {
                document.getElementById('chk_' + i).checked = false;

            }
        }
    }


}



function Save_Records() {
    for (i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
        var f13book = document.getElementById('txtbook').value;
        var f13page = document.getElementById('txtpage').value;
        var keystring = document.getElementById('txtkey').value;
        var f13planet = document.getElementById('planet').value;
        var f13aplanet = document.getElementById('planet1').value;
        var f13house = document.getElementById('house').value;
        var lagna = document.getElementById('lr_' + i).value;
        var aplanetrashi = document.getElementById('apr_' + i).value;
        var aplanethouse = document.getElementById('aph_' + i).value;
        var planetrashi = document.getElementById('rashi_' + i).value;
        var planethouse = document.getElementById('house_' + i).value;
        var combination = f13planet + aplanetrashi + aplanethouse + f13aplanet + planetrashi + planethouse;
        var detail = document.getElementById('detail').value;
        var desc = f13planet + ' in ' + f13house + ' Aspected by ' + f13aplanet;

       planetaspectplanet.save(f13planet, f13house, f13aplanet, f13book, f13page, keystring, detail, desc, combination, lagna)
    }
    alert('saved successfully')
    document.getElementById('house').value = "";
    document.getElementById('planet').value = "";
    document.getElementById('planet1').value = "";
    document.getElementById('txtbook').value = "";
    document.getElementById('txtkey').value = "";
    document.getElementById('txtpage').value = "";
    document.getElementById('detail').value = "";
    return false;

}


function blankfields() {

    document.getElementById('btnNew').disabled = false;
    document.getElementById('btnNew').focus();
    document.getElementById('btnQuery').disabled = false;
    document.getElementById('btnCancel').disabled = false;
    document.getElementById('btnExit').disabled = false;
    document.getElementById('btnSave').disabled = true;
    document.getElementById('btnExecute').disabled = true;
    document.getElementById('btnfirst').disabled = true;
    document.getElementById('btnlast').disabled = true;
    document.getElementById('btnModify').disabled = true;
    document.getElementById('btnprevious').disabled = true;
    document.getElementById('btnnext').disabled = true;
    document.getElementById('btnDelete').disabled = true;

    document.getElementById('txtsigni').disabled = true;



    return false;
}


function modifydata() {

    Modify = 1;

    var modifyduplicacydesc = $('txtextentions').value;

    document.getElementById("txtextentions").disabled = false;



    document.getElementById("btnModify").disabled = true;
    document.getElementById("btnlast").disabled = true;
    document.getElementById("btnnext").disabled = true;
    document.getElementById("btnfirst").disabled = true;
    document.getElementById("btnprevious").disabled = true;
    document.getElementById("btnDelete").disabled = false;
    document.getElementById("btnSave").disabled = false;
    modify = "true";



    delete_record = 0;

    setButtonImages();

    return false;
}

function ModifyClass() {









    var txtextentions = (document.getElementById('txtextentions').value);
    var casetxtextentions = txtextentions;









    var hiddenmodtxtextentions = document.getElementById("hiddenmodtxtextentions").value;



    astroextentions.Modifydata1(casetxtextentions, hiddenmodtxtextentions)


    alert("Data updated Successfully")
    click_on_cancel();
    return false;

}




