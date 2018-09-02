using System;

class Censorship
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();
        string replacement = new string('*', word.Length);
        string sentence = Console.ReadLine().Replace(word, replacement);
        Console.WriteLine(sentence);
    }
}