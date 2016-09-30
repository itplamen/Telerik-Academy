define(['GlobalConstants', 'SuperMario', 'kinetic', 'raphael'], function(GlobalConstants, SuperMario, Kinetic, Raphael) {
    'use strict';

    function startGame() {
        var BACKGROUND_IMAGE = 'images/background.jpg',
            canvasContainer = document.getElementById('canvas-container'),
            paper = initializeBackground(GlobalConstants.CANVAS_X, GlobalConstants.CANVAS_Y,
                GlobalConstants.CANVAS_WIDTH, GlobalConstants.CANVAS_HEIGHT, BACKGROUND_IMAGE),
            stage = initializeStage(GlobalConstants.CANVAS_WIDTH, GlobalConstants.CANVAS_HEIGHT),
            layer = new Kinetic.Layer();

        canvasContainer.style.width = GlobalConstants.CANVAS_WIDTH;
        canvasContainer.style.height = GlobalConstants.CANVAS_HEIGHT;

        var superMario = new SuperMario(100, 495);
        var sprite = superMario.getSprite();

        layer.add(sprite);
        stage.add(layer);
        sprite.start();

        window.addEventListener('keydown', function(event) {
            event = event || window.event;

            switch (event.keyCode) {
                case 37:
                    superMario.moveLeft();
                    break;
                case 39:
                    superMario.moveRight();
                    break;
            }
        }, false);

        window.addEventListener('keypress', function(event) {
            event = event || window.event;

            switch (event.keyCode) {
                case 32:
                    superMario.jump();
                    break;
            }
        }, false);


        window.addEventListener('keyup', function(event) {
            event = event || window.event;

            switch (event.keyCode) {
                case 37:
                case 39:
                    superMario.positionFixed();
                    break;
            }

        }, false);
    }

    function initializeStage(CANVAS_WIDTH, CANVAS_HEIGHT) {
        return  new Kinetic.Stage({
            container: 'canvas-container',
            width: CANVAS_WIDTH,
            height: CANVAS_HEIGHT
        });
    }

    function initializeBackground(CANVAS_X, CANVAS_Y, CANVAS_WIDTH, CANVAS_HEIGHT, BACKGROUND_IMAGE) {
        var paper = new Raphael(CANVAS_X, CANVAS_Y, CANVAS_WIDTH, CANVAS_HEIGHT);
        paper.image(BACKGROUND_IMAGE, CANVAS_X, CANVAS_Y, CANVAS_WIDTH, CANVAS_HEIGHT);
        return paper;
    }

    return {
        startGame: startGame
    }
});