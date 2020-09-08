function chkallinto(id) {
    if (document.getElementById('chkboxinto_h').checked == true) {
        for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
            if (document.getElementById('chkboxinto_' + i).checked == false) {
                document.getElementById('chkboxinto_' + i).checked = true;

            }

        }
    }
    else {
        for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
            if (document.getElementById('chkboxinto_' + i).checked == true) {
                document.getElementById('chkboxinto_' + i).checked = false;

            }
        }
    }


}


function f1bindplanetaspplanet()
{

var planet= document.getElementById('f1planet').value;
var house= document.getElementById('f1house').value;
var aspplanet = document.getElementById('f1aceptplanet').value;
var ahouse=document.getElementById('f1ahouse').value;
predictive_input1.planetaspectplanet(planet,house,aspplanet,ahouse,callback_f1grid);
return false;
}

function callback_f1grid(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f1grid').innerHTML = "";
        document.getElementById('f1div').style.display = 'block';
        document.getElementById('f1div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f1grid').style.display = "block";

        if (document.getElementById("f1grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f1div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f1grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f1grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f1div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASPECTED_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASPECTED_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "PLANET_RASHI" + "</td>"
        
        
        
         


        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f1rh1_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f1r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f1h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "</textarea>"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f1ar_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_RASHI'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f1ah_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_HOUSE'] + "</textarea>"
                buf2 += "</td>"
                
                                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f1pr_" + i + "'>" + exec_data1.Tables[0].Rows[i]['PLANET_RASHI'] + "</textarea>"
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
        document.getElementById('f1grid').innerHTML = temp_del1;



    }
    
    
    
    




}




function f1_save123()
 {
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        var lagnarashi = document.getElementById('f1rh1_' + i).value;
        var book = document.getElementById('f1book').value;
        var page = document.getElementById('f1page').value;
        var filter = document.getElementById('f1filter').value;
        var lordofhouse = document.getElementById('f1planet').value;
        
        var rashi = document.getElementById('f1r_' + i).value;
        var house = document.getElementById('f1h_' + i).value;
        var lord = document.getElementById('f1aceptplanet').value;
        var asphouse = document.getElementById('f1ah_' + i).value;
        var asprashi = document.getElementById('f1ar_' + i).value;
       
        var aplanet = document.getElementById('f1aplanet').value;
        var ahouse = document.getElementById('f1ahouse').value;
        var arashi = document.getElementById('f1pr_' + i).value;
        var unique =document.getElementById('f1unique').value;
        var combination = lordofhouse+rashi+house+lord +asprashi+ asphouse+aplanet+arashi+ahouse;
        var detail = document.getElementById('f1detail').value;
        var chart = document.getElementById('f1chart').value;
        
        var fid="PI1_"+document.getElementById('f1id').innerHTML;
     
        var description = lordofhouse + ' in ' + house + ' Aspected by ' + lord+ ' and ' + aplanet+ ' in ' + ahouse;
        var nop = "3";
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!

        var yyyy = today.getFullYear();
        if (dd < 10) { dd = '0' + dd }
        if (mm < 10) { mm = '0' + mm }
        today = dd + '/' + mm + '/' + yyyy;
      predictive_input1.save_lordwithplanetwithmalifics(lagnarashi,lordofhouse,lord,house,rashi,combination, book, page, filter, detail, description, nop,chart,unique,fid,today);
    }
    alert('saved successfully')
    document.getElementById('f1house').value = "";
    document.getElementById('f1planet').value = "";
    document.getElementById('f1aplanet').value = "";    
    document.getElementById('f1book').value = "";
    document.getElementById('f1filter').value = "";
    document.getElementById('f1page').value = "";
    document.getElementById('f1detail').value = "";
    
    return false;
}

function f2binddispositor()
{
var dhouse=document.getElementById('f2dhouse').value;
var house=document.getElementById('f2house').value;
predictive_input1.f2binddispositor(dhouse,house,callback_f2grid);
return false;
}


