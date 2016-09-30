var Education;
(function (Education) {
    'use strict';
    var MajorType = (function () {
        function MajorType() {
        }
        Object.defineProperty(MajorType, "Electronics", {
            get: function () {
                return MajorType._electronics;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(MajorType, "MechanicalEngineering", {
            get: function () {
                return MajorType._mechanicalEngineering;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(MajorType, "ComputerScience", {
            get: function () {
                return MajorType._computerScience;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(MajorType, "BusinessManagement", {
            get: function () {
                return MajorType._businessManagement;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(MajorType, "Geography", {
            get: function () {
                return MajorType._geography;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(MajorType, "Math", {
            get: function () {
                return MajorType._math;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(MajorType, "Marketing", {
            get: function () {
                return MajorType._marketing;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(MajorType, "Chemistry", {
            get: function () {
                return MajorType._chemistry;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(MajorType, "Economy", {
            get: function () {
                return MajorType._economy;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(MajorType, "Law", {
            get: function () {
                return MajorType._law;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(MajorType, "ComputerTechnology", {
            get: function () {
                return MajorType._computerTechnology;
            },
            enumerable: true,
            configurable: true
        });
        Object.defineProperty(MajorType, "MajorTypes", {
            get: function () {
                return this._majorTypes;
            },
            enumerable: true,
            configurable: true
        });
        MajorType.isMajorTypeValid = function (majorType) {
            if (majorType === null || majorType === '') {
                throw new Error('Major type cannot be null or empty!');
            }
            for (var i = 0; i < MajorType._majorTypes.length; i += 1) {
                if (MajorType._majorTypes[i] === majorType) {
                    return true;
                }
            }
            return false;
        };
        MajorType._electronics = 'Electronics';
        MajorType._mechanicalEngineering = 'Mechanical Engineering';
        MajorType._computerScience = 'Computer Science';
        MajorType._businessManagement = 'Business Management';
        MajorType._geography = 'Geography';
        MajorType._math = 'Math';
        MajorType._marketing = 'Marketing';
        MajorType._chemistry = 'Chemistry';
        MajorType._economy = 'Economy';
        MajorType._law = 'Law';
        MajorType._computerTechnology = 'Computer Technology';
        MajorType._majorTypes = [MajorType._electronics, MajorType._mechanicalEngineering, MajorType._computerScience,
            MajorType._businessManagement, MajorType._geography, MajorType._math, MajorType._marketing, MajorType._chemistry,
            MajorType._economy, MajorType._law, MajorType._computerTechnology];
        return MajorType;
    })();
    Education.MajorType = MajorType;
})(Education || (Education = {}));
//# sourceMappingURL=MajorType.js.map