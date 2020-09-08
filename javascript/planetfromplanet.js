var querytype="";
var val="";
var planetfromplanet="";
var exec_data="";
var next=0;
var execute="";
var Modify=0;
var delete_record=0;

function EnableOnNew()
{
document.getElementById("Hidden10").value =0
   
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
    
        
          document.getElementById('planet').disabled = false;
          document.getElementById('house').disabled = false;        
          document.getElementById('description').disabled=false;
          document.getElementById('book').disabled = false;
          document.getElementById('keystring').disabled = false; 
          document.getElementById('planet1').disabled=false; 
          document.getElementById('detail').disabled=false; 
        
         

 setButtonImages();
          
    
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
     
          document.getElementById('planet').disabled = true;
          document.getElementById('house').disabled = true;
          document.getElementById('book').disabled = true;
          document.getElementById('keystring').disabled = true;      
              document.getElementById('planet1').disabled = true;        
          document.getElementById('description').disabled=true; 
          document.getElementById('detail').disabled=true; 
                           
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
         $('div1').style.display='none';
        $('planet').disabled= true;
        $('book').disabled = true;
        $('keystring').disabled = true;
        $('planet1').disabled= true;
        $('house').disabled= true;
        $('description').disabled= true;
         $('detail').disabled= true;
        
       
      if($('book').value!="")
      { 
      $('book').value="";
  }

  if ($('keystring').value != "") 
  {
      $('keystring').value = "";
  }
      if($('house').value!="")
      { 
      $('house').value="";
      }
         if($('planet').value!="")
      { 
      $('planet').value="";
      }
      
      if($('description').value!="")
      { 
      $('description').value="";
      }
      
      if($('detail').value!="")
      { 
      $('detail').value="";
      }
      
      if($('planet1').value!="")
      { 
      $('planet1').value="";
      }
      
    setButtonImages();
     return false;
   }
   
   
  function Exit()
{
       if(confirm("Do You want to skip the page?"))
       {
         window.close();
         return false;
   }
}



  function save_records()

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


        var planet = "'" + (document.getElementById('planet').value) + "'";
        var caseplanet = planet;
       
        var house = "'" + (document.getElementById('house').value) + "'";
       var casehouse = house;
       
           var book = "'" + (document.getElementById('book').value) + "'";
           var casebook = book;

           var keystring = "'" + (document.getElementById('keystring').value) + "'";
           var casekeystring = keystring;
       
           var planet1 = "'" + (document.getElementById('planet1').value) + "'";
       var caseplanet1 = planet1;
        
        var description = "'" + (document.getElementById('description').value) + "'";
        var casedescription = description;
        
          
        var detail = "'" + (document.getElementById('detail').value) + "'";
        var casedetail = detail;
        
        
        
       if(Modify == 1)
    {
      ModifyClass();
        
      return false;
    }
        
        
        
        
         caseplanet=caseplanet.replace("'","");
        caseplanet=caseplanet.replace("'","");
        casehouse=casehouse.replace("'","");
        casehouse=casehouse.replace("'","");
        caseplanet1=caseplanet1.replace("'","");
        caseplanet1=caseplanet1.replace("'","");
        casedescription=casedescription.replace("'","");
        casedescription=casedescription.replace("'","");
        casedetail=casedetail.replace("'","");
        casedetail=casedetail.replace("'","");
        casebook=casebook.replace("'","");
        casebook = casebook.replace("'", "");
        casekeystring = casekeystring.replace("'", "");
        casekeystring = casekeystring.replace("'", "");






        var tablevalue = caseplanet + "$~$" + casehouse + "$~$" + caseplanet1 + "$~$" + casebook + "$~$" + casedescription + "$~$" + casedetail + "$~$" + casekeystring + "$~$";
         var fi = document.getElementById('tblfields').value.replace("$~$" + tablename, "")
         fi = fi.replace("$~$" + action, "")
         var dateformate = document.getElementById('hiddendateformat').value
        
        
        
        var result=planetfromplanet.save(caseplanet,casehouse,caseplanet1,casebook,casedescription,casedetail,casekeystring)
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
   function modifydata()
{

Modify=1;
     
      document.getElementById("Hidden10").value =1

      var modifyduplicacyalias = $('book').value;
      var modifyduplicacyalias = $('keystring').value; 
          var   modifyduplicacydesc=$('house').value;
         var    modifyduplicacyalias=$('planet').value;   
         var    modifyduplicacyalias=$('planet1').value; 
         var    modifyduplicacyalias=$('description').value;             
         var  modifyduplicacyalias=$('detail').value;


         document.getElementById("book").disabled = false;
         document.getElementById("keystring").disabled = false;
    document.getElementById("house").disabled=false;
    document.getElementById("planet").disabled=false;
    document.getElementById("planet1").disabled=false;
    document.getElementById("description").disabled=false;
    document.getElementById("detail").disabled=false;
   
  
   
   
    
  
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

       

        var planet = "'" + (document.getElementById('planet').value) + "'";
        var caseplanet = planet;
       
        var house = "'" + (document.getElementById('house').value) + "'";
        var casehouse = house;
        
        var book = "'" + (document.getElementById('book').value) + "'";
        var casebook = book;

        var keystring = "'" + (document.getElementById('keystring').value) + "'";
        var casekeystring = keystring;
        
        var planet1 = "'" + (document.getElementById('planet1').value) + "'";
        var caseplanet1 = planet1;
        
        var description = "'" + (document.getElementById('description').value) + "'";
        var casedescription = description;
        
         var detail = "'" + (document.getElementById('detail').value) + "'";
        var casedetail= detail
        
        
        
         
        
        
        
        
    
    
    
     var fi = document.getElementById('tblfields').value.replace("$~$" + tablename, "")
        fi = fi.replace("$~$" + action, "")
        fi=fi+"$~$"
        
        
        var concolname="PLANET"+"$~$"+"HOUSE"+"$~$"+"FROM_PLANET"+"$~$";
        var dateformate = document.getElementById('hiddendateformat').value

        var tablevalue = caseplanet + "$~$" + casehouse + "$~$" + caseplanet1 + "$~$" + casebook + "$~$" + casedescription + "$~$" + casedetail + "$~$" + casekeystring + "$~$";
    var res=planetfromplanet.Modify_data(tablename,fi,tablevalue,concolname,dateformate,"","",callbackeex)
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
    
    
    
    
     document.getElementById("book").disabled=false;
    document.getElementById("planet").disabled=false;
    document.getElementById("house").disabled=false;
    document.getElementById("planet1").disabled=false;
    document.getElementById("description").disabled=false;
    document.getElementById("detail").disabled=false;
      
document.getElementById('house').style.display='block';
document.getElementById('planet').style.display='block';
document.getElementById('planet1').style.display='block';
document.getElementById('book').style.display = 'block';
document.getElementById('keystring').style.display = 'block';
document.getElementById('description').style.display='block';
document.getElementById('detail').style.display='block';
      
        
    
        
    document.getElementById("btnExecute").focus(); 
    
    delete_record = 0; 
 
     setButtonImages();
    return false;

}


