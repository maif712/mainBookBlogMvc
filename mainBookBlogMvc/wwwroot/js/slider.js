

document.addEventListener("DOMContentLoaded", () => {

    // Slider navigation
    const sliderPrevBtn = document.querySelector(".slider__btn--prev")
    const sliderNextBtn = document.querySelector(".slider__btn--next")
    const sliderContainer = document.querySelector(".slider-wrapper")

    sliderNextBtn.addEventListener("click", () => {
        const allSliderCards = document.querySelectorAll(".slider-card")
        sliderContainer.appendChild(allSliderCards[0])
    })

    sliderPrevBtn.addEventListener("click", () => {
        const allSliderCards = document.querySelectorAll(".slider-card")
        sliderContainer.prepend(allSliderCards[allSliderCards.length - 1])
    })



    // Limit the slider book card description
    const sliderCardsDescription = document.querySelectorAll(".slider-card__para")
    const limit = 200;
    sliderCardsDescription.forEach(des => {
        const text = des.innerText
        if(text.length > limit) {
            des.innerText = `${text.slice(0, limit)} ...`
        }
    })
})