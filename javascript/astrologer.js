var astro_client = "";
var district = "";
var ist = "";
var resprobable = "";
function astro_valid() {
    if (document.getElementById('astro_name').value == "") {
        alert("Please enter Name.");
        document.form1.astro_name.focus();
        return false;
    }

    if (document.getElementById('astro_mmail').value == "") {
        alert("Please enter Main Email.");
        document.form1.astro_mmail.focus();
        return false;
    }

    if (document.getElementById('astro_mob_no').value == "") {
        alert("Please enter Mobile No.");
        document.form1.astro_mob_no.focus();
        return false;
    }

    if (document.getElementById('astro_add').value == "") {
        alert("Please enter Address 1.");
        document.form1.astro_add.focus();
        return false;
    }

    if (document.getElementById('astro_add1').value == "") {
        alert("Please enter Address 2.");
        document.form1.astro_add1.focus();
        return false;
    }

    if (document.getElementById('ddlcunt').value == "0") {
        alert("Please select Country.");
        document.form1.ddlcunt.focus();
        return false;
    }
 if (document.getElementById('sb').value == "Select Subscription") {
        alert("Please select Subscription.");
        document.form1.sb.focus();
        return false;
    }
    if (document.getElementById('zipcode').value == "") {
        alert("Please enter ZipCode.");
        document.form1.zipcode.focus();
        return false;
    }

    if (document.getElementById('password').value == "") {
        alert("Please enter Password.");
        document.form1.password.focus();
        return false;
    }

    if (document.getElementById('ddlcunt').value == "--Select--") {
        alert("Please select Country.");
        document.form1.ddlcunt.focus();
        return false;
    }
}

function group_bind() {
    var astrologer = document.getElementById('hdnuser').value;
    if (astrologer == 'astrology' || astrologer == 'ASTROLOGY' || astrologer == "") {
        // alert('you are admin');
        getopen("login.aspx");
        return false;
    }
    else {
        res = astro_client.searchuser(astrologer, document.getElementById('DropDownList2').value);
         
          if(document.getElementById('DropDownList2').value.toUpperCase()=='HORARY')
          {
             document.getElementById('dobid').innerHTML="Date of Query <font class='star'>*</font>";
             document.getElementById('tobid').innerHTML="Time of Query <font class='star'>*</font>";
             document.getElementById('pobid').innerHTML="Place of Query <font class='star'>*</font>";
             document.getElementById('submit').innerHTML="Calculate Horary Chart";
          }
          if(document.getElementById('DropDownList2').value.toUpperCase()=='NATAL')
          {
             document.getElementById('dobid').innerHTML="Date of Birth <font class='star'>*</font>";
             document.getElementById('tobid').innerHTML="Time of Birth <font class='star'>*</font>";
             document.getElementById('pobid').innerHTML="Place of Birth <font class='star'>*</font>";
             document.getElementById('submit').innerHTML="Calculate Natal Chart";
          }
          callback_drp1(res);
       
        return false;
    }
    return false;
}


function callback_drp1(res) {
    var ds = res.value;
    //var edtn = $("cat");
    var edtn = document.getElementById("cat");
    //Start Deepak comment following lines on 19/06/2020
    //edtn.options.length = 1;
    //edtn.options[0] = new Option("General", "0");
    //edtn.options[1] = new Option("New Group", "1");
    //End Deepak comment following lines on 19/06/2020
    if (ds != null && typeof (ds) == "object" && ds.Tables[1].Rows.length > 0) {
        for (var i = 0; i < ds.Tables[1].Rows.length; i++) {
            edtn.options[edtn.options.length] = new Option(ds.Tables[1].Rows[i].CAT_ID, ds.Tables[1].Rows[i].CAT_ID)
            edtn.options.length;
        }
    }
    return false;
}

