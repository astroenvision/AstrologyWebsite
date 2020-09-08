
var querytype="";
var val="";
//var Drphouse="";
//var Drprashi="";
//var  Drpplanet="";
var Houseposition="";
var exec_data="";
var next=0;
var execute="";
var exec_data1="";
var Modify=0;
var delete_record=0;
var buf1 = new StringBuffer();
function StringBuffer() {
    this.buffer = [];
}

StringBuffer.prototype.append = function append(string) {
    this.buffer.push(string);
    return this;
};

function ShowPreview()
{
    var ht="";
    var wt="";
    var jobid= document.getElementById('hiddenjobid').value;
 
     for(var t1=0; t1<document.getElementById('ListBox1').options.length; t1++)
    {
       if(document.getElementById("ListBox1").options[t1].selected == true)
       {
           
            
              var fname =document.getElementById("ListBox1").options[t1].innerText;
           
             
                window.open('preview.aspx?jobid='+jobid+'&f_name='+fname,'Preview','status=0,toolbar=0,resizable=0,scrollbars=yes,modal=yes,top=0,left=0,width=800px,height=1000px');
           
              return false; 
                        
       }
    } 
}
	function EnableOnNew()
{grid();
//enabelgrid();
   
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
    
        
          document.getElementById('Textcode').disabled = false;
          
          document.getElementById('Textname').disabled = false;        
          document.getElementById('Textdesc').disabled=false; 
           document.getElementById('book').disabled=false; 
            document.getElementById('page0').disabled=false; 
          document.getElementById('Textpdegree').disabled=false; 
        
          document.getElementById('Drphouse').disabled=false; 
          document.getElementById('loh').disabled = false;
          document.getElementById('Drprashi').disabled=false; 
          document.getElementById('Drpplanet').disabled=false; 
          document.getElementById('detaildesc').disabled=false; 
          document.getElementById('ascendentbox').disabled=false; 
          document.getElementById('constellationbox').disabled=false;
          document.getElementById('degreefrom').disabled = false;
          document.getElementById('keystring').disabled = false; 
          document.getElementById('degreeto').disabled=false; 
            document.getElementById('chart').disabled=false; 
            document.getElementById('accepting').disabled=false; 
           // document.getElementById('DropDownList1').disabled=false;  
          
          
         //document.getElementById('Button4').disabled=true; 
//          thsi is for view is show or not 
           // $('Button4').style.display ='none';
             
//new_button("New")

 setButtonImages();
          
                   
       //new_button("New");
          
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
     
          document.getElementById('Textcode').disabled = true;
          document.getElementById('Textname').disabled = true;      
            document.getElementById('book').disabled = true;      
              document.getElementById('page0').disabled = true;        
          document.getElementById('Textdesc').disabled=true; 
          document.getElementById('Textpdegree').disabled=true; 
           document.getElementById('ascendentbox').disabled=true; 
             document.getElementById('loh').disabled=true; 
          document.getElementById('constellationbox').disabled=true;
          document.getElementById('degreefrom').disabled = true;
          document.getElementById('keystring').disabled = true; 
          document.getElementById('degreeto').disabled=true; 
            document.getElementById('chart').disabled=true; 
        
          document.getElementById('Drphouse').disabled=true; 
          document.getElementById('Drprashi').disabled=true; 
          document.getElementById('Drpplanet').disabled=true;
           document.getElementById('accepting').disabled=true; 
      //    document.getElementById('DropDownList1').disabled=true; 
          
//          this is for detail desc
          document.getElementById('detaildesc').disabled=true; 
         // $('Button4').style.display ='none';
                 
          return false;
   }



