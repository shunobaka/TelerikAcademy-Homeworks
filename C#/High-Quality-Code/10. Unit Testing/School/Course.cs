namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MaxStudentsInCourse = 30;
        private string name;
        private ICollection<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
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
                    throw new ArgumentNullException("Course name cannot be null, empty or whitespace.");
                }

                this.name = value;
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public void Add(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null.");
            }

            if (this.students.Count >= MaxStudentsInCourse)
            {
                throw new ArgumentOutOfRangeException("The course is full and cannot add the student.");
            }

            if (this.students.Contains(student))
            {
                throw new InvalidOperationException("This student already has joined the class.");
            }

            this.students.Add(student);
        }

        public void Remove(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null.");
            }

            if (!this.students.Contains(student))
            {
                throw new InvalidOperationException("There's no such student in the class.");
            }

            this.students.Remove(student);
        }
    }
}
