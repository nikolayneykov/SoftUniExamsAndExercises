using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            double unitValue = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();
            double meters = 0;
            double outputValue = 0;
            switch (inputUnit)
            {
                case "mm":meters = unitValue / 1000;break;
                case "cm":meters = unitValue / 100;break;
                case "mi":meters = unitValue / 0.000621371192; break;
                case "in":meters = unitValue / 39.3700787; break;
                case "km":meters = unitValue / 0.001; break;
                case "ft":meters = unitValue / 3.2808399; break;
                case "yd":meters = unitValue / 1.0936133; break;
                default:meters = unitValue;break;
            }
            switch (outputUnit)
            {
                case "mm": outputValue = meters * 1000; break;
                case "cm": outputValue = meters * 100; break;
                case "mi": outputValue = meters * 0.000621371192; break;
                case "in": outputValue = meters * 39.3700787; break;
                case "km": outputValue = meters * 0.001; break;
                case "ft": outputValue = meters * 3.2808399; break;
                case "yd": outputValue = meters * 1.0936133; break;
                default:outputValue = meters; break;
            }
            Console.WriteLine($"{outputValue:F8}");

        }
    }
}
