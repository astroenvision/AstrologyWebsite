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

function ChangeLabels()
{
      //document.getElementById('loading').style.display = 'block';
    if (document.getElementById('DropDownList2').value.toUpperCase()=="HORARY") {
       document.getElementById('datelabel').innerHTML ="Date of Query <font class=\"star\">*</font>";
       document.getElementById('timelabel').innerHTML ="Time of Query <font class=\"star\">*</font>";
       document.getElementById('citylabel').innerHTML ="City of Query <font class=\"star\">*</font>";
    }
    if (document.getElementById('DropDownList2').value.toUpperCase()=="NATAL") {
       document.getElementById('datelabel').innerHTML ="Date of Birth <font class=\"star\">*</font>";
       document.getElementById('timelabel').innerHTML ="Time of Birth <font class=\"star\">*</font>";
       document.getElementById('citylabel').innerHTML ="City of Birth <font class=\"star\">*</font>";
    }
    
    return false;
}


function group_bind() {
    var astrologer = document.getElementById('hdnuser').value;
    if (astrologer == 'astrology' || astrologer == 'ASTROLOGY' || astrologer == "") {
        // alert('you are admin');
        getopen("login.aspx");
        return false;
    }
    else {
        res = compatibilitymatchingtest.searchuser(astrologer, document.getElementById('DropDownList2').value);

        callback_drp1(res);
       
        return false;
    }
    return false;
}


