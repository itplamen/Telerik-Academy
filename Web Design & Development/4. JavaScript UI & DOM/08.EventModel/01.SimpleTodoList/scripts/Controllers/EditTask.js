define(['MainModules/GlobalVariables', 'MainModules/Navigation', 'Controllers/Message',
    'Helper/FindTask', 'Helper/CheckFields'], function(GlobalVariables, Navigation, Message, FindTask, CheckFields) {

    function editTask($selectedTask) {
        if(Navigation.$editCurrentTaskBox.html() !== '') {
            Navigation.$editCurrentTaskBox.empty();
        }

        var taskIndex = FindTask.findTaskFromListOfTasks($selectedTask);
        generateEditBox(taskIndex);

        $('#save-edited-task-btn').on('click', function() {
            if(CheckFields.areAllFieldsFilled($('.editTitle'), $('.editContent'))) {
                saveEditedTask($selectedTask, taskIndex);
                Navigation.$editCurrentTaskBox.css('display', 'none');
                Navigation.$showCurrentTaskBox.css('display', 'block');
                Message.taskEdited();
            }
        });
    }

    function generateEditBox(taskIndex) {
        var $title = $('<input type="text" class="editTitle"/>').val(GlobalVariables.listOfTasks[taskIndex].getTitle());
        var $content = $('<textarea class="editContent"/>').html(GlobalVariables.listOfTasks[taskIndex].getContent()).css('resize', 'none');
        var $saveBtn = $('<button id="save-edited-task-btn">Save</button>');

        Navigation.$editCurrentTaskBox.append($saveBtn, $title, $content);
    }

    function saveEditedTask($selectedTask, taskIndex) {
        var $editTitle = $('.editTitle');
        var $editContent = $('.editContent');

        GlobalVariables.listOfTasks[taskIndex].setTitle($editTitle.val());
        GlobalVariables.listOfTasks[taskIndex].setContent($editContent.val());

        $selectedTask.find('.currentTaskTitle').html($editTitle.val());
        $selectedTask.find('.currentTaskContent').html($editContent.val());

        $('#' + $selectedTask.attr('class')).find('.taskTitle').html($editTitle.val());
        $('#' + $selectedTask.attr('class')).find('.taskContent').html($editContent.val());
    }

    return {
        editTask: editTask
    }
});