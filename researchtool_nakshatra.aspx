﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="researchtool_nakshatra.aspx.cs" Inherits="researchtool_nakshatra" EnableEventValidation="false"%>

<!doctype html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">

     
<meta charset="utf-8">
<title>Astrology</title>
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
<script type="text/javascript" language="javascript" src="javascript/researchtool_nakshatra.js"></script>
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
       
       
      
      <div class="menu_main_lower" id="horarydiv" runat="server" >
	<div class="menu" id="nav">
    	<ul>
        	<li id='Li1' runat="server"><a  href="#" >Home</a></li>
        	<li id='Li9' runat="server"><a  onclick='javascript:getopen("myaccount.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>My Account</a></li>   
             <li id="Li2" runat="server"><a  href="#">Horary Yoga</a>
            <ul >
                        <li><a >Calculate Horary Yoga</a></li>
                        <li><a >Calculate Karyasiddhi Yoga</a></li>
                        
                    </ul></li>
            <li id='Li3' runat="server"><a  href="#"  >Nature Of Query</a></li>
            <li id='Li7' runat="server"><a  onclick='javascript:getopen("horarysignificator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer' >Horary Significator</a></li>
            <li id='Li8' runat="server"><a  onclick='javascript:getopen("hoarary_knowledge.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer' >Horary Knowledge</a></li>
            <li id='Li13' runat="server"><a href="javascript:void(0);">Calculation</a>
            <ul>
                 <li><a href="#">Horary Calculation</a></li>
                 <li><a href="#">Probable Query</a></li>
            </ul>
            </li>
             <li id='Li6' runat="server"><a  onclick='javascript:getopen("horary_illustration.aspx?usermail="+ document.getElementById("hdnuser").value + "&gropunder=" + "Horary")' style='cursor:pointer' >Horary Illustration</a></li>
            <li id='Li10' runat="server"><a  href="#">About us</a> </li>
            <li class="menu_last" id='Li11' runat="server"><a  onclick='javascript:getopen1("login.aspx")' style='cursor:pointer'>Log Out</a></li>
        </ul>
    </div>
</div>

    <div class="menu_main_lower"  id="nataldiv" runat="server" >
	<div class="menu" id="nav">
    	<ul>
        	<li id="a1" runat="server"><a href="#" >Home</a></li>
        	<li id="a9" runat="server"><a  onclick='javascript:getopen("myaccount.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'">My Account</a></li>
            <li id="a6" runat="server"><a href="#">Natal Yoga</a></li>
            <li id="a7" runat="server"><a href="#">Natal Predictive</a></li>
            <li id="a3" runat="server"><a onclick='javascript:getopen("significator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Natal Significators</a></li>
            <li id="a4" runat="server"><a onclick='javascript:getopen("astro_tree_view.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Natal Knowledge</a></li>
            <li id="a5" runat="server"><a >Research Tool</a>
           <ul>
                        <li><a  onclick='javascript:getopen("ResearchTool.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Planets in Various Awastha’s in Varga’s  </a></li>
                        <li><a  onclick='javascript:getopen("ResearchTool_awastha.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Planets in Awastha’s – Planetary war etc</a></li>
                        <li><a  onclick='javascript:getopen("researchtool_conj_rashi.aspx?usermail="+ document.getElementById("hdnuser").value+ "&filt=" + "Without Conjunction")' style='cursor:pointer'>Planets in Rashi’s & House’s in Varga’s</a></li>
                        <li><a onclick='javascript:getopen("researchtool_conj_rashi.aspx?usermail="+ document.getElementById("hdnuser").value+ "&filt=" + "With Conjunction")' style='cursor:pointer'>Conjunction of Chosen Planets in Rashi and Houses in Varga’s</a></li>
                        <li><a onclick='javascript:getopen("researchtool_conjunction.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Conjunction of chosen Planets in Varga’s</a></li>
                        <li><a onclick='javascript:getopen("research_tool_any.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Conjunction of Planets – Number of Planets</a></li>
                        <li><a  onclick='javascript:getopen("researchtool_nakshatra.aspx?usermail="+ document.getElementById("hdnuser").value+ "&filt=" + "Without Conjunction")' style='cursor:pointer'>Search the  Single or Multiple Planets on Basis of Multiple Nakashtra/Constellation</a></li>
                        <li><a  onclick='javascript:getopen("researchtool_nakshatra.aspx?usermail="+ document.getElementById("hdnuser").value+ "&filt=" + "With Conjunction")' style='cursor:pointer'>Search the Conjuction of Planets in Single or Multiple Nakashtra’s/Constellation’s</a></li>
                        <li><a  onclick='javascript:getopen("researchtool_aspect.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Search for Aspects of Planet’s</a></li>
                        <li><a onclick='javascript:getopen("research_dashamsha.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Search for Awastha of Planets in Dashamsha</a></li>
                        <li><a onclick='javascript:getopen("ResearchTool_Driskkan.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>Driskkan Division</a></li>
            </ul>
            </li>
             <li id="Li4" runat="server"><a  href="#">Natal Calculation</a></li>
             <li id="Li5" runat="server"><a href="#">Remedial</a></li>
            <li id='Li12' runat="server"><a  onclick='javascript:getopen("horary_illustration.aspx?usermail="+ document.getElementById("hdnuser").value + "&gropunder=" + "Natal")' style='cursor:pointer' >Natal Illustration</a></li>
            <li id="a10" runat="server"><a href="#">About Us</a> </li>
            <li id="a11" runat="server" class="menu_last"><a onclick='javascript:getopen1("login.aspx")' style='cursor:pointer'>Log Out</a></li>
        </ul>
    </div>
