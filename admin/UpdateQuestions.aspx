<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="UpdateQuestions.aspx.cs" Inherits="admin_UpdateQuestions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div class="right_col" role="main">
        <div class="">
            <div class="page-title">
                <div class="title_left">
                    <h3>Update Questions</h3>
                </div>
            </div>
            <div class="clearfix"></div>
            <div class="row" style="display: block;">
                <div class="clearfix"></div>
                <div class="col-md-12 col-sm-12  ">
                    <div class="x_panel">
                        <div class="x_content">
                            <div class="table-responsive">
                                <asp:GridView ID="grdData" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="grdData_PageIndexChanging" OnRowCancelingEdit="grdData_RowCancelingEdit" OnRowEditing="grdData_RowEditing" OnRowUpdating="grdData_RowUpdating"
                                    CssClass="table table-striped jambo_table bulk_action" HeaderStyle-CssClass="headings" PageSize="50" HeaderStyle-BackColor="#f25e0a" HeaderStyle-ForeColor="White">
                                    <AlternatingRowStyle CssClass="even" />
                                    <Columns>
                                         <asp:TemplateField HeaderText="CATEGORYID" Visible="false">
                                            <HeaderStyle HorizontalAlign="Left" Width="100px"></HeaderStyle>
                                            <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:Label ID="lblID" Visible="false" runat="server" Text='<%# Server.HtmlEncode(DataBinder.Eval (Container.DataItem, "FINAL_CATID").ToString()) %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="CATEGERY">
                                            <HeaderStyle HorizontalAlign="Left" Width="250px"></HeaderStyle>
                                            <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:Label ID="lbl_Category" runat="server" Text='<%#Eval("FINAL_CATEGERY") %>'></asp:Label>
                                                <asp:Label ID="lblOldQus" runat="server" Visible="false" Text='<%#Eval("QUESTION") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="QUESTION">
                                            <HeaderStyle HorizontalAlign="Left" Width="500px"></HeaderStyle>
                                            <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:Label ID="lbl_Name" runat="server" Text='<%#Eval("QUESTION") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtQuestions" runat="server" Width="100%" Text='<%#Eval("QUESTION") %>' CssClass="form-control"></asp:TextBox>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>
                                            <HeaderStyle HorizontalAlign="Left" Width="200px"></HeaderStyle>
                                            <ItemStyle HorizontalAlign="Left" VerticalAlign="Top"></ItemStyle>
                                            <ItemTemplate>
                                                <asp:Button ID="btn_Edit" runat="server" Text="Edit" CommandName="Edit"  CssClass="btn btn-primary"/>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:Button ID="btn_Update" runat="server" Text="Update" CommandName="Update" CssClass="btn btn-success" />
                                                <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" CommandName="Cancel" CssClass="btn btn-secondary" />
                                            </EditItemTemplate>
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
                </div>
            </div>
        </div>
    </div>
</asp:Content>
