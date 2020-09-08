<%@ Page Title="" Language="C#" MasterPageFile="~/astroenvision.master" AutoEventWireup="true" CodeFile="NatalCategory.aspx.cs" Inherits="section_NatalCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <div class="container-sec">
            <div style="clear: both;"></div>
            <div class="content-center">
                <div class="col-sm-12">
                    <div class="fullarticle" id="fullarticle_id" runat="server">
                    </div>
                </div>
            </div>
            <div class="content-center">
                <div class="tab-content">
                    <div id="natal" class="tab-pane active">
                        <div class="row">
                            <div class="col-xl-12 col-sm-12 form-group" id="categories_list" runat="server">
                                <div class="table-responsive">
                                    <table class="table table-bordered crttbl">
                                        <thead>
                                            <tr>
                                                <%--<th class="text-left">Category Image</th>--%>
                                                <th class="text-left">Name</th>
                                                <th class="text-left">Actual Price</th>
                                                <th class="text-left">Discount</th>
                                                <th class="text-left">You Save</th>
                                                <th class="text-left">Payable Price</th>
                                                <th class="text-left">Buy Report</th>
                                            </tr>
                                        </thead>
                                        <tbody id="divData" runat="server">
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

