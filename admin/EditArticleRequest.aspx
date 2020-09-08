<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="EditArticleRequest.aspx.cs" Inherits="admin_EditArticleRequest" ValidateRequest="false" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
        <%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="right_col" role="main">
        <div class="">
            <div class="page-title">
                <div class="title_left">
                    <h3>Update Article</h3>
                </div>
                <div class="title_right" runat="server" visible="false" >
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
                            <%--<h2>Form Design <small>different form elements</small></h2>--%>
                            <ul class="nav navbar-right panel_toolbox">
                                <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                                </li>
                                <li><a class="close-link"><i class="fa fa-close"></i></a>
                                </li>
                            </ul>
                            <div class="clearfix"></div>
                        </div>
                        <div class="x_content">
                          
                              <div class="form-group" id="divUserImg" runat="server" style="margin-left: 10px;">
                                   <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Author Image</label>
                                <br>
                              <asp:Image ID="imgauthor" runat="server" Height="100px"  Width="150px" BorderWidth="1px">
                              </asp:Image>
                             </div>
                            <div class="form-label-left input_mask">
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                     <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Name</label>
                                    <asp:TextBox runat="server" ID="txtName" CssClass="form-control" placeholder="Name"></asp:TextBox>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Category Name</label>
                                <asp:label runat="server" id="lblCatID" Visible="false"></asp:label>
                                <asp:label runat="server" id="lblStatus" Visible="false"></asp:label>
                                 <asp:TextBox runat="server" ID="txtCatName" CssClass="form-control" placeholder="Category Name"></asp:TextBox>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                   <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Group Name</label>
                                   <asp:TextBox runat="server" ID="txtGroupName" CssClass="form-control" placeholder="Group Name"></asp:TextBox>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                       <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Priority</label>
                                   <asp:dropdownlist runat="server" ID="ddlPriority" CssClass="form-control">
                                    <asp:listitem Value="-1">Select Priority</asp:listitem>
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
                                <div style="margin-left: 11px;">
                                <div class="form-group row">
                                    <label class="col-form-label col-md-3 col-sm-3 " style="FONT-SIZE: 14px;color: #555; font-weight: bold;">HeadLine</label>
                                    <div class="col-md-9 col-sm-9 ">
                                       <asp:TextBox runat="server" ID="txtHeadLine" CssClass="form-control" TextMode="MultiLine" Rows="2"></asp:TextBox>
                                    </div>
                                </div>
                           
                                    <div class="form-group">
                                   <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Synopsis</label>
                                     <FCKeditorV2:FCKeditor ID="fckSynopsis" runat="server" BasePath="~/fckeditor/" Height="400" ></FCKeditorV2:FCKeditor>
                                </div>

                                  <div class="form-group">
                                   <label style="FONT-SIZE: 14px;color: #555; font-weight: bold;">Meta Description</label>
                                     <FCKeditorV2:FCKeditor ID="rtedetails" runat="server" BasePath="~/fckeditor/" Height="400" ></FCKeditorV2:FCKeditor>
                                </div>
                                    </div>
                          
                                <div class="form-group row">
                                    <div class="col-md-9 col-sm-9  offset-md-3">
                                        <asp:linkbutton ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-success" ValidationGroup="save"  OnClick="btnUpdate_Click" />
                                        <asp:linkbutton ID="lnkbutton" runat="server" Text="Close" CssClass="btn btn-secondary" OnClientClick="javascript:window.close();" />
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

