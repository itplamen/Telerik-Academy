$(function() {
    var url, student, $info;

    url = 'http://localhost:3000/students/';
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

    function onBtnClick() {


        HttpRequest.deleteJSON(url)
            .then(function(data) {
                console.log(data)
            },
            function(error) {
                alert('Cannot delete student!');
            });
    }

    $('#get-all-students').on('click', function() {
        var student, $documentFragment, $liItem, $deleteBtn;

        HttpRequest.getJSON(url)
            .then(function(data) {
                $documentFragment = $(document.createDocumentFragment());
                $liItem = $('<li/>');
                $deleteBtn = $('<button>X</button>').on('click', onBtnClick);
                $documentFragment.append('<li>' + '-------------------- All students --------------------' + '</li>');

                for (var i = 0; i < data.students.length; i++) {
                    student = data.students[i];
//                    $liItem.attr('data', 'student-' + student.id);
                    $liItem.attr('data-student-id', student.id);
                    $liItem.html('Name: ' + student.name + ', grade: ' + student.grade).append($deleteBtn.clone(true));
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