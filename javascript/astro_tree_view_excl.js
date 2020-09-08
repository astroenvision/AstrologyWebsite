
var f = "";
var filter = "";
function openroot(event) {
    if (event.keyCode == 38 || event.keyCode == 40) {

        if (document.activeElement.id == 'root') {
            document.getElementById('root_list').focus();
            return false;
           
        }

        if (document.activeElement.id == 'filter1') {
            document.getElementById('filter1_list').focus();
            return false;
        }

        if (document.activeElement.id == 'filter2') {
            document.getElementById('filter2_list').focus();
            return false;
        }

        if (document.activeElement.id == 'filter3') {
            document.getElementById('filter3_list').focus();
            return false;
        }

        if (document.activeElement.id == 'filter4') {
            document.getElementById('filter4_list').focus();
            return false;
        }
 if (document.activeElement.id == 'filter5') {
            document.getElementById('filter5_list').focus();
            return false;
        }
         if (document.activeElement.id == 'filter6') {
            document.getElementById('filter6_list').focus();
            return false;
        }
    }

    if (event.keyCode == 27) {
       
        if (document.activeElement.id == 'root') {
            document.getElementById('root_list').style.display = 'none';
                  return false;
              }
              if (document.activeElement.id == 'filter1') {
                  document.getElementById('filter1_list').style.display = 'none';
                  return false;
              }
              if (document.activeElement.id == 'filter2') {
                  document.getElementById('filter2_list').style.display = 'none';
                  return false;
              }
              if (document.activeElement.id == 'filter3') {
                  document.getElementById('filter3_list').style.display = 'none';
                  return false;
              }
              if (document.activeElement.id == 'filter4') {
                  document.getElementById('filter4_list').style.display = 'none';
                  return false;
              }
              
               if (document.activeElement.id == 'filter5') {
                  document.getElementById('filter5_list').style.display = 'none';
                  return false;
              }
              
               if (document.activeElement.id == 'filter6') {
                  document.getElementById('filter6_list').style.display = 'none';
                  return false;
              }
        return false;
    }
    var drop_down = document.getElementById('drop_select').value 
    if (document.activeElement.id== 'root')
    {
        filter = document.getElementById('root').value
        var under_node_id = '0';
        if (filter == "0") {
            document.getElementById("root_list").value = "";
            document.getElementById('root_list').style.display = 'none';
        }
        else {
            var res = astro_tree_view_excl.show_node_data(filter, under_node_id,drop_down, exec_gridcall);
            return false;
        }
    }
    if (document.activeElement.id== 'filter1')
    {
        filter = document.getElementById('filter1').value
        var under_node_id = document.getElementById('hidden_root').value;
        if (filter == "0") {
            document.getElementById("filter1_list").value = "";
            document.getElementById('filter1_list').style.display = 'none';
        }
        else {
            var res = astro_tree_view_excl.show_node_data(filter, under_node_id, drop_down, exec_gridcall);
            return false;
        }
    }
    if (document.activeElement.id == 'filter2') {
        var under_node_id = document.getElementById('hidden_filter1').value;
        filter = document.getElementById('filter2').value
        if (filter == "0") {
            document.getElementById("filter2_list").value = "";
            document.getElementById('filter2_list').style.display = 'none';
        }
        else {
            var res = astro_tree_view_excl.show_node_data(filter, under_node_id, drop_down, exec_gridcall);
            return false;
        }
    }
    if (document.activeElement.id == 'filter3') {
        var under_node_id = document.getElementById('hidden_filter2').value;
        filter = document.getElementById('filter3').value
        if (filter == "0") {
            document.getElementById("filter3_list").value = "";
            document.getElementById('filter3_list').style.display = 'none';
        
        }
        else {
            var res = astro_tree_view_excl.show_node_data(filter, under_node_id, drop_down, exec_gridcall);
            return false;
        }
    }
    if (document.activeElement.id == 'filter4') {
        var under_node_id = document.getElementById('hidden_filter3').value;
        filter = document.getElementById('filter4').value
        if (filter == "0") {
            document.getElementById("filter4_list").value = "";
            document.getElementById('filter4_list').style.display = 'none';
        }
        else {
            var res = astro_tree_view_excl.show_node_data(filter, under_node_id, drop_down, exec_gridcall);
            return false;
        }
    }
    
    if (document.activeElement.id == 'filter5') {
        var under_node_id = document.getElementById('hidden_filter4').value;
        filter = document.getElementById('filter5').value
        if (filter == "0") {
            document.getElementById("filter5_list").value = "";
            document.getElementById('filter5_list').style.display = 'none';
        }
        else {
            var res = astro_tree_view_excl.show_node_data(filter, under_node_id, drop_down, exec_gridcall);
            return false;
        }
    }
    
    if (document.activeElement.id == 'filter6') {
        var under_node_id = document.getElementById('hidden_filter5').value;
        filter = document.getElementById('filter6').value
        if (filter == "0") {
            document.getElementById("filter6_list").value = "";
            document.getElementById('filter6_list').style.display = 'none';
        }
        else {
            var res = astro_tree_view_excl.show_node_data(filter, under_node_id, drop_down, exec_gridcall);
            return false;
        }
    }
    return false;

}

var dsgrid = "";
function exec_gridcall(val) {

     dsgrid = val.value;
     // var dsgrid = exec_grid
    
    
     if (document.activeElement.id == 'root') {
         if (dsgrid.Tables[0].Rows.length > 0) {
            
             document.getElementById('root_list').style.display = 'block';

             var pkgitem = document.getElementById("root_list");

             pkgitem.options.length = 0;
             pkgitem.options[0] = new Option("-Select Root-", "0");
             pkgitem.options.length = 1;

             for (var i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
                 pkgitem.options[pkgitem.options.length] = new Option(dsgrid.Tables[0].Rows[i].NODE_NAME, dsgrid.Tables[0].Rows[i].NODE_NAME + "~" + dsgrid.Tables[0].Rows[i].NODE_ID, dsgrid.Tables[0].Rows[i].NODE_ID);
                 pkgitem.options.length;
             }
             var aTag = eval(document.getElementById('root'))
             var btag;
             var leftpos = 0;
             var toppos = 0;

             do {
                 aTag = eval(aTag.offsetParent);

                 leftpos += aTag.offsetLeft;
                 toppos += aTag.offsetTop;
                 btag = eval(aTag)

             }
             while (aTag.tagName != "BODY" && aTag.tagName != "HTML");

             var tot = document.getElementById('list_div').scrollLeft;

             var scrolltop = document.getElementById('list_div').scrollTop;
             document.getElementById('list_div').style.display = 'block';

             document.getElementById('list_div').style.left = document.getElementById('root').offsetLeft + leftpos - tot + "px";
             document.getElementById('list_div').style.top = document.getElementById('root').offsetTop + toppos - scrolltop + "px";
             //document.getElementById('root').focus();

             return false;
         }
         else {
             document.getElementById("root_list").value = "";
             document.getElementById('list_div').style.display = 'none';
             return false;
         }
    }


    if (document.activeElement.id == 'filter1') {
        if (dsgrid.Tables[0].Rows.length > 0) {
            document.getElementById('filter1_list').style.display = 'block';

            var pkgitem = document.getElementById("filter1_list");

            pkgitem.options.length = 0;
            pkgitem.options[0] = new Option("-Select Filter-", "0");
            pkgitem.options.length = 1;

            for (var i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
                pkgitem.options[pkgitem.options.length] = new Option(dsgrid.Tables[0].Rows[i].NODE_NAME, dsgrid.Tables[0].Rows[i].NODE_NAME + "~" + dsgrid.Tables[0].Rows[i].NODE_ID, dsgrid.Tables[0].Rows[i].NODE_ID);
                pkgitem.options.length;
            }
            var aTag = eval(document.getElementById('filter1'))
            var btag;
            var leftpos = 0;
            var toppos = 0;

            do {
                aTag = eval(aTag.offsetParent);

                leftpos += aTag.offsetLeft;
                toppos += aTag.offsetTop;
                btag = eval(aTag)

            }
            while (aTag.tagName != "BODY" && aTag.tagName != "HTML");

            var tot = document.getElementById('filter1_div').scrollLeft;

            var scrolltop = document.getElementById('filter1_div').scrollTop;
            document.getElementById('filter1_div').style.display = 'block';

            document.getElementById('filter1_div').style.left = document.getElementById('filter1').offsetLeft + leftpos - tot + "px";
            document.getElementById('filter1_div').style.top = document.getElementById('filter1').offsetTop + toppos - scrolltop + "px";
           // document.getElementById('filter1').focus();

            return false;
        }
        else {
            document.getElementById("filter1_list").value = "";
            document.getElementById('filter1_list').style.display = 'none';
            return false;
        }
    }



    if (document.activeElement.id == 'filter2') {
        if (dsgrid.Tables[0].Rows.length > 0) {
            document.getElementById('filter2_list').style.display = 'block';

            var pkgitem = document.getElementById("filter2_list");

            pkgitem.options.length = 0;
            pkgitem.options[0] = new Option("-Select Filter-", "0");
            pkgitem.options.length = 1;

            for (var i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
                pkgitem.options[pkgitem.options.length] = new Option(dsgrid.Tables[0].Rows[i].NODE_NAME, dsgrid.Tables[0].Rows[i].NODE_NAME + "~" + dsgrid.Tables[0].Rows[i].NODE_ID, dsgrid.Tables[0].Rows[i].NODE_ID);
                pkgitem.options.length;
            }
            var aTag = eval(document.getElementById('filter2'))
            var btag;
            var leftpos = 0;
            var toppos = 0;

            do {
                aTag = eval(aTag.offsetParent);

                leftpos += aTag.offsetLeft;
                toppos += aTag.offsetTop;
                btag = eval(aTag)

            }
            while (aTag.tagName != "BODY" && aTag.tagName != "HTML");

            var tot = document.getElementById('filter2_div').scrollLeft;

            var scrolltop = document.getElementById('filter2_div').scrollTop;
            document.getElementById('filter2_div').style.display = 'block';

            document.getElementById('filter2_div').style.left = document.getElementById('filter2').offsetLeft + leftpos - tot + "px";
            document.getElementById('filter2_div').style.top = document.getElementById('filter2').offsetTop + toppos - scrolltop + "px";
          //  document.getElementById('filter2').focus();

            return false;
        }
        else {
            document.getElementById("filter2_list").value = "";
            document.getElementById('filter2_list').style.display = 'none';
            
            return false;
        }
    }

    if (document.activeElement.id == 'filter3') {
        if (dsgrid.Tables[0].Rows.length > 0) {
            document.getElementById('filter3_list').style.display = 'block';

            var pkgitem = document.getElementById("filter3_list");

            pkgitem.options.length = 0;
            pkgitem.options[0] = new Option("-Select Filter-", "0");
            pkgitem.options.length = 1;

            for (var i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
                pkgitem.options[pkgitem.options.length] = new Option(dsgrid.Tables[0].Rows[i].NODE_NAME, dsgrid.Tables[0].Rows[i].NODE_NAME + "~" + dsgrid.Tables[0].Rows[i].NODE_ID, dsgrid.Tables[0].Rows[i].NODE_ID);
                pkgitem.options.length;
            }
            var aTag = eval(document.getElementById('filter3'))
            var btag;
            var leftpos = 0;
            var toppos = 0;

            do {
                aTag = eval(aTag.offsetParent);

                leftpos += aTag.offsetLeft;
                toppos += aTag.offsetTop;
                btag = eval(aTag)

            }
            while (aTag.tagName != "BODY" && aTag.tagName != "HTML");

            var tot = document.getElementById('filter3_div').scrollLeft;

            var scrolltop = document.getElementById('filter3_div').scrollTop;
            document.getElementById('filter3_div').style.display = 'block';

            document.getElementById('filter3_div').style.left = document.getElementById('filter2').offsetLeft + leftpos - tot + "px";
            document.getElementById('filter3_div').style.top = document.getElementById('filter2').offsetTop + toppos - scrolltop + "px";
          //  document.getElementById('filter3').focus();

            return false;
        }
        else {
            document.getElementById("filter3_list").value = "";
            document.getElementById('filter3_list').style.display = 'none';
            return false;
        }
    }


    if (document.activeElement.id == 'filter4')
     {
        if (dsgrid.Tables[0].Rows.length > 0)
         {
            document.getElementById('filter4_list').style.display = 'block';

            var pkgitem = document.getElementById("filter4_list");

            pkgitem.options.length = 0;
            pkgitem.options[0] = new Option("-Select Filter-", "0");
            pkgitem.options.length = 1;

            for (var i = 0; i < dsgrid.Tables[0].Rows.length; ++i)
             {
                pkgitem.options[pkgitem.options.length] = new Option(dsgrid.Tables[0].Rows[i].NODE_NAME, dsgrid.Tables[0].Rows[i].NODE_NAME + "~" + dsgrid.Tables[0].Rows[i].NODE_ID, dsgrid.Tables[0].Rows[i].NODE_ID);
                pkgitem.options.length;
            }
            var aTag = eval(document.getElementById('filter4'))
            var btag;
            var leftpos = 0;
            var toppos = 0;

            do
             {
                aTag = eval(aTag.offsetParent);

                leftpos += aTag.offsetLeft;
                toppos += aTag.offsetTop;
                btag = eval(aTag)

            }
            while (aTag.tagName != "BODY" && aTag.tagName != "HTML");

            var tot = document.getElementById('filter4_div').scrollLeft;

            var scrolltop = document.getElementById('filter4_div').scrollTop;
            document.getElementById('filter4_div').style.display = 'block';

            document.getElementById('filter4_div').style.left = document.getElementById('filter2').offsetLeft + leftpos - tot + "px";
            document.getElementById('filter4_div').style.top = document.getElementById('filter2').offsetTop + toppos - scrolltop + "px";
          

            return false;
        }
    
    else 
    {
        document.getElementById("filter4_list").value = "";
        document.getElementById('filter4_list').style.display = 'none';
        return false;
     }
     }
 if (document.activeElement.id == 'filter5') {
        if (dsgrid.Tables[0].Rows.length > 0) {
            document.getElementById('filter5_list').style.display = 'block';

            var pkgitem = document.getElementById("filter5_list");

            pkgitem.options.length = 0;
            pkgitem.options[0] = new Option("-Select Filter-", "0");
            pkgitem.options.length = 1;

            for (var i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
                pkgitem.options[pkgitem.options.length] = new Option(dsgrid.Tables[0].Rows[i].NODE_NAME, dsgrid.Tables[0].Rows[i].NODE_NAME + "~" + dsgrid.Tables[0].Rows[i].NODE_ID, dsgrid.Tables[0].Rows[i].NODE_ID);
                pkgitem.options.length;
            }
            var aTag = eval(document.getElementById('filter5'))
            var btag;
            var leftpos = 0;
            var toppos = 0;

            do {
                aTag = eval(aTag.offsetParent);

                leftpos += aTag.offsetLeft;
                toppos += aTag.offsetTop;
                btag = eval(aTag)

            }
            while (aTag.tagName != "BODY" && aTag.tagName != "HTML");

            var tot = document.getElementById('filter5_div').scrollLeft;

            var scrolltop = document.getElementById('filter5_div').scrollTop;
            document.getElementById('filter5_div').style.display = 'block';

            document.getElementById('filter5_div').style.left = document.getElementById('filter2').offsetLeft + leftpos - tot + "px";
            document.getElementById('filter5_div').style.top = document.getElementById('filter2').offsetTop + toppos - scrolltop + "px";
      

            return false;
        }
  
    else {
        document.getElementById("filter5_list").value = "";
        document.getElementById('filter5_list').style.display = 'none';
        return false;
     }  }
 if (document.activeElement.id == 'filter6') {
        if (dsgrid.Tables[0].Rows.length > 0) {
            document.getElementById('filter6_list').style.display = 'block';

            var pkgitem = document.getElementById("filter6_list");

            pkgitem.options.length = 0;
            pkgitem.options[0] = new Option("-Select Filter-", "0");
            pkgitem.options.length = 1;

            for (var i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
                pkgitem.options[pkgitem.options.length] = new Option(dsgrid.Tables[0].Rows[i].NODE_NAME, dsgrid.Tables[0].Rows[i].NODE_NAME + "~" + dsgrid.Tables[0].Rows[i].NODE_ID, dsgrid.Tables[0].Rows[i].NODE_ID);
                pkgitem.options.length;
            }
            var aTag = eval(document.getElementById('filter6'))
            var btag;
            var leftpos = 0;
            var toppos = 0;

            do {
                aTag = eval(aTag.offsetParent);

                leftpos += aTag.offsetLeft;
                toppos += aTag.offsetTop;
                btag = eval(aTag)

            }
            while (aTag.tagName != "BODY" && aTag.tagName != "HTML");

            var tot = document.getElementById('filter6_div').scrollLeft;

            var scrolltop = document.getElementById('filter6_div').scrollTop;
            document.getElementById('filter6_div').style.display = 'block';

            document.getElementById('filter6_div').style.left = document.getElementById('filter2').offsetLeft + leftpos - tot + "px";
            document.getElementById('filter6_div').style.top = document.getElementById('filter2').offsetTop + toppos - scrolltop + "px";
          //  document.getElementById('filter4').focus();

            return false;
        }
    
    else {
        document.getElementById("filter6_list").value = "";
        document.getElementById('filter6_list').style.display = 'none';
        return false;
     }}
}