function Save_Records()

      {
//******************** change for modify
//if(Modify == 1)
    //{
      //  ModifyClass();
        
      //  return false;
    //}
    //else
   // {
//**********************************
        var str = document.getElementById('tblfields').value;
        var str1 = str.split("$~$");
        var tablename = str1[str1.length - 2];

        var action = str1[str1.length - 1];
        var finalaction = action.split("#");
        var insert = finalaction[0];
        var update = finalaction[1];
        var del = finalaction[2];
        var select = finalaction[3];

//        if (document.getElementById('Textname').value == "") 
//        {
//            alert("Please fill text Name")
//            document.getElementById('Textname').focus();
//            return false;
//        }

//        if (document.getElementById('Drphouse').value== "0" || document.getElementById('Drphouse').value== "") 
//        {
//            alert("Please select house")
//            document.getElementById('Drphouse').focus();
//            return false;
//        }
        
        
//         if (document.getElementById('Drpplanet').value == "0" || document.getElementById('Drpplanet').value == "")
//         {
//            alert(" Please Enter planet")
//            document.getElementById('Drpplanet').focus();
//            return false;
//        }
        
        
//        if (document.getElementById('Drprashi').value == "0"|| document.getElementById('Drprashi').value == "") 
//        {
//            alert("Please Enter  Rashi")
//            document.getElementById('Drprashi').focus();
//            return false;
//        }
//        
//        
//        if (document.getElementById('Textpdegree').value == "")
//         {
//            alert("please enter Planetdegree")
//            document.getElementById('Textpdegree').focus();
//            return false;
//        }

        
       
//        if (document.getElementById('Textdesc').value == "")
//         {
//            alert("Please fill Description")
//            document.getElementById('Textdesc').focus();
//            return false;
//        }

//        
//        if (document.getElementById('detaildesc').value == "")
//         {
//            alert("Please fill Descripation in detail")
//            document.getElementById('detaildesc').focus();
//            return false;
//        }
        

       
       

        var code = "'" + (document.getElementById('Textcode').value) + "'";
        var casecode = code;
       
        var name = "'" + (document.getElementById('Textname').value) + "'";
       var casename = name;
       
           var book = "'" + (document.getElementById('book').value) + "'";
       var casebook = book;
       
           var page0 = "'" + (document.getElementById('page0').value) + "'";
       var casepage0 = page0;

       var keystring = "'" + (document.getElementById('keystring').value) + "'";
       var casekeystring = keystring;
        
        var house = "'" + (document.getElementById('Drphouse').value) + "'";
        var casehouse = house;
        
          
        var loh = "'" + (document.getElementById('loh').value) + "'";
        var caseloh = loh;
        
        
        
         var planet = "'" + (document.getElementById('Drpplanet').value) + "'";
        var caseplanet = planet;
        
        
        var rashi = "'" + (document.getElementById('Drprashi').value) + "'";
        var caserashi = rashi;
        
        
                
        var degree = "'" + (document.getElementById('Textpdegree').value) + "'";
        var casedegree= degree;
         
        
        
        
        var description = "'" + (document.getElementById('Textdesc').value) + "'";
        var casedescription= description;
        

       
       

        var dedesc = "'" + (document.getElementById('detaildesc').value) + "'";
       var caseplanet = dedesc;
        var desc = "''";
        
          var ascendent = "'" + (document.getElementById('ascendentbox').value) + "'";
        var caseascendent = ascendent;
        
        var constellation = "'" + (document.getElementById('constellationbox').value) + "'";
        var caseconstellation = constellation;
        
        var degreefrom = "'" + (document.getElementById('degreefrom').value) + "'";
        var casedegreefrom = degreefrom;
        
        var degreeto = "'" + (document.getElementById('degreeto').value) + "'";
        var casedegreeto= degreeto;
        
        var chart = "'" + (document.getElementById('chart').value) + "'";
        var casechart= chart;
        
        var aspecting = "'" + (document.getElementById('accepting').value) + "'";
        var caseaspecting= aspecting;
        
//         var aspectinghouse = "'" + (document.getElementById('DropDownList1').value) + "'";
//        var caseaspectinghouse= aspectinghouse;
if(Modify == 1)
    {
    
      ModifyClass();
        
      return false;
    }
        
        
        
        
         casename=casename.replace("'","");
        casename=casename.replace("'","");
        casehouse=casehouse.replace("'","");
        casehouse=casehouse.replace("'","");
        planet=planet.replace("'","");
        planet=planet.replace("'","");
        caserashi=caserashi.replace("'","");
        caserashi=caserashi.replace("'","");
        casedegree=casedegree.replace("'","");
        casedegree=casedegree.replace("'","");
        casedescription=casedescription.replace("'","");
        casedescription=casedescription.replace("'","");
        caseplanet=caseplanet.replace("'","");
        caseplanet=caseplanet.replace("'","");
        caseascendent=caseascendent.replace("'","");
        caseascendent=caseascendent.replace("'","");
        caseconstellation=caseconstellation.replace("'","");
        caseconstellation=caseconstellation.replace("'","");
       casedegreefrom=casedegreefrom.replace("'","");
       casedegreefrom=casedegreefrom.replace("'","");
        casedegreeto=casedegreeto.replace("'","");
        casedegreeto=casedegreeto.replace("'","");
        casechart=casechart.replace("'","");
        casechart=casechart.replace("'","");
        caseaspecting=caseaspecting.replace("'","");
       caseaspecting=caseaspecting.replace("'","");
       // caseaspectinghouse=caseaspectinghouse.replace("'","");
      // caseaspectinghouse=caseaspectinghouse.replace("'","");
        casebook=casebook.replace("'","");
       casebook=casebook.replace("'","");
        casepage0=casepage0.replace("'","");
        casepage0 = casepage0.replace("'", "");
        casekeystring = casekeystring.replace("'", "");
        casekeystring = casekeystring.replace("'", "");
        caseloh=caseloh.replace("'","");
       caseloh=caseloh.replace("'","");
        
        
        
        var gencode=Houseposition.genastcode(casehouse,caserashi,planet,casedegree,caseascendent,caseconstellation,casedegreefrom,casedegreeto,casechart,caseaspecting,caseloh);
          casecode=gencode.value.Tables[0].Rows[0].AUTOG;             
       //COMP_CODE$~$       UNIT_CODE$~$      PUBL_CODE$~$  MAIN_EDTN$~$     EDTN_CODE$~$    SUPL_NAME_SUN$~$  SUPL_ONAME_SUN$~$SUPL_NAME_MON$~$   SUPL_ONAME_MON$~$   SUPL_NAME_TUE$~$  SUPL_ONAME_TUE$~$SUPL_NAME_WED$~$SUPL_ONAME_WED$~$SUPL_NAME_THU$~$SUPL_ONAME_THU$~$SUPL_NAME_FRI$~$SUPL_ONAME_FRI$~$SUPL_NAME_SAT$~$SUPL_ONAME_SAT$~$               VALID_FROM$~$       CREATED_BY$~$   CREATED_DATE$~$     UPDATED_BY$~$       UPDATED_DATE$~$         BKUP_SNO
        
        //var tablevalue =casecode + "$~$" + casename + "$~$"+ casehouse + "$~$" + casedescription + "$~$" + casedegree + "$~$" + caserashi + "$~$" + caseplanet+ "$~$" + desc + "$~$" ;
        
         var tablevalue =casecode + "$~$" + casename + "$~$"+ casehouse + "$~$" + planet + "$~$" + caserashi + "$~$" + casedegree + "$~$" + casedescription+ "$~$" + caseplanet + "$~$"+caseascendent+ "$~$"+caseconstellation+ "$~$"+casedegreefrom+ "$~$"+casedegreeto+ "$~$"+casechart+ "$~$"+caseaspecting+ "$~$"+casebook+ "$~$"+casepage0+ "$~$"+caseloh+ "$~$";
        
        
        var fi = document.getElementById('tblfields').value.replace("$~$" + tablename, "")
        fi = fi.replace("$~$" + action, "")
        var dateformate = document.getElementById('hiddendateformat').value




        savegrid(casecode, casedescription);
        
       
        var result=Houseposition.save(casecode,casename,casehouse,planet,caserashi,casedegree,casedescription,caseplanet,caseascendent,caseconstellation,casedegreefrom,casedegreeto,casechart,caseaspecting,casebook,casepage0,caseloh,casekeystring)
        //var result = Houseposition.save("HOUSE_POSITIPON",fi, tablevalue, "", "dd/mm/yyyy", "", "")
//var modcolname=""+"$~$"+""+"$~$"
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

//        if (document.getElementById('Textname').value == "") 
//        {
//            alert("Please fill text Name")
//            document.getElementById('Textname').focus();
//            return false;
//        }

//        if (document.getElementById('Drphouse').value== "0" || document.getElementById('Drphouse').value== "") 
//        {
//            alert("Please select house")
//            document.getElementById('Drphouse').focus();
//            return false;
//        }
//        
//        
//         if (document.getElementById('Drpplanet').value == "0" || document.getElementById('Drpplanet').value == "")
//         {
//            alert(" Please Enter planet")
//            document.getElementById('Drpplanet').focus();
//            return false;
//        }
//        
//        
//        if (document.getElementById('Drprashi').value == "0"|| document.getElementById('Drprashi').value == "") 
//        {
//            alert("Please Enter  Rashi")
//            document.getElementById('Drprashi').focus();
//            return false;
//        }
//        
//        
//        if (document.getElementById('Textpdegree').value == "")
//         {
//            alert("please enter Planetdegree")
//            document.getElementById('Textpdegree').focus();
//            return false;
//        }

//        
//       
//        if (document.getElementById('Textdesc').value == "")
//         {
//            alert("Please fill Description")
//            document.getElementById('Textdesc').focus();
//            return false;
//        }

//        
//        if (document.getElementById('detaildesc').value == "")
//         {
//            alert("Please fill Descripation in detail")
//            document.getElementById('detaildesc').focus();
//            return false;
//        }
//        
//if (document.getElementById('ascendentbox').value == "") 
//        {
//            alert("Please fill Ascendent ")
//            document.getElementById('ascendentbox').focus();
//            return false;
//        }
//       if (document.getElementById('constellationbox').value == "") 
//        {
//            alert("Please fill Constellation ")
//            document.getElementById('constellationbox').focus();
//            return false;
//        }
//        if (document.getElementById('degreefrom').value == "") 
//        {
//            alert("Please fill Degree Range ")
//            document.getElementById('degreefrom').focus();
//            return false;
//        }
//        if (document.getElementById('degreeto').value == "") 
//        {
//            alert("Please fill Degree Range ")
//            document.getElementById('degreeto').focus();
//            return false;
//        }
//        if (document.getElementById('chart').value == "") 
//        {
//            alert("Please fill Chart Number ")
//            document.getElementById('chart').focus();
//            return false;
//        }
       

        var code = "'" + (document.getElementById('Textcode').value) + "'";
        var casecode = code;
       
        var name = "'" + (document.getElementById('Textname').value) + "'";
        var casename = name;
        
        var book = "'" + (document.getElementById('book').value) + "'";
        var casebook = book;
        
        var page = "'" + (document.getElementById('page0').value) + "'";
        var casepage0 = page;

        var keystring = "'" + (document.getElementById('keystring').value) + "'";
        var casekeystring = keystring;
        
        var house = "'" + (document.getElementById('Drphouse').value) + "'";
        var casehouse = house;
        
         var loh = "'" + (document.getElementById('loh').value) + "'";
        var caseloh = loh
        
        
         var planet = "'" + document.getElementById('Drpplanet').value + "'";
        var caseplanet = planet;
        
        
        var rashi = "'" + (document.getElementById('Drprashi').value) + "'";
        var caserashi = rashi;
        
        
                
        var degree = "'" + (document.getElementById('Textpdegree').value) + "'";
      var casedegree= degree;
         
        
        
        
        var description = "'" + (document.getElementById('Textdesc').value) + "'";
        var casedescription= description;
        

       
       

        var dedesc = "'" + (document.getElementById('detaildesc').value) + "'";
        var caseplanet = dedesc;
        var desc = "''";
        
 var ascendent = "'" + (document.getElementById('ascendentbox').value) + "'";
        var caseascendent = ascendent;
        
        var constellation = "'" + (document.getElementById('constellationbox').value) + "'";
        var caseconstellation = constellation;
        
        var degreefrom = "'" + (document.getElementById('degreefrom').value) + "'";
        var casedegreefrom = degreefrom;
        
        var degreeto = "'" + (document.getElementById('degreeto').value) + "'";
        var casedegreeto= degreeto;
        
        var chart = "'" + document.getElementById('chart').value + "'";
        var casechart= chart;
    
     var aspecting = "'" + document.getElementById('accepting').value + "'";
        var caseaspecting= aspecting;
    
        
     //var aspectinghouse = "'" + document.getElementById('DropDownList1').value + "'";
   //     var caseaspectinghouse= aspectinghouse;
    
    
    
    
     var fi = document.getElementById('tblfields').value.replace("$~$" + tablename, "")
        fi = fi.replace("$~$" + action, "")
        fi=fi+"$~$"
        
        
        var concolname="CODE"+"$~$";
        var dateformate = document.getElementById('hiddendateformat').value

        var tablevalue = casecode + "$~$" + casename + "$~$" + casehouse + "$~$" + planet + "$~$" + caserashi + "$~$" + casedegree + "$~$" + casedescription + "$~$" + caseplanet + "$~$" + caseascendent + "$~$" + caseconstellation + "$~$" + casedegreefrom + "$~$" + casedegreeto + "$~$" + casechart + "$~$" + caseaspecting + "$~$" + casebook + "$~$" + casepage0 + "$~$" + caseloh + "$~$" + casekeystring + "$~$";
    var res=Houseposition.Modify_data(tablename,fi,tablevalue,concolname,dateformate,"","",callbackeex)
    
    
    var klen1 = document.getElementById("hdsviewgrid").childNodes[0].childNodes[0].childNodes.length - 1;

 for (i = 0; i <= klen1 - 1; i++) {
 var priority = "'" + document.getElementById('pr_' + i).value + "'";
 var casepriority=priority;
 var descclob = "'" + document.getElementById('de_' + i).value + "'"; 
 var casedescclob=descclob;
 var ref = "'" + document.getElementById('ref_' + i).value + "'";
  var caseref=ref;
 var tablename="PRIORITY_HOUSE";
 var concolname="CODE"+"$~$"+"REF_ID"+"$~$";
 var fi="CODE$~$PRIORITY$~$DESCCLOB$~$REF_ID$~$";
 var tablevalue=casecode + "$~$" + casepriority + "$~$"+ casedescclob + "$~$" + caseref + "$~$";
 var updated = document.getElementById('up_' + i).value.toUpperCase();
 if(updated=="M")
 {
 var res=Houseposition.Modify_data(tablename,fi,tablevalue,concolname,dateformate,"","")
 }
 else
 {
 savegrid(casecode);
 }
 
 }
    
    
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
     
     
     //.............for clear all text and deopdown................
     
     
     
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
        
        $('Textcode').disabled= true;
        $('book').disabled= true;
        $('page0').disabled = true;
        $('keystring').disabled = true;
        $('Textname').disabled= true;
        $('Drphouse').disabled= true;
         $('loh').disabled= true;
        $('Textdesc').disabled= true;
        $('Textpdegree').disabled= true;
        $('Drpplanet').disabled= true;        
        $('Drprashi').disabled =true;        
        $('detaildesc').disabled= true;
        $('ascendentbox').disabled= true;
        $('constellationbox').disabled= true;
        $('degreefrom').disabled= true;
        $('degreeto').disabled= true;
        $('chart').disabled= true;
         $('accepting').disabled= true;
             // $('DropDownList1').disabled= true;

       if($('Textcode').value!="")
       { 
        $('Textcode').value="";
        }
       
      if($('Textname').value!="")
      { 
      $('Textname').value="";
      }
       if($('page0').value!="")
      { 
      $('page0').value="";
      }
      if($('book').value!="")
      { 
      $('book').value="";
      }

      if ($('keystring').value != "") {
          $('keystring').value = "";
      }
      
      if($('Drphouse').value!="")
      { 
      $('Drphouse').value="";
      }
         if($('loh').value!="")
      { 
      $('loh').value="";
      }
      
      if($('Textdesc').value!="")
      { 
      $('Textdesc').value="";
      }
      
      if($('Textpdegree').value!="")
      { 
      $('Textpdegree').value="";
      }
      
      if($('Drprashi').value!="")
      { 
      $('Drprashi').value="";
      }
      if($('Drpplanet').value!="")
      { 
      $('Drpplanet').value="";
      }
           
      if($('detaildesc').value!="")
      { 
      $('detaildesc').value="";
      }
      if($('ascendentbox').value!="")
      { 
      $('ascendentbox').value="";
      }
      if($('constellationbox').value!="")
      { 
      $('constellationbox').value="";
      }
      if($('degreefrom').value!="")
      { 
      $('degreefrom').value="";
      }
      if($('degreeto').value!="")
      { 
      $('degreeto').value="";
      }
      if($('chart').value!="")
      { 
      $('chart').value="";
      }
     
     if($('accepting').value!="")
      { 
      $('accepting').value="";
      }
      
//      if($('DropDownList1').value!="")
//      { 
//      $('DropDownList1').value="";
//      }
     
        //$('Button4').style.display ='none';
    //  new_button("");
    //cleargrid();
grid();
disabelgrid();
    
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
  
//  ************************** this code for query

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
    
   
    
    document.getElementById("Textcode").disabled=false;
    document.getElementById("Textname").disabled=false;
    document.getElementById("book").disabled = false;
    document.getElementById("keystring").disabled = false;
      document.getElementById("page0").disabled=false;
    document.getElementById("Drphouse").disabled=false;
    document.getElementById("loh").disabled=false;
    document.getElementById("Textdesc").disabled=false;
    document.getElementById("Textpdegree").disabled=false;
    document.getElementById("Drprashi").disabled=false;
    document.getElementById("Drpplanet").disabled=false;
    document.getElementById("accepting").disabled=false;
      //document.getElementById("DropDownList1").disabled=false;
    document.getElementById("detaildesc").disabled=false;
               
          document.getElementById('ascendentbox').disabled=false; 
          document.getElementById('constellationbox').disabled=false; 
          document.getElementById('degreefrom').disabled=false; 
          document.getElementById('degreeto').disabled=false; 
            document.getElementById('chart').disabled=false;

//     document.getElementById('drpfrzflag').style.display='block';
//     document.getElementById('lblfrzflag').style.display='block';


 

document.getElementById('Textcode').style.display='block';
document.getElementById('Textname').style.display='block';
document.getElementById('Drphouse').style.display='block';
document.getElementById('loh').style.display='block';
document.getElementById('Textdesc').style.display='block';
document.getElementById('book').style.display = 'block';
document.getElementById('keystring').style.display = 'block';
document.getElementById('page0').style.display='block';
document.getElementById('Textpdegree').style.display='block';
document.getElementById('Drprashi').style.display='block';
document.getElementById('Drpplanet').style.display='block';
document.getElementById('detaildesc').style.display='block';
      
          document.getElementById('ascendentbox').style.display='block'; 
                document.getElementById('accepting').style.display='block'; 
             //   document.getElementById('DropDownList1').style.display='block'; 
          document.getElementById('constellationbox').style.display='block'; 
          document.getElementById('degreefrom').style.display='block'; 
          document.getElementById('degreeto').style.display='block'; 
          document.getElementById('chart').style.display='block';

    
        //$('prepage').style.display ='none';
        //$('nextpage').style.display ='none';
      //  $('next1').style.display ='none';
      //  $('Td14').style.display = 'none';
       // $('view19').style.display = 'none';
        //$('button4').disabled=false;
        //$('Button4').style.display ='block';
      //enabelgrid();
    document.getElementById("btnExecute").focus(); 
    
    delete_record = 0; 
  //  $('Button4').style.display ='block';
  //  new_button("Query")
  
     setButtonImages();
    return false;

}
// this is for query execute..................................................
function executequery(querytype)

