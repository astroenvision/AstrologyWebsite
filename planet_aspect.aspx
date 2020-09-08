<%@ Page Language="C#" AutoEventWireup="true" CodeFile="planet_aspect.aspx.cs" Inherits="planet_aspect" %>
<%@ register TagPrefix="uc1" TagName="topbar" Src="~/topbarnew.ascx"%>
<%@ register TagPrefix="uc2" TagName="Leftbar" Src="~/leftbar.ascx"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title>Planet Aspect</title>
    <script type="text/javascript" language="javascript" src="javascript/planetaspect.js"></script>
    <script language="javascript" src="javascript/prototype.js" type="text/javascript">
</script>
   <style type="text/css">
   </style>
</head>
<body id="body"   style="background-color:#f3f6fd;margin:0px 0px 0px 0px">
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
                    ImageUrl="~/Image/execute.jpg" onclick="btnExecute_Click"></asp:ImageButton>
                <asp:ImageButton id="btnCancel" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/clear.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnfirst"  runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/first.jpg" Width="70px" Height="27px" 
                    onclick="btnfirst_Click"></asp:ImageButton>
                <asp:ImageButton id="btnprevious" runat="server" Font-Size="XX-Small"
										BackColor="Control" BorderStyle="Outset"  Font-Bold="True" 
                    ImageUrl="~/Image/previous.jpg" onclick="btnprevious_Click" ></asp:ImageButton>
                <asp:ImageButton id="btnnext" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/next.jpg" onclick="btnnext_Click" ></asp:ImageButton>
                <asp:ImageButton id="btnlast" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/last.jpg" Width="70px" Height="27px" 
                    onclick="btnlast_Click" ></asp:ImageButton>
                <asp:ImageButton id="btnDelete" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/delete.jpg" ></asp:ImageButton>
                <asp:ImageButton id="btnExit" runat="server"  Font-Size="XX-Small" BackColor="Control"
										BorderStyle="Outset" BorderColor="DarkGray" Font-Bold="True" 
                    ImageUrl="~/Image/exit.jpg" ></asp:ImageButton>
								</td>
							</tr>
                             
                                        	
                              
                                 
                    </table>   
                     </ContentTemplate></asp:UpdatePanel></div>
                     
            <table>
            
            <asp:ImageButton id="btnSave" 
                    runat="server"  Font-Size="XX-Small" BackColor="Control" BorderStyle="Outset" 
                    BorderColor="DarkGray" Font-Bold="True" ImageUrl="~/Image/save.jpg" 
                    onclick="btnSave_Click" ></asp:ImageButton>
        </table>
        
        

          
       
    <table align="left">  
    <tr>
	<td >
	<table align="left" cellspacing="0" cellpadding="0" style="width: 550px">
  
   <tr>    
  <td style="padding-left:20px;" > 
  <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate> 
  <asp:DropDownList ID="astrocat" runat="server" style=" height: 16px; width: 90px" AutoPostBack="True" onselectedindexchanged="astrocat_SelectedIndexChanged">
  </asp:DropDownList>
  </ContentTemplate></asp:UpdatePanel> 
</td>

<td style="padding-left:20px;">
<asp:UpdatePanel ID="UpdatePanel7" runat="server"><ContentTemplate>
 <asp:DropDownList ID="planet" runat="server" style="  height: 16px; width: 90px" Visible="False">
 </asp:DropDownList>

 <asp:DropDownList ID="DropDownList1" runat="server"   style=" height: 16px; width: 90px">
  </asp:DropDownList>
  </ContentTemplate></asp:UpdatePanel> 
 </td>
  
  
  

<td style="padding-left:20px;">
 <asp:UpdatePanel ID="UpdatePanel6" runat="server"><ContentTemplate>
 <asp:DropDownList ID="DropDownList2" runat="server"  Height="16px" Width="90px" >
 </asp:DropDownList>
 </ContentTemplate></asp:UpdatePanel> 
