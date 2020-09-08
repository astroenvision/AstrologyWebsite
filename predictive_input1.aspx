<%@ Page Language="C#" AutoEventWireup="true" CodeFile="predictive_input1.aspx.cs" Inherits="predictive_input1"  EnableEventValidation="false" %>
<%@ register TagPrefix="uc1" TagName="Topbar" Src="~/topbarnew.ascx"%>
<%@ register TagPrefix="uc2" TagName="Leftbar" Src="~/Leftbar.ascx"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">



<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>PREDICTIVE INPUT1</title>
    <script type="text/javascript" language="javascript" src="javascript/predictiveinput1.js"></script>
    
    <%--<link href="css/combine.css" type="text/css" rel="stylesheet" />--%>
     
   <%-- this is for prototype--%>
     
    <script language="javascript" src="javascript/prototype.js" type="text/javascript">
</script>
    <style type="text/css">
        
    </style>
</head>
<body id="body"  style="background-color:#f3f6fd;margin:0px 0px 0px 0px">
<form id="form1" runat="server">
 


<table cellpadding="0" cellspacing="0">
<tr>
<td colspan="2"><uc1:topbar id="Topbar1" runat="server" Text="extentions"></uc1:topbar></td>
</tr>
</table>




<table>
<tr> <td>   

<table border="0" cellpadding="0" cellspacing="0"  width="100%">
<tr>
<td style="width:27px;"></td>
<td style="background-image:url(image/corner-left.jpg);width:11px; background-position:right center; background-repeat:no-repeat; height:20px;"></td>

<td style="width:150PX;font-family:Verdana;text-align:right;font-size:10px;background-color:#a0bfeb; height:20px;"><center><b>PREDICTIVE INPUT 1</b></center></td>
<%-- <td style="width:150PX;font-family:Verdana;text-align:right;font-size:10px;background-color:#a0bfeb; height:25px;"><center><b> ASTRO EXTENTIONS</b></center></td>--%>
<td style="background-image:url(image/corner-right.jpg); background-repeat:no-repeat; height:25px;width:11px"></td>
<td style="width:770px"><table cellpadding="0" cellspacing="0"><tr><td style="background-color:#a0bfeb;width:770px; height:3px;"></td></tr></table></td>
</tr>
</table>         

</td>
</tr> 

</table>
          


<table id="outeroutertbl" cellpadding="0" cellspacing="0" width="800px" style="margin-left:25px; margin-top:10px; ">
<tr>
<td>
<div id="maindiv" style= "overflow:auto; width:950px;  height:550px;" >



<table id="outertbl" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="innertbl1" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="pLabel" runat="server" Text="Planet" ></asp:Label></td>
<td><asp:DropDownList ID="f1planet" runat="server" Width="100px" ></asp:DropDownList></td>

<td><asp:Label ID="pin" runat="server" Text="in House" ></asp:Label></td>
<td><asp:DropDownList ID="f1house" runat="server" Width="100px"  ></asp:DropDownList></td>


<td><asp:Label ID="pin1" runat="server" Text="Aspected by"></asp:Label></td>
<td><asp:DropDownList ID="f1aceptplanet" runat="server" Width="100px"></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="anplabel" runat="server" Text="and Planet"></asp:Label></td>
<td><asp:DropDownList ID="f1aplanet" runat="server" Width="100px" ></asp:DropDownList></td>

<td><asp:Label ID="inabel2" runat="server" Text="in House"></asp:Label></td>
<td><asp:DropDownList ID="f1ahouse" runat="server" Width="100px" ></asp:DropDownList></td>
<td><asp:Label ID="label15" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f1chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>

<tr>
<td><asp:Label ID="Label5" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f1page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label4" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f1book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label13" runat="server" Text="Unique id"></asp:Label></td>
<td><asp:TextBox ID="f1unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>

<tr>

<td><asp:Label ID="f1key" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f1filter" runat="server" Width="100px" ></asp:TextBox></td>


<td><asp:Button ID="f1_save" runat="server" Text="save" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>

<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="innertbl" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f1detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f1id" runat="server" Text="1" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f1div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table97" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f1grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>	










<table id="f2table" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table95" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label182" runat="server"  Text="Dispositor of House"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f2dhouse" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label183" runat="server" Text="in House" ></asp:Label></td>
<td><asp:Dropdownlist ID="f2house" runat="server" Width="100px"></asp:Dropdownlist></td>
<td><asp:Label ID="Label20" runat="server" Text="Unique id"></asp:Label></td>
<td><asp:TextBox ID="f2unique" runat="server" Width="100px" ></asp:TextBox></td>



</tr>

