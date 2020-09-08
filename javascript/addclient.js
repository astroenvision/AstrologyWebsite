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
          res = addclient.searchuser(astrologer, document.getElementById('DropDownList2').value);
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
    edtn.options.length = 1;
    edtn.options[0] = new Option("General", "0");
    edtn.options[1] = new Option("New Group", "1");
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

//    if (document.getElementById('ddlstat').value == "") {
//        alert("Please enter State Name.");
//        document.form1.ddlstat.focus();
//        return false;
//    }

//    //if (document.getElementById('ddlcunt').options[document.getElementById('ddlcunt').selectedIndex].text == 'India') {
//    //    if (document.getElementById('district').value == "") {
//    //        alert("Please enter District Name.");
//    //        document.form1.District.focus();
//    //        return false;
//    //    }
//    //}

//    if (document.getElementById('city').value == "") {
//        alert("Please enter City Name.");
//        document.form1.city.focus();
//        return false;
//    }

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

    var isdres = addclient.istfind(ist3, tob, dateob);
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
        // Uncomment following line by deepak on 16-06-2020
        window.open("homenewpage.aspx?clname=" + clname + "&clmail=" + clmail + "&astmail=" + astrologer + "&astname=" + document.getElementById('hdnastname').value + "&usermail=" + document.getElementById('hdnuser').value + "&group_u=" + cat_grp + "&group=" + cat_id + "&mobile=" + mno + "&dob=" + dateob + "&da1ofb=" + da1ob + "&mo1ofb=" + mo1ob + "&yr1ofb=" + yr1ob + "&tob=" + tob + "&hourofb=" + ihob + "&minuteofb=" + imob + "&country=" + conob + "&state=" + statob + "&dist=" + distob + "&city=" + cityob + "&latit=" + lati + "&longit=" + longi + "&tzo=" + timezone + "&tzoval=" + document.getElementById('hdntz').value + "&prof=" + profession + "&sex=" + sex + "&cd=" + cd  + "&sunsetpre=" + sunsetpre + "&sunrise=" + sunrise  + "&sunset=" + sunset  + "&sunrisenext=" + sunrisenext + "&query="+clientquery+"", null);
        clear_data();
        
        document.getElementById('SPhdngroup').value=cat_id;
        document.getElementById('hdngroup_u').value=cat_grp;
        document.getElementById('hdnlongit').value=longi;
        document.getElementById('hdnlatit').value=lati;
        document.getElementById('hdntzo').value=timezone;
        document.getElementById('Hastmail').value=astrologer;
        
        document.getElementById('hdncountry').value=conob;
        document.getElementById('SPhdnstate').value=statob;
        document.getElementById('SPhdndist').value=distob;
        document.getElementById('SPhdncity').value=cityob;
        document.getElementById('SPhdnprof').value=profession;
        document.getElementById('hdnsex').value=sex;
        document.getElementById('hdnmobile').value=mno;
        
        document.getElementById('hdnmoc').value=cd;
        document.getElementById('hdndob').value=dateob;
        document.getElementById('hdnidob').value=da1ob;
        document.getElementById('hdnimoob').value=mo1ob;
        document.getElementById('hdniyob').value=yr1ob;
        document.getElementById('hdntob').value=tob;
        document.getElementById('hdnihob').value=ihob;
        document.getElementById('hdnimob').value=imob;
        
        document.getElementById('Hclmail').value=clmail;
        document.getElementById('Hclname').value=clname;
        document.getElementById('SPHastmail').value=astrologer;
        document.getElementById('SPHastname').value=astro_dtls;
        
        document.getElementById('SPhdsunsetpre').value=sunsetpre;
        document.getElementById('SPhdsunrise').value=sunrise;
        document.getElementById('SPhdsunset').value=sunset;
        document.getElementById('SPhdsunrisenext').value=sunrisenext;
        document.getElementById('hdntzo').value=timezone;
       
        gridcall();
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
        res1 = addclient.update_client(astro_dtls, name, profession, age, sex, astrologer, email, cat_id, mno, cat_grp);

      

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

function bind_ddl_states(id) {
    var res = addclient.state("GETALLSTATES",id.value);
    var ds = res.value;
    var ddls = document.getElementById("ddlstates");    
    ddls.options.length = 1;
    ddls.options[0] = new Option("--Select--", "0");
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        for (var i = 0; i < ds.Tables[0].Rows.length; i++) {
            ddls.options[ddls.options.length] = new Option(ds.Tables[0].Rows[i].LOC_NAME, ds.Tables[0].Rows[i].LOC_ID)
            ddls.options.length;
        }
    }
    return false;
}


function bind_ddl_cities(id) {
    var countval = document.getElementById('ddlcunt').value;
    var stateval = document.getElementById('ddlstates').value;
    var districtval="";
    var res = addclient.citys(countval,stateval,districtval,"GETALLCITIES");
    var ds = res.value;
    var ddls = document.getElementById("ddlcities");    
    ddls.options.length = 1;
    ddls.options[0] = new Option("--Select--", "0");
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        for (var i = 0; i < ds.Tables[0].Rows.length; i++) {
            ddls.options[ddls.options.length] = new Option(ds.Tables[0].Rows[i].LOC_NAME, ds.Tables[0].Rows[i].LOC_ID)
            ddls.options.length;
        }
    }
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
           
            var res = addclient.state(filter, drop_down, exec_gridcall);
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

            var res = addclient.districtt(drop_down, state,filter, exec_gridcall);
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
            var res = addclient.citys(con, state, district, city, exec_gridcall);
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


