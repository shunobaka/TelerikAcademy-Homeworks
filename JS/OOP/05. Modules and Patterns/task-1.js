/* Task Description */
/* 
 * Create a module for a Telerik Academy course
 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation
 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course
 * Create method init
 * Accepts a string - course title
 * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
 * Titles do not start or end with spaces
 * Titles do not have consecutive spaces
 * Titles have at least one character
 * Throws if there are no presentations
 * Create method addStudent which lists a student for the course
 * Accepts a string in the format 'Firstname Lastname'
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it
 * Create method getAllStudents that returns an array of students in the format:
 * {firstname: 'string', lastname: 'string', id: StudentID}
 * Create method submitHomework
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid
 * Create method pushExamResults
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

function solve() {
    // Make sure the title is non-empty, doesn't start or end with space 
    // and doesn't have consecutive spaces.
    function validateTitle(title) {
        if (title.length < 1) {
            throw new Error('Title shouldn\'t be empty!');
        }
        if (title[0] === ' ') {
            throw new Error('Title shouldn\'t start with a space!');
        }
        if (title[title.length - 1] === ' ') {
            throw new Error('Title shouldn\'t end with a space!');
        }
        if (title.indexOf('  ') > -1) {
            throw new Error('Title shouldn\'t have consecutive spaces!');
        }
    }

    // Validates that there are presentations and their titles are valid.
    function validatePresentations(presentations) {
        if (presentations.length < 1) {
            throw new Error('There must be presentations');
        }
        for (var presentation in presentations) {
            validateTitle(presentations[presentation]);
        }
    }

    // Makes sure the student has two names and they start with capital letter and rest are lowercase.
    function validateStudentsName(studentsNames) {
        var names = studentsNames.split(' '),
            nameValidation = /^[A-Z]{1}[a-z]*/;

        if (names.length !== 2) {
            throw new Error('Student must have exactly two names!');
        }

        for (var name in names) {
            if (!nameValidation.test(names[name])) {
                throw new Error('One of the students names is invalid!');
            }
        }
    }

    function getStudent(students, id) {
        for (var student in students) {
            if (id === students[student].id) {
                return students[student];
            }
        }

        throw new Error('There is no student with this id!');
    }

    function validateHomeworkExistence(presentations, id) {
        if (parseInt(id) !== id) {
            throw new Error('The homework id must be a positive integer!');
        }

        if (id < 1 || id > presentations.length) {
            throw new Error('There is no homework with this id to submit!');
        }
    }

    var Course = {
        init: function(title, presentations) {
            validateTitle(title);
            validatePresentations(presentations);

            this.title = title;
            this.presentations = presentations;
            this.students = [];

            return this;
        },
        addStudent: function(name) {
            validateStudentsName(name);
            var numberOfPresentations = this.presentations.length;

            var student = {
                firstname: name.split(' ')[0],
                lastname: name.split(' ')[1],
                id: (this.students.length + 1),
                submittedHomeworks: 0,
            };

            Object.defineProperty(student, 'finalScore', {
                get: function() {
                    return (((student.score || 0) * 0.75) + (student.submittedHomeworks / numberOfPresentations * 0.25)).toFixed(2);
                }
            });

            this.students.push(student);

            return student.id;
        },
        getAllStudents: function() {
            return this.students;
        },
        submitHomework: function(studentID, homeworkID) {
            var student = getStudent(this.students, studentID);

            validateHomeworkExistence(this.presentations, homeworkID);

            student.submittedHomeworks += 1;

            return this;
        },
        pushExamResults: function(results) {
            var student;
            var score;

            for (var result in results) {
                student = getStudent(this.students, results[result].StudentID);

                if (student.hasOwnProperty('score')) {
                    throw new Error('The student cheated on the exam!');
                }

                score = +results[result].Score;

                if (isNaN(score)) {
                    throw new Error('The score is not a number!');
                }

                student.score = score;
            }

            return this;
        },
        getTopStudents: function() {
            var topStudents = this.students.sort(function(studOne, studTwo) {
                    return studTwo.finalScore - studOne.finalScore;
                });

            if (this.students.length > 10) {
                topStudents = topStudents.slice(0, 10);
            }

            return topStudents.map(function(student) {
                return student.firstname + ' ' + student.lastname + ': ' + student.finalScore;
            });
        }
    };

    return Course;
}

module.exports = solve;
