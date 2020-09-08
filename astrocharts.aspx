<%@ Page Language="C#" AutoEventWireup="true" CodeFile="astrocharts.aspx.cs" Inherits="astrocharts" %>
<%@ register TagPrefix="uc1" TagName="topbar" Src="~/topbarnew.ascx"%>
<%@ register TagPrefix="uc2" TagName="Leftbar" Src="~/leftbar.ascx"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Astro Charts</title>
    <script type="text/javascript" language="javascript" src="javascript/charts.js"></script>
    <script language="javascript" src="javascript/prototype.js" type="text/javascript">
</script>
   <style type="text/css">
      
   </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
         <table cellpadding="0" cellspacing="0">
    <tr>
            <td colspan="2"><uc1:topbar id="Topbar1" runat="server" Text="extentions"></uc1:topbar></td>
    </tr>
    </table>
    <div>
    <table>   
         <tr valign="top" >
			<td><asp:ImageButton id="btnNew" runat="server"   Font-Size="XX-Small" 
                    BackColor="Control" BorderStyle="Outset"  Font-Bold="True" 
                    ImageUrl="~/Image/new.jpg"  ></asp:ImageButton>
                 <asp:ImageButton id="btnSave" 
                    runat="server"  Font-Size="XX-Small" BackColor="Control" BorderStyle="Outset" 
                    BorderColor="DarkGray" Font-Bold="True" ImageUrl="~/Image/save.jpg" 
                     ></asp:ImageButton>
                <asp:ImageButton id="btnModify" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/modify.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnQuery" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/query.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnExecute" runat="server" Font-Size="XX-Small"
										BackColor="Control" BorderStyle="Outset"  Font-Bold="True" 
                    ImageUrl="~/Image/execute.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnCancel" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/clear.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnfirst"  runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/first.jpg" Width="70px" Height="27px" 
                    ></asp:ImageButton>
                <asp:ImageButton id="btnprevious" runat="server" Font-Size="XX-Small"
										BackColor="Control" BorderStyle="Outset"  Font-Bold="True" 
                    ImageUrl="~/Image/previous.jpg"  ></asp:ImageButton>
                <asp:ImageButton id="btnnext" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/next.jpg"  ></asp:ImageButton>
                <asp:ImageButton id="btnlast" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/last.jpg" Width="70px" Height="27px" 
                     ></asp:ImageButton>
                <asp:ImageButton id="btnDelete" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/delete.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnExit" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/exit.jpg" ></asp:ImageButton>
								</td>
							</tr>
                             
                                        	
                              
                                 
                    </table> 
                    
                           
  <table>
  	<tr> <td>   
                                        
                                        
                    
                     <table border="0" cellpadding="0" cellspacing="0"  width="100%">
                  <tr>
				     <td style="width:27px;"></td>
                     <td style="background-image:url(Image/corner-left.jpg);width:11px; background-position:right center; background-repeat:no-repeat; height:20px;"></td>
                     <td style="width:150PX;font-family:Verdana;text-align:right;font-size:10px;background-color:#a0bfeb; height:20px;"><b><center> Astrology Charts</center></b></td>
                     <td style="background-image:url(Image/corner-right.jpg); background-repeat:no-repeat; height:20px;width:11px"></td>
					 <td style="width:770px"><table cellpadding="0" cellspacing="0"><tr><td style="background-color:#a0bfeb;width:770px; height:3px;"></td></tr></table></td>
                   </tr>
            </table>      
                    
                  </td></tr>  
                  
                  
                 <tr>
								<td style="height: 25px"></td>
							</tr> 
                  
         </table>
                    
                    <table align="left">  
    <tr>
	<td >
	<table align="left" cellspacing="0" cellpadding="0" style="width: 850px">
  
   <tr>    
 


<td  style="padding-left:20px;" > 
  <asp:Label ID="Label6" runat="server" Text="Planet"></asp:Label>
</td>

<td style="padding-left:20px;" >
<asp:UpdatePanel ID="UpdatePanel7" runat="server"><ContentTemplate>
 <asp:DropDownList ID="planet" runat="server" style="  height: 16px; width: 90px" >
 </asp:DropDownList>
