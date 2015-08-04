﻿namespace School
{
    using System;

    public class Student
    {
        private const int MinIdValue = 10000;
        private const int MaxIdValue = 99999;
        private string name;
        private int id;

        public Student(string name, int id)
        {
            this.Name = name;
            this.Id = id;
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
                    throw new ArgumentNullException("The name of the student cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            private set
            {
                if (value < MinIdValue || MaxIdValue < value)
                {
                    throw new ArgumentOutOfRangeException(string.Format("The student id must be between {0} and {1}", MinIdValue, MaxIdValue));
                }

                this.id = value;
            }
        }
    }
}