function accountuser()
{
    if (document.getElementById('hdncat').value == 'Horary')
    {
        document.getElementById('DropDownList2').value = 'Horary'

    }

    if (document.getElementById('hdncat').value == 'Natal') {
        document.getElementById('DropDownList2').value = 'Natal'

    }
    group_bind();
}
function numeric(event) {
    var strUserAgent = navigator.userAgent.toLowerCase();
    var isIE = strUserAgent.indexOf("msie") > -1;

    if (isIE) {
        if ((event.keyCode >= 48 && event.keyCode <= 57) || event.keyCode == 0 || event.keyCode == 8 || event.keyCode == 47)
            return true;
        else
            alert("Enter Numeric Digits");
        return false;
    }
    else {

        if ((event.which >= 48 && event.which <= 57) || event.which == 0 || event.which == 8 || event.which == 47)
            return true;
        else
            alert("Enter Numeric Digits");
        return false;
    }
}
function trim(stringToTrim) {
return stringToTrim.replace(/^\s+|\s+$/g, "");
}
function cl_dtls() 
{
   
    var sex="";
    if (document.getElementById('DropDownList2').value == "Select Category") {
        alert("Select Group Category !");
        document.form1.DropDownList2.focus();
        return false;
    }
    if (document.getElementById('cat').value == "Select Group") {
        alert("Select Group Name !");
        document.form1.cat.focus();
        return false;
    }  
    
    if (document.getElementById('cl_name').value == "") {
        alert("Please enter Name.");
        document.form1.cl_name.focus();
        return false;
    }
  
   
    var re = "";
    var re1 = "";
    function validateEmail(txtmail) {
         re = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
         return re1=re.test(txtmail);
    }

    if (document.getElementById('txtmail').value == "") {
        alert("Please enter Email.");
        document.form1.txtmail.focus();
        return false;
    }
    else
    {
        validateEmail(document.getElementById('txtmail').value);
        if (re1 == false)
        {
            alert("Please enter valid Email.");
            document.form1.txtmail.focus();
            return false;
        }
    }
    
    if (document.getElementById('dob').value == "") {
        alert("Please enter Date Of Birth.");
        document.form1.dob.focus();
        return false;
    }
    if (document.getElementById('hob').value == "Hours") {
        alert("Select Hours Of Birth!");
        document.form1.hob.focus();
        return false;
    }
   
    if (document.getElementById('hob').value == "Minutes") {
        alert("Select Minutes Of Birth!");
        document.form1.mob.focus();
        return false;
    }
    if (document.getElementById('ddlcunt').value == "") {
        alert("Please enter Country Name.");
        document.form1.ddlcunt.focus();
        return false;
    }

    if (document.getElementById('ddlstat').value == "") {
        alert("Please enter State Name.");
        document.form1.ddlstat.focus();
        return false;
    }

    //if (document.getElementById('ddlcunt').options[document.getElementById('ddlcunt').selectedIndex].text == 'India') {
    //    if (document.getElementById('district').value == "") {
    //        alert("Please enter District Name.");
    //        document.form1.District.focus();
    //        return false;
    //    }
    //}

    if (document.getElementById('city').value == "") {
        alert("Please enter City Name.");
        document.form1.city.focus();
        return false;
    }

    if (document.getElementById('lat').value == "") {
        alert("Please enter Latitude.");
        document.form1.lat.focus();
        return false;
    }

    if (document.getElementById('lng').value == "") {
        alert("Please enter Longitude.");
        document.form1.lng.focus();
        return false;
    }

    if (document.getElementById('tz').value == "") {
        alert("Please enter Time Zone.");
        document.form1.lng.focus();
        return false;
    }


    name = trim(document.getElementById('cl_name').value);
    email = trim(document.getElementById('txtmail').value);

    clname = trim(document.getElementById('cl_name').value);
    clmail = trim(document.getElementById('txtmail').value);


    dateob = trim(document.getElementById('dob').value);
    
    hoursob = trim(document.getElementById('hob').value);
    
    minuteob = trim(document.getElementById('mob').value);
    conob = document.getElementById('ddlcunt').options[document.getElementById('ddlcunt').selectedIndex].text;
    statob = trim(document.getElementById('ddlstat').value);
    distob = trim(document.getElementById('district').value);
    cityob = trim(document.getElementById('city').value);
    lati = trim(document.getElementById('lat').value);
    longi = trim(document.getElementById('lng').value);
    timezone = trim(document.getElementById('tz').value);

    profession = trim(document.getElementById('cl_pro').value);
    
    

    if (document.getElementById('mn').value == "")
    {
        mno = 0;
    }
    else
    {
        mno = document.getElementById('mn').value
    }

     
    if (document.getElementById('male').checked == true) {
        sex = "M"

    }
    else { sex="F"}

   
    if (document.getElementById('cat').selectedIndex == 1)
    {
        if (document.getElementById('catn').value == "")
        {
            alert('Enter Group Name!');
            return false;
        }
        else
        {
            cat_id = trim(document.getElementById('catn').value)
        }
    }
    else
    {
        cat_id = document.getElementById('cat').options[document.getElementById('cat').selectedIndex].text 
    }

    
    cat_grp =document.getElementById('DropDownList2').value;
    if (document.activeElement.id == 'submit') {
        var cd = 1;
    }
    else { var cd = 0; }
    document.getElementById('hdndifftz').value = parseFloat((parseFloat(5.50)) - (parseFloat(document.getElementById('hdntz').value))).toFixed(2);
    
    ist = document.getElementById('hdndifftz').value;
    if (ist == 0)
    { ist3 = 0; }
    else
    {
        var ist1 = ist.split('.');
        var ist2 = ist1[1] * (.6);
        if (ist2 == NaN) {
            ist2 = 0;
        }
        if (ist1[0] <= 0) {
            var ist3 = ist1[0] * 60 - ist2;
        }
        else { var ist3 = ist1[0] * 60 + ist2; }
    }
    var tob = hoursob + ':' + minuteob;
 //  var o= moment.utc(moment('31/12/2014 00:19', "DD/MM/YYYY HH:mm").diff(moment('31/12/2014 01:30', "DD/MM/YYYY HH:mm"))).format("HH:mm")

    var isdres = astro_client.istfind(ist3, tob, dateob);
    var ds = isdres.value;
    daob = ds.Tables[0].Rows[0].IDOB.split(' ');
    idaob=daob[0];
    itaob = daob[1];

    idaob1 = idaob.split('-');
    da1ob = idaob1[0];
    mo1ob = idaob1[1];
    yr1ob = idaob1[2];

    itaob1 = itaob.split(':');
    ihob = itaob1[0];
    imob = itaob1[1];

    var sunsetpre = document.getElementById('hdsunsetpre').value;
    var sunrise = document.getElementById('hdsunrise').value;
    var sunset = document.getElementById('hdsunset').value;
    var sunrisenext = document.getElementById('hdsunrisenext').value;
         
    astro_dtls = document.getElementById('username').value
    astrologer = document.getElementById('hdnuser').value
    if (cat_grp == 'Horary')
    {
        var clmail = clmail +'-'+ da1ob + mo1ob + yr1ob + ihob + imob ;
    }
    var clientquery=document.getElementById('txtquery').value;

    if (document.getElementById('hdnuser').value != "" || document.getElementById('hdnuser').value  != null)
    {
        window.open("homenewpage.aspx?clname=" + clname + "&clmail=" + clmail + "&astmail=" + astrologer + "&astname=" + document.getElementById('hdnastname').value + "&usermail=" + document.getElementById('hdnuser').value + "&group_u=" + cat_grp + "&group=" + cat_id + "&mobile=" + mno + "&dob=" + dateob + "&da1ofb=" + da1ob + "&mo1ofb=" + mo1ob + "&yr1ofb=" + yr1ob + "&tob=" + tob + "&hourofb=" + ihob + "&minuteofb=" + imob + "&country=" + conob + "&state=" + statob + "&dist=" + distob + "&city=" + cityob + "&latit=" + lati + "&longit=" + longi + "&tzo=" + timezone + "&tzoval=" + document.getElementById('hdntz').value + "&prof=" + profession + "&sex=" + sex + "&cd=" + cd  + "&sunsetpre=" + sunsetpre + "&sunrise=" + sunrise  + "&sunset=" + sunset  + "&sunrisenext=" + sunrisenext + "&query="+clientquery+"", null);
        //clear_data();
    }
    else
    {
        Response.Redirect("" + ResolveUrl("~/login.aspx") + "");
    }

}

    function clear_data()
    {
        document.getElementById('cl_name').value= "";
        document.getElementById('cl_pro').value = "";
        
        document.getElementById('mn').value  = "";
        document.getElementById('male').checked=true;
        document.getElementById('DropDownList2').selectedIndex = 0;
        document.getElementById('txtmail').value = "";
        document.getElementById('dob').value = "";
        document.getElementById('hob').value = "";
        document.getElementById('mob').value = "";
        document.getElementById('ddlcunt').value = "";
        document.getElementById('ddlstat').value = "";
        document.getElementById('district').value = "";
        document.getElementById('city').value = "";
        document.getElementById('lat').value = "";
        document.getElementById('lng').value = "";
        document.getElementById('tz').value = "";
    }

