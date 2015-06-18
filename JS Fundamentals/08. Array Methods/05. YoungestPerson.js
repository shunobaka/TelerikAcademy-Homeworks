if (!Array.prototype.find) {
    Array.prototype.find = function(callback) {
        var i,
            len = this.length;
        for (i = 0; i < len; i += 1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
    };
}

var people = [{
    firstname: 'Traian',
    age: 11,
    gender: 'female'
}, {
    firstname: 'Ivan',
    age: 49,
    gender: 'male'
}, {
    firstname: 'Lozan',
    age: 45,
    gender: 'male'
}, {
    firstname: 'Bogomil',
    age: 39,
    gender: 'male'
}, {
    firstname: 'Bogomil',
    age: 39,
    gender: 'female'
}, {
    firstname: 'Traian',
    age: 46,
    gender: 'male'
}, {
    firstname: 'Gosho',
    age: 56,
    gender: 'male'
}, {
    firstname: 'Bogomil',
    age: 13,
    gender: 'male'
}, {
    firstname: 'Pesho',
    age: 20,
    gender: 'male'
}, {
    firstname: 'Traian',
    age: 24,
    gender: 'female'
}];

FindYoungestMale(people);

function FindYoungestMale(arrayOfPeople) {
    var youngestMale = arrayOfPeople.filter(function(person) {
        if (person.gender === 'male') {
            return person;
        }
    }).sort(function(person, personTwo) {
        return person.age - personTwo.age;
    }).find(function(person) {
        return person.age > 0;
    });

    console.log(youngestMale);
}