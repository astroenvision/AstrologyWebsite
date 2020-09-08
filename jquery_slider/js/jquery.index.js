/* jquerydemo.com */

(function($) {

   var firstImage = $('#slider-content .slider-img:first').index();
   var lastImage = $('#slider-content .slider-img:last').index();

   var currentImage = firstImage
   var nextImage = firstImage + 1
   var prevImage = lastImage

   var sliderImages = $('#slider-content .slider-img');
   var sliderContent = $('#slider-content');

   var sliderImageWidth = parseFloat(sliderImages.eq(0).css('width'));

   $('#button-next').click(function() {
       nextImage = currentImage == lastImage ? firstImage : currentImage + 1;
       sliderContent.animate({ "left": -nextImage * sliderImageWidth });
       currentImage = nextImage;
       e.preventDefault();
   });
   $('#button-prev').click(function() {
       prevImage = currentImage == firstImage ? lastImage : currentImage - 1;
       sliderContent.animate({ "left": -prevImage * sliderImageWidth });
       currentImage = prevImage;
       e.preventDefault();
   });
})(jQuery);