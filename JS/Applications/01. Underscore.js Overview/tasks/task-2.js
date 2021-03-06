/*
Create a function that:
*   Takes an array of students
    *   Each student has a `firstName`, `lastName` and `age` properties
*   **finds** the students whose age is between 18 and 24
*   **prints**  the fullname of found students, sorted lexicographically ascending
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
  	return function (students) {
  		_.chain(students)
  			.filter(function(st) {
  				return st.age >= 18 && st.age <= 24;
  			})
  			.sortBy(function(st) {
  				studentFullName = st.firstName + ' ' + st.lastName;
  				return studentFullName;
  			})
  			.each(function(st) {
  				studentFullName = st.firstName + ' ' + st.lastName;
  				console.log(studentFullName);
  			})
  	};
}

module.exports = solve;
