using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double dog = double.Parse(Console.ReadLine());
            double cat = double.Parse(Console.ReadLine());
            double turtle = double.Parse(Console.ReadLine())/1000;
            double consumed = days * (dog + cat + turtle);
            
            if (consumed>food)
            {
                Console.WriteLine("{0} more kilos of food are needed.",Math.Ceiling( consumed-food));
            }
            else
            {
                Console.WriteLine("{0} kilos of food left.",Math.Floor( food-consumed));
            }

        }
    }
}
