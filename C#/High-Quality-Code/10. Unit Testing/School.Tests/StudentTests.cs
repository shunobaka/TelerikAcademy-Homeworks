namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowArgumentNullExceptionWhenCreatedWithNullName()
        {
            var student = new Student(null, 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowArgumentNullExceptionWhenCreatedWithEmptyString()
        {
            var student = new Student(string.Empty, 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowArgumentNullExceptionWhenCreatedWithWhitespace()
        {
            var student = new Student("  ", 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentShouldThrowArgumentOutOfRangeExceptionWhenIdIsBelowMinimum()
        {
            var student = new Student("Gosho", 9999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentShouldThrowArgumentOutOfRangeExceptionWhenIdIsAboveMaximum()
        {
            var student = new Student("Gosho", 100000);
        }

        [TestMethod]
        public void StudentShouldBeInitializedProperlyWhenGivenValidNameAndId()
        {
            var student = new Student("Gosho", 99999);
            Assert.AreEqual("Gosho", student.Name);
            Assert.AreEqual(99999, student.Id);
        }
    }
}
