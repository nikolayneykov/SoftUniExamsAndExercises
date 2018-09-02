using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _01.MatchFullName
{
    class MatchFullName
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string names = Console.ReadLine();
            MatchCollection matchedNames = Regex.Matches(names, pattern);
            foreach (Match match in matchedNames)
            {
                Console.Write(match.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
