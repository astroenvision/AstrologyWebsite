<%@ Page Title="Consult An Astrologer | Astro Envision" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="ConsultAnAstrologer.aspx.cs" Inherits="ConsultAnAstrologer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="<%# ResolveUrl("lib/jquery/jquery.min.js") %>"></script>
    <script src="js/ConsultAnAstrologer.js"></script>
    <script>
        $(document).ready(function () {
            $("#txtQuestion_1").on("input", function () {
                var length = $("#txtQuestion_1").val().length;
                $("#lblMessage_1").text('');
                $("#lblMessage_1").text(length);
            });
        });

        $(document).ready(function () {
            $("#txtQuestion_2").on("input", function () {
                var length = $("#txtQuestion_2").val().length;
                $("#lblMessage_2").text('');
                $("#lblMessage_2").text(length);
            });
        });
        $(document).ready(function () {
            $("#txtQuestion_3").on("input", function () {
                var length = $("#txtQuestion_3").val().length;
                $("#lblMessage_3").text('');
                $("#lblMessage_3").text(length);
            });
        });
        $(document).ready(function () {
            $("#txtQuestion_4").on("input", function () {
                var length = $("#txtQuestion_4").val().length;
                $("#lblMessage_4").text('');
                $("#lblMessage_4").text(length);
            });
        });
        $(document).ready(function () {
            $("#txtQuestion_5").on("input", function () {
                var length = $("#txtQuestion_5").val().length;
                $("#lblMessage_5").text('');
                $("#lblMessage_5").text(length);
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Start Page Section -->
    <section class="srvc-sec">
        <div class="container">
            <div class="srvc-sec-innr">
                <header class="section-header wow fadeInUp" style="visibility: visible; animation-name: fadeInUp;">
                    <h1>Consult An Astrologer</h1>
                </header>
                <ul class="tttbli" runat="server" id="ulAstrologer">
                </ul>
            </div>
        </div>
    </section>
    <!-- End Page Section -->
    <asp:HiddenField ID="hdnQusID1" runat="server" />
    <asp:HiddenField ID="hdnQusID2" runat="server" />
    <asp:HiddenField ID="hdnQusID3" runat="server" />
    <asp:HiddenField ID="hdnQusID4" runat="server" />
    <asp:HiddenField ID="hdnQusID5" runat="server" />
</asp:Content>

