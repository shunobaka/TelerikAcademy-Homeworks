namespace AnimalHierarchy.Models
{
    using System;
    using Interfaces;

    public class Frog : Animal, IAnimal, ISound
    {
        public Frog(string name, int age, Gender sex)
            : base(name, age, sex, AnimalType.Frog)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Ribbit Ribbit..");
        }
    }
}
