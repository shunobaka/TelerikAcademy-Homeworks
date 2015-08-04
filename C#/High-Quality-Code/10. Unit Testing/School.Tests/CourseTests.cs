namespace School.Tests
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowArgumentNullExceptionWhenCreatedWithNullName()
        {
            var course = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowArgumentNullExceptionWhenCreatedWithEmptyString()
        {
            var course = new Course(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowArgumentNullExceptionWhenCreatedWithWhitespace()
        {
            var course = new Course("  ");
        }

        [TestMethod]
        public void CourseShouldBeInitializedProperlyWhenGivenValidName()
        {
            var course = new Course("Gosho course");
            Assert.AreEqual("Gosho course", course.Name);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowArgumentNullExceptionWhenTryingToAddNullStudent()
        {
            var course = new Course("Gosho course");
            course.Add(null);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowArgumentNullExceptionWhenTryingToRemoveNullStudent()
        {
            var course = new Course("Gosho course");
            course.Remove(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowInvalidOperationExceptionWhenTryingToRemoveUnexistingStudent()
        {
            var course = new Course("Gosho course");
            var student = new Student("Gosho", 99999);
            course.Remove(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowInvalidOperationExceptionWhenTryingToAddAStudentTwice()
        {
            var course = new Course("Gosho course");
            var student = new Student("Gosho", 99999);
            course.Add(student);
            course.Add(student);
        }

        [TestMethod]
        public void CourseShouldCorrectlyAddAndRemoveStudentWhenGiveValidData()
        {
            var course = new Course("Gosho course");
            var student = new Student("Gosho", 99999);
            course.Add(student);
            Assert.AreSame(student, course.Students.First());
            course.Remove(student);
            Assert.AreEqual(0, course.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CourseShouldThrowArgumentOutOfRangeExceptionWhenTryingToAddTooManyStudents()
        {
            var course = new Course("Gosho course");
            for (int i = 0; i < 31; i++)
            {
                var student = new Student("Gosho", 10000 + i);
                course.Add(student);
            }
        }
    }
}
