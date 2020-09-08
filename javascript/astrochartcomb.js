function SelectHiii(grdid, obj, objlist) {
   
    if (document.getElementById("DataGrid1_ctl01_cb1").checked == true) {
        var j1;
        var j;
        var str1 = "DataGrid1_ctl01_cb1";
        for (j = 1; j <= document.getElementById("DataGrid1").rows.length; j++) {
            if (objlist == "cb1") {
                document.getElementById(str1).checked = true;
                var str2 = str1.split('_')[1]
                var str3 = str2.split('l')[1]
                var str4 = str2.split('l')[0]
                str3 = str3
                str3 = Number(str3) + 1;
                if (str3 >= 10) {
                    str1 = "DataGrid1_ctl" + str3 + "_cbx1";
                }
                else {
                    str1 = "DataGrid1_ctl0" + str3 + "_cbx1";
                }

            }
        }
    }
    else {
        var j1;
        var j;
        var str1 = "DataGrid1_ctl02_cbx1";
        for (j = 1; j < document.getElementById("DataGrid1").rows.length; j++) {
            if (objlist == "cb1") {
                document.getElementById(str1).checked = false;
                var str2 = str1.split('_')[1]
                var str3 = str2.split('l')[1]
                var str4 = str2.split('l')[0]
                str3 = str3
                str3 = Number(str3) + 1;
                if (str3 >= 10) {
                    str1 = "DataGrid1_ctl" + str3 + "_cbx1";
                }
                else {
                    str1 = "DataGrid1_ctl0" + str3 + "_cbx1";
                }
            }
        }
        return false;
    }

}


function vargas()
{
var vargas=document.getElementById('Hidden4').value;
document.getElementById('planet').value=document.getElementById('Hidden1').value;
document.getElementById('balance').value=document.getElementById('Hidden2').value;
astrochartcombi.vargasvalue(vargas,callback_vargas);
return false;
}