</div>


 <div class="mid_body" style=" padding-bottom: 74px;" >
 <div class="mid_sec" >
 <div class="mid_over">
      
  <div id="Div2" class="div_header" >
    
    




   <div class="d_header_1 h_filtersc"> 
   
  
  <span class="filterss">
   <asp:Label id="Label3"  ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"  Text="Astrologer ID :" runat="server" >
   </asp:Label>
  
   <asp:Label id="astid" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"    runat="server" >
   </asp:Label>
  </span>
   
  <span class="filterss">
<asp:Label ID="client" runat="server" Text="Select Client Group" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"></asp:Label>
<asp:DropDownList ID="clgroup" CssClass="drpo_homenew" runat="server"></asp:DropDownList>
  </span>
  <span class="filterss">
<asp:DropDownList ID="grcl"    CssClass="drpo_homenewcl" runat="server" ></asp:DropDownList> 
</span>
 
   
   </div>
    </div>
   
          
         
          
    <div id="whitediv2"  class="div_curve" style="background-color: White; width: 98%;  margin-left: 5px; border-width: 2px; margin-right: 0px; height: 400px;"> 
	<table>   

 <tr>
  <div id="e1" runat="server" class="d_header_3">
    <p>
    Choose Single or Multiple Combination of Planets’s in Nakashtra’s / Constellation   - For Individual or Group of chart </p>
     <p id="sn" runat="server">
    Explanation – Astrologer. can choose , A single or Multiple Planet’s Position in One or More Nakashtra / constellation  - For Individual or Group of Chart. </p>
   </div>
   <div id="e2" runat="server"  class="d_header_3">
    <p>
    Choose Multiple planet’s in Single of Multiple Nakashtra’s - In Individual or a Group of chart</p>
     <p id="mn" runat="server">
   Explanation : - Astrologer can search the conjunction of two or more Planets in Single of Multiple Nakashtra’s / Constellation’s</p>
   </div>
    <div class="d_header_3">
    <p>Choose : <input type="checkbox" ID="csu" value="SUN" runat="server" class="vargt"/>SUN
   <input type="checkbox" ID="cmo"  value="MOON" runat="server" class="vargt" />MOON
   <input type="checkbox" ID="cma"  value="MARS" runat="server" class="vargt" />MARS
   <input type="checkbox" ID="cme"  value="MERCURY" runat="server" class="vargt" /> MERCURY
   <input type="checkbox" ID="cju"  value="JUPITER"  runat="server" class="vargt" />JUPITER
   <input type="checkbox" ID="cve"  value="VENUS" runat="server" class="vargt" />VENUS
   <input type="checkbox" ID="csa"  value="SATURN"  runat="server" class="vargt" />SATURN
   <input type="checkbox" ID="cra"  value="RAHU"  runat="server" class="vargt" />RAHU
   <input type="checkbox" ID="cke"  value="KETU"  runat="server" class="vargt" />KETU
    
       
        </p>

        <p>
            <span class="filterss">   
 <asp:LinkButton ID="cal" class="per_btn"   runat="server"  Text="Calculate" />
