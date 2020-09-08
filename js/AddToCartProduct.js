/***************Add TO Cart Product************/

function ProductAddToCart(Flag, ProductOrderId, Cartid, ProductId, ProductQuantity, ProductDimension, ProductWeight, ActualPriceINR, DiscountINR, PayableAmountINR, RegUserID, RegEmailID) {
    try {
         var pageUrl = document.location.origin;
        if (pageUrl.indexOf('localhost') > -1) {
            pageUrl = pageUrl + '/astrology'
        }
        else {
            pageUrl = "";
        }
        $.ajax({
            url: pageUrl + '/CommonMethod.aspx/AddToCartProduct',
            type: 'POST',
            data: "{ 'Flag': '" + Flag + "', 'ProductOrderId': '" + ProductOrderId + "',  'Cartid': '" + Cartid + "', 'ProductId': '" + ProductId + "' , 'ProductQuantity': '" + ProductQuantity + "', 'ProductDimension': '" + ProductDimension + "' , 'ProductWeight': '" + ProductWeight + "'  , 'ActualPriceINR': '" + ActualPriceINR + "'   , 'DiscountINR': '" + DiscountINR + "'  , 'PayableAmountINR': '" + PayableAmountINR + "'  , 'RegUserID': '" + RegUserID + "'  , 'RegEmailID': '" + RegEmailID + "' }",
            contentType: 'application/json; charset=utf-8',
            dataType: "json",
            success: function (result) {
                $("#ctl00_cartid").text(result.d);
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

