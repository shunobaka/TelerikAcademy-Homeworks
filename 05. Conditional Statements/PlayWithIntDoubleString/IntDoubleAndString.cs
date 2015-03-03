//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;

class IntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        Console.Write("Please choose a type: ");
        int choice = int.Parse(Console.ReadLine());
        int intNumber = new int();
        double doubleNumber = new double();
        string text;

        switch (choice)
        {
            case 1:
                Console.Write("Please enter an integer: ");
                intNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(intNumber + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleNumber + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                text = Console.ReadLine();
                Console.WriteLine(text + "*");
                break;
        }
    }
}