</td>
 
 
 <td style="padding-left:20px;">
  <asp:UpdatePanel ID="UpdatePanel5" runat="server"><ContentTemplate>
  <asp:DropDownList ID="house" runat="server" AutoPostBack="True" onselectedindexchanged="house_SelectedIndexChanged" Height="16px" Width="90px" >
  </asp:DropDownList>
  </ContentTemplate></asp:UpdatePanel> 
</td>



</tr> 
  
  <tr>
  <td  style="padding-left:20px;"> 
  <asp:Label ID="Label1" runat="server" Text="Book"></asp:Label>
  </td>
  
  <td  style="padding-left:20px;">
  <asp:TextBox ID="book" runat="server" style=" height: 15px; width: 100px; " ></asp:TextBox>
  </td>
    
    <td style="padding-left:20px;"> 
   <asp:Label ID="Label2" runat="server" Text="Key"></asp:Label>
   </td>
   
   <td style="padding-left:20px;">
   <asp:TextBox ID="keystring" runat="server" style=" height: 15px; width: 100px; " ></asp:TextBox>
    </td>
   </tr>
   
   
   
  </table>
  </td>
  </tr>
 
  
        
<tr>
<td style="padding-left:00px;">
<table align="left" cellspacing="0" cellpadding="0"  style="width: 550px">
  
<tr>
<td style="padding-left:20px;" >  
<asp:Label ID="Label5" runat="server" Text="Description">
</asp:Label>
<asp:TextBox ID="Textdesc" runat="server" style=" height: 15px; width: 400px; " ></asp:TextBox>
 </td>
</tr>

 <tr>
<td style="padding-left:100px;">
 <asp:TextBox ID="detaildesc" runat="server" TextMode="MultiLine" style=" height: 120px; width: 410px;">
 </asp:TextBox>  
 </td>
 </tr>
</table> 
 </td>
 </tr>
 
 
 
 </table>        
            
 
  
                 
                 
                  
                  
                  
                  
                  
   
  
                      
