define(['Navigation/GlobalVariables', 'Navigation/GlobalConstants', 'MainModules/Rectangle', 'MainModules/Line',
    'MainModules/Circle'], function(GlobalVariables, GlobalConstants, Rectangle, Line, Circle) {

    function drawShape() {
        var stage = initializeStage();
        var layer = new Kinetic.Layer();
        var shape;

       if(GlobalVariables.selectedShape === GlobalConstants.RECTANGLE || GlobalVariables.selectedShape === GlobalConstants.LINE ||
           GlobalVariables.selectedShape === GlobalConstants.CIRCLE) {
           switch (GlobalVariables.selectedShape) {
               case GlobalConstants.RECTANGLE:
                   shape = new Rectangle(GlobalVariables.x, GlobalVariables.y, GlobalVariables.width, GlobalVariables.height,
                       GlobalVariables.selectedStrokeColor.value, GlobalVariables.selectedFillColor.value, GlobalVariables.selectedStrokeWidth.value);
                   break;
               case GlobalConstants.LINE:
                   shape = new Line(GlobalVariables.x, GlobalVariables.y, GlobalVariables.x2, GlobalVariables.y2,
                       GlobalVariables.selectedStrokeColor.value, GlobalVariables.selectedStrokeWidth.value);
                   break;
               case GlobalConstants.CIRCLE:
                   shape = new Circle(GlobalVariables.x, GlobalVariables.y, GlobalVariables.radius ,
                       GlobalVariables.selectedStrokeColor.value, GlobalVariables.selectedFillColor.value, GlobalVariables.selectedStrokeWidth.value);
                   break;
               default: alert('INVALID SHAPE!!!');
                   break;
           }

           layer.add(shape.draw());
           stage.add(layer);
       }
    }

    function initializeStage() {
        var stage = new Kinetic.Stage({
            container: 'canvas-container',
            width: 800,
            height: 500
        });

        return stage;
    }

    return {
        draw: drawShape
    };
});