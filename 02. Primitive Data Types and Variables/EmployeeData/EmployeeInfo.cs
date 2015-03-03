//Problem 10. Employee Data

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;

class EmployeeInfo
{
    static void Main()
    {
        string firstName = "Gosho";
        string secondName = "Peshov";
        byte age = 56;
        char gender = 'm';
        long id = 8306112507;
        int uniqueNumber = 27560000;
        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Second Name: " + secondName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("gender: " + gender);
        Console.WriteLine("Personal ID: " + id);
        Console.WriteLine("Unique Number: " + uniqueNumber);
    }
}
