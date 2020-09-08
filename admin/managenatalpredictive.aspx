<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="managenatalpredictive.aspx.cs" Inherits="admin_managenatalpredictive" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="<%=ResolveUrl("~/js/ApproveTestimonials.js") %>"></script>
    <%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
    <style>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="right_col" role="main">
        <div class="">
            <div class="page-title">
                <div class="title_left">
                    <h3 id="h3headertest" runat="server"></h3>
                    <p runat="server"></p>
                    <p runat="server"></p>
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
                <div class="col-md-12">
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
                                <asp:Label runat="server" Visible="false" ID="lblID"></asp:Label>
                                <div class="col-md-8">
                                    <div class="col-md-3 col-sm-3 form-group has-feedback">
                                        <label style="font-size: 14px; color: #555; font-weight: bold;">Predictive Type:</label>
                                        <asp:DropDownList runat="server" ID="ddlpredictivetype" CssClass="form-control">
                                            <asp:ListItem Value="0" Text="--Select--"></asp:ListItem>
                                            <asp:ListItem Value="P" Text="POSITIVE"></asp:ListItem>
                                            <asp:ListItem Value="N" Text="NEGATIVE"></asp:ListItem>
                                            <asp:ListItem Value="R" Text="REMEDIAL"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-md-3 col-sm-3 form-group has-feedback">
                                        <label style="font-size: 14px; color: #555; font-weight: bold;">Status:</label>
                                        <asp:DropDownList runat="server" ID="ddlstatus" CssClass="form-control">
                                            <asp:ListItem Value="" Text="--Select--"></asp:ListItem>
                                            <asp:ListItem Value="A" Text="Show"></asp:ListItem>
                                            <asp:ListItem Value="U" Text="Hide"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-md-3 col-sm-3 form-group has-feedback">
                                        <label style="font-size: 14px; color: #555; font-weight: bold;">Checked:</label>
                                        <asp:DropDownList runat="server" ID="ddlchecked" CssClass="form-control">
                                            <asp:ListItem Value="" Text="--Select--"></asp:ListItem>
                                            <asp:ListItem Value="T" Text="Checked"></asp:ListItem>
                                            <asp:ListItem Value="F" Text="Unchecked"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-md-3 col-sm-3 form-group has-feedback">
                                        <label style="font-size: 14px; color: #555; font-weight: bold;">Priority</label>
                                        <asp:DropDownList runat="server" ID="ddlPriority" CssClass="form-control">
                                            <asp:ListItem Value="0" Text="--Priority--"></asp:ListItem>
                                            <asp:ListItem Value="0" Text="0"></asp:ListItem>
                                            <asp:ListItem Value="1" Text="1"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="2"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="3"></asp:ListItem>
                                            <asp:ListItem Value="4" Text="4"></asp:ListItem>
                                            <asp:ListItem Value="5" Text="5"></asp:ListItem>
                                            <asp:ListItem Value="6" Text="6"></asp:ListItem>
                                            <asp:ListItem Value="7" Text="7"></asp:ListItem>
                                            <asp:ListItem Value="8" Text="8"></asp:ListItem>
                                            <asp:ListItem Value="9" Text="9"></asp:ListItem>
                                            <asp:ListItem Value="10" Text="10"></asp:ListItem>
                                            <asp:ListItem Value="11" Text="11"></asp:ListItem>
                                            <asp:ListItem Value="12" Text="12"></asp:ListItem>
                                            <asp:ListItem Value="13" Text="13"></asp:ListItem>
                                            <asp:ListItem Value="14" Text="14"></asp:ListItem>
                                            <asp:ListItem Value="15" Text="15"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-md-3 col-sm-3 form-group has-feedback">
                                        <label style="font-size: 14px; color: #555; font-weight: bold;">Unique ID</label>
                                        <asp:TextBox runat="server" ID="txtUniqueID" CssClass="form-control">  </asp:TextBox>
                                    </div>
                                    <div class="col-md-9 col-sm-9 form-group has-feedback">
                                        <label style="font-size: 14px; color: #555; font-weight: bold;" class="required">Logic</label>
                                        <asp:DropDownList runat="server" ID="ddlLogic" CssClass="form-control">
                                            <asp:ListItem Value="-1" Selected="True">Select Logic</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="reqLogic" runat="server" ControlToValidate="ddlLogic" CssClass="validator" Display="Dynamic"
                                            ErrorMessage="Enter Logic" SetFocusOnError="True" InitialValue="-1" ValidationGroup="save"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="col-md-12 form-group has-feedback">
                                        <label style="font-size: 14px; color: #555; font-weight: bold;">Predictive:</label>
                                        <FCKeditorV2:FCKeditor ID="rtepredictivenew" runat="server" BasePath="~/fckeditor/" Height="400"></FCKeditorV2:FCKeditor>
                                    </div>
                                    <div class="col-md-12 form-group has-feedback">
                                        <label style="font-size: 14px; color: #555; font-weight: bold;">Remedial:</label>
                                        <FCKeditorV2:FCKeditor ID="rteremedialnew" runat="server" BasePath="~/fckeditor/" Height="300"></FCKeditorV2:FCKeditor>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="x_content">
                                        <div class="table-responsive">
                                            <asp:GridView ID="grdData" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                                PageSize="50" HeaderStyle-BackColor="#f25e0a" HeaderStyle-ForeColor="White" AlternatingRowStyle-BackColor="#dddddd" 
                                                RowStyle-ForeColor="Black" Width="100%">
                                                <AlternatingRowStyle CssClass="even" />
                                                <Columns>
                                                    <asp:TemplateField>
                                                        <HeaderStyle VerticalAlign="Middle" HorizontalAlign="Center" Width="25px" CssClass="column-title"></HeaderStyle>
                                                        <ItemStyle VerticalAlign="Middle" HorizontalAlign="Center"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:CheckBox ID="chkrow" runat="server" onclick="javascript: HighlightRow(this)" AutoPostBack="false" />
                                                        </ItemTemplate>
                                                        <HeaderTemplate>
                                                            <input type="checkbox" id="chkallrow" onclick="javascript: CheckAllRows(this)" />
                                                        </HeaderTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="CAT_ID" Visible="true">
                                                        <ItemStyle VerticalAlign="top" HorizontalAlign="Center"></ItemStyle>
                                                        <HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblCATEGORYID" runat="server" Text='<%# Bind("CATEGORY_ID")%>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="CATEGORY NAME">
                                                        <ItemStyle Wrap="true" VerticalAlign="top" HorizontalAlign="Left"></ItemStyle>
                                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblCATEGORY_NAME" runat="server" Text='<%# Bind("CATEGORY_NAME")%>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                </Columns>
                                                <EmptyDataTemplate>
                                                    No record to display...
                                                </EmptyDataTemplate>
                                                <HeaderStyle HorizontalAlign="Left" />
                                                <PagerStyle CssClass="gridpager" />
                                                <RowStyle CssClass="odd" />
                                            </asp:GridView>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-12">
                                    <div class="form-group row">
                                        <div class="col-md-9 col-sm-9 offset-md-3">
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
    </div>
</asp:Content>