function callback_drp1(res) {
    var ds = res.value;
    var edtn = $("cat");
    //edtn.options.length = 1;
    //edtn.options[0] = new Option("General", "0");
    //edtn.options[1] = new Option("New Group", "1");
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
        document.getElementById('DropDownList2').value = 'Horary';
    }

    if (document.getElementById('hdncat').value == 'Natal') {
        document.getElementById('DropDownList2').value = 'Natal';
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
    //if (document.getElementById('DropDownList2').value == "Select Category") {
    //    alert("Select Group Category !");
    //    document.form1.DropDownList2.focus();
    //    return false;
    //}
    //if (document.getElementById('cat').value == "Select Group") {
    //    alert("Select Group Name !");
    //    document.form1.cat.focus();
    //    return false;
    //}  
    
    if (document.getElementById('cl_name').value == "") {
        alert("Please Enter Name.");
        document.form1.cl_name.focus();
        return false;
    }
    
    //if (document.getElementById('txtpwd').value == "") {
    //    alert("Please Enter Password.");
    //    document.form1.cl_name.focus();
    //    return false;
    //}
  
   
    var re = "";
    var re1 = "";
    function validateEmail(txtmail) {
         re = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
         return re1=re.test(txtmail);
    }

    if (document.getElementById('txtmail').value == "") {
        alert("Please enter EmailId.");
        document.form1.txtmail.focus();
        return false;
    }
    else
    {
        validateEmail(document.getElementById('txtmail').value);
        if (re1 == false)
        {
            alert("Please enter valid EmailId.");
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
    
    document.getElementById('hdnlatit').value=lati;
    document.getElementById('hdnlongit').value=longi;
    document.getElementById('hdnlat').value=lati;
    document.getElementById('hdnlng').value=longi;

    //profession = trim(document.getElementById('cl_pro').value);
    profession = "";
    
    if (document.getElementById('mn').value == "")
    {
        mno = 0;
    }
    else
    {
        mno = document.getElementById('mn').value
    }

    sex = "M";
    //if (document.getElementById('male').checked == true) {
    //    sex = "M"
    //}
    //else { sex="F"}

   
    //if (document.getElementById('cat').selectedIndex == 3)
    //{
    //    if (document.getElementById('catn').value == "")
    //    {
    //        alert('Enter Group Name!');
    //        return false;
    //    }
    //    else
    //    {
    //        cat_id = trim(document.getElementById('catn').value)
    //    }
    //}
    //else
    //{
    //    cat_id = document.getElementById('cat').options[document.getElementById('cat').selectedIndex].text 
    //}
    cat_id = "Astro Envision Natal";
    
    document.getElementById('loading').style.display = 'block';
    
    //cat_grp =document.getElementById('DropDownList2').value;
    cat_grp = "natal";
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
    //var o= moment.utc(moment('31/12/2014 00:19', "DD/MM/YYYY HH:mm").diff(moment('31/12/2014 01:30', "DD/MM/YYYY HH:mm"))).format("HH:mm")

    var isdres = compatibilitymatchingtest.istfind(ist3, tob, dateob);
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
         
    astro_dtls = document.getElementById('username').value;
    astrologer = document.getElementById('hdnuser').value;
    document.getElementById('hdnclientemailid').value = trim(document.getElementById('txtmail').value);

    if (cat_grp.toUpperCase() == 'HORARY')
    {
        var clmail = clmail +'-'+ da1ob + mo1ob + yr1ob + ihob + imob;
    }
    if (document.getElementById('hdnuser').value != "" || document.getElementById('hdnuser').value  != null)
    {
        //window.open("homenewpage.aspx?clname=" + clname + "&clmail=" + clmail + "&astmail=" + astrologer + "&astname=" + astro_dtls + "&usermail=" + document.getElementById('hdnuser').value + "&group_u=" + cat_grp + "&group=" + cat_id + "&mobile=" + mno + "&dob=" + dateob + "&da1ofb=" + da1ob + "&mo1ofb=" + mo1ob + "&yr1ofb=" + yr1ob + "&tob=" + tob + "&hourofb=" + ihob + "&minuteofb=" + imob + "&country=" + conob + "&state=" + statob + "&dist=" + distob + "&city=" + cityob + "&latit=" + lati + "&longit=" + longi + "&tzo=" + timezone + "&tzoval=" + document.getElementById('hdntz').value + "&prof=" + profession + "&sex=" + sex + "&cd=" + cd  + "&sunsetpre=" + sunsetpre + "&sunrise=" + sunrise  + "&sunset=" + sunset  + "&sunrisenext=" + sunrisenext + "", null);
        //clear_data();
        
        document.getElementById('hdncountry').value=conob;
        document.getElementById('hdnstate').value=statob;
        document.getElementById('hdndist').value=distob;
        document.getElementById('hdncity').value=cityob;
        document.getElementById('hdnprof').value=profession;
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
        document.getElementById('Hastmail').value=astrologer;
        document.getElementById('Hastname').value=astro_dtls;
        
        document.getElementById('hdsunsetpre').value=sunsetpre;
        document.getElementById('hdsunrise').value=sunrise;
        document.getElementById('hdsunset').value=sunset;
        document.getElementById('hdsunrisenext').value=sunrisenext;
        document.getElementById('hdntzo').value=timezone;
        
        gridcall();
        
        if (document.getElementById('hdnmoc').value == 1)
        {
          //makebc()
        }
        
        calvargas();    //This function call when we click on Vargas Button.
        
        accountuser_final();  // This Function call on page load on vargas_chart.aspx page
        vargas();

        //alert('Done');
    }
    else
    {
        Response.Redirect("" + ResolveUrl("~/login.aspx") + "");
    }
   return false;
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
{document.getElementById('catn').style.display='block'
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
        res1 = compatibilitymatchingtest.update_client(astro_dtls, name, profession, age, sex, astrologer, email, cat_id, mno, cat_grp);

      

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
           
            var res = compatibilitymatchingtest.state(filter, drop_down, exec_gridcall);
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

            var res = compatibilitymatchingtest.districtt(drop_down, state,filter, exec_gridcall);
            return false;
        }
    }
    return false;
}


function StateKeyPressed(e) {
        if (window.event) {
            e = window.event;
        }
        if (e.keyCode == 13) {
            document.getElementById('state_list').style.display = 'none';
            document.getElementById('ddlstat').value=document.getElementById('state_list').options[document.getElementById('state_list').selectedIndex].innerHTML;
            document.getElementById('hdnstate').value=document.getElementById('state_list').options[document.getElementById('state_list').selectedIndex].value;
            document.getElementById('city').focus();
         }
        }
        
        
        
 function CityKeyPressed(e) {
        if (window.event) {
            e = window.event;
        }
        if (e.keyCode == 13) {
            document.getElementById('city_list').style.display = 'none';
            document.getElementById('city').value=document.getElementById('city_list').options[document.getElementById('city_list').selectedIndex].innerHTML;
            document.getElementById('hdncit').value=document.getElementById('city_list').options[document.getElementById('city_list').selectedIndex].value;
            insert_data("city_list");
            document.getElementById('mn').focus();
         }
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

    if (event.keyCode == 1333333) {

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
            var res = compatibilitymatchingtest.citys(con, state, district, city, exec_gridcall);
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

        var res = compatibilitymatchingtest.latlng(con, state, district, document.getElementById('city').value);
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
                      var res = compatibilitymatchingtest.timezone(tzid, dob1);
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
    {                  document.getElementById('tz').value = stz1[0];
                    }

                    var d1 = dob1.split('/')

                    var res = compatibilitymatchingtest.getsunsetsunrise(document.getElementById('lat').value, document.getElementById('lng').value, document.getElementById('username').value, d1[1]+'/'+d1[0]+'/'+d1[2] + ' ' + '1:00:42 AM')

                    var sssr = res.value;
                    var srss1 = sssr.split('\r\n')
                    var sr = srss1[0];
                    var ss = srss1[1];
                    var res = compatibilitymatchingtest.getsunsetsunrisea(sr, document.getElementById('hdntz').value, ss,d1[1]+'/'+d1[0]+'/'+d1[2] + ' ' + '1:00:42 AM')
                    var actsrss = res.value;
                    var sunrise = actsrss.Tables[0].Rows[0].IDOB;
                    var sunset = actsrss.Tables[1].Rows[0].IDOB;
                    
                    document.getElementById('hdsunrise').value=sunrise;
                    document.getElementById('hdsunset').value=sunset;

                    var res = compatibilitymatchingtest.getsunsetsunrise1(document.getElementById('lat').value, document.getElementById('lng').value, document.getElementById('username').value, d1[1] + '/' + d1[0] + '/' + d1[2] + ' ' + '1:00:42 AM')

                    var sssr = res.value;
                    var srss1 = sssr.split('\r\n')
                    var sr = srss1[0];
                    var ss = srss1[1];
                    
                    var res = compatibilitymatchingtest.getsunsetsunriseanext(sr, document.getElementById('hdntz').value, ss,d1[1]+'/'+d1[0]+'/'+d1[2] + ' ' + '1:00:42 AM')
                    var actsrss = res.value;
                    var sunrisenextday = actsrss.Tables[0].Rows[0].IDOB;
                    hoursob = trim(document.getElementById('hob').value);
                    document.getElementById('hdsunrisenext').value=sunrisenextday;

                    var res = compatibilitymatchingtest.getsunsetsunrise2(document.getElementById('lat').value, document.getElementById('lng').value, document.getElementById('username').value, d1[1] + '/' + d1[0] + '/' + d1[2] + ' ' + '1:00:42 AM')
                    var ssopd = res.value;
                    var ssopd1 = ssopd.split('\r\n')
                    var sr = ssopd1[0];
                    var ss = ssopd1[1];
                    
                    var res = compatibilitymatchingtest.getsunsetsunriseapre(sr, document.getElementById('hdntz').value, ss,d1[1]+'/'+d1[0]+'/'+d1[2] + ' ' + '1:00:42 AM')
                    var actsrss = res.value;
                    var sunsetpreday = actsrss.Tables[1].Rows[0].IDOB;
                    document.getElementById('hdsunsetpre').value=sunsetpreday;
                    
                    
                    minuteob = trim(document.getElementById('mob').value);
                    var tob = d1[1] + '/' + d1[0] + '/' + d1[2] + ' ' + hoursob + ':' + minuteob;
                    var user = document.getElementById('hdnuser').value;
                    resprobable = compatibilitymatchingtest.getdinrat(sunset, sunrise, sunrisenextday, tob, user)
                    
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




/* All Function Start Here For Second Step */


//var homenewpage = "";
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

    if (document.getElementById('hdnmoc').value == 1)
    {
       makebc()
    }
//    else if (document.getElementById('hdnmoc').value == 0) {
//        makeoc()
//    }
//    else
//    {
//       //searchclientid();
//    }

//    vargaschart();
    
    return false;
}
function searchclientid()
  {
  
  var clientname =document.getElementById('txtmail').value;
  var astroname=document.getElementById('Hastname').value;
  //astroname="HARI SHARMA";
  var astid1=document.getElementById('Hastmail').value;
  //astid1="hshoradm@horary.com";
  var exec = compatibilitymatchingtest.searchclientid(clientname, astroname, astid1, document.getElementById('hdngroup').value, document.getElementById('hdngroup_u').value,'');
  var ds=exec.value;
  
  if(ds.Tables[1].Rows.length > 0)
  {
  var ds1=ds.Tables[1].Rows[0].HOROSCOPE_D01;
  ds1=ds1.slice(0,-1);
   var id1 = ds1.split('~')
   for(i=0; i<id1.length; i++){
    var id2 =id1[i].split('/')
    document.getElementById('rashi_'+ i).value=id2[1];
    document.getElementById('house_'+ i ).value=id2[2];
    
    var id3 =id2[3].split('.')
    document.getElementById('degree_'+ i ).value=id3[0];
   document.getElementById('minutes_'+ i ).value=id3[1];
   document.getElementById('seconds_' + i).value = id3[2];
   document.getElementById('retrograde_' + i).value = id2[4];
    document.getElementById('constelation_'+ i ).value=id2[5];
    }
    }
    else{
    for(i=0; i<11;i++){
     
      document.getElementById('rashi_'+ i ).selectedIndex="0";
      document.getElementById('house_'+ i ).selectedIndex="0";
      document.getElementById('degree_'+ i ).selectedIndex="0";
      document.getElementById('minutes_'+ i ).selectedIndex="0";
      document.getElementById('seconds_'+ i ).selectedIndex="0";
    }
    
    }
  return false;
  }
  
function grid() {
 document.getElementById('hdsviewgrid_enduser').innerHTML = "";
 document.getElementById('Divgrid1_enduser').style.display = 'block';
  var temp_del1 = "";

    flg_req = "yes"
    var aa1 = "";
    var aa = "";
    var hs = 0;
    var hs1 = 0;
    document.getElementById('hdsviewgrid_enduser').style.display = "block";
    //$('hdsviewgrid_enduser').style.display = "block";
    if (document.getElementById("hdsviewgrid_enduser").children.length == "0") {
        klen = "0"
    }
    else {

        klen = document.getElementById("Divgrid1_enduser").childNodes[0].childNodes[0].childNodes.length - 1;
        IntializeNumber = klen + 1;
    }
     if (document.getElementById("hdsviewgrid_enduser").innerHTML.indexOf("width:530px;display:block") <= 0) 
     {
        aa = document.getElementById("hdsviewgrid_enduser").innerHTML.replace("</TBODY>", "")//</TABLE>","")
    }
    
    buf1 += "<table  id='Divgrid1_enduser' runat='server' align='left' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
    
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
    buf1 += "</tr>"

    len = 1;
    
    buf1 += "<tr>"

    buf1 += "<td class='colum-td-new'>"
    buf1 += "<input type='text' disabled class='colum-name_id' align='left'   id='planets_" + klen + "'  >"
    buf1 += "</td>"

    buf1 += "<td class='colum-td-new ' >"
    buf1 += "<select ' align='left' class='Planets-font rashi-1' AutoPostBack='true' id='rashi_" + klen + "' onChange='javascript:return enablerashi(this.id);' >"
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
    
     buf1 += "</tr>"
      buf1 += "</table>"
      var hdsview = "";
    temp_del1 = aa + buf1.toString();
    temp_del1 = temp_del1.replace("<TBODY>", "")
    temp_del1 = temp_del1.replace("</TBODY>", "")
    //alert(temp_del1)
    document.getElementById('hdsviewgrid_enduser').innerHTML = temp_del1;
    return false;
    
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

      var exea = compatibilitymatchingtest.Cal_Ascendant_Gulika(hdnmocval,dobval,dateob,monthob,yearob,timeob,hourob,hdnimob,longitudeval,latitudeval,sunsetpre,sunrise,sunset,sunrisenext,tzval);

      exea = exea.value.split('~');
      var ascnd_val="";
      var gulika_val="";
      if(exea.length>0) 
      {
       ascnd_val=exea[0];
       gulika_val=exea[1];
      }

      var exec = compatibilitymatchingtest.makebirthchart(dob, tob, tzon, parseFloat(ascnd_val),parseFloat(gulika_val));
      
      var ds = exec.value;
      if (ds.Tables[0].Rows.length > 0)
      {
        for (i = 0; i < ds.Tables[0].Rows.length; ++i) 
        {
              document.getElementById('rashi_' + i).value = ds.Tables[0].Rows[i].RASHI;
              document.getElementById('house_' + i).value = ds.Tables[0].Rows[i].HOUSE;
              document.getElementById('degree_' + i).value = ds.Tables[0].Rows[i].DEGREE;
              document.getElementById('minutes_' + i).value = ds.Tables[0].Rows[i].MINUTE;
              document.getElementById('seconds_' + i).value = ds.Tables[0].Rows[i].SECOND;
              document.getElementById('constelation_' + i).value = ds.Tables[0].Rows[i].CONSTELATION;
              document.getElementById('charan_' + i).value = ds.Tables[0].Rows[i].CHARAN;
              document.getElementById('constelationlord_' + i).value = ds.Tables[0].Rows[i].CONSTELATION_LORD;
              
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
  
  
  function grid1(i) {

     flg_req = "yes"
    var aa1 = "";
    var aa = "";
    var hs = 0;
    var hs1 = 0;


    klen = (i+1);

    buf1 = document.getElementById("hdsviewgrid_enduser").innerHTML;

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
     //$("hdsviewgrid_enduser").innerHTML = buf1.toString();
     document.getElementById('hdsviewgrid_enduser').innerHTML = buf1.toString();
     

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
    var res1 = compatibilitymatchingtest.bindrashi(vishu);
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
        var res1 = compatibilitymatchingtest.bindhouse(vishu);
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
    var res1 = compatibilitymatchingtest.binddegree(vishu);
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
    var res1 = compatibilitymatchingtest.bindminutes(vishu);
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
    var res1 = compatibilitymatchingtest.bindseconds(vishu);
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
    var res1 = compatibilitymatchingtest.bindretrograde(vishu);
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
    var res1 = compatibilitymatchingtest.bindconstelation(vishu);
    var ds = res1.value;

    document.getElementById(res).options.length = 0;
    document.getElementById(res).options[0] = new Option("--Select Constelation--", "0");

    var i;
    //if(ds!=null)
    //{
    if (ds.Tables[0].Rows.length > 0) {
        for (i = 0; i < ds.Tables[0].Rows.length; ++i) {
            document.getElementById(res).options[document.getElementById(res).options.length] = new Option(ds.Tables[0].Rows[i].NAME, ds.Tables[0].Rows[i].CODE);
            document.getElementById(res).options.length;
        }
    }
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
        document.getElementById('rashiid_enduser').style.display = "none";
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
                    j1 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j1 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j1 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j1 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j1 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j1 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j1 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j1 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j1 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j1 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                h1 = h1 + j1 + " ";


            }
            if (h == 'HOUSE2') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j2 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j2 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j2 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j2 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j2 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j2 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j2 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j2 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j2 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j2 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }


                h2 = h2 + j2 + " ";


            }

            if (h == 'HOUSE3') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j3 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j3 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j3 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j3 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j3 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j3 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j3 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j3 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j3 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j3 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h3 = h3 + j3 + " ";


            }


            if (h == 'HOUSE4') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j4 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j4 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j4 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j4 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j4 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j4 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j4 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j4 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j4 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j4 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h4 = h4 + j4 + " ";


            }

            if (h == 'HOUSE5') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j5 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j5 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j5 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j5 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j5 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j5 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j5 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j5 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j5 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j5 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h5 = h5 + j5 + " ";

            }

            if (h == 'HOUSE6') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j6 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j6 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j6 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j6 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
          }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j6 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j6 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j6 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j6 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';

                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j6 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j6 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h6 = h6 + j6 + " ";


            }

            if (h == 'HOUSE7') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j7 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j7 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j7 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j7 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j7 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j7 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j7 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j7 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j7 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j7 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                h7 = h7 + j7 + " ";


            }

            if (h == 'HOUSE8') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j8 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j8 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j8 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j8 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j8 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j8 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j8 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j8 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j8 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j8 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                h8 = h8 + j8 + " ";


            }

            if (h == 'HOUSE9') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j9 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j9 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j9 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j9 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j9 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j9 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j9 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j9 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j9 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>'  + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }


                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j9 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h9 = h9 + j9 + " ";


            }

            if (h == 'HOUSE10') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j10 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j10 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j10 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j10 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j10 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j10 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j10 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j10 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j10 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value  + '</span>' + " " +  '<span style=color:#f90914>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j10 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }

                h10 = h10 + j10 + " ";


            }

            if (h == 'HOUSE11') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j11 = 'Me'+ '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#f90914>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j11 = 'Ju'+ '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " + '<span style=color:#f90914>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j11 = 'Ve'+ '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#f90914>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j11 = 'Sa'+ '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#f90914>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j11 = 'Su'+ '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#f90914>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j11 = 'Mo'+ '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#f90914>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j11 = 'Ma'+ '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#f90914>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j11 = 'Ra'+ '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#f90914>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j11 = 'Ke'+ '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#f90914>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }


                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j11 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
                }
                h11 = h11 + j11 + " ";

            }
            if (h == 'HOUSE12') {

                if (document.getElementById('planets_' + i).value == 'MERCURY') {
                    j12 = 'Me'+ '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#f90914>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'JUPITER') {
                    j12 = 'Ju'+ '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#f90914>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'VENUS') {
                    j12 = 'Ve'+ '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#f90914>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SATURN') {
                    j12 = 'Sa'+ '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#f90914>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'SUN') {
                    j12 = 'Su'+ '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#f90914>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MOON') {
                    j12 = 'Mo'+ '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#f90914>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'MARS') {
                    j12 = 'Ma'+ '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#f90914>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'RAHU') {
                    j12 = 'Ra'+ '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value  + '</span>'  + " " +  '<span style=color:#f90914>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }
                if (document.getElementById('planets_' + i).value == 'KETU') {
                    j12 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value  + '</span>' + " " + '<span style=color:#f90914>'+document.getElementById('degree_' + i).value+'.'+document.getElementById('minutes_' + i).value+'</span>';
                }

                if (document.getElementById('planets_' + i).value == 'GULIKA') {
                    j12 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + i).value + '.' + document.getElementById('minutes_' + i).value + '</span>';
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
        document.getElementById('h1l1').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>'+document.getElementById('degree_' + 0).value+'.'+document.getElementById('minutes_' + 0).value+'</span>';
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


        ///////mobile/////////////////
        //document.getElementById('h1l1m').innerHTML = p1+" "+'Asc';
        //document.getElementById('h2l1m').innerHTML = p2;
        //document.getElementById('h3l1m').innerHTML = p3;
        //document.getElementById('h4l1m').innerHTML = p4;
        //document.getElementById('h5l1m').innerHTML = p5;
        //document.getElementById('h6l1m').innerHTML = p6;
        //document.getElementById('h7l1m').innerHTML = p7;
        //document.getElementById('h8l1m').innerHTML = p8;
        //document.getElementById('h9l1m').innerHTML = p9;
        //document.getElementById('h10l1m').innerHTML = p10;
        //document.getElementById('h11l1m').innerHTML = p11;
        //document.getElementById('h12l1m').innerHTML = p12;
        //document.getElementById('h12rm').innerHTML = r12;
        //document.getElementById('h1rm').innerHTML = r1;
        //document.getElementById('h2rm').innerHTML = r2;
        //document.getElementById('h3rm').innerHTML = r3;
        //document.getElementById('h4rm').innerHTML = r4;
        //document.getElementById('h5rm').innerHTML = r5;
        //document.getElementById('h6rm').innerHTML = r6;
        //document.getElementById('h7rm').innerHTML = r7;
        //document.getElementById('h8rm').innerHTML = r8;
        //document.getElementById('h9rm').innerHTML = r9;
        //document.getElementById('h10rm').innerHTML = r10;
        //document.getElementById('h11rm').innerHTML = r11;
        
        return false;
    }
}



