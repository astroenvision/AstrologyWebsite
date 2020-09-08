<%@ Page Title="" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="MyReports.aspx.cs" Inherits="MyReports" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="srvc-sec">
        <div class="container">
            <div class="fullarticle_catname">My Reports</div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <%--<div class="row">
                        <div class="col-sm-2">
                            <asp:DropDownList ID="ddlGroup" runat="server" CssClass="form-control form-control-lg-Srch" OnSelectedIndexChanged="ddlGroup_SelectedIndexChanged" AutoPostBack="true">
                                <asp:ListItem Value="-1" Text="Select Group"></asp:ListItem>
                                <asp:ListItem Value="NATAL" Text="NATAL"></asp:ListItem>
                                <asp:ListItem Value="HORARY" Text="HORARY"></asp:ListItem>
                                <asp:ListItem Value="BOTH" Text="BOTH"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-2">
                            <asp:DropDownList ID="ddlCategory" runat="server" CssClass="form-control form-control-lg-Srch">
                                <asp:ListItem Value="-1" Text="Select Category"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-2">
                            <asp:DropDownList ID="ddlStatus" runat="server" CssClass="form-control form-control-lg-Srch">
                                <asp:ListItem Selected="True" Value="-1"> Select Status</asp:ListItem>
                                <asp:ListItem Value="A" Text="Approved"></asp:ListItem>
                                <asp:ListItem Value="P" Text="Pending"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm-5">
                            <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="kwm-btn-lg-sch" OnClick="btnSearch_Click" />
                            <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="kwm-btn-lg-sch" OnClick="btnReset_Click" />
                            <asp:Button ID="btnApprove" runat="server" Text="Approved" CssClass="kwm-btn-lg-sch" OnClick="btnApproved_Click" />
                            <asp:Button ID="btnUnapproved" runat="server" Text="UnApproved" CssClass="kwm-btn-lg-sch" OnClick="btnUnapproved_Click" />
                        </div>
                    </div>
                    <br />--%>
                    <div class="row justify-content-center">
                        <div class="col-sm-12">
                            <div class="table-responsive">
                                <asp:GridView ID="grdData" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdData_PageIndexChanging"
                                    CssClass="table dataTable custom-table-bordered th-nowrap" OnRowDataBound="grdData_RowDataBound">
                                    <AlternatingRowStyle CssClass="even" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="ID" Visible="false">
                                            <HeaderStyle HorizontalAlign="Left" Width="100px"></HeaderStyle>
                                            <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:Label ID="lblPaymentFor" Visible="false" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "RAZORPAY_PAYMENT_FOR").ToString()) %>' ></asp:Label>
                                                <asp:Label ID="lblCartID" Visible="false" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "CARTID").ToString()) %>' ></asp:Label>
                                                 <asp:Label ID="lblCLientID" Visible="false" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "CLIENT_ID").ToString()) %>' ></asp:Label>
                                                 <asp:Label ID="lblUserMailID" Visible="false" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "REG_USER_EMAILID").ToString()) %>' ></asp:Label>
                                                <asp:Label ID="lblID" Visible="false" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "REG_USER_ID").ToString()) %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <%--<asp:BoundField DataField="AUTHOR" HeaderText="S.NO" />--%>
                                        <asp:BoundField DataField="ROW_NO" HeaderText="SNO." />
                                        <asp:BoundField DataField="REPORT_FOR" HeaderText="REPORT FOR" />
                                        <asp:BoundField DataField="CLIENT_NAME" HeaderText="NAME" />
                                        <asp:BoundField DataField="PAYMENT_DATE" HeaderText="REPORT DATE" />
                                        <asp:BoundField DataField="TOTAL_PRICE" HeaderText="PRICE" />
                                        <asp:TemplateField HeaderText="&nbsp; <span><i class='fa fa-eye' aria-hidden='true'></i></span>">
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="15"></HeaderStyle>
                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                            <ItemTemplate>
                                             <asp:HyperLink ID="lnkShowReport" runat="server"  title="Show Report" Target="_blank" Font-Size="1.4em"><i  class="fa fa-eye" aria-hidden="true"></i></asp:HyperLink>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <EmptyDataTemplate>
                                        No record to display...
                                    </EmptyDataTemplate>
                                    <HeaderStyle HorizontalAlign="Left" />
                                    <PagerStyle CssClass="gridpager" />
                                    <RowStyle CssClass="odd" />
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </ContentTemplate>
              
            </asp:UpdatePanel>
<%--            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <div class="loading">
                        <div class="loader-custom-inner">
                            <img src="/astrology/img/Loader.gif" alt="Astro" />
                        </div>
                    </div>
                </ProgressTemplate>
            </asp:UpdateProgress>--%>
        </div>
    </section>
</asp:Content>