function bind_lat_lng_tz(id) {
     
    if (document.activeElement.id == 'ddlcities') {

        //document.getElementById('city_list').style.display = 'none';
        var spl = document.getElementById('ddlcities').options[document.getElementById('ddlcities').selectedIndex].innerHTML;
       
        spl = spl.split('~');
        f = "";
        for (var i = 1; i < spl.length; i++) {
            f = f + spl[i] + '~';
        }
        f = f.slice(0, -1);
        document.getElementById('city').value = spl[0];
        var con = document.getElementById('ddlcunt').options[document.getElementById('ddlcunt').selectedIndex].text;
        var state = document.getElementById('ddlstates').value
    
        var con = document.getElementById('ddlcunt').value;
        var res = addclient.latlng(con, state, district, document.getElementById('ddlcities').value);
        var ds=res.value;
        

                document.getElementById('lat').value = ds.Tables[0].Rows[0].LATITUDE;
                document.getElementById('lng').value = ds.Tables[0].Rows[0].LONGITUDE;

                var dob1 = document.getElementById('dob').value;
                var tzid = ds.Tables[0].Rows[0].TIMEZONEID;
              if(tzid==undefined)
              {
                  tzid = 'Asia/Kolkata'
               }
              var res = addclient.timezone(tzid, dob1);
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

            var res = addclient.getsunsetsunrise(document.getElementById('lat').value, document.getElementById('lng').value, document.getElementById('username').value, d1[1]+'/'+d1[0]+'/'+d1[2] + ' ' + '1:00:42 AM')

            var sssr = res.value;
            var srss1 = sssr.split('\r\n')
            var sr = srss1[0];
            var ss = srss1[1];
            var res = addclient.getsunsetsunrisea(sr, document.getElementById('hdntz').value, ss,d1[1]+'/'+d1[0]+'/'+d1[2] + ' ' + '1:00:42 AM')
            var actsrss = res.value;
            var sunrise = actsrss.Tables[0].Rows[0].IDOB;
            var sunset = actsrss.Tables[1].Rows[0].IDOB;
            
            document.getElementById('hdsunrise').value=sunrise;
            document.getElementById('hdsunset').value=sunset;

            var res = addclient.getsunsetsunrise1(document.getElementById('lat').value, document.getElementById('lng').value, document.getElementById('username').value, d1[1] + '/' + d1[0] + '/' + d1[2] + ' ' + '1:00:42 AM')

            var sssr = res.value;
            var srss1 = sssr.split('\r\n')
            var sr = srss1[0];
            var ss = srss1[1];
            
            var res = addclient.getsunsetsunriseanext(sr, document.getElementById('hdntz').value, ss,d1[1]+'/'+d1[0]+'/'+d1[2] + ' ' + '1:00:42 AM')
            var actsrss = res.value;
            var sunrisenextday = actsrss.Tables[0].Rows[0].IDOB;
            hoursob = trim(document.getElementById('hob').value);
            document.getElementById('hdsunrisenext').value=sunrisenextday;

            var res = addclient.getsunsetsunrise2(document.getElementById('lat').value, document.getElementById('lng').value, document.getElementById('username').value, d1[1] + '/' + d1[0] + '/' + d1[2] + ' ' + '1:00:42 AM')
            var ssopd = res.value;
            var ssopd1 = ssopd.split('\r\n')
            var sr = ssopd1[0];
            var ss = ssopd1[1];
            
            var res = addclient.getsunsetsunriseapre(sr, document.getElementById('hdntz').value, ss,d1[1]+'/'+d1[0]+'/'+d1[2] + ' ' + '1:00:42 AM')
            var actsrss = res.value;
            var sunsetpreday = actsrss.Tables[1].Rows[0].IDOB;
            document.getElementById('hdsunsetpre').value=sunsetpreday;
            
            
            minuteob = trim(document.getElementById('mob').value);
            var tob = d1[1] + '/' + d1[0] + '/' + d1[2] + ' ' + hoursob + ':' + minuteob;
            var user = document.getElementById('hdnuser').value;
            resprobable = addclient.getdinrat(sunset, sunrise, sunrisenextday, tob, user)
                    
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
        var res = addclient.latlng(con, state, district, document.getElementById('city').value);
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
              var res = addclient.timezone(tzid, dob1);
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

            var res = addclient.getsunsetsunrise(document.getElementById('lat').value, document.getElementById('lng').value, document.getElementById('username').value, d1[1]+'/'+d1[0]+'/'+d1[2] + ' ' + '1:00:42 AM')

            var sssr = res.value;
            var srss1 = sssr.split('\r\n')
            var sr = srss1[0];
            var ss = srss1[1];
            var res = addclient.getsunsetsunrisea(sr, document.getElementById('hdntz').value, ss,d1[1]+'/'+d1[0]+'/'+d1[2] + ' ' + '1:00:42 AM')
            var actsrss = res.value;
            var sunrise = actsrss.Tables[0].Rows[0].IDOB;
            var sunset = actsrss.Tables[1].Rows[0].IDOB;
            
            document.getElementById('hdsunrise').value=sunrise;
            document.getElementById('hdsunset').value=sunset;

            var res = addclient.getsunsetsunrise1(document.getElementById('lat').value, document.getElementById('lng').value, document.getElementById('username').value, d1[1] + '/' + d1[0] + '/' + d1[2] + ' ' + '1:00:42 AM')

            var sssr = res.value;
            var srss1 = sssr.split('\r\n')
            var sr = srss1[0];
            var ss = srss1[1];
            
            var res = addclient.getsunsetsunriseanext(sr, document.getElementById('hdntz').value, ss,d1[1]+'/'+d1[0]+'/'+d1[2] + ' ' + '1:00:42 AM')
            var actsrss = res.value;
            var sunrisenextday = actsrss.Tables[0].Rows[0].IDOB;
            hoursob = trim(document.getElementById('hob').value);
            document.getElementById('hdsunrisenext').value=sunrisenextday;

            var res = addclient.getsunsetsunrise2(document.getElementById('lat').value, document.getElementById('lng').value, document.getElementById('username').value, d1[1] + '/' + d1[0] + '/' + d1[2] + ' ' + '1:00:42 AM')
            var ssopd = res.value;
            var ssopd1 = ssopd.split('\r\n')
            var sr = ssopd1[0];
            var ss = ssopd1[1];
            
            var res = addclient.getsunsetsunriseapre(sr, document.getElementById('hdntz').value, ss,d1[1]+'/'+d1[0]+'/'+d1[2] + ' ' + '1:00:42 AM')
            var actsrss = res.value;
            var sunsetpreday = actsrss.Tables[1].Rows[0].IDOB;
            document.getElementById('hdsunsetpre').value=sunsetpreday;
            
            
            minuteob = trim(document.getElementById('mob').value);
            var tob = d1[1] + '/' + d1[0] + '/' + d1[2] + ' ' + hoursob + ':' + minuteob;
            var user = document.getElementById('hdnuser').value;
            resprobable = addclient.getdinrat(sunset, sunrise, sunrisenextday, tob, user)
                    
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













//Second Page(homenewpage.aspx) Function Start Here //


var homenewpage = "";
var exec_data = "";
var next = 0;
var execute = "";
var exec_data1 = "";
var Modify = 0;
var delete_record = 0;
var browser = navigator.appName;

var buf1 = new StringBuffer();
function StringBuffer() {
    this.buffer = [];
}

StringBuffer.prototype.append = function append(string) {
    this.buffer.push(string);
    return this;
};

function StringBuffer() {
    this.buffer = [];
}

StringBuffer.prototype.append = function append(string) {
    this.buffer.push(string);
    return this;
}

StringBuffer.prototype.toString = function toString() {
    return this.buffer.join("");
}


var buf2 = new StringBuffer2();
function StringBuffer2() {
    this.buffer = [];
}

StringBuffer2.prototype.append = function append(string) {
    this.buffer.push(string);
    return this;
};

function StringBuffer2() {
    this.buffer = [];
}

StringBuffer2.prototype.append = function append(string) {
    this.buffer.push(string);
    return this;
}

StringBuffer2.prototype.toString = function toString() {
    return this.buffer.join("");
}


function gridcall()
{
//    document.getElementById('clientname').innerHTML = document.getElementById('Hclname').value;
//    document.getElementById('clientid').innerHTML = document.getElementById('Hclmail').value;
//    document.getElementById('astname').innerHTML = document.getElementById('SPHastname').value;
//    document.getElementById('astid').innerHTML = document.getElementById('SPHastmail').value;

    grid();
    for (var i = 0; i <= 9; i++) {
        grid1(i);
    }


    for (var kk = 0; kk < 11; kk++) {
        binddropdown("planets_" + kk);
        bindrashi("rashi_" + kk);
        bindhouse("house_" + kk);
        binddegree("degree_" + kk);
        bindminutes("minutes_" + kk);
        bindseconds("seconds_" + kk);
        bindretrograde("retrograde_" + kk);
        bindconstelation("constelation_" + kk);

     }
    document.getElementById('seconds_9').disabled = true;
    document.getElementById('minutes_9').disabled = true;
    document.getElementById('degree_9').disabled = true;
    document.getElementById('rashi_9').disabled = true;
    document.getElementById('rashi_10').disabled = true;
    document.getElementById('house_10').disabled = true;

    document.getElementById('planets_10').value = "GULIKA";
    document.getElementById('planets_10').disabled = true;
 
    //document.getElementById('degree_10').style.display = 'none';
    //document.getElementById('minutes_10').style.display = 'none';
    //document.getElementById('seconds_10').style.display = 'none';
    //document.getElementById('retrograde_10').style.display = 'none';
    //document.getElementById('constelation_10').style.display = 'none';
    //alert(document.getElementById('hdnmoc').value);
    if (document.getElementById('hdnmoc').value == 1)
    {
        makebc()
    }
    //else if (document.getElementById('hdnmoc').value == 0) {
    //    makeoc()
    //}
    //else
    //{
    //    searchclientid();
    //}

       vargaschart();
     
       calvargas();   // This Function call when we click om vargas button

       return false;
}



function grid() {
//    document.getElementById('Divgrid1').style.top = 160 + "px";
//    document.getElementById('Divgrid1').style.left =-250 + "px";

    document.getElementById('hdsviewgrid_astroclient').innerHTML = "";
        document.getElementById('Divgrid1_astroclient').style.display = 'block';
    var temp_del1 = "";

    flg_req = "yes"
    var aa1 = "";
    var aa = "";
    var hs = 0;
    var hs1 = 0;
    //alert('kkk')
    //alert(document.getElementById("datagrid1").childNodes[0])
    document.getElementById('hdsviewgrid_astroclient').style.display = "block";
    //$('hdsviewgrid').style.display = "block";
    //alert(document.getElementById("hdsviewgrid_astroclient").children.length)
    if (document.getElementById("hdsviewgrid_astroclient").children.length == "0") {
        klen = "0"
        //alert(klen)
    }
    else {

        klen = document.getElementById("Divgrid1_astroclient").childNodes[0].childNodes[0].childNodes.length - 1;
        //alert(klen)
        //klen=document.getElementById("hdsviewgrid").childNodes[0].childNodes[0].childNodes.length-1;
        IntializeNumber = klen + 1;
    }
    
    if (document.getElementById("hdsviewgrid_astroclient").innerHTML.indexOf("width:530px;display:block") <= 0) {
        aa = document.getElementById("hdsviewgrid_astroclient").innerHTML.replace("</TBODY>", "")//</TABLE>","")
    }
    
    buf1 += "<table id='Divgrid1_astroclient' runat='server' align='left' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
    buf1 += "<tr>"
    buf1 += "<td class='colum-td-head Planets'>" + "Planets" + "</td>"
    buf1 += "<td class='colum-td-head'>" + "Rashi" + "</td>"
    buf1 += "<td class='colum-td-head'>" + "House" + "</td>"
    buf1 += "<td class='colum-td-head'>" + "o`" + "</td>"
    buf1 += "<td class='colum-td-head'>" + "'" + "</td>"
    buf1 += "<td class='colum-td-head'>" + "''" + "</td>"
    buf1 += "<td class='colum-td-head'>" + "Retro" + "</td>"
    buf1 += "<td class='colum-td-head'>" + "Const" + "</td>"
    buf1 += "<td class='colum-td-head'>" + "Charan" + "</td>"
    buf1 += "<td class='colum-td-head'>" + "ConstLord" + "</td>"
     // buf1 += "<td  bgcolor=#7DAAE3 style='height:20px;width:70px;font-size:10px;text-align:center;border:1px solid #ffffff;'>" + "Birth_date" + "</td>"
   

    buf1 += "</tr>"

    len = 1;


    buf1 += "<tr>"


    buf1 += "<td class='colum-td-new'>"
    buf1 += "<input type='text' disabled class='colum-name_id' align='left'   id='planets_" + klen + "'  >"
    buf1 += "</td>"


    buf1 += "<td class='colum-td-new ' >"
    buf1 += "<select   ' align='left' class='Planets-font rashi-1' AutoPostBack='true' id='rashi_" + klen + "' onChange='javascript:return enablerashi(this.id);' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new '>"
    buf1 += "<input type='text'  disabled 'class='rashi-1'; align='left' value='HOUSE1' id='house_" + klen + "' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new '>"
    buf1 += "<select align='left' class='rashi-3' id='degree_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new '>"
    buf1 += "<select align='left' class='rashi-3' id='minutes_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new '>"
    buf1 += "<select class='rashi-3'; align='left' id='seconds_" + klen + "' onChange='javascript:return selectconstellation(this.id);'>"
    buf1 += "</td>"

    buf1 += "<td class='retro-1'>"
    buf1 += "<select  align='left'class='rashi-3' id='retrograde_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new '>"
    buf1 += "<select disabled align='left'class='rashi-1' id='constelation_" + klen + "'>"
    buf1 += "</td>"
    
    buf1 += "<td class='colum-td-new '>"
    buf1 += "<input type='text' disabled class='colum-name_id' align='left' id='charan_" + klen + "'  >"
    buf1 += "</td>"
    
    buf1 += "<td class='colum-td-new '>"
    buf1 += "<input type='text' disabled class='colum-name_id' align='left' id='constelationlord_" + klen + "'  >"
    buf1 += "</td>"
    
//     buf1 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
//    buf1 += "<select style='width:70px;'class='dropdown_large_corr'; align='left' id='birth_" + klen + "' onChange='javascript:return selectbirthon(this.id);'>"
//    buf1 += "</td>"


    //    buf1 += "<td class='gridview' style='border:0px solid #7DAAE3;display:none;'>"
    //    buf1 += "<input type='text'   class='fortaxtbox' width=100px' id='drprefid_" + klen + "'>"
    //    buf1 += "</td>"

    //        buf1 +="<td  class='gridview' style='border:0px solid #7DAAE3;'>")
    //        buf1 +="<select  style='display:none;' class=fordropdown width=100px' id='txtclimit_" + klen + "' onfocus='javascript:return binddropdown(id);'>"
    //        buf1 +="</td>")
    buf1 += "</tr>"

    buf1 += "</table>"
    var hdsview = "";
    temp_del1 = aa + buf1.toString();
    temp_del1 = temp_del1.replace("<TBODY>", "")
    temp_del1 = temp_del1.replace("</TBODY>", "")
    //alert(document.getElementById('hdsviewgrid_astroclient').innerHTML);
    document.getElementById('hdsviewgrid_astroclient').innerHTML = temp_del1;

    return false;
}


function grid1(i) {

     flg_req = "yes"
    var aa1 = "";
    var aa = "";
    var hs = 0;
    var hs1 = 0;

   
    klen = (i+1);

    // buf1 +="<table  class='gridview' id='datagrid1' runat='server' align='center' Width='500px' height='0px' style='border:0;margin-left:250px; solid #7DAAE3; cellpadding='0' cellspacing='0'>")//<tr>")
    // for (klen = a; klen < len1; klen++) {


    buf1 = document.getElementById("hdsviewgrid_astroclient").innerHTML;

    if (browser != "Microsoft Internet Explorer") {
        buf1 = buf1.replace("</tbody></table>", "");
    }
    else {
        buf1 = buf1.replace("</tbody></table>", "");
    }

    buf1 += "<tr>"

    buf1 += "<td class='colum-td-new'>"
    buf1 += "<input type='text'disabled '; class='Planets-font' align='left' id='planets_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new'>"
    buf1 += "<select disabled  ' align='left' class='Planets-font rashi-1'  id='rashi_" + klen + "' onChange='javascript:return selectrashi(this.id);' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new'>"
    buf1 += "<select disabled '; id='house_" + klen + "' runat='server'  align='left' class='rashi-2'  onChange='javascript:return selecthouse(this.id);' >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new '>"
    buf1 += "<select disabled ' align='left'class='rashi-3' id='degree_" + klen + "'onchange='javascript:return selectdegree(this.id);'>"
    buf1 += "</td>"

    buf1 += "<td  class='colum-td-new '>"
    buf1 += "<select disabled  ' align='left' class='rashi-3' id='minutes_" + klen + "'onchange='javascript:return selectminute(this.id);'>"
    buf1 += "</td>"

    buf1 += "<td  class='colum-td-new '>"
    buf1 += "<select disabled ' align='left' class='rashi-3' id='seconds_" + klen + "' onChange='javascript:return selectconstellation(this.id);'>"
    buf1 += "</td>"


    buf1 += "<td class='retro-1'>"
    buf1 += "<select ' align='left'class='rashi-3' id='retrograde_" + klen + "'>"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new '>"
    buf1 += "<select disabled ' align='left'class='rashi-1' id='constelation_" + klen + "'>"
    buf1 += "</td>"
     
    buf1 += "<td class='colum-td-new '>"
    buf1 += "<input type='text' disabled class='Planets-font' align='left' id='charan_" + klen + "'  >"
    buf1 += "</td>"
    
    buf1 += "<td class='colum-td-new '>"
    buf1 += "<input type='text' disabled class='Planets-font' align='left' id='constelationlord_" + klen + "'  >"
    buf1 += "</td>"
    
//    buf1 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
//    buf1 += "<select disabled style='width:70px;'class='dropdown_large_corr'; align='left' id='birth_" + klen + "' >"
//    buf1 += "</td>"
//    //        buf1 +="<td  class='gridview' style='border:0px solid #7DAAE3;'>")
    //        buf1 +="<select  style='display:none;' class=fordropdown width=100px' id='txtclimit_" + klen + "' onfocus='javascript:return binddropdown(id);'>"
    //        buf1 +="</td>")
    buf1 += "</tr>"


    if (browser != "Microsoft Internet Explorer") {
        buf1 += "</TBODY></table>"
    }
    else {
        buf1 += "</tbody></table>"
    }
     $("hdsviewgrid_astroclient").innerHTML = buf1.toString();
    //alert(document.getElementById("hdsviewgrid_astroclient").innerHTML);
    //    //for(var i=0;
    //    //binddropdown('planets_0');

    return false;
}


function binddropdown(res) {
    if (res == "planets_0") {
        document.getElementById(res).value = "ASCENDENT";
    }
    if (res == "planets_1") {
        document.getElementById(res).value = "SUN";
    }

    if (res == "planets_2") {
        document.getElementById(res).value = "MOON";
    }

    if (res == "planets_3") {
        document.getElementById(res).value = "MARS";
    }

    if (res == "planets_4") {
        document.getElementById(res).value = "MERCURY";
    }

    if (res == "planets_5") {
        document.getElementById(res).value = "JUPITER";
    }

    if (res == "planets_6") {
        document.getElementById(res).value = "VENUS";
    }
    if (res == "planets_7") {
        document.getElementById(res).value = "SATURN";
    }
    if (res == "planets_8") {
        document.getElementById(res).value = "RAHU";

    }
    if (res == "planets_9") {
        document.getElementById(res).value = "KETU";
    }
// if (res == "planets_10") {
//        document.getElementById(res).value = "GULIKA";
//    }

}

function bindrashi(res) {

    var vishu = "";
    var res1 = addclient.bindrashi(vishu);
    var ds = res1.value;

    document.getElementById(res).options.length = 0;
    document.getElementById(res).options[0] = new Option("--Select Rashi--", "0");

    var i;
    //    if(ds!=null)
    //    {
    if (ds.Tables[0].Rows.length > 0) {
        for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
            document.getElementById(res).options[document.getElementById(res).options.length] = new Option(ds.Tables[0].Rows[i].NAME, ds.Tables[0].Rows[i].CODE);
            document.getElementById(res).options.length;
        }
    }


}


function bindhouse(res) {
    if (res == "house_0") {

    }
    else {
        var vishu = "";
        var res1 = addclient.bindhouse(vishu);
        var ds = res1.value;
        //var drop_id=
        document.getElementById(res).options.length =0;
    
       document.getElementById(res).options[0] = new Option("--Select House--", "0");
        
        var i;
        //    if(ds!=null)
        //    {
        if (ds.Tables[0].Rows.length > 0) {
            for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
                document.getElementById(res).options[document.getElementById(res).options.length] = new Option(ds.Tables[0].Rows[i].NAME, ds.Tables[0].Rows[i].CODE);
                document.getElementById(res).options.length;
            }
        }
    }

}

