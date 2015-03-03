//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccData
{
    static void Main()
    {
        string firstName = "Gosho";
        string middleName = "Peshov";
        string lastName = "Toshev";
        decimal balance = 245900.55m;
        string bankName = "FiBank";
        string iban = "BG81 BNBG 0543 0594 4822 55";
        long firstCard = 12345678910;
        long secondCard = 213232185824;
        long thirdCard = 32859357825341;
    }
}
