var person = {
	firstname: 'Pesho',
	lastname: 'Goshov',
	age: 20,
	email: 'sdadsd@abv.bg'
},
	clonedPerson;

clonedPerson = clone(person);

console.log(clonedPerson);

function clone(obj) {
	var prop,
		clonedObj = {};
	for (prop in obj) {
		clonedObj[prop] = obj[prop];
	}

	return clonedObj;
}