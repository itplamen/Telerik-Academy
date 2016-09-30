var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Persons;
(function (Persons) {
    'use strict';
    var Student = (function (_super) {
        __extends(Student, _super);
        function Student(fullname, id, course, facultyNumber) {
            _super.call(this, fullname, id);
            this.course = course;
            this.facultyNumber = facultyNumber;
            this._marks = [];
        }
        Object.defineProperty(Student.prototype, "course", {
            get: function () {
                return this._course;
            },
            set: function (course) {
                if (course < Student.MIN_COURSE || course > Student.MAX_COURSE) {
                    throw new Error('Course must be in the interval [' + Student.MIN_COURSE + ' - ' + Student.MAX_COURSE + ']!');
                }
                this._course = course;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Student.prototype, "facultyNumber", {
            get: function () {
                return this._facultyNumber;
            },
            set: function (facultyNumber) {
                if (facultyNumber === null || facultyNumber === '') {
                    throw new Error('Faculty number cannot be null or empty!');
                }
                else if (Student.isFacultyNumberAlreadyExist(facultyNumber)) {
                    throw new Error('Faculty number already exist!');
                }
                this._facultyNumber = facultyNumber;
                Student._facultyNumbers.push(facultyNumber);
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Student.prototype, "marks", {
            get: function () {
                return this._marks;
            },
            enumerable: true,
            configurable: true
        });
        Student.prototype.addMark = function (discipline, mark) {
            var disciplineMarks = [];
            this.isDisciplineValid(discipline);
            if (!this.isMarkValid(mark)) {
                throw new Error('Mark must be an integer number in interval [' + Student.MIN_MARK + ' - ' + Student.MAX_MARK + ']!');
            }
            if (!this._marks[discipline]) {
                this._marks[discipline] = [mark];
            }
            else {
                disciplineMarks = this._marks[discipline];
                disciplineMarks.push(mark);
                this._marks[discipline] = disciplineMarks;
            }
        };
        Student.prototype.addMarks = function (discipline, marks) {
            var _this = this;
            this.isDisciplineValid(discipline);
            marks.forEach(function (mark) {
                if (!_this.isMarkValid(mark)) {
                    throw new Error('Mark must be an integer number in interval [' + Student.MIN_MARK + ' - ' + Student.MAX_MARK + ']!');
                }
            });
            this._marks[discipline] = marks;
        };
        Student.prototype.getAverageMark = function (discipline) {
            var disciplineMarks = this._marks[discipline], averageMark = 0;
            this.isDisciplineValid(discipline);
            disciplineMarks.forEach(function (mark) {
                averageMark += mark;
            });
            return averageMark / disciplineMarks.length;
        };
        Student.prototype.clearMarks = function () {
            this._marks = [];
        };
        Student.prototype.printStudent = function () {
            var discipline;
            _super.prototype.printPerson.call(this);
            console.log('Course: ' + this.course + ', Faculty number: ' + this.facultyNumber);
            console.group('Marks: ');
            for (discipline in this._marks) {
                console.log(discipline + ': ' + '[' + this._marks[discipline] + '] -> ' + this.getAverageMark(discipline));
            }
            if (!discipline) {
                console.log('There are no marks!');
            }
            console.groupEnd();
            console.log('\n');
        };
        Student.isFacultyNumberAlreadyExist = function (facultyNumber) {
            return Student._facultyNumbers.indexOf(facultyNumber) !== -1;
        };
        Student.prototype.isDisciplineValid = function (discipline) {
            if (discipline === null || discipline === '') {
                throw new Error('Discipline cannot be null or empty!');
            }
            else if (!Education.Discipline.isDisciplineValid(discipline)) {
                throw new Error('There is no such discipline!');
            }
            return true;
        };
        Student.prototype.isMarkValid = function (mark) {
            return (mark >= Student.MIN_MARK && mark <= Student.MAX_MARK) &&
                (parseInt(mark.toString()) === parseFloat(mark.toString()));
        };
        Student.MIN_COURSE = 1;
        Student.MAX_COURSE = 5;
        Student.MIN_MARK = 2;
        Student.MAX_MARK = 6;
        Student._facultyNumbers = [];
        return Student;
    })(Persons.Person);
    Persons.Student = Student;
})(Persons || (Persons = {}));
//# sourceMappingURL=Student.js.map