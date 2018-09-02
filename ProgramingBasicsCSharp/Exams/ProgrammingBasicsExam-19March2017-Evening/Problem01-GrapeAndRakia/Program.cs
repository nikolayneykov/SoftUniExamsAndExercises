using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_GrapeAndRakia
{
    class Program
    {
        static void Main(string[] args)
        {
            double fieldArea = double.Parse(Console.ReadLine());
            double grapePerMSqrt = double.Parse(Console.ReadLine());
            double scrap = double.Parse(Console.ReadLine());

            double totalGrape = fieldArea * grapePerMSqrt - scrap;

            double rakiaLiters = (totalGrape * 0.45) / 7.5;
            double grapeForSell = totalGrape * 0.55;

            double rakiaProfit = rakiaLiters * 9.8;
            double grapeProfit = grapeForSell * 1.5;

            Console.WriteLine("{0:F2}",rakiaProfit);
            Console.WriteLine("{0:F2}",grapeProfit);
        }
    }
}
