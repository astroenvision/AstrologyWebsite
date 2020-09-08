<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Leftbar.ascx.cs" Inherits="Leftbar" %>
<LINK href="css/image.css" type="text/css" rel="stylesheet">
<table border="0" cellpadding="0" cellspacing="0" >
    <tr valign="top" style="height:35px">
        <td valign="baseline" colspan="3">
            <div id="tP1" runat="server" class="topbarclock1" align="center"><asp:Label id="lbrelease" runat="server"></asp:Label></div>
        </td>
    </tr>
   <%--<tr>
    <td>
       <table cellpadding="0" cellspacing="0" align="center">
         <tr>
            <td style="background-image:url(images/corner-left.jpg);width:11px; background-position:right center; background-repeat:no-repeat; height:20px;"></td>
            <td style="width:135PX;font-family:Verdana;text-align:right;font-size:10px;background-color:#a0bfeb; height:20px;"><b><center><%=Text%></center></b></td>
            <td style="background-image:url(images/corner-right.jpg); background-repeat:no-repeat; height:20px;width:11px"></td>
         </tr>
       </table>
     </td>  
    </tr>--%>
    <script runat="server" language="C#">
    public String Text = "";
    
</script>
    
</table>



