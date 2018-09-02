using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача2_Фирма
{
    class Program
    {
        static void Main(string[] args)
        {
            int requiredHours = int.Parse(Console.ReadLine());
            int daysAvailable = int.Parse(Console.ReadLine());
            int extraWorkers = int.Parse(Console.ReadLine());

            double educationDays = daysAvailable * 0.1;
            double daysLeft = daysAvailable - educationDays;
            double workingHours = daysLeft * 8;
            double extraWorkingHours = extraWorkers * 2 * daysAvailable;
            double totalWorkingHours = Math.Floor(workingHours + extraWorkingHours);
            if (totalWorkingHours < requiredHours)
            {
                Console.WriteLine("Not enough time!{0} hours needed.", requiredHours - totalWorkingHours);
            }
            else
            {
                Console.WriteLine("Yes!{0} hours left.", totalWorkingHours - requiredHours);
            }
        }
    }
}
