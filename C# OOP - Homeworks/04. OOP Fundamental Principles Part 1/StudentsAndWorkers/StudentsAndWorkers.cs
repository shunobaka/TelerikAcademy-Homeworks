//Problem 2. Students and workers

//Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade.
//Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker.
//Define the proper constructors and properties for this hierarchy.
// - Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
// - Initialize a list of 10 workers and sort them by money per hour in descending order.
// - Merge the lists and sort them by first name and last name.

namespace StudentsAndWorkers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Models;

    class StudentsAndWorkers
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Strahimir", "Iotov", 4.20),
                new Student("Spas", "Atanasov", 5.55),
                new Student("Veselin", "Zhetchev", 5.92),
                new Student("Grigor","Arnaudov", 3.33),
                new Student("Putin", "Vladimir", 6.00),
                new Student("Pesho", "Krika", 2.01),
                new Student("Evtimii", "Ivanovich", 2.49),
                new Student("Pamel", "Anderson", 5.37),
                new Student("Sevda", "Goranova", 4.69),
                new Student("Soren", "Biurg", 2.75)
            };

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Natasha", "Dimitrova", 100, 12),
                new Worker("Cho", "Ming", 1000, 4),
                new Worker("Ping", "Vin", 325, 8),
                new Worker("Dimitar", "Berbatov", 10000, 2),
                new Worker("Richard", "Papilon", 420, 6),
                new Worker("Hristo", "Georgiev", 175, 8),
                new Worker("Kiril", "Spasov", 120, 7),
                new Worker("Yao", "Ming", 500, 6),
                new Worker("Vin", "Diesel", 2500, 8),
                new Worker("Bobi", "Djurov", 1300, 5)
            };

            List<Worker> sortedWorkers = (from worker in workers
                                          orderby worker.MoneyPerHour() descending
                                          select worker).ToList();

            List<Student> sortedStudents = (from st in students
                                            orderby st.Grade
                                            select st).ToList();

            var listOfHumans = new List<Human>();
            listOfHumans.AddRange(students);
            listOfHumans.AddRange(workers);

            listOfHumans = listOfHumans
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToList();

            Console.WriteLine("Workers sorted descending by money per hour:\n");
            Console.WriteLine(string.Join("\n", sortedWorkers));
            Console.WriteLine("\nStudents sorted ascending by grade:\n");
            Console.WriteLine(string.Join("\n", sortedStudents));
            Console.WriteLine("\nAll humans sorted by first and then last name:\n");
            Console.WriteLine(string.Join("\n", listOfHumans.Select(x => string.Format("{0} {1}", x.FirstName, x.LastName))));

            
        }
    }
}
