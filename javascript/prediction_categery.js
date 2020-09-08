
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


function fillcategery(event)
{
var keycode=event.keyCode?event.keyCode:event.which;
if(keycode==113)
   {
       if(document.activeElement.id=="categery")
           {
           
           
               
              document.getElementById('lstcategery').value="";
              //var compcode = $('hdncompcode').value;
              //var unit=$('hdnunitcode').value;          
              document.getElementById("divcategery").style.display="block";
              document.getElementById('divcategery').style.top=20+ "px" ;
              document.getElementById('divcategery').style.left=200+ "px";
              var extra1= document.getElementById('categery').value;
              document.getElementById('categery').focus();
              predictive_categery.fill_categery(extra1 ,callback_fillcategery)

         }
         
    }

      if(keycode==27)
                {

                 document.getElementById('divcategery').style.display="none";
                 document.getElementById('categery').focus()
                 return false;

                }

            else if(keycode==8 || keycode==46)
          {
              document.getElementById('categery').value="";
              return true;
           }

           else if(event.ctrlKey==true && keycode==88)
            {
               document.getElementById('categery').value="";
              // $('txtreason').focus();
               return true;
             }
            else if(keycode==9)
            {
              return keycode;
            }
            else if(keycode==13)
            {
              return false;
            }
            else
            {
              document.getElementById('categery').focus();
              return keycode;
            }    
               
    }
function callback_fillcategery(res)
{
   ds=res.value;
   if(ds!= null && typeof(ds) == "object" && ds.Tables[0].Rows.length > 0)
   {
       var pkgitem = document.getElementById("lstcategery");
       pkgitem.options.length = 0;
       pkgitem.options[0]=new Option("--Select categery--","0");
       pkgitem.options.length = 1;
       for (var i = 0  ;  i < ds.Tables[0].Rows.length;  ++i)
       {
         //pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].REASON_CODE+"-"+ds.Tables[0].Rows[i].REASON_NAME,ds.Tables[0].Rows[i].REASON_CODE);
           pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].CATEGERY, ds.Tables[0].Rows[i].CATEGERY);
         pkgitem.options.length;
       }
   }
  document.getElementById('lstcategery').focus();
   //document.getElementById("lstcategery").value="0";
   return false;
}
function oncliccategery(event) {
    var browser = navigator.appName;
var keycode=event.keyCode?event.keyCode:event.which;
   if(keycode==13 || event.type=="click")
   {
    if(document.activeElement.id=="lstcategery")
       {
          if(document.getElementById('lstcategery').value=="0")
           {
               document.getElementById('categery').value="";
               document.getElementById('divcategery').style.display="none";
               document.getElementById('categery').focus();
               return false;
           }
     
      // document.getElementById("divcategery").style.display="none";
       var page=document.getElementById('lstcategery').value;
       agencycodeglo=page;
        for(var k=0;k <= document.getElementById("lstcategery").length-1;k++)
               {
                  if(document.getElementById('lstcategery').options[k].value==page)
                   {
                       if (document.getElementById('lstcategery').options[k].value == page) {
                        if (browser != "Microsoft Internet Explorer") {
                            var abc = document.getElementById('lstcategery').options[k].textContent;
                        }
                        else {
                            var abc = document.getElementById('lstcategery').options[k].innerText;

                        }
                       var splitcategery = abc;
                       var str = splitcategery.split("~");
                       var agcd=str[0];
                       var dpcd=str[1];
                     document.getElementById('categery').value=agcd;
                       document.getElementById('categery').focus();
                       return false;          
                 }
               }
             }
    }
    else if(keycode==27)
    {
      document.getElementById('divcategery').style.display="none";
      document.getElementById('categery').focus();
      return false;
    }
}

function closelist(event)
{
var keycode=event.keyCode?event.keyCode:event.which;
if(keycode==27)
    {
      document.getElementById('divcategery').style.display="none";
      document.getElementById('categery').focus();
      return false;
    }

}


function save() {

    var page = document.getElementById('hiddenpage').value;
    var kk = "";
    var ss = "";
    var ds1 = "";
    for ( var i = 0; i < document.getElementById('lstcategery').options.length; ++i) {
        if (document.getElementById('lstcategery').options[i].selected == true) {
            ss = ss + document.getElementById('lstcategery').options[i].innerText + "$";
        }

    }

    if (document.getElementById('CheckBox1').checked == true) {
        kk = 1;
    }
    else {
        kk = 0;
    }
    if (ss != "") {
        ss = ss.slice(0, -1);
        if (document.getElementById('CheckBox1').checked == false && document.getElementById('CheckBox2').checked == false) {
            alert("Please Select Checkbox");
            return false;

        }
    }
    var res1 = predictive_categery.bind_desc(ss, kk);
    var ds1 = res1.value;
    document.getElementById('Divgrid1').style.top = 150 + "px";
    document.getElementById('Divgrid1').style.left = -220 + "px";
    document.getElementById('Divgrid1').style.BackColor = "Ivory";
    var temp_del1 = "";

    flg_req = "yes"
    var aa1 = "";
    var aa = "";
    var hs = 0;
    var hs1 = 0;
    //alert('kkk')
    //alert(document.getElementById("datagrid1").childNodes[0])
    document.getElementById('hdsviewgrid').style.display = "block";
   // $('hdsviewgrid').style.display = "block";
    //alert(document.getElementById("hdsviewgrid").children.length)
    if (document.getElementById("hdsviewgrid").children.length == "0") {
        klen = "0"
        //alert(klen)
    }
    else {

        klen = document.getElementById("Divgrid1").childNodes[0].childNodes[0].childNodes.length - 1;
        //alert(klen)
        //           klen=document.getElementById("hdsviewgrid").childNodes[0].childNodes[0].childNodes.length-1;
        IntializeNumber = klen + 1;
    }

    if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:500px;display:block") <= 0) {
        aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
    }

    buf1 += "<table  class='gridview' id='Divgrid1' runat='server' align='center' Width='300px' height='0px' style='border:1px;margin-left:250px; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
    buf1 += "<tr>"
    buf1 += "<td  bgcolor=#7DAAE3 style='height:10px;width:200px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "DESCRIPTION" + "</td>"
    buf1 += "<td  bgcolor=#7DAAE3 style='height:10px;width:200px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "DETAIL_DESCRIPTION" + "</td>"
    buf1 += "<td  bgcolor=#7DAAE3 style='height:10px;width:90px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "DETAIL" + "</td>"
   
    buf1 += "</tr>"

    len = 1;


    if (ds1.Tables[0].Rows.length > 0) {
        for (i = 0; i < ds1.Tables[0].Rows.length; ++i) {




            //klen = document.getElementById("hdsviewgrid").childNodes[0].childNodes[0].childNodes.length - 1;

            buf1 += "<tr>"


            buf1 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
            buf1 += "<input type='text' style='width:200px;' align='left' value='"+ds1.Tables[0].Rows[i]['DESCRIPTION']+"'  id='description_" + i + "'  >"
            buf1 += "</td>"

            buf1 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
            buf1 += "<input type='text' style='width:400px;' align='left' value='" + ds1.Tables[0].Rows[i]['DESCCLOB'] + "'  id='descclob_" + i + "' onMouseOver='javascript:return selectdescclob(this.id);'   >"
            buf1 += "</td>"

            buf1 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
            buf1 += "<Button  style='width:50px;' align='left' Text='Detail' value='Detail' AutoPostBack='true' id='detail_" + i + "' onClick='javascript:return selectdescclob(this.id);' >More...</Button>"
            buf1 += "</td>"

            buf1 += "<td    style='border:0px solid #7DAAE3;'  align='left' >"
            buf1 += "<input type='text' style='width:200px; display:none;' align='left' id='text_" + i + "' >"
            buf1 += "</td>"

           
            buf1 += "</tr>"
        } 
    }
    buf1 += "</table>"
    var hdsview = "";
    temp_del1 = aa + buf1.toString();
    temp_del1 = temp_del1.replace("<TBODY>", "")
    temp_del1 = temp_del1.replace("</TBODY>", "")
    //alert(temp_del1)
    document.getElementById('hdsviewgrid').innerHTML = temp_del1;
    return false;
}

