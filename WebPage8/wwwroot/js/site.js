
$(document).ready(function () {
    $('.owl-carousel').owlCarousel({
        loop: true,
        margin: 10, autoplay: true,
        responsiveClass: true,
        responsive: {
            500: {
                items: 1,
                nav: true
            },
            600: {
                items: 2,
                nav: true
            },
            1000: {
                items: 3,
                nav: true,
                loop: true,
                margin: 20
            }
        }
    });
});

$(document).ready(function () {
    // Page scrolling feature
    $('a.page-scroll').bind('click', function (event) {
        var link = $(this);
        $('html, body').stop().animate({
            scrollTop: $(link.attr('href')).offset().top - 50
        }, 500);
        event.preventDefault();
    });

    $('body').scrollspy({
        target: '.navbar-fixed-top',
        offset: 80
    });
    $('.carousel').carousel({
        interval: 5000,
        pause: false
    })
});

$(document).ready(function () {
    $(window).scroll(function () { // check if scroll event happened
        if ($(document).scrollTop() > 100) { // check if user scrolled more than 50 from top of the browser window

            $(".navbar-fixed-top").css("background-color", "#fbfbfb"); // if yes, then change the color of class "navbar-fixed-top" to white (#f8f8f8)
            $('.logo').addClass('small-logo2');
            $('.landing-page .navbar-nav > li > a').css("color", "#2e2e2e")
            $('.navbar.navbar-static-top a, .nav.navbar-nav li a').css("color", "#2e2e2e")
        } else {
            $(".navbar-fixed-top").css("background-color", "transparent"); // if not, change it back to transparent
            $('.logo').removeClass('small-logo2');
            $('.landing-page .navbar-nav > li > a').css("color", "#fff")
            $('.navbar.navbar-static-top a, .nav.navbar-nav li a').css("color", "#fff")
        }
    });
});