function callback_f2grid(val) 
{
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) 
    {
        document.getElementById('f2grid').innerHTML = "";
        document.getElementById('f2div').style.display = 'block';
        document.getElementById('f2div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f2grid').style.display = "block";

        if (document.getElementById("f2grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f2div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f2grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f2grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f2div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LORD" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASPECTED_BY_PLANET" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASPECTED_BY_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASPECTED_BY_HAOUSE" + "</td>"
       
        
        
        
        
         


        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f2l_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LORD'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f2r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f2h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "</textarea>"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f2rhl_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f2ap_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_BY_PLANET'] + "</textarea>"
                buf2 += "</td>"
                
                                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f2ar_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_BY_RASHI'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f2ah_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_BY_HOUSE'] + "</textarea>"
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
        document.getElementById('f2grid').innerHTML = temp_del1;



    }
    
  
}
function f2_save()
{
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        var lagnarashi = document.getElementById('f2rhl_'+i).value;
        var book = document.getElementById('f2book').value;
        var page = document.getElementById('f2page').value;
        var filter = document.getElementById('f2filter').value;
        //var lordofhouse = document.getElementById('f2planet').value;
        
        var rashi = document.getElementById('f2r_' + i).value;
        var house = document.getElementById('f2h_' + i).value;
        var lord = document.getElementById('f2l_' + i).value;
        var unique =document.getElementById('f2unique').value;
        var dlord = document.getElementById('f2ap_' + i).value;
        var asphouse = document.getElementById('f2ah_' + i).value;
        var asprashi = document.getElementById('f2ar_' + i).value;
       
        var lordofhouse=document.getElementById('f2dhouse').value;
        var ahouse=document.getElementById('f2house').value;
       
        var combination = lord+rashi+house+dlord +asprashi+ asphouse;
        var detail = document.getElementById('f2detail').value;
        var fid= "PI1_"+document.getElementById('f2id').innerHTML;
        var description ='Dispositor of Lord of '+ lordofhouse + ' in ' + ahouse ;
        var nop = "2";
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!

        var yyyy = today.getFullYear();
        if (dd < 10) { dd = '0' + dd }
        if (mm < 10) { mm = '0' + mm }
        today = dd + '/' + mm + '/' + yyyy;
      predictive_input1.save_lordwithplanetwithmalifics(lagnarashi,lordofhouse,lord,house,rashi,combination, book, page, filter, detail, description, nop,chart,unique,fid,today);
    }
    alert('saved successfully')
    document.getElementById('f2house').value = "";
    document.getElementById('f2dhouse').value = "";
    
    document.getElementById('f2book').value = "";
    document.getElementById('f2filter').value = "";
    document.getElementById('f2page').value = "";
    document.getElementById('f2detail').value = "";
    document.getElementById('f2unique').value="";
    document.getElementById('f2chart').value="";
  
    return false;
}





function f3planetasploh()
{
var planet=document.getElementById('f3planet').value;
var house=document.getElementById('f3house').value;
var lohouse=document.getElementById('f3lohhouse').value;
predictive_input1.f3planetasploh(planet,house,lohouse,callback_f3grid);
return false;
}




function callback_f3grid(val) 
{
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) 
    {
        document.getElementById('f3grid').innerHTML = "";
        document.getElementById('f3div').style.display = 'block';
        document.getElementById('f3div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f3grid').style.display = "block";

        if (document.getElementById("f3grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f3div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f3grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f3grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f3div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LORD" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASPECTED_BY_PLANET" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASPECTED_BY_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASPECTED_BY_HOUSE" + "</td>"
       
        
        
        
        
         


        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f3l_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LORD'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f3r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f3h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "</textarea>"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f3rhl_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"
                
                
                 buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f3ap_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_BY_PLANET'] + "</textarea>"
                buf2 += "</td>"
                
                                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f3ar_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_BY_RASHI'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f3ah_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_BY_HOUSE'] + "</textarea>"
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
        document.getElementById('f3grid').innerHTML = temp_del1;



    }
    
  
}


function f3_save()
{
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        var lagna = document.getElementById('f3rhl_'+i).value;
        var f13book = document.getElementById('f3book').value;
        var f13page = document.getElementById('f3page').value;
        var keystring = document.getElementById('f3filter').value;
        
       // var lordofhouse = document.getElementById('f3lohhouse').value;
        var rashi = document.getElementById('f3r_' + i).value;
        var f13house = document.getElementById('f3h_' + i).value;
        var f13planet = document.getElementById('f3l_' + i).value;
        var unique = document.getElementById('f3unique').value;
        
        var f13aplanet = document.getElementById('f3ap_' + i).value;
        var asphouse = document.getElementById('f3ah_' + i).value;
        var asprashi = document.getElementById('f3ar_' + i).value;
       
        var lordofhouse=document.getElementById('f3lohhouse').value;
        
       
        var combination = f13planet+rashi+f13house+f13aplanet +asprashi+ asphouse;
        var detail = document.getElementById('f3detail').value;
        var chart = document.getElementById('f3chart').value;
        var fid = "PI1_"+document.getElementById('f3id').innerHTML;
        var desc =f13planet +' in '+ f13house + ' Aspected by Lord of ' + lordofhouse ;
var nop ="2";


var today = new Date();
var dd = today.getDate();
var mm = today.getMonth() + 1; //January is 0!

var yyyy = today.getFullYear();
if (dd < 10) { dd = '0' + dd }
if (mm < 10) { mm = '0' + mm }
today = dd + '/' + mm + '/' + yyyy;
     
      predictive_input1.save_f13(f13planet, f13house, f13aplanet, f13book, f13page, keystring, detail, desc, combination, lagna,chart,unique,fid,today)
    }
    alert('saved successfully')
    document.getElementById('f3house').value = "";
    document.getElementById('f3lohhouse').value = "";
    
    document.getElementById('f3book').value = "";
    document.getElementById('f3filter').value = "";
    document.getElementById('f3page').value = "";
    document.getElementById('f3detail').value = "";
    document.getElementById('f3unique').value="";
    document.getElementById('f3chart').value="";
 
    return false;
}


function f4lohinfixed()
{
var loh=document.getElementById('f4loh').value;
var rashi=document.getElementById('f4rashi').value;
predictive_input1.f4lohinfixed(loh,rashi,callback_f4grid);
return false;
}


function callback_f4grid(val) 
{
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f4grid').innerHTML = "";
        document.getElementById('f4div').style.display = 'block';
        document.getElementById('f4div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f4grid').style.display = "block";

        if (document.getElementById("f4grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f4div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f4grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f4grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f4div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LORD" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"
        
       
        
       
        
        
        
        
         


        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f4rhl_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f4l_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LORD'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f4r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI'] + "</textarea>"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f4h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "</textarea>"
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
        document.getElementById('f4grid').innerHTML = temp_del1;



    }
    
  
}


