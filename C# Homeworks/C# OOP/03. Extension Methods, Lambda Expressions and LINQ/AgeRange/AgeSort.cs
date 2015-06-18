//Problem 4. Age range

//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

namespace AgeRange
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Students;

    class AgeSort
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student(){FirstName = "Ivan", LastName = "Georgiev", Age = 15},
                new Student(){FirstName = "Pesho", LastName = "Gosho", Age = 25},
                new Student(){FirstName = "Atanas", LastName = "Nedjalkov", Age = 19},
                new Student(){FirstName = "Bojidar", LastName = "Petkov", Age = 28},
                new Student(){FirstName = "Janica", LastName = "Draganova", Age = 23}
            };

            List<Student> inAgeRange = (from st in students
                                               where st.Age >= 18 && st.Age <= 24
                                               select st).ToList();

            Console.WriteLine("Students between age of 18 and 24:\n");

            foreach (var student in inAgeRange)
            {
                Console.WriteLine(student.FirstAndLast());
            }
        }
    }
}
