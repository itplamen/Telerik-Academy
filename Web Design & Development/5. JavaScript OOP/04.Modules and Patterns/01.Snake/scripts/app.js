(function() {
    require(['MainModules/GlobalConstants', 'MainModules/Snake', 'MainModules/Stone', 'Controllers/Drawer', 'Helper/EndGame',
        'Controllers/Updater', 'Controllers/Events'], function(GlobalConst, Snake, Stone, Drawer, EndGame, Updater, Event) {

        var snake = new Snake();
        Event.getPosition(snake);

        var animationFrame = setInterval(function() {
            GlobalConst.CONTEXT.clearRect(0, 0, GlobalConst.CONTEXT.canvas.width, GlobalConst.CONTEXT.canvas.height);
            Drawer.drawStones();
            Drawer.drawFood();
            snake.drawSnake(GlobalConst.CONTEXT);
            EndGame.checkGameEnd(snake, animationFrame);
            snake.moveSnake();
            Updater.update(snake);
        }, GlobalConst.GAME_SPEED);
    });
}());