function callback_vargas(val) {
    record_show = 11
    record_show1 = 1
    var gg4 = 0;
    exec_data = val.value;
    var i = 0

    if (exec_data.Tables[0].Rows.length > 0) {
        document.getElementById('hdsviewgrid').innerHTML = "";
        document.getElementById('Divgrid1').style.display = 'block';
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

        if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:600;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='600px' height='0px' style='border:1px solid;border-color:#7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:100px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "PLANET" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D1_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D1_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:100px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "DEGREE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:150px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "BIRTH_TIME" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D2_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D2_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D3_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D3_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D4_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D4_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D5_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D5_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D6_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D6_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D7_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D7_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D8_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D8_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D9_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D9_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D10_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D10_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D11_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D11_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D12_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D12_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D16_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D16_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D20_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D20_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D24_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D24_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D27_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D27_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D30_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D30_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D40_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D40_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D45_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D45_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D60_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D60_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "SHASHTYAMSHA_NAME" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "D60_NATURE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "KARAKAMSHA_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:80px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "KARAKAMSHA_RASHI" + "</td>"
        buf2 += "</tr>"


        len = 1;


        if (exec_data.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"
//                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'> "
//                buf2 += "<label  style='width:90px; font-family:helvetica;' class='dropdown_large_corr'; align='left' Text='" + exec_data.Tables[0].Rows[i]['PLANET'] + "'  id=planets_" + i + " >"
//                buf2 += "</td>"
                
                
                 buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['PLANET']) + "</font>"
               buf2 +="<input type='hidden' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['PLANET'])+">"
              buf2 += "</td>"
                
                

                 buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D1_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D1_HOUSE'])+">"
              buf2 += "</td>"


                buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D1_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D1_RASHI'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td   style='width:100px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='100px'>" +(exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
               buf2 +="<input type='hidden' id=degree_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE'])+">"
              buf2 += "</td>"
              
               buf2 += "<td    style='width:150px;'class='dropdown_large_corr1'; align='center' >"
               buf2 += "<font width='150px'>" +(exec_data.Tables[0].Rows[i]['BIRTH_TIME']) + "</font>"
               buf2 +="<input type='hidden' id=birth_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['BIRTH_TIME'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D2_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d2house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D2_HOUSE'])+">"
              buf2 += "</td>"
              
                  buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D2_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d2rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D2_RASHI'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D3_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d3house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D3_HOUSE'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D3_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d3rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D3_RASHI'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D4_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d4house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D4_HOUSE'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D4_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d4rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D4_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D5_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d5house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D5_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D5_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d5rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D5_RASHI'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D6_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d6house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D6_HOUSE'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D6_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d6rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D6_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D7_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d7house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D7_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D7_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d7rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D7_RASHI'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D8_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d8house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D8_HOUSE'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D8_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d8rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D8_RASHI'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D9_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d9house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D9_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D9_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d9rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D9_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D10_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d10house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D10_HOUSE'])+">"
              buf2 += "</td>"
                  buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D10_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d10rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D10_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D11_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d11house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D11_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D11_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d11rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D11_RASHI'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D12_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d12house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D12_HOUSE'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D12_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d12rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D12_RASHI'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D16_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d16house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D16_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D16_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d16rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D16_RASHI'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D20_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d20house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D20_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D20_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d20rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D20_RASHI'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D24_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d24house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D24_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D24_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d24rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D24_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D27_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d27house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D27_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D27_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d27rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D27_RASHI'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D30_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d30house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D30_HOUSE'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D30_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d30rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D30_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D40_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d40house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D40_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D40_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d40rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D40_RASHI'])+">"
              buf2 += "</td>"
                 
                 
                   buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D45_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d45house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D45_HOUSE'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D45_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d45rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D45_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D60_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d60house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D60_HOUSE'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D60_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d60rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D60_RASHI'])+">"
              buf2 += "</td>"
                
               
                    buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['SHASHTYAMSHA_NAME']) + "</font>"
               buf2 +="<input type='hidden' id=d60shash_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['SHASHTYAMSHA_NAME'])+">"
              buf2 += "</td>"
              
                
                
                    buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['D60_NATURE']) + "</font>"
               buf2 +="<input type='hidden' id=d60nature_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D60_NATURE'])+">"
              buf2 += "</td>"
              
              
              
                  buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['KARAKAMSHA_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=karkahouse_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['KARAKAMSHA_HOUSE'])+">"
              buf2 += "</td>"
                   buf2 += "<td   style='width:90px;'class='dropdown_large_corr1'; align='left' >"
               buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['KARAKAMSHA_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=karkarashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['KARAKAMSHA_RASHI'])+">"
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
        //alert(temp_del1)
        document.getElementById('hdsviewgrid').innerHTML = temp_del1;



    }



}

var ds2 = "";

