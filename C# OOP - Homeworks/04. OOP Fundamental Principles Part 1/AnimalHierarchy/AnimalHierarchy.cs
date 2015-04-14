//Problem 3. Animal hierarchy

//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals.
//All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex.
//Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
// - Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using Models;

    class AnimalHierarchy
    {
        static void Main()
        {
            Kitten maca = new Kitten("Maca", 1);
            Cat tomas = new Cat("Tomas", 5, Gender.male);
            Dog sharo = new Dog("Sharo", 5, Gender.male);
            Frog kroko = new Frog("Kroko", 3, Gender.male);
            Tomcat herkules = new Tomcat("Herkules", 20);

            List<Kitten> kittens = new List<Kitten>()
            {
                maca,
                new Kitten("Pisi", 2),
                new Kitten("Lapa", 1)
            };

            Cat[] cats = new Cat[]
            {
                tomas,
                new Cat("Gosho", 4, Gender.male),
                new Cat("Sara", 8, Gender.female),
                new Cat("Pesho", 11, Gender.male)
            };

            Dog[] dogs = new Dog[]
            {
                sharo,
                new Dog("Chocho", 16, Gender.male),
                new Dog("Lucky", 8, Gender.female),
                new Dog("Sara", 10, Gender.female)
            };

            List<Frog> frogs = new List<Frog>()
            {
                kroko,
                new Frog("Kroki", 2, Gender.female)
            };

            Tomcat[] tomcats = new Tomcat[]
            {
                herkules,
                new Tomcat("Paul", 11),
                new Tomcat("Richard", 9)
            };

            Console.WriteLine("Average ages of animals in collections:");
            Console.WriteLine(string.Format("Tomcats: {0:F2}",Animal.AvgAge(tomcats)));
            Console.WriteLine(string.Format("Kittens: {0:F2}", Animal.AvgAge(kittens)));
            Console.WriteLine(string.Format("Cats: {0:F2}",Animal.AvgAge(cats)));
            Console.WriteLine(string.Format("Dogs: {0:F2}", Animal.AvgAge(dogs)));
            Console.WriteLine(string.Format("Frogs: {0:F2}", Animal.AvgAge(frogs)));

            Console.WriteLine("\nSounds the animals make:");
            Console.Write("Kitten: ");
            maca.MakeSound();
            Console.Write("Tomcat: ");
            herkules.MakeSound();
            Console.Write("Cat: ");
            tomas.MakeSound();
            Console.Write("Dog: ");
            sharo.MakeSound();
            Console.Write("Frog: ");
            kroko.MakeSound();
        }
    }
}