<tr>
<td><asp:Label ID="Label184" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f2page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label185" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f2book" runat="server" Width="100px" ></asp:TextBox></td>
</tr>
<tr>
<td><asp:Label ID="Label186" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f2filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label187" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:Dropdownlist ID="f2chart" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Button ID="f2save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table96" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f2detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f2id" runat="server" Text="2" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f2div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table1" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f2grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>









<table id="f3table" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="f3table" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label1" runat="server"  Text="Planet"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f3planet" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label2" runat="server" Text="in House" ></asp:Label></td>
<td><asp:Dropdownlist ID="f3house" runat="server" Width="100px"></asp:Dropdownlist></td>
<td><asp:Label ID="Label10" runat="server" Text="Aspected by Lord of House" ></asp:Label></td>
<td><asp:Dropdownlist ID="f3lohhouse" runat="server" Width="100px"></asp:Dropdownlist></td>



</tr>

<tr>
<td><asp:Label ID="Label3" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f3page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label6" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f3book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label21" runat="server" Text="Unique id"></asp:Label></td>
<td><asp:TextBox ID="f3unique" runat="server" Width="100px" ></asp:TextBox></td>


</tr>
<tr>
<td><asp:Label ID="Label7" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f3filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label8" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:Dropdownlist ID="f3chart" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Button ID="f3save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table4" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f3detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f3id" runat="server" Text="3" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f3div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table5" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f3grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>







<table id="f4table" cellpadding="0" cellspacing="0"  
        style="border:2px solid #7DAAE3; margin-top:20px; width: 500px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table3" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label11" runat="server"  Text="Lord of House"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f4loh" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label12" runat="server" Text="Rashi" ></asp:Label></td>
<td><asp:Dropdownlist ID="f4rashi" runat="server" Width="100px"></asp:Dropdownlist></td>
</tr>

<tr>
<td><asp:Label ID="Label14" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f4page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label16" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f4book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label22" runat="server" Text="Unique id"></asp:Label></td>
<td><asp:TextBox ID="f4unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>
<tr>
<td><asp:Label ID="Label17" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f4filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label18" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:Dropdownlist ID="f4chart" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Button ID="f4save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table6" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f4detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f4id" runat="server" Text="4" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f4div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table7" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f4grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>







<table id="f5table" cellpadding="0" cellspacing="0"  
        style="border:2px solid #7DAAE3; margin-top:20px; width: 500px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table8" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label23" runat="server"  Text="Dispositor of Planet"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f5dop" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label24" runat="server" Text=" in Rashi" ></asp:Label></td>
<td><asp:Dropdownlist ID="f5rashi" runat="server" Width="100px"></asp:Dropdownlist></td>
</tr>

<tr>
<td><asp:Label ID="Label25" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f5page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label26" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f5book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label27" runat="server" Text="Unique id"></asp:Label></td>
<td><asp:TextBox ID="f5unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>
<tr>
<td><asp:Label ID="Label28" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f5filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label29" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:Dropdownlist ID="f5chart" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Button ID="f5save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table9" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f5detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f5id" runat="server" Text="5" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f5div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table10" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f5grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>







<table id="f6table" cellpadding="0" cellspacing="0"  
        style="border:2px solid #7DAAE3; margin-top:20px; width: 500px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table11" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label9" runat="server"  Text="Planet"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f6planet" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label19" runat="server" Text=" in Rashi" ></asp:Label></td>
<td><asp:Dropdownlist ID="f6rashi" runat="server" Width="100px"></asp:Dropdownlist></td>
<td><asp:Label ID="label33" runat="server" Text="in House [f2*]" ></asp:Label></td>
<td><asp:TextBox ID="f6house" runat="server" Width="100px"></asp:TextBox></td>
</tr>

<tr>
<td><asp:Label ID="Label30" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f6page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label31" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f6book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label32" runat="server" Text="Unique id"></asp:Label></td>
<td><asp:TextBox ID="f6unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>
<tr>
<td><asp:Label ID="Label1133" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f6filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label1234" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:Dropdownlist ID="f6chart" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Button ID="f6save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table12" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f6detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f6id" runat="server" Text="6" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f6div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table13" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f6grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>









<table id="f7table" cellpadding="0" cellspacing="0"  
        style="border:2px solid #7DAAE3; margin-top:20px; width: 500px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table14" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label34" runat="server"  Text="Planet"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f7planet" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label35" runat="server" Text=" With ben/mal" ></asp:Label></td>
<td><asp:Dropdownlist ID="f7benmal" runat="server" Width="100px"></asp:Dropdownlist></td>
<td><asp:Label ID="label36" runat="server" Text="in House [f2*]" ></asp:Label></td>
<td><asp:TextBox ID="f7house" runat="server" Width="100px"></asp:TextBox></td>
</tr>

