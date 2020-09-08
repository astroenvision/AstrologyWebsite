<%@ Control Language="C#" AutoEventWireup="true" CodeFile="leftbanr.ascx.cs" Inherits="leftbanr" %>

<script language="javascript" src="javascript/givenpermission.js"></script>


<table cellSpacing="0" cellPadding="0" border="0">
	<tr valign="top">
		<td valign="baseline"><div id="tP1" class="topbarclock"></div>
		</td>
	</tr>
	<tr valign="top">
		<td background="image/leftbar.jpg"><div id="FIND_LIST" style="BACKGROUND-IMAGE: url(http://localhost/Adbooking/image/leftbar.jpg); VISIBILITY:visible; "><%=tree%></div>
		</td>
	</tr>
	
</table>
<input id="hiddenusername" type="hidden" runat="server" />
<script type="text/javascript">    Clock();</script>