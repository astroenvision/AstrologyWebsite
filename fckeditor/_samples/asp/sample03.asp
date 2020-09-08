<%@ CodePage=65001 Language="VBScript"%>
<% Option Explicit %>

<% ' You must set "Enable Parent Paths" on your web site in order this relative include to work. %>
<!-- #INCLUDE file="../../fckeditor.asp" -->
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<html>
	<head>
		<title>Sample</title>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
		<meta name="robots" content="noindex, nofollow">
		<link href="../sample.css" rel="stylesheet" type="text/css" />
		<script type="text/javascript">

function FCKeditor_OnComplete( editorInstance )
{
	var oCombo = document.getElementById( 'cmbToolbars' ) ;
	oCombo.value = editorInstance.ToolbarSet.Name ;
	oCombo.style.visibility = '' ;
}

function ChangeToolbar( toolbarName )
{
	window.location.href = window.location.pathname + "?Toolbar=" + toolbarName ;
}

		</script>
	</head>
	<body>
		<h1>SP - Sample 3</h1>
		This sample shows how to change the editor toolbar.
		<hr>
		<table cellpadding="0" cellspacing="0" border="0">
			<tr>
				<td>
					Select the toolbar to load:&nbsp;
				</td>
				<td>
					<select id="cmbToolbars" onchange="ChangeToolbar(this.value);" style="VISIBILITY: hidden">
						<option value="Default" selected>Default</option>
						<option value="Basic">Basic</option>
					</select>
				</td>
			</tr>
		</table>
		<br>
		<form action="sampleposteddata.asp" method="post" target="_blank">
<%
' Automatically calculates the editor base path based on the _samples directory.
' This is usefull only for these samples. A real application should use something like this:
' oFCKeditor.BasePath = '/fckeditor/' ;	// '/fckeditor/' is the default value.
Dim sBasePath
sBasePath = Request.ServerVariables("PATH_INFO")
sBasePath = Left( sBasePath, InStrRev( sBasePath, "/_samples" ) )

Dim oFCKeditor
Set oFCKeditor = New FCKeditor
oFCKeditor.BasePath = sBasePath

If Request.QueryString("Toolbar") <> "" Then
	oFCKeditor.ToolbarSet = Server.HTMLEncode( Request.QueryString("Toolbar") )
End If

oFCKeditor.Value = "<p>This is some <strong>sample text</strong>. You are using <a href=""http://www.fckeditor.net/"">FCKeditor</a>."
oFCKeditor.Create "FCKeditor1"
%>
			<br>
			<input type="submit" value="Submit">
		</form>
	</body>
</html>
