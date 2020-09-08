// JScript File
var into;

function givebuttonpermission(formname) {
    //alert("hi");

    if (document.getElementById('hiddencompcode').value == null) {

        window.location.href = 'login.aspx'
    }

    var browser = navigator.appName;
    var id;

    if (browser != "Microsoft Internet Explorer") {
        var httpRequest = null;
        httpRequest = new XMLHttpRequest();
        if (httpRequest.overrideMimeType) {
            httpRequest.overrideMimeType('text/xml');
        }

        httpRequest.onreadystatechange = function() { alertContents(httpRequest) };

        httpRequest.open("GET", "button.aspx?page=" + formname, false);
        httpRequest.send('');
        //alert(httpRequest.readyState);
        if (httpRequest.readyState == 4) {
            //alert(httpRequest.status);
            if (httpRequest.status == 200) {
                id = httpRequest.responseText;
            }
            else {
                alert('There was a problem with the request.');
            }
        }
    }
    else {

        var page;
        var xml = new ActiveXObject("Microsoft.XMLHTTP");
        xml.Open("GET", "button.aspx?page=" + formname, false);
        xml.Send();
        id = xml.responseText;
    }

    /*change*/
    //var ds = response.value;

    //if(ds.Tables[0].Rows.length>0)
    if (id != 0) {
        //var id = ds.Tables[0].Rows[0].button_id;



        if (id == "0" || id == "8") {
            document.getElementById('bdy').style.visibility = "hidden";

            FlagStatus = 0;
            document.getElementById('btnNew').disabled = true;
            document.getElementById('btnQuery').disabled = true;
            document.getElementById('btnExecute').disabled = true;
            document.getElementById('btnCancel').disabled = true;
            document.getElementById('btnExit').disabled = true;
            document.getElementById('btnDelete').disabled = true;
            document.getElementById('btnModify').disabled = true;

            document.getElementById('btnSave').disabled = true;
            document.getElementById('btnModify').disabled = true;
            document.getElementById('btnfirst').disabled = true;
            document.getElementById('btnnext').disabled = true;
            document.getElementById('btnprevious').disabled = true;
            document.getElementById('btnlast').disabled = true;
            document.getElementById('Topbar1_lbldisplay').style.visibility = "hidden";
            document.getElementById('Topbar1_Label3').style.visibility = "hidden";
            document.getElementById('Topbar1_Label4').style.visibility = "hidden";
            document.getElementById('Topbar1_Label5').style.visibility = "hidden";
            document.getElementById('Topbar1_Label2').style.visibility = "hidden";


            window.location.href = 'EnterPage.aspx';
            alert("You Are Not Authorised To See This Form");
            FlagStatus = 0;
            window.close();
            //return false;

        }
        if (id == "1" || id == "9") {
            document.getElementById('btnNew').disabled = false;
            document.getElementById('btnQuery').disabled = true;
            document.getElementById('btnCancel').disabled = false;
            document.getElementById('btnExit').disabled = false;
            document.getElementById('btnDelete').disabled = true;
            document.getElementById('btnExecute').disabled = true;

            document.getElementById('btnSave').disabled = true;
            document.getElementById('btnModify').disabled = true;
            document.getElementById('btnfirst').disabled = true;
            document.getElementById('btnnext').disabled = true;
            document.getElementById('btnprevious').disabled = true;
            document.getElementById('btnlast').disabled = true;
            FlagStatus = 1;
            //return false;
        }
        if (id == "2" || id == "10") {

            document.getElementById('btnNew').disabled = true;
            document.getElementById('btnExecute').disabled = true;
            document.getElementById('btnQuery').disabled = false;
            document.getElementById('btnCancel').disabled = false;
            document.getElementById('btnExit').disabled = false;
            document.getElementById('btnDelete').disabled = true;
            document.getElementById('btnModify').disabled = true;

            document.getElementById('btnSave').disabled = true;
            document.getElementById('btnfirst').disabled = true;
            document.getElementById('btnnext').disabled = true;
            document.getElementById('btnprevious').disabled = true;
            document.getElementById('btnlast').disabled = true;
            document.getElementById('btnExit').disabled = false;
            FlagStatus = 2;
            //return false;

        }
        if (id == "3" || id == "11") {
            document.getElementById('btnNew').disabled = false;
            document.getElementById('btnQuery').disabled = false;
            document.getElementById('btnExecute').disabled = true;
            document.getElementById('btnDelete').disabled = true;
            document.getElementById('btnModify').disabled = true;
            document.getElementById('btnCancel').disabled = false;
            document.getElementById('btnExit').disabled = false;
            document.getElementById('btnDelete').disabled = true;


            document.getElementById('btnSave').disabled = true;
            document.getElementById('btnfirst').disabled = true;
            document.getElementById('btnnext').disabled = true;
            document.getElementById('btnprevious').disabled = true;
            document.getElementById('btnlast').disabled = true;


            FlagStatus = 3;
            //return false;

        }
        if (id == "4" || id == "12") {
            document.getElementById('btnNew').disabled = true;
            document.getElementById('btnQuery').disabled = false;
            document.getElementById('btnCancel').disabled = false;
            document.getElementById('btnExit').disabled = false;
            document.getElementById('btnDelete').disabled = true;
            document.getElementById('btnfirst').disabled = true;
            document.getElementById('btnnext').disabled = true;
            document.getElementById('btnprevious').disabled = true;
            document.getElementById('btnlast').disabled = true;
            document.getElementById('btnExecute').disabled = true;

            document.getElementById('btnNew').disabled = true;
            document.getElementById('btnExecute').disabled = true;
            document.getElementById('btnDelete').disabled = true;
            document.getElementById('btnCancel').disabled = false;
            document.getElementById('btnExit').disabled = false;


            document.getElementById('btnModify').disabled = true;

            document.getElementById('btnSave').disabled = true;
            document.getElementById('btnfirst').disabled = true;
            document.getElementById('btnnext').disabled = true;
            document.getElementById('btnprevious').disabled = true;
            document.getElementById('btnlast').disabled = true;


            FlagStatus = 4;
            //return false;
        }
        if (id == "5" || id == "13") {
            document.getElementById('btnNew').disabled = false;
            document.getElementById('btnSave').disabled = true;
            document.getElementById('btnQuery').disabled = false;
            document.getElementById('btnCancel').disabled = false;
            document.getElementById('btnExit').disabled = false;
            document.getElementById('btnDelete').disabled = true;
            document.getElementById('btnfirst').disabled = true;
            document.getElementById('btnnext').disabled = true;
            document.getElementById('btnprevious').disabled = true;
            document.getElementById('btnlast').disabled = true;
            document.getElementById('btnExecute').disabled = true;
            document.getElementById('btnModify').disabled = true;
            FlagStatus = 5;
            //return false;

        }
        if (id == "6" || id == "14") {
            document.getElementById('btnNew').disabled = true;
            document.getElementById('btnSave').disabled = true;
            document.getElementById('btnQuery').disabled = false;
            document.getElementById('btnModify').disabled = true;
            document.getElementById('btnCancel').disabled = false;
            document.getElementById('btnExit').disabled = false;
            document.getElementById('btnDelete').disabled = true;
            document.getElementById('btnfirst').disabled = true;
            document.getElementById('btnnext').disabled = true;
            document.getElementById('btnprevious').disabled = true;
            document.getElementById('btnlast').disabled = true;
            document.getElementById('btnExecute').disabled = true;
            FlagStatus = 6;
            //return false;
        }
        if (id == "7" || id == "15") {
            document.getElementById('btnNew').disabled = false;
            document.getElementById('btnSave').disabled = true;
            document.getElementById('btnQuery').disabled = false;
            document.getElementById('btnModify').disabled = true;
            document.getElementById('btnCancel').disabled = false;
            document.getElementById('btnExit').disabled = false;
            document.getElementById('btnDelete').disabled = true;
            document.getElementById('btnfirst').disabled = true;
            document.getElementById('btnnext').disabled = true;
            document.getElementById('btnprevious').disabled = true;
            document.getElementById('btnlast').disabled = true;
            document.getElementById('btnExecute').disabled = true;
            FlagStatus = 7;
            //return false;
        }
    }
    else {
        alert("Please Register your form for!!!!!! Administrator only");
        window.close();
        return false;
    }

    if (formname == "ClientMaster") {
        if (document.getElementById('hiddenclientbook') != null) {
            if (document.getElementById('hiddenclientbook').value != "0") {
                NewClick_client('ClientMaster');
                document.getElementById('hiddenclientbook').value = "0";
            }
        }
    }

    if (formname == "Agent_master") {
        checkthevisibility();
    }
    if (formname == "Booking_master" || formname == "QBC") {
        if (document.getElementById('hiddenaudit').value != "") {
            document.getElementById('btnNew').disabled = true;
            document.getElementById('btnQuery').disabled = true;
            document.getElementById('btnCancel').disabled = true;
            document.getElementById('txtciobookid').value = document.getElementById('hiddenaudit').value;
            document.getElementById('btnExecute').disabled = false;
            document.getElementById('txtciobookid').style.backgroundColor = "#FFFF80";
            document.getElementById('txtciobookid').disabled = true;
            document.getElementById('btnExecute').focus();

        }

        var username = document.getElementById('hiddenusername').value;
        var compuser = document.getElementById('hiddencompuser').value;
        var admin = document.getElementById('hiddenadmin').value;
        if (compuser == "Agency" && admin == "yes") {
            comp_ = "Agency";
            admin_ = "Admin";
        }
        else if (admin == "yes" && compuser != "Agency") {
            comp_ = "Hindustan";
            admin_ = "Admin";
        }
        else if (compuser == "Agency" && admin != "yes") {
            comp_ = "Agency";
            admin_ = "User";

        }
        else if (compuser != "Agency" && admin != "yes") {
            comp_ = "Hindustan";
            admin_ = "User";

        }
        document.getElementById("_user").innerHTML = username;
        document.getElementById("_com").innerHTML = " @ " + comp_;
        document.getElementById("_admin").innerHTML = "( " + admin_ + " )";
    }
    return false;






    return false;
}

