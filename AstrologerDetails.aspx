<%@ Page Title="Astrologer Hari Sharma | Astro Envision" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="AstrologerDetails.aspx.cs" Inherits="AstrologerDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script>
        function GetValue(Rating) {
            for (i = 1 ; i <= 5; i++) {
                $("#ctl00_ContentPlaceHolder1_rating_" + i).attr('checked', false);
            }

            for (i = 1 ; i <= Rating; i++) {
                $("#ctl00_ContentPlaceHolder1_rating_" + i).attr('checked', true);
            }
            $("#ctl00_ContentPlaceHolder1_hdnRating").val(Rating);
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
  <%--  <section class="srvc-sec">--%>
        <div class="container">
            <div class="container-sec">
                <div class="content-center">
                    <div class="ttbastr" style="border-bottom: none;">
                        <%--<header class="section-header wow fadeInUp mb-5 text-center" style="visibility: visible; animation-name: fadeInUp;">
                        <h3>Talk to an astrologer using 5 easy steps</h3>
                        <img class="tlkimg" src="img/talktoast.svg" />
                        </header>--%>
                        <h1 class="fullarticle_catname">About Astrologer Hari Sharma</h1>
                        <div class="row">
                            <div class="col-sm-4 text-center form-group">
                                <div class="card">
                                    <div class="card-body">
                                        <div class="prfpcx">
                                            <img runat="server" id="imgAstrologer" title="Astrologer Hari Sharma" alt="Astrologer Hari Sharma" src="img/PanditHariSharma.png" />
                                        </div>
                                        <div class="astnmez" runat="server" id="divName"></div>
                                        <div class="astdsgn" runat="server" id="divExpertIn">Vedic Astrology, Numerology</div>
                                        <div class="astexpr" runat="server" id="divExperience"></div>
                                        <div class="asttgz">
                                            <span class="astrtnx" id="spnTotalRating" runat="server"></span>
                                            <span class="astrtnx" style="display: none">2345<i class="fa fa-eye"></i></span>
                                            <span class="astrtnx" id="spnTotalComments" runat="server"><i class="fa fa-comment"></i></span>
                                        </div>
                                        <a class="kwm-btn-bg ntfyz" runat="server" visible="false" href="javascript:;"><i class="fa fa-bell"></i>Notify Me</a>
                                    </div>
                                </div>
                            </div>

                            <div class="col-sm-8 form-group">
                                <div class="card mb-3">
                                    <div class="card-body">
                                        <div class="astnmez">About Me</div>
                                        <div class="tstdtl" id="fullDesc" runat="server"></div>
                                        <div class="astnmez">Achievement</div>
                                        <div class="tstdtl" id="divAchievement" runat="server"></div>
                                    </div>
                                </div>

                                <div class="card mb-3">
                                    <div class="card-body">
                                        <div class="astnmez">Write Your Review</div>
                                        <div class="col-sm-12 form-group">
                                            <label style="margin-bottom: 0.0rem;">Rating</label>
                                            <span class="rating">
                                                <input type="radio" class="rating-input"
                                                    id="rating_5" runat="server" value="5" onclick="GetValue(5);" name="rating-input-5" />
                                                <label for="rating-input-1-5" class="rating-star" onclick="GetValue(5);"></label>
                                                <input type="radio" class="rating-input" onclick="GetValue(4);"
                                                    id="rating_4" runat="server" value="4" name="rating-input-4" />
                                                <label for="rating-input-1-4" class="rating-star" onclick="GetValue(4);"></label>
                                                <input type="radio" class="rating-input" onclick="GetValue(3);"
                                                    id="rating_3" runat="server" value="3" name="rating-input-3" />
                                                <label for="rating-input-1-3" class="rating-star" onclick="GetValue(3);"></label>
                                                <input type="radio" class="rating-input" onclick="GetValue(2);"
                                                    id="rating_2" runat="server" value="2" name="rating-input-2" />
                                                <label for="rating-input-1-2" class="rating-star" onclick="GetValue(2);"></label>
                                                <input type="radio" runat="server" class="rating-input" onclick="GetValue(1);"
                                                    id="rating_1" value="1" name="rating-input-1" />
                                                <label for="rating-input-1-1" class="rating-star" onclick="GetValue(1);"></label>
                                            </span>
                                        </div>
                                        <div class="col-sm-12 form-group">
                                            <asp:TextBox ID="txtComments" runat="server" class="form-control form-control-lg" TextMode="MultiLine" Rows="4" placeholder="Enter your Comment"></asp:TextBox>
                                        </div>
                                        <div class="mt-3 text-center">
                                            <asp:Button ID="btnsave" runat="server" OnClick="btnSubmit_Click" CssClass="kwm-btn-lg" Text="Submit" />
                                            <asp:Button ID="btnEdit" runat="server" Visible="false" OnClick="btnSubmit_Click" CssClass="kwm-btn-lg" Text="Edit your comment" />
                                        </div>
                                    </div>
                                </div>
                                <div class="card mb-3" runat="server" id="UserRating">
                                </div>
                                <div class="card">
                                    <div class="card-body">
                                        <div class="rvwttl">User Reviews</div>
                                        <ul class="astrvw" id="ulReviews" runat="server">
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
   <%-- </section>--%>
    <asp:HiddenField ID="hdnAstrologerID" runat="server" />
    <asp:HiddenField ID="hdnRating" runat="server" />
    <asp:HiddenField ID="hdnID" runat="server" />
</asp:Content>

