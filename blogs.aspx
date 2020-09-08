<%@ Page Title="" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="blogs.aspx.cs" Inherits="blogs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="container-sec">
                    <div style="clear: both;"></div>
                    <div class="content-center">
                        <div class="form-background_article">
                            <div class="fullarticle" id="blogdivid" runat="server">
                            </div>
                        </div>
                    </div>
                    <div class="row justify-content-center">
                        <div class="col-sm-2">
                            <div class="mt-4 text-center">
                                <asp:Button ID="btnSubmit" runat="server" Text="Load More" CssClass="btn btn-primary btn-block btn-lg" ValidationGroup="save" OnClick="btnSubmit_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnSubmit" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
        <asp:UpdateProgress ID="UpdateProgress1" runat="server">
            <ProgressTemplate>
                <div class="loading">
                    <div class="loader-custom-inner">
                        <img src="<%=ResolveUrl("~/img/plane-loading.gif") %>" alt="Loader" title="Loader" />
                    </div>
                </div>
            </ProgressTemplate>
        </asp:UpdateProgress>
    </div>
    <asp:HiddenField ID="hdnCount" runat="server" />
</asp:Content>

