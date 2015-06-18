//Problem 19. Dates from text in Canada

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;

class DatesFromText
{
    static void Main()
    {
        string inputText = "This is a text from 22.10.2013. The date today is 25.02.2015 blahblah";
        Console.WriteLine(inputText);
        var regex = new Regex(@"\b\d{2}\.\d{2}.\d{4}\b");
        Console.WriteLine("\nExtracted dates from the text:");
        foreach (Match m in regex.Matches(inputText))
        {
            DateTime dt;
            if (DateTime.TryParseExact(m.Value, "dd.MM.yyyy", null, DateTimeStyles.None, out dt))
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
                Console.WriteLine(dt.ToString("d"));
            }
        }
    }
}
