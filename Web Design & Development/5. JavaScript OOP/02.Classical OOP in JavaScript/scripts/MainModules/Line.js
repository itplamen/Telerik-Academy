define(function () {
    var Line = (function () {
        function Line(x1, y1, x2, y2, strokeColor, strokeWidth) {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.strokeColor = strokeColor;
            this.strokeWidth = strokeWidth;
        }

        Line.prototype.getX1 = function () {
            return this.x1;
        };

        Line.prototype.getY1 = function () {
            return this.y1;
        };

        Line.prototype.getX2 = function () {
            return this.x2;
        };

        Line.prototype.getY2 = function () {
            return this.y2;
        };

        Line.prototype.getStrokeColor = function() {
            return this.strokeColor;
        };

        Line.prototype.getStrokeWidth = function() {
            return this.strokeWidth;
        };

        Line.prototype.draw = function () {
            var line = new Kinetic.Line({
                points: [this.x1, this.y1, this.x2, this.y2],
                stroke: this.strokeColor,
                strokeWidth: this.strokeWidth
            });

            return line;
        };

        return Line;
    }());

    return Line;
});