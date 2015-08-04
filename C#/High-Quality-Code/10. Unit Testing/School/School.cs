namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        private ICollection<Course> courses;
        private ICollection<Student> students;
        private string name;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
            this.students = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The school name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public ICollection<Course> Courses
        {
            get
            {
                return new List<Course>(this.courses);
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null.");
            }

            if (this.students.Contains(student))
            {
                throw new InvalidOperationException("This student already has joined the school.");
            }

            if (this.students.Any(st => st.Id == student.Id))
            {
                throw new InvalidOperationException("There is already a student in the school with the same id.");
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null.");
            }

            if (!this.students.Contains(student))
            {
                throw new InvalidOperationException("There's no such student in the school.");
            }

            this.students.Remove(student);
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course cannot be null.");
            }

            if (this.courses.Contains(course))
            {
                throw new InvalidOperationException("This course was already added to the school.");
            }

            this.courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course cannot be null.");
            }

            if (!this.courses.Contains(course))
            {
                throw new InvalidOperationException("There's no such course in the school.");
            }

            this.courses.Remove(course);
        }
    }
}
