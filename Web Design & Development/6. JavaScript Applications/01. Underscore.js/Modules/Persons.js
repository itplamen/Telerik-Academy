var Persons = (function() {
    var Student = (function() {
        function Student(firstName, lastName, age, arrayOfMarks) {
            this._firstName = firstName;
            this._lastName = lastName;
            this._age = age;
            this._marks = arrayOfMarks;
        }

        Student.prototype.getFirstName = function() {
            return this._firstName;
        };

        Student.prototype.getLastName = function() {
            return this._lastName;
        };

        Student.prototype.getAge = function() {
            return this._age;
        };

        Student.prototype.getMarks = function() {
            return this._marks;
        };

        Student.prototype.getAverageMark = function() {
            var averageMark = _.reduce(this._marks, function(sum, mark) {
                return sum += mark;
            });

            return averageMark /= this._marks.length;
        };

        return Student;
    }());

    var initializeStudents = (function() {
        var students = [
            new Student('Plamen', 'Georgiev', 23, [6, 5, 6, 4, 4, 3, 2, 6]),
            new Student('Spas', 'Petrov', 30, [2, 2, 6, 6, 4, 3, 5, 2]),
            new Student('Georgi', 'Ivanov', 11, [6, 2, 5, 4, 3, 2, 6, 6]),
            new Student('Stamat', 'Georgiev', 18, [2, 5, 5, 5, 5, 3, 4, 6]),
            new Student('Ivan', 'Angelov', 24, [2, 2, 6, 6, 6, 3, 2, 2]),
            new Student('Viktor', 'Georgiev', 16, [3, 3, 4, 4, 4, 4, 5, 5]),
            new Student('Pesho', 'Peshov', 20, [6, 6, 6, 2, 2, 4, 3, 6]),
            new Student('Spas', 'Georgiev', 129, [4, 4, 5, 3, 2, 3, 2, 3]),
            new Student('Spas', 'Spasov', 19, [6, 6, 6, 4, 4, 6, 2, 6]),
            new Student('Anton', 'Denev', 25, [6, 2, 2, 6, 6, 6, 6, 6])
        ];

        return students;
    }());

    return {
      Student: Student,
        initializeStudents: initializeStudents
    };
}());