function newgroup()
{

if(document.getElementById('cat').selectedIndex == '1')
{
document.getElementById('catn_newgroup').style.display='table-row'
document.getElementById('catn').style.display='block'
return false;}
else{document.getElementById('catn').style.display='none'
return false;}

}



function update_cl_dtls() {
    name = trim(document.getElementById('cl_name').value);
    clname = trim(document.getElementById('cl_name').value);
    profession = trim(document.getElementById('cl_pro').value);
    email = trim(document.getElementById('txtmail').value);
    clmail = trim(document.getElementById('txtmail').value);
       
    if (document.getElementById('mn').value == "") {
        mno = 0;
    }
    else {
        mno = document.getElementById('mn').value
    }

    if ((trim(document.getElementById('cl_age').value)) == "") {
        alert('Select Age!');
        return false;
    }
    age = document.getElementById('cl_age').value
    if (document.getElementById('male').checked == true) {
        sex = "M"

    }
    else { sex = "F" }



       
    cat_id = trim(document.getElementById('cat').value)
    cat_grp = document.getElementById('DropDownList2').value;



    if (document.getElementById('hdnuser').value != "" || document.getElementById('hdnuser').value != null) {
        astrologer = document.getElementById('hdnuser').value
        astro_dtls = document.getElementById('username').value
        res1 = astro_client.update_client(astro_dtls, name, profession, age, sex, astrologer, email, cat_id, mno, cat_grp);

      

        alert('Updated Successfully !');
        window.open("myaccount.aspx?usermail=" + document.getElementById('hdnuser').value + "", null);
        clear_data();
                
        }
        else
        {
            Response.Redirect("" + ResolveUrl("~/login.aspx") + "");
        }
    
    
}

