var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Persons;
(function (Persons) {
    var Employee = (function (_super) {
        __extends(Employee, _super);
        function Employee(fullName, age, personalNumber, position) {
            _super.call(this, fullName, age, personalNumber);
            this.Position = position;
        }
        Object.defineProperty(Employee.prototype, "Position", {
            get: function () {
                return this._position;
            },
            set: function (position) {
                if (position === null) {
                    throw new Error('Invalid position type. Position cannot be null!');
                }
                this._position = position;
            },
            enumerable: true,
            configurable: true
        });
        Employee.prototype.printEmployee = function () {
            _super.prototype.printPerson.call(this);
            console.log('Position: ' + this.Position);
        };
        return Employee;
    })(Persons.Person);
    Persons.Employee = Employee;
})(Persons || (Persons = {}));
//# sourceMappingURL=Employee.js.map