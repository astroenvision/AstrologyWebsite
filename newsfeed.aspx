<%@ Page Language="C#" AutoEventWireup="true" CodeFile="newsfeed.aspx.cs" Inherits="newsfeed" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>News Feed</title>
     <link rel="Stylesheet" href="css/astrocss.css" type="text/css" />
    <link href="css/combine.css" type="text/css" rel="stylesheet" />
    <script type="text/javascript">

var popUpWin = 0;



function getopen(pagename)
{

if(popUpWin)
       {
            if(!popUpWin.closed) popUpWin.close();
       }

	popUpWin = window.open(''+ pagename +'','form','resizable=yes, status=no, toolbar=no, scrollbars=yes, location=no, menubar=no,addressbar=no')

}
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="Div1" class="maindiv" runat="server">
      <h1 class="astrocss">
            Astrology</h1>
     <div id="header" class="astrohead" runat="server">
     <ul>
        	<li ><a href="#" class="menu_Selact">HOME</a></li>
            <li><a href="#">PREDICTIVE SUPPORT</a></li>
            <li><a href="#">SIGNIFICATORS</a></li>
            <li><a href="#">RESEARCH TOOL</a></li>
            <li><a href="#">CHART INDEX</a></li>
               <li><a href="#">HORARY SIGNIFICATOR</a></li>
                <li><a href="#">HORARY KNOWLEDGE</a></li>
              <li><a href="#">ASTRO KNOWLEDGE</a></li>
            <li><a href="#">ABOUT US</a> </li>
            <li><a href="#">MY ACCOUNT</a></li>
            <li class="menu_last"><a href="#">LOG OUT</a></li>
        </ul>
        </div>
        
        
        <table style="height:300px;">
        <tr>
        <td>
        
        </td>
        </tr>
        </table>
        
         <div class="footer" id="foot" runat="server">
            <div>
               <ul>
        	<li ><a href="#" class="menu_Selact">HOME</a></li>
            <li><a href="#">PREDICTIVE SUPPORT</a></li>
            <li><a href="#">SIGNIFICATORS</a></li>
            <li><a href="#">RESEARCH TOOL</a></li>
            <li><a href="#">CHART INDEX</a></li>
               <li><a href="#">HORARY SIGNIFICATOR</a></li>
                <li><a href="#">HORARY KNOWLEDGE</a></li>
              <li><a href="#">ASTRO KNOWLEDGE</a></li>
            <li><a href="#">ABOUT US</a> </li>
            <li><a href="#">MY ACCOUNT</a></li>
            <li class="menu_last"><a href="#">LOG OUT</a></li>
        </ul>
              
            </div>
            <div style="margin-top: 12px;">
                Copyright 2012 Astrology.All right reserved</div>
        </div>
      </div>  
        
    </form>
</body>
</html>
