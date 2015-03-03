//Problem 1. Leap year

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class LeapYear
    {
        static void Main()
        {
            Console.WriteLine("Enter year to check:");
            int year = int.Parse(Console.ReadLine());
            bool isLeap = DateTime.IsLeapYear(year);
            Console.WriteLine("Is {0} leap? - {1}", year, isLeap);
        }
    }
}
