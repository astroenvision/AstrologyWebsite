// JavaScript Document
var angle = 0;
var int;
rotateImage();

function rotateImage() {
    int = setInterval(function() {
        angle += 3;
        $("#image").rotate(angle);
    }, 50);
}
$("#image").mouseover(function() {
    clearInterval(int);
    //$(this).stop();
}).mouseout(function() {
    rotateImage();
});