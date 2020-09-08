function SaveLike(Flag , QuestoinID , UserID , UserEmailID)
{
    try
    {
        var NoOfLike = '0';
        if (Flag == "SaveLike")
        {
            NoOfLike = '1';
        }
      
        var ComntDtls = $("#txtComnt_" + QuestoinID).val().replace(/'/g, "\\'");
        var flag = 'INSERT';
        var pageUrl = document.location.origin;
        if (pageUrl.indexOf('localhost') > -1) {
            pageUrl = pageUrl + '/astrology'
        }
        else {
            pageUrl = "";
        }
        $.ajax({
            url: pageUrl + '/CommonMethod.aspx/SaveComment',
            type: 'POST',
            data: "{ 'Flag': '" + flag + "', 'QuestionID': '" + QuestoinID + "',  'CommentDtls': '" + ComntDtls + "','RegUserID': '" + UserID + "',  'RegEmailID': '" + UserEmailID + "' , 'Status': '" + "1" + "', 'NoOfLike': '" + NoOfLike + "'  }",
            contentType: 'application/json; charset=utf-8',
            dataType: "json",
            success: function (result) {
                if (Flag == "SaveLike") {
                    alert("Answer liked successfully!");
                }
                else
                {
                    //alert("asdsdadfsy!")
                    window.location = pageUrl + "/my-answers.html";
                    //alert("Comment saved successfully!");
                }
                
            },
            error: function (error) {
                alert(error.responseText);
            },
            async: false
        });
    }
    catch(ex)
    {
        alert(ex);
        return false;
    }
}

function ShowCommntbox(id)
{
    try
    {
        $("#divComnt_" + id).show();
    }
    catch(ex)
    {
        alert(ex);
        return false;
    }
}