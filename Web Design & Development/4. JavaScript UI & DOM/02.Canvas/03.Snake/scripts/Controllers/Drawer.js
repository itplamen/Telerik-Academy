define(['MainModules/Stone', 'MainModules/Food', 'MainModules/GlobalConstants'], function(Stone, Food, GlobalConst) {
    function drawStones() {
        for (var i = 0; i < Stone.stones.length; i++) {
            GlobalConst.CONTEXT.drawImage(Stone.stones[i], Stone.stonesCoordinates[i].x,
                Stone.stonesCoordinates[i].y, Stone.stones[i].width, Stone.stones[i].height);
        }
    }

    function drawFood() {
        GlobalConst.CONTEXT.drawImage(Food.food, Food.foodCoordinates.x, Food.foodCoordinates.y,
            Food.food.width, Food.food.height);
    }

    function drawGameOverImage(gameOverImage) {
        GlobalConst.CONTEXT.drawImage(gameOverImage, GlobalConst.GAME_OVER_POSITION_X, GlobalConst.GAME_OVER_POSITION_Y,
            GlobalConst.GAME_OVER_WIDTH, GlobalConst.GAME_OVER_HEIGHT);
    }

    return {
        drawStones: drawStones,
        drawFood: drawFood,
        drawGameOverImage: drawGameOverImage
    };
});