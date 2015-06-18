namespace SchoolSystem.Models
{
    using System.Collections.Generic;
    using Interfaces;

    public class SchoolClass : IClass, ICommentable
    {
        private string identifier;
        private string comment;
        private List<Teacher> teachers;
        private List<Student> students;

        public SchoolClass(string identifier, List<Teacher> teachers, List<Student> students)
        {
            this.Identifier = identifier;
            this.Teachers = teachers;
            this.Students = students;
        }

        public SchoolClass(string identifier, List<Teacher> teachers, List<Student> students, string comment)
            : this(identifier, teachers, students)
        {
            this.Comment = comment;
        }

        public string Identifier
        {
            get
            {
                return this.identifier;
            }
            private set
            {
                this.identifier = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }

        public List<Teacher> Teachers
        {
            get 
            {
                return this.teachers;
            }
            private set
            {
                this.teachers = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            private set
            {
                this.students = value;
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public override string ToString()
        {
            string output = string.Format("Class: {0}\n\nTeachers:\n{1}\n\nStudents:\n{2}", this.identifier, string.Join("\n", teachers), string.Join("\n", students));
            return output;
        }
    }
}
