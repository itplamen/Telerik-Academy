(function() {
    var animals = Animals.initializeAnimals;

    console.log('---------- All animals ----------');
    printAnimals(animals);

    var totalNumberOfLegs = findTotalNumberOfLegs(animals);
    console.log('---------- Total number of legs ----------');
    console.log(totalNumberOfLegs);

    function findTotalNumberOfLegs(animals) {
        var totalNumberOfLegs = 0;
        _.each(animals, function (animal) {
            totalNumberOfLegs += animal.getNumberOfLegs();
        });

        return totalNumberOfLegs;
    }

    function printAnimals(animals) {
        _.each(animals, function(animal) {
            console.log(animal.getSpecies() + ' ' + animal.getNumberOfLegs());
        });

        console.log('\n');
    }
}());