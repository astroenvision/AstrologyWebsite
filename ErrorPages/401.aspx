<%@ Page Language="C#" AutoEventWireup="true" CodeFile="401.aspx.cs" Inherits="ErrorPages_401" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Online Astrology and Consultancy, Prashna(Horary) Astrology</title>
    <meta content="width=device-width, initial-scale=1.0" name="viewport" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <link href="<%=ResolveUrl("~/css/error-style.css") %>" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="mainerror">
            <div class="errorbox">
                <img class="erricn" src="../img/access-denied.svg" />
                <div class="errttl"><span>401</span>Oops! Page Not Found!</div>
                <div class="errsubhead">Oops!, Sorry we can't find that page</div>
                <div class="errdesc">Either something went wrong or the page doesn't exist anymore. <a class="bklnk" href="<%=ResolveUrl("~/index.html") %>">Go To Home</a></div>
            </div>
        </div>
    </form>
</body>
</html>