function openrootu(event) {
    if (event.keyCode == 38 || event.keyCode == 40) {

        if (document.activeElement.id == 'rootu') {
            document.getElementById('root_listu').focus();
            return false;
        }

        if (document.activeElement.id == 'filter1u') {
            document.getElementById('filter1_listu').focus();
            return false;
        }

        if (document.activeElement.id == 'filter2u') {
            document.getElementById('filter2_listu').focus();
            return false;
        }

        if (document.activeElement.id == 'filter3u') {
            document.getElementById('filter3_listu').focus();
            return false;
        }

        if (document.activeElement.id == 'filter4u') {
            document.getElementById('filter4_listu').focus();
            return false;
        }
        
         if (document.activeElement.id == 'filter5u') {
            document.getElementById('filter5_listu').focus();
            return false;
        }
        
         if (document.activeElement.id == 'filter6u') {
            document.getElementById('filter6_listu').focus();
            return false;
        }

    }

    if (event.keyCode == 27) {

        if (document.activeElement.id == 'rootu') {
            document.getElementById('root_listu').style.display = 'none';
            return false;
        }
        if (document.activeElement.id == 'filter1u') {
            document.getElementById('filter1_listu').style.display = 'none';
            return false;
        }
        if (document.activeElement.id == 'filter2u') {
            document.getElementById('filter2_listu').style.display = 'none';
            return false;
        }
        if (document.activeElement.id == 'filter3u') {
            document.getElementById('filter3_listu').style.display = 'none';
            return false;
        }
        if (document.activeElement.id == 'filter4u') {
            document.getElementById('filter4_listu').style.display = 'none';
            return false;
        }
        
         if (document.activeElement.id == 'filter5u') {
            document.getElementById('filter5_listu').style.display = 'none';
            return false;
        }
        
         if (document.activeElement.id == 'filter6u') {
            document.getElementById('filter6_listu').style.display = 'none';
            return false;
        }
        return false;
    }
    var drop_down = document.getElementById('drop_select').value 
    if (document.activeElement.id== 'rootu')
    {
        filter = document.getElementById('rootu').value
        var under_node_id = '0';
        if (filter == "0") {
            document.getElementById("root_listu").value = "";
            document.getElementById('root_listu').style.display = 'none';
        }
        else {
            var res = astro_tree_view_excl.show_node_data(filter, under_node_id,drop_down, exec_gridcallu);
            return false;
        }
    }
    if (document.activeElement.id== 'filter1u')
    {
        filter = document.getElementById('filter1u').value
        var under_node_id = document.getElementById('hidden_rootu').value;
        if (filter == "0") {
            document.getElementById("filter1_listu").value = "";
            document.getElementById('filter1_listu').style.display = 'none';
        }
        else {
            var res = astro_tree_view_excl.show_node_data(filter, under_node_id, drop_down, exec_gridcallu);
            return false;
        }
    }
    if (document.activeElement.id == 'filter2u') {
        var under_node_id = document.getElementById('hidden_filter1u').value;
        filter = document.getElementById('filter2u').value
        if (filter == "0") {
            document.getElementById("filter2_listu").value = "";
            document.getElementById('filter2_listu').style.display = 'none';
        }
        else {
            var res = astro_tree_view_excl.show_node_data(filter, under_node_id, drop_down, exec_gridcallu);
            return false;
        }
    }
    if (document.activeElement.id == 'filter3u') {
        var under_node_id = document.getElementById('hidden_filter2u').value;
        filter = document.getElementById('filter3u').value
        if (filter == "0") {
            document.getElementById("filter3_listu").value = "";
            document.getElementById('filter3_listu').style.display = 'none';
        
        }
        else {
            var res = astro_tree_view_excl.show_node_data(filter, under_node_id, drop_down, exec_gridcallu);
            return false;
        }
    }
    if (document.activeElement.id == 'filter4u') {
        var under_node_id = document.getElementById('hidden_filter3u').value;
        filter = document.getElementById('filter4u').value
        if (filter == "0") {
            document.getElementById("filter4_listu").value = "";
            document.getElementById('filter4_listu').style.display = 'none';
        }
        else {
            var res = astro_tree_view_excl.show_node_data(filter, under_node_id, drop_down, exec_gridcallu);
            return false;
        }
    }
    
     if (document.activeElement.id == 'filter5u') {
        var under_node_id = document.getElementById('hidden_filter4u').value;
        filter = document.getElementById('filter5u').value
        if (filter == "0") {
            document.getElementById("filter5_listu").value = "";
            document.getElementById('filter5_listu').style.display = 'none';
        }
        else {
            var res = astro_tree_view_excl.show_node_data(filter, under_node_id, drop_down, exec_gridcallu);
            return false;
        }
    }
    
     if (document.activeElement.id == 'filter6u') {
        var under_node_id = document.getElementById('hidden_filter5u').value;
        filter = document.getElementById('filter6u').value
        if (filter == "0") {
            document.getElementById("filter6_listu").value = "";
            document.getElementById('filter6_listu').style.display = 'none';
        }
        else {
            var res = astro_tree_view_excl.show_node_data(filter, under_node_id, drop_down, exec_gridcallu);
            return false;
        }
    }
    return false;

}

