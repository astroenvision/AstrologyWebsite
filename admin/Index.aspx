<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Admin.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="admin_Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="right_col" role="main">
        <div class="row" style="display: inline-block;padding:10px 0px 0px 0px;" id="divAdminBlock" runat="server">
                <div class="top_tiles">
                    <h4 id="hhead" runat="server"></h4>
                     <div class="animated flipInY col-lg-3 col-md-3 col-sm-6 ">
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-user"></i></div>
                            <a style="color: #f25e0a;" href="<%=ResolveUrl("~/admin/RegisteredUserList.aspx") %>" target="_blank" title="Register User"><div class="count" id="divTotalReguser" runat="server"></div></a>
                            <h5>Registered User</h5>
                        </div>
                    </div>
                     <div class="animated flipInY col-lg-3 col-md-3 col-sm-6 ">
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-user-times"></i></div>
                            <a style="color: #f25e0a;" href="<%=ResolveUrl("~/admin/FreeUserList.aspx") %>" target="_blank" title="Free User"> <div class="count" id="divFreeUser" runat="server"></div></a>
                            <h5>Free Horoscope Reports</h5>
                        </div>
                    </div>
                     <div class="animated flipInY col-lg-3 col-md-3 col-sm-6 ">
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-flag"></i></div>
                              <a style="color: #f25e0a;" href="<%=ResolveUrl("~/admin/FreeMatchingUser.aspx") %>" target="_blank" title="Free Matching Report">   <div class="count" id="divFreeMatchingUser" runat="server"></div></a>
                            <h5>Free Matching Reports</h5>
                        </div>
                    </div>
                    <div class="animated flipInY col-lg-3 col-md-3 col-sm-6 ">
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-user-plus"></i></div>
                              <a style="color: #f25e0a;" href="<%=ResolveUrl("~/admin/PaidUserList.aspx") %>" target="_blank" title="Paid User"> <div class="count" id="divTotalPaidUser" runat="server"></div></a>
                            <h5>Paid User</h5>
                        </div>
                    </div> 
                      <div class="animated flipInY col-lg-3 col-md-3 col-sm-6 " runat="server" >
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-flag"></i></div>
                              <a style="color: #f25e0a;" href="<%=ResolveUrl("~/admin/PaidMatchingUser.aspx") %>" target="_blank" title="Paid Matching Report"><div class="count" id="divPaidMatchingReport" runat="server"></div></a>
                            <h5>Paid Matching Reports</h5>
                        </div>
                    </div>
                    <div class="animated flipInY col-lg-3 col-md-3 col-sm-6 ">
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-pencil-square-o"></i></div>
                             <a style="color: #f25e0a;" href="<%=ResolveUrl("~/admin/TestimonialsList.aspx") %>" target="_blank" title="Testimonials"><div class="count" id="divTestimonials" runat="server"></div></a>
                            <h5>Testimonials</h5>
                        </div>
                    </div>
                     <div class="animated flipInY col-lg-3 col-md-3 col-sm-6 ">
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-inr"></i></div>
                            <a style="color: #f25e0a;" href="<%=ResolveUrl("~/admin/PaymentDetails.aspx") %>" target="_blank" title="Received Payment"><div class="count" id="divPaymentInINR" runat="server"></div></a>
                             <h5>Total Payment</h5>
                        </div>
                    </div>
                     <div class="animated flipInY col-lg-3 col-md-3 col-sm-6 ">
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-comments"></i></div>
                           <a style="color: #f25e0a;" href="<%=ResolveUrl("~/admin/FeedbackList.aspx") %>" target="_blank" title="FeedBack"> <div class="count" id="divTotalFeedBack" runat="server"></div></a>
                            <h5>FeedBack</h5>
                        </div>
                    </div>
                       <div class="animated flipInY col-lg-3 col-md-3 col-sm-6 ">
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-comments"></i></div>
                           <a style="color: #f25e0a;" href="<%=ResolveUrl("~/admin/ImportantPlanet.aspx") %>" target="_blank" title="FeedBack"> <div class="count" id="divCurrentImportantPlanet" runat="server"></div></a>
                            <h5>Important Planet</h5>
                        </div>
                    </div>

                      <div class="animated flipInY col-lg-3 col-md-3 col-sm-6 ">
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-user-plus"></i></div>
                              <a style="color: #f25e0a;" title="Paid User"> <div class="count" id="divAstrologerClient" runat="server"></div></a>
                            <h5>Astrologer Client</h5>
                        </div>
                    </div> 

              </div>  </div>
        <div class="row" id="divAdminData" runat="server">
                        <div class="top_tiles">
                     <h4>Overall Report</h4>
                         <div class="animated flipInY col-lg-3 col-md-3 col-sm-6 ">
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-user-plus"></i></div>
                              <a style="color: #f25e0a;" href="<%=ResolveUrl("~/admin/RegisteredUserList.aspx?q=Alluser") %>" target="_blank" title="Paid User"> <div class="count" id="divTotalUser" runat="server"></div></a>
                            <h5>Registered User</h5>
                        </div>
                    </div> 
                       <div class="animated flipInY col-lg-3 col-md-3 col-sm-6 ">
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-user-times"></i></div>
                            <a style="color: #f25e0a;" href="<%=ResolveUrl("~/admin/FreeUserList.aspx?q=Alluser") %>" target="_blank" title="Free User"> <div class="count" id="divTotalFreeUser" runat="server"></div></a>
                            <h5>Free Horoscope Reports</h5>
                        </div>
                    </div>
                      <div class="animated flipInY col-lg-3 col-md-3 col-sm-6 ">
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-flag"></i></div>
                              <a style="color: #f25e0a;" href="<%=ResolveUrl("~/admin/FreeMatchingUser.aspx?q=Alluser") %>" target="_blank" title="Free Matching Report">   <div class="count" id="divTotalFreeMatching" runat="server"></div></a>
                            <h5>Free Matching Reports</h5>
                        </div>
                    </div>
                         <div class="animated flipInY col-lg-3 col-md-3 col-sm-6 ">
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-user-plus"></i></div>
                              <a style="color: #f25e0a;" href="<%=ResolveUrl("~/admin/OverallPaidUserList.aspx") %>" target="_blank" title="Paid User"> <div class="count" id="divOverallUser" runat="server"></div></a>
                            <h5>Paid User</h5>
                        </div>
                    </div> 
                     <div class="animated flipInY col-lg-3 col-md-3 col-sm-6 " runat="server" >
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-flag"></i></div>
                              <a style="color: #f25e0a;" href="<%=ResolveUrl("~/admin/PaidMatchingUser.aspx?q=Alluser") %>" target="_blank" title="Paid Matching Report"><div class="count" id="divTotalPaidMatching" runat="server"></div></a>
                            <h5>Paid Matching Reports</h5>
                        </div>
                    </div>
                    <div class="animated flipInY col-lg-3 col-md-3 col-sm-6 ">
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-pencil-square-o"></i></div>
                             <a style="color: #f25e0a;" href="<%=ResolveUrl("~/admin/TestimonialsList.aspx?q=Alluser") %>" target="_blank" title="Testimonials"><div class="count" id="divTotalTestimonials" runat="server"></div></a>
                            <h5>Testimonials</h5>
                        </div>
                    </div>
                      <div class="animated flipInY col-lg-3 col-md-3 col-sm-6 ">
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-inr"></i></div>
                             <a style="color: #f25e0a;" href="<%=ResolveUrl("~/admin/OverallPaidUser.aspx") %>" target="_blank" title="FeedBack"> <div class="count" id="divOverRallPayment" runat="server"></div></a>
                             <h5>Total Amount</h5>
                        </div>
                    </div>
                        <div class="animated flipInY col-lg-3 col-md-3 col-sm-6 ">
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-comments"></i></div>
                           <a style="color: #f25e0a;" href="<%=ResolveUrl("~/admin/FeedbackList.aspx?q=Alluser") %>" target="_blank" title="FeedBack"> <div class="count" id="divOverRallFeedbackList" runat="server"></div></a>
                            <h5>FeedBack</h5>
                        </div>
                    </div>
                             <div class="animated flipInY col-lg-3 col-md-3 col-sm-6 ">
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-comments"></i></div>
                           <a style="color: #f25e0a;" href="<%=ResolveUrl("~/admin/ImportantPlanet.aspx?q=Alluser") %>" target="_blank" title="FeedBack"> <div class="count" id="divImportantPlanet" runat="server"></div></a>
                            <h5>Important Planet</h5>
                        </div>
                    </div>
                            <div class="animated flipInY col-lg-3 col-md-3 col-sm-6 ">
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-user-plus"></i></div>
                            <a style="color: #f25e0a;" title="Free User"> <div class="count" id="divAstroOverrallClient" runat="server"></div></a>
                            <h5>Astrologer Client</h5>
                        </div>
                    </div>
               </div>
            </div>
       <div class="row" id="divAstrologerData" runat="server">
                        <div class="top_tiles">
                     <h4 id="hAstroHead" runat="server"></h4>
                         <div class="animated flipInY col-lg-12 col-md-12 col-sm-6 ">
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-user-plus"></i></div>
                              <a style="color: #f25e0a;" title="Paid User"> <div class="count" id="divTotalClient" runat="server"></div></a>
                            <h5>Total Client</h5>
                        </div>
                    </div> 
                            <h4>Overall Report</h4>
                       <div class="animated flipInY col-lg-12 col-md-12 col-sm-6 ">
                        <div class="tile-stats">
                            <div class="icon"><i style="font-size: 47px;" class="fa fa-user-plus"></i></div>
                            <a style="color: #f25e0a;" title="Free User"> <div class="count" id="divOverrallClient" runat="server"></div></a>
                            <h5>Overrall Client</h5>
                        </div>
                    </div>
                </div>
            </div>
    </div>
</asp:Content>

