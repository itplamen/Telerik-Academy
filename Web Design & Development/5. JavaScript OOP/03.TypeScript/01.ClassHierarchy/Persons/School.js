var Schools;
(function (Schools) {
    var School = (function () {
        function School(name) {
            this.Name = name;
        }
        Object.defineProperty(School.prototype, "Name", {
            get: function () {
                return this._name;
            },
            set: function (name) {
                if (name === null || name === '') {
                    throw new Error('Invalid school name. The name cannot be null or empty!');
                }
                else {
                    this._name = name;
                }
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(School.prototype, "Teachers", {
            get: function () {
                return this._teachers;
            },
            enumerable: true,
            configurable: true
        });
        School.prototype.addTeacher = function (teacher) {
            this._teachers.push(teacher);
        };
        School.prototype.containsTeacher = function (teacher) {
            if (this._teachers.indexOf(teacher) !== -1) {
                return true;
            }
            return false;
        };
        School.prototype.removeTeacher = function (teacher) {
            if (this.containsTeacher(teacher)) {
                var teacherIndex = this._teachers.indexOf(teacher);
                this._teachers[teacherIndex] = this._teachers[length - 1];
                this._teachers.pop();
                return true;
            }
            return false;
        };
        return School;
    })();
    Schools.School = School;
})(Schools || (Schools = {}));
//# sourceMappingURL=School.js.map