var index,
	indexOfYoungest = 0,
	ageOfYoungest;
var people = [{
    firstname: 'Gosho',
    lastname: 'Petrov',
    age: 32
}, {
    firstname: 'Bay',
    lastname: 'Ivan',
    age: 81
}, {
    firstname: 'Hristo',
    lastname: 'Hristov',
    age: 19
}, {
    firstname: 'Pesho',
    lastname: 'Peshov',
    age: 25
}];

for (index in people) {
	if (!ageOfYoungest) {
		ageOfYoungest = people[index].age;
	}
	if (people[index].age < ageOfYoungest) {
		ageOfYoungest = people[index].age;
		indexOfYoungest = index;
	}
}

console.log(people[indexOfYoungest].firstname + ' ' + people[indexOfYoungest].lastname);