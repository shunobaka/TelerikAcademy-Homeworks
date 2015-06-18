//Problem 4. Sub-string in text

//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:

//The target sub-string is in

//The text is as follows: 
//We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The result is: 9

using System;
using System.Text;

class SubStringInText
{
    static void Main()
    {
        string input = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        Console.WriteLine(input);
        int startIndex = new int();
        int indexOf = new int();
        int inCount = new int();

        while (true)
        {
            indexOf = input.IndexOf("in", startIndex);
            if (indexOf >= 0)
            {
                inCount++;
                startIndex = indexOf + 1;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("The count of \"in\" in the text is: {0}", inCount);
    }
}
