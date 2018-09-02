using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CapitalizeWords
{
    class CapitalizeWords
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] sentences = input
                        .Split(new[] { ' ', '.', ',', ':', ';', '?', '!', '-', '_' },
                        StringSplitOptions.RemoveEmptyEntries);
                sentences = Capitalize(sentences);
                Console.WriteLine(string.Join(", ", sentences));
            }
        }
        static string[] Capitalize(string[] sentences)
        {
            for (int i = 0; i < sentences.Length; i++)
            {
                string currentWord = sentences[i].ToLower();
                string firstLetter = currentWord[0].ToString().ToUpper();
                string capitalizedWord = firstLetter + (currentWord.Substring(1));
                sentences[i] = capitalizedWord;
            }
            return sentences;
        }
    }
}
