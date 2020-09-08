<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Topbarnew_n.ascx.cs" Inherits="Topbarnew_n" %>

<script language="javascript" src="javascript/tree.js"></script>

<script language="javascript" src="javascript/TreeLibrary.js"></script>
<script language="javascript">

</script>
<div class="n_topbar">
	<%--<div  class="n_logo"><img id="imglogo" runat="server" src="images/udyavani-logo.jpg" width="206" height="68" /></div>--%>
	<div  class="n_logo"> <img src="Image/ast.jpeg" runat="server" height="68" /></div>
	<div class="n_top">
  	     
       <div class="clear"></div>
        <div class="n_t_inside2">
        	<ul>
        
        	<li><asp:Label ID="lblastrology" runat="server" CssClass="newDAMS" ForeColor="#5050A4" onclick="javascript:return openastro();"> Astrology |</asp:Label></li>
        	<li class="lougout " id="Formnamezz" onclick="javascript:return logoutpage();">Logout</li>
            	
            </ul>
        </div>
    </div>
    <div class="n_overlap"><img src="images/poweredy.jpg" width="148" height="44" /></div>
   
</div>

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