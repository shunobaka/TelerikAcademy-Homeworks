//Problem 7. Encode/decode

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first
//letter of the string with the first of the key, the second – with the second, etc. When
//the last key character is reached, the next is the first.

using System;
using System.Text;

class EncodeAndDecode
{
    static void Main()
    {
        string text = "Highly protected encoded text!";
        string key = "verystrongencription";

        string encoded = string.Empty;
        string decoded = string.Empty;

        encoded = Encode(text, key);
        decoded = Decode(encoded, key);
        Console.WriteLine("The text encoded:\n{0}", encoded);
        Console.WriteLine("\nThe text decoded:\n{0}\n", decoded);
    }

    static string Encode(string text, string key)
    {
        int keyIndex = new int();
        char currentResult = new char();
        StringBuilder encoded = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            if (keyIndex >= key.Length)
            {
                keyIndex = 0;
            }
            currentResult = (char)(text[i] ^ key[keyIndex]);
            encoded.Append(currentResult);
            keyIndex++;
        }

        return encoded.ToString();
    }

    static string Decode(string encoded, string key)
    {
        int keyIndex = new int();
        char currentResult = new char();
        StringBuilder decoded = new StringBuilder();

        for (int i = 0; i < encoded.Length; i++)
        {
            if (keyIndex >= key.Length)
            {
                keyIndex = 0;
            }
            currentResult = (char)(encoded[i] ^ key[keyIndex]);
            decoded.Append(currentResult);
            keyIndex++;
        }

        return decoded.ToString();
    }
}