function mr()
{
    document.getElementById('female').checked = false;
    return false;
}

function fr()
{
    document.getElementById('male').checked = false;
    return false;
}


function state(event)
{
    document.getElementById('hdnstate').value = "";
    document.getElementById('city').value = "";
    document.getElementById('lat').value = "";
    document.getElementById('lng').value = "";
   if (event.keyCode == 38 || event.keyCode == 40) {

        if (document.activeElement.id == 'ddlstat') {
            document.getElementById('state_list').focus();
            return false;

        }

       
    }

    if (event.keyCode == 27) {

        if (document.activeElement.id == 'ddlstat') {
            document.getElementById('state_list').style.display = 'none';
            return false;
        }
       
        return false;
    }

   
    var drop_down = document.getElementById('ddlcunt').options[document.getElementById('ddlcunt').selectedIndex].text;

    if (document.activeElement.id == 'ddlstat') {
        filter = document.getElementById('ddlstat').value
       

        
        var drop_down = document.getElementById('ddlcunt').value;
            document.getElementById('district').style.display = 'none';
            document.getElementById('dis').style.display = 'none';
       
        if (filter == "0") {
            document.getElementById("state_list").value = "";
            document.getElementById('state_list').style.display = 'none';
        }
        else {
           
            var res = astro_client.state(filter, drop_down, exec_gridcall);
            return false;
        }
    }
    return false;
}


function districtt(event) {
    document.getElementById('hdndistrict').value = "";
    document.getElementById('city').value = "";
    document.getElementById('lat').value = "";
    document.getElementById('lng').value = "";
    if (event.keyCode == 38 || event.keyCode == 40) {

        if (document.activeElement.id == 'district') {
            document.getElementById('district_list').focus();
            return false;

        }


    }

    if (event.keyCode == 27) {

        if (document.activeElement.id == 'district') {
            document.getElementById('district_list').style.display = 'none';
            return false;
        }

        return false;
    }


    var drop_down = document.getElementById('ddlcunt').options[document.getElementById('ddlcunt').selectedIndex].text;
    var state = document.getElementById('ddlstat').value;

    if (document.activeElement.id == 'district') {
        filter = document.getElementById('district').value
        if (filter == "0") {
            document.getElementById("district_list").value = "";
            document.getElementById('district_list').style.display = 'none';
        }
        else {

            var res = astro_client.districtt(drop_down, state,filter, exec_gridcall);
            return false;
        }
    }
    return false;
}





