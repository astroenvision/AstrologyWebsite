



function click_on_new()
{
window.open("houseposition.aspx");
}

function click_on_cancel()
{
 if(confirm("Do You want to exit the page?"))
       {
         window.close();
         return false;
   }

}
function ShowPreview()
{
    var ht="";
    var wt="";
    var jobid= document.getElementById('hiddenjobid').value;
 
     for(var t1=0; t1<document.getElementById('ListBox2').options.length; t1++)
    {
       if(document.getElementById("ListBox2").options[t1].selected == true)
       {
           
            
              var fname =document.getElementById("ListBox2").options[t1].innerText;
           
             
                window.open('preview.aspx?jobid='+jobid+'&f_name='+fname,'Preview','status=0,toolbar=0,resizable=0,scrollbars=yes,modal=yes,top=0,left=0,width=800px,height=1000px');
           
              return false; 
                        
       }
    } 
}