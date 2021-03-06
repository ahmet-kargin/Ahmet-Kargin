const secilen = document.querySelector("#logo");
const slide = document.querySelectorAll(".slide");
let slideNo=0;
const slidesNumber = slide.length;
secilen.addEventListener("click",e=>{
    console.log(e.target);
})

/* Slider kodları */
function previous(){
    slideNo--;
    slideShow(slideNo);
}
function next(){
    slideNo++;
    slideShow(slideNo);
}

function slideShow(slideNumber){
    slideNo = slideNumber;
    if(slideNumber>=slidesNumber){
        slideNo=0;
    }
    if(slideNumber<0){
        slideNo=slidesNumber-1;
    }
    for(let i=0; i < 4; i++){
        slide[i].style.display="none";
    }
    slide[slideNo].style.display="block";
}

slideShow(slideNo);


const tikla = document.querySelector("section");
const mainPopup = document.querySelector(".main-popup");
const close = document.querySelector(".close-popup");

tikla.addEventListener("click",()=>{
    mainPopup.style.display="block";
})


mainPopup.addEventListener("click", e =>{
    if(e.target.className=="main-popup" || e.target.className=="close-popup"){
        mainPopup.style.display="none";
    }
})