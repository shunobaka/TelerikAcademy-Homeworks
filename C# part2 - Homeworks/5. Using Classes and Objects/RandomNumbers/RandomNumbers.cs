//Problem 2. Random numbers

//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class RandomNumbers
    {
        static Random rnd = new Random();

        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i != 9)
                {
                    Console.Write(rnd.Next(100, 200) + ", ");
                }
                else
                {
                    Console.Write(rnd.Next(100, 200));
                }
            }
            Console.WriteLine();
        }
    }
}
