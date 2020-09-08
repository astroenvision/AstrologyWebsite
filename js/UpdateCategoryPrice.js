
/***********************************************Calculate INR Value **************************************************************/

function CalculateDiscount()
{
    try {
        CalculateDiscount();
    }
    catch (ex)
    {
        alert(ex);
        return false;
    }
}


function CalculateDiscount()
{
    try{
        var DiscountPer = $("#ctl00_ContentPlaceHolder1_txtDicountRate").val();
        var FinalPriceVal = $("#ctl00_ContentPlaceHolder1_txtFinalPrice").val();
        if (FinalPriceVal != 0 || FinalPriceVal != "") {
            if (DiscountPer >= 0) {
                var ActualDiscount = 100 - DiscountPer;
                ActualDiscount = ActualDiscount / 100;
                var ActualAmount = FinalPriceVal / ActualDiscount;
                $("#ctl00_ContentPlaceHolder1_txtActualPrice").val(parseFloat(ActualAmount).toFixed(2));
                $("#ctl00_ContentPlaceHolder1_hdnActualAmountINR").val(parseFloat(ActualAmount).toFixed(2));
                var DiscountPrice = ActualAmount - FinalPriceVal;
                $("#ctl00_ContentPlaceHolder1_txtDiscountPrice").val(parseFloat(DiscountPrice).toFixed(2));
                $("#ctl00_ContentPlaceHolder1_hdntxtDiscountPriceINR").val(parseFloat(DiscountPrice).toFixed(2));
                CalculateDiscount_USD('DiscountonUsd');
            }
            else {
                alert('Warning!! Discount Percentage should be greater then zero');
                return;
            }
        }
        else {
            $("#ctl00_ContentPlaceHolder1_txtActualPrice").val('');
            $("#ctl00_ContentPlaceHolder1_txtDiscountPrice").val('');
            return;
        }

    }
    catch(ex)
    {
        alert(ex);
        return false;
    }
}

/***********************************************Calculate USD Value **************************************************************/

function CalculateDiscount_USD(Flag)
{
    try
    {
        
        var INRUSDRate = $("#ctl00_ContentPlaceHolder1_txtUsdRate").val();
        var IncreaseUsdPrice = $("#ctl00_ContentPlaceHolder1_txtIncreaseUsdPriceInPer").val();
        var UsdDiscountRate = $("#ctl00_ContentPlaceHolder1_txtUsdDiscount").val();
        var INRActualPrice = $("#ctl00_ContentPlaceHolder1_txtActualPrice").val();
  
        if (IncreaseUsdPrice == "") {
            IncreaseUsdPrice = 0;
        }     
        if (UsdDiscountRate == "") {
            UsdDiscountRate = 0;
        }
        if (UsdDiscountRate >= 0) {
            IncreaseUsdPrice = parseFloat(IncreaseUsdPrice) / 100;
            IncreaseUsdPrice = parseFloat(IncreaseUsdPrice) * 100;
            var CalVal = (parseFloat(INRActualPrice) * parseFloat(IncreaseUsdPrice)) / 100;
            var CalculateINRRAte = parseFloat(INRActualPrice) + parseFloat(CalVal);
            if (Flag == 'UsdPrice') {
                $("#ctl00_ContentPlaceHolder1_txtIncreaseUsdPrice").val(CalculateINRRAte);
            }
            var ConvertToUSd = parseFloat(CalculateINRRAte) / parseFloat(INRUSDRate);
            $("#ctl00_ContentPlaceHolder1_TxtActualPriceinUsd").val(parseFloat(ConvertToUSd).toFixed(2));
            $("#ctl00_ContentPlaceHolder1_hdnActualAmountUSD").val(parseFloat(ConvertToUSd).toFixed(2));
            var DicountAmount = (parseFloat(ConvertToUSd) * parseFloat(UsdDiscountRate)) / 100;
            $("#ctl00_ContentPlaceHolder1_txtUSD_DiscountPrice").val(parseFloat(DicountAmount).toFixed(2));
            $("#ctl00_ContentPlaceHolder1_hdnDiscountPriceUSD").val(parseFloat(DicountAmount).toFixed(2));
            var FinalAmount = parseFloat(ConvertToUSd) - parseFloat(DicountAmount);
            $("#ctl00_ContentPlaceHolder1_txtUSD_FinalPrice").val(parseFloat(FinalAmount).toFixed(2));
            $("#ctl00_ContentPlaceHolder1_hdnFinalPriceUSD").val(parseFloat(FinalAmount).toFixed(2));
       }
    }
    catch(ex)
    {
        alert(ex);
        return;
    }
}
