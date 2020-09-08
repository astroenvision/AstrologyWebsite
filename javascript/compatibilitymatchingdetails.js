


function Get_CompatibilityMatching() {
    //var BoyID = document.getElementById('hdnboyid').value;
    //var GirlID = document.getElementById('hdngirlid').value;

    var RegUserId = document.getElementById("ctl00_ContentPlaceHolder1_hdnRegUserId").value;
    var RegUserEmailId = document.getElementById("ctl00_ContentPlaceHolder1_hdnRegUserEmailId").value;

    var BoyID = document.getElementById('ctl00_ContentPlaceHolder1_hdnboyid').value;
    var GirlID = document.getElementById('ctl00_ContentPlaceHolder1_hdngirlid').value;

    if (document.getElementById("ctl00_ContentPlaceHolder1_hdnPayType").value.toUpperCase() == "INR") {
        var dsfplist = compatibilitymatchingdetails.GetFinalPrice(document.getElementById('ctl00_ContentPlaceHolder1_hdncartid').value);
        var dsfp = dsfplist.value;
        var totalprice = "";

        if (dsfp.Tables[0].Rows.length > 0) {
            totalprice = dsfp.Tables[0].Rows[0]['TOTAL_PRICE'];

            var uads = compatibilitymatchingdetails.GetUserAccess(RegUserEmailId, "", "", "GETCLIENTINFO");
            var uadsval = uads.value;
            if (uadsval.Tables[0].Rows.length > 0)
            {
                if (uadsval.Tables[0].Rows[0]['USER_ACCESS']=="FREE")
                {
                    window.open('compatibilitymatchingreport.aspx?cartid=' + document.getElementById('ctl00_ContentPlaceHolder1_hdncartid').value + '', "_self");
                }
                else
                {
                    window.open('auto_razorpay.aspx?member=' + document.getElementById('ctl00_ContentPlaceHolder1_hdncartid').value + '&amount=' + totalprice + '&clientemailid=' + RegUserEmailId + '&group=' + document.getElementById("ctl00_ContentPlaceHolder1_hdngroup_u").value.toUpperCase() + '&PaymentFor=KUNDALI_MATCHING', "_self");
                }
            }
        }
    }
    else {
        window.open('auto_razorpay.aspx?member=' + document.getElementById('ctl00_ContentPlaceHolder1_hdncartid').value + '&amount=' + totalprice + '&clientemailid=' + RegUserEmailId + '&group=' + document.getElementById("ctl00_ContentPlaceHolder1_hdngroup_u").value.toUpperCase() + '&PaymentFor=KUNDALI_MATCHING', "_self");
    }

    //window.open('compatibilitymatchingreport.aspx?BoyId=' + BoyID + '&GirlId=' + GirlID + '', "_self");
}