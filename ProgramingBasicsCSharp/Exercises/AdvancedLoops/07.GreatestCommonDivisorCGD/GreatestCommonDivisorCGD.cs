using System;

namespace _07.GreatestCommonDivisorCGD
{
    class GreatestCommonDivisorCGD
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            Console.WriteLine(a);
        }
    }
}
