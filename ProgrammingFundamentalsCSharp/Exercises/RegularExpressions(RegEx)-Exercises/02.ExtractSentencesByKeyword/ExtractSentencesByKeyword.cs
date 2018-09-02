using System;
using System.Linq;

namespace _02.ExtractSentencesByKeyword
{
    class ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] sentences = Console.ReadLine()
                .Split(new[] { '.', '!', '?' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            foreach (string sentence in sentences)
            {
                string[] sentenceTokens = sentence.Split(" -,:;()`~|\'\"*&^%$#@{}[]/\\".ToCharArray());
                if (sentenceTokens.Contains(word))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }

        }
    }
}
