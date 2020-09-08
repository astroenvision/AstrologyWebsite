<%@ Page Title="" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="CategoryDetails.aspx.cs" Inherits="section_CategoryDetails" ValidateRequest="false" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <%--<meta property="og:title" content="<%=CategoryName%>" />
    <meta property="og:description" content="<%=CategorySynopsis%>" />
    <meta property="og:image" content="<%=CategoryImagePath%>" />
    <meta property="og:url" content="<%=GetCategoryUrl%>" />
    <meta property="og:site_name" content="https://www.astroenvision.com" />
        
    <meta name="twitter:card" content="summary_large_image" />
    <meta name="twitter:site" content="@prabhatkhabar" />
    <meta name="twitter:domain" content="prabhatkhabar.com" />
    <meta name="twitter:title" content="<%=Getheadline %>" />
    <meta name="twitter:decription" content="<%=Getdescription%>" />
    <meta name="twitter:image" content="<%=GetimgPath %>" />--%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <div class="container-sec">
            <div style="clear: both;"></div>
            <div class="content-center">
                <div class="form-background_article">
                    <div class="fullarticle" id="divCategory" runat="server">
                    </div>
                </div>
                <div style="clear: both;"></div>
                <div class="tab-content">
                    <div id="natal" class="tab-pane active">
                        <div class="row service-cols" id="natalcategorydiv" runat="server">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <label id="hdnPreviousURL" runat="server" visible="false"></label>
</asp:Content>

