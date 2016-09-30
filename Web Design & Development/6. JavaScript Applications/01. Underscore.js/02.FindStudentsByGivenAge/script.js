(function() {
    var students = Persons.initializeStudents;

    console.log('---------- All students ----------');
    printStudents(students);

    var studentsWithCorrectAge = findStudentsByAge(students);
    console.log('---------- All students with age between 18 and 24 ----------');
    printStudents(studentsWithCorrectAge);

    function findStudentsByAge(students) {
        var MIN_AGE = 18;
        var MAX_AGE = 24;

        var result = _.filter(students, function(student) {
            return (student.getAge() >= MIN_AGE && student.getAge() <= MAX_AGE);
        });

        return result;
    }

    function printStudents(students) {
        _.each(students, function(student) {
            console.log(student.getFirstName() + ' ' + student.getLastName() + ' ' + student.getAge());
        });

        console.log('\n');
    }
}());