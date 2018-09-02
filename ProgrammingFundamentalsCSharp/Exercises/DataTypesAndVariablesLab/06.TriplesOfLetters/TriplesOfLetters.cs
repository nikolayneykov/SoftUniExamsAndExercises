using System;

namespace _06.TriplesOfLetters
{
    class TriplesOfLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (char i = 'a'; i < 'a' + n; i++)
                for (char i2 = 'a'; i2 < 'a' + n; i2++)
                    for (char i3 = 'a'; i3 < 'a' + n; i3++)
                    {
                        Console.WriteLine($"{i}{i2}{i3}");
                    }
        }
    }
}
