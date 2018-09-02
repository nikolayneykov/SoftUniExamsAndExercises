using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.AnonymousVox
{
    class AnonymousVox
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            Regex regEncodedText = new Regex(@"([a-zA-Z]+)(.+)\1");
            MatchCollection matches = regEncodedText.Matches(input.ToString());
            StringBuilder newText = new StringBuilder();
            string[] placeholders = Console.ReadLine()
                .Split(new[] { '{', '}' },
                StringSplitOptions.RemoveEmptyEntries);
            int index = 0;
            foreach (Match match in matches)
            {
                if (index < placeholders.Length)
                {
                    newText.Append(match.Groups[0].Value.Replace(match.Groups[2].Value, placeholders[index]));
                    input.Replace(match.Groups[0].Value,newText.ToString());
                }
                else
                {
                    break;
                }
                index++;
                newText.Clear();
            }
            Console.WriteLine(input);
        }
    }
}
