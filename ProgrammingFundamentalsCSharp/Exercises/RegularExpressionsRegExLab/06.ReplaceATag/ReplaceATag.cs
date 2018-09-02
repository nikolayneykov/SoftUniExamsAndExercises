using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.ReplaceATag
{
    class ReplaceATag
    {
        static void Main(string[] args)
        {
            List<string> result = new List<string>();
            string input;
            while ((input=Console.ReadLine())!="end")
            {
                Regex reg = new Regex(@"<a\s?href=(.*?)>(.*?)<\/a>");
                if (reg.IsMatch(input))
                {                   
                    string replacement = @"[URL href=$1]$2[/URL]";
                    input = reg.Replace(input, replacement);
                }
                result.Add(input);
            }
            Console.WriteLine(string.Join(Environment.NewLine,result));
        }
    }
}
