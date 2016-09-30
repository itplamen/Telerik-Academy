define(['MainModules/Navigation', 'MainModules/GlobalVariables', 'Controllers/DeleteTask', 'Controllers/EditTask',
    'Helper/FindTask'], function(Navigation, GlobalVariables, DeleteTask, EditTask, FindTask) {

    function showTask($selectedTaskFromListBox) {
        if(Navigation.$showCurrentTaskBox.html() !== '') {
            Navigation.$showCurrentTaskBox.empty();
        }

        generateCurrentTask($selectedTaskFromListBox);

        // Onclick $deleteCurrentTaskBtn
        $('#delete-task').on('click', function() {
            Navigation.$tasksListBox.css('display', 'block');
            Navigation.$createTaskBox.css('display', 'none');
            Navigation.$showCurrentTaskBox.css('display', 'none');
            Navigation.$editCurrentTaskBox.css('display', 'none');
            DeleteTask.deleteTask($('#current-task'));
        });

        // Onclick $editCurrentTaskBtn
        $('#edit-task-btn').on('click', function() {
            Navigation.$editCurrentTaskBox.css('display', 'block');
            Navigation.$createTaskBox.css('display', 'none');
            Navigation.$tasksListBox.css('display', 'none');
            Navigation.$showCurrentTaskBox.css('display', 'none');
            EditTask.editTask($('#current-task'));
        });
    }

    function generateCurrentTask($selectedTaskFromListBox) {
        var taskIndex = FindTask.findTaskFromListOfTasks($selectedTaskFromListBox);
        var $currentTaskTittle = $('<p class="currentTaskTitle"/>').html(GlobalVariables.listOfTasks[taskIndex].getTitle());
        var $currentTaskContent = $('<p class="currentTaskContent"/>').html(GlobalVariables.listOfTasks[taskIndex].getContent());
        var $currentTask = $('<div id="current-task"/>').attr('class', $selectedTaskFromListBox.attr('id')).append($currentTaskTittle, $currentTaskContent);
        var $deleteCurrentTaskBtn = $('<button id="delete-task">X</button>');
        var $editCurrentTaskBtn = $('<button id="edit-task-btn">Edit</button>');

        Navigation.$showCurrentTaskBox.append($deleteCurrentTaskBtn, $editCurrentTaskBtn, $currentTask);
    }

    return {
        showTask: showTask
    };
});