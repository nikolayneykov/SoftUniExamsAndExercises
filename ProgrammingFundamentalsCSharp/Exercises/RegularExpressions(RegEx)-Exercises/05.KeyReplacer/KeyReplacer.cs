using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.KeyReplacer
{
    class KeyReplacer
    {
        static void Main(string[] args)
        {
            Regex regKeys = new Regex(@"^([^\|\<\\]+).*?([^\|\<\\]+)$");
            string keys = Console.ReadLine();
            string startKey = regKeys.Match(keys).Groups[1].Value;
            string endKey = regKeys.Match(keys).Groups[2].Value;
            Regex regText = new Regex($@"{startKey}(.*?){endKey}");
            string text = Console.ReadLine();
            MatchCollection matches = regText.Matches(text);
            StringBuilder result = new StringBuilder();
            foreach (Match match in matches)
            {
                result.Append(match.Groups[1].Value);
            }
            Console.WriteLine(result.Length > 0 ? result.ToString(): "Empty result");
        }
    }
}
