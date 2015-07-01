namespace SchoolSystem.Models
{
    using Interfaces;

    public class Student : Person, IPerson, IStudent
    {
        private int classNumber;

        public Student(string name, int classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public Student(string name, int classNumber, string comment)
            : base(name, comment)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            private set
            {
                this.classNumber = value;
            }
        }

        public override string ToString()
        {
            string output = this.Name;
            return output;
        }
    }
}
