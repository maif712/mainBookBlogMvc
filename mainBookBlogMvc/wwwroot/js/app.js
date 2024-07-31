
document.addEventListener("DOMContentLoaded", () => {

    // Limits the product card text
    const limit = 200
    const allProductCardsPara = document.querySelectorAll(".product-card__para")
    allProductCardsPara.forEach(item => {
        const text = item.innerText
        if (text.length > limit) {
            item.innerText = `${text.slice(0, limit)} ...`
        }
    })


    //Active navigtion
    const allNavLinks = document.querySelectorAll(".header__nav-link")
    const currentLocation = window.location.href
    const rootLocation = `${window.location.origin}/`

    allNavLinks.forEach(link => {
        if (link.href == currentLocation || link.href == `${rootLocation}index.html` && currentLocation == rootLocation) {
            link.classList.add("active")
        }

    })
})
