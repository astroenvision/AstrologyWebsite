<%@ Page Language="C#" AutoEventWireup="true" CodeFile="questions.aspx.cs" Inherits="article_questions"
    ValidateRequest="false" EnableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/usercontrol/header.ascx" TagName="header" TagPrefix="uc1" %>
<%@ Register Src="~/usercontrol/footer.ascx" TagName="footer" TagPrefix="uc2" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Astro Envision</title>
    <%--<link rel="shortcut icon" href="<%=ResolveUrl("~/Image/favicon.ico") %>" type="image/x-icon" />
    <script type="text/javascript" src="<%=ResolveUrl("~/javascript/login.js") %>"></script>--%>
    <link rel="shortcut icon" href="../Image/favicon.ico" type="image/x-icon" />
    <script type="text/javascript" src="../javascript/login.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager runat="Server" ID="ScriptManager1" EnablePartialRendering="false" />
    <div class="maincontainer">
        <uc1:header ID="header1" runat="server" />
        <div class="middlecontainer">
            <div class="leftmiddlecontainer">
                <ul id="tabs" runat="server">
                    <li><a href="#">Horary</a></li>
                </ul>
                <div class="fullarticle" id="fullarticle_id" runat="server">
                </div>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Panel ID="HoraryPanel" runat="server" Height="300px" Width="100%" ScrollBars="Vertical">
                            <asp:GridView Width="100%" ID="GvHoraryQuestions" runat="server" AutoGenerateColumns="false"
                                ShowHeader="false" GridLines="none" OnRowDataBound="GvHoraryQuestions_RowDataBound"
                                CssClass="questionsdiv_gv">
                                <Columns>
                                    <asp:TemplateField HeaderText="QuestionId" ItemStyle-Width="2%" ItemStyle-ForeColor="#5D5D5D"
                                        Visible="false">
                                        <ItemTemplate>
                                            <asp:Label ID="lblhoraryquestionid" runat="server" Text='<%# Eval("Question_id") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Question" ItemStyle-Width="90%" ItemStyle-ForeColor="#5D5D5D">
                                        <ItemTemplate>
                                            <asp:Label ID="lblhoraryquestion" runat="server" Text='<%# Eval("sub_code") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkRowhorary" CssClass="grdchkbox" Checked="true" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:Panel>
                        <asp:Panel ID="NatalPanel" runat="server" Height="300px" Width="100%" ScrollBars="Vertical">
                            <asp:GridView Width="100%" ID="GvNatalQuestions" runat="server" AutoGenerateColumns="false"
                                ShowHeader="false" GridLines="none" OnRowDataBound="GvNatalQuestions_RowDataBound"
                                CssClass="questionsdiv_gv">
                                <Columns>
                                    <asp:TemplateField HeaderText="QuestionId" ItemStyle-Width="2%" ItemStyle-ForeColor="#5D5D5D"
                                        Visible="false">
                                        <ItemTemplate>
                                            <asp:Label ID="lblnatalquestionid" runat="server" Text='<%# Eval("QUESTION_ID") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Question" ItemStyle-Width="90%" ItemStyle-ForeColor="#5D5D5D">
                                        <ItemTemplate>
                                            <asp:Label ID="lblnatalquestion" runat="server" Text='<%# Eval("QUESTION") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkRownatal" CssClass="grdchkbox" Checked="true" runat="server"
                                                Visible="false" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:Panel>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <div class="fullarticle_next">
                    <h2 class="priceh2" id="actualtotalamt" runat="server">
                    </h2>
                    <h2 class="priceh1" id="discountper" runat="server">
                    </h2>
                    <h2 class="priceh3" id="totalamt" runat="server">
                    </h2>
                    <div style="text-align: left;">
                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                            <ContentTemplate>
                                <asp:Button ID="btnnext" runat="server" Text="Buy this Report" class="nextbtncss"
                                    OnClick="btnnext_Click" />
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
            </div>
            <div class="rightmiddlecontainer">
            </div>
        </div>
        <uc2:footer ID="footer1" runat="server" />
    </div>
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <div style="display: none;">
                <asp:Button ID="selectallH" runat="server" Text="Select All" OnClick="selectallH_Click" />
                <asp:Button ID="UnselectallH" runat="server" Text="Deselect All" OnClick="UnselectallH_Click" />
                <asp:Button ID="selectallN" runat="server" Text="Select All" OnClick="selectallN_Click" />
                <asp:Button ID="UnselectallN" runat="server" Text="Deselect All" OnClick="UnselectallN_Click" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>

    <script language="javascript" type="text/javascript">
    function SetHoraryAutoSelected(flag) {
           var chkflag = flag;
           if (chkflag == "Select") {
                var btn = document.getElementById('<%= selectallH.ClientID %>');
                 btn.click();
                 document.getElementById("selectid").style.color = '#F4600A';
                 document.getElementById("deselectid").style.color = '#4d4d4d';
            } 
            if (chkflag == "DeSelect") {
                var btn = document.getElementById('<%= UnselectallH.ClientID %>');
                 btn.click();
                 document.getElementById("deselectid").style.color = '#F4600A';
                 document.getElementById("selectid").style.color = '#4d4d4d';
            } 
    }
    </script>

    <script language="javascript" type="text/javascript">
    function SetNatalAutoSelected(flag) {
           var chkflag = flag;
           if (chkflag == "Select") {
                var btn = document.getElementById('<%= selectallN.ClientID %>');
                 btn.click();
                 document.getElementById("selectid").style.color = '#F4600A';
                 document.getElementById("deselectid").style.color = '#4d4d4d';
            } 
            if (chkflag == "DeSelect") {
                var btn = document.getElementById('<%= UnselectallN.ClientID %>');
                 btn.click();
                 document.getElementById("deselectid").style.color = '#F4600A';
                 document.getElementById("selectid").style.color = '#4d4d4d';
            } 
    }
    </script>

</body>
</html>
