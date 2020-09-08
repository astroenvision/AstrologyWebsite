<%@ Page Language="C#" AutoEventWireup="true" CodeFile="chartindex.aspx.cs" Inherits="chartindex" EnableEventValidation="true"%>

<!doctype html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">

     
<meta charset="utf-8">
<title>Astorylogy</title>
   <meta name="viewport" content="width=device-width, initial-scale=1.0" />
     <link rel="Stylesheet" href="css/astrocss.css" type="text/css" />
     <link type="text/css" rel="stylesheet" href="CSS/main.css">
<link type="text/css" rel="stylesheet" href="CSS/tabletchartindex.css">
<link href="css/combine.css" type="text/css" rel="stylesheet" />
<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine">
<link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Oxygen">
<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Open+Sans">
<link href="http://fonts.googleapis.com/css?family=PT Sans Narrow" rel="stylesheet" type="text/css" />
<link href="http://fonts.googleapis.com/css?family=Marcellus" rel="stylesheet" type="text/css" />
<link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Yanone+Kaffeesatz">

<script type="text/javascript" language="javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
<script type="text/javascript" language="javascript" src="javascript/chartindex.js"></script>
<script language="javascript" src="javascript/prototype.js" type="text/javascript"></script>
<script type="text/javascript">
<script type="text/javascript" language="javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
	<style>
 nav select {
      display: none;
    }
 @media (max-width: 768px) {
	 nav ul     { display: none; }
		nav select { display: inline-block;}
     
    }
	</style>
	<script type="text/javascript" language="javascript">
	 // DOM ready
	 $(function() {
	   
      // Create the dropdown base
      $("<select />").appendTo("nav");
      
      // Create default option "Go to..."
      $("<option />", {
         "selected": "selected",
         "value"   : "",
         "text"    : "Go to..."
      }).appendTo("nav select");
      
      // Populate dropdown with menu items
      $("nav a").each(function() {
       var el = $(this);
       $("<option />", {
           "value"   : el.attr("href"),
           "text"    : el.text()
       }).appendTo("nav select");
      });
      
	   // To make dropdown actually work
	   // To make more unobtrusive: http://css-tricks.com/4064-unobtrusive-page-changer/
      $("nav select").change(function() {
        window.location = $(this).find("option:selected").val();
      });
	 
	 });
	</script>
	
	
	<script>
var popUpWin = 0;
function getopen(pagename)
{

if(popUpWin)
       {
            if(!popUpWin.closed) popUpWin.close();
       }

	popUpWin = window.open(''+ pagename +'','form','resizable=yes, status=no, toolbar=no, scrollbars=yes, location=no, menubar=no,addressbar=no')

}
function getopen1(pagename)
{

window.parent.location.href="login.aspx";
}

    </script>
 
   
  
   
   
    
</head>

<body id="body" oncontextmenu="return false";  onload="gridcall()"; >
    <form id="form1" runat="server">
    
    <div class="head_main">
    	<div class="head">
        <div class="head_logo">	<img src="IMAGES/logo.jpg" /></div>
        <div class="head_ad"><script type="text/javascript"><!--

                                 google_ad_client = "ca-pub-9581515182700674";

                                 /* 468x60, created 6/17/11 */

                                 google_ad_slot = "6032384492";

                                 google_ad_width = 468;

                                 google_ad_height = 60;

//-->

</script>

<script type="text/javascript"

src="http://pagead2.googlesyndication.com/pagead/show_ads.js">

</script></div>
        </div>
        <div style="clear:both"></div>
