//Problem 4. Download file

//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        string remoteUri = "http://telerikacademy.com/Content/Images/";
        string fileName = "news-img01.png";
        string webResource = null;
        WebClient myWebClient = new WebClient();
        webResource = remoteUri + fileName;


        Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n", fileName, webResource);
        try
        {
            myWebClient.DownloadFile(webResource, fileName);
            Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, webResource);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("No address given.");
        }
        catch (WebException)
        {
            Console.WriteLine("The file does not exist or the name is empty.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The method has been called simultaneously on multiple threads.");
        }
        finally
        {
            myWebClient.Dispose();
        }
        Console.WriteLine();
    }
}
