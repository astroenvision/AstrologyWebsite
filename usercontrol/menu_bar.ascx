<%@ Control Language="C#" AutoEventWireup="true" CodeFile="menu_bar.ascx.cs" Inherits="usercontrol_menu_bar" %>
<link type="text/css" rel="stylesheet" href="<%=ResolveUrl("~/CSS/index.css") %>" />
<link type="text/css" rel="stylesheet" href="<%=ResolveUrl("~/CSS/mystyle.css") %>" />
<meta charset="utf-8">

<ul class="mtree transit">
        <li><a href="#">Horary</a>
            <ul>
                <li><a href="#">My Account</a></li>
                <li><a href="#">Horary Yoga</a>
                    <ul>
                        <li><a href="#">Calculate Horary Yoga</a></li>
                        <li><a href="#">Calculate Karyasiddhi Yoga</a></li>
                    </ul>
                </li>
                 <li><a href="#">Nature Of Query</a></li>
                <li><a onclick="javascript:getopen(&quot;horarysignificator.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                    style="cursor: pointer">Horary Significator</a></li>
                <li><a onclick="javascript:getopen(&quot;hoarary_knowledge.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                    style="cursor: pointer">Horary Knowledge</a></li>
                    <li><a href="javascript:void(0);">Calculation</a>
                    <ul>
                        <li><a href="#">Horary Calculation</a></li>
                        <li><a href="#">Probable Query</a></li>
                    </ul>
                </li>
                <li><a onclick="javascript:getopen(&quot;horary_illustration.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value + &quot;&amp;gropunder=&quot; + &quot;Horary&quot;)"
                    style="cursor: pointer">Horary Illustration</a></li>
                <li><a href="#">About us</a></li>
                <li><a onclick="javascript:getopen1(&quot;login.aspx&quot;)" style="cursor: pointer">
                    Log Out</a></li>
            </ul>
        </li>
        <li><a href="#">Natal</a>
            <ul>
                <li><a href="#">My Account</a></li>
                <li><a href="#">Natal Yoga</a></li>
                <li><a href="#">Natal Predictive</a></li>
                <li><a onclick="javascript:getopen(&quot;significator.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                    style="cursor: pointer">Natal Significators</a></li>
                <li><a onclick="javascript:getopen(&quot;astro_tree_view.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                    style="cursor: pointer">Natal Knowledge</a></li>
                <li><a href="javascript:void(0);">Research Tool</a>
                    <ul>
                        <li><a onclick="javascript:getopen(&quot;ResearchTool.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                            style="cursor: pointer">Planets in Various Awastha’s in Varga’s </a></li>
                        <li><a onclick="javascript:getopen(&quot;ResearchTool_awastha.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                            style="cursor: pointer">Planets in Awastha’s – Planetary war etc</a></li>
                        <li><a onclick="javascript:getopen(&quot;researchtool_conj_rashi.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value+ &quot;&amp;filt=&quot; + &quot;Without Conjunction&quot;)"
                            style="cursor: pointer">Planets in Rashi’s &amp; House’s in Varga’s</a></li>
                        <li><a onclick="javascript:getopen(&quot;researchtool_conj_rashi.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value+ &quot;&amp;filt=&quot; + &quot;With Conjunction&quot;)"
                            style="cursor: pointer">Conjunction of Chosen Planets in Rashi and Houses in Varga’s</a></li>
                        <li><a onclick="javascript:getopen(&quot;researchtool_conjunction.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                            style="cursor: pointer">Conjunction of chosen Planets in Varga’s</a></li>
                        <li><a onclick="javascript:getopen(&quot;research_tool_any.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                            style="cursor: pointer">Conjunction of Planets – Number of Planets</a></li>
                        <li><a onclick="javascript:getopen(&quot;researchtool_nakshatra.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value+ &quot;&amp;filt=&quot; + &quot;Without Conjunction&quot;)"
                            style="cursor: pointer">Search the Single or Multiple Planets on Basis of Multiple
                            Nakashtra/Constellation</a></li>
                        <li><a onclick="javascript:getopen(&quot;researchtool_nakshatra.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value+ &quot;&amp;filt=&quot; + &quot;With Conjunction&quot;)"
                            style="cursor: pointer">Search the Conjuction of Planets in Single or Multiple Nakashtra’s/Constellation’s</a></li>
                        <li><a onclick="javascript:getopen(&quot;researchtool_aspect.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                            style="cursor: pointer">Search for Aspects of Planet’s</a></li>
                        <li><a onclick="javascript:getopen(&quot;research_dashamsha.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                            style="cursor: pointer">Search for Awastha of Planets in Dashamsha</a></li>
                        <li><a onclick="javascript:getopen(&quot;ResearchTool_Driskkan.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                            style="cursor: pointer">Driskkan Division</a></li>
                    </ul>
                </li>
                <li><a href="#">Natal Calculation</a></li>
                <li><a href="#">Remedial</a></li>
                <li><a onclick="javascript:getopen(&quot;horary_illustration.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value + &quot;&amp;gropunder=&quot; + &quot;Natal&quot;)" style="cursor:pointer">Natal Illustration</a></li>
                <li><a href="#">About Us</a></li>
                <li id="a11"><a onclick="javascript:getopen1(&quot;login.aspx&quot;)" style="cursor:pointer">Log Out</a></li>
            </ul>
        </li>

    </ul>

