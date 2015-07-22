namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course : ICourse
    {
        private string name;
        private string teacherName;
        private ICollection<string> students;

        protected Course(string courseName)
            : this(courseName, null)
        {
        }

        protected Course(string courseName, string teacherName)
            : this(courseName, teacherName, new List<string>())
        {
        }

        protected Course(string courseName, string teacherName, ICollection<string> students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The course name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The teacher name cannot be null or empty!");
                }

                this.teacherName = value;
            }
        }

        public ICollection<string> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The students list cannot be null!");
                }

                this.students = new List<string>();

                foreach (string student in value)
                {
                    if (string.IsNullOrWhiteSpace(student))
                    {
                        throw new ArgumentException("The student name cannot be null or empty!");
                    }

                    this.students.Add(student);
                }
            }
        }

        protected string GetStudentsAsString()
        {
            string students = "{ " + string.Join(", ", this.Students) + " }";
            return students;
        }

        protected override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse { Name = ");
            result.Append(this.Name);
            result.Append("; Teacher = ");
            result.Append(this.TeacherName);
            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            return result.ToString();
        }
    }
}
