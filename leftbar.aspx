<%@ Page Language="C#" AutoEventWireup="true" CodeFile="leftbar.aspx.cs" Inherits="leftbar" %>
<%@ register TagPrefix="uc1" TagName="Topbar" Src="~/Topbarnew_n.ascx"%>
<%@ register TagPrefix="uc2" TagName="Leftbar" Src="~/Leftbanr_n.ascx"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Left Bar</title>
    
    <style type="text/css">.style1 { FONT-WEIGHT: bold; COLOR: #ffffff; FONT-FAMILY: Verdana, Arial, Helvetica, sans-serif }
	.style2 { COLOR: #ffffff }
	</style>
	
</head>
<body style="margin-top:0px;">
    <form id="form1" runat="server" method="post">
   <table id="OuterTable" width="100%" height="100%" align="center" border="0" cellpadding="0"
				cellspacing="0">
				<tr valign="top">
					<td colSpan="2" valign="Top">
					<uc1:topbar id="Topbar1" runat="server" Text="Enter Page"></uc1:topbar></td>
				</tr>
				<tr valign="top" >
					<td valign="top" >
					<uc2:leftbar id="Leftbar1" runat="server" ></uc2:leftbar></td>
					<td valign="top"  align="left">
						<iframe style=" BACKGROUND-COLOR:white; "    id="detail" frameBorder="0" width=780  height="600" ></iframe></td></tr>
			</table>
    </form>
</body>
</html>
