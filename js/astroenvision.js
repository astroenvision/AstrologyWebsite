var ds = "";
var dsCity = "";
/*************** Window Load *********************/
//$(window).load(function () {
//    try {
        
//        AddToCart("","","GetTotalCount");
//        return false;
//    }
//    catch (ex) {
//        alert(ex);
//        return false;
//    }
//});
/*************** Add To Cart *********************/
function AddToCart(CatName,CatID, GroupID, flag) {
    var pageUrl = document.location.origin;
    if (pageUrl.indexOf('localhost') > -1) {
        pageUrl = pageUrl + '/astrology'
    }
    else
    {
        pageUrl = "";
    }
    $.ajax({
        url: pageUrl + '/CommonMethod.aspx/AddToCart',
        type: 'POST',
        data: "{ 'CatName': '" + CatName + "','CatId': '" + CatID + "', 'GroupId': '" + GroupID + "' , 'Flag': '" + flag + "'}",
        contentType: 'application/json; charset=utf-8',
        dataType: "json",
        success: function (result) {
            if (result.d == "0") {
                //window.location = "signin.html";
                $('#addtocartmsg').hide();
            }
            else {
                var strmsg = "<a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a><i class=\"fa fa-check-circle fchk\"></i><strong>" + CatName + "</strong> added to your cart <a href=\"CheckOutCart.html\" class=\"kwm-btn-white ml-2\">Proceed to Checkout</a>";
                $("#addtocartmsg").html(strmsg);
                $("#addtocartmsg").show();
                setTimeout(function () { $("#addtocartmsg").fadeOut(1500); }, 3000);

                //document.getElementById('cartid').innerHTML = result.d;
              }
            //document.getElementById('ctl00_cartid').Text = result.d;
            $("#ctl00_cartid").text(result.d);
       },
        error: function (error) {
            alert(error.responseText);
        },
        async: false
    });
};

/*************** Logout Function *********************/
function Logout() {
    $.ajax({
        url: 'CommonMethod.aspx/Logout',
        type: 'POST',
        contentType: 'application/json; charset=utf-8',
        dataType: "json",
        success: function (result) {
           if (result.d == "1") {
                 window.location = "index.html";
                       }
        },
        error: function (error) {
            alert(error.responseText);
        },
        async: false
    });
};

/*************** Delete Category  *********************/
function DeleteCategory(CartId,CatId) {
    try {
       $.ajax({
            url: 'CommonMethod.aspx/DeleteCategoryID',
            type: 'POST',
            data: "{ 'CartId': '" + CartId + "','CatId': '" + CatId + "'}",
            contentType: 'application/json; charset=utf-8',
            dataType: "json",
            success: function (result) {
                if (result.d == "1") {
                    alert("Category delete successfully!!!")
                    window.location = "CheckOutCart.html";
                }
            },
            error: function (error) {
                alert(error.responseText);
            },
            async: false
        });
    }
    catch (ex) {
        alert(ex);
        return false;
    }
}


/*************** Buy Report *********************/
function BuyReport(CatName,CatID, GroupID, flag) {

    var pageUrl = document.location.origin;
    if (pageUrl.indexOf('localhost') > -1) {
        pageUrl = pageUrl + '/astrology'
    }
    else
    {
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
};


/***************Admin Logout Function *********************/
function AdminLogout(StateManagementType, CookieTimeoutType, CookieTimeout) {
    var pageUrl = document.location.origin;
    if (pageUrl.indexOf('localhost') > -1) {
        pageUrl = pageUrl + '/astrology'
    }
    else {
        pageUrl = "";
    }
    $.ajax({
        url: pageUrl + '/CommonMethod.aspx/AdminLogout',
        type: 'POST',
        data: "{'StateManagementType': '" + StateManagementType + "','CookieTimeoutType': '" + CookieTimeoutType + "','CookieTimeout': '" + CookieTimeout + "'}",
        contentType: 'application/json; charset=utf-8',
        dataType: "json",
        success: function (result) {
            if (result.d == "1") {
                window.location = pageUrl + "/admin/";
            }
        },
        error: function (error) {
            alert(error.responseText);
        },
        async: false
    });
};



/***************Function For Reverse Countdown*********************/

window.onload = function () {
    var myElem = document.getElementById('ctl00_HdnCookieEnd');
    if (myElem != null)
    {
        var CookieEndTime = new Date(document.getElementById('ctl00_HdnCookieEnd').value).getTime();
        var CookieStartTime = new Date(document.getElementById('ctl00_HdnCookieStart').value).getTime();
        var sss = msToTime(CookieEndTime - CookieStartTime);
        setInterval(startTimer, 1000);
        document.getElementById("time").innerHTML = sss.toString();
    }
};

function startTimer() {
    var CookieEndTime = new Date(document.getElementById('ctl00_HdnCookieEnd').value).getTime();
    var CookieStartTime = new Date().getTime();
    var sss = msToTime(CookieEndTime - CookieStartTime);
    document.getElementById("time").innerHTML = sss.toString();
}

function msToTime(duration) {
    var milliseconds = parseInt((duration % 1000) / 100),
      seconds = Math.floor((duration / 1000) % 60),
      minutes = Math.floor((duration / (1000 * 60)) % 60),
      hours = Math.floor((duration / (1000 * 60 * 60)) % 24);

    hours = (hours < 10) ? "0" + hours : hours;
    minutes = (minutes < 10) ? "0" + minutes : minutes;
    seconds = (seconds < 10) ? "0" + seconds : seconds;
    //return hours + ":" + minutes + ":" + seconds + "." + milliseconds;
    return hours + ":" + minutes + ":" + seconds;
}

