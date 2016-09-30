define(['Helper/GetFamilyMembers'], function(GetFamilyMembers) {
    function drawFamilyTree() {
        var stage = initializeStage(),
            layer = new Kinetic.Layer(),
            root = GetFamilyMembers.findRoot(),
            queue = [root],
            xShift = 140,
            radius = 5,
            fatherName,
            motherName,
            fatherShape,
            motherShape,
            parentsConnection,
            family;

        while(queue.length > 0) {
            family = queue.shift();

            if(family.getFather()) {
                fatherName = drawNameOfFamilyMember(family.getPositionX(), family.getPositionY(), family.getFather());
                fatherShape = drawShapeOfFamilyMember(family.getPositionX(), family.getPositionY(), radius);
            }

            if(family.getMother()) {
                motherName = drawNameOfFamilyMember(family.getPositionX() + xShift, family.getPositionY(), family.getMother());
                motherShape = drawShapeOfFamilyMember(family.getPositionX() + xShift, family.getPositionY(), radius * 3);
            }

            // If parents are no leafs (if they have children).
            if(family.getChildren()) {
                parentsConnection = drawConnectionBetweenParents(family.getPositionX() + 120, family.getPositionY() + 15,
                        family.getPositionX() + xShift, family.getPositionY() + 15);

                for (var i = 0; i < family.getChildren().length; i++) {

                   // If there is more than one child.
                    if(i > 0) {
                        family.getChildren()[i].setPositionX(family.getPositionX() + xShift * i)
                    }

                    family.getChildren()[i].setPositionY(family.getPositionY() + 100);
                    queue.push(family.getChildren()[i]);

                    if(family.isChildFemale === true) {
                        connectParentsWithChildren(parentsConnection, family.getChildren()[i].getPositionX() + xShift + 50,
                            family.getChildren()[i].getPositionY(), layer);
                    }
                    else {
                        connectParentsWithChildren(parentsConnection, family.getChildren()[i].getPositionX() + 50,
                            family.getChildren()[i].getPositionY(), layer);
                    }
                }
            }

            layer.add(fatherName, fatherShape, motherName, motherShape, parentsConnection);
            stage.add(layer);
        }

        return stage.add(layer);
    }

    function connectParentsWithChildren(parentsConnection, childPositionX, childPositionY, layer) {
        var parentConnectionX1 = parentsConnection.attrs.points[0],
            parentConnectionY1 = parentsConnection.attrs.points[1],
            parentConnectionX2 = parentsConnection.attrs.points[2],
            parentConnectionY2 = parentsConnection.attrs.points[3],
            childConnectionX = (parentConnectionX1 + parentConnectionX2) / 2,
            childConnectionY = (parentConnectionY1 + parentConnectionY2) / 2;

        layer.add(drawConnectionBetweenParentsAndChildren(childConnectionX, childConnectionY, childPositionX, childPositionY),
            drawArrow(childPositionX, childPositionY, childPositionX - 6, childPositionY - 6,
                    childPositionX + 6, childPositionY - 6));
    }

    function initializeStage() {
        return new Kinetic.Stage({
            container: 'canvas-container',
            width: 800,
            height: 500
        });
    }

    function drawShapeOfFamilyMember(x, y, radius) {
        return new Kinetic.Rect({
            x: x,
            y: y,
            width: 120,
            height: 30,
            stroke: 'yellowgreen',
            cornerRadius: radius
        });
    }

    function drawNameOfFamilyMember(x, level, name) {
        return new Kinetic.Text({
            x: x,
            y: level,
            text: name,
            padding: 10,
            fill: '#555',
            align: 'center'
        });
    }

    function drawConnectionBetweenParents(x1, y1, x2, y2) {
        return new Kinetic.Line({
            points: [x1, y1, x2, y2],
            stroke: 'yellowgreen',
            strokeWidth: 2
        });
    }

    function drawConnectionBetweenParentsAndChildren(x1, y1, x2, y2) {
        return new Kinetic.Line({
            points: [x1, y1, x1, y1 + 30, x2, y1 + 30, x2, y2],
            stroke: 'yellowgreen',
            strokeWidth: 2,
            lineJoin: 'round',
            tension: 0.3
        });
    }

    function drawArrow(x1, y1, x2, y2, x3, y3) {
        return new Kinetic.Line({
            points: [x1, y1, x2, y2, x3, y3],
            stroke: 'yellowgreen',
            fill: 'yellowgreen',
            strokeWidth: 2,
            closed: true
        });
    }

    return {
        drawFamilyTree: drawFamilyTree
    };
});