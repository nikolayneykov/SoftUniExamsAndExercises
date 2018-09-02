using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            int cupsNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            int workHours = workers * workDays * 8;
            double createdCups = Math.Floor(workHours / 5.0);

            if (createdCups<cupsNeeded)
            {
                double losses = (cupsNeeded - createdCups) * 4.2;
                Console.WriteLine("Losses: {0:F2}",losses);
            }
            else
            {
                double extraMoney = (createdCups - cupsNeeded) * 4.2;
                Console.WriteLine("{0:F2} extra money", extraMoney);
            }
        }
    }
}
