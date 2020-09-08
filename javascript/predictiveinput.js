var predictive_input = "";
var buf2 = new StringBuffer2();
function StringBuffer2() {
    this.buffer = [];
}

StringBuffer2.prototype.append = function append(string) {
    this.buffer.push(string);
    return this;
}

function f25fillmalifics(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "f25malifics") {
            document.getElementById('lstmultipleplanet').value = "";
            //var compcode = $('hdncompcode').value;
            //var unit=$('hdnunitcode').value;
            document.getElementById("divmultipleplanet").style.display = "block";
             document.getElementById('divmultipleplanet').style.top = findPos(document.getElementById('f25malifics'), "top");
       document.getElementById('divmultipleplanet').style.left = findPos(document.getElementById('f25malifics'), "left");
     

            var extra1 = document.getElementById('f25malifics').value;
            document.getElementById('f25malifics').focus();
            predictive_input.fill_malifics(extra1, f20callback_planet);
            return false;
        }

    }


}

function f22fillplanet(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "f22planet") {
            document.getElementById('lstmultipleplanet').value = "";
            //var compcode = $('hdncompcode').value;
            //var unit=$('hdnunitcode').value;
            document.getElementById("divmultipleplanet").style.display = "block";
             document.getElementById('divmultipleplanet').style.top = findPos(document.getElementById('f22planet'), "top");
       document.getElementById('divmultipleplanet').style.left = findPos(document.getElementById('f22planet'), "left");
     

            var extra1 = document.getElementById('f22planet').value;
            document.getElementById('f22planet').focus();
            predictive_input.fill_planet(extra1, f20callback_planet);
            return false;
        }

    }


}

function fillplanet(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "txtmultipleplanet") {
            document.getElementById('lstmultipleplanet').value = "";
            //var compcode = $('hdncompcode').value;
            //var unit=$('hdnunitcode').value;
            document.getElementById("divmultipleplanet").style.display = "block";
             document.getElementById('divmultipleplanet').style.top = findPos(document.getElementById('txtmultipleplanet'), "top");
       document.getElementById('divmultipleplanet').style.left = findPos(document.getElementById('txtmultipleplanet'), "left");
     

            var extra1 = document.getElementById('txtmultipleplanet').value;
            document.getElementById('txtmultipleplanet').focus();
            predictive_input.fill_planet(extra1, f20callback_planet);
            return false;
        }

    }


}





function fillf7planet(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "f7planet") {
            document.getElementById('lstmultipleplanet').value = "";
            //var compcode = $('hdncompcode').value;
            //var unit=$('hdnunitcode').value;
            document.getElementById("divmultipleplanet").style.display = "block";
            document.getElementById('divmultipleplanet').style.top = findPos(document.getElementById('f7planet'), "top");
       document.getElementById('divmultipleplanet').style.left = findPos(document.getElementById('f7planet'), "left");
     

            var extra1 = document.getElementById('f7planet').value;
            document.getElementById('f7planet').focus();
            predictive_input.fill_planet(extra1, f20callback_planet);
            return false;
        }

    }


}

function fillf8planet(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "f8planet") {
            document.getElementById('lstmultipleplanet').value = "";
            //var compcode = $('hdncompcode').value;
            //var unit=$('hdnunitcode').value;
            document.getElementById("divmultipleplanet").style.display = "block";
            document.getElementById('divmultipleplanet').style.top = findPos(document.getElementById('f8planet'), "top");
       document.getElementById('divmultipleplanet').style.left = findPos(document.getElementById('f8planet'), "left");
     
            var extra1 = document.getElementById('f8planet').value;
            document.getElementById('f8planet').focus();
            predictive_input.fill_planet(extra1, f20callback_planet);
            return false;
        }

    }


}


function closeplanet(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 27) {
        for (var i = 0; i < document.getElementById('lstmultipleplanet').options.length; ++i) {
            document.getElementById('lstmultipleplanet').options[i].selected = false;

        }
        document.getElementById('divmultipleplanet').style.display = "none";
        document.getElementById('txtmultipleplanet').value = "";
        document.getElementById('f8planet').value = "";
        document.getElementById('f7planet').value = "";
        document.getElementById('f20planet').value = "";
//        document.getElementById('txtmultipleplanet').focus();

        return false;
    }

}


function fillf22ahouse(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "f22ahouse") {
            document.getElementById('lstmultiplehouse').value = "";
            //var compcode = $('hdncompcode').value;
            //var unit=$('hdnunitcode').value;
            document.getElementById("divmultiplehouse").style.display = "block";
//            document.getElementById('divmultiplehouse').style.top = 500 + "px";
//            document.getElementById('divmultiplehouse').style.left = 335 + "px";
 document.getElementById('divmultiplehouse').style.top = findPos(document.getElementById('f22ahouse'), "top");
       document.getElementById('divmultiplehouse').style.left = findPos(document.getElementById('f22ahouse'), "left");
       
            var extra1 = document.getElementById('f22ahouse').value;
            document.getElementById('f22ahouse').focus();
            predictive_input.fill_house(extra1, callback_house);
            return false;
        }

    }


}

function fillmhouse(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "mdrphouse") {
            document.getElementById('lstmultiplehouse').value = "";
            //var compcode = $('hdncompcode').value;
            //var unit=$('hdnunitcode').value;
            document.getElementById("divmultiplehouse").style.display = "block";
//            document.getElementById('divmultiplehouse').style.top = 500 + "px";
//            document.getElementById('divmultiplehouse').style.left = 335 + "px";
 document.getElementById('divmultiplehouse').style.top = findPos(document.getElementById('mdrphouse'), "top");
       document.getElementById('divmultiplehouse').style.left = findPos(document.getElementById('mdrphouse'), "left");
       
            var extra1 = document.getElementById('mdrphouse').value;
            document.getElementById('mdrphouse').focus();
            predictive_input.fill_house(extra1, callback_house);
            return false;
        }

    }


}

function callback_house(res) {
    ds = res.value;
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        var pkgitem = document.getElementById("lstmultiplehouse");
        pkgitem.options.length = 0;
        pkgitem.options[0] = new Option("Any House", "0");
        pkgitem.options.length = 1;
        for (var i = 0; i < ds.Tables[0].Rows.length; ++i) {
            //pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].REASON_CODE+"-"+ds.Tables[0].Rows[i].REASON_NAME,ds.Tables[0].Rows[i].REASON_CODE);
            pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].CODE);
            pkgitem.options.length;
        }
    }
    document.getElementById('lstmultiplehouse').style.display = "block";
    document.getElementById('lstmultiplehouse').focus();
    return false;
}


function closehouse(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 27) {
        for (var i = 0; i < document.getElementById('lstmultiplehouse').options.length; ++i) {
            document.getElementById('lstmultiplehouse').options[i].selected = false;

        }
        document.getElementById('divmultiplehouse').style.display = "none";
        document.getElementById('mdrphouse').value = "";
        document.getElementById('f8house').value = "";
        document.getElementById('drphouse').value = "";
        
        return false;
    }

}

function fillhouse(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "drphouse") {
            document.getElementById('lstmultiplehouse').value = "";
            //var compcode = $('hdncompcode').value;
            //var unit=$('hdnunitcode').value;
            document.getElementById("divmultiplehouse").style.display = "block";
             document.getElementById('divmultipleplanet').style.top = findPos(document.getElementById('drphouse'), "top");
       document.getElementById('divmultipleplanet').style.left = findPos(document.getElementById('drphouse'), "left");
      

            var extra1 = document.getElementById('drphouse').value;
            document.getElementById('drphouse').focus();
            predictive_input.fill_house(extra1, callback_house);
            return false;
        }

    }


}

function houseincharan(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "f19house") {
            document.getElementById('lstmultiplehouse').value = "";
            //var compcode = $('hdncompcode').value;
            //var unit=$('hdnunitcode').value;
            document.getElementById("divmultiplehouse").style.display = "block";
            document.getElementById('divmultiplehouse').style.top = 500 + "px";
            document.getElementById('divmultiplehouse').style.left = 325 + "px";

            var extra1 = document.getElementById('f19house').value;
            document.getElementById('f19house').focus();
            predictive_input.fill_house(extra1, callback_house);
            return false;
        }

    }


}
function fillhouseinedm(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "f17ahouse") {
            document.getElementById('lstmultiplehouse').value = "";
            //var compcode = $('hdncompcode').value;
            //var unit=$('hdnunitcode').value;
            document.getElementById("divmultiplehouse").style.display = "block";
             document.getElementById('divmultipleplanet').style.top = findPos(document.getElementById('f17ahouse'), "top");
       document.getElementById('divmultipleplanet').style.left = findPos(document.getElementById('f17ahouse'), "left");
      

            var extra1 = document.getElementById('f17ahouse').value;
            document.getElementById('f17ahouse').focus();
            predictive_input.fill_house(extra1, callback_house);
            return false;
        }

    }


}

function fillf8house(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "f8house") {
            document.getElementById('lstmultiplehouse').value = "";
            //var compcode = $('hdncompcode').value;
            //var unit=$('hdnunitcode').value;
            document.getElementById("divmultiplehouse").style.display = "block";
          document.getElementById('divmultipleplanet').style.top = findPos(document.getElementById('f8house'), "top");
       document.getElementById('divmultipleplanet').style.left = findPos(document.getElementById('f8house'), "left");
      

            var extra1 = document.getElementById('f8house').value;
            document.getElementById('f8house').focus();
            predictive_input.fill_house(extra1, callback_house);
            return false;
        }

    }


}





function fillf7rashi(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "f7rashi") {
            document.getElementById('lstmultiplerashi').value = "";
            //var compcode = $('hdncompcode').value;
            //var unit=$('hdnunitcode').value;
            document.getElementById("divmultiplerashi").style.display = "block";
             document.getElementById('divmultiplerashi').style.top = findPos(document.getElementById('f7rashi'), "top");
       document.getElementById('divmultiplerashi').style.left = findPos(document.getElementById('f7rashi'), "left");
     
            var extra1 = document.getElementById('f7rashi').value;
            document.getElementById('f7rashi').focus();
            predictive_input.fill_rashi(extra1, callback_rashi);
            return false;
        }

    }


}

function fillf8rashi(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "f8rashi") {
            document.getElementById('lstmultiplerashi').value = "";
            //var compcode = $('hdncompcode').value;
            //var unit=$('hdnunitcode').value;
            document.getElementById("divmultiplerashi").style.display = "block";
             document.getElementById('divmultiplerashi').style.top = findPos(document.getElementById('f8rashi'), "top");
       document.getElementById('divmultiplerashi').style.left = findPos(document.getElementById('f8rashi'), "left");
     

            var extra1 = document.getElementById('f8rashi').value;
            document.getElementById('f8rashi').focus();
            predictive_input.fill_rashi(extra1, callback_rashi);
            return false;
        }

    }


}

function f20fillrashi(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "f20arashi") {
            document.getElementById('lstmultiplerashi').value = "";
            //var compcode = $('hdncompcode').value;
            //var unit=$('hdnunitcode').value;
            document.getElementById("divmultiplerashi").style.display = "block";
             document.getElementById('divmultiplerashi').style.top = findPos(document.getElementById('f20arashi'), "top");
       document.getElementById('divmultiplerashi').style.left = findPos(document.getElementById('f20arashi'), "left");
     

            var extra1 = document.getElementById('f20arashi').value;
            document.getElementById('f20arashi').focus();
            predictive_input.fill_rashi(extra1, callback_rashi);
            return false;
        }

    }


}

function callback_rashi(res) {
    ds = res.value;
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        var pkgitem = document.getElementById("lstmultiplerashi");
        pkgitem.options.length = 0;
        pkgitem.options[0] = new Option("Any Rashi", "0");
        pkgitem.options.length = 1;
        for (var i = 0; i < ds.Tables[0].Rows.length; ++i) {
            //pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].REASON_CODE+"-"+ds.Tables[0].Rows[i].REASON_NAME,ds.Tables[0].Rows[i].REASON_CODE);
            pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].CODE);
            pkgitem.options.length;
        }
    }
    document.getElementById('lstmultiplerashi').style.display = "block";
    document.getElementById('lstmultiplerashi').focus();
    return false;
}





function closerashi(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 27) {
        for (var i = 0; i < document.getElementById('lstmultiplerashi').options.length; ++i) {
            document.getElementById('lstmultiplerashi').options[i].selected = false;

        }
        document.getElementById('divmultiplerashi').style.display = "none";
        document.getElementById('f7rashi').value = "";
        document.getElementById('f8rashi').value = "";
        //document.getElementById('f7rashi').focus();

        return false;
    }
}

var name = "";
var house = "";
var description = "";
var nop = '0';
function multipleplanetinhouse() 
{

    if (document.getElementById('lstmultiplehouse').options[0].selected == true) {
        for (var h = 1; h <= 12; ++h) {
            for (var i = 0; i < document.getElementById('lstmultipleplanet').options.length; ++i) {
                if (document.getElementById('lstmultipleplanet').options[i].selected == true) {
                    nop = parseInt(nop) + parseInt(1);
                    name = name + document.getElementById('lstmultipleplanet').options[i].innerHTML + "-" + 'HOUSE' + h + "~";
                    description = description + document.getElementById('lstmultipleplanet').options[i].innerHTML + " and ";
                }
            }


            if (name != "") {
                name = name.slice(0, -1);

            }

            if (description != "") {
                description = description.slice(0, -5);

            }

            var book = document.getElementById('mbook').value
            var page = document.getElementById('mpage').value
            var filter = document.getElementById('mfilter').value
            var detail = document.getElementById('mdetail').value
            
            var chart = document.getElementById('f6chart').value
            var unique = document.getElementById('f6unique').value
            var fid = "PI_" + document.getElementById('f6id').innerHTML


            description = description + " " + 'together in any House';

            var today = new Date();
            var dd = today.getDate();
            var mm = today.getMonth() + 1; //January is 0!

            var yyyy = today.getFullYear();
            if (dd < 10) { dd = '0' + dd }
            if (mm < 10) { mm = '0' + mm }
            today = dd + '/' + mm + '/' + yyyy;
      predictive_input.multipleplanetinanyhouse(name, book, page, filter, detail, description, nop,chart,unique,fid,today);
            nop = '0';
            name = "";
            description = "";
           
        }
        alert('Saved Succesfully');
        house = "";
        document.getElementById('mbook').value = "";
        document.getElementById('mpage').value = "";
        document.getElementById('mfilter').value = "";
        document.getElementById('mdetail').value = "";
        document.getElementById('f6chart').value = "";
        document.getElementById('f6unique').value = "";
        return false;
    }





    else {





        for (var j = 0; j < document.getElementById('lstmultiplehouse').options.length; ++j) {
            if (document.getElementById('lstmultiplehouse').options[j].selected == true) {
                house = house + document.getElementById('lstmultiplehouse').options[j].innerHTML + "-";

            }
        }

        if (house != "") {
            house = house.slice(0, -1);

        }

        house = house.split('-')

        for (var k = 0; k < house.length; ++k) {
            for (var i = 0; i < document.getElementById('lstmultipleplanet').options.length; ++i) {
                if (document.getElementById('lstmultipleplanet').options[i].selected == true) {
                    nop = parseInt(nop) + parseInt(1);
                    name = name + document.getElementById('lstmultipleplanet').options[i].innerHTML + "-" + house[k] + "~";
                    description = description + document.getElementById('lstmultipleplanet').options[i].innerHTML + " and ";
                }
            }


            if (name != "") {
                name = name.slice(0, -1);

            }

            if (description != "") {
                description = description.slice(0, -5);

            }

            var book = document.getElementById('mbook').value
            var page = document.getElementById('mpage').value
            var filter = document.getElementById('mfilter').value
            var detail = document.getElementById('mdetail').value
            description = description + " " + 'together in any House';
             var chart = document.getElementById('f6chart').value
            var unique = document.getElementById('f6unique').value
            var fid = "PI_" + document.getElementById('f6id').innerHTML

            var today = new Date();
            var dd = today.getDate();
            var mm = today.getMonth() + 1; //January is 0!

            var yyyy = today.getFullYear();
            if (dd < 10) { dd = '0' + dd }
            if (mm < 10) { mm = '0' + mm }
            today = dd + '/' + mm + '/' + yyyy;
            predictive_input.multipleplanetinanyhouse(name, book, page, filter, detail, description, nop,chart,unique,fid,today);
            nop = '0';
            name = "";
            description = "";
           
        }
        alert('Saved Succesfully');
        house = "";
        document.getElementById('mbook').value = "";
        document.getElementById('mpage').value = "";
        document.getElementById('mfilter').value = "";
        document.getElementById('mdetail').value = "";
        return false;
    }
}



function planetinhouse() {


    if (document.getElementById('lstmultiplehouse').options[0].selected == true) {
        for (var h = 1; h <= 12; ++h) {
            var house = 'HOUSE' + h;
            var planet = document.getElementById('drpplanet').value;
            var name = planet +"-"+ house;
            var description = planet + " in " + house;
            var book = document.getElementById('txtbook').value;
            var page = document.getElementById('txtpage').value;
            var filter = document.getElementById('txtkey').value;
            var detail = document.getElementById('txtdetail').value;
            var unique = document.getElementById('f1unique').value;
            var chart = document.getElementById('f1chart').value;
            var fid ="PI_"+document.getElementById('f1id').innerHTML;
            var today = new Date();
            var dd = today.getDate();
            var mm = today.getMonth() + 1; //January is 0!

            var yyyy = today.getFullYear();
            if (dd < 10) { dd = '0' + dd }
            if (mm < 10) { mm = '0' + mm }
            today = mm + '/' + dd + '/' + yyyy;



            predictive_input.saveplanetonhouse(house, planet, name, description, book, page, filter, detail, chart, unique, fid,today)
            
        }
        alert('save successfully');
        document.getElementById('txtbook').value = "";
        document.getElementById('txtpage').value = "";
        document.getElementById('txtkey').value = "";
        document.getElementById('txtdetail').value = "";
        document.getElementById('f1unique').value="";
         document.getElementById('f1chart').value="";
        
        return false;
    }
    else {

        for (var j = 0; j < document.getElementById('lstmultiplehouse').options.length; ++j) {
            if (document.getElementById('lstmultiplehouse').options[j].selected == true) {
                var house = document.getElementById('lstmultiplehouse').options[j].innerHTML;
                var planet = document.getElementById('drpplanet').value;
                var name = planet +"-"+ house;
                var description = planet + " in " + house;
                var book = document.getElementById('txtbook').value;
                var page = document.getElementById('txtpage').value;
                var filter = document.getElementById('txtkey').value;
                var detail = document.getElementById('txtdetail').value;
                 var unique = document.getElementById('f1unique').value;
            var chart = document.getElementById('f1chart').value;
            var fid = "PI_" + document.getElementById('f1id').innerHTML;

            var today = new Date();
            var dd = today.getDate();
            var mm = today.getMonth() + 1; //January is 0!

            var yyyy = today.getFullYear();
            if (dd < 10) { dd = '0' + dd }
            if (mm < 10) { mm = '0' + mm }
            today = dd + '/' + mm + '/' + yyyy;


            predictive_input.saveplanetonhouse(house, planet, name, description, book, page, filter, detail, chart, unique, fid,today)
            }


        }
        alert('save successfully');
        document.getElementById('txtbook').value = "";
        document.getElementById('txtpage').value = "";
        document.getElementById('txtkey').value = "";
        document.getElementById('txtdetail').value = "";
        return false;
    }

}


function findentry() {
    var planet = document.getElementById('drpplanet').value;
     for (var j = 0; j < document.getElementById('lstmultiplehouse').options.length; ++j) {
            if (document.getElementById('lstmultiplehouse').options[j].selected == true) {
    var house = document.getElementById('lstmultiplehouse').options[j].innerHTML;}}
    predictive_input.find_entry(planet, house, callback_findentry);
    return false;
}


function callback_findentry(res) {
    var exec_data = res.value;
    if (exec_data.Tables[0].Rows.length == null ||exec_data.Tables[0].Rows.length == '0') {
        alert("There is no data available regarding your query.")
        return false;
    }
    else {
        if (exec_data.Tables[0].Rows[0].BOOK == null) {
            document.getElementById('txtbook').value = ""
        }
        else { document.getElementById('txtbook').value = exec_data.Tables[0].Rows[0].BOOK; }
        if (exec_data.Tables[0].Rows[0].PAGE_NO == null)
        {document.getElementById('txtpage').value = "";}
        else {
            document.getElementById('txtpage').value = exec_data.Tables[0].Rows[0].PAGE_NO;
        }

        document.getElementById('txtdetail').value = exec_data.Tables[0].Rows[0].DESCCLOB;
        if (exec_data.Tables[0].Rows[0].KEY_STRING == null)
        { document.getElementById('txtkey').value = ""; }
        else
        { document.getElementById('txtkey').value = exec_data.Tables[0].Rows[0].KEY_STRING; }
        document.getElementById('key').value=exec_data.Tables[0].Rows[0].KEY_STRING
        document.getElementById('drpplanet').value = exec_data.Tables[0].Rows[0].PLANET;
        document.getElementById('drphouse').value = exec_data.Tables[0].Rows[0].HOUSE;


    }
    return false;

}


