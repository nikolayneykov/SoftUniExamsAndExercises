using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _05.MatchNumbers
{
    class MatchNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex reg = new Regex(@"(^|(?<=\s))(-?\d+)(\.\d+)?($|(?=\s))");
            MatchCollection matches = reg.Matches(input);
            string[] result = matches
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
