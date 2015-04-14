namespace AnimalHierarchy.Models
{
    using System;
    using Interfaces;

    public class Kitten : Cat, IAnimal, ISound 
    {
        public Kitten(string name, int age)
            : base(name, age, Gender.female)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Mew!");
        }
    }
}