/* All Function End Here For Second Step */



/* All Function Start Here For Third Step */

var v = "";
var c="";
var degree = "";
function calvargas() 
{
    if ((document.getElementById('hdnmoc').value == 0) && (parseFloat(document.getElementById('Hnewdiffm').value) > parseFloat('28.00.00') && parseFloat(document.getElementById('Hnewdiffm1').value) > parseFloat('28.00.00')) || (parseFloat(document.getElementById('Hnewdiffm').value) < parseFloat('00.00.00') && parseFloat(document.getElementById('Hnewdiffm1').value) < parseFloat('00.00.00')) || (parseFloat(document.getElementById('Hnewdiffv').value) > parseFloat('48.00.00') && parseFloat(document.getElementById('Hnewdiffv1').value) > parseFloat('48.00.00')) || (parseFloat(document.getElementById('Hnewdiffv').value) < parseFloat('00.00.00') && parseFloat(document.getElementById('Hnewdiffv1').value) < parseFloat('00.00.00')))
    {
        alert('chart is not valid');
        return false;
    }
    else 
    {
        var astname = document.getElementById('Hastname').value;
        var astid = document.getElementById('Hastmail').value;
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
        //deepak add this code

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
        
         var astmail = document.getElementById('Hastmail').value;
         var bosparameters = document.getElementById('degree_' + 2).value + "$" + document.getElementById('minutes_' + 2).value + "$" + document.getElementById('seconds_' + 2).value + "$" + document.getElementById('rashi_' + 2).value + "$" + date1 + "$" + month1 + "$" + year1 + "$" + hob + "$" + miob + "$" + stob + "$" + astmail + "$" +  dn;

        //window.open('vargas_chart.aspx?v=' + v + "&j=" + j + "&k=" + k + "&astname=" + astname + "&astid=" + astid + "&clientname=" + clientname + "&clientid=" + clientid + "&usermail=" + document.getElementById('hdnuser').value + "&c=" + c + "&dob=" + document.getElementById("hdndob").value + "&tob=" + document.getElementById("hdntob").value + "&country=" + document.getElementById("hdncountry").value + "&state=" + document.getElementById("hdnstate").value + "&district=" + document.getElementById("hdndist").value + "&city=" + document.getElementById("hdncity").value + "&group=" + document.getElementById("hdngroup").value + "&group_under=" + document.getElementById("hdngroup_u").value + "&prof=" + document.getElementById("hdnprof").value + "&sex=" + document.getElementById("hdnsex").value + "&mobile=" + document.getElementById("hdnmobile").value + "&idateob=" + idateob + "&imonthob=" + imonthob + "&iyearob=" + iyearob + "&ihourob=" + ihourob + "&iminuteob=" + iminuteob + "&longitude=" + document.getElementById('hdnlongit').value + "&latitude=" + document.getElementById('hdnlatit').value + "&timezone=" + tzo + "&tzval=" + document.getElementById('hdntzval').value + "&sunsetpre=" + sunsetpre  + "&sunrise=" + sunrise + "&sunset=" + sunset + "&sunrisenext=" + sunrisenext + "&balancedasha=" + bosparameters );
        document.getElementById('astid').innerHTML = astid;
        document.getElementById('astname').innerHTML = astname;
        
        document.getElementById('clientid').innerHTML = clientid;
        document.getElementById('clientname').innerHTML = clientname;
        document.getElementById('Hiddencons').value=c;
        document.getElementById('Hidden4').value=v;
        document.getElementById('Hidden1').value=j;
        document.getElementById('Hidden2').value=k;
        
        document.getElementById('CVal').value=c;
        document.getElementById('BalanceDashaVal').value=bosparameters;

    }
}


/* All Function End Here For Third Step */




/* All Function Start Here For Fourth Step */
function accountuser_final() {

    if (document.getElementById('hdncat').value.toUpperCase() == 'HORARY') {
        document.getElementById('cat_grp').value = 'Horary'
    }

    if (document.getElementById('hdncat').value.toUpperCase() == 'NATAL') {
        document.getElementById('cat_grp').value = 'Natal'
    }
    group_bind();
}


function group_bind() {
    var astrologer = document.getElementById('astid').innerHTML;
    if (astrologer == 'astrology' || astrologer == 'ASTROLOGY' || astrologer == "") {
        //getopen("login.aspx");
        return false;
    }
    else {
        res = compatibilitymatchingtest.searchuser(astrologer, document.getElementById('cat_grp').options[document.getElementById('cat_grp').selectedIndex].text);
        callback_drp1(res);
    }
}

function callback_drp1(res) {
     var ds = res.value;
    //var edtn = $("groupdrop_final");
     var edtn = document.getElementById('groupdrop_final');
     edtn.options.length = 1;
     edtn.options[0] = new Option("General", "0");
     if (ds != null && typeof (ds) == "object" && ds.Tables[1].Rows.length > 0) {
         for (var i = 0; i < ds.Tables[1].Rows.length; i++) {
             edtn.options[edtn.options.length] = new Option(ds.Tables[1].Rows[i].CAT_ID, ds.Tables[1].Rows[i].CAT_ID)
             edtn.options.length;
         }
     }
 }
 
 
 
function vargas()
 {
    document.getElementById('chart_final').value='D09';
    var vargas=document.getElementById('Hiddencons').value;
    document.getElementById('planet_final').value=document.getElementById('Hidden1').value;
    document.getElementById('dasha_final').value=document.getElementById('Hidden2').value;
    document.getElementById('planet_final').disabled=true;
    document.getElementById('dasha_final').disabled=true;
    compatibilitymatchingtest.vargasvalue(vargas,callback_vargas);
    return false;
}




function callback_vargas(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
    exec_data = val.value;
    var i = 0
    if (exec_data.Tables[0].Rows.length > 0) {
        document.getElementById('hdsviewgrid_final').innerHTML = "";
        document.getElementById('Divgrid1_final').style.display = 'block';
        document.getElementById('Divgrid1_final').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('hdsviewgrid_final').style.display = "block";

        if (document.getElementById("hdsviewgrid_final").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("Divgrid1_final").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("hdsviewgrid_final").innerHTML.indexOf("width:520;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid_final").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='Divgrid1_final' runat='server' align='left' Width='450px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td  class='colum-td-head'>" + "PLANET" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D1_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D1_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "BIRTH_TIME" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "R" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "DEGREE" + "</td>"
                
        buf2 += "<td  class='colum-td-head'>" + "D2_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D2_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D3_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D3_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D4_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D4_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D5_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D5_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D6_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D6_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D7_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D7_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D8_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D8_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D9_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D9_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D10_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D10_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D11_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D11_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D12_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D12_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D16_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D16_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D20_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D20_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D24_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D24_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D27_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D27_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D30_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D30_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D40_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D40_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D45_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D45_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D60_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D60_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "SHASHTYAMSHA_NAME" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "D60_NATURE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "KARAKAMSHA_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "KARAKAMSHA_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "MOON_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "MOON_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "VENUS_HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "VENUS_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "CONSTELATION" + "</td>"
        buf2 += "</tr>"


        len = 1;


        if (exec_data.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"
//                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'> "
//                buf2 += "<label  style='width:90px; font-family:helvetica;' class='dropdown_large_corr'; align='left' Text='" + exec_data.Tables[0].Rows[i]['PLANET'] + "'  id=planets_" + i + " >"
//                buf2 += "</td>"


                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='90px' class='Planets-font'>" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</font>"
               buf2 +="<input type='hidden' class='Planets-font' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['PLANET'])+">"
              buf2 += "</td>"
                
                

                 buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D1_HOUSE']) + "</font>"
               buf2 += "<input type='hidden' class='Planets-font' id=house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D1_HOUSE']) + ">"
              buf2 += "</td>"


                buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D1_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D1_RASHI'])+">"
              buf2 += "</td>"
              
               buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['BIRTH_TIME']) + "</font>"
               buf2 +="<input type='hidden' id=birth_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['BIRTH_TIME'])+">"
               buf2 += "</td>"

               buf2 += "<td class='colum-td-new1'>"
               if (exec_data.Tables[0].Rows[i]['RETRO'] == null) {
                   buf2 += "<font width='90px'></font>"
                   buf2 += "<input type='hidden' id=retrograde_" + i + " >"
                   buf2 += "</td>"
                 
               }
               else {
                   buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['RETRO']) + "</font>"
                   buf2 += "<input type='hidden' id=retrograde_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['RETRO']) + ">"
                   buf2 += "</td>"
                 }
               
                
                 buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
               buf2 +="<input type='hidden' id=degreefinal_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE'])+">"
               buf2 += "</td>"
                
                    buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D2_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d2house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D2_HOUSE'])+">"
              buf2 += "</td>"
              
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D2_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d2rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D2_RASHI'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D3_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d3house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D3_HOUSE'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D3_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d3rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D3_RASHI'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D4_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d4house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D4_HOUSE'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D4_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d4rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D4_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D5_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d5house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D5_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D5_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d5rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D5_RASHI'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D6_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d6house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D6_HOUSE'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D6_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d6rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D6_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D7_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d7house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D7_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D7_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d7rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D7_RASHI'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D8_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d8house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D8_HOUSE'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D8_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d8rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D8_RASHI'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D9_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d9house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D9_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D9_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d9rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D9_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D10_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d10house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D10_HOUSE'])+">"
              buf2 += "</td>"
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D10_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d10rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D10_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D11_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d11house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D11_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D11_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d11rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D11_RASHI'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D12_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d12house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D12_HOUSE'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D12_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d12rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D12_RASHI'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D16_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d16house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D16_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D16_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d16rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D16_RASHI'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D20_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d20house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D20_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D20_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d20rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D20_RASHI'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D24_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d24house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D24_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D24_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d24rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D24_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D27_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d27house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D27_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D27_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d27rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D27_RASHI'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D30_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d30house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D30_HOUSE'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D30_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d30rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D30_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D40_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d40house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D40_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D40_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d40rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D40_RASHI'])+">"
              buf2 += "</td>"
                 
                 
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D45_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d45house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D45_HOUSE'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D45_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d45rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D45_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D60_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d60house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D60_HOUSE'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D60_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d60rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D60_RASHI'])+">"
              buf2 += "</td>"
                
               
                     buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['SHASHTYAMSHA_NAME']) + "</font>"
               buf2 +="<input type='hidden' id=d60shash_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['SHASHTYAMSHA_NAME'])+">"
              buf2 += "</td>"
               
                
                     buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D60_NATURE']) + "</font>"
               buf2 +="<input type='hidden' id=d60nature_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D60_NATURE'])+">"
              buf2 += "</td>"
               
                
                
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['KARAKAMSHA_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=karkahouse_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['KARAKAMSHA_HOUSE'])+">"
              buf2 += "</td>"
              
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['KARAKAMSHA_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=karkarashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['KARAKAMSHA_RASHI'])+">"
              buf2 += "</td>"
              
                  buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['MOON_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=moonhouse_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['MOON_HOUSE'])+">"
              buf2 += "</td>"
              
                   buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['MOON_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=moonrashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['MOON_RASHI'])+">"
              buf2 += "</td>"
              
              buf2 += "<td class='colum-td-new1'>"
              buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['VENUS_HOUSE']) + "</font>"
              buf2 +="<input type='hidden' id=venushouse_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['VENUS_HOUSE'])+">"
              buf2 += "</td>"
              
              buf2 += "<td class='colum-td-new1'>"
              buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['VENUS_RASHI']) + "</font>"
              buf2 +="<input type='hidden' id=venusrashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['VENUS_RASHI'])+">"
              buf2 += "</td>"
              
               buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['CONSTELATION']) + "</font>"
               buf2 +="<input type='hidden' id=cons_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['CONSTELATION'])+">"
               buf2 += "</td>"
              
               buf2 += "</td>"

                buf2 += "</tr>"
            }
        }
        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        
        document.getElementById('hdsviewgrid_final').innerHTML = temp_del1;

    }
