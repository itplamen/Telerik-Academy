define(function() {
    var Rectangle = (function() {

        function Rectangle(x, y, width, height, strokeColor, fillColor, strokeWidth) {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.strokeColor = strokeColor;
            this.fillColor = fillColor;
            this.strokeWidth = strokeWidth;
        }

        Rectangle.prototype.getX = function() {
            return this.x;
        };

        Rectangle.prototype.getY = function() {
            return this.y;
        };

        Rectangle.prototype.getWidth = function() {
            return this.width;
        };

        Rectangle.prototype.getHeight = function() {
            return this.height;
        };

        Rectangle.prototype.getStrokeColor = function() {
            return this.strokeColor;
        };

        Rectangle.prototype.getFillColor = function() {
            return this.fillColor;
        };

        Rectangle.prototype.getStrokeWidth = function() {
            return this.strokeWidth;
        };

        Rectangle.prototype.draw = function() {
            var rect = new Kinetic.Rect({
                x: this.x,
                y: this.y,
                width: this.width,
                height: this.height,
                stroke: this.strokeColor,
                fill: this.fillColor,
                strokeWidth: this.strokeWidth
            });

            return rect;
        };

       return Rectangle;
    }());

    return Rectangle;
});