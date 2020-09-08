var querytype = "";
var val = "";
var horarysigni = "";

//var Drphouse="";
//var Drprashi="";
//var  Drpplanet="";
var Houseposition = "";
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
function StringBuffer3() {
    this.buffer = [];
}

StringBuffer3.prototype.append = function append(string) {
    this.buffer.push(string);
    return this;
};
function ShowPreview() {
    var ht = "";
    var wt = "";
    var jobid = document.getElementById('hiddenjobid').value;

    for (var t1 = 0; t1 < document.getElementById('ListBox1').options.length; t1++) {
        if (document.getElementById("ListBox1").options[t1].selected == true) {


            var fname = document.getElementById("ListBox1").options[t1].innerText;


            window.open('preview.aspx?jobid=' + jobid + '&f_name=' + fname, 'Preview', 'status=0,toolbar=0,resizable=0,scrollbars=yes,modal=yes,top=0,left=0,width=800px,height=1000px');

            return false;

        }
    }
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
    document.getElementById('plant').disabled = false;
    document.getElementById('hous').disabled = false;
    document.getElementById('karka').disabled = false;
    document.getElementById('rash').disabled = false;
    document.getElementById('planet').disabled = false;
    document.getElementById('texthouse').disabled = false;
    document.getElementById('ext').disabled = false;
    document.getElementById('rashi').disabled = false;
    document.getElementById('Textcode').disabled = false;
    document.getElementById('Textname').disabled = false;
    document.getElementById('book').disabled = false;
    document.getElementById('page0').disabled = false;
    document.getElementById('detail').disabled = false;
    setButtonImages();

    document.getElementById("hous").value = ""
    document.getElementById("karka").value = ""
    document.getElementById("rash").value = ""
    document.getElementById("plant").value = ""

    document.getElementById("texthouse").value = ""
    document.getElementById("ext").value = ""
    document.getElementById("rashi").value = ""
    document.getElementById("planet").value = ""
    document.getElementById("Textcode").value = ""
    document.getElementById("Textname").value = ""
    document.getElementById("book").value = ""
    document.getElementById("page0").value = ""
    document.getElementById("detail").value = "";


    /***************************************************************************************/

    return false;
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
    $('plant').disabled = true;
    $('rash').disabled = true;
    $('karka').disabled = true;
    $('hous').disabled = true;
    $('Textcode').disabled = true;
    $('planet').disabled = true;
    $('rashi').disabled = true;
    $('Textname').disabled = true;
    $('texthouse').disabled = true;
    $('ext').disabled = true;
    $('book').disabled = true;
    $('page0').disabled = true;
    $('detail').disabled = true;


    if ($('Textcode').value != "") {
        $('Textcode').value = "";
        return false;
    }

    document.getElementById('hdsviewgrid').innerHTML = "";
    document.getElementById('Divgrid1').style.display = "none";
    document.getElementById('hdsviewgrid2').innerHTML = "";
    document.getElementById('Divgrid2').style.display = "none";
    //    if ($('Divgrid1').value != "")
    //     {
    //         $('Divgrid1').value = "";
    //    }
    if ($('book').value != "") {
        $('book').value = "";

    }
    if ($('page0').value != "") {
        $('page0').value = "";

    }
    if ($('Textname').value != "") {
        $('Textname').value = "";

    }

    if ($('karka').value != "") {
        $('karka').value = "";

    }
    //alert($('texthouse').value)

    if ($('texthouse').value != "") {
        $('texthouse').value = "0";

    }

    if ($('hous').value != "") {
        $('hous').value = "0";

    }
    if ($('plant').value != "") {
        $('plant').value = "0";

    }
    if ($('rash').value != "") {
        $('rash').value = "0";

    }

    if ($('ext').value != "") {
        $('ext').value = "0";

    }


    if ($('rashi').value != "") {
        $('rashi').value = "0";

    }

    if ($('planet').value != "") {
        $('planet').value = "0";

    }


    if ($('detail').value != "") {
        $('detail').value = "";

    }

    document.getElementById("hous").value = ""
    document.getElementById("karka").value = ""
    document.getElementById("rash").value = ""
    document.getElementById("plant").value = ""

    document.getElementById("texthouse").value = ""
    document.getElementById("ext").value = ""
    document.getElementById("rashi").value = ""
    document.getElementById("planet").value = ""
    document.getElementById("Textcode").value = ""
    document.getElementById("Textname").value = ""
    document.getElementById("book").value = ""
    document.getElementById("page0").value = ""
    document.getElementById("detail").value = "";

    document.getElementById('hous').style.display = "none";
    document.getElementById('karka').style.display = "none";
    document.getElementById('rash').style.display = "none";
    document.getElementById('plant').style.display = "none";
    document.getElementById('inserts').style.display = "none";
    document.getElementById('Label7').style.display = "none";
    setButtonImages();
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

    document.getElementById("planet").disabled = false;
    document.getElementById("texthouse").disabled = false;
    document.getElementById("ext").disabled = false;
    document.getElementById("rashi").disabled = false;
    document.getElementById("Textcode").disabled = false;
    document.getElementById("Textname").disabled = false;
    document.getElementById("book").disabled = false;
    document.getElementById("page0").disabled = false;
    document.getElementById("detail").disabled = false;

    document.getElementById('texthouse').style.display = 'block';
    document.getElementById('ext').style.display = 'block';
    document.getElementById('rashi').style.display = 'block';
    document.getElementById('planet').style.display = 'block';
    document.getElementById('Textcode').style.display = 'block';
    document.getElementById('Textname').style.display = 'block';
    document.getElementById('detail').style.display = 'block';

    document.getElementById("btnExecute").focus();

    delete_record = 0;

    setButtonImages();
    return false;

}




