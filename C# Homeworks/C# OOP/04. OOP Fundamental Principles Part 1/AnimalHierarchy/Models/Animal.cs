namespace AnimalHierarchy.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    public abstract class Animal : IAnimal, ISound
    {
        private string name;
        private int age;
        private Gender sex;
        private AnimalType type;

        public Animal(string name, int age, Gender sex, AnimalType type)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Type = type;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value >= 0)
                {
                    this.age = value;
                }
            }
        }

        public Gender Sex
        {
            get { return this.sex; }
            private set { this.sex = value; }
        }

        public AnimalType Type 
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Unknown animal sound.");
        }

        public static double AvgAge(IEnumerable<Animal> animals)
        {
            double average = animals.Average(x => x.Age);

            return average;
        }
    }
}