function f4_save() 
{

 for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) 
{
    var f4sign=document.getElementById('f4rashi').value;   
    var f4loh=document.getElementById('f4loh').value;
     var lagnarashi = document.getElementById('f4rhl_'+i).value;
    var f4planet = document.getElementById('f4l_'+i).value;
    var f4house = document.getElementById('f4h_'+i).value;
    var f4rashi = document.getElementById('f4r_'+i).value;
    var f4book = document.getElementById('f4book').value;
    var f4page = document.getElementById('f4page').value;
    var f4filter = document.getElementById('f4filter').value;
    var unique = document.getElementById('f4unique').value;
    var f4detail = document.getElementById('f4detail').value;
    var f4chart =document.getElementById('f4chart').value;
    var fid ="PI1_"+document.getElementById('f4id').innerHTML;
    var f4description ="Lord of "+ f4loh + " in " + f4sign + " Rashi " ;
    var f4name = f4planet + " - " + f4rashi + " - " + f4house;
    var nop = "1"
    var today = new Date();
    var dd = today.getDate();
    var mm = today.getMonth() + 1; //January is 0!

    var yyyy = today.getFullYear();
    if (dd < 10) { dd = '0' + dd }
    if (mm < 10) { mm = '0' + mm }
    today = dd + '/' + mm + '/' + yyyy;
   predictive_input1.save_f4predictiveinput(f4planet,f4house,f4rashi,f4book, f4page, f4filter, f4detail, f4description, f4name,f4chart,unique,fid,today);
    }
    alert('saved successfully');
    document.getElementById('f4rashi').value = "";
    
    document.getElementById('f4book').value = "";
    document.getElementById('f4page').value = "";
    document.getElementById('f4filter').value = "";
    document.getElementById('f4detail').value = "";
    document.getElementById('f4unique').value="";
   
    document.getElementById('f4loh').value ="";
     document.getElementById('f4chart').value ="";

    return false;

}

function f5dopinrashi()
{
var dop=document.getElementById('f5dop').value;
var rashi=document.getElementById('f5rashi').value;
predictive_input1.f5dopinrashi(dop,rashi,callback_f5grid);
return false;
}



function callback_f5grid(val) 
{
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f5grid').innerHTML = "";
        document.getElementById('f5div').style.display = 'block';
        document.getElementById('f5div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f5grid').style.display = "block";

        if (document.getElementById("f5grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f5div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f5grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f5grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f4div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LORD" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASPECTED_BY_PLANET" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASPECTED_BY_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASPECTED_BY_HOUSE" + "</td>"
       
       
        
       
        
       
        
        
        
        
         


        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f5l_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LORD'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f5r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f5h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "</textarea>"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f5rhl_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f5ap_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_BY_PLANET'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f5ar_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_BY_RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f5ah_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_BY_HOUSE'] + "</textarea>"
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
        document.getElementById('f5grid').innerHTML = temp_del1;



    }
    
  
}



function f5_save()
{
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        var lagnarashi = document.getElementById('f5rhl_'+i).value;
        var book = document.getElementById('f5book').value;
        var page = document.getElementById('f5page').value;
        var filter = document.getElementById('f5filter').value;
        //var lordofhouse = document.getElementById('f2planet').value;
        var lordofhouse=document.getElementById('f5dop').value;
        var inrashi=document.getElementById('f5rashi').value;
        var rashi = document.getElementById('f5r_' + i).value;
        var house = document.getElementById('f5h_' + i).value;
        var lord = document.getElementById('f5l_' + i).value;
        var unique =document.getElementById('f5unique').value;
        var dlord = document.getElementById('f5ap_' + i).value;
        var asphouse = document.getElementById('f5ah_' + i).value;
        var asprashi = document.getElementById('f5ar_' + i).value;
       
        
       
       
        var combination = lord+rashi+house+dlord +asprashi+ asphouse;
        var detail = document.getElementById('f5detail').value;
        var chart = document.getElementById('f5chart').value;
        var fid ="PI1_"+document.getElementById('f5id').innerHTML;
        var description ='Dispositor of '+ lordofhouse + ' in ' + inrashi ;
        var nop = "2";
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!

        var yyyy = today.getFullYear();
        if (dd < 10) { dd = '0' + dd }
        if (mm < 10) { mm = '0' + mm }
        today = dd + '/' + mm + '/' + yyyy;
      predictive_input1.save_lordwithplanetwithmalifics(lagnarashi,lordofhouse,lord,house,rashi,combination, book, page, filter, detail, description, nop,chart,unique,fid,today);
    }
    alert('saved successfully')
    document.getElementById('f5house').value = "";
    document.getElementById('f5dhouse').value = "";
    
    document.getElementById('f5book').value = "";
    document.getElementById('f5filter').value = "";
    document.getElementById('f5page').value = "";
    document.getElementById('f5detail').value = "";
    document.getElementById('f5unique').value="";
     document.getElementById('f5chart').value="";
      document.getElementById('f5dop').value="";
       document.getElementById('f5rashi').value="";
    return false;
}




function f6planetinownrashi()
{

var planet= document.getElementById('f6planet').value;
var rashi= document.getElementById('f6rashi').value;

predictive_input1.f6planetinownrashi(planet,rashi,callback_f6grid);
return false;
}