<tr>
<td><asp:Label ID="Label37" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f7page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label38" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f7book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label39" runat="server" Text="Unique id"></asp:Label></td>
<td><asp:TextBox ID="f7unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>
<tr>
<td><asp:Label ID="Label40" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f7filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label41" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:Dropdownlist ID="f7chart" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Button ID="f7save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table15" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f7detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f7id" runat="server" Text="7" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f7div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table16" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f7grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>









<table id="f8table" cellpadding="0" cellspacing="0"  
        style="border:2px solid #7DAAE3; margin-top:20px; width: 500px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table17" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label42" runat="server"  Text="Lord of House"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f8loh" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label43" runat="server" Text=" in House" ></asp:Label></td>
<td><asp:Dropdownlist ID="f8house" runat="server" Width="100px"></asp:Dropdownlist></td>
<td><asp:Label ID="label44" runat="server" Text="Aspected by Lord of House" ></asp:Label></td>
<td><asp:Dropdownlist ID="f8ahouse" runat="server" Width="100px" ></asp:Dropdownlist></td>

</tr>

<tr>
<td><asp:Label ID="Label45" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f8page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label46" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f8book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label47" runat="server" Text="Unique id"></asp:Label></td>
<td><asp:TextBox ID="f8unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>
<tr>
<td><asp:Label ID="Label48" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f8filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label49" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:Dropdownlist ID="f8chart" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Button ID="f8save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table18" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f8detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f8id" runat="server" Text="8" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f8div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table19" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f8grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>








<table id="f9table" cellpadding="0" cellspacing="0"  
        style="border:2px solid #7DAAE3; margin-top:20px; width: 500px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table20" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label50" runat="server"  Text="Lord Of House"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f9loh" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label51" runat="server" Text=" with Ben/Mal" ></asp:Label></td>
<td><asp:Dropdownlist ID="f9benmal" runat="server" Width="100px"></asp:Dropdownlist></td>
<td><asp:Label ID="label52" runat="server" Text="In House" ></asp:Label></td>
<td><asp:Dropdownlist ID="f9house" runat="server" Width="100px" ></asp:Dropdownlist></td>

</tr>

<tr>
<td><asp:Label ID="Label53" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f9page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label54" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f9book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label55" runat="server" Text="Unique id"></asp:Label></td>
<td><asp:TextBox ID="f9unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>
<tr>
<td><asp:Label ID="Label56" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f9filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label57" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:Dropdownlist ID="f9chart" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Button ID="f9save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table21" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f9detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f9id" runat="server" Text="9" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f9div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table22" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f9grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>









<table id="f10table" cellpadding="0" cellspacing="0"  
        style="border:2px solid #7DAAE3; margin-top:20px; width: 500px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table23" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label58" runat="server"  Text="Lord Of House"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f10loh" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label59" runat="server" Text=" Between Ben/Mal" ></asp:Label></td>
<td><asp:Dropdownlist ID="f10benmal" runat="server" Width="100px"></asp:Dropdownlist></td>

</tr>

<tr>
<td><asp:Label ID="Label61" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f10page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label62" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f10book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label63" runat="server" Text="Unique id"></asp:Label></td>
<td><asp:TextBox ID="f10unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>
<tr>
<td><asp:Label ID="Label64" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f10filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label65" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:Dropdownlist ID="f10chart" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Button ID="f10save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table24" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f10detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f10id" runat="server" Text="10" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f10div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table25" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f10grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>









<table id="f11Table" cellpadding="0" cellspacing="0"  
        style="border:2px solid #7DAAE3; margin-top:20px; width: 500px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table26" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label60" runat="server"  Text="Planet"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f11planet" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label66" runat="server" Text=" Between Ben/Mal" ></asp:Label></td>
<td><asp:Dropdownlist ID="f11benmal" runat="server" Width="100px"></asp:Dropdownlist></td>

</tr>

<tr>
<td><asp:Label ID="Label67" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f11page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label68" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f11book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label69" runat="server" Text="Unique id"></asp:Label></td>
<td><asp:TextBox ID="f11unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>
<tr>
<td><asp:Label ID="Label70" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f11filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label71" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:Dropdownlist ID="f11chart" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Button ID="f11save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table27" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f11detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f11id" runat="server" Text="11" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f11div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table28" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f11grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>










<table id="f12table" cellpadding="0" cellspacing="0"  
        style="border:2px solid #7DAAE3; margin-top:20px; width: 500px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table29" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label72" runat="server"  Text="Planet"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f12planet" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label73" runat="server" Text=" in Deblitation" ></asp:Label></td>
<td><asp:Dropdownlist ID="f12deb" runat="server" Width="100px"></asp:Dropdownlist></td>

</tr>

