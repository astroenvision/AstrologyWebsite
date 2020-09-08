var querytype="";
var val="";
//var Drphouse="";
//var Drprashi="";
//var  Drpplanet="";
var Houseposition="";
var exec_data="";
var next=0;
var execute="";
var Modify=0;


function EnableOnNew()
{
document.getElementById("Hidden36").value =0
   
         modifyduplicacyalias="";
         modifyduplicacydesc="";
         
         document.getElementById('btnNew').disabled = true;
         document.getElementById('btnQuery').disabled=true;
         document.getElementById('btnCancel').disabled = false;
         document.getElementById('btnExit').disabled = false;
         document.getElementById('btnSave').disabled = false;
         document.getElementById('btnExecute').disabled = true;
         document.getElementById('btnfirst').disabled = true;
         document.getElementById('btnlast').disabled = true;
         document.getElementById('btnModify').disabled = true;
         document.getElementById('btnprevious').disabled = true;
         document.getElementById('btnnext').disabled = true;
         document.getElementById('btnDelete').disabled = true;
         setButtonImages();





         document.getElementById('book').disabled = false;
         document.getElementById('keystring').disabled = false; 
   //         document.getElementById('page0').disabled=false; 
          
           document.getElementById('Textdesc').disabled=false; 
          document.getElementById('house').disabled=false; 
         //  document.getElementById('quardent').disabled=false; 
   //         document.getElementById('trines').disabled=false; 
         
         // document.getElementById('planet').disabled=false; 
          document.getElementById('detaildesc').disabled=false;
        //        document.getElementById('plant').disabled=false; 
        
        if($('astrocat').selectedIndex==2)
        {
          document.getElementById('planet').disabled=false;
        }
         else
         {
          document.getElementById('DropDownList1').disabled=false;
         }
                      document.getElementById('DropDownList2').disabled=false;
         
                      document.getElementById('astrocat').disabled=false;  
 setButtonImages();
       
          
          /***************************************************************************************/

        return false;


 
          
}

function blankfields()
{

         document.getElementById('btnNew').disabled = false;
         document.getElementById('btnNew').focus();
         document.getElementById('btnQuery').disabled = false;
         document.getElementById('btnCancel').disabled = false;
         document.getElementById('btnExit').disabled = false;
         document.getElementById('btnSave').disabled = true;
         document.getElementById('btnExecute').disabled = true;
         document.getElementById('btnfirst').disabled = true;
         document.getElementById('btnlast').disabled = true;
         document.getElementById('btnModify').disabled = true;
         document.getElementById('btnprevious').disabled = true;
         document.getElementById('btnnext').disabled = true;
         document.getElementById('btnDelete').disabled = true;  
        // setButtonImages();


         document.getElementById('book').disabled = true;
         document.getElementById('keystring').disabled = true;      
   //           document.getElementById('page0').disabled = true;        
          document.getElementById('Textdesc').disabled=true; 
        
        
          document.getElementById('house').disabled=true;
             document.getElementById('quardent').disabled=true;
             document.getElementById('plant').disabled=true;
               if($('astrocat').selectedIndex==2)
        {
          document.getElementById('planet').disabled=true;
        }
        else
        {
             document.getElementById('DropDownList1').disabled=true;
        }
              document.getElementById('DropDownList2').disabled=true;
     //           document.getElementById('trines').disabled=true; 
          
         
          document.getElementById('astrocat').disabled=true;
       
          
//          this is for detail desc
          document.getElementById('detaildesc').disabled=true; 
       
                 
          return false;
   }

