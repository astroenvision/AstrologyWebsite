<%@ Page Language="C#" AutoEventWireup="true" CodeFile="searchpage.aspx.cs" Inherits="searchpage" EnableEventValidation="false"   %>
<!doctype html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">

<meta charset="utf-8">
<title>Astorylogy</title>
   <meta name="viewport" content="width=device-width, initial-scale=1.0" />
<script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script>

<link type="text/css" rel="stylesheet" href="CSS/main.css">
<link type="text/css" rel="stylesheet" href="CSS/tabletsearchpage.css">
<link rel="Stylesheet" href="css/combine.css" type="text/css" />
<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Tangerine">
<link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Oxygen">
<link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Open+Sans">
<link href="http://fonts.googleapis.com/css?family=PT Sans Narrow" rel="stylesheet" type="text/css" />
<link href="http://fonts.googleapis.com/css?family=Marcellus" rel="stylesheet" type="text/css" />
<link rel="stylesheet" type="text/css" href="http://www.google.com/fonts/#QuickUsePlace:quickUse/Family:Yanone+Kaffeesatz">
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
<script type="text/javascript" language="javascript" src="javascript/searchresult.js"></script>
<script language="javascript" src="javascript/prototype.js" type="text/javascript"></script>
<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>

<style>
 nav select {
      display: none;
    }
 @media (max-width: 768px) {
	 nav ul     { display: none; }
		nav select { display: inline-block;}
     
    }
	</style>


    <script>
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
  
   
    <style type="text/css"></style>
</head>


<body id="body" oncontextmenu="return false"; onload="gridcall()";  >
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
            <li id="a7" runat="server"><a class="menu_Selact">Natal Predictive</a></li>
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
             <li id="Li4" runat="server"><a href="#">Natal Calculation</a></li>
             <li id="Li5" runat="server"><a href="#">Remedial</a></li>
            <li id='Li12' runat="server"><a  onclick='javascript:getopen("horary_illustration.aspx?usermail="+ document.getElementById("hdnuser").value + "&gropunder=" + "Natal")' style='cursor:pointer' >Natal Illustration</a></li>
            <li id="a10" runat="server"><a href="#">About Us</a> </li>
            <li id="a11" runat="server" class="menu_last"><a onclick='javascript:getopen1("login.aspx")' style='cursor:pointer'>Log Out</a></li>
        </ul>
    </div>
