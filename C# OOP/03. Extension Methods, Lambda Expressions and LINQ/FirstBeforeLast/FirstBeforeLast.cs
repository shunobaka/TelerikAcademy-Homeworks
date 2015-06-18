//Problem 3. First before last

//Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//Use LINQ query operators.

namespace NamesSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Students;

    class NamesSort
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student(){FirstName = "Ivan", LastName = "Georgiev", Age = 15},
                new Student(){FirstName = "Pesho", LastName = "Gosho", Age = 25},
                new Student(){FirstName = "Atanas", LastName = "Nedqlkov", Age = 19},
                new Student(){FirstName = "Bojidar", LastName = "Petkov", Age = 28},
                new Student(){FirstName = "Qnica", LastName = "Draganova", Age = 23}
            };

            Console.WriteLine("Students with first name before last alphabetically:\n");
            List<Student> firstBeforeLast = FirstBeforeLast(students).ToList();

            foreach (var student in firstBeforeLast)
            {
                Console.WriteLine(student.FirstAndLast());
            }
        }

        static IEnumerable<Student> FirstBeforeLast(List<Student> students)
        {
            return from st in students
                   where st.FirstName[0] < st.LastName[0]
                   select st;
        } 
    }
}