</div>
       
       <div class="menu_main_lower" >
	<div class="menu" id="nav">
    	<ul>
        	<li id="a1" runat="server"><a href="#" >HOME</a></li>
        	<li id="a2" runat="server"><a onclick='javascript:getopen("homenewpage.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>PREDICTIVE SUPPORT</a></li>
            <li id="a3" runat="server"><a onclick='javascript:getopen("significator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>SIGNIFICATORS</a></li>
            <li id="a4" runat="server"><a onclick='javascript:getopen("astro_tree_view.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>ASTRO KNOWLEDGE</a></li>
             <li id="a5" runat="server"><a >RESEARCH TOOL</a>
            <ul >
                        <li><a  onclick='javascript:getopen("ResearchTool.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Status Of Planet</a></li>
                        <li><a onclick='javascript:getopen("research_dashamsha.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Dashamsh Chart</a></li>
                        
                    </ul></li>
            <li id="a6" runat="server"><a href="#" class="menu_Selact">CHART INDEX</a></li>
            <li id="a7" runat="server"><a onclick='javascript:getopen("horarysignificator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>HORARY SIGNIFICATOR</a></li>
            <li id="a8" runat="server"><a onclick='javascript:getopen("hoarary_knowledge.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>HORARY KNOWLEDGE</a></li>
            <li id="a9" runat="server"><a onclick='javascript:getopen("myaccount.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>MY ACCOUNT</a></li>
            <li id="a10" runat="server"><a href="#">ABOUT US</a> </li>
            <li id="a11" runat="server" class="menu_last"><a onclick='javascript:getopen1("login.aspx")' style='cursor:pointer'>LOG OUT</a></li>
        </ul>
    </div>
