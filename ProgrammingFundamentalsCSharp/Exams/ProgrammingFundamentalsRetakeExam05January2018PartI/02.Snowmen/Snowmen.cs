using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Snowmen
{
    class Snowmen
    {
        static void Main(string[] args)
        { 
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            while (input.Count > 1)
            {
                List<int> deadIndexes = new List<int>();

                for (int attackerIndex = 0; attackerIndex < input.Count; attackerIndex++)
                {
                    if (!deadIndexes.Contains(attackerIndex) &&
                        deadIndexes.Count < input.Count - 1)
                    {
                        int targetIndex = input[attackerIndex] % input.Count;
                        int diff = Math.Abs(attackerIndex - targetIndex);
                        if (targetIndex == attackerIndex)
                        {
                            if (!deadIndexes.Contains(attackerIndex))
                            {
                                deadIndexes.Add(attackerIndex);
                            }
                            Console.WriteLine($"{attackerIndex} performed harakiri");
                        }
                        else if (diff % 2 == 0)
                        {
                            if (!deadIndexes.Contains(targetIndex))
                            {
                                deadIndexes.Add(targetIndex);
                            }
                            Console.WriteLine($"{attackerIndex} x {targetIndex} -> {attackerIndex} wins");
                        }
                        else
                        {
                            if (!deadIndexes.Contains(attackerIndex))
                            {
                                deadIndexes.Add(attackerIndex);
                            }
                            Console.WriteLine($"{attackerIndex} x {targetIndex} -> {targetIndex} wins");
                        }
                    }
                }              
                for (int i = 0; i < deadIndexes.Count; i++)
                {
                    int indexToRemove = deadIndexes[i];
                    input[indexToRemove] = -1;
                }
                input.RemoveAll(x => x == -1);
            }
        }
    }
}