</ContentTemplate></asp:UpdatePanel> 
 </td>
 
  <td  style="padding-left:20px;"> 
  <asp:Label ID="Label7" runat="server" Text="House"></asp:Label>
  </td>
  
  <td style="padding-left:20px;" >
  <asp:UpdatePanel ID="UpdatePanel5" runat="server"><ContentTemplate>
  <asp:DropDownList ID="house" runat="server" AutoPostBack="True"  Height="16px" Width="90px" >
  </asp:DropDownList>
  </ContentTemplate></asp:UpdatePanel> 
  </td>
  


  

  
<td style="padding-left:20px; ">
<table>
<tr>
<td>
<asp:Button ID="d1" runat="server"  Text="D1" onclick="d1_Click" />
<asp:Button ID="d3" runat="server"  Text="D3" onclick="d3_Click"   />
<asp:Button ID="d4" runat="server"  Text="D4" onclick="d4_Click"   />
<asp:Button ID="d7" runat="server"  Text="D7" onclick="d7_Click"   />
<asp:Button ID="d9" runat="server"  Text="D9" onclick="d9_Click"   />
<asp:Button ID="d10" runat="server"  Text="D10" onclick="d10_Click"   />
<asp:Button ID="d12" runat="server"  Text="D12" onclick="d12_Click"   />
<asp:Button ID="d16" runat="server"  Text="D16" onclick="d16_Click"   />
</td></tr></table>
</td>
</tr>

 
  
  
   
   <tr>
  <td  style="padding-left:20px; " > 
  <asp:Label ID="Label3" runat="server" style=" height: 15px; width: 100px;" Text="Lagna Degree" ></asp:Label></td>
  
  <td  style="padding-left:20px; " >
  <asp:TextBox ID="ldegree" runat="server" style=" height: 15px; width: 100px;  " 
          MaxLength="8" ></asp:TextBox>
  </td>
  
  <td  style="padding-left:20px; " > 
  <asp:Label ID="Label4" runat="server" Text="Planet Degree" style=" height: 15px; width: 100px;" ></asp:Label>
  </td>
  
  <td  style="padding-left:20px; " >
  <asp:TextBox ID="pdegree" runat="server" style=" height: 15px; width: 100px;  " 
          MaxLength="8" ></asp:TextBox>
  </td>
  
  
  <td  style="padding-left:20px; " > 
  <asp:Label ID="Label9" runat="server"  style=" height: 15px; width: 100px;" ></asp:Label>
  </td>
  </tr>
  
   <tr>
  <td  style="padding-left:20px;" > 
  <asp:Label ID="Label1" runat="server" Text="Book"></asp:Label>
  </td>
  
  <td  style="padding-left:20px;" >
  <asp:TextBox ID="book" runat="server" style=" height: 15px; width: 100px; " ></asp:TextBox>
  </td>
    
    <td style="padding-left:20px;" > 
   <asp:Label ID="Label2" runat="server" Text="Key"></asp:Label>
   </td>
   
   <td style="padding-left:20px;" >
   <asp:TextBox ID="keystring" runat="server" style=" height: 15px; width: 100px; " ></asp:TextBox>
    </td>
   </tr>
        
  </table></td></tr>
  
 
  
        
<tr>
<td style="padding-left:00px;">
<table align="left" cellspacing="0" cellpadding="0"  style="width: 550px">
  
<tr>
<td style="padding-left:20px;" >  
<asp:Label ID="Label5" runat="server" Text="Description">
</asp:Label>
<asp:TextBox ID="Textdesc" runat="server" style=" height: 15px; width: 450px; " ></asp:TextBox>
 </td>
</tr>

 <tr>
<td style="padding-left:100px;">
 <asp:TextBox ID="detaildesc" runat="server" TextMode="MultiLine" style=" height: 120px; width: 450px;">
 </asp:TextBox>  
 </td>
 </tr>