var formopen = new Array(100);
var formopen12 = new Array(100);
var handleform = new Array(100);
for (var z = 0; z < 99; z++) {

    formopen[z] = "";

}
/*change*/
function giveopenpermission(formname, name, g) {

    var userid = document.getElementById('hiddenuserid').value;
    var compcode = document.getElementById('hiddencompcode').value;


    var browser = navigator.appName;
    var httpRequest = null;
    var id = "";
    var page;


    httpRequest = new XMLHttpRequest();
    //alert(httpRequest);
    if (httpRequest.overrideMimeType) {
        httpRequest.overrideMimeType('text/xml');
    }

    httpRequest.onreadystatechange = function() { };

    httpRequest.open("GET", "openpage.aspx?page=" + formname, false);
    httpRequest.send('');
    id = httpRequest.responseText;
    // alert("hi");
    if (httpRequest.readyState == 4) {

        if (httpRequest.status == 200) {
            id = httpRequest.responseText;
        }
        else {
            //alert('There was a problem with the request.');
        }
    }
    else {

        var xml = new ActiveXObject("Microsoft.XMLHTTP");
        xml.Open("GET", "openpage.aspx?page=" + formname, false);
        xml.Send();
        id = xml.responseText;
    }

    if (id == "null") {
        parent.window.location.href = 'login.aspx';
        return false;
    }

    if (id == 0 || id == "no" || id == "0") {

        alert("You Are Not Authorised To See This Form");
        alert("Module id should be 1,May be its incorrect")
        return false;

    }
    else {

        var t = 0;
        var open = formname;
        var i = 0

        for (i = 0; i < 100; i++) {
            if (formopen[i] == formname) {
                if (handleform[i] && !handleform[i].closed) {
                    formopen12 = handleform[i];
                    //document.getElementById('closewin').value=handleform[i];
                    handleform[i].focus();
                    //return false;
                    //count;
                    break;
                }
                else {
                    win = window.open('' + formname + '.aspx?dis=' + g, '', 'width=' + screen.availWidth + ',height=' + screen.availHeight + ',resizable=1,left=0,top=0,scrollbars=yes');

                    //win=window.open(''+formname+'.aspx');

                    formopen[i] = formname;

                    handleform[i] = win;
                    formopen12 = handleform;
                    //return false;
                    break;
                }


            }
            if (formopen[i] == "") {
                win = window.open('' + formname + '.aspx?dis=' + g, '', 'width=' + screen.availWidth + ',height=' + screen.availHeight + ',resizable=1,left=0,top=0,scrollbars=yes');

                //win=window.open(''+formname+'.aspx');

                formopen[i] = formname;
                handleform[i] = win;
                //return false;
                break;

            }
            //win=window.open(''+formname+'.aspx');
        }

        return false;
    }





    return false;
}


