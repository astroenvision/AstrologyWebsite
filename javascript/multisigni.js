var multiplesignificators = "";
var querytype = "";
var val = "";
var exec_data = "";
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


function fillhouse(event) 
{ 
   var keycode = event.keyCode ? event.keyCode : event.which;
   if (keycode == 113)
     {
        if (document.activeElement.id == "txthouse") {
            document.getElementById('lsthouse').value = "";
            //var compcode = $('hdncompcode').value;
            //var unit=$('hdnunitcode').value;
            document.getElementById("divhouse").style.display = "block";
            document.getElementById('divhouse').style.top = 170 + "px";
            document.getElementById('divhouse').style.left = 310 + "px";

            var extra1 = document.getElementById('txthouse').value;
            document.getElementById('txthouse').focus();
            multiplesignificators.fill_house(extra1, callback_house);
            return false;
        }

    }


}

function callback_house(res) {
    ds = res.value;
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        var pkgitem = document.getElementById("lsthouse");
        pkgitem.options.length = 0;
        pkgitem.options[0] = new Option("--Select House--", "0");
        pkgitem.options.length = 1;
        for (var i = 0; i < ds.Tables[0].Rows.length; ++i) {
            //pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].REASON_CODE+"-"+ds.Tables[0].Rows[i].REASON_NAME,ds.Tables[0].Rows[i].REASON_CODE);
            pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].CODE);
            pkgitem.options.length;
        }
    }
    document.getElementById('lsthouse').style.display = "block";
    document.getElementById('lsthouse').focus();
    return false;
}

function fillplanet(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "txtplanet") {
            document.getElementById('lstplanet').value = "";
            //var compcode = $('hdncompcode').value;
            //var unit=$('hdnunitcode').value;
            document.getElementById("divplanet").style.display = "block";
            document.getElementById('divplanet').style.top = 170 + "px";
            document.getElementById('divplanet').style.left = 455 + "px";

            var extra1 = document.getElementById('txtplanet').value;
            document.getElementById('txtplanet').focus();
            multiplesignificators.fill_planet(extra1, callback_planet);
            return false;
        }

    }


}

function callback_planet(res) {
    ds = res.value;
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        var pkgitem = document.getElementById("lstplanet");
        pkgitem.options.length = 0;
        pkgitem.options[0] = new Option("--Select Planet--", "0");
        pkgitem.options.length = 1;
        for (var i = 0; i < ds.Tables[0].Rows.length; ++i) {
            //pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].REASON_CODE+"-"+ds.Tables[0].Rows[i].REASON_NAME,ds.Tables[0].Rows[i].REASON_CODE);
            pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].CODE);
            pkgitem.options.length;
        }
    }
    document.getElementById('lstplanet').style.display = "block";
    document.getElementById('lstplanet').focus();
    return false;
}

function fillrashi(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "txtrashi") {
            document.getElementById('lstrashi').value = "";
            //var compcode = $('hdncompcode').value;
            //var unit=$('hdnunitcode').value;
            document.getElementById("divrashi").style.display = "block";
            document.getElementById('divrashi').style.top = 170 + "px";
            document.getElementById('divrashi').style.left = 595 + "px";

            var extra1 = document.getElementById('txtrashi').value;
            document.getElementById('txtrashi').focus();
            multiplesignificators.fill_rashi(extra1, callback_rashi);
            return false;
        }

    }


}

function callback_rashi(res) {
    ds = res.value;
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        var pkgitem = document.getElementById("lstrashi");
        pkgitem.options.length = 0;
        pkgitem.options[0] = new Option("--Select Rashi--", "0");
        pkgitem.options.length = 1;
        for (var i = 0; i < ds.Tables[0].Rows.length; ++i) {
            //pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].REASON_CODE+"-"+ds.Tables[0].Rows[i].REASON_NAME,ds.Tables[0].Rows[i].REASON_CODE);
            pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].CODE);
            pkgitem.options.length;
        }
    }
    document.getElementById('lstrashi').style.display = "block";
    document.getElementById('lstrashi').focus();
    return false;
}


function closehouse(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 27) {
        for (var i = 0; i < document.getElementById('lsthouse').options.length; ++i) {
            document.getElementById('lsthouse').options[i].selected = false;

        }
        document.getElementById('divhouse').style.display = "none";
        document.getElementById('txthouse').value = "";
        document.getElementById('txthouse').focus();

        return false;
    }

}

function closeplanet(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 27) {
        for (var i = 0; i < document.getElementById('lstplanet').options.length; ++i) {
            document.getElementById('lstplanet').options[i].selected = false;

        }
        document.getElementById('divplanet').style.display = "none";
        document.getElementById('txtplanet').value = "";
        document.getElementById('txtplanet').focus();

        return false;
    }

}