function openroot(event) {
    if (event.keyCode == 38 || event.keyCode == 40) {

        if (document.activeElement.id == 'city') {
            document.getElementById('city_list').focus();
            return false;

        }

       
    }

    if (event.keyCode == 27) {

        if (document.activeElement.id == 'city') {
            document.getElementById('city_list').style.display = 'none';
            return false;
        }
       
        return false;
    }

    if (event.keyCode == 13) {

      $(document).ready(function () {

            var geocoder = new google.maps.Geocoder();
            var con = document.getElementById('ddlcunt').options[document.getElementById('ddlcunt').selectedIndex].text;
    var state = document.getElementById('hdnstate').value
      if(con=='India')
    {
     district = document.getElementById('hdndistrict').value
}
else
{
var con = document.getElementById('ddlcunt').value;
}
    var city = document.getElementById('city').value

            
            var com = city + "," +district+"," + state + "," + con;
            geocoder.geocode({ 'address': com }, function (results, status) {
                if (status == google.maps.GeocoderStatus.OK) {
                    document.getElementById('hdnlat').value = results[0].geometry.location.lat();
                    var lat = document.getElementById('hdnlat').value
                    var lat1 = lat.split('.');
                    var lat2 = lat1[1] * 60;
                    var lat3 = lat1[0] + '.' + lat2;
                    document.getElementById('hdnlng').value = results[0].geometry.location.lng();
                    var lng = document.getElementById('hdnlng').value
                    var lng1 = lng.split('.');
                    var lng2 = lng1[1] * 60;
                    var lng3 = lng1[0] + '.' + lng2;

                    document.getElementById('lat').value = lat3;
                    document.getElementById('lng').value = lng3;

                } else {
                    alert("Wrong Details: " + status);
                }
            });

      });


    }
    var con = document.getElementById('ddlcunt').options[document.getElementById('ddlcunt').selectedIndex].text;
    var state = document.getElementById('hdnstate').value
  
var con = document.getElementById('ddlcunt').value;

    if (document.activeElement.id == 'city') {
       var city = document.getElementById('city').value
        if (filter == "0") {
            document.getElementById("city_list").value = "";
            document.getElementById('city_list').style.display = 'none';
        }
        else {
            var res = astro_client.citys(con, state, district, city, exec_gridcall);
            return false;
        }
    }
    return false;

}



