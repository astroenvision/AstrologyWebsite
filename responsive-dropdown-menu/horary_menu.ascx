﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="horary_menu.ascx.cs" Inherits="responsive_dropdown_menu_horary_menu" %>


<link rel="stylesheet" href="<%=ResolveUrl("css/style.css") %>">

<nav id="nav" role="navigation"> <a href="#nav" title="Show navigation">Show navigation</a> <a href="#" title="Hide navigation">Hide navigation</a>
      <ul class="clearfix">
    <li><a href="">Home</a></li>
    <li> <a href=""><span>Blog</span></a>
          <ul>
        <li><a href="">Design</a></li>
        <li><a href="">HTML</a></li>
        <li><a href="">CSS</a></li>
        <li><a href="">JavaScript</a></li>
      </ul>
        </li>
    <li> <a href=""><span>Work</span></a>
          <ul>
        <li><a href="">Web Design</a></li>
        <li><a href="">Typography</a></li>
        <li><a href="">Front-End</a></li>
      </ul>
        </li>
    <li><a href="">About</a></li>
  </ul>
</nav>




<script src="http://osvaldas.info/examples/main.js"></script>

<script src="http://osvaldas.info/examples/drop-down-navigation-touch-friendly-and-responsive/doubletaptogo.js"></script> 
  
<script>
	$( function()
	{
		$( '#nav li:has(ul)' ).doubleTapToGo();
	});
</script>
  