function checkthevisibility() {

    //Agent_master.checkfields(call_check);
    var str = "";
    var id = "";
    var page;


    var browser = navigator.appName;
    var httpRequest = null;
    // alert(browser);
    if (browser != "Microsoft Internet Explorer") {
        httpRequest = new XMLHttpRequest();
        if (httpRequest.overrideMimeType) {
            httpRequest.overrideMimeType('text/xml');
        }

        httpRequest.onreadystatechange = function() { alertContents(httpRequest) };


        httpRequest.open('GET', "chkvisibilityforagency.aspx", false);
        httpRequest.send('');
        str = httpRequest.responseText;



    }
    else {

        var xml = new ActiveXObject("Microsoft.XMLHTTP");
        xml.Open("GET", "chkvisibilityforagency.aspx", false);
        xml.Send();
        str = xml.responseText;
    }

    id = str.split(",");

    if (id[0] == "1") {
        document.getElementById('lab').style.display = "none";
        //document.getElementById('lab').style.visibility="hidden";
        document.getElementById('txt').style.display = "none";
        document.getElementById('txt1').style.display = "none";
        //document.getElementById('txt1').style.visibility="hidden";

    }
    else {

        document.getElementById('lab').style.display = "block";
        //document.getElementById('lab').style.visibility="hidden";
        document.getElementById('txt').style.display = "block";
        document.getElementById('txt1').style.display = "block";


        //		//document.getElementById('agcat').style.display="block";
        //		document.getElementById('agcat').style.visibility="visible";
        //		//document.getElementById('drpagcat').style.display="block";
        //		document.getElementById('drpagcat').style.visibility="visible";

    }
    if (id[1] == "1") {
        //document.getElementById('ascat').style.visibility="hidden";
        //document.getElementById('ascat').style.display="none";
    }
    else {
        //document.getElementById('ascat').style.visibility="visible";
        //document.getElementById('ascat').style.display="block";
    }




    return false;
}

