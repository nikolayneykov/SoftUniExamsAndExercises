using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChooseADrink2._0
{
    class ChooseADrink2
    {
        static void Main(string[] args)
        {
            string proffesion = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            switch (proffesion)
            {
                case "Athlete": Console.WriteLine($"The {proffesion} has to pay {number*0.7:F2}."); break;
                case "Businessman":
                case "Businesswoman": Console.WriteLine($"The {proffesion} has to pay {number * 1.0:F2}."); break;
                case "SoftUni Student": Console.WriteLine($"The {proffesion} has to pay {number * 1.7:F2}."); break;
                default: Console.WriteLine($"The {proffesion} has to pay {number * 1.2:F2}."); break;
            }
        }
    }
}
