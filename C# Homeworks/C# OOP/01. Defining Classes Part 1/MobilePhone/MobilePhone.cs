// Homework problems: https://github.com/TelerikAcademy/Object-Oriented-Programming/blob/master/01.%20Defining%20Classes%20-%20Part%201/README.md

// Remove the comment from the tests in the main method!!!
// Remove the comment from the tests in the main method!!!
// Remove the comment from the tests in the main method!!!
// Remove the comment from the tests in the main method!!!
// Remove the comment from the tests in the main method!!!
// Remove the comment from the tests in the main method!!!

namespace MobilePhone
{
    using System;

    class MobilePhone
    {
        static void Main()
        {
            // First test to print GSMs from GSMTest call

            foreach (var phone in GSMTest.Phones)
            {
                Console.WriteLine(phone.ToString());
            }
            Console.WriteLine(GSM.IPhone4S);


            // Second test to print call history and price of calls

            // GSM newPhone = new GSM("dsadsa", "dsadsda");
            // Call newCall = new Call("12.12", "12:12", 3231232323123, 300);
            // Call secondCall = new Call("11.14", "11:34", 2323124241, 10000);
            // newPhone.AddCall(newCall);
            // newPhone.AddCall(secondCall);
            // newPhone.AddCall(new Call("02.02", "03:22", 2312424214, 2313));
            // Console.WriteLine("List of calls:\n");
            // Console.WriteLine(newPhone.PrintCalls());
            // Console.WriteLine();
            // Console.WriteLine(newPhone.CallPrice());
            // Console.WriteLine();
        }
    }
}
