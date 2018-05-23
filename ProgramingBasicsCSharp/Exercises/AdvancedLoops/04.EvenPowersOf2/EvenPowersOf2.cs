using System;

namespace _04.EvenPowersOf2
{
    class EvenPowersOf2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberToPrint = 1;
            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(numberToPrint);
                numberToPrint *= 4;
            }
        }
    }
}
