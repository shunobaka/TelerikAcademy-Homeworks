namespace Methods
{
    using System;

    public class Student
    {
        public Student(string firstName, string lastName, DateTime birthDate, string town, string additionalInfo = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Town = town;
            this.AdditionalInfo = additionalInfo;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Town { get; set; }

        public string AdditionalInfo { get; set; }

        public bool IsOlderThan(Student otherStudent)
        {
            return this.BirthDate < otherStudent.BirthDate;
        }
    }
}