function exec_gridcallu(val) {

     dsgrid = val.value;
     // var dsgrid = exec_grid
    
   
     if (document.activeElement.id == 'rootu') {
         if (dsgrid.Tables[0].Rows.length > 0) {
             document.getElementById('root_listu').style.display = 'block';

             var pkgitem = document.getElementById("root_listu");

             pkgitem.options.length = 0;
             pkgitem.options[0] = new Option("-Select Root-", "0");
             pkgitem.options.length = 1;

             for (var i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
                 pkgitem.options[pkgitem.options.length] = new Option(dsgrid.Tables[0].Rows[i].NODE_NAME, dsgrid.Tables[0].Rows[i].NODE_NAME + "~" + dsgrid.Tables[0].Rows[i].NODE_ID, dsgrid.Tables[0].Rows[i].NODE_ID);
                 pkgitem.options.length;
             }
             var aTag = eval(document.getElementById('rootu'))
             var btag;
             var leftpos = 0;
             var toppos = 0;

             do {
                 aTag = eval(aTag.offsetParent);

                 leftpos += aTag.offsetLeft;
                 toppos += aTag.offsetTop;
                 btag = eval(aTag)

             }
             while (aTag.tagName != "BODY" && aTag.tagName != "HTML");

             var tot = document.getElementById('list_divu').scrollLeft;

             var scrolltop = document.getElementById('list_divu').scrollTop;
             document.getElementById('list_divu').style.display = 'block';

             document.getElementById('list_divu').style.left = document.getElementById('rootu').offsetLeft + leftpos - tot + "px";
             document.getElementById('list_divu').style.top = document.getElementById('rootu').offsetTop + toppos - scrolltop + "px";
           //  document.getElementById('rootu').focus();

             return false;
         }
         else {
             document.getElementById("root_listu").value = "";
             document.getElementById('list_divu').style.display = 'none';
             return false;
         }
    }


    if (document.activeElement.id == 'filter1u') {
        if (dsgrid.Tables[0].Rows.length > 0) {
            document.getElementById('filter1_listu').style.display = 'block';

            var pkgitem = document.getElementById("filter1_listu");

            pkgitem.options.length = 0;
            pkgitem.options[0] = new Option("-Select Filter-", "0");
            pkgitem.options.length = 1;

            for (var i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
                pkgitem.options[pkgitem.options.length] = new Option(dsgrid.Tables[0].Rows[i].NODE_NAME, dsgrid.Tables[0].Rows[i].NODE_NAME + "~" + dsgrid.Tables[0].Rows[i].NODE_ID, dsgrid.Tables[0].Rows[i].NODE_ID);
                pkgitem.options.length;
            }
            var aTag = eval(document.getElementById('filter1u'))
            var btag;
            var leftpos = 0;
            var toppos = 0;

            do {
                aTag = eval(aTag.offsetParent);

                leftpos += aTag.offsetLeft;
                toppos += aTag.offsetTop;
                btag = eval(aTag)

            }
            while (aTag.tagName != "BODY" && aTag.tagName != "HTML");

            var tot = document.getElementById('filter1_divu').scrollLeft;

            var scrolltop = document.getElementById('filter1_divu').scrollTop;
            document.getElementById('filter1_divu').style.display = 'block';

            document.getElementById('filter1_divu').style.left = document.getElementById('filter1u').offsetLeft + leftpos - tot + "px";
            document.getElementById('filter1_divu').style.top = document.getElementById('filter1u').offsetTop + toppos - scrolltop + "px";
          //  document.getElementById('filter1u').focus();

            return false;
        }
        else {
            document.getElementById("filter1_listu").value = "";
            document.getElementById('filter1_listu').style.display = 'none';
            return false;
        }
    }



    if (document.activeElement.id == 'filter2u') {
        if (dsgrid.Tables[0].Rows.length > 0) {
            document.getElementById('filter2_listu').style.display = 'block';

            var pkgitem = document.getElementById("filter2_listu");

            pkgitem.options.length = 0;
            pkgitem.options[0] = new Option("-Select Filter-", "0");
            pkgitem.options.length = 1;

            for (var i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
                pkgitem.options[pkgitem.options.length] = new Option(dsgrid.Tables[0].Rows[i].NODE_NAME, dsgrid.Tables[0].Rows[i].NODE_NAME + "~" + dsgrid.Tables[0].Rows[i].NODE_ID, dsgrid.Tables[0].Rows[i].NODE_ID);
                pkgitem.options.length;
            }
            var aTag = eval(document.getElementById('filter2u'))
            var btag;
            var leftpos = 0;
            var toppos = 0;

            do {
                aTag = eval(aTag.offsetParent);

                leftpos += aTag.offsetLeft;
                toppos += aTag.offsetTop;
                btag = eval(aTag)

            }
            while (aTag.tagName != "BODY" && aTag.tagName != "HTML");

            var tot = document.getElementById('filter2_divu').scrollLeft;

            var scrolltop = document.getElementById('filter2_divu').scrollTop;
            document.getElementById('filter2_divu').style.display = 'block';

            document.getElementById('filter2_divu').style.left = document.getElementById('filter2u').offsetLeft + leftpos - tot + "px";
            document.getElementById('filter2_divu').style.top = document.getElementById('filter2u').offsetTop + toppos - scrolltop + "px";
         //   document.getElementById('filter2u').focus();

            return false;
        }
        else {
            document.getElementById("filter2_listu").value = "";
            document.getElementById('filter2_listu').style.display = 'none';
            
            return false;
        }
    }

    if (document.activeElement.id == 'filter3u') {
        if (dsgrid.Tables[0].Rows.length > 0) {
            document.getElementById('filter3_listu').style.display = 'block';

            var pkgitem = document.getElementById("filter3_listu");

            pkgitem.options.length = 0;
            pkgitem.options[0] = new Option("-Select Filter-", "0");
            pkgitem.options.length = 1;

            for (var i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
                pkgitem.options[pkgitem.options.length] = new Option(dsgrid.Tables[0].Rows[i].NODE_NAME, dsgrid.Tables[0].Rows[i].NODE_NAME + "~" + dsgrid.Tables[0].Rows[i].NODE_ID, dsgrid.Tables[0].Rows[i].NODE_ID);
                pkgitem.options.length;
            }
            var aTag = eval(document.getElementById('filter3u'))
            var btag;
            var leftpos = 0;
            var toppos = 0;

            do {
                aTag = eval(aTag.offsetParent);

                leftpos += aTag.offsetLeft;
                toppos += aTag.offsetTop;
                btag = eval(aTag)

            }
            while (aTag.tagName != "BODY" && aTag.tagName != "HTML");

            var tot = document.getElementById('filter3_divu').scrollLeft;

            var scrolltop = document.getElementById('filter3_divu').scrollTop;
            document.getElementById('filter3_divu').style.display = 'block';

            document.getElementById('filter3_divu').style.left = document.getElementById('filter2u').offsetLeft + leftpos - tot + "px";
            document.getElementById('filter3_divu').style.top = document.getElementById('filter2u').offsetTop + toppos - scrolltop + "px";
         //   document.getElementById('filter3u').focus();

            return false;
        }
        else {
            document.getElementById("filter3_listu").value = "";
            document.getElementById('filter3_listu').style.display = 'none';
            return false;
        }
    }


    if (document.activeElement.id == 'filter4u') {
        if (dsgrid.Tables[0].Rows.length > 0) {
            document.getElementById('filter4_listu').style.display = 'block';

            var pkgitem = document.getElementById("filter4_listu");

            pkgitem.options.length = 0;
            pkgitem.options[0] = new Option("-Select Filter-", "0");
            pkgitem.options.length = 1;

            for (var i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
                pkgitem.options[pkgitem.options.length] = new Option(dsgrid.Tables[0].Rows[i].NODE_NAME, dsgrid.Tables[0].Rows[i].NODE_NAME + "~" + dsgrid.Tables[0].Rows[i].NODE_ID, dsgrid.Tables[0].Rows[i].NODE_ID);
                pkgitem.options.length;
            }
            var aTag = eval(document.getElementById('filter4u'))
            var btag;
            var leftpos = 0;
            var toppos = 0;

            do {
                aTag = eval(aTag.offsetParent);

                leftpos += aTag.offsetLeft;
                toppos += aTag.offsetTop;
                btag = eval(aTag)

            }
            while (aTag.tagName != "BODY" && aTag.tagName != "HTML");

            var tot = document.getElementById('filter4_divu').scrollLeft;

            var scrolltop = document.getElementById('filter4_divu').scrollTop;
            document.getElementById('filter4_divu').style.display = 'block';

            document.getElementById('filter4_divu').style.left = document.getElementById('filter2u').offsetLeft + leftpos - tot + "px";
            document.getElementById('filter4_divu').style.top = document.getElementById('filter2u').offsetTop + toppos - scrolltop + "px";
        //    document.getElementById('filter4u').focus();

            return false;
        }
   
    else {
        document.getElementById("filter4_listu").value = "";
        document.getElementById('filter4_listu').style.display = 'none';
        return false;
     } }


 if (document.activeElement.id == 'filter5u') {
        if (dsgrid.Tables[0].Rows.length > 0) {
            document.getElementById('filter5_listu').style.display = 'block';

            var pkgitem = document.getElementById("filter5_listu");

            pkgitem.options.length = 0;
            pkgitem.options[0] = new Option("-Select Filter-", "0");
            pkgitem.options.length = 1;

            for (var i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
                pkgitem.options[pkgitem.options.length] = new Option(dsgrid.Tables[0].Rows[i].NODE_NAME, dsgrid.Tables[0].Rows[i].NODE_NAME + "~" + dsgrid.Tables[0].Rows[i].NODE_ID, dsgrid.Tables[0].Rows[i].NODE_ID);
                pkgitem.options.length;
            }
            var aTag = eval(document.getElementById('filter5u'))
            var btag;
            var leftpos = 0;
            var toppos = 0;

            do {
                aTag = eval(aTag.offsetParent);

                leftpos += aTag.offsetLeft;
                toppos += aTag.offsetTop;
                btag = eval(aTag)

            }
            while (aTag.tagName != "BODY" && aTag.tagName != "HTML");

            var tot = document.getElementById('filter5_divu').scrollLeft;

            var scrolltop = document.getElementById('filter5_divu').scrollTop;
            document.getElementById('filter5_divu').style.display = 'block';

            document.getElementById('filter5_divu').style.left = document.getElementById('filter2u').offsetLeft + leftpos - tot + "px";
            document.getElementById('filter5_divu').style.top = document.getElementById('filter2u').offsetTop + toppos - scrolltop + "px";
        //    document.getElementById('filter4u').focus();

            return false;
        }
    
    else {
        document.getElementById("filter5_listu").value = "";
        document.getElementById('filter5_listu').style.display = 'none';
        return false;
     }}
 if (document.activeElement.id == 'filter6u') {
        if (dsgrid.Tables[0].Rows.length > 0) {
            document.getElementById('filter6_listu').style.display = 'block';

            var pkgitem = document.getElementById("filter6_listu");

            pkgitem.options.length = 0;
            pkgitem.options[0] = new Option("-Select Filter-", "0");
            pkgitem.options.length = 1;

            for (var i = 0; i < dsgrid.Tables[0].Rows.length; ++i) {
                pkgitem.options[pkgitem.options.length] = new Option(dsgrid.Tables[0].Rows[i].NODE_NAME, dsgrid.Tables[0].Rows[i].NODE_NAME + "~" + dsgrid.Tables[0].Rows[i].NODE_ID, dsgrid.Tables[0].Rows[i].NODE_ID);
                pkgitem.options.length;
            }
            var aTag = eval(document.getElementById('filter6u'))
            var btag;
            var leftpos = 0;
            var toppos = 0;

            do {
                aTag = eval(aTag.offsetParent);

                leftpos += aTag.offsetLeft;
                toppos += aTag.offsetTop;
                btag = eval(aTag)

            }
            while (aTag.tagName != "BODY" && aTag.tagName != "HTML");

            var tot = document.getElementById('filter6_divu').scrollLeft;

            var scrolltop = document.getElementById('filter6_divu').scrollTop;
            document.getElementById('filter6_divu').style.display = 'block';

            document.getElementById('filter6_divu').style.left = document.getElementById('filter2u').offsetLeft + leftpos - tot + "px";
            document.getElementById('filter6_divu').style.top = document.getElementById('filter2u').offsetTop + toppos - scrolltop + "px";
        //    document.getElementById('filter4u').focus();

            return false;
        }
    
    else {
        document.getElementById("filter6_listu").value = "";
        document.getElementById('filter6_listu').style.display = 'none';
        return false;
     }}
}

