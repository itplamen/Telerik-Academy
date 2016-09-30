define(['MainModules/Snake'], function(Snake) {
    function getPosition(snake) {
        window.addEventListener('keydown', function(event) {
            event = event || window.event;

            switch (event.keyCode) {
                case 38:
                    if(snake.getPosition().y !== 1) {
                        snake.moveUp();
                    }
                    break;
                case 40:
                    if(snake.getPosition().y !== -1) {
                        snake.moveDown();
                    }
                    break;
                case 37:
                    if(snake.getPosition().x !== 1) {
                        snake.moveLeft();
                    }
                    break;
                case 39:
                    if(snake.getPosition().x !== -1) {
                        snake.moveRight();
                    }
                    break;
            }
        }, false);
    }

    return {
        getPosition: getPosition
    };
});
