define(['data', 'handlebars', 'jQuery'], function(data, Handlebars) {
    var comboBoxTemplate = Handlebars.compile($('#combo-box-template').html());
    $('#combo-box').html(comboBoxTemplate({
        persons: data
    }));
});