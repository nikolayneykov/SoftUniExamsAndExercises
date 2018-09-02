using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.WormIpsum
{
    class WormIpsum
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Worm Ipsum")
            {
                Regex validSentencePattern = new Regex(@"^[A-Z][^\.]*\.$");
                StringBuilder encryptedSentence = new StringBuilder(input);
                if (validSentencePattern.IsMatch(input))
                {
                    string[] words = input.Split(new char[] { ' ', ',', '.' },
                        StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < words.Length; i++)
                    {
                        string word = words[i];
                        string encryptedWord = EncryptWord(word);
                        encryptedSentence.Replace(word, encryptedWord);
                    }
                    Console.WriteLine(encryptedSentence);
                }
            }
        }
        static string EncryptWord(string word)
        {
            char[] uniqueCharacters = word.ToCharArray().Distinct().ToArray();
            int mostRepeatCount = 0;
            char mostRepeatChar = word[0];
            for (int i = 0; i < uniqueCharacters.Length; i++)
            {
                char tempChar = uniqueCharacters[i];
                int tempRepeatCount = 0;
                for (int j = 0; j < word.Length; j++)
                {
                    if (tempChar == word[j])
                    {
                        tempRepeatCount++;
                        if (tempRepeatCount > mostRepeatCount)
                        {
                            mostRepeatChar = tempChar;
                            mostRepeatCount = tempRepeatCount;
                        }
                    }
                }
            }
            string encryptedWord = word;
            if (mostRepeatCount >= 2)
            {
                encryptedWord = new string(mostRepeatChar, word.Length);
            }
            return encryptedWord;
        }
    }
}