<%--<script type="text/javascript" src="<%=ResolveUrl("~/javascript/mtree.jquery.min.js") %>"></script>--%>
  <script type="text/javascript" src="<%=ResolveUrl("~/javascript/mtree.min.js") %>"></script>
<script type="text/javascript" src="<%=ResolveUrl("~/javascript/mtree.js") %>"></script>


<%--<script type="text/javascript">
$(document).ready(function() {
  var mtree = $('ul.mtree');
  
  // Skin selector for demo
  mtree.wrap('<div class=mtree-demo></div>');
  var skins = ['bubba','skinny','transit','jet','nix'];
  mtree.addClass(skins[0]);
  $('body').prepend('<div class="mtree-skin-selector"><ul class="button-group radius"></ul></div>');
  var s = $('.mtree-skin-selector');
  $.each(skins, function(index, val) {
    s.find('ul').append('<li><button class="small skin">' + val + '</button></li>');
  });
  s.find('ul').append('<li><button class="small csl active">Close Same Level</button></li>');
  s.find('button.skin').each(function(index){
    $(this).on('click.mtree-skin-selector', function(){
      s.find('button.skin.active').removeClass('active');
      $(this).addClass('active');
      mtree.removeClass(skins.join(' ')).addClass(skins[index]);
    });
  })
  s.find('button:first').addClass('active');
  s.find('.csl').on('click.mtree-close-same-level', function(){
    $(this).toggleClass('active'); 
  });
});
    </script>--%>























<%--<script type="text/javascript">
      var $m = jQuery.noConflict();
		$m( document ).ready( function( ) {
				$m( '.treeboxmenu li' ).each( function() {
						if( $m( this ).children( 'ul' ).length > 0 ) {
								$m( this ).addClass( 'parent' );     
						}
				});
				
				$m( '.treeboxmenu li.parent > a' ).click( function( ) {
						$m( this ).parent().toggleClass( 'active' );
						$m( this ).parent().children( 'ul' ).slideToggle( 'fast' );
				});
				
				$m( '#all' ).click( function() {
					
					$m( '.treeboxmenu li' ).each( function() {
						$m( this ).toggleClass( 'active' );
						$m( this ).children( 'ul' ).slideToggle( 'fast' );
					});
				});
				
		});
</script>--%>

