var Education;
(function (Education) {
    'use strict';
    var Exam = (function () {
        function Exam(majorType, discipline, teacher, students) {
            this.majorType = majorType;
            this.discipline = discipline;
            this._teacher = teacher;
            if (students) {
                this._students = students;
            }
            else {
                this._students = [];
            }
        }
        Object.defineProperty(Exam.prototype, "majorType", {
            get: function () {
                return this._majorType;
            },
            set: function (majorType) {
                if (!Education.MajorType.isMajorTypeValid(majorType)) {
                    throw new Error('There is no such major type!');
                }
                this._majorType = majorType;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Exam.prototype, "discipline", {
            get: function () {
                return this._discipline;
            },
            set: function (discipline) {
                if (!Education.Discipline.isDisciplineValid(discipline)) {
                    throw new Error('There is no such discipline!');
                }
                this._discipline = discipline;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Exam.prototype, "teacher", {
            get: function () {
                return this._teacher;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Exam.prototype, "students", {
            get: function () {
                return this._students;
            },
            enumerable: true,
            configurable: true
        });
        Exam.prototype.printExam = function () {
            console.group('Exam: ');
            console.log('Major: ' + this._majorType + ', Discipline: ' + this._discipline);
            console.log('Teacher: ');
            this._teacher.printTeacher();
            console.log('Students: ');
            this._students.forEach(function (student) {
                student.printStudent();
            });
            console.groupEnd();
        };
        return Exam;
    })();
    Education.Exam = Exam;
})(Education || (Education = {}));
//# sourceMappingURL=Exam.js.map