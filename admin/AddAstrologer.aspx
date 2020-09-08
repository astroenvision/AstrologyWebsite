<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="AddAstrologer.aspx.cs" Inherits="admin_AddAstrologer" EnableEventValidation="false" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript" src="<%=ResolveUrl("~/admin/Admin.js") %> "></script>
    <style>
        .prof-img-custom {
            position: relative;
        }

        .prof-img-inner-custom {
            width: 132px;
            height: 132px;
            position: relative;
            /*box-shadow: 0 0 2px #ddd;*/
            margin: auto;
        }

            .prof-img-inner-custom img {
                width: 132px;
                height: 132px;
            }

        .photoUpload-custom {
            overflow: hidden;
            padding: 3px 5px;
            cursor: pointer;
            position: absolute;
            width: 100%;
            bottom: 0;
            background: rgba(0, 0, 0, 0.5);
            text-align: center;
        }

            .photoUpload-custom span {
                color: #fff;
                position: relative;
                top: 2px;
            }

            .photoUpload-custom input.uploadpic {
                position: absolute;
                top: 0;
                right: 0;
                margin: 0;
                padding: 0;
                cursor: pointer;
                opacity: 0;
                width: 100%;
                filter: alpha(opacity=0);
            }

        .required {
            position: relative;
        }

            .required:after {
                position: absolute;
                content: '*';
                color: #ff0000;
                right: -10px;
            }
    </style>
    <script type="text/javascript">
        $(function () {
            $('#profile-image1').on('click', function () {
                $('#profile-image-upload').click();
            });
        });
        function showpreview(input) {
            var ext = $('#ctl00_ContentPlaceHolder1_FileUserPhoto').val().split('.').pop().toLowerCase();
            if ($.inArray(ext, ['png', 'jpg', 'jpeg']) == -1) {
                alert('You can upload only jpg , jpeg , png extensions files.');
                $('#ctl00_ContentPlaceHolder1_FileUserPhoto').val('');
            }
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#ctl00_ContentPlaceHolder1_imgpreview').css('visibility', 'visible');
                    $('#ctl00_ContentPlaceHolder1_imgpreview').attr('src', e.target.result);
                }
                reader.readAsDataURL(input.files[0]);
            }
        }

    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="right_col" role="main">
        <div class="">
            <div class="page-title">
                <div class="title_left">
                    <h3 id="h3headertest" runat="server"></h3>
                </div>
                <div class="title_right" runat="server" visible="false">
                    <div class="col-md-5 col-sm-5  form-group pull-right top_search">
                        <div class="input-group">
                            <input type="text" class="form-control" placeholder="Search for...">
                            <span class="input-group-btn">
                                <button class="btn btn-default" type="button">Go!</button>
                            </span>
                        </div>
                    </div>
                </div>
            </div>
            <div class="clearfix"></div>
            <div class="row">
                <div class="col-md-12 ">
                    <div class="x_panel">
                        <div class="x_title">
                            <ul class="nav navbar-right panel_toolbox">
                                <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                                </li>
                                <li><a class="close-link"><i class="fa fa-close"></i></a>
                                </li>
                            </ul>
                            <div class="clearfix"></div>
                        </div>
                        <div class="x_content">
                            <div class="form-label-left input_mask">
                                <div class="form-group" id="div1" runat="server">
                                    <div class="col-md-3 prof-img-custom">
                                        <div class="prof-img-inner-custom">
                                            <img id="imgpreview" runat="server" src="../Image/avatar.png" class="userPro" />
                                            <asp:HiddenField ID="hdnAstrologerImage" runat="server" />
                                            <div class="photoUpload-custom">
                                                <span><i class="icon-cloud-upload mg-r-5"></i>Upload Photo</span>
                                                <asp:UpdatePanel ID="upPhotograph" runat="server" UpdateMode="Conditional">
                                                    <ContentTemplate>
                                                        <asp:FileUpload ID="FileUserPhoto" runat="server" CssClass="uploadpic" onchange="showpreview(this);" />
                                                    </ContentTemplate>
                                                    <Triggers>
                                                        <asp:PostBackTrigger ControlID="btnUpdate" />
                                                    </Triggers>
                                                </asp:UpdatePanel>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-3 col-sm-6 form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Astrologer Name</label>
                                    <asp:Label ID="lblAstrologerID" runat="server" Visible="false"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtName" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqUserID" runat="server" ControlToValidate="txtName" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter User Name" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div id="dvLoaderConnnetion" runat="server" style="display: none"></div>
                                <div class="col-md-3 col-sm-6 form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Gender</label>
                                    <asp:DropDownList runat="server" ID="ddlGender" CssClass="form-control">
                                        <asp:ListItem Value="-1">Select Gender</asp:ListItem>
                                        <asp:ListItem Value="M">Male</asp:ListItem>
                                        <asp:ListItem Value="F">Female</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="reqGender" runat="server" ControlToValidate="ddlGender" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Select Gender" InitialValue="-1" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-3 col-sm-6 form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Email Id</label>
                                    <asp:TextBox runat="server" ID="txtEmailID" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmailID" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Email ID" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="regEmail" runat="server" ErrorMessage="Enter Valid Email"
                                        ControlToValidate="txtEmailID" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" CssClass="validator" Display="Dynamic" ValidationGroup="save" />
                                </div>
                                <div class="col-md-3 col-sm-6 form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Login Id</label>
                                    <asp:TextBox runat="server" ID="txtLoginID" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLoginID" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Login ID" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-3 col-sm-6 form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Password</label>
                                    <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPassword" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Password" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-3 col-sm-6 form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Mobile No</label>
                                    <asp:TextBox runat="server" ID="txtPhoneNo" CssClass="form-control" MaxLength="10"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPhoneNo" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Phone No" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="regContact" runat="server" ErrorMessage="Enter Valid No"
                                        ControlToValidate="txtPhoneNo" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" CssClass="validator" Display="Dynamic" ValidationGroup="save" />
                                </div>
                                <div class="col-md-3 col-sm-6 form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Alternate Mobile No</label>
                                    <asp:TextBox runat="server" ID="txtAlternateNo" CssClass="form-control" MaxLength="10"></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="regAlternateNo" runat="server" ErrorMessage="Enter Valid No"
                                        ControlToValidate="txtAlternateNo" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$" CssClass="validator" Display="Dynamic" ValidationGroup="save" />
                                </div>
                                <div class="col-md-5 col-sm-6 form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Experience in Astrology (In Years)</label>
                                    <asp:TextBox runat="server" ID="txtExperience" CssClass="form-control"></asp:TextBox>
                                    <%--<asp:RegularExpressionValidator ID="reqExperience" CssClass="validator" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtExperience" runat="server"
                                        ErrorMessage="Only Numbers allowed" ValidationGroup="save" ValidationExpression="\d+"></asp:RegularExpressionValidator>--%>
                                </div>
                                <div class="col-md-4 col-sm-6 form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Qualification</label>
                                    <asp:TextBox runat="server" ID="txtEducation" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqEducation" runat="server" ControlToValidate="txtEducation" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Education" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-7 col-sm-6 form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Expertise in</label>
                                    <asp:TextBox runat="server" ID="txtExpertIn" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="col-md-5 col-sm-6 form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Language spoken</label>
                                    <asp:TextBox ID="txtSpeakInLanguage" runat="server" CssClass="form-control"></asp:TextBox>
                                    <%--<asp:RequiredFieldValidator ID="reqSpeakInLanguage" runat="server" ControlToValidate="txtSpeakInLanguage" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Languages" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>--%>
                                </div>
                                <div class="col-md-3 col-sm-6 form-group has-feedback" runat="server" visible="false">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Group Name</label>
                                    <asp:DropDownList runat="server" CssClass="form-control" ID="ddlGroup">
                                        <asp:ListItem Value="-1" Text="Select Group"></asp:ListItem>
                                        <asp:ListItem Value="NATAL" Text="NATAL"></asp:ListItem>
                                        <asp:ListItem Value="HORARY" Text="HORARY"></asp:ListItem>
                                    </asp:DropDownList>
                                   <%-- <asp:RequiredFieldValidator ID="reqGroup" runat="server" ControlToValidate="ddlGroup" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Select Group Name" SetFocusOnError="True" InitialValue="-1" ValidationGroup="save"></asp:RequiredFieldValidator>--%>
                                </div>
                                <div class="col-md-6 col-sm-6 form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Achievements</label>
                                    <asp:TextBox runat="server" ID="txtAchievements" TextMode="MultiLine" Rows="3" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="col-md-6 col-sm-6 form-group has-feedback" runat="server" visible="false">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Small Description</label>
                                    <asp:TextBox runat="server" ID="txtSmallDesc" TextMode="MultiLine" Rows="3" CssClass="form-control"></asp:TextBox>
                                   <%-- <asp:RequiredFieldValidator ID="reqSmallDesc" runat="server" ControlToValidate="txtSmallDesc" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Small Description" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>--%>
                                </div>
                                <div class="col-md-6 col-sm-6 form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">About Astrologer</label>
                                    <asp:TextBox runat="server" ID="txtFullDesc" TextMode="MultiLine" Rows="3" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqFullDesc" runat="server" ControlToValidate="txtFullDesc" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter About Astrologer" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-12 col-sm-6 form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Address</label>
                                    <asp:TextBox runat="server" ID="txtAddress" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqAddress" runat="server" ControlToValidate="txtAddress" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Address" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-3 col-sm-6 form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">Country</label>
                                    <asp:DropDownList runat="server" ID="ddlCountry" CssClass="form-control" Onchange="ddlCountryChange();"></asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="reqCountry" runat="server" ControlToValidate="ddlCountry" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Select Country" InitialValue="-1" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-3 col-sm-6 form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">State</label>
                                    <asp:DropDownList runat="server" ID="ddlState" CssClass="form-control" Onchange="ddlStateChange();"></asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="reqState" runat="server" ControlToValidate="ddlState" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Select State" InitialValue="-1" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-3 col-sm-6 form-group has-feedback">
                                    <label class="required" style="font-size: 14px; color: #555; font-weight: bold;">City</label>
                                    <asp:DropDownList runat="server" ID="ddlCity" CssClass="form-control " Onchange="ddlCityChange();"></asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="reqCity" runat="server" ControlToValidate="ddlCity" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Select City" InitialValue="-1" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-3 col-sm-6 form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Zip Code</label>
                                    <asp:TextBox runat="server" ID="txtZipCode" CssClass="form-control" MaxLength="6"></asp:TextBox>
                                  <%--  <asp:RequiredFieldValidator ID="reqZipCode" runat="server" ControlToValidate="txtZipCode" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Zip Code" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="regZipCode" CssClass="validator" ValidationGroup="save" Display="Dynamic" SetFocusOnError="True" ControlToValidate="txtZipCode" runat="server" ErrorMessage="Only Numbers allowed"
                                        ValidationExpression="\d+"></asp:RegularExpressionValidator>--%>
                                </div>
                                <div class="col-md-3 col-sm-6 form-group has-feedback" runat="server" visible="false">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Rating</label>
                                    <asp:TextBox runat="server" ID="txtRating" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="form-group row">
                                    <div class="col-md-9 col-sm-9" style="margin-top: 31px;">
                                        <asp:CheckBox runat="server" ID="chkStatus" Text="Active" Style="margin-left: 10px; font-size: 14px; color: #555; font-weight: bold;"></asp:CheckBox>
                                        <asp:CheckBox runat="server" ID="chkAvailable" Text="Currently Available" Style="margin-left: 10px; font-size: 14px; color: #555; font-weight: bold;"></asp:CheckBox>
                                    </div>
                                    <div class="col-md-9 col-sm-9  offset-md-3">
                                        <asp:LinkButton ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-success" ValidationGroup="save" OnClick="btnUpdate_Click" />
                                        <asp:LinkButton ID="lnkbutton" runat="server" Text="Close" CssClass="btn btn-secondary" OnClientClick="javascript:window.close();" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <asp:HiddenField ID="hdnCountry" runat="server" />
    <asp:HiddenField ID="hdnCity" runat="server" />
    <asp:HiddenField ID="hdnState" runat="server" />
</asp:Content>

