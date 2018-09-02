using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DiamondProblem
{
    class DiamondProblem
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int startIndex = input.IndexOf("<");
            int endIndex = input.IndexOf(">", startIndex+1);
            bool foundDiamonds = false;
            while (startIndex != -1 && endIndex != -1)
            {
                foundDiamonds = true;
                string diamond = input.Substring(startIndex, endIndex - startIndex+1);
                PrintCarats(diamond);
                startIndex = input.IndexOf("<", endIndex);
                endIndex = input.IndexOf(">", startIndex + 1);
            }
            if (!foundDiamonds)
            {
                Console.WriteLine("Better luck next time");
            }
        }
        static void PrintCarats(string diamond)
        {
            int carats = 0;
            for (int i = 0; i < diamond.Length; i++)
            {
                char currentChar = diamond[i];
                if (char.IsDigit(currentChar))
                {
                    carats += currentChar - '0';
                }
            }
            Console.WriteLine($"Found {carats} carat diamond");
        }
    }
}
