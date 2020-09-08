<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<html>
	<head>
		<title>Samples - Posted Data</title>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
		<meta name="robots" content="noindex, nofollow">
		<link href="../sample.css" rel="stylesheet" type="text/css" />
	</head>
	<body>
		<h1>Samples - Posted Data</h1>
		This page lists all data posted by the form.
		<hr>
<cfif listFirst( server.coldFusion.productVersion ) LT 6>
	<cfif isDefined( 'FORM.fieldnames' )>
		<cfoutput>
		<hr />
		<table border="1" cellspacing="0" id="outputSample">
			<colgroup><col width="80"><col></colgroup>
			<thead>
				<tr>
					<th>Field Name</th>
					<th>Value</th>
				</tr>
			</thead>
		<tr>
			<th>FieldNames</th>
			<td>#FORM.fieldNames#</td>
		</tr>
		<cfloop list="#FORM.fieldnames#" index="key">
		<tr>
			<th>#key#</th>
			<td><pre>#HTMLEditFormat( evaluate( "FORM.#key#" ) )#</pre></td>
		</tr>
		</cfloop>
		</table>
		</cfoutput>
	</cfif>
<cfelse>
	<cfdump var="#FORM#" label="Dump of FORM Variables">
</cfif>


	</body>
</html>
