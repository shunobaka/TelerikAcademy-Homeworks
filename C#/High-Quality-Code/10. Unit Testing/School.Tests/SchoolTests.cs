namespace School.Tests
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowArgumentNullExceptionWhenCreatedWithNullName()
        {
            var school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowArgumentNullExceptionWhenCreatedWithEmptyString()
        {
            var school = new School(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowArgumentNullExceptionWhenCreatedWithWhitespace()
        {
            var school = new School("  ");
        }

        [TestMethod]
        public void SchoolShouldBeInitializedProperlyWhenGivenValidName()
        {
            var school = new School("Gosho school");
            Assert.AreEqual("Gosho school", school.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowArgumentNullExceptionWhenTryingToAddNullStudent()
        {
            var school = new School("Gosho school");
            school.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowInvalidOperationExceptionWhenTryingToAddAStudentTwice()
        {
            var school = new School("Gosho school");
            var student = new Student("Gosho", 99999);
            school.AddStudent(student);
            school.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowInvalidOperationExceptionWhenTryingToAddStudentWithConflictingId()
        {
            var school = new School("Gosho school");
            var student = new Student("Gosho", 99999);
            var studentTwo = new Student("Pesho", 99999);
            school.AddStudent(student);
            school.AddStudent(studentTwo);
        }

        [TestMethod]
        public void SchoolShouldWorkCorrectlyWhenProperlyAddingStudent()
        {
            var school = new School("Gosho school");
            var student = new Student("Gosho", 99999);
            school.AddStudent(student);
            Assert.AreSame(student, school.Students.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowArgumentNullExceptionWhenTryingToRemoveNullStudent()
        {
            var school = new School("Gosho school");
            school.RemoveStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowInvalidOperationExceptionWhenTryingToRemoveUnexistingStudent()
        {
            var school = new School("Gosho school");
            var student = new Student("Gosho", 99999);
            school.RemoveStudent(student);
        }

        [TestMethod]
        public void SchoolShouldWorkCorrectlyWhenProperlyRemovingStudent()
        {
            var school = new School("Gosho school");
            var student = new Student("Gosho", 99999);
            school.AddStudent(student);
            school.RemoveStudent(student);
            Assert.AreEqual(0, school.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowArgumentNullExceptionWhenTryingToAddNullCourse()
        {
            var school = new School("Gosho school");
            school.AddCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowInvalidOperationExceptionWhenTryingToAddSameCourseTwice()
        {
            var school = new School("Gosho school");
            var course = new Course("Gosho course");
            school.AddCourse(course);
            school.AddCourse(course);
        }

        [TestMethod]
        public void SchoolShouldWorkCorrectlyWhenProperlyAddingCourse()
        {
            var school = new School("Gosho school");
            var course = new Course("Gosho course");
            school.AddCourse(course);
            Assert.AreSame(course, school.Courses.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowArgumentNullExceptionWhenTryingToRemoveNullCourse()
        {
            var school = new School("Gosho school");
            school.RemoveCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowInvalidOperationExceptionWhenTryingToRemoveUnexistingCourse()
        {
            var school = new School("Gosho school");
            var course = new Course("Gosho course");
            school.RemoveCourse(course);
        }

        [TestMethod]
        public void SchoolShouldWorkCorrectlyWhenProperlyRemovingCourse()
        {
            var school = new School("Gosho school");
            var course = new Course("Gosho course");
            school.AddCourse(course);
            school.RemoveCourse(course);
            Assert.AreEqual(0, school.Courses.Count);
        }
    }
}