{

  document.getElementById("btnDelete").disabled=false;
       var house="";
       var textname="";
       var rashi="";
       var planet="";
        var ascendent="";
        var constellation="";
       var aspecting="";
        var aspectinghouse="";
       var loh="";
       var priority="";
       var descclob = "";
       var keystring = "";
         
//   for (i = 0; i <= klen1 - 1; i++) {
//var priority ="'"+document.getElementById('pr_' + i).value+"'"
//var descclob ="'"+document.getElementById('de_' + i).value+"'"
//       }
       
        var comp_code="'"+document.getElementById("Textcode").value+"'"
         
        //document.getElementById('Button4').disabled= false;        
        //$('Button4').style.display ='block';   
             
       var textname="'"+repalcesinglequote(document.getElementById("Textname").value)+"'"           
       //var caseassesy_code=textname.toUpperCase();  
       
       var book="'"+repalcesinglequote(document.getElementById("book").value)+"'"
       var page0 = "'" + repalcesinglequote(document.getElementById("page0").value) + "'"
       var keystring = "'" + repalcesinglequote(document.getElementById("keystring").value) + "'"           
                   
              
        if(document.getElementById("Drphouse").value!=0)
        {
          house="'"+repalcesinglequote(document.getElementById("Drphouse").value)+"'"
        }
        else
        
        {
        house="'"+house+"'"
        }
        
         if(document.getElementById("loh").value!=0)
        {
          loh="'"+repalcesinglequote(document.getElementById("loh").value)+"'"
        }
        else
        
        {
        loh="'"+loh+"'"
        }
        
        if(document.getElementById("accepting").value!=0)
        {
          aspecting="'"+repalcesinglequote(document.getElementById("accepting").value)+"'"
        }
        else
        
        {
        aspecting="'"+aspecting+"'"
        }
        
//        if(document.getElementById("DropDownList1").value!=0)
//        {
//          aspectinghouse="'"+repalcesinglequote(document.getElementById("DropDownList1").value)+"'"
//        }
//        else
//        
//        {
//        aspectinghouse="'"+aspectinghouse+"'"
//        }
        
        
         if(document.getElementById("Drpplanet").value!=0)
        {
          planet="'"+repalcesinglequote(document.getElementById("Drpplanet").value)+"'"
        }
        else
        {
        planet="'"+planet+"'"
        }
                
        if(document.getElementById("Drprashi").value!=0)
        {
          rashi="'"+repalcesinglequote(document.getElementById("Drprashi").value)+"'"
        }
        else
        {
        rashi="'"+rashi+"'"
        }  
               
      
      var plntdegree="'"+repalcesinglequote(document.getElementById("Textpdegree").value)+"'"      
             
       var descrption="'"+repalcesinglequote(document.getElementById("Textdesc").value)+"'"
        
       var dedsec="'"+repalcesinglequote(document.getElementById("detaildesc").value)+"'"
    
       
       var detaildesc="'"+"'";   
       
       
        if(document.getElementById("ascendentbox").value!=0)
        {
          ascendent="'"+repalcesinglequote(document.getElementById("ascendentbox").value)+"'"
        }
        else
        {
        ascendent="'"+ascendent+"'"
        }          
      
       
       
           if(document.getElementById("constellationbox").value!=0)
        {
          constellation="'"+repalcesinglequote(document.getElementById("constellationbox").value)+"'"
        }
        else
        {
        constellation="'"+constellation+"'"
        }         
        
     
       
      var  degreefro="'"+repalcesinglequote(document.getElementById("degreefrom").value)+"'"

  
  
      var  degreet="'"+repalcesinglequote(document.getElementById("degreeto").value)+"'"
  
       
          
 
 var chartno="'"+repalcesinglequote(document.getElementById("chart").value)+"'"
       //var caseassesy_name=dedsec.toUpperCase();
       
       
      
       
//       var frzflag1 = "";
//       
//        if ($('drpfrzflag').value=="0")
//         {
//         frzflag1="''";
//         }
//         else
//         {
//         frzflag1= "'"+document.getElementById('drpfrzflag').value+"'";
//         }
 
    var userid="'"+document.getElementById("hdnuserid").value+"'"
    var userid="''";
    document.getElementById("btnExecute").disabled=true;
    document.getElementById("btnfirst").disabled=false;
   
   

    //var fieldsvalue=comp_code+"$~$"+textname+"$~$"+house+"$~$"+descrption+"$~$"+plntdegree+"$~$"+rashi+"$~$"+planet+"$~$"+detaildesc+"$~$"

    var fieldsvalue = comp_code + "$~$" + textname + "$~$" + house + "$~$" + planet + "$~$" + rashi + "$~$" + plntdegree + "$~$" + descrption + "$~$" + detaildesc + "$~$" + ascendent + "$~$" + constellation + "$~$" + degreefro + "$~$" + degreet + "$~$" + chartno + "$~$" + aspecting + "$~$" + book + "$~$" + page0 + "$~$" + loh + "$~$" + keystring + "$~$"



   // fieldsvalue=fndun(fieldsvalue)
   
    //fieldsvalue=fndun()
   
    var SPLITVALUE=document.getElementById('fields').value.split("$~$")
    var fields=document.getElementById('fields').value.replace("$~$"+SPLITVALUE[SPLITVALUE.length-2],"").replace("$~$"+SPLITVALUE[SPLITVALUE.length-1],"")
    
     exectefuncol=fields;
     exectefunvalue=fieldsvalue;
     exectefuntab=SPLITVALUE[SPLITVALUE.length-2];
     old_exec_value=fieldsvalue;
     fields = fields+"$~$"
     Houseposition.execute(SPLITVALUE[SPLITVALUE.length-2],fields,fieldsvalue,"select",$('hdndateformat').value,"","",execute_callback);
  
   
   // var ds_ex=res.value;
   
//      view_tablename =exectefuntab;
//      view_colname=fields;      
//      view_colvalues=fieldsvalue ;
//     if(querytype=="view")
//        {
//             $('Td14').style.display ='block';
//             $('view19').style.display ='block';
//             $('prepage').style.display ='block';
//             $('nextpage').style.display ='block';
//             $('next1').style.display ='block';
   //         Houseposition.execute(fields,fieldsvalue,exectefuntab,"select",$('hdndateformat').value,"''","",callback_allview)
//             document.getElementById('Button4').disabled= true;
//             document.getElementById('btnExecute').disabled= true;
//        }



    
//    grid();
}


//************************** FOR CALL BACK***************



function execute_callback(val)
{
var degreet="";
record_show=10
record_show1=1

exec_data=val.value;
  var gg4=0;   
    
    if(exec_data == null)
    {
       alert("There is no data available regarding your query.")
     //  document.getElementById('Button4').disabled= true;
        
      //  $('Button4').style.display ='none';
    //   disabledexecfld();
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
//       document.getElementById("txtassesytypecode").value=repalcestr2quote(exec_data.Tables[0].Rows[next].ASSESY_CODE);
//       document.getElementById("txtassesytypename").value=repalcestr2quote(exec_data.Tables[0].Rows[next].ASSESY_DESC);




        document.getElementById("Textcode").value=(exec_data.Tables[0].Rows[next].CODE);
        document.getElementById("Textname").value=(exec_data.Tables[0].Rows[next].NAME);
        
        
        if(document.getElementById("Textname").value=="null")
       {
           document.getElementById("Textname").value="";
       }
       else
       {
      document.getElementById("Textname").value=(exec_data.Tables[0].Rows[next].NAME);
       }
       
        document.getElementById("book").value=(exec_data.Tables[0].Rows[next].BOOK);
        
        
        if(document.getElementById("book").value=="null")
       {
           document.getElementById("book").value="";
       }
       else
       {
      document.getElementById("book").value=(exec_data.Tables[0].Rows[next].BOOK);
       }
        document.getElementById("page0").value=(exec_data.Tables[0].Rows[next].PAGE_NO);
        
        
        if(document.getElementById("page0").value=="null")
       {
           document.getElementById("page0").value="";
       }
       else
       {
      document.getElementById("page0").value=(exec_data.Tables[0].Rows[next].PAGE_NO);
  }

  document.getElementById("page0").value = (exec_data.Tables[0].Rows[next].PAGE_NO);


  if (document.getElementById("keystring").value == "null") {
      document.getElementById("keystring").value = "";
  }
  else {
      document.getElementById("keystring").value = (exec_data.Tables[0].Rows[next].KEY_STRING);
  }

  document.getElementById("keystring").value = (exec_data.Tables[0].Rows[next].KEY_STRING);
        document.getElementById("Drphouse").value=(exec_data.Tables[0].Rows[next].HOUSE);
          document.getElementById("loh").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE);        
        document.getElementById("Drpplanet").value=(exec_data.Tables[0].Rows[next].PLANET);
        document.getElementById("Drprashi").value=(exec_data.Tables[0].Rows[next].RASHI);
        document.getElementById("accepting").value=(exec_data.Tables[0].Rows[next].ASPECTING_PLANET);
      //  document.getElementById("DropDownList1").value=(exec_data.Tables[0].Rows[next].ASPECTING_HOUSE);
        document.getElementById("Textpdegree").value=(exec_data.Tables[0].Rows[next].ASC_DEGREE);
        if(document.getElementById("Textpdegree").value=="null")
       {
           document.getElementById("Textpdegree").value="";
       }
       else
       {
      document.getElementById("Textpdegree").value=(exec_data.Tables[0].Rows[next].ASC_DEGREE);
       } 
        document.getElementById("Textdesc").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);       
          if(document.getElementById("Textdesc").value=="null")
       {
           document.getElementById("Textdesc").value="";
       }
       else
       {
      document.getElementById("Textdesc").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);
       }
       
       
       
       
//       
//         if(document.getElementById('Hidden7').value!="")
//       {
//       
//       
//       
//       if(document.getElementById('Hidden6').value=="1")
//       {
//      var categery= document.getElementById('Hidden7').value.split("$");
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
//              var categery= document.getElementById('Hidden7').value.split("$");
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
//       if(document.getElementById('Hidden6').value=="1")
//       {
//       if(gg4==categery.length)
//       {
//        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
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
//          if(document.getElementById("detaildesc").value=="null")
//       {
//           document.getElementById("detaildesc").value="";
//       }
//       else
//       {
//      document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       }

 document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
          document.getElementById("ascendentbox").value=(exec_data.Tables[0].Rows[next].ASCENDENT);
            document.getElementById("constellationbox").value=(exec_data.Tables[0].Rows[next].CONSTELLATION);
              document.getElementById("degreefrom").value=(exec_data.Tables[0].Rows[next].DEGREE_FROM);
       if(document.getElementById("degreefrom").value=="null")
       {
       document.getElementById("degreefrom").value="";
       }
       else
       { 
       
        document.getElementById("degreefrom").value=(exec_data.Tables[0].Rows[next].DEGREE_FROM);
}
                document.getElementById("degreeto").value=(exec_data.Tables[0].Rows[next].DEGREE_TO);
                
   if(document.getElementById("degreeto").value=="null")
  {
              document.getElementById("degreeto").value="";
       }
       else
       { 
  
       document.getElementById("degreeto").value=(exec_data.Tables[0].Rows[next].DEGREE_TO);
       }
  
  
  
  
                   document.getElementById("chart").value=(exec_data.Tables[0].Rows[next].CHART_NO);
 
      if(document.getElementById("chart").value=="null")
       {
         document.getElementById("chart").value="";
       }
       else
       { 
         document.getElementById("chart").value=(exec_data.Tables[0].Rows[next].CHART_NO);
       }
       
       
       old_execute_code =exec_data.Tables[0].Rows[next].CODE;
       old_execute_name =exec_data.Tables[0].Rows[next].NAME;
       old_execute_book =exec_data.Tables[0].Rows[next].BOOK;
       old_execute_page0 = exec_data.Tables[0].Rows[next].PAGE_NO;
       old_execute_keystring = exec_data.Tables[0].Rows[next].KEY_STRING;
       
       old_execute_house =exec_data.Tables[0].Rows[next].HOUSE;
        old_execute_loh =exec_data.Tables[0].Rows[next].LORD_OF_HOUSE;
       old_execute_planet =exec_data.Tables[0].Rows[next].PLANET;
       old_execute_rashi =exec_data.Tables[0].Rows[next].RASHI;
             old_execute_aspecting =exec_data.Tables[0].Rows[next].ASPECTING_PLANET;
           //   old_execute_aspectinghouse =exec_data.Tables[0].Rows[next].ASPECTING_HOUSE;
       old_execute_pdegree =exec_data.Tables[0].Rows[next].ASC_DEGREE;
       old_execute_desc =exec_data.Tables[0].Rows[next].DESCRIPTION;       
       old_execute_dedesc =exec_data.Tables[0].Rows[next].DESCCLOB;
       old_execute_ascendent =exec_data.Tables[0].Rows[next].ASCENDENT;
       old_execute_constellation =exec_data.Tables[0].Rows[next].CONSTELLATION;
       old_execute_dfrom =exec_data.Tables[0].Rows[next].DEGREE_FROM;
       old_execute_dto =exec_data.Tables[0].Rows[next].DEGREE_TO;
       old_execute_chart =exec_data.Tables[0].Rows[next].CHART_NO;
      
   
   
    
   
  
//    if(exec_data.Tables[0].Rows[next].FREEZE_FLAG==null)
//	{	
//	$('drpfrzflag').value="";  
//    }
//	else
//	{
//	$('drpfrzflag').value=exec_data.Tables[0].Rows[next].FREEZE_FLAG   
//    }
    
      // var frzflagnew = fndnull(exec_data.Tables[0].Rows[next].FREEZE_FLAG);
      // $('drpfrzflag').value= frzflagnew;
    
         document.getElementById("btnModify").disabled=false;