function insert_data(id) 
{
    var drop_down = document.getElementById('drop_select').value 
     if (document.activeElement.id == 'root_list') {
       
        document.getElementById('root_list').style.display = 'none';
        var spl = document.getElementById('root_list').options[document.getElementById('root_list').selectedIndex].value;
        spl = spl.split('~');
        f="";
        for(var i=1;i<spl.length;i++)
        {
         f = f + spl[i]+'~' ;
        }
        f=f.slice(0,-1);
        document.getElementById('root').value=spl[0];
        document.getElementById('hidden_root').value = f;
         
    document.getElementById('filter1').value="";
    document.getElementById('filter2').value="";
    document.getElementById('filter3').value="";
    document.getElementById('filter4').value="";
    document.getElementById('filter5').value="";
    document.getElementById('filter6').value="";
    FCKeditorAPI.GetInstance('explanation_text').SetHTML("");
    FCKeditorAPI.GetInstance('explanation_text2').SetHTML("");  
    FCKeditorAPI.GetInstance('explanation_text3').SetHTML("");
    var res = astro_tree_view_excl.show_node_exp(spl[0], f, drop_down, exec_gridcallexp);
    var res1 = astro_tree_view_excl.show_syno_name(f, drop_down, exec_gridcallsyno);
    var res2 = astro_tree_view_excl.show_par_name(f, drop_down, exec_gridcallpar);
    
    return false;
    }

    if (document.activeElement.id == 'filter1_list') {
       
        document.getElementById('filter1_list').style.display = 'none';
        var spl = document.getElementById('filter1_list').options[document.getElementById('filter1_list').selectedIndex].value;
         spl = spl.split('~');
         f="";
         for(var i=1;i<spl.length;i++)
        {
         f = f + spl[i]+'~' ;
        }
        f=f.slice(0,-1);
         document.getElementById('filter1').value=spl[0];
          document.getElementById('hidden_filter1').value=f;
           
    
     document.getElementById('filter2').value="";
    document.getElementById('filter3').value="";
   document.getElementById('filter4').value="";
   document.getElementById('filter5').value="";
   document.getElementById('filter6').value="";
      FCKeditorAPI.GetInstance('explanation_text').SetHTML("");
    FCKeditorAPI.GetInstance('explanation_text2').SetHTML("");  
   FCKeditorAPI.GetInstance('explanation_text3').SetHTML(""); 
            var res = astro_tree_view_excl.show_node_exp(spl[0], f,drop_down, exec_gridcallexp);
            
        return false;
        
    }

    if (document.activeElement.id == 'filter2_list') {
        document.getElementById('filter2').value = document.getElementById('filter2_list').value;
        document.getElementById('filter2_list').style.display = 'none';
        var spl = document.getElementById('filter2_list').options[document.getElementById('filter2_list').selectedIndex].value;
        spl = spl.split('~');
        f="";
        for(var i=1;i<spl.length;i++)
        {
         f = f + spl[i]+'~' ;
        }
        f=f.slice(0,-1);
         document.getElementById('filter2').value=spl[0];
        document.getElementById('hidden_filter2').value = f;
         
    document.getElementById('filter3').value="";
   document.getElementById('filter4').value="";
   document.getElementById('filter5').value="";
   document.getElementById('filter6').value="";
      FCKeditorAPI.GetInstance('explanation_text').SetHTML("");
    FCKeditorAPI.GetInstance('explanation_text2').SetHTML("");  
   FCKeditorAPI.GetInstance('explanation_text3').SetHTML(""); 
        var res = astro_tree_view_excl.show_node_exp(spl[0], f,drop_down, exec_gridcallexp);
            
        return false;
    }

    if (document.activeElement.id == 'filter3_list') {
        document.getElementById('filter3').value = document.getElementById('filter3_list').value;
        document.getElementById('filter3_list').style.display = 'none';
        var spl = document.getElementById('filter3_list').options[document.getElementById('filter3_list').selectedIndex].value;
        spl = spl.split('~');
        f="";
        for(var i=1;i<spl.length;i++)
        {
         f = f + spl[i]+'~' ;
        }
        f=f.slice(0,-1);
         document.getElementById('filter3').value=spl[0];
        document.getElementById('hidden_filter3').value = f;
         
   document.getElementById('filter4').value="";
   document.getElementById('filter5').value="";
   document.getElementById('filter6').value="";
      FCKeditorAPI.GetInstance('explanation_text').SetHTML("");
    FCKeditorAPI.GetInstance('explanation_text2').SetHTML("");  
   FCKeditorAPI.GetInstance('explanation_text3').SetHTML(""); 
        var res = astro_tree_view_excl.show_node_exp(spl[0], f,drop_down, exec_gridcallexp);
            
        return false;
    }

    if (document.activeElement.id == 'filter4_list') {
      
        document.getElementById('filter4_list').style.display = 'none';
        var spl = document.getElementById('filter4_list').options[document.getElementById('filter4_list').selectedIndex].value;
        spl = spl.split('~');
        f="";
        for(var i=1;i<spl.length;i++)
        {
         f = f + spl[i]+'~' ;
        }
        f=f.slice(0,-1);
         document.getElementById('filter4').value=spl[0];
           document.getElementById('hidden_filter4').value = f;
          document.getElementById('filter5').value="";
   document.getElementById('filter6').value="";
      FCKeditorAPI.GetInstance('explanation_text').SetHTML("");
    FCKeditorAPI.GetInstance('explanation_text2').SetHTML("");  
   FCKeditorAPI.GetInstance('explanation_text3').SetHTML(""); 
        
         var res = astro_tree_view_excl.show_node_exp(spl[0], f,drop_down, exec_gridcallexp);
            
        return false;
    }

 if (document.activeElement.id == 'filter5_list') {
      
        document.getElementById('filter5_list').style.display = 'none';
        var spl = document.getElementById('filter5_list').options[document.getElementById('filter5_list').selectedIndex].value;
        spl = spl.split('~');
        f="";
        for(var i=1;i<spl.length;i++)
        {
         f = f + spl[i]+'~' ;
        }
        f=f.slice(0,-1);
         document.getElementById('filter5').value=spl[0];
           document.getElementById('hidden_filter5').value = f;
          document.getElementById('filter6').value="";
  
      FCKeditorAPI.GetInstance('explanation_text').SetHTML("");
    FCKeditorAPI.GetInstance('explanation_text2').SetHTML("");  
   FCKeditorAPI.GetInstance('explanation_text3').SetHTML(""); 
        
         var res = astro_tree_view_excl.show_node_exp(spl[0], f,drop_down, exec_gridcallexp);
            
        return false;
    }
if (document.activeElement.id == 'filter6_list') {
      
        document.getElementById('filter6_list').style.display = 'none';
        var spl = document.getElementById('filter6_list').options[document.getElementById('filter6_list').selectedIndex].value;
        spl = spl.split('~');
        f="";
        for(var i=1;i<spl.length;i++)
        {
         f = f + spl[i]+'~' ;
        }
        f=f.slice(0,-1);
         document.getElementById('filter6').value=spl[0];
           document.getElementById('hidden_filter6').value = f;
  
      FCKeditorAPI.GetInstance('explanation_text').SetHTML("");
    FCKeditorAPI.GetInstance('explanation_text2').SetHTML("");  
   FCKeditorAPI.GetInstance('explanation_text3').SetHTML(""); 
        
         var res = astro_tree_view_excl.show_node_exp(spl[0], f,drop_down, exec_gridcallexp);
            
        return false;
    }


}