function updatefindentry() {

    var planet = document.getElementById('drpplanet').value;
    var house = document.getElementById('drphouse').value;
    var filter = document.getElementById('key').value;
    var filternew = document.getElementById('txtkey').value;
    var detail = document.getElementById('txtdetail').value;
    var book = document.getElementById('txtbook').value;
    var page = document.getElementById('txtpage').value;
    predictive_input.update_findentry(planet, house, filter,filternew,detail,book,page)
    alert('updated successfully');
    return false;
}


function findmultipleentry()
 { 

 for (var j = 0; j < document.getElementById('lstmultiplehouse').options.length; ++j)
  {
      if (document.getElementById('lstmultiplehouse').options[j].selected == true) 
      {
          for (var i = 0; i < document.getElementById('lstmultipleplanet').options.length; ++i) 
          {
              if (document.getElementById('lstmultipleplanet').options[i].selected == true) 
              {
                  name = name + document.getElementById('lstmultipleplanet').options[i].innerHTML + "-" + document.getElementById('lstmultiplehouse').options[j].innerHTML + "~";
              }
          }
      }
  }

            if (name != "") {
                name = name.slice(0, -1);
                document.getElementById('mname').value = name;
        }
        predictive_input.find_multiple_entry(name, callback_findmultipleentry);
        name = "";
        return false;
    }


    function callback_findmultipleentry(res) {
        var exec_data = res.value;
        if (exec_data.Tables[0].Rows.length == null || exec_data.Tables[0].Rows.length == '0') {
            alert("There is no data available regarding your query.")
            return false;
        }
        else {
            if (exec_data.Tables[0].Rows[0].BOOK == null) {
                document.getElementById('mbook').value = ""
            }
            else { document.getElementById('mbook').value = exec_data.Tables[0].Rows[0].BOOK; }
            if (exec_data.Tables[0].Rows[0].PAGE_NO == null)
            { document.getElementById('mpage').value = ""; }
            else {
                document.getElementById('mpage').value = exec_data.Tables[0].Rows[0].PAGE_NO;
            }

            document.getElementById('mdetail').value = exec_data.Tables[0].Rows[0].DESC_CLOB;
            if (exec_data.Tables[0].Rows[0].KEY_STRING == null)
            { document.getElementById('mfilter').value = ""; }
            else
            { document.getElementById('mfilter').value = exec_data.Tables[0].Rows[0].KEY_STRING; }
            document.getElementById('mhiddenfilter').value = exec_data.Tables[0].Rows[0].KEY_STRING
        }
        return false;
    }


    function updatemultiplefindentry() {
        var name = document.getElementById('mname').value;

        var filter = document.getElementById('mhiddenfilter').value;
        var filternew = document.getElementById('mfilter').value;
        var detail = document.getElementById('mdetail').value;
        var book = document.getElementById('mbook').value;
        var page = document.getElementById('mpage').value;
        predictive_input.update_multiplefindentry(name, filter, filternew, detail, book, page)
        alert('updated successfully');
        document.getElementById('mbook').value = "";
        document.getElementById('mpage').value = "";
        document.getElementById('mfilter').value = "";
        document.getElementById('mdetail').value = "";
        return false;
    }


    function planetinrashi() {
    
    var f2planet=document.getElementById('f2planet').value;
    var f2rashi=document.getElementById('f2rashi').value;
    var f2book=document.getElementById('f2book').value;
    var f2page=document.getElementById('f2page').value;
    var f2filter=document.getElementById('f2filter').value;
    var f2detail = document.getElementById('f2detail').value;
    var chart = document.getElementById('f2chart').value;
    var unique = document.getElementById('f2unique').value;
    var fid ="PI_"+document.getElementById('f2id').innerHTML;
    var f2description = f2planet + " in " + f2rashi;
    var f2name = f2planet + " - " + f2rashi;
    var today = new Date();
    var dd = today.getDate();
    var mm = today.getMonth() + 1; //January is 0!

    var yyyy = today.getFullYear();
    if (dd < 10) { dd = '0' + dd }
    if (mm < 10) { mm = '0' + mm }
    today = dd + '/' + mm + '/' + yyyy;
    
   predictive_input.save_f2predictiveinput(f2planet,f2rashi,f2book,f2page,f2filter,f2detail,f2description,f2name,chart,unique,fid,today);
    alert('saved successfully');
    document.getElementById('f2rashi').value = "";
    document.getElementById('f2planet').value = "";
    document.getElementById('f2book').value = "";
    document.getElementById('f2page').value = "";
    document.getElementById('f2filter').value = "";
    document.getElementById('f2detail').value = "";
     document.getElementById('f2chart').value = "";
      document.getElementById('f2unique').value = "";
    return false;

}


function houseinrashi() {

    var f3house = document.getElementById('f3house').value;
    var f3rashi = document.getElementById('f3rashi').value;
    var f3book = document.getElementById('f3book').value;
    var f3page = document.getElementById('f3page').value;
    var f3filter = document.getElementById('f3filter').value;
    var f3detail = document.getElementById('f3detail').value;
    var chart= document.getElementById('f3chart').value;
    var unique= document.getElementById('f3unique').value;
    var fid="PI_"+document .getElementById('f3id').innerHTML;
    var f3description = f3house + " in " + f3rashi;
    var f3name = f3house + " - " + f3rashi;
    var today = new Date();
    var dd = today.getDate();
    var mm = today.getMonth() + 1; //January is 0!

    var yyyy = today.getFullYear();
    if (dd < 10) { dd = '0' + dd }
    if (mm < 10) { mm = '0' + mm }
    today = dd + '/' + mm + '/' + yyyy;
    
    predictive_input.save_f3predictiveinput(f3house, f3rashi, f3book, f3page, f3filter, f3detail, f3description, f3name,chart,unique,fid,today);
    alert('saved successfully');
    document.getElementById('f3rashi').value = "";
    document.getElementById('f3house').value = "";
    document.getElementById('f3book').value = "";
    document.getElementById('f3page').value = "";
    document.getElementById('f3filter').value = "";
    document.getElementById('f3detail').value = "";
    document.getElementById('f3chart').value ="";
     document.getElementById('f3unique').value ="";
    
    return false;

}

function planetinrashiinhouse() {
    var f4planet = document.getElementById('f4planet').value;
    var f4house = document.getElementById('f4house').value;
    var f4rashi = document.getElementById('f4rashi').value;
    var f4book = document.getElementById('f4book').value;
    var f4page = document.getElementById('f4page').value;
    var f4filter = document.getElementById('f4filter').value;
    var f4detail = document.getElementById('f4detail').value;
    var chart =document.getElementById('f4chart').value;
    var unique =document.getElementById('f4unique').value;
    var fid ="PI_"+document.getElementById('f4id').innerHTML;
  
    var f4description = f4planet + " in " + f4rashi + " in " + f4house;
    var f4name = f4planet + " - " + f4rashi + " - " + f4house;
    var today = new Date();
    var dd = today.getDate();
    var mm = today.getMonth() + 1; //January is 0!

    var yyyy = today.getFullYear();
    if (dd < 10) { dd = '0' + dd }
    if (mm < 10) { mm = '0' + mm }
    today = dd + '/' + mm + '/' + yyyy;
    
    predictive_input.save_f4predictiveinput(f4planet,f4house,f4rashi,f4book, f4page, f4filter, f4detail, f4description, f4name,chart,unique,fid,today);
    alert('saved successfully');
    document.getElementById('f4rashi').value = "";
    document.getElementById('f4house').value = "";
    document.getElementById('f4book').value = "";
    document.getElementById('f4page').value = "";
    document.getElementById('f4filter').value = "";
    document.getElementById('f4detail').value = "";
    document.getElementById('f4planet').value = "";
    document.getElementById('f4chart').value = "";
    document.getElementById('f4unique').value = "";

    return false;

}

function planetinconstelation() {
    var f5planet = document.getElementById('f5planet').value;
    var f5constelation = document.getElementById('f5constelation').value;
    var f5book = document.getElementById('f5book').value;
    var f5page = document.getElementById('f5page').value;
    var f5filter = document.getElementById('f5filter').value;
    var f5detail = document.getElementById('f5detail').value;
    var chart = document.getElementById('f5chart').value;
    var unique = document.getElementById('f5unique').value;
    var fid ="PI_"+document.getElementById('f5id').innerHTML;
    var f5description = f5planet + " in " + f5constelation;
    var f5name = f5planet + " - " + f5constelation;
    var today = new Date();
    var dd = today.getDate();
    var mm = today.getMonth() + 1; //January is 0!

    var yyyy = today.getFullYear();
    if (dd < 10) { dd = '0' + dd }
    if (mm < 10) { mm = '0' + mm }
    today = dd + '/' + mm + '/' + yyyy;
    
    predictive_input.save_f5predictiveinput(f5planet, f5constelation, f5book, f5page, f5filter, f5detail, f5description, f5name,chart,unique,fid,today);
    alert('saved successfully');
    document.getElementById('f5planet').value = "";
    document.getElementById('f5constelation').value = "";
    document.getElementById('f5book').value = "";
    document.getElementById('f5page').value = "";
    document.getElementById('f5filter').value = "";
    document.getElementById('f5detail').value = "";
    document.getElementById('f5chart').value = "";
    document.getElementById('f5unique').value = "";
   

    return false;

}


function findplanetinrashi() {
    var f2planet = document.getElementById('f2planet').value;
    var f2rashi = document.getElementById('f2rashi').value;
    predictive_input.fetch_f2predictiveinput(f2planet, f2rashi,callback_planetrashi);
    return false;
}


function callback_planetrashi(res) {
    var exec_data = res.value;
    if (exec_data.Tables[0].Rows.length == null || exec_data.Tables[0].Rows.length == '0') {
        alert("There is no data available regarding your query.")
        return false;
    }
    else {
        if (exec_data.Tables[0].Rows[0].BOOK == null) {
            document.getElementById('f2book').value = ""
        }
        else { document.getElementById('f2book').value = exec_data.Tables[0].Rows[0].BOOK; }
        if (exec_data.Tables[0].Rows[0].PAGE_NO == null)
        { document.getElementById('f2page').value = ""; }
        else {
            document.getElementById('f2page').value = exec_data.Tables[0].Rows[0].PAGE_NO;
        }

        document.getElementById('f2detail').value = exec_data.Tables[0].Rows[0].DESCCLOB;
        if (exec_data.Tables[0].Rows[0].KEY_STRING == null)
        { document.getElementById('f2filter').value = ""; }
        else
        { document.getElementById('f2filter').value = exec_data.Tables[0].Rows[0].KEY_STRING; }
        document.getElementById('f2hiddenkey').value = exec_data.Tables[0].Rows[0].KEY_STRING
        document.getElementById('f2planet').value = exec_data.Tables[0].Rows[0].PLANET;
        document.getElementById('f2rashi').value = exec_data.Tables[0].Rows[0].RASHI;


    }
    return false;



}

function findhouseinrashi() {
    var f3house = document.getElementById('f3house').value;
    var f3rashi = document.getElementById('f3rashi').value;
    predictive_input.fetch_f3predictiveinput(f3house, f3rashi, callback_houseinrashi);
    return false;
}


function callback_houseinrashi(res) {
    var exec_data = res.value;
    if (exec_data.Tables[0].Rows.length == null || exec_data.Tables[0].Rows.length == '0') {
        alert("There is no data available regarding your query.")
        return false;
    }
    else {
        if (exec_data.Tables[0].Rows[0].BOOK == null) {
            document.getElementById('f3book').value = ""
        }
        else { document.getElementById('f3book').value = exec_data.Tables[0].Rows[0].BOOK; }
        if (exec_data.Tables[0].Rows[0].PAGE_NO == null)
        { document.getElementById('f3page').value = ""; }
        else {
            document.getElementById('f3page').value = exec_data.Tables[0].Rows[0].PAGE_NO;
        }

        document.getElementById('f3detail').value = exec_data.Tables[0].Rows[0].DESCCLOB;
        if (exec_data.Tables[0].Rows[0].KEY_STRING == null)
        { document.getElementById('f3filter').value = ""; }
        else
        { document.getElementById('f3filter').value = exec_data.Tables[0].Rows[0].KEY_STRING; }
        document.getElementById('f3hiddenkey').value = exec_data.Tables[0].Rows[0].KEY_STRING
        document.getElementById('f3house').value = exec_data.Tables[0].Rows[0].HOUSE;
        document.getElementById('f3rashi').value = exec_data.Tables[0].Rows[0].RASHI;


    }
    return false;



}



function findplanetinrashiinhouse() {
    var f4house = document.getElementById('f4house').value;
    var f4rashi = document.getElementById('f4rashi').value;
    var f4planet = document.getElementById('f4planet').value;
    predictive_input.fetch_f4predictiveinput(f4house, f4rashi,f4planet, callback_planetinrashiinhouse);
    return false;
}


function callback_planetinrashiinhouse(res) {
    var exec_data = res.value;
    if (exec_data.Tables[0].Rows.length == null || exec_data.Tables[0].Rows.length == '0') {
        alert("There is no data available regarding your query.")
        return false;
    }
    else {
        if (exec_data.Tables[0].Rows[0].BOOK == null) {
            document.getElementById('f4book').value = ""
        }
        else { document.getElementById('f4book').value = exec_data.Tables[0].Rows[0].BOOK; }
        if (exec_data.Tables[0].Rows[0].PAGE_NO == null)
        { document.getElementById('f4page').value = ""; }
        else {
            document.getElementById('f4page').value = exec_data.Tables[0].Rows[0].PAGE_NO;
        }

        document.getElementById('f4detail').value = exec_data.Tables[0].Rows[0].DESCCLOB;
        if (exec_data.Tables[0].Rows[0].KEY_STRING == null)
        { document.getElementById('f4filter').value = ""; }
        else
        { document.getElementById('f4filter').value = exec_data.Tables[0].Rows[0].KEY_STRING; }
        document.getElementById('f4hiddenkey').value = exec_data.Tables[0].Rows[0].KEY_STRING
        document.getElementById('f4house').value = exec_data.Tables[0].Rows[0].HOUSE;
        document.getElementById('f4rashi').value = exec_data.Tables[0].Rows[0].RASHI;
        document.getElementById('f4planet').value = exec_data.Tables[0].Rows[0].PLANET;


    }
    return false;



}

function findplanetinconstelation() {
    var f5planet = document.getElementById('f5planet').value;
    var f5constelation = document.getElementById('f5constelation').value;
    predictive_input.fetch_f5predictiveinput(f5planet, f5constelation, callback_planetinconstelation);
    return false;
}


function callback_planetinconstelation(res) {
    var exec_data = res.value;
    if (exec_data.Tables[0].Rows.length == null || exec_data.Tables[0].Rows.length == '0') {
        alert("There is no data available regarding your query.")
        return false;
    }
    else {
        if (exec_data.Tables[0].Rows[0].BOOK == null) {
            document.getElementById('f5book').value = ""
        }
        else { document.getElementById('f5book').value = exec_data.Tables[0].Rows[0].BOOK; }
        if (exec_data.Tables[0].Rows[0].PAGE_NO == null)
        { document.getElementById('f5page').value = ""; }
        else {
            document.getElementById('f5page').value = exec_data.Tables[0].Rows[0].PAGE_NO;
        }

        document.getElementById('f5detail').value = exec_data.Tables[0].Rows[0].DESCCLOB;
        if (exec_data.Tables[0].Rows[0].KEY_STRING == null)
        { document.getElementById('f5filter').value = ""; }
        else
        { document.getElementById('f5filter').value = exec_data.Tables[0].Rows[0].KEY_STRING; }
        document.getElementById('f5hiddenkey').value = exec_data.Tables[0].Rows[0].KEY_STRING
        document.getElementById('f5planet').value = exec_data.Tables[0].Rows[0].PLANET;
        document.getElementById('f5constelation').value = exec_data.Tables[0].Rows[0].CONSTELATION;
        


    }
    return false;



}

function updateplanetinrashi() {
    var f2planet = document.getElementById('f2planet').value;
    var f2rashi = document.getElementById('f2rashi').value;
    var f2filter = document.getElementById('f2hiddenkey').value;
    var f2filternew = document.getElementById('f2filter').value;
    var detail = document.getElementById('f2detail').value;
    var book = document.getElementById('f2book').value;
    var page = document.getElementById('f2page').value;
    predictive_input.update_planetinrashi(f2planet, f2rashi, f2filter, f2filternew, detail, book, page)
    alert('updated successfully');

    document.getElementById('f2rashi').value = "";
    document.getElementById('f2planet').value= "";
    document.getElementById('f2book').value = "";
    document.getElementById('f2page').value = "";
    document.getElementById('f2filter').value = "";
    document.getElementById('f2detail').value= "";
    
   
    return false;
}


function updatehouseinrashi() {
    var f3house = document.getElementById('f3house').value;
    var f3rashi = document.getElementById('f3rashi').value;
    var f3filter = document.getElementById('f3hiddenkey').value;
    var f3filternew = document.getElementById('f3filter').value;
    var detail = document.getElementById('f3detail').value;
    var book = document.getElementById('f3book').value;
    var page = document.getElementById('f3page').value;
    predictive_input.update_houseinrashi(f3house, f3rashi, f3filter, f3filternew, detail, book, page)
    alert('updated successfully');
    document.getElementById('f3rashi').value = "";
    document.getElementById('f3house').value = "";
    document.getElementById('f3book').value = "";
    document.getElementById('f3page').value = "";
    document.getElementById('f3filter').value = "";
    document.getElementById('f3detail').value = "";
    return false;
}

function updateplanetinrashiinhouse() {
    var f4house = document.getElementById('f4house').value;
    var f4rashi = document.getElementById('f4rashi').value;
    var f4planet = document.getElementById('f4planet').value;
    var f4filter = document.getElementById('f4hiddenkey').value;
    var f4filternew = document.getElementById('f4filter').value;
    var detail = document.getElementById('f4detail').value;
    var book = document.getElementById('f4book').value;
    var page = document.getElementById('f4page').value;
    predictive_input.update_planetinrashiinhouse(f4house, f4rashi, f4planet, f4filter, f4filternew, detail, book, page)
    alert('updated successfully');
    document.getElementById('f4rashi').value = "";
    document.getElementById('f4planet').value = "";
    document.getElementById('f4house').value = "";
    document.getElementById('f4book').value = "";
    document.getElementById('f4page').value = "";
    document.getElementById('f4filter').value = "";
    document.getElementById('f4detail').value = "";
    return false;
}


function updateplanetinconstelation() {
    var f5constelation = document.getElementById('f5constelation').value;
    var f5planet = document.getElementById('f5planet').value;
    var f5filter = document.getElementById('f5hiddenkey').value;
    var f5filternew = document.getElementById('f5filter').value;
    var detail = document.getElementById('f5detail').value;
    var book = document.getElementById('f5book').value;
    var page = document.getElementById('f5page').value;
    predictive_input.update_planetinconstelation(f5planet, f5constelation, f5filter, f5filternew, detail, book, page)
    alert('updated successfully');
    
    document.getElementById('f5planet').value = "";
    document.getElementById('f5constelation').value = "";
    document.getElementById('f5book').value = "";
    document.getElementById('f5page').value = "";
    document.getElementById('f5filter').value = "";
    document.getElementById('f5detail').value = "";
    return false;
}




