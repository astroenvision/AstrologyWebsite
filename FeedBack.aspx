<%@ Page Title="" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="FeedBack.aspx.cs" Inherits="FeedBack" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <meta name="description" content="Give your feedback about astroenvision website." />
    <meta name="keywords" content="feedback, give your feedback, write your feedback, site feedback, astroenvision feedback" />
    <script>
       function countChar() {
            try {
                var length = $('#ctl00_ContentPlaceHolder1_txtMessage').val().length;
                $("#lblMessage").text('');
                $("#lblMessage").text('Total Character-' + length);
            }
            catch (ex) {
                alert(ex);
                return false;
            }
        }
        function isokmaxlength(e, val, maxlengt) {
            var charCode = (typeof e.which == "number") ? e.which : e.keyCode
            if (!(charCode == 44 || charCode == 46 || charCode == 0 || charCode == 8 || (val.value.length < maxlengt))) {
                return false;
            }
        }
        function limitnofotext(reftxt, charlength) {
            if (reftxt.value.length > charlength) {
                reftxt.value = reftxt.value.substring(0, charlength);
                var str = reftxt.value.substr(0, 500);
                $('#ctl00_ContentPlaceHolder1_txtMessage').val(str);
                $("#lblMessage").text('');
                $("#lblMessage").text('Total Character-' + str.length);
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="srvc-sec">
        <div class="container">
            <h1 class="fullarticle_catname">Feedback</h1>
            <div class="row justify-content-center">
                <div class="col-sm-6">
                    <div class="accntsec">
                        <header class="section-header">
                            <h3>Give Your Feedback</h3>
                        </header>
                        <div class="form-group">
                            <label class="required">Name</label>
                            <asp:TextBox ID="txtName" runat="server" MaxLength="30" CssClass="form-control form-control-lg" placeholder="Name"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqName" runat="server" ControlToValidate="txtName" CssClass="validator" Display="Dynamic"
                                ErrorMessage="Enter Name" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label class="required">Email ID</label>
                            <asp:TextBox ID="txtEmail" runat="server" MaxLength="30" CssClass="form-control form-control-lg" placeholder="Email ID"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqEmail" runat="server" ControlToValidate="txtEmail" CssClass="validator" Display="Dynamic"
                                ErrorMessage="Enter Email" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="regEmail" runat="server" ErrorMessage="Enter Valid Email"
                                ControlToValidate="txtEmail" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" CssClass="validator" Display="Dynamic" ValidationGroup="save" />
                        </div>
                       <div class="form-group">
                            <label class="required">Contact No</label>
                            <asp:TextBox ID="txtContcatNo" runat="server" CssClass="form-control form-control-lg" placeholder="Contact No" MaxLength="13"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqContactNo" runat="server" ControlToValidate="txtContcatNo" CssClass="validator" Display="Dynamic"
                                ErrorMessage="Enter Contact No" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="regContact" runat="server" ErrorMessage="Enter Valid Contact No"
                                ControlToValidate="txtContcatNo" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" CssClass="validator" Display="Dynamic" ValidationGroup="save" />
                        </div>
                        <div class="form-group">
                            <label class="required">Message</label>
                            <asp:TextBox ID="txtMessage" runat="server" onblur="limitnofotext(this,500)" MaxLength="500" onkeypress="return isokmaxlength(event,this,500);" onkeyup="countChar();" CssClass="form-control form-control-lg" placeholder="Message" TextMode="MultiLine" Rows="4"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqMessage" runat="server" ControlToValidate="txtMessage" CssClass="validator" Display="Dynamic"
                                ErrorMessage="Enter Message" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                            <label id="lblMessage"></label>
                        </div>
                        <div class="mt-4 text-center">
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-primary btn-block btn-lg" ValidationGroup="save" OnClick="btnsubmit_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