//       document.getElementById("drpfrzflag").disabled=true;
         document.getElementById("Textcode").disabled=true;
         document.getElementById("Textname").disabled=true;
          document.getElementById("book").disabled=true;
          document.getElementById("page0").disabled = true;
          document.getElementById("keystring").disabled = true;
         document.getElementById("Drphouse").disabled=true;
         document.getElementById("loh").disabled=true;
         document.getElementById("Textdesc").disabled=true;
         document.getElementById("Textpdegree").disabled=true;
         document.getElementById("Drprashi").disabled=true;
         document.getElementById("Drpplanet").disabled=true;
         document.getElementById("accepting").disabled=true;
    //      document.getElementById("DropDownList1").disabled=true;
         document.getElementById("detaildesc").disabled=true;
         document.getElementById("ascendentbox").disabled=true;
         document.getElementById("constellationbox").disabled=true;
         document.getElementById("degreefrom").disabled=true;
         document.getElementById("degreeto").disabled=true;
         document.getElementById("chart").disabled=true;
     
       
    $('btnfirst').disabled = true;
	$('btnlast').disabled = false;
	$('btnprevious').disabled = true;
	$('btnnext').disabled = false;
	//$('btnDelete').disabled = true;
	//$('next1').displayed=true;
   setButtonImages();
  var tablename="PRIORITY_HOUSE";
   var fields1="CODE$~$PRIORITY$~$DESCCLOB$~$";
   var co=exec_data.Tables[0].Rows[next].CODE;
   var fieldsvalue1="'" + co + "'" +"$~$"+"''"+"$~$"+"''"+"$~$";
Houseposition.execute(tablename,fields1,fieldsvalue1,"select",$('hdndateformat').value,"","",execute_callback1);
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
   
   	//$('btnModify').focus(); 
    
 // chk_button(exec_data.Tables[0].Rows.length)
}





//**********************THIS IS FOR DELETE ****************
function delete_data()
{ 
       var comp_code="'"+document.getElementById("Textcode").value+"'"     
       var textname="'"+(document.getElementById("Textname").value)+"'"           
              if(confirm("Are you sure! Do you want to delete this entry?"))
   
        {
                    var fieldsvalue=comp_code+"$~$"+textname;
               var SPLITVALUE=document.getElementById('fields').value.split("$~$")
               var fields1="CODE"+"$~$"+"NAME"
             
                
                var tablename="HOUSE_POSITIPON";
               // var old_value=comp_code+"$~$"+"'"+old_textname+"'"+"$~$"+"'"+old_house+"'"+"$~$"   +old_planet+"'"+"$~$"+old_rashi+"'"+"$~$"+old_pdegree+"'"+"$~$"+old_desc+"'"+"$~$"+old_dedesc+"'"+"$~$";
              var extra1="''";
              var extra2="''";
             //  var wcon=document.getElementById('wfields').value+"$~$";
               var res=Houseposition.agency_delete(tablename,fields1,fieldsvalue,document.getElementById('hdndateformat').value,extra1,extra2)
             //  fin_assesytype.agency_exec(fields,old_exec_value,SPLITVALUE[SPLITVALUE.length-2],"select",$('hdndateformat').value,execute_callback)
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
 
//****************************for find first record************************ 
 function fnd_first_record()
{
      delete_record = 0;
      record_show=5
      record_show1=1
var gg=0;
       next="0";
       chk_button(next)
//       old_assesy_code =exec_data.Tables[0].Rows[next].ASSESY_CODE;
//       old_assesy_desc =exec_data.Tables[0].Rows[next].ASSESY_DESC;

       old_execute_code =exec_data.Tables[0].Rows[next].CODE;
       old_execute_name =exec_data.Tables[0].Rows[next].NAME;
       old_execute_book =exec_data.Tables[0].Rows[next].BOOK;
       old_execute_page0 = exec_data.Tables[0].Rows[next].PAGE_NO;
       old_execute_keystring = exec_data.Tables[0].Rows[next].KEY_STRING;
       old_execute_house =exec_data.Tables[0].Rows[next].HOUSE;
          old_execute_loh =exec_data.Tables[0].Rows[next].LORD_OF_HOUSE;
       old_execute_planet =exec_data.Tables[0].Rows[next].PLANET;
       old_execute_rashi =exec_data.Tables[0].Rows[next].RASHI;            
       old_execute_aspecting =exec_data.Tables[0].Rows[next].ASPECTING_PLANET;  
            //  old_execute_aspectinghouse =exec_data.Tables[0].Rows[next].ASPECTING_HOUSE;          
       old_execute_pdegree =exec_data.Tables[0].Rows[next].ASC_DEGREE;
       old_execute_desc =exec_data.Tables[0].Rows[next].DESCRIPTION;       
       old_execute_dedesc =exec_data.Tables[0].Rows[next].DESCCLOB;
         old_execute_ascendent =exec_data.Tables[0].Rows[next].ASCENDENT;
          old_execute_constellation =exec_data.Tables[0].Rows[next].CONSTELLATION;
              old_execute_dfrom=exec_data.Tables[0].Rows[next].DEGREE_FROM;
               old_execute_dto=exec_data.Tables[0].Rows[next].DEGREE_TO;
                     old_execute_chart=exec_data.Tables[0].Rows[next].CHART_NO;

       document.getElementById("Textcode").value=(exec_data.Tables[0].Rows[next].CODE);
        document.getElementById("Textname").value=(exec_data.Tables[0].Rows[next].NAME);
        
        
        if(document.getElementById("Textname").value=="null")
       {
           document.getElementById("Textname").value="";
       }
       else
       {
      document.getElementById("Textname").value=(exec_data.Tables[0].Rows[next].NAME);
       }
            document.getElementById("page0").value=(exec_data.Tables[0].Rows[next].PAGE_NO);
        
        
        if(document.getElementById("page0").value=="null")
       {
           document.getElementById("page0").value="";
       }
       else
       {
      document.getElementById("page0").value=(exec_data.Tables[0].Rows[next].PAGE_NO);
       }

       document.getElementById("page0").value = (exec_data.Tables[0].Rows[next].PAGE_NO);


       if (document.getElementById("keystring").value == "null") {
           document.getElementById("keystring").value = "";
       }
       else {
           document.getElementById("keystring").value = (exec_data.Tables[0].Rows[next].KEY_STRING);
       }

       document.getElementById("keystring").value = (exec_data.Tables[0].Rows[next].KEY_STRING);
        
        document.getElementById("book").value=(exec_data.Tables[0].Rows[next].BOOK);
        
        
        if(document.getElementById("book").value=="null")
       {
           document.getElementById("book").value="";
       }
       else
       {
      document.getElementById("book").value=(exec_data.Tables[0].Rows[next].BOOK);
       }
        document.getElementById("Drphouse").value=(exec_data.Tables[0].Rows[next].HOUSE);
        
        document.getElementById("loh").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE);
        document.getElementById("Drpplanet").value=(exec_data.Tables[0].Rows[next].PLANET);
        document.getElementById("Drprashi").value=(exec_data.Tables[0].Rows[next].RASHI);
        document.getElementById("accepting").value=(exec_data.Tables[0].Rows[next].ASPECTING_PLANET);
       // document.getElementById("DropDownList1").value=(exec_data.Tables[0].Rows[next].ASPECTING_HOUSE); 
        document.getElementById("Textpdegree").value=(exec_data.Tables[0].Rows[next].ASC_DEGREE);
        
         if(document.getElementById("Textpdegree").value=="null")
       {
           document.getElementById("Textpdegree").value="";
       }
       else
       {
      document.getElementById("Textpdegree").value=(exec_data.Tables[0].Rows[next].ASC_DEGREE);
       }
        
        
        document.getElementById("Textdesc").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);  
          if(document.getElementById("Textdesc").value=="null")
       {
           document.getElementById("Textdesc").value="";
       }
       else
       {
      document.getElementById("Textdesc").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);
       }      
       
       
       
//       
//                if(document.getElementById('Hidden7').value!="")
//       {
//       
//       
//       
//       if(document.getElementById('Hidden6').value=="1")
//       {
//      var categery= document.getElementById('Hidden7').value.split("$");
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
//              var categery= document.getElementById('Hidden7').value.split("$");
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
//       if(document.getElementById('Hidden6').value=="1")
//       {
//       if(gg==categery.length)
//       {
//        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
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
        document.getElementById("ascendentbox").value=(exec_data.Tables[0].Rows[next].ASCENDENT);
document.getElementById("constellationbox").value=(exec_data.Tables[0].Rows[next].CONSTELLATION);
document.getElementById("degreefrom").value=(exec_data.Tables[0].Rows[next].DEGREE_FROM);
if(document.getElementById("degreefrom").value=="null")
       {
       document.getElementById("degreefrom").value="";
       }
       else
       { 
       
        document.getElementById("degreefrom").value=(exec_data.Tables[0].Rows[next].DEGREE_FROM);
}

document.getElementById("degreeto").value=(exec_data.Tables[0].Rows[next].DEGREE_TO);

  if(document.getElementById("degreeto").value=="null")
  {
            document.getElementById("degreeto").value="";
       }
       else
       { 
  
       document.getElementById("degreeto").value=(exec_data.Tables[0].Rows[next].DEGREE_TO);
       }
  
  
document.getElementById("chart").value=(exec_data.Tables[0].Rows[next].CHART_NO);

if(document.getElementById("chart").value=="null")
       {
         document.getElementById("chart").value="";
       }
       else
       { 
         document.getElementById("chart").value=(exec_data.Tables[0].Rows[next].CHART_NO);
       }
       
       
 var tablename="PRIORITY_HOUSE";
   var fields1="CODE$~$PRIORITY$~$DESCCLOB$~$";
   var co=exec_data.Tables[0].Rows[next].CODE;
   var fieldsvalue1="'" + co + "'" +"$~$"+"''"+"$~$"+"''"+"$~$";
Houseposition.execute(tablename,fields1,fieldsvalue1,"select",$('hdndateformat').value,"","",execute_callback1);
    
    //var frzflagnew = fndnull(exec_data.Tables[0].Rows[next].FREEZE_FLAG);
     //  $('drpfrzflag').value= frzflagnew;
    
  //  document.getElementById('Button4').disabled= true;
        
        
//        $('Td14').style.display = 'none';
//       $('view19').style.display = 'none';
//       $('prepage').style.display = 'none';
//       $('nextpage').style.display = 'none';
//      $('next1').style.display='none';


    return false;
}

 
 
 //*******************************find next record**********************************
 function fnd_next_record()
{
    delete_record = 0;
    record_show=8
    record_show1=1
    next=parseInt(next)+1;
    chk_button(next) 
    var gg1=0;
//        old_assesy_code =exec_data.Tables[0].Rows[next].ASSESY_CODE;
//       old_assesy_desc =exec_data.Tables[0].Rows[next].ASSESY_DESC;



       old_execute_code =exec_data.Tables[0].Rows[next].CODE;
       old_execute_name =exec_data.Tables[0].Rows[next].NAME;
       old_execute_book =exec_data.Tables[0].Rows[next].BOOK;
       old_execute_page0 = exec_data.Tables[0].Rows[next].PAGE_NO;
       old_execute_keystring = exec_data.Tables[0].Rows[next].KEY_STRING;
         old_execute_house =exec_data.Tables[0].Rows[next].HOUSE;
           old_execute_loh =exec_data.Tables[0].Rows[next].LORD_OF_HOUSE;
       old_execute_planet =exec_data.Tables[0].Rows[next].PLANET;
       old_execute_rashi =exec_data.Tables[0].Rows[next].RASHI;
        old_execute_aspecting =exec_data.Tables[0].Rows[next].ASPECTING_PLANET;     
        //old_execute_aspectinghouse =exec_data.Tables[0].Rows[next].ASPECTING_HOUSE;         
       old_execute_pdegree =exec_data.Tables[0].Rows[next].ASC_DEGREE;
       old_execute_desc =exec_data.Tables[0].Rows[next].DESCRIPTION;        
       old_execute_dedesc =exec_data.Tables[0].Rows[next].DESCCLOB;
         old_execute_ascendent =exec_data.Tables[0].Rows[next].ASCENDENT;
          old_execute_constellation =exec_data.Tables[0].Rows[next].CONSTELLATION;
              old_execute_dfrom=exec_data.Tables[0].Rows[next].DEGREE_FROM;
               old_execute_dto=exec_data.Tables[0].Rows[next].DEGREE_TO;
                     old_execute_chart=exec_data.Tables[0].Rows[next].CHART_NO;




      document.getElementById("Textcode").value=(exec_data.Tables[0].Rows[next].CODE);
      document.getElementById("Textname").value=(exec_data.Tables[0].Rows[next].NAME);
       
        if(document.getElementById("Textname").value=="null")
       {
           document.getElementById("Textname").value="";
       }
       else
       {
      document.getElementById("Textname").value=(exec_data.Tables[0].Rows[next].NAME);
       }
      
      document.getElementById("book").value=(exec_data.Tables[0].Rows[next].BOOK);
       
        if(document.getElementById("book").value=="null")
       {
           document.getElementById("book").value="";
       }
       else
       {
      document.getElementById("book").value=(exec_data.Tables[0].Rows[next].BOOK);
       }
      document.getElementById("page0").value=(exec_data.Tables[0].Rows[next].PAGE_NO);
       
        if(document.getElementById("page0").value=="null")
       {
           document.getElementById("page0").value="";
       }
       else
       {
      document.getElementById("page0").value=(exec_data.Tables[0].Rows[next].PAGE_NO);
  }

  document.getElementById("keystring").value = (exec_data.Tables[0].Rows[next].KEY_STRING);

  if (document.getElementById("keystring").value == "null") {
      document.getElementById("keystring").value = "";
  }
  else {
      document.getElementById("keystring").value = (exec_data.Tables[0].Rows[next].KEY_STRING);
  }
      
      document.getElementById("Drphouse").value=(exec_data.Tables[0].Rows[next].HOUSE);
        document.getElementById("loh").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE);
      document.getElementById("Drpplanet").value=(exec_data.Tables[0].Rows[next].PLANET);
      document.getElementById("Drprashi").value=(exec_data.Tables[0].Rows[next].RASHI);
       document.getElementById("accepting").value=(exec_data.Tables[0].Rows[next].ASPECTING_PLANET);
    //   document.getElementById("DropDownList1").value=(exec_data.Tables[0].Rows[next].ASPECTING_HOUSE);      
      document.getElementById("Textpdegree").value=(exec_data.Tables[0].Rows[next].ASC_DEGREE);
      
        if(document.getElementById("Textpdegree").value=="null")
       {
           document.getElementById("Textpdegree").value="";
       }
       else
       {
      document.getElementById("Textpdegree").value=(exec_data.Tables[0].Rows[next].ASC_DEGREE);
       }
      
      document.getElementById("Textdesc").value=(exec_data.Tables[0].Rows[next].DESCRIPTION); 
        if(document.getElementById("Textdesc").value=="null")
       {
           document.getElementById("Textdesc").value="";
       }
       else
       {
      document.getElementById("Textdesc").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);
       }     
       
       
       
       
       
       
       