function callback_f6grid(val) 
{
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f6grid').innerHTML = "";
        document.getElementById('f6div').style.display = 'block';
        document.getElementById('f6div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f6grid').style.display = "block";

        if (document.getElementById("f6grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f6div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f6grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f6grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f6div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "CODE" + "</td>"
      
        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f6c_" + i + "'>" + exec_data1.Tables[0].Rows[i]['CODE'] + "</textarea>"
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
        document.getElementById('f6grid').innerHTML = temp_del1;



    }
    
  
}


function fillf6house(event) 
{
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "f6house") {
            document.getElementById('f1lstmultiplehouse').value = "";
            //var compcode = $('hdncompcode').value;
            //var unit=$('hdnunitcode').value;
            document.getElementById("f1divmultiplehouse").style.display = "block";
          document.getElementById('f1divmultiplehouse').style.top = findPos(document.getElementById('f6house'), "top");
       document.getElementById('f1divmultiplehouse').style.left = findPos(document.getElementById('f6house'), "left");
      

            var extra1 = document.getElementById('f6house').value;
            document.getElementById('f6house').focus();
            predictive_input1.fill_house(extra1, callback_house);
            return false;
        }

    }


}


function callback_house(res) {
    ds = res.value;
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        var pkgitem = document.getElementById("f1lstmultiplehouse");
        pkgitem.options.length = 0;
        pkgitem.options[0] = new Option("Any House", "0");
        pkgitem.options.length = 1;
        for (var i = 0; i < ds.Tables[0].Rows.length; ++i) {
            //pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].REASON_CODE+"-"+ds.Tables[0].Rows[i].REASON_NAME,ds.Tables[0].Rows[i].REASON_CODE);
            pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].CODE);
            pkgitem.options.length;
        }
    }
    document.getElementById('f1lstmultiplehouse').style.display = "block";
    document.getElementById('f1lstmultiplehouse').focus();
    return false;
}
        
        
        
        
function findPos(obj,val) 
{
   var curleft = curtop = 0;

   if (obj.offsetParent) {
       curleft = obj.offsetLeft

       curtop = obj.offsetTop

       while (obj = obj.offsetParent) {
           curleft += obj.offsetLeft

           curtop += obj.offsetTop

       }

   }
   curtop = curtop += 5;
   if (val == "top")
       return curtop +"px";
   else
       return curleft + "px";
       
}





function planetinhouse() {
  for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i)
  {  
 
    if (document.getElementById('f1lstmultiplehouse').options[0].selected == true) {
        for (var h = 1; h <= 12; ++h) {
            var f4house = 'HOUSE' + h;
            var f4planet = document.getElementById('f6planet').value;
             var f4rashi = document.getElementById('f6c_' + i).value;
            var f4name = f4planet+"-"+f4rashi+"-"+ f4house;
            var f4description = f4planet + " in " +f4rashi+" in "+f4house;
            var f4book = document.getElementById('f6book').value;
            var f4page = document.getElementById('f6page').value;
            var f4filter = document.getElementById('f6filter').value;
            var f4detail = document.getElementById('f6detail').value;
            var unique = document.getElementById('f6unique').value;
            var chart = document.getElementById('f6chart').value;
            var fid ="PI1_"+document.getElementById('f6id').innerHTML;
            var today = new Date();
            var dd = today.getDate();
            var mm = today.getMonth() + 1; //January is 0!

            var yyyy = today.getFullYear();
            if (dd < 10) { dd = '0' + dd }
            if (mm < 10) { mm = '0' + mm }
            today = dd + '/' + mm + '/' + yyyy;
             predictive_input1.save_f4predictiveinput(f4planet,f4house,f4rashi,f4book, f4page, f4filter, f4detail, f4description, f4name,chart,unique,fid,today);
            
        }
        alert('save successfully');
        document.getElementById('f6book').value = "";
        document.getElementById('f6page').value = "";
        document.getElementById('f6filter').value = "";
        document.getElementById('f6detail').value = "";
        document.getElementById('f6unique').value="";
        document.getElementById('f6chart').value="";
        
        
        return false;
    }
    else {

        for (var j = 0; j < document.getElementById('f1lstmultiplehouse').options.length; ++j) {
            if (document.getElementById('f1lstmultiplehouse').options[j].selected == true) {
                var f4house = document.getElementById('f1lstmultiplehouse').options[j].innerHTML;
                var f4planet = document.getElementById('f6planet').value;
                var f4rashi = document.getElementById('f6c_' + i).value;
                var f4name = f4planet+"-"+f4rashi+"-"+ f4house;
                var f4description = f4planet + " in " + f4rashi+" in "+f4house;
                var f4book = document.getElementById('f6book').value;
                var f4page = document.getElementById('f6page').value;
                var f4filter = document.getElementById('f6filter').value;
                var f4detail = document.getElementById('f6detail').value;
                var unique = document.getElementById('f6unique').value;
                var chart = document.getElementById('f6chart').value;
                var fid ="PI1_"+document.getElementById('f6id').innerHTML;
               predictive_input1.save_f4predictiveinput(f4planet,f4house,f4rashi,f4book, f4page, f4filter, f4detail, f4description, f4name,chart,unique,fid);
            }


        }
        alert('save successfully');
        document.getElementById('f6book').value = "";
        document.getElementById('f6page').value = "";
        document.getElementById('f6filter').value = "";
        document.getElementById('f6detail').value = "";
         document.getElementById('f6unique').value = "";
          document.getElementById('f6chart').value = "";
        return false;
    }

}

}



