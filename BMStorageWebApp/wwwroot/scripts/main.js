
window.onscroll = function() {stickyFunction()};

var header = document.getElementById("myHeader");
var sticky = header.offsetTop;

var bodyWidth = document.getElementsByTagName("Body").width;

var siteWidth =  document.getElementsByClassName("parallax-home").width;


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
  document.getElementById("myNav").style.width = bodyWidth;
}
function closeNav() {
  document.getElementById("myNav").style.height = "0%";
}

function openCSNav() {
  scrollToTop();
  document.getElementById("myNav").style.height = "100%";
  document.getElementById("myNav").style.width = "48%";
}

function closeCSNav() {
  document.getElementById("myNav").style.height = "0%";
}

function scrollToTop() { 
   $(window).scrollTop(0); 
  }