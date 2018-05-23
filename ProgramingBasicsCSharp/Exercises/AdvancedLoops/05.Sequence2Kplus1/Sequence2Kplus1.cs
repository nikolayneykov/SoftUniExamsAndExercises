using System;

namespace _05.Sequence2Kplus1
{
    class Sequence2Kplus1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberToPrint = 1;
            while (numberToPrint <= n)
            {
                Console.WriteLine(numberToPrint);
                numberToPrint *= 2;
                numberToPrint++;
            }
        }
    }
}
