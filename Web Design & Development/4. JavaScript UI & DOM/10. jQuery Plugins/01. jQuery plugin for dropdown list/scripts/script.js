(function($) {
    $.fn.dropdown = function() {
        var $this = $(this),
            $div = $('<div class="dropdown-list-container"/>'),
            $ul = $('<ul class="dropdow-list-options"/>'),
            $li = $('<li class="dropdown-list-option"/>'),
            $showHideList = $('#show-hide-list'),
            $option = null,
            HIDDEN_STATE = 'hidden',
            SHOWN_STATE = 'shown',
            listState = HIDDEN_STATE,
            mouseOverImage = 'show-hover.png',
            mouseOutImage = 'show.png';

        for (var i = 0; i < $this.children().length; i++) {
            $option = $($this.children()[i]);
            $li.attr('data-value', $option.attr('value'))
                .html($option.html());
            $ul.append($li.clone(true));
        }

        $('body').append($div.append($ul.hide()));

        $ul.on('click', 'li.dropdown-list-option', function() {
            var childIndex = $(this).attr('data-value') - 1,
                $currentOption = $($this.children()[childIndex]);

            if($currentOption.attr('selected')) {
                $(this).css('background-color', '#4f93ef');
                $currentOption.removeAttr('selected')
            }
            else {
                $(this).css('background-color', 'red');
                $currentOption.attr('selected', 'true');
            }
        });

        $showHideList.hover(function() {
            $(this).attr('src', 'images/' + mouseOverImage);
        }, function() {
            $(this).attr('src', 'images/' + mouseOutImage);
        });

        $showHideList.on('click', function() {
            $ul.slideToggle();

            if(listState === HIDDEN_STATE) {
                mouseOverImage = 'hide-hover.png';
                mouseOutImage = 'hide.png';
                listState = SHOWN_STATE;
                $showHideList.attr('src', 'images/' + mouseOverImage);
            }
            else if(listState === SHOWN_STATE) {
                mouseOverImage = 'show-hover.png';
                mouseOutImage = 'show.png';
                listState = HIDDEN_STATE;
                $showHideList.attr('src', 'images/' + mouseOverImage);
            }
        });

        return this;
    };
}(jQuery));