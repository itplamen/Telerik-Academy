define(['MainModules/GlobalVariables', 'MainModules/Snake', 'MainModules/Food'], function(GlobalVariables, Snake, Food) {
    function update(snake) {
        if(snake.getHeadPosition().x === Food.foodCoordinates.x && snake.getHeadPosition().y === Food.foodCoordinates.y) {
            Food.generateNewCoordinates();
            snake.snakeGrow();
            updatePoints();
        }
    }

    function updatePoints() {
        GlobalVariables.points += 10;
        GlobalVariables.pointsField.innerHTML = GlobalVariables.points.toString();
    }

    return {
        update: update
    }
});