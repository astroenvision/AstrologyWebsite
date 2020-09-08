function HighlightRow(chkB) {
    var xState = chkB.checked;
    if (xState) {
        ShowHideButton(chkB);
    }
    else {
        ShowHideButton(chkB);
    }
}

function CheckAllRows(objRef) {
    var GridView = objRef.parentNode.parentNode.parentNode.parentNode;
    var inputList = GridView.getElementsByTagName("input");
    for (var i = 0; i < inputList.length; i++) {
        var row = inputList[i].parentNode.parentNode;
        if (inputList[i].type == "checkbox" && objRef != inputList[i]) {
            if (objRef.checked) {
                if (inputList[i].disabled == false) {
                    inputList[i].checked = true;
                    ShowHideButton(objRef);
                }
            }
            else {

                if (inputList[i].disabled == false) {
                    inputList[i].checked = false;
                    ShowHideButton(objRef);
                }
            }
        }
    }
}

function ShowHideButton(objRef) {
    try {
        var CheckedCount = 0;
        var GridView = objRef.parentNode.parentNode.parentNode.parentNode;
        var inputList = GridView.getElementsByTagName("input");
        for (var i = 0; i < inputList.length; i++) {
            if (inputList[i].type == "checkbox") {
                if (inputList[i].checked == true) {
                    CheckedCount++;
                }
            }
        }
        if (chkallrow.checked == true) {
            CheckedCount = CheckedCount - 1;
        }
        if (CheckedCount == 0) {
            chkallrow.checked = false;
        }
        if (CheckedCount > 0) {
            $("#ctl00_ContentPlaceHolder1_btnApprove").show();
            $("#ctl00_ContentPlaceHolder1_btnUnapproved").show();
        }
        else {
            $("#ctl00_ContentPlaceHolder1_btnApprove").hide();
            $("#ctl00_ContentPlaceHolder1_btnUnapproved").hide();
        }
    }
    catch (ex) {
        alert(ex);
        return false;
    }
}