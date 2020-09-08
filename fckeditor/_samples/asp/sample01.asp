﻿<%@  codepage="65001" language="VBScript" %>
<% Option Explicit %>
<% ' You must set "Enable Parent Paths" on your web site in order this relative include to work. %>
<!-- #INCLUDE file="../../fckeditor.asp" -->
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<title>Sample</title>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<meta name="robots" content="noindex, nofollow" />
	<link href="../sample.css" rel="stylesheet" type="text/css" />
</head>
<body>
	<h1>
		ASP - Sample 1
	</h1>
	<div>
		This sample displays a normal HTML form with an FCKeditor with full features enabled.
	</div>
	<hr />
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
oFCKeditor.BasePath	= sBasePath
oFCKeditor.Value	= "<p>This is some <strong>sample text</strong>. You are using <a href=""http://www.fckeditor.net/"">FCKeditor</a>."
oFCKeditor.Create "FCKeditor1"
		%>
		<br />
		<input type="submit" value="Submit" />
	</form>
</body>
</html>
