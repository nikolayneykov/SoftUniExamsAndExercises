using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double yuan = double.Parse(Console.ReadLine());
            double commissionPercent = double.Parse(Console.ReadLine());

            double bitcoinToLev = bitcoin * 1168;
            double yuanToUsd = yuan * 0.15;
            double usdToLev = yuanToUsd * 1.76;

            double totalLev = bitcoinToLev + usdToLev;
            double LevToEur = (totalLev / 1.95) - ((totalLev / 1.95)*commissionPercent)/100;
            Console.WriteLine("{0:F2}",LevToEur);
        }
    }
}
