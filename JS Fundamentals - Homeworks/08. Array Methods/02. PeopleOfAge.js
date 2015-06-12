var peopleArray = [{
    firstname: 'Gosho',
    age: 37,
}, {
    firstname: 'Bogomil',
    age: 32,
}, {
    firstname: 'Pesho',
    age: 17,
}, {
    firstname: 'Gosho',
    age: 68,
}, {
    firstname: 'Pesho',
    age: 67,
}, {
    firstname: 'Pesho',
    age: 87,
}, {
    firstname: 'Ivan',
    age: 45,
}, {
    firstname: 'Bogomil',
    age: 70,
}];

AreAllPeopleOfAge(peopleArray);

function AreAllPeopleOfAge(arrayOfPeople) {
    var result = arrayOfPeople.every(function(person) {
        return person.age >= 18;
    });
    console.log(result);
}
