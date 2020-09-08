<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="NewsLetterSend.aspx.cs" Inherits="admin_NewsLetterSend" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
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
        <div class="page-title">
            <div class="title_left">
                <h3>News Letter Send</h3>
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
                        <div class="col-md-6 col-sm-6  form-group has-feedback">
                            <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Subject</label>
                            <asp:Label ID="lblID" runat="server" Visible="false"></asp:Label>
                            <asp:TextBox runat="server" ID="txtSubject" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqTitle" runat="server" ControlToValidate="txtSubject" CssClass="validator" Display="Dynamic"
                                ErrorMessage="Enter Subject" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                        </div>
                         <div class="col-md-6 col-sm-6  form-group has-feedback">
                            <label style="font-size: 14px; color: #555; font-weight: bold;">Upload Image</label>
                            <asp:UpdatePanel ID="upPhotograph" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:FileUpload ID="FileUserPhoto" Style="margin-top: 5px;" runat="server" AllowMultiple="true" />
                                </ContentTemplate>
                                <Triggers>
                                    <asp:PostBackTrigger ControlID="btnSubmit" />
                                </Triggers>
                            </asp:UpdatePanel>
                        </div>
                         <div class="col-md-12  form-group has-feedback">
                            <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Headline</label>
                            <FCKeditorV2:FCKeditor ID="fckHeadline" runat="server" BasePath="~/fckeditor/" Height="300"></FCKeditorV2:FCKeditor>
                        </div>
                         <div class="col-md-12  form-group has-feedback">
                            <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Description</label>
                            <FCKeditorV2:FCKeditor ID="fckDescription" runat="server" BasePath="~/fckeditor/" Height="300"></FCKeditorV2:FCKeditor>
                        </div>
                        <div class="clearfix"></div>
                        <div class="form-group row">
                            <div class="col-md-9 col-sm-9" style="margin-top: 31px;">
                                <asp:CheckBox runat="server" ID="chkStatus" Text="Active" Style="margin-left: 10px; font-size: 14px; color: #555; font-weight: bold;"></asp:CheckBox>
                            </div>
                            <div class="col-md-9 col-sm-9  offset-md-3">
                                <asp:LinkButton ID="btnSubmit" runat="server" Text="Send" CssClass="btn btn-success" ValidationGroup="save" OnClick="btnSubmit_Click" />
                                <asp:LinkButton ID="lnkbutton" runat="server" Text="Close" CssClass="btn btn-secondary" OnClientClick="javascript:window.close();" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <asp:HiddenField ID="hdnImage" runat="server" />
</asp:Content>

