using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02.Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] gamefield = input
                .Take(input.Length - 1)
                .ToArray();
            int currentIndex = input[input.Length - 1];
            int stepCount = 0;
            while (true)
            {
                gamefield = gamefield
                    .Select(x => x -= 1)
                    .ToArray();
                if (gamefield[currentIndex] == 0)
                {
                    Console.WriteLine(string.Join(" ", gamefield));
                    Console.WriteLine(stepCount);
                    break;
                }
                gamefield = gamefield
                    .Select((x, i) => x = x == 0 ? input[i] : x)
                    .ToArray();
                currentIndex = int.Parse(Console.ReadLine());
                stepCount++;
            }
        }
    }
}
