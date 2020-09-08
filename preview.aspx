<%@ Page Language="C#" AutoEventWireup="true" CodeFile="preview.aspx.cs" Inherits="preview" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Preview</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="div1" runat="server">
      <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
    
    </div>
    
  
    <input id="hiddenusername" runat="server" type="hidden" name="username"/>
   	<input id="hiddencustuserid" runat="server" type="hidden" name="hiddencustid" />
   	<input id="hiddenfilename" runat="server" type="hidden" name="hiddenfilename" />
   	<input id="hiddenpheight" runat="server" type="hidden" name="hiddenpheight" style="width: 47px">
    <input id="hiddenpwidth" runat="server" type="hidden" name="hiddenpwidth" style="width: 47px">
    <input id="hiddenjobid" runat="server" type="hidden" name="hiddenjobid" style="width: 47px"/>
    </form>
</body>
</html>
