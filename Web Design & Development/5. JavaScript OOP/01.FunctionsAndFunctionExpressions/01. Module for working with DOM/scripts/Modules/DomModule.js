var DomModule = (function() {
    function appendElementToParent(parentID) {
        if (isIDValid(parentID)) {
            var $child = createElement(parentID);
            $('#' + parentID).append($child);
        }
        else {
            alert('Invalid ID!');
        }
    }

    function removeElement(elementID) {
        if (isIDValid(elementID)) {
            $('html').find('#' + elementID).remove();
            removeIDFromArray(elementID);
        }
        else {
            alert('Invalid ID!');
        }
    }

    function createElement(parentID) {
        var $element = $('<div/>')
            .html('#' + parentID.toString() + ' -> #child-' + GlobalVariables.childCounter.toString())
            .attr('id', 'child-' + GlobalVariables.childCounter.toString())
            .css('background-color', getRandomColor().toString())
            .on('click', function() {
                console.log('Element: ' + $(this).attr('id'));
            });

        GlobalVariables.elementsID.push($element.attr('id'));
        GlobalVariables.childCounter += 1;
        return $element;
    }

    function addMultipleElements(numberOfElements, parentID) {
        if (isIDValid(parentID)) {
            var documentFragment  = document.createDocumentFragment();

            for (var i = 1; i <= numberOfElements; i++) {
                $(documentFragment).append(createElement(parentID));
            }

            $('#' + parentID).append(documentFragment);
        }
        else {
            alert('Invalid ID!');
        }
    }

    function getRandomColor () {
        var SYMBOLS_IN_COLOR = 6,
            symbols = '0123456789ABCDEF'.split(''),
            color = '#',
            i;

        for (i = 1; i <= SYMBOLS_IN_COLOR; i += 1 ) {
            color += symbols[Math.floor(Math.random() * 16)];
        }

        return color;
    }

    function isIDValid(ID) {
        if (GlobalVariables.elementsID.indexOf(ID) !== -1) {
            return true;
        }

        return false;
    }

    function removeIDFromArray(ID) {
         GlobalVariables.elementsID.splice(GlobalVariables.elementsID.indexOf(ID), 1);
    }

    return {
        appendElementToParent: appendElementToParent,
        removeElement: removeElement,
        addMultipleElements: addMultipleElements
    };
}());