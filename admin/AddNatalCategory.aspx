<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="AddNatalCategory.aspx.cs" Inherits="admin_AddNatalCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
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
        <div class="page-title">
            <div class="title_left">
                <h3>Save Category</h3>
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
                                <div class="prof-img-custom">
                                    <div class="prof-img-inner-custom">
                                        <img id="imgpreview" runat="server" src="../../content/images/avatar.jpg" class="userPro" />
                                        <asp:HiddenField ID="hdnCatImage" runat="server" />
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
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Category Name</label>
                                <asp:Label ID="lblID" runat="server" Visible="false"></asp:Label>
                                <asp:TextBox runat="server" ID="txtCatName" CssClass="form-control" placeholder="Name"></asp:TextBox>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Priority</label>
                                <asp:DropDownList runat="server" ID="ddlPriority" CssClass="form-control">
                                    <asp:ListItem Value="0">Select Priority</asp:ListItem>
                                    <asp:ListItem Value="0">0</asp:ListItem>
                                    <asp:ListItem Value="1">1</asp:ListItem>
                                    <asp:ListItem Value="2">2</asp:ListItem>
                                    <asp:ListItem Value="3">3</asp:ListItem>
                                    <asp:ListItem Value="4">4</asp:ListItem>
                                    <asp:ListItem Value="5">5</asp:ListItem>
                                    <asp:ListItem Value="6">6</asp:ListItem>
                                    <asp:ListItem Value="7">7</asp:ListItem>
                                    <asp:ListItem Value="8">8</asp:ListItem>
                                    <asp:ListItem Value="9">9</asp:ListItem>
                                    <asp:ListItem Value="10">10</asp:ListItem>
                                    <asp:ListItem Value="11">11</asp:ListItem>
                                    <asp:ListItem Value="12">12</asp:ListItem>
                                    <asp:ListItem Value="13">13</asp:ListItem>
                                    <asp:ListItem Value="14">14</asp:ListItem>
                                    <asp:ListItem Value="15">15</asp:ListItem>
                                    <asp:ListItem Value="16">16</asp:ListItem>
                                    <asp:ListItem Value="17">17</asp:ListItem>
                                    <asp:ListItem Value="18">18</asp:ListItem>
                                    <asp:ListItem Value="19">19</asp:ListItem>
                                    <asp:ListItem Value="20">20</asp:ListItem>
                                    <asp:ListItem Value="21">21</asp:ListItem>
                                    <asp:ListItem Value="22">22</asp:ListItem>
                                    <asp:ListItem Value="23">23</asp:ListItem>
                                    <asp:ListItem Value="24">24</asp:ListItem>
                                    <asp:ListItem Value="25">25</asp:ListItem>
                                    <asp:ListItem Value="26">26</asp:ListItem>
                                    <asp:ListItem Value="27">27</asp:ListItem>
                                    <asp:ListItem Value="28">28</asp:ListItem>
                                    <asp:ListItem Value="29">29</asp:ListItem>
                                    <asp:ListItem Value="30">30</asp:ListItem>
                                    <asp:ListItem Value="31">31</asp:ListItem>
                                    <asp:ListItem Value="32">32</asp:ListItem>
                                    <asp:ListItem Value="33">33</asp:ListItem>
                                    <asp:ListItem Value="34">34</asp:ListItem>
                                    <asp:ListItem Value="35">35</asp:ListItem>
                                    <asp:ListItem Value="36">36</asp:ListItem>
                                    <asp:ListItem Value="37">37</asp:ListItem>
                                    <asp:ListItem Value="38">38</asp:ListItem>
                                    <asp:ListItem Value="39">39</asp:ListItem>
                                    <asp:ListItem Value="40">40</asp:ListItem>
                                    <asp:ListItem Value="41">41</asp:ListItem>
                                    <asp:ListItem Value="42">42</asp:ListItem>
                                    <asp:ListItem Value="43">43</asp:ListItem>
                                    <asp:ListItem Value="44">44</asp:ListItem>
                                    <asp:ListItem Value="45">45</asp:ListItem>
                                    <asp:ListItem Value="46">46</asp:ListItem>
                                    <asp:ListItem Value="47">47</asp:ListItem>
                                    <asp:ListItem Value="48">48</asp:ListItem>
                                    <asp:ListItem Value="49">49</asp:ListItem>
                                    <asp:ListItem Value="50">50</asp:ListItem>
                                    <asp:ListItem Value="100">100</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Meta Keywords</label>
                                <asp:TextBox runat="server" ID="txtMetaKeyWords" CssClass="form-control" TextMode="MultiLine" Rows="3"></asp:TextBox>
                            </div>
                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Meta Description</label>
                                <asp:TextBox runat="server" ID="txtMetaDesc" CssClass="form-control" TextMode="MultiLine" Rows="3"></asp:TextBox>
                            </div>
                            <div class="col-md-6 col-sm-6 form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Title</label>
                                <asp:TextBox runat="server" ID="txtTitle" CssClass="form-control"></asp:TextBox>
                            </div>
                               
                            <div class="col-md-6 col-sm-6 form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Pre Url</label>
                                <asp:TextBox runat="server" ID="txtPreUrl" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-6 col-sm-6 form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Category Url</label>
                             <asp:TextBox runat="server" ID="txtCategoryURL" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtCategoryURL_TextChanged" ></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqCategoryURL" runat="server" ControlToValidate="txtCategoryURL" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Category URL" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-6 col-sm-6 form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Post Url</label>
                                <asp:TextBox runat="server" ID="txtPostURL" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-12  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Synopsis</label>
                                <FCKeditorV2:FCKeditor ID="rtesynopsis" runat="server" BasePath="~/fckeditor/" Height="300"></FCKeditorV2:FCKeditor>
                            </div>
                            <div class="col-md-12  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Description</label>
                                <FCKeditorV2:FCKeditor ID="rtedetails" runat="server" BasePath="~/fckeditor/" Height="400"></FCKeditorV2:FCKeditor>
                            </div>

                            <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Category Color</label>
                                <input type="color" id="txtColor" runat="server" value="#f25e0a" />
                            </div>
                            <div class="col-md-6 col-sm-6 form-group has-feedback">
                                <asp:CheckBox runat="server" ID="chkIsBlink" Text="&nbsp;Blink" Style="margin-left: 10px; font-size: 14px; color: #555; font-weight: bold;"></asp:CheckBox>
                                 <asp:CheckBox runat="server" ID="chkIsPaid" Text="&nbsp;Is Paid" Style="margin-left: 10px; font-size: 14px; color: #555; font-weight: bold;"></asp:CheckBox>
                                <asp:CheckBox runat="server" ID="chkStatus" Text="&nbsp;Active" Style="font-size: 14px; color: #555; font-weight: bold;"></asp:CheckBox>
                                 <asp:CheckBox runat="server" ID="chkISAddToCart" Text="&nbsp;Is Add To Cart" Style="font-size: 14px; color: #555; font-weight: bold;"></asp:CheckBox>
                            </div>
                           
                            <div class="clearfix"></div>
                            <div class="form-group row">
                                <div class="col-md-9 col-sm-9  offset-md-3">
                                    <asp:LinkButton ID="btnUpdate" runat="server" Text="Save" CssClass="btn btn-success" ValidationGroup="save" OnClick="btnUpdate_Click" />
                                    <asp:LinkButton ID="lnkbutton" runat="server" Text="Close" CssClass="btn btn-secondary" OnClientClick="javascript:window.close();" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>


