<%@ Page Title="" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="TestPDF.aspx.cs" Inherits="TestPDF" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="divshowreport" runat="server"></div>
    <asp:LinkButton ID="lnkGeneratePDF" runat="server" OnClick="btnGenertePDf_Click">generate pdf</asp:LinkButton>
</asp:Content>