function Save_Records()
 {

        var str = document.getElementById('tblfields').value;
        var str1 = str.split("$~$");
        var tablename = str1[str1.length - 2];

        var action = str1[str1.length - 1];
        var finalaction = action.split("#");
        var insert = finalaction[0];
        var update = finalaction[1];
        var del = finalaction[2];
        var select = finalaction[3];

        

       
       

       
        //   var book = "'" + (document.getElementById('book').value) + "'";
       //var casebook = book;
       
         //  var page0 = "'" + (document.getElementById('page0').value) + "'";
       //var casepage0 = page0;
        
        var house =  "'"+(document.getElementById('house').value)+"'";
       // var house="'" + (document.getElementById('house').options[hous].text) + "'";
        var casehouse = house;
        
            
       // var quardent = "'" + (document.getElementById('quardent').value) + "'";
       // var casequardent = quardent;
        
          
       // var trines = "'" + (document.getElementById('trines').value) + "'";
       // var casetrines = trines;
        
        
//        
//         var planet = "'" + (document.getElementById('planet').value) + "'";
//        var caseplanet = planet;
//        
         
//                var plant ="'"+(document.getElementById('plant').value)+"'" ;
//        var caseplant = plant;
//        
//                var loh = "'" + (document.getElementById('DropDownList1').value) + "'";
//        var caseloh = loh;
        
        
        
        var description = "'" + (document.getElementById('Textdesc').value) + "'";
        var casedescription= description;
        

       var caselord="";
       var rashi="";
       var hou="";
       

        var dedesc = "'" + (document.getElementById('detaildesc').value) + "'";
       var casededesc = dedesc;
        var desc = "''";
        
        
        
if(Modify == 1)
    {
      ModifyClass();
        
      return false;
    }
        
        
        
        
        
        casehouse=casehouse.replace("'","");
        casehouse=casehouse.replace("'","");
       
       casededesc=casededesc.replace("'","");
        casededesc=casededesc.replace("'","");
        
        casedescription=casedescription.replace("'","");
        casedescription=casedescription.replace("'","");
      
      
      
//        caseplanet=caseplanet.replace("'","");
//        caseplanet=caseplanet.replace("'","");
      
        casebook=casebook.replace("'","");
       casebook=casebook.replace("'","");
      
        //casepage0=casepage0.replace("'","");
       //casepage0=casepage0.replace("'","");
        
        //casetrines=casetrines.replace("'","");
       // casetrines=casetrines.replace("'","");
        
       // casequardent=casequardent.replace("'","");
       // casequardent=casequardent.replace("'","");
        
       // casequardent=casequardent.replace("'","");
       // casequardent=casequardent.replace("'","");
        
//       caseplant=caseplant.replace("'","");
//               caseplant=caseplant.replace("'","");
//        caseloh=caseloh.replace("'","");
//          caseloh=caseloh.replace("'","");
        
       
        
         var tablevalue = casehouse+ "$~$"+casedescription+ "$~$"+casededesc+ "$~$"+caselord+ "$~$"+rashi+ "$~$"+hou+ "$~$" ;
        
        
        var fi = document.getElementById('tblfields').value.replace("$~$" + tablename, "")
        fi = fi.replace("$~$" + action, "")
        var dateformate = document.getElementById('hiddendateformat').value
        
        
        
        var result=planet_aspect.saveaspect(casehouse,casedescription,casededesc,caselord,rashi,hou)
        
        if (result.value.toUpperCase() == "TRUE")
         {
            alert("Data saved successfully");
           ClearAll();
            blankfields();
         
        }
        else 
        {
            var exalert = result.value;
            var exalert1 = exalert.split("-");
            if (exalert1[0].indexOf("ORA") >= 0)
             {
                if (exalert1[1].indexOf("00001") >= 0)
                 {
                    alert("Data Not Saved.This combination already exists.Please enter another combination.")
                    ClearAll();
                    return false;

                }
            }

        }
        document.getElementById('btnNew').disabled = false;
        document.getElementById('btnNew').focus();
        setButtonImages();

        return false;
    
    }
    
    
    
    function ClearAll()
{


 Modify=0;

        dsexe="";
        next=0;
        $('btnNew').disabled = false;
        $('btnNew').focus();
        $('btnQuery').disabled = false;
        $('btnCancel').disabled = false;
        $('btnExit').disabled = false;
        $('btnSave').disabled = true;
        $('btnExecute').disabled = true;
        $('btnfirst').disabled = true;
        $('btnlast').disabled = true;
        $('btnModify').disabled = true;
        $('btnprevious').disabled = true;
        $('btnnext').disabled = true;
        $('btnDelete').disabled = true;      
   
       setButtonImages();


       $('book').disabled = true;
       $('keystring').disabled = true;
        //$('page0').disabled= true;
      $('div1').style.display='none';
         //$('div3').style.display='none';
        $('house').disabled= true;
        // $('quardent').disabled= true;
         
          //  $('plant').disabled= true;
            if($('astrocat').selectedIndex==2)
            {
               $('planet').disabled= true;
             }
             else
             {
               $('DropDownList1').disabled= true;
             }
               $('DropDownList2').disabled= true;
             
               $('astrocat').disabled= true;
               
       // $('trines').disabled= true;
        $('Textdesc').disabled= true;
       // $('planet').disabled= true;        
        $('detaildesc').disabled= true;
         

       
     //  if($('page0').value!="")
     // { 
     // $('page0').value="";
        // }

        if ($('keystring').value != "") {
            $('keystring').value = "";
        }
     if($('book').value!="")
     { 
      $('book').value="";
      }
      if($('house').value!="")
      { 
      document.getElementById('house').selectedIndex = 0;
      }
      if($('astrocat').selectedIndex==2)
{

if($('planet').value!="")
      { 
     document.getElementById('planet').selectedIndex = 0;
      }
    
      
}
else
{
 if($('DropDownList1').value!="")
      { 
      document.getElementById('DropDownList1').selectedIndex = 0;
      }

} 
       
//       if($('astrocat').value!="")
//      { 
//      document.getElementById('astrocat').selectedIndex = 0;
//      }
      
      
        
//      if($('quardent').value!="")
//    { 
//      $('quardent').value="";
//      }
        
        
//         if($('plant').value!="")
//      { 
//      $('plant').value="";
//      }
       


     if($('DropDownList2').value!="")
      { 
     document.getElementById('DropDownList2').selectedIndex = 0;
      }
      
       //  if($('trines').value!="")
     // { 
     // $('trines').value="";
    //  }
        
         
      if($('Textdesc').value!="")
      { 
      $('Textdesc').value="";
      }
      
     
      
      
//      if($('planet').value!="")
//      { 
//      $('planet').value="";
//      }
           
      if($('detaildesc').value!="")
      { 
      $('detaildesc').value="";
      }
      
     
        
    setButtonImages();
     return false;
   }
  
  
  function setButtonImages()
{
    if(document.getElementById('btnNew').disabled==true)
        document.getElementById('btnNew').src="Image/new-off.jpg";
    else
        document.getElementById('btnNew').src="Image/new.jpg";
        
    if(document.getElementById('btnSave').disabled==true)
        document.getElementById('btnSave').src="Image/save-off.jpg";
    else
        document.getElementById('btnSave').src="Image/save.jpg";
        
    if(document.getElementById('btnModify').disabled==true)
        document.getElementById('btnModify').src="Image/modify-off.jpg";
    else
        document.getElementById('btnModify').src="Image/modify.jpg";
        
    if(document.getElementById('btnQuery').disabled==true)
        document.getElementById('btnQuery').src="Image/query-off.jpg";
    else
        document.getElementById('btnQuery').src="Image/query.jpg";
    
    if(document.getElementById('btnExecute').disabled==true)
        document.getElementById('btnExecute').src="Image/execute-off.jpg";
    else
        document.getElementById('btnExecute').src="Image/execute.jpg";
        
    if(document.getElementById('btnCancel').disabled==true)
        document.getElementById('btnCancel').src="Image/clear-off.jpg";
    else
        document.getElementById('btnCancel').src="Image/clear.jpg";
        
    if(document.getElementById('btnfirst').disabled==true)
        document.getElementById('btnfirst').src="Image/first-off.jpg";
    else
        document.getElementById('btnfirst').src="Image/first.jpg";
        
    if(document.getElementById('btnprevious').disabled==true)
        document.getElementById('btnprevious').src="Image/previous-off.jpg";
    else
        document.getElementById('btnprevious').src="Image/previous.jpg";
        
    if(document.getElementById('btnnext').disabled==true)
        document.getElementById('btnnext').src="Image/next-off.jpg";
    else
        document.getElementById('btnnext').src="Image/next.jpg";
        
    if(document.getElementById('btnlast').disabled==true)
        document.getElementById('btnlast').src="Image/last-off.jpg";
    else
        document.getElementById('btnlast').src="Image/last.jpg";   
        
    if(document.getElementById('btnDelete').disabled==true)
        document.getElementById('btnDelete').src="Image/delete-off.jpg";
    else
        document.getElementById('btnDelete').src="Image/delete.jpg";
        
    if(document.getElementById('btnExit').disabled==true)
        document.getElementById('btnExit').src="Image/exit-off.jpg";
    else
        document.getElementById('btnExit').src="Image/exit.jpg";
     }
     
     
     
     
      function ModifyClass()
    {
    
    
    
    
    
    
    
      var str = document.getElementById('tblfields').value;
        var str1 = str.split("$~$");
        var tablename = str1[str1.length - 2];

        var action = str1[str1.length - 1];
        var finalaction = action.split("#");
        var insert = finalaction[0];
        var update = finalaction[1];
        var del = finalaction[2];
        var select = finalaction[3];


       
       
        
        
       var book = "'" + (document.getElementById('book').value) + "'";
       var casebook = book;

       var keystring = "'" + (document.getElementById('keystring').value) + "'";
       var casekeystring = keystring;
        
        //var page = "'" + (document.getElementById('page0').value) + "'";
       // var casepage0 = page;
        
        var house = "'" + (document.getElementById('house').value) + "'";
        var casehouse = house;
        
      //  var quardent = "'" + (document.getElementById('quardent').value) + "'";
      //  var casequardent = quardent;
        
   var plant = "'" + (document.getElementById('plant').value) + "'";
        var caseplant = plant;
        
          var loh = "'" + (document.getElementById('DropDownList1').value) + "'";
        var caseloh = loh;
        
    //    var trines = "'" + (document.getElementById('trines').value) + "'";
      //  var casetrines = trines;
        
        
         var planet = "'" + document.getElementById('planet').value + "'";
        var caseplanet = planet;
        
        
        
                
        
        var description = "'" + (document.getElementById('Textdesc').value) + "'";
        var casedescription= description;
        

       
       

        var dedesc = "'" + (document.getElementById('detaildesc').value) + "'";
        var casededesc = dedesc;
        var desc = "''";
        
    
    
     var fi = document.getElementById('tblfields').value.replace("$~$" + tablename, "")
        fi = fi.replace("$~$" + action, "")
        fi=fi+"$~$"
        
        
        var concolname="CODE"+"$~$";
        var dateformate = document.getElementById('hiddendateformat').value

        var tablevalue = caseplanet + "$~$" + casehouse + "$~$" + casebook + "$~$" + casepage0 + "$~$" + casequardent + "$~$" + casetrines + "$~$" + casedescription + "$~$" + casededesc + "$~$" + caseplant + "$-$" + caseloh + "$-$" + casekeystring + "$-$";
    var res=planet_aspect.Modify_dataaspect(tablename,fi,tablevalue,concolname,dateformate,"","",callbackeex)
    }
    
    
    
    
    function callbackeex(res)
{
    if(res.value=="true")
                {
                    
                    alert("Data updated Successfully")
                   ClearAll();
                    return false;
                    
                }
                else
                {
                    alert(res.value);
                    return false;
                }
}



 function Exit()
{
       if(confirm("Do You want to skip the page?"))
       {
         window.close();
         return false;
   }
}


