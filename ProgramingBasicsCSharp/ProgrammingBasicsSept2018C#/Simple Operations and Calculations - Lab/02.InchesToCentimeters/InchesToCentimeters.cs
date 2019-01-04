using System;

namespace _02.InchesToCentimeters
{
    class InchesToCentimeters
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double centimeters = inches * 2.54d;
            Console.WriteLine(centimeters);
        }
    }
}
