namespace AnimalHierarchy.Models
{
    using System;
    using Interfaces;

    public class Cat : Animal, IAnimal, ISound
    {
        public Cat(string name, int age, Gender sex)
            : base(name, age, sex, AnimalType.Cat)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Meeeoooow :3");
        }
    }
}
