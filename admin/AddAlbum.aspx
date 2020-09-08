﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="AddAlbum.aspx.cs" Inherits="admin_AddAlbum" %>

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

        .prof-img-custom {
            position: relative;
        }

        .prof-img-inner-custom {
            width: 132px;
            height: 132px;
            position: relative;
            /*box-shadow: 0 0 2px #ddd;*/
            margin: auto;
        }

            .prof-img-inner-custom img {
                width: 132px;
                height: 132px;
            }

        .photoUpload-custom {
            overflow: hidden;
            padding: 3px 5px;
            cursor: pointer;
            position: absolute;
            width: 100%;
            bottom: 0;
            background: rgba(0, 0, 0, 0.5);
            text-align: center;
        }

            .photoUpload-custom span {
                color: #fff;
                position: relative;
                top: 2px;
            }

            .photoUpload-custom input.uploadpic {
                position: absolute;
                top: 0;
                right: 0;
                margin: 0;
                padding: 0;
                cursor: pointer;
                opacity: 0;
                width: 100%;
                filter: alpha(opacity=0);
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
                                <div class="col-md-6 col-sm-6  form-group has-feedback" id="divCoverImage" runat="server" visible="false">
                                    <div class="prof-img-custom">
                                        <div class="prof-img-inner-custom">
                                            <img id="imgpreview" runat="server" src="../../content/images/avatar.jpg" class="userPro" />
                                        </div>
                                    </div>
                                </div>
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
                                    <asp:DropDownList runat="server" CssClass="form-control" ID="ddlCatName" AutoPostBack="true">
                                        <asp:ListItem Value="-1" Text="Select Category"></asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="reqCategory" runat="server" ControlToValidate="ddlCatName" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Select Category Name" SetFocusOnError="True" InitialValue="-1" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Album Name</label>
                                    <asp:TextBox runat="server" ID="txtAlbumName" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqAlbumName" runat="server" ControlToValidate="txtAlbumName" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Album Name" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Album URL</label>
                                    <asp:TextBox runat="server" ID="txtAlbumURL" CssClass="form-control" OnTextChanged="txtAlbumURL_TextChanged" AutoPostBack="true">
                                    </asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqAlbumURL" runat="server" ControlToValidate="txtAlbumURL" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Title" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Title</label>
                                    <asp:TextBox runat="server" ID="txtTitle" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqTitle" runat="server" ControlToValidate="txtTitle" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Title" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Meta Keywords</label>
                                    <asp:TextBox runat="server" ID="txtMetaKeywords" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqMetaKeywords" runat="server" ControlToValidate="txtMetaKeywords" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Meta Keywords" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Meta Description</label>
                                    <asp:TextBox runat="server" ID="txtMetaDescription" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqMetaDescription" runat="server" ControlToValidate="txtMetaDescription" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Meta Description" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Priority</label>
                                    <asp:DropDownList runat="server" ID="ddlPriority" CssClass="form-control">
                                        <asp:ListItem Value="">Select Priority</asp:ListItem>
                                        <asp:ListItem Value="0">0</asp:ListItem>
                                        <asp:ListItem Value="1">1</asp:ListItem>
                                        <asp:ListItem Value="2">2</asp:ListItem>
                                        <asp:ListItem Value="3">3</asp:ListItem>
                                        <asp:ListItem Value="4">4</asp:ListItem>
                                        <asp:ListItem Value="5">5</asp:ListItem>
                                        <asp:ListItem Value="6">6</asp:ListItem>
                                        <asp:ListItem Value="7">7</asp:ListItem>
                                        <asp:ListItem Value="8">8</asp:ListItem>
                                        <asp:ListItem Value="9">9</asp:ListItem>
                                        <asp:ListItem Value="10">10</asp:ListItem>
                                        <asp:ListItem Value="11">11</asp:ListItem>
                                        <asp:ListItem Value="12">12</asp:ListItem>
                                        <asp:ListItem Value="13">13</asp:ListItem>
                                        <asp:ListItem Value="14">14</asp:ListItem>
                                        <asp:ListItem Value="15">15</asp:ListItem>
                                        <asp:ListItem Value="16">16</asp:ListItem>
                                        <asp:ListItem Value="17">17</asp:ListItem>
                                        <asp:ListItem Value="18">18</asp:ListItem>
                                        <asp:ListItem Value="19">19</asp:ListItem>
                                        <asp:ListItem Value="20">20</asp:ListItem>
                                        <asp:ListItem Value="21">21</asp:ListItem>
                                        <asp:ListItem Value="22">22</asp:ListItem>
                                        <asp:ListItem Value="23">23</asp:ListItem>
                                        <asp:ListItem Value="24">24</asp:ListItem>
                                        <asp:ListItem Value="25">25</asp:ListItem>
                                        <asp:ListItem Value="26">26</asp:ListItem>
                                        <asp:ListItem Value="27">27</asp:ListItem>
                                        <asp:ListItem Value="28">28</asp:ListItem>
                                        <asp:ListItem Value="29">29</asp:ListItem>
                                        <asp:ListItem Value="30">30</asp:ListItem>
                                        <asp:ListItem Value="31">31</asp:ListItem>
                                        <asp:ListItem Value="32">32</asp:ListItem>
                                        <asp:ListItem Value="33">33</asp:ListItem>
                                        <asp:ListItem Value="34">34</asp:ListItem>
                                        <asp:ListItem Value="35">35</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="reqPriority" runat="server" ControlToValidate="ddlPriority" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Select Priority" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback" runat="server" visible="false">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Upload Cover Image</label>
                                    <asp:UpdatePanel ID="upPhotograph" runat="server" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <asp:FileUpload ID="FileUserPhoto" Style="margin-top: 5px;" runat="server" />
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
    <asp:HiddenField ID="hdnCoverImage" runat="server" />
</asp:Content>

