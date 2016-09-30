window.onload = function() {
    var $container = $('#container');
    var $leftArrow = $('#left-arrow');
    var $rightArrow = $('#right-arrow');
    var NUMBER_OF_SLIDES = 4;
    var slides = getSlides(NUMBER_OF_SLIDES);
    var slideIndex = 0;
    var direction = {
        left: 'left',
        right: 'right'
    };
    var animationFrame = setInterval(animation, 5000);
    $container.append(slides[slideIndex]);

    $leftArrow.on('click', function() {
        slideIndex = changeSlides($container, slideIndex, NUMBER_OF_SLIDES, slides, direction.left);
        clearInterval(animationFrame);
        animationFrame = setInterval(animation, 5000);
    });

    $rightArrow.on('click', function() {
        slideIndex = changeSlides($container, slideIndex, NUMBER_OF_SLIDES, slides, direction.right);
        clearInterval(animationFrame);
        animationFrame = setInterval(animation, 5000);
    });

    function animation() {
        slideIndex = changeSlides($container, slideIndex, NUMBER_OF_SLIDES, slides, direction.left);
    }
};

function changeSlides($container, slideIndex, numberOfSlides, slides, direction) {
    $('.slide' + slideIndex).fadeOut(1600, function() {
        this.remove();
        $container.append($(slides[slideIndex]).fadeIn(1600));
    });

    switch (direction) {
        case 'left':
            slideIndex++;
            break;
        case 'right':
            slideIndex--;
            break;
    }

    slideIndex = checkSlideIndex(slideIndex, numberOfSlides);
    return slideIndex;
}

function checkSlideIndex(slideIndex, numberOfSlides) {
    if(slideIndex >= numberOfSlides) {
        slideIndex = 0;
    }
    else if(slideIndex < 0) {
        slideIndex = numberOfSlides - 1;
    }

    return slideIndex;
}

function getSlides(numberOfSlides) {
    var slides = [];

    for (var i = 0; i < numberOfSlides; i++) {
        var slide = new Image();
        slide.src = 'images/slide' + i + '.jpg'
        slide.className = 'slide' + i;
        slide.width = 600;
        slide.height = 400;
        slide.style.borderRadius = 10 + 'px';
        slides.push(slide);
    }

    return slides;
}

