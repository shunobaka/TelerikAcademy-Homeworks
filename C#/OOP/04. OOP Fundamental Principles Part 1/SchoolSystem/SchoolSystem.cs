//Problem 1. School classes

//We are given a school. In the school there are classes of students. Each class has a set of teachers.
//Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique text identifier.
//Teachers have name. Disciplines have name, number of lectures and number of exercises. Both teachers and students are people.
//Students, classes, teachers and disciplines could have optional comments (free text block).
//Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.

namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using Models;

    class SchoolSystem
    {
        static void Main()
        {
            List<Student> class12vstudents = new List<Student>()
            {
                new Student("Ivan Georgiev", 1),
                new Student("Pesho Goshev", 3),
                new Student("Vasko Vasilev", 1),
                new Student("Mashinata", 2)
            };
            List<Discipline> georgiDisciplines = new List<Discipline>()
            {
                new Discipline("Math", 120, 24),
                new Discipline("History", 25, 30)
            };
            List<Discipline> ivanDisciplines = new List<Discipline>()
            {
                new Discipline("Biology", 25, 32)
            };
            List<Teacher> class12vTeachers = new List<Teacher>()
            {
                new Teacher("Georgi Hristov", georgiDisciplines),
                new Teacher("Ivan Tsonev", ivanDisciplines)
            };
            List<SchoolClass> classes = new List<SchoolClass>()
            {
                new SchoolClass("12v", class12vTeachers, class12vstudents)
            };
            School school = new School("Kvartalnoto daskalo", classes);

            List<Teacher> class12gTeachers = new List<Teacher>()
            {
                new Teacher("Georgi Hristov", georgiDisciplines),
                new Teacher("Vanq Popova", new List<Discipline>() { new Discipline("Physics", 23, 23) })
            };
            List<Student> class12gStudents = new List<Student>()
            {
                new Student("Vancho", 1)
            };

            class12gTeachers.Add(new Teacher("Hristo Hristov", new List<Discipline>(){new Discipline("Physicology",12, 12)}));
            class12gStudents.Add(new Student("Sasho Minchev", 5));
            classes.Add(new SchoolClass("12g",class12gTeachers, class12gStudents));

            Console.WriteLine(school);
        }
    }
}
