namespace BoolToStringConverter
{
    using System;

    public class Converter
    {
        private const int MaxCount = 6;

        public void PrintAsString(bool boolInput)
        {
            string inputAsString = boolInput.ToString();
            Console.WriteLine(inputAsString);
        }
    }
}
