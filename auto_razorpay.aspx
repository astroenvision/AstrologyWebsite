<%@ Page Title="" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="auto_razorpay.aspx.cs" Inherits="auto_razorpay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="https://checkout.razorpay.com/v1/checkout.js"></script>
    <script>
        function Payment() {
            try {
                var pageUrl = document.location.origin;
                if (pageUrl.indexOf('localhost') > -1) {
                    pageUrl = pageUrl + '/astrology'
                }
                else {
                    pageUrl = "https://www.astroenvision.com";
                }
                var Name = $("#ctl00_ContentPlaceHolder1_hdnName").val();
                var EmailID = $("#ctl00_ContentPlaceHolder1_hdnEmail").val();
                var PhoneNo = $("#ctl00_ContentPlaceHolder1_hdnPhone").val();
                var Address = $("#ctl00_ContentPlaceHolder1_hdnAddress").val();
                var CartID = $("#ctl00_ContentPlaceHolder1_hdnCartId").val();
                var Key = $("#ctl00_ContentPlaceHolder1_hdnKey").val();
                var PaymentForVal = $("#ctl00_ContentPlaceHolder1_hdnPaymentFor").val();
                var options = {
                    "key": Key,
                    //"amount": Amount, // Example: 2000 paise = INR 20
                    "name": "Astro Envision",
                    "callback_url": pageUrl + "/thankyou_razorpay.aspx?q=" + CartID + "&PaymentFor=" + PaymentForVal,
                    "redirect": true,
                    "base_amount": 7129,
                    "base_currency": "INR",
                    "image": "img/logo.png",// COMPANY LOGO
                    "order_id": "<%=orderId%>",
                    "handler": function (response) {
                        console.log(response);
                        alert(response.razorpay_order_id);
                        alert(response.razorpay_payment_id);
                        alert(response.razorpay_signature);
                        // AFTER TRANSACTION IS COMPLETE YOU WILL GET THE RESPONSE HERE.
                    },
                    "prefill": {
                        "name": Name, // pass customer name
                        "email": EmailID,// customer email
                        "contact": PhoneNo//customer phone no.
                    },
                    "notes": {
                        "address": Address //customer address 
                    },
                    "theme": {
                        "color": "#f25e0a" // screen color
                    }
                };
                console.log(options);
                var propay = new Razorpay(options);
                propay.open();
            }
            catch (ex) {
                alert(ex);
                return false;
            }
        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="height:400px">
        <asp:HiddenField ID="hdnName" runat="server" />
        <asp:HiddenField ID="hdnEmail" runat="server" />
        <asp:HiddenField ID="hdnPhone" runat="server" />
        <asp:HiddenField ID="hdnAddress" runat="server" />
        <asp:HiddenField ID="hdnCartId" runat="server" />
        <asp:HiddenField ID="hdnKey" runat="server" />
        <asp:HiddenField ID="hdnPaymentFor" runat="server" />
    </div>
</asp:Content>

