using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.MatchDates
{
    class MatchDates
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex reg = new Regex(@"\b(?<day>\d{2})(\/|-|\.)(?<month>\w{3})\1(?<year>\d{4})\b");
            MatchCollection result = reg.Matches(input);
            foreach (Match date in result)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
