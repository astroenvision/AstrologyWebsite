<%@ Page Language="C#" AutoEventWireup="true" CodeFile="planetfromplanet.aspx.cs" Inherits="planetfromplanet" %>
<%@ register TagPrefix="uc1" TagName="topbar" Src="~/topbarnew.ascx"%>
<%@ register TagPrefix="uc2" TagName="Leftbar" Src="~/leftbar.ascx"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>planet from planet</title>
     <script type="text/javascript" language="javascript" src="javascript/planetfromplanet.js"></script>
      <link href="css/combine.css" type="text/css" rel="stylesheet" />
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
     <asp:UpdatePanel ID="UpdatePanel4" runat="server"><ContentTemplate>
    <table>   
         <tr valign="top" >
			<td><asp:ImageButton id="btnNew" runat="server"   Font-Size="XX-Small" 
                    BackColor="Control" BorderStyle="Outset"  Font-Bold="True" 
                    ImageUrl="~/Image/new.jpg"  ></asp:ImageButton>
            
                <asp:ImageButton id="btnModify" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/modify.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnQuery" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/query.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnExecute" runat="server" Font-Size="XX-Small"
										BackColor="Control" BorderStyle="Outset"  Font-Bold="True" 
                    ImageUrl="~/Image/execute.jpg" onclick="btnExecute_Click" ></asp:ImageButton>
                <asp:ImageButton id="btnCancel" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/clear.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnfirst"  runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/first.jpg" Width="70px" Height="27px" onclick="btnfirst_Click" 
                    ></asp:ImageButton>
                <asp:ImageButton id="btnprevious" runat="server" Font-Size="XX-Small"
										BackColor="Control" BorderStyle="Outset"  Font-Bold="True" 
                    ImageUrl="~/Image/previous.jpg" onclick="btnprevious_Click"  ></asp:ImageButton>
                <asp:ImageButton id="btnnext" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/next.jpg" onclick="btnnext_Click"  ></asp:ImageButton>
                <asp:ImageButton id="btnlast" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/last.jpg" Width="70px" Height="27px" onclick="btnlast_Click" 
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
                     </ContentTemplate></asp:UpdatePanel>
       <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>              
       <table>
      
          <asp:ImageButton id="btnSave" 
                    runat="server"  Font-Size="XX-Small" BackColor="Control" BorderStyle="Outset" 
                    BorderColor="DarkGray" Font-Bold="True" ImageUrl="~/Image/save.jpg" 
               onclick="btnSave_Click" ></asp:ImageButton>   
     
       </table>
      </ContentTemplate></asp:UpdatePanel>
        
        
        
    <table>  
    <tr>
	<td style="padding-left:00px;">
	<table align="left" cellspacing="0" cellpadding="0" style="width: 550px">

  <tr>    
  <td style="padding-left:20px;"> 
  <asp:Label ID="Label1" runat="server" Text="Planet">
  </asp:Label>
  </td>
  
  <td style="padding-left:20px;">
  <asp:DropDownList ID="planet"  runat="server" Width="100px" height="22px">
  </asp:DropDownList>
  </td>
  
  <td style="padding-left:20px;">
  <asp:Label ID="Label2" runat="server" Text="In">
  </asp:Label>
  </td>
  
  <td style="padding-left:20px;">      
  <asp:UpdatePanel ID="UpdatePanel2" runat="server"><ContentTemplate>    
  <asp:DropDownList ID="house"  runat="server" Width="100px" AutoPostBack="True" onselectedindexchanged="house_SelectedIndexChanged" height="22px">
  </asp:DropDownList>
  </ContentTemplate></asp:UpdatePanel>
  </td>
  
  <td style="padding-left:20px;">
  <asp:Label ID="Label3" runat="server" Text="From">
  </asp:Label>
  </td>
  
  <td style="padding-left:20px;">
  <asp:DropDownList ID="planet1"  runat="server" Width="100px" height="22px">
  </asp:DropDownList>
  </td>
  </tr>
  
  <tr>
  <td style="padding-left:20px;">
  <asp:Label ID="Label4" runat="server" Text="Book">
  </asp:Label>
  </td>
  
  <td style="padding-left:20px;">
  <asp:TextBox ID="book" runat="server" height="20px" width="110px">
  </asp:TextBox>
  </td>
  
  <td style="padding-left:20px;">
  <asp:Label ID="Label6" runat="server" Text="Key ">
  </asp:Label>
  </td>
  
  <td style="padding-left:20px;">
  <asp:TextBox ID="keystring" runat="server" height="20px" width="110px">
  </asp:TextBox>
  </td>
  
  </tr>
  </table>  
</td>
</tr>
 </table>
 
 <table>           
