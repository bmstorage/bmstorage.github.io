(function() {
    $.fn.rotateClass = function(cls1, cls2, cls3) {
      if ($(this).hasClass(cls1)) {
        return $(this).removeClass(cls1).addClass(cls2);
      } else if ($(this).hasClass(cls2)) {
        return $(this).removeClass(cls2).addClass(cls3);
      } else if ($(this).hasClass(cls3)) {
        return $(this).removeClass(cls3).addClass(cls1);
      } else {
        return $(this).toggleClass(cls1); // Default case.
      }
    }
  })(jQuery);
  
  $('#click-me').on('click', function(e) {
    $(this).rotateClass('cls-1', 'cls-2', 'cls-3');
  });