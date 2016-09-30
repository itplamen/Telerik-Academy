(function() {
    var animals = Animals.initializeAnimals;

    console.log('---------- All animals ----------');
    printAnimals(animals);

    console.log('---------- Grouped animals ----------');
    var groupedAnimals = groupAnimalsBySpecies(animals);
    printGroupedAnimals(groupedAnimals);

    var sortedAnimals = sortAnimalsByNumberOfLegs(groupedAnimals);
    console.log('---------- Sorted animals ----------');
    printGroupedAnimals(sortedAnimals);

    function groupAnimalsBySpecies(animals) {
        var groupedAnimals = _.groupBy(animals, function(animal) {
            return animal.getSpecies();
        });

        return groupedAnimals;
    }

    function sortAnimalsByNumberOfLegs(animals) {
        var sortedAnimals = _.sortBy(animals, function(animal) {
            return animal[0].getNumberOfLegs();
        });

        return sortedAnimals;
    }

    function printAnimals(animals) {
        _.each(animals, function(animal) {
            console.log(animal.getSpecies() + ' ' + animal.getNumberOfLegs());
        });

        console.log('\n');
    }

    function printGroupedAnimals(groupedAnimals) {
        _.each(groupedAnimals, function(animalGroup) {
            console.log('[ ' + _.map(animalGroup, function(animal) {
                return animal.getSpecies() + ' - ' + animal.getNumberOfLegs() + ' legs ';
            }) +  ' ]');
        });

        console.log('\n');
    }
}());