function search123() {
    if(document.getElementById('chart').value=="0")
    {
    alert('Please select the chart')
    return false;
    }
        var chart=document.getElementById('chart').value;
        document.getElementById('hdsviewgrid2').innerHTML = "";
        document.getElementById('Divgrid2').style.display = "none";
        var planets = "";
        var key = "";
    var kk = "";
    var ss = "";
    //var ds1 = "";
    for ( var i = 0; i < document.getElementById('lstcategery').options.length; ++i) {
        if (document.getElementById('lstcategery').options[i].selected == true) {
            ss = ss + document.getElementById('lstcategery').options[i].innerHTML + "$";
            document.getElementById('CheckBox2').checked = true;
        }

    }

    if (document.getElementById('CheckBox1').checked == true) 
    {
        kk = 1;
        document.getElementById('CheckBox2').checked == false
    }
   else if (document.getElementById('CheckBox2').checked == true) 
    {
        kk = 0;
        document.getElementById('CheckBox1').checked == false
    }
   else {
    
    kk="";
}



if (ss != "") {
    ss= ss.slice(0, -1);
        if (document.getElementById('CheckBox1').checked == false && document.getElementById('CheckBox2').checked == false) {
            alert("Please Select Checkbox");
            return false;

        } 
    }
    
        var s = "";
        for (var i = 0; i < 11; i++) {
            
           var degree=document.getElementById('degree_' + i).value
        var degree1=degree.split('.');
        if(chart=='D01')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('rashi_' + i).value + "~" + document.getElementById('house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        
        }
        if(chart=='D02')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d2rashi_' + i).value + "~" + document.getElementById('d2house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D03')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d3rashi_' + i).value + "~" + document.getElementById('d3house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D04')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d4rashi_' + i).value + "~" + document.getElementById('d4house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D05')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d5rashi_' + i).value + "~" + document.getElementById('d5house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D06')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d6rashi_' + i).value + "~" + document.getElementById('d6house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D07')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d7rashi_' + i).value + "~" + document.getElementById('d7house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D08')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d8rashi_' + i).value + "~" + document.getElementById('d8house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D09')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d9rashi_' + i).value + "~" + document.getElementById('d9house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D10')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d10rashi_' + i).value + "~" + document.getElementById('d10house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D11')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d11rashi_' + i).value + "~" + document.getElementById('d11house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D12')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d12rashi_' + i).value + "~" + document.getElementById('d12house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D16')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d16rashi_' + i).value + "~" + document.getElementById('d16house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D20')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d20rashi_' + i).value + "~" + document.getElementById('d20house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D24')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d24rashi_' + i).value + "~" + document.getElementById('d24house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D27')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d27rashi_' + i).value + "~" + document.getElementById('d27house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D30')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d30rashi_' + i).value + "~" + document.getElementById('d30house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D40')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d40rashi_' + i).value + "~" + document.getElementById('d40house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D45')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d45rashi_' + i).value + "~" + document.getElementById('d45house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
        if(chart=='D60')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('d60rashi_' + i).value + "~" + document.getElementById('d60house_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
        }
    
          if(chart=='KL')
        {
            var s = s + document.getElementById('planets_' + i).value + "~" + document.getElementById('karkarashi_' + i).value + "~" + document.getElementById('karkahouse_' + i).value + "~" + degree1[0] + "~" + degree1[1] + "~" + degree1[2] + "~" + '0' + "~" + '0' + "~" + "0" + "$";
     }
         
        }
        var rashi = document.getElementById('rashi_' + 0).value;
        key = document.getElementById('k1').value;
        
         
        
        if(document.getElementById('CheckBoxSun').checked == true)
        {
            planets = planets + document.getElementById('LabelSun').innerHTML + "$";
        }

        if (document.getElementById('CheckBoxMoon').checked == true) {
            planets = planets + document.getElementById('LabelMoon').innerHTML + "$";
         }

        if (document.getElementById('CheckBoxMars').checked == true) {
            planets = planets + document.getElementById('LabelMars').innerHTML + "$";
             }

        if (document.getElementById('CheckBoxMercury').checked == true) {
            planets = planets + document.getElementById('LabelMercury').innerHTML + "$";
         }

        if (document.getElementById('CheckBoxJupitor').checked == true) {
            planets = planets + document.getElementById('LabelJupitor').innerHTML + "$";
         }

        if (document.getElementById('CheckBoxVenus').checked == true) {
            planets = planets + document.getElementById('LabelVenus').innerHTML + "$";
         }

        if (document.getElementById('CheckBoxSaturn').checked == true) {
            planets = planets + document.getElementById('LabelSaturn').innerHTML + "$";
         }

        if (document.getElementById('CheckBoxRahu').checked == true) {
            planets = planets + document.getElementById('LabelRahu').innerHTML + "$";
         }

        if (document.getElementById('CheckBoxKetu').checked == true) {
            planets = planets + document.getElementById('LabelKetu').innerHTML + "$";
         }
         
        

         if (planets != "") {
             planets = planets.slice(0, -1);

         }
         

         var res1 = astrochartcombi.searchdesc(s, ss, kk, rashi, key, planets,chart);
       
         var ds1 = res1.value;

         ds2 = ds1;
        
        document.getElementById('Divgrid2').style.top = 750 + "px";
        document.getElementById('Divgrid2').style.left = -285 + "px";
        document.getElementById('Divgrid2').style.BackColor = "Ivory";
        var temp_del1 = "";

        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;
        var flag = "0";
        document.getElementById('hdsviewgrid2').style.display = "block";
        document.getElementById('Divgrid2').style.display = "block";
        
        if (document.getElementById("hdsviewgrid2").children.length == "0") {
            klen = "0"
        }
        else 
        {
            klen = document.getElementById("Divgrid2").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("Divgrid2").innerHTML.indexOf("width:900px;display:block") <= 0) {
            aa = document.getElementById("Divgrid2").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='hdsviewgrid2' runat='server' align='center' Width='500px' height='0px' style='border:1px;margin-left:100px; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:120px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "DESCRIPTION" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:50px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "KEY_STRING" + "</td>"

        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:150px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "DETAIL_DESCRIPTION" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:30px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "EXPLANATION" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:100px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "BOOK" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:50px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "DETAIL" + "</td>"
        
      
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:50px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "UPDATE" + "</td>"
        
        buf2 += "</tr>"

        len = 1;

        if (ds1.Tables[0].Rows.length > 0) {
            for (i = 0; i < ds1.Tables[0].Rows.length; ++i) {




              

               
                buf2 += "<tr>"

               
                    
                        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                        buf2 += "<textarea type='text' style='width:150px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr';  id='description_" + i + "'>" + ds1.Tables[0].Rows[i]['DESCRIPTION'] + "</textarea>" 
                        buf2 += "</td>"
                    
                 if (ds1.Tables[0].Rows[i]['KEY_STRING'] == null) {
                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<textarea type='text' style='width:200px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='key_" + i + "'>" + "</textarea>" 
                    buf2 += "</td>"
                }
                else {
                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<textarea type='text' style='width:200px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='key_" + i + "'>" + ds1.Tables[0].Rows[i]['KEY_STRING'] + "</textarea>" 
                    buf2 += "</td>"
                }


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:300px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr';  id=detaild_" + i + "  >" + ds1.Tables[0].Rows[i]['DESCCLOB']+ "</textarea>" 
                buf2 += "</td>"
                
                
                
                if (ds1.Tables[0].Rows[i]['EXPLANATION'] == null) {
                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<textarea type='text' style='width:100px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='explain_" + i + "'>" + "</textarea>" 
                    buf2 += "</td>"
                }
                else {
                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<textarea type='text' style='width:100px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr'; id='explain_" + i + "'>" + ds1.Tables[0].Rows[i]['EXPLANATION'] + "</textarea>" 
                    buf2 += "</td>"
                }

               
              

               
//                    
//                   
                        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                      buf2 += "<textarea type='text' style='width:100px; height:100px; font-family:helvetica; font-size:14px;' align='left' class='dropdown_large_corr';  id=book_" + i + "  >" + ds1.Tables[0].Rows[i]['BOOK']+ "</textarea>" 
                      buf2 += "</td>"
//                

//               
//                
//                
                buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:50px; ' align='left' class='dropdown_large_corr'; Text='Detail' value='Detail' AutoPostBack='true' id=detail_" + i + " onClick='javascript:return descclob1(id);' >More...</Button>"
                buf2 += "</td>"
                



              
          
          
                buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<Button  style='width:50px; ' align='left' Text='Update' class='dropdown_large_corr'; value='Update' AutoPostBack='true' id=update_" + i + " onClick='javascript:return update1234(id);' >Update...</Button>"
                buf2 += "</td>"


               

                buf2 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
                buf2 += "<input type='text' style='display:none; font-family:helvetica;' align='left' class='dropdown_large_corr'; id=text_" + i + " >"
                buf2 += "</td>"


                
              
                buf2 += "</tr>"
            }
        }
        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
      //  alert(temp_del1);
      
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('hdsviewgrid2').innerHTML = temp_del1;
        return false;
    }
    
    
     function categery123(event) {
      
        
        var keycode = event.keyCode ? event.keyCode : event.which;
        if (keycode == 113) 
        {
            if (document.activeElement.id == "categery") {



                document.getElementById('lstcategery').value = "";
                //var compcode = $('hdncompcode').value;
                //var unit=$('hdnunitcode').value;          
                document.getElementById("divcategery").style.display = "block";
                document.getElementById('divcategery').style.top = 445 + "px";
                document.getElementById('divcategery').style.left = 150 + "px";
                var extra1 = document.getElementById('categery').value;
                document.getElementById('categery').focus();
                astrochartcombi.fill_categery(extra1, callback_fillcategery)

            }

        }

        if (keycode == 27) {

            document.getElementById('divcategery').style.display = "none";
            document.getElementById('categery').focus()
            return false;

        }

        else if (keycode == 8 || keycode == 46) {
            document.getElementById('categery').value = "";
            return true;
        }

        else if (event.ctrlKey == true && keycode == 88) {
            document.getElementById('categery').value = "";
            // $('txtreason').focus();
            return true;
        }
        else if (keycode == 9) {
            return keycode;
        }
        else if (keycode == 13) {
            return false;
        }
        else {
            document.getElementById('categery').focus();
            return keycode;
        }

    }
    function callback_fillcategery(res) {
        ds = res.value;
        if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
            var pkgitem = document.getElementById("lstcategery");
            pkgitem.options.length = 0;
            pkgitem.options[0] = new Option("--Select categery--", "0");
            pkgitem.options.length = 1;
            for (var i = 0; i < ds.Tables[0].Rows.length; ++i) {
                //pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].REASON_CODE+"-"+ds.Tables[0].Rows[i].REASON_NAME,ds.Tables[0].Rows[i].REASON_CODE);
                pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].CATEGERY, ds.Tables[0].Rows[i].CATEGERY);
                pkgitem.options.length;
            }
        }
        document.getElementById('lstcategery').focus();
        document.getElementById('CheckBox2').checked = true;
        document.getElementById('CheckBox1').checked = false;
        //document.getElementById("lstcategery").value="0";
        return false;
    }
    
     function closelist(event) {
        var keycode = event.keyCode ? event.keyCode : event.which;
        if (keycode == 27) {
        for ( var i = 0; i < document.getElementById('lstcategery').options.length; ++i) 
        {
            document.getElementById('lstcategery').options[i].selected = false;
            
        }
            document.getElementById('divcategery').style.display = "none";
            document.getElementById('categery').value = "";
            document.getElementById('categery').focus();
            document.getElementById('CheckBox2').checked = false;
            document.getElementById('CheckBox1').checked = false;
            return false;
        }

    }
    
    
    
    
    function descclob1(id) {




        document.getElementById('hidden123').value = id;
  

        var detail = id.split('_')
        var detail1 = detail[1];
        document.getElementById("Div3").style.display = "block";


           
            $('Div3').style.top = findPos($(id), "top");
            $('Div3').style.left = findPos($(id), "left")

        document.getElementById("list").value = document.getElementById("detaild_" + detail1).value;
        return false;
    }
    
    
    function findPos(obj, val) {

       
    var curleft = curtop = 0;

    if (obj.offsetParent) {
        curleft = obj.offsetLeft

        curtop = obj.offsetTop

        while (obj = obj.offsetParent) {
            if (document.getElementById('hidden123').value.indexOf("detail_") < 0) {
                curleft += obj.offsetLeft + 105;

                curtop += obj.offsetTop
            }
            else {
                curleft += obj.offsetLeft+20;
                curtop += obj.offsetTop
            }
        }

    }
    curtop = curtop += 5;
    if (val == "top")
        return curtop +"px";
    else
        return curleft + "px";
}


 function chk()
    { document.getElementById('CheckBox2').checked = true; }
    
    function chk1() {
    document.getElementById('CheckBox2').checked = false;
}
    
    function chk2() {
        document.getElementById('CheckBox1').checked = false;
    }
    
    
    
    
    
    var flag1 = "0";
