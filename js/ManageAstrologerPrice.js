function CalculateDiscount() {
    try {
        var FinalPriceVal = $("#ctl00_ContentPlaceHolder1_txtFinalPrice").val();
        var DiscountPer = $("#ctl00_ContentPlaceHolder1_txtInrDiscount").val();
        if (FinalPriceVal != 0 || FinalPriceVal != "") {
            if (DiscountPer >= 0) {
                var ActualDiscount = 100 - DiscountPer;
                ActualDiscount = ActualDiscount / 100;
                var ActualAmount = FinalPriceVal / ActualDiscount;
                $("#ctl00_ContentPlaceHolder1_txtPrice").val(parseFloat(ActualAmount).toFixed(2));
                $("#ctl00_ContentPlaceHolder1_hdnPrice").val(parseFloat(ActualAmount).toFixed(2));
            }
            else {
                alert('Warning!! Discount Percentage should be greater then zero');
                return;
            }
        }
        else {
        //    $("#ctl00_ContentPlaceHolder1_txtActualPrice").val('');
        //    $("#ctl00_ContentPlaceHolder1_txtDiscountPrice").val('');
            return;
        }
    }
    catch (ex) {
        alert(ex);
        return;
    }
}