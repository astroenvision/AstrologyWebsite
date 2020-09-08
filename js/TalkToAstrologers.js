var Discount = 0;
var DiscountAmount = 0;
var ActualAmount = 0;
var PayableAmount = 0;
var LanguageType = 'English';
var ConsultType = 'Telephonic';
var Question1 = "";
var Question2 = "";
var Question3 = "";
var Question4 = "";
var Question5 = "";
var Min = "";



function btnBook_Click(flag, CartId, RegUserID, RegEmailId, AmountType, AstrologerID, Name, btnValue) {
    try {
        Question1 = $('#txtQuestion1').val().replace(/'/g, "\\'");
        Question2 = $('#txtQuestion2').val().replace(/'/g, "\\'");
        if (Question1 == "" && Question2 == "") {
            alert('Please Write any question!!');
            return false;
        }
        SetPaymentValue(btnValue);
        if (RegUserID == "0") {
            SavePayment(flag, CartId, RegUserID, RegEmailId, PayableAmount, Discount, DiscountAmount, ActualAmount, AmountType, AstrologerID, Name, Min);
            window.location.href = 'signin.html?flag=TalkToAstrologer';

        }
        else {
            SavePayment(flag, CartId, RegUserID, RegEmailId, PayableAmount, Discount, DiscountAmount, ActualAmount, AmountType, AstrologerID, Name, Min);
            window.location.href = 'enterdetails.aspx?groupid=NATAL&cartid=' + CartId + '&flag=TALK_TO_ASTROLOGER';
        }
    }
    catch (ex) {
        alert(ex);
        return;
    }
}

function SavePayment(flag, CartId, RegUserID, RegEmailId, PayableAmount, Discount, DiscountAmount, ActualAmount, AmountType, AstrologerID, Name, NoOfMin)
{
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
            data: "{ 'Flag': '" + flag + "', 'CartId': '" + CartId + "',  'RegUserID': '" + RegUserID + "', 'RegEmailId': '" + RegEmailId + "' , 'PayableAmount': '" + PayableAmount + "', 'Discount': '" + Discount + "' , 'DiscountAmount': '" + DiscountAmount + "'  , 'ActualAmount': '" + ActualAmount + "'   , 'AmountType': '" + AmountType + "'  , 'AstrologerID': '" + AstrologerID + "'  , 'Name': '" + Name + "' , 'LangType': '" + LanguageType + "' , 'ConsultationType': '" + ConsultType + "' , 'Question1': '" + Question1 + "' , 'Question2': '" + Question2 + "' , 'NoOfMin': '" + NoOfMin + "', 'Question3': '" + Question3 + "' , 'Question4': '" + Question4 + "' ,'Question5': '" + Question5 + "' ,'PayFor': '" + 'TALK_TO_ASTROLOGER' + "'  ,'ClientID': '" + "" + "'  ,'ClientEmailID': '" + "" + "' }",
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
    catch(ex)
    {
        alert(ex);
        return;
    }
}

function SetPayment(ID)
{
    try
    {
        var DivID = ID.split("_")[1];
        var FirstVal = ID.split("_")[1];
        var SecondVal = ID.split("_")[2];
        Discount = $("#hdnDiscountAmonut_" + FirstVal + "_" + SecondVal).val();
        ActualAmount = $("#hdnActualAmonut_" + FirstVal + "_" + SecondVal).val();
        PayableAmount = $("#hdnPayableAmount_" + FirstVal + "_" + SecondVal).val();
        Min = $("#hdnMin_" + FirstVal + "_" + SecondVal).val();
        DiscountAmount = ActualAmount - PayableAmount;
        $("#divPayableAmount_" + FirstVal).html("<span style='color: #f25e0a;font-weight: bold;font-size: 0.45em;'>You Pay</span>₹" + PayableAmount + "<span>(Includes GST)</span>");
        $("#divOldAmount_" + FirstVal).html("₹" + ActualAmount);
        $("#divSaveAmount_" + FirstVal).html("Save ₹ " + parseFloat(DiscountAmount).toFixed(2) + "(" + Discount + "%)");
        $("#divDiscountAmount_" + FirstVal).html("Discount :- "  + Discount + "%");
 }
    catch(ex)
    {
        alert(ex);
        return;
    }
}

function CheckedRadioButton()
{
    try {
    
        var Count = $("#hdnCount").val();
        for (i = 0; i < Count ; i++)
        {
            $("#AstroPrice_" + i + "_" + 0).prop("checked", true);

        }
        Min = $("#hdnMin_" + 0 + "_" + 0).val();
    }
    catch(ex)
    {
        alert(ex);
        return;
    }
}

function SetPaymentValue(btnVal)
{
    try
    {
        var Count = $("#SecondCount_" + btnVal).val();
        for (i = 0 ; i < Count ; i++)
        {
            if ($("#AstroPrice_" + btnVal + "_" + i).prop("checked")) {
                Discount = $("#hdnDiscountAmonut_" + btnVal + "_" + i).val();
                ActualAmount = $("#hdnActualAmonut_" + btnVal + "_" + i).val();
                PayableAmount = $("#hdnPayableAmount_" + btnVal + "_" + i).val();
                DiscountAmount = ActualAmount - PayableAmount;
            }
        }
 }
    catch(ex)
    {
        alert(ex);
        return;
    }
}

function SetLanguageType(LangValue)
{
    try {
        LanguageType = LangValue;
      }
    catch (ex) {

    }
}

function SetConsultationType(ConsultValue)
{
    try{
        ConsultType = ConsultValue;
    }
    catch(ex)
    {
        alert(ex);
        return;
    }
}

function countChar(GetTxtBoxNo) {
    try {

        if (GetTxtBoxNo == 1) {
            var length = $('#txtQuestion1').val().length;
            $("#lblMessage").text('');
            $("#lblMessage").text(length);
            Question1 = $('#txtQuestion1').val();
        }
        else {
            var length = $('#txtQuestion2').val().length;
            $("#lblMessage1").text('');
            $("#lblMessage1").text(length);
            Question2 = $('#txtQuestion2').val();
        }
    }
    catch (ex) {
        alert(ex);
        return false;
    }

}

//$("#txtQuestion2").mouseout(() => {
//    ('hello');
//});