var rashi = "";
var r = "";
function f7planetinrashi() {



    if (document.getElementById('lstmultiplerashi').options[0].selected == true) {
        for (var h = 1; h <= 12; ++h) {
            if (h == '1')
            { r = 'Aries' }

            if (h == '2')
            { r = 'Taurus' }

            if (h == '3')
            { r = 'Gemini' }

            if (h == '4')
            { r = 'Cancer' }

            if (h == '5')
            { r = 'Leo' }

            if (h == '6')
            { r = 'Virgo' }

            if (h == '7')
            { r = 'Libra' }

            if (h == '8')
            { r = 'Scorpio' }

            if (h == '9')
            { r = 'Sagittarius' }

            if (h == '10')
            { r = 'Capricorn' }

            if (h == '11')
            { r = 'Aquarius' }

            if (h == '12')
            { r = 'Pisces' }
            for (var i = 0; i < document.getElementById('lstmultipleplanet').options.length; ++i) {
                if (document.getElementById('lstmultipleplanet').options[i].selected == true) {
                    nop = parseInt(nop) + parseInt(1);
                    name = name + document.getElementById('lstmultipleplanet').options[i].innerHTML + "-" + r + "~";
                    description = description + document.getElementById('lstmultipleplanet').options[i].innerHTML + " and ";
                }
            }


            if (name != "") {
                name = name.slice(0, -1);

            }

            if (description != "") {
                description = description.slice(0, -5);

            }

            var book = document.getElementById('f7book').value
            var page = document.getElementById('f7page').value
            var filter = document.getElementById('f7filter').value
            var detail = document.getElementById('f7detail').value
            var chart =   document.getElementById('f7chart').value
            var unique =  document.getElementById('f7unique').value
            var fid ="PI_"+document .getElementById ('f7id').innerHTML
            description = description + " " + 'together in any Rashi';
            var today = new Date();
            var dd = today.getDate();
            var mm = today.getMonth() + 1; //January is 0!

            var yyyy = today.getFullYear();
            if (dd < 10) { dd = '0' + dd }
            if (mm < 10) { mm = '0' + mm }
            today = dd + '/' + mm + '/' + yyyy;
            
            predictive_input.multipleplanetinanyhouse(name, book, page, filter, detail, description, nop,chart,unique,fid,today);
            nop = '0';
            name = "";
            description = "";
            
        }
        alert('Saved Succesfully');
        rashi = "";
        document.getElementById('f7book').value = "";
        document.getElementById('f7page').value = "";
        document.getElementById('f7filter').value = "";
        document.getElementById('f7detail').value = "";
         document.getElementById('f7chart').value = "";
         document.getElementById('f7unique').value = "";
        return false;
    }





    else {





        for (var j = 0; j < document.getElementById('lstmultiplerashi').options.length; ++j) {
            if (document.getElementById('lstmultiplerashi').options[j].selected == true) {
                rashi = rashi + document.getElementById('lstmultiplerashi').options[j].innerHTML + "-";

            }
        }

        if (rashi != "") {
            rashi = rashi.slice(0, -1);

        }

        rashi = rashi.split('-')

        for (var k = 0; k < rashi.length; ++k) {
            for (var i = 0; i < document.getElementById('lstmultipleplanet').options.length; ++i) {
                if (document.getElementById('lstmultipleplanet').options[i].selected == true) {
                    nop = parseInt(nop) + parseInt(1);
                    name = name + document.getElementById('lstmultipleplanet').options[i].innerHTML + "-" + rashi[k] + "~";
                    description = description + document.getElementById('lstmultipleplanet').options[i].innerHTML + " and ";
                }
            }


            if (name != "") {
                name = name.slice(0, -1);

            }

            if (description != "") {
                description = description.slice(0, -5);

            }

            var book = document.getElementById('f7book').value
            var page = document.getElementById('f7page').value
            var filter = document.getElementById('f7filter').value
            var detail = document.getElementById('f7detail').value
            var chart =   document.getElementById('f7chart').value
            var unique =  document.getElementById('f7unique').value
            var fid ="PI_"+document .getElementById ('f7id').innerHTML
            
            description = description + " " + 'together in any Rashi';
            predictive_input.multipleplanetinanyhouse(name, book, page, filter, detail, description, nop,chart,unique,fid);
            nop = '0';
            name = "";
            description = "";
           
        }
        alert('Saved Succesfully');
        rashi = "";
        document.getElementById('f7book').value = "";
        document.getElementById('f7page').value = "";
        document.getElementById('f7filter').value = "";
        document.getElementById('f7detail').value = "";
        document.getElementById('f7chart').value = "";
        document.getElementById('f7unique').value = "";
        return false;
    }
}








function f7findplanetinrashi() {

    for (var j = 0; j < document.getElementById('lstmultiplerashi').options.length; ++j) {
        if (document.getElementById('lstmultiplerashi').options[j].selected == true) {
            for (var i = 0; i < document.getElementById('lstmultipleplanet').options.length; ++i) {
                if (document.getElementById('lstmultipleplanet').options[i].selected == true) {
                    name = name + document.getElementById('lstmultipleplanet').options[i].innerHTML + "-" + document.getElementById('lstmultiplerashi').options[j].innerHTML + "~";
                }
            }
        }
    }

    if (name != "") {
        name = name.slice(0, -1);
        document.getElementById('f7name').value = name;
    }
    predictive_input.find_multiple_entry(name, callback_f7findmultipleentry);
    name = "";
    return false;
}


function callback_f7findmultipleentry(res) {
    var exec_data = res.value;
    if (exec_data.Tables[0].Rows.length == null || exec_data.Tables[0].Rows.length == '0') {
        alert("There is no data available regarding your query.")
        return false;
    }
    else {
        if (exec_data.Tables[0].Rows[0].BOOK == null) {
            document.getElementById('f7book').value = ""
        }
        else { document.getElementById('f7book').value = exec_data.Tables[0].Rows[0].BOOK; }
        if (exec_data.Tables[0].Rows[0].PAGE_NO == null)
        { document.getElementById('f7page').value = ""; }
        else {
            document.getElementById('f7page').value = exec_data.Tables[0].Rows[0].PAGE_NO;
        }

        document.getElementById('f7detail').value = exec_data.Tables[0].Rows[0].DESC_CLOB;
        if (exec_data.Tables[0].Rows[0].KEY_STRING == null)
        { document.getElementById('f7filter').value = ""; }
        else
        { document.getElementById('f7filter').value = exec_data.Tables[0].Rows[0].KEY_STRING; }
        document.getElementById('f7hiddenfilter').value = exec_data.Tables[0].Rows[0].KEY_STRING
    }
    return false;
}


function f7updateplanetinrashi(){
    var name = document.getElementById('f7name').value;

    var filter = document.getElementById('f7hiddenfilter').value;
    var filternew = document.getElementById('f7filter').value;
    var detail = document.getElementById('f7detail').value;
    var book = document.getElementById('f7book').value;
    var page = document.getElementById('f7page').value;
    predictive_input.update_multiplefindentry(name, filter, filternew, detail, book, page)
    alert('updated successfully');
    return false;
}



function f8planetinhouseinrashi() {
    if (document.getElementById('lstmultiplerashi').options[0].selected == true) {
        for (var h = 1; h <= 12; ++h) {
            if (h == '1')
            { r = 'Aries' }

            if (h == '2')
            { r = 'Taurus' }

            if (h == '3')
            { r = 'Gemini' }

            if (h == '4')
            { r = 'Cancer' }

            if (h == '5')
            { r = 'Leo' }

            if (h == '6')
            { r = 'Virgo' }

            if (h == '7')
            { r = 'Libra' }

            if (h == '8')
            { r = 'Scorpio' }

            if (h == '9')
            { r = 'Sagittarius' }

            if (h == '10')
            { r = 'Capricorn' }

            if (h == '11')
            { r = 'Aquarius' }

            if (h == '12')
            { r = 'Pisces' }

            if (document.getElementById('lstmultiplehouse').options[0].selected == true) {
                for (var mh = 1; mh <= 12; ++mh) {

                    for (var i = 0; i < document.getElementById('lstmultipleplanet').options.length; ++i) {
                        if (document.getElementById('lstmultipleplanet').options[i].selected == true) {
                            nop = parseInt(nop) + parseInt(1);
                            name = name + document.getElementById('lstmultipleplanet').options[i].innerHTML + "-" + r + "-" + 'HOUSE' + mh + "~";
                            description = description + document.getElementById('lstmultipleplanet').options[i].innerHTML + " and ";
                        }
                    }


                    if (name != "") {
                        name = name.slice(0, -1);

                    }

                    if (description != "") {
                        description = description.slice(0, -5);

                    }

                    var book = document.getElementById('f8book').value
                    var page = document.getElementById('f8page').value
                    var filter = document.getElementById('f8filter').value
                    var detail = document.getElementById('f8detail').value
                    var chart = document.getElementById('f8chart').value
                    var unique=document.getElementById('f8unique').value
                    var fid ="PI_"+document.getElementById('f8id').innerHTML
                    description = description + " " + 'together in any Rashi in any House';
                    var today = new Date();
                    var dd = today.getDate();
                    var mm = today.getMonth() + 1; //January is 0!

                    var yyyy = today.getFullYear();
                    if (dd < 10) { dd = '0' + dd }
                    if (mm < 10) { mm = '0' + mm }
                    today = dd + '/' + mm + '/' + yyyy;
                    predictive_input.multipleplanetinanyhouse(name, book, page, filter, detail, description, nop,chart,unique,fid,today);
                    nop = '0';
                    name = "";
                    description = "";
                   
                } 
            } 
        }
        alert('Saved Succesfully');
        rashi = "";
        house = "";
        document.getElementById('f8book').value = "";
        document.getElementById('f8page').value = "";
        document.getElementById('f8filter').value = "";
        document.getElementById('f8detail').value = "";
        document.getElementById('f8chart').value = "";
        document.getElementById('f8unique').value = "";
        
        return false;
    }





    else {





        for (var j = 0; j < document.getElementById('lstmultiplerashi').options.length; ++j) {
            if (document.getElementById('lstmultiplerashi').options[j].selected == true) {
                rashi = rashi + document.getElementById('lstmultiplerashi').options[j].innerHTML + "-";

            }
        }

        if (rashi != "") {
            rashi = rashi.slice(0, -1);

        }

        rashi = rashi.split('-')


        for (var j = 0; j < document.getElementById('lstmultiplehouse').options.length; ++j) {
            if (document.getElementById('lstmultiplehouse').options[j].selected == true) {
                house = house + document.getElementById('lstmultiplehouse').options[j].innerHTML + "-";

            }
        }

        if (house != "") {
            house = house.slice(0, -1);

        }

        house = house.split('-')

        for (var k = 0; k < rashi.length; ++k) {
            for (var f8h = 0; f8h < house.length; ++f8h) {
                for (var i = 0; i < document.getElementById('lstmultipleplanet').options.length; ++i) {
                    if (document.getElementById('lstmultipleplanet').options[i].selected == true) {
                        nop = parseInt(nop) + parseInt(1);
                        name = name + document.getElementById('lstmultipleplanet').options[i].innerHTML + "-" + rashi[k] + "-" + house[f8h] + "~";
                        description = description + document.getElementById('lstmultipleplanet').options[i].innerHTML + " and ";
                    }
                }


                if (name != "") {
                    name = name.slice(0, -1);

                }

                if (description != "") {
                    description = description.slice(0, -5);

                }

                var book = document.getElementById('f8book').value
                var page = document.getElementById('f8page').value
                var filter = document.getElementById('f8filter').value
                var detail = document.getElementById('f8detail').value
                var chart = document.getElementById('f8chart').value
                var unique=document.getElementById('f8unique').value
                var fid ="PI_"+document.getElementById('f8id').innerHTML

                description = description + " " + 'together in any Rashi in any House';

                var today = new Date();
                var dd = today.getDate();
                var mm = today.getMonth() + 1; //January is 0!

                var yyyy = today.getFullYear();
                if (dd < 10) { dd = '0' + dd }
                if (mm < 10) { mm = '0' + mm }
                today = dd + '/' + mm + '/' + yyyy;
                predictive_input.multipleplanetinanyhouse(name, book, page, filter, detail, description, nop,chart,unique,fid,today);
                nop = '0';
                name = "";
                description = "";
               
            } 
        }
        alert('Saved Succesfully');
        rashi = "";
        house = "";
        document.getElementById('f8book').value = "";
        document.getElementById('f8page').value = "";
        document.getElementById('f8filter').value = "";
        document.getElementById('f8detail').value = "";
        return false;
    }



}


function f8findplanetinrashiinhouse() {

    for (var j = 0; j < document.getElementById('lstmultiplerashi').options.length; ++j) {
        if (document.getElementById('lstmultiplerashi').options[j].selected == true) {

            for (var f8eh = 0; f8eh < document.getElementById('lstmultiplehouse').options.length; ++f8eh) {
                if (document.getElementById('lstmultiplehouse').options[f8eh].selected == true) {

                    for (var i = 0; i < document.getElementById('lstmultipleplanet').options.length; ++i) {
                        if (document.getElementById('lstmultipleplanet').options[i].selected == true) {
                            name = name + document.getElementById('lstmultipleplanet').options[i].innerHTML + "-" + document.getElementById('lstmultiplerashi').options[j].innerHTML + "-" + document.getElementById('lstmultiplehouse').options[j].innerHTML + "~";
                        }
                    }
                }
            }
        } 
    }
    if (name != "") {
        name = name.slice(0, -1);
        document.getElementById('f8name').value = name;
    }
    predictive_input.find_multiple_entry(name, callback_f8findmultipleentry);
    name = "";
    return false;
}



function callback_f8findmultipleentry(res) {
    var exec_data = res.value;
    if (exec_data.Tables[0].Rows.length == null || exec_data.Tables[0].Rows.length == '0') {
        alert("There is no data available regarding your query.")
        return false;
    }
    else {
        if (exec_data.Tables[0].Rows[0].BOOK == null) {
            document.getElementById('f8book').value = ""
        }
        else { document.getElementById('f8book').value = exec_data.Tables[0].Rows[0].BOOK; }
        if (exec_data.Tables[0].Rows[0].PAGE_NO == null)
        { document.getElementById('f8page').value = ""; }
        else {
            document.getElementById('f8page').value = exec_data.Tables[0].Rows[0].PAGE_NO;
        }

        document.getElementById('f8detail').value = exec_data.Tables[0].Rows[0].DESC_CLOB;
        if (exec_data.Tables[0].Rows[0].KEY_STRING == null)
        { document.getElementById('f8filter').value = ""; }
        else
        { document.getElementById('f8filter').value = exec_data.Tables[0].Rows[0].KEY_STRING; }
        document.getElementById('f8hiddenfilter').value = exec_data.Tables[0].Rows[0].KEY_STRING
    }
    return false;
}

function f8updateplanetinrashiinhouse() {
    var name = document.getElementById('f8name').value;

    var filter = document.getElementById('f8hiddenfilter').value;
    var filternew = document.getElementById('f8filter').value;
    var detail = document.getElementById('f8detail').value;
    var book = document.getElementById('f8book').value;
    var page = document.getElementById('f8page').value;
    predictive_input.update_multiplefindentry(name, filter, filternew, detail, book, page)
    alert('updated successfully');
    return false;
}



function lordhouseinhousewithplanet() {

var lordofhouse = document.getElementById('f22house').value;
var inhouse = document.getElementById('f22ahouse').value;
    predictive_input.lordhouseinto_house(lordofhouse, inhouse,callback_lordhouseinhousewithplanet)

       
    
}


function callback_lordhouseinhousewithplanet(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f22grid').innerHTML = "";
        document.getElementById('f22div').style.display = 'block';
        document.getElementById('f22div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f22grid').style.display = "block";

        if (document.getElementById("f22grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f22div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f22grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f22grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f22div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Rashi of House1" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Lord Of House" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "House" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Rashi" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Rashi Of House" + "</td>"

 


        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f22rh1_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI_CODE'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f22lh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LORD_OF_HOUSE'] + "</textarea>"
                buf2 += "</td>"




                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f22h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['SECOND_HOUSE'] + "</textarea>"
                buf2 += "</td>"



                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f22r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['WITHLORD_OF_HOUSE'] + "</textarea>"
                buf2 += "</td>"



                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f22rh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['FIRST_HOUSE'] + "</textarea>"
                buf2 += "</td>"



                buf2 += "</tr>"
            }
        }
        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f22grid').innerHTML = temp_del1;



    }



}


function f22_save() 
{nop='1'
var name="";
var planet="";
   for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i)
    {
                var lagnarashi=document.getElementById('f22rh1_' + i).value
                var lord = document.getElementById('f22lh_' + i).value
                var house =document.getElementById('f22ahouse').value
                var lordofhouse =document.getElementById('f22house').value
               
                var unique = document.getElementById('f22unique').value
                var fid ="PI_"+document.getElementById('f22id').innerHTML
                
                
                
                var rashi = document.getElementById('f22rh_'+i).value
                     for (var k = 0; k < document.getElementById('lstmultipleplanet').options.length; ++k) 
                      {
                       if (document.getElementById('lstmultipleplanet').options[k].selected == true) 
                         { nop = parseInt(nop) + parseInt(1);
                            name=name+document.getElementById('lstmultipleplanet').options[k].innerHTML+rashi+house;
                            var planet=planet+document.getElementById('lstmultipleplanet').options[k].innerHTML+' and ';
                         }
                      }
    
    
    
    
               if(planet!="")
               {planet=planet.slice(0,-5)}
                
                
                
               
            var combination=lord+rashi+house+name;
            var book = document.getElementById('f22book').value
            var filter = document.getElementById('f22filter').value
            var page = document.getElementById('f22page').value
            var description = 'Lord of ' + lordofhouse+ ' with ' + planet;
            var detail = document.getElementById('f22detail').value
            var chart = document.getElementById('f22chart').value

            var today = new Date();
            var dd = today.getDate();
            var mm = today.getMonth() + 1; //January is 0!

            var yyyy = today.getFullYear();
            if (dd < 10) { dd = '0' + dd }
            if (mm < 10) { mm = '0' + mm }
            today = dd + '/' + mm + '/' + yyyy;
         predictive_input.save_lordwithplanetwithmalifics(lagnarashi,lordofhouse,lord,house,rashi,combination, book, page, filter, detail, description, nop,chart,unique,fid,today);
           name="";
            nop = '1';
           planet="";
        }    
            
           
            
       
   

alert('saved successfully')
    document.getElementById('f22house').value = "";
    document.getElementById('f22planet').value = "";
    document.getElementById('f22book').value = "";
    document.getElementById('f22filter').value = "";
    document.getElementById('f22page').value = "";
    document.getElementById('f22detail').value = "";
     document.getElementById('f22chart').value = "";
      document.getElementById('f22unique').value = "";
    
    return false;
}





function lordhouseintohouse() {
    var lordofhouse = document.getElementById('f9lhouse').value;
    var inhouse = document.getElementById('f9house').value;
    predictive_input.lordhouseinto_house(lordofhouse, inhouse,callback_lordhouseintohouse)
}


function callback_lordhouseintohouse(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('gridmovesinto').innerHTML = "";
        document.getElementById('divmovesinto').style.display = 'block';
        document.getElementById('divmovesinto').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('gridmovesinto').style.display = "block";

        if (document.getElementById("gridmovesinto").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("divmovesinto").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("gridmovesinto").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("gridmovesinto").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='divmovesinto' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Rashi of House1" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Lord Of House" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "House" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Rashi" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Rashi Of House" + "</td>"


        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f9rh1_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI_CODE'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f9lh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LORD_OF_HOUSE'] + "</textarea>"
                buf2 += "</td>"




                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f9h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['SECOND_HOUSE'] + "</textarea>"
                buf2 += "</td>"



                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f9r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['WITHLORD_OF_HOUSE'] + "</textarea>"
                buf2 += "</td>"



                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f9rh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['FIRST_HOUSE'] + "</textarea>"
                buf2 += "</td>"





                buf2 += "</tr>"
            }
        }
        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('gridmovesinto').innerHTML = temp_del1;



    }



}

function chkallinto(id) {
    if (document.getElementById('chkboxinto_h').checked == true) {
        for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
            if (document.getElementById('chkboxinto_' + i).checked == false) {
                document.getElementById('chkboxinto_' + i).checked = true;

            }

        }
    }
    else {
        for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
            if (document.getElementById('chkboxinto_' + i).checked == true) {
                document.getElementById('chkboxinto_' + i).checked = false;

            }
        }
    }


}


function f9savelhinh()
{
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        var lagna = document.getElementById('f9rh1_' + i).value
        var lordof = document.getElementById('f9lh_' + i).value
        var house2 = document.getElementById('f9h_' + i).value
        var rashi = document.getElementById('f9r_' + i).value
        var inrashi = document.getElementById('f9rh_' + i).value
        var loh = document.getElementById('f9lhouse').value
        var categery = 'In';
        var inhouse = document.getElementById('f9house').value
        var astrocat1 = 'Lord Of House';
        var book1 = document.getElementById('f9book').value
        var keystring1 = document.getElementById('f9filter').value
        var f9page = document.getElementById('f9page').value
        var chart=  document.getElementById('f9chart').value
        var unique = document.getElementById('f9unique').value
        var fid ="PI_"+document.getElementById('f9id').innerHTML
        var desc = 'Lord of ' + loh + ' moves into ' + inhouse
        var detail = document.getElementById('f9detail').value
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!

        var yyyy = today.getFullYear();
        if (dd < 10) { dd = '0' + dd }
        if (mm < 10) { mm = '0' + mm }
        today = dd + '/' + mm + '/' + yyyy;
      predictive_input.save_f9(astrocat1, lagna, lordof, house2, inhouse, loh, desc, detail, categery, book1, keystring1, rashi, inrashi, f9page,chart,unique,fid,today)
    }
    alert('saved successfully')
    document.getElementById('f9house').value = "";
    document.getElementById('f9lhouse').value = "";
    document.getElementById('f9book').value = "";
    document.getElementById('f9filter').value = "";
    document.getElementById('f9page').value = "";
    document.getElementById('f9detail').value = "";
    document.getElementById('f9chart').value = "";
    document.getElementById('f9unique').value = "";
    
    
    return false;


}


function f9_execute() {
    var loh = document.getElementById('f9lhouse').value
    var categery = 'In';
    var inhouse = document.getElementById('f9house').value
    predictive_input.f9_executevalue(loh, categery, inhouse, callback_f9_execute)
    return false;
}

function callback_f9_execute(res) {
    var exec_data = res.value;
    if (exec_data.Tables[0].Rows.length == null || exec_data.Tables[0].Rows.length == '0') {
        alert("There is no data available regarding your query.")
        return false;
    }
    else {
        if (exec_data.Tables[0].Rows[0].BOOK == null) {
            document.getElementById('f9book').value = ""
        }
        else { document.getElementById('f9book').value = exec_data.Tables[0].Rows[0].BOOK; }
        if (exec_data.Tables[0].Rows[0].PAGE_NO == null)
        { document.getElementById('f9page').value = ""; }
        else {
            document.getElementById('f9page').value = exec_data.Tables[0].Rows[0].PAGE_NO;
        }

        document.getElementById('f9detail').value = exec_data.Tables[0].Rows[0].DESCCLOB;
        if (exec_data.Tables[0].Rows[0].KEY_STRING == null)
        { document.getElementById('f9filter').value = ""; }
        else
        { document.getElementById('f9filter').value = exec_data.Tables[0].Rows[0].KEY_STRING; }
        document.getElementById('f9hiddenfilter').value = exec_data.Tables[0].Rows[0].KEY_STRING
    }
    return false;


}