<tr>
<td><asp:Label ID="Label74" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f12page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label75" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f12book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label76" runat="server" Text="Unique id"></asp:Label></td>
<td><asp:TextBox ID="f12unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>
<tr>
<td><asp:Label ID="Label77" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f12filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label78" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:Dropdownlist ID="f12chart" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Button ID="f12save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table30" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f12deatil" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f12id" runat="server" Text="12" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f12div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table31" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f12grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>

<table id="f13table" cellpadding="0" cellspacing="0"  
        style="border:2px solid #7DAAE3; margin-top:20px; width: 500px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table36" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label87" runat="server"  Text="Lord of House"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f13loh" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label88" runat="server" Text=" in Deblitation" ></asp:Label></td>
<td><asp:Dropdownlist ID="f13deb" runat="server" Width="100px"></asp:Dropdownlist></td>

</tr>

<tr>
<td><asp:Label ID="Label89" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f13page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label90" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f13book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label91" runat="server" Text="Unique id"></asp:Label></td>
<td><asp:TextBox ID="f13unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>
<tr>
<td><asp:Label ID="Label92" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f13filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label93" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:Dropdownlist ID="f13chart" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Button ID="f13save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table37" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f13deatil" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f13id" runat="server" Text="13" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f13div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table38" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f13grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>












</div>
</td>
</tr>
</table>




<table>
<tr>
<td>      
    <div id="f1divmultipleplanet" style="border:none;display:none;z-index:1;">
    <table cellpadding="0" cellspacing="0">
    <tr>
    <td>
    <asp:ListBox ID="f1lstmultipleplanet" Width="110px" Height="75px" runat="server" CssClass="btextlist"  SelectionMode="Multiple">
    </asp:ListBox>
    </td>
    </tr>
    </table>
    </div>
   </td> 
    

    <td>
    <div id="f1divmultiplehouse" style=" margin-left:150px; display:none;display:none;z-index:1;">
    <table cellpadding="0" cellspacing="0">
    <tr>
    <td>
    <asp:ListBox ID="f1lstmultiplehouse" Width="110px" Height="75px" runat="server" CssClass="btextlist"  SelectionMode="Multiple">
    </asp:ListBox>
    </td>
    </tr>
    </table>
    </div>
    </td>
   
    <td>
    <div id="f1divmultiplerashi" style=" margin-left:110px;display:none;display:none;z-index:1;">
    <table cellpadding="0" cellspacing="0">
    <tr>
    <td>
    <asp:ListBox ID="f1lstmultiplerashi" Width="110px" Height="75px" runat="server" CssClass="btextlist"  SelectionMode="Multiple">
    </asp:ListBox>
    </td>
    </tr>
    </table>
    </div>
     </td>
     </tr>
        </table>











<input type="hidden" runat="server" id="tblfields"/>
<input type="hidden" runat="server" id="hiddendateformat"/>
<input type="hidden" runat="server" id="fields" />
<input type="hidden" runat="server" id="Hiddentxtextentions" /> 
<input type="hidden" runat="server" id="hdnuserid" /> 
<input type="hidden" runat="server" id="hiddenmodtxtextentions" />
  <input type="hidden" runat="server" id="key" />
  <input type="hidden" runat="server" id="mhiddenfilter" /> 
  <input type="hidden" runat="server" id="f7hiddenfilter" /> 
  <input type="hidden" runat="server" id="f8hiddenfilter" /> 
  <input type="hidden" runat="server" id="f9hiddenfilter" />
  <input type="hidden" runat="server" id="f10hiddenfilter" />
  <input type="hidden" runat="server" id="f11hiddenfilter" />
  <input type="hidden" runat="server" id="f12hiddenfilter" />
  <input type="hidden" runat="server" id="f13hiddenfilter" />
  <input type="hidden" runat="server" id="f14hiddenfilter" />
  <input type="hidden" runat="server" id="f15hiddenfilter" />
  <input type="hidden" runat="server" id="f16hiddenfilter" />
  <input type="hidden" runat="server" id="f17hiddenfilter" />
  <input type="hidden" runat="server" id="f18hiddenfilter" />
  <input type="hidden" runat="server" id="f19hiddenfilter" />
  <input type="hidden" runat="server" id="f20hiddenfilter" />
   <input type="hidden" runat="server" id="mname" />
   <input type="hidden" runat="server" id="f7name" />
   <input type="hidden" runat="server" id="f8name" />
<input type="hidden" runat="server" id="f2hiddenkey" />
<input type="hidden" runat="server" id="f3hiddenkey" />
<input type="hidden" runat="server" id="f4hiddenkey" />
<input type="hidden" runat="server" id="f5hiddenkey" />
<input type="hidden" runat="server" id="inhousevalue" />
<input type="hidden" runat="server" id="lordwithlordhidden"/>
</form>
</body>
</html>
