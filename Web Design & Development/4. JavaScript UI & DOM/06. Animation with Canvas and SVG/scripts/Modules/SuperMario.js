define(['GlobalConstants', 'kinetic'], function(GlobalConstants, Kinetic) {
    'use strict';

    var SuperMario = (function() {
        var IMAGE_SRC = 'images/sprite.png',
            image = new Image(),
            startY = 0,
            step = 3,
            maxJumpingHigh = 400,
            isJumping = false,
            isLanding = true,
            isMovingLeft = false,
            isMovingRight = false;

        image.src = IMAGE_SRC;

        function SuperMario(x, y) {
            this.x = x;
            this.y = y;
            this.sprite = generateSprite(this.x, this.y, image);
            startY = this.y;
        }

        function generateSprite(x, y, image) {
            return new Kinetic.Sprite({
                x: x,
                y: y,
                image: image,
                animation: 'initialState',
                animations: {
                    initialState: [
                        688, 155, 88, 119
                    ],
                    move: [
                        7, 290, 80, 119,
                        90, 290, 80, 119,
                        170, 290, 80, 119,
                        250, 290, 80, 119,
                        330, 290, 80, 119,
                        415, 290, 80, 119,
                        490, 290, 80, 119
                    ],
                    jump: [
                        7, 560, 88, 120,
                        90, 560, 88, 120,
                        170, 560, 88, 120,
                        250, 560, 88, 120,
                        330, 560, 88, 120,
                        415, 560, 88, 120,
                        490, 560, 88, 120,
                        576, 560, 88, 120,
                        655, 560, 88, 120,
                        750, 560, 88, 120,
                    ]
                },
                frameRate: 15,
                frameIndex: 0
            });
        }

        function isLeftBorderReached() {
            if(this.x < 90) {
                return true;
            }

            return false;
        }

        function isRightBorderReached() {
            if(this.x >= GlobalConstants.CANVAS_WIDTH - 90) {
                return true;
            }

            return false;
        }

        SuperMario.prototype.getX = function() {
            return this.x;
        };

        SuperMario.prototype.getY = function() {
            return this.y;
        };

        SuperMario.prototype.getSprite = function() {
            return this.sprite;
        };

        SuperMario.prototype.moveLeft = function() {
            if(!(isLeftBorderReached.call(this))) {
                if(isLanding) {
                    this.sprite.attrs.animation = "move";
                }
                else {
                    this.sprite.attrs.animation = "jump";
                }

                isMovingLeft = true;
                this.sprite.setX(this.x -= step);
                this.sprite.scaleX(-1);
            }
        };

        SuperMario.prototype.moveRight = function() {
            if(!(isRightBorderReached.call(this))) {
                if(isLanding) {
                    this.sprite.attrs.animation = "move";
                }
                else {
                    this.sprite.attrs.animation = "jump";
                }

                isMovingRight = true;
                this.sprite.setX(this.x += step);
                this.sprite.scaleX(1);
            }
        };

        SuperMario.prototype.positionFixed = function() {
            if(isLanding) {
                this.sprite.attrs.animation = "initialState";
                isMovingLeft = false;
                isMovingRight = false;
            }
        };

        SuperMario.prototype.jump = function() {
            // Prevent from multiple space key pressing
            if(isLanding) {
                this.sprite.attrs.animation = "jump";
                var self = this;
                isJumping = true;
                isLanding = false;

                var jumpAnimation = setInterval(function() {
                    if(isJumping) {
                        self.sprite.setY(self.y -= step + 2);

                        if(self.y === maxJumpingHigh) {
                            isJumping = false
                        }
                    }
                    else {
                        self.sprite.setY(self.y += step + 2);

                        if(self.y === startY) {
                            clearInterval(jumpAnimation);
                            isLanding = true;
                            self.positionFixed();
                        }
                    }
                    if(isMovingLeft && !(isLeftBorderReached.call(self))) {
                        self.sprite.setX(self.x -= step + 2);
                    }
                    else if(isMovingRight && !(isRightBorderReached.call(self))) {
                        self.sprite.setX(self.x += step + 2);
                    }
                }, 50);
            }
        };

        return SuperMario;
    }());

    return SuperMario;
});