function f9_update() {
    var loh = document.getElementById('f9lhouse').value
    var categery = 'In';
    var inhouse = document.getElementById('f9house').value
    var filter = document.getElementById('f9hiddenfilter').value;
    var filternew = document.getElementById('f9filter').value;
    var detail = document.getElementById('f9detail').value;
    var book = document.getElementById('f9book').value;
    var page = document.getElementById('f9page').value;
    predictive_input.f9_updatevalue(loh, categery,inhouse,filter, filternew, detail, book, page)
    alert('updated successfully');
    document.getElementById('f9house').value = "";
    document.getElementById('f9lhouse').value = "";
    document.getElementById('f9book').value = "";
    document.getElementById('f9filter').value = "";
    document.getElementById('f9page').value = "";
    document.getElementById('f9detail').value = "";
    return false;
}


function lordhousewithhouse() {
    var lordofhouse=document.getElementById('f10lhouse').value
    var withthouse = document.getElementById('f10alhouse').value
    predictive_input.f10combination(withthouse, lordofhouse,callback_f10combination_show);
    return false;
}


function callback_f10combination_show(val) 
{
    var inhouse = document.getElementById('f10house').value

    record_show = 10
    record_show1 = 1
    var gg4 = 0;

    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('gridf10').innerHTML = "";
        document.getElementById('divf10').style.display = 'block';
        document.getElementById('divf10').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('gridf10').style.display = "block";

        if (document.getElementById("gridf10").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("divf10").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("gridf10").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("gridf10").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='divf10' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallwith(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Rashi of House1" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Lord Of House" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "With Lord Of House" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "House" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Rashi" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Rashi Of House" + "</td>"


        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
                if (exec_data1.Tables[0].Rows[i]['HOUSE'] == inhouse) {
                    
                    buf2 += "<tr>"

                
                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                    buf2 += "</td>"


                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f10rh1_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI_CODE'] + "</textarea>"
                    buf2 += "</td>"

                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f10wlh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['WITHLORD_OF_HOUSE'] + "</textarea>"
                    buf2 += "</td>"




                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f10loh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LORD_OF_HOUSE'] + "</textarea>"
                    buf2 += "</td>"



                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f10h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "</textarea>"
                    buf2 += "</td>"



                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f10fh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['FIRST_HOUSE'] + "</textarea>"
                    buf2 += "</td>"



                    buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                    buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f10sh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['SECOND_HOUSE'] + "</textarea>"
                    buf2 += "</td>"

                    buf2 += "</tr>"
                }
            } 
        }
        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('gridf10').innerHTML = temp_del1;



    }




}
function chkallwith(id) {
    var inhouse=document.getElementById('f10house').value
    if (document.getElementById('chkboxinto_h').checked == true) {
        for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
            if (exec_data1.Tables[0].Rows[i]['HOUSE'] == inhouse) {
                if (document.getElementById('chkboxinto_' + i).checked == false) {
                    document.getElementById('chkboxinto_' + i).checked = true;

                }
            }
        }
    }
    else {
        for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
            if (exec_data1.Tables[0].Rows[i]['HOUSE'] == inhouse) {
                if (document.getElementById('chkboxinto_' + i).checked == true) {
                    document.getElementById('chkboxinto_' + i).checked = false;

                } 
            }
        }
    }


}



function f10_save() {
    var seq = '0';
    var seq1 = '0';
    var inhouse = document.getElementById('f10house').value
    var lordofhouse = document.getElementById('f10lhouse').value
    var withlordofhouse = document.getElementById('f10alhouse').value
    var comb = inhouse + lordofhouse + withlordofhouse;
    document.getElementById('lordwithlordhidden').value = comb;
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        if (exec_data1.Tables[0].Rows[i]['HOUSE'] == inhouse) {
            var loh = document.getElementById('f10wlh_' + i).value
            var wloh = document.getElementById('f10loh_' + i).value
            var rashi = document.getElementById('f10sh_' + i).value
            if (loh == 'SUN')
            {seq='1' }
            if (loh == 'MOON')
            { seq = '2' }
            if (loh == 'MARS')
            { seq = '3' }
            if (loh == 'MERCURY')
            { seq = '4' }
            if (loh == 'JUPITER')
            { seq = '5' }
            if (loh == 'VENUS')
            { seq = '6' }
            if (loh == 'SATURN')
             { seq = '7' }
            if (loh == 'RAHU')
             { seq = '8' }
            if (loh == 'KETU')
            { seq = '9' }

            if (wloh == 'SUN')
            { seq1 = '1' }
            if (wloh == 'MOON')
            { seq1 = '2' }
            if (wloh == 'MARS')
            { seq1 = '3' }
            if (wloh == 'MERCURY')
            { seq1 = '4' }
            if (wloh == 'JUPITER')
            { seq1 = '5' }
            if (wloh == 'VENUS')
            { seq1 = '6' }
            if (wloh == 'SATURN')
            { seq1 = '7' }
            if (wloh == 'RAHU')
            { seq1 = '8' }
            if (wloh == 'KETU')
            { seq1 = '9' }
             if(seq<seq1) {
                 var name = loh + '-' + rashi + '-' + inhouse + '~' + wloh + '-' + rashi + '-' + inhouse;
            }
            else
            {
                var name = wloh + '-' + rashi + '-' + inhouse + '~' + loh + '-' + rashi + '-' + inhouse;
            }
            var book = document.getElementById('f10book').value
            var filter = document.getElementById('f10filter').value
            var page = document.getElementById('f10page').value
            var description = 'Lord of ' + lordofhouse + ' moves into ' + inhouse + ' with Lord of ' + withlordofhouse;
            var detail = document.getElementById('f10detail').value
            var chart= document.getElementById('f10chart').value
            var unique = document.getElementById('f10unique').value
            var fid ="PI_"+document.getElementById('f10id').innerHTML
            var nop = '2';


            var today = new Date();
            var dd = today.getDate();
            var mm = today.getMonth() + 1; //January is 0!

            var yyyy = today.getFullYear();
            if (dd < 10) { dd = '0' + dd }
            if (mm < 10) { mm = '0' + mm }
            today = dd + '/' + mm + '/' + yyyy;
            predictive_input.save_f10(name, book, page, filter, detail, description, nop, comb,chart,unique,fid,today);
        } 
    }
    alert('saved successfully')
    document.getElementById('f10house').value = "";
    document.getElementById('f10lhouse').value = "";
    document.getElementById('f10alhouse').value = "";
    document.getElementById('f10book').value = "";
    document.getElementById('f10filter').value = "";
    document.getElementById('f10page').value = "";
    document.getElementById('f10detail').value = "";
    document.getElementById('f10chart').value = "";
    document.getElementById('f10unique').value = "";
    comb = "";
    return false;


}



function f10_execute() {

    comb = document.getElementById('lordwithlordhidden').value;
    predictive_input.execute_f10(comb, callback_f10);
    name = "";
    return false;
}


function callback_f10(res) {
    var exec_data = res.value;
    if (exec_data.Tables[0].Rows.length == null || exec_data.Tables[0].Rows.length == '0') {
        alert("There is no data available regarding your query.")
        return false;
    }
    else {
        if (exec_data.Tables[0].Rows[0].BOOK == null) {
            document.getElementById('f10book').value = ""
        }
        else { document.getElementById('f10book').value = exec_data.Tables[0].Rows[0].BOOK; }
        if (exec_data.Tables[0].Rows[0].PAGE_NO == null)
        { document.getElementById('f10page').value = ""; }
        else {
            document.getElementById('f10page').value = exec_data.Tables[0].Rows[0].PAGE_NO;
        }

        document.getElementById('f10detail').value = exec_data.Tables[0].Rows[0].DESC_CLOB;
        if (exec_data.Tables[0].Rows[0].KEY_STRING == null)
        { document.getElementById('f10filter').value = ""; }
        else
        { document.getElementById('f10filter').value = exec_data.Tables[0].Rows[0].KEY_STRING; }
        document.getElementById('f10hiddenfilter').value = exec_data.Tables[0].Rows[0].KEY_STRING
    }
    return false;
}


function f10_update() {
    var comb = document.getElementById('lordwithlordhidden').value;

    var filter = document.getElementById('f10hiddenfilter').value;
    var filternew = document.getElementById('f10filter').value;
    var detail = document.getElementById('f10detail').value;
    var book = document.getElementById('f10book').value;
    var page = document.getElementById('f10page').value;
    predictive_input.update_f10(comb, filter, filternew, detail, book, page)
    alert('updated successfully');
    document.getElementById('f10book').value = "";
    document.getElementById('f10page').value = "";
    document.getElementById('f10filter').value = "";
    document.getElementById('f10detail').value = "";
    return false;
}



function lordhouseaspectinghouse() {
    var lordofhouse = document.getElementById('f11lhouse').value;
    var aspecthouse = document.getElementById('f11house').value;
    predictive_input.f11lohah(aspecthouse, lordofhouse, callback_f11);
    return false;
}

function callback_f11(val) {
    
    record_show = 10
    record_show1 = 1
    var gg4 = 0;

    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f11grid').innerHTML = "";
        document.getElementById('f11div').style.display = 'block';
        document.getElementById('f11div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f11grid').style.display = "block";

        if (document.getElementById("f11grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f11div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f11grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f11grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f11div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Lord" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Rashi" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "House" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Rashi of House1" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Rashi of Aspect House" + "</td>"
        
        


        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f11pc_" + i + "'>" + exec_data1.Tables[0].Rows[i]['PLANET_CODE'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f11rc_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI_CODE'] + "</textarea>"
                buf2 += "</td>"




                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f11ah_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECT_HOUSE'] + "</textarea>"
                buf2 += "</td>"



                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f11rh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI_OF_HOUSE1'] + "</textarea>"
                buf2 += "</td>"



                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f11hc_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE_CODE'] + "</textarea>"
                buf2 += "</td>"



               
                buf2 += "</tr>"
            }
        }

        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f11grid').innerHTML = temp_del1;


    }

}


function f11_save() {
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        var book1 = document.getElementById('f11book').value;
        var keystring1 = document.getElementById('f11filter').value; ;
        var astrocat1 = 'Lord Of House'
        var lord = document.getElementById('f11pc_'+i).value;
        var rashi = document.getElementById('f11rc_' + i).value;
        var aspectrashi = document.getElementById('f11hc_' + i).value;
        var hous = document.getElementById('f11ah_' + i).value;
        var lagna = document.getElementById('f11rh_' + i).value;
        var aspects = document.getElementById('f11house').value;
        var detail = document.getElementById('f11detail').value;
        var loh = document.getElementById('f11lhouse').value;
        var chart = document.getElementById('f11chart').value;
        var unique= document.getElementById('f11unique').value;
        var fid ="PI_"+document.getElementById('f11id').innerHTML;
        var desc = 'Lord of ' + loh + ' aspecting ' + aspects;
        var categery = 'Aspects';
        var f11page = document.getElementById('f11page').value
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!

        var yyyy = today.getFullYear();
        if (dd < 10) { dd = '0' + dd }
        if (mm < 10) { mm = '0' + mm }
        today = dd + '/' + mm + '/' + yyyy;
        
       predictive_input.save_f11(astrocat1, aspects, lord, rashi, hous, desc, detail, loh, categery, lagna, book1, keystring1, aspectrashi,f11page,chart,unique,fid,today)
    }
    alert('saved successfully')
    document.getElementById('f11house').value = "";
    document.getElementById('f11lhouse').value = "";
    document.getElementById('f11book').value = "";
    document.getElementById('f11filter').value = "";
    document.getElementById('f11page').value = "";
    document.getElementById('f11detail').value = "";
    document.getElementById('f11chart').value = "";
    document.getElementById('f11unique').value = "";
    return false;

}


function f11_execute() {
    var loh = document.getElementById('f11lhouse').value
    var categery = 'Aspects';
    var aspecthouse = document.getElementById('f11house').value
    predictive_input.f9_executevalue(loh, categery, aspecthouse, callback_f11_execute)
    return false;
}

function callback_f11_execute(res) {
    var exec_data = res.value;
    if (exec_data.Tables[0].Rows.length == null || exec_data.Tables[0].Rows.length == '0') {
        alert("There is no data available regarding your query.")
        return false;
    }
    else {
        if (exec_data.Tables[0].Rows[0].BOOK == null) {
            document.getElementById('f11book').value = ""
        }
        else { document.getElementById('f11book').value = exec_data.Tables[0].Rows[0].BOOK; }
        if (exec_data.Tables[0].Rows[0].PAGE_NO == null)
        { document.getElementById('f11page').value = ""; }
        else {
            document.getElementById('f11page').value = exec_data.Tables[0].Rows[0].PAGE_NO;
        }

        document.getElementById('f11detail').value = exec_data.Tables[0].Rows[0].DESCCLOB;
        if (exec_data.Tables[0].Rows[0].KEY_STRING == null)
        { document.getElementById('f11filter').value = ""; }
        else
        { document.getElementById('f11filter').value = exec_data.Tables[0].Rows[0].KEY_STRING; }
        document.getElementById('f11hiddenfilter').value = exec_data.Tables[0].Rows[0].KEY_STRING
    }
    return false;


}


function f11_update() {
    var loh = document.getElementById('f11lhouse').value
    var categery = 'Aspects';
    var aspectshouse = document.getElementById('f11house').value
    var filter = document.getElementById('f11hiddenfilter').value;
    var filternew = document.getElementById('f11filter').value;
    var detail = document.getElementById('f11detail').value;
    var book = document.getElementById('f11book').value;
    var page = document.getElementById('f11page').value;
    predictive_input.f9_updatevalue(loh, categery, aspectshouse, filter, filternew, detail, book, page)
    alert('updated successfully');
    document.getElementById('f11house').value = "";
    document.getElementById('f11lhouse').value = "";
    document.getElementById('f11book').value = "";
    document.getElementById('f11filter').value = "";
    document.getElementById('f11page').value = "";
    document.getElementById('f11detail').value = "";
    return false;
}



function planetaspectinghouse() {
    var lordhouse = document.getElementById('f12house').value;
    var planet1 = document.getElementById('f12planet').value;
    predictive_input.f12pah(lordhouse, planet1,callback_f12);
    return false;
}



function callback_f12(val) {

    record_show = 10
    record_show1 = 1
    var gg4 = 0;

    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f12grid').innerHTML = "";
        document.getElementById('f12div').style.display = 'block';
        document.getElementById('f12div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f12grid').style.display = "block";

        if (document.getElementById("f12grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f12div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f12grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f12grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f12div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Rashi Of House1" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LORD" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:5px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "House" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:5px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Aspect House" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:5px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Rashi" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:5px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Rashi Of Aspect House" + "</td>"




        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f12rc_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI_CODE'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f12lh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LORD_OF_HOUSE'] + "</textarea>"
                buf2 += "</td>"




                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f12sh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['SECOND_HOUSE'] + "</textarea>"
                buf2 += "</td>"



                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f12fh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['FIRST_HOUSE'] + "</textarea>"
                buf2 += "</td>"



                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f12wh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['WITHLORD_OF_HOUSE'] + "</textarea>"
                buf2 += "</td>"



                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f12h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "</textarea>"
                buf2 += "</td>"
                
                
                buf2 += "</tr>"
            }
        }

        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f12grid').innerHTML = temp_del1;


    }

}

function f12_save() {
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        var book1 = document.getElementById('f12book').value;
        var keystring1 = document.getElementById('f12filter').value;
        var astrocat1 = 'Planet'
        var lagna = document.getElementById('f12rc_'+i).value;
        var rashi = document.getElementById('f12wh_' + i).value;
        var aspectrashi = document.getElementById('f12h_' + i).value;
        var lordp = document.getElementById('f12lh_' + i).value;
        var aspecthouse = document.getElementById('f12fh_' + i).value;
        var house1 = document.getElementById('f12sh_' + i).value;
        var housep = document.getElementById('f12house').value;
        var chart = document.getElementById('f12chart').value;
        var unique= document.getElementById('f12unique').value;
       
        var detail = document.getElementById('f12detail').value;
        var planet1 = document.getElementById('f12planet').value;
        var categery = 'Aspects'
        var desc = planet1 + ' Aspecting ' + housep;
        var f12page = document.getElementById('f12page').value;
        var fid = 'PI_' + document.getElementById('f12id').innerHTML;
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!

        var yyyy = today.getFullYear();
        if (dd < 10) { dd = '0' + dd }
        if (mm < 10) { mm = '0' + mm }
        today = dd + '/' + mm + '/' + yyyy;
        
        predictive_input.save_f12(astrocat1, lagna, planet1, categery, housep, desc, detail, lordp, house1, aspecthouse, book1, keystring1, rashi, aspectrashi,f12page,chart,unique,fid,today)
    }
    alert('saved successfully')
    document.getElementById('f12house').value = "";
    document.getElementById('f12planet').value = "";
    document.getElementById('f12book').value = "";
    document.getElementById('f12filter').value = "";
    document.getElementById('f12page').value = "";
    document.getElementById('f12detail').value = "";
    document.getElementById('f12chart').value="";
    document.getElementById('f12unique').value="";
    return false;

}


function f12_execute() {
    var planet = document.getElementById('f12planet').value
    var categery = 'Aspects';
    var aspecthouse = document.getElementById('f12house').value
    predictive_input.f12_executevalue(planet, categery, aspecthouse, callback_f12_execute)
    return false;
}

function callback_f12_execute(res) {
    var exec_data = res.value;
    if (exec_data.Tables[0].Rows.length == null || exec_data.Tables[0].Rows.length == '0') {
        alert("There is no data available regarding your query.")
        return false;
    }
    else {
        if (exec_data.Tables[0].Rows[0].BOOK == null) {
            document.getElementById('f12book').value = ""
        }
        else { document.getElementById('f12book').value = exec_data.Tables[0].Rows[0].BOOK; }
        if (exec_data.Tables[0].Rows[0].PAGE_NO == null)
        { document.getElementById('f12page').value = ""; }
        else {
            document.getElementById('f12page').value = exec_data.Tables[0].Rows[0].PAGE_NO;
        }

        document.getElementById('f12detail').value = exec_data.Tables[0].Rows[0].DESCCLOB;
        if (exec_data.Tables[0].Rows[0].KEY_STRING == null)
        { document.getElementById('f12filter').value = ""; }
        else
        { document.getElementById('f12filter').value = exec_data.Tables[0].Rows[0].KEY_STRING; }
        document.getElementById('f12hiddenfilter').value = exec_data.Tables[0].Rows[0].KEY_STRING
    }
    return false;


}

function f12_update() {
    var planet = document.getElementById('f12planet').value
    var categery = 'Aspects';
    var aspectshouse = document.getElementById('f12house').value
    var filter = document.getElementById('f12hiddenfilter').value;
    var filternew = document.getElementById('f12filter').value;
    var detail = document.getElementById('f12detail').value;
    var book = document.getElementById('f12book').value;
    var page = document.getElementById('f12page').value;
    predictive_input.f12_updatevalue(planet, categery, aspectshouse, filter, filternew, detail, book, page)
    alert('updated successfully');
    document.getElementById('f12house').value = "";
    document.getElementById('f12planet').value = "";
    document.getElementById('f12book').value = "";
    document.getElementById('f12filter').value = "";
    document.getElementById('f12page').value = "";
    document.getElementById('f12detail').value = "";
    return false;
}



function planetaspectplanet() {
    var planet = document.getElementById('f13planet').value
    var planet1 = document.getElementById('f13aplanet').value
    var house = document.getElementById('f13house').value
    predictive_input.planetaspectplanet(planet, planet1, house,callback_f13);
    return false;

}
function callback_f13(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;

    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f13grid').innerHTML = "";
        document.getElementById('f13div').style.display = 'block';
        document.getElementById('f13div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f13grid').style.display = "block";

        if (document.getElementById("f13grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f13div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f13grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f13grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f13div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASP_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASP_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"



        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f13lr_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f13apr_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_PLANET_RASHI'] + "</textarea>"
                buf2 += "</td>"




                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f13aph_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_PLANET_HOUSE'] + "</textarea>"
                buf2 += "</td>"



                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f13r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI'] + "</textarea>"
                buf2 += "</td>"



                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f13h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "</textarea>"
                buf2 += "</td>"



               


                buf2 += "</tr>"
            }
        }

        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f13grid').innerHTML = temp_del1;


    }
}


