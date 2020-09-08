var buf2="";
var dsgrid="";
var flag='0';
var group1="";
var flag1=true;
var myaccount="";

var popUpWin = 0;
function getopen(pagename)
{

if(popUpWin)
       {
            if(!popUpWin.closed) popUpWin.close();
       }

	popUpWin = window.open(''+ pagename +'','form','resizable=yes, status=no, toolbar=no, scrollbars=yes, location=no, menubar=no,addressbar=no')

}

function accountuser(){
    var astrologer= document.getElementById('Hidden9').value;
    if(astrologer=='astrology' ||astrologer=='ASTROLOGY' || astrologer==""){
     //alert('you are admin');
     getopen("login.aspx");
     return false;
   }
    else {
     res = myaccount.searchuser(astrologer, document.getElementById('grp_cat').value);
    callback_fillgrid(res);
    //callback_fillgrid2(res);
    group_bind();
   }
}


function group_bind() {

    var astrologer = document.getElementById('Hidden9').value;
    if (astrologer == 'astrology' || astrologer == 'ASTROLOGY' || astrologer == "") {
        // alert('you are admin');
        getopen("login.aspx");
        return false;
    }
    else {
        res = myaccount.searchuser(astrologer, document.getElementById('grp_cat').value);
        
        callback_drp1(res);
        cldetail();
        return false
    }
    return false;
}


  function callback_drp1(res) {
    var ds=res.value;
    //var edtn = $("clgroup");   //--Deepak Nirwal comment this line
    var edtn=document.getElementById('clgroup');   // --Deepak Nirwal added this line
    edtn.options.length = 1;
    edtn.options[0] = new Option("General", "0");
    if (ds != null && typeof (ds) == "object" && ds.Tables[1].Rows.length > 0) {
        for (var i = 0; i < ds.Tables[1].Rows.length; i++) {
            edtn.options[edtn.options.length] = new Option(ds.Tables[1].Rows[i].CAT_ID, ds.Tables[1].Rows[i].CAT_ID)
            edtn.options.length;
        }
    }
    return false;
}
  function sebyd_data() {
      document.getElementById('sebyt').style.display = 'inline';
  }
function cldetail()

{
document.getElementById('update2').style.display = 'block';
document.getElementById('whitediv2').style.display='block';
var grop = document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text;

var astrologer= document.getElementById('Hidden9').value;
document.getElementById('sebyd').selectedIndex = 0
document.getElementById('sebyt').style.display = 'none';
res = myaccount.searchclient(astrologer, grop, document.getElementById('grp_cat').value);
callback_fillgrid2(res);
return false;
}


function sebyb_data() {

    var grop = document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text;

    var gropu = document.getElementById('grp_cat').options[document.getElementById('grp_cat').selectedIndex].text;

//    if (document.getElementById('clgroup').selectedIndex == 0)
//    {
//        alert('Please Select Group Name');
//        return;
//    }
    var astrologer = document.getElementById('Hidden9').value;
    var txtvalue = document.getElementById('sebyt').value;
    var searchoption = document.getElementById('sebyd').value;

    res = myaccount.searchclient_by(astrologer, grop, searchoption, txtvalue,gropu);
    callback_fillgrid2(res);
    return false;
}

