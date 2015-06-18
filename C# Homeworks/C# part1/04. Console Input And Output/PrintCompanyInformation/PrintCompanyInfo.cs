//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Company's name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company's address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Company's phone: ");
        string companyPhone = Console.ReadLine();
        Console.Write("Company's fax: ");
        string fax = Console.ReadLine();
        Console.Write("Company's website: ");
        string website = Console.ReadLine();
        Console.Write("Manager's first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager's last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager's age: ");
        string managerAge = Console.ReadLine();
        Console.Write("Manager's phone: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine("{0} \nAddress: {1} \nTel. {2} \nFax: {3} " +
        "\nWeb Site: {4} \nManager: {5} {6} (age: {7}, tel. {8})"
        ,companyName,companyAddress,companyPhone,fax,website
        ,managerFirstName,managerLastName,managerAge,managerPhone);
    }
}
