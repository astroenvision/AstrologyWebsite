<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="PaymentDetails.aspx.cs" Inherits="admin_PaymentDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        #loading {
            width: 100%;
            height: 100%;
            top: 0px;
            left: 0px;
            position: fixed;
            display: block;
            opacity: 0.7;
            background-color: #fff;
            z-index: 99;
            text-align: center;
        }

        .loading {
            width: 100%;
            height: 100%;
            top: 0px;
            left: 0px;
            position: fixed;
            display: block;
            opacity: 0.7;
            background-color: #fff;
            z-index: 99;
            text-align: center;
        }

        #loadingimg {
            width: 100%;
            height: 100%;
            top: 0px;
            left: 0px;
            position: fixed;
            display: block;
            opacity: 0.7;
            background-color: #fff;
            z-index: 99;
            text-align: center;
        }

        .txtdatecss {
            width: 120px;
            display: initial;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="right_col" role="main">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="page-title">
                    <div class="title_left">
                        <h3>Received Payment List<small></small></h3>
                    </div>
                </div>
                <div class="clearfix"></div>
                <div class="row" style="display: block;">
                    <div class="clearfix"></div>
                    <div class="col-md-12 col-sm-12">
                        <div class="x_panel">
                            <div class="x_title">
                                <div class="col-md-2" runat="server" id="Name">
                                    <asp:TextBox ID="txtUserName" runat="server" PlaceHolder="Enter Name" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="col-md-2">
                                    <asp:DropDownList ID="ddlSortColumn" runat="server" AutoPostBack="true" CssClass="form-control">
                                        <asp:ListItem Value="">Sort By</asp:ListItem>
                                        <asp:ListItem Value="Name">Name</asp:ListItem>
                                        <asp:ListItem Value="Date" Selected="True">Date</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-md-2">
                                    <asp:DropDownList ID="ddlSortBy" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="ASC">ASC</asp:ListItem>
                                        <asp:ListItem Value="DESC" Selected="True">DESC</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="clearfix"></div>
                            </div>
                            <div class="x_title">
                                <div class="col-sm-6">
                                    <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-primary" OnClick="btnSearch_Click" />
                                    <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="btn btn-secondary" OnClick="btnReset_Click" />
                                </div>
                                <div class="clearfix"></div>
                            </div>
                            <div class="x_content">
                                <div style="float: left; width: 100%; margin: 0% auto; padding: 0% 0% 0.5% 0%;">
                                    <span id="lbl_result" runat="server" style="color: black; font-weight: bold;"></span>
                                </div>
                                <div class="table-responsive">
                                    <asp:GridView ID="grdData" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdData_PageIndexChanging"
                                        CssClass="table table-striped jambo_table bulk_action" HeaderStyle-CssClass="headings" HeaderStyle-BackColor="#f25e0a" HeaderStyle-ForeColor="White" PageSize="30">
                                        <AlternatingRowStyle CssClass="even" />
                                        <Columns>
                                            <asp:TemplateField HeaderText="ID" Visible="false">
                                                <HeaderStyle HorizontalAlign="Left" Width="100px" CssClass="column-title"></HeaderStyle>
                                                <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblID" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "AUTOID").ToString()) %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="NAME" HeaderText="USER NAME" />
                                            <asp:BoundField DataField="EMAILID" HeaderText="USER MAIL" />
                                            <asp:BoundField DataField="CONTACT_NO" HeaderText="MOBILE NO" HeaderStyle-Width="100" />
                                            <asp:BoundField DataField="TOTAL_PRICE" HeaderText="TOTAL PAID AMOUNT" />
                                            <asp:BoundField DataField="PAYMENT_FOR" HeaderText="PAYMENT FOR" />
                                            <asp:BoundField DataField="PAIDDATE" HeaderText="PAYMENT DATE" />
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
                            </div>
                        </div>
                    </div>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnSearch" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
        <asp:UpdateProgress ID="UpdateProgress1" runat="server">
            <ProgressTemplate>
                <div class="loading">
                    <div class="loader-custom-inner">
                        <img src="<%=ResolveUrl("~/Image/loading_icon.gif") %>" alt="loader" title="loader" />
                    </div>
                </div>
            </ProgressTemplate>
        </asp:UpdateProgress>
    </div>
    <input type="hidden" runat="server" id="hiddendateformat" />
</asp:Content>

