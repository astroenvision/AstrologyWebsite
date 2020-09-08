<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="ApproveArticle.aspx.cs" Inherits="admin_ApproveArticle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="<%=ResolveUrl("~/js/ApproveTestimonials.js") %>"></script>
    <script src="<%=ResolveUrl("~/admin/custom.css") %>"></script>
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
        <div class="">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div class="page-title">
                        <div class="title_left">
                            <h3>Manage Articles<small></small></h3>
                        </div>
                        <div class="title_right">
                            <div class="col-md-5 col-sm-5  form-group pull-right top_search">
                                <div class="input-group" style="display: block; text-align: right;">
                                    <asp:HyperLink ID="btnAddArticle" runat="server" Text="Add Article" CssClass="btn btn-success" NavigateUrl="~/admin/AddArticle.aspx" Target="_blank" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="clearfix"></div>
                    <div class="row" style="display: block;">
                        <div class="clearfix"></div>
                        <div class="col-md-12 col-sm-12  ">
                            <div class="x_panel">
                                <div class="x_title">
                                    <div class="col-md-2">
                                        <asp:DropDownList runat="server" CssClass="form-control" ID="ddlGroup" OnSelectedIndexChanged="ddlGroup_SelectedIndexChanged" AutoPostBack="true">
                                            <asp:ListItem Value="-1" Text="Select Group"></asp:ListItem>
                                            <asp:ListItem Value="NATAL" Text="NATAL"></asp:ListItem>
                                            <asp:ListItem Value="HORARY" Text="HORARY"></asp:ListItem>
                                            <asp:ListItem Value="BOTH" Text="BOTH"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-md-2">
                                        <asp:DropDownList runat="server" CssClass="form-control" ID="ddlCategory" AutoPostBack="true" OnSelectedIndexChanged="ddlCatName_OnChange">
                                            <asp:ListItem Value="-1" Text="Select Category"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-md-2">
                                        <asp:DropDownList runat="server" CssClass="form-control" ID="ddlSubCat">
                                            <asp:ListItem Value="-1" Text="Select Sub Category"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-md-2">
                                        <asp:DropDownList ID="ddlStatus" runat="server" CssClass="form-control">
                                            <asp:ListItem Selected="True" Value="-1"> Select Status</asp:ListItem>
                                            <asp:ListItem Value="A" Text="Approved"></asp:ListItem>
                                            <asp:ListItem Value="P" Text="Pending"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-md-2">
                                        <asp:TextBox runat="server" CssClass="form-control" ID="txtHeadline" placeholder="Headline">  </asp:TextBox>
                                    </div>
                                    <div class="col-sm-6" style="margin-top: 10px;">
                                        <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-primary" OnClick="btnSearch_Click" />
                                        <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="btn btn-secondary" OnClick="btnReset_Click" />
                                        <asp:Button ID="btnApprove" runat="server" Text="Approve" CssClass="btn btn-success" OnClick="btnApproved_Click" />
                                        <asp:Button ID="btnUnapproved" runat="server" Text="UnApprove" CssClass="btn btn-danger" OnClick="btnUnapproved_Click" />
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
                                                <asp:TemplateField>
                                                    <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Center" Width="25px" CssClass="column-title"></HeaderStyle>
                                                    <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="chkrow" runat="server" onclick="javascript: HighlightRow(this)" AutoPostBack="false" />
                                                    </ItemTemplate>
                                                    <HeaderTemplate>
                                                        <input type="checkbox" id="chkallrow" onclick="javascript: CheckAllRows(this)" />
                                                    </HeaderTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="ID" Visible="false">
                                                    <HeaderStyle HorizontalAlign="Left" Width="100px" CssClass="column-title"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblID" Visible="false" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "NEWS_ID").ToString()) %>'></asp:Label>
                                                        <asp:Label ID="lblStatus" Visible="false" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "STATUSVAL").ToString()) %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:BoundField DataField="AUTHOR" HeaderText="AUTHOR NAME" Visible="false" />
                                                <asp:BoundField DataField="HEADLINE" HeaderText="HEADLINE" />
                                                <asp:BoundField DataField="CAT_NAME" HeaderText="CAT NAME" />
                                                <asp:BoundField DataField="GROUP_ID" HeaderText="GROUP" />
                                                <asp:BoundField DataField="MOD_DATE" HeaderText="CREATED DATE" />
                                                <asp:BoundField DataField="PRIORITY" HeaderText="PRIORITY" />
                                                <asp:TemplateField HeaderText="STATUS">
                                                    <HeaderStyle HorizontalAlign="Left" Width="100px"></HeaderStyle>
                                                    <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblStatusVal" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "STATUSVAL").ToString()) %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="&nbsp; <span><i class='fa fa-cog' aria-hidden='true'></i></span>">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="15"></HeaderStyle>
                                                    <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                    <ItemTemplate>
                                                        <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%# "~/admin/AddArticle.aspx?q=" + Eval("NEWS_ID") %>'
                                                            title="Edit" Target="_blank" Font-Size="1.4em"><i  class="fa fa-pencil-square-o" aria-hidden="true"></i></asp:HyperLink>
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
                              <img src="<%=ResolveUrl("~/img/Loader.gif") %>" alt="Loader" title="Loader" />
                        </div>
                    </div>
                </ProgressTemplate>
            </asp:UpdateProgress>
        </div>
    </div>
</asp:Content>