function f13_save() {
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        var f13book = document.getElementById('f13book').value;
        var f13page = document.getElementById('f13page').value;
        var keystring = document.getElementById('f13filter').value;
        var f13planet = document.getElementById('f13planet').value;
        var f13aplanet = document.getElementById('f13aplanet').value;
        var f13house = document.getElementById('f13house').value;
        var lagna = document.getElementById('f13lr_' + i).value;
        var aplanetrashi = document.getElementById('f13apr_' + i).value;
        var aplanethouse = document.getElementById('f13aph_' + i).value;
        var planetrashi = document.getElementById('f13r_' + i).value;
        var planethouse = document.getElementById('f13h_' + i).value;
        var combination = f13planet+aplanetrashi+aplanethouse + f13aplanet+planetrashi+planethouse;
        var detail = document.getElementById('f13detail').value;
        var desc = f13planet + ' in ' + f13house + ' Aspected by ' + f13aplanet;
         var chart = document.getElementById('f13chart').value;
         var unique = document.getElementById('f13unique').value;
         var fid ="PI_"+document.getElementById('f13id').innerHTML;
         var today = new Date();
         var dd = today.getDate();
         var mm = today.getMonth() + 1; //January is 0!

         var yyyy = today.getFullYear();
         if (dd < 10) { dd = '0' + dd }
         if (mm < 10) { mm = '0' + mm }
         today = dd + '/' + mm + '/' + yyyy;
      predictive_input.save_f13(f13planet, f13house, f13aplanet, f13book, f13page, keystring, detail, desc, combination, lagna,chart,unique,fid,today)
    }
    alert('saved successfully')
    document.getElementById('f13house').value = "";
    document.getElementById('f13planet').value = "";
    document.getElementById('f13aplanet').value = "";    
    document.getElementById('f13book').value = "";
    document.getElementById('f13filter').value = "";
    document.getElementById('f13page').value = "";
    document.getElementById('f13detail').value = "";
      document.getElementById('f13chart').value = "";
        document.getElementById('f13unique').value = "";
    return false;
}



function f13_execute() {
    var f13planet = document.getElementById('f13planet').value;
    var f13aplanet = document.getElementById('f13aplanet').value;
    var f13house = document.getElementById('f13house').value;
    predictive_input.f13_executevalue(f13planet, f13house, f13aplanet, callback_f13_execute)
    return false;
}

function callback_f13_execute(res) {
    var exec_data = res.value;
    if (exec_data.Tables[0].Rows.length == null || exec_data.Tables[0].Rows.length == '0') {
        alert("There is no data available regarding your query.")
        return false;
    }
    else {
        if (exec_data.Tables[0].Rows[0].BOOK == null) {
            document.getElementById('f13book').value = ""
        }
        else { document.getElementById('f13book').value = exec_data.Tables[0].Rows[0].BOOK; }
        if (exec_data.Tables[0].Rows[0].PAGE_NO == null)
        { document.getElementById('f13page').value = ""; }
        else {
            document.getElementById('f13page').value = exec_data.Tables[0].Rows[0].PAGE_NO;
        }

        document.getElementById('f13detail').value = exec_data.Tables[0].Rows[0].DESCCLOB;
        if (exec_data.Tables[0].Rows[0].KEY_STRING == null)
        { document.getElementById('f13filter').value = ""; }
        else
        { document.getElementById('f13filter').value = exec_data.Tables[0].Rows[0].KEY_STRING; }
        document.getElementById('f13hiddenfilter').value = exec_data.Tables[0].Rows[0].KEY_STRING
    }
    return false;


}

function f13_update() {
    var planet = document.getElementById('f13planet').value
    var house = document.getElementById('f13house').value
    var aplanet = document.getElementById('f13aplanet').value
    
    var filter = document.getElementById('f13hiddenfilter').value;
    var filternew = document.getElementById('f13filter').value;
    var detail = document.getElementById('f13detail').value;
    var book = document.getElementById('f13book').value;
    var page = document.getElementById('f13page').value;
    predictive_input.f13_updatevalue(planet, house, aplanet, filter, filternew, detail, book, page)
    alert('updated successfully');
    document.getElementById('f13house').value = "";
    document.getElementById('f13planet').value = "";
    document.getElementById('f13aplanet').value = "";
    document.getElementById('f13book').value = "";
    document.getElementById('f13filter').value = "";
    document.getElementById('f13page').value = "";
    document.getElementById('f13detail').value = "";
    return false;
}


function planetaspectbenific() {
    var planet= document.getElementById('f14planet').value 
    var house= document.getElementById('f14house').value
    var benmal = document.getElementById('f14aplanet').value
    predictive_input.planetaspectbenific(planet, house, benmal, callback_f14);
    return false;
}


function callback_f14(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;

    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f14grid').innerHTML = "";
        document.getElementById('f14div').style.display = 'block';
        document.getElementById('f14div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f14grid').style.display = "block";

        if (document.getElementById("f14grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f14div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f14grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f14grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f14div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"

        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASP_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASP_RASHI" + "</td>"
      
        if (document.getElementById('f14aplanet').value == 'BENIFICS') {
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "BENIFICS" + "</td>"
        }
        if (document.getElementById('f14aplanet').value == 'MALIFICS') {
            buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "MALIFICS" + "</td>"
        }


        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"



        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:10px;' class='dropdown_large_corr'; align='left' value='" + exec_data1.Tables[0].Rows[i]['ASPECTED_HOUSE'] + "'  id='f14ah_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:10px;' class='dropdown_large_corr'; align='left' value='" + exec_data1.Tables[0].Rows[i]['ASPECTED_RASHI'] + "'  id='f14ar_" + i + "'  >"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:5px;' class='dropdown_large_corr'; align='left' value='" + exec_data1.Tables[0].Rows[i]['PLANET'] + "'  id='f14planet_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:5px;' align='left' class='dropdown_large_corr'; value='" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "'  id='f14lr_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:5px;' align='left' class='dropdown_large_corr'; value='" + exec_data1.Tables[0].Rows[i]['RASHI'] + "'  id='f14rashi_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:5px;' align='left' class='dropdown_large_corr'; value='" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "'  id='f14house_" + i + "'  >"
                buf2 += "</td>"



                buf2 += "</tr>"
            }
        }

        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f14grid').innerHTML = temp_del1;


    }
}


function f14_save() {
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        var f14book = document.getElementById('f14book').value;
        var f14page = document.getElementById('f14page').value;
        var keystring = document.getElementById('f14filter').value;
        var f14planet = document.getElementById('f14planet').value;
        var f14aplanet = document.getElementById('f14aplanet').value;
        var planet = document.getElementById('f14planet_'+i).value;
        var f14house = document.getElementById('f14house').value;
        var lagna = document.getElementById('f14lr_' + i).value;
        var aplanetrashi = document.getElementById('f14ar_' + i).value;
        var aplanethouse = document.getElementById('f14ah_' + i).value;
        var planetrashi = document.getElementById('f14rashi_' + i).value;
        var planethouse = document.getElementById('f14house_' + i).value;
        var combination = f14planet + aplanetrashi + aplanethouse + planet + planetrashi + planethouse;
        var detail = document.getElementById('f14detail').value;
        var desc = f14planet + ' in ' + f14house + ' Aspected by ' + f14aplanet;
        var chart = document.getElementById('f14chart').value;
        var unique= document.getElementById('f14unique').value;
        var fid = "PI_" + document.getElementById('f14id').innerHTML;
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!

        var yyyy = today.getFullYear();
        if (dd < 10) { dd = '0' + dd }
        if (mm < 10) { mm = '0' + mm }
        today = dd + '/' + mm + '/' + yyyy;

        predictive_input.save_f14(f14planet, f14house, f14aplanet, f14book, f14page, keystring, detail, desc, combination, lagna,chart,unique,fid,today)
    }
    alert('saved successfully')
    document.getElementById('f14house').value = "";
    document.getElementById('f14planet').value = "";
    document.getElementById('f14aplanet').value = "";
    document.getElementById('f14book').value = "";
    document.getElementById('f14filter').value = "";
    document.getElementById('f14page').value = "";
    document.getElementById('f14detail').value = "";
     document.getElementById('f14chart').value = "";
      document.getElementById('f14unique').value = "";
    return false;
}

function f14_execute() {
    var f14planet = document.getElementById('f14planet').value;
    var f14aplanet = document.getElementById('f14aplanet').value;
    var f14house = document.getElementById('f14house').value;
    predictive_input.f14_executevalue(f14planet, f14house, f14aplanet, callback_f14_execute)
    return false;
}

function callback_f14_execute(res) {
    var exec_data = res.value;
    if (exec_data.Tables[0].Rows.length == null || exec_data.Tables[0].Rows.length == '0') {
        alert("There is no data available regarding your query.")
        return false;
    }
    else {
        if (exec_data.Tables[0].Rows[0].BOOK == null) {
            document.getElementById('f14book').value = ""
        }
        else { document.getElementById('f14book').value = exec_data.Tables[0].Rows[0].BOOK; }
        if (exec_data.Tables[0].Rows[0].PAGE_NO == null)
        { document.getElementById('f14page').value = ""; }
        else {
            document.getElementById('f14page').value = exec_data.Tables[0].Rows[0].PAGE_NO;
        }

        document.getElementById('f14detail').value = exec_data.Tables[0].Rows[0].DESCCLOB;
        if (exec_data.Tables[0].Rows[0].KEY_STRING == null)
        { document.getElementById('f14filter').value = ""; }
        else
        { document.getElementById('f14filter').value = exec_data.Tables[0].Rows[0].KEY_STRING; }
        document.getElementById('f14hiddenfilter').value = exec_data.Tables[0].Rows[0].KEY_STRING
    }
    return false;


}
function f14_update() {
    var planet = document.getElementById('f14planet').value
    var house = document.getElementById('f14house').value
    var aplanet = document.getElementById('f14aplanet').value

    var filter = document.getElementById('f14hiddenfilter').value;
    var filternew = document.getElementById('f14filter').value;
    var detail = document.getElementById('f14detail').value;
    var book = document.getElementById('f14book').value;
    var page = document.getElementById('f14page').value;
    predictive_input.f14_updatevalue(planet, house, aplanet, filter, filternew, detail, book, page)
    alert('updated successfully');
    document.getElementById('f14house').value = "";
    document.getElementById('f14planet').value = "";
    document.getElementById('f14aplanet').value = "";
    document.getElementById('f14book').value = "";
    document.getElementById('f14filter').value = "";
    document.getElementById('f14page').value = "";
    document.getElementById('f14detail').value = "";
    return false;
}

function planetfromplanet()
 {
    var inhouse = document.getElementById('f15house').value
    var planets = document.getElementById('f15planet').value
    var fromplanet = document.getElementById('f15aplanet').value
    predictive_input.planetfromplanet(planets, fromplanet, inhouse,callback_f15);
}

function callback_f15(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;

    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f15grid').innerHTML = "";
        document.getElementById('f15div').style.display = 'block';
        document.getElementById('f15div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f15grid').style.display = "block";

        if (document.getElementById("f15grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f15div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f15grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f15grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f15div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"

        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Lagna Rashi" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "From Planet House" + "</td>"

        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "From Planet Rashi" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:5px;width:5px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "House" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:5px;width:5px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "Rashi" + "</td>"



        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:10px;' class='dropdown_large_corr'; align='left' value='" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "'  id='f15lr_" + i + "'  >"
                buf2 += "</td>"

      
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:10px;' class='dropdown_large_corr'; align='left' value='" + exec_data1.Tables[0].Rows[i]['FROM_PLANET_HOUSE'] + "'  id='f15fph_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:10px;' align='left' class='dropdown_large_corr'; value='" + exec_data1.Tables[0].Rows[i]['FROM_PLANET_RASHI'] + "'  id='f15fpr_" + i + "'  >"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:5px;' align='left' class='dropdown_large_corr'; value='" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "'  id='f15h_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='text' style='width:5px;' align='left' class='dropdown_large_corr'; value='" + exec_data1.Tables[0].Rows[i]['RASHI'] + "'  id='f15r_" + i + "'  >"
                buf2 += "</td>"



                buf2 += "</tr>"
            }
        }

        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f15grid').innerHTML = temp_del1;


    }
}

function f15_save() {
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        var f15book = document.getElementById('f15book').value;
        var f15page = document.getElementById('f15page').value;
        var keystring = document.getElementById('f15filter').value;
        var f15planet = document.getElementById('f15planet').value;
        var f15aplanet = document.getElementById('f15aplanet').value;
        var f15house = document.getElementById('f15house').value;
        var lagna = document.getElementById('f15lr_' + i).value;
        var fplaneth = document.getElementById('f15fph_' + i).value;
        var fplanetr = document.getElementById('f15fpr_' + i).value;
        var planetrashi = document.getElementById('f15r_' + i).value;
        var planethouse = document.getElementById('f15h_' + i).value;
        var combination = f15planet + planetrashi + planethouse + f15aplanet + fplanetr + fplaneth;
        var detail = document.getElementById('f15detail').value;
        var desc = f15planet + ' in ' + f15house + ' From ' + f15aplanet;
        var chart= document.getElementById('f15chart').value;
        var unique= document.getElementById('f15unique').value;
        var fid = "PI_" + document.getElementById('f15id').innerHTML;
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!

        var yyyy = today.getFullYear();
        if (dd < 10) { dd = '0' + dd }
        if (mm < 10) { mm = '0' + mm }
        today = dd + '/' + mm + '/' + yyyy;

        predictive_input.save_f15(f15planet, f15house, f15aplanet, f15book, f15page, keystring, detail, desc, combination, lagna,chart,unique,fid,today)
    }
    alert('saved successfully')
    document.getElementById('f15house').value = "";
    document.getElementById('f15planet').value = "";
    document.getElementById('f15aplanet').value = "";
    document.getElementById('f15book').value = "";
    document.getElementById('f15filter').value = "";
    document.getElementById('f15page').value = "";
    document.getElementById('f15detail').value = "";
    document.getElementById('f15chart').value = "";
    document.getElementById('f15unique').value = "";
    return false;
}


function f15_execute() {
    var f15planet = document.getElementById('f15planet').value;
    var f15aplanet = document.getElementById('f15aplanet').value;
    var f15house = document.getElementById('f15house').value;
    predictive_input.f15_executevalue(f15planet, f15house, f15aplanet, callback_f15_execute)
    return false;
}

function callback_f15_execute(res) {
    var exec_data = res.value;
    if (exec_data.Tables[0].Rows.length == null || exec_data.Tables[0].Rows.length == '0') {
        alert("There is no data available regarding your query.")
        return false;
    }
    else {
        if (exec_data.Tables[0].Rows[0].BOOK == null) {
            document.getElementById('f15book').value = ""
        }
        else { document.getElementById('f15book').value = exec_data.Tables[0].Rows[0].BOOK; }
        if (exec_data.Tables[0].Rows[0].PAGE_NO == null)
        { document.getElementById('f15page').value = ""; }
        else {
            document.getElementById('f15page').value = exec_data.Tables[0].Rows[0].PAGE_NO;
        }

        document.getElementById('f15detail').value = exec_data.Tables[0].Rows[0].DESCCLOB;
        if (exec_data.Tables[0].Rows[0].KEY_STRING == null)
        { document.getElementById('f15filter').value = ""; }
        else
        { document.getElementById('f15filter').value = exec_data.Tables[0].Rows[0].KEY_STRING; }
        document.getElementById('f15hiddenfilter').value = exec_data.Tables[0].Rows[0].KEY_STRING
    }
    return false;


}

function f15_update() {
    var planet = document.getElementById('f15planet').value
    var house = document.getElementById('f15house').value
    var aplanet = document.getElementById('f15aplanet').value

    var filter = document.getElementById('f15hiddenfilter').value;
    var filternew = document.getElementById('f15filter').value;
    var detail = document.getElementById('f15detail').value;
    var book = document.getElementById('f15book').value;
    var page = document.getElementById('f15page').value;
    predictive_input.f15_updatevalue(planet, house, aplanet, filter, filternew, detail, book, page)
    alert('updated successfully');
    document.getElementById('f15house').value = "";
    document.getElementById('f15planet').value = "";
    document.getElementById('f15aplanet').value = "";
    document.getElementById('f15book').value = "";
    document.getElementById('f15filter').value = "";
    document.getElementById('f15page').value = "";
    document.getElementById('f15detail').value = "";
    return false;
}



function planetaspectbyplanet() {
    var planet = document.getElementById('f16planet').value
    var planet1 = document.getElementById('f16aplanet').value
  
    predictive_input.planetaspectbyplanet(planet, planet1,callback_f16);
    return false;

}
function callback_f16(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;

    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f16grid').innerHTML = "";
        document.getElementById('f16div').style.display = 'block';
        document.getElementById('f16div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f16grid').style.display = "block";

        if (document.getElementById("f16grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f16div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f16grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f16grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f16div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASP_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASP_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"



        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f16lr_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f16apr_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_PLANET_RASHI'] + "</textarea>"
                buf2 += "</td>"




                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f16aph_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_PLANET_HOUSE'] + "</textarea>"
                buf2 += "</td>"



                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f16r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI'] + "</textarea>"
                buf2 += "</td>"



                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f16h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "</textarea>"
                buf2 += "</td>"



               


                buf2 += "</tr>"
            }
        }

        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f16grid').innerHTML = temp_del1;


    }
}


function f16_save() {
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        var f13book = document.getElementById('f16book').value;
        var f13page = document.getElementById('f16page').value;
        var keystring = document.getElementById('f16filter').value;
        var f13planet = document.getElementById('f16planet').value;
        var f13aplanet = document.getElementById('f16aplanet').value;
        var f13house = document.getElementById('f16aph_' + i).value;
        var lagna = document.getElementById('f16lr_' + i).value;
        var aplanetrashi = document.getElementById('f16apr_' + i).value;
        var aplanethouse = document.getElementById('f16aph_' + i).value;
        var planetrashi = document.getElementById('f16r_' + i).value;
        var planethouse = document.getElementById('f16h_' + i).value;
       
        var unique = document.getElementById('f16unique').value;
        var combination = f13planet + aplanetrashi + aplanethouse + f13aplanet + planetrashi + planethouse;
        var detail = document.getElementById('f16detail').value;
        var desc = f13planet + ' Aspected by ' + f13aplanet;
        var chart=document.getElementById('f16chart').value;
        var fid = "PI_" + document.getElementById('f16id').innerHTML;
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!

        var yyyy = today.getFullYear();
        if (dd < 10) { dd = '0' + dd }
        if (mm < 10) { mm = '0' + mm }
        today = dd + '/' + mm + '/' + yyyy;

        predictive_input.save_f13(f13planet, f13house, f13aplanet, f13book, f13page, keystring, detail, desc, combination, lagna,chart,unique,fid,today)
    }
    alert('saved successfully')
  
    document.getElementById('f16planet').value = "";
    document.getElementById('f16aplanet').value = "";
    document.getElementById('f16book').value = "";
    document.getElementById('f16filter').value = "";
    document.getElementById('f16page').value = "";
    document.getElementById('f16detail').value = "";
     document.getElementById('f16chart').value = "";
      document.getElementById('f16unique').value = "";
    return false;
}


function f16_execute() {
    var f16planet = document.getElementById('f16planet').value;
    var f16aplanet = document.getElementById('f16aplanet').value;
    predictive_input.f16_executevalue(f16planet, f16aplanet, callback_f16_execute)
    return false;
}

function callback_f16_execute(res) {
    var exec_data = res.value;
    if (exec_data.Tables[0].Rows.length == null || exec_data.Tables[0].Rows.length == '0') {
        alert("There is no data available regarding your query.")
        return false;
    }
    else {
        if (exec_data.Tables[0].Rows[0].BOOK == null) {
            document.getElementById('f16book').value = ""
        }
        else { document.getElementById('f16book').value = exec_data.Tables[0].Rows[0].BOOK; }
        if (exec_data.Tables[0].Rows[0].PAGE_NO == null)
        { document.getElementById('f16page').value = ""; }
        else {
            document.getElementById('f16page').value = exec_data.Tables[0].Rows[0].PAGE_NO;
        }

        document.getElementById('f16detail').value = exec_data.Tables[0].Rows[0].DESCCLOB;
        if (exec_data.Tables[0].Rows[0].KEY_STRING == null)
        { document.getElementById('f16filter').value = ""; }
        else
        { document.getElementById('f16filter').value = exec_data.Tables[0].Rows[0].KEY_STRING; }
        document.getElementById('f16hiddenfilter').value = exec_data.Tables[0].Rows[0].KEY_STRING
    }
    return false;


}

function f16_update() {
    var planet = document.getElementById('f16planet').value
    
    var aplanet = document.getElementById('f16aplanet').value

    var filter = document.getElementById('f16hiddenfilter').value;
    var filternew = document.getElementById('f16filter').value;
    var detail = document.getElementById('f16detail').value;
    var book = document.getElementById('f16book').value;
    var page = document.getElementById('f16page').value;
    predictive_input.f16_updatevalue(planet,  aplanet, filter, filternew, detail, book, page)
    alert('updated successfully');
    document.getElementById('f16planet').value = "";
    document.getElementById('f16aplanet').value = "";
    document.getElementById('f16book').value = "";
    document.getElementById('f16filter').value = "";
    document.getElementById('f16page').value = "";
    document.getElementById('f16detail').value = "";
    return false;
}

function houseindebexal() {
    var loh = document.getElementById('f17house').value
    
    var rashi = document.getElementById('f17rashi').value

    predictive_input.houseindebexal(loh, rashi, callback_f17);
    return false;
}


function callback_f17(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;

    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f17grid').innerHTML = "";
        document.getElementById('f17div').style.display = 'block';
        document.getElementById('f17div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f17grid').style.display = "block";

        if (document.getElementById("f17grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f17div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f17grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f17grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f17div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "PLANET" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LONGITUDE_IN_THE_SIGN_FROM" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "LONGITUDE_IN_THE_SIGN_TO" + "</td>"

        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f17lr_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f17p_" + i + "'>" + exec_data1.Tables[0].Rows[i]['PLANET'] + "</textarea>"
                buf2 += "</td>"




                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f17h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "</textarea>"
                buf2 += "</td>"



                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f17r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI'] + "</textarea>"
                buf2 += "</td>"



                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f17lf_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LONGITUDE_IN_THE_SIGN_FROM'] + "</textarea>"
                buf2 += "</td>"
                
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f17lt_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LONGITUDE_IN_THE_SIGN_TO'] + "</textarea>"
                buf2 += "</td>"






                buf2 += "</tr>"
            }
        }

        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f17grid').innerHTML = temp_del1;


    }
}

