$(function() {
    var url, student, $info, $documentFragment, $liItem;

    url = 'http://localhost:3000/students';
    $info = $('#info');

    $('#add-student').on('click', function() {
        student  = {
            name: $('#name').val(),
            grade: $('#grade').val()
        };

        HttpRequest.postJSON(url, student)
            .then(function(data) {
                $info.append('<li class="added-student">' + 'Student: ' + data.name + ' with grade: ' + data.grade +
                    ' was added successfully!' + '</li>');
            },
            function() {
                alert('Cannot add student!');
            });
    });

    $('#get-all-students').on('click', function() {
        HttpRequest.getJSON(url)
            .then(function(data) {
                $documentFragment = $(document.createDocumentFragment());
                $liItem = $('<li/>');
                $documentFragment.append('<li>' + '-------------------- All students --------------------' + '</li>');

                for (var i = 0; i < data.students.length; i++) {
                    $liItem.html('Name: ' + data.students[i].name + ', grade: ' + data.students[i].grade);
                    $documentFragment.append($liItem.clone(true));
                }

                $documentFragment.append('<li>' + '----------------------------------------' + '</li>');
                $info.append($documentFragment);
            },
            function() {
                alert('Cannot get students!');
            });
    });
});