<asp:UpdatePanel ID="UpdatePanel3" runat="server"><ContentTemplate>
<div id="div1" runat="server" 
                   
                   
        style="OVERFLOW: auto; WIDTH: 360px; HEIGHT: 306px; top: 130px; left: 575px; position: absolute;">
                   
                   
    <asp:GridView 
                       ID="GridView1" runat="server" AutoGenerateColumns="False"  CellPadding="4" 
                         ForeColor="#333333" GridLines="None" Height="79px" 
        Width="354px" HorizontalAlign="Left" 
         >
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#EFF3FB" />
       
        <Columns>
      
       <asp:TemplateField  >
       <HeaderTemplate>
       <asp:CheckBox ID="checkselect" runat="server" EnableViewState = "true" AutoPostBack="true" runat="server"  OnCheckedChanged="cbCheckAll_CheckedChanged" />
       </HeaderTemplate>
    <ItemTemplate>
    
    <asp:CheckBox ID="check1" runat="server" AutoPostBack="true"  OnCheckedChanged="cbCheckeach_CheckedChanged"/>
    </ItemTemplate>
    </asp:TemplateField>
          <asp:BoundField DataField="PLANET_CODE" HeaderText="Lord" SortExpression="PLANET_CODE" />
          
            <asp:BoundField DataField="RASHI_CODE" HeaderText="Rashi" SortExpression="RASHI_CODE" />
              <asp:BoundField DataField="ASPECT_HOUSE" HeaderText="House" SortExpression="ASPECTS_HOUSE" />
                <asp:BoundField DataField="RASHI_OF_HOUSE1" HeaderText="Rashi of House1" SortExpression="ASPECTS_HOUSE" />
                <asp:BoundField DataField="HOUSE_CODE" HeaderText="Rashi of Aspect House" SortExpression="ASPECTS_HOUSE" />
        
        </Columns>
        
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>              
                   
                   
                   
                   
                   
                <asp:GridView 
                       ID="GridView4" runat="server" AutoGenerateColumns="False"  CellPadding="4" 
                         ForeColor="#333333" GridLines="None" Height="79px" 
        Width="354px"  >
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#EFF3FB" />
       
        <Columns>
      
       <asp:TemplateField  >
       <HeaderTemplate>
       <asp:CheckBox ID="checkselect1" runat="server" EnableViewState = "true" AutoPostBack="true" OnCheckedChanged="cbCheckAll1_CheckedChanged"   />
       </HeaderTemplate>
    <ItemTemplate>
    
    <asp:CheckBox ID="check2" runat="server" AutoPostBack="true"  OnCheckedChanged="cbCheckeach1_CheckedChanged"  />
    </ItemTemplate>
    </asp:TemplateField>
       <asp:BoundField DataField="RASHI_CODE" HeaderText="Rashi of House1"  />
          <asp:BoundField DataField="WITHLORD_OF_HOUSE" HeaderText="Lord Of House" />
          
            
              
                <asp:BoundField DataField="LORD_OF_HOUSE" HeaderText="With Lord Of House"  />
        <asp:BoundField DataField="HOUSE" HeaderText="House"  />
         <asp:BoundField DataField="FIRST_HOUSE" HeaderText="Rashi"  />
          <asp:BoundField DataField="SECOND_HOUSE" HeaderText="Rashi Of House"  />
        </Columns>
        
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>     
                   
                    <asp:GridView 
                       ID="GridView6" runat="server" AutoGenerateColumns="False"  CellPadding="4" 
                         ForeColor="#333333" GridLines="None" Height="79px" 
        Width="354px"  >
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#EFF3FB" />
       
        <Columns>
      
       <asp:TemplateField  >
       <HeaderTemplate>
       <asp:CheckBox ID="checkselect2" runat="server" EnableViewState = "true" AutoPostBack="true" OnCheckedChanged="cbCheckAll2_CheckedChanged"   />
       </HeaderTemplate>
    <ItemTemplate>
    
    <asp:CheckBox ID="check3" runat="server" AutoPostBack="true"  OnCheckedChanged="cbCheckeach2_CheckedChanged"  />
    </ItemTemplate>
    </asp:TemplateField>
       <asp:BoundField DataField="RASHI_CODE" HeaderText="Rashi of House1"  />
          <asp:BoundField DataField="LORD_OF_HOUSE" HeaderText="Lord Of House" />
          
            
              
                
        <asp:BoundField DataField="SECOND_HOUSE" HeaderText="House"  />
        <asp:BoundField DataField="WITHLORD_OF_HOUSE" HeaderText="Rashi"  />
           <asp:BoundField DataField="FIRST_HOUSE" HeaderText="Rashi Of House"  />
        </Columns>
        
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>  
    
     <asp:GridView 
                       ID="GridView8" runat="server" AutoGenerateColumns="False"  CellPadding="4" 
                         ForeColor="#333333" GridLines="None" Height="79px" 
        Width="354px" HorizontalAlign="Left"  >
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#EFF3FB" />
       
        <Columns>
      
       <asp:TemplateField  >
       <HeaderTemplate>
       <asp:CheckBox ID="checkselect8" runat="server" EnableViewState = "true" AutoPostBack="true" runat="server"  OnCheckedChanged="cbCheckAll8_CheckedChanged" />
       </HeaderTemplate>
    <ItemTemplate>
    
    <asp:CheckBox ID="check8" runat="server" AutoPostBack="true"  OnCheckedChanged="cbCheckeach8_CheckedChanged"/>
    </ItemTemplate>
    </asp:TemplateField>
          <asp:BoundField DataField="RASHI_CODE" HeaderText="Rashi Of House1" />
          
            <asp:BoundField DataField="LORD_OF_HOUSE" HeaderText="LORD"/>
              <asp:BoundField DataField="SECOND_HOUSE" HeaderText="House"/>
                <asp:BoundField DataField="FIRST_HOUSE" HeaderText="Aspect House"/>
                <asp:BoundField DataField="WITHLORD_OF_HOUSE" HeaderText="Rashi"/>
                <asp:BoundField DataField="HOUSE" HeaderText="Rashi Of Aspect House"/>
        
        </Columns>
        
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>     
    
                   
                   </div>
                   </ContentTemplate></asp:UpdatePanel>
    
