var Discount = 0;
var DiscountAmount = 0;
var ActualAmount = 0;
var PayableAmount = 0;
var LanguageType = '';
var ConsultType = '';
var Question1 = "";
var Question2 = "";
var Question3 = "";
var Question4 = "";
var Question5 = "";
var Min = "";
var NoOfquestions = "";
var QuestionNo="";

function btnBook_Click(flag, CartId, RegUserID, RegEmailId, AmountType, AstrologerID, Name, btnValue) {
    try {
    
        if (NoOfquestions == '1' ||  NoOfquestions == '')
        {
            Question1 = $('#txtQuestion_1').val();
            Question1 = Question1.replace(/'/g, "\\'");
            Question2 = ""; Question3 = ""; Question4 = ""; Question5 = "";
        }
        else if (NoOfquestions == '2')
        {
            Question1 = $('#txtQuestion_1').val().replace(/'/g, "\\'");
            Question2 = $('#txtQuestion_2').val().replace(/'/g, "\\'");
            Question3 = ""; Question4 = ""; Question5 = "";
        }
        else if (NoOfquestions == '3')
        {
            Question1 = $('#txtQuestion_1').val().replace(/'/g, "\\'");
            Question2 = $('#txtQuestion_2').val().replace(/'/g, "\\'");
            Question3 = $('#txtQuestion_3').val().replace(/'/g, "\\'");
            Question4 = ""; Question5 = "";
        }
        else if (NoOfquestions == '4') {
            Question1 = $('#txtQuestion_1').val().replace(/'/g, "\\'");
            Question2 = $('#txtQuestion_2').val().replace(/'/g, "\\'");
            Question3 = $('#txtQuestion_3').val().replace(/'/g, "\\'");
            Question4 = $('#txtQuestion_4').val().replace(/'/g, "\\'");
            Question5 = "";
        }
        else if (NoOfquestions == '5') {
            Question1 = $('#txtQuestion_1').val().replace(/'/g, "\\'");
            Question2 = $('#txtQuestion_2').val().replace(/'/g, "\\'");
            Question3 = $('#txtQuestion_3').val().replace(/'/g, "\\'");
            Question4 = $('#txtQuestion_4').val().replace(/'/g, "\\'");
            Question5 = $('#txtQuestion_5').val().replace(/'/g, "\\'");
        }
        if (Question1 == "" && Question2 == "" ) {
            alert('Please Write any question!!');
            return false;
        }
        SetPaymentValue(btnValue);
        if (RegUserID == "0") {
            SavePayment(flag, CartId, RegUserID, RegEmailId, PayableAmount, Discount, DiscountAmount, ActualAmount, AmountType, AstrologerID, Name, Min);
            window.location.href = 'signin.html?flag=CONSULT_AN_ASTROLOGER';

        }
        else {
            SavePayment(flag, CartId, RegUserID, RegEmailId, PayableAmount, Discount, DiscountAmount, ActualAmount, AmountType, AstrologerID, Name, Min);
            window.location.href = 'enterdetails.aspx?groupid=NATAL&cartid=' + CartId + '&flag=CONSULT_AN_ASTROLOGER';
        }
    }
    catch (ex) {
        alert(ex);
        return;
    }
}

function SavePayment(flag, CartId, RegUserID, RegEmailId, PayableAmount, Discount, DiscountAmount, ActualAmount, AmountType, AstrologerID, Name, NoOfMin) {
    try {

        var pageUrl = document.location.origin;
        if (pageUrl.indexOf('localhost') > -1) {
            pageUrl = pageUrl + '/astrology'
        }
        else {
            pageUrl = "";
        }
        $.ajax({
            url: pageUrl + '/CommonMethod.aspx/ManagePayment',
            type: 'POST',
            data: "{ 'Flag': '" + flag + "', 'CartId': '" + CartId + "',  'RegUserID': '" + RegUserID + "', 'RegEmailId': '" + RegEmailId + "' , 'PayableAmount': '" + PayableAmount + "', 'Discount': '" + Discount + "' , 'DiscountAmount': '" + DiscountAmount + "'  , 'ActualAmount': '" + ActualAmount + "'   , 'AmountType': '" + AmountType + "'  , 'AstrologerID': '" + AstrologerID + "'  , 'Name': '" + Name + "' , 'LangType': '" + LanguageType + "' , 'ConsultationType': '" + ConsultType + "' , 'Question1': '" + Question1 + "' , 'Question2': '" + Question2 + "' , 'NoOfMin': '" + NoOfMin + "', 'Question3': '" + Question3 + "' , 'Question4': '" + Question4 + "' ,'Question5': '" + Question5 + "' ,'PayFor': '" + 'CONSULT_AN_ASTROLOGER' + "'  ,'ClientID': '" + "" + "'  ,'ClientEmailID': '" + "" + "' }",
            contentType: 'application/json; charset=utf-8',
            dataType: "json",
            success: function (result) {
            },
            error: function (error) {
                alert(error.responseText);
            },
            async: false
        });
    }
    catch (ex) {
        alert(ex);
        return;
    }
}

function SetPayment(ID) {
    try {
       
        var DivID = ID.split("_")[1];
        var FirstVal = ID.split("_")[1];
        var SecondVal = ID.split("_")[2];
        
        Discount = $("#hdnDiscountAmonut_" + FirstVal + "_" + SecondVal).val();
        ActualAmount = $("#hdnActualAmonut_" + FirstVal + "_" + SecondVal).val();
        PayableAmount = $("#hdnPayableAmount_" + FirstVal + "_" + SecondVal).val();
        Min = $("#hdnMin_" + FirstVal + "_" + SecondVal).val();
        NoOfquestions = $("#hdnQus_" + FirstVal + "_" + SecondVal).val();
        ShowTextBox(NoOfquestions);
        DiscountAmount = ActualAmount - PayableAmount;
        $("#divPayableAmount_" + FirstVal).html("<span style='color: #f25e0a;font-weight: bold;font-size: 0.45em;'>You Pay</span>₹" + PayableAmount + "<span>(Includes GST)</span>");
        $("#divOldAmount_" + FirstVal).html("₹" + ActualAmount);
        $("#divSaveAmount_" + FirstVal).html("Save ₹ " + parseFloat(DiscountAmount).toFixed(2) + "(" + Discount + "%)");
        $("#divDiscountAmount_" + FirstVal).html("Discount :- " + Discount + "%");

    }
    catch (ex) {
        alert(ex);
        return;
    }
}

function ShowTextBox(no)
{
    try
    {
        
        for (i = 1; i <= 5 ; i++) {
            $("#divqus_" + i).hide();
        }

        for(i=1; i<= no ; i++)
        {
            $("#divqus_"+ i).show();
        }
        
        if (no == "1")
        {
            $('#txtQuestion_2').val('');
            $('#txtQuestion_3').val('');
            $('#txtQuestion_4').val('');
            $('#txtQuestion_5').val('');
            var id2=  $('#ctl00_ContentPlaceHolder1_hdnQusID2').val();
            var id3=  $('#ctl00_ContentPlaceHolder1_hdnQusID3').val();
            var id4=  $('#ctl00_ContentPlaceHolder1_hdnQusID4').val();
            var id5=  $('#ctl00_ContentPlaceHolder1_hdnQusID5').val();
            $("#chk_" + id2).prop("checked", false);
            $("#chk_" + id3).prop("checked", false);
            $("#chk_" + id4).prop("checked", false);
            $("#chk_" + id5).prop("checked", false);
        }
        if (no == "2") {
            $('#txtQuestion_3').val('');
            $('#txtQuestion_4').val('');
            $('#txtQuestion_5').val('');
          
            var id3 = $('#ctl00_ContentPlaceHolder1_hdnQusID3').val();
            var id4 = $('#ctl00_ContentPlaceHolder1_hdnQusID4').val();
            var id5 = $('#ctl00_ContentPlaceHolder1_hdnQusID5').val();
            $("#chk_" + id3).prop("checked", false);
            $("#chk_" + id4).prop("checked", false);
            $("#chk_" + id5).prop("checked", false);
        }
        if (no == "3") {
            $('#txtQuestion_4').val('');
            $('#txtQuestion_5').val('');
            var id4 = $('#ctl00_ContentPlaceHolder1_hdnQusID4').val();
            var id5 = $('#ctl00_ContentPlaceHolder1_hdnQusID5').val();
            $("#chk_" + id4).prop("checked", false);
            $("#chk_" + id5).prop("checked", false);
        }
        if (no == "4") {
            $('#txtQuestion_5').val('');
             var id5 = $('#ctl00_ContentPlaceHolder1_hdnQusID5').val();
            $("#chk_" + id5).prop("checked", false);
        }
       
      
    }
    catch(ex)
    {
        alert(ex);
        return;
    }
}

function CheckedRadioButton() {
    try {
        var Count = $("#hdnCount").val();
        for (i = 0; i < Count ; i++) {
            $("#AstroPrice_" + i + "_" + 0).prop("checked", true);

        }
        Min = $("#hdnMin_" + 0 + "_" + 0).val();
    }
    catch (ex) {
        alert(ex);
        return;
    }
}

function SetPaymentValue(btnVal) {
    try {
        var Count = $("#SecondCount_" + btnVal).val();
        for (i = 0 ; i < Count ; i++) {
            if ($("#AstroPrice_" + btnVal + "_" + i).prop("checked")) {
                Discount = $("#hdnDiscountAmonut_" + btnVal + "_" + i).val();
                ActualAmount = $("#hdnActualAmonut_" + btnVal + "_" + i).val();
                PayableAmount = $("#hdnPayableAmount_" + btnVal + "_" + i).val();
                DiscountAmount = ActualAmount - PayableAmount;
            }
        }
    }
    catch (ex) {
        alert(ex);
        return;
    }
}

function SetLanguageType(LangValue) {
    try {
        LanguageType = LangValue;
    }
    catch (ex) {

    }
}

function SetConsultationType(ConsultValue) {
    try {
        ConsultType = ConsultValue;
    }
    catch (ex) {
        alert(ex);
        return;
    }
}

function countChar(GetTxtBoxNo) {
    try {
        var length = $("#txtQuestion_" + GetTxtBoxNo).val().length;
        $("#lblMessage_" + GetTxtBoxNo).text('');
        $("#lblMessage_" + GetTxtBoxNo).text(length);
        Question1 = $('#txtQuestion_1').val();
        Question2 = $('#txtQuestion_2').val();
        Question3 = $('#txtQuestion_3').val();
        Question4 = $('#txtQuestion_4').val();
        Question5 = $('#txtQuestion_5').val();
     }
    catch (ex) {
        alert(ex);
        return false;
    }

}

function GetCheckbocData(id) {
    try {
        var a = $('#p_' + id).text();
        var count = a.split(".").length;
        var res = a.split(".");
        var qus = "";
        if (NoOfquestions == "")
        {
            NoOfquestions = 1;
        }
        for (i = 1; i < count; i++)
        {
            if (qus == "") {
                qus = res[i];
            }
            else {
                qus = qus + "." + res[i];
            }
        }
        if ($("#chk_" + id).prop('checked') == true) {
              if (NoOfquestions == 1)
                {
                    if ($("#chk_" + id).prop('checked') == true) {
                        if ($('#txtQuestion_1').val() == '') {
                            $('#txtQuestion_1').val(qus);
                            $('#ctl00_ContentPlaceHolder1_hdnQusID1').val(id);
                           
                            return false;
                        }
                    }
                }
                else if (NoOfquestions == 2) {
                    if ($("#chk_" + id).prop('checked') == true) {
                        if ($('#txtQuestion_1').val() == '') {
                            $('#txtQuestion_1').val(qus);
                            $('#ctl00_ContentPlaceHolder1_hdnQusID1').val(id);
                            return false;
                        }
                        if ($('#txtQuestion_2').val() == '') {
                            $('#txtQuestion_2').val(qus);
                            $('#ctl00_ContentPlaceHolder1_hdnQusID2').val(id);
                            return false;
                        }
                    }
                }
                else if (NoOfquestions == 3) {
                    if ($("#chk_" + id).prop('checked') == true) {
                        if ($('#txtQuestion_1').val() == '') {
                            $('#txtQuestion_1').val(qus);
                            $('#ctl00_ContentPlaceHolder1_hdnQusID1').val(id);
                            return false;
                        }
                        if ($('#txtQuestion_2').val() == '') {
                            $('#txtQuestion_2').val(qus);
                            $('#ctl00_ContentPlaceHolder1_hdnQusID2').val(id);
                            return false;
                        }
                        if ($('#txtQuestion_3').val() == '') {
                            $('#txtQuestion_3').val(qus);
                            $('#ctl00_ContentPlaceHolder1_hdnQusID3').val(id);
                            return false;
                        }
                    }
                }
                else if (NoOfquestions == 4) {
                    if ($("#chk_" + id).prop('checked') == true) {
                        if ($('#txtQuestion_1').val() == '') {
                            $('#txtQuestion_1').val(qus);
                            $('#ctl00_ContentPlaceHolder1_hdnQusID1').val(id);
                            return false;
                        }
                        if ($('#txtQuestion_2').val() == '') {
                            $('#txtQuestion_2').val(qus);
                            $('#ctl00_ContentPlaceHolder1_hdnQusID2').val(id);
                            return false;
                        }
                        if ($('#txtQuestion_3').val() == '') {
                            $('#txtQuestion_3').val(qus);
                            $('#ctl00_ContentPlaceHolder1_hdnQusID3').val(id);
                            return false;
                        }
                        if ($('#txtQuestion_4').val() == '') {
                            $('#txtQuestion_4').val(qus);
                            $('#ctl00_ContentPlaceHolder1_hdnQusID4').val(id);
                            return false;
                        }
                    }
                }
                else if (NoOfquestions == 5) {
                    if ($("#chk_" + id).prop('checked') == true) {
                        if ($('#txtQuestion_1').val() == '') {
                            $('#txtQuestion_1').val(qus);
                            $('#ctl00_ContentPlaceHolder1_hdnQusID1').val(id);
                            return false;
                        }
                        if ($('#txtQuestion_2').val() == '') {
                            $('#txtQuestion_2').val(qus);
                            $('#ctl00_ContentPlaceHolder1_hdnQusID2').val(id);
                            return false;
                        }
                        if ($('#txtQuestion_3').val() == '') {
                            $('#txtQuestion_3').val(qus);
                            $('#ctl00_ContentPlaceHolder1_hdnQusID3').val(id);
                            return false;
                        }
                        if ($('#txtQuestion_4').val() == '') {
                            $('#txtQuestion_4').val(qus);
                            $('#ctl00_ContentPlaceHolder1_hdnQusID4').val(id);
                            return false;
                        }
                        if ($('#txtQuestion_5').val() == '') {
                            $('#txtQuestion_5').val(qus);
                            $('#ctl00_ContentPlaceHolder1_hdnQusID5').val(id);
                            return false;
                        }
                    }
                }
            }    
        else
        {
            if ($('#txtQuestion_1').val() == qus) {
                $('#txtQuestion_1').val('');
                return false;
            }
            if ($('#txtQuestion_2').val() == qus) {
                $('#txtQuestion_2').val('');
                return false;
            }
            if ($('#txtQuestion_3').val() == qus) {
                $('#txtQuestion_3').val('');
                return false;
            }
            if ($('#txtQuestion_4').val() == qus) {
                $('#txtQuestion_4').val('');
                return false;
            }
            if ($('#txtQuestion_5').val() == qus) {
                $('#txtQuestion_5').val('');
                return false;
            }
        }
    }
    catch (ex) {
        alert(ex);
        return false;
    }
}
