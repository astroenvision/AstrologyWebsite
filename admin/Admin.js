var Flag = "";

/*************** Country Change  *********************/
function ddlCountryChange(Flag) {
    try {
        $('#ctl00_ContentPlaceHolder1_ddlState').empty();
        var CountryID = $("#ctl00_ContentPlaceHolder1_ddlCountry").val();
        var pageUrl = document.location.origin;
        if (pageUrl.indexOf('localhost') > -1) {
            pageUrl = pageUrl + '/astrology'
        }
        else {
            pageUrl = "";
        }
        $.ajax({
            type: "POST",
            url: pageUrl + "/CommonMethod.aspx/GetStateData",
            contentType: "application/json; charset=utf-8",
            data: "{'CountryCode':'" + CountryID + "'}",
            dataType: "json",
            beforeSend: function () {
                var html = '<div class="loading">'
                    //+ '<div class="loader-custom-inner">'
                    + '<img src="/astrology/img/Loader.gif" alt="Astro" />'
                    + '</div>'
                //+ '</div>';
                $("#dvLoaderConnnetion").html(html);
                $("#dvLoaderConnnetion").show();
            },
            success: function (result) {
                var dsmain = "";
                dsmain = $.parseJSON(result.d);
                BindState(dsmain, Flag);
                $("#dvLoaderConnnetion").hide();
            },
            error: function (error) {
                alert(error.responseText);
            },
        });
    }
    catch (ex) {
        alert(ex);
        return false;
    }
}

/*************** State Change  *********************/
function ddlStateChange() {
    try {
        $('#ctl00_ContentPlaceHolder1_ddlCity').empty();
        var CountryID = $("#ctl00_ContentPlaceHolder1_ddlCountry").val();
        var StateID = $("#ctl00_ContentPlaceHolder1_ddlState").val();
        $('#ctl00_ContentPlaceHolder1_hdnState').val(StateID);
        var pageUrl = document.location.origin;
        if (pageUrl.indexOf('localhost') > -1) {
            pageUrl = pageUrl + '/astrology'
        }
        else {
            pageUrl = "";
        }
        $.ajax({
            type: "POST",
            url: pageUrl + "/CommonMethod.aspx/GetCityData",
            contentType: "application/json; charset=utf-8",
            data: "{'CountryCode':'" + CountryID + "' , 'StateCode': '" + StateID + "'}",
            dataType: "json",
            beforeSend: function () {
                var html = '<div class="loading">'
                    //+ '<div class="loader-custom-inner">'
                    + '<img src="/astrology/img/Loader.gif" alt="Astro" />'
                    + '</div>'
                //+ '</div>';
                $("#dvLoaderConnnetion").html(html);
                $("#dvLoaderConnnetion").show();
            },
            success: function (result) {
                var dsmainData = "";
                dsmainData = $.parseJSON(result.d);
                BindCity(dsmainData);
                $("#dvLoaderConnnetion").hide();
            },
            error: function (error) {
                alert(error.responseText);
                $("#dvLoaderConnnetion").hide();

            },
        });
    }
    catch (ex) {
        alert(ex);
        return false;
    }
}

/*************** Bind State  *********************/
function BindState(ds , flag) {
    try {
        var objadscat = document.getElementById("ctl00_ContentPlaceHolder1_ddlState");
        objadscat.options.length = 0;
        if (ds.length > 0) {
            objadscat.options[0] = new Option("Select State", "-1");
            objadscat.options.length = 1;
            for (var i = 0; i < ds.length; ++i) {
                objadscat.options[objadscat.options.length] = new Option(ds[i].LOC_NAME, ds[i].LOC_ID);
                //$("#ddlState").append($("<option></option>").val(ds[i].LOC_ID).html(ds[i].LOC_NAME));
            }
        }
        else {
            objadscat.options[0] = new Option("Select State", "-1");
            return false;
        }
        if (flag == 'Edit')
        {
            var Country = $("#ctl00_ContentPlaceHolder1_hdnCountry").val();
            if (Country != "") {
                $("#ctl00_ContentPlaceHolder1_ddlCountry").val(Country);
            }
            var value = $("#ctl00_ContentPlaceHolder1_hdnState").val();
            $("#ctl00_ContentPlaceHolder1_ddlState").val(value);
            var City = $("#ctl00_ContentPlaceHolder1_hdnCity").val();
            if (City != "") {
                ddlStateChange();
         }
        }
       $("#ctl00_ContentPlaceHolder1_ddlState").focus();
        return false;
    }
    catch (ex) {
        alert(ex);
        return false;
    }
}

/*************** Bind City  *********************/
function BindCity(dsCity) {
    try {
        var objadscat = document.getElementById("ctl00_ContentPlaceHolder1_ddlCity");
        objadscat.options.length = 0;
        if (dsCity.length > 0) {
            objadscat.options[0] = new Option("Select City", "-1");
            objadscat.options.length = 1;
            for (var i = 0; i < dsCity.length; ++i) {
                objadscat.options[objadscat.options.length] = new Option(dsCity[i].LOC_NAME, dsCity[i].LOC_ID);
             }
        }
        else {
            objadscat.options[0] = new Option("Select City", "-1");
            return false;
        }
        var value = $("#ctl00_ContentPlaceHolder1_hdnCity").val();
        if (value != "")
        {
            $("#ctl00_ContentPlaceHolder1_ddlCity").val(value);
        }
         $("#ctl00_ContentPlaceHolder1_ddlCity").focus();
       return false;
    }
    catch (ex) {
        alert(ex);
        return false;
    }
}

/*************** Bind City Change *********************/
function ddlCityChange()
{
    try
    {
        var CityID = $("#ctl00_ContentPlaceHolder1_ddlCity").val();
         $('#ctl00_ContentPlaceHolder1_hdnCity').val(CityID);
    }
    catch(ex)
    {
        alert(ex);
        return false;
    }
}
