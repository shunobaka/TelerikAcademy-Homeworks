var person = {
    firstname: 'Gosho',
    lastname: 'Pesho',
    age: 19
};

var hasAge = hasProperty(person, 'age');
var hasEmail = hasProperty(person, 'email');

console.log('Has age property: ' + hasAge);
console.log('Has email property: ' + hasEmail);

function hasProperty(obj, property) {
    var prop;
    for (prop in obj) {
        if (prop === property) {
            return true;
        }
    }
    return false;
}