function fillf7house(event) 
{
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "f7house") {
            document.getElementById('f1lstmultiplehouse').value = "";
            //var compcode = $('hdncompcode').value;
            //var unit=$('hdnunitcode').value;
            document.getElementById("f1divmultiplehouse").style.display = "block";
          document.getElementById('f1divmultiplehouse').style.top = findPos(document.getElementById('f6house'), "top");
       document.getElementById('f1divmultiplehouse').style.left = findPos(document.getElementById('f6house'), "left");
      

            var extra1 = document.getElementById('f7house').value;
            document.getElementById('f7house').focus();
            predictive_input1.fill_house(extra1, callback_house);
            return false;
        }

    }


}

 

        



function f7planetinbenmal()

{
 
var benmal = document.getElementById('f7benmal').value;

predictive_input1.f7planetinbenmal(benmal,callback_f7grid);
return false;
}


function callback_f7grid(val) 
{
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f7grid').innerHTML = "";
        document.getElementById('f7div').style.display = 'block';
        document.getElementById('f7div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f7grid').style.display = "block";

        if (document.getElementById("f7grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f7div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f7grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f7grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f6div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "CODE" + "</td>"
      
        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f7c_" + i + "'>" + exec_data1.Tables[0].Rows[i]['CODE'] + "</textarea>"
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
        document.getElementById('f7grid').innerHTML = temp_del1;



    }
    
  
}

var name=""
var house=""
function planetinbenmal()
{
for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i)
 {

     var benmal=document.getElementById('f7c_' + i).value;
    if (document.getElementById('f1lstmultiplehouse').options[0].selected == true)
     
    {
        for (var h = 1; h <= 12; ++h)
         {
        var planet=document.getElementById('f7planet').value
                   name = planet + "-" + 'HOUSE' + h + "~"+benmal+"-"+'HOUSE'+h;
                    
                
            


            
         
             nop = '2';
             
            var book = document.getElementById('f7book').value
            var page = document.getElementById('f7page').value
            var filter = document.getElementById('f7filter').value
            var detail = document.getElementById('f7detail').value
            
            var chart = document.getElementById('f7chart').value
            var unique = document.getElementById('f7unique').value
            var fid ="PI1_"+document.getElementById('f7id').innerHTML
            var description = planet + " with " + benmal + " in " + " HOUSE" + h;
            var today = new Date();
            var dd = today.getDate();
            var mm = today.getMonth() + 1; //January is 0!

            var yyyy = today.getFullYear();
            if (dd < 10) { dd = '0' + dd }
            if (mm < 10) { mm = '0' + mm }
            today = dd + '/' + mm + '/' + yyyy;
          predictive_input1.multipleplanetinanyhouse(name, book, page, filter, detail, description, nop,chart,unique,fid,today);


        }
        name=""
house=""
    }





    else {





        for (var j = 0; j < document.getElementById('f1lstmultiplehouse').options.length; ++j)
         {
            if (document.getElementById('f1lstmultiplehouse').options[j].selected == true) {
                house = house + document.getElementById('f1lstmultiplehouse').options[j].innerHTML + "-";

            }
        }

        if (house != "") {
            house = house.slice(0, -1);

        }

        house = house.split('-')

        for (var k = 0; k < house.length; ++k) 
        {
            var planet = document.getElementById('f7planet').value
                    var benmal=document.getElementById('f7c_' + i).value; 
                    name =  planet + "-" + house[k] + "~"+benmal+"-"+house[k];
                    
                
            
           var nop ='2';
           
            
            var book = document.getElementById('f7book').value
            var page = document.getElementById('f7page').value
            var filter = document.getElementById('f7filter').value
            var detail = document.getElementById('f7detail').value
            var description = planet+" with "+benmal+" in "+house[k];
             var chart = document.getElementById('f7chart').value
            var unique = document.getElementById('f7unique').value
            var fid = "PI1_" + document.getElementById('f7id').innerHTML;
            var today = new Date();
            var dd = today.getDate();
            var mm = today.getMonth() + 1; //January is 0!

            var yyyy = today.getFullYear();
            if (dd < 10) { dd = '0' + dd }
            if (mm < 10) { mm = '0' + mm }
            today = dd + '/' + mm + '/' + yyyy;
            predictive_input1.multipleplanetinanyhouse(name, book, page, filter, detail, description, nop,chart,unique,fid,today);
            
          
           
        }
          house=""
          name=""
    }
}
alert('Saved Succesfully');
        house = "";
        document.getElementById('f7book').value = "";
        document.getElementById('f7chart').value = "";
        document.getElementById('f7filter').value = "";
        document.getElementById('f7detail').value = "";
        return false;
}


function lordhouseasphouse()
{
var loh=document.getElementById('f8loh').value;
var house=document.getElementById('f8house').value;
var ahouse=document.getElementById('f8ahouse').value;
predictive_input1.lordhouseasphouse(loh,house,ahouse,callback_f8grid)
return false;
}