function insert_datau(id) {
    var drop_down = document.getElementById('drop_select').value 
     if (document.activeElement.id == 'root_listu') {
       
        document.getElementById('root_listu').style.display = 'none';
        var spl = document.getElementById('root_listu').options[document.getElementById('root_listu').selectedIndex].value;
        spl = spl.split('~');
        f="";
        for(var i=1;i<spl.length;i++)
        {
         f = f + spl[i]+'~' ;
        }
        f=f.slice(0,-1);
        document.getElementById('rootu').value=spl[0];
        document.getElementById('hidden_rootu').value = f;
         
 document.getElementById('filter1u').value = "";
 document.getElementById('filter2u').value = "";
 document.getElementById('filter3u').value = "";
 document.getElementById('filter4u').value = "";
 document.getElementById('filter5u').value = "";
 document.getElementById('filter6u').value = "";
  FCKeditorAPI.GetInstance('explanation_textu').SetHTML("");
    FCKeditorAPI.GetInstance('explanation_text2u').SetHTML("");  
   FCKeditorAPI.GetInstance('explanation_text3u').SetHTML(""); 
          var res = astro_tree_view_excl.show_node_exp(spl[0], f,drop_down, exec_gridcallexpu);
          var res1 = astro_tree_view_excl.show_syno_name(f, drop_down, exec_gridcallcl);
          var res2 = astro_tree_view_excl.show_par_name(f, drop_down, exec_gridcallpl);
  
        return false;
    }

    if (document.activeElement.id == 'filter1_listu') {
       
        document.getElementById('filter1_listu').style.display = 'none';
        var spl = document.getElementById('filter1_listu').options[document.getElementById('filter1_listu').selectedIndex].value;
         spl = spl.split('~');
         f="";
         for(var i=1;i<spl.length;i++)
        {
         f = f + spl[i]+'~' ;
        }
        f=f.slice(0,-1);
         document.getElementById('filter1u').value=spl[0];
          document.getElementById('hidden_filter1u').value=f;
          
 
 document.getElementById('filter2u').value = "";
 document.getElementById('filter3u').value = "";
 document.getElementById('filter4u').value = "";
 document.getElementById('filter5u').value = "";
 document.getElementById('filter6u').value = "";
  FCKeditorAPI.GetInstance('explanation_textu').SetHTML("");
    FCKeditorAPI.GetInstance('explanation_text2u').SetHTML("");  
   FCKeditorAPI.GetInstance('explanation_text3u').SetHTML(""); 
         
            var res = astro_tree_view_excl.show_node_exp(spl[0], f,drop_down, exec_gridcallexpu);
            
        return false;
        
    }

    if (document.activeElement.id == 'filter2_listu') {
        document.getElementById('filter2u').value = document.getElementById('filter2_listu').value;
        document.getElementById('filter2_listu').style.display = 'none';
        var spl = document.getElementById('filter2_listu').options[document.getElementById('filter2_listu').selectedIndex].value;
        spl = spl.split('~');
        f="";
        for(var i=1;i<spl.length;i++)
        {
         f = f + spl[i]+'~' ;
        }
        f=f.slice(0,-1);
         document.getElementById('filter2u').value=spl[0];
        document.getElementById('hidden_filter2u').value = f;
        
 
 document.getElementById('filter3u').value = "";
 document.getElementById('filter4u').value = "";
 document.getElementById('filter5u').value = "";
 document.getElementById('filter6u').value = "";
  FCKeditorAPI.GetInstance('explanation_textu').SetHTML("");
    FCKeditorAPI.GetInstance('explanation_text2u').SetHTML("");  
   FCKeditorAPI.GetInstance('explanation_text3u').SetHTML(""); 
        var res = astro_tree_view_excl.show_node_exp(spl[0], f,drop_down, exec_gridcallexpu);
            
        return false;
    }

    if (document.activeElement.id == 'filter3_listu') {
        document.getElementById('filter3u').value = document.getElementById('filter3_listu').value;
        document.getElementById('filter3_listu').style.display = 'none';
        var spl = document.getElementById('filter3_listu').options[document.getElementById('filter3_listu').selectedIndex].value;
        spl = spl.split('~');
        f="";
        for(var i=1;i<spl.length;i++)
        {
         f = f + spl[i]+'~' ;
        }
        f=f.slice(0,-1);
         document.getElementById('filter3u').value=spl[0];
        document.getElementById('hidden_filter3u').value = f;
        
 
 document.getElementById('filter4u').value = "";
 document.getElementById('filter5u').value = "";
 document.getElementById('filter6u').value = "";
  FCKeditorAPI.GetInstance('explanation_textu').SetHTML("");
    FCKeditorAPI.GetInstance('explanation_text2u').SetHTML("");  
   FCKeditorAPI.GetInstance('explanation_text3u').SetHTML(""); 
 
        var res = astro_tree_view_excl.show_node_exp(spl[0], f,drop_down, exec_gridcallexpu);
            
        return false;
    }

    if (document.activeElement.id == 'filter4_listu') {
      
        document.getElementById('filter4_listu').style.display = 'none';
        var spl = document.getElementById('filter4_listu').options[document.getElementById('filter4_listu').selectedIndex].value;
        spl = spl.split('~');
        f="";
        for(var i=1;i<spl.length;i++)
        {
         f = f + spl[i]+'~' ;
        }
        f=f.slice(0,-1);
         document.getElementById('filter4u').value=spl[0];
         document.getElementById('up').value = f;
          document.getElementById('hidden_filter4u').value=f;
 document.getElementById('filter5u').value = "";
 document.getElementById('filter6u').value = "";
  FCKeditorAPI.GetInstance('explanation_textu').SetHTML("");
    FCKeditorAPI.GetInstance('explanation_text2u').SetHTML("");  
   FCKeditorAPI.GetInstance('explanation_text3u').SetHTML(""); 
         var res = astro_tree_view_excl.show_node_exp(spl[0], f,drop_down, exec_gridcallexpu);
            
        return false;
    }


if (document.activeElement.id == 'filter5_listu') {
      
        document.getElementById('filter5_listu').style.display = 'none';
        var spl = document.getElementById('filter5_listu').options[document.getElementById('filter5_listu').selectedIndex].value;
        spl = spl.split('~');
        f="";
        for(var i=1;i<spl.length;i++)
        {
         f = f + spl[i]+'~' ;
        }
        f=f.slice(0,-1);
         document.getElementById('filter5u').value=spl[0];
         document.getElementById('up').value = f;
          document.getElementById('hidden_filter5u').value=f;
 
 document.getElementById('filter6u').value = "";
  FCKeditorAPI.GetInstance('explanation_textu').SetHTML("");
    FCKeditorAPI.GetInstance('explanation_text2u').SetHTML("");  
   FCKeditorAPI.GetInstance('explanation_text3u').SetHTML(""); 
         var res = astro_tree_view_excl.show_node_exp(spl[0], f,drop_down, exec_gridcallexpu);
            
        return false;
    }
if (document.activeElement.id == 'filter6_listu') {
      
        document.getElementById('filter6_listu').style.display = 'none';
        var spl = document.getElementById('filter6_listu').options[document.getElementById('filter6_listu').selectedIndex].value;
        spl = spl.split('~');
        f="";
        for(var i=1;i<spl.length;i++)
        {
         f = f + spl[i]+'~' ;
        }
        f=f.slice(0,-1);
         document.getElementById('filter6u').value=spl[0];
         document.getElementById('up').value = f;
          document.getElementById('hidden_filter6u').value=f;
 
 
  FCKeditorAPI.GetInstance('explanation_textu').SetHTML("");
    FCKeditorAPI.GetInstance('explanation_text2u').SetHTML("");  
   FCKeditorAPI.GetInstance('explanation_text3u').SetHTML(""); 
         var res = astro_tree_view_excl.show_node_exp(spl[0], f,drop_down, exec_gridcallexpu);
            
        return false;
    }

}
function trim(stringToTrim) {
return stringToTrim.replace(/^\s+|\s+$/g, "");
}
var group = "";
function save_data() 
{
    var drop_down = document.getElementById('drop_select').value 
   var node_name = trim(document.getElementById('root').value);
    var filter1 = trim(document.getElementById('filter1').value);
    var filter2 = trim(document.getElementById('filter2').value);
    var filter3 = trim(document.getElementById('filter3').value);
    var filter4 = trim(document.getElementById('filter4').value);
    var filter5 = trim(document.getElementById('filter5').value);
    var filter6 = trim(document.getElementById('filter6').value);
 var explanation=FCKeditorAPI.GetInstance("explanation_text").GetHTML();
 var exp2 =FCKeditorAPI.GetInstance("explanation_text2").GetHTML();
 var exp3 =FCKeditorAPI.GetInstance("explanation_text3").GetHTML();
    if (filter1 == "" && filter2 == "" && filter3 == "" && filter4 == "" && filter5 == "" && filter6 == "" && node_name != "") 
{
   node_name = trim(document.getElementById('root').value);
 }
 if (filter2 == "" && filter3 == "" && filter4 == "" && filter5 == "" && filter6 == "" && node_name != "" && filter1 != "" ) {
  node_name = trim(document.getElementById('root').value)+'$'+filter1 
 }
  if (filter3 == "" && filter4 == "" && filter5 == "" && filter6 == "" && node_name != "" && filter1 != "" && filter2 != "") {
   node_name = trim(document.getElementById('root').value)+'$'+filter1 +'$'+filter2
  }
  if ( filter4 == "" && filter5 == "" && filter6 == "" && node_name != "" && filter1 != "" && filter2 != "" && filter3 != "") {
   node_name = trim(document.getElementById('root').value)+'$'+filter1 +'$'+filter2+'$'+filter3;
  }
  
   if ( filter5 == "" && filter6 == "" && filter4 != "" && node_name != "" && filter1 != "" && filter2 != "" && filter3 != "") {
   node_name =trim(document.getElementById('root').value)+'$'+filter1 +'$'+filter2+'$'+filter3 +'$'+filter4;
  }
  if (  filter6 == "" && filter5 != "" && filter4 != "" && node_name != "" && filter1 != "" && filter2 != "" && filter3 != "") {
   node_name = trim(document.getElementById('root').value)+'$'+filter1 +'$'+filter2+'$'+filter3 +'$'+filter4 +'$'+filter5;
  }
  if ( filter6 != "" && filter5 != "" && filter4 != "" && node_name != "" && filter1 != "" && filter2 != "" && filter3 != "") {
   node_name = trim(document.getElementById('root').value)+'$'+filter1 +'$'+filter2+'$'+filter3+'$'+filter4+'$'+filter5 +'$'+filter6;
  }
    var under_node_id = "";
    var drop = "";
    var id = "";
 astro_tree_view_excl.save_data(node_name, group, explanation, under_node_id, id, exp2, exp3, drop_down)
            alert('Data Saved')
            document.getElementById('root').value="";
    document.getElementById('filter1').value="";
     document.getElementById('filter2').value="";
    document.getElementById('filter3').value="";
   document.getElementById('filter4').value="";
    document.getElementById('filter5').value="";
   document.getElementById('filter6').value="";
   
      FCKeditorAPI.GetInstance('explanation_text').SetHTML("");
    FCKeditorAPI.GetInstance('explanation_text2').SetHTML("");  
   FCKeditorAPI.GetInstance('explanation_text3').SetHTML(""); 
    return false;



}
function update_data() 
{
    var drop_down = document.getElementById('drop_select').value 
   var node_name = trim(document.getElementById('rootu').value);
    var filter1 = trim(document.getElementById('filter1u').value);
    var filter2 = trim(document.getElementById('filter2u').value);
    var filter3 = trim(document.getElementById('filter3u').value);
    var filter4 = trim(document.getElementById('filter4u').value);
      var filter5 = trim(document.getElementById('filter5u').value);
    var filter6 = trim(document.getElementById('filter6u').value);
    var explanation = FCKeditorAPI.GetInstance("explanation_textu").GetHTML();
    
    var exp2 =FCKeditorAPI.GetInstance("explanation_text2u").GetHTML(); 
    var exp3 = FCKeditorAPI.GetInstance("explanation_text3u").GetHTML();
    var upnode = "";  
    if (filter1 == "" && filter2 == "" && filter3 == "" && filter4 == "" && filter5 == "" && filter6 == "" && node_name != "") 
{
    var nodeid = trim(document.getElementById('hidden_rootu').value);
    upnode = node_name;
 }
 if (filter2 == "" && filter3 == "" && filter4 == "" && filter5 == "" && filter6 == "" && node_name != "" && filter1 != "" ) {
     var nodeid = trim(document.getElementById('hidden_filter1u').value);
     upnode = filter1;
 }
  if (filter3 == "" && filter4 == "" && filter5 == "" && filter6 == "" && node_name != "" && filter1 != "" && filter2 != "") {
      var nodeid = trim(document.getElementById('hidden_filter2u').value);
      upnode = filter2;
  }
  if ( filter4 == "" && filter5 == "" && filter6 == "" && node_name != "" && filter1 != "" && filter2 != "" && filter3 != "") {
      var nodeid = trim(document.getElementById('hidden_filter3u').value);
      upnode = filter3;
  }
  if ( filter5 == "" && filter6 == "" && filter4 != "" && node_name != "" && filter1 != "" && filter2 != "" && filter3 != "") {
      var nodeid = trim(document.getElementById('hidden_filter4u').value);
      upnode = filter4;
  }
   if ( filter5 != "" && filter6 == "" && filter4 != "" && node_name != "" && filter1 != "" && filter2 != "" && filter3 != "") {
       var nodeid = trim(document.getElementById('hidden_filter5u').value);
       upnode = filter5;
  }
  if ( filter5 != "" && filter6 != "" && filter4 != "" && node_name != "" && filter1 != "" && filter2 != "" && filter3 != "") {
      var nodeid = trim(document.getElementById('hidden_filter6u').value);
      upnode = filter6;
  }
  astro_tree_view_excl.update_data(nodeid, explanation, exp2, exp3, drop_down, upnode)
  astro_tree_view_excl.update_data1(nodeid, explanation, drop_down, upnode)
 alert('Data Update')
 document.getElementById('rootu').value = "";
 document.getElementById('filter1u').value = "";
 document.getElementById('filter2u').value = "";
 document.getElementById('filter3u').value = "";
 document.getElementById('filter4u').value = "";
  document.getElementById('filter5u').value = "";
 document.getElementById('filter6u').value = "";
  FCKeditorAPI.GetInstance('explanation_textu').SetHTML("");
    FCKeditorAPI.GetInstance('explanation_text2u').SetHTML("");  
   FCKeditorAPI.GetInstance('explanation_text3u').SetHTML("");
   return false;
         
            }



