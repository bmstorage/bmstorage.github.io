
window.onscroll = function() {stickyFunction()};

var header = document.getElementById("myHeader");
var sticky = header.offsetTop;

function stickyFunction() {
  if (window.pageYOffset > sticky) {
    header.classList.add("sticky");
  } else {
    header.classList.remove("sticky");
  }
}

function openNav() {
  scrollToTop();
  document.getElementById("myNav").style.height = "100%";
}

function closeNav() {
  document.getElementById("myNav").style.height = "0%";
}

function scrollToTop() { 
   $(window).scrollTop(0); 
  }