</div>

     <div class="mid_body" style=" padding-bottom: 74px;" >
 <div class="mid_sec">
 <div class="mid_over">
 
 
  <div id="Div1" class="div_header" >
       <div class="d_header_1 h_filters">    
       
    <span class="filterss">
   <asp:Label id="lbusername" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"  Text="Astrologer Name :" runat="server" >
   </asp:Label>
   <asp:Label id="astname" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"  runat="server" >
   </asp:Label>
  </span>
  
  <span class="filterss">
   <asp:Label id="Label3"  ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"  Text="Astrologer ID :" runat="server" >
   </asp:Label>
   <asp:Label id="astid" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"   runat="server" >
   </asp:Label>
   </span>
  <span class="filterss">
   
   <asp:Label id="Label5"  ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"  Text="Client Name :" runat="server" >
   </asp:Label>
   <asp:Label id="clientname" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"   runat="server" >
   </asp:Label>  
  </span>
  
  <span class="filterss">
  
   <asp:Label id="Label4"  ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"  Text="Client ID :" runat="server" >
   </asp:Label>
   <asp:Label id="clientid" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px"  runat="server" ></asp:Label>
  </span>
   
   
   </div>
 
 
 
    
        <div class="keywordcss d_header_2">
           <div> <asp:Label ID="Label1" class="new_font1"  runat="server" Text="Keyword" Font-Size="Small">
            </asp:Label> 
            
            <span>
                <asp:TextBox ID="k1" runat="server" BorderWidth="1px"  BorderColor="#6A6A6A" style="border-radius:5px;margin-left:41px; width:100px;"></asp:TextBox>
            </span>
            </div>
            
            <div>
            <asp:Label ID="Label2" class="new_font1" runat="server" Text="Categery[F2*]" Font-Size="Small">
            </asp:Label> 
            
            <span>
                <asp:TextBox ID="categery" Width="150" runat="server" BorderWidth="1px"
                    BorderColor="#6A6A6A" style="border-radius:5px; width:100px; margin:5px 10px 10px 13px">
                </asp:TextBox>
            </span>
            </div>
            
            <div>
            
            <span class="keyspancss" style="margin-left:0px;"><asp:CheckBox ID="CheckBox1" runat="server" /></span>
            <asp:Label ID="Label6" class="new_font1" runat="server" Text="All Of Them" Font-Size="Small">
            </asp:Label>
            
            
            </div>
            
            <div>
            <span class="keyspancss" style="margin-left:0px;"><asp:CheckBox ID="CheckBox2" runat="server" /></span>
           <asp:Label ID="Label7" class="new_font1" runat="server" Text="Any Of Them" Font-Size="Small">
            </asp:Label>
            
            
            </div>
        </div>
       
        
       <div class="d_header_3"> 
            <div><asp:Label ID="Label8" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px" runat="server" Text="Search By Planet"  >
            </asp:Label></div>
          <span class="filters">
            <asp:CheckBox ID="CheckBoxSun" runat="server"  /><asp:Label ID="LabelSun" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px" runat="server" Text="Sun" CssClass="back_clr" >
            </asp:Label>
            
          </span>
        <span class="filters">
           <asp:CheckBox ID="CheckBoxMoon" runat="server" /><asp:Label ID="LabelMoon" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px" runat="server" Text="Moon" CssClass="back_clr" >
           </asp:Label>
           
        </span>
       <span class="filters">
           <asp:CheckBox ID="CheckBoxMars" runat="server" /> <asp:Label ID="LabelMars" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px" runat="server" Text="Mars" CssClass="back_clr" >
</asp:Label>
               
            </span>
            <span class="filters">
           <asp:CheckBox ID="CheckBoxMercury" runat="server" /> <asp:Label ID="LabelMercury" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px" runat="server" Text="Mercury" CssClass="back_clr">
</asp:Label>
               
            </span>
            <span class="filters">
           <asp:CheckBox ID="CheckBoxJupitor" runat="server" /> <asp:Label ID="LabelJupitor" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px" runat="server" Text="Jupiter" CssClass="back_clr" >
</asp:Label>
                
            </span>
            <span class="filters">
           <asp:CheckBox ID="CheckBoxVenus" runat="server" /> <asp:Label ID="LabelVenus" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px" runat="server" Text="Venus"  CssClass="back_clr">
</asp:Label>
                
            </span>
            <span class="filters">
            <asp:CheckBox ID="CheckBoxSaturn" runat="server" /><asp:Label ID="LabelSaturn" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px" runat="server" Text="Saturn" CssClass="back_clr" >
</asp:Label>
               
            </span>
            <span class="filters">
           <asp:CheckBox ID="CheckBoxRahu" runat="server" /> <asp:Label ID="LabelRahu" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px" runat="server" Text="Rahu" CssClass="back_clr" >
</asp:Label>
                

            </span>
            <span class="filters">
            <asp:CheckBox ID="CheckBoxKetu" runat="server" /><asp:Label ID="LabelKetu" ForeColor="White" font-weight="600" font-family="Open Sans" font-size="11px" runat="server" Text="Ketu" CssClass="back_clr" >
</asp:Label>
                
            </span>
        
     </div></div>
       
      
       
       
         <div class="buttondivs">
                 <asp:LinkButton ID="D01" runat="server" 
                 class="per_btn"
                 >Search</asp:LinkButton>
                 
        
                  <asp:LinkButton ID="short1" runat="server" class="per_btn"
                
                 >Short Predictive</asp:LinkButton>

                 <asp:LinkButton ID="long1" runat="server"  class="per_btn"
                
                  >Long Predictive</asp:LinkButton>
                  
                    <asp:LinkButton ID="ImageButton1" runat="server" 
                class="per_btn">Vargas Chart</asp:LinkButton>
                     
            </div>
           
           
           
 <div class="loadingimage" id="img1"  runat ="server"  style="visibility:visible;">
 <img src="Image/preloader_transparent.gif" alt="hello"/>
 </div>  
 
  <div >
