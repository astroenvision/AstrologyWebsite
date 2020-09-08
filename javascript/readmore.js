


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
  

// data1show();
    
     

}






//function data1show()
//{

//var grididata=document.getElementById('link1').value;
//var val=readmore.datashow(grididata,execute_callback);
//  return false;
//}

//function execute_callback(val)
//{


//var ds=val.value;


////var elem = document.createElement("replace_div");
////elem.setAttribute("src", "\articles"+ ds.Tables[0].Rows[0]['IMAGE']);

//var image=ds.Tables[0].Rows[0]['IMAGE'];
//  var buf = new StringBuffer2();
//  var aa="";
//  $('replace_div').style.display = "block";
//  var hdsview="";
//  var klen="";
// 

//    if (document.getElementById("replace_div").innerHTML.indexOf("width:900px;display:block") <= 0)
//     {
//         aa = document.getElementById("replace_div").innerHTML.replace("</TBODY></TABLE>", "")
//     }
//     

//buf += "<tr>";
//buf+="<td>"
//buf += "<div id='imgdiv' runat='server' class='read_more_grid_img' <a href=''><img src='articles/"+image+"' style='width: 277px; height: 306px; float:left;' ;'/>"+"</div>"
//buf += "<div type='text'id='head' runat='server' class='read_more_grid' ;>" + ds.Tables[0].Rows[0]['HEADLINES'] + "</div>"
//buf += "<div type='text'id='fillstr' runat='server' class='read_more_grid_story'  ;>" + ds.Tables[0].Rows[0]['FILLSTORY'] + "</div>"

//buf+="</td>"
//buf += "</tr>";
//buf += "</table>";

//$("replace_div").innerHTML = buf.toString();
// $('replace_div').style.display = "block";
//$("replace_div").style.width = screen.availWidth;
//$("replace_div").style.height = screen.availHeight;

//return false;
//        
//    
//       
//               
//          
//        }
//        
        


  