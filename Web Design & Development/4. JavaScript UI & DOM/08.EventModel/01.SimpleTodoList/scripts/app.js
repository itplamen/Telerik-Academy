(function() {
    'use strict';
    require(['MainModules/Events', 'Controllers/Message'], function(Event, Message) {
        Message.createBoxMessage();
    });
}());