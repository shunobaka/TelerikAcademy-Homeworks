//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullVariables
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;
        Console.WriteLine("Int before adding: " + nullInt);
        Console.WriteLine("Double before adding: " + nullDouble);
        nullInt += 1;
        nullDouble += 3;
        Console.WriteLine("Int after adding: " + nullInt);
        Console.WriteLine("Double after adding: " + nullDouble);
    }
}
