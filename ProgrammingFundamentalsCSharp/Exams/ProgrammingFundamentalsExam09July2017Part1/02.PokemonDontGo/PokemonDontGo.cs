using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PokemonDontGo
{
    class PokemonDontGo
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int sumOfRemoved = 0;
            while (sequence.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int valueToCompare = 0;
                if (index < 0)
                {
                    valueToCompare = sequence[0];
                    sumOfRemoved += valueToCompare;
                    sequence[0] = sequence[sequence.Count - 1];
                }
                else if (index > sequence.Count - 1)
                {
                    valueToCompare = sequence[sequence.Count - 1];
                    sumOfRemoved += valueToCompare;
                    sequence[sequence.Count - 1] = sequence[0];
                }
                else
                {
                    valueToCompare = sequence[index];
                    sumOfRemoved += valueToCompare;
                    sequence.RemoveAt(index);
                }
                sequence = ModifySequence(sequence, valueToCompare);
            }
            Console.WriteLine(sumOfRemoved);
        }
        static List<int> ModifySequence(List<int> sequence, int valueToCompare)
        {
            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] <= valueToCompare)
                {
                    sequence[i] += valueToCompare;
                }
                else if (sequence[i] > valueToCompare)
                {
                    sequence[i] -= valueToCompare;
                }
            }
            return sequence;
        }
    }
}