var dsgrid = "";
function exec_gridcall(val) {

    dsgrid = val.value;
    // var dsgrid = exec_grid


    if (document.activeElement.id == 'city') {
        if (dsgrid.Tables[0].Rows.length > 0) {

            document.getElementById('city_list').style.display = 'block';

            var pkgitem = document.getElementById("city_list");

            pkgitem.options.length = 0;
            pkgitem.options[0] = new Option("-Select City-", "0");
            pkgitem.options.length = 1;

            for (var i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
                pkgitem.options[pkgitem.options.length] = new Option(dsgrid.Tables[0].Rows[i].LOC_NAME, dsgrid.Tables[0].Rows[i].LOC_ID);
                pkgitem.options.length;
            }
            var aTag = eval(document.getElementById('city'))
            var btag;
            var leftpos = 0;
            var toppos = 0;

            do {
                aTag = eval(aTag.offsetParent);

                leftpos += aTag.offsetLeft;
                toppos += aTag.offsetTop;
                btag = eval(aTag)

            }
            while (aTag.tagName != "BODY" && aTag.tagName != "HTML");

            var tot = document.getElementById('list_div').scrollLeft;

            var scrolltop = document.getElementById('list_div').scrollTop;
            document.getElementById('list_div').style.display = 'block';

            document.getElementById('list_div').style.left = document.getElementById('city').offsetLeft + leftpos - tot + "px";
            document.getElementById('list_div').style.top = document.getElementById('city').offsetTop + toppos - scrolltop + "px";
            //document.getElementById('root').focus();

            return false;
        }
        else {
            document.getElementById("city_list").value = "";
            document.getElementById('list_div').style.display = 'none';
            return false;
        }
    }


    if (document.activeElement.id == 'ddlstat') {
        if (dsgrid.Tables[0].Rows.length > 0) {

            document.getElementById('state_list').style.display = 'block';

            var pkgitem = document.getElementById("state_list");

            pkgitem.options.length = 0;
            pkgitem.options[0] = new Option("-Select State-", "0");
            pkgitem.options.length = 1;

            for (var i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
                pkgitem.options[pkgitem.options.length] = new Option(dsgrid.Tables[0].Rows[i].LOC_NAME, dsgrid.Tables[0].Rows[i].LOC_ID);
                pkgitem.options.length;
            }
            var aTag = eval(document.getElementById('ddlstat'))
            var btag;
            var leftpos = 0;
            var toppos = 0;

            do {
                aTag = eval(aTag.offsetParent);

                leftpos += aTag.offsetLeft;
                toppos += aTag.offsetTop;
                btag = eval(aTag)

            }
            while (aTag.tagName != "BODY" && aTag.tagName != "HTML");

            var tot = document.getElementById('list_state').scrollLeft;

            var scrolltop = document.getElementById('list_state').scrollTop;
            document.getElementById('list_state').style.display = 'block';

            document.getElementById('list_state').style.left = document.getElementById('ddlstat').offsetLeft + leftpos - tot + "px";
            document.getElementById('list_state').style.top = document.getElementById('ddlstat').offsetTop + toppos - scrolltop + "px";
            //document.getElementById('root').focus();

            return false;
        }
        else {
            document.getElementById("state_list").value = "";
            document.getElementById('list_state').style.display = 'none';
            return false;
        }
    }

    if (document.activeElement.id == 'district') {
        if (dsgrid.Tables[0].Rows.length > 0) {

            document.getElementById('district_list').style.display = 'block';

            var pkgitem = document.getElementById("district_list");

            pkgitem.options.length = 0;
            pkgitem.options[0] = new Option("-Select District-", "0");
            pkgitem.options.length = 1;

            for (var i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
                pkgitem.options[pkgitem.options.length] = new Option(dsgrid.Tables[0].Rows[i].LOC_NAME, dsgrid.Tables[0].Rows[i].LOC_ID);
                pkgitem.options.length;
            }
            var aTag = eval(document.getElementById('district'))
            var btag;
            var leftpos = 0;
            var toppos = 0;

            do {
                aTag = eval(aTag.offsetParent);

                leftpos += aTag.offsetLeft;
                toppos += aTag.offsetTop;
                btag = eval(aTag)

            }
            while (aTag.tagName != "BODY" && aTag.tagName != "HTML");

            var tot = document.getElementById('list_district').scrollLeft;

            var scrolltop = document.getElementById('list_district').scrollTop;
            document.getElementById('list_district').style.display = 'block';

            document.getElementById('list_district').style.left = document.getElementById('district').offsetLeft + leftpos - tot + "px";
            document.getElementById('list_district').style.top = document.getElementById('district').offsetTop + toppos - scrolltop + "px";
            //document.getElementById('root').focus();

            return false;
        }
        else {
            document.getElementById("district_list").value = "";
            document.getElementById('list_district').style.display = 'none';
            return false;
        }
    }
}


