<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ClientReport.aspx.cs" Inherits="ClientReport" %>

<!DOCTYPE html>
<%@ Register Src="~/usercontrol/astroheader.ascx" TagName="astroheader" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/astrofooter.ascx" TagName="astrofooter" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Astrology and Consultancy, Prashna Astrology</title>
    <meta name="robots" content="noindex,nofollow" />
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
       <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />

    <%--<link type="text/css" rel="stylesheet" href="CSS/main.css" />
    <link type="text/css" rel="stylesheet" href="CSS/tabletastrodtls.css" />
    <link rel="Stylesheet" type="text/css" href="CSS/mystyle.css" />--%>
    <link type="text/css" rel="stylesheet" href="CSS/report.css" />
    <link rel="Stylesheet" type="text/css" href="CSS/astrocss.css" />
    <link type="text/css" rel="stylesheet" href="CSS/thankyou.css" />
    <script type="text/javascript" src="javascript/thankyou.js"></script>
    <%-- <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js" type="text/javascript"></script>--%>
    <script type="text/javascript">
        function openInNewTab() {
            window.document.forms[0].target = '_blank';
            setTimeout(function () { window.document.forms[0].target = ''; }, 0);
        }
    </script>
</head>
<%--<body id="body1" onload="gridcall();">--%>
<body id="body1">
    <form id="form1" runat="server">
        <asp:ScriptManager runat="Server" ID="ScriptManager1" />
        <uc1:astroheader ID="astroheader1" runat="server" />
        <section class="bannerarea" runat="server">
            <div class="middlecontainer" id="Div1" runat="server">
                <div class="logo-section text-center">
                    <img class="lgo" src="<%=ResolveUrl("~/Image/large_logo.svg") %>" alt="Astro Envision" title="Astro Envision" />
                </div>

                <div class="container">
                    <div id="divShowChart" class="rptprsnl_details" runat="server"></div>
                </div>

                <div style="float: left; width: 100%; text-align: center; margin: 1em 0em 1em 0em;">
                    <asp:Button ID="Button1" class="nextbtncss" runat="server" Text="Save Your Output as PDF"
                        OnClick="btnExport_Click" Visible="false" />
                    &nbsp; &nbsp;
                <asp:Button ID="Button2" class="nextbtncss" OnClick="btnprint_Click" runat="server"
                    Text="Print" Visible="false" />
                    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-primary" OnClientClick="openInNewTab();" OnClick="lnkGeneratePDF_Click">Generate PDF</asp:LinkButton>
                     <asp:LinkButton ID="LinkButton2" runat="server" CssClass="btn btn-primary"  OnClick="lnkGenerateWordFile_Click">Word File</asp:LinkButton>
                    <div style="margin: 1em 0em 0.5em 0em;">
                        <a style="color: #f25e0a;border-bottom: 1px solid #f25e0a; font-weight:bold;font-size: 25px;" target="_blank" href="<%=ResolveUrl("~/feedback.html") %>">Click here for give your feedback about your report</a>
                    </div>
                </div>
            </div>
        </section>
        <section class="bannerarea" runat="server" visible="false">
            <div class="middlecontainer" id="dvHtml" runat="server">
                <div class="logo-section text-center">
                    <img class="lgo" src="<%=ResolveUrl("~/Image/large_logo.svg") %>" alt="Astro Envision" title="Astro Envision" />
                </div>
                <asp:Panel ID="Panel1" runat="server">


                    <div id="resultid" runat="server" visible="false" style="float: left; width: 84%; margin: 0% 8% 0% 8%;">
                        <%--<table class="questionsdiv_gv" cellspacing="0" border="0" style="width: 100%; border-collapse: collapse;"
                    runat="server">
                    <tr style="width: 96%;">
                        <th align="center" valign="middle" scope="col" style="width: 10%;">
                            Group
                        </th>
                        <th align="center" valign="middle" scope="col" style="width: 20%;">
                            Question
                        </th>
                        <th align="center" valign="middle" scope="col" style="width: 50%;">
                            Answer
                        </th>
                    </tr>
                    <tr>
                        <td align="center" valign="top" style="color: #5D5D5D; width: 10%;">
                            <span>NATAL</span>
                        </td>
                        <td align="center" valign="top" style="color: #5D5D5D; width: 20%;">
                            <span>Manglik Dosha</span>
                        </td>
                        <td align="center" valign="top" style="color: #5D5D5D; width: 50%;">
                            <span>Manglik dosha or Kuja Dosha is considered applicable
                                in ordinarily manner when in a Birth chart, Mars is posited in Lagna, or in 2nd
                                House or in 4th house, or in 7th House or in 8th House or in 12th House in Lagna
                                chart. This appears so simple to look into, however the malefic influcene of Mars
                                varies greatly with its placement in different house and differnt Rashi having different
                                impact on marital bliss and other consideation from Mars. To ensure the accurate
                                applicability, the weightage towards maleficence of Mars in Lagna, Moon and Venus
                                chart has been given using the proven anceint dictum. Further in the sequence the
                                cancellation & remedials has also been given for users consideration used by learned
                                Astrologers.</span>
                        </td>
                    </tr>
                </table>--%>
                    </div>
                    <div class="box" runat="server" visible="false">
                        <span class="rpthead">
                            <h1>Birth Chart</h1>
                        </span>
                        <div id="whitediv_1" class="div_curve_homenew">
                            <div id="Divgrid1_enduser" class="divg1homenewpage">
                                <table>
                                    <tr>
                                        <td runat="server" id="hdsviewgrid_enduser" align="left"></td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                        <div class="column1ho" id="rashiid_enduser" style="display: none; float: left;">
                            <div class="column-div1">
                                <span>
                                    <asp:Label ID="h1l1" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr1">
                                <span>
                                    <asp:Label ID="h1r" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div2">
                                <span>
                                    <asp:Label ID="h2l1" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr2">
                                <span>
                                    <asp:Label ID="h2r" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div3">
                                <span>
                                    <asp:Label ID="h3l1" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr3">
                                <span>
                                    <asp:Label ID="h3r" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label></span>
                            </div>
                            <div class="column-div4">
                                <span>
                                    <asp:Label ID="h4l1" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr4">
                                <span>
                                    <asp:Label ID="h4r" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div5">
                                <span>
                                    <asp:Label ID="h5l1" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr5">
                                <span>
                                    <asp:Label ID="h5r" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div6">
                                <span>
                                    <asp:Label ID="h6l1" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr6">
                                <span>
                                    <asp:Label ID="h6r" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div7">
                                <span>
                                    <asp:Label ID="h7l1" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr7">
                                <span>
                                    <asp:Label ID="h7r" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div8">
                                <span>
                                    <asp:Label ID="h8l1" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label></span>
                            </div>
                            <div class="column-divr8">
                                <span>
                                    <asp:Label ID="h8r" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div9">
                                <span>
                                    <asp:Label ID="h9l1" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr9">
                                <span>
                                    <asp:Label ID="h9r" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div10">
                                <span>
                                    <asp:Label ID="h10l1" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr10">
                                <span>
                                    <asp:Label ID="h10r" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div11">
                                <span>
                                    <asp:Label ID="h11l1" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr11">
                                <span>
                                    <asp:Label ID="h11r" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-div12">
                                <span>
                                    <asp:Label ID="h12l1" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <div class="column-divr12">
                                <span>
                                    <asp:Label ID="h12r" runat="server" Text="" CssClass="spanplanet">
                                    </asp:Label>
                                </span>
                            </div>
                            <figure class="fixedratio"></figure>
                        </div>
                    </div>

                    <div class="box" runat="server">
                        <span class="rpthead">
                            <h1>Other Charts</h1>
                        </span>
                        <div id="whitediv" class="div_curve_vargas">
                            <div id="Divgrid1" class="divg1homenewpage div-scroll_vargas">
                                <table>
                                    <tr>
                                        <td runat="server" id="hdsviewgrid" style="width: 550px;" align="left"></td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                        <div class="chartbox_left">
                            <div class="sec_varga">
                                <div>
                                    <asp:Label ID="fLabel1" runat="server" ForeColor="Black" CssClass="varga_lbl">
                                    </asp:Label>
                                </div>
                                <div class="column" id="frashiid">
                                    <div class="column-div1">
                                        <span>
                                            <asp:Label ID="fh1l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv1">
                                        <span>
                                            <asp:Label ID="fh1r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label></span>
                                    </div>
                                    <div class="column-div2">
                                        <span>
                                            <asp:Label ID="fh2l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv2">
                                        <span>
                                            <asp:Label ID="fh2r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div3">
                                        <span>
                                            <asp:Label ID="fh3l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv3">
                                        <span>
                                            <asp:Label ID="fh3r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label></span>
                                    </div>
                                    <div class="column-div4">
                                        <span>
                                            <asp:Label ID="fh4l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv4">
                                        <span>
                                            <asp:Label ID="fh4r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div5">
                                        <span>
                                            <asp:Label ID="fh5l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv5">
                                        <span>
                                            <asp:Label ID="fh5r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div6">
                                        <span>
                                            <asp:Label ID="fh6l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv6">
                                        <span>
                                            <asp:Label ID="fh6r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div7">
                                        <span>
                                            <asp:Label ID="fh7l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv7">
                                        <span>
                                            <asp:Label ID="fh7r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div8">
                                        <span>
                                            <asp:Label ID="fh8l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label></span>
                                    </div>
                                    <div class="column-divrv8">
                                        <span>
                                            <asp:Label ID="fh8r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div9">
                                        <span>
                                            <asp:Label ID="fh9l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv9">
                                        <span>
                                            <asp:Label ID="fh9r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div10">
                                        <span>
                                            <asp:Label ID="fh10l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv10">
                                        <span>
                                            <asp:Label ID="fh10r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div11">
                                        <span>
                                            <asp:Label ID="fh11l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv11">
                                        <span>
                                            <asp:Label ID="fh11r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div12">
                                        <span>
                                            <asp:Label ID="fh12l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv12">
                                        <span>
                                            <asp:Label ID="fh12r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <figure class="fixedratio"></figure>
                                </div>
                            </div>
                        </div>
                        <div class="chartbox_right">
                            <div class="sec_varga">
                                <div>
                                    <asp:Label ID="sLabel1" runat="server" ForeColor="Black" CssClass="varga_lbl">
                                    </asp:Label>
                                </div>
                                <div class="column" id="srashiid">
                                    <div class="column-div1">
                                        <span>
                                            <asp:Label ID="sh1l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv1">
                                        <span>
                                            <asp:Label ID="sh1r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label></span>
                                    </div>
                                    <div class="column-div2">
                                        <span>
                                            <asp:Label ID="sh2l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv2">
                                        <span>
                                            <asp:Label ID="sh2r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div3">
                                        <span>
                                            <asp:Label ID="sh3l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv3">
                                        <span>
                                            <asp:Label ID="sh3r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label></span>
                                    </div>
                                    <div class="column-div4">
                                        <span>
                                            <asp:Label ID="sh4l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv4">
                                        <span>
                                            <asp:Label ID="sh4r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div5">
                                        <span>
                                            <asp:Label ID="sh5l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv5">
                                        <span>
                                            <asp:Label ID="sh5r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div6">
                                        <span>
                                            <asp:Label ID="sh6l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv6">
                                        <span>
                                            <asp:Label ID="sh6r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div7">
                                        <span>
                                            <asp:Label ID="sh7l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv7">
                                        <span>
                                            <asp:Label ID="sh7r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div8">
                                        <span>
                                            <asp:Label ID="sh8l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label></span>
                                    </div>
                                    <div class="column-divrv8">
                                        <span>
                                            <asp:Label ID="sh8r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div9">
                                        <span>
                                            <asp:Label ID="sh9l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv9">
                                        <span>
                                            <asp:Label ID="sh9r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div10">
                                        <span>
                                            <asp:Label ID="sh10l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv10">
                                        <span>
                                            <asp:Label ID="sh10r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div11">
                                        <span>
                                            <asp:Label ID="sh11l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv11">
                                        <span>
                                            <asp:Label ID="sh11r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div12">
                                        <span>
                                            <asp:Label ID="sh12l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv12">
                                        <span>
                                            <asp:Label ID="sh12r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <figure class="fixedratio"></figure>
                                </div>
                            </div>
                        </div>
                        <div class="chartbox_left">
                            <div class="sec_varga">
                                <div>
                                    <asp:Label ID="tLabel1" runat="server" ForeColor="Black" CssClass="varga_lbl">
                                    </asp:Label>
                                </div>
                                <div class="column" id="trashiid">
                                    <div class="column-div1">
                                        <span>
                                            <asp:Label ID="th1l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv1">
                                        <span>
                                            <asp:Label ID="th1r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label></span>
                                    </div>
                                    <div class="column-div2">
                                        <span>
                                            <asp:Label ID="th2l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv2">
                                        <span>
                                            <asp:Label ID="th2r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div3">
                                        <span>
                                            <asp:Label ID="th3l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv3">
                                        <span>
                                            <asp:Label ID="th3r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label></span>
                                    </div>
                                    <div class="column-div4">
                                        <span>
                                            <asp:Label ID="th4l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv4">
                                        <span>
                                            <asp:Label ID="th4r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div5">
                                        <span>
                                            <asp:Label ID="th5l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv5">
                                        <span>
                                            <asp:Label ID="th5r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div6">
                                        <span>
                                            <asp:Label ID="th6l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv6">
                                        <span>
                                            <asp:Label ID="th6r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div7">
                                        <span>
                                            <asp:Label ID="th7l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv7">
                                        <span>
                                            <asp:Label ID="th7r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div8">
                                        <span>
                                            <asp:Label ID="th8l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label></span>
                                    </div>
                                    <div class="column-divrv8">
                                        <span>
                                            <asp:Label ID="th8r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div9">
                                        <span>
                                            <asp:Label ID="th9l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv9">
                                        <span>
                                            <asp:Label ID="th9r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div10">
                                        <span>
                                            <asp:Label ID="th10l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv10">
                                        <span>
                                            <asp:Label ID="th10r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div11">
                                        <span>
                                            <asp:Label ID="th11l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv11">
                                        <span>
                                            <asp:Label ID="th11r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div12">
                                        <span>
                                            <asp:Label ID="th12l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv12">
                                        <span>
                                            <asp:Label ID="th12r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <figure class="fixedratio"></figure>
                                </div>
                            </div>
                        </div>
                        <div class="chartbox_right">
                            <div class="sec_varga">
                                <div>
                                    <asp:Label ID="frLabel1" runat="server" ForeColor="Black" CssClass="varga_lbl">
                                    </asp:Label>
                                </div>
                                <div class="column" id="frrashiid">
                                    <div class="column-div1">
                                        <span>
                                            <asp:Label ID="frh1l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv1">
                                        <span>
                                            <asp:Label ID="frh1r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label></span>
                                    </div>
                                    <div class="column-div2">
                                        <span>
                                            <asp:Label ID="frh2l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv2">
                                        <span>
                                            <asp:Label ID="frh2r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div3">
                                        <span>
                                            <asp:Label ID="frh3l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv3">
                                        <span>
                                            <asp:Label ID="frh3r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label></span>
                                    </div>
                                    <div class="column-div4">
                                        <span>
                                            <asp:Label ID="frh4l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv4">
                                        <span>
                                            <asp:Label ID="frh4r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div5">
                                        <span>
                                            <asp:Label ID="frh5l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv5">
                                        <span>
                                            <asp:Label ID="frh5r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div6">
                                        <span>
                                            <asp:Label ID="frh6l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv6">
                                        <span>
                                            <asp:Label ID="frh6r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div7">
                                        <span>
                                            <asp:Label ID="frh7l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv7">
                                        <span>
                                            <asp:Label ID="frh7r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div8">
                                        <span>
                                            <asp:Label ID="frh8l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label></span>
                                    </div>
                                    <div class="column-divrv8">
                                        <span>
                                            <asp:Label ID="frh8r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div9">
                                        <span>
                                            <asp:Label ID="frh9l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv9">
                                        <span>
                                            <asp:Label ID="frh9r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div10">
                                        <span>
                                            <asp:Label ID="frh10l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv10">
                                        <span>
                                            <asp:Label ID="frh10r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div11">
                                        <span>
                                            <asp:Label ID="frh11l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv11">
                                        <span>
                                            <asp:Label ID="frh11r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-div12">
                                        <span>
                                            <asp:Label ID="frh12l1" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <div class="column-divrv12">
                                        <span>
                                            <asp:Label ID="frh12r" runat="server" Text="" CssClass="spanplanet">
                                            </asp:Label>
                                        </span>
                                    </div>
                                    <figure class="fixedratio"></figure>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="box">
                        <span class="rpthead">
                            <h1 id="balancedasha_id" runat="server"></h1>
                        </span>

                        <span class="rpthead">
                            <h2>Vimshottari Mahadasha
                            </h2>
                        </span>
                        <div class="tftable_div" id="mahadasha_id" runat="server">
                        </div>
                        <span class="rpthead">
                            <h2>Vimshottari Mahadasha and Antardashas
                            </h2>
                        </span>
                        <div class="tftable_div" id="antardasha_id" runat="server">
                        </div>
                        <%--  <div style="clear:both; float:left; width:100%;"></div>--%>
                        <span class="rpthead">
                            <h2>Vimshottari Antardasha and Pratyantardashas
                            </h2>
                        </span>
                        <div class="tftable_div" id="pratyantardasha_id" runat="server">
                        </div>
                        <%--<span class="rpthead">
                        <h1>
                            Sookshma Dasha
                        </h1>
                    </span>
                    <div class="tftable_div" id="sookshmadasha_id" runat="server">
                    </div>--%>
                    </div>

                    <div class="box" id="lagnadetailsid" runat="server">
                        <%--<span class="rpthead">
                        <h1>
                            Your Report On Lagna</h1>
                    </span>
                    <div class="lagnadetails" id="lagnadetailsid" runat="server">
                    </div>--%>
                    </div>

                    <div class="box">
                        <span class="rpthead">
                            <h1>Your Astro Reports</h1>
                        </span>
                        <div class="outputdetails" id="outputdetailsid" runat="server">
                        </div>
                        <div class="outputdetails" id="outputdetailsid_para" runat="server">
                        </div>
                        <div class="outputdetails_pointmain" id="outputdetailsid_point" runat="server">
                        </div>
                    </div>

                    <div class="box" id="remedialdetailsid" runat="server">
                        <%--<span class="rpthead">
                        <h1>
                            Remedial As Per Your Lagna</h1>
                    </span>
                    <div class="lagnadetails" id="remedialdetailsid" runat="server">
                    </div>--%>
                    </div>
                    <div class="thankscss">
                        <img src="<%=ResolveUrl("~/Image/om_small.png") %>" alt="ads" style="border: 0px;" />
                        <h1>Thanks for using our services.......</h1>
                        <h2>Provided By : Astro Envision</h2>
                        <h2>Contact : +91 9958883955</h2>
                        <h2>Email-Id : support@astroenvision.com</h2>
                    </div>
                </asp:Panel>
                <div style="float: left; width: 100%; text-align: center; margin: 1em 0em 1em 0em;">
                    <asp:Button ID="btnExport" class="nextbtncss" runat="server" Text="Save Your Output as PDF"
                        OnClick="btnExport_Click" Visible="false" />
                    &nbsp; &nbsp;
                   <asp:Button ID="btnprint" class="nextbtncss" OnClick="btnprint_Click" runat="server"
                       Text="Print" />
                    <asp:LinkButton ID="lnkGeneratePdf" runat="server" CssClass="btn btn-primary" OnClientClick="openInNewTab();" OnClick="lnkGeneratePDF_Click">Generate PDF</asp:LinkButton>
                    
                </div>
            </div>
        </section>
        <uc2:astrofooter ID="astrofooter1" runat="server" />
        <input type="hidden" runat="server" id="txtmail" />
        <input type="hidden" runat="server" id="Hastname" />
        <input type="hidden" runat="server" id="Hastmail" />
        <input type="hidden" runat="server" id="hdngroup" />
        <input type="hidden" runat="server" id="hdngroup_u" />
        <input type="hidden" runat="server" id="hdnmoc" />
        <input type="hidden" runat="server" id="hdndob" />
        <input type="hidden" runat="server" id="hdnidob" />
        <input type="hidden" runat="server" id="hdnimoob" />
        <input type="hidden" runat="server" id="hdniyob" />
        <input type="hidden" runat="server" id="hdntob" />
        <input type="hidden" runat="server" id="hdnihob" />
        <input type="hidden" runat="server" id="hdnimob" />
        <input type="hidden" runat="server" id="Hnewdiffm" />
        <input type="hidden" runat="server" id="Hnewdiffm1" />
        <input type="hidden" runat="server" id="Hnewdiffv" />
        <input type="hidden" runat="server" id="Hnewdiffv1" />
        <input type="hidden" runat="server" id="hdntzo" />
        <input type="hidden" runat="server" id="Hidden4" />
        <input type="hidden" runat="server" id="Hiddencons" />
        <%--<input type="hidden" runat="server" id="Hidden5" />--%>
        <input type="hidden" runat="server" id="chart" />
        <input type="hidden" runat="server" id="hdnuserid" />
        <input type="hidden" runat="server" id="hdnCartId" />
    </form>
</body>
</html>
