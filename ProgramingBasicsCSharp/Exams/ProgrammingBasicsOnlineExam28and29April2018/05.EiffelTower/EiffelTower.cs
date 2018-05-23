using System;

namespace _05.EiffelTower
{
    class EiffelTower
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('-', n + 2) + "**" + new string('-', n + 2));
            }
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine(new string('-', n + 1) + "****" + new string('-', n + 1));
            }
            Console.WriteLine(new string('-', n) + "******" + new string('-', n));
            for (int i = 0; i < n - 4; i++)
            {
                Console.WriteLine(new string('-', n) + "**--**" + new string('-', n));
            }
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine(new string('-', n - 1) + "**----**" + new string('-', n - 1));
            }
            Console.WriteLine(new string('-', n - 2) + "**********" + new string('-', n - 2));
            int midCnt = 0;

            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine(new string('-', n - 3 - i) + "**" + new string('-', 8 + midCnt) + "**" + new string('-', n - 3 - i));
                midCnt += 2;
            }
            Console.WriteLine("***" + new string('-', n * 2) + "***");

        }
    }
}
