var querytype = "";
var val = "";
var exec_data = "";
var next = 0;
var execute = "";
var Modify = 0;
var extentions = "";
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

    document.getElementById('txtextentions').disabled = false;
    
    setButtonImages();




    /***************************************************************************************/

    return false;
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

    dsexe = "";
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

    $('txtextentions').disabled = true;


    if ($('txtextentions').value != "") {
        $('txtextentions').value = "";
    }
    
    setButtonImages();
    return false;
}


function disabledexecfld() {

    next = 0;
    exec_data = "";

    srt_count = 0;
    record_show1 = 1;

    document.getElementById("txtextentions").disabled = true;
    
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

    document.getElementById("txtextentions").value = ""
   
    modify = "false";

    delete_record = 0;

    setButtonImages();
    return false;
}

var mod = "";
function Save_Records() 
{
    var str = document.getElementById('tblfields').value;
    var str1 = str.split("$~$");
    var tablename = str1[str1.length - 2];

    var action = str1[str1.length - 1];
    var finalaction = action.split("#");
    var insert = finalaction[0];
    var update = finalaction[1];
    var del = finalaction[2];
    var select = finalaction[3];



    var txtextentions = "'" + (document.getElementById('txtextentions').value) + "'";
    var caseextentions = txtextentions;




    if (Modify == 1) 
    {
        ModifyClass();

        return false;
    }

    caseextentions = caseextentions.replace("'", "");
    caseextentions = caseextentions.replace("'", "");





    var tablevalue = caseextentions+ "$~$";

    mod = tablevalue;
    var fi = document.getElementById('tblfields').value.replace("$~$" + tablename, "")
    fi = fi.replace("$~$" + action, "")
    var dateformate = document.getElementById('hiddendateformat').value



    var result = astroextentions.save(caseextentions)

    if (result.value.toUpperCase() == "TRUE") 
    {
        alert("Data saved successfully");
        click_on_cancel();
        blankfields();

    }
    else 
    {
        var exalert = result.value;
        var exalert1 = exalert.split("-");
        if (exalert1[0].indexOf("ORA") >= 0)
         {
            if (exalert1[1].indexOf("00001") >= 0) 
            {
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

    document.getElementById('txtextentions').disabled = true;
   

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









    var txtextentions =  (document.getElementById('txtextentions').value) ;
    var casetxtextentions = txtextentions;









    var hiddenmodtxtextentions = document.getElementById("hiddenmodtxtextentions").value;



    astroextentions.Modifydata1(casetxtextentions, hiddenmodtxtextentions )


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

    document.getElementById("txtextentions").disabled = false;


    document.getElementById('txtextentions').style.display = 'block';
  

    document.getElementById("btnExecute").focus();

    delete_record = 0;

    setButtonImages();
    return false;

}




function executequery(querytype) {

    document.getElementById("btnDelete").disabled = false;
    var txtextentions = "";


    var txtextentions = "'" + document.getElementById("txtextentions").value + "'"
    document.getElementById("Hiddentxtextentions").value = document.getElementById("txtextentions").value;
   

    var userid = "'" + document.getElementById("hdnuserid").value + "'"
    var userid = "''";
    document.getElementById("btnExecute").disabled = true;
    document.getElementById("btnfirst").disabled = false;

    var fieldsvalue = txtextentions + "$~$"

    var SPLITVALUE = document.getElementById('fields').value.split("$~$")
    var fields = document.getElementById('fields').value.replace("$~$" + SPLITVALUE[SPLITVALUE.length - 2], "").replace("$~$" + SPLITVALUE[SPLITVALUE.length - 1], "")

    exectefuncol = fields;
    exectefunvalue = fieldsvalue;
    exectefuntab = SPLITVALUE[SPLITVALUE.length - 2];
    old_exec_value = fieldsvalue;
    fields = fields + "$~$"

    astroextentions.execute11(SPLITVALUE[SPLITVALUE.length - 2], fields, fieldsvalue, "select", $('hiddendateformat').value, "", "", execute_callback);
    return false;
}

function execute_callback(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
    exec_data = val.value;
    var ds = exec_data;
    if (exec_data == null) {
        alert("There is no data available regarding your query.")
        return false;
    }

    if (exec_data != null) {
        total_records = exec_data.Tables[0].Rows.length;
    }
    else {
        total_records = "0";
    }

    if (delete_record == 1) {

        var length_del = exec_data.Tables[0].Rows.length;

        var a = length_del - 1;
        if (length_del <= 0) {

            alert("There is no data available regarding your query.")
            disabledexecfld();
            return false;

        }
        else if (next == -1 || next >= length_del) {
            next = 0;
        }
        else {
            next = next;
        }

    }

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

        if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:300px;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='200px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:200px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "EXTENTIONS" + "</td>"
        buf2 += "</tr>"


        len = 1;


        if (ds.Tables[0].Rows.length > 0) {
            for (i = 0; i < ds.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:180px;' align='left' value='" + ds.Tables[0].Rows[i]['EXTENTIONS'] + "'  id='ext_" + i + "'  >"
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
    




    if (exec_data.Tables[0].Rows.length > 0) {

        document.getElementById("txtextentions").value = (exec_data.Tables[0].Rows[next].EXTENTIONS);
        if (document.getElementById("txtextentions").value == "null") {
            document.getElementById("txtextentions").value = "";

        }

        else {
            document.getElementById("txtextentions").value = (exec_data.Tables[0].Rows[next].EXTENTIONS);
            document.getElementById("hiddenmodtxtextentions").value = (exec_data.Tables[0].Rows[next].EXTENTIONS)
        }


        old_execute_code = exec_data.Tables[0].Rows[next].EXTENTIONS;
        
        document.getElementById("btnModify").disabled = false;
        document.getElementById("txtextentions").disabled = true;
       

        $('btnfirst').disabled = true;
        $('btnlast').disabled = false;
        $('btnprevious').disabled = true;
        $('btnnext').disabled = false;

        setButtonImages();
    }
    else {
        alert("There is no data available regarding your query.")

        $('btnfirst').disabled = true;
        $('btnlast').disabled = true;
        $('btnprevious').disabled = true;
        $('btnnext').disabled = true;

        setButtonImages();

        return false;
    }

}



function delete_data() {
    var txtextentions = "'" + document.getElementById("txtextentions").value + "'"
    

    if (confirm("Are you sure! Do you want to delete this entry?")) {
        var fieldsvalue = txtextentions + "$~$" ;
        var SPLITVALUE = document.getElementById('fields').value.split("$~$")
        var fields1 = "EXTENTIONS" + "$~$"
        var tablename = "EXTENTIONS";

        var extra1 = "''";
        var extra2 = "''";

        var res = astroextentions.agency_delete1(tablename, fields1, fieldsvalue, document.getElementById('hiddendateformat').value, extra1, extra2)

        document.getElementById("btnSave").disabled = true;
        document.getElementById("btnDelete").disabled = true;

        if (res.value == "true") {
            delete_record = 1;
            alert("Data Delete Successfully")
            disabledexecfld();
            return false;
        }
        else {
            alert(res.value);
            return false;
        }
    }
    else {
        $('btnDelete').focus();
        return false;
    }
}



function chk_button(a) {
    if (exec_data.Tables[0].Rows.length == 1 || exec_data.Tables[0].Rows.length == 0) {
        document.getElementById("btnlast").disabled = true;
        document.getElementById("btnnext").disabled = true;
        document.getElementById("btnfirst").disabled = true;
        document.getElementById("btnprevious").disabled = true;
        setButtonImages();
    }
    else if (next == "0") {
        document.getElementById("btnlast").disabled = false;
        document.getElementById("btnnext").disabled = false;
        document.getElementById("btnfirst").disabled = true;
        document.getElementById("btnprevious").disabled = true;
        setButtonImages();
        return false;
    }

    else if (next == exec_data.Tables[0].Rows.length - 1) {
        document.getElementById("btnlast").disabled = true;
        document.getElementById("btnnext").disabled = true;
        document.getElementById("btnfirst").disabled = false;
        document.getElementById("btnprevious").disabled = false;
        setButtonImages();
        return false;
    }

    else {
        document.getElementById("btnlast").disabled = false;
        document.getElementById("btnnext").disabled = false;
        document.getElementById("btnfirst").disabled = false;
        document.getElementById("btnprevious").disabled = false;
        setButtonImages();
        return false;
    }

}

function fnd_first_record() {
    delete_record = 0;
    record_show = 5
    record_show1 = 1
    var gg = 0;
    next = "0";
    chk_button(next)

    old_execute_extentions = exec_data.Tables[0].Rows[next].EXTENTIONS;




  

    if (document.getElementById("txtextentions").value == "null") {
        document.getElementById("txtextentions").value = "";
    }
    else {
        document.getElementById("txtextentions").value = (exec_data.Tables[0].Rows[next].EXTENTIONS);
    }

    
    return false;
}



function fnd_next_record() {
    delete_record = 0;
    record_show = 8
    record_show1 = 1
    next = parseInt(next) + 1;
    chk_button(next)
    var gg1 = 0;

    old_execute_extentions = exec_data.Tables[0].Rows[next].EXTENTIONS;




    if (document.getElementById("txtextentions").value == "null") {
        document.getElementById("txtextentions").value = "";
    }
    else {
        document.getElementById("txtextentions").value = (exec_data.Tables[0].Rows[next].EXTENTIONS);
    }

    



    if (next == total_records - 1) {

        $('btnprevious').focus();
        setButtonImages();
    }

    return false;
}


function fnd_pre_record() {
    delete_record = 0;
    record_show = 5
    record_show1 = 1
    next = parseInt(next) - 1;
    chk_button(next)
    var gg2 = 0;

    old_execute_extentions = exec_data.Tables[0].Rows[next].EXTENTIONS;






    if (document.getElementById("txtextentions").value == "null") {
        document.getElementById("txtextentions").value = "";
    }
    else {
        document.getElementById("txtextentions").value = (exec_data.Tables[0].Rows[next].EXTENTIONS);
    }
    
   
    if (next == 0) {

        $('btnnext').focus();
        setButtonImages();
    }



    return false;


}
function fnd_last_record() {
    delete_record = 0;
    record_show = 5
    record_show1 = 1

    next = exec_data.Tables[0].Rows.length - 1;
    chk_button(next)
    var gg3 = 0;


    old_execute_extentions = exec_data.Tables[0].Rows[next].EXTENTIONS;




    if (document.getElementById("txtextentions").value == "null") {
        document.getElementById("txtextentions").value = "";
    }
    else {
        document.getElementById("txtextentions").value = (exec_data.Tables[0].Rows[next].EXTENTIONS);
    }
  
    return false;
}

///**************************************************************************************************
function repalcesinglequote(val) {
    if (val.indexOf("'") >= 0) {
        while (val.indexOf("'") >= 0) {
            val = val.replace("'", "^");
        }
    }
    return val;
}


function repalcestr2quote(val) {
    if (val.indexOf("^") >= 0) {
        while (val.indexOf("^") >= 0) {
            val = val.replace("^", "'");
        }
    }
    return val;
}