function selectdescclob(res) {
      
    var kk = "";
    var ss = "";
    var ds1 = "";
//    for (var i = 0; i < document.getElementById('lstcategery').options.length; ++i) {
//        if (document.getElementById('lstcategery').options[i].selected == true) {
//            ss = ss + document.getElementById('lstcategery').options[i].innerText + "$";
//        }

//    }

//    if (document.getElementById('CheckBox1').checked == true) {
//        kk = 1;
//    }
//    else {
//        kk = 0;
//    }
//    if (ss != "") {
//        if (document.getElementById('CheckBox1').checked == false && document.getElementById('CheckBox2').checked == false) {
//            alert("Please Select Checkbox");
//            return false;

//        }
//    }
//    var res1 = predictive_categery.bind_desc(ss, kk);
//    var ds1 = res1.value;
    document.getElementById('div2').style.display= "block";
    var detail = res.split('_')
    var detail1 = detail[1];

    aTag = eval(document.getElementById("text_" + detail1))
    var btag;
    var leftpos = 0;
    var toppos = 0;
    do {
        aTag = eval(aTag.offsetParent);
        leftpos += aTag.offsetLeft;
        toppos += aTag.offsetTop;
        btag = eval(aTag)
    } while (aTag.tagName != "BODY" && aTag.tagName != "HTML");
    document.getElementById('div2').style.top = document.getElementById("text_" + detail1).offsetTop + toppos + "px";
    document.getElementById('div2').style.left = document.getElementById("text_" + detail1).offsetLeft + leftpos + "px";
    document.getElementById("TextBox2").value = document.getElementById("descclob_" + detail1).value;
}