(function() {
    $('#add-btn').on('click', function() {
        var parentID = $('#parent-id').val();
        DomModule.appendElementToParent(parentID);
    });

    $('#remove-btn').on('click', function() {
        var elementID = $('#element-id').val();
        DomModule.removeElement(elementID);
    });

    $('#add-multiple-elements-btn').on('click', function() {
        var parentID = $('#parent-id').val();
        DomModule.addMultipleElements(100, parentID);
    });
}());