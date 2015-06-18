//Problem 17. Date in Bulgarian

//Write a program that reads a date and time given in the format: day.month.year 
//hour:minute:second and prints the date and time after 6 hours and 30 minutes
//(in the same format) along with the day of week in Bulgarian.

using System;
using System.Text;
using System.Globalization;

class DateInBulgarian
{
    static void Main()
    {
        Console.WriteLine("Date format: day.month.year hour:minute:second");
        Console.WriteLine("Please enter date:");
        DateTime input = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        DateTime change = new DateTime();
        change = input.AddHours(6).AddMinutes(30);
        string dayOfWeek = string.Empty;

        switch ((int)change.DayOfWeek)
        {
            case 1: dayOfWeek = "Понеделник"; break;
            case 2: dayOfWeek = "Вторник"; break;
            case 3: dayOfWeek = "Сряда"; break;
            case 4: dayOfWeek = "Четвъртък"; break;
            case 5: dayOfWeek = "Петък"; break;
            case 6: dayOfWeek = "Събота"; break;
            case 0: dayOfWeek = "Неделя"; break;
        }

        Console.WriteLine("The date in 6 hours and 30 minutes:");
        Console.WriteLine("{0:d.MM.yyyy HH:mm:ss} {1}", change, dayOfWeek);
    }
}
