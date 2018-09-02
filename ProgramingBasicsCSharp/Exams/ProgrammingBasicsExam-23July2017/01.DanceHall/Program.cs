using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallLength = double.Parse(Console.ReadLine())*100;
            double hallWidth = double.Parse(Console.ReadLine())*100;
            double wardrobeSide = double.Parse(Console.ReadLine())*100;

            double hallArea = hallLength * hallWidth;
            double benchArea = hallArea * 0.1;
            double wardrobeArea = wardrobeSide * wardrobeSide;
            double dancerArea = 7040;

            double freeHallArea = hallArea - benchArea - wardrobeArea;
            double dancers =Math.Floor( freeHallArea / dancerArea);
            Console.WriteLine(dancers);
        }
    }
}
