using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _02.MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex reg = new Regex(@"\+359(\s|-)2\1\d{3}\1\d{4}\b");
            MatchCollection phoneMatches = reg.Matches(input);

            string[] result = phoneMatches
                .Cast<Match>()
                .Select(p => p.Value)
                .ToArray();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
