var Persons;
(function (Persons) {
    'use strict';
    var Person = (function () {
        function Person(fullName, id) {
            this.fullName = fullName;
            this.id = id;
        }
        Object.defineProperty(Person.prototype, "fullName", {
            get: function () {
                return this._fullName;
            },
            set: function (fullName) {
                if (fullName === null || fullName === '') {
                    throw new Error('Full name cannot be null or empty!');
                }
                this._fullName = fullName;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Person.prototype, "id", {
            get: function () {
                return this._id;
            },
            set: function (idNumber) {
                if (idNumber === null || idNumber === '') {
                    throw new Error('ID number cannot be null or empty!');
                }
                else if (!this.isIdValid(idNumber)) {
                    throw new Error('ID number must contains ' + Person.MAX_DIGITS_IN_ID + ' digits!');
                }
                else if (Person.isIdAlreadyExist(idNumber)) {
                    throw new Error('ID number already exist!');
                }
                this._id = idNumber;
                Person._idNumbers.push(idNumber);
            },
            enumerable: true,
            configurable: true
        });
        Person.prototype.printPerson = function () {
            console.log('Full name: ' + this.fullName + ', ID: ' + this.id);
        };
        Person.prototype.isIdValid = function (id) {
            if (id.length !== 10) {
                return false;
            }
            else if (!(/^\d+$/.test(id))) {
                return false;
            }
            return true;
        };
        Person.isIdAlreadyExist = function (id) {
            return Person._idNumbers.indexOf(id) !== -1;
        };
        Person.MIN_AGE = 0;
        Person.MAX_AGE = 100;
        Person.MAX_DIGITS_IN_ID = 10;
        Person._idNumbers = [];
        return Person;
    })();
    Persons.Person = Person;
})(Persons || (Persons = {}));
//# sourceMappingURL=Person.js.map