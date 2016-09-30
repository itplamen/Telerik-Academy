var GlobalVariables = (function() {
    var $container = $('#container'),
        elementsID = [$container.attr('id')];

    return {
        $container: $container,
        elementsID: elementsID,
        childCounter: 1
    };
}());