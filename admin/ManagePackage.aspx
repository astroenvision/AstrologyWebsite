<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="ManagePackage.aspx.cs" Inherits="admin_ManagePackage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script>
        function WriteUsdDiscount() {
            try {
                var per = $("#ctl00_ContentPlaceHolder1_txtInrDiscount").val();
                $("#ctl00_ContentPlaceHolder1_txtUsdDiscount").val(per);
            }
            catch (ex) {
                alert(ex);
                return false;
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="right_col" role="main">
        <div class="">
            <div class="page-title">
                <div class="title_left">
                    <h3>Manage Package Discount<small></small></h3>
                </div>
                <div class="title_right" runat="server" visible="false">
                    <div class="col-md-5 col-sm-5   form-group pull-right top_search">
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
            <div class="row" style="display: block;">
                <div class="clearfix"></div>
                <div class="col-md-12 col-sm-12  ">
                    <div class="x_panel">
                        <div class="x_title">
                            <div class="col-md-2">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Category From</label>
                                <asp:DropDownList ID="ddlCatFrom" runat="server" CssClass="form-control">
                                    <asp:ListItem Value="-1" Text="Category From"></asp:ListItem>
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
                                    <asp:ListItem Value="16" Text="16"></asp:ListItem>
                                    <asp:ListItem Value="17" Text="17"></asp:ListItem>
                                    <asp:ListItem Value="18" Text="18"></asp:ListItem>
                                    <asp:ListItem Value="19" Text="19"></asp:ListItem>
                                    <asp:ListItem Value="20" Text="20"></asp:ListItem>
                                    <asp:ListItem Value="21" Text="21"></asp:ListItem>
                                    <asp:ListItem Value="22" Text="22"></asp:ListItem>
                                    <asp:ListItem Value="23" Text="23"></asp:ListItem>
                                    <asp:ListItem Value="24" Text="24"></asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="reqCatFrom" runat="server" ControlToValidate="ddlCatFrom" CssClass="validator" Display="Dynamic" InitialValue="-1"
                                    ErrorMessage="Select Category From" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-2">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">Category To</label>
                                <asp:DropDownList ID="ddlCatTO" runat="server" CssClass="form-control">
                                    <asp:ListItem Value="-1" Text="Category To"></asp:ListItem>
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
                                    <asp:ListItem Value="16" Text="16"></asp:ListItem>
                                    <asp:ListItem Value="17" Text="17"></asp:ListItem>
                                    <asp:ListItem Value="18" Text="18"></asp:ListItem>
                                    <asp:ListItem Value="19" Text="19"></asp:ListItem>
                                    <asp:ListItem Value="20" Text="20"></asp:ListItem>
                                    <asp:ListItem Value="21" Text="21"></asp:ListItem>
                                    <asp:ListItem Value="22" Text="22"></asp:ListItem>
                                    <asp:ListItem Value="23" Text="23"></asp:ListItem>
                                    <asp:ListItem Value="24" Text="24"></asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="reqCatTo" runat="server" ControlToValidate="ddlCatTO" CssClass="validator" Display="Dynamic" InitialValue="-1"
                                    ErrorMessage="Select Category To" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-2">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">INR Discount</label>
                                <asp:TextBox ID="txtInrDiscount" runat="server" CssClass="form-control" Onkeyup="WriteUsdDiscount();" onkeypress="return AcceptDecimal(event)"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqInrDiscount" runat="server" ControlToValidate="txtInrDiscount" CssClass="validator" Display="Dynamic" InitialValue="-1"
                                    ErrorMessage="Enter INR Discount" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-2">
                                <label style="font-size: 14px; color: #555; font-weight: bold;">USD Discount</label>
                                <asp:TextBox ID="txtUsdDiscount" runat="server" CssClass="form-control" Onkeyup="WriteUsdDiscount();" onkeypress="return AcceptDecimal(event)"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqUsdDiscount" runat="server" ControlToValidate="txtUsdDiscount" CssClass="validator" Display="Dynamic" InitialValue="-1"
                                    ErrorMessage="Enter USD Discount" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-sm-4" style="margin-top: 25px;">
                                <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-primary" OnClick="btnUpdate_Click" ValidationGroup="save" />
                                <asp:Button ID="Button1" runat="server" Text="Reset" CssClass="btn btn-secondary" OnClick="btnReset_Click" />
                            </div>
                            <div class="clearfix"></div>
                        </div>
                        <div class="x_content">
                            <div class="table-responsive">
                                <asp:GridView ID="grdData" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdData_PageIndexChanging"
                                    CssClass="table table-striped jambo_table bulk_action" HeaderStyle-CssClass="headings" PageSize="50" HeaderStyle-BackColor="#f25e0a" HeaderStyle-ForeColor="White">
                                    <AlternatingRowStyle CssClass="even" />
                                    <Columns>
                                        <asp:TemplateField HeaderText="ID" Visible="false">
                                            <HeaderStyle HorizontalAlign="Left" Width="100px"></HeaderStyle>
                                            <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:Label ID="lblID" Visible="false" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "PACKID").ToString()) %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="PACK_NAME" HeaderText="NO OF CATEGORY" />
                                        <asp:BoundField DataField="DISCOUNT_INR" HeaderText="DIS. PRICE INR" />
                                        <asp:BoundField DataField="DISCOUNT_USD" HeaderText="DIS. PRICE USD" />
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
                </div>
            </div>
        </div>
    </div>
</asp:Content>