</table> 
 </td>
 </tr>
 
 
 
 </table>   
 <table cellpadding="0" cellspacing="0" width="400" style="width: auto; margin: 80px;">
                    <tr valign="top">
                        <td align="center" style="height: 200px">
                            <div id="divgrid1" runat="server" style="OVERFLOW: auto; WIDTH: 400px; HEIGHT: 200px; top: 270px; left: 575px; position: absolute;">
                                <table id="Table3" align="center">
                                    <tr>
                                        <td align="center" >
                                            <asp:DataGrid ID="DataGrid1" runat="server" CssClass="dtGrid" Width="400px" AutoGenerateColumns="False"
                                                OnItemDataBound="DataGrid1_ItemDataBound">
                                                <SelectedItemStyle Font-Size="XX-Small" BackColor="#046791"></SelectedItemStyle>
                                                <Columns>
                                                   
                                                    <asp:TemplateColumn>
                                                        <HeaderTemplate>
                                                            <input id="Cb"  type="checkbox" name="cb" onclick="SelectHi('DataGrid1',this,'cb');" runat="server" />
                                                        </HeaderTemplate>
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Height="15px"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Center" Width="20px" VerticalAlign="Bottom" Height="15px"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:CheckBox ID="cb1" CssClass="TextField1" runat="server" />
                                                        </ItemTemplate>
                                                    </asp:TemplateColumn>
                                                    <asp:BoundColumn DataField="D1_LAGN_RASHI" HeaderText="D1_LAGNA_RASHI">
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Bottom"  Width="30px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center"  Width="30px" />
                                                    </asp:BoundColumn>
                                                    
                                                       <asp:BoundColumn DataField="D1_RASHI" HeaderText="D1_RASHI">
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Bottom"  Width="30px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center"  Width="30px" />
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="D9_LAGNA_RASHI" HeaderText="D9_LAGNA_RASHI">
                                                        <ItemStyle  HorizontalAlign="Center" VerticalAlign="Bottom" Width="50px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="50px" />
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="D9_RASHI" HeaderText="D9_RASHI">
                                                        <ItemStyle HorizontalAlign="left" VerticalAlign="Bottom" Width="140px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="140px"/>
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="HOUSE" HeaderText="HOUSE">
                                                        <ItemStyle HorizontalAlign="left" VerticalAlign="Bottom" Width="90px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="90px" />
                                                    </asp:BoundColumn>
                                                   
                                                </Columns>
                                                <HeaderStyle HorizontalAlign="Center" Height="15px" ForeColor="White" CssClass="header"
                                                    BackColor="#7DAAE3"></HeaderStyle>
                                            </asp:DataGrid>
                                        </td>
                                    </tr>
                                </table>   
                                  </div>  
                                  <table cellpadding="0" cellspacing="0" width="350" style="width: auto; margin: 80px;">
                    <tr valign="top">
                        <td align="center" style="height: 200px">
                            <div id="div3" runat="server" style="OVERFLOW: auto; WIDTH: 350px; HEIGHT: 200px; top: 270px; left: 575px; position: absolute;">
                                <table id="Table1" align="center">
                                    <tr>
                                        <td align="center" >
                                            <asp:DataGrid ID="DataGrid2" runat="server" CssClass="dtGrid" Width="350px" AutoGenerateColumns="False"
                                                OnItemDataBound="DataGrid1_ItemDataBound">
                                                <SelectedItemStyle Font-Size="XX-Small" BackColor="#046791"></SelectedItemStyle>
                                                <Columns>
                                                   
                                                    <asp:TemplateColumn>
                                                        <HeaderTemplate>
                                                            <input id="Cb"  type="checkbox" name="cb" onclick="SelectHii('DataGrid1',this,'cb');" runat="server" />
                                                        </HeaderTemplate>
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Height="15px"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Center" Width="20px" VerticalAlign="Bottom" Height="15px"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:CheckBox ID="cb1" CssClass="TextField1" runat="server" />
                                                        </ItemTemplate>
                                                    </asp:TemplateColumn>
                                                    <asp:BoundColumn DataField="LAGNA_RASHI" HeaderText="LAGNA_RASHI">
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Bottom"  Width="30px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center"  Width="30px" />
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="D9_RASHI" HeaderText="RASHI">
                                                        <ItemStyle  HorizontalAlign="Center" VerticalAlign="Bottom" Width="50px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="50px" />
                                                    </asp:BoundColumn>
                                                   
                                                </Columns>
                                                <HeaderStyle HorizontalAlign="Center" Height="15px" ForeColor="White" CssClass="header"
                                                    BackColor="#7DAAE3"></HeaderStyle>
                                            </asp:DataGrid>
                                        </td>
                                    </tr>
                                </table>   
                                </div>              
                  </td></tr></table>
                  
                  
                  
                  
                  <table cellpadding="0" cellspacing="0" width="400" style="width: auto; margin: 80px;">
                    <tr valign="top">
                        <td align="center" style="height: 200px">
                            <div id="div1" runat="server" style="OVERFLOW: auto; WIDTH: 400px; HEIGHT: 200px; top: 270px; left: 575px; position: absolute;">
                                <table id="Table2" align="center">
                                    <tr>
                                        <td align="center" >
                                            <asp:DataGrid ID="DataGrid3" runat="server" CssClass="dtGrid" Width="400px" AutoGenerateColumns="False"
                                                OnItemDataBound="DataGrid1_ItemDataBound">
                                                <SelectedItemStyle Font-Size="XX-Small" BackColor="#046791"></SelectedItemStyle>
                                                <Columns>
                                                   
                                                    <asp:TemplateColumn>
                                                        <HeaderTemplate>
                                                            <input id="Cb3"  type="checkbox" name="cb3" onclick="SelectHiii('DataGrid3',this,'cb3');" runat="server" />
                                                        </HeaderTemplate>
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Height="15px"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Center" Width="20px" VerticalAlign="Bottom" Height="15px"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:CheckBox ID="cbx3" CssClass="TextField1" runat="server" />
                                                        </ItemTemplate>
                                                    </asp:TemplateColumn>
                                                    <asp:BoundColumn DataField="D1_LAGN_RASHI" HeaderText="D1_LAGNA_RASHI">
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Bottom"  Width="30px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center"  Width="30px" />
                                                    </asp:BoundColumn>
                                                    
                                                       <asp:BoundColumn DataField="D1_RASHI" HeaderText="D1_RASHI">
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Bottom"  Width="30px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center"  Width="30px" />
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="D9_LAGNA_RASHI" HeaderText="D3_LAGNA_RASHI">
                                                        <ItemStyle  HorizontalAlign="Center" VerticalAlign="Bottom" Width="50px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="50px" />
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="D9_RASHI" HeaderText="D3_RASHI">
                                                        <ItemStyle HorizontalAlign="left" VerticalAlign="Bottom" Width="140px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="140px"/>
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="HOUSE" HeaderText="HOUSE">
                                                        <ItemStyle HorizontalAlign="left" VerticalAlign="Bottom" Width="90px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="90px" />
                                                    </asp:BoundColumn>
                                                   
                                                </Columns>
                                                <HeaderStyle HorizontalAlign="Center" Height="15px" ForeColor="White" CssClass="header"
                                                    BackColor="#7DAAE3"></HeaderStyle>
                                            </asp:DataGrid>
                                        </td>
                                    </tr>
                                </table>   
                                  </div>  
                                  
                                  
                                  
                                  <table cellpadding="0" cellspacing="0" width="400" style="width: auto; margin: 80px;">
                    <tr valign="top">
                        <td align="center" style="height: 200px">
                            <div id="div2" runat="server" style="OVERFLOW: auto; WIDTH: 400px; HEIGHT: 200px; top: 270px; left: 575px; position: absolute;">
                                <table id="Table4" align="center">
                                    <tr>
                                        <td align="center" >
                                            <asp:DataGrid ID="DataGrid4" runat="server" CssClass="dtGrid" Width="400px" AutoGenerateColumns="False"
                                                OnItemDataBound="DataGrid1_ItemDataBound">
                                                <SelectedItemStyle Font-Size="XX-Small" BackColor="#046791"></SelectedItemStyle>
                                                <Columns>
                                                   
                                                    <asp:TemplateColumn>
                                                        <HeaderTemplate>
                                                            <input id="Cb4"  type="checkbox" name="cb4" onclick="SelectH('DataGrid4',this,'cb4');" runat="server" />
                                                        </HeaderTemplate>
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Height="15px"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Center" Width="20px" VerticalAlign="Bottom" Height="15px"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:CheckBox ID="cbx4" CssClass="TextField1" runat="server" />
                                                        </ItemTemplate>
                                                    </asp:TemplateColumn>
                                                    <asp:BoundColumn DataField="D1_LAGN_RASHI" HeaderText="D1_LAGNA_RASHI">
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Bottom"  Width="30px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center"  Width="30px" />
                                                    </asp:BoundColumn>
                                                    
                                                       <asp:BoundColumn DataField="D1_RASHI" HeaderText="D1_RASHI">
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Bottom"  Width="30px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center"  Width="30px" />
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="D9_LAGNA_RASHI" HeaderText="D4_LAGNA_RASHI">
                                                        <ItemStyle  HorizontalAlign="Center" VerticalAlign="Bottom" Width="50px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="50px" />
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="D9_RASHI" HeaderText="D4_RASHI">
                                                        <ItemStyle HorizontalAlign="left" VerticalAlign="Bottom" Width="140px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="140px"/>
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="HOUSE" HeaderText="HOUSE">
                                                        <ItemStyle HorizontalAlign="left" VerticalAlign="Bottom" Width="90px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="90px" />
                                                    </asp:BoundColumn>
                                                   
                                                </Columns>
                                                <HeaderStyle HorizontalAlign="Center" Height="15px" ForeColor="White" CssClass="header"
                                                    BackColor="#7DAAE3"></HeaderStyle>
                                            </asp:DataGrid>
                                        </td>
                                    </tr>
                                </table>   
                                  </div>  
                                  
                                  
                                  
                                     <table cellpadding="0" cellspacing="0" width="400" style="width: auto; margin: 80px;">
                    <tr valign="top">
                        <td align="center" style="height: 200px">
                            <div id="div4" runat="server" style="OVERFLOW: auto; WIDTH: 400px; HEIGHT: 200px; top: 270px; left: 575px; position: absolute;">
                                <table id="Table5" align="center">
                                    <tr>
                                        <td align="center" >
                                            <asp:DataGrid ID="DataGrid7" runat="server" CssClass="dtGrid" Width="400px" AutoGenerateColumns="False"
                                                OnItemDataBound="DataGrid1_ItemDataBound">
                                                <SelectedItemStyle Font-Size="XX-Small" BackColor="#046791"></SelectedItemStyle>
                                                <Columns>
                                                   
                                                    <asp:TemplateColumn>
                                                        <HeaderTemplate>
                                                            <input id="Cb7"  type="checkbox" name="cb7" onclick="Select7('DataGrid7',this,'cb7');" runat="server" />
                                                        </HeaderTemplate>
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Height="15px"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Center" Width="20px" VerticalAlign="Bottom" Height="15px"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:CheckBox ID="cbx7" CssClass="TextField1" runat="server" />
                                                        </ItemTemplate>
                                                    </asp:TemplateColumn>
                                                    <asp:BoundColumn DataField="D1_LAGN_RASHI" HeaderText="D1_LAGNA_RASHI">
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Bottom"  Width="30px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center"  Width="30px" />
                                                    </asp:BoundColumn>
                                                    
                                                       <asp:BoundColumn DataField="D1_RASHI" HeaderText="D1_RASHI">
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Bottom"  Width="30px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center"  Width="30px" />
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="D9_LAGNA_RASHI" HeaderText="D7_LAGNA_RASHI">
                                                        <ItemStyle  HorizontalAlign="Center" VerticalAlign="Bottom" Width="50px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="50px" />
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="D9_RASHI" HeaderText="D7_RASHI">
                                                        <ItemStyle HorizontalAlign="left" VerticalAlign="Bottom" Width="140px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="140px"/>
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="HOUSE" HeaderText="HOUSE">
                                                        <ItemStyle HorizontalAlign="left" VerticalAlign="Bottom" Width="90px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="90px" />
                                                    </asp:BoundColumn>
                                                   
                                                </Columns>
                                                <HeaderStyle HorizontalAlign="Center" Height="15px" ForeColor="White" CssClass="header"
                                                    BackColor="#7DAAE3"></HeaderStyle>
                                            </asp:DataGrid>
                                            
                                        </td>
                                    </tr>
                                </table>   
                                  </div>  
                  
                  
                  
                  <table cellpadding="0" cellspacing="0" width="400" style="width: auto; margin: 80px;">
                    <tr valign="top">
                        <td align="center" style="height: 200px">
                            <div id="div5" runat="server" style="OVERFLOW: auto; WIDTH: 400px; HEIGHT: 200px; top: 270px; left: 575px; position: absolute;">
                                <table id="Table6" align="center">
                                    <tr>
                                        <td align="center" >
                                            <asp:DataGrid ID="DataGrid10" runat="server" CssClass="dtGrid" Width="400px" AutoGenerateColumns="False"
                                                OnItemDataBound="DataGrid1_ItemDataBound">
                                                <SelectedItemStyle Font-Size="XX-Small" BackColor="#046791"></SelectedItemStyle>
                                                <Columns>
                                                   
                                                    <asp:TemplateColumn>
                                                        <HeaderTemplate>
                                                            <input id="Cb10"  type="checkbox" name="cb10" onclick="Select10('DataGrid10',this,'cb10');" runat="server" />
                                                        </HeaderTemplate>
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Height="15px"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Center" Width="20px" VerticalAlign="Bottom" Height="15px"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:CheckBox ID="cbx10" CssClass="TextField1" runat="server" />
                                                        </ItemTemplate>
                                                    </asp:TemplateColumn>
                                                    <asp:BoundColumn DataField="D1_LAGN_RASHI" HeaderText="D1_LAGNA_RASHI">
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Bottom"  Width="30px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center"  Width="30px" />
                                                    </asp:BoundColumn>
                                                    
                                                       <asp:BoundColumn DataField="D1_RASHI" HeaderText="D1_RASHI">
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Bottom"  Width="30px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center"  Width="30px" />
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="D9_LAGNA_RASHI" HeaderText="D10_LAGNA_RASHI">
                                                        <ItemStyle  HorizontalAlign="Center" VerticalAlign="Bottom" Width="50px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="50px" />
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="D9_RASHI" HeaderText="D10_RASHI">
                                                        <ItemStyle HorizontalAlign="left" VerticalAlign="Bottom" Width="140px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="140px"/>
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="HOUSE" HeaderText="HOUSE">
                                                        <ItemStyle HorizontalAlign="left" VerticalAlign="Bottom" Width="90px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="90px" />
                                                    </asp:BoundColumn>
                                                   
                                                </Columns>
                                                <HeaderStyle HorizontalAlign="Center" Height="15px" ForeColor="White" CssClass="header"
                                                    BackColor="#7DAAE3"></HeaderStyle>
                                            </asp:DataGrid>
                                            
                                        </td>
                                    </tr>
                                </table>   
                                  </div>  
                  
                  
                  
                  
                  <table cellpadding="0" cellspacing="0" width="400" style="width: auto; margin: 80px;">
                    <tr valign="top">
                        <td align="center" style="height: 200px">
                            <div id="div6" runat="server" style="OVERFLOW: auto; WIDTH: 400px; HEIGHT: 200px; top: 270px; left: 575px; position: absolute;">
                                <table id="Table7" align="center">
                                    <tr>
                                        <td align="center" >
                                            <asp:DataGrid ID="DataGrid12" runat="server" CssClass="dtGrid" Width="400px" AutoGenerateColumns="False"
                                                OnItemDataBound="DataGrid1_ItemDataBound">
                                                <SelectedItemStyle Font-Size="XX-Small" BackColor="#046791"></SelectedItemStyle>
                                                <Columns>
                                                   
                                                    <asp:TemplateColumn>
                                                        <HeaderTemplate>
                                                            <input id="Cb12"  type="checkbox" name="cb12" onclick="Select12('DataGrid12',this,'cb12');" runat="server" />
                                                        </HeaderTemplate>
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Height="15px"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Center" Width="20px" VerticalAlign="Bottom" Height="15px"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:CheckBox ID="cbx12" CssClass="TextField1" runat="server" />
                                                        </ItemTemplate>
                                                    </asp:TemplateColumn>
                                                    <asp:BoundColumn DataField="D1_LAGN_RASHI" HeaderText="D1_LAGNA_RASHI">
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Bottom"  Width="30px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center"  Width="30px" />
                                                    </asp:BoundColumn>
                                                    
                                                       <asp:BoundColumn DataField="D1_RASHI" HeaderText="D1_RASHI">
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Bottom"  Width="30px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center"  Width="30px" />
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="D9_LAGNA_RASHI" HeaderText="D12_LAGNA_RASHI">
                                                        <ItemStyle  HorizontalAlign="Center" VerticalAlign="Bottom" Width="50px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="50px" />
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="D9_RASHI" HeaderText="D12_RASHI">
                                                        <ItemStyle HorizontalAlign="left" VerticalAlign="Bottom" Width="140px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="140px"/>
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="HOUSE" HeaderText="HOUSE">
                                                        <ItemStyle HorizontalAlign="left" VerticalAlign="Bottom" Width="90px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="90px" />
                                                    </asp:BoundColumn>
                                                   
                                                </Columns>
                                                <HeaderStyle HorizontalAlign="Center" Height="15px" ForeColor="White" CssClass="header"
                                                    BackColor="#7DAAE3"></HeaderStyle>
                                            </asp:DataGrid>
                                            
                                        </td>
                                    </tr>
                                </table>   
                                  </div>  
                  
                  
                  
                  <table cellpadding="0" cellspacing="0" width="400" style="width: auto; margin: 80px;">
                    <tr valign="top">
                        <td align="center" style="height: 200px">
                            <div id="div7" runat="server" style="OVERFLOW: auto; WIDTH: 400px; HEIGHT: 200px; top: 270px; left: 575px; position: absolute;">
                                <table id="Table8" align="center">
                                    <tr>
                                        <td align="center" >
                                            <asp:DataGrid ID="DataGrid16" runat="server" CssClass="dtGrid" Width="400px" AutoGenerateColumns="False"
                                                OnItemDataBound="DataGrid1_ItemDataBound">
                                                <SelectedItemStyle Font-Size="XX-Small" BackColor="#046791"></SelectedItemStyle>
                                                <Columns>
                                                   
                                                    <asp:TemplateColumn>
                                                        <HeaderTemplate>
                                                            <input id="Cb16"  type="checkbox" name="cb16" onclick="Select16('DataGrid16',this,'cb16');" runat="server" />
                                                        </HeaderTemplate>
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Height="15px"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Center" Width="20px" VerticalAlign="Bottom" Height="15px"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:CheckBox ID="cbx16" CssClass="TextField1" runat="server" />
                                                        </ItemTemplate>
                                                    </asp:TemplateColumn>
                                                    <asp:BoundColumn DataField="D1_LAGN_RASHI" HeaderText="D1_LAGNA_RASHI">
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Bottom"  Width="30px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center"  Width="30px" />
                                                    </asp:BoundColumn>
                                                    
                                                       <asp:BoundColumn DataField="D1_RASHI" HeaderText="D1_RASHI">
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Bottom"  Width="30px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center"  Width="30px" />
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="D9_LAGNA_RASHI" HeaderText="D16_LAGNA_RASHI">
                                                        <ItemStyle  HorizontalAlign="Center" VerticalAlign="Bottom" Width="50px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="50px" />
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="D9_RASHI" HeaderText="D16_RASHI">
                                                        <ItemStyle HorizontalAlign="left" VerticalAlign="Bottom" Width="140px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="140px"/>
                                                    </asp:BoundColumn>
                                                    <asp:BoundColumn DataField="HOUSE" HeaderText="HOUSE">
                                                        <ItemStyle HorizontalAlign="left" VerticalAlign="Bottom" Width="90px" Height="15px"></ItemStyle>
                                                        <HeaderStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                            Font-Underline="False" ForeColor="White" HorizontalAlign="Center" Width="90px" />
                                                    </asp:BoundColumn>
                                                   
                                                </Columns>
                                                <HeaderStyle HorizontalAlign="Center" Height="15px" ForeColor="White" CssClass="header"
                                                    BackColor="#7DAAE3"></HeaderStyle>
                                            </asp:DataGrid>
                                            
                                        </td>
                                    </tr>
                                </table>   
                                  </div>  
                  
                  
                  </td></tr></table>     
 
 
        
    </div>
    <input type="hidden" runat="server" id="tblfields"/>
<input type="hidden" runat="server" id="hiddendateformat"/>
<input type="hidden" runat="server" id="hiddenvalue" />
<input type="hidden" runat="server" id="fields" />
    </form>
</body>
</html>
