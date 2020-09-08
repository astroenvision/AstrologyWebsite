<%@ Page Language="C#" AutoEventWireup="true" CodeFile="predictive_input.aspx.cs" Inherits="predictive_input"  EnableEventValidation="false" %>
<%@ register TagPrefix="uc1" TagName="Topbar" Src="~/topbarnew.ascx"%>
<%@ register TagPrefix="uc2" TagName="Leftbar" Src="~/Leftbar.ascx"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PREDICTIVE INPUT</title>
    <script type="text/javascript" language="javascript" src="javascript/predictiveinput.js"></script>
    
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

<td style="width:150PX;font-family:Verdana;text-align:right;font-size:10px;background-color:#a0bfeb; height:20px;"><center><b>PLANET ASPECT PLANET</b></center></td>
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
<div id="maindiv" style= "overflow:auto; width:950px;  height:596px;" >



<table id="outertbl" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="innertbl1" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="pLabel" runat="server" Text="Planet" ></asp:Label></td>
<td><asp:DropDownList ID="drpplanet" runat="server" Width="100px" ></asp:DropDownList></td>

<td><asp:Label ID="pin" runat="server" Text="in House[F2]" ></asp:Label></td>
<td><asp:Textbox ID="drphouse" runat="server" Width="100px" ></asp:Textbox></td>
<td><asp:Label ID="Label192" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f1chart" runat="server" Width="100px" ></asp:DropDownList></td>


</tr>

<tr>
<td><asp:Label ID="Label5" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="txtpage" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label4" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="txtbook" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label181" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f1unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>

<tr>

<td><asp:Label ID="pkey" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="txtkey" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="btnexecute"  Text="Execute" runat="server" Width="80px" ></asp:Button></td>
<td><asp:Button ID="btnupdate"  Text="Update" runat="server" Width="100px" ></asp:Button></td>
<td><asp:Button ID="btnsave"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>

<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="innertbl" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="txtdetail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f1id" runat="server" Text="1" ></asp:Label></td>
</tr> 
</table>
</td>
</tr>
</table>	






<table id="Table4" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table5" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label8" runat="server"  Text="Planet" ></asp:Label></td>
<td><asp:DropDownList ID="f2planet" runat="server" Width="100px" ></asp:DropDownList></td>
<td><asp:Label ID="Label9" runat="server" Text="in Rashi" ></asp:Label></td>
<td><asp:DropDownList ID="f2rashi" runat="server" Width="100px" ></asp:DropDownList></td>
<td><asp:Label ID="Label193" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f2chart" runat="server" Width="100px" ></asp:DropDownList></td>
</tr>


<tr>
<td><asp:Label ID="Label10" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f2page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label11" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f2book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label187" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f2unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>
<tr>
<td><asp:Label ID="Label12" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f2filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f2execute"  Text="Execute" runat="server" Width="80px" ></asp:Button></td>
<td><asp:Button ID="f2update"  Text="Update" runat="server" Width="100px" ></asp:Button></td>
<td><asp:Button ID="f2save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table6" cellpadding="2" cellspacing="2" width="300" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f2detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f2id" runat="server" Text="2" ></asp:Label></td>
</tr> 
</table>
</td>
</tr>
</table>







<table id="Table7" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table8" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label13" runat="server"  Text="House" ></asp:Label></td>
<td><asp:DropDownList ID="f3house" runat="server" Width="100px" ></asp:DropDownList></td>
<td><asp:Label ID="Label14" runat="server" Text="in Rashi" ></asp:Label></td>
<td><asp:DropDownList ID="f3rashi" runat="server" Width="100px" ></asp:DropDownList></td>
<td><asp:Label ID="Label194" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f3chart" runat="server" Width="100px" ></asp:DropDownList></td>
</tr>
<tr>
<td></td></tr>
<tr>
<td><asp:Label ID="Label15" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f3page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label16" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f3book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label212" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f3unique" runat="server" Width="100px" ></asp:TextBox></td>


</tr>
<tr>
<td><asp:Label ID="Label17" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f3filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f3execute"  Text="Execute" runat="server" Width="80px" ></asp:Button></td>
<td><asp:Button ID="f3update"  Text="Update" runat="server" Width="100px" ></asp:Button></td>
<td><asp:Button ID="f3save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table9" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f3detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f3id" runat="server" Text="3" ></asp:Label></td>
</tr> 
</table>
</td>
</tr>
</table>







