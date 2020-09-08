<%@ Page Title="Talk To Astrologer | Astro Envision" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="TalkToAstrologers.aspx.cs" Inherits="TalkToAstrologers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <meta name="keywords" content="talk to astrologer, famous astrologer, talk to astro " />
    <meta name="description" content="Talk To Astrologer for horoscope predictions from the best astrologer online." />
    <script src="<%# ResolveUrl("lib/jquery/jquery.min.js") %>"></script>
    <script src="js/TalkToAstrologers.js"></script>
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
                    <h1>Talk To Astrologers</h1>
                    <%--<p>Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper.</p>--%>
                </header>
                <ul class="tttbli" runat="server" id="ulAstrologer">
                    <%--	<li class="d-flex">
						<div class="tpic">
							<img src="img/deepak.jpg" />
						</div>
						<div class="tdtl">
							<div class="tttle">Dr. Yashmine Danial</div>
							<div class="tttle-sb">Astologistic & Trama</div>
							<div class="ttbatag">
							<span class="spinle"><img class="strrtng" src="img/star.svg" /> 4.5 Rating</span>
							<span class="spinle">876 Comments</span>
							<span class="spinle">2345 Views</span>
							</div>
							<div class="tstdtl">Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper.</div>
							<div class="cfss d-flex">
								<div class="cfssblk d-flex">
									<input type="radio" class="rdoast" checked>
									<div><span>for 15 days : ₹ 349</span>
									tax included</div>
								</div>
								<div class="cfssblk d-flex">
									<input type="radio" class="rdoast">
									<div><span>for 15 days : ₹ 349</span>
									tax included</div>
								</div>
								<div class="cfssblk d-flex">
									<input type="radio" class="rdoast">
									<div><span>for 15 days : ₹ 349</span>
									tax included</div>
								</div>
							</div>
							<div class="btnsec">
								<a class="btn btn-info btn-sm" href="javascript:;">CALL NOW</a>
								<a class="btn btn-primary btn-sm" href="javascript:;">BOOK NOW</a>
							</div>
						</div>
					</li>
					
					<li class="d-flex">
						<div class="tpic">
							<img src="img/deepak.jpg" />
						</div>
						<div class="tdtl">
							<div class="tttle">Dr. Yashmine Danial</div>
							<div class="tttle-sb">Astologistic & Trama</div>
							<div class="ttbatag">
							<span class="spinle"><img class="strrtng" src="img/star.svg" /> 4.5 Rating</span>
							<span class="spinle">876 Comments</span>
							<span class="spinle">2345 Views</span>
							</div>
							<div class="tstdtl">Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper.</div>
							<div class="cfss d-flex">
								<div class="cfssblk d-flex">
									<input type="radio" class="rdoast" checked>
									<div><span>for 15 days : ₹ 349</span>
									tax included</div>
								</div>
								<div class="cfssblk d-flex">
									<input type="radio" class="rdoast">
									<div><span>for 15 days : ₹ 349</span>
									tax included</div>
								</div>
								<div class="cfssblk d-flex">
									<input type="radio" class="rdoast">
									<div><span>for 15 days : ₹ 349</span>
									tax included</div>
								</div>
							</div>
							<div class="btnsec">
								<a class="btn btn-info btn-sm" href="javascript:;">CALL NOW</a>
								<a class="btn btn-primary btn-sm" href="javascript:;">BOOK NOW</a>
							</div>
						</div>
					</li>
					
					<li class="d-flex">
						<div class="tpic">
							<img src="img/deepak.jpg" />
						</div>
						<div class="tdtl">
							<div class="tttle">Dr. Yashmine Danial</div>
							<div class="tttle-sb">Astologistic & Trama</div>
							<div class="ttbatag">
							<span class="spinle"><img class="strrtng" src="img/star.svg" /> 4.5 Rating</span>
							<span class="spinle">876 Comments</span>
							<span class="spinle">2345 Views</span>
							</div>
							<div class="tstdtl">Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper.</div>
							<div class="cfss d-flex">
								<div class="cfssblk d-flex">
									<input type="radio" class="rdoast" checked>
									<div><span>for 15 days : ₹ 349</span>
									tax included</div>
								</div>
								<div class="cfssblk d-flex">
									<input type="radio" class="rdoast">
									<div><span>for 15 days : ₹ 349</span>
									tax included</div>
								</div>
								<div class="cfssblk d-flex">
									<input type="radio" class="rdoast">
									<div><span>for 15 days : ₹ 349</span>
									tax included</div>
								</div>
							</div>
							<div class="btnsec">
								<a class="btn btn-info btn-sm" href="javascript:;">CALL NOW</a>
								<a class="btn btn-primary btn-sm" href="javascript:;">BOOK NOW</a>
							</div>
						</div>
					</li>
                    --%>
                </ul>


            </div>

        </div>
    </section>

    <!-- End Page Section -->
</asp:Content>

