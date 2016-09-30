window.onload = function() {
    var x = 10,
        y = 10,
        width = 320,
        height = 110,
        fontSize = 40,
        borderRadius = 15;

    var paper = Raphael(x, y, width - 100, height);

    drawRect(paper, x + 85, y + 15, width - 220, 50, borderRadius);
    drawText(paper, x + 40, y + 40, fontSize);
};

function drawRect(paper, x, y, width, height, borderRadius) {
    paper.rect(x, y, width, height, borderRadius)
        .attr({
            fill: '#ec2828',
            stroke: 'none'
        });
}

function drawText(paper, x, y, fontSize) {
    paper.text(x + 5, y, 'You')
        .attr({
            'font-size': fontSize,
            'font-weight': 'bold',
            fill: '#4b4b4b'
        });

    paper.text(x + 95, y, 'Tube')
        .attr({
            'font-size': fontSize,
            'font-weight': 'bold',
            fill: '#ffffff'
        });
}