function disabledexecfld()
{
   
    next=0;
    exec_data="";
    
    srt_count = 0;
    record_show1=1 ;
    
     
     document.getElementById("planet").disabled=true;
   document.getElementById("planet1").disabled=true;
   document.getElementById("book").disabled = true;
   document.getElementById("keystring").disabled = true;
   document.getElementById("house").disabled=true;
   document.getElementById("description").disabled=true;
   document.getElementById("detail").disabled=true;
       
     
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
    
    
    



    
   document.getElementById("planet").value=""
   document.getElementById("planet1").value=""
   document.getElementById("house").value=""
   document.getElementById("book").value = ""
   document.getElementById("keystring").value = ""
   document.getElementById("description").value=""
   document.getElementById("detail").value=""
    
   modify="false";
    
    
    
        
    
    delete_record = 0;
    
      setButtonImages();
    return false;
}



function executequery(querytype)

{

 document.getElementById("btnDelete").disabled=false;
       var house="";
       var planet1="";
       var planet="";
       var book="";
       var description="";
       var detail="";







       var book = "'" + document.getElementById("book").value + "'"
       var keystring = "'" + document.getElementById("keystring").value + "'"        
       var detail="'"+document.getElementById("detail").value+"'" 
       var description="'"+document.getElementById("description").value+"'"           
                   
      if(document.getElementById("house").value!=0)
        {
          house="'"+document.getElementById("house").value+"'"
        }
        else
        
        {
        house="'"+house+"'"
        }
        
         if(document.getElementById("planet").value!=0)
        {
          planet="'"+document.getElementById("planet").value+"'"
        }
        else
        
        {
        planet="'"+planet+"'"
        }
        
        if(document.getElementById("planet1").value!=0)
        {
          planet1="'"+document.getElementById("planet1").value+"'"
        }
        else
      
        {
        planet1="'"+planet1+"'"
        }
    
      var userid="'"+document.getElementById("hdnuserid").value+"'"
      var userid="''";

      document.getElementById("btnfirst").disabled=false;



      var fieldsvalue = planet + "$~$" + house + "$~$" + planet1 + "$~$" + book + "$~$" + description + "$~$" + detail + "$~$" + keystring + "$~$"    

 
  



  
   
   var SPLITVALUE=document.getElementById('fields').value.split("$~$")
   var fields=document.getElementById('fields').value.replace("$~$"+SPLITVALUE[SPLITVALUE.length-2],"").replace("$~$"+SPLITVALUE[SPLITVALUE.length-1],"")
    
     exectefuncol=fields;
     exectefunvalue=fieldsvalue;
     exectefuntab=SPLITVALUE[SPLITVALUE.length-2];
     old_exec_value=fieldsvalue;
     fields = fields+"$~$"
     
    
    var res1=planetfromplanet.execute(SPLITVALUE[SPLITVALUE.length-2],fields,fieldsvalue,"select",$('hiddendateformat').value,"","");
  execute_callback(res1);

  return ;
}





