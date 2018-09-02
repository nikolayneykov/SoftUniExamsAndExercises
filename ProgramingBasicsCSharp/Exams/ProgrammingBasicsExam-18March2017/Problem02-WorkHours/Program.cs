using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_WorkHours
{
    class Program
    {
        static void Main(string[] args)
        {
            long hoursNeeded = long.Parse(Console.ReadLine());
            long workers = long.Parse(Console.ReadLine());
            long workingDays = long.Parse(Console.ReadLine());

            long workingHours = workers * workingDays * 8;
            if (hoursNeeded>workingHours)
            {
                Console.WriteLine("{0} overtime",hoursNeeded-workingHours);
                Console.WriteLine("Penalties: {0}",(hoursNeeded-workingHours)*workingDays);
            }
            else
            {
                Console.WriteLine("{0} hours left",workingHours-hoursNeeded);
            }
        }
    }
}