<table>
                   <div id="div2" runat="server"   style="OVERFLOW: auto; WIDTH: 423px; HEIGHT: 180px; top: 450px; left: 575px; position: absolute;">            
  
                       <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                           CellPadding="4" ForeColor="#333333" GridLines="None">
                           <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                           <RowStyle BackColor="#EFF3FB" />
                           <Columns>
                           <asp:BoundField DataField="LORD_OF_HOUSE2" HeaderText="Aspects" SortExpression="PLANET_CODE" />
       
          <asp:BoundField DataField="LORD" HeaderText="Lord" SortExpression="PLANET_CODE" />
          
            <asp:BoundField DataField="RASHI" HeaderText="Rashi" SortExpression="RASHI_CODE" />
              <asp:BoundField DataField="HOUSE" HeaderText="House" SortExpression="ASPECTS_HOUSE" />
             <asp:BoundField DataField="DESCRIPTION" HeaderText="Description" SortExpression="ASPECTS_HOUSE" />   
        
                           </Columns>
                           <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                           <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                           <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                           <EditRowStyle BackColor="#2461BF" />
                           <AlternatingRowStyle BackColor="White" />
                       </asp:GridView>
                       
                        <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                           CellPadding="4" ForeColor="#333333" GridLines="None">
                           <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                           <RowStyle BackColor="#EFF3FB" />
                           <Columns>
                           <asp:BoundField DataField="LORD_OF_HOUSE2" HeaderText="LORD_OF_HOUSE2" SortExpression="PLANET_CODE" />
       
          <asp:BoundField DataField="WITH_LORD" HeaderText="With Lord" SortExpression="PLANET_CODE" />
          
            <asp:BoundField DataField="LORD" HeaderText="Lord" SortExpression="RASHI_CODE" />
              <asp:BoundField DataField="HOUSE" HeaderText="House" SortExpression="ASPECTS_HOUSE" />
             <asp:BoundField DataField="DESCRIPTION" HeaderText="Description" SortExpression="ASPECTS_HOUSE" />   
        
                           </Columns>
                           <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                           <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                           <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                           <EditRowStyle BackColor="#2461BF" />
                           <AlternatingRowStyle BackColor="White" />
                       </asp:GridView>
                       
                       <asp:GridView ID="GridView7" runat="server" AutoGenerateColumns="False" 
                           CellPadding="4" ForeColor="#333333" GridLines="None">
                           <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                           <RowStyle BackColor="#EFF3FB" />
                           <Columns>
                           <asp:BoundField DataField="RASHI_OF_LAGNA" HeaderText="Lagna" SortExpression="RASHI_CODE" />
            <asp:BoundField DataField="LORD" HeaderText="Lord" SortExpression="RASHI_CODE" />
                           <asp:BoundField DataField="LORD_OF_HOUSE2" HeaderText="LORD_OF_HOUSE2" SortExpression="PLANET_CODE" />
       
          
          
           
          
             <asp:BoundField DataField="DESCRIPTION" HeaderText="Description" SortExpression="ASPECTS_HOUSE" />   
        
                           </Columns>
                           <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                           <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                           <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                           <EditRowStyle BackColor="#2461BF" />
                           <AlternatingRowStyle BackColor="White" />
                       </asp:GridView>
                       
                       
                        <asp:GridView 
                       ID="GridView9" runat="server" AutoGenerateColumns="False"  CellPadding="4" 
                         ForeColor="#333333" GridLines="None" Height="79px" 
        Width="354px" HorizontalAlign="Left"  >
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#EFF3FB" />
       
        <Columns>
      <asp:BoundField DataField="LORD_OF_HOUSE" HeaderText="Aspect House"/>
      <asp:BoundField DataField="LORD" HeaderText="Lord"/>
          <asp:BoundField DataField="RASHI_OF_LAGNA" HeaderText="Rashi" />
          
          
          <asp:BoundField DataField="HOUSE" HeaderText="House"/>
          <asp:BoundField DataField="DESCRIPTION" HeaderText="Description"/>
          
        </Columns>
        
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <AlternatingRowStyle BackColor="White" />
    </asp:GridView>     
  
    </div></table>
