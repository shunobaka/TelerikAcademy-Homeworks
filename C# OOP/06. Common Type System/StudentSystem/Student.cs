namespace StudentSystem
{
    using System;
    using System.Text;
    using Interfaces;
    using Enumarations;

    public class Student : Object, IStudent, ICloneable, IComparable
    {
        #region Fields
        private string firstName;
        private string middleName;
        private string lastName;
        private int ssn;
        private string address;
        private int phone;
        private string email;
        private string course;
        private Faculty faculty;
        private University university;
        private Speciality speciality;
        #endregion

        public Student(string firstName, string middleName, string lastName, int ssn)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
        }

        #region Properties
        public string FirstName
        {
            get { return this.firstName; }
            private set { this.firstName = value; }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            private set { this.middleName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set { this.lastName = value; }
        }

        public int SSN
        {
            get { return this.ssn; }
            private set { this.ssn = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public int Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Course
        {
            get { return this.course; }
            set { this.course = value; }
        }

        public Speciality Speciality
        {
            get { return this.speciality; }
            set { this.speciality = value; }
        }

        public Faculty Faculty
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }

        public University Univerity
        {
            get { return this.university; }
            set { this.university = value; }
        }
        #endregion

        #region Overrides
        public override bool Equals(object obj)
        {
            if (obj is Student)
            {
                var student = obj as Student;
                if (student.FirstName == this.FirstName && student.LastName == this.LastName)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (this.SSN.GetHashCode() ^ this.Phone.GetHashCode() ^ this.LastName.GetHashCode());
        }

        public override string ToString()
        {
            StringBuilder studentAsString = new StringBuilder();
            studentAsString.AppendLine(string.Format("Name: {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            studentAsString.AppendLine(string.Format("Address: {0}", this.Address));
            studentAsString.AppendLine(string.Format("Email: {0}", this.Email));
            studentAsString.AppendLine(string.Format("University: {0}", this.Univerity));
            studentAsString.AppendLine(string.Format("Faculty: {0}", this.Faculty));
            studentAsString.AppendLine(string.Format("Speciality: {0}", this.Speciality));
            studentAsString.Append(string.Format("Course: {0}", this.Course));
            return studentAsString.ToString();
        }

        public static bool operator !=(Student stOne, Student stTwo)
        {
            return !stOne.Equals(stTwo);
        }

        public static bool operator ==(Student stOne, Student stTwo)
        {
            return stOne.Equals(stTwo);
        }
        #endregion

        public object Clone()
        {
            Student newStudent = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN)
            {
                Address = this.Address,
                Phone = this.Phone,
                Email = this.Email,
                Course = this.Course,
                Faculty = this.Faculty,
                Univerity = this.Univerity,
                Speciality = this.Speciality
            };
            return newStudent;
        }

        public int CompareTo(object obj)
        {
            if (obj is Student)
            {
                Student st = obj as Student;

                if (this.FirstName.CompareTo(st.FirstName) != 0)
                {
                    return this.FirstName.CompareTo(st.FirstName);
                }
                if (this.MiddleName.CompareTo(st.MiddleName) != 0)
                {
                    return this.MiddleName.CompareTo(st.MiddleName);
                }
                if (this.LastName.CompareTo(st.LastName) != 0)
                {
                    return this.LastName.CompareTo(st.LastName);
                }
                if (this.SSN.CompareTo(st.SSN) != 0)
                {
                    return this.SSN.CompareTo(st.SSN);
                }
                return 0;
            }
            throw new FormatException("Can only be compared to another student!");
        }
    }
}