function modifydata()
{

Modify=1;
     
      document.getElementById("Hidden36").value =1

      var modifyduplicacyalias = $('book').value;
      var modifyduplicacyalias = $('keystring').value; 
          var   modifyduplicacydesc=$('house').value;
          if($('astrocat').selectedIndex==2)
              {
             var    modifyduplicacyalias=$('planet').value;       
             }
         else
            {
            var   modifyduplicacydesc=$('Dropdownlist1').value;
              }
         var    modifyduplicacyalias=$('Dropdownlist2').value;   
         var    modifyduplicacyalias=$('astrocat').value; 
         var    modifyduplicacyalias=$('Textdesc').value;             
         var  modifyduplicacyalias=$('detaildesc').value;


         document.getElementById("book").disabled = false;
         document.getElementById("keystring").disabled = false;
    document.getElementById("house").disabled=false;
    document.getElementById("astrocat").disabled=false;
    document.getElementById("Dropdownlist2").disabled=false;
    document.getElementById("Textdesc").disabled=false;
    document.getElementById("detaildesc").disabled=false;
   
  if($('astrocat').selectedIndex==2)
  {
   document.getElementById("planet").disabled=false;
  }
  else 
  {
  document.getElementById("Dropdownlist1").disabled=false;
  }
   
   
    
  
    document.getElementById("btnModify").disabled=true;
    document.getElementById("btnlast").disabled=true;
    document.getElementById("btnnext").disabled=true;
    document.getElementById("btnfirst").disabled=true;
    document.getElementById("btnprevious").disabled=true;
    document.getElementById("btnDelete").disabled=false;
    document.getElementById("btnSave").disabled=false;
    modify="true";
   
     
    
    delete_record = 0;
    setButtonImages();
    return false;
}

function enablequery()
{
    document.getElementById("btnNew").disabled=true;
    document.getElementById("btnSave").disabled=true;
    document.getElementById("btnModify").disabled=true;
    document.getElementById("btnQuery").disabled=true;
    document.getElementById("btnExecute").disabled=false;
    document.getElementById("btnCancel").disabled=false;
    document.getElementById("btnfirst").disabled=true;
    document.getElementById("btnprevious").disabled=true;        
    document.getElementById("btnnext").disabled=true;
    document.getElementById("btnlast").disabled=true;
    document.getElementById("btnDelete").disabled=true;
    document.getElementById("btnExit").disabled=false;




    document.getElementById("book").disabled = false;
    document.getElementById("keystring").disabled = false;
 //    document.getElementById("page0").disabled=false;
    document.getElementById("house").disabled=false;
//        document.getElementById("quardent").disabled=false;
        //document.getElementById("plant").disabled=false;
        if($('astrocat').selectedIndex==2)
        {
          document.getElementById('planet').disabled=false;
        }
        else
        {
             document.getElementById('DropDownList1').disabled=false;
        }
        
        document.getElementById("DropDownList2").disabled=false;
  //          document.getElementById("trines").disabled=false;
   
    document.getElementById("Textdesc").disabled=false;
    
    document.getElementById('astrocat').disabled=false;
 //   document.getElementById("planet").disabled=false;
    document.getElementById("detaildesc").disabled=false;
               
    





//document.getElementById('quardent').style.display='block';
//document.getElementById('plant').style.display='block';
 if($('astrocat').selectedIndex==2)
        {
          document.getElementById('planet').style.display='block';
        }
        else
        {
             document.getElementById('DropDownList1').style.display='block';
        }

document.getElementById('DropDownList2').style.display='block';
//document.getElementById('trines').style.display='block';
document.getElementById('house').style.display='block';
  document.getElementById('astrocat').style.display='block';
document.getElementById('Textdesc').style.display='block';
document.getElementById('book').style.display='block';
//document.getElementById('page0').style.display='block';
//document.getElementById('planet').style.display='block';
document.getElementById('detaildesc').style.display='block';
      
        
    
        
    document.getElementById("btnExecute").focus(); 
    
    delete_record = 0; 
 
     setButtonImages();
    return false;

}



function delete_data()
{ 
       var house="'"+document.getElementById("house").value+"'"
       var categery="'"+document.getElementById("Dropdownlist2").value+"'"
       var astrocat="'"+document.getElementById("astrocat").value+"'"
       var detail="'"+document.getElementById("detaildesc").value+"'"
       var planet="";
       var loh="";
       if($('astrocat').selectedIndex==2)
       {     
             var planet="'"+(document.getElementById("planet").value)+"'"  
           
       }
        else
        {

            var loh="'"+(document.getElementById("Dropdownlist1").value)+"'" 
           
        }

              if(confirm("Are you sure! Do you want to delete this entry?"))
   
        {
        if($('astrocat').selectedIndex==2)
        {
                    var fieldsvalue=house+"$~$"+categery+"$~$"+astrocat+"$~$"+planet;
         }
         else
         {
         var fieldsvalue=house+"$~$"+categery+"$~$"+astrocat+"$~$"+loh;
         }
         
               var SPLITVALUE=document.getElementById('fields').value.split("$~$")
         
       if($('astrocat').selectedIndex==2)
          {
               var fields1="LORD_OF_HOUSE2"+"$~$"+"CATEGERY"+"$~$"+"ASTRO_CAT"+"$~$"+"PLANET";
          }
       else
          {
               var fields1="LORD_OF_HOUSE2"+"$~$"+"CATEGERY"+"$~$"+"ASTRO_CAT"+"$~$"+"LORD_OF_HOUSE";
          }
   
               var tablename="PLANET_ASPECT";
               
              var extra1="''";
              var extra2="''";
             
              var res=planet_aspect.deleteaspect(tablename,fields1,fieldsvalue,document.getElementById('hiddendateformat').value,extra1,extra2)
            
              document.getElementById("btnSave").disabled=true;
              document.getElementById("btnDelete").disabled=true;
              
           if(res.value=="true")
                {
                    delete_record = 1;
                    alert("Data Delete Successfully")
                    disabledexecfld();
                    return false;
                }
                else
                {
                    alert(res.value);
                    return false;
                }
       } 
       else
       {
             $('btnDelete').focus();
             return false;
       }  
 }
 function disabledexecfld()
{
   
    next=0;
    exec_data="";
    
    srt_count = 0;
    record_show1=1 ;
    
     
   //  document.getElementById("quardent").disabled=true;
      //document.getElementById("plant").disabled=true;
       if($('astrocat').selectedIndex==2)
        {
          document.getElementById('planet').disabled=true;
        }
        else
        {
             document.getElementById('DropDownList1').disabled=true;
        }
       document.getElementById("DropDownList2").disabled=true;
  //  document.getElementById("trines").disabled=true;
       document.getElementById("book").disabled = true;
       document.getElementById("keystring").disabled = true;
  //  document.getElementById("page0").disabled=true;    
    document.getElementById("detaildesc").disabled=true;
    document.getElementById("Textdesc").disabled=true;
    document.getElementById("house").disabled=true;
//    document.getElementById("planet").disabled=true;
    document.getElementById('astrocat').disabled=true;
     
     
    document.getElementById("btnNew").disabled=false;
    document.getElementById("btnSave").disabled=true;
    document.getElementById("btnModify").disabled=true;
    document.getElementById("btnQuery").disabled=false;
    document.getElementById("btnExecute").disabled=true;
    document.getElementById("btnCancel").disabled=false;
    document.getElementById("btnfirst").disabled=true;
    document.getElementById("btnprevious").disabled=true;
    document.getElementById("btnnext").disabled=true;
    document.getElementById("btnlast").disabled=true;
    document.getElementById("btnDelete").disabled=true;
    document.getElementById("btnExit").disabled=false;
    
    
    



    
   // document.getElementById("quardent").value=""
   // document.getElementById("plant").value=""
    document.getElementById("DropDownList1").value=""
     document.getElementById("DropDownList2").value=""
 //   document.getElementById("trines").value=""
     document.getElementById("book").value = ""
     document.getElementById("keystring").value = ""
 //   document.getElementById("page0").value=""
    document.getElementById("detaildesc").value=""
    document.getElementById("Textdesc").value=""
    document.getElementById("house").value=""
    document.getElementById("planet").value=""
    
        modify="false";
    
    
    
        
    
    delete_record = 0;
    
      setButtonImages();
    return false;
}


