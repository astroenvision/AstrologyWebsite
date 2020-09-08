using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class responsive_dropdown_menu_horary_menu : System.Web.UI.UserControl
{
    string StrHtml = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //string url = HttpContext.Current.Request.Url.AbsoluteUri;
            string path = HttpContext.Current.Request.Url.AbsolutePath;
            //string host = HttpContext.Current.Request.Url.Host;

            if (path.IndexOf("/myaccount") > -1)
            {
                StrHtml = "<li><a href=\"" + ResolveUrl("~/index.html") + "\">Home</a></li>";
                StrHtml += "<li><a href='javascript:void(0);'>Calculations</a><ul>";
                StrHtml += "<li><a href='#'>Horary Calculation</a>";
                StrHtml += "<ul>";
                StrHtml += "<li><a href='#'>Hora</a></li>";
                StrHtml += "</ul>";
                StrHtml += "</li>";
                StrHtml += "<li><a href='#'>Probable Query</a>";
                StrHtml += "<ul>";
                StrHtml += "<li><a href='#'>Method 1</a></li>";
                StrHtml += "</ul>";
                StrHtml += "</li>";
                StrHtml += "</ul></li>";
                StrHtml += "<li><a href='#'>Horary Yoga</a><ul>";
                StrHtml += "<li><a href='#'>Calculate All Horary Yoga</a></li>";
                StrHtml += "<li><a href='#'>Calculate Future Horary Yoga</a></li>";
                //StrHtml += "<li><a href='#'>Calculate Karyasiddhi Yoga</a></li>";
                StrHtml += "</ul></li>";
                StrHtml += "<li><a href='#'>Horary Predictive</a></li>";
                StrHtml += "<li><a onclick='javascript:getopen(&quot;horarysignificator.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)' style='cursor: pointer;'>Significators</a></li>";
                StrHtml += "<li><a href='#'>Highlights</a>";
                StrHtml += "<ul>";
                StrHtml += "<li><a href=\"" + ResolveUrl("~/horary_astrology/horary-highlight/a-horary-glimpse/21-41.html") + "\" target='_blank'>A Horary Glimpse</a></li>";
                StrHtml += "<li><a href=\"" + ResolveUrl("~/horary_astrology/horary-highlight/software-features/22-42.html") + "\" target='_blank'>Software Features</a></li>";
                StrHtml += "</ul>";
                StrHtml += "</li>";
                StrHtml += "<li><a onclick='javascript:getopen(&quot;hoarary_knowledge.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)' style='cursor: pointer;'>Knowledge</a></li>";
                StrHtml += "<li><a onclick='javascript:getopen(&quot;horary_illustration.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value + &quot;&amp;gropunder=&quot; + &quot;Horary&quot;)' style='cursor: pointer'>Illustrations</a></li>";
                StrHtml += "<li style='float:right;'><a href=\"" + ResolveUrl("~/logout.aspx") + "\" style='cursor: pointer;border-right:none;border-left: solid 1px #fff;'>Log Out</a></li>";
                StrHtml += "<li style='float:right;'><a onclick='javascript:getopen(&quot;myaccount.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)' style='cursor: pointer;'>My Account</a></li>";
                horarymenuid.InnerHtml = StrHtml;
            }
            else if (path.IndexOf("/homenewpage") > -1)
            {
                StrHtml = "<li><a href=\"" + ResolveUrl("~/index.html") + "\">Home</a></li>";
                StrHtml += "<li><a href='javascript:void(0);'>Calculations</a><ul>";
                //StrHtml += "<li><a onclick='javascript:gethorarycalculation();' style='cursor: pointer;'>Horary Calculation</a></li>";
                //StrHtml += "<li><a onclick='javascript:getprobablequery();' style='cursor: pointer;'>Probable Query</a></li>";
                StrHtml += "<li><a href='#'>Horary Calculation</a>";
                StrHtml += "<ul>";
                StrHtml += "<li><a onclick='javascript:gethorarycalculation();' style='cursor: pointer;'>Hora</a></li>";
                StrHtml += "</ul>";
                StrHtml += "</li>";
                StrHtml += "<li><a href='#'>Probable Query</a>";
                StrHtml += "<ul>";
                StrHtml += "<li><a onclick='javascript:getprobablequery();' style='cursor: pointer;'>Method 1</a></li>";
                StrHtml += "</ul>";
                StrHtml += "</li>";
                StrHtml += "</ul></li>";
                StrHtml += "<li><a href='#'>Horary Yoga</a><ul>";
                StrHtml += "<li><a href='#'>Calculate All Horary Yoga</a></li>";
                StrHtml += "<li><a href='#'>Calculate Future Horary Yoga</a></li>";
                //StrHtml += "<li><a href='#'>Calculate Karyasiddhi Yoga</a></li>";
                StrHtml += "</ul></li>";
                StrHtml += "<li><a href='#'>Horary Predictive</a></li>";
                StrHtml += "<li><a onclick='javascript:getopen(&quot;horarysignificator.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)' style='cursor: pointer;'>Significators</a></li>";
                StrHtml += "<li><a href='#'>Highlights</a>";
                StrHtml += "<ul>";
                StrHtml += "<li><a href=\"" + ResolveUrl("~/horary_astrology/horary-highlight/a-horary-glimpse/21-41.html") + "\" target='_blank'>A Horary Glimpse</a></li>";
                StrHtml += "<li><a href=\"" + ResolveUrl("~/horary_astrology/horary-highlight/software-features/22-42.html") + "\" target='_blank'>Software Features</a></li>";
                StrHtml += "</ul>";
                StrHtml += "</li>";
                StrHtml += "<li><a onclick='javascript:getopen(&quot;hoarary_knowledge.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)' style='cursor: pointer;'>Knowledge</a></li>";
                StrHtml += "<li><a onclick='javascript:getopen(&quot;horary_illustration.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value + &quot;&amp;gropunder=&quot; + &quot;Horary&quot;)' style='cursor: pointer'>Illustrations</a></li>";
                StrHtml += "<li style='float:right;'><a href=\"" + ResolveUrl("~/logout.aspx") + "\" style='cursor: pointer;border-right:none;border-left: solid 1px #fff;'>Log Out</a></li>";
                StrHtml += "<li style='float:right;'><a onclick='javascript:getopen(&quot;myaccount.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)' style='cursor: pointer;'>My Account</a></li>";
                horarymenuid.InnerHtml = StrHtml;
            }
            else if (path.IndexOf("/vargas_chart") > -1)
            {
                StrHtml = "<li><a href=\"" + ResolveUrl("~/index.html") + "\">Home</a></li>";
                StrHtml += "<li><a href='javascript:void(0);'>Calculations</a><ul>";
                //StrHtml += " <li><a onclick='javascript:gethorarycalculation();' style='cursor: pointer;'>Horary Calculation</a></li>";
                //StrHtml += "<li><a onclick='javascript:getprobablequery();' style='cursor: pointer;'>Probable Query</a></li>";
                StrHtml += "<li><a href='#'>Horary Calculation</a>";
                StrHtml += "<ul>";
                StrHtml += "<li><a onclick='javascript:gethorarycalculation();' style='cursor: pointer;'>Hora</a></li>";
                StrHtml += "</ul>";
                StrHtml += "</li>";
                StrHtml += "<li><a href='#'>Probable Query</a>";
                StrHtml += "<ul>";
                StrHtml += "<li><a onclick='javascript:getprobablequery();' style='cursor: pointer;'>Method 1</a></li>";
                StrHtml += "</ul>";
                StrHtml += "</li>";
                StrHtml += "</ul></li>";
                StrHtml += "<li><a href='#'>Horary Yoga</a><ul>";
                StrHtml += "<li><a onclick='javascript:return calculateyogas(this)' style='cursor: pointer'>Calculate All Horary Yoga</a></li>";
                StrHtml += "<li><a onclick='javascript:return calculateyogas(this)' style='cursor: pointer'>Calculate Future Horary Yoga</a></li>";
                //StrHtml += "<li><a onclick='javascript:return calculateyogas(this)' style='cursor: pointer'>Calculate Karyasiddhi Yoga</a></li>";
                StrHtml += "</ul></li>";
                StrHtml += "<li><a onclick='javascript:return openhorcomb();' style='cursor: pointer;'>Horary Predictive</a></li>";
                StrHtml += "<li><a onclick='javascript:getopen(&quot;horarysignificator.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)' style='cursor: pointer;'>Significators</a></li>";
                StrHtml += "<li><a href='#'>Highlights</a>";
                StrHtml += "<ul>";
                StrHtml += "<li><a href=\"" + ResolveUrl("~/horary_astrology/horary-highlight/a-horary-glimpse/21-41.html") + "\" target='_blank'>A Horary Glimpse</a></li>";
                StrHtml += "<li><a href=\"" + ResolveUrl("~/horary_astrology/horary-highlight/software-features/22-42.html") + "\" target='_blank'>Software Features</a></li>";
                StrHtml += "</ul>";
                StrHtml += "</li>";
                StrHtml += "<li><a onclick='javascript:getopen(&quot;hoarary_knowledge.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)' style='cursor: pointer;'>Knowledge</a></li>";
                StrHtml += "<li><a onclick='javascript:getopen(&quot;horary_illustration.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value + &quot;&amp;gropunder=&quot; + &quot;Horary&quot;)' style='cursor: pointer'>Illustrations</a></li>";
                StrHtml += "<li style='float:right;'><a href=\"" + ResolveUrl("~/logout.aspx") + "\" style='cursor: pointer;border-right:none;border-left: solid 1px #fff;'>Log Out</a></li>";
                StrHtml += "<li style='float:right;'><a onclick='javascript:getopen(&quot;myaccount.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)' style='cursor: pointer;'>My Account</a></li>";
                Session["HoraryMenu"]=StrHtml;
                horarymenuid.InnerHtml = StrHtml;
            }
            else if (path.IndexOf("/horary_calculation") > -1)
            {
                StrHtml = "<li><a href=\"" + ResolveUrl("~/index.html") + "\">Home</a></li>";
                StrHtml += "<li><a href='javascript:void(0);'>Calculations</a><ul>";
                //StrHtml += " <li><a onclick='javascript:gethorarycalculation();' style='cursor: pointer;'>Horary Calculation</a></li>";
                //StrHtml += "<li><a onclick='javascript:getprobablequery();' style='cursor: pointer;'>Probable Query</a></li>";
                StrHtml += "<li><a href='#'>Horary Calculation</a>";
                StrHtml += "<ul>";
                StrHtml += "<li><a onclick='javascript:gethorarycalculation();' style='cursor: pointer;'>Hora</a></li>";
                StrHtml += "</ul>";
                StrHtml += "</li>";
                StrHtml += "<li><a href='#'>Probable Query</a>";
                StrHtml += "<ul>";
                StrHtml += "<li><a onclick='javascript:getprobablequery();' style='cursor: pointer;'>Method 1</a></li>";
                StrHtml += "</ul>";
                StrHtml += "</li>";
                StrHtml += "</ul></li>";
                StrHtml += "<li><a href='#'>Horary Yoga</a><ul>";
                StrHtml += "<li><a href='#'>Calculate All Horary Yoga</a></li>";
                StrHtml += "<li><a href='#'>Calculate Future Horary Yoga</a></li>";
                //StrHtml += "<li><a href='#'>Calculate Karyasiddhi Yoga</a></li>";
                StrHtml += "</ul></li>";
                StrHtml += " <li><a href='#'>Horary Predictive</a></li>";
                StrHtml += "<li><a onclick='javascript:getopen(&quot;horarysignificator.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)' style='cursor: pointer;'>Significators</a></li>";
                StrHtml += "<li><a href='#'>Highlights</a>";
                StrHtml += "<ul>";
                StrHtml += "<li><a href=\"" + ResolveUrl("~/horary_astrology/horary-highlight/a-horary-glimpse/21-41.html") + "\" target='_blank'>A Horary Glimpse</a></li>";
                StrHtml += "<li><a href=\"" + ResolveUrl("~/horary_astrology/horary-highlight/software-features/22-42.html") + "\" target='_blank'>Software Features</a></li>";
                StrHtml += "</ul>";
                StrHtml += "</li>";
                StrHtml += "<li><a onclick='javascript:getopen(&quot;hoarary_knowledge.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)' style='cursor: pointer;'>Knowledge</a></li>";
                StrHtml += "<li><a onclick='javascript:getopen(&quot;horary_illustration.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value + &quot;&amp;gropunder=&quot; + &quot;Horary&quot;)' style='cursor: pointer'>Illustrations</a></li>";
                StrHtml += "<li style='float:right;'><a href=\"" + ResolveUrl("~/logout.aspx") + "\" style='cursor: pointer;border-right:none;border-left: solid 1px #fff;'>Log Out</a></li>";
                StrHtml += "<li style='float:right;'><a onclick='javascript:getopen(&quot;myaccount.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)' style='cursor: pointer;'>My Account</a></li>";
                horarymenuid.InnerHtml = StrHtml;
            }
            else if (path.IndexOf("/yogas") > -1)
            {
                //Page == myaccount ,home , horary_illustration ,horarysignificator, hoarary_knowledge, About us, Logout
                StrHtml = "<li><a href=\"" + ResolveUrl("~/index.html") + "\">Home</a></li>";
                StrHtml += "<li><a href='javascript:void(0);'>Calculations</a><ul>";
                //StrHtml += "<li><a href='#'>Horary Calculation</a>";
                //StrHtml += "</li>";
                //StrHtml += "<li><a href='#'>Probable Query</a></li>";
                StrHtml += "<li><a href='#'>Horary Calculation</a>";
                StrHtml += "<ul>";
                StrHtml += "<li><a href='#'>Hora</a></li>";
                StrHtml += "</ul>";
                StrHtml += "</li>";
                StrHtml += "<li><a href='#'>Probable Query</a>";
                StrHtml += "<ul>";
                StrHtml += "<li><a href='#'>Method 1</a></li>";
                StrHtml += "</ul>";
                StrHtml += "</li>";
                StrHtml += "</ul></li>";
                StrHtml += "<li><a href='#'>Horary Yoga</a><ul>";
                StrHtml += "<li><a href='#'>Calculate All Horary Yoga</a></li>";
                StrHtml += "<li><a href='#'>Calculate Future Horary Yoga</a></li>";
                //StrHtml += "<li><a href='#'>Calculate Karyasiddhi Yoga</a></li>";
                StrHtml += "</ul></li>";
                StrHtml += " <li><a href='#'>Horary Predictive</a></li>";
                StrHtml += "<li><a onclick='javascript:getopen(&quot;horarysignificator.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)' style='cursor: pointer;'>Significators</a></li>";
                StrHtml += "<li><a href='#'>Highlights</a>";
                StrHtml += "<ul>";
                StrHtml += "<li><a href=\"" + ResolveUrl("~/horary_astrology/horary-highlight/a-horary-glimpse/21-41.html") + "\" target='_blank'>A Horary Glimpse</a></li>";
                StrHtml += "<li><a href=\"" + ResolveUrl("~/horary_astrology/horary-highlight/software-features/22-42.html") + "\" target='_blank'>Software Features</a></li>";
                StrHtml += "</ul>";
                StrHtml += "</li>";
                StrHtml += "<li><a onclick='javascript:getopen(&quot;hoarary_knowledge.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)' style='cursor: pointer;'>Knowledge</a></li>";
                StrHtml += "<li><a onclick='javascript:getopen(&quot;horary_illustration.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value + &quot;&amp;gropunder=&quot; + &quot;Horary&quot;)' style='cursor: pointer'>Illustrations</a></li>";
                StrHtml += "<li style='float:right;'><a href=\"" + ResolveUrl("~/logout.aspx") + "\" style='cursor: pointer;border-right:none;border-left: solid 1px #fff;'>Log Out</a></li>";
                StrHtml += "<li style='float:right;'><a onclick='javascript:getopen(&quot;myaccount.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)' style='cursor: pointer;'>My Account</a></li>";
                horarymenuid.InnerHtml = StrHtml;
            }
            else
            {
                //string abcd = Session["HoraryMenu"].ToString();
                //Page == myaccount ,home , horary_illustration ,horarysignificator, hoarary_knowledge, About us, Logout
                StrHtml = "<li><a href=\"" + ResolveUrl("~/index.html") + "\">Home</a></li>";
                StrHtml += "<li><a href='javascript:void(0);'>Calculations</a><ul>";
                //StrHtml += "<li><a href='#'>Horary Calculation</a>";
                //StrHtml += "</li>";
                //StrHtml += "<li><a href='#'>Probable Query</a></li>";
                StrHtml += "<li><a href='#'>Horary Calculation</a>";
                StrHtml += "<ul>";
                StrHtml += "<li><a href='#'>Hora</a></li>";
                StrHtml += "</ul>";
                StrHtml += "</li>";
                StrHtml += "<li><a href='#'>Probable Query</a>";
                StrHtml += "<ul>";
                StrHtml += "<li><a href='#'>Method 1</a></li>";
                StrHtml += "</ul>";
                StrHtml += "</li>";
                StrHtml += "</ul></li>";
                StrHtml += "<li><a href='#'>Horary Yoga</a><ul>";
                StrHtml += "<li><a href='#'>Calculate All Horary Yoga</a></li>";
                StrHtml += "<li><a href='#'>Calculate Future Horary Yoga</a></li>";
                //StrHtml += "<li><a href='#'>Calculate Karyasiddhi Yoga</a></li>";
                StrHtml += "</ul></li>";
                StrHtml += " <li><a href='#'>Horary Predictive</a></li>";
                StrHtml += "<li><a onclick='javascript:getopen(&quot;horarysignificator.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)' style='cursor: pointer;'>Significators</a></li>";
                StrHtml += "<li><a href='#'>Highlights</a>";
                StrHtml += "<ul>";
                StrHtml += "<li><a href=\"" + ResolveUrl("~/horary_astrology/horary-highlight/a-horary-glimpse/21-41.html") + "\" target='_blank'>A Horary Glimpse</a></li>";
                StrHtml += "<li><a href=\"" + ResolveUrl("~/horary_astrology/horary-highlight/software-features/22-42.html") + "\" target='_blank'>Software Features</a></li>";
                StrHtml += "</ul>";
                StrHtml += "</li>";
                StrHtml += "<li><a onclick='javascript:getopen(&quot;hoarary_knowledge.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)' style='cursor: pointer;'>Knowledge</a></li>";
                StrHtml += "<li><a onclick='javascript:getopen(&quot;horary_illustration.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value + &quot;&amp;gropunder=&quot; + &quot;Horary&quot;)' style='cursor: pointer'>Illustrations</a></li>";
                StrHtml += "<li style='float:right;'><a href=\"" + ResolveUrl("~/logout.aspx") + "\" style='cursor: pointer;border-right:none;border-left: solid 1px #fff;'>Log Out</a></li>";
                StrHtml += "<li style='float:right;'><a onclick='javascript:getopen(&quot;myaccount.aspx?usermail=&quot;+ document.getElementById(&quot;hdnuser&quot;).value)' style='cursor: pointer;'>My Account</a></li>";
                horarymenuid.InnerHtml = StrHtml;
            }
        }
    }
}
