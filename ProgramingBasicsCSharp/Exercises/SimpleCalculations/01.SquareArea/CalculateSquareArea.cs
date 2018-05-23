using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareArea
{
    class CalculateSquareArea
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            int squareArea = a * a;
            Console.WriteLine($"Square = {squareArea}");
        }
    }
}
