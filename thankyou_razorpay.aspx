<%@ Page Title="" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="thankyou_razorpay.aspx.cs" Inherits="thankyou_razorpay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
     <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="srvc-sec">
        <div class="container">
            <div id="divMessgae" runat="server" visible="false">Your Transation is Failed! Try again</div>
        </div>
    </section>
</asp:Content>