<tr>
<td style="padding-left:00px;">
<table align="left" cellspacing="0" cellpadding="0"  style="width: 550px">
  
<tr>
<td style="padding-left:20px;" >  
<asp:Label ID="Label5" runat="server" Text="Description">
</asp:Label>
<asp:TextBox ID="description" runat="server" Width="400px" height="20px">
</asp:TextBox>
</td>
</tr>

<tr>
<td style="padding-left:20px;">
<asp:TextBox ID="detail" runat="server"  Height="120px" Width="470px" 
        TextMode="MultiLine"></asp:TextBox>
</td>
</tr>
</table>
</td>
</tr>
</table>
</div>



<asp:UpdatePanel ID="UpdatePanel3" runat="server"><ContentTemplate>
<div id="div1" runat="server" style="OVERFLOW: auto; WIDTH: 360px; HEIGHT: 306px; top: 120px; left: 600px; position: absolute;">
                   
                   
    <asp:GridView 
                       ID="GridView1" runat="server" AutoGenerateColumns="False"  CellPadding="4" 
                         ForeColor="#333333" GridLines="None" Height="79px" 
        Width="354px" HorizontalAlign="Left"  >
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#EFF3FB" />
       
        <Columns>
      
       <asp:TemplateField  >
       <HeaderTemplate>
       <asp:CheckBox ID="checkselect" runat="server" EnableViewState = "true" AutoPostBack="true" OnCheckedChanged="cbCheckAll_CheckedChanged" />
       </HeaderTemplate>
    <ItemTemplate>
    
    <asp:CheckBox ID="check1" runat="server" AutoPostBack="true"  OnCheckedChanged="cbCheckeach_CheckedChanged"/>
    </ItemTemplate>
    </asp:TemplateField>
          
          
            <asp:BoundField DataField="LAGNA_RASHI" HeaderText="Lagna Rashi" SortExpression="RASHI_CODE" />
            <asp:BoundField DataField="FROM_PLANET_HOUSE" HeaderText="From Planet House" SortExpression="RASHI_CODE" />
            <asp:BoundField DataField="FROM_PLANET_RASHI" HeaderText="From Planet Rashi" SortExpression="RASHI_CODE" />
            <asp:BoundField DataField="HOUSE" HeaderText="House" />
            <asp:BoundField DataField="RASHI" HeaderText="Rashi"  />
            
                
        
        </Columns>
        
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>              
                   
                   
                   
</div>
    
    </ContentTemplate></asp:UpdatePanel>
    
      <div id="div2" runat="server"   style="OVERFLOW: auto; WIDTH: 423px; HEIGHT: 180px; top: 430px; left: 575px; position: absolute;">            
  
                       <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                           CellPadding="4" ForeColor="#333333" GridLines="None">
                           <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                           <RowStyle BackColor="#EFF3FB" />
                           <Columns>
            <asp:BoundField DataField="RASHI" HeaderText="Rashi" SortExpression="RASHI_CODE" />        
            <asp:BoundField DataField="LORD" HeaderText="Lord" SortExpression="RASHI_CODE" />
            <asp:BoundField DataField="DESCRIPTION" HeaderText="Description" SortExpression="RASHI_CODE" />
            
               
                           </Columns>
                           <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                           <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                           <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                           <EditRowStyle BackColor="#2461BF" />
                           <AlternatingRowStyle BackColor="White" />
                       </asp:GridView>
                       
    </div>
    <input type="hidden" runat="server" id="tblfields"/>
     <input type="hidden" runat="server" id="hiddendateformat"/>
    
       <input type="hidden" runat="server" id="valuehidden"/>
     <input type="hidden" runat="server" id="fields" />
     <input type="hidden" runat="server" id="hiddenvalue" />
     <input id="hdnuserid" type="hidden" runat="server" name="hdnuserid"/>
     <input type="hidden" runat="server" id="executefields" />
<input type="hidden" runat="server" id="deltblfields" />
<input type="hidden" runat="server" id="Hidden1"/>
<input type="hidden" runat="server" id="Hidden2"/>
<input type="hidden" runat="server" id="Hidden3"/>
<input type="hidden" runat="server" id="Hidden4"/>
<input type="hidden" runat="server" id="Hidden5"/>
<input type="hidden" runat="server" id="Hidden6"/>
<input type="hidden" runat="server" id="Hidden7"/>
<input type="hidden" runat="server" id="Hidden8"/>
<input type="hidden" runat="server" id="Hidden9"/>
<input type="hidden" runat="server" id="Hidden10"/>
<input type="hidden" runat="server" id="Hidden11"/>
<input type="hidden" runat="server" id="Hidden12"/>





    </form>
</body>
</html>