<table id="Table10" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table11" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label18" runat="server"  Text="Planet" ></asp:Label></td>
<td><asp:DropDownList ID="f4planet" runat="server" Width="100px" ></asp:DropDownList></td>
<td><asp:Label ID="Label19" runat="server" Text="in Rashi" ></asp:Label></td>
<td><asp:DropDownList ID="f4rashi" runat="server" Width="100px" ></asp:DropDownList></td>
<td><asp:Label ID="Label23" runat="server" Text="in House" ></asp:Label></td>
<td><asp:DropDownList ID="f4house" runat="server" Width="100px" ></asp:DropDownList></td>
</tr>

<tr>
<td><asp:Label ID="Label20" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f4page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label21" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f4book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label195" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f4chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label22" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f4filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label219" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f4unique" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f4execute"  Text="Execute" runat="server" Width="80px" ></asp:Button></td>
<td><asp:Button ID="f4update"  Text="Update" runat="server" Width="100px" ></asp:Button></td>
<td><asp:Button ID="f4save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table12" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f4detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f4id" runat="server" Text="4" ></asp:Label></td>
</tr> 
</table>
</td>
</tr>
</table>







<table id="Table13" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table14" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label24" runat="server"  Text="Planet" ></asp:Label></td>
<td><asp:DropDownList ID="f5planet" runat="server" Width="100px" ></asp:DropDownList></td>
<td><asp:Label ID="Label25" runat="server" Text="in Constelation" ></asp:Label></td>
<td><asp:DropDownList ID="f5constelation" runat="server" Width="100px" ></asp:DropDownList></td>
<td><asp:Label ID="Label220" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f5unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>

<tr>
<td><asp:Label ID="Label27" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f5page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label28" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f5book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label196" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f5chart" runat="server" Width="100px" ></asp:DropDownList></td>
</tr>
<tr>
<td><asp:Label ID="Label29" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f5filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f5execute"  Text="Execute" runat="server" Width="80px" ></asp:Button></td>
<td><asp:Button ID="f5update"  Text="Update" runat="server" Width="100px" ></asp:Button></td>
<td><asp:Button ID="f5save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table15" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f5detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f5id" runat="server" Text="5" ></asp:Label></td>
</tr> 
</table>
</td>
</tr>
</table>








<table id="Table1" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table2" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label1" runat="server"  Text="Multiple Planet[F2]" Font-Size="small" ></asp:Label></td>
<td><asp:textbox ID="txtmultipleplanet" runat="server" Width="100px" ></asp:textbox></td>
<td><asp:Label ID="Label2" runat="server" Text="in[F2]" ></asp:Label></td>
<td><asp:textbox ID="mdrphouse" runat="server" Width="100px" ></asp:textbox></td>
<td><asp:Label ID="Label221" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f6unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>

<tr>
<td></td></tr>
<tr>
<td><asp:Label ID="Label3" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="mpage" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label6" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="mbook" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label197" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f6chart" runat="server" Width="100px" ></asp:DropDownList></td>
</tr>
<tr>
<td><asp:Label ID="Label7" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="mfilter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="mbtnexecute"  Text="Execute" runat="server" Width="80px" ></asp:Button></td>
<td><asp:Button ID="mbtnupdate"  Text="Update" runat="server" Width="100px" ></asp:Button></td>
<td><asp:Button ID="mbtnsave"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table3" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="mdetail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f6id" runat="server" Text="6" ></asp:Label></td>
</tr> 
</table>
</td>
</tr>
</table>






<table id="Table16" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table17" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label26" runat="server"  Text="Multiple Planet[F2]" Font-Size="small" ></asp:Label></td>
<td><asp:textbox ID="f7planet" runat="server" Width="100px" ></asp:textbox></td>
<td><asp:Label ID="Label30" runat="server" Text="in Rashi[F2]" ></asp:Label></td>
<td><asp:textbox ID="f7rashi" runat="server" Width="100px" ></asp:textbox></td>
<td><asp:Label ID="Label222" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f7unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>

