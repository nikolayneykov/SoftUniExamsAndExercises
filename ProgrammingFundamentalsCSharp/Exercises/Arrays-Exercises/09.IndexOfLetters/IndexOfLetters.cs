using System;

namespace _09.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            foreach (char letter in word)
            {
                Console.WriteLine($"{letter} -> {letter-'a'}");
            }
        }
    }
}
