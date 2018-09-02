using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal mackerelPricePerKg = decimal.Parse(Console.ReadLine());
            decimal spratPricePerKg = decimal.Parse(Console.ReadLine());
            decimal bonitoKg = decimal.Parse(Console.ReadLine());
            decimal horseMackerelKg = decimal.Parse(Console.ReadLine());
            decimal musselsKg = decimal.Parse(Console.ReadLine());

            decimal sum = ((mackerelPricePerKg * 0.6m + mackerelPricePerKg) * bonitoKg) +
                         ((spratPricePerKg * 0.8m + spratPricePerKg) * horseMackerelKg) +
                         (musselsKg * 7.5m);
            Console.WriteLine("{0:F2}",sum);
        }
    }
}
