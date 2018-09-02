using System;
using System.Text.RegularExpressions;

namespace _01.ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            MatchCollection matches = Regex.Matches(Console.ReadLine(),
             @"(?<=\s)([a-z]+|\d+)(\d+|\w+|\.+|-+)([a-z]+|\d+)\@[a-z]+\-?[a-z]+\.[a-z]+(\.[a-z]+)?");
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
