function showgrid() {
    var searchsignitext = document.getElementById('searchsignificator').value;
  if (document.getElementById('horpalnet').selectedIndex == '0')
   {
      if (document.getElementById('horrashi').selectedIndex == '0') 
      {
          if (document.getElementById('horhouse').selectedIndex == '0') 
          {
              if (document.getElementById('searchsignificator').value == '') {
                  alert('not selected');
              }
              else {
                  datafortable = document.getElementById('searchsignificator').value;
              }
             
             
          }
          else 
          {
              datafortable = document.getElementById('horhouse').value;
                }
         } 
      
      
         else {
             datafortable = document.getElementById('horrashi').value;
                 }
      
}

  else
   {
      datafortable =document.getElementById('horpalnet').value;
  }
  
 
  
      document.getElementById('hs').value = datafortable;
      var res = horarysignificator.bindgirdfor(datafortable);


  }

  function clearall() {

      if (document.getElementById('horpalnet').selectedIndex !== '0') {
          document.getElementById('horrashi').selectedIndex = '0';
          document.getElementById('horhouse').selectedIndex = '0';
          document.getElementById('searchsignificator').value = "";
          return false;
      }
  }

  function clearall2() {
          if (document.getElementById('horrashi').selectedIndex !== '0') {
              document.getElementById('horpalnet').selectedIndex = '0';
              document.getElementById('horhouse').selectedIndex = '0';
              document.getElementById('searchsignificator').value = "";
              return false;
          }
      }
      function clearall3() {
      if (document.getElementById('horhouse').selectedIndex !== '0') {
          document.getElementById('horpalnet').selectedIndex = '0';
          document.getElementById('horrashi').selectedIndex = '0';
          document.getElementById('searchsignificator').value = "";
          return false;
      }
     
  }
  function clearall4() {
      if (document.getElementById('searchsignificator').value !== '') {
          document.getElementById('horpalnet').selectedIndex = '0';
          document.getElementById('horrashi').selectedIndex = '0';
          document.getElementById('horhouse').selectedIndex = '0';
          return false;
      }

  }
