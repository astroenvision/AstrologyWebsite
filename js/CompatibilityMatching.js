var ActualAmount = 0;
var PayableAmount = 0;

function AddPrice()
{
    try
    {
        PayableAmount = 0;
        ActualAmount = 0;
        var Count = $("#hdnCount").val();
        for (var i = 0; i <= Count ; i++)
        {
            if ($('#AddCat_' + i).prop('checked'))
            {
                PayableAmount = PayableAmount + parseFloat($("#hdnPaybleAmonut_" + i).val());
                ActualAmount = ActualAmount + parseFloat($("#hdnActualAmonut_" + i).val());
            }
        }
        $("#ctl00_ContentPlaceHolder1_divTotalAmount").html("₹" + parseFloat(ActualAmount).toFixed(2));
        $("#ctl00_ContentPlaceHolder1_divTotalPayableAmount").html("₹" + parseFloat(PayableAmount).toFixed(2));
        var Save = parseFloat(ActualAmount) - parseFloat(PayableAmount);
        $("#ctl00_ContentPlaceHolder1_divYouSave").html("₹" + parseFloat(Save).toFixed(2));
        var Price = PayableAmount + parseFloat($("#ctl00_ContentPlaceHolder1_hdnKundliMacting").val());
        $("#ctl00_ContentPlaceHolder1_divActualPayableAmount").html("₹" + parseFloat(Price).toFixed(2));
        
    }
    catch(ex)
    {
        alert(ex);
        return;
    }
}


function SaveToCart()
{
    var Count = $("#hdnCount").val();
    for (var i = 0; i <= Count ; i++) {
        if ($('#AddCat_' + i).prop('checked')) {
            var CatName = $("#hdnCatNAME_" + i).val();
            var CatID = $("#hdnCatID_" + i).val();
            var GroupID = "NATAL";
            var flag = "";

            var pageUrl = document.location.origin;
            if (pageUrl.indexOf('localhost') > -1) {
                pageUrl = pageUrl + '/astrology'
            }
            else {
                pageUrl = "";
            }
            $.ajax({
                url: pageUrl + '/CommonMethod.aspx/AddToCart',
                type: 'POST',
                data: "{ 'CatName': '" + CatName + "','CatId': '" + CatID + "', 'GroupId': '" + GroupID + "' , 'Flag': '" + flag + "'}",
                contentType: 'application/json; charset=utf-8',
                dataType: "json",
                success: function (result) {
                    window.location = "compatibilitymatching.html";
                },
                error: function (error) {
                    alert(error.responseText);
                },
                async: false
            });
        }
    }
}