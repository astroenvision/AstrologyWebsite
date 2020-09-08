<%@ Page Language="C#" AutoEventWireup="true" CodeFile="finalquestions.aspx.cs" Inherits="article_finalquestions" ValidateRequest="false" EnableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Astro Envision</title>
    <link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
</head>
<body id="body1"> 
    <form id="form1" runat="server">
    <asp:ScriptManager runat="Server" ID="ScriptManager1" EnablePartialRendering="false" />
    <script type="text/javascript" language="javascript">
    Sys.WebForms.PageRequestManager.getInstance().add_endRequest(EndRequestHandler);
    function EndRequestHandler(sender, args){
        if (args.get_error() != undefined){
            args.set_errorHandled(true);
        }
    }
   </script>
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <div class="middlecontainer">
            <div class="leftmiddlecontainer" style="width: 50%;">
                <ul id="tabs" runat="server">
                    <li><a id="groupheaderid" href="#" runat="server"></a></li>
                </ul>
                <div class="fullarticle" id="fullarticle_id" runat="server">
                </div>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Panel ID="HoraryPanel" runat="server" Height="300px" Width="100%" ScrollBars="Vertical">
                            <asp:GridView Width="100%" ID="GvHoraryQuestions" runat="server" AutoGenerateColumns="false"
                                ShowHeader="true" GridLines="none" HeaderStyle-Width="96%" OnRowDataBound="GvHoraryQuestions_RowDataBound"
                                OnRowDeleting="GvHoraryQuestions_RowDeleting" DataKeyNames="GROUP_ID" CssClass="questionsdiv_gv">
                                <Columns>
                                    <asp:TemplateField HeaderText="Type" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="14%"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top" Width="14%"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblgroupid" runat="server" Text='<%# Eval("GROUP_ID") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Astro Reports" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="75%"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top" Width="75%"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblcatid" runat="server" Text='<%# Eval("CATID") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="You've Chosen/May Add More" ItemStyle-ForeColor="#5D5D5D" Visible="false">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="40%"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top" Width="40%"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lbladdmore" runat="server" Text='<%# Eval("totalques") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Edit" ItemStyle-ForeColor="#5D5D5D" Visible="false">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="10%"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top" Width="10%"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:HyperLink ID="btnedit" runat="server" Target="_self">
                                               <img src="../Image/editbtn.png" alt="Edit" title="Edit" />
                                            </asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Delete" ItemStyle-ForeColor="#5D5D5D">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="btndelete" runat="server" Text="" CommandName="Delete" OnClientClick="return confirm('Are you sure, you want to delete this category?');">
                                                             &nbsp; &nbsp;<img src="../Image/deletebtn.png" alt="Delete" title="Delete" />
                                            </asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Category" ItemStyle-ForeColor="#5D5D5D" Visible="false">
                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="20%"></HeaderStyle>
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Top" Width="20%"></ItemStyle>
                                        <ItemTemplate>
                                            <asp:Label ID="lblcategoryid" runat="server" Text='<%# Eval("CATID") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:Panel>
                        <%--<asp:Panel ID="NatalPanel" runat="server" Height="300px" Width="100%" ScrollBars="Vertical">
                            <asp:GridView Width="100%" ID="GvNatalQuestions" runat="server" AutoGenerateColumns="false"
                                ShowHeader="false" GridLines="none" CssClass="questionsdiv_gv">
                                <Columns>
                                    <asp:TemplateField HeaderText="Country" ItemStyle-Width="100%" ItemStyle-ForeColor="#5D5D5D">
                                        <ItemTemplate>
                                            <asp:Label ID="lblCountry" runat="server" Text='<%# Eval("QUESTION") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:Panel>--%>
                        <%--<div class="fullarticle_offer" id="offermaindiv" runat="server">
                            <h2 class="offerh1">
                                Current Offer – Free of Cost
                            </h2>
                            <h2 class="offerh2" id="offerid" runat="server">
                            </h2>
                        </div>--%>
                        <div class="fullarticle_next" style="border:none;">
                            <h2 class="priceh2" id="actualtotalamt" runat="server">
                            </h2>
                            <h2 class="priceh1" id="discountper" runat="server">
                            </h2>
                            <h2 class="priceh3" id="totalamt" runat="server">
                            </h2>
                            <div style="text-align:right;">
                            <asp:Button ID="btnaddmorecat" runat="server" Text="Want to choose more Astro Report?" class="nextbtncss"
                                OnClick="btnaddmorecat_Click" />
                                <asp:Button ID="btnproceedforpayment" runat="server" Text="Proceed for Payment" class="proceednextbtncss"
                                OnClick="btnproceedforpayment_Click" />
                                </div>
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div class="rightmiddlecontainer" style="width: 48%;">
                <div class="proceednextcss">
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <h1>
                                <asp:CheckBox ID="chkboxreadtermsid" runat="server" CssClass="proceednextchkcss"
                                    AutoPostBack="true" Checked="true" />
                                "Please select the check box to accept the terms & conditions mentioned below
                                <br />
                                Please ensure the following accurate details are available with you before you proceed
                                for payment.<br />
                                <%--please click on <font color="#F4600A">"Proceed for Payment".</font><br />--%>
                                <font color="#F4600A">Date of Birth</font><br />
                                <font color="#F4600A">Time of Birth</font><br />
                                <font color="#F4600A">Place of Birth</font>
                            </h1>
                            
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>
        <uc2:footer ID="footer1" runat="server" />
    </div>
    <input type="hidden" runat="server" id="TotalAmounts" />
    <input type="hidden" runat="server" id="CurrencyType" />
    <input type="hidden" runat="server" id="hdncartid" />
    <input type="hidden" runat="server" id="hdncountrycode" />
    <input type="hidden" runat="server" id="hdngroupid" />
    </form>
</body>
</html>