<asp:Label ID="labchart" CssClass="vargalabel" runat="server" Text="Chart" ></asp:Label></div>
<div >
<asp:DropDownList ID="vargaschart" runat="server" CssClass="vargas" ></asp:DropDownList>        
 </div>        
 
 
 <div id="whitediv"  class="div_curve" style="background-color: White; float:left;padding-right: 0px; padding-left: 0px; border-left-width: 0px; margin-left: 10px; border-right-width: 0px; width: 980px; padding-bottom: 9px;height: 360px;">
            

<div id="Divgrid1" class="searchdiv">
    <table >
    <tr>
    <td runat="server" id="hdsviewgrid" style="width:600px;" align="left" ></td>
    </tr>
    </table></div>
      
      
      
    

<div id="Divgrid2" style= "overflow:auto;display:none; width:600px; height:260px;" >
    <table >
    <tr>
    <td runat="server" id="hdsviewgrid2" style="width:600px;" align="left" ></td>
    </tr>
    </table></div>
    
         <div id="clinetnamediv" runat="server"  class="div_name_id_div_searchpage" >
             <div><asp:Button ID="cross" runat="server" Text="X"  CssClass="vargas_1_search" /></div>
             <div id="readmorediv" runat="server" ></div>
              
     
    </div>
    
<div id="vargasdiv" runat="server" style="left:150px; margin-left: 92px; margin-top: -26px;">



            <div class="column1" id="rashiid">
        
            	<div class="column-div1">	
                	 <span >
                     <asp:Label ID="h1l1" runat="server" Text="" >
                    </asp:Label>
                    </span>
                </div>
                 
                 <div class="column-divr1">
                     <span>
                     <asp:Label ID="h1r" runat="server" Text=""  >
                    </asp:Label></span>
                 </div>
                    
                <div class="column-div2">	
                	 <span >
                    <asp:Label ID="h2l1" runat="server" Text="" >
                    </asp:Label>
                   </span>
                  
                    
                </div>
                
                 <div class="column-divr2">
                      <span>
                    <asp:Label ID="h2r" runat="server" Text="" >
                    </asp:Label>
                   </span>
                 </div>
                 
                 
                <div class="column-div3">	
                	<span >
                     <asp:Label ID="h3l1" runat="server" Text=""  >
                    </asp:Label>
                    </span>
                </div>
                
                 <div class="column-divr3">
                     <span>
                     <asp:Label ID="h3r" runat="server" Text=""   >
                    </asp:Label>
                    </span>
                 </div>
                
                <div class="column-div4">	
                	 <span >
                    <asp:Label ID="h4l1" runat="server" Text=""  >
                    </asp:Label>
                    </span>
                </div>
                
                <div class="column-divr4">
                    <span>
                    <asp:Label ID="h4r" runat="server" Text="" >
                    </asp:Label>
                    </span>
                 </div>
                
                <div class="column-div5">	
                	<span >
                    <asp:Label ID="h5l1" runat="server" Text=""  >
                    </asp:Label>
                   </span>
               </div>
                
                 <div class="column-divr5">
                    <span>
                    <asp:Label ID="h5r" runat="server" Text=""  >
                    </asp:Label>
                    </span>
                 </div>
                
                <div class="column-div6">	
                	 <span>
                    <asp:Label ID="h6l1" runat="server" Text=""  >
                    </asp:Label>
                    </span>
                </div>
                
                 <div class="column-divr6">
                   <span>
                    <asp:Label ID="h6r" runat="server" Text=""  >
                    </asp:Label>
                    </span>
                 </div>
                
                <div class="column-div7">	
                	 <span >
                    <asp:Label ID="h7l1" runat="server" Text="" >
                    </asp:Label>
                    </span>
                </div>
                
                <div class="column-divr7">
                  <span>
                    <asp:Label ID="h7r" runat="server" Text=""  >
                    </asp:Label>
                  </span>
                </div>
                
                <div class="column-div8">	
                	<span >
                    <asp:Label ID="h8l1" runat="server" Text=""  >
                    </asp:Label></span>
                </div>
                
                 <div class="column-divr8">
                  <span>
                   <asp:Label ID="h8r" runat="server" Text=""  >
                   </asp:Label>
                  </span>
                </div>
                
                
                <div class="column-div9">	
                	<span >
                    <asp:Label ID="h9l1" runat="server" Text=""  >
                    </asp:Label>
                    </span>
                </div>
                
                <div class="column-divr9">
                  <span>
                    <asp:Label ID="h9r" runat="server" Text="" >
                    </asp:Label>
                   </span>
                </div>
                
                <div class="column-div10">	
                	<span>
                    <asp:Label ID="h10l1" runat="server" Text=""  >
                    </asp:Label>
                    </span>
                </div>
                
                <div class="column-divr10">
                  <span>
                    <asp:Label ID="h10r" runat="server" Text=""  >
                    </asp:Label>
                  </span>
                </div>
                
                <div class="column-div11">	
                	<span >
                     <asp:Label ID="h11l1" runat="server" Text=""  >
                    </asp:Label>
                   </span>
                </div>
                
                 <div class="column-divr11">
                  <span>
                     <asp:Label ID="h11r" runat="server" Text=""  >
                    </asp:Label>
                   </span>
                </div>
                
                <div class="column-div12">	
                	<span >
                    <asp:Label ID="h12l1" runat="server" Text=""  >
                    </asp:Label>
                   </span>
                </div>
                
                 <div class="column-divr12">
                  <span>
                    <asp:Label ID="h12r" runat="server" Text="" >
                    </asp:Label>
                  </span>
                </div>
                
            	<figure class="fixedratio"></figure>
             </div>   
            </div>  
            
        
            
        </div>
            
       
        </div>  
        </div>  
        </div>  
  <%--      
 <div class="menu_mainf" >
	<div class="menuf" id="nav">
             <ul>
           <li id="a1l" runat="server" ><a href="#" >HOME</a></li>
           <li id="a2l" runat="server"><a href="#" class="menu_Selact">PREDICTIVE SUPPORT</a></li>
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
    
  </div></div>--%>
   
    <table>
     <tr>
     <td>      
    <div id="divcategery" style="position:absolute;top:0px;left:0px;border:none;display:none;z-index:1;">
    <table cellpadding="0" cellspacing="0">
    <tr>
    <td>
    <asp:ListBox ID="lstcategery" Width="200px" Height="75px" runat="server" CssClass="btextlist"  SelectionMode="Multiple">
    </asp:ListBox>
    </td>
    </tr>
    </table>
    </div>
     </td>
             </tr>
              </table>
              
            
             
             <input type="hidden" runat="server" id="Hiddends" />
             <input type="hidden" runat="server" id="Hiddenval" /> 
             
             <input type="hidden" runat="server" id="hiddens" /> 
             <input type="hidden" runat="server" id="hiddenss" /> 
              <input type="hidden" runat="server" id="hiddenkk" /> 
              <input type="hidden" runat="server" id="hiddenrashi" /> 
              <input type="hidden" runat="server" id="hiddenkey" /> 
              <input type="hidden" runat="server" id="hiddenplanets" /> 
               
             <input type="hidden" runat="server" id="Hidden6" /> 
             <input type="hidden" runat="server" id="Hidden1" /> 
             <input type="hidden" runat="server" id="Hidden2" /> 
             <input type="hidden" runat="server" id="Hidden3" /> 
             <input type="hidden" runat="server" id="Hidden4" /> 
             <input type="hidden" runat="server" id="Hidden5" /> 
             <input type="hidden" runat="server" id="hiddenchart" /> 
             <input type="hidden" runat="server" id="Hiddenv" />
             <input type="hidden" runat="server" id="Hiddenj" />
             <input type="hidden" runat="server" id="Hiddenk" />
             <input type="hidden" runat="server" id="Hidden8" />
             <input type="hidden" runat="server" id="Hidden9" />
                <input type="hidden" runat="server" id="hdnuser" />
<input type="hidden" runat="server" id="Hidden7" /> 
    </form>
</body>
</html>

