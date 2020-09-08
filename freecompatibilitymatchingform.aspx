<%@ Page Title="Free Kundli Matching: Online Kundli Match Making for Marriage | Astro Envision" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="freecompatibilitymatchingform.aspx.cs" Inherits="freecompatibilitymatchingform" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function selectRadioButton() {
            var y = document.getElementById("ctl00_ContentPlaceHolder1_maleid");
            var n = document.getElementById("ctl00_ContentPlaceHolder1_femaleid");
            if (y.checked == false && n.checked == false) {
                alert("Please select Any Option");
                return false;
            }
            return true;
        }
    </script>
    <meta name="description" content="Looking for Free Kundli Matching Online? Free Kundli Matching or Guna - Dosha Milan is a compatibility between a Boy and a Girl. Astroenvision does an accurate Kundli matching with much deep insight based on Vedic Astrology." />
    <meta name="keywords" content="free kundli matching, free online horoscope compatibility report, free horoscope matching, free guna milan, free kundali matching for marriage, Astro Envision" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <div class="container-sec">
            <div style="clear: both;"></div>
            <div class="content-center">
                <%--<h1 class="pageheading">Free Kundli Matching</h1>--%>
                <div class="line">
                    <h1 id="heading_div">Free Kundli Matching</h1>
                </div>
                <div style="clear: both;"></div>
                <div class="col-sm-12">
                    <div class="form-background_article">
                        <div class="fullarticle">
                            <%--<header class="section-header">
                            <h3>Free Kundli Matching</h3>
                           </header>--%>
                            <div class="row">
                                <div class="col-sm-12">
                                    <h2 style="text-align: center;">Free Online Kundli Matching | Free Horoscope Matching | Free Guna-Dosha Milan</h2>
                                    <p>In this Free Online Kundli matching Report, Astro Envision will provide you detailing and explanation of Ashtakoot matching process which is an important part of matching and given to you in this Free Kundli Matching| Free Guna-Dosha Milan matching</p>
                                </div>
                            </div>

                            <div class="col-sm-12 my-2 py-1">
                                <div class="row justify-content-center align-self-center">
                                    <h2><i class="fa fa-angle-double-right"></i>You are a Boy and want to check Kundli Matching with a Girl.&nbsp;<asp:LinkButton ID="lnkboytogirl" runat="server" OnClick="lnkboytogirl_Click">Click Here</asp:LinkButton></h2>
                                </div>
                                <div class="row justify-content-center align-self-center py-1">
                                    <strong>Or</strong>
                                </div>
                                <div class="row justify-content-center align-self-center">
                                    <h2><i class="fa fa-angle-double-right"></i>You are a Girl and want to check Kundli Matching with a Boy.&nbsp;<asp:LinkButton ID="lnkgirltoboy" runat="server" OnClick="lnkgirltoboy_Click">Click Here</asp:LinkButton></h2>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-12">
                                    <h1 style="text-align: center; color: mediumblue; font-weight: bold; font-size: 1.5rem;">Why you should look beyond the Free Kundli Matching ?</h1>
                                    <div class="row justify-content-md-center pt-3">
                                        <div class="col-xl-9 col-sm-12 form-group">
                                            <div class="table-responsive">
                                                <table class="table table-bordered crttbl">
                                                    <thead style="background-color: #f25e0a;">
                                                        <tr>
                                                            <th class="text-left" style="color: white;">See what full report are available for you:</th>
                                                            <th class="text-center" style="color: white; width: 19%;">Free Report</th>
                                                            <th class="text-center" style="color: white; width: 15%;">Paid Report</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <tr>
                                                            <th class="text-left" style="color: black; font-weight: normal;">36 Point Gun Milan</th>
                                                            <th class="text-center">
                                                                <img style="height: 20px;" src="img/right.png" /></th>
                                                            <th class="text-center">
                                                                <img style="height: 20px;" src="img/right.png" /></th>
                                                        </tr>
                                                        <tr>
                                                            <th class="text-left" style="color: black; font-weight: normal;">Manglik Dosha Report</th>
                                                            <th class="text-center">
                                                                <img style="height: 20px;" src="img/right.png" /></th>
                                                            <th class="text-center">
                                                                <img style="height: 20px;" src="img/right.png" /></th>
                                                        </tr>
                                                        <tr>
                                                            <th class="text-left" style="color: black;">Individual reports for Bride and Groom on: </th>
                                                            <th></th>
                                                            <th></th>
                                                        </tr>

                                                        <tr>
                                                            <th class="text-left" style="color: black; font-weight: normal;">Nakashtra Dosha Report</th>
                                                            <th class="text-center">
                                                                <img style="height: 20px;" src="img/Cross.png" />
                                                            </th>
                                                            <th class="text-center">
                                                                <img style="height: 20px;" src="img/right.png" /></th>
                                                        </tr>
                                                        <tr>
                                                            <th class="text-left" style="color: black; font-weight: normal;">Eka Nakashtra Dosha Report</th>
                                                            <th class="text-center">
                                                                <img style="height: 20px;" src="img/Cross.png" />
                                                            </th>
                                                            <th class="text-center">
                                                                <img style="height: 20px;" src="img/right.png" /></th>
                                                        </tr>
                                                        <tr>
                                                            <th class="text-left" style="color: black; font-weight: normal;">27th Nakashtra Dosha Report</th>
                                                            <th class="text-center">
                                                                <img style="height: 20px;" src="img/Cross.png" /></th>
                                                            <th class="text-center">
                                                                <img style="height: 20px;" src="img/right.png" /></th>
                                                        </tr>
                                                        <tr>
                                                            <th class="text-left" style="color: black; font-weight: normal;">Vadha Vainasika Dosha Report</th>
                                                            <th class="text-center">
                                                                <img style="height: 20px;" src="img/Cross.png" /></th>
                                                            <th class="text-center">
                                                                <img style="height: 20px;" src="img/right.png" /></th>
                                                        </tr>
                                                        <tr>
                                                            <th class="text-left" style="color: black; font-weight: normal;">Dosha Samya Report</th>
                                                            <th class="text-center">
                                                                <img style="height: 20px;" src="img/Cross.png" /></th>
                                                            <th class="text-center">
                                                                <img style="height: 20px;" src="img/right.png" /></th>
                                                        </tr>
                                                        <tr>
                                                            <th class="text-left" style="color: black; font-weight: normal;">Kaal Sarpa Yoga Report</th>
                                                            <th class="text-center">
                                                                <img style="height: 20px;" src="img/Cross.png" /></th>
                                                            <th class="text-center">
                                                                <img style="height: 20px;" src="img/right.png" /></th>
                                                        </tr>
                                                        <tr>
                                                            <th class="text-left" style="color: black; font-weight: normal;">Personality Traits for boy and girl</th>
                                                            <th class="text-center">
                                                                <img style="height: 20px;" src="img/Cross.png" /></th>
                                                            <th class="text-center">
                                                                <img style="height: 20px;" src="img/right.png" /></th>
                                                        </tr>
                                                        <tr>
                                                            <th class="text-left" style="color: black;">Pay for detailed  report</th>
                                                            <th class="text-center" style="color: black; font-weight: normal;">Free</th>
                                                            <th class="text-left" style="background-color: #f25e0a;" id="thPrice" runat="server"></th>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                    <h2 style="text-align: center; color: mediumblue; font-weight: bold;">Find the New Way of Kundli Matching Process
                                    </h2>

                                    <p>As you are aware that with the increased financial empowerment of females and great exposure to outside word by them, various issues arises between the couples such as,&nbsp; difference of opinion on small issues of day to day life, lack of communication between the couple, lack of intimacy due to work pressure, anger and resentment, lack of emotional intimacy between them, increasing financial and power goals of both the individuals leading to selfish behave, lack of equality in terms of intelligence, constant arguing between the couple on trivial issues in day to day life, unrealistic expectations by both the individuals after the marriage, who cares attitude after marriage, lack of sincerity, developing long-distance relationship, Interference of parents in married life, addition of toxic mode, single parenting, lack of appreciation, live in relationship are some burning issues and it becomes all the more important to address to all these issues and know much more deep about the perfect Kundli matching and the various traits of your would be prospective bride or groom.</p>
                                    <p></p>
                                    <p><strong>Here We Provide</strong></p>
                                    <h3 style="text-align: left;">Super Solution of Kundli matching</h3>
                                    <p>Simply looking at Guna- Dosha as per Ashtakoot Matching will not produce results for all the above issues being faced by couple in their day to day life in the modern world.</p>
                                    <p>So to ensure that matching is carried out in a perfect manner, we provide you the relevant astro reports &ndash; (refer the Home page of astroenvision) covering almost all the most important and significant factors about an individual, so that a wise decision is taken by user after reading the reports of their &ldquo;Would be alliance&rdquo;</p>
                                    <p><strong>Here are some important reports we provide in compatibility matching beyond the free matching report on Guna Dosha</strong></p>
                                    <ul>
                                        <li>Manglik Dosha Report</li>
                                        <li>Dosha-Samay Report</li>
                                    </ul>
                                    <p>This Dosha Samay reports covers dosha arising from the most Malefic planets namely, Mars, Saturn, Rahu and Sun. This is very important report and is much more powerful tool than the Manglik Dosha Report.</p>
                                    <ul>
                                        <li>Nakashtra Dosha Report</li>
                                        <li>Eka Nakashtra Dosha Report</li>
                                        <li>Vaadh Vainashik Dosha Report</li>
                                        <li>27th Constellation Dosha Report</li>
                                        <li>Kaal- Sarpa Report</li>
                                    </ul>
                                    <p><strong>This Free Kundli matching report consist the Ashtakoot matching process as follows:-</strong></p>
                                    <table class="col-sm-6 mx-auto" width="200" border="1" cellpadding="1" cellspacing="1">
                                        <tbody>
                                            <tr>
                                                <td style="text-align: center;"><strong>SNo.</strong></td>
                                                <td style="text-align: center;"><strong>Ashtakoot</strong></td>
                                                <td style="text-align: center;"><strong>Gunas</strong></td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: center;">1</td>
                                                <td style="text-align: center;">Nadi</td>
                                                <td style="text-align: center;">8</td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: center;">2</td>
                                                <td style="text-align: center;">Bhakoot</td>
                                                <td style="text-align: center;">7</td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: center;">3</td>
                                                <td style="text-align: center;">Gana</td>
                                                <td style="text-align: center;">6</td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: center;">4</td>
                                                <td style="text-align: center;">Grahamaitri</td>
                                                <td style="text-align: center;">5</td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: center;">5</td>
                                                <td style="text-align: center;">Yoni</td>
                                                <td style="text-align: center;">4</td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: center;">6</td>
                                                <td style="text-align: center;">Tara</td>
                                                <td style="text-align: center;">3</td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: center;">7</td>
                                                <td style="text-align: center;">Vasya</td>
                                                <td style="text-align: center;">2</td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: center;">8</td>
                                                <td style="text-align: center;">Varna</td>
                                                <td style="text-align: center;">1</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-sm-12 mt-2">
            <div class="row d-flex justify-content-center">
                <div class="top-banner-holder">
                    <a href="<%=ResolveUrl("~/free-horoscope.html") %>" title="Free Horoscope">
                        <div class="topbanner">
                            <img src="<%=ResolveUrl("~/IMAGES/free_horoscope.jpg") %>" alt="Free Horoscope" title="Free Horoscope" />
                        </div>
                    </a>
                </div>
                <div class="top-banner-holder">
                    <a href="<%=ResolveUrl("~/single-most-important-planet-for-you.html") %>" title="The Most Important planet for You">
                        <div class="topbanner">
                            <img src="<%=ResolveUrl("~/IMAGES/single_most_imp_planet.jpg") %>" alt="The Most Important planet for You" title="The Most Important planet for You" />
                        </div>
                    </a>
                </div>
                <div class="top-banner-holder">
                    <a href="<%=ResolveUrl("~/two-most-important-planet-for-you.html") %>" title="Two Important planet for You">
                        <div class="topbanner">
                            <img src="<%=ResolveUrl("~/IMAGES/two_most_imp_planet.jpg") %>" alt="Two Important planet for You" title="Two Important planet for You" />
                        </div>
                    </a>
                </div>
                <div class="top-banner-holder">
                    <a href="<%=ResolveUrl("~/three-most-important-planet-for-you.html") %>" title="Three Important planet for You">
                        <div class="topbanner">
                            <img src="<%=ResolveUrl("~/IMAGES/three_most_imp_planet.jpg") %>" alt="Three Important planet for You" title="Three Important planet for You" />
                        </div>
                    </a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

