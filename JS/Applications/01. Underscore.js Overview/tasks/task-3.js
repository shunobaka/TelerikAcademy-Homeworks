/* 
Create a function that:
*   Takes an array of students
    *   Each student has:
        *   `firstName`, `lastName` and `age` properties
        *   Array of decimal numbers representing the marks         
*   **finds** the student with highest average mark (there will be only one)
*   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
  	return function(students) {
  		var topStudent = _.chain(students)
  			.sortBy(function(st) {
  				debugger;
  				var sumOfMarks = 0;
  				_.each(st.marks, function(mark) {
  					sumOfMarks += mark;
  				});

  				return sumOfMarks / st.marks.length;
  			})
  			.last()
  			.value();

  		var topStudentFullName = topStudent.firstName + ' ' + topStudent.lastName;
  		var sumOfMarks = 0;
  		var averageMark;

  		_.each(topStudent.marks, function(mark) {
  			sumOfMarks += mark;
  		});

  		averageMark = sumOfMarks / topStudent.marks.length;

  		console.log(topStudentFullName + ' has an average score of ' + averageMark);
  	};
};

module.exports = solve;