function closerashi(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 27) {
        for (var i = 0; i < document.getElementById('lstrashi').options.length; ++i) {
            document.getElementById('lstrashi').options[i].selected = false;

        }
        document.getElementById('divrashi').style.display = "none";
        document.getElementById('txtrashi').value = "";
        document.getElementById('txtrashi').focus();

        return false;
    }

}


function setButtonImages() {
    if (document.getElementById('btnNew').disabled == true)
        document.getElementById('btnNew').src = "Image/new-off.jpg";
    else
        document.getElementById('btnNew').src = "Image/new.jpg";

    if (document.getElementById('btnSave').disabled == true)
        document.getElementById('btnSave').src = "Image/save-off.jpg";
    else
        document.getElementById('btnSave').src = "Image/save.jpg";

    if (document.getElementById('btnModify').disabled == true)
        document.getElementById('btnModify').src = "Image/modify-off.jpg";
    else
        document.getElementById('btnModify').src = "Image/modify.jpg";

    if (document.getElementById('btnQuery').disabled == true)
        document.getElementById('btnQuery').src = "Image/query-off.jpg";
    else
        document.getElementById('btnQuery').src = "Image/query.jpg";

    if (document.getElementById('btnExecute').disabled == true)
        document.getElementById('btnExecute').src = "Image/execute-off.jpg";
    else
        document.getElementById('btnExecute').src = "Image/execute.jpg";

    if (document.getElementById('btnCancel').disabled == true)
        document.getElementById('btnCancel').src = "Image/clear-off.jpg";
    else
        document.getElementById('btnCancel').src = "Image/clear.jpg";

    if (document.getElementById('btnfirst').disabled == true)
        document.getElementById('btnfirst').src = "Image/first-off.jpg";
    else
        document.getElementById('btnfirst').src = "Image/first.jpg";

    if (document.getElementById('btnprevious').disabled == true)
        document.getElementById('btnprevious').src = "Image/previous-off.jpg";
    else
        document.getElementById('btnprevious').src = "Image/previous.jpg";

    if (document.getElementById('btnnext').disabled == true)
        document.getElementById('btnnext').src = "Image/next-off.jpg";
    else
        document.getElementById('btnnext').src = "Image/next.jpg";

    if (document.getElementById('btnlast').disabled == true)
        document.getElementById('btnlast').src = "Image/last-off.jpg";
    else
        document.getElementById('btnlast').src = "Image/last.jpg";

    if (document.getElementById('btnDelete').disabled == true)
        document.getElementById('btnDelete').src = "Image/delete-off.jpg";
    else
        document.getElementById('btnDelete').src = "Image/delete.jpg";

    if (document.getElementById('btnExit').disabled == true)
        document.getElementById('btnExit').src = "Image/exit-off.jpg";
    else
        document.getElementById('btnExit').src = "Image/exit.jpg";
}

function Exit() {
    if (confirm("Do You want to skip the page?")) {
        window.close();
        return false;
    }
}


function click_on_cancel() {

    Modify = 0;

    
    next = 0;
    $('btnNew').disabled = false;
    $('btnNew').focus();
    $('btnQuery').disabled = false;
    $('btnCancel').disabled = false;
    $('btnExit').disabled = false;
    $('btnSave').disabled = true;
    $('btnExecute').disabled = true;
    $('btnfirst').disabled = true;
    $('btnlast').disabled = true;
    $('btnModify').disabled = true;
    $('btnprevious').disabled = true;
    $('btnnext').disabled = true;
    $('btnDelete').disabled = true;

    setButtonImages();

    
    if ($('txtsigni').value != "") {
        $('txtsigni').value = "";
    }

    for (var i = 0; i < document.getElementById('lstplanet').options.length; ++i) {
        document.getElementById('lstplanet').options[i].selected = false;
    }
for (var i = 0; i < document.getElementById('lsthouse').options.length; ++i) {
      
            document.getElementById('lsthouse').options[i].selected = false;

       
        }
        for (var i = 0; i < document.getElementById('lstrashi').options.length; ++i) {
          
                document.getElementById('lstrashi').options[i].selected = false;

           
        }
    document.getElementById('hdsviewgrid').innerHTML = "";
    document.getElementById('Divgrid1').style.display = "none";
    document.getElementById('lstrashi').style.display = "none";
    document.getElementById('lsthouse').style.display = "none";
    document.getElementById('lstplanet').style.display = "none";
    document.getElementById('txtrashi').value = "";
    document.getElementById('txthouse').value = "";
    document.getElementById('txtplanet').value = "";
    setButtonImages();
    return false;
}


