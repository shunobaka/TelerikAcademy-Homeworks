namespace SchoolSystem.Data.Migrations
{
    using SchoolSystem.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<SchoolSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SchoolSystemDbContext context)
        {
            context.Courses.AddOrUpdate(c => c.Name,
                new Course()
                {
                    Name = "C# High-Quality-Code",
                },
                new Course()
                {
                    Name = "Databases"
                },
                new Course()
                {
                    Name = "HTML"
                }
            );

            context.Students.AddOrUpdate(s => s.Name,
                new Student()
                {
                    Name = "Gosho",
                    Number = 344924934,
                    Homeworks = new HashSet<Homework>()
                    {
                        new Homework()
                        {
                            Content = "Empty",
                            CourseId = 1,
                            TimeSent = DateTime.Now
                        }
                    }
                },
                new Student()
                {
                    Name = "Ivan",
                    Number = 231323132,
                    Homeworks = new HashSet<Homework>()
                    {
                        new Homework()
                        {
                            Content = "Kutiq s taini",
                            CourseId = 1
                        }
                    }
                },
                new Student()
                {
                    Name = "Pesho",
                    Number = 32132,
                    Homeworks = new HashSet<Homework>()
                    {
                        new Homework()
                        {
                            Content = "Databases",
                            CourseId = 1
                        },
                        new Homework()
                        {
                            Content = "High Quality Code",
                            CourseId = 1
                        }
                    }
                },
                new Student()
                {
                    Name = "Stamat",
                    Number = 1
                }
            );
        }
    }
}
