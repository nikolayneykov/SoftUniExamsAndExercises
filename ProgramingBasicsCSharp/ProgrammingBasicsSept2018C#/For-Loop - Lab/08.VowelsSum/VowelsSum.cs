using System;
using System.Collections.Generic;

class VowelsSum
{
    static void Main(string[] args)
    {
        Dictionary<char, int> vowels = new Dictionary<char, int>()
        {
            ['a'] = 1,
            ['e'] = 2,
            ['i'] = 3,
            ['o'] = 4,
            ['u'] = 5,
        };
        int sum = 0;
        string text = Console.ReadLine();
        for (int i = 0; i < text.Length; i++)
        {
            if (vowels.ContainsKey(text[i]))
            {
                sum += vowels[text[i]];
            }
        }
        Console.WriteLine(sum);
    }
}

