<%@ Page Title="Personal Meeting | Astro Envision" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="PersonalMeeting.aspx.cs" Inherits="PersonalMeeting" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <%--<meta name="description" content="Personal Meeting With Astrologer" />
    <meta name="keywords" content="Online Astrology Services, Astrology Portal, Astrology Website, Indian Astrologer, Indian Vedic Astrology,  Indian Astrology, Natal Astrology, Prashna Astrology, Horary Astrology, Tajik Astrology,  Personal Consultancy, Birth chart Astrology, Telephonic Astrology Consultancy, Skype Astrology Consultancy, Online Astrology Reports for Money,  Online Astrology Reports for Wealth, Online Astrology Reports for Career, Online Astrology Reports for Finance, Online Astrology Reports for Cash, Online Astrology Report for Riches, Online Astrology Reports for Property, Online Astrology Reports for Prosperity, Online Astrology Reports for Profession, Online Astrology Reports for Fame, Online Reports for Fortune, Online Astrology Reports for Love, Online Astrology Reports for Sex life, Online  Astrology Repots for Marriage Prospects, Online Astrology Reports for Manglik Dosha, Astrologer in Delhi, Astrologer in Delhi NCR, Astrologer in India, Top Astrologer, Unique Astrologer,  Old Astrologer, Mantra Astrologer, Tantra Astrologer, Yantra,  Female Astrology, Online Female Astrology, Famous Astrologer, Celebrity Astrologer, Future Astrology, Future Astrologer, Master Astrologer, Horary Astrologer, Prashna Astrologer, Tajik Astrologer Eminent Astrologer, Well known Astrologer, Prestigious Astrologer, Notable Astrologer, Outstanding Astrologer, Foremost Astrologer." />--%>
    <script src="<%# ResolveUrl("lib/jquery/jquery.min.js") %>"></script>
    <script src="js/PersonalMeeting.js"></script>
    <script>
        $(document).ready(function () {
            $("#txtQuestion2").on("input", function () {
                var length = $('#txtQuestion2').val().length;
                $("#lblMessage1").text('');
                $("#lblMessage1").text(length);
                Question2 = $('#txtQuestion2').val();
            });
        });

        $(document).ready(function () {
            $("#txtQuestion1").on("input", function () {
                var length = $('#txtQuestion1').val().length;
                $("#lblMessage").text('');
                $("#lblMessage").text(length);
                Question1 = $('#txtQuestion1').val();
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
                    <h1>Personal Meeting With Astrologer</h1>
                </header>
                <ul class="tttbli" runat="server" id="ulAstrologer">
                </ul>
            </div>
        </div>
    </section>
</asp:Content>

