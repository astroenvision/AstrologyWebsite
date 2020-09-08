function StringBuffer2() {
    this.buffer = [];
}


StringBuffer2.prototype.append = function append(string) {
    this.buffer.push(string);
    return this;
}

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

function login1() {
 
        var username=document.getElementById('txtusername1').value;
        var password = document.getElementById('txtpwd1').value;

            if ((username == "ASTROLOGY" || username == "astrology") && (password == "ASTROLOGY" || password == "astrology")) {
               // window.location.href = "Default.aspx";
                window.open("Default.aspx");
            }
            else {
                alert("Invalid User Name or Password");
                return false;
            }

    return false;

}


function loginoutenduser() {
     document.getElementById('loginid').innerHTML="Login";
     document.getElementById('logoutid').innerHTML="<a href='astro_registration.aspx?user=1'>Register Now ?</a>";
     document.getElementById('middleloginid').style.display='block';
     PageMethods.LogOut();
     return false;
}

function radio1butt()
{
    document.getElementById('r1').checked=true;
    document.getElementById('r2').checked=false;
    document.getElementById('linkabutton1').style.display='none';
    document.getElementById('linkabutton2').style.display='none';
     document.getElementById('linkabutton3').style.display='block';
    return false;
   
   

}


function radio2butt()
{

    document.getElementById('r2').checked=true;
    document.getElementById('r1').checked=false;
     document.getElementById('linkabutton1').style.display='block';
    document.getElementById('linkabutton2').style.display='block';
    document.getElementById('linkabutton3').style.display='none';
     return false;
       
}

function buttonhide()
{
 document.getElementById('linkabutton1').style.display='block';
 document.getElementById('linkabutton2').style.display='block';
 document.getElementById('linkabutton3').style.display='none';
  
 //document.getElementById('imgdiv').innerHTML=document.getElementById('head1').innerHTML;

}



function data1show(id)
{

var grididata=id;

  var buf = new StringBuffer2();
  var aa="";
  $('replace_div').style.display = "block";
  var hdsview="";
  var klen="";
 

    if (document.getElementById("replace_div").innerHTML.indexOf("width:900px;display:block") <= 0)
     {
         aa = document.getElementById("replace_div").innerHTML.replace("</TBODY></TABLE>", "")
     }
      buf.append("<table cellpadding='0' cellspacing='0' border='0px ' width='100px'>")
      buf.append("<tr style=border:1px solid #0000FF;' ><td class='mobshow'><input type='image' src='image/closelabel(1).gif' id='btnredump' onclick='javascript:return closeissuedespatch();'></td>");
     buf.append("</tr>")


buf += "<tr><td  class='mobshow_gid' 'align:left'   id='data1_" + i + "'>" +grididata + "</td>";
       
buf += "</tr>";
buf += "</table>";

$("replace_div").innerHTML = buf.toString();
 $('replace_div').style.display = "block";
$("replace_div").style.width = screen.availWidth;
$("replace_div").style.height = screen.availHeight;

return false;
        
    
       
               
          
        }
        
        

        
function closeissuedespatch()
{
    $("replace_div").style.display = 'none';
  
  return false;
  }
  
  
  
  
  function GetData(code)
{
document.getElementById('question').style.display="block";
document.getElementById ('backbtndiv_id').style.display='block';
login.Show_Harary_Questions(code,calldata)

//for showing the heading on question page......
document .getElementById('question').innerHTML="<h1 class='questioncat_h1'>"+code+"</h1>";
return false;

}

function calldata(res)
{
var ds=res.value;
for(var i=0;i<ds.Tables[0].Rows.length;i++)
{
var code=ds.Tables[0].Rows[i].SUB_CODE;

//alert(code);
fun(code);
}
}

function fun(code)
{
document.getElementById ('leftcontainer_id').style.display="none";
//document.getElementById('question').innerHTML+="<div style=\"width:100%;font-weight:bold;text-align:left;padding:1%;display: list-item;list-style-type:square;\"><a style='cursor:pointer;cursor:Hand;text-decoration:none;color:#4597a0;' onclick='div_show()'>"+code+"</div>";
document.getElementById('question').innerHTML+="<li><a onclick='div_show()'>"+code+"</li>";
document.getElementById('question').style.display="Block";
}
   
function BackFunction()
{
document.getElementById('leftcontainer_id').style.display='block';
document.getElementById('question').style.display="none";
document.getElementById('question').innerHTML="";
document.getElementById ('backbtndiv_id').style.display='none';
return false ;
}
