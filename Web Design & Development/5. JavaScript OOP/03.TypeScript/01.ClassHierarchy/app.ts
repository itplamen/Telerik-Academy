console.group('-----------------------------------------------------------------------------------------------------');
var teodorStudent: Persons.Student = new Persons.Student('Teodor Teodorov', '9101012233', 1, '199222');
teodorStudent.addMarks(Education.Discipline.Database, [6, 5, 4, 6, 3]);
teodorStudent.addMarks(Education.Discipline.JavaProgramming, [4, 4, 2, 6, 6]);

var ivanStudent: Persons.Student = new Persons.Student('Ivan Ivanov', '9110102233', 4, '101111');
ivanStudent.addMarks(Education.Discipline.WebDesign, [5, 5, 6, 5, 5]);

var mariaTeacher: Persons.Teacher = new Persons.Teacher('Maria Getova', '6404023233', '20 years',
    [Education.Discipline.Database, Education.Discipline.Criptography, Education.Discipline.Math]);

var kirilTeacher: Persons.Teacher = new Persons.Teacher('Kiril Petev', '8812129900', '11 months', [Education.Discipline.JavaProgramming]);

var computerScienceStudents: Persons.Student[] = [
    teodorStudent,
    ivanStudent,
    new Persons.Student('Maria Dimitrova', '9101022211', 4, '101213'),
    new Persons.Student('Hristo Petkov', '9408070111', 1, '131322'),
    new Persons.Student('Georgi Georgiev', '8920113212', 2, '132001'),
    new Persons.Student('Kristina Ivanova', '8801012101', 3, '432122')
];

var computerScienceMajor: Education.Major = new Education.Major(Education.MajorType.ComputerScience, computerScienceStudents);
computerScienceMajor.addStudent(new Persons.Student('Valentin Koev', '9312241022', 2, '099122'));
computerScienceMajor.removeStudent(ivanStudent);
computerScienceMajor.printMajor(); 
console.log('Is student ' + ivanStudent.fullName + ' still exist in computer science major: ' + computerScienceMajor.containsStudent(ivanStudent));

console.log('-----------------------------------------------------------------------------------------------------');
console.groupEnd();

console.group('-----------------------------------------------------------------------------------------------------');
var university: Education.University = new Education.University('Software University', [mariaTeacher, kirilTeacher]);
university.addTeacher(new Persons.Teacher('Denis Koev', '8012091233', 'no experience'));
university.addMajor(new Education.Major(Education.MajorType.Chemistry, [new Persons.Student('Mitko Ivanov', '9202061222', 1, '151102'), ivanStudent]));
university.printUniversity();

console.log('-----------------------------------------------------------------------------------------------------');
console.groupEnd();

console.group('-----------------------------------------------------------------------------------------------------');
var exam: Education.Exam<Persons.Teacher, Persons.Student> = new Education.Exam<Persons.Teacher, Persons.Student>
    (Education.MajorType.Electronics, Education.Discipline.Math, new Persons.Teacher('Daniel Petrov', '5009162314', '30 years',
        [Education.Discipline.Math, Education.Discipline.OOP]), [new Persons.Student('Kamelia Koleva', '9104121444', 4, '110033')]);

exam.printExam();
console.log('-----------------------------------------------------------------------------------------------------');
console.groupEnd();