<tr>
<td></td></tr>
<tr>
<td><asp:Label ID="Label31" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f7page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label32" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f7book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label198" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f7chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label33" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f7filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f7execute"  Text="Execute" runat="server" Width="80px" ></asp:Button></td>
<td><asp:Button ID="f7update"  Text="Update" runat="server" Width="100px" ></asp:Button></td>
<td><asp:Button ID="f7save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table18" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f7detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f7id" runat="server" Text="7" ></asp:Label></td>
</tr> 
</table>
</td>
</tr>
</table>









<table id="Table19" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table20" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label34" runat="server"  Text="Multiple Planet[F2]" Font-Size="small" ></asp:Label></td>
<td><asp:textbox ID="f8planet" runat="server" Width="100px" ></asp:textbox></td>
<td><asp:Label ID="Label39" runat="server" Text="in House[F2]" ></asp:Label></td>
<td><asp:textbox ID="f8house" runat="server" Width="100px" ></asp:textbox></td>
<td><asp:Label ID="Label35" runat="server" Text="in Rashi[F2]" ></asp:Label></td>
<td><asp:textbox ID="f8rashi" runat="server" Width="100px" ></asp:textbox></td>
</tr>
<tr>
<td></td></tr>
<tr>
<td><asp:Label ID="Label36" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f8page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label37" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f8book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label199" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f8chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label38" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f8filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label223" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f8unique" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f8execute"  Text="Execute" runat="server" Width="80px" ></asp:Button></td>
<td><asp:Button ID="f8update"  Text="Update" runat="server" Width="100px" ></asp:Button></td>
<td><asp:Button ID="f8save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table21" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f8detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f8id" runat="server" Text="8" ></asp:Label></td>
</tr> 
</table>
</td>
</tr>
</table>







<table id="Table22" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table23" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label40" runat="server"  Text="Lord of House" Font-Size="small" ></asp:Label></td>
<td><asp:Dropdownlist ID="f9lhouse" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label41" runat="server" Text="Moves into House" ></asp:Label></td>
<td><asp:Dropdownlist ID="f9house" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label224" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f9unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>
<tr>
<td></td></tr>
<tr>
<td><asp:Label ID="Label43" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f9page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label44" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f9book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label200" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f9chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label45" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f9filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f9execute"  Text="Execute" runat="server" Width="80px" ></asp:Button></td>
<td><asp:Button ID="f9update"  Text="Update" runat="server" Width="100px" ></asp:Button></td>
<td><asp:Button ID="f9save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table24" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
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
<div id="divmovesinto" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table25" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="gridmovesinto" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>







<table id="Tablef" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Tablefg" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label42" runat="server"  Text="Lord of House" Font-Size="small" ></asp:Label></td>
<td><asp:Dropdownlist ID="f10lhouse" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label46" runat="server" Text="Moves into House" Font-Size="small"></asp:Label></td>
<td><asp:Dropdownlist ID="f10house" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label50" runat="server" Text="With Lord Of House" Font-Size="small"></asp:Label></td>
<td><asp:Dropdownlist ID="f10alhouse" runat="server" Width="100px" ></asp:Dropdownlist></td>
</tr>
<tr>
<td></td></tr>
<tr>
<td><asp:Label ID="Label47" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f10page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label48" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f10book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label201" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f10chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label49" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f10filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label225" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f10unique" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f10execute"  Text="Execute" runat="server" Width="80px" ></asp:Button></td>
<td><asp:Button ID="f10update"  Text="Update" runat="server" Width="100px" ></asp:Button></td>
<td><asp:Button ID="f10save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Tablef10" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
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
<div id="divf10" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table29" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="gridf10" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>









<table id="Table26" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table27" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label51" runat="server"  Text="Lord of House"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f11lhouse" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label52" runat="server" Text="Aspecting" ></asp:Label></td>
<td><asp:Dropdownlist ID="f11house" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label226" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f11unique" runat="server" Width="100px" ></asp:TextBox></td>

</tr>
<tr>
<td></td></tr>
<tr>
<td><asp:Label ID="Label54" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f11page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label55" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f11book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label202" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f11chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label56" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f11filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f11execute"  Text="Execute" runat="server" Width="80px" ></asp:Button></td>
<td><asp:Button ID="f11update"  Text="Update" runat="server" Width="100px" ></asp:Button></td>
<td><asp:Button ID="f11save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table28" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
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
<table id="Table30" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f11grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>










