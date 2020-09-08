<%@ Page Title="Write Experience | Astro Envision" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="ManageTestiMonials.aspx.cs" Inherits="ManageTestiMonials" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function onFileSelected(event) {
            var selectedFile = event.target.files[0];
            if (selectedFile != "" || selectedFile != null) {
                $("#ctl00_ContentPlaceHolder1_imgauthor").show();
                var reader = new FileReader();
                var imgtag = document.getElementById("ctl00_ContentPlaceHolder1_imgauthor");
                imgtag.title = selectedFile.name;
                reader.onload = function (event) {
                    imgtag.src = event.target.result;
                };
                reader.readAsDataURL(selectedFile);
            }
            else {
                $("#ctl00_ContentPlaceHolder1_imgauthor").hide();
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:UpdatePanel ID="upMain" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <section class="srvc-sec">
                <div class="container">
                    <div class="row justify-content-center">
                        <div class="col-sm-6">
                            <div class="accntsec">
                                <header class="section-header">
                                    <h1>Write Your Experience About <br /> Astrologer Hari Sharma</h1>
                                </header>
                                <div class="form-group">
                                    <label class="required">Your Name</label>
                                    <asp:TextBox ID="txtName" runat="server" CssClass="form-control form-control-lg" placeholder="Name"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqName" runat="server" ControlToValidate="txtName" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Name" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group">
                                    <label class="required">Write Your Experience</label>
                                    <asp:TextBox ID="txtTestimonials" runat="server" CssClass="form-control form-control-lg" TextMode="MultiLine" Rows="5"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqTestimonials" runat="server" ControlToValidate="txtTestimonials" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Write Your Experience" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group">
                                    <label>Kindly Upload Your Photo</label>
                                    <br>
                                    <asp:Image ID="imgauthor" runat="server" Height="100px" alt="Author Image" Title="Author Image" ImageUrl="" Width="150px" BorderWidth="1px" Style="display: none"></asp:Image>
                                    <asp:FileUpload ID="fuPhoto" runat="server" class="form-control form-control-lg" onchange="onFileSelected(event)" />
                                </div>
                                <div class="form-group">
                                    <label><a href="<%=ResolveUrl("~/astrology/testimonials.html") %>" target="_blank" title="Astro Envision Testimonials">Kindly Read Other Testimonials</a></label>
                                    </div>
                                <div class="mt-1 text-center">
                                    <asp:LinkButton ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-primary btn-block btn-lg" ValidationGroup="save" OnClick="btnSubmit_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="btnSubmit" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>

