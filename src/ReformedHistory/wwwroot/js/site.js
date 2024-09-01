document.addEventListener("DOMContentLoaded", function () {
    // Get the button
    const backToTopBtn = document.getElementById("backToTopBtn");

    // Check the scroll position when the page loads
    checkScrollPosition();

    // When the user scrolls down 20px from the top of the document, show the button
    window.onscroll = function () {
        checkScrollPosition();
    };

    function checkScrollPosition() {
        if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
            backToTopBtn.style.display = "flex"; // Show the button as a flex element
        } 
        else {  
            backToTopBtn.style.display = "none"; // Hide the button
        }
    }

    // When the user clicks on the button, scroll to the top of the document
    backToTopBtn.addEventListener("click", function () {
        window.scrollTo({
            top: 0,
            behavior: 'smooth'
        });
    });
});
