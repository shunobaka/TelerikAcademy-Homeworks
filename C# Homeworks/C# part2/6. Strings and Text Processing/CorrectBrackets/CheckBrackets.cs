//Problem 3. Correct brackets

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). 
//Example of incorrect expression: )(a+b)).

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter expression: ");
        string input = Console.ReadLine().Trim();
        int bracketCount = new int();
        bool correctExpression = true;

        foreach (char symbol in input)
        {
            if (symbol == '(')
            {
                bracketCount++;
            }
            else if (symbol == ')')
            {
                bracketCount--;
            }

            if (bracketCount < 0)
            {
                correctExpression = false;
                break;
            }
        }

        Console.WriteLine("The expression is correct: {0}", correctExpression);
    }
}
