define(['MainModules/GlobalConstants', 'Controllers/Drawer' ,'MainModules/Stone'], function(GlobalConst, Drawer, Stone) {
    var gameOverImage = createGameOverImage();

    function checkGameEnd(snake, animationFrame) {
        if(isSnakeHitStone(snake) || isSnakeEatsItself(snake) || isSnakeHitCanvasBorders(snake)) {
            clearInterval(animationFrame);
            Drawer.drawGameOverImage(gameOverImage);
            window.prompt('Enter your name: ');
        }
    }

    function isSnakeHitStone(snake) {
        for (var i = 0; i < Stone.stones.length; i++) {
            if(snake.getHeadPosition().x === Stone.stonesCoordinates[i].x &&
                snake.getHeadPosition().y === Stone.stonesCoordinates[i].y) {

                return true;
            }
        }
    }

    function isSnakeEatsItself(snake) {
        for (var i = 0; i < snake.snakeBody.length; i++) {
            if(snake.getHeadPosition().x === snake.snakeBody[i].x &&
                snake.getHeadPosition().y === snake.snakeBody[i].y) {

                return true;
            }
        }
    }

    function isSnakeHitCanvasBorders(snake) {
        if(snake.getHeadPosition().x < 0 || snake.getHeadPosition().x === GlobalConst.CANVAS.clientWidth ||
            snake.getHeadPosition().y < 0 || snake.getHeadPosition().y === GlobalConst.CANVAS.clientHeight) {

            return true;
        }
    }

    function createGameOverImage() {
        var gameOverImage = new Image();
        gameOverImage.src = 'images/game_over.png';
        gameOverImage.width = GlobalConst.GAME_OVER_WIDTH;
        gameOverImage.height = GlobalConst.GAME_OVER_HEIGHT;

        return gameOverImage;
    }

    return {
        checkGameEnd: checkGameEnd
    };
});