using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    oddSum += number;
                    oddMin = number < oddMin ? number : oddMin;
                    oddMax = number > oddMax ? number : oddMax;
                }
                else
                {
                    evenSum += number;
                    evenMin = number < evenMin ? number : evenMin;
                    evenMax = number > evenMax ? number : evenMax;
                }
            }
            Console.WriteLine($"OddSum={oddSum},");
            Console.WriteLine(oddMin != double.MaxValue ? $"OddMin={oddMin}," : "OddMin=No,");
            Console.WriteLine(oddMax != double.MinValue ? $"OddMax={oddMax}," : "OddMax=No,");
            Console.WriteLine($"EvenSum={evenSum},");
            Console.WriteLine(evenMin!= double.MaxValue? $"EvenMin={evenMin},":"EvenMin=No,");
            Console.WriteLine(evenMax!= double.MinValue? $"EvenMax={evenMax},":"EvenMax=No");
        }
    }
}
