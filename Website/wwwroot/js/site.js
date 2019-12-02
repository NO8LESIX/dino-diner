// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.


/*
 * Side-nav overlay experiment code 
 * https://www.w3schools.com/howto/howto_js_sidenav.asp
 */

//opens and resizes objects from the left of the screen
function openNav() {
    document.getElementById("Sidenav").style.width = "250px";
    document.getElementById("content").style.width = "1fr";
    document.body.style.backgroundColor = "rgba(0,0,0,0.4)";
}

//closes navbar to the left of the screen
function closeNav() {
    document.getElementById("Sidenav").style.width = "0";
    document.getElementById("content").style.width = "1fr";
    document.body.style.backgroundColor = "white";
}

//end Side-nav overlay experiment