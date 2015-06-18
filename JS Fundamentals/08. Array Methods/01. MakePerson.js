var array = [1,1,1,1,1,1,1,1,1,1],
	firstNames = ['Gosho', 'Pesho', 'Ivan', 'Lozan', 'Traian', 'Bogomil'],
	lastNames = ['Petkov', 'Petrov', 'Ivanov', 'Georgiev', 'Peshev', 'Emilov'],
	genders = ['male', 'female'];

var arrayOfPeople = array.map(makePerson);
console.log(arrayOfPeople);

function makePerson(element, index) {
	var person = {};
	person.firstname = firstNames[getRandomInt(0,6)]
	person.lastname = lastNames[getRandomInt(0,6)];
	person.age = (Math.random(Number) * 100) | 0
	person.gender = genders[getRandomInt(0,2)];
	return person;
}

function getRandomInt(min, max) {
	return (Math.random() * (max - min)) | 0 + min
}