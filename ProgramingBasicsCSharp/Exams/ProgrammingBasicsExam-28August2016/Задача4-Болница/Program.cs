using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача4_Болница
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int treated = 0;
            int untreated = 0;
            int doctors = 7;
            for (int i = 1; i <= period; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                if (i%3==0 && untreated>treated)
                {
                    doctors++;
                }
                if (patients<=doctors)
                {
                    treated += patients;
                }
                else
                {
                    treated += doctors;
                    untreated += patients - doctors;
                }
            }
            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", untreated);
        }
    }
}
