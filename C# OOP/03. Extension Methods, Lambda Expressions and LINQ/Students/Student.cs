//Problem 9. Student groups

//Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.

namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string FN { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public byte GroupNumber { get; set; }

        public override string ToString()
        {
            StringBuilder students = new StringBuilder();
            students.AppendLine(string.Format("Name: {0} {1}, age: {2}", this.FirstName, this.LastName, this.Age));
            students.AppendLine(string.Format("Email: {0}", this.Email));
            students.AppendLine(string.Format("Group: {0}", this.GroupNumber));
            students.AppendLine(string.Format("Tel.: {0}", this.Tel));
            students.AppendLine(string.Format("FN: {0}", this.FN));
            students.AppendLine(string.Format("Marks: {0}", string.Join(", ", this.Marks)));

            return students.ToString();
        }

        public string FirstAndLast()
        {
            string names = String.Format("Name: {0} {1}", this.FirstName, this.LastName);
            return names;
        }
    }
}