function binddegree(res) {

    var vishu = "";
    var res1 = addclient.binddegree(vishu);
    var ds = res1.value;

    document.getElementById(res).options.length = 0;
    document.getElementById(res).options[0] = new Option("", "");

    var i;
    //    if(ds!=null)
    //    {
    if (ds.Tables[0].Rows.length > 0) {
        for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
            document.getElementById(res).options[document.getElementById(res).options.length] = new Option(ds.Tables[0].Rows[i].DEGREE, ds.Tables[0].Rows[i].CODE);
            document.getElementById(res).options.length;
        }
    }


}

function bindminutes(res) {

    var vishu = "";
    var res1 = addclient.bindminutes(vishu);
    var ds = res1.value;

    document.getElementById(res).options.length = 0;
    document.getElementById(res).options[0] = new Option("", "");

    var i;
    //    if(ds!=null)
    //    {
    if (ds.Tables[0].Rows.length > 0) {
        for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
            document.getElementById(res).options[document.getElementById(res).options.length] = new Option(ds.Tables[0].Rows[i].MINUTES, ds.Tables[0].Rows[i].CODE);
            document.getElementById(res).options.length;
        }
    }


}

function bindseconds(res) {

    var vishu = "";
    var res1 = addclient.bindseconds(vishu);
    var ds = res1.value;

    document.getElementById(res).options.length = 0;
    document.getElementById(res).options[0] = new Option("", "");

    var i;
    //    if(ds!=null)
    //    {
    if (ds.Tables[0].Rows.length > 0) {
        for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
            document.getElementById(res).options[document.getElementById(res).options.length] = new Option(ds.Tables[0].Rows[i].SECONDS, ds.Tables[0].Rows[i].CODE);
            document.getElementById(res).options.length;
        }
    }


}

