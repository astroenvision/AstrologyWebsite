<%@ Page Title="Kundli Matching | Astro Envision" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="compatibilitymatchingform.aspx.cs" Inherits="compatibilitymatchingform" ValidateRequest="false" EnableEventValidation="false" %>

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
    <script src="js/CompatibilityMatching.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <div class="container-sec">
            <div style="clear: both;"></div>
            <%--<h1 class="fullarticle_catname">Kundli Matching</h1>--%>
            <div class="content-center">
                <div class="line">
                    <h1 id="heading_div">Kundli Matching</h1>
                </div>
                <div style="clear: both;"></div>
                <div class="col-sm-12">
                    <div class="form-background_article">
                        <div class="fullarticle">
                            <div class="row">
                                <div class="col-sm-12">
                                    <h2 style="text-align: center;">Kundli Matching | Horoscope Matching | Guna-Dosha Milan</h2>
                                    <h4 style="text-align: center;">Super Solution - The New Way of Kundli Matching Process</h4>
                                    <p>In this Online Kundli matching, Compatibility matching report, Astro Envision will provide you detailing, explanation of multiple ancient ways of matching of the birth chart of Girl and Boy for the alliance.</p>
                                </div>
                            </div>
                            <div class="col-sm-12 my-2 py-1">
                                <div class="row justify-content-center align-self-center">
                                    <h2><i class="fa fa-angle-double-right"></i>You are a Boy and want to check Kundli Matching with a Girl.&nbsp;<asp:LinkButton ID="lnkboytogirl" runat="server" OnClientClick="SaveToCart();" OnClick="lnkboytogirl_Click">Click Here</asp:LinkButton></h2>
                                </div>
                                <div class="row justify-content-center align-self-center py-1">
                                    <strong>Or</strong>
                                </div>
                                <div class="row justify-content-center align-self-center">
                                    <h2><i class="fa fa-angle-double-right"></i>You are a Girl and want to check Kundli Matching with a Boy.&nbsp;<asp:LinkButton ID="lnkgirltoboy" runat="server" OnClientClick="SaveToCart();" OnClick="lnkgirltoboy_Click">Click Here</asp:LinkButton></h2>
                                </div>
                            </div>
                                          <div class="row">
                                <div class="col-sm-12">
                                    <h1 style="text-align: center; color: mediumblue; font-weight: bold; font-size: 1.5rem;">List of Astro reports covered in Kundli Matching</h1>
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
                                  
                                </div>
                            </div>
                           
                                   <div class="row">
                                <div class="col-sm-12">
                                    <h1 style="text-align: center; color: mediumblue; font-weight: bold; font-size: 1.5rem;">Additional Astro reports you may like to read</h1>
                                    <div class="row justify-content-md-center pt-3">
                                           <div class="col-xl-8 col-sm-12 form-group" id="categories_list" runat="server">
                    <div class="table-responsive">
                        <table class="table table-bordered crttbl">
                            <%--<thead>
                                <tr>
                                    <th class="text-left">Categories</th>
                                    <th class="text-right">Actual Amount</th>
                                    <th class="text-right">Discount</th>
                                    <th class="text-right">You Save</th>
                                    <th class="text-right">Payable Amount</th>
                                    <th class="text-left">Remove</th>
                                </tr>
                            </thead>--%>
                            <thead id="divColoumNameForCat" runat="server">
                              
                            </thead>
                            <tbody id="divData" runat="server">
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class="col-xl-4 col-sm-12 form-group" id="categories_price" runat="server">
                    <table class="table table-bordered crttbl">
                        <tbody>
                               <tr>
                                <td class="text-left"><strong>Kundli Matching Price:</strong></td>
                                <td class="text-left">
                                    <div id="divKundliMactingprice" runat="server">₹0.00</div>
                                </td>
                                    </tr>
                            <tr>
                                <td class="text-left"><strong>Additional Report Amount:</strong></td>
                                <td class="text-left">
                                    <div id="divTotalPayableAmount" runat="server">₹0.00</div>
                                </td>
                            </tr>
                            <tr>
                                <td class="text-left"><strong>You Save:</strong></td>
                                <td class="text-left">
                                    <div id="divYouSave" runat="server">₹0.00</div>
                                </td>
                            </tr>
                            <tr style="display:none">
                                <td class="text-left"><strong>Total Payable Amount:</strong></td>
                                <td class="text-left">
                                    <div id="divTotalAmount" runat="server">₹0.00</div>
                                </td>
                            </tr>
                            
                                   <tr>
                                <th class="text-left"><strong>Total Payable Amount:</strong></th>
                                <th class="text-left">
                                    <div id="divActualPayableAmount" runat="server">₹0.00</div>
                                </th>
                            </tr>
                        </tbody>
                    </table>
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
                            <div class="row">
                                <div class="col-sm-12">
                                    <p>These are:</p>
                                    <ul>
                                        <li>Ashtakoot Guna- Dosha (36 gunas match)</li>
                                        <li>Manglik Dosha Report</li>
                                        <li>Dosha-Samay Report – Covers maleficence of Mars, Sat, Sun and Rahu</li>
                                        <li>Nakashtra Dosha Report</li>
                                        <li>Eka Nakashtra Dosha Report</li>
                                        <li>Vaadh Vainashik Dosha Report</li>
                                        <li>27th Constellation Dosha Report</li>
                                        <li>Kaal- Sarpa Report</li>
                                    </ul>
                                     <h3 style="text-align: center; color: red;">Important and critical reports for more clarity about Girl or Boy</h3>
                                    <p>Apart from the above, you may like to look at the personality traits, money, wealth, career, profession, adventure, fame, fortune and other important report read and understand the grand compatibility through reports given on the <a href="<%=ResolveUrl("~/index.html") %>" title="Astro Envision">Home Page</a></p>
                                </div>
                            </div>
                            
                            <%--<div class="accntsec">
                        <header class="section-header">
                            <h3>Kundli Matching</h3>
                        </header>
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="custom-control custom-radio">
                                    <asp:RadioButton ID="maleid" value="M" Text="You are a Boy and want to check match with a Girl." GroupName="Gender" CssClass="matchgendercss" runat="server" />
                                </div>
                            </div>
                        </div>
                        <div style="clear: both;"></div>
                        <asp:Label ID="LabelOr" CssClass="matchlabelcss" runat="server">OR</asp:Label>
                        <div style="clear: both;"></div>
                        <div class="row">
                            <div class="col-sm-12">
                                <div class="custom-control custom-radio">
                                    <asp:RadioButton ID="femaleid" value="F" Text="You are a Girl and want to check match with a Boy." GroupName="Gender" CssClass="matchgendercss" runat="server" />
                                </div>
                            </div>
                        </div>
                        <div class="mt-3 text-center">
                            <asp:Button ID="btnnext" runat="server" class="kwm-btn-lg" Text="Next >>" OnClick="btnnext_Click" OnClientClick="return selectRadioButton();"></asp:Button>
                        </div>
                        </div>--%>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
    <input type="hidden" runat="server" id="TotalAmounts" />
    <input type="hidden" runat="server" id="CurrencyType" />
    <input type="hidden" runat="server" id="hdncartid" />
    <input type="hidden" runat="server" id="hdncountrycode" />
    <input type="hidden" runat="server" id="hdngroupid" />
        <input type="hidden" runat="server" id="hdnKundliMacting" />

    <script type="text/javascript">
        Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler);
        function EndRequestHandler(sender, args) {
            if (args.get_error() != undefined) {
                args.set_errorHandled(true);
            }
        }
    </script>
</asp:Content>

