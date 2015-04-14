namespace AnimalHierarchy.Models
{
    using System;
    using Interfaces;

    public class Dog : Animal, IAnimal, ISound
    {
        public Dog(string name, int age, Gender sex)
            : base(name, age, sex, AnimalType.Dog)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof woof!");
        }
    }
}