<input type="hidden" runat="server" id="tblfields"/>
     <input type="hidden" runat="server" id="hiddendateformat"/>
      <input type="hidden" runat="server" id="Hidden4"/>
      <input type="hidden" runat="server" id="Hidden1"/>
      <input type="hidden" runat="server" id="Hidden2"/>
       <input type="hidden" runat="server" id="valuehidden"/>
     <input type="hidden" runat="server" id="fields" />
     <input type="hidden" runat="server" id="hiddenvalue" />
     <input id="hdnuserid" type="hidden" runat="server" name="hdnuserid"/>
     <input type="hidden" runat="server" id="executefields" />
<input type="hidden" runat="server" id="deltblfields" />
<input type="hidden" runat="server" id="lord11"/>
<input type="hidden" runat="server" id="rashi11"/>
<input type="hidden" runat="server" id="hou11"/>
<input type="hidden" runat="server" id="Hidden3"/>
<input type="hidden" runat="server" id="Hidden5"/>
<input type="hidden" runat="server" id="Hidden6"/>
<input type="hidden" runat="server" id="Hidden7"/>
<input type="hidden" runat="server" id="Hidden8"/>
<input type="hidden" runat="server" id="Hidden9"/>
<input type="hidden" runat="server" id="Hidden10"/>
<input type="hidden" runat="server" id="Hidden11"/>
<input type="hidden" runat="server" id="Hidden12"/>
<input type="hidden" runat="server" id="Hidden13"/>
<input type="hidden" runat="server" id="Hidden14"/>
<input type="hidden" runat="server" id="Hidden15"/>
<input type="hidden" runat="server" id="Hidden16"/>
<input id="hidrowlen" type="hidden" runat="server" />
<input type="hidden" runat="server" id="Hidden17"/>

<input type="hidden" runat="server" id="Hidden18"/>
<input type="hidden" runat="server" id="Hidden19"/>
<input type="hidden" runat="server" id="Hidden20"/>
<input type="hidden" runat="server" id="Hidden21"/>
<input type="hidden" runat="server" id="Hidden22"/>
<input type="hidden" runat="server" id="Hidden23"/>
<input type="hidden" runat="server" id="Hidden24"/>
<input type="hidden" runat="server" id="Hidden25"/>
<input type="hidden" runat="server" id="Hidden26"/>
<input type="hidden" runat="server" id="Hidden27"/>
<input type="hidden" runat="server" id="Hidden28"/>
<input type="hidden" runat="server" id="Hidden29"/>
<input type="hidden" runat="server" id="Hidden30"/>
<input type="hidden" runat="server" id="Hidden31"/>
<input type="hidden" runat="server" id="Hidden32"/>
<input type="hidden" runat="server" id="Hidden33"/>
<input type="hidden" runat="server" id="Hidden34"/>
<input type="hidden" runat="server" id="Hidden35"/>
<input type="hidden" runat="server" id="Hidden36"/>

<input type="hidden" runat="server" id="Hidden37"/>
<input type="hidden" runat="server" id="Hidden38"/>

    </form>
</body>
</html>