function keywordpressed(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    
    if (flag1 == "1") {
        if (document.getElementById('k1').value == "") {

            document.getElementById('CheckBox2').checked = false;
            document.getElementById('CheckBox1').checked = false;
            flag1 = "0";
        }
        else {
            document.getElementById('CheckBox2').checked = true;
            document.getElementById('CheckBox1').checked = false;
            flag1 = "0";
        }
    }
    else 
    {
        if (event.keyCode == 8 || event.keyCode == 46) 
        {
            return;
        }
        else
         {
            document.getElementById('CheckBox2').checked = true;
            document.getElementById('CheckBox1').checked = false;
            flag1 = "1";
        } 
    }
}




   function update1234(id)
     {
        
    
       
        var update = id.split('_')
        var update1 = update[1];
        var description = ds2.Tables[0].Rows[update1].DESCRIPTION
       
        var key = ds2.Tables[0].Rows[update1].KEY_STRING
       if (key == null) {
            key = "";
       }
        var description1 = document.getElementById("description_" + update1).value;
        if (description1 == "") {

            description1 = description;
        
        }
        var key1 = document.getElementById("key_" + update1).value;
        if (key1 == null) {
            key1 = "";
        }

        var explain = document.getElementById("explain_" + update1).value;
        if (explain == null) {
            explain = "";
        }
        
        
        var descclob = document.getElementById("detaild_" + update1).value;
        var res = astrochartcombi.update_grid(description, description1, descclob, key, key1, explain);
   

            alert("Data updated Successfully")
          
    
        return false;
        
    }
    
    
    