function eventcalling(event) {
    if (event.keyCode == 27) {
        if (document.activeElement.id == "root") {
            document.getElementById('root_list').value= "";
            document.getElementById('root_list').style.display = "none";
            document.getElementById('root').focus();
            return false;
        }

        if (document.activeElement.id == "filter1") {
            document.getElementById('filter1_list').value = "";
            document.getElementById('filter1_list').style.display = "none";
            document.getElementById('filter1').focus();
            return false;
        }
        if (document.activeElement.id == "filter2") {
            document.getElementById('filter2_list').value = "";
            document.getElementById('filter2_list').style.display = "none";
            document.getElementById('filter2').focus();
            return false;
        }

        if (document.activeElement.id == "filter3") {
            document.getElementById('filter3_list').value = "";
            document.getElementById('filter3_list').style.display = "none";
            document.getElementById('filter3').focus();
            return false;
        }



        if (document.activeElement.id == "filter4") {
            document.getElementById('filter4_list').value = "";
            document.getElementById('filter4_list').style.display = "none";
            document.getElementById('filter4').focus();
            return false;
        }
        
         if (document.activeElement.id == "filter5") {
            document.getElementById('filter5_list').value = "";
            document.getElementById('filter5_list').style.display = "none";
            document.getElementById('filter5').focus();
            return false;
        }
        if (document.activeElement.id == "filter6") {
            document.getElementById('filter6_list').value = "";
            document.getElementById('filter6_list').style.display = "none";
            document.getElementById('filter6').focus();
            return false;
        }

    }
    return event.keyCode;
}


function exec_gridcallexp(val) {
 
     dsgrid = val.value;
    
   
   
         if (dsgrid.Tables[0].Rows.length > 0 ) {
         if(dsgrid.Tables[0].Rows[0].EXPLANATION!=null)
         {
         FCKeditorAPI.GetInstance('explanation_text').SetHTML(dsgrid.Tables[0].Rows[0].EXPLANATION);
         
     // CKeditor.instances.['explanation_text'].setData(dsgrid.Tables[0].Rows[0].EXPLANATION);
         //document.getElementById('explanation_text').value=dsgrid.Tables[0].Rows[0].EXPLANATION;
         }
         if(dsgrid.Tables[0].Rows[0].EXPLANATION2!=null)
         {
         FCKeditorAPI.GetInstance('explanation_text2').SetHTML(dsgrid.Tables[0].Rows[0].EXPLANATION2);
         //document.getElementById('explanation_text2').value=dsgrid.Tables[0].Rows[0].EXPLANATION2;
         }
         if(dsgrid.Tables[0].Rows[0].EXPLANATION3!=null)
         {
         FCKeditorAPI.GetInstance('explanation_text3').SetHTML(dsgrid.Tables[0].Rows[0].EXPLANATION3);
        // document.getElementById('explanation_text3').value=dsgrid.Tables[0].Rows[0].EXPLANATION3;
         }
         }
         
         return false;
         }
         
         
         
