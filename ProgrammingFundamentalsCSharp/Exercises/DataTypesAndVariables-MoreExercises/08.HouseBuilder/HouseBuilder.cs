using System;
using System.Numerics;

namespace _08.HouseBuilder
{
    class HouseBuilder
    {
        static void Main(string[] args)
        {
            BigInteger num1 = BigInteger.Parse(Console.ReadLine());
            BigInteger num2 = BigInteger.Parse(Console.ReadLine());
            BigInteger totalPrice = 0;
            if (num1 <= 127)
            {
                totalPrice = 4 * num1 + 10 * num2;
            }
            else
            {
                totalPrice = 4 * num2 + 10 * num1;
            }

            Console.WriteLine(totalPrice);
        }
    }
}
