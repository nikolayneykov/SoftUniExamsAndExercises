using System;

namespace _12.Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f0 = 1;
            int f1 = 1;
            for (int i = 0; i < n-1; i++)
            {
                int temp = f1;
                f1 += f0;
                f0 = temp;
            }
            Console.WriteLine(f1);
        }
    }
}
