(function() {
    var students = Persons.initializeStudents;

    console.log('---------- All students ----------');
    printStudents(students);

    var studentsWithFirstNameBeforeLastName = findStudentsWithFirstNameBeforeLastName(students);
    var studentsInDescendingOrder = sortStudentsInDescendingOrder(studentsWithFirstNameBeforeLastName);
    console.log('---------- Students whose first name is before its last name (in descending order) ----------');
    printStudents(studentsInDescendingOrder);

    function findStudentsWithFirstNameBeforeLastName(students) {
        var studentsWithFirstNameBeforeLastName =  _.filter(students, function(student) {
            return student.getFirstName().toLowerCase() < student.getLastName().toLowerCase();
        });

        return studentsWithFirstNameBeforeLastName;
    }

    function printStudents(students) {
        _.each(students, function(student) {
            console.log(student.getFirstName() + ' ' + student.getLastName());
        });

        console.log('\n');
    }

    function sortStudentsInDescendingOrder(students) {
        var studentsInDescendingOrder = _.sortBy(students, function(student) {
            return student.getFirstName().toLowerCase() + ' ' + student.getLastName().toLowerCase();
        })
            .reverse();

        return studentsInDescendingOrder;
    }
}());