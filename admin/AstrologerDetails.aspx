<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="AstrologerDetails.aspx.cs" Inherits="admin_AstrologerDetails" %>

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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="right_col" role="main">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="page-title">
                    <div class="title_left">
                        <h3>Astrologer Details<small></small></h3>
                    </div>
                </div>
                <div class="clearfix"></div>
                <div class="row" style="display: block;">
                    <div class="clearfix"></div>
                    <div class="col-md-12 col-sm-12">
                        <div class="x_panel">

                            <div class="x_content">
                                <div class="table-responsive">
                                    <asp:GridView ID="gvDetails" runat="server" AllowPaging="True" AutoGenerateColumns="False" ShowFooter="true"
                                        CssClass="table table-striped jambo_table bulk_action" HeaderStyle-CssClass="headings" PageSize="50" HeaderStyle-BackColor="#f25e0a" ShowHeaderWhenEmpty="true" OnRowDeleting="gvDetails_RowDeleting">
                                        <AlternatingRowStyle CssClass="even" />
                                        <Columns>
                                            <asp:BoundField DataField="rowid" HeaderText="Row Id" ReadOnly="true" />
                                            <asp:TemplateField HeaderText="Name">
                                                <ItemTemplate>
                                                    <asp:TextBox ID="txtName" runat="server" />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Email Id">
                                                <ItemTemplate>
                                                    <asp:TextBox ID="txtemailid" runat="server" />
                                                </ItemTemplate>
                                                <FooterTemplate>
                                                    <asp:Button ID="btnAdd" runat="server" Text="Add Row" OnClick="btnAdd_Click" CssClass="btn btn-secondary" />
                                                </FooterTemplate>
                                            </asp:TemplateField>
                                            <asp:CommandField ShowDeleteButton="true" />
                                        </Columns>

                                        <EmptyDataTemplate>
                                            No record to display...
                                        </EmptyDataTemplate>
                                        <HeaderStyle HorizontalAlign="Left" />
                                        <PagerStyle CssClass="gridpager" />
                                        <RowStyle CssClass="odd" />
                                    </asp:GridView>
                                </div>

                                <div class="row" style="margin-left: 512px; margin-bottom: 5px;">
                                    <asp:Button ID="btnsendmail" runat="server" Text="Send Mail" CssClass="btn btn-success" OnClick="btnsendmail_Click" />
                                    <asp:Button ID="btnreset" runat="server" Text="Reset" CssClass="btn btn-secondary" OnClick="btnreset_Click" />
                                </div>
                                <div class="row">
                                    <div class="x_panel">
                                        <div class="x_title">
                                            <div class="col-md-2">
                                                <label style="font-size: 14px; color: #555; font-weight: bold;">Keyword:</label>
                                                <asp:TextBox ID="txtkeyword" runat="server" Text="" CssClass="form-control" PlaceHolder="Name or EmailID"></asp:TextBox>
                                            </div>
                                            <div class="col-sm-4" style="margin-top: 27px;">
                                                <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-primary" OnClick="btnsearch_Click" />
                                            </div>
                                            <div id="divTotalRcords" runat="server" class="nav navbar-right panel_toolbox"></div>
                                            <div class="clearfix"></div>
                                        </div>
                                        <div class="x_content">
                                            <div class="table-responsive">
                                                <asp:GridView ID="grdviews" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ID"
                                                    CssClass="table table-striped jambo_table bulk_action" HeaderStyle-CssClass="headings" PageSize="50" HeaderStyle-BackColor="#f25e0a" HeaderStyle-ForeColor="White"
                                                    OnPageIndexChanging="grdviews_PageIndexChanging" OnRowDataBound="grdviews_RowDataBound" OnRowCancelingEdit="grdviews_RowCancelingEdit" OnRowDeleting="grdviews_RowDeleting"
                                                    OnRowEditing="grdviews_RowEditing" OnRowUpdating="grdviews_RowUpdating" EmptyDataText="No records has been added.">
                                                    <AlternatingRowStyle CssClass="even" />
                                                    <Columns>
                                                        <asp:BoundField DataField="ID" HeaderText="Code" Visible="false" />
                                                        <asp:TemplateField HeaderText="Name">
                                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left" Wrap="true"></ItemStyle>
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblname" runat="server" Text='<%# Bind("NAME")%>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="EmailID" Visible="true">
                                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Left"></ItemStyle>
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblemailid" runat="server" Text='<%# Bind("MAINMAIL")%>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Subscription" Visible="true">
                                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblsubscription" runat="server" Text='<%# Bind("SUBSCRIPTION")%>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Gender" Visible="true">
                                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblgender" runat="server" Text='<%# Bind("GENDER")%>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Mobile" Visible="true">
                                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblmobile" runat="server" Text='<%# Bind("MOBILE_NO")%>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Password" Visible="true">
                                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblpwd" runat="server" Text='<%# Bind("PASSWORD")%>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Created Date" Visible="true">
                                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblcrtddate" runat="server" Text='<%# Bind("CRTDDATE")%>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Valid Form" Visible="false">
                                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblvalidfrom" runat="server" Text='<%# Bind("VALID_FROM")%>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Valid To" Visible="false">
                                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblvalidto" runat="server" Text='<%# Bind("VALID_TO")%>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Validity(In Days)" Visible="true">
                                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblvalidity" runat="server" Text='<%# Bind("DAYS")%>'></asp:Label>
                                                            </ItemTemplate>
                                                            <EditItemTemplate>
                                                                <asp:DropDownList ID="ddlvalidity" runat="server">
                                                                    <asp:ListItem Value="0">--Select Validity--</asp:ListItem>
                                                                    <asp:ListItem Value="15">15</asp:ListItem>
                                                                    <asp:ListItem Value="30">30</asp:ListItem>
                                                                    <asp:ListItem Value="45">45</asp:ListItem>
                                                                    <asp:ListItem Value="60">60</asp:ListItem>
                                                                    <asp:ListItem Value="75">75</asp:ListItem>
                                                                    <asp:ListItem Value="90">90</asp:ListItem>
                                                                    <asp:ListItem Value="180">180</asp:ListItem>
                                                                    <asp:ListItem Value="270">270</asp:ListItem>
                                                                    <asp:ListItem Value="365">365</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </EditItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Status" Visible="true">
                                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                            <EditItemTemplate>
                                                                <asp:DropDownList ID="ddlstatus" runat="server">
                                                                    <asp:ListItem Value="0">--Select Status--</asp:ListItem>
                                                                    <asp:ListItem Value="T">Active</asp:ListItem>
                                                                    <asp:ListItem Value="F">Inactive</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </EditItemTemplate>
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblstatus" runat="server" Text='<%# Bind("ACTIVE")%>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Mail Status" Visible="true">
                                                            <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                            <EditItemTemplate>
                                                                <asp:DropDownList ID="ddlmailstatus" runat="server">
                                                                    <asp:ListItem Value="0">--Select Status--</asp:ListItem>
                                                                    <asp:ListItem Value="T">Active</asp:ListItem>
                                                                    <asp:ListItem Value="F">Inactive</asp:ListItem>
                                                                </asp:DropDownList>
                                                            </EditItemTemplate>
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblmailstatus" runat="server" Text='<%# Bind("VERIFY_EMAILID")%>'></asp:Label>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true"
                                                            ItemStyle-Width="120" HeaderText="Action" />
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
                                </div>
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
                        <img src="/astrology/img/Loader.gif" alt="Astro" />
                    </div>
                </div>
            </ProgressTemplate>
        </asp:UpdateProgress>
    </div>
</asp:Content>





