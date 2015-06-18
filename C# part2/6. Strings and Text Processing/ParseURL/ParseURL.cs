//Problem 12. Parse URL

//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//Example:

//URL	                                                         Information
//http://telerikacademy.com/Courses/Courses/Details/212	         [protocol] = http 
//                                                               [server] = telerikacademy.com 
//                                                               [resource] = /Courses/Courses/Details/212

using System;
using System.Text;

class ParseURL
{
    static void Main()
    {
        Console.WriteLine("Please enter URL:");
        string url = Console.ReadLine().Trim();
        string protocol = string.Empty;
        string server = string.Empty;
        string resourse = string.Empty;

        protocol = url.Substring(0, url.IndexOf("://"));
        url = url.Substring(protocol.Length + 3);
        server = url.Substring(0, url.IndexOf("/"));
        url = url.Substring(server.Length + 1);
        resourse = url;
        Console.WriteLine("\nURL Information:");
        Console.WriteLine("[protocol] = {0}",protocol);
        Console.WriteLine("[server] = {0}",server);
        Console.WriteLine("[resourse] = {0}",resourse);
    }
}
