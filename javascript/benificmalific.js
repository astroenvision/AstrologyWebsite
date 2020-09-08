var querytype="";
var val = "";
var Houseposition="";
var exec_data = "";
var exec_extention = "";
var showext_value = "";
var next=0;
var execute="";
var Modify = 0;
var benificmalific = "";
var browser = navigator.appName;
var buf2 = new StringBuffer2();
function StringBuffer2() {
    this.buffer = [];
}

StringBuffer2.prototype.append = function append(string) {
    this.buffer.push(string);
    return this;
};


function benmalaspects() {
  var planet=  document.getElementById('planet').value
  var house=  document.getElementById('house').value
  var benmal = document.getElementById('benmal').value
  benificmalific.aspectbenmal(planet, house, benmal, callback_grid);
  return false;

}

var dsgrid = "";
function callback_grid(val) {
  var exec_grid = val.value;
   
     dsgrid = exec_grid
    document.getElementById('hdsviewgrid').innerHTML = "";
    document.getElementById('Divgrid1').style.display = "none";
    if (exec_grid.Tables[0].Rows.length >= 0) {
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

        if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:350px;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='350px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:15px;' class='dropdown_large_corr'; align='left'   id='chk_" + 'h' + "' onClick='javascript:return chkall(this.id);' >"
        buf2 += "</td>"


        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASP_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASP_RASHI" + "</td>"
        if (document.getElementById('benmal').value == 'BENIFICS') {
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:75px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "BENIFICS" + "</td>"
        }
        if (document.getElementById('benmal').value == 'MALIFICS') {
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:75px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "MALIFICS" + "</td>"
        }


        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"

        buf2 += "</tr>"

        // document.getElementById( 'filter_').focus();
        len = 1;

        if (dsgrid.Tables[0].Rows.length == 0) {

        }

        if (dsgrid.Tables[0].Rows.length > 0) {

            for (i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {


                buf2 += "<tr>"




                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:15px;' class='dropdown_large_corr'; align='left'   id='chk_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:75px;' class='dropdown_large_corr'; align='left' value='" + dsgrid.Tables[0].Rows[i]['ASPECTED_HOUSE'] + "'  id='ah_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:75px;' class='dropdown_large_corr'; align='left' value='" + dsgrid.Tables[0].Rows[i]['ASPECTED_RASHI'] + "'  id='ar_" + i + "'  >"
                buf2 += "</td>"
                
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:75px;' class='dropdown_large_corr'; align='left' value='" + dsgrid.Tables[0].Rows[i]['PLANET'] + "'  id='planet_" + i + "'  >"
                buf2 += "</td>"
              
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:80px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['LAGNA_RASHI'] + "'  id='lr_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:80px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['RASHI'] + "'  id='rashi_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:80px;' align='left' class='dropdown_large_corr'; value='" + dsgrid.Tables[0].Rows[i]['HOUSE'] + "'  id='house_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "</tr>"

            }
        }

        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('hdsviewgrid').innerHTML = temp_del1;
       return false;
   }

}


function chkall(id)
 {
     if (document.getElementById('chk_h').checked == true) 
     {
         for (i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
             if (document.getElementById('chk_' + i).checked == false) {
                 document.getElementById('chk_' + i).checked = true;

             }

         }
     }
     else 
     {
         for (i = 0; i < dsgrid.Tables[0].Rows.length; ++i) 
         {
             if (document.getElementById('chk_' + i).checked == true)
              {
                 document.getElementById('chk_' + i).checked = false;

             }
         } 
     }


 }



 function Save_Records()
  {


      for (i = 0; i < dsgrid.Tables[0].Rows.length; ++i) 
      {
          var f14book = document.getElementById('txtbook').value;
          var f14page = "";
         var keystring = document.getElementById('txtkey').value;
         var f14planet = document.getElementById('planet').value;
         var f14aplanet = document.getElementById('benmal').value;
         var planet = document.getElementById('planet_' + i).value;
         var f14house = document.getElementById('house').value;
         var lagna = document.getElementById('lr_' + i).value;
         var aplanetrashi = document.getElementById('ar_' + i).value;
         var aplanethouse = document.getElementById('ah_' + i).value;
         var planetrashi = document.getElementById('rashi_' + i).value;
         var planethouse = document.getElementById('house_' + i).value;
         var combination = f14planet + aplanetrashi + aplanethouse + planet + planetrashi + planethouse;
         var detail = document.getElementById('detail').value;
         var desc = f14planet + ' in ' + f14house + ' Aspected by ' + f14aplanet;

         benificmalific.save(f14planet, f14house, f14aplanet, f14book, f14page, keystring, detail, desc, combination, lagna)
     }
     alert('saved successfully')
     document.getElementById('house').value = "";
     document.getElementById('planet').value = "";
     document.getElementById('benmal').value = "";
     document.getElementById('txtbook').value = "";
     document.getElementById('txtkey').value = "";
     document.getElementById('detail').value = "";
     return false;

      
    

   

 }


 function blankfields() {

     document.getElementById('btnNew').disabled = false;
     document.getElementById('btnNew').focus();
     document.getElementById('btnQuery').disabled = false;
     document.getElementById('btnCancel').disabled = false;
     document.getElementById('btnExit').disabled = false;
     document.getElementById('btnSave').disabled = true;
     document.getElementById('btnExecute').disabled = true;
     document.getElementById('btnfirst').disabled = true;
     document.getElementById('btnlast').disabled = true;
     document.getElementById('btnModify').disabled = true;
     document.getElementById('btnprevious').disabled = true;
     document.getElementById('btnnext').disabled = true;
     document.getElementById('btnDelete').disabled = true;

     document.getElementById('txtsigni').disabled = true;



     return false;
 }


 function modifydata() {

     Modify = 1;

     var modifyduplicacydesc = $('txtextentions').value;

     document.getElementById("txtextentions").disabled = false;



     document.getElementById("btnModify").disabled = true;
     document.getElementById("btnlast").disabled = true;
     document.getElementById("btnnext").disabled = true;
     document.getElementById("btnfirst").disabled = true;
     document.getElementById("btnprevious").disabled = true;
     document.getElementById("btnDelete").disabled = false;
     document.getElementById("btnSave").disabled = false;
     modify = "true";



     delete_record = 0;

     setButtonImages();

     return false;
 }

 function ModifyClass() {









     var txtextentions = (document.getElementById('txtextentions').value);
     var casetxtextentions = txtextentions;









     var hiddenmodtxtextentions = document.getElementById("hiddenmodtxtextentions").value;



     astroextentions.Modifydata1(casetxtextentions, hiddenmodtxtextentions)


     alert("Data updated Successfully")
     click_on_cancel();
     return false;

 }




