﻿//Problem 15. Extract marks

//Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

namespace ExtractMarksByYear
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Students;

    class ExtractMarksFromYear
    {
        static void Main()
        {
            List<Student> students = GetStudents();

            var marksFrom2006 = students.Where(st => st.FN.Substring(4, 2) == "06").Select(st => string.Join(", ", st.Marks)).ToList();

            Console.WriteLine("List of all marks from 2006:\n");
            Console.WriteLine(string.Join(", ", marksFrom2006));
        }

        static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){FirstName = "Ivan", LastName = "Georgiev", Age = 15, Email = "vankata214@abv.bg", 
                    GroupNumber = 2, Tel = "(03) 545 543 654", FN = "543534232", Marks = new List<int>{2, 6, 5, 2}},
                new Student(){FirstName = "Pesho", LastName = "Gosho", Age = 25, Email = "programista@abv.bg", 
                    GroupNumber = 5, Tel = "(04) 545 543 654", FN = "756806765", Marks = new List<int>{2, 2, 2, 2}},
                new Student(){FirstName = "Atanas", LastName = "Nedqlkov", Age = 19, Email = "nasko.nedqlkov@gmail.com", 
                    GroupNumber = 2, Tel = "(01) 545 543 654", FN = "58450693412", Marks = new List<int>{6, 6, 5, 4}},
                new Student(){FirstName = "Bojidar", LastName = "Petkov", Age = 28, Email = "mashinataBP@abv.bg", 
                    GroupNumber = 1, Tel = "(02) 545 543 654", FN = "5349063842843", Marks = new List<int>{4, 5, 4, 6}},
                new Student(){FirstName = "Qnica", LastName = "Draganova", Age = 23, Email = "qnica.d@hotmail.com", 
                    GroupNumber = 3, Tel = "(02) 545 543 654", FN = "65440643243", Marks = new List<int>{2, 3, 2, 4}}
            };

            return students;
        }
    }
}
