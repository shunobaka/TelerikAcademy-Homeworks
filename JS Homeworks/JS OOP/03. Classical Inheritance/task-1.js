/* Task Description */
/* 
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error 		
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/
function solve() {
    var Person = (function() {
        function Person(firstname, lastname, age) {
            if (firstname.length < 3 || firstname.length > 20) {
                throw new Error('First name must be between 3 and 100 letters!');
            } else {
                this.firstname = firstname;
            }
            if (lastname.length < 3 || lastname.length > 20) {
                throw new Error('Last name must be between 3 and 100 letters!');
            } else {
                this.lastname = lastname;
            }
            if (age < 0 || age > 150) {
                throw new Error('Age is either below zero or too high!');
            } else {
                this.age = age;
            }
            this.fullname = this.firstname + ' ' + this.lastname;
        }

        Object.defineProperty(Person.prototype, 'fullname', {
            get: function() {
                return this.firstname + ' ' + this.lastname;
            },
            set: function(newFullname) {
                var newFirstname = newFullname.split(' ')[0];
                var newLastname = newFullname.split(' ')[1];
                if (newFirstname.length < 3 || newFirstname.length > 20) {
                    throw new Error('First name must be between 3 and 100 letters!');
                } else {
                    this.firstname = newFirstname;
                }
                if (newLastname.length < 3 || newLastname.length > 20) {
                    throw new Error('Last name must be between 3 and 100 letters!');
                } else {
                    this.lastname = newLastname;
                }
            }
        });

        Person.prototype.introduce = function() {
            return ('Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old');
        };

        return Person;
    }());
    return Person;
}
module.exports = solve;
