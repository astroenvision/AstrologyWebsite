/**********************************Accept Only Decimal****************************************************/
function AcceptDecimal(evt) {
    var charCode = (evt.which) ? evt.which : evt.keyCode;
    if (charCode == 46) {
        return true;
    }
    if (charCode > 31 && (charCode < 48 || charCode > 57))
        return false;
   
    return true;
}

/**********************************Accept Only Numeric****************************************************/
function AcceptNumericOnly(evt) {
    var charCode = (evt.which) ? evt.which : evt.keyCode;
  
    if (charCode > 31 && (charCode < 48 || charCode > 57))
        return false;

    return true;
}

/**********************************Replace Null To Blank****************************************************/

function fndnull(val) {
    if (val == null || val == "null" || val == undefined || val == "undefined" || val == "NULL" || val == "NA")
        val = ""
    return val
}

/**********************************Replace Blank To Sapce****************************************************/

function blank_space(val) {
    if (val == "" || val == null || val == undefined || val == "null" || val == "undefined") {
        val = "&nbsp";
    }
    return val
}

/**********************************Replace Blank To Zero****************************************************/

function BlankToZero(val) {
    if (val == "" || val == null || val == undefined || val == "null" || val == "undefined") {
        val = 0
    }
    return val
}