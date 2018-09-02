using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Placeholders
{
    class Placeholders
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputTokens = input
               .Split(new string[] { " -> " },
               StringSplitOptions.RemoveEmptyEntries);
                string text = inputTokens[0];
                string[] values = inputTokens[1]
                    .Split(new string[] { ", " },
                    StringSplitOptions.RemoveEmptyEntries);
                text = PlaceHolderReplace(text, values);
                Console.WriteLine(text);
            }

        }
        static string PlaceHolderReplace(string text, string[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                text = text.Replace($"{{{i}}}", values[i]);
            }
            return text;
        }
    }
}
