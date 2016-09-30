var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Persons;
(function (Persons) {
    'use strict';
    var Teacher = (function (_super) {
        __extends(Teacher, _super);
        function Teacher(fullname, id, experience, disciplines) {
            var isAllDisciplinesValid = true;
            _super.call(this, fullname, id);
            this.experience = experience;
            if (disciplines) {
                disciplines.forEach(function (currentDiscipline) {
                    if (!Education.Discipline.isDisciplineValid(currentDiscipline)) {
                        throw new Error('There is no such discipline!');
                    }
                });
                this._disciplines = disciplines;
            }
            else {
                this._disciplines = [];
            }
        }
        Object.defineProperty(Teacher.prototype, "experience", {
            get: function () {
                return this._experience;
            },
            set: function (experience) {
                if (experience === null || experience === '') {
                    throw new Error('Experience cannot be null or empty!');
                }
                this._experience = experience;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Teacher.prototype, "disciplines", {
            get: function () {
                return this._disciplines;
            },
            enumerable: true,
            configurable: true
        });
        Teacher.prototype.addDiscipline = function (discipline) {
            if (!Education.Discipline.isDisciplineValid(discipline)) {
                throw new Error('There is no such discipline!');
            }
            else if (this.containsDiscipline(discipline)) {
                throw new Error('Discipline already exist!');
            }
            this._disciplines.push(discipline);
        };
        Teacher.prototype.containsDiscipline = function (discipline) {
            return this._disciplines.indexOf(discipline) !== -1;
        };
        Teacher.prototype.removeDiscipline = function (discipline) {
            if (this.containsDiscipline(discipline)) {
                var disciplineIndex = this._disciplines.indexOf(discipline);
                this._disciplines[disciplineIndex] = this._disciplines[this._disciplines.length - 1];
                this._disciplines.pop();
                return true;
            }
            return false;
        };
        Teacher.prototype.printTeacher = function () {
            _super.prototype.printPerson.call(this);
            console.log('Experience: ' + this.experience);
            console.group('Disciplines: ');
            if (this._disciplines.length > 0) {
                this._disciplines.forEach(function (discipline) {
                    console.log(discipline);
                });
            }
            else {
                console.log('There are no disciplines!');
            }
            console.groupEnd();
            console.log('\n');
        };
        return Teacher;
    })(Persons.Person);
    Persons.Teacher = Teacher;
})(Persons || (Persons = {}));
//# sourceMappingURL=Teacher.js.map