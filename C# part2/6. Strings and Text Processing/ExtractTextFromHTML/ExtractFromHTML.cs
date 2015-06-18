//Problem 25. Extract text from HTML

//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

//Example input:
//<html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skilful .NET software engineers.</p></body>
//</html>

//Output:
//Title: News

//Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractFromHTML
{
    static void Main()
    {
        string input = "<html> <head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";
        int tagStartIndex = new int();
        int tagEndIndex = new int();
        string title = string.Empty;
        StringBuilder text = new StringBuilder();
        text.Append(input);

        tagStartIndex = input.IndexOf("<title>");
        if (tagStartIndex >= 0)
        {
            tagEndIndex = input.IndexOf("</title>");
            title = input.Substring(tagStartIndex + 7, tagEndIndex - tagStartIndex - 7);
            text.Remove(0, tagEndIndex);
        }

        tagEndIndex = 0;
        tagStartIndex = 0;

        while (true)
        {
            tagStartIndex = text.ToString().IndexOf("<");
            tagEndIndex = text.ToString().IndexOf(">");

            if (tagStartIndex >= 0 && tagEndIndex >= 0)
            {
                text.Remove(tagStartIndex, tagEndIndex - tagStartIndex + 1);
                text.Insert(tagStartIndex, ' ');
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("Title: {0}", title);
        Console.WriteLine("\nText: {0}", text.ToString().Trim());
    }
}
