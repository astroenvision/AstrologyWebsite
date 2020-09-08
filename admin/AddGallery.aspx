<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="AddGallery.aspx.cs" Inherits="admin_AddGallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
       .required {
            position: relative;
        }
       .required:after {
                position: absolute;
                content: '*';
                color: #ff0000;
                right: -10px;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="right_col" role="main">
        <div class="">
            <div class="page-title">
                <div class="title_left">
                    <h3 id="h3headertest" runat="server"></h3>
                </div>
                <div class="title_right" runat="server" visible="false">
                    <div class="col-md-5 col-sm-5  form-group pull-right top_search">
                        <div class="input-group">
                            <input type="text" class="form-control" placeholder="Search for...">
                            <span class="input-group-btn">
                                <button class="btn btn-default" type="button">Go!</button>
                            </span>
                        </div>
                    </div>
                </div>
            </div>
            <div class="clearfix"></div>
            <div class="row">
                <div class="col-md-12 ">
                    <div class="x_panel">
                        <div class="x_title">
                            <ul class="nav navbar-right panel_toolbox">
                                <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                                </li>
                                <li><a class="close-link"><i class="fa fa-close"></i></a>
                                </li>
                            </ul>
                            <div class="clearfix"></div>
                        </div>
                        <div class="x_content">
                            <div class="form-label-left input_mask">
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <asp:Label runat="server" ID="lblAlbumID" Visible="false"></asp:Label>
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Group Name</label>
                                    <asp:DropDownList runat="server" CssClass="form-control" ID="ddlGroup" AutoPostBack="true" OnSelectedIndexChanged="ddlGroup_SelectChange">
                                        <asp:ListItem Value="-1" Text="Select Group"></asp:ListItem>
                                        <asp:ListItem Value="NATAL" Text="NATAL"></asp:ListItem>
                                        <asp:ListItem Value="HORARY" Text="HORARY"></asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="reqGroupName" runat="server" ControlToValidate="ddlGroup" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Select Group Name" SetFocusOnError="True" InitialValue="-1" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Category Name</label>
                                    <asp:DropDownList runat="server" CssClass="form-control" ID="ddlCatName" AutoPostBack="true" OnSelectedIndexChanged="ddlCatName_SelectChange">
                                        <asp:ListItem Value="-1" Text="Select Category"></asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="reqCategory" runat="server" ControlToValidate="ddlCatName" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Select Category Name" SetFocusOnError="True" InitialValue="-1" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Album Name</label>
                                    <asp:DropDownList runat="server" CssClass="form-control" ID="ddlAlbum" AutoPostBack="true">
                                        <asp:ListItem Value="-1" Text="Select Album"></asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="reqAlbum" runat="server" ControlToValidate="ddlAlbum" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Select Album Name" SetFocusOnError="True" InitialValue="-1" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Upload Gallery Image</label>
                                    <asp:UpdatePanel ID="upPhotograph" runat="server" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <asp:FileUpload ID="FileUserPhoto" Style="margin-top: 5px;" runat="server" AllowMultiple="true" />
                                        </ContentTemplate>
                                        <Triggers>
                                            <asp:PostBackTrigger ControlID="btnSubmit" />
                                        </Triggers>
                                    </asp:UpdatePanel>
                                </div>
                                <div class="form-group row">
                                    <div class="col-md-9 col-sm-9" style="margin-top: 31px;">
                                    </div>
                                    <div class="col-md-9 col-sm-9  offset-md-3">
                                        <asp:LinkButton ID="btnSubmit" runat="server" Text="Update" CssClass="btn btn-success" ValidationGroup="save" OnClick="btnSubmit_Click" />
                                        <asp:LinkButton ID="lnkbutton" runat="server" Text="Close" CssClass="btn btn-secondary" OnClientClick="javascript:window.close();" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