function disabledexecfld() {

    next = 0;
    exec_data = "";

    srt_count = 0;
    record_show1 = 1;

    document.getElementById("txtsigni").disabled = true;

    document.getElementById("btnNew").disabled = false;
    document.getElementById("btnSave").disabled = true;
    document.getElementById("btnModify").disabled = true;
    document.getElementById("btnQuery").disabled = false;
    document.getElementById("btnExecute").disabled = true;
    document.getElementById("btnCancel").disabled = false;
    document.getElementById("btnfirst").disabled = true;
    document.getElementById("btnprevious").disabled = true;
    document.getElementById("btnnext").disabled = true;
    document.getElementById("btnlast").disabled = true;
    document.getElementById("btnDelete").disabled = true;
    document.getElementById("btnExit").disabled = false;

    document.getElementById("txtsigni").value = ""
    
    modify = "false";

    delete_record = 0;

    setButtonImages();
    return false;
}

function EnableOnNew() {


    modifyduplicacyalias = "";
    modifyduplicacydesc = "";

    document.getElementById('btnNew').disabled = true;
    document.getElementById('btnQuery').disabled = true;
    document.getElementById('btnCancel').disabled = false;
    document.getElementById('btnExit').disabled = false;
    document.getElementById('btnSave').disabled = false;
    document.getElementById('btnExecute').disabled = true;
    document.getElementById('btnfirst').disabled = true;
    document.getElementById('btnlast').disabled = true;
    document.getElementById('btnModify').disabled = true;
    document.getElementById('btnprevious').disabled = true;
    document.getElementById('btnnext').disabled = true;
    document.getElementById('btnDelete').disabled = true;
    setButtonImages();

    document.getElementById('txtsigni').disabled = false;

    setButtonImages();




    /***************************************************************************************/

    return false;
}