<table id="Table31" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table32" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label53" runat="server"  Text="Planet"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f12planet" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label57" runat="server" Text="Aspecting" ></asp:Label></td>
<td><asp:Dropdownlist ID="f12house" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label227" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f12unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>
<tr>
<td></td></tr>
<tr>
<td><asp:Label ID="Label58" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f12page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label59" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f12book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label203" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f12chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label60" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f12filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f12execute"  Text="Execute" runat="server" Width="80px" ></asp:Button></td>
<td><asp:Button ID="f12update"  Text="Update" runat="server" Width="100px" ></asp:Button></td>
<td><asp:Button ID="f12save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table33" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f12detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f12id" runat="server" Text="12" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f12div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table34" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f12grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>











<table id="Table46" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table47" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label79" runat="server"  Text="Planet"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f16planet" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label81" runat="server" Text="Aspected by" ></asp:Label></td>
<td><asp:Dropdownlist ID="f16aplanet" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label228" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f16unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>
<tr>
<td></td></tr>
<tr>
<td><asp:Label ID="Label82" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f16page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label83" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f16book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label191" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:Dropdownlist ID="f16chart" runat="server" Width="100px" ></asp:Dropdownlist></td>
</tr>
<tr>
<td><asp:Label ID="Label84" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f16filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f16execute"  Text="Execute" runat="server" Width="80px" ></asp:Button></td>
<td><asp:Button ID="f16update"  Text="Update" runat="server" Width="100px" ></asp:Button></td>
<td><asp:Button ID="f16save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table48" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f16detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f16id" runat="server" Text="13" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f16div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table49" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f16grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>











<table id="Table35" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table36" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label61" runat="server"  Text="Planet"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f13planet" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label66" runat="server" Text="in House" ></asp:Label></td>
<td><asp:Dropdownlist ID="f13house" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label62" runat="server" Text="Aspected by" ></asp:Label></td>
<td><asp:Dropdownlist ID="f13aplanet" runat="server" Width="100px" ></asp:Dropdownlist></td>
</tr>
<tr>
<td></td></tr>
<tr>
<td><asp:Label ID="Label63" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f13page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label64" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f13book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label204" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f13chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label65" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f13filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label229" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f13unique" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f13execute"  Text="Execute" runat="server" Width="80px" ></asp:Button></td>
<td><asp:Button ID="f13update"  Text="Update" runat="server" Width="100px" ></asp:Button></td>
<td><asp:Button ID="f13save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table37" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f13detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f13id" runat="server" Text="14" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f13div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table35" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f13grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>



















<table id="Table38" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table39" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label67" runat="server"  Text="Planet"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f14planet" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label68" runat="server" Text="in House" ></asp:Label></td>
<td><asp:Dropdownlist ID="f14house" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label69" runat="server" Text="Aspected by" ></asp:Label></td>
<td><asp:Dropdownlist ID="f14aplanet" runat="server" Width="100px" ></asp:Dropdownlist></td>
</tr>
<tr>
<td></td></tr>
<tr>
<td><asp:Label ID="Label70" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f14page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label71" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f14book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label205" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f14chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label72" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f14filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label230" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f14unique" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f14execute"  Text="Execute" runat="server" Width="80px" ></asp:Button></td>
<td><asp:Button ID="f14update"  Text="Update" runat="server" Width="100px" ></asp:Button></td>
<td><asp:Button ID="f14save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table40" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f14detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f14id" runat="server" Text="15" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f14div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table41" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f14grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>







<table id="Table42" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table43" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label73" runat="server"  Text="Planet"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f15planet" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label74" runat="server" Text="in House" ></asp:Label></td>
<td><asp:Dropdownlist ID="f15house" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label75" runat="server" Text="From Planet" ></asp:Label></td>
<td><asp:Dropdownlist ID="f15aplanet" runat="server" Width="100px" ></asp:Dropdownlist></td>
</tr>
<tr>
<td></td></tr>
<tr>
<td><asp:Label ID="Label76" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f15page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label77" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f15book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label206" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f15chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label78" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f15filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label231" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f15unique" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f15execute"  Text="Execute" runat="server" Width="80px" ></asp:Button></td>
<td><asp:Button ID="f15update"  Text="Update" runat="server" Width="100px" ></asp:Button></td>
<td><asp:Button ID="f15save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table44" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f15detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f15id" runat="server" Text="16" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f15div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table45" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f15grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>










