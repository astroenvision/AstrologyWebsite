var admin_map_natal_data = "";
var browser = navigator.appName;
var buf2 = new StringBuffer2();

function StringBuffer2() {
    this.buffer = [];
}

StringBuffer2.prototype.append = function append(string) {
    this.buffer.push(string);
    return this;
}

function StringBuffer2() {
    this.buffer = [];
}

StringBuffer2.prototype.append = function append(string) {
    this.buffer.push(string);
    return this;
}

StringBuffer2.prototype.toString = function toString() {
    return this.buffer.join("");
}




 var fil="0";   
function bind_books()
{
var res=admin_map_natal_data.bindbook(fil);
callback_drp0(res);
return false;
}


 function callback_drp0(res) {
    var ds=res.value;
    if(fil=='0')
    {
    var edtn = document.getElementById('ddlbooks');
    edtn.options.length = 1;
    edtn.options[0] = new Option("Select Book", "0");
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        for (var i = 0; i < ds.Tables[0].Rows.length; i++) {
            edtn.options[edtn.options.length] = new Option(ds.Tables[0].Rows[i].CODE, ds.Tables[0].Rows[i].CODE)
            edtn.options.length;
        }
    }}
    else
    {
    var edtn = document.getElementById('ddlbooks').value;
    
    edtn.options.length = 1;
    
    edtn.options[0] = new Option("Select Book", "0");
    
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        for (var i = 0; i < ds.Tables[0].Rows.length; i++) {
            edtn.options[edtn.options.length] = new Option(ds.Tables[0].Rows[i].CODE, ds.Tables[0].Rows[i].CODE)
            edtn.options.length;
        }
    }}
    return false;
}




function bind_subbooks(){
  var  fil = "0";
var book=document.getElementById('ddlbooks').value;
var res = admin_map_natal_data.getbookname(book, fil);

callback_drp1(res);

return false;

}



 function callback_drp1(res) {
    var ds=res.value;
    var edtn = document.getElementById('ddlsubbooks');
    edtn.options.length = 1;
    edtn.options[0] = new Option("Select Book", "0");
    if (ds != null && typeof (ds) == "object" && ds.Tables[0].Rows.length > 0) {
        for (var i = 0; i < ds.Tables[0].Rows.length; i++) {
            edtn.options[edtn.options.length] = new Option(ds.Tables[0].Rows[i].NAME, ds.Tables[0].Rows[i].NAME)
            edtn.options.length;
        }
    }
    return false;
}