function f17_save() 
{
  
    

        for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i)
         {
        var loh = document.getElementById('f17house').value;
        var house = document.getElementById('f17h_'+i).value;
        var categery = document.getElementById('f17rashi').value;
        var lagnarashi = document.getElementById('f17lr_' + i).value;
        var rashi = document.getElementById('f17r_' + i).value;
        var planet = document.getElementById('f17p_' + i).value;
        var lfrom = document.getElementById('f17lf_' + i).value;
        var lto = document.getElementById('f17lt_' + i).value; 
        var book = document.getElementById('f17book').value;
        var page = document.getElementById('f17page').value;
        var filter = document.getElementById('f17filter').value;
        var detail = document.getElementById('f17detail').value;
        var desc ='Lord of ' + loh + ' in ' + categery;
        var chart = document.getElementById('f17chart').value;
        var unique = document.getElementById('f17unique').value;
        var fid = "PI_" + document.getElementById('f17id').innerHTML;
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!

        var yyyy = today.getFullYear();
        if (dd < 10) { dd = '0' + dd }
        if (mm < 10) { mm = '0' + mm }
        today = dd + '/' + mm + '/' + yyyy;
        predictive_input.save_f17(loh, house, categery, lagnarashi, rashi, planet, lfrom, lto, book, page,filter,detail,desc,chart,unique,fid,today)
     }
        
    alert('saved successfully')
  
    document.getElementById('f17house').value = "";
    //document.getElementById('f17ahouse').value = "";
    document.getElementById('f17rashi').value = "";
    document.getElementById('f17filter').value = "";
    document.getElementById('f17book').value = "";
    document.getElementById('f17page').value = "";
    document.getElementById('f17detail').value = "";
    document.getElementById('f17chart').value = "";
    document.getElementById('f17unique').value = "";
    return false;
}


function f17_execute()
{
    var loh = document.getElementById('f17house').value;
    var house = document.getElementById('f17ahouse').value;
    var categery = document.getElementById('f17rashi').value;
    predictive_input.f17_executevalue(loh, house,categery, callback_f17_execute)
    return false;
}
    
    
    
    function callback_f17_execute(res) {
    var exec_data = res.value;
    if (exec_data.Tables[0].Rows.length == null || exec_data.Tables[0].Rows.length == '0') {
        alert("There is no data available regarding your query.")
        return false;
    }
    else {
        if (exec_data.Tables[0].Rows[0].BOOK == null) {
            document.getElementById('f17book').value = ""
        }
        else { document.getElementById('f17book').value = exec_data.Tables[0].Rows[0].BOOK; }
        if (exec_data.Tables[0].Rows[0].PAGE_NO == null)
        { document.getElementById('f17page').value = ""; }
        else {
            document.getElementById('f17page').value = exec_data.Tables[0].Rows[0].PAGE_NO;
        }

        document.getElementById('f17detail').value = exec_data.Tables[0].Rows[0].DESCCLOB;
        if (exec_data.Tables[0].Rows[0].KEY_STRING == null)
        { document.getElementById('f17filter').value = ""; }
        else
        { document.getElementById('f17filter').value = exec_data.Tables[0].Rows[0].KEY_STRING; }
        document.getElementById('f17hiddenfilter').value = exec_data.Tables[0].Rows[0].KEY_STRING
    }
    return false;


}



function f17_update() {
    var loh = document.getElementById('f17house').value;
    var house = document.getElementById('f17ahouse').value;
    var categery = document.getElementById('f17rashi').value;

    var filter = document.getElementById('f17hiddenfilter').value;
    var filternew = document.getElementById('f17filter').value;
    var detail = document.getElementById('f17detail').value;
    var book = document.getElementById('f17book').value;
    var page = document.getElementById('f17page').value;
    predictive_input.f17_updatevalue(loh,  house,categery, filter, filternew, detail, book, page)
    alert('updated successfully');
    document.getElementById('f17house').value = "";
    document.getElementById('f17ahouse').value = "";
    document.getElementById('f17rashi').value = "";
    document.getElementById('f17filter').value = "";
    document.getElementById('f17book').value = "";
    document.getElementById('f17page').value = "";
    document.getElementById('f17detail').value = "";
    return false;
}




function bindhouseincons()
{
    var f18planet = document.getElementById('f18planet').value;
    var f18house = document.getElementById('f18house').value;
    var f18cons = document.getElementById('f18cons').value;
    predictive_input.houseincons(f18planet, f18house, f18cons, callback_f18);
    return false;
}



function callback_f18(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;

    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f18grid').innerHTML = "";
        document.getElementById('f18div').style.display = 'block';
        document.getElementById('f18div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f18grid').style.display = "block";

        if (document.getElementById("f18grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f18div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f18grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f18grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f18div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "CHARAN" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LONGITUDE_IN_THE_SIGN_FROM" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "LONGITUDE_IN_THE_SIGN_TO" + "</td>"
        



        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f18r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f18c_" + i + "'>" + exec_data1.Tables[0].Rows[i]['CHARAN'] + "</textarea>"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f18lf_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LONGITUDE_IN_THE_SIGN_FROM'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f18lt_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LONGITUDE_IN_THE_SIGN_TO'] + "</textarea>"
                buf2 += "</td>"



               






                buf2 += "</tr>"
            }
        }

        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f18grid').innerHTML = temp_del1;


    }
}


function f18_save() {
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        var planet = document.getElementById('f18planet').value;
        var house = document.getElementById('f18house').value;
        var cons = document.getElementById('f18cons').value;
        var book = document.getElementById('f18book').value;
        var page = document.getElementById('f18page').value;
        var filter = document.getElementById('f18filter').value;
        var rashi = document.getElementById('f18r_' + i).value;
        var charan = document.getElementById('f18c_' + i).value;
        var lfrom = document.getElementById('f18lf_' + i).value;
        var lto = document.getElementById('f18lt_' + i).value;
      
        var detail = document.getElementById('f18detail').value;
        var desc = planet + ' in ' + house+ ' in ' + cons;
        var chart= document.getElementById('f18chart').value;
        var unique = document.getElementById('f18unique').value;
        var fid = "PI_" + document.getElementById('f18id').innerHTML;
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!

        var yyyy = today.getFullYear();
        if (dd < 10) { dd = '0' + dd }
        if (mm < 10) { mm = '0' + mm }
        today = dd + '/' + mm + '/' + yyyy; 

        predictive_input.save_f18(planet, house, cons, book, page, filter, rashi, charan, lfrom, lto,detail,desc,chart,unique,fid,today)
    }
    alert('saved successfully')
  
    document.getElementById('f18planet').value = "";
    document.getElementById('f18house').value = "";
    document.getElementById('f18cons').value = "";
    document.getElementById('f18filter').value = "";
    document.getElementById('f18book').value = "";
    document.getElementById('f18page').value = "";
    document.getElementById('f18detail').value = "";
     document.getElementById('f18chart').value = "";
      document.getElementById('f18unique').value = "";
    return false;
}


function f18_execute()
{
    var planet = document.getElementById('f18planet').value;
    var house = document.getElementById('f18house').value;
    var cons = document.getElementById('f18cons').value;
    predictive_input.f18_executevalue(planet, house,cons, callback_f18_execute)
    return false;
}
    
    
    
    function callback_f18_execute(res) {
    var exec_data = res.value;
    if (exec_data.Tables[0].Rows.length == null || exec_data.Tables[0].Rows.length == '0') {
        alert("There is no data available regarding your query.")
        return false;
    }
    else {
        if (exec_data.Tables[0].Rows[0].BOOK == null) {
            document.getElementById('f18book').value = ""
        }
        else { document.getElementById('f18book').value = exec_data.Tables[0].Rows[0].BOOK; }
        if (exec_data.Tables[0].Rows[0].PAGE_NO == null)
        { document.getElementById('f18page').value = ""; }
        else {
            document.getElementById('f18page').value = exec_data.Tables[0].Rows[0].PAGE_NO;
        }

        document.getElementById('f18detail').value = exec_data.Tables[0].Rows[0].DESCCLOB;
        if (exec_data.Tables[0].Rows[0].KEY_STRING == null)
        { document.getElementById('f18filter').value = ""; }
        else
        { document.getElementById('f18filter').value = exec_data.Tables[0].Rows[0].KEY_STRING; }
        document.getElementById('f18hiddenfilter').value = exec_data.Tables[0].Rows[0].KEY_STRING
    }
    return false;


}


function f18_update() {
    var planet = document.getElementById('f18planet').value
    
    var house = document.getElementById('f18house').value
    var cons = document.getElementById('f18cons').value

    var filter = document.getElementById('f18hiddenfilter').value;
    var filternew = document.getElementById('f18filter').value;
    var detail = document.getElementById('f18detail').value;
    var book = document.getElementById('f18book').value;
    var page = document.getElementById('f18page').value;
    predictive_input.f18_updatevalue(planet,  house,cons, filter, filternew, detail, book, page)
    alert('updated successfully');
    document.getElementById('f18planet').value = "";
    document.getElementById('f18house').value = "";
    document.getElementById('f18cons').value = "";
    document.getElementById('f18filter').value = "";
    document.getElementById('f18book').value = "";
    document.getElementById('f18page').value = "";
    document.getElementById('f18detail').value = "";
    return false;
}


function bindhouseincharanofcons()
{ var f19planet = document.getElementById('f19planet').value;
    var f19house = document.getElementById('f19house').value;
    var f19cons = document.getElementById('f19cons').value;
    var f19charan = document.getElementById('f19charan').value;
    predictive_input.houseincharanincons(f19planet, f19house, f19cons,f19charan, callback_f19);
    return false;}
    
    
    
    function callback_f19(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;

    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f19grid').innerHTML = "";
        document.getElementById('f19div').style.display = 'block';
        document.getElementById('f19div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f19grid').style.display = "block";

        if (document.getElementById("f19grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f19div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f19grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f19grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f19div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "CHARAN" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LONGITUDE_IN_THE_SIGN_FROM" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "LONGITUDE_IN_THE_SIGN_TO" + "</td>"
        



        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f19r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f19c_" + i + "'>" + exec_data1.Tables[0].Rows[i]['CHARAN'] + "</textarea>"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f19lf_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LONGITUDE_IN_THE_SIGN_FROM'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f19lt_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LONGITUDE_IN_THE_SIGN_TO'] + "</textarea>"
                buf2 += "</td>"



               






                buf2 += "</tr>"
            }
        }

        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f19grid').innerHTML = temp_del1;


    }
}

function f19_save() 
{

 if (document.getElementById('lstmultiplehouse').options[0].selected == true)
  {
        for (var h = 1; h <= 12; ++h)
         {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i)
                {
                    var planet = document.getElementById('f19planet').value;
                    var house = document.getElementById('lstmultiplehouse').options[h].innerHTML;
                    var cons = document.getElementById('f19cons').value;
                    var book = document.getElementById('f19book').value;
                    var page = document.getElementById('f19page').value;
                    var filter = document.getElementById('f19filter').value;
                    var rashi = document.getElementById('f19r_' + i).value;
                    var charan = document.getElementById('f19c_' + i).value;
                    var lfrom = document.getElementById('f19lf_' + i).value;
                    var lto = document.getElementById('f19lt_' + i).value;
                  
                    var detail = document.getElementById('f19detail').value;
                    var desc = planet + ' in ' + house+ ' in ' + cons;
                    var chart = document.getElementById('f19chart').value;
                    var unique = document.getElementById('f19unique').value;
                    var fid = "PI_" + document.getElementById('f19id').innerHTML;
                    var today = new Date();
                    var dd = today.getDate();
                    var mm = today.getMonth() + 1; //January is 0!

                    var yyyy = today.getFullYear();
                    if (dd < 10) { dd = '0' + dd }
                    if (mm < 10) { mm = '0' + mm }
                    today = dd + '/' + mm + '/' + yyyy;
           
                    predictive_input.save_f18(planet, house, cons, book, page, filter, rashi, charan, lfrom, lto,detail,desc,chart,unique,fid,today)
                }
           }
    }
 else
  { 
    for (var j = 1; j < document.getElementById('lstmultiplehouse').options.length; ++j)
    {
     if (document.getElementById('lstmultiplehouse').options[j].selected == true)
        {
           for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) 
             {
                var planet = document.getElementById('f19planet').value;
                var house = document.getElementById('lstmultiplehouse').options[j].innerHTML;
                var cons = document.getElementById('f19cons').value;
                var book = document.getElementById('f19book').value;
                var page = document.getElementById('f19page').value;
                var filter = document.getElementById('f19filter').value;
                var rashi = document.getElementById('f19r_' + i).value;
                var charan = document.getElementById('f19c_' + i).value;
                var lfrom = document.getElementById('f19lf_' + i).value;
                var lto = document.getElementById('f19lt_' + i).value;
              
                var detail = document.getElementById('f19detail').value;
                var desc = planet + ' in ' + house+ ' in ' + cons;
                 var chart = document.getElementById('f19chart').value;
                 var unique = document.getElementById('f19unique').value;
                 var fid = "PI_" + document.getElementById('f19id').innerHTML;
                 var today = new Date();
                 var dd = today.getDate();
                 var mm = today.getMonth() + 1; //January is 0!

                 var yyyy = today.getFullYear();
                 if (dd < 10) { dd = '0' + dd }
                 if (mm < 10) { mm = '0' + mm }
                 today = dd + '/' + mm + '/' + yyyy;
                

                predictive_input.save_f18(planet, house, cons, book, page, filter, rashi, charan, lfrom, lto,detail,desc,chart,unique,fid,today)
              }
         }
     }
  }
  
  
  
  
    alert('saved successfully')
    document.getElementById('f19planet').value = "";
    document.getElementById('f19house').value = "";
    document.getElementById('f19cons').value = "";
    document.getElementById('f19filter').value = "";
    document.getElementById('f19book').value = "";
    document.getElementById('f19page').value = "";
    document.getElementById('f19detail').value = "";
    document.getElementById('f19charan').value = "";
    document.getElementById('f19chart').value = "";
    document.getElementById('f19unique').value = "";
    return false;
}

function f19_execute()
{
    var planet = document.getElementById('f19planet').value;
    var house = document.getElementById('f19house').value;
    var cons = document.getElementById('f19cons').value;
    predictive_input.f18_executevalue(planet, house,cons, callback_f19_execute)
    return false;
}
    
    
    
    function callback_f19_execute(res) {
    var exec_data = res.value;
    if (exec_data.Tables[0].Rows.length == null || exec_data.Tables[0].Rows.length == '0') {
        alert("There is no data available regarding your query.")
        return false;
    }
    else {
        if (exec_data.Tables[0].Rows[0].BOOK == null) {
            document.getElementById('f19book').value = ""
        }
        else { document.getElementById('f19book').value = exec_data.Tables[0].Rows[0].BOOK; }
        if (exec_data.Tables[0].Rows[0].PAGE_NO == null)
        { document.getElementById('f19page').value = ""; }
        else {
            document.getElementById('f19page').value = exec_data.Tables[0].Rows[0].PAGE_NO;
        }

        document.getElementById('f19detail').value = exec_data.Tables[0].Rows[0].DESCCLOB;
        if (exec_data.Tables[0].Rows[0].KEY_STRING == null)
        { document.getElementById('f19filter').value = ""; }
        else
        { document.getElementById('f19filter').value = exec_data.Tables[0].Rows[0].KEY_STRING; }
        document.getElementById('f19hiddenfilter').value = exec_data.Tables[0].Rows[0].KEY_STRING
    }
    return false;


}


function f19_update() {
    var planet = document.getElementById('f19planet').value
    
    var house = document.getElementById('f19house').value
    var cons = document.getElementById('f19cons').value

    var filter = document.getElementById('f19hiddenfilter').value;
    var filternew = document.getElementById('f19filter').value;
    var detail = document.getElementById('f19detail').value;
    var book = document.getElementById('f19book').value;
    var page = document.getElementById('f19page').value;
    predictive_input.f18_updatevalue(planet,  house,cons, filter, filternew, detail, book, page)
    alert('updated successfully');
    document.getElementById('f19planet').value = "";
    document.getElementById('f19house').value = "";
    document.getElementById('f19cons').value = "";
    document.getElementById('f19filter').value = "";
    document.getElementById('f19book').value = "";
    document.getElementById('f19page').value = "";
    document.getElementById('f19detail').value = "";
    return false;
}


function findPos(obj,val) {
   var curleft = curtop = 0;

   if (obj.offsetParent) {
       curleft = obj.offsetLeft

       curtop = obj.offsetTop

       while (obj = obj.offsetParent) {
           curleft += obj.offsetLeft

           curtop += obj.offsetTop

       }

   }
   curtop = curtop += 5;
   if (val == "top")
       return curtop +"px";
   else
       return curleft + "px";
}



function f20fillplanet(event) {
    var keycode = event.keyCode ? event.keyCode : event.which;
    if (keycode == 113) {
        if (document.activeElement.id == "f20aplanet") {
            document.getElementById('lstmultipleplanet').value = "";
            //var compcode = $('hdncompcode').value;
            //var unit=$('hdnunitcode').value;
           
        document.getElementById('divmultipleplanet').style.top = findPos(document.getElementById('f20aplanet'), "top");
       document.getElementById('divmultipleplanet').style.left = findPos(document.getElementById('f20aplanet'), "left");
            var extra1 = document.getElementById('f20aplanet').value;
             document.getElementById("divmultipleplanet").style.display = "block";
            document.getElementById('f20aplanet').focus();
            predictive_input.fill_planet(extra1, f20callback_planet);
            return false;
        }

    }


}

function f20callback_planet(res) {
    ds = res.value;
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        var pkgitem = document.getElementById("lstmultipleplanet");
        pkgitem.options.length = 0;
        pkgitem.options[0] = new Option("--Select Planet--", "0");
        pkgitem.options.length = 1;
        for (var i = 0; i < ds.Tables[0].Rows.length; ++i) {
            //pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].REASON_CODE+"-"+ds.Tables[0].Rows[i].REASON_NAME,ds.Tables[0].Rows[i].REASON_CODE);
            pkgitem.options[pkgitem.options.length] = new Option(ds.Tables[0].Rows[i].CODE);
            pkgitem.options.length;
        }
    }
    document.getElementById('lstmultipleplanet').style.display = "block";
    document.getElementById('lstmultipleplanet').focus();
    return false;
}


function f20bindquadraped()
{
 var qplanet = document.getElementById('f20planet').value
  
 predictive_input.planetinquadraped(qplanet, callback_f20);
 return false;
    }
    
    
    
    function callback_f20(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;

    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f20grid').innerHTML = "";
        document.getElementById('f20div').style.display = 'block';
        document.getElementById('f20div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f20grid').style.display = "block";

        if (document.getElementById("f20grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f20div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f20grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f20grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f20div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "QUADRAPED PLANET" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "QUADRAPED RASHI" + "</td>"
        
        



        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f20qp_" + i + "'>" + exec_data1.Tables[0].Rows[i]['QUADRAPED_PLANET'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f20qr_" + i + "'>" + exec_data1.Tables[0].Rows[i]['QUADRAPED_RASHI'] + "</textarea>"
                buf2 += "</td>"


             




                buf2 += "</tr>"
            }
        }

        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f20grid').innerHTML = temp_del1;


    }
}


function f20_save()
{   var combination="";
    var desc="";
  var nop='0';
  for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i)
    {
        var qplanet = document.getElementById('f20qp_'+i).value;
        var qrashi = document.getElementById('f20qr_'+i).value;
         for (var j = 0; j < document.getElementById('lstmultiplerashi').options.length; ++j)
          {
            if (document.getElementById('lstmultiplerashi').options[j].selected == true) {
                rashi = rashi + document.getElementById('lstmultiplerashi').options[j].innerHTML + "-";

            }
        }

        if (rashi != "") {
            rashi = rashi.slice(0, -1);

        }
         rashi = rashi.split('-')

        for (var l = 0; l < rashi.length; ++l) {
                                     for (var k = 0; k < document.getElementById('lstmultipleplanet').options.length; ++k) 
                                            {
                                               if (document.getElementById('lstmultipleplanet').options[k].selected == true) 
                                                     {
                                                         var planet=document.getElementById('lstmultipleplanet').options[k].innerHTML;
                                                       combination=combination+planet+rashi[l];
                                                     desc=desc+planet+' and ';
                                                      nop = parseInt(nop) + parseInt(1);
                                                     }
                                            }
                                            
                                            if (desc != "") {
                                                 desc = desc.slice(0, -5);

                                                            }           
                    var detail = document.getElementById('f20detail').value;
                    var desc1 = qplanet + ' in ' + 'quadraped rashi'+ ' and ' + desc+' in '+rashi[l];
                    combination=qplanet+qrashi+combination;
                    var book=document.getElementById('f20book').value;
                    var page=document.getElementById('f20page').value;
                     var filter=document.getElementById('f20filter').value;
                     var chart = document.getElementById('f20chart').value;
                     var unique = document.getElementById('f20unique').value;
                     var fid ="PI_"+document.getElementById('f20id').innerHTML;
                     nop = nop + parseInt(1);
                     var today = new Date();
                     var dd = today.getDate();
                     var mm = today.getMonth() + 1; //January is 0!

                     var yyyy = today.getFullYear();
                     if (dd < 10) { dd = '0' + dd }
                     if (mm < 10) { mm = '0' + mm }
                     today = dd + '/' + mm + '/' + yyyy;
                    predictive_input.save_f20(qplanet, qrashi, desc1,detail,book,page,combination,filter,nop,chart,unique,fid,today)
                           combination ="";
                             desc="";
                             nop='0';
                             
                       }
             
     
                rashi="";
                  
                    
     }
     alert('data saved successfully');
     document.getElementById('f20filter').value="";
     document.getElementById('f20book').value="";
     document.getElementById('f20page').value="";
     document.getElementById('f20detail').value="";
      document.getElementById('f20chart').value="";
       document.getElementById('f20unique').value="";
     return false;
}



