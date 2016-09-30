define(['MainModules/Position', 'MainModules/GlobalConstants'], function(Position, GlobalConst) {
    var Snake = (function() {
        function createSnake() {
            this.head = new Position(this.startX, this.startY);
            this.snakeBody  = new Array(this.snakeLength);

            for (var i = 0; i < this.snakeLength; i++) {
                this.snakeBody[i] = new Position(this.startX - GlobalConst.BLOCK_SIZE * (i + 1), this.startY);
            }
        }

        function Snake() {
            this.head = null;
            this.snakeBody = [];
            this.startX = 100;
            this.startY = 20;
            this.snakeLength = GlobalConst.SNAKE_LENGTH;
            this.position = {
                x: 1,
                y: 0
            };
            createSnake.call(this);
        }

        Snake.prototype.drawSnake = function(context) {
            for (var i = 0; i < this.snakeBody.length; i++) {
                if (i === 0 ) {
                    context.fillStyle = 'darkgreen';
                }
                else {
                    context.fillStyle = 'green';
                }

                context.beginPath();
                context.rect(this.snakeBody[i].x, this.snakeBody[i].y, GlobalConst.BLOCK_SIZE, GlobalConst.BLOCK_SIZE);
                context.fill();
            }
        };

        Snake.prototype.moveSnake = function() {
            this.snakeBody.pop();
            this.snakeBody.unshift(new Position(this.head.x, this.head.y));
            this.head.x += this.position.x * GlobalConst.BLOCK_SIZE;
            this.head.y += this.position.y * GlobalConst.BLOCK_SIZE;
        };

        Snake.prototype.moveUp = function() {
            this.position = {
                x: 0,
                y: -1
            };
        };

        Snake.prototype.moveDown = function() {
            this.position = {
                x: 0,
                y: 1
            };
        };

        Snake.prototype.moveLeft = function() {
            this.position = {
                x: -1,
                y: 0
            };
        };

        Snake.prototype.moveRight = function() {
            this.position = {
                x: 1,
                y: 0
            };
        };

        Snake.prototype.getPosition = function() {
            return this.position;
        };

        Snake.prototype.getHeadPosition = function() {
            return {
                x: this.head.x,
                y: this.head.y
            };
        };

        Snake.prototype.snakeGrow = function() {
            this.snakeBody.push(new Position(this.snakeBody[this.snakeBody.length - 1].x, this.snakeBody[this.snakeBody.length - 1].y));
        };

        return Snake;
    }());

    return Snake;
});