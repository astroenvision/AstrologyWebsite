var StateID = "";
var City = "";
var Flag = "";

/*********** Check Method **************************/
function CheckMethod(GetID) {
    try {
        if ($("#Address_" + GetID).prop("checked")) {
            $("#ctl00_ContentPlaceHolder1_hdnAddressID").val(GetID);
        }
        else {
            $("#ctl00_ContentPlaceHolder1_hdnAddressID").val('');
        }
    }
    catch (ex) {
        alert(ex);
        return;
    }
}

/*********** On Edit Click **************************/
function OnEditClick(Id)
{
    try{
        $.ajax({
            type: "POST",
            url: "CommonMethod.aspx/GetAddressByID",
            contentType: "application/json; charset=utf-8",
            data: "{'ShippingId':'" + Id + "'}",
            dataType: "json",
          
            success: function (result) {
                var dsmainData = "";
                dsmainData = $.parseJSON(result.d);
                $("#ctl00_ContentPlaceHolder1_divAllAddress").empty();
                $("#ctl00_ContentPlaceHolder1_divAllAddress").hide();
                $("#ctl00_ContentPlaceHolder1_DivAddNewAddress").show();
                 LoadData(dsmainData);
            },
            error: function (error) {
                alert(error.responseText);
             },
        });
    }
    catch(ex)
    {
        alert(ex);
        return;
    }
}

/*********** Load Data **************************/
function LoadData(ds)
{
    try
    {
        Flag = 'Edit';
        $("#ctl00_ContentPlaceHolder1_txtname").val(ds[0].USER_NAME);
        $("#ctl00_ContentPlaceHolder1_txtMobileNo").val(ds[0].MOBILE_NO);
        $("#ctl00_ContentPlaceHolder1_txtAlternateNo").val(ds[0].ALT_MOBILE_NO);
        $("#ctl00_ContentPlaceHolder1_txtLandmark").val(ds[0].LANDMARK);
        $("#ctl00_ContentPlaceHolder1_txtAddress").val(ds[0].ADDRESS);
        $("#ctl00_ContentPlaceHolder1_ddlCountry").val(ds[0].COUNTRY);
        StateID = ds[0].STATE;
        City = ds[0].CITY;
        ddlCountryChange();
        ddlStateChange();
        $('#ctl00_ContentPlaceHolder1_hdnCity').val(City);
        $("#ctl00_ContentPlaceHolder1_ddlCity").val(ds[0].CITY);
        $("#ctl00_ContentPlaceHolder1_txtpincode").val(ds[0].PIN_CODE);
        var radio = $("[id*=ctl00_ContentPlaceHolder1_rdAddressType] label:contains('" + ds[0].ADDRESS_TYPE + "')").closest("td").find("input");
        radio.attr("checked", "checked");
        $("#ctl00_ContentPlaceHolder1_hdnAddressID").val(ds[0].SHIPPING_ID);
        $("#ctl00_ContentPlaceHolder1_hdnFlag").val(Flag);
        $("#ctl00_ContentPlaceHolder1_lnkContinue").text("Update and Continue");
        $("#ctl00_ContentPlaceHolder1_lnkContinue").show();
        $("#ctl00_ContentPlaceHolder1_lnkContinueWithAddress").hide();
    }
    catch(ex)
    {
        alert(ex);
        return;
    }
}

/*********** Delete Product **************************/
function DeleteProduct(ProductId) {
    try {
        $.ajax({
            url: 'CommonMethod.aspx/DeleteProduct',
            type: 'POST',
            data: "{ 'ProductId': '" + ProductId + "'}",
            contentType: 'application/json; charset=utf-8',
            dataType: "json",
            success: function (result) {
                if (result.d == "1") {
                    alert("Product Delete Sucessfully!!!")
                    window.location = "CheckOut.aspx";
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

/*************** Country Change  *********************/
function ddlCountryChange() {
    try {
        $('#ctl00_ContentPlaceHolder1_ddlState').empty();
        var CountryID = $("#ctl00_ContentPlaceHolder1_ddlCountry").val();
        $('#ctl00_ContentPlaceHolder1_hdnCountry').val(CountryID);
        $.ajax({
            type: "POST",
            url: "CommonMethod.aspx/GetStateData",
            contentType: "application/json; charset=utf-8",
            data: "{'CountryCode':'" + CountryID + "'}",
            dataType: "json",
            beforeSend: function () {
                var html = '<div class="loading">'
                    //+ '<div class="loader-custom-inner">'
                    + '<img src="/astrology/img/Loader.gif" alt="Loading Image" title="Loading Image" />'
                    + '</div>'
                //+ '</div>';
                $("#dvLoaderConnnetion").html(html);
                $("#dvLoaderConnnetion").show();
            },
            success: function (result) {
                var dsmain = "";
                dsmain = $.parseJSON(result.d);
                BindState(dsmain);
                //$("#dvLoaderConnnetion").hide();
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
        var State_ID = $("#ctl00_ContentPlaceHolder1_ddlState").val();
        if (Flag == 'Edit') {
            State_ID = StateID;
        }
        $('#ctl00_ContentPlaceHolder1_hdnState').val(State_ID);
        $.ajax({
            type: "POST",
            url: "CommonMethod.aspx/GetCityData",
            contentType: "application/json; charset=utf-8",
            data: "{'CountryCode':'" + CountryID + "' , 'StateCode': '" + State_ID + "'}",
            dataType: "json",
            beforeSend: function () {
                var html = '<div class="loading">'
                    //+ '<div class="loader-custom-inner">'
                    + '<img src="/astrology/img/Loader.gif" alt="Loading Image" title="Loading Image" />'
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
function BindState(ds) {
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
        if (Flag == 'Edit')
        {
            $("#ctl00_ContentPlaceHolder1_ddlState").val(StateID);
        }
        else
        {
            $("#ctl00_ContentPlaceHolder1_ddlState").focus();
        }
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
                //$("#ddlState").append($("<option></option>").val(ds[i].LOC_ID).html(ds[i].LOC_NAME));
            }
        }
        else {
            objadscat.options[0] = new Option("Select City", "-1");
            return false;
        }
       
        if (Flag == 'Edit') {
            $("#ctl00_ContentPlaceHolder1_ddlCity").val(City);
        }
        else {
            $("#ctl00_ContentPlaceHolder1_ddlCity").focus();
        }
        return false;
    }
    catch (ex) {
        alert(ex);
        return false;
    }
}


/*************** Bind City Change *********************/
function ddlCityChange() {
    try {
        var CityID = $("#ctl00_ContentPlaceHolder1_ddlCity").val();
        $('#ctl00_ContentPlaceHolder1_hdnCity').val(CityID);
    }
    catch (ex) {
        alert(ex);
        return false;
    }
}