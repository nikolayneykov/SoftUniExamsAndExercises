using System;

namespace _03.PowersOfTwo
{
    class PowersOfTwo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberToPrint = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(numberToPrint);
                numberToPrint *= 2;
            }
        }
    }
}
