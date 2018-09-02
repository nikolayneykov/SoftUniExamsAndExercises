using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            int firstTimeInMinutes = int.Parse(Console.ReadLine());
            int secondTimeInMinutes = int.Parse(Console.ReadLine());
            int thirdTimeInMinutes = int.Parse(Console.ReadLine());

            double firstTimeInHours = firstTimeInMinutes / 60.0;
            double secondTimeInHours = secondTimeInMinutes / 60.0;
            double thirdTimeInHours = thirdTimeInMinutes / 60.0;

            double distance = firstTimeInHours * speed;
            speed += speed * 0.1;
            distance += secondTimeInHours * speed;
            speed -= speed * 0.05;
            distance += thirdTimeInHours * speed;
            Console.WriteLine("{0:F2}", distance);
        }
    }
}
