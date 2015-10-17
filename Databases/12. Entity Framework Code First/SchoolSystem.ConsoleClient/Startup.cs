namespace SchoolSystem.ConsoleClient
{
    using SchoolSystem.Data;
    using SchoolSystem.Data.Migrations;
    using SchoolSystem.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolSystemDbContext, Configuration>());

            SchoolSystemDbContext schoolSystemContext = new SchoolSystemDbContext();

            schoolSystemContext
                .Students
                    .FirstOrDefault()
                    .Courses
                    .Add(new Course()
                    {
                        Name = "Testing course",
                        Description = "Just another useless course",
                    });

            schoolSystemContext.SaveChanges();

            foreach (var course in schoolSystemContext.Courses.Include("Students"))
            {
                Console.WriteLine(course.Name);
                foreach (var student in course.Students)
                {
                    Console.Write(" --> " + student.Name + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
