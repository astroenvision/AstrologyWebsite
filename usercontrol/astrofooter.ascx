<%@ Control Language="C#" AutoEventWireup="true" CodeFile="astrofooter.ascx.cs" Inherits="usercontrol_astrofooter" %>


<!--==========================
    Footer
  ============================-->
<footer id="footer">
    <div class="footer-top">
        <div class="container">
            <div class="form-group text-center">
                <a class="hme" href="<%=ResolveUrl("~") %>" title="Astro Envision">
                    <img class="footlogo" src="<%=ResolveUrl("~/Image/small_logo.svg") %>" alt="Astro Envision" title="Astro Envision" /></a>
            </div>
            <div class="text-center footsocial">
                <%--<a href="#" target="_blank"><img class="sicon" src="img/whatsapp.png" /></a>--%>
                <a href="https://www.facebook.com/astroenvisionservices/" target="_blank" title="Share this on Facebook" rel="noopener noreferrer nofollow">
                    <img class="sicon" src="<%=ResolveUrl("~/img/facebook.png") %>" alt="Astro Envision Facebook Profile" title="Astro Envision Facebook Profile" /></a>
                <a href="https://twitter.com/astroenvision/" target="_blank" title="Share this on Twitter" rel="noopener noreferrer nofollow">
                    <img class="sicon" src="<%=ResolveUrl("~/img/twitter.png") %>" alt="Astro Envision Twitter Profile" title="Astro Envision Twitter Profile" /></a>
                <a href="https://www.linkedin.com/in/astroenvision/" target="_blank" title="Share this on Linkedin" rel="noopener noreferrer nofollow">
                    <img class="sicon" src="<%=ResolveUrl("~/img/linkedin.png") %>" alt="Astro Envision Linkedin Profile" title="Astro Envision Linkedin Profile" /></a>
                <a href="https://www.instagram.com/astroenvision/" target="_blank" title="Share this on Instagram" rel="noopener noreferrer nofollow">
                    <img class="sicon" src="<%=ResolveUrl("~/img/instagram.png") %>" alt="Astro Envision Instagram Profile" title="Astro Envision Instagram Profile" /></a>
                <%-- <a href="#" target="_blank">
                                    <img class="sicon" src="<%=ResolveUrl("~/img/pinterest.png") %>" alt="Astro Envision Pinterest Profile" title="Astro Envision Pinterest Profile" /></a>--%>
                <a href="https://www.youtube.com/channel/UCI6zN6xdgWq-mn3v9XTKP9A/" title="Share this on Youtube" rel="noopener noreferrer nofollow" target="_blank">
                    <img class="sicon" src="<%=ResolveUrl("~/img/youtube.png") %>" alt="Astro Envision Youtube Channel" title="Astro Envision Youtube Channel" /></a>
            </div>

            <div class="footlinks text-center">
                <%--<a href="<%=ResolveUrl("~/consult-an-astrologer.html") %>" title="Consult an Astrologer">Consult an Astrologer</a>--%>
                <a href="<%=ResolveUrl("~/astrology/testimonials.html") %>" title="Testimonials">Testimonials</a>
                <a href="<%=ResolveUrl("~/astrology/expert-s-comment.html") %>" title="Experts Comments">Experts Comments</a>
                <a href="<%=ResolveUrl("~/aboutus.html") %>" title="About Us">About Us</a>
                <a href="<%=ResolveUrl("~/contactus.html") %>" title="Contact Us">Contact Us</a>
                <a href="<%=ResolveUrl("~/feedback.html") %>" title="Feedback">Feedback</a>
                <a href="<%=ResolveUrl("~/sitemap.html") %>" title="Site Map">Sitemap</a>
                <a href="<%=ResolveUrl("~/faqs.html") %>" title="FAQs">FAQs</a>
                <a href="<%=ResolveUrl("~/privacy-policy.html") %>" title="Privacy Policy">Privacy Policy</a>
                <a href="<%=ResolveUrl("~/terms-of-use.html") %>" title="Terms of Use">Terms of Use</a>
                <a href="<%=ResolveUrl("~/photo-gallery.html") %>" title="Photo Gallery">Photo Gallery</a>
            </div>

        </div>
    </div>

    <div class="container">
        <div class="copyright">
            Copyright &copy; 2020 Astro Envision. All Rights Reserved
        </div>
        <div class="credits">
            Designed by : Astro Envision
        </div>
    </div>
</footer>
<!-- #footer -->