function callback_f8grid(val) 
{
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f8grid').innerHTML = "";
        document.getElementById('f8div').style.display = 'block';
        document.getElementById('f8div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f8grid').style.display = "block";

        if (document.getElementById("f8grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f8div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f8grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f8grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f8div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LORD" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASPECTED_BY_PLANET" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASPECTED_BY_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASPECTED_BY_HOUSE" + "</td>"
       
       
        
       
        
       
        
        
        
        
         


        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f8l_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LORD'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f8r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f8h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "</textarea>"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f8rhl_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f8ap_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_BY_PLANET'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f8ar_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_BY_RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f8ah_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_BY_HOUSE'] + "</textarea>"
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
        document.getElementById('f8grid').innerHTML = temp_del1;



    }
    
  
}





function f8_save()
{
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        var lagna = document.getElementById('f8rhl_'+i).value;
        var f13book = document.getElementById('f8book').value;
        var f13page = document.getElementById('f8page').value;
        var keystring = document.getElementById('f8filter').value;
        var ahouse = document.getElementById('f8ahouse').value;
        var lordofhouse = document.getElementById('f8loh').value;
        var rashi = document.getElementById('f8r_' + i).value;
        var f13house = document.getElementById('f8h_' + i).value;
        var f13planet = document.getElementById('f8l_' + i).value;
        var unique = document.getElementById('f8unique').value;
        
        var f13aplanet = document.getElementById('f8ap_' + i).value;
        var asphouse = document.getElementById('f8ah_' + i).value;
        var asprashi = document.getElementById('f8ar_' + i).value;
       
        
        
       
        var combination = f13planet+rashi+f13house+f13aplanet +asprashi+ asphouse;
        var detail = document.getElementById('f8detail').value;
        var chart = document.getElementById('f8chart').value;
        var fid = "PI1_" + document.getElementById('f8id').innerHTML;
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!

        var yyyy = today.getFullYear();
        if (dd < 10) { dd = '0' + dd }
        if (mm < 10) { mm = '0' + mm }
        today = dd + '/' + mm + '/' + yyyy;
        var desc ='lord of '+ lordofhouse +' in '+ f13house + ' Aspected by Lord of' + ahouse ;
var nop ="2";

     
      predictive_input1.save_f13(f13planet, f13house, f13aplanet, f13book, f13page, keystring, detail, desc, combination, lagna,chart,unique,fid,today)
    }
    alert('saved successfully')
    document.getElementById('f8house').value = "";
   
    
    document.getElementById('f8book').value = "";
    document.getElementById('f8filter').value = "";
    document.getElementById('f8page').value = "";
    document.getElementById('f8detail').value = "";
    document.getElementById('f8unique').value="";
    document.getElementById('f8chart').value="";
 
    return false;
}

function closehouse(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 27) {
        for (var i = 0; i < document.getElementById('f1lstmultiplehouse').options.length; ++i) {
            document.getElementById('f1lstmultiplehouse').options[i].selected = false;

        }
        document.getElementById('f1divmultiplehouse').style.display = "none";
        
        document.getElementById('f6house').value = "";
        document.getElementById('f7house').value = "";
        
        return false;
    }

}




function inhouse123()
{
var loh=document.getElementById('f9loh').value;
var benmal=document.getElementById('f9benmal').value;
var house=document.getElementById('f9house').value;
predictive_input1.inhouse123(loh, benmal, house,callback_f9grid)
return false;
}

function callback_f9grid(val) 
{
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f9grid').innerHTML = "";
        document.getElementById('f9div').style.display = 'block';
        document.getElementById('f9div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f9grid').style.display = "block";

        if (document.getElementById("f9grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f9div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f9grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f9grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f9div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "PLANET" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "MAL_BEN" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "MAL_BEN_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "MAL_BEN_HOUSE" + "</td>"
       



        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f9rhl_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f9p_" + i + "'>" + exec_data1.Tables[0].Rows[i]['PLANET'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f9r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI'] + "</textarea>"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f9h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f9mb_" + i + "'>" + exec_data1.Tables[0].Rows[i]['MAL_BEN'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f9mbr_" + i + "'>" + exec_data1.Tables[0].Rows[i]['MAL_BEN_RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f9mbh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['MAL_BEN_HOUSE'] + "</textarea>"
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
        document.getElementById('f9grid').innerHTML = temp_del1;



    }
    
  
}






function f9_save()
{
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        var lordofhouse = document.getElementById('f9loh').value;
        var benmal = document.getElementById('f9benmal').value;
        var house = document.getElementById('f9house').value;
        var filter = document.getElementById('f9filter').value;
    var chart=document.getElementById('f9chart').value;
    var page=document.getElementById('f9page').value;
        var book=document.getElementById('f9book').value;
        var rashi = document.getElementById('f9r_' + i).value;
        var lagnarashi = document.getElementById('f9rhl_' + i).value;
        var house = document.getElementById('f9h_' + i).value;
     
        var lord = document.getElementById('f9p_' + i).value;
        var unique =document.getElementById('f9unique').value;
        
        var malben = document.getElementById('f9mb_' + i).value;
        var malbenrashi = document.getElementById('f9mbr_' + i).value;
      
       
       
       
        var malbenhouse = document.getElementById('f9mbh_' + i).value;
        var combination = lord+rashi+house+malben +malbenrashi+malbenhouse;
        var detail = document.getElementById('f9detail').value;
        var fid= "PI1_"+document.getElementById('f9id').innerHTML;
        var description =' Lord of '+ lordofhouse + ' with ' + benmal+' in '+ house;
        var nop = "2";
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!

        var yyyy = today.getFullYear();
        if (dd < 10) { dd = '0' + dd }
        if (mm < 10) { mm = '0' + mm }
        today = dd + '/' + mm + '/' + yyyy;
      predictive_input1.save_lordwithplanetwithmalifics(lagnarashi,lordofhouse,lord,house,rashi,combination, book, page, filter, detail, description, nop,chart,unique,fid,today);
    }
    alert('saved successfully')
    document.getElementById('f9house').value = "";
    //document.getElementById('f9dhouse').value = "";
    
    document.getElementById('f9book').value = "";
    document.getElementById('f9filter').value = "";
    document.getElementById('f9page').value = "";
    document.getElementById('f9detail').value = "";
    document.getElementById('f9unique').value="";
    document.getElementById('f9chart').value="";
  
    return false;
}



