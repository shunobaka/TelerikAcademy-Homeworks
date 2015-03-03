//Problem 4. Print a Deck of 52 Cards

//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;

class PrintDeck
{
    static void Main()
    {
        string cardNumber = "";
        string cardSuit = "";
        for (int i = 2; i <= 14; i++)
        {
            switch (i)
            {
                case 2: cardNumber = "2"; break;
                case 3: cardNumber = "3"; break;
                case 4: cardNumber = "4"; break;
                case 5: cardNumber = "5"; break;
                case 6: cardNumber = "6"; break;
                case 7: cardNumber = "7"; break;
                case 8: cardNumber = "8"; break;
                case 9: cardNumber = "9"; break;
                case 10: cardNumber = "10"; break;
                case 11: cardNumber = "J"; break;
                case 12: cardNumber = "Q"; break;
                case 13: cardNumber = "K"; break;
                case 14: cardNumber = "A"; break;
            }
            for (int suit = 1; suit <= 4; suit++)
            {
                switch (suit)
                {
                    case 1: cardSuit = "spades"; break;
                    case 2: cardSuit = "clubs"; break;
                    case 3: cardSuit = "hearts"; break;
                    case 4: cardSuit = "diamonds"; break;
                }
                Console.Write("{0} of {1}, ", cardNumber, cardSuit);
            }
            Console.WriteLine();
        }
    }
}
