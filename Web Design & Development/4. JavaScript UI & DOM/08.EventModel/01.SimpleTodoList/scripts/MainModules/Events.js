define(['MainModules/Navigation', 'Controllers/CreateTask', 'Controllers/ShowTask'] , function(Navigation, CreateTask, ShowTask) {
    Navigation.$newTaskBtn.on('click', function() {
        Navigation.$container.css('height', 480 + 'px');
        Navigation.$createTaskBox.css('display', 'block');
        Navigation.$tasksListBox.css('display', 'none');
        Navigation.$showCurrentTaskBox.css('display', 'none');
        Navigation.$editCurrentTaskBox.css('display', 'none');
    });

    Navigation.$showTasksBtn.on('click', function() {
        Navigation.$container.css('height', 480 + 'px');
        Navigation.$tasksListBox.css('display', 'block');
        Navigation.$createTaskBox.css('display', 'none');
        Navigation.$showCurrentTaskBox.css('display', 'none');
        Navigation.$editCurrentTaskBox.css('display', 'none');
    });

    Navigation.$addTaskBtn.on('click', function() {
        CreateTask.onCreateNewTaskBtn(Navigation.title, Navigation.$content);
    });

    Navigation.$hideTasksBtn.on('click', function() {
        Navigation.$createTaskBox.css('display', 'none');
        Navigation.$tasksListBox.css('display', 'none');
        Navigation.$showCurrentTaskBox.css('display', 'none');
        Navigation.$editCurrentTaskBox.css('display', 'none');
        Navigation.$container.css('height', 'defaultStatus');
    });

    Navigation.$tasksListBox.on('click', 'div.task', function() {
        Navigation.$showCurrentTaskBox.css('display', 'block');
        Navigation.$createTaskBox.css('display', 'none');
        Navigation.$tasksListBox.css('display', 'none');
        Navigation.$editCurrentTaskBox.css('display', 'none');
        ShowTask.showTask($(this));
    });
});