function exec_gridcallexpu(val) {

     dsgrid = val.value;
    
   
   
         if (dsgrid.Tables[0].Rows.length > 0 ) {
         if(dsgrid.Tables[0].Rows[0].EXPLANATION!=null)
         {
         FCKeditorAPI.GetInstance('explanation_textu').SetHTML(dsgrid.Tables[0].Rows[0].EXPLANATION);
         //document.getElementById('explanation_textu').value=dsgrid.Tables[0].Rows[0].EXPLANATION;
         }
         if(dsgrid.Tables[0].Rows[0].EXPLANATION2!=null)
         {
         FCKeditorAPI.GetInstance('explanation_text2u').SetHTML(dsgrid.Tables[0].Rows[0].EXPLANATION2);
        // document.getElementById('explanation_text2u').value=dsgrid.Tables[0].Rows[0].EXPLANATION2;
         }
         if(dsgrid.Tables[0].Rows[0].EXPLANATION3!=null)
         {
         FCKeditorAPI.GetInstance('explanation_text3u').SetHTML(dsgrid.Tables[0].Rows[0].EXPLANATION3);
         //document.getElementById('explanation_text3u').value=dsgrid.Tables[0].Rows[0].EXPLANATION3;
         }
         }
         
         return false;
         }


         function textboxfocus(event) {
             
                 if (document.activeElement.id == 'root_list') {                    
                     if (document.getElementById('root_list').selectedIndex == 0) {
             if (event.keyCode == 38) {
                         document.getElementById('root').focus()
                         //document.getElementById('root_list').style.display = 'none';
                         return false;
                     }
             }    }


                 if (document.activeElement.id == 'filter1_list') {
                     if (document.getElementById('filter1_list').selectedIndex == 0) {
              if (event.keyCode == 38) {
                         document.getElementById('filter1').focus()
                       //  document.getElementById('filter1_list').style.display = 'none';
                         return false;
              }       }
                 }

                 if (document.activeElement.id == 'filter2_list') {
                     if (document.getElementById('filter2_list').selectedIndex == 0) {
                     if (event.keyCode == 38) {
                         document.getElementById('filter2').focus()
                      //   document.getElementById('filter2_list').style.display = 'none';
                         return false;
                     }}
                 }

                 if (document.activeElement.id == 'filter3_list') {
                     if (document.getElementById('filter3_list').selectedIndex == 0) {
                      if (event.keyCode == 38) {
                         document.getElementById('filter3').focus()
                      //   document.getElementById('filter3_list').style.display = 'none';
                         return false;
                     }}
                 }

                 if (document.activeElement.id == 'filter4_list') {
                     if (document.getElementById('filter4_list').selectedIndex == 0) {
                      if (event.keyCode == 38) {
                         document.getElementById('filter4').focus()
                        // document.getElementById('filter4_list').style.display = 'none';
                         return false;
                     }
                 }}
                 if (document.activeElement.id == 'filter5_list') {
                     if (document.getElementById('filter5_list').selectedIndex == 0) {
                      if (event.keyCode == 38) {
                         document.getElementById('filter5').focus()
                        // document.getElementById('filter4_list').style.display = 'none';
                         return false;
                     }}
                 }
                 if (document.activeElement.id == 'filter6_list') {
                     if (document.getElementById('filter6_list').selectedIndex == 0) {
                      if (event.keyCode == 38) {
                         document.getElementById('filter6').focus()
                        // document.getElementById('filter4_list').style.display = 'none';
                         return false;
                     }
                 }
             }

             if (event.keyCode == 13) {
                 var drop_down = document.getElementById('drop_select').value 
                 if (document.activeElement.id == 'root_list') {
                     var spl = document.getElementById('root_list').options[document.getElementById('root_list').selectedIndex].value;
                     spl = spl.split('~');
                     f = "";
                     for (var i = 1; i < spl.length; i++) {
                         f = f + spl[i] + '~';
                     }
                     f = f.slice(0, -1);
                     document.getElementById('root').value = spl[0];
                     document.getElementById('hidden_root').value = f;
                     var res = astro_tree_view_excl.show_node_exp(spl[0], f, drop_down, exec_gridcallexp);
                         document.getElementById('root_list').style.display = 'none';
                         return false;

                     }

                     if (document.activeElement.id == 'filter1_list') {
                         var spl = document.getElementById('filter1_list').options[document.getElementById('filter1_list').selectedIndex].value;
                         spl = spl.split('~');
                         f = "";
                         for (var i = 1; i < spl.length; i++) {
                             f = f + spl[i] + '~';
                         }
                         f = f.slice(0, -1);
                         document.getElementById('filter1').value = spl[0];
                         document.getElementById('filter1_list').value = f;
                         var res = astro_tree_view_excl.show_node_exp(spl[0], f, drop_down, exec_gridcallexp);
                         document.getElementById('filter1_list').style.display = 'none';
                         return false;

                     }

                     if (document.activeElement.id == 'filter2_list') {
                         var spl = document.getElementById('filter2_list').options[document.getElementById('filter2_list').selectedIndex].value;
                         spl = spl.split('~');
                         f = "";
                         for (var i = 1; i < spl.length; i++) {
                             f = f + spl[i] + '~';
                         }
                         f = f.slice(0, -1);
                         document.getElementById('filter2').value = spl[0];
                         document.getElementById('filter2_list').value = f;
                         var res = astro_tree_view_excl.show_node_exp(spl[0], f, drop_down, exec_gridcallexp);
                         document.getElementById('filter2_list').style.display = 'none';
                         return false;

                     }

                     if (document.activeElement.id == 'filter3_list') {
                         var spl = document.getElementById('filter3_list').options[document.getElementById('filter3_list').selectedIndex].value;
                         spl = spl.split('~');
                         f = "";
                         for (var i = 1; i < spl.length; i++) {
                             f = f + spl[i] + '~';
                         }
                         f = f.slice(0, -1);
                         document.getElementById('filter3').value = spl[0];
                         document.getElementById('filter3_list').value = f;
                         var res = astro_tree_view_excl.show_node_exp(spl[0], f, drop_down, exec_gridcallexp);
                         document.getElementById('filter3_list').style.display = 'none';
                         return false;

                     }
                     if (document.activeElement.id == 'filter4_list') {
                         var spl = document.getElementById('filter4_list').options[document.getElementById('filter4_list').selectedIndex].value;
                         spl = spl.split('~');
                         f = "";
                         for (var i = 1; i < spl.length; i++) {
                             f = f + spl[i] + '~';
                         }
                         f = f.slice(0, -1);
                         document.getElementById('filter4').value = spl[0];
                         document.getElementById('filter4_list').value = f;
                         var res = astro_tree_view_excl.show_node_exp(spl[0], f, drop_down, exec_gridcallexp);
                         document.getElementById('filter4_list').style.display = 'none';
                         return false;

                     }
                      if (document.activeElement.id == 'filter5_list') {
                         var spl = document.getElementById('filter5_list').options[document.getElementById('filter5_list').selectedIndex].value;
                         spl = spl.split('~');
                         f = "";
                         for (var i = 1; i < spl.length; i++) {
                             f = f + spl[i] + '~';
                         }
                         f = f.slice(0, -1);
                         document.getElementById('filter5').value = spl[0];
                         document.getElementById('filter5_list').value = f;
                         var res = astro_tree_view_excl.show_node_exp(spl[0], f, drop_down, exec_gridcallexp);
                         document.getElementById('filter5_list').style.display = 'none';
                         return false;

                     }
                     if (document.activeElement.id == 'filter6_list') {
                         var spl = document.getElementById('filter6_list').options[document.getElementById('filter6_list').selectedIndex].value;
                         spl = spl.split('~');
                         f = "";
                         for (var i = 1; i < spl.length; i++) {
                             f = f + spl[i] + '~';
                         }
                         f = f.slice(0, -1);
                         document.getElementById('filter6').value = spl[0];
                         document.getElementById('filter6_list').value = f;
                         var res = astro_tree_view_excl.show_node_exp(spl[0], f, drop_down, exec_gridcallexp);
                         document.getElementById('filter6_list').style.display = 'none';
                         return false;

                     }

                 }

                 if (event.keyCode == 27) {

                     if (document.activeElement.id == 'root_list') {
                         document.getElementById('root_list').style.display = 'none';
                         return false;
                     }
                     if (document.activeElement.id == 'filter1_list') {
                         document.getElementById('filter1_list').style.display = 'none';
                         return false;
                     }
                     if (document.activeElement.id == 'filter2_list') {
                         document.getElementById('filter2_list').style.display = 'none';
                         return false;
                     }
                     if (document.activeElement.id == 'filter3_list') {
                         document.getElementById('filter3_list').style.display = 'none';
                         return false;
                     }
                     if (document.activeElement.id == 'filter4_list') {
                         document.getElementById('filter4_list').style.display = 'none';
                         return false;
                     }
                       if (document.activeElement.id == 'filter5_list') {
                         document.getElementById('filter5_list').style.display = 'none';
                         return false;
                     }
                       if (document.activeElement.id == 'filter6_list') {
                         document.getElementById('filter6_list').style.display = 'none';
                         return false;
                     }
                     return false;
                 }

                
         }




         function textboxfocusu(event) {
             
                 if (document.activeElement.id == 'root_listu') {
                     if (document.getElementById('root_listu').selectedIndex == 0) {
                    if (event.keyCode == 38) {
                         document.getElementById('rootu').focus()
                       //  document.getElementById('root_listu').style.display = 'none';
                         return false;
                     }
                 }}


                 if (document.activeElement.id == 'filter1_listu') {
                     if (document.getElementById('filter1_listu').selectedIndex == 0) {
                   if (event.keyCode == 38) {
                         document.getElementById('filter1u').focus()
                      //   document.getElementById('filter1_listu').style.display = 'none';
                         return false;
                   }  }
                 }

                 if (document.activeElement.id == 'filter2_listu') {
                     if (document.getElementById('filter2_listu').selectedIndex == 0) {
                     if (event.keyCode == 38) {
                         document.getElementById('filter2u').focus()
                    //     document.getElementById('filter2_listu').style.display = 'none';
                         return false;
                     }
                 }}

                 if (document.activeElement.id == 'filter3_listu') {
                     if (document.getElementById('filter3_listu').selectedIndex == 0) {
                   if (event.keyCode == 38) {
                         document.getElementById('filter3u').focus()
                     //    document.getElementById('filter3_listu').style.display = 'none';
                         return false;
                   }  }
                 }

                 if (document.activeElement.id == 'filter4_listu') {
                     if (document.getElementById('filter4_listu').selectedIndex == 0) {
                     if (event.keyCode == 38) {
                         document.getElementById('filter4u').focus()
                      //   document.getElementById('filter4_listu').style.display = 'none';
                         return false;
                     }
                 }
             }

 if (document.activeElement.id == 'filter5_listu') {
                     if (document.getElementById('filter5_listu').selectedIndex == 0) {
                     if (event.keyCode == 38) {
                         document.getElementById('filter5u').focus()
                      //   document.getElementById('filter4_listu').style.display = 'none';
                         return false;
                     }
                 }
             }
if (document.activeElement.id == 'filter6_listu') {
                     if (document.getElementById('filter6_listu').selectedIndex == 0) {
                     if (event.keyCode == 38) {
                         document.getElementById('filter6u').focus()
                      //   document.getElementById('filter4_listu').style.display = 'none';
                         return false;
                     }
                 }
             }

             if (event.keyCode == 13) {
                 var drop_down = document.getElementById('drop_select').value;
                 if (document.activeElement.id == 'root_listu') {
                     var spl = document.getElementById('root_listu').options[document.getElementById('root_listu').selectedIndex].value;
                     spl = spl.split('~');
                     f = "";
                     for (var i = 1; i < spl.length; i++) {
                         f = f + spl[i] + '~';
                     }
                     f = f.slice(0, -1);
                     document.getElementById('rootu').value = spl[0];
                     document.getElementById('hidden_rootu').value = f;
                     var res = astro_tree_view_excl.show_node_exp(spl[0], f, drop_down, exec_gridcallexpu);
                     document.getElementById('root_listu').style.display = 'none';
                     return false;

                 }

                 if (document.activeElement.id == 'filter1_listu') {
                     var spl = document.getElementById('filter1_listu').options[document.getElementById('filter1_listu').selectedIndex].value;
                     spl = spl.split('~');
                     f = "";
                     for (var i = 1; i < spl.length; i++) {
                         f = f + spl[i] + '~';
                     }
                     f = f.slice(0, -1);
                     document.getElementById('filter1u').value = spl[0];
                     document.getElementById('hidden_rootu').value = f;
                     var res = astro_tree_view_excl.show_node_exp(spl[0], f, drop_down, exec_gridcallexpu);                    
                     document.getElementById('filter1_listu').style.display = 'none';
                     return false;

                 }

                 if (document.activeElement.id == 'filter2_listu') {
                     var spl = document.getElementById('filter2_listu').options[document.getElementById('filter2_listu').selectedIndex].value;
                     spl = spl.split('~');
                     f = "";
                     for (var i = 1; i < spl.length; i++) {
                         f = f + spl[i] + '~';
                     }
                     f = f.slice(0, -1);
                     document.getElementById('filter2u').value = spl[0];
                     document.getElementById('hidden_rootu').value = f;
                     var res = astro_tree_view_excl.show_node_exp(spl[0], f, drop_down, exec_gridcallexpu);    
                     document.getElementById('filter2_listu').style.display = 'none';
                     return false;

                 }

                 if (document.activeElement.id == 'filter3_listu') {
                     var spl = document.getElementById('filter3_listu').options[document.getElementById('filter3_listu').selectedIndex].value;
                     spl = spl.split('~');
                     f = "";
                     for (var i = 1; i < spl.length; i++) {
                         f = f + spl[i] + '~';
                     }
                     f = f.slice(0, -1);
                     document.getElementById('filter3u').value = spl[0];
                     document.getElementById('hidden_rootu').value = f;
                     var res = astro_tree_view_excl.show_node_exp(spl[0], f, drop_down, exec_gridcallexpu);    
                     document.getElementById('filter3_listu').style.display = 'none';
                     return false;

                 }
                 if (document.activeElement.id == 'filter4_listu') {
                     var spl = document.getElementById('filter4_listu').options[document.getElementById('filter4_listu').selectedIndex].value;
                     spl = spl.split('~');
                     f = "";
                     for (var i = 1; i < spl.length; i++) {
                         f = f + spl[i] + '~';
                     }
                     f = f.slice(0, -1);
                     document.getElementById('filter4u').value = spl[0];
                     document.getElementById('hidden_rootu').value = f;
                     var res = astro_tree_view_excl.show_node_exp(spl[0], f, drop_down, exec_gridcallexpu);   
                     document.getElementById('filter4_listu').style.display = 'none';
                     return false;

                 }
if (document.activeElement.id == 'filter5_listu') {
                     var spl = document.getElementById('filter5_listu').options[document.getElementById('filter5_listu').selectedIndex].value;
                     spl = spl.split('~');
                     f = "";
                     for (var i = 1; i < spl.length; i++) {
                         f = f + spl[i] + '~';
                     }
                     f = f.slice(0, -1);
                     document.getElementById('filter5u').value = spl[0];
                     document.getElementById('hidden_rootu').value = f;
                     var res = astro_tree_view_excl.show_node_exp(spl[0], f, drop_down, exec_gridcallexpu);   
                     document.getElementById('filter5_listu').style.display = 'none';
                     return false;

                 }
                 if (document.activeElement.id == 'filter6_listu') {
                     var spl = document.getElementById('filter6_listu').options[document.getElementById('filter6_listu').selectedIndex].value;
                     spl = spl.split('~');
                     f = "";
                     for (var i = 1; i < spl.length; i++) {
                         f = f + spl[i] + '~';
                     }
                     f = f.slice(0, -1);
                     document.getElementById('filter6u').value = spl[0];
                     document.getElementById('hidden_rootu').value = f;
                     var res = astro_tree_view_excl.show_node_exp(spl[0], f, drop_down, exec_gridcallexpu);   
                     document.getElementById('filter6_listu').style.display = 'none';
                     return false;

                 }
             }


             if (event.keyCode == 27) {

                 if (document.activeElement.id == 'root_listu') {
                     document.getElementById('root_listu').style.display = 'none';
                     return false;
                 }
                 if (document.activeElement.id == 'filter1_listu') {
                     document.getElementById('filter1_listu').style.display = 'none';
                     return false;
                 }
                 if (document.activeElement.id == 'filter2_listu') {
                     document.getElementById('filter2_listu').style.display = 'none';
                     return false;
                 }
                 if (document.activeElement.id == 'filter3_listu') {
                     document.getElementById('filter3_listu').style.display = 'none';
                     return false;
                 }
                 if (document.activeElement.id == 'filter4_listu') {
                     document.getElementById('filter4_listu').style.display = 'none';
                     return false;
                 }
                  if (document.activeElement.id == 'filter5_listu') {
                     document.getElementById('filter5_listu').style.display = 'none';
                     return false;
                 }
                  if (document.activeElement.id == 'filter6_listu') {
                     document.getElementById('filter6_listu').style.display = 'none';
                     return false;
                 }
                 return false;
             }
         }  
         
     function initCapr(str) {
    /* First letter as uppercase, rest lower */
    var str = str.substring(0, 1).toUpperCase() + str.substring(1, str.length).toLowerCase();
    document.getElementById('root').value = str;    
}    

         
     function initCapf1(str) {
    /* First letter as uppercase, rest lower */
   // var str = str.substring(0, 1)+ str.substring(1, str.length);
    document.getElementById('filter1').value = str;    
}    

         
     function initCapf2(str) {
    /* First letter as uppercase, rest lower */
  //  var str = str.substring(0, 1) + str.substring(1, str.length);
    document.getElementById('filter2').value = str;    
}    

         
     function initCapf3(str) {
    /* First letter as uppercase, rest lower */
   // var str = str.substring(0, 1)+ str.substring(1, str.length);
    document.getElementById('filter3').value = str;    
}    

         
     function initCapf4(str) {
    /* First letter as uppercase, rest lower */
  //  var str = str.substring(0, 1) + str.substring(1, str.length);
    document.getElementById('filter4').value = str;    
}    
 function initCapf5(str) {
    /* First letter as uppercase, rest lower */
  //  var str = str.substring(0, 1) + str.substring(1, str.length);
    document.getElementById('filter5').value = str;    
}   
 function initCapf6(str) {
    /* First letter as uppercase, rest lower */
  //  var str = str.substring(0, 1)+ str.substring(1, str.length);
    document.getElementById('filter6').value = str;    
}
function initCaps(str) {
    /* First letter as uppercase, rest lower */
  //  var str = str.substring(0, 1) + str.substring(1, str.length);
    document.getElementById('syn').value = str;
}    

 function initCapru(str) {
    /* First letter as uppercase, rest lower */
    var str = str.substring(0, 1).toUpperCase() + str.substring(1, str.length).toLowerCase();
    document.getElementById('rootu').value = str;    
}    

         
     function initCapf1u(str) {
    /* First letter as uppercase, rest lower */
  //  var str = str.substring(0, 1) + str.substring(1, str.length);
    document.getElementById('filter1u').value = str;    
}    

         
     function initCapf2u(str) {
    /* First letter as uppercase, rest lower */
  //  var str = str.substring(0, 1)+ str.substring(1, str.length);
    document.getElementById('filter2u').value = str;    
}    

         
     function initCapf3u(str) {
    /* First letter as uppercase, rest lower */
  //  var str = str.substring(0, 1) + str.substring(1, str.length);
    document.getElementById('filter3u').value = str;    
}    

         
     function initCapf4u(str) {
    /* First letter as uppercase, rest lower */
 //   var str = str.substring(0, 1) + str.substring(1, str.length);
    document.getElementById('filter4u').value = str;    
}    

  function initCapf5u(str) {
    /* First letter as uppercase, rest lower */
 //   var str = str.substring(0, 1) + str.substring(1, str.length);
    document.getElementById('filter6u').value = str;    
}   

  function initCapf6u(str) {
    /* First letter as uppercase, rest lower */
//    var str = str.substring(0, 1)+ str.substring(1, str.length);
    document.getElementById('filter6u').value = str;    
}   


