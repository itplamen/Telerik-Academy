var Animals = (function() {
    var Animal = (function() {
        function Animal(species, numberOfLegs) {
            this._firstName = species;
            this._numberOfLegs = numberOfLegs;
        }

        Animal.prototype.getSpecies = function() {
            return this._firstName;
        };

        Animal.prototype.getNumberOfLegs = function() {
            return this._numberOfLegs;
        };

        return Animal;
    }());

    var initializeAnimals = (function() {
        var animals = [
            new Animal('Eagle', 2),
            new Animal('Grass Spider', 8),
            new Animal('Salmon', 0),
            new Animal('Kangaroo', 2),
            new Animal('White Shark', 0),
            new Animal('Bison', 4),
            new Animal('Eagle', 2),
            new Animal('Centipede', 100),
            new Animal('Bison', 4),
            new Animal('Elephant', 4),
            new Animal('Barracuda', 0),
            new Animal('Hawk', 2),
            new Animal('Centipede', 100),
            new Animal('Eagle', 2),
            new Animal('White Shark', 0)
        ];

        return animals;
    }());

    return {
        Animal: Animal,
        initializeAnimals: initializeAnimals
    };
}());