function vargaschart()
 {
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
var chartname=document.getElementById('chart').value;
document.getElementById('Label1').innerHTML = chartname+' Chart';
    document.getElementById('rashiid').style.display = "block";
   for (var i = 1; i < 10; i++) 
    {
        document.getElementById('Hidden5').value = i;
            if(document.getElementById('chart').value=='D01')
            {
                var h = document.getElementById('house_' + i).value
                var r=document.getElementById('rashi_' + 0).value
                
            }
            
            if(document.getElementById('chart').value=='D02')
            {
                var h = document.getElementById('d2house_' + i).value
                var r=document.getElementById('d2rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D03')
            {
                var h = document.getElementById('d3house_' + i).value
                var r=document.getElementById('d3rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D04')
            {
                var h = document.getElementById('d4house_' + i).value
                var r=document.getElementById('d4rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D05')
            {
                var h = document.getElementById('d5house_' + i).value
                var r=document.getElementById('d5rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D06')
            {
                var h = document.getElementById('d6house_' + i).value
                var r=document.getElementById('d6rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D07')
            {
                var h = document.getElementById('d7house_' + i).value
                var r=document.getElementById('d7rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D08')
            {
                var h = document.getElementById('d8house_' + i).value
                var r=document.getElementById('d8rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D09')
            {
                var h = document.getElementById('d9house_' + i).value
                var r=document.getElementById('d9rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D10')
            {
                var h = document.getElementById('d10house_' + i).value
                var r=document.getElementById('d10rashi_' + 0).value
            }
            if(document.getElementById('chart').value=='D11')
            {
                var h = document.getElementById('d11house_' + i).value
                var r=document.getElementById('d11rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D12')
            {
                var h = document.getElementById('d12house_' + i).value
                var r=document.getElementById('d12rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D16')
            {
                var h = document.getElementById('d16house_' + i).value
                var r=document.getElementById('d16rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D20')
            {
                var h = document.getElementById('d20house_' + i).value
                var r=document.getElementById('d20rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D24')
            {
                var h = document.getElementById('d24house_' + i).value
                var r=document.getElementById('d24rashi_' + 0).value
            }
            
             if(document.getElementById('chart').value=='D27')
            {
                var h = document.getElementById('d27house_' + i).value
                var r=document.getElementById('d27rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D30')
            {
                var h = document.getElementById('d30house_' + i).value
                var r=document.getElementById('d30rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D40')
            {
                var h = document.getElementById('d40house_' + i).value
                var r=document.getElementById('d40rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D45')
            {
                var h = document.getElementById('d45house_' + i).value
                var r=document.getElementById('d45rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='D60')
            {
                var h = document.getElementById('d60house_' + i).value
                var r=document.getElementById('d60rashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='KL')
            {
                var h = document.getElementById('karkahouse_' + i).value
                var r=document.getElementById('karkarashi_' + 0).value
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
document.getElementById('h1l1').innerHTML = p1+" "+'Asc';
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
document.getElementById('h12r').innerHTML = r12;
document.getElementById('h1r').innerHTML = r1;
document.getElementById('h2r').innerHTML = r2;
document.getElementById('h3r').innerHTML = r3;
document.getElementById('h4r').innerHTML = r4;
document.getElementById('h5r').innerHTML = r5;
document.getElementById('h6r').innerHTML = r6;
document.getElementById('h7r').innerHTML = r7;
document.getElementById('h8r').innerHTML = r8;
document.getElementById('h9r').innerHTML = r9;
document.getElementById('h10r').innerHTML = r10;
document.getElementById('h11r').innerHTML = r11;
    
    return false;}



   
