namespace StudentsAndWorkers.Models
{
    using Interfaces;

    public class Student : Human, IStudent, IHuman
    {
        private double grade;

        public Student(string firstName, string lastName, double grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                this.grade = value;
            }
        }

        public override string ToString()
        {
            string toString = string.Format("{0, -17} - Grade: {1:F2}", base.fullName, this.Grade);
            return toString;
        }
    }
}