<table id="Table50" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table51" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label100" runat="server"  Text="Lord of House"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f17house" runat="server" Width="100px" ></asp:Dropdownlist></td>

<td><asp:Label ID="Label102" runat="server" Text="in Deep Debilitation / Deep Exaltation" ></asp:Label></td>
<td><asp:Dropdownlist ID="f17rashi" runat="server" Width="100px" ></asp:Dropdownlist></td>
</tr>
<tr>
<td></td></tr>
<tr>
<td><asp:Label ID="Label103" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f17page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label104" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f17book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label207" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f17chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label105" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f17filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label232" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f17unique" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f17execute"  Text="Execute" runat="server" Width="80px" ></asp:Button></td>
<td><asp:Button ID="f17update"  Text="Update" runat="server" Width="100px" ></asp:Button></td>
<td><asp:Button ID="f17save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table52" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f17detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f17id" runat="server" Text="17" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f17div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table53" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f17grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>









<table id="Table54" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table55" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label107" runat="server"  Text="Planet"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f18planet" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label108" runat="server" Text="in House" ></asp:Label></td>
<td><asp:Dropdownlist ID="f18house" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label109" runat="server" Text="in Constellation" ></asp:Label></td>
<td><asp:Dropdownlist ID="f18cons" runat="server" Width="100px" ></asp:Dropdownlist></td>
</tr>
<tr>
<td></td></tr>
<tr>
<td><asp:Label ID="Label110" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f18page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label111" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f18book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label208" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f18chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label112" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f18filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label233" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f18unique" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f18execute"  Text="Execute" runat="server" Width="80px" ></asp:Button></td>
<td><asp:Button ID="f18update"  Text="Update" runat="server" Width="100px" ></asp:Button></td>
<td><asp:Button ID="f18save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table56" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f18detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f18id" runat="server" Text="18" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f18div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table57" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f18grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>






<table id="Table58" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table59" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label114" runat="server"  Text="Planet"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f19planet" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label115" runat="server" Text="in House[F2]" ></asp:Label></td>
<td><asp:Textbox ID="f19house" runat="server" Width="100px" ></asp:Textbox></td>
<td><asp:Label ID="Label234" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f19unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>
<tr>
<td><asp:Label ID="Label121" runat="server" Text="in Charan" ></asp:Label></td>
<td><asp:Dropdownlist ID="f19charan" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label116" runat="server" Text="of Constellation" ></asp:Label></td>
<td><asp:Dropdownlist ID="f19cons" runat="server" Width="100px" ></asp:Dropdownlist></td>
</tr>
<tr>
<td><asp:Label ID="Label117" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f19page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label118" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f19book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label209" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f19chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label119" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f19filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f19execute"  Text="Execute" runat="server" Width="80px" ></asp:Button></td>
<td><asp:Button ID="f19update"  Text="Update" runat="server" Width="100px" ></asp:Button></td>
<td><asp:Button ID="f19save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table60" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f19detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f19id" runat="server" Text="19" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f19div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table61" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f19grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>







<table id="Table62" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table63" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label122" runat="server"  Text="Planet"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f20planet" runat="server" Width="100px" ></asp:Dropdownlist>

</td>
<td><asp:Label ID="Label123" runat="server" Text="in Quadraped Rashi" ></asp:Label></td>
<td><asp:Dropdownlist ID="f20rashi" runat="server" Width="100px" ></asp:Dropdownlist></td>

</tr>
<tr>
<td><asp:Label ID="Label124" runat="server" Text="Planet[F2*]" ></asp:Label></td>
<td><asp:Textbox ID="f20aplanet" runat="server" Width="100px" ></asp:Textbox></td>
<td><asp:Label ID="Label125" runat="server" Text="in Rashi[F2*]" ></asp:Label></td>
<td><asp:Textbox ID="f20arashi" runat="server" Width="100px" ></asp:Textbox></td>
<td><asp:Label ID="Label235" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f20unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>
<tr>
<td><asp:Label ID="Label126" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f20page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label127" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f20book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label210" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f20chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label128" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f20filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f20execute"  Text="Execute" runat="server" Width="80px" ></asp:Button></td>
<td><asp:Button ID="f20update"  Text="Update" runat="server" Width="100px" ></asp:Button></td>
<td><asp:Button ID="f20save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table64" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f20detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f20id" runat="server" Text="20" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f20div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table65" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f20grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>