function insert_data(id) {

    if (document.activeElement.id == 'city_list') {

        document.getElementById('city_list').style.display = 'none';
        var spl = document.getElementById('city_list').options[document.getElementById('city_list').selectedIndex].innerHTML;
        spl = spl.split('~');
        f = "";
        for (var i = 1; i < spl.length; i++) {
            f = f + spl[i] + '~';
        }
        f = f.slice(0, -1);
        document.getElementById('city').value = spl[0];
        var con = document.getElementById('ddlcunt').options[document.getElementById('ddlcunt').selectedIndex].text;
        var state = document.getElementById('hdnstate').value
    
        var con = document.getElementById('ddlcunt').value;


        var res = astro_client.latlng(con, state, district, document.getElementById('city').value);
        var ds=res.value;
        

                        document.getElementById('lat').value = ds.Tables[0].Rows[0].LATITUDE;
                        document.getElementById('lng').value = ds.Tables[0].Rows[0].LONGITUDE;

                        //document.getElementById('hdnlat').value = ds.Tables[0].Rows[0].LATITUDE;
                        //var lat = document.getElementById('hdnlat').value
                        //var lat1 = lat.split('.');
                        //var lat2 = lat1[1] * 60;
                        //var lat3 = lat1[0] + '.' + lat2;
                        //document.getElementById('hdnlng').value = ds.Tables[0].Rows[0].LONGITUDE;
                        //var lng = document.getElementById('hdnlng').value
                        //var lng1 = lng.split('.');
                        //var lng2 = lng1[1] * 60;
                        //var lng3 = lng1[0] + '.' + lng2;

                        //document.getElementById('lat').value = lat3;
                        //document.getElementById('lng').value = lng3;






                        var dob1 = document.getElementById('dob').value;
                        var tzid = ds.Tables[0].Rows[0].TIMEZONEID;
                      if(tzid==undefined)
                      {
                          tzid = 'Asia/Kolkata'
                       }
                      var res = astro_client.timezone(tzid, dob1);
                        var ds1=res.value;
                        document.getElementById('hdntz').value = ds1.Tables[0].Rows[0].TIMEZONE;
                        var stz = document.getElementById('hdntz').value;
                       var stz1=stz.split('.');
                    if(stz1.length>1){   
                        var stz2=stz1[1]*6;
                        var stz3=stz1[0]+'.'+stz2;
                        document.getElementById('tz').value = stz3;
                        
                     }
                    else
                     {              
                     document.getElementById('tz').value = stz1[0];
                    }

                    var d1 = dob1.split('/')

                    var res = astro_client.getsunsetsunrise(document.getElementById('lat').value, document.getElementById('lng').value, document.getElementById('username').value, d1[1]+'/'+d1[0]+'/'+d1[2] + ' ' + '1:00:42 AM')

                    var sssr = res.value;
                    var srss1 = sssr.split('\r\n')
                    var sr = srss1[0];
                    var ss = srss1[1];
                    var res = astro_client.getsunsetsunrisea(sr, document.getElementById('hdntz').value, ss,d1[1]+'/'+d1[0]+'/'+d1[2] + ' ' + '1:00:42 AM')
                    var actsrss = res.value;
                    var sunrise = actsrss.Tables[0].Rows[0].IDOB;
                    var sunset = actsrss.Tables[1].Rows[0].IDOB;
                    
                    document.getElementById('hdsunrise').value=sunrise;
                    document.getElementById('hdsunset').value=sunset;

                    var res = astro_client.getsunsetsunrise1(document.getElementById('lat').value, document.getElementById('lng').value, document.getElementById('username').value, d1[1] + '/' + d1[0] + '/' + d1[2] + ' ' + '1:00:42 AM')

                    var sssr = res.value;
                    var srss1 = sssr.split('\r\n')
                    var sr = srss1[0];
                    var ss = srss1[1];
                    
                    var res = astro_client.getsunsetsunriseanext(sr, document.getElementById('hdntz').value, ss,d1[1]+'/'+d1[0]+'/'+d1[2] + ' ' + '1:00:42 AM')
                    var actsrss = res.value;
                    var sunrisenextday = actsrss.Tables[0].Rows[0].IDOB;
                    hoursob = trim(document.getElementById('hob').value);
                    document.getElementById('hdsunrisenext').value=sunrisenextday;

                    var res = astro_client.getsunsetsunrise2(document.getElementById('lat').value, document.getElementById('lng').value, document.getElementById('username').value, d1[1] + '/' + d1[0] + '/' + d1[2] + ' ' + '1:00:42 AM')
                    var ssopd = res.value;
                    var ssopd1 = ssopd.split('\r\n')
                    var sr = ssopd1[0];
                    var ss = ssopd1[1];
                    
                    var res = astro_client.getsunsetsunriseapre(sr, document.getElementById('hdntz').value, ss,d1[1]+'/'+d1[0]+'/'+d1[2] + ' ' + '1:00:42 AM')
                    var actsrss = res.value;
                    var sunsetpreday = actsrss.Tables[1].Rows[0].IDOB;
                    document.getElementById('hdsunsetpre').value=sunsetpreday;
                    
                    
                    minuteob = trim(document.getElementById('mob').value);
                    var tob = d1[1] + '/' + d1[0] + '/' + d1[2] + ' ' + hoursob + ':' + minuteob;
                    var user = document.getElementById('hdnuser').value;
                    resprobable = astro_client.getdinrat(sunset, sunrise, sunrisenextday, tob, user)
                    
    }


    if (document.activeElement.id == 'state_list') {

        document.getElementById('state_list').style.display = 'none';
        var spl = document.getElementById('state_list').options[document.getElementById('state_list').selectedIndex].innerHTML;
        spl = spl.split('~');
        f = "";
        for (var i = 1; i < spl.length; i++) {
            f = f + spl[i] + '~';
        }
        f = f.slice(0, -1);
        document.getElementById('ddlstat').value = spl[0];
        document.getElementById('hdnstate').value= document.getElementById('state_list').options[document.getElementById('state_list').selectedIndex].value;

    }

    if (document.activeElement.id == 'district_list') {

        document.getElementById('district_list').style.display = 'none';
        var spl = document.getElementById('district_list').options[document.getElementById('district_list').selectedIndex].innerHTML;
        spl = spl.split('~');
        f = "";
        for (var i = 1; i < spl.length; i++) {
            f = f + spl[i] + '~';
        }
        f = f.slice(0, -1);
        document.getElementById('district').value = spl[0];
        document.getElementById('hdndistrict').value = document.getElementById('district_list').options[document.getElementById('district_list').selectedIndex].value;


        
    }
   
}