function executequery(querytype) {
    document.getElementById("btnDelete").disabled = false;
    var house = "";
    var comp_code = "";
    var book = "";
    var page0 = "";
    var textname = "";
    var dedsec = "";
    var planet = "";
    var rashi = "";
    var ext = "";

    if (document.getElementById("texthouse").value != 0) {
        house = "'" + repalcesinglequote(document.getElementById("texthouse").value) + "'"
        document.getElementById("Hiddenhouse").value = document.getElementById("texthouse").value;
    }
    else {
        document.getElementById("Hiddenhouse").value = house;
        house = "'" + house + "'"

    }


    if (document.getElementById("ext").value != 0) {
        ext = "'" + repalcesinglequote(document.getElementById("ext").value) + "'"
        document.getElementById("Hiddenext").value = document.getElementById("ext").value;
    }
    else {
        document.getElementById("Hiddenext").value = ext;
        ext = "'" + ext + "'"

    }




    if (document.getElementById("rashi").value != 0) {
        rashi = "'" + repalcesinglequote(document.getElementById("rashi").value) + "'"
        document.getElementById("Hiddenrashi").value = document.getElementById("rashi").value;
    }
    else {
        document.getElementById("Hiddenrashi").value = rashi;
        rashi = "'" + rashi + "'"

    }



    if (document.getElementById("planet").value != 0) {
        planet = "'" + repalcesinglequote(document.getElementById("planet").value) + "'"
        document.getElementById("Hiddenplanet").value = document.getElementById("planet").value;
    }
    else {
        document.getElementById("Hiddenplanet").value = planet;
        planet = "'" + planet + "'"

    }

    var comp_code = "'" + document.getElementById("Textcode").value + "'"
    document.getElementById("Hiddencompcode").value = document.getElementById("Textcode").value;
    var book = "'" + document.getElementById("book").value + "'"
    document.getElementById("Hiddenbook").value = document.getElementById("book").value;
    var page0 = "'" + document.getElementById("page0").value + "'"
    document.getElementById("Hiddenpage").value = document.getElementById("page0").value;
    var textname = "'" + repalcesinglequote(document.getElementById("Textname").value) + "'"
    document.getElementById("Hiddendesc").value = document.getElementById("Textname").value;
    var dedsec = "'" + repalcesinglequote(document.getElementById("detail").value) + "'"
    document.getElementById("Hiddendetail").value = document.getElementById("detail").value;
    var detaildesc = "'" + "'";

    var userid = "'" + document.getElementById("hdnuserid").value + "'"
    var userid = "''";
    document.getElementById("btnExecute").disabled = true;
    document.getElementById("btnfirst").disabled = false;

    var fieldsvalue = comp_code + "$~$" + textname + "$~$" + detaildesc + "$~$" + book + "$~$" + page0 + "$~$" + house + "$~$" + planet + "$~$" + rashi + "$~$" + ext + "$~$"

    var SPLITVALUE = document.getElementById('fields').value.split("$~$")
    var fields = document.getElementById('fields').value.replace("$~$" + SPLITVALUE[SPLITVALUE.length - 2], "").replace("$~$" + SPLITVALUE[SPLITVALUE.length - 1], "")

    exectefuncol = fields;
    exectefunvalue = fieldsvalue;
    exectefuntab = SPLITVALUE[SPLITVALUE.length - 2];
    old_exec_value = fieldsvalue;
    fields = fields + "$~$"

    var orderby
    var viewcolname = "KEY_STRINGS"
    orderby = "ASC";
    viewcolname = viewcolname + " " + orderby;


    encyclopaedia.execute1(SPLITVALUE[SPLITVALUE.length - 2], fields, fieldsvalue, "select", $('hdndateformat').value, viewcolname, "", execute_callback);
    return false;
}
var dsexec = "";
function execute_callback(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
    exec_data = val.value;
    dsexec = exec_data;
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

        document.getElementById("Textcode").value = (exec_data.Tables[0].Rows[next].CODE);
        if (document.getElementById("Textcode").value == "null") {
            document.getElementById("Textcode").value = "";

        }

        else {
            document.getElementById("Textcode").value = (exec_data.Tables[0].Rows[next].CODE);
        }








        document.getElementById("Textname").value = (exec_data.Tables[0].Rows[next].KEY_STRINGS);

        if (document.getElementById("Textname").value == "null") {
            document.getElementById("Textname").value = "";
        }
        else {
            document.getElementById("Textname").value = (exec_data.Tables[0].Rows[next].KEY_STRINGS);
        }

        document.getElementById("texthouse").value = (exec_data.Tables[0].Rows[next].HOUSE);
        document.getElementById("ext").value = (exec_data.Tables[0].Rows[next].EXTENTIONS);
        document.getElementById("rashi").value = (exec_data.Tables[0].Rows[next].RASHI);
        document.getElementById("planet").value = (exec_data.Tables[0].Rows[next].PLANET);

        document.getElementById("book").value = (exec_data.Tables[0].Rows[next].BOOK);

        if (document.getElementById("book").value == "null") {
            document.getElementById("book").value = "";
        }
        else {
            document.getElementById("book").value = (exec_data.Tables[0].Rows[next].BOOK);
        }
        document.getElementById("page0").value = (exec_data.Tables[0].Rows[next].PAGE_NO);

        if (document.getElementById("page0").value == "null") {
            document.getElementById("page0").value = "";
        }
        else {
            document.getElementById("page0").value = (exec_data.Tables[0].Rows[next].PAGE_NO);
        }
        //         if(document.getElementById('Hidden5').value!="")
        //       {

        //       if(document.getElementById('Hidden4').value=="1")
        //       {
        //      var categery= document.getElementById('Hidden5').value.split("$");
        //              for(var m=0;m<categery.length-1;m++)
        //              {
        //              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
        //              {
        //              gg4++;
        //              }
        //              }
        //      
        //       }
        //       else
        //       {
        //       
        //              var categery= document.getElementById('Hidden5').value.split("$");
        //              for(var m=0;m<categery.length-1;m++)
        //              {
        //              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
        //              {
        //              gg4++;
        //              }
        //              }
        //       
        //       }
        //       
        //       if(document.getElementById('Hidden4').value=="1")
        //       {
        //       if(gg4==categery.length)
        //       {
        //        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
        //       }
        //       else
        //       {
        //       alert("No Match Found");
        //         $('btnfirst').disabled = true;
        //	$('btnlast').disabled = false;
        //	$('btnprevious').disabled = true;
        //	$('btnnext').disabled = false;
        //       return false;
        //       
        //       }
        //       }
        //       else
        //       {
        //       if(gg4>0)
        //        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
        //        else
        //        {
        //       alert("No Match Found");
        //       return false;
        //        }
        //       }
        //       
        //       }
        //       else
        //       {
        //        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
        //       
        //       }
        //       
        document.getElementById("detail").value = (exec_data.Tables[0].Rows[next].DESCCLOB);

        if (document.getElementById("detail").value == "null") {
            document.getElementById("detail").value = "";
        }
        else {
            document.getElementById("detail").value = (exec_data.Tables[0].Rows[next].DESCCLOB);
        }

        old_execute_code = exec_data.Tables[0].Rows[next].CODE;
        old_execute_name = exec_data.Tables[0].Rows[next].KEY_STRINGS;
        old_execute_book = exec_data.Tables[0].Rows[next].BOOK;
        old_execute_page0 = exec_data.Tables[0].Rows[next].PAGE_NO;
        old_execute_dedesc = exec_data.Tables[0].Rows[next].DESCCLOB;
        old_execute_house = exec_data.Tables[0].Rows[next].HOUSE;
        old_execute_rashi = exec_data.Tables[0].Rows[next].RASHI;
        old_execute_ext = exec_data.Tables[0].Rows[next].EXTENTIONS;
        old_execute_planet = exec_data.Tables[0].Rows[next].PLANET;

        document.getElementById("btnModify").disabled = false;
        document.getElementById("texthouse").disabled = true;
        document.getElementById("ext").disabled = true;
        document.getElementById("rashi").disabled = true;
        document.getElementById("planet").disabled = true;
        document.getElementById("Textcode").disabled = true;
        document.getElementById("Textname").disabled = true;
        document.getElementById("book").disabled = true;
        document.getElementById("page0").disabled = true;
        document.getElementById("detail").disabled = true;

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


function disabledexecfld() {

    next = 0;
    exec_data = "";

    srt_count = 0;
    record_show1 = 1;

    document.getElementById("texthouse").disabled = true;
    document.getElementById("ext").disabled = true;
    document.getElementById("rashi").disabled = true;
    document.getElementById("planet").disabled = true;
    document.getElementById("Textcode").disabled = true;
    document.getElementById("Textname").disabled = true;
    document.getElementById("book").disabled = true;
    document.getElementById("page0").disabled = true;
    document.getElementById("detail").disabled = true;

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

    document.getElementById("texthouse").value = ""
    document.getElementById("ext").value = ""
    document.getElementById("rashi").value = ""
    document.getElementById("planet").value = ""
    document.getElementById("Textcode").value = ""
    document.getElementById("Textname").value = ""
    document.getElementById("book").value = ""
    document.getElementById("page0").value = ""
    document.getElementById("detail").value = "";
    modify = "false";

    delete_record = 0;

    setButtonImages();
    return false;
}

function repalcesinglequote(val) {
    if (val.indexOf("'") >= 0) {
        while (val.indexOf("'") >= 0) {
            val = val.replace("'", "^");
        }
    }
    return val;
}

function delete_data() {
    var comp_code = "'" + document.getElementById("Textcode").value + "'"
    var textname = "'" + (document.getElementById("Textname").value) + "'"

    if (confirm("Are you sure! Do you want to delete this entry?")) {
        var fieldsvalue = comp_code + "$~$" + textname;
        var SPLITVALUE = document.getElementById('fields').value.split("$~$")
        var fields1 = "CODE" + "$~$" + "KEY_STRINGS"

        var tablename = "ENCYCLOPAEDIA";

        var extra1 = "''";
        var extra2 = "''";

        var res = encyclopaedia.agency_delete1(tablename, fields1, fieldsvalue, document.getElementById('hdndateformat').value, extra1, extra2)

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

    old_execute_house = exec_data.Tables[0].Rows[next].HOUSE;
    old_execute_ext = exec_data.Tables[0].Rows[next].EXTENTIONS;
    old_execute_rashi = exec_data.Tables[0].Rows[next].RASHI;
    old_execute_planet = exec_data.Tables[0].Rows[next].PLANET;
    old_execute_code = exec_data.Tables[0].Rows[next].CODE;
    old_execute_name = exec_data.Tables[0].Rows[next].KEY_STRINGS;
    old_execute_book = exec_data.Tables[0].Rows[next].BOOK;
    old_execute_page0 = exec_data.Tables[0].Rows[next].PAGE_NO;

    old_execute_dedesc = exec_data.Tables[0].Rows[next].DESCCLOB;

    document.getElementById("Textcode").value = (exec_data.Tables[0].Rows[next].CODE);
    document.getElementById("Textname").value = (exec_data.Tables[0].Rows[next].KEY_STRINGS);

    if (document.getElementById("Textname").value == "null") {
        document.getElementById("Textname").value = "";
    }
    else {
        document.getElementById("Textname").value = (exec_data.Tables[0].Rows[next].KEY_STRINGS);
    }

    document.getElementById("book").value = (exec_data.Tables[0].Rows[next].BOOK);

    if (document.getElementById("book").value == "null") {
        document.getElementById("book").value = "";
    }
    else {
        document.getElementById("book").value = (exec_data.Tables[0].Rows[next].BOOK);
    }

    document.getElementById("page0").value = (exec_data.Tables[0].Rows[next].PAGE_NO);

    if (document.getElementById("page0").value == "null") {
        document.getElementById("page0").value = "";
    }
    else {
        document.getElementById("page0").value = (exec_data.Tables[0].Rows[next].PAGE_NO);
    }

    //           if(document.getElementById('Hidden5').value!="")
    //       {
    //       
    //       
    //       
    //       if(document.getElementById('Hidden4').value=="1")
    //       {
    //      var categery= document.getElementById('Hidden5').value.split("$");
    //              for(var m=0;m<categery.length-1;m++)
    //              {
    //              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
    //              {
    //              gg0++;
    //              }
    //              }
    //      
    //       }
    //       else
    //       {
    //       
    //              var categery= document.getElementById('Hidden5').value.split("$");
    //              for(var m=0;m<categery.length-1;m++)
    //              {
    //              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
    //              {
    //              gg0++;
    //              }
    //              }
    //       
    //       }
    //       
    //       if(document.getElementById('Hidden4').value=="1")
    //       {
    //       if(gg0==categery.length)
    //       {
    //        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
    //       }
    //       else
    //       {
    //       alert("No Match Found");
    //       return false;
    //       
    //       }
    //       }
    //       else
    //       {
    //       if(gg0>0)
    //        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
    //        else
    //        {
    //       alert("No Match Found");
    //       return false;
    //        }
    //       }
    //       
    //       }
    //       else
    //       {
    //        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
    //       
    //       }
    document.getElementById("detail").value = (exec_data.Tables[0].Rows[next].DESCCLOB);


    if (document.getElementById("detail").value == "null") {
        document.getElementById("detail").value = "";
    }
    else {
        document.getElementById("detail").value = (exec_data.Tables[0].Rows[next].DESCCLOB);
    }
    document.getElementById("texthouse").value = (exec_data.Tables[0].Rows[next].HOUSE);
    document.getElementById("ext").value = (exec_data.Tables[0].Rows[next].EXTENTIONS);
    document.getElementById("rashi").value = (exec_data.Tables[0].Rows[next].RASHI);
    document.getElementById("planet").value = (exec_data.Tables[0].Rows[next].PLANET);




    return false;
}

function fnd_next_record() {
    delete_record = 0;
    record_show = 8
    record_show1 = 1
    next = parseInt(next) + 1;
    chk_button(next)
    var gg1 = 0;

    old_execute_house = exec_data.Tables[0].Rows[next].HOUSE;


    old_execute_ext = exec_data.Tables[0].Rows[next].EXTENTIONS;
    old_execute_planet = exec_data.Tables[0].Rows[next].PLANET;
    old_execute_rashi = exec_data.Tables[0].Rows[next].RASHI;
    old_execute_code = exec_data.Tables[0].Rows[next].CODE;
    old_execute_name = exec_data.Tables[0].Rows[next].KEY_STRINGS;
    old_execute_book = exec_data.Tables[0].Rows[next].BOOK;
    old_execute_page0 = exec_data.Tables[0].Rows[next].PAGE_NO;
    old_execute_dedesc = exec_data.Tables[0].Rows[next].DESCCLOB;



    if (exec_data.Tables[0].Rows[next].HOUSE == null) {

        document.getElementById("texthouse").value = "0";
    }
    else {
        document.getElementById("texthouse").value = (exec_data.Tables[0].Rows[next].HOUSE);
    }


    if (document.getElementById("ext").value == null) {


        document.getElementById("ext").value = "";
    }
    else {
        document.getElementById("ext").value = (exec_data.Tables[0].Rows[next].EXTENTIONS);
    }



    if (exec_data.Tables[0].Rows[next].RASHI == null) {
        document.getElementById("rashi").value = "0";
    }
    else {
        document.getElementById("rashi").value = (exec_data.Tables[0].Rows[next].RASHI);
    }


    if (exec_data.Tables[0].Rows[next].PLANET == null) {


        document.getElementById("planet").value = "0";
    }
    else {
        document.getElementById("planet").value = (exec_data.Tables[0].Rows[next].PLANET);
    }

    if (document.getElementById("Textcode").value == null) {


        document.getElementById("Textcode").value = "0";
    }
    else {

        document.getElementById("Textcode").value = (exec_data.Tables[0].Rows[next].CODE);
    }

    if (document.getElementById("Textname").value == "null") {


        document.getElementById("Textname").value = "";
    }
    else {
        document.getElementById("Textname").value = (exec_data.Tables[0].Rows[next].KEY_STRINGS);
    }


    document.getElementById("book").value = (exec_data.Tables[0].Rows[next].BOOK);

    if (document.getElementById("book").value == "null") {
        document.getElementById("book").value = "";
    }
    else {
        document.getElementById("book").value = (exec_data.Tables[0].Rows[next].BOOK);
    }
    document.getElementById("page0").value = (exec_data.Tables[0].Rows[next].PAGE_NO);

    if (document.getElementById("page0").value == "null") {
        document.getElementById("page0").value = "";
    }
    else {
        document.getElementById("page0").value = (exec_data.Tables[0].Rows[next].PAGE_NO);
    }

    //       
    //            if(document.getElementById('Hidden5').value!="")
    //       {
    //       
    //       
    //       
    //       if(document.getElementById('Hidden4').value=="1")
    //       {
    //      var categery= document.getElementById('Hidden5').value.split("$");
    //              for(var m=0;m<categery.length-1;m++)
    //              {
    //              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
    //              {
    //              gg1++;
    //              }
    //              }
    //      
    //       }
    //       else
    //       {
    //       
    //              var categery= document.getElementById('Hidden5').value.split("$");
    //              for(var m=0;m<categery.length-1;m++)
    //              {
    //              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
    //              {
    //              gg1++;
    //              }
    //              }
    //       
    //       }
    //       
    //       if(document.getElementById('Hidden4').value=="1")
    //       {
    //       if(gg1==categery.length)
    //       {
    //        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
    //       }
    //       else
    //       {
    //       alert("No Match Found");
    //       return false;
    //       
    //       }
    //       }
    //       else
    //       {
    //       if(gg1>0)
    //        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
    //        else
    //        {
    //       alert("No Match Found");
    //       return false;
    //        }
    //       }
    //       
    //       }
    //       else
    //       {
    //        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
    //       
    //       }    
    //       

    document.getElementById("detail").value = (exec_data.Tables[0].Rows[next].DESCCLOB);

    if (document.getElementById("detail").value == "null") {
        document.getElementById("detail").value = "";
    }
    else {
        document.getElementById("detail").value = (exec_data.Tables[0].Rows[next].DESCCLOB);
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

    old_execute_house = exec_data.Tables[0].Rows[next].HOUSE;
    old_execute_ext = exec_data.Tables[0].Rows[next].EXTENTIONS;
    old_execute_rashi = exec_data.Tables[0].Rows[next].RASHI;
    old_execute_planet = exec_data.Tables[0].Rows[next].PLANET;
    old_execute_code = exec_data.Tables[0].Rows[next].CODE;
    old_execute_name = exec_data.Tables[0].Rows[next].KEY_STRINGS;

    old_execute_book = exec_data.Tables[0].Rows[next].BOOK;
    old_execute_page0 = exec_data.Tables[0].Rows[next].PAGE_NO;
    old_execute_dedesc = exec_data.Tables[0].Rows[next].DESCCLOB;

    document.getElementById("texthouse").value = (exec_data.Tables[0].Rows[next].HOUSE);
    document.getElementById("ext").value = (exec_data.Tables[0].Rows[next].EXTENTIONS);
    document.getElementById("rashi").value = (exec_data.Tables[0].Rows[next].RASHI);
    document.getElementById("planet").value = (exec_data.Tables[0].Rows[next].PLANET);
    document.getElementById("Textcode").value = (exec_data.Tables[0].Rows[next].CODE);
    document.getElementById("Textname").value = (exec_data.Tables[0].Rows[next].KEY_STRINGS);

    if (document.getElementById("Textname").value == "null") {
        document.getElementById("Textname").value = "";
    }
    else {
        document.getElementById("Textname").value = (exec_data.Tables[0].Rows[next].KEY_STRINGS);
    }
    document.getElementById("book").value = (exec_data.Tables[0].Rows[next].BOOK);

    if (document.getElementById("book").value == "null") {
        document.getElementById("book").value = "";
    }
    else {
        document.getElementById("book").value = (exec_data.Tables[0].Rows[next].BOOK);
    }
    document.getElementById("page0").value = (exec_data.Tables[0].Rows[next].PAGE_NO);

    if (document.getElementById("page0").value == "null") {
        document.getElementById("page0").value = "";
    }
    else {
        document.getElementById("page0").value = (exec_data.Tables[0].Rows[next].PAGE_NO);
    }

    //            if(document.getElementById('Hidden5').value!="")
    //       {
    //       
    //       
    //       
    //       if(document.getElementById('Hidden4').value=="1")
    //       {
    //      var categery= document.getElementById('Hidden5').value.split("$");
    //              for(var m=0;m<categery.length-1;m++)
    //              {
    //              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
    //              {
    //              gg2++;
    //              }
    //              }
    //      
    //       }
    //       else
    //       {
    //       
    //              var categery= document.getElementById('Hidden5').value.split("$");
    //              for(var m=0;m<categery.length-1;m++)
    //              {
    //              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
    //              {
    //              gg2++;
    //              }
    //              }
    //       
    //       }
    //       
    //       if(document.getElementById('Hidden4').value=="1")
    //       {
    //       if(gg2==categery.length)
    //       {
    //        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
    //       }
    //       else
    //       {
    //       alert("No Match Found");
    //       return false;
    //       
    //       }
    //       }
    //       else
    //       {
    //       if(gg2>0)
    //        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
    //        else
    //        {
    //       alert("No Match Found");
    //       return false;
    //        }
    //       }
    //       
    //       }
    //       else
    //       {
    //        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
    //       
    //       }    
    //         
    //      
    //         if(document.getElementById("detail").value=="null")
    //       {
    //           document.getElementById("detail").value="";
    //       }
    //       else
    //       {
    //      document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
    //       }
    document.getElementById("detail").value = (exec_data.Tables[0].Rows[next].DESCCLOB);
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


    old_execute_house = exec_data.Tables[0].Rows[next].HOUSE;
    old_execute_ext = exec_data.Tables[0].Rows[next].EXTENTIONS;
    old_execute_rashi = exec_data.Tables[0].Rows[next].RASHI;
    old_execute_planet = exec_data.Tables[0].Rows[next].PLANET;
    old_execute_code = exec_data.Tables[0].Rows[next].CODE;
    old_execute_name = exec_data.Tables[0].Rows[next].KEY_STRINGS;
    old_execute_book = exec_data.Tables[0].Rows[next].BOOK;
    old_execute_page0 = exec_data.Tables[0].Rows[next].PAGE_NO;


    old_execute_dedesc = exec_data.Tables[0].Rows[next].DESCCLOB;

    document.getElementById("texthouse").value = (exec_data.Tables[0].Rows[next].HOUSE);
    document.getElementById("ext").value = (exec_data.Tables[0].Rows[next].EXTENTIONS);
    document.getElementById("rashi").value = (exec_data.Tables[0].Rows[next].RASHI);
    document.getElementById("planet").value = (exec_data.Tables[0].Rows[next].PLANET);
    document.getElementById("Textcode").value = (exec_data.Tables[0].Rows[next].CODE);
    document.getElementById("Textname").value = (exec_data.Tables[0].Rows[next].KEY_STRINGS);

    if (document.getElementById("Textname").value == "null") {
        document.getElementById("Textname").value = "";
    }
    else {
        document.getElementById("Textname").value = (exec_data.Tables[0].Rows[next].KEY_STRINGS);
    }
    document.getElementById("book").value = (exec_data.Tables[0].Rows[next].BOOK);

    if (document.getElementById("book").value == "null") {
        document.getElementById("book").value = "";
    }
    else {
        document.getElementById("book").value = (exec_data.Tables[0].Rows[next].BOOK);
    }

    document.getElementById("page0").value = (exec_data.Tables[0].Rows[next].PAGE_NO);

    if (document.getElementById("page0").value == "null") {
        document.getElementById("page0").value = "";
    }
    else {
        document.getElementById("page0").value = (exec_data.Tables[0].Rows[next].PAGE_NO);
    }


    //            if(document.getElementById('Hidden5').value!="")
    //       {
    //       
    //       
    //       
    //       if(document.getElementById('Hidden4').value=="1")
    //       {
    //      var categery= document.getElementById('Hidden5').value.split("$");
    //              for(var m=0;m<categery.length-1;m++)
    //              {
    //              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
    //              {
    //              gg3++;
    //              }
    //              }
    //      
    //       }
    //       else
    //       {
    //       
    //              var categery= document.getElementById('Hidden5').value.split("$");
    //              for(var m=0;m<categery.length-1;m++)
    //              {
    //              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
    //              {
    //              gg3++;
    //              }
    //              }
    //       
    //       }
    //       
    //       if(document.getElementById('Hidden4').value=="1")
    //       {
    //       if(gg3==categery.length)
    //       {
    //        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
    //       }
    //       else
    //       {
    //       alert("No Match Found");
    //       return false;
    //       
    //       }
    //       }
    //       else
    //       {
    //       if(gg3>0)
    //        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
    //        else
    //        {
    //       alert("No Match Found");
    //       return false;
    //        }
    //       }
    //       
    //       }
    //       else
    //       {
    //        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
    //       
    //       }    
    //      
    //      if(document.getElementById("detail").value=="null")
    //       {
    //           document.getElementById("detail").value="";
    //       }
    //       else
    //       {
    //      document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
    //       }
    //      
    document.getElementById("detail").value = (exec_data.Tables[0].Rows[next].DESCCLOB);
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

    //         if (document.getElementById('Textcode').value == "") 
    //        {
    //            alert("Please fill text code")
    //            document.getElementById('Textname').focus();
    //            return false;
    //        }



    var code = "'" + (document.getElementById('Textcode').value) + "'";
    var casecode = code;

    var name = "'" + (document.getElementById('Textname').value) + "'";
    var casename = name;

    var house = "'" + (document.getElementById('texthouse').value) + "'";
    var casehouse = house;

    var ext1 = "'" + (document.getElementById('ext').value) + "'";
    var caseext = ext1;


    var rashi = "'" + (document.getElementById('rashi').value) + "'";
    var caserashi = rashi;

    var planet = "'" + (document.getElementById('planet').value) + "'";
    var caseplanet1 = planet;


    var book = "'" + (document.getElementById('book').value) + "'";
    var casebook = book;

    var page0 = "'" + (document.getElementById('page0').value) + "'";
    var casepage0 = page0;



    var dedesc = "'" + (document.getElementById('detail').value) + "'";
    var caseplanet = dedesc;
    var desc = "''";



    if (Modify == 1) {
        ModifyClass();

        return false;
    }

    casehouse = casehouse.replace("'", "");
    casehouse = casehouse.replace("'", "");
    caseext = caseext.replace("'", "");
    caseext = caseext.replace("'", "");
    caserashi = caserashi.replace("'", "");
    caserashi = caserashi.replace("'", "");
    caseplanet1 = caseplanet1.replace("'", "");
    caseplanet1 = caseplanet1.replace("'", "");

    casecode = casecode.replace("'", "");
    casecode = casecode.replace("'", "");
    casename = casename.replace("'", "");
    casename = casename.replace("'", "");
    casepage0 = casepage0.replace("'", "");
    casepage0 = casepage0.replace("'", "");
    casebook = casebook.replace("'", "");
    casebook = casebook.replace("'", "");

    caseplanet = caseplanet.replace("'", "");
    caseplanet = caseplanet.replace("'", "");





    var tablevalue = casecode + "$~$" + casename + "$~$" + caseplanet + "$~$" + casebook + "$~$" + casepage0 + "$~$" + casehouse + "$~$" + caseplanet1 + "$~$" + caserashi + "$~$" + caseext + "$~$";


    var fi = document.getElementById('tblfields').value.replace("$~$" + tablename, "")
    fi = fi.replace("$~$" + action, "")
    var dateformate = document.getElementById('hiddendateformat').value



    var result = encyclopaedia.save1(casecode, casename, caseplanet, casebook, casepage0, casehouse, caseplanet1, caserashi, caseext)

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


    document.getElementById('hous').disabled = true;
    document.getElementById('karka').disabled = true;
    document.getElementById('rash').disabled = true;
    document.getElementById('plant').disabled = true;


    document.getElementById('texthouse').disabled = true;
    document.getElementById('ext').disabled = true;
    document.getElementById('rashi').disabled = true;
    document.getElementById('planet').disabled = true;
    document.getElementById('Textcode').disabled = true;
    document.getElementById('Textname').disabled = true;

    document.getElementById('book').disabled = true;
    document.getElementById('page0').disabled = true;
    document.getElementById("hous").value = "0";
    document.getElementById("karka").value = "";
    document.getElementById("rash").value = "0";
    document.getElementById("plant").value = "0";
    document.getElementById('detail').disabled = true;
    document.getElementById("texthouse").value = "0";
    document.getElementById("ext").value = "0";
    document.getElementById("rashi").value = "0";
    document.getElementById("planet").value = "0";
    document.getElementById("Textcode").value = "";
    document.getElementById("Textname").value = "";
    document.getElementById("book").value = "";
    document.getElementById("page0").value = "";
    document.getElementById("detail").value = "";
    document.getElementById('hous').style.display = "none";
    document.getElementById('karka').style.display = "none";
    document.getElementById('rash').style.display = "none";
    document.getElementById('plant').style.display = "none";
    document.getElementById('inserts').style.display = "none";
    document.getElementById('Label7').style.display = "none";
    return false;
}


function modifydata() {
    Modify = 1;

    var modifyduplicacydesc = $('texthouse').value;
    var modifyduplicacydesc = $('ext').value;
    var modifyduplicacydesc = $('rashi').value;
    var modifyduplicacydesc = $('planet').value;
    var modifyduplicacydesc = $('Textcode').value;
    var modifyduplicacyalias = $('Textname').value;
    var modifyduplicacydesc = $('book').value;
    var modifyduplicacyalias = $('page0').value;

    var modifyduplicacyalias = $('detail').value;


    //document.getElementById("Textcode").disabled=false;
    document.getElementById("texthouse").disabled = false;
    document.getElementById("ext").disabled = false;
    document.getElementById("rashi").disabled = false;
    document.getElementById("planet").disabled = false;
    document.getElementById("Textname").disabled = false;

    document.getElementById("detail").disabled = false;
    document.getElementById("book").disabled = false;

    document.getElementById("page0").disabled = false;


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







    var str = document.getElementById('tblfields').value;
    var str1 = str.split("$~$");
    var tablename = str1[str1.length - 2];

    var action = str1[str1.length - 1];
    var finalaction = action.split("#");
    var insert = finalaction[0];
    var update = finalaction[1];
    var del = finalaction[2];
    var select = finalaction[3];


    var code = "'" + (document.getElementById('Textcode').value) + "'";
    var casecode = code;

    var house = "'" + (document.getElementById('texthouse').value) + "'";
    var casehouse = house;

    var ext1 = "'" + (document.getElementById('ext').value) + "'";
    var caseext = ext1;


    var rashi = "'" + (document.getElementById('rashi').value) + "'";
    var caserashi = rashi;


    var planet = "'" + (document.getElementById('planet').value) + "'";
    var caseplanet1 = planet;

    var book = "'" + (document.getElementById('book').value) + "'";
    var casebook = book;


    var page0 = "'" + (document.getElementById('page0').value) + "'";
    var casepage0 = page0;

    var name = "'" + (document.getElementById('Textname').value) + "'";
    var casename = name;






    var dedesc = "'" + (document.getElementById('detail').value) + "'";
    var caseplanet = dedesc;
    var desc = "''";









    var fi = document.getElementById('tblfields').value.replace("$~$" + tablename, "")
    fi = fi.replace("$~$" + action, "")
    fi = fi + "$~$"


    var concolname = "CODE" + "$~$";
    var dateformate = document.getElementById('hiddendateformat').value

    var tablevalue = casecode + "$~$" + casename + "$~$" + caseplanet + "$~$" + casebook + "$~$" + casepage0 + "$~$" + casehouse + "$~$" + caseplanet1 + "$~$" + caserashi + "$~$" + caseext + "$~$";
    var res = encyclopaedia.Modify_data1(tablename, fi, tablevalue, concolname, dateformate, "", "", callbackeex)
}

function callbackeex(res) {
    if (res.value == "true") {

        alert("Data updated Successfully")
        click_on_cancel();
        return false;

    }
    else {
        alert(res.value);
        return false;
    }
}

function filter(event) {



    id = document.getElementById(document.activeElement.id).value;
    if (browser != "Microsoft Internet Explorer") {
        event.which;
    }
    else {

        event.keyCode;
    }


    //var keycode = event.keyCode ? event.keyCode : event.which;
    if (event.keyCode == 37 || event.keyCode == 39) {
        return;
    }
    if (event.keyCode == 46) {


        if (document.getElementById("texthouse").value == '0') {
            var h = document.getElementById("texthouse").value = ""
            house = h;
        }
        else {
            house = document.getElementById("texthouse").value
        }

        if (document.getElementById("planet").value == '0') {
            var p = document.getElementById("planet").value = ""
            planet = p;
        }
        else {
            planet = document.getElementById("planet").value
        }


        if (document.getElementById("rashi").value == '0') {
            var r = document.getElementById("rashi").value = ""
            rashi = r;
        }
        else {
            rashi = document.getElementById("rashi").value
        }
      
        ext = document.getElementById('Hidden6').value


        comp_code = document.getElementById("Textcode").value
        book = document.getElementById("book").value
        page0 = document.getElementById("page0").value
        textname = document.getElementById("Textname").value
        dedsec = document.getElementById("detail").value
        var extra1 = id;
        document.getElementById('Hiddenid').value = extra1;
        horarysigni.filtergrid1(comp_code, house, rashi, planet, textname, book, page0, ext, extra1, exec_gridcall)
        document.getElementById('filter_').focus();
        //doTimer();
        document.activeElement.id = "filter_";
        //alert(document.activeElement.id);
        document.getElementById('filter_').focus();
        document.getElementById('filter_').tabIndex = 0;
        document.getElementById('filter_').focus();
        return false;


    }
    if (document.getElementById("texthouse").value == '0') {
        var h = document.getElementById("texthouse").value = ""
        house = h;
    }
    else {
        house = document.getElementById("texthouse").value
    }

    if (document.getElementById("planet").value == '0') {
        var p = document.getElementById("planet").value = ""
        planet = p;
    }
    else {
        planet = document.getElementById("planet").value
    }


    if (document.getElementById("rashi").value == '0') {
        var r = document.getElementById("rashi").value = ""
        rashi = r;
    }
    else {
        rashi = document.getElementById("rashi").value
    }










    ext = document.getElementById('Hidden6').value


    comp_code = document.getElementById("Textcode").value
    book = document.getElementById("book").value
    page0 = document.getElementById("page0").value
    textname = document.getElementById("Textname").value
    dedsec = document.getElementById("detail").value
    var extra1 = id;
    document.getElementById('Hiddenid').value = extra1;
    horarysigni.filtergrid1(comp_code, house, rashi, planet, textname, book, page0, ext, extra1, exec_gridcall)

    document.getElementById('filter_').focus();
    //doTimer();
    document.activeElement.id = "filter_";
    //alert(document.activeElement.id);
    document.getElementById('filter_').focus();
    document.getElementById('filter_').tabIndex = 0;
    document.getElementById('filter_').focus();


    return false;
}
var dsgrid = "";
function exec_gridcall(val) {

    var exec_grid = val.value;
    var id1 = document.getElementById('Hiddenid').value;
    dsexec = exec_grid

    document.getElementById('hdsviewgrid').innerHTML = "";
    document.getElementById('Divgrid1').style.display = "none";

    if (exec_grid.Tables[0].Rows.length >= 0) {

        document.getElementById('hdsviewgridh').innerHTML = "";
        document.getElementById('Divgrid1h').style.display = 'block';
        document.getElementById('Divgrid1h').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('hdsviewgridh').style.display = "block";

        if (document.getElementById("hdsviewgridh").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("Divgrid1h").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("hdsviewgridh").innerHTML.indexOf("width:460px;display:block") <= 0) {
            aa = document.getElementById("hdsviewgridh").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        bufh = "";
        bufh += "<table  id='Divgrid1h' runat='server' align='left' Width='460px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        bufh += "<tr>"
        bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:250px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "KEY_STRINGS" + "</td>"
        bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:50px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "VERIFY" + "</td>"
        bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:65px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "UPDATE" + "</td>"
        bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:65px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "DELETE" + "</td>"
        bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "VRF" + "</td>"
        bufh += "</tr>"
        bufh += "<tr>"
        bufh += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        bufh += "<input type='text' id='filter_' runat='server' style='width:250px;' value='" + id1 + "' onkeyup='javascript:return filter(event);'   >"
        bufh += "</td>"
        bufh += "</tr>"


        bufh += "</table>"

        var hdsview = "";
        temp_del1 = aa + bufh.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('hdsviewgridh').innerHTML = temp_del1;



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

        if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:460px;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='460px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        //        buf2 += "<tr>"
        //        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:250px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "KEY_STRINGS" + "</td>"
        //        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:50px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "VERIFY" + "</td>"
        //        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:65px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "UPDATE" + "</td>"
        //        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:65px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "DELETE" + "</td>"
        //        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "VRF" + "</td>"
        //        buf2 += "</tr>"
        //        buf2 += "<tr>"
        //        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        //        buf2 += "<input type='text' id='filter_' runat='server' style='width:250px;' value='" + id1 + "' onkeyup='javascript:return filter(event);'   >"
        //        buf2 += "</td>"
        //        buf2 += "</tr>"
        document.getElementById('filter_').focus();
        len = 1;

        if (dsexec.Tables[0].Rows.length == 0) {

        }
        var publishcount=1;
        if (dsexec.Tables[0].Rows.length > 0) {

            for (i = 0; i < dsexec.Tables[0].Rows.length; ++i) {


                buf2 += "<tr>"
                mystring = dsexec.Tables[0].Rows[i]['KEY_STRINGS']
                mystring = mystring.replace('"', "&#39;");
                mystring = mystring.replace("'", "&#39;");
                //newTemp = mystring.replace(/\"/g, '\'');

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:250px;' class='dropdown_large_corr'; align='left' value='" + mystring + "'  id='key_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:50px;' align='left' class='dropdown_large_corr'; value='" + dsexec.Tables[0].Rows[i]['CHECKED'] + "'  id='vrf_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:65px;' align='left' class='dropdown_large_corr'; Text='update' value='update' AutoPostBack='true' id='update_" + i + "' onClick='javascript:return update12(this.id);' >Update...</Button>"
                buf2 += "</td>"

                buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:65px;' align='left' class='dropdown_large_corr'; Text='delete' value='delete' AutoPostBack='true' id='delete_" + i + "' onClick='javascript:return delete1(this.id);' >Delete...</Button>"
                buf2 += "</td>"


                buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:65px;' align='left' class='dropdown_large_corr'; Text='chk' value='chk' AutoPostBack='true' id='chk_" + i + "' onClick='javascript:return check1(this.id);' >Chk...</Button>"
                buf2 += "</td>"
                
                 if (dsexec.Tables[0].Rows[i]['STATUS'] == "A") 
                 {
                  publishcount++;
                 document.getElementById('tots').innerHTML="Total Rows:- "+ dsexec.Tables[0].Rows.length +"  Publish Rows:- " + (publishcount-1);
                buf2 += "<td style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:65px;color:green;font-weight: bold;' align='left' class='dropdown_large_corr'; Text='Publish' value='Publish' AutoPostBack='true' id='chk_" + i + "' onClick='javascript:return PublishHorarySignificators(this.id);' >Publish</Button>"
                buf2 += "</td>"
                }
                else
                {
                 buf2 += "<td style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:65px;' align='left' class='dropdown_large_corr'; Text='Publish' value='Publish' AutoPostBack='true' id='chk_" + i + "' onClick='javascript:return PublishHorarySignificators(this.id);' >Publish</Button>"
                buf2 += "</td>"
                }
                
                 if (dsexec.Tables[0].Rows[i]['STATUS'] == "P") 
                 {
                buf2 += "<td style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:75px;color:red;font-weight: bold;' align='left' class='dropdown_large_corr'; Text='Unpublish' value='Unpublish' AutoPostBack='true' id='chk_" + i + "' onClick='javascript:return UnpublishHorarySignificators(this.id);' >Unpublish</Button>"
                buf2 += "</td>"
                }
                else
                {
                 buf2 += "<td style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:75px;' align='left' class='dropdown_large_corr'; Text='Unpublish' value='Unpublish' AutoPostBack='true' id='chk_" + i + "' onClick='javascript:return UnpublishHorarySignificators(this.id);' >Unpublish</Button>"
                buf2 += "</td>"
                }


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

        //alert(document.activeElement.id);
        //   doTimer();
        document.getElementById('filter_').focus();
        document.getElementById('filter_').tabIndex = 0;
        document.getElementById('filter_').focus();
        var text = document.getElementById('filter_');
        if (text != null && text.value.length > 0) {
            
            if (text.createTextRange){
            var FieldRange = text.createTextRange();
            FieldRange.moveStart('character',text.value.length);
            FieldRange.collapse();
            FieldRange.select();
            }
            else if (text.selectionStart || text.selectionStart == '0') {
            var elemLen = text.value.length;
            text.selectionStart = elemLen;
            text.selectionEnd = elemLen;
            text.focus();
            }
        }


        return false;

    }
}
//function showext() {
//    if (document.getElementById('planet').selectedIndex == 0 && document.getElementById('rashi').selectedIndex==0)
//    {
//        document.getElementById('ext').style.display = "block";

//    
//    }


//}


function update12(id) {
    var update = id.split('_')
    var update1 = update[1];
    var key = dsexec.Tables[0].Rows[update1].KEY_STRINGS
    mystring = document.getElementById("key_" + update1).value;
    newTemp = mystring.replace(/'/g, '"');
    var key1 = newTemp;
    if (document.getElementById('texthouse').value != 0) {
        var housev = document.getElementById('texthouse').value
    }
    if (document.getElementById('planet').value != 0) {
        var housev = document.getElementById('planet').value
    }

    if (document.getElementById('rashi').value != 0) {
        var housev = document.getElementById('rashi').value
    }

    var res = horarysigni.update_grid(key, key1, housev);


    alert("Data updated Successfully")


    return false;
}


function delete1(id) {
    var delet = id.split('_')
    var delet1 = delet[1];
    mystring = dsexec.Tables[0].Rows[delet1].KEY_STRINGS
    newTemp = mystring.replace(/'/g, '"');
    var key = newTemp
    //house = document.getElementById("texthouse").value

    if (document.getElementById('texthouse').value != 0) {
        var housev = document.getElementById('texthouse').value
    }
    if (document.getElementById('planet').value != 0) {
        var housev = document.getElementById('planet').value
    }

    if (document.getElementById('rashi').value != 0) {
        var housev = document.getElementById('rashi').value
    }



    var res = horarysigni.delete_grid_row(key, housev);


    alert("Data deleted Successfully")


    return false;
}


function fillcategery(event) {
    document.getElementById('hous').style.display = "block";
    document.getElementById('karka').style.display = "block";
    document.getElementById('rash').style.display = "block";
    document.getElementById('plant').style.display = "block";
    document.getElementById('inserts').style.display = "block";
    document.getElementById('Label7').style.display = "block";
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "gs") {

            var extra1 = document.getElementById('gs').value;

            encyclopaedia.fill_categery(extra1, callback_categery);
            return false;
        }

    }

}

function callback_categery(val) {
    ds = val.value;
    var id1 = document.getElementById('Hiddenid').value;
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {

        document.getElementById('hdsviewgrid').innerHTML = "";
        document.getElementById('Divgrid1').style.display = "none";
        if (ds.Tables[0].Rows.length >= 0) {
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

            if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:560px;display:block") <= 0) {
                aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
            }
            buf2 = "";
            buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='560px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
            buf2 += "<tr>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:240px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "KEY_STRINGS" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:60px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:60px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:60px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "PLANET" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:40px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "VER" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "UPD" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "DEL" + "</td>"
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "VRF" + "</td>"

            buf2 += "</tr>"

            // document.getElementById( 'filter_').focus();
            len = 1;

            if (ds.Tables[0].Rows.length == 0) {
                return false;
            }

            if (ds.Tables[0].Rows.length > 0) {

                for (i = 0; i < ds.Tables[0].Rows.length; ++i) {


                    buf2 += "<tr>"


                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<input type='text' style='width:240px;' class='dropdown_large_corr'; align='left' value='" + ds.Tables[0].Rows[i]['KEY_STRINGS'] + "'  id='key_" + i + "'  >"
                    buf2 += "</td>"


                    if (ds.Tables[0].Rows[i]['HOUSE'] == null || ds.Tables[0].Rows[i]['HOUSE'] == "0") {

                        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                        buf2 += "<input type='text' style='width:60px;' class='dropdown_large_corr'; align='left'   id='ho_" + i + "'  >"
                        buf2 += "</td>"


                    }
                    else {

                        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                        buf2 += "<input type='text' style='width:60px;' class='dropdown_large_corr'; align='left' value='" + ds.Tables[0].Rows[i]['HOUSE'] + "'  id='ho_" + i + "'  >"
                        buf2 += "</td>"
                    }

                    if (ds.Tables[0].Rows[i]['RASHI'] == null || ds.Tables[0].Rows[i]['RASHI'] == "0") {
                        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                        buf2 += "<input type='text' style='width:60px;' class='dropdown_large_corr'; align='left'  id='ra_" + i + "'  >"
                        buf2 += "</td>"
                    }
                    else {

                        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                        buf2 += "<input type='text' style='width:60px;' class='dropdown_large_corr'; align='left' value='" + ds.Tables[0].Rows[i]['RASHI'] + "'  id='ra_" + i + "'  >"
                        buf2 += "</td>"
                    }


                    if (ds.Tables[0].Rows[i]['PLANET'] == null || ds.Tables[0].Rows[i]['PLANET'] == "0") {
                        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                        buf2 += "<input type='text' style='width:60px;' class='dropdown_large_corr'; align='left'  id='pl_" + i + "'  >"
                        buf2 += "</td>"
                    }
                    else {
                        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                        buf2 += "<input type='text' style='width:60px;' class='dropdown_large_corr'; align='left' value='" + ds.Tables[0].Rows[i]['PLANET'] + "'  id='pl_" + i + "'  >"
                        buf2 += "</td>"
                    }

                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<input type='text' style='width:40px;' class='dropdown_large_corr'; align='left' value='" + ds.Tables[0].Rows[i]['CHECKED'] + "'  id='vrf_" + i + "'  >"
                    buf2 += "</td>"


                    buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                    buf2 += "<Button  style='width:30px;' align='left' class='dropdown_large_corr'; Text='update' value='update' AutoPostBack='true' id='update_" + i + "' onClick='javascript:return update1(this.id);' >Upd...</Button>"
                    buf2 += "</td>"

                    buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                    buf2 += "<Button  style='width:30px;' align='left' class='dropdown_large_corr'; Text='delete' value='delete' AutoPostBack='true' id='delete_" + i + "' onClick='javascript:return delete12(this.id);' >Del...</Button>"
                    buf2 += "</td>"

                    buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                    buf2 += "<Button  style='width:30px;' align='left' class='dropdown_large_corr'; Text='chk' value='chk' AutoPostBack='true' id='chk_" + i + "' onClick='javascript:return chk12(this.id);' >Chk...</Button>"
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
    return false;
}



function update1(id) {
    var update = id.split('_')
    var update11 = update[1];
    var key = ds.Tables[0].Rows[update11].KEY_STRINGS
    var key1 = document.getElementById("key_" + update11).value;
    if (document.getElementById('ho_' + update11).value != null && document.getElementById('ho_' + update11).value != "" && document.getElementById('ho_' + update11).value != '0') {
        var housev = document.getElementById("ho_" + update11).value
    }
    if (document.getElementById('ra_' + update11).value != null && document.getElementById('ra_' + update11).value != "" && document.getElementById('ra_' + update11).value != '0') {
        var housev = document.getElementById('ra_' + update11).value
    }

    if (document.getElementById('pl_' + update11).value != null && document.getElementById('pl_' + update11).value != "" && document.getElementById('pl_' + update11).value != '0') {
        var housev = document.getElementById('pl_' + update11).value
    }
    var res = encyclopaedia.update_grid(key, key1, housev);


    alert("Data updated Successfully")


    return false;
}

function delete12(id) {
    var delete11 = id.split('_')
    var delete12 = delete11[1];

    var key = document.getElementById("key_" + delete12).value;
    if (document.getElementById('ho_' + delete12).value != null && document.getElementById('ho_' + delete12).value != "" && document.getElementById('ho_' + delete12).value != '0') {
        var housev = document.getElementById("ho_" + delete12).value
    }
    if (document.getElementById('ra_' + delete12).value != null && document.getElementById('ra_' + delete12).value != "" && document.getElementById('ra_' + delete12).value != '0') {
        var housev = document.getElementById('ra_' + delete12).value
    }

    if (document.getElementById('pl_' + delete12).value != null && document.getElementById('pl_' + delete12).value != "" && document.getElementById('pl_' + delete12).value != '0') {
        var housev = document.getElementById('pl_' + delete12).value
    }
    var res = encyclopaedia.delete_grid_row(key, housev);


    alert("Data deleted Successfully")


    return false;
}


function chk12(id) {
    var chk = id.split('_')
    var chk1 = chk[1];
    var key = document.getElementById("key_" + chk1).value
    if (document.getElementById('ho_' + chk1).value != null && document.getElementById('ho_' + chk1).value != "" && document.getElementById('ho_' + chk1).value != '0') {
        var housev = document.getElementById("ho_" + chk1).value
    }
    if (document.getElementById('ra_' + chk1).value != null && document.getElementById('ra_' + chk1).value != "" && document.getElementById('ra_' + chk1).value != '0') {
        var housev = document.getElementById('ra_' + chk1).value
    }

    if (document.getElementById('pl_' + chk1).value != null && document.getElementById('pl_' + chk1).value != "" && document.getElementById('pl_' + chk1).value != '0') {
        var housev = document.getElementById('pl_' + chk1).value
    }
    document.getElementById("vrf_" + chk1).value = 'Chk'

    var res = encyclopaedia.chk_encyclo(key, housev);
    alert("Data Verified Successfully")
    return false;


}


function showextentions() {
    if (document.getElementById('texthouse').value != 0) {
        var exten = document.getElementById('texthouse').value
    }
    if (document.getElementById('planet').value != 0) {
        var exten = document.getElementById('planet').value
    }

    if (document.getElementById('rashi').value != 0) {
        var exten = document.getElementById('rashi').value
    }
    document.getElementById('hous').value = document.getElementById('texthouse').value;
    document.getElementById('plant').value = document.getElementById('planet').value;
    document.getElementById('rash').value = document.getElementById('rashi').value;

    document.getElementById('Hidden7').value = exten;
    encyclopaedia.showext(exten, call_ext);
    return false;
}

function call_ext(val) {


    exec_extention = val.value;
    if (exec_extention.Tables[0].Rows.length > 0) {
        document.getElementById('hdsviewgrid2').innerHTML = "";
        document.getElementById('Divgrid2').style.display = 'block';
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

        if (document.getElementById("hdsviewgrid2").innerHTML.indexOf("width:280px;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid2").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf3 = "";
        buf3 += "<table  id='Divgrid2' runat='server' align='left' Width='280px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf3 += "<tr>"
        buf3 += "<td  bgcolor=#7DAAE3 style='height:10px;width:200px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "EXTENTIONS" + "</td>"
        buf3 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "Show" + "</td>"

        buf3 += "</tr>"

        len = 1;


        if (exec_extention.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_extention.Tables[0].Rows.length; ++i) {

                buf3 += "<tr>"
                buf3 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf3 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + exec_extention.Tables[0].Rows[i]['EXTENTIONS'] + "'  id='ext_" + i + "'  >"
                buf3 += "</td>"
                buf3 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf3 += "<Button  style='width:80px;' align='left' class='dropdown_large_corr'; Text='show' value='show' AutoPostBack='true' id='showext_" + i + "' onClick='javascript:return showext12(this.id);' >Show...</Button>"
                buf3 += "</td>"


                buf3 += "</tr>"
            }
        }
        buf3 += "</table>"

        var hdsview = "";
        temp_del1 = aa + buf3.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('hdsviewgrid2').innerHTML = temp_del1;

        return false;

    }


}
function showext12() {
    document.getElementById('hous').style.display = "block";
    document.getElementById('karka').style.display = "block";
    document.getElementById('karka').disabled = false;
    document.getElementById('rash').style.display = "block";
    document.getElementById('plant').style.display = "block";
    document.getElementById('inserts').style.display = "block";
    document.getElementById('Label7').style.display = "block";
//    var extense = id.split('_')
//    var extense1 = extense[1];

//    var extenvalue = exec_extention.Tables[0].Rows[extense1].EXTENTIONS
    if (document.getElementById('texthouse').value != 0) {
        var exten = document.getElementById('texthouse').value
    }
    if (document.getElementById('planet').value != 0) {
        var exten = document.getElementById('planet').value
    }

    if (document.getElementById('rashi').value != 0) {
        var exten = document.getElementById('rashi').value
    }
    document.getElementById('hous').value = document.getElementById('texthouse').value;
    document.getElementById('plant').value = document.getElementById('planet').value;
    document.getElementById('rash').value = document.getElementById('rashi').value;
   // document.getElementById('Hidden6').value = extenvalue

    //document.getElementById('Hidden7').value = exten
    var res = horarysigni.showextvalue(exten, exec_showextvalue);


    return false;

}
function exec_showextvalue(val) {
    dsexec = val.value;
    if (dsexec.Tables[0].Rows.length > 0) {

        document.getElementById('hdsviewgridh').innerHTML = "";
        document.getElementById('Divgrid1h').style.display = 'block';
        document.getElementById('Divgrid1h').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;
        document.getElementById('tots').innerHTML = dsexec.Tables[0].Rows.length;
        document.getElementById('hdsviewgridh').style.display = "block";

        if (document.getElementById("hdsviewgridh").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("Divgrid1h").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("hdsviewgridh").innerHTML.indexOf("width:460px;display:block") <= 0) {
            aa = document.getElementById("hdsviewgridh").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        bufh = "";
        bufh += "<table  id='Divgrid1h' runat='server' align='left' Width='460px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        bufh += "<tr>"
        bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:250px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "KEY_STRINGS" + "</td>"
        bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:50px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "VERIFY" + "</td>"
        bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:65px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "UPDATE" + "</td>"
        bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:65px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "DELETE" + "</td>"
        bufh += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "VRF" + "</td>"
        bufh += "</tr>"
        bufh += "<tr>"
        bufh += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        bufh += "<input type='text' id='filter_' runat='server' style='width:250px;' onkeyup='javascript:return filter(event);'  >"
        bufh += "</td>"
        bufh += "</tr>"

        bufh += "</table>"

        var hdsview = "";
        temp_del1 = aa + bufh.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('hdsviewgridh').innerHTML = temp_del1;



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

        if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:460px;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='460px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        //         buf2 += "<tr>"
        //         buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:250px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "KEY_STRINGS" + "</td>"
        //         buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:50px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "VERIFY" + "</td>"
        //         buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:65px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "UPDATE" + "</td>"
        //         buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:65px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "DELETE" + "</td>"
        //         buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "VRF" + "</td>"
        //         buf2 += "</tr>"
        //         buf2 += "<tr>"
        //         buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        //         buf2 += "<input type='text' id='filter_' runat='server' style='width:250px;' onkeyup='javascript:return filter(event);'  >"
        //         buf2 += "</td>"
        //         buf2 += "</tr>"

        len = 1;

         var publishcount=1;
        if (dsexec.Tables[0].Rows.length > 0) {
            for (i = 0; i < dsexec.Tables[0].Rows.length; ++i) {
                mystring = dsexec.Tables[0].Rows[i]['KEY_STRINGS']
                mystring = mystring.replace('"', "&#39;");
                mystring = mystring.replace("'", "&#39;");
                // newTemp = mystring.replace(/\"/g, '\'');
                buf2 += "<tr>"
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:250px;' align='left' class='dropdown_large_corr'; value='" + mystring + "'  id='key_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:50px;' align='left' class='dropdown_large_corr'; value='" + dsexec.Tables[0].Rows[i]['CHECKED'] + "'  id='vrf_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:65px;' align='left' class='dropdown_large_corr'; Text='update' value='update' AutoPostBack='true' id='update_" + i + "' onClick='javascript:return update12(this.id);' >Update...</Button>"
                buf2 += "</td>"

                buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:65px;' align='left' class='dropdown_large_corr'; Text='delete' value='delete' AutoPostBack='true' id='delete_" + i + "' onClick='javascript:return delete1(this.id);' >Delete...</Button>"
                buf2 += "</td>"

                buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:65px;' align='left' class='dropdown_large_corr'; Text='chk' value='chk' AutoPostBack='true' id='chk_" + i + "' onClick='javascript:return check1(this.id);' >Chk...</Button>"
                buf2 += "</td>"
                
                 if (dsexec.Tables[0].Rows[i]['STATUS'] == "A") 
                 {
                 publishcount++;
                 document.getElementById('tots').innerHTML="Total Rows:- "+ dsexec.Tables[0].Rows.length +"  Publish Rows:- " + (publishcount-1);
                buf2 += "<td  style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:65px;color:green;font-weight: bold;' align='left' class='dropdown_large_corr'; Text='Publish' value='Publish' AutoPostBack='true' id='chk_" + i + "' onClick='javascript:return PublishHorarySignificators(this.id);' >Publish</Button>"
                buf2 += "</td>"
                }
                else
                {
                buf2 += "<td  style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:65px;' align='left' class='dropdown_large_corr'; Text='Publish' value='Publish' AutoPostBack='true' id='chk_" + i + "' onClick='javascript:return PublishHorarySignificators(this.id);' >Publish</Button>"
                buf2 += "</td>"
                }
                
                if (dsexec.Tables[0].Rows[i]['STATUS'] == "P") 
                 {
                buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:75px;color:red;font-weight: bold;' align='left' class='dropdown_large_corr'; Text='Unpublish' value='Unpublish' AutoPostBack='true' id='chk_" + i + "' onClick='javascript:return UnpublishHorarySignificators(this.id);' >Unpublish</Button>"
                buf2 += "</td>"
                }
                else
                {
                 buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:75px;' align='left' class='dropdown_large_corr'; Text='Unpublish' value='Unpublish' AutoPostBack='true' id='chk_" + i + "' onClick='javascript:return UnpublishHorarySignificators(this.id);' >Unpublish</Button>"
                buf2 += "</td>"
                }

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
        document.getElementById('filter_').focus();
        return false;

    }
}


function check1(id) {
    var chk = id.split('_')
    var chk1 = chk[1];
    mystring = document.getElementById("key_" + chk1).value
    //newTemp = mystring.replace(/'/g, '"');   //This Line Comment By Deepak
    newTemp=mystring;   // Deepak Added This New Line
    var key = newTemp;
    if (document.getElementById('texthouse').value != 0) {
        var housev = document.getElementById('texthouse').value
    }
    if (document.getElementById('planet').value != 0) {
        var housev = document.getElementById('planet').value
    }

    if (document.getElementById('rashi').value != 0) {
        var housev = document.getElementById('rashi').value
    }
    document.getElementById("vrf_" + chk1).value = 'Chk'

    var res = horarysigni.chk_encyclo(key, housev);
    alert("Data Verified Successfully")


    return false;


}

function significatorinsert() {

    var code = document.getElementById('Textcode').value;
    var casecode = code;

    var name = document.getElementById('karka').value;
    var casename = name;
    
    if(casename=='')
     {
        alert('Please insert any key string !');
        return false;
     }

    var house = document.getElementById('hous').value;
    var casehouse = house;

    var ext1 = 'Significators';
    var caseext = ext1;


    var rashi = document.getElementById('rash').value;
    var caserashi = rashi;

    var planet = document.getElementById('plant').value;
    var caseplanet1 = planet;


    var book = 'Significators';
    var casebook = book;

    var page0 = document.getElementById('page0').value;
    var casepage0 = page0;



    var dedesc = document.getElementById('karka').value;
    var mystring = dedesc;
    //var newTemp = mystring.replace(/'/g, '"');
    var caseplanet = mystring;
    var desc = "''";

    horarysigni.save1(casecode, casename, caseplanet, casebook, casepage0, casehouse, caseplanet1, caserashi, caseext)
    alert('data saved successfully');

    //     $('hous').value = "0"
    //     $('rash').value = "0"
    //     $('plant').value = "0"
    $('karka').value = ""

    return false;


}
function clh() {
    if (document.getElementById('texthouse').value != '--Select House--') {
        document.getElementById('planet').value = '0';
        document.getElementById('rashi').value = '0';

    }
    return false;
}

function clp() {
    if (document.getElementById('planet').value != '--Select Planet--') {
        document.getElementById('texthouse').value = '0';
        document.getElementById('rashi').value = '0';

    }
    return false;
}
function clr() {
    if (document.getElementById('rashi').value != '--Select Rashi--') {
        document.getElementById('texthouse').value = '0';
        document.getElementById('planet').value = '0';

    }
    return false;
}

function showmultiplesignificators() {

    var multisign = document.getElementById("Textname").value;
    encyclopaedia.multisignificators(multisign, callback_categery);
    return false;


}



function PublishHorarySignificators(id) {
    var chk = id.split('_')
    var chk1 = chk[1];
    mystring = document.getElementById("key_" + chk1).value
    //newTemp = mystring.replace(/'/g, '"');
    newTemp = mystring;
    var key = newTemp;
    if (document.getElementById('texthouse').value != 0) {
        var housev = document.getElementById('texthouse').value
    }
    if (document.getElementById('planet').value != 0) {
        var housev = document.getElementById('planet').value
    }

    if (document.getElementById('rashi').value != 0) {
        var housev = document.getElementById('rashi').value
    }
    document.getElementById("vrf_" + chk1).value = 'Chk'

    var res = horarysigni.PublishUnpublishSignificators(key, key,housev,"A","HORARY");
    alert("Data Published Successfully")


    return false;


}

function UnpublishHorarySignificators(id) {
    var chk = id.split('_')
    var chk1 = chk[1];
    mystring = document.getElementById("key_" + chk1).value
    //newTemp = mystring.replace(/'/g, '"');
    newTemp = mystring;
    var key = newTemp;
    if (document.getElementById('texthouse').value != 0) {
        var housev = document.getElementById('texthouse').value
    }
    if (document.getElementById('planet').value != 0) {
        var housev = document.getElementById('planet').value
    }

    if (document.getElementById('rashi').value != 0) {
        var housev = document.getElementById('rashi').value
    }
    document.getElementById("vrf_" + chk1).value = 'Chk'

    var res = horarysigni.PublishUnpublishSignificators(key,key, housev,"P","HORARY");
    alert("Data Unpublished Successfully")


    return false;


}