function bindretrograde(res) {
  
    var vishu = "";
    var res1 = addclient.bindretrograde(vishu);
    var ds = res1.value;

//    document.getElementById(res).options.length = 0;
//    document.getElementById(res).options[0] = new Option("", "0");

    var i;
    //    if(ds!=null)
    //    {
    if (ds.Tables[0].Rows.length > 0) {
        for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
             if(ds.Tables[0].Rows[i].CATE==null)
             {
                ds.Tables[0].Rows[i].CATE="";
             }
             if(ds.Tables[0].Rows[i].CODE==null)
             {
                ds.Tables[0].Rows[i].CODE="";
             }
            document.getElementById(res).options[document.getElementById(res).options.length] = new Option(ds.Tables[0].Rows[i].CATE, ds.Tables[0].Rows[i].CODE);
            document.getElementById(res).options.length;
        }
    }


}

function bindconstelation(res) {

    var vishu = "";
    var res1 = addclient.bindconstelation(vishu);
    var ds = res1.value;

    document.getElementById(res).options.length = 0;
    document.getElementById(res).options[0] = new Option("--Select Constelation--", "0");

    var i;
    //    if(ds!=null)
    //    {
    if (ds.Tables[0].Rows.length > 0) {
        for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
            document.getElementById(res).options[document.getElementById(res).options.length] = new Option(ds.Tables[0].Rows[i].NAME, ds.Tables[0].Rows[i].CODE);
            document.getElementById(res).options.length;
        }
    }
}



  function makebc() {
      var dob = document.getElementById('hdnimoob').value + '/' + document.getElementById('hdnidob').value + '/' + document.getElementById('hdniyob').value
      var tob = document.getElementById('hdnihob').value + '.' + document.getElementById('hdnimob').value
      var tzon = "5.30";
      
       var hdnmocval =document.getElementById('hdnmoc').value;
      var dobval =document.getElementById('hdndob').value;
      var dateob =document.getElementById('hdnidob').value;
      var monthob =document.getElementById('hdnimoob').value;
      var yearob =document.getElementById('hdniyob').value;
      
      var timeob =document.getElementById('hdntob').value;
      var hourob =document.getElementById('hdnihob').value;
      var hdnimob =document.getElementById('hdnimob').value;
      var longitudeval=document.getElementById('lng').value;
      var latitudeval=document.getElementById('lat').value;
      
      var sunsetpre=document.getElementById('hdsunsetpre').value;
      var sunrise=document.getElementById('hdsunrise').value;
      var sunset=document.getElementById('hdsunset').value;
      var sunrisenext=document.getElementById('hdsunrisenext').value;
      var tzval=document.getElementById('tz').value;

      var exea = addclient.Cal_Ascendant_Gulika(hdnmocval,dobval,dateob,monthob,yearob,timeob,hourob,hdnimob,longitudeval,latitudeval,sunsetpre,sunrise,sunset,sunrisenext,tzval);
      
      exea = exea.value.split('~');
      var ascnd_val="";
      var gulika_val="";
      if(exea.length>0) 
      {
       ascnd_val=exea[0];
       gulika_val=exea[1];
      }
      
      var exec = addclient.makebirthchart(dob, tob, tzon, parseFloat(ascnd_val),parseFloat(gulika_val));

      var ds = exec.value;
      if (ds.Tables[0].Rows.length > 0)
      {
          for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
              document.getElementById('rashi_' + i).value = ds.Tables[0].Rows[i].RASHI;
              document.getElementById('house_' + i).value = ds.Tables[0].Rows[i].HOUSE;
              document.getElementById('degree_' + i).value = ds.Tables[0].Rows[i].DEGREE;
              document.getElementById('minutes_' + i).value = ds.Tables[0].Rows[i].MINUTE;
              document.getElementById('seconds_' + i).value = ds.Tables[0].Rows[i].SECOND;
              document.getElementById('constelation_' + i).value = ds.Tables[0].Rows[i].CONSTELATION;
              document.getElementById('charan_' + i).value = ds.Tables[0].Rows[i].CHARAN;
              document.getElementById('constelationlord_' + i).value=ds.Tables[0].Rows[i].CONSTELATION_LORD;

              if (ds.Tables[0].Rows[i].RASHI == 'Aries') {
                  var num = 1;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Taurus') {
                  var num = 2;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Gemini') {
                  var num = 3;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Cancer') {
                  var num = 4;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Leo') {
                  var num = 5;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Virgo') {
                  var num = 6;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Libra') {
                  var num = 7;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Scorpio') {
                  var num = 8;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Sagittarius') {
                  var num = 9;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Capricorn') {
                  var num = 10;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Aquarius') {
                  var num = 11;
              }
              if (ds.Tables[0].Rows[i].RASHI == 'Pisces') {
                  var num = 12;
              }
              document.getElementById('hdnr'+i).value = num;
              document.getElementById('hdnretro' + i).value = zeroPad(parseInt(ds.Tables[0].Rows[i].DEGREE), 2) + '.' + zeroPad(parseInt(ds.Tables[0].Rows[i].MINUTE), 2) + '.' + zeroPad(parseInt(ds.Tables[0].Rows[i].SECOND), 2);
              
          }
      }

      document.getElementById('rashi_' + 10).value = ds.Tables[0].Rows[10].RASHI;
      document.getElementById('house_' + 10).value = ds.Tables[0].Rows[10].HOUSE;
      document.getElementById('degree_' + 10).value = ds.Tables[0].Rows[10].DEGREE;
      document.getElementById('minutes_' + 10).value = ds.Tables[0].Rows[10].MINUTE;
      document.getElementById('seconds_' + 10).value = ds.Tables[0].Rows[10].SECOND;
      document.getElementById('constelation_' + 10).value = ds.Tables[0].Rows[10].CONSTELATION;
      document.getElementById('charan_' + 10).value = ds.Tables[0].Rows[10].CHARAN;
      document.getElementById('constelationlord_' + 10).value = ds.Tables[0].Rows[10].CONSTELATION_LORD;
      
      if (ds.Tables[1].Rows.length > 0) {

          for (i = 0; i < ds.Tables[1].Rows.length; ++i)
          {
              if (ds.Tables[1].Rows[i].PLANET == 'MARS' && ds.Tables[1].Rows[i].MOVEMENT1 == 'R')
              { document.getElementById('retrograde_' + 3).value = 'R' }
              if (ds.Tables[1].Rows[i].PLANET == 'MERCURY' && ds.Tables[1].Rows[i].MOVEMENT1 == 'R')
              { document.getElementById('retrograde_' + 4).value = 'R' }
              if (ds.Tables[1].Rows[i].PLANET == 'JUPITER' && ds.Tables[1].Rows[i].MOVEMENT1 == 'R')
              { document.getElementById('retrograde_' + 5).value = 'R' }
              if (ds.Tables[1].Rows[i].PLANET == 'VENUS' && ds.Tables[1].Rows[i].MOVEMENT1 == 'R')
              { document.getElementById('retrograde_' + 6).value = 'R' }
              if (ds.Tables[1].Rows[i].PLANET == 'SATURN' && ds.Tables[1].Rows[i].MOVEMENT1 == 'R')
              { document.getElementById('retrograde_' + 7).value = 'R' }
          }
      }
      //daob = ds.Tables[1].Rows[0].IDOB.split(' ');
      //idaob = daob[0];
      //itaob = daob[1];

      //idaob1 = idaob.split('-');
      //da1ob = idaob1[0];
      //mo1ob = idaob1[1];
      //yr1ob = idaob1[2];

      //itaob1 = itaob.split(':');
      //ihob = itaob1[0];
      //imob = itaob1[1];

      //var dob = mo1ob + '/' + da1ob + '/' + yr1ob;
      //var tob = ihob + '.' + imob

      //var exec = homenewpage.makebirthchart(dob, tob, tzon, parseFloat(document.getElementById('hdnasc').value));
      //var ds1 = exec.value;

      //if (ds1.Tables[0].Rows.length > 0)
      // {


      //    for (i = 3; i < ds1.Tables[0].Rows.length; ++i) 
      //    {
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Aries') {
      //            var num = 1;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Taurus') {
      //            var num = 2;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Gemini') {
      //            var num = 3;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Cancer') {
      //            var num = 4;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Leo') {
      //            var num = 5;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Virgo') {
      //            var num = 6;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Libra') {
      //            var num = 7;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Scorpio') {
      //            var num = 8;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Sagittarius') {
      //            var num = 9;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Capricorn') {
      //            var num = 10;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Aquarius') {
      //            var num = 11;
      //        }
      //        if (ds1.Tables[0].Rows[i].RASHI == 'Pisces') {
      //            var num = 12;
      //        }

      //        fretro = zeroPad(parseInt(ds1.Tables[0].Rows[i].DEGREE), 2) + '.' + zeroPad(parseInt(ds1.Tables[0].Rows[i].MINUTE), 2) + '.' + zeroPad(parseInt(ds1.Tables[0].Rows[i].SECOND), 2);

      //        if (document.getElementById('hdnretro' + i).value > fretro && parseInt(document.getElementById('hdnr' + i).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + i).value) != parseInt(1) && (parseInt(document.getElementById('hdnr' + i).value) >= parseInt(num) || parseInt(document.getElementById('hdnr' + i).value) == parseInt(num))) {
      //            document.getElementById('retrograde_' + i).value = 'R'
      //        }
      //        else { }


      //        if (parseInt(document.getElementById('hdnr' + i).value)==parseInt(12))
      //        {
                  
      //            if (document.getElementById('hdnretro' + i).value > fretro && parseInt(num) != parseInt('1') && (parseInt(document.getElementById('hdnr' + i).value) >= parseInt(num) || parseInt(document.getElementById('hdnr' + i).value) == parseInt(num)))
      //        {
      //            document.getElementById('retrograde_' + i).value = 'R'
      //        }
      //        else { }
      //        }

      //        if (parseInt(document.getElementById('hdnr' + i).value) == parseInt(1))
      //         {

      //            if (document.getElementById('hdnretro' + i).value > fretro && (parseInt(num) == parseInt('1') || parseInt(num) == parseInt('12')  ) ) {
      //                document.getElementById('retrograde_' + i).value = 'R'
      //            }
      //            else { }
      //        }

      //    }
      //}

   
      var moonsunr = document.getElementById('hdnr' + 2).value - document.getElementById('hdnr' + 1).value
      var marsunr = document.getElementById('hdnr' + 3).value - document.getElementById('hdnr' + 1).value
      var mersunr = document.getElementById('hdnr' + 4).value - document.getElementById('hdnr' + 1).value
      var jupsunr = document.getElementById('hdnr' + 5).value - document.getElementById('hdnr' + 1).value
      var vensunr = document.getElementById('hdnr' + 6).value - document.getElementById('hdnr' + 1).value
      var satsunr = document.getElementById('hdnr' + 7).value - document.getElementById('hdnr' + 1).value
      var rahusunr = document.getElementById('hdnr' + 8).value - document.getElementById('hdnr' + 1).value
      var ketusunr = document.getElementById('hdnr' + 9).value - document.getElementById('hdnr' + 1).value

      if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) && parseInt(document.getElementById('hdnr' + 2).value) == parseInt(1)) {
          var moonsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 2).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) && parseInt(document.getElementById('hdnr' + 2).value) == parseInt(12)) {
          var moonsun = parseFloat('30.00' - document.getElementById('hdnretro' + 2).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) > parseInt(document.getElementById('hdnr' + 2).value)) {
          var moonsun = parseFloat('30.00' - document.getElementById('hdnretro' + 2).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) < parseInt(document.getElementById('hdnr' + 2).value)) 
          {
              var moonsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 2).value.slice(0, -3))
          }
      else
      {
          var moonsun = parseFloat(document.getElementById('hdnretro' + 2).value.slice(0, -3)) - parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
          
          }


      if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) && parseInt(document.getElementById('hdnr' + 3).value)==parseInt(1)) {
          var marsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 3).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) && parseInt(document.getElementById('hdnr' + 3).value) == parseInt(12)) {
          var marsun = parseFloat('30.00' - document.getElementById('hdnretro' + 3).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) > parseInt(document.getElementById('hdnr' + 3).value)) {
          var marsun = parseFloat('30.00' - document.getElementById('hdnretro' + 3).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) < parseInt(document.getElementById('hdnr' + 3).value)) {
          var marsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 3).value.slice(0, -3))
      }
      else
      {
          var marsun = parseFloat(document.getElementById('hdnretro' + 3).value.slice(0, -3)) - parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))

      }

      if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) && parseInt(document.getElementById('hdnr' + 4).value) == parseInt(1)) {
          var mersun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 4).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) && parseInt(document.getElementById('hdnr' + 4).value) == parseInt(12)) {
          var mersun = parseFloat('30.00' - document.getElementById('hdnretro' + 4).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) > parseInt(document.getElementById('hdnr' + 4).value)) {
          var mersun = parseFloat('30.00' - document.getElementById('hdnretro' + 4).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) < parseInt(document.getElementById('hdnr' + 4).value)) {
          var mersun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 4).value.slice(0, -3))

      }
      else {
          var mersun = parseFloat(document.getElementById('hdnretro' + 4).value.slice(0, -3)) - parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }


      if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) && parseInt(document.getElementById('hdnr' + 5).value) == parseInt(1)) {
          var jupsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 5).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) && parseInt(document.getElementById('hdnr' + 5).value) == parseInt(12)) {
          var jupsun = parseFloat('30.00' - document.getElementById('hdnretro' + 5).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) > parseInt(document.getElementById('hdnr' + 5).value)) {
          var jupsun = parseFloat('30.00' - document.getElementById('hdnretro' + 5).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) < parseInt(document.getElementById('hdnr' + 5).value)) {
          var jupsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 5).value.slice(0, -3))
      }
      else {
          var jupsun = parseFloat( document.getElementById('hdnretro' + 5).value.slice(0, -3)) - parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }


      if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) && parseInt(document.getElementById('hdnr' + 6).value) == parseInt(1)) {
          var vensun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 6).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) && parseInt(document.getElementById('hdnr' + 6).value) == parseInt(12)) {
          var vensun = parseFloat('30.00' - document.getElementById('hdnretro' + 6).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) > parseInt(document.getElementById('hdnr' + 6).value)) {
          var vensun = parseFloat('30.00' - document.getElementById('hdnretro' + 6).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) < parseInt(document.getElementById('hdnr' + 6).value)) {
          var vensun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 6).value.slice(0, -3))
      }
      else {
          var vensun = parseFloat( document.getElementById('hdnretro' + 6).value.slice(0, -3)) - parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))

      }

      if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) && parseInt(document.getElementById('hdnr' + 7).value) == parseInt(1)) {
          var satsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 7).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) && parseInt(document.getElementById('hdnr' + 7).value) == parseInt(12)) {
          var satsun = parseFloat('30.00' - document.getElementById('hdnretro' + 7).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) > parseInt(document.getElementById('hdnr' + 7).value)) {
          var satsun = parseFloat('30.00' - document.getElementById('hdnretro' + 7).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) < parseInt(document.getElementById('hdnr' + 7).value)) {
          var satsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 7).value.slice(0, -3))
      }
      else {
          var satsun = parseFloat(document.getElementById('hdnretro' + 7).value.slice(0, -3)) - parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))

      }

      if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) && parseInt(document.getElementById('hdnr' + 8).value) == parseInt(1)) {
          var rahsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 8).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) && parseInt(document.getElementById('hdnr' + 8).value) == parseInt(12)) {
          var rahsun = parseFloat('30.00' - document.getElementById('hdnretro' + 8).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) > parseInt(document.getElementById('hdnr' + 8).value)) {
          var rahsun = parseFloat('30.00' - document.getElementById('hdnretro' + 8).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) < parseInt(document.getElementById('hdnr' + 8).value)) {
          var rahsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 8).value.slice(0, -3))

      }
      else {
          var rahsun = parseFloat( document.getElementById('hdnretro' + 8).value.slice(0, -3)) - parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }


      if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) && parseInt(document.getElementById('hdnr' + 9).value) == parseInt(1)) {
          var ketsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 9).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) && parseInt(document.getElementById('hdnr' + 9).value) == parseInt(12)) {
          var ketsun = parseFloat('30.00' - document.getElementById('hdnretro' + 9).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) > parseInt(document.getElementById('hdnr' + 9).value)) {
          var ketsun = parseFloat('30.00' - document.getElementById('hdnretro' + 9).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }
      else if (parseInt(document.getElementById('hdnr' + 1).value) < parseInt(document.getElementById('hdnr' + 9).value)) {
          var ketsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 9).value.slice(0, -3))
      }
      else {
          var ketsun = parseFloat( document.getElementById('hdnretro' + 9).value.slice(0, -3)) - parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }


      if (moonsun < "12" && moonsun > "-12" && parseInt(document.getElementById('hdnr' + 2).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 2).value) != parseInt(1) && moonsunr <= '1' && moonsunr>='-1') {
          if (document.getElementById('retrograde_' + 2).value == 'R') {
              document.getElementById('retrograde_' + 2).value = 'RC'
          }
          else {
              document.getElementById('retrograde_' + 2).value = 'C'
          }
      }

      if (moonsun < "3.20" && moonsun > "-3.20" && parseInt(document.getElementById('hdnr' + 2).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 2).value) != parseInt(1) && moonsunr <= '1' && moonsunr >= '-1') {
          if (document.getElementById('retrograde_' + 2).value == 'R') {
              document.getElementById('retrograde_' + 2).value = 'RDC'
          }
          else {
              document.getElementById('retrograde_' + 2).value = 'DC'
          }

      }


      if (parseInt(document.getElementById('hdnr' + 2).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) ||  parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1)  )     ) {

          if (moonsun < "12" && moonsun > "-12" && (parseInt(document.getElementById('hdnr' + 2).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 2).value == 'R') {
                  document.getElementById('retrograde_' + 2).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 2).value = 'C'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 2).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (moonsun < "3.20" && moonsun > "-3.20" && (parseInt(document.getElementById('hdnr' + 2).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 2).value == 'R') {
                  document.getElementById('retrograde_' + 2).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 2).value = 'DC'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 2).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2)) ) {

          if (moonsun < "12" && moonsun > "-12" && ((parseInt(document.getElementById('hdnr' + 2).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 2).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 2).value == 'R') {
                  document.getElementById('retrograde_' + 2).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 2).value = 'C'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 2).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (moonsun < "3.20" && moonsun > "-3.20" && ((parseInt(document.getElementById('hdnr' + 2).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 2).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 2).value == 'R') {
                  document.getElementById('retrograde_' + 2).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 2).value = 'DC'
              }
          }

      }


      if (satsun < "16" && satsun > "-16" && parseInt(document.getElementById('hdnr' + 7).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 7).value) != parseInt(1) && satsunr <= '1' && satsunr >= '-1') {
          if (document.getElementById('retrograde_' + 7).value == 'R') {
              document.getElementById('retrograde_' + 7).value = 'RC'
          }
          else {
              document.getElementById('retrograde_' + 7).value = 'C'
          }
      }

      if (satsun < "3.20" && satsun > "-3.20" && parseInt(document.getElementById('hdnr' + 7).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 7).value) != parseInt(1) && satsunr <= '1' && satsunr >= '-1') {
          if (document.getElementById('retrograde_' + 7).value == 'R') {
              document.getElementById('retrograde_' + 7).value = 'RDC'
          }
          else {
              document.getElementById('retrograde_' + 7).value = 'DC'
          }

      }


      if (parseInt(document.getElementById('hdnr' + 7).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (satsun < "16" && satsun > "-16" && (parseInt(document.getElementById('hdnr' + 7).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 7).value == 'R') {
                  document.getElementById('retrograde_' + 7).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 7).value = 'C'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 7).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (satsun < "3.20" && satsun > "-3.20" && (parseInt(document.getElementById('hdnr' + 7).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 7).value == 'R') {
                  document.getElementById('retrograde_' + 7).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 7).value = 'DC'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 7).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (satsun < "16" && satsun > "-16" && ((parseInt(document.getElementById('hdnr' + 7).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 7).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 7).value == 'R') {
                  document.getElementById('retrograde_' + 7).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 7).value = 'C'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 7).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (satsun < "3.20" && satsun > "-3.20" && ((parseInt(document.getElementById('hdnr' + 7).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 7).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 7).value == 'R') {
                  document.getElementById('retrograde_' + 7).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 7).value = 'DC'
              }
          }

      }
      
      
      if (vensun < "10" && vensun > "-10" && parseInt(document.getElementById('hdnr' + 6).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 6).value) != parseInt(1) && vensunr <= '1' && vensunr >= '-1') {
          if (document.getElementById('retrograde_' + 6).value == 'R') {
              document.getElementById('retrograde_' + 6).value = 'RC'
          }
          else {
              document.getElementById('retrograde_' + 6).value = 'C'
          }
      }

      if (vensun < "3.20" && vensun > "-3.20" && parseInt(document.getElementById('hdnr' + 6).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 6).value) != parseInt(1) && vensunr <= '1' && vensunr >= '-1') {
          if (document.getElementById('retrograde_' + 6).value == 'R') {
              document.getElementById('retrograde_' + 6).value = 'RDC'
          }
          else {
              document.getElementById('retrograde_' + 6).value = 'DC'
          }

      }


      if (parseInt(document.getElementById('hdnr' + 6).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (vensun < "10" && vensun > "-10" && (parseInt(document.getElementById('hdnr' + 6).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 6).value == 'R') {
                  document.getElementById('retrograde_' + 6).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 6).value = 'C'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 6).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (vensun < "3.20" && vensun > "-3.20" && (parseInt(document.getElementById('hdnr' + 6).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 6).value == 'R') {
                  document.getElementById('retrograde_' + 6).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 6).value = 'DC'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 6).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (vensun < "10" && vensun > "-10" && ((parseInt(document.getElementById('hdnr' + 6).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 6).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 6).value == 'R') {
                  document.getElementById('retrograde_' + 6).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 6).value = 'C'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 6).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (vensun < "3.20" && vensun > "-3.20" && ((parseInt(document.getElementById('hdnr' + 6).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 6).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 6).value == 'R') {
                  document.getElementById('retrograde_' + 6).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 6).value = 'DC'
              }
          }

      }


      if (jupsun < "11" && jupsun > "-11" && parseInt(document.getElementById('hdnr' + 5).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 5).value) != parseInt(1) && jupsunr <= '1' && jupsunr >= '-1') {
          if (document.getElementById('retrograde_' + 5).value == 'R') {
              document.getElementById('retrograde_' + 5).value = 'RC'
          }
          else {
              document.getElementById('retrograde_' + 5).value = 'C'
          }
      }

      if (jupsun < "3.20" && jupsun > "-3.20" && parseInt(document.getElementById('hdnr' + 5).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 5).value) != parseInt(1) && jupsunr <= '1' && jupsunr >= '-1') {
          if (document.getElementById('retrograde_' + 5).value == 'R') {
              document.getElementById('retrograde_' + 5).value = 'RDC'
          }
          else {
              document.getElementById('retrograde_' + 5).value = 'DC'
          }

      }


      if (parseInt(document.getElementById('hdnr' + 5).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (jupsun < "11" && jupsun > "-11" && (parseInt(document.getElementById('hdnr' + 5).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 5).value == 'R') {
                  document.getElementById('retrograde_' + 5).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 5).value = 'C'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 5).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (jupsun < "3.20" && jupsun > "-3.20" && (parseInt(document.getElementById('hdnr' + 5).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 5).value == 'R') {
                  document.getElementById('retrograde_' + 5).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 5).value = 'DC'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 5).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (jupsun < "11" && jupsun > "-11" && ((parseInt(document.getElementById('hdnr' + 5).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 5).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 5).value == 'R') {
                  document.getElementById('retrograde_' + 5).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 5).value = 'C'
              }
          }
      }

      if (parseInt(document.getElementById('hdnr' + 5).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (jupsun < "3.20" && jupsun > "-3.20" && ((parseInt(document.getElementById('hdnr' + 5).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 5).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 5).value == 'R') {
                  document.getElementById('retrograde_' + 5).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 5).value = 'DC'
              }
          }
      }

      if (mersun < "14" && mersun > "-14" && parseInt(document.getElementById('hdnr' + 4).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 4).value) != parseInt(1) && mersunr <= '1' && mersunr >= '-1') {
          if (document.getElementById('retrograde_' + 4).value == 'R') {
              document.getElementById('retrograde_' + 4).value = 'RC'
          }
          else {
              document.getElementById('retrograde_' + 4).value = 'C'
          }
      }

      if (mersun < "3.20" && mersun > "-3.20" && parseInt(document.getElementById('hdnr' + 4).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 4).value) != parseInt(1) && mersunr <= '1' && mersunr >= '-1') {
          if (document.getElementById('retrograde_' + 4).value == 'R') {
              document.getElementById('retrograde_' + 4).value = 'RDC'
          }
          else {
              document.getElementById('retrograde_' + 4).value = 'DC'
          }
      }


      if (parseInt(document.getElementById('hdnr' + 4).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (mersun < "14" && mersun > "-14" && (parseInt(document.getElementById('hdnr' + 4).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 4).value == 'R') {
                  document.getElementById('retrograde_' + 4).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 4).value = 'C'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 4).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (mersun < "3.20" && mersun > "-3.20" && (parseInt(document.getElementById('hdnr' + 4).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 4).value == 'R') {
                  document.getElementById('retrograde_' + 4).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 4).value = 'DC'
              }
          }
      }

      if (parseInt(document.getElementById('hdnr' + 4).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (mersun < "14" && mersun > "-14" && ((parseInt(document.getElementById('hdnr' + 4).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 4).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 4).value == 'R') {
                  document.getElementById('retrograde_' + 4).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 4).value = 'C'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 4).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (mersun < "3.20" && mersun > "-3.20" && ((parseInt(document.getElementById('hdnr' + 4).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 4).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 4).value == 'R') {
                  document.getElementById('retrograde_' + 4).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 4).value = 'DC'
              }
          }

      }

      if (marsun < "17" && marsun > "-17" && parseInt(document.getElementById('hdnr' + 3).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 3).value) != parseInt(1) && marsunr <= '1' && marsunr >= '-1')
      {
          if (document.getElementById('retrograde_' + 3).value == 'R')
          {
              document.getElementById('retrograde_' + 3).value = 'RC'
          }
          else
          {
              document.getElementById('retrograde_' + 3).value = 'C'
          }
      }
      
      if (marsun < "3.20" && marsun > "-3.20" && parseInt(document.getElementById('hdnr' + 3).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 3).value) != parseInt(1) && marsunr <= '1' && marsunr >= '-1') {
          if (document.getElementById('retrograde_' + 3).value == 'R') {
              document.getElementById('retrograde_' + 3).value = 'RDC'
          }
          else {
              document.getElementById('retrograde_' + 3).value = 'DC'
          }

          
      }


      if (parseInt(document.getElementById('hdnr' + 3).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (marsun < "17" && marsun > "-17" && (parseInt(document.getElementById('hdnr' + 3).value)) != parseInt('1'))
          {
              if (document.getElementById('retrograde_' + 3).value == 'R') {
                  document.getElementById('retrograde_' + 3).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 3).value = 'C'
              }
          }

           
      }

      if (parseInt(document.getElementById('hdnr' + 3).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (marsun < "3.20" && marsun > "-3.20" && (parseInt(document.getElementById('hdnr' + 3).value)) != parseInt('1')) {
              if (document.getElementById('retrograde_' + 3).value == 'R') {
                  document.getElementById('retrograde_' + 3).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 3).value = 'DC'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 3).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (marsun < "17" && marsun > "-17" && ((parseInt(document.getElementById('hdnr' + 3).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 3).value)) == parseInt('12')))
          {
              if (document.getElementById('retrograde_' + 3).value == 'R') {
                  document.getElementById('retrograde_' + 3).value = 'RC'
              }
              else {
                  document.getElementById('retrograde_' + 3).value = 'C'
              }
          }
          
      }

      if (parseInt(document.getElementById('hdnr' + 3).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (marsun < "3.20" && marsun > "-3.20" && ((parseInt(document.getElementById('hdnr' + 3).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 3).value)) == parseInt('12'))) {
              if (document.getElementById('retrograde_' + 3).value == 'R') {
                  document.getElementById('retrograde_' + 3).value = 'RDC'
              }
              else {
                  document.getElementById('retrograde_' + 3).value = 'DC'
              }
          }

      }
      
      return false;
  }