function openreports(formname, a) {


    var t = 0;
    var open = formname;
    var i = 0

    for (i = 0; i < 100; i++) {
        if (formopen[i] == formname) {
            if (handleform[i] && !handleform[i].closed) {
                formopen12 = handleform[i];
                //document.getElementById('closewin').value=handleform[i];
                handleform[i].focus();
                //return false;
                //count;
                break;
            }
            else {
                win = window.open('' + formname + '.aspx', '', 'width=' + screen.availWidth + ',height=' + screen.availHeight + ',resizable=1,left=0,top=0,scrollbars=yes');

                //win=window.open(''+formname+'.aspx');

                formopen[i] = formname;

                handleform[i] = win;
                formopen12 = handleform;
                //return false;
                break;
            }


        }
        if (formopen[i] == "") {
            win = window.open('' + formname + '.aspx', '', 'width=' + screen.availWidth + ',height=' + screen.availHeight + ',resizable=1,left=0,top=0,scrollbars=yes');

            //win=window.open(''+formname+'.aspx');

            formopen[i] = formname;
            handleform[i] = win;
            //return false;
            break;

        }
        //win=window.open(''+formname+'.aspx');
    }

}


function Exit() {
    if (confirm("Do you want to skip this page. ")) {
        window.close();
        return false;
    }
    return false;

}