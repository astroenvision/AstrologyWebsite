<%@ Page Title="Your Answer | Astro Envision" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="Free_Ask_Question_Ans.aspx.cs" Inherits="Free_Ask_Question_Ans" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="js/FreeAskQuestionAns.js"></script>
    <meta name="robots" content="noindex,nofollow" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="srvc-sec">
        <div class="container">
            <div class="srvc-sec-innr">
                <div class="ttbastr" style="border-bottom: none;">
                    <div class="row justify-content-center">
                        <div class="col-sm-12 form-group">
                            <div class="card">
                                <div class="card-body">
                                    <div class="rvwttl" style="text-align: center;">Your Answer</div>
                                    <ul class="astrvw" id="ulUserAns" runat="server">
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

