
function gethorarycalculation() {
    var sunrise = document.getElementById('hdsunrise').value;
    var sunset = document.getElementById('hdsunset').value;
    var sunrisenext = document.getElementById('hdnsunrisenext').value;

    var astrologer = document.getElementById('Hastid').value;
    var tob = document.getElementById('hdntob').value;
    var dob = document.getElementById('hdndob').value;
    var city = document.getElementById('hdncity').value;
    window.open("horary_calculation.aspx?astmail=" + astrologer + "&dob=" + dob + "&tob=" + tob + "&city=" + city + "&sunrise=" + sunrise + "&sunset=" + sunset + "&sunrisenext=" + sunrisenext + "&usermail=" + document.getElementById('hdnuser').value + "", null);
    return false;
}

function getprobablequery() {
    var sunrise = document.getElementById('hdsunrise').value;
    var sunset = document.getElementById('hdsunset').value;
    var sunrisenext = document.getElementById('hdnsunrisenext').value;
    var astrologer = document.getElementById('Hastid').value;
    var tob = document.getElementById('hdntob').value;
    var dob = document.getElementById('hdndob').value;
    var city = document.getElementById('hdncity').value;
    window.open("probable_query.aspx?astmail=" + astrologer + "&dob=" + dob + "&tob=" + tob + "&city=" + city + "&sunrise=" + sunrise + "&sunset=" + sunset + "&sunrisenext=" + sunrisenext + "&usermail=" + document.getElementById('hdnuser').value + "", null);
    return false;
}