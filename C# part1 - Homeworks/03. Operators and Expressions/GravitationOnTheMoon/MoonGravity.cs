//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class MoonGravity
{
    static void Main()
    {
        string inputWeight = Console.ReadLine();
        float earthWeight = int.Parse(inputWeight);
        float moonWeight = earthWeight * 0.17f;
        Console.WriteLine("If you weight {0}kg on the earth, you'll weight {1:F2}kg on the moon.", earthWeight, moonWeight);
    }
}
