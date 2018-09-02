using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            StringBuilder textToRepeat = new StringBuilder();
            StringBuilder timesToRepeat = new StringBuilder();
            int index = 0;
            while (index<input.Length)
            {
                char currentChar = input[index];
                while (!char.IsDigit(currentChar))
                {
                    textToRepeat.Append(currentChar);
                    index++;
                    if (index > input.Length - 1)
                    {
                        break;
                    }
                    currentChar = input[index];
                }  
                while (char.IsDigit(currentChar))
                {
                    timesToRepeat.Append(currentChar);
                    index++;
                    if (index > input.Length - 1)
                    {
                        break;
                    }
                    currentChar = input[index];
                }
                int repeatCount = int.Parse(timesToRepeat.ToString());
                for (int j = 0; j < repeatCount; j++)
                {
                    result.Append(textToRepeat.ToString().ToUpper());
                }
                textToRepeat.Clear();
                timesToRepeat.Clear();
            }
            int uniqueSymbolsCount = result
               .ToString()
               .ToCharArray()
               .Distinct()
               .Count();
            Console.WriteLine($"Unique symbols used: {uniqueSymbolsCount}");
            Console.WriteLine(result);
        }
    }
}