function benmalinhouse()
{


var loh=document.getElementById('f10loh').value;
var benmal=document.getElementById('f10benmal').value;
var res=predictive_input1.benmalinhousebet(loh, benmal);
callback_f10grid(res);
return false;
}


function callback_f10grid(val) 
{
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f10grid').innerHTML = "";
        document.getElementById('f10div').style.display = 'block';
        document.getElementById('f10div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f10grid').style.display = "block";

        if (document.getElementById("f10grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f10div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f10grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f10grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f10div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "COMBINATION" + "</td>"
     
       



        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f10lr_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f10c_" + i + "'>" + exec_data1.Tables[0].Rows[i]['COMBINATION'] + "</textarea>"
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
        document.getElementById('f10grid').innerHTML = temp_del1;



    }
return false;
  
}



function f10_save()
{
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        var lordofhouse = document.getElementById('f10loh').value;
        var benmal = document.getElementById('f10benmal').value;
       
        var filter = document.getElementById('f10filter').value;
    var chart=document.getElementById('f10chart').value;
    var page=document.getElementById('f10page').value;
        var book=document.getElementById('f10book').value;
        var lagnarashi = document.getElementById('f10lr_' + i).value;
      
        var unique =document.getElementById('f10unique').value;
        
     
       
       
       
    var lord=document.getElementById('f10loh').value;
    var rashi=document.getElementById('f10loh').value;
    var house=document.getElementById('f10loh').value;
        
        var combination = document.getElementById('f10c_' + i).value;
        var detail = document.getElementById('f10detail').value;
        var fid= "PI1_"+document.getElementById('f10id').innerHTML;
        var description =' Lord of '+ lordofhouse + ' in between ' + benmal;
        var nop = "3";
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!

        var yyyy = today.getFullYear();
        if (dd < 10) { dd = '0' + dd }
        if (mm < 10) { mm = '0' + mm }
        today = dd + '/' + mm + '/' + yyyy;
    predictive_input1.save_lordwithplanetwithmalifics(lagnarashi,lordofhouse,lord,house,rashi,combination, book, page, filter, detail, description, nop,chart,unique,fid,today);
    }
    alert('saved successfully')
 
  
    
    document.getElementById('f10book').value = "";
    document.getElementById('f10filter').value = "";
    document.getElementById('f10page').value = "";
    document.getElementById('f10detail').value = "";
    document.getElementById('f10unique').value="";
    document.getElementById('f10chart').value="";
  
    return false;
}












function planetbenmalbet()
{


var planet=document.getElementById('f11planet').value;
var benmal=document.getElementById('f11benmal').value;
var res=predictive_input1.planetbenmalbet(planet, benmal);
callback_f11grid(res);
return false;
}