function probquery()
{
    
    var exec_data = resprobable.value;
    if (exec_data.Tables[0].Rows.length > '0') {

        dsgrid = exec_data;
        document.getElementById('hdsviewgrid').innerHTML = "";
        document.getElementById('Divgrid1').style.display = "none";

        document.getElementById('hdsviewgrid').innerHTML = "";
        document.getElementById('Divgrid1').style.display = 'block';
        $('Divgrid1').display = 'block;'


        document.getElementById('Divgrid1').style.BackColor = "Ivory";
        var temp_del1 = "";

        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;
        document.getElementById('clinetnamediv').style.display = "block";
        
        document.getElementById('hdsviewgrid').style.display = "block";

        if (document.getElementById("hdsviewgrid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("Divgrid1").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:468px !important;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='468px !important' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
     
        buf2 += "<td class='colum-td-heada'>" + "Result" + "</td>"

        buf2 += "</tr>"
        len = 1;

        if (dsgrid.Tables[0].Rows.length > 0) {

            for (i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {


                buf2 += "<tr>"

                buf2 += "<td class='colum-td-newhc'>"
                buf2 += "<font width='90px' >" + (dsgrid.Tables[0].Rows[i]['DESCCLOB']) + "</font>"
                buf2 += "<input type='hidden'  id=desc_" + i + "  value =" + (dsgrid.Tables[0].Rows[i]['DESCCLOB']) + "> "
                buf2 += "</td>"

                buf2 += "</tr>"

            }
        }

        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        document.getElementById('hdsviewgrid').innerHTML = temp_del1;
        buf2 = "";
        temp_del1 = "";
    }

    return false;

    

}

function creossdiv() {
    document.getElementById('clinetnamediv').style.display = 'none';
    document.getElementById('hdsviewgrid').innerHTML = "";
    return false;
}
function insert_lat(id)
{
     c = document.getElementById('hdncit').value;
   
    var res = Birth_Detail.latlng(c);
    call_lat(res);
    

}

function call_lat(res) {
    var flag = 0;
    var city1 = "";
    dsgrid = res.value;

    if (dsgrid != null) {

       
        var con = dsgrid.Tables[0].Rows[0].COUNTRY_NAME;
        var state = dsgrid.Tables[0].Rows[0].STATE_NAME;
        var city = dsgrid.Tables[0].Rows[0].CITY_NAME;
        var conco = dsgrid.Tables[0].Rows[0].COUNTRY_CODE;
        var stateco = dsgrid.Tables[0].Rows[0].STATE_CODE;

        document.getElementById('hdncit').value = city;
        var com = city + "," + state + "," + con ;
        flag = 1;
    }
    var geocoder = new google.maps.Geocoder();
        geocoder.geocode({ 'address': com }, function (results, status) {
            if (status == google.maps.GeocoderStatus.OK) {
                var latf = results[0].geometry.location.lat();
                var lngf = results[0].geometry.location.lng();
                Birth_Detail.updatelatlng(latf, lngf, conco, stateco, city);
                flag = 0;
                document.getElementById('hdncit').value =  city;
                insert_lat(flag);
                
            } else {
                //alert("Wrong Details: " + status);
                flag = 0;
                
                document.getElementById('hdncit').value =  city ;
                insert_lat(flag);
                //insert_lat();
            }
        });
        if (flag == 0) {
           
           
            return false;
        }
   
}