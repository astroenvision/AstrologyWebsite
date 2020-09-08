var dasha_pattern = "";
var ds = "";
var res = "";

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


function dashacalculate()
{
    var mdegree =parseInt(document.getElementById('hdnmdegree').value);
    var mminute = parseInt(document.getElementById('hdnmminute').value);
    var msecond = parseInt(document.getElementById('hdnmsecond').value);
    var mrashi = document.getElementById('hdnmrashi').value;
    var htob = parseInt(document.getElementById('hdnihob').value);
    var mtob = parseInt(document.getElementById('hdnimob').value);
    var stob = parseInt(0);
    var dob = parseInt(document.getElementById('hdnidob').value);
    var mob = parseInt(document.getElementById('hdnimoob').value);
    var yob = parseInt(document.getElementById('hdniyob').value);
    var astrologer = document.getElementById('hdnusermail').value;
    res = dasha_pattern.caldasha(mdegree, mminute, msecond, mrashi, dob, mob, yob, htob, mtob, stob, astrologer);
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
       document.getElementById('bod').innerHTML = dsgrid.Tables[0].Rows[0]['BALANCEDASA'];
       document.getElementById('RadioButton1').checked = true
       if (document.getElementById('RadioButton4').checked == true) {
           if (dsgrid.Tables[1].Rows.length > 0) {

               buf2 = "";
               buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='460px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
               buf2 += "<tr>"
               buf2 += "<td class='colum-td-head'>" + "PLANET1" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "PLANET2" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "PLANET3" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "PLANET4" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "YEAR" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "MONTH" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "DAY" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "HOUR" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "MINUTE" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "SECOND" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "DASHA_START" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "DASHA_PERIOD" + "</td>"
               buf2 += "</tr>"
               len = 1;




               for (i = 0; i < dsgrid.Tables[1].Rows.length; ++i) {


                   buf2 += "<tr>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' class='dropdown_large_corr'; align='left' value='" + dsgrid.Tables[1].Rows[i]['PLANET1'] + "'  id='name_" + i + "'  >"
                   buf2 += "</td>"




                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text'Enabled='false'disabled style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[1].Rows[i]['PLANET2'] + "'  id='pmail1_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[1].Rows[i]['PLANET3'] + "'  id='altmail_" + i + "'  >"
                   buf2 += "</td>"



                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[1].Rows[i]['PLANET4'] + "'  id='mobno_" + i + "'  >"
                   buf2 += "</td>"



                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[1].Rows[i]['YEAR'] + "'  id='landno_" + i + "'  >"
                   buf2 += "</td>"



                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[1].Rows[i]['MONTH'] + "'  id='add1_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[1].Rows[i]['DAY'] + "'  id='add2_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[1].Rows[i]['HOUR'] + "'  id='landmark_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[1].Rows[i]['MINUTE'] + "'  id='country_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td  class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[1].Rows[i]['SECOND'] + "'  id='zip_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[1].Rows[i]['DASHA_START'] + "'  id='pwd_" + i + "'  >"
                   buf2 += "</td>"

                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[1].Rows[i]['DASHA_PERIOD'] + "'  id='pwd_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "</tr>"

               }
           }
       }


       if (document.getElementById('RadioButton3').checked == true) {
           if (dsgrid.Tables[2].Rows.length > 0) {

               buf2 = "";
               buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='460px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
               buf2 += "<tr>"
               buf2 += "<td class='colum-td-head'>" + "PLANET1" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "PLANET2" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "PLANET3" + "</td>"

               buf2 += "<td class='colum-td-head'>" + "YEAR" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "MONTH" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "DAY" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "HOUR" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "MINUTE" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "SECOND" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "DASHA_START" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "DASHA_PERIOD" + "</td>"
               buf2 += "</tr>"
               len = 1;




               for (i = 0; i < dsgrid.Tables[2].Rows.length; ++i) {


                   buf2 += "<tr>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' class='dropdown_large_corr'; align='left' value='" + dsgrid.Tables[2].Rows[i]['PLANET1'] + "'  id='name_" + i + "'  >"
                   buf2 += "</td>"




                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text'Enabled='false'disabled style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[2].Rows[i]['PLANET2'] + "'  id='pmail1_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[2].Rows[i]['PLANET3'] + "'  id='altmail_" + i + "'  >"
                   buf2 += "</td>"




                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[2].Rows[i]['YEAR'] + "'  id='landno_" + i + "'  >"
                   buf2 += "</td>"



                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[2].Rows[i]['MONTH'] + "'  id='add1_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[2].Rows[i]['DAY'] + "'  id='add2_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[2].Rows[i]['HOUR'] + "'  id='landmark_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[2].Rows[i]['MINUTE'] + "'  id='country_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td  class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[2].Rows[i]['SECOND'] + "'  id='zip_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[2].Rows[i]['DASHA_START'] + "'  id='pwd_" + i + "'  >"
                   buf2 += "</td>"

                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[2].Rows[i]['DASHA_PERIOD'] + "'  id='pwd_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "</tr>"

               }
           }
       }


       if (document.getElementById('RadioButton2').checked == true) {
           if (dsgrid.Tables[3].Rows.length > 0) {

               buf2 = "";
               buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='460px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
               buf2 += "<tr>"
               buf2 += "<td class='colum-td-head'>" + "PLANET1" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "PLANET2" + "</td>"


               buf2 += "<td class='colum-td-head'>" + "YEAR" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "MONTH" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "DAY" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "HOUR" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "MINUTE" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "SECOND" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "DASHA_START" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "DASHA_PERIOD" + "</td>"
               buf2 += "</tr>"
               len = 1;




               for (i = 0; i < dsgrid.Tables[3].Rows.length; ++i) {


                   buf2 += "<tr>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' class='dropdown_large_corr'; align='left' value='" + dsgrid.Tables[3].Rows[i]['PLANET1'] + "'  id='name_" + i + "'  >"
                   buf2 += "</td>"




                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text'Enabled='false'disabled style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[3].Rows[i]['PLANET2'] + "'  id='pmail1_" + i + "'  >"
                   buf2 += "</td>"






                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[3].Rows[i]['YEAR'] + "'  id='landno_" + i + "'  >"
                   buf2 += "</td>"



                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[3].Rows[i]['MONTH'] + "'  id='add1_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[3].Rows[i]['DAY'] + "'  id='add2_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[3].Rows[i]['HOUR'] + "'  id='landmark_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[3].Rows[i]['MINUTE'] + "'  id='country_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td  class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[3].Rows[i]['SECOND'] + "'  id='zip_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[3].Rows[i]['DASHA_START'] + "'  id='pwd_" + i + "'  >"
                   buf2 += "</td>"

                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[3].Rows[i]['DASHA_PERIOD'] + "'  id='pwd_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "</tr>"

               }
           }
       }

       if (document.getElementById('RadioButton1').checked == true) {
           if (dsgrid.Tables[4].Rows.length > 0) {

               buf2 = "";
               buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='460px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
               buf2 += "<tr>"
               buf2 += "<td class='colum-td-head'>" + "PLANET1" + "</td>"

               buf2 += "<td class='colum-td-head'>" + "YEAR" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "MONTH" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "DAY" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "HOUR" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "MINUTE" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "SECOND" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "DASHA_START" + "</td>"
               buf2 += "<td class='colum-td-head'>" + "DASHA_PERIOD" + "</td>"
               buf2 += "</tr>"
               len = 1;




               for (i = 0; i < dsgrid.Tables[4].Rows.length; ++i) {


                   buf2 += "<tr>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' class='dropdown_large_corr'; align='left' value='" + dsgrid.Tables[4].Rows[i]['PLANET1'] + "'  id='name_" + i + "'  >"
                   buf2 += "</td>"




                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[4].Rows[i]['YEAR'] + "'  id='landno_" + i + "'  >"
                   buf2 += "</td>"



                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[4].Rows[i]['MONTH'] + "'  id='add1_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[4].Rows[i]['DAY'] + "'  id='add2_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[4].Rows[i]['HOUR'] + "'  id='landmark_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[4].Rows[i]['MINUTE'] + "'  id='country_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td  class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[4].Rows[i]['SECOND'] + "'  id='zip_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[4].Rows[i]['DASHA_START'] + "'  id='pwd_" + i + "'  >"
                   buf2 += "</td>"

                   buf2 += "<td class='colum-td'>"
                   buf2 += "<input type='text' style='width:200px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[4].Rows[i]['DASHA_PERIOD'] + "'  id='pwd_" + i + "'  >"
                   buf2 += "</td>"


                   buf2 += "</tr>"

               }
           }
       }

       buf2 += "</table>"
       var hdsview = "";
       temp_del1 = aa + buf2.toString();
       temp_del1 = temp_del1.replace("<TBODY>", "")
       temp_del1 = temp_del1.replace("</TBODY>", "")
       document.getElementById('hdsviewgrid').innerHTML = temp_del1;





   }


   return false;
}


function callback_fillgrid(res) {

   
}


