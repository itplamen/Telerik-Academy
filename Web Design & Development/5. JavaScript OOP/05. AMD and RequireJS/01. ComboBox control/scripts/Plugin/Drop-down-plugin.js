define(['jQuery'], function() {
    $.fn.dropdown = function() {
        var $this = $(this),
            $selectedItem = $('<div id="selected"/>')
                .append($($this.children()[0]).clone()
                    .attr('id', 'selected-item')),
            $unselectedItems = $($this.children())
                .filter(':not(#selected-item)');

        $this.prepend($selectedItem);

        $selectedItem.on('click', function() {
            $unselectedItems.slideToggle();
        });

        $unselectedItems.on('click', function() {
            $selectedItem.html($(this).clone());
            $unselectedItems.slideToggle();
        });

        return $this;
    };
});