function executequery(querytype)

{

 document.getElementById("btnDelete").disabled=false;
       var house="";
      
      // var planet="";
       //  var plant="";
   //    var quardent="";
     //  var trines="";
          var loh="";
        var planet="";
     var categery="";
         var astrocat="";







         var book = "'" + document.getElementById("book").value + "'"
         var keystring = "'" + document.getElementById("keystring").value + "'"        
      // var page0="'"+document.getElementById("page0").value+"'"           
                   
       if(document.getElementById("astrocat").value!=0)
        {
          astrocat="'"+document.getElementById("astrocat").value+"'"
        }
        else
        
        {
        astrocat="'"+astrocat+"'"
        }       
        if(document.getElementById("house").value!=0)
        {
          house="'"+document.getElementById("house").value+"'"
        }
        else
        
        {
        house="'"+house+"'"
        }
        
//         if(document.getElementById("planet").value!=0)
//        {
//          planet="'"+document.getElementById("planet").value+"'"
//        }
//        else
//        
//        {
//        planet="'"+planet+"'"
//        }
        
    //    if(document.getElementById("quardent").value!=0)
    //    {
    //      quardent="'"+document.getElementById("quardent").value+"'"
    //    }
    //    else
        
    //    {
    //    quardent="'"+quardent+"'"
    //    }
        
//         if(document.getElementById("plant").value!=0)
//        {
//          plant="'"+document.getElementById("plant").value+"'"
//        }
//        else
//        
//        {
//        plant="'"+plant+"'"
//        }
//planet="'"+planet+"'";
 //loh="'"+loh+"'";
if($('astrocat').selectedIndex==0||$('astrocat').selectedIndex==1)
        {
             if(document.getElementById("DropDownList1").value!=0)
                 {
                         loh="'"+document.getElementById("DropDownList1").value+"'"
                  planet="'"+planet+"'"
                 }
             else
        
                {
                        loh="'"+loh+"'"
                         planet="'"+planet+"'"
                }
}
else
{
 if(document.getElementById("planet").value!=0)
                 {
                         planet="'"+document.getElementById("planet").value+"'"
                  loh="'"+loh+"'"
                 }
             else
        
                {
                
                        planet="'"+planet+"'"
                  loh="'"+loh+"'"
                }


}
        
        
        
        if(document.getElementById("DropDownList2").value!=0)
        {
          categery="'"+document.getElementById("DropDownList2").value+"'"
        }
        else
        
        {
        categery="'"+categery+"'"
        }
        
 //        if(document.getElementById("trines").value!=0)
 //       {
 //         trines="'"+document.getElementById("trines").value+"'"
 //       }
 //       else
 //       {
 //       trines="'"+trines+"'"
 //       }
                
        
               
      
     
             
       var descrption="'"+document.getElementById("Textdesc").value+"'"
        
       var dedsec=""+document.getElementById("detaildesc").value+"'"
    
       
       var detaildesc="'"+"'";   
       
       
         
 
      var userid="'"+document.getElementById("hdnuserid").value+"'"
    var userid="''";
 // document.getElementById("btnExecute").disabled=true;
  document.getElementById("btnfirst").disabled=false;



  var fieldsvalue = house + "$~$" + descrption + "$~$" + detaildesc + "$~$" + loh + "$~$" + categery + "$~$" + planet + "$~$" + astrocat + "$~$" + book + "$~$" + keystring + "$~$"    

 
  



  
   
   var SPLITVALUE=document.getElementById('fields').value.split("$~$")
      var fields=document.getElementById('fields').value.replace("$~$"+SPLITVALUE[SPLITVALUE.length-2],"").replace("$~$"+SPLITVALUE[SPLITVALUE.length-1],"")
    
     exectefuncol=fields;
     exectefunvalue=fieldsvalue;
     exectefuntab=SPLITVALUE[SPLITVALUE.length-2];
    old_exec_value=fieldsvalue;
      fields = fields+"$~$"

      document.getElementById("Hidden7").value = loh;
    var res1=planet_aspect.execute(SPLITVALUE[SPLITVALUE.length-2],fields,fieldsvalue,"select",$('hiddendateformat').value,"","");
  execute_callback(res1);

  return;
}





function execute_callback(val)
{
var gg=0;
var degreet="";
record_show=10
record_show1=1

exec_data=val.value;
     
    
    if(exec_data == null)
    {
       alert("There is no data available regarding your query.")
     
        
       
    
       return false;
    }
    
    if(exec_data != null)
      {
         total_records = exec_data.Tables[0].Rows.length;
      }
      else
      {
         total_records = "0";
      }
    
    if(delete_record == 1)
    {
        //  dsexe = response.value;
          var length_del = exec_data.Tables[0].Rows.length;
        //  total_records = exec_data.Tables[0].Rows.length;
          var a=length_del-1;
          if(length_del<=0)
          {
         
        alert("There is no data available regarding your query.")
             disabledexecfld();
             return false;
            
          }
          else if (next == -1 || next >= length_del)
          {
             next = 0;
          }
          else
          {
             next = next ;
          }
          
    }
    
    
    var i=0
    
    
    if(exec_data.Tables[0].Rows.length>0)
    {





      
        
        
       
       document.getElementById("book").value=(exec_data.Tables[0].Rows[next].BOOK);
      
        if(document.getElementById("book").value=="null")
     {
           document.getElementById("book").value="";
      }
      else
       {
      document.getElementById("book").value=(exec_data.Tables[0].Rows[next].BOOK);
  }



  document.getElementById("keystring").value = (exec_data.Tables[0].Rows[next].KEY_STRING);

  if (document.getElementById("keystring").value == "null") {
      document.getElementById("keystring").value = "";
  }
  else {
      document.getElementById("keystring").value = (exec_data.Tables[0].Rows[next].KEY_STRING);
  }
      // document.getElementById("page0").value=(exec_data.Tables[0].Rows[next].PAGE_NO);
        
        
  //      if(document.getElementById("page0").value=="null")
    //   {
      //     document.getElementById("page0").value="";
   //    }
     //  else
       //{
     // document.getElementById("page0").value=(exec_data.Tables[0].Rows[next].PAGE_NO);
       //}
        document.getElementById("astrocat").value=(exec_data.Tables[0].Rows[next].ASTRO_CAT);
        document.getElementById("house").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE2);
          //document.getElementById("planet").value=(exec_data.Tables[0].Rows[next].PLANET);        
   //     document.getElementById("quardent").value=(exec_data.Tables[0].Rows[next].QUADRENTS);
        //document.getElementById("plant").value=(exec_data.Tables[0].Rows[next].PLANT);
        if($('astrocat').selectedIndex==2)
        {
         document.getElementById("planet").value=(exec_data.Tables[0].Rows[next].PLANET);
        }
        else
        {
            document.getElementById("DropDownList1").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE);
        }
          
           document.getElementById("DropDownList2").value=(exec_data.Tables[0].Rows[next].CATEGERY);
     //   document.getElementById("trines").value=(exec_data.Tables[0].Rows[next].TRINES);
        
      
        document.getElementById("Textdesc").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);       
          if(document.getElementById("Textdesc").value=="null")
       {
           document.getElementById("Textdesc").value="";
       }
       else
       {
      document.getElementById("Textdesc").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);
       }
       
       