function callback_f11grid(val) 
{
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f11grid').innerHTML = "";
        document.getElementById('f11div').style.display = 'block';
        document.getElementById('f11div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f11grid').style.display = "block";

        if (document.getElementById("f11grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f11div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f11grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f11grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f11div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "COMBINATION" + "</td>"
     
       



        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f11lr_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f11c_" + i + "'>" + exec_data1.Tables[0].Rows[i]['COMBINATION'] + "</textarea>"
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
        document.getElementById('f11grid').innerHTML = temp_del1;



    }
return false;

}
function houseindeb() {


    var house = document.getElementById('f13loh').value;
    var deb = document.getElementById('f13deb').value;
    var res = predictive_input1.houseindebo(house);
    callback_f13grid(res);
    return false;
}

function callback_f13grid(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;

    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f13grid').innerHTML = "";
        document.getElementById('f13div').style.display = 'block';
        document.getElementById('f13div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f13grid').style.display = "block";

        if (document.getElementById("f13grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f13div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f13grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f13grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f13div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "COMBINATION" + "</td>"





        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f13lr_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f13c_" + i + "'>" + exec_data1.Tables[0].Rows[i]['COMBINATION'] + "</textarea>"
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
        document.getElementById('f13grid').innerHTML = temp_del1;



    }
    return false;

}
function f13_save() {
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        var lordofhouse = document.getElementById('f13loh').value;
        var filter = document.getElementById('f13filter').value;
        var chart = document.getElementById('f13chart').value;
        var page = document.getElementById('f13page').value;
        var book = document.getElementById('f13book').value;
        var lagnarashi = document.getElementById('f13lr_' + i).value;
        var unique = document.getElementById('f13unique').value;
        var combination = document.getElementById('f13c_' + i).value;
        var detail = document.getElementById('f13deatil').value;
       
        var rashi = document.getElementById('f13lr_' + i).value;

        var fid = "PI1_" + document.getElementById('f13id').innerHTML;
        var lord = document.getElementById('f13loh').value;
        var description = 'lord of'+lordofhouse + ' in Debilitation Rashi';
        var nop = "3";

        var house = 'HOUSE1';
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!

        var yyyy = today.getFullYear();
        if (dd < 10) { dd = '0' + dd }
        if (mm < 10) { mm = '0' + mm }
        today = dd + '/' + mm + '/' + yyyy;
        predictive_input1.save_lordwithplanetwithmalifics(lagnarashi, lordofhouse, lord, house, rashi, combination, book, page, filter, detail, description, nop, chart, unique, fid,today);
    }
    alert('saved successfully')

    document.getElementById('f13planet').value = "";
    document.getElementById('f13book').value = "";
    document.getElementById('f13filter').value = "";
    document.getElementById('f13page').value = "";
    document.getElementById('f13detail').value = "";
    document.getElementById('f13unique').value = "";
    document.getElementById('f13chart').value = "";

    return false;
}










function f11_save()
{
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        var lord = document.getElementById('f11planet').value;
        var benmal = document.getElementById('f11benmal').value;
       
        var filter = document.getElementById('f11filter').value;
    var chart=document.getElementById('f11chart').value;
    var page=document.getElementById('f11page').value;
        var book=document.getElementById('f11book').value;
        var lagnarashi = document.getElementById('f11lr_' + i).value;
      
        var unique =document.getElementById('f11unique').value;
        
    var lordofhouse=document.getElementById('f11planet').value;
    var rashi=document.getElementById('f11planet').value;
    var house=document.getElementById('f11planet').value;
        
        var combination = document.getElementById('f11c_' + i).value;
        var detail = document.getElementById('f11detail').value;
        var fid= "PI1_"+document.getElementById('f11id').innerHTML;
        var description = lord + ' in between ' + benmal;
        var nop = "3";
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!

        var yyyy = today.getFullYear();
        if (dd < 10) { dd = '0' + dd }
        if (mm < 10) { mm = '0' + mm }
        today = dd + '/' + mm + '/' + yyyy;
    predictive_input1.save_lordwithplanetwithmalifics(lagnarashi,lordofhouse,lord,house,rashi,combination, book, page, filter, detail, description, nop,chart,unique,fid,today);
    }
    alert('saved successfully')
 
  
    
    document.getElementById('f11book').value = "";
    document.getElementById('f11filter').value = "";
    document.getElementById('f11page').value = "";
    document.getElementById('f11detail').value = "";
    document.getElementById('f11unique').value="";
    document.getElementById('f11chart').value="";
  
    return false;
}





function planetindeb()
{


var planet=document.getElementById('f12planet').value;
var deb=document.getElementById('f12deb').value;
var res = predictive_input1.planetindebrash(planet,callback_f12grid);
callback_f12grid(res);
return false;
}




function callback_f12grid(val) 
{
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f12grid').innerHTML = "";
        document.getElementById('f12div').style.display = 'block';
        document.getElementById('f12div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f12grid').style.display = "block";

        if (document.getElementById("f12grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f12div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f12grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f12grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f12div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "COMBINATION" + "</td>"
     
       



        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f12lr_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f12c_" + i + "'>" + exec_data1.Tables[0].Rows[i]['COMBINATION'] + "</textarea>"
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
        document.getElementById('f12grid').innerHTML = temp_del1;



    }
return false;
  
}




function f12_save()
{
for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
// var lordofhouse = document.getElementById('floh').value;
var filter = document.getElementById('f12filter').value;
var chart=document.getElementById('f12chart').value;
var page=document.getElementById('f12page').value;
var book=document.getElementById('f12book').value;
var lagnarashi = document.getElementById('f12lr_'+ i).value;
var unique =document.getElementById('f12unique').value;
var combination = document.getElementById('f12c_'+i).value;
var detail = document.getElementById('f12deatil').value;
var planet=document.getElementById('f12planet').value;
var rashi=document.getElementById('f12lr_'+ i).value;

var fid= "PI1_"+document.getElementById('f12id').innerHTML;
var lord=document.getElementById('f12planet').value;
var description = planet + ' in Debilitation Rashi';
var nop ="3";
var lordofhouse='HOUSE1';
var house = 'HOUSE1';
var today = new Date();
var dd = today.getDate();
var mm = today.getMonth() + 1; //January is 0!

var yyyy = today.getFullYear();
if (dd < 10) { dd = '0' + dd }
if (mm < 10) { mm = '0' + mm }
today = dd + '/' + mm + '/' + yyyy;
predictive_input1.save_lordwithplanetwithmalifics(lagnarashi,lordofhouse,lord,house,rashi,combination, book, page, filter, detail, description, nop,chart,unique,fid,today);
}
alert('saved successfully')

document.getElementById('f12planet').value = "";
document.getElementById('f12book').value = "";
document.getElementById('f12filter').value = "";
document.getElementById('f12page').value = "";
document.getElementById('f12detail').value = "";
document.getElementById('f12unique').value="";
document.getElementById('f12chart').value="";

return false;
}