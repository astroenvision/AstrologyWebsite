<%@ Page Title="" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="article.aspx.cs" Inherits="article_article" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="container">
        <div class="container-sec">
            <div class="content-center">
                <div class="col-sm-12">
                    <div class="fullarticle" id="fullarticle_id" runat="server">
                    </div>
                     <div class="text-sm-right">
                        <asp:LinkButton ID="lnkPreviousPage" runat="server" CssClass="vwall-btn" OnClick="lnkPreviousPage_Click">Back</asp:LinkButton>
                     </div>
                </div>
            </div>
        </div>
    </div>
    <asp:HiddenField id="hdnPriviousURl" runat="server"/>
</asp:Content>

