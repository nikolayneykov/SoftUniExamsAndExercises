using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double electricty = 0;
            for (int i = 0; i < months; i++)
            {
                electricty += double.Parse(Console.ReadLine());
            }
            double water = 20 * months;
            double internet = 15 * months;
            double other = (electricty + water + internet) + 
                (electricty + water + internet) * 0.2;
            double average = (electricty + water + internet + other) / months;

            Console.WriteLine("Electricity: {0:F2} lv",electricty);
            Console.WriteLine("Water: {0:F2} lv", water);
            Console.WriteLine("Internet: {0:F2} lv", internet);
            Console.WriteLine("Other: {0:F2} lv", other);
            Console.WriteLine("Average: {0:F2} lv", average);
        }
    }
}
