<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="managecombination.aspx.cs" Inherits="admin_managecombination" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
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
                                <asp:label runat="server" Visible="false" ID="lblID"></asp:label>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;" class="required">Chart</label>
                                    <asp:DropDownList runat="server" ID="ddlChart" CssClass="form-control">
                                        <asp:ListItem Value="-1" Selected="True">Select Chart</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="reqChart" runat="server" ControlToValidate="ddlChart" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Select Chart" SetFocusOnError="True" ValidationGroup="save" InitialValue="-1"></asp:RequiredFieldValidator>
                                </div>
                                     <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">House</label>
                                    <asp:DropDownList runat="server" ID="ddlHouse" CssClass="form-control">
                                        <asp:ListItem Value="-1" Selected="True">Select House</asp:ListItem>
                                    </asp:DropDownList>
                                   
                                </div>
                                     <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Planet</label>
                                    <asp:DropDownList runat="server" ID="ddlPlanet" CssClass="form-control">
                                        <asp:ListItem Value="-1" Selected="True">Select Planet</asp:ListItem>
                                    </asp:DropDownList>
                               </div>
                                    <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Rashi</label>
                                    <asp:DropDownList runat="server" ID="ddlRashi" CssClass="form-control">
                                        <asp:ListItem Value="-1" Selected="True">Select Rashi</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                          
                                  <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Lord</label>
                                    <asp:DropDownList runat="server" ID="ddlLord" CssClass="form-control">
                                        <asp:ListItem Value="-1" Selected="True">Select Lord</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                    <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Constsllation</label>
                                    <asp:DropDownList runat="server" ID="ddlConstsllation" CssClass="form-control">
                                        <asp:ListItem Value="-1" Selected="True">Select Constsllation</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                               <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Degree From</label>
                                    <asp:textbox runat="server" ID="txtDegreeFrom" CssClass="form-control">
                                      </asp:textbox>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Degree To</label>
                                    <asp:textbox runat="server" ID="txtDegreeTo" CssClass="form-control">
                                    </asp:textbox>
                                </div>
                                 <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Moved House</label>
                                    <asp:DropDownList runat="server" ID="ddlMovedHouse" CssClass="form-control">
                                        <asp:ListItem Value="-1" Selected="True">Select Moved House</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Moved Planet</label>
                                    <asp:DropDownList runat="server" ID="ddlMovedPlanet" CssClass="form-control">
                                        <asp:ListItem Value="-1" Selected="True">Select Moved Planet</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                  <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Moved Rashi</label>
                                    <asp:DropDownList runat="server" ID="ddlMovedRashi" CssClass="form-control">
                                        <asp:ListItem Value="-1" Selected="True">Select Moved Rashi</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                         <div class="col-md-6 col-sm-6  form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;">Moved Constsllation</label>
                                    <asp:DropDownList runat="server" ID="ddlMovedConstsllation" CssClass="form-control">
                                        <asp:ListItem Value="-1" Selected="True">Select Moved Constsllation</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                       <div class="col-md-12 col-sm-12  form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;" class="required">Logic Desc</label>
                                    <asp:TextBox runat="server" ID="txtLogicDesc" Rows="3" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqLogicDesc" runat="server" ControlToValidate="txtLogicDesc" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Logic Desc" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                               </div>
                                     <div class="col-md-12 col-sm-12  form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;" class="required">Logic</label>
                                    <asp:TextBox runat="server" ID="txtLogic" Rows="3" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqLogic" runat="server" ControlToValidate="txtLogic" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter Logic" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                               </div>
                                    <div class="col-md-12 col-sm-12  form-group has-feedback">
                                    <label style="font-size: 14px; color: #555; font-weight: bold;" class="required">Combination</label>
                                    <asp:TextBox runat="server" ID="txtCombination"  Rows="3" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="reqCombination" runat="server" ControlToValidate="txtCombination" CssClass="validator" Display="Dynamic"
                                        ErrorMessage="Enter txtCombination" SetFocusOnError="True" ValidationGroup="save"></asp:RequiredFieldValidator>
                               </div>

                                <div class="form-group row">
                                    <div class="col-md-9 col-sm-9" style="margin-top: 31px;">
                                        <asp:CheckBox runat="server" ID="chkStatus" Text="Approved" Style="margin-left: 10px; font-size: 14px; color: #555; font-weight: bold;"></asp:CheckBox>
                                    </div>
                                    <div class="col-md-9 col-sm-9  offset-md-3">
                                        <asp:LinkButton ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-success" ValidationGroup="save" OnClick="btnUpdate_Click"  />
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
</asp:Content>