//       if(document.getElementById('Hidden38').value!="")
//       {
//       
//       
//       
//       if(document.getElementById('Hidden37').value=="1")
//       {
//      var categery= document.getElementById('Hidden38').value.split("$");
//              for(var m=0;m<categery.length-1;m++)
//              {
//              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
//              {
//              gg++;
//              }
//              }
//      
//       }
//       else
//       {
//       
//              var categery= document.getElementById('Hidden38').value.split("$");
//              for(var m=0;m<categery.length-1;m++)
//              {
//              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
//              {
//              gg++;
//              }
//              }
//       
//       }
//       
//       if(document.getElementById('Hidden37').value=="1")
//       {
//       if(gg==categery.length)
//       {
//        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       }
//       else
//       {
//       alert("No Match Found");
//       return false;
//       
//       }
//       }
//       else
//       {
//       if(gg>0)
//        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//        else
//        {
//       alert("No Match Found");
//        $('btnfirst').disabled = true;
//	$('btnlast').disabled = false;
//	$('btnprevious').disabled = true;
//	$('btnnext').disabled = false;
//       return false;
//        }
//       }
//       
//       }
//       else
//       {
//        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       
//       }
//       
       
        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
       
          if(document.getElementById("detaildesc").value=="null")
       {
           document.getElementById("detaildesc").value="";
       }
       else
       {
      document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
       }


       old_execute_book = exec_data.Tables[0].Rows[next].BOOK;
       old_execute_keystring = exec_data.Tables[0].Rows[next].KEY_STRING;
    //   old_execute_page0 =exec_data.Tables[0].Rows[next].PAGE_NO;
    old_execute_astrocat=exec_data.Tables[0].Rows[next].ASTRO_CAT;
    document.getElementById("Hidden30").value =exec_data.Tables[0].Rows[next].ASTRO_CAT;
       old_execute_aspects=exec_data.Tables[0].Rows[next].LORD_OF_HOUSE2;
        document.getElementById("Hidden3").value =exec_data.Tables[0].Rows[next].LORD_OF_HOUSE2;
        
      // old_execute_planet =exec_data.Tables[0].Rows[next].PLANET;
     
       old_execute_description=exec_data.Tables[0].Rows[next].DESCRIPTION; 
       document.getElementById("Hidden5").value =exec_data.Tables[0].Rows[next].DESCRIPTION;
       old_execute_descclob  =exec_data.Tables[0].Rows[next].DESCCLOB;     
       document.getElementById("Hidden6").value =exec_data.Tables[0].Rows[next].DESCCLOB;
      // old_execute_quardent =exec_data.Tables[0].Rows[next].QUADRENTS;
     //  old_execute_plant =exec_data.Tables[0].Rows[next].PLANT;
    if($('astrocat').selectedIndex==2)
        {
        old_execute_planet=exec_data.Tables[0].Rows[next].PLANET;
         document.getElementById("Hidden29").value =exec_data.Tables[0].Rows[next].PLANET;
        }
        else
        {
           old_execute_loh=exec_data.Tables[0].Rows[next].LORD_OF_HOUSE;
       document.getElementById("Hidden7").value =exec_data.Tables[0].Rows[next].LORD_OF_HOUSE;
        }
     
     old_execute_categery=exec_data.Tables[0].Rows[next].CATEGERY;
       
       document.getElementById("Hidden28").value =exec_data.Tables[0].Rows[next].CATEGERY;
     //  old_execute_trines =exec_data.Tables[0].Rows[next].TRINES;
      
      
   

    
         document.getElementById("btnModify").disabled=false;
        // document.getElementById("planet").disabled=true;
         document.getElementById("house").disabled=true;
           document.getElementById("astrocat").disabled=true;
           document.getElementById("book").disabled = true;
           document.getElementById("keystring").disabled = true;
       //   document.getElementById("page0").disabled=true;
        
         document.getElementById("Textdesc").disabled=true;
        
     //    document.getElementById("quardent").disabled=true;
          //    document.getElementById("plant").disabled=true;
                  if($('astrocat').selectedIndex==2)
        {
         document.getElementById("planet").disabled=true;
        }
        else
        {
             document.getElementById("DropDownList1").disabled=true;
        }
                 
                    document.getElementById("DropDownList2").disabled=true;
      //   document.getElementById("trines").disabled=true;
         
         document.getElementById("detaildesc").disabled=true;
       
      
    $('btnfirst').disabled = true;
	$('btnlast').disabled = false;
	$('btnprevious').disabled = true;
	$('btnnext').disabled = false;
	
   setButtonImages();
    }
    else
    {
         alert("There is no data available regarding your query.")
        
        
        $('btnfirst').disabled = true;
	    $('btnlast').disabled = true;
	    $('btnprevious').disabled = true;
	    $('btnnext').disabled = true;
	   // $('next1').disabled=true;
	 setButtonImages();
       // disabledexecfld();
        return false;
    }
}

 function fnd_first_record()
{
      delete_record = 0;
      record_show=5
      record_show1=1
var gg1=0;
       next="0";
       chk_button(next)

      
       old_execute_book =exec_data.Tables[0].Rows[next].BOOK;

       old_execute_keystring = exec_data.Tables[0].Rows[next].KEY_STRING;
        //      old_execute_page0 =exec_data.Tables[0].Rows[next].PAGE_NO;
       old_execute_house =exec_data.Tables[0].Rows[next].LORD_OF_HOUSE2;
        old_execute_astrocat =exec_data.Tables[0].Rows[next].ASTRO_CAT;
         
      // old_execute_planet =exec_data.Tables[0].Rows[next].PLANET;
//       old_execute_trines =exec_data.Tables[0].Rows[next].TRINES;            
      // old_execute_plant =exec_data.Tables[0].Rows[next].PLANT;   
        if($('astrocat').selectedIndex=="Planet")
        {
        old_execute_planet=exec_data.Tables[0].Rows[next].PLANET;
         
        }
        else
        {
       old_execute_loh =exec_data.Tables[0].Rows[next].LORD_OF_HOUSE;
       
        }         
       
       old_execute_categery =exec_data.Tables[0].Rows[next].CATEGERY;            
//       old_execute_quardent =exec_data.Tables[0].Rows[next].QUADRENTS;            
       
       old_execute_desc =exec_data.Tables[0].Rows[next].DESCRIPTION;       
       old_execute_dedesc =exec_data.Tables[0].Rows[next].DESCCLOB;
        

      
        
        
       
  //          document.getElementById("page0").value=(exec_data.Tables[0].Rows[next].PAGE_NO);
        
        
  //      if(document.getElementById("page0").value=="null")
  //     {
  //         document.getElementById("page0").value="";
  //     }
    //   else
  //     {
  //    document.getElementById("page0").value=(exec_data.Tables[0].Rows[next].PAGE_NO);
   //    }
        document.getElementById("book").value=(exec_data.Tables[0].Rows[next].BOOK);
        
        
        if(document.getElementById("book").value=="null")
      {
          document.getElementById("book").value="";
      }
       else
      {
      document.getElementById("book").value=(exec_data.Tables[0].Rows[next].BOOK);
  }


  document.getElementById("keystring").value = (exec_data.Tables[0].Rows[next].KEY_STRING);


  if (document.getElementById("keystring").value == "null") {
      document.getElementById("keystring").value = "";
  }
  else {
      document.getElementById("keystring").value = (exec_data.Tables[0].Rows[next].KEY_STRING);
  }
   document.getElementById("astrocat").value=(exec_data.Tables[0].Rows[next].ASTRO_CAT);
        document.getElementById("house").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE2);
        
      document.getElementById("Hidden20").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE2);
       // document.getElementById("planet").value=(exec_data.Tables[0].Rows[next].PLANET);
 //       document.getElementById("quardent").value=(exec_data.Tables[0].Rows[next].QUADRENTS);
         // document.getElementById("plant").value=(exec_data.Tables[0].Rows[next].PLANT);
          if($('astrocat').selectedIndex==2)
        {
      // document.getElementById("planet").value=(exec_data.Tables[0].Rows[next].PLANET);
          document.getElementById("Hidden31").value=(exec_data.Tables[0].Rows[next].PLANET);
        }
        else
        {
     //  document.getElementById("DropDownList1").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE);
       document.getElementById("Hidden21").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE);
        } 
            
            document.getElementById("DropDownList2").value=(exec_data.Tables[0].Rows[next].CATEGERY);
             
             document.getElementById("Hidden24").value=(exec_data.Tables[0].Rows[next].CATEGERY);
   //     document.getElementById("trines").value=(exec_data.Tables[0].Rows[next].TRINES);
       
         
        
        
        document.getElementById("Textdesc").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);  
          if(document.getElementById("Textdesc").value=="null")
       {
           document.getElementById("Textdesc").value="";
       }
       else
       {
      document.getElementById("Textdesc").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);
       }
       document.getElementById("Hidden22").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);      
       
       
