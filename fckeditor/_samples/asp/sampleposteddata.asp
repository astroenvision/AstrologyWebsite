<%@ CodePage=65001 Language="VBScript"%>
<% Option Explicit %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<html>
	<head>
		<title>Samples - Posted Data</title>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
		<meta name="robots" content="noindex, nofollow">
		<link href="../sample.css" rel="stylesheet" type="text/css" >
	</head>
	<body>
		<h1>Samples - Posted Data</h1>
		This page lists all data posted by the form.
		<hr>
		<table border="1" cellspacing="0" id="outputSample">
			<colgroup><col width="80"><col></colgroup>
			<thead>
				<tr>
					<th>Field Name</th>
					<th>Value</th>
				</tr>
			</thead>
			<%
			Dim sForm
			For Each sForm in Request.Form
			%>
			<tr>
				<th><%=sForm%></th>
				<td><pre><%=Server.HTMLEncode( Request.Form(sForm) )%></pre></td>
			</tr>
			<% Next %>
		</table>
	</body>
</html>