<table id="Table66" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table67" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label130" runat="server"  Text="House"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f21house" runat="server" Width="100px" ></asp:Dropdownlist>

</td>
<td><asp:Label ID="Label131" runat="server" Text="in Watery Rashi" ></asp:Label></td>
<td><asp:Dropdownlist ID="f21wrashi" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label236" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f21unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>
<tr>
<td><asp:Label ID="Label132" runat="server" Text="Planet" ></asp:Label></td>
<td><asp:Dropdownlist ID="f21planet" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label133" runat="server" Text="in House" ></asp:Label></td>
<td><asp:Dropdownlist ID="f21ahouse" runat="server" Width="100px" ></asp:Dropdownlist></td>
</tr>
<tr>
<td><asp:Label ID="Label134" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f21page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label135" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f21book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label211" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f21chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label136" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f21filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f21save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table68" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f21detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f21id" runat="server" Text="21" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f21div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table69" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f21grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>








<table id="Table70" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table71" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label138" runat="server"  Text="Lord of House"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f22house" runat="server" Width="100px" ></asp:Dropdownlist>

</td>
<td><asp:Label ID="Label139" runat="server" Text="in House" ></asp:Label></td>
<td><asp:Dropdownlist ID="f22ahouse" runat="server" Width="100px" ></asp:Dropdownlist></td>


<td><asp:Label ID="Label140" runat="server" Text="With Planet[F2*]" ></asp:Label></td>
<td><asp:TextBox ID="f22planet" runat="server" Width="100px" ></asp:TextBox></td>
</tr>
<tr>
<td><asp:Label ID="Label142" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f22page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label143" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f22book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label237" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f22unique" runat="server" Width="100px" ></asp:TextBox></td>



</tr>
<tr>
<td><asp:Label ID="Label144" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f22filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label190" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:Dropdownlist ID="f22chart" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Button ID="f22save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table72" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f22detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f22id" runat="server" Text="22" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f22div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table73" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f22grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>







<table id="Table74" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table75" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label141" runat="server"  Text="Lord of House"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f23house" runat="server" Width="100px" ></asp:Dropdownlist>

</td>
<td><asp:Label ID="Label146" runat="server" Text="Aspected by Planet" ></asp:Label></td>
<td><asp:Dropdownlist ID="f23planet" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label238" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f23unique" runat="server" Width="100px" ></asp:TextBox></td>

</tr>
<tr>
<td><asp:Label ID="Label148" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f23page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label149" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f23book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label213" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f23chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label150" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f23filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f23save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table76" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f23detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f23id" runat="server" Text="23" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f23div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table77" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f23grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>








<table id="Table78" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table79" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label147" runat="server"  Text="Lord of House"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f24loh1" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label152" runat="server" Text="in House" ></asp:Label></td>
<td><asp:Dropdownlist ID="f24house1" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label157" runat="server" Text="and Planet" ></asp:Label></td>
<td><asp:Dropdownlist ID="f24planet" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label158" runat="server" Text="in House" ></asp:Label></td>
<td><asp:Dropdownlist ID="f24house" runat="server" Width="100px" ></asp:Dropdownlist></td>
</tr>
<tr>
<td><asp:Label ID="Label159" runat="server" Text="Lord Of House" ></asp:Label></td>
<td><asp:Dropdownlist ID="f24loh2" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label160" runat="server" Text="in House" ></asp:Label></td>
<td><asp:Dropdownlist ID="f24house2" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label239" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f24unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>
<tr>
<td><asp:Label ID="Label153" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f24page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label154" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f24book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label214" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f24chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label155" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f24filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f24save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table80" cellpadding="2" cellspacing="2" width="280px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f24detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f24id" runat="server" Text="24" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f24div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table81" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f24grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>







<table id="Table82" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table83" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label161" runat="server"  Text="Lord of House"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f25loh" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label162" runat="server" Text="in House" ></asp:Label></td>
<td><asp:Dropdownlist ID="f25house" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label240" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f25unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>
<tr>
<td><asp:Label ID="Label163" runat="server" Text="With Planet" ></asp:Label></td>
<td><asp:Dropdownlist ID="f25planet" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label164" runat="server" Text="with Malifics[F2*]" ></asp:Label></td>
<td><asp:TextBox ID="f25malifics" runat="server" Width="100px" ></asp:TextBox></td>