function execute_callback(val)
{
var degreet="";
record_show=10
record_show1=1

exec_data=val.value;
     var gg=0;
    
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
      
        document.getElementById("planet").value=(exec_data.Tables[0].Rows[next].PLANET);
      
        document.getElementById("house").value=(exec_data.Tables[0].Rows[next].HOUSE);
        
        document.getElementById("planet1").value=(exec_data.Tables[0].Rows[next].FROM_PLANET);
                
        document.getElementById("description").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);
               
          if(document.getElementById("description").value=="null")
       {
           document.getElementById("description").value="";
       }
       else
       {
      document.getElementById("description").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);
    
       }
       
       
//        if(document.getElementById('Hidden12').value!="")
//       {
//       
//       
//       
//       if(document.getElementById('Hidden11').value=="1")
//       {
//      var categery= document.getElementById('Hidden12').value.split("$");
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
//              var categery= document.getElementById('Hidden12').value.split("$");
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
//       if(document.getElementById('Hidden11').value=="1")
//       {
//       if(gg==categery.length)
//       {
//        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       }
//       else
//       {
//       alert("No Match Found");
//         $('btnfirst').disabled = true;
//	$('btnlast').disabled = false;
//	$('btnprevious').disabled = true;
//	$('btnnext').disabled = false;
//       return false;
//       
//       }
//       }
//       else
//       {
//       if(gg>0)
//        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
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
//        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       
//       }
//       
        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
       
        
       
          if(document.getElementById("detail").value=="null")
       {
           document.getElementById("detail").value="";
       }
       else
       {
      document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
       }


       old_execute_book = exec_data.Tables[0].Rows[next].BOOK;
       old_execute_keystring = exec_data.Tables[0].Rows[next].KEY_STRING;
       old_execute_planet =exec_data.Tables[0].Rows[next].PLANET;
        document.getElementById("Hidden1").value =exec_data.Tables[0].Rows[next].PLANET;
       old_execute_house =exec_data.Tables[0].Rows[next].HOUSE;
       document.getElementById("Hidden2").value =exec_data.Tables[0].Rows[next].HOUSE;
       old_execute_fromplanet=exec_data.Tables[0].Rows[next].FROM_PLANET;
       document.getElementById("Hidden3").value =exec_data.Tables[0].Rows[next].FROM_PLANET;
       old_execute_description=exec_data.Tables[0].Rows[next].DESCRIPTION; 
       document.getElementById("Hidden4").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);
       old_execute_detail  =exec_data.Tables[0].Rows[next].DESCCLOB;     
     document.getElementById("Hidden5").value=(exec_data.Tables[0].Rows[next].DESCCLOB);     
       
       document.getElementById("btnModify").disabled=false;
       document.getElementById("planet").disabled=true;
       document.getElementById("house").disabled=true;
       document.getElementById("planet1").disabled=true;
       document.getElementById("book").disabled = true;
       document.getElementById("keystring").disabled = true;
       document.getElementById("description").disabled=true;
       document.getElementById("detail").disabled=true;
       
      
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
	 
	 setButtonImages();
     
        return false;
    }
}


