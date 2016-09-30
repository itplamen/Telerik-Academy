(function($) {
    $.fn.listView = function(items) {
        var $this = $(this),
            templateID = '#' + $(this).attr('data-template'),
            template = Handlebars.compile($(templateID).html()),
            html = '',
            itemIndex;

        for (itemIndex in items) {
            html += template(items[itemIndex]);
        }

        $this.html(html);
        return $this;
    };
}(jQuery));