</tr>
<tr>
<td><asp:Label ID="Label167" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f25page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label168" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f25book" runat="server" Width="100px" ></asp:TextBox></td><td>
<asp:Label ID="Label215" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f25chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label169" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f25filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f25save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table84" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f25detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f25id" runat="server" Text="25" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f25div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table85" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f25grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>









<table id="Table86" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table87" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label165" runat="server"  Text="Lord of House"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f26house" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label166" runat="server" Text="Aspected By Benifics/Malifics" ></asp:Label></td>
<td><asp:Dropdownlist ID="f26malifics" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label241" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f26unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>

<tr>
<td><asp:Label ID="Label173" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f26page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label174" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f26book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label216" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f26chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label175" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f26filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f26save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table88" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f26detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f26id" runat="server" Text="26" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f26div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table89" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f26grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>










<table id="Table90" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table91" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label171" runat="server"  Text="Lord of House"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f27loh1" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label172" runat="server" Text="Aspected By Dispositor" ></asp:Label></td>
<td><asp:Dropdownlist ID="f27loh2" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label242" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f27unique" runat="server" Width="100px" ></asp:TextBox></td>
</tr>

<tr>
<td><asp:Label ID="Label177" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f27page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label178" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f27book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label217" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f27chart" runat="server" Width="100px" ></asp:DropDownList></td>


</tr>
<tr>
<td><asp:Label ID="Label179" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f27filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Button ID="f27save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>
</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table92" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f27detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f27id" runat="server" Text="27" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f27div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table93" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f27grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>









<table id="Table94" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table95" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label182" runat="server"  Text="Lord of House"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f28loh" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label183" runat="server" Text="with ben/mal" ></asp:Label></td>
<td><asp:Dropdownlist ID="f28benmal" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label189" runat="server" Text="in sign" ></asp:Label></td>
<td><asp:Dropdownlist ID="f28sign" runat="server" Width="100px" >
 <asp:ListItem>SELECT RASHI</asp:ListItem>
                     <asp:ListItem>WATERY</asp:ListItem>
                     
                      <asp:ListItem>EXALTATION</asp:ListItem></asp:Dropdownlist></td>

</tr>

<tr>
<td><asp:Label ID="Label184" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f28page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label185" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f28book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label218" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f28chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label186" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f28filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label243" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f28unique" runat="server" Width="100px" ></asp:TextBox></td>

<td><asp:Button ID="f28save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>


</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table96" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f28detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f28id" runat="server" Text="28" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f28div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table97" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f28grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>









<table id="f29table" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table99" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label80" runat="server"  Text="Lord of House"  ></asp:Label></td>
<td><asp:Dropdownlist ID="f29loh" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label85" runat="server" Text="in House" ></asp:Label></td>
<td><asp:Dropdownlist ID="f29house" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label86" runat="server" Text="from Planet" ></asp:Label></td>
<td><asp:Dropdownlist ID="f29planet" runat="server" Width="100px" ></asp:Dropdownlist></td>

</tr>

<tr>
<td><asp:Label ID="Label87" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f29page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label88" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f29book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label89" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f29chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label90" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f29filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label91" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f29unique" runat="server" Width="100px" ></asp:TextBox></td>

<td><asp:Button ID="f29save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>


</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table100" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f29detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f29id" runat="server" Text="29" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f29div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table101" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f29grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>








<table id="f30table" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table102" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label92" runat="server"  Text="Planet "  ></asp:Label></td>
<td><asp:Dropdownlist ID="f30planet" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label93" runat="server" Text="in House" ></asp:Label></td>
<td><asp:Dropdownlist ID="f30house" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label94" runat="server" Text="From lord of house" ></asp:Label></td>
<td><asp:Dropdownlist ID="f30loh" runat="server" Width="100px" ></asp:Dropdownlist></td>


</tr>

<tr>
<td><asp:Label ID="Label95" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f30page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label96" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f30book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label97" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f30chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label98" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f30filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label99" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f30unique" runat="server" Width="100px" ></asp:TextBox></td>

<td><asp:Button ID="f30save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>


</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table103" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f30detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f30id" runat="server" Text="30" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f30div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table104" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f30grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>