function delete_data()
{ 
       var house="'"+document.getElementById("house").value+"'"
       var planet="'"+document.getElementById("planet").value+"'"
       var planet1="'"+document.getElementById("planet1").value+"'"
       var book = "'" + document.getElementById("book").value + "'"
       var book = "'" + document.getElementById("keystring").value + "'"
       var description="'"+document.getElementById("description").value+"'"
       var detail="'"+document.getElementById("detail").value+"'"
       if(confirm("Are you sure! Do you want to delete this entry?"))
     {
       var fieldsvalue=house+"$~$"+planet+"$~$"+planet1;
       var SPLITVALUE=document.getElementById('fields').value.split("$~$")
         
       var fields1="HOUSE"+"$~$"+"PLANET"+"$~$"+"FROM_PLANET";
        
   
               var tablename="PLANETFROMPLANET";
               
              var extra1="''";
              var extra2="''";
             
              var res=planetfromplanet.deletep(tablename,fields1,fieldsvalue,document.getElementById('hiddendateformat').value,extra1,extra2)
            
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
 
 function chk_button(a)
{
var book="''";
var house="''";
var descrption="''";
var detail="''";
var planet="''";
var planet1 = "''";
var keystring = "''";

var fieldsvalue = house + "$~$" + descrption + "$~$" + detail + "$~$" + book + "$~$" + planet + "$~$" + planet1 + "$~$" + keystring + "$~$"    
    



  
   
   var SPLITVALUE=document.getElementById('fields').value.split("$~$")
      var fields=document.getElementById('fields').value.replace("$~$"+SPLITVALUE[SPLITVALUE.length-2],"").replace("$~$"+SPLITVALUE[SPLITVALUE.length-1],"")
    
     exectefuncol=fields;
     exectefunvalue=fieldsvalue;
     exectefuntab=SPLITVALUE[SPLITVALUE.length-2];
    old_exec_value=fieldsvalue;
      fields = fields+"$~$"
     
    
    var res1=planetfromplanet.execute(SPLITVALUE[SPLITVALUE.length-2],fields,fieldsvalue,"select",$('hiddendateformat').value,"","");
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

function fnd_first_record()
{
      delete_record = 0;
      record_show=5
      record_show1=1

       next="0";
       chk_button(next)
var gg1=0;

old_execute_book = exec_data.Tables[0].Rows[next].BOOK;
old_execute_keystring = exec_data.Tables[0].Rows[next].KEY_STRING;
       old_execute_planet =exec_data.Tables[0].Rows[next].PLANET;
       old_execute_house =exec_data.Tables[0].Rows[next].HOUSE;
       old_execute_fromplanet =exec_data.Tables[0].Rows[next].FROM_PLANET;
       old_execute_desc =exec_data.Tables[0].Rows[next].DESCRIPTION;       
       old_execute_detail =exec_data.Tables[0].Rows[next].DESCCLOB;
        

      
        
        
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
  
   document.getElementById("planet").value=(exec_data.Tables[0].Rows[next].PLANET);
   document.getElementById("house").value=(exec_data.Tables[0].Rows[next].HOUSE);
   document.getElementById("Hidden7").value=(exec_data.Tables[0].Rows[next].HOUSE);
        
   
    document.getElementById("planet1").value=(exec_data.Tables[0].Rows[next].FROM_PLANET);
    document.getElementById("description").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);  
    if(document.getElementById("description").value=="null")
       {
           document.getElementById("description").value="";
       }
       else
       {
      document.getElementById("description").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);
       }
       
       
       
       
//         if(document.getElementById('Hidden12').value!="")
//       {
//       
//       
//       
//       if(document.getElementById('Hidden11').value=="1")
//       {
//      var categery= document.getElementById('Hidden12').value.split("$");
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
//              var categery= document.getElementById('Hidden12').value.split("$");
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
//       if(document.getElementById('Hidden11').value=="1")
//       {
//       if(gg1==categery.length)
//       {
//        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       }
//       else
//       {
//       alert("No Match Found");
//         $('btnfirst').disabled = true;
//	$('btnlast').disabled = false;
//	$('btnprevious').disabled = true;
//	$('btnnext').disabled = false;
//       return false;
//       
//       }
//       }
//       else
//       {
//       if(gg1>0)
//        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
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
//        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       
//       }
       
       document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
       
        if(document.getElementById("detail").value=="null")
       {
           document.getElementById("detail").value="";
       }
       else
       {
      document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
       }
 return ;
}


function fnd_next_record()
{
    delete_record = 0;
    record_show=8
    record_show1=1
    next=parseInt(next)+1;
    chk_button(next) 
var gg2=0;





old_execute_book = exec_data.Tables[0].Rows[next].BOOK;
old_execute_keystring = exec_data.Tables[0].Rows[next].KEY_STRING;
         old_execute_house =exec_data.Tables[0].Rows[next].HOUSE;
         old_execute_planet =exec_data.Tables[0].Rows[next].PLANET;
         old_execute_fromplanet =exec_data.Tables[0].Rows[next].FROM_PLANET;
         old_execute_description =exec_data.Tables[0].Rows[next].DESCRIPTION;
         old_execute_detail =exec_data.Tables[0].Rows[next].DESCCLOB;
      

     
      
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
      
      
    document.getElementById("house").value=(exec_data.Tables[0].Rows[next].HOUSE);
    document.getElementById("Hidden6").value=(exec_data.Tables[0].Rows[next].HOUSE);
    
    document.getElementById("planet").value=(exec_data.Tables[0].Rows[next].PLANET);
      
    document.getElementById("planet1").value=(exec_data.Tables[0].Rows[next].FROM_PLANET);
    document.getElementById("description").value=(exec_data.Tables[0].Rows[next].DESCRIPTION); 
        if(document.getElementById("description").value=="null")
       {
           document.getElementById("description").value="";
       }
       else
       {
      document.getElementById("description").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);
       }    
      
      
      
      
//        if(document.getElementById('Hidden12').value!="")
//       {
//       
//       
//       
//       if(document.getElementById('Hidden11').value=="1")
//       {
//      var categery= document.getElementById('Hidden12').value.split("$");
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
//              var categery= document.getElementById('Hidden12').value.split("$");
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
//       if(document.getElementById('Hidden11').value=="1")
//       {
//       if(gg2==categery.length)
//       {
//        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       }
//       else
//       {
//       alert("No Match Found");
//         $('btnfirst').disabled = true;
//	$('btnlast').disabled = false;
//	$('btnprevious').disabled = true;
//	$('btnnext').disabled = false;
//       return false;
//       
//       }
//       }
//       else
//       {
//       if(gg2>0)
//        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
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
//        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       
//       }
         document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
      
      if(document.getElementById("detail").value=="null")
       {
           document.getElementById("detail").value="";
       }
       else
       {
      document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
       }
         
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



old_execute_book = exec_data.Tables[0].Rows[next].BOOK;
old_execute_keystring = exec_data.Tables[0].Rows[next].KEY_STRING;
        old_execute_planet =exec_data.Tables[0].Rows[next].PLANET;
        old_execute_house =exec_data.Tables[0].Rows[next].HOUSE;  
        old_execute_planet1 =exec_data.Tables[0].Rows[next].FROM_PLANET;      
        old_execute_description =exec_data.Tables[0].Rows[next].DESCRIPTION;         
        old_execute_detail =exec_data.Tables[0].Rows[next].DESCCLOB;
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
       
       
       document.getElementById("planet").value=(exec_data.Tables[0].Rows[next].PLANET);
      document.getElementById("house").value=(exec_data.Tables[0].Rows[next].HOUSE);
         document.getElementById("Hidden8").value=(exec_data.Tables[0].Rows[next].HOUSE);
      
     
      document.getElementById("planet1").value=(exec_data.Tables[0].Rows[next].FROM_PLANET);
      document.getElementById("description").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);   
      
        if(document.getElementById("description").value=="null")
       {
           document.getElementById("description").value="";
       }
       else
       {
      document.getElementById("description").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);
       }
       
       
       
