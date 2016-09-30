var Module = (function() {
    var $container, animationFrame;

    function initializeDivElements(numberOfElements) {
        $container = $('<div/>')
            .css('position', 'absolute')
            .css('left', 600 + 'px')
            .css('top', 300 + 'px');

        for (var i = 1; i <= numberOfElements; i += 1) {
            $container.append(createElement());
        }

        $('body').append($container);
        moveDivs($container);
    }

    function createElement() {
        var $div = $('<div/>')
            .html('div')
            .css('position', 'absolute')
            .css('width', 50 + 'px')
            .css('height', 50 + 'px')
            .css('border', 5 + 'px solid ' + getRandomColor())
            .css('background-color', getRandomColor())
            .css('border-radius', 30 + 'px')
            .css('text-align', 'center')
            .css('font-family', getRandomFontFamily());

        return $div;
    }

    function moveDivs($container) {
        var angle = 0,
            width = 200,
            height = 200,
            step = 2 * Math.PI / $container.children().length,
            x = null,
            y = null;

        animationFrame = setInterval(function() {
            for (var i = 0; i < $container.children().length; i++) {
                x = Math.cos(angle + (i * step)) * width;
                y = Math.sin(angle + (i * step)) * height;
                $container.children().eq(i).css('left', x + 'px');
                $container.children().eq(i).css('top', y + 'px');
            }
            angle += 0.05;
        }, 20);
    }

    function getRandomColor () {
        var SYMBOLS_IN_COLOR = 6,
            symbols = '0123456789ABCDEF'.split(''),
            color = '#',
            i;

        for (i = 1; i <= SYMBOLS_IN_COLOR; i += 1 ) {
            color += symbols[Math.floor(Math.random() * 16)];
        }

        return color;
    }

    function getRandomFontFamily() {
        var fontFamilies = ['Consolas', 'Tahoma', 'Verdana', 'Times New Roman', 'Arial'];
        return fontFamilies[Math.floor(Math.random() * fontFamilies.length)];
    }

    return {
        initializeDivElements: initializeDivElements
    };
}());