<table id="f31table" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table105" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label106" runat="server"  Text="Lord of house "  ></asp:Label></td>
<td><asp:Dropdownlist ID="f31loh" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label113" runat="server" Text="in House" ></asp:Label></td>
<td><asp:Dropdownlist ID="f31house" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label120" runat="server" Text="From lord of house" ></asp:Label></td>
<td><asp:Dropdownlist ID="f31aloh" runat="server" Width="100px" ></asp:Dropdownlist></td>


</tr>

<tr>
<td><asp:Label ID="Label129" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f31page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label137" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f31book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label145" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f31chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label151" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f31filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label156" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f31unique" runat="server" Width="100px" ></asp:TextBox></td>

<td><asp:Button ID="f31save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>


</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table106" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f31detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f31id" runat="server" Text="31" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f31div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table107" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f31grid" style="width:300px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>















<table id="f32table" cellpadding="0" cellspacing="0" width="500px"  style="border:2px solid;border-color:#7DAAE3; margin-top:20px;" >       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table98" cellpadding="2" cellspacing="2" width="500px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td><asp:Label ID="Label170" runat="server"  Text="Lord of house "  ></asp:Label></td>
<td><asp:Dropdownlist ID="f32loh" runat="server" Width="100px" ></asp:Dropdownlist></td>
<td><asp:Label ID="Label176" runat="server" Text="in Rashi" ></asp:Label></td>
<td><asp:Dropdownlist ID="f32rashi" runat="server" Width="100px" ></asp:Dropdownlist></td>


</tr>

<tr>
<td><asp:Label ID="Label188" runat="server" Text="Page_No" ></asp:Label></td>
<td><asp:TextBox ID="f32page" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label244" runat="server" Text="Book" ></asp:Label></td>
<td><asp:TextBox ID="f32book" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label245" runat="server" Text="Chart" ></asp:Label></td>
<td><asp:DropDownList ID="f32chart" runat="server" Width="100px" ></asp:DropDownList></td>

</tr>
<tr>
<td><asp:Label ID="Label246" runat="server" Text="Key Strings" ></asp:Label></td>
<td><asp:TextBox ID="f32filter" runat="server" Width="100px" ></asp:TextBox></td>
<td><asp:Label ID="Label247" runat="server" Text="Unique id" ></asp:Label></td>
<td><asp:TextBox ID="f32unique" runat="server" Width="100px" ></asp:TextBox></td>

<td><asp:Button ID="f32save"  Text="Save" runat="server" Width="80px" ></asp:Button></td>


</tr>		
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<table id="Table108" cellpadding="2" cellspacing="2" width="300px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td >
<asp:TextBox ID="f32detail" runat="server" TextMode="MultiLine" Width="260px" Height="80px" >
</asp:TextBox>
</td>
<td><asp:Label ID="f32id" runat="server" Text="32" ></asp:Label></td>
</tr> 
</table>
</td>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;">
<div id="f32div" style= "overflow:auto;display:none; width:50px; height:50px;" >
<table id="Table109" cellpadding="2" cellspacing="2" width="50px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
<td runat="server" id="f32grid" style="width:300px;" align="left" ></td>
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
    <div id="divmultipleplanet" style="border:none;display:none;z-index:1;">
    <table cellpadding="0" cellspacing="0">
    <tr>
    <td>
    <asp:ListBox ID="lstmultipleplanet" Width="110px" Height="75px" runat="server" CssClass="btextlist"  SelectionMode="Multiple">
    </asp:ListBox>
    </td>
    </tr>
    </table>
    </div>
   </td> 
    

    <td>
    <div id="divmultiplehouse" style=" margin-left:150px; display:none;display:none;z-index:1;">
    <table cellpadding="0" cellspacing="0">
    <tr>
    <td>
    <asp:ListBox ID="lstmultiplehouse" Width="110px" Height="75px" runat="server" CssClass="btextlist"  SelectionMode="Multiple">
    </asp:ListBox>
    </td>
    </tr>
    </table>
    </div>
    </td>
   
    <td>
    <div id="divmultiplerashi" style=" margin-left:110px;display:none;display:none;z-index:1;">
    <table cellpadding="0" cellspacing="0">
    <tr>
    <td>
    <asp:ListBox ID="lstmultiplerashi" Width="110px" Height="75px" runat="server" CssClass="btextlist"  SelectionMode="Multiple">
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