function clear_data()
{  document.getElementById('root').value="";
    document.getElementById('filter1').value="";
     document.getElementById('filter2').value="";
    document.getElementById('filter3').value="";
   document.getElementById('filter4').value="";
    document.getElementById('filter5').value="";
   document.getElementById('filter6').value="";
   document.getElementById('syn').value = "";
      FCKeditorAPI.GetInstance('explanation_text').SetHTML("");
    FCKeditorAPI.GetInstance('explanation_text2').SetHTML("");  
   FCKeditorAPI.GetInstance('explanation_text3').SetHTML(""); 
    return false;}
    
    
    function clear_datau()
{   document.getElementById('rootu').value = "";
 document.getElementById('filter1u').value = "";
 document.getElementById('filter2u').value = "";
 document.getElementById('filter3u').value = "";
 document.getElementById('filter4u').value = "";
  document.getElementById('filter5u').value = "";
 document.getElementById('filter6u').value = "";
  FCKeditorAPI.GetInstance('explanation_textu').SetHTML("");
    FCKeditorAPI.GetInstance('explanation_text2u').SetHTML("");  
   FCKeditorAPI.GetInstance('explanation_text3u').SetHTML(""); 
    return false;}
    
    
    function delete_data(id)
    {
    var drop_down = document.getElementById('drop_select').value 
    var node_name = document.getElementById('rootu').value;
    var filter1 = document.getElementById('filter1u').value;
    var filter2 = document.getElementById('filter2u').value;
    var filter3 = document.getElementById('filter3u').value;
    var filter4 = document.getElementById('filter4u').value;
    var filter5 = document.getElementById('filter5u').value;
    var filter6 = document.getElementById('filter6u').value;
    var explanation = FCKeditorAPI.GetInstance("explanation_textu").GetHTML();
    var exp2 =FCKeditorAPI.GetInstance("explanation_text2u").GetHTML(); 
    var exp3 = FCKeditorAPI.GetInstance("explanation_text3u").GetHTML(); 
    
   if (filter1 == "" && filter2 == "" && filter3 == "" && filter4 == "" && filter5 == "" && filter6 == "" && node_name != "") 
{
    var a = confirm('Do You Want To Remove The Main Root');
    if (a == false) {
        return false;
    }
   var nodeid =document.getElementById('hidden_rootu').value;
 }
  if (filter1 != "" && filter2 == "" && filter3 == "" && filter4 == "" && filter5 == "" && filter6 == "" && node_name != "") 
{
 
   var nodeid =document.getElementById('hidden_filter1u').value;
 }
 if (filter1 != "" && filter2 != "" && filter3 == "" && filter4 == "" && filter5 == "" && filter6 == "" && node_name != "") 
{
 
   var nodeid =document.getElementById('hidden_filter2u').value;
 }
 if (filter1 != "" && filter2 != "" && filter3 != "" && filter4 == "" && filter5 == "" && filter6 == "" && node_name != "") 
{
 
   var nodeid =document.getElementById('hidden_filter3u').value;
 }
  if (filter1 != "" && filter2 != "" && filter3 != "" && filter4 != "" && filter5 == "" && filter6 == "" && node_name != "") 
{
 
   var nodeid =document.getElementById('hidden_filter4u').value;
 }
 if (filter1 != "" && filter2 != "" && filter3 != "" && filter4 != "" && filter5 != "" && filter6 == "" && node_name != "") 
{
 
   var nodeid =document.getElementById('hidden_filter5u').value;
 }
 if (filter1 != "" && filter2 != "" && filter3 != "" && filter4 != "" && filter5 != "" && filter6 != "" && node_name != "") 
{
 
   var nodeid =document.getElementById('hidden_filter6u').value;
 }
 
 
 astro_tree_view_excl.delete_data(nodeid, drop_down)
 alert('Data Deleted')
 document.getElementById('rootu').value = "";
 document.getElementById('filter1u').value = "";
 document.getElementById('filter2u').value = "";
 document.getElementById('filter3u').value = "";
 document.getElementById('filter4u').value = "";
  document.getElementById('filter5u').value = "";
 document.getElementById('filter6u').value = "";
  FCKeditorAPI.GetInstance('explanation_textu').SetHTML("");
    FCKeditorAPI.GetInstance('explanation_text2u').SetHTML("");  
   FCKeditorAPI.GetInstance('explanation_text3u').SetHTML(""); 

            return false;
   }
   
   
   function cu()
   {
   if(document.getElementById('drop_select').value=='Astro Knowledge')
   {
   
   var edtn = document.getElementById("drop_selectu");
    edtn.options.length = 1;
   
    edtn.options[0] = new Option(document.getElementById('drop_select').value, document.getElementById('drop_select').value);
  
   }
   else{   var edtn = document.getElementById("drop_selectu");
    edtn.options.length = 1;
    edtn.options[0] = new Option(document.getElementById('drop_select').value, document.getElementById('drop_select').value);}

}

   function anr() {
     
       document.getElementById('filter6').value = trim(document.getElementById('filter5').value);
       document.getElementById('filter5').value = trim(document.getElementById('filter4').value);
       document.getElementById('filter4').value = trim(document.getElementById('filter3').value);
       document.getElementById('filter3').value = trim(document.getElementById('filter2').value);
       document.getElementById('filter2').value = trim(document.getElementById('filter1').value);
       document.getElementById('filter1').value = trim(document.getElementById('root').value);
       document.getElementById('root').value = "";
       return false;

   }
function ctr1() {
    document.getElementById('root').value = trim(document.getElementById('filter1').value);
    document.getElementById('filter1').value = trim(document.getElementById('filter2').value);
    document.getElementById('filter2').value = trim(document.getElementById('filter3').value);
    document.getElementById('filter3').value = trim(document.getElementById('filter4').value);
    document.getElementById('filter4').value = trim(document.getElementById('filter5').value);
    document.getElementById('filter5').value = trim(document.getElementById('filter6').value);
    document.getElementById('filter6').value = "";
    return false;

}
function ctr2() {
    document.getElementById('root').value = trim(document.getElementById('filter2').value);
    document.getElementById('filter1').value = trim(document.getElementById('filter3').value);
    document.getElementById('filter2').value = trim(document.getElementById('filter4').value);
    document.getElementById('filter3').value = trim(document.getElementById('filter5').value);
    document.getElementById('filter4').value = trim(document.getElementById('filter6').value);
    document.getElementById('filter5').value = "";
    document.getElementById('filter6').value = ""; 
    return false;

}
function ctr3() {
    document.getElementById('root').value = trim(document.getElementById('filter3').value);
    document.getElementById('filter1').value = trim(document.getElementById('filter4').value);
    document.getElementById('filter2').value = trim(document.getElementById('filter5').value);
    document.getElementById('filter3').value = trim(document.getElementById('filter6').value);
    document.getElementById('filter4').value = "";
    document.getElementById('filter5').value = "";
    document.getElementById('filter6').value = "";
    return false;

}

function ctr4() {
    document.getElementById('root').value = trim(document.getElementById('filter4').value);
    document.getElementById('filter1').value = trim(document.getElementById('filter5').value);
    document.getElementById('filter2').value = trim(document.getElementById('filter6').value);
    document.getElementById('filter3').value = "";
    document.getElementById('filter4').value = "";
    document.getElementById('filter5').value = "";
    document.getElementById('filter6').value = "";
    return false;

}
function ctr5() {
    document.getElementById('root').value = trim(document.getElementById('filter5').value);
    document.getElementById('filter1').value = trim(document.getElementById('filter6').value);
    document.getElementById('filter2').value = "";
    document.getElementById('filter3').value = "";
    document.getElementById('filter4').value = "";
    document.getElementById('filter5').value = "";
    document.getElementById('filter6').value = "";
    return false;

}

function ctr6() {
    document.getElementById('root').value = trim(document.getElementById('filter6').value);
    document.getElementById('filter1').value = "";
    document.getElementById('filter2').value = "";
    document.getElementById('filter3').value = "";
    document.getElementById('filter4').value = "";
    document.getElementById('filter5').value = "";
    document.getElementById('filter6').value = "";
    return false;

}

function save_synonyam() {
   
    var drop_down = document.getElementById('drop_select').value
    var node_name = trim(document.getElementById('root').value);
    var synonyam = trim(document.getElementById('syn').value);
    astro_tree_view_excl.save_syn(drop_down, node_name, synonyam)
    alert('Data Save');
    document.getElementById('syn').value = "";
    return false;
}



function exec_gridcallsyno(res1) {
    var ds = res1.value;
    var edtn1 = document.getElementById("synon");
    edtn1.options.length = 1;
    edtn1.options[0] = new Option("Select Child", "0");
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        for (var i = 0; i < ds.Tables[0].Rows.length; i++) {
            edtn1.options[edtn1.options.length] = new Option(ds.Tables[0].Rows[i].NODE_NAME, ds.Tables[0].Rows[i].NODE_NAME)
            edtn1.options.length;
        }

    }
    return false;
}
function exec_gridcallpar(res2) {
    var ds = res2.value;
    var edtn1 = document.getElementById("par");
    edtn1.options.length = 1;
    edtn1.options[0] = new Option("Select Parent", "0");
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        for (var i = 0; i < ds.Tables[0].Rows.length; i++) {
            edtn1.options[edtn1.options.length] = new Option(ds.Tables[0].Rows[i].NODE_NAME, ds.Tables[0].Rows[i].NODE_NAME)
            edtn1.options.length;
        }

    }
    return false;
}

function exec_gridcallcl(res1) {
    var ds = res1.value;
    var edtn1 = document.getElementById("cl");
    edtn1.options.length = 1;
    edtn1.options[0] = new Option("Select Child", "0");
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        for (var i = 0; i < ds.Tables[0].Rows.length; i++) {
            edtn1.options[edtn1.options.length] = new Option(ds.Tables[0].Rows[i].NODE_NAME, ds.Tables[0].Rows[i].NODE_NAME)
            edtn1.options.length;
        }

    }
    return false;
}
function exec_gridcallpl(res2) {
    var ds = res2.value;
    var edtn1 = document.getElementById("pl");
    edtn1.options.length = 1;
    edtn1.options[0] = new Option("Select Parent", "0");
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        for (var i = 0; i < ds.Tables[0].Rows.length; i++) {
            edtn1.options[edtn1.options.length] = new Option(ds.Tables[0].Rows[i].NODE_NAME, ds.Tables[0].Rows[i].NODE_NAME)
            edtn1.options.length;
        }

    }
    return false;
}