function f20_execute()
{
    var qplanet = document.getElementById('f20planet').value;
   
    predictive_input.f20_executevalue(qplanet, callback_f20_execute)
    return false;
}
    
    
    
    function callback_f20_execute(res) {
    var exec_data = res.value;
    if (exec_data.Tables[0].Rows.length == null || exec_data.Tables[0].Rows.length == '0') {
        alert("There is no data available regarding your query.")
        return false;
    }
    else {
        if (exec_data.Tables[0].Rows[0].BOOK == null) {
            document.getElementById('f20book').value = ""
        }
        else { document.getElementById('f20book').value = exec_data.Tables[0].Rows[0].BOOK; }
        if (exec_data.Tables[0].Rows[0].PAGE_NO == null)
        { document.getElementById('f20page').value = ""; }
        else {
            document.getElementById('f20page').value = exec_data.Tables[0].Rows[0].PAGE_NO;
        }

        document.getElementById('f20detail').value = exec_data.Tables[0].Rows[0].DESCCLOB;
        if (exec_data.Tables[0].Rows[0].KEY_STRING == null)
        { document.getElementById('f20filter').value = ""; }
        else
        { document.getElementById('f20filter').value = exec_data.Tables[0].Rows[0].KEY_STRING; }
        document.getElementById('f20hiddenfilter').value = exec_data.Tables[0].Rows[0].KEY_STRING
    }
    return false;

}

function f20_update() {
    var qplanet = document.getElementById('f20planet').value
    var filter = document.getElementById('f20hiddenfilter').value;
    var filternew = document.getElementById('f20filter').value;
    var detail = document.getElementById('f20detail').value;
    var book = document.getElementById('f20book').value;
    var page = document.getElementById('f20page').value;
    predictive_input.f20_updatevalue(qplanet,filter, filternew, detail, book, page)
    alert('updated successfully');
    document.getElementById('f20planet').value = "";
    document.getElementById('f20filter').value = "";
    document.getElementById('f20book').value = "";
    document.getElementById('f20page').value = "";
    document.getElementById('f20detail').value = "";
    return false;
}


function f21bindwatery()
{
 var house = document.getElementById('f21house').value
  
 predictive_input.planetinwrashi(house, callback_f21);
 return false;
    }
    
    
    
    function callback_f21(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;

    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f21grid').innerHTML = "";
        document.getElementById('f21div').style.display = 'block';
        document.getElementById('f21div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f21grid').style.display = "block";

        if (document.getElementById("f21grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f21div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f21grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f21grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f21div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "WATERY HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "WATERY RASHI" + "</td>"
        
        



        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f21wh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['WATERY_HOUSE'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f21wr_" + i + "'>" + exec_data1.Tables[0].Rows[i]['WATERY_RASHI'] + "</textarea>"
                buf2 += "</td>"


             




                buf2 += "</tr>"
            }
        }

        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f21grid').innerHTML = temp_del1;


    }
}




function f21_save() 
{
      for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i)
                {
                    var planet = document.getElementById('f21planet').value;
                    var house = document.getElementById('f21wh_'+i).value;
                    var wrashi = document.getElementById('f21wr_'+i).value;
                    var ahouse = document.getElementById('f21ahouse').value;
                    var page = document.getElementById('f21page').value;
                    var filter = document.getElementById('f21filter').value;
                    var book = document.getElementById('f21book').value;
                     var chart = document.getElementById('f21chart').value;
                      var unique = document.getElementById('f21unique').value;
                      var fid="PI_"+document.getElementById('f21id').innerHTML;
               
                   
                  
                    var detail = document.getElementById('f21detail').value;
                    var desc = house + ' in ' + 'Watery Rashi'+ ' and ' + planet+ ' in ' + ahouse;
                    var name = house + '-' + wrashi + '~' + planet + '-' + ahouse;
                    var today = new Date();
                    var dd = today.getDate();
                    var mm = today.getMonth() + 1; //January is 0!

                    var yyyy = today.getFullYear();
                    if (dd < 10) { dd = '0' + dd }
                    if (mm < 10) { mm = '0' + mm }
                    today = dd + '/' + mm + '/' + yyyy;
                    predictive_input.save_f21(house, wrashi, planet, ahouse,book, page, filter,detail,desc,name,chart,unique,fid,today)
                }
                alert('Saved Successfully');
    document.getElementById('f21planet').value = "";
    document.getElementById('f21filter').value = "";
    document.getElementById('f21book').value = "";
    document.getElementById('f21page').value = "";
    document.getElementById('f21detail').value = "";
    document.getElementById('f21house').value = "";
     document.getElementById('f21wrashi').value = "";
      document.getElementById('f21ahouse').value = "";
      document.getElementById('f21chart').value = "";
      document.getElementById('f21unique').value = "";
    return false;
 }  
 
 
 
 
 
function f23bindplanet()
{
 var planet = document.getElementById('f23planet').value
 var loh = document.getElementById('f23house').value
  
 predictive_input.lohaspectedbyplanet(planet,loh, callback_f23);
 return false;
    }
    
    
    
    function callback_f23(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;

    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f23grid').innerHTML = "";
        document.getElementById('f23div').style.display = 'block';
        document.getElementById('f23div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f23grid').style.display = "block";

        if (document.getElementById("f23grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f23div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f23grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f23grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f23div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LORD" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASPECTED_BY_PLANET" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASPECTED_BY_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASPECTED_BY_HOUSE" + "</td>"
        
        



        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f23p_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LORD'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f23r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI'] + "</textarea>"
                buf2 += "</td>"
                
                
                 buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f23h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "</textarea>"
                buf2 += "</td>"
                
                
                 buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f23lr_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"
                
                
                 buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f23ap_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_BY_PLANET'] + "</textarea>"
                buf2 += "</td>"
                
                
                 buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f23ar_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_BY_RASHI'] + "</textarea>"
                buf2 += "</td>"
                
                
                 buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f23ah_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_BY_HOUSE'] + "</textarea>"
                buf2 += "</td>"


             




                buf2 += "</tr>"
            }
        }

        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f23grid').innerHTML = temp_del1;


    }
}



function f23_save() 
{
      for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i)
                {var loh=document.getElementById('f23house').value;
                    var f13planet = document.getElementById('f23p_'+i).value;
                    var rashi = document.getElementById('f23r_'+i).value;
                    var f13house = document.getElementById('f23h_'+i).value;
                    var lagna = document.getElementById('f23lr_'+i).value;
                    var f13aplanet = document.getElementById('f23ap_'+i).value;
                    var arashi = document.getElementById('f23ar_'+i).value;
                    var ahouse = document.getElementById('f23ah_'+i).value;
                    var f13book = document.getElementById('f23book').value;
                    var f13page = document.getElementById('f23page').value;
                    var keystring = document.getElementById('f23filter').value;
                    var detail = document.getElementById('f23detail').value;
                     var chart = document.getElementById('f23chart').value;
                      var unique = document.getElementById('f23unique').value;
                      var fid ="PI_"+document.getElementById('f23id').innerHTML;
               var desc='Lord of '+loh+' Aspected by '+f13aplanet;

               var combination = f13planet + rashi + f13house + f13aplanet + arashi + ahouse;
               var today = new Date();
               var dd = today.getDate();
               var mm = today.getMonth() + 1; //January is 0!

               var yyyy = today.getFullYear();
               if (dd < 10) { dd = '0' + dd }
               if (mm < 10) { mm = '0' + mm }
               today = dd + '/' + mm + '/' + yyyy;
                predictive_input.save_f13(f13planet, f13house, f13aplanet, f13book, f13page, keystring, detail, desc, combination, lagna,chart,unique,fid,today)
                }
                alert('Saved Successfully');
    document.getElementById('f23house').value = "";
    document.getElementById('f23filter').value = "";
    document.getElementById('f23book').value = "";
    document.getElementById('f23page').value = "";
    document.getElementById('f23detail').value = "";
    document.getElementById('f23planet').value = "";
     document.getElementById('f23unique').value = "";
      document.getElementById('f23chart').value = "";
    
    return false;
 }  
 
 
 function f24bindlohinhouse()
 { 
 var loh1 = document.getElementById('f24loh1').value
 var house1 = document.getElementById('f24house1').value
 var planet = document.getElementById('f24planet').value
 var house = document.getElementById('f24house').value
 var loh2 = document.getElementById('f24loh2').value
 var house2 = document.getElementById('f24house2').value
  
 predictive_input.f24lohhouse(loh1,house1,planet,house,loh2,house2,callback_f24);
 return false;
    }
    
    
    
    function callback_f24(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;

    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f24grid').innerHTML = "";
        document.getElementById('f24div').style.display = 'block';
        document.getElementById('f24div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f24grid').style.display = "block";

        if (document.getElementById("f24grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f24div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f24grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f24grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f24div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LORD_OF_HOUSE1" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "HOUSE1" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "RASHI1" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "PLANET" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LORD_OF_HOUSE2" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "HOUSE2" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "RASHI2" + "</td>"
        
        



        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f24loh1_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LORD_OF_HOUSE1'] + "</textarea>"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f24lr_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f24h1_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE1'] + "</textarea>"
                buf2 += "</td>"
                
                 buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f24r1_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI1'] + "</textarea>"
                buf2 += "</td>"
                
                
                 buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f24p_" + i + "'>" + exec_data1.Tables[0].Rows[i]['PLANET'] + "</textarea>"
                buf2 += "</td>"
                
                
                 buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f24h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "</textarea>"
                buf2 += "</td>"
                
                 buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f24r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI'] + "</textarea>"
                buf2 += "</td>"
                
                
                 buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f24loh2_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LORD_OF_HOUSE2'] + "</textarea>"
                buf2 += "</td>"
                
                
                 buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f24h2_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE2'] + "</textarea>"
                buf2 += "</td>"
                
                
               
                 buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f24r2_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI2'] + "</textarea>"
                buf2 += "</td>"
             




                buf2 += "</tr>"
            }
        }

        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f24grid').innerHTML = temp_del1;


    }
}


function f24_save() 
{
      for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i)
                {
                var lagnarashi=document.getElementById('f24lr_'+i).value;
                
                var lordofhouse1=document.getElementById('f24loh1').value;
                var lord1=document.getElementById('f24loh1_'+i).value;
                var house1 = document.getElementById('f24h1_'+i).value;
                var rashi1 = document.getElementById('f24r1_'+i).value;
                
                    var planet = document.getElementById('f24p_'+i).value;
                    var house = document.getElementById('f24h_'+i).value;
                    var rashi = document.getElementById('f24r_'+i).value;
                   
                   var lordofhouse2=document.getElementById('f24loh2').value;
                    var lord2 = document.getElementById('f24loh2_'+i).value;
                    var house2 = document.getElementById('f24h2_'+i).value;
                   var rashi2 = document.getElementById('f24r2_'+i).value;
                   
                    var book = document.getElementById('f24book').value;
                    var page = document.getElementById('f24page').value;
                    var filter = document.getElementById('f24filter').value;
                    var detail = document.getElementById('f24detail').value;
                    var chart = document.getElementById('f24chart').value;
                    var unique =document.getElementById('f24unique').value;
                    var fid ="PI_"+document.getElementById('f24id').innerHTML;
                    var description='Lord of '+lordofhouse1+' moves in '+ house1 + ' and '+ planet+' in '+house+ ' and Lord of '+ lordofhouse2+' in '+house2;
                    nop='3'
                    var combination = lord1 + rashi1 + house1 + planet + rashi + house + lord2 + rashi2 + house2;
                    var today = new Date();
                    var dd = today.getDate();
                    var mm = today.getMonth() + 1; //January is 0!

                    var yyyy = today.getFullYear();
                    if (dd < 10) { dd = '0' + dd }
                    if (mm < 10) { mm = '0' + mm }
                    today = dd + '/' + mm + '/' + yyyy;
                     predictive_input.save_lordwithplanetwithmalifics(lagnarashi,lordofhouse1,lord1,house1,rashi1,combination, book, page, filter, detail, description, nop,chart,unique,fid,today);
                }
                alert('Saved Successfully');
    document.getElementById('f24house').value = "";
    document.getElementById('f24filter').value = "";
    document.getElementById('f24book').value = "";
    document.getElementById('f24page').value = "";
    document.getElementById('f24detail').value = "";
    document.getElementById('f24planet').value = "";
     document.getElementById('f24chart').value = "";
     document.getElementById('f24unique').value = "";
    return false;
 }  
 
function f25bindlohinhouse()
{
 
var lordofhouse = document.getElementById('f25loh').value;
var inhouse = document.getElementById('f25house').value;
predictive_input.lordhouseinto_house(lordofhouse, inhouse,callback_lordhouseinhousewithplanetwithmalific)
return false;
}
    
    
    function callback_lordhouseinhousewithplanetwithmalific(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f25grid').innerHTML = "";
        document.getElementById('f25div').style.display = 'block';
        document.getElementById('f25div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f25grid').style.display = "block";

        if (document.getElementById("f25grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f25div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f25grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f25grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f25div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Rashi of House1" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Lord Of House" + "</td>"
         buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "Rashi Of House" + "</td>"

 


        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f25rh1_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI_CODE'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f25lh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LORD_OF_HOUSE'] + "</textarea>"
                buf2 += "</td>"







                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f25rh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['FIRST_HOUSE'] + "</textarea>"
                buf2 += "</td>"



                buf2 += "</tr>"
            }
        }
        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f25grid').innerHTML = temp_del1;



    }



}
function f25_save()
{ nop='2'
var malific="";
var malifics="";
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i)
      {         var lagnarashi=document.getElementById('f25rh1_'+i).value;
                var lordofhouse=document.getElementById('f25loh').value;
                var house=document.getElementById('f25house').value;
                var lord=document.getElementById('f25lh_'+i).value;
                var rashi = document.getElementById('f25rh_'+i).value;
                var planet=document.getElementById('f25planet').value;
                var book = document.getElementById('f25book').value;
                var page = document.getElementById('f25page').value;
                var filter = document.getElementById('f25filter').value;
                var detail = document.getElementById('f25detail').value;
                 var chart = document.getElementById('f25chart').value;
                 var unique = document.getElementById('f25unique').value;
                 var fid ="PI_"+document.getElementById('f25id').innerHTML;
    for (var k = 0; k < document.getElementById('lstmultipleplanet').options.length; ++k) 
      {
       if (document.getElementById('lstmultipleplanet').options[k].selected == true) 
         { nop = parseInt(nop) + parseInt(1);
            malific=malific+document.getElementById('lstmultipleplanet').options[k].innerHTML+rashi+house;
             malifics=malifics+ ' ' +document.getElementById('lstmultipleplanet').options[k].innerHTML;
         }
      }
      
       var description='Lord of '+lordofhouse+' with '+ planet + ' and Malifics namely '+ malifics +' in '+house;
       var combination = lord + rashi + house + planet + rashi + house + malific;
       var today = new Date();
       var dd = today.getDate();
       var mm = today.getMonth() + 1; //January is 0!

       var yyyy = today.getFullYear();
       if (dd < 10) { dd = '0' + dd }
       if (mm < 10) { mm = '0' + mm }
       today = dd + '/' + mm + '/' + yyyy;
       predictive_input.save_lordwithplanetwithmalifics(lagnarashi,lordofhouse,lord,house,rashi,combination, book, page, filter, detail, description, nop,chart,unique,fid,today);
    malifics="";
     malific="";
     nop='2'
      }
     
                alert('Saved Successfully');
    document.getElementById('f25house').value = "";
    document.getElementById('f25filter').value = "";
    document.getElementById('f25book').value = "";
    document.getElementById('f25page').value = "";
    document.getElementById('f25detail').value = "";
    document.getElementById('f25planet').value = "";
    document.getElementById('f25chart').value = "";
    document.getElementById('f25unique').value = "";
    
    
    return false;
 }  
 
 
 
 function f26bindlohaspectbybenmal()
 {
    var lordofhouse = document.getElementById('f26house').value;
    var benmal = document.getElementById('f26malifics').value;
    predictive_input.f26bindlohaspectbybenmal(lordofhouse, benmal,callback_f26lordaspectmalben)
return false;
}
    
    
    function callback_f26lordaspectmalben(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f26grid').innerHTML = "";
        document.getElementById('f26div').style.display = 'block';
        document.getElementById('f26div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f26grid').style.display = "block";

        if (document.getElementById("f26grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f26div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f26grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f26grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f26div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "PLANET" + "</td>"
         buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"
buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "MAL_BEN" + "</td>"
buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "MAL_BEN_RASHI" + "</td>"
buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "MAL_BEN_HOUSE" + "</td>"
 


        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f26rh1_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f26lh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['PLANET'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f26r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI'] + "</textarea>"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f26h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f26mb_" + i + "'>" + exec_data1.Tables[0].Rows[i]['MAL_BEN'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f26mbr_" + i + "'>" + exec_data1.Tables[0].Rows[i]['MAL_BEN_RASHI'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f26mbh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['MAL_BEN_HOUSE'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "</tr>"
            }
        }
        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f26grid').innerHTML = temp_del1;



    }



}



function f26_save() 
{
      for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i)
                {
                    var lagna=document.getElementById('f26rh1_'+i).value;
                    var f14planet=document.getElementById('f26house').value;
                    var f15lord=document.getElementById('f26lh_'+i).value;
                    var f14house=document.getElementById('f26h_'+i).value;
                    var f14aplanet=document.getElementById('f26malifics').value;
                    var f14book=document.getElementById('f26book').value;
                    var f14page=document.getElementById('f26page').value;
                    var keystring=document.getElementById('f26filter').value;
                    var detail=document.getElementById('f26detail').value;
                   var f15rashi=document.getElementById('f26r_'+i).value;
                   var benmal=document.getElementById('f26mb_'+i).value;
                   var benmalr=document.getElementById('f26mbr_'+i).value;
                   var benmalh=document.getElementById('f26mbh_'+i).value; 
                    var chart=document.getElementById('f26chart').value;
                    var unique =document.getElementById('f26unique').value;
                    var fid ="PI_"+document.getElementById('f26id').innerHTML;
                     
                    var combination = f15lord + f15rashi + f14house + benmal + benmalr + benmalh;

                    var desc = 'Lord of ' + f14planet + ' Aspected By ' + f14aplanet;
                    var today = new Date();
                    var dd = today.getDate();
                    var mm = today.getMonth() + 1; //January is 0!

                    var yyyy = today.getFullYear();
                    if (dd < 10) { dd = '0' + dd }
                    if (mm < 10) { mm = '0' + mm }
                    today = dd + '/' + mm + '/' + yyyy;
                    predictive_input.save_f14(f14planet, f14house, f14aplanet, f14book, f14page, keystring, detail, desc, combination, lagna,chart,unique,fid,today)
     }
                alert('Saved Successfully');
    document.getElementById('f26house').value = "";
    document.getElementById('f26filter').value = "";
    document.getElementById('f26book').value = "";
    document.getElementById('f26page').value = "";
    document.getElementById('f26detail').value = "";
    document.getElementById('f26malifics').value = "";
     document.getElementById('f26chart').value = "";
      document.getElementById('f26unique').value = "";
    
    return false;
 }  
 
 function f27bindlohaspectbydispositor()
 {
    var loh1 = document.getElementById('f27loh1').value;
    var loh2 = document.getElementById('f27loh2').value;
    predictive_input.f27bindlohaspectbydispositor(loh1, loh2,callback_f27lord)
    return false;
}
    
    
    function callback_f27lord(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f27grid').innerHTML = "";
        document.getElementById('f27div').style.display = 'block';
        document.getElementById('f27div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f27grid').style.display = "block";

        if (document.getElementById("f27grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f27div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f27grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f27grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f27div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LORD" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASPECTED_BY_PLANET" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASPECTED_BY_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "ASPECTED_BY_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "DISPOSITOR" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "DISPOSITOR_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "DISPOSITOR_HOUSE" + "</td>"
         


        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f27rh1_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f27loh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LORD'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f27r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI'] + "</textarea>"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f27h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f27ap_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_BY_PLANET'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f27ar_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_BY_RASHI'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f27ah_" + i + "'>" + exec_data1.Tables[0].Rows[i]['ASPECTED_BY_HOUSE'] + "</textarea>"
                buf2 += "</td>"
                
                
                 buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f27d_" + i + "'>" + exec_data1.Tables[0].Rows[i]['DISPOSITOR'] + "</textarea>"
                buf2 += "</td>"
                
                
                
                 
                 buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f27dr_" + i + "'>" + exec_data1.Tables[0].Rows[i]['DISPOSITOR_RASHI'] + "</textarea>"
                buf2 += "</td>"
                
                
                
                
                 
                 buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f27dh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['DISPOSITOR_HOUSE'] + "</textarea>"
                buf2 += "</td>"




                buf2 += "</tr>"
            }
        }
        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f27grid').innerHTML = temp_del1;



    }



}