function callback_fillgrid(res){

 var exec_data = res.value;
    
    dsgrid = exec_data;
    document.getElementById('hdsviewgrid').innerHTML = "";
    document.getElementById('Divgrid1').style.display = "none";
    if (exec_data.Tables[0].Rows.length >= 0) {
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

        document.getElementById('hdsviewgrid').style.display = "block";

        if (document.getElementById("hdsviewgrid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("Divgrid1").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:460px;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='460px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td class='colum-td-head'>" + "NAME" + "</td>"
        buf2 += "<td class='colum-td-head'>" + "MAINMAIL" + "</td>"
        //buf2 += "<td class='colum-td-head'>" + "ALTMAIL" + "</td>"
        buf2 += "<td class='colum-td-head'>" + "MOBILE_NO" + "</td>"
        //buf2 += "<td class='colum-td-head'>" + "LANDLINE_NO" + "</td>"
        buf2 += "<td class='colum-td-head'>" + "ADDRESS" + "</td>"
        //buf2 += "<td class='colum-td-head'>" + "ADDRESS2" + "</td>"
        //buf2 += "<td class='colum-td-head'>" + "LANDMARK" + "</td>"
        buf2 += "<td class='colum-td-head'>" + "COUNTRY" + "</td>"
        buf2 += "<td class='colum-td-head'>" + "ZIPCODE" + "</td>"
        //buf2 += "<td class='colum-td-head'>" + "PASSWORD" + "</td>"
    
        buf2 += "</tr>"
           len = 1;

       
        if (dsgrid.Tables[0].Rows.length > 0) {

            for (i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {


                buf2 += "<tr>"
                if (dsgrid.Tables[0].Rows[i]['SUBSCRIPTION'] == 'Natal')
                {
                    document.getElementById('grp_cat').value='Natal'
                }
                if (dsgrid.Tables[0].Rows[i]['SUBSCRIPTION'] == 'Horary') {
                    document.getElementById('grp_cat').value = 'Horary'
                }
                document.getElementById('hdnasn').value = dsgrid.Tables[0].Rows[i]['NAME']
                buf2 += "<td class='colum-td'>"
                buf2 += "<input type='text' style='width:200px;' class='dropdown_large_corr'; align='left' value='" + dsgrid.Tables[0].Rows[i]['NAME'] + "'  id='name_" + i + "'  >"
                buf2 += "</td>"


                document.getElementById('hdnas').value = dsgrid.Tables[0].Rows[i]['MAINMAIL'];

                buf2 += "<td class='colum-td'>"
                buf2 += "<input type='text'Enabled='false'disabled style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['MAINMAIL'] + "'  id='pmail1_" + i + "'  >"
                buf2 += "</td>"


//                buf2 += "<td class='colum-td'>"
//                buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['ALTMAIL'] + "'  id='altmail_" + i + "'  >"
//                buf2 += "</td>"



                buf2 += "<td class='colum-td'>"
                buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['MOBILE_NO'] + "'  id='mobno_" + i + "'  >"
                buf2 += "</td>"



//                buf2 += "<td class='colum-td'>"
//                buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['LANDLINE_NO'] + "'  id='landno_" + i + "'  >"
//                buf2 += "</td>"



                buf2 += "<td class='colum-td'>"
                buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['ADDRESS1'] + "'  id='add1_" + i + "'  >"
                buf2 += "</td>"


//                buf2 += "<td class='colum-td'>"
//                buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['ADDRESS2'] + "'  id='add2_" + i + "'  >"
//                buf2 += "</td>"


//                buf2 += "<td class='colum-td'>"
//                buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['LANDMARK'] + "'  id='landmark_" + i + "'  >"
//                buf2 += "</td>"


                buf2 += "<td class='colum-td'>"
                buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['COUNTRY'] + "'  id='country_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td  class='colum-td'>"
                buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['ZIPCODE'] + "'  id='zip_" + i + "'  >"
                buf2 += "</td>"


//                buf2 += "<td class='colum-td'>"
//                buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['PASSWORD'] + "'  id='pwd_" + i + "'  >"
//                buf2 += "</td>"
                
                buf2 += "</tr>"
            }
        }

        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        document.getElementById('hdsviewgrid').innerHTML = temp_del1;
      }
  }
     

function callback_fillgrid2(res){

    var exec_data = res.value;
    
    dsgrid = exec_data;
    document.getElementById('hdsviewgrid2').innerHTML = "";
    document.getElementById('Divgrid2').style.display = "none";
    if (exec_data.Tables[0].Rows.length >= 0) {
        document.getElementById('hdsviewgrid2').innerHTML = "";
        document.getElementById('Divgrid2').style.display = 'block';
         document.getElementById('Divgrid2').style.height = 'auto';
        $('Divgrid2').display = 'block;'


        document.getElementById('Divgrid2').style.BackColor = "Ivory";
        var temp_del1 = "";

        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('hdsviewgrid2').style.display = "block";

        if (document.getElementById("hdsviewgrid2").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("Divgrid2").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("hdsviewgrid2").innerHTML.indexOf("width:460px;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid2").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
//        buf2 += "<table>"
//        buf2 += "<tr>"
        if (dsgrid.Tables[0].Rows.length > 0) {

            for (i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
                var group = dsgrid.Tables[0].Rows[i]['CAT_ID'];
                   
                if (flag == '0') {

                    buf2 += "<table>"
                    buf2 += "<tr style='float:left;width:auto;background-color: #6D6D6D'>"
                    buf2 += "<td style='background-color:#6D6D6D;border-right:none;border-right: 0px solid white !important;font-size: 0.85em;' class='colum-td-head'>" + "Group Name: " + group + "</td>"
                    buf2 += "</tr>"
                    flag = '1';
                    buf2 += "<tr>"
                    buf2 += "<table>"
                    buf2 += "<tr>"
                    //buf2 += "<td style='display:none;' class='colum-td-head'>" + "ASTRO_DTLS" + "</td>"
                    //buf2 += "<td style='display:none;' class='colum-td-head astro-mail'>" + "ASTRO_MAIL" + "</td>"
                    buf2 += "<td id='cliname' class='colum-td-head colum-name' onclick=\"click_trcode(this.id);\">" + "CLIENT_NAME" + "</td>"
                    buf2 += "<td  class='colum-td-head astro-mail'>" + "CLIENT_MAIL" + "</td>"
                    buf2 += "<td id='prof' class='colum-td-head colum-name' onclick=\"click_trcode(this.id);\">" + "PROFESSION" + "</td>"
                    buf2 += "<td id='prof' class='colum-td-head colum-name'>" + "MOBILE_NO" + "</td>"
                    buf2 += "<td  class='colum-td-head colum-age'>" + "DOB" + "</td>"
                    buf2 += "<td  class='colum-td-head colum-age'>" + "TOB" + "</td>"
                    buf2 += "<td  class='colum-td-head colum-age'>" + "COUNTRY" + "</td>"
                    buf2 += "<td  class='colum-td-head colum-age'>" + "STATE" + "</td>"
                    buf2 += "<td  class='colum-td-head colum-age' style='display:none;'>" + "DISTRICT" + "</td>"
                    buf2 += "<td  class='colum-td-head colum-age'>" + "CITY" + "</td>"
                    buf2 += "<td  class='colum-td-head colum-age'>" + "GENDER" + "</td>"
                    buf2 += "<td  class='colum-td-head colum-age'>" + "OPEN" + "</td>"
                    //buf2 += "<td  class='colum-td-head colum-age'>" + "UPDATE" + "</td>"
                    buf2 += "<td class='colum-td-head colum-age'>" + "DELETE" + "</td>"
                    buf2 += "<td style='display:none;' class='colum-td-head colum-age'>D01</td>"
                    buf2 += "<td style='display:none;' class='colum-td-head colum-age'>Astrologer Name</td>"
                    buf2 += "<td style='display:none;' class='colum-td-head colum-age'>Astrologer Emailid</td>"
                    buf2 += "<td style='display:none;' class='colum-td-head colum-age'>Longitude</td>"
                    buf2 += "<td style='display:none;' class='colum-td-head colum-age'>Latitude</td>"
                    buf2 += "<td style='display:none;' class='colum-td-head colum-age'>TimeZone</td>"
                    buf2 += "<td style='display:none;' class='colum-td-head colum-age'>SunSetPre</td>"
                    buf2 += "<td style='display:none;' class='colum-td-head colum-age'>SunRise</td>"
                    buf2 += "<td style='display:none;' class='colum-td-head colum-age'>SunSet</td>"
                    buf2 += "<td style='display:none;' class='colum-td-head colum-age'>SunRiseNext</td>"
                    buf2 += "</tr>"

                    len = 1;
                }

                buf2 += "<tr>"


                //buf2 += "<td class='colum-td'>"
                //buf2 += "<input type='text' style='display:none;' class='dropdown_large_corr' Enabled='false' disabled  value='" + dsgrid.Tables[0].Rows[i]['ASTRO_DTLS'] + "'  id='astdel1_" + i + "'  >"
                //buf2 += "</td>"

                //buf2 += "<td  class='colum-td'>"
                //buf2 += "<input type='text' style='display:none;' class='dropdown_large_corr' style='width:200px; 'Enabled='false' disabled value='" + dsgrid.Tables[0].Rows[i]['P_MAIL'] + "'  id='pmail1_" + i + "'  >"
                //buf2 += "</td>"

                buf2 += "<td   class='colum-td'>"
                buf2 += "<input type='text' class='dropdown_large_corr'  Enabled='false'disabled  value='" + dsgrid.Tables[0].Rows[i]['CLIENT_NAME'] + "'  id='cname1_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   class='colum-td'>"
                //buf2 += "<input type='text'  style='width:200px';  class='colum-name_id' value='" + dsgrid.Tables[0].Rows[i]['CLIENT_MAIL'] + "'  id='climale1_" + i + "' onClick='javascript:return onclientmail(id);' >"
                buf2 += "<input type='text'  style='width:200px';  class='colum-name_id' value='" + dsgrid.Tables[0].Rows[i]['CLIENT_MAIL'] + "'  id='climale1_" + i + "' onClick='javascript:return OpenClientChart(id);' >"
                buf2 += "</td>"


                if (dsgrid.Tables[0].Rows[i]['PROFESSION'] == 0 || dsgrid.Tables[0].Rows[i]['PROFESSION'] == null) {
                    buf2 += "<td   class='colum-td'>"
                    buf2 += "<input type='text' class='dropdown_large_corr'  Enabled='false'disabled class='colum-name'  id='prof1_" + i + "'  >"
                    buf2 += "</td>"
                }
                else {

                    buf2 += "<td   class='colum-td'>"
                    buf2 += "<input type='text' class='dropdown_large_corr'  Enabled='false'disabled  class='colum-name' value='" + dsgrid.Tables[0].Rows[i]['PROFESSION'] + "'  id='prof1_" + i + "'  >"
                    buf2 += "</td>"
                }
                if (dsgrid.Tables[0].Rows[i]['MOBILE_NO'] == 0 || dsgrid.Tables[0].Rows[i]['MOBILE_NO'] == null)
                {
                    buf2 += "<td   class='colum-td'>"
                    buf2 += "<input type='text' class='dropdown_large_corr'  Enabled='false'disabled  class='colum-age'  id='mobile_" + i + "'  >"
                    buf2 += "</td>"
                }
                else

                {
                    buf2 += "<td   class='colum-td'>"
                    buf2 += "<input type='text' class='dropdown_large_corr'  Enabled='false'disabled class='colum-age'  value='" + dsgrid.Tables[0].Rows[i]['MOBILE_NO'] + "'  id='mobile_" + i + "'  >"
                    buf2 += "</td>"
                }


                buf2 += "<td   class='colum-td'>"
                buf2 += "<input type='text'  class='colum-age' class='dropdown_large_corr'  value='" + dsgrid.Tables[0].Rows[i]['DOB'] + "'  id='age1_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   class='colum-td'>"
                buf2 += "<input type='text'  class='colum-age' class='dropdown_large_corr'  value='" + dsgrid.Tables[0].Rows[i]['TOB'] + "'  id='tob_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   class='colum-td'>"
                buf2 += "<input type='text'  class='colum-age' class='dropdown_large_corr'  value='" + dsgrid.Tables[0].Rows[i]['COUNTRY'] + "'  id='con_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   class='colum-td'>"
                buf2 += "<input type='text'  class='colum-age' class='dropdown_large_corr'  value='" + dsgrid.Tables[0].Rows[i]['STATE'] + "'  id='state_" + i + "'  >"
                buf2 += "</td>"

                if (dsgrid.Tables[0].Rows[i]['DISTRICT'] == 0 || dsgrid.Tables[0].Rows[i]['DISTRICT'] == null) {
                    buf2 += "<td   class='colum-td' style='display:none;'>"
                    buf2 += "<input type='text' class='dropdown_large_corr' style='display:none;' Enabled='false'disabled  class='colum-age'  id='dist_" + i + "'  >"
                    buf2 += "</td>"
                }
                else {
                    buf2 += "<td   class='colum-td'  style='display:none;'>"
                    buf2 += "<input type='text'  class='colum-age' class='dropdown_large_corr'  style='display:none;' value='" + dsgrid.Tables[0].Rows[i]['DISTRICT'] + "'  id='dist_" + i + "'  >"
                    buf2 += "</td>"
                }
                buf2 += "<td   class='colum-td'>"
                buf2 += "<input type='text'  class='colum-age' class='dropdown_large_corr'  value='" + dsgrid.Tables[0].Rows[i]['CITY'] + "'  id='city_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   class='colum-td'>"
                buf2 += "<input type='text'   class='colum-age' class='dropdown_large_corr'  value='" + dsgrid.Tables[0].Rows[i]['GENDER'] + "'  id='gender1_" + i + "'  >"
                buf2 += "</td>"


//                buf2 += "<td   class='colum-td'>"
//                buf2 += "<input type='button' class='per_btn1_2_new'  onClick='javascript:return onclientmail(id);' value='OPEN'  id='open_" + i + "'  >"
//                buf2 += "</td>"

                buf2 += "<td class='colum-td'>"
                buf2 += "<input type='button' class='per_btn1_2_new' onClick='javascript:return OpenClientChart(id);' value='OPEN' id='open_" + i + "'  >"
                buf2 += "</td>"

//                buf2 += "<td   class='colum-td'>"
//                buf2 += "<input type='button' class='per_btn1_2_new' onClick='javascript:return update_data(id);' value='UPDATE'  id='upd_" + i + "'  >"
//                buf2 += "</td>"

                buf2 += "<td   class='colum-td'>"
                buf2 += "<input type='button' class='per_btn1_2_new' onClick='javascript:return delete_data(id);' value='DELETE'  id='del_" + i + "'  >"
                buf2 += "</td>"
                
                buf2 += "<td style='display:none;' class='colum-td'>"
                buf2 += "<input type='text' class='colum-age' class='dropdown_large_corr' value='" + dsgrid.Tables[0].Rows[i]['HOROSCOPE_D01'] + "'  id='d01chart_" + i + "'  >"
                buf2 += "</td>"
                
                buf2 += "<td style='display:none;' class='colum-td'>"
                buf2 += "<input type='text' class='colum-age' class='dropdown_large_corr' value='" + dsgrid.Tables[0].Rows[i]['ASTROLOGER_NAME'] + "'  id='astrologername_" + i + "'  >"
                buf2 += "</td>"
                
                buf2 += "<td style='display:none;' class='colum-td'>"
                buf2 += "<input type='text' class='colum-age' class='dropdown_large_corr' value='" + dsgrid.Tables[0].Rows[i]['ASTROLOGER_ID'] + "'  id='astrologeremailid_" + i + "'  >"
                buf2 += "</td>"
                
                buf2 += "<td style='display:none;' class='colum-td'>"
                buf2 += "<input type='text' class='colum-age' class='dropdown_large_corr' value='" + dsgrid.Tables[0].Rows[i]['LONGITUDE'] + "'  id='longitudeval_" + i + "'  >"
                buf2 += "</td>"
                
                buf2 += "<td style='display:none;' class='colum-td'>"
                buf2 += "<input type='text' class='colum-age' class='dropdown_large_corr' value='" + dsgrid.Tables[0].Rows[i]['LATITUDE'] + "'  id='latitudeval_" + i + "'  >"
                buf2 += "</td>"
                
                buf2 += "<td style='display:none;' class='colum-td'>"
                buf2 += "<input type='text' class='colum-age' class='dropdown_large_corr' value='" + dsgrid.Tables[0].Rows[i]['TIMEZONE'] + "'  id='timezoneval_" + i + "'  >"
                buf2 += "</td>"
                
                buf2 += "<td style='display:none;' class='colum-td'>"
                buf2 += "<input type='text' class='colum-age' class='dropdown_large_corr' value='" + dsgrid.Tables[0].Rows[i]['SUN_SET_PREDAY'] + "'  id='sunsetpre_" + i + "'  >"
                buf2 += "</td>"
                
                buf2 += "<td style='display:none;' class='colum-td'>"
                buf2 += "<input type='text' class='colum-age' class='dropdown_large_corr' value='" + dsgrid.Tables[0].Rows[i]['SUN_RISE'] + "'  id='sunrise_" + i + "'  >"
                buf2 += "</td>"
                
                buf2 += "<td style='display:none;' class='colum-td'>"
                buf2 += "<input type='text' class='colum-age' class='dropdown_large_corr' value='" + dsgrid.Tables[0].Rows[i]['SUN_SET'] + "'  id='sunset_" + i + "'  >"
                buf2 += "</td>"
                
                buf2 += "<td style='display:none;' class='colum-td'>"
                buf2 += "<input type='text' class='colum-age' class='dropdown_large_corr' value='" + dsgrid.Tables[0].Rows[i]['SUN_RISE_NEXTDAY'] + "'  id='sunrisenext_" + i + "'  >"
                buf2 += "</td>"
                
                buf2 += "<td style='display:none;' class='colum-td'>"
                buf2 += "<input type='text' class='colum-age' class='dropdown_large_corr' value='" + dsgrid.Tables[0].Rows[i]['QUERY'] + "'  id='query_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "</tr>"
                //  group1=group;
            }
        }
        else {

            //alert('There is no Data regarding your query');
            return false;
        }

         flag='0';
        buf2 += "</table>"
        buf2 += "</tr>"
        //buf2 += "</tr>"
        buf2 += "</table>"
        //buf2 += "</tr>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        document.getElementById('hdsviewgrid2').innerHTML = temp_del1;
              
     }
 }


var v_val = "";
var c_val="";
var degree_val = "";
function OpenClientChart(id)
{
      var cmail = id.split('_');
      var cmail1 = cmail[1];
      var group = document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text;

      var clname = document.getElementById("cname1_" + cmail1).value;
      var clmail = document.getElementById("climale1_" + cmail1).value;
      var astname = document.getElementById("astrologername_" + cmail1).value;
      var astmail = document.getElementById("astrologeremailid_" + cmail1).value;
     
      var d01chartval = document.getElementById("d01chart_" + cmail1).value;
      d01chartval = d01chartval.slice(0,-1);
      var d01arr = d01chartval.split('~');
      var v_val='';
      var c_val='';
      for(i=0; i<d01arr.length; i++)
      {
        var d01arr1 =d01arr[i].split('/');
        var planetsval=d01arr1[0];
        var rashival=d01arr1[1];
        
        var houseval=d01arr1[2];
        var d01arr2 =d01arr1[3].split('.');
        var degreeval=d01arr2[0];
        var minutesval=d01arr2[1];
        var secondsval=d01arr2[2];
        var retroval=d01arr1[4];
        var constelationval=d01arr1[5];
        var birthval='0';
        if(planetsval=="MOON")
        {
           var degreevalmoon=degreeval;
           var minutesvalmoon=minutesval;
           var secondsvalmoon=secondsval;
           var rashivalmoon=rashival;
        }
        
        degree_val = degreeval + "." + minutesval + "." + secondsval;
        v_val = v_val + planetsval + "~" + rashival + "~" + houseval + "~" + birthval + "~" + retroval + "~" + degree_val + "$";
        c_val = c_val + planetsval + "~" + rashival + "~" + houseval + "~" + birthval + "~" + retroval + "~" + degree_val + "~" + constelationval + "$";
      }
      var j_val='0';
      var k_val='';
      v_val = v_val.slice(0, -1);
      c_val = c_val.slice(0, -1);
      var dobval=document.getElementById("age1_" + cmail1).value;
      var tobval=document.getElementById("tob_" + cmail1).value;
      var countryval=document.getElementById("con_" + cmail1).value;
      var stateval=document.getElementById("state_" + cmail1).value;
      var districtval=document.getElementById("dist_" + cmail1).value;
      var cityval=document.getElementById("city_" + cmail1).value;
      var group_underval=document.getElementById('grp_cat').options[document.getElementById('grp_cat').selectedIndex].text;
      var profval=document.getElementById("prof1_" + cmail1).value;
      var sexval=document.getElementById("gender1_" + cmail1).value;
      var mobileval=document.getElementById("mobile_" + cmail1).value;
      
      var dobvalsplit =dobval.split('/');
      var imonthob = dobvalsplit[1];
      var idateob = dobvalsplit[0];
      var iyearob = dobvalsplit[2];
      var tobvalsplit =tobval.split(':');
      var ihourob = tobvalsplit[0];
      var iminuteob = tobvalsplit[1];
      var longitude_val=document.getElementById("longitudeval_" + cmail1).value;  
      var latitude_val=document.getElementById("latitudeval_" + cmail1).value; 
      var timezone_val=document.getElementById("timezoneval_" + cmail1).value;
      var sunsetpre_val=document.getElementById("sunsetpre_" + cmail1).value;
      var sunrise_val=document.getElementById("sunrise_" + cmail1).value;
      var sunset_val=document.getElementById("sunset_" + cmail1).value;
      var sunrisenext_val=document.getElementById("sunrisenext_" + cmail1).value;
      var clientquery=document.getElementById("query_" + cmail1).value;
      var dn="Maha Dasha";
      var stob="0";
      var bosparameters = degreevalmoon + "$" + minutesvalmoon + "$" + secondsvalmoon + "$" + rashivalmoon + "$" + idateob + "$" + imonthob + "$" + iyearob + "$" + ihourob + "$" + iminuteob + "$" + stob + "$" + astmail + "$" +  dn;
      
//      var urll='vargas_chart.aspx?v=' + v_val + "&j=" + j_val + "&k=" + k_val + "&astname=" + astname + "&astid=" + astmail + "&clientname=" + clname + "&clientid=" + clmail + "&usermail=" + astmail + "&c=" + c_val + "&dob=" + dobval + "&tob=" + tobval + "&country=" + countryval + "&state=" + stateval + "&district=" + districtval + "&city=" + cityval + "&group=" + group + "&group_under=" + group_underval + "&prof=" + profval + "&sex=" + sexval + "&mobile=" + mobileval + "&idateob=" + idateob + "&imonthob=" + imonthob + "&iyearob=" + iyearob + "&ihourob=" + ihourob + "&iminuteob=" + iminuteob + "&longitude=" + longitude_val + "&latitude=" + latitude_val + "&timezone=" + timezone_val + "&tzval=" + timezone_val + "&sunsetpre=" + sunsetpre_val  + "&sunrise=" + sunrise_val + "&sunset=" + sunset_val + "&sunrisenext=" + sunrisenext_val + "&balancedasha=" + bosparameters +"&query="+clientquery + "";
//      alert(urll);
      window.open('vargas_chart.aspx?v=' + v_val + "&j=" + j_val + "&k=" + k_val + "&astname=" + astname + "&astid=" + astmail + "&clientname=" + clname + "&clientid=" + clmail + "&usermail=" + astmail + "&c=" + c_val + "&dob=" + dobval + "&tob=" + tobval + "&country=" + countryval + "&state=" + stateval + "&district=" + districtval + "&city=" + cityval + "&group=" + group + "&group_under=" + group_underval + "&prof=" + profval + "&sex=" + sexval + "&mobile=" + mobileval + "&idateob=" + idateob + "&imonthob=" + imonthob + "&iyearob=" + iyearob + "&ihourob=" + ihourob + "&iminuteob=" + iminuteob + "&longitude=" + longitude_val + "&latitude=" + latitude_val + "&timezone=" + timezone_val + "&tzval=" + timezone_val + "&sunsetpre=" + sunsetpre_val  + "&sunrise=" + sunrise_val + "&sunset=" + sunset_val + "&sunrisenext=" + sunrisenext_val + "&balancedasha=" + bosparameters +"&query="+clientquery + "");


     //window.open('homenewpage.aspx?clmail=' + clmail + "&clname=" + clname + "&astname=" + astname + "&astmail=" + astmail + "&usermail=" + document.getElementById("hdnuser").value + "&group=" + group + "&group_u=" + document.getElementById('grp_cat').options[document.getElementById('grp_cat').selectedIndex].text  + "&mobile=" + document.getElementById("mobile_" + cmail1).value + "&dob=" + document.getElementById("age1_" + cmail1).value + "&tob=" + document.getElementById("tob_" + cmail1).value + "&country=" + document.getElementById("con_" + cmail1).value + "&state=" + document.getElementById("state_" + cmail1).value + "&dist=" + document.getElementById("dist_" + cmail1).value + "&city=" + document.getElementById("city_" + cmail1).value + "&prof=" + document.getElementById("prof1_" + cmail1).value + "&sex=" + document.getElementById("gender1_" + cmail1).value + "&cd=" + 2);

    return false;
}



function updatedata(){

 var name=document.getElementById('name_0').value;
 var mainmail=document.getElementById('pmail1_0').value;
 var altmail=document.getElementById('altmail_0').value;
 var mobno=document.getElementById('mobno_0').value;
 var landno=document.getElementById('landno_0').value;
 var add1=document.getElementById('add1_0').value;
 var dd2=document.getElementById('add2_0').value;
 var landmark=document.getElementById('landmark_0').value;
 var country1=document.getElementById('country_0').value;
 var zip=document.getElementById('zip_0').value;
 var pwd=document.getElementById('pwd_0').value; 
 myaccount.update(name,altmail,mobno,landno,add1,dd2,country1,zip,pwd,landmark,mainmail); 
 alert('update successfully');
 accountuser();
 
}

function update_data(id) {
    var cmail = id.split('_')
    var cmail1 = cmail[1];
    var group = document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text;
    
    var groupcat = document.getElementById('grp_cat').options[document.getElementById('grp_cat').selectedIndex].text;
    

    var astrodetail = document.getElementById('hdnasn').value
    var clidetail = document.getElementById('cname1_' + cmail1).value;
    var profession = document.getElementById('prof1_' + cmail1).value;
    var age = document.getElementById('age1_' + cmail1).value;
    var tob = document.getElementById('tob_' + cmail1).value;
    var tob1 = tob.split(':');
    var hob = tob1[0];
    var miob = tob1[1];
    var con = document.getElementById('con_' + cmail1).value;
    var state = document.getElementById('state_' + cmail1).value;
    var dist = document.getElementById('dist_' + cmail1).value;
    var city = document.getElementById('city_' + cmail1).value;
    var gender = document.getElementById('gender1_' + cmail1).value;
    var pmail = document.getElementById('hdnas').value
    var climail = document.getElementById('climale1_' + cmail1).value;
    var mobile = document.getElementById('mobile_' + cmail1).value;
    var flagu = 1;
    window.open('astro_client.aspx?clmail=' + climail + "&clname=" + clidetail + "&astname=" + astrodetail + "&astmail=" + pmail + "&usermail=" + document.getElementById("hdnuser").value + "&group=" + group + "&prof=" + profession + "&age=" + age + "&hob=" + hob + "&miob=" + miob + "&con=" + con + "&state=" + state + "&dist=" + dist + "&city=" + city + "&gender=" + gender + "&mob=" + mobile + "&flag=" + flagu + "&groupcat=" + groupcat);

    //myaccount.updateclient(astrodetail,clidetail,profession,age,gender,pmail,climail,group);

    //alert('update successfully');
    //accountuser();

}

function onclientmail(id)
{
    var cmail = id.split('_')
    var cmail1 = cmail[1];
    var group = document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text;

     var clname = document.getElementById("cname1_" + cmail1).value;
     var clmail = document.getElementById("climale1_" + cmail1).value;
     var astname = document.getElementById('hdnasn').value
     var astmail = document.getElementById('hdnas').value
//     window.open("homenewpage.aspx?clname=" + clname + "&clmail=" + clmail + "&astmail=" + astrologer + "&astname=" + astro_dtls + "&usermail=" + document.getElementById('hdnuser').value + "&group_u=" + cat_grp + "&group=" + cat_id + "&mobile=" + mno + "&dob=" + dateob + "&da1ofb=" + da1ob + "&mo1ofb=" + mo1ob + "&yr1ofb=" + yr1ob + "&tob=" + tob + "&hourofb=" + ihob + "&minuteofb=" + imob + "&country=" + conob + "&state=" + statob + "&dist=" + distob + "&city=" + cityob + "&latit=" + lati + "&longit=" + longi + "&tzo=" + timezone + "&prof=" + profession + "&sex=" + sex + "&cd=" + cd + "", null);

     window.open('homenewpage.aspx?clmail=' + clmail + "&clname=" + clname + "&astname=" + astname + "&astmail=" + astmail + "&usermail=" + document.getElementById("hdnuser").value + "&group=" + group + "&group_u=" + document.getElementById('grp_cat').options[document.getElementById('grp_cat').selectedIndex].text  + "&mobile=" + document.getElementById("mobile_" + cmail1).value + "&dob=" + document.getElementById("age1_" + cmail1).value + "&tob=" + document.getElementById("tob_" + cmail1).value + "&country=" + document.getElementById("con_" + cmail1).value + "&state=" + document.getElementById("state_" + cmail1).value + "&dist=" + document.getElementById("dist_" + cmail1).value + "&city=" + document.getElementById("city_" + cmail1).value + "&prof=" + document.getElementById("prof1_" + cmail1).value + "&sex=" + document.getElementById("gender1_" + cmail1).value + "&cd=" + 2);

    return false;
}


function newcl()
{
 var astrologer= document.getElementById('Hidden9').value;
 var astname= document.getElementById('name_0').value;
 var flag = 0;
 //window.open('astro_client.aspx?astrologer=' + astrologer + "&astname=" + astname + "&usermail=" + document.getElementById('hdnuser').value + "&flag=" + flag);
 window.open('addclient.aspx?astrologer=' + astrologer + "&astname=" + astname + "&usermail=" + document.getElementById('hdnuser').value + "&flag=" + flag);
return false;}

function click_trcode(hd)
{var astrologer= document.getElementById('Hidden9').value;
var grop=document.getElementById('clgroup').value;

 valueType=hd;

if(valueType=="cliname")
{
  viewcolname="CLIENT_NAME";
}

else if(valueType=="prof")
{
  viewcolname="PROFESSION";
}

var orderby ="";
if(flag1==true)
{

orderby="ASC";
flag1=false
}
else
{

orderby="DESC";
flag1=true

}

myaccount.abc(astrologer, grop, viewcolname, orderby, document.getElementById('grp_cat').value,callback_fillgrid2);

return false;

}

function craeatnewchart() {
    var astmail = document.getElementById('Hidden9').value;
    var astname = document.getElementById('name_0').value;
    var clmail = "";
    var clname = "";
   // alert(astmail); 
    var group = document.getElementById('clgroup').value;
    window.open('homenewpage.aspx?astmail=' + astmail + "&astname=" + astname + "&clmail=" + clmail + "&clname=" + clname + "&usermail=" + document.getElementById('hdnuser').value + "&group=" + group);

   return false;}


function delete_data(id) {
    var group = document.getElementById('clgroup').options[document.getElementById('clgroup').selectedIndex].text;
    
    var groupu = document.getElementById('grp_cat').options[document.getElementById('grp_cat').selectedIndex].text;
    var spl = id.split('_')
    var spl1 = spl[1];
    if (id == 'delete_0') {
        var flag = 'A'
        var client_id = "";
     }
     else {
     
         var flag = 'C';
         var client_id = document.getElementById('climale1_' + spl1).value;
         var r = confirm("Are You Sure You Want To Delete This? ");
         if (r == true) {
             var astrologer_id = document.getElementById('hdnas').value;

             myaccount.datadel(astrologer_id, client_id, flag, group, groupu)
             alert('Delete Sucessfully')
             if (flag == 'A') {
                 window.open('login.aspx');

             }
             if (flag == 'C') {
                 cldetail();

             }
         }
         else {
             return false;
         }
     }
 }