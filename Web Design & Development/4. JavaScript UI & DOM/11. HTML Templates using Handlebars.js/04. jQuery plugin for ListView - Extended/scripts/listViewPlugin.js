(function($) {
    $.fn.listView = function(items) {
        var $this = $(this),
            template = Handlebars.compile($this.html()),
            html = '',
            itemIndex;

        for (itemIndex in items) {
            html += template(items[itemIndex]);
        }

        $this.html(html);
        return $this;
    };
}(jQuery));