//         if(document.getElementById('Hidden38').value!="")
//       {
//       
//       
//       
//       if(document.getElementById('Hidden37').value=="1")
//       {
//      var categery= document.getElementById('Hidden38').value.split("$");
//              for(var m=0;m<categery.length-1;m++)
//              {
//              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
//              {
//              gg1++;
//              }
//              }
//      
//       }
//       else
//       {
//       
//              var categery= document.getElementById('Hidden38').value.split("$");
//              for(var m=0;m<categery.length-1;m++)
//              {
//              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
//              {
//              gg1++;
//              }
//              }
//       
//       }
//       
//       if(document.getElementById('Hidden37').value=="1")
//       {
//       if(gg1==categery.length)
//       {
//        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       }
//       else
//       {
//       alert("No Match Found");
//       return false;
//       
//       }
//       }
//       else
//       {
//       if(gg1>0)
//        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//        else
//        {
//       alert("No Match Found");
//       return false;
//        }
//       }
//       
//       }
//       else
//       {
//        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       
//       }
//       
//       
//       
//        
//        if(document.getElementById("detaildesc").value=="null")
//       {
//           document.getElementById("detaildesc").value="";
//       }
//       else
//       {
//      document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       }
//       
document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
        document.getElementById("Hidden23").value=(exec_data.Tables[0].Rows[next].DESCCLOB);

    
    


    return ;
}

function chk_button(a)
{
var book="''";
var house="''";
var descrption="''";
var detaildesc="''";
var loh="''";
var categery="''";
var planet="''";
var astrocat = "''";
var keystring = "''";
var fieldsvalue = house + "$~$" + descrption + "$~$" + detaildesc + "$~$" + loh + "$~$" + categery + "$~$" + planet + "$~$" + astrocat + "$~$" + book + "$~$" + keystring + "$~$"       
    



  
   
   var SPLITVALUE=document.getElementById('fields').value.split("$~$")
      var fields=document.getElementById('fields').value.replace("$~$"+SPLITVALUE[SPLITVALUE.length-2],"").replace("$~$"+SPLITVALUE[SPLITVALUE.length-1],"")
    
     exectefuncol=fields;
     exectefunvalue=fieldsvalue;
     exectefuntab=SPLITVALUE[SPLITVALUE.length-2];
    old_exec_value=fieldsvalue;
      fields = fields+"$~$"
     
    
    var res1=planet_aspect.execute(SPLITVALUE[SPLITVALUE.length-2],fields,fieldsvalue,"select",$('hiddendateformat').value,"","");
    exec_data=res1.value;
    if(exec_data == null)
    {
       alert("There is no data available regarding your query.")
     
        
       
    
       return false;
    }
     if(exec_data != null)
      {
        total_records = exec_data.Tables[0].Rows.length;
      }
      else
      {
         total_records = "0";
      }
     if(delete_record == 1)
    {
        //  dsexe = response.value;
          var length_del = exec_data.Tables[0].Rows.length;
        //  total_records = exec_data.Tables[0].Rows.length;
          var a=length_del-1;
          if(length_del<=0)
          {
         
        alert("There is no data available regarding your query.")
             disabledexecfld();
             return false;
            
          }
          else if(next==-1 || next>= length_del)
          {
             next = 0;
          }
          else
          {
             next = next ;
          }
          
    }
    
if(exec_data.Tables[0].Rows.length==1 || exec_data.Tables[0].Rows.length==0)
{
        document.getElementById("btnlast").disabled=true;
        document.getElementById("btnnext").disabled=true;
        document.getElementById("btnfirst").disabled=true;
        document.getElementById("btnprevious").disabled=true;
         setButtonImages();
}
else if(next=="0")
{
        document.getElementById("btnlast").disabled=false;
        document.getElementById("btnnext").disabled=false;
      //  document.getElementById("btnfirst").disabled=true;
        //document.getElementById("btnprevious").disabled=true;
         setButtonImages();
        return ;
    }

else if(next==exec_data.Tables[0].Rows.length-1)
{
        //document.getElementById("btnlast").disabled=true;
      //  document.getElementById("btnnext").disabled=true;
        document.getElementById("btnfirst").disabled=false;
        document.getElementById("btnprevious").disabled=false;
         setButtonImages();
        return ;
    }
    
    else
    {
        document.getElementById("btnlast").disabled=false;
        document.getElementById("btnnext").disabled=false;
        document.getElementById("btnfirst").disabled=false;
        document.getElementById("btnprevious").disabled=false;
        setButtonImages();
        return ;
    }
    
}


