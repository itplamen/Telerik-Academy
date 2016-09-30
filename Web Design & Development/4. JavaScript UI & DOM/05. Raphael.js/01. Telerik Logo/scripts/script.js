window.onload = function() {
    var x = 30,
        y = 10,
        width = 320,
        height = 110;

    var paper = Raphael(x, y, width, height);

    drawText(paper, x + 150, y + 40);
    drawRegisteredTrademarkSymbol(paper, x + 225, y + 35, 6);
    drawLogo(paper);
};

function drawText(paper, x, y) {
    paper.text(x, y, 'Telerik')
        .attr({
            'font-size': 40,
            'font-weight': 'bold'
        });

    paper.text(x + 28, y + 30, 'Develop experiences')
        .attr({
            'font-size': 18
        });
}

function drawRegisteredTrademarkSymbol(paper, x, y, r) {
    paper.circle(x + 0.5, y - 0.2, r);

    paper.text(x, y, 'R')
        .attr({
            'font-weight': 'bold'
        });
}

function drawLogo(paper) {
    paper.path('M 28 37 L 40 25 L 70 50 L 55 65 L 38 50 L 65 25 L 78 37')
        .attr({
            stroke: '#5ce600',
            fill: 'none',
            'stroke-width': 7
        });
}