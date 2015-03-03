//Problem 2. Float or Double?

//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class FloatAndDouble
{
    static void Main()
    {
        double number1 = 34.567839023d;
        float number2 = 12.345f;
        double number3 = 8923.1234857d;
        float number4 = 3456.091f;
        Console.WriteLine(number1);
        Console.WriteLine(number2);
        Console.WriteLine(number3);
        Console.WriteLine(number4);
    }
}
