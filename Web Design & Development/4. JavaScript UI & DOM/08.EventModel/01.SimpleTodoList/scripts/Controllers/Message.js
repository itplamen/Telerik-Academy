define(function() {
    function createBoxMessage() {
        var $textMessage = $('<p id="text-message"/>');
        var $boxMessage = $('<div id="message-box"/>').append($textMessage);
        $('body').append($boxMessage);
    }

    function taskCreated() {
        showMessage('Task created!');
    }

    function taskDeleted() {
        showMessage('Task deleted!');
    }

    function taskEdited() {
        showMessage('Task edited!');
    }

    function showMessage(message) {
        var $textMessage = $('#text-message').html(message);
        $('#message-box').append($textMessage).fadeIn(1000).fadeOut(1000);
    }

    return {
        createBoxMessage: createBoxMessage,
        taskCreated: taskCreated,
        taskDeleted: taskDeleted,
        taskEdited: taskEdited
    };
});