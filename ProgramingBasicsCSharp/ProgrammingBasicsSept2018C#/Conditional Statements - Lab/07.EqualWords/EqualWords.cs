using System;

class EqualWords
{
    static void Main(string[] args)
    {
        string firstWord = Console.ReadLine().ToLower();
        string secondWord = Console.ReadLine().ToLower();
        Console.WriteLine(firstWord.Equals(secondWord) ? "yes" : "no");
    }
}

