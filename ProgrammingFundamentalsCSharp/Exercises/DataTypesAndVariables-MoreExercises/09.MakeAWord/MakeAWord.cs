using System;
using System.Text;

namespace _09.MakeAWord
{
    class MakeAWord
    {
        static void Main(string[] args)
        {
            StringBuilder word = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                word.Append(Console.ReadLine());
            }
            Console.WriteLine($"The word is: {word}");
        }
    }
}
