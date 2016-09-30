define(['MainModules/GlobalVariables'], function(GlobalVariables) {
    function findTaskFromListOfTasks($selectedTaskFromListBox) {
        for (var index = 0; index < GlobalVariables.listOfTasks.length; index++) {
            if(GlobalVariables.listOfTasks[index].getID().toString() === $selectedTaskFromListBox.attr('id') ||
                GlobalVariables.listOfTasks[index].getID().toString() === $selectedTaskFromListBox.attr('class')) {
                return index;
            }
        }
    }

    return {
        findTaskFromListOfTasks: findTaskFromListOfTasks
    };
});