define(['MainModules/GlobalVariables', 'MainModules/Task', 'MainModules/Navigation', 'Controllers/Message',
    'Helper/CheckFields'] , function(GlobalVariables, Task, Navigation, Message, CheckFields) {

    function onCreateNewTaskBtn($title, $content) {
        if(CheckFields.areAllFieldsFilled($title, $content) === true) {
            GlobalVariables.listOfTasks.push(new Task($title.val(), $content.val(), GlobalVariables.taskNumber));
            appendTaskToDocument($title, $content, GlobalVariables.taskNumber);
            removeValuesFromFields($title, $content);

            GlobalVariables.taskNumber++;
        }
    }

    function appendTaskToDocument($title, $content, id) {
        var $taskTitle = $('<p class="taskTitle"/>').html(formatFieldLength($title));
        var $taskContent = $('<p class="taskContent"/>').html(formatFieldLength($content));
        var $createdTask = $('<div class="task"/>').attr('id', id).append($taskTitle, $taskContent);

        Navigation.$tasksListBox.append($createdTask);
        Message.taskCreated();
    }

    function formatFieldLength($field) {
        if($field.val().length > 30) {
            return $field.val().substr(0, 30) + '...';
        }
        else {
            return $field.val();
        }
    }

    function removeValuesFromFields($title, $content) {
        $title.val('');
        $content.val('');
    }

    return {
        onCreateNewTaskBtn: onCreateNewTaskBtn
    };
});