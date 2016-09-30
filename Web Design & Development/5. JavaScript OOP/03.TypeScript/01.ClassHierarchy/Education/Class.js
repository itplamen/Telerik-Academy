var Education;
(function (Education) {
    var Class = (function () {
        function Class(className, students) {
            this.ClassName = className;
            if (students) {
                this._students = students;
            }
        }
        Object.defineProperty(Class.prototype, "ClassName", {
            get: function () {
                return this._className;
            },
            set: function (className) {
                if (className === null || className === '') {
                    throw new Error('Invalid class name. Class name cannot be null or empty!');
                }
                this._className = className;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Class.prototype, "Students", {
            get: function () {
                return this._students;
            },
            enumerable: true,
            configurable: true
        });
        Class.prototype.addStudent = function (student) {
            this._students.push(student);
        };
        Class.prototype.containsStudent = function (student) {
            if (this._students.indexOf(student) !== -1) {
                return true;
            }
            return false;
        };
        Class.prototype.removeStudent = function (student) {
            if (this.containsStudent(student)) {
                var studentIndex = this._students.indexOf(student);
                this._students[studentIndex] = this._students[length - 1];
                this._students.pop();
                return true;
            }
            return false;
        };
        Class.prototype.clearClass = function () {
            this._students = [];
        };
        Class.prototype.printClass = function () {
            console.log('Class name: ' + this.ClassName);
            if (this._students && this._students.length > 0) {
                console.group('Students in class: ' + this._students.length);
                this._students.forEach(function (student) {
                    console.log(student.FullName + ', ' + student.Age + ', ' + student.PersonalNumber + ' ' + student.Course);
                });
            }
            else {
                console.log('Students in class: 0');
            }
        };
        return Class;
    })();
    Education.Class = Class;
})(Education || (Education = {}));
//# sourceMappingURL=Class.js.map