function fnd_next_record()
{
    delete_record = 0;
    record_show=8
    record_show1=1
    next=parseInt(next)+1;
    chk_button(next) 
var gg2=0;




       
//         old_execute_page0 =exec_data.Tables[0].Rows[next].PAGE_NO;
         old_execute_house =exec_data.Tables[0].Rows[next].LORD_OF_HOUSE2;
         old_execute_astrocat =exec_data.Tables[0].Rows[next].ASTRO_CAT;
          document.getElementById("Hidden35").value=(exec_data.Tables[0].Rows[next].ASTRO_CAT);
            document.getElementById("astrocat").value=(exec_data.Tables[0].Rows[next].ASTRO_CAT);
//           old_execute_quardent =exec_data.Tables[0].Rows[next].QUADRENTS;
                   //old_execute_plant =exec_data.Tables[0].Rows[next].PLANT;
     if(old_execute_astrocat=="Planet")
        {
        
        old_execute_planet=exec_data.Tables[0].Rows[next].PLANET;
         
        }
        else
        {
        // $('planet').style.display='none';
       //  $('DropDownList1').disabled=true;
        // $('DropDownList1').style.display='block';
          
         old_execute_loh =exec_data.Tables[0].Rows[next].LORD_OF_HOUSE;
       
        }
                        
                           old_execute_categery =exec_data.Tables[0].Rows[next].CATEGERY;
      // old_execute_planet =exec_data.Tables[0].Rows[next].PLANET;
  //     old_execute_trines =exec_data.Tables[0].Rows[next].TRINES;
        
       old_execute_desc =exec_data.Tables[0].Rows[next].DESCRIPTION;        
       old_execute_dedesc =exec_data.Tables[0].Rows[next].DESCCLOB;
        
old_execute_book =exec_data.Tables[0].Rows[next].BOOK;
document.getElementById("book").value=(exec_data.Tables[0].Rows[next].BOOK);
       
       if(document.getElementById("book").value=="null")
      {
          document.getElementById("book").value="";
       }
      else
      {
     document.getElementById("book").value=(exec_data.Tables[0].Rows[next].BOOK);
      }





      old_execute_keystring = exec_data.Tables[0].Rows[next].KEY_STRING;
      document.getElementById("keystring").value = (exec_data.Tables[0].Rows[next].KEY_STRING);

      if (document.getElementById("keystring").value == "null") {
          document.getElementById("keystring").value = "";
      }
      else {
          document.getElementById("keystring").value = (exec_data.Tables[0].Rows[next].KEY_STRING);
      }


  //    document.getElementById("page0").value=(exec_data.Tables[0].Rows[next].PAGE_NO);
       
   //     if(document.getElementById("page0").value=="null")
     //  {
       //    document.getElementById("page0").value="";
     //  }
       //else
   //    {
     // document.getElementById("page0").value=(exec_data.Tables[0].Rows[next].PAGE_NO);
     //  }
      
      document.getElementById("house").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE2);
       document.getElementById("Hidden8").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE2);
      //document.getElementById("planet").value=(exec_data.Tables[0].Rows[next].PLANET);
      
    //  document.getElementById("quardent").value=(exec_data.Tables[0].Rows[next].QUADRENTS);
      // document.getElementById("plant").value=(exec_data.Tables[0].Rows[next].PLANT);
       if(old_execute_astrocat=="Planet")
        {
       //document.getElementById("planet").value=(exec_data.Tables[0].Rows[next].PLANET);
          document.getElementById("Hidden32").value=(exec_data.Tables[0].Rows[next].PLANET);
        }
        else
        {
   //   document.getElementById("DropDownList1").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE);
      document.getElementById("Hidden9").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE);
        } 
      
        document.getElementById("DropDownList2").value=(exec_data.Tables[0].Rows[next].CATEGERY);
        
        document.getElementById("Hidden25").value=(exec_data.Tables[0].Rows[next].CATEGERY);
   //    document.getElementById("trines").value=(exec_data.Tables[0].Rows[next].TRINES);      
     
     
      
      document.getElementById("Textdesc").value=(exec_data.Tables[0].Rows[next].DESCRIPTION); 
        if(document.getElementById("Textdesc").value=="null")
       {
           document.getElementById("Textdesc").value="";
       }
       else
       {
      document.getElementById("Textdesc").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);
       }    
       document.getElementById("Hidden10").value=(exec_data.Tables[0].Rows[next].DESCRIPTION); 
       
       
//         if(document.getElementById('Hidden38').value!="")
//       {
//       
//       
//       
//       if(document.getElementById('Hidden37').value=="1")
//       {
//      var categery= document.getElementById('Hidden38').value.split("$");
//              for(var m=0;m<categery.length-1;m++)
//              {
//              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
//              {
//              gg2++;
//              }
//              }
//      
//       }
//       else
//       {
//       
//              var categery= document.getElementById('Hidden38').value.split("$");
//              for(var m=0;m<categery.length-1;m++)
//              {
//              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
//              {
//              gg2++;
//              }
//              }
//       
//       }
//       
//       if(document.getElementById('Hidden37').value=="1")
//       {
//       if(gg2==categery.length)
//       {
//        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       }
//       else
//       {
//       alert("No Match Found");
//       return false;
//       
//       }
//       }
//       else
//       {
//       if(gg2>0)
//        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//        else
//        {
//       alert("No Match Found");
//       return false;
//        }
//       }
//       
//       }
//       else
//       {
//        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       
//       }
//       
          document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
    
      if(document.getElementById("detaildesc").value=="null")
       {
           document.getElementById("detaildesc").value="";
       }
       else
       {
      document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
       }
         document.getElementById("Hidden11").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
         if(next==total_records-1 )
         {

              $('btnprevious').focus();
                 setButtonImages();      
         }
    
    
    return ;
}



function fnd_pre_record()
{
    delete_record = 0;
      record_show=5
record_show1=1
    next=parseInt(next)-1;
    chk_button(next)
var gg3=0;

//       old_assesy_code =exec_data.Tables[0].Rows[next].ASSESY_CODE;
//       old_assesy_desc =exec_data.Tables[0].Rows[next].ASSESY_DESC;


old_execute_book = exec_data.Tables[0].Rows[next].BOOK;
old_execute_keystring = exec_data.Tables[0].Rows[next].KEY_STRING;
 //               old_execute_page0 =exec_data.Tables[0].Rows[next].PAGE_NO;
        old_execute_house =exec_data.Tables[0].Rows[next].LORD_OF_HOUSE2;  
           
            
       // old_execute_planet =exec_data.Tables[0].Rows[next].PLANET;      
 //       old_execute_quardent =exec_data.Tables[0].Rows[next].QUADRENTS;
//old_execute_plant =exec_data.Tables[0].Rows[next].PLANT;
        if($('astrocat').selectedIndex=="Planet")
        {
        old_execute_planet=exec_data.Tables[0].Rows[next].PLANET;
         
        }
        else
        {
          old_execute_loh =exec_data.Tables[0].Rows[next].LORD_OF_HOUSE;
       
        }

             
              old_execute_astrocat =exec_data.Tables[0].Rows[next].ASTRO_CAT;
              
              old_execute_categery =exec_data.Tables[0].Rows[next].CATEGERY;
//        old_execute_trines =exec_data.Tables[0].Rows[next].TRINES;
        old_execute_desc =exec_data.Tables[0].Rows[next].DESCRIPTION;         
        old_execute_dedesc =exec_data.Tables[0].Rows[next].DESCCLOB;
    
       //document.getElementById("txtassesytypecode").value=repalcestr2quote(exec_data.Tables[0].Rows[next].ASSESY_CODE);
       //document.getElementById("txtassesytypename").value=repalcestr2quote(exec_data.Tables[0].Rows[next].ASSESY_DESC);
            
 //        document.getElementById("page0").value=(exec_data.Tables[0].Rows[next].PAGE_NO);
      
      
//        if(document.getElementById("page0").value=="null")
//       {
//           document.getElementById("page0").value="";
//       }
//       else
//       {
//      document.getElementById("page0").value=(exec_data.Tables[0].Rows[next].PAGE_NO);
//      }
        document.getElementById("book").value=(exec_data.Tables[0].Rows[next].BOOK);
      
        if(document.getElementById("book").value=="null")
       {
           document.getElementById("book").value="";
      }
      else
      {
      document.getElementById("book").value=(exec_data.Tables[0].Rows[next].BOOK);
  }




  document.getElementById("keystring").value = (exec_data.Tables[0].Rows[next].KEY_STRING);

  if (document.getElementById("keystring").value == "null") {
      document.getElementById("keystring").value = "";
  }
  else {
      document.getElementById("keystring").value = (exec_data.Tables[0].Rows[next].KEY_STRING);
  }
       document.getElementById("astrocat").value=(exec_data.Tables[0].Rows[next].ASTRO_CAT);
      document.getElementById("house").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE2);
      
      document.getElementById("Hidden12").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE2);
     // document.getElementById("planet").value=(exec_data.Tables[0].Rows[next].PLANET);
  //    document.getElementById("trines").value=(exec_data.Tables[0].Rows[next].TRINES);      
  //    document.getElementById("quardent").value=(exec_data.Tables[0].Rows[next].QUADRENTS);
     //  document.getElementById("plant").value=(exec_data.Tables[0].Rows[next].PLANT);
     if($('astrocat').selectedIndex==2)
        {
       //document.getElementById("planet").value=(exec_data.Tables[0].Rows[next].PLANET);
          document.getElementById("Hidden33").value=(exec_data.Tables[0].Rows[next].PLANET);
        }
        else
        {
    //  document.getElementById("DropDownList1").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE);
      document.getElementById("Hidden13").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE);
        } 
     
        
        document.getElementById("DropDownList2").value=(exec_data.Tables[0].Rows[next].CATEGERY);
     
      document.getElementById("Hidden26").value=(exec_data.Tables[0].Rows[next].CATEGERY);
        
      document.getElementById("Textdesc").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);   
      
        if(document.getElementById("Textdesc").value=="null")
       {
           document.getElementById("Textdesc").value="";
       }
       else
       {
      document.getElementById("Textdesc").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);
       }
         document.getElementById("Hidden14").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);
         
