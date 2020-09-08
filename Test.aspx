<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="Test" %>

<!DOCTYPE html>
<%@ Register Src="~/usercontrol/astroheader.ascx" TagName="astroheader" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/astrofooter.ascx" TagName="astrofooter" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Astro Envision</title>
    <meta name="robots" content="noindex,nofollow" />
    <meta content="width=device-width, initial-scale=1.0" name="viewport" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <link type="text/css" rel="stylesheet" href="CSS/report.css" />
    <link rel="Stylesheet" type="text/css" href="CSS/astrocss.css" />
    <link type="text/css" rel="stylesheet" href="CSS/thankyou.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <uc1:astroheader ID="astroheader1" runat="server" />
        <div class="container" id="dvHtml" runat="server">
            <asp:Panel ID="Panel1" runat="server">
                <section class="bannerarea">
                    <div class="container" style="background-color: white; border: 1px solid #d2c9c9; border-radius: 15px; padding: 10px 0 5px 0px;">
                        <div class="logo-section text-center" runat="server">
                            <a class="hme" href="<%=ResolveUrl("~/index.html") %>" title="Astro Envision">
                                <img class="lgo" src="<%=ResolveUrl("~/Image/large_logo.svg") %>" alt="Astro Envision" title="Astro Envision" /></a>
                        </div>

                        <div class="clearfix"></div>
                        <div class="row">
                            <div class="col-md-12 col-sm-12">
                                <div class="x_panel">
                                    <div class="x_title">
                                        <div class="col-md-3">
                                            <asp:Label runat="server" Font-Bold="true">Table</asp:Label>
                                            <asp:DropDownList ID="ddlvarga" runat="server" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="ddlvarga_SelectChange">
                                                <asp:ListItem Value="" Selected="True">Select Varga</asp:ListItem>
                                                <asp:ListItem Value="ShadVarga">ShadVarga</asp:ListItem>
                                                <asp:ListItem Value="SaptaVarga">SaptaVarga</asp:ListItem>
                                                <asp:ListItem Value="DashaVarga">DashaVarga</asp:ListItem>
                                                <asp:ListItem Value="ShodashVarga">ShodashVarga</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:Label runat="server" Font-Bold="true">KeyString:</asp:Label>
                                            <asp:DropDownList ID="ddlChart" runat="server" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="ddlChart_SelectChange">
                                            </asp:DropDownList>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="clearfix"></div>

                        <div class="table-responsive" id="divShowvargas" runat="server">
                            <asp:GridView ID="grdData" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdData_PageIndexChanging"
                                CssClass="table table-striped jambo_table bulk_action" HeaderStyle-CssClass="headings" HeaderStyle-BackColor="#f25e0a" HeaderStyle-ForeColor="White" PageSize="30">
                                <AlternatingRowStyle CssClass="even" />
                                <Columns>
                                    <asp:TemplateField HeaderText="CHART_NO" Visible="true">
                                        <HeaderStyle HorizontalAlign="Left" Width="50px" CssClass="column-title"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblCHART_NO" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "CHART_NO").ToString()) %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="PLANET">
                                        <HeaderStyle HorizontalAlign="Right" Width="100px"></HeaderStyle>
                                        <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblPLANET" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "PLANET").ToString()) %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="HOUSE">
                                        <HeaderStyle HorizontalAlign="Right" Width="100px"></HeaderStyle>
                                        <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblHOUSE" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "HOUSE").ToString()) %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="RASHI">
                                        <HeaderStyle HorizontalAlign="Right" Width="100px"></HeaderStyle>
                                        <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblRASHI" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "RASHI").ToString()) %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="DEGREE">
                                        <HeaderStyle HorizontalAlign="Right" Width="100px"></HeaderStyle>
                                        <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblDEGREE" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "DEGREE").ToString()) %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="RASHI_STATUS">
                                        <HeaderStyle HorizontalAlign="Right" Width="100px"></HeaderStyle>
                                        <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblRASHI_STATUS" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "RASHI_STATUS").ToString()) %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <EmptyDataTemplate>
                                    No record to display...
                                </EmptyDataTemplate>
                                <HeaderStyle HorizontalAlign="Left" />
                                <PagerStyle CssClass="PagerStyle" Wrap="True"
                                    HorizontalAlign="Center" />
                                <RowStyle CssClass="odd" />
                            </asp:GridView>
                        </div>
                        <div class="thankscss">
                            <img src="<%=ResolveUrl("~/Image/om_small.png") %>" alt="ads" style="border: 0px;" />
                            <h1>Thanks for using Astro Envision services</h1>
                            <h2>Provided By : Astro Envision</h2>
                            <h2>Contact : +91 9958883955</h2>
                            <h2>Email Id : support@astroenvision.com</h2>
                        </div>
                    </div>
                </section>
            </asp:Panel>
        </div>
        <uc2:astrofooter ID="astrofooter1" runat="server" />
    </form>
</body>
</html>
