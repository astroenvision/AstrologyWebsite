<%@ Page Language="C#" AutoEventWireup="true" CodeFile="testpage.aspx.cs" Inherits="responsive_dropdown_menu_testpage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="horary_menu.ascx" TagName="horarymenubar" TagPrefix="uc1" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Menu</title>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <uc1:horarymenubar ID="horarymenubar1" runat="server" />
    </div>
    </form>
</body>
</html>
