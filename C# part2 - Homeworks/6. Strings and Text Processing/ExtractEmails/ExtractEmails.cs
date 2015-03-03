//Problem 18. Extract e-mails

//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;

class ExtractEmails
{
    static void Main()
    {
        string input = "This is a text with emails such as random@email.com and another@email.bg. Yet another email test@testing.uk";
        int atSignIndex = new int();
        int domainStart = new int();
        int domainEnd = new int();
        int emailStart = new int();
        string identifier = string.Empty;
        string host = string.Empty;
        string domain = string.Empty;

        Console.WriteLine("Extracted emails from text:");

        atSignIndex = input.IndexOf("@");
        while (atSignIndex > 0)
        {
            emailStart = input.LastIndexOf(" ", atSignIndex);
            identifier = input.Substring(emailStart + 1, atSignIndex - emailStart - 1);
            domainStart = input.IndexOf(".", atSignIndex);
            host = input.Substring(atSignIndex + 1, domainStart - atSignIndex - 1);
            for (int index = domainStart + 1; index < input.Length; index++)
            {
                if ((input[index] <= 'a' || input[index] >= 'z') && (input[index] <= 'A' || input[index] >= 'Z'))
                {
                    domainEnd = index;
                    break;
                }
                domainEnd = index + 1;
            }
            domain = input.Substring(domainStart + 1, domainEnd - domainStart - 1);
            Console.WriteLine("{0}@{1}.{2}",identifier, host, domain);
            input = input.Substring(domainEnd, input.Length - domainEnd);
            atSignIndex = input.IndexOf("@");
        }
        Console.WriteLine();
    }
}
