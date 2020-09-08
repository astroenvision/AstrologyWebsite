function listboxitemsclick() {
    document.getElementById('Div4').innerHTML = "";
    document.getElementById('img1').style.display = 'block';
    document.getElementById('Label1').innerHTML = "";
    var listitem = document.getElementById('yogalist').value;
    var rashihouse = document.getElementById('Hs').value;
   
    var  res = yoga.get_alldata_data(rashihouse, listitem)
    document.getElementById('img1').style.display = 'none';

     ds = res.value;
     if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
     for (var i = 0; i < ds.Tables[0].Rows.length; i++) {
    //  document.getElementById('Div2').innerHTML = "<p>" + document.getElementById('yogalist').value + " \n<\p>" + "\n<p>" + ds.Tables[0].Rows[i].DESCRIPTION + " \n<\p>" + "\n<p>" + ds.Tables[0].Rows[i].DESCCLOB + "\n<\p>";
    document.getElementById('Div4').innerHTML += " <p>" + ds.Tables[0].Rows[i].YOGA + " \n</p>" + "\n<h1>" + ds.Tables[0].Rows[i].DESCRIPTION + " \n</h1>" + "\n<p2>" + ds.Tables[0].Rows[i].DESCCLOB + "\n</p2>";
    document.getElementById('Label1').innerHTML = "";
    }
    }
    else{
    alert("There is no data regarding your query");
    }
    
   
    return false;
}


var res = "";
function bindlistbox_data() {

    var data = "A";
    res = yoga.get_alldata(data,callback_drp)
   


}


function callback_drp(res) {
   
    var ds = res.value;
    var edtn = $("yogalist");
    edtn.options.length = 1;
    edtn.options[0] = new Option("--Select yoga--", "0");
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        for (var i = 0; i < ds.Tables[0].Rows.length; i++) {
            edtn.options[edtn.options.length] = new Option(ds.Tables[0].Rows[i].CODE, ds.Tables[0].Rows[i].CODE)
            edtn.options.length;
        }
    }
  
}



function bindlistbox_data1() {    
    var data = "B";
   res = yoga.get_alldata(data,callback_drp)
    


}



function bindlistbox_data2() {
    var data = "M";
    res = yoga.get_alldata(data, callback_drp)



}


 
