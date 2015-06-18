var people = [{
    firstname: 'Ivan',
    age: 23
}, {
    firstname: 'Gosho',
    age: 16
}, {
    firstname: 'Teodor',
    age: 31
}, {
    firstname: 'Ilian',
    age: 12
}, {
    firstname: 'Pesho',
    age: 15
}, {
    firstname: 'Lozan',
    age: 42
}, {
    firstname: 'Ina',
    age: 25
}, {
    firstname: 'Bogomil',
    age: 34
}, {
    firstname: 'Bozhidar',
    age: 47
}, {
    firstname: 'Traian',
    age: 69
}];

var result = groupPeople(people);

console.log(result);

function groupPeople(peopleArray) {
    var result = peopleArray.reduce(function(obj, element) {
        var fnameLetter = element['firstname'][0];
        if (!obj[fnameLetter]) {
            obj[fnameLetter] = [];
        }
        obj[fnameLetter].push(element);
        return obj;
    }, obj = {});
    return result;
}