//                if(document.getElementById('Hidden7').value!="")
//       {
//       
//       
//       
//       if(document.getElementById('Hidden6').value=="1")
//       {
//      var categery= document.getElementById('Hidden7').value.split("$");
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
//              var categery= document.getElementById('Hidden7').value.split("$");
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
//       if(document.getElementById('Hidden6').value=="1")
//       {
//       if(gg1==categery.length)
//       {
//        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       }
//       else
//       {
//       alert("No Match Found");
//         $('btnfirst').disabled = false;
//	$('btnlast').disabled = false;
//	$('btnprevious').disabled = false;
//	$('btnnext').disabled = false;
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
//      if(document.getElementById("detaildesc").value=="null")
//       {
//           document.getElementById("detaildesc").value="";
//       }
//       else
//       {
//      document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       }

  document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
       document.getElementById("ascendentbox").value=(exec_data.Tables[0].Rows[next].ASCENDENT);
document.getElementById("constellationbox").value=(exec_data.Tables[0].Rows[next].CONSTELLATION);
document.getElementById("degreefrom").value=(exec_data.Tables[0].Rows[next].DEGREE_FROM);

if(document.getElementById("degreefrom").value=="null")
       {
       document.getElementById("degreefrom").value="";
       }
       else
       { 
       
        document.getElementById("degreefrom").value=(exec_data.Tables[0].Rows[next].DEGREE_FROM);
}



document.getElementById("degreeto").value=(exec_data.Tables[0].Rows[next].DEGREE_TO);


 if(document.getElementById("degreeto").value=="null")
  {
            document.getElementById("degreeto").value="";
       }
       else
       { 
  
       document.getElementById("degreeto").value=(exec_data.Tables[0].Rows[next].DEGREE_TO);
       }
  

document.getElementById("chart").value=(exec_data.Tables[0].Rows[next].CHART_NO);        


if(document.getElementById("chart").value=="null")
       {
         document.getElementById("chart").value="";
       }
       else
       { 
         document.getElementById("chart").value=(exec_data.Tables[0].Rows[next].CHART_NO);
       }

var tablename="PRIORITY_HOUSE";
   var fields1="CODE$~$PRIORITY$~$DESCCLOB$~$";
   var co=exec_data.Tables[0].Rows[next].CODE;
   var fieldsvalue1="'" + co + "'" +"$~$"+"''"+"$~$"+"''"+"$~$";
Houseposition.execute(tablename,fields1,fieldsvalue1,"select",$('hdndateformat').value,"","",execute_callback1);

//  Textcode Textname Drphouse Textdesc Textpdegree Drprashi Drpplanet

    
    
  //    var frzflagnew = fndnull(exec_data.Tables[0].Rows[next].FREEZE_FLAG);
       //$('drpfrzflag').value= frzflagnew;
    
   //  document.getElementById('Button4').disabled= true;
        
        
//        $('Td14').style.display = 'none';
//       $('view19').style.display = 'none';
//       $('prepage').style.display = 'none';
//       $('nextpage').style.display = 'none';
//       $('next1').style.display='none';
//       
         if(next==total_records-1 )
         {

              $('btnprevious').focus();
                 setButtonImages();      
         }
    
    
    return false;
}
//********************find last record*******************
function fnd_last_record()
{
     delete_record = 0;
     record_show=5
record_show1=1
var gg2=0;
    next=exec_data.Tables[0].Rows.length-1;
    chk_button(next)


//         old_assesy_code =exec_data.Tables[0].Rows[next].ASSESY_CODE;
//       old_assesy_desc =exec_data.Tables[0].Rows[next].ASSESY_DESC;
//       
       
       
        old_execute_code =exec_data.Tables[0].Rows[next].CODE;
        old_execute_name =exec_data.Tables[0].Rows[next].NAME;
               old_execute_book =exec_data.Tables[0].Rows[next].BOOK;
               old_execute_page0 = exec_data.Tables[0].Rows[next].PAGE_NO;

               old_execute_keystring = exec_data.Tables[0].Rows[next].KEY_STRING;
        old_execute_house =exec_data.Tables[0].Rows[next].HOUSE;  
          old_execute_loh =exec_data.Tables[0].Rows[next].LORD_OF_HOUSE;       
        old_execute_planet =exec_data.Tables[0].Rows[next].PLANET;      
        old_execute_rashi =exec_data.Tables[0].Rows[next].RASHI;
         old_execute_aspecting =exec_data.Tables[0].Rows[next].ASPECTING_PLANET;
          //old_execute_aspectinghouse =exec_data.Tables[0].Rows[next].ASPECTING_HOUSE;
        old_execute_pdegree =exec_data.Tables[0].Rows[next].ASC_DEGREE;
        old_execute_desc =exec_data.Tables[0].Rows[next].DESCRIPTION;         
        old_execute_dedesc =exec_data.Tables[0].Rows[next].DESCCLOB;
old_execute_ascendent =exec_data.Tables[0].Rows[next].ASCENDENT;
          old_execute_constellation =exec_data.Tables[0].Rows[next].CONSTELLATION;
              old_execute_dfrom=exec_data.Tables[0].Rows[next].DEGREE_FROM;
               old_execute_dto=exec_data.Tables[0].Rows[next].DEGREE_TO;
                     old_execute_chart=exec_data.Tables[0].Rows[next].CHART_NO;
       
     
       
      document.getElementById("Textcode").value=(exec_data.Tables[0].Rows[next].CODE);
      document.getElementById("Textname").value=(exec_data.Tables[0].Rows[next].NAME);
      
        if(document.getElementById("Textname").value=="null")
       {
           document.getElementById("Textname").value="";
       }
       else
       {
      document.getElementById("Textname").value=(exec_data.Tables[0].Rows[next].NAME);
       }
        document.getElementById("book").value=(exec_data.Tables[0].Rows[next].BOOK);
      
        if(document.getElementById("book").value=="null")
       {
           document.getElementById("book").value="";
       }
       else
       {
      document.getElementById("book").value=(exec_data.Tables[0].Rows[next].BOOK);
       }
       
        document.getElementById("page0").value=(exec_data.Tables[0].Rows[next].PAGE_NO);
      
        if(document.getElementById("page0").value=="null")
       {
           document.getElementById("page0").value="";
       }
       else
       {
      document.getElementById("page0").value=(exec_data.Tables[0].Rows[next].PAGE_NO);
  }

  document.getElementById("keystring").value = (exec_data.Tables[0].Rows[next].KEY_STRING);

  if (document.getElementById("keystring").value == "null") {
      document.getElementById("keystring").value = "";
  }
  else {
      document.getElementById("keystring").value = (exec_data.Tables[0].Rows[next].KEY_STRING);
  }
       
      document.getElementById("Drphouse").value=(exec_data.Tables[0].Rows[next].HOUSE);
         document.getElementById("loh").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE);
      document.getElementById("Drpplanet").value=(exec_data.Tables[0].Rows[next].PLANET);
      document.getElementById("Drprashi").value=(exec_data.Tables[0].Rows[next].RASHI);
          document.getElementById("accepting").value=(exec_data.Tables[0].Rows[next].ASPECTING_PLANET);
         // document.getElementById("DropDownList1").value=(exec_data.Tables[0].Rows[next].ASPECTING_HOUSE);
      document.getElementById("Textpdegree").value=(exec_data.Tables[0].Rows[next].ASC_DEGREE); 
      
        if(document.getElementById("Textpdegree").value=="null")
       {
           document.getElementById("Textpdegree").value="";
       }
       else
       {
      document.getElementById("Textpdegree").value=(exec_data.Tables[0].Rows[next].ASC_DEGREE);
       }
      
      
      
      document.getElementById("Textdesc").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);    
        if(document.getElementById("Textdesc").value=="null")
       {
           document.getElementById("Textdesc").value="";
       }
       else
       {
      document.getElementById("Textdesc").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);
       } 
       
       
       
       
//                if(document.getElementById('Hidden7').value!="")
//       {
//       
//       
//       
//       if(document.getElementById('Hidden6').value=="1")
//       {
//      var categery= document.getElementById('Hidden7').value.split("$");
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
//              var categery= document.getElementById('Hidden7').value.split("$");
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
//       if(document.getElementById('Hidden6').value=="1")
//       {
//       if(gg2==categery.length)
//       {
//        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
//       }
//       else
//       {
//       alert("No Match Found");
//         $('btnfirst').disabled = false;
//	$('btnlast').disabled = true;
//	$('btnprevious').disabled = false;
//	$('btnnext').disabled = true;
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
       
      
          document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
      
      if(document.getElementById("detaildesc").value=="null")
       {
           document.getElementById("detaildesc").value="";
       }
       else
       {
      document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
       }
      document.getElementById("ascendentbox").value=(exec_data.Tables[0].Rows[next].ASCENDENT);
      document.getElementById("constellationbox").value=(exec_data.Tables[0].Rows[next].CONSTELLATION);
      document.getElementById("degreefrom").value=(exec_data.Tables[0].Rows[next].DEGREE_FROM);
      
      
      if(document.getElementById("degreefrom").value=="null")
       {
       document.getElementById("degreefrom").value="";
       }
       else
       { 
       
        document.getElementById("degreefrom").value=(exec_data.Tables[0].Rows[next].DEGREE_FROM);
}
      
      document.getElementById("degreeto").value=(exec_data.Tables[0].Rows[next].DEGREE_TO);
      
      if(document.getElementById("degreeto").value=="null")
  {
            document.getElementById("degreeto").value="";
       }
       else
       { 
  
       document.getElementById("degreeto").value=(exec_data.Tables[0].Rows[next].DEGREE_TO);
       }
  
      
      
      document.getElementById("chart").value=(exec_data.Tables[0].Rows[next].CHART_NO);        


if(document.getElementById("chart").value=="null")
       {
         document.getElementById("chart").value="";
       }
       else
       { 
         document.getElementById("chart").value=(exec_data.Tables[0].Rows[next].CHART_NO);
       }



 var tablename="PRIORITY_HOUSE";
   var fields1="CODE$~$PRIORITY$~$DESCCLOB$~$";
   var co=exec_data.Tables[0].Rows[next].CODE;
   var fieldsvalue1="'" + co + "'" +"$~$"+"''"+"$~$"+"''"+"$~$";
