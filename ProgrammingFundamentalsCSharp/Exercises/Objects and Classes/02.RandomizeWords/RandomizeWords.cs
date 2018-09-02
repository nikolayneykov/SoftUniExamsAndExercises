using System;

namespace _02.RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            { 
                int index = rnd.Next(0, words.Length - 1);
                string word = words[i];
                words[i] = words[index];
                words[index] = word;
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
