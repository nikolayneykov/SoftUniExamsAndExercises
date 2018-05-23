using System;

namespace _05.SublimeLogo
{
    class SublimeLogo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n;

            for (int i = 2; i <= 2 * n; i += 2)
            {
                Console.WriteLine(new string(' ', width - i) + new string('*', i));
            }
            Console.WriteLine(new string('*', width - 2));
            Console.WriteLine(new string('*', width - 4));
            Console.WriteLine(new string('*', width - 2));
            Console.WriteLine(new string('*', width));
            Console.WriteLine(new string(' ', 2) + new string('*', width - 2));
            Console.WriteLine(new string(' ', 4) + new string('*', width - 4));
            Console.WriteLine(new string(' ', 2) + new string('*', width - 2));
            for (int i = width; i >= 2; i -= 2)
            {
                Console.WriteLine(new string('*', i));
            }
        }
    }
}
