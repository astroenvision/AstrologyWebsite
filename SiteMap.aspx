<%@ Page Title="Sitemap | Astro Envision" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="SiteMap.aspx.cs" Inherits="SiteMap" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
 <meta name="robots" content="index,follow" />
 <meta name="keywords" content="sitemap, navigation, user sitemap" />
 <meta name="description" content="Using our sitemap, you can easily find what you are looking for." />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
      <div class="container">
        <div class="container-sec">
            <div style="clear: both;"></div>
            <div class="content-center">
                <div class="form-background_article">
                    <div class="fullarticle">
                        <h1 class="fullarticle_catname" runat="server">Sitemap</h1>
                    </div>
                </div>
                <div style="clear: both;"></div>
                    <div>
                        <div class="row" style="padding: 0 0 1rem 0;border-bottom: 1px solid #f25e0a;margin: 0 0 1rem 0;">
                            <div runat="server" id="divCategoryID"></div>
                        </div>
                        <div class="row" style="padding: 0 0 1rem 0;border-bottom: 1px solid #f25e0a;margin: 0 0 1rem 0;">
                            <div runat="server" id="divFreeServices"></div>
                        </div>
                        <div class="row" style="padding: 0 0 1rem 0;border-bottom: 1px solid #f25e0a;margin: 0 0 1rem 0;">
                            <div runat="server" id="divOtherServices"></div>
                        </div>
                    </div>
            </div>
        </div>
    </div>
</asp:Content>

