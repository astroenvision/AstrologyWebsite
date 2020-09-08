<%@ Page Title="" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="details.aspx.cs" Inherits="article_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler);
        function EndRequestHandler(sender, args) {
            if (args.get_error() != undefined) {
                args.set_errorHandled(true);
            }
        }
    </script>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <div class="container-sec">
             <div style="clear: both;"></div>
            <div class="content-center">
                <div class="col-sm-12">
                    <h1 class="fullarticle_catname">Consult An Astrologer</h1>
                    <div style="clear: both;"></div>
                    <div class="fullarticle" id="details_id" runat="server"></div>
                    <label class="tnc-ttl">Select Any Service</label>
                    <asp:RadioButtonList ID="radServiceType" runat="server" CssClass="rdolvfor" RepeatDirection="Horizontal">
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="reqLeavefor" runat="server"
                        ControlToValidate="radServiceType" CssClass="validator" Display="Dynamic"
                        ErrorMessage="Select Any Service" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                    <div class="note">
                        <p>
                            For Personal appointment/Telephonic/Skype Consultancy please call on <b>9555600111 / 9555700111</b>
                            Or write an email on <b><a href="mailto:sales@astroenvision.com">sales@astroenvision.com</a></b>.
                        </p>
                    </div>
                    <div style="float: left; margin: 2em 0em 1em 0em; padding: 0em; text-align: center; width: 100%; height: 30px;">
                        <asp:LinkButton ID="lnkSubmit" runat="server" OnClick="linkbtnproceed_Click" CssClass="kwm-btn-lg" Text="Proceed" Width="120" ValidationGroup="save"></asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

