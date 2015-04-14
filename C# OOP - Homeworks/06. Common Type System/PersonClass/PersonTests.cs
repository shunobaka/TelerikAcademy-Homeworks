//Problem 4. Person class

//Create a class Person with two fields – name and age.
//Age can be left unspecified (may contain null value.
//Override ToString() to display the information of a person and if age is not specified – to say so.

//Write a program to test this functionality.

namespace PersonClass
{
    using System;

    class PersonTests
    {
        static void Main(string[] args)
        {
            Person personOne = new Person("Pesho Gosho", 30);
            Person personTwo = new Person("Ivan");

            Console.WriteLine(personOne);
            Console.WriteLine();
            Console.WriteLine(personTwo);
        }
    }
}
