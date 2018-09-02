using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(":,;:.!()\"\'\\/[] ".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries);
            List<string> lowerCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();
            foreach (string word in text)
            {
                if (word.All(x => char.IsLower(x)))
                {
                    lowerCaseWords.Add(word);
                }
                else if (word.All(x => char.IsUpper(x)))
                {
                    upperCaseWords.Add(word);
                }
                else
                {
                    mixedCaseWords.Add(word);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseWords)}");
        }
    }
}
