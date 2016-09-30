define(['MainModules/GlobalVariables', 'Controllers/Message', 'MainModules/Navigation',
    'Helper/FindTask'], function(GlobalVariables, Message, Navigation, FindTask) {

    function deleteTask($currentTask) {
        var taskIndex = FindTask.findTaskFromListOfTasks($currentTask);
        Navigation.$tasksListBox.find('#' + $currentTask.attr('class')).remove();
        $currentTask.remove();
        GlobalVariables.listOfTasks.splice(taskIndex, 1);
        Message.taskDeleted();
    }

    return {
        deleteTask: deleteTask
    }
});