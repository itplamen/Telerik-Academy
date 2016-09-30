(function() {
    var mostCommonFirstName, mostCommonLastName = {};
    var persons = Persons.initializeStudents;

    console.log('---------- All persons ----------');
    printPersons(persons);

    mostCommonFirstName = mostCommonName(persons, 'first-name');
    mostCommonLastName = mostCommonName(persons, 'last-name');

    console.log('---------- Most common first name ----------');
    console.log(mostCommonFirstName.name + ' -> ' + mostCommonFirstName.counter + ' times.');

    console.log('---------- Most common last name ----------');
    console.log(mostCommonLastName.name + ' -> ' + mostCommonLastName.counter + ' times.');

    function mostCommonName(persons, searchByName) {
        var nameType = searchByName.toLowerCase().trim();
        var currentName = '';
        var currentCounter = 1;
        var mostCommonName = {
            name: '',
            counter: 1
        };

        var sortedPersons = _.sortBy(persons, function(person) {
            return getName(nameType, person);
        });

        _.each(sortedPersons, function(person) {
            if (currentName === '') {
                currentName = getName(nameType, person);
                mostCommonName.name = currentName;
            }
            else if (currentName === getName(nameType, person)) {
                currentCounter += 1;

                if (currentCounter > mostCommonName.counter) {
                    mostCommonName.counter = currentCounter;
                    mostCommonName.name = currentName;
                }
            }
            else {
                currentName = getName(nameType, person);
                currentCounter = 1;
            }
        });

        return mostCommonName;
    }

    function getName(nameType, person) {
        if (nameType === 'first-name') {
            return person.getFirstName();
        }
        else if (nameType === 'last-name') {
            return person.getLastName();
        }
    }

    function printPersons(persons) {
        _.each(persons, function(person) {
            console.log(person.getFirstName() + ' ' + person.getLastName());
        });

        console.log('\n');
    }
}());