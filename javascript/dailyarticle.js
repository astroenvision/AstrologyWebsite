

function data1(i1,i2,i3,i4,i5,i6)
{

var head=(document.getElementById(i1).innerHTML);
var keyword =(document.getElementById(i2).innerHTML);
var snopsis =(document.getElementById(i3).innerHTML);
var story=(document.getElementById(i4).innerHTML);
var picformat=(document.getElementById(i5).innerHTML);
var date="";
var datadate=(document.getElementById(i6).innerHTML);

dailyairticle.upddata(head,keyword,snopsis,story,picformat,date,datadate);
alert('data update succesfully')
return false;
}



function datadel(i1,i2,i3,i4,i5,i6)
{


var head=(document.getElementById(i1).innerHTML);
var keyword =(document.getElementById(i2).innerHTML);
var snopsis =(document.getElementById(i3).innerHTML);
var story=(document.getElementById(i4).innerHTML);
var picformat=(document.getElementById(i5).innerHTML);

var datadate=(document.getElementById(i6).innerHTML);


 dailyairticle.deldata(head,keyword,snopsis,story,picformat,datadate);
 alert('data delete succesfully')
return false;
}