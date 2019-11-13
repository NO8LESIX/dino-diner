// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

var cells = document.getElementsByClassName("square");
for (var i = 0; i < cells; i++) {
    cells[i].addEventListener("click", onClick);
}