

function vargas()
{
    getday(document.getElementById('hdnidateob').value + '/' + document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdniyearob').value);
var vargas=document.getElementById('Hiddencons').value;

transition.vargasvalue(vargas,callback_vargas);


      //Deepak Start Code Here
      var tob = document.getElementById('hdntob').value;
     var dob = document.getElementById('hdndob').value;
     var tz = document.getElementById('hdntzo').value;
     Cal_SunRiseSet_GulikaPageLoad(dob,tob,tz);
     //Deepak End Code Here


return false;
}


function callback_vargas(val) {
    record_show = 10
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

        if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:520;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='Divgrid1' runat='server' align='left' Width='150px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td  class='colum-td-head'>" + "PLANET" + "</td>"
        buf2 += "<td  class='colum-td-head' style='display:none;'>" + "HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "CONSTELATION" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "R" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "DEGREE" + "</td>"
        buf2 += "</tr>"


        len = 1;


        if (exec_data.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"
//                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'> "
//                buf2 += "<label  style='width:90px; font-family:helvetica;' class='dropdown_large_corr'; align='left' Text='" + exec_data.Tables[0].Rows[i]['PLANET'] + "'  id=planets_" + i + " >"
//                buf2 += "</td>"


                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='30px' class='Planets-font'>" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</font>"
               buf2 +="<input type='hidden' class='Planets-font' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['PLANET'])+">"
              buf2 += "</td>"
                
                

              buf2 += "<td class='colum-td-new1' style='display:none;'>"
               buf2 += "<font width='30px'>" +(exec_data.Tables[0].Rows[i]['D1_HOUSE']) + "</font>"
               buf2 += "<input type='hidden' class='Planets-font' id=house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D1_HOUSE']) + ">"
              buf2 += "</td>"

              buf2 += "<td class='colum-td-new1'>"
              buf2 += "<font width='30px'>" + (exec_data.Tables[0].Rows[i]['CONSTELATION']) + "</font>"
              buf2 += "<input type='hidden' class='Planets-font' id=cons_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['CONSTELATION']) + ">"
              buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='30px'>" +(exec_data.Tables[0].Rows[i]['D1_RASHI']) + "</font>"
               buf2 +="<input type='hidden' id=rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D1_RASHI'])+">"
              buf2 += "</td>"
              
        
               buf2 += "<td class='colum-td-new1'>"
               if (exec_data.Tables[0].Rows[i]['RETRO'] == null) {
                   buf2 += "<font width='30px'></font>"
                   buf2 += "<input type='hidden' id=retrograde_" + i + " >"
                   buf2 += "</td>"
                  
               }
               else {
                   buf2 += "<font width='30px'>" + (exec_data.Tables[0].Rows[i]['RETRO']) + "</font>"
                   buf2 += "<input type='hidden' id=retrograde_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['RETRO']) + ">"
                   buf2 += "</td>"
                 }
               
                
                 buf2 += "<td class='colum-td-new1'>"
               buf2 += "<font width='30px'>" +(exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
               buf2 +="<input type='hidden' id=degree_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE'])+">"
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

vargaschartd01();

}



function callback_vargast(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
    exec_data = val.value;
    var i = 0

    if (exec_data.Tables[0].Rows.length > 0) {
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

        if (document.getElementById("hdsviewgrid2").innerHTML.indexOf("width:520;display:block") <= 0) {
            aa = document.getElementById("hdsviewgrid2").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='Divgrid2' runat='server' align='left' Width='150px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td  class='colum-td-head'>" + "PLANET" + "</td>"
        buf2 += "<td  class='colum-td-head' style='display:none;'>" + "HOUSE" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "CONSTELATION" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "RASHI" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "R" + "</td>"
        buf2 += "<td  class='colum-td-head'>" + "DEGREE" + "</td>"
        buf2 += "</tr>"


        len = 1;


        if (exec_data.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"
                //                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'> "
                //                buf2 += "<label  style='width:90px; font-family:helvetica;' class='dropdown_large_corr'; align='left' Text='" + exec_data.Tables[0].Rows[i]['PLANET'] + "'  id=planets_" + i + " >"
                //                buf2 += "</td>"


                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='30px' class='Planets-font'>" + (exec_data.Tables[0].Rows[i]['PLANET']) + "</font>"
                buf2 += "<input type='hidden' class='Planets-font' id=planets_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['PLANET']) + ">"
                buf2 += "</td>"


                buf2 += "<td class='colum-td-new1' style='display:none;'>"
                buf2 += "<font width='30px'>" + (exec_data.Tables[0].Rows[i]['D1_HOUSE']) + "</font>"
                buf2 += "<input type='hidden' class='Planets-font' id=house_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D1_HOUSE']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1' >"
                buf2 += "<font width='30px'>" + (exec_data.Tables[0].Rows[i]['CONSTELATION']) + "</font>"
                buf2 += "<input type='hidden' class='Planets-font' id=cons_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['CONSTELATION']) + ">"
                buf2 += "</td>"

                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='30px'>" + (exec_data.Tables[0].Rows[i]['D1_RASHI']) + "</font>"
                buf2 += "<input type='hidden' id=rashi_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['D1_RASHI']) + ">"
                buf2 += "</td>"


                buf2 += "<td class='colum-td-new1'>"
                if (exec_data.Tables[0].Rows[i]['RETRO'] == 'B') {
                    buf2 += "<font width='30px'></font>"
                    buf2 += "<input type='hidden' id=retrograde_" + i + " >"
                    buf2 += "</td>"

                }
                else {
                    buf2 += "<font width='30px'>" + (exec_data.Tables[0].Rows[i]['RETRO']) + "</font>"
                    buf2 += "<input type='hidden' id=retrograde_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['RETRO']) + ">"
                    buf2 += "</td>"
                }

                //if (exec_data.Tables[0].Rows[i]['RETRO'] == 'R') {

                //    buf2 += "<font width='30px'>" + (exec_data.Tables[0].Rows[i]['RETRO']) + "</font>"
                //    buf2 += "<input type='hidden' id=retrograde_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['RETRO']) + ">"
                //    buf2 += "</td>"
                //}
                //else {
                //    buf2 += "<font width='30px'></font>"
                //    buf2 += "<input type='hidden' id=retrograde_" + i + " >"
                //    buf2 += "</td>"
                //}


                buf2 += "<td class='colum-td-new1'>"
                buf2 += "<font width='30px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']) + "</font>"
                buf2 += "<input type='hidden' id=degree_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']) + ">"
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
        document.getElementById('hdsviewgrid2').innerHTML = temp_del1;



    }

    transitionfunc();

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
            
            if(document.getElementById('chart').value=='MOON')
            {
                var h = document.getElementById('moonhouse_' + i).value
                var r=document.getElementById('moonrashi_' + 0).value
            }
            
            if(document.getElementById('chart').value=='VENUS')
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
    
    return false;
}


function vargaschartd01() {
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

    document.getElementById('rashiidd01').style.display = "block";
   for (var i = 1; i < 11; i++) 
    {
        document.getElementById('Hidden5d01').value = i;
           
                var h = document.getElementById('house_' + i).value
                var r=document.getElementById('rashi_' + 0).value



                if (document.getElementById('retrograde_' + i).value == "0" || document.getElementById('retrograde_' + i).value == "B") {
                    document.getElementById('retrograde_' + i).innerHTML = "";
                }



                if (h == 'HOUSE1') {

                     deg = document.getElementById('degree_' + i).value.split('.');
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
                     deg = document.getElementById('degree_' + i).value.split('.');
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
                     deg = document.getElementById('degree_' + i).value.split('.');
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
                     deg = document.getElementById('degree_' + i).value.split('.');
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
                     deg = document.getElementById('degree_' + i).value.split('.');
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
                     deg = document.getElementById('degree_' + i).value.split('.');
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
                     deg = document.getElementById('degree_' + i).value.split('.');
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
                     deg = document.getElementById('degree_' + i).value.split('.');
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
                     deg = document.getElementById('degree_' + i).value.split('.');
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
                     deg = document.getElementById('degree_' + i).value.split('.');
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
                     deg = document.getElementById('degree_' + i).value.split('.');
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
                    deg = document.getElementById('degree_' + i).value.split('.');
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
    

document.getElementById('h12rd01t').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r12 + '</span>' + '</br>';
document.getElementById('h1rd01t').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r1 + '</span>' + '</br>';
document.getElementById('h2rd01t').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r2 + '</span>' + '</br>';
document.getElementById('h3rd01t').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r3 + '</span>' + '</br>';
document.getElementById('h4rd01t').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r4 + '</span>' + '</br>';
document.getElementById('h5rd01t').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r5 + '</span>' + '</br>';
document.getElementById('h6rd01t').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r6 + '</span>' + '</br>';
document.getElementById('h7rd01t').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r7 + '</span>' + '</br>';
document.getElementById('h8rd01t').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r8 + '</span>' + '</br>';
document.getElementById('h9rd01t').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r9 + '</span>' + '</br>';
document.getElementById('h10rd01t').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r10 + '</span>' + '</br>';
document.getElementById('h11rd01t').innerHTML = '<br>' + '<span style="color: rgb(15, 22, 170); font-size: 15px;">' + r11 + '</span>' + '</br>';

    document.getElementById('hdnr1').innerHTML=r1
    document.getElementById('hdnr2').innerHTML=r2
    document.getElementById('hdnr3').innerHTML=r3
    document.getElementById('hdnr4').innerHTML=r4
    document.getElementById('hdnr5').innerHTML=r5
    document.getElementById('hdnr6').innerHTML=r6
    document.getElementById('hdnr7').innerHTML=r7
    document.getElementById('hdnr8').innerHTML=r8
    document.getElementById('hdnr9').innerHTML=r9
    document.getElementById('hdnr10').innerHTML=r10
    document.getElementById('hdnr11').innerHTML=r11
    document.getElementById('hdnr12').innerHTML=r12
  

    var vargas1 = document.getElementById('Hiddencons').value;

    transition.vargasvalue1(vargas1, callback_vargast);
}


function transitionfunc() {
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

    document.getElementById('rashiidd01').style.display = "block";
    for (var i = 1; i < 11; i++) {
        document.getElementById('Hidden5d01').value = i;

        var h = document.getElementById('house_' + i).value
        var r = document.getElementById('rashi_' + 0).value


        if (document.getElementById('retrograde_' + i).value == "0" || document.getElementById('retrograde_' + i).value == "B") {
            document.getElementById('retrograde_' + i).innerHTML = "";
        }



        if (h == 'HOUSE1') {

            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j1 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j1 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j1 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j1 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j1 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j1 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j1 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j1 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j1 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j1 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            h1 = h1 + j1 + " ";


        }
        if (h == 'HOUSE2') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j2 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j2 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j2 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j2 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j2 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j2 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j2 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j2 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j2 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }


            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j2 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            h2 = h2 + j2 + " ";


        }

        if (h == 'HOUSE3') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j3 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j3 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j3 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j3 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j3 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j3 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j3 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j3 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j3 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j3 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            h3 = h3 + j3 + " ";


        }


        if (h == 'HOUSE4') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j4 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j4 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j4 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j4 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j4 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j4 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j4 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j4 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j4 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j4 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            h4 = h4 + j4 + " ";


        }

        if (h == 'HOUSE5') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j5 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j5 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j5 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j5 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j5 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j5 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j5 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j5 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j5 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j5 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            h5 = h5 + j5 + " ";

        }

        if (h == 'HOUSE6') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j6 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j6 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j6 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j6 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j6 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j6 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j6 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j6 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';

            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j6 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j6 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            h6 = h6 + j6 + " ";


        }

        if (h == 'HOUSE7') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j7 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j7 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j7 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j7 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j7 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j7 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j7 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j7 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j7 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j7 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            h7 = h7 + j7 + " ";


        }

        if (h == 'HOUSE8') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j8 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j8 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j8 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j8 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j8 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j8 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j8 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j8 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j8 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j8 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            h8 = h8 + j8 + " ";


        }

        if (h == 'HOUSE9') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j9 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j9 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j9 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j9 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j9 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j9 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j9 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j9 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j9 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j9 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            h9 = h9 + j9 + " ";


        }

        if (h == 'HOUSE10') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j10 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j10 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j10 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j10 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j10 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j10 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j10 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j10 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j10 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j10 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            h10 = h10 + j10 + " ";


        }

        if (h == 'HOUSE11') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j11 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j11 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j11 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j11 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j11 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j11 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j11 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j11 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j11 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j11 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }


            h11 = h11 + j11 + " ";

        }
        if (h == 'HOUSE12') {
            deg = document.getElementById('degree_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planets_' + i).value == 'MERCURY') {
                j12 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'JUPITER') {
                j12 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'VENUS') {
                j12 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SATURN') {
                j12 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'SUN') {
                j12 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MOON') {
                j12 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'MARS') {
                j12 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'RAHU') {
                j12 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planets_' + i).value == 'KETU') {
                j12 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planets_' + i).value == 'GULIKA') {
                j12 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrograde_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
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
      

    if (r1 == document.getElementById('hdnr1').innerHTML)
    {
        document.getElementById('h1l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>'  + '</span>';
        document.getElementById('h2l1d01t').innerHTML = p2;
        document.getElementById('h3l1d01t').innerHTML = p3;
        document.getElementById('h4l1d01t').innerHTML = p4;
        document.getElementById('h5l1d01t').innerHTML = p5;
        document.getElementById('h6l1d01t').innerHTML = p6;
        document.getElementById('h7l1d01t').innerHTML = p7;
        document.getElementById('h8l1d01t').innerHTML = p8;
        document.getElementById('h9l1d01t').innerHTML = p9;
        document.getElementById('h10l1d01t').innerHTML = p10;
        document.getElementById('h11l1d01t').innerHTML = p11;
        document.getElementById('h12l1d01t').innerHTML = p12;
    }
    if (r1 == document.getElementById('hdnr2').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p12;
        document.getElementById('h2l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>' + '</span>';
        document.getElementById('h3l1d01t').innerHTML = p2; 
        document.getElementById('h4l1d01t').innerHTML = p3; 
        document.getElementById('h5l1d01t').innerHTML = p4; 
        document.getElementById('h6l1d01t').innerHTML = p5; 
        document.getElementById('h7l1d01t').innerHTML = p6; 
        document.getElementById('h8l1d01t').innerHTML = p7; 
        document.getElementById('h9l1d01t').innerHTML = p8;
        document.getElementById('h10l1d01t').innerHTML = p9; 
        document.getElementById('h11l1d01t').innerHTML = p10; 
        document.getElementById('h12l1d01t').innerHTML = p11; 
    }

    if (r1 == document.getElementById('hdnr3').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p11; 
        document.getElementById('h2l1d01t').innerHTML = p12;
        document.getElementById('h3l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>' +  '</span>';
        document.getElementById('h4l1d01t').innerHTML = p2; 
        document.getElementById('h5l1d01t').innerHTML = p3; 
        document.getElementById('h6l1d01t').innerHTML = p4; 
        document.getElementById('h7l1d01t').innerHTML = p5; 
        document.getElementById('h8l1d01t').innerHTML = p6; 
        document.getElementById('h9l1d01t').innerHTML = p7; 
        document.getElementById('h10l1d01t').innerHTML = p8; 
        document.getElementById('h11l1d01t').innerHTML = p9; 
        document.getElementById('h12l1d01t').innerHTML = p10; 
    }

    if (r1 == document.getElementById('hdnr4').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p10; 
        document.getElementById('h2l1d01t').innerHTML = p11; 
        document.getElementById('h3l1d01t').innerHTML = p12;
        document.getElementById('h4l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>'  + '</span>'; 
        document.getElementById('h5l1d01t').innerHTML = p2; 
        document.getElementById('h6l1d01t').innerHTML = p3; 
        document.getElementById('h7l1d01t').innerHTML = p4; 
        document.getElementById('h8l1d01t').innerHTML = p5; 
        document.getElementById('h9l1d01t').innerHTML = p6; 
        document.getElementById('h10l1d01t').innerHTML = p7; 
        document.getElementById('h11l1d01t').innerHTML = p8; 
        document.getElementById('h12l1d01t').innerHTML = p9; 
    }
    if (r1 == document.getElementById('hdnr5').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p9; 
        document.getElementById('h2l1d01t').innerHTML = p10; 
        document.getElementById('h3l1d01t').innerHTML = p11; 
        document.getElementById('h4l1d01t').innerHTML = p12;
        document.getElementById('h5l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>' + '</span>'; 
        document.getElementById('h6l1d01t').innerHTML = p2; 
        document.getElementById('h7l1d01t').innerHTML = p3; 
        document.getElementById('h8l1d01t').innerHTML = p4; 
        document.getElementById('h9l1d01t').innerHTML = p5; 
        document.getElementById('h10l1d01t').innerHTML = p6; 
        document.getElementById('h11l1d01t').innerHTML = p7; 
        document.getElementById('h12l1d01t').innerHTML = p8; 
    }

    if (r1 == document.getElementById('hdnr6').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p8; 
        document.getElementById('h2l1d01t').innerHTML = p9; 
        document.getElementById('h3l1d01t').innerHTML = p10; 
        document.getElementById('h4l1d01t').innerHTML = p11; 
        document.getElementById('h5l1d01t').innerHTML = p12;
        document.getElementById('h6l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>'+ '</span>';
        document.getElementById('h7l1d01t').innerHTML = p2; 
        document.getElementById('h8l1d01t').innerHTML = p3; 
        document.getElementById('h9l1d01t').innerHTML = p4; 
        document.getElementById('h10l1d01t').innerHTML = p5; 
        document.getElementById('h11l1d01t').innerHTML = p6; 
        document.getElementById('h12l1d01t').innerHTML = p7; 
    }
    if (r1 == document.getElementById('hdnr7').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p7; 
        document.getElementById('h2l1d01t').innerHTML = p8; 
        document.getElementById('h3l1d01t').innerHTML = p9; 
        document.getElementById('h4l1d01t').innerHTML = p10; 
        document.getElementById('h5l1d01t').innerHTML = p11; 
        document.getElementById('h6l1d01t').innerHTML = p12;
        document.getElementById('h7l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>'  + '</span>';
        document.getElementById('h8l1d01t').innerHTML = p2;
        document.getElementById('h9l1d01t').innerHTML = p3; 
        document.getElementById('h10l1d01t').innerHTML = p4; 
        document.getElementById('h11l1d01t').innerHTML = p5;
        document.getElementById('h12l1d01t').innerHTML = p6;
    }
    if (r1 == document.getElementById('hdnr8').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p6;
        document.getElementById('h2l1d01t').innerHTML = p7; 
        document.getElementById('h3l1d01t').innerHTML = p8;
        document.getElementById('h4l1d01t').innerHTML = p9; 
        document.getElementById('h5l1d01t').innerHTML = p10; 
        document.getElementById('h6l1d01t').innerHTML = p11; 
        document.getElementById('h7l1d01t').innerHTML = p12;
        document.getElementById('h8l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>' + '</span>';
        document.getElementById('h9l1d01t').innerHTML = p2;
        document.getElementById('h10l1d01t').innerHTML = p3;
        document.getElementById('h11l1d01t').innerHTML = p4; 
        document.getElementById('h12l1d01t').innerHTML = p5; 
    }

    if (r1 == document.getElementById('hdnr9').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p5;
        document.getElementById('h2l1d01t').innerHTML = p6;
        document.getElementById('h3l1d01t').innerHTML = p7;
        document.getElementById('h4l1d01t').innerHTML = p8;
        document.getElementById('h5l1d01t').innerHTML = p9; 
        document.getElementById('h6l1d01t').innerHTML = p10; 
        document.getElementById('h7l1d01t').innerHTML = p11;
        document.getElementById('h8l1d01t').innerHTML = p12; 
        document.getElementById('h9l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>' + '</span>'; 
        document.getElementById('h10l1d01t').innerHTML = p2; 
        document.getElementById('h11l1d01t').innerHTML = p3; 
        document.getElementById('h12l1d01t').innerHTML = p4; 
    }

    if (r1 == document.getElementById('hdnr10').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p4;
        document.getElementById('h2l1d01t').innerHTML = p5;
        document.getElementById('h3l1d01t').innerHTML = p6; 
        document.getElementById('h4l1d01t').innerHTML = p7; 
        document.getElementById('h5l1d01t').innerHTML = p8; 
        document.getElementById('h6l1d01t').innerHTML = p9; 
        document.getElementById('h7l1d01t').innerHTML = p10; 
        document.getElementById('h8l1d01t').innerHTML = p11; 
        document.getElementById('h9l1d01t').innerHTML = p12; 
        document.getElementById('h10l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>'  + '</span>';
        document.getElementById('h11l1d01t').innerHTML = p2; 
        document.getElementById('h12l1d01t').innerHTML = p3; 
    }

    if (r1 == document.getElementById('hdnr11').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p3;
        document.getElementById('h2l1d01t').innerHTML = p4; 
        document.getElementById('h3l1d01t').innerHTML = p5; 
        document.getElementById('h4l1d01t').innerHTML = p6; 
        document.getElementById('h5l1d01t').innerHTML = p7; 
        document.getElementById('h6l1d01t').innerHTML = p8; 
        document.getElementById('h7l1d01t').innerHTML = p9; 
        document.getElementById('h8l1d01t').innerHTML = p10; 
        document.getElementById('h9l1d01t').innerHTML = p11; 
        document.getElementById('h10l1d01t').innerHTML = p12; 
        document.getElementById('h11l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>' + '</span>'; 
        document.getElementById('h12l1d01t').innerHTML = p2; 
    }
    if (r1 == document.getElementById('hdnr12').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p2;
        document.getElementById('h2l1d01t').innerHTML = p3; 
        document.getElementById('h3l1d01t').innerHTML = p4;
        document.getElementById('h4l1d01t').innerHTML = p5;
        document.getElementById('h5l1d01t').innerHTML = p6; 
        document.getElementById('h6l1d01t').innerHTML = p7; 
        document.getElementById('h7l1d01t').innerHTML = p8; 
        document.getElementById('h8l1d01t').innerHTML = p9; 
        document.getElementById('h9l1d01t').innerHTML = p10; 
        document.getElementById('h10l1d01t').innerHTML = p11; 
        document.getElementById('h11l1d01t').innerHTML = p12; 
        document.getElementById('h12l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>'  + '</span>'; 
    }

   
}





function group_bind() {

    var astrologer = document.getElementById('astid').innerHTML;
    if (astrologer == 'astrology' || astrologer == 'ASTROLOGY' || astrologer == "") {
        // alert('you are admin');
        getopen("login.aspx");
        return false;
    }
    else {
        res = transition.searchuser(astrologer, document.getElementById('cat_grp').value);

        callback_drp1(res);
   
        return false
    }
    return false;
}



function hidediv() 
{
    d01 = ""
    d02 = ""
    d03 = ""
    d04 = ""
    d05 = ""
    d06 = ""
    d07 = ""
    d08 = ""
    d09 = ""
    d10 = ""
    d11 = ""
    d12 = ""
    d16 = ""
    d20 = ""
    d24 = ""
    d27 = ""
    d30 = ""
    d40 = ""
    d45 = ""
    d60 = ""
    kl = ""
    retro = ""

    for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {
        var planet = document.getElementById('planets_' + i).value;
        var house = document.getElementById('house_' + i).value;
        var rashi = document.getElementById('rashi_' + i).value;
        var degree = document.getElementById('degree_' + i).value;
        var birth = document.getElementById('birth_' + i).value;
        var cons = document.getElementById('cons_' + i).value;
        var d2house = document.getElementById('d2house_' + i).value;
        var d2rashi = document.getElementById('d2rashi_' + i).value;
        var d3house = document.getElementById('d3house_' + i).value;
        var d3rashi = document.getElementById('d3rashi_' + i).value;
        var d4house = document.getElementById('d4house_' + i).value;
        var d4rashi = document.getElementById('d4rashi_' + i).value;
        var d5house = document.getElementById('d5house_' + i).value;
        var d5rashi = document.getElementById('d5rashi_' + i).value;
        var d6house = document.getElementById('d6house_' + i).value;
        var d6rashi = document.getElementById('d6rashi_' + i).value;
        var d7house = document.getElementById('d7house_' + i).value;
        var d7rashi = document.getElementById('d7rashi_' + i).value;
        var d8house = document.getElementById('d8house_' + i).value;
        var d8rashi = document.getElementById('d8rashi_' + i).value;
        var d9house = document.getElementById('d9house_' + i).value;
        var d9rashi = document.getElementById('d9rashi_' + i).value;
        var d10house = document.getElementById('d10house_' + i).value;
        var d10rashi = document.getElementById('d10rashi_' + i).value;
        var d11house = document.getElementById('d11house_' + i).value;
        var d11rashi = document.getElementById('d11rashi_' + i).value;
        var d12house = document.getElementById('d12house_' + i).value;
        var d12rashi = document.getElementById('d12rashi_' + i).value;
        var d16house = document.getElementById('d16house_' + i).value;
        var d16rashi = document.getElementById('d16rashi_' + i).value;
        var d20house = document.getElementById('d20house_' + i).value;
        var d20rashi = document.getElementById('d20rashi_' + i).value;
        var d24house = document.getElementById('d24house_' + i).value;
        var d24rashi = document.getElementById('d24rashi_' + i).value;
        var d27house = document.getElementById('d27house_' + i).value;
        var d27rashi = document.getElementById('d27rashi_' + i).value;
        var d30house = document.getElementById('d30house_' + i).value;
        var d30rashi = document.getElementById('d30rashi_' + i).value;
        var d40house = document.getElementById('d40house_' + i).value;
        var d40rashi = document.getElementById('d40rashi_' + i).value;
        var d45house = document.getElementById('d45house_' + i).value;
        var d45rashi = document.getElementById('d45rashi_' + i).value;
        var d60house = document.getElementById('d60house_' + i).value;
        var d60rashi = document.getElementById('d60rashi_' + i).value;
        var klhouse = document.getElementById('karkahouse_' + i).value;
        var klrashi = document.getElementById('karkarashi_' + i).value;


        var d01 = d01 + document.getElementById('planets_' + i).value + "/" + document.getElementById('rashi_' + i).value + "/" + document.getElementById('house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + document.getElementById('retrograde_' + i).value + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"


        var d02 = d02 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d2rashi_' + i).value + "/" + document.getElementById('d2house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + document.getElementById('retrograde_' + i).value + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d03 = d03 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d3rashi_' + i).value + "/" + document.getElementById('d3house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + document.getElementById('retrograde_' + i).value + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d04 = d04 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d4rashi_' + i).value + "/" + document.getElementById('d4house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + document.getElementById('retrograde_' + i).value + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d05 = d05 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d5rashi_' + i).value + "/" + document.getElementById('d5house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + document.getElementById('retrograde_' + i).value + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d06 = d06 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d6rashi_' + i).value + "/" + document.getElementById('d6house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + document.getElementById('retrograde_' + i).value + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d07 = d07 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d7rashi_' + i).value + "/" + document.getElementById('d7house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + document.getElementById('retrograde_' + i).value + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d08 = d08 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d8rashi_' + i).value + "/" + document.getElementById('d8house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + document.getElementById('retrograde_' + i).value + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d09 = d09 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d9rashi_' + i).value + "/" + document.getElementById('d9house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + document.getElementById('retrograde_' + i).value + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d10 = d10 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d10rashi_' + i).value + "/" + document.getElementById('d10house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + document.getElementById('retrograde_' + i).value + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d11 = d11 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d11rashi_' + i).value + "/" + document.getElementById('d11house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + document.getElementById('retrograde_' + i).value + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d12 = d12 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d12rashi_' + i).value + "/" + document.getElementById('d12house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + document.getElementById('retrograde_' + i).value + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d16 = d16 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d16rashi_' + i).value + "/" + document.getElementById('d16house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + document.getElementById('retrograde_' + i).value + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d20 = d20 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d20rashi_' + i).value + "/" + document.getElementById('d20house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + document.getElementById('retrograde_' + i).value + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d24 = d24 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d24rashi_' + i).value + "/" + document.getElementById('d24house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + document.getElementById('retrograde_' + i).value + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d27 = d27 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d27rashi_' + i).value + "/" + document.getElementById('d27house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + document.getElementById('retrograde_' + i).value + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d30 = d30 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d30rashi_' + i).value + "/" + document.getElementById('d30house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + document.getElementById('retrograde_' + i).value + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d40 = d40 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d40rashi_' + i).value + "/" + document.getElementById('d40house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + document.getElementById('retrograde_' + i).value + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d45 = d45 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d45rashi_' + i).value + "/" + document.getElementById('d45house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + document.getElementById('retrograde_' + i).value + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var d60 = d60 + document.getElementById('planets_' + i).value + "/" + document.getElementById('d60rashi_' + i).value + "/" + document.getElementById('d60house_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + document.getElementById('retrograde_' + i).value + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"
        var kl = kl + document.getElementById('planets_' + i).value + "/" + document.getElementById('karkarashi_' + i).value + "/" + document.getElementById('karkahouse_' + i).value + "/" + document.getElementById('degree_' + i).value + "/" + document.getElementById('retrograde_' + i).value + "/" + exec_data.Tables[0].Rows[i]['CONSTELATION'] + "~"


    }

    var astname = document.getElementById('astname').innerHTML;
    var astid = document.getElementById('astid').innerHTML;

    var clientid = document.getElementById('clientnametextbox').value;
        if(client=="")
         {
             alert('Enter Name');
        return false;
        }
 var  client = document.getElementById('clientidtextbox').value;
            if(clientid=="") {
                alert('Enter Id');
        
        return false;
        }

            var dasha = document.getElementById('dasha').value;
            var group = document.getElementById('groupdrop').value;
            if (group == 0)
            {
                group= document.getElementById('groupdrop').options[document.getElementById('groupdrop').selectedIndex].text;
            }
            var groupcat = document.getElementById('cat_grp').options[document.getElementById('cat_grp').selectedIndex].text
            
            var res = transition.chechduplicacy(astid, astname, client, clientid, group, groupcat);

    // var res = transition.chechduplicacy(astid, astname, client, clientid, group);
    var ds = res.value;
    if (ds.Tables[0].Rows.length > 0) {
        alert('client Horoscope already saved');
        document.getElementById('clinetnamediv').style.display = 'none';
        document.getElementById('clientnametextbox').value="";
        document.getElementById('clientidtextbox').value="";
    }
    else {
      
        if (document.getElementById('cat_grp').selectedIndex == '0') {
            alert('Please select group category');
            return false;
        }
        

        transition.savecharts(d01, d02, d03, d04, d05, d06, d07, d08, d09, d10, d11, d12, d16, d20, d24, d27, d30, d40, d45, d60, kl, astid, astname, client, clientid, dasha, document.getElementById("hdndob").value, document.getElementById("hdntob").value, document.getElementById("hdncountry").value, document.getElementById("hdnstate").value, document.getElementById("hdndist").value, document.getElementById("hdncity").value, group, groupcat, document.getElementById("hdnprof").value, document.getElementById("hdnsex").value, document.getElementById("hdnmobile").value);
        alert(' save sucessfully')
        document.getElementById('clinetnamediv').style.display = 'none';
        document.getElementById('clientnametextbox').value = "";
        document.getElementById('clientidtextbox').value = "";
    }
    return false;

}


function creossdiv() {
    document.getElementById('clinetnamediv').style.display = 'none';
    return false;
}



 function callback_drp1(res) {
     var ds = res.value;
     var edtn = $("groupdrop");
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

 function soda() {
     document.getElementById('ttt').disabled = false;
     document.getElementById('sod').value = "Ok";
     var dtob = document.getElementById('ttt').value;
     var dtob1 = dtob.split(' ');
     var d=dtob1[0].split('-');
     var dob = d[1] + '/' + d[0] + '/' + d[2];
     var t = dtob1[1].split(':');
     var tob = t[0] + '.' + t[1];
    
     var tzon = "5.30";
     var flag = "add0min"
     getday(d[0] + '/' + d[1] + '/' + d[2]);
     var exec = transition.maketransition(dob, tob, flag);
     var ds = exec.value;

     daob = ds.Tables[0].Rows[0].IDOB.split(' ');
     document.getElementById('ttt').value = ds.Tables[0].Rows[0].IDOB;
     idaob = daob[0];
     itaob = daob[1];

     idaob1 = idaob.split('-');
     da1ob = idaob1[0];
     mo1ob = idaob1[1];
     yr1ob = idaob1[2];

     itaob1 = itaob.split(':');
     ihob = itaob1[0];
     imob = itaob1[1];

     var dob = mo1ob + '/' + da1ob + '/' + yr1ob;
     var tob = ihob + '.' + imob
     document.getElementById('hdnimonthob').value = mo1ob;
     document.getElementById('hdnidateob').value = da1ob;
     document.getElementById('hdniyearob').value = yr1ob;
     document.getElementById('hdnihourob').value = (ihob);
     document.getElementById('hdniminuteob').value = (imob);


     //var ObjFromDll = ActiveXObject("kundli4c.clskundli");
     //var anyResult = ObjFromDll.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById(hdnlongit).value),  parseFloat(document.getElementById(hdnlatit).value))
     var asc = transition.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById('hdnlongit').value), parseFloat(document.getElementById('hdnlatit').value));


     transition.makebirthchart(dob, tob, tzon, parseFloat(asc.value), callback_vargastaddmi);


     return false;
 }
 function getday(givenDate)
 {
     var givenDate = givenDate;
  
 weekDays=["Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"]  
 var dArray = givenDate.split("/");  
 // You have to write code that will check whether the date is valid or not because February cannot be 30 or 31, etc  
  
 // months in Javascript are 0-11  
 myDate=new Date(dArray[2],dArray[1]-1,dArray[0]);  
 var dayCode = myDate.getDay(); // dayCode 0-6  
 var dayIs=weekDays[dayCode]; //It will contain the required day, in this example it will be friday  
     //alert(dayIs);  
 wday.innerHTML = dayIs;
 }  

 function add1min()
 {
     var dob = document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdnidateob').value + '/' + document.getElementById('hdniyearob').value
     var tob = document.getElementById('hdnihourob').value + '.' + (document.getElementById('hdniminuteob').value);
     var tzon = "5.30";
     var flag = "add1min"
     getday(document.getElementById('hdnidateob').value +'/'+ document.getElementById('hdnimonthob').value +'/'+ document.getElementById('hdniyearob').value);
     var exec = transition.maketransition(dob, tob, flag);
     var ds = exec.value;
     
     daob = ds.Tables[0].Rows[0].IDOB.split(' ');
     document.getElementById('ttt').value = ds.Tables[0].Rows[0].IDOB;
     idaob = daob[0];
     itaob = daob[1];

     idaob1 = idaob.split('-');
     da1ob = idaob1[0];
     mo1ob = idaob1[1];
     yr1ob = idaob1[2];

     itaob1 = itaob.split(':');
     ihob = itaob1[0];
     imob = itaob1[1];

     var dob = mo1ob + '/' + da1ob + '/' + yr1ob;
     var tob = ihob + '.' + imob
     document.getElementById('hdnimonthob').value=mo1ob;
     document.getElementById('hdnidateob').value=da1ob;
     document.getElementById('hdniyearob').value=yr1ob;
     document.getElementById('hdnihourob').value=(ihob);
     document.getElementById('hdniminuteob').value=(imob);
     
     //Deepak Start Code Here
     document.getElementById('hdndob').value = da1ob + '/' + mo1ob + '/' + yr1ob;
     document.getElementById('hdntob').value = ihob + ':' + imob
     var tz = document.getElementById('hdntzo').value;
    var gul= Cal_SunRiseSet_Gulika(dob,document.getElementById('hdntob').value,tz);
     //Deepak End Code Here
     
   
     //var ObjFromDll = ActiveXObject("kundli4c.clskundli");
     //var anyResult = ObjFromDll.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById(hdnlongit).value),  parseFloat(document.getElementById(hdnlatit).value))
      var asc= transition.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById('hdnlongit').value),  parseFloat(document.getElementById('hdnlatit').value));
 
        
      transition.makebirthchart(dob, tob, tzon, parseFloat(asc.value), parseFloat(gul), callback_vargastaddmi);

     
     return false;
 }
 
 function minus1min()
 {
     var dob = document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdnidateob').value + '/' + document.getElementById('hdniyearob').value
     var tob = document.getElementById('hdnihourob').value + '.' + document.getElementById('hdniminuteob').value
     var tzon = "5.30";
     var flag = "minus1min"
     getday(document.getElementById('hdnidateob').value + '/' + document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdniyearob').value);
     var exec = transition.maketransition(dob, tob, flag);
     var ds = exec.value;

     daob = ds.Tables[0].Rows[0].IDOB.split(' ');
     document.getElementById('ttt').value = ds.Tables[0].Rows[0].IDOB;
     idaob = daob[0];
     itaob = daob[1];

     idaob1 = idaob.split('-');
     da1ob = idaob1[0];
     mo1ob = idaob1[1];
     yr1ob = idaob1[2];

     itaob1 = itaob.split(':');
     ihob = itaob1[0];
     imob = itaob1[1];

     var dob = mo1ob + '/' + da1ob + '/' + yr1ob;
     var tob = ihob + '.' + imob
     document.getElementById('hdnimonthob').value=mo1ob;
     document.getElementById('hdnidateob').value=da1ob;
     document.getElementById('hdniyearob').value=yr1ob;
     document.getElementById('hdnihourob').value=ihob;
     document.getElementById('hdniminuteob').value=imob;
     
     
     //Deepak Start Code Here
     document.getElementById('hdndob').value = da1ob + '/' + mo1ob + '/' + yr1ob;
     document.getElementById('hdntob').value = ihob + ':' + imob
     var tz = document.getElementById('hdntzo').value;
    var gul= Cal_SunRiseSet_Gulika(dob,document.getElementById('hdntob').value,tz);
     //Deepak End Code Here
     
   
     //var ObjFromDll = ActiveXObject("kundli4c.clskundli");
     //var anyResult = ObjFromDll.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById(hdnlongit).value),  parseFloat(document.getElementById(hdnlatit).value))
      var asc= transition.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById('hdnlongit').value),  parseFloat(document.getElementById('hdnlatit').value));
 
        
      transition.makebirthchart(dob, tob, tzon, parseFloat(asc.value), parseFloat(gul), callback_vargastaddmi);

     
     return false;
 }
 
 

 function add10min()
 {
     var dob = document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdnidateob').value + '/' + document.getElementById('hdniyearob').value
     var tob = document.getElementById('hdnihourob').value + '.' + document.getElementById('hdniminuteob').value
     var tzon = "5.30";
     var flag = "add10min"
     getday(document.getElementById('hdnidateob').value + '/' + document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdniyearob').value);
     var exec = transition.maketransition(dob, tob, flag);

     var ds = exec.value;

     daob = ds.Tables[0].Rows[0].IDOB.split(' ');
     document.getElementById('ttt').value = ds.Tables[0].Rows[0].IDOB;
     
     idaob = daob[0];
     itaob = daob[1];

     idaob1 = idaob.split('-');
     da1ob = idaob1[0];
     mo1ob = idaob1[1];
     yr1ob = idaob1[2];

     itaob1 = itaob.split(':');
     ihob = itaob1[0];
     imob = itaob1[1];

     var dob = mo1ob + '/' + da1ob + '/' + yr1ob;
     var tob = ihob + '.' + imob
     document.getElementById('hdnimonthob').value=mo1ob;
     document.getElementById('hdnidateob').value=da1ob;
     document.getElementById('hdniyearob').value=yr1ob;
     document.getElementById('hdnihourob').value=ihob;
     document.getElementById('hdniminuteob').value=imob;
     
     //Deepak Start Code Here
     document.getElementById('hdndob').value = da1ob + '/' + mo1ob + '/' + yr1ob;
     document.getElementById('hdntob').value = ihob + ':' + imob
     var tz = document.getElementById('hdntzo').value;
    var gul= Cal_SunRiseSet_Gulika(dob,document.getElementById('hdntob').value,tz);
     //Deepak End Code Here
     
   
     //var ObjFromDll = ActiveXObject("kundli4c.clskundli");
     //var anyResult = ObjFromDll.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById(hdnlongit).value),  parseFloat(document.getElementById(hdnlatit).value))
      var asc= transition.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById('hdnlongit').value),  parseFloat(document.getElementById('hdnlatit').value));
 
        
      transition.makebirthchart(dob, tob, tzon, parseFloat(asc.value), parseFloat(gul), callback_vargastaddmi);

     
     return false;
 }
 
 function minus10min()
 {
     var dob = document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdnidateob').value + '/' + document.getElementById('hdniyearob').value
     var tob = document.getElementById('hdnihourob').value + '.' + document.getElementById('hdniminuteob').value
     var tzon = "5.30";
     var flag = "minus10min"
     getday(document.getElementById('hdnidateob').value + '/' + document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdniyearob').value);
     var exec = transition.maketransition(dob, tob, flag);
     var ds = exec.value;

     daob = ds.Tables[0].Rows[0].IDOB.split(' ');
     document.getElementById('ttt').value = ds.Tables[0].Rows[0].IDOB;
     
     idaob = daob[0];
     itaob = daob[1];

     idaob1 = idaob.split('-');
     da1ob = idaob1[0];
     mo1ob = idaob1[1];
     yr1ob = idaob1[2];

     itaob1 = itaob.split(':');
     ihob = itaob1[0];
     imob = itaob1[1];

     var dob = mo1ob + '/' + da1ob + '/' + yr1ob;
     var tob = ihob + '.' + imob
     document.getElementById('hdnimonthob').value=mo1ob;
     document.getElementById('hdnidateob').value=da1ob;
     document.getElementById('hdniyearob').value=yr1ob;
     document.getElementById('hdnihourob').value=ihob;
     document.getElementById('hdniminuteob').value=imob;
     
     //Deepak Start Code Here
     document.getElementById('hdndob').value = da1ob + '/' + mo1ob + '/' + yr1ob;
    document.getElementById('hdntob').value = ihob + ':' + imob
     var tz = document.getElementById('hdntzo').value;
    var gul= Cal_SunRiseSet_Gulika(dob,document.getElementById('hdntob').value,tz);
     //Deepak End Code Here
     
   
     //var ObjFromDll = ActiveXObject("kundli4c.clskundli");
     //var anyResult = ObjFromDll.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById(hdnlongit).value),  parseFloat(document.getElementById(hdnlatit).value))
      var asc= transition.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById('hdnlongit').value),  parseFloat(document.getElementById('hdnlatit').value));
 
        
      transition.makebirthchart(dob, tob, tzon, parseFloat(asc.value), parseFloat(gul), callback_vargastaddmi);

     
     return false;
 }
 
 
 
 function add1hour()
 {
     var dob = document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdnidateob').value + '/' + document.getElementById('hdniyearob').value
     var tob = document.getElementById('hdnihourob').value + '.' + document.getElementById('hdniminuteob').value
     var tzon = "5.30";
     var flag = "add1hr"
     getday(document.getElementById('hdnidateob').value + '/' + document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdniyearob').value);
     var exec = transition.maketransition(dob, tob, flag);
     var ds = exec.value;

     daob = ds.Tables[0].Rows[0].IDOB.split(' ');
     document.getElementById('ttt').value = ds.Tables[0].Rows[0].IDOB;
     idaob = daob[0];
     itaob = daob[1];

     idaob1 = idaob.split('-');
     da1ob = idaob1[0];
     mo1ob = idaob1[1];
     yr1ob = idaob1[2];

     itaob1 = itaob.split(':');
     ihob = itaob1[0];
     imob = itaob1[1];

     var dob = mo1ob + '/' + da1ob + '/' + yr1ob;
     var tob = ihob + '.' + imob
     document.getElementById('hdnimonthob').value=mo1ob;
     document.getElementById('hdnidateob').value=da1ob;
     document.getElementById('hdniyearob').value=yr1ob;
     document.getElementById('hdnihourob').value=ihob;
     document.getElementById('hdniminuteob').value=imob;
     
     //Deepak Start Code Here
     document.getElementById('hdndob').value = da1ob + '/' + mo1ob + '/' + yr1ob;
     document.getElementById('hdntob').value = ihob + ':' + imob
     var tz = document.getElementById('hdntzo').value;
     var gul=Cal_SunRiseSet_Gulika(dob,document.getElementById('hdntob').value,tz);
     //Deepak End Code Here
     
   
     //var ObjFromDll = ActiveXObject("kundli4c.clskundli");
     //var anyResult = ObjFromDll.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById(hdnlongit).value),  parseFloat(document.getElementById(hdnlatit).value))
      var asc= transition.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById('hdnlongit').value),  parseFloat(document.getElementById('hdnlatit').value));
 
        
      transition.makebirthchart(dob, tob, tzon, parseFloat(asc.value), parseFloat(gul), callback_vargastaddmi);

     
     return false;
 }
 
 function minus1hour()
 {
     var dob = document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdnidateob').value + '/' + document.getElementById('hdniyearob').value
     var tob = document.getElementById('hdnihourob').value + '.' + document.getElementById('hdniminuteob').value
     var tzon = "5.30";
     var flag = "minus1hr"
     getday(document.getElementById('hdnidateob').value + '/' + document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdniyearob').value);
     var exec = transition.maketransition(dob, tob, flag);
     var ds = exec.value;

     daob = ds.Tables[0].Rows[0].IDOB.split(' ');
     document.getElementById('ttt').value = ds.Tables[0].Rows[0].IDOB;
     idaob = daob[0];
     itaob = daob[1];

     idaob1 = idaob.split('-');
     da1ob = idaob1[0];
     mo1ob = idaob1[1];
     yr1ob = idaob1[2];

     itaob1 = itaob.split(':');
     ihob = itaob1[0];
     imob = itaob1[1];

     var dob = mo1ob + '/' + da1ob + '/' + yr1ob;
     var tob = ihob + '.' + imob
     document.getElementById('hdnimonthob').value=mo1ob;
     document.getElementById('hdnidateob').value=da1ob;
     document.getElementById('hdniyearob').value=yr1ob;
     document.getElementById('hdnihourob').value=ihob;
     document.getElementById('hdniminuteob').value=imob;
     
     //Deepak Start Code Here
     document.getElementById('hdndob').value = da1ob + '/' + mo1ob + '/' + yr1ob;
     document.getElementById('hdntob').value = ihob + ':' + imob
     var tz = document.getElementById('hdntzo').value;
    var gul= Cal_SunRiseSet_Gulika(dob,document.getElementById('hdntob').value,tz);
     //Deepak End Code Here
   
     //var ObjFromDll = ActiveXObject("kundli4c.clskundli");
     //var anyResult = ObjFromDll.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById(hdnlongit).value),  parseFloat(document.getElementById(hdnlatit).value))
      var asc= transition.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById('hdnlongit').value),  parseFloat(document.getElementById('hdnlatit').value));
 
        
      transition.makebirthchart(dob, tob, tzon, parseFloat(asc.value), parseFloat(gul), callback_vargastaddmi);

     
     return false;
 }
 
 function minus10hour()
 {
     var dob = document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdnidateob').value + '/' + document.getElementById('hdniyearob').value
     var tob = document.getElementById('hdnihourob').value + '.' + document.getElementById('hdniminuteob').value
     var tzon = "5.30";
     var flag = "minus10hr"
     getday(document.getElementById('hdnidateob').value + '/' + document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdniyearob').value);
     var exec = transition.maketransition(dob, tob, flag);
     var ds = exec.value;

     daob = ds.Tables[0].Rows[0].IDOB.split(' ');
     document.getElementById('ttt').value = ds.Tables[0].Rows[0].IDOB;
     idaob = daob[0];
     itaob = daob[1];

     idaob1 = idaob.split('-');
     da1ob = idaob1[0];
     mo1ob = idaob1[1];
     yr1ob = idaob1[2];

     itaob1 = itaob.split(':');
     ihob = itaob1[0];
     imob = itaob1[1];

     var dob = mo1ob + '/' + da1ob + '/' + yr1ob;
     var tob = ihob + '.' + imob
     document.getElementById('hdnimonthob').value=mo1ob;
     document.getElementById('hdnidateob').value=da1ob;
     document.getElementById('hdniyearob').value=yr1ob;
     document.getElementById('hdnihourob').value=ihob;
     document.getElementById('hdniminuteob').value=imob;
     
     //Deepak Start Code Here
     document.getElementById('hdndob').value = da1ob + '/' + mo1ob + '/' + yr1ob;
     document.getElementById('hdntob').value = ihob + ':' + imob
     var tz = document.getElementById('hdntzo').value;
     var gul=Cal_SunRiseSet_Gulika(dob,document.getElementById('hdntob').value,tz);
     //Deepak End Code Here
     
   
     //var ObjFromDll = ActiveXObject("kundli4c.clskundli");
     //var anyResult = ObjFromDll.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById(hdnlongit).value),  parseFloat(document.getElementById(hdnlatit).value))
      var asc= transition.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById('hdnlongit').value),  parseFloat(document.getElementById('hdnlatit').value));
 
        
      transition.makebirthchart(dob, tob, tzon, parseFloat(asc.value), parseFloat(gul), callback_vargastaddmi);

     
     return false;
 }

 function add10hour()
 {
     var dob = document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdnidateob').value + '/' + document.getElementById('hdniyearob').value
     var tob = document.getElementById('hdnihourob').value + '.' + document.getElementById('hdniminuteob').value
     var tzon = "5.30";
     var flag = "add10hr"
     getday(document.getElementById('hdnidateob').value + '/' + document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdniyearob').value);
     var exec = transition.maketransition(dob, tob, flag);
     var ds = exec.value;

     daob = ds.Tables[0].Rows[0].IDOB.split(' ');
     document.getElementById('ttt').value = ds.Tables[0].Rows[0].IDOB;
     idaob = daob[0];
     itaob = daob[1];

     idaob1 = idaob.split('-');
     da1ob = idaob1[0];
     mo1ob = idaob1[1];
     yr1ob = idaob1[2];

     itaob1 = itaob.split(':');
     ihob = itaob1[0];
     imob = itaob1[1];

     var dob = mo1ob + '/' + da1ob + '/' + yr1ob;
     var tob = ihob + '.' + imob
     document.getElementById('hdnimonthob').value=mo1ob;
     document.getElementById('hdnidateob').value=da1ob;
     document.getElementById('hdniyearob').value=yr1ob;
     document.getElementById('hdnihourob').value=ihob;
     document.getElementById('hdniminuteob').value=imob;
     
     //Deepak Start Code Here
     document.getElementById('hdndob').value = da1ob + '/' + mo1ob + '/' + yr1ob;
     document.getElementById('hdntob').value = ihob + ':' + imob
     var tz = document.getElementById('hdntzo').value;
     var gul=Cal_SunRiseSet_Gulika(dob,document.getElementById('hdntob').value,tz);
     //Deepak End Code Here
   
     //var ObjFromDll = ActiveXObject("kundli4c.clskundli");
     //var anyResult = ObjFromDll.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById(hdnlongit).value),  parseFloat(document.getElementById(hdnlatit).value))
      var asc= transition.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById('hdnlongit').value),  parseFloat(document.getElementById('hdnlatit').value));
 
        
      transition.makebirthchart(dob, tob, tzon, parseFloat(asc.value), parseFloat(gul), callback_vargastaddmi);

     
     return false;
 }


 function minus1day()
 {
     var dob = document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdnidateob').value + '/' + document.getElementById('hdniyearob').value
     var tob = document.getElementById('hdnihourob').value + '.' + document.getElementById('hdniminuteob').value
     var tzon = "5.30";
     var flag = "minus1day"
     getday(document.getElementById('hdnidateob').value + '/' + document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdniyearob').value);
     var exec = transition.maketransition(dob, tob, flag);
     var ds = exec.value;

     daob = ds.Tables[0].Rows[0].IDOB.split(' ');
     document.getElementById('ttt').value = ds.Tables[0].Rows[0].IDOB;
     idaob = daob[0];
     itaob = daob[1];

     idaob1 = idaob.split('-');
     da1ob = idaob1[0];
     mo1ob = idaob1[1];
     yr1ob = idaob1[2];

     itaob1 = itaob.split(':');
     ihob = itaob1[0];
     imob = itaob1[1];

     var dob = mo1ob + '/' + da1ob + '/' + yr1ob;
     var tob = ihob + '.' + imob
     document.getElementById('hdnimonthob').value=mo1ob;
     document.getElementById('hdnidateob').value=da1ob;
     document.getElementById('hdniyearob').value=yr1ob;
     document.getElementById('hdnihourob').value=ihob;
     document.getElementById('hdniminuteob').value=imob;
     
      //Deepak Start Code Here
     document.getElementById('hdndob').value = da1ob + '/' + mo1ob + '/' + yr1ob;
     document.getElementById('hdntob').value = ihob + ':' + imob
     var tz = document.getElementById('hdntzo').value;
     var gul=Cal_SunRiseSet_Gulika(dob,document.getElementById('hdntob').value,tz);
     //Deepak End Code Here
     
   
     //var ObjFromDll = ActiveXObject("kundli4c.clskundli");
     //var anyResult = ObjFromDll.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById(hdnlongit).value),  parseFloat(document.getElementById(hdnlatit).value))
      var asc= transition.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById('hdnlongit').value),  parseFloat(document.getElementById('hdnlatit').value));
 
        
      transition.makebirthchart(dob, tob, tzon, parseFloat(asc.value), parseFloat(gul), callback_vargastaddmi);

     
     return false;
 }

 function add1day()
 {
     var dob = document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdnidateob').value + '/' + document.getElementById('hdniyearob').value
     var tob = document.getElementById('hdnihourob').value + '.' + document.getElementById('hdniminuteob').value
     var tzon = "5.30";
     var flag = "add1day"
     var exec = transition.maketransition(dob, tob, flag);
     getday(document.getElementById('hdnidateob').value + '/' + document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdniyearob').value);
     var ds = exec.value;

     daob = ds.Tables[0].Rows[0].IDOB.split(' ');
     document.getElementById('ttt').value = ds.Tables[0].Rows[0].IDOB;
     idaob = daob[0];
     itaob = daob[1];

     idaob1 = idaob.split('-');
     da1ob = idaob1[0];
     mo1ob = idaob1[1];
     yr1ob = idaob1[2];

     itaob1 = itaob.split(':');
     ihob = itaob1[0];
     imob = itaob1[1];

     var dob = mo1ob + '/' + da1ob + '/' + yr1ob;
     var tob = ihob + '.' + imob
     document.getElementById('hdnimonthob').value=mo1ob;
     document.getElementById('hdnidateob').value=da1ob;
     document.getElementById('hdniyearob').value=yr1ob;
     document.getElementById('hdnihourob').value=ihob;
     document.getElementById('hdniminuteob').value=imob;
     
     
     //Deepak Start Code Here
     document.getElementById('hdndob').value = da1ob + '/' + mo1ob + '/' + yr1ob;
     document.getElementById('hdntob').value = ihob + ':' + imob
     var tz = document.getElementById('hdntzo').value;
     var gul=Cal_SunRiseSet_Gulika(dob,document.getElementById('hdntob').value,tz);
     //Deepak End Code Here
     
      //var res = astro_client.getsunsetsunrisea
     //var ObjFromDll = ActiveXObject("kundli4c.clskundli");
     //var anyResult = ObjFromDll.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById(hdnlongit).value),  parseFloat(document.getElementById(hdnlatit).value))
      var asc= transition.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById('hdnlongit').value),  parseFloat(document.getElementById('hdnlatit').value));
 
      
      transition.makebirthchart(dob, tob, tzon, parseFloat(asc.value),parseFloat(gul), callback_vargastaddmi);

     
     return false;
 }


 function minus1week() {
     var dob = document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdnidateob').value + '/' + document.getElementById('hdniyearob').value
     var tob = document.getElementById('hdnihourob').value + '.' + document.getElementById('hdniminuteob').value
     var tzon = "5.30";
     var flag = "minus1week"
     getday(document.getElementById('hdnidateob').value + '/' + document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdniyearob').value);
     var exec = transition.maketransition(dob, tob, flag);
     var ds = exec.value;

     daob = ds.Tables[0].Rows[0].IDOB.split(' ');
     document.getElementById('ttt').value = ds.Tables[0].Rows[0].IDOB;
     idaob = daob[0];
     itaob = daob[1];

     idaob1 = idaob.split('-');
     da1ob = idaob1[0];
     mo1ob = idaob1[1];
     yr1ob = idaob1[2];

     itaob1 = itaob.split(':');
     ihob = itaob1[0];
     imob = itaob1[1];

     var dob = mo1ob + '/' + da1ob + '/' + yr1ob;
     var tob = ihob + '.' + imob
     document.getElementById('hdnimonthob').value = mo1ob;
     document.getElementById('hdnidateob').value = da1ob;
     document.getElementById('hdniyearob').value = yr1ob;
     document.getElementById('hdnihourob').value = ihob;
     document.getElementById('hdniminuteob').value = imob;
     
      //Deepak Start Code Here
     document.getElementById('hdndob').value = da1ob + '/' + mo1ob + '/' + yr1ob;
     document.getElementById('hdntob').value = ihob + ':' + imob
     var tz = document.getElementById('hdntzo').value;
     var gul=Cal_SunRiseSet_Gulika(dob,document.getElementById('hdntob').value,tz);
     //Deepak End Code Here


     //var ObjFromDll = ActiveXObject("kundli4c.clskundli");
     //var anyResult = ObjFromDll.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById(hdnlongit).value),  parseFloat(document.getElementById(hdnlatit).value))
     var asc = transition.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById('hdnlongit').value), parseFloat(document.getElementById('hdnlatit').value));


     transition.makebirthchart(dob, tob, tzon, parseFloat(asc.value), parseFloat(gul), callback_vargastaddmi);


     return false;
 }

 function add1week() {
     var dob = document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdnidateob').value + '/' + document.getElementById('hdniyearob').value
     var tob = document.getElementById('hdnihourob').value + '.' + document.getElementById('hdniminuteob').value
     var tzon = "5.30";
     var flag = "add1week"
     getday(document.getElementById('hdnidateob').value + '/' + document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdniyearob').value);
     var exec = transition.maketransition(dob, tob, flag);
     var ds = exec.value;

     daob = ds.Tables[0].Rows[0].IDOB.split(' ');
     document.getElementById('ttt').value = ds.Tables[0].Rows[0].IDOB;
     idaob = daob[0];
     itaob = daob[1];

     idaob1 = idaob.split('-');
     da1ob = idaob1[0];
     mo1ob = idaob1[1];
     yr1ob = idaob1[2];

     itaob1 = itaob.split(':');
     ihob = itaob1[0];
     imob = itaob1[1];

     var dob = mo1ob + '/' + da1ob + '/' + yr1ob;
     var tob = ihob + '.' + imob
     document.getElementById('hdnimonthob').value = mo1ob;
     document.getElementById('hdnidateob').value = da1ob;
     document.getElementById('hdniyearob').value = yr1ob;
     document.getElementById('hdnihourob').value = ihob;
     document.getElementById('hdniminuteob').value = imob;
     
     //Deepak Start Code Here
     document.getElementById('hdndob').value = da1ob + '/' + mo1ob + '/' + yr1ob;
     document.getElementById('hdntob').value = ihob + ':' + imob
     var tz = document.getElementById('hdntzo').value;
     var gul=Cal_SunRiseSet_Gulika(dob,document.getElementById('hdntob').value,tz);
     //Deepak End Code Here


     //var ObjFromDll = ActiveXObject("kundli4c.clskundli");
     //var anyResult = ObjFromDll.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById(hdnlongit).value),  parseFloat(document.getElementById(hdnlatit).value))
     var asc = transition.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById('hdnlongit').value), parseFloat(document.getElementById('hdnlatit').value));


     transition.makebirthchart(dob, tob, tzon, parseFloat(asc.value), parseFloat(gul), callback_vargastaddmi);


     return false;
 }


 function minus1month() {
     var dob = document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdnidateob').value + '/' + document.getElementById('hdniyearob').value
     var tob = document.getElementById('hdnihourob').value + '.' + document.getElementById('hdniminuteob').value
     var tzon = "5.30";
     var flag = "minus1month"
     getday(document.getElementById('hdnidateob').value + '/' + document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdniyearob').value);
     var exec = transition.maketransition(dob, tob, flag);
     var ds = exec.value;

     daob = ds.Tables[0].Rows[0].IDOB.split(' ');
     document.getElementById('ttt').value = ds.Tables[0].Rows[0].IDOB;
     idaob = daob[0];
     itaob = daob[1];

     idaob1 = idaob.split('-');
     da1ob = idaob1[0];
     mo1ob = idaob1[1];
     yr1ob = idaob1[2];

     itaob1 = itaob.split(':');
     ihob = itaob1[0];
     imob = itaob1[1];

     var dob = mo1ob + '/' + da1ob + '/' + yr1ob;
     var tob = ihob + '.' + imob
     document.getElementById('hdnimonthob').value = mo1ob;
     document.getElementById('hdnidateob').value = da1ob;
     document.getElementById('hdniyearob').value = yr1ob;
     document.getElementById('hdnihourob').value = ihob;
     document.getElementById('hdniminuteob').value = imob;
     
     //Deepak Start Code Here
     document.getElementById('hdndob').value = da1ob + '/' + mo1ob + '/' + yr1ob;
     document.getElementById('hdntob').value = ihob + ':' + imob
     var tz = document.getElementById('hdntzo').value;
    var gul= Cal_SunRiseSet_Gulika(dob,document.getElementById('hdntob').value,tz);
     //Deepak End Code Here


     //var ObjFromDll = ActiveXObject("kundli4c.clskundli");
     //var anyResult = ObjFromDll.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById(hdnlongit).value),  parseFloat(document.getElementById(hdnlatit).value))
     var asc = transition.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById('hdnlongit').value), parseFloat(document.getElementById('hdnlatit').value));


     transition.makebirthchart(dob, tob, tzon, parseFloat(asc.value), parseFloat(gul), callback_vargastaddmi);


     return false;
 }

 function add1month() {
     var dob = document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdnidateob').value + '/' + document.getElementById('hdniyearob').value
     var tob = document.getElementById('hdnihourob').value + '.' + document.getElementById('hdniminuteob').value
     var tzon = "5.30";
     var flag = "add1month"
     getday(document.getElementById('hdnidateob').value + '/' + document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdniyearob').value);
     var exec = transition.maketransition(dob, tob, flag);
     var ds = exec.value;

     daob = ds.Tables[0].Rows[0].IDOB.split(' ');
     document.getElementById('ttt').value = ds.Tables[0].Rows[0].IDOB;
     idaob = daob[0];
     itaob = daob[1];

     idaob1 = idaob.split('-');
     da1ob = idaob1[0];
     mo1ob = idaob1[1];
     yr1ob = idaob1[2];

     itaob1 = itaob.split(':');
     ihob = itaob1[0];
     imob = itaob1[1];

     var dob = mo1ob + '/' + da1ob + '/' + yr1ob;
     var tob = ihob + '.' + imob
     document.getElementById('hdnimonthob').value = mo1ob;
     document.getElementById('hdnidateob').value = da1ob;
     document.getElementById('hdniyearob').value = yr1ob;
     document.getElementById('hdnihourob').value = ihob;
     document.getElementById('hdniminuteob').value = imob;
     
     //Deepak Start Code Here
     document.getElementById('hdndob').value = da1ob + '/' + mo1ob + '/' + yr1ob;
     document.getElementById('hdntob').value = ihob + ':' + imob
     var tz = document.getElementById('hdntzo').value;
    var gul= Cal_SunRiseSet_Gulika(dob,document.getElementById('hdntob').value,tz);
     //Deepak End Code Here


     //var ObjFromDll = ActiveXObject("kundli4c.clskundli");
     //var anyResult = ObjFromDll.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById(hdnlongit).value),  parseFloat(document.getElementById(hdnlatit).value))
     var asc = transition.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById('hdnlongit').value), parseFloat(document.getElementById('hdnlatit').value));


     transition.makebirthchart(dob, tob, tzon, parseFloat(asc.value), parseFloat(gul), callback_vargastaddmi);


     return false;
 }


 function minus1year() {
     var dob = document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdnidateob').value + '/' + document.getElementById('hdniyearob').value
     var tob = document.getElementById('hdnihourob').value + '.' + document.getElementById('hdniminuteob').value
     var tzon = "5.30";
     var flag = "minus1year"
     getday(document.getElementById('hdnidateob').value + '/' + document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdniyearob').value);
     var exec = transition.maketransition(dob, tob, flag);
     var ds = exec.value;

     daob = ds.Tables[0].Rows[0].IDOB.split(' ');
     document.getElementById('ttt').value = ds.Tables[0].Rows[0].IDOB;
     idaob = daob[0];
     itaob = daob[1];

     idaob1 = idaob.split('-');
     da1ob = idaob1[0];
     mo1ob = idaob1[1];
     yr1ob = idaob1[2];

     itaob1 = itaob.split(':');
     ihob = itaob1[0];
     imob = itaob1[1];

     var dob = mo1ob + '/' + da1ob + '/' + yr1ob;
     var tob = ihob + '.' + imob
     document.getElementById('hdnimonthob').value = mo1ob;
     document.getElementById('hdnidateob').value = da1ob;
     document.getElementById('hdniyearob').value = yr1ob;
     document.getElementById('hdnihourob').value = ihob;
     document.getElementById('hdniminuteob').value = imob;
     
     //Deepak Start Code Here
     document.getElementById('hdndob').value = da1ob + '/' + mo1ob + '/' + yr1ob;
     document.getElementById('hdntob').value = ihob + ':' + imob
     var tz = document.getElementById('hdntzo').value;
     var gul=Cal_SunRiseSet_Gulika(dob,document.getElementById('hdntob').value,tz);
     //Deepak End Code Here


     //var ObjFromDll = ActiveXObject("kundli4c.clskundli");
     //var anyResult = ObjFromDll.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById(hdnlongit).value),  parseFloat(document.getElementById(hdnlatit).value))
     var asc = transition.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById('hdnlongit').value), parseFloat(document.getElementById('hdnlatit').value));


     transition.makebirthchart(dob, tob, tzon, parseFloat(asc.value), parseFloat(gul), callback_vargastaddmi);


     return false;
 }

 function add1year() {
     var dob = document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdnidateob').value + '/' + document.getElementById('hdniyearob').value
     var tob = document.getElementById('hdnihourob').value + '.' + document.getElementById('hdniminuteob').value
     var tzon = "5.30";
     var flag = "add1year"
     getday(document.getElementById('hdnidateob').value + '/' + document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdniyearob').value);
     var exec = transition.maketransition(dob, tob, flag);
     var ds = exec.value;

     daob = ds.Tables[0].Rows[0].IDOB.split(' ');
     document.getElementById('ttt').value = ds.Tables[0].Rows[0].IDOB;
     idaob = daob[0];
     itaob = daob[1];

     idaob1 = idaob.split('-');
     da1ob = idaob1[0];
     mo1ob = idaob1[1];
     yr1ob = idaob1[2];

     itaob1 = itaob.split(':');
     ihob = itaob1[0];
     imob = itaob1[1];

     var dob = mo1ob + '/' + da1ob + '/' + yr1ob;
     var tob = ihob + '.' + imob
     document.getElementById('hdnimonthob').value = mo1ob;
     document.getElementById('hdnidateob').value = da1ob;
     document.getElementById('hdniyearob').value = yr1ob;
     document.getElementById('hdnihourob').value = ihob;
     document.getElementById('hdniminuteob').value = imob;
     
     //Deepak Start Code Here
     document.getElementById('hdndob').value = da1ob + '/' + mo1ob + '/' + yr1ob;
     document.getElementById('hdntob').value = ihob + ':' + imob
     var tz = document.getElementById('hdntzo').value;
     var gul=Cal_SunRiseSet_Gulika(dob,document.getElementById('hdntob').value,tz);
     //Deepak End Code Here


     //var ObjFromDll = ActiveXObject("kundli4c.clskundli");
     //var anyResult = ObjFromDll.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById(hdnlongit).value),  parseFloat(document.getElementById(hdnlatit).value))
     var asc = transition.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById('hdnlongit').value), parseFloat(document.getElementById('hdnlatit').value));


     transition.makebirthchart(dob, tob, tzon, parseFloat(asc.value), parseFloat(gul), callback_vargastaddmi);


     return false;
 }



 function minus10year() {
     var dob = document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdnidateob').value + '/' + document.getElementById('hdniyearob').value
     var tob = document.getElementById('hdnihourob').value + '.' + document.getElementById('hdniminuteob').value
     var tzon = "5.30";
     var flag = "minus10year"
     getday(document.getElementById('hdnidateob').value + '/' + document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdniyearob').value);
     var exec = transition.maketransition(dob, tob, flag);
     var ds = exec.value;

     daob = ds.Tables[0].Rows[0].IDOB.split(' ');
     document.getElementById('ttt').value = ds.Tables[0].Rows[0].IDOB;
     idaob = daob[0];
     itaob = daob[1];

     idaob1 = idaob.split('-');
     da1ob = idaob1[0];
     mo1ob = idaob1[1];
     yr1ob = idaob1[2];

     itaob1 = itaob.split(':');
     ihob = itaob1[0];
     imob = itaob1[1];

     var dob = mo1ob + '/' + da1ob + '/' + yr1ob;
     var tob = ihob + '.' + imob
     document.getElementById('hdnimonthob').value = mo1ob;
     document.getElementById('hdnidateob').value = da1ob;
     document.getElementById('hdniyearob').value = yr1ob;
     document.getElementById('hdnihourob').value = ihob;
     document.getElementById('hdniminuteob').value = imob;
     
     //Deepak Start Code Here
     document.getElementById('hdndob').value = da1ob + '/' + mo1ob + '/' + yr1ob;
     document.getElementById('hdntob').value = ihob + ':' + imob
     var tz = document.getElementById('hdntzo').value;
     var gul=Cal_SunRiseSet_Gulika(dob,document.getElementById('hdntob').value,tz);
     //Deepak End Code Here


     //var ObjFromDll = ActiveXObject("kundli4c.clskundli");
     //var anyResult = ObjFromDll.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById(hdnlongit).value),  parseFloat(document.getElementById(hdnlatit).value))
     var asc = transition.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById('hdnlongit').value), parseFloat(document.getElementById('hdnlatit').value));


     transition.makebirthchart(dob, tob, tzon, parseFloat(asc.value), parseFloat(gul), callback_vargastaddmi);


     return false;
 }

 function add10year() {
     var dob = document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdnidateob').value + '/' + document.getElementById('hdniyearob').value
     var tob = document.getElementById('hdnihourob').value + '.' + document.getElementById('hdniminuteob').value
     var tzon = "5.30";
     var flag = "add10year"
     getday(document.getElementById('hdnidateob').value + '/' + document.getElementById('hdnimonthob').value + '/' + document.getElementById('hdniyearob').value);
     var exec = transition.maketransition(dob, tob, flag);
     var ds = exec.value;

     daob = ds.Tables[0].Rows[0].IDOB.split(' ');
     document.getElementById('ttt').value = ds.Tables[0].Rows[0].IDOB;
     idaob = daob[0];
     itaob = daob[1];

     idaob1 = idaob.split('-');
     da1ob = idaob1[0];
     mo1ob = idaob1[1];
     yr1ob = idaob1[2];

     itaob1 = itaob.split(':');
     ihob = itaob1[0];
     imob = itaob1[1];

     var dob = mo1ob + '/' + da1ob + '/' + yr1ob;
     var tob = ihob + '.' + imob
     document.getElementById('hdnimonthob').value = mo1ob;
     document.getElementById('hdnidateob').value = da1ob;
     document.getElementById('hdniyearob').value = yr1ob;
     document.getElementById('hdnihourob').value = ihob;
     document.getElementById('hdniminuteob').value = imob;
     
     //Deepak Start Code Here
     document.getElementById('hdndob').value = da1ob + '/' + mo1ob + '/' + yr1ob;
     document.getElementById('hdntob').value = ihob + ':' + imob
     var tz = document.getElementById('hdntzo').value;
    var gul= Cal_SunRiseSet_Gulika(dob,document.getElementById('hdntob').value,tz);
     //Deepak End Code Here
     

     //var ObjFromDll = ActiveXObject("kundli4c.clskundli");
     //var anyResult = ObjFromDll.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById(hdnlongit).value),  parseFloat(document.getElementById(hdnlatit).value))
     var asc = transition.asccalcul(da1ob, mo1ob, yr1ob, ihob, imob, 00, -5.5, parseFloat(document.getElementById('hdnlongit').value), parseFloat(document.getElementById('hdnlatit').value));


     transition.makebirthchart(dob, tob, tzon, parseFloat(asc.value), parseFloat(gul), callback_vargastaddmi);


     return false;
 }

 function callback_vargastaddmi(val) {
     record_show = 10
     record_show1 = 1
     var gg4 = 0;
     exec_data = val.value;
     var i = 0

     if (exec_data.Tables[0].Rows.length > 0) {
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

         if (document.getElementById("hdsviewgrid2").innerHTML.indexOf("width:520;display:block") <= 0) {
             aa = document.getElementById("hdsviewgrid2").innerHTML.replace("</TBODY>", "")//</TABLE>","")
         }
         buf2 = "";
         buf2 += "<table  id='Divgrid2' runat='server' align='left' Width='150px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
         buf2 += "<tr>"
         buf2 += "<td  class='colum-td-head'>" + "PLANET" + "</td>"
         buf2 += "<td  class='colum-td-head' style='display:none;'>" + "HOUSE" + "</td>"
         buf2 += "<td  class='colum-td-head'>" + "CONSTELATION" + "</td>"
         buf2 += "<td  class='colum-td-head'>" + "RASHI" + "</td>"
         buf2 += "<td  class='colum-td-head'>" + "R" + "</td>"
         buf2 += "<td  class='colum-td-head'>" + "DEGREE" + "</td>"
         buf2 += "</tr>"


         len = 1;


         if (exec_data.Tables[0].Rows.length > 0) {
             for (i = 0; i < exec_data.Tables[0].Rows.length; ++i) {

                 buf2 += "<tr>"
                 //                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'> "
                 //                buf2 += "<label  style='width:90px; font-family:helvetica;' class='dropdown_large_corr'; align='left' Text='" + exec_data.Tables[0].Rows[i]['PLANET'] + "'  id=planets_" + i + " >"
                 //                buf2 += "</td>"


                 buf2 += "<td class='colum-td-new1'>"
                 buf2 += "<font width='30px' class='Planets-font'>" + (exec_data.Tables[0].Rows[i]['PLANET1']) + "</font>"
                 buf2 += "<input type='hidden' class='Planets-font' id=planetst_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['PLANET1']) + ">"
                 buf2 += "</td>"



                 buf2 += "<td class='colum-td-new1' style='display:none;'>"
                 buf2 += "<font width='30px'>" + (exec_data.Tables[0].Rows[i]['HOUSE']) + "</font>"
                 buf2 += "<input type='hidden' class='Planets-font' id=houset_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['HOUSE']) + ">"
                 buf2 += "</td>"

                 buf2 += "<td class='colum-td-new1'>"
                 buf2 += "<font width='30px'>" + (exec_data.Tables[0].Rows[i]['CONSTELATION']) + "</font>"
                 buf2 += "<input type='hidden' class='Planets-font' id=houset_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['CONSTELATION']) + ">"
                 buf2 += "</td>"


                 buf2 += "<td class='colum-td-new1'>"
                 buf2 += "<font width='30px'>" + (exec_data.Tables[0].Rows[i]['RASHI']) + "</font>"
                 buf2 += "<input type='hidden' id=rashit_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['RASHI']) + ">"
                 buf2 += "</td>"


                     buf2 += "<td class='colum-td-new1'>"
                     buf2 += "<font width='10px'></font>"
                     buf2 += "<input type='text' disabled style='width:10px;'  id=retrogradet_" + i + " >"
                     buf2 += "</td>"


                 buf2 += "<td class='colum-td-new1'>"
                 buf2 += "<font width='30px'>" + (exec_data.Tables[0].Rows[i]['DEGREE']+'.'+exec_data.Tables[0].Rows[i]['MINUTE']+'.'+exec_data.Tables[0].Rows[i]['SECOND']) + "</font>"
                 buf2 += "<input type='hidden' id=degreet_" + i + "  value =" + (exec_data.Tables[0].Rows[i]['DEGREE']+'.'+exec_data.Tables[0].Rows[i]['MINUTE']+'.'+exec_data.Tables[0].Rows[i]['SECOND']) + ">"
                 buf2 += "</td>"

                 buf2 += "</td>"





                 buf2 += "</tr>"
                 
                 if (exec_data.Tables[0].Rows[i].RASHI == 'Aries') {
                  var num = 1;
              }
              if (exec_data.Tables[0].Rows[i].RASHI == 'Taurus') {
                  var num = 2;
              }
              if (exec_data.Tables[0].Rows[i].RASHI == 'Gemini') {
                  var num = 3;
              }
              if (exec_data.Tables[0].Rows[i].RASHI == 'Cancer') {
                  var num = 4;
              }
              if (exec_data.Tables[0].Rows[i].RASHI == 'Leo') {
                  var num = 5;
              }
              if (exec_data.Tables[0].Rows[i].RASHI == 'Virgo') {
                  var num = 6;
              }
              if (exec_data.Tables[0].Rows[i].RASHI == 'Libra') {
                  var num = 7;
              }
              if (exec_data.Tables[0].Rows[i].RASHI == 'Scorpio') {
                  var num = 8;
              }
              if (exec_data.Tables[0].Rows[i].RASHI == 'Sagittarius') {
                  var num = 9;
              }
              if (exec_data.Tables[0].Rows[i].RASHI == 'Capricorn') {
                  var num = 10;
              }
              if (exec_data.Tables[0].Rows[i].RASHI == 'Aquarius') {
                  var num = 11;
              }
              if (exec_data.Tables[0].Rows[i].RASHI == 'Pisces') {
                  var num = 12;
              }
              document.getElementById('hdnr'+i).value = num;
              document.getElementById('hdnretro' + i).value = zeroPad(parseInt(exec_data.Tables[0].Rows[i].DEGREE), 2) + '.' + zeroPad(parseInt(exec_data.Tables[0].Rows[i].MINUTE), 2) + '.' + zeroPad(parseInt(exec_data.Tables[0].Rows[i].SECOND),2);
                 
             }
         }
         buf2 += "</table>"
         var hdsview = "";
         temp_del1 = aa + buf2.toString();
         temp_del1 = temp_del1.replace("<TBODY>", "")
         temp_del1 = temp_del1.replace("</TBODY>", "")
         //alert(temp_del1)
         document.getElementById('hdsviewgrid2').innerHTML = temp_del1;

         if (exec_data.Tables[1].Rows.length > 0) {

             for (i = 0; i < exec_data.Tables[1].Rows.length; ++i) {
                 if (exec_data.Tables[1].Rows[i].PLANET == 'MARS' && exec_data.Tables[1].Rows[i].MOVEMENT1 == 'R')
                 { document.getElementById('retrogradet_' + 3).value = 'R' }
                 if (exec_data.Tables[1].Rows[i].PLANET == 'MERCURY' && exec_data.Tables[1].Rows[i].MOVEMENT1 == 'R')
                 { document.getElementById('retrogradet_' + 4).value = 'R' }
                 if (exec_data.Tables[1].Rows[i].PLANET == 'JUPITER' && exec_data.Tables[1].Rows[i].MOVEMENT1 == 'R')
                 { document.getElementById('retrogradet_' + 5).value = 'R' }
                 if (exec_data.Tables[1].Rows[i].PLANET == 'VENUS' && exec_data.Tables[1].Rows[i].MOVEMENT1 == 'R')
                 { document.getElementById('retrogradet_' + 6).value = 'R' }
                 if (exec_data.Tables[1].Rows[i].PLANET == 'SATURN' && exec_data.Tables[1].Rows[i].MOVEMENT1 == 'R')
                 { document.getElementById('retrogradet_' + 7).value = 'R' }
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
      else if (parseInt(document.getElementById('hdnr' + 1).value) < parseInt(document.getElementById('hdnr' + 2).value)) {
          var moonsun = parseFloat('30.00' - document.getElementById('hdnretro' + 1).value.slice(0, -3)) + parseFloat(document.getElementById('hdnretro' + 2).value.slice(0, -3))
      }
      else {
          var moonsun = parseFloat(document.getElementById('hdnretro' + 2).value.slice(0, -3)) - parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))

      }


      if (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) && parseInt(document.getElementById('hdnr' + 3).value) == parseInt(1)) {
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
      else {
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
          var jupsun = parseFloat(document.getElementById('hdnretro' + 5).value.slice(0, -3)) - parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
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
          var vensun = parseFloat(document.getElementById('hdnretro' + 6).value.slice(0, -3)) - parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))

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
          var rahsun = parseFloat(document.getElementById('hdnretro' + 8).value.slice(0, -3)) - parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
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
          var ketsun = parseFloat(document.getElementById('hdnretro' + 9).value.slice(0, -3)) - parseFloat(document.getElementById('hdnretro' + 1).value.slice(0, -3))
      }



      if (moonsun < "12" && moonsun > "-12" && parseInt(document.getElementById('hdnr' + 2).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 2).value) != parseInt(1) && moonsunr <= '1' && moonsunr >= '-1') {
          if (document.getElementById('retrogradet_' + 2).value == 'R') {
              document.getElementById('retrogradet_' + 2).value = 'RC'
          }
          else {
              document.getElementById('retrogradet_' + 2).value = 'C'
          }
      }

      if (moonsun < "3.20" && moonsun > "-3.20" && parseInt(document.getElementById('hdnr' + 2).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 2).value) != parseInt(1) && moonsunr <= '1' && moonsunr >= '-1') {
          if (document.getElementById('retrogradet_' + 2).value == 'R') {
              document.getElementById('retrogradet_' + 2).value = 'RDC'
          }
          else {
              document.getElementById('retrogradet_' + 2).value = 'DC'
          }


      }


      if (parseInt(document.getElementById('hdnr' + 2).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (moonsun < "12" && moonsun > "-12" && (parseInt(document.getElementById('hdnr' + 2).value)) != parseInt('1')) {
              if (document.getElementById('retrogradet_' + 2).value == 'R') {
                  document.getElementById('retrogradet_' + 2).value = 'RC'
              }
              else {
                  document.getElementById('retrogradet_' + 2).value = 'C'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 2).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (moonsun < "3.20" && moonsun > "-3.20" && (parseInt(document.getElementById('hdnr' + 2).value)) != parseInt('1')) {
              if (document.getElementById('retrogradet_' + 2).value == 'R') {
                  document.getElementById('retrogradet_' + 2).value = 'RDC'
              }
              else {
                  document.getElementById('retrogradet_' + 2).value = 'DC'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 2).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (moonsun < "12" && moonsun > "-12" && ((parseInt(document.getElementById('hdnr' + 2).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 2).value)) == parseInt('12'))) {
              if (document.getElementById('retrogradet_' + 2).value == 'R') {
                  document.getElementById('retrogradet_' + 2).value = 'RC'
              }
              else {
                  document.getElementById('retrogradet_' + 2).value = 'C'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 2).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (moonsun < "3.20" && moonsun > "-3.20" && ((parseInt(document.getElementById('hdnr' + 2).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 2).value)) == parseInt('12'))) {
              if (document.getElementById('retrogradet_' + 2).value == 'R') {
                  document.getElementById('retrogradet_' + 2).value = 'RDC'
              }
              else {
                  document.getElementById('retrogradet_' + 2).value = 'DC'
              }
          }

      }











      if (satsun < "16" && satsun > "-16" && parseInt(document.getElementById('hdnr' + 7).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 7).value) != parseInt(1) && satsunr <= '1' && satsunr >= '-1') {
          if (document.getElementById('retrogradet_' + 7).value == 'R') {
              document.getElementById('retrogradet_' + 7).value = 'RC'
          }
          else {
              document.getElementById('retrogradet_' + 7).value = 'C'
          }
      }

      if (satsun < "3.20" && satsun > "-3.20" && parseInt(document.getElementById('hdnr' + 7).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 7).value) != parseInt(1) && satsunr <= '1' && satsunr >= '-1') {
          if (document.getElementById('retrogradet_' + 7).value == 'R') {
              document.getElementById('retrogradet_' + 7).value = 'RDC'
          }
          else {
              document.getElementById('retrogradet_' + 7).value = 'DC'
          }


      }


      if (parseInt(document.getElementById('hdnr' + 7).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (satsun < "16" && satsun > "-16" && (parseInt(document.getElementById('hdnr' + 7).value)) != parseInt('1')) {
              if (document.getElementById('retrogradet_' + 7).value == 'R') {
                  document.getElementById('retrogradet_' + 7).value = 'RC'
              }
              else {
                  document.getElementById('retrogradet_' + 7).value = 'C'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 7).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (satsun < "3.20" && satsun > "-3.20" && (parseInt(document.getElementById('hdnr' + 7).value)) != parseInt('1')) {
              if (document.getElementById('retrogradet_' + 7).value == 'R') {
                  document.getElementById('retrogradet_' + 7).value = 'RDC'
              }
              else {
                  document.getElementById('retrogradet_' + 7).value = 'DC'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 7).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (satsun < "16" && satsun > "-16" && ((parseInt(document.getElementById('hdnr' + 7).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 7).value)) == parseInt('12'))) {
              if (document.getElementById('retrogradet_' + 7).value == 'R') {
                  document.getElementById('retrogradet_' + 7).value = 'RC'
              }
              else {
                  document.getElementById('retrogradet_' + 7).value = 'C'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 7).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (satsun < "3.20" && satsun > "-3.20" && ((parseInt(document.getElementById('hdnr' + 7).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 7).value)) == parseInt('12'))) {
              if (document.getElementById('retrogradet_' + 7).value == 'R') {
                  document.getElementById('retrogradet_' + 7).value = 'RDC'
              }
              else {
                  document.getElementById('retrogradet_' + 7).value = 'DC'
              }
          }

      }











      if (vensun < "10" && vensun > "-10" && parseInt(document.getElementById('hdnr' + 6).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 6).value) != parseInt(1) && vensunr <= '1' && vensunr >= '-1') {
          if (document.getElementById('retrogradet_' + 6).value == 'R') {
              document.getElementById('retrogradet_' + 6).value = 'RC'
          }
          else {
              document.getElementById('retrogradet_' + 6).value = 'C'
          }
      }

      if (vensun < "3.20" && vensun > "-3.20" && parseInt(document.getElementById('hdnr' + 6).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 6).value) != parseInt(1) && vensunr <= '1' && vensunr >= '-1') {
          if (document.getElementById('retrogradet_' + 6).value == 'R') {
              document.getElementById('retrogradet_' + 6).value = 'RDC'
          }
          else {
              document.getElementById('retrogradet_' + 6).value = 'DC'
          }


      }


      if (parseInt(document.getElementById('hdnr' + 6).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (vensun < "10" && vensun > "-10" && (parseInt(document.getElementById('hdnr' + 6).value)) != parseInt('1')) {
              if (document.getElementById('retrogradet_' + 6).value == 'R') {
                  document.getElementById('retrogradet_' + 6).value = 'RC'
              }
              else {
                  document.getElementById('retrogradet_' + 6).value = 'C'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 6).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (vensun < "3.20" && vensun > "-3.20" && (parseInt(document.getElementById('hdnr' + 6).value)) != parseInt('1')) {
              if (document.getElementById('retrogradet_' + 6).value == 'R') {
                  document.getElementById('retrogradet_' + 6).value = 'RDC'
              }
              else {
                  document.getElementById('retrogradet_' + 6).value = 'DC'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 6).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (vensun < "10" && vensun > "-10" && ((parseInt(document.getElementById('hdnr' + 6).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 6).value)) == parseInt('12'))) {
              if (document.getElementById('retrogradet_' + 6).value == 'R') {
                  document.getElementById('retrogradet_' + 6).value = 'RC'
              }
              else {
                  document.getElementById('retrogradet_' + 6).value = 'C'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 6).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (vensun < "3.20" && vensun > "-3.20" && ((parseInt(document.getElementById('hdnr' + 6).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 6).value)) == parseInt('12'))) {
              if (document.getElementById('retrogradet_' + 6).value == 'R') {
                  document.getElementById('retrogradet_' + 6).value = 'RDC'
              }
              else {
                  document.getElementById('retrogradet_' + 6).value = 'DC'
              }
          }

      }















      if (jupsun < "11" && jupsun > "-11" && parseInt(document.getElementById('hdnr' + 5).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 5).value) != parseInt(1) && jupsunr <= '1' && jupsunr >= '-1') {
          if (document.getElementById('retrogradet_' + 5).value == 'R') {
              document.getElementById('retrogradet_' + 5).value = 'RC'
          }
          else {
              document.getElementById('retrogradet_' + 5).value = 'C'
          }
      }

      if (jupsun < "3.20" && jupsun > "-3.20" && parseInt(document.getElementById('hdnr' + 5).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 5).value) != parseInt(1) && jupsunr <= '1' && jupsunr >= '-1') {
          if (document.getElementById('retrogradet_' + 5).value == 'R') {
              document.getElementById('retrogradet_' + 5).value = 'RDC'
          }
          else {
              document.getElementById('retrogradet_' + 5).value = 'DC'
          }


      }


      if (parseInt(document.getElementById('hdnr' + 5).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (jupsun < "11" && jupsun > "-11" && (parseInt(document.getElementById('hdnr' + 5).value)) != parseInt('1')) {
              if (document.getElementById('retrogradet_' + 5).value == 'R') {
                  document.getElementById('retrogradet_' + 5).value = 'RC'
              }
              else {
                  document.getElementById('retrogradet_' + 5).value = 'C'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 5).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (jupsun < "3.20" && jupsun > "-3.20" && (parseInt(document.getElementById('hdnr' + 5).value)) != parseInt('1')) {
              if (document.getElementById('retrogradet_' + 5).value == 'R') {
                  document.getElementById('retrogradet_' + 5).value = 'RDC'
              }
              else {
                  document.getElementById('retrogradet_' + 5).value = 'DC'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 5).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (jupsun < "11" && jupsun > "-11" && ((parseInt(document.getElementById('hdnr' + 5).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 5).value)) == parseInt('12'))) {
              if (document.getElementById('retrogradet_' + 5).value == 'R') {
                  document.getElementById('retrogradet_' + 5).value = 'RC'
              }
              else {
                  document.getElementById('retrogradet_' + 5).value = 'C'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 5).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (jupsun < "3.20" && jupsun > "-3.20" && ((parseInt(document.getElementById('hdnr' + 5).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 5).value)) == parseInt('12'))) {
              if (document.getElementById('retrogradet_' + 5).value == 'R') {
                  document.getElementById('retrogradet_' + 5).value = 'RDC'
              }
              else {
                  document.getElementById('retrogradet_' + 5).value = 'DC'
              }
          }

      }
















      if (mersun < "14" && mersun > "-14" && parseInt(document.getElementById('hdnr' + 4).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 4).value) != parseInt(1) && mersunr <= '1' && mersunr >= '-1') {
          if (document.getElementById('retrogradet_' + 4).value == 'R') {
              document.getElementById('retrogradet_' + 4).value = 'RC'
          }
          else {
              document.getElementById('retrogradet_' + 4).value = 'C'
          }
      }

      if (mersun < "3.20" && mersun > "-3.20" && parseInt(document.getElementById('hdnr' + 4).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 4).value) != parseInt(1) && mersunr <= '1' && mersunr >= '-1') {
          if (document.getElementById('retrogradet_' + 4).value == 'R') {
              document.getElementById('retrogradet_' + 4).value = 'RDC'
          }
          else {
              document.getElementById('retrogradet_' + 4).value = 'DC'
          }


      }


      if (parseInt(document.getElementById('hdnr' + 4).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (mersun < "14" && mersun > "-14" && (parseInt(document.getElementById('hdnr' + 4).value)) != parseInt('1')) {
              if (document.getElementById('retrogradet_' + 4).value == 'R') {
                  document.getElementById('retrogradet_' + 4).value = 'RC'
              }
              else {
                  document.getElementById('retrogradet_' + 4).value = 'C'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 4).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (mersun < "3.20" && mersun > "-3.20" && (parseInt(document.getElementById('hdnr' + 4).value)) != parseInt('1')) {
              if (document.getElementById('retrogradet_' + 4).value == 'R') {
                  document.getElementById('retrogradet_' + 4).value = 'RDC'
              }
              else {
                  document.getElementById('retrogradet_' + 4).value = 'DC'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 4).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (mersun < "14" && mersun > "-14" && ((parseInt(document.getElementById('hdnr' + 4).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 4).value)) == parseInt('12'))) {
              if (document.getElementById('retrogradet_' + 4).value == 'R') {
                  document.getElementById('retrogradet_' + 4).value = 'RC'
              }
              else {
                  document.getElementById('retrogradet_' + 4).value = 'C'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 4).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (mersun < "3.20" && mersun > "-3.20" && ((parseInt(document.getElementById('hdnr' + 4).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 4).value)) == parseInt('12'))) {
              if (document.getElementById('retrogradet_' + 4).value == 'R') {
                  document.getElementById('retrogradet_' + 4).value = 'RDC'
              }
              else {
                  document.getElementById('retrogradet_' + 4).value = 'DC'
              }
          }

      }






      if (marsun < "17" && marsun > "-17" && parseInt(document.getElementById('hdnr' + 3).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 3).value) != parseInt(1) && marsunr <= '1' && marsunr >= '-1') {
          if (document.getElementById('retrogradet_' + 3).value == 'R') {
              document.getElementById('retrogradet_' + 3).value = 'RC'
          }
          else {
              document.getElementById('retrogradet_' + 3).value = 'C'
          }
      }

      if (marsun < "3.20" && marsun > "-3.20" && parseInt(document.getElementById('hdnr' + 3).value) != parseInt('12') && parseInt(document.getElementById('hdnr' + 3).value) != parseInt(1) && marsunr <= '1' && marsunr >= '-1') {
          if (document.getElementById('retrogradet_' + 3).value == 'R') {
              document.getElementById('retrogradet_' + 3).value = 'RDC'
          }
          else {
              document.getElementById('retrogradet_' + 3).value = 'DC'
          }


      }


      if (parseInt(document.getElementById('hdnr' + 3).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (marsun < "17" && marsun > "-17" && (parseInt(document.getElementById('hdnr' + 3).value)) != parseInt('1')) {
              if (document.getElementById('retrogradet_' + 3).value == 'R') {
                  document.getElementById('retrogradet_' + 3).value = 'RC'
              }
              else {
                  document.getElementById('retrogradet_' + 3).value = 'C'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 3).value) == parseInt(12) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(11) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1))) {

          if (marsun < "3.20" && marsun > "-3.20" && (parseInt(document.getElementById('hdnr' + 3).value)) != parseInt('1')) {
              if (document.getElementById('retrogradet_' + 3).value == 'R') {
                  document.getElementById('retrogradet_' + 3).value = 'RDC'
              }
              else {
                  document.getElementById('retrogradet_' + 3).value = 'DC'
              }
          }


      }

      if (parseInt(document.getElementById('hdnr' + 3).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (marsun < "17" && marsun > "-17" && ((parseInt(document.getElementById('hdnr' + 3).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 3).value)) == parseInt('12'))) {
              if (document.getElementById('retrogradet_' + 3).value == 'R') {
                  document.getElementById('retrogradet_' + 3).value = 'RC'
              }
              else {
                  document.getElementById('retrogradet_' + 3).value = 'C'
              }
          }

      }

      if (parseInt(document.getElementById('hdnr' + 3).value) == parseInt(1) && (parseInt(document.getElementById('hdnr' + 1).value) == parseInt(1) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(12) || parseInt(document.getElementById('hdnr' + 1).value) == parseInt(2))) {

          if (marsun < "3.20" && marsun > "-3.20" && ((parseInt(document.getElementById('hdnr' + 3).value)) == parseInt('1') || (parseInt(document.getElementById('hdnr' + 3).value)) == parseInt('12'))) {
              if (document.getElementById('retrogradet_' + 3).value == 'R') {
                  document.getElementById('retrogradet_' + 3).value = 'RDC'
              }
              else {
                  document.getElementById('retrogradet_' + 3).value = 'DC'
              }
          }

      }



     }

     transitionfuncaddminus();

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
  
  
  
  
function transitionfuncaddminus() {
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

    document.getElementById('rashiidd01').style.display = "block";
    for (var i = 1; i < 11; i++) {
        document.getElementById('Hidden5d01').value = i;

        var h = document.getElementById('houset_' + i).value
        var r = document.getElementById('rashit_' + 0).value


        if (document.getElementById('retrogradet_' + i).value == "0" || document.getElementById('retrogradet_' + i).value == "B") {
            document.getElementById('retrogradet_' + i).innerHTML = "";
        }



        if (h == 'HOUSE1') {

            deg = document.getElementById('degreet_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planetst_' + i).value == 'MERCURY') {
                j1 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'JUPITER') {
                j1 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'VENUS') {
                j1 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SATURN') {
                j1 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SUN') {
                j1 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MOON') {
                j1 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MARS') {
                j1 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'RAHU') {
                j1 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planetst_' + i).value == 'KETU') {
                j1 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'GULIKA') {
                j1 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            h1 = h1 + j1 + " ";


        }
        if (h == 'HOUSE2') {
            deg = document.getElementById('degreet_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planetst_' + i).value == 'MERCURY') {
                j2 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'JUPITER') {
                j2 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'VENUS') {
                j2 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SATURN') {
                j2 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SUN') {
                j2 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MOON') {
                j2 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MARS') {
                j2 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'RAHU') {
                j2 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planetst_' + i).value == 'KETU') {
                j2 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'GULIKA') {
                j2 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }



            h2 = h2 + j2 + " ";


        }

        if (h == 'HOUSE3') {
            deg = document.getElementById('degreet_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planetst_' + i).value == 'MERCURY') {
                j3 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'JUPITER') {
                j3 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'VENUS') {
                j3 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SATURN') {
                j3 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SUN') {
                j3 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MOON') {
                j3 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MARS') {
                j3 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'RAHU') {
                j3 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planetst_' + i).value == 'KETU') {
                j3 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'GULIKA') {
                j3 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            h3 = h3 + j3 + " ";


        }


        if (h == 'HOUSE4') {
            deg = document.getElementById('degreet_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planetst_' + i).value == 'MERCURY') {
                j4 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'JUPITER') {
                j4 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'VENUS') {
                j4 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SATURN') {
                j4 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SUN') {
                j4 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MOON') {
                j4 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MARS') {
                j4 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'RAHU') {
                j4 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planetst_' + i).value == 'KETU') {
                j4 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'GULIKA') {
                j4 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            h4 = h4 + j4 + " ";


        }

        if (h == 'HOUSE5') {
            deg = document.getElementById('degreet_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planetst_' + i).value == 'MERCURY') {
                j5 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'JUPITER') {
                j5 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'VENUS') {
                j5 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SATURN') {
                j5 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SUN') {
                j5 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MOON') {
                j5 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MARS') {
                j5 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'RAHU') {
                j5 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planetst_' + i).value == 'KETU') {
                j5 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planetst_' + i).value == 'GULIKA') {
                j5 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            h5 = h5 + j5 + " ";

        }

        if (h == 'HOUSE6') {
            deg = document.getElementById('degreet_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planetst_' + i).value == 'MERCURY') {
                j6 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'JUPITER') {
                j6 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'VENUS') {
                j6 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SATURN') {
                j6 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SUN') {
                j6 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MOON') {
                j6 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MARS') {
                j6 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'RAHU') {
                j6 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';

            }
            if (document.getElementById('planetst_' + i).value == 'KETU') {
                j6 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'GULIKA') {
                j6 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            h6 = h6 + j6 + " ";


        }

        if (h == 'HOUSE7') {
            deg = document.getElementById('degreet_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planetst_' + i).value == 'MERCURY') {
                j7 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'JUPITER') {
                j7 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'VENUS') {
                j7 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SATURN') {
                j7 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SUN') {
                j7 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MOON') {
                j7 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MARS') {
                j7 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'RAHU') {
                j7 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planetst_' + i).value == 'KETU') {
                j7 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planetst_' + i).value == 'GULIKA') {
                j7 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            h7 = h7 + j7 + " ";


        }

        if (h == 'HOUSE8') {
            deg = document.getElementById('degreet_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planetst_' + i).value == 'MERCURY') {
                j8 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'JUPITER') {
                j8 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'VENUS') {
                j8 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SATURN') {
                j8 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SUN') {
                j8 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MOON') {
                j8 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MARS') {
                j8 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'RAHU') {
                j8 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planetst_' + i).value == 'KETU') {
                j8 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'GULIKA') {
                j8 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            h8 = h8 + j8 + " ";


        }

        if (h == 'HOUSE9') {
            deg = document.getElementById('degreet_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planetst_' + i).value == 'MERCURY') {
                j9 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'JUPITER') {
                j9 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'VENUS') {
                j9 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SATURN') {
                j9 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SUN') {
                j9 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MOON') {
                j9 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MARS') {
                j9 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'RAHU') {
                j9 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planetst_' + i).value == 'KETU') {
                j9 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planetst_' + i).value == 'GULIKA') {
                j9 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }


            h9 = h9 + j9 + " ";


        }

        if (h == 'HOUSE10') {
            deg = document.getElementById('degreet_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planetst_' + i).value == 'MERCURY') {
                j10 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'JUPITER') {
                j10 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'VENUS') {
                j10 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SATURN') {
                j10 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SUN') {
                j10 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MOON') {
                j10 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MARS') {
                j10 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'RAHU') {
                j10 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planetst_' + i).value == 'KETU') {
                j10 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'GULIKA') {
                j10 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            h10 = h10 + j10 + " ";


        }

        if (h == 'HOUSE11') {
            deg = document.getElementById('degreet_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planetst_' + i).value == 'MERCURY') {
                j11 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'JUPITER') {
                j11 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'VENUS') {
                j11 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SATURN') {
                j11 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SUN') {
                j11 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MOON') {
                j11 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MARS') {
                j11 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'RAHU') {
                j11 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planetst_' + i).value == 'KETU') {
                j11 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'GULIKA') {
                j11 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            h11 = h11 + j11 + " ";

        }
        if (h == 'HOUSE12') {
            deg = document.getElementById('degreet_' + i).value.split('.');
            deg1 = deg[0] + '.' + deg[1];
            if (document.getElementById('planetst_' + i).value == 'MERCURY') {
                j12 = 'Me' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'JUPITER') {
                j12 = 'Ju' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'VENUS') {
                j12 = 'Ve' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SATURN') {
                j12 = 'Sa' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'SUN') {
                j12 = 'Su' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MOON') {
                j12 = 'Mo' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'MARS') {
                j12 = 'Ma' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'RAHU') {
                j12 = 'Ra' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
            }
            if (document.getElementById('planetst_' + i).value == 'KETU') {
                j12 = 'Ke' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + deg1 + '</span>';
            }

            if (document.getElementById('planetst_' + i).value == 'GULIKA') {
                j12 = 'Gk' + '<span style=color:#f90914>' + document.getElementById('retrogradet_' + i).value + '</span>' + " " + '<span style=color:#f90914>' + '</span>';
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
      

    if (r1 == document.getElementById('hdnr1').innerHTML)
    {
        document.getElementById('h1l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>'  + '</span>';
        document.getElementById('h2l1d01t').innerHTML = p2;
        document.getElementById('h3l1d01t').innerHTML = p3;
        document.getElementById('h4l1d01t').innerHTML = p4;
        document.getElementById('h5l1d01t').innerHTML = p5;
        document.getElementById('h6l1d01t').innerHTML = p6;
        document.getElementById('h7l1d01t').innerHTML = p7;
        document.getElementById('h8l1d01t').innerHTML = p8;
        document.getElementById('h9l1d01t').innerHTML = p9;
        document.getElementById('h10l1d01t').innerHTML = p10;
        document.getElementById('h11l1d01t').innerHTML = p11;
        document.getElementById('h12l1d01t').innerHTML = p12;
    }
    if (r1 == document.getElementById('hdnr2').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p12;
        document.getElementById('h2l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>' + '</span>';
        document.getElementById('h3l1d01t').innerHTML = p2; 
        document.getElementById('h4l1d01t').innerHTML = p3; 
        document.getElementById('h5l1d01t').innerHTML = p4; 
        document.getElementById('h6l1d01t').innerHTML = p5; 
        document.getElementById('h7l1d01t').innerHTML = p6; 
        document.getElementById('h8l1d01t').innerHTML = p7; 
        document.getElementById('h9l1d01t').innerHTML = p8;
        document.getElementById('h10l1d01t').innerHTML = p9; 
        document.getElementById('h11l1d01t').innerHTML = p10; 
        document.getElementById('h12l1d01t').innerHTML = p11; 
    }

    if (r1 == document.getElementById('hdnr3').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p11; 
        document.getElementById('h2l1d01t').innerHTML = p12;
        document.getElementById('h3l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>' +  '</span>';
        document.getElementById('h4l1d01t').innerHTML = p2; 
        document.getElementById('h5l1d01t').innerHTML = p3; 
        document.getElementById('h6l1d01t').innerHTML = p4; 
        document.getElementById('h7l1d01t').innerHTML = p5; 
        document.getElementById('h8l1d01t').innerHTML = p6; 
        document.getElementById('h9l1d01t').innerHTML = p7; 
        document.getElementById('h10l1d01t').innerHTML = p8; 
        document.getElementById('h11l1d01t').innerHTML = p9; 
        document.getElementById('h12l1d01t').innerHTML = p10; 
    }

    if (r1 == document.getElementById('hdnr4').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p10; 
        document.getElementById('h2l1d01t').innerHTML = p11; 
        document.getElementById('h3l1d01t').innerHTML = p12;
        document.getElementById('h4l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>'  + '</span>'; 
        document.getElementById('h5l1d01t').innerHTML = p2; 
        document.getElementById('h6l1d01t').innerHTML = p3; 
        document.getElementById('h7l1d01t').innerHTML = p4; 
        document.getElementById('h8l1d01t').innerHTML = p5; 
        document.getElementById('h9l1d01t').innerHTML = p6; 
        document.getElementById('h10l1d01t').innerHTML = p7; 
        document.getElementById('h11l1d01t').innerHTML = p8; 
        document.getElementById('h12l1d01t').innerHTML = p9; 
    }
    if (r1 == document.getElementById('hdnr5').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p9; 
        document.getElementById('h2l1d01t').innerHTML = p10; 
        document.getElementById('h3l1d01t').innerHTML = p11; 
        document.getElementById('h4l1d01t').innerHTML = p12;
        document.getElementById('h5l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>' + '</span>'; 
        document.getElementById('h6l1d01t').innerHTML = p2; 
        document.getElementById('h7l1d01t').innerHTML = p3; 
        document.getElementById('h8l1d01t').innerHTML = p4; 
        document.getElementById('h9l1d01t').innerHTML = p5; 
        document.getElementById('h10l1d01t').innerHTML = p6; 
        document.getElementById('h11l1d01t').innerHTML = p7; 
        document.getElementById('h12l1d01t').innerHTML = p8; 
    }

    if (r1 == document.getElementById('hdnr6').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p8; 
        document.getElementById('h2l1d01t').innerHTML = p9; 
        document.getElementById('h3l1d01t').innerHTML = p10; 
        document.getElementById('h4l1d01t').innerHTML = p11; 
        document.getElementById('h5l1d01t').innerHTML = p12;
        document.getElementById('h6l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>'+ '</span>';
        document.getElementById('h7l1d01t').innerHTML = p2; 
        document.getElementById('h8l1d01t').innerHTML = p3; 
        document.getElementById('h9l1d01t').innerHTML = p4; 
        document.getElementById('h10l1d01t').innerHTML = p5; 
        document.getElementById('h11l1d01t').innerHTML = p6; 
        document.getElementById('h12l1d01t').innerHTML = p7; 
    }
    if (r1 == document.getElementById('hdnr7').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p7; 
        document.getElementById('h2l1d01t').innerHTML = p8; 
        document.getElementById('h3l1d01t').innerHTML = p9; 
        document.getElementById('h4l1d01t').innerHTML = p10; 
        document.getElementById('h5l1d01t').innerHTML = p11; 
        document.getElementById('h6l1d01t').innerHTML = p12;
        document.getElementById('h7l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>'  + '</span>';
        document.getElementById('h8l1d01t').innerHTML = p2;
        document.getElementById('h9l1d01t').innerHTML = p3; 
        document.getElementById('h10l1d01t').innerHTML = p4; 
        document.getElementById('h11l1d01t').innerHTML = p5;
        document.getElementById('h12l1d01t').innerHTML = p6;
    }
    if (r1 == document.getElementById('hdnr8').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p6;
        document.getElementById('h2l1d01t').innerHTML = p7; 
        document.getElementById('h3l1d01t').innerHTML = p8;
        document.getElementById('h4l1d01t').innerHTML = p9; 
        document.getElementById('h5l1d01t').innerHTML = p10; 
        document.getElementById('h6l1d01t').innerHTML = p11; 
        document.getElementById('h7l1d01t').innerHTML = p12;
        document.getElementById('h8l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>' + '</span>';
        document.getElementById('h9l1d01t').innerHTML = p2;
        document.getElementById('h10l1d01t').innerHTML = p3;
        document.getElementById('h11l1d01t').innerHTML = p4; 
        document.getElementById('h12l1d01t').innerHTML = p5; 
    }

    if (r1 == document.getElementById('hdnr9').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p5;
        document.getElementById('h2l1d01t').innerHTML = p6;
        document.getElementById('h3l1d01t').innerHTML = p7;
        document.getElementById('h4l1d01t').innerHTML = p8;
        document.getElementById('h5l1d01t').innerHTML = p9; 
        document.getElementById('h6l1d01t').innerHTML = p10; 
        document.getElementById('h7l1d01t').innerHTML = p11;
        document.getElementById('h8l1d01t').innerHTML = p12; 
        document.getElementById('h9l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>' + '</span>'; 
        document.getElementById('h10l1d01t').innerHTML = p2; 
        document.getElementById('h11l1d01t').innerHTML = p3; 
        document.getElementById('h12l1d01t').innerHTML = p4; 
    }

    if (r1 == document.getElementById('hdnr10').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p4;
        document.getElementById('h2l1d01t').innerHTML = p5;
        document.getElementById('h3l1d01t').innerHTML = p6; 
        document.getElementById('h4l1d01t').innerHTML = p7; 
        document.getElementById('h5l1d01t').innerHTML = p8; 
        document.getElementById('h6l1d01t').innerHTML = p9; 
        document.getElementById('h7l1d01t').innerHTML = p10; 
        document.getElementById('h8l1d01t').innerHTML = p11; 
        document.getElementById('h9l1d01t').innerHTML = p12; 
        document.getElementById('h10l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>'  + '</span>';
        document.getElementById('h11l1d01t').innerHTML = p2; 
        document.getElementById('h12l1d01t').innerHTML = p3; 
    }

    if (r1 == document.getElementById('hdnr11').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p3;
        document.getElementById('h2l1d01t').innerHTML = p4; 
        document.getElementById('h3l1d01t').innerHTML = p5; 
        document.getElementById('h4l1d01t').innerHTML = p6; 
        document.getElementById('h5l1d01t').innerHTML = p7; 
        document.getElementById('h6l1d01t').innerHTML = p8; 
        document.getElementById('h7l1d01t').innerHTML = p9; 
        document.getElementById('h8l1d01t').innerHTML = p10; 
        document.getElementById('h9l1d01t').innerHTML = p11; 
        document.getElementById('h10l1d01t').innerHTML = p12; 
        document.getElementById('h11l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>' + '</span>'; 
        document.getElementById('h12l1d01t').innerHTML = p2; 
    }
    if (r1 == document.getElementById('hdnr12').innerHTML) {
        document.getElementById('h1l1d01t').innerHTML = p2;
        document.getElementById('h2l1d01t').innerHTML = p3; 
        document.getElementById('h3l1d01t').innerHTML = p4;
        document.getElementById('h4l1d01t').innerHTML = p5;
        document.getElementById('h5l1d01t').innerHTML = p6; 
        document.getElementById('h6l1d01t').innerHTML = p7; 
        document.getElementById('h7l1d01t').innerHTML = p8; 
        document.getElementById('h8l1d01t').innerHTML = p9; 
        document.getElementById('h9l1d01t').innerHTML = p10; 
        document.getElementById('h10l1d01t').innerHTML = p11; 
        document.getElementById('h11l1d01t').innerHTML = p12; 
        document.getElementById('h12l1d01t').innerHTML = p1 + " " + 'Asc' + " " + '<span style=color:#f90914>'  + '</span>'; 
    }

   
}




function  Cal_SunRiseSet_Gulika(dob,tob)
{
     var latit_val = document.getElementById('hdnlatit').value;
     var longit_val = document.getElementById('hdnlongit').value;
     var d1 = dob.split('/')
     var res = transition.getsunsetsunrise(document.getElementById('hdnlatit').value, document.getElementById('hdnlongit').value, document.getElementById('username').value, d1[0]+'/'+d1[1]+'/'+d1[2] + ' ' + '1:00:42 AM')
     var sssr = res.value;
     var srss1 = sssr.split('\r\n')
     var sr = srss1[0];
     var ss = srss1[1];
     var res = transition.getsunsetsunrisea(sr, document.getElementById('hdntzval').value, ss,d1[0]+'/'+d1[1]+'/'+d1[2] + ' ' + '1:00:42 AM')
     var actsrss = res.value;
     var sunrise = actsrss.Tables[0].Rows[0].IDOB;
     var sunset = actsrss.Tables[1].Rows[0].IDOB;
     
     document.getElementById('hdsunrise').value=sunrise;
     document.getElementById('hdsunset').value=sunset;
     
     document.getElementById("sunriseid").innerHTML="Sunrise time :---- " + sunrise;
     document.getElementById("sunsetid").innerHTML="Sunset time :---- " + sunset;
     
     var res = transition.getsunsetsunrise1(document.getElementById('hdnlatit').value, document.getElementById('hdnlongit').value, document.getElementById('username').value, d1[0] + '/' + d1[1] + '/' + d1[2] + ' ' + '1:00:42 AM')
     var sssr = res.value;
     var srss1 = sssr.split('\r\n')
     var sr = srss1[0];
     var ss = srss1[1];
     
     var res = transition.getsunsetsunriseanext(sr, document.getElementById('hdntzval').value, ss,d1[0]+'/'+d1[1]+'/'+d1[2] + ' ' + '1:00:42 AM')
     var actsrss = res.value;
     var sunrisenextday = actsrss.Tables[0].Rows[0].IDOB;
     //hoursob = trim(document.getElementById('hob').value);
     document.getElementById('hdsunrisenext').value=sunrisenextday;
     
     document.getElementById("sunrisenestid").innerHTML="Sunrise Next time :---- " + sunrisenextday;
     
     var res = transition.getsunsetsunrise2(document.getElementById('hdnlatit').value, document.getElementById('hdnlongit').value, document.getElementById('username').value, d1[0] + '/' + d1[1] + '/' + d1[2] + ' ' + '1:00:42 AM')
     var ssopd = res.value;
     var ssopd1 = ssopd.split('\r\n')
     var sr = ssopd1[0];
     var ss = ssopd1[1];
    
     var res = transition.getsunsetsunriseapre(sr, document.getElementById('hdntzval').value, ss,d1[0]+'/'+d1[1]+'/'+d1[2] + ' ' + '1:00:42 AM')
     var actsrss = res.value;
     var sunsetpreday = actsrss.Tables[1].Rows[0].IDOB;
     document.getElementById('hdsunsetpre').value=sunsetpreday;
     
     document.getElementById("sunsetpreid").innerHTML="Sunset Previous time :---- " + sunsetpreday;
      
     var tz = document.getElementById('hdntzo').value;
     var gulikads = transition.GulikaCalculate(document.getElementById('hdndob').value,document.getElementById('hdntob').value,sunsetpreday,sunrise,sunset,sunrisenextday,tz,latit_val,longit_val);
     var gulikadssplit = gulikads.value.split('/')
     
     document.getElementById("gulikaid").innerHTML="Gulika time :---- " + gulikadssplit[0] + " Minute";
     document.getElementById("ascendantid").innerHTML="Ascendantid time :---- " + gulikadssplit[2] + " Minute";
     document.getElementById("dayofweekid").innerHTML = "Day :---- " + gulikadssplit[1];

     return gulikadssplit[2];
     
}

function Cal_SunRiseSet_GulikaPageLoad(dob,tob,tz)
{
     var latit_val=document.getElementById('hdnlatit').value;
     var longit_val=document.getElementById('hdnlongit').value;
     var d1 = dob.split('/')
     var res = transition.getsunsetsunrise(document.getElementById('hdnlatit').value, document.getElementById('hdnlongit').value, document.getElementById('username').value, d1[1]+'/'+d1[0]+'/'+d1[2] + ' ' + '1:00:42 AM')
     var sssr = res.value;
     var srss1 = sssr.split('\r\n')
     var sr = srss1[0];
     var ss = srss1[1];
     var res = transition.getsunsetsunrisea(sr, document.getElementById('hdntzval').value, ss,d1[1]+'/'+d1[0]+'/'+d1[2] + ' ' + '1:00:42 AM')
     var actsrss = res.value;
     var sunrise = actsrss.Tables[0].Rows[0].IDOB;
     var sunset = actsrss.Tables[1].Rows[0].IDOB;
     
     document.getElementById('hdsunrise').value=sunrise;
     document.getElementById('hdsunset').value=sunset;
     
     document.getElementById("sunriseid").innerHTML="Sunrise time :---- " + sunrise;
     document.getElementById("sunsetid").innerHTML="Sunset time :---- " + sunset;
     
     var res = transition.getsunsetsunrise1(document.getElementById('hdnlatit').value, document.getElementById('hdnlongit').value, document.getElementById('username').value, d1[1] + '/' + d1[0] + '/' + d1[2] + ' ' + '1:00:42 AM')
     var sssr = res.value;
     var srss1 = sssr.split('\r\n')
     var sr = srss1[0];
     var ss = srss1[1];
     
     var res = transition.getsunsetsunriseanext(sr, document.getElementById('hdntzval').value, ss,d1[1]+'/'+d1[0]+'/'+d1[2] + ' ' + '1:00:42 AM')
     var actsrss = res.value;
     var sunrisenextday = actsrss.Tables[0].Rows[0].IDOB;
     //hoursob = trim(document.getElementById('hob').value);
     document.getElementById('hdsunrisenext').value=sunrisenextday;
     
     document.getElementById("sunrisenestid").innerHTML="Sunrise Next time :---- " + sunrisenextday;
     
     var res = transition.getsunsetsunrise2(document.getElementById('hdnlatit').value, document.getElementById('hdnlongit').value, document.getElementById('username').value, d1[1] + '/' + d1[0] + '/' + d1[2] + ' ' + '1:00:42 AM')
     var ssopd = res.value;
     var ssopd1 = ssopd.split('\r\n')
     var sr = ssopd1[0];
     var ss = ssopd1[1];
    
     var res = transition.getsunsetsunriseapre(sr, document.getElementById('hdntzval').value, ss,d1[1]+'/'+d1[0]+'/'+d1[2] + ' ' + '1:00:42 AM')
     var actsrss = res.value;
     var sunsetpreday = actsrss.Tables[1].Rows[0].IDOB;
     document.getElementById('hdsunsetpre').value=sunsetpreday;
     
     document.getElementById("sunsetpreid").innerHTML="Sunset Previous time :---- " + sunsetpreday;
      
     var gulikads = transition.GulikaCalculate(document.getElementById('hdndob').value,document.getElementById('hdntob').value,sunsetpreday,sunrise,sunset,sunrisenextday,tz,latit_val,longit_val);
     var gulikadssplit = gulikads.value.split('/')
     
     document.getElementById("gulikaid").innerHTML="Gulika time :---- " + gulikadssplit[0] + " Minute";
     document.getElementById("ascendantid").innerHTML="Ascendantid time :---- " + gulikadssplit[2] + " Minute";
     document.getElementById("dayofweekid").innerHTML="Day :---- " + gulikadssplit[1];
     
}