Houseposition.execute(tablename,fields1,fieldsvalue1,"select",$('hdndateformat').value,"","",execute_callback1);
//    
//      document.getElementById("txtassesytypecode").value=repalcestr2quote(exec_data.Tables[0].Rows[next].ASSESY_CODE);
//       document.getElementById("txtassesytypename").value=repalcestr2quote(exec_data.Tables[0].Rows[next].ASSESY_DESC);
      
   
//    if(exec_data.Tables[0].Rows[next].FREEZE_FLAG==null)
//	{	

//	//$('drpfrzflag').value="";  
//    }
//	else
//	{
//	$('drpfrzflag').value=exec_data.Tables[0].Rows[next].FREEZE_FLAG   
//    }
    
 //    document.getElementById('Button4').disabled= true;
        
        
//        $('Td14').style.display = 'none';
//       $('view19').style.display = 'none';
//       $('prepage').style.display = 'none';
//       $('nextpage').style.display = 'none';
//       $('next1').style.display='none';
//    
    return false; 
}

///**************************************************************************************************
function repalcesinglequote(val)
{
    if(val.indexOf("'")>=0)
    {
        while(val.indexOf("'")>=0)
        {
            val=val.replace("'","^");
        }
    }
    return val;
}


function repalcestr2quote(val)
{
    if(val.indexOf("^")>=0)
    {
        while(val.indexOf("^")>=0)
        {
            val=val.replace("^","'");
        }
    }
    return val;
}
//*******************************************callback view********from finnance********************



var srt_count=1;
var record_show1=1;
var record_show=8;	
var record_show1_other1=10;
var record_show_other=10;
var extra_record_other=0;
var divres=""; 
var check=true;


function callback_allview(res)
{
if(check==true)
{
var srt_count=0
var record_show1=1
var record_show=9

    if(res.value!=undefined)
    {
    ds18=res.value;
    }
    else
    {
    ds18=res;
    }
    
      if(ds18 == null)
    {
       alert("There is no data found regarding your query.")
    //   document.getElementById('Button4').disabled= true;
        
      //  $('Button4').style.display ='none';
       disabledexecfld();
       return false;
    }
check =false;

}
else
{
var srt_count=0
var record_show1=1
var record_show=9	
ds18="";

    if(res.value!=undefined)
    {
    ds18=res.value;
    }
    else
    {
    ds18=res;
    }
}

row_count=ds18.Tables[0].Rows.length;
var valnextval=2
pagenext(valnextval);


//ds18=res.value;
var hdsview="";
var j=1
var i=0

                            


    if(ds18!=null && ds18.Tables[0].Rows.length > 0)
    {           
                 hdsview+="<table Width='755px' style='border:1px solid #7DAAE3;margin-top:1px;margin-bottom:1px;margin-left:4px;' cellpadding='0' cellspacing='0'>"     
                for( srt_count;srt_count<=record_show && srt_count<ds18.Tables[0].Rows.length;srt_count++)
                {
                    
                     hdsview+="<tr>"
                     hdsview+="<td width='30px' style='border:1px solid #7DAAE3;padding-right:4px;' align='right'>"
                     hdsview+="<font style='font-size:10px;font-weight:bold;vertical-align:right;padding-top:4px;padding-left:6px;padding-bottom:2px; text-align:right;' >"+j;"</font>"
                     hdsview+="</td>"
                     
                     var ds_view_name=ds18.Tables[0].Rows[srt_count].ASSESY_CODE
			         if(ds_view_name!=null)
		             {
                     hdsview+="<td  id=tdassesycode"+j+" align='right'width='100px'   style='border:1px solid #7DAAE3;padding-right:8px;' onclick='javascript:return getDataInHeader(this.id);'>"
                     hdsview+="<font class='clickFieldinGrid' align='right'>"+repalcestr2quote(ds18.Tables[0].Rows[srt_count].ASSESY_CODE)+"</font>"
                     hdsview+="</td>"
                     }
                     
                     else
                     {
                         hdsview+="<td width='100px' style='border:1px solid #7DAAE3;padding-left:8px;;'>&nbsp;"
                         hdsview+="<font class='gridview'></font>"
                         hdsview+="</td>"
                     
                     }
                     
			         var ds_view_name=ds18.Tables[0].Rows[srt_count].ASSESY_DESC
			         if(ds_view_name!=null)
		             {
		               var aa11 = "\""+repalcestr2quote(ds18.Tables[0].Rows[srt_count].ASSESY_DESC)+ "\"";
                     hdsview+="<td width='600px'  align='left'   style='border:1px solid #7DAAE3;padding-left:8px;' align='left'>"
                     hdsview+="<font class='gridview' align='left' title="+aa11+">"+repalcestr2quote(ds18.Tables[0].Rows[srt_count].ASSESY_DESC).substring(0,25)+"</font>"
                     hdsview+="</td>"
                     }
                        else
                     {
                         hdsview+="<td width='600px' style='border:1px solid #7DAAE3;padding-left:8px;;'>&nbsp;"
                         hdsview+="<font class='gridview'></font>"
                         hdsview+="</td>"
                     
                     }
                                     
                     hdsview+="</tr>"
               //      hdsview+="</table>"
                     //document.getElementById('tstank').value=hdsview
        			
        			 $('view19').innerHTML=hdsview;  
			         j++
			         
			         //return false;
                 }
                 
                   hdsview+="</table>"
               	
        } 
		else
         {
			
			 hdsview+="<table width='755px;'>"
             hdsview+="<tr>"
             hdsview+="<td width='700px'>"
             hdsview+="<font Style='font-family:arial;font-weight:bold;font-size:18px;'>You have no detail </font></strong>"
             hdsview+="</td>"
    		 hdsview+="</tr>"
             hdsview+="</table>"
             hdsview =hdsview+ "<BR>"
			 $('view19').innerHTML=hdsview;
			    
			 return false;
        }  
}	

var srt_count_0ther=1;
function pagenext(valnext)
{
var nextPageNumberColor=true
divres=row_count/10;
if(divres.valueOf(".")>="0")
{
divres=divres+1;
}
else
{
divres;
}
  
var hdspage;
var aa="";
if((parseInt(record_show1)*10)-10>=row_count)
{
      return false;
}
else
{
$('next1').innerHTML="";
for(srt_count=record_show1;srt_count<record_show;srt_count++)
{
   if(srt_count<divres)
   {
   if(srt_count==1 || nextPageNumberColor==true)
   {
    $('next1').innerHTML+="<span onclick=pagenumber("+srt_count+",this.id) class='paggingColorChange'  id=nextnumber_"+srt_count+" runat='server'>"+srt_count+"</span>"
    nextPageNumberColor=false;
    pagenumber(srt_count,this.id)
   }
   else
   {
    $('next1').innerHTML+="<span onclick=pagenumber("+srt_count+",this.id) class='paggingColor'  id=nextnumber_"+srt_count+" runat='server'>"+srt_count+"</span>"
   } 
     aa="aa";
  }
  else
  {
   aa="";
  }

}
if(aa!="")
{
record_show1=record_show; 
preval=record_show1-4
record_show=record_show1+4;
nextPageNumberColor=true;
}
else
{
//record_show1=record_show; 
//preval=record_show1-4
//record_show=record_show1+4;
record_show1=1
preval=record_show1-4
record_show=record_show1+4;

//return false;
}
}
}
////****************************modify data*********************
function modifydata()
{

Modify=1;
     
      //  Textcode Textname Drphouse Textdesc  Textpdegree Drprashi Drpplanet detaildesc
      var     modifyduplicacydesc=$('Textcode').value;
      var     modifyduplicacyalias=$('Textname').value;        
          var     modifyduplicacyalias=$('book').value;
          var modifyduplicacyalias = $('page0').value;
          var modifyduplicacyalias = $('keystring').value; 
        var   modifyduplicacydesc=$('Drphouse').value;
          var   modifyduplicacydesc=$('loh').value;
       var    modifyduplicacyalias=$('Drpplanet').value;       
       var    modifyduplicacyalias=$('Drprashi').value;   
        var    modifyduplicacyalias=$('accepting').value; 
      //  var    modifyduplicacyalias=$('DropDownList1').value;   
        var   modifyduplicacyalias=$('Textpdegree').value;
       var    modifyduplicacyalias=$('Textdesc').value;             
         var  modifyduplicacyalias=$('detaildesc').value;
            var  modifyduplicacyalias=$('ascendentbox').value;
            var  modifyduplicacyalias=$('constellationbox').value;
            var  modifyduplicacyalias=$('degreefrom').value;
              var  modifyduplicacyalias=$('degreeto').value;
               var  modifyduplicacyalias=$('chart').value;

    
    document.getElementById("Textcode").disabled=false;
    document.getElementById("Textname").disabled=false;
    document.getElementById("book").disabled=false;
    document.getElementById("page0").disabled = false;
    document.getElementById("keystring").disabled = false;
    document.getElementById("Drphouse").disabled=false;
    document.getElementById("loh").disabled=false;
    document.getElementById("Drpplanet").disabled=false;
    document.getElementById("accepting").disabled=false;
   // document.getElementById("DropDownList1").disabled=false;
    document.getElementById("Drprashi").disabled=false;
    document.getElementById("Textpdegree").disabled=false;    
    document.getElementById("Textdesc").disabled=false;
    document.getElementById("detaildesc").disabled=false;
    document.getElementById("ascendentbox").disabled=false;
    document.getElementById("constellationbox").disabled=false;
    document.getElementById("degreefrom").disabled=false;
    document.getElementById("degreeto").disabled=false;
    document.getElementById("chart").disabled=false;
   
    
  
    document.getElementById("btnModify").disabled=true;
    document.getElementById("btnlast").disabled=true;
    document.getElementById("btnnext").disabled=true;
    document.getElementById("btnfirst").disabled=true;
    document.getElementById("btnprevious").disabled=true;
    document.getElementById("btnDelete").disabled=false;
    document.getElementById("btnSave").disabled=false;
//enabelgrid();
    modify="true";
   
  //     document.getElementById('Button4').disabled= false;
    
     // $('prepage').style.display ='none';
        //$('nextpage').style.display ='none';
        //$('next1').style.display ='none';
        //$('Td14').style.display = 'none';
        //$('view19').style.display = 'none';
        //$('button4').disabled=true;
    
    delete_record = 0;
    //new_button("Modify")
      setButtonImages();
    
    return false;
}
//**************************************
function chk_button(a)
{
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
        document.getElementById("btnfirst").disabled=true;
        document.getElementById("btnprevious").disabled=true;
         setButtonImages();
        return false;
    }

