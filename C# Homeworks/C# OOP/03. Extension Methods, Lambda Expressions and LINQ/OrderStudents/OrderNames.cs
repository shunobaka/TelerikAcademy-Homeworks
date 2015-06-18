//Problem 5. Order students

//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
//Rewrite the same with LINQ.

namespace OrderStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Students;

    class OrderNames
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student(){FirstName = "Ivan", LastName = "Georgiev", Age = 15},
                new Student(){FirstName = "Pesho", LastName = "Gosho", Age = 25},
                new Student(){FirstName = "Atanas", LastName = "Nedqlkov", Age = 19},
                new Student(){FirstName = "Bojidar", LastName = "Petkov", Age = 28},
                new Student(){FirstName = "Qnica", LastName = "Draganova", Age = 23},
                new Student(){FirstName = "Qnica", LastName = "Asenova", Age = 36},
                new Student(){FirstName = "Qnica", LastName = "Ivanova", Age = 40},
                new Student(){FirstName = "Ivan", LastName = "Petrov", Age = 34},
                new Student(){FirstName = "Atanas", LastName = "Jankov", Age = 29}
            };

            IEnumerable<Student> orderedStudents = students
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName)
                .ToList();

            Console.WriteLine("Students ordered descending by first and then second name:\n");
            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student.FirstAndLast());
            }

            IEnumerable<Student> orderedWithLinq = from st in students
                                                   orderby st.FirstName descending,
                                                   st.LastName descending
                                                   select st;

            Console.WriteLine("\nAgain using LINQ:\n");
            foreach (var student in orderedWithLinq)
            {
                Console.WriteLine(student.FirstAndLast());
            }
        }
    }
}
