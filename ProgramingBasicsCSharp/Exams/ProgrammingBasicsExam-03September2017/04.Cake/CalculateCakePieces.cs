using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Cake
{
    class CalculateCakePieces
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());
            int cakePieces = cakeWidth * cakeLength;
            string takePieces = string.Empty;

            while ((takePieces = Console.ReadLine()) != "STOP" && cakePieces >= 0)
            {
                int pieces = int.Parse(takePieces);
                cakePieces -= pieces;
            }
            Console.WriteLine(cakePieces >= 0 ?
                $"{cakePieces} pieces are left." :
                $"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
        }
    }
}