</div>

 <div class="mid_body" style=" padding-bottom: 74px;" >
 <div class="mid_sec" >
 <div class="mid_over">
      
  <div id="Div2" class="div_header" >
    
    




   <div class="d_header_1 h_filtersc"> 
   <span class="filterss">
   <asp:Label id="lbusername" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"  Text="Astrologer Name :" runat="server" >
   </asp:Label>
   
  <asp:Label id="astname" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"    runat="server" >
   </asp:Label>
  </span>
  
  <span class="filterss">
   <asp:Label id="Label3"  ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"  Text="Astrologer ID :" runat="server" >
   </asp:Label>
  
   <asp:Label id="astid" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"    runat="server" >
   </asp:Label>
  </span>
   
   <span class="filterss">
   <asp:Label id="Label5"  ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"  Text="Client Name" runat="server" >
   </asp:Label>
   
  <asp:Label id="clientname" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"  runat="server" >
   </asp:Label>
   </span>
   
   <span class="filterss">
   <asp:Label id="Label4"  ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"  Text="Client ID :" runat="server" >
   </asp:Label>
   
  <asp:Label id="clientid" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"   runat="server" >
   </asp:Label>
   </span>
   
   
   </div>
    </div>
   
          
          
          
    <div id="whitediv2"  class="div_curve" style="background-color: White; width: 98%;  margin-left: 5px; border-width: 2px; margin-right: 0px; height:400px;"> 
	<table>   

 <tr>
 <div class="d_header_3">
    <p>
    Choose Single Or Multiple Combination's From Following Vargas / Avastha's</p>
   </div>
 <div class="d_header_3">
    <p>Choose : <input type="radio" ID="RadioButton1" name="vargas" value="Shad Varga" runat="server" />Shad Varga
    <input type="radio" ID="RadioButton2" name="vargas" value="Sapta Varga" runat="server" class="vargt" />Sapta Varga
   
   <input type="radio" ID="RadioButton3" name="vargas" value="Das Varga" runat="server" class="vargt" />Dash Varga
   <input type="radio" ID="RadioButton4" name="vargas" value="Shodash Varga" runat="server" class="vargt" /> Shodash Varga
   <input type="radio" ID="Radio1" name="vargas" value="Multiple Varga" checked="true" runat="server" class="vargt" />Single / Multiple Varga</p>
   </div>
   
 <td style="padding-left:00px;border:1px ;border-color:#7DAAE3; ">
   <div id="Divgrid1" class="divg" style= "display:none; " >
    <table >
    <tr>
    <td runat="server" id="hdsviewgrid" style="width:97%; " align="left"  ></td>
    </tr>
    </table></div></td>
      </tr>
     
      </table> 
   
       </div> 
     
     
     <div id="clinetnamediv" runat="server"  class="div_name_id_div_searchpage"  style="width:700px; height: 300px; margin-left:5px;" >
         <div class="colum-td-head" style="width:97% !important; margin-left: 0px;">
             <asp:Label ID="Label2" runat="server" Text="Astro Research" font-weight="600" font-family="Open Sans" font-size="11px" ForeColor="White" ></asp:Label>
             <asp:Button ID="cross" runat="server" Text="X" style="margin-left: 553px; margin-top: -19px;"  /></div>
           
             <div id="palnet_div" style="width:140px; float:left;" font-weight="600" font-family="Open Sans  !important;" font-size="11px" ForeColor="White" runat="server">Planet
             </div>
          
           <div id="rashi_div" style="width:140px; float:left;" font-weight="600" font-family="Open Sans" font-size="11px" ForeColor="White" runat="server">Rashi
           </div>
           
           <div id="varga_div" style="width:140px; float:left;" font-weight="600" font-family="Open Sans" font-size="11px" ForeColor="White" runat="server">Varga
           </div>
           
           <div id="client_name"  style="width:140px; float:left;" font-weight="600" font-family="Open Sans" font-size="11px" ForeColor="White" runat="server">Client Name
           </div>
           
           <div id="client_id"  style="width:140px; float:left;" font-weight="600" font-family="Open Sans" font-size="11px" ForeColor="White" runat="server">Client Id
           </div>
           
           <div style="width:140px;height:200px; float:left;"><asp:Label ID="pl" runat="server" Text="" ></asp:Label></div>
           <div style="width:140px;height:200px; float:left;"><asp:Label ID="ra"  runat="server" Text=""></asp:Label></div>
           <div style="width:140px;height:200px; float:left;"><asp:Label ID="va" runat="server" Text=""></asp:Label></div>
           <div style="width:140px;height:200px; float:left;"><asp:Label ID="cn" runat="server" Text=""></asp:Label></div>
           <div style="width:140px;height:200px; float:left;"><asp:Label ID="cm" runat="server" Text=""></asp:Label></div>
     </div>
     
     
      </div>
   
  
 </div>
    </div>
    <div class="menu_mainf" >
	<div class="menuf" id="nav">
    	<ul>
        	<li id="a1l" runat="server"><a href="#" >HOME</a></li>
        	<li id="a2l" runat="server"><a onclick='javascript:getopen("homenewpage.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>PREDICTIVE SUPPORT</a></li>
            <li id="a3l" runat="server"><a onclick='javascript:getopen("significator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>SIGNIFICATORS</a></li>
            <li id="a4l" runat="server"><a onclick='javascript:getopen("astro_tree_view.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>ASTRO KNOWLEDGE</a></li>
             <li id="a5l" runat="server"><a >RESEARCH TOOL</a>
            <ul >
                        <li><a  onclick='javascript:getopen("ResearchTool.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Status Of Planet</a></li>
                        <li><a onclick='javascript:getopen("research_dashamsha.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Dashamsh Chart</a></li>
                        
                    </ul></li>
            <li id="a6l" runat="server"><a href="#" class="menu_Selact">CHART INDEX</a></li>
            <li id="a7l" runat="server"><a onclick='javascript:getopen("horarysignificator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>HORARY SIGNIFICATOR</a></li>
            <li id="a8l" runat="server"><a onclick='javascript:getopen("hoarary_knowledge.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>HORARY KNOWLEDGE</a></li>
            <li id="a9l" runat="server"><a onclick='javascript:getopen("myaccount.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>MY ACCOUNT</a></li>
            <li id="a10l" runat="server"><a href="#">ABOUT US</a> </li>
            <li id="a11l" runat="server" class="menu_last"><a onclick='javascript:getopen1("login.aspx")' style='cursor:pointer'>LOG OUT</a></li>
        </ul>
    </div>

    
  

</div>
    
     
      <input type="hidden" runat="server" id="Hidden4" />
    <input type="hidden" runat="server" id="hiddendateformat" />
    <input type="hidden" runat="server" id="hdnastname" />
    <input type="hidden" runat="server" id="hdnastid" />
    <input type="hidden" runat="server" id="hdnclientid" />
    <input type="hidden" runat="server" id="Hclmail" />
    <input type="hidden" runat="server" id="Hclname" />
    <input type="hidden" runat="server" id="Hastmail" />
    <input type="hidden" runat="server" id="Hastname" />
         <input type="hidden" runat="server" id="hdnuser" /></form>
    </form>
    
    
</body>
</html>
