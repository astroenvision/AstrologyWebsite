<%@ Page Title="Online Astrology Reports, Consultancy, Prashna (Horary) Astrology" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="indexpage.aspx.cs" Inherits="indexpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <meta name="description" content="Online Vedic Astrology Software generates multiple reports backed by Hundreds of Thousands of planetary combinations present in your birth Chart." />
    <meta name="keywords" content="Online Astrology Services, Astrology Portal, Astrology Website, Indian Astrologer, Indian Vedic Astrology,  Indian Astrology, Natal Astrology, Prashna Astrology, Horary Astrology, Tajik Astrology,  Personal Consultancy, Birth chart Astrology, Telephonic Astrology Consultancy, Skype Astrology Consultancy, Online Astrology Reports for Money,  Online Astrology Reports for Wealth, Online Astrology Reports for Career, Online Astrology Reports for Finance, Online Astrology Reports for Cash, Online Astrology Report for Riches, Online Astrology Reports for Property, Online Astrology Reports for Prosperity, Online Astrology Reports for Profession, Online Astrology Reports for Fame, Online Reports for Fortune, Online Astrology Reports for Love, Online Astrology Reports for Sex life, Online  Astrology Repots for Marriage Prospects, Online Astrology Reports for Manglik Dosha, Astrologer in Delhi, Astrologer in Delhi NCR, Astrologer in India, Top Astrologer, Unique Astrologer,  Old Astrologer, Mantra Astrologer, Tantra Astrologer, Yantra,  Female Astrology, Online Female Astrology, Famous Astrologer, Celebrity Astrologer, Future Astrology, Future Astrologer, Master Astrologer, Horary Astrologer, Prashna Astrologer, Tajik Astrologer Eminent Astrologer, Well known Astrologer, Prestigious Astrologer, Notable Astrologer, Outstanding Astrologer, Foremost Astrologer." />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <main id="main">
        <!--========================== Portfolio Sectionmm============================-->
        <section class="srvc-sec">
            <div class="container">
                <div class="srvc-sec-innr">

                    <div class="bnrsec" style="display:none;">
                        <div class="row">
                            <div class="col-sm-2"></div>
                            <div class="col-sm-7 form-group">
                                <div class="bnr-sb-title">Astrologer Hari Sharma</div>
                                <div class="bnrp-title">
                                    Online Free Astro Consultancy<br />
                                    <%--Ask One <span> & </span>Expertise--%>
                                    <span style="color: blue">Ask One Question <i class="fa fa-question" aria-hidden="true"></i> </span>
                                    <ul>
                                        <li>Career & Profession</li>
                                        <li>Money, Wealth & Luxuries</li>
                                        <li>Fortune and Wisdom</li>
                                        <li>Relationship</li>
                                    </ul>
                                </div>
                                <a href="<%=ResolveUrl("~/ask-one-question-free.html") %>" title="Ask One Question" class="kwm-btn"><i class="fa fa-arrow-circle-right" aria-hidden="true"></i> Click Here</a>
                            </div>

                            <div class="col-sm-3 form-group">
                                <img src="<%=ResolveUrl("~/img/bnr-icon.jpg") %>" alt="Astrology Chart" title="Astrology Chart" />
                            </div>
                        </div>
                    </div>

                    <header class="section-header wow fadeInUp" style="visibility: visible; animation-name: fadeInUp;">
                        <h3>Astro Reports on Birth Chart Promise ?</h3>
                    </header>
                    <ul class="nav nav-pills justify-content-center" role="tablist" style="display: none;">
                        <li class="nav-item">
                            <a class="nav-link active" data-toggle="pill" href="#natal">Natal</a>
                        </li>
                        <li class="nav-item" style="display: none">
                            <a class="nav-link" data-toggle="pill" href="#prashna">Prashna (Horary)</a>
                        </li>
                    </ul>
                    <!-- Tab panes -->
                    <div class="tab-content">
                        <div id="natal" class="tab-pane active">
                            <div class="row service-cols" id="natalcategorydiv" runat="server">
                                <%-- <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s1.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Personality Traits</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="javascript:;" class="kwm-btn" data-toggle="modal" data-target="#readMore1">Know More</a>
                                                <a href="javascript:;" class="kwm-btn"><i class="fa fa-shopping-cart mr-1"></i>Add to Cart</a>
                                            </div>
                                        </div>
                                        <div class="modal fade" id="readMore1">
                                        <div class="modal-dialog modal-lg modal-dialog-centered">
                                            <div class="modal-content">
                                                <!-- Modal Header -->
                                                <div class="modal-header">
                                                    <h4 class="modal-title">Personality Traits</h4>
                                                    <button type="button" class="close" data-dismiss="modal"><i class="ion-ios-close-outline text-bold"></i></button>
                                                </div>
                                                <!-- Modal body -->
                                                <div class="modal-body">
                                                    <p>Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.</p>
                                                    <p>Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.</p>
                                                    <p>Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.</p>
                                                </div>
                                            </div>
                                        </div>
                                        </div>
                                    </div>
                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s2.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Political career</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn" data-toggle="modal" data-target="#readMore2">Know More</a>
                                            </div>
                                        </div>
                                         <div class="modal fade" id="readMore2">
                                        <div class="modal-dialog modal-lg modal-dialog-centered">
                                            <div class="modal-content">
                                                <!-- Modal Header -->
                                                <div class="modal-header">
                                                    <h4 class="modal-title">Political career</h4>
                                                    <button type="button" class="close" data-dismiss="modal"><i class="ion-ios-close-outline text-bold"></i></button>
                                                </div>
                                                <!-- Modal body -->
                                                <div class="modal-body">
                                                    <p>Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.</p>
                                                    <p>Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco. Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.</p>
                                                    <p>Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.</p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    </div>
                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s3.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Adventure in Life</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s4.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Energy & Vitality</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s1.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Personality Traits</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s2.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Political career</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s3.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Adventure in Life</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s4.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Energy & Vitality</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s1.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Personality Traits</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s2.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Political career</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s3.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Adventure in Life</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                        <div class="service-col">
                                            <div class="img">
                                                <img src="img/s4.jpg" alt="" class="img-fluid">
                                            </div>
                                            <div class="bdy">
                                                <h2 class="title"><a href="#">Energy & Vitality</a></h2>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                                </p>
                                                <a href="#" class="kwm-btn">Know More</a>
                                            </div>
                                        </div>
                                    </div>--%>
                            </div>
                        </div>
                        <%--  <div id="prashna" class="container tab-pane fade" style="display: none">
                            <br>
                            <div class="row service-cols">
                                <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                    <div class="service-col">
                                        <div class="img">
                                            <img src="img/s1.jpg" alt="" class="img-fluid">
                                        </div>
                                        <div class="bdy">
                                            <h2 class="title"><a href="#">Personality Traits</a></h2>
                                            <p>
                                                Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                            </p>
                                            <a href="#" class="kwm-btn">Know More</a>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                    <div class="service-col">
                                        <div class="img">
                                            <img src="img/s2.jpg" alt="" class="img-fluid">
                                        </div>
                                        <div class="bdy">
                                            <h2 class="title"><a href="#">Political career</a></h2>
                                            <p>
                                                Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                            </p>
                                            <a href="#" class="kwm-btn">Know More</a>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                    <div class="service-col">
                                        <div class="img">
                                            <img src="img/s3.jpg" alt="" class="img-fluid">
                                        </div>
                                        <div class="bdy">
                                            <h2 class="title"><a href="#">Adventure in Life</a></h2>
                                            <p>
                                                Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                            </p>
                                            <a href="#" class="kwm-btn">Know More</a>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-xl-3 col-lg-4 col-sm-6 wow fadeInUp">
                                    <div class="service-col">
                                        <div class="img">
                                            <img src="img/s4.jpg" alt="" class="img-fluid">
                                        </div>
                                        <div class="bdy">
                                            <h2 class="title"><a href="#">Energy & Vitality</a></h2>
                                            <p>
                                                Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                            </p>
                                            <a href="#" class="kwm-btn">Know More</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>--%>
                    </div>
                    <%--  <div class="vwall-sec text-center" style="display: none">
                        <div class="vwall">We have <span>11 more interesting categories</span> for you...</div>
                        <a class="vwall-btn" href="#">Click to View More...</a>
                    </div>--%>
                </div>
            </div>
        </section>
        <section id="testimonials" class="section-bg wow fadeInUp">
            <div class="container">
                <header class="section-header">
                    <h3>Testimonials - Our Happy Customer's</h3>
                    <a href="managetestimonials.html" title="Manage Testimonials">
                        <p style="color: black; font-weight: bold; /*text-decoration-line: underline; */">
                            Write Your Testimonial&nbsp;<img src="<%=ResolveUrl("~/Image/pencil-icon.png") %>" title="Testimonial" alt="Testimonial" />
                        </p>
                    </a>
                </header>
                <div class="owl-carousel testimonials-carousel" id="testimonialid" runat="server">
                    <%--<div class="testimonial-item">
                            <img src="img/testi.png" class="testimonial-img" alt="">
                            <p>
                                <img src="img/quote-sign-left.png" class="quote-sign-left" alt="" />
                                Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper.
                                    <img src="img/quote-sign-right.png" class="quote-sign-right" alt="" />
                            </p>
                            <h3>Mr. SN Chattarjee</h3>
                        </div>--%>
                    <%--<div class="testimonial-item">
                            <img src="img/testi.png" class="testimonial-img" alt="">
                            <p>
                                <img src="img/quote-sign-left.png" class="quote-sign-left" alt="">
                                Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper.
                               <img src="img/quote-sign-right.png" class="quote-sign-right" alt="">
                            </p>
                            <h3>Mr. SN Chattarjee</h3>
                        </div>
                         <div class="testimonial-item">
                            <img src="img/testi.png" class="testimonial-img" alt="">
                            <p>
                                <img src="img/quote-sign-left.png" class="quote-sign-left" alt="">
                                Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper.
                                <img src="img/quote-sign-right.png" class="quote-sign-right" alt="">
                            </p>
                            <h3>Mr. SN Chattarjee</h3>
                        </div>
                 <div class="testimonial-item">
                            <img src="img/testi.png" class="testimonial-img" alt="">
                            <p>
                                <img src="img/quote-sign-left.png" class="quote-sign-left" alt="">
                                Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper.
              <img src="img/quote-sign-right.png" class="quote-sign-right" alt="">
                            </p>
                            <h3>Mr. SN Chattarjee</h3>
                        </div>--%>
                </div>
            </div>
        </section>
        <!-- #testimonials -->
        <!--========================== Services Section   ============================-->
        <section id="expert">
            <div class="container">
                <header class="section-header wow fadeInUp">
                    <h3>Experts Comments</h3>
                    <%--<p>Experience Story/ Testimonials of the our respected customers</p>--%>
                </header>
                <div class="owl-carousel expert-carousel" id="expertid" runat="server">
                    <%--<div class="expert-item">
                        <img src="img/comment.jpg" class="expert-img" alt="">
                        <p>
                          <img src="img/quote-sign-left.png" class="quote-sign-left" alt="">
                          Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper.
                          <img src="img/quote-sign-right.png" class="quote-sign-right" alt="">
                        </p>
			            <h3>Mr. SN Chattarjee</h3>
			            <div class="cmddesg">(Vice President ICSA) Counsil of Astrological Sciences, (Regd.)</div>
                      </div>--%>
                </div>
            </div>
        </section>
        <!-- #services -->
        <!--==========================    About Us Section            ============================-->
        <%-- <section id="about" style="display: none;">
            <div class="container">
                <div class="fus">
                    <div class="titlehead mb-3">Also for you</div>
                    <div class="row">
                        <div class="col-xl-3 col-sm-6 form-group text-center wow fadeInUp">
                            <div class="fuimg">
                                <img src="img/fu1.jpg" alt="">
                            </div>
                            <div class="bdy">
                                <h2 class="title"><a href="#">Learn Astrology</a></h2>
                                <div class="desc">
                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                </div>
                                <a href="#" class="kwm-btn">Know More</a>
                            </div>
                        </div>
                        <div class="col-xl-3 col-sm-6 form-group text-center wow fadeInUp">
                            <div class="fuimg">
                                <img src="img/fu2.jpg" alt="">
                            </div>
                            <div class="bdy">
                                <h2 class="title"><a href="#">Free Kundali</a></h2>
                                <div class="desc">
                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                </div>
                                <a href="#" class="kwm-btn">Know More</a>
                            </div>
                        </div>
                        <div class="col-xl-3 col-sm-6 form-group text-center wow fadeInUp">
                            <div class="fuimg">
                                <img src="img/fu3.jpg" alt="">
                            </div>
                            <div class="bdy">
                                <h2 class="title"><a href="#">Free Astrology</a></h2>
                                <div class="desc">
                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                </div>
                                <a href="#" class="kwm-btn">Know More</a>
                            </div>
                        </div>
                        <div class="col-xl-3 col-sm-6 form-group text-center wow fadeInUp">
                            <div class="fuimg">
                                <img src="img/fu4.jpg" alt="">
                            </div>
                            <div class="bdy">
                                <h2 class="title"><a href="#">Free Astrology</a></h2>
                                <div class="desc">
                                    Lorem ipsum dolor sit amet, consectetur elit, sed do eiusmod tempor ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.
                                </div>
                                <a href="#" class="kwm-btn">Know More</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>--%>
        <div class="alert alert-added alert-dismissible alrtfxd" id="addtocartmsg" style="display: none;">
            <%--<a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
            <i class="fa fa-check-circle fchk"></i><strong>NA</strong> added to your cart 
            <a href="javascript:;" class="kwm-btn-white ml-2">Proceed to Checkout</a>--%>
        </div>
    </main>
</asp:Content>