</span>
        </p>
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
     
     
      <div id="clinetnamediv" runat="server"  style="width:976px; float: left;height: auto; overflow: auto;display:none; margin-left:5px; margin-top:-153px;  background-color: #FFFFFF; border: 1px solid #E3E3E3;  box-shadow: 2px 2px 5px #000000;" >
         <div class="colum-td-head" style="width:97% !important; margin-left: 0px;">
             <asp:Label ID="Label2" runat="server" Text="Astro Research" font-weight="600" font-family="Open Sans" font-size="11px" ForeColor="White" ></asp:Label>
             <asp:Button ID="cross" runat="server" Text="X" style="margin-left: 804px; margin-top: 0px;"  />
         </div>
           <table>
           <tr>
           <td>
           <div style="width:976px;height:auto; text-align:center;">
           <asp:Label ID="qry" runat="server" Text=""  font-weight="600" font-family="Open Sans" font-size="16px" ></asp:Label></div>
           </td>
           </tr>
           <tr></tr>
           <tr>
           <td>
           <div style="width:976px;text-align:center;">
           <asp:Label ID="Total" runat="server" Text="Total"  font-weight="600" font-family="Open Sans" font-size="16px" ></asp:Label></div>
           </td>
           </tr>
           <tr></tr>
           </table>
           <div id="v1" style="width:976px;overflow:auto; margin-left:5px;">
           <div id="Div1"   style="width:950px;overflow:auto; margin-left:5px;  border:1px solid;">
           <div  id="Dv1"   style="width:950px; margin-left:5px;  border:1px solid;">
           <div id="client_name"  style="width:200px; float:left;" font-weight="600" font-family="Open Sans" font-size="11px" ForeColor="White" runat="server">Client Name
           </div>
           
           <div id="client_id"  style="width:200px; float:left;" font-weight="600" font-family="Open Sans" font-size="11px" ForeColor="White" runat="server">Client Id
           </div>
           
           <div id="palnet_div" style="width:200px; float:left;" font-weight="600" font-family="Open Sans  !important;" font-size="11px" ForeColor="White" runat="server">Planet
             </div>
          
           <div id="rashi_div" style="width:200px; float:left;" font-weight="600" font-family="Open Sans" font-size="11px" ForeColor="White" runat="server">Nakshatra
           </div>
           </div>
           
           
           <div  id="Div9"   style="width:950px; height:130px; overflow:auto; margin-left:5px; margin-top:20px; border:1px solid;">
           <div style="width:200px;height:200px; float:left;"><asp:Label ID="pl" runat="server" Text="" ></asp:Label></div>
           <%--<div style="width:140px;height:200px; float:left;"><asp:Label ID="ra"  runat="server" Text=""></asp:Label></div>--%>
           <div style="width:200px;height:200px; float:left;"><asp:Label ID="ra" runat="server" Text=""></asp:Label></div>
           <div style="width:200px;height:200px; float:left;"><asp:Label ID="cn" runat="server" Text=""></asp:Label></div>
           <div style="width:200px;height:200px; float:left;"><asp:Label ID="cm" runat="server" Text=""></asp:Label></div>
     </div>
        </div>
        
         <div  style="width:950px; overflow:auto; margin-left:5px; margin-top:20px; border:1px solid;">
         <div  id="Div3"   style="width:950px; margin-left:5px;  border:1px solid;">
         <div id="Div4"   style="width:170px; float:left;" font-weight="600" font-family="Open Sans" font-size="11px" ForeColor="White" runat="server">Planet
           </div>
           <div id="Div5"   style="width:170px; float:left;" font-weight="600" font-family="Open Sans" font-size="11px" ForeColor="White" runat="server">Nakshatra
           </div>
           <div id="Div6"  style="width:170px; float:left;" font-weight="600" font-family="Open Sans" font-size="11px" ForeColor="White" runat="server">Total
           </div>
           <div id="Div7"  style="width:170px;float:left;"  font-weight="600" font-family="Open Sans" font-size="11px" ForeColor="White" runat="server">Percentage
           </div>
           <div id="Div8"  style="width:250px;float:left;"  font-weight="600" font-family="Open Sans" font-size="11px" ForeColor="White" runat="server">Nummber Of Chart
           </div>
           </div>
           <div id="iv1"   style="width:950px; height:130px; overflow:auto; margin-left:5px; margin-top:20px; border:1px solid;">
           <div style="width:170px;height:14px; float:left;"><asp:Label ID="pn" runat="server" Text=""></asp:Label></div>
           <div style="width:170px;height:140px; float:left;"><asp:Label ID="rn" runat="server" Text=""></asp:Label></div>
           <div style="width:170px;height:140px; float:left;"><asp:Label ID="tn"  runat="server" Text=""></asp:Label></div>
           <div style="width:170px;height:140px; float:left;"><asp:Label ID="per"  runat="server" Text=""></asp:Label></div>
           <div style="width:250px;height:140px; float:left;"><asp:Label ID="noc" runat="server" Text=""></asp:Label></div>
           </div>
           </div>
     </div></div>
     
     
     
 </div>
 </div>
 </div>
    <%--<div class="menu_mainf" >
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
            <li id="a6l" runat="server"><a >CHART INDEX</a></li>
            <li id="a7l" runat="server"><a onclick='javascript:getopen("horarysignificator.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>HORARY SIGNIFICATOR</a></li>
            <li id="a8l" runat="server"><a onclick='javascript:getopen("hoarary_knowledge.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>HORARY KNOWLEDGE</a></li>
            <li id="a9l" runat="server"><a onclick='javascript:getopen("myaccount.aspx?usermail="+ document.getElementById("hdnuser").value)' style='cursor:pointer'>MY ACCOUNT</a></li>
            <li id="a10l" runat="server"><a href="#">ABOUT US</a> </li>
            <li id="a11l" runat="server" class="menu_last"><a onclick='javascript:getopen1("login.aspx")' style='cursor:pointer'>LOG OUT</a></li>
        </ul>
    </div>

    
  

</div>--%>
    
     
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
         <input type="hidden" runat="server" id="Hdnna" /></form>
    </form>
    
    
</body>
</html>
