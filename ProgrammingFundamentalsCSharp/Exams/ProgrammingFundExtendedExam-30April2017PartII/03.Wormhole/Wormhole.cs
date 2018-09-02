using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wormhole
{
    class Wormhole
    {
        static void Main(string[] args)
        {
            int[] numSequence = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int index = 0;
            int counter = 0;

            while (index < numSequence.Length)
            {            
                if (numSequence[index] == 0)
                {
                    index++;
                    counter++;
                }
                else
                {
                    int newIndex = numSequence[index];
                    numSequence[index] = 0;
                    index = newIndex;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
