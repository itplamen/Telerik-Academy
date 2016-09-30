var Education;
(function (Education) {
    'use strict';
    var University = (function () {
        function University(universityName, teachers, majors) {
            this.universityName = universityName;
            if (teachers) {
                this._teachers = teachers;
            }
            else {
                this._teachers = [];
            }
            if (majors) {
                this._majors = majors;
            }
            else {
                this._majors = [];
            }
        }
        Object.defineProperty(University.prototype, "universityName", {
            get: function () {
                return this._universityName;
            },
            set: function (universityName) {
                if (universityName === null || universityName === '') {
                    throw new Error('University name cannot be null or empty!');
                }
                this._universityName = universityName;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(University.prototype, "teachers", {
            get: function () {
                return this._teachers;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(University.prototype, "majors", {
            get: function () {
                return this._majors;
            },
            enumerable: true,
            configurable: true
        });
        University.prototype.addTeacher = function (teacher) {
            this._teachers.push(teacher);
        };
        University.prototype.containsTeacher = function (teacher) {
            return this._teachers.indexOf(teacher) !== -1;
        };
        University.prototype.removeTeacher = function (teacher) {
            if (this.containsTeacher(teacher)) {
                var teacherIndex = this._teachers.indexOf(teacher);
                this._teachers[teacherIndex] = this._teachers[this._teachers.length - 1];
                this._teachers.pop();
                return true;
            }
            return false;
        };
        University.prototype.addMajor = function (major) {
            if (this.containsMajor(major)) {
                throw new Error('Major already exist!');
            }
            this._majors.push(major);
        };
        University.prototype.containsMajor = function (major) {
            return this._majors.indexOf(major) !== -1;
        };
        University.prototype.removeMajor = function (major) {
            if (this.containsMajor(major)) {
                var majorIndex = this._majors.indexOf(major);
                this._majors[majorIndex] = this._majors[this._majors.length - 1];
                this._majors.pop();
                return true;
            }
            return false;
        };
        University.prototype.getNumberOfStudents = function () {
            var numberOfStudents = 0;
            this._majors.forEach(function (major) {
                numberOfStudents += major.students.length;
            });
            return numberOfStudents;
        };
        University.prototype.printUniversity = function () {
            console.group('University name: ' + this.universityName);
            console.log('Number of teachers: ' + this._teachers.length);
            console.log('Number of majors: ' + this._majors.length);
            console.log('Number of students: ' + this.getNumberOfStudents());
            if (this._teachers.length > 0) {
                console.group('Teachers: ');
                this._teachers.forEach(function (teacher) {
                    teacher.printTeacher();
                });
                console.groupEnd();
            }
            if (this._majors.length > 0) {
                console.group('Majors: ');
                this._majors.forEach(function (major) {
                    major.printMajor();
                });
                console.groupEnd();
            }
            console.groupEnd();
        };
        return University;
    })();
    Education.University = University;
})(Education || (Education = {}));
//# sourceMappingURL=University.js.map