namespace AnimalHierarchy.Models
{
    using System;
    using Interfaces;

    public class Tomcat : Cat, IAnimal, ISound
    {
        public Tomcat(string name, int age)
            : base(name, age, Gender.male)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Grrrr");
        }
    }
}
