using System;

namespace _04.TouristInformation
{
    class TouristInformation
    {
        static void Main(string[] args)
        {
            string imperialMeasurement = Console.ReadLine();
            double imperialValue = double.Parse(Console.ReadLine());
            string metricMeasurement = string.Empty;
            double metricValue = 0;
            switch (imperialMeasurement)
            {
                case "miles":
                    metricMeasurement = "kilometers";
                    metricValue = imperialValue * 1.6;
                    break;
                case "inches":
                    metricMeasurement = "centimeters";
                    metricValue = imperialValue * 2.54;
                    break;
                case "feet":
                    metricMeasurement = "centimeters";
                    metricValue = imperialValue * 30;
                    break;
                case "yards":
                    metricMeasurement = "meters";
                    metricValue = imperialValue * 0.91;
                    break;
                case "gallons":
                    metricMeasurement = "liters";
                    metricValue = imperialValue * 3.8;
                    break;
            }
            Console.WriteLine($"{imperialValue} {imperialMeasurement} = {metricValue:F2} {metricMeasurement}");
        }
    }
}
