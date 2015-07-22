namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course, ICourse
    {
        private string town;

        public OffsiteCourse(string courseName, string teacherName, ICollection<string> students, string town)
            : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The town cannot be null or empty!");
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.Append("; Town = ");
            result.Append(this.Town);
            result.Append(" }");
            return result.ToString();
        }
    }
}
