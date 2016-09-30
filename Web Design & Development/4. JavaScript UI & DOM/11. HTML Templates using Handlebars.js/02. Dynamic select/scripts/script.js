window.onload = function() {
    var selectTemplate = Handlebars.compile(document.getElementById('select-template').innerHTML);
    document.getElementById('dynamic-select').innerHTML = selectTemplate({
        items: Items
    });
};