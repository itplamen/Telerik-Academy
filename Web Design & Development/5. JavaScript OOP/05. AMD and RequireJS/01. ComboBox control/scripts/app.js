(function() {
    require.config({
        paths: {
            'handlebars': 'libs/handlebars-v3.0.3',
            'jQuery': 'libs/jquery-2.1.3.min',
            'data' : 'Data/Data',
            'template': 'Template/ComboBox-template',
            'dropDownPlugin': 'Plugin/Drop-down-plugin'
        }
    });

    require(['template', 'dropDownPlugin'], function(Template, DropDownPlugin) {
        $('#combo-box').dropdown();
    });
}());