else if(next==exec_data.Tables[0].Rows.length-1)
{
        document.getElementById("btnlast").disabled=true;
        document.getElementById("btnnext").disabled=true;
        document.getElementById("btnfirst").disabled=false;
        document.getElementById("btnprevious").disabled=false;
         setButtonImages();
        return false;
    }
    
    else
    {
        document.getElementById("btnlast").disabled=false;
        document.getElementById("btnnext").disabled=false;
        document.getElementById("btnfirst").disabled=false;
        document.getElementById("btnprevious").disabled=false;
        setButtonImages();
        return false;
    }
    
}
//********************************************************************************
function disabledexecfld()
{
    publication_code=""
    edition_code=""
    agency_code=""
    agency_sub_code=""
    next=0;
    exec_data="";
    
    srt_count = 0;
    record_show1=1 ;
    
//    document.getElementById("txtassesytypecode").disabled=true;
//    document.getElementById("txtassesytypename").disabled=true;
//    document.getElementById("drpfrzflag").disabled=true;
     
     document.getElementById("Textcode").disabled=true;
    document.getElementById("Textname").disabled=true;    
    document.getElementById("Drphouse").disabled=true;
      document.getElementById("loh").disabled=true;
     document.getElementById("book").disabled=true;
     document.getElementById("page0").disabled = true;
     document.getElementById("keystring").disabled = true;
    document.getElementById("Drpplanet").disabled=true;
       document.getElementById("accepting").disabled=true;
            //document.getElementById("DropDownList1").disabled=true;
    document.getElementById("Drprashi").disabled=true;
    document.getElementById("Textpdegree").disabled=true;    
    document.getElementById("Textdesc").disabled=true;
    document.getElementById("detaildesc").disabled=true;
     document.getElementById("ascendentbox").disabled=true;
      document.getElementById("constellationbox").disabled=true;
       document.getElementById("degreefrom").disabled=true;
        document.getElementById("degreeto").disabled=true;
         document.getElementById("chart").disabled=true;

     
     
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
    
    
    
    
//    document.getElementById("txtassesytypecode").value=""
//    document.getElementById("txtassesytypename").value=""


  document.getElementById("Textcode").value=""
    document.getElementById("Textname").value=""
    document.getElementById("book").value=""
    document.getElementById("page0").value = ""
    document.getElementById("keystring").value = ""
    document.getElementById("Drphouse").value="0";    
    document.getElementById("loh").value="0";    
    document.getElementById("Drpplanet").value="0";
    document.getElementById("Drprashi").value="0";    
      document.getElementById("accepting").value="0";
       //  document.getElementById("DropDownList1").value="0";     
    document.getElementById("Textpdegree").value="";    
    document.getElementById("Textdesc").value="";
    document.getElementById("detaildesc").value="";
     document.getElementById("ascendentbox").value="0";
      document.getElementById("constellationbox").value="0";
       document.getElementById("degreefrom").value="";
        document.getElementById("degreeto").value="";
         document.getElementById("chart").value="";
    modify="false";
    
    
    
   // document.getElementById('Button4').disabled= true;
        //$('Td14').style.display = 'none';
      //  $('view19').style.display = 'none';
      //  $('prepage').style.display='none';
      //  $('nextpage').style.display='none';
     //   $('next1').style.display='none';
     //   document.getElementById('next1').innerHTML = "";
        
    
    delete_record = 0;
    
    //new_button();
      setButtonImages();
    return false;
}
//***************************find pre record********************
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

        old_execute_code =exec_data.Tables[0].Rows[next].CODE;
        old_execute_name =exec_data.Tables[0].Rows[next].NAME;
                old_execute_book =exec_data.Tables[0].Rows[next].BOOK;
                old_execute_page0 = exec_data.Tables[0].Rows[next].PAGE_NO;
                old_execute_keystring = exec_data.Tables[0].Rows[next].KEY_STRING;
        old_execute_house =exec_data.Tables[0].Rows[next].HOUSE;  
              old_execute_loh =exec_data.Tables[0].Rows[next].LORD_OF_HOUSE;   
           old_execute_aspecting =exec_data.Tables[0].Rows[next].ASPECTING_PLANET;
           // old_execute_aspectinghouse =exec_data.Tables[0].Rows[next].ASPECTING_HOUSE;       
        old_execute_planet =exec_data.Tables[0].Rows[next].PLANET;      
        old_execute_rashi =exec_data.Tables[0].Rows[next].RASHI;
        old_execute_pdegree =exec_data.Tables[0].Rows[next].ASC_DEGREE;
        old_execute_desc =exec_data.Tables[0].Rows[next].DESCRIPTION;         
        old_execute_dedesc =exec_data.Tables[0].Rows[next].DESCCLOB;
    
       //document.getElementById("txtassesytypecode").value=repalcestr2quote(exec_data.Tables[0].Rows[next].ASSESY_CODE);
       //document.getElementById("txtassesytypename").value=repalcestr2quote(exec_data.Tables[0].Rows[next].ASSESY_DESC);
            document.getElementById("Textcode").value=(exec_data.Tables[0].Rows[next].CODE);
      document.getElementById("Textname").value=(exec_data.Tables[0].Rows[next].NAME);
      
      
        if(document.getElementById("Textname").value=="null")
       {
           document.getElementById("Textname").value="";
       }
       else
       {
      document.getElementById("Textname").value=(exec_data.Tables[0].Rows[next].NAME);
       }
         document.getElementById("page0").value=(exec_data.Tables[0].Rows[next].PAGE_NO);
      
      
        if(document.getElementById("page0").value=="null")
       {
           document.getElementById("page0").value="";
       }
       else
       {
      document.getElementById("page0").value=(exec_data.Tables[0].Rows[next].PAGE_NO);
  }


  document.getElementById("keystring").value = (exec_data.Tables[0].Rows[next].KEY_STRING);


  if (document.getElementById("keystring").value == "null") {
      document.getElementById("keystring").value = "";
  }
  else {
      document.getElementById("keystring").value = (exec_data.Tables[0].Rows[next].KEY_STRING);
  }
        document.getElementById("book").value=(exec_data.Tables[0].Rows[next].BOOK);
      
      
        if(document.getElementById("book").value=="null")
       {
           document.getElementById("book").value="";
       }
       else
       {
      document.getElementById("book").value=(exec_data.Tables[0].Rows[next].BOOK);
       }
       
      document.getElementById("Drphouse").value=(exec_data.Tables[0].Rows[next].HOUSE);
       document.getElementById("loh").value=(exec_data.Tables[0].Rows[next].LORD_OF_HOUSE);
       document.getElementById("accepting").value=(exec_data.Tables[0].Rows[next].ASPECTING_PLANET);
         //  document.getElementById("DropDownList1").value=(exec_data.Tables[0].Rows[next].ASPECTING_HOUSE);
      document.getElementById("Drpplanet").value=(exec_data.Tables[0].Rows[next].PLANET);
      document.getElementById("Drprashi").value=(exec_data.Tables[0].Rows[next].RASHI);      
      document.getElementById("Textpdegree").value=(exec_data.Tables[0].Rows[next].ASC_DEGREE);
      if(document.getElementById("Textpdegree").value=="null")
       {
           document.getElementById("Textpdegree").value="";
       }
       else
       {
      document.getElementById("Textpdegree").value=(exec_data.Tables[0].Rows[next].ASC_DEGREE);
       }
      
      
        
      document.getElementById("Textdesc").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);   
      
        if(document.getElementById("Textdesc").value=="null")
       {
           document.getElementById("Textdesc").value="";
       }
       else
       {
      document.getElementById("Textdesc").value=(exec_data.Tables[0].Rows[next].DESCRIPTION);
       }
         
         
         
         
      if(document.getElementById('Hidden7').value!="")
       {
       
       
       
       if(document.getElementById('Hidden6').value=="1")
       {
      var categery= document.getElementById('Hidden7').value.split("$");
              for(var m=0;m<categery.length-1;m++)
              {
              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
              {
              gg3++;
              }
              }
      
       }
       else
       {
       
              var categery= document.getElementById('Hidden7').value.split("$");
              for(var m=0;m<categery.length-1;m++)
              {
              if(exec_data.Tables[0].Rows[next].DESCCLOB.indexOf(categery[m])>0)
              {
              gg3++;
              }
              }
       
       }
       
       if(document.getElementById('Hidden6').value=="1")
       {
       if(gg3==categery.length)
       {
        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
       }
       else
       {
       alert("No Match Found");
         $('btnfirst').disabled = false;
	$('btnlast').disabled = false;
	$('btnprevious').disabled = false;
	$('btnnext').disabled = false;
       return false;
       
       }
       }
       else
       {
       if(gg3>0)
        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
        else
        {
       alert("No Match Found");
       return false;
        }
       }
       
       }
       else
       {
        document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
       
       }
         
         
     
         if(document.getElementById("detaildesc").value=="null")
       {
           document.getElementById("detaildesc").value="";
       }
       else
       {
      document.getElementById("detaildesc").value=(exec_data.Tables[0].Rows[next].DESCCLOB);
       }
 document.getElementById("ascendentbox").value=(exec_data.Tables[0].Rows[next].ASCENDENT);
document.getElementById("constellationbox").value=(exec_data.Tables[0].Rows[next].CONSTELLATION);
document.getElementById("degreefrom").value=(exec_data.Tables[0].Rows[next].DEGREE_FROM);

   
      if(document.getElementById("degreefrom").value=="null")
       {
       document.getElementById("degreefrom").value="";
       }
       else
       { 
       
        document.getElementById("degreefrom").value=(exec_data.Tables[0].Rows[next].DEGREE_FROM);
}
      

document.getElementById("degreeto").value=(exec_data.Tables[0].Rows[next].DEGREE_TO);


  if(document.getElementById("degreeto").value=="null")
  {
            document.getElementById("degreeto").value="";
       }
       else
       { 
  
       document.getElementById("degreeto").value=(exec_data.Tables[0].Rows[next].DEGREE_TO);
       }


document.getElementById("chart").value=(exec_data.Tables[0].Rows[next].CHART_NO);        



if(document.getElementById("chart").value=="null")
       {
         document.getElementById("chart").value="";
       }
       else
       { 
         document.getElementById("chart").value=(exec_data.Tables[0].Rows[next].CHART_NO);
       }



      
    var tablename="PRIORITY_HOUSE";
   var fields1="CODE$~$PRIORITY$~$DESCCLOB$~$";
   var co=exec_data.Tables[0].Rows[next].CODE;
   var fieldsvalue1="'" + co + "'" +"$~$"+"''"+"$~$"+"''"+"$~$";
Houseposition.execute(tablename,fields1,fieldsvalue1,"select",$('hdndateformat').value,"","",execute_callback1);

//     var frzflagnew = fndnull(exec_data.Tables[0].Rows[next].FREEZE_FLAG);
//       $('drpfrzflag').value= frzflagnew;
//    
     // document.getElementById('Button4').disabled= true;
        
 
//        $('Td14').style.display = 'none';
//       $('view19').style.display = 'none';
//       $('prepage').style.display = 'none';
//       $('nextpage').style.display = 'none';
//       $('next1').style.display='none';
       
         if (next==0)
     {
       //   document.getElementById('btnfirst').disabled = true;
         //  document.getElementById('btnprevious').disabled = true;
         //  document.getElementById('btnlast').disabled=false;
            $('btnnext').focus();
            setButtonImages();
     }
     
     
    
    
    
    return false;
   
   
}



function grid() {

    //alert(res)
//    ds = res.value

    document.getElementById('Divgrid1').style.top = 630 + "px";
    document.getElementById('Divgrid1').style.left = 90 + "px";
    document.getElementById('Divgrid1').style.BackColor = "Ivory";
    var temp_del1 = "";
   buf1="";
   document.getElementById('hdsviewgrid').innerHTML="";
    flg_req = "yes"
    var aa1 = "";
    var aa = "";
    var hs = 0;
    var hs1 = 0;
    //alert('kkk')
    //alert(document.getElementById("datagrid1").childNodes[0])
    document.getElementById('hdsviewgrid').style.display = "block";
    //alert(document.getElementById("hdsviewgrid").children.length)
    if (document.getElementById("hdsviewgrid").children.length == "0") {
        klen = "0"
        //alert(klen)
    }
    else {

        klen = document.getElementById("datagrid1").childNodes[0].childNodes[0].childNodes.length - 1;
        //alert(klen)
        //           klen=document.getElementById("hdsviewgrid").childNodes[0].childNodes[0].childNodes.length-1;
        IntializeNumber = klen + 1;
    }

    if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:500px;display:block") <= 0) {
        aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
    }

    buf1 += "<table   id='datagrid1' runat='server' align='center' Width='490px' height='0px' style='border:1px;margin-left:210px; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
    buf1 += "<tr>"
    buf1 += "<td  bgcolor=#7DAAE3 style='height:10px;width:50px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "Priority" + "</td>"
    buf1 += "<td  bgcolor=#7DAAE3 style='height:10px;width:440px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "Descclob" + "</td>"
    buf1 += "<td  bgcolor=#7DAAE3 style='height:10px;width:20px;font-size:10px;display:none;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "ref_id" + "</td>"
    buf1 += "<td  bgcolor=#7DAAE3 style='height:10px;width:20px;font-size:10px;display:none;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "updated" + "</td>"

    buf1 += "</tr>"
   
        len = 1;
   
    
        buf1 +="<tr>"

        buf1 +="<td  style='border:0px solid #7DAAE3;' width='50px'>"
        buf1 += "<input type='text'  id='pr_" + klen + "'>"
        buf1 += "</td>"

//        buf1 += "<td class='gridview' style='border:0px solid #7DAAE3;display:none;'>"
//        buf1 += "<input type='text' style='display:none;'  class=fortaxtbox width=100px' id='drppcentercode_" + klen + "'>"
//        buf1 += "</td>"

        buf1 +="<td    style='border:0px solid #7DAAE3;'  align='left' >"
        buf1 += "<input type='text'  style='width:340px;' align='left' id='de_" + klen + "'>"
        buf1 += "</td>"

        buf1 +="<td    style='border:0px solid #7DAAE3;'  align='left' >"
        buf1 += "<input type='text'  style='width:20px;display:none;' align='left' id='ref_" + klen + "'>"
        buf1 += "</td>"
        
        buf1 +="<td    style='border:0px solid #7DAAE3;'  align='left' >"
        buf1 += "<input type='text'  style='width:20px;display:none;' value='i' align='left' id='up_" + klen + "'>"
        buf1 += "</td>"
       