function f27_save()
{ 
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i)
                {
                    var loh1=document.getElementById('f27loh1').value;
                    var loh2=document.getElementById('f27loh2').value;
                    var f13planet = document.getElementById('f27loh_'+i).value;
                    var rashi = document.getElementById('f27r_'+i).value;
                    var f13house = document.getElementById('f27h_'+i).value;
                    var lagna = document.getElementById('f27rh1_'+i).value;
                    var f13aplanet = document.getElementById('f27ap_'+i).value;
                    var arashi = document.getElementById('f27ar_'+i).value;
                    var ahouse = document.getElementById('f27ah_'+i).value;
                    var f13book = document.getElementById('f27book').value;
                    var f13page = document.getElementById('f27page').value;
                    var keystring = document.getElementById('f27filter').value;
                    var detail = document.getElementById('f27detail').value;
                    var chart = document.getElementById('f27chart').value;
                    var unique = document.getElementById('f27unique').value;
                  
                    var fid ="PI_"+document.getElementById('f27id').innerHTML;
               var desc='Lord of '+loh1+' Aspected by dispositor of '+loh2;
                 var dispo = document.getElementById('f27d_'+i).value;
                 var disporashi = document.getElementById('f27dr_'+i).value;
                 var dispohouse = document.getElementById('f27dh_'+i).value;

                 var combination = f13planet + rashi + f13house + f13aplanet + arashi + ahouse + dispo + disporashi + dispohouse;
                 var today = new Date();
                 var dd = today.getDate();
                 var mm = today.getMonth() + 1; //January is 0!

                 var yyyy = today.getFullYear();
                 if (dd < 10) { dd = '0' + dd }
                 if (mm < 10) { mm = '0' + mm }
                 today = dd + '/' + mm + '/' + yyyy;
               predictive_input.save_f13(f13planet, f13house, f13aplanet, f13book, f13page, keystring, detail, desc, combination, lagna,chart,unique,fid,today)
                }
                alert('Saved Successfully');
    document.getElementById('f27loh1').value = "";
    document.getElementById('f27filter').value = "";
    document.getElementById('f27book').value = "";
    document.getElementById('f27page').value = "";
    document.getElementById('f27detail').value = "";
    document.getElementById('f27loh2').value = "";
    document.getElementById('f27chart').value = "";
    document.getElementById('f27unique').value = "";
    
    return false;
    
    
    }
    
    
    
function f28bindlohwithbenmalinwatery()
{
    var loh = document.getElementById('f28loh').value;
    var benmal = document.getElementById('f28benmal').value;
    var sign = document.getElementById('f28sign').value;
    predictive_input.f28bindlohwithbenmalinwatery(loh, benmal,sign,callback_f28lord)
    return false;
}
    
    
    function callback_f28lord(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f28grid').innerHTML = "";
        document.getElementById('f28div').style.display = 'block';
        document.getElementById('f28div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f28grid').style.display = "block";

        if (document.getElementById("f28grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f28div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f28grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f28grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f28div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LORD" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "MAL_BEN" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "MAL_BEN_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "MAL_BEN_HOUSE" + "</td>"
         


        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f28rh1_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f28loh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['PLANET'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f28r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI'] + "</textarea>"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f28h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f28bm_" + i + "'>" + exec_data1.Tables[0].Rows[i]['MAL_BEN'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f28bmr_" + i + "'>" + exec_data1.Tables[0].Rows[i]['MAL_BEN_RASHI'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f28bmh_" + i + "'>" + exec_data1.Tables[0].Rows[i]['MAL_BEN_HOUSE'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "</tr>"
            }
        }
        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f28grid').innerHTML = temp_del1;



    }



}


function f28_save()
{
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i)
      {var chart=document.getElementById('f28chart').value;  
         var sign=document.getElementById('f28sign').value;  
          var benmal=document.getElementById('f28benmal').value;
                var lagnarashi=document.getElementById('f28rh1_'+i).value;
                var lordofhouse=document.getElementById('f28loh').value;
                var house=document.getElementById('f28h_'+i).value;
                var lord=document.getElementById('f28loh_'+i).value;
                var rashi = document.getElementById('f28r_'+i).value;
                var planet=document.getElementById('f28bm_'+i).value;
                var planetr=document.getElementById('f28bmr_'+i).value;
                var planeth=document.getElementById('f28bmh_'+i).value;
                var book = document.getElementById('f28book').value;
                var page = document.getElementById('f28page').value;
                var filter = document.getElementById('f28filter').value;
                var detail = document.getElementById('f28detail').value;
                var chart = document.getElementById('f28chart').value;
                var unique = document.getElementById('f28unique').value;
                var fid ="PI_"+document.getElementById('f28id').innerHTML;
   var nop='2'
      
       var description='Lord of '+lordofhouse+' with '+ benmal + ' in '+ sign +' sign ';
       var combination = lord + rashi + house + planet + planetr + planeth;
       var today = new Date();
       var dd = today.getDate();
       var mm = today.getMonth() + 1; //January is 0!

       var yyyy = today.getFullYear();
       if (dd < 10) { dd = '0' + dd }
       if (mm < 10) { mm = '0' + mm }
       today = dd + '/' + mm + '/' + yyyy;
       predictive_input.save_lordwithplanetwithmalifics(lagnarashi,lordofhouse,lord,house,rashi,combination, book, page, filter, detail, description, nop,chart,unique,fid,today);
    
      }
     
    alert('Saved Successfully');
    document.getElementById('f28loh').value = "";
    document.getElementById('f28filter').value = "";
    document.getElementById('f28book').value = "";
    document.getElementById('f28page').value = "";
    document.getElementById('f28detail').value = "";
    document.getElementById('f28sign').value = "";
      document.getElementById('f28chart').value = "";
        document.getElementById('f28unique').value = "";
    
    return false;}
    
    
    
    function lordofhousefromplanet()
    {
    var  loh=document.getElementById('f29loh').value;
    var house=document.getElementById('f29house').value;
    var planet=document.getElementById('f29planet').value;
     predictive_input.lordofhousefromplanet(loh,house,planet,callback_f29grid);
     return false;
    
    }
    
    
    
    
    
    function callback_f29grid(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f29grid').innerHTML = "";
        document.getElementById('f29div').style.display = 'block';
        document.getElementById('f29div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f29grid').style.display = "block";

        if (document.getElementById("f29grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f29div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f29grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f29grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f28div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "PLANET" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "FROM_PLANET_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "FROM_PLANET_HOUSE" + "</td>"
        
         


        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f29p_" + i + "'>" + exec_data1.Tables[0].Rows[i]['PLANET'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f29h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f29r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI'] + "</textarea>"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f29rh1_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f29fpr_" + i + "'>" + exec_data1.Tables[0].Rows[i]['FROM_PLANET_RASHI'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f29fph_" + i + "'>" + exec_data1.Tables[0].Rows[i]['FROM_PLANET_HOUSE'] + "</textarea>"
                buf2 += "</td>"
                
                

                buf2 += "</tr>"
            }
        }
        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f29grid').innerHTML = temp_del1;



    }



}


function f29_save() {
     for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        var f15book = document.getElementById('f29book').value;
        var f15page = document.getElementById('f29page').value;
        var keystring = document.getElementById('f29filter').value;
        var f15planet = document.getElementById('f29p_'+i).value;
        var loh= document.getElementById('f29loh').value;
        var f15aplanet = document.getElementById('f29planet').value;
        var f15house = document.getElementById('f29house').value;
        var lagna = document.getElementById('f29rh1_' + i).value;
        var fplaneth = document.getElementById('f29fph_' + i).value;
        var fplanetr = document.getElementById('f29fpr_' + i).value;
        var planetrashi = document.getElementById('f29r_' + i).value;
        var planethouse = document.getElementById('f29h_' + i).value;
        var combination = f15planet + planetrashi + planethouse +f15aplanet+  fplanetr + fplaneth;
        var detail = document.getElementById('f29detail').value;
        var desc = "Lord of "+ loh + ' in ' + f15house + ' From ' + f15aplanet;
        var chart= document.getElementById('f29chart').value;
        var unique= document.getElementById('f29unique').value;
        var fid = "PI_" + document.getElementById('f29id').innerHTML;
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!

        var yyyy = today.getFullYear();
        if (dd < 10) { dd = '0' + dd }
        if (mm < 10) { mm = '0' + mm }
        today = dd + '/' + mm + '/' + yyyy;

        predictive_input.save_f15(f15planet, f15house, f15aplanet, f15book, f15page, keystring, detail, desc, combination, lagna,chart,unique,fid,today)
    }
    alert('saved successfully')
    document.getElementById('f29house').value = "";
    document.getElementById('f29planet').value = "";
    document.getElementById('f29planet').value = "";
    document.getElementById('f29book').value = "";
    document.getElementById('f29filter').value = "";
    document.getElementById('f29page').value = "";
    document.getElementById('f29detail').value = "";
    document.getElementById('f29chart').value = "";
    document.getElementById('f29unique').value = "";
    return false;
}



function planethouselord()
{
var planet=document.getElementById('f30planet').value;
var house=document.getElementById('f30house').value;
var loh=document.getElementById('f30loh').value;
 predictive_input.planethouselord(planet,house,loh,callback_f30grid);
 return false;
}




 
    function callback_f30grid(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f30grid').innerHTML = "";
        document.getElementById('f30div').style.display = 'block';
        document.getElementById('f30div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f30grid').style.display = "block";

        if (document.getElementById("f30grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f30div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f30grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f30grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f28div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
                buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "PLANET" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "FROM_PLANET_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "FROM_PLANET_HOUSE" + "</td>"
       
        
         


        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                
                               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f30p_" + i + "'>" + exec_data1.Tables[0].Rows[i]['PLANET'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f30h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f30r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f30rhl_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f30fpr_" + i + "'>" + exec_data1.Tables[0].Rows[i]['FROM_PLANET_RASHI'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f30fph_" + i + "'>" + exec_data1.Tables[0].Rows[i]['FROM_PLANET_HOUSE'] + "</textarea>"
                buf2 += "</td>"
               
                

                buf2 += "</tr>"
            }
        }
        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f30grid').innerHTML = temp_del1;

    }

}




function f30_save() {
     for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        var f15book = document.getElementById('f30book').value;
        var f15page = document.getElementById('f30page').value;
        var keystring = document.getElementById('f30filter').value;
        //var f15planet = document.getElementById('f30p_'+i).value;
        var loh= document.getElementById('f30loh').value;
        var f15planet=document.getElementById('f30planet').value;
        var f15aplanet = document.getElementById('f30p_'+i).value;
        var f15house = document.getElementById('f30house').value;
        var lagna = document.getElementById('f30rhl_' + i).value;
        var fplaneth = document.getElementById('f30fph_' + i).value;
        var fplanetr = document.getElementById('f30fpr_' + i).value;
        var planetrashi = document.getElementById('f30r_' + i).value;
        var planethouse = document.getElementById('f30h_' + i).value;
        var combination = f15planet + planetrashi + planethouse +f15aplanet+  fplanetr + fplaneth;
        var detail = document.getElementById('f30detail').value;
        var desc = f15planet + ' in ' + f15house + ' From lord of ' + loh;
        var chart= document.getElementById('f30chart').value;
        var unique= document.getElementById('f30unique').value;
        var fid = "PI_" + document.getElementById('f30id').innerHTML;
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!

        var yyyy = today.getFullYear();
        if (dd < 10) { dd = '0' + dd }
        if (mm < 10) { mm = '0' + mm }
        today = dd + '/' + mm + '/' + yyyy;

        predictive_input.save_f15(f15planet, f15house, f15aplanet, f15book, f15page, keystring, detail, desc, combination, lagna, chart, unique, fid, today)
    }
    alert('saved successfully')
    document.getElementById('f30house').value = "";
    document.getElementById('f30planet').value = "";
    document.getElementById('f30planet').value = "";
    document.getElementById('f30book').value = "";
    document.getElementById('f30filter').value = "";
    document.getElementById('f30page').value = "";
    document.getElementById('f30detail').value = "";
    document.getElementById('f30chart').value = "";
    document.getElementById('f30unique').value = "";
    return false;
}



function lohinhouseloh()
{
var loh =document.getElementById('f31loh').value;
var house =document.getElementById('f31house').value;
var aloh =document.getElementById('f31aloh').value;
predictive_input.lohinhouseloh(loh,house,aloh,callback_f31grid);
return false;
}


 function callback_f31grid(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f31grid').innerHTML = "";
        document.getElementById('f31div').style.display = 'block';
        document.getElementById('f31div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f31grid').style.display = "block";

        if (document.getElementById("f31grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f31div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f31grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f31grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f28div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
                buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "PLANET" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "FROM_PLANET_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "FROM_PLANET_HOUSE" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:5px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "FROM_PLANET" + "</td>"
       
        
         


        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                
                               buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f31p_" + i + "'>" + exec_data1.Tables[0].Rows[i]['PLANET'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f31h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f31r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f31rhl_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"


                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f31fpr_" + i + "'>" + exec_data1.Tables[0].Rows[i]['FROM_PLANET_RASHI'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f31fph_" + i + "'>" + exec_data1.Tables[0].Rows[i]['FROM_PLANET_HOUSE'] + "</textarea>"
                buf2 += "</td>"
               
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:5px;  font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f31fp_" + i + "'>" + exec_data1.Tables[0].Rows[i]['FROM_PLANET'] + "</textarea>"
                buf2 += "</td>"
               
                

                buf2 += "</tr>"
            }
        }
        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f31grid').innerHTML = temp_del1;

    }

}



function f31_save() {
     for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        var f15book = document.getElementById('f31book').value;
        var f15page = document.getElementById('f31page').value;
        var keystring = document.getElementById('f31filter').value;
        var f15planet = document.getElementById('f31p_'+i).value;
        var loh= document.getElementById('f31loh').value;
        var aloh=document.getElementById('f31aloh').value;
        var f15aplanet=document.getElementById('f31fp_'+i).value;
        //var f15aplanet = document.getElementById('f31p_'+i).value;
        var f15house = document.getElementById('f31house').value;
        var lagna = document.getElementById('f31rhl_' + i).value;
        var fplaneth = document.getElementById('f31fph_' + i).value;
        var fplanetr = document.getElementById('f31fpr_' + i).value;
        var planetrashi = document.getElementById('f31r_' + i).value;
        var planethouse = document.getElementById('f31h_' + i).value;
        var combination = f15planet + planetrashi + planethouse +f15aplanet+  fplanetr + fplaneth;
        var detail = document.getElementById('f31detail').value;
        var desc = 'lord of ' +loh + ' in ' + f15house + ' From lord of ' + aloh;
        var chart= document.getElementById('f31chart').value;
        var unique= document.getElementById('f31unique').value;
        var fid ="PI_"+document.getElementById('f31id').innerHTML;
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!

        var yyyy = today.getFullYear();
        if (dd < 10) { dd = '0' + dd }
        if (mm < 10) { mm = '0' + mm }
        today = dd + '/' + mm + '/' + yyyy;
       predictive_input.save_f15(f15planet, f15house, f15aplanet, f15book, f15page, keystring, detail, desc, combination, lagna,chart,unique,fid,today)
    }
    alert('saved successfully')
    document.getElementById('f31house').value = "";
    //document.getElementById('f31aplanet').value = "";
    //document.getElementById('f31planet').value = "";
    document.getElementById('f31book').value = "";
    document.getElementById('f31filter').value = "";
    document.getElementById('f31page').value = "";
    document.getElementById('f31detail').value = "";
    document.getElementById('f31chart').value = "";
    document.getElementById('f31unique').value = "";
    return false;
}


function lordrashiclass()
{
var loh =document.getElementById('f32loh').value;
var rashi =document.getElementById('f32rashi').value;
predictive_input.lordrashiclass(loh,rashi,callback_f32grid);
return false;
}


 function callback_f32grid(val) {
    record_show = 10
    record_show1 = 1
    var gg4 = 0;
   
    exec_data1 = val.value;
    var i = 0

    if (exec_data1.Tables[0].Rows.length > 0) {
        document.getElementById('f32grid').innerHTML = "";
        document.getElementById('f32div').style.display = 'block';
        document.getElementById('f32div').style.BackColor = "Ivory";
        var temp_del1 = "";
        flg_req = "yes"
        var aa1 = "";
        var aa = "";
        var hs = 0;
        var hs1 = 0;

        document.getElementById('f32grid').style.display = "block";

        if (document.getElementById("f32grid").children.length == "0") {
            klen = "0"
        }
        else {
            klen = document.getElementById("f32div").childNodes[0].childNodes[0].childNodes.length - 1;
            IntializeNumber = klen + 1;
        }

        if (document.getElementById("f32grid").innerHTML.indexOf("width:50px;display:block") <= 0) {
            aa = document.getElementById("f32grid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
        }
        buf2 = "";
        buf2 += "<table  id='f28div' runat='server' align='left' Width='50px' height='0px' style='border:1px;; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
        buf2 += "<tr>"
        buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
        buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + 'h' + "' onClick='javascript:return chkallinto(this.id);' >"
        buf2 += "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LORD" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "NAMEOFRASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "LAGNA_RASHI" + "</td>"
        buf2 += "<td  bgcolor=#7DAAE3 style='height:10px;width:10px;font-size:10px;font-weight:bold;text-align:left;border:1px solid #ffffff;'>" + "HOUSE" + "</td>"
        




        buf2 += "</tr>"


        len = 1;


        if (exec_data1.Tables[0].Rows.length > 0) {
            for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {

                buf2 += "<tr>"

               
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<input type='checkbox' style='width:10px;' class='dropdown_large_corr'; align='left'   id='chkboxinto_" + i + "'  >"
                buf2 += "</td>"
                
                
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f32l_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LORD'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr';  id='f32r_" + i + "'>" + exec_data1.Tables[0].Rows[i]['RASHI'] + "</textarea>"
                buf2 += "</td>"

                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f32nor_" + i + "'>" + exec_data1.Tables[0].Rows[i]['NAMEOFRASHI'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f32rhl_" + i + "'>" + exec_data1.Tables[0].Rows[i]['LAGNA_RASHI'] + "</textarea>"
                buf2 += "</td>"
                
                buf2 += "<td   style='border:0px solid #7DAAE3;' align='left'>"
                buf2 += "<textarea type='text' style='width:10px; font-family:Georgia;' align='left' class='dropdown_large_corr'; id='f32h_" + i + "'>" + exec_data1.Tables[0].Rows[i]['HOUSE'] + "</textarea>"
                buf2 += "</td>"

               
                

                buf2 += "</tr>"
            }
        }
        buf2 += "</table>"
        var hdsview = "";
        temp_del1 = aa + buf2.toString();
        temp_del1 = temp_del1.replace("<TBODY>", "")
        temp_del1 = temp_del1.replace("</TBODY>", "")
        //alert(temp_del1)
        document.getElementById('f32grid').innerHTML = temp_del1;

    }

}



function f32_save()
{
    for (i = 0; i < exec_data1.Tables[0].Rows.length; ++i) {
        var lordof = document.getElementById('f32l_' + i).value
        var inrashi = document.getElementById('f32nor_' + i).value
        var lagna = document.getElementById('f32rhl_' + i).value
        var nameofrashi = document.getElementById('f32r_' + i).value
        var house2 = document.getElementById('f32h_' + i).value
         var inhouse = document.getElementById('f32h_' + i).value
        var loh = document.getElementById('f32loh').value
        var categery = 'In';
        //var inhouse = document.getElementById('f9house').value
        var astrocat1 = 'Lord Of House';
        var book1 = document.getElementById('f32book').value
        var keystring1 = document.getElementById('f32filter').value
        var f9page = document.getElementById('f32page').value
        var chart=  document.getElementById('f32chart').value
        var unique = document.getElementById('f32unique').value
        var combination= lordof + inrashi + house2
        var fid ="PI_"+document.getElementById('f32id').innerHTML
        var desc = 'Lord of ' +loh + ' in  ' + nameofrashi;
        var detail = document.getElementById('f32detail').value
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!

        var yyyy = today.getFullYear();
        if (dd < 10) { dd = '0' + dd }
        if (mm < 10) { mm = '0' + mm }
        today = dd + '/' + mm + '/' + yyyy;
      predictive_input.save_f9(astrocat1, lagna, lordof, house2, inhouse, loh, desc, detail, categery, book1, keystring1, rashi, inrashi, f9page,chart,unique,fid,today)
    }
    alert('saved successfully')
    //document.getElementById('f32house').value = "";
    //document.getElementById('f32lhouse').value = "";
    document.getElementById('f32book').value = "";
    document.getElementById('f32filter').value = "";
    document.getElementById('f32page').value = "";
    document.getElementById('f32detail').value = "";
    document.getElementById('f32chart').value = "";
    document.getElementById('f32unique').value = "";
    
    
    return false;


}