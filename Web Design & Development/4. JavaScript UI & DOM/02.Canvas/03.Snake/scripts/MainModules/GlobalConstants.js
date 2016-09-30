define(function() {
    var CANVAS = document.getElementById('the-canvas');
    var CONTEXT = CANVAS.getContext('2d');
    var GAME_SPEED = 150;
    var BLOCK_SIZE = 20;
    var NUMBER_OF_STONES = 30;
    var SNAKE_LENGTH = 5;
    var GAME_OVER_POSITION_X = 100;
    var GAME_OVER_POSITION_Y = 120;
    var GAME_OVER_WIDTH = 500;
    var GAME_OVER_HEIGHT = 200;
    var BLANK_POSITION = {
        x: 200,
        y: 20
    };

    return {
        CANVAS: CANVAS,
        CONTEXT: CONTEXT,
        GAME_SPEED: GAME_SPEED,
        BLOCK_SIZE: BLOCK_SIZE,
        NUMBER_OF_STONES: NUMBER_OF_STONES,
        SNAKE_LENGTH: SNAKE_LENGTH,
        GAME_OVER_POSITION_X: GAME_OVER_POSITION_X,
        GAME_OVER_POSITION_Y: GAME_OVER_POSITION_Y,
        GAME_OVER_WIDTH: GAME_OVER_WIDTH,
        GAME_OVER_HEIGHT: GAME_OVER_HEIGHT,
        BLANK_POSITION: BLANK_POSITION
    };
});