<%--<div class="treeboxmenu">
    <ul>
        <li><a>Horary</a>
            <ul>
                <li><a href="#">My Account</a></li>
                <li><a>Horary Yoga</a>
                    <ul>
                        <li><a href="#">Calculate Horary Yoga</a></li>
                        <li><a href="#">Calculate Karyasiddhi Yoga</a></li>
                    </ul>
                </li>
                <li><a href="#">Nature Of Query</a></li>
                <li><a onclick="javascript:getopen(&quot;horarysignificator.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                    style="cursor: pointer">Horary Significator</a></li>
                <li><a onclick="javascript:getopen(&quot;hoarary_knowledge.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                    style="cursor: pointer">Horary Knowledge</a></li>
                <li><a href="javascript:void(0);">Calculation</a>
                    <ul>
                        <li><a href="#">Horary Calculation</a></li>
                        <li><a href="#">Probable Query</a></li>
                    </ul>
                </li>
                <li><a onclick="javascript:getopen(&quot;horary_illustration.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value + &quot;&amp;gropunder=&quot; + &quot;Horary&quot;)"
                    style="cursor: pointer">Horary Illustration</a></li>
                <li><a href="#">About us</a></li>
                <li><a onclick="javascript:getopen1(&quot;login.aspx&quot;)" style="cursor: pointer">
                    Log Out</a></li>
            </ul>
        </li>
        <li><a>Natal</a>
            <ul>
                <li><a href="#">My Account</a></li>
                <li><a href="#">Natal Yoga</a></li>
                <li><a href="#">Natal Predictive</a></li>
                <li><a onclick="javascript:getopen(&quot;significator.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                    style="cursor: pointer">Natal Significators</a></li>
                <li><a onclick="javascript:getopen(&quot;astro_tree_view.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                    style="cursor: pointer">Natal Knowledge</a></li>
                <li><a href="javascript:void(0);">Research Tool</a>
                    <ul>
                        <li><a onclick="javascript:getopen(&quot;ResearchTool.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                            style="cursor: pointer">Planets in Various Awastha’s in Varga’s </a></li>
                        <li><a onclick="javascript:getopen(&quot;ResearchTool_awastha.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                            style="cursor: pointer">Planets in Awastha’s – Planetary war etc</a></li>
                        <li><a onclick="javascript:getopen(&quot;researchtool_conj_rashi.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value+ &quot;&amp;filt=&quot; + &quot;Without Conjunction&quot;)"
                            style="cursor: pointer">Planets in Rashi’s &amp; House’s in Varga’s</a></li>
                        <li><a onclick="javascript:getopen(&quot;researchtool_conj_rashi.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value+ &quot;&amp;filt=&quot; + &quot;With Conjunction&quot;)"
                            style="cursor: pointer">Conjunction of Chosen Planets in Rashi and Houses in Varga’s</a></li>
                        <li><a onclick="javascript:getopen(&quot;researchtool_conjunction.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                            style="cursor: pointer">Conjunction of chosen Planets in Varga’s</a></li>
                        <li><a onclick="javascript:getopen(&quot;research_tool_any.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                            style="cursor: pointer">Conjunction of Planets – Number of Planets</a></li>
                        <li><a onclick="javascript:getopen(&quot;researchtool_nakshatra.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value+ &quot;&amp;filt=&quot; + &quot;Without Conjunction&quot;)"
                            style="cursor: pointer">Search the Single or Multiple Planets on Basis of Multiple
                            Nakashtra/Constellation</a></li>
                        <li><a onclick="javascript:getopen(&quot;researchtool_nakshatra.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value+ &quot;&amp;filt=&quot; + &quot;With Conjunction&quot;)"
                            style="cursor: pointer">Search the Conjuction of Planets in Single or Multiple Nakashtra’s/Constellation’s</a></li>
                        <li><a onclick="javascript:getopen(&quot;researchtool_aspect.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                            style="cursor: pointer">Search for Aspects of Planet’s</a></li>
                        <li><a onclick="javascript:getopen(&quot;research_dashamsha.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                            style="cursor: pointer">Search for Awastha of Planets in Dashamsha</a></li>
                        <li><a onclick="javascript:getopen(&quot;ResearchTool_Driskkan.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)"
                            style="cursor: pointer">Driskkan Division</a></li>
                    </ul>
                </li>
                <li><a href="#">Natal Calculation</a></li>
                <li><a href="#">Remedial</a></li>
                <li><a onclick="javascript:getopen(&quot;horary_illustration.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value + &quot;&amp;gropunder=&quot; + &quot;Natal&quot;)" style="cursor:pointer">Natal Illustration</a></li>
                <li><a href="#">About Us</a></li>
                <li id="a11"><a onclick="javascript:getopen1(&quot;login.aspx&quot;)" style="cursor:pointer">Log Out</a></li>
            </ul>
        </li>
    </ul>
</div>--%>
