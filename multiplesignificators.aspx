<%@ Page Language="C#" AutoEventWireup="true" CodeFile="multiplesignificators.aspx.cs" Inherits="multiplesignificators"  EnableEventValidation="false"  %>
<%@ register TagPrefix="uc1" TagName="topbar" Src="~/topbarnew.ascx"%>
<%@ register TagPrefix="uc2" TagName="Leftbar" Src="~/leftbar.ascx"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Multiple Significators</title>
    <script type="text/javascript" language="javascript" src="javascript/multisigni.js"></script>
    <link href="css/combine.css" type="text/css" rel="stylesheet" />
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
     <table id="outertable" width="400px" border="0" cellpadding="0" cellspacing="0">
          <tr>
                                             <td valign="top" style="width: 184px"><uc2:leftbar id="Leftbar1" runat="server"></uc2:leftbar></td>
	
	                                       <td valign="top">
						<table  style="margin-top:-4px;margin-left:-5px;height:20px;width: 900px">
							<tr style="height:25px;">
         
         
			<td><asp:ImageButton id="btnNew" runat="server"   Font-Size="XX-Small" 
                    BackColor="Control" BorderStyle="Outset"  Font-Bold="True" 
                    ImageUrl="~/Image/new.jpg"  ></asp:ImageButton>
                <asp:ImageButton id="btnSave" 
                    runat="server"  Font-Size="XX-Small" BackColor="Control" BorderStyle="Outset" 
                    BorderColor="DarkGray" Font-Bold="True" ImageUrl="~/Image/save.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnModify" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/modify.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnQuery" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/query.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnExecute" runat="server" Font-Size="XX-Small"
										BackColor="Control" BorderStyle="Outset"  Font-Bold="True" 
                    ImageUrl="~/Image/execute.jpg"></asp:ImageButton>
                <asp:ImageButton id="btnCancel" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/clear.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnfirst"  runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/first.jpg" Width="70px" Height="27px"></asp:ImageButton>
                <asp:ImageButton id="btnprevious" runat="server" Font-Size="XX-Small"
										BackColor="Control" BorderStyle="Outset"  Font-Bold="True" 
                    ImageUrl="~/Image/previous.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnnext" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/next.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnlast" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/last.jpg" Width="70px" Height="27px" ></asp:ImageButton>
                <asp:ImageButton id="btnDelete" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/delete.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnExit" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/exit.jpg" ></asp:ImageButton>
								</td>
								
								
							</tr>
							
				<tr valign="top" align="left">
								<td>
									
								</td>
							
					
	                    <td style="height: 15px"></td>
	                </tr>
	                </table>
	               </td>
	              
	                </table>
	                
	                
	                
	                
	                <table>
	                <tr> <td>   
                                        
                     <table border="0" cellpadding="0" cellspacing="0"  width="100%">
                      <tr>
                     <td style="width:27px;"></td>
                     <td style="background-image:url(image/corner-left.jpg);width:11px; background-position:right center; background-repeat:no-repeat; height:20px;"></td>
                     
                      <td style="width:150PX;font-family:Verdana;text-align:right;font-size:10px;background-color:#a0bfeb; height:20px;"><center><b>Multiple Significators</b></center></td>
                    <%-- <td style="width:150PX;font-family:Verdana;text-align:right;font-size:10px;background-color:#a0bfeb; height:25px;"><center><b> ASTRO EXTENTIONS</b></center></td>--%>
                     <td style="background-image:url(image/corner-right.jpg); background-repeat:no-repeat; height:25px;width:11px"></td>
					 <td style="width:770px"><table cellpadding="0" cellspacing="0"><tr><td style="background-color:#a0bfeb;width:770px; height:3px;"></td></tr></table></td>
				</tr>
                    </table>         
                    
                  </td>
                  </tr> 
                  
                  </table>
                  
                  
                  
<table id="outertbl" cellpadding="0" cellspacing="0" width="340px" style="margin-left:80px">       
<tr>
<td style="padding-left:4px; padding-top:4px; padding-bottom:4px; padding-right:4px;border:2px solid;border-color:#7DAAE3;">
<table id="innertbl" cellpadding="2" cellspacing="2" width="340px" style="border:1px solid;border-color:#7DAAE3;">
<tr>
</tr>
<tr>
<td><asp:Label ID="Significator" runat="server" Text="Significator" ></asp:Label></td>
<td><asp:TextBox ID="txtsigni" runat="server" Width="90px" ></asp:TextBox></td>
<td><asp:Label ID="House" runat="server" Text="House" ></asp:Label></td>
<td><asp:TextBox ID="txthouse" runat="server" Width="90px" ></asp:TextBox></td>
<td><asp:Label ID="Planet" runat="server" Text="Planet" ></asp:Label></td>
<td><asp:TextBox ID="txtplanet" runat="server" Width="90px" ></asp:TextBox></td>
<td><asp:Label ID="Rashi" runat="server" Text="Rashi" ></asp:Label></td>
<td><asp:TextBox ID="txtrashi" runat="server" Width="90px" ></asp:TextBox></td>
</table>


<table>
<tr>
<td style="padding-left:50px;">
<table align="left" cellspacing="0" cellpadding="0"  style="width: 550px">
<tr>
<td style="padding-left:20px;">
<div id="Divgrid1" style= "overflow:auto;display:none; width:550px;" >
<table >
<tr>
<td runat="server" id="hdsviewgrid" style="width:520px;" align="left" ></td>
</tr>
</table>
</div>
</td>
</tr>
</table>
</td>
</tr>                         
</table>
</td>
</tr>  
</table>	  
   
<table>
<tr>
<td>      
<div id="divhouse" style="position:absolute;top:0px;left:0px;border:none;display:none;z-index:1;">
<table cellpadding="0" cellspacing="0">
<tr>
<td>
<asp:ListBox ID="lsthouse" Width="100px" Height="75px" runat="server" SelectionMode="Multiple">
</asp:ListBox>
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
<div id="divplanet" style="position:absolute;top:0px;left:0px;border:none;display:none;z-index:1;">
<table cellpadding="0" cellspacing="0">
<tr>
<td>
<asp:ListBox ID="lstplanet" Width="100px" Height="75px" runat="server" SelectionMode="Multiple">
</asp:ListBox>
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
<div id="divrashi" style="position:absolute;top:0px;left:0px;border:none;display:none;z-index:1;">
<table cellpadding="0" cellspacing="0">
<tr>
<td>
<asp:ListBox ID="lstrashi" Width="100px" Height="75px" runat="server" SelectionMode="Multiple">
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
</form>
</body>
</html>
