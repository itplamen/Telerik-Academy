(function() {
    var students = Persons.initializeStudents;

    console.log('---------- All students ----------');
    printStudents(students);

    var studentWithHighestMarks = findStudentWithHighestMarks(students);
    console.log('---------- Student with highest marks ----------');
    printStudentWithHighestMarks(studentWithHighestMarks);

    function findStudentWithHighestMarks(students) {
        var studentWithHighestMarks;
        var highestAverageMark = 0;

         _.each(students, function(student) {
            if (student.getAverageMark() > highestAverageMark) {
                highestAverageMark = student.getAverageMark();
                studentWithHighestMarks = student;
            }
        });

        return studentWithHighestMarks;
    }

    function printStudents(students) {
        _.each(students, function(student) {
            console.log(student.getFirstName() + ' ' + student.getLastName() + ' [' + student.getMarks() +
            '] average mark: ' + student.getAverageMark());
        });

        console.log('\n');
    }

    function printStudentWithHighestMarks(student) {
        console.log(student.getFirstName() + ' ' + student.getLastName() + ' [' + student.getMarks() +
            '] average mark: ' + student.getAverageMark());
    }
}());