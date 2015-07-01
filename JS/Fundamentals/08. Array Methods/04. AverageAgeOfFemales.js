var people = [{
    firstname: 'Ivan',
    age: 88,
    gender: 'female'
}, {
    firstname: 'Gosho',
    age: 48,
    gender: 'male'
}, {
    firstname: 'Traian',
    age: 88,
    gender: 'male'
}, {
    firstname: 'Ivan',
    age: 6,
    gender: 'female'
}, {
    firstname: 'Pesho',
    age: 53,
    gender: 'female'
}, {
    firstname: 'Lozan',
    age: 2,
    gender: 'male'
}, {
    firstname: 'Ivan',
    age: 33,
    gender: 'male'
}, {
    firstname: 'Bogomil',
    age: 66,
    gender: 'female'
}, {
    firstname: 'Bogomil',
    age: 70,
    gender: 'female'
}, {
    firstname: 'Traian',
    age: 35,
    gender: 'male'
}];

FindAvgAgeOfFemales(people);

function FindAvgAgeOfFemales(arrayOfPeople) {
    var averageAgeOfFemales = arrayOfPeople.filter(function(person) {
        if (person.gender === 'female') {
            return person;
        }
    }).reduce(function(avg, female, index, arr) {
        avg += female.age / arr.length;
        return avg;
    }, avg = 0);

    console.log(averageAgeOfFemales);
}
