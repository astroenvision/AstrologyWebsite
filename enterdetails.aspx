<%@ Page Language="C#" AutoEventWireup="true" CodeFile="enterdetails.aspx.cs" Inherits="enterdetails" EnableEventValidation="false" %>

<!DOCTYPE html>
<%@ Register Src="~/usercontrol/astroheader.ascx" TagName="astroheader" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/astrofooter.ascx" TagName="astrofooter" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Astrology and Consultancy, Prashna Astrology</title>
    <meta name="robots" content="noindex,nofollow" />
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta content="width=device-width, initial-scale=1.0,maximum-scale=1.0, user-scalable=no" name="viewport" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <script type="text/javascript" src="js/astroenvision.js"></script>
    <script type="text/javascript" src="javascript/enterdetails.js"></script>
    <%--<script src="javascript/popupcalenderlead.js" type="text/javascript"></script>--%>
</head>
<body>
    <form id="form1" runat="server" class="needs-validation" novalidate>
        <asp:ScriptManager runat="Server" ID="ScriptManager1" />
        <uc1:astroheader ID="astroheader1" runat="server" />
        <%-- <asp:UpdatePanel ID="upMain" runat="server">
            <ContentTemplate>--%>
        <section class="bannerarea">
            <div id="loadingimg" style="display: none;">
                <img id="loading-image" src="IMAGES/please_wait.gif" alt="Loading..." />
            </div>
            <div id="dvLoaderConnnetion" runat="server" style="display: none"></div>
            <div class="container">
                <div class="logo-section text-center">
                    <a class="hme" href="<%=ResolveUrl("~/index.html") %>">
                        <img class="lgo" src="<%=ResolveUrl("~/Image/large_logo.svg") %>" alt="Astro Envision" title="Astro Envision" /></a>
                </div>
                <div class="row justify-content-center">
                    <div class="col-sm-9">
                        <div class="accntsec">
                            <header class="section-header">
                                <h3>Enter Birth Details</h3>
                                <%-- <p>Enter Your Birth Details</p>--%>
                            </header>
                            <div class="row">
                                <div class="col-sm-6 form-group">
                                    <label class="required">Name</label>
                                    <%--<input type="text" name="" class="form-control form-control-lg" placeholder="Enter full name">--%>
                                    <asp:TextBox ID="cl_name" runat="server" class="form-control form-control-lg" placeholder="Enter full name"></asp:TextBox>
                                </div>

                                <div class="col-sm-6 form-group" style="display:none;">
                                    <label class="required">Email ID</label>
                                    <asp:TextBox ID="txtmail" runat="server" class="form-control form-control-lg" placeholder="Enter email id"></asp:TextBox>
                                    <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator2"
                                        runat="server" ErrorMessage="Please Enter Valid Email ID"
                                        ValidationGroup="SaveData" ControlToValidate="txtmail"
                                        ForeColor="Red" Display="Dynamic"
                                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                                    </asp:RegularExpressionValidator>--%>
                                </div>
                                <div class="col-sm-6 form-group" style="display: none;">
                                    <label class="required">Birth Date</label>
                                    <div class="calicnrgt">
                                        <asp:TextBox ID="dob" runat="server" Width="85%" CssClass="form-control form-control-lg form-control-txtmargin" placeholder="dd/mm/yyyy" AutoCompleteType="Disabled" autocomplete="off"></asp:TextBox>
                                        <img id="cal" src='Image/cal1.png' width="22" height="24" onclick="popUpCalendar(this, form1.dob,'dd/mm/yyyy',event)" />
                                    </div>
                                </div>
                                <div class="col-sm-6 form-group">
                                    <label class="required">Birth Date</label>
                                    <div class="calicnrgt">
                                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                            <ContentTemplate>
                                                <asp:DropDownList ID="ddlDate" runat="server" Width="25%" CssClass="form-control form-control-lg form-control-dll" AutoPostBack="true">
                                                </asp:DropDownList>
                                                <asp:DropDownList ID="ddlMonth" runat="server" Width="30%" CssClass="form-control form-control-lg form-control-dll" AutoPostBack="true">
                                                </asp:DropDownList>
                                                <asp:DropDownList ID="ddlYear" runat="server" Width="30%" CssClass="form-control form-control-lg form-control-dll" AutoPostBack="true">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                                <div class="col-sm-6 form-group">
                                    <label class="required">Birth Time <font color="red">(24 hours format)</font></label>
                                    <div class="calicnrgt">
                                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                            <ContentTemplate>
                                                <%--<input type="text" name="" class="form-control form-control-lg" placeholder="Fri, 11-Nov-2019, 04:28 PM">--%>
                                                <asp:DropDownList ID="hob" runat="server" Width="42%" CssClass="form-control form-control-lg form-control-dll" AutoPostBack="true">
                                                </asp:DropDownList>
                                                <asp:DropDownList ID="mob" runat="server" Width="42%" CssClass="form-control form-control-lg form-control-dll" AutoPostBack="true">
                                                </asp:DropDownList>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>

                                <div class="col-sm-6 form-group">
                                    <label class="required">Gender</label>
                                    <asp:DropDownList ID="ddlgender" runat="server" CssClass="form-control form-control-lg browser-default">
                                        <asp:ListItem Value="" Selected="True">Select Gender</asp:ListItem>
                                        <asp:ListItem Value="M">Male</asp:ListItem>
                                        <asp:ListItem Value="F">Female</asp:ListItem>
                                    </asp:DropDownList>
                                </div>

                                <div class="col-sm-6 form-group">
                                    <label class="required">Birth Country</label>
                                    <%-- <asp:DropDownList ID="ddlCountry" runat="server" CssClass="form-control form-control-lg js-example-placeholder-single" AutoPostBack="true" OnSelectedIndexChanged="ddlCountry_SelectChnage">
                                            </asp:DropDownList>--%>
                                    <asp:DropDownList ID="ddlCountry" runat="server" CssClass="form-control-lg js-example-placeholder-single" Onchange="ddlCountryChange();">
                                    </asp:DropDownList>
                                </div>

                                <div class="col-sm-6 form-group">
                                    <label class="required">Birth State</label>
                                    <%--<asp:DropDownList ID="ddlState" runat="server" CssClass="form-control form-control-lg js-example-placeholder-single" AutoPostBack="true" OnSelectedIndexChanged="ddlState_SelectChange">
                                                <asp:ListItem Selected="True" Value="-1">Select State</asp:ListItem>
                                            </asp:DropDownList>--%>
                                    <asp:DropDownList ID="ddlState" runat="server" CssClass="form-control form-control-lg js-example-placeholder-single" Onchange="ddlStateChange();">
                                        <asp:ListItem Selected="True" Value="-1">Select State</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-sm-6 form-group">
                                    <label class="required">Birth City</label>
                                    <asp:DropDownList ID="ddlCity" runat="server" CssClass="form-control form-control-lg js-example-placeholder-single" AutoPostBack="true">
                                        <asp:ListItem Selected="True" Value="-1">Select City</asp:ListItem>
                                    </asp:DropDownList>
                                </div>

                                <div class="col-sm-2 form-group">
                                    <label class="required">Latitude</label>
                                    <%--<input type="text" name="" class="form-control form-control-lg" placeholder="Latitude">--%>
                                    <asp:TextBox ID="lat" runat="server" CssClass="form-control form-control-lg" placeholder="Latitude" disabled="disabled"></asp:TextBox>
                                </div>

                                <div class="col-sm-2 form-group">
                                    <label class="required">Longitude</label>
                                    <%--<input type="text" name="" class="form-control form-control-lg" placeholder="Longitude">--%>
                                    <asp:TextBox ID="lng" runat="server" CssClass="form-control form-control-lg" placeholder="Longitude" disabled="disabled"></asp:TextBox>
                                </div>

                                <div class="col-sm-2 form-group">
                                    <label class="required">Time Zone</label>
                                    <%--<input type="text" name="" class="form-control form-control-lg" placeholder="Time Zone">--%>
                                    <asp:TextBox ID="tz" runat="server" CssClass="form-control form-control-lg" placeholder="Time Zone" disabled="disabled"></asp:TextBox>
                                </div>

                                <%-- <div class="col-sm-12 form-group">
                                        <label class="required">Remark</label>
                                        <textarea type="text" name="" class="form-control form-control-lg" rows="2" placeholder="Remark type here..."></textarea>
                                        </div>--%>

                                <div class="col-sm-12 form-group">
                                    <div class="tnc-ttl">Terms and Conditions</div>
                                    <div class="tnc-desc">Please read the terms and indidate that you accept them to continue with the set up process. By clicking I accept below you are agreeing to the terms and conditions below, the Program Policy, and the Privacy Policy.</div>
                                </div>
                                <%-- <div class="col-sm-12 form-group">
                                    <div class="custom-control custom-checkbox">
                                        <input type="checkbox" class="custom-control-input" id="customCheck" name="example1" checked />
                                        <label class="custom-control-label" for="customCheck">I accept all Terms & Conditions</label>
                                    </div>
                                </div>--%>
                                <div class="col-sm-12 form-group">
                                    <label class="chkcontainer">
                                        <asp:CheckBox ID="chkTerms" runat="server" />I accept all Terms & Conditions
                                        <asp:Label ID="Label3" AssociatedControlID="chkTerms" runat="server"
                                            CssClass="checkmark"></asp:Label>
                                    </label>
                                </div>
                            </div>
                            <div class="mt-3 text-center">
                                <%--<button type="submit" class="kwm-btn-lg">Proceed to Payment</button>--%>
                                <asp:Button ID="btnsave" runat="server" CssClass="kwm-btn-lg" Text="Proceed to Payment" type="submit" ValidationGroup="SaveData" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <%--</ContentTemplate>
        </asp:UpdatePanel>--%>

        <uc2:astrofooter ID="astrofooter1" runat="server" />
        <input type="hidden" runat="server" id="hdnRegUserId" />
        <input type="hidden" runat="server" id="hdnUserType" />
        <input type="hidden" runat="server" id="hdnAstrologerIdVal" />
        <input type="hidden" runat="server" id="hdnAstrologerID" />
        <input type="hidden" runat="server" id="hdnAstrologerName" />
        <input type="hidden" runat="server" id="hdnPaymentFor" />
        <input type="hidden" runat="server" id="hdnRegUserEmailId" />
        <input type="hidden" runat="server" id="TotalAmounts" />
        <input type="hidden" runat="server" id="CurrencyType" />
        <input type="hidden" runat="server" id="Hclmail" />
        <input type="hidden" runat="server" id="Hclname" />
        <input type="hidden" runat="server" id="Hastmail" />
        <input type="hidden" runat="server" id="Hastname" />
        <input type="hidden" runat="server" id="hdnuser" />
        <input type="hidden" runat="server" id="hdnastmail" />
        <input type="hidden" runat="server" id="hdnastname" />
        <input type="hidden" runat="server" id="hdnclmail" />
        <input type="hidden" runat="server" id="hdnclname" />
        <input type="hidden" runat="server" id="hdnage" />
        <input type="hidden" runat="server" id="hdngender" />
        <input type="hidden" runat="server" id="hdnmob" />
        <input type="hidden" runat="server" id="hdnprof" />
        <input type="hidden" runat="server" id="hdngroup" />
        <input type="hidden" runat="server" id="hdngroup_u" />
        <input type="hidden" runat="server" id="hdnflag" />
        <input type="hidden" runat="server" id="username" />
        <input type="hidden" runat="server" id="hdnstate" />
        <input type="hidden" runat="server" id="hdndistrict" />
        <input type="hidden" runat="server" id="hdnlat" />
        <input type="hidden" runat="server" id="hdnlng" />
        <input type="hidden" runat="server" id="hiddendateformat" />
        <input type="hidden" runat="server" id="hdncit" />
        <input type="hidden" runat="server" id="hdntz" />
        <input type="hidden" runat="server" id="hdndifftz" />
        <input type="hidden" runat="server" id="hdnditob" />
        <input type="hidden" runat="server" id="hdnhob" />
        <input type="hidden" runat="server" id="hdnmiob" />
        <input type="hidden" runat="server" id="hdncon" />
        <input type="hidden" runat="server" id="hdnstateu" />
        <input type="hidden" runat="server" id="hdndist" />
        <input type="hidden" runat="server" id="hdncity" />
        <input type="hidden" runat="server" id="hdngroupu" />
        <input type="hidden" runat="server" id="hdncat" />
        <input type="hidden" runat="server" id="hdsunsetpre" />
        <input type="hidden" runat="server" id="hdsunrise" />
        <input type="hidden" runat="server" id="hdsunset" />
        <input type="hidden" runat="server" id="hdsunrisenext" />
        <div style="float: left; width: 40%; display: none;" id="makeenduserchartid" runat="server">
            <div id="Divgrid1_enduser" class="divg1homenewpage">
                <table>
                    <tr>
                        <td runat="server" id="hdsviewgrid_enduser" style="width: 520px;" align="left"></td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="divg1homenewpage11" style="display: none;">
            <asp:Label ID="label11" font-weight="600" font-family="Open Sans" Font-Size="11px"
                ForeColor="Black" runat="server" Text="Birth"></asp:Label>
            <asp:DropDownList ID="birth" runat="server" CssClass="drpo_homenew">
            </asp:DropDownList>
            <asp:Label ID="label12" font-weight="600" font-family="Open Sans" Font-Size="11px"
                ForeColor="Black" Style="display: none;" runat="server" Text="Planet"></asp:Label>
            <asp:DropDownList ID="planet" runat="server" Style="display: none;" CssClass="drpo_homenew">
            </asp:DropDownList>
            <asp:Label ID="label13" font-weight="600" font-family="Open Sans" Font-Size="11px"
                ForeColor="Black" runat="server" Text="D.O.B / D.O.Q"></asp:Label>
            <asp:TextBox ID="Texttodate" runat="server" CssClass="drpo_homenew"></asp:TextBox>
            <img src='Image/cal1.gif' onclick="popUpCalendar(this, form1.Texttodate,'dd/mm/yyyy',event)"
                class="calendra_homenew" alt="" />
        </div>
        <div class="column1ho" id="rashiid_enduser" style="display: none; float: left;">
            <div class="column-div1">
                <span>
                    <asp:Label ID="h1l1" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <div class="column-divr1">
                <span>
                    <asp:Label ID="h1r" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <div class="column-div2">
                <span>
                    <asp:Label ID="h2l1" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <div class="column-divr2">
                <span>
                    <asp:Label ID="h2r" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <div class="column-div3">
                <span>
                    <asp:Label ID="h3l1" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <div class="column-divr3">
                <span>
                    <asp:Label ID="h3r" runat="server" Text="">
                    </asp:Label></span>
            </div>
            <div class="column-div4">
                <span>
                    <asp:Label ID="h4l1" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <div class="column-divr4">
                <span>
                    <asp:Label ID="h4r" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <div class="column-div5">
                <span>
                    <asp:Label ID="h5l1" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <div class="column-divr5">
                <span>
                    <asp:Label ID="h5r" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <div class="column-div6">
                <span>
                    <asp:Label ID="h6l1" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <div class="column-divr6">
                <span>
                    <asp:Label ID="h6r" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <div class="column-div7">
                <span>
                    <asp:Label ID="h7l1" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <div class="column-divr7">
                <span>
                    <asp:Label ID="h7r" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <div class="column-div8">
                <span>
                    <asp:Label ID="h8l1" runat="server" Text="">
                    </asp:Label></span>
            </div>
            <div class="column-divr8">
                <span>
                    <asp:Label ID="h8r" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <div class="column-div9">
                <span>
                    <asp:Label ID="h9l1" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <div class="column-divr9">
                <span>
                    <asp:Label ID="h9r" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <div class="column-div10">
                <span>
                    <asp:Label ID="h10l1" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <div class="column-divr10">
                <span>
                    <asp:Label ID="h10r" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <div class="column-div11">
                <span>
                    <asp:Label ID="h11l1" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <div class="column-divr11">
                <span>
                    <asp:Label ID="h11r" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <div class="column-div12">
                <span>
                    <asp:Label ID="h12l1" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <div class="column-divr12">
                <span>
                    <asp:Label ID="h12r" runat="server" Text="">
                    </asp:Label>
                </span>
            </div>
            <figure class="fixedratio"></figure>
        </div>
        <input type="hidden" runat="server" id="hdnmoc" />
        <input type="hidden" runat="server" id="hdndob" />
        <input type="hidden" runat="server" id="hdnidob" />
        <input type="hidden" runat="server" id="hdnimoob" />
        <input type="hidden" runat="server" id="hdniyob" />
        <input type="hidden" runat="server" id="hdntob" />
        <input type="hidden" runat="server" id="hdnihob" />
        <input type="hidden" runat="server" id="hdnimob" />
        <input type="hidden" runat="server" id="Hnewdiffm" />
        <input type="hidden" runat="server" id="Hnewdiffm1" />
        <input type="hidden" runat="server" id="Hnewdiffv" />
        <input type="hidden" runat="server" id="Hnewdiffv1" />
        <input type="hidden" runat="server" id="hdntzo" />
        <input type="hidden" runat="server" id="Hidden4" />
        <input type="hidden" runat="server" id="hdnretro0" />
        <input type="hidden" runat="server" id="hdnretro1" />
        <input type="hidden" runat="server" id="hdnretro2" />
        <input type="hidden" runat="server" id="hdnretro3" />
        <input type="hidden" runat="server" id="hdnretro4" />
        <input type="hidden" runat="server" id="hdnretro5" />
        <input type="hidden" runat="server" id="hdnretro6" />
        <input type="hidden" runat="server" id="hdnretro7" />
        <input type="hidden" runat="server" id="hdnretro8" />
        <input type="hidden" runat="server" id="hdnretro9" />
        <input type="hidden" runat="server" id="hdnretro10" />
        <input type="hidden" runat="server" id="hdnr0" />
        <input type="hidden" runat="server" id="hdnr1" />
        <input type="hidden" runat="server" id="hdnr2" />
        <input type="hidden" runat="server" id="hdnr3" />
        <input type="hidden" runat="server" id="hdnr4" />
        <input type="hidden" runat="server" id="hdnr5" />
        <input type="hidden" runat="server" id="hdnr6" />
        <input type="hidden" runat="server" id="hdnr7" />
        <input type="hidden" runat="server" id="hdnr8" />
        <input type="hidden" runat="server" id="hdnr9" />
        <input type="hidden" runat="server" id="hdnr10" />
        <%--Vargas Chart Page Code--%>
        <div style="display: none;">
            <div id="Div1" class="div_header" style="float: left; width: 98%;">
                <div class="d_header_1 h_filters">
                    <span class="filterss">
                        <asp:Label ID="lbusername" ForeColor="White" font-weight="600" font-family="Open Sans"
                            Font-Size="11px" Text="Astrologer Name :" runat="server">
                        </asp:Label>
                        <asp:Label ID="astname" ForeColor="White" font-weight="600" font-family="Open Sans"
                            Font-Size="11px" runat="server">
                        </asp:Label>
                    </span><span class="filterss">
                        <asp:Label ID="lblastrologerid" ForeColor="White" font-weight="600" font-family="Open Sans"
                            Font-Size="11px" Text="Astrologer ID :" runat="server">
                        </asp:Label>
                        <asp:Label ID="astid" ForeColor="White" font-weight="600" font-family="Open Sans"
                            Font-Size="11px" runat="server">
                        </asp:Label>
                    </span><span class="filterss">
                        <asp:Label ID="lblclientname" ForeColor="White" font-weight="600" font-family="Open Sans"
                            Font-Size="11px" Text="Client Name :" runat="server">
                        </asp:Label>
                        <asp:Label ID="clientname" ForeColor="White" font-weight="600" font-family="Open Sans"
                            Font-Size="11px" runat="server">
                        </asp:Label>
                    </span><span class="filterss">
                        <asp:Label ID="lblclientid" ForeColor="White" font-weight="600" font-family="Open Sans"
                            Font-Size="11px" Text="Client ID :" runat="server">
                        </asp:Label>
                        <asp:Label ID="clientid" ForeColor="White" font-weight="600" font-family="Open Sans"
                            Font-Size="11px" runat="server"></asp:Label>
                    </span>
                </div>
            </div>
            <div id="whitediv" class="div_curve_vargas">
                <div id="Divgrid1_final" class="divg1homenewpage div-scroll_vargas">
                    <table>
                        <tr>
                            <td runat="server" id="hdsviewgrid_final" style="width: 550px;" align="left"></td>
                        </tr>
                    </table>
                </div>
                <div class="divg1_vargas">
                    <asp:Label ID="label11_final" font-weight="600" font-family="Open Sans" Font-Size="11px"
                        ForeColor="Black" runat="server" Text="Chart"></asp:Label>
                    <asp:DropDownList ID="chart_final" runat="server" CssClass="drpo_homenew">
                    </asp:DropDownList>
                    <asp:Label ID="label6_final" font-weight="600" font-family="Open Sans" Font-Size="11px"
                        ForeColor="Black" runat="server" Text="D.O.B \ D.O.Q" Style="display: none;"></asp:Label>
                    <asp:TextBox ID="dasha_final" runat="server" CssClass="drpo_homenew" Style="display: none;"></asp:TextBox>
                    <asp:Label ID="label7_final" font-weight="600" font-family="Open Sans" Font-Size="11px"
                        ForeColor="Black" runat="server" Text="Yogas" Style="display: none;"></asp:Label>
                    <asp:DropDownList ID="dropyogas_final" runat="server" Style="display: none;" CssClass="drpo_homenew_new">
                    </asp:DropDownList>
                    <asp:Label ID="label2_final" font-weight="600" font-family="Open Sans" Font-Size="11px"
                        ForeColor="Black" runat="server" Text="Planet" Style="display: none;"></asp:Label>
                    <asp:TextBox ID="planet_final" runat="server" Style="display: none;" CssClass="drpo_homenew_new"></asp:TextBox>
                </div>
                <div class="buttondiv">
                    <div id="d3" runat="server" style="width: 559px; float: left; display: none;">
                        <asp:LinkButton ID="yogasbutton" runat="server" Style="width: 165px; height: 20px;"
                            class="per_btn_vargas">Calculate Horary Yogas</asp:LinkButton>
                        <asp:LinkButton ID="horarycombina" runat="server" Style="width: 165px; height: 20px;"
                            class="per_btn_vargas">Horary Combination</asp:LinkButton>
                    </div>
                    <div id="De" runat="server" style="text-align: center; margin-left: 50px;">
                        <asp:LinkButton ID="ImageButton1" runat="server" Style="width: 100px;" class="per_btn_vargas">Vargas Chart</asp:LinkButton>
                        <asp:LinkButton ID="ImageButton2" runat="server" Style="width: 100px;" class="per_btn_vargas">Save</asp:LinkButton>
                    </div>
                    <div id="d2" runat="server" style="display: none;">
                        <asp:LinkButton ID="ImageButton4" runat="server" Style="width: 100px;" class="per_btn_vargas">Remedials</asp:LinkButton>
                        <asp:LinkButton ID="D01" runat="server" Style="width: 100px;" class="per_btn_vargas">Show Predictive</asp:LinkButton>
                        <asp:LinkButton ID="yoga" runat="server" Style="width: 100px;" class="per_btn_vargas">Natal Yogas</asp:LinkButton>
                        <asp:LinkButton ID="astrocalc" runat="server" Style="width: 100px;" class="per_btn_vargas">Astro Cals</asp:LinkButton>
                    </div>
                </div>
            </div>
            <div id="clinetnamediv_final" runat="server" class="div_name_id_div">
                <div style="margin-left: 5px;">
                    <asp:Button ID="cross_final" runat="server" Text="X" CssClass="vargas_1" />
                </div>
                <asp:Label ID="Label12_final" ForeColor="Black" Text="Group Category" runat="server"
                    Style="margin-left: 35px;"></asp:Label>
                <div style="margin-left: 35px;">
                    <asp:DropDownList ID="cat_grp" runat="server" CssClass="drpo_homenew">
                        <asp:ListItem>Select Category</asp:ListItem>
                        <asp:ListItem>Natal</asp:ListItem>
                        <asp:ListItem>Horary</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <asp:Label ID="Label10_final" ForeColor="Black" Text="Enter group" runat="server"
                    Style="margin-left: 35px;"></asp:Label>
                <div style="margin-left: 35px;">
                    <asp:DropDownList ID="groupdrop_final" runat="server" CssClass="drpo_homenew">
                    </asp:DropDownList>
                </div>
                <div style="margin-left: 35px;">
                    <asp:Label ID="Label8_final" ForeColor="Black" Text="Enter Client ID" runat="server"></asp:Label>
                    <asp:TextBox ID="clientidtextbox" runat="server"></asp:TextBox>
                </div>
                <div class="vargas_2" style="margin-left: 35px;">
                    <asp:Label ID="Label9_final" ForeColor="Black" Text="Enter Client Name" runat="server"></asp:Label>
                    <asp:TextBox ID="clientnametextbox" runat="server"></asp:TextBox>
                </div>
                <div class="vargas_3" style="margin-left: 35px;">
                    <asp:LinkButton ID="cliidname" runat="server" Style="margin-left: 35px;" class="per_btn_vargas">Save</asp:LinkButton>
                </div>
            </div>
            <div class="mar_div_chart">
                <div>
                    <div style="float: left; width: 50%;">
                        <asp:Label ID="Label1d01" runat="server" ForeColor="Black" CssClass="varga_lbl">
                        </asp:Label>
                    </div>
                    <div class="columnd01" id="rashiidd01">
                        <div class="column-div1">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h1l1d01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divr1">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h1rd01" runat="server" Text="">
                                </asp:Label></span>
                        </div>
                        <div class="column-div2">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h2l1d01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divr2">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h2rd01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-div3">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h3l1d01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divr3">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h3rd01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-div4">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h4l1d01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divr4">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h4rd01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-div5">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h5l1d01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divr5">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h5rd01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-div6">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h6l1d01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divr6">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h6rd01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-div7">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h7l1d01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divr7">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h7rd01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-div8">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h8l1d01" runat="server" Text="">
                                </asp:Label></span>
                        </div>
                        <div class="column-divr8">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h8rd01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-div9">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h9l1d01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divr9">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h9rd01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-div10">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h10l1d01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divr10">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h10rd01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-div11">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h11l1d01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divr11">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h11rd01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-div12">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h12l1d01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divr12">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h12rd01" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <figure class="fixedratio"></figure>
                    </div>
                </div>
                <div class="sec_varga">
                    <div style="float: left;">
                        <asp:Label ID="Label1_final" runat="server" ForeColor="Black" CssClass="varga_lbl">
                        </asp:Label>
                    </div>
                    <div class="column" id="rashiid_final">
                        <div class="column-div1">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h1l1_final" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divrv1">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h1r_final" runat="server" Text="">
                                </asp:Label></span>
                        </div>
                        <div class="column-div2">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h2l1_final" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divrv2">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h2r_final" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-div3">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h3l1_final" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divrv3">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h3r_final" runat="server" Text="">
                                </asp:Label></span>
                        </div>
                        <div class="column-div4">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h4l1_final" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divrv4">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h4r_final" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-div5">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h5l1_final" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divrv5">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h5r_final" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-div6">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h6l1_final" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divrv6">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h6r_final" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-div7">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h7l1_final" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divrv7">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h7r_final" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-div8">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h8l1_final" runat="server" Text="">
                                </asp:Label></span>
                        </div>
                        <div class="column-divrv8">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h8r_final" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-div9">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h9l1_final" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divrv9">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h9r_final" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-div10">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h10l1_final" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divrv10">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h10r_final" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-div11">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h11l1_final" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divrv11">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h11r_final" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-div12">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h12l1_final" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <div class="column-divrv12">
                            <span style="font-size: 11px;">
                                <asp:Label ID="h12r_final" runat="server" Text="">
                                </asp:Label>
                            </span>
                        </div>
                        <figure class="fixedratio"></figure>
                    </div>
                </div>
            </div>
        </div>
        <input type="hidden" runat="server" id="Hiddencons" />
        <input type="hidden" runat="server" id="Hidden1" />
        <input type="hidden" runat="server" id="Hidden5" />
        <input type="hidden" runat="server" id="Hidden2" />
        <input type="hidden" runat="server" id="Hidden3" />
        <input type="hidden" runat="server" id="Hidden5d01" />
        <input type="hidden" runat="server" id="hdncountry" />
        <input type="hidden" runat="server" id="hdnsex" />
        <input type="hidden" runat="server" id="hdnmobile" />
        <input type="hidden" runat="server" id="hdnlongit" />
        <input type="hidden" runat="server" id="hdnlatit" />
        <input type="hidden" runat="server" id="hddayofbirth" />
        <input type="hidden" runat="server" id="hdrashi" />
        <input type="hidden" runat="server" id="hdconstellation" />
        <input type="hidden" runat="server" id="hdndayduration" />
        <input type="hidden" runat="server" id="hdnnightduration" />
        <input type="hidden" runat="server" id="hdnbalancedasha" />
        <input type="hidden" runat="server" id="CVal" />
        <input type="hidden" runat="server" id="BalanceDashaVal" />
        <input type="hidden" runat="server" id="hdnclientemailid" />
        <input type="hidden" runat="server" id="hdncartid" />
        <input type="hidden" runat="server" id="Hs" />
        <input type="hidden" runat="server" id="Hm" />
        <input type="hidden" runat="server" id="Hv" />
        <input type="hidden" runat="server" id="hdncountrycode" />
    </form>
</body>
</html>
