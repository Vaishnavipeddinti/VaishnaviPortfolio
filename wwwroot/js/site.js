// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//Toggle Functionality
function toggleDetails(element) {
    element.classList.toggle('expanded');
    var details = element.querySelector('.award-details, .course-details');
    var detailsInner = details.querySelector('.award-details-inner, .course-details-inner');
    if (element.classList.contains('expanded')) {
        details.style.maxHeight = detailsInner.scrollHeight + "px";
    } else {
        details.style.maxHeight = "0";
    }
}


// Sidebar functionality
document.addEventListener('DOMContentLoaded', function () {
    const sections = document.querySelectorAll('section');
    const navLinks = document.querySelectorAll('#sidebar a');

    function changeLinkState() {
        let index = sections.length;
        while (--index && window.scrollY + 50 < sections[index].offsetTop) { }
        navLinks.forEach((link) => link.classList.remove('active'));
        navLinks[index].classList.add('active');
    }

    changeLinkState();
    window.addEventListener('scroll', changeLinkState);

    // Menu Dropdown Functionality
    var dropdownElementList = [].slice.call(document.querySelectorAll('.dropdown-toggle'))
    var dropdownList = dropdownElementList.map(function (dropdownToggleEl) {
        return new bootstrap.Dropdown(dropdownToggleEl)
    })
});



//For Readmore functionality
document.addEventListener('DOMContentLoaded', function () {
    const readMoreBtns = document.querySelectorAll('.read-more-btn');
    readMoreBtns.forEach(btn => {
        btn.addEventListener('click', function (e) {
            e.preventDefault();
            const card = this.closest('.card');
            const description = card.querySelector('.project-description');
            const descriptionInner = description.querySelector('p');

            if (!description.classList.contains('expanded')) {
                description.classList.add('expanded');
                this.textContent = 'Read Less';
                description.style.maxHeight = descriptionInner.scrollHeight + "px";
                card.style.height = card.scrollHeight + "px";
            } else {
                description.classList.remove('expanded');
                this.textContent = 'Read More';
                description.style.maxHeight = "100px"; // Same as initial max-height in CSS
                card.style.height = "";
            }

            // Fade out the button briefly during transition
            this.style.opacity = '0';
            setTimeout(() => {
                this.style.opacity = '1';
            }, 150);
        });
    });
});