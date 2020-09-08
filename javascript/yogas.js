
var menuitemsvalus = "";
function yogasgrid()
 {
    document.getElementById('img1').style.display = 'block';
    var lagnarashi = document.getElementById('Hlagnarashi').value;

    var lagspl = document.getElementById('Hlagnadegree').value;
    var getspl = lagspl.split('.');
    var lagnadegree = getspl[0];

    var degree = document.getElementById('Hdegree').value;
    var house = document.getElementById('Hhouse').value;
    var drop = document.getElementById('Hdrop1').value;
    var degreesecond = document.getElementById('Hdegreesecond').value;
    var moonrashi = document.getElementById('Hmoonrashi').value;
    var moonhouse = document.getElementById('Hmoonhouse').value;
    var sunhouse = document.getElementById('Hsunhouse').value;
     menuitemsvalus = document.getElementById('menuitsmcvalue').value;
    var retro = document.getElementById('Hretro').value;
    var rashie = document.getElementById('Hrashie').value;



    if (drop == 'Horary Yogas') {
        if (menuitemsvalus == '') {
            if(document.getElementById('astrologerid').value=='' || document.getElementById('astrologerid').value=='hshoradm@horary.com')
         {
            var res = yogas.showyogas(lagnarashi, degree, house, degreesecond, menuitemsvalus, retro, rashie, callback_othergrid_admin);
            return false;
         }
         else
         {    
             var res = yogas.showyogas(lagnarashi, degree, house, degreesecond, menuitemsvalus, retro, rashie, callback_othergrid);
             return false;
          }
        }
        else
         {
        if(document.getElementById('astrologerid').value=='' || document.getElementById('astrologerid').value=='hshoradm@horary.com')
        {
            var res = yogas.showyogas(lagnarashi, degree, house, degreesecond, menuitemsvalus, retro, rashie, callback_othergrid_admin);
            return false;
        }
        else
        {    var res = yogas.showyogas(lagnarashi, degree, house, degreesecond, menuitemsvalus, retro, rashie, callback_othergrid);
            return false;
        }
     }
    }

    if (drop == 'Manau Yoga') {
            
        var res = yogas.showyogas_manau(lagnarashi, degree, house, degreesecond, callback_gridkayra);
    }

    if (drop == 'Easarapha Yoga') {

        var res = yogas.showyogas1(lagnarashi, degree, house, menuitemsvalus, retro, callback_othergrid);
    }

    if (drop == 'Kamboola Yoga') {


        var res = yogas.showyogas_kamboola(lagnarashi, degree, house, degreesecond, moonrashi, moonhouse, sunhouse,callback_kaamboola);
    }
    }
    
   
   
   
   
   

    function callback_kaamboola(res) {
       
        record_show = 10
        record_show1 = 1
        var gg4 = 0;
        exec_data = res.value;
        var i = 0

        if (exec_data.Tables[0].Rows.length > 0) {
            document.getElementById('img1').style.display = 'none';
            document.getElementById('hdsviewgrid2').innerHTML = "";
            document.getElementById('Divgrid2').style.display = 'block';
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

            if (document.getElementById("hdsviewgrid2").innerHTML.indexOf("width:100%;display:block") <= 0) {
                aa = document.getElementById("hdsviewgrid2").innerHTML.replace("</TBODY>", "")//</TABLE>","")
            }
            buf2 = "";
            buf2 += "<table  id='Divgrid2' runat='server' align='left' Width='100%' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
//            buf2 += "<tr>"
//            buf2 += "<td  bgcolor= #65b6fc style='height:10px;box-shadow: 2px 2px 5px #000;-webkit-box-shadow: 2px 2px 5px #000;box-shadow: 2px 2px 5px #000;font-weight:600; text-decoration:none;border:2px solid;width:140px;font-size:12px;font-weight:bold;text-align:left;border:1px solid  #ffffff; color:white;'>" + "PLANET" + "</td>"
//            buf2 += "<td  bgcolor= #65b6fc style='height:10px;box-shadow: 2px 2px 5px #000;-webkit-box-shadow: 2px 2px 5px #000;box-shadow: 2px 2px 5px #000;font-weight:600; text-decoration:none;border:2px solid;width:140px;font-size:12px;font-weight:bold;text-align:left;border:1px  solid  #ffffff;color:white;'>" + "PLANET" + "</td>"
//            buf2 += "<td  bgcolor= #65b6fc style='height:10px;box-shadow: 2px 2px 5px #000;-webkit-box-shadow: 2px 2px 5px #000;box-shadow: 2px 2px 5px #000;font-weight:600; text-decoration:none;border:2px solid;width:140px;font-size:12px;font-weight:bold;text-align:left;border:1px solid #ffffff; color:white;'>" + "ITHASALA" + "</td>"
//            buf2 += "<td  bgcolor= #65b6fc style='height:10px;box-shadow: 2px 2px 5px #000;-webkit-box-shadow: 2px 2px 5px #000;box-shadow: 2px 2px 5px #000;font-weight:600; text-decoration:none;border:2px solid;width:140px;font-size:12px;font-weight:bold;text-align:left;border:1px solid  #ffffff; color:white;'>" + "PLANET" + "</td>"
//            buf2 += "<td  bgcolor= #65b6fc style='height:10px;box-shadow: 2px 2px 5px #000;-webkit-box-shadow: 2px 2px 5px #000;box-shadow: 2px 2px 5px #000;font-weight:600; text-decoration:none;border:2px solid;width:140px;font-size:12px;font-weight:bold;text-align:left;border:1px  solid  #ffffff;color:white;'>" + "PLANET" + "</td>"
//            buf2 += "<td  bgcolor= #65b6fc style='height:10px;box-shadow: 2px 2px 5px #000;-webkit-box-shadow: 2px 2px 5px #000;box-shadow: 2px 2px 5px #000;font-weight:600; text-decoration:none;border:2px solid;width:140px;font-size:12px;font-weight:bold;text-align:left;border:1px solid #ffffff; color:white;'>" + "KAAMBOOLA_ITHASALA" + "</td>"
//            buf2 += "</tr>"



            len = 1;


            if (exec_data.Tables[0].Rows.length > 0) {
                for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {

                    buf2 += "<tr>"

                    buf2 += "<td  class='new_grid'>"
                    buf2 += "<font width='90px'>" +((i+1+'.    ')+ exec_data.Tables[0].Rows[i]['PLANET1']) + "</font>"
                    buf2 += "<input type='hidden' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['PLANET1']) + "> has "
//                    buf2 += "</td>"

                    //                    buf2 += "<td  class='new_grid'>"
                    buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['HORARY_KAMBOOLA']) + "</font>"
                    buf2 += "<input type='hidden' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['HORARY_KAMBOOLA']) + "> with "
                    //                    buf2 += "</td>"


                    //                    buf2 += "<td  class='new_grid'>"
                    buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['PLANET2']) + "</font>"
                    buf2 += "<input type='hidden' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['PLANET2']) + ">   Because    "
//                    buf2 += "</td>"


//                    buf2 += "<td  class='new_grid' >"
                    buf2 += "<font width='90px'>" +(exec_data.Tables[0].Rows[i]['LORD']) + "</font>"
                    buf2 += "<input type='hidden' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + "> has "
//                    buf2 += "</td>"

//                    buf2 += "<td  class='new_grid'>"
                    buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['HORARY_ITHASALA']) + "</font>"
                    buf2 += "<input type='hidden' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['HORARY_ITHASALA']) + "> with "
//                    buf2 += "</td>"

//                    buf2 += "<td   class='new_grid' >"
                    buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</font>"
                    buf2 += "<input type='hidden' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['PLANET']) + ">"
                    buf2 += "</td>"

//                   


//                  
                   



                    buf2 += "</tr>"
                }
            }
            buf2 += "</table>"
            var hdsview = "";
            temp_del1 = aa + buf2.toString();
            temp_del1 = temp_del1.replace("<TBODY>", "")
            temp_del1 = temp_del1.replace("</TBODY>", "")
            //alert(temp_del1)
            document.getElementById('hdsviewgrid2').innerHTML = temp_del1;



        }
    }
    
    //------vishu-----//
    
    
    
     function callback_othergrid_admin(res) {
       
        var drop = document.getElementById('Hdrop1').value;
      
        document.getElementById('img1').style.display = 'none';
        record_show = 10
        record_show1 = 1
        var gg4 = 0;
        exec_data = res.value;
        var i = 0
        var b = "";
        var a ="";
        var flag = '0';
        var s = '0';
        var c;
        var d=0;
        if (exec_data.Tables[0].Rows.length > 0) {
            document.getElementById('img1').style.display = 'none';
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

            if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:100%;display:block") <= 0) {
                aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
            }
            buf2 = "";
            buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='100%' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
           



            len = 1;

           
            if (exec_data.Tables[0].Rows.length > 0) {
                for (i = 0; i < exec_data.Tables[0].Rows.length;++i) {
                   

                   



                        if (a != exec_data.Tables[0].Rows[i]['TYPE']) {
                            flag = '0';
                            a = exec_data.Tables[0].Rows[i]['TYPE'];
                        }
                                     if (a == 'Poorna') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a+"/Full Ithasaal" + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                            buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                          buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                           
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                           
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                    

                                            if (a == 'Applying') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                           
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                    
                                 
                                    if (a == 'Friendly Ithasaal') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                           
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                             
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                    
                                

                          if (a == 'Enemical Ithasaal') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                             
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                           
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                             
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                    

                        
                                        if (a == 'Bhavishyath') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                             
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                           
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                           
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                     if (a == 'Rashiyant Ithasaal-Poorna/Full') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a+" Ithasaal" + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                          buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                           
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                           
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                      if (a == 'Applying Rashiyant') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                           
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                    
                                     if (a == 'Rashiyant') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                             
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                           
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                             
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                     
                                      if (a == 'Easaraph') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                           
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                           
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                     
                                     if (a == 'Kamboola') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                              buf2 += "<a id=planets_" + i + " runat='server'   value ="+ (exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in ITHASALA and  "
                                            
                                          //   buf2 += "<input type='hidden' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['PLANET']) + "> are in ITHASALA and "
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + ">"
                                             


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                             buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                              buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in ITHASALA and  "
                                            
                                           
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + ">"
                                            


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                     
                                     if (a == 'Gary Kambool Yoga') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                              buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in Ithasaal and Moon is Forming  "
                                          
                                         //    buf2 += "<input type='hidden' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['PLANET']) + "> are in Ithasaal and Moon is Forming "
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + ">  "
                                           
                                             
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                              buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in Ithasaal and Moon is Forming  "
                                          
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + ">  "
                                             
                                            
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                     
                                     
                                     if (a == 'Nakta Yoga') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             
                                               buf2 += "<font width='90px'>" + ((i + 1 + '.    ') + exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> and establishes Ithasaal between "

                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and " 
                                              buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" 
                                          

                                             buf2 += "</td>"
                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             
                                                
                                            buf2 += "<font width='90px'>" + ((i + 1 + '.    ') + exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> and establishes Ithasaal between "

                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                              buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" 
                                          
                                             buf2 += "</td>"

                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                     
                                     
                                     if (a == 'Yamya Yoga') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ') + exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                             buf2 += "<input type='hidden' id=planets_" + i + "  value =" + exec_data.Tables[0].Rows[i]['ITHASALA'] + "> and establishes Ithasaal between "


                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                              buf2 += "<a id=planets_" + i + " runat='server'   value ="+ (exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" 
                                          
                                             buf2 += "</td>"

                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                              buf2 += "<font width='90px'>" + ((i + 1 + '.    ') + exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> and establishes Ithasaal between "


                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                              buf2 += "<a id=planets_" + i + " runat='server'   value ="+ (exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" 
                                          
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                     
                                     if (a == 'Kayra Siddhi') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"

                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                              buf2 += "<a id=planets_" + i + " runat='server'   value ="+ (exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" +" are in "
                                          
                                          
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                          
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ') )+ "</font>"

                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                          
                                          
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                     
                                     if (a == 'Manau') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"

                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                              buf2 += "<a id=planets_" + i + " runat='server'   value ="+ (exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " appears to be in "
                                          
                                          
                                            // buf2 += "<input type='hidden' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['PLANET']) + "> appears to be in "
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                           
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "> but Manau is formed thus Cancelling Ithasaal "
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                           buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"

                                          buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                            buf2 += "<a id=planets_" + i + " runat='server'   value ="+ (exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " appears to be in "
                                          
                                          
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">  but Manau is formed thus Cancelling Ithasaal "
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                     
                                     if (a == 'Radda') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"

                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "> but get Radda thus No ITHASALA   "
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                           
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"

                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                           
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "> but get Radda thus No ITHASALA   "
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                     
                                     if (a == 'IKKAVAL YOGA') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                           
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                           
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"

                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                           
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                             
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                      if (a == 'INDUVAR YOGA') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                      
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"

                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                           
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"

                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                           
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
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
        
    

        else {
            menuitemsvalus = document.getElementById('menuitsmcvalue').value;
            alert(" No Horary Yoga is formed for the Query Option ")
        }
    
}





//------vishu-----//

    function callback_othergrid(res) {
       
       var drop = document.getElementById('Hdrop1').value;
      
        document.getElementById('img1').style.display = 'none';
        record_show = 10
        record_show1 = 1
        var gg4 = 0;
        exec_data = res.value;
        var i = 0
        var b = "";
        var a ="";
        var flag = '0';
        var s = '0';
        var c;
        var d=0;
        if (exec_data.Tables[0].Rows.length > 0) {
            document.getElementById('img1').style.display = 'none';
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

            if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:100%;display:block") <= 0) {
                aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
            }
            buf2 = "";
            buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='100%' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
            


            len = 1;

           
            if (exec_data.Tables[0].Rows.length > 0) {
                for (i = 0; i < exec_data.Tables[0].Rows.length;++i) {
                   

                   



                        if (a != exec_data.Tables[0].Rows[i]['TYPE']) {
                            flag = '0';
                            a = exec_data.Tables[0].Rows[i]['TYPE'];
                        }
                                     if (a == 'Poorna') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a+"/Full Ithasaal" + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ') )+ "</font>"
                                             //    buf2 += "<input type='hidden'  id=planets_" + i + " runat='server' value =" + "<a onclick='javascript:open_div_button(id);'  >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                                                                      
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                             
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"
                                             //  buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE'])

                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                                                                      
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                    

                                            if (a == 'Applying') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                                                                      
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                                                                      
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                           
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                    
                                 
  if (a == 'Friendly Ithasaal') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                                                                      
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                           
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                                                                      
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                    
                                

                          if (a == 'Enemical Ithasaal') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                                                                       
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                        
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                                                                      
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                           
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                    

                        
                                        if (a == 'Bhavishyath') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                                                                      
                                            // buf2 += "<input type='hidden' id=planets_" + i + "  value =" + "<li><a onclick='javascript:open_div_button(id);' >"  + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a></li>" + " are in "
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> "
                                            
                                            
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                                                                      
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> "
                                           
                                            
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                     if (a == 'Rashiyant Ithasaal-Poorna/Full') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a+" Ithasaal" + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                          buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                           
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                           
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                      if (a == 'Applying Rashiyant') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                           
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                    
                                     if (a == 'Rashiyant') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                                                                      
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + ">  "
                                           
                                            
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                                                                      
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> "
                                            
                                           
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                     
                                      if (a == 'Easaraph') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                                                                      
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                             
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                                                                      
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                     
                                     if (a == 'Kamboola') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                              buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in ITHASALA and  "
                                                                                      
                                             //buf2 += "<input type='hidden' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['PLANET']) + "> are in ITHASALA and "
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + ">"
                                           
                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                              buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in ITHASALA and  "
                                                          
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + ">"
                                         
                                            


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                     
                                      if (a == 'Gary Kambool Yoga') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                              buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in Ithasaal and Moon is Forming  "
                                                       
                                            // buf2 += "<input type='hidden' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['PLANET']) + "> are in Ithasaal and Moon is Forming "
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + ">  "
                                           
                                             
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                              buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in Ithasaal and Moon is Forming  "
                                                     
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> "
                                             
                                           
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                     
                                     
                                     if (a == 'Nakta Yoga') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             
                                               buf2 += "<font width='90px'>" + ((i + 1 + '.    '+'Ithasaal between '))  + "</font>"


                                              buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                                buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " through Nakta Yoga  "
                                               buf2 += "</td>" 
                                          
                                           
                                           //  buf2 += "<input type='hidden' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['PLANET']) + "> through Nakta Yoga"
                                          
                                          

                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             
                                                
                                            buf2 += "<font width='90px'>" + ((i + 1 + '.    '+'Ithasaal between ') ) + "</font>"


                                           buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " through Nakta Yoga  "
                                                     
                                            buf2 += "</td>"
                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                     
                                     
                                     if (a == 'Yamya Yoga') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    '+'Ithasaal between ') ) + "</font>"


                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                              buf2 += "<a id=planets_" + i + " runat='server'   value ="+ (exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " through Yamya Yoga  "
                                             buf2 += "</td>"     
                                          //   buf2 += "<input type='hidden' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['PLANET']) + "> through Yamya Yoga  "
                                          
                                          
                                          

                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                              buf2 += "<font width='90px'>" + ((i + 1 + '.    '+'Ithasaal between ') ) + "</font>"

                                             buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                               buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " through Yamya Yoga  "
                                              buf2 += "</td>"     

                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                     
                                     if (a == 'Kayra Siddhi') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                           
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                         
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                     
                                     if (a == 'Manau') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                              buf2 += "<a id=planets_" + i + " runat='server'   value ="+ (exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " appears to be in "
                                          
                                           
                                 
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> but Manau is formed thus Cancelling Ithasaal "
                                          
                                            
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                              buf2 += "<a id=planets_" + i + " runat='server'   value ="+ (exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " appears to be in "
                                          
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> but Manau is formed thus Cancelling Ithasaal "
                                         
                                            
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                     
                                     if (a == 'Radda') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> but get Radda thus No ITHASALA   "
                                           
                                            
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> but get Radda thus No ITHASALA "
                                            
                                             
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                     
                                     if (a == 'IKKAVAL YOGA') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                      if (a == 'INDUVAR YOGA') {
                                         if (flag == '0') {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='colum-td-head'>" + "Yoga Type : " + a + "</td>"
                                             buf2 += "</tr>"
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                          
                                           buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                           
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                             flag = '1';
                                             s = '1';
                                           

                                         }


                                         else {
                                             buf2 += "<tr>"
                                             buf2 += "<td  class='new_grid' >"
                                             buf2 += "<font width='90px'>" + ((i + 1 + '.    ')) + "</font>"
                                            buf2 += "<a id=lord_" + i + " runat='server'  value =" + (exec_data.Tables[0].Rows[i]['LORD']) + " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['LORD']) + "</a>" + " and "
                                             buf2 += "<a id=planets_" + i + " runat='server'   value =" +(exec_data.Tables[0].Rows[i]['PLANET']) +  " onclick='javascript:open_div_button(id);' style='cursor:pointer;' >" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</a>" + " are in "
                                          
                                            buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "</font>"
                                            buf2 += "<input type='hidden' id=itc_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['ITHASALA']) + "> with a degree difference of  "
                                            
                                             buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                                           buf2 += "<input type='hidden' id=deg_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
                                             buf2 += "</td>"


                                             buf2 += "</tr>"
                                           
                                         }
                                     }
                                     
                                    
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
        
    

        else {
            menuitemsvalus = document.getElementById('menuitsmcvalue').value;


            alert(" No Horary Yoga is formed for the Query Option ")
        }
    
}



function karyasiddhi() {
    if (document.getElementById('Divgrid1').style.display = 'block') {
        document.getElementById('Divgrid1').style.display = 'none'
    
    }
    var asendrashi = "";
    document.getElementById('img1').style.display = 'block';
   
    
    var suninhouse = document.getElementById('Hsuninhouse').value;
    var mooninhouse = document.getElementById('Hmooninhouse').value;
    var marsinhouse = document.getElementById('Hmarsinhouse').value;
    var mrecinhouse = document.getElementById('Hmrecinhouse').value;
    var jupinhouse = document.getElementById('Hjupinhouse').value;
    var venusinhouse = document.getElementById('Hvenusinhouse').value;
    var saturninhouse = document.getElementById('Hsaturninhouse').value;
    var houselord = document.getElementById('hd').value;
    var lagnarashi = document.getElementById('Hasendrashi').value;
    var housewithtill = suninhouse + "~" + mooninhouse + "~" + marsinhouse + "~" + mrecinhouse + "~" + jupinhouse + "~" + venusinhouse + "~" + saturninhouse + "~";
   
    if (document.getElementById('Radio1').checked == true) {
        asendrashi = document.getElementById('Hasendrashi').value;        
        }

        if (document.getElementById('r1').checked == true) {
        asendrashi="MOON"
    }

    var res = yogas.karya_sidhi(asendrashi, houselord, housewithtill, lagnarashi,callback_gridkayra);
   
    return false;
}


function callback_gridkayra(res) {
    document.getElementById('img1').style.display = 'none';
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
    exec_data = res.value;
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

        if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:100%;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='100%' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td  class='colum-td-head'>" +"Karya Siddhi Yoga" +"</td>"
//        buf2 += "<td  bgcolor= #65b6fc style='height:10px;box-shadow: 2px 2px 5px #000;-webkit-box-shadow: 2px 2px 5px #000;box-shadow: 2px 2px 5px #000;font-weight:600; text-decoration:none;border:2px solid;width:300px;font-size:12px;font-weight:bold;text-align:left;border:1px  solid  #ffffff;color:white;'>" + "PLANET" + "</td>"
//        buf2 += "<td  bgcolor= #65b6fc style='height:10px;box-shadow: 2px 2px 5px #000;-webkit-box-shadow: 2px 2px 5px #000;box-shadow: 2px 2px 5px #000;font-weight:600; text-decoration:none;border:2px solid;width:200px;font-size:12px;font-weight:bold;text-align:left;border:1px solid #ffffff; color:white;'>" + "YOGA" + "</td>"
        buf2 += "</tr>"



        len = 1;


        if (exec_data.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"



                buf2 += "<td  class='new_grid' >"
                buf2 += "<font width='90px'>" + ((i+1+'.    ')+exec_data.Tables[0].Rows[i]['LAGANA_LORD']) + "</font>"
                buf2 += "<input type='hidden' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['LAGANA_LORD']) + "> has "
//                buf2 += "</td>"

//                buf2 += "<td  class='new_grid'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['KARYA_YOGA']) + "</font>"
                buf2 += "<input type='hidden' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['KARYA_YOGA']) + "> with "
//                buf2 += "</td>"

//                buf2 += "<td   class='new_grid' >"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['KARYA_LORD']) + "</font>"
                buf2 += "<input type='hidden' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['KARYA_LORD']) + ">"
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
    else {
        alert(" No Horary Yoga is formed for the Query Option ")
    }
 
}


function naktafun() {
    document.getElementById('naktadiv').style.display = 'block';
  document.getElementById('newhiddiv').style.display='none';
  
   return false;
}


function karyafun() {
    document.getElementById('newhiddiv').style.display = 'block';
   document.getElementById('naktadiv').style.display='none';
    return false;
}





function naktayogaitc() {
    var drop = document.getElementById('Hdrop1').value;
    document.getElementById('img1').style.display = 'block';
    var lagnarashi = document.getElementById('Hlagnarashi').value;
    var degree = document.getElementById('Hdegree').value;
    var house = document.getElementById('Hhouse').value;
    var lordhouse = document.getElementById('naktadrop').value;
    var newdegree = document.getElementById('Hdegreesecond').value;
    
    if (drop == 'Nakta Yoga') {
        var res = yogas.datra_nakta(lagnarashi, degree, house, lordhouse, newdegree, callback_gridkayra);
    }
    else {
       
    var res = yogas.datra_yamya(lagnarashi, degree, house, lordhouse, newdegree, callback_gridkayra) }
   

    return false;
}

function open_div_button(id_var) {
    var spl1 = id_var.split("_");
    var spl2 = spl1[1];
    var panethouse = "";
    document.getElementById('clinetnamediv').style.display = 'none';
    panethouse = document.getElementById(id_var).innerHTML;
//    panethouse = exec_data.Tables[0].Rows[spl2]['LORD'];
//    if (panethouse == "") {
//        panethouse = exec_data.Tables[0].Rows[spl2]['PLANET'];
//    }
    var planet_house = panethouse.split("(");
    var planet_spl = planet_house[0];
    var spl_house = planet_house[1].split(")");
    var spl_house_spl = spl_house[0];
    var spl_house1 = spl_house_spl.slice(6);
    spl_house1 = spl_house1.slice(2);
   
    var house_split = spl_house1.split("and");

    var house1 = house_split[0];
//    house1 = trim(house1)
    var house2 = "";
    house2 = house_split[1];
//    house2 = trim(house2);

     if (house2 == undefined) {
        house2 = "";
    
    }

    document.getElementById('clinetnamediv').style.display = 'block';
    document.getElementById('planet_link').innerHTML = planet_spl;
    document.getElementById('house1_link').innerHTML = house1;
    document.getElementById('house2_link').innerHTML = house2;
    
}



function creossdiv() {
    document.getElementById('clinetnamediv').style.display = 'none';
    document.getElementById('hdsviewgrid3').innerHTML = "";
    return false;
}



function showshignificator() {
    var datafortable = "";
    datafortable = document.getElementById('planet_link').innerHTML;


    var res = yogas.bindgirdfor(datafortable, callback_gridkayra1);
    

}
function showshignificator_house() {
    var datafortable = "";
    datafortable = trim(document.getElementById('house1_link').innerHTML)
    document.getElementById('hdsviewgrid3').innerHTML = "";
    var res = yogas.bindgirdfor(datafortable, callback_gridkayra1);

}

function showshignificator_house2() {
    var datafortable = "";
    datafortable = trim(document.getElementById('house2_link').innerHTML)
    document.getElementById('hdsviewgrid3').innerHTML = "";
   
    var res = yogas.bindgirdfor(datafortable, callback_gridkayra1);

}
function trim(val) {
    val.replace(/^\s+|\s+$/g,'');
   return val;
}

function callback_gridkayra1(res) {
  document.getElementById('img1').style.display = 'none';
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
    exec_data = res.value;
    var i = 0

    if (exec_data.Tables[0].Rows.length > 0) {

       
        document.getElementById('hdsviewgrid3').innerHTML = "";
        document.getElementById('Divgrid3').style.display = 'block';
        document.getElementById('Divgrid3').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('hdsviewgrid3').style.display = "block";

        if (document.getElementById("hdsviewgrid3").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("Divgrid3").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("hdsviewgrid3").innerHTML.indexOf("width:500px;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid3").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='Divgrid3' runat='server' align='left' Width='500px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
//        buf2 += "<td  class='colum-td-head'  style=' text-align: center;'>" + "SIGNIFICATOR" + "</td>"
//        
//        buf2 += "<td  class='colum-td-head'>" + "."+"</td>"
       
        buf2 += "</tr>"



        len = 1;


        if (exec_data.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"



                buf2 += "<td  class='new_grid' >"
                buf2 += "<font width='90px'>" + ((i + 1 + '.    ') + exec_data.Tables[0].Rows[i]['SIGNIFICATOR']) + "</font>"
                buf2 += "<input type='hidden' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['SIGNIFICATOR']) + "> "
                 buf2 += "</td>"
                 if (exec_data.Tables[0].Rows[i]['PLANET']==null)
                  {
                  }
                 else
                 {
                   buf2 += "<td  class='new_grid'>"
                buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</font>"
                buf2 += "<input type='hidden' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['PLANET']) + ">  "
                buf2 += "</td>"
                 }

                 if (exec_data.Tables[0].Rows[i]['RASHI'] == null) {
                 }
                 else{
                     buf2 += "<td  class='new_grid'>"
                     buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['RASHI']) + "</font>"
                     buf2 += "<input type='hidden' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['RASHI']) + ">  "
                     buf2 += "</td>"
                 }

                 if (exec_data.Tables[0].Rows[i]['HOUSE'] == null) {
                 }
                 else
                 {
                     buf2 += "<td  class='new_grid'>"
                     buf2 += "<font width='90px'>" + (exec_data.Tables[0].Rows[i]['HOUSE']) + "</font>"
                     buf2 += "<input type='hidden' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['HOUSE']) + ">  "
                     buf2 += "</td>"
                 }
              



                buf2 += "</tr>"

            }
        }
        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('hdsviewgrid3').innerHTML = temp_del1;
        return false;

    }
    else {
        alert('no data')
        return false;
    }

}



function cross_signi() {
    document.getElementById('Divgrid3').style.display = 'none';
    return false;
}

    function vargaschart11() {
document.getElementById('vargasdiv').style.display="block";
document.getElementById('Div2').style.display="none";
document.getElementById('Div3').style.display="none";

var vargas=document.getElementById('Hiddenva').value;
var res = yogas.vargasvalue(vargas);
callback_vargas(res);
showvargas();
return false;
}


function callback_vargas(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
     var vds= val.value;
     
    var i = 0

    if (vds.Tables[0].Rows.length > 0) {
        document.getElementById('dhdsviewgrid2').innerHTML = "";
        document.getElementById('Div2').style.display = 'block';
        document.getElementById('Div3').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('dhdsviewgrid2').style.display = "block";

        if (document.getElementById("dhdsviewgrid2").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("Div2").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("dhdsviewgrid2").innerHTML.indexOf("width:600;display:block") <= 0) {
            aa = document.getElementById("dhdsviewgrid2").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='Div2' runat='server' align='left' Width='600' height='0px' style='border:1px solid;border-color:#7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   class='colum-td-head'>" + "PLANET" + "</td>"
        buf2 += "<td   class='colum-td-head'>" + "D1_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head'>" + "D1_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "BIRTH_TIME" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "R" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "DEGREE" + "</td>"
                
        buf2 += "<td   class='colum-td-head>" + "D2_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D2_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D3_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D3_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D4_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D4_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D5_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D5_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D6_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D6_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D7_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D7_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D8_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D8_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D9_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D9_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D10_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head'>" + "D10_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D11_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D11_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D12_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D12_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D16_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D16_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D20_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D20_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D24_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D24_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D27_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D27_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D30_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D30_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D40_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D40_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D45_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D45_RASHI" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D60_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D60_RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head>" + "SHASHTYAMSHA_NAME" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "D60_NATURE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "KARAKAMSHA_HOUSE" + "</td>"
        buf2 += "<td   class='colum-td-head>" + "KARAKAMSHA_RASHI" + "</td>"
        buf2 += "</tr>"


        len = 1;


        if (vds.Tables[0].Rows.length > 0) {
            for (i = 0; i < vds.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"
//                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'> "
//                buf2 += "<label  style='width:90px; font-family:helvetica;' class='dropdown_large_corr'; align='left' Text='" + exec_data.Tables[0].Rows[i]['PLANET'] + "'  id=planets_" + i + " >"
//                buf2 += "</td>"
                
                
                 buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['PLANET']) + "</font>"
               buf2 +="<input type='hidden' id=planetsy_" + i + "  value =" + (vds.Tables[0].Rows[i]['PLANET'])+">"
              buf2 += "</td>"
                
                

                 buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D1_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D1_HOUSE'])+">"
              buf2 += "</td>"


                buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D1_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D1_RASHI'])+">"
              buf2 += "</td>"
              
               buf2 += "<td   style='width:150px;'class='dropdown_large_corr2'; align='left' >"
               buf2 += "<font width='150px'>" +(vds.Tables[0].Rows[i]['BIRTH_TIME']) + "</font>"
               buf2 +="<input type='hidden' id=birth_" + i + "  value =" + (vds.Tables[0].Rows[i]['BIRTH_TIME'])+">"
              buf2 += "</td>"
                
              buf2 += "<td class='colum-td-new1'>"
              if (vds.Tables[0].Rows[i]['RETRO'] == null) {
                  buf2 += "<font width='90px'></font>"
                  buf2 += "<input type='hidden' id=retrograde_" + i + " >"
                  buf2 += "</td>"

              }
              else {
                  buf2 += "<font width='90px'>" + (vds.Tables[0].Rows[i]['RETRO']) + "</font>"
                  buf2 += "<input type='hidden' id=retrograde_" + i + "  value =" + (vds.Tables[0].Rows[i]['RETRO']) + ">"
                  buf2 += "</td>"
              }


                 buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['DEGREE']) + "</font>"
               buf2 +="<input type='hidden' id=degree_" + i + "  value =" + (vds.Tables[0].Rows[i]['DEGREE'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D2_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d2house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D2_HOUSE'])+">"
              buf2 += "</td>"
              
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D2_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d2rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D2_RASHI'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D3_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d3house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D3_HOUSE'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D3_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d3rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D3_RASHI'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D4_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d4house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D4_HOUSE'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D4_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d4rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D4_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D5_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d5house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D5_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D5_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d5rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D5_RASHI'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D6_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d6house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D6_HOUSE'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D6_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d6rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D6_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D7_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d7house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D7_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D7_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d7rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D7_RASHI'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D8_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d8house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D8_HOUSE'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D8_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d8rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D8_RASHI'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D9_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d9house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D9_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D9_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d9rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D9_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D10_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d10house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D10_HOUSE'])+">"
              buf2 += "</td>"
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D10_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d10rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D10_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D11_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d11house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D11_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D11_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d11rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D11_RASHI'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D12_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d12house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D12_HOUSE'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D12_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d12rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D12_RASHI'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D16_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d16house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D16_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D16_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d16rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D16_RASHI'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D20_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d20house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D20_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D20_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d20rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D20_RASHI'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D24_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d24house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D24_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D24_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d24rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D24_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D27_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d27house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D27_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D27_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d27rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D27_RASHI'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D30_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d30house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D30_HOUSE'])+">"
              buf2 += "</td>"
                
                 buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D30_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d30rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D30_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D40_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d40house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D40_HOUSE'])+">"
              buf2 += "</td>"
                
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D40_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d40rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D40_RASHI'])+">"
              buf2 += "</td>"
                 
                 
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D45_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d45house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D45_HOUSE'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D45_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d45rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D45_RASHI'])+">"
              buf2 += "</td>"
                
                  buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D60_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=d60house_" + i + "  value =" + (vds.Tables[0].Rows[i]['D60_HOUSE'])+">"
              buf2 += "</td>"
                
                    buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D60_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=d60rashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['D60_RASHI'])+">"
              buf2 += "</td>"
                
               
                     buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['SHASHTYAMSHA_NAME']) + "</font>"
               buf2 +="<input type='hidden' id=d60shash_" + i + "  value =" + (vds.Tables[0].Rows[i]['SHASHTYAMSHA_NAME'])+">"
              buf2 += "</td>"
               
                
                     buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['D60_NATURE']) + "</font>"
               buf2 +="<input type='hidden' id=d60nature_" + i + "  value =" + (vds.Tables[0].Rows[i]['D60_NATURE'])+">"
              buf2 += "</td>"
               
                
                
               buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['KARAKAMSHA_HOUSE']) + "</font>"
               buf2 +="<input type='hidden' id=karkahouse_" + i + "  value =" + (vds.Tables[0].Rows[i]['KARAKAMSHA_HOUSE'])+">"
               buf2 += "</td>"
                   buf2 += "<td  class='colum-td-new1' >"
               buf2 += "<font width='90px'>" +(vds.Tables[0].Rows[i]['KARAKAMSHA_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=karkarashi_" + i + "  value =" + (vds.Tables[0].Rows[i]['KARAKAMSHA_RASHI'])+">"
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
        document.getElementById('dhdsviewgrid2').innerHTML = temp_del1;
        document.getElementById('vargaschart').style.display="block";
document.getElementById('labchart').style.display="block";
document.getElementById('Div2').style.display="none";



    }

    

}

function showvargas() {
    document.getElementById('vargasdiv').style.display = "block";


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
    var deg = "";
    var deg1 = "";
    var chartname = 'D01'

    document.getElementById('rashiid').style.display = "block";
    document.getElementById('vargaschart').value = 'D01'
    if (document.getElementById('vargaschart').value == 'D01')
    {


      
        for (var i = 1; i < 11; i++) {
            document.getElementById('Hidden8').value = i;

            var h = document.getElementById('house_' + i).value
            var r = document.getElementById('rashi_' + 0).value


            if (document.getElementById('retrograde_' + i).value == "0" || document.getElementById('retrograde_' + i).value == "B") {
                document.getElementById('retrograde_' + i).innerHTML = "";
                document.getElementById('retrograde_' + i).value="";
            }


            if (h == 'HOUSE1') {

                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planetsy_' + i).value == 'MERCURY') {
                    j1 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'JUPITER') {
                    j1 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'VENUS') {
                    j1 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SATURN') {
                    j1 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SUN') {
                    j1 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MOON') {
                    j1 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MARS') {
                    j1 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'RAHU') {
                    j1 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planetsy_' + i).value == 'KETU') {
                    j1 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'GULIKA') {
                    j1 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                h1 = h1 + j1 + " ";


            }
            if (h == 'HOUSE2') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planetsy_' + i).value == 'MERCURY') {
                    j2 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'JUPITER') {
                    j2 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'VENUS') {
                    j2 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SATURN') {
                    j2 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SUN') {
                    j2 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MOON') {
                    j2 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MARS') {
                    j2 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'RAHU') {
                    j2 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planetsy_' + i).value == 'KETU') {
                    j2 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }


                if (document.getElementById('planetsy_' + i).value == 'GULIKA') {
                    j2 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                h2 = h2 + j2 + " ";


            }

            if (h == 'HOUSE3') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planetsy_' + i).value == 'MERCURY') {
                    j3 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'JUPITER') {
                    j3 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'VENUS') {
                    j3 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SATURN') {
                    j3 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SUN') {
                    j3 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MOON') {
                    j3 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MARS') {
                    j3 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'RAHU') {
                    j3 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planetsy_' + i).value == 'KETU') {
                    j3 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planetsy_' + i).value == 'GULIKA') {
                    j3 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                h3 = h3 + j3 + " ";


            }


            if (h == 'HOUSE4') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planetsy_' + i).value == 'MERCURY') {
                    j4 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'JUPITER') {
                    j4 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'VENUS') {
                    j4 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SATURN') {
                    j4 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SUN') {
                    j4 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MOON') {
                    j4 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MARS') {
                    j4 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'RAHU') {
                    j4 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planetsy_' + i).value == 'KETU') {
                    j4 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planetsy_' + i).value == 'GULIKA') {
                    j4 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                h4 = h4 + j4 + " ";


            }

            if (h == 'HOUSE5') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planetsy_' + i).value == 'MERCURY') {
                    j5 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'JUPITER') {
                    j5 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'VENUS') {
                    j5 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SATURN') {
                    j5 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SUN') {
                    j5 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MOON') {
                    j5 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MARS') {
                    j5 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'RAHU') {
                    j5 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planetsy_' + i).value == 'KETU') {
                    j5 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planetsy_' + i).value == 'GULIKA') {
                    j5 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                h5 = h5 + j5 + " ";

            }

            if (h == 'HOUSE6') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planetsy_' + i).value == 'MERCURY') {
                    j6 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'JUPITER') {
                    j6 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'VENUS') {
                    j6 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SATURN') {
                    j6 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SUN') {
                    j6 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MOON') {
                    j6 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MARS') {
                    j6 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'RAHU') {
                    j6 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';

                }
                if (document.getElementById('planetsy_' + i).value == 'KETU') {
                    j6 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planetsy_' + i).value == 'GULIKA') {
                    j6 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                h6 = h6 + j6 + " ";


            }

            if (h == 'HOUSE7') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planetsy_' + i).value == 'MERCURY') {
                    j7 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'JUPITER') {
                    j7 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'VENUS') {
                    j7 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SATURN') {
                    j7 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SUN') {
                    j7 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MOON') {
                    j7 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MARS') {
                    j7 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'RAHU') {
                    j7 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planetsy_' + i).value == 'KETU') {
                    j7 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'GULIKA') {
                    j7 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                h7 = h7 + j7 + " ";


            }

            if (h == 'HOUSE8') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planetsy_' + i).value == 'MERCURY') {
                    j8 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'JUPITER') {
                    j8 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'VENUS') {
                    j8 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SATURN') {
                    j8 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SUN') {
                    j8 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MOON') {
                    j8 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MARS') {
                    j8 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'RAHU') {
                    j8 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planetsy_' + i).value == 'KETU') {
                    j8 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }


                if (document.getElementById('planetsy_' + i).value == 'GULIKA') {
                    j8 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                h8 = h8 + j8 + " ";


            }

            if (h == 'HOUSE9') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planetsy_' + i).value == 'MERCURY') {
                    j9 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'JUPITER') {
                    j9 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'VENUS') {
                    j9 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SATURN') {
                    j9 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SUN') {
                    j9 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MOON') {
                    j9 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MARS') {
                    j9 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'RAHU') {
                    j9 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planetsy_' + i).value == 'KETU') {
                    j9 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'GULIKA') {
                    j9 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                h9 = h9 + j9 + " ";


            }

            if (h == 'HOUSE10') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planetsy_' + i).value == 'MERCURY') {
                    j10 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'JUPITER') {
                    j10 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'VENUS') {
                    j10 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SATURN') {
                    j10 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SUN') {
                    j10 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MOON') {
                    j10 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MARS') {
                    j10 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'RAHU') {
                    j10 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planetsy_' + i).value == 'KETU') {
                    j10 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'GULIKA') {
                    j10 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                h10 = h10 + j10 + " ";


            }

            if (h == 'HOUSE11') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planetsy_' + i).value == 'MERCURY') {
                    j11 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'JUPITER') {
                    j11 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'VENUS') {
                    j11 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SATURN') {
                    j11 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SUN') {
                    j11 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MOON') {
                    j11 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MARS') {
                    j11 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'RAHU') {
                    j11 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planetsy_' + i).value == 'KETU') {
                    j11 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planetsy_' + i).value == 'GULIKA') {
                    j11 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }


                h11 = h11 + j11 + " ";

            }
            if (h == 'HOUSE12') {
                deg = document.getElementById('degree_' + i).value.split('.');
                deg1 = deg[0] + '.' + deg[1];
                if (document.getElementById('planetsy_' + i).value == 'MERCURY') {
                    j12 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'JUPITER') {
                    j12 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'VENUS') {
                    j12 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SATURN') {
                    j12 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'SUN') {
                    j12 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MOON') {
                    j12 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'MARS') {
                    j12 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'RAHU') {
                    j12 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }
                if (document.getElementById('planetsy_' + i).value == 'KETU') {
                    j12 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
                }

                if (document.getElementById('planetsy_' + i).value == 'GULIKA') {
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
        document.getElementById('h1l1').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>' + document.getElementById('degree_' + 0).value + '</span>';
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
        document.getElementById('h12r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r12 + '</span>' + '</br>';
        document.getElementById('h1r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r1 + '</span>' + '</br>';
        document.getElementById('h2r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r2 + '</span>' + '</br>';
        document.getElementById('h3r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r3 + '</span>' + '</br>';
        document.getElementById('h4r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r4 + '</span>' + '</br>';
        document.getElementById('h5r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r5 + '</span>' + '</br>';
        document.getElementById('h6r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r6 + '</span>' + '</br>';
        document.getElementById('h7r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r7 + '</span>' + '</br>';
        document.getElementById('h8r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r8 + '</span>' + '</br>';
        document.getElementById('h9r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r9 + '</span>' + '</br>';
        document.getElementById('h10r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r10 + '</span>' + '</br>';
        document.getElementById('h11r').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r11 + '</span>' + '</br>';

    }

   
    return false;
}


function calfhy()
{
    var drop1 = "Future Horary Yoga"
    var imonthob = document.getElementById('hdnimonthob').value
    var idateob = document.getElementById('hdnidateob').value
    var iyearob = document.getElementById('hdniyearob').value

    var ihourob = document.getElementById('hdnihourob').value
    var iminuteob = document.getElementById('hdniminuteob').value
    
    var dob = document.getElementById('hdndob').value
    var tob = document.getElementById('hdntob').value
    var tz = document.getElementById('hdntzo').value
    var tzval = document.getElementById('hdntzval').value
    var clientquery = document.getElementById('hdnquery').value;

    window.open('futureyogas.aspx?clmail=' + document.getElementById('hdnclientid').value + "&clname=" + document.getElementById('hdnclientname').value + "&astname=" + document.getElementById('astrologername').value + "&astmail=" + document.getElementById('astrologerid').value + "&lagnarashi=" + document.getElementById('Hlagnarashi').value + "&lagnadegree=" + document.getElementById('Hlagnadegree').value + "&degree=" + document.getElementById('Hdegree').value + "&house=" + document.getElementById('Hhouse').value + "&drop1=" + drop1 + "&degreesecond=" + document.getElementById('Hdegreesecond').value + "&moonrashi=" + document.getElementById('Hmoonrashi').value + "&sunhouse=" + document.getElementById('Hsunhouse').value + "&moonhouse=" + document.getElementById('Hmoonhouse').value + "&retro=" + document.getElementById('Hretro').value + "&rashie=" + document.getElementById('Hrashie').value + "&usermail=" + document.getElementById('hdnuser').value + "&v=" + document.getElementById('Hiddenva').value + "&idateob=" + idateob + "&imonthob=" + imonthob + "&iyearob=" + iyearob + "&ihourob=" + ihourob + "&iminuteob=" + iminuteob + "&longitude=" + document.getElementById('hdnlongit').value + "&latitude=" + document.getElementById('hdnlatit').value + "&dob=" + dob + "&tob=" + tob + "&tz=" + tz + "&tzval=" + tzval + "&query=" + clientquery + "");
    return false;
}

