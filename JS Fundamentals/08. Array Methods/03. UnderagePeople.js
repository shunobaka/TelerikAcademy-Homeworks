var peopleArray = [{
    firstname: 'Gosho',
    age: 11,
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
    age: 15,
}, {
    firstname: 'Pesho',
    age: 87,
}, {
    firstname: 'Ivan',
    age: 45,
}, {
    firstname: 'Bogomil',
    age: 9,
}];

ListUnderagePeople(peopleArray);

function ListUnderagePeople(arrayofPeople) {
    arrayofPeople.filter(function(person) {
        if (person.age < 18) {
            return person;
        }
    }).forEach(function(person) {
        console.log(person);
    })
}