vargaschart_final();
vargaschartd01_final();

savegrid();
}



function vargaschart_final() {
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
var chartname=document.getElementById('chart_final').value;

document.getElementById('Label1_final').innerHTML = chartname+' Chart';
    document.getElementById('rashiid_final').style.display = "block";
   for (var i = 1; i <= 10; i++) 
    {
        document.getElementById('Hidden5').value = i;
            if(document.getElementById('chart_final').value=='D01')
            {
                var h = document.getElementById('house_' + i).value
                var r=document.getElementById('rashi_' + 0).value
                
            }
            
            if(document.getElementById('chart_final').value=='D02')
            {
                var h = document.getElementById('d2house_' + i).value
                var r=document.getElementById('d2rashi_' + 0).value
            }
            
            if(document.getElementById('chart_final').value=='D03')
            {
                var h = document.getElementById('d3house_' + i).value
                var r=document.getElementById('d3rashi_' + 0).value
            }
            
            if(document.getElementById('chart_final').value=='D04')
            {
                var h = document.getElementById('d4house_' + i).value
                var r=document.getElementById('d4rashi_' + 0).value
            }
            
            if(document.getElementById('chart_final').value=='D05')
            {
                var h = document.getElementById('d5house_' + i).value
                var r=document.getElementById('d5rashi_' + 0).value
            }
            
            if(document.getElementById('chart_final').value=='D06')
            {
                var h = document.getElementById('d6house_' + i).value
                var r=document.getElementById('d6rashi_' + 0).value
            }
            
            if(document.getElementById('chart_final').value=='D07')
            {
                var h = document.getElementById('d7house_' + i).value
                var r=document.getElementById('d7rashi_' + 0).value
            }
            
            if(document.getElementById('chart_final').value=='D08')
            {
                var h = document.getElementById('d8house_' + i).value
                var r=document.getElementById('d8rashi_' + 0).value
            }
            
            if(document.getElementById('chart_final').value=='D09')
            {
                var h = document.getElementById('d9house_' + i).value
                var r=document.getElementById('d9rashi_' + 0).value
            }
            
            if(document.getElementById('chart_final').value=='D10')
            {
                var h = document.getElementById('d10house_' + i).value
                var r=document.getElementById('d10rashi_' + 0).value
            }
            if(document.getElementById('chart_final').value=='D11')
            {
                var h = document.getElementById('d11house_' + i).value
                var r=document.getElementById('d11rashi_' + 0).value
            }
            
            if(document.getElementById('chart_final').value=='D12')
            {
                var h = document.getElementById('d12house_' + i).value
                var r=document.getElementById('d12rashi_' + 0).value
            }
            
            if(document.getElementById('chart_final').value=='D16')
            {
                var h = document.getElementById('d16house_' + i).value
                var r=document.getElementById('d16rashi_' + 0).value
            }
            
            if(document.getElementById('chart_final').value=='D20')
            {
                var h = document.getElementById('d20house_' + i).value
                var r=document.getElementById('d20rashi_' + 0).value
            }
            
            if(document.getElementById('chart_final').value=='D24')
            {
                var h = document.getElementById('d24house_' + i).value
                var r=document.getElementById('d24rashi_' + 0).value
            }
            
             if(document.getElementById('chart_final').value=='D27')
            {
                var h = document.getElementById('d27house_' + i).value
                var r=document.getElementById('d27rashi_' + 0).value
            }
            
            if(document.getElementById('chart_final').value=='D30')
            {
                var h = document.getElementById('d30house_' + i).value
                var r=document.getElementById('d30rashi_' + 0).value
            }
            
            if(document.getElementById('chart_final').value=='D40')
            {
                var h = document.getElementById('d40house_' + i).value
                var r=document.getElementById('d40rashi_' + 0).value
            }
            
            if(document.getElementById('chart_final').value=='D45')
            {
                var h = document.getElementById('d45house_' + i).value
                var r=document.getElementById('d45rashi_' + 0).value
            }
            
            if(document.getElementById('chart_final').value=='D60')
            {
                var h = document.getElementById('d60house_' + i).value
                var r=document.getElementById('d60rashi_' + 0).value
            }
            
            if(document.getElementById('chart_final').value=='KL')
            {
                var h = document.getElementById('karkahouse_' + i).value
                var r=document.getElementById('karkarashi_' + 0).value
            }
            
            if(document.getElementById('chart_final').value=='MOON')
            {
                var h = document.getElementById('moonhouse_' + i).value
                var r=document.getElementById('moonrashi_' + 0).value
            }
            
            if(document.getElementById('chart_final').value=='VENUS')
            {
                var h = document.getElementById('venushouse_' + i).value
                var r=document.getElementById('venusrashi_' + 0).value
            }
            
       
         
         if (h == 'HOUSE1') {
           
                   
           if (document.getElementById('planets_' + i).value == 'MERCURY') 
             {
             j1 = 'Me';
             }

            if (document.getElementById('planets_' + i).value == 'JUPITER')
              {
              j1 = 'Ju';
              }

    if (document.getElementById('planets_' + i).value == 'VENUS') 
    {
        j1 = 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN')
     {
        j1 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN') 
    {
        j1 = 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON')
     {
        j1 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS')
     {
        j1 = 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU') 
    {
        j1 = 'Ra';
}
    if (document.getElementById('planets_' + i).value == 'KETU') 
    {
        j1= 'Ke';
    }

    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j1 = 'Gk';
    }
      h1 =h1+j1 + " ";
    
            
        }
        if (h == 'HOUSE2') 
        {
            
            if (document.getElementById('planets_' + i).value == 'MERCURY') 
            {
        j2 = 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER') 
    {
        j2 = 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS') 
    {
        j2 = 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN')
     {
        j2 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN') 
    {
        j2 = 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON')
     {
        j2 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS') 
    {
        j2 = 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU')
     {
        j2 = 'Ra';
}
    if (document.getElementById('planets_' + i).value == 'KETU')
     {
        j2 = 'Ke';
    }

    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j2 = 'Gk';
    }

   

    h2 = h2+j2 + " ";
   
            
        }

         if (h == 'HOUSE3') 
        {
           
           if (document.getElementById('planets_' + i).value == 'MERCURY')
            {
        j3 = 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER')
     {
        j3 = 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS')
     {
       j3 = 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN') 
    {
        j3 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN')
     {
        j3= 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON')
     {
        j3 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS')
     {
        j3 = 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU') 
    {
        j3 = 'Ra';
}
    if (document.getElementById('planets_' + i).value == 'KETU')
     {
        j3 = 'Ke';
    }
    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j3 = 'Gk';
    }
  
    h3 =h3+ j3 + " ";
   
           
        }


        if (h == 'HOUSE4') {
           
           if (document.getElementById('planets_' + i).value == 'MERCURY')
            {
        j4 = 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER')
     {
        j4 = 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS') 
    {
        j4 = 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN') 
    {
        j4 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN') 
    {
        j4 = 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON') 
    {
        j4 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS')
     {
        j4 = 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU') 
    {
        j4 = 'Ra';
}
    if (document.getElementById('planets_' + i).value == 'KETU')
     {
        j4 = 'Ke';
    }
    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j4 = 'Gk';
    }

    h4 =h4+ j4 + " ";
    
           
        }

        if (h == 'HOUSE5') {
            
            if (document.getElementById('planets_' + i).value == 'MERCURY')
             {
        j5 = 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER')
     {
        j5 = 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS') 
    {
        j5 = 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN')
     {
        j5 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN') 
    {
        j5 = 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON')
     {
        j5 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS')
     {
        j5 = 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU')
     {
       j5 = 'Ra';
}
    if (document.getElementById('planets_' + i).value == 'KETU')
     {
        j5 = 'Ke';
    }
    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j5 = 'Gk';
    }

    h5 =h5+ j5 + " ";
    
        }

        if (h == 'HOUSE6') {
            
            if (document.getElementById('planets_' + i).value == 'MERCURY') 
            {
        j6= 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER')
     {
        j6= 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS') 
    {
        j6 = 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN')
     {
        j6 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN')
     {
        j6 = 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON')
     {
        j6 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS')
     {
       j6 = 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU')
     {
        j6 = 'Ra';

}
    if (document.getElementById('planets_' + i).value == 'KETU')
     {
        j6= 'Ke';
    }
    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j6 = 'Gk';
    }


    h6 =h6+ j6 + " ";
   
            
        }

        if (h == 'HOUSE7') {
           
            if (document.getElementById('planets_' + i).value == 'MERCURY')
             {
        j7 = 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER')
     {
        j7 = 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS')
     {
        j7 = 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN') 
    {
        j7 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN')
     {
      j7 = 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON')
     {
        j7 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS')
     {
        j7 = 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU')
     {
        j7= 'Ra';
}
    if (document.getElementById('planets_' + i).value == 'KETU')
     {
        j7 = 'Ke';
    }
  
    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j7 = 'Gk';
    }

    h7 =h7+ j7 + " ";
    
            
        }

        if (h == 'HOUSE8') {
           
            if (document.getElementById('planets_' + i).value == 'MERCURY')
             {
       j8= 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER')
     {
        j8 = 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS')
     {
       j8 = 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN') 
    {
        j8 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN') 
    {
        j8= 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON')
     {
        j8 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS') 
    {
        j8= 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU')
     {
        j8= 'Ra';
}
    if (document.getElementById('planets_' + i).value == 'KETU') 
    {
       j8 = 'Ke';
    }

    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j8 = 'Gk';
    }


    h8 =h8+ j8 + " ";
    
           
        }

        if (h == 'HOUSE9') {
            
            if (document.getElementById('planets_' + i).value == 'MERCURY') 
            {
       j9 = 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER') 
    {
        j9 = 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS')
     {
        j9= 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN') 
    {
        j9 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN')
     {
       j9 = 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON') 
    {
        j9 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS') 
    {
        j9= 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU') 
    {
       j9= 'Ra';
}
    if (document.getElementById('planets_' + i).value == 'KETU') 
    {
        j9 = 'Ke';
    }
    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j9 = 'Gk';
    }
    

    h9 =h9+ j9 + " ";
   
            
        }

        if (h == 'HOUSE10') {
            
            if (document.getElementById('planets_' + i).value == 'MERCURY')
             {
        j10 = 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER')
     {
        j10 = 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS') 
    {
        j10 = 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN') 
    {
        j10= 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN')
     {
        j10 = 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON')
     {
        j10 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS')
     {
        j10 = 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU')
     {
        j10 = 'Ra';
}
    if (document.getElementById('planets_' + i).value == 'KETU') 
    {
        j10 = 'Ke';
    }
    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j10 = 'Gk';
    }


   

    h10 =h10+ j10 + " ";
   
           
        }

        if (h == 'HOUSE11') {
            
            if (document.getElementById('planets_' + i).value == 'MERCURY')
             {
        j11 = 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER') 
    {
        j11 = 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS')
     {
        j11= 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN') 
    {
        j11 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN') 
    {
        j11 = 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON') 
    {
        j11 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS')
     {
        j11 = 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU') 
    {
        j11= 'Ra';
}
    if (document.getElementById('planets_' + i).value == 'KETU')
     {
        j11 = 'Ke';
    }

    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j11 = 'Gk';
    }


    h11 =h11+ j11 + " ";
    
}
            if (h == 'HOUSE12') {
                
               if (document.getElementById('planets_' + i).value == 'MERCURY')
                {
       j12 = 'Me';
    }

    if (document.getElementById('planets_' + i).value == 'JUPITER')
     {
        j12= 'Ju';
    }

    if (document.getElementById('planets_' + i).value == 'VENUS')
     {
        j12 = 'Ve';
    }

    if (document.getElementById('planets_' + i).value == 'SATURN')
     {
       j12 = 'Sa';
    }

    if (document.getElementById('planets_' + i).value == 'SUN')
     {
        j12= 'Su';
    }

    if (document.getElementById('planets_' + i).value == 'MOON')
     {
        j12 = 'Mo';
    }

    if (document.getElementById('planets_' + i).value == 'MARS')
     {
        j12 = 'Ma';
    }

    if (document.getElementById('planets_' + i).value == 'RAHU') {
        j12 = 'Ra';
    }
    if (document.getElementById('planets_' + i).value == 'KETU')
     {
        j12 = 'Ke';
    }
    if (document.getElementById('planets_' + i).value == 'GULIKA') {
        j12 = 'Gk';
    }
   
    h12 =h12+ j12 + " ";
  
     
          
        }

    }
    if (r == 'Aries') 
    {
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
    p2 = h2 ;
    p3 = h3;
    p4 = h4; 
    p5 = h5;
    p6 = h6; 
    p7 = h7 ;
    p8 = h8 ; 
    p9 = h9 ;
    p10 = h10 ;
    p11 = h11 ;
    p12 = h12;
document.getElementById('h1l1_final').innerHTML = p1+" "+'Asc';
document.getElementById('h2l1_final').innerHTML = p2;
document.getElementById('h3l1_final').innerHTML = p3;
document.getElementById('h4l1_final').innerHTML = p4;
document.getElementById('h5l1_final').innerHTML = p5;
document.getElementById('h6l1_final').innerHTML = p6;
document.getElementById('h7l1_final').innerHTML = p7;
document.getElementById('h8l1_final').innerHTML = p8;
document.getElementById('h9l1_final').innerHTML = p9;
document.getElementById('h10l1_final').innerHTML = p10;
document.getElementById('h11l1_final').innerHTML = p11;
document.getElementById('h12l1_final').innerHTML = p12;
document.getElementById('h12r_final').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r12 + '</span>' + '</br>';
document.getElementById('h1r_final').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r1 + '</span>' + '</br>';
document.getElementById('h2r_final').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r2 + '</span>' + '</br>';
document.getElementById('h3r_final').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r3 + '</span>' + '</br>';
document.getElementById('h4r_final').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r4 + '</span>' + '</br>';
document.getElementById('h5r_final').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r5 + '</span>' + '</br>';
document.getElementById('h6r_final').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r6 + '</span>' + '</br>';
document.getElementById('h7r_final').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r7 + '</span>' + '</br>';
document.getElementById('h8r_final').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r8 + '</span>' + '</br>';
document.getElementById('h9r_final').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r9 + '</span>' + '</br>';
document.getElementById('h10r_final').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r10 + '</span>' + '</br>';
document.getElementById('h11r_final').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r11 + '</span>' + '</br>';
    
    return false;
}


function vargaschartd01_final() {
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
var deg="";
var deg1="";

var chartname='D01'
   document.getElementById('Label1d01').innerHTML = chartname+' Chart';
         
         
    document.getElementById('rashiidd01').style.display = "block";
   for (var i = 1; i <= 10; i++) 
    {
        document.getElementById('Hidden5d01').value = i;
           
                var h = document.getElementById('house_' + i).value
                var r=document.getElementById('rashi_' + 0).value


                if (document.getElementById('retrograde_' + i).value == "B") {
                    document.getElementById('retrograde_' + i).value = "";
                }


                if (h == 'HOUSE1') {
                
                    deg = document.getElementById('degreefinal_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j1 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j1 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j1 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j1 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j1 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j1 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j1 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j1 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j1 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j1 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    h1 = h1 + j1 + " ";


                }
                if (h == 'HOUSE2') {
                     
                     deg = document.getElementById('degreefinal_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j2 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j2 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j2 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j2 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j2 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j2 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j2 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j2 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j2 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j2 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    h2 = h2 + j2 + " ";
  
                }

                if (h == 'HOUSE3') {
                     deg = document.getElementById('degreefinal_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j3 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j3 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j3 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j3 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j3 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j3 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j3 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j3 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j3 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j3 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    h3 = h3 + j3 + " ";


                }


                if (h == 'HOUSE4') {
                     deg = document.getElementById('degreefinal_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j4 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j4 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j4 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j4 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j4 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j4 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j4 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j4 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j4 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j4 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    h4 = h4 + j4 + " ";


                }

                if (h == 'HOUSE5') {
                     deg = document.getElementById('degreefinal_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j5 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j5 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j5 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j5 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j5 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j5 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j5 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j5 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j5 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j5 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    h5 = h5 + j5 + " ";

                }

                if (h == 'HOUSE6') {
                     deg = document.getElementById('degreefinal_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j6 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j6 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j6 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j6 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j6 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j6 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j6 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j6 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';

                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j6 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j6 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    h6 = h6 + j6 + " ";


                }

                if (h == 'HOUSE7') {
                     deg = document.getElementById('degreefinal_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j7 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j7 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j7 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j7 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j7 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j7 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j7 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j7 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j7 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j7 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    h7 = h7 + j7 + " ";


                }

                if (h == 'HOUSE8') {
                     deg = document.getElementById('degreefinal_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j8 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j8 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j8 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j8 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j8 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j8 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j8 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j8 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j8 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j8 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    h8 = h8 + j8 + " ";


                }

                if (h == 'HOUSE9') {
                     deg = document.getElementById('degreefinal_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j9 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j9 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j9 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j9 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j9 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j9 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j9 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j9 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j9 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j9 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }


                    h9 = h9 + j9 + " ";


                }

                if (h == 'HOUSE10') {
                     deg = document.getElementById('degreefinal_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j10 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j10 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j10 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j10 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j10 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j10 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j10 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j10 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j10 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j10 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }


                    h10 = h10 + j10 + " ";


                }

                if (h == 'HOUSE11') {
                     deg = document.getElementById('degreefinal_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j11 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j11 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j11 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j11 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j11 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j11 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j11 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j11 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j11 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j11 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }


                    h11 = h11 + j11 + " ";

                }
                if (h == 'HOUSE12') {
                    deg = document.getElementById('degreefinal_' + i).value.split('.');
                    deg1 = deg[0] + '.' + deg[1];
                    if (document.getElementById('planets_' + i).value == 'MERCURY') {
                        j12 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'JUPITER') {
                        j12 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'VENUS') {
                        j12 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SATURN') {
                        j12 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'SUN') {
                        j12 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MOON') {
                        j12 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'MARS') {
                        j12 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }

                    if (document.getElementById('planets_' + i).value == 'RAHU') {
                        j12 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'KETU') {
                        j12 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                    }
                    if (document.getElementById('planets_' + i).value == 'GULIKA') {
                        j12 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
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
         
document.getElementById('h1l1d01').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' +0).value  + '</span>';
document.getElementById('h2l1d01').innerHTML = p2;
document.getElementById('h3l1d01').innerHTML = p3;
document.getElementById('h4l1d01').innerHTML = p4;
document.getElementById('h5l1d01').innerHTML = p5;
document.getElementById('h6l1d01').innerHTML = p6;
document.getElementById('h7l1d01').innerHTML = p7;
document.getElementById('h8l1d01').innerHTML = p8;
document.getElementById('h9l1d01').innerHTML = p9;
document.getElementById('h10l1d01').innerHTML = p10;
document.getElementById('h11l1d01').innerHTML = p11;
document.getElementById('h12l1d01').innerHTML = p12;
document.getElementById('h12rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r12 + '</span>' + '</br>';
document.getElementById('h1rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r1 + '</span>' + '</br>';
document.getElementById('h2rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r2 + '</span>' + '</br>';
document.getElementById('h3rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r3 + '</span>' + '</br>';
document.getElementById('h4rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r4 + '</span>' + '</br>';
document.getElementById('h5rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r5 + '</span>' + '</br>';
document.getElementById('h6rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r6 + '</span>' + '</br>';
document.getElementById('h7rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r7 + '</span>' + '</br>';
document.getElementById('h8rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r8 + '</span>' + '</br>';
document.getElementById('h9rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r9 + '</span>' + '</br>';
document.getElementById('h10rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r10 + '</span>' + '</br>';
document.getElementById('h11rd01').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r11 + '</span>' + '</br>';
    
    return false;
}


function savegrid()
{
d01=""
d02=""
d03=""
d04=""
d05=""
d06=""
d07=""
d08=""
d09=""
d10=""
d11=""
d12=""
d16=""
d20=""
d24=""
d27=""
d30=""
d40=""
d45=""
d60=""
kl=""
retro=""

for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) 
{

  var planet=document.getElementById('planets_'+i).value;  
  var house=document.getElementById('house_'+i).value;
  var rashi=document.getElementById('rashi_'+i).value;
  var degree=document.getElementById('degreefinal_'+i).value;
  var birth=document.getElementById('birth_'+i).value;
  var cons=document.getElementById('cons_'+i).value;
  var d2house=document.getElementById('d2house_'+i).value;
  var d2rashi=document.getElementById('d2rashi_'+i).value;
  var d3house=document.getElementById('d3house_'+i).value;
  var d3rashi=document.getElementById('d3rashi_'+i).value;
  var d4house=document.getElementById('d4house_'+i).value;
  var d4rashi=document.getElementById('d4rashi_'+i).value;
  var d5house=document.getElementById('d5house_'+i).value;
  var d5rashi=document.getElementById('d5rashi_'+i).value;
  var d6house=document.getElementById('d6house_'+i).value;
  var d6rashi=document.getElementById('d6rashi_'+i).value;
  var d7house=document.getElementById('d7house_'+i).value;
  var d7rashi=document.getElementById('d7rashi_'+i).value;
  var d8house=document.getElementById('d8house_'+i).value;
  var d8rashi=document.getElementById('d8rashi_'+i).value;
  var d9house=document.getElementById('d9house_'+i).value;
  var d9rashi=document.getElementById('d9rashi_'+i).value;
  var d10house=document.getElementById('d10house_'+i).value;
  var d10rashi=document.getElementById('d10rashi_'+i).value;
  var d11house=document.getElementById('d11house_'+i).value;
  var d11rashi=document.getElementById('d11rashi_'+i).value;
  var d12house=document.getElementById('d12house_'+i).value;
  var d12rashi=document.getElementById('d12rashi_'+i).value;
  var d16house=document.getElementById('d16house_'+i).value;
  var d16rashi=document.getElementById('d16rashi_'+i).value;
  var d20house=document.getElementById('d20house_'+i).value;
  var d20rashi=document.getElementById('d20rashi_'+i).value;
  var d24house=document.getElementById('d24house_'+i).value;
  var d24rashi=document.getElementById('d24rashi_'+i).value;
  var d27house=document.getElementById('d27house_'+i).value;
  var d27rashi=document.getElementById('d27rashi_'+i).value;
  var d30house=document.getElementById('d30house_'+i).value;
  var d30rashi=document.getElementById('d30rashi_'+i).value;
  var d40house=document.getElementById('d40house_'+i).value;
  var d40rashi=document.getElementById('d40rashi_'+i).value;
  var d45house=document.getElementById('d45house_'+i).value;
  var d45rashi=document.getElementById('d45rashi_'+i).value;
  var d60house=document.getElementById('d60house_'+i).value;
  var d60rashi=document.getElementById('d60rashi_'+i).value;
  var klhouse=document.getElementById('karkahouse_'+i).value;
  var klrashi=document.getElementById('karkarashi_'+i).value;

  if (document.getElementById('retrograde_' + i).value == "")
  { var rvalue = 'B' }
  else
  { var rvalue = document.getElementById('retrograde_' + i).value 
    }

  var d01 = d01 + document.getElementById('planets_' + i).value + "/" + document.getElementById('rashi_' + i).value + "/" + document.getElementById('house_' + i).value + "/" + document.getElementById('degreefinal_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"

  var d02 = d02 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d2rashi_' + i).value + "/" + document.getElementById('d2house_' + i).value + "/" + document.getElementById('degreefinal_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d03 = d03 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d3rashi_' + i).value + "/" + document.getElementById('d3house_' + i).value + "/" + document.getElementById('degreefinal_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d04 = d04 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d4rashi_' + i).value + "/" + document.getElementById('d4house_' + i).value + "/" + document.getElementById('degreefinal_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d05 = d05 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d5rashi_' + i).value + "/" + document.getElementById('d5house_' + i).value + "/" + document.getElementById('degreefinal_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d06 = d06 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d6rashi_' + i).value + "/" + document.getElementById('d6house_' + i).value + "/" + document.getElementById('degreefinal_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d07 = d07 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d7rashi_' + i).value + "/" + document.getElementById('d7house_' + i).value + "/" + document.getElementById('degreefinal_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d08 = d08 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d8rashi_' + i).value + "/" + document.getElementById('d8house_' + i).value + "/" + document.getElementById('degreefinal_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d09 = d09 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d9rashi_' + i).value + "/" + document.getElementById('d9house_' + i).value + "/" + document.getElementById('degreefinal_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d10 = d10 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d10rashi_' + i).value + "/" + document.getElementById('d10house_' + i).value + "/" + document.getElementById('degreefinal_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d11 = d11 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d11rashi_' + i).value + "/" + document.getElementById('d11house_' + i).value + "/" + document.getElementById('degreefinal_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d12 = d12 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d12rashi_' + i).value + "/" + document.getElementById('d12house_' + i).value + "/" + document.getElementById('degreefinal_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d16 = d16 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d16rashi_' + i).value + "/" + document.getElementById('d16house_' + i).value + "/" + document.getElementById('degreefinal_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d20 = d20 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d20rashi_' + i).value + "/" + document.getElementById('d20house_' + i).value + "/" + document.getElementById('degreefinal_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d24 = d24 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d24rashi_' + i).value + "/" + document.getElementById('d24house_' + i).value + "/" + document.getElementById('degreefinal_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d27 = d27 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d27rashi_' + i).value + "/" + document.getElementById('d27house_' + i).value + "/" + document.getElementById('degreefinal_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d30 = d30 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d30rashi_' + i).value + "/" + document.getElementById('d30house_' + i).value + "/" + document.getElementById('degreefinal_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d40 = d40 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d40rashi_' + i).value + "/" + document.getElementById('d40house_' + i).value + "/" + document.getElementById('degreefinal_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d45 = d45 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d45rashi_' + i).value + "/" + document.getElementById('d45house_' + i).value + "/" + document.getElementById('degreefinal_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var d60 = d60 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d60rashi_' + i).value + "/" + document.getElementById('d60house_' + i).value + "/" + document.getElementById('degreefinal_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
  var kl = kl + document.getElementById('planets_' + i).value + "/" + document.getElementById('karkarashi_' + i).value + "/" + document.getElementById('karkahouse_' + i).value + "/" + document.getElementById('degreefinal_' + i).value + "/" + rvalue + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
 
}

var sunsetpre = document.getElementById('hdsunsetpre').value;
var sunrise = document.getElementById('hdsunrise').value;
var sunset = document.getElementById('hdsunset').value;
var sunrisenext = document.getElementById('hdsunrisenext').value;


 var dsdob = compatibilitymatchingtest.GetDayOfBirth(document.getElementById('hdndob').value);
 dsdobfinal = dsdob.value;
 if (dsdobfinal.Tables[0].Rows.length > 0)
 {
   for (i = 0; i < dsdobfinal.Tables[0].Rows.length; ++i)
    {
       document.getElementById('hddayofbirth').value=dsdobfinal.Tables[0].Rows[i]['DayOB'];
    }
 }
 var dayofbirth_val = document.getElementById('hddayofbirth').value;



 var dsval = compatibilitymatchingtest.GetRashi_Constellation(document.getElementById('CVal').value);
 dsvalfinal = dsval.value;
 if (dsvalfinal.Tables[0].Rows.length > 0)
 {
   for (i = 0; i < dsvalfinal.Tables[0].Rows.length; ++i)
    {
       document.getElementById('hdrashi').value=dsvalfinal.Tables[0].Rows[i]['Rashi'];
       document.getElementById('hdconstellation').value=dsvalfinal.Tables[0].Rows[i]['Constellation'];
    }
 }
var rashi_val = document.getElementById("hdrashi").value;
var constellation_val = document.getElementById("hdconstellation").value;
var longitude_val= document.getElementById('hdnlongit').value;
var latitude_val= document.getElementById('hdnlatit').value;
var timezone_val= document.getElementById('hdntzo').value;


var dsdnd = compatibilitymatchingtest.GetDayNightDuration(sunrise,sunset,sunrisenext);
 dsdndfinal = dsdnd.value;
 if (dsdndfinal.Tables[0].Rows.length > 0)
 {
   for (i = 0; i < dsdndfinal.Tables[0].Rows.length; ++i)
    {
       document.getElementById('hdndayduration').value=dsdndfinal.Tables[0].Rows[i]['DayDuration']
       document.getElementById('hdnnightduration').value=dsdndfinal.Tables[0].Rows[i]['NightDuration']
    }
 }
var dayduration_val= document.getElementById('hdndayduration').value;
var nightduration_val= document.getElementById('hdnnightduration').value;

 var dsbdval = compatibilitymatchingtest.GetBalance_Dasha(document.getElementById('BalanceDashaVal').value);
 dsbdvalfinal = dsbdval.value;
 if (dsbdvalfinal.Tables[0].Rows.length > 0)
 {
   for (i = 0; i < dsbdvalfinal.Tables[0].Rows.length; ++i)
    {
       document.getElementById('hdnbalancedasha').value=dsbdvalfinal.Tables[0].Rows[i]['BalanceDasha'];
    }
 }
 
var balancedasha_val=document.getElementById('hdnbalancedasha').value;
var group = document.getElementById('hdngroup').value;
var dasha = document.getElementById('dasha_final').value;
var astname=document.getElementById('astname').innerHTML;
var astid=document.getElementById('astid').innerHTML;
 var client = document.getElementById('clientname').innerHTML;
 var clientid = document.getElementById('clientid').innerHTML;
 
 //var pwdval=document.getElementById('txtpwd').value;

 var pwdval = "123";
  if (client == "" || clientid == "") {
      alert('Enter Client Name');
      document.getElementById('clinetnamediv').style.display = 'block';
      var astrologer = astid
      res = compatibilitymatchingtest.searchuser(astrologer, document.getElementById('cat_grp').options[document.getElementById('cat_grp').selectedIndex].text);
      callback_drp1(res)
      return false;
  }


   var res = compatibilitymatchingtest.chechduplicacy(astid, astname, client, clientid, document.getElementById("hdngroup").value, document.getElementById("hdngroup_u").value);
   var ds=res.value;
   if(ds.Tables[0].Rows.length > 2) //0
   {
       alert('client Horoscope already saved in this group')
       document.getElementById('clinetnamediv').style.display = 'block';
       var astrologer = astid
       res = compatibilitymatchingtest.searchuser(astrologer, document.getElementById('hdngroup_u').value);
       callback_drp1(res)
       return false;
   }
   else
   {
         var chartdetails="";
         var lagnarashi_final="";
         if(document.getElementById("hdngroup_u").value.toUpperCase()=="HORARY")
         {
             var ss = "";
             for (i = 1; i <= 10; i++) 
             {
             var dd = document.getElementById('degreefinal_' + i).value
             dd = dd.split('.')
             dd=dd[0] + '.' + dd[1];
             ss = ss + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "~" + dd + "$";
             }
             ss =ss.slice(0, -1);
             chartdetails=ss;
             lagnarashi_final = document.getElementById('rashi_0').value;
         }
         else
         {
             lagnarashi_final = document.getElementById('rashi_0').value;
         }
         
        var resid = compatibilitymatchingtest.savecharts_enduser(d01, d02, d03, d04, d05, d06, d07, d08, d09, d10, d11, d12, d16, d20, d24, d27, d30, d40, d45, d60, kl, astid, astname, client, clientid, dasha, document.getElementById("hdndob").value, document.getElementById("hdntob").value, document.getElementById("hdncountry").value, document.getElementById("hdnstate").value, document.getElementById("hdndist").value, document.getElementById("hdncity").value, document.getElementById("hdngroup").value, document.getElementById("hdngroup_u").value, document.getElementById("hdnprof").value, document.getElementById("hdnsex").value, document.getElementById("hdnmobile").value,sunsetpre,sunrise,sunset,sunrisenext,dayofbirth_val,rashi_val,constellation_val,longitude_val,latitude_val,timezone_val,dayduration_val,nightduration_val,balancedasha_val,document.getElementById('hdnclientemailid').value,pwdval,lagnarashi_final,chartdetails);
        var dsid = resid.value;
        alert(dsid.Tables[0].Rows.length);
        var CID="";
        if(dsid.Tables[0].Rows.length > 0)
        {
            CID = dsid.Tables[0].Rows[0]['CLIENTID'];
            alert(CID);
            ////var Cartid = document.getElementById("hdncartid").value;
            ////var resupdateid = compatibilitymatchingtest.UpdateToCartBilling_UserId(CID,Cartid);
            ////var dsupdateid = resupdateid.value;
        }
        document.getElementById('loading').style.display = 'none';
        alert('Data saved successfully !');
        //window.open('astro_client_details.aspx?clientemailid=' + clientid + '');
       
       // start code for Nature Of Query //
       
       ////if(document.getElementById("hdngroup_u").value.toUpperCase()=="HORARY")
       ////{
       ////  GetAllHoraryQuestion(chartdetails,lagnarashi_final,astid,clientid);
       ////  //alert('Data updated successfully !');
       ////}
       
       // End code for Nature Of Query //
       
       
        // start code for Natal Predictive //
        
       ////if(document.getElementById("hdngroup_u").value.toUpperCase()=="NATAL")
       ////{
       ////   GetAllNatalQuestion();
       ////   //alert('Natal Data updated successfully !');
       ////   alert('Your report generated successfully !');
       //// }
       
       // End code for Natal Predictive //
       
       
        
       ////if(document.getElementById("hdncountrycode").value.toUpperCase()=="IN")
       ////{
       ////     window.open('thankyou_ccavenue.aspx?cartid='+ document.getElementById('hdncartid').value + '&clientid=' + CID + '&clientemailid=' + clientid + '&group=' + document.getElementById("hdngroup_u").value.toUpperCase() + '', "_self");
       ////}
       ////else
       ////{
       ////     window.open('thankyou_ccavenue.aspx?cartid='+ document.getElementById('hdncartid').value + '&clientid=' + CID + '&clientemailid=' + clientid + '&group=' + document.getElementById("hdngroup_u").value.toUpperCase() + '', "_self");
       ////}
       
//       if(document.getElementById("hdncountrycode").value.toUpperCase()=="IN")
//       {
//          window.open('auto_ccavenue.aspx?member='+ document.getElementById('hdncartid').value + '&amount=' + document.getElementById('TotalAmounts').value + '&clientemailid=' + clientid + '&group=' + document.getElementById("hdngroup_u").value.toUpperCase() + '');
//       }
//       else
//       {
//         window.open('auto_paypal.aspx?member='+ document.getElementById('hdncartid').value + '&amount=' + document.getElementById('TotalAmounts').value + '&uid=sdfaananana&catid='+ document.getElementById('hdncartid').value + '&username=dsf&emailid=sdf@das.com&city=asdassadsad&state=asdassadsad&country=USA&address=&phone=423&zipcode=21321&currency_type=USD');
//       }
       
       //window.open('thankyou.aspx?cartid='+ document.getElementById('hdncartid').value + '&clientemailid=' + clientid + '&group=' + document.getElementById("hdngroup_u").value.toUpperCase() + '');
       //window.open('thankyou_ccavenue.aspx?cartid='+ document.getElementById('hdncartid').value + '&clientemailid=' + clientid + '&group=' + document.getElementById("hdngroup_u").value.toUpperCase() + '');
       
    return false;
 }
   
  return false;
}


   function GetAllNatalQuestion() 
   {
         var chart=document.getElementById('chart_final').value;
         chart="D01";
         var s = "";
         var ss="";var kk = "0";var key="";
         for (var i = 0; i < 11; i++)
         {
          var degree=document.getElementById('degreefinal_' + i).value
          var degree1=degree.split('.');
          if(chart=='D01')
          {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$"; 
          }
          if(chart=='D09')
          {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d9rashi_' + i).value + "~" + document.getElementById('d9house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
          }
         }
         var rashi = document.getElementById('rashi_' + 0).value;
         var searchpage = s + "/" + rashi+ "/" + chart;
         
         var v="";
         var j="";
         var k="0"; var planets="";
         var astmail=document.getElementById('astid').innerHTML;;
         var clmail=document.getElementById('clientid').innerHTML;
         
         var cartid =document.getElementById('hdncartid').value;
//         var Grid_Table = document.getElementById('GvHoraryQuestions');
//         var rowCount = Grid_Table.rows.length;
//         var currRow;
         var executepro="N";
         var sessionid="",predictivetype="";
//         for (var i = 1; i < rowCount; i++) 
//         {
//            currRow = Grid_Table.rows[i];
//            var GroupType = currRow.cells[0].innerText;
//            var Category = currRow.cells[1].innerText;
//            alert(GroupType);
//            alert(Category);
            res = compatibilitymatchingtest.get_allhorarynatal_question(cartid,"","NATAL","","GETALLNATALQUESTIONS");
            var dsn = res.value;
            if (dsn != null && dsn.Tables[0].Rows.length > 0) 
            {
              for (var j = 0; j < dsn.Tables[0].Rows.length; j++) 
              {
                 var Autoid= dsn.Tables[0].Rows[j]['AUTOID']; 
                 var Questionid= dsn.Tables[0].Rows[j]['QUESTIONID'];
                 var CatName= dsn.Tables[0].Rows[j]['CATNAME'];
                 var CatId= dsn.Tables[0].Rows[j]['CATID'];
                 var Question= dsn.Tables[0].Rows[j]['QUESTION'];
                 var resds= compatibilitymatchingtest.get_natal_questions_substring(CatId,Questionid,Question,"NATAL");
                 dsqsub=resds.value;
                 if (dsqsub != null && dsqsub.Tables[0].Rows.length > 0) 
                 {
                    for (var d = 0; d < dsqsub.Tables[0].Rows.length; d++) 
                    {
                       ss = ss + dsqsub.Tables[0].Rows[d]['CATEGERY'] + "$";
                    }
                    if (ss != "") 
                    {
                      ss = ss.slice(0, -1);
                    }
                 }
                 
                 if(CatId=="10")  //This Condition for Manglik Dosha
                 {   
                     var lagnastr="",lagna_house="";
                     var moonstr="",moon_house="";
                     var venusstr="",venus_house="";
                     for (var i = 0; i < 11; i++)
                     {
                        var degree=document.getElementById('degreefinal_' + i).value
                        var degree1=degree.split('.');
                        var lagnastr = lagnastr + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
                        if(document.getElementById('planets_' + i).value.toUpperCase()=="MARS")
                        {
                        lagna_house=document.getElementById('house_' + i).value;
                        }
                        var moonstr = moonstr + document.getElementById('planets_' + i).value + "~" + document.getElementById('moonrashi_' + i).value + "~" + document.getElementById('moonhouse_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
                        if(document.getElementById('planets_' + i).value.toUpperCase()=="MARS")
                        {
                        moon_house=document.getElementById('moonhouse_' + i).value;
                        }
                        var venusstr = venusstr + document.getElementById('planets_' + i).value + "~" + document.getElementById('venusrashi_' + i).value + "~" + document.getElementById('venushouse_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
                        if(document.getElementById('planets_' + i).value.toUpperCase()=="MARS")
                        {
                        venus_house=document.getElementById('venushouse_' + i).value;
                        }
                      }
                      document.getElementById('Hs').value=lagnastr;
                      document.getElementById('Hm').value=moonstr;
                      document.getElementById('Hv').value=venusstr;
                      var respaap = compatibilitymatchingtest.pn("Paap Samya",document.getElementById('Hs').value,document.getElementById('Hm').value,document.getElementById('Hv').value,astmail);
                      var respaapds = respaap.value;
                      if (respaapds.Tables[0].Rows.length > 0)
                      {
                         for (var p = 0; p < respaapds.Tables[0].Rows.length; p++) 
                         {
                             if(respaapds.Tables[0].Rows[p]['DESCCLOB']=="MARS")
                             {
                               var lagnapoint = respaapds.Tables[0].Rows[p]['KEY_STRING'] // Lagna
                               var moonpoint = respaapds.Tables[0].Rows[p]['PLANET']      // Moon
                               var venuspoint = respaapds.Tables[0].Rows[p]['CHART_NO']   // Venus
                               var total= parseFloat(lagnapoint)+parseFloat(moonpoint)+parseFloat(venuspoint);

                               var mdr=compatibilitymatchingtest.Get_Manglik_Dosha_Result("MARS","LAGNA","MOON","VENUS",lagnapoint,moonpoint,venuspoint,"ManglikDosha","","");
                               var mdrds = mdr.value;
                               var manglik_result="";
                               if (mdrds.Tables[0].Rows.length > 0)
                               {
                                   var lagna_chart=mdrds.Tables[0].Rows[0]['CHART_NO'];
                                   var lagna_cat=mdrds.Tables[0].Rows[0]['CATEGORY'];
                                   var lagna_result=mdrds.Tables[0].Rows[0]['DESCCLOB'];
                                    predictivetype =mdrds.Tables[0].Rows[0]['PREDICTIVE_TYPE'];
                                   lagnapoint=parseFloat(lagnapoint)*(1.19);
                                   lagnapoint=lagnapoint.toFixed(2);
                                   lagna_result = lagna_result.replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                                   lagna_result = lagna_result.replace("XX.XX", lagnapoint);
                                   lagna_result = lagna_result.replace("HH", "<font color='#F4600A'><b>HHth</b></font>");
                                   lagna_house = lagna_house.replace("HOUSE", "");
                                   lagna_result = lagna_result.replace("HH", lagna_house);
                                   
                                   if (mdrds.Tables[1].Rows.length > 0) {
                                       var moon_chart = mdrds.Tables[1].Rows[0]['CHART_NO'];
                                       var moon_cat = mdrds.Tables[1].Rows[0]['CATEGORY'];
                                       var moon_result = mdrds.Tables[1].Rows[0]['DESCCLOB'];
                                       predictivetype = mdrds.Tables[1].Rows[0]['PREDICTIVE_TYPE'];
                                       moonpoint = parseFloat(moonpoint) * (1.19);
                                       moonpoint = moonpoint.toFixed(2);
                                       moon_result = moon_result.replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                                       moon_result = moon_result.replace("XX.XX", moonpoint);
                                       moon_result = moon_result.replace("HH", "<font color='#F4600A'><b>HHth</b></font>");
                                       moon_house = moon_house.replace("HOUSE", "");
                                       moon_result = moon_result.replace("HH", moon_house);
                                   }
                            
                                   if (mdrds.Tables[2].Rows.length > 0) {
                                       var venus_chart = mdrds.Tables[2].Rows[0]['CHART_NO'];
                                       var venus_cat = mdrds.Tables[2].Rows[0]['CATEGORY'];
                                       var venus_result = mdrds.Tables[2].Rows[0]['DESCCLOB'];
                                       predictivetype = mdrds.Tables[2].Rows[0]['PREDICTIVE_TYPE'];
                                       venuspoint = parseFloat(venuspoint) * (1.19);
                                       venuspoint = venuspoint.toFixed(2);
                                       venus_result = venus_result.replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                                       venus_result = venus_result.replace("XX.XX", venuspoint);
                                       venus_result = venus_result.replace("HH", "<font color='#F4600A'><b>HHth</b></font>");
                                       venus_house = venus_house.replace("HOUSE", "");
                                       venus_result = venus_result.replace("HH", venus_house);
                                   }
                                   if (mdrds.Tables[3].Rows.length > 0) {
                                       var final_chart = mdrds.Tables[3].Rows[0]['CHART_NO'];
                                       var final_cat = mdrds.Tables[3].Rows[0]['CATEGORY'];
                                       var final_result = mdrds.Tables[3].Rows[0]['DESCCLOB'];
                                       predictivetype = mdrds.Tables[3].Rows[0]['PREDICTIVE_TYPE'];
                                       total = parseFloat(total) * (1.19);
                                       total = total.toFixed(2);
                                       final_result = final_result.replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                                       final_result = final_result.replace("XX.XX", total);
                                   }
                                   
                                  manglik_result = lagna_result + '<br /><br />' +  moon_result + '<br /><br />' + venus_result + '<br /><br />' +final_result;

                                  if(Questionid=="1268")  
                                  {
                                      manglik_result = "";
                                      if (mdrds.Tables[4].Rows.length > 0) {
                                          manglik_result = mdrds.Tables[4].Rows[0]['DESCCLOB'];
                                          predictivetype = mdrds.Tables[4].Rows[0]['PREDICTIVE_TYPE'];
                                      }
                                      compatibilitymatchingtest.update_natalquestion_ans(Autoid,Questionid,manglik_result,"");
                                  }
                                  else if(Questionid=="1272")
                                  {
                                      manglik_result = "";
                                      if (mdrds.Tables[5].Rows.length > 0) {
                                          manglik_result = mdrds.Tables[5].Rows[0]['DESCCLOB'];
                                          predictivetype = mdrds.Tables[5].Rows[0]['PREDICTIVE_TYPE'];
                                          compatibilitymatchingtest.update_natalquestion_ans(Autoid, Questionid, manglik_result, "");
                                      }
                                  }
                                  else
                                  {
                                     compatibilitymatchingtest.update_natalquestion_ans(Autoid,Questionid,manglik_result,"");
                                  }
                               }
                               
                                
                             }
                         }
                      }
                 }
                 else if(CatId=="24")  //This Condition for Dosha Samya
                 {
                     var lagnastr="",lagna_house="";
                     var moonstr="",moon_house="";
                     var venusstr="",venus_house="";
                     for (var i = 0; i < 11; i++)
                     {
                        var degree=document.getElementById('degreefinal_' + i).value
                        var degree1=degree.split('.');
                        var lagnastr = lagnastr + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
                        if(document.getElementById('planets_' + i).value.toUpperCase()=="MARS")
                        {
                        lagna_house=document.getElementById('house_' + i).value;
                        }
                        var moonstr = moonstr + document.getElementById('planets_' + i).value + "~" + document.getElementById('moonrashi_' + i).value + "~" + document.getElementById('moonhouse_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
                        if(document.getElementById('planets_' + i).value.toUpperCase()=="MARS")
                        {
                        moon_house=document.getElementById('moonhouse_' + i).value;
                        }
                        var venusstr = venusstr + document.getElementById('planets_' + i).value + "~" + document.getElementById('venusrashi_' + i).value + "~" + document.getElementById('venushouse_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
                        if(document.getElementById('planets_' + i).value.toUpperCase()=="MARS")
                        {
                        venus_house=document.getElementById('venushouse_' + i).value;
                        }
                      }
                      document.getElementById('Hs').value=lagnastr;
                      document.getElementById('Hm').value=moonstr;
                      document.getElementById('Hv').value=venusstr;
                      var dsds = compatibilitymatchingtest.pn("Paap Samya",document.getElementById('Hs').value,document.getElementById('Hm').value,document.getElementById('Hv').value,astmail);
                      var dsdsval = dsds.value;
                      
//                      if (dsdsval.Tables[2].Rows.length > 0)
//                      {
//                         for (var p = 0; p < dsdsval.Tables[2].Rows.length; p++) 
//                         {
//                             var palnetname = dsdsval.Tables[2].Rows[p]['PLANET'] 
//                             var totalpercentage = dsdsval.Tables[2].Rows[p]['TOTALPERCENTAGE']
//                         }
//                      }
                      
                      var dsr="";
                      if(Questionid=="1273")  
                      {
                        dsr=compatibilitymatchingtest.Get_Dosha_Samya_Result("ALL","ALL","ALL","ALL","","","","DoshaSamya","Y","");
                      }
                      else if(Questionid=="1274")  // What is Dosha- Samya
                      {
                        dsr=compatibilitymatchingtest.Get_Dosha_Samya_Result("ALL","ALL","ALL","ALL","","","","DoshaSamya","D","");
                      }
                      else if(Questionid=="1275") // Final Dosha Samya Result
                      {
                         dsr=compatibilitymatchingtest.Get_Dosha_Samya_Result("ALL","ALL","ALL","ALL","","","","DoshaSamya","F","");
                      }
                      else if(Questionid=="1276") // Expert's advice on Result of Dosha Samay
                      {
                         dsr=compatibilitymatchingtest.Get_Dosha_Samya_Result("ALL","ALL","ALL","ALL","","","","DoshaSamya","R","");
                      }
                      var dsrval = dsr.value;
                      var doshasamya_result="";
                     
                      var dsresult="";var palnetname="";var totalpercentage="";
                     
                      if (dsrval.Tables[0].Rows.length > 0)
                      {
                         for (var p = 0; p < dsrval.Tables[0].Rows.length; p++) 
                         {
                              if(Questionid=="1273")  // Maleficence by Planets
                              {
                                  dsresult = dsrval.Tables[0].Rows[p]['DESCCLOB'];
                                  palnetname = dsdsval.Tables[2].Rows[p]['PLANET'] 
                                  totalpercentage = dsdsval.Tables[2].Rows[p]['TOTALPERCENTAGE']
                                  dsresult = dsresult.replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                                  dsresult = dsresult.replace("XXX", "<font color='#F4600A'><b>XXX</b></font>");
                                  dsresult = dsresult.replace("HHH", "<font color='#F4600A'><b>HHH</b></font>");
                                  dsresult = dsresult.replace("XX.XX", totalpercentage);
                                  dsresult = dsresult.replace("XXX", palnetname);
                                  dsresult = dsresult.replace("HHH", palnetname);
                                  doshasamya_result = doshasamya_result + dsresult + "<br /><br />";
                              }
                              else if(Questionid=="1274")  // What is Dosha- Samya
                              {
                                dsresult = dsrval.Tables[0].Rows[p]['DESCCLOB'];
                                doshasamya_result = dsresult;
                              }
                              else if(Questionid=="1275") // Final Dosha Samya Result
                              {
                                  dsresult = dsrval.Tables[0].Rows[p]['DESCCLOB'];
                                  totalpercentage = dsdsval.Tables[2].Rows[p]['TOTALPERCENTAGE'];
                                  dsresult = dsresult.replace("XX.XX", "<font color='#F4600A'><b>XX.XX</b></font>");
                                  dsresult = dsresult.replace("XX.XX", totalpercentage);
                                  doshasamya_result = dsresult;
                              }
                              else if(Questionid=="1276") // Final Dosha Samya Result
                              {
                                 doshasamya_result=dsrval.Tables[0].Rows[p]['DESCCLOB']
                              }
                         }
                         
                         compatibilitymatchingtest.update_natalquestion_ans(Autoid,Questionid,doshasamya_result,"");
                         
                      }
                      
                 }
                 else
                 {
                  
                   //window.open('searchpage.aspx?searchpage=' + searchpage+"&v="+ v + "&j="+ j + "&k="+ k +"&clmail="+ clmail + "&astmail=" + astmail + "&astname=" + astname + "&client=" + client+ "&usermail=" + clmail);
                   ss = ss.replace("'", "''");
                   s = s.replace("'", "''");
                   kk = kk.replace("'", "''");
                   if(executepro=="N")
                   {
                      var resans = compatibilitymatchingtest.get_natalquestion_ans(s, ss, kk, rashi, key, planets, chart, astmail);
                   }
                   else
                   {
                      var resans = compatibilitymatchingtest.get_natalquestion_ans_temp(s, ss, kk, rashi, key, planets, chart, astmail,sessionid,"GETQUESTIONANSWER");
                   }
                  var dsnans = resans.value;
                  ss="";
                  if(dsnans!=null)
                  {
                      if (dsnans.Tables[0].Rows.length > 0)
                      {
                         executepro="Y";
                         sessionid = dsnans.Tables[0].Rows[0]['SESS_ID'];
                         
                         var Answer="";
                         for (var l = 0; l < dsnans.Tables[0].Rows.length; l++) 
                         {
                           predictivetype = dsnans.Tables[0].Rows[l]['PREDICTIVE_TYPE'];
                           Answer = Answer + "#" + predictivetype + dsnans.Tables[0].Rows[l]['DESCCLOB'] + "$";
                         }
                         if (Answer != "") 
                         {
                          Answer = Answer.slice(0, -1);
                         }
                         compatibilitymatchingtest.update_natalquestion_ans(Autoid,Questionid,Answer,"");
                       }
                   }
                 }
              }
            }
             var resans = compatibilitymatchingtest.get_natalquestion_ans_temp('', '', '', '', '', '', '', '',sessionid,"DELETESESSION");
             var dsnans = resans.value;
             if(dsnans!=null)
              {
                if (dsnans.Tables[0].Rows.length > 0)
                {
                 return;
                }
            }
         //}
         
   }


  function GetAllHoraryQuestion(chartdetails,lagnarashi_final,astid,clientid) 
  {
       var cartid =document.getElementById('hdncartid').value;
       var Grid_Table = document.getElementById('GvHoraryQuestions');
       var rowCount = Grid_Table.rows.length;
       var currRow;
       for (var i = 1; i < rowCount; i++) 
       {
         currRow = Grid_Table.rows[i];
         var GroupType = currRow.cells[0].innerText;
         var Category = currRow.cells[1].innerText;

         res = compatibilitymatchingtest.get_allhorarynatal_question(cartid,"","HORARY","","GETALLHORARYQUESTIONS");
         var dsh = res.value;
         if (dsh != null && dsh.Tables[0].Rows.length > 0) 
         {
              for (var j = 0; j < dsh.Tables[0].Rows.length; j++) 
              {
               var Autoid= dsh.Tables[0].Rows[j]['AUTOID'];
               var Questionid= dsh.Tables[0].Rows[j]['QUESTIONID'];
               var CatName= dsh.Tables[0].Rows[j]['CATNAME'];
               var Question= dsh.Tables[0].Rows[j]['QUESTION'];
               var mainfilerdrop=CatName;
               var subfilterdrop=Question;
               var resr = compatibilitymatchingtest.get_horaryquestion_ans(chartdetails, lagnarashi_final, mainfilerdrop, subfilterdrop,astid,clientid);
               //var res = compatibilitymatchingtest.get_horaryquestion_ans(combination, lagnarashi_final, mainfilerdrop, subfilterdrop,callback_fillgrid);
                var exec_data = resr.value;
                if (exec_data.Tables[0].Rows.length > 0)
                {
                    for (var k = 0; k< exec_data.Tables[0].Rows.length; k++) 
                    {
                      var Answer = exec_data.Tables[0].Rows[k]['DESCCLOB'];
                      compatibilitymatchingtest.update_horaryquestion_ans(Autoid,Questionid,Answer,"");
                    }
                }
             }
         }
     }
 }
       
       
       

//  function callback_fillgrid(res) {
//    var exec_data = res.value;
//    if (exec_data.Tables[0].Rows.length > '0') {
//           
//    }
//    else 
//    {
//        alert('There is No Data Regarding Your Querry')
//        return false;
//    }
//}

// function callback_drp1(res) {
//     var ds = res.value;
//     var edtn = $("groupdrop");
//     edtn.options.length = 1;
//     edtn.options[0] = new Option("General", "0");
//     if (ds != null && typeof (ds) == "object" && ds.Tables[1].Rows.length > 0) {
//         for (var i = 0; i < ds.Tables[1].Rows.length; i++) {
//             edtn.options[edtn.options.length] = new Option(ds.Tables[1].Rows[i].CAT_ID, ds.Tables[1].Rows[i].CAT_ID)
//             edtn.options.length;
//         }
//     }
//     
// }



/* All Function End Here For Fourth Step */