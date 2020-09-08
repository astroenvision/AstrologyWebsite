<%@ Page Title="" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="EditArticlesRequest.aspx.cs" Inherits="admin_EditArticlesRequest" ValidateRequest="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <asp:UpdatePanel ID="upMain" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
      <section class="srvc-sec">
            <div class="container">
                <div class="row justify-content-center">
                    <div class="col-sm-8">
                        <div class="accntsec">
                            <header class="section-header">
                                <h3>Update Article</h3>
                            </header>
                              <div class="form-group" id="divUserImg" runat="server">
                             <label >Author Image</label>
                                <br>
                              <asp:Image ID="imgauthor" runat="server" Height="100px" ImageUrl="" Width="150px" BorderWidth="1px">
                              </asp:Image>
                             </div>
                               <div class="row">
                            <div class="col-sm-6 form-group" id="divName" runat="server">
                                <label>Name</label>
                                <asp:TextBox ID="txtName" runat="server" CssClass="form-control form-control-lg"></asp:TextBox>
                            </div>

                            <div class="col-sm-6 form-group" id="divCatName" runat="server">
                                <label>Category Name</label>
                                <asp:label runat="server" id="lblCatID" Visible="false"></asp:label>
                                <asp:label runat="server" id="lblStatus" Visible="false"></asp:label>
                                <asp:TextBox ID="txtCatName" runat="server" CssClass="form-control form-control-lg"></asp:TextBox>
                            </div>
                                   </div>

                                   <div class="row">
                            <div class="col-sm-6 form-group" id="divGroup" runat="server">
                                <label>Group Name</label>
                                <asp:TextBox ID="txtGroupName" runat="server" CssClass="form-control form-control-lg"></asp:TextBox>
                            </div>

                             <div class="col-sm-6 form-group" id="divPriority" runat="server">
                                <label>Priority</label>
                                <asp:dropdownlist ID="ddlPriority" runat="server" CssClass="form-control form-control-lg">
                                    <asp:listitem Value="0">0</asp:listitem>
                                    <asp:listitem Value="1">1</asp:listitem>
                                    <asp:listitem Value="2">2</asp:listitem>
                                    <asp:listitem Value="3">3</asp:listitem>
                                    <asp:listitem Value="4">4</asp:listitem>
                                    <asp:listitem Value="5">5</asp:listitem>
                                    <asp:listitem Value="6">6</asp:listitem>
                                    <asp:listitem Value="7">7</asp:listitem>
                                    <asp:listitem Value="8">8</asp:listitem>
                                    <asp:listitem Value="9">9</asp:listitem>
                                    <asp:listitem Value="10">10</asp:listitem>
                                    <asp:listitem Value="11">11</asp:listitem>
                                    <asp:listitem Value="12">12</asp:listitem>
                                    <asp:listitem Value="13">13</asp:listitem>
                                    <asp:listitem Value="14">14</asp:listitem>
                                    <asp:listitem Value="15">15</asp:listitem>
                                    <asp:listitem Value="16">16</asp:listitem>
                                    <asp:listitem Value="17">17</asp:listitem>
                                    <asp:listitem Value="18">18</asp:listitem>
                                    <asp:listitem Value="19">19</asp:listitem>
                                    <asp:listitem Value="20">20</asp:listitem>
                                </asp:dropdownlist>
                            </div>
                                   </div>

                            <div class="form-group" id="divHeadLine" runat="server">
                                <label>HeadLine</label>
                                <asp:TextBox ID="txtHeadLine" runat="server" CssClass="form-control form-control-lg" TextMode="MultiLine"></asp:TextBox>
                            </div>
                            <div class="form-group" id="divSynopsis" runat="server">
                                <label>Synopsis</label>
                                <asp:TextBox ID="txtSynopsis" runat="server" CssClass="form-control form-control-lg" TextMode="MultiLine"></asp:TextBox>
                            </div>

                            <div class="form-group" id="divFullStory" runat="server">
                                <label>Full Story</label>
                                <asp:TextBox ID="txtFullStory" runat="server" CssClass="form-control form-control-lg" TextMode="MultiLine"></asp:TextBox>
                            </div>
                           <div class="mt-3 text-center">
                                <asp:linkbutton ID="btnUpdate" runat="server" Text="Update" CssClass="kwm-btn-lg-color" ValidationGroup="save"  OnClick="btnUpdate_Click" />
                                <asp:linkbutton ID="lnkbutton" runat="server" Text="Close" CssClass="kwm-btn-lg-color" OnClientClick="javascript:window.close();" />
                            </div>
            
                        </div>
             
                    </div>
                </div>
                </div>
      
        </section>
            </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="btnUpdate" />
        </Triggers>
    </asp:UpdatePanel>
        
</asp:Content>


