using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _03.MatchHexadecimalNumbers
{
    class MatchHexadecimalNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex reg = new Regex(@"\b(0x)?[0-9A-F]+\b");
            MatchCollection matches = reg.Matches(input);
            string[] result = matches
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
