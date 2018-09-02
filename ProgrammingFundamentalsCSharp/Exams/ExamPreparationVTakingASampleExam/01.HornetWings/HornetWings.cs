using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HornetWings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distancePer1000WingFlaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());
            
            double distance = (wingFlaps / 1000.0) * distancePer1000WingFlaps;
            Console.WriteLine($"{distance:F2} m.");

            int flyTime = wingFlaps / 100;
            int restTime = (wingFlaps / endurance) * 5;
            flyTime += restTime;
            Console.WriteLine($"{flyTime} s.");
        }
    }
}
