<%@ Page Language="C#" AutoEventWireup="true" CodeFile="deepak.aspx.cs" Inherits="deepak" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Astro Envision</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 0 auto; width: 100%; max-width: 1000px; height: 842px; padding-top: 70px;">
            <div style="text-align: center;">
                <img src="<%=ResolveUrl("~/IMAGES/om.jpg") %>" />
                <br />
                <h1 style="font-size: 2rem; font-family: sans-serif; color: #f25e0a; padding: 0px; margin: 0px;">Astro Envision</h1>
                <h1 style="font-size: 2rem; font-family: sans-serif; color: #f25e0a; padding: 0px; margin: 0px;">Astrology Report</h1>
                <img src="<%=ResolveUrl("~/IMAGES/ganesha.jpg") %>" />
                <br />
                <img src="<%=ResolveUrl("~/Image/large_logo.svg") %>" alt="Astro Envision" title="Astro Envision" />
                <br />
                <br />
                <img src="<%=ResolveUrl("~/IMAGES/om.jpg") %>" />
            </div>
        </div>
        <%-- <div>
            <h1 id="H0" runat="server"></h1>
            <br />
            <h1 id="H1" runat="server"></h1>
            <br />
            <h1 id="H2" runat="server"></h1>
            <br />
            <h1 id="H3" runat="server"></h1>
            <br />
            <h1 id="H4" runat="server"></h1>
            <br />
            <h1 id="H5" runat="server"></h1>
            <br />
            <h1 id="H6" runat="server"></h1>
            <br />
        </div>--%>
    </form>
</body>
</html>
