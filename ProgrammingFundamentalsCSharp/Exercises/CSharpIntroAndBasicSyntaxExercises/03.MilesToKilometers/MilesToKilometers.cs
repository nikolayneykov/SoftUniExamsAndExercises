using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double kilometers = miles * 1.60934;
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
