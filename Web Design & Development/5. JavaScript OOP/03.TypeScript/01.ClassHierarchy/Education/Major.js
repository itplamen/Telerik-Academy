var Education;
(function (Education) {
    'use strict';
    var Major = (function () {
        function Major(majorType, students) {
            this.majorType = majorType;
            if (students) {
                this._students = students;
            }
            else {
                this._students = [];
            }
        }
        Object.defineProperty(Major.prototype, "majorType", {
            get: function () {
                return this._majorType;
            },
            set: function (majorType) {
                if (!Education.MajorType.isMajorTypeValid(majorType)) {
                    throw new Error('There is no sych major type!');
                }
                this._majorType = majorType;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Major.prototype, "students", {
            get: function () {
                return this._students;
            },
            enumerable: true,
            configurable: true
        });
        Major.prototype.addStudent = function (student) {
            this._students.push(student);
        };
        Major.prototype.containsStudent = function (student) {
            return this._students.indexOf(student) !== -1;
        };
        Major.prototype.removeStudent = function (student) {
            if (this.containsStudent(student)) {
                var studentIndex = this._students.indexOf(student);
                this._students[studentIndex] = this._students[this._students.length - 1];
                this._students.pop();
                return true;
            }
            return false;
        };
        Major.prototype.clearStudents = function () {
            this._students = [];
        };
        Major.prototype.printMajor = function () {
            console.group('Major: ' + this.majorType);
            console.group('Students: ');
            if (this._students.length > 0) {
                this._students.forEach(function (student) {
                    student.printStudent();
                });
                console.groupEnd();
            }
            else {
                console.log('There are no students in this major!');
            }
            console.groupEnd();
        };
        return Major;
    })();
    Education.Major = Major;
})(Education || (Education = {}));
//# sourceMappingURL=Major.js.map