//         if(document.getElementById('Hidden12').value!="")
//       {
//       
//       
//       
//       if(document.getElementById('Hidden11').value=="1")
//       {
//      var categery= document.getElementById('Hidden12').value.split("$");
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
//              var categery= document.getElementById('Hidden12').value.split("$");
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
//       if(document.getElementById('Hidden11').value=="1")
//       {
//       if(gg3==categery.length)
//       {
//        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       }
//       else
//       {
//       alert("No Match Found");
//         $('btnfirst').disabled = true;
//	$('btnlast').disabled = false;
//	$('btnprevious').disabled = true;
//	$('btnnext').disabled = false;
//       return false;
//       
//       }
//       }
//       else
//       {
//       if(gg3>0)
//        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
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
//        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       
//       }
       
          document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
      
         if(document.getElementById("detail").value=="null")
       {
           document.getElementById("detail").value="";
       }
       else
       {
      document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
       }
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

    next=exec_data.Tables[0].Rows.length-1;
    chk_button(next)
var gg4=0;




old_execute_book = exec_data.Tables[0].Rows[next].BOOK;
old_execute_keystring = exec_data.Tables[0].Rows[next].KEY_STRING;
             old_execute_planet =exec_data.Tables[0].Rows[next].PLANET;
        old_execute_house =exec_data.Tables[0].Rows[next].HOUSE;  
        old_execute_planet1 =exec_data.Tables[0].Rows[next].FROM_PLANET;  
        old_execute_description =exec_data.Tables[0].Rows[next].DESCRIPTION;         
        old_execute_detail =exec_data.Tables[0].Rows[next].DESCCLOB;

       
      
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
       
       
       
   document.getElementById("planet").value=(exec_data.Tables[0].Rows[next].PLANET);
   document.getElementById("house").value=(exec_data.Tables[0].Rows[next].HOUSE);
   document.getElementById("Hidden9").value=(exec_data.Tables[0].Rows[next].HOUSE);
   
   document.getElementById("planet1").value=(exec_data.Tables[0].Rows[next].FROM_PLANET);
      
      document.getElementById("description").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);    
        if(document.getElementById("description").value=="null")
       {
           document.getElementById("description").value="";
       }
       else
       {
      document.getElementById("description").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);
       } 
       
       
       
       
//         if(document.getElementById('Hidden12').value!="")
//       {
//       
//       
//       
//       if(document.getElementById('Hidden11').value=="1")
//       {
//      var categery= document.getElementById('Hidden12').value.split("$");
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
//              var categery= document.getElementById('Hidden12').value.split("$");
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
//       if(document.getElementById('Hidden11').value=="1")
//       {
//       if(gg4==categery.length)
//       {
//        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       }
//       else
//       {
//       alert("No Match Found");
//         $('btnfirst').disabled = true;
//	$('btnlast').disabled = false;
//	$('btnprevious').disabled = true;
//	$('btnnext').disabled = false;
//       return false;
//       
//       }
//       }
//       else
//       {
//       if(gg4>0)
//        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
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
//        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       
//       }
       
        document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
      
      if(document.getElementById("detail").value=="null")
       {
           document.getElementById("detail").value="";
       }
       else
       {
      document.getElementById("detail").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
       }
       
    return ; 
}

