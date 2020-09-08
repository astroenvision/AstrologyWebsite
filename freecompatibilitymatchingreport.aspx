<%@ Page Language="C#" AutoEventWireup="true" CodeFile="freecompatibilitymatchingreport.aspx.cs" Inherits="freecompatibilitymatchingreport" %>

<!DOCTYPE html>
<%@ Register Src="~/usercontrol/astroheader.ascx" TagName="astroheader" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/astrofooter.ascx" TagName="astrofooter" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Free Kundli Matching Report | Astro Envision</title>
    <meta name="robots" content="noindex,nofollow" />
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta content="width=device-width, initial-scale=1.0,user-scalable=no" name="viewport" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />

    <%-- <link type="text/css" rel="stylesheet" href="CSS/main.css" />--%>
    <%--<link type="text/css" rel="stylesheet" href="CSS/tabletastrodtls.css" />--%>
  <%--  <link rel="Stylesheet" type="text/css" href="css/mystyle.css" />--%>
    <link type="text/css" rel="stylesheet" href="CSS/report.css" />
    <link type="text/css" rel="Stylesheet" href="css/astrocss.css"  />
    <link type="text/css" rel="stylesheet" href="CSS/thankyou.css" />
    <script type="text/javascript">
        function openInNewTab() {
            window.document.forms[0].target = '_blank';
            setTimeout(function () { window.document.forms[0].target = ''; }, 0);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <uc1:astroheader ID="astroheader1" runat="server" />
        <section class="bannerarea">
            <div class="middlecontainer">
                <div class="logo-section text-center" runat="server" id="astrologo">
                    <%-- <img class="lgo" src="<%=ResolveUrl("~/Image/large_logo.svg") %>" alt="Astro Envision" title="Astro Envision" />--%>
                </div>
                <div class="container">
                    <div class="reportfirst" runat="server" id="astrofreereport">
                        <%-- <h2>Kundli Compatibility Matching Report</h2>--%>
                    </div>
                    <div class="rptprsnl_details" id="resultid" runat="server">
                        <div style="float: left; width: 100%;" id="bindDetails" runat="server"></div>
                        <div class="rpthead">
                            <h1>Birth Chart</h1>
                        </div>

                        <div style="float: left; width: 100%;">
                            <div runat="server" id="divBoysChart" style="float: left; width: 50%;"></div>
                            <div runat="server" id="divGirlsChart" style="float: left; width: 50%;"></div>
                        </div>

                        <div class="rpthead">
                            <h1>Ashtakoot Guna Matching Status</h1>
                        </div>
                        <div class="matchrptcss" runat="server" style="width: 96%;">
                            <asp:GridView ID="grdashakootmatching" runat="server" Width="100%" HeaderStyle-Width="96%" AutoGenerateColumns="False"
                                EmptyDataText="There are no data records to display."
                                OnRowDataBound="grdashakootmatching_RowDataBound" ShowFooter="true"
                                FooterStyle-HorizontalAlign="Center" FooterStyle-BackColor="#F4600A" FooterStyle-ForeColor="White" HeaderStyle-BackColor="#F4600A"
                                HeaderStyle-ForeColor="White" CssClass="grdcssstyle">
                                <Columns>
                                    <asp:TemplateField HeaderText="S.No" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblSNo" runat="server" Text='<%# Eval("SNo") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Koot Name" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblKootName" runat="server" Text='<%# Eval("KootName") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Girl Koot" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblGirlName" runat="server" Text='<%# Eval("GirlKootName") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Boy Koot" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblBoyName" runat="server" Text='<%# Eval("BoyKootName") %>'></asp:Label>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            <asp:Label ID="lblTotal" runat="server" Text='Total' Font-Bold="true"></asp:Label>
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Maximum Gunas" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="150px"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblMaximumGunas" runat="server" Text='<%# Eval("MaximumGunas") %>'></asp:Label>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            <asp:Label ID="lblTotalMaximumGunas" runat="server" Text='36' Font-Bold="true"></asp:Label>
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Matched Gunas" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="150px"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblMatchedGunas" runat="server" Text='<%# Eval("MatchedGunas") %>'></asp:Label>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            <asp:Label ID="lblTotalMatchedGunas" runat="server" Text='' Font-Bold="true"></asp:Label>
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Dosha Status" ItemStyle-ForeColor="#5D5D5D" Visible="false">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblDoshaStatus" runat="server" Text='<%# Eval("DoshaStatus") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Exception Match" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblExceptionMatch" runat="server" Text='<%# Eval("IsExceptionMatch") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                        <br />
                        <div class="rpthead">
                            <h1>Matching Results</h1>
                        </div>
                        <div id="finalreportid" class="matchrptcss" runat="server"></div>
                        <br />
                        <div class="rpthead">
                            <h1>Nadi Report</h1>
                        </div>
                        <div id="NadiReportDiv1" class="matchrptcss" runat="server"></div>
                        <br />
                        <div id="NadiReportDiv2" class="matchrptcss" runat="server"></div>
                        <div class="rpthead">
                            <h1>Bhakoot Report</h1>
                        </div>
                        <div id="BhakootReportdiv" class="matchrptcss" runat="server"></div>
                        <br />
                        <div class="rpthead">
                            <h1>Gana Report</h1>
                        </div>
                        <div id="GanaReportDiv" class="matchrptcss" runat="server"></div>
                        <br />
                        <div class="rpthead">
                            <h1>Grahamaitri Report</h1>
                        </div>
                        <div id="GrahamaitriReportDiv" class="matchrptcss" runat="server"></div>
                        <br />
                        <div class="rpthead">
                            <h1>Yoni Report</h1>
                        </div>
                        <div id="YoniReportDiv" class="matchrptcss" runat="server"></div>
                        <br />
                        <div class="rpthead">
                            <h1>Tara Report</h1>
                        </div>
                        <div id="TaraReportDiv" class="matchrptcss" runat="server"></div>
                        <br />
                        <div class="rpthead">
                            <h1>Vasya Report</h1>
                        </div>
                        <div id="VasyaReportDiv" class="matchrptcss" runat="server"></div>
                        <br />
                        <div class="rpthead">
                            <h1>Varna Report</h1>
                        </div>
                        <div id="VarnaReportDiv" class="matchrptcss" runat="server"></div>
                        <div style="clear:both;"></div>
                        <div>
                            <h1 style="color: #f25e0a; font-size: 1.3em; font-weight: 600;margin: 0 0 8px 0;"><i class="fa fa-angle-double-right" style="font-size:26px;color:#f25e0a;"></i>&nbsp;Important</h1>
                        </div>
                        <div class="matchrptcss" runat="server"><p>The following Kundali Matching – (Compatibility) reports are very crucial to consider before taking final decision to go ahead for marriage.</p></div>
                        <h5 style="line-height: 4px; font-size: 1em;">1. Manglik Dosha Report</h5>
                        <h5 style="line-height: 4px; font-size: 1em;">2. Dosha Samay Report </h5>
                        <div class="matchrptcss" runat="server"><p>Covers combined dosha arising from Mars, Saturn, Rahu and Sun – Very Important Consideration much beyond Manglik Dosha</p></div>
                        <div style="clear:both;"></div>
                        <h5 style="line-height: 4px; font-size: 1em;">3. Nakashtra Dosha Report </h5>
                        <h5 style="line-height: 4px; font-size: 1em;">4. Eka Nakashtra Dosha Report </h5>
                        <h5 style="line-height: 4px; font-size: 1em;">5. Vaadh Vainashik Dosha Report</h5>
                        <h5 style="line-height: 4px; font-size: 1em;">6. 27th Constellation Dosha Report </h5>
                        <h5 style="line-height: 4px; font-size: 1em;">7. Kaal- Sarpa Yoga</h5>
                        <div class="matchrptcss" runat="server"><p>Further, you may buy various Astro reports to know deep about the prospective alliance.</p></div>
                        <br />
                        <div><a style="font-weight: bold;" href="<%=ResolveUrl("~/natal-astrology/kundli-matching.html") %>" title="Buy Report" target="_blank">Click Here For Buy Report</a></div>
                         <div class="thankscss">
                            <img src="<%=ResolveUrl("~/Image/om_small.png") %>" alt="ads" style="border: 0px;" />
                            <h1>Thanks for using Astro Envision services</h1>
                            <h2>Provided By : Astro Envision</h2>
                            <h2>Contact : +91 9958883955, +91-9953248136</h2>
                            <h2>Email Id : support@astroenvision.com</h2>
                        </div>
                        <%--<br />
                        <div class="rpthead">
                            <h1>Nakashtra Dosha Report</h1>
                        </div>
                        <div id="NakashtraReportDiv" class="matchrptcss" runat="server"></div>
                        <br />
                        <div class="rpthead">
                            <h1>Eka Nakashtra Dosha Report</h1>
                        </div>
                        <div id="EkaNakashtraReportDiv" class="matchrptcss" runat="server"></div>
                        <br />
                        <div class="rpthead">
                            <h1>27th Nakashtra Dosha Report</h1>
                        </div>
                        <div id="Nakashtra27thReportDiv" class="matchrptcss" runat="server"></div>
                        <br />
                        <div class="rpthead">
                            <h1>Vadha Vainasika Dosha Report</h1>
                        </div>
                        <div id="VadhaVainasikaReportDiv" class="matchrptcss" runat="server"></div>
                        <br />
                        <div class="rpthead">
                            <h1>Manglik Dosha Report</h1>
                        </div>--%>
                        <%--<div id="ManglikDoshaDiv1" class="matchrptcss" runat="server"></div>
                        <div class="matchrptcss" runat="server" style="width: 96%;">
                            <asp:GridView ID="grdmanglikdosha" runat="server" Width="100%" HeaderStyle-Width="96%" AutoGenerateColumns="False"
                                EmptyDataText="There are no data records to display."
                                OnRowDataBound="grdmanglikdosha_RowDataBound" ShowFooter="true"
                                FooterStyle-HorizontalAlign="Center" FooterStyle-BackColor="#F4600A" FooterStyle-ForeColor="White" HeaderStyle-BackColor="#F4600A"
                                HeaderStyle-ForeColor="White" CssClass="grdcssstyle">
                                <Columns>
                                    <asp:TemplateField HeaderText="Manglik Dosha of Boy" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblManglikDoshaofBoy" runat="server" Text='<%# Eval("ManglikDoshaofBoy") %>'></asp:Label>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            <asp:Label ID="lblOverallBoyManglikDosha" runat="server" Text='Overall Manglik Dosha' Font-Bold="true"></asp:Label>
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="%" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblManglikPercentageForBoy" runat="server" Text='<%# Eval("ManglikPercentageForBoy") %>'></asp:Label>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            <asp:Label ID="lblBoyTotal" runat="server" Text='Total' Font-Bold="true"></asp:Label>
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Manglik Dosha of Girl" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblManglikDoshaofGirl" runat="server" Text='<%# Eval("ManglikDoshaofGirl") %>'></asp:Label>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            <asp:Label ID="lblOverallGirlManglikDosha" runat="server" Text='Overall Manglik Dosha' Font-Bold="true"></asp:Label>
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="%" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblManglikPercentageforGirl" runat="server" Text='<%# Eval("ManglikPercentageforGirl") %>'></asp:Label>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            <asp:Label ID="lblGirlTotal" runat="server" Text='Total' Font-Bold="true"></asp:Label>
                                        </FooterTemplate>
                                    </asp:TemplateField>

                                </Columns>
                            </asp:GridView>
                        </div>
                        <div id="ManglikDoshaDiv2" class="matchrptcss" runat="server"></div>
                        <div class="rpthead">
                            <h1>Dosha Samya Report</h1>
                        </div>
                        <div id="DoshaSamyaDiv1" class="matchrptcss" runat="server"></div>
                        <div class="matchrptcss" runat="server" style="width: 96%;">
                            <asp:GridView ID="grddoshasamya" runat="server" Width="100%" HeaderStyle-Width="96%" AutoGenerateColumns="False"
                                EmptyDataText="There are no data records to display."
                                OnRowDataBound="grddoshasamya_RowDataBound" ShowFooter="true"
                                FooterStyle-HorizontalAlign="Center" FooterStyle-BackColor="#F4600A" FooterStyle-ForeColor="White" HeaderStyle-BackColor="#F4600A"
                                HeaderStyle-ForeColor="White" CssClass="grdcssstyle">
                                <Columns>
                                    <asp:TemplateField HeaderText="Dosha Samya of Boy" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblDoshaSamyaofBoy" runat="server" Text='<%# Eval("DoshaSamyaofBoy") %>'></asp:Label>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            <asp:Label ID="lblOverallBoyDoshaSamya" runat="server" Text='Overall combined Dosha Samya %' Font-Bold="true"></asp:Label>
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="%" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblDoshaPercentageForBoy" runat="server" Text='<%# Eval("DoshaPercentageForBoy") %>'></asp:Label>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            <asp:Label ID="lblBoyTotal" runat="server" Text='Total' Font-Bold="true"></asp:Label>
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Dosha Samya of Girl" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblDoshaSamyaofGirl" runat="server" Text='<%# Eval("DoshaSamyaofGirl") %>'></asp:Label>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            <asp:Label ID="lblOverallGirlDoshaSamya" runat="server" Text='Overall combined Dosha Samya %' Font-Bold="true"></asp:Label>
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="%" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblDoshaPercentageforGirl" runat="server" Text='<%# Eval("DoshaPercentageforGirl") %>'></asp:Label>
                                        </ItemTemplate>
                                        <FooterTemplate>
                                            <asp:Label ID="lblGirlTotal" runat="server" Text='Total' Font-Bold="true"></asp:Label>
                                        </FooterTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                        <div id="DoshaSamyaDiv2" class="matchrptcss" runat="server"></div>
                        <br />
                        <div class="rpthead">
                            <h1>Kaal Sarpa Yoga Report</h1>
                        </div>
                        <div id="KaalSarpaYogaDiv" class="matchrptcss" runat="server"></div>--%>
                        <div id="divShowData" runat="server"></div>
                        <div style="width: 100%; text-align: center; margin-bottom: 10px; display:none;">
                            <asp:LinkButton ID="lnkGeneratePDF" runat="server" OnClientClick="openInNewTab();" CssClass="btn btn-primary" OnClick="lnkGeneratePDF_Click"><i class="fa fa-file-pdf-o" aria-hidden="true"></i> Generate Pdf</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <uc2:astrofooter ID="astrofooter1" runat="server" />
    </form>
</body>
</html>
