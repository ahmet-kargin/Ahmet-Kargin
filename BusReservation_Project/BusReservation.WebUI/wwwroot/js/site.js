$(document).ready(function () {
    $("li a").each(function () {
        if ($(this).attr("href") == window.location.pathname) {
            //$(this).css("background-color", "red")
            $(this).addClass("activeLink")
        }

    })

})

const tikla = document.querySelector(".UserLogin");
const mainPopup = document.querySelector(".main-popup");
const close = document.querySelector(".close-popup");

tikla.addEventListener("click", () => {
    mainPopup.style.display = "block";
})

// close.addEventListener("click",()=>{
//     mainPopup.style.display="none";
// })

mainPopup.addEventListener("click", e => {
    if (e.target.className == "main-popup" || e.target.className == "close-popup") {
        mainPopup.style.display = "none";
    }
})