define(function () {
    var Circle = (function () {
        function Circle(x, y, radius, strokeColor, fillColor, strokeWidth) {
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.strokeColor = strokeColor;
            this.fillColor = fillColor;
            this.strokeWidth = strokeWidth;
        }

        Circle.prototype.getX = function () {
            return this.x;
        };

        Circle.prototype.getY = function () {
            return this.y;
        };

        Circle.prototype.getRadius = function () {
            return this.radius;
        };

        Circle.prototype.getStrokeColor = function() {
            return this.strokeColor;
        };

        Circle.prototype.getFillColor = function() {
            return this.fillColor;
        };

        Circle.prototype.getStrokeWidth = function() {
            return this.strokeWidth;
        };

            Circle.prototype.draw = function () {
            var circle = new Kinetic.Circle({
                x: this.x,
                y: this.y,
                radius: this.radius,
                stroke: this.strokeColor,
                fill: this.fillColor,
                strokeWidth: this.strokeWidth
            });

            return circle;
        };

        return Circle;
    }());

    return Circle;
});