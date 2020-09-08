<%@ Page Title="" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="TalkToAstrologers_old.aspx.cs" Inherits="TalkToAstrologers_old" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="js/TalkToAstrologers.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- Start Page Section -->	
<section class="srvc-sec">
	<div class="container">

			<div class="ttbastr">
				<header class="section-header wow fadeInUp" style="visibility: visible; animation-name: fadeInUp;">
			  <h3>Talk to the Best Astrologers</h3>
			  <p>Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper.</p>
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

