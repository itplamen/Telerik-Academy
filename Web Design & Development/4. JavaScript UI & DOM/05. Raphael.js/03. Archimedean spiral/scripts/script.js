window.onload = function() {
    var x = 10,
        y = 10,
        width = 220,
        height = 290;

    var paper = Raphael(x, y, width, height);
    drawArchimedeanSpiral(paper, x + 90, y + 150);
};

function drawArchimedeanSpiral(paper, x, y) {
    var space = 3;
    var scale = 10;
    var cx = x;
    var cy = y;
    var STEPS_PER_ROTATION = space * 100;
    var increment = 2 * Math.PI / STEPS_PER_ROTATION;
    var angle = increment,
        newCX = 0,
        newCY = 0,
        radius = 1;

    while (angle < scale * Math.PI) {
        newCX = cx + (space * angle * Math.cos(angle));
        newCY = cy + (space * angle * Math.sin(angle));
        drawCircle(paper, newCX, newCY, radius);
        angle += increment;
    }
}

function drawCircle(paper, cx, cy, radius) {
    paper.circle(cx, cy, radius)
        .attr({
            stroke: 'black',
            fill: 'black'
        });
}