//        buf1 +="<td  class='gridview' style='border:0px solid #7DAAE3;'>")
//        buf1 +="<select  style='display:none;' class=fordropdown width=100px' id='txtclimit_" + klen + "' onfocus='javascript:return binddropdown(id);'>"
//        buf1 +="</td>")
        buf1 +="</tr>"




  

    buf1 +="</table>"
    var hdsview = "";
    temp_del1 = aa + buf1.toString();
    temp_del1 = temp_del1.replace("<TBODY>", "")
    temp_del1 = temp_del1.replace("</TBODY>", "")
    //alert(temp_del1)
    document.getElementById('hdsviewgrid').innerHTML = temp_del1;
    //alert(document.getElementById('hdsviewgrid').innerHTML)
    //document.getElementById('Td1').innerHTML=temp_del1; 
    //lert(document.getElementById('hdsviewgrid').innerHTML)
    //document.getElementById('txtdesc__0').focus();


//    valfill(res);

    //document.getElementById('hdsviewgrid').style.display="block";

//    flg_req = "no"

    
////    disabeled();
//    setButtonImages();
    return false;




}

function StringBuffer() {
    this.buffer = [];
}

StringBuffer.prototype.append = function append(string) {
    this.buffer.push(string);
    return this;
}

StringBuffer.prototype.toString = function toString() {
    return this.buffer.join("");
}




function grid1() {

  flg_req = "yes"
    var aa1 = "";
    var aa = "";
    var hs = 0;
    var hs1 = 0;

    
    klen = document.getElementById("hdsviewgrid").childNodes[0].childNodes[0].childNodes.length - 1;

   // buf1 +="<table  class='gridview' id='datagrid1' runat='server' align='center' Width='500px' height='0px' style='border:0;margin-left:250px; solid #7DAAE3; cellpadding='0' cellspacing='0'>")//<tr>")
     // for (klen = a; klen < len1; klen++) {



    buf1 = document.getElementById("hdsviewgrid").innerHTML;
         buf1=buf1.replace("</TBODY></TABLE>","");
   
   
   
    
        buf1 +="<tr>"

        buf1 +="<td  style='border:0px solid #7DAAE3;'>"
        buf1 += "<input type='text'  class='fortaxtbox' width=50px' id='pr_" + klen + "'>"
        buf1 += "</td>"

//        buf1 += "<td class='gridview' style='border:0px solid #7DAAE3;display:none;'>"
//        buf1 += "<input type='text' style='display:none;'  class=fortaxtbox width=100px' id='drppcentercode_" + klen + "'>"
//        buf1 += "</td>"

        buf1 +="<td    style='border:0px solid #7DAAE3;' align='left' >"
        buf1 += "<input type='text'  aling='left' style='width:340px;' id='de_" + klen + "'>"
        buf1 += "</td>"

        buf1 +="<td    style='border:0px solid #7DAAE3;'  align='left' >"
        buf1 += "<input type='text'  style='width:20px;display:none;' align='left' id='ref_" + klen + "'>"
        buf1 += "</td>"
        

        buf1 +="<td    style='border:0px solid #7DAAE3;'  align='left' >"
        buf1 += "<input type='text'  style='width:20px;display:none;' value='i' align='left' id='up_" + klen + "'>"
        buf1 += "</td>"
//        buf1 +="<td  class='gridview' style='border:0px solid #7DAAE3;'>")
//        buf1 +="<select  style='display:none;' class=fordropdown width=100px' id='txtclimit_" + klen + "' onfocus='javascript:return binddropdown(id);'>"
//        buf1 +="</td>")
        buf1 +="</tr>"




         buf1 += "</TBODY></TABLE>"
             $("hdsviewgrid").innerHTML = buf1.toString();

//    buf1 +="</table>"
//    var hdsview = "";
//  temp_del1 = aa + buf1.toString();
//    temp_del1 = temp_del1.replace("<TBODY>", "")
//    temp_del1 = temp_del1.replace("</TBODY>", "")
//    //alert(temp_del1)
//    document.getElementById('hdsviewgrid').innerHTML = temp_del1;
    //alert(document.getElementById('hdsviewgrid').innerHTML)
    //document.getElementById('Td1').innerHTML=temp_del1; 
    //lert(document.getElementById('hdsviewgrid').innerHTML)
    //document.getElementById('txtdesc__0').focus();


//    valfill(res);

    //document.getElementById('hdsviewgrid').style.display="block";

//    flg_req = "no"

    
////    disabeled();
//    setButtonImages();
    return false;




}

function savegrid(casecode, casedescription)
{

 var klen1 = document.getElementById("hdsviewgrid").childNodes[0].childNodes[0].childNodes.length - 1;
 casecode=casecode.replace("'","");
       casecode=casecode.replace("'","");
var code =casecode;
 for (i = 0; i <= klen1 - 1; i++) {
 var extra1="";
var extra2="";
var ref1=Houseposition.refcode(extra1,extra2);
var ref_=ref1.value
var priority = document.getElementById('pr_' + i).value.toUpperCase() ;
var descclob = document.getElementById('de_' + i).value.toUpperCase();
var updated = document.getElementById('up_' + i).value.toUpperCase(); 
            if(updated=="I")
            {
            updated="M";
            Houseposition.save_priority(code, priority, descclob, ref_, updated, casedescription)
            }
}
return false;
}

function execute_callback1(val)
{
var degreet="";
record_show=10
record_show1=1
exec_data1=val.value;
var gg4=0;

if(exec_data1 == null)
    {
    grid();
    disabelgrid();
    return false;
    }

    if(exec_data1 != null)
      {
         total_records = exec_data1.Tables[0].Rows.length;
      }
      else
      {
         total_records = "0";
      }
    
    if(delete_record == 1)
    {

          var length_del = exec_data1.Tables[0].Rows.length;
          var a=length_del-1;
          if(length_del<=0)
          {
        grid();
        disabelgrid();
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

    if(exec_data1.Tables[0].Rows.length==0)
    {
    grid();
    }
    else
    {
    var len =exec_data1.Tables[0].Rows.length;
    grid2(len);
     var klen1 = document.getElementById("hdsviewgrid").childNodes[0].childNodes[0].childNodes.length - 1;

 for (i = 0; i <= len-1; i++) {
  document.getElementById('pr_' + i).value=exec_data1.Tables[0].Rows[i].PRIORITY;
  document.getElementById('de_' + i).value=exec_data1.Tables[0].Rows[i].DESCCLOB;
            document.getElementById('ref_' + i).value=exec_data1.Tables[0].Rows[i].REF_ID;
            document.getElementById('up_' + i).value=exec_data1.Tables[0].Rows[i].UPDAT;
            //disabelgrid();
 }
    
    
     
    }
   
}
function grid2(len) {

  document.getElementById('Divgrid1').style.top = 630 + "px";
    document.getElementById('Divgrid1').style.left = 90 + "px";
    document.getElementById('Divgrid1').style.BackColor = "Ivory";
    var temp_del1 = "";
   buf1 = "";
    document.getElementById('hdsviewgrid').innerHTML ="";
    flg_req = "yes"
    var aa1 = "";
    var aa = "";
    var hs = 0;
    var hs1 = 0;
    //alert('kkk')
    //alert(document.getElementById("datagrid1").childNodes[0])
    document.getElementById('hdsviewgrid').style.display = "block";
    //alert(document.getElementById("hdsviewgrid").children.length)
    if (document.getElementById("hdsviewgrid").children.length == "0") {
        klen = "0"
        //alert(klen)
    }
    else {

//        klen = document.getElementById("datagrid1").childNodes[0].childNodes[0].childNodes.length - 1;
        //alert(klen)
        //           klen=document.getElementById("hdsviewgrid").childNodes[0].childNodes[0].childNodes.length-1;
        IntializeNumber = klen + 1;
    }

    if (document.getElementById("hdsviewgrid").innerHTML.indexOf("width:500px;display:block") <= 0) {
        aa = document.getElementById("hdsviewgrid").innerHTML.replace("</TBODY>", "")//</TABLE>","")
    }
    var i="";

    buf1 += "<table id='datagrid1' runat='server' align='center' Width='490px' height='0px' style='border:1px;margin-left:210px; solid #7DAAE3; cellpadding='0' cellspacing='0'>"//<tr>"
    buf1 += "<tr>"
    buf1 += "<td  bgcolor=#7DAAE3 style='height:10px;width:50px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "Priority" + "</td>"
    buf1 += "<td  bgcolor=#7DAAE3 style='height:10px;width:440px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "Descclob" + "</td>"
    buf1 += "<td  bgcolor=#7DAAE3 style='height:10px;display:none;width:440px;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "REF_ID" + "</td>"
    buf1 += "<td  bgcolor=#7DAAE3 style='height:10px;width:440px;display:none;font-size:10px;font-weight:bold;text-align:center;border:1px solid #ffffff;'>" + "UPDATED" + "</td>"

    buf1 += "</tr>"
   
//        len = 1;
   
    for( i=0;i<=len-1;i++)
{
        buf1 +="<tr>"

        buf1 +="<td  style='border:0px solid #7DAAE3;' width='50px'>"
        buf1 += "<input type='text'  id='pr_" + i + "'>"
        buf1 += "</td>"

//        buf1 += "<td class='gridview' style='border:0px solid #7DAAE3;display:none;'>"
//        buf1 += "<input type='text' style='display:none;'  class=fortaxtbox width=100px' id='drppcentercode_" + klen + "'>"
//        buf1 += "</td>"

        buf1 +="<td    style='border:0px solid #7DAAE3;'  align='left' >"
        buf1 += "<input type='text'  style='width:340px;' align='left' id='de_" + i + "'>"
        buf1 += "</td>"

       buf1 +="<td    style='border:0px solid #7DAAE3;'  align='left' >"
        buf1 += "<input type='text'  style='width:20px;display:none;' align='left' id='ref_" + i + "'>"
        buf1 += "</td>"
        
        buf1 +="<td    style='border:0px solid #7DAAE3;'  align='left' >"
        buf1 += "<input type='text'  style='width:20px;display:none;' align='left' id='up_" + i + "'>"
        buf1 += "</td>"
//        buf1 +="<td  class='gridview' style='border:0px solid #7DAAE3;'>")
//        buf1 +="<select  style='display:none;' class=fordropdown width=100px' id='txtclimit_" + klen + "' onfocus='javascript:return binddropdown(id);'>"
//        buf1 +="</td>")
        buf1 +="</tr>"



}
  

    buf1 +="</table>"
    var hdsview = "";
  temp_del1 = aa + buf1.toString();
    temp_del1 = temp_del1.replace("<TBODY>", "")
    temp_del1 = temp_del1.replace("</TBODY>", "")
    //alert(temp_del1)
    document.getElementById('hdsviewgrid').innerHTML = temp_del1;
    //alert(document.getElementById('hdsviewgrid').innerHTML)
    //document.getElementById('Td1').innerHTML=temp_del1; 
    //lert(document.getElementById('hdsviewgrid').innerHTML)
    //document.getElementById('txtdesc__0').focus();


//    valfill(res);

    //document.getElementById('hdsviewgrid').style.display="block";

//    flg_req = "no"

    
////    disabeled();
//    setButtonImages();
    return false;





}

//function enabelgrid ()

//{

//var klen1 = document.getElementById("hdsviewgrid").childNodes[0].childNodes[0].childNodes.length - 1;

// for (i = 0; i <= klen1 - 1; i++) {
// document.getElementById('pr_' + i).disabled=false;
//             document.getElementById('de_' + i).disabled=false;
////             document.getElementById('up_' + i).value
//            
// }


//}

function disabelgrid ()

{

var klen1 = document.getElementById("hdsviewgrid").childNodes[0].childNodes[0].childNodes.length - 1;

 for (i = 0; i <= klen1 - 1; i++) {
 document.getElementById('pr_' + i).disabled=true;
             document.getElementById('de_' + i).disabled=true;
//             document.getElementById('up_' + i).value
            
 }

}

////function cleargrid()
//{
//var klen1 = document.getElementById("hdsviewgrid").childNodes[0].childNodes[0].childNodes.length - 1;

// for (i = 0; i <= klen1 - 1; i++) {
// document.getElementById('pr_' + i).value="" ;
//             document.getElementById('de_' + i).value="";
//            document.getElementById('ref_' + i).value=""; 
//               document.getElementById('up_' + i).value="i"; 
//            }

//}