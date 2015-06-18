//Problem 16. Date difference

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:

//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days

using System;
using System.Text;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        Console.WriteLine("Date format: day.month.year");
        Console.Write("Enter the first date: ");
        DateTime dateOne = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
        Console.Write("Enter the second date: ");
        DateTime dateTwo = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

        TimeSpan difference = dateTwo - dateOne;
        Console.WriteLine("Distance: {0} days",difference.Days);
    }
}