//           if(document.getElementById('Hidden38').value!="")
//       {
//       
//       
//       
//       if(document.getElementById('Hidden37').value=="1")
//       {
//      var categery= document.getElementById('Hidden38').value.split("$");
//              for(var m=0;m<categery.length-1;m++)
//              {
//              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
//              {
//              gg3++;
//              }
//              }
//      
//       }
//       else
//       {
//       
//              var categery= document.getElementById('Hidden38').value.split("$");
//              for(var m=0;m<categery.length-1;m++)
//              {
//              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
//              {
//              gg3++;
//              }
//              }
//       
//       }
//       
//       if(document.getElementById('Hidden37').value=="1")
//       {
//       if(gg3==categery.length)
//       {
//        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       }
//       else
//       {
//       alert("No Match Found");
//       return false;
//       
//       }
//       }
//       else
//       {
//       if(gg3>0)
//        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//        else
//        {
//       alert("No Match Found");
//       return false;
//        }
//       }
//       
//       }
//       else
//       {
//        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       
//       }
//         
//         
  document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
         if(document.getElementById("detaildesc").value=="null")
       {
           document.getElementById("detaildesc").value="";
       }
       else
       {
      document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
       }
  document.getElementById("Hidden15").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
         if (next==0)
     {
       
            $('btnnext').focus();
            setButtonImages();
     }
    
    
    
    return ;
   
   
}


function fnd_last_record()
{
     delete_record = 0;
     record_show=5
record_show1=1
var gg4=0;
    next=exec_data.Tables[0].Rows.length-1;
    chk_button(next)





    old_execute_book = exec_data.Tables[0].Rows[next].BOOK;
    old_execute_keystring = exec_data.Tables[0].Rows[next].KEY_STRING;
    //           old_execute_page0 =exec_data.Tables[0].Rows[next].PAGE_NO;
        old_execute_house =exec_data.Tables[0].Rows[next].LORD_OF_HOUSE2;  
        old_execute_astrocat =exec_data.Tables[0].Rows[next].ASTRO_CAT;  
        if($('astrocat').selectedIndex=="Planet")
        {
        old_execute_planet=exec_data.Tables[0].Rows[next].PLANET;
         
        }
        else
        {
        old_execute_loh =exec_data.Tables[0].Rows[next].LORD_OF_HOUSE;
       
        }
            
       // old_execute_planet =exec_data.Tables[0].Rows[next].PLANET;      
 //       old_execute_quardent =exec_data.Tables[0].Rows[next].QUADRENTS;
         // old_execute_plant =exec_data.Tables[0].Rows[next].PLANT;
            
            old_execute_categery =exec_data.Tables[0].Rows[next].CATEGERY;
 //        old_execute_trine =exec_data.Tables[0].Rows[next].TRINES;
        
        old_execute_desc =exec_data.Tables[0].Rows[next].DESCRIPTION;         
        old_execute_dedesc =exec_data.Tables[0].Rows[next].DESCCLOB;

       
      
        document.getElementById("book").value=(exec_data.Tables[0].Rows[next].BOOK);
      
        if(document.getElementById("book").value=="null")
       {
          document.getElementById("book").value="";
      }
       else
       {
      document.getElementById("book").value=(exec_data.Tables[0].Rows[next].BOOK);
  }


  document.getElementById("keystring").value = (exec_data.Tables[0].Rows[next].KEY_STRING);

  if (document.getElementById("keystring").value == "null") {
      document.getElementById("keystring").value = "";
  }
  else {
      document.getElementById("keystring").value = (exec_data.Tables[0].Rows[next].KEY_STRING);
  }
       
  //      document.getElementById("page0").value=(exec_data.Tables[0].Rows[next].PAGE_NO);
      
  //      if(document.getElementById("page0").value=="null")
   //    {
   //        document.getElementById("page0").value="";
   //    }
   //    else
   //    {
   //   document.getElementById("page0").value=(exec_data.Tables[0].Rows[next].PAGE_NO);
   //    }
   document.getElementById("astrocat").value=(exec_data.Tables[0].Rows[next].ASTRO_CAT);
      document.getElementById("house").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE2);
         document.getElementById("Hidden16").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE2);
     // document.getElementById("planet").value=(exec_data.Tables[0].Rows[next].PLANET);
   //   document.getElementById("trines").value=(exec_data.Tables[0].Rows[next].TRINES);
    //      document.getElementById("quardent").value=(exec_data.Tables[0].Rows[next].QUADRENTS);
       //      document.getElementById("plant").value=(exec_data.Tables[0].Rows[next].PLANT);
        if($('astrocat').selectedIndex==2)
        {
      // document.getElementById("planet").value=(exec_data.Tables[0].Rows[next].PLANET);
          document.getElementById("Hidden34").value=(exec_data.Tables[0].Rows[next].PLANET);
        }
        else
        {
    //   document.getElementById("DropDownList1").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE);
     document.getElementById("Hidden17").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE);
        } 
               
                document.getElementById("DropDownList2").value=(exec_data.Tables[0].Rows[next].CATEGERY);
     
     document.getElementById("Hidden27").value=(exec_data.Tables[0].Rows[next].CATEGERY);
      
      document.getElementById("Textdesc").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);    
        if(document.getElementById("Textdesc").value=="null")
       {
           document.getElementById("Textdesc").value="";
       }
       else
       {
      document.getElementById("Textdesc").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);
       } 
       document.getElementById("Hidden18").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);
       
       
//         if(document.getElementById('Hidden38').value!="")
//       {
//       
//       
//       
//       if(document.getElementById('Hidden37').value=="1")
//       {
//      var categery= document.getElementById('Hidden38').value.split("$");
//              for(var m=0;m<categery.length-1;m++)
//              {
//              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
//              {
//              gg4++;
//              }
//              }
//      
//       }
//       else
//       {
//       
//              var categery= document.getElementById('Hidden38').value.split("$");
//              for(var m=0;m<categery.length-1;m++)
//              {
//              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
//              {
//              gg4++;
//              }
//              }
//       
//       }
//       
//       if(document.getElementById('Hidden37').value=="1")
//       {
//       if(gg4==categery.length)
//       {
//        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       }
//       else
//       {
//       alert("No Match Found");
//       return false;
//       
//       }
//       }
//       else
//       {
//       if(gg4>0)
//        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//        else
//        {
//       alert("No Match Found");
//       return false;
//        }
//       }
//       
//       }
//       else
//       {
//        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       
//       }
//       
       document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
      if(document.getElementById("detaildesc").value=="null")
       {
           document.getElementById("detaildesc").value="";
       }
       else
       {
      document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
       }
       document.getElementById("Hidden19").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
    return ;
}


//function d1chart() {
//    var planet = document.getElementById('planet').value;
//    var house = document.getElementById('house').value;
//    var ldeg = document.getElementById('ldegree').value;
//    var pdeg = document.getElementById('pdegree').value;
//    var res = planet_aspect.donechart(planet, house, ldeg, pdeg);

//}

//function d9chart() {

//    var planet = document.getElementById('planet').value;
//    var house = document.getElementById('house').value;
//    var ldeg = document.getElementById('ldegree').value;
//    var pdeg = document.getElementById('pdegree').value;
//    var res = planet_aspect.dninechart(planet, house, ldeg, pdeg);

//}



