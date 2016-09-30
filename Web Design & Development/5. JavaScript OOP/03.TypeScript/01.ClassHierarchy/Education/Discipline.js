var Education;
(function (Education) {
    'use strict';
    var Discipline = (function () {
        function Discipline() {
        }
        Object.defineProperty(Discipline, "OOP", {
            get: function () {
                return Discipline._oop;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Discipline, "Criptography", {
            get: function () {
                return Discipline._criptography;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Discipline, "Math", {
            get: function () {
                return Discipline._math;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Discipline, "JavaProgramming", {
            get: function () {
                return Discipline._javaProgramming;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Discipline, "English", {
            get: function () {
                return Discipline._english;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Discipline, "Database", {
            get: function () {
                return Discipline._database;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Discipline, "ArtificialIntelligence", {
            get: function () {
                return Discipline._artificialIntelligence;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Discipline, "WebDesign", {
            get: function () {
                return Discipline._webDesign;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(Discipline, "Disciplines", {
            get: function () {
                return Discipline._disciplines;
            },
            enumerable: true,
            configurable: true
        });
        Discipline.isDisciplineValid = function (discipline) {
            if (discipline === null || discipline === '') {
                throw new Error('Discipline cannot be null or empty!');
            }
            for (var i = 0; i < Discipline._disciplines.length; i += 1) {
                if (Discipline._disciplines[i] === discipline) {
                    return true;
                }
            }
            return false;
        };
        Discipline._oop = 'OOP';
        Discipline._criptography = 'Cryptography';
        Discipline._math = 'Math';
        Discipline._javaProgramming = 'JAVA Programming';
        Discipline._english = 'English';
        Discipline._database = 'Database';
        Discipline._artificialIntelligence = 'Artificial Intelligence';
        Discipline._webDesign = 'Web Design';
        Discipline._disciplines = [Discipline._oop, Discipline._criptography, Discipline._math, Discipline._javaProgramming,
            Discipline._english, Discipline._database, Discipline._artificialIntelligence, Discipline._webDesign];
        return Discipline;
    })();
    Education.Discipline = Discipline;
})(Education || (Education = {}));
//# sourceMappingURL=Discipline.js.map