function Save_Records() {
    var str = document.getElementById('tblfields').value;
    var str1 = str.split("$~$");
    var tablename = str1[str1.length - 2];

    var action = str1[str1.length - 1];
    var finalaction = action.split("#");
    var insert = finalaction[0];
    var update = finalaction[1];
    var del = finalaction[2];
    var select = finalaction[3];

    var casehouse = "";
    var caserashi = "";
    var caseplanet = "";

    var txtsignificators = document.getElementById('txtsigni').value;
    var casesignificators = txtsignificators;

    for (var i = 0; i < document.getElementById('lsthouse').options.length; ++i) {
        if (document.getElementById('lsthouse').options[i].selected == true) {
            casehouse = casehouse + document.getElementById('lsthouse').options[i].innerHTML + "+";
            
        }

    }
    if (casehouse != "") {
        casehouse = casehouse.slice(0, -1);

    }

    for (var i = 0; i < document.getElementById('lstrashi').options.length; ++i) {
        if (document.getElementById('lstrashi').options[i].selected == true) {
            caserashi = caserashi + document.getElementById('lstrashi').options[i].innerHTML + "+";
          
        }

    }
    if (caserashi != "") {
        caserashi = caserashi.slice(0, -1);

    }

    for (var i = 0; i < document.getElementById('lstplanet').options.length; ++i) {
        if (document.getElementById('lstplanet').options[i].selected == true) {
            caseplanet = caseplanet + document.getElementById('lstplanet').options[i].innerHTML + "+";

        }

    }
    if (caseplanet != "") {
        caseplanet = caseplanet.slice(0, -1);

    }
    
    
    
  
    if (caseplanet == "" && casehouse == "") {
    var signifies = caserashi;
    }

    else if (caserashi == "" && caseplanet == "") {
    var signifies = casehouse;
    }

    else if (caserashi == "" && casehouse == "") {
    var signifies = caseplanet;
    }

    else if (casehouse == "") {
    var signifies = caseplanet + "~" + caserashi;
    }
    else if (caseplanet == "") {
    var signifies = casehouse + "~" + caserashi;
    }

    else if (caserashi == "") {
    var signifies = casehouse + "~" + caseplanet;
    }
    else
    {
    var signifies = casehouse + "~" + caseplanet + "~" + caserashi;
    }
    
    if (Modify == 1) {
        ModifyClass();

        return false;
    }






    var tablevalue = casesignificators + "$~$" + signifies + "$~$";

    mod = tablevalue;
    var fi = document.getElementById('tblfields').value.replace("$~$" + tablename, "")
    fi = fi.replace("$~$" + action, "")
    var dateformate = document.getElementById('hiddendateformat').value



    var result = multiplesignificators.save(casesignificators, signifies)

    if (result.value.toUpperCase() == "TRUE") {
        alert("Data saved successfully");
        
       click_on_cancel();
       blankfields();

    }
    else {
        var exalert = result.value;
        var exalert1 = exalert.split("-");
        if (exalert1[0].indexOf("ORA") >= 0) {
            if (exalert1[1].indexOf("00001") >= 0) {
                alert("Data Not Saved.This combination already exists.Please enter another combination.")
                click_on_cancel();
                return false;


            }
        }

    }
    document.getElementById('btnNew').disabled = false;
    document.getElementById('btnNew').focus();
    setButtonImages();

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

function enablequery() {
    document.getElementById("btnNew").disabled = true;
    document.getElementById("btnSave").disabled = true;
    document.getElementById("btnModify").disabled = true;
    document.getElementById("btnQuery").disabled = true;
    document.getElementById("btnExecute").disabled = false;
    document.getElementById("btnCancel").disabled = false;
    document.getElementById("btnfirst").disabled = true;
    document.getElementById("btnprevious").disabled = true;
    document.getElementById("btnnext").disabled = true;
    document.getElementById("btnlast").disabled = true;
    document.getElementById("btnDelete").disabled = true;
    document.getElementById("btnExit").disabled = false;

    document.getElementById("txtsigni").disabled = false;
    document.getElementById("btnExecute").focus();

    delete_record = 0;

    setButtonImages();
    return false;

}

function executequery(querytype) {

    document.getElementById("btnDelete").disabled = false;
    var txtmultisigni = document.getElementById("txtsigni").value;
    multiplesignificators.executemultisigni(txtmultisigni, execute_callback);
    return false;
}

var dsgrid = "";
function execute_callback(val) {
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

        if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:520px;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='520px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"

       
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:100px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "SIGNIFICATORS" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:190px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "SIGNIFIES_BY" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:50px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "VERIFY" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:65px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "UPDATE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:65px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "DELETE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "VRF" + "</td>"
        buf2 += "</tr>"

        // document.getElementById( 'filter_').focus();
        len = 1;

        if (dsgrid.Tables[0].Rows.length == 0) {

        }

        if (dsgrid.Tables[0].Rows.length > 0) {

            for (i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {


                buf2 += "<tr>"

               

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:100px;' class='dropdown_large_corr'; align='left' value='" + dsgrid.Tables[0].Rows[i]['SIGNIFICATORS'] + "'  id='sign_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:190px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['SIGNIFIES_BY'] + "'  id='signby_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:50px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['CHECKED'] + "'  id='vrf_" + i + "'  >"
                buf2 += "</td>"
                
                buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:65px;' align='left' class='dropdown_large_corr'; Text='update' value='update' AutoPostBack='true' id='update_" + i + "' onClick='javascript:return update12(this.id);' >Update...</Button>"
                buf2 += "</td>"

                buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:65px;' align='left' class='dropdown_large_corr'; Text='delete' value='delete' AutoPostBack='true' id='delete_" + i + "' onClick='javascript:return delete1(this.id);' >Delete...</Button>"
                buf2 += "</td>"

                buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:30px;' align='left' class='dropdown_large_corr'; Text='chk' value='chk' AutoPostBack='true' id='chk_" + i + "' onClick='javascript:return check1(this.id);' >Chk...</Button>"
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

function update12(id) {
    var update = id.split('_')
    var update1 = update[1];
    var multisignificators = dsgrid.Tables[0].Rows[update1].SIGNIFICATORS
    var multisignificators1 = document.getElementById("sign_" + update1).value;
    var signifiesby = document.getElementById("signby_" + update1).value


    var res = multiplesignificators.update_multisignificators(multisignificators, multisignificators1, signifiesby);


    alert("Data updated Successfully")


    return false;
}



function delete1(id) {
    var delet = id.split('_')
    var delet1 = delet[1];
    var multisignificators = dsgrid.Tables[0].Rows[delet1].SIGNIFICATORS
    var signifiesby = document.getElementById("signby_" + delet1).value


    var res = multiplesignificators.delete_multisignificators(multisignificators, signifiesby);


    alert("Data deleted Successfully")


    return false;
}


function check1(id) {
    var chk = id.split('_')
    var chk1 = chk[1];
    var multisignificators = document.getElementById("sign_" + chk1).value
    var signifiesby = document.getElementById("signby_" + chk1).value


    var res = multiplesignificators.chk_multisignificators(multisignificators, signifiesby);
    document.getElementById("vrf_" + chk1).value = 'Chk'
    alert("Data Verified Successfully")


    return false;


}