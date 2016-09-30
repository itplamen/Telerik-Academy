define(['Navigation/GlobalVariables', 'Navigation/GlobalConstants', 'Controllers/Drawer'], function(GlobalVariables, GlobalConstants, Drawer) {
    var mouseDown = false;

    GlobalVariables.shapes.addEventListener('change', function() {
        GlobalVariables.selectedShape = getSelectedShape();
    }, false);

    GlobalVariables.selectedStrokeColor.addEventListener('change', function() {
        GlobalVariables.selectedStrokeColor = document.getElementById('stroke-color');

    }, false);

    GlobalVariables.selectedFillColor.addEventListener('change', function() {
        GlobalVariables.selectedFillColor = document.getElementById('fill-color');
    }, false);

    GlobalVariables.selectedStrokeColor.addEventListener('change', function() {
        GlobalVariables.selectedStrokeWidth = document.getElementById('stroke-width');
    }, false);

    GlobalVariables.canvasContainer.addEventListener('mousedown', function(event) {
        mouseDown = true;
        GlobalVariables.x = event.pageX - this.offsetLeft;
        GlobalVariables.y = event.pageY - this.offsetTop;

    },false);

    GlobalVariables.canvasContainer.addEventListener('mousemove', function(event) {
        if(mouseDown) {
            if(GlobalVariables.selectedShape === GlobalConstants.RECTANGLE) {
                GlobalVariables.width = (event.pageX - this.offsetLeft) - GlobalVariables.x;
                GlobalVariables.height = (event.pageY - this.offsetTop) - GlobalVariables.y;
            }
            else if(GlobalVariables.selectedShape === GlobalConstants.LINE) {
                GlobalVariables.x2 = event.pageX - this.offsetLeft;
                GlobalVariables.y2 = event.pageY - this.offsetTop;
            }
            else if(GlobalVariables.selectedShape === GlobalConstants.CIRCLE) {
                var mouseX = event.pageX - this.offsetLeft - GlobalVariables.x;
                var mouseY = event.pageY - this.offsetTop - GlobalVariables.y;
                GlobalVariables.radius = Math.sqrt(mouseX * mouseX + mouseY * mouseY);
            }

            Drawer.draw();
        }
    }, false);

    GlobalVariables.canvasContainer.addEventListener('mouseup', function() {
        mouseDown = false;
    }, false);

    function getSelectedShape() {
        for (var i = 0; i < GlobalVariables.shapes.innerHTML.length; i++) {
            if(GlobalVariables.shapes[i].selected) {
                return GlobalVariables.shapes[i].value;
            }
        }
    }
});
