$(document).ready(function () {
    $("li a").each(function () {
        if ($(this).attr("href") == window.location.pathname){
            //$(this).css("background-color", "red")
            $(this).addClass("activeLink")
        }

    })
        
})