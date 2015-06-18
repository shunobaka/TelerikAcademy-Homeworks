function buildPerson(firstname, lastname, age) {
    return {
        firstname: firstname,
        lastname: lastname,
        age: age
    };
}

var personOne = buildPerson('Pesho', 'Peshev', 33),
    personTwo = buildPerson('Stamat', 'Ivanov', 28),
    personThree = buildPerson('Georgi', 'Goshev', 21),
    personFour = buildPerson('Bobi', 'Petrov', 28),
    people = [personOne, personTwo, personThree, personFour];

var groupedByAge = groupPeopleBy(people, 'age');
console.log(groupedByAge);
var groupByfirstname = groupPeopleBy(people, 'firstname');
console.log(groupByfirstname);
var groupBylastname = groupPeopleBy(people, 'lastname');
console.log(groupBylastname);

function groupPeopleBy (peopleArr, key) {
    if (peopleArr.length === 0) {
        return null;
    }

    if (!peopleArr[0].hasOwnProperty(key)) {
        return null;
    }

    var groupedPeople = {},
        i;

    for (i in peopleArr) {
        var groupProperty = peopleArr[i][key];

        if (!groupedPeople.hasOwnProperty(groupProperty)) {
            groupedPeople[groupProperty] = [];
        }
        groupedPeople[groupProperty].push(peopleArr[i]);
    }

    return groupedPeople;
}