function zeroPad(num, numZeros) {
      var n = Math.abs(num);
      var zeros = Math.max(0, numZeros - Math.floor(n).toString().length);
      var zeroString = Math.pow(10, zeros).toString().substr(1);
      if (num < 0) {
          zeroString = '-' + zeroString;
      }
      return zeroString + n;
  }
  
  
  function vargaschart() {
    var p1 = "";
    var p2 = "";
    var p3 = "";
    var p4 = "";
    var p5 = "";
    var p6 = "";
    var p7 = "";
    var p8 = "";
    var p9 = "";
    var p10 = "";
    var p11 = "";
    var p12 = "";
    var j1 = "";
    var j2 = "";
    var j3 = "";
    var j4 = "";
    var j5 = "";
    var j6 = "";
    var j7 = "";
    var j8 = "";
    var j9 = "";
    var j10 = "";
    var j11 = "";
    var j12 = "";
    var h1 = "";
    var r1 = "";
    var h2 = "";
    var r2 = "";
    var h3 = "";
    var r3 = "";
    var h4 = "";
    var r4 = "";
    var h5 = "";
    var r5 = "";
    var h6 = "";
    var r6 = "";
    var h7 = "";
    var r7 = "";
    var h8 = "";
    var r8 = "";
    var h9 = "";
    var r9 = "";
    var h10 = "";
    var r10 = "";
    var h11 = "";
    var r11 = "";
    var h12 = "";
    var r12 = "";

   
    if( (parseFloat(document.getElementById('Hnewdiffm').value) > parseFloat('28.00.00') && parseFloat(document.getElementById('Hnewdiffm1').value) > parseFloat('28.00.00'))||(parseFloat(document.getElementById('Hnewdiffm').value) < parseFloat('00.00.00') || parseFloat(document.getElementById('Hnewdiffm1').value) < parseFloat('00.00.00'))||(parseFloat(document.getElementById('Hnewdiffv').value) >parseFloat( '48.00.00') && parseFloat(document.getElementById('Hnewdiffv1').value) >parseFloat( '48.00.00'))||(parseFloat(document.getElementById('Hnewdiffv').value) <parseFloat( '00.00.00') || parseFloat(document.getElementById('Hnewdiffv1').value) <parseFloat( '00.00.00'))){
        alert('chart is not valid');
        return false;
    }

    else {
        document.getElementById('rashiid').style.display = "block";
        for (var i = 1; i < 11; i++) {
            document.getElementById('Hidden4').value = i;

            var h = document.getElementById('house_' + i).value
            var r = document.getElementById('rashi_' + 0).value
            
        

            if (document.getElementById('retrograde_' + i).value == '0')
            {
                document.getElementById('retrograde_' + i).innerHTML = "";
                
            }


            if (h == 'HOUSE1') {


                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j1 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j1 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j1 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j1 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j1 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j1 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j1 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j1 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j1 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j1 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                h1 = h1 + j1 + " ";


            }
            if (h == 'HOUSE2') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j2 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j2 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j2 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j2 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j2 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j2 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j2 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j2 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j2 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j2 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }


                h2 = h2 + j2 + " ";


            }

            if (h == 'HOUSE3') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j3 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j3 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j3 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j3 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j3 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j3 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j3 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j3 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j3 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j3 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h3 = h3 + j3 + " ";


            }


            if (h == 'HOUSE4') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j4 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j4 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j4 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j4 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j4 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j4 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j4 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j4 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j4 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j4 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h4 = h4 + j4 + " ";


            }

            if (h == 'HOUSE5') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j5 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j5 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j5 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j5 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j5 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j5 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j5 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j5 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j5 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j5 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h5 = h5 + j5 + " ";

            }

            if (h == 'HOUSE6') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j6 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j6 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j6 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j6 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
          }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j6 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j6 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j6 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j6 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';

                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j6 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j6 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h6 = h6 + j6 + " ";


            }

            if (h == 'HOUSE7') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j7 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j7 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j7 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j7 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j7 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j7 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j7 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j7 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j7 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j7 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                h7 = h7 + j7 + " ";


            }

            if (h == 'HOUSE8') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j8 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j8 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j8 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j8 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j8 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j8 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j8 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j8 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j8 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j8 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                h8 = h8 + j8 + " ";


            }

            if (h == 'HOUSE9') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j9 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j9 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j9 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j9 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j9 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j9 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j9 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j9 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j9 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }


                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j9 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h9 = h9 + j9 + " ";


            }

            if (h == 'HOUSE10') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j10 = 'Me' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j10 = 'Ju' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j10 = 'Ve' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j10 = 'Sa' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j10 = 'Su' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j10 = 'Mo' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j10 = 'Ma' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j10 = 'Ra' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j10 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>' + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j10 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                h10 = h10 + j10 + " ";


            }

            if (h == 'HOUSE11') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j11 = 'Me'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j11 = 'Ju'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " + '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j11 = 'Ve'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j11 = 'Sa'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j11 = 'Su'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j11 = 'Mo'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j11 = 'Ma'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j11 = 'Ra'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j11 = 'Ke'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }


                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j11 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h11 = h11 + j11 + " ";

            }
            if (h == 'HOUSE12') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j12 = 'Me'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j12 = 'Ju'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j12 = 'Ve'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j12 = 'Sa'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j12 = 'Su'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j12 = 'Mo'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j12 = 'Ma'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j12 = 'Ra'+ '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j12 = 'Ke' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value  + '</span>' + " " + '<span style=color:#F25E0A>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j12 = 'Gk' + '<span style=color:#F25E0A>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#F25E0A>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h12 = h12 + j12 + " ";



            }

        }

        if (r == 'Aries') {
            r1 = '1'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = parseInt(r11) + parseInt(1);

        }
        if (r == 'Taurus') {
            r1 = '2'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = '1';

        }

        if (r == 'Gemini') {
            r1 = '3'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = '1';
            r12 = '2';

        }

        if (r == 'Cancer') {
            r1 = '4'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = '1';
            r11 = '2';
            r12 = '3';

        }


        if (r == 'Leo') {
            r1 = '5'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = '1';
            r10 = '2';
            r11 = '3';
            r12 = '4';

        }
        if (r == 'Virgo') {
            r1 = '6'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = '1'
            r9 = '2'
            r10 = '3'
            r11 = '4'
            r12 = '5'

        }

        if (r == 'Libra') {
            r1 = '7'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) - parseInt(11);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = parseInt(r11) + parseInt(1);

        }
        if (r == 'Scorpio') {
            r1 = '8'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) - parseInt(11);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = parseInt(r11) + parseInt(1);

        }

        if (r == 'Sagittarius') {
            r1 = '9'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) - parseInt(11);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = parseInt(r11) + parseInt(1);

        }

        if (r == 'Capricorn') {
            r1 = '10'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) - parseInt(11);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = parseInt(r11) + parseInt(1);

        }
        if (r == 'Aquarius') {
            r1 = '11'
            r2 = parseInt(r1) + parseInt(1);
            r3 = parseInt(r2) - parseInt(11);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = parseInt(r11) + parseInt(1);

        }
        if (r == 'Pisces') {
            r1 = '12'
            r2 = r1 - '11';
            r3 = parseInt(r2) + parseInt(1);
            r4 = parseInt(r3) + parseInt(1);
            r5 = parseInt(r4) + parseInt(1);
            r6 = parseInt(r5) + parseInt(1);
            r7 = parseInt(r6) + parseInt(1);
            r8 = parseInt(r7) + parseInt(1);
            r9 = parseInt(r8) + parseInt(1);
            r10 = parseInt(r9) + parseInt(1);
            r11 = parseInt(r10) + parseInt(1);
            r12 = parseInt(r11) + parseInt(1);

        }

        p1 = h1;
        p2 = h2;
        p3 = h3;
        p4 = h4;
        p5 = h5;
        p6 = h6;
        p7 = h7;
        p8 = h8;
        p9 = h9;
        p10 = h10;
        p11 = h11;
        p12 = h12;
        document.getElementById('h1l1').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#F25E0A>'+document.getElementById('degree_' + 0).value+'.'+document.getElementById('minutes_' + 0).value+'</span>';
        document.getElementById('h2l1').innerHTML = p2;
        document.getElementById('h3l1').innerHTML = p3;
        document.getElementById('h4l1').innerHTML = p4;
        document.getElementById('h5l1').innerHTML = p5;
        document.getElementById('h6l1').innerHTML = p6;
        document.getElementById('h7l1').innerHTML = p7;
        document.getElementById('h8l1').innerHTML = p8;
        document.getElementById('h9l1').innerHTML = p9;
        document.getElementById('h10l1').innerHTML = p10;
        document.getElementById('h11l1').innerHTML = p11;
        document.getElementById('h12l1').innerHTML = p12;
        document.getElementById('h12r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r12+'</span>'+'</br>';
        document.getElementById('h1r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r1+'</span>'+'</br>';
        document.getElementById('h2r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r2+'</span>'+'</br>';
        document.getElementById('h3r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r3+'</span>'+'</br>';
        document.getElementById('h4r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r4+'</span>'+'</br>';
        document.getElementById('h5r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r5+'</span>'+'</br>';
        document.getElementById('h6r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r6+'</span>'+'</br>';
        document.getElementById('h7r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r7+'</span>'+'</br>';
        document.getElementById('h8r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r8+'</span>'+'</br>';
        document.getElementById('h9r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r9+'</span>'+'</br>';
        document.getElementById('h10r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r10+'</span>'+'</br>';
        document.getElementById('h11r').innerHTML = '<br>'+'<span style="color: rgb(15, 22, 170); font-size: 15px;">'+r11+'</span>'+'</br>';
        return false;
    }
}



var v = "";
var c="";
var degree = "";
function calvargas() {

    if ( (document.getElementById('hdnmoc').value == 0) && (parseFloat(document.getElementById('Hnewdiffm').value) > parseFloat('28.00.00') && parseFloat(document.getElementById('Hnewdiffm1').value) > parseFloat('28.00.00')) || (parseFloat(document.getElementById('Hnewdiffm').value) < parseFloat('00.00.00') && parseFloat(document.getElementById('Hnewdiffm1').value) < parseFloat('00.00.00')) || (parseFloat(document.getElementById('Hnewdiffv').value) > parseFloat('48.00.00') && parseFloat(document.getElementById('Hnewdiffv1').value) > parseFloat('48.00.00')) || (parseFloat(document.getElementById('Hnewdiffv').value) < parseFloat('00.00.00') && parseFloat(document.getElementById('Hnewdiffv1').value) < parseFloat('00.00.00'))) {
    
            alert('chart is not valid');
            return false;
    }

    else {
        
        var astname = document.getElementById('SPHastname').value;
        var astid = document.getElementById('SPHastmail').value;
        var clientid = document.getElementById('Hclmail').value;

        var clientname = document.getElementById('Hclname').value;
        var j = document.getElementById('planet').value;

        var k = document.getElementById('Texttodate').value;
       
        var retro = "";
        for (var i = 0; i < 11; i++) {

            if (document.getElementById('retrograde_' + i).value == "")
            { retro = 'B' }

            else {
                retro = document.getElementById('retrograde_' + i).value;
            }

            if (document.getElementById('degree_' + i).value == '00') {
                //document.getElementById('degree_' + i).value = '01'
            }
            if (document.getElementById('minutes_' + i).value == '00') {
                document.getElementById('minutes_' + i).value = '01'
            }
            if (document.getElementById('seconds_' + i).value == '00') {
                document.getElementById('seconds_' + i).value = '01'
            }
            
            
            degree = document.getElementById('degree_' + i).value + "." + document.getElementById('minutes_' + i).value + "." + document.getElementById('seconds_' + i).value;
            v = v + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "~" + document.getElementById('birth').value + "~" + retro + "~" + degree + "$";
            c = c + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "~" + document.getElementById('birth').value + "~" + retro + "~" + degree + "~" + document.getElementById('constelation_' + i).value + "~" + document.getElementById('charan_' + i).value + "~" + document.getElementById('constelationlord_' + i).value + "$";
        }
        v = v.slice(0, -1);
        c = c.slice(0, -1);
        // var resv = astrodegree.calvargas(v);
        // var dsv = resv.value;
        var imonthob = document.getElementById('hdnimoob').value
        var idateob = document.getElementById('hdnidob').value
        var iyearob = document.getElementById('hdniyob').value

        var ihourob = document.getElementById('hdnihob').value
        var iminuteob = document.getElementById('hdnimob').value
        
        var sunsetpre = document.getElementById('hdsunsetpre').value;
        var sunrise = document.getElementById('hdsunrise').value;
        var sunset = document.getElementById('hdsunset').value;
        var sunrisenext = document.getElementById('hdsunrisenext').value;
        var tzo = document.getElementById('hdntzo').value;
        
        
        var dob = document.getElementById('hdndob').value
        var dob1 = dob.split('/')
        var date1=dob1[0];
        var month1=dob1[1];
        var year1=dob1[2];

        var tob = document.getElementById('hdntob').value
        var tob1 = tob.split(':');
        var hob=tob1[0];
        var miob=tob1[1];
        var stob="0";
        var dn="Maha Dasha";
        var clientquery = document.getElementById('hdnquery').value;
        var astmail = document.getElementById('Hastmail').value;
        
        var bosparameters = document.getElementById('degree_' + 2).value + "$" + document.getElementById('minutes_' + 2).value + "$" + document.getElementById('seconds_' + 2).value + "$" + document.getElementById('rashi_' + 2).value + "$" + date1 + "$" + month1 + "$" + year1 + "$" + hob + "$" + miob + "$" + stob + "$" + astmail + "$" +  dn;
        //window.open('vargas_chart.aspx?v=' + v + "&j=" + j + "&k=" + k + "&astname=" + astname + "&astid=" + astid + "&clientname=" + clientname + "&clientid=" + clientid + "&usermail=" + document.getElementById('hdnuser').value + "&c=" + c + "&dob=" + document.getElementById("hdndob").value + "&tob=" + document.getElementById("hdntob").value + "&country=" + document.getElementById("hdncountry").value + "&state=" + document.getElementById("SPhdnstate").value + "&district=" + document.getElementById("SPhdndist").value + "&city=" + document.getElementById("SPhdncity").value + "&group=" + document.getElementById("SPhdngroup").value + "&group_under=" + document.getElementById("hdngroup_u").value + "&prof=" + document.getElementById("SPhdnprof").value + "&sex=" + document.getElementById("hdnsex").value + "&mobile=" + document.getElementById("hdnmobile").value + "&idateob=" + idateob + "&imonthob=" + imonthob + "&iyearob=" + iyearob + "&ihourob=" + ihourob + "&iminuteob=" + iminuteob + "&longitude=" + document.getElementById('hdnlongit').value + "&latitude=" + document.getElementById('hdnlatit').value + "&timezone=" + tzo + "&tzval=" + document.getElementById('hdntzval').value + "&sunsetpre=" + sunsetpre  + "&sunrise=" + sunrise + "&sunset=" + sunset + "&sunrisenext=" + sunrisenext + "&balancedasha=" + bosparameters + "&query="+clientquery + "");
      
        var chartfinalurl = 'vargas_chart.aspx?v=' + v + "&j=" + j + "&k=" + k + "&astname=" + astname + "&astid=" + astid + "&clientname=" + clientname + "&clientid=" + clientid + "&usermail=" + document.getElementById('hdnuser').value + "&c=" + c + "&dob=" + document.getElementById("hdndob").value + "&tob=" + document.getElementById("hdntob").value + "&country=" + document.getElementById("hdncountry").value + "&state=" + document.getElementById("SPhdnstate").value + "&district=" + document.getElementById("SPhdndist").value + "&city=" + document.getElementById("SPhdncity").value + "&group=" + document.getElementById("SPhdngroup").value + "&group_under=" + document.getElementById("hdngroup_u").value + "&prof=" + document.getElementById("SPhdnprof").value + "&sex=" + document.getElementById("hdnsex").value + "&mobile=" + document.getElementById("hdnmobile").value + "&idateob=" + idateob + "&imonthob=" + imonthob + "&iyearob=" + iyearob + "&ihourob=" + ihourob + "&iminuteob=" + iminuteob + "&longitude=" + document.getElementById('hdnlongit').value + "&latitude=" + document.getElementById('hdnlatit').value + "&timezone=" + tzo + "&tzval=" + document.getElementById('hdntzval').value + "&sunsetpre=" + sunsetpre  + "&sunrise=" + sunrise + "&sunset=" + sunset + "&sunrisenext=" + sunrisenext + "&balancedasha=" + bosparameters + "&query="+clientquery + "";
        document.getElementById('finalnextpageurl').value=chartfinalurl;
    }
}


function selectconstellation(id) {
    var second = id.split('_')
    var seconds1 = second[1]

    var house = document.getElementById("house_" + seconds1).value
    var rashi = document.getElementById("rashi_" + seconds1).value
    var degree = document.getElementById("degree_" + seconds1).value
    var minutes = document.getElementById("minutes_" + seconds1).value
    var seconds = document.getElementById("seconds_" + seconds1).value
    var degreevalue = degree + '.' + minutes + '.' + seconds;

    var cons = addclient.getconstellation(rashi, degreevalue);
    var ds = cons.value;
    document.getElementById("constelation_" + seconds1).value = ds.Tables[0].Rows[0].CONSTELLATION;
     var a = document.getElementById('seconds_'+8).value;
  document.getElementById('seconds_'+9).value=a;
   var a = document.getElementById('constelation_'+8).value;
  document.getElementById('constelation_'+9).value=a;
  
  //checkforsec(id);
}



//Second Page(homenewpage.aspx) Function End Here //


//*************************************************Deepak Nirwal**************************************************************8//


//Third Page(vargas_chart.aspx) Function Start Here //


//Third Page(vargas_chart.aspx) Function End Here //