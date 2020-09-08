<%@ Page Title="" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="compatibilitymatchingdetails.aspx.cs" Inherits="compatibilitymatchingdetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript" src="javascript/compatibilitymatchingdetails.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
      <div class="container">
        <div class="container-sec">
            <div style="clear: both;"></div>
            <div class="row justify-content-center">
                <div style="clear: both;"></div>
                <div class="col-sm-12 row d-flex justify-content-center">
                    <div class="col-sm-10 my-3">
                    <header class="section-header">
                        <h3>Check Your Details</h3>
                    </header>
                    <div class="row">
                        <div class="col-sm-12">
                            <div class="custom-control custom-radio">
                                <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                    <ContentTemplate>
                                        <span id="Gv1Head" runat="server" class="Gv1HeadCss"></span>
                                       <asp:GridView Width="100%" ID="Gv1" runat="server" AutoGenerateColumns="false"
                                                ShowHeader="true" HeaderStyle-Width="96%" OnRowDataBound="Gv1_RowDataBound"
                                                DataKeyNames="ID" OnRowCommand="Gv1_RowCommand">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="ID" ItemStyle-CssClass="itemStyle" Visible="false">
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblid" runat="server" Text='<%# Eval("ID") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Name" ItemStyle-CssClass="itemStyle" HeaderStyle-CssClass="headerStyleth">
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblmame" runat="server" Text='<%# Eval("CLIENT_NAME") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Date Of Birth" ItemStyle-CssClass="itemStyle" HeaderStyle-CssClass="headerStyleth">
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lbldob" runat="server" Text='<%# Eval("DOB") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Time Of Birth" ItemStyle-CssClass="itemStyle" HeaderStyle-CssClass="headerStyleth">
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lbltob" runat="server" Text='<%# Eval("TOB") + " (24 Hrs)" %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Place Of Birth" ItemStyle-CssClass="itemStyle" HeaderStyle-CssClass="headerStyleth">
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblPlaceOfBirth" runat="server" Text='<%# Eval("CITY") + ", " +  Eval("STATE") + ", "  + Eval("COUNTRY")  %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Country" ItemStyle-CssClass="itemStyle" Visible="false">
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblCountry" runat="server" Text='<%# Eval("COUNTRY") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="State" ItemStyle-CssClass="itemStyle" Visible="false">
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblState" runat="server" Text='<%# Eval("STATE") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="City" ItemStyle-CssClass="itemStyle" Visible="false">
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblCity" runat="server" Text='<%# Eval("CITY") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Gender" ItemStyle-CssClass="itemStyle" Visible="false">
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblgender" runat="server" Text='<%# Eval("GENDER") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Action" ItemStyle-CssClass="itemStyle" Visible="false">
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:LinkButton ID="LinkButton1" CommandArgument='<%# Eval("ID") %>'
                                                                CommandName="DeleteRecord" ForeColor="Red" runat="server">Delete</asp:LinkButton>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                </Columns>
                                                <AlternatingRowStyle CssClass="alternateItemStyle" />
                                                <HeaderStyle CssClass="headerStyle" />
                                               <RowStyle CssClass="rowStyle" />
                                            </asp:GridView>
                                        <div style="float: left; width: 100%; font-weight: bold; text-align: center; margin: 20px 0px 5px 0px;">Match With</div>
                                        <span id="Gv2Head" runat="server" class="Gv1HeadCss"></span>
                                       <asp:GridView Width="100%" ID="Gv2" runat="server" AutoGenerateColumns="false"
                                                ShowHeader="true" HeaderStyle-Width="96%" OnRowDataBound="Gv2_RowDataBound"
                                                DataKeyNames="ID" OnRowCommand="Gv2_RowCommand">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="ID" ItemStyle-CssClass="itemStyle" Visible="false">
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblid" runat="server" Text='<%# Eval("ID") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Name" ItemStyle-CssClass="itemStyle" HeaderStyle-CssClass="headerStyleth">
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblmame" runat="server" Text='<%# Eval("CLIENT_NAME") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Date Of Birth" ItemStyle-CssClass="itemStyle" HeaderStyle-CssClass="headerStyleth">
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lbldob" runat="server" Text='<%# Eval("DOB") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Time Of Birth" ItemStyle-CssClass="itemStyle" HeaderStyle-CssClass="headerStyleth">
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lbltob" runat="server" Text='<%# Eval("TOB") + " (24 Hrs)"  %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Place Of Birth" ItemStyle-CssClass="itemStyle" HeaderStyle-CssClass="headerStyleth">
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblPlaceOfBirth" runat="server" Text='<%# Eval("CITY") + ", " +  Eval("STATE") + ", "  + Eval("COUNTRY")  %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Country" ItemStyle-CssClass="itemStyle" Visible="false">
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblCountry" runat="server" Text='<%# Eval("COUNTRY") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="State" ItemStyle-CssClass="itemStyle" Visible="false">
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblState" runat="server" Text='<%# Eval("STATE") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="City" ItemStyle-CssClass="itemStyle" Visible="false">
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblCity" runat="server" Text='<%# Eval("CITY") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Gender" ItemStyle-CssClass="itemStyle" Visible="false">
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblgender" runat="server" Text='<%# Eval("GENDER") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Action" ItemStyle-CssClass="itemStyle" Visible="false">
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                                        <ItemTemplate>
                                                            <asp:LinkButton ID="LinkButton1" CommandArgument='<%# Eval("ID") %>'
                                                                CommandName="DeleteRecord" ForeColor="Red" runat="server">Delete</asp:LinkButton>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                </Columns>
                                                 <AlternatingRowStyle CssClass="alternateItemStyle" />
                                                <HeaderStyle CssClass="headerStyle" />
                                                <RowStyle CssClass="rowStyle" />
                                            </asp:GridView>
                                        <div style="float: left; width: 100%; font-weight: bold; text-align: center; margin: 0.5em 0em 0.5em 0em;"></div>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </div>
                    </div>
                    <div class="mt-3 text-center">
                        <asp:Button ID="btnproceed" runat="server" class="kwm-btn-lg" Text="Proceed to Payment" OnClick="btnproceed_Click"></asp:Button>
                    </div>
                        </div>
                </div>
            </div>
        </div>

    </div>
    <asp:HiddenField ID="hdnboyid" runat="server" />
    <asp:HiddenField ID="hdngirlid" runat="server" />
    <asp:HiddenField ID="hdnPayType" runat="server" />
    <asp:HiddenField ID="hdncartid" runat="server" />
    <asp:HiddenField ID="hdnRegUserId" runat="server" />
    <asp:HiddenField ID="hdnRegUserEmailId" runat="server" />
    <asp:HiddenField ID="hdngroup_u" runat="server" />
</asp:Content>

