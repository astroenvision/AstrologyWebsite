﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="topbarnew.ascx.cs" Inherits="topbarnew" %>
<link href="css/image.css" type="text/css" rel="stylesheet"/>
<script type="text/javascript" language="javascript" src="javascript/tree.js" ></script>
<script type="text/javascript" language="javascript" src="javascript/TreeLibrary.js"></script>
<script type="text/javascript" language="javascript">
</script>
<LINK href="css/main.css" type="text/css" rel="stylesheet">
<div class="n_topbar">
<div  class="n_logo"><img id="imglogo" runat="server" src="image/logo.jpg" width="148" height="68" />
</div>
<div class="n_top">
<div class="n_t_inside">
<ul>
<li runat="server"  id="_lbuser" >.</li>
<li runat="server"  id="_user" ></li>
<li runat="server"  id="_lbcom" ></li>
<li runat="server" ID="_com" ></li>
<li runat="server" Id="_lbadmin"></li>
<li runat="server" id="_admin"></li>
</ul>
</div>

<div class="n_t_inside2" align="right">
<ul>
<li><asp:Label ID="lbladaccount" runat="server" CssClass="newDAMS" ForeColor="#5050A4">Subscription</asp:Label></li>
<li class="lougout " align="left" id="Formnamezz" style="align:right; text-align:right; width:530px" onclick="javascript:return logoutpage();">Logout</li>
<img src ="Image/logout-icon.gif" style="align:right;text-align:right;" />
</ul>
</div>
</div>
<div class="n_overlap"><img src="image/poweredy.jpg" width="148" height="44" /></div>
</div>
<input type="hidden" id="hidcompcode" runat="server" />
<input type="hidden" id="hidusername" runat="server" />
<input type="hidden" id="hiduserid" runat="server" />
<input type="hidden" id="hidauto" runat="server" />
<input type="hidden" id="hidautogenerated" runat="server" />
<script runat="server" language="C#">
public String Text = "";
</script>
<script language="javascript">
function opendiv(q)
{
document.getElementById(q).style.visibility = "visible"; 
document.getElementById('book').style.color = "red";
}

</script>

